class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3ad3854*/ EmbeddedAttribute();
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
                /*0x3ad385c*/ IsUnmanagedAttribute();
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
            /*0x1ffc854*/ ProfilerCounterValue(Unity.Profiling.ProfilerCategory category, string name, Unity.Profiling.ProfilerMarkerDataUnit dataUnit, Unity.Profiling.ProfilerCounterOptions counterOptions);
            /*0x1ffc854*/ T get_Value();
            /*0x1ffc854*/ void set_Value(T value);
        }
    }
}
