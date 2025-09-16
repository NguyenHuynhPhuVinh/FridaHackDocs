class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7b263e8*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x7b263f0*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace Unity
{
    namespace Profiling
    {
        struct ProfilerCounterValue<T>
        {
            /*0x3910ae8*/ ProfilerCounterValue(Unity.Profiling.ProfilerCategory category, string name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit);
            /*0x3910ae8*/ ProfilerCounterValue(Unity.Profiling.ProfilerCategory category, string name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions);
            /*0x3910ae8*/ T get_Value();
            /*0x3910ae8*/ void set_Value(T value);
        }
    }
}
