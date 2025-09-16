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

        static /*0x7decb98*/ void InvokeOnAudioConfigurationChanged(bool deviceWasChanged);
        static /*0x7decc04*/ void InvokeOnAudioSystemShuttingDown();
        static /*0x7decc68*/ void InvokeOnAudioSystemStartedUp();
        static /*0x7decccc*/ bool StartAudioOutput();
        static /*0x7deccf4*/ bool StopAudioOutput();

        class AudioConfigurationChangeHandler : System.MulticastDelegate
        {
            /*0x7decd1c*/ AudioConfigurationChangeHandler(object object, nint method);
            /*0x7decdbc*/ void Invoke(bool deviceWasChanged);
        }

        class Mobile
        {
            static /*0x0*/ bool <muteState>k__BackingField;
            static /*0x1*/ bool _stopAudioOutputOnMute;
            static /*0x8*/ System.Action<bool> OnMuteStateChanged;

            static /*0x7decdd4*/ bool get_muteState();
            static /*0x7dece1c*/ void set_muteState(bool value);
            static /*0x7dece6c*/ bool get_stopAudioOutputOnMute();
            static /*0x7deceb4*/ void InvokeOnMuteStateChanged(bool mute);
            static /*0x7ded084*/ bool InvokeIsStopAudioOutputOnMuteEnabled();
            static /*0x7ded05c*/ void StartAudioOutput();
            static /*0x7ded034*/ void StopAudioOutput();
        }
    }

    class AudioClip : UnityEngine.Audio.AudioResource
    {
        /*0x18*/ UnityEngine.AudioClip.PCMReaderCallback m_PCMReaderCallback;
        /*0x20*/ UnityEngine.AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

        static /*0x7ded154*/ bool GetData(UnityEngine.AudioClip clip, System.Span<float> data, int samplesOffset);
        static /*0x7ded2d0*/ bool SetData(UnityEngine.AudioClip clip, System.ReadOnlySpan<float> data, int samplesOffset);
        static /*0x7ded44c*/ UnityEngine.AudioClip Construct_Internal();
        static /*0x7dee638*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream);
        static /*0x7dee658*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback);
        static /*0x7dee7d0*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback);
        static /*0x7dee648*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream);
        static /*0x7dee7e0*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback);
        static /*0x7dee668*/ UnityEngine.AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, UnityEngine.AudioClip.PCMReaderCallback pcmreadercallback, UnityEngine.AudioClip.PCMSetPositionCallback pcmsetpositioncallback);
        static /*0x7ded27c*/ bool GetData_Injected(nint clip, ref UnityEngine.Bindings.ManagedSpanWrapper data, int samplesOffset);
        static /*0x7ded3f8*/ bool SetData_Injected(nint clip, ref UnityEngine.Bindings.ManagedSpanWrapper data, int samplesOffset);
        static /*0x7ded4b0*/ nint Construct_Internal_Injected();
        static /*0x7ded5d4*/ void GetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ded7e8*/ void CreateUserSound_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream);
        static /*0x7ded8d4*/ float get_length_Injected(nint _unity_self);
        static /*0x7ded988*/ int get_samples_Injected(nint _unity_self);
        static /*0x7deda3c*/ int get_channels_Injected(nint _unity_self);
        static /*0x7dedaf0*/ int get_frequency_Injected(nint _unity_self);
        static /*0x7dedba4*/ bool get_isReadyToPlay_Injected(nint _unity_self);
        static /*0x7dedc58*/ UnityEngine.AudioClipLoadType get_loadType_Injected(nint _unity_self);
        static /*0x7dedd0c*/ bool LoadAudioData_Injected(nint _unity_self);
        static /*0x7deddc0*/ bool UnloadAudioData_Injected(nint _unity_self);
        static /*0x7dede74*/ bool get_preloadAudioData_Injected(nint _unity_self);
        static /*0x7dedf28*/ bool get_ambisonic_Injected(nint _unity_self);
        static /*0x7dedfdc*/ bool get_loadInBackground_Injected(nint _unity_self);
        static /*0x7dee090*/ UnityEngine.AudioDataLoadState get_loadState_Injected(nint _unity_self);
        /*0x7ded0cc*/ AudioClip();
        /*0x7ded4d8*/ string GetName();
        /*0x7ded618*/ void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream);
        /*0x7ded85c*/ float get_length();
        /*0x7ded910*/ int get_samples();
        /*0x7ded9c4*/ int get_channels();
        /*0x7deda78*/ int get_frequency();
        /*0x7dedb2c*/ bool get_isReadyToPlay();
        /*0x7dedbe0*/ UnityEngine.AudioClipLoadType get_loadType();
        /*0x7dedc94*/ bool LoadAudioData();
        /*0x7dedd48*/ bool UnloadAudioData();
        /*0x7deddfc*/ bool get_preloadAudioData();
        /*0x7dedeb0*/ bool get_ambisonic();
        /*0x7dedf64*/ bool get_loadInBackground();
        /*0x7dee018*/ UnityEngine.AudioDataLoadState get_loadState();
        /*0x7dee0cc*/ bool GetData(System.Span<float> data, int offsetSamples);
        /*0x7dee1c0*/ bool GetData(float[] data, int offsetSamples);
        /*0x7dee2e8*/ bool SetData(float[] data, int offsetSamples);
        /*0x7dee4b8*/ bool SetData(System.ReadOnlySpan<float> data, int offsetSamples);
        /*0x7dee7ec*/ void add_m_PCMReaderCallback(UnityEngine.AudioClip.PCMReaderCallback value);
        /*0x7dee924*/ void remove_m_PCMReaderCallback(UnityEngine.AudioClip.PCMReaderCallback value);
        /*0x7dee888*/ void add_m_PCMSetPositionCallback(UnityEngine.AudioClip.PCMSetPositionCallback value);
        /*0x7dee9c0*/ void remove_m_PCMSetPositionCallback(UnityEngine.AudioClip.PCMSetPositionCallback value);
        /*0x7deea5c*/ void InvokePCMReaderCallback_Internal(float[] data);
        /*0x7deea78*/ void InvokePCMSetPositionCallback_Internal(int position);

        class PCMReaderCallback : System.MulticastDelegate
        {
            /*0x7deea94*/ PCMReaderCallback(object object, nint method);
            /*0x7deeb44*/ void Invoke(float[] data);
        }

        class PCMSetPositionCallback : System.MulticastDelegate
        {
            /*0x7deeb58*/ PCMSetPositionCallback(object object, nint method);
            /*0x7deebf8*/ void Invoke(int position);
        }
    }

    class AudioBehaviour : UnityEngine.Behaviour
    {
        /*0x7deec0c*/ AudioBehaviour();
    }

    class AudioListener : UnityEngine.AudioBehaviour
    {
        static /*0x7deec14*/ void GetOutputDataHelper(float[] samples, int channel);
        static /*0x7deed7c*/ void GetSpectrumDataHelper(float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7deef04*/ float get_volume();
        static /*0x7deef2c*/ void set_volume(float value);
        static /*0x7deef64*/ bool get_pause();
        static /*0x7deef8c*/ void set_pause(bool value);
        static /*0x7def140*/ float[] GetOutputData(int numSamples, int channel);
        static /*0x7def1a8*/ void GetOutputData(float[] samples, int channel);
        static /*0x7def1ac*/ float[] GetSpectrumData(int numSamples, int channel, UnityEngine.FFTWindow window);
        static /*0x7def21c*/ void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7deed38*/ void GetOutputDataHelper_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel);
        static /*0x7deeeb0*/ void GetSpectrumDataHelper_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7def040*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode_Injected(nint _unity_self);
        static /*0x7def0fc*/ void set_velocityUpdateMode_Injected(nint _unity_self, UnityEngine.AudioVelocityUpdateMode value);
        /*0x7def220*/ AudioListener();
        /*0x7deefc8*/ UnityEngine.AudioVelocityUpdateMode get_velocityUpdateMode();
        /*0x7def07c*/ void set_velocityUpdateMode(UnityEngine.AudioVelocityUpdateMode value);
    }

    class AudioSource : UnityEngine.AudioBehaviour
    {
        static /*0x7def228*/ float GetPitch(UnityEngine.AudioSource source);
        static /*0x7def30c*/ void SetPitch(UnityEngine.AudioSource source, float pitch);
        static /*0x7def410*/ void PlayHelper(UnityEngine.AudioSource source, ulong delay);
        static /*0x7def5c8*/ void GetOutputDataHelper(UnityEngine.AudioSource source, float[] samples, int channel);
        static /*0x7def7b0*/ void GetSpectrumDataHelper(UnityEngine.AudioSource source, float[] samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7def2d0*/ float GetPitch_Injected(nint source);
        static /*0x7def3c4*/ void SetPitch_Injected(nint source, float pitch);
        static /*0x7def4c0*/ void PlayHelper_Injected(nint source, ulong delay);
        static /*0x7def584*/ void Stop_Injected(nint _unity_self, bool stopOneShots);
        static /*0x7def75c*/ void GetOutputDataHelper_Injected(nint source, ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel);
        static /*0x7def954*/ void GetSpectrumDataHelper_Injected(nint source, ref UnityEngine.Bindings.BlittableArrayWrapper samples, int channel, UnityEngine.FFTWindow window);
        static /*0x7defa28*/ float get_volume_Injected(nint _unity_self);
        static /*0x7defaec*/ void set_volume_Injected(nint _unity_self, float value);
        static /*0x7defbb8*/ float get_time_Injected(nint _unity_self);
        static /*0x7defc6c*/ int get_timeSamples_Injected(nint _unity_self);
        static /*0x7defd28*/ void set_timeSamples_Injected(nint _unity_self, int value);
        static /*0x7deff14*/ nint get_resource_Injected(nint _unity_self);
        static /*0x7deff50*/ void set_resource_Injected(nint _unity_self, nint value);
        static /*0x7df0028*/ nint get_outputAudioMixerGroup_Injected(nint _unity_self);
        static /*0x7df0118*/ void set_outputAudioMixerGroup_Injected(nint _unity_self, nint value);
        static /*0x7df01e4*/ void Pause_Injected(nint _unity_self);
        static /*0x7df0298*/ void UnPause_Injected(nint _unity_self);
        static /*0x7df034c*/ bool get_isPlaying_Injected(nint _unity_self);
        static /*0x7df0408*/ void set_loop_Injected(nint _unity_self, bool value);
        static /*0x7df04cc*/ void set_playOnAwake_Injected(nint _unity_self, bool value);
        /*0x7df0518*/ AudioSource();
        /*0x7def504*/ void Stop(bool stopOneShots);
        /*0x7def9b0*/ float get_volume();
        /*0x7defa64*/ void set_volume(float value);
        /*0x7defb38*/ float get_pitch();
        /*0x7defb3c*/ void set_pitch(float value);
        /*0x7defb40*/ float get_time();
        /*0x7defbf4*/ int get_timeSamples();
        /*0x7defca8*/ void set_timeSamples(int value);
        /*0x7defd6c*/ UnityEngine.AudioClip get_clip();
        /*0x7defe5c*/ void set_clip(UnityEngine.AudioClip value);
        /*0x7defdc8*/ UnityEngine.Audio.AudioResource get_resource();
        /*0x7defe60*/ void set_resource(UnityEngine.Audio.AudioResource value);
        /*0x7deff94*/ UnityEngine.Audio.AudioMixerGroup get_outputAudioMixerGroup();
        /*0x7df0064*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
        /*0x7df015c*/ void Play();
        /*0x7df0164*/ void Stop();
        /*0x7df016c*/ void Pause();
        /*0x7df0220*/ void UnPause();
        /*0x7df02d4*/ bool get_isPlaying();
        /*0x7df0388*/ void set_loop(bool value);
        /*0x7df044c*/ void set_playOnAwake(bool value);
        /*0x7df0510*/ void GetOutputData(float[] samples, int channel);
        /*0x7df0514*/ void GetSpectrumData(float[] samples, int channel, UnityEngine.FFTWindow window);
    }

    namespace Experimental
    {
        namespace Audio
        {
            class AudioSampleProvider
            {
                /*0x10*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
                /*0x18*/ UnityEngine.Experimental.Audio.AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;

                /*0x7df0520*/ void InvokeSampleFramesAvailable(int sampleFrameCount);
                /*0x7df0548*/ void InvokeSampleFramesOverflow(int droppedSampleFrameCount);

                class SampleFramesHandler : System.MulticastDelegate
                {
                    /*0x7df0570*/ SampleFramesHandler(object object, nint method);
                    /*0x7df067c*/ void Invoke(UnityEngine.Experimental.Audio.AudioSampleProvider provider, uint sampleFrameCount);
                }
            }
        }
    }

    namespace Audio
    {
        class AudioResource : UnityEngine.Object
        {
            /*0x7ded0fc*/ AudioResource();
        }

        struct AudioClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x7df0690*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7df069c*/ bool Equals(UnityEngine.Audio.AudioClipPlayable other);
        }

        enum AudioMixerUpdateMode
        {
            Normal = 0,
            UnscaledTime = 1,
        }

        class AudioMixer : UnityEngine.Object
        {
            static /*0x7df0800*/ nint get_outputAudioMixerGroup_Injected(nint _unity_self);
            static /*0x7df08f0*/ void set_outputAudioMixerGroup_Injected(nint _unity_self, nint value);
            static /*0x7df0b28*/ nint FindSnapshot_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7df0d14*/ UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper subPath);
            static /*0x7df10d8*/ void TransitionToSnapshotInternal_Injected(nint _unity_self, nint snapshot, float timeToReach);
            static /*0x7df1248*/ void TransitionToSnapshots_Injected(nint _unity_self, UnityEngine.Audio.AudioMixerSnapshot[] snapshots, ref UnityEngine.Bindings.ManagedSpanWrapper weights, float timeToReach);
            static /*0x7df1324*/ UnityEngine.Audio.AudioMixerUpdateMode get_updateMode_Injected(nint _unity_self);
            static /*0x7df13e0*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.Audio.AudioMixerUpdateMode value);
            static /*0x7df15e0*/ bool SetFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value);
            static /*0x7df17e0*/ bool ClearFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7df19e0*/ bool GetFloat_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref float value);
            static /*0x7df1ae8*/ float GetAbsoluteAudibilityFromGroup_Injected(nint _unity_self, nint group);
            /*0x7df0714*/ AudioMixer();
            /*0x7df076c*/ UnityEngine.Audio.AudioMixerGroup get_outputAudioMixerGroup();
            /*0x7df083c*/ void set_outputAudioMixerGroup(UnityEngine.Audio.AudioMixerGroup value);
            /*0x7df0934*/ UnityEngine.Audio.AudioMixerSnapshot FindSnapshot(string name);
            /*0x7df0b6c*/ UnityEngine.Audio.AudioMixerGroup[] FindMatchingGroups(string subPath);
            /*0x7df0d58*/ void TransitionToSnapshot(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach);
            /*0x7df1014*/ void TransitionToSnapshotInternal(UnityEngine.Audio.AudioMixerSnapshot snapshot, float timeToReach);
            /*0x7df112c*/ void TransitionToSnapshots(UnityEngine.Audio.AudioMixerSnapshot[] snapshots, float[] weights, float timeToReach);
            /*0x7df12ac*/ UnityEngine.Audio.AudioMixerUpdateMode get_updateMode();
            /*0x7df1360*/ void set_updateMode(UnityEngine.Audio.AudioMixerUpdateMode value);
            /*0x7df1424*/ bool SetFloat(string name, float value);
            /*0x7df1634*/ bool ClearFloat(string name);
            /*0x7df1824*/ bool GetFloat(string name, ref float value);
            /*0x7df1a34*/ float GetAbsoluteAudibilityFromGroup(UnityEngine.Audio.AudioMixerGroup group);
        }

        class AudioMixerGroup : UnityEngine.Object, UnityEngine.Internal.ISubAssetNotDuplicatable
        {
            static /*0x7df1c18*/ nint get_audioMixer_Injected(nint _unity_self);
            /*0x7df1b2c*/ AudioMixerGroup();
            /*0x7df1b84*/ UnityEngine.Audio.AudioMixer get_audioMixer();
        }

        struct AudioMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Audio.AudioMixerPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x7df1c54*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7df1c60*/ bool Equals(UnityEngine.Audio.AudioMixerPlayable other);
        }

        class AudioMixerSnapshot : UnityEngine.Object, UnityEngine.Internal.ISubAssetNotDuplicatable
        {
            static /*0x7df1cd8*/ nint get_audioMixer_Injected(nint _unity_self);
            /*0x7df0f80*/ UnityEngine.Audio.AudioMixer get_audioMixer();
        }

        struct AudioPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7df1e10*/ UnityEngine.Audio.AudioPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x7df1ed8*/ void InternalSetEvaluateOnSeek(ref UnityEngine.Playables.PlayableOutputHandle output, bool value);
            /*0x7df1d14*/ AudioPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7df1e04*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x7df1e94*/ void SetEvaluateOnSeek(bool value);
        }
    }
}
