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
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x534220*/ IsUnmanagedAttribute();
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x1173820*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Unity
{
    namespace Collections
    {
        class AllocatorManager
        {
            static int kErrorNone = 0;
            static int kErrorBufferOverflow = -1;
            static ushort FirstUserIndex = 64;
            static /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Invalid;
            static /*0x4*/ Unity.Collections.AllocatorManager.AllocatorHandle None;
            static /*0x8*/ Unity.Collections.AllocatorManager.AllocatorHandle Temp;
            static /*0xc*/ Unity.Collections.AllocatorManager.AllocatorHandle TempJob;
            static /*0x10*/ Unity.Collections.AllocatorManager.AllocatorHandle Persistent;
            static /*0x14*/ Unity.Collections.AllocatorManager.AllocatorHandle AudioKernel;

            static /*0x115c260*/ AllocatorManager();
            static /*0x2a5510*/ Unity.Collections.AllocatorManager.Block AllocateBlock<T>(ref T t, int sizeOf, int alignOf, int items);
            static /*0x2a5510*/ Unity.Collections.AllocatorManager.Block AllocateBlock<T, U>(ref T t, U u, int items);
            static /*0x2a5510*/ void* Allocate<T>(ref T t, int sizeOf, int alignOf, int items);
            static /*0x2a5510*/ U* Allocate<T, U>(ref T t, U u, int items);
            static /*0x2a5510*/ void* AllocateStruct<T, U>(ref T t, U u, int items);
            static /*0x177670*/ void FreeBlock<T>(ref T t, ref Unity.Collections.AllocatorManager.Block block);
            static /*0x2a5510*/ void Free<T>(ref T t, void* pointer, int sizeOf, int alignOf, int items);
            static /*0x2a5510*/ void Free<T, U>(ref T t, U* pointer, int items);
            static /*0x115b6c0*/ void* Allocate(Unity.Collections.AllocatorManager.AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items);
            static /*0x2a5510*/ T* Allocate<T>(Unity.Collections.AllocatorManager.AllocatorHandle handle, int items);
            static /*0x115b820*/ void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, void* pointer, int itemSizeInBytes, int alignmentInBytes, int items);
            static /*0x115b8b0*/ void Free(Unity.Collections.AllocatorManager.AllocatorHandle handle, void* pointer);
            static /*0x2a5510*/ void Free<T>(Unity.Collections.AllocatorManager.AllocatorHandle handle, T* pointer, int items);
            static /*0x115b750*/ void CheckDelegate(ref bool useDelegate);
            static /*0x115c220*/ bool UseDelegate();
            static /*0x115c350*/ int allocate_block(ref Unity.Collections.AllocatorManager.Block block);
            static /*0x115c3e0*/ void forward_mono_allocate_block(ref Unity.Collections.AllocatorManager.Block block, ref int error);
            static /*0x115bd20*/ Unity.Collections.Allocator LegacyOf(Unity.Collections.AllocatorManager.AllocatorHandle handle);
            static /*0x115bed0*/ int TryLegacy(ref Unity.Collections.AllocatorManager.Block block);
            static /*0x115c060*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
            static /*0x32d010*/ void Initialize();
            static /*0x115b9a0*/ void Install(Unity.Collections.AllocatorManager.AllocatorHandle handle, nint allocatorState, Unity.Burst.FunctionPointer<Unity.Collections.AllocatorManager.TryFunction> functionPointer, Unity.Collections.AllocatorManager.TryFunction function);
            static /*0x115bc40*/ void Install(Unity.Collections.AllocatorManager.AllocatorHandle handle, nint allocatorState, Unity.Collections.AllocatorManager.TryFunction function);
            static /*0x115bd30*/ Unity.Collections.AllocatorManager.AllocatorHandle Register(nint allocatorState, Unity.Burst.FunctionPointer<Unity.Collections.AllocatorManager.TryFunction> functionPointer);
            static /*0x177be0*/ void Register<T>(ref T t);
            static /*0x177be0*/ void UnmanagedUnregister<T>(ref T t);
            static /*0x177be0*/ void Unregister<T>(ref T t);
            static /*0x2a5510*/ ref T CreateAllocator<T>(Unity.Collections.AllocatorManager.AllocatorHandle backingAllocator);
            static /*0x2a5510*/ void DestroyAllocator<T>(ref T t, Unity.Collections.AllocatorManager.AllocatorHandle backingAllocator);
            static /*0x32d010*/ void Shutdown();
            static /*0x115bd10*/ bool IsCustomAllocator(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x115b760*/ void CheckFailedToAllocate(int error);
            static /*0x115b7c0*/ void CheckFailedToFree(int error);
            static /*0x32d010*/ void CheckValid(Unity.Collections.AllocatorManager.AllocatorHandle handle);
            static /*0x115b960*/ void Initialize$StackAllocator_Try_00000980$BurstDirectCall();
            static /*0x115b920*/ void Initialize$SlabAllocator_Try_0000098E$BurstDirectCall();

            class TryFunction : System.MulticastDelegate
            {
                /*0x776780*/ TryFunction(object object, nint method);
                /*0x722200*/ int Invoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                /*0x1172b70*/ System.IAsyncResult BeginInvoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block, System.AsyncCallback callback, object object);
                /*0x1172c10*/ int EndInvoke(ref Unity.Collections.AllocatorManager.Block block, System.IAsyncResult result);
            }

            struct AllocatorHandle : Unity.Collections.AllocatorManager.IAllocator, System.IDisposable
            {
                /*0x10*/ ushort Index;
                /*0x12*/ ushort Version;

                static /*0x115b6a0*/ Unity.Collections.AllocatorManager.AllocatorHandle op_Implicit(Unity.Collections.Allocator a);
                static /*0x115b420*/ void CheckAllocatedSuccessfully(int error);
                /*0x115b600*/ ref Unity.Collections.AllocatorManager.TableEntry get_TableEntry();
                /*0x115b550*/ bool get_IsInstalled();
                /*0x32d010*/ void IncrementVersion();
                /*0x32d010*/ void Rewind();
                /*0x115b4c0*/ void Install(Unity.Collections.AllocatorManager.TableEntry tableEntry);
                /*0x6bba60*/ int get_Value();
                int TryAllocateBlock<T>(ref Unity.Collections.AllocatorManager.Block block, int items);
                /*0x2a5510*/ Unity.Collections.AllocatorManager.Block AllocateBlock<T>(int items);
                /*0x388e90*/ Unity.Collections.AllocatorManager.TryFunction get_Function();
                /*0x115b4e0*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
                /*0x6bba50*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
                /*0x6bbd40*/ void set_Handle(Unity.Collections.AllocatorManager.AllocatorHandle value);
                /*0x115b690*/ Unity.Collections.Allocator get_ToAllocator();
                /*0x115b540*/ bool get_IsCustomAllocator();
                /*0x32d010*/ void Dispose();
            }

            struct BlockHandle
            {
                /*0x10*/ ushort Value;
            }

            struct Range : System.IDisposable
            {
                /*0x10*/ nint Pointer;
                /*0x18*/ int Items;
                /*0x1c*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                /*0x1171f40*/ void Dispose();
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

                /*0x115e1b0*/ long get_Bytes();
                /*0x115e1a0*/ long get_AllocatedBytes();
                /*0x115e190*/ int get_Alignment();
                /*0x115e1c0*/ void set_Alignment(int value);
                /*0x115e140*/ void Dispose();
                /*0x115df50*/ int TryAllocate();
                /*0x115e140*/ int TryFree();
                /*0x115df50*/ void Allocate();
                /*0x115e140*/ void Free();
                /*0x115dfa0*/ void CheckFailedToAllocate(int error);
                /*0x115e070*/ void CheckFailedToFree(int error);
            }

            interface IAllocator : System.IDisposable
            {
                /*0x1803b0*/ Unity.Collections.AllocatorManager.TryFunction get_Function();
                /*0x17b580*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
                /*0x2a5510*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
                /*0x2a5510*/ void set_Handle(Unity.Collections.AllocatorManager.AllocatorHandle value);
                /*0x180980*/ Unity.Collections.Allocator get_ToAllocator();
                /*0x17cb40*/ bool get_IsCustomAllocator();
            }

            struct StackAllocator : Unity.Collections.AllocatorManager.IAllocator, System.IDisposable
            {
                /*0x10*/ Unity.Collections.AllocatorManager.AllocatorHandle m_handle;
                /*0x18*/ Unity.Collections.AllocatorManager.Block m_storage;
                /*0x38*/ long m_top;

                static /*0x1172710*/ int Try(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                static /*0x11726e0*/ int Try$BurstManaged(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                /*0x6bba50*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
                /*0x6bbd40*/ void set_Handle(Unity.Collections.AllocatorManager.AllocatorHandle value);
                /*0x115b690*/ Unity.Collections.Allocator get_ToAllocator();
                /*0x115b540*/ bool get_IsCustomAllocator();
                /*0x11726c0*/ void Initialize(Unity.Collections.AllocatorManager.Block storage);
                /*0x1172940*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
                /*0x1172a30*/ Unity.Collections.AllocatorManager.TryFunction get_Function();
                /*0x32d010*/ void Dispose();

                class Try_00000980$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x776780*/ Try_00000980$PostfixBurstDelegate(object , nint );
                    /*0x722200*/ int Invoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                    /*0x1173190*/ System.IAsyncResult BeginInvoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block, System.AsyncCallback , object );
                    /*0xf338c0*/ int EndInvoke(System.IAsyncResult );
                }

                class Try_00000980$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;
                    static /*0x8*/ nint DeferredCompilation;

                    static /*0x1172c40*/ Try_00000980$BurstDirectCall();
                    static /*0x1172cf0*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x1172e20*/ nint GetFunctionPointer();
                    static /*0x1172c40*/ void Constructor();
                    static /*0x32d010*/ void Initialize();
                    static /*0x1172f90*/ int Invoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                }
            }

            struct SlabAllocator : Unity.Collections.AllocatorManager.IAllocator, System.IDisposable
            {
                /*0x10*/ Unity.Collections.AllocatorManager.AllocatorHandle m_handle;
                /*0x18*/ Unity.Collections.AllocatorManager.Block Storage;
                /*0x38*/ int Log2SlabSizeInBytes;
                /*0x3c*/ Unity.Collections.FixedList4096Bytes<int> Occupied;
                /*0x1040*/ long budgetInBytes;
                /*0x1048*/ long allocatedBytes;

                static /*0x11720f0*/ int Try(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                static /*0x11720c0*/ int Try$BurstManaged(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                /*0x6bba50*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
                /*0x6bbd40*/ void set_Handle(Unity.Collections.AllocatorManager.AllocatorHandle value);
                /*0x115b690*/ Unity.Collections.Allocator get_ToAllocator();
                /*0x115b540*/ bool get_IsCustomAllocator();
                /*0x1172550*/ long get_BudgetInBytes();
                /*0x1172540*/ long get_AllocatedBytes();
                /*0x1172640*/ int get_SlabSizeInBytes();
                /*0x1172660*/ void set_SlabSizeInBytes(int value);
                /*0x1172650*/ int get_Slabs();
                /*0x1171fc0*/ void Initialize(Unity.Collections.AllocatorManager.Block storage, int slabSizeInBytes, long budget);
                /*0x1172320*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
                /*0x1172560*/ Unity.Collections.AllocatorManager.TryFunction get_Function();
                /*0x32d010*/ void Dispose();

                class Try_0000098E$PostfixBurstDelegate : System.MulticastDelegate
                {
                    /*0x776780*/ Try_0000098E$PostfixBurstDelegate(object , nint );
                    /*0x722200*/ int Invoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                    /*0x1173780*/ System.IAsyncResult BeginInvoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block, System.AsyncCallback , object );
                    /*0xf338c0*/ int EndInvoke(System.IAsyncResult );
                }

                class Try_0000098E$BurstDirectCall
                {
                    static /*0x0*/ nint Pointer;
                    static /*0x8*/ nint DeferredCompilation;

                    static /*0x1173230*/ Try_0000098E$BurstDirectCall();
                    static /*0x11732e0*/ void GetFunctionPointerDiscard(ref nint );
                    static /*0x1173410*/ nint GetFunctionPointer();
                    static /*0x1173230*/ void Constructor();
                    static /*0x32d010*/ void Initialize();
                    static /*0x1173580*/ int Invoke(nint allocatorState, ref Unity.Collections.AllocatorManager.Block block);
                }
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

                /*0x180980*/ int get_Length();
                /*0x17aa40*/ void set_Length(int value);
                /*0x184ab0*/ ref T ElementAt(int index);
            }

            class SharedStatics
            {
                /*0x32f970*/ SharedStatics();

                class IsInstalled
                {
                    static /*0x0*/ Unity.Burst.SharedStatic<Unity.Collections.Long1024> Ref;

                    static /*0x1171c70*/ IsInstalled();
                    /*0x32f970*/ IsInstalled();
                }

                class TableEntry
                {
                    static /*0x0*/ Unity.Burst.SharedStatic<Unity.Collections.AllocatorManager.Array32768<Unity.Collections.AllocatorManager.TableEntry>> Ref;

                    static /*0x1172b10*/ TableEntry();
                    /*0x32f970*/ TableEntry();
                }
            }

            class Managed
            {
                static int kMaxNumCustomAllocator = 32768;
                static /*0x0*/ Unity.Collections.AllocatorManager.TryFunction[] TryFunctionDelegates;

                static /*0x1171ed0*/ Managed();
                static /*0x1171d10*/ void RegisterDelegate(int index, Unity.Collections.AllocatorManager.TryFunction function);
                static /*0x1171df0*/ void UnregisterDelegate(int index);
            }
        }

        struct AllocatorHelper<T> : System.IDisposable
        {
            /*0x0*/ T* m_allocator;
            /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_backingAllocator;

            /*0x2a5510*/ AllocatorHelper(Unity.Collections.AllocatorManager.AllocatorHandle backingAllocator);
            /*0x1803b0*/ ref T get_Allocator();
            /*0x180fc0*/ void Dispose();
        }

        class CreatePropertyAttribute : System.Attribute
        {
            /*0x534220*/ CreatePropertyAttribute();
        }

        struct Bitwise
        {
            static /*0x115cc80*/ int AlignDown(int value, int alignPow2);
            static /*0x115cc90*/ int AlignUp(int value, int alignPow2);
            static /*0xe31d50*/ int FromBool(bool value);
            static /*0x115ccb0*/ uint ExtractBits(uint input, int pos, uint mask);
            static /*0x115dd90*/ uint ReplaceBits(uint input, int pos, uint mask, uint value);
            static /*0x115ddb0*/ uint SetBits(uint input, int pos, uint mask, bool value);
            static /*0x115cca0*/ ulong ExtractBits(ulong input, int pos, ulong mask);
            static /*0x115dd60*/ ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value);
            static /*0x115dde0*/ ulong SetBits(ulong input, int pos, ulong mask, bool value);
            static /*0x115de10*/ int lzcnt(byte value);
            static /*0x115deb0*/ int tzcnt(byte value);
            static /*0x115de60*/ int lzcnt(ushort value);
            static /*0x115df00*/ int tzcnt(ushort value);
            static /*0x115cfd0*/ int FindUlong(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115ce20*/ int FindUint(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115d430*/ int FindUshort(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115ccc0*/ int FindByte(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115d1b0*/ int FindUpto14bits(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115d2e0*/ int FindUpto6bits(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115d580*/ int FindWithBeginEnd(ulong* ptr, int beginBit, int endBit, int numBits);
            static /*0x115dd40*/ int Find(ulong* ptr, int pos, int count, int numBits);
        }

        struct BitField32
        {
            /*0x10*/ uint Value;

            static /*0x115c5c0*/ void CheckArgs(int pos, int numBits);
            /*0x6bbd40*/ BitField32(uint initialValue);
            /*0xe24e80*/ void Clear();
            /*0x115c7a0*/ void SetBits(int pos, bool value);
            /*0x115c7d0*/ void SetBits(int pos, bool value, int numBits);
            /*0x115c770*/ uint GetBits(int pos, int numBits);
            /*0x115c790*/ bool IsSet(int pos);
            /*0x115c870*/ bool TestNone(int pos, int numBits);
            /*0x115c840*/ bool TestAny(int pos, int numBits);
            /*0x115c810*/ bool TestAll(int pos, int numBits);
            /*0x115c690*/ int CountBits();
            /*0x115c6d0*/ int CountLeadingZeros();
            /*0x115c720*/ int CountTrailingZeros();
        }

        class BitField32DebugView
        {
            /*0x10*/ Unity.Collections.BitField32 BitField;

            /*0x115c500*/ BitField32DebugView(Unity.Collections.BitField32 bitfield);
            /*0x115c530*/ bool[] get_Bits();
        }

        struct BitField64
        {
            /*0x10*/ ulong Value;

            static /*0x115c930*/ void CheckArgs(int pos, int numBits);
            /*0x9e29e0*/ BitField64(ulong initialValue);
            /*0xe24e90*/ void Clear();
            /*0x115cb80*/ void SetBits(int pos, bool value);
            /*0x115cbb0*/ void SetBits(int pos, bool value, int numBits);
            /*0x115cb30*/ ulong GetBits(int pos, int numBits);
            /*0x115cb60*/ bool IsSet(int pos);
            /*0x115cc50*/ bool TestNone(int pos, int numBits);
            /*0x115cc20*/ bool TestAny(int pos, int numBits);
            /*0x115cbf0*/ bool TestAll(int pos, int numBits);
            /*0x115ca00*/ int CountBits();
            /*0x115ca60*/ int CountLeadingZeros();
            /*0x115cac0*/ int CountTrailingZeros();
        }

        class BitField64DebugView
        {
            /*0x10*/ Unity.Collections.BitField64 Data;

            /*0x1152e30*/ BitField64DebugView(Unity.Collections.BitField64 data);
            /*0x115c8a0*/ bool[] get_Bits();
        }

        class BurstCompatibleAttribute : System.Attribute
        {
            /*0x10*/ System.Type[] <GenericTypeArguments>k__BackingField;
            /*0x18*/ string RequiredUnityDefine;
            /*0x20*/ Unity.Collections.BurstCompatibleAttribute.BurstCompatibleCompileTarget CompileTarget;

            /*0x534220*/ BurstCompatibleAttribute();
            /*0x73d3e0*/ System.Type[] get_GenericTypeArguments();
            /*0x9f12f0*/ void set_GenericTypeArguments(System.Type[] value);

            enum BurstCompatibleCompileTarget
            {
                Player = 0,
                Editor = 1,
                PlayerAndEditor = 2,
            }
        }

        class NotBurstCompatibleAttribute : System.Attribute
        {
            /*0x534220*/ NotBurstCompatibleAttribute();
        }

        interface INativeDisposable : System.IDisposable
        {
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
        }

        class CollectionHelper
        {
            static int CacheLineSize = 64;

            static /*0x115e250*/ void CheckAllocator(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x115e770*/ int Log2Floor(int value);
            static /*0x115e730*/ int Log2Ceil(int value);
            static /*0x115e210*/ int Align(int size, int alignmentPowerOfTwo);
            static /*0x115e230*/ ulong Align(ulong size, ulong alignmentPowerOfTwo);
            static /*0x115e710*/ bool IsAligned(void* p, int alignmentPowerOfTwo);
            static /*0x115e710*/ bool IsAligned(ulong offset, int alignmentPowerOfTwo);
            static /*0x115e720*/ bool IsPowerOfTwo(int value);
            static /*0x115e6e0*/ uint Hash(void* ptr, int bytes);
            static /*0x115e7e0*/ void WriteLayout(System.Type type);
            static /*0x115e7c0*/ bool ShouldDeallocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x621c90*/ int AssumePositive(int value);
            static /*0x180ff0*/ void CheckIsUnmanaged<T>();
            static /*0x115e580*/ void CheckIntPositivePowerOfTwo(int value);
            static /*0x115e630*/ void CheckUlongPositivePowerOfTwo(ulong value);
            static /*0x115e440*/ void CheckIndexInRange(int index, int length);
            static /*0x115e300*/ void CheckCapacityInRange(int capacity, int length);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> CreateNativeArray<T, U>(int length, ref U allocator, Unity.Collections.NativeArrayOptions options);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> CreateNativeArray<T>(int length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> CreateNativeArray<T>(Unity.Collections.NativeArray<T> array, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> CreateNativeArray<T>(T[] array, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> CreateNativeArray<T, U>(T[] array, ref U allocator);
            static /*0x2a5510*/ Unity.Collections.NativeMultiHashMap<TKey, TValue> CreateNativeMultiHashMap<TKey, TValue, U>(int length, ref U allocator);

            struct LongDoubleUnion
            {
                /*0x10*/ long longValue;
                /*0x10*/ double doubleValue;
            }
        }

        struct Long8
        {
            /*0x10*/ long f0;
            /*0x18*/ long f1;
            /*0x20*/ long f2;
            /*0x28*/ long f3;
            /*0x30*/ long f4;
            /*0x38*/ long f5;
            /*0x40*/ long f6;
            /*0x48*/ long f7;
        }

        struct Long64
        {
            /*0x10*/ Unity.Collections.Long8 f0;
            /*0x50*/ Unity.Collections.Long8 f1;
            /*0x90*/ Unity.Collections.Long8 f2;
            /*0xd0*/ Unity.Collections.Long8 f3;
            /*0x110*/ Unity.Collections.Long8 f4;
            /*0x150*/ Unity.Collections.Long8 f5;
            /*0x190*/ Unity.Collections.Long8 f6;
            /*0x1d0*/ Unity.Collections.Long8 f7;
        }

        struct Long512
        {
            /*0x10*/ Unity.Collections.Long64 f0;
            /*0x210*/ Unity.Collections.Long64 f1;
            /*0x410*/ Unity.Collections.Long64 f2;
            /*0x610*/ Unity.Collections.Long64 f3;
            /*0x810*/ Unity.Collections.Long64 f4;
            /*0xa10*/ Unity.Collections.Long64 f5;
            /*0xc10*/ Unity.Collections.Long64 f6;
            /*0xe10*/ Unity.Collections.Long64 f7;
        }

        struct Long1024 : Unity.Collections.IIndexable<long>
        {
            /*0x10*/ Unity.Collections.Long512 f0;
            /*0x1010*/ Unity.Collections.Long512 f1;

            /*0x6d5f30*/ int get_Length();
            /*0x32d010*/ void set_Length(int value);
            /*0x1171cd0*/ ref long ElementAt(int index);
        }

        class ConcurrentMask
        {
            static int ErrorFailedToFree = -1;
            static int ErrorFailedToAllocate = -2;
            static int EmptyBeforeAllocation = 0;
            static int EmptyAfterFree = 0;

            static /*0x115f100*/ void longestConsecutiveOnes(long value, ref int offset, ref int count);
            static /*0x115ee70*/ bool foundAtLeastThisManyConsecutiveOnes(long value, int minimum, ref int offset, ref int count);
            static /*0x115efb0*/ bool foundAtLeastThisManyConsecutiveZeroes(long value, int minimum, ref int offset, ref int count);
            static /*0x115ea80*/ bool Succeeded(int error);
            static /*0x115ea50*/ long MakeMask(int offset, int bits);
            static /*0x115ec90*/ int TryAllocate(ref long l, int offset, int bits);
            static /*0x115ed80*/ int TryFree(ref long l, int offset, int bits);
            static /*0x115ea90*/ int TryAllocate(ref long l, ref int offset, int bits);
            static /*0x17c550*/ int TryAllocate<T>(ref T t, int offset, int bits);
            static /*0x17c550*/ int TryFree<T>(ref T t, int offset, int bits);
            static int TryAllocate<T>(ref T t, ref int offset, int begin, int end, int bits);
            static int TryAllocate<T>(ref T t, ref int offset, int bits);
            /*0x32f970*/ ConcurrentMask();
        }

        struct Pair<Key, Value>
        {
            /*0x0*/ Key key;
            /*0x0*/ Value value;

            /*0x2a5510*/ Pair(Key k, Value v);
            /*0x1803b0*/ string ToString();
        }

        struct ListPair<Key, Value>
        {
            /*0x0*/ Key key;
            /*0x0*/ Value value;

            /*0x2a5510*/ ListPair(Key k, Value v);
            /*0x1803b0*/ string ToString();
        }

        struct FixedList<T, U> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>
        {
            /*0x0*/ ushort length;
            /*0x0*/ U buffer;

            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int get_LengthInBytes();
            /*0x2a5510*/ byte* get_Buffer();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int GetHashCode();
            /*0x17aec0*/ void Add(ref T item);
            /*0x2a5510*/ void AddRange(void* ptr, int length);
            /*0x17aec0*/ void AddNoResize(ref T item);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int length);
            /*0x180fc0*/ void Clear();
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            void Insert(int index, ref T item);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
        }

        struct FixedList
        {
            static /*0x1809b0*/ int PaddingBytes<T>();
            static /*0x1809b0*/ int StorageBytes<BUFFER, T>();
            static /*0x1809b0*/ int Capacity<BUFFER, T>();
            static /*0x1784c0*/ void CheckResize<BUFFER, T>(int newLength);
        }

        struct FixedList32<T>
        {
        }

        struct FixedList32Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ ushort length;
            /*0x0*/ Unity.Collections.FixedBytes30 buffer;

            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList32Bytes<T> op_Implicit(ref Unity.Collections.FixedList64Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList32Bytes<T> op_Implicit(ref Unity.Collections.FixedList128Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList32Bytes<T> op_Implicit(ref Unity.Collections.FixedList512Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList32Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList32Bytes<T> op_Implicit(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17aec0*/ FixedList32Bytes(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x17aec0*/ FixedList32Bytes(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x17aec0*/ FixedList32Bytes(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x17aec0*/ FixedList32Bytes(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int get_LengthInBytes();
            /*0x2a5510*/ byte* get_Buffer();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int GetHashCode();
            /*0x17aec0*/ void Add(ref T item);
            /*0x2a5510*/ void AddRange(void* ptr, int length);
            /*0x17aec0*/ void AddNoResize(ref T item);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int length);
            /*0x180fc0*/ void Clear();
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            void Insert(int index, ref T item);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x2a5510*/ Unity.Collections.FixedList32Bytes.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.FixedList32Bytes<T> m_List;
                /*0x0*/ int m_Index;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.FixedList32Bytes<T> list);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedList32BytesExtensions
        {
            static /*0x2a5510*/ int IndexOf<T, U>(ref Unity.Collections.FixedList32Bytes<T> list, U value);
            static /*0x2a5510*/ bool Contains<T, U>(ref Unity.Collections.FixedList32Bytes<T> list, U value);
            static /*0x2a5510*/ bool Remove<T, U>(ref Unity.Collections.FixedList32Bytes<T> list, U value);
            static /*0x2a5510*/ bool RemoveSwapBack<T, U>(ref Unity.Collections.FixedList32Bytes<T> list, U value);
        }

        class FixedList32BytesDebugView<T>
        {
            /*0x0*/ Unity.Collections.FixedList32Bytes<T> m_List;

            /*0x2a5510*/ FixedList32BytesDebugView(Unity.Collections.FixedList32Bytes<T> list);
            /*0x1803b0*/ T[] get_Items();
        }

        struct FixedList64<T>
        {
        }

        struct FixedList64Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ ushort length;
            /*0x0*/ Unity.Collections.FixedBytes62 buffer;

            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList64Bytes<T> op_Implicit(ref Unity.Collections.FixedList32Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList64Bytes<T> op_Implicit(ref Unity.Collections.FixedList128Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList64Bytes<T> op_Implicit(ref Unity.Collections.FixedList512Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList64Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList64Bytes<T> op_Implicit(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17aec0*/ FixedList64Bytes(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x17aec0*/ FixedList64Bytes(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x17aec0*/ FixedList64Bytes(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x17aec0*/ FixedList64Bytes(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int get_LengthInBytes();
            /*0x2a5510*/ byte* get_Buffer();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int GetHashCode();
            /*0x17aec0*/ void Add(ref T item);
            /*0x2a5510*/ void AddRange(void* ptr, int length);
            /*0x17aec0*/ void AddNoResize(ref T item);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int length);
            /*0x180fc0*/ void Clear();
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            void Insert(int index, ref T item);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x2a5510*/ Unity.Collections.FixedList64Bytes.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.FixedList64Bytes<T> m_List;
                /*0x0*/ int m_Index;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.FixedList64Bytes<T> list);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedList64BytesExtensions
        {
            static /*0x2a5510*/ int IndexOf<T, U>(ref Unity.Collections.FixedList64Bytes<T> list, U value);
            static /*0x2a5510*/ bool Contains<T, U>(ref Unity.Collections.FixedList64Bytes<T> list, U value);
            static /*0x2a5510*/ bool Remove<T, U>(ref Unity.Collections.FixedList64Bytes<T> list, U value);
            static /*0x2a5510*/ bool RemoveSwapBack<T, U>(ref Unity.Collections.FixedList64Bytes<T> list, U value);
        }

        class FixedList64BytesDebugView<T>
        {
            /*0x0*/ Unity.Collections.FixedList64Bytes<T> m_List;

            /*0x2a5510*/ FixedList64BytesDebugView(Unity.Collections.FixedList64Bytes<T> list);
            /*0x1803b0*/ T[] get_Items();
        }

        struct FixedList128<T>
        {
        }

        struct FixedList128Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ ushort length;
            /*0x0*/ Unity.Collections.FixedBytes126 buffer;

            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList128Bytes<T> op_Implicit(ref Unity.Collections.FixedList32Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList128Bytes<T> op_Implicit(ref Unity.Collections.FixedList64Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList128Bytes<T> op_Implicit(ref Unity.Collections.FixedList512Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList128Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList128Bytes<T> op_Implicit(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17aec0*/ FixedList128Bytes(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x17aec0*/ FixedList128Bytes(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x17aec0*/ FixedList128Bytes(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x17aec0*/ FixedList128Bytes(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int get_LengthInBytes();
            /*0x2a5510*/ byte* get_Buffer();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int GetHashCode();
            /*0x17aec0*/ void Add(ref T item);
            /*0x2a5510*/ void AddRange(void* ptr, int length);
            /*0x17aec0*/ void AddNoResize(ref T item);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int length);
            /*0x180fc0*/ void Clear();
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            void Insert(int index, ref T item);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x2a5510*/ Unity.Collections.FixedList128Bytes.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.FixedList128Bytes<T> m_List;
                /*0x0*/ int m_Index;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.FixedList128Bytes<T> list);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedList128BytesExtensions
        {
            static /*0x2a5510*/ int IndexOf<T, U>(ref Unity.Collections.FixedList128Bytes<T> list, U value);
            static /*0x2a5510*/ bool Contains<T, U>(ref Unity.Collections.FixedList128Bytes<T> list, U value);
            static /*0x2a5510*/ bool Remove<T, U>(ref Unity.Collections.FixedList128Bytes<T> list, U value);
            static /*0x2a5510*/ bool RemoveSwapBack<T, U>(ref Unity.Collections.FixedList128Bytes<T> list, U value);
        }

        class FixedList128BytesDebugView<T>
        {
            /*0x0*/ Unity.Collections.FixedList128Bytes<T> m_List;

            /*0x2a5510*/ FixedList128BytesDebugView(Unity.Collections.FixedList128Bytes<T> list);
            /*0x1803b0*/ T[] get_Items();
        }

        struct FixedList512<T>
        {
        }

        struct FixedList512Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ ushort length;
            /*0x0*/ Unity.Collections.FixedBytes510 buffer;

            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList512Bytes<T> op_Implicit(ref Unity.Collections.FixedList32Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList512Bytes<T> op_Implicit(ref Unity.Collections.FixedList64Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList512Bytes<T> op_Implicit(ref Unity.Collections.FixedList128Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList512Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList512Bytes<T> op_Implicit(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17aec0*/ FixedList512Bytes(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x17aec0*/ FixedList512Bytes(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x17aec0*/ FixedList512Bytes(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x17aec0*/ FixedList512Bytes(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int get_LengthInBytes();
            /*0x2a5510*/ byte* get_Buffer();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int GetHashCode();
            /*0x17aec0*/ void Add(ref T item);
            /*0x2a5510*/ void AddRange(void* ptr, int length);
            /*0x17aec0*/ void AddNoResize(ref T item);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int length);
            /*0x180fc0*/ void Clear();
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            void Insert(int index, ref T item);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x2a5510*/ Unity.Collections.FixedList512Bytes.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.FixedList512Bytes<T> m_List;
                /*0x0*/ int m_Index;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.FixedList512Bytes<T> list);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedList512BytesExtensions
        {
            static /*0x2a5510*/ int IndexOf<T, U>(ref Unity.Collections.FixedList512Bytes<T> list, U value);
            static /*0x2a5510*/ bool Contains<T, U>(ref Unity.Collections.FixedList512Bytes<T> list, U value);
            static /*0x2a5510*/ bool Remove<T, U>(ref Unity.Collections.FixedList512Bytes<T> list, U value);
            static /*0x2a5510*/ bool RemoveSwapBack<T, U>(ref Unity.Collections.FixedList512Bytes<T> list, U value);
        }

        class FixedList512BytesDebugView<T>
        {
            /*0x0*/ Unity.Collections.FixedList512Bytes<T> m_List;

            /*0x2a5510*/ FixedList512BytesDebugView(Unity.Collections.FixedList512Bytes<T> list);
            /*0x1803b0*/ T[] get_Items();
        }

        struct FixedList4096<T>
        {
        }

        struct FixedList4096Bytes<T> : Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.FixedList32Bytes<T>>, System.IComparable<Unity.Collections.FixedList32Bytes<T>>, System.IEquatable<Unity.Collections.FixedList64Bytes<T>>, System.IComparable<Unity.Collections.FixedList64Bytes<T>>, System.IEquatable<Unity.Collections.FixedList128Bytes<T>>, System.IComparable<Unity.Collections.FixedList128Bytes<T>>, System.IEquatable<Unity.Collections.FixedList512Bytes<T>>, System.IComparable<Unity.Collections.FixedList512Bytes<T>>, System.IEquatable<Unity.Collections.FixedList4096Bytes<T>>, System.IComparable<Unity.Collections.FixedList4096Bytes<T>>
        {
            /*0x0*/ ushort length;
            /*0x0*/ Unity.Collections.FixedBytes4094 buffer;

            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList32Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList4096Bytes<T> op_Implicit(ref Unity.Collections.FixedList32Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList64Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList4096Bytes<T> op_Implicit(ref Unity.Collections.FixedList64Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList128Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList4096Bytes<T> op_Implicit(ref Unity.Collections.FixedList128Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList512Bytes<T> b);
            static /*0x2a5510*/ Unity.Collections.FixedList4096Bytes<T> op_Implicit(ref Unity.Collections.FixedList512Bytes<T> other);
            static /*0x1794f0*/ bool op_Equality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            static /*0x1794f0*/ bool op_Inequality(ref Unity.Collections.FixedList4096Bytes<T> a, ref Unity.Collections.FixedList4096Bytes<T> b);
            /*0x17aec0*/ FixedList4096Bytes(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x17aec0*/ FixedList4096Bytes(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x17aec0*/ FixedList4096Bytes(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x17aec0*/ FixedList4096Bytes(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<T> get_Elements();
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int get_LengthInBytes();
            /*0x2a5510*/ byte* get_Buffer();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int GetHashCode();
            /*0x17aec0*/ void Add(ref T item);
            /*0x2a5510*/ void AddRange(void* ptr, int length);
            /*0x17aec0*/ void AddNoResize(ref T item);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int length);
            /*0x180fc0*/ void Clear();
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            void Insert(int index, ref T item);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList32Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList32Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList64Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList64Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList128Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList128Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList512Bytes<T> other);
            /*0x17b580*/ int Initialize(ref Unity.Collections.FixedList512Bytes<T> other);
            /*0x2a5510*/ int CompareTo(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x2a5510*/ bool Equals(Unity.Collections.FixedList4096Bytes<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x2a5510*/ Unity.Collections.FixedList4096Bytes.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.FixedList4096Bytes<T> m_List;
                /*0x0*/ int m_Index;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.FixedList4096Bytes<T> list);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedList4096BytesExtensions
        {
            static /*0x2a5510*/ int IndexOf<T, U>(ref Unity.Collections.FixedList4096Bytes<T> list, U value);
            static /*0x2a5510*/ bool Contains<T, U>(ref Unity.Collections.FixedList4096Bytes<T> list, U value);
            static /*0x2a5510*/ bool Remove<T, U>(ref Unity.Collections.FixedList4096Bytes<T> list, U value);
            static /*0x2a5510*/ bool RemoveSwapBack<T, U>(ref Unity.Collections.FixedList4096Bytes<T> list, U value);
        }

        class FixedList4096BytesDebugView<T>
        {
            /*0x0*/ Unity.Collections.FixedList4096Bytes<T> m_List;

            /*0x2a5510*/ FixedList4096BytesDebugView(Unity.Collections.FixedList4096Bytes<T> list);
            /*0x1803b0*/ T[] get_Items();
        }

        struct FixedListByte32
        {
        }

        class FixedListByte32DebugView
        {
            /*0x10*/ Unity.Collections.FixedList32Bytes<byte> m_List;

            /*0x834b70*/ FixedListByte32DebugView(Unity.Collections.FixedList32Bytes<byte> list);
            /*0x115f6c0*/ byte[] get_Items();
        }

        struct FixedListByte64
        {
        }

        class FixedListByte64DebugView
        {
            /*0x10*/ Unity.Collections.FixedList64Bytes<byte> m_List;

            /*0x9bf2c0*/ FixedListByte64DebugView(Unity.Collections.FixedList64Bytes<byte> list);
            /*0x115f780*/ byte[] get_Items();
        }

        struct FixedListByte128
        {
        }

        class FixedListByte128DebugView
        {
            /*0x10*/ Unity.Collections.FixedList128Bytes<byte> m_List;

            /*0x99cc00*/ FixedListByte128DebugView(Unity.Collections.FixedList128Bytes<byte> list);
            /*0x115f680*/ byte[] get_Items();
        }

        struct FixedListByte512
        {
        }

        class FixedListByte512DebugView
        {
            /*0x10*/ Unity.Collections.FixedList512Bytes<byte> m_List;

            /*0x9b82d0*/ FixedListByte512DebugView(Unity.Collections.FixedList512Bytes<byte> list);
            /*0x115f740*/ byte[] get_Items();
        }

        struct FixedListByte4096
        {
        }

        class FixedListByte4096DebugView
        {
            /*0x10*/ Unity.Collections.FixedList4096Bytes<byte> m_List;

            /*0x9afe60*/ FixedListByte4096DebugView(Unity.Collections.FixedList4096Bytes<byte> list);
            /*0x115f700*/ byte[] get_Items();
        }

        struct FixedListInt32
        {
        }

        class FixedListInt32DebugView
        {
            /*0x10*/ Unity.Collections.FixedList32Bytes<int> m_List;

            /*0x834b70*/ FixedListInt32DebugView(Unity.Collections.FixedList32Bytes<int> list);
            /*0x115f940*/ int[] get_Items();
        }

        struct FixedListInt64
        {
        }

        class FixedListInt64DebugView
        {
            /*0x10*/ Unity.Collections.FixedList64Bytes<int> m_List;

            /*0x9bf2c0*/ FixedListInt64DebugView(Unity.Collections.FixedList64Bytes<int> list);
            /*0x115fa00*/ int[] get_Items();
        }

        struct FixedListInt128
        {
        }

        class FixedListInt128DebugView
        {
            /*0x10*/ Unity.Collections.FixedList128Bytes<int> m_List;

            /*0x99cc00*/ FixedListInt128DebugView(Unity.Collections.FixedList128Bytes<int> list);
            /*0x115f900*/ int[] get_Items();
        }

        struct FixedListInt512
        {
        }

        class FixedListInt512DebugView
        {
            /*0x10*/ Unity.Collections.FixedList512Bytes<int> m_List;

            /*0x9b82d0*/ FixedListInt512DebugView(Unity.Collections.FixedList512Bytes<int> list);
            /*0x115f9c0*/ int[] get_Items();
        }

        struct FixedListInt4096
        {
        }

        class FixedListInt4096DebugView
        {
            /*0x10*/ Unity.Collections.FixedList4096Bytes<int> m_List;

            /*0x9afe60*/ FixedListInt4096DebugView(Unity.Collections.FixedList4096Bytes<int> list);
            /*0x115f980*/ int[] get_Items();
        }

        struct FixedListFloat32
        {
        }

        class FixedListFloat32DebugView
        {
            /*0x10*/ Unity.Collections.FixedList32Bytes<float> m_List;

            /*0x834b70*/ FixedListFloat32DebugView(Unity.Collections.FixedList32Bytes<float> list);
            /*0x115f800*/ float[] get_Items();
        }

        struct FixedListFloat64
        {
        }

        class FixedListFloat64DebugView
        {
            /*0x10*/ Unity.Collections.FixedList64Bytes<float> m_List;

            /*0x9bf2c0*/ FixedListFloat64DebugView(Unity.Collections.FixedList64Bytes<float> list);
            /*0x115f8c0*/ float[] get_Items();
        }

        struct FixedListFloat128
        {
        }

        class FixedListFloat128DebugView
        {
            /*0x10*/ Unity.Collections.FixedList128Bytes<float> m_List;

            /*0x99cc00*/ FixedListFloat128DebugView(Unity.Collections.FixedList128Bytes<float> list);
            /*0x115f7c0*/ float[] get_Items();
        }

        struct FixedListFloat512
        {
        }

        class FixedListFloat512DebugView
        {
            /*0x10*/ Unity.Collections.FixedList512Bytes<float> m_List;

            /*0x9b82d0*/ FixedListFloat512DebugView(Unity.Collections.FixedList512Bytes<float> list);
            /*0x115f880*/ float[] get_Items();
        }

        struct FixedListFloat4096
        {
        }

        class FixedListFloat4096DebugView
        {
            /*0x10*/ Unity.Collections.FixedList4096Bytes<float> m_List;

            /*0x9afe60*/ FixedListFloat4096DebugView(Unity.Collections.FixedList4096Bytes<float> list);
            /*0x115f840*/ float[] get_Items();
        }

        class FixedListExtensions
        {
            static /*0x177be0*/ void Sort<T>(ref Unity.Collections.FixedList32Bytes<T> list);
            static /*0x2a5510*/ void Sort<T, U>(ref Unity.Collections.FixedList32Bytes<T> list, U comp);
            static /*0x177be0*/ void Sort<T>(ref Unity.Collections.FixedList64Bytes<T> list);
            static /*0x2a5510*/ void Sort<T, U>(ref Unity.Collections.FixedList64Bytes<T> list, U comp);
            static /*0x177be0*/ void Sort<T>(ref Unity.Collections.FixedList128Bytes<T> list);
            static /*0x2a5510*/ void Sort<T, U>(ref Unity.Collections.FixedList128Bytes<T> list, U comp);
            static /*0x177be0*/ void Sort<T>(ref Unity.Collections.FixedList512Bytes<T> list);
            static /*0x2a5510*/ void Sort<T, U>(ref Unity.Collections.FixedList512Bytes<T> list, U comp);
            static /*0x177be0*/ void Sort<T>(ref Unity.Collections.FixedList4096Bytes<T> list);
            static /*0x2a5510*/ void Sort<T, U>(ref Unity.Collections.FixedList4096Bytes<T> list, U comp);
        }

        struct FixedBytes16
        {
            /*0x10*/ byte byte0000;
            /*0x11*/ byte byte0001;
            /*0x12*/ byte byte0002;
            /*0x13*/ byte byte0003;
            /*0x14*/ byte byte0004;
            /*0x15*/ byte byte0005;
            /*0x16*/ byte byte0006;
            /*0x17*/ byte byte0007;
            /*0x18*/ byte byte0008;
            /*0x19*/ byte byte0009;
            /*0x1a*/ byte byte0010;
            /*0x1b*/ byte byte0011;
            /*0x1c*/ byte byte0012;
            /*0x1d*/ byte byte0013;
            /*0x1e*/ byte byte0014;
            /*0x1f*/ byte byte0015;
        }

        struct FixedBytes30
        {
            /*0x10*/ Unity.Collections.FixedBytes16 offset0000;
            /*0x20*/ byte byte0016;
            /*0x21*/ byte byte0017;
            /*0x22*/ byte byte0018;
            /*0x23*/ byte byte0019;
            /*0x24*/ byte byte0020;
            /*0x25*/ byte byte0021;
            /*0x26*/ byte byte0022;
            /*0x27*/ byte byte0023;
            /*0x28*/ byte byte0024;
            /*0x29*/ byte byte0025;
            /*0x2a*/ byte byte0026;
            /*0x2b*/ byte byte0027;
            /*0x2c*/ byte byte0028;
            /*0x2d*/ byte byte0029;
        }

        struct FixedString32
        {
        }

        struct FixedString32Bytes : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            static ushort utf8MaxLengthInBytes = 29;
            /*0x10*/ ushort utf8LengthInBytes;
            /*0x12*/ Unity.Collections.FixedBytes30 bytes;

            static /*0x1162880*/ int get_UTF8MaxLengthInBytes();
            static /*0x1162930*/ bool op_Equality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1162e20*/ bool op_Inequality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1162890*/ bool op_Equality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1162e60*/ bool op_Inequality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1162bf0*/ Unity.Collections.FixedString64Bytes op_Implicit(ref Unity.Collections.FixedString32Bytes fs);
            static /*0x1162a70*/ bool op_Equality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1162e00*/ bool op_Inequality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1162da0*/ Unity.Collections.FixedString128Bytes op_Implicit(ref Unity.Collections.FixedString32Bytes fs);
            static /*0x11629d0*/ bool op_Equality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1162e40*/ bool op_Inequality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1162bb0*/ Unity.Collections.FixedString512Bytes op_Implicit(ref Unity.Collections.FixedString32Bytes fs);
            static /*0x1162b10*/ bool op_Equality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1162de0*/ bool op_Inequality(ref Unity.Collections.FixedString32Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1162c20*/ Unity.Collections.FixedString4096Bytes op_Implicit(ref Unity.Collections.FixedString32Bytes fs);
            static /*0x1162d10*/ Unity.Collections.FixedString32Bytes op_Implicit(string b);
            static /*0x1161620*/ void CheckCopyError(Unity.Collections.CopyError error, string source);
            static /*0x11616c0*/ void CheckFormatError(Unity.Collections.FormatError error);
            /*0x11626f0*/ FixedString32Bytes(string source);
            /*0x11627d0*/ FixedString32Bytes(Unity.Collections.Unicode.Rune rune, int count);
            /*0x11627b0*/ FixedString32Bytes(ref Unity.Collections.FixedString32Bytes other);
            /*0x1162770*/ FixedString32Bytes(ref Unity.Collections.FixedString64Bytes other);
            /*0x1162860*/ FixedString32Bytes(ref Unity.Collections.FixedString128Bytes other);
            /*0x1162840*/ FixedString32Bytes(ref Unity.Collections.FixedString512Bytes other);
            /*0x1162790*/ FixedString32Bytes(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1162630*/ string get_Value();
            /*0x1160780*/ byte* GetUnsafePtr();
            /*0x6bba60*/ int get_Length();
            /*0x1161510*/ void set_Length(int value);
            /*0x1162880*/ int get_Capacity();
            /*0x32d010*/ void set_Capacity(int value);
            /*0x1162670*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x1160f50*/ bool get_IsEmpty();
            /*0x1160f60*/ byte get_Item(int index);
            /*0x1161500*/ void set_Item(int index, byte value);
            /*0x11600f0*/ ref byte ElementAt(int index);
            /*0x115fef0*/ void Clear();
            /*0x115fa40*/ void Add(ref byte value);
            /*0x1162170*/ Unity.Collections.FixedString32Bytes.Enumerator GetEnumerator();
            /*0x1161a50*/ int CompareTo(string other);
            /*0x1161ba0*/ bool Equals(string other);
            /*0x1161520*/ ref Unity.Collections.FixedList32Bytes<byte> AsFixedList();
            /*0x1162280*/ int Initialize(string source);
            /*0x11623c0*/ int Initialize(Unity.Collections.Unicode.Rune rune, int count);
            /*0x1161b00*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x1162580*/ int Initialize(ref Unity.Collections.FixedString32Bytes other);
            /*0x1161c80*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x1161b50*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x11621d0*/ int Initialize(ref Unity.Collections.FixedString64Bytes other);
            /*0x1161c60*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x1161a00*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x1162420*/ int Initialize(ref Unity.Collections.FixedString128Bytes other);
            /*0x1161ca0*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x11619b0*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x11624d0*/ int Initialize(ref Unity.Collections.FixedString512Bytes other);
            /*0x1161c40*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x1161ab0*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x1162310*/ int Initialize(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1162150*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x1162630*/ string ToString();
            /*0x1162190*/ int GetHashCode();
            /*0x1161cc0*/ bool Equals(object obj);
            /*0x1161720*/ void CheckIndexInRange(int index);
            /*0x1161870*/ void CheckLengthInRange(int length);
            /*0x1161550*/ void CheckCapacityInRange(int capacity);

            struct Enumerator : System.Collections.IEnumerator
            {
                /*0x10*/ Unity.Collections.FixedString32Bytes target;
                /*0x30*/ int offset;
                /*0x34*/ Unity.Collections.Unicode.Rune current;

                /*0x115f560*/ Enumerator(Unity.Collections.FixedString32Bytes other);
                /*0x32d010*/ void Dispose();
                /*0x115f1f0*/ bool MoveNext();
                /*0x115f350*/ void Reset();
                /*0x3e3ad0*/ Unity.Collections.Unicode.Rune get_Current();
                /*0x115f400*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        struct FixedBytes62
        {
            /*0x10*/ Unity.Collections.FixedBytes16 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16 offset0032;
            /*0x40*/ byte byte0048;
            /*0x41*/ byte byte0049;
            /*0x42*/ byte byte0050;
            /*0x43*/ byte byte0051;
            /*0x44*/ byte byte0052;
            /*0x45*/ byte byte0053;
            /*0x46*/ byte byte0054;
            /*0x47*/ byte byte0055;
            /*0x48*/ byte byte0056;
            /*0x49*/ byte byte0057;
            /*0x4a*/ byte byte0058;
            /*0x4b*/ byte byte0059;
            /*0x4c*/ byte byte0060;
            /*0x4d*/ byte byte0061;
        }

        struct FixedString64
        {
        }

        struct FixedString64Bytes : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            static ushort utf8MaxLengthInBytes = 61;
            /*0x10*/ ushort utf8LengthInBytes;
            /*0x12*/ Unity.Collections.FixedBytes62 bytes;

            static /*0x3a0860*/ int get_UTF8MaxLengthInBytes();
            static /*0x11676e0*/ bool op_Equality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1167b40*/ bool op_Inequality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1167780*/ bool op_Equality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1167b20*/ bool op_Inequality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1167640*/ bool op_Equality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1167ae0*/ bool op_Inequality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1167a80*/ Unity.Collections.FixedString128Bytes op_Implicit(ref Unity.Collections.FixedString64Bytes fs);
            static /*0x11675a0*/ bool op_Equality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1167ac0*/ bool op_Inequality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1167a40*/ Unity.Collections.FixedString512Bytes op_Implicit(ref Unity.Collections.FixedString64Bytes fs);
            static /*0x1167820*/ bool op_Equality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1167b00*/ bool op_Inequality(ref Unity.Collections.FixedString64Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x11678c0*/ Unity.Collections.FixedString4096Bytes op_Implicit(ref Unity.Collections.FixedString64Bytes fs);
            static /*0x11679b0*/ Unity.Collections.FixedString64Bytes op_Implicit(string b);
            static /*0x11662b0*/ void CheckCopyError(Unity.Collections.CopyError error, string source);
            static /*0x1166350*/ void CheckFormatError(Unity.Collections.FormatError error);
            /*0x1167490*/ FixedString64Bytes(string source);
            /*0x1167520*/ FixedString64Bytes(Unity.Collections.Unicode.Rune rune, int count);
            /*0x1167450*/ FixedString64Bytes(ref Unity.Collections.FixedString32Bytes other);
            /*0x11673f0*/ FixedString64Bytes(ref Unity.Collections.FixedString64Bytes other);
            /*0x1167410*/ FixedString64Bytes(ref Unity.Collections.FixedString128Bytes other);
            /*0x1167430*/ FixedString64Bytes(ref Unity.Collections.FixedString512Bytes other);
            /*0x1167470*/ FixedString64Bytes(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1167330*/ string get_Value();
            /*0x1160780*/ byte* GetUnsafePtr();
            /*0x6bba60*/ int get_Length();
            /*0x1161510*/ void set_Length(int value);
            /*0x3a0860*/ int get_Capacity();
            /*0x32d010*/ void set_Capacity(int value);
            /*0x1167370*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x1160f50*/ bool get_IsEmpty();
            /*0x1160f60*/ byte get_Item(int index);
            /*0x1161500*/ void set_Item(int index, byte value);
            /*0x11600f0*/ ref byte ElementAt(int index);
            /*0x115fef0*/ void Clear();
            /*0x115fa40*/ void Add(ref byte value);
            /*0x1166e00*/ Unity.Collections.FixedString64Bytes.Enumerator GetEnumerator();
            /*0x1166730*/ int CompareTo(string other);
            /*0x1166d20*/ bool Equals(string other);
            /*0x11661b0*/ ref Unity.Collections.FixedList64Bytes<byte> AsFixedList();
            /*0x1166fa0*/ int Initialize(string source);
            /*0x1166f30*/ int Initialize(Unity.Collections.Unicode.Rune rune, int count);
            /*0x1166790*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x11670f0*/ int Initialize(ref Unity.Collections.FixedString32Bytes other);
            /*0x1166cc0*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x11667e0*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x1167270*/ int Initialize(ref Unity.Collections.FixedString64Bytes other);
            /*0x1166d00*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x1166690*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x1167030*/ int Initialize(ref Unity.Collections.FixedString128Bytes other);
            /*0x1166ce0*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x1166640*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x1166e70*/ int Initialize(ref Unity.Collections.FixedString512Bytes other);
            /*0x1166dc0*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x11666e0*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x11671b0*/ int Initialize(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1166de0*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x1167330*/ string ToString();
            /*0x1166e30*/ int GetHashCode();
            /*0x1166830*/ bool Equals(object obj);
            /*0x11663b0*/ void CheckIndexInRange(int index);
            /*0x1166500*/ void CheckLengthInRange(int length);
            /*0x11661e0*/ void CheckCapacityInRange(int capacity);

            struct Enumerator : System.Collections.IEnumerator
            {
                /*0x10*/ Unity.Collections.FixedString64Bytes target;
                /*0x50*/ int offset;
                /*0x54*/ Unity.Collections.Unicode.Rune current;

                /*0x115f5d0*/ Enumerator(Unity.Collections.FixedString64Bytes other);
                /*0x32d010*/ void Dispose();
                /*0x115f280*/ bool MoveNext();
                /*0x115f340*/ void Reset();
                /*0x10eed50*/ Unity.Collections.Unicode.Rune get_Current();
                /*0x115f3b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        struct FixedBytes126
        {
            /*0x10*/ Unity.Collections.FixedBytes16 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16 offset0048;
            /*0x50*/ Unity.Collections.FixedBytes16 offset0064;
            /*0x60*/ Unity.Collections.FixedBytes16 offset0080;
            /*0x70*/ Unity.Collections.FixedBytes16 offset0096;
            /*0x80*/ byte byte0112;
            /*0x81*/ byte byte0113;
            /*0x82*/ byte byte0114;
            /*0x83*/ byte byte0115;
            /*0x84*/ byte byte0116;
            /*0x85*/ byte byte0117;
            /*0x86*/ byte byte0118;
            /*0x87*/ byte byte0119;
            /*0x88*/ byte byte0120;
            /*0x89*/ byte byte0121;
            /*0x8a*/ byte byte0122;
            /*0x8b*/ byte byte0123;
            /*0x8c*/ byte byte0124;
            /*0x8d*/ byte byte0125;
        }

        struct FixedString128
        {
        }

        struct FixedString128Bytes : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            static ushort utf8MaxLengthInBytes = 125;
            /*0x10*/ ushort utf8LengthInBytes;
            /*0x12*/ Unity.Collections.FixedBytes126 bytes;

            static /*0x1160f40*/ int get_UTF8MaxLengthInBytes();
            static /*0x1161010*/ bool op_Equality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x11614e0*/ bool op_Inequality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1161150*/ bool op_Equality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x11614a0*/ bool op_Inequality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x11610b0*/ bool op_Equality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1161460*/ bool op_Inequality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1160f70*/ bool op_Equality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x11614c0*/ bool op_Inequality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1161290*/ Unity.Collections.FixedString512Bytes op_Implicit(ref Unity.Collections.FixedString128Bytes fs);
            static /*0x11611f0*/ bool op_Equality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1161480*/ bool op_Inequality(ref Unity.Collections.FixedString128Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x11612d0*/ Unity.Collections.FixedString4096Bytes op_Implicit(ref Unity.Collections.FixedString128Bytes fs);
            static /*0x11613c0*/ Unity.Collections.FixedString128Bytes op_Implicit(string b);
            static /*0x115fb60*/ void CheckCopyError(Unity.Collections.CopyError error, string source);
            static /*0x115fc00*/ void CheckFormatError(Unity.Collections.FormatError error);
            /*0x1160e70*/ FixedString128Bytes(string source);
            /*0x1160e10*/ FixedString128Bytes(Unity.Collections.Unicode.Rune rune, int count);
            /*0x1160de0*/ FixedString128Bytes(ref Unity.Collections.FixedString32Bytes other);
            /*0x1160f10*/ FixedString128Bytes(ref Unity.Collections.FixedString64Bytes other);
            /*0x1160db0*/ FixedString128Bytes(ref Unity.Collections.FixedString128Bytes other);
            /*0x1160d80*/ FixedString128Bytes(ref Unity.Collections.FixedString512Bytes other);
            /*0x1160e40*/ FixedString128Bytes(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1160cc0*/ string get_Value();
            /*0x1160780*/ byte* GetUnsafePtr();
            /*0x6bba60*/ int get_Length();
            /*0x1161510*/ void set_Length(int value);
            /*0x1160f40*/ int get_Capacity();
            /*0x32d010*/ void set_Capacity(int value);
            /*0x1160d00*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x1160f50*/ bool get_IsEmpty();
            /*0x1160f60*/ byte get_Item(int index);
            /*0x1161500*/ void set_Item(int index, byte value);
            /*0x11600f0*/ ref byte ElementAt(int index);
            /*0x115fef0*/ void Clear();
            /*0x115fa40*/ void Add(ref byte value);
            /*0x11606d0*/ Unity.Collections.FixedString128Bytes.Enumerator GetEnumerator();
            /*0x115fff0*/ int CompareTo(string other);
            /*0x1160180*/ bool Equals(string other);
            /*0x115fa60*/ ref Unity.Collections.FixedList128Bytes<byte> AsFixedList();
            /*0x1160790*/ int Initialize(string source);
            /*0x1160b70*/ int Initialize(Unity.Collections.Unicode.Rune rune, int count);
            /*0x11600a0*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x1160bf0*/ int Initialize(ref Unity.Collections.FixedString32Bytes other);
            /*0x1160160*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x1160050*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x1160aa0*/ int Initialize(ref Unity.Collections.FixedString64Bytes other);
            /*0x1160220*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x115ff50*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x1160830*/ int Initialize(ref Unity.Collections.FixedString128Bytes other);
            /*0x1160140*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x115ffa0*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x1160900*/ int Initialize(ref Unity.Collections.FixedString512Bytes other);
            /*0x1160100*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x115ff00*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x11609d0*/ int Initialize(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1160120*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x1160cc0*/ string ToString();
            /*0x1160740*/ int GetHashCode();
            /*0x1160240*/ bool Equals(object obj);
            /*0x115fc60*/ void CheckIndexInRange(int index);
            /*0x115fdb0*/ void CheckLengthInRange(int length);
            /*0x115fa90*/ void CheckCapacityInRange(int capacity);

            struct Enumerator : System.Collections.IEnumerator
            {
                /*0x10*/ Unity.Collections.FixedString128Bytes target;
                /*0x90*/ int offset;
                /*0x94*/ Unity.Collections.Unicode.Rune current;

                /*0x115f600*/ Enumerator(Unity.Collections.FixedString128Bytes other);
                /*0x32d010*/ void Dispose();
                /*0x115f2c0*/ bool MoveNext();
                /*0x115f310*/ void Reset();
                /*0x115f670*/ Unity.Collections.Unicode.Rune get_Current();
                /*0x115f450*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        struct FixedBytes510
        {
            /*0x10*/ Unity.Collections.FixedBytes16 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16 offset0048;
            /*0x50*/ Unity.Collections.FixedBytes16 offset0064;
            /*0x60*/ Unity.Collections.FixedBytes16 offset0080;
            /*0x70*/ Unity.Collections.FixedBytes16 offset0096;
            /*0x80*/ Unity.Collections.FixedBytes16 offset0112;
            /*0x90*/ Unity.Collections.FixedBytes16 offset0128;
            /*0xa0*/ Unity.Collections.FixedBytes16 offset0144;
            /*0xb0*/ Unity.Collections.FixedBytes16 offset0160;
            /*0xc0*/ Unity.Collections.FixedBytes16 offset0176;
            /*0xd0*/ Unity.Collections.FixedBytes16 offset0192;
            /*0xe0*/ Unity.Collections.FixedBytes16 offset0208;
            /*0xf0*/ Unity.Collections.FixedBytes16 offset0224;
            /*0x100*/ Unity.Collections.FixedBytes16 offset0240;
            /*0x110*/ Unity.Collections.FixedBytes16 offset0256;
            /*0x120*/ Unity.Collections.FixedBytes16 offset0272;
            /*0x130*/ Unity.Collections.FixedBytes16 offset0288;
            /*0x140*/ Unity.Collections.FixedBytes16 offset0304;
            /*0x150*/ Unity.Collections.FixedBytes16 offset0320;
            /*0x160*/ Unity.Collections.FixedBytes16 offset0336;
            /*0x170*/ Unity.Collections.FixedBytes16 offset0352;
            /*0x180*/ Unity.Collections.FixedBytes16 offset0368;
            /*0x190*/ Unity.Collections.FixedBytes16 offset0384;
            /*0x1a0*/ Unity.Collections.FixedBytes16 offset0400;
            /*0x1b0*/ Unity.Collections.FixedBytes16 offset0416;
            /*0x1c0*/ Unity.Collections.FixedBytes16 offset0432;
            /*0x1d0*/ Unity.Collections.FixedBytes16 offset0448;
            /*0x1e0*/ Unity.Collections.FixedBytes16 offset0464;
            /*0x1f0*/ Unity.Collections.FixedBytes16 offset0480;
            /*0x200*/ byte byte0496;
            /*0x201*/ byte byte0497;
            /*0x202*/ byte byte0498;
            /*0x203*/ byte byte0499;
            /*0x204*/ byte byte0500;
            /*0x205*/ byte byte0501;
            /*0x206*/ byte byte0502;
            /*0x207*/ byte byte0503;
            /*0x208*/ byte byte0504;
            /*0x209*/ byte byte0505;
            /*0x20a*/ byte byte0506;
            /*0x20b*/ byte byte0507;
            /*0x20c*/ byte byte0508;
            /*0x20d*/ byte byte0509;
        }

        struct FixedString512
        {
        }

        struct FixedString512Bytes : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            static ushort utf8MaxLengthInBytes = 509;
            /*0x10*/ ushort utf8LengthInBytes;
            /*0x12*/ Unity.Collections.FixedBytes510 bytes;

            static /*0x1165c70*/ int get_UTF8MaxLengthInBytes();
            static /*0x1165f00*/ bool op_Equality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1166150*/ bool op_Inequality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1165e60*/ bool op_Equality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1166130*/ bool op_Inequality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1165d20*/ bool op_Equality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1166110*/ bool op_Inequality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1165c80*/ bool op_Equality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1166190*/ bool op_Inequality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1165dc0*/ bool op_Equality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1166170*/ bool op_Inequality(ref Unity.Collections.FixedString512Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1165fa0*/ Unity.Collections.FixedString4096Bytes op_Implicit(ref Unity.Collections.FixedString512Bytes fs);
            static /*0x1166090*/ Unity.Collections.FixedString512Bytes op_Implicit(string b);
            static /*0x1164890*/ void CheckCopyError(Unity.Collections.CopyError error, string source);
            static /*0x1164930*/ void CheckFormatError(Unity.Collections.FormatError error);
            /*0x1165a70*/ FixedString512Bytes(string source);
            /*0x1165bf0*/ FixedString512Bytes(Unity.Collections.Unicode.Rune rune, int count);
            /*0x1165b70*/ FixedString512Bytes(ref Unity.Collections.FixedString32Bytes other);
            /*0x1165a30*/ FixedString512Bytes(ref Unity.Collections.FixedString64Bytes other);
            /*0x1165bb0*/ FixedString512Bytes(ref Unity.Collections.FixedString128Bytes other);
            /*0x1165b30*/ FixedString512Bytes(ref Unity.Collections.FixedString512Bytes other);
            /*0x1165af0*/ FixedString512Bytes(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1165970*/ string get_Value();
            /*0x1160780*/ byte* GetUnsafePtr();
            /*0x6bba60*/ int get_Length();
            /*0x1161510*/ void set_Length(int value);
            /*0x1165c70*/ int get_Capacity();
            /*0x32d010*/ void set_Capacity(int value);
            /*0x11659b0*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x1160f50*/ bool get_IsEmpty();
            /*0x1160f60*/ byte get_Item(int index);
            /*0x1161500*/ void set_Item(int index, byte value);
            /*0x11600f0*/ ref byte ElementAt(int index);
            /*0x115fef0*/ void Clear();
            /*0x115fa40*/ void Add(ref byte value);
            /*0x11653e0*/ Unity.Collections.FixedString512Bytes.Enumerator GetEnumerator();
            /*0x1164d60*/ int CompareTo(string other);
            /*0x1165340*/ bool Equals(string other);
            /*0x11647a0*/ ref Unity.Collections.FixedList512Bytes<byte> AsFixedList();
            /*0x1165670*/ int Initialize(string source);
            /*0x11657a0*/ int Initialize(Unity.Collections.Unicode.Rune rune, int count);
            /*0x1164dc0*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x1165810*/ int Initialize(ref Unity.Collections.FixedString32Bytes other);
            /*0x1164e30*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x1164cc0*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x11655c0*/ int Initialize(ref Unity.Collections.FixedString64Bytes other);
            /*0x1164e10*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x1164c70*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x11656f0*/ int Initialize(ref Unity.Collections.FixedString128Bytes other);
            /*0x1165300*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x1164c20*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x1165510*/ int Initialize(ref Unity.Collections.FixedString512Bytes other);
            /*0x11652e0*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x1164d10*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x11658c0*/ int Initialize(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1165320*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x1165970*/ string ToString();
            /*0x11654d0*/ int GetHashCode();
            /*0x1164e50*/ bool Equals(object obj);
            /*0x1164990*/ void CheckIndexInRange(int index);
            /*0x1164ae0*/ void CheckLengthInRange(int length);
            /*0x11647d0*/ void CheckCapacityInRange(int capacity);

            struct Enumerator : System.Collections.IEnumerator
            {
                /*0x10*/ Unity.Collections.FixedString512Bytes target;
                /*0x210*/ int offset;
                /*0x214*/ Unity.Collections.Unicode.Rune current;

                /*0x115f4f0*/ Enumerator(Unity.Collections.FixedString512Bytes other);
                /*0x32d010*/ void Dispose();
                /*0x115f1a0*/ bool MoveNext();
                /*0x115f320*/ void Reset();
                /*0x115f650*/ Unity.Collections.Unicode.Rune get_Current();
                /*0x115f4a0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        struct FixedBytes4094
        {
            /*0x10*/ Unity.Collections.FixedBytes16 offset0000;
            /*0x20*/ Unity.Collections.FixedBytes16 offset0016;
            /*0x30*/ Unity.Collections.FixedBytes16 offset0032;
            /*0x40*/ Unity.Collections.FixedBytes16 offset0048;
            /*0x50*/ Unity.Collections.FixedBytes16 offset0064;
            /*0x60*/ Unity.Collections.FixedBytes16 offset0080;
            /*0x70*/ Unity.Collections.FixedBytes16 offset0096;
            /*0x80*/ Unity.Collections.FixedBytes16 offset0112;
            /*0x90*/ Unity.Collections.FixedBytes16 offset0128;
            /*0xa0*/ Unity.Collections.FixedBytes16 offset0144;
            /*0xb0*/ Unity.Collections.FixedBytes16 offset0160;
            /*0xc0*/ Unity.Collections.FixedBytes16 offset0176;
            /*0xd0*/ Unity.Collections.FixedBytes16 offset0192;
            /*0xe0*/ Unity.Collections.FixedBytes16 offset0208;
            /*0xf0*/ Unity.Collections.FixedBytes16 offset0224;
            /*0x100*/ Unity.Collections.FixedBytes16 offset0240;
            /*0x110*/ Unity.Collections.FixedBytes16 offset0256;
            /*0x120*/ Unity.Collections.FixedBytes16 offset0272;
            /*0x130*/ Unity.Collections.FixedBytes16 offset0288;
            /*0x140*/ Unity.Collections.FixedBytes16 offset0304;
            /*0x150*/ Unity.Collections.FixedBytes16 offset0320;
            /*0x160*/ Unity.Collections.FixedBytes16 offset0336;
            /*0x170*/ Unity.Collections.FixedBytes16 offset0352;
            /*0x180*/ Unity.Collections.FixedBytes16 offset0368;
            /*0x190*/ Unity.Collections.FixedBytes16 offset0384;
            /*0x1a0*/ Unity.Collections.FixedBytes16 offset0400;
            /*0x1b0*/ Unity.Collections.FixedBytes16 offset0416;
            /*0x1c0*/ Unity.Collections.FixedBytes16 offset0432;
            /*0x1d0*/ Unity.Collections.FixedBytes16 offset0448;
            /*0x1e0*/ Unity.Collections.FixedBytes16 offset0464;
            /*0x1f0*/ Unity.Collections.FixedBytes16 offset0480;
            /*0x200*/ Unity.Collections.FixedBytes16 offset0496;
            /*0x210*/ Unity.Collections.FixedBytes16 offset0512;
            /*0x220*/ Unity.Collections.FixedBytes16 offset0528;
            /*0x230*/ Unity.Collections.FixedBytes16 offset0544;
            /*0x240*/ Unity.Collections.FixedBytes16 offset0560;
            /*0x250*/ Unity.Collections.FixedBytes16 offset0576;
            /*0x260*/ Unity.Collections.FixedBytes16 offset0592;
            /*0x270*/ Unity.Collections.FixedBytes16 offset0608;
            /*0x280*/ Unity.Collections.FixedBytes16 offset0624;
            /*0x290*/ Unity.Collections.FixedBytes16 offset0640;
            /*0x2a0*/ Unity.Collections.FixedBytes16 offset0656;
            /*0x2b0*/ Unity.Collections.FixedBytes16 offset0672;
            /*0x2c0*/ Unity.Collections.FixedBytes16 offset0688;
            /*0x2d0*/ Unity.Collections.FixedBytes16 offset0704;
            /*0x2e0*/ Unity.Collections.FixedBytes16 offset0720;
            /*0x2f0*/ Unity.Collections.FixedBytes16 offset0736;
            /*0x300*/ Unity.Collections.FixedBytes16 offset0752;
            /*0x310*/ Unity.Collections.FixedBytes16 offset0768;
            /*0x320*/ Unity.Collections.FixedBytes16 offset0784;
            /*0x330*/ Unity.Collections.FixedBytes16 offset0800;
            /*0x340*/ Unity.Collections.FixedBytes16 offset0816;
            /*0x350*/ Unity.Collections.FixedBytes16 offset0832;
            /*0x360*/ Unity.Collections.FixedBytes16 offset0848;
            /*0x370*/ Unity.Collections.FixedBytes16 offset0864;
            /*0x380*/ Unity.Collections.FixedBytes16 offset0880;
            /*0x390*/ Unity.Collections.FixedBytes16 offset0896;
            /*0x3a0*/ Unity.Collections.FixedBytes16 offset0912;
            /*0x3b0*/ Unity.Collections.FixedBytes16 offset0928;
            /*0x3c0*/ Unity.Collections.FixedBytes16 offset0944;
            /*0x3d0*/ Unity.Collections.FixedBytes16 offset0960;
            /*0x3e0*/ Unity.Collections.FixedBytes16 offset0976;
            /*0x3f0*/ Unity.Collections.FixedBytes16 offset0992;
            /*0x400*/ Unity.Collections.FixedBytes16 offset1008;
            /*0x410*/ Unity.Collections.FixedBytes16 offset1024;
            /*0x420*/ Unity.Collections.FixedBytes16 offset1040;
            /*0x430*/ Unity.Collections.FixedBytes16 offset1056;
            /*0x440*/ Unity.Collections.FixedBytes16 offset1072;
            /*0x450*/ Unity.Collections.FixedBytes16 offset1088;
            /*0x460*/ Unity.Collections.FixedBytes16 offset1104;
            /*0x470*/ Unity.Collections.FixedBytes16 offset1120;
            /*0x480*/ Unity.Collections.FixedBytes16 offset1136;
            /*0x490*/ Unity.Collections.FixedBytes16 offset1152;
            /*0x4a0*/ Unity.Collections.FixedBytes16 offset1168;
            /*0x4b0*/ Unity.Collections.FixedBytes16 offset1184;
            /*0x4c0*/ Unity.Collections.FixedBytes16 offset1200;
            /*0x4d0*/ Unity.Collections.FixedBytes16 offset1216;
            /*0x4e0*/ Unity.Collections.FixedBytes16 offset1232;
            /*0x4f0*/ Unity.Collections.FixedBytes16 offset1248;
            /*0x500*/ Unity.Collections.FixedBytes16 offset1264;
            /*0x510*/ Unity.Collections.FixedBytes16 offset1280;
            /*0x520*/ Unity.Collections.FixedBytes16 offset1296;
            /*0x530*/ Unity.Collections.FixedBytes16 offset1312;
            /*0x540*/ Unity.Collections.FixedBytes16 offset1328;
            /*0x550*/ Unity.Collections.FixedBytes16 offset1344;
            /*0x560*/ Unity.Collections.FixedBytes16 offset1360;
            /*0x570*/ Unity.Collections.FixedBytes16 offset1376;
            /*0x580*/ Unity.Collections.FixedBytes16 offset1392;
            /*0x590*/ Unity.Collections.FixedBytes16 offset1408;
            /*0x5a0*/ Unity.Collections.FixedBytes16 offset1424;
            /*0x5b0*/ Unity.Collections.FixedBytes16 offset1440;
            /*0x5c0*/ Unity.Collections.FixedBytes16 offset1456;
            /*0x5d0*/ Unity.Collections.FixedBytes16 offset1472;
            /*0x5e0*/ Unity.Collections.FixedBytes16 offset1488;
            /*0x5f0*/ Unity.Collections.FixedBytes16 offset1504;
            /*0x600*/ Unity.Collections.FixedBytes16 offset1520;
            /*0x610*/ Unity.Collections.FixedBytes16 offset1536;
            /*0x620*/ Unity.Collections.FixedBytes16 offset1552;
            /*0x630*/ Unity.Collections.FixedBytes16 offset1568;
            /*0x640*/ Unity.Collections.FixedBytes16 offset1584;
            /*0x650*/ Unity.Collections.FixedBytes16 offset1600;
            /*0x660*/ Unity.Collections.FixedBytes16 offset1616;
            /*0x670*/ Unity.Collections.FixedBytes16 offset1632;
            /*0x680*/ Unity.Collections.FixedBytes16 offset1648;
            /*0x690*/ Unity.Collections.FixedBytes16 offset1664;
            /*0x6a0*/ Unity.Collections.FixedBytes16 offset1680;
            /*0x6b0*/ Unity.Collections.FixedBytes16 offset1696;
            /*0x6c0*/ Unity.Collections.FixedBytes16 offset1712;
            /*0x6d0*/ Unity.Collections.FixedBytes16 offset1728;
            /*0x6e0*/ Unity.Collections.FixedBytes16 offset1744;
            /*0x6f0*/ Unity.Collections.FixedBytes16 offset1760;
            /*0x700*/ Unity.Collections.FixedBytes16 offset1776;
            /*0x710*/ Unity.Collections.FixedBytes16 offset1792;
            /*0x720*/ Unity.Collections.FixedBytes16 offset1808;
            /*0x730*/ Unity.Collections.FixedBytes16 offset1824;
            /*0x740*/ Unity.Collections.FixedBytes16 offset1840;
            /*0x750*/ Unity.Collections.FixedBytes16 offset1856;
            /*0x760*/ Unity.Collections.FixedBytes16 offset1872;
            /*0x770*/ Unity.Collections.FixedBytes16 offset1888;
            /*0x780*/ Unity.Collections.FixedBytes16 offset1904;
            /*0x790*/ Unity.Collections.FixedBytes16 offset1920;
            /*0x7a0*/ Unity.Collections.FixedBytes16 offset1936;
            /*0x7b0*/ Unity.Collections.FixedBytes16 offset1952;
            /*0x7c0*/ Unity.Collections.FixedBytes16 offset1968;
            /*0x7d0*/ Unity.Collections.FixedBytes16 offset1984;
            /*0x7e0*/ Unity.Collections.FixedBytes16 offset2000;
            /*0x7f0*/ Unity.Collections.FixedBytes16 offset2016;
            /*0x800*/ Unity.Collections.FixedBytes16 offset2032;
            /*0x810*/ Unity.Collections.FixedBytes16 offset2048;
            /*0x820*/ Unity.Collections.FixedBytes16 offset2064;
            /*0x830*/ Unity.Collections.FixedBytes16 offset2080;
            /*0x840*/ Unity.Collections.FixedBytes16 offset2096;
            /*0x850*/ Unity.Collections.FixedBytes16 offset2112;
            /*0x860*/ Unity.Collections.FixedBytes16 offset2128;
            /*0x870*/ Unity.Collections.FixedBytes16 offset2144;
            /*0x880*/ Unity.Collections.FixedBytes16 offset2160;
            /*0x890*/ Unity.Collections.FixedBytes16 offset2176;
            /*0x8a0*/ Unity.Collections.FixedBytes16 offset2192;
            /*0x8b0*/ Unity.Collections.FixedBytes16 offset2208;
            /*0x8c0*/ Unity.Collections.FixedBytes16 offset2224;
            /*0x8d0*/ Unity.Collections.FixedBytes16 offset2240;
            /*0x8e0*/ Unity.Collections.FixedBytes16 offset2256;
            /*0x8f0*/ Unity.Collections.FixedBytes16 offset2272;
            /*0x900*/ Unity.Collections.FixedBytes16 offset2288;
            /*0x910*/ Unity.Collections.FixedBytes16 offset2304;
            /*0x920*/ Unity.Collections.FixedBytes16 offset2320;
            /*0x930*/ Unity.Collections.FixedBytes16 offset2336;
            /*0x940*/ Unity.Collections.FixedBytes16 offset2352;
            /*0x950*/ Unity.Collections.FixedBytes16 offset2368;
            /*0x960*/ Unity.Collections.FixedBytes16 offset2384;
            /*0x970*/ Unity.Collections.FixedBytes16 offset2400;
            /*0x980*/ Unity.Collections.FixedBytes16 offset2416;
            /*0x990*/ Unity.Collections.FixedBytes16 offset2432;
            /*0x9a0*/ Unity.Collections.FixedBytes16 offset2448;
            /*0x9b0*/ Unity.Collections.FixedBytes16 offset2464;
            /*0x9c0*/ Unity.Collections.FixedBytes16 offset2480;
            /*0x9d0*/ Unity.Collections.FixedBytes16 offset2496;
            /*0x9e0*/ Unity.Collections.FixedBytes16 offset2512;
            /*0x9f0*/ Unity.Collections.FixedBytes16 offset2528;
            /*0xa00*/ Unity.Collections.FixedBytes16 offset2544;
            /*0xa10*/ Unity.Collections.FixedBytes16 offset2560;
            /*0xa20*/ Unity.Collections.FixedBytes16 offset2576;
            /*0xa30*/ Unity.Collections.FixedBytes16 offset2592;
            /*0xa40*/ Unity.Collections.FixedBytes16 offset2608;
            /*0xa50*/ Unity.Collections.FixedBytes16 offset2624;
            /*0xa60*/ Unity.Collections.FixedBytes16 offset2640;
            /*0xa70*/ Unity.Collections.FixedBytes16 offset2656;
            /*0xa80*/ Unity.Collections.FixedBytes16 offset2672;
            /*0xa90*/ Unity.Collections.FixedBytes16 offset2688;
            /*0xaa0*/ Unity.Collections.FixedBytes16 offset2704;
            /*0xab0*/ Unity.Collections.FixedBytes16 offset2720;
            /*0xac0*/ Unity.Collections.FixedBytes16 offset2736;
            /*0xad0*/ Unity.Collections.FixedBytes16 offset2752;
            /*0xae0*/ Unity.Collections.FixedBytes16 offset2768;
            /*0xaf0*/ Unity.Collections.FixedBytes16 offset2784;
            /*0xb00*/ Unity.Collections.FixedBytes16 offset2800;
            /*0xb10*/ Unity.Collections.FixedBytes16 offset2816;
            /*0xb20*/ Unity.Collections.FixedBytes16 offset2832;
            /*0xb30*/ Unity.Collections.FixedBytes16 offset2848;
            /*0xb40*/ Unity.Collections.FixedBytes16 offset2864;
            /*0xb50*/ Unity.Collections.FixedBytes16 offset2880;
            /*0xb60*/ Unity.Collections.FixedBytes16 offset2896;
            /*0xb70*/ Unity.Collections.FixedBytes16 offset2912;
            /*0xb80*/ Unity.Collections.FixedBytes16 offset2928;
            /*0xb90*/ Unity.Collections.FixedBytes16 offset2944;
            /*0xba0*/ Unity.Collections.FixedBytes16 offset2960;
            /*0xbb0*/ Unity.Collections.FixedBytes16 offset2976;
            /*0xbc0*/ Unity.Collections.FixedBytes16 offset2992;
            /*0xbd0*/ Unity.Collections.FixedBytes16 offset3008;
            /*0xbe0*/ Unity.Collections.FixedBytes16 offset3024;
            /*0xbf0*/ Unity.Collections.FixedBytes16 offset3040;
            /*0xc00*/ Unity.Collections.FixedBytes16 offset3056;
            /*0xc10*/ Unity.Collections.FixedBytes16 offset3072;
            /*0xc20*/ Unity.Collections.FixedBytes16 offset3088;
            /*0xc30*/ Unity.Collections.FixedBytes16 offset3104;
            /*0xc40*/ Unity.Collections.FixedBytes16 offset3120;
            /*0xc50*/ Unity.Collections.FixedBytes16 offset3136;
            /*0xc60*/ Unity.Collections.FixedBytes16 offset3152;
            /*0xc70*/ Unity.Collections.FixedBytes16 offset3168;
            /*0xc80*/ Unity.Collections.FixedBytes16 offset3184;
            /*0xc90*/ Unity.Collections.FixedBytes16 offset3200;
            /*0xca0*/ Unity.Collections.FixedBytes16 offset3216;
            /*0xcb0*/ Unity.Collections.FixedBytes16 offset3232;
            /*0xcc0*/ Unity.Collections.FixedBytes16 offset3248;
            /*0xcd0*/ Unity.Collections.FixedBytes16 offset3264;
            /*0xce0*/ Unity.Collections.FixedBytes16 offset3280;
            /*0xcf0*/ Unity.Collections.FixedBytes16 offset3296;
            /*0xd00*/ Unity.Collections.FixedBytes16 offset3312;
            /*0xd10*/ Unity.Collections.FixedBytes16 offset3328;
            /*0xd20*/ Unity.Collections.FixedBytes16 offset3344;
            /*0xd30*/ Unity.Collections.FixedBytes16 offset3360;
            /*0xd40*/ Unity.Collections.FixedBytes16 offset3376;
            /*0xd50*/ Unity.Collections.FixedBytes16 offset3392;
            /*0xd60*/ Unity.Collections.FixedBytes16 offset3408;
            /*0xd70*/ Unity.Collections.FixedBytes16 offset3424;
            /*0xd80*/ Unity.Collections.FixedBytes16 offset3440;
            /*0xd90*/ Unity.Collections.FixedBytes16 offset3456;
            /*0xda0*/ Unity.Collections.FixedBytes16 offset3472;
            /*0xdb0*/ Unity.Collections.FixedBytes16 offset3488;
            /*0xdc0*/ Unity.Collections.FixedBytes16 offset3504;
            /*0xdd0*/ Unity.Collections.FixedBytes16 offset3520;
            /*0xde0*/ Unity.Collections.FixedBytes16 offset3536;
            /*0xdf0*/ Unity.Collections.FixedBytes16 offset3552;
            /*0xe00*/ Unity.Collections.FixedBytes16 offset3568;
            /*0xe10*/ Unity.Collections.FixedBytes16 offset3584;
            /*0xe20*/ Unity.Collections.FixedBytes16 offset3600;
            /*0xe30*/ Unity.Collections.FixedBytes16 offset3616;
            /*0xe40*/ Unity.Collections.FixedBytes16 offset3632;
            /*0xe50*/ Unity.Collections.FixedBytes16 offset3648;
            /*0xe60*/ Unity.Collections.FixedBytes16 offset3664;
            /*0xe70*/ Unity.Collections.FixedBytes16 offset3680;
            /*0xe80*/ Unity.Collections.FixedBytes16 offset3696;
            /*0xe90*/ Unity.Collections.FixedBytes16 offset3712;
            /*0xea0*/ Unity.Collections.FixedBytes16 offset3728;
            /*0xeb0*/ Unity.Collections.FixedBytes16 offset3744;
            /*0xec0*/ Unity.Collections.FixedBytes16 offset3760;
            /*0xed0*/ Unity.Collections.FixedBytes16 offset3776;
            /*0xee0*/ Unity.Collections.FixedBytes16 offset3792;
            /*0xef0*/ Unity.Collections.FixedBytes16 offset3808;
            /*0xf00*/ Unity.Collections.FixedBytes16 offset3824;
            /*0xf10*/ Unity.Collections.FixedBytes16 offset3840;
            /*0xf20*/ Unity.Collections.FixedBytes16 offset3856;
            /*0xf30*/ Unity.Collections.FixedBytes16 offset3872;
            /*0xf40*/ Unity.Collections.FixedBytes16 offset3888;
            /*0xf50*/ Unity.Collections.FixedBytes16 offset3904;
            /*0xf60*/ Unity.Collections.FixedBytes16 offset3920;
            /*0xf70*/ Unity.Collections.FixedBytes16 offset3936;
            /*0xf80*/ Unity.Collections.FixedBytes16 offset3952;
            /*0xf90*/ Unity.Collections.FixedBytes16 offset3968;
            /*0xfa0*/ Unity.Collections.FixedBytes16 offset3984;
            /*0xfb0*/ Unity.Collections.FixedBytes16 offset4000;
            /*0xfc0*/ Unity.Collections.FixedBytes16 offset4016;
            /*0xfd0*/ Unity.Collections.FixedBytes16 offset4032;
            /*0xfe0*/ Unity.Collections.FixedBytes16 offset4048;
            /*0xff0*/ Unity.Collections.FixedBytes16 offset4064;
            /*0x1000*/ byte byte4080;
            /*0x1001*/ byte byte4081;
            /*0x1002*/ byte byte4082;
            /*0x1003*/ byte byte4083;
            /*0x1004*/ byte byte4084;
            /*0x1005*/ byte byte4085;
            /*0x1006*/ byte byte4086;
            /*0x1007*/ byte byte4087;
            /*0x1008*/ byte byte4088;
            /*0x1009*/ byte byte4089;
            /*0x100a*/ byte byte4090;
            /*0x100b*/ byte byte4091;
            /*0x100c*/ byte byte4092;
            /*0x100d*/ byte byte4093;
        }

        struct FixedString4096
        {
        }

        struct FixedString4096Bytes : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            static ushort utf8MaxLengthInBytes = 4093;
            /*0x10*/ ushort utf8LengthInBytes;
            /*0x12*/ Unity.Collections.FixedBytes4094 bytes;

            static /*0x1164310*/ int get_UTF8MaxLengthInBytes();
            static /*0x1164460*/ bool op_Equality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1164720*/ bool op_Inequality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x11643c0*/ bool op_Equality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1164760*/ bool op_Inequality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1164500*/ bool op_Equality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1164700*/ bool op_Inequality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x11645a0*/ bool op_Equality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1164780*/ bool op_Inequality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1164320*/ bool op_Equality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1164740*/ bool op_Inequality(ref Unity.Collections.FixedString4096Bytes a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1164640*/ Unity.Collections.FixedString4096Bytes op_Implicit(string b);
            static /*0x1162f70*/ void CheckCopyError(Unity.Collections.CopyError error, string source);
            static /*0x1163010*/ void CheckFormatError(Unity.Collections.FormatError error);
            /*0x1164150*/ FixedString4096Bytes(string source);
            /*0x11641d0*/ FixedString4096Bytes(Unity.Collections.Unicode.Rune rune, int count);
            /*0x11640d0*/ FixedString4096Bytes(ref Unity.Collections.FixedString32Bytes other);
            /*0x1164250*/ FixedString4096Bytes(ref Unity.Collections.FixedString64Bytes other);
            /*0x1164110*/ FixedString4096Bytes(ref Unity.Collections.FixedString128Bytes other);
            /*0x11642d0*/ FixedString4096Bytes(ref Unity.Collections.FixedString512Bytes other);
            /*0x1164290*/ FixedString4096Bytes(ref Unity.Collections.FixedString4096Bytes other);
            /*0x1164010*/ string get_Value();
            /*0x1160780*/ byte* GetUnsafePtr();
            /*0x6bba60*/ int get_Length();
            /*0x1161510*/ void set_Length(int value);
            /*0x1164310*/ int get_Capacity();
            /*0x32d010*/ void set_Capacity(int value);
            /*0x1164050*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x1160f50*/ bool get_IsEmpty();
            /*0x1160f60*/ byte get_Item(int index);
            /*0x1161500*/ void set_Item(int index, byte value);
            /*0x11600f0*/ ref byte ElementAt(int index);
            /*0x115fef0*/ void Clear();
            /*0x115fa40*/ void Add(ref byte value);
            /*0x1163ad0*/ Unity.Collections.FixedString4096Bytes.Enumerator GetEnumerator();
            /*0x1163490*/ int CompareTo(string other);
            /*0x1163510*/ bool Equals(string other);
            /*0x1162e80*/ ref Unity.Collections.FixedList4096Bytes<byte> AsFixedList();
            /*0x1163f90*/ int Initialize(string source);
            /*0x1163d10*/ int Initialize(Unity.Collections.Unicode.Rune rune, int count);
            /*0x11633f0*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x1163e30*/ int Initialize(ref Unity.Collections.FixedString32Bytes other);
            /*0x1163a90*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x1163440*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x1163d80*/ int Initialize(ref Unity.Collections.FixedString64Bytes other);
            /*0x1163ab0*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x11633a0*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x1163bb0*/ int Initialize(ref Unity.Collections.FixedString128Bytes other);
            /*0x11635b0*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x1163300*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x1163c60*/ int Initialize(ref Unity.Collections.FixedString512Bytes other);
            /*0x11635d0*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x1163350*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x1163ee0*/ int Initialize(ref Unity.Collections.FixedString4096Bytes other);
            /*0x11634f0*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x1164010*/ string ToString();
            /*0x1163b70*/ int GetHashCode();
            /*0x11635f0*/ bool Equals(object obj);
            /*0x1163070*/ void CheckIndexInRange(int index);
            /*0x11631c0*/ void CheckLengthInRange(int length);
            /*0x1162eb0*/ void CheckCapacityInRange(int capacity);

            struct Enumerator : System.Collections.IEnumerator
            {
                /*0x10*/ Unity.Collections.FixedString4096Bytes target;
                /*0x1010*/ int offset;
                /*0x1014*/ Unity.Collections.Unicode.Rune current;

                /*0x115f580*/ Enumerator(Unity.Collections.FixedString4096Bytes other);
                /*0x32d010*/ void Dispose();
                /*0x115f230*/ bool MoveNext();
                /*0x115f330*/ void Reset();
                /*0x115f660*/ Unity.Collections.Unicode.Rune get_Current();
                /*0x115f360*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FixedStringMethods
        {
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, Unity.Collections.Unicode.Rune rune);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, char ch);
            static /*0x2a5510*/ Unity.Collections.FormatError AppendRawByte<T>(ref T fs, byte a);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, Unity.Collections.Unicode.Rune rune, int count);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, long input);
            static /*0x17cba0*/ Unity.Collections.FormatError Append<T>(ref T fs, int input);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, ulong input);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, uint input);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, float input, char decimalSeparator);
            static /*0x1779a0*/ Unity.Collections.FormatError Append<T, T2>(ref T fs, ref T2 input);
            static /*0x1779a0*/ Unity.Collections.CopyError CopyFrom<T, T2>(ref T fs, ref T2 input);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, byte* utf8Bytes, int utf8BytesLength);
            static /*0x1779a0*/ Unity.Collections.FormatError Append<T>(ref T fs, string s);
            static /*0x1779a0*/ Unity.Collections.CopyError CopyFrom<T>(ref T fs, string s);
            static /*0x177670*/ void CopyFromTruncated<T>(ref T fs, string s);
            static /*0x1824a0*/ void AppendFormat<T, U, T0>(ref T dest, ref U format, ref T0 arg0);
            static /*0x183be0*/ void AppendFormat<T, U, T0, T1>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1);
            static /*0x183e30*/ void AppendFormat<T, U, T0, T1, T2>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2);
            static /*0x184000*/ void AppendFormat<T, U, T0, T1, T2, T3>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3);
            static /*0x1841e0*/ void AppendFormat<T, U, T0, T1, T2, T3, T4>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, ref T4 arg4);
            static /*0x184350*/ void AppendFormat<T, U, T0, T1, T2, T3, T4, T5>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, ref T4 arg4, ref T5 arg5);
            static /*0x1844e0*/ void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, ref T4 arg4, ref T5 arg5, ref T6 arg6);
            static /*0x1846b0*/ void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, ref T4 arg4, ref T5 arg5, ref T6 arg6, ref T7 arg7);
            static /*0x1848a0*/ void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7, T8>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, ref T4 arg4, ref T5 arg5, ref T6 arg6, ref T7 arg7, ref T8 arg8);
            static /*0x184af0*/ void AppendFormat<T, U, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(ref T dest, ref U format, ref T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, ref T4 arg4, ref T5 arg5, ref T6 arg6, ref T7 arg7, ref T8 arg8, ref T9 arg9);
            static /*0x17f340*/ Unity.Collections.FormatError Append<T>(ref T fs, char a, char b);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, char a, char b, char c);
            static /*0x2a5510*/ Unity.Collections.FormatError Append<T>(ref T fs, char a, char b, char c, char d, char e, char f, char g, char h);
            static /*0x2a5510*/ Unity.Collections.FormatError AppendScientific<T>(ref T fs, char* source, int sourceLength, int decimalExponent, char decimalSeparator);
            static /*0x2a5510*/ bool Found<T>(ref T fs, ref int offset, char a, char b, char c);
            static /*0x2a5510*/ bool Found<T>(ref T fs, ref int offset, char a, char b, char c, char d, char e, char f, char g, char h);
            static /*0x2a5510*/ int IndexOf<T>(ref T fs, byte* bytes, int bytesLen);
            static /*0x2a5510*/ int IndexOf<T>(ref T fs, byte* bytes, int bytesLen, int startIndex, int distance);
            static /*0x1779a0*/ int IndexOf<T, T2>(ref T fs, ref T2 other);
            static /*0x17dee0*/ int IndexOf<T, T2>(ref T fs, ref T2 other, int startIndex, int distance);
            static /*0x1794f0*/ bool Contains<T, T2>(ref T fs, ref T2 other);
            static /*0x2a5510*/ int LastIndexOf<T>(ref T fs, byte* bytes, int bytesLen);
            static /*0x2a5510*/ int LastIndexOf<T>(ref T fs, byte* bytes, int bytesLen, int startIndex, int distance);
            static /*0x1779a0*/ int LastIndexOf<T, T2>(ref T fs, ref T2 other);
            static /*0x17dee0*/ int LastIndexOf<T, T2>(ref T fs, ref T2 other, int startIndex, int distance);
            static /*0x2a5510*/ int CompareTo<T>(ref T fs, byte* bytes, int bytesLen);
            static /*0x1779a0*/ int CompareTo<T, T2>(ref T fs, ref T2 other);
            static /*0x2a5510*/ bool Equals<T>(ref T fs, byte* bytes, int bytesLen);
            static /*0x1794f0*/ bool Equals<T, T2>(ref T fs, ref T2 other);
            static /*0x2a5510*/ Unity.Collections.Unicode.Rune Peek<T>(ref T fs, int index);
            static /*0x2a5510*/ Unity.Collections.Unicode.Rune Read<T>(ref T fs, ref int index);
            static /*0x2a5510*/ Unity.Collections.FormatError Write<T>(ref T fs, ref int index, Unity.Collections.Unicode.Rune rune);
            static /*0x17e030*/ string ConvertToString<T>(ref T fs);
            static /*0x17a070*/ int ComputeHashCode<T>(ref T fs);
            static /*0x17a070*/ int EffectiveSizeOf<T>(ref T fs);
            static /*0x17f7b0*/ bool ParseLongInternal<T>(ref T fs, ref int offset, ref long value);
            static /*0x17b660*/ Unity.Collections.ParseError Parse<T>(ref T fs, ref int offset, ref int output);
            static /*0x17b660*/ Unity.Collections.ParseError Parse<T>(ref T fs, ref int offset, ref uint output);
            static /*0x2a5510*/ Unity.Collections.ParseError Parse<T>(ref T fs, ref int offset, ref float output, char decimalSeparator);
        }

        class FixedString
        {
            static /*0x1167dd0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, int arg2, int arg3);
            static /*0x116a040*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, int arg2, int arg3);
            static /*0x116fb50*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, int arg3);
            static /*0x1168080*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, int arg2, int arg3);
            static /*0x116d1b0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, int arg2, int arg3);
            static /*0x116ab60*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, int arg3);
            static /*0x116aa00*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, int arg2, int arg3);
            static /*0x1168b90*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, int arg2, int arg3);
            static /*0x1168fe0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, int arg3);
            static /*0x116f2d0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, float arg2, int arg3);
            static /*0x11719c0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, float arg2, int arg3);
            static /*0x1171290*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, int arg3);
            static /*0x116f440*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, float arg2, int arg3);
            static /*0x1169c00*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, float arg2, int arg3);
            static /*0x116d540*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, int arg3);
            static /*0x1168e70*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, float arg2, int arg3);
            static /*0x116a740*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, float arg2, int arg3);
            static /*0x116e7a0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, int arg3);
            static /*0x1169d80*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, string arg2, int arg3);
            static /*0x116a320*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, string arg2, int arg3);
            static /*0x116a4a0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, int arg3);
            static /*0x1171400*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, string arg2, int arg3);
            static /*0x1169140*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, string arg2, int arg3);
            static /*0x1171580*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, int arg3);
            static /*0x116de10*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, string arg2, int arg3);
            static /*0x116bfd0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, string arg2, int arg3);
            static /*0x116f880*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, int arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, int arg3);
            static /*0x116b980*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, int arg2, float arg3);
            static /*0x1170900*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, int arg2, float arg3);
            static /*0x116dca0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, float arg3);
            static /*0x116d3d0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, int arg2, float arg3);
            static /*0x116af90*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, int arg2, float arg3);
            static /*0x1170440*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, float arg3);
            static /*0x116c580*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, int arg2, float arg3);
            static /*0x11688e0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, int arg2, float arg3);
            static /*0x116c290*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, float arg3);
            static /*0x116e910*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, float arg2, float arg3);
            static /*0x116c850*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, float arg2, float arg3);
            static /*0x11681f0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, float arg3);
            static /*0x1169960*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, float arg2, float arg3);
            static /*0x116e3c0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, float arg2, float arg3);
            static /*0x116d840*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, float arg3);
            static /*0x1170a70*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, float arg2, float arg3);
            static /*0x11697e0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, float arg2, float arg3);
            static /*0x1168770*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, float arg3);
            static /*0x116b570*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, string arg2, float arg3);
            static /*0x116ff10*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, string arg2, float arg3);
            static /*0x116cb40*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, float arg3);
            static /*0x116bd50*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, string arg2, float arg3);
            static /*0x116b3f0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, string arg2, float arg3);
            static /*0x116efc0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, float arg3);
            static /*0x116b810*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, string arg2, float arg3);
            static /*0x116c9d0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, string arg2, float arg3);
            static /*0x116ee50*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, float arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, float arg3);
            static /*0x116db40*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, int arg2, string arg3);
            static /*0x116d9c0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, int arg2, string arg3);
            static /*0x1169ee0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, string arg3);
            static /*0x1169660*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, int arg2, string arg3);
            static /*0x116d6c0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, int arg2, string arg3);
            static /*0x116cec0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, string arg3);
            static /*0x116f5b0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, int arg2, string arg3);
            static /*0x11685f0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, int arg2, string arg3);
            static /*0x1167f20*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, string arg3);
            static /*0x116ace0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, float arg2, string arg3);
            static /*0x116c400*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, float arg2, string arg3);
            static /*0x1170d30*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, string arg3);
            static /*0x1167c50*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, float arg2, string arg3);
            static /*0x1170ea0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, float arg2, string arg3);
            static /*0x116a1b0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, string arg3);
            static /*0x116f9e0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, float arg2, string arg3);
            static /*0x116d040*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, float arg2, string arg3);
            static /*0x116b110*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, string arg3);
            static /*0x116c6f0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, string arg2, string arg3);
            static /*0x116ecd0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, string arg2, string arg3);
            static /*0x116ccb0*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, string arg3);
            static /*0x1171700*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, string arg2, string arg3);
            static /*0x1171120*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, string arg2, string arg3);
            static /*0x116f710*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, string arg3);
            static /*0x1168d10*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, string arg2, string arg3);
            static /*0x116b280*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, string arg2, string arg3);
            static /*0x116ea80*/ Unity.Collections.FixedString512Bytes Format(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, string arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, int arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, int arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, int arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, int arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, int arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, int arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, int arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, int arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, float arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, float arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, float arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, float arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, float arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, float arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, float arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, float arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, string arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, string arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, string arg2, T1 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, string arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, string arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, string arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, string arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, string arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, int arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, int arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, int arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, int arg1, T2 arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, float arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, float arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, float arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, float arg1, T2 arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, int arg0, string arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, float arg0, string arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2>(Unity.Collections.FixedString512Bytes formatString, string arg0, string arg1, T1 arg2, T2 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, string arg1, T2 arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, int arg0, T1 arg1, T2 arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, float arg0, T1 arg1, T2 arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3>(Unity.Collections.FixedString512Bytes formatString, string arg0, T1 arg1, T2 arg2, T3 arg3);
            static /*0x2a5510*/ Unity.Collections.FixedString512Bytes Format<T1, T2, T3, T4>(Unity.Collections.FixedString512Bytes formatString, T1 arg0, T2 arg1, T3 arg2, T4 arg3);
            static /*0x1169ae0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, int arg1, int arg2);
            static /*0x11693f0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, int arg1, int arg2);
            static /*0x116fde0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, int arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, int arg1, int arg2);
            static /*0x1168a60*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, float arg1, int arg2);
            static /*0x1170090*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, float arg1, int arg2);
            static /*0x1169520*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, float arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, float arg1, int arg2);
            static /*0x116e530*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, string arg1, int arg2);
            static /*0x1171880*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, string arg1, int arg2);
            static /*0x116bc20*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, string arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, string arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, T1 arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, T1 arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, T1 arg1, int arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, T2 arg1, int arg2);
            static /*0x116baf0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, int arg1, float arg2);
            static /*0x116e280*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, int arg1, float arg2);
            static /*0x1168370*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, int arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, int arg1, float arg2);
            static /*0x1170bf0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, float arg1, float arg2);
            static /*0x116a8c0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, float arg1, float arg2);
            static /*0x116e660*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, float arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, float arg1, float arg2);
            static /*0x11705c0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, string arg1, float arg2);
            static /*0x11684b0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, string arg1, float arg2);
            static /*0x1170310*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, string arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, string arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, T1 arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, T1 arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, T1 arg1, float arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, T2 arg1, float arg2);
            static /*0x11692c0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, int arg1, string arg2);
            static /*0x116a600*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, int arg1, string arg2);
            static /*0x116fcb0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, int arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, int arg1, string arg2);
            static /*0x11701d0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, float arg1, string arg2);
            static /*0x116ae50*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, float arg1, string arg2);
            static /*0x1171b30*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, float arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, float arg1, string arg2);
            static /*0x116b6e0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, string arg1, string arg2);
            static /*0x116c150*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, string arg1, string arg2);
            static /*0x116df70*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, string arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, string arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, T1 arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, T1 arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, T1 arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, T2 arg1, string arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, int arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, int arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, int arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, int arg1, T2 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, float arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, float arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, float arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, float arg1, T2 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, string arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, string arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, string arg1, T1 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, string arg1, T2 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, int arg0, T1 arg1, T2 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, float arg0, T1 arg1, T2 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, string arg0, T1 arg1, T2 arg2);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2, T3>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, T2 arg1, T3 arg2);
            static /*0x116f130*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, int arg1);
            static /*0x1170700*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, int arg1);
            static /*0x116ebe0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, int arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, int arg1);
            static /*0x116bed0*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, float arg1);
            static /*0x116e180*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, float arg1);
            static /*0x1171020*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, float arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, float arg1);
            static /*0x1167b60*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0, string arg1);
            static /*0x1170800*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0, string arg1);
            static /*0x116e090*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0, string arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, string arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, int arg0, T1 arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, float arg0, T1 arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, string arg0, T1 arg1);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1, T2>(Unity.Collections.FixedString128Bytes formatString, T1 arg0, T2 arg1);
            static /*0x116d320*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, int arg0);
            static /*0x116ce10*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, float arg0);
            static /*0x116f220*/ Unity.Collections.FixedString128Bytes Format(Unity.Collections.FixedString128Bytes formatString, string arg0);
            static /*0x2a5510*/ Unity.Collections.FixedString128Bytes Format<T1>(Unity.Collections.FixedString128Bytes formatString, T1 arg0);
        }

        interface IUTF8Bytes
        {
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x2a5510*/ byte* GetUnsafePtr();
            bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
        }

        class FixedStringUtils
        {
            static /*0x1173df0*/ Unity.Collections.ParseError Base10ToBase2(ref float output, ulong mantissa10, int exponent10);
            static /*0x1173f30*/ void Base2ToBase10(ref ulong mantissa10, ref int exponent10, float input);

            struct UintFloatUnion
            {
                /*0x10*/ uint uintValue;
                /*0x10*/ float floatValue;
            }
        }

        struct HeapString : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, System.IDisposable, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.HeapString>, System.IEquatable<Unity.Collections.HeapString>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            /*0x10*/ Unity.Collections.NativeList<byte> m_Data;

            static /*0x1176c10*/ bool op_Equality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1176d50*/ bool op_Inequality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x11768b0*/ bool op_Equality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1176d30*/ bool op_Inequality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1176790*/ bool op_Equality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1176db0*/ bool op_Inequality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1176af0*/ bool op_Equality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1176d90*/ bool op_Inequality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x11769d0*/ bool op_Equality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1176d70*/ bool op_Inequality(ref Unity.Collections.HeapString a, ref Unity.Collections.FixedString4096Bytes b);
            /*0x1176240*/ HeapString(string source, Unity.Collections.Allocator allocator);
            /*0x1175de0*/ HeapString(int capacity, Unity.Collections.Allocator allocator);
            /*0x1176440*/ HeapString(Unity.Collections.Allocator allocator);
            /*0x1175cb0*/ HeapString(ref Unity.Collections.FixedString32Bytes source, Unity.Collections.Allocator allocator);
            /*0x1176500*/ HeapString(ref Unity.Collections.FixedString64Bytes source, Unity.Collections.Allocator allocator);
            /*0x1176110*/ HeapString(ref Unity.Collections.FixedString128Bytes source, Unity.Collections.Allocator allocator);
            /*0x1175eb0*/ HeapString(ref Unity.Collections.FixedString512Bytes source, Unity.Collections.Allocator allocator);
            /*0x1175fe0*/ HeapString(ref Unity.Collections.FixedString4096Bytes source, Unity.Collections.Allocator allocator);
            /*0x1176740*/ int get_Length();
            /*0x1176e80*/ void set_Length(int value);
            /*0x1176630*/ int get_Capacity();
            /*0x1176dd0*/ void set_Capacity(int value);
            /*0x1175c40*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x11766b0*/ bool get_IsEmpty();
            /*0x1176670*/ bool get_IsCreated();
            /*0x1175ae0*/ byte* GetUnsafePtr();
            /*0x11766f0*/ byte get_Item(int index);
            /*0x1176e20*/ void set_Item(int index, byte value);
            /*0x1175500*/ ref byte ElementAt(int index);
            /*0x1175240*/ void Clear();
            /*0x1174fe0*/ void Add(ref byte value);
            /*0x11752b0*/ int CompareTo(Unity.Collections.HeapString other);
            /*0x11755b0*/ bool Equals(Unity.Collections.HeapString other);
            /*0x11754c0*/ void Dispose();
            /*0x1176780*/ string get_Value();
            /*0x1175a80*/ Unity.Collections.HeapString.Enumerator GetEnumerator();
            /*0x1175490*/ int CompareTo(string other);
            /*0x1175620*/ bool Equals(string other);
            /*0x11753f0*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x1175600*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x11753a0*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x1175590*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x1175300*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x1175550*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x1175350*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x1175a60*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x1175440*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x1175570*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x1175bc0*/ string ToString();
            /*0x1175aa0*/ int GetHashCode();
            /*0x1175650*/ bool Equals(object other);
            /*0x11750c0*/ void CheckIndexInRange(int index);
            /*0x1175b30*/ void ThrowCopyError(Unity.Collections.CopyError error, string source);

            struct Enumerator : System.Collections.Generic.IEnumerator<Unity.Collections.Unicode.Rune>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ Unity.Collections.HeapString target;
                /*0x20*/ int offset;
                /*0x24*/ Unity.Collections.Unicode.Rune current;

                /*0x1173de0*/ Enumerator(Unity.Collections.HeapString source);
                /*0x32d010*/ void Dispose();
                /*0x1173c30*/ bool MoveNext();
                /*0x1173d20*/ void Reset();
                /*0x1173d80*/ object System.Collections.IEnumerator.get_Current();
                /*0x70a440*/ Unity.Collections.Unicode.Rune get_Current();
            }
        }

        class ListExtensions
        {
            static /*0x2a5510*/ bool RemoveSwapBack<T>(System.Collections.Generic.List<T> list, T value);
            static /*0x1794f0*/ bool RemoveSwapBack<T>(System.Collections.Generic.List<T> list, System.Predicate<T> matcher);
            static /*0x1827f0*/ void RemoveAtSwapBack<T>(System.Collections.Generic.List<T> list, int index);
            static /*0x2a5510*/ Unity.Collections.NativeList<T> ToNativeList<T>(System.Collections.Generic.List<T> list, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray<T>(System.Collections.Generic.List<T> list, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
        }

        struct Memory
        {
            static long k_MaximumRamSizeInBytes = 1099511627776;

            static /*0x11771b0*/ void CheckByteCountIsReasonable(long size);

            struct Unmanaged
            {
                static /*0x117ec60*/ void* Allocate(long size, int align, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                static /*0x117ec90*/ void Free(void* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                static /*0x2a5510*/ T* Allocate<T>(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                static /*0x2a5510*/ void Free<T>(T* pointer, Unity.Collections.AllocatorManager.AllocatorHandle allocator);

                struct Array
                {
                    static /*0x115bd10*/ bool IsCustom(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x1173900*/ void* CustomResize(void* oldPointer, long oldCount, long newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, long size, int align);
                    static /*0x11739d0*/ void* Resize(void* oldPointer, long oldCount, long newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator, long size, int align);
                    static /*0x2a5510*/ T* Resize<T>(T* oldPointer, long oldCount, long newCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x2a5510*/ T* Allocate<T>(long count, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x2a5510*/ void Free<T>(T* pointer, long count, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                }
            }

            struct Array
            {
                static /*0x2a5510*/ void Set<T>(T* pointer, long count, T t);
                static /*0x2a5510*/ void Clear<T>(T* pointer, long count);
                static /*0x2a5510*/ void Copy<T>(T* dest, T* src, long count);
            }
        }

        class NativeArrayExtensions
        {
            static /*0x2a5510*/ bool Contains<T, U>(Unity.Collections.NativeArray<T> array, U value);
            static /*0x2a5510*/ int IndexOf<T, U>(Unity.Collections.NativeArray<T> array, U value);
            static /*0x2a5510*/ bool Contains<T, U>(Unity.Collections.NativeArray.ReadOnly<T> array, U value);
            static /*0x2a5510*/ int IndexOf<T, U>(Unity.Collections.NativeArray.ReadOnly<T> array, U value);
            static /*0x2a5510*/ bool Contains<T, U>(Unity.Collections.NativeList<T> list, U value);
            static /*0x2a5510*/ int IndexOf<T, U>(Unity.Collections.NativeList<T> list, U value);
            static /*0x2a5510*/ bool Contains<T, U>(void* ptr, int length, U value);
            static /*0x2a5510*/ int IndexOf<T, U>(void* ptr, int length, U value);
            static /*0x2a5510*/ Unity.Collections.NativeArray<U> Reinterpret<T, U>(Unity.Collections.NativeArray<T> array);
            static /*0x2a5510*/ bool ArraysEqual<T>(Unity.Collections.NativeArray<T> array, Unity.Collections.NativeArray<T> other);
            static /*0x2a5510*/ bool ArraysEqual<T>(Unity.Collections.NativeList<T> array, Unity.Collections.NativeArray<T> other);
            static /*0x177be0*/ void CheckReinterpretSize<T, U>(ref Unity.Collections.NativeArray<T> array);
            static /*0x2a5510*/ void Initialize<T>(ref Unity.Collections.NativeArray<T> array, int length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
            static /*0x2a5510*/ void Initialize<T, U>(ref Unity.Collections.NativeArray<T> array, int length, ref U allocator, Unity.Collections.NativeArrayOptions options);

            struct NativeArrayStaticId<T>
            {
                static /*0x0*/ Unity.Burst.SharedStatic<int> s_staticSafetyId;

                static /*0x180ff0*/ NativeArrayStaticId();
            }
        }

        struct NativeBitArray : Unity.Collections.INativeDisposable, System.IDisposable
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeBitArray m_BitArray;

            /*0x11774d0*/ NativeBitArray(int numBits, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
            /*0x11774d0*/ NativeBitArray(int numBits, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options, int disposeSentinelStackDepth);
            /*0xb73aa0*/ bool get_IsCreated();
            /*0x1177370*/ void Dispose();
            /*0x1177330*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0xd05380*/ int get_Length();
            /*0x11772a0*/ void Clear();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> AsNativeArray<T>();
            /*0x1177420*/ void Set(int pos, bool value);
            /*0x1177400*/ void SetBits(int pos, bool value, int numBits);
            /*0x1177410*/ void SetBits(int pos, ulong value, int numBits);
            /*0x11773d0*/ ulong GetBits(int pos, int numBits);
            /*0x11773e0*/ bool IsSet(int pos);
            /*0x11772f0*/ void Copy(int dstPos, int srcPos, int numBits);
            /*0x11772e0*/ void Copy(int dstPos, ref Unity.Collections.NativeBitArray srcBitArray, int srcPos, int numBits);
            /*0x1177380*/ int Find(int pos, int numBits);
            /*0x11773b0*/ int Find(int pos, int count, int numBits);
            /*0x11774c0*/ bool TestNone(int pos, int numBits);
            /*0x11774b0*/ bool TestAny(int pos, int numBits);
            /*0x11774a0*/ bool TestAll(int pos, int numBits);
            /*0x1177320*/ int CountBits(int pos, int numBits);
            /*0x32d010*/ void CheckRead();
            /*0x180fc0*/ void CheckReadBounds<T>();
            /*0x32d010*/ void CheckWrite();
        }

        struct NativeKeyValueArrays<TKey, TValue> : Unity.Collections.INativeDisposable, System.IDisposable
        {
            /*0x0*/ Unity.Collections.NativeArray<TKey> Keys;
            /*0x0*/ Unity.Collections.NativeArray<TValue> Values;

            /*0x2a5510*/ NativeKeyValueArrays(int length, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
            /*0x180980*/ int get_Length();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
        }

        struct NativeHashMap<TKey, TValue> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<TKey, TValue> m_HashMapData;

            /*0x2a5510*/ NativeHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ NativeHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int Count();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool TryAdd(TKey key, TValue item);
            /*0x2a5510*/ void Add(TKey key, TValue item);
            /*0x2a5510*/ bool Remove(TKey key);
            /*0x2a5510*/ bool TryGetValue(TKey key, ref TValue item);
            /*0x2a5510*/ bool ContainsKey(TKey key);
            /*0x2a5510*/ TValue get_Item(TKey key);
            /*0x2a5510*/ void set_Item(TKey key, TValue value);
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x2a5510*/ Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeHashMap.ParallelWriter<TKey, TValue> AsParallelWriter();
            /*0x2a5510*/ Unity.Collections.NativeHashMap.Enumerator<TKey, TValue> GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x180fc0*/ void CheckRead();
            /*0x180fc0*/ void CheckWrite();
            /*0x2a5510*/ void ThrowKeyNotPresent(TKey key);
            /*0x2a5510*/ void ThrowKeyAlreadyAdded(TKey key);

            struct ParallelWriter<TKey, TValue>
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap.ParallelWriter<TKey, TValue> m_Writer;

                /*0x180980*/ int get_m_ThreadIndex();
                /*0x180980*/ int get_Capacity();
                /*0x2a5510*/ bool TryAdd(TKey key, TValue item);
            }

            struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataEnumerator m_Enumerator;

                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeHashMapDebuggerTypeProxy<TKey, TValue>
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<TKey, TValue> m_Target;

            /*0x2a5510*/ NativeHashMapDebuggerTypeProxy(Unity.Collections.NativeHashMap<TKey, TValue> target);
            /*0x1803b0*/ System.Collections.Generic.List<Unity.Collections.Pair<TKey, TValue>> get_Items();
        }

        class NativeHashMapExtensions
        {
            static /*0x2a5510*/ int Unique<T>(Unity.Collections.NativeArray<T> array);
            static /*0x2a5510*/ System.ValueTuple<Unity.Collections.NativeArray<TKey>, int> GetUniqueKeyArray<TKey, TValue>(Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> container, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x2a5510*/ System.ValueTuple<Unity.Collections.NativeArray<TKey>, int> GetUniqueKeyArray<TKey, TValue>(Unity.Collections.NativeMultiHashMap<TKey, TValue> container, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapBucketData GetBucketData<TKey, TValue>(Unity.Collections.NativeHashMap<TKey, TValue> container);
            static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapBucketData GetUnsafeBucketData<TKey, TValue>(Unity.Collections.NativeHashMap<TKey, TValue> container);
            static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapBucketData GetUnsafeBucketData<TKey, TValue>(Unity.Collections.NativeMultiHashMap<TKey, TValue> container);
            static /*0x2a5510*/ void Remove<TKey, TValue>(Unity.Collections.NativeMultiHashMap<TKey, TValue> container, TKey key, TValue value);
        }

        struct NativeHashSet<T> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.NativeHashMap<T, bool> m_Data;

            /*0x2a5510*/ NativeHashSet(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int Count();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Add(T item);
            /*0x2a5510*/ bool Remove(T item);
            /*0x2a5510*/ bool Contains(T item);
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeHashSet.ParallelWriter<T> AsParallelWriter();
            /*0x2a5510*/ Unity.Collections.NativeHashSet.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            struct ParallelWriter<T>
            {
                /*0x0*/ Unity.Collections.NativeHashMap.ParallelWriter<T, bool> m_Data;

                /*0x180980*/ int get_Capacity();
                /*0x2a5510*/ bool Add(T item);
            }

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataEnumerator m_Enumerator;

                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeHashSetDebuggerTypeProxy<T>
        {
            /*0x0*/ Unity.Collections.NativeHashSet<T> Data;

            /*0x2a5510*/ NativeHashSetDebuggerTypeProxy(Unity.Collections.NativeHashSet<T> data);
            /*0x1803b0*/ System.Collections.Generic.List<T> get_Items();
        }

        class HashSetExtensions
        {
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList128Bytes<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList128Bytes<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList128Bytes<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList32Bytes<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList32Bytes<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList32Bytes<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList4096Bytes<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList4096Bytes<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList4096Bytes<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList512Bytes<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList512Bytes<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList512Bytes<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList64Bytes<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList64Bytes<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.FixedList64Bytes<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeArray<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeArray<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeArray<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeHashSet<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeHashSet<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeHashSet<T> other);
            static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeList<T> other);
            static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeList<T> other);
            static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.NativeList<T> other);
        }

        interface IIndexable<T>
        {
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x184ab0*/ ref T ElementAt(int index);
        }

        interface INativeList<T> : Unity.Collections.IIndexable<T>
        {
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x180fc0*/ void Clear();
        }

        struct NativeList<T> : Unity.Collections.INativeDisposable, System.IDisposable, Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> m_ListData;
            /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_DeprecatedAllocator;

            static /*0x2a5510*/ Unity.Collections.NativeList<T> New<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth);
            static /*0x2a5510*/ Unity.Collections.NativeList<T> New<U>(int initialCapacity, ref U allocator);
            static /*0x2a5510*/ Unity.Collections.NativeArray<T> op_Implicit(Unity.Collections.NativeList<T> nativeList);
            static /*0x1784c0*/ void CheckInitialCapacity(int initialCapacity);
            static /*0x2a5510*/ void CheckTotalSize(int initialCapacity, long totalSize);
            static /*0x1785d0*/ void CheckSufficientCapacity(int capacity, int length);
            static /*0x1785d0*/ void CheckIndexInRange(int value, int length);
            static /*0x1784c0*/ void CheckArgPositive(int value);
            /*0x2a5510*/ NativeList(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ NativeList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ NativeList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
            /*0x2a5510*/ void Initialize<U>(int initialCapacity, ref U allocator, int disposeSentinelStackDepth);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ ref T ElementAt(int index);
            /*0x180980*/ int get_Length();
            /*0x17aa40*/ void set_Length(int value);
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> GetUnsafeList();
            /*0x2a5510*/ void AddNoResize(T value);
            /*0x2a5510*/ void AddRangeNoResize(void* ptr, int count);
            /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.NativeList<T> list);
            /*0x17aec0*/ void Add(ref T value);
            /*0x2a5510*/ void AddRange(Unity.Collections.NativeArray<T> array);
            /*0x2a5510*/ void AddRange(void* ptr, int count);
            /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAtSwapBack(int index);
            /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
            /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1817d0*/ void RemoveRange(int index, int count);
            /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x17aec0*/ void Dispose<U>(ref U allocator);
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> AsArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> AsDeferredJobArray();
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeArray.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x17aec0*/ void CopyFrom(T[] array);
            /*0x2a5510*/ void CopyFrom(Unity.Collections.NativeArray<T> array);
            /*0x1817d0*/ void Resize(int length, Unity.Collections.NativeArrayOptions options);
            /*0x17aa40*/ void ResizeUninitialized(int length);
            /*0x17aa40*/ void SetCapacity(int capacity);
            /*0x180fc0*/ void TrimExcess();
            /*0x2a5510*/ Unity.Collections.NativeArray.ReadOnly<T> AsParallelReader();
            /*0x2a5510*/ Unity.Collections.NativeList.ParallelWriter<T> AsParallelWriter();
            /*0x2a5510*/ void CheckHandleMatches(Unity.Collections.AllocatorManager.AllocatorHandle handle);

            struct ParallelWriter<T>
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> ListData;

                /*0x2a5510*/ ParallelWriter(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> listData);
                /*0x2a5510*/ void* get_Ptr();
                /*0x2a5510*/ void AddNoResize(T value);
                /*0x2a5510*/ void AddRangeNoResize(void* ptr, int count);
                /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list);
                /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.NativeList<T> list);
            }
        }

        struct NativeListDispose
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* m_ListData;

            /*0x1177510*/ void Dispose();
        }

        struct NativeListDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeListDispose Data;

            /*0x1177510*/ void Execute();
        }

        class NativeListDebugView<T>
        {
            /*0x0*/ Unity.Collections.NativeList<T> m_Array;

            /*0x2a5510*/ NativeListDebugView(Unity.Collections.NativeList<T> array);
            /*0x1803b0*/ T[] get_Items();
        }

        struct NativeMultiHashMapIterator<TKey>
        {
            /*0x0*/ TKey key;
            /*0x0*/ int NextEntryIndex;
            /*0x0*/ int EntryIndex;

            /*0x180980*/ int GetEntryIndex();
        }

        struct NativeMultiHashMap<TKey, TValue> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> m_MultiHashMapData;

            /*0x2a5510*/ NativeMultiHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ NativeMultiHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
            /*0x2a5510*/ void Initialize<U>(int capacity, ref U allocator, int disposeSentinelStackDepth);
            /*0x17cb40*/ bool get_IsEmpty();
            /*0x180980*/ int Count();
            /*0x180980*/ int get_Capacity();
            /*0x17aa40*/ void set_Capacity(int value);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ void Add(TKey key, TValue item);
            /*0x2a5510*/ int Remove(TKey key);
            /*0x2a5510*/ void Remove(Unity.Collections.NativeMultiHashMapIterator<TKey> it);
            /*0x2a5510*/ bool TryGetFirstValue(TKey key, ref TValue item, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it);
            bool TryGetNextValue(ref TValue item, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it);
            /*0x2a5510*/ bool ContainsKey(TKey key);
            /*0x2a5510*/ int CountValuesForKey(TKey key);
            /*0x2a5510*/ bool SetValue(TValue item, Unity.Collections.NativeMultiHashMapIterator<TKey> it);
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x2a5510*/ Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ Unity.Collections.NativeMultiHashMap.ParallelWriter<TKey, TValue> AsParallelWriter();
            /*0x2a5510*/ Unity.Collections.NativeMultiHashMap.Enumerator<TKey, TValue> GetValuesForKey(TKey key);
            /*0x2a5510*/ Unity.Collections.NativeMultiHashMap.KeyValueEnumerator<TKey, TValue> GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x180fc0*/ void CheckRead();
            /*0x180fc0*/ void CheckWrite();

            struct ParallelWriter<TKey, TValue>
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap.ParallelWriter<TKey, TValue> m_Writer;

                /*0x180980*/ int get_m_ThreadIndex();
                /*0x180980*/ int get_Capacity();
                /*0x2a5510*/ void Add(TKey key, TValue item);
            }

            struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeMultiHashMap<TKey, TValue> hashmap;
                /*0x0*/ TKey key;
                /*0x0*/ bool isFirst;
                /*0x0*/ TValue value;
                /*0x0*/ Unity.Collections.NativeMultiHashMapIterator<TKey> iterator;

                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ TValue get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x2a5510*/ Unity.Collections.NativeMultiHashMap.Enumerator<TKey, TValue> GetEnumerator();
            }

            struct KeyValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataEnumerator m_Enumerator;

                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeMultiHashMapDebuggerTypeProxy<TKey, TValue>
        {
            /*0x0*/ Unity.Collections.NativeMultiHashMap<TKey, TValue> m_Target;

            /*0x2a5510*/ NativeMultiHashMapDebuggerTypeProxy(Unity.Collections.NativeMultiHashMap<TKey, TValue> target);
            /*0x1803b0*/ System.Collections.Generic.List<Unity.Collections.ListPair<TKey, System.Collections.Generic.List<TValue>>> get_Items();
        }

        class NativeMultiHashMapExtensions
        {
            static /*0x2a5510*/ void Initialize<TKey, TValue, U>(ref Unity.Collections.NativeMultiHashMap<TKey, TValue> nativeMultiHashMap, int capacity, ref U allocator, int disposeSentinelStackDepth);
        }

        struct NativeQueueBlockHeader
        {
            /*0x10*/ Unity.Collections.NativeQueueBlockHeader* m_NextBlock;
            /*0x18*/ int m_NumItems;
        }

        struct NativeQueueBlockPoolData
        {
            static int m_BlockSize = 16384;
            /*0x10*/ nint m_FirstBlock;
            /*0x18*/ int m_NumBlocks;
            /*0x1c*/ int m_MaxBlocks;
            /*0x20*/ int m_AllocLock;

            /*0x1177550*/ Unity.Collections.NativeQueueBlockHeader* AllocateBlock();
            /*0x11776f0*/ void FreeBlock(Unity.Collections.NativeQueueBlockHeader* block);
        }

        class NativeQueueBlockPool
        {
            static /*0x0*/ Unity.Burst.SharedStatic<nint> Data;

            static /*0x1177cd0*/ NativeQueueBlockPool();
            static /*0x1177890*/ Unity.Collections.NativeQueueBlockPoolData* GetQueueBlockPool();
            static /*0x1177800*/ void AppDomainOnDomainUnload();
            static /*0x1177bb0*/ void OnDomainUnload(object sender, System.EventArgs e);
            /*0x32f970*/ NativeQueueBlockPool();
        }

        struct NativeQueueData
        {
            /*0x10*/ nint m_FirstBlock;
            /*0x18*/ nint m_LastBlock;
            /*0x20*/ int m_MaxItems;
            /*0x24*/ int m_CurrentRead;
            /*0x28*/ byte* m_CurrentWriteBlockTLS;

            static /*0x2a5510*/ Unity.Collections.NativeQueueBlockHeader* AllocateWriteBlockMT<T>(Unity.Collections.NativeQueueData* data, Unity.Collections.NativeQueueBlockPoolData* pool, int threadIndex);
            static /*0x2a5510*/ void AllocateQueue<T>(Unity.Collections.AllocatorManager.AllocatorHandle label, ref Unity.Collections.NativeQueueData* outBuf);
            static /*0x1177d30*/ void DeallocateQueue(Unity.Collections.NativeQueueData* data, Unity.Collections.NativeQueueBlockPoolData* pool, Unity.Collections.AllocatorManager.AllocatorHandle allocation);
            /*0x1177eb0*/ Unity.Collections.NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex);
            /*0x1177ec0*/ void SetCurrentWriteBlockTLS(int threadIndex, Unity.Collections.NativeQueueBlockHeader* currentWriteBlock);
        }

        struct NativeQueue<T> : Unity.Collections.INativeDisposable, System.IDisposable
        {
            /*0x0*/ Unity.Collections.NativeQueueData* m_Buffer;
            /*0x0*/ Unity.Collections.NativeQueueBlockPoolData* m_QueuePool;
            /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            static /*0x1809b0*/ int get_PersistentMemoryBlockCount();
            static /*0x1784c0*/ void set_PersistentMemoryBlockCount(int value);
            static /*0x1809b0*/ int get_MemoryBlockSize();
            static /*0x180ff0*/ void ThrowEmpty();
            /*0x2a5510*/ NativeQueue(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x17cb40*/ bool IsEmpty();
            /*0x180980*/ int get_Count();
            /*0x2a5510*/ T Peek();
            /*0x2a5510*/ void Enqueue(T value);
            /*0x2a5510*/ T Dequeue();
            /*0x17e620*/ bool TryDequeue(ref T item);
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x180fc0*/ void Clear();
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x2a5510*/ Unity.Collections.NativeQueue.ParallelWriter<T> AsParallelWriter();
            /*0x180fc0*/ void CheckRead();
            /*0x180fc0*/ void CheckReadNotEmpty();
            /*0x180fc0*/ void CheckWrite();

            struct ParallelWriter<T>
            {
                /*0x0*/ Unity.Collections.NativeQueueData* m_Buffer;
                /*0x0*/ Unity.Collections.NativeQueueBlockPoolData* m_QueuePool;
                /*0x0*/ int m_ThreadIndex;

                /*0x2a5510*/ void Enqueue(T value);
            }
        }

        struct NativeQueueDispose
        {
            /*0x10*/ Unity.Collections.NativeQueueData* m_Buffer;
            /*0x18*/ Unity.Collections.NativeQueueBlockPoolData* m_QueuePool;
            /*0x20*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            /*0x1177ee0*/ void Dispose();
        }

        struct NativeQueueDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeQueueDispose Data;

            /*0x1177ed0*/ void Execute();
        }

        struct NativeReference<T> : Unity.Collections.INativeDisposable, System.IDisposable, System.IEquatable<Unity.Collections.NativeReference<T>>
        {
            /*0x0*/ void* m_Data;
            /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            static /*0x2a5510*/ void Allocate(Unity.Collections.AllocatorManager.AllocatorHandle allocator, ref Unity.Collections.NativeReference<T> reference);
            static /*0x2a5510*/ bool op_Equality(Unity.Collections.NativeReference<T> left, Unity.Collections.NativeReference<T> right);
            static /*0x2a5510*/ bool op_Inequality(Unity.Collections.NativeReference<T> left, Unity.Collections.NativeReference<T> right);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeReference<T> dst, Unity.Collections.NativeReference<T> src);
            /*0x2a5510*/ NativeReference(Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
            /*0x2a5510*/ NativeReference(T value, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x2a5510*/ T get_Value();
            /*0x2a5510*/ void set_Value(T value);
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x2a5510*/ void CopyFrom(Unity.Collections.NativeReference<T> reference);
            /*0x2a5510*/ void CopyTo(Unity.Collections.NativeReference<T> reference);
            /*0x2a5510*/ bool Equals(Unity.Collections.NativeReference<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x180980*/ int GetHashCode();
            /*0x2a5510*/ Unity.Collections.NativeReference.ReadOnly<T> AsReadOnly();
            /*0x180fc0*/ void CheckNotDisposed();

            struct ReadOnly<T>
            {
                /*0x0*/ void* m_Data;

                /*0x2a5510*/ ReadOnly(void* data);
                /*0x2a5510*/ T get_Value();
            }
        }

        struct NativeReferenceDispose
        {
            /*0x10*/ void* m_Data;
            /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

            /*0x1177f90*/ void Dispose();
        }

        struct NativeReferenceDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeReferenceDispose Data;

            /*0x1177f80*/ void Execute();
        }

        class NativeSortExtension
        {
            static int k_IntrosortSizeThreshold = 16;

            static /*0x2a5510*/ void Sort<T>(T* array, int length);
            static /*0x2a5510*/ void Sort<T, U>(T* array, int length, U comp);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T>(T* array, int length, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(T* array, int length);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T, U>(T* array, int length, U comp, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(T* array, int length, U comp);
            static /*0x2a5510*/ int BinarySearch<T>(T* ptr, int length, T value);
            static /*0x2a5510*/ int BinarySearch<T, U>(T* ptr, int length, T value, U comp);
            static /*0x2a5510*/ void Sort<T>(Unity.Collections.NativeArray<T> array);
            static /*0x2a5510*/ void Sort<T, U>(Unity.Collections.NativeArray<T> array, U comp);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T>(Unity.Collections.NativeArray<T> array, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(Unity.Collections.NativeArray<T> array);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T, U>(Unity.Collections.NativeArray<T> array, U comp, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(Unity.Collections.NativeArray<T> array, U comp);
            static /*0x2a5510*/ int BinarySearch<T>(Unity.Collections.NativeArray<T> array, T value);
            static /*0x2a5510*/ int BinarySearch<T, U>(Unity.Collections.NativeArray<T> array, T value, U comp);
            static /*0x2a5510*/ void Sort<T>(Unity.Collections.NativeList<T> list);
            static /*0x2a5510*/ void Sort<T, U>(Unity.Collections.NativeList<T> list, U comp);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T>(Unity.Collections.NativeList<T> array, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(Unity.Collections.NativeList<T> list);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T, U>(Unity.Collections.NativeList<T> list, U comp, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(Unity.Collections.NativeList<T> list, U comp);
            static /*0x2a5510*/ int BinarySearch<T>(Unity.Collections.NativeList<T> list, T value);
            static /*0x2a5510*/ int BinarySearch<T, U>(Unity.Collections.NativeList<T> list, T value, U comp);
            static /*0x2a5510*/ void Sort<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list);
            static /*0x2a5510*/ void Sort<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, U comp);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, U comp, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, U comp);
            static /*0x2a5510*/ int BinarySearch<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, T value);
            static /*0x2a5510*/ int BinarySearch<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, T value, U comp);
            static /*0x2a5510*/ void Sort<T>(Unity.Collections.NativeSlice<T> slice);
            static /*0x2a5510*/ void Sort<T, U>(Unity.Collections.NativeSlice<T> slice, U comp);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T>(Unity.Collections.NativeSlice<T> slice, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(Unity.Collections.NativeSlice<T> slice);
            static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T, U>(Unity.Collections.NativeSlice<T> slice, U comp, Unity.Jobs.JobHandle inputDeps);
            static /*0x2a5510*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(Unity.Collections.NativeSlice<T> slice, U comp);
            static /*0x2a5510*/ int BinarySearch<T>(Unity.Collections.NativeSlice<T> slice, T value);
            static /*0x2a5510*/ int BinarySearch<T, U>(Unity.Collections.NativeSlice<T> slice, T value, U comp);
            static /*0x2a5510*/ void IntroSort<T, U>(void* array, int length, U comp);
            static /*0x2a5510*/ void IntroSort<T, U>(void* array, int lo, int hi, int depth, U comp);
            static /*0x2a5510*/ void InsertionSort<T, U>(void* array, int lo, int hi, U comp);
            static /*0x2a5510*/ int Partition<T, U>(void* array, int lo, int hi, U comp);
            static /*0x2a5510*/ void HeapSort<T, U>(void* array, int lo, int hi, U comp);
            static /*0x2a5510*/ void Heapify<T, U>(void* array, int i, int n, int lo, U comp);
            static /*0x2a5510*/ void Swap<T>(void* array, int lhs, int rhs);
            static /*0x2a5510*/ void SwapIfGreaterWithItems<T, U>(void* array, int lhs, int rhs, U comp);
            static /*0x2a5510*/ void IntroSortStruct<T, U>(void* array, int length, U comp);
            static /*0x2a5510*/ void IntroSortStruct<T, U>(void* array, int lo, int hi, int depth, U comp);
            static /*0x2a5510*/ void InsertionSortStruct<T, U>(void* array, int lo, int hi, U comp);
            static /*0x2a5510*/ int PartitionStruct<T, U>(void* array, int lo, int hi, U comp);
            static /*0x2a5510*/ void HeapSortStruct<T, U>(void* array, int lo, int hi, U comp);
            static /*0x2a5510*/ void HeapifyStruct<T, U>(void* array, int i, int n, int lo, U comp);
            static /*0x2a5510*/ void SwapStruct<T>(void* array, int lhs, int rhs);
            static /*0x2a5510*/ void SwapIfGreaterWithItemsStruct<T, U>(void* array, int lhs, int rhs, U comp);
            static /*0x1784c0*/ void CheckStrideMatchesSize<T>(int stride);

            struct DefaultComparer<T> : System.Collections.Generic.IComparer<T>
            {
                /*0x2a5510*/ int Compare(T x, T y);
            }

            struct SegmentSort<T, U> : Unity.Jobs.IJobParallelFor
            {
                /*0x0*/ T* Data;
                /*0x0*/ U Comp;
                /*0x0*/ int Length;
                /*0x0*/ int SegmentWidth;

                /*0x17aa40*/ void Execute(int index);
            }

            struct SegmentSortMerge<T, U> : Unity.Jobs.IJob
            {
                /*0x0*/ T* Data;
                /*0x0*/ U Comp;
                /*0x0*/ int Length;
                /*0x0*/ int SegmentWidth;

                /*0x180fc0*/ void Execute();
            }
        }

        struct SortJob<T, U>
        {
            /*0x0*/ T* Data;
            /*0x0*/ U Comp;
            /*0x0*/ int Length;

            /*0x2a5510*/ Unity.Jobs.JobHandle Schedule(Unity.Jobs.JobHandle inputDeps);

            struct SegmentSort<T, U> : Unity.Jobs.IJobParallelFor
            {
                /*0x0*/ T* Data;
                /*0x0*/ U Comp;
                /*0x0*/ int Length;
                /*0x0*/ int SegmentWidth;

                /*0x17aa40*/ void Execute(int index);
            }

            struct SegmentSortMerge<T, U> : Unity.Jobs.IJob
            {
                /*0x0*/ T* Data;
                /*0x0*/ U Comp;
                /*0x0*/ int Length;
                /*0x0*/ int SegmentWidth;

                /*0x180fc0*/ void Execute();
            }
        }

        struct NativeStream : System.IDisposable
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream m_Stream;

            static /*0x2a5510*/ Unity.Jobs.JobHandle ScheduleConstruct<T>(ref Unity.Collections.NativeStream stream, Unity.Collections.NativeList<T> bufferCount, Unity.Jobs.JobHandle dependency, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x1178310*/ Unity.Jobs.JobHandle ScheduleConstruct(ref Unity.Collections.NativeStream stream, Unity.Collections.NativeArray<int> bufferCount, Unity.Jobs.JobHandle dependency, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x1178070*/ void AllocateBlock(ref Unity.Collections.NativeStream stream, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            static /*0x1178140*/ void CheckForEachCountGreaterThanZero(int forEachCount);
            /*0x11783d0*/ NativeStream(int bufferCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x11782b0*/ bool IsEmpty();
            /*0xb73aa0*/ bool get_IsCreated();
            /*0x1178410*/ int get_ForEachCount();
            /*0x1178090*/ Unity.Collections.NativeStream.Reader AsReader();
            /*0x11780e0*/ Unity.Collections.NativeStream.Writer AsWriter();
            /*0x11781c0*/ int Count();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray<T>(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x1173bb0*/ void Dispose();
            /*0x1178220*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x1178080*/ void AllocateForEach(int forEachCount);
            /*0x32d010*/ void CheckReadAccess();

            struct ConstructJobList : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeStream Container;
                /*0x20*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List;

                /*0x1173b70*/ void Execute();
            }

            struct ConstructJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeStream Container;
                /*0x20*/ Unity.Collections.NativeArray<int> Length;

                /*0x1173ba0*/ void Execute();
            }

            struct Writer
            {
                /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream.Writer m_Writer;

                /*0x11840b0*/ Writer(ref Unity.Collections.NativeStream stream);
                /*0x1178410*/ int get_ForEachCount();
                /*0x32d010*/ void PatchMinMaxRange(int foreEachIndex);
                /*0x1183f50*/ void BeginForEachIndex(int foreachIndex);
                /*0x1183f70*/ void EndForEachIndex();
                /*0x2a5510*/ void Write<T>(T value);
                /*0x1803b0*/ ref T Allocate<T>();
                /*0x1183eb0*/ byte* Allocate(int size);
                /*0x32d010*/ void CheckBeginForEachIndex(int foreachIndex);
                /*0x32d010*/ void CheckEndForEachIndex();
                /*0x32d010*/ void CheckAllocateSize(int size);
            }

            struct Reader
            {
                /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream.Reader m_Reader;

                /*0x117b350*/ Reader(ref Unity.Collections.NativeStream stream);
                /*0x117afe0*/ int BeginForEachIndex(int foreachIndex);
                /*0x32d010*/ void EndForEachIndex();
                /*0x1178410*/ int get_ForEachCount();
                /*0x3e3af0*/ int get_RemainingItemCount();
                /*0x117b290*/ byte* ReadUnsafePtr(int size);
                /*0x1803b0*/ ref T Read<T>();
                /*0x1803b0*/ ref T Peek<T>();
                /*0x11781c0*/ int Count();
                /*0x32d010*/ void CheckNotReadingOutOfBounds(int size);
                /*0x32d010*/ void CheckRead();
                /*0x32d010*/ void CheckReadSize(int size);
                /*0x32d010*/ void CheckBeginForEachIndex(int forEachIndex);
                /*0x117b190*/ void CheckEndForEachIndex();
            }
        }

        struct NativeText : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.INativeDisposable, System.IDisposable, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.NativeText>, System.IEquatable<Unity.Collections.NativeText>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
        {
            /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeText* m_Data;

            static /*0x1179930*/ bool op_Equality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1179d30*/ bool op_Inequality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString32Bytes b);
            static /*0x1179b70*/ bool op_Equality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1179cf0*/ bool op_Inequality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString64Bytes b);
            static /*0x1179ab0*/ bool op_Equality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1179d70*/ bool op_Inequality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString128Bytes b);
            static /*0x1179c30*/ bool op_Equality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x1179d50*/ bool op_Inequality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString512Bytes b);
            static /*0x11799f0*/ bool op_Equality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x1179d10*/ bool op_Inequality(ref Unity.Collections.NativeText a, ref Unity.Collections.FixedString4096Bytes b);
            static /*0x11785f0*/ void CheckNull(void* dataPtr);
            /*0x11794d0*/ NativeText(string source, Unity.Collections.Allocator allocator);
            /*0x11796b0*/ NativeText(string source, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x1179800*/ NativeText(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth);
            /*0x1179180*/ NativeText(int capacity, Unity.Collections.Allocator allocator);
            /*0x1179510*/ NativeText(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x1179140*/ NativeText(Unity.Collections.Allocator allocator);
            /*0x11791c0*/ NativeText(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x11791f0*/ NativeText(ref Unity.Collections.FixedString32Bytes source, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x1179290*/ NativeText(ref Unity.Collections.FixedString32Bytes source, Unity.Collections.Allocator allocator);
            /*0x1179530*/ NativeText(ref Unity.Collections.FixedString64Bytes source, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x11793f0*/ NativeText(ref Unity.Collections.FixedString64Bytes source, Unity.Collections.Allocator allocator);
            /*0x11792d0*/ NativeText(ref Unity.Collections.FixedString128Bytes source, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x11795d0*/ NativeText(ref Unity.Collections.FixedString128Bytes source, Unity.Collections.Allocator allocator);
            /*0x1179610*/ NativeText(ref Unity.Collections.FixedString512Bytes source, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x1179370*/ NativeText(ref Unity.Collections.FixedString512Bytes source, Unity.Collections.Allocator allocator);
            /*0x1179430*/ NativeText(ref Unity.Collections.FixedString4096Bytes source, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x11793b0*/ NativeText(ref Unity.Collections.FixedString4096Bytes source, Unity.Collections.Allocator allocator);
            /*0x1179920*/ int get_Length();
            /*0x1179dc0*/ void set_Length(int value);
            /*0x11798d0*/ int get_Capacity();
            /*0x1179d90*/ void set_Capacity(int value);
            /*0x1179120*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
            /*0x11798e0*/ bool get_IsEmpty();
            /*0xb73aa0*/ bool get_IsCreated();
            /*0x1179020*/ byte* GetUnsafePtr();
            /*0x1179900*/ byte get_Item(int index);
            /*0x1179da0*/ void set_Item(int index, byte value);
            /*0x11789e0*/ ref byte ElementAt(int index);
            /*0x1178650*/ void Clear();
            /*0x1178430*/ void Add(ref byte value);
            /*0x1178820*/ int CompareTo(Unity.Collections.NativeText other);
            /*0x1178a40*/ bool Equals(Unity.Collections.NativeText other);
            /*0x11788c0*/ int CompareTo(Unity.Collections.NativeText.ReadOnly other);
            /*0x11789f0*/ bool Equals(Unity.Collections.NativeText.ReadOnly other);
            /*0x1178950*/ void Dispose();
            /*0x1178910*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x11790c0*/ string get_Value();
            /*0x1151300*/ Unity.Collections.NativeText.Enumerator GetEnumerator();
            /*0x1178660*/ int CompareTo(string other);
            /*0x1178f00*/ bool Equals(string other);
            /*0x11786e0*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
            /*0x1178f80*/ bool Equals(Unity.Collections.FixedString32Bytes other);
            /*0x1178870*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
            /*0x1178fc0*/ bool Equals(Unity.Collections.FixedString64Bytes other);
            /*0x11787d0*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
            /*0x1178ee0*/ bool Equals(Unity.Collections.FixedString128Bytes other);
            /*0x1178730*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
            /*0x1178fa0*/ bool Equals(Unity.Collections.FixedString512Bytes other);
            /*0x1178780*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
            /*0x1178ec0*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
            /*0x11790c0*/ string ToString();
            /*0x1178fe0*/ int GetHashCode();
            /*0x1178a90*/ bool Equals(object other);
            /*0x32d010*/ void CheckRead();
            /*0x32d010*/ void CheckWrite();
            /*0x32d010*/ void CheckWriteAndBumpSecondaryVersion();
            /*0x1178490*/ void CheckIndexInRange(int index);
            /*0x1179030*/ void ThrowCopyError(Unity.Collections.CopyError error, string source);
            /*0x6937d0*/ Unity.Collections.NativeText.ReadOnly AsReadOnly();

            struct Enumerator : System.Collections.Generic.IEnumerator<Unity.Collections.Unicode.Rune>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ Unity.Collections.NativeText.ReadOnly target;
                /*0x18*/ int offset;
                /*0x1c*/ Unity.Collections.Unicode.Rune current;

                /*0x1173dd0*/ Enumerator(Unity.Collections.NativeText source);
                /*0x1173dd0*/ Enumerator(Unity.Collections.NativeText.ReadOnly source);
                /*0x32d010*/ void Dispose();
                /*0x1173bc0*/ bool MoveNext();
                /*0x1173d10*/ void Reset();
                /*0x1173d30*/ object System.Collections.IEnumerator.get_Current();
                /*0x837600*/ Unity.Collections.Unicode.Rune get_Current();
            }

            struct ReadOnly : Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>, Unity.Collections.IUTF8Bytes, System.IComparable<string>, System.IEquatable<string>, System.IComparable<Unity.Collections.NativeText>, System.IEquatable<Unity.Collections.NativeText>, System.IComparable<Unity.Collections.FixedString32Bytes>, System.IEquatable<Unity.Collections.FixedString32Bytes>, System.IComparable<Unity.Collections.FixedString64Bytes>, System.IEquatable<Unity.Collections.FixedString64Bytes>, System.IComparable<Unity.Collections.FixedString128Bytes>, System.IEquatable<Unity.Collections.FixedString128Bytes>, System.IComparable<Unity.Collections.FixedString512Bytes>, System.IEquatable<Unity.Collections.FixedString512Bytes>, System.IComparable<Unity.Collections.FixedString4096Bytes>, System.IEquatable<Unity.Collections.FixedString4096Bytes>
            {
                /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeText* m_Data;

                static /*0x117a1f0*/ void CheckNull(void* dataPtr);
                static /*0x117adc0*/ bool op_Equality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString32Bytes b);
                static /*0x117af60*/ bool op_Inequality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString32Bytes b);
                static /*0x117ad00*/ bool op_Equality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString64Bytes b);
                static /*0x117af80*/ bool op_Inequality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString64Bytes b);
                static /*0x117ac40*/ bool op_Equality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString128Bytes b);
                static /*0x117af40*/ bool op_Inequality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString128Bytes b);
                static /*0x117ae80*/ bool op_Equality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString512Bytes b);
                static /*0x117afa0*/ bool op_Inequality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString512Bytes b);
                static /*0x117ab80*/ bool op_Equality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString4096Bytes b);
                static /*0x117afc0*/ bool op_Inequality(ref Unity.Collections.NativeText.ReadOnly a, ref Unity.Collections.FixedString4096Bytes b);
                /*0x9e29e0*/ ReadOnly(Unity.Collections.LowLevel.Unsafe.UnsafeText* text);
                /*0x11798d0*/ int get_Capacity();
                /*0x32d010*/ void set_Capacity(int value);
                /*0x11798e0*/ bool get_IsEmpty();
                /*0x32d010*/ void set_IsEmpty(bool value);
                /*0x1179920*/ int get_Length();
                /*0x32d010*/ void set_Length(int value);
                /*0x1179900*/ byte get_Item(int index);
                /*0x32d010*/ void set_Item(int index, byte value);
                /*0x32d010*/ void Clear();
                /*0x117a4c0*/ ref byte ElementAt(int index);
                /*0x1179020*/ byte* GetUnsafePtr();
                /*0x348b00*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
                /*0x32d010*/ void CheckRead();
                /*0x32d010*/ void ErrorWrite();
                /*0x117a340*/ int CompareTo(string other);
                /*0x117a9c0*/ bool Equals(string other);
                /*0x117a420*/ int CompareTo(Unity.Collections.NativeText.ReadOnly other);
                /*0x117aa00*/ bool Equals(Unity.Collections.NativeText.ReadOnly other);
                /*0x117a2f0*/ int CompareTo(Unity.Collections.NativeText other);
                /*0x117aa70*/ bool Equals(Unity.Collections.NativeText other);
                /*0x117a380*/ int CompareTo(Unity.Collections.FixedString32Bytes other);
                /*0x117a510*/ bool Equals(Unity.Collections.FixedString32Bytes other);
                /*0x117a250*/ int CompareTo(Unity.Collections.FixedString64Bytes other);
                /*0x117a530*/ bool Equals(Unity.Collections.FixedString64Bytes other);
                /*0x117a2a0*/ int CompareTo(Unity.Collections.FixedString128Bytes other);
                /*0x117a550*/ bool Equals(Unity.Collections.FixedString128Bytes other);
                /*0x117a3d0*/ int CompareTo(Unity.Collections.FixedString512Bytes other);
                /*0x117aac0*/ bool Equals(Unity.Collections.FixedString512Bytes other);
                /*0x117a470*/ int CompareTo(Unity.Collections.FixedString4096Bytes other);
                /*0x117aa50*/ bool Equals(Unity.Collections.FixedString4096Bytes other);
                /*0x117ab20*/ string ToString();
                /*0x117aae0*/ int GetHashCode();
                /*0x117a570*/ bool Equals(object other);
                /*0x117ab20*/ string get_Value();
                /*0x1151300*/ Unity.Collections.NativeText.Enumerator GetEnumerator();
            }
        }

        struct Spinner
        {
            /*0x10*/ int m_value;

            /*0x117bfd0*/ void Lock();
            /*0x117c010*/ void Unlock();
        }

        struct UnmanagedArray<T> : System.IDisposable
        {
            /*0x0*/ nint m_pointer;
            /*0x0*/ int m_length;
            /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_allocator;

            /*0x2a5510*/ UnmanagedArray(int length, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ T* GetUnsafePointer();
            /*0x184ab0*/ ref T get_Item(int index);
        }

        struct RewindableAllocator : Unity.Collections.AllocatorManager.IAllocator, System.IDisposable
        {
            /*0x10*/ Unity.Collections.Spinner m_spinner;
            /*0x14*/ Unity.Collections.AllocatorManager.AllocatorHandle m_handle;
            /*0x18*/ Unity.Collections.UnmanagedArray<Unity.Collections.RewindableAllocator.MemoryBlock> m_block;
            /*0x28*/ int m_best;
            /*0x2c*/ int m_last;
            /*0x30*/ int m_used;
            /*0x34*/ bool m_enableBlockFree;

            static /*0x117bb00*/ int Try(nint state, ref Unity.Collections.AllocatorManager.Block block);
            static /*0x117b7a0*/ int Try$BurstManaged(nint state, ref Unity.Collections.AllocatorManager.Block block);
            /*0x117b530*/ void Initialize(int initialSizeInBytes, bool enableBlockFree);
            /*0xed9100*/ bool get_EnableBlockFree();
            /*0x117be00*/ void set_EnableBlockFree(bool value);
            /*0x117bd30*/ int get_BlocksAllocated();
            /*0x117bda0*/ int get_InitialSizeInBytes();
            /*0x117b620*/ void Rewind();
            /*0x117b3f0*/ void Dispose();
            /*0x117bd40*/ Unity.Collections.AllocatorManager.TryFunction get_Function();
            /*0x117b7d0*/ int Try(ref Unity.Collections.AllocatorManager.Block block);
            /*0xa5a7c0*/ Unity.Collections.AllocatorManager.AllocatorHandle get_Handle();
            /*0xfc2c10*/ void set_Handle(Unity.Collections.AllocatorManager.AllocatorHandle value);
            /*0x117bdf0*/ Unity.Collections.Allocator get_ToAllocator();
            /*0x117bde0*/ bool get_IsCustomAllocator();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> AllocateNativeArray<T>(int length);
            /*0x2a5510*/ Unity.Collections.NativeList<T> AllocateNativeList<T>(int capacity);

            struct MemoryBlock : System.IDisposable
            {
                static int kMaximumAlignment = 16384;
                /*0x10*/ byte* m_pointer;
                /*0x18*/ long m_bytes;
                /*0x20*/ long m_current;
                /*0x28*/ long m_allocations;

                /*0x11770a0*/ MemoryBlock(long bytes);
                /*0x1176fa0*/ void Rewind();
                /*0x1176f30*/ void Dispose();
                /*0x1176fb0*/ int TryAllocate(ref Unity.Collections.AllocatorManager.Block block);
                /*0x1176ef0*/ bool Contains(nint ptr);
            }

            class Try_000006E8$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x776780*/ Try_000006E8$PostfixBurstDelegate(object , nint );
                /*0x722200*/ int Invoke(nint state, ref Unity.Collections.AllocatorManager.Block block);
                /*0x117d8c0*/ System.IAsyncResult BeginInvoke(nint state, ref Unity.Collections.AllocatorManager.Block block, System.AsyncCallback , object );
                /*0xf338c0*/ int EndInvoke(System.IAsyncResult );
            }

            class Try_000006E8$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;
                static /*0x8*/ nint DeferredCompilation;

                static /*0x117d370*/ Try_000006E8$BurstDirectCall();
                static /*0x117d420*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x117d550*/ nint GetFunctionPointer();
                static /*0x117d370*/ void Constructor();
                static /*0x32d010*/ void Initialize();
                static /*0x117d6c0*/ int Invoke(nint state, ref Unity.Collections.AllocatorManager.Block block);
            }
        }

        enum FormatError
        {
            None = 0,
            Overflow = 1,
        }

        enum ParseError
        {
            None = 0,
            Syntax = 1,
            Overflow = 2,
            Underflow = 3,
        }

        enum CopyError
        {
            None = 0,
            Truncation = 1,
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
            static int kMaximumValidCodePoint = 1114111;

            static /*0x117e480*/ bool IsValidCodePoint(int codepoint);
            static /*0x117e490*/ bool NotTrailer(byte b);
            static /*0x117ec50*/ Unity.Collections.Unicode.Rune get_ReplacementCharacter();
            static /*0x388e90*/ Unity.Collections.Unicode.Rune get_BadRune();
            static /*0x117e840*/ Unity.Collections.ConversionError Utf8ToUcs(ref Unity.Collections.Unicode.Rune rune, byte* buffer, ref int index, int capacity);
            static /*0xe2ccf0*/ bool IsLeadingSurrogate(char c);
            static /*0xe2ceb0*/ bool IsTrailingSurrogate(char c);
            static /*0x117e650*/ Unity.Collections.ConversionError Utf16ToUcs(ref Unity.Collections.Unicode.Rune rune, char* buffer, ref int index, int capacity);
            static /*0x117e540*/ Unity.Collections.ConversionError UcsToUtf8(byte* buffer, ref int index, int capacity, Unity.Collections.Unicode.Rune rune);
            static /*0x117e4a0*/ Unity.Collections.ConversionError UcsToUtf16(char* buffer, ref int index, int capacity, Unity.Collections.Unicode.Rune rune);
            static /*0x117e710*/ Unity.Collections.ConversionError Utf16ToUtf8(char* utf16Buffer, int utf16Length, byte* utf8Buffer, ref int utf8Length, int utf8Capacity);
            static /*0x117eb90*/ Unity.Collections.ConversionError Utf8ToUtf8(byte* srcBuffer, int srcLength, byte* destBuffer, ref int destLength, int destCapacity);
            static /*0x117ea90*/ Unity.Collections.ConversionError Utf8ToUtf16(byte* utf8Buffer, int utf8Length, char* utf16Buffer, ref int utf16Length, int utf16Capacity);

            struct Rune
            {
                /*0x10*/ int value;

                static /*0xe31090*/ Unity.Collections.Unicode.Rune op_Explicit(char codepoint);
                static /*0x117bf80*/ bool IsDigit(Unity.Collections.Unicode.Rune r);
                /*0x6bbd40*/ Rune(int codepoint);
                /*0x117bf90*/ int LengthInUtf8Bytes();
            }
        }

        class UTF8ArrayUnsafeUtility
        {
            static /*0x117dbf0*/ Unity.Collections.CopyError Copy(byte* dest, ref int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength);
            static /*0x117de30*/ Unity.Collections.CopyError Copy(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength);
            static /*0x117dd50*/ Unity.Collections.CopyError Copy(byte* dest, ref int destLength, int destUTF8MaxLengthInBytes, byte* src, int srcLength);
            static /*0x117dc70*/ Unity.Collections.CopyError Copy(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength);
            static /*0x117dc30*/ Unity.Collections.CopyError Copy(char* dest, ref int destLength, int destUCS2MaxLengthInChars, byte* src, int srcLength);
            static /*0x117de90*/ Unity.Collections.CopyError Copy(char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength);
            static /*0x117d9e0*/ Unity.Collections.FormatError AppendUTF8Bytes(byte* dest, ref int destLength, int destCapacity, byte* src, int srcLength);
            static /*0x117db00*/ Unity.Collections.CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength);
            static /*0x117da40*/ Unity.Collections.CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength);
            static /*0x117daa0*/ Unity.Collections.CopyError Append(char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength);
            static /*0x117e3c0*/ int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB);
            static /*0x117e220*/ int StrCmp(char* utf16BufferA, int utf16LengthInCharsA, char* utf16BufferB, int utf16LengthInCharsB);
            static /*0x117def0*/ bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength);
            static /*0x117e0e0*/ int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars);
            static /*0x117dfa0*/ int StrCmp(char* utf16Buffer, int utf16LengthInChars, byte* utf8Buffer, int utf8LengthInBytes);

            struct Comparison
            {
                /*0x10*/ bool terminates;
                /*0x14*/ int result;

                /*0x1173b40*/ Comparison(Unity.Collections.Unicode.Rune runeA, Unity.Collections.ConversionError errorA, Unity.Collections.Unicode.Rune runeB, Unity.Collections.ConversionError errorB);
            }
        }

        class xxHash3
        {
            static int STRIPE_LEN = 64;
            static int ACC_NB = 8;
            static int SECRET_CONSUME_RATE = 8;
            static int SECRET_KEY_SIZE = 192;
            static int SECRET_KEY_MIN_SIZE = 136;
            static int SECRET_LASTACC_START = 7;
            static int NB_ROUNDS = 16;
            static int BLOCK_LEN = 1024;
            static uint PRIME32_1 = 2654435761;
            static uint PRIME32_2 = 2246822519;
            static uint PRIME32_3 = 3266489917;
            static uint PRIME32_5 = 374761393;
            static ulong PRIME64_1 = 11400714785074694791;
            static ulong PRIME64_2 = 14029467366897019727;
            static ulong PRIME64_3 = 1609587929392839161;
            static ulong PRIME64_4 = 9650029242287828579;
            static ulong PRIME64_5 = 2870177450012600261;
            static int MIDSIZE_MAX = 240;
            static int MIDSIZE_STARTOFFSET = 3;
            static int MIDSIZE_LASTOFFSET = 17;
            static int SECRET_MERGEACCS_START = 11;

            static /*0x1184670*/ void Avx2HashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64);
            static /*0x1184910*/ void Avx2ScrambleAcc(ulong* acc, byte* secret);
            static /*0x1184570*/ void Avx2Accumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64);
            static /*0x1184180*/ void Avx2Accumulate512(ulong* acc, byte* input, byte* dest, byte* secret);
            static /*0x11876d0*/ Unity.Mathematics.uint2 Hash64(void* input, long length);
            static /*0x2a5510*/ Unity.Mathematics.uint2 Hash64<T>(ref T input);
            static /*0x1187610*/ Unity.Mathematics.uint2 Hash64(void* input, long length, ulong seed);
            static /*0x11868a0*/ Unity.Mathematics.uint4 Hash128(void* input, long length);
            static /*0x2a5510*/ Unity.Mathematics.uint4 Hash128<T>(ref T input);
            static /*0x1186710*/ Unity.Mathematics.uint4 Hash128(void* input, void* destination, long length);
            static /*0x1186650*/ Unity.Mathematics.uint4 Hash128(void* input, long length, ulong seed);
            static /*0x11867d0*/ Unity.Mathematics.uint4 Hash128(void* input, void* destination, long length, ulong seed);
            static /*0x1186950*/ ulong Hash64Internal(byte* input, byte* dest, long length, byte* secret, ulong seed);
            static /*0x1185520*/ void Hash128Internal(byte* input, byte* dest, long length, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x11872b0*/ ulong Hash64Len1To3(byte* input, long len, byte* secret, ulong seed);
            static /*0x1187330*/ ulong Hash64Len4To8(byte* input, long length, byte* secret, ulong seed);
            static /*0x11873c0*/ ulong Hash64Len9To16(byte* input, long length, byte* secret, ulong seed);
            static /*0x1186d30*/ ulong Hash64Len0To16(byte* input, long length, byte* secret, ulong seed);
            static /*0x11870a0*/ ulong Hash64Len17To128(byte* input, long length, byte* secret, ulong seed);
            static /*0x1186f10*/ ulong Hash64Len129To240(byte* input, long length, byte* secret, ulong seed);
            static /*0x1187590*/ ulong Hash64Long(byte* input, byte* dest, long length, byte* secret);
            static /*0x1186140*/ void Hash128Len1To3(byte* input, long length, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x1186240*/ void Hash128Len4To8(byte* input, long len, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x1186320*/ void Hash128Len9To16(byte* input, long len, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x11856c0*/ void Hash128Len0To16(byte* input, long length, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x1185e00*/ void Hash128Len17To128(byte* input, long length, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x1185a00*/ void Hash128Len129To240(byte* input, long length, byte* secret, ulong seed, ref Unity.Mathematics.uint4 result);
            static /*0x11865d0*/ void Hash128Long(byte* input, byte* dest, long length, byte* secret, ref Unity.Mathematics.uint4 result);
            static /*0x1187a50*/ Unity.Mathematics.uint2 ToUint2(ulong u);
            static /*0x1187a70*/ Unity.Mathematics.uint4 ToUint4(ulong ul0, ulong ul1);
            static /*0x11854e0*/ void EncodeSecretKey(byte* dst, byte* secret, ulong seed);
            static /*0x6937d0*/ ulong Read64LE(void* addr);
            static /*0x6bba50*/ uint Read32LE(void* addr);
            static /*0x9e29e0*/ void Write64LE(void* addr, ulong value);
            static /*0x6bbd40*/ void Read32LE(void* addr, uint value);
            static /*0xf578c0*/ ulong Mul32To64(uint x, uint y);
            static /*0x1187a40*/ ulong Swap64(ulong x);
            static /*0xf0cd40*/ uint Swap32(uint x);
            static /*0xf4eb40*/ uint RotL32(uint x, int r);
            static /*0x1187a20*/ ulong RotL64(ulong x, int r);
            static /*0x1187a90*/ ulong XorShift64(ulong v64, int shift);
            static /*0x11879f0*/ ulong Mul128Fold64(ulong lhs, ulong rhs);
            static /*0x1187890*/ ulong Mix16(byte* input, byte* secret, ulong seed);
            static /*0x1187900*/ Unity.Collections.xxHash3.ulong2 Mix32(Unity.Collections.xxHash3.ulong2 acc, byte* input_1, byte* input_2, byte* secret, ulong seed);
            static /*0x1184150*/ ulong Avalanche(ulong h64);
            static /*0x1184110*/ ulong AvalancheH64(ulong h64);
            static /*0x1187ab0*/ ulong rrmxmx(ulong h64, ulong length);
            static /*0x11878d0*/ ulong Mix2Acc(ulong acc0, ulong acc1, byte* secret);
            static /*0x1187780*/ ulong MergeAcc(ulong* acc, byte* secret, ulong start);
            static /*0x1185100*/ void DefaultHashLongInternalLoop(ulong* acc, byte* input, byte* dest, long length, byte* secret, int isHash64);
            static /*0x1184f20*/ void DefaultAccumulate(ulong* acc, byte* input, byte* dest, byte* secret, long nbStripes, int isHash64);
            static /*0x1184dc0*/ void DefaultAccumulate512(ulong* acc, byte* input, byte* dest, byte* secret, int isHash64);
            static /*0x1185400*/ void DefaultScrambleAcc(ulong* acc, byte* secret);
            static /*0x1187450*/ ulong Hash64Long$BurstManaged(byte* input, byte* dest, long length, byte* secret);
            static /*0x1186450*/ void Hash128Long$BurstManaged(byte* input, byte* dest, long length, byte* secret, ref Unity.Mathematics.uint4 result);

            struct ulong2
            {
                /*0x10*/ ulong x;
                /*0x18*/ ulong y;

                /*0xbee490*/ ulong2(ulong x, ulong y);
            }

            struct StreamingState
            {
                static /*0x0*/ int SECRET_LIMIT;
                static /*0x4*/ int NB_STRIPES_PER_BLOCK;
                static /*0x8*/ int INTERNAL_BUFFER_SIZE;
                static /*0xc*/ int INTERNAL_BUFFER_STRIPES;
                /*0x10*/ Unity.Collections.xxHash3.StreamingState.StreamingStateData State;

                static /*0x117d230*/ StreamingState();
                /*0x117d2d0*/ StreamingState(bool isHash64, ulong seed);
                /*0x117cdc0*/ void Reset(bool isHash64, ulong seed);
                /*0x117cf90*/ void Update(void* input, int length);
                /*0x17aec0*/ void Update<T>(ref T input);
                /*0x117c530*/ Unity.Mathematics.uint4 DigestHash128();
                /*0x117c780*/ Unity.Mathematics.uint2 DigestHash64();
                /*0x621ca0*/ ulong* get_Acc();
                /*0x117d350*/ byte* get_Buffer();
                /*0x117d360*/ byte* get_SecretKey();
                /*0x117c960*/ void DigestLong(ulong* acc, byte* secret, int isHash64);
                /*0x117c100*/ void ConsumeStripes(ulong* acc, ref int nbStripesSoFar, byte* input, long totalStripes, byte* secret, int isHash64);
                /*0x117c040*/ void CheckKeySize(int isHash64);

                struct StreamingStateData
                {
                    /*0x10*/ ulong Acc;
                    /*0x50*/ byte Buffer;
                    /*0x150*/ int IsHash64;
                    /*0x154*/ int BufferedSize;
                    /*0x158*/ int NbStripesSoFar;
                    /*0x160*/ long TotalLength;
                    /*0x168*/ ulong Seed;
                    /*0x170*/ byte SecretKey;
                    /*0x22c*/ byte _PadEnd;
                }
            }

            class Hash64Long_0000071F$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x1174f20*/ Hash64Long_0000071F$PostfixBurstDelegate(object , nint );
                /*0x7239c0*/ ulong Invoke(byte* input, byte* dest, long length, byte* secret);
                /*0x1174e80*/ System.IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, System.AsyncCallback , object );
                /*0xe61b10*/ ulong EndInvoke(System.IAsyncResult );
            }

            class Hash64Long_0000071F$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;
                static /*0x8*/ nint DeferredCompilation;

                static /*0x1174860*/ Hash64Long_0000071F$BurstDirectCall();
                static /*0x1174910*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x1174a40*/ nint GetFunctionPointer();
                static /*0x1174860*/ void Constructor();
                static /*0x32d010*/ void Initialize();
                static /*0x1174bb0*/ ulong Invoke(byte* input, byte* dest, long length, byte* secret);
            }

            class Hash128Long_00000726$PostfixBurstDelegate : System.MulticastDelegate
            {
                /*0x11747a0*/ Hash128Long_00000726$PostfixBurstDelegate(object , nint );
                /*0x723cc0*/ void Invoke(byte* input, byte* dest, long length, byte* secret, ref Unity.Mathematics.uint4 result);
                /*0x11746d0*/ System.IAsyncResult BeginInvoke(byte* input, byte* dest, long length, byte* secret, ref Unity.Mathematics.uint4 result, System.AsyncCallback , object );
                /*0x723cb0*/ void EndInvoke(System.IAsyncResult );
            }

            class Hash128Long_00000726$BurstDirectCall
            {
                static /*0x0*/ nint Pointer;
                static /*0x8*/ nint DeferredCompilation;

                static /*0x1174060*/ Hash128Long_00000726$BurstDirectCall();
                static /*0x1174110*/ void GetFunctionPointerDiscard(ref nint );
                static /*0x1174240*/ nint GetFunctionPointer();
                static /*0x1174060*/ void Constructor();
                static /*0x32d010*/ void Initialize();
                static /*0x11743b0*/ void Invoke(byte* input, byte* dest, long length, byte* secret, ref Unity.Mathematics.uint4 result);
            }
        }

        class xxHashDefaultKey
        {
            static /*0x0*/ byte[] kSecret;

            static /*0x1187b10*/ xxHashDefaultKey();
        }

        namespace NotBurstCompatible
        {
            class Extensions
            {
                static /*0x2a5510*/ T[] ToArray<T>(Unity.Collections.NativeHashSet<T> set);
                static /*0x2a5510*/ T[] ToArrayNBC<T>(Unity.Collections.NativeList<T> list);
                static /*0x2a5510*/ void CopyFromNBC<T>(Unity.Collections.NativeList<T> list, T[] array);
                static /*0x2a5510*/ System.ValueTuple<Unity.Collections.NativeArray<TKey>, int> GetUniqueKeyArrayNBC<TKey, TValue>(Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> hashmap, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                static /*0x2a5510*/ System.ValueTuple<Unity.Collections.NativeArray<TKey>, int> GetUniqueKeyArrayNBC<TKey, TValue>(Unity.Collections.NativeMultiHashMap<TKey, TValue> hashmap, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
            }
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                struct UnsafeList : Unity.Collections.INativeDisposable, System.IDisposable
                {
                    /*0x10*/ void* Ptr;
                    /*0x18*/ int Length;
                    /*0x1c*/ int unused;
                    /*0x20*/ int Capacity;
                    /*0x24*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList New<U>(int sizeOf, int alignOf, int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x11814b0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList* Create(int sizeOf, int alignOf, int initialCapacity, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList* Create<U>(int sizeOf, int alignOf, int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x2a5510*/ void Destroy<U>(Unity.Collections.LowLevel.Unsafe.UnsafeList* listData, ref U allocator, int sizeOf, int alignOf);
                    static /*0x11815c0*/ void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafeList* listData);
                    static /*0x1181450*/ void CheckNull(void* listData);
                    static /*0x1181090*/ void CheckAllocator(Unity.Collections.Allocator a);
                    static /*0x1181020*/ void CheckAllocator(Unity.Collections.AllocatorManager.AllocatorHandle a);
                    /*0x1181c60*/ UnsafeList(Unity.Collections.Allocator allocator);
                    /*0x1181b80*/ UnsafeList(void* ptr, int length);
                    /*0x1181af0*/ UnsafeList(int sizeOf, int alignOf, int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x1181bc0*/ UnsafeList(int sizeOf, int alignOf, int initialCapacity, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x2a5510*/ void Initialize<U>(int sizeOf, int alignOf, int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x1181c90*/ bool get_IsEmpty();
                    /*0xb73aa0*/ bool get_IsCreated();
                    /*0x1181650*/ void Dispose();
                    void Dispose<U>(ref U allocator, int sizeOf, int alignOf);
                    /*0x11816f0*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0xd03bf0*/ void Clear();
                    /*0x1181a00*/ void Resize(int sizeOf, int alignOf, int length, Unity.Collections.NativeArrayOptions options);
                    /*0x1817d0*/ void Resize<T>(int length, Unity.Collections.NativeArrayOptions options);
                    /*0x2a5510*/ void Realloc<U>(ref U allocator, int sizeOf, int alignOf, int capacity);
                    /*0x11818b0*/ void Realloc(int sizeOf, int alignOf, int capacity);
                    /*0x2a5510*/ void SetCapacity<U>(ref U allocator, int sizeOf, int alignOf, int capacity);
                    /*0x1181a70*/ void SetCapacity(int sizeOf, int alignOf, int capacity);
                    /*0x17aa40*/ void SetCapacity<T>(int capacity);
                    /*0x180fc0*/ void TrimExcess<T>();
                    /*0x2a5510*/ int IndexOf<T>(T value);
                    /*0x2a5510*/ bool Contains<T>(T value);
                    /*0x2a5510*/ void AddNoResize<T>(T value);
                    /*0x1180f40*/ void AddRangeNoResize(int sizeOf, void* ptr, int length);
                    /*0x2a5510*/ void AddRangeNoResize<T>(void* ptr, int length);
                    /*0x2a5510*/ void AddRangeNoResize<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList list);
                    /*0x2a5510*/ void Add<T>(T value);
                    /*0x1180f80*/ void AddRange(int sizeOf, int alignOf, void* ptr, int length);
                    /*0x2a5510*/ void AddRange<T>(void* ptr, int length);
                    /*0x2a5510*/ void AddRange<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList list);
                    /*0x1181800*/ void InsertRangeWithBeginEnd(int sizeOf, int alignOf, int begin, int end);
                    /*0x1817d0*/ void InsertRangeWithBeginEnd<T>(int begin, int end);
                    /*0x1181930*/ void RemoveRangeSwapBackWithBeginEnd(int sizeOf, int begin, int end);
                    /*0x17aa40*/ void RemoveAtSwapBack<T>(int index);
                    /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd<T>(int begin, int end);
                    /*0x1181990*/ void RemoveRangeWithBeginEnd(int sizeOf, int begin, int end);
                    /*0x17aa40*/ void RemoveAt<T>(int index);
                    /*0x1817d0*/ void RemoveRangeWithBeginEnd<T>(int begin, int end);
                    /*0x6d1ef0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader AsParallelReader();
                    /*0x1181010*/ Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter AsParallelWriter();
                    /*0x1181100*/ void CheckBeginEnd(int begin, int end);
                    /*0x32d010*/ void CheckNoResizeHasEnoughCapacity(int length);
                    /*0x1181350*/ void CheckNoResizeHasEnoughCapacity(int length, int index);

                    struct ParallelReader
                    {
                        /*0x10*/ void* Ptr;
                        /*0x18*/ int Length;

                        /*0xa59ff0*/ ParallelReader(void* ptr, int length);
                        /*0x2a5510*/ int IndexOf<T>(T value);
                        /*0x2a5510*/ bool Contains<T>(T value);
                    }

                    struct ParallelWriter
                    {
                        /*0x10*/ void* Ptr;
                        /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeList* ListData;

                        /*0xbee490*/ ParallelWriter(void* ptr, Unity.Collections.LowLevel.Unsafe.UnsafeList* listData);
                        /*0x2a5510*/ void AddNoResize<T>(T value);
                        /*0x117a0d0*/ void AddRangeNoResize(int sizeOf, int alignOf, void* ptr, int length);
                        /*0x2a5510*/ void AddRangeNoResize<T>(void* ptr, int length);
                        /*0x2a5510*/ void AddRangeNoResize<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList list);
                    }
                }

                class UnsafeListExtension
                {
                    static /*0x17e030*/ ref Unity.Collections.LowLevel.Unsafe.UnsafeList ListData<T>(ref Unity.Collections.LowLevel.Unsafe.UnsafeList<T> from);
                    static /*0x2a5510*/ void Sort<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList list);
                    static /*0x2a5510*/ void Sort<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList list, U comp);
                    static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList container, Unity.Jobs.JobHandle inputDeps);
                    static /*0x2a5510*/ Unity.Collections.SortJob<T, Unity.Collections.NativeSortExtension.DefaultComparer<T>> SortJob<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList list);
                    static /*0x2a5510*/ Unity.Jobs.JobHandle Sort<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList container, U comp, Unity.Jobs.JobHandle inputDeps);
                    static /*0x2a5510*/ Unity.Collections.SortJob<T, U> SortJob<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList list, U comp);
                    static /*0x2a5510*/ int BinarySearch<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList container, T value);
                    static /*0x2a5510*/ int BinarySearch<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList container, T value, U comp);
                }

                struct UnsafePtrList : Unity.Collections.INativeDisposable, System.IDisposable, Unity.Collections.INativeList<nint>, Unity.Collections.IIndexable<nint>, System.Collections.Generic.IEnumerable<nint>, System.Collections.IEnumerable
                {
                    /*0x10*/ void** Ptr;
                    /*0x18*/ int length;
                    /*0x1c*/ int unused;
                    /*0x20*/ int capacity;
                    /*0x24*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    static /*0x1182200*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList* Create(void** ptr, int length);
                    static /*0x1182300*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList* Create(int initialCapacity, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x11823d0*/ void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafePtrList* listData);
                    /*0x1182d70*/ UnsafePtrList(void** ptr, int length);
                    /*0x1182c30*/ UnsafePtrList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x1182ac0*/ UnsafePtrList(int initialCapacity, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x834a60*/ int get_Length();
                    /*0x32d010*/ void set_Length(int value);
                    /*0x417e30*/ int get_Capacity();
                    /*0x32d010*/ void set_Capacity(int value);
                    /*0xbcf1a0*/ nint get_Item(int index);
                    /*0x1182e00*/ void set_Item(int index, nint value);
                    /*0x1182600*/ ref nint ElementAt(int index);
                    /*0x1181c90*/ bool get_IsEmpty();
                    /*0xb73aa0*/ bool get_IsCreated();
                    /*0x11825b0*/ void Dispose();
                    /*0x1182530*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x11821b0*/ void Clear();
                    /*0x11828c0*/ void Resize(int length, Unity.Collections.NativeArrayOptions options);
                    /*0x1182950*/ void SetCapacity(int capacity);
                    /*0x1182a50*/ void TrimExcess();
                    /*0xbed040*/ int IndexOf(void* value);
                    /*0x117a030*/ bool Contains(void* value);
                    /*0x1181dd0*/ void AddNoResize(void* value);
                    /*0x1181ed0*/ void AddRangeNoResize(void** ptr, int length);
                    /*0x1181e50*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafePtrList list);
                    /*0x11820b0*/ void Add(ref nint value);
                    /*0x1182130*/ void Add(void* value);
                    /*0x1181f60*/ void AddRange(void* ptr, int length);
                    /*0x1181ff0*/ void AddRange(Unity.Collections.LowLevel.Unsafe.UnsafePtrList list);
                    /*0x1182610*/ void InsertRangeWithBeginEnd(int begin, int end);
                    /*0x11826a0*/ void RemoveAtSwapBack(int index);
                    /*0x11827a0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
                    /*0x1182720*/ void RemoveAt(int index);
                    /*0x1182830*/ void RemoveRangeWithBeginEnd(int begin, int end);
                    /*0x1182a10*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x11829d0*/ System.Collections.Generic.IEnumerator<nint> System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator();
                    /*0x6d1ef0*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList.ParallelReader AsParallelReader();
                    /*0x1181010*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList.ParallelWriter AsParallelWriter();

                    struct ParallelReader
                    {
                        /*0x10*/ void** Ptr;
                        /*0x18*/ int Length;

                        /*0xa59ff0*/ ParallelReader(void** ptr, int length);
                        /*0xbed040*/ int IndexOf(void* value);
                        /*0x117a030*/ bool Contains(void* value);
                    }

                    struct ParallelWriter
                    {
                        /*0x10*/ void* Ptr;
                        /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeList* ListData;

                        /*0xbee490*/ ParallelWriter(void* ptr, Unity.Collections.LowLevel.Unsafe.UnsafeList* listData);
                        /*0x117a070*/ void AddNoResize(void* value);
                        /*0x117a140*/ void AddRangeNoResize(void** ptr, int length);
                        /*0x117a1a0*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafePtrList list);
                    }
                }

                class UnsafePtrListExtensions
                {
                    static /*0x1181d90*/ ref Unity.Collections.LowLevel.Unsafe.UnsafeList ListData(ref Unity.Collections.LowLevel.Unsafe.UnsafePtrList from);
                }

                class UnsafePtrListDebugView
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList Data;

                    /*0x1181cb0*/ UnsafePtrListDebugView(Unity.Collections.LowLevel.Unsafe.UnsafePtrList data);
                    /*0x1181cf0*/ nint[] get_Items();
                }

                class WordStorageDebugView
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.WordStorage m_wordStorage;

                    /*0x11835f0*/ WordStorageDebugView(Unity.Collections.LowLevel.Unsafe.WordStorage wordStorage);
                    /*0x1183640*/ Unity.Collections.FixedString128Bytes[] get_Table();
                }

                class WordStorageStatic
                {
                    static /*0x0*/ Unity.Collections.LowLevel.Unsafe.WordStorageStatic.Thing Ref;

                    static /*0x32d010*/ WordStorageStatic();
                    /*0x32f970*/ WordStorageStatic();

                    struct Thing
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.WordStorage Data;
                    }
                }

                struct WordStorage
                {
                    static int kMaxEntries = 16384;
                    static int kMaxChars = 2097152;
                    static int kMaxCharsPerEntry = 4096;
                    /*0x10*/ Unity.Collections.NativeArray<byte> buffer;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Collections.LowLevel.Unsafe.WordStorage.Entry> entry;
                    /*0x30*/ Unity.Collections.NativeMultiHashMap<int, int> hash;
                    /*0x40*/ int chars;
                    /*0x44*/ int entries;

                    static /*0x1183d00*/ ref Unity.Collections.LowLevel.Unsafe.WordStorage get_Instance();
                    static /*0x11838a0*/ void Initialize();
                    static /*0x1183bf0*/ void Shutdown();
                    static /*0x11836f0*/ void Clear();
                    static /*0x1183be0*/ void Setup();
                    /*0x995160*/ int get_Entries();
                    void GetFixedString<T>(int index, ref T temp);
                    /*0x2a5510*/ int GetIndexFromHashAndFixedString<T>(int h, ref T temp);
                    /*0x17e620*/ bool Contains<T>(ref T value);
                    /*0x11837c0*/ bool Contains(string value);
                    /*0x17b580*/ int GetOrCreateIndex<T>(ref T value);

                    struct Entry
                    {
                        /*0x10*/ int offset;
                        /*0x14*/ int length;
                    }

                    class <>c
                    {
                        static /*0x0*/ Unity.Collections.LowLevel.Unsafe.WordStorage.<> <>9;
                        static /*0x8*/ System.EventHandler <>9__13_0;
                        static /*0x10*/ System.EventHandler <>9__13_1;

                        static /*0x117d970*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x117d960*/ void <Initialize>b__13_0(object _, System.EventArgs __);
                        /*0x117d960*/ void <Initialize>b__13_1(object _, System.EventArgs __);
                    }
                }

                struct Words
                {
                    /*0x10*/ int Index;

                    /*0x17aec0*/ void ToFixedString<T>(ref T value);
                    /*0x1183e40*/ string ToString();
                    /*0x17aec0*/ void SetFixedString<T>(ref T value);
                    /*0x1183d60*/ void SetString(string value);
                }

                struct NumberedWords
                {
                    static int kPositiveNumericSuffixShift = 0;
                    static int kPositiveNumericSuffixBits = 29;
                    static int kMaxPositiveNumericSuffix = 536870911;
                    static int kPositiveNumericSuffixMask = 536870911;
                    static int kLeadingZeroesShift = 29;
                    static int kLeadingZeroesBits = 3;
                    static int kMaxLeadingZeroes = 7;
                    static int kLeadingZeroesMask = 7;
                    /*0x10*/ int Index;
                    /*0x14*/ int Suffix;

                    /*0x1179fe0*/ int get_LeadingZeroes();
                    /*0x117a000*/ void set_LeadingZeroes(int value);
                    /*0x1179ff0*/ int get_PositiveNumericSuffix();
                    /*0x117a020*/ void set_PositiveNumericSuffix(int value);
                    /*0x1179fd0*/ bool get_HasPositiveNumericSuffix();
                    /*0x1179de0*/ string NewString(char c, int count);
                    /*0x17b580*/ int ToFixedString<T>(ref T result);
                    /*0x1179f60*/ string ToString();
                    /*0x1179dd0*/ bool IsDigit(byte b);
                    /*0x17aec0*/ void SetString<T>(ref T value);
                    /*0x1179e80*/ void SetString(string value);
                }

                class NativeBitArrayUnsafeUtility
                {
                    static /*0x1177270*/ Unity.Collections.NativeBitArray ConvertExistingDataToNativeBitArray(void* ptr, int sizeInBytes, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                }

                class NativeListUnsafeUtility
                {
                    static /*0x2a5510*/ void* GetUnsafePtr<T>(Unity.Collections.NativeList<T> list);
                    static /*0x2a5510*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeList<T> list);
                    static /*0x2a5510*/ void* GetInternalListDataPtrUnchecked<T>(ref Unity.Collections.NativeList<T> list);
                }

                class NativeReferenceUnsafeUtility
                {
                    static /*0x2a5510*/ void* GetUnsafePtr<T>(Unity.Collections.NativeReference<T> reference);
                    static /*0x2a5510*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeReference<T> reference);
                    static /*0x2a5510*/ void* GetUnsafePtrWithoutChecks<T>(Unity.Collections.NativeReference<T> reference);
                }

                struct UnsafeAppendBuffer : Unity.Collections.INativeDisposable, System.IDisposable
                {
                    /*0x10*/ byte* Ptr;
                    /*0x18*/ int Length;
                    /*0x1c*/ int Capacity;
                    /*0x20*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x24*/ int Alignment;

                    static /*0x117edf0*/ void CheckAlignment(int alignment);
                    /*0x117f220*/ UnsafeAppendBuffer(int initialCapacity, int alignment, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x117f190*/ UnsafeAppendBuffer(void* ptr, int length);
                    /*0xc3ff30*/ bool get_IsEmpty();
                    /*0xb73aa0*/ bool get_IsCreated();
                    /*0x117eea0*/ void Dispose();
                    /*0x117ef30*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0xd03bf0*/ void Reset();
                    /*0x117f0a0*/ void SetCapacity(int capacity);
                    /*0x117f070*/ void ResizeUninitialized(int length);
                    /*0x2a5510*/ void Add<T>(T value);
                    /*0x117ed70*/ void Add(void* ptr, int structSize);
                    /*0x2a5510*/ void AddArray<T>(void* ptr, int length);
                    /*0x2a5510*/ void Add<T>(Unity.Collections.NativeArray<T> value);
                    /*0x117edc0*/ void Add(string value);
                    /*0x2a5510*/ T Pop<T>();
                    /*0x117f030*/ void Pop(void* ptr, int structSize);
                    /*0x117f180*/ byte[] ToBytes();
                    /*0x117edd0*/ Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer.Reader AsReader();

                    struct Reader
                    {
                        /*0x10*/ byte* Ptr;
                        /*0x18*/ int Size;
                        /*0x1c*/ int Offset;

                        /*0x117b3c0*/ Reader(ref Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer buffer);
                        /*0x117b3b0*/ Reader(void* ptr, int length);
                        /*0x117b3e0*/ bool get_EndOfBuffer();
                        /*0x17aec0*/ void ReadNext<T>(ref T value);
                        /*0x2a5510*/ T ReadNext<T>();
                        /*0x117b240*/ void* ReadNext(int structSize);
                        /*0x2a5510*/ void ReadNext<T>(ref Unity.Collections.NativeArray<T> value, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                        /*0x2a5510*/ void* ReadNextArray<T>(ref int length);
                        /*0x117b280*/ void ReadNext(ref string value);
                        /*0x117b0c0*/ void CheckBounds(int structSize);
                    }
                }

                struct UnsafeAtomicCounter32
                {
                    /*0x10*/ int* Counter;

                    /*0x9e29e0*/ UnsafeAtomicCounter32(void* ptr);
                    /*0x117f310*/ void Reset(int value);
                    /*0x117f2c0*/ int Add(int value);
                    /*0x117f3a0*/ int Sub(int value);
                    /*0x117f240*/ int AddSat(int value, int max);
                    /*0x117f320*/ int SubSat(int value, int min);
                }

                struct UnsafeAtomicCounter64
                {
                    /*0x10*/ long* Counter;

                    /*0x9e29e0*/ UnsafeAtomicCounter64(void* ptr);
                    /*0x117f4d0*/ void Reset(long value);
                    /*0x117f480*/ long Add(long value);
                    /*0x117f570*/ long Sub(long value);
                    /*0x117f3f0*/ long AddSat(long value, long max);
                    /*0x117f4e0*/ long SubSat(long value, long min);
                }

                struct UnsafeBitArray : Unity.Collections.INativeDisposable, System.IDisposable
                {
                    /*0x10*/ ulong* Ptr;
                    /*0x18*/ int Length;
                    /*0x1c*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    static /*0x117fcf0*/ void CheckSizeMultipleOf8(int sizeInBytes);
                    static /*0x117f660*/ void CheckArgsCopy(ref Unity.Collections.LowLevel.Unsafe.UnsafeBitArray dstBitArray, int dstPos, ref Unity.Collections.LowLevel.Unsafe.UnsafeBitArray srcBitArray, int srcPos, int numBits);
                    /*0x1180950*/ UnsafeBitArray(void* ptr, int sizeInBytes, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x1180970*/ UnsafeBitArray(int numBits, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0xb73aa0*/ bool get_IsCreated();
                    /*0x1180260*/ void Dispose();
                    /*0x11802f0*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x11772a0*/ void Clear();
                    /*0x1177420*/ void Set(int pos, bool value);
                    /*0x11805f0*/ void SetBits(int pos, bool value, int numBits);
                    /*0x11804e0*/ void SetBits(int pos, ulong value, int numBits);
                    /*0x11803f0*/ ulong GetBits(int pos, int numBits);
                    /*0x11773e0*/ bool IsSet(int pos);
                    /*0x117fdb0*/ void CopyUlong(int dstPos, ref Unity.Collections.LowLevel.Unsafe.UnsafeBitArray srcBitArray, int srcPos, int numBits);
                    /*0x11772f0*/ void Copy(int dstPos, int srcPos, int numBits);
                    /*0x117fe00*/ void Copy(int dstPos, ref Unity.Collections.LowLevel.Unsafe.UnsafeBitArray srcBitArray, int srcPos, int numBits);
                    /*0x1177380*/ int Find(int pos, int numBits);
                    /*0x11773b0*/ int Find(int pos, int count, int numBits);
                    /*0x1180890*/ bool TestNone(int pos, int numBits);
                    /*0x11807d0*/ bool TestAny(int pos, int numBits);
                    /*0x1180700*/ bool TestAll(int pos, int numBits);
                    /*0x1180090*/ int CountBits(int pos, int numBits);
                    /*0x117fbe0*/ void CheckArgs(int pos, int numBits);
                    /*0x117f840*/ void CheckArgsPosCount(int begin, int count, int numBits);
                    /*0x117fa50*/ void CheckArgsUlong(int pos, int numBits);
                }

                class UnsafeBitArrayDebugView
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeBitArray Data;

                    /*0x836380*/ UnsafeBitArrayDebugView(Unity.Collections.LowLevel.Unsafe.UnsafeBitArray data);
                    /*0x117f5c0*/ bool[] get_Bits();
                }

                struct UnsafeHashMapBucketData
                {
                    /*0x10*/ byte* values;
                    /*0x18*/ byte* keys;
                    /*0x20*/ byte* next;
                    /*0x28*/ byte* buckets;
                    /*0x30*/ int bucketCapacityMask;

                    /*0x1180b00*/ UnsafeHashMapBucketData(byte* v, byte* k, byte* n, byte* b, int bcm);
                }

                struct UnsafeHashMapData
                {
                    static int IntsPerCacheLine = 16;
                    /*0x10*/ byte* values;
                    /*0x18*/ byte* keys;
                    /*0x20*/ byte* next;
                    /*0x28*/ byte* buckets;
                    /*0x30*/ int keyCapacity;
                    /*0x34*/ int bucketCapacityMask;
                    /*0x38*/ int allocatedIndexLength;
                    /*0x50*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData.<firstFreeTLS> firstFreeTLS;

                    static /*0x1180da0*/ int GetBucketSize(int capacity);
                    static /*0x1180e20*/ int GrowCapacity(int capacity);
                    static /*0x2a5510*/ void AllocateHashMap<TKey, TValue>(int length, int bucketLength, Unity.Collections.AllocatorManager.AllocatorHandle label, ref Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* outBuf);
                    static /*0x2a5510*/ void ReallocateHashMap<TKey, TValue>(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, int newCapacity, int newBucketCapacity, Unity.Collections.AllocatorManager.AllocatorHandle label);
                    static /*0x1180d00*/ void DeallocateHashMap(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x2a5510*/ int CalculateDataSize<TKey, TValue>(int length, int bucketLength, ref int keyOffset, ref int nextOffset, ref int bucketOffset);
                    static /*0x1180e30*/ bool IsEmpty(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data);
                    static /*0x1180db0*/ int GetCount(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data);
                    static /*0x1180e80*/ bool MoveNext(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, ref int bucketIndex, ref int nextIndex, ref int index);
                    static /*0x2a5510*/ void GetKeyArray<TKey>(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, Unity.Collections.NativeArray<TKey> result);
                    static /*0x2a5510*/ void GetValueArray<TValue>(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, Unity.Collections.NativeArray<TValue> result);
                    static /*0x2a5510*/ void GetKeyValueArrays<TKey, TValue>(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, Unity.Collections.NativeKeyValueArrays<TKey, TValue> result);
                    static /*0x1180c90*/ void CheckHashMapReallocateDoesNotShrink(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, int newCapacity);
                    /*0x1180d70*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapBucketData GetBucketData();

                    struct <firstFreeTLS>e__FixedBuffer
                    {
                        /*0x10*/ int FixedElementField;
                    }
                }

                struct UnsafeHashMapDataDispose
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

                    /*0x1180b20*/ void Dispose();
                }

                struct UnsafeHashMapDataDisposeJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataDispose Data;

                    /*0x1180b20*/ void Execute();
                }

                struct UnsafeHashMapBase<TKey, TValue>
                {
                    static /*0x2a5510*/ void Clear(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data);
                    static /*0x2a5510*/ int AllocEntry(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, int threadIndex);
                    static /*0x2a5510*/ void FreeEntry(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, int idx, int threadIndex);
                    static /*0x2a5510*/ bool TryAddAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, TKey key, TValue item, int threadIndex);
                    static /*0x2a5510*/ void AddAtomicMulti(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, TKey key, TValue item, int threadIndex);
                    static /*0x2a5510*/ bool TryAdd(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, TKey key, TValue item, bool isMultiHashMap, Unity.Collections.AllocatorManager.AllocatorHandle allocation);
                    static /*0x2a5510*/ int Remove(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, TKey key, bool isMultiHashMap);
                    static /*0x2a5510*/ void Remove(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    static /*0x2a5510*/ void RemoveKeyValue<TValueEQ>(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, TKey key, TValueEQ value);
                    static /*0x2a5510*/ bool TryGetFirstValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, TKey key, ref TValue item, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    static /*0x2a5510*/ bool TryGetNextValueAtomic(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, ref TValue item, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    static /*0x2a5510*/ bool SetValue(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it, ref TValue item);
                    static /*0x1785d0*/ void CheckOutOfCapacity(int idx, int keyCapacity);
                    static /*0x2a5510*/ void CheckIndexOutOfBounds(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data, int idx);
                    static /*0x180ff0*/ void ThrowFull();
                    static /*0x180ff0*/ void ThrowInvalidIterator();
                }

                struct KeyValue<TKey, TValue>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                    /*0x0*/ int m_Index;
                    /*0x0*/ int m_Next;

                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> get_Null();
                    /*0x2a5510*/ TKey get_Key();
                    /*0x1803b0*/ ref TValue get_Value();
                    bool GetKeyValue(ref TKey key, ref TValue value);
                }

                struct UnsafeHashMapDataEnumerator
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                    /*0x18*/ int m_Index;
                    /*0x1c*/ int m_BucketIndex;
                    /*0x20*/ int m_NextIndex;

                    /*0x1180c70*/ UnsafeHashMapDataEnumerator(Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* data);
                    /*0x1180b90*/ bool MoveNext();
                    /*0x1180c50*/ void Reset();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> GetCurrent<TKey, TValue>();
                    /*0x2a5510*/ TKey GetCurrentKey<TKey>();
                }

                struct UnsafeHashMap<TKey, TValue> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

                    /*0x2a5510*/ UnsafeHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x180980*/ int Count();
                    /*0x180980*/ int get_Capacity();
                    /*0x17aa40*/ void set_Capacity(int value);
                    /*0x180fc0*/ void Clear();
                    /*0x2a5510*/ bool TryAdd(TKey key, TValue item);
                    /*0x2a5510*/ void Add(TKey key, TValue item);
                    /*0x2a5510*/ bool Remove(TKey key);
                    /*0x2a5510*/ bool TryGetValue(TKey key, ref TValue item);
                    /*0x2a5510*/ bool ContainsKey(TKey key);
                    /*0x2a5510*/ TValue get_Item(TKey key);
                    /*0x2a5510*/ void set_Item(TKey key, TValue value);
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x2a5510*/ Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap.ParallelWriter<TKey, TValue> AsParallelWriter();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap.Enumerator<TKey, TValue> GetEnumerator();
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    struct ParallelWriter<TKey, TValue>
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                        /*0x0*/ int m_ThreadIndex;

                        /*0x180980*/ int get_Capacity();
                        /*0x2a5510*/ bool TryAdd(TKey key, TValue item);
                    }

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataEnumerator m_Enumerator;

                        /*0x180fc0*/ void Dispose();
                        /*0x17cb40*/ bool MoveNext();
                        /*0x180fc0*/ void Reset();
                        /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> get_Current();
                        /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                struct UnsafeHashMapDisposeJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* Data;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    /*0x1180b20*/ void Execute();
                }

                class UnsafeHashMapDebuggerTypeProxy<TKey, TValue>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<TKey, TValue> m_Target;

                    /*0x2a5510*/ UnsafeHashMapDebuggerTypeProxy(Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<TKey, TValue> target);
                    /*0x1803b0*/ System.Collections.Generic.List<Unity.Collections.Pair<TKey, TValue>> get_Items();
                }

                struct UntypedUnsafeHashMap
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;
                }

                struct UnsafeHashSet<T> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap<T, bool> m_Data;

                    /*0x2a5510*/ UnsafeHashSet(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x180980*/ int Count();
                    /*0x180980*/ int get_Capacity();
                    /*0x17aa40*/ void set_Capacity(int value);
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x180fc0*/ void Clear();
                    /*0x2a5510*/ bool Add(T item);
                    /*0x2a5510*/ bool Remove(T item);
                    /*0x2a5510*/ bool Contains(T item);
                    /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashSet.ParallelWriter<T> AsParallelWriter();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashSet.Enumerator<T> GetEnumerator();
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    struct ParallelWriter<T>
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMap.ParallelWriter<T, bool> m_Data;

                        /*0x180980*/ int get_Capacity();
                        /*0x2a5510*/ bool Add(T item);
                    }

                    struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataEnumerator m_Enumerator;

                        /*0x180fc0*/ void Dispose();
                        /*0x17cb40*/ bool MoveNext();
                        /*0x180fc0*/ void Reset();
                        /*0x2a5510*/ T get_Current();
                        /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class UnsafeHashSetDebuggerTypeProxy<T>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> Data;

                    /*0x2a5510*/ UnsafeHashSetDebuggerTypeProxy(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> data);
                    /*0x1803b0*/ System.Collections.Generic.List<T> get_Items();
                }

                class HashSetExtensions
                {
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.NativeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList128Bytes<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList128Bytes<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList128Bytes<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList32Bytes<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList32Bytes<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList32Bytes<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList4096Bytes<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList4096Bytes<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList4096Bytes<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList512Bytes<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList512Bytes<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList512Bytes<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList64Bytes<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList64Bytes<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.FixedList64Bytes<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeArray<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeArray<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeArray<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeHashSet<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeHashSet<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeHashSet<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeList<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeList<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.NativeList<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> other);
                    static /*0x2a5510*/ void ExceptWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                    static /*0x2a5510*/ void IntersectWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                    static /*0x2a5510*/ void UnionWith<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> container, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                }

                struct UnsafeDisposeJob : Unity.Jobs.IJob
                {
                    /*0x10*/ void* Ptr;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;

                    /*0x1180aa0*/ void Execute();
                }

                struct UntypedUnsafeList
                {
                    /*0x10*/ void* Ptr;
                    /*0x18*/ int m_length;
                    /*0x1c*/ int m_capacity;
                    /*0x20*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x24*/ int obsolete_length;
                    /*0x28*/ int obsolete_capacity;
                }

                struct UnsafeList<T> : Unity.Collections.INativeDisposable, System.IDisposable, Unity.Collections.INativeList<T>, Unity.Collections.IIndexable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
                {
                    /*0x0*/ T* Ptr;
                    /*0x0*/ int m_length;
                    /*0x0*/ int m_capacity;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x0*/ int length;
                    /*0x0*/ int capacity;

                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> New<U>(int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> Create<U>(int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x2a5510*/ void Destroy<U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> listData, ref U allocator);
                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> Create(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x2a5510*/ void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> listData);
                    static /*0x2a5510*/ void CheckNull(void* listData);
                    /*0x2a5510*/ UnsafeList(T* ptr, int length);
                    /*0x2a5510*/ UnsafeList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x180980*/ int get_Length();
                    /*0x17aa40*/ void set_Length(int value);
                    /*0x180980*/ int get_Capacity();
                    /*0x17aa40*/ void set_Capacity(int value);
                    /*0x2a5510*/ T get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, T value);
                    /*0x184ab0*/ ref T ElementAt(int index);
                    /*0x2a5510*/ void Initialize<U>(int initialCapacity, ref U allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x17aec0*/ void Dispose<U>(ref U allocator);
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x180fc0*/ void Clear();
                    /*0x1817d0*/ void Resize(int length, Unity.Collections.NativeArrayOptions options);
                    /*0x182a70*/ void Realloc<U>(ref U allocator, int newCapacity);
                    /*0x17aa40*/ void Realloc(int capacity);
                    /*0x182a70*/ void SetCapacity<U>(ref U allocator, int capacity);
                    /*0x17aa40*/ void SetCapacity(int capacity);
                    /*0x180fc0*/ void TrimExcess();
                    /*0x2a5510*/ void AddNoResize(T value);
                    /*0x2a5510*/ void AddRangeNoResize(void* ptr, int count);
                    /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list);
                    /*0x17aec0*/ void Add(ref T value);
                    /*0x2a5510*/ void AddRange(void* ptr, int count);
                    /*0x2a5510*/ void AddRange(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list);
                    /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
                    /*0x17aa40*/ void RemoveAtSwapBack(int index);
                    /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
                    /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
                    /*0x17aa40*/ void RemoveAt(int index);
                    /*0x1817d0*/ void RemoveRange(int index, int count);
                    /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<T> AsParallelReader();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelWriter<T> AsParallelWriter();
                    /*0x2a5510*/ void CopyFrom(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> array);
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeList.Enumerator<T> GetEnumerator();
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                    /*0x1817d0*/ void CheckIndexCount(int index, int count);
                    /*0x1817d0*/ void CheckBeginEnd(int begin, int end);
                    /*0x17aa40*/ void CheckNoResizeHasEnoughCapacity(int length);
                    /*0x1817d0*/ void CheckNoResizeHasEnoughCapacity(int length, int index);

                    struct ParallelReader<T>
                    {
                        /*0x0*/ T* Ptr;
                        /*0x0*/ int Length;

                        /*0x2a5510*/ ParallelReader(T* ptr, int length);
                    }

                    struct ParallelWriter<T>
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> ListData;

                        /*0x2a5510*/ ParallelWriter(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> listData);
                        /*0x2a5510*/ void* get_Ptr();
                        /*0x2a5510*/ void AddNoResize(T value);
                        /*0x2a5510*/ void AddRangeNoResize(void* ptr, int count);
                        /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list);
                    }

                    struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ T* m_Ptr;
                        /*0x0*/ int m_Length;
                        /*0x0*/ int m_Index;

                        /*0x180fc0*/ void Dispose();
                        /*0x17cb40*/ bool MoveNext();
                        /*0x180fc0*/ void Reset();
                        /*0x2a5510*/ T get_Current();
                        /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class UnsafeListExtensions
                {
                    static /*0x2a5510*/ int IndexOf<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, U value);
                    static /*0x2a5510*/ bool Contains<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> list, U value);
                    static /*0x2a5510*/ int IndexOf<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<T> list, U value);
                    static /*0x2a5510*/ bool Contains<T, U>(Unity.Collections.LowLevel.Unsafe.UnsafeList.ParallelReader<T> list, U value);
                    static /*0x2a5510*/ bool ArraysEqual<T>(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> array, Unity.Collections.LowLevel.Unsafe.UnsafeList<T> other);
                }

                class UnsafeListTDebugView<T>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<T> Data;

                    /*0x2a5510*/ UnsafeListTDebugView(Unity.Collections.LowLevel.Unsafe.UnsafeList<T> data);
                    /*0x1803b0*/ T[] get_Items();
                }

                struct UnsafePtrList<T> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<nint>, System.Collections.IEnumerable
                {
                    /*0x0*/ T** Ptr;
                    /*0x0*/ int m_length;
                    /*0x0*/ int m_capacity;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x0*/ int length;
                    /*0x0*/ int capacity;

                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> Create(T** ptr, int length);
                    static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> Create(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    static /*0x2a5510*/ void Destroy(Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> listData);
                    /*0x2a5510*/ UnsafePtrList(T** ptr, int length);
                    /*0x2a5510*/ UnsafePtrList(int initialCapacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x180980*/ int get_Length();
                    /*0x17aa40*/ void set_Length(int value);
                    /*0x180980*/ int get_Capacity();
                    /*0x17aa40*/ void set_Capacity(int value);
                    /*0x2a5510*/ T* get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, T* value);
                    /*0x184ab0*/ ref T* ElementAt(int index);
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x180fc0*/ void Clear();
                    /*0x1817d0*/ void Resize(int length, Unity.Collections.NativeArrayOptions options);
                    /*0x17aa40*/ void SetCapacity(int capacity);
                    /*0x180fc0*/ void TrimExcess();
                    /*0x2a5510*/ int IndexOf(void* ptr);
                    /*0x2a5510*/ bool Contains(void* ptr);
                    /*0x2a5510*/ void AddNoResize(void* value);
                    /*0x2a5510*/ void AddRangeNoResize(void** ptr, int count);
                    /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> list);
                    /*0x17aec0*/ void Add(ref nint value);
                    /*0x2a5510*/ void Add(void* value);
                    /*0x2a5510*/ void AddRange(void* ptr, int length);
                    /*0x2a5510*/ void AddRange(Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> list);
                    /*0x1817d0*/ void InsertRangeWithBeginEnd(int begin, int end);
                    /*0x17aa40*/ void RemoveAtSwapBack(int index);
                    /*0x1817d0*/ void RemoveRangeSwapBack(int index, int count);
                    /*0x1817d0*/ void RemoveRangeSwapBackWithBeginEnd(int begin, int end);
                    /*0x17aa40*/ void RemoveAt(int index);
                    /*0x1817d0*/ void RemoveRange(int index, int count);
                    /*0x1817d0*/ void RemoveRangeWithBeginEnd(int begin, int end);
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<nint> System.Collections.Generic.IEnumerable<System.IntPtr>.GetEnumerator();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList.ParallelReader<T> AsParallelReader();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList.ParallelWriter<T> AsParallelWriter();

                    struct ParallelReader<T>
                    {
                        /*0x0*/ T** Ptr;
                        /*0x0*/ int Length;

                        /*0x2a5510*/ ParallelReader(T** ptr, int length);
                        /*0x2a5510*/ int IndexOf(void* ptr);
                        /*0x2a5510*/ bool Contains(void* ptr);
                    }

                    struct ParallelWriter<T>
                    {
                        /*0x0*/ T** Ptr;
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeList<nint> ListData;

                        /*0x2a5510*/ ParallelWriter(T** ptr, Unity.Collections.LowLevel.Unsafe.UnsafeList<nint> listData);
                        /*0x2a5510*/ void AddNoResize(T* value);
                        /*0x2a5510*/ void AddRangeNoResize(T** ptr, int count);
                        /*0x2a5510*/ void AddRangeNoResize(Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> list);
                    }
                }

                class UnsafePtrListTExtensions
                {
                    static /*0x17e030*/ ref Unity.Collections.LowLevel.Unsafe.UnsafeList<nint> ListData<T>(ref Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> from);
                }

                class UnsafePtrListTDebugView<T>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> Data;

                    /*0x2a5510*/ UnsafePtrListTDebugView(Unity.Collections.LowLevel.Unsafe.UnsafePtrList<T> data);
                    /*0x1803b0*/ T*[] get_Items();
                }

                struct UnsafeMultiHashMap<TKey, TValue> : Unity.Collections.INativeDisposable, System.IDisposable, System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerable
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle m_AllocatorLabel;

                    /*0x2a5510*/ UnsafeMultiHashMap(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x180980*/ int Count();
                    /*0x180980*/ int get_Capacity();
                    /*0x17aa40*/ void set_Capacity(int value);
                    /*0x180fc0*/ void Clear();
                    /*0x2a5510*/ void Add(TKey key, TValue item);
                    /*0x2a5510*/ int Remove(TKey key);
                    /*0x2a5510*/ void Remove<TValueEQ>(TKey key, TValueEQ value);
                    /*0x2a5510*/ void Remove(Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    /*0x2a5510*/ bool TryGetFirstValue(TKey key, ref TValue item, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    bool TryGetNextValue(ref TValue item, ref Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    /*0x2a5510*/ bool ContainsKey(TKey key);
                    /*0x2a5510*/ int CountValuesForKey(TKey key);
                    /*0x2a5510*/ bool SetValue(TValue item, Unity.Collections.NativeMultiHashMapIterator<TKey> it);
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x2a5510*/ Unity.Collections.NativeArray<TKey> GetKeyArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.NativeArray<TValue> GetValueArray(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.NativeKeyValueArrays<TKey, TValue> GetKeyValueArrays(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap.Enumerator<TKey, TValue> GetValuesForKey(TKey key);
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap.ParallelWriter<TKey, TValue> AsParallelWriter();
                    /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap.KeyValueEnumerator<TKey, TValue> GetEnumerator();
                    /*0x1803b0*/ System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator();
                    /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    struct Enumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<TValue>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> hashmap;
                        /*0x0*/ TKey key;
                        /*0x0*/ bool isFirst;
                        /*0x0*/ TValue value;
                        /*0x0*/ Unity.Collections.NativeMultiHashMapIterator<TKey> iterator;

                        /*0x180fc0*/ void Dispose();
                        /*0x17cb40*/ bool MoveNext();
                        /*0x180fc0*/ void Reset();
                        /*0x2a5510*/ TValue get_Current();
                        /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                        /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap.Enumerator<TKey, TValue> GetEnumerator();
                    }

                    struct ParallelWriter<TKey, TValue>
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapData* m_Buffer;
                        /*0x0*/ int m_ThreadIndex;

                        /*0x180980*/ int get_Capacity();
                        /*0x2a5510*/ void Add(TKey key, TValue item);
                    }

                    struct KeyValueEnumerator<TKey, TValue> : System.Collections.Generic.IEnumerator<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue>>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeHashMapDataEnumerator m_Enumerator;

                        /*0x180fc0*/ void Dispose();
                        /*0x17cb40*/ bool MoveNext();
                        /*0x180fc0*/ void Reset();
                        /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.KeyValue<TKey, TValue> get_Current();
                        /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class UnsafeMultiHashMapDebuggerTypeProxy<TKey, TValue>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> m_Target;

                    static /*0x2a5510*/ System.ValueTuple<Unity.Collections.NativeArray<TKey>, int> GetUniqueKeyArray(ref Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> hashMap, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x2a5510*/ UnsafeMultiHashMapDebuggerTypeProxy(Unity.Collections.LowLevel.Unsafe.UnsafeMultiHashMap<TKey, TValue> target);
                    /*0x1803b0*/ System.Collections.Generic.List<Unity.Collections.ListPair<TKey, System.Collections.Generic.List<TValue>>> get_Items();
                }

                struct RingControl
                {
                    /*0x10*/ int Capacity;
                    /*0x14*/ int Current;
                    /*0x18*/ int Write;
                    /*0x1c*/ int Read;

                    /*0x117bf50*/ RingControl(int capacity);
                    /*0x117bf40*/ void Reset();
                    /*0x117bed0*/ int Distance(int from, int to);
                    /*0x117be10*/ int Available();
                    /*0x117bef0*/ int Reserve(int count);
                    /*0x117be30*/ int Commit(int count);
                    /*0x117be80*/ int Consume(int count);
                    /*0x117bf60*/ int get_Length();
                }

                struct UnsafeRingQueue<T> : Unity.Collections.INativeDisposable, System.IDisposable
                {
                    /*0x0*/ T* Ptr;
                    /*0x0*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.RingControl Control;

                    static /*0x180ff0*/ void ThrowQueueFull();
                    static /*0x180ff0*/ void ThrowQueueEmpty();
                    /*0x2a5510*/ UnsafeRingQueue(T* ptr, int capacity);
                    /*0x2a5510*/ UnsafeRingQueue(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator, Unity.Collections.NativeArrayOptions options);
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x180980*/ int get_Length();
                    /*0x180980*/ int get_Capacity();
                    /*0x17cb40*/ bool get_IsCreated();
                    /*0x180fc0*/ void Dispose();
                    /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x2a5510*/ bool TryEnqueue(T value);
                    /*0x2a5510*/ void Enqueue(T value);
                    /*0x17e620*/ bool TryDequeue(ref T item);
                    /*0x2a5510*/ T Dequeue();
                }

                class UnsafeRingQueueDebugView<T>
                {
                    /*0x0*/ Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue<T> Data;

                    /*0x2a5510*/ UnsafeRingQueueDebugView(Unity.Collections.LowLevel.Unsafe.UnsafeRingQueue<T> data);
                    /*0x1803b0*/ T[] get_Items();
                }

                struct UnsafeScratchAllocator
                {
                    /*0x10*/ void* m_Pointer;
                    /*0x18*/ int m_LengthInBytes;
                    /*0x1c*/ int m_CapacityInBytes;

                    /*0x1182fd0*/ UnsafeScratchAllocator(void* ptr, int capacityInBytes);
                    /*0x1182ed0*/ void CheckAllocationDoesNotExceedCapacity(ulong requestedSize);
                    /*0x1182e30*/ void* Allocate(int sizeInBytes, int alignmentInBytes);
                    /*0x2a5510*/ void* Allocate<T>(int count);
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
                    static int AllocationSize = 4096;
                    /*0x10*/ Unity.Collections.AllocatorManager.AllocatorHandle Allocator;
                    /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock** Blocks;
                    /*0x20*/ int BlockCount;
                    /*0x28*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Free;
                    /*0x30*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamRange* Ranges;
                    /*0x38*/ int RangeCount;

                    /*0x1182fe0*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* Allocate(Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* oldBlock, int threadIndex);
                }

                struct UnsafeStream : Unity.Collections.INativeDisposable, System.IDisposable
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData* m_Block;
                    /*0x18*/ Unity.Collections.AllocatorManager.AllocatorHandle m_Allocator;

                    static /*0x2a5510*/ Unity.Jobs.JobHandle ScheduleConstruct<T>(ref Unity.Collections.LowLevel.Unsafe.UnsafeStream stream, Unity.Collections.NativeList<T> bufferCount, Unity.Jobs.JobHandle dependency, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x1183530*/ Unity.Jobs.JobHandle ScheduleConstruct(ref Unity.Collections.LowLevel.Unsafe.UnsafeStream stream, Unity.Collections.NativeArray<int> bufferCount, Unity.Jobs.JobHandle dependency, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    static /*0x1183110*/ void AllocateBlock(ref Unity.Collections.LowLevel.Unsafe.UnsafeStream stream, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x11783d0*/ UnsafeStream(int bufferCount, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x1183240*/ void AllocateForEach(int forEachCount);
                    /*0x11834d0*/ bool IsEmpty();
                    /*0xb73aa0*/ bool get_IsCreated();
                    /*0x1178410*/ int get_ForEachCount();
                    /*0x1183370*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream.Reader AsReader();
                    /*0x1183390*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream.Writer AsWriter();
                    /*0x11781c0*/ int Count();
                    /*0x2a5510*/ Unity.Collections.NativeArray<T> ToNativeArray<T>(Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x11833c0*/ void Deallocate();
                    /*0x1173bb0*/ void Dispose();
                    /*0x1178220*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);

                    struct DisposeJob : Unity.Jobs.IJob
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;

                        /*0x1173bb0*/ void Execute();
                    }

                    struct ConstructJobList : Unity.Jobs.IJob
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;
                        /*0x20*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList* List;

                        /*0x1173b70*/ void Execute();
                    }

                    struct ConstructJob : Unity.Jobs.IJob
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStream Container;
                        /*0x20*/ Unity.Collections.NativeArray<int> Length;

                        /*0x1173ba0*/ void Execute();
                    }

                    struct Writer
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData* m_BlockStream;
                        /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* m_CurrentBlock;
                        /*0x20*/ byte* m_CurrentPtr;
                        /*0x28*/ byte* m_CurrentBlockEnd;
                        /*0x30*/ int m_ForeachIndex;
                        /*0x34*/ int m_ElementCount;
                        /*0x38*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* m_FirstBlock;
                        /*0x40*/ int m_FirstOffset;
                        /*0x44*/ int m_NumberOfBlocks;
                        /*0x48*/ int m_ThreadIndex;

                        /*0x1184080*/ Writer(ref Unity.Collections.LowLevel.Unsafe.UnsafeStream stream);
                        /*0x1178410*/ int get_ForEachCount();
                        /*0x1183f50*/ void BeginForEachIndex(int foreachIndex);
                        /*0x1183f80*/ void EndForEachIndex();
                        /*0x2a5510*/ void Write<T>(T value);
                        /*0x1803b0*/ ref T Allocate<T>();
                        /*0x1183ec0*/ byte* Allocate(int size);
                    }

                    struct Reader
                    {
                        /*0x10*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlockData* m_BlockStream;
                        /*0x18*/ Unity.Collections.LowLevel.Unsafe.UnsafeStreamBlock* m_CurrentBlock;
                        /*0x20*/ byte* m_CurrentPtr;
                        /*0x28*/ byte* m_CurrentBlockEnd;
                        /*0x30*/ int m_RemainingItemCount;
                        /*0x34*/ int m_LastBlockSize;

                        /*0x117b390*/ Reader(ref Unity.Collections.LowLevel.Unsafe.UnsafeStream stream);
                        /*0x117aff0*/ int BeginForEachIndex(int foreachIndex);
                        /*0x32d010*/ void EndForEachIndex();
                        /*0x1178410*/ int get_ForEachCount();
                        /*0x3e3af0*/ int get_RemainingItemCount();
                        /*0x117b2f0*/ byte* ReadUnsafePtr(int size);
                        /*0x1803b0*/ ref T Read<T>();
                        /*0x1803b0*/ ref T Peek<T>();
                        /*0x11781c0*/ int Count();
                    }
                }

                class UnsafeTextExtensions
                {
                    static /*0x1187e40*/ ref Unity.Collections.LowLevel.Unsafe.UnsafeList<byte> AsUnsafeListOfBytes(ref Unity.Collections.LowLevel.Unsafe.UnsafeText text);
                }

                struct UnsafeText : Unity.Collections.INativeDisposable, System.IDisposable, Unity.Collections.IUTF8Bytes, Unity.Collections.INativeList<byte>, Unity.Collections.IIndexable<byte>
                {
                    /*0x10*/ Unity.Collections.LowLevel.Unsafe.UntypedUnsafeList m_UntypedListData;

                    static /*0x1187e80*/ void CheckCapacityInRange(int value, int length);
                    /*0x11884e0*/ UnsafeText(int capacity, Unity.Collections.AllocatorManager.AllocatorHandle allocator);
                    /*0x1188620*/ bool get_IsCreated();
                    /*0x1188180*/ void Dispose();
                    /*0x11881f0*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
                    /*0x1188690*/ bool get_IsEmpty();
                    /*0x1188760*/ byte get_Item(int index);
                    /*0x1188890*/ void set_Item(int index, byte value);
                    /*0x1188290*/ ref byte ElementAt(int index);
                    /*0x1188170*/ void Clear();
                    /*0x6937d0*/ byte* GetUnsafePtr();
                    /*0x1188410*/ bool TryResize(int newLength, Unity.Collections.NativeArrayOptions clearOptions);
                    /*0x11885b0*/ int get_Capacity();
                    /*0x1188810*/ void set_Capacity(int value);
                    /*0x11887a0*/ int get_Length();
                    /*0x11888e0*/ void set_Length(int value);
                    /*0x1188360*/ string ToString();
                    /*0x1187fc0*/ void CheckIndexInRange(int index);
                    /*0x11882d0*/ void ThrowCopyError(Unity.Collections.CopyError error, string source);
                }

                class UnsafeUtilityExtensions
                {
                    static /*0x1188af0*/ void MemSwap(void* ptr, void* otherPtr, long size);
                    static /*0x2a5510*/ T ReadArrayElementBoundsChecked<T>(void* source, int index, int capacity);
                    static /*0x2a5510*/ void WriteArrayElementBoundsChecked<T>(void* destination, int index, T value, int capacity);
                    static /*0x2a5510*/ void* AddressOf<T>(ref T value);
                    static /*0x17e030*/ ref T AsRef<T>(ref T value);
                    static /*0x1188a80*/ void CheckMemSwapOverlap(byte* dst, byte* src, long size);
                    static /*0x11889a0*/ void CheckIndexRange(int index, int capacity);
                }

                namespace NotBurstCompatible
                {
                    class Extensions
                    {
                        static /*0x2a5510*/ T[] ToArray<T>(Unity.Collections.LowLevel.Unsafe.UnsafeHashSet<T> set);
                        static /*0x1187ba0*/ void AddNBC(ref Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer buffer, string value);
                        static /*0x1187d00*/ byte[] ToBytesNBC(ref Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer buffer);
                        static /*0x1187c20*/ void ReadNextNBC(ref Unity.Collections.LowLevel.Unsafe.UnsafeAppendBuffer.Reader reader, ref string value);
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 2CF2F88BF9B71283059B6DF53E5BCDE20ADBFD9E8D6CE2C1AB106262BB283BED;
    static /*0xc0*/ <PrivateImplementationDetails> 4033DE056C06586368C45BBBBAFC01D4C6E1DDCAD21DD290BBBF8C82593C00E3;
    static /*0x3225*/ <PrivateImplementationDetails> D710173E5FD56DEC44908D3A806A79A42646675106C764DF4F820BA9A1710E12;

    struct __StaticArrayInitTypeSize=192
    {
    }

    struct __StaticArrayInitTypeSize=5135
    {
    }

    struct __StaticArrayInitTypeSize=12645
    {
    }
}

class $BurstDirectCallInitializer
{
    static /*0x1187d80*/ void Initialize();
}
