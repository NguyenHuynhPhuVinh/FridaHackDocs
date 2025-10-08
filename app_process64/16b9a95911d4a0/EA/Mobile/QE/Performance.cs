class <Module>
{
}

class <>f__AnonymousType0<<Avg>j__TPar, <StdDev>j__TPar, <Min>j__TPar, <Max>j__TPar, <Count>j__TPar>
{
    /*0x0*/ <Avg> <Avg>i__Field;
    /*0x0*/ <StdDev> <StdDev>i__Field;
    /*0x0*/ <Min> <Min>i__Field;
    /*0x0*/ <Max> <Max>i__Field;
    /*0x0*/ <Count> <Count>i__Field;

    /*0x1ffc854*/ <>f__AnonymousType0(<Avg> Avg, <StdDev> StdDev, <Min> Min, <Max> Max, <Count> Count);
    /*0x1f2fec8*/ bool Equals(object value);
    /*0x1f2ffc8*/ int GetHashCode();
    /*0x1f30214*/ string ToString();
}

namespace EA
{
    namespace Mobile
    {
        namespace QE
        {
            namespace Performance
            {
                class PerformanceManager
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<EA.Mobile.QE.Performance.Collector.CollectorTypes, EA.Mobile.QE.Performance.Collector.EventCollector> _collectors;
                    /*0x18*/ System.Collections.Generic.List<EA.Mobile.QE.Performance.Reporting.IEventReporter> _reporters;
                    /*0x20*/ EA.Mobile.QE.Performance.Logging.ILogger _logger;
                    /*0x28*/ EA.Mobile.QE.Performance.Collector.IEventCollectorFactory _eventCollectorFactory;
                    /*0x30*/ EA.Mobile.QE.Performance.Collector.CollectorTypes[] _collectorTypes;
                    /*0x38*/ EA.Mobile.QE.Performance.Collector.CollectorTypes _enabledCollectors;
                    /*0x40*/ EA.Mobile.QE.Performance.Reporting.CollectionEventDispatcher _collectionEventDispatcher;

                    /*0x2bbc3ac*/ PerformanceManager(EA.Mobile.QE.Performance.Logging.ILogger logger);
                    /*0x2bbc668*/ void Toggle(EA.Mobile.QE.Performance.Collector.CollectorTypes collectorTypes);
                    /*0x2bbc904*/ void RegisterReporter(EA.Mobile.QE.Performance.Reporting.IEventReporterFactory reporterFactory, System.TimeSpan reportingInterval);
                    /*0x2bbcb24*/ void Stop();
                    /*0x2bbcf9c*/ string ToString();
                    /*0x2bbc684*/ void HandleCollectorToggle(EA.Mobile.QE.Performance.Collector.CollectorTypes types);
                }

                class JsonUtils
                {
                    static /*0x0*/ Newtonsoft.Json.JsonSerializerSettings Settings;
                    static /*0x8*/ Newtonsoft.Json.JsonSerializer Serializer;

                    static /*0x2bbd050*/ JsonUtils();
                    static /*0x2bbd1b0*/ string ToJson(object toSerialize);
                }

                namespace Reporting
                {
                    class AggregationResult
                    {
                        /*0x10*/ string <PropertyName>k__BackingField;
                        /*0x18*/ double <Average>k__BackingField;
                        /*0x20*/ double <StandardDeviation>k__BackingField;
                        /*0x28*/ double <Minimum>k__BackingField;
                        /*0x30*/ double <Maximum>k__BackingField;
                        /*0x38*/ int <Count>k__BackingField;

                        /*0x2bbd2a0*/ AggregationResult();
                        /*0x2bbd240*/ string get_PropertyName();
                        /*0x2bbd248*/ void set_PropertyName(string value);
                        /*0x2bbd250*/ double get_Average();
                        /*0x2bbd258*/ void set_Average(double value);
                        /*0x2bbd260*/ double get_StandardDeviation();
                        /*0x2bbd268*/ void set_StandardDeviation(double value);
                        /*0x2bbd270*/ double get_Minimum();
                        /*0x2bbd278*/ void set_Minimum(double value);
                        /*0x2bbd280*/ double get_Maximum();
                        /*0x2bbd288*/ void set_Maximum(double value);
                        /*0x2bbd290*/ int get_Count();
                        /*0x2bbd298*/ void set_Count(int value);
                    }

                    class AggregationUtils
                    {
                        static /*0x1f327cc*/ System.Collections.Generic.ICollection<EA.Mobile.QE.Performance.Reporting.AggregationResult> GetAggregationResult<T>(System.Collections.Generic.IList<T> eventsToAggregate);
                        static /*0x1f327fc*/ EA.Mobile.QE.Performance.Reporting.AggregationResult GetAggregationResult<T>(System.Collections.Generic.IList<T> eventsToAggregate, int propertySelectorIndex);
                    }

                    class CollectionEventDispatcher
                    {
                        /*0x10*/ EA.Mobile.QE.Performance.Logging.ILogger _logger;

                        /*0x2bbc638*/ CollectionEventDispatcher(EA.Mobile.QE.Performance.Logging.ILogger logger);
                    }

                    interface IEventReporter
                    {
                        /*0x1f309e4*/ void Stop();
                    }

                    interface IEventReporterFactory
                    {
                        EA.Mobile.QE.Performance.Reporting.IEventReporter CreateInstance(EA.Mobile.QE.Performance.Collector.CollectorTypes types, System.TimeSpan reportingInterval);
                    }

