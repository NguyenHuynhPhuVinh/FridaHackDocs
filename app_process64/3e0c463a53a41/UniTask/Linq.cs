class <Module>
{
}

namespace Cysharp
{
    namespace Threading
    {
        namespace Tasks
        {
            namespace Linq
            {
                class UniTaskAsyncEnumerable
                {
                    static /*0x382eaf0*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T> Create<T>(System.Func<Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> create);
                }

                interface IAsyncWriter<T>
                {
                    /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask YieldAsync(T value);
                }

                class Create<T> : Cysharp.Threading.Tasks.IUniTaskAsyncEnumerable<T>
                {
                    /*0x0*/ System.Func<Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> create;

                    /*0x380d83c*/ Create(System.Func<Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> create);
                    /*0x380ba14*/ Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);

                    class _Create<T> : Cysharp.Threading.Tasks.MoveNextSource, Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator<T>, Cysharp.Threading.Tasks.IUniTaskAsyncDisposable
                    {
                        /*0x0*/ System.Func<Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> create;
                        /*0x0*/ System.Threading.CancellationToken cancellationToken;
                        /*0x0*/ int state;
                        /*0x0*/ Cysharp.Threading.Tasks.Linq.Create.AsyncWriter<T> writer;
                        /*0x0*/ T <Current>k__BackingField;

                        /*0x3907c14*/ _Create(System.Func<Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>, System.Threading.CancellationToken, Cysharp.Threading.Tasks.UniTask> create, System.Threading.CancellationToken cancellationToken);
                        /*0x3907c14*/ T get_Current();
                        /*0x3907c14*/ void set_Current(T value);
                        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask DisposeAsync();
                        /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> MoveNextAsync();
                        /*0x380cb08*/ void MoveNext();
                        /*0x3907c14*/ Cysharp.Threading.Tasks.UniTaskVoid RunWriterTask(Cysharp.Threading.Tasks.UniTask task);
                        /*0x3907c14*/ void SetResult(T value);

                        struct <RunWriterTask>d__12<T> : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x0*/ int <>1__state;
                            /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskVoidMethodBuilder <>t__builder;
                            /*0x0*/ Cysharp.Threading.Tasks.UniTask task;
                            /*0x0*/ Cysharp.Threading.Tasks.Linq.Create._Create<T> <>4__this;
                            /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                            /*0x380cb08*/ void MoveNext();
                            /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    class AsyncWriter<T> : Cysharp.Threading.Tasks.IUniTaskSource, Cysharp.Threading.Tasks.Linq.IAsyncWriter<T>
                    {
                        /*0x0*/ Cysharp.Threading.Tasks.Linq.Create._Create<T> enumerator;
                        /*0x0*/ Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit> core;

                        /*0x380d83c*/ AsyncWriter(Cysharp.Threading.Tasks.Linq.Create._Create<T> enumerator);
                        void GetResult(short token);
                        Cysharp.Threading.Tasks.UniTaskStatus GetStatus(short token);
                        /*0x380b6a0*/ Cysharp.Threading.Tasks.UniTaskStatus UnsafeGetStatus();
                        void OnCompleted(System.Action<object> continuation, object state, short token);
                        /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask YieldAsync(T value);
                        /*0x380cb08*/ void SignalWriter();
                    }
                }
            }
        }
    }
}
