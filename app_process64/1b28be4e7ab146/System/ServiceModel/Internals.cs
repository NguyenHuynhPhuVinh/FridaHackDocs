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
            /*0x7628f40*/ CallbackException();
            /*0x7628f50*/ CallbackException(string message, System.Exception innerException);
            /*0x7628f60*/ CallbackException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class ExceptionTrace
        {
            /*0x10*/ string eventSourceName;
            /*0x18*/ System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace;

            /*0x7628f70*/ ExceptionTrace(string eventSourceName, System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace);
            /*0x7628fb4*/ System.ArgumentOutOfRangeException ArgumentOutOfRange(string paramName, object actualValue, string message);
            /*0x7629050*/ void TraceHandledException(System.Exception exception, System.Diagnostics.TraceEventType traceEventType);
            /*0x3910ae8*/ TException TraceException<TException>(TException exception);
            /*0x3910ae8*/ TException TraceException<TException>(TException exception, string eventSource);
            /*0x7629c88*/ void BreakOnException(System.Exception exception);
        }

        class FatalException : System.SystemException
        {
            /*0x7628f48*/ FatalException();
            /*0x7628f58*/ FatalException(string message, System.Exception innerException);
            /*0x7628f68*/ FatalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class Fx
        {
            static /*0x0*/ System.Runtime.ExceptionTrace exceptionTrace;
            static /*0x8*/ System.Runtime.Diagnostics.EtwDiagnosticTrace diagnosticTrace;

            static /*0x7629c8c*/ System.Runtime.ExceptionTrace get_Exception();
            static /*0x7629d4c*/ System.Runtime.Diagnostics.EtwDiagnosticTrace get_Trace();
            static /*0x7629dc0*/ System.Runtime.Diagnostics.EtwDiagnosticTrace InitializeTracing();
            static /*0x762a430*/ System.Exception AssertAndThrow(string description);
            static /*0x762a694*/ bool IsFatal(System.Exception exception);
            static /*0x762a3a0*/ void UpdateLevel(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762ac30*/ void UpdateLevel();

            class InternalException : System.SystemException
            {
                /*0x762a670*/ InternalException(string description);
                /*0x762ac8c*/ InternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class FatalInternalException : System.Runtime.Fx.InternalException
            {
                /*0x762ac94*/ FatalInternalException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
            }

            class <>c
            {
                static /*0x0*/ System.Runtime.Fx.<> <>9;
                static /*0x8*/ System.Action <>9__8_0;

                static /*0x762ac9c*/ <>c();
                /*0x762ad04*/ <>c();
                /*0x762ad0c*/ void <InitializeTracing>b__8_0();
            }
        }

        class HashHelper
        {
            static /*0x762ad1c*/ byte[] ComputeHash(byte[] buffer);
        }

        class PartialTrustHelpers
        {
            static /*0x762b270*/ bool HasEtwPermissions();
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

            static /*0x762b484*/ TraceLevelHelper();
            static /*0x762b278*/ System.Diagnostics.TraceEventType GetTraceEventType(System.Runtime.TraceEventLevel level);
            static /*0x762b2f4*/ string LookupSeverity(System.Runtime.TraceEventLevel level, System.Runtime.TraceEventOpcode opcode);
        }

        struct TracePayload
        {
            /*0x10*/ string serializedException;
            /*0x18*/ string eventSource;
            /*0x20*/ string appDomainFriendlyName;
            /*0x28*/ string extendedData;
            /*0x30*/ string hostReference;

            /*0x762b524*/ TracePayload(string serializedException, string eventSource, string appDomainFriendlyName, string extendedData, string hostReference);
            /*0x762b598*/ string get_SerializedException();
            /*0x762b5a0*/ string get_EventSource();
            /*0x762b5a8*/ string get_AppDomainFriendlyName();
            /*0x762b5b0*/ string get_ExtendedData();
        }

        class TraceCore
        {
            static /*0x0*/ System.Resources.ResourceManager resourceManager;
            static /*0x8*/ System.Globalization.CultureInfo resourceCulture;
            static /*0x10*/ System.Runtime.Diagnostics.EventDescriptor[] eventDescriptors;
            static /*0x18*/ object syncLock;
            static /*0x20*/ bool eventDescriptorsCreated;

            static /*0x762de40*/ TraceCore();
            static /*0x762b5b8*/ System.Resources.ResourceManager get_ResourceManager();
            static /*0x762b6fc*/ System.Globalization.CultureInfo get_Culture();
            static /*0x762b754*/ bool AppDomainUnloadIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762b88c*/ void AppDomainUnload(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string appdomainName, string processName, string processId);
            static /*0x7629a14*/ bool HandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7629a9c*/ void HandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x762a494*/ void ShipAssertExceptionMessage(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0);
            static /*0x762be54*/ bool ThrowingExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762bedc*/ void ThrowingException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, string param1, System.Exception exception);
            static /*0x762c0dc*/ bool UnhandledExceptionIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762c164*/ void UnhandledException(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x762c350*/ bool TraceCodeEventLogCriticalIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762c3d8*/ void TraceCodeEventLogCritical(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x762c620*/ bool TraceCodeEventLogErrorIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762c6a8*/ void TraceCodeEventLogError(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x762c8f0*/ bool TraceCodeEventLogInfoIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762c978*/ void TraceCodeEventLogInfo(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x762cbc0*/ bool TraceCodeEventLogVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762cc48*/ void TraceCodeEventLogVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x762ce90*/ bool TraceCodeEventLogWarningIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762cf18*/ void TraceCodeEventLogWarning(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, System.Runtime.Diagnostics.TraceRecord traceRecord);
            static /*0x762952c*/ bool HandledExceptionWarningIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x76295b4*/ void HandledExceptionWarning(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x762abb8*/ bool ActionItemScheduledIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x762ab60*/ bool ActionItemCallbackInvokedIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x76292b8*/ bool HandledExceptionErrorIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7629340*/ void HandledExceptionError(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x76297a0*/ bool HandledExceptionVerboseIsEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace);
            static /*0x7629828*/ void HandledExceptionVerbose(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, string param0, System.Exception exception);
            static /*0x762d160*/ void CreateEventDescriptors();
            static /*0x762d53c*/ void EnsureEventDescriptors();
            static /*0x762b7dc*/ bool IsEtwEventEnabled(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex);
            static /*0x762bac0*/ bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4);
            static /*0x762bcd4*/ bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3);
            static /*0x762bd9c*/ bool WriteEtwEvent(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, System.Runtime.Diagnostics.EventTraceActivity eventParam0, string eventParam1, string eventParam2);
            static /*0x762bbfc*/ void WriteTraceSource(System.Runtime.Diagnostics.EtwDiagnosticTrace trace, int eventIndex, string description, System.Runtime.TracePayload payload);
        }

        class InternalSR
        {
            static /*0x762deb4*/ string EtwRegistrationFailed(object arg);
            static /*0x762ac40*/ string ShipAssertExceptionMessage(object description);
        }

        namespace Interop
        {
            class SafeEventLogWriteHandle : Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid
            {
                static /*0x762df0c*/ System.Runtime.Interop.SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName);
                static /*0x762e08c*/ bool DeregisterEventSource(nint hEventLog);
                /*0x762df00*/ SafeEventLogWriteHandle();
                /*0x762e114*/ bool ReleaseHandle();
            }

            class UnsafeNativeMethods
            {
                static /*0x762e11c*/ uint EventRegister(ref System.Guid providerId, System.Runtime.Interop.UnsafeNativeMethods.EtwEnableCallback enableCallback, void* callbackContext, ref long registrationHandle);
                static /*0x762e1c4*/ uint EventUnregister(long registrationHandle);
                static /*0x762e244*/ bool EventEnabled(long registrationHandle, ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor);
                static /*0x762e2d0*/ uint EventWrite(long registrationHandle, ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, uint userDataCount, System.Runtime.Interop.UnsafeNativeMethods.EventData* userData);
                static /*0x762e370*/ uint EventActivityIdControl(int ControlCode, ref System.Guid ActivityId);
                static /*0x762e3f4*/ bool ReportEvent(System.Runtime.InteropServices.SafeHandle hEventLog, ushort type, ushort category, uint eventID, byte[] userSID, ushort numStrings, uint dataLen, System.Runtime.InteropServices.HandleRef strings, byte[] rawData);
                static /*0x762dfa0*/ System.Runtime.Interop.SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName);

                struct EventData
                {
                    /*0x10*/ ulong DataPointer;
                    /*0x18*/ uint Size;
                    /*0x1c*/ int Reserved;
                }

                class EtwEnableCallback : System.MulticastDelegate
                {
                    /*0x762e530*/ EtwEnableCallback(object object, nint method);
                    /*0x762e5e4*/ void Invoke(ref System.Guid sourceId, int isEnabled, byte level, long matchAnyKeywords, long matchAllKeywords, void* filterData, void* callbackContext);
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

                static /*0x762e9a4*/ void SetLastError(int error);
                static /*0x762eb7c*/ void SetActivityId(ref System.Guid id);
                /*0x762e5fc*/ DiagnosticsEventProvider(System.Guid providerGuid);
                /*0x762e660*/ void EtwRegister();
                /*0x762e780*/ void Dispose();
                /*0x762e7ec*/ void Dispose(bool disposing);
                /*0x762e84c*/ void Finalize();
                /*0x762e82c*/ void Deregister();
                /*0x762e8ec*/ void EtwEnableCallBack(ref System.Guid sourceId, int isEnabled, byte setLevel, long anyKeyword, long allKeyword, void* filterData, void* callbackContext);
                /*0x38159dc*/ void OnControllerCommand();
                /*0x762e90c*/ bool IsEnabled();
                /*0x762e914*/ bool IsEnabled(byte level, long keywords);
                /*0x762e958*/ bool IsEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor);
                /*0x762ea10*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string data);
                /*0x762eb88*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, int dataCount, nint data);

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

                static /*0x7630ac8*/ DiagnosticTraceBase();
                static /*0x762ecd8*/ void UnsafeRemoveDefaultTraceListener(System.Diagnostics.TraceSource traceSource);
                static /*0x762efa0*/ string get_ProcessName();
                static /*0x762f120*/ int get_ProcessId();
                static /*0x762f2e0*/ string XmlEncode(string text);
                static /*0x762f75c*/ string CreateSourceString(object source);
                static /*0x762f838*/ string CreateDefaultSourceString(object source);
                static /*0x762f964*/ string StackTraceString(System.Exception exception);
                /*0x762ec00*/ DiagnosticTraceBase(string traceSourceName);
                /*0x762ecc8*/ System.DateTime get_LastFailure();
                /*0x762ecd0*/ void set_LastFailure(System.DateTime value);
                /*0x762ed38*/ System.Diagnostics.TraceSource get_TraceSource();
                /*0x762ed40*/ void SetTraceSource(System.Diagnostics.TraceSource traceSource);
                /*0x762ede0*/ bool get_HaveListeners();
                /*0x762ede8*/ System.Diagnostics.SourceLevels FixLevel(System.Diagnostics.SourceLevels level);
                /*0x762ee28*/ void OnSetLevel(System.Diagnostics.SourceLevels level);
                /*0x762ee2c*/ void SetLevel(System.Diagnostics.SourceLevels level);
                /*0x762ef0c*/ System.Diagnostics.SourceLevels get_Level();
                /*0x762ef70*/ string get_EventSourceName();
                /*0x762ef78*/ void set_EventSourceName(string value);
                /*0x762ef80*/ bool get_TracingEnabled();
                /*0x762f2a0*/ bool ShouldTrace(System.Runtime.TraceEventLevel level);
                /*0x762f2a4*/ bool ShouldTrace(System.Diagnostics.TraceEventType type);
                /*0x762bb90*/ bool ShouldTraceToTraceSource(System.Runtime.TraceEventLevel level);
                /*0x762f454*/ void AddDomainEventHandlersForCleanup();
                /*0x762f5e8*/ void ExitOrUnloadEventHandler(object sender, System.EventArgs e);
                /*0x3816710*/ void OnUnhandledException(System.Exception exception);
                /*0x762f6bc*/ void UnhandledExceptionHandler(object sender, System.UnhandledExceptionEventArgs args);
                /*0x762fbe8*/ void LogTraceFailure(string traceString, System.Exception exception);
                /*0x38159dc*/ void OnShutdownTracing();
                /*0x762f5ec*/ void ShutdownTracing();
                /*0x7630ac0*/ bool get_CalledShutdown();
                /*0x3813ffc*/ bool IsEnabled();
                /*0x3816044*/ void TraceEventLogEvent(System.Diagnostics.TraceEventType type, System.Runtime.Diagnostics.TraceRecord traceRecord);
            }

            class DiagnosticTraceSource : System.Diagnostics.TraceSource
            {
                /*0x7630b2c*/ DiagnosticTraceSource(string name);
            }

            class DictionaryTraceRecord : System.Runtime.Diagnostics.TraceRecord
            {
                /*0x10*/ System.Collections.IDictionary dictionary;

                /*0x7630b94*/ DictionaryTraceRecord(System.Collections.IDictionary dictionary);
                /*0x7630bcc*/ void WriteTo(System.Xml.XmlWriter xml);
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

                static /*0x763101c*/ EtwDiagnosticTrace();
                static /*0x76317e4*/ System.Guid get_DefaultEtwProviderId();
                static /*0x7631b1c*/ string BuildTrace(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description, System.Runtime.TracePayload payload, string msdnTraceCode);
                static /*0x76318c4*/ void GenerateLegacyTraceCode(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, ref string msdnTraceCode, ref int legacyEventId);
                static /*0x76323b4*/ string GenerateMsdnTraceCode(string traceSource, string traceCodeString);
                static /*0x7632298*/ string LookupChannel(System.Runtime.TraceChannel traceChannel);
                static /*0x7632b04*/ string ExceptionToTraceString(System.Exception exception, int maxTraceStringLength);
                static /*0x76335e0*/ void WriteExceptionToTraceString(System.Xml.XmlTextWriter xml, System.Exception exception, int remainingLength, int remainingAllowedRecursionDepth);
                static /*0x7634c7c*/ string GetInnerException(System.Exception exception, int remainingLength, int remainingAllowedRecursionDepth);
                static /*0x7634200*/ string GetExceptionData(System.Exception exception);
                static /*0x76340c8*/ bool WriteStartElement(System.Xml.XmlTextWriter xml, string localName, ref int remainingLength);
                static /*0x7634120*/ bool WriteXmlElementString(System.Xml.XmlTextWriter xml, string localName, string value, ref int remainingLength);
                /*0x7629f8c*/ EtwDiagnosticTrace(string traceSourceName, System.Guid etwProviderId);
                /*0x763183c*/ System.Runtime.Diagnostics.EtwProvider get_EtwProvider();
                /*0x762d6b4*/ bool get_IsEtwProviderEnabled();
                /*0x762a368*/ System.Action get_RefreshState();
                /*0x762a384*/ void set_RefreshState(System.Action value);
                /*0x76317d4*/ bool get_EtwTracingEnabled();
                /*0x762ac10*/ void SetEnd2EndActivityTracingEnabled(bool isEnd2EndTracingEnabled);
                /*0x7631844*/ bool ShouldTrace(System.Runtime.TraceEventLevel level);
                /*0x7631898*/ bool ShouldTraceToEtw(System.Runtime.TraceEventLevel level);
                /*0x762dc2c*/ void WriteTraceSource(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, string description, System.Runtime.TracePayload payload);
                /*0x762ba88*/ System.Runtime.TracePayload GetSerializedPayload(object source, System.Runtime.Diagnostics.TraceRecord traceRecord, System.Exception exception);
                /*0x7632464*/ System.Runtime.TracePayload GetSerializedPayload(object source, System.Runtime.Diagnostics.TraceRecord traceRecord, System.Exception exception, bool getServiceReference);
                /*0x762d6d4*/ bool IsEtwEventEnabled(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, bool fullCheck);
                /*0x763114c*/ void CreateTraceSource();
                /*0x7631478*/ void CreateEtwProvider(System.Guid etwProviderId);
                /*0x7632f8c*/ void OnShutdownTracing();
                /*0x7632fa4*/ void ShutdownTraceSource();
                /*0x7633198*/ void ShutdownEtwProvider();
                /*0x7633258*/ bool IsEnabled();
                /*0x763332c*/ void TraceEventLogEvent(System.Diagnostics.TraceEventType type, System.Runtime.Diagnostics.TraceRecord traceRecord);
                /*0x763351c*/ void OnUnhandledException(System.Exception exception);

                class StringBuilderPool
                {
                    static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<System.Text.StringBuilder> freeStringBuilders;

                    static /*0x7635268*/ StringBuilderPool();
                    static /*0x76321dc*/ System.Text.StringBuilder Take();
                    static /*0x7635188*/ void Return(System.Text.StringBuilder sb);
                }
            }

            class EtwProvider : System.Runtime.Diagnostics.DiagnosticsEventProvider
            {
                /*0x50*/ System.Action invokeControllerCallback;
                /*0x58*/ bool end2EndActivityTracingEnabled;

                /*0x7632f88*/ EtwProvider(System.Guid id);
                /*0x7635300*/ System.Action get_ControllerCallBack();
                /*0x7635308*/ void set_ControllerCallBack(System.Action value);
                /*0x7635310*/ void OnControllerCommand();
                /*0x7635330*/ void SetEnd2EndActivityTracingEnabled(bool isEnd2EndActivityTracingEnabled);
                /*0x762dae4*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2);
                /*0x762d938*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3);
                /*0x762d734*/ bool WriteEvent(ref System.Runtime.Diagnostics.EventDescriptor eventDescriptor, System.Runtime.Diagnostics.EventTraceActivity eventTraceActivity, string value1, string value2, string value3, string value4);
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

                /*0x762d390*/ EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords);
                /*0x763533c*/ int get_EventId();
                /*0x7635344*/ byte get_Channel();
                /*0x763534c*/ byte get_Level();
                /*0x7635354*/ byte get_Opcode();
                /*0x763535c*/ long get_Keywords();
                /*0x7635364*/ bool Equals(object obj);
                /*0x763544c*/ int GetHashCode();
                /*0x76353dc*/ bool Equals(System.Runtime.Diagnostics.EventDescriptor other);
            }

            class EventLogger
            {
                static /*0x0*/ int logCountForPT;
                static /*0x4*/ bool canLogEvent;
                /*0x10*/ System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace;
                /*0x18*/ string eventLogSourceName;
                /*0x20*/ bool isInPartialTrust;

                static /*0x7635de8*/ EventLogger();
                static /*0x762ff80*/ System.Runtime.Diagnostics.EventLogger UnsafeCreateEventLogger(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace);
                static /*0x7635db8*/ System.Diagnostics.EventLogEntryType EventLogEntryTypeFromEventType(System.Diagnostics.TraceEventType type);
                static /*0x76356e0*/ string NormalizeEventLogParameter(string eventLogParameter);
                /*0x7635484*/ EventLogger();
                /*0x76311c8*/ EventLogger(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace);
                /*0x7630010*/ void UnsafeLogEvent(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, string[] values);
                /*0x7631304*/ void LogEvent(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, string[] values);
                /*0x7635db0*/ void SafeLogEvent(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, string[] values);
                /*0x7635de0*/ void SafeSetLogSourceName(string eventLogSourceName);
                /*0x76356b0*/ void SetLogSourceName(string eventLogSourceName, System.Runtime.Diagnostics.DiagnosticTraceBase diagnosticTrace);
                /*0x76354a8*/ bool IsInPartialTrust();
                /*0x7635b88*/ void UnsafeWriteEventLog(System.Diagnostics.TraceEventType type, ushort eventLogCategory, uint eventId, string[] logValues, byte[] sidBA, System.Runtime.InteropServices.GCHandle stringsRootHandle);
                /*0x7635888*/ string UnsafeGetProcessName();
                /*0x7635a08*/ int UnsafeGetProcessId();
            }

            class EventTraceActivity
            {
                /*0x10*/ System.Guid ActivityId;
            }

            interface ITraceSourceStringProvider
            {
                /*0x38148bc*/ string GetSourceString();
            }

            class StringTraceRecord : System.Runtime.Diagnostics.TraceRecord
            {
                /*0x10*/ string elementName;
                /*0x18*/ string content;

                /*0x7635e34*/ StringTraceRecord(string elementName, string content);
                /*0x7635e78*/ void WriteTo(System.Xml.XmlWriter writer);
            }

            class TraceRecord
            {
                /*0x7630bc4*/ TraceRecord();
                /*0x7635e9c*/ void WriteTo(System.Xml.XmlWriter writer);
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
