class <Module>
{
}

namespace EA
{
    namespace Profiling
    {
        class ScopedProfiler
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, UnityEngine.Profiling.CustomSampler> CachedSamples;
            static /*0x8*/ EA.Profiling.ScopedProfiler.ScopedProfileSample EmptySample;

            static /*0x2bd8968*/ ScopedProfiler();
            static /*0x2bd8910*/ EA.Profiling.ScopedProfiler.ScopedProfileSample Sample(string name);

            struct ScopedProfileSample : System.IDisposable
            {
                /*0x10*/ UnityEngine.Profiling.CustomSampler _customSampler;

                /*0x2bd8a34*/ ScopedProfileSample(UnityEngine.Profiling.CustomSampler sampler);
                /*0x2bd8a3c*/ void Dispose();
            }
        }
    }
}
