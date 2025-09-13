class <Module>
{
}

namespace FxResources
{
    namespace System
    {
        namespace Buffers
        {
            class SR
            {
            }
        }
    }
}

namespace System
{
    class SR
    {
        static /*0x0*/ System.Resources.ResourceManager s_resourceManager;

        static /*0x2b383e4*/ System.Resources.ResourceManager get_ResourceManager();
        static /*0x2b384fc*/ string GetResourceString(string resourceKey, string defaultString);
        static /*0x2b385f0*/ string get_ArgumentException_BufferNotFromPool();
        static /*0x2b38484*/ System.Type get_ResourceType();
    }

    namespace Buffers
    {
        class ArrayPool<T>
        {
            static /*0x0*/ System.Buffers.ArrayPool<T> s_sharedInstance;

            static System.Buffers.ArrayPool<T> get_Shared();
            static System.Buffers.ArrayPool<T> EnsureSharedCreated();
            static System.Buffers.ArrayPool<T> Create();
            static System.Buffers.ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket);
            ArrayPool();
            T[] Rent(int minimumLength);
            void Return(T[] array, bool clearArray);
        }

        class ArrayPoolEventSource : System.Diagnostics.Tracing.EventSource
        {
            static /*0x0*/ System.Buffers.ArrayPoolEventSource Log;

            static /*0x2b38388*/ ArrayPoolEventSource();
            /*0x2b38324*/ ArrayPoolEventSource();
            /*0x2b38318*/ void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId);
            /*0x2b3831c*/ void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, System.Buffers.ArrayPoolEventSource.BufferAllocatedReason reason);
            /*0x2b38320*/ void BufferReturned(int bufferId, int bufferSize, int poolId);

            enum BufferAllocatedReason
            {
                Pooled = 0,
                OverMaximumSize = 1,
                PoolExhausted = 2,
            }
        }

        class DefaultArrayPool<T> : System.Buffers.ArrayPool<T>
        {
            static /*0x0*/ T[] s_emptyArray;
            /*0x0*/ System.Buffers.DefaultArrayPool.Bucket<T> _buckets;

            DefaultArrayPool();
            DefaultArrayPool(int maxArrayLength, int maxArraysPerBucket);
            int get_Id();
            T[] Rent(int minimumLength);
            void Return(T[] array, bool clearArray);

            class Bucket<T>
            {
                /*0x0*/ int _bufferLength;
                /*0x0*/ T[][] _buffers;
                /*0x0*/ int _poolId;
                /*0x0*/ System.Threading.SpinLock _lock;
                /*0x0*/ int _index;

                Bucket(int bufferLength, int numberOfBuffers, int poolId);
                int get_Id();
                T[] Rent();
                void Return(T[] array);
            }
        }

        class Utilities
        {
            static /*0x2b38638*/ int SelectBucketIndex(int bufferSize);
            static /*0x2b386b4*/ int GetMaxSizeForBucket(int binIndex);
        }
    }
}
