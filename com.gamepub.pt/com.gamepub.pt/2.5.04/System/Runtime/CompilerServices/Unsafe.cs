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
                static T ReadUnaligned<T>(ref byte source);
                static void WriteUnaligned<T>(ref byte destination, T value);
                static void* AsPointer<T>(ref T value);
                static int SizeOf<T>();
                static /*0x2b3a9b0*/ void CopyBlock(ref byte destination, ref byte source, uint byteCount);
                static /*0x2b3a9b8*/ void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount);
                static /*0x2b3a9c0*/ void InitBlockUnaligned(void* startAddress, byte value, uint byteCount);
                static /*0x2b3a9c8*/ void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount);
                static T As<T>(object o);
                static ref T AsRef<T>(void* source);
                static ref TTo As<TFrom, TTo>(ref TFrom source);
                static ref T Add<T>(ref T source, int elementOffset);
                static ref T Add<T>(ref T source, nint elementOffset);
                static ref T AddByteOffset<T>(ref T source, nint byteOffset);
                static nint ByteOffset<T>(ref T origin, ref T target);
                static bool AreSame<T>(ref T left, ref T right);
            }
        }

        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x2b3a9a8*/ NonVersionableAttribute();
            }
        }
    }
}
