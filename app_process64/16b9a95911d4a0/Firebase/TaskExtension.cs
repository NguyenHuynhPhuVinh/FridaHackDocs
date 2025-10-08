class <Module>
{
}

namespace Firebase
{
    namespace Extensions
    {
        class TaskExtension
        {
            static /*0x2d54da0*/ System.Threading.Tasks.Task ContinueWithOnMainThread(System.Threading.Tasks.Task task, System.Action<System.Threading.Tasks.Task> continuation);
            static /*0x1f32888*/ System.Threading.Tasks.Task ContinueWithOnMainThread<T>(System.Threading.Tasks.Task<T> task, System.Action<System.Threading.Tasks.Task<T>> continuation);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ System.Action<System.Threading.Tasks.Task> continuation;

                /*0x2d54e9c*/ <>c__DisplayClass0_0();
                /*0x2d54ea4*/ System.Threading.Tasks.Task<bool> <ContinueWithOnMainThread>b__0(System.Threading.Tasks.Task t);
            }

            class <>c__DisplayClass0_1
            {
                /*0x10*/ System.Threading.Tasks.Task t;
                /*0x18*/ Firebase.Extensions.TaskExtension.<> CS$<>8__locals1;

                /*0x2d54fb8*/ <>c__DisplayClass0_1();
                /*0x2d54fc0*/ bool <ContinueWithOnMainThread>b__1();
            }

            class <>c__DisplayClass4_0<T>
            {
                /*0x0*/ System.Action<System.Threading.Tasks.Task<T>> continuation;

                /*0x1f309e4*/ <>c__DisplayClass4_0();
                /*0x1f302cc*/ System.Threading.Tasks.Task<bool> <ContinueWithOnMainThread>b__0(System.Threading.Tasks.Task<T> t);
            }

            class <>c__DisplayClass4_<T>
            {
                /*0x0*/ System.Threading.Tasks.Task<T> t;
                /*0x0*/ Firebase.Extensions.TaskExtension.<>c__DisplayClass4_0<T> CS$<>8__locals1;

                /*0x1f309e4*/ <>c__DisplayClass4_();
                /*0x1f2fe14*/ bool <ContinueWithOnMainThread>b__1();
            }
        }
    }
}
