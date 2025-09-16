class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3ca08ac*/ EmbeddedAttribute();
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

                /*0x3ca08b4*/ NullableAttribute(byte );
                /*0x3ca093c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3ca096c*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3ca0994*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3ca0a88*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace MessagePack
{
    class GeneratedMessagePackResolver : MessagePack.IFormatterResolver
    {
        static /*0x0*/ MessagePack.IFormatterResolver Instance;

        static /*0x3ca0a98*/ GeneratedMessagePackResolver();
        /*0x3ca0a90*/ GeneratedMessagePackResolver();
        /*0x38148bc*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

        class FormatterCache<T>
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static /*0x383e7a0*/ FormatterCache();
        }

        class GeneratedMessagePackResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, int> closedTypeLookup;

            static /*0x3ca0c24*/ GeneratedMessagePackResolverGetFormatterHelper();
            static /*0x3ca0b00*/ object GetFormatter(System.Type t);
        }

        class Assets
        {
            /*0x3ca0d60*/ Assets();

            class Battle
            {
                /*0x3ca0d68*/ Battle();

                class BattleController
                {
                    /*0x3ca0d70*/ BattleController();

                    class LocalBattleSettingsFormatter : MessagePack.Formatters.IMessagePackFormatter<Assets.Battle.BattleController.LocalBattleSettings>, MessagePack.Formatters.IMessagePackFormatter
                    {
                        /*0x3ca0c1c*/ LocalBattleSettingsFormatter();
                        /*0x3ca0d78*/ void Serialize(ref MessagePack.MessagePackWriter writer, Assets.Battle.BattleController.LocalBattleSettings value, MessagePack.MessagePackSerializerOptions options);
                        /*0x3ca0f60*/ Assets.Battle.BattleController.LocalBattleSettings Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
                    }
                }
            }
        }
    }
}

namespace VContainer
{
    class BattleContainerBuilderExtension
    {
        static /*0x3ca12f4*/ void RegisterBattleAssemblies(VContainer.IContainerBuilder builder);

        class <>c
        {
            static /*0x0*/ VContainer.BattleContainerBuilderExtension.<> <>9;
            static /*0x8*/ System.Func<System.Type, bool> <>9__0_0;
            static /*0x10*/ System.Func<System.Type, bool> <>9__0_1;
            static /*0x18*/ System.Func<System.Type, bool> <>9__0_2;
            static /*0x20*/ System.Func<System.Type, bool> <>9__0_3;

            static /*0x3ca1844*/ <>c();
            /*0x3ca18ac*/ <>c();
            /*0x3ca18b4*/ bool <RegisterBattleAssemblies>b__0_0(System.Type t);
            /*0x3ca18f8*/ bool <RegisterBattleAssemblies>b__0_1(System.Type t);
            /*0x3ca195c*/ bool <RegisterBattleAssemblies>b__0_2(System.Type t);
            /*0x3ca19a0*/ bool <RegisterBattleAssemblies>b__0_3(System.Type t);
        }
    }
}

namespace Assets
{
    namespace Battle
    {
        class Actor : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.Api.Client.PawnId <Id>k__BackingField;
            /*0x28*/ string <AssetId>k__BackingField;
            /*0x30*/ string <CockpitId>k__BackingField;
            /*0x38*/ Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController> <MecanimReference>k__BackingField;
            /*0x40*/ bool <IsEnemyActor>k__BackingField;
            /*0x41*/ bool <IsDead>k__BackingField;
            /*0x42*/ bool <SustainsControlEffect>k__BackingField;
            /*0x44*/ int <FieldPositionIndex>k__BackingField;
            /*0x48*/ int <PositionIndex>k__BackingField;
            /*0x4c*/ float <CameraFocusDistance>k__BackingField;
            /*0x50*/ Assets.Battle.Actor.States <State>k__BackingField;
            /*0x58*/ Assets.Battle.Hud.ActorStatusView <ActorIcon>k__BackingField;
            /*0x60*/ Assets.Battle.Hud.ActorStatusView <WorldIcon>k__BackingField;
            /*0x68*/ Assets.Battle.Hud.ActorStatusIcon <ActorStatusIcon>k__BackingField;
            /*0x70*/ Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> <Cockpit>k__BackingField;
            /*0x78*/ System.Collections.Generic.Dictionary<string, Assets.VisualEffectData.VfxHandler> <AttachedVfx>k__BackingField;
            /*0x80*/ Assets.Api.Client.StatusView <Status>k__BackingField;
            /*0x88*/ bool <LargeScaleMecanim>k__BackingField;
            /*0x89*/ bool <VoiceIsPlaying>k__BackingField;
            /*0x8c*/ Assets.Api.Client.CharacterAttributes <Attribute>k__BackingField;
            /*0x90*/ System.Collections.Generic.Dictionary<int, Assets.Api.Client.AuraView> <AppliedAuras>k__BackingField;
            /*0x98*/ UnityEngine.Color ConflagrationColor;
            /*0xa8*/ UnityEngine.Color FreezeColor;

            /*0x3ca26e4*/ Actor();
            /*0x3ca1a84*/ Assets.Api.Client.PawnId get_Id();
            /*0x3ca1a8c*/ void set_Id(Assets.Api.Client.PawnId value);
            /*0x3ca1a94*/ string get_AssetId();
            /*0x3ca1a9c*/ void set_AssetId(string value);
            /*0x3ca1aa4*/ string get_CockpitId();
            /*0x3ca1aac*/ void set_CockpitId(string value);
            /*0x3ca1ab4*/ Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController> get_MecanimReference();
            /*0x3ca1abc*/ void set_MecanimReference(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController> value);
            /*0x3ca1ac4*/ bool get_IsEnemyActor();
            /*0x3ca1acc*/ void set_IsEnemyActor(bool value);
            /*0x3ca1ad8*/ bool get_IsDead();
            /*0x3ca1ae0*/ void set_IsDead(bool value);
            /*0x3ca1aec*/ bool get_SustainsControlEffect();
            /*0x3ca1af4*/ void set_SustainsControlEffect(bool value);
            /*0x3ca1b00*/ int get_FieldPositionIndex();
            /*0x3ca1b08*/ void set_FieldPositionIndex(int value);
            /*0x3ca1b10*/ int get_PositionIndex();
            /*0x3ca1b18*/ void set_PositionIndex(int value);
            /*0x3ca1b20*/ float get_CameraFocusDistance();
            /*0x3ca1b28*/ void set_CameraFocusDistance(float value);
            /*0x3ca1b30*/ Assets.Battle.Actor.States get_State();
            /*0x3ca1b38*/ void set_State(Assets.Battle.Actor.States value);
            /*0x3ca1b40*/ Assets.Battle.Hud.ActorStatusView get_ActorIcon();
            /*0x3ca1b48*/ void set_ActorIcon(Assets.Battle.Hud.ActorStatusView value);
            /*0x3ca1b50*/ Assets.Battle.Hud.ActorStatusView get_WorldIcon();
            /*0x3ca1b58*/ void set_WorldIcon(Assets.Battle.Hud.ActorStatusView value);
            /*0x3ca1b60*/ Assets.Battle.Hud.ActorStatusIcon get_ActorStatusIcon();
            /*0x3ca1b68*/ void set_ActorStatusIcon(Assets.Battle.Hud.ActorStatusIcon value);
            /*0x3ca1b70*/ Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> get_Cockpit();
            /*0x3ca1b78*/ void set_Cockpit(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> value);
            /*0x3ca1b80*/ System.Collections.Generic.Dictionary<string, Assets.VisualEffectData.VfxHandler> get_AttachedVfx();
            /*0x3ca1b88*/ void set_AttachedVfx(System.Collections.Generic.Dictionary<string, Assets.VisualEffectData.VfxHandler> value);
            /*0x3ca1b90*/ Assets.Api.Client.StatusView get_Status();
            /*0x3ca1b98*/ void set_Status(Assets.Api.Client.StatusView value);
            /*0x3ca1ba0*/ bool get_LargeScaleMecanim();
            /*0x3ca1ba8*/ void set_LargeScaleMecanim(bool value);
            /*0x3ca1bb4*/ bool get_VoiceIsPlaying();
            /*0x3ca1bbc*/ void set_VoiceIsPlaying(bool value);
            /*0x3ca1bc8*/ Assets.Api.Client.CharacterAttributes get_Attribute();
            /*0x3ca1bd0*/ void set_Attribute(Assets.Api.Client.CharacterAttributes value);
            /*0x3ca1bd8*/ System.Collections.Generic.Dictionary<int, Assets.Api.Client.AuraView> get_AppliedAuras();
            /*0x3ca1be0*/ void UpdateAuraState(ref bool sustainsControlEffectStateChanged);
            /*0x3ca1eb4*/ void AddBetweenState(Assets.Battle.Actor.States initialState, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3ca2088*/ void AddConflagrationState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverser);
            /*0x3ca21b0*/ void RemoveConflagrationState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3ca22e0*/ void AddFreezeState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3ca2464*/ void RemoveFreezeState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3ca25bc*/ void AddGuardingState();
            /*0x3ca2620*/ void RemoveGuardingState();
            /*0x3ca2694*/ void UpdateHudEmergencyState(Assets.Api.Client.StatusView statusView);
            /*0x3ca1ea4*/ void UpdateHudControlState(bool sustainsControlEffect);
            /*0x3ca26dc*/ void ResetState();
            /*0x3ca21a0*/ void AddState(Assets.Battle.Actor.States state);
            /*0x3ca22d0*/ void RemoveState(Assets.Battle.Actor.States state);

            enum AttackTypes
            {
                Sword = 0,
                AssaultRifle = 1,
                MissileLauncher = 2,
            }

            enum Formation
            {
                Front = 0,
                Back = 1,
            }

            enum States
            {
                Normal = 0,
                ControlEffect = 1,
                Emergency = 2,
                Guarding = 4,
                Conflagration = 8,
                Freeze = 16,
            }
        }

        class BattleComponent : UnityEngine.MonoBehaviour<Assets.Battle.BattleComponent, Assets.Battle.BattleController, Assets.GameUi.BattleArguments>
        {
            /*0x48*/ bool togglePause;
            /*0x49*/ bool processEventOnClick;
            /*0x4a*/ bool unlockLocks;
            /*0x4b*/ bool pauseVfxUpdate;
            /*0x4c*/ bool triggerLightFlash;
            /*0x4d*/ bool triggerDarkFlash;
            /*0x4e*/ bool cameraOffset;
            /*0x50*/ Assets.Battle.BattleComponent.BattlePresets battlePreset;
            /*0x54*/ bool triggerTutorialMessage;
            /*0x55*/ bool triggerSkip;
            /*0x56*/ bool triggerReplay;
            /*0x57*/ bool triggerResultAnimations;
            /*0x58*/ bool triggerError;
            /*0x59*/ bool triggerDamage;
            /*0x5a*/ bool triggerShiledDamage;
            /*0x5b*/ bool triggerText;
            /*0x5c*/ bool triggerTotalDamage;
            /*0x5d*/ bool triggerTotalDamageReset;
            /*0x60*/ Assets.Battle.Hud.ActionQueue actionQueue;
            /*0x68*/ UnityEngine.Transform playerActorIconsGroup;
            /*0x70*/ UnityEngine.Transform enemyActorIconsGroup;
            /*0x78*/ UnityEngine.Transform playerActorStatusIconsGroup;
            /*0x80*/ UnityEngine.Transform enemyActorStatusIconsGroup;
            /*0x88*/ TMPro.TextMeshProUGUI turnText;
            /*0x90*/ TMPro.TextMeshProUGUI questText;
            /*0x98*/ UnityEngine.UI.Button skipButton;
            /*0xa0*/ UnityEngine.UI.Button skipLock;
            /*0xa8*/ UnityEngine.UI.Button speedButton;
            /*0xb0*/ UnityEngine.UI.Button speedLock;
            /*0xb8*/ UnityEngine.UI.Button pauseButton;
            /*0xc0*/ UnityEngine.UI.Button closePauseButton;
            /*0xc8*/ UnityEngine.UI.Button cameraChangeButton;
            /*0xd0*/ UnityEngine.UI.Button cameraChangeLock;
            /*0xd8*/ UnityEngine.UI.Button cockpitViewChangeButton;
            /*0xe0*/ UnityEngine.UI.Button cockpitViewChangeLock;
            /*0xe8*/ TMPro.TextMeshProUGUI speedButtonLabel;
            /*0xf0*/ Assets.Battle.Hud.SkillNameLabel skillNameLabel;
            /*0xf8*/ UnityEngine.GameObject hudLayer;
            /*0x100*/ Assets.Battle.Hud.TurnView turnView;
            /*0x108*/ UnityEngine.CanvasGroup minimizedCockpitUnderlay;
            /*0x110*/ UnityEngine.UI.Image minimizedCockpitOverlay;
            /*0x118*/ UnityEngine.Transform worldCanvas;
            /*0x120*/ Assets.Battle.Hud.ResultNavigation resultNavigation;
            /*0x128*/ Assets.Battle.Hud.ResultBackground resultBackground;
            /*0x130*/ Assets.Battle.Hud.ResultRewardsView resultRewardsView;
            /*0x138*/ Assets.Battle.Hud.ResultLevelProgress resultLevelProgress;
            /*0x140*/ Assets.Battle.Hud.ResultRankProgress resultRankProgress;
            /*0x148*/ Assets.Battle.Hud.ResultDamageView resultDamageView;
            /*0x150*/ Assets.Battle.Hud.BossHealthGauge bossHealthGauge;
            /*0x158*/ Assets.Battle.Hud.CombinedGauge teamHealthGauge;
            /*0x160*/ Assets.Battle.Hud.PositionLegend positionLegend;
            /*0x168*/ UnityEngine.GameObject pauseHeader;
            /*0x170*/ UnityEngine.GameObject pauseFade;
            /*0x178*/ UnityEngine.GameObject playerPauseLabel;
            /*0x180*/ UnityEngine.GameObject enemyPauseLabel;
            /*0x188*/ UnityEngine.UI.Image overlayFade;
            /*0x190*/ UnityEngine.Transform navigationHud;
            /*0x198*/ UnityEngine.Transform bottomHud;
            /*0x1a0*/ UnityEngine.Transform bottomOverlayHud;
            /*0x1a8*/ Assets.Battle.Hud.ActorDetails actorDetails;
            /*0x1b0*/ UnityEngine.UI.Button closeActorDetailsButton;
            /*0x1b8*/ UnityEngine.UI.Button actorDetailsRightScrollButton;
            /*0x1c0*/ UnityEngine.UI.Button actorDetailsLeftScrollButton;
            /*0x1c8*/ Assets.Battle.Hud.MvpDataView mvpDataView;
            /*0x1d0*/ Assets.Battle.Accessors.CinemachineLayoutAccessor cinemachineLayoutAccessor;
            /*0x1d8*/ UnityEngine.GameObject entranceAnimation;
            /*0x1e0*/ Unity.Cinemachine.NoiseSettings shakeNoise;
            /*0x1e8*/ Unity.Cinemachine.NoiseSettings wobbleNoise;
            /*0x1f0*/ UnityEngine.Rendering.Volume postProcessingVolume;
            /*0x1f8*/ Assets.Battle.Hud.TotalDamageView totalDamageView;
            /*0x200*/ UnityEngine.Material normalMaterial;
            /*0x208*/ UnityEngine.Material criticalMaterial;
            /*0x210*/ UnityEngine.Material resistMaterial;
            /*0x218*/ UnityEngine.Material weakMaterial;
            /*0x220*/ UnityEngine.Material missMaterial;
            /*0x228*/ UnityEngine.Material healMaterial;
            /*0x230*/ UnityEngine.Transform fieldCenter;
            /*0x238*/ UnityEngine.Transform playerGroupCenter;
            /*0x240*/ UnityEngine.Transform enemyGroupCenter;
            /*0x248*/ Assets.Battle.Hud.CockpitPlaceholder[] cockpitViewPlaceholders;
            /*0x250*/ UnityEngine.UI.Image cockpitBackground;
            /*0x258*/ Assets.Battle.Utilities.PunchData damagePunchData;
            /*0x260*/ Assets.Battle.Utilities.ColorData damageColorData;
            /*0x268*/ Assets.Battle.Utilities.ColorData healColorData;
            /*0x270*/ UnityEngine.UI.Image[] additionalAnimationTargets;
            /*0x278*/ UnityEngine.Transform actorsLayer;
            /*0x280*/ UnityEngine.Transform visualEffectsLayer;
            /*0x288*/ UnityEngine.Transform visualEffectsOverlayLayer;
            /*0x290*/ UnityEngine.Transform combatTextLayer;
            /*0x298*/ UnityEngine.Transform cockpitResultLayer;
            /*0x2a0*/ UnityEngine.Transform minimizedCockpitLayer;
            /*0x2a8*/ UnityEngine.Transform navigationParentLayer;
            /*0x2b0*/ UnityEngine.Transform navigationOverlayParentLayer;
            /*0x2b8*/ UnityEngine.Transform resultLayerParentAnchor;
            /*0x2c0*/ UnityEngine.Transform bottomHudParentLowAnchor;
            /*0x2c8*/ UnityEngine.Transform bottomHudParentHightAnchor;
            /*0x2d0*/ UnityEngine.Transform bottomHudOverlayParentLowAnchor;
            /*0x2d8*/ UnityEngine.Transform bottomHudOverlayParentHightAnchor;
            /*0x2e0*/ UnityEngine.Transform fieldParent;
            /*0x2e8*/ UnityEngine.Transform[] actorPlaceholders;
            /*0x2f0*/ UnityEngine.InputSystem.InputActionAsset input;
            /*0x2f8*/ UnityEngine.Animator[] resultAnimators;
            /*0x300*/ UnityEngine.RectTransform firstSlotHighlight;
            /*0x308*/ UnityEngine.RectTransform firstSlotExtraGaugeHighlight;
            /*0x310*/ UnityEngine.RectTransform resultTipsHighlight;
            /*0x318*/ UnityEngine.RectTransform actorsOrderList;
            /*0x320*/ UnityEngine.RectTransform playerActorIconFirstSlotAP;
            /*0x328*/ UnityEngine.RectTransform playerActorIconFirstSlotPP;
            /*0x330*/ UnityEngine.RectTransform playerActorIconSecondSlotPP;
            /*0x338*/ Assets.GameUi.Header.IHeaderComponent <Header>k__BackingField;
            /*0x340*/ Assets.GameUi.Externals.IBackgroundManager <BackgroundManager>k__BackingField;
            /*0x348*/ Assets.Battle.ICache <Cache>k__BackingField;
            /*0x350*/ Assets.Battle.Utilities.IMetronome <Metronome>k__BackingField;
            /*0x358*/ Assets.GameUi.Externals.IUiLayoutManager <UiLayoutManager>k__BackingField;
            /*0x360*/ Assets.GameUi.Externals.ICameraManager <CameraManager>k__BackingField;
            /*0x368*/ Assets.Battle.Overseers.IHudOverseerUnityFacade <HudOverseerFacade>k__BackingField;
            /*0x370*/ Assets.Battle.Overseers.ICombatTextOverseerUnityFacade <CombatTextOverseerFacade>k__BackingField;
            /*0x378*/ Assets.Battle.Overseers.ICameraOverseerUnityFacade <CameraOverseerFacade>k__BackingField;
            /*0x380*/ Assets.Battle.Overseers.IActorOverseerUnityFacade <ActorOverseerFacade>k__BackingField;
            /*0x388*/ Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade <VisualEffectsOverseerFacade>k__BackingField;
            /*0x390*/ Assets.Battle.Overseers.ICockpitOverseerUnityFacade <CockpitOverseerFacade>k__BackingField;
            /*0x398*/ Assets.Battle.Overseers.IFieldOverseerUnityFacade <FieldOverseerFacade>k__BackingField;
            /*0x3a0*/ Assets.Battle.Overseers.ITutorialOverseerUnityFacade <TutorialOverseerFacade>k__BackingField;
            /*0x3a8*/ Assets.Battle.Overseers.ILayoutOverseerUnityFacade <LayoutOverseerFacade>k__BackingField;
            /*0x3b0*/ bool initialized;
            /*0x3b1*/ bool currentCameraOffset;

            /*0x3ca4694*/ BattleComponent();
            /*0x3ca27d8*/ Assets.GameUi.Header.IHeaderComponent get_Header();
            /*0x3ca27e0*/ void set_Header(Assets.GameUi.Header.IHeaderComponent value);
            /*0x3ca27f0*/ Assets.GameUi.Externals.IBackgroundManager get_BackgroundManager();
            /*0x3ca27f8*/ void set_BackgroundManager(Assets.GameUi.Externals.IBackgroundManager value);
            /*0x3ca2808*/ Assets.Battle.ICache get_Cache();
            /*0x3ca2810*/ void set_Cache(Assets.Battle.ICache value);
            /*0x3ca2820*/ Assets.Battle.Utilities.IMetronome get_Metronome();
            /*0x3ca2828*/ void set_Metronome(Assets.Battle.Utilities.IMetronome value);
            /*0x3ca2838*/ Assets.GameUi.Externals.IUiLayoutManager get_UiLayoutManager();
            /*0x3ca2840*/ void set_UiLayoutManager(Assets.GameUi.Externals.IUiLayoutManager value);
            /*0x3ca2850*/ Assets.GameUi.Externals.ICameraManager get_CameraManager();
            /*0x3ca2858*/ void set_CameraManager(Assets.GameUi.Externals.ICameraManager value);
            /*0x3ca2868*/ Assets.Battle.Overseers.IHudOverseerUnityFacade get_HudOverseerFacade();
            /*0x3ca2870*/ void set_HudOverseerFacade(Assets.Battle.Overseers.IHudOverseerUnityFacade value);
            /*0x3ca2880*/ Assets.Battle.Overseers.ICombatTextOverseerUnityFacade get_CombatTextOverseerFacade();
            /*0x3ca2888*/ void set_CombatTextOverseerFacade(Assets.Battle.Overseers.ICombatTextOverseerUnityFacade value);
            /*0x3ca2898*/ Assets.Battle.Overseers.ICameraOverseerUnityFacade get_CameraOverseerFacade();
            /*0x3ca28a0*/ void set_CameraOverseerFacade(Assets.Battle.Overseers.ICameraOverseerUnityFacade value);
            /*0x3ca28b0*/ Assets.Battle.Overseers.IActorOverseerUnityFacade get_ActorOverseerFacade();
            /*0x3ca28b8*/ void set_ActorOverseerFacade(Assets.Battle.Overseers.IActorOverseerUnityFacade value);
            /*0x3ca28c8*/ Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade get_VisualEffectsOverseerFacade();
            /*0x3ca28d0*/ void set_VisualEffectsOverseerFacade(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade value);
            /*0x3ca28e0*/ Assets.Battle.Overseers.ICockpitOverseerUnityFacade get_CockpitOverseerFacade();
            /*0x3ca28e8*/ void set_CockpitOverseerFacade(Assets.Battle.Overseers.ICockpitOverseerUnityFacade value);
            /*0x3ca28f8*/ Assets.Battle.Overseers.IFieldOverseerUnityFacade get_FieldOverseerFacade();
            /*0x3ca2900*/ void set_FieldOverseerFacade(Assets.Battle.Overseers.IFieldOverseerUnityFacade value);
            /*0x3ca2910*/ Assets.Battle.Overseers.ITutorialOverseerUnityFacade get_TutorialOverseerFacade();
            /*0x3ca2918*/ void set_TutorialOverseerFacade(Assets.Battle.Overseers.ITutorialOverseerUnityFacade value);
            /*0x3ca2928*/ Assets.Battle.Overseers.ILayoutOverseerUnityFacade get_LayoutOverseerFacade();
            /*0x3ca2930*/ void set_LayoutOverseerFacade(Assets.Battle.Overseers.ILayoutOverseerUnityFacade value);
            /*0x3ca2940*/ void Update();
            /*0x3ca386c*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.GameUi.BattleArguments args);
            /*0x3ca3960*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.GameUi.BattleArguments args);
            /*0x3ca3a5c*/ Cysharp.Threading.Tasks.UniTask ProcessOnComplete();
            /*0x3ca3b64*/ void Clear();
            /*0x3ca440c*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
            /*0x3ca459c*/ Cysharp.Threading.Tasks.UniTask<Assets.GameUi.BattleArguments> CreateBattleArguments();
            /*0x3ca47bc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_0();
            /*0x3ca4a80*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_1();
            /*0x3ca4ad4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_2();
            /*0x3ca4b34*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_3();
            /*0x3ca5544*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_4(Assets.GameUi.Icon.IconBase.IconArgs args);
            /*0x3ca5678*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_5(Assets.GameUi.Icon.IconBase.IconArgs args);
            /*0x3ca56dc*/ void <ProcessOnCreate>b__172_6();
            /*0x3ca591c*/ void <ProcessOnCreate>b__172_7();
            /*0x3ca5aa8*/ void <ProcessOnCreate>b__172_8();
            /*0x3ca5b00*/ void <ProcessOnCreate>b__172_9();
            /*0x3ca5b58*/ void <ProcessOnCreate>b__172_10();

            enum BattlePresets
            {
                None = 0,
                Default = 1,
                Debug = 2,
                Tutorial = 3,
            }

            class TipButtonData
            {
                /*0x10*/ System.Func<Cysharp.Threading.Tasks.UniTask> <OnClickAction>k__BackingField;
                /*0x18*/ string <Title>k__BackingField;
                /*0x20*/ string <ButtonLabel>k__BackingField;

                /*0x3ca5bd8*/ TipButtonData();
                /*0x3ca5ba8*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnClickAction();
                /*0x3ca5bb0*/ void set_OnClickAction(System.Func<Cysharp.Threading.Tasks.UniTask> value);
                /*0x3ca5bb8*/ string get_Title();
                /*0x3ca5bc0*/ void set_Title(string value);
                /*0x3ca5bc8*/ string get_ButtonLabel();
                /*0x3ca5bd0*/ void set_ButtonLabel(string value);
            }

            class <>c
            {
                static /*0x0*/ Assets.Battle.BattleComponent.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Transform, UnityEngine.Vector3> <>9__173_0;

                static /*0x3ca5c2c*/ <>c();
                /*0x3ca5c94*/ <>c();
                /*0x3ca5c9c*/ UnityEngine.Vector3 <ProcessOnRestore>b__173_0(UnityEngine.Transform t);
            }

            class <>c__DisplayClass173_0
            {
                /*0x10*/ Assets.Battle.BattleComponent.TipButtonData tip;

                /*0x3ca5cb4*/ <>c__DisplayClass173_0();
                /*0x3ca5cbc*/ void <ProcessOnRestore>b__1();
            }

            struct <CreateBattleArguments>d__177 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.GameUi.BattleArguments> <>t__builder;
                /*0x30*/ Assets.Battle.BattleComponent <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.RealBattleResult> <>u__1;

                /*0x3ca5cf0*/ void MoveNext();
                /*0x3ca6510*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessOnCreate>d__172 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Battle.BattleComponent <>4__this;
                /*0x38*/ Assets.GameUi.BattleArguments args;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                /*0x3ca6568*/ void MoveNext();
                /*0x3ca7e60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessOnRestore>d__173 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Battle.BattleComponent <>4__this;
                /*0x38*/ Assets.GameUi.BattleArguments args;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.GameUi.BattleArguments> <>u__2;

                /*0x3ca7eb8*/ void MoveNext();
                /*0x3caa900*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class BattleController : Assets.UiComponentSystem.Runtime.Controller
        {
            /*0x20*/ Assets.UiComponentSystem.Runtime.IGameNavigator navigator;
            /*0x28*/ Assets.GameUi.Toast.IToastComponent toast;
            /*0x30*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
            /*0x38*/ Assets.Api.Client.IApiClient api;
            /*0x40*/ Assets.Battle.IEventProcessor eventProcessor;
            /*0x48*/ Assets.GameUi.Utilities.IIconDetailNavigator iconDetailNavigator;
            /*0x50*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
            /*0x58*/ Assets.GameUi.Services.IBattleDebugService battleDebugService;
            /*0x60*/ Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer;
            /*0x68*/ Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService;
            /*0x70*/ Assets.GameUi.Services.ISchoolTacticalExerciseService schoolTacticalExerciseService;
            /*0x78*/ Assets.GameUi.Services.ICharacterLimitBreakService characterLimitBreakService;
            /*0x80*/ Assets.GameUi.Services.IBgmService bgmService;
            /*0x88*/ Assets.GameUi.Services.ICharacterSkillService characterSkillService;
            /*0x90*/ Assets.GameUi.Services.IModuleService moduleService;
            /*0x98*/ Assets.GameUi.Service.ILevelLinkService levelLinkService;
            /*0xa0*/ Assets.GameUi.Service.IPartyBuffService partyBuffService;
            /*0xa8*/ Assets.GameUi.Service.IBadgeService badgeService;
            /*0xb0*/ Assets.Api.Client.IErrorHandler errorHandler;
            /*0xb8*/ Assets.GameUi.Services.ICharacterOperatingSystemService characterOperatingSystemService;
            /*0xc0*/ Assets.Api.Client.FunctionBlocker.IFunctionBlocker functionBlocker;
            /*0xc8*/ Assets.GameUi.Externals.ILocalSettingsManager localSettingsManager;
            /*0xd0*/ Assets.Api.Client.Time.IAdjustedTime adjustedTime;
            /*0xd8*/ Assets.GameUi.BattleArguments arguments;
            /*0xe0*/ Assets.Battle.BattleController.BattleReport battleReport;

            static /*0x3cb0ae8*/ Assets.GameUi.BattleReport.Tile.Args <OpenBattleReport>g__CreateDataTile|39_8(Assets.Battle.BattleController.BattleReport report, System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x3caa958*/ BattleController(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.GameUi.Externals.ICameraManager cameraManager, Assets.GameUi.Toast.IToastComponent toast, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Api.Client.IApiClient api, Assets.Battle.IEventProcessor eventProcessor, Assets.GameUi.Utilities.IIconDetailNavigator iconDetailNavigator, Assets.GameUi.IGameNotificationsMessageBroker gameNotificationsMessageBroker, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Services.IBattleDebugService battleDebugService, Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer, Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService, Assets.GameUi.Services.ISchoolTacticalExerciseService schoolTacticalExerciseService, Assets.GameUi.Services.ICharacterLimitBreakService characterLimitBreakService, Assets.GameUi.Services.IBgmService bgmService, Assets.GameUi.Services.ICharacterSkillService characterSkillService, Assets.GameUi.Services.IModuleService moduleService, Assets.GameUi.Service.ILevelLinkService levelLinkService, Assets.GameUi.Service.IPartyBuffService partyBuffService, Assets.GameUi.Service.IBadgeService badgeService, Assets.Api.Client.IErrorHandler errorHandler, Assets.GameUi.Services.ICharacterOperatingSystemService characterOperatingSystemService, Assets.Api.Client.FunctionBlocker.IFunctionBlocker functionBlocker, Assets.GameUi.Externals.ILocalSettingsManager localSettingsManager, Assets.Api.Client.Time.IAdjustedTime adjustedTime);
            /*0x3ca6418*/ Cysharp.Threading.Tasks.UniTask<Assets.Api.Client.RealBattleResult> PostBattleStart();
            /*0x3caad50*/ void SkipCurrentEventProcess();
            /*0x3caae00*/ void PauseCurrentEventProcess(bool value);
            /*0x3ca3720*/ void ToggleEventProcessPause();
            /*0x3caaf70*/ bool IsDebugModeActive();
            /*0x3ca8f54*/ void UpdateDataModel(Assets.GameUi.BattleArguments arguments);
            /*0x3ca3ee8*/ void Playback();
            /*0x3ca55a8*/ Cysharp.Threading.Tasks.UniTask MoveToRewardDetail(Assets.GameUi.Icon.IconBase.IconArgs args);
            /*0x3ca4810*/ Cysharp.Threading.Tasks.UniTask MoveBack();
            /*0x3cabec8*/ Cysharp.Threading.Tasks.UniTask MoveToHome();
            /*0x3cabed8*/ Cysharp.Threading.Tasks.UniTask MoveToMaze();
            /*0x3cabef0*/ Cysharp.Threading.Tasks.UniTask MoveToCharacterList();
            /*0x3cabf54*/ Cysharp.Threading.Tasks.UniTask MoveToLevelLink();
            /*0x3ca4b88*/ Cysharp.Threading.Tasks.UniTask OpenBattleReport();
            /*0x3cab014*/ Assets.Battle.BattleController.BattleReport CreateBattleReport(Assets.Api.Client.IBattleEngineEvent[] events);
            /*0x3cabffc*/ Assets.GameUi.BattleArguments CreateBattleArguments(string data);
            /*0x3cac0a8*/ void ThrowToast(string text);
            /*0x3cac15c*/ void ThrowTutorialToast(string text);
            /*0x3ca5730*/ void ThrowSkipLockToast();
            /*0x3ca5974*/ void ThrowUnlockDescriptionToast(Assets.Api.Client.UnlockFunctionTypes type);
            /*0x3ca3670*/ void HandleUserClickAction();
            /*0x3ca33a8*/ void RiseUserClickedEvent();
            /*0x3ca7ca4*/ void OnToggleBattleUi(System.Action action);
            /*0x3ca35c0*/ void HandleSkipAction();
            /*0x3caa548*/ Assets.Battle.BattleComponent.TipButtonData[] CreateTips(Assets.GameUi.BattleArguments arguments);
            /*0x3cac280*/ Assets.Battle.BattleComponent.TipButtonData[] CreateTips(Assets.Api.Client.PawnView[] playerPawns);
            /*0x3cb0288*/ void TryAddRandomTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3cafec0*/ void TryAddPositionTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, Assets.Api.Client.PawnView[] playerPawns);
            /*0x3cafd44*/ void TryAddAttributesTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3caf7a4*/ void TryAddPartyBuffTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters);
            /*0x3caf4ec*/ void TryAddMemoriesTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3caf270*/ void TryAddOverLimitTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3caef6c*/ void TryAddOperatingSystemTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3caeae8*/ void TryAddGearCustomTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3cae834*/ void TryAddLevelLinkTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters);
            /*0x3cae5b8*/ void TryAddSchoolLevelTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3cae2a0*/ void TryAddLevelUpAffectionTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3cadf88*/ void TryAddLevelUpModulesTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3cadc70*/ void TryAddLevelUpSkillsTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3cad710*/ void TryAddLevelUpTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3cad3f8*/ void TryAddLimitBreakTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3cad0d8*/ void TryAddTacticTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3caca3c*/ void TryAddMazeTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca346c*/ Cysharp.Threading.Tasks.UniTask TriggerError();
            /*0x3ca3458*/ Cysharp.Threading.Tasks.UniTask Replay();
            /*0x3cabbec*/ Assets.Battle.BattleController.LocalBattleSettings TryLoadLocalSettings();
            /*0x3cb08bc*/ void TrySaveLocalSettings(Assets.Battle.BattleController.LocalBattleSettings settings);
            /*0x3cabb40*/ void UpdateBattleLocalSettings();
            /*0x3cb0a10*/ bool <UpdateDataModel>b__31_0(Assets.Api.Client.PlayerRankMaster m);
            /*0x3cb0ad4*/ void <UpdateDataModel>b__31_13();
            /*0x3cb0ad8*/ Assets.GameUi.BattleReport.Tile.Args <OpenBattleReport>b__39_4(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> e);
            /*0x3cb0d80*/ Assets.GameUi.BattleReport.Tile.Args <OpenBattleReport>b__39_6(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> e);
            /*0x3cb0d98*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__52_0();
            /*0x3cb0da8*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__52_1();
            /*0x3cb0db8*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__52_2();
            /*0x3cb0dd0*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__52_3();
            /*0x3cb0de8*/ Cysharp.Threading.Tasks.UniTask <TryAddOverLimitTips>b__57_0();
            /*0x3cb0df8*/ bool <TryAddLevelLinkTips>b__60_0(Assets.Api.Client.Character c);
            /*0x3cb0ea4*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelLinkTips>b__60_1();
            /*0x3cb0eb4*/ Cysharp.Threading.Tasks.UniTask <TryAddSchoolLevelTips>b__61_0();
            /*0x3cb0ec0*/ Cysharp.Threading.Tasks.UniTask <TryAddTacticTips>b__67_0();

            class LocalBattleSettings
            {
                /*0x10*/ System.Collections.Generic.HashSet<string> <CharactersUsedExtraSkill>k__BackingField;
                /*0x18*/ System.DateTime <UsedExtraSkillCreationDate>k__BackingField;

                /*0x3ca123c*/ LocalBattleSettings();
                /*0x3cb0ed4*/ System.Collections.Generic.HashSet<string> get_CharactersUsedExtraSkill();
                /*0x3cb0edc*/ void set_CharactersUsedExtraSkill(System.Collections.Generic.HashSet<string> value);
                /*0x3cb0ee4*/ System.DateTime get_UsedExtraSkillCreationDate();
                /*0x3cb0eec*/ void set_UsedExtraSkillCreationDate(System.DateTime value);
            }

            class BattleReport
            {
                /*0x10*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> <Entries>k__BackingField;
                /*0x18*/ long <LargestHealApplied>k__BackingField;
                /*0x20*/ long <LargestDamageApplied>k__BackingField;
                /*0x28*/ long <LargestDamageReceived>k__BackingField;
                /*0x30*/ long <TotalDamageScore>k__BackingField;

                /*0x3cabf64*/ BattleReport();
                /*0x3cb0ef4*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> get_Entries();
                /*0x3cb0efc*/ long get_LargestHealApplied();
                /*0x3cb0f04*/ void set_LargestHealApplied(long value);
                /*0x3cb0f0c*/ long get_LargestDamageApplied();
                /*0x3cb0f14*/ void set_LargestDamageApplied(long value);
                /*0x3cb0f1c*/ long get_LargestDamageReceived();
                /*0x3cb0f24*/ void set_LargestDamageReceived(long value);
                /*0x3cb0f2c*/ long get_TotalDamageScore();
                /*0x3cb0f34*/ void set_TotalDamageScore(long value);

                class BattleReportEntry
                {
                    /*0x10*/ long <DamageApplied>k__BackingField;
                    /*0x18*/ long <DamageReceived>k__BackingField;
                    /*0x20*/ long <HealApplied>k__BackingField;
                    /*0x28*/ bool <IsEnemyPawn>k__BackingField;
                    /*0x29*/ bool <HasDied>k__BackingField;

                    /*0x3cabff4*/ BattleReportEntry();
                    /*0x3cb0f3c*/ long get_DamageApplied();
                    /*0x3cb0f44*/ void set_DamageApplied(long value);
                    /*0x3cb0f4c*/ long get_DamageReceived();
                    /*0x3cb0f54*/ void set_DamageReceived(long value);
                    /*0x3cb0f5c*/ long get_HealApplied();
                    /*0x3cb0f64*/ void set_HealApplied(long value);
                    /*0x3cb0f6c*/ bool get_IsEnemyPawn();
                    /*0x3cb0f74*/ void set_IsEnemyPawn(bool value);
                    /*0x3cb0f80*/ bool get_HasDied();
                    /*0x3cb0f88*/ void set_HasDied(bool value);
                }
            }

            class <>c
            {
                static /*0x0*/ Assets.Battle.BattleController.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__31_1;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, long> <>9__31_2;
                static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__31_3;
                static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, Assets.Api.Client.PawnId> <>9__31_4;
                static /*0x28*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__31_5;
                static /*0x30*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, long> <>9__31_6;
                static /*0x38*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__31_7;
                static /*0x40*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, Assets.Api.Client.PawnId> <>9__31_8;
                static /*0x48*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__31_9;
                static /*0x50*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, long> <>9__31_10;
                static /*0x58*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__31_11;
                static /*0x60*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, Assets.Api.Client.PawnId> <>9__31_12;
                static /*0x68*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__32_0;
                static /*0x70*/ System.Func<Assets.Battle.BattleController.BattleReport.BattleReportEntry, long> <>9__39_0;
                static /*0x78*/ System.Func<Assets.Battle.BattleController.BattleReport.BattleReportEntry, long> <>9__39_1;
                static /*0x80*/ System.Func<Assets.Battle.BattleController.BattleReport.BattleReportEntry, long> <>9__39_2;
                static /*0x88*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__39_3;
                static /*0x90*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__39_5;
                static /*0x98*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__39_7;
                static /*0xa0*/ System.Func<Assets.Api.Client.Character, long> <>9__51_0;
                static /*0xa8*/ System.Func<Assets.Battle.BattleComponent.TipButtonData, int, string> <>9__51_1;
                static /*0xb0*/ System.Func<Assets.Api.Client.Character, long> <>9__55_0;
                static /*0xb8*/ System.Func<Assets.Api.Client.PartyBonusMaster, bool> <>9__55_1;
                static /*0xc0*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__58_2;
                static /*0xc8*/ System.Func<Assets.Api.Client.Item, bool> <>9__59_0;
                static /*0xd0*/ System.Func<Assets.Api.Client.Item, bool> <>9__59_1;
                static /*0xd8*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__59_3;
                static /*0xe0*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__63_2;
                static /*0xe8*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__64_2;
                static /*0xf0*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__65_3;
                static /*0xf8*/ System.Func<Assets.Api.Client.Item, bool> <>9__65_1;
                static /*0x100*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__66_2;

                static /*0x3cb0f94*/ <>c();
                /*0x3cb0ffc*/ <>c();
                /*0x3cb1004*/ bool <UpdateDataModel>b__31_1(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1050*/ long <UpdateDataModel>b__31_2(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1094*/ bool <UpdateDataModel>b__31_3(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb10e0*/ Assets.Api.Client.PawnId <UpdateDataModel>b__31_4(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb111c*/ bool <UpdateDataModel>b__31_5(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1168*/ long <UpdateDataModel>b__31_6(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb11ac*/ bool <UpdateDataModel>b__31_7(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb11f8*/ Assets.Api.Client.PawnId <UpdateDataModel>b__31_8(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1234*/ bool <UpdateDataModel>b__31_9(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1280*/ long <UpdateDataModel>b__31_10(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb12c4*/ bool <UpdateDataModel>b__31_11(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1310*/ Assets.Api.Client.PawnId <UpdateDataModel>b__31_12(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb134c*/ bool <Playback>b__32_0(Assets.Api.Client.IBattleEngineEvent e);
                /*0x3cb13c4*/ long <OpenBattleReport>b__39_0(Assets.Battle.BattleController.BattleReport.BattleReportEntry entry);
                /*0x3cb13dc*/ long <OpenBattleReport>b__39_1(Assets.Battle.BattleController.BattleReport.BattleReportEntry entry);
                /*0x3cb13f4*/ long <OpenBattleReport>b__39_2(Assets.Battle.BattleController.BattleReport.BattleReportEntry entry);
                /*0x3cb140c*/ bool <OpenBattleReport>b__39_3(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb1458*/ bool <OpenBattleReport>b__39_5(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3cb149c*/ bool <OpenBattleReport>b__39_7(Assets.Api.Client.IBattleEngineEvent entry);
                /*0x3cb1514*/ long <CreateTips>b__51_0(Assets.Api.Client.Character c);
                /*0x3cb152c*/ string <CreateTips>b__51_1(Assets.Battle.BattleComponent.TipButtonData t, int i);
                /*0x3cb15f8*/ long <TryAddPartyBuffTips>b__55_0(Assets.Api.Client.Character c);
                /*0x3cb1610*/ bool <TryAddPartyBuffTips>b__55_1(Assets.Api.Client.PartyBonusMaster m);
                /*0x3cb1630*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddOperatingSystemTips>b__58_2(long id);
                /*0x3cb16d0*/ bool <TryAddGearCustomTips>b__59_0(Assets.Api.Client.Item i);
                /*0x3cb1700*/ bool <TryAddGearCustomTips>b__59_1(Assets.Api.Client.Item i);
                /*0x3cb1720*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddGearCustomTips>b__59_3(long id);
                /*0x3cb17c0*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLevelUpModulesTips>b__63_2(long id);
                /*0x3cb1860*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLevelUpSkillsTips>b__64_2(long id);
                /*0x3cb1900*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLevelUpTips>b__65_3(long id);
                /*0x3cb19a0*/ bool <TryAddLevelUpTips>b__65_1(Assets.Api.Client.Item i);
                /*0x3cb19e0*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLimitBreakTips>b__66_2(long id);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ Assets.GameUi.IGameNotificationsMessageBroker gameNotificationsMessageBroker;

                /*0x3caad48*/ <>c__DisplayClass25_0();
                /*0x3cb1a80*/ void <.ctor>b__0(bool value);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry;

                /*0x3cb0d90*/ <>c__DisplayClass39_0();
                /*0x3cb1b68*/ bool <OpenBattleReport>b__9(Assets.Api.Client.PawnMasterView s);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ Assets.Api.Client.PawnSpawnedEvent spawnEvent;
                /*0x18*/ Assets.Api.Client.PawnReceivedDamageEvent damageEvent;
                /*0x20*/ Assets.Api.Client.PawnReceivedHealingEvent healingEvent;
                /*0x28*/ Assets.Api.Client.PawnDiedEvent diedEvent;

                /*0x3cabfec*/ <>c__DisplayClass40_0();
                /*0x3cb1bcc*/ bool <CreateBattleReport>b__0(Assets.Api.Client.PawnMasterView s);
                /*0x3cb1c10*/ bool <CreateBattleReport>b__1(Assets.Api.Client.PawnMasterView s);
                /*0x3cb1c54*/ bool <CreateBattleReport>b__2(Assets.Api.Client.PawnMasterView s);
                /*0x3cb1c98*/ bool <CreateBattleReport>b__3(Assets.Api.Client.PawnMasterView s);
                /*0x3cb1cdc*/ bool <CreateBattleReport>b__4(Assets.Api.Client.PawnMasterView s);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ System.Action action;

                /*0x3cac278*/ <>c__DisplayClass48_0();
                /*0x3cb1d20*/ void <OnToggleBattleUi>b__0();
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ Assets.Api.Client.PawnView item;

                /*0x3cb086c*/ <>c__DisplayClass53_0();
                /*0x3cb1d44*/ bool <TryAddPositionTips>b__0(Assets.Api.Client.PawnMasterView p);
            }

            class <>c__DisplayClass55_0
            {
                /*0x10*/ Assets.GameUi.Service.PartyBuffRetrieveResult partyBuff;

                /*0x3cb0874*/ <>c__DisplayClass55_0();
                /*0x3cb1d6c*/ bool <TryAddPartyBuffTips>b__2(Assets.Api.Client.PartyBonusDetailMaster m);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;

                /*0x3cb087c*/ <>c__DisplayClass58_0();
                /*0x3cb1de4*/ bool <TryAddOperatingSystemTips>b__0(Assets.Api.Client.Character c);
                /*0x3cb1e94*/ Cysharp.Threading.Tasks.UniTask <TryAddOperatingSystemTips>b__1();
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;

                /*0x3cb0884*/ <>c__DisplayClass59_0();
                /*0x3cb20ac*/ Cysharp.Threading.Tasks.UniTask <TryAddGearCustomTips>b__2();
            }

            class <>c__DisplayClass62_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ Assets.Api.Client.Character canLevelUpAffection;
                /*0x20*/ long[] playerCharactersIds;

                /*0x3cb088c*/ <>c__DisplayClass62_0();
                /*0x3cb22c4*/ bool <TryAddLevelUpAffectionTips>b__0(Assets.Api.Client.Character c);
                /*0x3cb2378*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpAffectionTips>b__1();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLevelUpModules;

                /*0x3cb0894*/ <>c__DisplayClass63_0();
                /*0x3cb240c*/ bool <TryAddLevelUpModulesTips>b__0(Assets.Api.Client.Character c);
                /*0x3cb24c0*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpModulesTips>b__1();
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLevelUpSkills;

                /*0x3cb089c*/ <>c__DisplayClass64_0();
                /*0x3cb2708*/ bool <TryAddLevelUpSkillsTips>b__0(Assets.Api.Client.Character c);
                /*0x3cb27bc*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpSkillsTips>b__1();
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLevelUp;

                /*0x3cb08a4*/ <>c__DisplayClass65_0();
                /*0x3cb2a04*/ bool <TryAddLevelUpTips>b__0(Assets.Api.Client.Character c);
                /*0x3cb2ab4*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpTips>b__2();
                /*0x3cb2cfc*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpTips>b__4();
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLimitBreak;

                /*0x3cb08ac*/ <>c__DisplayClass66_0();
                /*0x3cb2d20*/ bool <TryAddLimitBreakTips>b__0(Assets.Api.Client.Character c);
                /*0x3cb2dd4*/ Cysharp.Threading.Tasks.UniTask <TryAddLimitBreakTips>b__1();
            }

            class <>c__DisplayClass68_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ Assets.Api.Client.MazeLevelMaster levelMaster;

                /*0x3cb08b4*/ <>c__DisplayClass68_0();
                /*0x3cb3020*/ Cysharp.Threading.Tasks.UniTask <TryAddMazeTips>b__1();
                /*0x3cb3048*/ bool <TryAddMazeTips>b__0(Assets.Api.Client.TypeEquipment e);
                /*0x3cb3074*/ Cysharp.Threading.Tasks.UniTask <TryAddMazeTips>b__2();
            }

            struct <MoveToRewardDetail>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.GameUi.Icon.IconBase.IconArgs args;
                /*0x30*/ Assets.Battle.BattleController <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cb309c*/ void MoveNext();
                /*0x3cb3c80*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostBattleStart>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Api.Client.RealBattleResult> <>t__builder;
                /*0x30*/ Assets.Battle.BattleController <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.RealBattleResult>> <>u__1;

                /*0x3cb3c8c*/ void MoveNext();
                /*0x3cb43b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface ICache
        {
            Cysharp.Threading.Tasks.UniTask Preload(string[] keys);
            Cysharp.Threading.Tasks.UniTask<Unity.Cinemachine.CinemachineCamera> TryAcquireCinemachineVirtualCamera(string key, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAcquireGameObject(string key, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAcquireMecanimController(string key, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAcquireVfxHandler(string key, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.SpriteRenderer> TryAcquireSpriteRenderer(string key, UnityEngine.Transform parent);
            /*0x3816810*/ void TryRegisterPrefabToCache(string key, UnityEngine.GameObject prefab);
            Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAcquireVfxAnimationHandler(string key, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.SkeletonController> TryAcquireSkeletonController(string key, UnityEngine.Transform parent);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> TryAcquireComponent<T>(string key, UnityEngine.Transform parent);
            /*0x38159dc*/ void Clear();
        }

        class Cache : Assets.Battle.ICache
        {
            /*0x10*/ Assets.AssetManagement.IAssetInstanceProvider assetInstanceProvider;
            /*0x18*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.GameObject>> objectCache;
            /*0x20*/ System.Collections.Generic.Dictionary<string, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> preloadTasks;
            /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> registeredPrefabs;
            /*0x30*/ object locked;

            /*0x3cb440c*/ Cache(Assets.AssetManagement.IAssetInstanceProvider assetInstanceProvider);
            /*0x3cb4590*/ void Clear();
            /*0x3cb4818*/ void TryRegisterPrefabToCache(string key, UnityEngine.GameObject prefab);
            /*0x3cb4990*/ Cysharp.Threading.Tasks.UniTask Preload(string[] keys);
            /*0x3cb4a60*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAcquireVfxAnimationHandler(string key, UnityEngine.Transform parent);
            /*0x3cb4ae8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAcquireVfxHandler(string key, UnityEngine.Transform parent);
            /*0x3cb4b70*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAcquireMecanimController(string key, UnityEngine.Transform parent);
            /*0x3cb4bf8*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.SkeletonController> TryAcquireSkeletonController(string key, UnityEngine.Transform parent);
            /*0x3cb4c80*/ Cysharp.Threading.Tasks.UniTask<Unity.Cinemachine.CinemachineCamera> TryAcquireCinemachineVirtualCamera(string key, UnityEngine.Transform parent);
            /*0x3cb4d08*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.SpriteRenderer> TryAcquireSpriteRenderer(string key, UnityEngine.Transform parent);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> TryAcquireComponent<T>(string key, UnityEngine.Transform parent);
            /*0x3cb4d90*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAcquireGameObject(string key, UnityEngine.Transform parent);

            class <>c__DisplayClass16_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> task;

                /*0x3cb4ecc*/ <>c__DisplayClass16_0();
                /*0x3cb4ed4*/ bool <TryAcquireGameObject>b__0();
            }

            struct <Preload>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Battle.Cache <>4__this;
                /*0x30*/ string[] keys;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cb4fac*/ void MoveNext();
                /*0x3cb58bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryAcquireComponent>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.Battle.Cache <>4__this;
                /*0x0*/ string key;
                /*0x0*/ UnityEngine.Transform parent;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryAcquireGameObject>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.Battle.Cache <>4__this;
                /*0x38*/ string key;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ UnityEngine.GameObject <gameObject>5__2;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__2;

                /*0x3cb58c8*/ void MoveNext();
                /*0x3cb68ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class Constants
        {
            static /*0x0*/ string ControlEffectVfxKey;
            static /*0x8*/ string KnockoutEffectVfxKey;
            static /*0x10*/ string ChargingEffectVfxKey;
            static /*0x18*/ string GuardingEffectVfxKey;
            static /*0x20*/ string EntranceVfxKey;
            static /*0x28*/ float LargeMecanimScale;
            static /*0x2c*/ float CameraFocusDistance;
            static /*0x30*/ float MecanimScale;
            static /*0x34*/ float MetronomeBPM;
            static /*0x38*/ float CockpitViewMaxCount;
            static /*0x40*/ string SoundEffectActorDeath;
            static /*0x48*/ string SoundEffectEXGaugeFull;
            static /*0x50*/ string SoundEffectExGaugeUse;
            static /*0x58*/ string SoundEffectPointRestoration;
            static /*0x60*/ string SoundEffectVictory;
            static /*0x68*/ string SoundEffectDefeat;

            static /*0x3cb6904*/ Constants();
        }

        interface IEventProcessor
        {
            /*0x38148bc*/ System.Threading.CancellationTokenSource get_ActiveProcessCancellationTokenSource();
            Cysharp.Threading.Tasks.UniTask ProcessEvent(Assets.Api.Client.IBattleEngineEvent battleEvent);
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask ProcessEvents();
            /*0x3816710*/ void RecordEvents(Assets.Api.Client.IBattleEngineEvent[] events);
            /*0x38158ec*/ Cysharp.Threading.Tasks.UniTask TryProcessUntilTickChanged(int tick);
        }

        class EventProcessor : Assets.Battle.IEventProcessor, System.IDisposable
        {
            /*0x10*/ UniRx.CompositeDisposable disposables;
            /*0x18*/ System.Collections.Generic.Dictionary<System.Type, Assets.Battle.Directors.IDirector> directors;
            /*0x20*/ System.Collections.Generic.Queue<Assets.Api.Client.IBattleEngineEvent> eventQueue;
            /*0x28*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
            /*0x30*/ System.Threading.CancellationTokenSource <ActiveProcessCancellationTokenSource>k__BackingField;
            /*0x38*/ bool pauseEventProcessing;
            /*0x39*/ bool processSiingleEvent;
            /*0x3a*/ bool skipToEndEvent;

            /*0x3cb6b44*/ EventProcessor(Assets.Battle.Directors.IPawnSpawnedEventDirector pawnSpawnedEventDirector, Assets.Battle.Directors.IPawnUsesSkillEventDirector pawnUsesSkillEventDirector, Assets.Battle.Directors.IManeuverOrderUpdatedEventDirector maneuverOrderUpdatedEventDirector, Assets.Battle.Directors.IMasterDataUpdatedEventDirector masterDataUpdatedEventDirector, Assets.Battle.Directors.IWaveStartedEventDirector waveStartedEventDirector, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Directors.IPawnReceivedDamageEventDirector pawnReceivedDamageEventDirector, Assets.Battle.Directors.ITurnStartedEventDirector turnStartedEventDirector, Assets.Battle.Directors.IPawnDiedEventDirector pawnDiedEventDirector, Assets.Battle.Directors.IBattleEndedEventDirector battleEndedEventDirector, Assets.Battle.Directors.IPawnReceivedVfxEventDirector pawnReceivedVfxEventDirector, Assets.Battle.Directors.IPawnReceivedHealingEventDirector pawnReceivedHealingEventDirector, Assets.Battle.Directors.IPawnResourcesUpdatedEventDirector pawnResourcesUpdatedEventDirector, Assets.Battle.Directors.IPawnPreparesSkillEventDirector pawnPreparesSkillEventDirector, Assets.Battle.Directors.IPawnsAreTargetedEventDirector pawnsAreTargetedEventDirector, Assets.Battle.Directors.IBattleStartedEventDirector battleStartedEventDirector, Assets.Battle.Directors.IPawnChargesSkillEventDirector pawnChargesSkillEventDirector, Assets.Battle.Directors.IPawnStoppedChargingSkillEventDirector pawnStoppedChargingSkillEventDirector, Assets.Battle.Directors.IPawnSkippedManeuverEventDirector pawnSkippedManeuverEventDirector, Assets.Battle.Directors.ITutorialMessageEventDirector tutorialMessageEventDirector, Assets.Battle.Directors.IPawnAuraAddedEventDirector pawnAuraAddedEventDirector, Assets.Battle.Directors.IPawnAuraRemovedEventDirector pawnAuraRemovedEventDirector, Assets.Battle.Directors.IPawnUsedSkillEventDirector pawnUsedSkillEventDirector, Assets.Battle.Directors.IPawnAuraUpdatedEventDirector pawnAuraUpdatedEventDirector);
            /*0x3cb6b34*/ System.Threading.CancellationTokenSource get_ActiveProcessCancellationTokenSource();
            /*0x3cb6b3c*/ void set_ActiveProcessCancellationTokenSource(System.Threading.CancellationTokenSource value);
            /*0x3cb7508*/ void Dispose();
            /*0x3cb7624*/ void OnSkipCurrentEventProcess();
            /*0x3cb7630*/ void RecordEvents(Assets.Api.Client.IBattleEngineEvent[] events);
            /*0x3cb7720*/ Cysharp.Threading.Tasks.UniTask ProcessEvents();
            /*0x3cb77d0*/ Cysharp.Threading.Tasks.UniTask ProcessEvent(Assets.Api.Client.IBattleEngineEvent battleEvent);
            /*0x3cb7d5c*/ Cysharp.Threading.Tasks.UniTask TryProcessUntilTickChanged(int tick);
            /*0x3cb7e14*/ void <.ctor>b__11_0(bool value);
            /*0x3cb7e20*/ void <.ctor>b__11_1();

            struct <<-ctor>b__11_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ Assets.Battle.EventProcessor <>4__this;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cb7ed0*/ void MoveNext();
                /*0x3cb8254*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessEvents>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Battle.EventProcessor <>4__this;
                /*0x30*/ System.Threading.CancellationToken <cancellationToken>5__2;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cb8260*/ void MoveNext();
                /*0x3cb8adc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryProcessUntilTickChanged>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Battle.EventProcessor <>4__this;
                /*0x30*/ int tick;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cb8ae8*/ void MoveNext();
                /*0x3cb914c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class Math
        {
            static /*0x3cb9158*/ UnityEngine.Vector3 CalculatePerpendicularPoint(UnityEngine.Vector3 origin, UnityEngine.Vector3 target, float distance, float perpendicularDistance);
            static /*0x3cb93c4*/ UnityEngine.Vector3 CalculateFiniteCentroid(UnityEngine.Vector3[] points);
            static /*0x3cb94d0*/ bool ShouldIDoIt(float percentage);
            /*0x3cb94f8*/ Math();
        }

        class DeactivateWhenNoActive : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.ParticleSystem component;

            /*0x3cb95a0*/ DeactivateWhenNoActive();
            /*0x3cb9500*/ void Awake();
            /*0x3cb9558*/ void Update();
        }

        namespace Utilities
        {
            class ColorData
            {
                /*0x10*/ UnityEngine.Color <Color>k__BackingField;
                /*0x20*/ DG.Tweening.Ease <EaseIn>k__BackingField;
                /*0x24*/ DG.Tweening.Ease <EaseOut>k__BackingField;
                /*0x28*/ float <DurationIn>k__BackingField;
                /*0x2c*/ float <DurationOut>k__BackingField;

                /*0x3cb9600*/ ColorData();
                /*0x3cb95a8*/ UnityEngine.Color get_Color();
                /*0x3cb95b4*/ void set_Color(UnityEngine.Color value);
                /*0x3cb95c0*/ DG.Tweening.Ease get_EaseIn();
                /*0x3cb95c8*/ void set_EaseIn(DG.Tweening.Ease value);
                /*0x3cb95d0*/ DG.Tweening.Ease get_EaseOut();
                /*0x3cb95d8*/ void set_EaseOut(DG.Tweening.Ease value);
                /*0x3cb95e0*/ float get_DurationIn();
                /*0x3cb95e8*/ void set_DurationIn(float value);
                /*0x3cb95f0*/ float get_DurationOut();
                /*0x3cb95f8*/ void set_DurationOut(float value);
            }

            class ColorSycle : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image image;
                /*0x28*/ UnityEngine.Color[] colors;
                /*0x30*/ int index;

                /*0x3cb9724*/ ColorSycle();
                /*0x3cb9618*/ void OnEnabled();
                /*0x3cb9658*/ void Set(int index);
                /*0x3cb96bc*/ void Sycle();
            }

            class FunctionDebug : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Actor target;

                /*0x3cb978c*/ FunctionDebug();
                /*0x3cb972c*/ void Update();
            }

            class MaterialComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Material>
            {
                static /*0x0*/ Assets.Battle.Utilities.MaterialComparer Default;

                static /*0x3cb9814*/ MaterialComparer();
                /*0x3cb980c*/ MaterialComparer();
                /*0x3cb9794*/ bool Equals(UnityEngine.Material x, UnityEngine.Material y);
                /*0x3cb97e0*/ int GetHashCode(UnityEngine.Material obj);
            }

            interface IMetronome
            {
                /*0x38151b8*/ float get_BPM();
                /*0x3816f24*/ void set_BPM(float value);
                /*0x38151b8*/ float get_Interval();
                /*0x38148bc*/ UnityEngine.Events.UnityEvent get_OnBeatEvent();
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AwaitForMetronomeBeat();
                bool Update(float deltaTime);
            }

            class Metronome : Assets.Battle.Utilities.IMetronome
            {
                /*0x10*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTaskCompletionSource> completionSources;
                /*0x18*/ float bpm;
                /*0x1c*/ float interval;
                /*0x20*/ float time;
                /*0x28*/ UnityEngine.Events.UnityEvent <OnBeatEvent>k__BackingField;

                /*0x3cb98c8*/ Metronome();
                /*0x3cb987c*/ float get_BPM();
                /*0x3cb9884*/ void set_BPM(float value);
                /*0x3cb98b8*/ float get_Interval();
                /*0x3cb98c0*/ UnityEngine.Events.UnityEvent get_OnBeatEvent();
                /*0x3cb9a00*/ Cysharp.Threading.Tasks.UniTask AwaitForMetronomeBeat();
                /*0x3cb9adc*/ void CompleteBeat();
                /*0x3cb9d58*/ bool Update(float deltaTime);
                /*0x3cb9da8*/ void <.ctor>b__12_0();
            }

            class PositionFollower : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform <Target>k__BackingField;
                /*0x28*/ UnityEngine.Vector3 <Offset>k__BackingField;

                /*0x3cb9e90*/ PositionFollower();
                /*0x3cb9dac*/ UnityEngine.Transform get_Target();
                /*0x3cb9db4*/ void set_Target(UnityEngine.Transform value);
                /*0x3cb9dbc*/ UnityEngine.Vector3 get_Offset();
                /*0x3cb9dc8*/ void set_Offset(UnityEngine.Vector3 value);
                /*0x3cb9dd4*/ void Update();
            }

            class PunchData
            {
                /*0x10*/ UnityEngine.Vector3 <Vector>k__BackingField;
                /*0x1c*/ float <Duration>k__BackingField;
                /*0x20*/ int <Vibrato>k__BackingField;
                /*0x24*/ float <Elasticity>k__BackingField;
                /*0x28*/ bool <Snapping>k__BackingField;

                /*0x3cb9f4c*/ PunchData();
                /*0x3cb9ef0*/ UnityEngine.Vector3 get_Vector();
                /*0x3cb9efc*/ void set_Vector(UnityEngine.Vector3 value);
                /*0x3cb9f08*/ float get_Duration();
                /*0x3cb9f10*/ void set_Duration(float value);
                /*0x3cb9f18*/ int get_Vibrato();
                /*0x3cb9f20*/ void set_Vibrato(int value);
                /*0x3cb9f28*/ float get_Elasticity();
                /*0x3cb9f30*/ void set_Elasticity(float value);
                /*0x3cb9f38*/ bool get_Snapping();
                /*0x3cb9f40*/ void set_Snapping(bool value);
            }

            class SpriteCycle : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image image;
                /*0x28*/ UnityEngine.Sprite[] sprites;
                /*0x30*/ int index;

                /*0x3cba04c*/ SpriteCycle();
                /*0x3cb9f6c*/ void OnEnabled();
                /*0x3cb9fa0*/ void Set(int index);
                /*0x3cb9ff4*/ void Sycle();
            }

            class UtilityFunctions
            {
                static /*0x3cba054*/ float CalculateFocusCameraYOffset(float distanceFromGround);
                static /*0x38390c0*/ T[] GetRandomElements<T>(T[] array, int count);
                static /*0x3cba084*/ Cysharp.Threading.Tasks.UniTask UpdateTeamHealthGauge(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer);
                static /*0x3cb7cb8*/ void Log(string message);
                static /*0x3cb0810*/ void Log(string[] message);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Utilities.UtilityFunctions.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Actor, bool> <>9__2_0;
                    static /*0x10*/ System.Func<Assets.Battle.Actor, long> <>9__2_1;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, bool> <>9__2_2;
                    static /*0x20*/ System.Func<Assets.Battle.Actor, long> <>9__2_3;
                    static /*0x28*/ System.Func<Assets.Battle.Actor, bool> <>9__2_4;
                    static /*0x30*/ System.Func<Assets.Battle.Actor, long> <>9__2_5;
                    static /*0x38*/ System.Func<Assets.Battle.Actor, bool> <>9__2_6;
                    static /*0x40*/ System.Func<Assets.Battle.Actor, long> <>9__2_7;

                    static /*0x3cba784*/ <>c();
                    /*0x3cba7ec*/ <>c();
                    /*0x3cba7f4*/ bool <UpdateTeamHealthGauge>b__2_0(Assets.Battle.Actor a);
                    /*0x3cba814*/ long <UpdateTeamHealthGauge>b__2_1(Assets.Battle.Actor a);
                    /*0x3cba834*/ bool <UpdateTeamHealthGauge>b__2_2(Assets.Battle.Actor a);
                    /*0x3cba854*/ long <UpdateTeamHealthGauge>b__2_3(Assets.Battle.Actor a);
                    /*0x3cba874*/ bool <UpdateTeamHealthGauge>b__2_4(Assets.Battle.Actor a);
                    /*0x3cba894*/ long <UpdateTeamHealthGauge>b__2_5(Assets.Battle.Actor a);
                    /*0x3cba8b4*/ bool <UpdateTeamHealthGauge>b__2_6(Assets.Battle.Actor a);
                    /*0x3cba8d4*/ long <UpdateTeamHealthGauge>b__2_7(Assets.Battle.Actor a);
                }

                class <>c__<T>
                {
                    static /*0x0*/ Assets.Battle.Utilities.UtilityFunctions.<>c__1<T> <>9;
                    static /*0x0*/ System.Func<T, System.Guid> <>9__1_0;

                    static /*0x383e7a0*/ <>c__();
                    /*0x38159dc*/ <>c__();
                    /*0x3910ae8*/ System.Guid <GetRandomElements>b__1_0(T x);
                }
            }

            class YHardLook : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform LookAt;
                /*0x28*/ UnityEngine.Vector3 currentRotationVector;

                /*0x3cbab28*/ YHardLook();
                /*0x3cba8f4*/ void Update();
            }

            class YHardRotation : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform LookAt;

                /*0x3cbacf4*/ YHardRotation();
                /*0x3cbab88*/ void Update();
            }
        }

        namespace Temporary
        {
            class TestMath : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Utilities.Spine.SkeletonController skeletonController;
                /*0x28*/ UnityEngine.UI.Image colorTarget;
                /*0x30*/ UnityEngine.Transform transformTarget;
                /*0x38*/ Assets.Battle.Utilities.PunchData punchData;
                /*0x40*/ UnityEngine.Color color;
                /*0x50*/ DG.Tweening.Ease colorEaseIn;
                /*0x54*/ DG.Tweening.Ease colorEaseOut;
                /*0x58*/ float colorDurationIn;
                /*0x5c*/ float colorDurationOut;
                /*0x60*/ float sequenceInterval;
                /*0x64*/ bool trigger;
                /*0x68*/ DG.Tweening.Sequence sequence;

                /*0x3cbaf68*/ TestMath();
                /*0x3cbacfc*/ void Update();
                /*0x3cbade8*/ void PlaybackAnimationSequence();
            }
        }

        namespace Shared
        {
            interface ISharedBattleDataStorageModel
            {
                /*0x38148bc*/ UniRx.ReactiveProperty<float> get_BattlePlaybackSpeed();
                /*0x3813ffc*/ bool get_IsPlayground();
                /*0x3815cc4*/ void set_IsPlayground(bool value);
                /*0x3813ffc*/ bool get_HasLargeScaleMecanim();
                /*0x3815cc4*/ void set_HasLargeScaleMecanim(bool value);
                /*0x38148bc*/ UnityEngine.Vector3[] get_ActorFieldPositions();
                /*0x3816710*/ void set_ActorFieldPositions(UnityEngine.Vector3[] value);
                /*0x38148bc*/ UniRx.ReactiveProperty<bool> get_EnabledCockpitView();
            }

            interface ISharedCameraOverseer
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ICameraOverseerUnityFacade.Arguments arguments);
                /*0x3816710*/ void SetFollowTarget(UnityEngine.Transform target);
                /*0x3817254*/ void SetFollowPosition(UnityEngine.Vector3 position);
                /*0x3817254*/ void SetLookAtPosition(UnityEngine.Vector3 position);
                /*0x3817254*/ void SetFocusLookAtPosition(UnityEngine.Vector3 position);
                /*0x3816f24*/ void ConfigureBlendCamera(float duration);
                /*0x38159dc*/ void ConfigureCutBlendCamera();
                /*0x3815ed0*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x38159dc*/ void EnablePostProcessing();
                /*0x38159dc*/ void DisablePostProcessing();
                Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters);
                Cysharp.Threading.Tasks.UniTask TryEnableActionCamera(string key, bool isEnemyActor, bool isExtraSkill);
                /*0x38159dc*/ void TryDisableActionCamera();
                /*0x38159dc*/ void DetatchFollowAndLook();
                /*0x38159dc*/ void ReattachFollowAndLook();
                /*0x38159dc*/ void TransitionToActiveCameraType();
                /*0x3817254*/ void SetFocusFollowPosition(UnityEngine.Vector3 position);
                /*0x3816710*/ void AddToTargetGroup(UnityEngine.Transform[] targets);
                /*0x3816710*/ void AddToTargetGroup(UnityEngine.Transform target);
                /*0x38159dc*/ void ClearTargetGroup();
                /*0x3815cc4*/ void SetCameraOffset(bool value);
                /*0x3813ffc*/ bool GetCameraOffset();
                /*0x3816f24*/ void SetCameraFocusDistance(float value);
                /*0x3816f24*/ void SetCameraFocusYOffset(float value);
                /*0x3816f24*/ void SetCameraTargetFocusDistance(float value);
                /*0x3816f24*/ void SetCameraTargetFocusYOffset(float value);
                /*0x3817254*/ void SetLookAtStaticPosition(UnityEngine.Vector3 position);
                /*0x3817254*/ void SetFollowStaticPosition(UnityEngine.Vector3 position);
            }

            interface ISharedCockpitOverseer
            {
                /*0x38159dc*/ void ForceHideMinimizedCockpit();
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ICockpitOverseerUnityFacade.Arguments arguments);
                /*0x3816710*/ void ShowMinimizedCockpit(Assets.Utilities.Spine.SkeletonController cockpit);
            }

            interface ISharedFieldOverseer
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IFieldOverseerUnityFacade.Arguments arguments);
                /*0x38159a4*/ UnityEngine.Vector3 AcquireFieldCenterPosition();
                UnityEngine.Vector3 AcquireGroupCenterPosition(bool isEnemyGroup);
                Cysharp.Threading.Tasks.UniTask LoadField(string configurationJson);
                /*0x3815cc4*/ void SetActive(bool active);
                /*0x38148bc*/ UnityEngine.Material[] AcquireFieldMaterials();
            }

            interface ISharedHudOverseer
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x3815cc4*/ void SetIntractability(bool interactable);
            }

            interface ISharedVisualEffectsOverseer
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade.Arguments arguments);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(Assets.VisualEffectData.VfxHandler prefab, UnityEngine.Vector3 position);
                Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAquireMecanimController(string key);
                /*0x3816710*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                /*0x3816710*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                Cysharp.Threading.Tasks.UniTask PlaybackTimeStop(Assets.VisualEffectData.TimeStopParameters parameters);
                /*0x3816710*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x38159dc*/ void ClearFieldMaterials();
                void AddActorRenderer(long id, UnityEngine.Renderer target);
                /*0x381630c*/ void RemoveActorRenderer(long id);
                /*0x38159dc*/ void Update();
                Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAquireVfx(UnityEngine.GameObject prefab);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAquireVfxAnimationHandler(string key);
                UnityEngine.Vector3 AcquireYOffsetedPosition(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 position);
            }

            class SharedActor
            {
                /*0x10*/ Assets.Utilities.Spine.MecanimController <MecanimController>k__BackingField;
                /*0x18*/ int <FieldIndex>k__BackingField;
                /*0x1c*/ float <CameraFocusDistance>k__BackingField;

                /*0x3cbafa4*/ SharedActor(Assets.Utilities.Spine.MecanimController mecanimController, int fieldIndex, float cameraFocusDistance);
                /*0x3cbaf8c*/ Assets.Utilities.Spine.MecanimController get_MecanimController();
                /*0x3cbaf94*/ int get_FieldIndex();
                /*0x3cbaf9c*/ float get_CameraFocusDistance();
            }

            interface ISkillMotionOverseer
            {
                UnityEngine.Vector3 CalculateFocusTarget(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 actorPosition, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                UnityEngine.Vector3[] CalculateTargetsPositions(Assets.VisualEffectData.VfxHandler vfx, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                /*0x3814b04*/ System.Collections.Generic.IAsyncEnumerable<string> MotionEvents(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                Cysharp.Threading.Tasks.UniTask TransitionToFocusCamera(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                Cysharp.Threading.Tasks.UniTask ProcessBoosterActionEvent(Assets.Utilities.Spine.MecanimController actor, Assets.Utilities.Spine.MecanimController.ActionData eventData);
            }

            class SharedSkillMotionOverseer : Assets.Battle.Shared.ISkillMotionOverseer
            {
                /*0x10*/ Assets.Battle.Shared.ISharedVisualEffectsOverseer vfxOverseer;
                /*0x18*/ Assets.Battle.Shared.ISharedCameraOverseer cameraOverseer;
                /*0x20*/ Assets.Battle.Shared.ISharedHudOverseer hudOverseer;
                /*0x28*/ Assets.Battle.Shared.ISharedBattleDataStorageModel model;
                /*0x30*/ Assets.Battle.Shared.ISharedFieldOverseer fieldOverseer;
                /*0x38*/ Assets.Battle.Utilities.IMetronome metronome;
                /*0x40*/ Assets.Battle.Shared.ISharedCockpitOverseer cockpitOverseer;

                static /*0x3cbb348*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes <AcquireTargetFocusCameraType>g__SelectCameraType|10_0(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                static /*0x3cbb6a0*/ UnityEngine.Vector3 <CalculateFocusTarget>g__GetPosition|12_1(Assets.Battle.Shared.SharedActor data, Assets.Battle.Shared.ISharedBattleDataStorageModel model);
                static /*0x3cbcba0*/ void <MotionEvents>g__Continue|19_3(string key, System.Collections.Generic.Queue<string> queue, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                static /*0x3cbcc14*/ void <MotionEvents>g__End|19_4(System.Threading.CancellationTokenSource cancellationTokenSource, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3cbaff0*/ SharedSkillMotionOverseer(Assets.Battle.Shared.ISharedVisualEffectsOverseer vfxOverseer, Assets.Battle.Shared.ISharedCameraOverseer cameraOverseer, Assets.Battle.Shared.ISharedHudOverseer hudOverseer, Assets.Battle.Shared.ISharedBattleDataStorageModel model, Assets.Battle.Shared.ISharedFieldOverseer fieldOverseer, Assets.Battle.Utilities.IMetronome metronome, Assets.Battle.Shared.ISharedCockpitOverseer cockpitOverseer);
                /*0x3cbb0b0*/ Cysharp.Threading.Tasks.UniTask TransitionToFocusCamera(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cbb18c*/ Cysharp.Threading.Tasks.UniTask TransitionToTargetFocusCamera(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cbb268*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes AcquireTargetFocusCameraType(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cbb3b0*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes AcquireFocusCameraType(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cbb3e4*/ UnityEngine.Vector3 CalculateFocusTarget(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 actorPosition, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                /*0x3cbb774*/ System.Nullable<UnityEngine.Vector3> TryAcquireVfxPosition(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3[] positions, bool isEnemyIsTarget);
                /*0x3cbb940*/ UnityEngine.Vector3[] CalculateTargetsPositions(Assets.VisualEffectData.VfxHandler vfx, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                /*0x3cbbd18*/ UnityEngine.Vector3 AcquireMecanimDamagePoint(Assets.VisualEffectData.ProjectileEmitter emitter, Assets.Battle.Shared.SharedActor actor);
                /*0x3cbbdf8*/ UnityEngine.Vector3 AcquireMecanimDamagePoint(Assets.Battle.Shared.SharedActor actor);
                /*0x3cbbe88*/ Cysharp.Threading.Tasks.UniTask ProcessBoosterActionEvent(Assets.Utilities.Spine.MecanimController mecanim, Assets.Utilities.Spine.MecanimController.ActionData eventData);
                /*0x3cbbf7c*/ Cysharp.Threading.Tasks.UniTask ProcessJumpAction(Assets.Utilities.Spine.MecanimController.ActionData eventData, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, UnityEngine.Vector3 actorPosition, UnityEngine.Vector3 targetPosition);
                /*0x3cbc0b4*/ System.Collections.Generic.IAsyncEnumerable<string> MotionEvents(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                /*0x3cbc158*/ Cysharp.Threading.Tasks.UniTask ProcessExtraSkillVfxEvent(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                /*0x3cbc25c*/ Cysharp.Threading.Tasks.UniTask ProcessCutInSkillVfxEvent(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                /*0x3cbc35c*/ Assets.Utilities.Spine.SkeletonController.AnimationTypes AcquireAnimationType(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cbc364*/ Cysharp.Threading.Tasks.UniTask ProcessSkillVfxEvent(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Action continuationCallback, System.Action endCallback);
                /*0x3cbc464*/ Cysharp.Threading.Tasks.UniTask ProcessSegment(Assets.VisualEffectData.LineSegmentHandler segmentHanler, UnityEngine.Vector3 origin, UnityEngine.Vector3[] emitters, UnityEngine.Vector3 target, string vfxName);
                /*0x3cbc5c0*/ void ProcessAreaVfx(Assets.VisualEffectData.VfxHandler prefab, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cbc97c*/ Cysharp.Threading.Tasks.UniTask ProcessProjectileEmission(Assets.VisualEffectData.ProjectileEmitter emitter, UnityEngine.Vector3[] targets, UnityEngine.Vector3[] emissionPoints, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Action continuationCallback, System.Action endCallback);
                /*0x3cbcad4*/ UnityEngine.Vector3 TryToApplyDeviation(UnityEngine.Vector3 position, float radius);
                /*0x3cbcb2c*/ UnityEngine.Quaternion CalculateRotation(UnityEngine.Quaternion rotation, bool isEnemyActor);
                /*0x3cbcb90*/ UnityEngine.Vector3 <CalculateFocusTarget>b__12_0(Assets.Battle.Shared.SharedActor t);

                class SkillData
                {
                    /*0x10*/ Assets.Battle.Shared.SharedActor <Actor>k__BackingField;
                    /*0x18*/ Assets.Battle.Shared.SharedActor[] <Targets>k__BackingField;
                    /*0x20*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> <Tasks>k__BackingField;
                    /*0x28*/ System.Func<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData, Cysharp.Threading.Tasks.UniTask> <ShowSkillLabel>k__BackingField;
                    /*0x30*/ UnityEngine.Vector3 <TargetPosition>k__BackingField;
                    /*0x40*/ Assets.Utilities.Spine.SkeletonController <Cockpit>k__BackingField;
                    /*0x48*/ Assets.VisualEffectData.VfxHandler <Vfx>k__BackingField;
                    /*0x50*/ Assets.VisualEffectData.VfxTargetOverride <VfxTargetOverride>k__BackingField;
                    /*0x58*/ string <MotionName>k__BackingField;
                    /*0x60*/ string <MotionFlowName>k__BackingField;
                    /*0x68*/ string <SubsequentFlowName>k__BackingField;
                    /*0x70*/ string <JumpActionOverride>k__BackingField;
                    /*0x78*/ string <BoneTag>k__BackingField;
                    /*0x80*/ string <ExtraSkillAssetId>k__BackingField;
                    /*0x88*/ string <CutInAssetId>k__BackingField;
                    /*0x90*/ string <CameraAssetId>k__BackingField;
                    /*0x98*/ string <Name>k__BackingField;
                    /*0xa0*/ int <Type>k__BackingField;
                    /*0xa4*/ int <ResourceCost>k__BackingField;
                    /*0xa8*/ bool <IsEnemyActor>k__BackingField;
                    /*0xa9*/ bool <IsEnemyIsTarget>k__BackingField;
                    /*0xaa*/ bool <IsTargetSelf>k__BackingField;
                    /*0xab*/ bool <IsTargetFriendly>k__BackingField;
                    /*0xac*/ bool <LargeScaleMecanim>k__BackingField;
                    /*0xad*/ bool <HasLargeScaleMecanimTarget>k__BackingField;
                    /*0xb0*/ UnityEngine.Vector3 <ActorTruePosition>k__BackingField;

                    /*0x3cbdaa8*/ SkillData(Assets.Battle.Shared.SharedActor actor, Assets.Battle.Shared.SharedActor[] targets, System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> tasks, System.Func<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData, Cysharp.Threading.Tasks.UniTask> showSkillLabel);
                    /*0x3cbd900*/ Assets.Battle.Shared.SharedActor get_Actor();
                    /*0x3cbd908*/ Assets.Battle.Shared.SharedActor[] get_Targets();
                    /*0x3cbd910*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> get_Tasks();
                    /*0x3cbd918*/ System.Func<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData, Cysharp.Threading.Tasks.UniTask> get_ShowSkillLabel();
                    /*0x3cbd920*/ UnityEngine.Vector3 get_TargetPosition();
                    /*0x3cbd92c*/ void set_TargetPosition(UnityEngine.Vector3 value);
                    /*0x3cbd938*/ Assets.Utilities.Spine.SkeletonController get_Cockpit();
                    /*0x3cbd940*/ void set_Cockpit(Assets.Utilities.Spine.SkeletonController value);
                    /*0x3cbd948*/ Assets.VisualEffectData.VfxHandler get_Vfx();
                    /*0x3cbd950*/ void set_Vfx(Assets.VisualEffectData.VfxHandler value);
                    /*0x3cbd958*/ Assets.VisualEffectData.VfxTargetOverride get_VfxTargetOverride();
                    /*0x3cbd960*/ void set_VfxTargetOverride(Assets.VisualEffectData.VfxTargetOverride value);
                    /*0x3cbd968*/ string get_MotionName();
                    /*0x3cbd970*/ void set_MotionName(string value);
                    /*0x3cbd978*/ string get_MotionFlowName();
                    /*0x3cbd980*/ void set_MotionFlowName(string value);
                    /*0x3cbd988*/ string get_SubsequentFlowName();
                    /*0x3cbd990*/ void set_SubsequentFlowName(string value);
                    /*0x3cbd998*/ string get_JumpActionOverride();
                    /*0x3cbd9a0*/ void set_JumpActionOverride(string value);
                    /*0x3cbd9a8*/ string get_BoneTag();
                    /*0x3cbd9b0*/ void set_BoneTag(string value);
                    /*0x3cbd9b8*/ string get_ExtraSkillAssetId();
                    /*0x3cbd9c0*/ void set_ExtraSkillAssetId(string value);
                    /*0x3cbd9c8*/ string get_CutInAssetId();
                    /*0x3cbd9d0*/ void set_CutInAssetId(string value);
                    /*0x3cbd9d8*/ string get_CameraAssetId();
                    /*0x3cbd9e0*/ void set_CameraAssetId(string value);
                    /*0x3cbd9e8*/ string get_Name();
                    /*0x3cbd9f0*/ void set_Name(string value);
                    /*0x3cbd9f8*/ int get_Type();
                    /*0x3cbda00*/ void set_Type(int value);
                    /*0x3cbda08*/ int get_ResourceCost();
                    /*0x3cbda10*/ void set_ResourceCost(int value);
                    /*0x3cbda18*/ bool get_IsEnemyActor();
                    /*0x3cbda20*/ void set_IsEnemyActor(bool value);
                    /*0x3cbda2c*/ bool get_IsEnemyIsTarget();
                    /*0x3cbda34*/ void set_IsEnemyIsTarget(bool value);
                    /*0x3cbda40*/ bool get_IsTargetSelf();
                    /*0x3cbda48*/ void set_IsTargetSelf(bool value);
                    /*0x3cbda54*/ bool get_IsTargetFriendly();
                    /*0x3cbda5c*/ void set_IsTargetFriendly(bool value);
                    /*0x3cbda68*/ bool get_LargeScaleMecanim();
                    /*0x3cbda70*/ void set_LargeScaleMecanim(bool value);
                    /*0x3cbda7c*/ bool get_HasLargeScaleMecanimTarget();
                    /*0x3cbda84*/ void set_HasLargeScaleMecanimTarget(bool value);
                    /*0x3cbda90*/ UnityEngine.Vector3 get_ActorTruePosition();
                    /*0x3cbda9c*/ void set_ActorTruePosition(UnityEngine.Vector3 value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Shared.SharedActor, UnityEngine.Transform> <>9__9_0;
                    static /*0x10*/ System.Func<Assets.Battle.Shared.SharedActor, UnityEngine.Vector3> <>9__14_0;
                    static /*0x18*/ System.Func<Assets.Battle.Shared.SharedActor, UnityEngine.Vector3> <>9__25_0;

                    static /*0x3cbdc04*/ <>c();
                    /*0x3cbdc6c*/ <>c();
                    /*0x3cbdc74*/ UnityEngine.Transform <TransitionToTargetFocusCamera>b__9_0(Assets.Battle.Shared.SharedActor t);
                    /*0x3cbdc94*/ UnityEngine.Vector3 <CalculateTargetsPositions>b__14_0(Assets.Battle.Shared.SharedActor t);
                    /*0x3cbdcc0*/ UnityEngine.Vector3 <ProcessAreaVfx>b__25_0(Assets.Battle.Shared.SharedActor m);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x18*/ Assets.VisualEffectData.VfxHandler vfx;

                    /*0x3cbdcec*/ <>c__DisplayClass14_0();
                    /*0x3cbdcf4*/ UnityEngine.Vector3 <CalculateTargetsPositions>b__1(Assets.Battle.Shared.SharedActor t);
                    /*0x3cbdd20*/ UnityEngine.Vector3 <CalculateTargetsPositions>b__2(UnityEngine.Vector3 p);
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;

                    /*0x3cbddfc*/ <>c__DisplayClass17_0();
                    /*0x3cbde04*/ bool <ProcessBoosterActionEvent>b__0(Spine.Unity.BoneFollower b);
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ UnityEngine.Vector3 actorPosition;
                    /*0x1c*/ UnityEngine.Vector3 targetPosition;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;

                    /*0x3cbde3c*/ <>c__DisplayClass18_0();
                    /*0x3cbde44*/ Cysharp.Threading.Tasks.UniTask <ProcessJumpAction>g__ProcessSlideAction|0(float firstPoint, float secondPoint);

                    struct <<ProcessJumpAction>g__ProcessSlideAction|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x30*/ float firstPoint;
                        /*0x34*/ float secondPoint;
                        /*0x38*/ UnityEngine.Vector3 <firstPerpendicularPoint>5__2;
                        /*0x44*/ UnityEngine.Vector3 <secondPerpendicularPoint>5__3;
                        /*0x50*/ UnityEngine.Quaternion <rotation>5__4;
                        /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cbdf08*/ void MoveNext();
                        /*0x3cbf0d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x18*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x20*/ System.Threading.CancellationTokenSource cancellationTokenSource;
                    /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x30*/ System.Threading.CancellationToken cancellationToken;
                    /*0x38*/ System.Collections.Generic.Queue<string> queue;
                    /*0x40*/ DG.Tweening.TweenCallback <>9__12;
                    /*0x48*/ DG.Tweening.TweenCallback <>9__13;
                    /*0x50*/ System.Action <>9__14;
                    /*0x58*/ System.Action <>9__15;
                    /*0x60*/ System.Action <>9__16;
                    /*0x68*/ System.Action <>9__17;
                    /*0x70*/ System.Func<bool> <>9__18;

                    /*0x3cbf0e4*/ <>c__DisplayClass19_0();
                    /*0x3cbf0ec*/ void <MotionEvents>b__12();
                    /*0x3cbf11c*/ void <MotionEvents>b__13();
                    /*0x3cbf14c*/ void <MotionEvents>b__7();
                    /*0x3cbf1fc*/ void <MotionEvents>b__8();
                    /*0x3cbf2ac*/ void <MotionEvents>b__9();
                    /*0x3cbf35c*/ void <MotionEvents>b__14();
                    /*0x3cbf388*/ void <MotionEvents>b__15();
                    /*0x3cbf448*/ void <MotionEvents>b__10(Assets.Utilities.Spine.MecanimController.VisualEffectData vfxData);
                    /*0x3cbf51c*/ void <MotionEvents>b__11(string value);
                    /*0x3cbf5dc*/ Cysharp.Threading.Tasks.UniTask <MotionEvents>b__0();
                    /*0x3cbf6ec*/ void <MotionEvents>b__16();
                    /*0x3cbf718*/ void <MotionEvents>b__17();
                    /*0x3cbf728*/ void <MotionEvents>b__1();
                    /*0x3cbf754*/ void <MotionEvents>b__2();
                    /*0x3cbf764*/ bool <MotionEvents>b__18();

                    struct <<MotionEvents>b__10>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Utilities.Spine.MecanimController.VisualEffectData vfxData;
                        /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;
                        /*0x60*/ string[] <>7__wrap1;
                        /*0x68*/ int <>7__wrap2;

                        /*0x3cbf78c*/ void MoveNext();
                        /*0x3cc0068*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__7>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc0074*/ void MoveNext();
                        /*0x3cc039c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__8>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc03a8*/ void MoveNext();
                        /*0x3cc06d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__9>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc06dc*/ void MoveNext();
                        /*0x3cc0ad4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass19_1
                {
                    /*0x10*/ UnityEngine.Vector3 actorPosition;
                    /*0x1c*/ UnityEngine.Vector3 targetPosition;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> CS$<>8__locals1;

                    /*0x3cc0ae0*/ <>c__DisplayClass19_1();
                    /*0x3cc0ae8*/ void <MotionEvents>b__5(Assets.Utilities.Spine.MecanimController.ActionData eventData);
                    /*0x3cc0bbc*/ void <MotionEvents>b__6(Assets.Utilities.Spine.MecanimController.ActionData eventData);

                    struct <<MotionEvents>b__5>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;
                        /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc0c90*/ void MoveNext();
                        /*0x3cc1264*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__6>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;
                        /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc1270*/ void MoveNext();
                        /*0x3cc1a30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource extraSkillCompletionSource;

                    /*0x3cc1a3c*/ <>c__DisplayClass20_0();
                    /*0x3cc1a44*/ void <ProcessExtraSkillVfxEvent>b__0(string motionName);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource cutInCompletionSource;

                    /*0x3cc1a60*/ <>c__DisplayClass21_0();
                    /*0x3cc1a68*/ void <ProcessCutInSkillVfxEvent>b__0();
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ System.Action continuationCallback;
                    /*0x18*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x20*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x28*/ Assets.VisualEffectData.VfxHandler vfx;
                    /*0x30*/ System.Action endCallback;

                    /*0x3cc1a84*/ <>c__DisplayClass23_0();
                    /*0x3cc1a8c*/ void <ProcessSkillVfxEvent>b__0(Assets.VisualEffectData.VfxHandler afterEffectPrefab);
                    /*0x3cc1d08*/ void <ProcessSkillVfxEvent>b__1();
                }

                class <>c__DisplayClass26_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x18*/ Assets.VisualEffectData.ProjectileEmitter emitter;
                    /*0x20*/ System.Action continuationCallback;
                    /*0x28*/ System.Action endCallback;

                    /*0x3cc1d58*/ <>c__DisplayClass26_0();
                    /*0x3cc1d60*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> <ProcessProjectileEmission>b__0(UnityEngine.GameObject prefab);
                    /*0x3cc1e78*/ void <ProcessProjectileEmission>b__1();
                    /*0x3cc1ec0*/ void <ProcessProjectileEmission>b__2();

                    struct <<ProcessProjectileEmission>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                        /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x38*/ UnityEngine.GameObject prefab;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                        /*0x3cc1f08*/ void MoveNext();
                        /*0x3cc24a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <MotionEvents>d__19 : System.Collections.Generic.IAsyncEnumerable<string>, System.Collections.Generic.IAsyncEnumerator<string>, System.IAsyncDisposable, System.Threading.Tasks.Sources.IValueTaskSource<bool>, System.Threading.Tasks.Sources.IValueTaskSource, System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncIteratorMethodBuilder <>t__builder;
                    /*0x30*/ System.Threading.Tasks.Sources.ManualResetValueTaskSourceCore<bool> <>v__promiseOfValueOrEnd;
                    /*0x68*/ string <>2__current;
                    /*0x70*/ bool <>w__disposeMode;
                    /*0x78*/ System.Threading.CancellationTokenSource <>x__combinedTokens;
                    /*0x80*/ int <>l__initialThreadId;
                    /*0x88*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x90*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x98*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData <>3__data;
                    /*0xa0*/ System.Threading.CancellationToken cancellationToken;
                    /*0xa8*/ System.Threading.CancellationToken <>3__cancellationToken;
                    /*0xb0*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__1;
                    /*0xb8*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__2;
                    /*0xc0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0xd0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<int> <>u__2;

                    /*0x3cc24fc*/ <MotionEvents>d__19(int <>1__state);
                    /*0x3cc2568*/ void MoveNext();
                    /*0x3cc4674*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    /*0x3cc4678*/ System.Collections.Generic.IAsyncEnumerator<string> System.Collections.Generic.IAsyncEnumerable<System.String>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);
                    /*0x3cc4874*/ System.Threading.Tasks.ValueTask<bool> System.Collections.Generic.IAsyncEnumerator<System.String>.MoveNextAsync();
                    /*0x3cc49ec*/ string System.Collections.Generic.IAsyncEnumerator<System.String>.get_Current();
                    /*0x3cc49f4*/ bool System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetResult(short token);
                    /*0x3cc4a4c*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetStatus(short token);
                    /*0x3cc4aa4*/ void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x3cc4b1c*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x3cc4b74*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(short token);
                    /*0x3cc4bcc*/ void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x3cc4c44*/ System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync();
                }

                struct <ProcessBoosterActionEvent>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;
                    /*0x30*/ Assets.Utilities.Spine.MecanimController mecanim;
                    /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__1;
                    /*0x48*/ Spine.Unity.BoneFollower[] <bones>5__2;
                    /*0x50*/ Assets.VisualEffectData.VfxHandler[] <vfxHandlers>5__3;
                    /*0x58*/ int <i>5__4;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3cc4d5c*/ void MoveNext();
                    /*0x3cc5668*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessCutInSkillVfxEvent>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__1;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ Assets.VisualEffectData.VfxAnimationHandler <vfx>5__2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxAnimationHandler> <>u__1;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3cc5674*/ void MoveNext();
                    /*0x3cc6478*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessExtraSkillVfxEvent>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__1;
                    /*0x40*/ System.Threading.CancellationToken cancellationToken;
                    /*0x48*/ Assets.Utilities.Spine.MecanimController <mecanim>5__2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.MecanimController> <>u__1;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;
                    /*0x78*/ object <>7__wrap2;
                    /*0x80*/ int <>7__wrap3;

                    /*0x3cc6484*/ void MoveNext();
                    /*0x3cc81e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessJumpAction>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ UnityEngine.Vector3 actorPosition;
                    /*0x34*/ UnityEngine.Vector3 targetPosition;
                    /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x48*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x50*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;
                    /*0x58*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cc81f0*/ void MoveNext();
                    /*0x3cc8fb8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessProjectileEmission>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x30*/ Assets.VisualEffectData.ProjectileEmitter emitter;
                    /*0x38*/ System.Action continuationCallback;
                    /*0x40*/ System.Action endCallback;
                    /*0x48*/ UnityEngine.Vector3[] targets;
                    /*0x50*/ UnityEngine.Vector3[] emissionPoints;
                    /*0x58*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cc8fc4*/ void MoveNext();
                    /*0x3cc96e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessSegment>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x30*/ UnityEngine.Vector3 target;
                    /*0x40*/ Assets.VisualEffectData.LineSegmentHandler segmentHanler;
                    /*0x48*/ UnityEngine.Vector3[] emitters;
                    /*0x50*/ string vfxName;
                    /*0x58*/ UnityEngine.Vector3 origin;
                    /*0x64*/ int <i>5__2;
                    /*0x68*/ UnityEngine.Vector3 <targetPosition>5__3;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3cc96f0*/ void MoveNext();
                    /*0x3cc9df0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessSkillVfxEvent>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ System.Action continuationCallback;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x40*/ System.Action endCallback;
                    /*0x48*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>8__1;
                    /*0x50*/ UnityEngine.Vector3[] <emitters>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;
                    /*0x80*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> <operations>5__3;
                    /*0x88*/ Assets.VisualEffectData.CustomProjectileEmitter[] <>7__wrap3;
                    /*0x90*/ int <>7__wrap4;
                    /*0x98*/ Assets.VisualEffectData.CustomProjectileEmitter <item>5__6;
                    /*0xa0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__3;

                    /*0x3cc9dfc*/ void MoveNext();
                    /*0x3ccc2b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToFocusCamera>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x38*/ UnityEngine.Transform <actorTransform>5__2;
                    /*0x40*/ UnityEngine.Vector3 <lookFromDirection>5__3;
                    /*0x4c*/ float <distanceToFocusPoint>5__4;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ccc2c0*/ void MoveNext();
                    /*0x3ccdb60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToTargetFocusCamera>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ccdb6c*/ void MoveNext();
                    /*0x3cce6b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            namespace Playground
            {
                class SharedPlaygroundEntryPoint : VContainer.Unity.IAsyncStartable
                {
                    static /*0x0*/ bool <InitializeFinished>k__BackingField;
                    /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;

                    static /*0x3cce6c4*/ bool get_InitializeFinished();
                    static /*0x3cce70c*/ void set_InitializeFinished(bool value);
                    /*0x3cce75c*/ SharedPlaygroundEntryPoint(Assets.AssetManagement.IAddressablesAssetProvider assetProvider);
                    /*0x3cce78c*/ Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken cancellation);

                    struct <StartAsync>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundEntryPoint <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cce838*/ void MoveNext();
                        /*0x3ccee60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class SharedPlaygroundLifetimeScope : VContainer.Unity.LifetimeScope
                {
                    /*0x68*/ Assets.GameUi.Externals.AudioManager audioManager;
                    /*0x70*/ Assets.GameUi.Externals.CameraManager cameraManager;
                    /*0x78*/ Assets.AssetManagement.UnusedInstanceManager unusedInstanceManager;

                    /*0x3ccf064*/ SharedPlaygroundLifetimeScope();
                    /*0x3ccee6c*/ void Configure(VContainer.IContainerBuilder builder);
                }

                class SharedPlaygroundManager : UnityEngine.UCSMonoBehaviour
                {
                    /*0x38*/ UnityEngine.Transform actorsParent;
                    /*0x40*/ UnityEngine.Transform[] actorPositions;
                    /*0x48*/ UnityEngine.GameObject fieldLegend;
                    /*0x50*/ UnityEngine.GameObject fieldBase;
                    /*0x58*/ Assets.Battle.Shared.Playground.Hud.SharedPlaygroundHud hud;
                    /*0x60*/ UnityEngine.UI.Image minimizedCockpitOverlay;
                    /*0x68*/ UnityEngine.CanvasGroup minimizedCockpitUnderlay;
                    /*0x70*/ UnityEngine.Transform minimizedCockpitLayer;
                    /*0x78*/ Assets.Battle.Accessors.CinemachineLayoutAccessor cinemachineLayoutAccessor;
                    /*0x80*/ Unity.Cinemachine.NoiseSettings shakeNoise;
                    /*0x88*/ Unity.Cinemachine.NoiseSettings wobbleNoise;
                    /*0x90*/ UnityEngine.Rendering.Volume postProcessingVolume;
                    /*0x98*/ UnityEngine.Transform visualEffectsLayer;
                    /*0xa0*/ UnityEngine.Transform overlayLayer;
                    /*0xa8*/ UnityEngine.Transform fieldCenter;
                    /*0xb0*/ UnityEngine.Transform playerGroupCenter;
                    /*0xb8*/ UnityEngine.Transform enemyGroupCenter;
                    /*0xc0*/ Assets.Battle.Shared.Playground.ActorData[] players;
                    /*0xc8*/ Assets.Battle.Shared.Playground.ActorData[] enemies;
                    /*0xd0*/ string vfxAssetKey;
                    /*0xd8*/ string motionName;
                    /*0xe0*/ string subsequentMotionName;
                    /*0xe8*/ string jumpActionOverride;
                    /*0xf0*/ string extraSkillAssetKey;
                    /*0xf8*/ string cameraAssetKey;
                    /*0x100*/ string eventVfxAssetKey;
                    /*0x108*/ string cutInAssetKey;
                    /*0x110*/ string cockpitAssetId;
                    /*0x118*/ bool triggerPlayerSkill;
                    /*0x119*/ bool triggerEnemySkill;
                    /*0x11a*/ bool reloadMecanims;
                    /*0x120*/ Assets.AssetManagement.IAssetInstanceProvider <InstanceProvider>k__BackingField;
                    /*0x128*/ Assets.Battle.Shared.ISkillMotionOverseer <SkillMotionOverseer>k__BackingField;
                    /*0x130*/ Assets.Battle.Shared.ISharedCameraOverseer <CameraOverseer>k__BackingField;
                    /*0x138*/ Assets.Battle.Shared.ISharedVisualEffectsOverseer <VfxOverseer>k__BackingField;
                    /*0x140*/ Assets.Battle.Shared.ISharedFieldOverseer <FieldOverseer>k__BackingField;
                    /*0x148*/ Assets.Battle.Shared.ISharedHudOverseer <HudOverseer>k__BackingField;
                    /*0x150*/ Assets.Battle.Shared.ISharedBattleDataStorageModel <BattleDataStorageModel>k__BackingField;
                    /*0x158*/ Assets.Battle.Shared.ISharedCockpitOverseer <CockpitOverseer>k__BackingField;
                    /*0x160*/ Assets.Battle.Utilities.IMetronome <Metronome>k__BackingField;
                    /*0x168*/ Assets.GameUi.Header.IHeaderComponent <Header>k__BackingField;
                    /*0x170*/ Assets.GameUi.Externals.IBackgroundManager <BackgroundManager>k__BackingField;
                    /*0x178*/ Assets.Battle.Shared.Playground.TargetData[] playerMechas;
                    /*0x180*/ Assets.Battle.Shared.Playground.TargetData[] enemyMechas;
                    /*0x188*/ Assets.Utilities.Spine.SkeletonController cockpit;
                    /*0x190*/ bool processing;

                    static /*0x3cd0ad0*/ string <CreateSkillData>g__AcquireMotionName|83_1(string motionName);
                    static /*0x3cd0ba8*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Shared.Playground.TargetData[]> <LoadMecanims>g__CreateMechas|86_0(Assets.Battle.Shared.Playground.ActorData[] data, UnityEngine.Transform[] positions, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, UnityEngine.Transform parent, string suffix);
                    static /*0x3cd0d14*/ void <LoadMecanims>g__AddYHardRotation|86_1(UnityEngine.GameObject target);
                    /*0x3cd04e4*/ SharedPlaygroundManager();
                    /*0x3ccf0bc*/ Assets.AssetManagement.IAssetInstanceProvider get_InstanceProvider();
                    /*0x3ccf0c4*/ void set_InstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                    /*0x3ccf0d4*/ Assets.Battle.Shared.ISkillMotionOverseer get_SkillMotionOverseer();
                    /*0x3ccf0dc*/ void set_SkillMotionOverseer(Assets.Battle.Shared.ISkillMotionOverseer value);
                    /*0x3ccf0ec*/ Assets.Battle.Shared.ISharedCameraOverseer get_CameraOverseer();
                    /*0x3ccf0f4*/ void set_CameraOverseer(Assets.Battle.Shared.ISharedCameraOverseer value);
                    /*0x3ccf104*/ Assets.Battle.Shared.ISharedVisualEffectsOverseer get_VfxOverseer();
                    /*0x3ccf10c*/ void set_VfxOverseer(Assets.Battle.Shared.ISharedVisualEffectsOverseer value);
                    /*0x3ccf11c*/ Assets.Battle.Shared.ISharedFieldOverseer get_FieldOverseer();
                    /*0x3ccf124*/ void set_FieldOverseer(Assets.Battle.Shared.ISharedFieldOverseer value);
                    /*0x3ccf134*/ Assets.Battle.Shared.ISharedHudOverseer get_HudOverseer();
                    /*0x3ccf13c*/ void set_HudOverseer(Assets.Battle.Shared.ISharedHudOverseer value);
                    /*0x3ccf14c*/ Assets.Battle.Shared.ISharedBattleDataStorageModel get_BattleDataStorageModel();
                    /*0x3ccf154*/ void set_BattleDataStorageModel(Assets.Battle.Shared.ISharedBattleDataStorageModel value);
                    /*0x3ccf164*/ Assets.Battle.Shared.ISharedCockpitOverseer get_CockpitOverseer();
                    /*0x3ccf16c*/ void set_CockpitOverseer(Assets.Battle.Shared.ISharedCockpitOverseer value);
                    /*0x3ccf17c*/ Assets.Battle.Utilities.IMetronome get_Metronome();
                    /*0x3ccf184*/ void set_Metronome(Assets.Battle.Utilities.IMetronome value);
                    /*0x3ccf194*/ Assets.GameUi.Header.IHeaderComponent get_Header();
                    /*0x3ccf19c*/ void set_Header(Assets.GameUi.Header.IHeaderComponent value);
                    /*0x3ccf1ac*/ Assets.GameUi.Externals.IBackgroundManager get_BackgroundManager();
                    /*0x3ccf1b4*/ void set_BackgroundManager(Assets.GameUi.Externals.IBackgroundManager value);
                    /*0x3ccf1c4*/ void Awake();
                    /*0x3ccf76c*/ void PrepareForSkillUse();
                    /*0x3ccfaa8*/ void Update();
                    /*0x3cd00b4*/ Cysharp.Threading.Tasks.UniTask ProcessSkillUse(Assets.Battle.Shared.Playground.TargetData actor, Assets.Battle.Shared.Playground.TargetData[] targets, bool isEnemyActor);
                    /*0x3cd0258*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> CreateSkillData(Assets.Battle.Shared.Playground.TargetData actor, Assets.Battle.Shared.Playground.TargetData[] targets, bool isEnemyActor);
                    /*0x3cd03a0*/ Cysharp.Threading.Tasks.UniTask TryEnableMinimizedCockpit(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                    /*0x3ccf6c0*/ Cysharp.Threading.Tasks.UniTask Process();
                    /*0x3cd01a8*/ Cysharp.Threading.Tasks.UniTask LoadMecanims();
                    /*0x3cd080c*/ void <Awake>b__79_0(Assets.Battle.Shared.Playground.ActorData[] playerData, Assets.Battle.Shared.Playground.ActorData[] enemyData);
                    /*0x3cd0848*/ void <Awake>b__79_1();
                    /*0x3cd0864*/ void <Awake>b__79_2();
                    /*0x3cd0880*/ void <Awake>b__79_3();
                    /*0x3cd0928*/ void <Awake>b__79_4();
                    /*0x3cd095c*/ Cysharp.Threading.Tasks.UniTask <Awake>b__79_5();
                    /*0x3cd0a08*/ Cysharp.Threading.Tasks.UniTask <Awake>b__79_6();
                    /*0x3cd0ab4*/ bool <Update>b__81_3();
                    /*0x3cd0ac0*/ bool <Update>b__81_2();
                    /*0x3cd0acc*/ Cysharp.Threading.Tasks.UniTask <CreateSkillData>b__83_2(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);

                    struct <<Awake>b__79_5>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cd0e04*/ void MoveNext();
                        /*0x3cd1524*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<Awake>b__79_6>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cd1530*/ void MoveNext();
                        /*0x3cd1a84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<LoadMecanims>g__CreateMechas|86_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Shared.Playground.TargetData[]> <>t__builder;
                        /*0x30*/ Assets.Battle.Shared.Playground.ActorData[] data;
                        /*0x38*/ Assets.AssetManagement.IAssetInstanceProvider instanceProvider;
                        /*0x40*/ string suffix;
                        /*0x48*/ UnityEngine.Transform parent;
                        /*0x50*/ UnityEngine.Transform[] positions;
                        /*0x58*/ Assets.Battle.Shared.Playground.TargetData[] <buffer>5__2;
                        /*0x60*/ int <i>5__3;
                        /*0x68*/ Assets.Battle.Shared.Playground.ActorData <item>5__4;
                        /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.MecanimController> <>u__1;

                        /*0x3cd1a90*/ void MoveNext();
                        /*0x3cd2338*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager.<> <>9;
                        static /*0x8*/ System.Func<Assets.Battle.Shared.Playground.ActorData, bool> <>9__81_0;
                        static /*0x10*/ System.Func<Assets.Battle.Shared.Playground.ActorData, bool> <>9__81_1;
                        static /*0x18*/ System.Func<Assets.Battle.Shared.Playground.TargetData, Assets.Battle.Shared.SharedActor> <>9__83_0;
                        static /*0x20*/ System.Func<Assets.Battle.Shared.Playground.TargetData, bool> <>9__83_3;
                        static /*0x28*/ System.Func<UnityEngine.Transform, UnityEngine.Vector3> <>9__85_0;

                        static /*0x3cd2390*/ <>c();
                        /*0x3cd23f8*/ <>c();
                        /*0x3cd2400*/ bool <Update>b__81_0(Assets.Battle.Shared.Playground.ActorData p);
                        /*0x3cd2478*/ bool <Update>b__81_1(Assets.Battle.Shared.Playground.ActorData e);
                        /*0x3cd24f0*/ Assets.Battle.Shared.SharedActor <CreateSkillData>b__83_0(Assets.Battle.Shared.Playground.TargetData t);
                        /*0x3cd2570*/ bool <CreateSkillData>b__83_3(Assets.Battle.Shared.Playground.TargetData t);
                        /*0x3cd2604*/ UnityEngine.Vector3 <Process>b__85_0(UnityEngine.Transform p);
                    }

                    struct <CreateSkillData>d__83 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> <>t__builder;
                        /*0x30*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x38*/ Assets.Battle.Shared.Playground.TargetData actor;
                        /*0x40*/ Assets.Battle.Shared.Playground.TargetData[] targets;
                        /*0x48*/ bool isEnemyActor;
                        /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                        /*0x3cd2648*/ void MoveNext();
                        /*0x3cd32e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <LoadMecanims>d__86 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Shared.Playground.TargetData[]> <>u__1;

                        /*0x3cd3338*/ void MoveNext();
                        /*0x3cd3ebc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <Process>d__85 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cd3ec8*/ void MoveNext();
                        /*0x3cd4968*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ProcessSkillUse>d__82 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Assets.Battle.Shared.Playground.TargetData actor;
                        /*0x38*/ Assets.Battle.Shared.Playground.TargetData[] targets;
                        /*0x40*/ bool isEnemyActor;
                        /*0x48*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData <data>5__2;
                        /*0x50*/ bool <triggeredEventVfx>5__3;
                        /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.SkeletonController> <>u__1;
                        /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> <>u__2;
                        /*0x88*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__3;
                        /*0x98*/ System.Runtime.CompilerServices.ConfiguredCancelableAsyncEnumerable.Enumerator<string> <>7__wrap3;
                        /*0xa8*/ object <>7__wrap4;
                        /*0xb0*/ int <>7__wrap5;
                        /*0xb8*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<bool> <>u__4;
                        /*0xc8*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__5;

                        /*0x3cd4974*/ void MoveNext();
                        /*0x3cd6048*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ActorData
                {
                    /*0x10*/ string <AssetKey>k__BackingField;
                    /*0x18*/ int <PositionIndex>k__BackingField;
                    /*0x1c*/ float <Scale>k__BackingField;
                    /*0x20*/ float <CameraDistance>k__BackingField;

                    /*0x3cd6094*/ ActorData();
                    /*0x3cd6054*/ string get_AssetKey();
                    /*0x3cd605c*/ void set_AssetKey(string value);
                    /*0x3cd6064*/ int get_PositionIndex();
                    /*0x3cd606c*/ void set_PositionIndex(int value);
                    /*0x3cd6074*/ float get_Scale();
                    /*0x3cd607c*/ void set_Scale(float value);
                    /*0x3cd6084*/ float get_CameraDistance();
                    /*0x3cd608c*/ void set_CameraDistance(float value);
                }

                class TargetData
                {
                    /*0x10*/ Assets.Utilities.Spine.MecanimController <Mecnaim>k__BackingField;
                    /*0x18*/ Assets.Battle.Shared.Playground.ActorData <ActorData>k__BackingField;

                    /*0x3cd2330*/ TargetData();
                    /*0x3cd60c8*/ Assets.Utilities.Spine.MecanimController get_Mecnaim();
                    /*0x3cd60d0*/ void set_Mecnaim(Assets.Utilities.Spine.MecanimController value);
                    /*0x3cd60d8*/ Assets.Battle.Shared.Playground.ActorData get_ActorData();
                    /*0x3cd60e0*/ void set_ActorData(Assets.Battle.Shared.Playground.ActorData value);
                }

                namespace Hud
                {
                    class ActorCreationView : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ Assets.Battle.Shared.Playground.Hud.ActorGroup <PlayerGroup>k__BackingField;
                        /*0x28*/ Assets.Battle.Shared.Playground.Hud.ActorGroup <EnemyGroup>k__BackingField;
                        /*0x30*/ UnityEngine.UI.Button <ApplyButton>k__BackingField;
                        /*0x38*/ UnityEngine.UI.Button navigationButton;
                        /*0x40*/ bool isOpened;

                        /*0x3cd628c*/ ActorCreationView();
                        /*0x3cd60e8*/ Assets.Battle.Shared.Playground.Hud.ActorGroup get_PlayerGroup();
                        /*0x3cd60f0*/ void set_PlayerGroup(Assets.Battle.Shared.Playground.Hud.ActorGroup value);
                        /*0x3cd60f8*/ Assets.Battle.Shared.Playground.Hud.ActorGroup get_EnemyGroup();
                        /*0x3cd6100*/ void set_EnemyGroup(Assets.Battle.Shared.Playground.Hud.ActorGroup value);
                        /*0x3cd6108*/ UnityEngine.UI.Button get_ApplyButton();
                        /*0x3cd6110*/ void set_ApplyButton(UnityEngine.UI.Button value);
                        /*0x3cd6118*/ void Awake();
                        /*0x3cd61a0*/ void TriggerNavigationAction();
                        /*0x3cd6294*/ void <Awake>b__14_0();
                    }

                    class ActorGroup : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ Assets.Battle.Shared.Playground.Hud.ActorTile tilePrefab;
                        /*0x28*/ UnityEngine.Transform tileContainer;
                        /*0x30*/ UnityEngine.UI.Button addButton;
                        /*0x38*/ System.Collections.Generic.List<Assets.Battle.Shared.Playground.Hud.ActorTile> <Tiles>k__BackingField;
                        /*0x40*/ int activeTilesCount;

                        /*0x3cd65b0*/ ActorGroup();
                        /*0x3cd6298*/ System.Collections.Generic.List<Assets.Battle.Shared.Playground.Hud.ActorTile> get_Tiles();
                        /*0x3cd62a0*/ void Awake();
                        /*0x3cd6328*/ void AddTile(string assetKey, string position, string scale, string cameraDistance);
                        /*0x3cd6638*/ void <Awake>b__7_0();

                        class <>c__DisplayClass8_0
                        {
                            /*0x10*/ Assets.Battle.Shared.Playground.Hud.ActorGroup <>4__this;
                            /*0x18*/ Assets.Battle.Shared.Playground.Hud.ActorTile tile;

                            /*0x3cd65a8*/ <>c__DisplayClass8_0();
                            /*0x3cd67ec*/ void <AddTile>b__0();
                        }
                    }

                    class ActorTile : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ TMPro.TMP_InputField <AssetKey>k__BackingField;
                        /*0x28*/ TMPro.TMP_InputField <Position>k__BackingField;
                        /*0x30*/ TMPro.TMP_InputField <Scale>k__BackingField;
                        /*0x38*/ TMPro.TMP_InputField <CameraDistance>k__BackingField;
                        /*0x40*/ UnityEngine.UI.Button <RemoveButton>k__BackingField;

                        /*0x3cd68f4*/ ActorTile();
                        /*0x3cd68a4*/ TMPro.TMP_InputField get_AssetKey();
                        /*0x3cd68ac*/ void set_AssetKey(TMPro.TMP_InputField value);
                        /*0x3cd68b4*/ TMPro.TMP_InputField get_Position();
                        /*0x3cd68bc*/ void set_Position(TMPro.TMP_InputField value);
                        /*0x3cd68c4*/ TMPro.TMP_InputField get_Scale();
                        /*0x3cd68cc*/ void set_Scale(TMPro.TMP_InputField value);
                        /*0x3cd68d4*/ TMPro.TMP_InputField get_CameraDistance();
                        /*0x3cd68dc*/ void set_CameraDistance(TMPro.TMP_InputField value);
                        /*0x3cd68e4*/ UnityEngine.UI.Button get_RemoveButton();
                        /*0x3cd68ec*/ void set_RemoveButton(UnityEngine.UI.Button value);
                    }

                    class ButtonPanel : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ UnityEngine.UI.Button <Button>k__BackingField;

                        /*0x3cd690c*/ ButtonPanel();
                        /*0x3cd68fc*/ UnityEngine.UI.Button get_Button();
                        /*0x3cd6904*/ void set_Button(UnityEngine.UI.Button value);
                    }

                    class DropDownPanel : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ TMPro.TMP_Dropdown <Dropdown>k__BackingField;

                        /*0x3cd6924*/ DropDownPanel();
                        /*0x3cd6914*/ TMPro.TMP_Dropdown get_Dropdown();
                        /*0x3cd691c*/ void set_Dropdown(TMPro.TMP_Dropdown value);
                    }

                    class InputPanel : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ TMPro.TMP_InputField <InputField>k__BackingField;

                        /*0x3cd693c*/ InputPanel();
                        /*0x3cd692c*/ TMPro.TMP_InputField get_InputField();
                        /*0x3cd6934*/ void set_InputField(TMPro.TMP_InputField value);
                    }

                    class SettingsView : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ Assets.Battle.Shared.Playground.Hud.InputPanel <VfxAssetKey>k__BackingField;
                        /*0x28*/ Assets.Battle.Shared.Playground.Hud.InputPanel <MotionName>k__BackingField;
                        /*0x30*/ Assets.Battle.Shared.Playground.Hud.InputPanel <SubsequentMotionName>k__BackingField;
                        /*0x38*/ Assets.Battle.Shared.Playground.Hud.InputPanel <JumpActionOverride>k__BackingField;
                        /*0x40*/ Assets.Battle.Shared.Playground.Hud.InputPanel <ExtraSkillAssetKey>k__BackingField;
                        /*0x48*/ Assets.Battle.Shared.Playground.Hud.InputPanel <CameraAssetKey>k__BackingField;
                        /*0x50*/ Assets.Battle.Shared.Playground.Hud.InputPanel <EventVfxAssetKey>k__BackingField;
                        /*0x58*/ Assets.Battle.Shared.Playground.Hud.InputPanel <CutInAssetKey>k__BackingField;
                        /*0x60*/ Assets.Battle.Shared.Playground.Hud.InputPanel <CockpitAssetId>k__BackingField;
                        /*0x68*/ Assets.Battle.Shared.Playground.Hud.ButtonPanel <ResetCameraButton>k__BackingField;
                        /*0x70*/ Assets.Battle.Shared.Playground.Hud.ButtonPanel <ToggleLegendButton>k__BackingField;
                        /*0x78*/ Assets.Battle.Shared.Playground.Hud.InputPanel <FieldJsonString>k__BackingField;
                        /*0x80*/ UnityEngine.UI.Button <ApplyPlayerButton>k__BackingField;
                        /*0x88*/ UnityEngine.UI.Button <ApplyEnemyButton>k__BackingField;
                        /*0x90*/ UnityEngine.UI.Button <ApplyFieldButton>k__BackingField;
                        /*0x98*/ UnityEngine.UI.Button navigationButton;
                        /*0xa0*/ bool isOpened;

                        /*0x3cd6abc*/ SettingsView();
                        /*0x3cd6944*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_VfxAssetKey();
                        /*0x3cd694c*/ void set_VfxAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd6954*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_MotionName();
                        /*0x3cd695c*/ void set_MotionName(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd6964*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_SubsequentMotionName();
                        /*0x3cd696c*/ void set_SubsequentMotionName(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd6974*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_JumpActionOverride();
                        /*0x3cd697c*/ void set_JumpActionOverride(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd6984*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_ExtraSkillAssetKey();
                        /*0x3cd698c*/ void set_ExtraSkillAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd6994*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_CameraAssetKey();
                        /*0x3cd699c*/ void set_CameraAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd69a4*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_EventVfxAssetKey();
                        /*0x3cd69ac*/ void set_EventVfxAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd69b4*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_CutInAssetKey();
                        /*0x3cd69bc*/ void set_CutInAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd69c4*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_CockpitAssetId();
                        /*0x3cd69cc*/ void set_CockpitAssetId(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd69d4*/ Assets.Battle.Shared.Playground.Hud.ButtonPanel get_ResetCameraButton();
                        /*0x3cd69dc*/ void set_ResetCameraButton(Assets.Battle.Shared.Playground.Hud.ButtonPanel value);
                        /*0x3cd69e4*/ Assets.Battle.Shared.Playground.Hud.ButtonPanel get_ToggleLegendButton();
                        /*0x3cd69ec*/ void set_ToggleLegendButton(Assets.Battle.Shared.Playground.Hud.ButtonPanel value);
                        /*0x3cd69f4*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_FieldJsonString();
                        /*0x3cd69fc*/ void set_FieldJsonString(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3cd6a04*/ UnityEngine.UI.Button get_ApplyPlayerButton();
                        /*0x3cd6a0c*/ void set_ApplyPlayerButton(UnityEngine.UI.Button value);
                        /*0x3cd6a14*/ UnityEngine.UI.Button get_ApplyEnemyButton();
                        /*0x3cd6a1c*/ void set_ApplyEnemyButton(UnityEngine.UI.Button value);
                        /*0x3cd6a24*/ UnityEngine.UI.Button get_ApplyFieldButton();
                        /*0x3cd6a2c*/ void set_ApplyFieldButton(UnityEngine.UI.Button value);
                        /*0x3cd6a34*/ void Awake();
                        /*0x3ccf9bc*/ void TriggerNavigationAction();
                        /*0x3cd6ac4*/ void <Awake>b__62_0();
                    }

                    class SharedPlaygroundHud : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ Assets.Battle.Shared.Playground.Hud.ActorCreationView actorCreationView;
                        /*0x28*/ Assets.Battle.Shared.Playground.Hud.SettingsView <SettingsView>k__BackingField;
                        /*0x30*/ UnityEngine.Events.UnityEvent<Assets.Battle.Shared.Playground.ActorData[], Assets.Battle.Shared.Playground.ActorData[]> OnApplyActorsClicked;

                        /*0x3cd6e98*/ SharedPlaygroundHud();
                        /*0x3cd6ac8*/ Assets.Battle.Shared.Playground.Hud.SettingsView get_SettingsView();
                        /*0x3cd6ad0*/ void set_SettingsView(Assets.Battle.Shared.Playground.Hud.SettingsView value);
                        /*0x3cd6ad8*/ void Awake();
                        /*0x3cd6b64*/ Assets.Battle.Shared.Playground.ActorData[] CreateActorData(System.Collections.Generic.List<Assets.Battle.Shared.Playground.Hud.ActorTile> tiles);
                        /*0x3ccf524*/ void ApplyActorData(Assets.Battle.Shared.Playground.ActorData[] playerData, Assets.Battle.Shared.Playground.ActorData[] enemyData);
                        /*0x3cd6f20*/ void <Awake>b__6_0();
                    }
                }
            }
        }

        namespace Overseers
        {
            interface IActorOverseerUnityFacade
            {
                /*0x38159dc*/ void ClearActorList();
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IActorOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <ActorsLayer>k__BackingField;

                    /*0x3cd707c*/ Arguments();
                    /*0x3cd706c*/ UnityEngine.Transform get_ActorsLayer();
                    /*0x3cd7074*/ void set_ActorsLayer(UnityEngine.Transform value);
                }
            }

            interface IActorOverseer
            {
                /*0x3814a3c*/ Assets.Battle.Actor AcquireActor(Assets.Api.Client.PawnId id);
                /*0x38148bc*/ Assets.Battle.Actor[] AcquireActors();
                /*0x3814a3c*/ Assets.Battle.Actor[] AcquireActors(Assets.Api.Client.PawnId[] ids);
                Assets.Battle.Actor[] AcquireActors(bool enemyActors);
                /*0x38148bc*/ Assets.Battle.Actor[] AcquireActorsIncludingDead();
                Assets.Battle.Actor[] AcquireActorsIncludingDead(bool enemyActors);
                /*0x38148bc*/ Assets.Battle.Actor[] AcquireEnemyActors();
                /*0x38148bc*/ Assets.Battle.Actor[] AcquireEnemyActorsIncludingDead();
                /*0x38148bc*/ Assets.Battle.Actor AcquireFirstEnemyActor();
                /*0x38148bc*/ Assets.Battle.Actor AcquireFirstPlayerActor();
                /*0x38148bc*/ Assets.Battle.Actor[] AcquirePlayerActors();
                /*0x38148bc*/ Assets.Battle.Actor[] AcquirePlayerActorsIncludingDead();
                /*0x38159dc*/ void ClearActorList();
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Actor> CreateActor(Assets.Api.Client.PawnView view);
            }

            class ActorOverseer : Assets.Battle.Overseers.IActorOverseer, Assets.Battle.Overseers.IActorOverseerUnityFacade, System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, Assets.Battle.Actor> actors;
                /*0x18*/ UniRx.CompositeDisposable disposables;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x28*/ Assets.AssetManagement.ISpineAssetProvider spineAssetProvider;
                /*0x30*/ UnityEngine.Transform actorsLayer;

                /*0x3cd7084*/ ActorOverseer(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.AssetManagement.ISpineAssetProvider spineAssetProvider);
                /*0x3cd7174*/ void Initialize(Assets.Battle.Overseers.IActorOverseerUnityFacade.Arguments arguments);
                /*0x3cd7328*/ Assets.Battle.Actor AcquireActor(Assets.Api.Client.PawnId id);
                /*0x3cd73a0*/ Assets.Battle.Actor[] AcquireActors(Assets.Api.Client.PawnId[] ids);
                /*0x3cd7528*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Actor> CreateActor(Assets.Api.Client.PawnView view);
                /*0x3cd7650*/ void ClearActorList();
                /*0x3cd7b80*/ Assets.Battle.Actor[] AcquireActors(bool enemyActors);
                /*0x3cd7c9c*/ Assets.Battle.Actor[] AcquireActorsIncludingDead(bool enemyActors);
                /*0x3cd7db8*/ Assets.Battle.Actor[] AcquireActors();
                /*0x3cd7f08*/ Assets.Battle.Actor[] AcquireActorsIncludingDead();
                /*0x3cd7f74*/ Assets.Battle.Actor AcquireFirstPlayerActor();
                /*0x3cd80a0*/ Assets.Battle.Actor AcquireFirstEnemyActor();
                /*0x3cd81cc*/ Assets.Battle.Actor[] AcquirePlayerActors();
                /*0x3cd831c*/ Assets.Battle.Actor[] AcquireEnemyActors();
                /*0x3cd846c*/ Assets.Battle.Actor[] AcquirePlayerActorsIncludingDead();
                /*0x3cd85bc*/ Assets.Battle.Actor[] AcquireEnemyActorsIncludingDead();
                /*0x3cd870c*/ int FormationLocationViewToFieldPositionIndex(Assets.Api.Client.FormationLocationView view);
                /*0x3cd8890*/ int FormationLocationViewToPositionIndex(Assets.Api.Client.FormationLocationView view);
                /*0x3cd8a14*/ void Dispose();
                /*0x3cd8a30*/ void <Initialize>b__6_0(bool value);

                class Configuration
                {
                    /*0x10*/ float <MecanimScale>k__BackingField;
                    /*0x14*/ float <CameraFocusDistance>k__BackingField;

                    /*0x3cdaa48*/ Configuration();
                    /*0x3cdaab4*/ Configuration(Assets.Api.Client.PawnMasterView view);
                    /*0x3cdaa28*/ float get_MecanimScale();
                    /*0x3cdaa30*/ void set_MecanimScale(float value);
                    /*0x3cdaa38*/ float get_CameraFocusDistance();
                    /*0x3cdaa40*/ void set_CameraFocusDistance(float value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Overseers.ActorOverseer.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Actor, bool> <>9__13_0;
                    static /*0x10*/ System.Func<Assets.Battle.Actor, bool> <>9__15_0;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, bool> <>9__16_0;
                    static /*0x20*/ System.Func<Assets.Battle.Actor, bool> <>9__17_0;
                    static /*0x28*/ System.Func<Assets.Battle.Actor, bool> <>9__18_0;
                    static /*0x30*/ System.Func<Assets.Battle.Actor, bool> <>9__19_0;
                    static /*0x38*/ System.Func<Assets.Battle.Actor, bool> <>9__20_0;

                    static /*0x3cdacfc*/ <>c();
                    /*0x3cdad64*/ <>c();
                    /*0x3cdad6c*/ bool <AcquireActors>b__13_0(Assets.Battle.Actor a);
                    /*0x3cdad8c*/ bool <AcquireFirstPlayerActor>b__15_0(Assets.Battle.Actor a);
                    /*0x3cdadbc*/ bool <AcquireFirstEnemyActor>b__16_0(Assets.Battle.Actor a);
                    /*0x3cdadec*/ bool <AcquirePlayerActors>b__17_0(Assets.Battle.Actor a);
                    /*0x3cdae1c*/ bool <AcquireEnemyActors>b__18_0(Assets.Battle.Actor a);
                    /*0x3cdae4c*/ bool <AcquirePlayerActorsIncludingDead>b__19_0(Assets.Battle.Actor a);
                    /*0x3cdae6c*/ bool <AcquireEnemyActorsIncludingDead>b__20_0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ bool enemyActors;

                    /*0x3cdae84*/ <>c__DisplayClass11_0();
                    /*0x3cdae8c*/ bool <AcquireActors>b__0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ bool enemyActors;

                    /*0x3cdaec0*/ <>c__DisplayClass12_0();
                    /*0x3cdaec8*/ bool <AcquireActorsIncludingDead>b__0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Api.Client.PawnView view;

                    /*0x3cdaeec*/ <>c__DisplayClass9_0();
                    /*0x3cdaef4*/ bool <CreateActor>b__0(Assets.Api.Client.PawnMasterView p);
                }

                struct <CreateActor>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Actor> <>t__builder;
                    /*0x30*/ Assets.Api.Client.PawnView view;
                    /*0x38*/ Assets.Battle.Overseers.ActorOverseer <>4__this;
                    /*0x40*/ Assets.Battle.Overseers.ActorOverseer.<> <>8__1;
                    /*0x48*/ Assets.Api.Client.PawnMasterView <pawnMaster>5__2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> <>u__1;

                    /*0x3cdaf1c*/ void MoveNext();
                    /*0x3cdbe60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICameraOverseerUnityFacade
            {
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x3816f24*/ void ConfigureBlendCamera(float duration);
                /*0x38159dc*/ void ConfigureCutBlendCamera();
                /*0x38159dc*/ void DisablePostProcessing();
                /*0x3815ed0*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x38159dc*/ void EnablePostProcessing();
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ICameraOverseerUnityFacade.Arguments arguments);
                /*0x3815cc4*/ void SetCameraOffset(bool value);

                class Arguments
                {
                    /*0x10*/ Assets.Battle.Accessors.CinemachineLayoutAccessor <CinemachineLayoutAccessor>k__BackingField;
                    /*0x18*/ Assets.Battle.Accessors.LayerOrderAccessor <LayerOrderAccessor>k__BackingField;
                    /*0x20*/ Unity.Cinemachine.NoiseSettings <ShakeNoise>k__BackingField;
                    /*0x28*/ Unity.Cinemachine.NoiseSettings <WobbleNoise>k__BackingField;
                    /*0x30*/ UnityEngine.Rendering.Volume <PostProcessingVolume>k__BackingField;
                    /*0x38*/ UnityEngine.GameObject <EntranceAnimation>k__BackingField;

                    /*0x3cdbf18*/ Arguments();
                    /*0x3cdbeb8*/ Assets.Battle.Accessors.CinemachineLayoutAccessor get_CinemachineLayoutAccessor();
                    /*0x3cdbec0*/ void set_CinemachineLayoutAccessor(Assets.Battle.Accessors.CinemachineLayoutAccessor value);
                    /*0x3cdbec8*/ Assets.Battle.Accessors.LayerOrderAccessor get_LayerOrderAccessor();
                    /*0x3cdbed0*/ void set_LayerOrderAccessor(Assets.Battle.Accessors.LayerOrderAccessor value);
                    /*0x3cdbed8*/ Unity.Cinemachine.NoiseSettings get_ShakeNoise();
                    /*0x3cdbee0*/ void set_ShakeNoise(Unity.Cinemachine.NoiseSettings value);
                    /*0x3cdbee8*/ Unity.Cinemachine.NoiseSettings get_WobbleNoise();
                    /*0x3cdbef0*/ void set_WobbleNoise(Unity.Cinemachine.NoiseSettings value);
                    /*0x3cdbef8*/ UnityEngine.Rendering.Volume get_PostProcessingVolume();
                    /*0x3cdbf00*/ void set_PostProcessingVolume(UnityEngine.Rendering.Volume value);
                    /*0x3cdbf08*/ UnityEngine.GameObject get_EntranceAnimation();
                    /*0x3cdbf10*/ void set_EntranceAnimation(UnityEngine.GameObject value);
                }
            }

            interface ICameraOverseer
            {
                /*0x38159a4*/ UnityEngine.Vector3 get_CameraPosition();
                UnityEngine.Quaternion get_CameraRotation();
                Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters);
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                /*0x3816f24*/ void ConfigureBlendCamera(float duration);
                /*0x38159dc*/ void ConfigureCutBlendCamera();
                /*0x3815ed0*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x3817254*/ void SetFollowPosition(UnityEngine.Vector3 position);
                /*0x3817254*/ void SetLookAtPosition(UnityEngine.Vector3 position);
                /*0x38159dc*/ void TryDisableActionCamera();
                /*0x3816710*/ void SetFollowTarget(UnityEngine.Transform target);
                /*0x38159dc*/ void EnablePostProcessing();
                /*0x38159dc*/ void DisablePostProcessing();
                /*0x3817254*/ void SetFocusLookAtPosition(UnityEngine.Vector3 position);
                /*0x38159dc*/ void TransitionToActiveCameraType();
                /*0x3817254*/ void SetFocusFollowPosition(UnityEngine.Vector3 position);
                /*0x3816710*/ void AddToTargetGroup(UnityEngine.Transform[] targets);
                /*0x3816710*/ void AddToTargetGroup(UnityEngine.Transform target);
                /*0x38159dc*/ void ClearTargetGroup();
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask PlaybackEntranceAnimation();
                /*0x3815cc4*/ void SetCameraOffset(bool value);
                Cysharp.Threading.Tasks.UniTask TryEnableActionCamera(string key, bool isEnemyActor, bool isExtraSkill);
                /*0x3816f24*/ void SetCameraFocusDistance(float value);
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask PrepareEntranceAnimation();
                /*0x3816f24*/ void SetCameraFocusYOffset(float value);
                /*0x3816f24*/ void SetCameraTargetFocusDistance(float value);
                /*0x3816f24*/ void SetCameraTargetFocusYOffset(float value);
            }

            class CameraOverseer : Assets.Battle.Overseers.ICameraOverseer, Assets.Battle.Overseers.ICameraOverseerUnityFacade, Assets.Battle.Shared.ISharedCameraOverseer, System.IDisposable
            {
                /*0x10*/ UniRx.CompositeDisposable disposables;
                /*0x18*/ System.Collections.Generic.List<Unity.Cinemachine.CinemachineCamera> noiseCameras;
                /*0x20*/ Assets.GameUi.Externals.ICameraManager cameraManager;
                /*0x28*/ Assets.Battle.ICache cache;
                /*0x30*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x38*/ Assets.Battle.Accessors.CinemachineLayoutAccessor layoutAccessor;
                /*0x40*/ Assets.Battle.Accessors.LayerOrderAccessor layerOrderAccessor;
                /*0x48*/ UnityEngine.GameObject activeActionCamera;
                /*0x50*/ Unity.Cinemachine.NoiseSettings shakeNoise;
                /*0x58*/ Unity.Cinemachine.NoiseSettings wobbleNoise;
                /*0x60*/ UnityEngine.Rendering.Volume postProcessingVolume;
                /*0x68*/ UnityEngine.GameObject entranceAnimation;
                /*0x70*/ float blendDuration;
                /*0x74*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes activeCameraType;
                /*0x78*/ bool offsetIsActive;

                /*0x3cdc064*/ CameraOverseer(Assets.GameUi.Externals.ICameraManager cameraManager, Assets.Battle.ICache cache, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3cdbf20*/ UnityEngine.Vector3 get_CameraPosition();
                /*0x3cdbfc0*/ UnityEngine.Quaternion get_CameraRotation();
                /*0x3cdc3ec*/ void Initialize(Assets.Battle.Overseers.ICameraOverseerUnityFacade.Arguments arguments);
                /*0x3cdc9e8*/ void SetFieldCameraActive(bool value);
                /*0x3cdca30*/ void SetCameraOffset(bool value);
                /*0x3cdce34*/ void SetCameraFocusDistance(float value);
                /*0x3cdcebc*/ void SetCameraFocusYOffset(float value);
                /*0x3cdcf44*/ void SetCameraTargetFocusDistance(float value);
                /*0x3cdcfcc*/ void SetCameraTargetFocusYOffset(float value);
                /*0x3cdd054*/ bool GetCameraOffset();
                /*0x3cdd05c*/ Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters);
                /*0x3cdd12c*/ Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters, Unity.Cinemachine.CinemachineCamera camera);
                /*0x3cdd210*/ void EnablePostProcessing();
                /*0x3cdd2a4*/ void DisablePostProcessing();
                /*0x3cdd338*/ void TransitionToActiveCameraType();
                /*0x3cdca44*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x3cdd340*/ void ClearTargetGroup();
                /*0x3cdd3c0*/ void AddToTargetGroup(UnityEngine.Transform target);
                /*0x3cdd3ec*/ void AddToTargetGroup(UnityEngine.Transform[] targets);
                /*0x3cdd470*/ Cysharp.Threading.Tasks.UniTask PrepareEntranceAnimation();
                /*0x3cdd520*/ Cysharp.Threading.Tasks.UniTask PlaybackEntranceAnimation();
                /*0x3cdd5cc*/ Cysharp.Threading.Tasks.UniTask TryEnableActionCamera(string key, bool isEnemyActor, bool isExtraSkill);
                /*0x3cdd6b0*/ Unity.Cinemachine.CinemachineCamera TryGetActionVirtualCamera(UnityEngine.GameObject actionCamera);
                /*0x3cdd7c8*/ void TryDisableActionCamera();
                /*0x3cdd86c*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                /*0x3cdd910*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                /*0x3cdd9b4*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x3cdda5c*/ void SetFollowTarget(UnityEngine.Transform target);
                /*0x3cddcbc*/ void ConfigureCutBlendCamera();
                /*0x3cddd64*/ void ConfigureBlendCamera(float duration);
                /*0x3cdde20*/ void DetatchFollowAndLook();
                /*0x3cddec0*/ void ReattachFollowAndLook();
                /*0x3cddf68*/ void SetFollowPosition(UnityEngine.Vector3 position);
                /*0x3cde150*/ void SetFollowStaticPosition(UnityEngine.Vector3 position);
                /*0x3cde338*/ void SetLookAtPosition(UnityEngine.Vector3 position);
                /*0x3cde520*/ void SetLookAtStaticPosition(UnityEngine.Vector3 position);
                /*0x3cde708*/ void SetFocusLookAtPosition(UnityEngine.Vector3 position);
                /*0x3cde8f0*/ void SetFocusFollowPosition(UnityEngine.Vector3 position);
                /*0x3cdead8*/ void Dispose();
                /*0x3cdeaf4*/ UnityEngine.Vector3 <SetFollowPosition>b__50_0();
                /*0x3cdeb24*/ void <SetFollowPosition>b__50_1(UnityEngine.Vector3 x);
                /*0x3cdeb7c*/ UnityEngine.Vector3 <SetFollowStaticPosition>b__51_0();
                /*0x3cdebac*/ void <SetFollowStaticPosition>b__51_1(UnityEngine.Vector3 x);
                /*0x3cdec04*/ UnityEngine.Vector3 <SetLookAtPosition>b__52_0();
                /*0x3cdec34*/ void <SetLookAtPosition>b__52_1(UnityEngine.Vector3 x);
                /*0x3cdec8c*/ UnityEngine.Vector3 <SetLookAtStaticPosition>b__53_0();
                /*0x3cdecbc*/ void <SetLookAtStaticPosition>b__53_1(UnityEngine.Vector3 x);
                /*0x3cded14*/ UnityEngine.Vector3 <SetFocusLookAtPosition>b__54_0();
                /*0x3cded44*/ void <SetFocusLookAtPosition>b__54_1(UnityEngine.Vector3 x);
                /*0x3cded9c*/ UnityEngine.Vector3 <SetFocusFollowPosition>b__55_0();
                /*0x3cdedcc*/ void <SetFocusFollowPosition>b__55_1(UnityEngine.Vector3 x);

                enum CameraTypes
                {
                    Fade = 0,
                    Focus = 1,
                    TargetFocus = 2,
                    Field = 3,
                    PlayerGroup = 4,
                    EnemyGroup = 5,
                    GroupFraming = 6,
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x18*/ Assets.Battle.DataModels.IBattleDataStorageModel model;

                    /*0x3cdc3e4*/ <>c__DisplayClass19_0();
                    /*0x3cdee24*/ void <.ctor>b__0(bool value);
                    /*0x3cdee40*/ void <.ctor>b__1(bool value);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x18*/ UnityEngine.Transform target;

                    /*0x3cddcb4*/ <>c__DisplayClass45_0();
                    /*0x3cdef28*/ void <SetFollowTarget>b__0();
                }

                struct <ApplyCameraNoise>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x30*/ Assets.VisualEffectData.CameraNoiseParameters parameters;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cdef5c*/ void MoveNext();
                    /*0x3cdf7fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ApplyCameraNoise>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Unity.Cinemachine.CinemachineCamera camera;
                    /*0x30*/ Assets.VisualEffectData.CameraNoiseParameters parameters;
                    /*0x38*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x40*/ Unity.Cinemachine.CinemachineBasicMultiChannelPerlin <noise>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cdf808*/ void MoveNext();
                    /*0x3cdfdec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlaybackEntranceAnimation>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cdfdf8*/ void MoveNext();
                    /*0x3ce0638*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PrepareEntranceAnimation>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x30*/ UnityEngine.Animator <animator>5__2;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ce0644*/ void MoveNext();
                    /*0x3ce0b5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryEnableActionCamera>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ string key;
                    /*0x30*/ bool isEnemyActor;
                    /*0x38*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x40*/ bool isExtraSkill;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x3ce0b68*/ void MoveNext();
                    /*0x3ce1270*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICockpitOverseerUnityFacade
            {
                /*0x38159dc*/ void Clear();
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ICockpitOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <CockpitResultLayer>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <MinimizedCockpitLayer>k__BackingField;
                    /*0x20*/ UnityEngine.CanvasGroup <MinimizedCockpitUnderlay>k__BackingField;
                    /*0x28*/ UnityEngine.UI.Image <MinimizedCockpitOverlay>k__BackingField;
                    /*0x30*/ Assets.Battle.Hud.CockpitPlaceholder[] <CockpitViewPlaceholders>k__BackingField;
                    /*0x38*/ UnityEngine.UI.Image <CockpitBackground>k__BackingField;
                    /*0x40*/ Assets.Battle.Utilities.PunchData <DamagePunchData>k__BackingField;
                    /*0x48*/ Assets.Battle.Utilities.ColorData <DamageColorData>k__BackingField;
                    /*0x50*/ Assets.Battle.Utilities.ColorData <HealColorData>k__BackingField;
                    /*0x58*/ UnityEngine.UI.Image[] <AdditionalAnimationTargets>k__BackingField;

                    /*0x3ce131c*/ Arguments();
                    /*0x3ce127c*/ UnityEngine.Transform get_CockpitResultLayer();
                    /*0x3ce1284*/ void set_CockpitResultLayer(UnityEngine.Transform value);
                    /*0x3ce128c*/ UnityEngine.Transform get_MinimizedCockpitLayer();
                    /*0x3ce1294*/ void set_MinimizedCockpitLayer(UnityEngine.Transform value);
                    /*0x3ce129c*/ UnityEngine.CanvasGroup get_MinimizedCockpitUnderlay();
                    /*0x3ce12a4*/ void set_MinimizedCockpitUnderlay(UnityEngine.CanvasGroup value);
                    /*0x3ce12ac*/ UnityEngine.UI.Image get_MinimizedCockpitOverlay();
                    /*0x3ce12b4*/ void set_MinimizedCockpitOverlay(UnityEngine.UI.Image value);
                    /*0x3ce12bc*/ Assets.Battle.Hud.CockpitPlaceholder[] get_CockpitViewPlaceholders();
                    /*0x3ce12c4*/ void set_CockpitViewPlaceholders(Assets.Battle.Hud.CockpitPlaceholder[] value);
                    /*0x3ce12cc*/ UnityEngine.UI.Image get_CockpitBackground();
                    /*0x3ce12d4*/ void set_CockpitBackground(UnityEngine.UI.Image value);
                    /*0x3ce12dc*/ Assets.Battle.Utilities.PunchData get_DamagePunchData();
                    /*0x3ce12e4*/ void set_DamagePunchData(Assets.Battle.Utilities.PunchData value);
                    /*0x3ce12ec*/ Assets.Battle.Utilities.ColorData get_DamageColorData();
                    /*0x3ce12f4*/ void set_DamageColorData(Assets.Battle.Utilities.ColorData value);
                    /*0x3ce12fc*/ Assets.Battle.Utilities.ColorData get_HealColorData();
                    /*0x3ce1304*/ void set_HealColorData(Assets.Battle.Utilities.ColorData value);
                    /*0x3ce130c*/ UnityEngine.UI.Image[] get_AdditionalAnimationTargets();
                    /*0x3ce1314*/ void set_AdditionalAnimationTargets(UnityEngine.UI.Image[] value);
                }
            }

            interface ICockpitOverseer
            {
                Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> CreateCockpit(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask SetUpResultPose(Assets.Battle.Actor actor);
                /*0x3816710*/ void ShowMinimizedCockpit(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask PrepareCockpitView(Assets.Battle.Actor[] actors);
                /*0x38159dc*/ void ForceHideMinimizedCockpit();
                /*0x3816710*/ void UpdateCockpitViewCount(Assets.Battle.Actor[] actors);
                /*0x3815cc4*/ void UpdateCockpitPlaceholdersSizeAndPosition(bool tween);
                /*0x3816710*/ void AddActorToCockpitView(Assets.Battle.Actor actor);
                /*0x3816710*/ void TryKillActor(Assets.Battle.Actor actor);
                /*0x38148bc*/ Assets.Battle.Actor TryAcquireScreenLeftCockpitActor();
                /*0x3816710*/ void TryUpdateStatus(Assets.Battle.Actor actor);
                /*0x38159dc*/ void ClearCockpitViewData();
                /*0x3816710*/ void ClearCockpitViewData(Assets.Battle.Actor exclude);
                /*0x3815cc4*/ void SetCockpitViewVisibility(bool value);
                /*0x38159dc*/ void ClearPlacehodlers();
                /*0x38159dc*/ void ClearPlaceholderStatuses();
                /*0x3816710*/ void PlaybackDamageAnimation(Assets.Battle.Actor actor);
                /*0x38159dc*/ void PlaybackHealAnimation();
            }

            class CockpitOverseer : Assets.Battle.Overseers.ICockpitOverseerUnityFacade, Assets.Battle.Overseers.ICockpitOverseer, Assets.Battle.Shared.ISharedCockpitOverseer, System.IDisposable
            {
                /*0x10*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x18*/ Assets.AssetManagement.ISpineAssetProvider spineAssetProvider;
                /*0x20*/ UniRx.CompositeDisposable disposables;
                /*0x28*/ UnityEngine.Transform cockpitResultLayer;
                /*0x30*/ UnityEngine.Transform minimizedCockpitLayer;
                /*0x38*/ UnityEngine.CanvasGroup minimizedCockpitUnderlay;
                /*0x40*/ UnityEngine.UI.Image minimizedCockpitOverlay;
                /*0x48*/ Assets.Battle.Hud.CockpitPlaceholder[] cockpitViewPlaceholders;
                /*0x50*/ UnityEngine.UI.Image cockpitBackground;
                /*0x58*/ Assets.Battle.Utilities.PunchData damagePunchData;
                /*0x60*/ Assets.Battle.Utilities.ColorData damageColorData;
                /*0x68*/ Assets.Battle.Utilities.ColorData healColorData;
                /*0x70*/ UnityEngine.UI.Image[] additionalAnimationTargets;
                /*0x78*/ Assets.Utilities.Spine.SkeletonController activeCockpit;
                /*0x80*/ DG.Tweening.Sequence minimizedCockpitSequence;
                /*0x88*/ DG.Tweening.Sequence animationSequence;
                /*0x90*/ System.Collections.Generic.List<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData> cockpitViewData;
                /*0x98*/ int cockpitViewCount;
                /*0x9c*/ int cockpitViewIndex;

                /*0x3ce1324*/ CockpitOverseer(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.AssetManagement.ISpineAssetProvider spineAssetProvider);
                /*0x3ce1484*/ void Initialize(Assets.Battle.Overseers.ICockpitOverseerUnityFacade.Arguments arguments);
                /*0x3ce16c8*/ void SetCockpitViewVisibility(bool value);
                /*0x3ce1724*/ void ShowMinimizedCockpit(Assets.Battle.Actor actor);
                /*0x3ce1784*/ void ShowMinimizedCockpit(Assets.Utilities.Spine.SkeletonController cockpit);
                /*0x3ce1cb8*/ void ForceHideMinimizedCockpit();
                /*0x3ce1dd0*/ Assets.Battle.Actor TryAcquireScreenLeftCockpitActor();
                /*0x3ce1f70*/ void ClearCockpitViewData();
                /*0x3ce1f78*/ void ClearCockpitViewData(Assets.Battle.Actor exclude);
                /*0x3ce22a8*/ void ClearPlacehodlers();
                /*0x3ce25fc*/ Cysharp.Threading.Tasks.UniTask SetUpResultPose(Assets.Battle.Actor actor);
                /*0x3ce26cc*/ Cysharp.Threading.Tasks.UniTask PrepareCockpitView(Assets.Battle.Actor[] actors);
                /*0x3ce279c*/ void UpdateCockpitViewCount(Assets.Battle.Actor[] actors);
                /*0x3ce290c*/ void UpdateCockpitPlaceholdersSizeAndPosition(bool tween);
                /*0x3ce2c20*/ void AddActorToCockpitView(Assets.Battle.Actor actor);
                /*0x3ce2304*/ void ClearPlaceholder(Assets.Battle.Hud.CockpitPlaceholder placeholder);
                /*0x3ce33ac*/ void ClearPlaceholderStatuses();
                /*0x3ce340c*/ void TryUpdateStatus(Assets.Battle.Actor actor);
                /*0x3ce35b4*/ void PlaybackDamageAnimation(Assets.Battle.Actor actor);
                /*0x3ce3a14*/ void PlaybackHealAnimation();
                /*0x3ce3c08*/ void TryKillActor(Assets.Battle.Actor actor);
                /*0x3ce3178*/ void AssignToPlaceholder(Assets.Battle.Actor actor, Assets.Battle.Hud.CockpitPlaceholder placeholder);
                /*0x3ce3d28*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> CreateCockpit(Assets.Battle.Actor actor);
                /*0x3ce3e40*/ void Clear();
                /*0x3ce3f10*/ void Dispose();
                /*0x3ce3f4c*/ void <Initialize>b__20_0(bool value);

                class CockpitViewData
                {
                    /*0x10*/ Assets.Battle.Actor <Actor>k__BackingField;
                    /*0x18*/ Assets.Battle.Hud.CockpitPlaceholder <Placeholder>k__BackingField;
                    /*0x20*/ System.DateTime <LastUpdated>k__BackingField;

                    /*0x3ce30e0*/ CockpitViewData(Assets.Battle.Actor actor, Assets.Battle.Hud.CockpitPlaceholder placeholder);
                    /*0x3ce40e4*/ Assets.Battle.Actor get_Actor();
                    /*0x3ce40ec*/ Assets.Battle.Hud.CockpitPlaceholder get_Placeholder();
                    /*0x3ce40f4*/ void set_Placeholder(Assets.Battle.Hud.CockpitPlaceholder value);
                    /*0x3ce40fc*/ System.DateTime get_LastUpdated();
                    /*0x3ce4104*/ void set_LastUpdated(System.DateTime value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Overseers.CockpitOverseer.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Hud.CockpitPlaceholder, bool> <>9__31_0;
                    static /*0x10*/ System.Func<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData, bool> <>9__32_0;
                    static /*0x18*/ System.Func<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData, bool> <>9__33_1;
                    static /*0x20*/ System.Func<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData, System.DateTime> <>9__33_2;

                    static /*0x3ce410c*/ <>c();
                    /*0x3ce4174*/ <>c();
                    /*0x3ce417c*/ bool <UpdateCockpitViewCount>b__31_0(Assets.Battle.Hud.CockpitPlaceholder c);
                    /*0x3ce4208*/ bool <UpdateCockpitPlaceholdersSizeAndPosition>b__32_0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                    /*0x3ce4230*/ bool <AddActorToCockpitView>b__33_1(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                    /*0x3ce4250*/ System.DateTime <AddActorToCockpitView>b__33_2(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x18*/ Assets.Utilities.Spine.SkeletonController oldCockpit;

                    /*0x3ce1cb0*/ <>c__DisplayClass23_0();
                    /*0x3ce4268*/ void <ShowMinimizedCockpit>b__0();
                }

                class <>c__DisplayClass33_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3ce30d8*/ <>c__DisplayClass33_0();
                    /*0x3ce439c*/ bool <AddActorToCockpitView>b__0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                class <>c__DisplayClass37_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3ce3a0c*/ <>c__DisplayClass37_0();
                    /*0x3ce43cc*/ bool <PlaybackDamageAnimation>b__0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                class <>c__DisplayClass39_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3ce3d20*/ <>c__DisplayClass39_0();
                    /*0x3ce43fc*/ bool <TryKillActor>b__0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                struct <CreateCockpit>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>u__1;

                    /*0x3ce442c*/ void MoveNext();
                    /*0x3ce4a9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PrepareCockpitView>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor[] actors;
                    /*0x30*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ce4af4*/ void MoveNext();
                    /*0x3ce5490*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SetUpResultPose>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ce549c*/ void MoveNext();
                    /*0x3ce5de4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICombatTextOverseerUnityFacade
            {
                Cysharp.Threading.Tasks.UniTask FireCombatText(UnityEngine.Vector3 position, string text, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize, Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType);
                Cysharp.Threading.Tasks.UniTask FireDamageText(UnityEngine.Vector3 position, string value, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                Cysharp.Threading.Tasks.UniTask FireShieldDamageText(UnityEngine.Vector3 position, string value, string shieldValue, string additionalValue, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite, float scale);
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ICombatTextOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <CombatTextLayer>k__BackingField;
                    /*0x18*/ UnityEngine.Material <CriticalMaterial>k__BackingField;
                    /*0x20*/ UnityEngine.Material <MissMaterial>k__BackingField;
                    /*0x28*/ UnityEngine.Material <NormalMaterial>k__BackingField;
                    /*0x30*/ UnityEngine.Material <ResistMaterial>k__BackingField;
                    /*0x38*/ UnityEngine.Material <WeakMaterial>k__BackingField;
                    /*0x40*/ UnityEngine.Material <HealMaterial>k__BackingField;
                    /*0x48*/ Assets.Battle.Hud.TotalDamageView <TotalDamageView>k__BackingField;

                    /*0x3ce5e70*/ Arguments();
                    /*0x3ce5df0*/ UnityEngine.Transform get_CombatTextLayer();
                    /*0x3ce5df8*/ void set_CombatTextLayer(UnityEngine.Transform value);
                    /*0x3ce5e00*/ UnityEngine.Material get_CriticalMaterial();
                    /*0x3ce5e08*/ void set_CriticalMaterial(UnityEngine.Material value);
                    /*0x3ce5e10*/ UnityEngine.Material get_MissMaterial();
                    /*0x3ce5e18*/ void set_MissMaterial(UnityEngine.Material value);
                    /*0x3ce5e20*/ UnityEngine.Material get_NormalMaterial();
                    /*0x3ce5e28*/ void set_NormalMaterial(UnityEngine.Material value);
                    /*0x3ce5e30*/ UnityEngine.Material get_ResistMaterial();
                    /*0x3ce5e38*/ void set_ResistMaterial(UnityEngine.Material value);
                    /*0x3ce5e40*/ UnityEngine.Material get_WeakMaterial();
                    /*0x3ce5e48*/ void set_WeakMaterial(UnityEngine.Material value);
                    /*0x3ce5e50*/ UnityEngine.Material get_HealMaterial();
                    /*0x3ce5e58*/ void set_HealMaterial(UnityEngine.Material value);
                    /*0x3ce5e60*/ Assets.Battle.Hud.TotalDamageView get_TotalDamageView();
                    /*0x3ce5e68*/ void set_TotalDamageView(Assets.Battle.Hud.TotalDamageView value);
                }
            }

            interface ICombatTextOverseer
            {
                Cysharp.Threading.Tasks.UniTask FireCombatText(UnityEngine.Vector3 position, string text, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize, Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType);
                Cysharp.Threading.Tasks.UniTask FireDamageText(UnityEngine.Vector3 position, string value, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask FireMultipleDamageTexts(UnityEngine.Vector3 position, int hitCount, long damage, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                Cysharp.Threading.Tasks.UniTask FireShieldDamageText(UnityEngine.Vector3 position, string value, string shieldValue, string additionalValue, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite, float scale);
                /*0x3815cc4*/ void RecordTotalDamage(bool value);
                /*0x38159dc*/ void ResetTotalDamage();
                /*0x38159dc*/ void ResetTotalDamageSource();
                void UpdateTotalDamage(Assets.Api.Client.PawnId source, long damage, int hitCount);
            }

            class CombatTextOverseer : Assets.Battle.Overseers.ICombatTextOverseer, Assets.Battle.Overseers.ICombatTextOverseerUnityFacade
            {
                /*0x10*/ Assets.Battle.ICache cahce;
                /*0x18*/ Assets.AssetManagement.ITextureAssetProvider textureAssetProvider;
                /*0x20*/ Assets.AssetManagement.IAddressablesAssetProvider addressablesAssetProvider;
                /*0x28*/ UnityEngine.Transform combatTextLayer;
                /*0x30*/ UnityEngine.Material normalMaterial;
                /*0x38*/ UnityEngine.Material criticalMaterial;
                /*0x40*/ UnityEngine.Material resistMaterial;
                /*0x48*/ UnityEngine.Material weakMaterial;
                /*0x50*/ UnityEngine.Material missMaterial;
                /*0x58*/ UnityEngine.Material healMaterial;
                /*0x60*/ Assets.Battle.Hud.TotalDamageView totalDamageView;
                /*0x68*/ Assets.Api.Client.PawnId damageSource;
                /*0x70*/ bool recordTotalDamage;

                /*0x3ce5e78*/ CombatTextOverseer(Assets.Battle.ICache cahce, Assets.AssetManagement.ITextureAssetProvider textureAssetProvider, Assets.AssetManagement.IAddressablesAssetProvider addressablesAssetProvider);
                /*0x3ce5ed8*/ void Initialize(Assets.Battle.Overseers.ICombatTextOverseerUnityFacade.Arguments arguments);
                /*0x3ce5f74*/ void ResetTotalDamage();
                /*0x3ce5f90*/ void ResetTotalDamageSource();
                /*0x3ce5f9c*/ void UpdateTotalDamage(Assets.Api.Client.PawnId source, long damage, int hitCount);
                /*0x3ce6044*/ void RecordTotalDamage(bool value);
                /*0x3ce6050*/ Cysharp.Threading.Tasks.UniTask FireMultipleDamageTexts(UnityEngine.Vector3 position, int hitCount, long damage, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                /*0x3ce6174*/ Cysharp.Threading.Tasks.UniTask FireShieldDamageText(UnityEngine.Vector3 position, string value, string shieldValue, string additionalValue, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite, float scale);
                /*0x3ce62b0*/ Cysharp.Threading.Tasks.UniTask FireDamageText(UnityEngine.Vector3 position, string value, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                /*0x3ce63d4*/ Cysharp.Threading.Tasks.UniTask FireCombatText(UnityEngine.Vector3 position, string text, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize, Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType);
                /*0x3ce64e4*/ UnityEngine.Material AquireMaterial(Assets.Battle.Overseers.CombatTextOverseer.FontTypes type);
                /*0x3ce653c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Material> AquireSpriteMaterial(Assets.Battle.Overseers.CombatTextOverseer.FontTypes type);

                enum FontTypes
                {
                    Normal = 0,
                    Critical = 1,
                    Resist = 2,
                    Weak = 3,
                    Miss = 4,
                    Heal = 5,
                    Guard = 6,
                }

                enum SpriteTypes
                {
                    PhysicalShield = 0,
                    EnergyShield = 1,
                }

                enum MotionTypes
                {
                    Up = 0,
                    Down = 1,
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ Assets.Battle.Hud.ShieldDamageText damageText;

                    /*0x3ce68c4*/ <>c__DisplayClass20_0();
                    /*0x3ce68cc*/ void <FireShieldDamageText>b__0();
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ Assets.Battle.Hud.DamageText damageText;

                    /*0x3ce68f8*/ <>c__DisplayClass21_0();
                    /*0x3ce6900*/ void <FireDamageText>b__0();
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ Assets.Battle.Hud.DamageText damageText;

                    /*0x3ce692c*/ <>c__DisplayClass22_0();
                    /*0x3ce6934*/ void <FireCombatText>b__0();
                }

                struct <FireCombatText>d__22 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CombatTextOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Overseers.CombatTextOverseer.<> <>8__1;
                    /*0x38*/ Assets.Battle.Overseers.CombatTextOverseer.FontTypes font;
                    /*0x3c*/ UnityEngine.Vector3 position;
                    /*0x48*/ Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType;
                    /*0x4c*/ int fontSize;
                    /*0x50*/ string text;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x3ce6960*/ void MoveNext();
                    /*0x3ce75f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <FireDamageText>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CombatTextOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Overseers.CombatTextOverseer.<> <>8__1;
                    /*0x38*/ Assets.Battle.Overseers.CombatTextOverseer.FontTypes font;
                    /*0x3c*/ UnityEngine.Vector3 position;
                    /*0x48*/ int fontSize;
                    /*0x50*/ string label;
                    /*0x58*/ string value;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x3ce75fc*/ void MoveNext();
                    /*0x3ce838c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <FireMultipleDamageTexts>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ long damage;
                    /*0x30*/ int hitCount;
                    /*0x38*/ Assets.Battle.Overseers.CombatTextOverseer <>4__this;
                    /*0x40*/ UnityEngine.Vector3 position;
                    /*0x50*/ string label;
                    /*0x58*/ Assets.Battle.Overseers.CombatTextOverseer.FontTypes font;
                    /*0x5c*/ int fontSize;
                    /*0x60*/ long <singleDamage>5__2;
                    /*0x68*/ int <i>5__3;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3ce8398*/ void MoveNext();
                    /*0x3ce8860*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <FireShieldDamageText>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CombatTextOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Overseers.CombatTextOverseer.<> <>8__1;
                    /*0x38*/ UnityEngine.Vector3 position;
                    /*0x44*/ Assets.Battle.Overseers.CombatTextOverseer.FontTypes font;
                    /*0x48*/ Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite;
                    /*0x50*/ string value;
                    /*0x58*/ string shieldValue;
                    /*0x60*/ string additionalValue;
                    /*0x68*/ float scale;
                    /*0x6c*/ UnityEngine.Vector3 <adjustedPosition>5__2;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;
                    /*0x90*/ UnityEngine.SpriteRenderer <>7__wrap2;
                    /*0x98*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite> <>u__2;
                    /*0xb0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Material> <>u__3;

                    /*0x3ce886c*/ void MoveNext();
                    /*0x3ce9ff8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IFieldOverseerUnityFacade
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IFieldOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <FieldParent>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <FieldCenter>k__BackingField;
                    /*0x20*/ UnityEngine.Transform <PlayerGroupCenter>k__BackingField;
                    /*0x28*/ UnityEngine.Transform <EnemyGroupCenter>k__BackingField;

                    /*0x3cea044*/ Arguments();
                    /*0x3cea004*/ UnityEngine.Transform get_FieldParent();
                    /*0x3cea00c*/ void set_FieldParent(UnityEngine.Transform value);
                    /*0x3cea014*/ UnityEngine.Transform get_FieldCenter();
                    /*0x3cea01c*/ void set_FieldCenter(UnityEngine.Transform value);
                    /*0x3cea024*/ UnityEngine.Transform get_PlayerGroupCenter();
                    /*0x3cea02c*/ void set_PlayerGroupCenter(UnityEngine.Transform value);
                    /*0x3cea034*/ UnityEngine.Transform get_EnemyGroupCenter();
                    /*0x3cea03c*/ void set_EnemyGroupCenter(UnityEngine.Transform value);
                }
            }

            interface IFieldOverseer
            {
                /*0x38159a4*/ UnityEngine.Vector3 AcquireFieldCenterPosition();
                /*0x38148bc*/ UnityEngine.Material[] AcquireFieldMaterials();
                UnityEngine.Vector3 AcquireGroupCenterPosition(bool isEnemyGroup);
                Cysharp.Threading.Tasks.UniTask LoadField(string configurationJson);
                /*0x3815cc4*/ void SetActive(bool active);
            }

            class FieldOverseer : Assets.Battle.Overseers.IFieldOverseer, Assets.Battle.Overseers.IFieldOverseerUnityFacade, Assets.Battle.Shared.ISharedFieldOverseer
            {
                /*0x10*/ Assets.Battle.ICache cache;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;
                /*0x20*/ UnityEngine.Transform fieldParent;
                /*0x28*/ UnityEngine.Transform fieldCenter;
                /*0x30*/ UnityEngine.Transform playerGroupCenter;
                /*0x38*/ UnityEngine.Transform enemyGroupCenter;
                /*0x40*/ UnityEngine.GameObject loadedField;
                /*0x48*/ System.Collections.Generic.List<Assets.VisualEffectData.VfxHandler> fieldVisualEffects;

                /*0x3cea04c*/ FieldOverseer(Assets.Battle.ICache cache, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer);
                /*0x3cea104*/ void Initialize(Assets.Battle.Overseers.IFieldOverseerUnityFacade.Arguments arguments);
                /*0x3cea160*/ UnityEngine.Vector3 AcquireFieldCenterPosition();
                /*0x3cea17c*/ UnityEngine.Vector3 AcquireGroupCenterPosition(bool isEnemyGroup);
                /*0x3cea1a4*/ void SetActive(bool active);
                /*0x3cea23c*/ Cysharp.Threading.Tasks.UniTask LoadField(string configurationJson);
                /*0x3cea310*/ Cysharp.Threading.Tasks.UniTask LoadFieldVisualEffects(Assets.Battle.Overseers.FieldOverseer.Configuration configuration);
                /*0x3cea720*/ UnityEngine.Material[] AcquireFieldMaterials();
                /*0x3cead94*/ void <LoadFieldVisualEffects>b__14_0(Assets.VisualEffectData.VfxHandler vfx);

                class Configuration
                {
                    /*0x10*/ string <FieldAssetId>k__BackingField;
                    /*0x18*/ string[] <FieldVisualEffectsAssetIds>k__BackingField;

                    /*0x3ceaeb4*/ Configuration();
                    /*0x3ceaf80*/ Configuration(string configurationJson);
                    /*0x3ceae94*/ string get_FieldAssetId();
                    /*0x3ceae9c*/ void set_FieldAssetId(string value);
                    /*0x3ceaea4*/ string[] get_FieldVisualEffectsAssetIds();
                    /*0x3ceaeac*/ void set_FieldVisualEffectsAssetIds(string[] value);
                }

                struct <LoadField>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ string configurationJson;
                    /*0x30*/ Assets.Battle.Overseers.FieldOverseer <>4__this;
                    /*0x38*/ Assets.Battle.Overseers.FieldOverseer.Configuration <configuration>5__2;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__2;

                    /*0x3ceb22c*/ void MoveNext();
                    /*0x3cebdd0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IHudOverseerUnityFacade
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x3815cc4*/ void SetHudActive(bool active);
                /*0x3815cc4*/ void SetIntractability(bool interactable);
                /*0x3815cc4*/ void SetLocksActive(bool active);

                class Arguments
                {
                    /*0x10*/ UnityEngine.UI.Image <OverlayFade>k__BackingField;
                    /*0x18*/ UnityEngine.GameObject <PlayerPauseLabel>k__BackingField;
                    /*0x20*/ UnityEngine.GameObject <EnemyPauseLabel>k__BackingField;
                    /*0x28*/ UnityEngine.GameObject <PauseHeader>k__BackingField;
                    /*0x30*/ UnityEngine.GameObject <PauseFade>k__BackingField;
                    /*0x38*/ Assets.Battle.Hud.PositionLegend <PositionLegend>k__BackingField;
                    /*0x40*/ Assets.Battle.Hud.BossHealthGauge <BossHealthGauge>k__BackingField;
                    /*0x48*/ Assets.Battle.Hud.CombinedGauge <TeamHealthGauge>k__BackingField;
                    /*0x50*/ Assets.Battle.Hud.ActionQueue <ActionQueue>k__BackingField;
                    /*0x58*/ TMPro.TextMeshProUGUI <TurnText>k__BackingField;
                    /*0x60*/ TMPro.TextMeshProUGUI <QuestText>k__BackingField;
                    /*0x68*/ UnityEngine.UI.Button <SkipButton>k__BackingField;
                    /*0x70*/ UnityEngine.UI.Button <SkipLock>k__BackingField;
                    /*0x78*/ UnityEngine.UI.Button <SpeedButton>k__BackingField;
                    /*0x80*/ UnityEngine.UI.Button <PauseButton>k__BackingField;
                    /*0x88*/ UnityEngine.UI.Button <ClosePauseButton>k__BackingField;
                    /*0x90*/ UnityEngine.UI.Button <CameraChangeButton>k__BackingField;
                    /*0x98*/ UnityEngine.UI.Button <CockpitViewChangeButton>k__BackingField;
                    /*0xa0*/ TMPro.TextMeshProUGUI <SpeedButtonLabel>k__BackingField;
                    /*0xa8*/ Assets.Battle.Hud.SkillNameLabel <SkillNameLabel>k__BackingField;
                    /*0xb0*/ UnityEngine.GameObject <HudLayer>k__BackingField;
                    /*0xb8*/ Assets.Battle.Hud.TurnView <TurnView>k__BackingField;
                    /*0xc0*/ UnityEngine.Transform <PlayerActorIconsGroup>k__BackingField;
                    /*0xc8*/ UnityEngine.Transform <EnemyActorIconsGroup>k__BackingField;
                    /*0xd0*/ UnityEngine.Transform <PlayerActorStatusIconsGroup>k__BackingField;
                    /*0xd8*/ UnityEngine.Transform <EnemyActorStatusIconsGroup>k__BackingField;
                    /*0xe0*/ UnityEngine.Transform <WorldCanvas>k__BackingField;
                    /*0xe8*/ Assets.Battle.Hud.ResultNavigation <ResultNavigation>k__BackingField;
                    /*0xf0*/ Assets.Battle.Hud.ResultBackground <ResultBackground>k__BackingField;
                    /*0xf8*/ Assets.Battle.Hud.ResultRewardsView <ResultRewardsView>k__BackingField;
                    /*0x100*/ Assets.Battle.Hud.ResultLevelProgress <ResultLevelProgress>k__BackingField;
                    /*0x108*/ Assets.Battle.Hud.ResultRankProgress <ResultRankProgress>k__BackingField;
                    /*0x110*/ Assets.Battle.Hud.ResultDamageView <ResultDamageView>k__BackingField;
                    /*0x118*/ UnityEngine.Transform <NavigationParentLayer>k__BackingField;
                    /*0x120*/ UnityEngine.Transform <NavigationOverlayParentLayer>k__BackingField;
                    /*0x128*/ UnityEngine.Transform <NavigationHud>k__BackingField;
                    /*0x130*/ UnityEngine.Transform <ResultLayerParentAnchor>k__BackingField;
                    /*0x138*/ UnityEngine.Transform <BottomHud>k__BackingField;
                    /*0x140*/ UnityEngine.Transform <BottomOverlayHud>k__BackingField;
                    /*0x148*/ UnityEngine.Transform <BottomHudParentLowAnchor>k__BackingField;
                    /*0x150*/ UnityEngine.Transform <BottomHudParentHightAnchor>k__BackingField;
                    /*0x158*/ UnityEngine.Transform <BottomHudOverlayParentLowAnchor>k__BackingField;
                    /*0x160*/ UnityEngine.Transform <BottomHudOverlayParentHightAnchor>k__BackingField;
                    /*0x168*/ Assets.Battle.Hud.ActorDetails <ActorDetails>k__BackingField;
                    /*0x170*/ UnityEngine.UI.Button <CloseActorDetailsButton>k__BackingField;
                    /*0x178*/ UnityEngine.UI.Button <ActorDetailsRightScrollButton>k__BackingField;
                    /*0x180*/ UnityEngine.UI.Button <ActorDetailsLeftScrollButton>k__BackingField;
                    /*0x188*/ UnityEngine.UI.Button <SpeedLock>k__BackingField;
                    /*0x190*/ UnityEngine.UI.Button <CameraChangeLock>k__BackingField;
                    /*0x198*/ UnityEngine.UI.Button <CockpitViewChangeLock>k__BackingField;
                    /*0x1a0*/ Assets.Battle.Hud.MvpDataView <MvpDataView>k__BackingField;

                    /*0x3cec1b4*/ Arguments();
                    /*0x3cebddc*/ UnityEngine.UI.Image get_OverlayFade();
                    /*0x3cebde4*/ void set_OverlayFade(UnityEngine.UI.Image value);
                    /*0x3cebdec*/ UnityEngine.GameObject get_PlayerPauseLabel();
                    /*0x3cebdf4*/ void set_PlayerPauseLabel(UnityEngine.GameObject value);
                    /*0x3cebdfc*/ UnityEngine.GameObject get_EnemyPauseLabel();
                    /*0x3cebe04*/ void set_EnemyPauseLabel(UnityEngine.GameObject value);
                    /*0x3cebe0c*/ UnityEngine.GameObject get_PauseHeader();
                    /*0x3cebe14*/ void set_PauseHeader(UnityEngine.GameObject value);
                    /*0x3cebe1c*/ UnityEngine.GameObject get_PauseFade();
                    /*0x3cebe24*/ void set_PauseFade(UnityEngine.GameObject value);
                    /*0x3cebe2c*/ Assets.Battle.Hud.PositionLegend get_PositionLegend();
                    /*0x3cebe34*/ void set_PositionLegend(Assets.Battle.Hud.PositionLegend value);
                    /*0x3cebe3c*/ Assets.Battle.Hud.BossHealthGauge get_BossHealthGauge();
                    /*0x3cebe44*/ void set_BossHealthGauge(Assets.Battle.Hud.BossHealthGauge value);
                    /*0x3cebe4c*/ Assets.Battle.Hud.CombinedGauge get_TeamHealthGauge();
                    /*0x3cebe54*/ void set_TeamHealthGauge(Assets.Battle.Hud.CombinedGauge value);
                    /*0x3cebe5c*/ Assets.Battle.Hud.ActionQueue get_ActionQueue();
                    /*0x3cebe64*/ void set_ActionQueue(Assets.Battle.Hud.ActionQueue value);
                    /*0x3cebe6c*/ TMPro.TextMeshProUGUI get_TurnText();
                    /*0x3cebe74*/ void set_TurnText(TMPro.TextMeshProUGUI value);
                    /*0x3cebe7c*/ TMPro.TextMeshProUGUI get_QuestText();
                    /*0x3cebe84*/ void set_QuestText(TMPro.TextMeshProUGUI value);
                    /*0x3cebe8c*/ UnityEngine.UI.Button get_SkipButton();
                    /*0x3cebe94*/ void set_SkipButton(UnityEngine.UI.Button value);
                    /*0x3cebe9c*/ UnityEngine.UI.Button get_SkipLock();
                    /*0x3cebea4*/ void set_SkipLock(UnityEngine.UI.Button value);
                    /*0x3cebeac*/ UnityEngine.UI.Button get_SpeedButton();
                    /*0x3cebeb4*/ void set_SpeedButton(UnityEngine.UI.Button value);
                    /*0x3cebebc*/ UnityEngine.UI.Button get_PauseButton();
                    /*0x3cebec4*/ void set_PauseButton(UnityEngine.UI.Button value);
                    /*0x3cebecc*/ UnityEngine.UI.Button get_ClosePauseButton();
                    /*0x3cebed4*/ void set_ClosePauseButton(UnityEngine.UI.Button value);
                    /*0x3cebedc*/ UnityEngine.UI.Button get_CameraChangeButton();
                    /*0x3cebee4*/ void set_CameraChangeButton(UnityEngine.UI.Button value);
                    /*0x3cebeec*/ UnityEngine.UI.Button get_CockpitViewChangeButton();
                    /*0x3cebef4*/ void set_CockpitViewChangeButton(UnityEngine.UI.Button value);
                    /*0x3cebefc*/ TMPro.TextMeshProUGUI get_SpeedButtonLabel();
                    /*0x3cebf04*/ void set_SpeedButtonLabel(TMPro.TextMeshProUGUI value);
                    /*0x3cebf0c*/ Assets.Battle.Hud.SkillNameLabel get_SkillNameLabel();
                    /*0x3cebf14*/ void set_SkillNameLabel(Assets.Battle.Hud.SkillNameLabel value);
                    /*0x3cebf1c*/ UnityEngine.GameObject get_HudLayer();
                    /*0x3cebf24*/ void set_HudLayer(UnityEngine.GameObject value);
                    /*0x3cebf2c*/ Assets.Battle.Hud.TurnView get_TurnView();
                    /*0x3cebf34*/ void set_TurnView(Assets.Battle.Hud.TurnView value);
                    /*0x3cebf3c*/ UnityEngine.Transform get_PlayerActorIconsGroup();
                    /*0x3cebf44*/ void set_PlayerActorIconsGroup(UnityEngine.Transform value);
                    /*0x3cebf4c*/ UnityEngine.Transform get_EnemyActorIconsGroup();
                    /*0x3cebf54*/ void set_EnemyActorIconsGroup(UnityEngine.Transform value);
                    /*0x3cebf5c*/ UnityEngine.Transform get_PlayerActorStatusIconsGroup();
                    /*0x3cebf64*/ void set_PlayerActorStatusIconsGroup(UnityEngine.Transform value);
                    /*0x3cebf6c*/ UnityEngine.Transform get_EnemyActorStatusIconsGroup();
                    /*0x3cebf74*/ void set_EnemyActorStatusIconsGroup(UnityEngine.Transform value);
                    /*0x3cebf7c*/ UnityEngine.Transform get_WorldCanvas();
                    /*0x3cebf84*/ void set_WorldCanvas(UnityEngine.Transform value);
                    /*0x3cebf8c*/ Assets.Battle.Hud.ResultNavigation get_ResultNavigation();
                    /*0x3cebf94*/ void set_ResultNavigation(Assets.Battle.Hud.ResultNavigation value);
                    /*0x3cebf9c*/ Assets.Battle.Hud.ResultBackground get_ResultBackground();
                    /*0x3cebfa4*/ void set_ResultBackground(Assets.Battle.Hud.ResultBackground value);
                    /*0x3cebfac*/ Assets.Battle.Hud.ResultRewardsView get_ResultRewardsView();
                    /*0x3cebfb4*/ void set_ResultRewardsView(Assets.Battle.Hud.ResultRewardsView value);
                    /*0x3cebfbc*/ Assets.Battle.Hud.ResultLevelProgress get_ResultLevelProgress();
                    /*0x3cebfc4*/ void set_ResultLevelProgress(Assets.Battle.Hud.ResultLevelProgress value);
                    /*0x3cebfd4*/ Assets.Battle.Hud.ResultRankProgress get_ResultRankProgress();
                    /*0x3cebfdc*/ void set_ResultRankProgress(Assets.Battle.Hud.ResultRankProgress value);
                    /*0x3cebfec*/ Assets.Battle.Hud.ResultDamageView get_ResultDamageView();
                    /*0x3cebff4*/ void set_ResultDamageView(Assets.Battle.Hud.ResultDamageView value);
                    /*0x3cec004*/ UnityEngine.Transform get_NavigationParentLayer();
                    /*0x3cec00c*/ void set_NavigationParentLayer(UnityEngine.Transform value);
                    /*0x3cec01c*/ UnityEngine.Transform get_NavigationOverlayParentLayer();
                    /*0x3cec024*/ void set_NavigationOverlayParentLayer(UnityEngine.Transform value);
                    /*0x3cec034*/ UnityEngine.Transform get_NavigationHud();
                    /*0x3cec03c*/ void set_NavigationHud(UnityEngine.Transform value);
                    /*0x3cec04c*/ UnityEngine.Transform get_ResultLayerParentAnchor();
                    /*0x3cec054*/ void set_ResultLayerParentAnchor(UnityEngine.Transform value);
                    /*0x3cec064*/ UnityEngine.Transform get_BottomHud();
                    /*0x3cec06c*/ void set_BottomHud(UnityEngine.Transform value);
                    /*0x3cec07c*/ UnityEngine.Transform get_BottomOverlayHud();
                    /*0x3cec084*/ void set_BottomOverlayHud(UnityEngine.Transform value);
                    /*0x3cec094*/ UnityEngine.Transform get_BottomHudParentLowAnchor();
                    /*0x3cec09c*/ void set_BottomHudParentLowAnchor(UnityEngine.Transform value);
                    /*0x3cec0ac*/ UnityEngine.Transform get_BottomHudParentHightAnchor();
                    /*0x3cec0b4*/ void set_BottomHudParentHightAnchor(UnityEngine.Transform value);
                    /*0x3cec0c4*/ UnityEngine.Transform get_BottomHudOverlayParentLowAnchor();
                    /*0x3cec0cc*/ void set_BottomHudOverlayParentLowAnchor(UnityEngine.Transform value);
                    /*0x3cec0dc*/ UnityEngine.Transform get_BottomHudOverlayParentHightAnchor();
                    /*0x3cec0e4*/ void set_BottomHudOverlayParentHightAnchor(UnityEngine.Transform value);
                    /*0x3cec0f4*/ Assets.Battle.Hud.ActorDetails get_ActorDetails();
                    /*0x3cec0fc*/ void set_ActorDetails(Assets.Battle.Hud.ActorDetails value);
                    /*0x3cec10c*/ UnityEngine.UI.Button get_CloseActorDetailsButton();
                    /*0x3cec114*/ void set_CloseActorDetailsButton(UnityEngine.UI.Button value);
                    /*0x3cec124*/ UnityEngine.UI.Button get_ActorDetailsRightScrollButton();
                    /*0x3cec12c*/ void set_ActorDetailsRightScrollButton(UnityEngine.UI.Button value);
                    /*0x3cec13c*/ UnityEngine.UI.Button get_ActorDetailsLeftScrollButton();
                    /*0x3cec144*/ void set_ActorDetailsLeftScrollButton(UnityEngine.UI.Button value);
                    /*0x3cec154*/ UnityEngine.UI.Button get_SpeedLock();
                    /*0x3cec15c*/ void set_SpeedLock(UnityEngine.UI.Button value);
                    /*0x3cec16c*/ UnityEngine.UI.Button get_CameraChangeLock();
                    /*0x3cec174*/ void set_CameraChangeLock(UnityEngine.UI.Button value);
                    /*0x3cec184*/ UnityEngine.UI.Button get_CockpitViewChangeLock();
                    /*0x3cec18c*/ void set_CockpitViewChangeLock(UnityEngine.UI.Button value);
                    /*0x3cec19c*/ Assets.Battle.Hud.MvpDataView get_MvpDataView();
                    /*0x3cec1a4*/ void set_MvpDataView(Assets.Battle.Hud.MvpDataView value);
                }
            }

            interface IHudOverseer
            {
                /*0x38148bc*/ UnityEngine.Events.UnityEvent get_OnUiButtonClicked();
                Cysharp.Threading.Tasks.UniTask OverlayFadeFadeIn(float duration);
                Cysharp.Threading.Tasks.UniTask OverlayFadeFadeOut(float duration);
                /*0x3816710*/ void AddToLegend(Assets.Api.Client.PawnView pawn);
                /*0x38159dc*/ void AdvanceActionQueue();
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusIcon> CreateActorStatusIcon(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorWorldStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                Cysharp.Threading.Tasks.UniTask InitializeBossGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool showScoreView);
                Cysharp.Threading.Tasks.UniTask PlaybackTurnAnimation(int turn, int turnsCount);
                /*0x3815cc4*/ void SetHudActive(bool active);
                /*0x3815cc4*/ void SetIntractability(bool interactable);
                /*0x3815cc4*/ void SetTeamHealthGaugeState(bool active);
                /*0x3816000*/ void ShowResultBackground(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, System.Action onFadeComplete);
                Cysharp.Threading.Tasks.UniTask ShowResultDamageView(string rankData, string damage, string damagePercentage, bool newRecord, bool showPercentage);
                Cysharp.Threading.Tasks.UniTask ShowResultLevelProgress(Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments);
                /*0x3815fb8*/ void ShowResultNavigation(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType);
                Cysharp.Threading.Tasks.UniTask ShowResultRankProgress(int currentPoints, int maxPoints, int rank);
                Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.Icon.IconBase.IconArgs[] rewards);
                Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs[] rewards);
                void ShowSkillLabel(string skillName, bool isEnemyActor, Assets.Api.Client.SkillTypes skillType, int pointAmount);
                Cysharp.Threading.Tasks.UniTask UpdateActionQueue(Assets.Battle.Actor[] actors);
                void UpdateActorsIconPositions(Assets.Battle.Actor[] actors, bool isEnemyIcons);
                /*0x3816810*/ void UpdateBossHealthGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x381630c*/ void UpdateBossScoreValue(long value);
                Cysharp.Threading.Tasks.UniTask UpdateTeamHealthGauge(long leftCurrent, long leftMax, long rightCurrent, long rightMax);
                /*0x3815cc4*/ void SetSkipAvaiability(bool available);
                /*0x3815cc4*/ void ChangeCockpitViewHudActive(bool value);
                /*0x3814574*/ Assets.Battle.Hud.CombinedGauge.StateTypes GetCurrentTeamHealthGaugeState();
                /*0x38159dc*/ void HideBossGauge();
                /*0x38159dc*/ void Clear();
                void SetIconsInIconGroupActive(bool active, bool isEnemyGroup);
                /*0x3815cc4*/ void SetSpeedAvaiability(bool available);
                /*0x3815cc4*/ void SetCameraChangeAvaiability(bool available);
                /*0x3815cc4*/ void SetCockpitViewChangeAvaiability(bool available);
                void ShowMvpDataView(Assets.GameUi.BattleArguments.BattleTypes battleType, Assets.Api.Client.PawnId attacker, Assets.Api.Client.PawnId defender, Assets.Api.Client.PawnId healer);
            }

            class HudOverseer : Assets.Battle.Overseers.IHudOverseer, Assets.Battle.Overseers.IHudOverseerUnityFacade, Assets.Battle.Shared.ISharedHudOverseer, System.IDisposable
            {
                /*0x10*/ Assets.AssetManagement.IAssetInstanceProvider instanceProvider;
                /*0x18*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
                /*0x28*/ Assets.Battle.ICache cache;
                /*0x30*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x38*/ Assets.AssetManagement.ITextureAssetProvider textureAssetProvider;
                /*0x40*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x48*/ UniRx.CompositeDisposable disposables;
                /*0x50*/ System.Collections.Generic.List<Assets.Battle.Hud.ActorStatusView> activeActorStatusViews;
                /*0x58*/ Assets.Battle.Hud.ActionQueue actionQueue;
                /*0x60*/ Assets.Battle.Hud.SkillNameLabel skillNameLabel;
                /*0x68*/ UnityEngine.GameObject hudLayer;
                /*0x70*/ Assets.Battle.Hud.TurnView turnView;
                /*0x78*/ UnityEngine.Transform playerActorIconsGroup;
                /*0x80*/ UnityEngine.Transform enemyActorIconsGroup;
                /*0x88*/ UnityEngine.Transform playerActorStatusIconsGroup;
                /*0x90*/ UnityEngine.Transform enemyActorStatusIconsGroup;
                /*0x98*/ UnityEngine.UI.Button skipButton;
                /*0xa0*/ UnityEngine.UI.Button speedButton;
                /*0xa8*/ UnityEngine.UI.Button cameraChangeButton;
                /*0xb0*/ UnityEngine.UI.Button pauseButton;
                /*0xb8*/ UnityEngine.UI.Button closePauseButton;
                /*0xc0*/ UnityEngine.UI.Button cockpitViewChangeButton;
                /*0xc8*/ UnityEngine.Transform worldCanvas;
                /*0xd0*/ Assets.Battle.Hud.ResultNavigation resultNavigation;
                /*0xd8*/ Assets.Battle.Hud.ResultBackground resultBackground;
                /*0xe0*/ Assets.Battle.Hud.ResultRewardsView rewardsView;
                /*0xe8*/ Assets.Battle.Hud.ResultLevelProgress resultLevelProgress;
                /*0xf0*/ Assets.Battle.Hud.ResultRankProgress resultRankProgress;
                /*0xf8*/ Assets.Battle.Hud.ResultDamageView resultDamageView;
                /*0x100*/ Assets.Battle.Hud.BossHealthGauge bossHealthGauge;
                /*0x108*/ Assets.Battle.Hud.CombinedGauge teamHealthGauge;
                /*0x110*/ Assets.Battle.Hud.PositionLegend positionLegend;
                /*0x118*/ UnityEngine.GameObject pauseHeader;
                /*0x120*/ UnityEngine.GameObject pauseFade;
                /*0x128*/ UnityEngine.GameObject playerPauseLabel;
                /*0x130*/ UnityEngine.GameObject enemyPauseLabel;
                /*0x138*/ UnityEngine.UI.Image overlayFade;
                /*0x140*/ UnityEngine.Transform navigationHud;
                /*0x148*/ UnityEngine.Transform navigationParentLayer;
                /*0x150*/ UnityEngine.Transform navigationOverlayParentLayer;
                /*0x158*/ UnityEngine.Transform resultLayerParentAnchor;
                /*0x160*/ UnityEngine.Transform bottomHud;
                /*0x168*/ UnityEngine.Transform bottomOverlayHud;
                /*0x170*/ UnityEngine.Transform bottomHudParentLowAnchor;
                /*0x178*/ UnityEngine.Transform bottomHudParentHightAnchor;
                /*0x180*/ UnityEngine.Transform bottomHudOverlayParentLowAnchor;
                /*0x188*/ UnityEngine.Transform bottomHudOverlayParentHightAnchor;
                /*0x190*/ Assets.Battle.Hud.ActorDetails actorDetails;
                /*0x198*/ UnityEngine.UI.Button closeActorDetailsButton;
                /*0x1a0*/ UnityEngine.UI.Button actorDetailsRightScrollButton;
                /*0x1a8*/ UnityEngine.UI.Button actorDetailsLeftScrollButton;
                /*0x1b0*/ UnityEngine.UI.Button skipLock;
                /*0x1b8*/ UnityEngine.UI.Button speedLock;
                /*0x1c0*/ UnityEngine.UI.Button cameraChangeLock;
                /*0x1c8*/ UnityEngine.UI.Button cockpitViewChangeLock;
                /*0x1d0*/ Assets.Battle.Hud.MvpDataView mvpDataView;
                /*0x1d8*/ UnityEngine.Events.UnityEvent <OnUiButtonClicked>k__BackingField;

                /*0x3cec1c4*/ HudOverseer(Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.Battle.ICache cache, Assets.GameUi.Externals.IAudioManager audioManager, Assets.AssetManagement.ITextureAssetProvider textureAssetProvider, Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3cec1bc*/ UnityEngine.Events.UnityEvent get_OnUiButtonClicked();
                /*0x3cec360*/ void Initialize(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x3ceca10*/ void InitializeSubscriptions(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x3ced1d8*/ void ShowMvpDataView(Assets.GameUi.BattleArguments.BattleTypes battleType, Assets.Api.Client.PawnId attacker, Assets.Api.Client.PawnId defender, Assets.Api.Client.PawnId healer);
                /*0x3ced25c*/ void SetTeamHealthGaugeState(bool active);
                /*0x3ced27c*/ Cysharp.Threading.Tasks.UniTask UpdateTeamHealthGauge(long leftCurrent, long leftMax, long rightCurrent, long rightMax);
                /*0x3ced2a0*/ Assets.Battle.Hud.CombinedGauge.StateTypes GetCurrentTeamHealthGaugeState();
                /*0x3ced2bc*/ void AddToLegend(Assets.Api.Client.PawnView pawn);
                /*0x3ced2d8*/ void HideBossGauge();
                /*0x3ced304*/ Cysharp.Threading.Tasks.UniTask InitializeBossGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool showScoreView);
                /*0x3ced408*/ void UpdateBossHealthGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3ced424*/ void UpdateBossScoreValue(long value);
                /*0x3cec760*/ void InitializeButtons();
                /*0x3ced440*/ void SetHudActive(bool active);
                /*0x3ced460*/ void SetLocksActive(bool active);
                /*0x3ced4a8*/ void SetSkipAvaiability(bool available);
                /*0x3ced508*/ void SetSpeedAvaiability(bool available);
                /*0x3ced568*/ void SetCameraChangeAvaiability(bool available);
                /*0x3ced5c8*/ void SetCockpitViewChangeAvaiability(bool available);
                /*0x3ced628*/ void SetPauseMenuActive(bool active);
                /*0x3ced7c0*/ Cysharp.Threading.Tasks.UniTask PlaybackTurnAnimation(int turn, int turnsCount);
                /*0x3ced054*/ void SetIntractability(bool interactable);
                /*0x3ced7dc*/ void ShowSkillLabel(string skillName, bool isEnemyActor, Assets.Api.Client.SkillTypes skillType, int pointAmount);
                /*0x3ced804*/ Cysharp.Threading.Tasks.UniTask OverlayFadeFadeIn(float duration);
                /*0x3ced870*/ Cysharp.Threading.Tasks.UniTask OverlayFadeFadeOut(float duration);
                /*0x3ced8d8*/ Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.Icon.IconBase.IconArgs[] rewards);
                /*0x3ced928*/ Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs[] rewards);
                /*0x3ced978*/ void ShowResultBackground(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, System.Action onFadeComplete);
                /*0x3ced994*/ void ShowResultNavigation(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType);
                /*0x3ceda70*/ Cysharp.Threading.Tasks.UniTask ShowResultLevelProgress(Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments);
                /*0x3cedac0*/ Cysharp.Threading.Tasks.UniTask ShowResultRankProgress(int currentPoints, int maxPoints, int rank);
                /*0x3cedb28*/ Cysharp.Threading.Tasks.UniTask ShowResultDamageView(string rankData, string damage, string damagePercentage, bool newRecord, bool showPercentage);
                /*0x3cedba8*/ void ProcessCockpitViewButtonClick();
                /*0x3cedd0c*/ void ProcessCameraChangeButtonClick();
                /*0x3cedee4*/ void ProcessPauseButtonClick();
                /*0x3cee1d0*/ void UpdateEnemyActorIconsGroupTransform();
                /*0x3cee4e8*/ void SetIconsInIconGroupActive(bool active, bool isEnemyGroup);
                /*0x3cee3b4*/ void ChangeCockpitViewHudActive(bool value);
                /*0x3cee368*/ void RestoreParentRelations();
                /*0x3ceea7c*/ void ProcessCloseActorDetailsClick();
                /*0x3ceeddc*/ void ProcessSkipButtonClick();
                /*0x3ceee9c*/ void ProcessSpeedButtonClick();
                /*0x3ceef50*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorWorldStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3cef08c*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3cef1bc*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusIcon> CreateActorStatusIcon(Assets.Battle.Actor actor);
                /*0x3cef2d4*/ void UpdateActorsIconPositions(Assets.Battle.Actor[] actors, bool isEnemyIcons);
                /*0x3cef490*/ void Clear();
                /*0x3cef620*/ Cysharp.Threading.Tasks.UniTask UpdateActionQueue(Assets.Battle.Actor[] actors);
                /*0x3cef63c*/ void AdvanceActionQueue();
                /*0x3cef658*/ void Dispose();
                /*0x3cef674*/ void <InitializeButtons>b__72_0();
                /*0x3cef678*/ void <InitializeButtons>b__72_1();
                /*0x3cef67c*/ void <InitializeButtons>b__72_2();
                /*0x3cef680*/ void <InitializeButtons>b__72_3();
                /*0x3cef684*/ void <InitializeButtons>b__72_4();
                /*0x3cef688*/ void <InitializeButtons>b__72_5();
                /*0x3cef68c*/ void <InitializeButtons>b__72_6();

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Overseers.HudOverseer.<> <>9;
                    static /*0x8*/ System.Action<float> <>9__62_1;
                    static /*0x10*/ System.Func<Assets.Battle.Actor, int> <>9__103_1;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, int> <>9__105_0;

                    static /*0x3cef690*/ <>c();
                    /*0x3cef6f8*/ <>c();
                    /*0x3cef700*/ void <InitializeSubscriptions>b__62_1(float speed);
                    /*0x3cef708*/ int <CreateActorStatusView>b__103_1(Assets.Battle.Actor a);
                    /*0x3cef720*/ int <UpdateActorsIconPositions>b__105_0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass103_0
                {
                    /*0x10*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x18*/ Assets.Battle.Actor actor;

                    /*0x3cef738*/ <>c__DisplayClass103_0();
                    /*0x3cef740*/ void <CreateActorStatusView>b__0();
                }

                class <>c__DisplayClass103_1
                {
                    /*0x10*/ Assets.Battle.Actor[] relatedActors;
                    /*0x18*/ int index;
                    /*0x20*/ Assets.Battle.Overseers.HudOverseer.<> CS$<>8__locals1;

                    /*0x3cefdc4*/ <>c__DisplayClass103_1();
                    /*0x3cefdcc*/ void <CreateActorStatusView>b__2();
                    /*0x3cefe38*/ void <CreateActorStatusView>b__3();
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments;
                    /*0x18*/ Assets.Battle.Overseers.HudOverseer <>4__this;

                    /*0x3ced1d0*/ <>c__DisplayClass62_0();
                    /*0x3cefea0*/ void <InitializeSubscriptions>b__0(int speed);
                    /*0x3ceff44*/ void <InitializeSubscriptions>b__2(System.ValueTuple<int, int> value);
                    /*0x3cf000c*/ void <InitializeSubscriptions>b__3(string quest);
                    /*0x3cf0038*/ void <InitializeSubscriptions>b__4(bool value);
                    /*0x3cf0054*/ void <InitializeSubscriptions>b__5(bool value);
                }

                struct <CreateActorStatusIcon>d__104 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Hud.ActorStatusIcon> <>t__builder;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActorStatusIcon> <>u__1;

                    /*0x3cf0110*/ void MoveNext();
                    /*0x3cf07b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <CreateActorStatusView>d__103 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Hud.ActorStatusView> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Assets.Battle.Overseers.HudOverseer.<> <>8__1;
                    /*0x48*/ Assets.Api.Client.StatusView status;
                    /*0x50*/ Assets.Battle.Hud.ActorStatusView <view>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActorStatusView> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3cf0810*/ void MoveNext();
                    /*0x3cf1410*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <CreateActorWorldStatusView>d__102 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Hud.ActorStatusView> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Assets.Api.Client.StatusView status;
                    /*0x48*/ Assets.Battle.Hud.ActorStatusView <icon>5__2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActorStatusView> <>u__1;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3cf1468*/ void MoveNext();
                    /*0x3cf20d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <InitializeBossGauge>d__69 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Assets.Api.Client.StatusView status;
                    /*0x40*/ bool showScoreView;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cf3bf4*/ void MoveNext();
                    /*0x3cf40dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ILayoutOverseerUnityFacade
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ILayoutOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <CinemachineLayer>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <ActorsLayer>k__BackingField;
                    /*0x20*/ UnityEngine.Transform <FieldLayer>k__BackingField;

                    /*0x3cf4118*/ Arguments();
                    /*0x3cf40e8*/ UnityEngine.Transform get_CinemachineLayer();
                    /*0x3cf40f0*/ void set_CinemachineLayer(UnityEngine.Transform value);
                    /*0x3cf40f8*/ UnityEngine.Transform get_ActorsLayer();
                    /*0x3cf4100*/ void set_ActorsLayer(UnityEngine.Transform value);
                    /*0x3cf4108*/ UnityEngine.Transform get_FieldLayer();
                    /*0x3cf4110*/ void set_FieldLayer(UnityEngine.Transform value);
                }
            }

            interface ILayoutOverseer
            {
                /*0x38148bc*/ UnityEngine.Transform get_ActorsLayer();
                /*0x38148bc*/ UnityEngine.Transform get_CinemachineLayer();
                /*0x38148bc*/ UnityEngine.Transform get_FieldLayer();
            }

            class LayoutOverseer : Assets.Battle.Overseers.ILayoutOverseer, Assets.Battle.Overseers.ILayoutOverseerUnityFacade
            {
                /*0x10*/ Assets.Battle.Overseers.ILayoutOverseerUnityFacade.Arguments arguments;

                /*0x3cf417c*/ LayoutOverseer();
                /*0x3cf4120*/ UnityEngine.Transform get_CinemachineLayer();
                /*0x3cf413c*/ UnityEngine.Transform get_ActorsLayer();
                /*0x3cf4158*/ UnityEngine.Transform get_FieldLayer();
                /*0x3cf4174*/ void Initialize(Assets.Battle.Overseers.ILayoutOverseerUnityFacade.Arguments arguments);
            }

            interface ITutorialOverseerUnityFacade
            {
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.ITutorialOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.RectTransform <FirstSlotHighlight>k__BackingField;
                    /*0x18*/ UnityEngine.RectTransform <FirstSlotExtraGaugeHighlight>k__BackingField;
                    /*0x20*/ UnityEngine.RectTransform <ResultTips>k__BackingField;
                    /*0x28*/ UnityEngine.RectTransform <ActorsOrderList>k__BackingField;
                    /*0x30*/ UnityEngine.RectTransform <PlayerActorIconFirstSlotAP>k__BackingField;
                    /*0x38*/ UnityEngine.RectTransform <PlayerActorIconFirstSlotPP>k__BackingField;
                    /*0x40*/ UnityEngine.RectTransform <PlayerActorIconSecondSlotPP>k__BackingField;
                    /*0x48*/ UnityEngine.RectTransform <SpeedButton>k__BackingField;
                    /*0x50*/ UnityEngine.RectTransform <CameraChangeButton>k__BackingField;
                    /*0x58*/ UnityEngine.RectTransform <CockpitViewChangeButton>k__BackingField;

                    /*0x3cf4224*/ Arguments();
                    /*0x3cf4184*/ UnityEngine.RectTransform get_FirstSlotHighlight();
                    /*0x3cf418c*/ void set_FirstSlotHighlight(UnityEngine.RectTransform value);
                    /*0x3cf4194*/ UnityEngine.RectTransform get_FirstSlotExtraGaugeHighlight();
                    /*0x3cf419c*/ void set_FirstSlotExtraGaugeHighlight(UnityEngine.RectTransform value);
                    /*0x3cf41a4*/ UnityEngine.RectTransform get_ResultTips();
                    /*0x3cf41ac*/ void set_ResultTips(UnityEngine.RectTransform value);
                    /*0x3cf41b4*/ UnityEngine.RectTransform get_ActorsOrderList();
                    /*0x3cf41bc*/ void set_ActorsOrderList(UnityEngine.RectTransform value);
                    /*0x3cf41c4*/ UnityEngine.RectTransform get_PlayerActorIconFirstSlotAP();
                    /*0x3cf41cc*/ void set_PlayerActorIconFirstSlotAP(UnityEngine.RectTransform value);
                    /*0x3cf41d4*/ UnityEngine.RectTransform get_PlayerActorIconFirstSlotPP();
                    /*0x3cf41dc*/ void set_PlayerActorIconFirstSlotPP(UnityEngine.RectTransform value);
                    /*0x3cf41e4*/ UnityEngine.RectTransform get_PlayerActorIconSecondSlotPP();
                    /*0x3cf41ec*/ void set_PlayerActorIconSecondSlotPP(UnityEngine.RectTransform value);
                    /*0x3cf41f4*/ UnityEngine.RectTransform get_SpeedButton();
                    /*0x3cf41fc*/ void set_SpeedButton(UnityEngine.RectTransform value);
                    /*0x3cf4204*/ UnityEngine.RectTransform get_CameraChangeButton();
                    /*0x3cf420c*/ void set_CameraChangeButton(UnityEngine.RectTransform value);
                    /*0x3cf4214*/ UnityEngine.RectTransform get_CockpitViewChangeButton();
                    /*0x3cf421c*/ void set_CockpitViewChangeButton(UnityEngine.RectTransform value);
                }
            }

            interface ITutorialOverseer
            {
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AwaitForProcessor();
                /*0x3815874*/ Cysharp.Threading.Tasks.UniTask AwaitForUserInput();
                /*0x3814a3c*/ Assets.Api.Client.IBattleEngineEvent[] InjectCockpitViewUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3814a3c*/ Assets.Api.Client.IBattleEngineEvent[] InjectFirstTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3814a3c*/ Assets.Api.Client.IBattleEngineEvent[] InjectMazeTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3814a3c*/ Assets.Api.Client.IBattleEngineEvent[] InjectSecondTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3814a3c*/ Assets.Api.Client.IBattleEngineEvent[] InjectSpeedAndCameraChangeUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x38159dc*/ void TerminateActiveProcessor();
                /*0x3816710*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData data);
                /*0x3816710*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData[] data);
                /*0x38159dc*/ void TryReplayResultTutorialMessages();
                /*0x38159dc*/ void TryTriggerNextMessage();
            }

            class TutorialOverseer : Assets.Battle.Overseers.ITutorialOverseer, Assets.Battle.Overseers.ITutorialOverseerUnityFacade
            {
                static string TextColorPink = "#fa3c8c";
                static string TextColorBlue = "#0096ff";
                static string TextColorRed = "#ff1c0b";
                /*0x10*/ Assets.GameUi.Service.Tutorial.ITutorialService tutorialService;
                /*0x18*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x20*/ Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService;
                /*0x28*/ UnityEngine.RectTransform playerActorIconFirstSlot;
                /*0x30*/ UnityEngine.RectTransform playerActorIconSecondSlotExtraSkillGauge;
                /*0x38*/ UnityEngine.RectTransform resultTips;
                /*0x40*/ UnityEngine.RectTransform actorsOrderList;
                /*0x48*/ UnityEngine.RectTransform playerActorIconFirstSlotAP;
                /*0x50*/ UnityEngine.RectTransform playerActorIconFirstSlotPP;
                /*0x58*/ UnityEngine.RectTransform playerActorIconSecondSlotPP;
                /*0x60*/ UnityEngine.RectTransform speedButton;
                /*0x68*/ UnityEngine.RectTransform cameraChangeButton;
                /*0x70*/ UnityEngine.RectTransform cockpitViewChangeButton;
                /*0x78*/ Assets.GameUi.Service.Tutorial.TutorialGuideProcessor activeProcessor;
                /*0x80*/ Cysharp.Threading.Tasks.UniTaskCompletionSource activeCompletionSource;
                /*0x88*/ Assets.Battle.Overseers.TutorialMessageData[] resultInjection;

                /*0x3cf422c*/ TutorialOverseer(Assets.GameUi.Service.Tutorial.ITutorialService tutorialService, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService);
                /*0x3cf431c*/ void Initialize(Assets.Battle.Overseers.ITutorialOverseerUnityFacade.Arguments arguments);
                /*0x3cf43d8*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData data);
                /*0x3cf4730*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData[] data);
                /*0x3cf4b24*/ Cysharp.Threading.Tasks.UniTask AwaitForProcessor();
                /*0x3cf4b98*/ void TryTriggerNextMessage();
                /*0x3cf4c4c*/ void TryReplayResultTutorialMessages();
                /*0x3cf4c74*/ UnityEngine.RectTransform GetHighlightRect(Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes highlight);
                /*0x3cf4cf4*/ void TerminateActiveProcessor();
                /*0x3cf4d28*/ Cysharp.Threading.Tasks.UniTask AwaitForUserInput();
                /*0x3cf4f34*/ Assets.Api.Client.IBattleEngineEvent[] InjectFirstTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cf5d84*/ Assets.Api.Client.IBattleEngineEvent[] InjectSecondTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cf6f54*/ Assets.Api.Client.IBattleEngineEvent[] InjectMazeTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cf72e8*/ Assets.Api.Client.IBattleEngineEvent[] InjectSpeedAndCameraChangeUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cf78cc*/ Assets.Api.Client.IBattleEngineEvent[] InjectCockpitViewUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cf5918*/ Assets.Api.Client.IBattleEngineEvent[] InjectTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events, System.Collections.Generic.List<Assets.Battle.Overseers.TutorialOverseer.MessageInjectionDescriptor> injectionDescriptors);
                /*0x3cf7ec4*/ void <ThrowTutorialMessage>b__21_0();
                /*0x3cf7ef0*/ void <ThrowTutorialMessage>b__22_0();
                /*0x3cf7f1c*/ bool <InjectSecondTutorialMessages>b__30_3(Assets.Api.Client.IBattleEngineEvent eventData);
                /*0x3cf815c*/ bool <InjectSecondTutorialMessages>b__30_6(Assets.Api.Client.IBattleEngineEvent eventData);
                /*0x3cf839c*/ bool <InjectSecondTutorialMessages>b__30_9(Assets.Api.Client.IBattleEngineEvent eventData);
                /*0x3cf85ec*/ bool <InjectSecondTutorialMessages>b__30_12(Assets.Api.Client.IBattleEngineEvent eventData);

                class MessageInjectionDescriptor
                {
                    /*0x10*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <CanBeInjectedBefore>k__BackingField;
                    /*0x18*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <CanBeInjectedAfter>k__BackingField;
                    /*0x20*/ Assets.Api.Client.IBattleEngineEvent <EventData>k__BackingField;
                    /*0x28*/ bool <HasBeenInjected>k__BackingField;

                    /*0x3cf5694*/ MessageInjectionDescriptor();
                    /*0x3cf8838*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> get_CanBeInjectedBefore();
                    /*0x3cf8840*/ void set_CanBeInjectedBefore(System.Func<Assets.Api.Client.IBattleEngineEvent, bool> value);
                    /*0x3cf8848*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> get_CanBeInjectedAfter();
                    /*0x3cf8850*/ void set_CanBeInjectedAfter(System.Func<Assets.Api.Client.IBattleEngineEvent, bool> value);
                    /*0x3cf8858*/ Assets.Api.Client.IBattleEngineEvent get_EventData();
                    /*0x3cf8860*/ void set_EventData(Assets.Api.Client.IBattleEngineEvent value);
                    /*0x3cf8868*/ bool get_HasBeenInjected();
                    /*0x3cf8870*/ void set_HasBeenInjected(bool value);

                    class <>c
                    {
                        static /*0x0*/ Assets.Battle.Overseers.TutorialOverseer.MessageInjectionDescriptor.<> <>9;
                        static /*0x8*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__16_0;
                        static /*0x10*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__16_1;

                        static /*0x3cf887c*/ <>c();
                        /*0x3cf88e4*/ <>c();
                        /*0x3cf88ec*/ bool <.ctor>b__16_0(Assets.Api.Client.IBattleEngineEvent eventData);
                        /*0x3cf88f4*/ bool <.ctor>b__16_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    }
                }

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Overseers.TutorialOverseer.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__29_0;
                    static /*0x10*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__29_1;
                    static /*0x18*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__29_2;
                    static /*0x20*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__29_3;
                    static /*0x28*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_0;
                    static /*0x30*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_1;
                    static /*0x38*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_2;
                    static /*0x40*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_5;
                    static /*0x48*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_8;
                    static /*0x50*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_11;
                    static /*0x58*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_14;
                    static /*0x60*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_15;
                    static /*0x68*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_16;
                    static /*0x70*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__30_17;
                    static /*0x78*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__31_0;
                    static /*0x80*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__31_1;
                    static /*0x88*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__32_0;
                    static /*0x90*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__32_1;
                    static /*0x98*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__33_0;
                    static /*0xa0*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__33_1;

                    static /*0x3cf88fc*/ <>c();
                    /*0x3cf8964*/ <>c();
                    /*0x3cf896c*/ bool <InjectFirstTutorialMessages>b__29_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8974*/ bool <InjectFirstTutorialMessages>b__29_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf89ec*/ bool <InjectFirstTutorialMessages>b__29_2(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf89f4*/ bool <InjectFirstTutorialMessages>b__29_3(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8a84*/ bool <InjectSecondTutorialMessages>b__30_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8a8c*/ bool <InjectSecondTutorialMessages>b__30_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8b1c*/ bool <InjectSecondTutorialMessages>b__30_2(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8b24*/ bool <InjectSecondTutorialMessages>b__30_5(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8b2c*/ bool <InjectSecondTutorialMessages>b__30_8(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8b34*/ bool <InjectSecondTutorialMessages>b__30_11(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8b3c*/ bool <InjectSecondTutorialMessages>b__30_14(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8bcc*/ bool <InjectSecondTutorialMessages>b__30_15(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8bd4*/ bool <InjectSecondTutorialMessages>b__30_16(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8bdc*/ bool <InjectSecondTutorialMessages>b__30_17(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8c7c*/ bool <InjectMazeTutorialMessages>b__31_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8c84*/ bool <InjectMazeTutorialMessages>b__31_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8d14*/ bool <InjectSpeedAndCameraChangeUnlockTutorialMessages>b__32_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8d1c*/ bool <InjectSpeedAndCameraChangeUnlockTutorialMessages>b__32_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8dac*/ bool <InjectCockpitViewUnlockTutorialMessages>b__33_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cf8db4*/ bool <InjectCockpitViewUnlockTutorialMessages>b__33_1(Assets.Api.Client.IBattleEngineEvent eventData);
                }

                class <>c__DisplayClass28_0
                {
                    /*0x10*/ Assets.Battle.Overseers.TutorialOverseer <>4__this;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource completionSource;

                    /*0x3cf4f2c*/ <>c__DisplayClass28_0();
                    /*0x3cf8e44*/ void <AwaitForUserInput>b__0();
                }

                class <>c__DisplayClass30_0
                {
                    /*0x10*/ Assets.Api.Client.PawnPreparesSkillEvent data;

                    /*0x3cf8154*/ <>c__DisplayClass30_0();
                    /*0x3cf8f0c*/ bool <InjectSecondTutorialMessages>b__4(Assets.Api.Client.SkillMasterView s);
                }

                class <>c__DisplayClass30_1
                {
                    /*0x10*/ Assets.Api.Client.PawnUsedSkillEvent data;

                    /*0x3cf8394*/ <>c__DisplayClass30_1();
                    /*0x3cf8f48*/ bool <InjectSecondTutorialMessages>b__7(Assets.Api.Client.SkillMasterView s);
                }

                class <>c__DisplayClass30_2
                {
                    /*0x10*/ Assets.Api.Client.PawnsAreTargetedEvent data;

                    /*0x3cf85e4*/ <>c__DisplayClass30_2();
                    /*0x3cf8f84*/ bool <InjectSecondTutorialMessages>b__10(Assets.Api.Client.SkillMasterView s);
                }

                class <>c__DisplayClass30_3
                {
                    /*0x10*/ Assets.Api.Client.PawnResourcesUpdatedEvent data;

                    /*0x3cf8830*/ <>c__DisplayClass30_3();
                    /*0x3cf8fc0*/ bool <InjectSecondTutorialMessages>b__13(Assets.Api.Client.PawnMasterView s);
                }
            }

            class TutorialMessageData
            {
                /*0x10*/ string <Message>k__BackingField;
                /*0x18*/ string <CharacterAssetId>k__BackingField;
                /*0x20*/ Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes <HighLight>k__BackingField;
                /*0x24*/ float <ZOffset>k__BackingField;
                /*0x28*/ Assets.GameUi.Guide.Narration.NarrationComponent.PositionTypes <PositionType>k__BackingField;
                /*0x2c*/ Assets.GameUi.Guide.Highlight.HoleComponent.ArrowDirection <ArrowDirection>k__BackingField;
                /*0x30*/ bool <DisableAutoContinuation>k__BackingField;

                /*0x3cf58c4*/ TutorialMessageData();
                /*0x3cf8ffc*/ string get_Message();
                /*0x3cf9004*/ void set_Message(string value);
                /*0x3cf900c*/ string get_CharacterAssetId();
                /*0x3cf9014*/ void set_CharacterAssetId(string value);
                /*0x3cf901c*/ Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes get_HighLight();
                /*0x3cf9024*/ void set_HighLight(Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes value);
                /*0x3cf902c*/ float get_ZOffset();
                /*0x3cf9034*/ void set_ZOffset(float value);
                /*0x3cf903c*/ Assets.GameUi.Guide.Narration.NarrationComponent.PositionTypes get_PositionType();
                /*0x3cf9044*/ void set_PositionType(Assets.GameUi.Guide.Narration.NarrationComponent.PositionTypes value);
                /*0x3cf904c*/ Assets.GameUi.Guide.Highlight.HoleComponent.ArrowDirection get_ArrowDirection();
                /*0x3cf9054*/ void set_ArrowDirection(Assets.GameUi.Guide.Highlight.HoleComponent.ArrowDirection value);
                /*0x3cf905c*/ bool get_DisableAutoContinuation();
                /*0x3cf9064*/ void set_DisableAutoContinuation(bool value);
            }

            class TutorialMessageEvent : Assets.Api.Client.IBattleEngineEvent
            {
                /*0x10*/ int <Tick>k__BackingField;
                /*0x18*/ Assets.Battle.Overseers.TutorialMessageData[] <Messages>k__BackingField;

                /*0x3cf5820*/ TutorialMessageEvent();
                /*0x3cf9070*/ int get_Tick();
                /*0x3cf9078*/ void set_Tick(int value);
                /*0x3cf9080*/ Assets.Battle.Overseers.TutorialMessageData[] get_Messages();
                /*0x3cf9088*/ void set_Messages(Assets.Battle.Overseers.TutorialMessageData[] value);

                enum HighlightTypes
                {
                    None = 0,
                    PlayerActorIconFirstSlot = 1,
                    PlayerActorIconFirstSlotExtraSkillGauge = 2,
                    ResultTips = 3,
                    ActorsOrderList = 4,
                    PlayerActorIconFirstSlotAP = 5,
                    PlayerActorIconFirstSlotPP = 6,
                    PlayerActorIconSecondSlotPP = 7,
                    SpeedButton = 8,
                    CameraChangeButton = 9,
                    CockpitViewChangeButton = 10,
                }
            }

            interface IVisualEffectsOverseerUnityFacade
            {
                /*0x3816710*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x38159dc*/ void ClearActorRenderers();
                /*0x38159dc*/ void ClearFieldMaterials();
                /*0x3816710*/ void Initialize(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade.Arguments arguments);
                /*0x3816710*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                /*0x3816710*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                /*0x38159dc*/ void Update();

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <VisualEffectsLayer>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <OverlayLayer>k__BackingField;

                    /*0x3cf90b0*/ Arguments();
                    /*0x3cf9090*/ UnityEngine.Transform get_VisualEffectsLayer();
                    /*0x3cf9098*/ void set_VisualEffectsLayer(UnityEngine.Transform value);
                    /*0x3cf90a0*/ UnityEngine.Transform get_OverlayLayer();
                    /*0x3cf90a8*/ void set_OverlayLayer(UnityEngine.Transform value);
                }
            }

            interface IVisualEffectsOverseer
            {
                void AddActorRenderer(long id, UnityEngine.Renderer target);
                /*0x381630c*/ void RemoveActorRenderer(long id);
                /*0x3816710*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                void PlaybackErosionIn(long id, float duration);
                void PlaybackErosionOut(long id, float duration);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key);
                Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAquireMecanimController(string key);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position);
                /*0x3814a3c*/ string KeyToVfxKey(string key);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
                /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Vector3 scale);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent);
                /*0x3816710*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x38159dc*/ void ClearFieldMaterials();
                /*0x3816710*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                Cysharp.Threading.Tasks.UniTask PlaybackTimeStop(Assets.VisualEffectData.TimeStopParameters parameters);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAquireVfx(UnityEngine.GameObject prefab);
                /*0x3816710*/ void PlaybackColorPunch(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAquireVfxAnimationHandler(string key);
                void PlaybackBetweenState(Assets.Battle.Actor actor, UnityEngine.Color firstColor, UnityEngine.Color secondColor);
                void PlaybackConflagration(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x3816710*/ void StopConflagration(Assets.Battle.Actor actor);
                void PlaybackFreeze(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x3816710*/ void StopFreeze(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandlerOnOverlayLayer(string key);
                UnityEngine.Vector3 AcquireYOffsetedPosition(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 position);
            }

            class VisualEffectsOverseer : Assets.Battle.Overseers.IVisualEffectsOverseer, Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade, Assets.Battle.Shared.ISharedVisualEffectsOverseer, System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<long, System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters>> renderers;
                /*0x18*/ System.Collections.Generic.HashSet<Assets.Battle.Overseers.VisualEffectsOverseer.MaterialParameters> fieldMaterials;
                /*0x20*/ Assets.Battle.ICache cache;
                /*0x28*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x30*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x38*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x40*/ UnityEngine.Transform visualEffectsLayer;
                /*0x48*/ UnityEngine.Transform overlayLayer;
                /*0x50*/ DG.Tweening.Sequence lightSequence;
                /*0x58*/ DG.Tweening.Sequence darkSequence;
                /*0x60*/ float lightStrength;
                /*0x64*/ float overlayStrength;
                /*0x68*/ UnityEngine.Color lightColor;
                /*0x78*/ UnityEngine.Color overlayColor;

                /*0x3cf90b8*/ VisualEffectsOverseer(Assets.Battle.ICache cache, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3cf9200*/ void Initialize(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade.Arguments arguments);
                /*0x3cf923c*/ void Update();
                /*0x3cf9560*/ string KeyToVfxAnimationKey(string key);
                /*0x3cf95ac*/ string KeyToVfxKey(string key);
                /*0x3cf95f8*/ string KeyToMecanimKey(string key);
                /*0x3cf9644*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position);
                /*0x3cf98d0*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
                /*0x3cf99b8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Vector3 scale);
                /*0x3cf9a84*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(Assets.VisualEffectData.VfxHandler prefab, UnityEngine.Vector3 position);
                /*0x3cf9754*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
                /*0x3cf9ca4*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key);
                /*0x3cf9f88*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent);
                /*0x3cfa0cc*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandlerOnOverlayLayer(string key);
                /*0x3cfa210*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAquireVfx(UnityEngine.GameObject prefab);
                /*0x3cf9de8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
                /*0x3cfa328*/ void SubscribeToHandlerEvents(Assets.VisualEffectData.VfxHandler vfx);
                /*0x3cfa704*/ void SubscribeToHandlerEvents(Assets.VisualEffectData.VfxAnimationHandler vfx);
                /*0x3cfa8a0*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAquireMecanimController(string key);
                /*0x3cfa9b8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAquireVfxAnimationHandler(string key);
                /*0x3cfaad0*/ UnityEngine.Vector3 AcquireYOffsetedPosition(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 position);
                /*0x3cfab88*/ void AddActorRenderer(long id, UnityEngine.Renderer target);
                /*0x3cfacf8*/ void RemoveActorRenderer(long id);
                /*0x3cfae14*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x3cfaef0*/ void ClearFieldMaterials();
                /*0x3cfaf40*/ void ClearActorRenderers();
                /*0x3cfaf90*/ void PlaybackErosionIn(long id, float duration);
                /*0x3cfb144*/ void PlaybackErosionOut(long id, float duration);
                /*0x3cfb2fc*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                /*0x3cfb40c*/ void PlaybackLightFlash(float inDuration, float outDuration);
                /*0x3cfb710*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                /*0x3cfb844*/ void PlaybackDarkFlash(UnityEngine.Color color, float inDuration, float outDuration);
                /*0x3cfbd6c*/ void PlaybackColorPunch(Assets.Battle.Actor actor);
                /*0x3cfbdd0*/ void PlaybackColorPunch(Assets.Battle.Actor actor, UnityEngine.Color color, UnityEngine.Vector3 direction, float durtion, int vibrato, float elasticity, bool snapping);
                /*0x3cfc2ec*/ void PlaybackBetweenState(Assets.Battle.Actor actor, UnityEngine.Color firstColor, UnityEngine.Color secondColor);
                /*0x3cfc748*/ void PlaybackConflagration(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x3cfca98*/ void StopConflagration(Assets.Battle.Actor actor);
                /*0x3cfcb60*/ void PlaybackFreeze(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x3cfcc38*/ void StopFreeze(Assets.Battle.Actor actor);
                /*0x3cfcd00*/ Cysharp.Threading.Tasks.UniTask PlaybackTimeStop(Assets.VisualEffectData.TimeStopParameters parameters);
                /*0x3cfcdd0*/ void Dispose();
                /*0x3cfb334*/ Cysharp.Threading.Tasks.UniTask <PlaybackLightFlash>g__Playback|42_0(int amount, int delay, float inDuration, float outDuration);
                /*0x3cfce0c*/ float <PlaybackLightFlash>b__43_0();
                /*0x3cfce14*/ void <PlaybackLightFlash>b__43_1(float x);
                /*0x3cfce1c*/ float <PlaybackLightFlash>b__43_2();
                /*0x3cfce24*/ void <PlaybackLightFlash>b__43_3(float x);
                /*0x3cfce2c*/ float <PlaybackLightFlash>b__43_4();
                /*0x3cfce34*/ void <PlaybackLightFlash>b__43_5(float x);
                /*0x3cfce3c*/ float <PlaybackLightFlash>b__43_6();
                /*0x3cfce44*/ void <PlaybackLightFlash>b__43_7(float x);
                /*0x3cfb740*/ Cysharp.Threading.Tasks.UniTask <PlaybackDarkFlash>g__Playback|44_0(UnityEngine.Color color, int amount, int delay, float inDuration, float outDuration);

                class RendererParameters
                {
                    /*0x10*/ UnityEngine.MaterialPropertyBlock <MaterialPropertyBlock>k__BackingField;
                    /*0x18*/ DG.Tweening.Tween <ErosionTween>k__BackingField;
                    /*0x20*/ float <Erosion>k__BackingField;
                    /*0x28*/ DG.Tweening.Tween <PunchTween>k__BackingField;
                    /*0x30*/ DG.Tweening.Sequence <ColorSequence>k__BackingField;
                    /*0x38*/ UnityEngine.Color <OverlayColor>k__BackingField;
                    /*0x48*/ float <OverlayStrength>k__BackingField;
                    /*0x4c*/ bool <ignoreLight>k__BackingField;

                    /*0x3cfac7c*/ RendererParameters();
                    /*0x3cfce4c*/ UnityEngine.MaterialPropertyBlock get_MaterialPropertyBlock();
                    /*0x3cfce54*/ DG.Tweening.Tween get_ErosionTween();
                    /*0x3cfce5c*/ void set_ErosionTween(DG.Tweening.Tween value);
                    /*0x3cfce64*/ float get_Erosion();
                    /*0x3cfce6c*/ void set_Erosion(float value);
                    /*0x3cfce74*/ DG.Tweening.Tween get_PunchTween();
                    /*0x3cfce7c*/ void set_PunchTween(DG.Tweening.Tween value);
                    /*0x3cfce84*/ DG.Tweening.Sequence get_ColorSequence();
                    /*0x3cfce8c*/ void set_ColorSequence(DG.Tweening.Sequence value);
                    /*0x3cfce94*/ UnityEngine.Color get_OverlayColor();
                    /*0x3cfcea0*/ void set_OverlayColor(UnityEngine.Color value);
                    /*0x3cfceac*/ float get_OverlayStrength();
                    /*0x3cfceb4*/ void set_OverlayStrength(float value);
                    /*0x3cfcebc*/ bool get_ignoreLight();
                    /*0x3cfcec4*/ void set_ignoreLight(bool value);
                }

                class MaterialParameters
                {
                    /*0x10*/ UnityEngine.Material <Material>k__BackingField;
                    /*0x18*/ UnityEngine.Color <OriginalColor>k__BackingField;

                    /*0x3cfaea0*/ MaterialParameters(UnityEngine.Material material);
                    /*0x3cfced0*/ UnityEngine.Material get_Material();
                    /*0x3cfced8*/ UnityEngine.Color get_OriginalColor();
                }

                struct <<PlaybackDarkFlash>g__Playback|44_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x30*/ UnityEngine.Color color;
                    /*0x40*/ float inDuration;
                    /*0x44*/ float outDuration;
                    /*0x48*/ int delay;
                    /*0x4c*/ int amount;
                    /*0x50*/ int <i>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cfcee4*/ void MoveNext();
                    /*0x3cfd340*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <<PlaybackLightFlash>g__Playback|42_0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x30*/ float inDuration;
                    /*0x34*/ float outDuration;
                    /*0x38*/ int delay;
                    /*0x3c*/ int amount;
                    /*0x40*/ int <i>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cfd34c*/ void MoveNext();
                    /*0x3cfd7a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass30_0
                {
                    /*0x10*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x18*/ Assets.VisualEffectData.VfxHandler vfx;

                    /*0x3cfa6fc*/ <>c__DisplayClass30_0();
                    /*0x3cfd7ac*/ void <SubscribeToHandlerEvents>b__0(Assets.VisualEffectData.LightFlashParameters parameters);
                    /*0x3cfd7c4*/ void <SubscribeToHandlerEvents>b__1(Assets.VisualEffectData.DarkFlashParameters parameters);
                    /*0x3cfd7dc*/ void <SubscribeToHandlerEvents>b__2(Assets.VisualEffectData.CameraNoiseParameters parameters);
                    /*0x3cfd8b0*/ void <SubscribeToHandlerEvents>b__3(Assets.VisualEffectData.TimeStopParameters parameters);
                    /*0x3cfd984*/ void <SubscribeToHandlerEvents>b__4();
                    /*0x3cfd9b0*/ void <SubscribeToHandlerEvents>b__5(UnityEngine.AudioClip audioClip);

                    struct <<SubscribeToHandlerEvents>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Overseers.VisualEffectsOverseer.<> <>4__this;
                        /*0x40*/ Assets.VisualEffectData.CameraNoiseParameters parameters;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cfda64*/ void MoveNext();
                        /*0x3cfde04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<SubscribeToHandlerEvents>b__3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Overseers.VisualEffectsOverseer.<> <>4__this;
                        /*0x40*/ Assets.VisualEffectData.TimeStopParameters parameters;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cfde10*/ void MoveNext();
                        /*0x3cfe130*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ Assets.VisualEffectData.VfxAnimationHandler vfx;
                    /*0x18*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;

                    /*0x3cfa898*/ <>c__DisplayClass31_0();
                    /*0x3cfe13c*/ void <SubscribeToHandlerEvents>b__0();
                    /*0x3cfe168*/ void <SubscribeToHandlerEvents>b__1(UnityEngine.AudioClip audioClip);
                }

                class <>c__DisplayClass40_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> item;

                    /*0x3cfb13c*/ <>c__DisplayClass40_0();
                    /*0x3cfe21c*/ float <PlaybackErosionIn>b__0();
                    /*0x3cfe238*/ void <PlaybackErosionIn>b__1(float value);
                }

                class <>c__DisplayClass41_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> item;

                    /*0x3cfb2f4*/ <>c__DisplayClass41_0();
                    /*0x3cfe254*/ float <PlaybackErosionOut>b__0();
                    /*0x3cfe270*/ void <PlaybackErosionOut>b__1(float value);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ Assets.Battle.Overseers.VisualEffectsOverseer.MaterialParameters item;

                    /*0x3cfbd5c*/ <>c__DisplayClass45_0();
                    /*0x3cfe28c*/ UnityEngine.Color <PlaybackDarkFlash>b__0();
                    /*0x3cfe2b0*/ void <PlaybackDarkFlash>b__1(UnityEngine.Color x);
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ Assets.Battle.Overseers.VisualEffectsOverseer.MaterialParameters item;

                    /*0x3cfbd64*/ <>c__DisplayClass45_1();
                    /*0x3cfe2d4*/ UnityEngine.Color <PlaybackDarkFlash>b__2();
                    /*0x3cfe2f8*/ void <PlaybackDarkFlash>b__3(UnityEngine.Color x);
                }

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> target;
                    /*0x20*/ UnityEngine.Vector3 position;

                    /*0x3cfc2e4*/ <>c__DisplayClass47_0();
                    /*0x3cfe31c*/ void <PlaybackColorPunch>b__0();
                    /*0x3cfe350*/ void <PlaybackColorPunch>b__1();
                    /*0x3cfe384*/ float <PlaybackColorPunch>b__2();
                    /*0x3cfe3a0*/ void <PlaybackColorPunch>b__3(float x);
                    /*0x3cfe3bc*/ float <PlaybackColorPunch>b__4();
                    /*0x3cfe3d8*/ void <PlaybackColorPunch>b__5(float x);
                    /*0x3cfe3f4*/ void <PlaybackColorPunch>b__6();
                    /*0x3cfe414*/ void <PlaybackColorPunch>b__7();
                }

                class <>c__DisplayClass48_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> target;

                    /*0x3cfc740*/ <>c__DisplayClass48_0();
                    /*0x3cfe434*/ UnityEngine.Color <PlaybackBetweenState>b__0();
                    /*0x3cfe454*/ void <PlaybackBetweenState>b__1(UnityEngine.Color value);
                    /*0x3cfe474*/ UnityEngine.Color <PlaybackBetweenState>b__2();
                    /*0x3cfe494*/ void <PlaybackBetweenState>b__3(UnityEngine.Color value);
                    /*0x3cfe4b4*/ UnityEngine.Color <PlaybackBetweenState>b__4();
                    /*0x3cfe4d4*/ void <PlaybackBetweenState>b__5(UnityEngine.Color value);
                    /*0x3cfe4f4*/ UnityEngine.Color <PlaybackBetweenState>b__6();
                    /*0x3cfe514*/ void <PlaybackBetweenState>b__7(UnityEngine.Color value);
                }

                class <>c__DisplayClass49_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> target;

                    /*0x3cfca90*/ <>c__DisplayClass49_0();
                    /*0x3cfe534*/ UnityEngine.Color <PlaybackConflagration>b__0();
                    /*0x3cfe554*/ void <PlaybackConflagration>b__1(UnityEngine.Color value);
                    /*0x3cfe574*/ UnityEngine.Color <PlaybackConflagration>b__2();
                    /*0x3cfe594*/ void <PlaybackConflagration>b__3(UnityEngine.Color value);
                }

                struct <PlaybackTimeStop>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.VisualEffectData.TimeStopParameters parameters;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cfe5b4*/ void MoveNext();
                    /*0x3cfeb74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireMecanimController>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Utilities.Spine.MecanimController> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.MecanimController> <>u__1;

                    /*0x3cfeb80*/ void MoveNext();
                    /*0x3cff254*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireVfx>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ UnityEngine.GameObject prefab;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x3cff2ac*/ void MoveNext();
                    /*0x3cff9b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireVfxAnimationHandler>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.VisualEffectData.VfxAnimationHandler> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxAnimationHandler> <>u__1;

                    /*0x3cffa10*/ void MoveNext();
                    /*0x3d000c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireVfxHandler>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.VisualEffectData.VfxHandler> <>t__builder;
                    /*0x30*/ string key;
                    /*0x38*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x40*/ UnityEngine.Transform parent;
                    /*0x48*/ UnityEngine.Vector3 position;
                    /*0x54*/ UnityEngine.Quaternion rotation;
                    /*0x64*/ UnityEngine.Vector3 scale;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d0011c*/ void MoveNext();
                    /*0x3d007b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryTriggerVfxAt>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.VisualEffectData.VfxHandler> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ UnityEngine.Vector3 position;
                    /*0x4c*/ UnityEngine.Quaternion rotation;
                    /*0x5c*/ UnityEngine.Vector3 scale;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d0080c*/ void MoveNext();
                    /*0x3d00d34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        namespace Hud
        {
            class ActionQueue : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform activeQueue;
                /*0x28*/ UnityEngine.Transform cache;
                /*0x30*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, System.Collections.Generic.List<Assets.Battle.Hud.ActionQueueIcon>> iconCache;
                /*0x38*/ Assets.AssetManagement.IAssetInstanceProvider <InstanceProvider>k__BackingField;
                /*0x40*/ Assets.AssetManagement.ITextureAssetProvider <TextureProvider>k__BackingField;
                /*0x48*/ Assets.AssetManagement.IAddressablesKeyProvider <KeyProvider>k__BackingField;

                /*0x3d01398*/ ActionQueue();
                /*0x3d00d8c*/ Assets.AssetManagement.IAssetInstanceProvider get_InstanceProvider();
                /*0x3d00d94*/ void set_InstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                /*0x3d00d9c*/ Assets.AssetManagement.ITextureAssetProvider get_TextureProvider();
                /*0x3d00da4*/ void set_TextureProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3d00dac*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3d00db4*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3d00dbc*/ void Clear();
                /*0x3d01094*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActionQueueIcon> RequestIcon(Assets.Battle.Actor actor);
                /*0x3d011ac*/ Cysharp.Threading.Tasks.UniTask UpdateQueue(Assets.Battle.Actor[] queue);
                /*0x3d01278*/ void Advance();

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Assets.Battle.Hud.ActionQueueIcon[] icons;

                    /*0x3d01420*/ <>c__DisplayClass17_0();
                }

                class <>c__DisplayClass17_1
                {
                    /*0x10*/ int index;
                    /*0x18*/ Assets.Battle.Actor actor;
                    /*0x20*/ Assets.Battle.Hud.ActionQueue.<> CS$<>8__locals1;

                    /*0x3d01428*/ <>c__DisplayClass17_1();
                    /*0x3d01430*/ void <UpdateQueue>b__0(Assets.Battle.Hud.ActionQueueIcon icon);
                }

                struct <RequestIcon>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Hud.ActionQueueIcon> <>t__builder;
                    /*0x30*/ Assets.Battle.Hud.ActionQueue <>4__this;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Assets.Battle.Hud.ActionQueueIcon <icon>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActionQueueIcon> <>u__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d01574*/ void MoveNext();
                    /*0x3d02390*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <UpdateQueue>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Hud.ActionQueue <>4__this;
                    /*0x30*/ Assets.Battle.Actor[] queue;
                    /*0x38*/ Assets.Battle.Hud.ActionQueue.<> <>8__1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d023e8*/ void MoveNext();
                    /*0x3d02c18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class ActionQueueIcon : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Hud.ActorIcon icon;
                /*0x28*/ UnityEngine.UI.Image background;
                /*0x30*/ UnityEngine.UI.Image label;
                /*0x38*/ UnityEngine.UI.Image indexBackground;
                /*0x40*/ TMPro.TextMeshProUGUI index;
                /*0x48*/ Assets.Api.Client.PawnId <ActorId>k__BackingField;
                /*0x50*/ bool <ReadyToUse>k__BackingField;

                /*0x3d02d10*/ ActionQueueIcon();
                /*0x3d02c24*/ Assets.Api.Client.PawnId get_ActorId();
                /*0x3d02c2c*/ void set_ActorId(Assets.Api.Client.PawnId value);
                /*0x3d02c34*/ bool get_ReadyToUse();
                /*0x3d02c3c*/ void set_ReadyToUse(bool value);
                /*0x3d02268*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.AssetManagement.ITextureAssetProvider assetProvider, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider);
                /*0x3d0151c*/ void UpdateState(Assets.Battle.Actor actor, int index);

                struct <Initialize>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor actor;
                    /*0x30*/ Assets.Battle.Hud.ActionQueueIcon <>4__this;
                    /*0x38*/ Assets.AssetManagement.IAssetInstanceProvider instanceProvider;
                    /*0x40*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
                    /*0x48*/ Assets.AssetManagement.ITextureAssetProvider assetProvider;
                    /*0x50*/ string <keySuffix>5__2;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x68*/ UnityEngine.UI.Image <>7__wrap2;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite> <>u__2;

                    /*0x3d02d18*/ void MoveNext();
                    /*0x3d03cc0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class ActorDetails : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image headerLabel;
                /*0x28*/ TMPro.TextMeshProUGUI headerActorInfo;
                /*0x30*/ Assets.Battle.Hud.ActorIcon actorIcon;
                /*0x38*/ UnityEngine.UI.RawImage attributeIcon;
                /*0x40*/ UnityEngine.UI.RawImage roleIcon;
                /*0x48*/ Assets.Utilities.FillGauge exGauge;
                /*0x50*/ UnityEngine.GameObject exGaugeParent;
                /*0x58*/ UnityEngine.GameObject exGaugeDisabledLabel;
                /*0x60*/ Assets.Battle.Hud.PointGauge activePoints;
                /*0x68*/ Assets.Battle.Hud.PointGauge passivePoints;
                /*0x70*/ Assets.Utilities.FillGauge healthGauge;
                /*0x78*/ TMPro.TextMeshProUGUI currentHpValue;
                /*0x80*/ TMPro.TextMeshProUGUI totalHpValue;
                /*0x88*/ TMPro.TextMeshProUGUI universalShieldValue;
                /*0x90*/ TMPro.TextMeshProUGUI physicShieldValue;
                /*0x98*/ TMPro.TextMeshProUGUI energyShieldValue;
                /*0xa0*/ TMPro.TextMeshProUGUI attackValue;
                /*0xa8*/ TMPro.TextMeshProUGUI defenceValue;
                /*0xb0*/ TMPro.TextMeshProUGUI speedValue;
                /*0xb8*/ TMPro.TextMeshProUGUI criticalValue;
                /*0xc0*/ UnityEngine.Transform AuraDataViewParent;
                /*0xc8*/ Assets.Battle.Hud.AuraDataView auraDataViewPrefab;
                /*0xd0*/ UnityEngine.GameObject emptyAuraDataLabel;
                /*0xd8*/ Assets.AssetManagement.ITextureAssetProvider <TextureAssetProvider>k__BackingField;
                /*0xe0*/ Assets.Battle.DataModels.IBattleDataStorageModel <BattleDataStorageModel>k__BackingField;
                /*0xe8*/ Assets.Api.MemoryDB.IMemoryDB <MemoryDB>k__BackingField;
                /*0xf0*/ Assets.AssetManagement.IAssetInstanceProvider <AssetInstanceProvider>k__BackingField;
                /*0xf8*/ Assets.AssetManagement.IAddressablesKeyProvider <KeyProvider>k__BackingField;
                /*0x100*/ Assets.Battle.ICache <Cache>k__BackingField;

                /*0x3d0599c*/ ActorDetails();
                /*0x3d03ccc*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                /*0x3d03cd4*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3d03cdc*/ Assets.Battle.DataModels.IBattleDataStorageModel get_BattleDataStorageModel();
                /*0x3d03ce4*/ void set_BattleDataStorageModel(Assets.Battle.DataModels.IBattleDataStorageModel value);
                /*0x3d03cec*/ Assets.Api.MemoryDB.IMemoryDB get_MemoryDB();
                /*0x3d03cf4*/ void set_MemoryDB(Assets.Api.MemoryDB.IMemoryDB value);
                /*0x3d03cfc*/ Assets.AssetManagement.IAssetInstanceProvider get_AssetInstanceProvider();
                /*0x3d03d04*/ void set_AssetInstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                /*0x3d03d0c*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3d03d14*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3d03d1c*/ Assets.Battle.ICache get_Cache();
                /*0x3d03d24*/ void set_Cache(Assets.Battle.ICache value);
                /*0x3d03d34*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor);
                /*0x3d04e68*/ void Clear();
                /*0x3d05268*/ Cysharp.Threading.Tasks.UniTask ApplyAuraDataView(Assets.Battle.Actor actor);
                /*0x3d05648*/ string ConstructParameterValueText(long parameter, long baseParameter);
                /*0x3d057f4*/ string ConstructParameterValueText(float parameter, float baseParameter);

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ Assets.Battle.Hud.ActorDetails <>4__this;
                    /*0x18*/ Assets.Battle.Actor actor;

                    /*0x3d04e60*/ <>c__DisplayClass47_0();
                    /*0x3d059a4*/ UnityEngine.Sprite <Initialize>b__0(UnityEngine.Sprite sprite);
                    /*0x3d059d4*/ UnityEngine.Texture <Initialize>b__1(UnityEngine.Texture2D texture);
                    /*0x3d05a04*/ bool <Initialize>b__2(Assets.Api.Client.PawnMasterView p);
                    /*0x3d05a2c*/ UnityEngine.Texture <Initialize>b__3(UnityEngine.Texture2D texture);
                }

                struct <ApplyAuraDataView>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor actor;
                    /*0x30*/ Assets.Battle.Hud.ActorDetails <>4__this;
                    /*0x38*/ bool <auraExists>5__2;
                    /*0x40*/ System.Collections.Generic.Dictionary.Enumerator<int, Assets.Api.Client.AuraView> <>7__wrap2;
                    /*0x68*/ System.Collections.Generic.KeyValuePair<int, Assets.Api.Client.AuraView> <item>5__4;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.AuraDataView> <>u__1;

                    /*0x3d05a5c*/ void MoveNext();
                    /*0x3d06390*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class ActorIcon : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image icon;
                /*0x28*/ UnityEngine.Transform imageParent;
                /*0x30*/ Assets.Battle.Utilities.SpriteCycle iconFrame;
                /*0x38*/ Assets.Battle.Utilities.SpriteCycle backgroundFrame;
                /*0x40*/ UnityEngine.GameObject iconGlow;
                /*0x48*/ UnityEngine.GameObject deathLabel;
                /*0x50*/ UnityEngine.UI.Button <Button>k__BackingField;
                /*0x58*/ UnityEngine.GameObject iconAsset;
                /*0x60*/ System.Collections.Generic.List<UnityEngine.GameObject> oldIcons;

                /*0x3d0654c*/ ActorIcon();
                /*0x3d0639c*/ UnityEngine.UI.Button get_Button();
                /*0x3d063a4*/ void set_Button(UnityEngine.UI.Button value);
                /*0x3d03bb8*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider);
                /*0x3d063ac*/ void SetGlowActive(bool active);
                /*0x3d063cc*/ void SetDeathLabelActive(bool active);
                /*0x3d02c48*/ void UpdateVisualState(Assets.Battle.Actor actor);
                /*0x3d063ec*/ void SetToAliveState();
                /*0x3d0649c*/ void SetToDeadState();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d065d4*/ <>c__DisplayClass12_0();
                    /*0x3d065dc*/ bool <Initialize>b__0(UnityEngine.GameObject i);
                }

                struct <Initialize>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor actor;
                    /*0x30*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
                    /*0x38*/ Assets.Battle.Hud.ActorIcon <>4__this;
                    /*0x40*/ Assets.AssetManagement.IAssetInstanceProvider instanceProvider;
                    /*0x48*/ Assets.Battle.Hud.ActorIcon.<> <>8__1;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x3d06610*/ void MoveNext();
                    /*0x3d07010*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class ActorStatusIcon : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image icon;
                /*0x28*/ UnityEngine.Sprite playerSprite;
                /*0x30*/ UnityEngine.Sprite enemySprite;

                /*0x3d07080*/ ActorStatusIcon();
                /*0x3d0701c*/ void Initialize(bool isEnemyActor);
                /*0x3d07050*/ void SetStatus(bool active);
            }

            class ActorStatusView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Hud.ActorIcon <Icon>k__BackingField;
                /*0x28*/ Assets.Utilities.FillGauge healthGauge;
                /*0x30*/ TMPro.TextMeshProUGUI healthValue;
                /*0x38*/ Assets.Utilities.FillGauge burstGauge;
                /*0x40*/ UnityEngine.GameObject burstGaugeParent;
                /*0x48*/ UnityEngine.GameObject burstGaugeDisabledLabel;
                /*0x50*/ Assets.Battle.Hud.PointGauge activePoints;
                /*0x58*/ Assets.Battle.Hud.PointGauge passivePoints;
                /*0x60*/ TMPro.TextMeshProUGUI buffCount;
                /*0x68*/ TMPro.TextMeshProUGUI debuffCount;
                /*0x70*/ UnityEngine.UI.Image buffIcon;
                /*0x78*/ UnityEngine.UI.Image debuffIcon;
                /*0x80*/ UnityEngine.UI.Image abnormalConditionIcon;
                /*0x88*/ UnityEngine.UI.Image burstGaugeGlow;
                /*0x90*/ UnityEngine.UI.Image attribute;
                /*0x98*/ bool worldSpace;
                /*0xa0*/ UnityEngine.Material normalHpMaterial;
                /*0xa8*/ UnityEngine.Material shieldedHpMaterial;
                /*0xb0*/ UnityEngine.Color normalHpColor;
                /*0xc0*/ UnityEngine.Color shieldedHpColor;
                /*0xd0*/ Assets.Api.Client.StatusView lastUpdatedStatus;

                /*0x3d07bbc*/ ActorStatusView();
                /*0x3d07088*/ Assets.Battle.Hud.ActorIcon get_Icon();
                /*0x3d07090*/ void set_Icon(Assets.Battle.Hud.ActorIcon value);
                /*0x3d07098*/ void Awake();
                /*0x3d070c4*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool worldSpace, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.GameUi.Externals.IAudioManager audioManager, Assets.AssetManagement.ITextureAssetProvider textureAssetProvider);
                /*0x3d0720c*/ void TryRestoreStatus();
                /*0x3d07220*/ void UpdateStatus(Assets.Api.Client.StatusView status, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d074f8*/ void UpdateAuraState(int buffs, int debuffs, bool hasAbnormalState, bool sustainsShieldEffect);
                /*0x3d07764*/ void TryToFadeIn(float duration);
                /*0x3d0783c*/ void TryToFadeOut(float delay, float duration);
                /*0x3d07934*/ Cysharp.Threading.Tasks.UniTask SetToEngageState(bool isEnemyActor);
                /*0x3d07a1c*/ Cysharp.Threading.Tasks.UniTask SetToIdleState(bool isEnemyActor);
                /*0x3d07b04*/ void SetToAliveState();
                /*0x3d07b4c*/ void SetToDeadState();
                /*0x3d074c8*/ void SetGlowActive(bool active);

                struct <Initialize>d__25 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Hud.ActorStatusView <>4__this;
                    /*0x30*/ bool worldSpace;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Assets.Api.Client.StatusView status;
                    /*0x48*/ Assets.AssetManagement.ITextureAssetProvider textureAssetProvider;
                    /*0x50*/ Assets.AssetManagement.IAssetInstanceProvider instanceProvider;
                    /*0x58*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d07bc4*/ void MoveNext();
                    /*0x3d08488*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AuraDataView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI <Description>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <TurnLeft>k__BackingField;

                /*0x3d084b4*/ AuraDataView();
                /*0x3d08494*/ TMPro.TextMeshProUGUI get_Description();
                /*0x3d0849c*/ void set_Description(TMPro.TextMeshProUGUI value);
                /*0x3d084a4*/ TMPro.TextMeshProUGUI get_TurnLeft();
                /*0x3d084ac*/ void set_TurnLeft(TMPro.TextMeshProUGUI value);
            }

            class BossHealthGauge : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Utilities.FillGauge healthGauge;
                /*0x28*/ Assets.Utilities.FillGauge burstGauge;
                /*0x30*/ TMPro.TextMeshProUGUI scoreValue;
                /*0x38*/ Assets.Battle.Hud.ActorIcon icon;
                /*0x40*/ UnityEngine.GameObject scoreView;
                /*0x48*/ Assets.AssetManagement.ITextureAssetProvider <TextureProvider>k__BackingField;
                /*0x50*/ long currentScoreValue;
                /*0x58*/ DG.Tweening.Tween tween;

                /*0x3d08734*/ BossHealthGauge();
                /*0x3d084bc*/ Assets.AssetManagement.ITextureAssetProvider get_TextureProvider();
                /*0x3d084c4*/ void set_TextureProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3cf4070*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool showScoreView, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider);
                /*0x3d084cc*/ void UpdateStatus(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3d0857c*/ void UpdateScoreValue(long value);
                /*0x3d0872c*/ long GetCurrentScoreValue();

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ long currentValue;
                    /*0x18*/ Assets.Battle.Hud.BossHealthGauge <>4__this;

                    /*0x3d08724*/ <>c__DisplayClass13_0();
                    /*0x3d0873c*/ long <UpdateScoreValue>b__0();
                    /*0x3d08744*/ void <UpdateScoreValue>b__1(long x);
                }
            }

            class CockpitPlaceholder : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.RectTransform <RectTransform>k__BackingField;
                /*0x28*/ UnityEngine.UI.Image statusLabel;
                /*0x30*/ UnityEngine.UI.Image deadLabel;
                /*0x38*/ UnityEngine.Sprite emergencyStatusSprite;
                /*0x40*/ UnityEngine.Sprite controlEffectStatusSprite;
                /*0x48*/ Assets.Battle.Actor <Actor>k__BackingField;
                /*0x50*/ bool <Disabled>k__BackingField;

                /*0x3d08970*/ CockpitPlaceholder();
                /*0x3d087c4*/ UnityEngine.RectTransform get_RectTransform();
                /*0x3d087cc*/ void set_RectTransform(UnityEngine.RectTransform value);
                /*0x3d087d4*/ Assets.Battle.Actor get_Actor();
                /*0x3d087dc*/ void set_Actor(Assets.Battle.Actor value);
                /*0x3d087e4*/ bool get_Disabled();
                /*0x3d087ec*/ void set_Disabled(bool value);
                /*0x3d087f8*/ void UpdateStatus(Assets.Battle.Actor actor);
                /*0x3d08920*/ void Clear();
            }

            class CombinedGauge : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image leftGauge;
                /*0x28*/ UnityEngine.UI.Image rightGauge;
                /*0x30*/ UnityEngine.GameObject inactiveLabel;
                /*0x38*/ DG.Tweening.Tween leftGaugeTween;
                /*0x40*/ DG.Tweening.Tween rightGaugeTween;
                /*0x48*/ Assets.Battle.Hud.CombinedGauge.StateTypes <State>k__BackingField;

                /*0x3d08c4c*/ CombinedGauge();
                /*0x3d08978*/ Assets.Battle.Hud.CombinedGauge.StateTypes get_State();
                /*0x3d08980*/ void set_State(Assets.Battle.Hud.CombinedGauge.StateTypes value);
                /*0x3d08988*/ void SetState(bool active);
                /*0x3d089fc*/ Cysharp.Threading.Tasks.UniTask UpdateValue(long leftCurrent, long leftMax, long rightCurrent, long rightMax, float duration);
                /*0x3d08c24*/ Assets.Battle.Hud.CombinedGauge.StateTypes CalculateCurrentState(float leftValue, float rightValue);

                enum StateTypes
                {
                    LeftAdvantage = 0,
                    RightAdvantage = 1,
                    Neutral = 2,
                }
            }

            class DamageText : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshPro <Mesh>k__BackingField;
                /*0x28*/ UnityEngine.Vector3 <PositionOffset>k__BackingField;
                /*0x34*/ float <StartPositionYOffset>k__BackingField;
                /*0x38*/ float <Deviation>k__BackingField;
                /*0x3c*/ float <FadeInDuration>k__BackingField;
                /*0x40*/ float <MoveInDuration>k__BackingField;
                /*0x44*/ float <IntervalDuration>k__BackingField;
                /*0x48*/ float <FadeOutDuration>k__BackingField;
                /*0x50*/ DG.Tweening.Sequence <ActiveSequence>k__BackingField;

                /*0x3d08cec*/ DamageText();
                /*0x3d08c54*/ TMPro.TextMeshPro get_Mesh();
                /*0x3d08c5c*/ void set_Mesh(TMPro.TextMeshPro value);
                /*0x3d08c64*/ UnityEngine.Vector3 get_PositionOffset();
                /*0x3d08c70*/ void set_PositionOffset(UnityEngine.Vector3 value);
                /*0x3d08c7c*/ float get_StartPositionYOffset();
                /*0x3d08c84*/ void set_StartPositionYOffset(float value);
                /*0x3d08c8c*/ float get_Deviation();
                /*0x3d08c94*/ void set_Deviation(float value);
                /*0x3d08c9c*/ float get_FadeInDuration();
                /*0x3d08ca4*/ void set_FadeInDuration(float value);
                /*0x3d08cac*/ float get_MoveInDuration();
                /*0x3d08cb4*/ void set_MoveInDuration(float value);
                /*0x3d08cbc*/ float get_IntervalDuration();
                /*0x3d08cc4*/ void set_IntervalDuration(float value);
                /*0x3d08ccc*/ float get_FadeOutDuration();
                /*0x3d08cd4*/ void set_FadeOutDuration(float value);
                /*0x3d08cdc*/ DG.Tweening.Sequence get_ActiveSequence();
                /*0x3d08ce4*/ void set_ActiveSequence(DG.Tweening.Sequence value);
            }

            class LegendMark : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image <Icon>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <Label>k__BackingField;

                /*0x3d08d78*/ LegendMark();
                /*0x3d08d58*/ UnityEngine.UI.Image get_Icon();
                /*0x3d08d60*/ void set_Icon(UnityEngine.UI.Image value);
                /*0x3d08d68*/ TMPro.TextMeshProUGUI get_Label();
                /*0x3d08d70*/ void set_Label(TMPro.TextMeshProUGUI value);
            }

            class MvpDataView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.GameUi.Icon.IconBase attackIcon;
                /*0x28*/ Assets.GameUi.Icon.IconBase defenceIcon;
                /*0x30*/ Assets.GameUi.Icon.IconBase healIcon;
                /*0x38*/ Assets.Battle.DataModels.IBattleDataStorageModel <Model>k__BackingField;

                /*0x3d09210*/ MvpDataView();
                /*0x3d08d80*/ Assets.Battle.DataModels.IBattleDataStorageModel get_Model();
                /*0x3d08d88*/ void set_Model(Assets.Battle.DataModels.IBattleDataStorageModel value);
                /*0x3d08d90*/ void SetAnimationTrigger(Assets.Battle.Hud.MvpDataView.Animations trigger);
                /*0x3d08e48*/ Cysharp.Threading.Tasks.UniTask AssignActors(Assets.Api.Client.PawnId attacker, Assets.Api.Client.PawnId defender, Assets.Api.Client.PawnId healer);
                /*0x3d09130*/ Cysharp.Threading.Tasks.UniTask ApplyToIcon(Assets.Api.Client.PawnId actor, Assets.GameUi.Icon.IconBase icon);

                enum Animations
                {
                    Default = 0,
                    ScoreAttack = 1,
                    Maze = 2,
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Api.Client.PawnId actor;

                    /*0x3d09218*/ <>c__DisplayClass9_0();
                    /*0x3d09220*/ bool <ApplyToIcon>b__0(Assets.Api.Client.PawnMasterView s);
                }

                struct <ApplyToIcon>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.PawnId actor;
                    /*0x30*/ Assets.Battle.Hud.MvpDataView <>4__this;
                    /*0x38*/ Assets.GameUi.Icon.IconBase icon;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3d09254*/ void MoveNext();
                    /*0x3d099c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NavigationTile : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI <Title>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <ButtonLabel>k__BackingField;
                /*0x30*/ UnityEngine.UI.Button <Button>k__BackingField;

                /*0x3d099fc*/ NavigationTile();
                /*0x3d099cc*/ TMPro.TextMeshProUGUI get_Title();
                /*0x3d099d4*/ void set_Title(TMPro.TextMeshProUGUI value);
                /*0x3d099dc*/ TMPro.TextMeshProUGUI get_ButtonLabel();
                /*0x3d099e4*/ void set_ButtonLabel(TMPro.TextMeshProUGUI value);
                /*0x3d099ec*/ UnityEngine.UI.Button get_Button();
                /*0x3d099f4*/ void set_Button(UnityEngine.UI.Button value);
            }

            class Point : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform <Value>k__BackingField;
                /*0x28*/ bool <Enabled>k__BackingField;
                /*0x29*/ bool <Inactive>k__BackingField;
                /*0x2a*/ bool <NegativeScale>k__BackingField;
                /*0x30*/ UnityEngine.SpriteRenderer vfxOnEnable;
                /*0x38*/ UnityEngine.SpriteRenderer vfxOnDisable;
                /*0x40*/ bool currentState;

                /*0x3d09c08*/ Point();
                /*0x3d09a04*/ UnityEngine.Transform get_Value();
                /*0x3d09a0c*/ void set_Value(UnityEngine.Transform value);
                /*0x3d09a14*/ bool get_Enabled();
                /*0x3d09a1c*/ void set_Enabled(bool value);
                /*0x3d09a28*/ bool get_Inactive();
                /*0x3d09a30*/ void set_Inactive(bool value);
                /*0x3d09a3c*/ bool get_NegativeScale();
                /*0x3d09a44*/ void set_NegativeScale(bool value);
                /*0x3d09a50*/ void Update();
            }

            class PointGauge : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Hud.Point[] points;
                /*0x28*/ bool <Inactive>k__BackingField;
                /*0x30*/ DG.Tweening.Sequence sequence;

                /*0x3d09c24*/ PointGauge();
                /*0x3d09c10*/ bool get_Inactive();
                /*0x3d09c18*/ void set_Inactive(bool value);
                /*0x3d0533c*/ Cysharp.Threading.Tasks.UniTask UpdateValue(int current, int max, float duration, Assets.GameUi.Externals.IAudioManager audioManager);
            }

            class PositionLegend : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Hud.LegendMark[] playerFrontRow;
                /*0x28*/ Assets.Battle.Hud.LegendMark[] playerBackRow;
                /*0x30*/ Assets.Battle.Hud.LegendMark[] enemyFrontRow;
                /*0x38*/ Assets.Battle.Hud.LegendMark[] enemyBackRow;
                /*0x40*/ UnityEngine.Color playerMarkColor;
                /*0x50*/ UnityEngine.Color enemyMarkColor;
                /*0x60*/ UnityEngine.Color emptyMarkColor;
                /*0x70*/ UnityEngine.Material playerFontMaterial;
                /*0x78*/ UnityEngine.Material enemyFontMaterial;
                /*0x80*/ UnityEngine.Material emptyFontMaterial;
                /*0x88*/ UnityEngine.Color playerFontColor;
                /*0x98*/ UnityEngine.Color enemyFontColor;
                /*0xa8*/ UnityEngine.Color emptyFontColor;

                /*0x3d09f70*/ PositionLegend();
                /*0x3d09c2c*/ void SetToEmpty();
                /*0x3d09dd8*/ void Add(Assets.Api.Client.PawnView pawn);
                /*0x3d09efc*/ void SetMarkToPlayer(Assets.Battle.Hud.LegendMark mark);
                /*0x3d09e88*/ void SetMarkToEnemy(Assets.Battle.Hud.LegendMark mark);
                /*0x3d09d64*/ void SetMarkToEmpty(Assets.Battle.Hud.LegendMark mark);
            }

            class ResultBackground : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image background;
                /*0x28*/ UnityEngine.UI.Image label;
                /*0x30*/ UnityEngine.UI.Image subLabel;
                /*0x38*/ UnityEngine.Animator animator;
                /*0x40*/ UnityEngine.Sprite victoryBackground;
                /*0x48*/ UnityEngine.Sprite defeatBackground;
                /*0x50*/ UnityEngine.Sprite victoryLabel;
                /*0x58*/ UnityEngine.Sprite defeatLabel;
                /*0x60*/ UnityEngine.Sprite finishlabel;
                /*0x68*/ System.Action onFadeComplete;

                /*0x3d0a278*/ ResultBackground();
                /*0x3d0a128*/ void Show(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, System.Action onFadeComplete);
                /*0x3d0a25c*/ void OnAnimationFadeStepComplete(string value);
            }

            class ResultDamageView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI rankPercentage;
                /*0x28*/ TMPro.TextMeshProUGUI damage;
                /*0x30*/ TMPro.TextMeshProUGUI damagePercentage;
                /*0x38*/ UnityEngine.GameObject damagePercentageParent;
                /*0x40*/ UnityEngine.GameObject damageRecordMark;

                /*0x3d0a380*/ ResultDamageView();
                /*0x3d0a280*/ Cysharp.Threading.Tasks.UniTask UpdateData(string rankData, string damage, string damagePercentage, bool newRecord, bool showPercentage);
            }

            class ResultLevelProgress : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent levelProgress;
                /*0x28*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> <OnRewardClicked>k__BackingField;
                /*0x30*/ Assets.Battle.DataModels.IBattleDataStorageModel <Model>k__BackingField;

                /*0x3d0a4c8*/ ResultLevelProgress();
                /*0x3d0a388*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> get_OnRewardClicked();
                /*0x3d0a390*/ void set_OnRewardClicked(System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> value);
                /*0x3d0a398*/ Assets.Battle.DataModels.IBattleDataStorageModel get_Model();
                /*0x3d0a3a0*/ void set_Model(Assets.Battle.DataModels.IBattleDataStorageModel value);
                /*0x3d0a3a8*/ Cysharp.Threading.Tasks.UniTask UpdateLevelProgress(Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments);

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Battle.Hud.ResultLevelProgress <>4__this;
                    /*0x18*/ Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments;

                    /*0x3d0a4c0*/ <>c__DisplayClass9_0();
                    /*0x3d0a4d0*/ Cysharp.Threading.Tasks.UniTask <UpdateLevelProgress>b__0(Assets.GameUi.Icon.IconBase icon);

                    struct <<UpdateLevelProgress>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Hud.ResultLevelProgress.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3d0a57c*/ void MoveNext();
                        /*0x3d0a9d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }

            class ResultNavigation : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.GameObject TipsParent;
                /*0x28*/ UnityEngine.UI.Button <NextButton>k__BackingField;
                /*0x30*/ UnityEngine.UI.Button <ReplayButton>k__BackingField;
                /*0x38*/ UnityEngine.UI.Button <HomeButton>k__BackingField;
                /*0x40*/ UnityEngine.UI.Button <ReportButton>k__BackingField;
                /*0x48*/ Assets.Battle.Hud.NavigationTile[] <Tips>k__BackingField;
                /*0x50*/ UnityEngine.UI.Button <NextButtonLock>k__BackingField;
                /*0x58*/ UnityEngine.UI.Button <ReplayButtonLock>k__BackingField;
                /*0x60*/ UnityEngine.UI.Button <HomeButtonLock>k__BackingField;

                /*0x3d0ac00*/ ResultNavigation();
                /*0x3d0a9e0*/ UnityEngine.UI.Button get_NextButton();
                /*0x3d0a9e8*/ void set_NextButton(UnityEngine.UI.Button value);
                /*0x3d0a9f0*/ UnityEngine.UI.Button get_ReplayButton();
                /*0x3d0a9f8*/ void set_ReplayButton(UnityEngine.UI.Button value);
                /*0x3d0aa00*/ UnityEngine.UI.Button get_HomeButton();
                /*0x3d0aa08*/ void set_HomeButton(UnityEngine.UI.Button value);
                /*0x3d0aa10*/ UnityEngine.UI.Button get_ReportButton();
                /*0x3d0aa18*/ void set_ReportButton(UnityEngine.UI.Button value);
                /*0x3d0aa20*/ Assets.Battle.Hud.NavigationTile[] get_Tips();
                /*0x3d0aa28*/ void set_Tips(Assets.Battle.Hud.NavigationTile[] value);
                /*0x3d0aa30*/ UnityEngine.UI.Button get_NextButtonLock();
                /*0x3d0aa38*/ void set_NextButtonLock(UnityEngine.UI.Button value);
                /*0x3d0aa40*/ UnityEngine.UI.Button get_ReplayButtonLock();
                /*0x3d0aa48*/ void set_ReplayButtonLock(UnityEngine.UI.Button value);
                /*0x3d0aa50*/ UnityEngine.UI.Button get_HomeButtonLock();
                /*0x3d0aa58*/ void set_HomeButtonLock(UnityEngine.UI.Button value);
                /*0x3d0aa60*/ void Show(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, bool homeLock, bool nextLock);
            }

            class ResultRankProgress : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Utilities.FillGauge rankGauge;
                /*0x28*/ TMPro.TextMeshProUGUI currentRank;
                /*0x30*/ TMPro.TextMeshProUGUI rankPoints;

                /*0x3d0ad20*/ ResultRankProgress();
                /*0x3d0ac08*/ Cysharp.Threading.Tasks.UniTask UpdateRankProgress(int currentPoints, int maxPoints, int rank);
            }

            class ResultRewardsView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.GameObject label;
                /*0x28*/ UnityEngine.Transform rewardsParent;
                /*0x30*/ UnityEngine.Transform scoreRewardsParent;
                /*0x38*/ Assets.GameUi.Icon.IconBase[] rewardIcons;
                /*0x40*/ Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell[] scoreRewardIcons;
                /*0x48*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> <OnRewardClicked>k__BackingField;

                /*0x3d0b438*/ ResultRewardsView();
                /*0x3d0ad28*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> get_OnRewardClicked();
                /*0x3d0ad30*/ void set_OnRewardClicked(System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> value);
                /*0x3d0ad38*/ Cysharp.Threading.Tasks.UniTask ShowRewards(Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs[] rewards);
                /*0x3d0b0b8*/ Cysharp.Threading.Tasks.UniTask ShowRewards(Assets.GameUi.Icon.IconBase.IconArgs[] rewards);

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ Assets.GameUi.Icon.IconBase.IconArgs args;
                    /*0x18*/ Assets.Battle.Hud.ResultRewardsView <>4__this;

                    /*0x3d0b430*/ <>c__DisplayClass10_0();
                    /*0x3d0b440*/ Cysharp.Threading.Tasks.UniTask <ShowRewards>b__0(UnityEngine.UI.Button icon);

                    struct <<ShowRewards>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Hud.ResultRewardsView.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3d0b4ec*/ void MoveNext();
                        /*0x3d0b934*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs args;
                    /*0x18*/ Assets.Battle.Hud.ResultRewardsView <>4__this;

                    /*0x3d0b0b0*/ <>c__DisplayClass9_0();
                    /*0x3d0b940*/ Cysharp.Threading.Tasks.UniTask <ShowRewards>b__0(UnityEngine.UI.Button icon);

                    struct <<ShowRewards>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Hud.ResultRewardsView.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3d0b9ec*/ void MoveNext();
                        /*0x3d0be44*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }

            class ShieldDamageText : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform <Container>k__BackingField;
                /*0x28*/ TMPro.TextMeshPro <Value>k__BackingField;
                /*0x30*/ TMPro.TextMeshPro <ShieldValue>k__BackingField;
                /*0x38*/ TMPro.TextMeshPro <AdditionalValue>k__BackingField;
                /*0x40*/ UnityEngine.SpriteRenderer <ShieldSprite>k__BackingField;
                /*0x48*/ UnityEngine.Vector3 <PositionOffset>k__BackingField;
                /*0x54*/ float <StartPositionYOffset>k__BackingField;
                /*0x58*/ float <Deviation>k__BackingField;
                /*0x5c*/ float <FadeInDuration>k__BackingField;
                /*0x60*/ float <MoveInDuration>k__BackingField;
                /*0x64*/ float <IntervalDuration>k__BackingField;
                /*0x68*/ float <FadeOutDuration>k__BackingField;
                /*0x70*/ DG.Tweening.Sequence <ActiveSequence>k__BackingField;

                /*0x3d0bf28*/ ShieldDamageText();
                /*0x3d0be50*/ UnityEngine.Transform get_Container();
                /*0x3d0be58*/ void set_Container(UnityEngine.Transform value);
                /*0x3d0be60*/ TMPro.TextMeshPro get_Value();
                /*0x3d0be68*/ void set_Value(TMPro.TextMeshPro value);
                /*0x3d0be70*/ TMPro.TextMeshPro get_ShieldValue();
                /*0x3d0be78*/ void set_ShieldValue(TMPro.TextMeshPro value);
                /*0x3d0be80*/ TMPro.TextMeshPro get_AdditionalValue();
                /*0x3d0be88*/ void set_AdditionalValue(TMPro.TextMeshPro value);
                /*0x3d0be90*/ UnityEngine.SpriteRenderer get_ShieldSprite();
                /*0x3d0be98*/ void set_ShieldSprite(UnityEngine.SpriteRenderer value);
                /*0x3d0bea0*/ UnityEngine.Vector3 get_PositionOffset();
                /*0x3d0beac*/ void set_PositionOffset(UnityEngine.Vector3 value);
                /*0x3d0beb8*/ float get_StartPositionYOffset();
                /*0x3d0bec0*/ void set_StartPositionYOffset(float value);
                /*0x3d0bec8*/ float get_Deviation();
                /*0x3d0bed0*/ void set_Deviation(float value);
                /*0x3d0bed8*/ float get_FadeInDuration();
                /*0x3d0bee0*/ void set_FadeInDuration(float value);
                /*0x3d0bee8*/ float get_MoveInDuration();
                /*0x3d0bef0*/ void set_MoveInDuration(float value);
                /*0x3d0bef8*/ float get_IntervalDuration();
                /*0x3d0bf00*/ void set_IntervalDuration(float value);
                /*0x3d0bf08*/ float get_FadeOutDuration();
                /*0x3d0bf10*/ void set_FadeOutDuration(float value);
                /*0x3d0bf18*/ DG.Tweening.Sequence get_ActiveSequence();
                /*0x3d0bf20*/ void set_ActiveSequence(DG.Tweening.Sequence value);
            }

            class SkillNameLabel : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.CanvasGroup canvasGroup;
                /*0x28*/ TMPro.TextMeshProUGUI label;
                /*0x30*/ UnityEngine.UI.Image frame;
                /*0x38*/ UnityEngine.UI.HorizontalLayoutGroup points;
                /*0x40*/ UnityEngine.Sprite playerFrame;
                /*0x48*/ UnityEngine.Sprite enemyFrame;
                /*0x50*/ UnityEngine.Sprite activePoint;
                /*0x58*/ UnityEngine.Sprite passivePoint;
                /*0x60*/ float pauseDuration;
                /*0x64*/ float inDuration;
                /*0x68*/ float outDuration;
                /*0x70*/ DG.Tweening.Sequence sequence;

                /*0x3d0dc40*/ SkillNameLabel();
                /*0x3d0d698*/ void Playback(string skillName, Assets.Battle.Hud.SkillNameLabel.FrameTypes type, Assets.Battle.Hud.SkillNameLabel.PointTypes pointType, int pointAmount);
                /*0x3d0dc28*/ void OnDisable();
                /*0x3d0dc60*/ void <Playback>b__12_0();

                enum FrameTypes
                {
                    Player = 0,
                    Enemy = 1,
                }

                enum PointTypes
                {
                    Active = 0,
                    Passive = 1,
                }
            }

            class TotalDamageView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.CanvasGroup canvasGroup;
                /*0x28*/ TMPro.TextMeshProUGUI value;
                /*0x30*/ float fadeDuration;
                /*0x34*/ float fadeDelay;
                /*0x38*/ Assets.Battle.Utilities.PunchData punchData;
                /*0x40*/ DG.Tweening.Sequence activeSequence;
                /*0x48*/ long totalDamage;
                /*0x50*/ int totalHitCount;

                /*0x3d0e040*/ TotalDamageView();
                /*0x3d0dc98*/ void ResetTotalDamage();
                /*0x3d0dd98*/ void UpdateTotalDamage(long damage, int hitCount);
            }

            class TurnView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI turnValue;
                /*0x28*/ TMPro.TextMeshProUGUI turnCount;
                /*0x30*/ bool trigger;

                /*0x3d0e1ac*/ TurnView();
                /*0x3d0e0b8*/ void Update();
                /*0x3d0e0e8*/ Cysharp.Threading.Tasks.UniTask Playback(int turn, int turnsCount);

                struct <Playback>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Hud.TurnView <>4__this;
                    /*0x30*/ int turn;
                    /*0x34*/ int turnsCount;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d0e1b4*/ void MoveNext();
                    /*0x3d0e698*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        namespace Directors
        {
            interface IBattleEndedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class BattleEndedEventDirector : Assets.Battle.Directors.IBattleEndedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x18*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x28*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x30*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x38*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                /*0x40*/ Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing;
                /*0x48*/ Assets.GameUi.Services.ISchoolTacticalExerciseService schoolTacticalExerciseService;
                /*0x50*/ Assets.Api.Client.IApiClient apiClient;
                /*0x58*/ Assets.GameUi.Service.IMiningService miningService;
                /*0x60*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x68*/ Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer;
                /*0x70*/ Assets.Battle.Overseers.ILayoutOverseer layoutOverseer;

                static /*0x3d0ee84*/ Assets.GameUi.Icon.IconBase.IconArgs[] <CreateRewardsIconsArguments>g__CreateIconArgumentsFromMaster|17_0(long id, string name, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing);
                static /*0x3d0f2b8*/ Assets.GameUi.Icon.IconBase.IconArgs <CreateRewardsIconsArguments>g__CreateIconArguments|17_1(Assets.Api.Client.RewardMaster rewardMaster, string name, Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing);
                /*0x3d0e6a4*/ BattleEndedEventDirector(Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing, Assets.GameUi.Services.ISchoolTacticalExerciseService schoolTacticalExerciseService, Assets.Api.Client.IApiClient apiClient, Assets.GameUi.Service.IMiningService miningService, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer, Assets.Battle.Overseers.ILayoutOverseer layoutOverseer);
                /*0x3d0e7ec*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d0e8bc*/ Cysharp.Threading.Tasks.UniTask ShowResultDamageView();
                /*0x3d0e96c*/ Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.Api.Client.BattleEndedEvent eventData);
                /*0x3d0ece8*/ Assets.GameUi.Icon.IconBase.IconArgs[] CreateRewardsIconsArguments(Assets.Api.Client.QuestMaster questMaster);
                /*0x3d0f128*/ bool <ShowResultDamageView>b__15_1(Assets.Api.Client.TacticStageResult v);
                /*0x3d0f1ec*/ bool <ShowResultDamageView>b__15_2(Assets.Api.Client.TacticCycleQuestMaster v);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.BattleEndedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.TacticStageResult, long> <>9__15_0;
                    static /*0x10*/ System.Func<Assets.Api.Client.RewardMaster, bool> <>9__17_2;

                    static /*0x3d0f560*/ <>c();
                    /*0x3d0f5c8*/ <>c();
                    /*0x3d0f5d0*/ long <ShowResultDamageView>b__15_0(Assets.Api.Client.TacticStageResult v);
                    /*0x3d0f5e8*/ bool <CreateRewardsIconsArguments>b__17_2(Assets.Api.Client.RewardMaster reward);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Assets.Battle.Actor leadActor;
                    /*0x18*/ Assets.Battle.Directors.BattleEndedEventDirector <>4__this;

                    /*0x3d0f608*/ <>c__DisplayClass14_0();
                    /*0x3d0f610*/ void <Execute>b__1();
                    /*0x3d0f62c*/ void <Execute>b__0();
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ string name;
                    /*0x18*/ Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing;

                    /*0x3d0f2b0*/ <>c__DisplayClass17_0();
                    /*0x3d0f96c*/ Assets.GameUi.Icon.IconBase.IconArgs <CreateRewardsIconsArguments>b__3(Assets.Api.Client.RewardMaster rewardMaster);
                }

                struct <Execute>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Directors.BattleEndedEventDirector <>4__this;
                    /*0x30*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x38*/ Assets.Battle.Directors.BattleEndedEventDirector.<> <>8__1;
                    /*0x40*/ Assets.Api.Client.BattleEndedEvent <eventData>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d0f97c*/ void MoveNext();
                    /*0x3d12720*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowResultDamageView>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Directors.BattleEndedEventDirector <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.RawRanking>> <>u__1;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d1272c*/ void MoveNext();
                    /*0x3d136f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IBattleStartedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class BattleStartedEventDirector : Assets.Battle.Directors.IBattleStartedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x18*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x20*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x28*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x30*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x38*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x40*/ Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer;
                /*0x48*/ Assets.GameUi.Services.IBgmService bgmService;
                /*0x50*/ Assets.AssetManagement.IAssetInstanceProvider assetProvider;
                /*0x58*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
                /*0x60*/ Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService;
                /*0x68*/ Assets.Battle.Overseers.IFieldOverseer fieldOverseer;
                /*0x70*/ Assets.GameUi.Externals.IUiLayoutManager uiLayoutManager;
                /*0x78*/ Assets.Battle.Overseers.ILayoutOverseer layoutOverseer;
                /*0x80*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;

                /*0x3d13704*/ BattleStartedEventDirector(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer, Assets.GameUi.Services.IBgmService bgmService, Assets.AssetManagement.IAssetInstanceProvider assetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService, Assets.Battle.Overseers.IFieldOverseer fieldOverseer, Assets.GameUi.Externals.IUiLayoutManager uiLayoutManager, Assets.Battle.Overseers.ILayoutOverseer layoutOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer);
                /*0x3d13878*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d13950*/ Cysharp.Threading.Tasks.UniTask PlaybackCharacterVoices(Assets.Battle.Actor[] playerActors, Assets.Battle.Actor[] enemyActors);
                /*0x3d13a38*/ System.Threading.Tasks.Task TryPlaybackMemoryAnimation();
                /*0x3d13b28*/ void <PlaybackCharacterVoices>g__PlaybackVoice|17_0(Assets.Battle.Actor actor, Assets.GameUi.Externals.CharacterBattleVoiceTypes type);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.BattleStartedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Actor, int> <>9__16_0;
                    static /*0x10*/ System.Func<Assets.Api.Client.PawnMasterView, bool> <>9__17_3;

                    static /*0x3d13cb4*/ <>c();
                    /*0x3d13d1c*/ <>c();
                    /*0x3d13d24*/ int <Execute>b__16_0(Assets.Battle.Actor a);
                    /*0x3d13d3c*/ bool <PlaybackCharacterVoices>b__17_3(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Assets.Battle.Actor player;

                    /*0x3d13d58*/ <>c__DisplayClass17_0();
                    /*0x3d13d60*/ bool <PlaybackCharacterVoices>b__1(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass17_1
                {
                    /*0x10*/ Assets.Battle.Actor enemy;

                    /*0x3d13d9c*/ <>c__DisplayClass17_1();
                    /*0x3d13da4*/ bool <PlaybackCharacterVoices>b__2(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass17_2
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d13cac*/ <>c__DisplayClass17_2();
                    /*0x3d13de0*/ void <PlaybackCharacterVoices>b__4();
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ Assets.VisualEffectData.VfxAnimationHandler memoryVfx;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource source;

                    /*0x3d13dfc*/ <>c__DisplayClass18_0();
                    /*0x3d13e04*/ void <TryPlaybackMemoryAnimation>b__0();
                }

                struct <Execute>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.BattleStartedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Actor[] <playerActors>5__2;
                    /*0x40*/ Assets.Battle.Actor[] <enemyActors>5__3;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask <entranceAnimation>5__4;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__2;
                    /*0x80*/ System.Runtime.CompilerServices.TaskAwaiter <>u__3;

                    /*0x3d13e44*/ void MoveNext();
                    /*0x3d170e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlaybackCharacterVoices>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor[] playerActors;
                    /*0x30*/ Assets.Battle.Directors.BattleStartedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Actor[] enemyActors;
                    /*0x40*/ Assets.Battle.Actor <leadActor>5__2;
                    /*0x48*/ Assets.Battle.Actor <replyActor>5__3;
                    /*0x50*/ Assets.GameUi.Externals.CharacterBattleVoiceTypes <teamVoice>5__4;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x68*/ int <i>5__5;
                    /*0x70*/ Assets.Battle.Actor <actor>5__6;

                    /*0x3d170f4*/ void MoveNext();
                    /*0x3d18084*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryPlaybackMemoryAnimation>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Assets.Battle.Directors.BattleStartedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Directors.BattleStartedEventDirector.<> <>8__1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxAnimationHandler> <>u__1;
                    /*0x58*/ int <i>5__2;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__2;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__3;

                    /*0x3d18090*/ void MoveNext();
                    /*0x3d1953c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IDirector
            {
                Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
            }

            interface IPawnUsedSkillEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnUsedSkillEventDirector : Assets.Battle.Directors.IPawnUsedSkillEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;

                /*0x3d195a4*/ PawnUsedSkillEventDirector(Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer);
                /*0x3d195d4*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
            }

            interface IManeuverOrderUpdatedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class ManeuverOrderUpdatedEventDirector : Assets.Battle.Directors.IManeuverOrderUpdatedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x18*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d19740*/ ManeuverOrderUpdatedEventDirector(Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d19784*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d199e4*/ void <Execute>g__AddPawnToActionQueue|3_0(Assets.Api.Client.PawnId pawnId, ref Assets.Battle.Directors.ManeuverOrderUpdatedEventDirector.<> );

                struct <>c__DisplayClass3_0
                {
                    /*0x10*/ Assets.Battle.Directors.ManeuverOrderUpdatedEventDirector <>4__this;
                    /*0x18*/ System.Collections.Generic.List<Assets.Battle.Actor> actors;
                }
            }

            interface IMasterDataUpdatedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class MasterDataUpdatedEventDirector : Assets.Battle.Directors.IMasterDataUpdatedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.DataModels.IBattleDataStorageModel model;

                /*0x3d19b68*/ MasterDataUpdatedEventDirector(Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d19b98*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
            }

            interface IPawnAuraAddedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnAuraAddedEventDirector : Assets.Battle.Directors.IPawnAuraAddedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;
                /*0x20*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x28*/ Assets.GameUi.Externals.IAudioManager audioManager;

                /*0x3d19d08*/ PawnAuraAddedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d19d7c*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d19e4c*/ Cysharp.Threading.Tasks.UniTask AddContinuousVfx(Assets.Battle.Actor actor, string key);

                struct <AddContinuousVfx>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor actor;
                    /*0x30*/ string key;
                    /*0x38*/ Assets.Battle.Directors.PawnAuraAddedEventDirector <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d19f30*/ void MoveNext();
                    /*0x3d1a62c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Execute>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnAuraAddedEventDirector <>4__this;
                    /*0x38*/ Assets.Api.Client.PawnAuraAddedEvent <eventData>5__2;
                    /*0x40*/ Assets.Battle.Actor <actor>5__3;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d1a638*/ void MoveNext();
                    /*0x3d1b268*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnAuraRemovedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnAuraRemovedEventDirector : Assets.Battle.Directors.IPawnAuraRemovedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;
                /*0x20*/ Assets.GameUi.Externals.IAudioManager audioManager;

                /*0x3d1b274*/ PawnAuraRemovedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d1b2d4*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d1b8d4*/ void RemoveContinuousVfx(Assets.Battle.Actor actor, string key);
            }

            interface IPawnAuraUpdatedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnAuraUpdatedEventDirector : Assets.Battle.Directors.IPawnAuraUpdatedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d1b9cc*/ PawnAuraUpdatedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d1b9fc*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
            }

            interface IPawnChargesSkillEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnChargesSkillEventDirector : Assets.Battle.Directors.IPawnChargesSkillEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x20*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x28*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x30*/ Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer;

                /*0x3d1bc10*/ PawnChargesSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer);
                /*0x3d1bca0*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Api.Client.PawnChargesSkillEvent eventData;

                    /*0x3d1bd70*/ <>c__DisplayClass6_0();
                    /*0x3d1bd78*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
                }

                struct <Execute>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnChargesSkillEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Actor <actor>5__2;
                    /*0x40*/ Assets.Api.Client.SkillMasterView <skillView>5__3;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__2;

                    /*0x3d1bdb4*/ void MoveNext();
                    /*0x3d1d0cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnDiedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnDiedEventDirector : Assets.Battle.Directors.IPawnDiedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x28*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x30*/ Assets.GameUi.Externals.IAudioManager audioManager;

                /*0x3d1d0d8*/ PawnDiedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d1d168*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d1d24c*/ <>c__DisplayClass6_0();
                    /*0x3d1d254*/ void <Execute>b__0();
                }

                struct <Execute>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnDiedEventDirector <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x40*/ Assets.Battle.Directors.PawnDiedEventDirector.<> <>8__1;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d1d270*/ void MoveNext();
                    /*0x3d1e1c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnPreparesSkillEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnPreparesSkillEventDirector : Assets.Battle.Directors.IPawnPreparesSkillEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;

                /*0x3d1e1d0*/ PawnPreparesSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d1e230*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ Assets.Api.Client.PawnPreparesSkillEvent eventData;

                    /*0x3d1e314*/ <>c__DisplayClass4_0();
                    /*0x3d1e31c*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
                }

                struct <Execute>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x38*/ Assets.Battle.Directors.PawnPreparesSkillEventDirector <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d1e358*/ void MoveNext();
                    /*0x3d1eccc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnReceivedDamageEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnReceivedDamageEventDirector : Assets.Battle.Directors.IPawnReceivedDamageEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;
                /*0x18*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x28*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x30*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;
                /*0x38*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x40*/ Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer;
                /*0x48*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;

                /*0x3d1ecd8*/ PawnReceivedDamageEventDirector(Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer);
                /*0x3d1edac*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d1ee84*/ void DumpDebugDataToLog(Assets.Api.Client.PawnReceivedDamageEvent eventData);

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ Assets.Api.Client.PawnReceivedDamageEvent eventData;

                    /*0x3d1f724*/ <>c__DisplayClass10_0();
                    /*0x3d1f72c*/ bool <DumpDebugDataToLog>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d1f75c*/ bool <DumpDebugDataToLog>b__1(Assets.Api.Client.PawnMasterView p);
                    /*0x3d1f78c*/ bool <DumpDebugDataToLog>b__2(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;
                    /*0x18*/ Assets.Api.Client.PawnReceivedDamageEvent eventData;

                    /*0x3d1f7bc*/ <>c__DisplayClass9_0();
                    /*0x3d1f7c4*/ void <Execute>b__1();
                    /*0x3d1f7e0*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass9_1
                {
                    /*0x10*/ Assets.Battle.Actor sourcePawn;

                    /*0x3d1f810*/ <>c__DisplayClass9_1();
                    /*0x3d1f818*/ void <Execute>b__2();
                }

                struct <Execute>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnReceivedDamageEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Directors.PawnReceivedDamageEventDirector.<> <>8__1;
                    /*0x40*/ Assets.Battle.Overseers.CombatTextOverseer.FontTypes <fontType>5__2;
                    /*0x48*/ string <damageLabel>5__3;
                    /*0x50*/ Spine.Unity.BoneFollower <damagePoint>5__4;
                    /*0x58*/ bool <shouldUpdateTotalDamage>5__5;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d1f834*/ void MoveNext();
                    /*0x3d22580*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnReceivedHealingEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnReceivedHealingEventDirector : Assets.Battle.Directors.IPawnReceivedHealingEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;
                /*0x18*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x28*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x30*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x38*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;

                /*0x3d2258c*/ PawnReceivedHealingEventDirector(Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer);
                /*0x3d22630*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d22714*/ void DumpDebugDataToLog(Assets.Api.Client.PawnReceivedHealingEvent eventData);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Assets.Api.Client.PawnReceivedHealingEvent eventData;

                    /*0x3d22d74*/ <>c__DisplayClass7_0();
                    /*0x3d22d7c*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ Assets.Api.Client.PawnReceivedHealingEvent eventData;

                    /*0x3d22d6c*/ <>c__DisplayClass8_0();
                    /*0x3d22dac*/ bool <DumpDebugDataToLog>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d22ddc*/ bool <DumpDebugDataToLog>b__1(Assets.Api.Client.PawnMasterView p);
                }

                struct <Execute>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnReceivedHealingEventDirector <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x40*/ Assets.Battle.Directors.PawnReceivedHealingEventDirector.<> <>8__1;
                    /*0x48*/ Assets.Battle.Actor <actor>5__2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d22e0c*/ void MoveNext();
                    /*0x3d23ed8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnReceivedVfxEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnReceivedVfxEventDirector : Assets.Battle.Directors.IPawnReceivedVfxEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer;
                /*0x20*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;
                /*0x28*/ Assets.Battle.DataModels.IBattleDataStorageModel model;

                /*0x3d23ee4*/ PawnReceivedVfxEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d23f58*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d2403c*/ Cysharp.Threading.Tasks.UniTask FireCombatText(Assets.Api.Client.PawnReceivedVfxEvent eventData, Assets.Battle.Actor actor);

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Assets.Battle.Directors.PawnReceivedVfxEventDirector <>4__this;
                    /*0x18*/ Assets.Api.Client.PawnReceivedVfxEvent eventData;
                    /*0x20*/ Assets.Battle.Actor actor;

                    /*0x3d24304*/ <>c__DisplayClass5_0();
                    /*0x3d2430c*/ void <Execute>b__0(Assets.VisualEffectData.VfxHandler _);

                    struct <<Execute>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Directors.PawnReceivedVfxEventDirector.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3d243bc*/ void MoveNext();
                        /*0x3d246dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                struct <Execute>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Directors.PawnReceivedVfxEventDirector <>4__this;
                    /*0x30*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x40*/ Assets.Battle.Directors.PawnReceivedVfxEventDirector.<> <>8__1;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;
                    /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d246e8*/ void MoveNext();
                    /*0x3d2544c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnResourcesUpdatedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnResourcesUpdatedEventDirector : Assets.Battle.Directors.IPawnResourcesUpdatedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x20*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x28*/ Assets.GameUi.Externals.IAudioManager audioManager;

                /*0x3d25458*/ PawnResourcesUpdatedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d254cc*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Assets.Api.Client.PawnResourcesUpdatedEvent eventData;

                    /*0x3d25958*/ <>c__DisplayClass5_0();
                    /*0x3d25960*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                }
            }

            interface IPawnsAreTargetedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnsAreTargetedEventDirector : Assets.Battle.Directors.IPawnsAreTargetedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer;
                /*0x20*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x28*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x30*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x38*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x40*/ Assets.Battle.Shared.ISkillMotionOverseer skillMotionOverseer;
                /*0x48*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x50*/ Assets.Battle.Utilities.IMetronome metronome;
                /*0x58*/ Assets.Battle.Overseers.IFieldOverseer fieldOverseer;
                /*0x60*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> existingTasks;

                static /*0x3d27adc*/ UnityEngine.Vector3 <CalculateTargetPosition>g__GetSingleTargetPosition|20_1(Assets.Battle.Actor[] motionTargets, System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d25988*/ PawnsAreTargetedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Shared.ISkillMotionOverseer skillMotionOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Utilities.IMetronome metronome, Assets.Battle.Overseers.IFieldOverseer fieldOverseer);
                /*0x3d25b00*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d25bec*/ Cysharp.Threading.Tasks.UniTask TryAwaitForMovementCompletionIfNotCompleted(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData);
                /*0x3d25ca8*/ bool CanSkipMotion(Assets.Api.Client.SkillMasterView skillView, Assets.Api.Client.SkillTargetGroupView targetGroupView);
                /*0x3d25d90*/ void DumpDebugDataToLog(Assets.Api.Client.PawnsAreTargetedEvent eventData, Assets.Api.Client.SkillMasterView skillView, Assets.Api.Client.SkillTargetGroupView targetGroupView, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData);
                /*0x3d26b80*/ Assets.Battle.Actor[] SelectMotionTargets(System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targets);
                /*0x3d26cd0*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> CreateTargetDataDictionary(Assets.Api.Client.PawnsAreTargetedEvent eventData);
                /*0x3d27174*/ Cysharp.Threading.Tasks.UniTask ShowSkillLabel(Assets.Battle.Actor actor, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3d27260*/ Cysharp.Threading.Tasks.UniTask RestoreInterceptorsState(System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targetData);
                /*0x3d277a8*/ UnityEngine.Vector3 CalculateTargetPosition(Assets.VisualEffectData.VfxHandler vfx, Assets.Battle.Actor actor, Assets.Battle.Actor[] motionTargets, System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions);
                /*0x3d27c5c*/ Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3>> TriggerInterceptions(Assets.Battle.Actor actor, System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targetData);
                /*0x3d27da8*/ Cysharp.Threading.Tasks.UniTask PlaybackSkillMotion(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, Assets.Api.Client.IBattleEngineEvent eventData, Assets.Battle.IEventProcessor eventProcessor);
                /*0x3d27ea8*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> CreateSkillData(Assets.Battle.Actor actor, Assets.Battle.Actor[] targets, Assets.Api.Client.SkillMasterView skillView, Assets.Api.Client.SkillTargetGroupView targetGroupView, Assets.Api.Client.PawnsAreTargetedEvent eventData, System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions);
                /*0x3d2803c*/ Cysharp.Threading.Tasks.UniTask ProcessNextPossibleEvent(int tick, Assets.Battle.IEventProcessor eventProcessor);
                /*0x3d280e4*/ UnityEngine.Vector3 <CalculateTargetPosition>b__20_0(Assets.Battle.Actor t);
                /*0x3d281bc*/ UnityEngine.Vector3 <TriggerInterceptions>b__21_0(Assets.Battle.Actor t);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Cysharp.Threading.Tasks.UniTask, bool> <>9__12_4;
                    static /*0x10*/ System.Func<System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>, System.Collections.Generic.IEnumerable<Assets.Battle.Actor>> <>9__16_0;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, bool> <>9__23_1;
                    static /*0x20*/ System.Func<Assets.Battle.Actor, Assets.Battle.Shared.SharedActor> <>9__23_2;
                    static /*0x28*/ System.Func<Assets.Battle.Actor, bool> <>9__23_5;

                    static /*0x3d28294*/ <>c();
                    /*0x3d282fc*/ <>c();
                    /*0x3d28304*/ bool <Execute>b__12_4(Cysharp.Threading.Tasks.UniTask t);
                    /*0x3d283fc*/ System.Collections.Generic.IEnumerable<Assets.Battle.Actor> <SelectMotionTargets>b__16_0(System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>> item);
                    /*0x3d284dc*/ bool <CreateSkillData>b__23_1(Assets.Battle.Actor t);
                    /*0x3d284f4*/ Assets.Battle.Shared.SharedActor <CreateSkillData>b__23_2(Assets.Battle.Actor t);
                    /*0x3d28588*/ bool <CreateSkillData>b__23_5(Assets.Battle.Actor t);
                }

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ Assets.Api.Client.PawnsAreTargetedEvent eventData;
                    /*0x18*/ Assets.Battle.Actor actor;

                    /*0x3d285a0*/ <>c__DisplayClass12_0();
                    /*0x3d285a8*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
                    /*0x3d285e4*/ bool <Execute>b__1(Assets.Api.Client.SkillTargetGroupView s);
                    /*0x3d28620*/ void <Execute>b__2();
                    /*0x3d2863c*/ void <Execute>b__3();
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource completionSource;

                    /*0x3d28658*/ <>c__DisplayClass13_0();
                    /*0x3d28660*/ void <TryAwaitForMovementCompletionIfNotCompleted>b__0(string motion);
                    /*0x3d28700*/ void <TryAwaitForMovementCompletionIfNotCompleted>b__1(string _);
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ Assets.Api.Client.PawnsAreTargetedEvent eventData;

                    /*0x3d26b68*/ <>c__DisplayClass15_0();
                    /*0x3d28748*/ bool <DumpDebugDataToLog>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d28778*/ bool <DumpDebugDataToLog>b__1(Assets.Api.Client.PawnMasterView p);
                    /*0x3d28868*/ bool <DumpDebugDataToLog>b__2(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass15_1
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView p;

                    /*0x3d28860*/ <>c__DisplayClass15_1();
                    /*0x3d28958*/ bool <DumpDebugDataToLog>b__3(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass15_2
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView p;

                    /*0x3d28950*/ <>c__DisplayClass15_2();
                    /*0x3d28988*/ bool <DumpDebugDataToLog>b__4(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass15_3
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView item;

                    /*0x3d26b70*/ <>c__DisplayClass15_3();
                    /*0x3d289c4*/ bool <DumpDebugDataToLog>b__5(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass15_4
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView item;

                    /*0x3d26b78*/ <>c__DisplayClass15_4();
                    /*0x3d289f4*/ bool <DumpDebugDataToLog>b__6(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x18*/ Assets.Battle.Actor actor;
                    /*0x20*/ Assets.Api.Client.SkillTargetGroupView targetGroupView;

                    /*0x3d28a28*/ <>c__DisplayClass23_0();
                    /*0x3d28a30*/ UnityEngine.Vector3 <CreateSkillData>b__0(Assets.Battle.Actor t);
                    /*0x3d28b10*/ Cysharp.Threading.Tasks.UniTask <CreateSkillData>b__4(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                    /*0x3d28b34*/ string <CreateSkillData>g__AcquireMotionName|3(Assets.Api.Client.SkillMasterView skillMaster);
                }

                struct <CreateSkillData>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> <>t__builder;
                    /*0x30*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Assets.Api.Client.SkillTargetGroupView targetGroupView;
                    /*0x48*/ Assets.Battle.Actor[] targets;
                    /*0x50*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector.<> <>8__1;
                    /*0x58*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions;
                    /*0x60*/ Assets.Api.Client.PawnsAreTargetedEvent eventData;
                    /*0x68*/ Assets.Api.Client.SkillMasterView skillView;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d28c30*/ void MoveNext();
                    /*0x3d2a228*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Execute>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector.<> <>8__1;
                    /*0x40*/ Assets.Battle.IEventProcessor eventProcessor;
                    /*0x48*/ Assets.Api.Client.SkillMasterView <skillView>5__2;
                    /*0x50*/ Assets.Api.Client.SkillTargetGroupView <targetGroupView>5__3;
                    /*0x58*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> <targetData>5__4;
                    /*0x60*/ Assets.Battle.Actor[] <motionTargets>5__5;
                    /*0x68*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData <skillData>5__6;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3>> <>u__1;
                    /*0x88*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> <>u__2;
                    /*0xa0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__3;

                    /*0x3d2b72c*/ void MoveNext();
                    /*0x3d2dd04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlaybackSkillMotion>d__22 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x38*/ Assets.Api.Client.IBattleEngineEvent eventData;
                    /*0x40*/ Assets.Battle.IEventProcessor eventProcessor;
                    /*0x48*/ int <tick>5__2;
                    /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x60*/ System.Runtime.CompilerServices.ConfiguredCancelableAsyncEnumerable.Enumerator<string> <>7__wrap2;
                    /*0x70*/ object <>7__wrap3;
                    /*0x78*/ int <>7__wrap4;
                    /*0x80*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<bool> <>u__2;
                    /*0x90*/ System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter <>u__3;

                    /*0x3d2dd10*/ void MoveNext();
                    /*0x3d2eb14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowSkillLabel>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d2eb20*/ void MoveNext();
                    /*0x3d2f12c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TriggerInterceptions>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3>> <>t__builder;
                    /*0x30*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targetData;
                    /*0x38*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x40*/ Assets.Battle.Actor actor;
                    /*0x48*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> <actions>5__2;
                    /*0x50*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> <interceptorPositions>5__3;
                    /*0x58*/ System.Collections.Generic.Dictionary.ValueCollection.Enumerator<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> <>7__wrap3;
                    /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d2f138*/ void MoveNext();
                    /*0x3d2fe9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAwaitForMovementCompletionIfNotCompleted>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData;
                    /*0x30*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector.<> <>8__1;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d2fef4*/ void MoveNext();
                    /*0x3d30774*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnSkippedManeuverEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnSkippedManeuverEventDirector : Assets.Battle.Directors.IPawnSkippedManeuverEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x20*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;
                /*0x28*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x30*/ Assets.Battle.DataModels.IBattleDataStorageModel model;

                /*0x3d30780*/ PawnSkippedManeuverEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d30810*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d308e0*/ <>c__DisplayClass6_0();
                    /*0x3d308e8*/ void <Execute>b__0();
                }

                struct <Execute>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.PawnSkippedManeuverEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Directors.PawnSkippedManeuverEventDirector.<> <>8__1;
                    /*0x40*/ Spine.Unity.BoneFollower <damagePoint>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d30904*/ void MoveNext();
                    /*0x3d31c94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnSpawnedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnSpawnedEventDirector : Assets.Battle.Directors.IPawnSpawnedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x20*/ Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer;
                /*0x28*/ Assets.Battle.ICache cache;
                /*0x30*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x38*/ Assets.Battle.DataModels.IBattleDataStorageModel model;

                /*0x3d31ca0*/ PawnSpawnedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.ICache cache, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d31d44*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class Parameters
                {
                    /*0x10*/ int <Id>k__BackingField;
                    /*0x14*/ Assets.Battle.Actor.AttackTypes <Type>k__BackingField;
                    /*0x18*/ Assets.Battle.Actor.Formation <Formation>k__BackingField;
                    /*0x1c*/ int <PositionIndex>k__BackingField;
                    /*0x20*/ bool <IsEnemyActor>k__BackingField;
                    /*0x24*/ UnityEngine.Vector3 <Position>k__BackingField;

                    /*0x3d31e90*/ Parameters();
                    /*0x3d31e24*/ int get_Id();
                    /*0x3d31e2c*/ void set_Id(int value);
                    /*0x3d31e34*/ Assets.Battle.Actor.AttackTypes get_Type();
                    /*0x3d31e3c*/ void set_Type(Assets.Battle.Actor.AttackTypes value);
                    /*0x3d31e44*/ Assets.Battle.Actor.Formation get_Formation();
                    /*0x3d31e4c*/ void set_Formation(Assets.Battle.Actor.Formation value);
                    /*0x3d31e54*/ int get_PositionIndex();
                    /*0x3d31e5c*/ void set_PositionIndex(int value);
                    /*0x3d31e64*/ bool get_IsEnemyActor();
                    /*0x3d31e6c*/ void set_IsEnemyActor(bool value);
                    /*0x3d31e78*/ UnityEngine.Vector3 get_Position();
                    /*0x3d31e84*/ void set_Position(UnityEngine.Vector3 value);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Assets.Api.Client.PawnSpawnedEvent eventData;
                    /*0x18*/ Assets.Battle.Directors.PawnSpawnedEventDirector <>4__this;

                    /*0x3d31e98*/ <>c__DisplayClass7_0();
                    /*0x3d31ea0*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d31ed0*/ string <Execute>b__1(string d);
                }

                struct <Execute>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Directors.PawnSpawnedEventDirector <>4__this;
                    /*0x30*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x40*/ Assets.Battle.Directors.PawnSpawnedEventDirector.<> <>8__1;
                    /*0x48*/ Assets.Api.Client.PawnMasterView <pawnView>5__2;
                    /*0x50*/ Assets.Battle.Actor <actor>5__3;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Actor> <>u__1;
                    /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;
                    /*0x80*/ Assets.Battle.Actor <>7__wrap3;
                    /*0x88*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>u__3;
                    /*0xa0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActorStatusView> <>u__4;
                    /*0xb8*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActorStatusIcon> <>u__5;

                    /*0x3d31f84*/ void MoveNext();
                    /*0x3d34908*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnStoppedChargingSkillEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnStoppedChargingSkillEventDirector : Assets.Battle.Directors.IPawnStoppedChargingSkillEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d34914*/ PawnStoppedChargingSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d34944*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
            }

            interface IPawnUsesSkillEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnUsesSkillEventDirector : Assets.Battle.Directors.IPawnUsesSkillEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;
                /*0x18*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x20*/ Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer;
                /*0x28*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x30*/ Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer;
                /*0x38*/ Assets.GameUi.Externals.IAudioManager audioManager;

                /*0x3d34bb0*/ PawnUsesSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d34c54*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Assets.Api.Client.PawnUsesSkillEvent eventData;

                    /*0x3d352dc*/ <>c__DisplayClass7_0();
                    /*0x3d352e4*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
                }
            }

            interface ITurnStartedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class TurnStartedEventDirector : Assets.Battle.Directors.ITurnStartedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x18*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x20*/ Assets.Battle.Overseers.ICameraOverseer cameraOverseer;
                /*0x28*/ Assets.GameUi.Externals.IAudioManager audioManager;
                /*0x30*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d35320*/ TurnStartedEventDirector(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d353b0*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.TurnStartedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Actor, bool> <>9__6_0;
                    static /*0x10*/ System.Func<Assets.Battle.Actor, long> <>9__6_1;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, bool> <>9__6_2;
                    static /*0x20*/ System.Func<Assets.Battle.Actor, long> <>9__6_3;

                    static /*0x3d35480*/ <>c();
                    /*0x3d354e8*/ <>c();
                    /*0x3d354f0*/ bool <Execute>b__6_0(Assets.Battle.Actor a);
                    /*0x3d35510*/ long <Execute>b__6_1(Assets.Battle.Actor a);
                    /*0x3d35530*/ bool <Execute>b__6_2(Assets.Battle.Actor a);
                    /*0x3d35550*/ long <Execute>b__6_3(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d35570*/ <>c__DisplayClass6_0();
                    /*0x3d35578*/ void <Execute>b__4();
                }

                struct <Execute>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.TurnStartedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Directors.TurnStartedEventDirector.<> <>8__1;
                    /*0x40*/ Assets.Api.Client.TurnStartedEvent <eventData>5__2;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d35594*/ void MoveNext();
                    /*0x3d36978*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ITutorialMessageEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class TutorialMessageEventDirector : Assets.Battle.Directors.ITutorialMessageEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer;
                /*0x18*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;

                /*0x3d36984*/ TutorialMessageEventDirector(Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer);
                /*0x3d369c8*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d36a98*/ void <Execute>b__3_0();

                struct <Execute>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.TutorialMessageEventDirector <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d36b3c*/ void MoveNext();
                    /*0x3d37338*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IWaveStartedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class WaveStartedEventDirector : Assets.Battle.Directors.IWaveStartedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;

                /*0x3d37344*/ WaveStartedEventDirector(Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer);
                /*0x3d37374*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Assets.VisualEffectData.VfxHandler vfx;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource entranceTaskCompletionSource;

                    /*0x3d37448*/ <>c__DisplayClass2_0();
                    /*0x3d37450*/ void <Execute>b__0();
                }

                struct <Execute>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.WaveStartedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Directors.WaveStartedEventDirector.<> <>8__1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d37490*/ void MoveNext();
                    /*0x3d37fb0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        namespace DataModels
        {
            interface IBattleDataStorageModel
            {
                /*0x38148bc*/ UniRx.ReactiveProperty<int> get_BattleSpeed();
                /*0x38148bc*/ UniRx.ReactiveProperty<float> get_BattlePlaybackSpeed();
                /*0x38148bc*/ UniRx.ReactiveProperty<System.ValueTuple<int, int>> get_Turn();
                /*0x38148bc*/ UniRx.ReactiveProperty<string> get_Quest();
                /*0x38148bc*/ UniRx.ReactiveProperty<bool> get_EnabledStaticCamera();
                /*0x38148bc*/ UnityEngine.Vector3[] get_ActorFieldPositions();
                /*0x3816710*/ void set_ActorFieldPositions(UnityEngine.Vector3[] value);
                /*0x38148bc*/ Assets.Api.Client.MasterDataView get_MasterData();
                /*0x3816710*/ void set_MasterData(Assets.Api.Client.MasterDataView value);
                /*0x3814574*/ int get_VictoryAdditionalMoveBackCount();
                /*0x3815ed0*/ void set_VictoryAdditionalMoveBackCount(int value);
                /*0x3814574*/ int get_LoseAdditionalMoveBackCount();
                /*0x3815ed0*/ void set_LoseAdditionalMoveBackCount(int value);
                /*0x38148bc*/ UniRx.ReactiveProperty<bool> get_PauseCurrentEventProcess();
                /*0x38148bc*/ UnityEngine.Events.UnityEvent get_OnSkipCurrentEventProcess();
                /*0x38148bc*/ UnityEngine.Events.UnityEvent get_OnProcessSingleEvent();
                /*0x38148bc*/ UnityEngine.Events.UnityEvent get_UserInputTriggeredEvent();
                /*0x38148bc*/ Assets.Api.Client.QuestMaster get_QuestMaster();
                /*0x3816710*/ void set_QuestMaster(Assets.Api.Client.QuestMaster value);
                /*0x38148bc*/ UniRx.ReactiveProperty<bool> get_EnableGameNotifications();
                /*0x38148bc*/ Assets.Api.Client.Mining get_Mining();
                /*0x3816710*/ void set_Mining(Assets.Api.Client.Mining value);
                /*0x38148bc*/ Assets.Api.Client.User get_User();
                /*0x3816710*/ void set_User(Assets.Api.Client.User value);
                /*0x38148bc*/ Assets.Api.Client.PlayerRankMaster get_RankMaster();
                /*0x3816710*/ void set_RankMaster(Assets.Api.Client.PlayerRankMaster value);
                /*0x3814574*/ Assets.Api.Client.BattleOutcome get_Outcome();
                /*0x3815ed0*/ void set_Outcome(Assets.Api.Client.BattleOutcome value);
                /*0x3814574*/ Assets.GameUi.BattleArguments.BattleTypes get_BattleType();
                /*0x3815ed0*/ void set_BattleType(Assets.GameUi.BattleArguments.BattleTypes value);
                /*0x3813ffc*/ bool get_IsPlayground();
                /*0x3815cc4*/ void set_IsPlayground(bool value);
                /*0x3813ffc*/ bool get_IsFirstTurnHappend();
                /*0x3815cc4*/ void set_IsFirstTurnHappend(bool value);
                /*0x38148bc*/ Assets.Battle.Actor get_SkillTarget();
                /*0x3816710*/ void set_SkillTarget(Assets.Battle.Actor value);
                /*0x3813ffc*/ bool get_HasLargeScaleMecanim();
                /*0x3815cc4*/ void set_HasLargeScaleMecanim(bool value);
                /*0x3814574*/ Assets.GameUi.BattleArguments.BattleTutorialTypes get_Tutorial();
                /*0x3815ed0*/ void set_Tutorial(Assets.GameUi.BattleArguments.BattleTutorialTypes value);
                /*0x3813ffc*/ bool get_DebugMode();
                /*0x3815cc4*/ void set_DebugMode(bool value);
                /*0x3813ffc*/ bool get_ShowEnemiesHpValue();
                /*0x3815cc4*/ void set_ShowEnemiesHpValue(bool value);
                /*0x38148bc*/ UniRx.ReactiveProperty<bool> get_EnabledCockpitView();
                /*0x38146fc*/ long get_TotalDamageScore();
                /*0x381630c*/ void set_TotalDamageScore(long value);
                /*0x3813ffc*/ bool get_SlowMotionOnBattleEndWasTriggered();
                /*0x3815cc4*/ void set_SlowMotionOnBattleEndWasTriggered(bool value);
                /*0x38148bc*/ Assets.Api.Client.PawnId get_MvpAttacker();
                /*0x3816710*/ void set_MvpAttacker(Assets.Api.Client.PawnId value);
                /*0x38148bc*/ Assets.Api.Client.PawnId get_MvpDefender();
                /*0x3816710*/ void set_MvpDefender(Assets.Api.Client.PawnId value);
                /*0x38148bc*/ Assets.Api.Client.PawnId get_MvpHealer();
                /*0x3816710*/ void set_MvpHealer(Assets.Api.Client.PawnId value);
                /*0x38148bc*/ Assets.Battle.BattleController.LocalBattleSettings get_LocalBattleSettings();
                /*0x3816710*/ void set_LocalBattleSettings(Assets.Battle.BattleController.LocalBattleSettings value);
                /*0x3813ffc*/ bool get_SingleExtraSkillPerDayEnabled();
                /*0x3815cc4*/ void set_SingleExtraSkillPerDayEnabled(bool value);
                /*0x38148bc*/ System.Action get_UpdateLocalBattleSettingsCallback();
                /*0x3816710*/ void set_UpdateLocalBattleSettingsCallback(System.Action value);
                /*0x38159dc*/ void AccelerateBattleSpeed();
                /*0x3814200*/ bool IsPlayerTeamHasAttributesAdvantages(Assets.Battle.Actor[] playerActors, Assets.Battle.Actor[] enemyActors);
                /*0x3815cc4*/ void InitializeBattleSpeedSettings(bool IsFunctionUnlocked);
                /*0x3815cc4*/ void InitializeCameraSettings(bool IsFunctionUnlocked);
                /*0x3815cc4*/ void InitializeCockpitViewSettings(bool IsFunctionUnlocked);
                bool IsAttributeIsAdvantageous(Assets.Api.Client.CharacterAttributes attackerAttribute, Assets.Api.Client.CharacterAttributes targetAttribute);
                /*0x3813ffc*/ bool IsPlayerTeamHasAttributesAdvantages();
            }

            class BattleDataStorageModel : Assets.Battle.DataModels.IBattleDataStorageModel, Assets.Battle.Shared.ISharedBattleDataStorageModel, System.IDisposable
            {
                static string BattleSpeedPrefsKey = "Izanami_BattleSpeed";
                static string BattleCameraPrefsKey = "Izanami_BattleCamera";
                static string BattleCockpitViewPrefsKey = "Izanami_BattleCockpitView";
                /*0x10*/ UniRx.CompositeDisposable disposables;
                /*0x18*/ UniRx.ReactiveProperty<int> <BattleSpeed>k__BackingField;
                /*0x20*/ UniRx.ReactiveProperty<float> <BattlePlaybackSpeed>k__BackingField;
                /*0x28*/ UniRx.ReactiveProperty<System.ValueTuple<int, int>> <Turn>k__BackingField;
                /*0x30*/ UniRx.ReactiveProperty<string> <Quest>k__BackingField;
                /*0x38*/ UniRx.ReactiveProperty<bool> <EnabledStaticCamera>k__BackingField;
                /*0x40*/ UniRx.ReactiveProperty<bool> <PauseCurrentEventProcess>k__BackingField;
                /*0x48*/ UniRx.ReactiveProperty<bool> <EnableGameNotifications>k__BackingField;
                /*0x50*/ UniRx.ReactiveProperty<bool> <EnabledCockpitView>k__BackingField;
                /*0x58*/ UnityEngine.Events.UnityEvent <OnSkipCurrentEventProcess>k__BackingField;
                /*0x60*/ UnityEngine.Events.UnityEvent <OnProcessSingleEvent>k__BackingField;
                /*0x68*/ UnityEngine.Events.UnityEvent <UserInputTriggeredEvent>k__BackingField;
                /*0x70*/ Assets.Battle.Actor <SkillTarget>k__BackingField;
                /*0x78*/ Assets.GameUi.BattleArguments.BattleTutorialTypes <Tutorial>k__BackingField;
                /*0x80*/ long <TotalDamageScore>k__BackingField;
                /*0x88*/ bool <SlowMotionOnBattleEndWasTriggered>k__BackingField;
                /*0x90*/ Assets.Api.Client.PawnId <MvpAttacker>k__BackingField;
                /*0x98*/ Assets.Api.Client.PawnId <MvpDefender>k__BackingField;
                /*0xa0*/ Assets.Api.Client.PawnId <MvpHealer>k__BackingField;
                /*0xa8*/ UnityEngine.Vector3[] <ActorFieldPositions>k__BackingField;
                /*0xb0*/ Assets.Api.Client.MasterDataView <MasterData>k__BackingField;
                /*0xb8*/ int <VictoryAdditionalMoveBackCount>k__BackingField;
                /*0xbc*/ int <LoseAdditionalMoveBackCount>k__BackingField;
                /*0xc0*/ Assets.Api.Client.QuestMaster <QuestMaster>k__BackingField;
                /*0xc8*/ Assets.Api.Client.Mining <Mining>k__BackingField;
                /*0xd0*/ Assets.Api.Client.User <User>k__BackingField;
                /*0xd8*/ Assets.Api.Client.PlayerRankMaster <RankMaster>k__BackingField;
                /*0xe0*/ Assets.Api.Client.BattleOutcome <Outcome>k__BackingField;
                /*0xe4*/ Assets.GameUi.BattleArguments.BattleTypes <BattleType>k__BackingField;
                /*0xe8*/ bool <IsPlayground>k__BackingField;
                /*0xe9*/ bool <IsFirstTurnHappend>k__BackingField;
                /*0xea*/ bool <HasLargeScaleMecanim>k__BackingField;
                /*0xeb*/ bool <DebugMode>k__BackingField;
                /*0xec*/ bool <ShowEnemiesHpValue>k__BackingField;
                /*0xf0*/ Assets.Battle.BattleController.LocalBattleSettings <LocalBattleSettings>k__BackingField;
                /*0xf8*/ bool <SingleExtraSkillPerDayEnabled>k__BackingField;
                /*0x100*/ System.Action <UpdateLocalBattleSettingsCallback>k__BackingField;

                /*0x3d381d8*/ BattleDataStorageModel();
                /*0x3d37fbc*/ UniRx.ReactiveProperty<int> get_BattleSpeed();
                /*0x3d37fc4*/ void set_BattleSpeed(UniRx.ReactiveProperty<int> value);
                /*0x3d37fcc*/ UniRx.ReactiveProperty<float> get_BattlePlaybackSpeed();
                /*0x3d37fd4*/ void set_BattlePlaybackSpeed(UniRx.ReactiveProperty<float> value);
                /*0x3d37fdc*/ UniRx.ReactiveProperty<System.ValueTuple<int, int>> get_Turn();
                /*0x3d37fe4*/ UniRx.ReactiveProperty<string> get_Quest();
                /*0x3d37fec*/ UniRx.ReactiveProperty<bool> get_EnabledStaticCamera();
                /*0x3d37ff4*/ UniRx.ReactiveProperty<bool> get_PauseCurrentEventProcess();
                /*0x3d37ffc*/ UniRx.ReactiveProperty<bool> get_EnableGameNotifications();
                /*0x3d38004*/ UniRx.ReactiveProperty<bool> get_EnabledCockpitView();
                /*0x3d3800c*/ UnityEngine.Events.UnityEvent get_OnSkipCurrentEventProcess();
                /*0x3d38014*/ UnityEngine.Events.UnityEvent get_OnProcessSingleEvent();
                /*0x3d3801c*/ UnityEngine.Events.UnityEvent get_UserInputTriggeredEvent();
                /*0x3d38024*/ Assets.Battle.Actor get_SkillTarget();
                /*0x3d3802c*/ void set_SkillTarget(Assets.Battle.Actor value);
                /*0x3d38034*/ Assets.GameUi.BattleArguments.BattleTutorialTypes get_Tutorial();
                /*0x3d3803c*/ void set_Tutorial(Assets.GameUi.BattleArguments.BattleTutorialTypes value);
                /*0x3d38044*/ long get_TotalDamageScore();
                /*0x3d3804c*/ void set_TotalDamageScore(long value);
                /*0x3d38054*/ bool get_SlowMotionOnBattleEndWasTriggered();
                /*0x3d3805c*/ void set_SlowMotionOnBattleEndWasTriggered(bool value);
                /*0x3d38068*/ Assets.Api.Client.PawnId get_MvpAttacker();
                /*0x3d38070*/ void set_MvpAttacker(Assets.Api.Client.PawnId value);
                /*0x3d38078*/ Assets.Api.Client.PawnId get_MvpDefender();
                /*0x3d38080*/ void set_MvpDefender(Assets.Api.Client.PawnId value);
                /*0x3d38088*/ Assets.Api.Client.PawnId get_MvpHealer();
                /*0x3d38090*/ void set_MvpHealer(Assets.Api.Client.PawnId value);
                /*0x3d38098*/ UnityEngine.Vector3[] get_ActorFieldPositions();
                /*0x3d380a0*/ void set_ActorFieldPositions(UnityEngine.Vector3[] value);
                /*0x3d380a8*/ Assets.Api.Client.MasterDataView get_MasterData();
                /*0x3d380b0*/ void set_MasterData(Assets.Api.Client.MasterDataView value);
                /*0x3d380b8*/ int get_VictoryAdditionalMoveBackCount();
                /*0x3d380c0*/ void set_VictoryAdditionalMoveBackCount(int value);
                /*0x3d380c8*/ int get_LoseAdditionalMoveBackCount();
                /*0x3d380d0*/ void set_LoseAdditionalMoveBackCount(int value);
                /*0x3d380d8*/ Assets.Api.Client.QuestMaster get_QuestMaster();
                /*0x3d380e0*/ void set_QuestMaster(Assets.Api.Client.QuestMaster value);
                /*0x3d380e8*/ Assets.Api.Client.Mining get_Mining();
                /*0x3d380f0*/ void set_Mining(Assets.Api.Client.Mining value);
                /*0x3d380f8*/ Assets.Api.Client.User get_User();
                /*0x3d38100*/ void set_User(Assets.Api.Client.User value);
                /*0x3d38108*/ Assets.Api.Client.PlayerRankMaster get_RankMaster();
                /*0x3d38110*/ void set_RankMaster(Assets.Api.Client.PlayerRankMaster value);
                /*0x3d38118*/ Assets.Api.Client.BattleOutcome get_Outcome();
                /*0x3d38120*/ void set_Outcome(Assets.Api.Client.BattleOutcome value);
                /*0x3d38128*/ Assets.GameUi.BattleArguments.BattleTypes get_BattleType();
                /*0x3d38130*/ void set_BattleType(Assets.GameUi.BattleArguments.BattleTypes value);
                /*0x3d38138*/ bool get_IsPlayground();
                /*0x3d38140*/ void set_IsPlayground(bool value);
                /*0x3d3814c*/ bool get_IsFirstTurnHappend();
                /*0x3d38154*/ void set_IsFirstTurnHappend(bool value);
                /*0x3d38160*/ bool get_HasLargeScaleMecanim();
                /*0x3d38168*/ void set_HasLargeScaleMecanim(bool value);
                /*0x3d38174*/ bool get_DebugMode();
                /*0x3d3817c*/ void set_DebugMode(bool value);
                /*0x3d38188*/ bool get_ShowEnemiesHpValue();
                /*0x3d38190*/ void set_ShowEnemiesHpValue(bool value);
                /*0x3d3819c*/ Assets.Battle.BattleController.LocalBattleSettings get_LocalBattleSettings();
                /*0x3d381a4*/ void set_LocalBattleSettings(Assets.Battle.BattleController.LocalBattleSettings value);
                /*0x3d381ac*/ bool get_SingleExtraSkillPerDayEnabled();
                /*0x3d381b4*/ void set_SingleExtraSkillPerDayEnabled(bool value);
                /*0x3d381c0*/ System.Action get_UpdateLocalBattleSettingsCallback();
                /*0x3d381c8*/ void set_UpdateLocalBattleSettingsCallback(System.Action value);
                /*0x3d388e8*/ void InitializeCameraSettings(bool IsFunctionUnlocked);
                /*0x3d38984*/ void InitializeBattleSpeedSettings(bool IsFunctionUnlocked);
                /*0x3d38a60*/ void InitializeCockpitViewSettings(bool IsFunctionUnlocked);
                /*0x3d38afc*/ void AccelerateBattleSpeed();
                /*0x3d38bb0*/ float SpeedToBattleSpeed(int value);
                /*0x3d38bd4*/ void Dispose();
                /*0x3d38c38*/ bool IsPlayerTeamHasAttributesAdvantages();
                /*0x3d38f80*/ bool IsPlayerTeamHasAttributesAdvantages(Assets.Battle.Actor[] playerActors, Assets.Battle.Actor[] enemyActors);
                /*0x3d38f0c*/ bool IsAttributeIsAdvantageous(Assets.Api.Client.CharacterAttributes attackerAttribute, Assets.Api.Client.CharacterAttributes targetAttribute);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.DataModels.BattleDataStorageModel.<> <>9;
                    static /*0x8*/ System.Action<int> <>9__139_0;
                    static /*0x10*/ System.Action<bool> <>9__139_1;
                    static /*0x18*/ System.Action<bool> <>9__139_2;
                    static /*0x20*/ System.Func<Assets.Api.Client.PawnMasterView, bool> <>9__146_0;
                    static /*0x28*/ System.Func<Assets.Api.Client.PawnMasterView, bool> <>9__146_1;

                    static /*0x3d39260*/ <>c();
                    /*0x3d392c8*/ <>c();
                    /*0x3d392d0*/ void <.ctor>b__139_0(int value);
                    /*0x3d3931c*/ void <.ctor>b__139_1(bool value);
                    /*0x3d39368*/ void <.ctor>b__139_2(bool value);
                    /*0x3d393b4*/ bool <IsPlayerTeamHasAttributesAdvantages>b__146_0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d393e4*/ bool <IsPlayerTeamHasAttributesAdvantages>b__146_1(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass147_0
                {
                    /*0x10*/ Assets.Battle.Actor enemyActor;

                    /*0x3d39250*/ <>c__DisplayClass147_0();
                    /*0x3d39414*/ bool <IsPlayerTeamHasAttributesAdvantages>b__0(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass147_1
                {
                    /*0x10*/ Assets.Battle.Actor playerActor;

                    /*0x3d39258*/ <>c__DisplayClass147_1();
                    /*0x3d39450*/ bool <IsPlayerTeamHasAttributesAdvantages>b__1(Assets.Api.Client.PawnMasterView p);
                }
            }
        }

        namespace Accessors
        {
            class CinemachineLayoutAccessor : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Unity.Cinemachine.CinemachineCamera <FieldCamera>k__BackingField;
                /*0x28*/ Unity.Cinemachine.CinemachineCamera <FieldOverviewCamera>k__BackingField;
                /*0x30*/ Unity.Cinemachine.CinemachineCamera <FieldOverviewCameraWithOffset>k__BackingField;
                /*0x38*/ Unity.Cinemachine.CinemachineCamera <PlayerOverviewCamera>k__BackingField;
                /*0x40*/ Unity.Cinemachine.CinemachineCamera <PlayerOverviewCameraWithOffset>k__BackingField;
                /*0x48*/ Unity.Cinemachine.CinemachineCamera <EnemyOverviewCamera>k__BackingField;
                /*0x50*/ Unity.Cinemachine.CinemachineCamera <EnemyOverviewCameraWithOffset>k__BackingField;
                /*0x58*/ Unity.Cinemachine.CinemachineCamera <FocusCamera>k__BackingField;
                /*0x60*/ Unity.Cinemachine.CinemachineCamera <FocusCameraWithOffset>k__BackingField;
                /*0x68*/ Unity.Cinemachine.CinemachineCamera <TargetFocusCamera>k__BackingField;
                /*0x70*/ Unity.Cinemachine.CinemachineCamera <TargetFocusCameraWithOffset>k__BackingField;
                /*0x78*/ Unity.Cinemachine.CinemachineCamera <GroupFramingCamera>k__BackingField;
                /*0x80*/ Unity.Cinemachine.CinemachineCamera <GroupFramingCameraWithOffset>k__BackingField;
                /*0x88*/ Unity.Cinemachine.CinemachineCamera <FadeCamera>k__BackingField;
                /*0x90*/ UnityEngine.GameObject <CameraFollow>k__BackingField;
                /*0x98*/ UnityEngine.GameObject <CameraLookAt>k__BackingField;
                /*0xa0*/ Assets.Battle.Utilities.PositionFollower <FollowAndLookAtContainer>k__BackingField;
                /*0xa8*/ UnityEngine.GameObject <CameraStaticFollow>k__BackingField;
                /*0xb0*/ UnityEngine.GameObject <CameraStaticLookAt>k__BackingField;
                /*0xb8*/ UnityEngine.GameObject <CameraFocusLookAt>k__BackingField;
                /*0xc0*/ UnityEngine.GameObject <CameraFocusFollow>k__BackingField;
                /*0xc8*/ Unity.Cinemachine.CinemachineTargetGroup <TargetGroup>k__BackingField;

                /*0x3d395ec*/ CinemachineLayoutAccessor();
                /*0x3d3948c*/ Unity.Cinemachine.CinemachineCamera get_FieldCamera();
                /*0x3d39494*/ void set_FieldCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3949c*/ Unity.Cinemachine.CinemachineCamera get_FieldOverviewCamera();
                /*0x3d394a4*/ void set_FieldOverviewCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d394ac*/ Unity.Cinemachine.CinemachineCamera get_FieldOverviewCameraWithOffset();
                /*0x3d394b4*/ void set_FieldOverviewCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d394bc*/ Unity.Cinemachine.CinemachineCamera get_PlayerOverviewCamera();
                /*0x3d394c4*/ void set_PlayerOverviewCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d394cc*/ Unity.Cinemachine.CinemachineCamera get_PlayerOverviewCameraWithOffset();
                /*0x3d394d4*/ void set_PlayerOverviewCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d394dc*/ Unity.Cinemachine.CinemachineCamera get_EnemyOverviewCamera();
                /*0x3d394e4*/ void set_EnemyOverviewCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d394ec*/ Unity.Cinemachine.CinemachineCamera get_EnemyOverviewCameraWithOffset();
                /*0x3d394f4*/ void set_EnemyOverviewCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d394fc*/ Unity.Cinemachine.CinemachineCamera get_FocusCamera();
                /*0x3d39504*/ void set_FocusCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3950c*/ Unity.Cinemachine.CinemachineCamera get_FocusCameraWithOffset();
                /*0x3d39514*/ void set_FocusCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3951c*/ Unity.Cinemachine.CinemachineCamera get_TargetFocusCamera();
                /*0x3d39524*/ void set_TargetFocusCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3952c*/ Unity.Cinemachine.CinemachineCamera get_TargetFocusCameraWithOffset();
                /*0x3d39534*/ void set_TargetFocusCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3953c*/ Unity.Cinemachine.CinemachineCamera get_GroupFramingCamera();
                /*0x3d39544*/ void set_GroupFramingCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3954c*/ Unity.Cinemachine.CinemachineCamera get_GroupFramingCameraWithOffset();
                /*0x3d39554*/ void set_GroupFramingCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3955c*/ Unity.Cinemachine.CinemachineCamera get_FadeCamera();
                /*0x3d39564*/ void set_FadeCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d3956c*/ UnityEngine.GameObject get_CameraFollow();
                /*0x3d39574*/ void set_CameraFollow(UnityEngine.GameObject value);
                /*0x3d3957c*/ UnityEngine.GameObject get_CameraLookAt();
                /*0x3d39584*/ void set_CameraLookAt(UnityEngine.GameObject value);
                /*0x3d3958c*/ Assets.Battle.Utilities.PositionFollower get_FollowAndLookAtContainer();
                /*0x3d39594*/ void set_FollowAndLookAtContainer(Assets.Battle.Utilities.PositionFollower value);
                /*0x3d3959c*/ UnityEngine.GameObject get_CameraStaticFollow();
                /*0x3d395a4*/ void set_CameraStaticFollow(UnityEngine.GameObject value);
                /*0x3d395ac*/ UnityEngine.GameObject get_CameraStaticLookAt();
                /*0x3d395b4*/ void set_CameraStaticLookAt(UnityEngine.GameObject value);
                /*0x3d395bc*/ UnityEngine.GameObject get_CameraFocusLookAt();
                /*0x3d395c4*/ void set_CameraFocusLookAt(UnityEngine.GameObject value);
                /*0x3d395cc*/ UnityEngine.GameObject get_CameraFocusFollow();
                /*0x3d395d4*/ void set_CameraFocusFollow(UnityEngine.GameObject value);
                /*0x3d395dc*/ Unity.Cinemachine.CinemachineTargetGroup get_TargetGroup();
                /*0x3d395e4*/ void set_TargetGroup(Unity.Cinemachine.CinemachineTargetGroup value);
            }

            class LayerOrderAccessor : UnityEngine.MonoBehaviour
            {
                /*0x20*/ int <CameraActiveOrder>k__BackingField;
                /*0x24*/ int <CameraInactiveOrder>k__BackingField;
                /*0x28*/ int <CameraFadeOrder>k__BackingField;
                /*0x2c*/ int <ActionCameraOrder>k__BackingField;
                /*0x30*/ int <StaticCameraOrder>k__BackingField;
                /*0x34*/ int <ActionCameraExtraSkillOrder>k__BackingField;
                /*0x38*/ int <EntranceAnimationCameraOrder>k__BackingField;

                /*0x3d39664*/ LayerOrderAccessor();
                /*0x3d395f4*/ int get_CameraActiveOrder();
                /*0x3d395fc*/ void set_CameraActiveOrder(int value);
                /*0x3d39604*/ int get_CameraInactiveOrder();
                /*0x3d3960c*/ void set_CameraInactiveOrder(int value);
                /*0x3d39614*/ int get_CameraFadeOrder();
                /*0x3d3961c*/ void set_CameraFadeOrder(int value);
                /*0x3d39624*/ int get_ActionCameraOrder();
                /*0x3d3962c*/ void set_ActionCameraOrder(int value);
                /*0x3d39634*/ int get_StaticCameraOrder();
                /*0x3d3963c*/ void set_StaticCameraOrder(int value);
                /*0x3d39644*/ int get_ActionCameraExtraSkillOrder();
                /*0x3d3964c*/ void set_ActionCameraExtraSkillOrder(int value);
                /*0x3d39654*/ int get_EntranceAnimationCameraOrder();
                /*0x3d3965c*/ void set_EntranceAnimationCameraOrder(int value);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> C60ADC589D292B4D32325A49B4AA24F913B4EE4964724940313BF293F137F841;
    static /*0x18*/ <PrivateImplementationDetails> D17CE1865EB1F31B67E3C619556B2615553C6E0C775D337FEA7DE561B83D48C7;
    static /*0x153d*/ <PrivateImplementationDetails> F70A9E94FC9ACDD709B8A3AD59431005E5BCE433BA3912701571CC1F89989441;

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=5413
    {
    }

    struct __StaticArrayInitTypeSize=8374
    {
    }
}
