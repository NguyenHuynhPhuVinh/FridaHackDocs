class <Module>
{
}

namespace UnityEngine
{
    class AudioSettings
    {
        static /*0x0*/ UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;
        static /*0x8*/ System.Action OnAudioSystemShuttingDown;
        static /*0x10*/ System.Action OnAudioSystemStartedUp;

        static /*0xfd7938*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0xfd79a4*/ void InvokeOnAudioSystemShuttingDown();
        static /*0xfd7a08*/ void InvokeOnAudioSystemStartedUp();
        static /*0xfd7a6c*/ bool StartAudioOutput();
        static /*0xfd7a94*/ bool StopAudioOutput();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0xfd7abc*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0xfd7b80*/ void Invoke(bool deviceWasChanged);
        }

        class Mobile
        {
            static /*0x0*/ bool <muteState>k__BackingField;
            static /*0x1*/ bool _stopAudioOutputOnMute;
            static /*0x8*/ System.Action<bool> OnMuteStateChanged;

            static /*0xfd7b98*/ bool get_muteState();
            static /*0xfd7be0*/ void set_muteState(bool value);
            static /*0xfd7c2c*/ bool get_stopAudioOutputOnMute();
            static /*0xfd7c74*/ void InvokeOnMuteStateChanged(bool mute);
            static /*0xfd7e40*/ bool InvokeIsStopAudioOutputOnMuteEnabled();
            static /*0xfd7e18*/ void StartAudioOutput();
            static /*0xfd7df0*/ void StopAudioOutput();
        }
    }

    class AudioClip : UnityEngine.Object
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        /*0xfd7e88*/ AudioClip();
        /*0xfd7ee4*/ float get_length();
        /*0xfd7f20*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0xfd7f3c*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0xfd7f58*/ PCMReaderCallback(object object, nint method);
            /*0xfd802c*/ void Invoke(float[] data);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0xfd8040*/ PCMSetPositionCallback(object object, nint method);
            /*0xfd8104*/ void Invoke(int position);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
        static /*0xfd8118*/ void set_volume(float value);
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0xfd8150*/ float GetPitch(UnityEngine.AudioSource source);
        static /*0xfd818c*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0xfd81d8*/ void PlayHelper(UnityEngine.AudioSource source, ulong delay);
        static /*0xfd821c*/ void PlayOneShotHelper(UnityEngine.AudioSource source, UnityEngine.AudioClip clip, float volumeScale);
        /*0xfd8270*/ void Stop(bool stopOneShots);
        /*0xfd82b4*/ float get_volume();
        /*0xfd82f0*/ void set_volume(float value);
        /*0xfd833c*/ float get_pitch();
        /*0xfd8378*/ void set_pitch(float value);
        /*0xfd83c4*/ UnityEngine.AudioClip get_clip();
        /*0xfd8400*/ void set_clip(UnityEngine.AudioClip value);
        /*0xfd8444*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
        /*0xfd8488*/ void Play();
        /*0xfd84c8*/ void PlayOneShot(UnityEngine.AudioClip clip);
        /*0xfd84d0*/ void PlayOneShot(UnityEngine.AudioClip clip, float volumeScale);
        /*0xfd85cc*/ void Stop();
        /*0xfd860c*/ bool get_isPlaying();
        /*0xfd8648*/ void set_loop(bool value);
        /*0xfd868c*/ void set_playOnAwake(bool value);
    }

    namespace Audio
    {
        struct AudioPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }

        class AudioMixerGroup : UnityEngine.Object
        {
        }

        class AudioMixer : UnityEngine.Object
        {
            /*0xfd86d0*/ bool SetFloat(string name, float value);
        }

        class AudioMixerSnapshot : UnityEngine.Object
        {
        }

        struct AudioClipPlayable : System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0xfd8724*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xfd8730*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
        }

        struct AudioMixerPlayable : System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0xfd87a8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xfd87b4*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }
    }

    namespace Experimental
    {
        namespace Audio
        {
            class AudioSampleProvider
            {
                /*0x10*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
                /*0x18*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

                /*0xfd882c*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0xfd8854*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0xfd887c*/ SampleFramesHandler(object object, nint method);
                    /*0xfd89ac*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                }
            }
        }
    }
}
