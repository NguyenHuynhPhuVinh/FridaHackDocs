class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Telemetry
            {
                namespace Internal
                {
                    class DisabledCachePersister<TPayload> : Unity.Services.Core.Telemetry.Internal.ICachePersister<TPayload>
                    {
                        DisabledCachePersister();
                        bool get_CanPersist();
                        void Persist(Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> cache);
                        bool TryFetch(ref Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> persistedCache);
                        void Delete();
                    }

                    class FileCachePersister
                    {
                        static /*0x2adc9f8*/ bool IsAvailableFor(UnityEngine.RuntimePlatform platform);
                        static /*0x2adca1c*/ string GetPersistentDataPathFor(UnityEngine.RuntimePlatform platform);
                        /*0x2adca84*/ FileCachePersister();
                    }

                    class FileCachePersister<TPayload> : Unity.Services.Core.Telemetry.Internal.FileCachePersister, Unity.Services.Core.Telemetry.Internal.ICachePersister<TPayload>
                    {
                        /*0x0*/ string <FilePath>k__BackingField;
                        /*0x0*/ bool <CanPersist>k__BackingField;

                        FileCachePersister(string fileName);
                        string get_FilePath();
                        bool get_CanPersist();
                        void Persist(Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> cache);
                        bool TryFetch(ref Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> persistedCache);
                        void Delete();
                    }

                    interface ICachePersister<TPayload>
                    {
                        bool get_CanPersist();
                        void Persist(Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> cache);
                        bool TryFetch(ref Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> persistedCache);
                        void Delete();
                    }

                    class Diagnostics : Unity.Services.Core.Telemetry.Internal.IDiagnostics
                    {
                        /*0x10*/ Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler <Handler>k__BackingField;
                        /*0x18*/ System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField;

                        /*0x2adb4b0*/ Diagnostics(Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler handler, System.Collections.Generic.IDictionary<string, string> packageTags);
                        /*0x2adb4a0*/ Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler get_Handler();
                        /*0x2adb4a8*/ System.Collections.Generic.IDictionary<string, string> get_PackageTags();
                        /*0x2adb4e8*/ void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class DiagnosticsFactory : Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ Unity.Services.Core.Configuration.Internal.IProjectConfiguration m_ProjectConfig;
                        /*0x18*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField;
                        /*0x20*/ Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler <Handler>k__BackingField;

                        /*0x2adb724*/ DiagnosticsFactory(Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler handler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfig);
                        /*0x2adb71c*/ Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler get_Handler();
                        /*0x2adb808*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    class DisabledDiagnostics : Unity.Services.Core.Telemetry.Internal.IDiagnostics
                    {
                        /*0x2adc774*/ DisabledDiagnostics();
                        /*0x2adc770*/ void Unity.Services.Core.Telemetry.Internal.IDiagnostics.SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class DisabledDiagnosticsFactory : Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory.CommonTags>k__BackingField;

                        /*0x2adc7d4*/ DisabledDiagnosticsFactory();
                        /*0x2adc77c*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory.Create(string packageName);
                    }

                    class DiagnosticsHandler : Unity.Services.Core.Telemetry.Internal.TelemetryHandler<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload, Unity.Services.Core.Telemetry.Internal.Diagnostic>
                    {
                        static /*0x2adbd54*/ void OnSendAsyncCompleted(System.Threading.Tasks.Task sendOperation, object state);
                        /*0x2adbaa4*/ DiagnosticsHandler(Unity.Services.Core.Telemetry.Internal.TelemetryConfig config, Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload> cache, Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Telemetry.Internal.ICachePersister<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload> cachePersister, Unity.Services.Core.Telemetry.Internal.TelemetrySender sender);
                        /*0x2adbb30*/ void SendPersistedCache(Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload> persistedCache);
                        /*0x2adbeb8*/ void FetchSpecificCommonTags(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        /*0x2adc228*/ void SendCachedPayload();

                        class SendState
                        {
                            /*0x10*/ Unity.Services.Core.Telemetry.Internal.DiagnosticsHandler Self;
                            /*0x18*/ Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload> Payload;

                            /*0x2adbd4c*/ SendState();
                        }
                    }

                    class MetricsHandler : Unity.Services.Core.Telemetry.Internal.TelemetryHandler<Unity.Services.Core.Telemetry.Internal.MetricsPayload, Unity.Services.Core.Telemetry.Internal.Metric>
                    {
                        /*0x2adcf68*/ MetricsHandler(Unity.Services.Core.Telemetry.Internal.TelemetryConfig config, Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.MetricsPayload> cache, Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Telemetry.Internal.ICachePersister<Unity.Services.Core.Telemetry.Internal.MetricsPayload> cachePersister, Unity.Services.Core.Telemetry.Internal.TelemetrySender sender);
                        /*0x2add03c*/ void SendPersistedCache(Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.MetricsPayload> persistedCache);
                        /*0x2add244*/ void FetchSpecificCommonTags(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        /*0x2add2ac*/ void SendCachedPayload();
                        /*0x2add164*/ bool <SendPersistedCache>g__AreMetricsOutdated|1_0(ref Unity.Services.Core.Telemetry.Internal.MetricsHandler.<> );

                        struct <>c__DisplayClass1_0
                        {
                            /*0x10*/ Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.MetricsPayload> persistedCache;
                            /*0x18*/ Unity.Services.Core.Telemetry.Internal.MetricsHandler <>4__this;
                        }
                    }

                    class TelemetryHandler
                    {
                        static /*0x2add658*/ string FormatOperatingSystemInfo(string rawOsInfo);
                        /*0x2add6dc*/ TelemetryHandler();
                    }

                    class TelemetryHandler<TPayload, TEvent> : Unity.Services.Core.Telemetry.Internal.TelemetryHandler
                    {
                        /*0x0*/ Unity.Services.Core.Scheduler.Internal.IActionScheduler m_Scheduler;
                        /*0x0*/ Unity.Services.Core.Telemetry.Internal.ICachePersister<TPayload> m_CachePersister;
                        /*0x0*/ Unity.Services.Core.Telemetry.Internal.TelemetrySender m_Sender;
                        /*0x0*/ long SendingLoopScheduleId;
                        /*0x0*/ long PersistenceLoopScheduleId;
                        /*0x0*/ Unity.Services.Core.Telemetry.Internal.TelemetryConfig <Config>k__BackingField;
                        /*0x0*/ Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> <Cache>k__BackingField;

                        TelemetryHandler(Unity.Services.Core.Telemetry.Internal.TelemetryConfig config, Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> cache, Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Telemetry.Internal.ICachePersister<TPayload> cachePersister, Unity.Services.Core.Telemetry.Internal.TelemetrySender sender);
                        Unity.Services.Core.Telemetry.Internal.TelemetryConfig get_Config();
                        Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> get_Cache();
                        void Initialize(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        void HandlePersistedCache();
                        void SendPersistedCache(Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> persistedCache);
                        void FetchAllCommonTags(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        void FetchSpecificCommonTags(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        void FetchTelemetryCommonTags();
                        void ScheduleSendingLoop();
                        void SendCachedPayload();
                        void SchedulePersistenceLoop();
                        void PersistCache();
                        void Register(TEvent telemetryEvent);
                        void <ScheduleSendingLoop>g__SendingLoop|18_0();
                        void <SchedulePersistenceLoop>g__PersistenceLoop|20_0();
                        bool <Register>g__IsCacheFull|22_0();
                    }

                    class DisabledMetrics : Unity.Services.Core.Telemetry.Internal.IMetrics
                    {
                        /*0x2adc858*/ DisabledMetrics();
                        /*0x2adc84c*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x2adc850*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x2adc854*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class DisabledMetricsFactory : Unity.Services.Core.Telemetry.Internal.IMetricsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <Unity.Services.Core.Telemetry.Internal.IMetricsFactory.CommonTags>k__BackingField;

                        /*0x2adc8b8*/ DisabledMetricsFactory();
                        /*0x2adc860*/ Unity.Services.Core.Telemetry.Internal.IMetrics Unity.Services.Core.Telemetry.Internal.IMetricsFactory.Create(string packageName);
                    }

                    class Metrics : Unity.Services.Core.Telemetry.Internal.IMetrics
                    {
                        /*0x10*/ Unity.Services.Core.Telemetry.Internal.MetricsHandler <Handler>k__BackingField;
                        /*0x18*/ System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField;

                        /*0x2adca9c*/ Metrics(Unity.Services.Core.Telemetry.Internal.MetricsHandler handler, System.Collections.Generic.IDictionary<string, string> packageTags);
                        /*0x2adca8c*/ Unity.Services.Core.Telemetry.Internal.MetricsHandler get_Handler();
                        /*0x2adca94*/ System.Collections.Generic.IDictionary<string, string> get_PackageTags();
                        /*0x2adcad4*/ Unity.Services.Core.Telemetry.Internal.Metric CreateMetric(string name, double value, Unity.Services.Core.Telemetry.Internal.MetricType type, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x2adcb84*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x2adcc38*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x2adccec*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class MetricsFactory : Unity.Services.Core.Telemetry.Internal.IMetricsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ Unity.Services.Core.Configuration.Internal.IProjectConfiguration m_ProjectConfig;
                        /*0x18*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField;
                        /*0x20*/ Unity.Services.Core.Telemetry.Internal.MetricsHandler <Handler>k__BackingField;

                        /*0x2adcda8*/ MetricsFactory(Unity.Services.Core.Telemetry.Internal.MetricsHandler handler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfig);
                        /*0x2adcda0*/ Unity.Services.Core.Telemetry.Internal.MetricsHandler get_Handler();
                        /*0x2adce8c*/ Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
                    }

                    class CachedPayload<TPayload>
                    {
                        /*0x0*/ long TimeOfOccurenceTicks;
                        /*0x0*/ TPayload Payload;

                        CachedPayload();
                    }

                    struct Diagnostic : Unity.Services.Core.Telemetry.Internal.ITelemetryEvent
                    {
                        /*0x10*/ System.Collections.Generic.IDictionary<string, string> Content;
                    }

                    struct DiagnosticsPayload : Unity.Services.Core.Telemetry.Internal.ITelemetryPayload
                    {
                        /*0x10*/ System.Collections.Generic.List<Unity.Services.Core.Telemetry.Internal.Diagnostic> Diagnostics;
                        /*0x18*/ System.Collections.Generic.Dictionary<string, string> CommonTags;
                        /*0x20*/ System.Collections.Generic.Dictionary<string, string> DiagnosticsCommonTags;

                        /*0xb228a4*/ System.Collections.Generic.Dictionary<string, string> Unity.Services.Core.Telemetry.Internal.ITelemetryPayload.get_CommonTags();
                        /*0xb228ac*/ int Unity.Services.Core.Telemetry.Internal.ITelemetryPayload.get_Count();
                        /*0xb228fc*/ void Unity.Services.Core.Telemetry.Internal.ITelemetryPayload.Add(Unity.Services.Core.Telemetry.Internal.ITelemetryEvent telemetryEvent);
                    }

                    interface ITelemetryEvent
                    {
                    }

                    interface ITelemetryPayload
                    {
                        System.Collections.Generic.Dictionary<string, string> get_CommonTags();
                        int get_Count();
                        void Add(Unity.Services.Core.Telemetry.Internal.ITelemetryEvent telemetryEvent);
                    }

                    struct Metric : Unity.Services.Core.Telemetry.Internal.ITelemetryEvent
                    {
                        /*0x10*/ string Name;
                        /*0x18*/ double Value;
                        /*0x20*/ Unity.Services.Core.Telemetry.Internal.MetricType Type;
                        /*0x28*/ System.Collections.Generic.IDictionary<string, string> Tags;
                    }

                    enum MetricType
                    {
                        Gauge = 0,
                        Sum = 1,
                        Histogram = 2,
                    }

                    struct MetricsPayload : Unity.Services.Core.Telemetry.Internal.ITelemetryPayload
                    {
                        /*0x10*/ System.Collections.Generic.List<Unity.Services.Core.Telemetry.Internal.Metric> Metrics;
                        /*0x18*/ System.Collections.Generic.Dictionary<string, string> CommonTags;
                        /*0x20*/ System.Collections.Generic.Dictionary<string, string> MetricsCommonTags;

                        /*0xb2297c*/ System.Collections.Generic.Dictionary<string, string> Unity.Services.Core.Telemetry.Internal.ITelemetryPayload.get_CommonTags();
                        /*0xb22984*/ int Unity.Services.Core.Telemetry.Internal.ITelemetryPayload.get_Count();
                        /*0xb229d4*/ void Unity.Services.Core.Telemetry.Internal.ITelemetryPayload.Add(Unity.Services.Core.Telemetry.Internal.ITelemetryEvent telemetryEvent);
                    }

                    class ExponentialBackOffRetryPolicy
                    {
                        /*0x10*/ int m_MaxTryCount;
                        /*0x14*/ float m_BaseDelaySeconds;

                        static /*0x2adc984*/ bool IsTransientError(Unity.Services.Core.Telemetry.Internal.WebRequest webRequest);
                        static /*0x2adc9bc*/ bool <IsTransientError>g__IsServerErrorCode|9_0(long responseCode);
                        /*0x2adc9e4*/ ExponentialBackOffRetryPolicy();
                        /*0x2adc930*/ int get_MaxTryCount();
                        /*0x2adc938*/ float get_BaseDelaySeconds();
                        /*0x2adc940*/ bool CanRetry(Unity.Services.Core.Telemetry.Internal.WebRequest webRequest, int sendCount);
                        /*0x2adc9cc*/ float GetDelayBeforeSendingSeconds(int sendCount);
                    }

                    interface IUnityWebRequestSender
                    {
                        void SendRequest(UnityEngine.Networking.UnityWebRequest request, System.Action<Unity.Services.Core.Telemetry.Internal.WebRequest> callback);
                    }

                    class TelemetrySender
                    {
                        /*0x10*/ string <TargetUrl>k__BackingField;
                        /*0x18*/ Unity.Services.Core.Telemetry.Internal.ExponentialBackOffRetryPolicy m_RetryPolicy;
                        /*0x20*/ Unity.Services.Core.Scheduler.Internal.IActionScheduler m_Scheduler;
                        /*0x28*/ Unity.Services.Core.Telemetry.Internal.IUnityWebRequestSender m_RequestSender;

                        static byte[] SerializePayload<TPayload>(TPayload payload);
                        /*0x2add6ec*/ TelemetrySender(string targetUrl, string servicePath, Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Telemetry.Internal.ExponentialBackOffRetryPolicy retryPolicy, Unity.Services.Core.Telemetry.Internal.IUnityWebRequestSender requestSender);
                        /*0x2add6e4*/ string get_TargetUrl();
                        System.Threading.Tasks.Task SendAsync<TPayload>(TPayload payload);
                        /*0x2add784*/ UnityEngine.Networking.UnityWebRequest CreateRequest(byte[] serializedPayload);

                        class <>c__DisplayClass7_0<TPayload>
                        {
                            /*0x0*/ Unity.Services.Core.Telemetry.Internal.TelemetrySender <>4__this;
                            /*0x0*/ byte[] serializedPayload;
                            /*0x0*/ int sendCount;
                            /*0x0*/ System.Threading.Tasks.TaskCompletionSource<object> completionSource;

                            <>c__DisplayClass7_0();
                            void <SendAsync>g__SendWebRequest|0();
                            void <SendAsync>g__OnRequestCompleted|1(Unity.Services.Core.Telemetry.Internal.WebRequest webRequest);
                        }
                    }

                    class UnityWebRequestSender : Unity.Services.Core.Telemetry.Internal.IUnityWebRequestSender
                    {
                        static /*0x2ade4a8*/ Unity.Services.Core.Telemetry.Internal.WebRequest Simplify(UnityEngine.Networking.UnityWebRequest webRequest);
                        /*0x2ade0a0*/ UnityWebRequestSender();
                        /*0x2ade3b0*/ void SendRequest(UnityEngine.Networking.UnityWebRequest request, System.Action<Unity.Services.Core.Telemetry.Internal.WebRequest> callback);

                        class <>c__DisplayClass0_0
                        {
                            /*0x10*/ System.Action<Unity.Services.Core.Telemetry.Internal.WebRequest> callback;

                            /*0x2ade4a0*/ <>c__DisplayClass0_0();
                            /*0x2ade574*/ void <SendRequest>g__OnSendingRequestCompleted|0(UnityEngine.AsyncOperation operation);
                        }
                    }

                    enum WebRequestResult
                    {
                        Success = 0,
                        ConnectionError = 1,
                        ProtocolError = 2,
                        UnknownError = 3,
                    }

                    struct WebRequest
                    {
                        /*0x10*/ Unity.Services.Core.Telemetry.Internal.WebRequestResult Result;
                        /*0x18*/ string ErrorMessage;
                        /*0x20*/ string ErrorBody;
                        /*0x28*/ long ResponseCode;

                        /*0xb22aa0*/ bool get_IsSuccess();
                    }

                    class TelemetryConfig
                    {
                        /*0x10*/ string TargetUrl;
                        /*0x18*/ string ServicePath;
                        /*0x20*/ double PayloadExpirationSeconds;
                        /*0x28*/ double PayloadSendingMaxIntervalSeconds;
                        /*0x30*/ double SafetyPersistenceIntervalSeconds;
                        /*0x38*/ int MaxMetricCountPerPayload;

                        /*0x2add650*/ TelemetryConfig();
                    }

                    class CacheExtensions
                    {
                        static bool IsEmpty<TPayload>(Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> self);
                        static /*0x2adb400*/ void AddRangeFrom(Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload> self, Unity.Services.Core.Telemetry.Internal.CachedPayload<Unity.Services.Core.Telemetry.Internal.DiagnosticsPayload> payload);
                        static void Add<TPayload>(Unity.Services.Core.Telemetry.Internal.CachedPayload<TPayload> self, Unity.Services.Core.Telemetry.Internal.ITelemetryEvent telemetryEvent);
                    }

                    class FactoryUtils
                    {
                        static /*0x2adb8e4*/ System.Collections.Generic.IDictionary<string, string> CreatePackageTags(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfig, string packageName);
                    }

                    class TelemetryUtils
                    {
                        static /*0x2add8d8*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory CreateMetricsFactory(Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration, Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        static /*0x2ade0a8*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory CreateDiagnosticsFactory(Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration, Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                        static /*0x2addbe0*/ bool IsTelemetryDisabled(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                        static Unity.Services.Core.Telemetry.Internal.ICachePersister<TPayload> CreateCachePersister<TPayload>(string fileName, UnityEngine.RuntimePlatform platform);
                        static /*0x2addca8*/ Unity.Services.Core.Telemetry.Internal.TelemetryConfig CreateTelemetryConfig(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    }
                }
            }
        }
    }
}
