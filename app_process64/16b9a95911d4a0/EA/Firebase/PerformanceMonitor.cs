class <Module>
{
}

namespace EA
{
    namespace Firebase
    {
        namespace PerformanceMonitor
        {
            class AndroidHttpMetric : EA.Firebase.PerformanceMonitor.IHttpMetric, EA.Firebase.PerformanceMonitor.ITrace, System.IDisposable
            {
                /*0x10*/ UnityEngine.AndroidJavaObject _httpMetricInstance;
                /*0x18*/ EA.Firebase.PerformanceMonitor.TraceState <State>k__BackingField;

                /*0x2bb9a7c*/ AndroidHttpMetric(UnityEngine.AndroidJavaObject httpMetric, bool hasStarted);
                /*0x2bb9a6c*/ EA.Firebase.PerformanceMonitor.TraceState get_State();
                /*0x2bb9a74*/ void set_State(EA.Firebase.PerformanceMonitor.TraceState value);
                /*0x2bb9ab8*/ void Start();
                /*0x2bb9b98*/ void Stop();
                /*0x2bb9c7c*/ void SetAttribute(string attribute, string value);
                /*0x2bb9da4*/ void SetHttpResponseCode(int code);
                /*0x2bb9e94*/ void SetRequestPayloadSize(long bytes);
                /*0x2bb9f84*/ void SetResponseContentType(string contentType);
                /*0x2bba054*/ void SetResponsePayloadSize(long bytes);
                /*0x2bba144*/ void Dispose();
            }

            class AndroidPerfMonitor
            {
                static /*0x0*/ UnityEngine.AndroidJavaClass androidFirebasePerfMonitorClass;

                static /*0x2bba788*/ AndroidPerfMonitor();
                static /*0x2bba184*/ void set_IsInstrumentationEnabled(bool value);
                static /*0x2bba2a0*/ EA.Firebase.PerformanceMonitor.IPerformanceTrace CreateAndStartTrace(string traceName);
                static /*0x2bba54c*/ EA.Firebase.PerformanceMonitor.IHttpMetric CreateHttpMetric(string url, EA.Firebase.PerformanceMonitor.HttpMethod httpMethod);
            }

            class AndroidPerformanceTrace : EA.Firebase.PerformanceMonitor.IPerformanceTrace, EA.Firebase.PerformanceMonitor.ITrace, System.IDisposable
            {
                /*0x10*/ UnityEngine.AndroidJavaObject _traceInstance;
                /*0x18*/ EA.Firebase.PerformanceMonitor.TraceState <State>k__BackingField;

                /*0x2bba510*/ AndroidPerformanceTrace(UnityEngine.AndroidJavaObject trace, bool hasStarted);
                /*0x2bba824*/ EA.Firebase.PerformanceMonitor.TraceState get_State();
                /*0x2bba82c*/ void set_State(EA.Firebase.PerformanceMonitor.TraceState value);
                /*0x2bba834*/ void Start();
                /*0x2bba914*/ void Stop();
                /*0x2bba9f8*/ void SetAttribute(string attribute, string value);
                /*0x2bbab20*/ void SetMetric(string metric, long value);
                /*0x2bbac50*/ void DisposeNoStop();
                /*0x2bbac64*/ void Dispose();
            }

            interface IPerformanceTrace : EA.Firebase.PerformanceMonitor.ITrace, System.IDisposable
            {
                void SetMetric(string metric, long value);
                /*0x1f309e4*/ void DisposeNoStop();
            }

            interface ITrace : System.IDisposable
            {
                /*0x1f309e4*/ void Start();
                /*0x1f309e4*/ void Stop();
                /*0x1f30ff0*/ void SetAttribute(string attribute, string value);
            }

            enum HttpMethod
            {
                GET = 0,
                PUT = 1,
                POST = 2,
                DELETE = 3,
                HEAD = 4,
                PATCH = 5,
                OPTIONS = 6,
                TRACE = 7,
                CONNECT = 8,
            }

            interface IHttpMetric : EA.Firebase.PerformanceMonitor.ITrace, System.IDisposable
            {
                /*0x1f30b78*/ void SetHttpResponseCode(int code);
                /*0x1f30d60*/ void SetRequestPayloadSize(long bytes);
                /*0x1f30ebc*/ void SetResponseContentType(string contentType);
                /*0x1f30d60*/ void SetResponsePayloadSize(long bytes);
            }

            class NullHttpMetric : EA.Firebase.PerformanceMonitor.IHttpMetric, EA.Firebase.PerformanceMonitor.ITrace, System.IDisposable
            {
                /*0x10*/ EA.Firebase.PerformanceMonitor.TraceState <State>k__BackingField;

                /*0x2bba754*/ NullHttpMetric(bool hasStarted);
                /*0x2bbad50*/ EA.Firebase.PerformanceMonitor.TraceState get_State();
                /*0x2bbad58*/ void set_State(EA.Firebase.PerformanceMonitor.TraceState value);
                /*0x2bbad60*/ void Start();
                /*0x2bbad78*/ void Stop();
                /*0x2bbad90*/ void SetAttribute(string attribute, string value);
                /*0x2bbad94*/ void SetHttpResponseCode(int code);
                /*0x2bbad98*/ void SetRequestPayloadSize(long bytes);
                /*0x2bbad9c*/ void SetResponseContentType(string contentType);
                /*0x2bbada0*/ void SetResponsePayloadSize(long bytes);
                /*0x2bbada4*/ void Dispose();
            }

            class NullTrace : EA.Firebase.PerformanceMonitor.IPerformanceTrace, EA.Firebase.PerformanceMonitor.ITrace, System.IDisposable
            {
                /*0x10*/ EA.Firebase.PerformanceMonitor.TraceState <State>k__BackingField;

                /*0x2bba4dc*/ NullTrace(bool hasStarted);
                /*0x2bbada8*/ EA.Firebase.PerformanceMonitor.TraceState get_State();
                /*0x2bbadb0*/ void set_State(EA.Firebase.PerformanceMonitor.TraceState value);
                /*0x2bbadb8*/ void Start();
                /*0x2bbadd0*/ void Stop();
                /*0x2bbade8*/ void SetAttribute(string attribute, string value);
                /*0x2bbadec*/ void SetMetric(string metric, long value);
                /*0x2bbadf0*/ void DisposeNoStop();
                /*0x2bbadf4*/ void Dispose();
            }

            class PerfMonitor
            {
                static /*0x2bbadf8*/ void set_IsInstrumentationEnabled(bool value);
                static /*0x2bbae4c*/ EA.Firebase.PerformanceMonitor.IPerformanceTrace CreateAndStartTrace(string traceName);
                static /*0x2bbaea0*/ EA.Firebase.PerformanceMonitor.IHttpMetric CreateHttpMetric(string url, EA.Firebase.PerformanceMonitor.HttpMethod methodType);
            }

            enum TraceState
            {
                None = 0,
                Started = 1,
                Stopped = 2,
            }

            class PerfUtils
            {
                static /*0x2bba440*/ bool CheckBadNameFormat(string name);
                static /*0x2bbaf04*/ bool IsWhitespace(string str);
            }
        }
    }
}
