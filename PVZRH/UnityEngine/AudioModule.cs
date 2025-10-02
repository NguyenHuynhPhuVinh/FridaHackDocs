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

        static /*0x15b89e0*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0x15b8a40*/ void InvokeOnAudioSystemShuttingDown();
        static /*0x15b8a90*/ void InvokeOnAudioSystemStartedUp();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0x7220a0*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0x720980*/ void Invoke(bool deviceWasChanged);
        }
    }

    class AudioClip : UnityEngine.Object
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        /*0x15b8850*/ AudioClip();
        /*0x15b88c0*/ float get_length();
        /*0x15b8810*/ bool LoadAudioData();
        /*0x15b87d0*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0x15b87f0*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0xf0a420*/ PCMReaderCallback(object object, nint method);
            /*0x720980*/ void Invoke(float[] data);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0x721150*/ PCMSetPositionCallback(object object, nint method);
            /*0x720980*/ void Invoke(int position);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
        /*0x15b84e0*/ AudioBehaviour();
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0x15b8bb0*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0x15b8b20*/ void PlayHelper(UnityEngine.AudioSource source, ulong delay);
        /*0x15b84e0*/ AudioSource();
        /*0x15b8c40*/ void Stop(bool stopOneShots);
        /*0x15b8d90*/ float get_volume();
        /*0x15b8e70*/ void set_volume(float value);
        /*0x15b8bb0*/ void set_pitch(float value);
        /*0x15b8d50*/ float get_time();
        /*0x15b8e20*/ void set_time(float value);
        /*0x15b8cd0*/ UnityEngine.AudioClip get_clip();
        /*0x15b8dd0*/ void set_clip(UnityEngine.AudioClip value);
        /*0x15b8b70*/ void Play();
        /*0x15b8c00*/ void Stop();
        /*0x15b8ae0*/ void Pause();
        /*0x15b8c90*/ void UnPause();
        /*0x15b8d10*/ bool get_isPlaying();
    }

    namespace Experimental
    {
        namespace Audio
        {
            class AudioSampleProvider
            {
                /*0x10*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
                /*0x18*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

                /*0x15b8980*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0x15b89b0*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0x7232d0*/ SampleFramesHandler(object object, nint method);
                    /*0x722200*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                }
            }
        }
    }

    namespace Audio
    {
        struct AudioClipPlayable : System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b8750*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
        }

        struct AudioMixerPlayable : System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b8900*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }

        struct AudioPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }
    }
}
