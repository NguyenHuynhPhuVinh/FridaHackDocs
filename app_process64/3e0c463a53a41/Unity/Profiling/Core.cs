class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7b0efb8*/ EmbeddedAttribute();
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
                /*0x7b0efc0*/ IsUnmanagedAttribute();
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
            /*0x3907c14*/ ProfilerCounterValue(Unity.Profiling.ProfilerCategory category, string name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit);
            /*0x3907c14*/ ProfilerCounterValue(Unity.Profiling.ProfilerCategory category, string name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions);
            /*0x3907c14*/ T get_Value();
            /*0x3907c14*/ void set_Value(T value);
        }
    }
}
