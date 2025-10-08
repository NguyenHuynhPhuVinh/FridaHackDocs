class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace StarlightWrapper
        {
            class CoroutineRunner : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Coroutine, EA.Unity.StarlightWrapper.CoroutineRunner> runningCoroutines;
                /*0x20*/ UnityEngine.Coroutine runningCoroutine;

                static /*0x2bf745c*/ CoroutineRunner();
                static /*0x2bf7050*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator coroutineToStart);
                static /*0x2bf71d0*/ void StopCoroutine(UnityEngine.Coroutine coroutineToStop);
                /*0x2bf7454*/ CoroutineRunner();
                /*0x2bf7198*/ UnityEngine.Coroutine Begin(System.Collections.IEnumerator coroutineToStart);
                /*0x2bf73a4*/ System.Collections.IEnumerator Run(System.Collections.IEnumerator coroutineToStart);
                /*0x2bf7328*/ void End();

                class <Run>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ System.Collections.IEnumerator coroutineToStart;
                    /*0x28*/ EA.Unity.StarlightWrapper.CoroutineRunner <>4__this;

                    /*0x2bf742c*/ <Run>d__5(int <>1__state);
                    /*0x2bf74f4*/ void System.IDisposable.Dispose();
                    /*0x2bf74f8*/ bool MoveNext();
                    /*0x2bf7564*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2bf756c*/ void System.Collections.IEnumerator.Reset();
                    /*0x2bf75a4*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }
    }
}
