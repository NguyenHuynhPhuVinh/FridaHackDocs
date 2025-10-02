class <Module>
{
}

namespace Unity
{
    namespace Burst
    {
        class Unsafe
        {
            static /*0x2a5510*/ T Read<T>(void* source);
            static /*0x2a5510*/ T ReadUnaligned<T>(void* source);
            static /*0x2a5510*/ T ReadUnaligned<T>(ref byte source);
            static /*0x2a5510*/ void Write<T>(void* destination, T value);
            static /*0x2a5510*/ void WriteUnaligned<T>(void* destination, T value);
            static /*0x2a5510*/ void WriteUnaligned<T>(ref byte destination, T value);
            static /*0x2a5510*/ void Copy<T>(void* destination, ref T source);
            static /*0x2a5510*/ void Copy<T>(ref T destination, void* source);
            static /*0x2a5510*/ void* AsPointer<T>(ref T value);
            static /*0x1809b0*/ int SizeOf<T>();
            static /*0x1142a10*/ void CopyBlock(void* destination, void* source, uint byteCount);
            static /*0x1142a10*/ void CopyBlock(ref byte destination, ref byte source, uint byteCount);
            static /*0x1142a10*/ void CopyBlockUnaligned(void* destination, void* source, uint byteCount);
            static /*0x1142a10*/ void CopyBlockUnaligned(ref byte destination, ref byte source, uint byteCount);
            static /*0x1142a20*/ void InitBlock(void* startAddress, byte value, uint byteCount);
            static /*0x1142a20*/ void InitBlock(ref byte startAddress, byte value, uint byteCount);
            static /*0x1142a20*/ void InitBlockUnaligned(void* startAddress, byte value, uint byteCount);
            static /*0x1142a20*/ void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount);
            static /*0x2a5510*/ T As<T>(object o);
            static /*0x2a5510*/ ref T AsRef<T>(void* source);
            static /*0x17e030*/ ref T AsRef<T>(ref T source);
            static /*0x17e030*/ ref TTo As<TFrom, TTo>(ref TFrom source);
            static /*0x17e030*/ ref T Unbox<T>(object box);
            static /*0x17baf0*/ ref T Add<T>(ref T source, int elementOffset);
            static /*0x2a5510*/ void* Add<T>(void* source, int elementOffset);
            static /*0x2a5510*/ ref T Add<T>(ref T source, nint elementOffset);
            static /*0x2a5510*/ ref T AddByteOffset<T>(ref T source, nint byteOffset);
            static /*0x17baf0*/ ref T Subtract<T>(ref T source, int elementOffset);
            static /*0x2a5510*/ void* Subtract<T>(void* source, int elementOffset);
            static /*0x2a5510*/ ref T Subtract<T>(ref T source, nint elementOffset);
            static /*0x2a5510*/ ref T SubtractByteOffset<T>(ref T source, nint byteOffset);
            static /*0x2a5510*/ nint ByteOffset<T>(ref T origin, ref T target);
            static /*0x1794f0*/ bool AreSame<T>(ref T left, ref T right);
            static /*0x1794f0*/ bool IsAddressGreaterThan<T>(ref T left, ref T right);
            static /*0x1794f0*/ bool IsAddressLessThan<T>(ref T left, ref T right);
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace Versioning
        {
            class NonVersionableAttribute : System.Attribute
            {
                /*0x534220*/ NonVersionableAttribute();
            }
        }

        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x534220*/ IsReadOnlyAttribute();
            }
        }
    }
}
