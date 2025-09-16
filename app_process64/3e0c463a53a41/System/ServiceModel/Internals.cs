class <Module>
{
}

namespace System
{
    namespace ServiceModel
    {
        namespace Internals
        {
            class LocalAppContextSwitches
            {
                static /*0x0*/ bool IncludeNullExceptionMessageInETWTrace;
            }
        }
    }

    namespace Diagnostics
    {
        enum EventLogEntryType
        {
            Error = 1,
            Warning = 2,
            Information = 4,
            SuccessAudit = 8,
            FailureAudit = 16,
        }
    }

    namespace Runtime
    {
        class CallbackException : System.Runtime.FatalException
        {
            /*0x7611b10*/ CallbackException();
            /*0x7611b20*/ CallbackException(string message, System.Exception innerException);
            /*0x7611b30*/ CallbackException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ExceptionTrace
        {
            /*0x10*/ string eventSourceName;
            /*0x18*/ System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace;

            /*0x7611b40*/ ExceptionTrace(string eventSourceName, System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace);
            /*0x7611b84*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string paramName, object actualValue, string message);
            /*0x7611c20*/ void TraceHandledException(System.Exception exception, System.Diagnostics.TraceEventType traceEventType);
            /*0x3907c14*/ TException TraceException<TException>(TException exception);
            /*0x3907c14*/ TException TraceException<TException>(TException exception, string eventSource);
            /*0x7612858*/ void BreakOnException(System.Exception exception);
        }

