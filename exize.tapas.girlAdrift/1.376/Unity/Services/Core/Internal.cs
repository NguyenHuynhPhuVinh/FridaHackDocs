class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Wire
        {
            namespace Internal
            {
                struct ChannelToken
                {
                    /*0x10*/ string ChannelName;
                    /*0x18*/ string Token;
                }

                interface IChannel : System.IDisposable
                {
                    void add_MessageReceived(System.Action<string> value);
                    void remove_MessageReceived(System.Action<string> value);
                    void add_BinaryMessageReceived(System.Action<System.Byte[]> value);
                    void remove_BinaryMessageReceived(System.Action<System.Byte[]> value);
                    void add_KickReceived(System.Action value);
                    void remove_KickReceived(System.Action value);
                    void add_NewStateReceived(System.Action<Unity.Services.Wire.Internal.SubscriptionState> value);
                    void remove_NewStateReceived(System.Action<Unity.Services.Wire.Internal.SubscriptionState> value);
                    void add_ErrorReceived(System.Action<string> value);
                    void remove_ErrorReceived(System.Action<string> value);
                    System.Threading.Tasks.Task SubscribeAsync();
                    System.Threading.Tasks.Task UnsubscribeAsync();
                }

                interface IChannelTokenProvider
                {
                    System.Threading.Tasks.Task<Unity.Services.Wire.Internal.ChannelToken> GetTokenAsync();
                }

                interface IWire : Unity.Services.Core.Internal.IServiceComponent
                {
                    Unity.Services.Wire.Internal.IChannel CreateChannel(Unity.Services.Wire.Internal.IChannelTokenProvider tokenProvider);
                }

                enum SubscriptionState
                {
                    Unsubscribed = 0,
                    Synced = 1,
                    Unsynced = 2,
                    Error = 3,
                    Subscribing = 4,
                }
            }
        }

        namespace Vivox
        {
            namespace Internal
            {
                interface IVivox : Unity.Services.Core.Internal.IServiceComponent
                {
                    void RegisterTokenProvider(Unity.Services.Vivox.Internal.IVivoxTokenProviderInternal tokenProvider);
                }

                interface IVivoxTokenProviderInternal
                {
                    System.Threading.Tasks.Task<string> GetTokenAsync(string issuer, System.Nullable<System.TimeSpan> expiration, string userUri, string action, string conferenceUri, string fromUserUri, string realm);
                }
            }
        }

        namespace Qos
        {
            namespace Internal
            {
                interface IQosResults : Unity.Services.Core.Internal.IServiceComponent
                {
                    System.Threading.Tasks.Task<System.Collections.Generic.IList<Unity.Services.Qos.Internal.QosResult>> GetSortedQosResultsAsync(string service, System.Collections.Generic.IList<string> regions);
                }

                struct QosResult
                {
                    /*0x10*/ string Region;
                    /*0x18*/ int AverageLatencyMs;
                    /*0x1c*/ float PacketLossPercent;
                }
            }
        }

        namespace Authentication
        {
            namespace Internal
            {
                interface IAccessToken : Unity.Services.Core.Internal.IServiceComponent
                {
                    string get_AccessToken();
                }

                interface IEnvironmentId : Unity.Services.Core.Internal.IServiceComponent
                {
                    string get_EnvironmentId();
                }

                interface IPlayerId : Unity.Services.Core.Internal.IServiceComponent
                {
                    string get_PlayerId();
                    void add_PlayerIdChanged(System.Action<string> value);
                    void remove_PlayerIdChanged(System.Action<string> value);
                }
            }
        }

        namespace Core
        {
            namespace Threading
            {
                namespace Internal
                {
                    interface IUnityThreadUtils : Unity.Services.Core.Internal.IServiceComponent
                    {
                        bool get_IsRunningOnUnityThread();
                        System.Threading.Tasks.Task PostAsync(System.Action action);
                        System.Threading.Tasks.Task PostAsync(System.Action<object> action, object state);
                        System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<T> action);
                        System.Threading.Tasks.Task<T> PostAsync<T>(System.Func<object, T> action, object state);
                        void Send(System.Action action);
                        void Send(System.Action<object> action, object state);
                        T Send<T>(System.Func<T> action);
                        T Send<T>(System.Func<object, T> action, object state);
                    }
                }
            }

            namespace Telemetry
            {
                namespace Internal
                {
                    interface IDiagnostics
                    {
                        void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IDiagnosticsComponentProvider
                    {
                        System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> CreateDiagnosticsComponents();
                        System.Threading.Tasks.Task<string> GetSerializedProjectConfigurationAsync();
                    }

                    interface IDiagnosticsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        System.Collections.Generic.IReadOnlyDictionary<string, string> get_CommonTags();
                        Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    interface IMetrics
                    {
                        void SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IMetricsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        System.Collections.Generic.IReadOnlyDictionary<string, string> get_CommonTags();
                        Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
                    }
                }
            }

            namespace Scheduler
            {
                namespace Internal
                {
                    interface IActionScheduler : Unity.Services.Core.Internal.IServiceComponent
                    {
                        long ScheduleAction(System.Action action, double delaySeconds);
                        void CancelAction(long actionId);
                    }
                }
            }

            namespace Networking
            {
                namespace Internal
                {
                    struct HttpOptions
                    {
                        /*0x10*/ int RequestTimeoutInSeconds;
                        /*0x14*/ int RedirectLimit;
                    }

                    class HttpRequest
                    {
                        /*0x10*/ string Method;
                        /*0x18*/ string Url;
                        /*0x20*/ System.Collections.Generic.Dictionary<string, string> Headers;
                        /*0x28*/ byte[] Body;
                        /*0x30*/ Unity.Services.Core.Networking.Internal.HttpOptions Options;

                        /*0x166f3a0*/ HttpRequest();
                        /*0x166f3a8*/ HttpRequest(string method, string url, System.Collections.Generic.Dictionary<string, string> headers, byte[] body);
                        /*0x166f3e8*/ Unity.Services.Core.Networking.Internal.HttpRequest SetMethod(string method);
                        /*0x166f3f0*/ Unity.Services.Core.Networking.Internal.HttpRequest SetUrl(string url);
                        /*0x166f3f8*/ Unity.Services.Core.Networking.Internal.HttpRequest SetHeader(string key, string value);
                        /*0x166f4b4*/ Unity.Services.Core.Networking.Internal.HttpRequest SetHeaders(System.Collections.Generic.Dictionary<string, string> headers);
                        /*0x166f4bc*/ Unity.Services.Core.Networking.Internal.HttpRequest SetBody(byte[] body);
                        /*0x166f4c4*/ Unity.Services.Core.Networking.Internal.HttpRequest SetOptions(Unity.Services.Core.Networking.Internal.HttpOptions options);
                        /*0x166f4cc*/ Unity.Services.Core.Networking.Internal.HttpRequest SetRedirectLimit(int redirectLimit);
                        /*0x166f4d4*/ Unity.Services.Core.Networking.Internal.HttpRequest SetTimeOutInSeconds(int timeout);
                    }

                    class HttpRequestExtensions
                    {
                        static /*0x166f4dc*/ Unity.Services.Core.Networking.Internal.HttpRequest AsGet(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f530*/ Unity.Services.Core.Networking.Internal.HttpRequest AsPost(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f584*/ Unity.Services.Core.Networking.Internal.HttpRequest AsPut(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f5d8*/ Unity.Services.Core.Networking.Internal.HttpRequest AsDelete(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f62c*/ Unity.Services.Core.Networking.Internal.HttpRequest AsPatch(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f680*/ Unity.Services.Core.Networking.Internal.HttpRequest AsHead(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f6d4*/ Unity.Services.Core.Networking.Internal.HttpRequest AsConnect(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f728*/ Unity.Services.Core.Networking.Internal.HttpRequest AsOptions(Unity.Services.Core.Networking.Internal.HttpRequest self);
                        static /*0x166f77c*/ Unity.Services.Core.Networking.Internal.HttpRequest AsTrace(Unity.Services.Core.Networking.Internal.HttpRequest self);
                    }

                    class HttpResponse
                    {
                        /*0x10*/ Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest Request;
                        /*0x18*/ System.Collections.Generic.Dictionary<string, string> Headers;
                        /*0x20*/ byte[] Data;
                        /*0x28*/ long StatusCode;
                        /*0x30*/ string ErrorMessage;
                        /*0x38*/ bool IsHttpError;
                        /*0x39*/ bool IsNetworkError;

                        /*0x166f888*/ HttpResponse();
                        /*0x166f7d0*/ Unity.Services.Core.Networking.Internal.HttpResponse SetRequest(Unity.Services.Core.Networking.Internal.HttpRequest request);
                        /*0x166f7d8*/ Unity.Services.Core.Networking.Internal.HttpResponse SetRequest(Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest request);
                        /*0x166f7e0*/ Unity.Services.Core.Networking.Internal.HttpResponse SetHeader(string key, string value);
                        /*0x166f850*/ Unity.Services.Core.Networking.Internal.HttpResponse SetHeaders(System.Collections.Generic.Dictionary<string, string> headers);
                        /*0x166f858*/ Unity.Services.Core.Networking.Internal.HttpResponse SetData(byte[] data);
                        /*0x166f860*/ Unity.Services.Core.Networking.Internal.HttpResponse SetStatusCode(long statusCode);
                        /*0x166f868*/ Unity.Services.Core.Networking.Internal.HttpResponse SetErrorMessage(string errorMessage);
                        /*0x166f870*/ Unity.Services.Core.Networking.Internal.HttpResponse SetIsHttpError(bool isHttpError);
                        /*0x166f87c*/ Unity.Services.Core.Networking.Internal.HttpResponse SetIsNetworkError(bool isNetworkError);
                    }

                    interface IHttpClient : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string GetBaseUrlFor(string serviceId);
                        Unity.Services.Core.Networking.Internal.HttpOptions GetDefaultOptionsFor(string serviceId);
                        Unity.Services.Core.Networking.Internal.HttpRequest CreateRequestForService(string serviceId, string resourcePath);
                        Unity.Services.Core.Internal.IAsyncOperation<Unity.Services.Core.Networking.Internal.ReadOnlyHttpResponse> Send(Unity.Services.Core.Networking.Internal.HttpRequest request);
                    }

                    struct ReadOnlyHttpRequest
                    {
                        /*0x10*/ Unity.Services.Core.Networking.Internal.HttpRequest m_Request;

                        /*0x166f890*/ ReadOnlyHttpRequest(Unity.Services.Core.Networking.Internal.HttpRequest request);
                        /*0x166f898*/ string get_Method();
                        /*0x166f8b4*/ string get_Url();
                        /*0x166f8d0*/ System.Collections.Generic.IReadOnlyDictionary<string, string> get_Headers();
                        /*0x166f8ec*/ byte[] get_Body();
                    }

                    struct ReadOnlyHttpResponse
                    {
                        /*0x10*/ Unity.Services.Core.Networking.Internal.HttpResponse m_Response;

                        /*0x166f908*/ ReadOnlyHttpResponse(Unity.Services.Core.Networking.Internal.HttpResponse response);
                        /*0x166f910*/ Unity.Services.Core.Networking.Internal.ReadOnlyHttpRequest get_Request();
                        /*0x166f92c*/ System.Collections.Generic.IReadOnlyDictionary<string, string> get_Headers();
                        /*0x166f948*/ byte[] get_Data();
                        /*0x166f964*/ long get_StatusCode();
                        /*0x166f980*/ string get_ErrorMessage();
                        /*0x166f99c*/ bool get_IsHttpError();
                        /*0x166f9b8*/ bool get_IsNetworkError();
                    }
                }
            }

            namespace Environments
            {
                namespace Internal
                {
                    interface IEnvironments : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string get_Current();
                    }
                }
            }

            namespace Device
            {
                namespace Internal
                {
                    interface IInstallationId : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string GetOrCreateIdentifier();
                    }
                }
            }

            namespace Configuration
            {
                namespace Internal
                {
                    interface ICloudProjectId : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string GetCloudProjectId();
                    }

                    interface IExternalUserId : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string get_UserId();
                        void add_UserIdChanged(System.Action<string> value);
                        void remove_UserIdChanged(System.Action<string> value);
                    }

                    interface IProjectConfiguration : Unity.Services.Core.Internal.IServiceComponent
                    {
                        bool GetBool(string key, bool defaultValue);
                        int GetInt(string key, int defaultValue);
                        float GetFloat(string key, float defaultValue);
                        string GetString(string key, string defaultValue);
                    }
                }
            }

            namespace Internal
            {
                class AsyncOperation : Unity.Services.Core.Internal.IAsyncOperation, System.Collections.IEnumerator
                {
                    /*0x10*/ bool <IsDone>k__BackingField;
                    /*0x14*/ Unity.Services.Core.Internal.AsyncOperationStatus <Status>k__BackingField;
                    /*0x18*/ System.Exception <Exception>k__BackingField;
                    /*0x20*/ System.Action<Unity.Services.Core.Internal.IAsyncOperation> m_CompletedCallback;

                    /*0x166fcdc*/ AsyncOperation();
                    /*0x166f9d4*/ bool get_IsDone();
                    /*0x166f9dc*/ void set_IsDone(bool value);
                    /*0x166f9e8*/ Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    /*0x166f9f0*/ void set_Status(Unity.Services.Core.Internal.AsyncOperationStatus value);
                    /*0x166f9f8*/ void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    /*0x166fad0*/ void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    /*0x166fb78*/ System.Exception get_Exception();
                    /*0x166fb80*/ void set_Exception(System.Exception value);
                    /*0x166fb88*/ void SetInProgress();
                    /*0x166fb94*/ void Succeed();
                    /*0x166fbdc*/ void Fail(System.Exception reason);
                    /*0x166fc28*/ void Cancel();
                    /*0x166fcc0*/ bool System.Collections.IEnumerator.MoveNext();
                    /*0x166fcd0*/ void System.Collections.IEnumerator.Reset();
                    /*0x166fcd4*/ object System.Collections.IEnumerator.get_Current();
                }

                class AsyncOperation<T> : Unity.Services.Core.Internal.IAsyncOperation<T>, System.Collections.IEnumerator
                {
                    /*0x0*/ bool <IsDone>k__BackingField;
                    /*0x0*/ Unity.Services.Core.Internal.AsyncOperationStatus <Status>k__BackingField;
                    /*0x0*/ System.Exception <Exception>k__BackingField;
                    /*0x0*/ T <Result>k__BackingField;
                    /*0x0*/ System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> m_CompletedCallback;

                    AsyncOperation();
                    bool get_IsDone();
                    void set_IsDone(bool value);
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    void set_Status(Unity.Services.Core.Internal.AsyncOperationStatus value);
                    void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> value);
                    void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> value);
                    System.Exception get_Exception();
                    void set_Exception(System.Exception value);
                    T get_Result();
                    void set_Result(T value);
                    void SetInProgress();
                    void Succeed(T result);
                    void Fail(System.Exception reason);
                    void Cancel();
                    bool System.Collections.IEnumerator.MoveNext();
                    void System.Collections.IEnumerator.Reset();
                    object System.Collections.IEnumerator.get_Current();
                }

                struct AsyncOperationAwaiter : Unity.Services.Core.Internal.IAsyncOperationAwaiter, System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ Unity.Services.Core.Internal.IAsyncOperation m_Operation;

                    /*0x166fce4*/ AsyncOperationAwaiter(Unity.Services.Core.Internal.IAsyncOperation asyncOperation);
                    /*0x166fcec*/ void OnCompleted(System.Action continuation);
                    /*0x166fe20*/ void UnsafeOnCompleted(System.Action continuation);
                    /*0x166ff54*/ bool get_IsCompleted();
                    /*0x166fff4*/ void GetResult();

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Action continuation;

                        /*0x166fe18*/ <>c__DisplayClass2_0();
                        /*0x1670154*/ void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation operation);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ System.Action continuation;

                        /*0x166ff4c*/ <>c__DisplayClass3_0();
                        /*0x1670178*/ void <UnsafeOnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation operation);
                    }
                }

                struct AsyncOperationAwaiter<T> : Unity.Services.Core.Internal.IAsyncOperationAwaiter<T>, System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x0*/ Unity.Services.Core.Internal.IAsyncOperation<T> m_Operation;

                    AsyncOperationAwaiter(Unity.Services.Core.Internal.IAsyncOperation<T> asyncOperation);
                    void OnCompleted(System.Action continuation);
                    void UnsafeOnCompleted(System.Action continuation);
                    bool get_IsCompleted();
                    T GetResult();

                    class <>c__DisplayClass2_0<T>
                    {
                        /*0x0*/ System.Action continuation;

                        <>c__DisplayClass2_0();
                        void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation<T> obj);
                    }

                    class <>c__DisplayClass3_0<T>
                    {
                        /*0x0*/ System.Action continuation;

                        <>c__DisplayClass3_0();
                        void <UnsafeOnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation<T> obj);
                    }
                }

                class AsyncOperationBase : UnityEngine.CustomYieldInstruction, Unity.Services.Core.Internal.IAsyncOperation, System.Collections.IEnumerator, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ System.Action<Unity.Services.Core.Internal.IAsyncOperation> m_CompletedCallback;

                    /*0x1670444*/ AsyncOperationBase();
                    /*0x167019c*/ bool get_keepWaiting();
                    bool get_IsCompleted();
                    /*0x16701c0*/ bool get_IsDone();
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    System.Exception get_Exception();
                    void GetResult();
                    Unity.Services.Core.Internal.AsyncOperationBase GetAwaiter();
                    /*0x16701d0*/ void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    /*0x16702b8*/ void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    /*0x1670360*/ void DidComplete();
                    /*0x1670380*/ void OnCompleted(System.Action continuation);

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ System.Action continuation;

                        /*0x167043c*/ <>c__DisplayClass17_0();
                        /*0x167044c*/ void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation op);
                    }
                }

                class AsyncOperationBase<T> : UnityEngine.CustomYieldInstruction, Unity.Services.Core.Internal.IAsyncOperation<T>, System.Collections.IEnumerator, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x0*/ System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> m_CompletedCallback;

                    AsyncOperationBase();
                    bool get_keepWaiting();
                    bool get_IsCompleted();
                    bool get_IsDone();
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    System.Exception get_Exception();
                    T get_Result();
                    T GetResult();
                    Unity.Services.Core.Internal.AsyncOperationBase<T> GetAwaiter();
                    void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> value);
                    void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> value);
                    void DidComplete();
                    void OnCompleted(System.Action continuation);

                    class <>c__DisplayClass19_0<T>
                    {
                        /*0x0*/ System.Action continuation;

                        <>c__DisplayClass19_0();
                        void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation<T> op);
                    }
                }

                class AsyncOperationExtensions
                {
                    static /*0x1670468*/ Unity.Services.Core.Internal.AsyncOperationAwaiter GetAwaiter(Unity.Services.Core.Internal.IAsyncOperation self);
                    static /*0x167046c*/ System.Threading.Tasks.Task AsTask(Unity.Services.Core.Internal.IAsyncOperation self);
                    static Unity.Services.Core.Internal.AsyncOperationAwaiter<T> GetAwaiter<T>(Unity.Services.Core.Internal.IAsyncOperation<T> self);
                    static System.Threading.Tasks.Task<T> AsTask<T>(Unity.Services.Core.Internal.IAsyncOperation<T> self);

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ System.Threading.Tasks.TaskCompletionSource<object> taskCompletionSource;

                        /*0x1670720*/ <>c__DisplayClass1_0();
                        /*0x1670728*/ void <AsTask>g__CompleteTask|0(Unity.Services.Core.Internal.IAsyncOperation operation);
                    }

                    class <>c__DisplayClass3_0<T>
                    {
                        /*0x0*/ System.Threading.Tasks.TaskCompletionSource<T> taskCompletionSource;

                        <>c__DisplayClass3_0();
                        void <AsTask>g__CompleteTask|0(Unity.Services.Core.Internal.IAsyncOperation<T> operation);
                    }
                }

                enum AsyncOperationStatus
                {
                    None = 0,
                    InProgress = 1,
                    Succeeded = 2,
                    Failed = 3,
                    Cancelled = 4,
                }

                interface IAsyncOperation : System.Collections.IEnumerator
                {
                    bool get_IsDone();
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    System.Exception get_Exception();
                }

                interface IAsyncOperation<T> : System.Collections.IEnumerator
                {
                    bool get_IsDone();
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> value);
                    void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation<T>> value);
                    System.Exception get_Exception();
                    T get_Result();
                }

                interface IAsyncOperationAwaiter : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    bool get_IsCompleted();
                    void GetResult();
                }

                interface IAsyncOperationAwaiter<T> : System.Runtime.CompilerServices.ICriticalNotifyCompletion, System.Runtime.CompilerServices.INotifyCompletion
                {
                    bool get_IsCompleted();
                    T GetResult();
                }

                class TaskAsyncOperation : Unity.Services.Core.Internal.AsyncOperationBase, System.Runtime.CompilerServices.INotifyCompletion
                {
                    static /*0x0*/ System.Threading.Tasks.TaskScheduler Scheduler;
                    /*0x18*/ System.Threading.Tasks.Task m_Task;

                    static /*0x1670b88*/ Unity.Services.Core.Internal.TaskAsyncOperation Run(System.Action action);
                    static /*0x1670b14*/ void SetScheduler();
                    /*0x16709a4*/ TaskAsyncOperation(System.Threading.Tasks.Task task);
                    /*0x1670904*/ bool get_IsCompleted();
                    /*0x1670920*/ Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    /*0x1670988*/ System.Exception get_Exception();
                    /*0x167099c*/ void GetResult();
                    /*0x16709a0*/ Unity.Services.Core.Internal.AsyncOperationBase GetAwaiter();

                    class <>c
                    {
                        static /*0x0*/ Unity.Services.Core.Internal.TaskAsyncOperation.<> <>9;
                        static /*0x8*/ System.Action<System.Threading.Tasks.Task, object> <>9__10_0;

                        static /*0x1670c24*/ <>c();
                        /*0x1670c88*/ <>c();
                        /*0x1670c90*/ void <.ctor>b__10_0(System.Threading.Tasks.Task t, object state);
                    }
                }

                class TaskAsyncOperation<T> : Unity.Services.Core.Internal.AsyncOperationBase<T>
                {
                    /*0x0*/ System.Threading.Tasks.Task<T> m_Task;

                    static Unity.Services.Core.Internal.TaskAsyncOperation<T> Run(System.Func<T> func);
                    TaskAsyncOperation(System.Threading.Tasks.Task<T> task);
                    bool get_IsCompleted();
                    T get_Result();
                    T GetResult();
                    Unity.Services.Core.Internal.AsyncOperationBase<T> GetAwaiter();
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    System.Exception get_Exception();

                    class <>c<T>
                    {
                        static /*0x0*/ Unity.Services.Core.Internal.TaskAsyncOperation.<>c<T> <>9;
                        static /*0x0*/ System.Action<System.Threading.Tasks.Task<T>, object> <>9__11_0;

                        static <>c();
                        <>c();
                        void <.ctor>b__11_0(System.Threading.Tasks.Task<T> t, object state);
                    }
                }

                class CoreLogger
                {
                    static string Tag = "[ServicesCore]";
                    static string VerboseLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_VERBOSE_LOGGING";
                    static string k_TelemetryLoggingDefine = "ENABLE_UNITY_SERVICES_CORE_TELEMETRY_LOGGING";

                    static /*0x1670d30*/ void Log(object message);
                    static /*0x1670e50*/ void LogWarning(object message);
                    static /*0x1670f70*/ void LogError(object message);
                    static /*0x1671090*/ void LogException(System.Exception exception);
                    static /*0x16711b4*/ void LogAssertion(object message);
                    static /*0x16712d8*/ void LogVerbose(object message);
                    static /*0x16713f8*/ void LogTelemetry(object message);
                }

                class CircularDependencyException : Unity.Services.Core.ServicesInitializationException
                {
                    /*0x1671518*/ CircularDependencyException();
                    /*0x1671520*/ CircularDependencyException(string message);
                }

                class ComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField;

                    /*0x1671530*/ ComponentRegistry(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                    /*0x1671528*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance();
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    /*0x1671558*/ bool IsComponentTypeRegistered(int componentTypeHash);
                    /*0x1671620*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                interface IComponentRegistry
                {
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                class LockedComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    static string k_ErrorMessage = "Component registration has been locked. Make sure to register service components before all packages have finished initializing.";
                    /*0x10*/ Unity.Services.Core.Internal.IComponentRegistry <Registry>k__BackingField;

                    /*0x16716a0*/ LockedComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry registryToLock);
                    /*0x1671698*/ Unity.Services.Core.Internal.IComponentRegistry get_Registry();
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    /*0x16716c8*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                struct CoreRegistration
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry m_Registry;
                    /*0x18*/ int m_PackageHash;

                    /*0x1671718*/ CoreRegistration(Unity.Services.Core.Internal.IPackageRegistry registry, int packageHash);
                    Unity.Services.Core.Internal.CoreRegistration DependsOn<T>();
                    Unity.Services.Core.Internal.CoreRegistration OptionallyDependsOn<T>();
                    Unity.Services.Core.Internal.CoreRegistration ProvidesComponent<T>();
                }

                class CoreRegistry
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreRegistry <Instance>k__BackingField;
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <PackageRegistry>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Internal.IComponentRegistry <ComponentRegistry>k__BackingField;

                    static /*0x1671724*/ Unity.Services.Core.Internal.CoreRegistry get_Instance();
                    static /*0x167176c*/ void set_Instance(Unity.Services.Core.Internal.CoreRegistry value);
                    /*0x16717d8*/ CoreRegistry();
                    /*0x1671a90*/ CoreRegistry(Unity.Services.Core.Internal.IPackageRegistry packageRegistry, Unity.Services.Core.Internal.IComponentRegistry componentRegistry);
                    /*0x16717b8*/ Unity.Services.Core.Internal.IPackageRegistry get_PackageRegistry();
                    /*0x16717c0*/ void set_PackageRegistry(Unity.Services.Core.Internal.IPackageRegistry value);
                    /*0x16717c8*/ Unity.Services.Core.Internal.IComponentRegistry get_ComponentRegistry();
                    /*0x16717d0*/ void set_ComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    /*0x1671abc*/ void LockPackageRegistration();
                    /*0x1671b78*/ void LockComponentRegistration();
                }

                class CoreRegistryInitializer
                {
                    /*0x10*/ Unity.Services.Core.Internal.CoreRegistry m_Registry;
                    /*0x18*/ System.Collections.Generic.List<int> m_SortedPackageTypeHashes;

                    /*0x1671c0c*/ CoreRegistryInitializer(Unity.Services.Core.Internal.CoreRegistry registry, System.Collections.Generic.List<int> sortedPackageTypeHashes);
                    /*0x1671c38*/ System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> InitializeRegistryAsync();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ System.Diagnostics.Stopwatch stopwatch;
                        /*0x18*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x20*/ System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packagesInitInfos;
                        /*0x28*/ System.Collections.Generic.List<System.Exception> failureReasons;
                        /*0x30*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;

                        /*0x1671d28*/ <>c__DisplayClass3_0();
                        /*0x1671d30*/ System.Threading.Tasks.Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(Unity.Services.Core.Internal.IInitializablePackage package);
                        /*0x1671e0c*/ Unity.Services.Core.Internal.IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index);
                        /*0x1671e9c*/ void <InitializeRegistryAsync>g__Fail|2();

                        struct <<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>4__this;
                            /*0x38*/ Unity.Services.Core.Internal.IInitializablePackage package;
                            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0x1671f20*/ void MoveNext();
                            /*0x16723a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <InitializeRegistryAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>8__1;
                        /*0x40*/ int <i>5__2;
                        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x16723ac*/ void MoveNext();
                        /*0x16729a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DependencyTree
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance;
                    /*0x18*/ System.Collections.Generic.Dictionary<int, int> ComponentTypeHashToPackageTypeHash;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> PackageTypeHashToComponentTypeHashDependencies;
                    /*0x28*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance;

                    /*0x167191c*/ DependencyTree();
                    /*0x1672a00*/ DependencyTree(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<int, int> componentToPackage, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> packageToComponentDependencies, System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentToInstance);
                }

                class DependencyTreeSortFailedException : System.Exception
                {
                    static /*0x1672ac4*/ string CreateExceptionMessage(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                    /*0x1672a40*/ DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target);
                    /*0x1672ba4*/ DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                }

                class DependencyTreeExtensions
                {
                    static /*0x1672c38*/ string ToJson(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> order);
                    static /*0x1673e70*/ bool IsOptional(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x1673ef0*/ bool IsProvided(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x16733d4*/ Newtonsoft.Json.Linq.JObject GetPackageJObject(Unity.Services.Core.Internal.DependencyTree tree, int packageHash);
                    static /*0x1673b14*/ Newtonsoft.Json.Linq.JObject GetComponentJObject(Unity.Services.Core.Internal.DependencyTree tree, int componentHash);
                    static /*0x1673f4c*/ string GetComponentIdentifier(Unity.Services.Core.Internal.IServiceComponent component);
                }

                struct DependencyTreeInitializeOrderSorter
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree Tree;
                    /*0x18*/ System.Collections.Generic.ICollection<int> Target;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory;

                    /*0x1674004*/ DependencyTreeInitializeOrderSorter(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target);
                    /*0x1674010*/ void SortRegisteredPackagesIntoTarget();
                    /*0x16744e8*/ void RemoveUnprovidedOptionalDependenciesFromTree();
                    /*0x1674990*/ void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<int> dependencyTypeHashes);
                    /*0x1674698*/ void SortTreeThrough(int packageTypeHash);
                    /*0x1674ca0*/ void SortTreeThrough(System.Collections.Generic.IEnumerable<int> dependencyTypeHashes);
                    /*0x1674b44*/ void MarkPackage(int packageTypeHash, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark mark);
                    /*0x1674640*/ System.Collections.Generic.IReadOnlyCollection<int> GetPackageTypeHashes();
                    /*0x1674f8c*/ int GetPackageTypeHashFor(int componentTypeHash);
                    /*0x1674bac*/ System.Collections.Generic.IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash);

                    enum ExplorationMark
                    {
                        None = 0,
                        Viewed = 1,
                        Sorted = 2,
                    }
                }

                class HashException : System.Exception
                {
                    /*0x8c*/ int <Hash>k__BackingField;

                    /*0x1675090*/ HashException(int hash);
                    /*0x16750fc*/ HashException(int hash, string message);
                    /*0x1675168*/ HashException(int hash, string message, System.Exception inner);
                    /*0x1675088*/ int get_Hash();
                }

                class DependencyTreePackageHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x16751ec*/ DependencyTreePackageHashException(int hash);
                    /*0x1675084*/ DependencyTreePackageHashException(int hash, string message);
                    /*0x1674f88*/ DependencyTreePackageHashException(int hash, string message, System.Exception inner);
                }

                class DependencyTreeComponentHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x16751f0*/ DependencyTreeComponentHashException(int hash);
                    /*0x1675080*/ DependencyTreeComponentHashException(int hash, string message);
                    /*0x16751f4*/ DependencyTreeComponentHashException(int hash, string message, System.Exception inner);
                }

                interface IInitializablePackage
                {
                    System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                }

                interface IServiceComponent
                {
                }

                class MissingComponent : Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ System.Type <IntendedType>k__BackingField;

                    /*0x1675200*/ MissingComponent(System.Type intendedType);
                    /*0x16751f8*/ System.Type get_IntendedType();
                }

                class PackageInitializationInfo
                {
                    /*0x10*/ System.Type PackageType;
                    /*0x18*/ double InitializationTimeInSeconds;

                    /*0x1672398*/ PackageInitializationInfo();
                }

                interface IPackageRegistry
                {
                    Unity.Services.Core.Internal.DependencyTree get_Tree();
                    void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterDependency<TComponent>(int packageTypeHash);
                    void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class LockedPackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    static string k_ErrorMessage = "Package registration has been locked. Make sure to register service packages in[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)].";
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField;

                    /*0x1671b50*/ LockedPackageRegistry(Unity.Services.Core.Internal.IPackageRegistry registryToLock);
                    /*0x1675228*/ Unity.Services.Core.Internal.IPackageRegistry get_Registry();
                    /*0x1675230*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x16752d0*/ void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterDependency<TComponent>(int packageTypeHash);
                    void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class PackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree <Tree>k__BackingField;

                    /*0x1671a68*/ PackageRegistry(Unity.Services.Core.Internal.DependencyTree tree);
                    /*0x167537c*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x1675384*/ void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterDependency<TComponent>(int packageTypeHash);
                    void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    void RegisterProvision<TComponent>(int packageTypeHash);
                    /*0x167538c*/ void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash);
                }

                class CoreDiagnostics
                {
                    static string CorePackageName = "com.unity.services.core";
                    static string CircularDependencyDiagnosticName = "circular_dependency";
                    static string CorePackageInitDiagnosticName = "core_package_init";
                    static string OperateServicesInitDiagnosticName = "operate_services_init";
                    static string ProjectConfigTagName = "project_config";
                    static /*0x0*/ Unity.Services.Core.Internal.CoreDiagnostics <Instance>k__BackingField;
                    /*0x10*/ System.Collections.Generic.IDictionary<string, string> <CoreTags>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField;
                    /*0x20*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics <Diagnostics>k__BackingField;

                    static /*0x167549c*/ Unity.Services.Core.Internal.CoreDiagnostics get_Instance();
                    static /*0x16754e4*/ void set_Instance(Unity.Services.Core.Internal.CoreDiagnostics value);
                    static /*0x1675948*/ void OnSendFailed(System.Threading.Tasks.Task failedSendTask);
                    /*0x1675a58*/ CoreDiagnostics();
                    /*0x1675530*/ System.Collections.Generic.IDictionary<string, string> get_CoreTags();
                    /*0x1675538*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider get_DiagnosticsComponentProvider();
                    /*0x1675540*/ void set_DiagnosticsComponentProvider(Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider value);
                    /*0x1675548*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics get_Diagnostics();
                    /*0x1675550*/ void set_Diagnostics(Unity.Services.Core.Telemetry.Internal.IDiagnostics value);
                    /*0x1675558*/ void SetProjectConfiguration(string serializedProjectConfig);
                    /*0x1675620*/ void SendCircularDependencyDiagnostics(System.Exception exception);
                    /*0x16757c0*/ void SendCorePackageInitDiagnostics(System.Exception exception);
                    /*0x1675884*/ void SendOperateServicesInitDiagnostics(System.Exception exception);
                    /*0x16756e4*/ System.Threading.Tasks.Task SendCoreDiagnosticsAsync(string diagnosticName, System.Exception exception);
                    /*0x1675964*/ System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnostics> GetOrCreateDiagnosticsAsync();

                    struct <SendCoreDiagnosticsAsync>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreDiagnostics <>4__this;
                        /*0x38*/ string diagnosticName;
                        /*0x40*/ System.Exception exception;
                        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Telemetry.Internal.IDiagnostics> <>u__1;

                        /*0x1675ad4*/ void MoveNext();
                        /*0x1675d54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetOrCreateDiagnosticsAsync>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Telemetry.Internal.IDiagnostics> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreDiagnostics <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> <>u__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__2;

                        /*0x1675d60*/ void MoveNext();
                        /*0x16761d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class CoreMetrics
                {
                    static string PackageInitTimeMetricName = "package_init_time";
                    static string AllPackagesInitSuccessMetricName = "all_packages_init_success";
                    static string AllPackagesInitTimeMetricName = "all_packages_init_time";
                    static string PackageInitializerNamesKeyFormat = "{0}.initializer-assembly-qualified-names";
                    static char PackageInitializerNamesSeparator = 59;
                    static string AllPackageNamesKey = "com.unity.services.core.all-package-names";
                    static char AllPackageNamesSeparator = 59;
                    static /*0x0*/ Unity.Services.Core.Internal.CoreMetrics <Instance>k__BackingField;
                    /*0x10*/ Unity.Services.Core.Telemetry.Internal.IMetrics <Metrics>k__BackingField;
                    /*0x18*/ System.Collections.Generic.IDictionary<System.Type, Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField;

                    static /*0x167622c*/ Unity.Services.Core.Internal.CoreMetrics get_Instance();
                    static /*0x1676274*/ void set_Instance(Unity.Services.Core.Internal.CoreMetrics value);
                    /*0x1676b94*/ CoreMetrics();
                    /*0x16762c0*/ Unity.Services.Core.Telemetry.Internal.IMetrics get_Metrics();
                    /*0x16762c8*/ void set_Metrics(Unity.Services.Core.Telemetry.Internal.IMetrics value);
                    /*0x16762d0*/ System.Collections.Generic.IDictionary<System.Type, Unity.Services.Core.Telemetry.Internal.IMetrics> get_AllPackageMetrics();
                    /*0x16762d8*/ void SendAllPackagesInitSuccessMetric();
                    /*0x16763a8*/ void SendAllPackagesInitTimeMetric(double initTimeSeconds);
                    /*0x1676488*/ void SendInitTimeMetricForPackage(System.Type packageType, double initTimeSeconds);
                    /*0x16765ec*/ void Initialize(Unity.Services.Core.Configuration.Internal.IProjectConfiguration configuration, Unity.Services.Core.Telemetry.Internal.IMetricsFactory factory, System.Type corePackageType);
                    /*0x1676750*/ void FindAndCacheAllPackageMetrics(Unity.Services.Core.Configuration.Internal.IProjectConfiguration configuration, Unity.Services.Core.Telemetry.Internal.IMetricsFactory factory);
                }

                class UnityServicesInitializer
                {
                    static /*0x1676c10*/ void CreateStaticInstance();
                    static /*0x1676f00*/ void EnableServicesInitializationAsync();

                    struct <EnableServicesInitializationAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x1676f88*/ void MoveNext();
                        /*0x1677270*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class UnityServicesInternal : Unity.Services.Core.IUnityServices
                {
                    /*0x10*/ Unity.Services.Core.ServicesInitializationState <State>k__BackingField;
                    /*0x18*/ Unity.Services.Core.InitializationOptions <Options>k__BackingField;
                    /*0x20*/ bool CanInitialize;
                    /*0x28*/ System.Threading.Tasks.TaskCompletionSource<object> m_Initialization;
                    /*0x30*/ Unity.Services.Core.Internal.CoreRegistry <Registry>k__BackingField;
                    /*0x38*/ Unity.Services.Core.Internal.CoreMetrics <Metrics>k__BackingField;
                    /*0x40*/ Unity.Services.Core.Internal.CoreDiagnostics <Diagnostics>k__BackingField;

                    /*0x1676ec4*/ UnityServicesInternal(Unity.Services.Core.Internal.CoreRegistry registry, Unity.Services.Core.Internal.CoreMetrics metrics, Unity.Services.Core.Internal.CoreDiagnostics diagnostics);
                    /*0x167727c*/ Unity.Services.Core.ServicesInitializationState get_State();
                    /*0x1677284*/ void set_State(Unity.Services.Core.ServicesInitializationState value);
                    /*0x167728c*/ Unity.Services.Core.InitializationOptions get_Options();
                    /*0x1677294*/ void set_Options(Unity.Services.Core.InitializationOptions value);
                    /*0x167729c*/ Unity.Services.Core.Internal.CoreRegistry get_Registry();
                    /*0x16772a4*/ Unity.Services.Core.Internal.CoreMetrics get_Metrics();
                    /*0x16772ac*/ Unity.Services.Core.Internal.CoreDiagnostics get_Diagnostics();
                    /*0x16772b4*/ System.Threading.Tasks.Task InitializeAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x167738c*/ bool HasRequestedInitialization();
                    /*0x167739c*/ System.Threading.Tasks.Task InitializeServicesAsync();
                    /*0x1677468*/ void SendInitializationMetrics(System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packageInitInfos);
                    /*0x16771a8*/ System.Threading.Tasks.Task EnableInitializationAsync();
                    /*0x16775c4*/ bool <InitializeAsync>g__HasInitializationFailed|20_0();

                    struct <InitializeAsync>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ Unity.Services.Core.InitializationOptions options;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<object> <>u__1;
                        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                        /*0x1677644*/ void MoveNext();
                        /*0x1677948*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;
                        /*0x18*/ System.Collections.Generic.List<int> sortedPackageTypeHashes;
                        /*0x20*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x28*/ System.Diagnostics.Stopwatch initStopwatch;

                        /*0x1677954*/ <>c__DisplayClass22_0();
                        /*0x167795c*/ void <InitializeServicesAsync>g__SortPackages|0();
                        /*0x1677984*/ System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <InitializeServicesAsync>g__InitializePackagesAsync|1();
                        /*0x1677a74*/ void <InitializeServicesAsync>g__FailServicesInitialization|2(System.Exception reason);
                        /*0x1677b64*/ void <InitializeServicesAsync>g__SucceedServicesInitialization|3();

                        struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>4__this;
                            /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1;

                            /*0x1677ccc*/ void MoveNext();
                            /*0x1677f04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <InitializeServicesAsync>d__22 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>8__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1;

                        /*0x1677f5c*/ void MoveNext();
                        /*0x1678484*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <EnableInitializationAsync>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x1678490*/ void MoveNext();
                        /*0x1678630*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DictionaryExtensions
                {
                    static TDictionary MergeNoOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
                    static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
                    static bool ValueEquals<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y);
                    static bool ValueEquals<TKey, TValue, TComparer>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y, TComparer valueComparer);
                }

                class UnityWebRequestUtils
                {
                    static string JsonContentType = "application/json";

                    static /*0x167863c*/ bool HasSucceeded(UnityEngine.Networking.UnityWebRequest self);
                    static /*0x1678660*/ System.Threading.Tasks.Task<string> GetTextAsync(string uri);

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Threading.Tasks.TaskCompletionSource<string> completionSource;

                        /*0x1678794*/ <>c__DisplayClass2_0();
                        /*0x167879c*/ void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(UnityEngine.AsyncOperation rawOperation);
                    }
                }
            }
        }
    }
}
