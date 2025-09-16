class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x79e97c4*/ EmbeddedAttribute();
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
                /*0x79e97cc*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace Unity
{
    namespace Jobs
    {
        class EarlyInitHelpers
        {
            static /*0x0*/ System.Collections.Generic.List<Unity.Jobs.EarlyInitHelpers.EarlyInitFunction> s_PendingDelegates;

            static /*0x79e97d4*/ EarlyInitHelpers();
            static /*0x79e97d8*/ void FlushEarlyInits();
            static /*0x79e9990*/ void JobReflectionDataCreationFailed(System.Exception ex);

            class EarlyInitFunction : System.MulticastDelegate
            {
                /*0x79e9a08*/ EarlyInitFunction(object object, nint method);
                /*0x79e9aa4*/ void Invoke();
            }
        }

        interface IJobParallelForBatch
        {
            /*0x3815fb8*/ void Execute(int startIndex, int count);
        }

        class IJobParallelForBatchExtensions
        {
            static /*0x383e7a0*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3910ae8*/ Unity.Jobs.JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int indicesPerJobCount, Unity.Jobs.JobHandle dependsOn);
            static /*0x3910ae8*/ Unity.Jobs.JobHandle ScheduleBatch<T>(T jobData, int arrayLength, int indicesPerJobCount, Unity.Jobs.JobHandle dependsOn);

            struct JobParallelForBatchProducer<T>
            {
                static /*0x0*/ Unity.Burst.SharedStatic<nint> jobReflectionData;

                static /*0x383e7a0*/ JobParallelForBatchProducer();
                static /*0x383e7a0*/ void Initialize();
                static /*0x3843798*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        class RegisterGenericJobTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type ConcreteType;

            /*0x79e9ab8*/ RegisterGenericJobTypeAttribute(System.Type type);
        }

        class DOTSCompilerGeneratedAttribute : System.Attribute
        {
            /*0x79e9ae8*/ DOTSCompilerGeneratedAttribute();
        }
    }

    namespace Collections
    {
        class AllocatorManager
        {
            static /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Invalid;
            static /*0x4*/ Unity.Collections.AllocatorManager.AllocatorHandle None;
            static /*0x8*/ Unity.Collections.AllocatorManager.AllocatorHandle Temp;
            static /*0xc*/ Unity.Collections.AllocatorManager.AllocatorHandle TempJob;
            static /*0x10*/ Unity.Collections.AllocatorManager.AllocatorHandle Persistent;
            static /*0x14*/ Unity.Collections.AllocatorManager.AllocatorHandle AudioKernel;
            static /*0x18*/ ushort NumGlobalScratchAllocators;
            static /*0x1a*/ ushort MaxNumGlobalAllocators;
            static /*0x1c*/ uint GlobalAllocatorBaseIndex;
            static /*0x20*/ uint FirstGlobalScratchpadAllocatorIndex;

            static /*0x79ea0b8*/ AllocatorManager();
            static /*0x3910ae8*/ Unity.Collections.AllocatorManager.Block AllocateBlock<T>(ref T t, int sizeOf, int alignOf, int items);
            static /*0x3910ae8*/ void* Allocate<T>(ref T t, int sizeOf, int alignOf, int items);
            static /*0x3910ae8*/ U* Allocate<T, U>(ref T t, U u, int items);
            static /*0x3843dfc*/ void FreeBlock<T>(ref T t, ref Unity.Collections.AllocatorManager.Block block);
            static /*0x3910ae8*/ void Free<T>(ref T t, void* pointer, int sizeOf, int alignOf, int items);
            static /*0x3910ae8*/ void Free<T, U>(ref T t, U* pointer, int items);
            static /*0x79e9af0*/ void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, void* pointer);
            static /*0x3910ae8*/ void Free<T>(Unity.Collections.AllocatorManager.AllocatorHandle handle, T* pointer, int items);
            static /*0x79e9b74*/ void CheckDelegate(ref bool useDelegate);
            static /*0x79e9b80*/ bool UseDelegate();
            static /*0x79e9bd0*/ int allocate_block(ref Unity.Collections.AllocatorManager.Block block);
            static /*0x79e9d00*/ void forward_mono_allocate_block(ref Unity.Collections.AllocatorManager.Block block, ref int error);
            static /*0x79e9e18*/ Unity.Collections.Allocator LegacyOf(Unity.Collections.AllocatorManager.AllocatorHandle handle);
            static /*0x79e9e2c*/ int TryLegacy(ref Unity.Collections.AllocatorManager.Block block);
            static /*0x79e9fd8*/ int Try(ref Unity.Collections.AllocatorManager.Block block);

            class TryFunction : System.MulticastDelegate
            {
                /*0x79ea178*/ TryFunction(object object, nint method);
                /*0x79ea218*/ int Invoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
            }

            struct AllocatorHandle : Unity.Collections.AllocatorManager.IAllocator, System.IDisposable, System.IEquatable<Unity.Collections.AllocatorManager.AllocatorHandle>, System.IComparable<Unity.Collections.AllocatorManager.AllocatorHandle>
            {
                /*0x10*/ ushort Index;
                /*0x12*/ ushort Version;

                static /*0x79e9f94*/ Unity.Collections.AllocatorManager.AllocatorHandle op_Implicit(Unity.Collections.Allocator a);
                /*0x79e9c68*/ ref Unity.Collections.AllocatorManager.TableEntry get_TableEntry();
                /*0x79ea22c*/ void Rewind();
                /*0x79ea230*/ int get_Value();
                /*0x79ea238*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
                /*0x79e9e10*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
                /*0x79ea2a0*/ Unity.Collections.Allocator get_ToAllocator();
                /*0x79ea2a8*/ void Dispose();
                /*0x79ea2bc*/ bool Equals(object obj);
                /*0x79ea368*/ bool Equals(Unity.Collections.AllocatorManager.AllocatorHandle other);
                /*0x79ea378*/ int GetHashCode();
                /*0x79ea380*/ int CompareTo(Unity.Collections.AllocatorManager.AllocatorHandle other);
            }

            struct Range : System.IDisposable
            {
                /*0x10*/ nint Pointer;
                /*0x18*/ int Items;
                /*0x1c*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                /*0x79ea38c*/ void Dispose();
            }

            struct Block : System.IDisposable
            {
                /*0x10*/ Unity.Collections.AllocatorManager.Range Range;
                /*0x20*/ int BytesPerItem;
                /*0x24*/ int AllocatedItems;
                /*0x28*/ byte Log2Alignment;
                /*0x29*/ byte Padding0;
                /*0x2a*/ ushort Padding1;
                /*0x2c*/ uint Padding2;

                /*0x79e9f74*/ long get_Bytes();
                /*0x79ea3d4*/ long get_AllocatedBytes();
                /*0x79e9f84*/ int get_Alignment();
                /*0x79ea3e0*/ void set_Alignment(int value);
                /*0x79ea3d0*/ void Dispose();
                /*0x79ea420*/ int TryFree();
            }

            interface IAllocator : System.IDisposable
            {
                /*0x381467c*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
                /*0x3910ae8*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
            }

            struct TableEntry
            {
                /*0x10*/ nint function;
                /*0x18*/ nint state;
            }

            struct Array16<T>
            {
                /*0x0*/ T f0;
                /*0x0*/ T f1;
                /*0x0*/ T f2;
                /*0x0*/ T f3;
                /*0x0*/ T f4;
                /*0x0*/ T f5;
                /*0x0*/ T f6;
                /*0x0*/ T f7;
                /*0x0*/ T f8;
                /*0x0*/ T f9;
                /*0x0*/ T f10;
                /*0x0*/ T f11;
                /*0x0*/ T f12;
                /*0x0*/ T f13;
                /*0x0*/ T f14;
                /*0x0*/ T f15;
            }

            struct Array256<T>
            {
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f0;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f1;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f2;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f3;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f4;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f5;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f6;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f7;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f8;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f9;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f10;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f11;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f12;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f13;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f14;
                /*0x0*/ Unity.Collections.AllocatorManager.Array16<T> f15;
            }

            struct Array4096<T>
            {
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f0;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f1;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f2;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f3;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f4;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f5;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f6;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f7;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f8;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f9;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f10;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f11;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f12;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f13;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f14;
                /*0x0*/ Unity.Collections.AllocatorManager.Array256<T> f15;
            }

            struct Array32768<T> : Unity.Collections.IIndexable<T>
            {
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f0;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f1;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f2;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f3;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f4;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f5;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f6;
                /*0x0*/ Unity.Collections.AllocatorManager.Array4096<T> f7;

                /*0x3814574*/ int get_Length();
                /*0x3814964*/ ref T ElementAt(int index);
            }

            class SharedStatics
            {
                class TableEntry
                {
                    static /*0x0*/ Unity.Burst.SharedStatic<Unity.Collections.AllocatorManager.Array32768<Unity.Collections.AllocatorManager.TableEntry>> Ref;

                    static /*0x79ea478*/ TableEntry();
                }
            }

            class Managed
            {
                static /*0x0*/ Unity.Collections.AllocatorManager.TryFunction[] TryFunctionDelegates;

                static /*0x79ea4f4*/ Managed();
            }
        }

        class CollectionHelper
        {
            static /*0x79ea568*/ int Log2Floor(int value);
            static /*0x79ea5a0*/ int Align(int size, int alignmentPowerOfTwo);
            static /*0x79ea5bc*/ uint Hash(void* ptr, int bytes);
            static /*0x79ea5fc*/ bool ShouldDeallocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x79ea608*/ int AssumePositive(int value);

            struct DummyJob : Unity.Jobs.IJob
            {
                /*0x79ea60c*/ void Execute();
            }
        }

        struct FixedList
        {
            static /*0x382ad0c*/ int PaddingBytes<T>();
            static /*0x382ad0c*/ int StorageBytes<BUFFER, T>();
            static /*0x382ad0c*/ int Capacity<BUFFER, T>();
        }

        struct FixedList32Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ Unity.Collections.FixedBytes32Align8 data;

            /*0x3815648*/ ushort get_length();
            void set_length(ushort value);
            /*0x3910ae8*/ byte* get_buffer();
            /*0x3814574*/ int get_Length();
            /*0x3815ed0*/ void set_Length(int value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x3814574*/ int get_LengthInBytes();
            /*0x3910ae8*/ byte* get_Buffer();
            /*0x3814574*/ int get_Capacity();
            /*0x3910ae8*/ T get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, T value);
            /*0x3814574*/ int GetHashCode();
            /*0x38148bc*/ T[] ToArray();
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        }

        class FixedList32BytesDebugView<T>
        {
        }

        struct FixedList64Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ Unity.Collections.FixedBytes64Align8 data;

            /*0x3815648*/ ushort get_length();
            void set_length(ushort value);
            /*0x3910ae8*/ byte* get_buffer();
            /*0x3814574*/ int get_Length();
            /*0x3815ed0*/ void set_Length(int value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x3814574*/ int get_LengthInBytes();
            /*0x3910ae8*/ byte* get_Buffer();
            /*0x3814574*/ int GetHashCode();
            /*0x38148bc*/ T[] ToArray();
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        }

        class FixedList64BytesDebugView<T>
        {
        }

        struct FixedList128Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ Unity.Collections.FixedBytes128Align8 data;

            /*0x3815648*/ ushort get_length();
            void set_length(ushort value);
            /*0x3910ae8*/ byte* get_buffer();
            /*0x3814574*/ int get_Length();
            /*0x3815ed0*/ void set_Length(int value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x3814574*/ int get_LengthInBytes();
            /*0x3910ae8*/ byte* get_Buffer();
            /*0x3814574*/ int GetHashCode();
            /*0x38148bc*/ T[] ToArray();
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        }

        class FixedList128BytesDebugView<T>
        {
        }

        struct FixedList512Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ Unity.Collections.FixedBytes512Align8 data;

            /*0x3815648*/ ushort get_length();
            void set_length(ushort value);
            /*0x3910ae8*/ byte* get_buffer();
            /*0x3814574*/ int get_Length();
            /*0x3815ed0*/ void set_Length(int value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x3814574*/ int get_LengthInBytes();
            /*0x3910ae8*/ byte* get_Buffer();
            /*0x3814574*/ int GetHashCode();
            /*0x38148bc*/ T[] ToArray();
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        }

        class FixedList512BytesDebugView<T>
        {
        }

        struct FixedList4096Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ Unity.Collections.FixedBytes4096Align8 data;

            /*0x3815648*/ ushort get_length();
            void set_length(ushort value);
            /*0x3910ae8*/ byte* get_buffer();
            /*0x3814574*/ int get_Length();
            /*0x3815ed0*/ void set_Length(int value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x3814574*/ int get_LengthInBytes();
            /*0x3910ae8*/ byte* get_Buffer();
            /*0x3814574*/ int GetHashCode();
            /*0x38148bc*/ T[] ToArray();
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x3910ae8*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x3910ae8*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
        }

        class FixedList4096BytesDebugView<T>
        {
        }

        struct FixedBytes16Align8
        {
            /*0x10*/ ulong byte0000;
            /*0x18*/ ulong byte0008;
        }

        struct FixedBytes32Align8
        {
            /*0x10*/ Unity.Collections.FixedBytes16Align8 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16Align8 offset0016;
        }

        struct FixedBytes64Align8
        {
            /*0x10*/ Unity.Collections.FixedBytes16Align8 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16Align8 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16Align8 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16Align8 offset0048;
        }

        struct FixedBytes128Align8
        {
            /*0x10*/ Unity.Collections.FixedBytes16Align8 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16Align8 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16Align8 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16Align8 offset0048;
            /*0x50*/ Unity.Collections.FixedBytes16Align8 offset0064;
            /*0x60*/ Unity.Collections.FixedBytes16Align8 offset0080;
            /*0x70*/ Unity.Collections.FixedBytes16Align8 offset0096;
            /*0x80*/ Unity.Collections.FixedBytes16Align8 offset0112;
        }

        struct FixedBytes512Align8
        {
            /*0x10*/ Unity.Collections.FixedBytes16Align8 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16Align8 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16Align8 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16Align8 offset0048;
            /*0x50*/ Unity.Collections.FixedBytes16Align8 offset0064;
            /*0x60*/ Unity.Collections.FixedBytes16Align8 offset0080;
            /*0x70*/ Unity.Collections.FixedBytes16Align8 offset0096;
            /*0x80*/ Unity.Collections.FixedBytes16Align8 offset0112;
            /*0x90*/ Unity.Collections.FixedBytes16Align8 offset0128;
            /*0xa0*/ Unity.Collections.FixedBytes16Align8 offset0144;
            /*0xb0*/ Unity.Collections.FixedBytes16Align8 offset0160;
            /*0xc0*/ Unity.Collections.FixedBytes16Align8 offset0176;
            /*0xd0*/ Unity.Collections.FixedBytes16Align8 offset0192;
            /*0xe0*/ Unity.Collections.FixedBytes16Align8 offset0208;
            /*0xf0*/ Unity.Collections.FixedBytes16Align8 offset0224;
            /*0x100*/ Unity.Collections.FixedBytes16Align8 offset0240;
            /*0x110*/ Unity.Collections.FixedBytes16Align8 offset0256;
            /*0x120*/ Unity.Collections.FixedBytes16Align8 offset0272;
            /*0x130*/ Unity.Collections.FixedBytes16Align8 offset0288;
            /*0x140*/ Unity.Collections.FixedBytes16Align8 offset0304;
            /*0x150*/ Unity.Collections.FixedBytes16Align8 offset0320;
            /*0x160*/ Unity.Collections.FixedBytes16Align8 offset0336;
            /*0x170*/ Unity.Collections.FixedBytes16Align8 offset0352;
            /*0x180*/ Unity.Collections.FixedBytes16Align8 offset0368;
            /*0x190*/ Unity.Collections.FixedBytes16Align8 offset0384;
            /*0x1a0*/ Unity.Collections.FixedBytes16Align8 offset0400;
            /*0x1b0*/ Unity.Collections.FixedBytes16Align8 offset0416;
            /*0x1c0*/ Unity.Collections.FixedBytes16Align8 offset0432;
            /*0x1d0*/ Unity.Collections.FixedBytes16Align8 offset0448;
            /*0x1e0*/ Unity.Collections.FixedBytes16Align8 offset0464;
            /*0x1f0*/ Unity.Collections.FixedBytes16Align8 offset0480;
            /*0x200*/ Unity.Collections.FixedBytes16Align8 offset0496;
        }

        struct FixedBytes4096Align8
        {
            /*0x10*/ Unity.Collections.FixedBytes16Align8 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16Align8 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16Align8 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16Align8 offset0048;
            /*0x50*/ Unity.Collections.FixedBytes16Align8 offset0064;
            /*0x60*/ Unity.Collections.FixedBytes16Align8 offset0080;
            /*0x70*/ Unity.Collections.FixedBytes16Align8 offset0096;
            /*0x80*/ Unity.Collections.FixedBytes16Align8 offset0112;
            /*0x90*/ Unity.Collections.FixedBytes16Align8 offset0128;
            /*0xa0*/ Unity.Collections.FixedBytes16Align8 offset0144;
            /*0xb0*/ Unity.Collections.FixedBytes16Align8 offset0160;
            /*0xc0*/ Unity.Collections.FixedBytes16Align8 offset0176;
            /*0xd0*/ Unity.Collections.FixedBytes16Align8 offset0192;
            /*0xe0*/ Unity.Collections.FixedBytes16Align8 offset0208;
            /*0xf0*/ Unity.Collections.FixedBytes16Align8 offset0224;
            /*0x100*/ Unity.Collections.FixedBytes16Align8 offset0240;
            /*0x110*/ Unity.Collections.FixedBytes16Align8 offset0256;
            /*0x120*/ Unity.Collections.FixedBytes16Align8 offset0272;
            /*0x130*/ Unity.Collections.FixedBytes16Align8 offset0288;
            /*0x140*/ Unity.Collections.FixedBytes16Align8 offset0304;
            /*0x150*/ Unity.Collections.FixedBytes16Align8 offset0320;
            /*0x160*/ Unity.Collections.FixedBytes16Align8 offset0336;
            /*0x170*/ Unity.Collections.FixedBytes16Align8 offset0352;
            /*0x180*/ Unity.Collections.FixedBytes16Align8 offset0368;
            /*0x190*/ Unity.Collections.FixedBytes16Align8 offset0384;
            /*0x1a0*/ Unity.Collections.FixedBytes16Align8 offset0400;
            /*0x1b0*/ Unity.Collections.FixedBytes16Align8 offset0416;
            /*0x1c0*/ Unity.Collections.FixedBytes16Align8 offset0432;
            /*0x1d0*/ Unity.Collections.FixedBytes16Align8 offset0448;
            /*0x1e0*/ Unity.Collections.FixedBytes16Align8 offset0464;
            /*0x1f0*/ Unity.Collections.FixedBytes16Align8 offset0480;
            /*0x200*/ Unity.Collections.FixedBytes16Align8 offset0496;
            /*0x210*/ Unity.Collections.FixedBytes16Align8 offset0512;
            /*0x220*/ Unity.Collections.FixedBytes16Align8 offset0528;
            /*0x230*/ Unity.Collections.FixedBytes16Align8 offset0544;
            /*0x240*/ Unity.Collections.FixedBytes16Align8 offset0560;
            /*0x250*/ Unity.Collections.FixedBytes16Align8 offset0576;
            /*0x260*/ Unity.Collections.FixedBytes16Align8 offset0592;
            /*0x270*/ Unity.Collections.FixedBytes16Align8 offset0608;
            /*0x280*/ Unity.Collections.FixedBytes16Align8 offset0624;
            /*0x290*/ Unity.Collections.FixedBytes16Align8 offset0640;
            /*0x2a0*/ Unity.Collections.FixedBytes16Align8 offset0656;
            /*0x2b0*/ Unity.Collections.FixedBytes16Align8 offset0672;
            /*0x2c0*/ Unity.Collections.FixedBytes16Align8 offset0688;
            /*0x2d0*/ Unity.Collections.FixedBytes16Align8 offset0704;
            /*0x2e0*/ Unity.Collections.FixedBytes16Align8 offset0720;
            /*0x2f0*/ Unity.Collections.FixedBytes16Align8 offset0736;
            /*0x300*/ Unity.Collections.FixedBytes16Align8 offset0752;
            /*0x310*/ Unity.Collections.FixedBytes16Align8 offset0768;
            /*0x320*/ Unity.Collections.FixedBytes16Align8 offset0784;
            /*0x330*/ Unity.Collections.FixedBytes16Align8 offset0800;
            /*0x340*/ Unity.Collections.FixedBytes16Align8 offset0816;
            /*0x350*/ Unity.Collections.FixedBytes16Align8 offset0832;
            /*0x360*/ Unity.Collections.FixedBytes16Align8 offset0848;
            /*0x370*/ Unity.Collections.FixedBytes16Align8 offset0864;
            /*0x380*/ Unity.Collections.FixedBytes16Align8 offset0880;
            /*0x390*/ Unity.Collections.FixedBytes16Align8 offset0896;
            /*0x3a0*/ Unity.Collections.FixedBytes16Align8 offset0912;
            /*0x3b0*/ Unity.Collections.FixedBytes16Align8 offset0928;
            /*0x3c0*/ Unity.Collections.FixedBytes16Align8 offset0944;
            /*0x3d0*/ Unity.Collections.FixedBytes16Align8 offset0960;
            /*0x3e0*/ Unity.Collections.FixedBytes16Align8 offset0976;
            /*0x3f0*/ Unity.Collections.FixedBytes16Align8 offset0992;
            /*0x400*/ Unity.Collections.FixedBytes16Align8 offset1008;
            /*0x410*/ Unity.Collections.FixedBytes16Align8 offset1024;
            /*0x420*/ Unity.Collections.FixedBytes16Align8 offset1040;
            /*0x430*/ Unity.Collections.FixedBytes16Align8 offset1056;
            /*0x440*/ Unity.Collections.FixedBytes16Align8 offset1072;
            /*0x450*/ Unity.Collections.FixedBytes16Align8 offset1088;
            /*0x460*/ Unity.Collections.FixedBytes16Align8 offset1104;
            /*0x470*/ Unity.Collections.FixedBytes16Align8 offset1120;
            /*0x480*/ Unity.Collections.FixedBytes16Align8 offset1136;
            /*0x490*/ Unity.Collections.FixedBytes16Align8 offset1152;
            /*0x4a0*/ Unity.Collections.FixedBytes16Align8 offset1168;
            /*0x4b0*/ Unity.Collections.FixedBytes16Align8 offset1184;
            /*0x4c0*/ Unity.Collections.FixedBytes16Align8 offset1200;
            /*0x4d0*/ Unity.Collections.FixedBytes16Align8 offset1216;
            /*0x4e0*/ Unity.Collections.FixedBytes16Align8 offset1232;
            /*0x4f0*/ Unity.Collections.FixedBytes16Align8 offset1248;
            /*0x500*/ Unity.Collections.FixedBytes16Align8 offset1264;
            /*0x510*/ Unity.Collections.FixedBytes16Align8 offset1280;
            /*0x520*/ Unity.Collections.FixedBytes16Align8 offset1296;
            /*0x530*/ Unity.Collections.FixedBytes16Align8 offset1312;
            /*0x540*/ Unity.Collections.FixedBytes16Align8 offset1328;
            /*0x550*/ Unity.Collections.FixedBytes16Align8 offset1344;
            /*0x560*/ Unity.Collections.FixedBytes16Align8 offset1360;
            /*0x570*/ Unity.Collections.FixedBytes16Align8 offset1376;
            /*0x580*/ Unity.Collections.FixedBytes16Align8 offset1392;
            /*0x590*/ Unity.Collections.FixedBytes16Align8 offset1408;
            /*0x5a0*/ Unity.Collections.FixedBytes16Align8 offset1424;
            /*0x5b0*/ Unity.Collections.FixedBytes16Align8 offset1440;
            /*0x5c0*/ Unity.Collections.FixedBytes16Align8 offset1456;
            /*0x5d0*/ Unity.Collections.FixedBytes16Align8 offset1472;
            /*0x5e0*/ Unity.Collections.FixedBytes16Align8 offset1488;
            /*0x5f0*/ Unity.Collections.FixedBytes16Align8 offset1504;
            /*0x600*/ Unity.Collections.FixedBytes16Align8 offset1520;
            /*0x610*/ Unity.Collections.FixedBytes16Align8 offset1536;
            /*0x620*/ Unity.Collections.FixedBytes16Align8 offset1552;
            /*0x630*/ Unity.Collections.FixedBytes16Align8 offset1568;
            /*0x640*/ Unity.Collections.FixedBytes16Align8 offset1584;
            /*0x650*/ Unity.Collections.FixedBytes16Align8 offset1600;
            /*0x660*/ Unity.Collections.FixedBytes16Align8 offset1616;
            /*0x670*/ Unity.Collections.FixedBytes16Align8 offset1632;
            /*0x680*/ Unity.Collections.FixedBytes16Align8 offset1648;
            /*0x690*/ Unity.Collections.FixedBytes16Align8 offset1664;
            /*0x6a0*/ Unity.Collections.FixedBytes16Align8 offset1680;
            /*0x6b0*/ Unity.Collections.FixedBytes16Align8 offset1696;
            /*0x6c0*/ Unity.Collections.FixedBytes16Align8 offset1712;
            /*0x6d0*/ Unity.Collections.FixedBytes16Align8 offset1728;
            /*0x6e0*/ Unity.Collections.FixedBytes16Align8 offset1744;
            /*0x6f0*/ Unity.Collections.FixedBytes16Align8 offset1760;
            /*0x700*/ Unity.Collections.FixedBytes16Align8 offset1776;
            /*0x710*/ Unity.Collections.FixedBytes16Align8 offset1792;
            /*0x720*/ Unity.Collections.FixedBytes16Align8 offset1808;
            /*0x730*/ Unity.Collections.FixedBytes16Align8 offset1824;
            /*0x740*/ Unity.Collections.FixedBytes16Align8 offset1840;
            /*0x750*/ Unity.Collections.FixedBytes16Align8 offset1856;
            /*0x760*/ Unity.Collections.FixedBytes16Align8 offset1872;
            /*0x770*/ Unity.Collections.FixedBytes16Align8 offset1888;
            /*0x780*/ Unity.Collections.FixedBytes16Align8 offset1904;
            /*0x790*/ Unity.Collections.FixedBytes16Align8 offset1920;
            /*0x7a0*/ Unity.Collections.FixedBytes16Align8 offset1936;
            /*0x7b0*/ Unity.Collections.FixedBytes16Align8 offset1952;
            /*0x7c0*/ Unity.Collections.FixedBytes16Align8 offset1968;
            /*0x7d0*/ Unity.Collections.FixedBytes16Align8 offset1984;
            /*0x7e0*/ Unity.Collections.FixedBytes16Align8 offset2000;
            /*0x7f0*/ Unity.Collections.FixedBytes16Align8 offset2016;
            /*0x800*/ Unity.Collections.FixedBytes16Align8 offset2032;
            /*0x810*/ Unity.Collections.FixedBytes16Align8 offset2048;
            /*0x820*/ Unity.Collections.FixedBytes16Align8 offset2064;
            /*0x830*/ Unity.Collections.FixedBytes16Align8 offset2080;
            /*0x840*/ Unity.Collections.FixedBytes16Align8 offset2096;
            /*0x850*/ Unity.Collections.FixedBytes16Align8 offset2112;
            /*0x860*/ Unity.Collections.FixedBytes16Align8 offset2128;
            /*0x870*/ Unity.Collections.FixedBytes16Align8 offset2144;
            /*0x880*/ Unity.Collections.FixedBytes16Align8 offset2160;
            /*0x890*/ Unity.Collections.FixedBytes16Align8 offset2176;
            /*0x8a0*/ Unity.Collections.FixedBytes16Align8 offset2192;
            /*0x8b0*/ Unity.Collections.FixedBytes16Align8 offset2208;
            /*0x8c0*/ Unity.Collections.FixedBytes16Align8 offset2224;
            /*0x8d0*/ Unity.Collections.FixedBytes16Align8 offset2240;
            /*0x8e0*/ Unity.Collections.FixedBytes16Align8 offset2256;
            /*0x8f0*/ Unity.Collections.FixedBytes16Align8 offset2272;
            /*0x900*/ Unity.Collections.FixedBytes16Align8 offset2288;
            /*0x910*/ Unity.Collections.FixedBytes16Align8 offset2304;
            /*0x920*/ Unity.Collections.FixedBytes16Align8 offset2320;
            /*0x930*/ Unity.Collections.FixedBytes16Align8 offset2336;
            /*0x940*/ Unity.Collections.FixedBytes16Align8 offset2352;
            /*0x950*/ Unity.Collections.FixedBytes16Align8 offset2368;
            /*0x960*/ Unity.Collections.FixedBytes16Align8 offset2384;
            /*0x970*/ Unity.Collections.FixedBytes16Align8 offset2400;
            /*0x980*/ Unity.Collections.FixedBytes16Align8 offset2416;
            /*0x990*/ Unity.Collections.FixedBytes16Align8 offset2432;
            /*0x9a0*/ Unity.Collections.FixedBytes16Align8 offset2448;
            /*0x9b0*/ Unity.Collections.FixedBytes16Align8 offset2464;
            /*0x9c0*/ Unity.Collections.FixedBytes16Align8 offset2480;
            /*0x9d0*/ Unity.Collections.FixedBytes16Align8 offset2496;
            /*0x9e0*/ Unity.Collections.FixedBytes16Align8 offset2512;
            /*0x9f0*/ Unity.Collections.FixedBytes16Align8 offset2528;
            /*0xa00*/ Unity.Collections.FixedBytes16Align8 offset2544;
            /*0xa10*/ Unity.Collections.FixedBytes16Align8 offset2560;
            /*0xa20*/ Unity.Collections.FixedBytes16Align8 offset2576;
            /*0xa30*/ Unity.Collections.FixedBytes16Align8 offset2592;
            /*0xa40*/ Unity.Collections.FixedBytes16Align8 offset2608;
            /*0xa50*/ Unity.Collections.FixedBytes16Align8 offset2624;
            /*0xa60*/ Unity.Collections.FixedBytes16Align8 offset2640;
            /*0xa70*/ Unity.Collections.FixedBytes16Align8 offset2656;
            /*0xa80*/ Unity.Collections.FixedBytes16Align8 offset2672;
            /*0xa90*/ Unity.Collections.FixedBytes16Align8 offset2688;
            /*0xaa0*/ Unity.Collections.FixedBytes16Align8 offset2704;
            /*0xab0*/ Unity.Collections.FixedBytes16Align8 offset2720;
            /*0xac0*/ Unity.Collections.FixedBytes16Align8 offset2736;
            /*0xad0*/ Unity.Collections.FixedBytes16Align8 offset2752;
            /*0xae0*/ Unity.Collections.FixedBytes16Align8 offset2768;
            /*0xaf0*/ Unity.Collections.FixedBytes16Align8 offset2784;
            /*0xb00*/ Unity.Collections.FixedBytes16Align8 offset2800;
            /*0xb10*/ Unity.Collections.FixedBytes16Align8 offset2816;
            /*0xb20*/ Unity.Collections.FixedBytes16Align8 offset2832;
            /*0xb30*/ Unity.Collections.FixedBytes16Align8 offset2848;
            /*0xb40*/ Unity.Collections.FixedBytes16Align8 offset2864;
            /*0xb50*/ Unity.Collections.FixedBytes16Align8 offset2880;
            /*0xb60*/ Unity.Collections.FixedBytes16Align8 offset2896;
            /*0xb70*/ Unity.Collections.FixedBytes16Align8 offset2912;
            /*0xb80*/ Unity.Collections.FixedBytes16Align8 offset2928;
            /*0xb90*/ Unity.Collections.FixedBytes16Align8 offset2944;
            /*0xba0*/ Unity.Collections.FixedBytes16Align8 offset2960;
            /*0xbb0*/ Unity.Collections.FixedBytes16Align8 offset2976;
            /*0xbc0*/ Unity.Collections.FixedBytes16Align8 offset2992;
            /*0xbd0*/ Unity.Collections.FixedBytes16Align8 offset3008;
            /*0xbe0*/ Unity.Collections.FixedBytes16Align8 offset3024;
            /*0xbf0*/ Unity.Collections.FixedBytes16Align8 offset3040;
            /*0xc00*/ Unity.Collections.FixedBytes16Align8 offset3056;
            /*0xc10*/ Unity.Collections.FixedBytes16Align8 offset3072;
            /*0xc20*/ Unity.Collections.FixedBytes16Align8 offset3088;
            /*0xc30*/ Unity.Collections.FixedBytes16Align8 offset3104;
            /*0xc40*/ Unity.Collections.FixedBytes16Align8 offset3120;
            /*0xc50*/ Unity.Collections.FixedBytes16Align8 offset3136;
            /*0xc60*/ Unity.Collections.FixedBytes16Align8 offset3152;
            /*0xc70*/ Unity.Collections.FixedBytes16Align8 offset3168;
            /*0xc80*/ Unity.Collections.FixedBytes16Align8 offset3184;
            /*0xc90*/ Unity.Collections.FixedBytes16Align8 offset3200;
            /*0xca0*/ Unity.Collections.FixedBytes16Align8 offset3216;
            /*0xcb0*/ Unity.Collections.FixedBytes16Align8 offset3232;
            /*0xcc0*/ Unity.Collections.FixedBytes16Align8 offset3248;
            /*0xcd0*/ Unity.Collections.FixedBytes16Align8 offset3264;
            /*0xce0*/ Unity.Collections.FixedBytes16Align8 offset3280;
            /*0xcf0*/ Unity.Collections.FixedBytes16Align8 offset3296;
            /*0xd00*/ Unity.Collections.FixedBytes16Align8 offset3312;
            /*0xd10*/ Unity.Collections.FixedBytes16Align8 offset3328;
            /*0xd20*/ Unity.Collections.FixedBytes16Align8 offset3344;
            /*0xd30*/ Unity.Collections.FixedBytes16Align8 offset3360;
            /*0xd40*/ Unity.Collections.FixedBytes16Align8 offset3376;
            /*0xd50*/ Unity.Collections.FixedBytes16Align8 offset3392;
            /*0xd60*/ Unity.Collections.FixedBytes16Align8 offset3408;
            /*0xd70*/ Unity.Collections.FixedBytes16Align8 offset3424;
            /*0xd80*/ Unity.Collections.FixedBytes16Align8 offset3440;
            /*0xd90*/ Unity.Collections.FixedBytes16Align8 offset3456;
            /*0xda0*/ Unity.Collections.FixedBytes16Align8 offset3472;
            /*0xdb0*/ Unity.Collections.FixedBytes16Align8 offset3488;
            /*0xdc0*/ Unity.Collections.FixedBytes16Align8 offset3504;
            /*0xdd0*/ Unity.Collections.FixedBytes16Align8 offset3520;
            /*0xde0*/ Unity.Collections.FixedBytes16Align8 offset3536;
            /*0xdf0*/ Unity.Collections.FixedBytes16Align8 offset3552;
            /*0xe00*/ Unity.Collections.FixedBytes16Align8 offset3568;
            /*0xe10*/ Unity.Collections.FixedBytes16Align8 offset3584;
            /*0xe20*/ Unity.Collections.FixedBytes16Align8 offset3600;
            /*0xe30*/ Unity.Collections.FixedBytes16Align8 offset3616;
            /*0xe40*/ Unity.Collections.FixedBytes16Align8 offset3632;
            /*0xe50*/ Unity.Collections.FixedBytes16Align8 offset3648;
            /*0xe60*/ Unity.Collections.FixedBytes16Align8 offset3664;
            /*0xe70*/ Unity.Collections.FixedBytes16Align8 offset3680;
            /*0xe80*/ Unity.Collections.FixedBytes16Align8 offset3696;
            /*0xe90*/ Unity.Collections.FixedBytes16Align8 offset3712;
            /*0xea0*/ Unity.Collections.FixedBytes16Align8 offset3728;
            /*0xeb0*/ Unity.Collections.FixedBytes16Align8 offset3744;
            /*0xec0*/ Unity.Collections.FixedBytes16Align8 offset3760;
            /*0xed0*/ Unity.Collections.FixedBytes16Align8 offset3776;
            /*0xee0*/ Unity.Collections.FixedBytes16Align8 offset3792;
            /*0xef0*/ Unity.Collections.FixedBytes16Align8 offset3808;
            /*0xf00*/ Unity.Collections.FixedBytes16Align8 offset3824;
            /*0xf10*/ Unity.Collections.FixedBytes16Align8 offset3840;
            /*0xf20*/ Unity.Collections.FixedBytes16Align8 offset3856;
            /*0xf30*/ Unity.Collections.FixedBytes16Align8 offset3872;
            /*0xf40*/ Unity.Collections.FixedBytes16Align8 offset3888;
            /*0xf50*/ Unity.Collections.FixedBytes16Align8 offset3904;
            /*0xf60*/ Unity.Collections.FixedBytes16Align8 offset3920;
            /*0xf70*/ Unity.Collections.FixedBytes16Align8 offset3936;
            /*0xf80*/ Unity.Collections.FixedBytes16Align8 offset3952;
            /*0xf90*/ Unity.Collections.FixedBytes16Align8 offset3968;
            /*0xfa0*/ Unity.Collections.FixedBytes16Align8 offset3984;
            /*0xfb0*/ Unity.Collections.FixedBytes16Align8 offset4000;
            /*0xfc0*/ Unity.Collections.FixedBytes16Align8 offset4016;
            /*0xfd0*/ Unity.Collections.FixedBytes16Align8 offset4032;
            /*0xfe0*/ Unity.Collections.FixedBytes16Align8 offset4048;
            /*0xff0*/ Unity.Collections.FixedBytes16Align8 offset4064;
            /*0x1000*/ Unity.Collections.FixedBytes16Align8 offset4080;
        }

        class FixedStringMethods
        {
            static /*0x38379c4*/ string ConvertToString<T>(ref T fs);
        }

        interface IUTF8Bytes
        {
            /*0x3910ae8*/ byte* GetUnsafePtr();
        }

        class GenerateTestsForBurstCompatibilityAttribute : System.Attribute
        {
            /*0x10*/ System.Type[] <GenericTypeArguments>k__BackingField;
            /*0x18*/ string RequiredUnityDefine;

            /*0x79ea618*/ GenerateTestsForBurstCompatibilityAttribute();
            /*0x79ea610*/ void set_GenericTypeArguments(System.Type[] value);
        }

        class ExcludeFromBurstCompatTestingAttribute : System.Attribute
        {
            /*0x10*/ string <Reason>k__BackingField;

            /*0x79ea628*/ ExcludeFromBurstCompatTestingAttribute(string _reason);
            /*0x79ea620*/ void set_Reason(string value);
        }

        struct Memory
        {
            struct Unmanaged
            {
                static /*0x79e9f9c*/ void* Allocate(long size, int align, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                static /*0x79e9fb8*/ void Free(void* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                static /*0x3910ae8*/ void Free<T>(T* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator);

                struct Array
                {
                    static /*0x79ea738*/ bool IsCustom(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x79ea744*/ void* CustomResize(void* oldPointer, long oldCount, long newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, long size, int align);
                    static /*0x79ea658*/ void* Resize(void* oldPointer, long oldCount, long newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, long size, int align);
                    static /*0x3910ae8*/ T* Resize<T>(T* oldPointer, long oldCount, long newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                }
            }
        }

        class NativeArrayExtensions
        {
            static /*0x3910ae8*/ bool Contains<T, U>(Unity.Collections.NativeArray.ReadOnly<T> array, U value);
            static /*0x3910ae8*/ int IndexOf<T, U>(void* ptr, int length, U value);
        }

        struct NativeBitArrayDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeBitArray* m_BitArrayData;
            /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_Allocator;

            /*0x79ea834*/ void Dispose();
        }

        struct NativeBitArrayDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeBitArrayDispose Data;

            /*0x79ea8e8*/ void Execute();
        }

        struct NativeHashMapDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<int, int> m_HashMapData;
            /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_Allocator;

            /*0x79ea8f8*/ void Dispose();
        }

        struct NativeHashMapDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeHashMapDispose Data;

            /*0x79ea940*/ void Execute();
        }

        struct KVPair<TKey, TValue>
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.HashMapHelper<TKey> m_Data;
            /*0x0*/ int m_Index;
            /*0x0*/ int m_Next;
        }

        struct NativeHashMap<TKey, TValue> : System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey, TValue>>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.HashMapHelper<TKey> m_Data;

            /*0x3910ae8*/ NativeHashMap(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x38159dc*/ void Dispose();
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Clear();
            /*0x3910ae8*/ bool TryAdd(TKey key, TValue item);
            /*0x3910ae8*/ void Add(TKey key, TValue item);
            /*0x3910ae8*/ bool TryGetValue(TKey key, ref TValue item);
            /*0x3910ae8*/ bool ContainsKey(TKey key);
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Collections.KVPair<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NativeHashMapDebuggerTypeProxy<TKey, TValue>
        {
        }

        interface IIndexable<T>
        {
            /*0x3814574*/ int get_Length();
        }

        interface INativeList<T> : Unity.Collections.IIndexable<T>
        {
        }

        struct NativeList<T> : System.IDisposable, Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> m_ListData;

            /*0x3910ae8*/ NativeList(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x3910ae8*/ NativeList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x3816044*/ void Initialize<U>(int initialCapacity, ref U allocator);
            /*0x3910ae8*/ T get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, T value);
            /*0x3814964*/ ref T ElementAt(int index);
            /*0x3814574*/ int get_Length();
            /*0x3815ed0*/ void set_Length(int value);
            /*0x3814574*/ int get_Capacity();
            /*0x3815ed0*/ void set_Capacity(int value);
            /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> GetUnsafeList();
            /*0x3816710*/ void Add(ref T value);
            /*0x3910ae8*/ void AddRange(Unity.Collections.NativeArray<T> array);
            /*0x3910ae8*/ void AddRange(void* ptr, int count);
            /*0x3815ed0*/ void RemoveAtSwapBack(int index);
            /*0x3815ed0*/ void RemoveAt(int index);
            /*0x3813ffc*/ bool get_IsEmpty();
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Dispose();
            /*0x3910ae8*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x38159dc*/ void Clear();
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> AsArray();
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> AsDeferredJobArray();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x3815fb8*/ void Resize(int length, Unity.Collections.NativeArrayOptions options);
            /*0x3815ed0*/ void ResizeUninitialized(int length);
            /*0x3815ed0*/ void SetCapacity(int capacity);
            /*0x3910ae8*/ Unity.Collections.NativeList.ParallelWriter<T> AsParallelWriter();

            struct ParallelWriter<T>
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> ListData;

                /*0x3910ae8*/ ParallelWriter(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> listData);
                /*0x3910ae8*/ void AddRangeNoResize(void* ptr, int count);
            }
        }

        struct NativeListDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* m_ListData;

            /*0x79ea944*/ void Dispose();
        }

        struct NativeListDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeListDispose Data;

            /*0x79ea98c*/ void Execute();
        }

        class NativeListDebugView<T>
        {
        }

        class NativeListExtensions
        {
            static /*0x3910ae8*/ bool Contains<T, U>(Unity.Collections.NativeList<T> list, U value);
        }

        struct NativeParallelHashMap<TKey, TValue> : System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap<TKey, TValue> m_HashMapData;

            /*0x3910ae8*/ NativeParallelHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x3814574*/ int Count();
            /*0x3814574*/ int get_Capacity();
            /*0x3815ed0*/ void set_Capacity(int value);
            /*0x3910ae8*/ bool TryAdd(TKey key, TValue item);
            /*0x3910ae8*/ void Add(TKey key, TValue item);
            /*0x3910ae8*/ bool Remove(TKey key);
            /*0x3910ae8*/ bool TryGetValue(TKey key, ref TValue item);
            /*0x3910ae8*/ bool ContainsKey(TKey key);
            /*0x3910ae8*/ TValue get_Item(TKey key);
            /*0x3910ae8*/ void set_Item(TKey key, TValue value);
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Dispose();
            /*0x3910ae8*/ Unity.Collections.NativeParallelHashMap.ParallelWriter<TKey, TValue> AsParallelWriter();
            /*0x3910ae8*/ Unity.Collections.NativeParallelHashMap.Enumerator<TKey, TValue> GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            struct ParallelWriter<TKey, TValue>
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<TKey, TValue> m_Writer;

                /*0x3910ae8*/ bool TryAdd(TKey key, TValue item);
            }

            struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataEnumerator m_Enumerator;

                /*0x38159dc*/ void Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void Reset();
                /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> get_Current();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeParallelHashMapDebuggerTypeProxy<TKey, TValue>
        {
        }

        struct NativeParallelMultiHashMapIterator<TKey>
        {
            /*0x0*/ TKey key;
            /*0x0*/ int NextEntryIndex;
            /*0x0*/ int EntryIndex;
        }

        struct NativeParallelMultiHashMap<TKey, TValue> : System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;

            /*0x3910ae8*/ NativeParallelMultiHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x3816044*/ void Initialize<U>(int capacity, ref U allocator);
            /*0x3910ae8*/ void Add(TKey key, TValue item);
            /*0x3910ae8*/ int Remove(TKey key);
            /*0x3910ae8*/ void Remove(Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
            /*0x3910ae8*/ bool TryGetFirstValue(TKey key, ref TValue item, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
            /*0x3814200*/ bool TryGetNextValue(ref TValue item, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Dispose();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NativeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>
        {
        }

        struct NativeQueue<T> : System.IDisposable
        {
            /*0x0*/ Unity.Collections.UnsafeQueue<T> m_Queue;

            /*0x3910ae8*/ NativeQueue(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x3813ffc*/ bool IsEmpty();
            /*0x3910ae8*/ T Peek();
            /*0x3910ae8*/ void Enqueue(T value);
            /*0x3910ae8*/ T Dequeue();
            /*0x38141c4*/ bool TryDequeue(ref T item);
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Dispose();
        }

        struct NativeQueueDispose
        {
            /*0x10*/ Unity.Collections.UnsafeQueue<int> m_QueueData;

            /*0x79ea990*/ void Dispose();
        }

        struct NativeQueueDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeQueueDispose Data;

            /*0x79ea9d8*/ void Execute();
        }

        struct NativeReferenceDispose
        {
            /*0x10*/ void* m_Data;
            /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            /*0x79ea9dc*/ void Dispose();
        }

        struct NativeReferenceDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeReferenceDispose Data;

            /*0x79eaa04*/ void Execute();
        }

        struct NativeRingQueueDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue<int> m_QueueData;

            /*0x79eaa2c*/ void Dispose();
        }

        struct NativeRingQueueDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeRingQueueDispose Data;

            /*0x79eaa74*/ void Execute();
        }

        class NativeSortExtension
        {
            static /*0x3910ae8*/ void Sort<T, U>(T* array, int length, U comp);
            static /*0x3910ae8*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(T* array, int length, U comp);
            static /*0x3910ae8*/ int BinarySearch<T, U>(T* ptr, int length, T value, U comp);
            static /*0x3910ae8*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(Unity.Collections.NativeArray<T> array);
            static /*0x3910ae8*/ int BinarySearch<T>(Unity.Collections.NativeArray<T> array, T value);
            static /*0x3910ae8*/ int BinarySearch<T, U>(Unity.Collections.NativeArray<T> array, T value, U comp);
            static /*0x3910ae8*/ void IntroSort<T, U>(void* array, int length, U comp);
            static /*0x3910ae8*/ void IntroSort_R<T, U>(void* array, int lo, int hi, int depth, U comp);
            static /*0x3910ae8*/ void InsertionSort<T, U>(void* array, int lo, int hi, U comp);
            static /*0x3910ae8*/ int Partition<T, U>(void* array, int lo, int hi, U comp);
            static /*0x3910ae8*/ void HeapSort<T, U>(void* array, int lo, int hi, U comp);
            static /*0x3910ae8*/ void Heapify<T, U>(void* array, int i, int n, int lo, U comp);
            static /*0x3910ae8*/ void Swap<T>(void* array, int lhs, int rhs);
            static /*0x3910ae8*/ void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp);

            struct DefaultComparer<T> : System.Collections.Generic.IComparer<T>
            {
                /*0x3910ae8*/ int Compare(T x, T y);
            }
        }

        struct SortJob<T, U>
        {
            /*0x0*/ T* Data;
            /*0x0*/ U Comp;
            /*0x0*/ int Length;

            /*0x3910ae8*/ Unity.Jobs.JobHandle Schedule(Unity.Jobs.JobHandle inputDeps);

            struct SegmentSort<T, U> : Unity.Jobs.IJobParallelFor
            {
                /*0x0*/ T* Data;
                /*0x0*/ U Comp;
                /*0x0*/ int Length;
                /*0x0*/ int SegmentWidth;

                /*0x3815ed0*/ void Execute(int index);
            }

            struct SegmentSortMerge<T, U> : Unity.Jobs.IJob
            {
                /*0x0*/ T* Data;
                /*0x0*/ U Comp;
                /*0x0*/ int Length;
                /*0x0*/ int SegmentWidth;

                /*0x38159dc*/ void Execute();
            }
        }

        struct NativeStream : System.IDisposable
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream m_Stream;

            /*0x79eaa78*/ bool get_IsCreated();
            /*0x79eaa88*/ void Dispose();
            /*0x79eaaa8*/ void AllocateForEach(int forEachCount);

            struct ConstructJobList : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeStream Container;
                /*0x30*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List;

                /*0x79eab90*/ void Execute();
            }

            struct ConstructJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeStream Container;
                /*0x30*/ Unity.Collections.NativeArray<int> Length;

                /*0x79eabac*/ void Execute();
            }
        }

        struct NativeStreamDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream m_StreamData;

            /*0x79eabb8*/ void Dispose();
        }

        struct NativeStreamDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeStreamDispose Data;

            /*0x79eabc8*/ void Execute();
        }

        struct NativeTextDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeText* m_TextData;

            /*0x79eabd8*/ void Dispose();
        }

        struct NativeTextDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeTextDispose Data;

            /*0x79eac84*/ void Execute();
        }

        enum ConversionError
        {
            None = 0,
            Overflow = 1,
            Encoding = 2,
            CodePoint = 3,
        }

        struct Unicode
        {
            static /*0x79eac8c*/ bool IsValidCodePoint(int codepoint);
            static /*0x79eac98*/ bool NotTrailer(byte b);
            static /*0x79eaca8*/ Unity.Collections.Unicode.Rune get_ReplacementCharacter();
            static /*0x79eacb0*/ Unity.Collections.ConversionError Utf8ToUcs(ref Unity.Collections.Unicode.Rune rune, byte* buffer, ref int index, int capacity);
            static /*0x79eae5c*/ Unity.Collections.ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Unity.Collections.Unicode.Rune rune);
            static /*0x79eaed8*/ Unity.Collections.ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, ref int utf16Length, int utf16Capacity);

            struct Rune
            {
                /*0x10*/ int value;

                /*0x79eaf64*/ bool Equals(object obj);
                /*0x79eafdc*/ int GetHashCode();
            }
        }

        struct UnsafeQueueBlockHeader
        {
            /*0x10*/ Unity.Collections.UnsafeQueueBlockHeader* m_NextBlock;
            /*0x18*/ int m_NumItems;
        }

        struct UnsafeQueueBlockPoolData
        {
            /*0x10*/ nint m_FirstBlock;
            /*0x18*/ int m_NumBlocks;
            /*0x1c*/ int m_MaxBlocks;
            /*0x20*/ int m_AllocLock;

            /*0x79eafe4*/ Unity.Collections.UnsafeQueueBlockHeader* AllocateBlock();
            /*0x79eb0cc*/ void FreeBlock(Unity.Collections.UnsafeQueueBlockHeader* block);
        }

        class UnsafeQueueBlockPool
        {
            static /*0x0*/ Unity.Burst.SharedStatic<nint> Data;

            static /*0x79eb47c*/ UnsafeQueueBlockPool();
            static /*0x79eb1d0*/ Unity.Collections.UnsafeQueueBlockPoolData* GetQueueBlockPool();
            static /*0x79eb2ec*/ void AppDomainOnDomainUnload();
            static /*0x79eb37c*/ void OnDomainUnload(object sender, System.EventArgs e);
        }

        struct UnsafeQueueData
        {
            /*0x10*/ nint m_FirstBlock;
            /*0x18*/ nint m_LastBlock;
            /*0x20*/ int m_MaxItems;
            /*0x24*/ int m_CurrentRead;
            /*0x28*/ byte* m_CurrentWriteBlockTLS;

            static /*0x3910ae8*/ Unity.Collections.UnsafeQueueBlockHeader* AllocateWriteBlockMT<T>(Unity.Collections.UnsafeQueueData* data, Unity.Collections.UnsafeQueueBlockPoolData* pool, int threadIndex);
            static /*0x3910ae8*/ void AllocateQueue<T>(Unity.Collections.AllocatorManager.AllocatorHandle label, ref Unity.Collections.UnsafeQueueData* outBuf);
            static /*0x79eb518*/ void DeallocateQueue(Unity.Collections.UnsafeQueueData* data, Unity.Collections.UnsafeQueueBlockPoolData* pool, Unity.Collections.AllocatorManager.AllocatorHandle allocation);
            /*0x79eb4f8*/ Unity.Collections.UnsafeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex);
            /*0x79eb508*/ void SetCurrentWriteBlockTLS(int threadIndex, Unity.Collections.UnsafeQueueBlockHeader* currentWriteBlock);
        }

        struct UnsafeQueue<T> : System.IDisposable
        {
            /*0x0*/ Unity.Collections.UnsafeQueueData* m_Buffer;
            /*0x0*/ Unity.Collections.UnsafeQueueBlockPoolData* m_QueuePool;
            /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            static /*0x3910ae8*/ Unity.Collections.UnsafeQueue<T> Alloc(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x3910ae8*/ void Free(Unity.Collections.UnsafeQueue<T> data);
            /*0x3910ae8*/ UnsafeQueue(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x3813ffc*/ bool IsEmpty();
            /*0x3910ae8*/ T Peek();
            /*0x3910ae8*/ void Enqueue(T value);
            /*0x3910ae8*/ T Dequeue();
            /*0x38141c4*/ bool TryDequeue(ref T item);
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Dispose();
        }

        struct UnsafeQueueDispose
        {
            /*0x10*/ Unity.Collections.UnsafeQueueData* m_Buffer;
            /*0x18*/ Unity.Collections.UnsafeQueueBlockPoolData* m_QueuePool;
            /*0x20*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            /*0x79eb5a4*/ void Dispose();
        }

        struct UnsafeQueueDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.UnsafeQueueDispose Data;

            /*0x79eb5b4*/ void Execute();
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class NativeListUnsafeUtility
                {
                    static /*0x3910ae8*/ T* GetUnsafePtr<T>(Unity.Collections.NativeList<T> list);
                    static /*0x3910ae8*/ T* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeList<T> list);
                }

                struct UnsafeAtomicCounter32
                {
                    /*0x10*/ int* Counter;

                    /*0x79eb5c4*/ UnsafeAtomicCounter32(void* ptr);
                    /*0x79eb5cc*/ int Add(int value);
                }

                struct UnsafeBitArray : System.IDisposable
                {
                    /*0x10*/ ulong* Ptr;
                    /*0x18*/ int Length;
                    /*0x1c*/ int Capacity;
                    /*0x20*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    static /*0x79ea844*/ void Free(Unity.Collections.LowLevel.Unsafe.UnsafeBitArray* data, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x79eb6b4*/ bool get_IsCreated();
                    /*0x79eb61c*/ void Dispose();
                }

                class UnsafeBitArrayDebugView
                {
                }

                struct HashMapHelper<TKey>
                {
                    /*0x0*/ byte* Ptr;
                    /*0x0*/ TKey* Keys;
                    /*0x0*/ int* Next;
                    /*0x0*/ int* Buckets;
                    /*0x0*/ int Count;
                    /*0x0*/ int Capacity;
                    /*0x0*/ int Log2MinGrowth;
                    /*0x0*/ int BucketCapacity;
                    /*0x0*/ int AllocatedIndex;
                    /*0x0*/ int FirstFreeIdx;
                    /*0x0*/ int SizeOfTValue;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    static /*0x382d234*/ int GetBucketSize(int capacity);
                    static /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.HashMapHelper<TKey> Alloc(int capacity, int sizeOfValueT, int minGrowth, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x3910ae8*/ void Free(Unity.Collections.LowLevel.Unsafe.HashMapHelper<TKey> data);
                    static /*0x3910ae8*/ int CalculateDataSize(int capacity, int bucketCapacity, int sizeOfTValue, ref int outKeyOffset, ref int outNextOffset, ref int outBucketOffset);
                    /*0x38145a0*/ int CalcCapacityCeilPow2(int capacity);
                    /*0x3813ffc*/ bool get_IsCreated();
                    /*0x38159dc*/ void Clear();
                    /*0x3910ae8*/ void Init(int capacity, int sizeOfValueT, int minGrowth, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x38159dc*/ void Dispose();
                    /*0x3815ed0*/ void Resize(int newCapacity);
                    /*0x3815fb8*/ void ResizeExact(int newCapacity, int newBucketCapacity);
                    /*0x381467c*/ int GetBucket(ref TKey key);
                    /*0x381467c*/ int TryAdd(ref TKey key);
                    /*0x3910ae8*/ int Find(TKey key);
                    /*0x3910ae8*/ bool TryGetValue<TValue>(TKey key, ref TValue item);
                }

                struct UnsafeHashMap<TKey, TValue> : System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey, TValue>>, System.Collections.IEnumerable
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.HashMapHelper<TKey> m_Data;

                    /*0x38159dc*/ void Dispose();
                    /*0x3813ffc*/ bool get_IsCreated();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Collections.KVPair<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class UnsafeHashMapDebuggerTypeProxy<TKey, TValue>
                {
                }

                struct UnsafeDisposeJob : Unity.Jobs.IJob
                {
                    /*0x10*/ void* Ptr;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    /*0x79eb6c4*/ void Execute();
                }

                struct UntypedUnsafeList
                {
                    /*0x10*/ void* Ptr;
                    /*0x18*/ int m_length;
                    /*0x1c*/ int m_capacity;
                    /*0x20*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x24*/ int padding;
                }

                struct UnsafeList<T> : System.IDisposable, Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    /*0x0*/ T* Ptr;
                    /*0x0*/ int m_length;
                    /*0x0*/ int m_capacity;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x0*/ int padding;

                    static /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> Create<U>(int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x3910ae8*/ void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> listData);
                    /*0x3910ae8*/ UnsafeList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x3814574*/ int get_Length();
                    /*0x3814574*/ int get_Capacity();
                    /*0x3815ed0*/ void set_Capacity(int value);
                    /*0x3910ae8*/ T get_Item(int index);
                    /*0x3910ae8*/ void set_Item(int index, T value);
                    /*0x3814964*/ ref T ElementAt(int index);
                    /*0x3813ffc*/ bool get_IsCreated();
                    /*0x38159dc*/ void Dispose();
                    /*0x38159dc*/ void Clear();
                    /*0x3815fb8*/ void Resize(int length, Unity.Collections.NativeArrayOptions options);
                    /*0x381678c*/ void ResizeExact<U>(ref U allocator, int newCapacity);
                    /*0x381678c*/ void SetCapacity<U>(ref U allocator, int capacity);
                    /*0x3815ed0*/ void SetCapacity(int capacity);
                    /*0x3816710*/ void Add(ref T value);
                    /*0x3910ae8*/ void AddRange(void* ptr, int count);
                    /*0x3815ed0*/ void RemoveAtSwapBack(int index);
                    /*0x3815ed0*/ void RemoveAt(int index);
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                }

                class UnsafeListTDebugView<T>
                {
                }

                struct UnsafeParallelHashMapData
                {
                    /*0x10*/ byte* values;
                    /*0x18*/ byte* keys;
                    /*0x20*/ byte* next;
                    /*0x28*/ byte* buckets;
                    /*0x30*/ int keyCapacity;
                    /*0x34*/ int bucketCapacityMask;
                    /*0x38*/ int allocatedIndexLength;

                    static /*0x79eb72c*/ int GetBucketSize(int capacity);
                    static /*0x79eb734*/ int GrowCapacity(int capacity);
                    static /*0x3910ae8*/ void AllocateHashMap<TKey, TValue>(int length, int bucketLength, Unity.Collections.AllocatorManager.AllocatorHandle label, ref Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* outBuf);
                    static /*0x3910ae8*/ void ReallocateHashMap<TKey, TValue>(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, Unity.Collections.AllocatorManager.AllocatorHandle label);
                    static /*0x79eb744*/ void DeallocateHashMap(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x3910ae8*/ int CalculateDataSize<TKey, TValue>(int length, int bucketLength, ref int keyOffset, ref int nextOffset, ref int bucketOffset);
                    static /*0x79eb7c4*/ int GetCount(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data);
                    static /*0x79eb85c*/ bool MoveNextSearch(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, ref int index);
                    static /*0x79eb8d4*/ bool MoveNext(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, ref int index);
                    /*0x79eb724*/ int* get_firstFreeTLS();
                }

                struct UnsafeParallelHashMapDataDispose
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

                    /*0x79eb914*/ void Dispose();
                }

                struct UnsafeParallelHashMapDataDisposeJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapDataDispose Data;

                    /*0x79eb924*/ void Execute();
                }

                struct UnsafeParallelHashMapBase<TKey, TValue>
                {
                    static /*0x3910ae8*/ void Clear(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data);
                    static /*0x3910ae8*/ int AllocEntry(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, int threadIndex);
                    static /*0x3910ae8*/ void FreeEntry(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, int idx, int threadIndex);
                    static /*0x3910ae8*/ bool TryAddAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex);
                    static /*0x3910ae8*/ bool TryAdd(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, Unity.Collections.AllocatorManager.AllocatorHandle allocation);
                    static /*0x3910ae8*/ int Remove(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap);
                    static /*0x3910ae8*/ void Remove(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
                    static /*0x3910ae8*/ bool TryGetFirstValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, TKey key, ref TValue item, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
                    static /*0x3910ae8*/ bool TryGetNextValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, ref TValue item, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
                    static /*0x3910ae8*/ bool SetValue(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it, ref TValue item);
                }

                struct KeyValue<TKey, TValue>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
                    /*0x0*/ int m_Index;
                    /*0x0*/ int m_Next;

                    /*0x3910ae8*/ TKey get_Key();
                    /*0x38148bc*/ ref TValue get_Value();
                }

                struct UnsafeParallelHashMapDataEnumerator
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
                    /*0x18*/ int m_Index;
                    /*0x1c*/ int m_BucketIndex;
                    /*0x20*/ int m_NextIndex;

                    /*0x79eb934*/ UnsafeParallelHashMapDataEnumerator(Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* data);
                    /*0x79eb94c*/ bool MoveNext();
                    /*0x79eb9a0*/ void Reset();
                    /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> GetCurrent<TKey, TValue>();
                }

                struct UnsafeParallelHashMap<TKey, TValue> : System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

                    /*0x3910ae8*/ UnsafeParallelHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x3813ffc*/ bool get_IsCreated();
                    /*0x3814574*/ int Count();
                    /*0x3814574*/ int get_Capacity();
                    /*0x3815ed0*/ void set_Capacity(int value);
                    /*0x38159dc*/ void Clear();
                    /*0x3910ae8*/ bool Remove(TKey key);
                    /*0x3910ae8*/ bool TryGetValue(TKey key, ref TValue item);
                    /*0x3910ae8*/ bool ContainsKey(TKey key);
                    /*0x3910ae8*/ void set_Item(TKey key, TValue value);
                    /*0x38159dc*/ void Dispose();
                    /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMap.ParallelWriter<TKey, TValue> AsParallelWriter();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    struct ParallelWriter<TKey, TValue>
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
                        /*0x0*/ int m_ThreadIndex;

                        /*0x3910ae8*/ bool TryAdd(TKey key, TValue item);
                    }
                }

                struct UnsafeParallelHashMapDisposeJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* Data;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    /*0x79eb9b4*/ void Execute();
                }

                class UnsafeParallelHashMapDebuggerTypeProxy<TKey, TValue>
                {
                }

                struct UnsafeParallelMultiHashMap<TKey, TValue> : System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeParallelHashMapData* m_Buffer;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

                    /*0x3910ae8*/ UnsafeParallelMultiHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x38159dc*/ void Clear();
                    /*0x3910ae8*/ void Add(TKey key, TValue item);
                    /*0x3910ae8*/ int Remove(TKey key);
                    /*0x3910ae8*/ void Remove(Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
                    /*0x3910ae8*/ bool TryGetFirstValue(TKey key, ref TValue item, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
                    /*0x3814200*/ bool TryGetNextValue(ref TValue item, ref Unity.Collections.NativeParallelMultiHashMapIterator<TKey> it);
                    /*0x3813ffc*/ bool get_IsCreated();
                    /*0x38159dc*/ void Dispose();
                    /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
                    /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                class UnsafeParallelMultiHashMapDebuggerTypeProxy<TKey, TValue>
                {
                }

                struct UnsafeRingQueue<T> : System.IDisposable
                {
                    /*0x0*/ T* Ptr;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x0*/ int m_Capacity;
                    /*0x0*/ int m_Filled;
                    /*0x0*/ int m_Write;
                    /*0x0*/ int m_Read;

                    static /*0x3910ae8*/ void Free(Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue<T> data);
                    /*0x3813ffc*/ bool get_IsCreated();
                    /*0x38159dc*/ void Dispose();
                }

                class UnsafeRingQueueDebugView<T>
                {
                }

                struct UnsafeStreamBlock
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Next;
                    /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock.<Data> Data;

                    struct <Data>e__FixedBuffer
                    {
                        /*0x10*/ byte FixedElementField;
                    }
                }

                struct UnsafeStreamRange
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Block;
                    /*0x18*/ int OffsetInFirstBlock;
                    /*0x1c*/ int ElementCount;
                    /*0x20*/ int LastOffset;
                    /*0x24*/ int NumberOfBlocks;
                }

                struct UnsafeStreamBlockData
                {
                    /*0x10*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock** Blocks;
                    /*0x20*/ int BlockCount;
                    /*0x28*/ Unity.Collections.AllocatorManager.Block Ranges;
                    /*0x48*/ int RangeCount;

                    /*0x79eb9c4*/ void Free(Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* oldBlock);
                }

                struct UnsafeStream : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.AllocatorManager.Block m_BlockData;

                    /*0x79eaaac*/ void AllocateForEach(int forEachCount);
                    /*0x79eb9e4*/ bool get_IsCreated();
                    /*0x79eb9f4*/ void Deallocate();
                    /*0x79eaa98*/ void Dispose();

                    struct DisposeJob : Unity.Jobs.IJob
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;

                        /*0x79eba94*/ void Execute();
                    }

                    struct ConstructJobList : Unity.Jobs.IJob
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;
                        /*0x30*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List;

                        /*0x79eba98*/ void Execute();
                    }

                    struct ConstructJob : Unity.Jobs.IJob
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;
                        /*0x30*/ Unity.Collections.NativeArray<int> Length;

                        /*0x79ebab4*/ void Execute();
                    }
                }

                class UnsafeTextExtensions
                {
                    static /*0x79ebac0*/ ref Unity.Collections.LowLevel.Unsafe.UnsafeList<byte> AsUnsafeListOfBytes(ref Unity.Collections.LowLevel.Unsafe.UnsafeText text);
                    static /*0x79ebafc*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<byte> AsUnsafeListOfBytesRO(Unity.Collections.LowLevel.Unsafe.UnsafeText text);
                }

                struct UnsafeText : System.IDisposable, Unity.Collections.IUTF8Bytes, Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList m_UntypedListData;

                    static /*0x79eabe0*/ void Free(Unity.Collections.LowLevel.Unsafe.UnsafeText* data);
                    /*0x79ebb48*/ bool get_IsCreated();
                    /*0x79ebbac*/ void Dispose();
                    /*0x79ebc14*/ byte* GetUnsafePtr();
                    /*0x79ebc1c*/ int get_Length();
                    /*0x79ebc7c*/ string ToString();
                }
            }
        }
    }
}

class __JobReflectionRegistrationOutput__1652832624114795843
{
    static /*0x79ebd34*/ void CreateJobReflectionData();
    static /*0x79ebfec*/ void EarlyInit();
}

class $BurstDirectCallInitializer
{
    static /*0x79ebff0*/ void Initialize();
}