        class FatalException : System.SystemException
        {
            /*0x7611b18*/ FatalException();
            /*0x7611b28*/ FatalException(string message, System.Exception innerException);
            /*0x7611b38*/ FatalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class Fx
        {
            static /*0x0*/ System.Runtime.ExceptionTrace exceptionTrace;
            static /*0x8*/ System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace;

            static /*0x761285c*/ System.Runtime.ExceptionTrace get_Exception();
            static /*0x761291c*/ System.Runtime.Diagnostics.EtwDiagnosticTrace get_Trace();
            static /*0x7612990*/ System.Runtime.Diagnostics.EtwDiagnosticTrace InitializeTracing();
            static /*0x7613000*/ System.Exception AssertAndThrow(string description);
            static /*0x7613264*/ bool IsFatal(System.Exception exception);
            static /*0x7612f70*/ void UpdateLevel(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7613800*/ void UpdateLevel();

            class InternalException : System.SystemException
            {
                /*0x7613240*/ InternalException(string description);
                /*0x761385c*/ InternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class FatalInternalException : System.Runtime.Fx.InternalException
            {
                /*0x7613864*/ FatalInternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class <>c
            {
                static /*0x0*/ System.Runtime.Fx.<> <>9;
                static /*0x8*/ System.Action <>9__8_0;

                static /*0x761386c*/ <>c();
                /*0x76138d4*/ <>c();
                /*0x76138dc*/ void <InitializeTracing>b__8_0();
            }
        }

        class HashHelper
        {
            static /*0x76138ec*/ byte[] ComputeHash(byte[] buffer);
        }

        class PartialTrustHelpers
        {
            static /*0x7613e40*/ bool HasEtwPermissions();
        }

        enum TraceChannel
        {
            Admin = 16,
            Operational = 17,
            Analytic = 18,
            Debug = 19,
            Perf = 20,
            Application = 9,
        }

        enum TraceEventLevel
        {
            LogAlways = 0,
            Critical = 1,
            Error = 2,
            Warning = 3,
            Informational = 4,
            Verbose = 5,
        }

        enum TraceEventOpcode
        {
            Info = 0,
            Start = 1,
            Stop = 2,
            Reply = 6,
            Resume = 7,
            Suspend = 8,
            Send = 9,
            Receive = 240,
        }

        class TraceLevelHelper
        {
            static /*0x0*/ System.Diagnostics.TraceEventType[] EtwLevelToTraceEventType;

            static /*0x7614054*/ TraceLevelHelper();
            static /*0x7613e48*/ System.Diagnostics.TraceEventType GetTraceEventType(System.Runtime.TraceEventLevel level);
            static /*0x7613ec4*/ string LookupSeverity(System.Runtime.TraceEventLevel level, System.Runtime.TraceEventOpcode opcode);
        }

        struct TracePayload
        {
            /*0x10*/ string serializedException;
            /*0x18*/ string eventSource;
            /*0x20*/ string appDomainFriendlyName;
            /*0x28*/ string extendedData;
            /*0x30*/ string hostReference;

            /*0x76140f4*/ TracePayload(string serializedException, string eventSource, string appDomainFriendlyName, string extendedData, string hostReference);
            /*0x7614168*/ string get_SerializedException();
            /*0x7614170*/ string get_EventSource();
            /*0x7614178*/ string get_AppDomainFriendlyName();
            /*0x7614180*/ string get_ExtendedData();
        }

        class TraceCore
        {
            static /*0x0*/ System.Resources.ResourceManager resourceManager;
            static /*0x8*/ System.Globalization.CultureInfo resourceCulture;
            static /*0x10*/ System.Runtime.Diagnostics.EventDescriptor[] eventDescriptors;
            static /*0x18*/ object syncLock;
            static /*0x20*/ bool eventDescriptorsCreated;

            static /*0x7616a10*/ TraceCore();
            static /*0x7614188*/ System.Resources.ResourceManager get_ResourceManager();
            static /*0x76142cc*/ System.Globalization.CultureInfo get_Culture();
            static /*0x7614324*/ bool AppDomainUnloadIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x761445c*/ void AppDomainUnload(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string appdomainName, string processName, string processId);
            static /*0x76125e4*/ bool HandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x761266c*/ void HandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x7613064*/ void ShipAssertExceptionMessage(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0);
            static /*0x7614a24*/ bool ThrowingExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7614aac*/ void ThrowingException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception);
            static /*0x7614cac*/ bool UnhandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7614d34*/ void UnhandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x7614f20*/ bool TraceCodeEventLogCriticalIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7614fa8*/ void TraceCodeEventLogCritical(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x76151f0*/ bool TraceCodeEventLogErrorIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7615278*/ void TraceCodeEventLogError(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x76154c0*/ bool TraceCodeEventLogInfoIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7615548*/ void TraceCodeEventLogInfo(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x7615790*/ bool TraceCodeEventLogVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7615818*/ void TraceCodeEventLogVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x7615a60*/ bool TraceCodeEventLogWarningIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7615ae8*/ void TraceCodeEventLogWarning(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x76120fc*/ bool HandledExceptionWarningIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7612184*/ void HandledExceptionWarning(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x7613788*/ bool ActionItemScheduledIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7613730*/ bool ActionItemCallbackInvokedIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7611e88*/ bool HandledExceptionErrorIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7611f10*/ void HandledExceptionError(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x7612370*/ bool HandledExceptionVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x76123f8*/ void HandledExceptionVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x7615d30*/ void CreateEventDescriptors();
            static /*0x761610c*/ void EnsureEventDescriptors();
            static /*0x76143ac*/ bool IsEtwEventEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex);
            static /*0x7614690*/ bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4);
            static /*0x76148a4*/ bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3);
            static /*0x761496c*/ bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2);
            static /*0x76147cc*/ void WriteTraceSource(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, string description, System.Runtime.TracePayload payload);
        }

        class InternalSR
        {
            static /*0x7616a84*/ string EtwRegistrationFailed(object arg);
            static /*0x7613810*/ string ShipAssertExceptionMessage(object description);
        }

        namespace Interop
        {
            class SafeEventLogWriteHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x7616adc*/ System.Runtime.Interop.SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName);
                static /*0x7616c5c*/ bool DeregisterEventSource(nint hEventLog);
                /*0x7616ad0*/ SafeEventLogWriteHandle();
                /*0x7616ce4*/ bool ReleaseHandle();
            }

            class UnsafeNativeMethods
            {
                static /*0x7616cec*/ uint EventRegister(ref System.Guid providerId, System.Runtime.Interop.UnsafeNativeMethods.EtwEnableCallback enableCallback, void* callbackContext, ref long registrationHandle);
                static /*0x7616d94*/ uint EventUnregister(long registrationHandle);
                static /*0x7616e14*/ bool EventEnabled(long registrationHandle, ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor);
                static /*0x7616ea0*/ uint EventWrite(long registrationHandle, ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, uint userDataCount, System.Runtime.Interop.UnsafeNativeMethods.EventData* userData);
                static /*0x7616f40*/ uint EventActivityIdControl(int ControlCode, ref System.Guid ActivityId);
                static /*0x7616fc4*/ bool ReportEvent(System.Runtime.InteropServices.SafeHandle hEventLog, ushort type, ushort category, uint eventID, byte[] userSID, ushort numStrings, uint dataLen, System.Runtime.InteropServices.HandleRef strings, byte[] rawData);
                static /*0x7616b70*/ System.Runtime.Interop.SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName);

                struct EventData
                {
                    /*0x10*/ ulong DataPointer;
                    /*0x18*/ uint Size;
                    /*0x1c*/ int Reserved;
                }

                class EtwEnableCallback : System.MulticastDelegate
                {
                    /*0x7617100*/ EtwEnableCallback(object object, nint method);
                    /*0x76171b4*/ void Invoke(ref System.Guid sourceId, int isEnabled, byte level, long matchAnyKeywords, long matchAllKeywords, void* filterData, void* callbackContext);
                }
            }
        }

        namespace Diagnostics
        {
            class DiagnosticsEventProvider : System.IDisposable
            {
                [ThreadStatic] static System.Runtime.Diagnostics.DiagnosticsEventProvider.WriteEventErrorCode errorCode;
                /*0x10*/ System.Runtime.Interop.UnsafeNativeMethods.EtwEnableCallback etwCallback;
                /*0x18*/ long traceRegistrationHandle;
                /*0x20*/ byte currentTraceLevel;
                /*0x28*/ long anyKeywordMask;
                /*0x30*/ long allKeywordMask;
                /*0x38*/ bool isProviderEnabled;
                /*0x3c*/ System.Guid providerId;
                /*0x4c*/ int isDisposed;

                static /*0x7617574*/ void SetLastError(int error);
                static /*0x761774c*/ void SetActivityId(ref System.Guid id);
                /*0x76171cc*/ DiagnosticsEventProvider(System.Guid providerGuid);
                /*0x7617230*/ void EtwRegister();
                /*0x7617350*/ void Dispose();
                /*0x76173bc*/ void Dispose(bool disposing);
                /*0x761741c*/ void Finalize();
                /*0x76173fc*/ void Deregister();
                /*0x76174bc*/ void EtwEnableCallBack(ref System.Guid sourceId, int isEnabled, byte setLevel, long anyKeyword, long allKeyword, void* filterData, void* callbackContext);
                /*0x380cb08*/ void OnControllerCommand();
                /*0x76174dc*/ bool IsEnabled();
                /*0x76174e4*/ bool IsEnabled(byte level, long keywords);
                /*0x7617528*/ bool IsEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor);
                /*0x76175e0*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string data);
                /*0x7617758*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, int dataCount, nint data);

                enum WriteEventErrorCode
                {
                    NoError = 0,
                    NoFreeBuffers = 1,
                    EventTooBig = 2,
                }
            }

            class DiagnosticTraceBase
            {
                static /*0x0*/ string AppDomainFriendlyName;
                /*0x10*/ object thisLock;
                /*0x18*/ bool tracingEnabled;
                /*0x19*/ bool calledShutdown;
                /*0x1a*/ bool haveListeners;
                /*0x1c*/ System.Diagnostics.SourceLevels level;
                /*0x20*/ string TraceSourceName;
                /*0x28*/ System.Diagnostics.TraceSource traceSource;
                /*0x30*/ string eventSourceName;
                /*0x38*/ System.DateTime <LastFailure>k__BackingField;

                static /*0x7619698*/ DiagnosticTraceBase();
                static /*0x76178a8*/ void UnsafeRemoveDefaultTraceListener(System.Diagnostics.TraceSource traceSource);
                static /*0x7617b70*/ string get_ProcessName();
                static /*0x7617cf0*/ int get_ProcessId();
                static /*0x7617eb0*/ string XmlEncode(string text);
                static /*0x761832c*/ string CreateSourceString(object source);
                static /*0x7618408*/ string CreateDefaultSourceString(object source);
                static /*0x7618534*/ string StackTraceString(System.Exception exception);
                /*0x76177d0*/ DiagnosticTraceBase(string traceSourceName);
                /*0x7617898*/ System.DateTime get_LastFailure();
                /*0x76178a0*/ void set_LastFailure(System.DateTime value);
                /*0x7617908*/ System.Diagnostics.TraceSource get_TraceSource();
                /*0x7617910*/ void SetTraceSource(System.Diagnostics.TraceSource traceSource);
                /*0x76179b0*/ bool get_HaveListeners();
                /*0x76179b8*/ System.Diagnostics.SourceLevels FixLevel(System.Diagnostics.SourceLevels level);
                /*0x76179f8*/ void OnSetLevel(System.Diagnostics.SourceLevels level);
                /*0x76179fc*/ void SetLevel(System.Diagnostics.SourceLevels level);
                /*0x7617adc*/ System.Diagnostics.SourceLevels get_Level();
                /*0x7617b40*/ string get_EventSourceName();
                /*0x7617b48*/ void set_EventSourceName(string value);
                /*0x7617b50*/ bool get_TracingEnabled();
                /*0x7617e70*/ bool ShouldTrace(System.Runtime.TraceEventLevel level);
                /*0x7617e74*/ bool ShouldTrace(System.Diagnostics.TraceEventType type);
                /*0x7614760*/ bool ShouldTraceToTraceSource(System.Runtime.TraceEventLevel level);
                /*0x7618024*/ void AddDomainEventHandlersForCleanup();
                /*0x76181b8*/ void ExitOrUnloadEventHandler(object sender, System.EventArgs e);
                /*0x380d83c*/ void OnUnhandledException(System.Exception exception);
                /*0x761828c*/ void UnhandledExceptionHandler(object sender, System.UnhandledExceptionEventArgs args);
                /*0x76187b8*/ void LogTraceFailure(string traceString, System.Exception exception);
                /*0x380cb08*/ void OnShutdownTracing();
                /*0x76181bc*/ void ShutdownTracing();
                /*0x7619690*/ bool get_CalledShutdown();
                /*0x380b128*/ bool IsEnabled();
                /*0x380d170*/ void TraceEventLogEvent(System.Diagnostics.TraceEventType type, System.Runtime.Diagnostics.TraceRecord traceRecord);
            }

            class DiagnosticTraceSource : System.Diagnostics.TraceSource
            {
                /*0x76196fc*/ DiagnosticTraceSource(string name);
            }

            class DictionaryTraceRecord : System.Runtime.Diagnostics.TraceRecord
            {
                /*0x10*/ System.Collections.IDictionary dictionary;

                /*0x7619764*/ DictionaryTraceRecord(System.Collections.IDictionary dictionary);
                /*0x761979c*/ void WriteTo(System.Xml.XmlWriter xml);
            }

            class EtwDiagnosticTrace : System.Runtime.Diagnostics.DiagnosticTraceBase
            {
                static /*0x0*/ System.Guid ImmutableDefaultEtwProviderId;
                static /*0x10*/ System.Guid defaultEtwProviderId;
                static /*0x20*/ System.Collections.Hashtable etwProviderCache;
                static /*0x28*/ bool isVistaOrGreater;
                static /*0x30*/ System.Func<string> traceAnnotation;
                static /*0x38*/ System.Runtime.Diagnostics.EventDescriptor transferEventDescriptor;
                /*0x40*/ System.Runtime.Diagnostics.EtwProvider etwProvider;
                /*0x48*/ System.Guid etwProviderId;

                static /*0x7619bec*/ EtwDiagnosticTrace();
                static /*0x761a3b4*/ System.Guid get_DefaultEtwProviderId();
                static /*0x761a6ec*/ string BuildTrace(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description, System.Runtime.TracePayload payload, string msdnTraceCode);
                static /*0x761a494*/ void GenerateLegacyTraceCode(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, ref string msdnTraceCode, ref int legacyEventId);
                static /*0x761af84*/ string GenerateMsdnTraceCode(string traceSource, string traceCodeString);
                static /*0x761ae68*/ string LookupChannel(System.Runtime.TraceChannel traceChannel);
                static /*0x761b6d4*/ string ExceptionToTraceString(System.Exception exception, int maxTraceStringLength);
                static /*0x761c1b0*/ void WriteExceptionToTraceString(System.Xml.XmlTextWriter xml, System.Exception exception, int remainingLength, int remainingAllowedRecursionDepth);
                static /*0x761d84c*/ string GetInnerException(System.Exception exception, int remainingLength, int remainingAllowedRecursionDepth);
                static /*0x761cdd0*/ string GetExceptionData(System.Exception exception);
                static /*0x761cc98*/ bool WriteStartElement(System.Xml.XmlTextWriter xml, string localName, ref int remainingLength);
                static /*0x761ccf0*/ bool WriteXmlElementString(System.Xml.XmlTextWriter xml, string localName, string value, ref int remainingLength);
                /*0x7612b5c*/ EtwDiagnosticTrace(string traceSourceName, System.Guid etwProviderId);
                /*0x761a40c*/ System.Runtime.Diagnostics.EtwProvider get_EtwProvider();
                /*0x7616284*/ bool get_IsEtwProviderEnabled();
                /*0x7612f38*/ System.Action get_RefreshState();
                /*0x7612f54*/ void set_RefreshState(System.Action value);
                /*0x761a3a4*/ bool get_EtwTracingEnabled();
                /*0x76137e0*/ void SetEnd2EndActivityTracingEnabled(bool isEnd2EndTracingEnabled);
                /*0x761a414*/ bool ShouldTrace(System.Runtime.TraceEventLevel level);
                /*0x761a468*/ bool ShouldTraceToEtw(System.Runtime.TraceEventLevel level);
                /*0x76167fc*/ void WriteTraceSource(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description, System.Runtime.TracePayload payload);
                /*0x7614658*/ System.Runtime.TracePayload GetSerializedPayload(object source, System.Runtime.Diagnostics.TraceRecord traceRecord, System.Exception exception);
                /*0x761b034*/ System.Runtime.TracePayload GetSerializedPayload(object source, System.Runtime.Diagnostics.TraceRecord traceRecord, System.Exception exception, bool getServiceReference);
                /*0x76162a4*/ bool IsEtwEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, bool fullCheck);
                /*0x7619d1c*/ void CreateTraceSource();
                /*0x761a048*/ void CreateEtwProvider(System.Guid etwProviderId);
                /*0x761bb5c*/ void OnShutdownTracing();
                /*0x761bb74*/ void ShutdownTraceSource();
                /*0x761bd68*/ void ShutdownEtwProvider();
                /*0x761be28*/ bool IsEnabled();
                /*0x761befc*/ void TraceEventLogEvent(System.Diagnostics.TraceEventType type, System.Runtime.Diagnostics.TraceRecord traceRecord);
                /*0x761c0ec*/ void OnUnhandledException(System.Exception exception);

                class StringBuilderPool
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<System.Text.StringBuilder> freeStringBuilders;

                    static /*0x761de38*/ StringBuilderPool();
                    static /*0x761adac*/ System.Text.StringBuilder Take();
                    static /*0x761dd58*/ void Return(System.Text.StringBuilder sb);
                }
            }

