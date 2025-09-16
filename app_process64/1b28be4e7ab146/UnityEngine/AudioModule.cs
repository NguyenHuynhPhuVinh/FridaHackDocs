class <Module>
{
}

namespace UnityEngine
{
    enum AudioDataLoadState
    {
        Unloaded = 0,
        Loading = 1,
        Loaded = 2,
        Failed = 3,
    }

    enum AudioClipLoadType
    {
        DecompressOnLoad = 0,
        CompressedInMemory = 1,
        Streaming = 2,
    }

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

        static /*0x7e03fc8*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0x7e04034*/ void InvokeOnAudioSystemShuttingDown();
        static /*0x7e04098*/ void InvokeOnAudioSystemStartedUp();
        static /*0x7e040fc*/ bool StartAudioOutput();
        static /*0x7e04124*/ bool StopAudioOutput();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0x7e0414c*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0x7e041ec*/ void Invoke(bool deviceWasChanged);
        }

        class Mobile
        {
            static /*0x0*/ bool <muteState>k__BackingField;
            static /*0x1*/ bool _stopAudioOutputOnMute;
            static /*0x8*/ System.Action<bool> OnMuteStateChanged;

            static /*0x7e04204*/ bool get_muteState();
            static /*0x7e0424c*/ void set_muteState(bool value);
            static /*0x7e0429c*/ bool get_stopAudioOutputOnMute();
            static /*0x7e042e4*/ void InvokeOnMuteStateChanged(bool mute);
            static /*0x7e044b4*/ bool InvokeIsStopAudioOutputOnMuteEnabled();
            static /*0x7e0448c*/ void StartAudioOutput();
            static /*0x7e04464*/ void StopAudioOutput();
        }
    }

    class AudioClip : UnityEngine.Audio.AudioResource
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        static /*0x7e04584*/ bool GetData(UnityEngine.AudioClip clip, System.Span<float> data, int samplesOffset);
        static /*0x7e04700*/ bool SetData(UnityEngine.AudioClip clip, System.ReadOnlySpan<float> data, int samplesOffset);
        static /*0x7e0487c*/ UnityEngine.AudioClip Construct_Internal();
        static /*0x7e05a68*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream);
        static /*0x7e05a88*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback);
        static /*0x7e05c00*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback);
        static /*0x7e05a78*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream);
        static /*0x7e05c10*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback);
        static /*0x7e05a98*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback);
        static /*0x7e046ac*/ bool GetData_Injected(nint clip, ref UnityEngine.Bindings.ManagedSpanWrapper data, int samplesOffset);
        static /*0x7e04828*/ bool SetData_Injected(nint clip, ref UnityEngine.Bindings.ManagedSpanWrapper data, int samplesOffset);
        static /*0x7e048e0*/ nint Construct_Internal_Injected();
        static /*0x7e04a04*/ void GetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e04c18*/ void CreateUserSound_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream);
        static /*0x7e04d04*/ float get_length_Injected(nint _unity_self);
        static /*0x7e04db8*/ int get_samples_Injected(nint _unity_self);
        static /*0x7e04e6c*/ int get_channels_Injected(nint _unity_self);
        static /*0x7e04f20*/ int get_frequency_Injected(nint _unity_self);
        static /*0x7e04fd4*/ bool get_isReadyToPlay_Injected(nint _unity_self);
        static /*0x7e05088*/ UnityEngine.AudioClipLoadType get_loadType_Injected(nint _unity_self);
        static /*0x7e0513c*/ bool LoadAudioData_Injected(nint _unity_self);
        static /*0x7e051f0*/ bool UnloadAudioData_Injected(nint _unity_self);
        static /*0x7e052a4*/ bool get_preloadAudioData_Injected(nint _unity_self);
        static /*0x7e05358*/ bool get_ambisonic_Injected(nint _unity_self);
        static /*0x7e0540c*/ bool get_loadInBackground_Injected(nint _unity_self);
        static /*0x7e054c0*/ UnityEngine.AudioDataLoadState get_loadState_Injected(nint _unity_self);
        /*0x7e044fc*/ AudioClip();
        /*0x7e04908*/ string GetName();
        /*0x7e04a48*/ void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream);
        /*0x7e04c8c*/ float get_length();
        /*0x7e04d40*/ int get_samples();
        /*0x7e04df4*/ int get_channels();
        /*0x7e04ea8*/ int get_frequency();
        /*0x7e04f5c*/ bool get_isReadyToPlay();
        /*0x7e05010*/ UnityEngine.AudioClipLoadType get_loadType();
        /*0x7e050c4*/ bool LoadAudioData();
        /*0x7e05178*/ bool UnloadAudioData();
        /*0x7e0522c*/ bool get_preloadAudioData();
        /*0x7e052e0*/ bool get_ambisonic();
        /*0x7e05394*/ bool get_loadInBackground();
        /*0x7e05448*/ UnityEngine.AudioDataLoadState get_loadState();
        /*0x7e054fc*/ bool GetData(System.Span<float> data, int offsetSamples);
        /*0x7e055f0*/ bool GetData(float[] data, int offsetSamples);
        /*0x7e05718*/ bool SetData(float[] data, int offsetSamples);
        /*0x7e058e8*/ bool SetData(System.ReadOnlySpan<float> data, int offsetSamples);
        /*0x7e05c1c*/ void add_m_PCMReaderCallback(UnityEngine.AudioClip.PCMReaderCallback value);
        /*0x7e05d54*/ void remove_m_PCMReaderCallback(UnityEngine.AudioClip.PCMReaderCallback value);
        /*0x7e05cb8*/ void add_m_PCMSetPositionCallback(UnityEngine.AudioClip.PCMSetPositionCallback value);
        /*0x7e05df0*/ void remove_m_PCMSetPositionCallback(UnityEngine.AudioClip.PCMSetPositionCallback value);
        /*0x7e05e8c*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0x7e05ea8*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0x7e05ec4*/ PCMReaderCallback(object object, nint method);
            /*0x7e05f74*/ void Invoke(float[] data);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0x7e05f88*/ PCMSetPositionCallback(object object, nint method);
            /*0x7e06028*/ void Invoke(int position);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
        /*0x7e0603c*/ AudioBehaviour();
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
        static /*0x7e06044*/ void GetOutputDataHelper(float[] samples, int channel);
        static /*0x7e061ac*/ void GetSpectrumDataHelper(float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7e06334*/ float get_volume();
        static /*0x7e0635c*/ void set_volume(float value);
        static /*0x7e06394*/ bool get_pause();
        static /*0x7e063bc*/ void set_pause(bool value);
        static /*0x7e06570*/ float[] GetOutputData(int numSamples, int channel);
        static /*0x7e065d8*/ void GetOutputData(float[] samples, int channel);
        static /*0x7e065dc*/ float[] GetSpectrumData(int numSamples, int channel, UnityEngine.FFTWindow window);
        static /*0x7e0664c*/ void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7e06168*/ void GetOutputDataHelper_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel);
        static /*0x7e062e0*/ void GetSpectrumDataHelper_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7e06470*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode_Injected(nint _unity_self);
        static /*0x7e0652c*/ void set_velocityUpdateMode_Injected(nint _unity_self, UnityEngine.AudioVelocityUpdateMode value);
        /*0x7e06650*/ AudioListener();
        /*0x7e063f8*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode();
        /*0x7e064ac*/ void set_velocityUpdateMode(UnityEngine.AudioVelocityUpdateMode value);
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0x7e06658*/ float GetPitch(UnityEngine.AudioSource source);
        static /*0x7e0673c*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0x7e06840*/ void PlayHelper(UnityEngine.AudioSource source, ulong delay);
        static /*0x7e069f8*/ void GetOutputDataHelper(UnityEngine.AudioSource source, float[] samples, int channel);
        static /*0x7e06be0*/ void GetSpectrumDataHelper(UnityEngine.AudioSource source, float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7e06700*/ float GetPitch_Injected(nint source);
        static /*0x7e067f4*/ void SetPitch_Injected(nint source, float pitch);
        static /*0x7e068f0*/ void PlayHelper_Injected(nint source, ulong delay);
        static /*0x7e069b4*/ void Stop_Injected(nint _unity_self, bool stopOneShots);
        static /*0x7e06b8c*/ void GetOutputDataHelper_Injected(nint source, ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel);
        static /*0x7e06d84*/ void GetSpectrumDataHelper_Injected(nint source, ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7e06e58*/ float get_volume_Injected(nint _unity_self);
        static /*0x7e06f1c*/ void set_volume_Injected(nint _unity_self, float value);
        static /*0x7e06fe8*/ float get_time_Injected(nint _unity_self);
        static /*0x7e0709c*/ int get_timeSamples_Injected(nint _unity_self);
        static /*0x7e07158*/ void set_timeSamples_Injected(nint _unity_self, int value);
        static /*0x7e07344*/ nint get_resource_Injected(nint _unity_self);
        static /*0x7e07380*/ void set_resource_Injected(nint _unity_self, nint value);
        static /*0x7e07458*/ nint get_outputAudioMixerGroup_Injected(nint _unity_self);
        static /*0x7e07548*/ void set_outputAudioMixerGroup_Injected(nint _unity_self, nint value);
        static /*0x7e07614*/ void Pause_Injected(nint _unity_self);
        static /*0x7e076c8*/ void UnPause_Injected(nint _unity_self);
        static /*0x7e0777c*/ bool get_isPlaying_Injected(nint _unity_self);
        static /*0x7e07838*/ void set_loop_Injected(nint _unity_self, bool value);
        static /*0x7e078fc*/ void set_playOnAwake_Injected(nint _unity_self, bool value);
        /*0x7e07948*/ AudioSource();
        /*0x7e06934*/ void Stop(bool stopOneShots);
        /*0x7e06de0*/ float get_volume();
        /*0x7e06e94*/ void set_volume(float value);
        /*0x7e06f68*/ float get_pitch();
        /*0x7e06f6c*/ void set_pitch(float value);
        /*0x7e06f70*/ float get_time();
        /*0x7e07024*/ int get_timeSamples();
        /*0x7e070d8*/ void set_timeSamples(int value);
        /*0x7e0719c*/ UnityEngine.AudioClip get_clip();
        /*0x7e0728c*/ void set_clip(UnityEngine.AudioClip value);
        /*0x7e071f8*/ UnityEngine.Audio.AudioResource get_resource();
        /*0x7e07290*/ void set_resource(UnityEngine.Audio.AudioResource value);
        /*0x7e073c4*/ UnityEngine.Audio.AudioMixerGroup get_outputAudioMixerGroup();
        /*0x7e07494*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
        /*0x7e0758c*/ void Play();
        /*0x7e07594*/ void Stop();
        /*0x7e0759c*/ void Pause();
        /*0x7e07650*/ void UnPause();
        /*0x7e07704*/ bool get_isPlaying();
        /*0x7e077b8*/ void set_loop(bool value);
        /*0x7e0787c*/ void set_playOnAwake(bool value);
        /*0x7e07940*/ void GetOutputData(float[] samples, int channel);
        /*0x7e07944*/ void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window);
    }

    namespace Experimental
    {
        namespace Audio
        {
            class AudioSampleProvider
            {
                /*0x10*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
                /*0x18*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

                /*0x7e07950*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0x7e07978*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0x7e079a0*/ SampleFramesHandler(object object, nint method);
                    /*0x7e07aac*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                }
            }
        }
    }

    namespace Audio
    {
        class AudioResource : UnityEngine.Object
        {
            /*0x7e0452c*/ AudioResource();
        }

        struct AudioClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x7e07ac0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e07acc*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
        }

        enum AudioMixerUpdateMode
        {
            Normal = 0,
            UnscaledTime = 1,
        }

        class AudioMixer : UnityEngine.Object
        {
            static /*0x7e07c30*/ nint get_outputAudioMixerGroup_Injected(nint _unity_self);
            static /*0x7e07d20*/ void set_outputAudioMixerGroup_Injected(nint _unity_self, nint value);
            static /*0x7e07f58*/ nint FindSnapshot_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7e08144*/ UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper subPath);
            static /*0x7e08508*/ void TransitionToSnapshotInternal_Injected(nint _unity_self, nint snapshot, float timeToReach);
            static /*0x7e08678*/ void TransitionToSnapshots_Injected(nint _unity_self, UnityEngine.Audio.AudioMixerSnapshot[] snapshots, ref UnityEngine.Bindings.ManagedSpanWrapper weights, float timeToReach);
            static /*0x7e08754*/ UnityEngine.Audio.AudioMixerUpdateMode get_updateMode_Injected(nint _unity_self);
            static /*0x7e08810*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.Audio.AudioMixerUpdateMode value);
            static /*0x7e08a10*/ bool SetFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value);
            static /*0x7e08c10*/ bool ClearFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7e08e10*/ bool GetFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref float value);
            static /*0x7e08f18*/ float GetAbsoluteAudibilityFromGroup_Injected(nint _unity_self, nint group);
            /*0x7e07b44*/ AudioMixer();
            /*0x7e07b9c*/ UnityEngine.Audio.AudioMixerGroup get_outputAudioMixerGroup();
            /*0x7e07c6c*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
            /*0x7e07d64*/ UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(string name);
            /*0x7e07f9c*/ UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(string subPath);
            /*0x7e08188*/ void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach);
            /*0x7e08444*/ void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach);
            /*0x7e0855c*/ void TransitionToSnapshots(UnityEngine.Audio.AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);
            /*0x7e086dc*/ UnityEngine.Audio.AudioMixerUpdateMode get_updateMode();
            /*0x7e08790*/ void set_updateMode(UnityEngine.Audio.AudioMixerUpdateMode value);
            /*0x7e08854*/ bool SetFloat(string name, float value);
            /*0x7e08a64*/ bool ClearFloat(string name);
            /*0x7e08c54*/ bool GetFloat(string name, ref float value);
            /*0x7e08e64*/ float GetAbsoluteAudibilityFromGroup(UnityEngine.Audio.AudioMixerGroup group);
        }

        class AudioMixerGroup : UnityEngine.Object, UnityEngine.Internal.ISubAssetNotDuplicatable
        {
            static /*0x7e09048*/ nint get_audioMixer_Injected(nint _unity_self);
            /*0x7e08f5c*/ AudioMixerGroup();
            /*0x7e08fb4*/ UnityEngine.Audio.AudioMixer get_audioMixer();
        }

        struct AudioMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x7e09084*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e09090*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }

        class AudioMixerSnapshot : UnityEngine.Object, UnityEngine.Internal.ISubAssetNotDuplicatable
        {
            static /*0x7e09108*/ nint get_audioMixer_Injected(nint _unity_self);
            /*0x7e083b0*/ UnityEngine.Audio.AudioMixer get_audioMixer();
        }

        struct AudioPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7e09240*/ UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x7e09308*/ void InternalSetEvaluateOnSeek(ref UnityEngine.Playables.PlayableOutputHandle output, bool value);
            /*0x7e09144*/ AudioPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7e09234*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x7e092c4*/ void SetEvaluateOnSeek(bool value);
        }
    }
}