                    namespace Firebase
                    {
                        class FirebaseReporter : EA.Mobile.QE.Performance.Reporting.IEventReporter
                        {
                            /*0x10*/ System.Collections.Concurrent.ConcurrentQueue<EA.Mobile.QE.Performance.Collector.ICollectionEvent> _events;
                            /*0x18*/ EA.Mobile.QE.Performance.Reporting.Firebase.IFirebaseEventDispatcher _dispatcher;
                            /*0x20*/ EA.Mobile.QE.Performance.Logging.ILogger _logger;
                            /*0x28*/ System.Timers.Timer _timer;
                            /*0x30*/ System.TimeSpan _interval;
                            /*0x38*/ EA.Mobile.QE.Performance.Collector.CollectorTypes <Types>k__BackingField;

                            /*0x2bbd2a8*/ FirebaseReporter(System.TimeSpan reportingInterval, EA.Mobile.QE.Performance.Collector.CollectorTypes types, EA.Mobile.QE.Performance.Reporting.Firebase.IFirebaseEventDispatcher dispatcher, EA.Mobile.QE.Performance.Logging.ILogger logger);
                            /*0x2bbd494*/ void Stop();
                            /*0x2bbd4c8*/ void ReportCollectedEventsAtInterval(object sender, System.Timers.ElapsedEventArgs e);
                            /*0x2bbd5cc*/ System.Collections.Generic.Dictionary<string, object> CreateAnalyticsEvent();
                            /*0x2bbdb24*/ System.Collections.Generic.Dictionary<EA.Mobile.QE.Performance.Collector.CollectorTypes, System.Collections.Generic.List<EA.Mobile.QE.Performance.Collector.ICollectionEvent>> GetPendingEventsForInterval();
                        }

                        class FirebaseReporterFactory : EA.Mobile.QE.Performance.Reporting.IEventReporterFactory
                        {
                            /*0x10*/ EA.Mobile.QE.Performance.Logging.ILogger _logger;
                            /*0x18*/ EA.Mobile.QE.Performance.Reporting.Firebase.IFirebaseEventDispatcher _dispatcher;

                            /*0x2bbe08c*/ FirebaseReporterFactory(EA.Mobile.QE.Performance.Reporting.Firebase.IFirebaseEventDispatcher dispatcher, EA.Mobile.QE.Performance.Logging.ILogger logger);
                            /*0x2bbe124*/ EA.Mobile.QE.Performance.Reporting.IEventReporter CreateInstance(EA.Mobile.QE.Performance.Collector.CollectorTypes types, System.TimeSpan reportingInterval);
                        }

                        class FirebaseUtils
                        {
                            static /*0x2bbde80*/ void SerializeAggregationEvent(EA.Mobile.QE.Performance.Reporting.AggregationResult aggregationResult, System.Collections.Generic.Dictionary<string, object> performanceAnalyticsEvent);
                        }

                        interface IFirebaseEventDispatcher
                        {
                            /*0x1f30ebc*/ void DispatchEvent(System.Collections.Generic.Dictionary<string, object> eventParameters);
                        }
                    }
                }

                namespace Logging
                {
                    class ConsoleLogger : EA.Mobile.QE.Performance.Logging.ILogger
                    {
                        /*0x2bbc600*/ ConsoleLogger();
                        /*0x2bbe2ac*/ void Log(string message);
                        /*0x2bbe304*/ void LogError(string message);
                        /*0x2bbe308*/ void LogError(System.Exception exception);
                    }

                    interface ILogger
                    {
                        /*0x1f30ebc*/ void LogError(string message);
                        /*0x1f30ebc*/ void LogError(System.Exception exception);
                    }
                }

                namespace Collector
                {
                    class CollectionEventArgs
                    {
                    }

                    class CollectionEventErrorArgs
                    {
                        /*0x10*/ System.Exception <Exception>k__BackingField;

                        /*0x2bbe340*/ System.Exception get_Exception();
                    }

                    interface ICollectionEvent
                    {
                        /*0x1f2ffc8*/ EA.Mobile.QE.Performance.Collector.CollectorTypes get_Type();
                        /*0x1f30214*/ System.Func<System.ValueTuple<string, System.Lazy<System.Nullable<double>>>> get_Aggregates();
                    }

                    enum CollectorTypes
                    {
                        None = 0,
                        Cpu = 1,
                        Battery = 2,
                        Memory = 4,
                        Fps = 8,
                        Temperature = 16,
                    }

                    class EventCollector : System.IDisposable
                    {
                        /*0x10*/ System.Timers.Timer _timer;
                        /*0x18*/ bool <IsEnabled>k__BackingField;

                        /*0x2bbe348*/ bool get_IsEnabled();
                        /*0x2bbe350*/ void set_IsEnabled(bool value);
                        /*0x2bbe358*/ void Start();
                        /*0x2bbd040*/ void Toggle();
                        /*0x2bbd020*/ void Stop();
                        /*0x2bbcf74*/ void Dispose();
                    }

                    class EventCollectorFactory : EA.Mobile.QE.Performance.Collector.IEventCollectorFactory
                    {
                        /*0x10*/ EA.Mobile.QE.Performance.Logging.ILogger _logger;

                        /*0x2bbc608*/ EventCollectorFactory(EA.Mobile.QE.Performance.Logging.ILogger logger);
                    }

                    interface IEventCollectorFactory
                    {
                    }
                }
            }
        }
    }
}