            class EtwProvider : System.Runtime.Diagnostics.DiagnosticsEventProvider
            {
                /*0x50*/ System.Action invokeControllerCallback;
                /*0x58*/ bool end2EndActivityTracingEnabled;

                /*0x761bb58*/ EtwProvider(System.Guid id);
                /*0x761ded0*/ System.Action get_ControllerCallBack();
                /*0x761ded8*/ void set_ControllerCallBack(System.Action value);
                /*0x761dee0*/ void OnControllerCommand();
                /*0x761df00*/ void SetEnd2EndActivityTracingEnabled(bool isEnd2EndActivityTracingEnabled);
                /*0x76166b4*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2);
                /*0x7616508*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3);
                /*0x7616304*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4);
            }

            struct EventDescriptor
            {
                /*0x10*/ ushort m_id;
                /*0x12*/ byte m_version;
                /*0x13*/ byte m_channel;
                /*0x14*/ byte m_level;
                /*0x15*/ byte m_opcode;
                /*0x16*/ ushort m_task;
                /*0x18*/ long m_keywords;

                /*0x7615f60*/ EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords);
                /*0x761df0c*/ int get_EventId();
                /*0x761df14*/ byte get_Channel();
                /*0x761df1c*/ byte get_Level();
                /*0x761df24*/ byte get_Opcode();
                /*0x761df2c*/ long get_Keywords();
                /*0x761df34*/ bool Equals(object obj);
                /*0x761e01c*/ int GetHashCode();
                /*0x761dfac*/ bool Equals(System.Runtime.Diagnostics.EventDescriptor other);
            }

