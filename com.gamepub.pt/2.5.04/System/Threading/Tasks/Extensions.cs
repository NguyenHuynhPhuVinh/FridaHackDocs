class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x2b1c664*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x2b1c66c*/ IsReadOnlyAttribute();
            }
        }
    }

    class ThrowHelper
    {
        static /*0x2b1c67c*/ void ThrowArgumentNullException(System.ExceptionArgument argument);
        static /*0x2b1c718*/ void ThrowArgumentOutOfRangeException(System.ExceptionArgument argument);
        static /*0x2b1c6a8*/ System.ArgumentNullException GetArgumentNullException(System.ExceptionArgument argument);
        static /*0x2b1c744*/ System.ArgumentOutOfRangeException GetArgumentOutOfRangeException(System.ExceptionArgument argument);
        static /*0x2b1c7b4*/ string GetArgumentName(System.ExceptionArgument argument);
    }

    enum ExceptionArgument
    {
        task = 0,
        source = 1,
        state = 2,
    }

    namespace Threading
    {
        namespace Tasks
        {
            struct ValueTask : System.IEquatable<System.Threading.Tasks.ValueTask>
            {
                static /*0x0*/ System.Threading.Tasks.Task s_canceledTask;
                static /*0x8*/ System.Threading.Tasks.Task <CompletedTask>k__BackingField;
                /*0x10*/ object _obj;
                /*0x18*/ short _token;
                /*0x1a*/ bool _continueOnCapturedContext;

                static /*0x2b1cc08*/ ValueTask();
                static /*0x2b1c834*/ System.Threading.Tasks.Task get_CompletedTask();
                /*0xb4b18c*/ ValueTask(System.Threading.Tasks.Task task);
                /*0xb4b1b4*/ ValueTask(object obj, short token, bool continueOnCapturedContext);
                /*0xb4b1c8*/ int GetHashCode();
                /*0xb4b1e0*/ bool Equals(object obj);
                /*0xb4b1e8*/ bool Equals(System.Threading.Tasks.ValueTask other);
                /*0xb4b20c*/ bool get_IsCompleted();
                /*0xb4b32c*/ void ThrowIfCompletedUnsuccessfully();
                /*0xb4b458*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext);
            }

            struct ValueTask<TResult> : System.IEquatable<System.Threading.Tasks.ValueTask<TResult>>
            {
                /*0x0*/ object _obj;
                /*0x0*/ TResult _result;
                /*0x0*/ short _token;
                /*0x0*/ bool _continueOnCapturedContext;

                ValueTask(TResult result);
                ValueTask(System.Threading.Tasks.Task<TResult> task);
                ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext);
                int GetHashCode();
                bool Equals(object obj);
                bool Equals(System.Threading.Tasks.ValueTask<TResult> other);
                bool get_IsCompleted();
                bool get_IsCompletedSuccessfully();
                TResult get_Result();
                System.Runtime.CompilerServices.ValueTaskAwaiter<TResult> GetAwaiter();
                System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext);
                string ToString();
            }

            namespace Sources
            {
                enum ValueTaskSourceOnCompletedFlags
                {
                    None = 0,
                    UseSchedulingContext = 1,
                    FlowExecutionContext = 2,
                }

                enum ValueTaskSourceStatus
                {
                    Pending = 0,
                    Succeeded = 1,
                    Faulted = 2,
                    Canceled = 3,
                }

                interface IValueTaskSource
                {
                    System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    void GetResult(short token);
                }

                interface IValueTaskSource<TResult>
                {
                    System.Threading.Tasks.Sources.ValueTaskSourceStatus GetStatus(short token);
                    void OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    TResult GetResult(short token);
                }
            }
        }
    }

    namespace Runtime
    {
        namespace CompilerServices
        {
            class AsyncMethodBuilderAttribute : System.Attribute
            {
                /*0x10*/ System.Type <BuilderType>k__BackingField;

                /*0x2b1c5ac*/ AsyncMethodBuilderAttribute(System.Type builderType);
            }

            struct AsyncValueTaskMethodBuilder
            {
                /*0x10*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder _methodBuilder;
                /*0x28*/ bool _haveResult;
                /*0x29*/ bool _useBuilder;

                static /*0x2b1c5d8*/ System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder Create();
                void Start<TStateMachine>(ref TStateMachine stateMachine);
                /*0xb4b138*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                /*0xb4b144*/ void SetResult();
                /*0xb4b164*/ void SetException(System.Exception exception);
                /*0xb4b170*/ System.Threading.Tasks.ValueTask get_Task();
                void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
            }

            struct AsyncValueTaskMethodBuilder<TResult>
            {
                /*0x0*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<TResult> _methodBuilder;
                /*0x0*/ TResult _result;
                /*0x0*/ bool _haveResult;
                /*0x0*/ bool _useBuilder;

                static System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<TResult> Create();
                void Start<TStateMachine>(ref TStateMachine stateMachine);
                void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                void SetResult(TResult result);
                void SetException(System.Exception exception);
                System.Threading.Tasks.ValueTask<TResult> get_Task();
                void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine);
            }

            struct ConfiguredValueTaskAwaitable
            {
                /*0x10*/ System.Threading.Tasks.ValueTask _value;

                /*0xb4b178*/ ConfiguredValueTaskAwaitable(System.Threading.Tasks.ValueTask value);
                /*0xb4b180*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter GetAwaiter();

                struct ConfiguredValueTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ System.Threading.Tasks.ValueTask _value;

                    /*0xb4b4bc*/ ConfiguredValueTaskAwaiter(System.Threading.Tasks.ValueTask value);
                    /*0xb4b4c4*/ bool get_IsCompleted();
                    /*0xb4b5e4*/ void GetResult();
                    /*0xb4b710*/ void OnCompleted(System.Action continuation);
                    /*0xb4b718*/ void UnsafeOnCompleted(System.Action continuation);
                }
            }

            struct ConfiguredValueTaskAwaitable<TResult>
            {
                /*0x0*/ System.Threading.Tasks.ValueTask<TResult> _value;

                ConfiguredValueTaskAwaitable(System.Threading.Tasks.ValueTask<TResult> value);
                System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<TResult> GetAwaiter();

                struct ConfiguredValueTaskAwaiter<TResult> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x0*/ System.Threading.Tasks.ValueTask<TResult> _value;

                    ConfiguredValueTaskAwaiter(System.Threading.Tasks.ValueTask<TResult> value);
                    bool get_IsCompleted();
                    TResult GetResult();
                    void OnCompleted(System.Action continuation);
                    void UnsafeOnCompleted(System.Action continuation);
                }
            }

            struct ValueTaskAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
            {
                static /*0x0*/ System.Action<object> s_invokeActionDelegate;
                /*0x10*/ System.Threading.Tasks.ValueTask _value;

                static /*0x2b1d0b4*/ ValueTaskAwaiter();
                /*0xb4b4ac*/ void OnCompleted(System.Action continuation);
                /*0xb4b4b4*/ void UnsafeOnCompleted(System.Action continuation);

                class <>c
                {
                    static /*0x0*/ System.Runtime.CompilerServices.ValueTaskAwaiter.<> <>9;

                    static /*0x2b1d810*/ <>c();
                    /*0x2b1d870*/ <>c();
                    /*0x2b1d878*/ void <.cctor>b__9_0(object state);
                }
            }

            struct ValueTaskAwaiter<TResult> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
            {
                /*0x0*/ System.Threading.Tasks.ValueTask<TResult> _value;

                ValueTaskAwaiter(System.Threading.Tasks.ValueTask<TResult> value);
                bool get_IsCompleted();
                TResult GetResult();
                void OnCompleted(System.Action continuation);
                void UnsafeOnCompleted(System.Action continuation);
            }
        }
    }

    namespace Diagnostics
    {
        class StackTraceHiddenAttribute : System.Attribute
        {
            /*0x2b1c674*/ StackTraceHiddenAttribute();
        }
    }
}
