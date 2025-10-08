class <Module>
{
}

namespace UnityEngine
{
    enum AudioVelocityUpdateMode
    {
        Auto = 0,
        Fixed = 1,
        Dynamic = 2,
    }

    enum FFTWindow
    {
        Rectangular = 0,
        Triangle = 1,
        Hamming = 2,
        Hanning = 3,
        Blackman = 4,
        BlackmanHarris = 5,
    }

    class AudioSettings
    {
        static /*0x0*/ UnityEngine.AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;
        static /*0x8*/ System.Action OnAudioSystemShuttingDown;
        static /*0x10*/ System.Action OnAudioSystemStartedUp;

        static /*0x3d63358*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0x3d633c4*/ void InvokeOnAudioSystemShuttingDown();
        static /*0x3d63428*/ void InvokeOnAudioSystemStartedUp();
        static /*0x3d6348c*/ bool StartAudioOutput();
        static /*0x3d634b4*/ bool StopAudioOutput();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0x3d634dc*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0x3d6357c*/ void Invoke(bool deviceWasChanged);
        }

        class Mobile
        {
            static /*0x0*/ bool <muteState>k__BackingField;
            static /*0x1*/ bool _stopAudioOutputOnMute;
            static /*0x8*/ System.Action<bool> OnMuteStateChanged;

            static /*0x3d63590*/ bool get_muteState();
            static /*0x3d635d8*/ void set_muteState(bool value);
            static /*0x3d63628*/ bool get_stopAudioOutputOnMute();
            static /*0x3d63670*/ void InvokeOnMuteStateChanged(bool mute);
            static /*0x3d63830*/ bool InvokeIsStopAudioOutputOnMuteEnabled();
            static /*0x3d63808*/ void StartAudioOutput();
            static /*0x3d637e0*/ void StopAudioOutput();
        }
    }

    class AudioClip : UnityEngine.Audio.AudioResource
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        /*0x3d63878*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0x3d63894*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0x3d638b0*/ PCMReaderCallback(object object, nint method);
            /*0x3d63960*/ void Invoke(float[] data);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0x3d63974*/ PCMSetPositionCallback(object object, nint method);
            /*0x3d63a14*/ void Invoke(int position);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
        /*0x3d63a28*/ AudioBehaviour();
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
        static /*0x3d63a30*/ void GetOutputDataHelper(float[] samples, int channel);
        static /*0x3d63b88*/ void GetSpectrumDataHelper(float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x3d63d04*/ float get_volume();
        static /*0x3d63d2c*/ void set_volume(float value);
        static /*0x3d63d64*/ bool get_pause();
        static /*0x3d63d8c*/ void set_pause(bool value);
        static /*0x3d63f40*/ float[] GetOutputData(int numSamples, int channel);
        static /*0x3d63fa8*/ void GetOutputData(float[] samples, int channel);
        static /*0x3d63fac*/ float[] GetSpectrumData(int numSamples, int channel, UnityEngine.FFTWindow window);
        static /*0x3d6401c*/ void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x3d63b44*/ void GetOutputDataHelper_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel);
        static /*0x3d63cb0*/ void GetSpectrumDataHelper_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel, UnityEngine.FFTWindow window);
        static /*0x3d63e40*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode_Injected(nint _unity_self);
        static /*0x3d63efc*/ void set_velocityUpdateMode_Injected(nint _unity_self, UnityEngine.AudioVelocityUpdateMode value);
        /*0x3d64020*/ AudioListener();
        /*0x3d63dc8*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode();
        /*0x3d63e7c*/ void set_velocityUpdateMode(UnityEngine.AudioVelocityUpdateMode value);
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0x3d64028*/ float GetPitch(UnityEngine.AudioSource source);
        static /*0x3d6410c*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0x3d640d0*/ float GetPitch_Injected(nint source);
        static /*0x3d641c4*/ void SetPitch_Injected(nint source, float pitch);
        static /*0x3d64288*/ float get_volume_Injected(nint _unity_self);
        static /*0x3d6434c*/ void set_volume_Injected(nint _unity_self, float value);
        /*0x3d64210*/ float get_volume();
        /*0x3d642c4*/ void set_volume(float value);
        /*0x3d64398*/ float get_pitch();
        /*0x3d6439c*/ void set_pitch(float value);
    }

    namespace Experimental
    {
        namespace Audio
        {
            class AudioSampleProvider
            {
                /*0x10*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
                /*0x18*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

                /*0x3d643a0*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0x3d643c8*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0x3d643f0*/ SampleFramesHandler(object object, nint method);
                    /*0x3d644fc*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                }
            }
        }
    }

    namespace Audio
    {
        class AudioResource : UnityEngine.Object
        {
        }

        struct AudioClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x3d64510*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d6451c*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
        }

        class AudioMixer : UnityEngine.Object
        {
            static /*0x3d64750*/ bool SetFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value);
            static /*0x3d64960*/ bool GetFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref float value);
            /*0x3d64594*/ bool SetFloat(string name, float value);
            /*0x3d647a4*/ bool GetFloat(string name, ref float value);
        }

        struct AudioMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x3d649b4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d649c0*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }

        struct AudioPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x3d64b34*/ UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x3d64bfc*/ void InternalSetEvaluateOnSeek(ref UnityEngine.Playables.PlayableOutputHandle output, bool value);
            /*0x3d64a38*/ AudioPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x3d64b28*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x3d64bb8*/ void SetEvaluateOnSeek(bool value);
        }
    }
}
