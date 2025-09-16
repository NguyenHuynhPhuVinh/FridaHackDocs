class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3ff90c4*/ EmbeddedAttribute();
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

                /*0x3ff90cc*/ NullableAttribute(byte );
                /*0x3ff9154*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3ff9184*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3ff91ac*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3ff92a0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
                /*0x3813ffc*/ bool get_EnableVoiceSampler();
                /*0x3815cc4*/ void set_EnableVoiceSampler(bool value);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayVoice(string key, UnityEngine.AudioSource audioSource, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayVoice(string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource[]> PlayVoices(string[] keys);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayBackgroundVoice(string key);
                Cysharp.Threading.Tasks.UniTask PlayBackgroundVoice(string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string key);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>[]> StartSyncVoices(string[] keys);
                /*0x38159dc*/ void StopBgm();
                /*0x38159dc*/ void StopVoice();
                /*0x38159dc*/ void StopBackgroundVoice();
                Cysharp.Threading.Tasks.UniTask PlayBgm(Assets.GameUi.Externals.AudioManager.BgmArgs args);
                System.Nullable<int> GetCurrentBgmTimeSamples(bool correctFrequency);
                Cysharp.Threading.Tasks.UniTask PlaySe(string key);
                /*0x3815ed0*/ void SetVoiceChannelVolume(int percentage);
                /*0x3815ed0*/ void SetBgmChannelVolume(int percentage);
                /*0x3815ed0*/ void SetSeChannelVolume(int percentage);
                /*0x3815ed0*/ void SetBackgroundVoiceChannelVolume(int percentage);
                /*0x3816710*/ void PlaySe(UnityEngine.AudioClip clip);
                Cysharp.Threading.Tasks.UniTask StopSe(string key);
                /*0x38159dc*/ void StopSe();
                /*0x38159dc*/ void PauseBgm();
                /*0x38159dc*/ void ResumeBgm();
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, string key);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, string key, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask PlaySystemVoice(string assetId, System.Threading.CancellationToken token);
                Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncSystemVoice(string assetId);
                Cysharp.Threading.Tasks.UniTask WaitUntilPlaybackStarts(UnityEngine.AudioSource source);
                Cysharp.Threading.Tasks.UniTask WaitWhilePlaying(UnityEngine.AudioSource source);
                /*0x38141c4*/ bool AlreadyVoicePlaying(string assetId);
                /*0x3813ffc*/ bool IsVoicePlaying();
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

                static /*0x3ffd614*/ AudioManager();
                static /*0x3ffceb0*/ void Resume(UnityEngine.AudioSource source);
                static /*0x3ffd19c*/ float PercentageToDecibel(int percentage);
                /*0x3ffd58c*/ AudioManager();
                /*0x3ff92a8*/ Assets.AssetManagement.IAddressablesAssetProvider get_AssetProvider();
                /*0x3ff92b0*/ void set_AssetProvider(Assets.AssetManagement.IAddressablesAssetProvider value);
                /*0x3ff92b8*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3ff92c0*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3ff92c8*/ Assets.GameUi.Externals.ILocalSettingsManager get_LocalSettings();
                /*0x3ff92d0*/ void set_LocalSettings(Assets.GameUi.Externals.ILocalSettingsManager value);
                /*0x3ff92d8*/ Assets.GameUi.Externals.ICustomAudioSampler get_AudioSampler();
                /*0x3ff92e0*/ void set_AudioSampler(Assets.GameUi.Externals.ICustomAudioSampler value);
                /*0x3ff92e8*/ UniRx.ReactiveProperty<System.ValueTuple<string, float>[]> get_VoiceVolumes();
                /*0x3ff92f0*/ bool get_EnableVoiceSampler();
                /*0x3ff92f8*/ void set_EnableVoiceSampler(bool value);
                /*0x3ff9304*/ void Start();
                /*0x3ff9e6c*/ void Update();
                /*0x3ffa140*/ void OnDestroy();
                /*0x3ffa4a4*/ UnityEngine.AudioSource AcquireBgmSource();
                /*0x3ffa79c*/ UnityEngine.AudioSource AcquireBgmVoiceSource();
                /*0x3ffa7f8*/ UnityEngine.AudioSource AcquireSeSource();
                /*0x3ffa8bc*/ UnityEngine.AudioSource AcquireVoiceSource();
                /*0x3ffa980*/ Cysharp.Threading.Tasks.UniTask PlayBgm(Assets.GameUi.Externals.AudioManager.BgmArgs args);
                /*0x3ffaa4c*/ System.Nullable<int> GetCurrentBgmTimeSamples(bool correctFrequency);
                /*0x3ffac30*/ Cysharp.Threading.Tasks.UniTask PlaySe(string key);
                /*0x3ffacfc*/ void PlaySe(UnityEngine.AudioClip clip);
                /*0x3ffade4*/ Cysharp.Threading.Tasks.UniTask StopSe(string key);
                /*0x3ffaeb4*/ void StopSe();
                /*0x3ffb028*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayVoice(string key, UnityEngine.AudioSource audioSource, System.Threading.CancellationToken token);
                /*0x3ffb178*/ Cysharp.Threading.Tasks.UniTask PlayVoice(string key, System.Threading.CancellationToken token);
                /*0x3ffb25c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource[]> PlayVoices(string[] keys);
                /*0x3ffb6a0*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3ffb7e4*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3ffb8fc*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3ffba14*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3ffbb2c*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterAssetId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type, System.Threading.CancellationToken token);
                /*0x3ffbc44*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(string characterId, string key, System.Threading.CancellationToken token);
                /*0x3ffbd14*/ Cysharp.Threading.Tasks.UniTask PlayCharacterVoice(long characterId, string key, System.Threading.CancellationToken token);
                /*0x3ffbde4*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterBattleVoiceTypes type);
                /*0x3ffc030*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterMiscellaneousVoiceTypes type);
                /*0x3ffc158*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                /*0x3ffc280*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string characterId, Assets.GameUi.Externals.CharacterSystemVoiceTypes type);
                /*0x3ffc3a8*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(long characterId, string key);
                /*0x3ffc498*/ Cysharp.Threading.Tasks.UniTask PlaySystemVoice(string assetId, System.Threading.CancellationToken token);
                /*0x3ffc560*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncSystemVoice(string assetId);
                /*0x3ffc644*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.AudioSource> PlayBackgroundVoice(string key);
                /*0x3ffc75c*/ Cysharp.Threading.Tasks.UniTask PlayBackgroundVoice(string key, System.Threading.CancellationToken token);
                /*0x3ffbf0c*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>> StartSyncVoice(string key);
                /*0x3ffc854*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.AudioSource, UniRx.ReactiveProperty<float>, bool>[]> StartSyncVoices(string[] keys);
                /*0x3ffc970*/ UnityEngine.Audio.AudioMixerGroup get_VoiceMixerGroup();
                /*0x3ffc9f0*/ void StopBgm();
                /*0x3ffcb94*/ void PauseBgm();
                /*0x3ffcd20*/ void ResumeBgm();
                /*0x3ffb4ac*/ void StopVoice();
                /*0x3ffcec4*/ void StopBackgroundVoice();
                /*0x3ffd028*/ void Crossfade(UnityEngine.AudioSource active, UnityEngine.AudioSource target, float duration);
                /*0x3ffad18*/ void Play(UnityEngine.AudioClip clip, UnityEngine.AudioSource source);
                /*0x3ffcb54*/ void Stop(UnityEngine.AudioSource source);
                /*0x3ffcd08*/ void Pause(UnityEngine.AudioSource source);
                /*0x3ffa500*/ UnityEngine.AudioSource AcquireAudioSource(System.Collections.Generic.List<UnityEngine.AudioSource> list, System.Nullable<int> index);
                /*0x3ff992c*/ void SetVoiceChannelVolume(int percentage);
                /*0x3ff9bcc*/ void SetBgmChannelVolume(int percentage);
                /*0x3ff9d34*/ void SetSeChannelVolume(int percentage);
                /*0x3ff9a64*/ void SetBackgroundVoiceChannelVolume(int percentage);
                /*0x3ffa124*/ int CorrectFrequency(long frequency, long n, bool reverse);
                /*0x3ffd1f4*/ bool AlreadyVoicePlaying(string assetId);
                /*0x3ffd30c*/ Cysharp.Threading.Tasks.UniTask WaitUntilPlaybackStarts(UnityEngine.AudioSource source);
                /*0x3ffd3b8*/ Cysharp.Threading.Tasks.UniTask WaitWhilePlaying(UnityEngine.AudioSource source);
                /*0x3ffd464*/ bool IsVoicePlaying();

                class BgmArgs
                {
                    /*0x10*/ string <AssetId>k__BackingField;
                    /*0x18*/ System.Nullable<int> <LoopStartSampleCounts>k__BackingField;
                    /*0x20*/ System.Nullable<int> <LoopEndSampleCounts>k__BackingField;
                    /*0x28*/ System.Nullable<int> <StartSampleCounts>k__BackingField;

                    /*0x3ffd764*/ BgmArgs();
                    /*0x3ffd724*/ string get_AssetId();
                    /*0x3ffd72c*/ void set_AssetId(string value);
                    /*0x3ffd734*/ System.Nullable<int> get_LoopStartSampleCounts();
                    /*0x3ffd73c*/ void set_LoopStartSampleCounts(System.Nullable<int> value);
                    /*0x3ffd744*/ System.Nullable<int> get_LoopEndSampleCounts();
                    /*0x3ffd74c*/ void set_LoopEndSampleCounts(System.Nullable<int> value);
                    /*0x3ffd754*/ System.Nullable<int> get_StartSampleCounts();
                    /*0x3ffd75c*/ void set_StartSampleCounts(System.Nullable<int> value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.GameUi.Externals.AudioManager.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.AudioSource, bool> <>9__74_0;
                    static /*0x10*/ System.Func<UnityEngine.AudioSource, bool> <>9__87_0;
                    static /*0x18*/ System.Func<UnityEngine.AudioSource, bool> <>9__87_1;
                    static /*0x20*/ System.Func<UnityEngine.AudioSource, bool> <>9__97_0;

                    static /*0x3ffd798*/ <>c();
                    /*0x3ffd800*/ <>c();
                    /*0x3ffd808*/ bool <StartSyncVoices>b__74_0(UnityEngine.AudioSource source);
                    /*0x3ffd880*/ bool <AcquireAudioSource>b__87_0(UnityEngine.AudioSource s);
                    /*0x3ffd908*/ bool <AcquireAudioSource>b__87_1(UnityEngine.AudioSource s);
                    /*0x3ffd990*/ bool <IsVoicePlaying>b__97_0(UnityEngine.AudioSource v);
                }

                class <>c__DisplayClass52_0
                {
                    /*0x10*/ UnityEngine.AudioClip clip;

                    /*0x3ffd9a8*/ <>c__DisplayClass52_0();
                    /*0x3ffd9b0*/ bool <StopSe>b__0(UnityEngine.AudioSource s);
                }

                class <>c__DisplayClass72_0
                {
                    /*0x10*/ UnityEngine.AudioSource source;

                    /*0x3ffda30*/ <>c__DisplayClass72_0();
                    /*0x3ffda38*/ void <PlayBackgroundVoice>b__0();
                }

                class <>c__DisplayClass82_0
                {
                    /*0x10*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x18*/ UnityEngine.AudioSource active;

                    /*0x3ffd194*/ <>c__DisplayClass82_0();
                    /*0x3ffda54*/ void <Crossfade>b__0();
                }

                class <>c__DisplayClass94_0
                {
                    /*0x10*/ string assetId;

                    /*0x3ffd304*/ <>c__DisplayClass94_0();
                    /*0x3ffda70*/ bool <AlreadyVoicePlaying>b__0(UnityEngine.AudioSource source);
                }

                class <>c__DisplayClass95_0
                {
                    /*0x10*/ UnityEngine.AudioSource source;

                    /*0x3ffdb38*/ <>c__DisplayClass95_0();
                    /*0x3ffdb40*/ bool <WaitUntilPlaybackStarts>b__0();
                }

                class <>c__DisplayClass96_0
                {
                    /*0x10*/ UnityEngine.AudioSource source;
                    /*0x18*/ float timeout;

                    /*0x3ffdc04*/ <>c__DisplayClass96_0();
                    /*0x3ffdc0c*/ bool <WaitWhilePlaying>b__0();
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

                    /*0x3ffdce4*/ void MoveNext();
                    /*0x3ffe5a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3ffe600*/ void MoveNext();
                    /*0x3ffee9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlayBgm>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager.BgmArgs args;
                    /*0x30*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;

                    /*0x3ffeea8*/ void MoveNext();
                    /*0x3fff76c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlaySe>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;

                    /*0x3fff778*/ void MoveNext();
                    /*0x3fffcf4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3fffd00*/ void MoveNext();
                    /*0x40005ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x4000604*/ void MoveNext();
                    /*0x4000dfc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x4000e08*/ void MoveNext();
                    /*0x40016c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400171c*/ void MoveNext();
                    /*0x40023a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <StopSe>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.AudioManager <>4__this;
                    /*0x30*/ string key;
                    /*0x38*/ Assets.GameUi.Externals.AudioManager.<> <>8__1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.AudioClip> <>u__1;

                    /*0x4002400*/ void MoveNext();
                    /*0x4002adc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WaitUntilPlaybackStarts>d__95 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.AudioSource source;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x4002ae8*/ void MoveNext();
                    /*0x4002f88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <WaitWhilePlaying>d__96 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.AudioSource source;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x4002f94*/ void MoveNext();
                    /*0x4003544*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICustomAudioSampler
            {
                Cysharp.Threading.Tasks.UniTask<bool> StartSync(UnityEngine.AudioSource audioSource);
                /*0x3816710*/ void StopSync(UnityEngine.AudioSource audioSource);
                /*0x38159dc*/ void Update();
                /*0x3814a3c*/ UniRx.ReactiveProperty<float> GetVolume(UnityEngine.AudioSource audioSource);
            }

            class CustomAudioSampler : Assets.GameUi.Externals.ICustomAudioSampler
            {
                static int SAMPLE_SIZE = 512;
                /*0x10*/ float[] samples;
                /*0x18*/ Assets.Plugins.WebGl.IJSInterop jSInterop;
                /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.AudioSource, Assets.GameUi.Externals.CustomAudioSampler.VoiceSample> voiceSamples;
                /*0x28*/ UniRx.ReactiveProperty<float> <Volume>k__BackingField;

                /*0x4003558*/ CustomAudioSampler(Assets.Plugins.WebGl.IJSInterop jSInterop);
                /*0x4003550*/ UniRx.ReactiveProperty<float> get_Volume();
                /*0x4003680*/ Cysharp.Threading.Tasks.UniTask<bool> StartSync(UnityEngine.AudioSource audioSource);
                /*0x4003774*/ void StopSync(UnityEngine.AudioSource audioSource);
                /*0x4003970*/ void Update();
                /*0x4003d14*/ UniRx.ReactiveProperty<float> GetVolume(UnityEngine.AudioSource audioSource);

                class VoiceSample
                {
                    /*0x10*/ float[] samples;
                    /*0x18*/ Assets.Plugins.WebGl.IJSInterop jSInterop;
                    /*0x20*/ UnityEngine.AudioSource audioSource;
                    /*0x28*/ UniRx.ReactiveProperty<float> <Volume>k__BackingField;

                    /*0x4003da0*/ VoiceSample(Assets.Plugins.WebGl.IJSInterop jSInterop, UnityEngine.AudioSource audioSource);
                    /*0x4003d98*/ UniRx.ReactiveProperty<float> get_Volume();
                    /*0x4003e88*/ Cysharp.Threading.Tasks.UniTask<bool> StartSync();
                    /*0x4003818*/ void StopSync();
                    /*0x4003ad8*/ void Update();

                    class <>c
                    {
                        static /*0x0*/ Assets.GameUi.Externals.CustomAudioSampler.VoiceSample.<> <>9;
                        static /*0x8*/ System.Func<float, float> <>9__9_0;

                        static /*0x4003f64*/ <>c();
                        /*0x4003fcc*/ <>c();
                        /*0x4003fd4*/ float <Update>b__9_0(float s);
                    }

                    struct <StartSync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                        /*0x30*/ Assets.GameUi.Externals.CustomAudioSampler.VoiceSample <>4__this;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x4003fdc*/ void MoveNext();
                        /*0x4004620*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                struct <StartSync>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.CustomAudioSampler <>4__this;
                    /*0x38*/ UnityEngine.AudioSource audioSource;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x4004678*/ void MoveNext();
                    /*0x4004bd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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
                /*0x3816f24*/ void Blur(float duration);
                Cysharp.Threading.Tasks.UniTask Zoom(Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x3815cc4*/ void SetActive(bool active);
                /*0x38148bc*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> get_SpeechBubblePoints();
                System.ValueTuple<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>[], float> get_LocatorPoints();
                System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> GetSpineTapPosition(ref System.Nullable<UnityEngine.Vector2> mousePosition);
                /*0x381385c*/ System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> get_SpineTapPosition();
                /*0x38148bc*/ System.Collections.Generic.Dictionary<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes, System.ValueTuple<UnityEngine.Vector3, float>> get_SpineTapBoneScreenPositions();
                /*0x38148bc*/ Assets.GameUi.Externals.BackgroundManagerArgs get_Args();
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

                static /*0x400515c*/ string BuiltInBackgroundTypeToAssetId(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes type);
                static /*0x4007748*/ Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection <GetSpeechBubblePoints>g__GetDirectionFrom|60_1(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
                /*0x40079f8*/ BackgroundManager();
                /*0x4004c30*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x4004c38*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x4004c40*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                /*0x4004c48*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x4004c50*/ Assets.AssetManagement.ISpineAssetProvider get_SpineAssetProvider();
                /*0x4004c58*/ void set_SpineAssetProvider(Assets.AssetManagement.ISpineAssetProvider value);
                /*0x4004c60*/ Assets.AssetManagement.IDirectAssetProvider get_DirectAssetProvider();
                /*0x4004c68*/ void set_DirectAssetProvider(Assets.AssetManagement.IDirectAssetProvider value);
                /*0x4004c70*/ Assets.AssetManagement.IAssetInstanceProvider get_AssetInstanceProvider();
                /*0x4004c78*/ void set_AssetInstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                /*0x4004c80*/ Assets.GameUi.Externals.BackgroundManagerArgs get_Args();
                /*0x4004c88*/ void set_Args(Assets.GameUi.Externals.BackgroundManagerArgs value);
                /*0x4004c90*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes type, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x40052f8*/ Cysharp.Threading.Tasks.UniTask TransitionTo(string key, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Nullable<UnityEngine.Color> color);
                /*0x4005420*/ Cysharp.Threading.Tasks.UniTask TransitionToEmpty(UnityEngine.Color color, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x4005758*/ Cysharp.Threading.Tasks.UniTask TransitionToDirectAssetTexture(string key, float duration, DG.Tweening.Ease ease);
                /*0x4005840*/ Cysharp.Threading.Tasks.UniTask TransitionToFunctinalImage(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type, string key, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x4005948*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Video.VideoPlayer> TransitionToVideo(string key, bool loop, float duration, DG.Tweening.Ease ease);
                /*0x4005a90*/ Cysharp.Threading.Tasks.UniTask TransitionToBackgroundSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed);
                /*0x4005d54*/ Cysharp.Threading.Tasks.UniTask TransitionToAdventureSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed);
                /*0x4005ee8*/ Cysharp.Threading.Tasks.UniTask TransitionToExtraSkillSpine(string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Action onEndAction);
                /*0x4006098*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.BackgroundManagerArgs args);
                /*0x4006168*/ void Blur(float duration);
                /*0x4006280*/ Cysharp.Threading.Tasks.UniTask Zoom(Assets.GameUi.Externals.BackgroundManager.ZoomArgs args);
                /*0x4006384*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> get_SpeechBubblePoints();
                /*0x4006750*/ System.ValueTuple<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>[], float> get_LocatorPoints();
                /*0x4006804*/ System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> GetSpineTapPosition(ref System.Nullable<UnityEngine.Vector2> mousePosition);
                /*0x40071c0*/ System.Nullable<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes> get_SpineTapPosition();
                /*0x40071e4*/ System.Collections.Generic.Dictionary<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes, System.ValueTuple<UnityEngine.Vector3, float>> get_SpineTapBoneScreenPositions();
                /*0x4005054*/ Cysharp.Threading.Tasks.UniTask TransitionTo(UnityEngine.Texture2D texture, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom);
                /*0x4005618*/ Cysharp.Threading.Tasks.UniTask TransitionToTexture(UnityEngine.Texture2D texture, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Nullable<UnityEngine.Color> color, System.Threading.CancellationToken cancellationToken);
                /*0x4005c24*/ Cysharp.Threading.Tasks.UniTask TransitionToSpine(Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes type, string assetId, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Action onEndAction);
                /*0x40071e8*/ Cysharp.Threading.Tasks.UniTask TransitionToFunctinalImage(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes type, string assetId, float duration, DG.Tweening.Ease ease, Assets.GameUi.Externals.BackgroundManager.ZoomArgs zoom, System.Threading.CancellationToken cancellationToken);
                /*0x4004f74*/ Cysharp.Threading.Tasks.UniTask TransitionToBeDisabled(float duration, DG.Tweening.Ease ease, System.Threading.CancellationToken cancellationToken);
                /*0x4007314*/ Cysharp.Threading.Tasks.UniTask Transition(float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Threading.CancellationToken cancellationToken, System.Action onEndAction);
                /*0x4007444*/ Cysharp.Threading.Tasks.UniTask TransitionIn(Assets.GameUi.Externals.BackgroundPanel panel, float duration, DG.Tweening.Ease ease, System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> trigger, bool waitForLoop, float animationSpeed, System.Threading.CancellationToken token, System.Action onEndAction);
                /*0x400756c*/ Cysharp.Threading.Tasks.UniTask TransitionOut(Assets.GameUi.Externals.BackgroundPanel panel, float duration, DG.Tweening.Ease ease, System.Threading.CancellationToken token);
                /*0x4004ef0*/ System.Threading.CancellationToken ResetToken();
                /*0x400764c*/ void OnDisable();
                /*0x4007720*/ void SetActive(bool active);
                /*0x4006388*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> GetSpeechBubblePoints();
                /*0x4006754*/ System.ValueTuple<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>[], float> GetLocatorPoinsts();
                /*0x4007780*/ System.Collections.Generic.IEnumerable<System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3>> GetTransformedLocatorPoints();
                /*0x4007130*/ bool IsPositionInsideCircle(UnityEngine.Vector2 potion, UnityEngine.Vector2 centerPosition, float radius);
                /*0x4006bcc*/ System.Collections.Generic.Dictionary<Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes, System.ValueTuple<UnityEngine.Vector3, float>> GetSpineTapBonePositions();
                /*0x4007ad0*/ bool <TransitionToSpine>b__51_0();

                class MoveArgs
                {
                    /*0x10*/ DG.Tweening.PathType <PathType>k__BackingField;
                    /*0x18*/ UnityEngine.Vector3[] <Paths>k__BackingField;
                    /*0x20*/ float <Duration>k__BackingField;
                    /*0x24*/ DG.Tweening.Ease <Ease>k__BackingField;

                    /*0x4007c7c*/ MoveArgs();
                    /*0x4007c3c*/ DG.Tweening.PathType get_PathType();
                    /*0x4007c44*/ void set_PathType(DG.Tweening.PathType value);
                    /*0x4007c4c*/ UnityEngine.Vector3[] get_Paths();
                    /*0x4007c54*/ void set_Paths(UnityEngine.Vector3[] value);
                    /*0x4007c5c*/ float get_Duration();
                    /*0x4007c64*/ void set_Duration(float value);
                    /*0x4007c6c*/ DG.Tweening.Ease get_Ease();
                    /*0x4007c74*/ void set_Ease(DG.Tweening.Ease value);
                }

                class ScaleArgs
                {
                    /*0x10*/ float <Scale>k__BackingField;
                    /*0x14*/ float <Duration>k__BackingField;
                    /*0x18*/ DG.Tweening.Ease <Ease>k__BackingField;

                    /*0x4007d10*/ ScaleArgs();
                    /*0x4007ce0*/ float get_Scale();
                    /*0x4007ce8*/ void set_Scale(float value);
                    /*0x4007cf0*/ float get_Duration();
                    /*0x4007cf8*/ void set_Duration(float value);
                    /*0x4007d00*/ DG.Tweening.Ease get_Ease();
                    /*0x4007d08*/ void set_Ease(DG.Tweening.Ease value);
                }

                class ZoomArgs
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundManager.MoveArgs <MoveArgs>k__BackingField;
                    /*0x18*/ Assets.GameUi.Externals.BackgroundManager.ScaleArgs <ScaleArgs>k__BackingField;
                    /*0x20*/ Assets.GameUi.Externals.BackgroundManager.ShakeArgs <ShakeArgs>k__BackingField;

                    /*0x4007d84*/ ZoomArgs();
                    /*0x4007d18*/ Assets.GameUi.Externals.BackgroundManager.MoveArgs get_MoveArgs();
                    /*0x4007d20*/ void set_MoveArgs(Assets.GameUi.Externals.BackgroundManager.MoveArgs value);
                    /*0x4007d28*/ Assets.GameUi.Externals.BackgroundManager.ScaleArgs get_ScaleArgs();
                    /*0x4007d30*/ void set_ScaleArgs(Assets.GameUi.Externals.BackgroundManager.ScaleArgs value);
                    /*0x4007d38*/ Assets.GameUi.Externals.BackgroundManager.ShakeArgs get_ShakeArgs();
                    /*0x4007d40*/ void set_ShakeArgs(Assets.GameUi.Externals.BackgroundManager.ShakeArgs value);
                    /*0x4007d48*/ bool get_HasDuration();
                }

                class ShakeArgs
                {
                    /*0x10*/ float <Strength>k__BackingField;
                    /*0x14*/ UnityEngine.Animations.Axis <AxisFlags>k__BackingField;
                    /*0x18*/ bool <Once>k__BackingField;

                    /*0x4007dc0*/ ShakeArgs();
                    /*0x4007d8c*/ float get_Strength();
                    /*0x4007d94*/ void set_Strength(float value);
                    /*0x4007d9c*/ UnityEngine.Animations.Axis get_AxisFlags();
                    /*0x4007da4*/ void set_AxisFlags(UnityEngine.Animations.Axis value);
                    /*0x4007dac*/ bool get_Once();
                    /*0x4007db4*/ void set_Once(bool value);
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

                    static /*0x4007dc8*/ <>c();
                    /*0x4007e30*/ <>c();
                    /*0x4007e38*/ System.ValueTuple<UnityEngine.Vector3, Assets.GameUi.Externals.BackgroundManager.SpeechBubbleDirection> <GetSpeechBubblePoints>b__60_0(System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3> locatorPoint);
                }

                class <>c__DisplayClass55_0
                {
                    /*0x10*/ System.Action onEndAction;
                    /*0x18*/ Assets.GameUi.Externals.BackgroundPanel panel;

                    /*0x4007ed4*/ <>c__DisplayClass55_0();
                    /*0x4007edc*/ void <TransitionIn>b__1(string value);
                    /*0x4007f00*/ bool <TransitionIn>b__0();
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ UnityEngine.Transform transform;

                    /*0x4007920*/ <>c__DisplayClass62_0();
                    /*0x400805c*/ System.ValueTuple<long, UnityEngine.Vector3, UnityEngine.Vector3> <GetTransformedLocatorPoints>b__0(Assets.Utilities.FunctionalImage.BackgroundComponent.LocatorPoint p);
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

                    /*0x4008130*/ void MoveNext();
                    /*0x4008da4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x4008db0*/ void MoveNext();
                    /*0x4009dd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x4009de4*/ void MoveNext();
                    /*0x400aa20*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400aa2c*/ void MoveNext();
                    /*0x400b2d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionTo>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.GameUi.Externals.BackgroundManagerArgs args;
                    /*0x30*/ Assets.GameUi.Externals.BackgroundManager <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Video.VideoPlayer> <>u__2;

                    /*0x400b2e0*/ void MoveNext();
                    /*0x400cac8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400cad4*/ void MoveNext();
                    /*0x400cf24*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400cf30*/ void MoveNext();
                    /*0x400d3d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400d3dc*/ void MoveNext();
                    /*0x400dc58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400dc64*/ void MoveNext();
                    /*0x400e1ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400e1b8*/ void MoveNext();
                    /*0x400f07c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x400f088*/ void MoveNext();
                    /*0x401046c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x4010478*/ void MoveNext();
                    /*0x4011348*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x4011354*/ void MoveNext();
                    /*0x4011d30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x4004ebc*/ BackgroundManagerArgs();
                /*0x4011d88*/ Assets.GameUi.Externals.BackgroundTypes get_Type();
                /*0x4011d90*/ void set_Type(Assets.GameUi.Externals.BackgroundTypes value);
                /*0x4011d98*/ Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes get_BuiltInType();
                /*0x4011da0*/ void set_BuiltInType(Assets.GameUi.Externals.BackgroundManager.BuiltInBackgroundTypes value);
                /*0x4011da8*/ string get_Key();
                /*0x4011db0*/ void set_Key(string value);
                /*0x4011db8*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes get_FunctionalType();
                /*0x4011dc0*/ void set_FunctionalType(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes value);
                /*0x4011dc8*/ System.Nullable<UnityEngine.Color> get_Color();
                /*0x4011ddc*/ void set_Color(System.Nullable<UnityEngine.Color> value);
                /*0x4011df0*/ System.Nullable<float> get_Duration();
                /*0x4011df8*/ void set_Duration(System.Nullable<float> value);
                /*0x4011e00*/ System.Nullable<DG.Tweening.Ease> get_Ease();
                /*0x4011e08*/ void set_Ease(System.Nullable<DG.Tweening.Ease> value);
                /*0x4011e10*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs get_ZoomArgs();
                /*0x4011e18*/ void set_ZoomArgs(Assets.GameUi.Externals.BackgroundManager.ZoomArgs value);
                /*0x4011e20*/ System.Nullable<bool> get_Loop();
                /*0x4011e28*/ void set_Loop(System.Nullable<bool> value);
                /*0x4011e30*/ System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> get_Trigger();
                /*0x4011e38*/ void set_Trigger(System.Nullable<Assets.Utilities.Spine.MecanimController.Triggers> value);
                /*0x4011e40*/ bool get_WaitForLoop();
                /*0x4011e48*/ void set_WaitForLoop(bool value);
                /*0x4011e54*/ System.Nullable<float> get_AnimationSpeed();
                /*0x4011e5c*/ void set_AnimationSpeed(System.Nullable<float> value);
                /*0x4011e64*/ System.Action get_OnEndAction();
                /*0x4011e6c*/ void set_OnEndAction(System.Action value);
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

                /*0x4011edc*/ BackgroundPanel();
                /*0x4011e74*/ UnityEngine.UI.RawImage get_Image();
                /*0x4011e7c*/ void set_Image(UnityEngine.UI.RawImage value);
                /*0x4011e84*/ UnityEngine.Video.VideoPlayer get_VideoPlayer();
                /*0x4011e8c*/ void set_VideoPlayer(UnityEngine.Video.VideoPlayer value);
                /*0x4011e94*/ Assets.GameUi.Externals.BackgroundManager.TransitionTypes get_TransitionType();
                /*0x4011e9c*/ void set_TransitionType(Assets.GameUi.Externals.BackgroundManager.TransitionTypes value);
                /*0x4011ea4*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineViewModel get_SpineModel();
                /*0x4011eac*/ void set_SpineModel(Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineViewModel value);
                /*0x4006b64*/ Assets.AssetManagement.SpineMecanim get_Spine();
                /*0x4011eb4*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundFunctionalViewModel get_FunctionalImageModel();
                /*0x4011ebc*/ void set_FunctionalImageModel(Assets.GameUi.Externals.BackgroundPanel.BackgroundFunctionalViewModel value);
                /*0x4007928*/ Assets.Utilities.FunctionalImage.BackgroundComponent get_FunctionalImage();
                /*0x4011c34*/ Cysharp.Threading.Tasks.UniTask PlaybackVideoFile(string url, bool loop, System.Threading.CancellationToken token);
                /*0x400767c*/ void StopVideoFilePlayback();
                /*0x4006180*/ void Blur(float duration);
                /*0x400629c*/ Cysharp.Threading.Tasks.UniTask Zoom(Assets.GameUi.Externals.BackgroundManager.ZoomArgs args, System.Threading.CancellationToken cancellationToken);
                /*0x4008d8c*/ void KillActiveTween();
                /*0x4011ec4*/ void OnDisable();
                /*0x4011ee4*/ bool <PlaybackVideoFile>b__29_0();

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

                    /*0x4010438*/ BackgroundSpineViewModel();
                    /*0x4011f00*/ Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes get_Type();
                    /*0x4011f08*/ void set_Type(Assets.GameUi.Externals.BackgroundPanel.BackgroundSpineTypes value);
                    /*0x4011f10*/ string get_AssetId();
                    /*0x4011f18*/ void set_AssetId(string value);
                    /*0x4011f20*/ Assets.AssetManagement.SpineMecanim get_Spine();
                    /*0x4011f28*/ void set_Spine(Assets.AssetManagement.SpineMecanim value);
                }

                class BackgroundFunctionalViewModel
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes <Type>k__BackingField;
                    /*0x18*/ string <AssetId>k__BackingField;
                    /*0x20*/ Assets.Utilities.FunctionalImage.BackgroundComponent <Image>k__BackingField;

                    /*0x400f048*/ BackgroundFunctionalViewModel();
                    /*0x4011f30*/ Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes get_Type();
                    /*0x4011f38*/ void set_Type(Assets.GameUi.Externals.BackgroundManager.BackgroundFunctionalTypes value);
                    /*0x4011f40*/ string get_AssetId();
                    /*0x4011f48*/ void set_AssetId(string value);
                    /*0x4011f50*/ Assets.Utilities.FunctionalImage.BackgroundComponent get_Image();
                    /*0x4011f58*/ void set_Image(Assets.Utilities.FunctionalImage.BackgroundComponent value);
                    /*0x4011f60*/ void ReturnImage();
                }

                class <>c__DisplayClass32_0
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundPanel <>4__this;
                    /*0x18*/ Assets.GameUi.Externals.BackgroundManager.ZoomArgs args;

                    /*0x4012008*/ <>c__DisplayClass32_0();
                    /*0x4012010*/ void <Zoom>b__0();
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

                    /*0x4012160*/ void MoveNext();
                    /*0x40127a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x40127ac*/ void MoveNext();
                    /*0x40131ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICameraManager
            {
                /*0x38159a4*/ UnityEngine.Vector3 get_Position();
                UnityEngine.Quaternion get_Rotation();
                /*0x38148bc*/ UnityEngine.Transform get_Transform();
                /*0x3816710*/ void AddCameraLayer(string layer);
                /*0x38158a8*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition(System.Threading.CancellationToken cancellationToken);
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                Cysharp.Threading.Tasks.UniTask BlendToDefaultUi(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                Cysharp.Threading.Tasks.UniTask BlendToLoadingFade(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x3816124*/ void ConfigureForCustomBlend(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x38159dc*/ void ConfigureForCutBlend();
                /*0x38159dc*/ void PressNekoNoOnaka();
                /*0x3816710*/ void RemoveCameraLayer(string layer);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.CameraManager.CameraTypes type, System.Threading.CancellationToken cancellationToken);
            }

            class CameraManager : UnityEngine.MonoBehaviour, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSCameraManager, Assets.GameUi.Externals.ICameraManager
            {
                /*0x20*/ Unity.Cinemachine.CinemachineBrain cinemachineBrain;
                /*0x28*/ Unity.Cinemachine.CinemachineCamera defaultUiCamera;
                /*0x30*/ Unity.Cinemachine.CinemachineCamera loadingFadeCamera;
                /*0x38*/ int loadingFadeSortingLayer;
                /*0x3c*/ Assets.GameUi.Externals.CameraManager.CameraTypes currentFadeInType;

                /*0x4013604*/ CameraManager();
                /*0x40131b8*/ UnityEngine.Transform get_Transform();
                /*0x40131d4*/ UnityEngine.Vector3 get_Position();
                /*0x40131fc*/ UnityEngine.Quaternion get_Rotation();
                /*0x4013224*/ void PressNekoNoOnaka();
                /*0x4013270*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                /*0x401331c*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x40133cc*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                /*0x40133f8*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x401329c*/ void ConfigureForDefaultBlend();
                /*0x40132ac*/ Cysharp.Threading.Tasks.UniTask TransitionTo(Assets.GameUi.Externals.CameraManager.CameraTypes type, System.Threading.CancellationToken cancellationToken);
                /*0x4013418*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition(System.Threading.CancellationToken cancellationToken);
                /*0x40134f0*/ void ConfigureForCutBlend();
                /*0x401333c*/ void ConfigureForCustomBlend(Unity.Cinemachine.CinemachineBlendDefinition.Styles style, float blendTime);
                /*0x4013544*/ void AddCameraLayer(string layer);
                /*0x40135a4*/ void RemoveCameraLayer(string layer);

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
                /*0x38148bc*/ UnityEngine.Transform get_Foreground();
                /*0x38148bc*/ UnityEngine.Transform get_System();
                /*0x38148bc*/ UnityEngine.Transform get_Overlay();
                /*0x38148bc*/ UnityEngine.Transform get_OverlayIncludingOutsideSafeArea();
                /*0x3815ed0*/ void ChangeForegroundRenderMode(UnityEngine.RenderMode renderMode);
                /*0x3815cc4*/ void set_Loading(bool value);
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

                /*0x40165ac*/ LayoutManager();
                /*0x40162e4*/ UnityEngine.Transform get_Foreground();
                /*0x40162ec*/ void set_Foreground(UnityEngine.Transform value);
                /*0x40162f4*/ UnityEngine.Transform get_Overlay();
                /*0x40162fc*/ void set_Overlay(UnityEngine.Transform value);
                /*0x4016304*/ UnityEngine.Transform get_System();
                /*0x401630c*/ void set_System(UnityEngine.Transform value);
                /*0x4016314*/ UnityEngine.Transform get_OverlayIncludingOutsideSafeArea();
                /*0x401631c*/ void set_OverlayIncludingOutsideSafeArea(UnityEngine.Transform value);
                /*0x4016324*/ void Awake();
                /*0x4016390*/ void ChangeForegroundRenderMode(UnityEngine.RenderMode renderMode);
                /*0x401658c*/ void set_Loading(bool value);
            }

            interface ILocalSettingsManager
            {
                /*0x3816710*/ void Save(Assets.GameUi.Externals.LocalSettings settings);
                /*0x38148bc*/ Assets.GameUi.Externals.LocalSettings Load();
                /*0x38159dc*/ void Delete();
            }

            class LocalSettingsManager : Assets.GameUi.Externals.ILocalSettingsManager
            {
                static string LocalSettingsKey = "Inu_LocalSetting";
                /*0x10*/ Assets.GameUi.Externals.LocalSettings localSettings;

                /*0x4016ad0*/ LocalSettingsManager();
                /*0x40165b4*/ void Save(Assets.GameUi.Externals.LocalSettings settings);
                /*0x4016650*/ Assets.GameUi.Externals.LocalSettings Load();
                /*0x4016a70*/ void Delete();
            }

            class LegalSettings
            {
                /*0x10*/ System.Nullable<int> <AgreementVersion>k__BackingField;

                /*0x4016ae8*/ LegalSettings();
                /*0x4016ad8*/ System.Nullable<int> get_AgreementVersion();
                /*0x4016ae0*/ void set_AgreementVersion(System.Nullable<int> value);
            }

            class SystemSettings
            {
                /*0x10*/ int <QualityLevel>k__BackingField;
                /*0x14*/ int <SkillMovieCut>k__BackingField;

                /*0x4016b10*/ SystemSettings();
                /*0x4016af0*/ int get_QualityLevel();
                /*0x4016af8*/ void set_QualityLevel(int value);
                /*0x4016b00*/ int get_SkillMovieCut();
                /*0x4016b08*/ void set_SkillMovieCut(int value);
            }

            class AssetDownloadSetting
            {
                /*0x10*/ bool <IsBulkAssetDownloadConfirmed>k__BackingField;

                /*0x4016b34*/ AssetDownloadSetting();
                /*0x4016b20*/ bool get_IsBulkAssetDownloadConfirmed();
                /*0x4016b28*/ void set_IsBulkAssetDownloadConfirmed(bool value);
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

                /*0x4016c34*/ SoundSettings();
                /*0x4016b3c*/ bool get_AllMute();
                /*0x4016b44*/ void set_AllMute(bool value);
                /*0x4016b50*/ bool get_BgmMute();
                /*0x4016b58*/ void set_BgmMute(bool value);
                /*0x4016b64*/ bool get_SeMute();
                /*0x4016b6c*/ void set_SeMute(bool value);
                /*0x4016b78*/ bool get_VoiceMute();
                /*0x4016b80*/ void set_VoiceMute(bool value);
                /*0x4016b8c*/ int get_BgmVolume();
                /*0x4016b94*/ void set_BgmVolume(int value);
                /*0x4016b9c*/ int get_SeVolume();
                /*0x4016ba4*/ void set_SeVolume(int value);
                /*0x4016bac*/ int get_VoiceVolume();
                /*0x4016bb4*/ void set_VoiceVolume(int value);
                /*0x4016bbc*/ bool get_EnableBgm();
                /*0x4016be4*/ bool get_EnableSe();
                /*0x4016c0c*/ bool get_EnableVoice();
            }

            class ScenarioSettings
            {
                /*0x10*/ Assets.GameUi.Externals.ScenarioTextSpeedTypes <ScenarioTextSpeed>k__BackingField;
                /*0x14*/ Assets.GameUi.Externals.ScenarioTextBackGroundAlphaTypes <ScenarioBackgroundAlpha>k__BackingField;
                /*0x18*/ bool <ScenarioVoiceDownload>k__BackingField;
                /*0x19*/ bool <DoNotShowVoiceDownload>k__BackingField;
                /*0x1a*/ bool <DoNotShowIfPlayRated>k__BackingField;

                /*0x4016ca8*/ ScenarioSettings();
                /*0x4016c4c*/ Assets.GameUi.Externals.ScenarioTextSpeedTypes get_ScenarioTextSpeed();
                /*0x4016c54*/ void set_ScenarioTextSpeed(Assets.GameUi.Externals.ScenarioTextSpeedTypes value);
                /*0x4016c5c*/ Assets.GameUi.Externals.ScenarioTextBackGroundAlphaTypes get_ScenarioBackgroundAlpha();
                /*0x4016c64*/ void set_ScenarioBackgroundAlpha(Assets.GameUi.Externals.ScenarioTextBackGroundAlphaTypes value);
                /*0x4016c6c*/ bool get_ScenarioVoiceDownload();
                /*0x4016c74*/ void set_ScenarioVoiceDownload(bool value);
                /*0x4016c80*/ bool get_DoNotShowVoiceDownload();
                /*0x4016c88*/ void set_DoNotShowVoiceDownload(bool value);
                /*0x4016c94*/ bool get_DoNotShowIfPlayRated();
                /*0x4016c9c*/ void set_DoNotShowIfPlayRated(bool value);
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

                /*0x4016d44*/ NotificationSettings();
                /*0x4016cc0*/ bool get_NotificationActivityComplete();
                /*0x4016cc8*/ void set_NotificationActivityComplete(bool value);
                /*0x4016cd4*/ bool get_NotificationWorkCompleted();
                /*0x4016cdc*/ void set_NotificationWorkCompleted(bool value);
                /*0x4016ce8*/ bool get_NotificationNotLogIn();
                /*0x4016cf0*/ void set_NotificationNotLogIn(bool value);
                /*0x4016cfc*/ bool get_NotificationDailyMissionNotCompleted();
                /*0x4016d04*/ void set_NotificationDailyMissionNotCompleted(bool value);
                /*0x4016d10*/ bool get_NotificationTimeSetting();
                /*0x4016d18*/ void set_NotificationTimeSetting(bool value);
                /*0x4016d24*/ int get_NotificationStartTime();
                /*0x4016d2c*/ void set_NotificationStartTime(int value);
                /*0x4016d34*/ int get_NotificationEndTime();
                /*0x4016d3c*/ void set_NotificationEndTime(int value);
            }

            class SortFilterSettings
            {
                /*0x10*/ System.Collections.Generic.List<Assets.GameUi.Externals.SortFilterSettingsData> <SortFilterData>k__BackingField;

                /*0x4016d6c*/ SortFilterSettings();
                /*0x4016d5c*/ System.Collections.Generic.List<Assets.GameUi.Externals.SortFilterSettingsData> get_SortFilterData();
                /*0x4016d64*/ void set_SortFilterData(System.Collections.Generic.List<Assets.GameUi.Externals.SortFilterSettingsData> value);
            }

            class QuestSettings
            {
                /*0x10*/ long <MainQuestLastPartyId>k__BackingField;

                /*0x4016e04*/ QuestSettings();
                /*0x4016df4*/ long get_MainQuestLastPartyId();
                /*0x4016dfc*/ void set_MainQuestLastPartyId(long value);
            }

            class SortFilterSettingsData
            {
                /*0x10*/ Assets.GameUi.Externals.SortFilterTypes <SortFilterType>k__BackingField;
                /*0x14*/ bool <FilterValid>k__BackingField;
                /*0x18*/ int <Sort>k__BackingField;
                /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.IEnumerable<int>> <Filter>k__BackingField;

                /*0x4016e50*/ SortFilterSettingsData();
                /*0x4016e0c*/ Assets.GameUi.Externals.SortFilterTypes get_SortFilterType();
                /*0x4016e14*/ void set_SortFilterType(Assets.GameUi.Externals.SortFilterTypes value);
                /*0x4016e1c*/ bool get_FilterValid();
                /*0x4016e24*/ void set_FilterValid(bool value);
                /*0x4016e30*/ int get_Sort();
                /*0x4016e38*/ void set_Sort(int value);
                /*0x4016e40*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.IEnumerable<int>> get_Filter();
                /*0x4016e48*/ void set_Filter(System.Collections.Generic.Dictionary<int, System.Collections.Generic.IEnumerable<int>> value);
            }

            class GachaSettings
            {
                /*0x10*/ System.Nullable<System.DateTime> <LastViewedAt>k__BackingField;

                /*0x4016eec*/ GachaSettings();
                /*0x4016ed8*/ System.Nullable<System.DateTime> get_LastViewedAt();
                /*0x4016ee4*/ void set_LastViewedAt(System.Nullable<System.DateTime> value);
            }

            class ShopSettings
            {
                /*0x10*/ System.Nullable<System.DateTime> <LastViewedAt>k__BackingField;

                /*0x4016f08*/ ShopSettings();
                /*0x4016ef4*/ System.Nullable<System.DateTime> get_LastViewedAt();
                /*0x4016f00*/ void set_LastViewedAt(System.Nullable<System.DateTime> value);
            }

            class ChatSettings
            {
                /*0x10*/ System.Collections.Generic.List<string> <NewChatMessageSenderCodes>k__BackingField;

                /*0x4016f20*/ ChatSettings();
                /*0x4016f10*/ System.Collections.Generic.List<string> get_NewChatMessageSenderCodes();
                /*0x4016f18*/ void set_NewChatMessageSenderCodes(System.Collections.Generic.List<string> value);
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

                /*0x4016730*/ LocalSettings();
                /*0x4016fa8*/ Assets.GameUi.Externals.LegalSettings get_Legal();
                /*0x4016fb0*/ void set_Legal(Assets.GameUi.Externals.LegalSettings value);
                /*0x4016fb8*/ Assets.GameUi.Externals.SystemSettings get_System();
                /*0x4016fc0*/ void set_System(Assets.GameUi.Externals.SystemSettings value);
                /*0x4016fc8*/ Assets.GameUi.Externals.SoundSettings get_Sound();
                /*0x4016fd0*/ void set_Sound(Assets.GameUi.Externals.SoundSettings value);
                /*0x4016fd8*/ Assets.GameUi.Externals.ScenarioSettings get_Scenario();
                /*0x4016fe0*/ void set_Scenario(Assets.GameUi.Externals.ScenarioSettings value);
                /*0x4016fe8*/ Assets.GameUi.Externals.NotificationSettings get_Notification();
                /*0x4016ff0*/ void set_Notification(Assets.GameUi.Externals.NotificationSettings value);
                /*0x4016ff8*/ Assets.GameUi.Externals.SortFilterSettings get_SortFilter();
                /*0x4017000*/ void set_SortFilter(Assets.GameUi.Externals.SortFilterSettings value);
                /*0x4017008*/ Assets.GameUi.Externals.QuestSettings get_Quest();
                /*0x4017010*/ void set_Quest(Assets.GameUi.Externals.QuestSettings value);
                /*0x4017018*/ Assets.GameUi.Externals.GachaSettings get_Gacha();
                /*0x4017020*/ void set_Gacha(Assets.GameUi.Externals.GachaSettings value);
                /*0x4017028*/ Assets.GameUi.Externals.ShopSettings get_Shop();
                /*0x4017030*/ void set_Shop(Assets.GameUi.Externals.ShopSettings value);
                /*0x4017038*/ Assets.GameUi.Externals.PerformanceFlags get_DoNotPerformanceFlags();
                /*0x4017040*/ void set_DoNotPerformanceFlags(Assets.GameUi.Externals.PerformanceFlags value);
                /*0x4017048*/ Assets.GameUi.Externals.ChatSettings get_Chat();
                /*0x4017050*/ void set_Chat(Assets.GameUi.Externals.ChatSettings value);
                /*0x4017058*/ Assets.GameUi.Externals.AssetDownloadSetting get_AssetDownload();
                /*0x4017060*/ void set_AssetDownload(Assets.GameUi.Externals.AssetDownloadSetting value);
                /*0x4017068*/ Assets.GameUi.Externals.DebugSettings get_DebugSettings();
                /*0x4017070*/ void set_DebugSettings(Assets.GameUi.Externals.DebugSettings value);
            }

            class DebugSettings
            {
                /*0x10*/ string <Magic>k__BackingField;

                /*0x4017078*/ DebugSettings();
                /*0x40170ac*/ string get_Magic();
                /*0x40170b4*/ void set_Magic(string value);
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

                /*0x40170bc*/ SceneManager(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.GameUi.Externals.IUiLayoutManager layoutManager);
                /*0x4017100*/ Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> MoveToSceneAcync(string key);

                struct <MoveToSceneAcync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>t__builder;
                    /*0x30*/ Assets.GameUi.Externals.SceneManager <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>u__1;

                    /*0x4017218*/ void MoveNext();
                    /*0x401782c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            namespace Utilities
            {
                class SafeAreaConstraint : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ UnityEngine.Canvas <Canvas>k__BackingField;

                    /*0x4017ae0*/ SafeAreaConstraint();
                    /*0x4017884*/ UnityEngine.Canvas get_Canvas();
                    /*0x401788c*/ void set_Canvas(UnityEngine.Canvas value);
                    /*0x4017894*/ void Start();
                    /*0x40163bc*/ void Constrain();
                    /*0x40178c0*/ void ConstrainForWorldSpaceCanvas(UnityEngine.Canvas canvas);
                    /*0x4017898*/ bool IsWorldSpace(UnityEngine.Canvas canvas);
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
