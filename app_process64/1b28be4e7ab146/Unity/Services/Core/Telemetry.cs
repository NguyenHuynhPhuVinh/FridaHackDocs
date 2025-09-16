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

                        /*0x7d1a1ac*/ Diagnostics();
                        /*0x7d1a1a8*/ void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class DiagnosticsFactory : Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField;

                        /*0x7d1a284*/ DiagnosticsFactory();
                        /*0x7d1a234*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    class Metrics : Unity.Services.Core.Telemetry.Internal.IMetrics
                    {
                        /*0x10*/ System.Collections.Generic.IDictionary<string, string> <PackageTags>k__BackingField;

                        /*0x7d1a318*/ Metrics();
                        /*0x7d1a30c*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x7d1a310*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        /*0x7d1a314*/ void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    class MetricsFactory : Unity.Services.Core.Telemetry.Internal.IMetricsFactory, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ System.Collections.Generic.IReadOnlyDictionary<string, string> <CommonTags>k__BackingField;

                        /*0x7d1a3f0*/ MetricsFactory();
                        /*0x7d1a3a0*/ Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
                    }
                }
            }
        }
    }
}
