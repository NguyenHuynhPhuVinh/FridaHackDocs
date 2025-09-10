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
                    class ActionScheduler : Unity.Services.Core.Scheduler.Internal.IActionScheduler, Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x10*/ Unity.Services.Core.Scheduler.Internal.ITimeProvider m_TimeProvider;
                        /*0x18*/ object m_Lock;
                        /*0x20*/ Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ScheduledActions;
                        /*0x28*/ System.Collections.Generic.Dictionary<long, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_IdScheduledInvocationMap;
                        /*0x30*/ UnityEngine.LowLevel.PlayerLoopSystem SchedulerLoopSystem;
                        /*0x58*/ long m_NextId;

                        static /*0x120c6c4*/ void UpdateSubSystemList(System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> subSystemList, UnityEngine.LowLevel.PlayerLoopSystem currentPlayerLoop);
                        /*0x120ba14*/ ActionScheduler();
                        /*0x120ba80*/ ActionScheduler(Unity.Services.Core.Scheduler.Internal.ITimeProvider timeProvider);
                        /*0x120bc88*/ long ScheduleAction(System.Action action, double delaySeconds);
                        /*0x120bf68*/ void CancelAction(long actionId);
                        /*0x120c114*/ void ExecuteExpiredActions();
                        /*0x120c744*/ void JoinPlayerLoopSystem();
                    }

                    class MinimumBinaryHeap
                    {
                        /*0x120c900*/ MinimumBinaryHeap();
                    }

                    class MinimumBinaryHeap<T> : Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap
                    {
                        /*0x0*/ System.Collections.Generic.IComparer<T> m_Comparer;
                        /*0x0*/ int m_MinimumCapacity;
                        /*0x0*/ T[] m_HeapArray;
                        /*0x0*/ int <Count>k__BackingField;

                        static void Swap(ref T lhs, ref T rhs);
                        static int Parent(int key);
                        static int LeftChild(int key);
                        static int RightChild(int key);
                        MinimumBinaryHeap(System.Collections.Generic.IComparer<T> comparer, int minimumCapacity);
                        MinimumBinaryHeap(System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IComparer<T> comparer, int minimumCapacity);
                        int get_Count();
                        void set_Count(int value);
                        T get_Min();
                        void Insert(T data);
                        void IncreaseHeapCapacityWhenFull();
                        void Remove(T data);
                        T ExtractMin();
                        void DecreaseHeapCapacityWhenSpare();
                        int GetKey(T data);
                        void MinHeapify();
                        void <MinHeapify>g__UpdateSmallestKey|20_0(ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass20_0<T> );
                        void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|20_1(int candidate, ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass20_0<T> );

                        struct <>c__DisplayClass20_0<T>
                        {
                            /*0x0*/ int smallest;
                            /*0x0*/ int key;
                            /*0x0*/ Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T> <>4__this;
                        }
                    }

                    class ScheduledInvocation
                    {
                        /*0x10*/ System.Action Action;
                        /*0x18*/ System.DateTime InvocationTime;
                        /*0x20*/ long ActionId;

                        /*0x120bf60*/ ScheduledInvocation();
                    }

                    class ScheduledInvocationComparer : System.Collections.Generic.IComparer<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation>
                    {
                        /*0x120bc80*/ ScheduledInvocationComparer();
                        /*0x120c908*/ int Compare(Unity.Services.Core.Scheduler.Internal.ScheduledInvocation x, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation y);
                    }

                    interface ITimeProvider
                    {
                        System.DateTime get_Now();
                    }

                    class UtcTimeProvider : Unity.Services.Core.Scheduler.Internal.ITimeProvider
                    {
                        /*0x120ba78*/ UtcTimeProvider();
                        /*0x120c974*/ System.DateTime get_Now();
                    }
                }
            }
        }
    }
}
