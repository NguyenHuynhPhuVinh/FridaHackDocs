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
                static /*0x3907c14*/ T ReadUnaligned<T>(ref byte source);
                static /*0x3907c14*/ void WriteUnaligned<T>(ref byte destination, T value);
                static /*0x3821e38*/ int SizeOf<T>();
                static /*0x382eaf0*/ ref T AsRef<T>(ref T source);
                static /*0x382eaf0*/ ref TTo As<TFrom, TTo>(ref TFrom source);
                static /*0x38301ec*/ ref T Add<T>(ref T source, int elementOffset);
                static /*0x3907c14*/ ref T Add<T>(ref T source, nuint elementOffset);
            }
        }

        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x756545c*/ NonVersionableAttribute();
            }
        }

        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x7565464*/ IsReadOnlyAttribute();
            }

            class NativeIntegerAttribute : System.Attribute
            {
                /*0x10*/ bool[] TransformFlags;

                /*0x756546c*/ NativeIntegerAttribute();
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
            /*0x75654ec*/ EmbeddedAttribute();
        }
    }
}
