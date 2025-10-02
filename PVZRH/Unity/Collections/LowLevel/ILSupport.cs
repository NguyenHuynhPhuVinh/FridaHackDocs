class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x534220*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x534220*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace Unity
{
    namespace Collections
    {
        namespace LowLevel
        {
            namespace Unsafe
            {
                class ILSupport
                {
                    static /*0x2a5510*/ void* AddressOf<T>(ref T thing);
                    static /*0x17e030*/ ref T AsRef<T>(ref T thing);
                }
            }
        }
    }
}
