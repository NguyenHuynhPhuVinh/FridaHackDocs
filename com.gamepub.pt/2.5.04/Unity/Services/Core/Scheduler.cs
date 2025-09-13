class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Scheduler
            {
                namespace Internal
                {
                    class ScheduledInvocation : System.IComparable<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation>
                    {
                        /*0x10*/ System.Action Action;
                        /*0x18*/ System.DateTime InvocationTime;
                        /*0x20*/ long ActionId;

                        /*0x2b2e5ac*/ ScheduledInvocation();
                        /*0x2b2eb28*/ int CompareTo(Unity.Services.Core.Scheduler.Internal.ScheduledInvocation that);
                    }

                    class ActionScheduler : Unity.Services.Core.Scheduler.Internal.IActionScheduler, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ Unity.Services.Core.Scheduler.Internal.ITimeProvider m_TimeProvider;
                        /*0x18*/ Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ScheduledActions;
                        /*0x20*/ System.Collections.Generic.Dictionary<long, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_IdScheduledInvocationMap;
                        /*0x28*/ UnityEngine.LowLevel.PlayerLoopSystem SchedulerLoopSystem;
                        /*0x50*/ long m_NextId;

                        static /*0x2b2e934*/ void UpdateSubSystemList(System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> subSystemList, UnityEngine.LowLevel.PlayerLoopSystem currentPlayerLoop);
                        /*0x2b2e194*/ ActionScheduler();
                        /*0x2b2e1fc*/ ActionScheduler(Unity.Services.Core.Scheduler.Internal.ITimeProvider timeProvider);
                        /*0x2b2e38c*/ long ScheduleAction(System.Action action, double delaySeconds);
                        /*0x2b2e5b4*/ void CancelAction(long actionId);
                        /*0x2b2e6b0*/ void ExecuteExpiredActions();
                        /*0x2b2e9c0*/ void JoinPlayerLoopSystem();
                    }

                    class MinimumBinaryHeap<T>
                    {
                        /*0x0*/ int m_MinimumCapacity;
                        /*0x0*/ T[] m_HeapArray;
                        /*0x0*/ int m_Count;

                        static void Swap(ref T lhs, ref T rhs);
                        static int Parent(int key);
                        static int LeftChild(int key);
                        static int RightChild(int key);
                        MinimumBinaryHeap(int capacity);
                        int get_Count();
                        T get_Min();
                        void Insert(T data);
                        void IncreaseHeapCapacityWhenFull();
                        void Remove(T data);
                        T ExtractMin();
                        void DecreaseHeapCapacityWhenSpare();
                        int GetKey(T data);
                        void MinHeapify(int key);
                    }

                    interface ITimeProvider
                    {
                        System.DateTime get_Now();
                    }

                    class UtcTimeProvider : Unity.Services.Core.Scheduler.Internal.ITimeProvider
                    {
                        /*0x2b2e1f4*/ UtcTimeProvider();
                        /*0x2b2eb7c*/ System.DateTime get_Now();
                    }
                }
            }
        }
    }
}
