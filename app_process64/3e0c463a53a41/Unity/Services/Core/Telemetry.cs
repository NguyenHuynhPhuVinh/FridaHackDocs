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
                    class Diagnostics : Unity.Services.Core.Telemetry.Internal.IDiagnostics
                    {
                        /*0x10*/ System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField;

                        /*0x7d02d7c*/ Diagnostics();
                        /*0x7d02d78*/ void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class DiagnosticsFactory : Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField;

                        /*0x7d02e54*/ DiagnosticsFactory();
                        /*0x7d02e04*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    class Metrics : Unity.Services.Core.Telemetry.Internal.IMetrics
                    {
                        /*0x10*/ System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField;

                        /*0x7d02ee8*/ Metrics();
                        /*0x7d02edc*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x7d02ee0*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x7d02ee4*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class MetricsFactory : Unity.Services.Core.Telemetry.Internal.IMetricsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField;

                        /*0x7d02fc0*/ MetricsFactory();
                        /*0x7d02f70*/ Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
                    }
                }
            }
        }
    }
}
