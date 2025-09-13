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

        static /*0x2b2a2a8*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0x2b2a538*/ void InvokeOnAudioSystemShuttingDown();
        static /*0x2b2a598*/ void InvokeOnAudioSystemStartedUp();
        static /*0x2b2a5f8*/ bool StartAudioOutput();
        static /*0x2b2a62c*/ bool StopAudioOutput();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0x2b2b010*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0x2b2a30c*/ void Invoke(bool deviceWasChanged);
            /*0x2b2b070*/ System.IAsyncResult BeginInvoke(bool deviceWasChanged, System.AsyncCallback callback, object object);
            /*0x2b2b0fc*/ void EndInvoke(System.IAsyncResult result);
        }

        class Mobile
        {
            static /*0x0*/ bool <muteState>k__BackingField;
            static /*0x1*/ bool _stopAudioOutputOnMute;
            static /*0x8*/ System.Action<bool> OnMuteStateChanged;

            static /*0x2b2b56c*/ Mobile();
            static /*0x2b2b108*/ bool get_muteState();
            static /*0x2b2b16c*/ void set_muteState(bool value);
            static /*0x2b2b1d8*/ bool get_stopAudioOutputOnMute();
            static /*0x2b2b23c*/ void InvokeOnMuteStateChanged(bool mute);
            static /*0x2b2b514*/ bool InvokeIsStopAudioOutputOnMuteEnabled();
            static /*0x2b2b4e0*/ void StartAudioOutput();
            static /*0x2b2b4ac*/ void StopAudioOutput();
        }
    }

    class AudioClip : UnityEngine.Object
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        /*0x2b29698*/ AudioClip();
        /*0x2b29700*/ float get_length();
        /*0x2b29740*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0x2b29ac8*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0x2b2ad88*/ PCMReaderCallback(object object, nint method);
            /*0x2b29750*/ void Invoke(float[] data);
            /*0x2b2ade8*/ System.IAsyncResult BeginInvoke(float[] data, System.AsyncCallback callback, object object);
            /*0x2b2ae0c*/ void EndInvoke(System.IAsyncResult result);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0x2b2ae18*/ PCMSetPositionCallback(object object, nint method);
            /*0x2b29ad8*/ void Invoke(int position);
            /*0x2b2ae78*/ System.IAsyncResult BeginInvoke(int position, System.AsyncCallback callback, object object);
            /*0x2b2af00*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0x2b2a660*/ float GetPitch(UnityEngine.AudioSource source);
        static /*0x2b2a6a0*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0x2b2a6f0*/ void PlayHelper(UnityEngine.AudioSource source, ulong delay);
        /*0x2b2a740*/ void Stop(bool stopOneShots);
        /*0x2b2a790*/ float get_volume();
        /*0x2b2a7d0*/ void set_volume(float value);
        /*0x2b2a820*/ float get_pitch();
        /*0x2b2a860*/ void set_pitch(float value);
        /*0x2b2a8b0*/ UnityEngine.AudioClip get_clip();
        /*0x2b2a8f0*/ void set_clip(UnityEngine.AudioClip value);
        /*0x2b2a940*/ void Play();
        /*0x2b2a984*/ void Stop();
        /*0x2b2a9c8*/ void Pause();
        /*0x2b2aa08*/ void UnPause();
        /*0x2b2aa48*/ bool get_isPlaying();
        /*0x2b2aa88*/ void set_loop(bool value);
    }

    enum WebCamKind
    {
        WideAngle = 1,
        Telephoto = 2,
        ColorAndDepth = 3,
        UltraWideAngle = 4,
    }

    struct WebCamDevice
    {
        /*0x10*/ string m_Name;
        /*0x18*/ string m_DepthCameraName;
        /*0x20*/ int m_Flags;
        /*0x24*/ UnityEngine.WebCamKind m_Kind;
        /*0x28*/ UnityEngine.Resolution[] m_Resolutions;

        /*0xb5a5b0*/ string get_name();
        /*0xb5a5b8*/ bool get_isFrontFacing();
    }

    class WebCamTexture : UnityEngine.Texture
    {
        static /*0x2b2aaec*/ UnityEngine.WebCamDevice[] get_devices();
        static /*0x2b2abd8*/ void Internal_CreateWebCamTexture(UnityEngine.WebCamTexture self, string scriptingDevice, int requestedWidth, int requestedHeight, int maxFramerate);
        /*0x2b2ab20*/ WebCamTexture(string deviceName, int requestedWidth, int requestedHeight);
        /*0x2b2ac48*/ void Play();
        /*0x2b2ac88*/ void Stop();
        /*0x2b2acc8*/ bool get_isPlaying();
        /*0x2b2ad08*/ int get_videoRotationAngle();
        /*0x2b2ad48*/ bool get_videoVerticallyMirrored();
    }

    namespace Audio
    {
        struct AudioClipPlayable : System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0xb5a384*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb5a390*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
        }

        class AudioMixer : UnityEngine.Object
        {
            /*0x2b29d94*/ bool SetFloat(string name, float value);
            /*0x2b29df4*/ bool GetFloat(string name, ref float value);
        }

        struct AudioMixerPlayable : System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0xb5a398*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb5a3a4*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }

        struct AudioPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
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

                /*0x2b29edc*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0x2b2a28c*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0x2b2af0c*/ SampleFramesHandler(object object, nint method);
                    /*0x2b29ef8*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                    /*0x2b2af6c*/ System.IAsyncResult BeginInvoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount, System.AsyncCallback callback, object object);
                    /*0x2b2b004*/ void EndInvoke(System.IAsyncResult result);
                }
            }
        }
    }
}