            class EventLogger
            {
                static /*0x0*/ int logCountForPT;
                static /*0x4*/ bool canLogEvent;
                /*0x10*/ System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace;
                /*0x18*/ string eventLogSourceName;
                /*0x20*/ bool isInPartialTrust;

                static /*0x761e9b8*/ EventLogger();
                static /*0x7618b50*/ System.Runtime.Diagnostics.EventLogger UnsafeCreateEventLogger(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace);
                static /*0x761e988*/ System.Diagnostics.EventLogEntryType EventLogEntryTypeFromEventType(System.Diagnostics.TraceEventType type);
                static /*0x761e2b0*/ string NormalizeEventLogParameter(string eventLogParameter);
                /*0x761e054*/ EventLogger();
                /*0x7619d98*/ EventLogger(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace);
                /*0x7618be0*/ void UnsafeLogEvent(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, string[] values);
                /*0x7619ed4*/ void LogEvent(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, string[] values);
                /*0x761e980*/ void SafeLogEvent(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, string[] values);
                /*0x761e9b0*/ void SafeSetLogSourceName(string eventLogSourceName);
                /*0x761e280*/ void SetLogSourceName(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace);
                /*0x761e078*/ bool IsInPartialTrust();
                /*0x761e758*/ void UnsafeWriteEventLog(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, string[] logValues, byte[] sidBA, System.Runtime.InteropServices.GCHandle stringsRootHandle);
                /*0x761e458*/ string UnsafeGetProcessName();
                /*0x761e5d8*/ int UnsafeGetProcessId();
            }

            class EventTraceActivity
            {
                /*0x10*/ System.Guid ActivityId;
            }

            interface ITraceSourceStringProvider
            {
                /*0x380b9e8*/ string GetSourceString();
            }

            class StringTraceRecord : System.Runtime.Diagnostics.TraceRecord
            {
                /*0x10*/ string elementName;
                /*0x18*/ string content;

                /*0x761ea04*/ StringTraceRecord(string elementName, string content);
                /*0x761ea48*/ void WriteTo(System.Xml.XmlWriter writer);
            }

            class TraceRecord
            {
                /*0x7619794*/ TraceRecord();
                /*0x761ea6c*/ void WriteTo(System.Xml.XmlWriter writer);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 1812FFD58290AC7DDA7A88832F32082655D69F735E8B764AD679F9A0D19AE462;
    static /*0x18*/ <PrivateImplementationDetails> 62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9;
    static /*0x118*/ <PrivateImplementationDetails> 69B4F5E3CE230ECC9509A555D4DF97EFDCA206A15ACCD048A0729C8315C8E38E;

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }

    struct __StaticArrayInitTypeSize=256
    {
    }
}
