class <Module>
{
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class Unsafe
            {
                static /*0x3910ae8*/ T ReadUnaligned<T>(ref byte source);
                static /*0x3910ae8*/ void WriteUnaligned<T>(ref byte destination, T value);
                static /*0x382ad0c*/ int SizeOf<T>();
                static /*0x38379c4*/ ref T AsRef<T>(ref T source);
                static /*0x38379c4*/ ref TTo As<TFrom, TTo>(ref TFrom source);
                static /*0x38390c0*/ ref T Add<T>(ref T source, int elementOffset);
                static /*0x3910ae8*/ ref T Add<T>(ref T source, nuint elementOffset);
            }
        }

        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x757c88c*/ NonVersionableAttribute();
            }
        }

        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x757c894*/ IsReadOnlyAttribute();
            }

            class NativeIntegerAttribute : System.Attribute
            {
                /*0x10*/ bool[] TransformFlags;

                /*0x757c89c*/ NativeIntegerAttribute();
            }
        }
    }
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x757c91c*/ EmbeddedAttribute();
        }
    }
}
