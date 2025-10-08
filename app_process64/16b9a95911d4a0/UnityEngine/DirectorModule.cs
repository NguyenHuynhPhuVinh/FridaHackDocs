class <Module>
{
}

namespace UnityEngine
{
    namespace Playables
    {
        struct DataPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x3e2f04c*/ void Internal_CallOnPlayerChanged(UnityEngine.Playables.PlayableOutputHandle handle, object previousPlayer, object currentPlayer);
            /*0x3e2ef50*/ DataPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x3e2f040*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
        }

        interface IDataPlayer
        {
            void Bind(UnityEngine.Playables.DataPlayableOutput output);
            void Release(UnityEngine.Playables.DataPlayableOutput output);
        }

        class PlayableDirector : UnityEngine.Behaviour, UnityEngine.IExposedPropertyTable
        {
            /*0x18*/ System.Action<UnityEngine.Playables.PlayableDirector> played;
            /*0x20*/ System.Action<UnityEngine.Playables.PlayableDirector> paused;
            /*0x28*/ System.Action<UnityEngine.Playables.PlayableDirector> stopped;

            static /*0x3e2f40c*/ nint GetReferenceValue_Injected(nint _unity_self, ref UnityEngine.PropertyName id, ref bool idValid);
            static /*0x3e2f530*/ nint GetGenericBinding_Injected(nint _unity_self, nint key);
            static /*0x3e2f574*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode_Injected(nint _unity_self);
            static /*0x3e2f5b0*/ nint Internal_GetPlayableAsset_Injected(nint _unity_self);
            /*0x3e2f1cc*/ UnityEngine.Playables.DirectorWrapMode get_extrapolationMode();
            /*0x3e2f248*/ UnityEngine.Playables.PlayableAsset get_playableAsset();
            /*0x3e2f35c*/ UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
            /*0x3e2f460*/ UnityEngine.Object GetGenericBinding(UnityEngine.Object key);
            /*0x3e2f1d0*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode();
            /*0x3e2f2c8*/ UnityEngine.ScriptableObject Internal_GetPlayableAsset();
            /*0x3e2f5ec*/ void SendOnPlayableDirectorPlay();
            /*0x3e2f60c*/ void SendOnPlayableDirectorPause();
            /*0x3e2f62c*/ void SendOnPlayableDirectorStop();
        }

        class PlayableSystems
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Type> s_SystemTypes;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.Playables.PlayableSystems.PlayableSystemDelegate> s_Delegates;
            static /*0x10*/ System.Threading.ReaderWriterLockSlim s_RWLock;

            static /*0x3e2f850*/ PlayableSystems();
            static /*0x3e2f64c*/ int CombineTypeAndIndex(int typeIndex, UnityEngine.Playables.PlayableSystems.PlayableSystemStage stage);
            static /*0x3e2f658*/ bool Internal_CallSystemDelegate(int systemIndex, UnityEngine.Playables.PlayableSystems.PlayableSystemStage stage, nint outputsPtr, int numOutputs);

            class PlayableSystemDelegate : System.MulticastDelegate
            {
                /*0x3e2f97c*/ PlayableSystemDelegate(object object, nint method);
                /*0x3e2fa84*/ void Invoke(System.Collections.Generic.IReadOnlyList<UnityEngine.Playables.DataPlayableOutput> outputs);
            }

            enum PlayableSystemStage
            {
                FixedUpdate = 0,
                FixedUpdatePostPhysics = 1,
                Update = 2,
                AnimationBegin = 3,
                AnimationEnd = 4,
                LateUpdate = 5,
                Render = 6,
            }

            class DataPlayableOutputList : System.Collections.Generic.IReadOnlyList<UnityEngine.Playables.DataPlayableOutput>, System.Collections.Generic.IEnumerable<UnityEngine.Playables.DataPlayableOutput>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection<UnityEngine.Playables.DataPlayableOutput>
            {
                /*0x10*/ UnityEngine.Playables.PlayableOutputHandle* m_Outputs;
                /*0x18*/ int m_Count;

                /*0x3e2f820*/ DataPlayableOutputList(UnityEngine.Playables.PlayableOutputHandle* outputs, int count);
                /*0x3e2fa98*/ UnityEngine.Playables.DataPlayableOutput get_Item(int index);
                /*0x3e2fbbc*/ int get_Count();
                /*0x3e2fbc4*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.DataPlayableOutput> GetEnumerator();
                /*0x3e2fc70*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                class DataPlayableOutputEnumerator : System.Collections.Generic.IEnumerator<UnityEngine.Playables.DataPlayableOutput>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.Playables.PlayableSystems.DataPlayableOutputList m_List;
                    /*0x18*/ int m_Index;

                    /*0x3e2fc34*/ DataPlayableOutputEnumerator(UnityEngine.Playables.PlayableSystems.DataPlayableOutputList list);
                    /*0x3e2fc74*/ UnityEngine.Playables.DataPlayableOutput get_Current();
                    /*0x3e2fd50*/ object System.Collections.IEnumerator.get_Current();
                    /*0x3e2fdb4*/ void Dispose();
                    /*0x3e2fdc0*/ bool MoveNext();
                    /*0x3e2fdec*/ void Reset();
                }
            }
        }
    }
}
