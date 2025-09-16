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
                        /*0x10*/ UnityEngine.LowLevel.PlayerLoopSystem SchedulerLoopSystem;
                        /*0x38*/ Unity.Services.Core.Scheduler.Internal.ITimeProvider m_TimeProvider;
                        /*0x40*/ object m_Lock;
                        /*0x48*/ Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ScheduledActions;
                        /*0x50*/ System.Collections.Generic.Dictionary<long, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_IdScheduledInvocationMap;
                        /*0x58*/ System.Collections.Generic.List<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation> m_ExpiredActions;
                        /*0x60*/ long m_NextId;

                        static /*0x7d19e3c*/ void UpdateCurrentPlayerLoopWith(System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystem> subSystemList, UnityEngine.LowLevel.PlayerLoopSystem currentPlayerLoop);
                        /*0x7d19568*/ ActionScheduler();
                        /*0x7d195cc*/ ActionScheduler(Unity.Services.Core.Scheduler.Internal.ITimeProvider timeProvider);
                        /*0x7d19874*/ void ExecuteExpiredActions();
                        /*0x7d19ec8*/ void JoinPlayerLoopSystem();
                    }

                    class MinimumBinaryHeap
                    {
                        /*0x7d1a098*/ MinimumBinaryHeap();
                    }

                    class MinimumBinaryHeap<T> : Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap
                    {
                        /*0x0*/ object m_Lock;
                        /*0x0*/ System.Collections.Generic.IComparer<T> m_Comparer;
                        /*0x0*/ int m_MinimumCapacity;
                        /*0x0*/ T[] m_HeapArray;
                        /*0x0*/ int <Count>k__BackingField;

                        static /*0x3843dfc*/ void Swap(ref T lhs, ref T rhs);
                        static /*0x382d234*/ int GetParentIndex(int index);
                        static /*0x382d234*/ int GetLeftChildIndex(int index);
                        static /*0x382d234*/ int GetRightChildIndex(int index);
                        /*0x381678c*/ MinimumBinaryHeap(System.Collections.Generic.IComparer<T> comparer, int minimumCapacity);
                        MinimumBinaryHeap(System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IComparer<T> comparer, int minimumCapacity);
                        /*0x3814574*/ int get_Count();
                        /*0x3815ed0*/ void set_Count(int value);
                        /*0x3910ae8*/ T get_Min();
                        /*0x3910ae8*/ void Insert(T item);
                        /*0x38159dc*/ void IncreaseHeapCapacityWhenFull();
                        /*0x3910ae8*/ void Remove(T item);
                        /*0x3910ae8*/ int IndexOf(T item);
                        /*0x3910ae8*/ T ExtractMin();
                        /*0x38159dc*/ void DecreaseHeapCapacityWhenSpare();
                        /*0x38159dc*/ void MinHeapify();
                        /*0x3816710*/ void <MinHeapify>g__UpdateSmallestIndex|21_0(ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass21_0<T> );
                        /*0x3816044*/ void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap.<>c__DisplayClass21_0<T> );

                        struct <>c__DisplayClass21_0<T>
                        {
                            /*0x0*/ int smallest;
                            /*0x0*/ int currentIndex;
                            /*0x0*/ Unity.Services.Core.Scheduler.Internal.MinimumBinaryHeap<T> <>4__this;
                        }
                    }

                    class ScheduledInvocation
                    {
                        /*0x10*/ System.Action Action;
                        /*0x18*/ System.DateTime InvocationTime;
                        /*0x20*/ long ActionId;
                    }

                    class ScheduledInvocationComparer : System.Collections.Generic.IComparer<Unity.Services.Core.Scheduler.Internal.ScheduledInvocation>
                    {
                        /*0x7d1986c*/ ScheduledInvocationComparer();
                        /*0x7d1a0a0*/ int Compare(Unity.Services.Core.Scheduler.Internal.ScheduledInvocation x, Unity.Services.Core.Scheduler.Internal.ScheduledInvocation y);
                    }

                    interface ITimeProvider
                    {
                        /*0x381440c*/ System.DateTime get_Now();
                    }

                    class UtcTimeProvider : Unity.Services.Core.Scheduler.Internal.ITimeProvider
                    {
                        /*0x7d195c4*/ UtcTimeProvider();
                        /*0x7d1a158*/ System.DateTime get_Now();
                    }
                }
            }
        }
    }
}
