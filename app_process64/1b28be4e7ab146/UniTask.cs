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

                /*0x7918fd0*/ AsyncMethodBuilderAttribute(System.Type builderType);
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

                /*0x7919000*/ int GetHashCode();
                /*0x7919008*/ bool Equals(Cysharp.Threading.Tasks.AsyncUnit other);
                /*0x7919010*/ string ToString();
            }

            class CancellationTokenExtensions
            {
                static /*0x0*/ System.Action<object> cancellationTokenCallback;
                static /*0x8*/ System.Action<object> disposeCallback;

                static /*0x7919508*/ CancellationTokenExtensions();
                static /*0x7919050*/ void Callback(object state);
                static /*0x79190dc*/ System.Threading.CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(System.Threading.CancellationToken cancellationToken, System.Action callback);
                static /*0x791927c*/ System.Threading.CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(System.Threading.CancellationToken cancellationToken, System.Action<object> callback, object state);
                static /*0x7919428*/ void DisposeCallback(object state);
            }

            class CancellationTokenSourceExtensions
            {
                static /*0x0*/ System.Action<object> CancelCancellationTokenSourceStateDelegate;

                static /*0x79197f8*/ CancellationTokenSourceExtensions();
                static /*0x79195ec*/ void CancelCancellationTokenSourceState(object state);
                static /*0x7919670*/ System.IDisposable CancelAfterSlim(System.Threading.CancellationTokenSource cts, int millisecondsDelay, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming);
                static /*0x7919724*/ System.IDisposable CancelAfterSlim(System.Threading.CancellationTokenSource cts, System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming);
            }

            class EnumerableAsyncExtensions
            {
                static /*0x38395d4*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> Select<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, Cysharp.Threading.Tasks.UniTask> selector);
                static /*0x38395d4*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask<TR>> Select<T, TR>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, Cysharp.Threading.Tasks.UniTask<TR>> selector);
                static /*0x38395d4*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> Select<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, int, Cysharp.Threading.Tasks.UniTask> selector);
                static /*0x38395d4*/ System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask<TR>> Select<T, TR>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, int, Cysharp.Threading.Tasks.UniTask<TR>> selector);
            }

            class EnumeratorAsyncExtensions
            {
                static /*0x7919898*/ Cysharp.Threading.Tasks.UniTask ToUniTask(System.Collections.IEnumerator enumerator, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);

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

                    static /*0x7919b44*/ EnumeratorPromise();
                    static /*0x7919960*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.Collections.IEnumerator innerEnumerator, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    static /*0x7919ebc*/ System.Collections.IEnumerator ConsumeEnumerator(System.Collections.IEnumerator enumerator);
                    static /*0x791a5d0*/ System.Collections.IEnumerator UnwrapWaitForSeconds(UnityEngine.WaitForSeconds waitForSeconds);
                    static /*0x791a664*/ System.Collections.IEnumerator UnwrapWaitAsyncOperation(UnityEngine.AsyncOperation asyncOperation);
                    /*0x7919e28*/ EnumeratorPromise();
                    /*0x7919b3c*/ ref Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise get_NextNode();
                    /*0x791a21c*/ void GetResult(short token);
                    /*0x791a2f4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x791a34c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x791a404*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7919f28*/ bool MoveNext();
                    /*0x791a474*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.EnumeratorAsyncExtensions.EnumeratorPromise.<> <>9;

                        static /*0x791a6f8*/ <>c();
                        /*0x791a760*/ <>c();
                        /*0x791a768*/ int <.cctor>b__4_0();
                    }

                    class <ConsumeEnumerator>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ System.Collections.IEnumerator enumerator;
                        /*0x28*/ UnityEngine.CustomYieldInstruction <cyi>5__2;
                        /*0x30*/ System.Collections.IEnumerator <innerCoroutine>5__3;

                        /*0x791a5a8*/ <ConsumeEnumerator>d__19(int <>1__state);
                        /*0x791a7cc*/ void System.IDisposable.Dispose();
                        /*0x791a7d0*/ bool MoveNext();
                        /*0x791ad4c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x791ad54*/ void System.Collections.IEnumerator.Reset();
                        /*0x791ad8c*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <UnwrapWaitAsyncOperation>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ UnityEngine.AsyncOperation asyncOperation;

                        /*0x791a6d0*/ <UnwrapWaitAsyncOperation>d__22(int <>1__state);
                        /*0x791ad94*/ void System.IDisposable.Dispose();
                        /*0x791ad98*/ bool MoveNext();
                        /*0x791adf4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x791adfc*/ void System.Collections.IEnumerator.Reset();
                        /*0x791ae34*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <UnwrapWaitForSeconds>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ UnityEngine.WaitForSeconds waitForSeconds;
                        /*0x28*/ float <second>5__2;
                        /*0x2c*/ float <elapsed>5__3;

                        /*0x791a63c*/ <UnwrapWaitForSeconds>d__21(int <>1__state);
                        /*0x791ae3c*/ void System.IDisposable.Dispose();
                        /*0x791ae40*/ bool MoveNext();
                        /*0x791af5c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x791af64*/ void System.Collections.IEnumerator.Reset();
                        /*0x791af9c*/ object System.Collections.IEnumerator.get_Current();
                    }
                }
            }

            interface IUniTaskAsyncEnumerable<T>
            {
                /*0x38148e8*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);
            }

            interface IUniTaskAsyncEnumerator<T> : Cysharp.Threading.Tasks.IUniTaskAsyncDisposable
            {
                /*0x3910ae8*/ T get_Current();
                /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
            }

            interface IUniTaskAsyncDisposable
            {
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
            }

            class UniTaskAsyncEnumerableExtensions
            {
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTaskCancelableAsyncEnumerable<T> WithCancellation<T>(Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> source, System.Threading.CancellationToken cancellationToken);
            }

            struct UniTaskCancelableAsyncEnumerable<T>
            {
                /*0x0*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> enumerable;
                /*0x0*/ System.Threading.CancellationToken cancellationToken;

                /*0x3910ae8*/ UniTaskCancelableAsyncEnumerable(Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> enumerable, System.Threading.CancellationToken cancellationToken);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTaskCancelableAsyncEnumerable.Enumerator<T> GetAsyncEnumerator();

                struct Enumerator<T>
                {
                    /*0x0*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> enumerator;

                    /*0x3816710*/ Enumerator(Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> enumerator);
                    /*0x3910ae8*/ T get_Current();
                    /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
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
                /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
            }

            interface IUniTaskSource<T> : Cysharp.Threading.Tasks.IUniTaskSource
            {
                /*0x3910ae8*/ T GetResult(short token);
            }

            class UniTaskStatusExtensions
            {
                static /*0x791afa4*/ bool IsCompleted(Cysharp.Threading.Tasks.UniTaskStatus status);
                static /*0x791afb0*/ bool IsCompletedSuccessfully(Cysharp.Threading.Tasks.UniTaskStatus status);
            }

            class MoveNextSource : Cysharp.Threading.Tasks.IUniTaskSource<bool>, Cysharp.Threading.Tasks.IUniTaskSource
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<bool> completionSource;

                /*0x791b1ec*/ MoveNextSource();
                /*0x791afbc*/ bool GetResult(short token);
                /*0x791b014*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x791b06c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x791b0dc*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x791b194*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
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
                /*0x3813ffc*/ bool MoveNext();
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

                static /*0x791d4b0*/ PlayerLoopHelper();
                static /*0x791b1f4*/ System.Threading.SynchronizationContext get_UnitySynchronizationContext();
                static /*0x791b24c*/ int get_MainThreadId();
                static /*0x791a528*/ bool get_IsMainThread();
                static /*0x791b2a4*/ UnityEngine.LowLevel.PlayerLoopSystem[] InsertRunner(UnityEngine.LowLevel.PlayerLoopSystem loopSystem, bool injectOnFirst, System.Type loopRunnerYieldType, Cysharp.Threading.Tasks.Internal.ContinuationQueue cq, System.Type loopRunnerType, Cysharp.Threading.Tasks.Internal.PlayerLoopRunner runner);
                static /*0x791b5d8*/ UnityEngine.LowLevel.PlayerLoopSystem[] RemoveRunner(UnityEngine.LowLevel.PlayerLoopSystem loopSystem, System.Type loopRunnerYieldType, System.Type loopRunnerType);
                static /*0x791b700*/ UnityEngine.LowLevel.PlayerLoopSystem[] InsertUniTaskSynchronizationContext(UnityEngine.LowLevel.PlayerLoopSystem loopSystem);
                static /*0x791baf4*/ void Init();
                static /*0x791c7bc*/ int FindLoopSystemIndex(UnityEngine.LowLevel.PlayerLoopSystem[] playerLoopList, System.Type systemType);
                static /*0x791c8d0*/ void InsertLoop(UnityEngine.LowLevel.PlayerLoopSystem[] copyList, Cysharp.Threading.Tasks.InjectPlayerLoopTimings injectTimings, System.Type loopType, Cysharp.Threading.Tasks.InjectPlayerLoopTimings targetTimings, int index, bool injectOnFirst, System.Type loopRunnerYieldType, System.Type loopRunnerType, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming);
                static /*0x791bcc0*/ void Initialize(ref UnityEngine.LowLevel.PlayerLoopSystem playerLoop, Cysharp.Threading.Tasks.InjectPlayerLoopTimings injectTimings);
                static /*0x791a17c*/ void AddAction(Cysharp.Threading.Tasks.PlayerLoopTiming timing, Cysharp.Threading.Tasks.IPlayerLoopItem action);
                static /*0x791cdbc*/ void ThrowInvalidLoopTiming(Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming);
                static /*0x791d164*/ void AddContinuation(Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Action continuation);

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.PlayerLoopHelper.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.LowLevel.PlayerLoopSystem, bool> <>9__21_0;
                    static /*0x10*/ System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__21_1;
                    static /*0x18*/ System.Predicate<UnityEngine.LowLevel.PlayerLoopSystem> <>9__21_2;

                    static /*0x791d570*/ <>c();
                    /*0x791d5d8*/ <>c();
                    /*0x791d5e0*/ bool <InsertUniTaskSynchronizationContext>b__21_0(UnityEngine.LowLevel.PlayerLoopSystem ls);
                    /*0x791d658*/ bool <InsertUniTaskSynchronizationContext>b__21_1(UnityEngine.LowLevel.PlayerLoopSystem x);
                    /*0x791d6b8*/ bool <InsertUniTaskSynchronizationContext>b__21_2(UnityEngine.LowLevel.PlayerLoopSystem x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ System.Type loopRunnerYieldType;
                    /*0x18*/ System.Type loopRunnerType;

                    /*0x791b6f8*/ <>c__DisplayClass20_0();
                    /*0x791d718*/ bool <RemoveRunner>b__0(UnityEngine.LowLevel.PlayerLoopSystem ls);
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

                static /*0x791d820*/ Cysharp.Threading.Tasks.PlayerLoopTimer Create(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                static /*0x79197d0*/ Cysharp.Threading.Tasks.PlayerLoopTimer StartNew(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x791d7a8*/ PlayerLoopTimer(bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x791db80*/ void Restart();
                /*0x3815b88*/ void ResetCore(System.Nullable<System.TimeSpan> newInterval);
                /*0x791dc4c*/ void Dispose();
                /*0x791dc58*/ bool Cysharp.Threading.Tasks.IPlayerLoopItem.MoveNext();
                /*0x3813ffc*/ bool MoveNextCore();
            }

            class DeltaTimePlayerLoopTimer : Cysharp.Threading.Tasks.PlayerLoopTimer
            {
                /*0x30*/ int initialFrame;
                /*0x34*/ float elapsed;
                /*0x38*/ float interval;

                /*0x791dac4*/ DeltaTimePlayerLoopTimer(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x791dd30*/ bool MoveNextCore();
                /*0x791dd9c*/ void ResetCore(System.Nullable<System.TimeSpan> interval);
            }

            class IgnoreTimeScalePlayerLoopTimer : Cysharp.Threading.Tasks.PlayerLoopTimer
            {
                /*0x30*/ int initialFrame;
                /*0x34*/ float elapsed;
                /*0x38*/ float interval;

                /*0x791d94c*/ IgnoreTimeScalePlayerLoopTimer(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x791de9c*/ bool MoveNextCore();
                /*0x791df08*/ void ResetCore(System.Nullable<System.TimeSpan> interval);
            }

            class RealtimePlayerLoopTimer : Cysharp.Threading.Tasks.PlayerLoopTimer
            {
                /*0x30*/ Cysharp.Threading.Tasks.Internal.ValueStopwatch stopwatch;
                /*0x38*/ long intervalTicks;

                /*0x791da08*/ RealtimePlayerLoopTimer(System.TimeSpan interval, bool periodic, Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken, System.Action<object> timerCallback, object state);
                /*0x791e008*/ bool MoveNextCore();
                /*0x791e174*/ void ResetCore(System.Nullable<System.TimeSpan> interval);
            }

            class TaskPool
            {
                static /*0x0*/ int MaxPoolSize;
                static /*0x8*/ System.Collections.Generic.Dictionary<System.Type, System.Func<int>> sizes;

                static /*0x791e298*/ TaskPool();
                static /*0x7919ce0*/ void RegisterSizeGetter(System.Type type, System.Func<int> getSize);
            }

            interface ITaskPoolNode<T>
            {
                /*0x38148bc*/ ref T get_NextNode();
            }

            struct TaskPool<T>
            {
                /*0x0*/ int gate;
                /*0x0*/ int size;
                /*0x0*/ T root;

                /*0x3814574*/ int get_Size();
                /*0x38141c4*/ bool TryPop(ref T result);
                /*0x3910ae8*/ bool TryPush(T item);
            }

            interface ITriggerHandler<T>
            {
                /*0x3910ae8*/ void OnNext(T value);
                /*0x38159dc*/ void OnCompleted();
                /*0x38148bc*/ Cysharp.Threading.Tasks.ITriggerHandler<T> get_Prev();
                /*0x3816710*/ void set_Prev(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                /*0x38148bc*/ Cysharp.Threading.Tasks.ITriggerHandler<T> get_Next();
                /*0x3816710*/ void set_Next(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
            }

            struct TriggerEvent<T>
            {
                /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> head;
                /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> iteratingHead;
                /*0x0*/ bool preserveRemoveSelf;
                /*0x0*/ Cysharp.Threading.Tasks.ITriggerHandler<T> iteratingNode;

                /*0x3816710*/ void LogError(System.Exception ex);
                /*0x3910ae8*/ void SetResult(T value);
                /*0x38159dc*/ void SetCompleted();
                /*0x3816710*/ void Add(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
                /*0x3816710*/ void Remove(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
            }

            class UniTaskCancellationExtensions
            {
                static /*0x791e3fc*/ System.Threading.CancellationToken GetCancellationTokenOnDestroy(UnityEngine.MonoBehaviour monoBehaviour);
            }

            struct UniTask
            {
                static /*0x0*/ Cysharp.Threading.Tasks.UniTask CanceledUniTask;
                static /*0x10*/ Cysharp.Threading.Tasks.UniTask CompletedTask;
                /*0x10*/ Cysharp.Threading.Tasks.IUniTaskSource source;
                /*0x18*/ short token;

                static /*0x7920e0c*/ UniTask();
                static /*0x791e848*/ Cysharp.Threading.Tasks.YieldAwaitable Yield();
                static /*0x791e850*/ Cysharp.Threading.Tasks.YieldAwaitable Yield(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                static /*0x791e858*/ Cysharp.Threading.Tasks.UniTask Yield(System.Threading.CancellationToken cancellationToken);
                static /*0x791ea6c*/ Cysharp.Threading.Tasks.UniTask NextFrame();
                static /*0x791ece0*/ Cysharp.Threading.Tasks.UniTask WaitForEndOfFrame(UnityEngine.MonoBehaviour coroutineRunner, System.Threading.CancellationToken cancellationToken);
                static /*0x791eee8*/ Cysharp.Threading.Tasks.UniTask DelayFrame(int delayFrameCount, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x791f1bc*/ Cysharp.Threading.Tasks.UniTask Delay(int millisecondsDelay, bool ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x791f270*/ Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, bool ignoreTimeScale, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x791f2ec*/ Cysharp.Threading.Tasks.UniTask Delay(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming delayTiming, System.Threading.CancellationToken cancellationToken);
                static /*0x791fadc*/ Cysharp.Threading.Tasks.UniTask FromException(System.Exception ex);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> FromException<T>(System.Exception ex);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> FromResult<T>(T value);
                static /*0x791fbcc*/ Cysharp.Threading.Tasks.UniTask FromCanceled(System.Threading.CancellationToken cancellationToken);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> FromCanceled<T>(System.Threading.CancellationToken cancellationToken);
                static /*0x791fd34*/ Cysharp.Threading.Tasks.UniTask Create(System.Func<Cysharp.Threading.Tasks.UniTask> factory);
                static /*0x791fd58*/ Cysharp.Threading.Tasks.UniTask Defer(System.Func<Cysharp.Threading.Tasks.UniTask> factory);
                static /*0x791fe0c*/ Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable SwitchToMainThread(System.Threading.CancellationToken cancellationToken);
                static /*0x791fe54*/ Cysharp.Threading.Tasks.UniTask WaitUntil(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);
                static /*0x7920098*/ Cysharp.Threading.Tasks.UniTask WaitWhile(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T[]> WhenAll<T>(Cysharp.Threading.Tasks.UniTask<T> tasks);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T[]> WhenAll<T>(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask<T>> tasks);
                static /*0x79202dc*/ Cysharp.Threading.Tasks.UniTask WhenAll(Cysharp.Threading.Tasks.UniTask[] tasks);
                static /*0x79207d4*/ Cysharp.Threading.Tasks.UniTask WhenAll(System.Collections.Generic.IEnumerable<Cysharp.Threading.Tasks.UniTask> tasks);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2>> WhenAll<T1, T2>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2, T3>> WhenAll<T1, T2, T3>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2, T3, T4>> WhenAll<T1, T2, T3, T4>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<T1, T2, T3, T4, T5, T6, T7>> WhenAll<T1, T2, T3, T4, T5, T6, T7>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4, Cysharp.Threading.Tasks.UniTask<T5> task5, Cysharp.Threading.Tasks.UniTask<T6> task6, Cysharp.Threading.Tasks.UniTask<T7> task7);
                static /*0x792092c*/ Cysharp.Threading.Tasks.UniTask<int> WhenAny(Cysharp.Threading.Tasks.UniTask[] tasks);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<int, T1, T2>> WhenAny<T1, T2>(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                /*0x791e410*/ UniTask(Cysharp.Threading.Tasks.IUniTaskSource source, short token);
                /*0x791e438*/ Cysharp.Threading.Tasks.UniTaskStatus get_Status();
                /*0x791e4ec*/ Cysharp.Threading.Tasks.UniTask.Awaiter GetAwaiter();
                /*0x791e518*/ Cysharp.Threading.Tasks.UniTask<bool> SuppressCancellationThrow();
                /*0x791e708*/ string ToString();

                class IsCanceledSource : Cysharp.Threading.Tasks.IUniTaskSource<bool>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ Cysharp.Threading.Tasks.IUniTaskSource source;

                    /*0x791e6d8*/ IsCanceledSource(Cysharp.Threading.Tasks.IUniTaskSource source);
                    /*0x7920f04*/ bool GetResult(short token);
                    /*0x7921034*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    /*0x7921038*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x79210e0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7921184*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                }

                struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask task;

                    /*0x7921248*/ Awaiter(ref Cysharp.Threading.Tasks.UniTask task);
                    /*0x7921258*/ bool get_IsCompleted();
                    /*0x7921348*/ void GetResult();
                    /*0x79213fc*/ void OnCompleted(System.Action continuation);
                    /*0x792150c*/ void UnsafeOnCompleted(System.Action continuation);
                    /*0x792161c*/ void SourceOnCompleted(System.Action<object> continuation, object state);
                }

                class YieldPromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.YieldPromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.YieldPromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.YieldPromise nextNode;
                    /*0x18*/ System.Threading.CancellationToken cancellationToken;
                    /*0x20*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x792170c*/ YieldPromise();
                    static /*0x791e8e0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7921820*/ YieldPromise();
                    /*0x7921704*/ ref Cysharp.Threading.Tasks.UniTask.YieldPromise get_NextNode();
                    /*0x7921828*/ void GetResult(short token);
                    /*0x79218f4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x792194c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7921a04*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7921a74*/ bool MoveNext();
                    /*0x7921b28*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.YieldPromise.<> <>9;

                        static /*0x7921bc8*/ <>c();
                        /*0x7921c30*/ <>c();
                        /*0x7921c38*/ int <.cctor>b__4_0();
                    }
                }

                class NextFramePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.NextFramePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.NextFramePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.NextFramePromise nextNode;
                    /*0x18*/ int frameCount;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x7921ca4*/ NextFramePromise();
                    static /*0x791eb24*/ Cysharp.Threading.Tasks.IUniTaskSource Create(Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7921db8*/ NextFramePromise();
                    /*0x7921c9c*/ ref Cysharp.Threading.Tasks.UniTask.NextFramePromise get_NextNode();
                    /*0x7921dc0*/ void GetResult(short token);
                    /*0x7921e8c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7921ee4*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7921f9c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x792200c*/ bool MoveNext();
                    /*0x79220f8*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.NextFramePromise.<> <>9;

                        static /*0x7922198*/ <>c();
                        /*0x7922200*/ <>c();
                        /*0x7922208*/ int <.cctor>b__4_0();
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

                    static /*0x7922274*/ WaitForEndOfFramePromise();
                    static /*0x791ed74*/ Cysharp.Threading.Tasks.IUniTaskSource Create(UnityEngine.MonoBehaviour coroutineRunner, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x79223e0*/ WaitForEndOfFramePromise();
                    /*0x792226c*/ ref Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise get_NextNode();
                    /*0x79223f0*/ void GetResult(short token);
                    /*0x79224bc*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7922514*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x79225cc*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x792263c*/ bool TryReturn();
                    /*0x79226f0*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7922748*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x79226e4*/ void Reset();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WaitForEndOfFramePromise.<> <>9;

                        static /*0x7922810*/ <>c();
                        /*0x7922878*/ <>c();
                        /*0x7922880*/ int <.cctor>b__4_0();
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

                    static /*0x79228ec*/ DelayFramePromise();
                    static /*0x791eff0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(int delayFrameCount, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7922a00*/ DelayFramePromise();
                    /*0x79228e4*/ ref Cysharp.Threading.Tasks.UniTask.DelayFramePromise get_NextNode();
                    /*0x7922a08*/ void GetResult(short token);
                    /*0x7922ad4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7922b2c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7922be4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7922c54*/ bool MoveNext();
                    /*0x7922d70*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayFramePromise.<> <>9;

                        static /*0x7922e14*/ <>c();
                        /*0x7922e7c*/ <>c();
                        /*0x7922e84*/ int <.cctor>b__4_0();
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

                    static /*0x7922ef0*/ DelayPromise();
                    static /*0x791f8d8*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7923004*/ DelayPromise();
                    /*0x7922ee8*/ ref Cysharp.Threading.Tasks.UniTask.DelayPromise get_NextNode();
                    /*0x792300c*/ void GetResult(short token);
                    /*0x79230d8*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7923130*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x79231e8*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7923258*/ bool MoveNext();
                    /*0x792335c*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayPromise.<> <>9;

                        static /*0x7923400*/ <>c();
                        /*0x7923468*/ <>c();
                        /*0x7923470*/ int <.cctor>b__4_0();
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

                    static /*0x79234dc*/ DelayIgnoreTimeScalePromise();
                    static /*0x791f4e0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.TimeSpan delayFrameTimeSpan, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x79235f0*/ DelayIgnoreTimeScalePromise();
                    /*0x79234d4*/ ref Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise get_NextNode();
                    /*0x79235f8*/ void GetResult(short token);
                    /*0x79236c4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x792371c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x79237d4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7923844*/ bool MoveNext();
                    /*0x7923948*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayIgnoreTimeScalePromise.<> <>9;

                        static /*0x79239ec*/ <>c();
                        /*0x7923a54*/ <>c();
                        /*0x7923a5c*/ int <.cctor>b__4_0();
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

                    static /*0x7923ac8*/ DelayRealtimePromise();
                    static /*0x791f6e4*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.TimeSpan delayTimeSpan, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7923bdc*/ DelayRealtimePromise();
                    /*0x7923ac0*/ ref Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise get_NextNode();
                    /*0x7923be4*/ void GetResult(short token);
                    /*0x7923cb0*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7923d08*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7923dc0*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7923e30*/ bool MoveNext();
                    /*0x7923f6c*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.DelayRealtimePromise.<> <>9;

                        static /*0x792400c*/ <>c();
                        /*0x7924074*/ <>c();
                        /*0x792407c*/ int <.cctor>b__4_0();
                    }
                }

                class CanceledUniTaskCache<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> Task;

                    static /*0x383e7a0*/ CanceledUniTaskCache();
                }

                class ExceptionResultSource : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
                    /*0x18*/ bool calledGet;

                    /*0x791fcc8*/ ExceptionResultSource(System.Exception exception);
                    /*0x79240e0*/ void GetResult(short token);
                    /*0x792415c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7924164*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x792416c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7924194*/ void Finalize();
                }

                class ExceptionResultSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
                    /*0x0*/ bool calledGet;

                    /*0x3816710*/ ExceptionResultSource(System.Exception exception);
                    /*0x3910ae8*/ T GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x38159dc*/ void Finalize();
                }

                class CanceledResultSource : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ System.Threading.CancellationToken cancellationToken;

                    /*0x791fd04*/ CanceledResultSource(System.Threading.CancellationToken cancellationToken);
                    /*0x7924638*/ void GetResult(short token);
                    /*0x792467c*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7924684*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x792468c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                }

                class CanceledResultSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;

                    /*0x3910ae8*/ CanceledResultSource(System.Threading.CancellationToken cancellationToken);
                    /*0x3910ae8*/ T GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                }

                class DeferPromise : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ System.Func<Cysharp.Threading.Tasks.UniTask> factory;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask.Awaiter awaiter;

                    /*0x791fddc*/ DeferPromise(System.Func<Cysharp.Threading.Tasks.UniTask> factory);
                    /*0x79246b4*/ void GetResult(short token);
                    /*0x7924768*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x79248d0*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x79249b8*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                }

                class WaitUntilPromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.WaitUntilPromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.WaitUntilPromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.WaitUntilPromise nextNode;
                    /*0x18*/ System.Func<bool> predicate;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x7924aac*/ WaitUntilPromise();
                    static /*0x791fef0*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x7924bc0*/ WaitUntilPromise();
                    /*0x7924aa4*/ ref Cysharp.Threading.Tasks.UniTask.WaitUntilPromise get_NextNode();
                    /*0x7924bc8*/ void GetResult(short token);
                    /*0x7924c94*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7924cec*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7924da4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7924e14*/ bool MoveNext();
                    /*0x7924f88*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WaitUntilPromise.<> <>9;

                        static /*0x792503c*/ <>c();
                        /*0x79250a4*/ <>c();
                        /*0x79250ac*/ int <.cctor>b__4_0();
                    }
                }

                class WaitWhilePromise : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UniTask.WaitWhilePromise>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UniTask.WaitWhilePromise> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UniTask.WaitWhilePromise nextNode;
                    /*0x18*/ System.Func<bool> predicate;
                    /*0x20*/ System.Threading.CancellationToken cancellationToken;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object> core;

                    static /*0x7925118*/ WaitWhilePromise();
                    static /*0x7920134*/ Cysharp.Threading.Tasks.IUniTaskSource Create(System.Func<bool> predicate, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x792522c*/ WaitWhilePromise();
                    /*0x7925110*/ ref Cysharp.Threading.Tasks.UniTask.WaitWhilePromise get_NextNode();
                    /*0x7925234*/ void GetResult(short token);
                    /*0x7925300*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7925358*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7925410*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x7925480*/ bool MoveNext();
                    /*0x79255f4*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WaitWhilePromise.<> <>9;

                        static /*0x79256a8*/ <>c();
                        /*0x7925710*/ <>c();
                        /*0x7925718*/ int <.cctor>b__4_0();
                    }
                }

                class WhenAllPromise<T> : Cysharp.Threading.Tasks.IUniTaskSource<T[]>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T[] result;
                    /*0x0*/ int completeCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T[]> core;

                    static /*0x384432c*/ void TryInvokeContinuation(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T> awaiter, int i);
                    /*0x381678c*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T> tasks, int tasksLength);
                    T[] GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T> <>9;
                        static /*0x0*/ System.Action<object> <>9__3_0;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3816710*/ void <.ctor>b__3_0(object state);
                    }
                }

                class WhenAllPromise : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ int completeCount;
                    /*0x14*/ int tasksLength;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x792577c*/ void TryInvokeContinuation(Cysharp.Threading.Tasks.UniTask.WhenAllPromise self, ref Cysharp.Threading.Tasks.UniTask.Awaiter awaiter);
                    /*0x792039c*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask[] tasks, int tasksLength);
                    /*0x7925944*/ void GetResult(short token);
                    /*0x79259cc*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x7925a24*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7925adc*/ void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<> <>9;
                        static /*0x8*/ System.Action<object> <>9__3_0;

                        static /*0x7925b4c*/ <>c();
                        /*0x7925bb4*/ <>c();
                        /*0x7925bbc*/ void <.ctor>b__3_0(object state);
                    }
                }

                class WhenAllPromise<T1, T2> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<T1, T2>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T1 t1;
                    /*0x0*/ T2 t2;
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<T1, T2>> core;

                    static /*0x3843dfc*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    /*0x3910ae8*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                    /*0x3910ae8*/ System.ValueTuple<T1, T2> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2> <>9;
                        static /*0x0*/ System.Action<object> <>9__4_0;
                        static /*0x0*/ System.Action<object> <>9__4_1;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3816710*/ void <.ctor>b__4_0(object state);
                        /*0x3816710*/ void <.ctor>b__4_1(object state);
                    }
                }

                class WhenAllPromise<T1, T2, T3> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<T1, T2, T3>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ T1 t1;
                    /*0x0*/ T2 t2;
                    /*0x0*/ T3 t3;
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<T1, T2, T3>> core;

                    static /*0x3843dfc*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT3(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T3> awaiter);
                    /*0x3910ae8*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3);
                    /*0x3910ae8*/ System.ValueTuple<T1, T2, T3> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2, T3>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2, T3> <>9;
                        static /*0x0*/ System.Action<object> <>9__5_0;
                        static /*0x0*/ System.Action<object> <>9__5_1;
                        static /*0x0*/ System.Action<object> <>9__5_2;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3816710*/ void <.ctor>b__5_0(object state);
                        /*0x3816710*/ void <.ctor>b__5_1(object state);
                        /*0x3816710*/ void <.ctor>b__5_2(object state);
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

                    static /*0x3843dfc*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT3(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T3> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT4(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T4> awaiter);
                    /*0x3910ae8*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4);
                    /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<T1, T2, T3, T4>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAllPromise.<>c<T1, T2, T3, T4> <>9;
                        static /*0x0*/ System.Action<object> <>9__6_0;
                        static /*0x0*/ System.Action<object> <>9__6_1;
                        static /*0x0*/ System.Action<object> <>9__6_2;
                        static /*0x0*/ System.Action<object> <>9__6_3;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3816710*/ void <.ctor>b__6_0(object state);
                        /*0x3816710*/ void <.ctor>b__6_1(object state);
                        /*0x3816710*/ void <.ctor>b__6_2(object state);
                        /*0x3816710*/ void <.ctor>b__6_3(object state);
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

                    static /*0x3843dfc*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT3(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T3> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT4(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T4> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT5(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T5> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT6(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T6> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT7(Cysharp.Threading.Tasks.UniTask.WhenAllPromise<T1, T2, T3, T4, T5, T6, T7> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T7> awaiter);
                    /*0x3910ae8*/ WhenAllPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2, Cysharp.Threading.Tasks.UniTask<T3> task3, Cysharp.Threading.Tasks.UniTask<T4> task4, Cysharp.Threading.Tasks.UniTask<T5> task5, Cysharp.Threading.Tasks.UniTask<T6> task6, Cysharp.Threading.Tasks.UniTask<T7> task7);
                    /*0x3910ae8*/ System.ValueTuple<T1, T2, T3, T4, T5, T6, T7> GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
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

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3816710*/ void <.ctor>b__9_0(object state);
                        /*0x3816710*/ void <.ctor>b__9_1(object state);
                        /*0x3816710*/ void <.ctor>b__9_2(object state);
                        /*0x3816710*/ void <.ctor>b__9_3(object state);
                        /*0x3816710*/ void <.ctor>b__9_4(object state);
                        /*0x3816710*/ void <.ctor>b__9_5(object state);
                        /*0x3816710*/ void <.ctor>b__9_6(object state);
                    }
                }

                class WhenAnyPromise : Cysharp.Threading.Tasks.IUniTaskSource<int>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x10*/ int completedCount;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<int> core;

                    static /*0x7925d70*/ void TryInvokeContinuation(Cysharp.Threading.Tasks.UniTask.WhenAnyPromise self, ref Cysharp.Threading.Tasks.UniTask.Awaiter awaiter, int i);
                    /*0x79209bc*/ WhenAnyPromise(Cysharp.Threading.Tasks.UniTask[] tasks, int tasksLength);
                    /*0x7925f2c*/ int GetResult(short token);
                    /*0x7925fb4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x792600c*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x792607c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x7926134*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAnyPromise.<> <>9;
                        static /*0x8*/ System.Action<object> <>9__2_0;

                        static /*0x7926138*/ <>c();
                        /*0x79261a0*/ <>c();
                        /*0x79261a8*/ void <.ctor>b__2_0(object state);
                    }
                }

                class WhenAnyPromise<T1, T2> : Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<int, T1, T2>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x0*/ int completedCount;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<System.ValueTuple<int, T1, T2>> core;

                    static /*0x3843dfc*/ void TryInvokeContinuationT1(Cysharp.Threading.Tasks.UniTask.WhenAnyPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T1> awaiter);
                    static /*0x3843dfc*/ void TryInvokeContinuationT2(Cysharp.Threading.Tasks.UniTask.WhenAnyPromise<T1, T2> self, ref Cysharp.Threading.Tasks.UniTask.Awaiter<T2> awaiter);
                    /*0x3910ae8*/ WhenAnyPromise(Cysharp.Threading.Tasks.UniTask<T1> task1, Cysharp.Threading.Tasks.UniTask<T2> task2);
                    /*0x3910ae8*/ System.ValueTuple<int, T1, T2> GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);

                    class <>c<T1, T2>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UniTask.WhenAnyPromise.<>c<T1, T2> <>9;
                        static /*0x0*/ System.Action<object> <>9__2_0;
                        static /*0x0*/ System.Action<object> <>9__2_1;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3816710*/ void <.ctor>b__2_0(object state);
                        /*0x3816710*/ void <.ctor>b__2_1(object state);
                    }
                }

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTask.<> <>9;

                    static /*0x7926360*/ <>c();
                    /*0x79263c8*/ <>c();
                    /*0x79263d0*/ Cysharp.Threading.Tasks.UniTask <.cctor>b__178_0();
                }
            }

            class AwaiterActions
            {
                static /*0x0*/ System.Action<object> InvokeContinuationDelegate;

                static /*0x79264f0*/ AwaiterActions();
                static /*0x7926484*/ void Continuation(object state);
            }

            struct UniTask<T>
            {
                /*0x0*/ Cysharp.Threading.Tasks.IUniTaskSource<T> source;
                /*0x0*/ T result;
                /*0x0*/ short token;

                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask op_Implicit(Cysharp.Threading.Tasks.UniTask<T> self);
                /*0x3910ae8*/ UniTask(T result);
                UniTask(Cysharp.Threading.Tasks.IUniTaskSource<T> source, short token);
                /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus get_Status();
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> GetAwaiter();
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AsUniTask();
                /*0x38148bc*/ string ToString();

                struct Awaiter<T> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;

                    /*0x3816710*/ Awaiter(ref Cysharp.Threading.Tasks.UniTask<T> task);
                    /*0x3813ffc*/ bool get_IsCompleted();
                    /*0x3910ae8*/ T GetResult();
                    /*0x3816710*/ void OnCompleted(System.Action continuation);
                    /*0x3816710*/ void UnsafeOnCompleted(System.Action continuation);
                    /*0x3816810*/ void SourceOnCompleted(System.Action<object> continuation, object state);
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

                /*0x7926590*/ YieldAwaitable(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                /*0x7926598*/ Cysharp.Threading.Tasks.YieldAwaitable.Awaiter GetAwaiter();

                struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming timing;

                    /*0x79265a0*/ Awaiter(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                    /*0x79265a8*/ bool get_IsCompleted();
                    /*0x79265b0*/ void GetResult();
                    /*0x79265b4*/ void OnCompleted(System.Action continuation);
                    /*0x792661c*/ void UnsafeOnCompleted(System.Action continuation);
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

                static /*0x7926684*/ CompletedTasks();
            }

            struct SwitchToMainThreadAwaitable
            {
                /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming;
                /*0x18*/ System.Threading.CancellationToken cancellationToken;

                /*0x791fe44*/ SwitchToMainThreadAwaitable(Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken);
                /*0x7926834*/ Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable.Awaiter GetAwaiter();

                struct Awaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming;
                    /*0x18*/ System.Threading.CancellationToken cancellationToken;

                    /*0x792686c*/ Awaiter(Cysharp.Threading.Tasks.PlayerLoopTiming playerLoopTiming, System.Threading.CancellationToken cancellationToken);
                    /*0x792687c*/ bool get_IsCompleted();
                    /*0x792692c*/ void GetResult();
                    /*0x7926984*/ void OnCompleted(System.Action continuation);
                    /*0x79269ec*/ void UnsafeOnCompleted(System.Action continuation);
                }
            }

            class ExceptionHolder
            {
                /*0x10*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo exception;
                /*0x18*/ bool calledGet;

                /*0x7926a54*/ ExceptionHolder(System.Runtime.ExceptionServices.ExceptionDispatchInfo exception);
                /*0x7926a84*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo GetException();
                /*0x7926af4*/ void Finalize();
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

                /*0x38159dc*/ void Reset();
                /*0x38159dc*/ void ReportUnhandledError();
                /*0x3910ae8*/ bool TrySetResult(TResult result);
                /*0x38141c4*/ bool TrySetException(System.Exception error);
                /*0x3910ae8*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x3814548*/ short get_Version();
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x3910ae8*/ TResult GetResult(short token);
                void OnCompleted(System.Action<object> continuation, object state, short token);
                void ValidateToken(short token);
            }

            class UniTaskCompletionSourceCoreShared
            {
                static /*0x0*/ System.Action<object> s_sentinel;

                static /*0x7926c2c*/ UniTaskCompletionSourceCoreShared();
                static /*0x7926be0*/ void CompletionSentinel(object _);
            }

            class AutoResetUniTaskCompletionSource : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource>
            {
                static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource> pool;
                /*0x10*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource nextNode;
                /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                static /*0x7926cd4*/ AutoResetUniTaskCompletionSource();
                static /*0x7926df0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource Create();
                static /*0x7919e30*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource CreateFromCanceled(System.Threading.CancellationToken cancellationToken, ref short token);
                /*0x7926de8*/ AutoResetUniTaskCompletionSource();
                /*0x7926ccc*/ ref Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource get_NextNode();
                /*0x7926e90*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x7926ee8*/ void GetResult(short token);
                /*0x7926fb4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x792700c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x79270c4*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x7927134*/ bool TryReturn();

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource.<> <>9;

                    static /*0x79271d0*/ <>c();
                    /*0x7927238*/ <>c();
                    /*0x7927240*/ int <.cctor>b__4_0();
                }
            }

            class AutoResetUniTaskCompletionSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T>>
            {
                static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T>> pool;
                /*0x0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> nextNode;
                /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core;

                static /*0x383e7a0*/ AutoResetUniTaskCompletionSource();
                static /*0x3836db8*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> Create();
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> CreateFromCanceled(System.Threading.CancellationToken cancellationToken, ref short token);
                /*0x38159dc*/ AutoResetUniTaskCompletionSource();
                /*0x38148bc*/ ref Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource<T> get_NextNode();
                /*0x3910ae8*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x3910ae8*/ T GetResult(short token);
                void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x3813ffc*/ bool TryReturn();

                class <>c<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.AutoResetUniTaskCompletionSource.<>c<T> <>9;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x3814574*/ int <.cctor>b__4_0();
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

                /*0x79272a4*/ UniTaskCompletionSource();
                /*0x79272ac*/ void MarkHandled();
                /*0x79272c4*/ Cysharp.Threading.Tasks.UniTask get_Task();
                /*0x79190d4*/ bool TrySetResult();
                /*0x7927740*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x7927778*/ void GetResult(short token);
                /*0x7927860*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x7927868*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                /*0x7927870*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x79272f0*/ bool TrySignalCompletion(Cysharp.Threading.Tasks.UniTaskStatus status);
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

                /*0x38159dc*/ UniTaskCompletionSource();
                /*0x38159dc*/ void MarkHandled();
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                /*0x3910ae8*/ bool TrySetResult(T result);
                /*0x3910ae8*/ bool TrySetCanceled(System.Threading.CancellationToken cancellationToken);
                /*0x38141c4*/ bool TrySetException(System.Exception exception);
                /*0x3910ae8*/ T GetResult(short token);
                void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                void OnCompleted(System.Action<object> continuation, object state, short token);
                /*0x38140fc*/ bool TrySignalCompletion(Cysharp.Threading.Tasks.UniTaskStatus status);
            }

            class UniTaskExtensions
            {
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> AsUniTask<T>(System.Threading.Tasks.Task<T> task, bool useCurrentSynchronizationContext);
                static /*0x7927b08*/ Cysharp.Threading.Tasks.UniTask AttachExternalCancellation(Cysharp.Threading.Tasks.UniTask task, System.Threading.CancellationToken cancellationToken);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> AttachExternalCancellation<T>(Cysharp.Threading.Tasks.UniTask<T> task, System.Threading.CancellationToken cancellationToken);
                static /*0x7927ddc*/ Cysharp.Threading.Tasks.UniTask Timeout(Cysharp.Threading.Tasks.UniTask task, System.TimeSpan timeout, Cysharp.Threading.Tasks.DelayType delayType, Cysharp.Threading.Tasks.PlayerLoopTiming timeoutCheckTiming, System.Threading.CancellationTokenSource taskCancellationTokenSource);
                static /*0x7927ec8*/ void Forget(Cysharp.Threading.Tasks.UniTask task);
                static /*0x792827c*/ void Forget(Cysharp.Threading.Tasks.UniTask task, System.Action<System.Exception> exceptionHandler, bool handleExceptionOnMainThread);
                static /*0x792828c*/ Cysharp.Threading.Tasks.UniTaskVoid ForgetCoreWithCatch(Cysharp.Threading.Tasks.UniTask task, System.Action<System.Exception> exceptionHandler, bool handleExceptionOnMainThread);
                static /*0x3910ae8*/ void Forget<T>(Cysharp.Threading.Tasks.UniTask<T> task);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask ContinueWith<T>(Cysharp.Threading.Tasks.UniTask<T> task, System.Action<T> continuationFunction);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask ContinueWith<T>(Cysharp.Threading.Tasks.UniTask<T> task, System.Func<T, Cysharp.Threading.Tasks.UniTask> continuationFunction);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TR> ContinueWith<T, TR>(Cysharp.Threading.Tasks.UniTask<T> task, System.Func<T, TR> continuationFunction);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<TR> ContinueWith<T, TR>(Cysharp.Threading.Tasks.UniTask<T> task, System.Func<T, Cysharp.Threading.Tasks.UniTask<TR>> continuationFunction);
                static /*0x792836c*/ Cysharp.Threading.Tasks.UniTask ContinueWith(Cysharp.Threading.Tasks.UniTask task, System.Action continuationFunction);
                static /*0x7928438*/ Cysharp.Threading.Tasks.UniTask ContinueWith(Cysharp.Threading.Tasks.UniTask task, System.Func<Cysharp.Threading.Tasks.UniTask> continuationFunction);
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> ContinueWith<T>(Cysharp.Threading.Tasks.UniTask task, System.Func<T> continuationFunction);

                class AttachExternalCancellationSource : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    static /*0x0*/ System.Action<object> cancellationCallbackDelegate;
                    /*0x10*/ System.Threading.CancellationToken cancellationToken;
                    /*0x18*/ System.Threading.CancellationTokenRegistration tokenRegistration;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                    static /*0x7928824*/ AttachExternalCancellationSource();
                    static /*0x79285cc*/ void CancellationCallback(object state);
                    /*0x7927cdc*/ AttachExternalCancellationSource(Cysharp.Threading.Tasks.UniTask task, System.Threading.CancellationToken cancellationToken);
                    /*0x7928504*/ Cysharp.Threading.Tasks.UniTaskVoid RunTask(Cysharp.Threading.Tasks.UniTask task);
                    /*0x792864c*/ void GetResult(short token);
                    /*0x79286a4*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x79286fc*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x792876c*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();

                    struct <RunTask>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
                        /*0x20*/ Cysharp.Threading.Tasks.UniTask task;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTaskExtensions.AttachExternalCancellationSource <>4__this;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x79288c4*/ void MoveNext();
                        /*0x7928d6c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class AttachExternalCancellationSource<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    static /*0x0*/ System.Action<object> cancellationCallbackDelegate;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration tokenRegistration;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<T> core;

                    static /*0x383e7a0*/ AttachExternalCancellationSource();
                    static /*0x3840c74*/ void CancellationCallback(object state);
                    /*0x3910ae8*/ AttachExternalCancellationSource(Cysharp.Threading.Tasks.UniTask<T> task, System.Threading.CancellationToken cancellationToken);
                    /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTaskVoid RunTask(Cysharp.Threading.Tasks.UniTask<T> task);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    /*0x3910ae8*/ T GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();

                    struct <RunTask>d__5<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x0*/ int <>1__state;
                        /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.AttachExternalCancellationSource<T> <>4__this;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                        /*0x38159dc*/ void MoveNext();
                        /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.<> <>9;
                    static /*0x8*/ System.Action<object> <>9__16_0;

                    static /*0x7928d74*/ <>c();
                    /*0x7928ddc*/ <>c();
                    /*0x7928de4*/ void <Forget>b__16_0(object state);
                }

                class <>c__0<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.<>c__0<T> <>9;
                    static /*0x0*/ System.Action<System.Threading.Tasks.Task<T>, object> <>9__0_0;

                    static /*0x383e7a0*/ <>c__0();
                    /*0x38159dc*/ <>c__0();
                    /*0x3816810*/ void <AsUniTask>b__0_0(System.Threading.Tasks.Task<T> x, object state);
                }

                class <>c__19<T>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.UniTaskExtensions.<>c__19<T> <>9;
                    static /*0x0*/ System.Action<object> <>9__19_0;

                    static /*0x383e7a0*/ <>c__19();
                    /*0x38159dc*/ <>c__19();
                    /*0x3816710*/ void <Forget>b__19_0(object state);
                }

                struct <ContinueWith>d__22<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x0*/ System.Action<T> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                    /*0x0*/ System.Action<T> <>7__wrap1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__24<T, TR> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<TR> <>t__builder;
                    /*0x0*/ System.Func<T, TR> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask<T> task;
                    /*0x0*/ System.Func<T, TR> <>7__wrap1;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x38*/ System.Action continuationFunction;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x79290c0*/ void MoveNext();
                    /*0x79294dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x38*/ System.Func<Cysharp.Threading.Tasks.UniTask> continuationFunction;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x79294e4*/ void MoveNext();
                    /*0x7929b00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ContinueWith>d__28<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask task;
                    /*0x0*/ System.Func<T> continuationFunction;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x38159dc*/ void MoveNext();
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x7929b04*/ void MoveNext();
                    /*0x792a120*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x792a124*/ void MoveNext();
                    /*0x792a8a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class UniTaskObservableExtensions
            {
                static /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> ToUniTask<T>(System.IObservable<T> source, bool useFirstValue, System.Threading.CancellationToken cancellationToken);

                class ToUniTaskObserver<T> : System.IObserver<T>
                {
                    static /*0x0*/ System.Action<object> callback;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration registration;
                    /*0x0*/ bool hasValue;
                    /*0x0*/ T latestValue;

                    static /*0x383e7a0*/ ToUniTaskObserver();
                    static /*0x3840c74*/ void OnCanceled(object state);
                    /*0x381684c*/ ToUniTaskObserver(Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise, Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable, System.Threading.CancellationToken cancellationToken);
                    /*0x3910ae8*/ void OnNext(T value);
                    /*0x3816710*/ void OnError(System.Exception error);
                    /*0x38159dc*/ void OnCompleted();
                }

                class FirstValueToUniTaskObserver<T> : System.IObserver<T>
                {
                    static /*0x0*/ System.Action<object> callback;
                    /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable;
                    /*0x0*/ System.Threading.CancellationToken cancellationToken;
                    /*0x0*/ System.Threading.CancellationTokenRegistration registration;
                    /*0x0*/ bool hasValue;

                    static /*0x383e7a0*/ FirstValueToUniTaskObserver();
                    static /*0x3840c74*/ void OnCanceled(object state);
                    /*0x381684c*/ FirstValueToUniTaskObserver(Cysharp.Threading.Tasks.UniTaskCompletionSource<T> promise, Cysharp.Threading.Tasks.Internal.SingleAssignmentDisposable disposable, System.Threading.CancellationToken cancellationToken);
                    /*0x3910ae8*/ void OnNext(T value);
                    /*0x3816710*/ void OnError(System.Exception error);
                    /*0x38159dc*/ void OnCompleted();
                }
            }

            class UniTaskScheduler
            {
                static /*0x0*/ System.Action<System.Exception> UnobservedTaskException;
                static /*0x8*/ bool PropagateOperationCanceledException;
                static /*0xc*/ UnityEngine.LogType UnobservedExceptionWriteLogType;
                static /*0x10*/ bool DispatchUnityMainThread;
                static /*0x18*/ System.Threading.SendOrPostCallback handleExceptionInvoke;

                static /*0x792a96c*/ UniTaskScheduler();
                static /*0x792a8ac*/ void InvokeUnobservedTaskException(object state);
                static /*0x7924280*/ void PublishUnobservedTaskException(System.Exception ex);
            }

            class UniTaskSynchronizationContext : System.Threading.SynchronizationContext
            {
                static /*0x0*/ System.Threading.SpinLock gate;
                static /*0x4*/ bool dequing;
                static /*0x8*/ int actionListCount;
                static /*0x10*/ Cysharp.Threading.Tasks.UniTaskSynchronizationContext.Callback[] actionList;
                static /*0x18*/ int waitingListCount;
                static /*0x20*/ Cysharp.Threading.Tasks.UniTaskSynchronizationContext.Callback[] waitingList;

                static /*0x792ae60*/ UniTaskSynchronizationContext();
                static /*0x792aa20*/ void Run();

                struct Callback
                {
                    /*0x10*/ System.Threading.SendOrPostCallback callback;
                    /*0x18*/ object state;

                    /*0x792ad9c*/ void Invoke();
                }
            }

            struct UniTaskVoid
            {
                /*0x7928368*/ void Forget();
            }

            class UnityAsyncExtensions
            {
                static /*0x792af38*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter GetAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                static /*0x792afe8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Networking.UnityWebRequest> ToUniTask(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation, System.IProgress<float> progress, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.Threading.CancellationToken cancellationToken);

                struct UnityWebRequestAsyncOperationAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation;
                    /*0x18*/ System.Action<UnityEngine.AsyncOperation> continuationAction;

                    /*0x792afc4*/ UnityWebRequestAsyncOperationAwaiter(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                    /*0x792b57c*/ bool get_IsCompleted();
                    /*0x792b598*/ UnityEngine.Networking.UnityWebRequest GetResult();
                    /*0x792b64c*/ void OnCompleted(System.Action continuation);
                    /*0x792b650*/ void UnsafeOnCompleted(System.Action continuation);
                }

                class UnityWebRequestAsyncOperationConfiguredSource : Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Networking.UnityWebRequest>, Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.IPlayerLoopItem, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource> pool;
                    /*0x10*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource nextNode;
                    /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation;
                    /*0x20*/ System.IProgress<float> progress;
                    /*0x28*/ System.Threading.CancellationToken cancellationToken;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<UnityEngine.Networking.UnityWebRequest> core;

                    static /*0x792b740*/ UnityWebRequestAsyncOperationConfiguredSource();
                    static /*0x792b3a0*/ Cysharp.Threading.Tasks.IUniTaskSource<UnityEngine.Networking.UnityWebRequest> Create(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation, Cysharp.Threading.Tasks.PlayerLoopTiming timing, System.IProgress<float> progress, System.Threading.CancellationToken cancellationToken, ref short token);
                    /*0x792b854*/ UnityWebRequestAsyncOperationConfiguredSource();
                    /*0x792b738*/ ref Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource get_NextNode();
                    /*0x792b85c*/ UnityEngine.Networking.UnityWebRequest GetResult(short token);
                    /*0x792b924*/ void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    /*0x792b928*/ Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x792b980*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    /*0x792ba38*/ void OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x792baa8*/ bool MoveNext();
                    /*0x792bc9c*/ bool TryReturn();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationConfiguredSource.<> <>9;

                        static /*0x792bd60*/ <>c();
                        /*0x792bdc8*/ <>c();
                        /*0x792bdd0*/ int <.cctor>b__4_0();
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

                /*0x792b264*/ UnityWebRequestException(UnityEngine.Networking.UnityWebRequest unityWebRequest);
                /*0x792be34*/ UnityEngine.Networking.UnityWebRequest get_UnityWebRequest();
                /*0x792be3c*/ string get_Error();
                /*0x792be44*/ string get_Text();
                /*0x792be4c*/ string get_Message();
            }

            namespace Triggers
            {
                class AsyncAwakeTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792bfd8*/ AsyncAwakeTrigger();
                    /*0x792beb8*/ Cysharp.Threading.Tasks.UniTask AwakeAsync();
                }

                class AsyncDestroyTrigger : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ bool awakeCalled;
                    /*0x21*/ bool called;
                    /*0x28*/ System.Threading.CancellationTokenSource cancellationTokenSource;

                    /*0x792c338*/ AsyncDestroyTrigger();
                    /*0x792c020*/ System.Threading.CancellationToken get_CancellationToken();
                    /*0x792c140*/ void Awake();
                    /*0x792c14c*/ void OnDestroy();
                    /*0x792c188*/ Cysharp.Threading.Tasks.UniTask OnDestroyAsync();

                    class AwakeMonitor : Cysharp.Threading.Tasks.IPlayerLoopItem
                    {
                        /*0x10*/ Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger trigger;

                        /*0x792c110*/ AwakeMonitor(Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger trigger);
                        /*0x792c340*/ bool MoveNext();
                    }

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.Triggers.AsyncDestroyTrigger.<> <>9;
                        static /*0x8*/ System.Action<object> <>9__7_0;

                        static /*0x792c3d0*/ <>c();
                        /*0x792c438*/ <>c();
                        /*0x792c440*/ void <OnDestroyAsync>b__7_0(object state);
                    }
                }

                class AsyncStartTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x42*/ bool called;

                    /*0x792c65c*/ AsyncStartTrigger();
                    /*0x792c4c4*/ void Start();
                    /*0x792c53c*/ Cysharp.Threading.Tasks.UniTask StartAsync();
                }

                class AsyncTriggerBase<T> : UnityEngine.MonoBehaviour, Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T>
                {
                    /*0x0*/ Cysharp.Threading.Tasks.TriggerEvent<T> triggerEvent;
                    /*0x0*/ bool calledAwake;
                    /*0x0*/ bool calledDestroy;

                    /*0x38159dc*/ AsyncTriggerBase();
                    /*0x38159dc*/ void Awake();
                    /*0x38159dc*/ void OnDestroy();
                    /*0x3816710*/ void AddHandler(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
                    /*0x3816710*/ void RemoveHandler(Cysharp.Threading.Tasks.ITriggerHandler<T> handler);
                    /*0x3910ae8*/ void RaiseEvent(T value);
                    /*0x38148e8*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);

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

                        static /*0x383e7a0*/ AsyncTriggerEnumerator();
                        static /*0x3840c74*/ void CancellationCallback(object state);
                        /*0x3910ae8*/ AsyncTriggerEnumerator(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> parent, System.Threading.CancellationToken cancellationToken);
                        /*0x3910ae8*/ void OnNext(T value);
                        /*0x38159dc*/ void OnCompleted();
                        /*0x3910ae8*/ T get_Current();
                        /*0x3910ae8*/ void set_Current(T value);
                        /*0x38148bc*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev();
                        /*0x3816710*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                        /*0x38148bc*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next();
                        /*0x3816710*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                        /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
                        /*0x3815874*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
                    }

                    class AwakeMonitor<T> : Cysharp.Threading.Tasks.IPlayerLoopItem
                    {
                        /*0x0*/ Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger;

                        /*0x3816710*/ AwakeMonitor(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger);
                        /*0x3813ffc*/ bool MoveNext();
                    }
                }

                interface IAsyncOneShotTrigger
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OneShotAsync();
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

                    static /*0x383e7a0*/ AsyncTriggerHandler();
                    static /*0x3840c74*/ void CancellationCallback(object state);
                    AsyncTriggerHandler(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger, bool callOnce);
                    /*0x3910ae8*/ AsyncTriggerHandler(Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<T> trigger, System.Threading.CancellationToken cancellationToken, bool callOnce);
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync();
                    /*0x38148bc*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev();
                    /*0x3816710*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                    /*0x38148bc*/ Cysharp.Threading.Tasks.ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next();
                    /*0x3816710*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(Cysharp.Threading.Tasks.ITriggerHandler<T> value);
                    /*0x38159dc*/ void Dispose();
                    /*0x3910ae8*/ T Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(short token);
                    /*0x3910ae8*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(T value);
                    /*0x38159dc*/ void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted();
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus();
                    void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(System.Action<object> continuation, object state, short token);
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync();
                    Cysharp.Threading.Tasks.UniTask<int> Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync();
                    /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync();
                    /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync();
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync();
                    Cysharp.Threading.Tasks.UniTask<float> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync();
                    Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync();
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync();
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync();
                }

                interface IAsyncFixedUpdateHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask FixedUpdateAsync();
                }

                class AsyncFixedUpdateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792c9ec*/ AsyncFixedUpdateTrigger();
                    /*0x792c6a4*/ void FixedUpdate();
                    /*0x792c714*/ Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler();
                    /*0x792c790*/ Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792c814*/ Cysharp.Threading.Tasks.UniTask FixedUpdateAsync();
                    /*0x792c8fc*/ Cysharp.Threading.Tasks.UniTask FixedUpdateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncLateUpdateHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask LateUpdateAsync();
                }

                class AsyncLateUpdateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792cd7c*/ AsyncLateUpdateTrigger();
                    /*0x792ca34*/ void LateUpdate();
                    /*0x792caa4*/ Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler GetLateUpdateAsyncHandler();
                    /*0x792cb20*/ Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler GetLateUpdateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792cba4*/ Cysharp.Threading.Tasks.UniTask LateUpdateAsync();
                    /*0x792cc8c*/ Cysharp.Threading.Tasks.UniTask LateUpdateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnAnimatorIKHandler
                {
                    Cysharp.Threading.Tasks.UniTask<int> OnAnimatorIKAsync();
                }

                class AsyncAnimatorIKTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<int>
                {
                    /*0x792d0f4*/ AsyncAnimatorIKTrigger();
                    /*0x792cdc4*/ void OnAnimatorIK(int layerIndex);
                    /*0x792ce1c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler();
                    /*0x792ce98*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792cf1c*/ Cysharp.Threading.Tasks.UniTask<int> OnAnimatorIKAsync();
                    /*0x792d004*/ Cysharp.Threading.Tasks.UniTask<int> OnAnimatorIKAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnAnimatorMoveHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnAnimatorMoveAsync();
                }

                class AsyncAnimatorMoveTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792d484*/ AsyncAnimatorMoveTrigger();
                    /*0x792d13c*/ void OnAnimatorMove();
                    /*0x792d1ac*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler();
                    /*0x792d228*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792d2ac*/ Cysharp.Threading.Tasks.UniTask OnAnimatorMoveAsync();
                    /*0x792d394*/ Cysharp.Threading.Tasks.UniTask OnAnimatorMoveAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnApplicationFocusHandler
                {
                    /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationFocusAsync();
                }

                class AsyncApplicationFocusTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<bool>
                {
                    /*0x792d7fc*/ AsyncApplicationFocusTrigger();
                    /*0x792d4cc*/ void OnApplicationFocus(bool hasFocus);
                    /*0x792d524*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler();
                    /*0x792d5a0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792d624*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationFocusAsync();
                    /*0x792d70c*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationFocusAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnApplicationPauseHandler
                {
                    /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationPauseAsync();
                }

                class AsyncApplicationPauseTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<bool>
                {
                    /*0x792db74*/ AsyncApplicationPauseTrigger();
                    /*0x792d844*/ void OnApplicationPause(bool pauseStatus);
                    /*0x792d89c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler();
                    /*0x792d918*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792d99c*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationPauseAsync();
                    /*0x792da84*/ Cysharp.Threading.Tasks.UniTask<bool> OnApplicationPauseAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnApplicationQuitHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnApplicationQuitAsync();
                }

                class AsyncApplicationQuitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792df04*/ AsyncApplicationQuitTrigger();
                    /*0x792dbbc*/ void OnApplicationQuit();
                    /*0x792dc2c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler();
                    /*0x792dca8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792dd2c*/ Cysharp.Threading.Tasks.UniTask OnApplicationQuitAsync();
                    /*0x792de14*/ Cysharp.Threading.Tasks.UniTask OnApplicationQuitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnAudioFilterReadHandler
                {
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> OnAudioFilterReadAsync();
                }

                class AsyncAudioFilterReadTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<System.ValueTuple<System.Single[], int>>
                {
                    /*0x792e300*/ AsyncAudioFilterReadTrigger();
                    /*0x792df4c*/ void OnAudioFilterRead(float[] data, int channels);
                    /*0x792dfe8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler();
                    /*0x792e064*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792e0e8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> OnAudioFilterReadAsync();
                    /*0x792e1ec*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<System.Single[], int>> OnAudioFilterReadAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBecameInvisibleHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnBecameInvisibleAsync();
                }

                class AsyncBecameInvisibleTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792e690*/ AsyncBecameInvisibleTrigger();
                    /*0x792e348*/ void OnBecameInvisible();
                    /*0x792e3b8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler();
                    /*0x792e434*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792e4b8*/ Cysharp.Threading.Tasks.UniTask OnBecameInvisibleAsync();
                    /*0x792e5a0*/ Cysharp.Threading.Tasks.UniTask OnBecameInvisibleAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBecameVisibleHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnBecameVisibleAsync();
                }

                class AsyncBecameVisibleTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792ea20*/ AsyncBecameVisibleTrigger();
                    /*0x792e6d8*/ void OnBecameVisible();
                    /*0x792e748*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler();
                    /*0x792e7c4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler GetOnBecameVisibleAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792e848*/ Cysharp.Threading.Tasks.UniTask OnBecameVisibleAsync();
                    /*0x792e930*/ Cysharp.Threading.Tasks.UniTask OnBecameVisibleAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBeforeTransformParentChangedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnBeforeTransformParentChangedAsync();
                }

                class AsyncBeforeTransformParentChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792edb0*/ AsyncBeforeTransformParentChangedTrigger();
                    /*0x792ea68*/ void OnBeforeTransformParentChanged();
                    /*0x792ead8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler();
                    /*0x792eb54*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792ebd8*/ Cysharp.Threading.Tasks.UniTask OnBeforeTransformParentChangedAsync();
                    /*0x792ecc0*/ Cysharp.Threading.Tasks.UniTask OnBeforeTransformParentChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCanvasGroupChangedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnCanvasGroupChangedAsync();
                }

                class AsyncOnCanvasGroupChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x792f140*/ AsyncOnCanvasGroupChangedTrigger();
                    /*0x792edf8*/ void OnCanvasGroupChanged();
                    /*0x792ee68*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler();
                    /*0x792eee4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792ef68*/ Cysharp.Threading.Tasks.UniTask OnCanvasGroupChangedAsync();
                    /*0x792f050*/ Cysharp.Threading.Tasks.UniTask OnCanvasGroupChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionEnterHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionEnterAsync();
                }

                class AsyncCollisionEnterTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision>
                {
                    /*0x792f504*/ AsyncCollisionEnterTrigger();
                    /*0x792f188*/ void OnCollisionEnter(UnityEngine.Collision coll);
                    /*0x792f1e0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler();
                    /*0x792f25c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler GetOnCollisionEnterAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792f2e0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionEnterAsync();
                    /*0x792f3ec*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionEnterAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionEnter2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionEnter2DAsync();
                }

                class AsyncCollisionEnter2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision2D>
                {
                    /*0x792f8c8*/ AsyncCollisionEnter2DTrigger();
                    /*0x792f54c*/ void OnCollisionEnter2D(UnityEngine.Collision2D coll);
                    /*0x792f5a4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler();
                    /*0x792f620*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792f6a4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionEnter2DAsync();
                    /*0x792f7b0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionEnter2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionExitHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionExitAsync();
                }

                class AsyncCollisionExitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision>
                {
                    /*0x792fc8c*/ AsyncCollisionExitTrigger();
                    /*0x792f910*/ void OnCollisionExit(UnityEngine.Collision coll);
                    /*0x792f968*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler();
                    /*0x792f9e4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler GetOnCollisionExitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792fa68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionExitAsync();
                    /*0x792fb74*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionExitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionExit2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionExit2DAsync();
                }

                class AsyncCollisionExit2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision2D>
                {
                    /*0x7930050*/ AsyncCollisionExit2DTrigger();
                    /*0x792fcd4*/ void OnCollisionExit2D(UnityEngine.Collision2D coll);
                    /*0x792fd2c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler();
                    /*0x792fda8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x792fe2c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionExit2DAsync();
                    /*0x792ff38*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionExit2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionStayHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionStayAsync();
                }

                class AsyncCollisionStayTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision>
                {
                    /*0x7930414*/ AsyncCollisionStayTrigger();
                    /*0x7930098*/ void OnCollisionStay(UnityEngine.Collision coll);
                    /*0x79300f0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler();
                    /*0x793016c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler GetOnCollisionStayAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79301f0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionStayAsync();
                    /*0x79302fc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision> OnCollisionStayAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCollisionStay2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionStay2DAsync();
                }

                class AsyncCollisionStay2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collision2D>
                {
                    /*0x79307d8*/ AsyncCollisionStay2DTrigger();
                    /*0x793045c*/ void OnCollisionStay2D(UnityEngine.Collision2D coll);
                    /*0x79304b4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler();
                    /*0x7930530*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79305b4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionStay2DAsync();
                    /*0x79306c0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collision2D> OnCollisionStay2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnControllerColliderHitHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> OnControllerColliderHitAsync();
                }

                class AsyncControllerColliderHitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.ControllerColliderHit>
                {
                    /*0x7930b9c*/ AsyncControllerColliderHitTrigger();
                    /*0x7930820*/ void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit);
                    /*0x7930878*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler();
                    /*0x79308f4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7930978*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> OnControllerColliderHitAsync();
                    /*0x7930a84*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ControllerColliderHit> OnControllerColliderHitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDisableHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnDisableAsync();
                }

                class AsyncDisableTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7930f2c*/ AsyncDisableTrigger();
                    /*0x7930be4*/ void OnDisable();
                    /*0x7930c54*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler GetOnDisableAsyncHandler();
                    /*0x7930cd0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler GetOnDisableAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7930d54*/ Cysharp.Threading.Tasks.UniTask OnDisableAsync();
                    /*0x7930e3c*/ Cysharp.Threading.Tasks.UniTask OnDisableAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDrawGizmosHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosAsync();
                }

                class AsyncDrawGizmosTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79312bc*/ AsyncDrawGizmosTrigger();
                    /*0x7930f74*/ void OnDrawGizmos();
                    /*0x7930fe4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler();
                    /*0x7931060*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79310e4*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosAsync();
                    /*0x79311cc*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDrawGizmosSelectedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosSelectedAsync();
                }

                class AsyncDrawGizmosSelectedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x793164c*/ AsyncDrawGizmosSelectedTrigger();
                    /*0x7931304*/ void OnDrawGizmosSelected();
                    /*0x7931374*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler();
                    /*0x79313f0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7931474*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosSelectedAsync();
                    /*0x793155c*/ Cysharp.Threading.Tasks.UniTask OnDrawGizmosSelectedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnEnableHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnEnableAsync();
                }

                class AsyncEnableTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79319dc*/ AsyncEnableTrigger();
                    /*0x7931694*/ void OnEnable();
                    /*0x7931704*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler GetOnEnableAsyncHandler();
                    /*0x7931780*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler GetOnEnableAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7931804*/ Cysharp.Threading.Tasks.UniTask OnEnableAsync();
                    /*0x79318ec*/ Cysharp.Threading.Tasks.UniTask OnEnableAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnGUIHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnGUIAsync();
                }

                class AsyncGUITrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7931d6c*/ AsyncGUITrigger();
                    /*0x7931a24*/ void OnGUI();
                    /*0x7931a94*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler GetOnGUIAsyncHandler();
                    /*0x7931b10*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler GetOnGUIAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7931b94*/ Cysharp.Threading.Tasks.UniTask OnGUIAsync();
                    /*0x7931c7c*/ Cysharp.Threading.Tasks.UniTask OnGUIAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnJointBreakHandler
                {
                    Cysharp.Threading.Tasks.UniTask<float> OnJointBreakAsync();
                }

                class AsyncJointBreakTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<float>
                {
                    /*0x79320e4*/ AsyncJointBreakTrigger();
                    /*0x7931db4*/ void OnJointBreak(float breakForce);
                    /*0x7931e0c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler();
                    /*0x7931e88*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler GetOnJointBreakAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7931f0c*/ Cysharp.Threading.Tasks.UniTask<float> OnJointBreakAsync();
                    /*0x7931ff4*/ Cysharp.Threading.Tasks.UniTask<float> OnJointBreakAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnJointBreak2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> OnJointBreak2DAsync();
                }

                class AsyncJointBreak2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Joint2D>
                {
                    /*0x79324a8*/ AsyncJointBreak2DTrigger();
                    /*0x793212c*/ void OnJointBreak2D(UnityEngine.Joint2D brokenJoint);
                    /*0x7932184*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler();
                    /*0x7932200*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler GetOnJointBreak2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7932284*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> OnJointBreak2DAsync();
                    /*0x7932390*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Joint2D> OnJointBreak2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleCollisionHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> OnParticleCollisionAsync();
                }

                class AsyncParticleCollisionTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.GameObject>
                {
                    /*0x793286c*/ AsyncParticleCollisionTrigger();
                    /*0x79324f0*/ void OnParticleCollision(UnityEngine.GameObject other);
                    /*0x7932548*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler();
                    /*0x79325c4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7932648*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> OnParticleCollisionAsync();
                    /*0x7932754*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> OnParticleCollisionAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleSystemStoppedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnParticleSystemStoppedAsync();
                }

                class AsyncParticleSystemStoppedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7932bfc*/ AsyncParticleSystemStoppedTrigger();
                    /*0x79328b4*/ void OnParticleSystemStopped();
                    /*0x7932924*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler();
                    /*0x79329a0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7932a24*/ Cysharp.Threading.Tasks.UniTask OnParticleSystemStoppedAsync();
                    /*0x7932b0c*/ Cysharp.Threading.Tasks.UniTask OnParticleSystemStoppedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleTriggerHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnParticleTriggerAsync();
                }

                class AsyncParticleTriggerTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7932f8c*/ AsyncParticleTriggerTrigger();
                    /*0x7932c44*/ void OnParticleTrigger();
                    /*0x7932cb4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler();
                    /*0x7932d30*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7932db4*/ Cysharp.Threading.Tasks.UniTask OnParticleTriggerAsync();
                    /*0x7932e9c*/ Cysharp.Threading.Tasks.UniTask OnParticleTriggerAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnParticleUpdateJobScheduledHandler
                {
                    Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> OnParticleUpdateJobScheduledAsync();
                }

                class AsyncParticleUpdateJobScheduledTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.ParticleSystemJobs.ParticleSystemJobData>
                {
                    /*0x793338c*/ AsyncParticleUpdateJobScheduledTrigger();
                    /*0x7932fd4*/ void OnParticleUpdateJobScheduled(UnityEngine.ParticleSystemJobs.ParticleSystemJobData particles);
                    /*0x793305c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler();
                    /*0x79330d8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793315c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> OnParticleUpdateJobScheduledAsync();
                    /*0x7933270*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.ParticleSystemJobs.ParticleSystemJobData> OnParticleUpdateJobScheduledAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPostRenderHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnPostRenderAsync();
                }

                class AsyncPostRenderTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x793371c*/ AsyncPostRenderTrigger();
                    /*0x79333d4*/ void OnPostRender();
                    /*0x7933444*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler();
                    /*0x79334c0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler GetOnPostRenderAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7933544*/ Cysharp.Threading.Tasks.UniTask OnPostRenderAsync();
                    /*0x793362c*/ Cysharp.Threading.Tasks.UniTask OnPostRenderAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPreCullHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnPreCullAsync();
                }

                class AsyncPreCullTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7933aac*/ AsyncPreCullTrigger();
                    /*0x7933764*/ void OnPreCull();
                    /*0x79337d4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler GetOnPreCullAsyncHandler();
                    /*0x7933850*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler GetOnPreCullAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79338d4*/ Cysharp.Threading.Tasks.UniTask OnPreCullAsync();
                    /*0x79339bc*/ Cysharp.Threading.Tasks.UniTask OnPreCullAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPreRenderHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnPreRenderAsync();
                }

                class AsyncPreRenderTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7933e3c*/ AsyncPreRenderTrigger();
                    /*0x7933af4*/ void OnPreRender();
                    /*0x7933b64*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler();
                    /*0x7933be0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7933c64*/ Cysharp.Threading.Tasks.UniTask OnPreRenderAsync();
                    /*0x7933d4c*/ Cysharp.Threading.Tasks.UniTask OnPreRenderAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRectTransformDimensionsChangeHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnRectTransformDimensionsChangeAsync();
                }

                class AsyncRectTransformDimensionsChangeTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79341cc*/ AsyncRectTransformDimensionsChangeTrigger();
                    /*0x7933e84*/ void OnRectTransformDimensionsChange();
                    /*0x7933ef4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler();
                    /*0x7933f70*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7933ff4*/ Cysharp.Threading.Tasks.UniTask OnRectTransformDimensionsChangeAsync();
                    /*0x79340dc*/ Cysharp.Threading.Tasks.UniTask OnRectTransformDimensionsChangeAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRectTransformRemovedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnRectTransformRemovedAsync();
                }

                class AsyncRectTransformRemovedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x793455c*/ AsyncRectTransformRemovedTrigger();
                    /*0x7934214*/ void OnRectTransformRemoved();
                    /*0x7934284*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler();
                    /*0x7934300*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7934384*/ Cysharp.Threading.Tasks.UniTask OnRectTransformRemovedAsync();
                    /*0x793446c*/ Cysharp.Threading.Tasks.UniTask OnRectTransformRemovedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRenderImageHandler
                {
                    Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> OnRenderImageAsync();
                }

                class AsyncRenderImageTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>>
                {
                    /*0x7934958*/ AsyncRenderImageTrigger();
                    /*0x79345a4*/ void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination);
                    /*0x7934640*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler();
                    /*0x79346bc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler GetOnRenderImageAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7934740*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> OnRenderImageAsync();
                    /*0x7934844*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.RenderTexture, UnityEngine.RenderTexture>> OnRenderImageAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnRenderObjectHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnRenderObjectAsync();
                }

                class AsyncRenderObjectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7934ce8*/ AsyncRenderObjectTrigger();
                    /*0x79349a0*/ void OnRenderObject();
                    /*0x7934a10*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler();
                    /*0x7934a8c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7934b10*/ Cysharp.Threading.Tasks.UniTask OnRenderObjectAsync();
                    /*0x7934bf8*/ Cysharp.Threading.Tasks.UniTask OnRenderObjectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnServerInitializedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnServerInitializedAsync();
                }

                class AsyncServerInitializedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7935078*/ AsyncServerInitializedTrigger();
                    /*0x7934d30*/ void OnServerInitialized();
                    /*0x7934da0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler();
                    /*0x7934e1c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7934ea0*/ Cysharp.Threading.Tasks.UniTask OnServerInitializedAsync();
                    /*0x7934f88*/ Cysharp.Threading.Tasks.UniTask OnServerInitializedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTransformChildrenChangedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnTransformChildrenChangedAsync();
                }

                class AsyncTransformChildrenChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7935408*/ AsyncTransformChildrenChangedTrigger();
                    /*0x79350c0*/ void OnTransformChildrenChanged();
                    /*0x7935130*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler();
                    /*0x79351ac*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7935230*/ Cysharp.Threading.Tasks.UniTask OnTransformChildrenChangedAsync();
                    /*0x7935318*/ Cysharp.Threading.Tasks.UniTask OnTransformChildrenChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTransformParentChangedHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnTransformParentChangedAsync();
                }

                class AsyncTransformParentChangedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7935798*/ AsyncTransformParentChangedTrigger();
                    /*0x7935450*/ void OnTransformParentChanged();
                    /*0x79354c0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler();
                    /*0x793553c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79355c0*/ Cysharp.Threading.Tasks.UniTask OnTransformParentChangedAsync();
                    /*0x79356a8*/ Cysharp.Threading.Tasks.UniTask OnTransformParentChangedAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerEnterHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerEnterAsync();
                }

                class AsyncTriggerEnterTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider>
                {
                    /*0x7935b5c*/ AsyncTriggerEnterTrigger();
                    /*0x79357e0*/ void OnTriggerEnter(UnityEngine.Collider other);
                    /*0x7935838*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler();
                    /*0x79358b4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7935938*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerEnterAsync();
                    /*0x7935a44*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerEnterAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerEnter2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerEnter2DAsync();
                }

                class AsyncTriggerEnter2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider2D>
                {
                    /*0x7935f20*/ AsyncTriggerEnter2DTrigger();
                    /*0x7935ba4*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
                    /*0x7935bfc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler();
                    /*0x7935c78*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7935cfc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerEnter2DAsync();
                    /*0x7935e08*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerEnter2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerExitHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerExitAsync();
                }

                class AsyncTriggerExitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider>
                {
                    /*0x79362e4*/ AsyncTriggerExitTrigger();
                    /*0x7935f68*/ void OnTriggerExit(UnityEngine.Collider other);
                    /*0x7935fc0*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler();
                    /*0x793603c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler GetOnTriggerExitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79360c0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerExitAsync();
                    /*0x79361cc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerExitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerExit2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerExit2DAsync();
                }

                class AsyncTriggerExit2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider2D>
                {
                    /*0x79366a8*/ AsyncTriggerExit2DTrigger();
                    /*0x793632c*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
                    /*0x7936384*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler();
                    /*0x7936400*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7936484*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerExit2DAsync();
                    /*0x7936590*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerExit2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerStayHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerStayAsync();
                }

                class AsyncTriggerStayTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider>
                {
                    /*0x7936a6c*/ AsyncTriggerStayTrigger();
                    /*0x79366f0*/ void OnTriggerStay(UnityEngine.Collider other);
                    /*0x7936748*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler();
                    /*0x79367c4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler GetOnTriggerStayAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7936848*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerStayAsync();
                    /*0x7936954*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider> OnTriggerStayAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnTriggerStay2DHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerStay2DAsync();
                }

                class AsyncTriggerStay2DTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.Collider2D>
                {
                    /*0x7936e30*/ AsyncTriggerStay2DTrigger();
                    /*0x7936ab4*/ void OnTriggerStay2D(UnityEngine.Collider2D other);
                    /*0x7936b0c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler();
                    /*0x7936b88*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler GetOnTriggerStay2DAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7936c0c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerStay2DAsync();
                    /*0x7936d18*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Collider2D> OnTriggerStay2DAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnValidateHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnValidateAsync();
                }

                class AsyncValidateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79371c0*/ AsyncValidateTrigger();
                    /*0x7936e78*/ void OnValidate();
                    /*0x7936ee8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler GetOnValidateAsyncHandler();
                    /*0x7936f64*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler GetOnValidateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7936fe8*/ Cysharp.Threading.Tasks.UniTask OnValidateAsync();
                    /*0x79370d0*/ Cysharp.Threading.Tasks.UniTask OnValidateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnWillRenderObjectHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask OnWillRenderObjectAsync();
                }

                class AsyncWillRenderObjectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7937550*/ AsyncWillRenderObjectTrigger();
                    /*0x7937208*/ void OnWillRenderObject();
                    /*0x7937278*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler();
                    /*0x79372f4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler GetOnWillRenderObjectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7937378*/ Cysharp.Threading.Tasks.UniTask OnWillRenderObjectAsync();
                    /*0x7937460*/ Cysharp.Threading.Tasks.UniTask OnWillRenderObjectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncResetHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask ResetAsync();
                }

                class AsyncResetTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x79378e0*/ AsyncResetTrigger();
                    /*0x7937598*/ void Reset();
                    /*0x7937608*/ Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler GetResetAsyncHandler();
                    /*0x7937684*/ Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler GetResetAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7937708*/ Cysharp.Threading.Tasks.UniTask ResetAsync();
                    /*0x79377f0*/ Cysharp.Threading.Tasks.UniTask ResetAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncUpdateHandler
                {
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask UpdateAsync();
                }

                class AsyncUpdateTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<Cysharp.Threading.Tasks.AsyncUnit>
                {
                    /*0x7937c70*/ AsyncUpdateTrigger();
                    /*0x7937928*/ void Update();
                    /*0x7937998*/ Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler GetUpdateAsyncHandler();
                    /*0x7937a14*/ Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler GetUpdateAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7937a98*/ Cysharp.Threading.Tasks.UniTask UpdateAsync();
                    /*0x7937b80*/ Cysharp.Threading.Tasks.UniTask UpdateAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnBeginDragHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsync();
                }

                class AsyncBeginDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7938034*/ AsyncBeginDragTrigger();
                    /*0x7937cb8*/ void UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7937d10*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler();
                    /*0x7937d8c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7937e10*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsync();
                    /*0x7937f1c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnBeginDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnCancelHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync();
                }

                class AsyncCancelTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x79383f8*/ AsyncCancelTrigger();
                    /*0x793807c*/ void UnityEngine.EventSystems.ICancelHandler.OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x79380d4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler GetOnCancelAsyncHandler();
                    /*0x7938150*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler GetOnCancelAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79381d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync();
                    /*0x79382e0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDeselectHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnDeselectAsync();
                }

                class AsyncDeselectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x79387bc*/ AsyncDeselectTrigger();
                    /*0x7938440*/ void UnityEngine.EventSystems.IDeselectHandler.OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x7938498*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler GetOnDeselectAsyncHandler();
                    /*0x7938514*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler GetOnDeselectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7938598*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnDeselectAsync();
                    /*0x79386a4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnDeselectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDragHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDragAsync();
                }

                class AsyncDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7938b80*/ AsyncDragTrigger();
                    /*0x7938804*/ void UnityEngine.EventSystems.IDragHandler.OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x793885c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler GetOnDragAsyncHandler();
                    /*0x79388d8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler GetOnDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793895c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDragAsync();
                    /*0x7938a68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnDropHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDropAsync();
                }

                class AsyncDropTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7938f44*/ AsyncDropTrigger();
                    /*0x7938bc8*/ void UnityEngine.EventSystems.IDropHandler.OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7938c20*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler GetOnDropAsyncHandler();
                    /*0x7938c9c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler GetOnDropAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7938d20*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDropAsync();
                    /*0x7938e2c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnDropAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnEndDragHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnEndDragAsync();
                }

                class AsyncEndDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7939308*/ AsyncEndDragTrigger();
                    /*0x7938f8c*/ void UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7938fe4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler GetOnEndDragAsyncHandler();
                    /*0x7939060*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler GetOnEndDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79390e4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnEndDragAsync();
                    /*0x79391f0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnEndDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnInitializePotentialDragHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsync();
                }

                class AsyncInitializePotentialDragTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IInitializePotentialDragHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x79396cc*/ AsyncInitializePotentialDragTrigger();
                    /*0x7939350*/ void UnityEngine.EventSystems.IInitializePotentialDragHandler.OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x79393a8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler();
                    /*0x7939424*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler GetOnInitializePotentialDragAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x79394a8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsync();
                    /*0x79395b4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnInitializePotentialDragAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnMoveHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> OnMoveAsync();
                }

                class AsyncMoveTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.AxisEventData>, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7939a90*/ AsyncMoveTrigger();
                    /*0x7939714*/ void UnityEngine.EventSystems.IMoveHandler.OnMove(UnityEngine.EventSystems.AxisEventData eventData);
                    /*0x793976c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler GetOnMoveAsyncHandler();
                    /*0x79397e8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler GetOnMoveAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793986c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> OnMoveAsync();
                    /*0x7939978*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.AxisEventData> OnMoveAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerClickHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsync();
                }

                class AsyncPointerClickTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x7939e54*/ AsyncPointerClickTrigger();
                    /*0x7939ad8*/ void UnityEngine.EventSystems.IPointerClickHandler.OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7939b30*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler();
                    /*0x7939bac*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler GetOnPointerClickAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7939c30*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsync();
                    /*0x7939d3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerClickAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerDownHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsync();
                }

                class AsyncPointerDownTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793a218*/ AsyncPointerDownTrigger();
                    /*0x7939e9c*/ void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x7939ef4*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler();
                    /*0x7939f70*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler GetOnPointerDownAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x7939ff4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsync();
                    /*0x793a100*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerDownAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerEnterHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsync();
                }

                class AsyncPointerEnterTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793a5dc*/ AsyncPointerEnterTrigger();
                    /*0x793a260*/ void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x793a2b8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler();
                    /*0x793a334*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793a3b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsync();
                    /*0x793a4c4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerEnterAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerExitHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsync();
                }

                class AsyncPointerExitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793a9a0*/ AsyncPointerExitTrigger();
                    /*0x793a624*/ void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x793a67c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler();
                    /*0x793a6f8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793a77c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsync();
                    /*0x793a888*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerExitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnPointerUpHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsync();
                }

                class AsyncPointerUpTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793ad64*/ AsyncPointerUpTrigger();
                    /*0x793a9e8*/ void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x793aa40*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler();
                    /*0x793aabc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler GetOnPointerUpAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793ab40*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsync();
                    /*0x793ac4c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnPointerUpAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnScrollHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnScrollAsync();
                }

                class AsyncScrollTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.PointerEventData>, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793b128*/ AsyncScrollTrigger();
                    /*0x793adac*/ void UnityEngine.EventSystems.IScrollHandler.OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
                    /*0x793ae04*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler GetOnScrollAsyncHandler();
                    /*0x793ae80*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler GetOnScrollAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793af04*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnScrollAsync();
                    /*0x793b010*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.PointerEventData> OnScrollAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnSelectHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSelectAsync();
                }

                class AsyncSelectTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793b4ec*/ AsyncSelectTrigger();
                    /*0x793b170*/ void UnityEngine.EventSystems.ISelectHandler.OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x793b1c8*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler GetOnSelectAsyncHandler();
                    /*0x793b244*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler GetOnSelectAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793b2c8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSelectAsync();
                    /*0x793b3d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSelectAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnSubmitHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSubmitAsync();
                }

                class AsyncSubmitTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793b8b0*/ AsyncSubmitTrigger();
                    /*0x793b534*/ void UnityEngine.EventSystems.ISubmitHandler.OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x793b58c*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler GetOnSubmitAsyncHandler();
                    /*0x793b608*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler GetOnSubmitAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793b68c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSubmitAsync();
                    /*0x793b798*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnSubmitAsync(System.Threading.CancellationToken cancellationToken);
                }

                interface IAsyncOnUpdateSelectedHandler
                {
                    /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsync();
                }

                class AsyncUpdateSelectedTrigger : Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase<UnityEngine.EventSystems.BaseEventData>, UnityEngine.EventSystems.IUpdateSelectedHandler, UnityEngine.EventSystems.IEventSystemHandler
                {
                    /*0x793bc74*/ AsyncUpdateSelectedTrigger();
                    /*0x793b8f8*/ void UnityEngine.EventSystems.IUpdateSelectedHandler.OnUpdateSelected(UnityEngine.EventSystems.BaseEventData eventData);
                    /*0x793b950*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler();
                    /*0x793b9cc*/ Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler(System.Threading.CancellationToken cancellationToken);
                    /*0x793ba50*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsync();
                    /*0x793bb5c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.EventSystems.BaseEventData> OnUpdateSelectedAsync(System.Threading.CancellationToken cancellationToken);
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

                    static /*0x383e7a0*/ ArrayPool();
                    static /*0x382d234*/ int CalculateSize(int size);
                    static /*0x382d234*/ int GetQueueIndex(int size);
                    /*0x38159dc*/ ArrayPool();
                    /*0x3814964*/ T[] Rent(int minimumLength);
                    void Return(T[] array, bool clearArray);
                }

                class ArrayPoolUtil
                {
                    static /*0x3843070*/ void EnsureCapacity<T>(ref T[] array, int index, Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool);
                    static /*0x3843070*/ void EnsureCapacityCore<T>(ref T[] array, int index, Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool);
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.ArrayPoolUtil.RentArray<T> Materialize<T>(System.Collections.Generic.IEnumerable<T> source);

                    struct RentArray<T> : System.IDisposable
                    {
                        /*0x0*/ T[] Array;
                        /*0x0*/ int Length;
                        /*0x0*/ Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool;

                        RentArray(T[] array, int length, Cysharp.Threading.Tasks.Internal.ArrayPool<T> pool);
                        /*0x38159dc*/ void Dispose();
                        /*0x3815cc4*/ void DisposeManually(bool clearArray);
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

                    /*0x791cb24*/ ContinuationQueue(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                    /*0x791d204*/ void Enqueue(System.Action continuation);
                    /*0x793bcbc*/ void Run();
                    /*0x793bcc0*/ void RunCore();
                }

                class Error
                {
                    static /*0x3910ae8*/ void ThrowArgumentNullException<T>(T value, string paramName);
                    static /*0x793c020*/ void ThrowArgumentNullExceptionCore(string paramName);
                    static /*0x3910ae8*/ void ThrowWhenContinuationIsAlreadyRegistered<T>(T continuationField);
                    static /*0x793c064*/ void ThrowInvalidOperationExceptionCore(string message);
                    static /*0x792a870*/ void ThrowOperationCanceledException();
                }

                class MinimumQueue<T>
                {
                    /*0x0*/ T[] array;
                    /*0x0*/ int head;
                    /*0x0*/ int tail;
                    /*0x0*/ int size;

                    /*0x3815ed0*/ MinimumQueue(int capacity);
                    /*0x3814574*/ int get_Count();
                    /*0x3910ae8*/ void Enqueue(T item);
                    /*0x3910ae8*/ T Dequeue();
                    /*0x38159dc*/ void Grow();
                    /*0x3815ed0*/ void SetCapacity(int capacity);
                    /*0x3816710*/ void MoveNext(ref int index);
                    /*0x38159dc*/ void ThrowForEmptyQueue();
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

                    /*0x791cbd4*/ PlayerLoopRunner(Cysharp.Threading.Tasks.PlayerLoopTiming timing);
                    /*0x791ce48*/ void AddAction(Cysharp.Threading.Tasks.IPlayerLoopItem item);
                    /*0x793c0a8*/ void Run();
                    /*0x793c0ac*/ void RunCore();

                    class <>c
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.Internal.PlayerLoopRunner.<> <>9;
                        static /*0x8*/ System.Action<System.Exception> <>9__9_0;

                        static /*0x793ca84*/ <>c();
                        /*0x793caec*/ <>c();
                        /*0x793caf4*/ void <.ctor>b__9_0(System.Exception ex);
                    }
                }

                class PooledDelegate<T> : Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.Internal.PooledDelegate<T>>
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.Internal.PooledDelegate<T>> pool;
                    /*0x0*/ Cysharp.Threading.Tasks.Internal.PooledDelegate<T> nextNode;
                    /*0x0*/ System.Action<T> runDelegate;
                    /*0x0*/ System.Action continuation;

                    static /*0x383e7a0*/ PooledDelegate();
                    static /*0x38379c4*/ System.Action<T> Create(System.Action continuation);
                    /*0x38159dc*/ PooledDelegate();
                    /*0x38148bc*/ ref Cysharp.Threading.Tasks.Internal.PooledDelegate<T> get_NextNode();
                    /*0x3910ae8*/ void Run(T _);

                    class <>c<T>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.Internal.PooledDelegate.<>c<T> <>9;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3814574*/ int <.cctor>b__4_0();
                    }
                }

                class RuntimeHelpersAbstraction
                {
                    static /*0x3821564*/ bool IsWellKnownNoReferenceContainsType<T>();
                    static /*0x793cb4c*/ bool WellKnownNoReferenceContainsTypeInitialize(System.Type t);

                    class WellKnownNoReferenceContainsType<T>
                    {
                        static /*0x0*/ bool IsWellKnownType;

                        static /*0x383e7a0*/ WellKnownNoReferenceContainsType();
                    }
                }

                class StateTuple
                {
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1> Create<T1>(T1 item1);
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2);
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3);
                }

                class StateTuple<T1> : System.IDisposable
                {
                    /*0x0*/ T1 Item1;

                    /*0x38159dc*/ StateTuple();
                    /*0x38159dc*/ void Dispose();
                }

                class StatePool<T1>
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<Cysharp.Threading.Tasks.Internal.StateTuple<T1>> queue;

                    static /*0x383e7a0*/ StatePool();
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1> Create(T1 item1);
                    static /*0x3840c74*/ void Return(Cysharp.Threading.Tasks.Internal.StateTuple<T1> tuple);
                }

                class StateTuple<T1, T2> : System.IDisposable
                {
                    /*0x0*/ T1 Item1;
                    /*0x0*/ T2 Item2;

                    /*0x38159dc*/ StateTuple();
                    /*0x38159dc*/ void Dispose();
                }

                class StatePool<T1, T2>
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2>> queue;

                    static /*0x383e7a0*/ StatePool();
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2> Create(T1 item1, T2 item2);
                    static /*0x3840c74*/ void Return(Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2> tuple);
                }

                class StateTuple<T1, T2, T3> : System.IDisposable
                {
                    /*0x0*/ T1 Item1;
                    /*0x0*/ T2 Item2;
                    /*0x0*/ T3 Item3;

                    /*0x38159dc*/ StateTuple();
                    /*0x38159dc*/ void Dispose();
                }

                class StatePool<T1, T2, T3>
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3>> queue;

                    static /*0x383e7a0*/ StatePool();
                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3> Create(T1 item1, T2 item2, T3 item3);
                    static /*0x3840c74*/ void Return(Cysharp.Threading.Tasks.Internal.StateTuple<T1, T2, T3> tuple);
                }

                class UnityWebRequestResultExtensions
                {
                    static /*0x792b22c*/ bool IsError(UnityEngine.Networking.UnityWebRequest unityWebRequest);
                }

                struct ValueStopwatch
                {
                    static /*0x0*/ double TimestampToTicks;
                    /*0x10*/ long startTimestamp;

                    static /*0x793d028*/ ValueStopwatch();
                    static /*0x791e248*/ Cysharp.Threading.Tasks.Internal.ValueStopwatch StartNew();
                    /*0x793d020*/ ValueStopwatch(long startTimestamp);
                    /*0x7923f5c*/ bool get_IsInvalid();
                    /*0x791e06c*/ long get_ElapsedTicks();
                }

                class SingleAssignmentDisposable : System.IDisposable
                {
                    /*0x10*/ object gate;
                    /*0x18*/ System.IDisposable current;
                    /*0x20*/ bool disposed;

                    /*0x793d440*/ SingleAssignmentDisposable();
                    /*0x793d0b0*/ void set_Disposable(System.IDisposable value);
                    /*0x793d2b4*/ void Dispose();
                }
            }

            namespace CompilerServices
            {
                struct AsyncUniTaskMethodBuilder
                {
                    /*0x10*/ Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise runnerPromise;
                    /*0x18*/ System.Exception ex;

                    static /*0x793d4ac*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder Create();
                    /*0x793d4b8*/ Cysharp.Threading.Tasks.UniTask get_Task();
                    /*0x793d5ac*/ void SetException(System.Exception exception);
                    /*0x793d66c*/ void SetResult();
                    /*0x3816810*/ void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
                    /*0x3816710*/ void Start<TStateMachine>(ref TStateMachine stateMachine);
                    /*0x79294e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct AsyncUniTaskMethodBuilder<T>
                {
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T> runnerPromise;
                    /*0x0*/ System.Exception ex;
                    /*0x0*/ T result;

                    static /*0x3910ae8*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> Create();
                    /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                    /*0x3816710*/ void SetException(System.Exception exception);
                    /*0x3910ae8*/ void SetResult(T result);
                    /*0x3816810*/ void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
                    /*0x3816710*/ void Start<TStateMachine>(ref TStateMachine stateMachine);
                    /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct AsyncUniTaskVoidMethodBuilder
                {
                    /*0x10*/ Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner runner;

                    static /*0x793d718*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder Create();
                    /*0x793d720*/ Cysharp.Threading.Tasks.UniTaskVoid get_Task();
                    /*0x793d728*/ void SetException(System.Exception exception);
                    /*0x793d848*/ void SetResult();
                    /*0x3816810*/ void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
                    /*0x3816710*/ void Start<TStateMachine>(ref TStateMachine stateMachine);
                    /*0x7928d70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                interface IStateMachineRunner
                {
                    /*0x38148bc*/ System.Action get_MoveNext();
                    /*0x38148bc*/ System.Action get_ReturnAction();
                }

                interface IStateMachineRunnerPromise : Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x38148bc*/ System.Action get_MoveNext();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask get_Task();
                    /*0x38159dc*/ void SetResult();
                    /*0x3816710*/ void SetException(System.Exception exception);
                }

                interface IStateMachineRunnerPromise<T> : Cysharp.Threading.Tasks.IUniTaskSource<T>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    /*0x38148bc*/ System.Action get_MoveNext();
                    /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                    /*0x3910ae8*/ void SetResult(T result);
                    /*0x3816710*/ void SetException(System.Exception exception);
                }

                class AsyncUniTaskVoid<TStateMachine> : Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner, Cysharp.Threading.Tasks.ITaskPoolNode<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine>>, Cysharp.Threading.Tasks.IUniTaskSource
                {
                    static /*0x0*/ Cysharp.Threading.Tasks.TaskPool<Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine>> pool;
                    /*0x0*/ System.Action <ReturnAction>k__BackingField;
                    /*0x0*/ TStateMachine stateMachine;
                    /*0x0*/ System.Action <MoveNext>k__BackingField;
                    /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine> nextNode;

                    static /*0x383e7a0*/ AsyncUniTaskVoid();
                    static /*0x3843dfc*/ void SetStateMachine(ref TStateMachine stateMachine, ref Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunner runnerFieldRef);
                    /*0x38159dc*/ AsyncUniTaskVoid();
                    /*0x38148bc*/ System.Action get_ReturnAction();
                    /*0x38148bc*/ System.Action get_MoveNext();
                    /*0x38148bc*/ ref Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid<TStateMachine> get_NextNode();
                    /*0x38159dc*/ void Return();
                    /*0x38159dc*/ void Run();
                    Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus();
                    void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(System.Action<object> continuation, object state, short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);

                    class <>c<TStateMachine>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoid.<>c<TStateMachine> <>9;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3814574*/ int <.cctor>b__10_0();
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

                    static /*0x383e7a0*/ AsyncUniTask();
                    static /*0x3843dfc*/ void SetStateMachine(ref TStateMachine stateMachine, ref Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise runnerPromiseFieldRef);
                    /*0x38159dc*/ AsyncUniTask();
                    /*0x38148bc*/ System.Action get_MoveNext();
                    /*0x38148bc*/ ref Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine> get_NextNode();
                    /*0x38159dc*/ void Return();
                    /*0x38159dc*/ void Run();
                    /*0x3815874*/ Cysharp.Threading.Tasks.UniTask get_Task();
                    /*0x38159dc*/ void SetResult();
                    /*0x3816710*/ void SetException(System.Exception exception);
                    void GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<TStateMachine>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<TStateMachine> <>9;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3814574*/ int <.cctor>b__12_0();
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

                    static /*0x383e7a0*/ AsyncUniTask();
                    static /*0x3843dfc*/ void SetStateMachine(ref TStateMachine stateMachine, ref Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<T> runnerPromiseFieldRef);
                    /*0x38159dc*/ AsyncUniTask();
                    /*0x38148bc*/ System.Action get_MoveNext();
                    /*0x38148bc*/ ref Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<TStateMachine, T> get_NextNode();
                    /*0x38159dc*/ void Return();
                    /*0x38159dc*/ void Run();
                    /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> get_Task();
                    /*0x3910ae8*/ void SetResult(T result);
                    /*0x3816710*/ void SetException(System.Exception exception);
                    /*0x3910ae8*/ T GetResult(short token);
                    void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token);
                    Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                    /*0x3814574*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                    void OnCompleted(System.Action<object> continuation, object state, short token);

                    class <>c<TStateMachine, T>
                    {
                        static /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<TStateMachine, T> <>9;

                        static /*0x383e7a0*/ <>c();
                        /*0x38159dc*/ <>c();
                        /*0x3814574*/ int <.cctor>b__12_0();
                    }
                }
            }
        }
    }
}
