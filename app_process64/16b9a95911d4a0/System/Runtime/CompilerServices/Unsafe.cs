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
                static /*0x1ffc854*/ T ReadUnaligned<T>(ref byte source);
                static /*0x1ffc854*/ void WriteUnaligned<T>(ref byte destination, T value);
                static /*0x1f327cc*/ ref TTo As<TFrom, TTo>(ref TFrom source);
                static /*0x1f327fc*/ ref T Add<T>(ref T source, int elementOffset);
                static /*0x1ffc854*/ ref T AddByteOffset<T>(ref T source, nint byteOffset);
            }
        }

        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x37ec394*/ NonVersionableAttribute();
            }
        }
    }
}
