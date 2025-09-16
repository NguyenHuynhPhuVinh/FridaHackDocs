class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3fed3f0*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x3fed3f8*/ NullableAttribute(byte );
                /*0x3fed480*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3fed4b0*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3fed4d8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3fed5cc*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Assets
{
    namespace GameUi
    {
        namespace Externals
        {
            interface IAudioManager
            {
                /*0x380b128*/ bool get_EnableVoiceSampler();
                /*0x380cdf0*/ void set_EnableVoiceSampler(bool value);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayVoice(string key, UnityEngine.AudioSource audioSource, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayVoice(string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource[]> PlayVoices(string[] keys);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayBackgroundVoice(string key);
                Cysharp.Threading.Tasks.UniTask PlayBackgroundVoice(string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string key);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>[]> StartSyncVoices(string[] keys);
                /*0x380cb08*/ void StopBgm();
                /*0x380cb08*/ void StopVoice();
                /*0x380cb08*/ void StopBackgroundVoice();
                Cysharp.Threading.Tasks.UniTask PlayBgm(Assets.GameUi.Externals.AudioManager.BgmArgs args);
                System.Nullable<int> GetCurrentBgmTimeSamples(bool correctFrequency);
                Cysharp.Threading.Tasks.UniTask PlaySe(string key);
                /*0x380cffc*/ void SetVoiceChannelVolume(int percentage);
                /*0x380cffc*/ void SetBgmChannelVolume(int percentage);
                /*0x380cffc*/ void SetSeChannelVolume(int percentage);
                /*0x380cffc*/ void SetBackgroundVoiceChannelVolume(int percentage);
                /*0x380d83c*/ void PlaySe(UnityEngine.AudioClip clip);
                Cysharp.Threading.Tasks.UniTask StopSe(string key);
                /*0x380cb08*/ void StopSe();
                /*0x380cb08*/ void PauseBgm();
                /*0x380cb08*/ void ResumeBgm();
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, string key);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlaySystemVoice(string assetId, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncSystemVoice(string assetId);
                Cysharp.Threading.Tasks.UniTask WaitUntilPlaybackStarts(UnityEngine.AudioSource source);
                Cysharp.Threading.Tasks.UniTask WaitWhilePlaying(UnityEngine.AudioSource source);
                /*0x380b2f0*/ bool AlreadyVoicePlaying(string assetId);
                /*0x380b128*/ bool IsVoicePlaying();
            }

            class AudioManager : UnityEngine.MonoBehaviour, Assets.GameUi.Externals.IAudioManager
            {
                static int BackgroundMusicSourceCount = 2;
                static int SoundEffectSourceCount = 5;
                static int VoiceSourceCount = 5;
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.AudioSource> backgroundMusicSources;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.AudioSource> soundEffectSources;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.AudioSource> voiceSources;
                static /*0x18*/ System.Collections.Generic.List<UnityEngine.AudioSource> backgroundVoiceSources;
                /*0x20*/ UnityEngine.Audio.AudioMixer audioMixer;
                /*0x28*/ int activeBackgroundMusicSourceIndex;
                /*0x2c*/ int targetBackgroundMusicSourceIndex;
                /*0x30*/ int activeVoiceSourceIndex;
                /*0x34*/ int activeSoundEffectsSourceIndex;
                /*0x38*/ UnityEngine.Audio.AudioMixerGroup backgroundMusicChannel;
                /*0x40*/ UnityEngine.Audio.AudioMixerGroup soundEffectChannel;
                /*0x48*/ UnityEngine.Audio.AudioMixerGroup voiceChannel;
                /*0x50*/ UnityEngine.Audio.AudioMixerGroup backgroundVoiceChannel;
                /*0x58*/ Assets.AssetManagement.IAddressablesAssetProvider <AssetProvider>k__BackingField;
                /*0x60*/ Assets.AssetManagement.IAddressablesKeyProvider <KeyProvider>k__BackingField;
                /*0x68*/ Assets.GameUi.Externals.ILocalSettingsManager <LocalSettings>k__BackingField;
                /*0x70*/ Assets.GameUi.Externals.ICustomAudioSampler <AudioSampler>k__BackingField;
                /*0x78*/ UniRx.ReactiveProperty<System.ValueTuple<string, float>[]> <VoiceVolumes>k__BackingField;
                /*0x80*/ bool <EnableVoiceSampler>k__BackingField;
                /*0x84*/ System.Nullable<int> loopStartSampleCounts;
                /*0x8c*/ System.Nullable<int> loopEndSampleCounts;

                static /*0x3ff1940*/ AudioManager();
                static /*0x3ff11dc*/ void Resume(UnityEngine.AudioSource source);
                static /*0x3ff14c8*/ float PercentageToDecibel(int percentage);
                /*0x3ff18b8*/ AudioManager();
                /*0x3fed5d4*/ Assets.AssetManagement.IAddressablesAssetProvider get_AssetProvider();
                /*0x3fed5dc*/ void set_AssetProvider(Assets.AssetManagement.IAddressablesAssetProvider value);
                /*0x3fed5e4*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3fed5ec*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3fed5f4*/ Assets.GameUi.Externals.ILocalSettingsManager get_LocalSettings();
                /*0x3fed5fc*/ void set_LocalSettings(Assets.GameUi.Externals.ILocalSettingsManager value);
                /*0x3fed604*/ Assets.GameUi.Externals.ICustomAudioSampler get_AudioSampler();
                /*0x3fed60c*/ void set_AudioSampler(Assets.GameUi.Externals.ICustomAudioSampler value);
                /*0x3fed614*/ UniRx.ReactiveProperty<System.ValueTuple<string, float>[]> get_VoiceVolumes();
                /*0x3fed61c*/ bool get_EnableVoiceSampler();
                /*0x3fed624*/ void set_EnableVoiceSampler(bool value);
                /*0x3fed630*/ void Start();
                /*0x3fee198*/ void Update();
                /*0x3fee46c*/ void OnDestroy();
                /*0x3fee7d0*/ UnityEngine.AudioSource AcquireBgmSource();
                /*0x3feeac8*/ UnityEngine.AudioSource AcquireBgmVoiceSource();
                /*0x3feeb24*/ UnityEngine.AudioSource AcquireSeSource();
                /*0x3feebe8*/ UnityEngine.AudioSource AcquireVoiceSource();
                /*0x3feecac*/ Cysharp.Threading.Tasks.UniTask PlayBgm(Assets.GameUi.Externals.AudioManager.BgmArgs args);
                /*0x3feed78*/ System.Nullable<int> GetCurrentBgmTimeSamples(bool correctFrequency);
                /*0x3feef5c*/ Cysharp.Threading.Tasks.UniTask PlaySe(string key);
                /*0x3fef028*/ void PlaySe(UnityEngine.AudioClip clip);
                /*0x3fef110*/ Cysharp.Threading.Tasks.UniTask StopSe(string key);
                /*0x3fef1e0*/ void StopSe();
                /*0x3fef354*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayVoice(string key, UnityEngine.AudioSource audioSource, System.Threading.CancellationToken token);
                /*0x3fef4a4*/ Cysharp.Threading.Tasks.UniTask PlayVoice(string key, System.Threading.CancellationToken token);
                /*0x3fef588*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource[]> PlayVoices(string[] keys);
                /*0x3fef9cc*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3fefb10*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3fefc28*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3fefd40*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3fefe58*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3feff70*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterId, string key, System.Threading.CancellationToken token);
                /*0x3ff0040*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, string key, System.Threading.CancellationToken token);
                /*0x3ff0110*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type);
                /*0x3ff035c*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type);
                /*0x3ff0484*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                /*0x3ff05ac*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                /*0x3ff06d4*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, string key);
                /*0x3ff07c4*/ Cysharp.Threading.Tasks.UniTask PlaySystemVoice(string assetId, System.Threading.CancellationToken token);
                /*0x3ff088c*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncSystemVoice(string assetId);
                /*0x3ff0970*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayBackgroundVoice(string key);
                /*0x3ff0a88*/ Cysharp.Threading.Tasks.UniTask PlayBackgroundVoice(string key, System.Threading.CancellationToken token);
                /*0x3ff0238*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string key);
                /*0x3ff0b80*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>[]> StartSyncVoices(string[] keys);
                /*0x3ff0c9c*/ UnityEngine.Audio.AudioMixerGroup get_VoiceMixerGroup();
                /*0x3ff0d1c*/ void StopBgm();
                /*0x3ff0ec0*/ void PauseBgm();
                /*0x3ff104c*/ void ResumeBgm();
                /*0x3fef7d8*/ void StopVoice();
                /*0x3ff11f0*/ void StopBackgroundVoice();
                /*0x3ff1354*/ void Crossfade(UnityEngine.AudioSource active, UnityEngine.AudioSource target, float duration);
                /*0x3fef044*/ void Play(UnityEngine.AudioClip clip, UnityEngine.AudioSource source);
                /*0x3ff0e80*/ void Stop(UnityEngine.AudioSource source);
                /*0x3ff1034*/ void Pause(UnityEngine.AudioSource source);
                /*0x3fee82c*/ UnityEngine.AudioSource AcquireAudioSource(System.Collections.Generic.List<UnityEngine.AudioSource> list, System.Nullable<int> index);
                /*0x3fedc58*/ void SetVoiceChannelVolume(int percentage);
                /*0x3fedef8*/ void SetBgmChannelVolume(int percentage);
                /*0x3fee060*/ void SetSeChannelVolume(int percentage);
                /*0x3fedd90*/ void SetBackgroundVoiceChannelVolume(int percentage);
                /*0x3fee450*/ int CorrectFrequency(long frequency, long n, bool reverse);
                /*0x3ff1520*/ bool AlreadyVoicePlaying(string assetId);
                /*0x3ff1638*/ Cysharp.Threading.Tasks.UniTask WaitUntilPlaybackStarts(UnityEngine.AudioSource source);
                /*0x3ff16e4*/ Cysharp.Threading.Tasks.UniTask WaitWhilePlaying(UnityEngine.AudioSource source);
                /*0x3ff1790*/ bool IsVoicePlaying();

                class BgmArgs
                {
                    /*0x10*/ string <AssetId>k__BackingField;
                    /*0x18*/ System.Nullable<int> <LoopStartSampleCounts>k__BackingField;
                    /*0x20*/ System.Nullable<int> <LoopEndSampleCounts>k__BackingField;
                    /*0x28*/ System.Nullable<int> <StartSampleCounts>k__BackingField;

                    /*0x3ff1a90*/ BgmArgs();
                    /*0x3ff1a50*/ string get_AssetId();
                    /*0x3ff1a58*/ void set_AssetId(string value);
                    /*0x3ff1a60*/ System.Nullable<int> get_LoopStartSampleCounts();
                    /*0x3ff1a68*/ void set_LoopStartSampleCounts(System.Nullable<int> value);
                    /*0x3ff1a70*/ System.Nullable<int> get_LoopEndSampleCounts();
                    /*0x3ff1a78*/ void set_LoopEndSampleCounts(System.Nullable<int> value);
                    /*0x3ff1a80*/ System.Nullable<int> get_StartSampleCounts();
                    /*0x3ff1a88*/ void set_StartSampleCounts(System.Nullable<int> value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.GameUi.Externals.AudioManager.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.AudioSource, bool> <>9__74_0;
                    static /*0x10*/ System.Func<UnityEngine.AudioSource, bool> <>9__87_0;
                    static /*0x18*/ System.Func<UnityEngine.AudioSource, bool> <>9__87_1;
                    static /*0x20*/ System.Func<UnityEngine.AudioSource, bool> <>9__97_0;

                    static /*0x3ff1ac4*/ <>c();
                    /*0x3ff1b2c*/ <>c();
                    /*0x3ff1b34*/ bool <StartSyncVoices>b__74_0(UnityEngine.AudioSource source);
                    /*0x3ff1bac*/ bool <AcquireAudioSource>b__87_0(UnityEngine.AudioSource s);
                    /*0x3ff1c34*/ bool <AcquireAudioSource>b__87_1(UnityEngine.AudioSource s);
                    /*0x3ff1cbc*/ bool <IsVoicePlaying>b__97_0(UnityEngine.AudioSource v);
                }

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ UnityEngine.AudioClip clip;

                    /*0x3ff1cd4*/ <>c__DisplayClass52_0();
                    /*0x3ff1cdc*/ bool <StopSe>b__0(UnityEngine.AudioSource s);
                }

                class <>c__DisplayClass72_0
                {
                    /*0x10*/ UnityEngine.AudioSource source;

                    /*0x3ff1d5c*/ <>c__DisplayClass72_0();
                    /*0x3ff1d64*/ void <PlayBackgroundVoice>b__0();
                }

                class <>c__DisplayClass82_0
                {
                    /*0x10*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x18*/ UnityEngine.AudioSource active;

                    /*0x3ff14c0*/ <>c__DisplayClass82_0();
                    /*0x3ff1d80*/ void <Crossfade>b__0();
                }

                class <>c__DisplayClass94_0
                {
                    /*0x10*/ string assetId;

                    /*0x3ff1630*/ <>c__DisplayClass94_0();
                    /*0x3ff1d9c*/ bool <AlreadyVoicePlaying>b__0(UnityEngine.AudioSource source);
                }

                class <>c__DisplayClass95_0
                {
                    /*0x10*/ UnityEngine.AudioSource source;

                    /*0x3ff1e64*/ <>c__DisplayClass95_0();
                    /*0x3ff1e6c*/ bool <WaitUntilPlaybackStarts>b__0();
                }

                class <>c__DisplayClass96_0
                {
                    /*0x10*/ UnityEngine.AudioSource source;
                    /*0x18*/ float timeout;

                    /*0x3ff1f30*/ <>c__DisplayClass96_0();
                    /*0x3ff1f38*/ bool <WaitWhilePlaying>b__0();
                }

                struct <PlayBackgroundVoice>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.AudioSource> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ UnityEngine.AudioSource <source>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3ff2010*/ void MoveNext();
                    /*0x3ff28d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlayBackgroundVoice>d__72 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ Assets.GameUi.Externals.AudioManager.<> <>8__1;
                    /*0x40*/ System.Threading.CancellationToken token;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioSource> <>u__1;
                    /*0x60*/ System.Threading.CancellationTokenRegistration <>7__wrap1;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3ff292c*/ void MoveNext();
                    /*0x3ff31c8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlayBgm>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager.BgmArgs args;
                    /*0x30*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;

                    /*0x3ff31d4*/ void MoveNext();
                    /*0x3ff3a98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlaySe>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;

                    /*0x3ff3aa4*/ void MoveNext();
                    /*0x3ff4020*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlayVoice>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.AudioSource> <>t__builder;
                    /*0x30*/ UnityEngine.AudioSource audioSource;
                    /*0x38*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x40*/ string key;
                    /*0x48*/ System.Threading.CancellationToken token;
                    /*0x50*/ UnityEngine.AudioSource <source>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3ff402c*/ void MoveNext();
                    /*0x3ff48d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlayVoice>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ System.Threading.CancellationToken token;
                    /*0x40*/ UnityEngine.AudioSource <source>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioSource> <>u__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3ff4930*/ void MoveNext();
                    /*0x3ff5128*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StartSyncVoice>d__73 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> <>t__builder;
                    /*0x40*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x48*/ string key;
                    /*0x50*/ UnityEngine.AudioSource <source>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioSource> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

                    /*0x3ff5134*/ void MoveNext();
                    /*0x3ff59f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StartSyncVoices>d__74 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>[]> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x38*/ string[] keys;
                    /*0x40*/ System.Collections.Generic.List<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> <results>5__2;
                    /*0x48*/ UnityEngine.AudioSource[] <sources>5__3;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioSource[]> <>u__1;
                    /*0x68*/ UnityEngine.AudioSource[] <>7__wrap3;
                    /*0x70*/ int <>7__wrap4;
                    /*0x78*/ UnityEngine.AudioSource <source>5__6;
                    /*0x80*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

                    /*0x3ff5a48*/ void MoveNext();
                    /*0x3ff66d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StopSe>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ Assets.GameUi.Externals.AudioManager.<> <>8__1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;

                    /*0x3ff672c*/ void MoveNext();
                    /*0x3ff6e08*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WaitUntilPlaybackStarts>d__95 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.AudioSource source;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ff6e14*/ void MoveNext();
                    /*0x3ff72b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WaitWhilePlaying>d__96 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.AudioSource source;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ff72c0*/ void MoveNext();
                    /*0x3ff7870*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICustomAudioSampler
            {
                Cysharp.Threading.Tasks.UniTask<bool> StartSync(UnityEngine.AudioSource audioSource);
                /*0x380d83c*/ void StopSync(UnityEngine.AudioSource audioSource);
                /*0x380cb08*/ void Update();
                /*0x380bb68*/ UniRx.ReactiveProperty<float> GetVolume(UnityEngine.AudioSource audioSource);
            }

            class CustomAudioSampler : Assets.GameUi.Externals.ICustomAudioSampler
            {
                static int SAMPLE_SIZE = 512;
                /*0x10*/ float[] samples;
                /*0x18*/ Assets.Plugins.WebGl.IJSInterop jSInterop;
                /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.AudioSource, Assets.GameUi.Externals.CustomAudioSampler.VoiceSample> voiceSamples;
                /*0x28*/ UniRx.ReactiveProperty<float> <Volume>k__BackingField;

                /*0x3ff7884*/ CustomAudioSampler(Assets.Plugins.WebGl.IJSInterop jSInterop);
                /*0x3ff787c*/ UniRx.ReactiveProperty<float> get_Volume();
                /*0x3ff79ac*/ Cysharp.Threading.Tasks.UniTask<bool> StartSync(UnityEngine.AudioSource audioSource);
                /*0x3ff7aa0*/ void StopSync(UnityEngine.AudioSource audioSource);
                /*0x3ff7c9c*/ void Update();
                /*0x3ff8040*/ UniRx.ReactiveProperty<float> GetVolume(UnityEngine.AudioSource audioSource);

                class VoiceSample
                {
                    /*0x10*/ float[] samples;
                    /*0x18*/ Assets.Plugins.WebGl.IJSInterop jSInterop;
                    /*0x20*/ UnityEngine.AudioSource audioSource;
                    /*0x28*/ UniRx.ReactiveProperty<float> <Volume>k__BackingField;

                    /*0x3ff80cc*/ VoiceSample(Assets.Plugins.WebGl.IJSInterop jSInterop, UnityEngine.AudioSource audioSource);
                    /*0x3ff80c4*/ UniRx.ReactiveProperty<float> get_Volume();
                    /*0x3ff81b4*/ Cysharp.Threading.Tasks.UniTask<bool> StartSync();
                    /*0x3ff7b44*/ void StopSync();
                    /*0x3ff7e04*/ void Update();

                    class <>c
                    {
                        static /*0x0*/ Assets.GameUi.Externals.CustomAudioSampler.VoiceSample.<> <>9;
                        static /*0x8*/ System.Func<float, float> <>9__9_0;

                        static /*0x3ff8290*/ <>c();
                        /*0x3ff82f8*/ <>c();
                        /*0x3ff8300*/ float <Update>b__9_0(float s);
                    }

                    struct <StartSync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                        /*0x30*/ Assets.GameUi.Externals.CustomAudioSampler.VoiceSample <>4__this;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3ff8308*/ void MoveNext();
                        /*0x3ff894c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                struct <StartSync>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.CustomAudioSampler <>4__this;
                    /*0x38*/ UnityEngine.AudioSource audioSource;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3ff89a4*/ void MoveNext();
                    /*0x3ff8f04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IBackgroundManager
            {
                Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes type, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                Cysharp.Threading.Tasks.UniTask TransitionTo(string key, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Nullable<UnityEngine.Color> color);
                Cysharp.Threading.Tasks.UniTask TransitionToEmpty(UnityEngine.Color color, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.Video.VideoPlayer> TransitionToVideo(string key, bool loop, float duration, DG.Tweening.Ease ease);
                Cysharp.Threading.Tasks.UniTask TransitionToBackgroundSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed);
                Cysharp.Threading.Tasks.UniTask TransitionToAdventureSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed);
                Cysharp.Threading.Tasks.UniTask TransitionToExtraSkillSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Action onEndAction);
                Cysharp.Threading.Tasks.UniTask TransitionToDirectAssetTexture(string key, float duration, DG.Tweening.Ease ease);
                Cysharp.Threading.Tasks.UniTask TransitionToFunctinalImage(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type, string assetId, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x380e050*/ void Blur(float duration);
                Cysharp.Threading.Tasks.UniTask Zoom(Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x380cdf0*/ void SetActive(bool active);
                /*0x380b9e8*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> get_SpeechBubblePoints();
                System.ValueTuple<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>[], float> get_LocatorPoints();
                System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> GetSpineTapPosition(ref System.Nullable<UnityEngine.Vector2> mousePosition);
                /*0x380a988*/ System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> get_SpineTapPosition();
                /*0x380b9e8*/ System.Collections.Generic.Dictionary<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes, System.ValueTuple<UnityEngine.Vector3, float>> get_SpineTapBoneScreenPositions();
                /*0x380b9e8*/ Assets.GameUi.Externals.BackgroundManagerArgs get_Args();
                Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.BackgroundManagerArgs args);
            }

            class BackgroundManager : UnityEngine.MonoBehaviour, Assets.GameUi.Externals.IBackgroundManager
            {
                /*0x20*/ Assets.GameUi.Externals.BackgroundPanel background;
                /*0x28*/ Assets.GameUi.Externals.BackgroundPanel foreground;
                /*0x30*/ UnityEngine.Rect defaultRect;
                /*0x40*/ Assets.AssetManagement.IAddressablesKeyProvider <KeyProvider>k__BackingField;
                /*0x48*/ Assets.AssetManagement.ITextureAssetProvider <TextureAssetProvider>k__BackingField;
                /*0x50*/ Assets.AssetManagement.ISpineAssetProvider <SpineAssetProvider>k__BackingField;
                /*0x58*/ Assets.AssetManagement.IDirectAssetProvider <DirectAssetProvider>k__BackingField;
                /*0x60*/ Assets.AssetManagement.IAssetInstanceProvider <AssetInstanceProvider>k__BackingField;
                /*0x68*/ Assets.GameUi.Externals.BackgroundManagerArgs <Args>k__BackingField;
                /*0x70*/ System.Threading.CancellationTokenSource cancellationTokenSource;

                static /*0x3ff9488*/ string BuiltInBackgroundTypeToAssetId(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes type);
                static /*0x3ffba74*/ Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection <GetSpeechBubblePoints>g__GetDirectionFrom|60_1(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
                /*0x3ffbd24*/ BackgroundManager();
                /*0x3ff8f5c*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3ff8f64*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3ff8f6c*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                /*0x3ff8f74*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3ff8f7c*/ Assets.AssetManagement.ISpineAssetProvider get_SpineAssetProvider();
                /*0x3ff8f84*/ void set_SpineAssetProvider(Assets.AssetManagement.ISpineAssetProvider value);
                /*0x3ff8f8c*/ Assets.AssetManagement.IDirectAssetProvider get_DirectAssetProvider();
                /*0x3ff8f94*/ void set_DirectAssetProvider(Assets.AssetManagement.IDirectAssetProvider value);
                /*0x3ff8f9c*/ Assets.AssetManagement.IAssetInstanceProvider get_AssetInstanceProvider();
                /*0x3ff8fa4*/ void set_AssetInstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                /*0x3ff8fac*/ Assets.GameUi.Externals.BackgroundManagerArgs get_Args();
                /*0x3ff8fb4*/ void set_Args(Assets.GameUi.Externals.BackgroundManagerArgs value);
                /*0x3ff8fbc*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes type, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x3ff9624*/ Cysharp.Threading.Tasks.UniTask TransitionTo(string key, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Nullable<UnityEngine.Color> color);
                /*0x3ff974c*/ Cysharp.Threading.Tasks.UniTask TransitionToEmpty(UnityEngine.Color color, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x3ff9a84*/ Cysharp.Threading.Tasks.UniTask TransitionToDirectAssetTexture(string key, float duration, DG.Tweening.Ease ease);
                /*0x3ff9b6c*/ Cysharp.Threading.Tasks.UniTask TransitionToFunctinalImage(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type, string key, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x3ff9c74*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Video.VideoPlayer> TransitionToVideo(string key, bool loop, float duration, DG.Tweening.Ease ease);
                /*0x3ff9dbc*/ Cysharp.Threading.Tasks.UniTask TransitionToBackgroundSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed);
                /*0x3ffa080*/ Cysharp.Threading.Tasks.UniTask TransitionToAdventureSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed);
                /*0x3ffa214*/ Cysharp.Threading.Tasks.UniTask TransitionToExtraSkillSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Action onEndAction);
                /*0x3ffa3c4*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.BackgroundManagerArgs args);
                /*0x3ffa494*/ void Blur(float duration);
                /*0x3ffa5ac*/ Cysharp.Threading.Tasks.UniTask Zoom(Assets.GameUi.Externals.BackgroundManager.ZoomArgs args);
                /*0x3ffa6b0*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> get_SpeechBubblePoints();
                /*0x3ffaa7c*/ System.ValueTuple<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>[], float> get_LocatorPoints();
                /*0x3ffab30*/ System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> GetSpineTapPosition(ref System.Nullable<UnityEngine.Vector2> mousePosition);
                /*0x3ffb4ec*/ System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> get_SpineTapPosition();
                /*0x3ffb510*/ System.Collections.Generic.Dictionary<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes, System.ValueTuple<UnityEngine.Vector3, float>> get_SpineTapBoneScreenPositions();
                /*0x3ff9380*/ Cysharp.Threading.Tasks.UniTask TransitionTo(UnityEngine.Texture2D texture, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x3ff9944*/ Cysharp.Threading.Tasks.UniTask TransitionToTexture(UnityEngine.Texture2D texture, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Nullable<UnityEngine.Color> color, System.Threading.CancellationToken cancellationToken);
                /*0x3ff9f50*/ Cysharp.Threading.Tasks.UniTask TransitionToSpine(Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes type, string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Action onEndAction);
                /*0x3ffb514*/ Cysharp.Threading.Tasks.UniTask TransitionToFunctinalImage(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type, string assetId, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Threading.CancellationToken cancellationToken);
                /*0x3ff92a0*/ Cysharp.Threading.Tasks.UniTask TransitionToBeDisabled(float duration, DG.Tweening.Ease ease, System.Threading.CancellationToken cancellationToken);
                /*0x3ffb640*/ Cysharp.Threading.Tasks.UniTask Transition(float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Threading.CancellationToken cancellationToken, System.Action onEndAction);
                /*0x3ffb770*/ Cysharp.Threading.Tasks.UniTask TransitionIn(Assets.GameUi.Externals.BackgroundPanel panel, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Threading.CancellationToken token, System.Action onEndAction);
                /*0x3ffb898*/ Cysharp.Threading.Tasks.UniTask TransitionOut(Assets.GameUi.Externals.BackgroundPanel panel, float duration, DG.Tweening.Ease ease, System.Threading.CancellationToken token);
                /*0x3ff921c*/ System.Threading.CancellationToken ResetToken();
                /*0x3ffb978*/ void OnDisable();
                /*0x3ffba4c*/ void SetActive(bool active);
                /*0x3ffa6b4*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> GetSpeechBubblePoints();
                /*0x3ffaa80*/ System.ValueTuple<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>[], float> GetLocatorPoinsts();
                /*0x3ffbaac*/ System.Collections.Generic.IEnumerable<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>> GetTransformedLocatorPoints();
                /*0x3ffb45c*/ bool IsPositionInsideCircle(UnityEngine.Vector2 potion, UnityEngine.Vector2 centerPosition, float radius);
                /*0x3ffaef8*/ System.Collections.Generic.Dictionary<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes, System.ValueTuple<UnityEngine.Vector3, float>> GetSpineTapBonePositions();
                /*0x3ffbdfc*/ bool <TransitionToSpine>b__51_0();

                class MoveArgs
                {
                    /*0x10*/ DG.Tweening.PathType <PathType>k__BackingField;
                    /*0x18*/ UnityEngine.Vector3[] <Paths>k__BackingField;
                    /*0x20*/ float <Duration>k__BackingField;
                    /*0x24*/ DG.Tweening.Ease <Ease>k__BackingField;

                    /*0x3ffbfa8*/ MoveArgs();
                    /*0x3ffbf68*/ DG.Tweening.PathType get_PathType();
                    /*0x3ffbf70*/ void set_PathType(DG.Tweening.PathType value);
                    /*0x3ffbf78*/ UnityEngine.Vector3[] get_Paths();
                    /*0x3ffbf80*/ void set_Paths(UnityEngine.Vector3[] value);
                    /*0x3ffbf88*/ float get_Duration();
                    /*0x3ffbf90*/ void set_Duration(float value);
                    /*0x3ffbf98*/ DG.Tweening.Ease get_Ease();
                    /*0x3ffbfa0*/ void set_Ease(DG.Tweening.Ease value);
                }

                class ScaleArgs
                {
                    /*0x10*/ float <Scale>k__BackingField;
                    /*0x14*/ float <Duration>k__BackingField;
                    /*0x18*/ DG.Tweening.Ease <Ease>k__BackingField;

                    /*0x3ffc03c*/ ScaleArgs();
                    /*0x3ffc00c*/ float get_Scale();
                    /*0x3ffc014*/ void set_Scale(float value);
                    /*0x3ffc01c*/ float get_Duration();
                    /*0x3ffc024*/ void set_Duration(float value);
                    /*0x3ffc02c*/ DG.Tweening.Ease get_Ease();
                    /*0x3ffc034*/ void set_Ease(DG.Tweening.Ease value);
                }

                class ZoomArgs
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundManager.MoveArgs <MoveArgs>k__BackingField;
                    /*0x18*/ Assets.GameUi.Externals.BackgroundManager.ScaleArgs <ScaleArgs>k__BackingField;
                    /*0x20*/ Assets.GameUi.Externals.BackgroundManager.ShakeArgs <ShakeArgs>k__BackingField;

                    /*0x3ffc0b0*/ ZoomArgs();
                    /*0x3ffc044*/ Assets.GameUi.Externals.BackgroundManager.MoveArgs get_MoveArgs();
                    /*0x3ffc04c*/ void set_MoveArgs(Assets.GameUi.Externals.BackgroundManager.MoveArgs value);
                    /*0x3ffc054*/ Assets.GameUi.Externals.BackgroundManager.ScaleArgs get_ScaleArgs();
                    /*0x3ffc05c*/ void set_ScaleArgs(Assets.GameUi.Externals.BackgroundManager.ScaleArgs value);
                    /*0x3ffc064*/ Assets.GameUi.Externals.BackgroundManager.ShakeArgs get_ShakeArgs();
                    /*0x3ffc06c*/ void set_ShakeArgs(Assets.GameUi.Externals.BackgroundManager.ShakeArgs value);
                    /*0x3ffc074*/ bool get_HasDuration();
                }

                class ShakeArgs
                {
                    /*0x10*/ float <Strength>k__BackingField;
                    /*0x14*/ UnityEngine.Animations.Axis <AxisFlags>k__BackingField;
                    /*0x18*/ bool <Once>k__BackingField;

                    /*0x3ffc0ec*/ ShakeArgs();
                    /*0x3ffc0b8*/ float get_Strength();
                    /*0x3ffc0c0*/ void set_Strength(float value);
                    /*0x3ffc0c8*/ UnityEngine.Animations.Axis get_AxisFlags();
                    /*0x3ffc0d0*/ void set_AxisFlags(UnityEngine.Animations.Axis value);
                    /*0x3ffc0d8*/ bool get_Once();
                    /*0x3ffc0e0*/ void set_Once(bool value);
                }

                enum TransitionTypes
                {
                    Texture = 0,
                    VideoFile = 1,
                    Mecanim = 2,
                    FunctionalImage = 3,
                    Disabled = 4,
                }

                enum BuiltInBackgroundTypes
                {
                    EmptyWhite = 0,
                    Lobby = 1,
                    Sea = 2,
                    Portal = 3,
                    StartCaution = 4,
                    Actuator = 5,
                    Simulation = 6,
                    Vip = 7,
                    Maze = 8,
                    MazeTower = 9,
                    Spot = 10,
                    CharacterDetail = 11,
                    Circle = 12,
                    CircleTop = 13,
                    CharacterProfileR = 14,
                    CharacterProfileSr = 15,
                    CharacterProfileSsr = 16,
                    Cyber = 17,
                    QuestTop = 18,
                    StartCautionRated = 19,
                }

                enum BackgroundFunctionalTypes
                {
                    None = 0,
                    Memory = 1,
                    Spot = 2,
                    BuiltIn = 3,
                }

                enum SpineTapPositionTypes
                {
                    Other = 0,
                    Position1 = 1,
                    Position2 = 2,
                    Position3 = 3,
                }

                enum SpeechBubbleDirection
                {
                    LeftTop = 0,
                    LeftBottom = 1,
                    RightTop = 2,
                    RightBottom = 3,
                }

                class <>c
                {
                    static /*0x0*/ Assets.GameUi.Externals.BackgroundManager.<> <>9;
                    static /*0x8*/ System.Func<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>, System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection>> <>9__60_0;

                    static /*0x3ffc0f4*/ <>c();
                    /*0x3ffc15c*/ <>c();
                    /*0x3ffc164*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> <GetSpeechBubblePoints>b__60_0(System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3> locatorPoint);
                }

                class <>c__DisplayClass55_0
                {
                    /*0x10*/ System.Action onEndAction;
                    /*0x18*/ Assets.GameUi.Externals.BackgroundPanel panel;

                    /*0x3ffc200*/ <>c__DisplayClass55_0();
                    /*0x3ffc208*/ void <TransitionIn>b__1(string value);
                    /*0x3ffc22c*/ bool <TransitionIn>b__0();
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ UnityEngine.Transform transform;

                    /*0x3ffbc4c*/ <>c__DisplayClass62_0();
                    /*0x3ffc388*/ System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3> <GetTransformedLocatorPoints>b__0(Assets.Utilities.FunctionalImage.BackgroundComponent.LocatorPoint p);
                }

                struct <Transition>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ float duration;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x38*/ DG.Tweening.Ease ease;
                    /*0x3c*/ System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger;
                    /*0x44*/ bool waitForLoop;
                    /*0x48*/ float animationSpeed;
                    /*0x50*/ System.Threading.CancellationToken cancellationToken;
                    /*0x58*/ System.Action onEndAction;
                    /*0x60*/ float <step>5__2;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ffc45c*/ void MoveNext();
                    /*0x3ffd0d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionIn>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ System.Action onEndAction;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundPanel panel;
                    /*0x38*/ float duration;
                    /*0x3c*/ DG.Tweening.Ease ease;
                    /*0x40*/ System.Threading.CancellationToken token;
                    /*0x48*/ System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger;
                    /*0x50*/ float animationSpeed;
                    /*0x54*/ bool waitForLoop;
                    /*0x58*/ Assets.GameUi.Externals.BackgroundManager.<> <>8__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ffd0dc*/ void MoveNext();
                    /*0x3ffe104*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionOut>d__56 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundPanel panel;
                    /*0x30*/ float duration;
                    /*0x34*/ DG.Tweening.Ease ease;
                    /*0x38*/ System.Threading.CancellationToken token;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ffe110*/ void MoveNext();
                    /*0x3ffed4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionTo>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ float duration;
                    /*0x3c*/ DG.Tweening.Ease ease;
                    /*0x40*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom;
                    /*0x48*/ System.Nullable<UnityEngine.Color> color;
                    /*0x60*/ System.Threading.CancellationToken <token>5__2;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;
                    /*0x80*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3ffed58*/ void MoveNext();
                    /*0x3fff600*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionTo>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManagerArgs args;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Video.VideoPlayer> <>u__2;

                    /*0x3fff60c*/ void MoveNext();
                    /*0x4000df4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionTo>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ UnityEngine.Texture2D texture;
                    /*0x38*/ float duration;
                    /*0x3c*/ DG.Tweening.Ease ease;
                    /*0x40*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x4000e00*/ void MoveNext();
                    /*0x4001250*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToBeDisabled>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ float duration;
                    /*0x34*/ DG.Tweening.Ease ease;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x400125c*/ void MoveNext();
                    /*0x40016fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToDirectAssetTexture>d__31 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ float duration;
                    /*0x3c*/ DG.Tweening.Ease ease;
                    /*0x40*/ System.Threading.CancellationToken <token>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x4001708*/ void MoveNext();
                    /*0x4001f84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToFunctinalImage>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type;
                    /*0x38*/ string key;
                    /*0x40*/ float duration;
                    /*0x44*/ DG.Tweening.Ease ease;
                    /*0x48*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x4001f90*/ void MoveNext();
                    /*0x40024d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToFunctinalImage>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type;
                    /*0x38*/ string assetId;
                    /*0x40*/ float duration;
                    /*0x44*/ DG.Tweening.Ease ease;
                    /*0x48*/ System.Threading.CancellationToken cancellationToken;
                    /*0x50*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x40024e4*/ void MoveNext();
                    /*0x40033a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToSpine>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes type;
                    /*0x38*/ string assetId;
                    /*0x40*/ System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger;
                    /*0x48*/ float animationSpeed;
                    /*0x4c*/ bool waitForLoop;
                    /*0x50*/ float duration;
                    /*0x54*/ DG.Tweening.Ease ease;
                    /*0x58*/ System.Action onEndAction;
                    /*0x60*/ System.Threading.CancellationToken <token>5__2;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineMecanim> <>u__2;

                    /*0x40033b4*/ void MoveNext();
                    /*0x4004798*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToTexture>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ System.Nullable<UnityEngine.Color> color;
                    /*0x40*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x48*/ UnityEngine.Texture2D texture;
                    /*0x50*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom;
                    /*0x58*/ float duration;
                    /*0x5c*/ DG.Tweening.Ease ease;
                    /*0x60*/ System.Threading.CancellationToken cancellationToken;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x40047a4*/ void MoveNext();
                    /*0x4005674*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToVideo>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Video.VideoPlayer> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ bool loop;
                    /*0x44*/ float duration;
                    /*0x48*/ DG.Tweening.Ease ease;
                    /*0x50*/ System.Threading.CancellationToken <token>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x4005680*/ void MoveNext();
                    /*0x400605c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            enum BackgroundTypes
            {
                None = 0,
                BuiltIn = 1,
                Texture = 2,
                Color = 3,
                Video = 4,
                Spine = 5,
                AdventureSpine = 6,
                ExtraSkillSpine = 7,
                DirectTexture = 8,
                FunctionalImage = 9,
            }

            class BackgroundManagerArgs
            {
                /*0x10*/ Assets.GameUi.Externals.BackgroundTypes <Type>k__BackingField;
                /*0x14*/ Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes <BuiltInType>k__BackingField;
                /*0x18*/ string <Key>k__BackingField;
                /*0x20*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes <FunctionalType>k__BackingField;
                /*0x24*/ System.Nullable<UnityEngine.Color> <Color>k__BackingField;
                /*0x38*/ System.Nullable<float> <Duration>k__BackingField;
                /*0x40*/ System.Nullable<DG.Tweening.Ease> <Ease>k__BackingField;
                /*0x48*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs <ZoomArgs>k__BackingField;
                /*0x50*/ System.Nullable<bool> <Loop>k__BackingField;
                /*0x54*/ System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> <Trigger>k__BackingField;
                /*0x5c*/ bool <WaitForLoop>k__BackingField;
                /*0x60*/ System.Nullable<float> <AnimationSpeed>k__BackingField;
                /*0x68*/ System.Action <OnEndAction>k__BackingField;

                /*0x3ff91e8*/ BackgroundManagerArgs();
                /*0x40060b4*/ Assets.GameUi.Externals.BackgroundTypes get_Type();
                /*0x40060bc*/ void set_Type(Assets.GameUi.Externals.BackgroundTypes value);
                /*0x40060c4*/ Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes get_BuiltInType();
                /*0x40060cc*/ void set_BuiltInType(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes value);
                /*0x40060d4*/ string get_Key();
                /*0x40060dc*/ void set_Key(string value);
                /*0x40060e4*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes get_FunctionalType();
                /*0x40060ec*/ void set_FunctionalType(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes value);
                /*0x40060f4*/ System.Nullable<UnityEngine.Color> get_Color();
                /*0x4006108*/ void set_Color(System.Nullable<UnityEngine.Color> value);
                /*0x400611c*/ System.Nullable<float> get_Duration();
                /*0x4006124*/ void set_Duration(System.Nullable<float> value);
                /*0x400612c*/ System.Nullable<DG.Tweening.Ease> get_Ease();
                /*0x4006134*/ void set_Ease(System.Nullable<DG.Tweening.Ease> value);
                /*0x400613c*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs get_ZoomArgs();
                /*0x4006144*/ void set_ZoomArgs(Assets.GameUi.Externals.BackgroundManager.ZoomArgs value);
                /*0x400614c*/ System.Nullable<bool> get_Loop();
                /*0x4006154*/ void set_Loop(System.Nullable<bool> value);
                /*0x400615c*/ System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> get_Trigger();
                /*0x4006164*/ void set_Trigger(System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> value);
                /*0x400616c*/ bool get_WaitForLoop();
                /*0x4006174*/ void set_WaitForLoop(bool value);
                /*0x4006180*/ System.Nullable<float> get_AnimationSpeed();
                /*0x4006188*/ void set_AnimationSpeed(System.Nullable<float> value);
                /*0x4006190*/ System.Action get_OnEndAction();
                /*0x4006198*/ void set_OnEndAction(System.Action value);
            }

            class BackgroundPanel : UnityEngine.MonoBehaviour
            {
                static int BaseWidth = 1920;
                static int BaseHeight = 1080;
                /*0x20*/ UnityEngine.UI.RawImage <Image>k__BackingField;
                /*0x28*/ UnityEngine.Video.VideoPlayer <VideoPlayer>k__BackingField;
                /*0x30*/ Assets.GameUi.Externals.BackgroundManager.TransitionTypes <TransitionType>k__BackingField;
                /*0x38*/ UnityEngine.Material blurMaterial;
                /*0x40*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineViewModel <SpineModel>k__BackingField;
                /*0x48*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundFunctionalViewModel <FunctionalImageModel>k__BackingField;
                /*0x50*/ UnityEngine.RenderTexture renderTexture;
                /*0x58*/ DG.Tweening.Tween activeTween;

                /*0x4006208*/ BackgroundPanel();
                /*0x40061a0*/ UnityEngine.UI.RawImage get_Image();
                /*0x40061a8*/ void set_Image(UnityEngine.UI.RawImage value);
                /*0x40061b0*/ UnityEngine.Video.VideoPlayer get_VideoPlayer();
                /*0x40061b8*/ void set_VideoPlayer(UnityEngine.Video.VideoPlayer value);
                /*0x40061c0*/ Assets.GameUi.Externals.BackgroundManager.TransitionTypes get_TransitionType();
                /*0x40061c8*/ void set_TransitionType(Assets.GameUi.Externals.BackgroundManager.TransitionTypes value);
                /*0x40061d0*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineViewModel get_SpineModel();
                /*0x40061d8*/ void set_SpineModel(Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineViewModel value);
                /*0x3ffae90*/ Assets.AssetManagement.SpineMecanim get_Spine();
                /*0x40061e0*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundFunctionalViewModel get_FunctionalImageModel();
                /*0x40061e8*/ void set_FunctionalImageModel(Assets.GameUi.Externals.BackgroundPanel.BackgroundFunctionalViewModel value);
                /*0x3ffbc54*/ Assets.Utilities.FunctionalImage.BackgroundComponent get_FunctionalImage();
                /*0x4005f60*/ Cysharp.Threading.Tasks.UniTask PlaybackVideoFile(string url, bool loop, System.Threading.CancellationToken token);
                /*0x3ffb9a8*/ void StopVideoFilePlayback();
                /*0x3ffa4ac*/ void Blur(float duration);
                /*0x3ffa5c8*/ Cysharp.Threading.Tasks.UniTask Zoom(Assets.GameUi.Externals.BackgroundManager.ZoomArgs args, System.Threading.CancellationToken cancellationToken);
                /*0x3ffd0b8*/ void KillActiveTween();
                /*0x40061f0*/ void OnDisable();
                /*0x4006210*/ bool <PlaybackVideoFile>b__29_0();

                enum BackgroundSpineTypes
                {
                    None = 0,
                    Background = 1,
                    Adventure = 2,
                    ExtraSkill = 3,
                }

                class BackgroundSpineViewModel
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes <Type>k__BackingField;
                    /*0x18*/ string <AssetId>k__BackingField;
                    /*0x20*/ Assets.AssetManagement.SpineMecanim <Spine>k__BackingField;

                    /*0x4004764*/ BackgroundSpineViewModel();
                    /*0x400622c*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes get_Type();
                    /*0x4006234*/ void set_Type(Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes value);
                    /*0x400623c*/ string get_AssetId();
                    /*0x4006244*/ void set_AssetId(string value);
                    /*0x400624c*/ Assets.AssetManagement.SpineMecanim get_Spine();
                    /*0x4006254*/ void set_Spine(Assets.AssetManagement.SpineMecanim value);
                }

                class BackgroundFunctionalViewModel
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes <Type>k__BackingField;
                    /*0x18*/ string <AssetId>k__BackingField;
                    /*0x20*/ Assets.Utilities.FunctionalImage.BackgroundComponent <Image>k__BackingField;

                    /*0x4003374*/ BackgroundFunctionalViewModel();
                    /*0x400625c*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes get_Type();
                    /*0x4006264*/ void set_Type(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes value);
                    /*0x400626c*/ string get_AssetId();
                    /*0x4006274*/ void set_AssetId(string value);
                    /*0x400627c*/ Assets.Utilities.FunctionalImage.BackgroundComponent get_Image();
                    /*0x4006284*/ void set_Image(Assets.Utilities.FunctionalImage.BackgroundComponent value);
                    /*0x400628c*/ void ReturnImage();
                }

                class <>c__DisplayClass32_0
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundPanel <>4__this;
                    /*0x18*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs args;

                    /*0x4006334*/ <>c__DisplayClass32_0();
                    /*0x400633c*/ void <Zoom>b__0();
                }

                struct <PlaybackVideoFile>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundPanel <>4__this;
                    /*0x30*/ string url;
                    /*0x38*/ bool loop;
                    /*0x40*/ System.Threading.CancellationToken token;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x400648c*/ void MoveNext();
                    /*0x4006acc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Zoom>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundPanel <>4__this;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs args;
                    /*0x38*/ System.Threading.CancellationToken cancellationToken;
                    /*0x40*/ System.Threading.CancellationTokenRegistration <>7__wrap1;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x4006ad8*/ void MoveNext();
                    /*0x40074d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICameraManager
            {
                /*0x380cad0*/ UnityEngine.Vector3 get_Position();
                UnityEngine.Quaternion get_Rotation();
                /*0x380b9e8*/ UnityEngine.Transform get_Transform();
                /*0x380d83c*/ void AddCameraLayer(string layer);
                /*0x380c9d4*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition(System.Threading.CancellationToken cancellationToken);
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                Cysharp.Threading.Tasks.UniTask BlendToDefaultUi(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                Cysharp.Threading.Tasks.UniTask BlendToLoadingFade(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x380d250*/ void ConfigureForCustomBlend(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x380cb08*/ void ConfigureForCutBlend();
                /*0x380cb08*/ void PressNekoNoOnaka();
                /*0x380d83c*/ void RemoveCameraLayer(string layer);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.CameraManager.CameraTypes type, System.Threading.CancellationToken cancellationToken);
            }

            class CameraManager : UnityEngine.MonoBehaviour, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSCameraManager, Assets.GameUi.Externals.ICameraManager
            {
                /*0x20*/ Unity.Cinemachine.CinemachineBrain cinemachineBrain;
                /*0x28*/ Unity.Cinemachine.CinemachineCamera defaultUiCamera;
                /*0x30*/ Unity.Cinemachine.CinemachineCamera loadingFadeCamera;
                /*0x38*/ int loadingFadeSortingLayer;
                /*0x3c*/ Assets.GameUi.Externals.CameraManager.CameraTypes currentFadeInType;

                /*0x4007930*/ CameraManager();
                /*0x40074e4*/ UnityEngine.Transform get_Transform();
                /*0x4007500*/ UnityEngine.Vector3 get_Position();
                /*0x4007528*/ UnityEngine.Quaternion get_Rotation();
                /*0x4007550*/ void PressNekoNoOnaka();
                /*0x400759c*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                /*0x4007648*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x40076f8*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                /*0x4007724*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x40075c8*/ void ConfigureForDefaultBlend();
                /*0x40075d8*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.CameraManager.CameraTypes type, System.Threading.CancellationToken cancellationToken);
                /*0x4007744*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition(System.Threading.CancellationToken cancellationToken);
                /*0x400781c*/ void ConfigureForCutBlend();
                /*0x4007668*/ void ConfigureForCustomBlend(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x4007870*/ void AddCameraLayer(string layer);
                /*0x40078d0*/ void RemoveCameraLayer(string layer);

                enum CameraTypes
                {
                    Undefined = 0,
                    DefaultUi = 1,
                    LoadingFade = 2,
                    SlidingDoors = 4,
                    MonitorInitialization = 8,
                }
            }

            enum CharacterMiscellaneousVoiceTypes
            {
                CallOut = 0,
                Farewell = 1,
                ResponseGood = 2,
                ResponseBad = 3,
                Question = 4,
                Agreement = 5,
                Disagreement = 6,
                Rejection = 7,
                Scream = 8,
                Thank = 9,
                Apology = 10,
                Stop = 11,
                Happiness = 12,
                Pleasure = 13,
                Shy = 14,
                Displeasure = 15,
                Anger = 16,
                Sadness = 17,
                Crying = 18,
                Smile = 19,
                Laugh = 20,
                Confused = 21,
                Surprised = 22,
                Amazed = 23,
                Panic = 24,
                Fear = 25,
                Hesitation = 26,
                Suggesting = 27,
                Objection = 28,
                Serious1 = 29,
                Serious2 = 30,
                Moan = 31,
            }

            enum CharacterSystemVoiceTypes
            {
                ReceiveCall = 0,
                LeaveAlone = 1,
                NewYear = 2,
                Valentine = 3,
                WhiteDay = 4,
                AprilFool = 5,
                JuneBride = 6,
                Tanabata = 7,
                Halloween = 8,
                Christmas = 9,
                UserBirthday = 10,
                HomeMotion1 = 11,
                HomeMotion2 = 12,
                HomeMotion3 = 13,
                HomeMotion4 = 14,
                HomeMotion5 = 15,
                HomeMotion6 = 16,
                HomeNormal1 = 17,
                HomeNormal2 = 18,
                HomeNormal3 = 19,
                CharacterBirthday = 20,
                Introduction = 21,
                EnhanceLevel = 22,
                LimitBreak1 = 23,
                LimitBreak2 = 24,
                EnhanceSkill = 25,
                EnhanceModule = 26,
                Present = 27,
                FavoritePresent = 28,
                EnhanceLikability = 29,
                QuestStart = 30,
                Title = 31,
                TitleX = 32,
                TitleShort = 33,
                MazeStart = 34,
                MazeSuccess = 35,
                MazeFailure = 36,
                MazeAdvance = 37,
                MazeSelect1 = 38,
                MazeSelect2 = 39,
            }

            enum CharacterBattleVoiceTypes
            {
                Victory = 0,
                Defeat = 1,
                ActiveSkill1 = 2,
                ActiveSkill2 = 3,
                PassiveSkill1 = 4,
                PassiveSkill2 = 5,
                EXSkill = 6,
                Hit1 = 7,
                Hit2 = 8,
                Hit3 = 9,
                Support = 10,
                Jamming = 11,
                Annihilated = 12,
                Defeated = 13,
                ActionSkip = 14,
                Worry = 15,
                Praise = 16,
                Appreciate = 17,
                Advantage = 18,
                Struggle = 19,
                Disadvantage = 20,
                StartNormal = 21,
                StartBoss = 22,
                StartReply = 23,
                StartFrightened = 24,
                StartFrightenedReply = 25,
                StartConfident = 26,
                StartConfidentReply = 27,
                StartNegative = 28,
                StartNegativeReply = 29,
                PracticeEnd = 30,
            }

            interface IUiLayoutManager
            {
                /*0x380b9e8*/ UnityEngine.Transform get_Foreground();
                /*0x380b9e8*/ UnityEngine.Transform get_System();
                /*0x380b9e8*/ UnityEngine.Transform get_Overlay();
                /*0x380b9e8*/ UnityEngine.Transform get_OverlayIncludingOutsideSafeArea();
                /*0x380cffc*/ void ChangeForegroundRenderMode(UnityEngine.RenderMode renderMode);
                /*0x380cdf0*/ void set_Loading(bool value);
            }

            class LayoutManager : UnityEngine.MonoBehaviour, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSLayoutManager, Assets.GameUi.Externals.IUiLayoutManager
            {
                /*0x20*/ UnityEngine.Transform <Foreground>k__BackingField;
                /*0x28*/ UnityEngine.Transform <Overlay>k__BackingField;
                /*0x30*/ UnityEngine.Transform <System>k__BackingField;
                /*0x38*/ UnityEngine.Transform <OverlayIncludingOutsideSafeArea>k__BackingField;
                /*0x40*/ UnityEngine.GameObject loading;
                /*0x48*/ UnityEngine.Canvas foregroundCanvas;
                /*0x50*/ Assets.GameUi.Externals.Utilities.SafeAreaConstraint foregroundSafeAreaConstraint;

                /*0x400a8d8*/ LayoutManager();
                /*0x400a610*/ UnityEngine.Transform get_Foreground();
                /*0x400a618*/ void set_Foreground(UnityEngine.Transform value);
                /*0x400a620*/ UnityEngine.Transform get_Overlay();
                /*0x400a628*/ void set_Overlay(UnityEngine.Transform value);
                /*0x400a630*/ UnityEngine.Transform get_System();
                /*0x400a638*/ void set_System(UnityEngine.Transform value);
                /*0x400a640*/ UnityEngine.Transform get_OverlayIncludingOutsideSafeArea();
                /*0x400a648*/ void set_OverlayIncludingOutsideSafeArea(UnityEngine.Transform value);
                /*0x400a650*/ void Awake();
                /*0x400a6bc*/ void ChangeForegroundRenderMode(UnityEngine.RenderMode renderMode);
                /*0x400a8b8*/ void set_Loading(bool value);
            }

            interface ILocalSettingsManager
            {
                /*0x380d83c*/ void Save(Assets.GameUi.Externals.LocalSettings settings);
                /*0x380b9e8*/ Assets.GameUi.Externals.LocalSettings Load();
                /*0x380cb08*/ void Delete();
            }

            class LocalSettingsManager : Assets.GameUi.Externals.ILocalSettingsManager
            {
                static string LocalSettingsKey = "Inu_LocalSetting";
                /*0x10*/ Assets.GameUi.Externals.LocalSettings localSettings;

                /*0x400adfc*/ LocalSettingsManager();
                /*0x400a8e0*/ void Save(Assets.GameUi.Externals.LocalSettings settings);
                /*0x400a97c*/ Assets.GameUi.Externals.LocalSettings Load();
                /*0x400ad9c*/ void Delete();
            }

            class LegalSettings
            {
                /*0x10*/ System.Nullable<int> <AgreementVersion>k__BackingField;

                /*0x400ae14*/ LegalSettings();
                /*0x400ae04*/ System.Nullable<int> get_AgreementVersion();
                /*0x400ae0c*/ void set_AgreementVersion(System.Nullable<int> value);
            }

            class SystemSettings
            {
                /*0x10*/ int <QualityLevel>k__BackingField;
                /*0x14*/ int <SkillMovieCut>k__BackingField;

                /*0x400ae3c*/ SystemSettings();
                /*0x400ae1c*/ int get_QualityLevel();
                /*0x400ae24*/ void set_QualityLevel(int value);
                /*0x400ae2c*/ int get_SkillMovieCut();
                /*0x400ae34*/ void set_SkillMovieCut(int value);
            }

            class AssetDownloadSetting
            {
                /*0x10*/ bool <IsBulkAssetDownloadConfirmed>k__BackingField;

                /*0x400ae60*/ AssetDownloadSetting();
                /*0x400ae4c*/ bool get_IsBulkAssetDownloadConfirmed();
                /*0x400ae54*/ void set_IsBulkAssetDownloadConfirmed(bool value);
            }

            class SoundSettings
            {
                /*0x10*/ bool <AllMute>k__BackingField;
                /*0x11*/ bool <BgmMute>k__BackingField;
                /*0x12*/ bool <SeMute>k__BackingField;
                /*0x13*/ bool <VoiceMute>k__BackingField;
                /*0x14*/ int <BgmVolume>k__BackingField;
                /*0x18*/ int <SeVolume>k__BackingField;
                /*0x1c*/ int <VoiceVolume>k__BackingField;

                /*0x400af60*/ SoundSettings();
                /*0x400ae68*/ bool get_AllMute();
                /*0x400ae70*/ void set_AllMute(bool value);
                /*0x400ae7c*/ bool get_BgmMute();
                /*0x400ae84*/ void set_BgmMute(bool value);
                /*0x400ae90*/ bool get_SeMute();
                /*0x400ae98*/ void set_SeMute(bool value);
                /*0x400aea4*/ bool get_VoiceMute();
                /*0x400aeac*/ void set_VoiceMute(bool value);
                /*0x400aeb8*/ int get_BgmVolume();
                /*0x400aec0*/ void set_BgmVolume(int value);
                /*0x400aec8*/ int get_SeVolume();
                /*0x400aed0*/ void set_SeVolume(int value);
                /*0x400aed8*/ int get_VoiceVolume();
                /*0x400aee0*/ void set_VoiceVolume(int value);
                /*0x400aee8*/ bool get_EnableBgm();
                /*0x400af10*/ bool get_EnableSe();
                /*0x400af38*/ bool get_EnableVoice();
            }

            class ScenarioSettings
            {
                /*0x10*/ Assets.GameUi.Externals.ScenarioTextSpeedTypes <ScenarioTextSpeed>k__BackingField;
                /*0x14*/ Assets.GameUi.Externals.ScenarioTextBackGroundAlphaTypes <ScenarioBackgroundAlpha>k__BackingField;
                /*0x18*/ bool <ScenarioVoiceDownload>k__BackingField;
                /*0x19*/ bool <DoNotShowVoiceDownload>k__BackingField;
                /*0x1a*/ bool <DoNotShowIfPlayRated>k__BackingField;

                /*0x400afd4*/ ScenarioSettings();
                /*0x400af78*/ Assets.GameUi.Externals.ScenarioTextSpeedTypes get_ScenarioTextSpeed();
                /*0x400af80*/ void set_ScenarioTextSpeed(Assets.GameUi.Externals.ScenarioTextSpeedTypes value);
                /*0x400af88*/ Assets.GameUi.Externals.ScenarioTextBackGroundAlphaTypes get_ScenarioBackgroundAlpha();
                /*0x400af90*/ void set_ScenarioBackgroundAlpha(Assets.GameUi.Externals.ScenarioTextBackGroundAlphaTypes value);
                /*0x400af98*/ bool get_ScenarioVoiceDownload();
                /*0x400afa0*/ void set_ScenarioVoiceDownload(bool value);
                /*0x400afac*/ bool get_DoNotShowVoiceDownload();
                /*0x400afb4*/ void set_DoNotShowVoiceDownload(bool value);
                /*0x400afc0*/ bool get_DoNotShowIfPlayRated();
                /*0x400afc8*/ void set_DoNotShowIfPlayRated(bool value);
            }

            class NotificationSettings
            {
                /*0x10*/ bool <NotificationActivityComplete>k__BackingField;
                /*0x11*/ bool <NotificationWorkCompleted>k__BackingField;
                /*0x12*/ bool <NotificationNotLogIn>k__BackingField;
                /*0x13*/ bool <NotificationDailyMissionNotCompleted>k__BackingField;
                /*0x14*/ bool <NotificationTimeSetting>k__BackingField;
                /*0x18*/ int <NotificationStartTime>k__BackingField;
                /*0x1c*/ int <NotificationEndTime>k__BackingField;

                /*0x400b070*/ NotificationSettings();
                /*0x400afec*/ bool get_NotificationActivityComplete();
                /*0x400aff4*/ void set_NotificationActivityComplete(bool value);
                /*0x400b000*/ bool get_NotificationWorkCompleted();
                /*0x400b008*/ void set_NotificationWorkCompleted(bool value);
                /*0x400b014*/ bool get_NotificationNotLogIn();
                /*0x400b01c*/ void set_NotificationNotLogIn(bool value);
                /*0x400b028*/ bool get_NotificationDailyMissionNotCompleted();
                /*0x400b030*/ void set_NotificationDailyMissionNotCompleted(bool value);
                /*0x400b03c*/ bool get_NotificationTimeSetting();
                /*0x400b044*/ void set_NotificationTimeSetting(bool value);
                /*0x400b050*/ int get_NotificationStartTime();
                /*0x400b058*/ void set_NotificationStartTime(int value);
                /*0x400b060*/ int get_NotificationEndTime();
                /*0x400b068*/ void set_NotificationEndTime(int value);
            }

            class SortFilterSettings
            {
                /*0x10*/ System.Collections.Generic.List<Assets.GameUi.Externals.SortFilterSettingsData> <SortFilterData>k__BackingField;

                /*0x400b098*/ SortFilterSettings();
                /*0x400b088*/ System.Collections.Generic.List<Assets.GameUi.Externals.SortFilterSettingsData> get_SortFilterData();
                /*0x400b090*/ void set_SortFilterData(System.Collections.Generic.List<Assets.GameUi.Externals.SortFilterSettingsData> value);
            }

            class QuestSettings
            {
                /*0x10*/ long <MainQuestLastPartyId>k__BackingField;

                /*0x400b130*/ QuestSettings();
                /*0x400b120*/ long get_MainQuestLastPartyId();
                /*0x400b128*/ void set_MainQuestLastPartyId(long value);
            }

            class SortFilterSettingsData
            {
                /*0x10*/ Assets.GameUi.Externals.SortFilterTypes <SortFilterType>k__BackingField;
                /*0x14*/ bool <FilterValid>k__BackingField;
                /*0x18*/ int <Sort>k__BackingField;
                /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.IEnumerable<int>> <Filter>k__BackingField;

                /*0x400b17c*/ SortFilterSettingsData();
                /*0x400b138*/ Assets.GameUi.Externals.SortFilterTypes get_SortFilterType();
                /*0x400b140*/ void set_SortFilterType(Assets.GameUi.Externals.SortFilterTypes value);
                /*0x400b148*/ bool get_FilterValid();
                /*0x400b150*/ void set_FilterValid(bool value);
                /*0x400b15c*/ int get_Sort();
                /*0x400b164*/ void set_Sort(int value);
                /*0x400b16c*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.IEnumerable<int>> get_Filter();
                /*0x400b174*/ void set_Filter(System.Collections.Generic.Dictionary<int, System.Collections.Generic.IEnumerable<int>> value);
            }

            class GachaSettings
            {
                /*0x10*/ System.Nullable<System.DateTime> <LastViewedAt>k__BackingField;

                /*0x400b218*/ GachaSettings();
                /*0x400b204*/ System.Nullable<System.DateTime> get_LastViewedAt();
                /*0x400b210*/ void set_LastViewedAt(System.Nullable<System.DateTime> value);
            }

            class ShopSettings
            {
                /*0x10*/ System.Nullable<System.DateTime> <LastViewedAt>k__BackingField;

                /*0x400b234*/ ShopSettings();
                /*0x400b220*/ System.Nullable<System.DateTime> get_LastViewedAt();
                /*0x400b22c*/ void set_LastViewedAt(System.Nullable<System.DateTime> value);
            }

            class ChatSettings
            {
                /*0x10*/ System.Collections.Generic.List<string> <NewChatMessageSenderCodes>k__BackingField;

                /*0x400b24c*/ ChatSettings();
                /*0x400b23c*/ System.Collections.Generic.List<string> get_NewChatMessageSenderCodes();
                /*0x400b244*/ void set_NewChatMessageSenderCodes(System.Collections.Generic.List<string> value);
            }

            class LocalSettings
            {
                /*0x10*/ Assets.GameUi.Externals.LegalSettings <Legal>k__BackingField;
                /*0x18*/ Assets.GameUi.Externals.SystemSettings <System>k__BackingField;
                /*0x20*/ Assets.GameUi.Externals.SoundSettings <Sound>k__BackingField;
                /*0x28*/ Assets.GameUi.Externals.ScenarioSettings <Scenario>k__BackingField;
                /*0x30*/ Assets.GameUi.Externals.NotificationSettings <Notification>k__BackingField;
                /*0x38*/ Assets.GameUi.Externals.SortFilterSettings <SortFilter>k__BackingField;
                /*0x40*/ Assets.GameUi.Externals.QuestSettings <Quest>k__BackingField;
                /*0x48*/ Assets.GameUi.Externals.GachaSettings <Gacha>k__BackingField;
                /*0x50*/ Assets.GameUi.Externals.ShopSettings <Shop>k__BackingField;
                /*0x58*/ Assets.GameUi.Externals.PerformanceFlags <DoNotPerformanceFlags>k__BackingField;
                /*0x60*/ Assets.GameUi.Externals.ChatSettings <Chat>k__BackingField;
                /*0x68*/ Assets.GameUi.Externals.AssetDownloadSetting <AssetDownload>k__BackingField;
                /*0x70*/ Assets.GameUi.Externals.DebugSettings <DebugSettings>k__BackingField;

                /*0x400aa5c*/ LocalSettings();
                /*0x400b2d4*/ Assets.GameUi.Externals.LegalSettings get_Legal();
                /*0x400b2dc*/ void set_Legal(Assets.GameUi.Externals.LegalSettings value);
                /*0x400b2e4*/ Assets.GameUi.Externals.SystemSettings get_System();
                /*0x400b2ec*/ void set_System(Assets.GameUi.Externals.SystemSettings value);
                /*0x400b2f4*/ Assets.GameUi.Externals.SoundSettings get_Sound();
                /*0x400b2fc*/ void set_Sound(Assets.GameUi.Externals.SoundSettings value);
                /*0x400b304*/ Assets.GameUi.Externals.ScenarioSettings get_Scenario();
                /*0x400b30c*/ void set_Scenario(Assets.GameUi.Externals.ScenarioSettings value);
                /*0x400b314*/ Assets.GameUi.Externals.NotificationSettings get_Notification();
                /*0x400b31c*/ void set_Notification(Assets.GameUi.Externals.NotificationSettings value);
                /*0x400b324*/ Assets.GameUi.Externals.SortFilterSettings get_SortFilter();
                /*0x400b32c*/ void set_SortFilter(Assets.GameUi.Externals.SortFilterSettings value);
                /*0x400b334*/ Assets.GameUi.Externals.QuestSettings get_Quest();
                /*0x400b33c*/ void set_Quest(Assets.GameUi.Externals.QuestSettings value);
                /*0x400b344*/ Assets.GameUi.Externals.GachaSettings get_Gacha();
                /*0x400b34c*/ void set_Gacha(Assets.GameUi.Externals.GachaSettings value);
                /*0x400b354*/ Assets.GameUi.Externals.ShopSettings get_Shop();
                /*0x400b35c*/ void set_Shop(Assets.GameUi.Externals.ShopSettings value);
                /*0x400b364*/ Assets.GameUi.Externals.PerformanceFlags get_DoNotPerformanceFlags();
                /*0x400b36c*/ void set_DoNotPerformanceFlags(Assets.GameUi.Externals.PerformanceFlags value);
                /*0x400b374*/ Assets.GameUi.Externals.ChatSettings get_Chat();
                /*0x400b37c*/ void set_Chat(Assets.GameUi.Externals.ChatSettings value);
                /*0x400b384*/ Assets.GameUi.Externals.AssetDownloadSetting get_AssetDownload();
                /*0x400b38c*/ void set_AssetDownload(Assets.GameUi.Externals.AssetDownloadSetting value);
                /*0x400b394*/ Assets.GameUi.Externals.DebugSettings get_DebugSettings();
                /*0x400b39c*/ void set_DebugSettings(Assets.GameUi.Externals.DebugSettings value);
            }

            class DebugSettings
            {
                /*0x10*/ string <Magic>k__BackingField;

                /*0x400b3a4*/ DebugSettings();
                /*0x400b3d8*/ string get_Magic();
                /*0x400b3e0*/ void set_Magic(string value);
            }

            enum SortFilterTypes
            {
                None = 0,
                Character = 1,
                CharacterBase = 2,
                CharacterSsrIllustration = 3,
                CharacterEpisode = 4,
                MemoryEpisode = 5,
                Memory = 6,
                CharacterOrganization = 7,
                MemoryOrganization = 8,
            }

            enum ScenarioTextSpeedTypes
            {
                None = 0,
                Slow = 1,
                Normal = 2,
                Fast = 3,
                Immediately = 4,
            }

            enum ScenarioTextBackGroundAlphaTypes
            {
                None = 0,
                Pale = 1,
                Normal = 2,
                Deep = 3,
            }

            enum PerformanceFlags
            {
                None = 0,
                LevelLinkAmplification = 1,
            }

            class SceneManager : Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager
            {
                /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
                /*0x18*/ Assets.GameUi.Externals.IUiLayoutManager layoutManager;

                /*0x400b3e8*/ SceneManager(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.GameUi.Externals.IUiLayoutManager layoutManager);
                /*0x400b42c*/ Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> MoveToSceneAcync(string key);

                struct <MoveToSceneAcync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.SceneManager <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>u__1;

                    /*0x400b544*/ void MoveNext();
                    /*0x400bb58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            namespace Utilities
            {
                class SafeAreaConstraint : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ UnityEngine.Canvas <Canvas>k__BackingField;

                    /*0x400be0c*/ SafeAreaConstraint();
                    /*0x400bbb0*/ UnityEngine.Canvas get_Canvas();
                    /*0x400bbb8*/ void set_Canvas(UnityEngine.Canvas value);
                    /*0x400bbc0*/ void Start();
                    /*0x400a6e8*/ void Constrain();
                    /*0x400bbec*/ void ConstrainForWorldSpaceCanvas(UnityEngine.Canvas canvas);
                    /*0x400bbc4*/ bool IsWorldSpace(UnityEngine.Canvas canvas);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 71ABB6640C5C9919E607796B3DB4330F53C878075FEFE46AE7440E405371EF59;
    static /*0x721*/ <PrivateImplementationDetails> 8EB126B375CB373416788363E8499E6FFAF7DE91FAA88C6A5358136D923D873F;

    struct __StaticArrayInitTypeSize=484
    {
    }

    struct __StaticArrayInitTypeSize=1825
    {
    }
}
