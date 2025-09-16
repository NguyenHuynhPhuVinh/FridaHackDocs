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

            static /*0x7eb9c88*/ void Internal_CallOnPlayerChanged(UnityEngine.Playables.PlayableOutputHandle handle, object previousPlayer, object currentPlayer);
            /*0x7eb9b8c*/ DataPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7eb9c7c*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
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

            static /*0x7eba00c*/ void set_time_Injected(nint _unity_self, double value);
            static /*0x7eba0d0*/ double get_time_Injected(nint _unity_self);
            static /*0x7eba184*/ double get_duration_Injected(nint _unity_self);
            static /*0x7eba238*/ void Play_Injected(nint _unity_self);
            static /*0x7eba2ec*/ void Stop_Injected(nint _unity_self);
            static /*0x7eba3d8*/ nint GetReferenceValue_Injected(nint _unity_self, ref UnityEngine.PropertyName id, ref bool idValid);
            static /*0x7eba4fc*/ nint GetGenericBinding_Injected(nint _unity_self, nint key);
            static /*0x7eba540*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode_Injected(nint _unity_self);
            static /*0x7eba57c*/ nint Internal_GetPlayableAsset_Injected(nint _unity_self);
            /*0x7eb9df4*/ UnityEngine.Playables.DirectorWrapMode get_extrapolationMode();
            /*0x7eb9e70*/ UnityEngine.Playables.PlayableAsset get_playableAsset();
            /*0x7eb9f84*/ void set_time(double value);
            /*0x7eba058*/ double get_time();
            /*0x7eba10c*/ double get_duration();
            /*0x7eba1c0*/ void Play();
            /*0x7eba274*/ void Stop();
            /*0x7eba328*/ UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
            /*0x7eba42c*/ UnityEngine.Object GetGenericBinding(UnityEngine.Object key);
            /*0x7eb9df8*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode();
            /*0x7eb9ef0*/ UnityEngine.ScriptableObject Internal_GetPlayableAsset();
            /*0x7eba5b8*/ void SendOnPlayableDirectorPlay();
            /*0x7eba5d8*/ void SendOnPlayableDirectorPause();
            /*0x7eba5f8*/ void SendOnPlayableDirectorStop();
        }

        class PlayableSystems
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Type> s_SystemTypes;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.Playables.PlayableSystems.PlayableSystemDelegate> s_Delegates;
            static /*0x10*/ System.Threading.ReaderWriterLockSlim s_RWLock;

            static /*0x7eba82c*/ PlayableSystems();
            static /*0x7eba618*/ int CombineTypeAndIndex(int typeIndex, UnityEngine.Playables.PlayableSystems.PlayableSystemStage stage);
            static /*0x7eba624*/ bool Internal_CallSystemDelegate(int systemIndex, UnityEngine.Playables.PlayableSystems.PlayableSystemStage stage, nint outputsPtr, int numOutputs);

            class PlayableSystemDelegate : System.MulticastDelegate
            {
                /*0x7eba958*/ PlayableSystemDelegate(object object, nint method);
                /*0x7ebaa60*/ void Invoke(System.Collections.Generic.IReadOnlyList<UnityEngine.Playables.DataPlayableOutput> outputs);
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

                /*0x7eba7fc*/ DataPlayableOutputList(UnityEngine.Playables.PlayableOutputHandle* outputs, int count);
                /*0x7ebaa74*/ UnityEngine.Playables.DataPlayableOutput get_Item(int index);
                /*0x7ebab98*/ int get_Count();
                /*0x7ebaba0*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.DataPlayableOutput> GetEnumerator();
                /*0x7ebac4c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                class DataPlayableOutputEnumerator : System.Collections.Generic.IEnumerator<UnityEngine.Playables.DataPlayableOutput>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.Playables.PlayableSystems.DataPlayableOutputList m_List;
                    /*0x18*/ int m_Index;

                    /*0x7ebac10*/ DataPlayableOutputEnumerator(UnityEngine.Playables.PlayableSystems.DataPlayableOutputList list);
                    /*0x7ebac50*/ UnityEngine.Playables.DataPlayableOutput get_Current();
                    /*0x7ebad2c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7ebad90*/ void Dispose();
                    /*0x7ebad9c*/ bool MoveNext();
                    /*0x7ebadcc*/ void Reset();
                }
            }
        }
    }
}
