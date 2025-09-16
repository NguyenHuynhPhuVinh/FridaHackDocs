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

            static /*0x7ed10b8*/ void Internal_CallOnPlayerChanged(UnityEngine.Playables.PlayableOutputHandle handle, object previousPlayer, object currentPlayer);
            /*0x7ed0fbc*/ DataPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7ed10ac*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
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

            static /*0x7ed143c*/ void set_time_Injected(nint _unity_self, double value);
            static /*0x7ed1500*/ double get_time_Injected(nint _unity_self);
            static /*0x7ed15b4*/ double get_duration_Injected(nint _unity_self);
            static /*0x7ed1668*/ void Play_Injected(nint _unity_self);
            static /*0x7ed171c*/ void Stop_Injected(nint _unity_self);
            static /*0x7ed1808*/ nint GetReferenceValue_Injected(nint _unity_self, ref UnityEngine.PropertyName id, ref bool idValid);
            static /*0x7ed192c*/ nint GetGenericBinding_Injected(nint _unity_self, nint key);
            static /*0x7ed1970*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode_Injected(nint _unity_self);
            static /*0x7ed19ac*/ nint Internal_GetPlayableAsset_Injected(nint _unity_self);
            /*0x7ed1224*/ UnityEngine.Playables.DirectorWrapMode get_extrapolationMode();
            /*0x7ed12a0*/ UnityEngine.Playables.PlayableAsset get_playableAsset();
            /*0x7ed13b4*/ void set_time(double value);
            /*0x7ed1488*/ double get_time();
            /*0x7ed153c*/ double get_duration();
            /*0x7ed15f0*/ void Play();
            /*0x7ed16a4*/ void Stop();
            /*0x7ed1758*/ UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
            /*0x7ed185c*/ UnityEngine.Object GetGenericBinding(UnityEngine.Object key);
            /*0x7ed1228*/ UnityEngine.Playables.DirectorWrapMode GetWrapMode();
            /*0x7ed1320*/ UnityEngine.ScriptableObject Internal_GetPlayableAsset();
            /*0x7ed19e8*/ void SendOnPlayableDirectorPlay();
            /*0x7ed1a08*/ void SendOnPlayableDirectorPause();
            /*0x7ed1a28*/ void SendOnPlayableDirectorStop();
        }

        class PlayableSystems
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Type> s_SystemTypes;
            static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.Playables.PlayableSystems.PlayableSystemDelegate> s_Delegates;
            static /*0x10*/ System.Threading.ReaderWriterLockSlim s_RWLock;

            static /*0x7ed1c5c*/ PlayableSystems();
            static /*0x7ed1a48*/ int CombineTypeAndIndex(int typeIndex, UnityEngine.Playables.PlayableSystems.PlayableSystemStage stage);
            static /*0x7ed1a54*/ bool Internal_CallSystemDelegate(int systemIndex, UnityEngine.Playables.PlayableSystems.PlayableSystemStage stage, nint outputsPtr, int numOutputs);

            class PlayableSystemDelegate : System.MulticastDelegate
            {
                /*0x7ed1d88*/ PlayableSystemDelegate(object object, nint method);
                /*0x7ed1e90*/ void Invoke(System.Collections.Generic.IReadOnlyList<UnityEngine.Playables.DataPlayableOutput> outputs);
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

                /*0x7ed1c2c*/ DataPlayableOutputList(UnityEngine.Playables.PlayableOutputHandle* outputs, int count);
                /*0x7ed1ea4*/ UnityEngine.Playables.DataPlayableOutput get_Item(int index);
                /*0x7ed1fc8*/ int get_Count();
                /*0x7ed1fd0*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.DataPlayableOutput> GetEnumerator();
                /*0x7ed207c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                class DataPlayableOutputEnumerator : System.Collections.Generic.IEnumerator<UnityEngine.Playables.DataPlayableOutput>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ UnityEngine.Playables.PlayableSystems.DataPlayableOutputList m_List;
                    /*0x18*/ int m_Index;

                    /*0x7ed2040*/ DataPlayableOutputEnumerator(UnityEngine.Playables.PlayableSystems.DataPlayableOutputList list);
                    /*0x7ed2080*/ UnityEngine.Playables.DataPlayableOutput get_Current();
                    /*0x7ed215c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7ed21c0*/ void Dispose();
                    /*0x7ed21cc*/ bool MoveNext();
                    /*0x7ed21fc*/ void Reset();
                }
            }
        }
    }
}
