class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3c94cb0*/ EmbeddedAttribute();
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

                /*0x3c94cb8*/ NullableAttribute(byte );
                /*0x3c94d40*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3c94d70*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c94d98*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c94e8c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        static /*0x3c94e9c*/ GeneratedMessagePackResolver();
        /*0x3c94e94*/ GeneratedMessagePackResolver();
        /*0x380b9e8*/ MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>();

        class FormatterCache<T>
        {
            static /*0x0*/ MessagePack.Formatters.IMessagePackFormatter<T> Formatter;

            static /*0x38358cc*/ FormatterCache();
        }

        class GeneratedMessagePackResolverGetFormatterHelper
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, int> closedTypeLookup;

            static /*0x3c95028*/ GeneratedMessagePackResolverGetFormatterHelper();
            static /*0x3c94f04*/ object GetFormatter(System.Type t);
        }

        class Assets
        {
            /*0x3c95164*/ Assets();

            class Battle
            {
                /*0x3c9516c*/ Battle();

                class BattleController
                {
                    /*0x3c95174*/ BattleController();

                    class LocalBattleSettingsFormatter : MessagePack.Formatters.IMessagePackFormatter<Assets.Battle.BattleController.LocalBattleSettings>, MessagePack.Formatters.IMessagePackFormatter
                    {
                        /*0x3c95020*/ LocalBattleSettingsFormatter();
                        /*0x3c9517c*/ void Serialize(ref MessagePack.MessagePackWriter writer, Assets.Battle.BattleController.LocalBattleSettings value, MessagePack.MessagePackSerializerOptions options);
                        /*0x3c95364*/ Assets.Battle.BattleController.LocalBattleSettings Deserialize(ref MessagePack.MessagePackReader reader, MessagePack.MessagePackSerializerOptions options);
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
        static /*0x3c956f8*/ void RegisterBattleAssemblies(VContainer.IContainerBuilder builder);

        class <>c
        {
            static /*0x0*/ VContainer.BattleContainerBuilderExtension.<> <>9;
            static /*0x8*/ System.Func<System.Type, bool> <>9__0_0;
            static /*0x10*/ System.Func<System.Type, bool> <>9__0_1;
            static /*0x18*/ System.Func<System.Type, bool> <>9__0_2;
            static /*0x20*/ System.Func<System.Type, bool> <>9__0_3;

            static /*0x3c95c48*/ <>c();
            /*0x3c95cb0*/ <>c();
            /*0x3c95cb8*/ bool <RegisterBattleAssemblies>b__0_0(System.Type t);
            /*0x3c95cfc*/ bool <RegisterBattleAssemblies>b__0_1(System.Type t);
            /*0x3c95d60*/ bool <RegisterBattleAssemblies>b__0_2(System.Type t);
            /*0x3c95da4*/ bool <RegisterBattleAssemblies>b__0_3(System.Type t);
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

            /*0x3c96ae8*/ Actor();
            /*0x3c95e88*/ Assets.Api.Client.PawnId get_Id();
            /*0x3c95e90*/ void set_Id(Assets.Api.Client.PawnId value);
            /*0x3c95e98*/ string get_AssetId();
            /*0x3c95ea0*/ void set_AssetId(string value);
            /*0x3c95ea8*/ string get_CockpitId();
            /*0x3c95eb0*/ void set_CockpitId(string value);
            /*0x3c95eb8*/ Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController> get_MecanimReference();
            /*0x3c95ec0*/ void set_MecanimReference(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController> value);
            /*0x3c95ec8*/ bool get_IsEnemyActor();
            /*0x3c95ed0*/ void set_IsEnemyActor(bool value);
            /*0x3c95edc*/ bool get_IsDead();
            /*0x3c95ee4*/ void set_IsDead(bool value);
            /*0x3c95ef0*/ bool get_SustainsControlEffect();
            /*0x3c95ef8*/ void set_SustainsControlEffect(bool value);
            /*0x3c95f04*/ int get_FieldPositionIndex();
            /*0x3c95f0c*/ void set_FieldPositionIndex(int value);
            /*0x3c95f14*/ int get_PositionIndex();
            /*0x3c95f1c*/ void set_PositionIndex(int value);
            /*0x3c95f24*/ float get_CameraFocusDistance();
            /*0x3c95f2c*/ void set_CameraFocusDistance(float value);
            /*0x3c95f34*/ Assets.Battle.Actor.States get_State();
            /*0x3c95f3c*/ void set_State(Assets.Battle.Actor.States value);
            /*0x3c95f44*/ Assets.Battle.Hud.ActorStatusView get_ActorIcon();
            /*0x3c95f4c*/ void set_ActorIcon(Assets.Battle.Hud.ActorStatusView value);
            /*0x3c95f54*/ Assets.Battle.Hud.ActorStatusView get_WorldIcon();
            /*0x3c95f5c*/ void set_WorldIcon(Assets.Battle.Hud.ActorStatusView value);
            /*0x3c95f64*/ Assets.Battle.Hud.ActorStatusIcon get_ActorStatusIcon();
            /*0x3c95f6c*/ void set_ActorStatusIcon(Assets.Battle.Hud.ActorStatusIcon value);
            /*0x3c95f74*/ Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> get_Cockpit();
            /*0x3c95f7c*/ void set_Cockpit(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> value);
            /*0x3c95f84*/ System.Collections.Generic.Dictionary<string, Assets.VisualEffectData.VfxHandler> get_AttachedVfx();
            /*0x3c95f8c*/ void set_AttachedVfx(System.Collections.Generic.Dictionary<string, Assets.VisualEffectData.VfxHandler> value);
            /*0x3c95f94*/ Assets.Api.Client.StatusView get_Status();
            /*0x3c95f9c*/ void set_Status(Assets.Api.Client.StatusView value);
            /*0x3c95fa4*/ bool get_LargeScaleMecanim();
            /*0x3c95fac*/ void set_LargeScaleMecanim(bool value);
            /*0x3c95fb8*/ bool get_VoiceIsPlaying();
            /*0x3c95fc0*/ void set_VoiceIsPlaying(bool value);
            /*0x3c95fcc*/ Assets.Api.Client.CharacterAttributes get_Attribute();
            /*0x3c95fd4*/ void set_Attribute(Assets.Api.Client.CharacterAttributes value);
            /*0x3c95fdc*/ System.Collections.Generic.Dictionary<int, Assets.Api.Client.AuraView> get_AppliedAuras();
            /*0x3c95fe4*/ void UpdateAuraState(ref bool sustainsControlEffectStateChanged);
            /*0x3c962b8*/ void AddBetweenState(Assets.Battle.Actor.States initialState, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3c9648c*/ void AddConflagrationState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverser);
            /*0x3c965b4*/ void RemoveConflagrationState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3c966e4*/ void AddFreezeState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3c96868*/ void RemoveFreezeState(Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer);
            /*0x3c969c0*/ void AddGuardingState();
            /*0x3c96a24*/ void RemoveGuardingState();
            /*0x3c96a98*/ void UpdateHudEmergencyState(Assets.Api.Client.StatusView statusView);
            /*0x3c962a8*/ void UpdateHudControlState(bool sustainsControlEffect);
            /*0x3c96ae0*/ void ResetState();
            /*0x3c965a4*/ void AddState(Assets.Battle.Actor.States state);
            /*0x3c966d4*/ void RemoveState(Assets.Battle.Actor.States state);

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

            /*0x3c98a78*/ BattleComponent();
            /*0x3c96bdc*/ Assets.GameUi.Header.IHeaderComponent get_Header();
            /*0x3c96be4*/ void set_Header(Assets.GameUi.Header.IHeaderComponent value);
            /*0x3c96bf4*/ Assets.GameUi.Externals.IBackgroundManager get_BackgroundManager();
            /*0x3c96bfc*/ void set_BackgroundManager(Assets.GameUi.Externals.IBackgroundManager value);
            /*0x3c96c0c*/ Assets.Battle.ICache get_Cache();
            /*0x3c96c14*/ void set_Cache(Assets.Battle.ICache value);
            /*0x3c96c24*/ Assets.Battle.Utilities.IMetronome get_Metronome();
            /*0x3c96c2c*/ void set_Metronome(Assets.Battle.Utilities.IMetronome value);
            /*0x3c96c3c*/ Assets.GameUi.Externals.IUiLayoutManager get_UiLayoutManager();
            /*0x3c96c44*/ void set_UiLayoutManager(Assets.GameUi.Externals.IUiLayoutManager value);
            /*0x3c96c54*/ Assets.GameUi.Externals.ICameraManager get_CameraManager();
            /*0x3c96c5c*/ void set_CameraManager(Assets.GameUi.Externals.ICameraManager value);
            /*0x3c96c6c*/ Assets.Battle.Overseers.IHudOverseerUnityFacade get_HudOverseerFacade();
            /*0x3c96c74*/ void set_HudOverseerFacade(Assets.Battle.Overseers.IHudOverseerUnityFacade value);
            /*0x3c96c84*/ Assets.Battle.Overseers.ICombatTextOverseerUnityFacade get_CombatTextOverseerFacade();
            /*0x3c96c8c*/ void set_CombatTextOverseerFacade(Assets.Battle.Overseers.ICombatTextOverseerUnityFacade value);
            /*0x3c96c9c*/ Assets.Battle.Overseers.ICameraOverseerUnityFacade get_CameraOverseerFacade();
            /*0x3c96ca4*/ void set_CameraOverseerFacade(Assets.Battle.Overseers.ICameraOverseerUnityFacade value);
            /*0x3c96cb4*/ Assets.Battle.Overseers.IActorOverseerUnityFacade get_ActorOverseerFacade();
            /*0x3c96cbc*/ void set_ActorOverseerFacade(Assets.Battle.Overseers.IActorOverseerUnityFacade value);
            /*0x3c96ccc*/ Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade get_VisualEffectsOverseerFacade();
            /*0x3c96cd4*/ void set_VisualEffectsOverseerFacade(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade value);
            /*0x3c96ce4*/ Assets.Battle.Overseers.ICockpitOverseerUnityFacade get_CockpitOverseerFacade();
            /*0x3c96cec*/ void set_CockpitOverseerFacade(Assets.Battle.Overseers.ICockpitOverseerUnityFacade value);
            /*0x3c96cfc*/ Assets.Battle.Overseers.IFieldOverseerUnityFacade get_FieldOverseerFacade();
            /*0x3c96d04*/ void set_FieldOverseerFacade(Assets.Battle.Overseers.IFieldOverseerUnityFacade value);
            /*0x3c96d14*/ Assets.Battle.Overseers.ITutorialOverseerUnityFacade get_TutorialOverseerFacade();
            /*0x3c96d1c*/ void set_TutorialOverseerFacade(Assets.Battle.Overseers.ITutorialOverseerUnityFacade value);
            /*0x3c96d2c*/ Assets.Battle.Overseers.ILayoutOverseerUnityFacade get_LayoutOverseerFacade();
            /*0x3c96d34*/ void set_LayoutOverseerFacade(Assets.Battle.Overseers.ILayoutOverseerUnityFacade value);
            /*0x3c96d44*/ void Update();
            /*0x3c97c70*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.GameUi.BattleArguments args);
            /*0x3c97d64*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.GameUi.BattleArguments args);
            /*0x3c97e60*/ Cysharp.Threading.Tasks.UniTask ProcessOnComplete();
            /*0x3c97f68*/ void Clear();
            /*0x3c987f0*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
            /*0x3c98980*/ Cysharp.Threading.Tasks.UniTask<Assets.GameUi.BattleArguments> CreateBattleArguments();
            /*0x3c98ba0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_0();
            /*0x3c98ddc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_1();
            /*0x3c98e30*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_2();
            /*0x3c98e90*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_3();
            /*0x3c998a0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_4(Assets.GameUi.Icon.IconBase.IconArgs args);
            /*0x3c999d4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__172_5(Assets.GameUi.Icon.IconBase.IconArgs args);
            /*0x3c99a38*/ void <ProcessOnCreate>b__172_6();
            /*0x3c99c78*/ void <ProcessOnCreate>b__172_7();
            /*0x3c99e04*/ void <ProcessOnCreate>b__172_8();
            /*0x3c99e5c*/ void <ProcessOnCreate>b__172_9();
            /*0x3c99eb4*/ void <ProcessOnCreate>b__172_10();

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

                /*0x3c99f34*/ TipButtonData();
                /*0x3c99f04*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnClickAction();
                /*0x3c99f0c*/ void set_OnClickAction(System.Func<Cysharp.Threading.Tasks.UniTask> value);
                /*0x3c99f14*/ string get_Title();
                /*0x3c99f1c*/ void set_Title(string value);
                /*0x3c99f24*/ string get_ButtonLabel();
                /*0x3c99f2c*/ void set_ButtonLabel(string value);
            }

            class <>c
            {
                static /*0x0*/ Assets.Battle.BattleComponent.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.Transform, UnityEngine.Vector3> <>9__173_0;

                static /*0x3c99f88*/ <>c();
                /*0x3c99ff0*/ <>c();
                /*0x3c99ff8*/ UnityEngine.Vector3 <ProcessOnRestore>b__173_0(UnityEngine.Transform t);
            }

            class <>c__DisplayClass173_0
            {
                /*0x10*/ Assets.Battle.BattleComponent.TipButtonData tip;

                /*0x3c9a010*/ <>c__DisplayClass173_0();
                /*0x3c9a018*/ void <ProcessOnRestore>b__1();
            }

            struct <CreateBattleArguments>d__177 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.GameUi.BattleArguments> <>t__builder;
                /*0x30*/ Assets.Battle.BattleComponent <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.RealBattleResult> <>u__1;

                /*0x3c9a04c*/ void MoveNext();
                /*0x3c9a86c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessOnCreate>d__172 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Battle.BattleComponent <>4__this;
                /*0x38*/ Assets.GameUi.BattleArguments args;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                /*0x3c9a8c4*/ void MoveNext();
                /*0x3c9c1bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessOnRestore>d__173 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Battle.BattleComponent <>4__this;
                /*0x38*/ Assets.GameUi.BattleArguments args;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.GameUi.BattleArguments> <>u__2;

                /*0x3c9c214*/ void MoveNext();
                /*0x3c9ec5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            static /*0x3ca4e2c*/ Assets.GameUi.BattleReport.Tile.Args <OpenBattleReport>g__CreateDataTile|38_8(Assets.Battle.BattleController.BattleReport report, System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x3c9ecb4*/ BattleController(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.GameUi.Externals.ICameraManager cameraManager, Assets.GameUi.Toast.IToastComponent toast, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Api.Client.IApiClient api, Assets.Battle.IEventProcessor eventProcessor, Assets.GameUi.Utilities.IIconDetailNavigator iconDetailNavigator, Assets.GameUi.IGameNotificationsMessageBroker gameNotificationsMessageBroker, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Services.IBattleDebugService battleDebugService, Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer, Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService, Assets.GameUi.Services.ISchoolTacticalExerciseService schoolTacticalExerciseService, Assets.GameUi.Services.ICharacterLimitBreakService characterLimitBreakService, Assets.GameUi.Services.IBgmService bgmService, Assets.GameUi.Services.ICharacterSkillService characterSkillService, Assets.GameUi.Services.IModuleService moduleService, Assets.GameUi.Service.ILevelLinkService levelLinkService, Assets.GameUi.Service.IPartyBuffService partyBuffService, Assets.GameUi.Service.IBadgeService badgeService, Assets.Api.Client.IErrorHandler errorHandler, Assets.GameUi.Services.ICharacterOperatingSystemService characterOperatingSystemService, Assets.Api.Client.FunctionBlocker.IFunctionBlocker functionBlocker, Assets.GameUi.Externals.ILocalSettingsManager localSettingsManager, Assets.Api.Client.Time.IAdjustedTime adjustedTime);
            /*0x3c9a774*/ Cysharp.Threading.Tasks.UniTask<Assets.Api.Client.RealBattleResult> PostBattleStart();
            /*0x3c9f0ac*/ void SkipCurrentEventProcess();
            /*0x3c9f15c*/ void PauseCurrentEventProcess(bool value);
            /*0x3c97b24*/ void ToggleEventProcessPause();
            /*0x3c9f2cc*/ bool IsDebugModeActive();
            /*0x3c9d2b0*/ void UpdateDataModel(Assets.GameUi.BattleArguments arguments);
            /*0x3c982cc*/ void Playback();
            /*0x3c99904*/ Cysharp.Threading.Tasks.UniTask MoveToRewardDetail(Assets.GameUi.Icon.IconBase.IconArgs args);
            /*0x3c98bf4*/ Cysharp.Threading.Tasks.UniTask MoveBack();
            /*0x3ca0224*/ Cysharp.Threading.Tasks.UniTask MoveToHome();
            /*0x3ca0234*/ Cysharp.Threading.Tasks.UniTask MoveToCharacterList();
            /*0x3ca0298*/ Cysharp.Threading.Tasks.UniTask MoveToLevelLink();
            /*0x3c98ee4*/ Cysharp.Threading.Tasks.UniTask OpenBattleReport();
            /*0x3c9f370*/ Assets.Battle.BattleController.BattleReport CreateBattleReport(Assets.Api.Client.IBattleEngineEvent[] events);
            /*0x3ca0340*/ Assets.GameUi.BattleArguments CreateBattleArguments(string data);
            /*0x3ca03ec*/ void ThrowToast(string text);
            /*0x3ca04a0*/ void ThrowTutorialToast(string text);
            /*0x3c99a8c*/ void ThrowSkipLockToast();
            /*0x3c99cd0*/ void ThrowUnlockDescriptionToast(Assets.Api.Client.UnlockFunctionTypes type);
            /*0x3c97a74*/ void HandleUserClickAction();
            /*0x3c977ac*/ void RiseUserClickedEvent();
            /*0x3c9c000*/ void OnToggleBattleUi(System.Action action);
            /*0x3c979c4*/ void HandleSkipAction();
            /*0x3c9e8a4*/ Assets.Battle.BattleComponent.TipButtonData[] CreateTips(Assets.GameUi.BattleArguments arguments);
            /*0x3ca05c4*/ Assets.Battle.BattleComponent.TipButtonData[] CreateTips(Assets.Api.Client.PawnView[] playerPawns);
            /*0x3ca45cc*/ void TryAddRandomTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca4204*/ void TryAddPositionTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, Assets.Api.Client.PawnView[] playerPawns);
            /*0x3ca4088*/ void TryAddAttributesTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca3ae8*/ void TryAddPartyBuffTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters);
            /*0x3ca3830*/ void TryAddMemoriesTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca35b4*/ void TryAddOverLimitTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca32b0*/ void TryAddOperatingSystemTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca2e2c*/ void TryAddGearCustomTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca2b78*/ void TryAddLevelLinkTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters);
            /*0x3ca28fc*/ void TryAddSchoolLevelTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca25e4*/ void TryAddLevelUpAffectionTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca22cc*/ void TryAddLevelUpModulesTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca1fb4*/ void TryAddLevelUpSkillsTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca1a54*/ void TryAddLevelUpTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca173c*/ void TryAddLimitBreakTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips, System.Collections.Generic.List<Assets.Api.Client.Character> playerCharacters, long[] playerCharactersIds);
            /*0x3ca141c*/ void TryAddTacticTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3ca0d80*/ void TryAddMazeTips(System.Collections.Generic.List<Assets.Battle.BattleComponent.TipButtonData> tips);
            /*0x3c97870*/ Cysharp.Threading.Tasks.UniTask TriggerError();
            /*0x3c9785c*/ Cysharp.Threading.Tasks.UniTask Replay();
            /*0x3c9ff48*/ Assets.Battle.BattleController.LocalBattleSettings TryLoadLocalSettings();
            /*0x3ca4c00*/ void TrySaveLocalSettings(Assets.Battle.BattleController.LocalBattleSettings settings);
            /*0x3c9fe9c*/ void UpdateBattleLocalSettings();
            /*0x3ca4d54*/ bool <UpdateDataModel>b__31_0(Assets.Api.Client.PlayerRankMaster m);
            /*0x3ca4e18*/ void <UpdateDataModel>b__31_13();
            /*0x3ca4e1c*/ Assets.GameUi.BattleReport.Tile.Args <OpenBattleReport>b__38_4(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> e);
            /*0x3ca50c4*/ Assets.GameUi.BattleReport.Tile.Args <OpenBattleReport>b__38_6(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> e);
            /*0x3ca50dc*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__51_0();
            /*0x3ca50ec*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__51_1();
            /*0x3ca50fc*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__51_2();
            /*0x3ca5114*/ Cysharp.Threading.Tasks.UniTask <TryAddRandomTips>b__51_3();
            /*0x3ca512c*/ Cysharp.Threading.Tasks.UniTask <TryAddOverLimitTips>b__56_0();
            /*0x3ca513c*/ bool <TryAddLevelLinkTips>b__59_0(Assets.Api.Client.Character c);
            /*0x3ca51e8*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelLinkTips>b__59_1();
            /*0x3ca51f8*/ Cysharp.Threading.Tasks.UniTask <TryAddSchoolLevelTips>b__60_0();
            /*0x3ca5204*/ Cysharp.Threading.Tasks.UniTask <TryAddTacticTips>b__66_0();

            class LocalBattleSettings
            {
                /*0x10*/ System.Collections.Generic.HashSet<string> <CharactersUsedExtraSkill>k__BackingField;
                /*0x18*/ System.DateTime <UsedExtraSkillCreationDate>k__BackingField;

                /*0x3c95640*/ LocalBattleSettings();
                /*0x3ca5218*/ System.Collections.Generic.HashSet<string> get_CharactersUsedExtraSkill();
                /*0x3ca5220*/ void set_CharactersUsedExtraSkill(System.Collections.Generic.HashSet<string> value);
                /*0x3ca5228*/ System.DateTime get_UsedExtraSkillCreationDate();
                /*0x3ca5230*/ void set_UsedExtraSkillCreationDate(System.DateTime value);
            }

            class BattleReport
            {
                /*0x10*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> <Entries>k__BackingField;
                /*0x18*/ long <LargestHealApplied>k__BackingField;
                /*0x20*/ long <LargestDamageApplied>k__BackingField;
                /*0x28*/ long <LargestDamageReceived>k__BackingField;
                /*0x30*/ long <TotalDamageScore>k__BackingField;

                /*0x3ca02a8*/ BattleReport();
                /*0x3ca5238*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> get_Entries();
                /*0x3ca5240*/ long get_LargestHealApplied();
                /*0x3ca5248*/ void set_LargestHealApplied(long value);
                /*0x3ca5250*/ long get_LargestDamageApplied();
                /*0x3ca5258*/ void set_LargestDamageApplied(long value);
                /*0x3ca5260*/ long get_LargestDamageReceived();
                /*0x3ca5268*/ void set_LargestDamageReceived(long value);
                /*0x3ca5270*/ long get_TotalDamageScore();
                /*0x3ca5278*/ void set_TotalDamageScore(long value);

                class BattleReportEntry
                {
                    /*0x10*/ long <DamageApplied>k__BackingField;
                    /*0x18*/ long <DamageReceived>k__BackingField;
                    /*0x20*/ long <HealApplied>k__BackingField;
                    /*0x28*/ bool <IsEnemyPawn>k__BackingField;
                    /*0x29*/ bool <HasDied>k__BackingField;

                    /*0x3ca0338*/ BattleReportEntry();
                    /*0x3ca5280*/ long get_DamageApplied();
                    /*0x3ca5288*/ void set_DamageApplied(long value);
                    /*0x3ca5290*/ long get_DamageReceived();
                    /*0x3ca5298*/ void set_DamageReceived(long value);
                    /*0x3ca52a0*/ long get_HealApplied();
                    /*0x3ca52a8*/ void set_HealApplied(long value);
                    /*0x3ca52b0*/ bool get_IsEnemyPawn();
                    /*0x3ca52b8*/ void set_IsEnemyPawn(bool value);
                    /*0x3ca52c4*/ bool get_HasDied();
                    /*0x3ca52cc*/ void set_HasDied(bool value);
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
                static /*0x70*/ System.Func<Assets.Battle.BattleController.BattleReport.BattleReportEntry, long> <>9__38_0;
                static /*0x78*/ System.Func<Assets.Battle.BattleController.BattleReport.BattleReportEntry, long> <>9__38_1;
                static /*0x80*/ System.Func<Assets.Battle.BattleController.BattleReport.BattleReportEntry, long> <>9__38_2;
                static /*0x88*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__38_3;
                static /*0x90*/ System.Func<System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry>, bool> <>9__38_5;
                static /*0x98*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__38_7;
                static /*0xa0*/ System.Func<Assets.Api.Client.Character, long> <>9__50_0;
                static /*0xa8*/ System.Func<Assets.Battle.BattleComponent.TipButtonData, int, string> <>9__50_1;
                static /*0xb0*/ System.Func<Assets.Api.Client.Character, long> <>9__54_0;
                static /*0xb8*/ System.Func<Assets.Api.Client.PartyBonusMaster, bool> <>9__54_1;
                static /*0xc0*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__57_2;
                static /*0xc8*/ System.Func<Assets.Api.Client.Item, bool> <>9__58_0;
                static /*0xd0*/ System.Func<Assets.Api.Client.Item, bool> <>9__58_1;
                static /*0xd8*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__58_3;
                static /*0xe0*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__62_2;
                static /*0xe8*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__63_2;
                static /*0xf0*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__64_3;
                static /*0xf8*/ System.Func<Assets.Api.Client.Item, bool> <>9__64_1;
                static /*0x100*/ System.Func<long, Assets.GameUi.CharacterDetail.CharacterDetailEntity> <>9__65_2;

                static /*0x3ca52d8*/ <>c();
                /*0x3ca5340*/ <>c();
                /*0x3ca5348*/ bool <UpdateDataModel>b__31_1(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5394*/ long <UpdateDataModel>b__31_2(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca53d8*/ bool <UpdateDataModel>b__31_3(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5424*/ Assets.Api.Client.PawnId <UpdateDataModel>b__31_4(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5460*/ bool <UpdateDataModel>b__31_5(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca54ac*/ long <UpdateDataModel>b__31_6(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca54f0*/ bool <UpdateDataModel>b__31_7(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca553c*/ Assets.Api.Client.PawnId <UpdateDataModel>b__31_8(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5578*/ bool <UpdateDataModel>b__31_9(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca55c4*/ long <UpdateDataModel>b__31_10(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5608*/ bool <UpdateDataModel>b__31_11(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5654*/ Assets.Api.Client.PawnId <UpdateDataModel>b__31_12(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca5690*/ bool <Playback>b__32_0(Assets.Api.Client.IBattleEngineEvent e);
                /*0x3ca5708*/ long <OpenBattleReport>b__38_0(Assets.Battle.BattleController.BattleReport.BattleReportEntry entry);
                /*0x3ca5720*/ long <OpenBattleReport>b__38_1(Assets.Battle.BattleController.BattleReport.BattleReportEntry entry);
                /*0x3ca5738*/ long <OpenBattleReport>b__38_2(Assets.Battle.BattleController.BattleReport.BattleReportEntry entry);
                /*0x3ca5750*/ bool <OpenBattleReport>b__38_3(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca579c*/ bool <OpenBattleReport>b__38_5(System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry);
                /*0x3ca57e0*/ bool <OpenBattleReport>b__38_7(Assets.Api.Client.IBattleEngineEvent entry);
                /*0x3ca5858*/ long <CreateTips>b__50_0(Assets.Api.Client.Character c);
                /*0x3ca5870*/ string <CreateTips>b__50_1(Assets.Battle.BattleComponent.TipButtonData t, int i);
                /*0x3ca593c*/ long <TryAddPartyBuffTips>b__54_0(Assets.Api.Client.Character c);
                /*0x3ca5954*/ bool <TryAddPartyBuffTips>b__54_1(Assets.Api.Client.PartyBonusMaster m);
                /*0x3ca5974*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddOperatingSystemTips>b__57_2(long id);
                /*0x3ca5a14*/ bool <TryAddGearCustomTips>b__58_0(Assets.Api.Client.Item i);
                /*0x3ca5a44*/ bool <TryAddGearCustomTips>b__58_1(Assets.Api.Client.Item i);
                /*0x3ca5a64*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddGearCustomTips>b__58_3(long id);
                /*0x3ca5b04*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLevelUpModulesTips>b__62_2(long id);
                /*0x3ca5ba4*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLevelUpSkillsTips>b__63_2(long id);
                /*0x3ca5c44*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLevelUpTips>b__64_3(long id);
                /*0x3ca5ce4*/ bool <TryAddLevelUpTips>b__64_1(Assets.Api.Client.Item i);
                /*0x3ca5d24*/ Assets.GameUi.CharacterDetail.CharacterDetailEntity <TryAddLimitBreakTips>b__65_2(long id);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ Assets.GameUi.IGameNotificationsMessageBroker gameNotificationsMessageBroker;

                /*0x3c9f0a4*/ <>c__DisplayClass25_0();
                /*0x3ca5dc4*/ void <.ctor>b__0(bool value);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ System.Collections.Generic.KeyValuePair<Assets.Api.Client.PawnId, Assets.Battle.BattleController.BattleReport.BattleReportEntry> entry;

                /*0x3ca50d4*/ <>c__DisplayClass38_0();
                /*0x3ca5eac*/ bool <OpenBattleReport>b__9(Assets.Api.Client.PawnMasterView s);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ Assets.Api.Client.PawnSpawnedEvent spawnEvent;
                /*0x18*/ Assets.Api.Client.PawnReceivedDamageEvent damageEvent;
                /*0x20*/ Assets.Api.Client.PawnReceivedHealingEvent healingEvent;
                /*0x28*/ Assets.Api.Client.PawnDiedEvent diedEvent;

                /*0x3ca0330*/ <>c__DisplayClass39_0();
                /*0x3ca5f10*/ bool <CreateBattleReport>b__0(Assets.Api.Client.PawnMasterView s);
                /*0x3ca5f54*/ bool <CreateBattleReport>b__1(Assets.Api.Client.PawnMasterView s);
                /*0x3ca5f98*/ bool <CreateBattleReport>b__2(Assets.Api.Client.PawnMasterView s);
                /*0x3ca5fdc*/ bool <CreateBattleReport>b__3(Assets.Api.Client.PawnMasterView s);
                /*0x3ca6020*/ bool <CreateBattleReport>b__4(Assets.Api.Client.PawnMasterView s);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ System.Action action;

                /*0x3ca05bc*/ <>c__DisplayClass47_0();
                /*0x3ca6064*/ void <OnToggleBattleUi>b__0();
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ Assets.Api.Client.PawnView item;

                /*0x3ca4bb0*/ <>c__DisplayClass52_0();
                /*0x3ca6088*/ bool <TryAddPositionTips>b__0(Assets.Api.Client.PawnMasterView p);
            }

            class <>c__DisplayClass54_0
            {
                /*0x10*/ Assets.GameUi.Service.PartyBuffRetrieveResult partyBuff;

                /*0x3ca4bb8*/ <>c__DisplayClass54_0();
                /*0x3ca60b0*/ bool <TryAddPartyBuffTips>b__2(Assets.Api.Client.PartyBonusDetailMaster m);
            }

            class <>c__DisplayClass57_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;

                /*0x3ca4bc0*/ <>c__DisplayClass57_0();
                /*0x3ca6128*/ bool <TryAddOperatingSystemTips>b__0(Assets.Api.Client.Character c);
                /*0x3ca61d8*/ Cysharp.Threading.Tasks.UniTask <TryAddOperatingSystemTips>b__1();
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;

                /*0x3ca4bc8*/ <>c__DisplayClass58_0();
                /*0x3ca63f0*/ Cysharp.Threading.Tasks.UniTask <TryAddGearCustomTips>b__2();
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ Assets.Api.Client.Character canLevelUpAffection;
                /*0x20*/ long[] playerCharactersIds;

                /*0x3ca4bd0*/ <>c__DisplayClass61_0();
                /*0x3ca6608*/ bool <TryAddLevelUpAffectionTips>b__0(Assets.Api.Client.Character c);
                /*0x3ca66bc*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpAffectionTips>b__1();
            }

            class <>c__DisplayClass62_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLevelUpModules;

                /*0x3ca4bd8*/ <>c__DisplayClass62_0();
                /*0x3ca6750*/ bool <TryAddLevelUpModulesTips>b__0(Assets.Api.Client.Character c);
                /*0x3ca6804*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpModulesTips>b__1();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLevelUpSkills;

                /*0x3ca4be0*/ <>c__DisplayClass63_0();
                /*0x3ca6a4c*/ bool <TryAddLevelUpSkillsTips>b__0(Assets.Api.Client.Character c);
                /*0x3ca6b00*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpSkillsTips>b__1();
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLevelUp;

                /*0x3ca4be8*/ <>c__DisplayClass64_0();
                /*0x3ca6d48*/ bool <TryAddLevelUpTips>b__0(Assets.Api.Client.Character c);
                /*0x3ca6df8*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpTips>b__2();
                /*0x3ca7040*/ Cysharp.Threading.Tasks.UniTask <TryAddLevelUpTips>b__4();
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ long[] playerCharactersIds;
                /*0x20*/ Assets.Api.Client.Character canLimitBreak;

                /*0x3ca4bf0*/ <>c__DisplayClass65_0();
                /*0x3ca7064*/ bool <TryAddLimitBreakTips>b__0(Assets.Api.Client.Character c);
                /*0x3ca7118*/ Cysharp.Threading.Tasks.UniTask <TryAddLimitBreakTips>b__1();
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ Assets.Battle.BattleController <>4__this;
                /*0x18*/ Assets.Api.Client.MazeLevelMaster levelMaster;

                /*0x3ca4bf8*/ <>c__DisplayClass67_0();
                /*0x3ca7364*/ Cysharp.Threading.Tasks.UniTask <TryAddMazeTips>b__1();
                /*0x3ca738c*/ bool <TryAddMazeTips>b__0(Assets.Api.Client.TypeEquipment e);
                /*0x3ca73b8*/ Cysharp.Threading.Tasks.UniTask <TryAddMazeTips>b__2();
            }

            struct <MoveToRewardDetail>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.GameUi.Icon.IconBase.IconArgs args;
                /*0x30*/ Assets.Battle.BattleController <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3ca73e0*/ void MoveNext();
                /*0x3ca7fc4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostBattleStart>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Api.Client.RealBattleResult> <>t__builder;
                /*0x30*/ Assets.Battle.BattleController <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.RealBattleResult>> <>u__1;

                /*0x3ca7fd0*/ void MoveNext();
                /*0x3ca86f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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
            /*0x380d93c*/ void TryRegisterPrefabToCache(string key, UnityEngine.GameObject prefab);
            Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAcquireVfxAnimationHandler(string key, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.SkeletonController> TryAcquireSkeletonController(string key, UnityEngine.Transform parent);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> TryAcquireComponent<T>(string key, UnityEngine.Transform parent);
            /*0x380cb08*/ void Clear();
        }

        class Cache : Assets.Battle.ICache
        {
            /*0x10*/ Assets.AssetManagement.IAssetInstanceProvider assetInstanceProvider;
            /*0x18*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.GameObject>> objectCache;
            /*0x20*/ System.Collections.Generic.Dictionary<string, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> preloadTasks;
            /*0x28*/ System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> registeredPrefabs;
            /*0x30*/ object locked;

            /*0x3ca8750*/ Cache(Assets.AssetManagement.IAssetInstanceProvider assetInstanceProvider);
            /*0x3ca88d4*/ void Clear();
            /*0x3ca8b5c*/ void TryRegisterPrefabToCache(string key, UnityEngine.GameObject prefab);
            /*0x3ca8cd4*/ Cysharp.Threading.Tasks.UniTask Preload(string[] keys);
            /*0x3ca8da4*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAcquireVfxAnimationHandler(string key, UnityEngine.Transform parent);
            /*0x3ca8e2c*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAcquireVfxHandler(string key, UnityEngine.Transform parent);
            /*0x3ca8eb4*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAcquireMecanimController(string key, UnityEngine.Transform parent);
            /*0x3ca8f3c*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.SkeletonController> TryAcquireSkeletonController(string key, UnityEngine.Transform parent);
            /*0x3ca8fc4*/ Cysharp.Threading.Tasks.UniTask<Unity.Cinemachine.CinemachineCamera> TryAcquireCinemachineVirtualCamera(string key, UnityEngine.Transform parent);
            /*0x3ca904c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.SpriteRenderer> TryAcquireSpriteRenderer(string key, UnityEngine.Transform parent);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> TryAcquireComponent<T>(string key, UnityEngine.Transform parent);
            /*0x3ca90d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAcquireGameObject(string key, UnityEngine.Transform parent);

            class <>c__DisplayClass16_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> task;

                /*0x3ca9210*/ <>c__DisplayClass16_0();
                /*0x3ca9218*/ bool <TryAcquireGameObject>b__0();
            }

            struct <Preload>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Battle.Cache <>4__this;
                /*0x30*/ string[] keys;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3ca92f0*/ void MoveNext();
                /*0x3ca9c00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryAcquireComponent>d__15<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.Battle.Cache <>4__this;
                /*0x0*/ string key;
                /*0x0*/ UnityEngine.Transform parent;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3ca9c0c*/ void MoveNext();
                /*0x3caabf0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            static /*0x3caac48*/ Constants();
        }

        interface IEventProcessor
        {
            /*0x380b9e8*/ System.Threading.CancellationTokenSource get_ActiveProcessCancellationTokenSource();
            Cysharp.Threading.Tasks.UniTask ProcessEvent(Assets.Api.Client.IBattleEngineEvent battleEvent);
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask ProcessEvents();
            /*0x380d83c*/ void RecordEvents(Assets.Api.Client.IBattleEngineEvent[] events);
            /*0x380ca18*/ Cysharp.Threading.Tasks.UniTask TryProcessUntilTickChanged(int tick);
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

            /*0x3caae88*/ EventProcessor(Assets.Battle.Directors.IPawnSpawnedEventDirector pawnSpawnedEventDirector, Assets.Battle.Directors.IPawnUsesSkillEventDirector pawnUsesSkillEventDirector, Assets.Battle.Directors.IManeuverOrderUpdatedEventDirector maneuverOrderUpdatedEventDirector, Assets.Battle.Directors.IMasterDataUpdatedEventDirector masterDataUpdatedEventDirector, Assets.Battle.Directors.IWaveStartedEventDirector waveStartedEventDirector, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Directors.IPawnReceivedDamageEventDirector pawnReceivedDamageEventDirector, Assets.Battle.Directors.ITurnStartedEventDirector turnStartedEventDirector, Assets.Battle.Directors.IPawnDiedEventDirector pawnDiedEventDirector, Assets.Battle.Directors.IBattleEndedEventDirector battleEndedEventDirector, Assets.Battle.Directors.IPawnReceivedVfxEventDirector pawnReceivedVfxEventDirector, Assets.Battle.Directors.IPawnReceivedHealingEventDirector pawnReceivedHealingEventDirector, Assets.Battle.Directors.IPawnResourcesUpdatedEventDirector pawnResourcesUpdatedEventDirector, Assets.Battle.Directors.IPawnPreparesSkillEventDirector pawnPreparesSkillEventDirector, Assets.Battle.Directors.IPawnsAreTargetedEventDirector pawnsAreTargetedEventDirector, Assets.Battle.Directors.IBattleStartedEventDirector battleStartedEventDirector, Assets.Battle.Directors.IPawnChargesSkillEventDirector pawnChargesSkillEventDirector, Assets.Battle.Directors.IPawnStoppedChargingSkillEventDirector pawnStoppedChargingSkillEventDirector, Assets.Battle.Directors.IPawnSkippedManeuverEventDirector pawnSkippedManeuverEventDirector, Assets.Battle.Directors.ITutorialMessageEventDirector tutorialMessageEventDirector, Assets.Battle.Directors.IPawnAuraAddedEventDirector pawnAuraAddedEventDirector, Assets.Battle.Directors.IPawnAuraRemovedEventDirector pawnAuraRemovedEventDirector, Assets.Battle.Directors.IPawnUsedSkillEventDirector pawnUsedSkillEventDirector, Assets.Battle.Directors.IPawnAuraUpdatedEventDirector pawnAuraUpdatedEventDirector);
            /*0x3caae78*/ System.Threading.CancellationTokenSource get_ActiveProcessCancellationTokenSource();
            /*0x3caae80*/ void set_ActiveProcessCancellationTokenSource(System.Threading.CancellationTokenSource value);
            /*0x3cab84c*/ void Dispose();
            /*0x3cab968*/ void OnSkipCurrentEventProcess();
            /*0x3cab974*/ void RecordEvents(Assets.Api.Client.IBattleEngineEvent[] events);
            /*0x3caba64*/ Cysharp.Threading.Tasks.UniTask ProcessEvents();
            /*0x3cabb14*/ Cysharp.Threading.Tasks.UniTask ProcessEvent(Assets.Api.Client.IBattleEngineEvent battleEvent);
            /*0x3cac0a0*/ Cysharp.Threading.Tasks.UniTask TryProcessUntilTickChanged(int tick);
            /*0x3cac158*/ void <.ctor>b__11_0(bool value);
            /*0x3cac164*/ void <.ctor>b__11_1();

            struct <<-ctor>b__11_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                /*0x38*/ Assets.Battle.EventProcessor <>4__this;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cac214*/ void MoveNext();
                /*0x3cac598*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessEvents>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Battle.EventProcessor <>4__this;
                /*0x30*/ System.Threading.CancellationToken <cancellationToken>5__2;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cac5a4*/ void MoveNext();
                /*0x3cace20*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <TryProcessUntilTickChanged>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Battle.EventProcessor <>4__this;
                /*0x30*/ int tick;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3cace2c*/ void MoveNext();
                /*0x3cad490*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class Math
        {
            static /*0x3cad49c*/ UnityEngine.Vector3 CalculatePerpendicularPoint(UnityEngine.Vector3 origin, UnityEngine.Vector3 target, float distance, float perpendicularDistance);
            static /*0x3cad708*/ UnityEngine.Vector3 CalculateFiniteCentroid(UnityEngine.Vector3[] points);
            static /*0x3cad814*/ bool ShouldIDoIt(float percentage);
            /*0x3cad83c*/ Math();
        }

        class DeactivateWhenNoActive : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.ParticleSystem component;

            /*0x3cad8e4*/ DeactivateWhenNoActive();
            /*0x3cad844*/ void Awake();
            /*0x3cad89c*/ void Update();
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

                /*0x3cad944*/ ColorData();
                /*0x3cad8ec*/ UnityEngine.Color get_Color();
                /*0x3cad8f8*/ void set_Color(UnityEngine.Color value);
                /*0x3cad904*/ DG.Tweening.Ease get_EaseIn();
                /*0x3cad90c*/ void set_EaseIn(DG.Tweening.Ease value);
                /*0x3cad914*/ DG.Tweening.Ease get_EaseOut();
                /*0x3cad91c*/ void set_EaseOut(DG.Tweening.Ease value);
                /*0x3cad924*/ float get_DurationIn();
                /*0x3cad92c*/ void set_DurationIn(float value);
                /*0x3cad934*/ float get_DurationOut();
                /*0x3cad93c*/ void set_DurationOut(float value);
            }

            class ColorSycle : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image image;
                /*0x28*/ UnityEngine.Color[] colors;
                /*0x30*/ int index;

                /*0x3cada68*/ ColorSycle();
                /*0x3cad95c*/ void OnEnabled();
                /*0x3cad99c*/ void Set(int index);
                /*0x3cada00*/ void Sycle();
            }

            class FunctionDebug : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Actor target;

                /*0x3cadad0*/ FunctionDebug();
                /*0x3cada70*/ void Update();
            }

            class MaterialComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.Material>
            {
                static /*0x0*/ Assets.Battle.Utilities.MaterialComparer Default;

                static /*0x3cadb58*/ MaterialComparer();
                /*0x3cadb50*/ MaterialComparer();
                /*0x3cadad8*/ bool Equals(UnityEngine.Material x, UnityEngine.Material y);
                /*0x3cadb24*/ int GetHashCode(UnityEngine.Material obj);
            }

            interface IMetronome
            {
                /*0x380c2e4*/ float get_BPM();
                /*0x380e050*/ void set_BPM(float value);
                /*0x380c2e4*/ float get_Interval();
                /*0x380b9e8*/ UnityEngine.Events.UnityEvent get_OnBeatEvent();
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AwaitForMetronomeBeat();
                bool Update(float deltaTime);
            }

            class Metronome : Assets.Battle.Utilities.IMetronome
            {
                /*0x10*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTaskCompletionSource> completionSources;
                /*0x18*/ float bpm;
                /*0x1c*/ float interval;
                /*0x20*/ float time;
                /*0x28*/ UnityEngine.Events.UnityEvent <OnBeatEvent>k__BackingField;

                /*0x3cadc0c*/ Metronome();
                /*0x3cadbc0*/ float get_BPM();
                /*0x3cadbc8*/ void set_BPM(float value);
                /*0x3cadbfc*/ float get_Interval();
                /*0x3cadc04*/ UnityEngine.Events.UnityEvent get_OnBeatEvent();
                /*0x3cadd44*/ Cysharp.Threading.Tasks.UniTask AwaitForMetronomeBeat();
                /*0x3cade20*/ void CompleteBeat();
                /*0x3cae09c*/ bool Update(float deltaTime);
                /*0x3cae0ec*/ void <.ctor>b__12_0();
            }

            class PositionFollower : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform <Target>k__BackingField;
                /*0x28*/ UnityEngine.Vector3 <Offset>k__BackingField;

                /*0x3cae1d4*/ PositionFollower();
                /*0x3cae0f0*/ UnityEngine.Transform get_Target();
                /*0x3cae0f8*/ void set_Target(UnityEngine.Transform value);
                /*0x3cae100*/ UnityEngine.Vector3 get_Offset();
                /*0x3cae10c*/ void set_Offset(UnityEngine.Vector3 value);
                /*0x3cae118*/ void Update();
            }

            class PunchData
            {
                /*0x10*/ UnityEngine.Vector3 <Vector>k__BackingField;
                /*0x1c*/ float <Duration>k__BackingField;
                /*0x20*/ int <Vibrato>k__BackingField;
                /*0x24*/ float <Elasticity>k__BackingField;
                /*0x28*/ bool <Snapping>k__BackingField;

                /*0x3cae290*/ PunchData();
                /*0x3cae234*/ UnityEngine.Vector3 get_Vector();
                /*0x3cae240*/ void set_Vector(UnityEngine.Vector3 value);
                /*0x3cae24c*/ float get_Duration();
                /*0x3cae254*/ void set_Duration(float value);
                /*0x3cae25c*/ int get_Vibrato();
                /*0x3cae264*/ void set_Vibrato(int value);
                /*0x3cae26c*/ float get_Elasticity();
                /*0x3cae274*/ void set_Elasticity(float value);
                /*0x3cae27c*/ bool get_Snapping();
                /*0x3cae284*/ void set_Snapping(bool value);
            }

            class SpriteCycle : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image image;
                /*0x28*/ UnityEngine.Sprite[] sprites;
                /*0x30*/ int index;

                /*0x3cae390*/ SpriteCycle();
                /*0x3cae2b0*/ void OnEnabled();
                /*0x3cae2e4*/ void Set(int index);
                /*0x3cae338*/ void Sycle();
            }

            class UtilityFunctions
            {
                static /*0x3cae398*/ float CalculateFocusCameraYOffset(float distanceFromGround);
                static /*0x38301ec*/ T[] GetRandomElements<T>(T[] array, int count);
                static /*0x3cae3c8*/ Cysharp.Threading.Tasks.UniTask UpdateTeamHealthGauge(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer);
                static /*0x3cabffc*/ void Log(string message);
                static /*0x3ca4b54*/ void Log(string[] message);

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

                    static /*0x3caeac8*/ <>c();
                    /*0x3caeb30*/ <>c();
                    /*0x3caeb38*/ bool <UpdateTeamHealthGauge>b__2_0(Assets.Battle.Actor a);
                    /*0x3caeb58*/ long <UpdateTeamHealthGauge>b__2_1(Assets.Battle.Actor a);
                    /*0x3caeb78*/ bool <UpdateTeamHealthGauge>b__2_2(Assets.Battle.Actor a);
                    /*0x3caeb98*/ long <UpdateTeamHealthGauge>b__2_3(Assets.Battle.Actor a);
                    /*0x3caebb8*/ bool <UpdateTeamHealthGauge>b__2_4(Assets.Battle.Actor a);
                    /*0x3caebd8*/ long <UpdateTeamHealthGauge>b__2_5(Assets.Battle.Actor a);
                    /*0x3caebf8*/ bool <UpdateTeamHealthGauge>b__2_6(Assets.Battle.Actor a);
                    /*0x3caec18*/ long <UpdateTeamHealthGauge>b__2_7(Assets.Battle.Actor a);
                }

                class <>c__<T>
                {
                    static /*0x0*/ Assets.Battle.Utilities.UtilityFunctions.<>c__1<T> <>9;
                    static /*0x0*/ System.Func<T, System.Guid> <>9__1_0;

                    static /*0x38358cc*/ <>c__();
                    /*0x380cb08*/ <>c__();
                    /*0x3907c14*/ System.Guid <GetRandomElements>b__1_0(T x);
                }
            }

            class YHardLook : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform LookAt;
                /*0x28*/ UnityEngine.Vector3 currentRotationVector;

                /*0x3caee6c*/ YHardLook();
                /*0x3caec38*/ void Update();
            }

            class YHardRotation : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.Transform LookAt;

                /*0x3caf038*/ YHardRotation();
                /*0x3caeecc*/ void Update();
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

                /*0x3caf2ac*/ TestMath();
                /*0x3caf040*/ void Update();
                /*0x3caf12c*/ void PlaybackAnimationSequence();
            }
        }

        namespace Shared
        {
            interface ISharedBattleDataStorageModel
            {
                /*0x380b9e8*/ UniRx.ReactiveProperty<float> get_BattlePlaybackSpeed();
                /*0x380b128*/ bool get_IsPlayground();
                /*0x380cdf0*/ void set_IsPlayground(bool value);
                /*0x380b128*/ bool get_HasLargeScaleMecanim();
                /*0x380cdf0*/ void set_HasLargeScaleMecanim(bool value);
                /*0x380b9e8*/ UnityEngine.Vector3[] get_ActorFieldPositions();
                /*0x380d83c*/ void set_ActorFieldPositions(UnityEngine.Vector3[] value);
                /*0x380b9e8*/ UniRx.ReactiveProperty<bool> get_EnabledCockpitView();
            }

            interface ISharedCameraOverseer
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ICameraOverseerUnityFacade.Arguments arguments);
                /*0x380d83c*/ void SetFollowTarget(UnityEngine.Transform target);
                /*0x380e380*/ void SetFollowPosition(UnityEngine.Vector3 position);
                /*0x380e380*/ void SetLookAtPosition(UnityEngine.Vector3 position);
                /*0x380e380*/ void SetFocusLookAtPosition(UnityEngine.Vector3 position);
                /*0x380e050*/ void ConfigureBlendCamera(float duration);
                /*0x380cb08*/ void ConfigureCutBlendCamera();
                /*0x380cffc*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x380cb08*/ void EnablePostProcessing();
                /*0x380cb08*/ void DisablePostProcessing();
                Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters);
                Cysharp.Threading.Tasks.UniTask TryEnableActionCamera(string key, bool isEnemyActor, bool isExtraSkill);
                /*0x380cb08*/ void TryDisableActionCamera();
                /*0x380cb08*/ void DetatchFollowAndLook();
                /*0x380cb08*/ void ReattachFollowAndLook();
                /*0x380cb08*/ void TransitionToActiveCameraType();
                /*0x380e380*/ void SetFocusFollowPosition(UnityEngine.Vector3 position);
                /*0x380d83c*/ void AddToTargetGroup(UnityEngine.Transform[] targets);
                /*0x380d83c*/ void AddToTargetGroup(UnityEngine.Transform target);
                /*0x380cb08*/ void ClearTargetGroup();
                /*0x380cdf0*/ void SetCameraOffset(bool value);
                /*0x380b128*/ bool GetCameraOffset();
                /*0x380e050*/ void SetCameraFocusDistance(float value);
                /*0x380e050*/ void SetCameraFocusYOffset(float value);
                /*0x380e050*/ void SetCameraTargetFocusDistance(float value);
                /*0x380e050*/ void SetCameraTargetFocusYOffset(float value);
                /*0x380e380*/ void SetLookAtStaticPosition(UnityEngine.Vector3 position);
                /*0x380e380*/ void SetFollowStaticPosition(UnityEngine.Vector3 position);
            }

            interface ISharedCockpitOverseer
            {
                /*0x380cb08*/ void ForceHideMinimizedCockpit();
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ICockpitOverseerUnityFacade.Arguments arguments);
                /*0x380d83c*/ void ShowMinimizedCockpit(Assets.Utilities.Spine.SkeletonController cockpit);
            }

            interface ISharedFieldOverseer
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IFieldOverseerUnityFacade.Arguments arguments);
                /*0x380cad0*/ UnityEngine.Vector3 AcquireFieldCenterPosition();
                UnityEngine.Vector3 AcquireGroupCenterPosition(bool isEnemyGroup);
                Cysharp.Threading.Tasks.UniTask LoadField(string configurationJson);
                /*0x380cdf0*/ void SetActive(bool active);
                /*0x380b9e8*/ UnityEngine.Material[] AcquireFieldMaterials();
            }

            interface ISharedHudOverseer
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x380cdf0*/ void SetIntractability(bool interactable);
            }

            interface ISharedVisualEffectsOverseer
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade.Arguments arguments);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(Assets.VisualEffectData.VfxHandler prefab, UnityEngine.Vector3 position);
                Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAquireMecanimController(string key);
                /*0x380d83c*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                /*0x380d83c*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                Cysharp.Threading.Tasks.UniTask PlaybackTimeStop(Assets.VisualEffectData.TimeStopParameters parameters);
                /*0x380d83c*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x380cb08*/ void ClearFieldMaterials();
                void AddActorRenderer(long id, UnityEngine.Renderer target);
                /*0x380d438*/ void RemoveActorRenderer(long id);
                /*0x380cb08*/ void Update();
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

                /*0x3caf2e8*/ SharedActor(Assets.Utilities.Spine.MecanimController mecanimController, int fieldIndex, float cameraFocusDistance);
                /*0x3caf2d0*/ Assets.Utilities.Spine.MecanimController get_MecanimController();
                /*0x3caf2d8*/ int get_FieldIndex();
                /*0x3caf2e0*/ float get_CameraFocusDistance();
            }

            interface ISkillMotionOverseer
            {
                UnityEngine.Vector3 CalculateFocusTarget(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 actorPosition, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                UnityEngine.Vector3[] CalculateTargetsPositions(Assets.VisualEffectData.VfxHandler vfx, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                /*0x380bc30*/ System.Collections.Generic.IAsyncEnumerable<string> MotionEvents(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
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

                static /*0x3caf68c*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes <AcquireTargetFocusCameraType>g__SelectCameraType|10_0(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                static /*0x3caf9e4*/ UnityEngine.Vector3 <CalculateFocusTarget>g__GetPosition|12_1(Assets.Battle.Shared.SharedActor data, Assets.Battle.Shared.ISharedBattleDataStorageModel model);
                static /*0x3cb0ee4*/ void <MotionEvents>g__Continue|19_3(string key, System.Collections.Generic.Queue<string> queue, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                static /*0x3cb0f58*/ void <MotionEvents>g__End|19_4(System.Threading.CancellationTokenSource cancellationTokenSource, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3caf334*/ SharedSkillMotionOverseer(Assets.Battle.Shared.ISharedVisualEffectsOverseer vfxOverseer, Assets.Battle.Shared.ISharedCameraOverseer cameraOverseer, Assets.Battle.Shared.ISharedHudOverseer hudOverseer, Assets.Battle.Shared.ISharedBattleDataStorageModel model, Assets.Battle.Shared.ISharedFieldOverseer fieldOverseer, Assets.Battle.Utilities.IMetronome metronome, Assets.Battle.Shared.ISharedCockpitOverseer cockpitOverseer);
                /*0x3caf3f4*/ Cysharp.Threading.Tasks.UniTask TransitionToFocusCamera(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3caf4d0*/ Cysharp.Threading.Tasks.UniTask TransitionToTargetFocusCamera(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3caf5ac*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes AcquireTargetFocusCameraType(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3caf6f4*/ Assets.Battle.Overseers.CameraOverseer.CameraTypes AcquireFocusCameraType(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3caf728*/ UnityEngine.Vector3 CalculateFocusTarget(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 actorPosition, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                /*0x3cafab8*/ System.Nullable<UnityEngine.Vector3> TryAcquireVfxPosition(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3[] positions, bool isEnemyIsTarget);
                /*0x3cafc84*/ UnityEngine.Vector3[] CalculateTargetsPositions(Assets.VisualEffectData.VfxHandler vfx, Assets.Battle.Shared.SharedActor[] targets, bool isEnemyIsTarget);
                /*0x3cb005c*/ UnityEngine.Vector3 AcquireMecanimDamagePoint(Assets.VisualEffectData.ProjectileEmitter emitter, Assets.Battle.Shared.SharedActor actor);
                /*0x3cb013c*/ UnityEngine.Vector3 AcquireMecanimDamagePoint(Assets.Battle.Shared.SharedActor actor);
                /*0x3cb01cc*/ Cysharp.Threading.Tasks.UniTask ProcessBoosterActionEvent(Assets.Utilities.Spine.MecanimController mecanim, Assets.Utilities.Spine.MecanimController.ActionData eventData);
                /*0x3cb02c0*/ Cysharp.Threading.Tasks.UniTask ProcessJumpAction(Assets.Utilities.Spine.MecanimController.ActionData eventData, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, UnityEngine.Vector3 actorPosition, UnityEngine.Vector3 targetPosition);
                /*0x3cb03f8*/ System.Collections.Generic.IAsyncEnumerable<string> MotionEvents(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                /*0x3cb049c*/ Cysharp.Threading.Tasks.UniTask ProcessExtraSkillVfxEvent(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                /*0x3cb05a0*/ Cysharp.Threading.Tasks.UniTask ProcessCutInSkillVfxEvent(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Threading.CancellationToken cancellationToken);
                /*0x3cb06a0*/ Assets.Utilities.Spine.SkeletonController.AnimationTypes AcquireAnimationType(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cb06a8*/ Cysharp.Threading.Tasks.UniTask ProcessSkillVfxEvent(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Action continuationCallback, System.Action endCallback);
                /*0x3cb07a8*/ Cysharp.Threading.Tasks.UniTask ProcessSegment(Assets.VisualEffectData.LineSegmentHandler segmentHanler, UnityEngine.Vector3 origin, UnityEngine.Vector3[] emitters, UnityEngine.Vector3 target, string vfxName);
                /*0x3cb0904*/ void ProcessAreaVfx(Assets.VisualEffectData.VfxHandler prefab, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3cb0cc0*/ Cysharp.Threading.Tasks.UniTask ProcessProjectileEmission(Assets.VisualEffectData.ProjectileEmitter emitter, UnityEngine.Vector3[] targets, UnityEngine.Vector3[] emissionPoints, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, System.Action continuationCallback, System.Action endCallback);
                /*0x3cb0e18*/ UnityEngine.Vector3 TryToApplyDeviation(UnityEngine.Vector3 position, float radius);
                /*0x3cb0e70*/ UnityEngine.Quaternion CalculateRotation(UnityEngine.Quaternion rotation, bool isEnemyActor);
                /*0x3cb0ed4*/ UnityEngine.Vector3 <CalculateFocusTarget>b__12_0(Assets.Battle.Shared.SharedActor t);

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

                    /*0x3cb1dec*/ SkillData(Assets.Battle.Shared.SharedActor actor, Assets.Battle.Shared.SharedActor[] targets, System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> tasks, System.Func<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData, Cysharp.Threading.Tasks.UniTask> showSkillLabel);
                    /*0x3cb1c44*/ Assets.Battle.Shared.SharedActor get_Actor();
                    /*0x3cb1c4c*/ Assets.Battle.Shared.SharedActor[] get_Targets();
                    /*0x3cb1c54*/ System.Collections.Generic.List<Cysharp.Threading.Tasks.UniTask> get_Tasks();
                    /*0x3cb1c5c*/ System.Func<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData, Cysharp.Threading.Tasks.UniTask> get_ShowSkillLabel();
                    /*0x3cb1c64*/ UnityEngine.Vector3 get_TargetPosition();
                    /*0x3cb1c70*/ void set_TargetPosition(UnityEngine.Vector3 value);
                    /*0x3cb1c7c*/ Assets.Utilities.Spine.SkeletonController get_Cockpit();
                    /*0x3cb1c84*/ void set_Cockpit(Assets.Utilities.Spine.SkeletonController value);
                    /*0x3cb1c8c*/ Assets.VisualEffectData.VfxHandler get_Vfx();
                    /*0x3cb1c94*/ void set_Vfx(Assets.VisualEffectData.VfxHandler value);
                    /*0x3cb1c9c*/ Assets.VisualEffectData.VfxTargetOverride get_VfxTargetOverride();
                    /*0x3cb1ca4*/ void set_VfxTargetOverride(Assets.VisualEffectData.VfxTargetOverride value);
                    /*0x3cb1cac*/ string get_MotionName();
                    /*0x3cb1cb4*/ void set_MotionName(string value);
                    /*0x3cb1cbc*/ string get_MotionFlowName();
                    /*0x3cb1cc4*/ void set_MotionFlowName(string value);
                    /*0x3cb1ccc*/ string get_SubsequentFlowName();
                    /*0x3cb1cd4*/ void set_SubsequentFlowName(string value);
                    /*0x3cb1cdc*/ string get_JumpActionOverride();
                    /*0x3cb1ce4*/ void set_JumpActionOverride(string value);
                    /*0x3cb1cec*/ string get_BoneTag();
                    /*0x3cb1cf4*/ void set_BoneTag(string value);
                    /*0x3cb1cfc*/ string get_ExtraSkillAssetId();
                    /*0x3cb1d04*/ void set_ExtraSkillAssetId(string value);
                    /*0x3cb1d0c*/ string get_CutInAssetId();
                    /*0x3cb1d14*/ void set_CutInAssetId(string value);
                    /*0x3cb1d1c*/ string get_CameraAssetId();
                    /*0x3cb1d24*/ void set_CameraAssetId(string value);
                    /*0x3cb1d2c*/ string get_Name();
                    /*0x3cb1d34*/ void set_Name(string value);
                    /*0x3cb1d3c*/ int get_Type();
                    /*0x3cb1d44*/ void set_Type(int value);
                    /*0x3cb1d4c*/ int get_ResourceCost();
                    /*0x3cb1d54*/ void set_ResourceCost(int value);
                    /*0x3cb1d5c*/ bool get_IsEnemyActor();
                    /*0x3cb1d64*/ void set_IsEnemyActor(bool value);
                    /*0x3cb1d70*/ bool get_IsEnemyIsTarget();
                    /*0x3cb1d78*/ void set_IsEnemyIsTarget(bool value);
                    /*0x3cb1d84*/ bool get_IsTargetSelf();
                    /*0x3cb1d8c*/ void set_IsTargetSelf(bool value);
                    /*0x3cb1d98*/ bool get_IsTargetFriendly();
                    /*0x3cb1da0*/ void set_IsTargetFriendly(bool value);
                    /*0x3cb1dac*/ bool get_LargeScaleMecanim();
                    /*0x3cb1db4*/ void set_LargeScaleMecanim(bool value);
                    /*0x3cb1dc0*/ bool get_HasLargeScaleMecanimTarget();
                    /*0x3cb1dc8*/ void set_HasLargeScaleMecanimTarget(bool value);
                    /*0x3cb1dd4*/ UnityEngine.Vector3 get_ActorTruePosition();
                    /*0x3cb1de0*/ void set_ActorTruePosition(UnityEngine.Vector3 value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Shared.SharedActor, UnityEngine.Transform> <>9__9_0;
                    static /*0x10*/ System.Func<Assets.Battle.Shared.SharedActor, UnityEngine.Vector3> <>9__14_0;
                    static /*0x18*/ System.Func<Assets.Battle.Shared.SharedActor, UnityEngine.Vector3> <>9__25_0;

                    static /*0x3cb1f48*/ <>c();
                    /*0x3cb1fb0*/ <>c();
                    /*0x3cb1fb8*/ UnityEngine.Transform <TransitionToTargetFocusCamera>b__9_0(Assets.Battle.Shared.SharedActor t);
                    /*0x3cb1fd8*/ UnityEngine.Vector3 <CalculateTargetsPositions>b__14_0(Assets.Battle.Shared.SharedActor t);
                    /*0x3cb2004*/ UnityEngine.Vector3 <ProcessAreaVfx>b__25_0(Assets.Battle.Shared.SharedActor m);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x18*/ Assets.VisualEffectData.VfxHandler vfx;

                    /*0x3cb2030*/ <>c__DisplayClass14_0();
                    /*0x3cb2038*/ UnityEngine.Vector3 <CalculateTargetsPositions>b__1(Assets.Battle.Shared.SharedActor t);
                    /*0x3cb2064*/ UnityEngine.Vector3 <CalculateTargetsPositions>b__2(UnityEngine.Vector3 p);
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;

                    /*0x3cb2140*/ <>c__DisplayClass17_0();
                    /*0x3cb2148*/ bool <ProcessBoosterActionEvent>b__0(Spine.Unity.BoneFollower b);
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ UnityEngine.Vector3 actorPosition;
                    /*0x1c*/ UnityEngine.Vector3 targetPosition;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;

                    /*0x3cb2180*/ <>c__DisplayClass18_0();
                    /*0x3cb2188*/ Cysharp.Threading.Tasks.UniTask <ProcessJumpAction>g__ProcessSlideAction|0(float firstPoint, float secondPoint);

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

                        /*0x3cb224c*/ void MoveNext();
                        /*0x3cb341c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cb3428*/ <>c__DisplayClass19_0();
                    /*0x3cb3430*/ void <MotionEvents>b__12();
                    /*0x3cb3460*/ void <MotionEvents>b__13();
                    /*0x3cb3490*/ void <MotionEvents>b__7();
                    /*0x3cb3540*/ void <MotionEvents>b__8();
                    /*0x3cb35f0*/ void <MotionEvents>b__9();
                    /*0x3cb36a0*/ void <MotionEvents>b__14();
                    /*0x3cb36cc*/ void <MotionEvents>b__15();
                    /*0x3cb378c*/ void <MotionEvents>b__10(Assets.Utilities.Spine.MecanimController.VisualEffectData vfxData);
                    /*0x3cb3860*/ void <MotionEvents>b__11(string value);
                    /*0x3cb3920*/ Cysharp.Threading.Tasks.UniTask <MotionEvents>b__0();
                    /*0x3cb3a30*/ void <MotionEvents>b__16();
                    /*0x3cb3a5c*/ void <MotionEvents>b__17();
                    /*0x3cb3a6c*/ void <MotionEvents>b__1();
                    /*0x3cb3a98*/ void <MotionEvents>b__2();
                    /*0x3cb3aa8*/ bool <MotionEvents>b__18();

                    struct <<MotionEvents>b__10>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Utilities.Spine.MecanimController.VisualEffectData vfxData;
                        /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;
                        /*0x60*/ string[] <>7__wrap1;
                        /*0x68*/ int <>7__wrap2;

                        /*0x3cb3ad0*/ void MoveNext();
                        /*0x3cb43ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__7>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cb43b8*/ void MoveNext();
                        /*0x3cb46e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__8>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cb46ec*/ void MoveNext();
                        /*0x3cb4a14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__9>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cb4a20*/ void MoveNext();
                        /*0x3cb4e18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass19_1
                {
                    /*0x10*/ UnityEngine.Vector3 actorPosition;
                    /*0x1c*/ UnityEngine.Vector3 targetPosition;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> CS$<>8__locals1;

                    /*0x3cb4e24*/ <>c__DisplayClass19_1();
                    /*0x3cb4e2c*/ void <MotionEvents>b__5(Assets.Utilities.Spine.MecanimController.ActionData eventData);
                    /*0x3cb4f00*/ void <MotionEvents>b__6(Assets.Utilities.Spine.MecanimController.ActionData eventData);

                    struct <<MotionEvents>b__5>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;
                        /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cb4fd4*/ void MoveNext();
                        /*0x3cb55a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<MotionEvents>b__6>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Utilities.Spine.MecanimController.ActionData eventData;
                        /*0x40*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cb55b4*/ void MoveNext();
                        /*0x3cb5d74*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource extraSkillCompletionSource;

                    /*0x3cb5d80*/ <>c__DisplayClass20_0();
                    /*0x3cb5d88*/ void <ProcessExtraSkillVfxEvent>b__0(string motionName);
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource cutInCompletionSource;

                    /*0x3cb5da4*/ <>c__DisplayClass21_0();
                    /*0x3cb5dac*/ void <ProcessCutInSkillVfxEvent>b__0();
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ System.Action continuationCallback;
                    /*0x18*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x20*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x28*/ Assets.VisualEffectData.VfxHandler vfx;
                    /*0x30*/ System.Action endCallback;

                    /*0x3cb5dc8*/ <>c__DisplayClass23_0();
                    /*0x3cb5dd0*/ void <ProcessSkillVfxEvent>b__0(Assets.VisualEffectData.VfxHandler afterEffectPrefab);
                    /*0x3cb604c*/ void <ProcessSkillVfxEvent>b__1();
                }

                class <>c__DisplayClass26_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x18*/ Assets.VisualEffectData.ProjectileEmitter emitter;
                    /*0x20*/ System.Action continuationCallback;
                    /*0x28*/ System.Action endCallback;

                    /*0x3cb609c*/ <>c__DisplayClass26_0();
                    /*0x3cb60a4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> <ProcessProjectileEmission>b__0(UnityEngine.GameObject prefab);
                    /*0x3cb61bc*/ void <ProcessProjectileEmission>b__1();
                    /*0x3cb6204*/ void <ProcessProjectileEmission>b__2();

                    struct <<ProcessProjectileEmission>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                        /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer.<> <>4__this;
                        /*0x38*/ UnityEngine.GameObject prefab;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                        /*0x3cb624c*/ void MoveNext();
                        /*0x3cb67e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cb6840*/ <MotionEvents>d__19(int <>1__state);
                    /*0x3cb68ac*/ void MoveNext();
                    /*0x3cb89b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    /*0x3cb89bc*/ System.Collections.Generic.IAsyncEnumerator<string> System.Collections.Generic.IAsyncEnumerable<System.String>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken);
                    /*0x3cb8bb8*/ System.Threading.Tasks.ValueTask<bool> System.Collections.Generic.IAsyncEnumerator<System.String>.MoveNextAsync();
                    /*0x3cb8d30*/ string System.Collections.Generic.IAsyncEnumerator<System.String>.get_Current();
                    /*0x3cb8d38*/ bool System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetResult(short token);
                    /*0x3cb8d90*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.GetStatus(short token);
                    /*0x3cb8de8*/ void System.Threading.Tasks.Sources.IValueTaskSource<System.Boolean>.OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x3cb8e60*/ void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token);
                    /*0x3cb8eb8*/ System.Threading.Tasks.Sources.ValueTaskSourceStatus System.Threading.Tasks.Sources.IValueTaskSource.GetStatus(short token);
                    /*0x3cb8f10*/ void System.Threading.Tasks.Sources.IValueTaskSource.OnCompleted(System.Action<object> continuation, object state, short token, System.Threading.Tasks.Sources.ValueTaskSourceOnCompletedFlags flags);
                    /*0x3cb8f88*/ System.Threading.Tasks.ValueTask System.IAsyncDisposable.DisposeAsync();
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

                    /*0x3cb90a0*/ void MoveNext();
                    /*0x3cb99ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cb99b8*/ void MoveNext();
                    /*0x3cba7bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cba7c8*/ void MoveNext();
                    /*0x3cbc528*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cbc534*/ void MoveNext();
                    /*0x3cbd2fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cbd308*/ void MoveNext();
                    /*0x3cbda28*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cbda34*/ void MoveNext();
                    /*0x3cbe134*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cbe140*/ void MoveNext();
                    /*0x3cc05f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cc0604*/ void MoveNext();
                    /*0x3cc1ea4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TransitionToTargetFocusCamera>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x30*/ Assets.Battle.Shared.SharedSkillMotionOverseer <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cc1eb0*/ void MoveNext();
                    /*0x3cc29fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            namespace Playground
            {
                class SharedPlaygroundEntryPoint : VContainer.Unity.IAsyncStartable
                {
                    static /*0x0*/ bool <InitializeFinished>k__BackingField;
                    /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;

                    static /*0x3cc2a08*/ bool get_InitializeFinished();
                    static /*0x3cc2a50*/ void set_InitializeFinished(bool value);
                    /*0x3cc2aa0*/ SharedPlaygroundEntryPoint(Assets.AssetManagement.IAddressablesAssetProvider assetProvider);
                    /*0x3cc2ad0*/ Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken cancellation);

                    struct <StartAsync>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundEntryPoint <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc2b7c*/ void MoveNext();
                        /*0x3cc31a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class SharedPlaygroundLifetimeScope : VContainer.Unity.LifetimeScope
                {
                    /*0x68*/ Assets.GameUi.Externals.AudioManager audioManager;
                    /*0x70*/ Assets.GameUi.Externals.CameraManager cameraManager;
                    /*0x78*/ Assets.AssetManagement.UnusedInstanceManager unusedInstanceManager;

                    /*0x3cc33a8*/ SharedPlaygroundLifetimeScope();
                    /*0x3cc31b0*/ void Configure(VContainer.IContainerBuilder builder);
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

                    static /*0x3cc4e14*/ string <CreateSkillData>g__AcquireMotionName|83_1(string motionName);
                    static /*0x3cc4eec*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Shared.Playground.TargetData[]> <LoadMecanims>g__CreateMechas|86_0(Assets.Battle.Shared.Playground.ActorData[] data, UnityEngine.Transform[] positions, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, UnityEngine.Transform parent, string suffix);
                    static /*0x3cc5058*/ void <LoadMecanims>g__AddYHardRotation|86_1(UnityEngine.GameObject target);
                    /*0x3cc4828*/ SharedPlaygroundManager();
                    /*0x3cc3400*/ Assets.AssetManagement.IAssetInstanceProvider get_InstanceProvider();
                    /*0x3cc3408*/ void set_InstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                    /*0x3cc3418*/ Assets.Battle.Shared.ISkillMotionOverseer get_SkillMotionOverseer();
                    /*0x3cc3420*/ void set_SkillMotionOverseer(Assets.Battle.Shared.ISkillMotionOverseer value);
                    /*0x3cc3430*/ Assets.Battle.Shared.ISharedCameraOverseer get_CameraOverseer();
                    /*0x3cc3438*/ void set_CameraOverseer(Assets.Battle.Shared.ISharedCameraOverseer value);
                    /*0x3cc3448*/ Assets.Battle.Shared.ISharedVisualEffectsOverseer get_VfxOverseer();
                    /*0x3cc3450*/ void set_VfxOverseer(Assets.Battle.Shared.ISharedVisualEffectsOverseer value);
                    /*0x3cc3460*/ Assets.Battle.Shared.ISharedFieldOverseer get_FieldOverseer();
                    /*0x3cc3468*/ void set_FieldOverseer(Assets.Battle.Shared.ISharedFieldOverseer value);
                    /*0x3cc3478*/ Assets.Battle.Shared.ISharedHudOverseer get_HudOverseer();
                    /*0x3cc3480*/ void set_HudOverseer(Assets.Battle.Shared.ISharedHudOverseer value);
                    /*0x3cc3490*/ Assets.Battle.Shared.ISharedBattleDataStorageModel get_BattleDataStorageModel();
                    /*0x3cc3498*/ void set_BattleDataStorageModel(Assets.Battle.Shared.ISharedBattleDataStorageModel value);
                    /*0x3cc34a8*/ Assets.Battle.Shared.ISharedCockpitOverseer get_CockpitOverseer();
                    /*0x3cc34b0*/ void set_CockpitOverseer(Assets.Battle.Shared.ISharedCockpitOverseer value);
                    /*0x3cc34c0*/ Assets.Battle.Utilities.IMetronome get_Metronome();
                    /*0x3cc34c8*/ void set_Metronome(Assets.Battle.Utilities.IMetronome value);
                    /*0x3cc34d8*/ Assets.GameUi.Header.IHeaderComponent get_Header();
                    /*0x3cc34e0*/ void set_Header(Assets.GameUi.Header.IHeaderComponent value);
                    /*0x3cc34f0*/ Assets.GameUi.Externals.IBackgroundManager get_BackgroundManager();
                    /*0x3cc34f8*/ void set_BackgroundManager(Assets.GameUi.Externals.IBackgroundManager value);
                    /*0x3cc3508*/ void Awake();
                    /*0x3cc3ab0*/ void PrepareForSkillUse();
                    /*0x3cc3dec*/ void Update();
                    /*0x3cc43f8*/ Cysharp.Threading.Tasks.UniTask ProcessSkillUse(Assets.Battle.Shared.Playground.TargetData actor, Assets.Battle.Shared.Playground.TargetData[] targets, bool isEnemyActor);
                    /*0x3cc459c*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> CreateSkillData(Assets.Battle.Shared.Playground.TargetData actor, Assets.Battle.Shared.Playground.TargetData[] targets, bool isEnemyActor);
                    /*0x3cc46e4*/ Cysharp.Threading.Tasks.UniTask TryEnableMinimizedCockpit(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                    /*0x3cc3a04*/ Cysharp.Threading.Tasks.UniTask Process();
                    /*0x3cc44ec*/ Cysharp.Threading.Tasks.UniTask LoadMecanims();
                    /*0x3cc4b50*/ void <Awake>b__79_0(Assets.Battle.Shared.Playground.ActorData[] playerData, Assets.Battle.Shared.Playground.ActorData[] enemyData);
                    /*0x3cc4b8c*/ void <Awake>b__79_1();
                    /*0x3cc4ba8*/ void <Awake>b__79_2();
                    /*0x3cc4bc4*/ void <Awake>b__79_3();
                    /*0x3cc4c6c*/ void <Awake>b__79_4();
                    /*0x3cc4ca0*/ Cysharp.Threading.Tasks.UniTask <Awake>b__79_5();
                    /*0x3cc4d4c*/ Cysharp.Threading.Tasks.UniTask <Awake>b__79_6();
                    /*0x3cc4df8*/ bool <Update>b__81_3();
                    /*0x3cc4e04*/ bool <Update>b__81_2();
                    /*0x3cc4e10*/ Cysharp.Threading.Tasks.UniTask <CreateSkillData>b__83_2(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);

                    struct <<Awake>b__79_5>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc5148*/ void MoveNext();
                        /*0x3cc5868*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<Awake>b__79_6>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc5874*/ void MoveNext();
                        /*0x3cc5dc8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                        /*0x3cc5dd4*/ void MoveNext();
                        /*0x3cc667c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager.<> <>9;
                        static /*0x8*/ System.Func<Assets.Battle.Shared.Playground.ActorData, bool> <>9__81_0;
                        static /*0x10*/ System.Func<Assets.Battle.Shared.Playground.ActorData, bool> <>9__81_1;
                        static /*0x18*/ System.Func<Assets.Battle.Shared.Playground.TargetData, Assets.Battle.Shared.SharedActor> <>9__83_0;
                        static /*0x20*/ System.Func<Assets.Battle.Shared.Playground.TargetData, bool> <>9__83_3;
                        static /*0x28*/ System.Func<UnityEngine.Transform, UnityEngine.Vector3> <>9__85_0;

                        static /*0x3cc66d4*/ <>c();
                        /*0x3cc673c*/ <>c();
                        /*0x3cc6744*/ bool <Update>b__81_0(Assets.Battle.Shared.Playground.ActorData p);
                        /*0x3cc67bc*/ bool <Update>b__81_1(Assets.Battle.Shared.Playground.ActorData e);
                        /*0x3cc6834*/ Assets.Battle.Shared.SharedActor <CreateSkillData>b__83_0(Assets.Battle.Shared.Playground.TargetData t);
                        /*0x3cc68b4*/ bool <CreateSkillData>b__83_3(Assets.Battle.Shared.Playground.TargetData t);
                        /*0x3cc6948*/ UnityEngine.Vector3 <Process>b__85_0(UnityEngine.Transform p);
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

                        /*0x3cc698c*/ void MoveNext();
                        /*0x3cc7624*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <LoadMecanims>d__86 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Shared.Playground.TargetData[]> <>u__1;

                        /*0x3cc767c*/ void MoveNext();
                        /*0x3cc8200*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <Process>d__85 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Shared.Playground.SharedPlaygroundManager <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cc820c*/ void MoveNext();
                        /*0x3cc8cac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                        /*0x3cc8cb8*/ void MoveNext();
                        /*0x3cca38c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ActorData
                {
                    /*0x10*/ string <AssetKey>k__BackingField;
                    /*0x18*/ int <PositionIndex>k__BackingField;
                    /*0x1c*/ float <Scale>k__BackingField;
                    /*0x20*/ float <CameraDistance>k__BackingField;

                    /*0x3cca3d8*/ ActorData();
                    /*0x3cca398*/ string get_AssetKey();
                    /*0x3cca3a0*/ void set_AssetKey(string value);
                    /*0x3cca3a8*/ int get_PositionIndex();
                    /*0x3cca3b0*/ void set_PositionIndex(int value);
                    /*0x3cca3b8*/ float get_Scale();
                    /*0x3cca3c0*/ void set_Scale(float value);
                    /*0x3cca3c8*/ float get_CameraDistance();
                    /*0x3cca3d0*/ void set_CameraDistance(float value);
                }

                class TargetData
                {
                    /*0x10*/ Assets.Utilities.Spine.MecanimController <Mecnaim>k__BackingField;
                    /*0x18*/ Assets.Battle.Shared.Playground.ActorData <ActorData>k__BackingField;

                    /*0x3cc6674*/ TargetData();
                    /*0x3cca40c*/ Assets.Utilities.Spine.MecanimController get_Mecnaim();
                    /*0x3cca414*/ void set_Mecnaim(Assets.Utilities.Spine.MecanimController value);
                    /*0x3cca41c*/ Assets.Battle.Shared.Playground.ActorData get_ActorData();
                    /*0x3cca424*/ void set_ActorData(Assets.Battle.Shared.Playground.ActorData value);
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

                        /*0x3cca5d0*/ ActorCreationView();
                        /*0x3cca42c*/ Assets.Battle.Shared.Playground.Hud.ActorGroup get_PlayerGroup();
                        /*0x3cca434*/ void set_PlayerGroup(Assets.Battle.Shared.Playground.Hud.ActorGroup value);
                        /*0x3cca43c*/ Assets.Battle.Shared.Playground.Hud.ActorGroup get_EnemyGroup();
                        /*0x3cca444*/ void set_EnemyGroup(Assets.Battle.Shared.Playground.Hud.ActorGroup value);
                        /*0x3cca44c*/ UnityEngine.UI.Button get_ApplyButton();
                        /*0x3cca454*/ void set_ApplyButton(UnityEngine.UI.Button value);
                        /*0x3cca45c*/ void Awake();
                        /*0x3cca4e4*/ void TriggerNavigationAction();
                        /*0x3cca5d8*/ void <Awake>b__14_0();
                    }

                    class ActorGroup : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ Assets.Battle.Shared.Playground.Hud.ActorTile tilePrefab;
                        /*0x28*/ UnityEngine.Transform tileContainer;
                        /*0x30*/ UnityEngine.UI.Button addButton;
                        /*0x38*/ System.Collections.Generic.List<Assets.Battle.Shared.Playground.Hud.ActorTile> <Tiles>k__BackingField;
                        /*0x40*/ int activeTilesCount;

                        /*0x3cca8f4*/ ActorGroup();
                        /*0x3cca5dc*/ System.Collections.Generic.List<Assets.Battle.Shared.Playground.Hud.ActorTile> get_Tiles();
                        /*0x3cca5e4*/ void Awake();
                        /*0x3cca66c*/ void AddTile(string assetKey, string position, string scale, string cameraDistance);
                        /*0x3cca97c*/ void <Awake>b__7_0();

                        class <>c__DisplayClass8_0
                        {
                            /*0x10*/ Assets.Battle.Shared.Playground.Hud.ActorGroup <>4__this;
                            /*0x18*/ Assets.Battle.Shared.Playground.Hud.ActorTile tile;

                            /*0x3cca8ec*/ <>c__DisplayClass8_0();
                            /*0x3ccab30*/ void <AddTile>b__0();
                        }
                    }

                    class ActorTile : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ TMPro.TMP_InputField <AssetKey>k__BackingField;
                        /*0x28*/ TMPro.TMP_InputField <Position>k__BackingField;
                        /*0x30*/ TMPro.TMP_InputField <Scale>k__BackingField;
                        /*0x38*/ TMPro.TMP_InputField <CameraDistance>k__BackingField;
                        /*0x40*/ UnityEngine.UI.Button <RemoveButton>k__BackingField;

                        /*0x3ccac38*/ ActorTile();
                        /*0x3ccabe8*/ TMPro.TMP_InputField get_AssetKey();
                        /*0x3ccabf0*/ void set_AssetKey(TMPro.TMP_InputField value);
                        /*0x3ccabf8*/ TMPro.TMP_InputField get_Position();
                        /*0x3ccac00*/ void set_Position(TMPro.TMP_InputField value);
                        /*0x3ccac08*/ TMPro.TMP_InputField get_Scale();
                        /*0x3ccac10*/ void set_Scale(TMPro.TMP_InputField value);
                        /*0x3ccac18*/ TMPro.TMP_InputField get_CameraDistance();
                        /*0x3ccac20*/ void set_CameraDistance(TMPro.TMP_InputField value);
                        /*0x3ccac28*/ UnityEngine.UI.Button get_RemoveButton();
                        /*0x3ccac30*/ void set_RemoveButton(UnityEngine.UI.Button value);
                    }

                    class ButtonPanel : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ UnityEngine.UI.Button <Button>k__BackingField;

                        /*0x3ccac50*/ ButtonPanel();
                        /*0x3ccac40*/ UnityEngine.UI.Button get_Button();
                        /*0x3ccac48*/ void set_Button(UnityEngine.UI.Button value);
                    }

                    class DropDownPanel : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ TMPro.TMP_Dropdown <Dropdown>k__BackingField;

                        /*0x3ccac68*/ DropDownPanel();
                        /*0x3ccac58*/ TMPro.TMP_Dropdown get_Dropdown();
                        /*0x3ccac60*/ void set_Dropdown(TMPro.TMP_Dropdown value);
                    }

                    class InputPanel : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ TMPro.TMP_InputField <InputField>k__BackingField;

                        /*0x3ccac80*/ InputPanel();
                        /*0x3ccac70*/ TMPro.TMP_InputField get_InputField();
                        /*0x3ccac78*/ void set_InputField(TMPro.TMP_InputField value);
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

                        /*0x3ccae00*/ SettingsView();
                        /*0x3ccac88*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_VfxAssetKey();
                        /*0x3ccac90*/ void set_VfxAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccac98*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_MotionName();
                        /*0x3ccaca0*/ void set_MotionName(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccaca8*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_SubsequentMotionName();
                        /*0x3ccacb0*/ void set_SubsequentMotionName(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccacb8*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_JumpActionOverride();
                        /*0x3ccacc0*/ void set_JumpActionOverride(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccacc8*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_ExtraSkillAssetKey();
                        /*0x3ccacd0*/ void set_ExtraSkillAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccacd8*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_CameraAssetKey();
                        /*0x3ccace0*/ void set_CameraAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccace8*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_EventVfxAssetKey();
                        /*0x3ccacf0*/ void set_EventVfxAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccacf8*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_CutInAssetKey();
                        /*0x3ccad00*/ void set_CutInAssetKey(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccad08*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_CockpitAssetId();
                        /*0x3ccad10*/ void set_CockpitAssetId(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccad18*/ Assets.Battle.Shared.Playground.Hud.ButtonPanel get_ResetCameraButton();
                        /*0x3ccad20*/ void set_ResetCameraButton(Assets.Battle.Shared.Playground.Hud.ButtonPanel value);
                        /*0x3ccad28*/ Assets.Battle.Shared.Playground.Hud.ButtonPanel get_ToggleLegendButton();
                        /*0x3ccad30*/ void set_ToggleLegendButton(Assets.Battle.Shared.Playground.Hud.ButtonPanel value);
                        /*0x3ccad38*/ Assets.Battle.Shared.Playground.Hud.InputPanel get_FieldJsonString();
                        /*0x3ccad40*/ void set_FieldJsonString(Assets.Battle.Shared.Playground.Hud.InputPanel value);
                        /*0x3ccad48*/ UnityEngine.UI.Button get_ApplyPlayerButton();
                        /*0x3ccad50*/ void set_ApplyPlayerButton(UnityEngine.UI.Button value);
                        /*0x3ccad58*/ UnityEngine.UI.Button get_ApplyEnemyButton();
                        /*0x3ccad60*/ void set_ApplyEnemyButton(UnityEngine.UI.Button value);
                        /*0x3ccad68*/ UnityEngine.UI.Button get_ApplyFieldButton();
                        /*0x3ccad70*/ void set_ApplyFieldButton(UnityEngine.UI.Button value);
                        /*0x3ccad78*/ void Awake();
                        /*0x3cc3d00*/ void TriggerNavigationAction();
                        /*0x3ccae08*/ void <Awake>b__62_0();
                    }

                    class SharedPlaygroundHud : UnityEngine.MonoBehaviour
                    {
                        /*0x20*/ Assets.Battle.Shared.Playground.Hud.ActorCreationView actorCreationView;
                        /*0x28*/ Assets.Battle.Shared.Playground.Hud.SettingsView <SettingsView>k__BackingField;
                        /*0x30*/ UnityEngine.Events.UnityEvent<Assets.Battle.Shared.Playground.ActorData[], Assets.Battle.Shared.Playground.ActorData[]> OnApplyActorsClicked;

                        /*0x3ccb1dc*/ SharedPlaygroundHud();
                        /*0x3ccae0c*/ Assets.Battle.Shared.Playground.Hud.SettingsView get_SettingsView();
                        /*0x3ccae14*/ void set_SettingsView(Assets.Battle.Shared.Playground.Hud.SettingsView value);
                        /*0x3ccae1c*/ void Awake();
                        /*0x3ccaea8*/ Assets.Battle.Shared.Playground.ActorData[] CreateActorData(System.Collections.Generic.List<Assets.Battle.Shared.Playground.Hud.ActorTile> tiles);
                        /*0x3cc3868*/ void ApplyActorData(Assets.Battle.Shared.Playground.ActorData[] playerData, Assets.Battle.Shared.Playground.ActorData[] enemyData);
                        /*0x3ccb264*/ void <Awake>b__6_0();
                    }
                }
            }
        }

        namespace Overseers
        {
            interface IActorOverseerUnityFacade
            {
                /*0x380cb08*/ void ClearActorList();
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IActorOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <ActorsLayer>k__BackingField;

                    /*0x3ccb3c0*/ Arguments();
                    /*0x3ccb3b0*/ UnityEngine.Transform get_ActorsLayer();
                    /*0x3ccb3b8*/ void set_ActorsLayer(UnityEngine.Transform value);
                }
            }

            interface IActorOverseer
            {
                /*0x380bb68*/ Assets.Battle.Actor AcquireActor(Assets.Api.Client.PawnId id);
                /*0x380b9e8*/ Assets.Battle.Actor[] AcquireActors();
                /*0x380bb68*/ Assets.Battle.Actor[] AcquireActors(Assets.Api.Client.PawnId[] ids);
                Assets.Battle.Actor[] AcquireActors(bool enemyActors);
                /*0x380b9e8*/ Assets.Battle.Actor[] AcquireActorsIncludingDead();
                Assets.Battle.Actor[] AcquireActorsIncludingDead(bool enemyActors);
                /*0x380b9e8*/ Assets.Battle.Actor[] AcquireEnemyActors();
                /*0x380b9e8*/ Assets.Battle.Actor[] AcquireEnemyActorsIncludingDead();
                /*0x380b9e8*/ Assets.Battle.Actor AcquireFirstEnemyActor();
                /*0x380b9e8*/ Assets.Battle.Actor AcquireFirstPlayerActor();
                /*0x380b9e8*/ Assets.Battle.Actor[] AcquirePlayerActors();
                /*0x380b9e8*/ Assets.Battle.Actor[] AcquirePlayerActorsIncludingDead();
                /*0x380cb08*/ void ClearActorList();
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Actor> CreateActor(Assets.Api.Client.PawnView view);
            }

            class ActorOverseer : Assets.Battle.Overseers.IActorOverseer, Assets.Battle.Overseers.IActorOverseerUnityFacade, System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, Assets.Battle.Actor> actors;
                /*0x18*/ UniRx.CompositeDisposable disposables;
                /*0x20*/ Assets.Battle.DataModels.IBattleDataStorageModel model;
                /*0x28*/ Assets.AssetManagement.ISpineAssetProvider spineAssetProvider;
                /*0x30*/ UnityEngine.Transform actorsLayer;

                /*0x3ccb3c8*/ ActorOverseer(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.AssetManagement.ISpineAssetProvider spineAssetProvider);
                /*0x3ccb4b8*/ void Initialize(Assets.Battle.Overseers.IActorOverseerUnityFacade.Arguments arguments);
                /*0x3ccb66c*/ Assets.Battle.Actor AcquireActor(Assets.Api.Client.PawnId id);
                /*0x3ccb6e4*/ Assets.Battle.Actor[] AcquireActors(Assets.Api.Client.PawnId[] ids);
                /*0x3ccb86c*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Actor> CreateActor(Assets.Api.Client.PawnView view);
                /*0x3ccb994*/ void ClearActorList();
                /*0x3ccbec4*/ Assets.Battle.Actor[] AcquireActors(bool enemyActors);
                /*0x3ccbfe0*/ Assets.Battle.Actor[] AcquireActorsIncludingDead(bool enemyActors);
                /*0x3ccc0fc*/ Assets.Battle.Actor[] AcquireActors();
                /*0x3ccc24c*/ Assets.Battle.Actor[] AcquireActorsIncludingDead();
                /*0x3ccc2b8*/ Assets.Battle.Actor AcquireFirstPlayerActor();
                /*0x3ccc3e4*/ Assets.Battle.Actor AcquireFirstEnemyActor();
                /*0x3ccc510*/ Assets.Battle.Actor[] AcquirePlayerActors();
                /*0x3ccc660*/ Assets.Battle.Actor[] AcquireEnemyActors();
                /*0x3ccc7b0*/ Assets.Battle.Actor[] AcquirePlayerActorsIncludingDead();
                /*0x3ccc900*/ Assets.Battle.Actor[] AcquireEnemyActorsIncludingDead();
                /*0x3ccca50*/ int FormationLocationViewToFieldPositionIndex(Assets.Api.Client.FormationLocationView view);
                /*0x3cccbd4*/ int FormationLocationViewToPositionIndex(Assets.Api.Client.FormationLocationView view);
                /*0x3cccd58*/ void Dispose();
                /*0x3cccd74*/ void <Initialize>b__6_0(bool value);

                class Configuration
                {
                    /*0x10*/ float <MecanimScale>k__BackingField;
                    /*0x14*/ float <CameraFocusDistance>k__BackingField;

                    /*0x3cced8c*/ Configuration();
                    /*0x3ccedf8*/ Configuration(Assets.Api.Client.PawnMasterView view);
                    /*0x3cced6c*/ float get_MecanimScale();
                    /*0x3cced74*/ void set_MecanimScale(float value);
                    /*0x3cced7c*/ float get_CameraFocusDistance();
                    /*0x3cced84*/ void set_CameraFocusDistance(float value);
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

                    static /*0x3ccf040*/ <>c();
                    /*0x3ccf0a8*/ <>c();
                    /*0x3ccf0b0*/ bool <AcquireActors>b__13_0(Assets.Battle.Actor a);
                    /*0x3ccf0d0*/ bool <AcquireFirstPlayerActor>b__15_0(Assets.Battle.Actor a);
                    /*0x3ccf100*/ bool <AcquireFirstEnemyActor>b__16_0(Assets.Battle.Actor a);
                    /*0x3ccf130*/ bool <AcquirePlayerActors>b__17_0(Assets.Battle.Actor a);
                    /*0x3ccf160*/ bool <AcquireEnemyActors>b__18_0(Assets.Battle.Actor a);
                    /*0x3ccf190*/ bool <AcquirePlayerActorsIncludingDead>b__19_0(Assets.Battle.Actor a);
                    /*0x3ccf1b0*/ bool <AcquireEnemyActorsIncludingDead>b__20_0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ bool enemyActors;

                    /*0x3ccf1c8*/ <>c__DisplayClass11_0();
                    /*0x3ccf1d0*/ bool <AcquireActors>b__0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ bool enemyActors;

                    /*0x3ccf204*/ <>c__DisplayClass12_0();
                    /*0x3ccf20c*/ bool <AcquireActorsIncludingDead>b__0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Api.Client.PawnView view;

                    /*0x3ccf230*/ <>c__DisplayClass9_0();
                    /*0x3ccf238*/ bool <CreateActor>b__0(Assets.Api.Client.PawnMasterView p);
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

                    /*0x3ccf260*/ void MoveNext();
                    /*0x3cd01a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICameraOverseerUnityFacade
            {
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x380e050*/ void ConfigureBlendCamera(float duration);
                /*0x380cb08*/ void ConfigureCutBlendCamera();
                /*0x380cb08*/ void DisablePostProcessing();
                /*0x380cffc*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x380cb08*/ void EnablePostProcessing();
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ICameraOverseerUnityFacade.Arguments arguments);
                /*0x380cdf0*/ void SetCameraOffset(bool value);

                class Arguments
                {
                    /*0x10*/ Assets.Battle.Accessors.CinemachineLayoutAccessor <CinemachineLayoutAccessor>k__BackingField;
                    /*0x18*/ Assets.Battle.Accessors.LayerOrderAccessor <LayerOrderAccessor>k__BackingField;
                    /*0x20*/ Unity.Cinemachine.NoiseSettings <ShakeNoise>k__BackingField;
                    /*0x28*/ Unity.Cinemachine.NoiseSettings <WobbleNoise>k__BackingField;
                    /*0x30*/ UnityEngine.Rendering.Volume <PostProcessingVolume>k__BackingField;
                    /*0x38*/ UnityEngine.GameObject <EntranceAnimation>k__BackingField;

                    /*0x3cd025c*/ Arguments();
                    /*0x3cd01fc*/ Assets.Battle.Accessors.CinemachineLayoutAccessor get_CinemachineLayoutAccessor();
                    /*0x3cd0204*/ void set_CinemachineLayoutAccessor(Assets.Battle.Accessors.CinemachineLayoutAccessor value);
                    /*0x3cd020c*/ Assets.Battle.Accessors.LayerOrderAccessor get_LayerOrderAccessor();
                    /*0x3cd0214*/ void set_LayerOrderAccessor(Assets.Battle.Accessors.LayerOrderAccessor value);
                    /*0x3cd021c*/ Unity.Cinemachine.NoiseSettings get_ShakeNoise();
                    /*0x3cd0224*/ void set_ShakeNoise(Unity.Cinemachine.NoiseSettings value);
                    /*0x3cd022c*/ Unity.Cinemachine.NoiseSettings get_WobbleNoise();
                    /*0x3cd0234*/ void set_WobbleNoise(Unity.Cinemachine.NoiseSettings value);
                    /*0x3cd023c*/ UnityEngine.Rendering.Volume get_PostProcessingVolume();
                    /*0x3cd0244*/ void set_PostProcessingVolume(UnityEngine.Rendering.Volume value);
                    /*0x3cd024c*/ UnityEngine.GameObject get_EntranceAnimation();
                    /*0x3cd0254*/ void set_EntranceAnimation(UnityEngine.GameObject value);
                }
            }

            interface ICameraOverseer
            {
                /*0x380cad0*/ UnityEngine.Vector3 get_CameraPosition();
                UnityEngine.Quaternion get_CameraRotation();
                Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters);
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                /*0x380e050*/ void ConfigureBlendCamera(float duration);
                /*0x380cb08*/ void ConfigureCutBlendCamera();
                /*0x380cffc*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x380e380*/ void SetFollowPosition(UnityEngine.Vector3 position);
                /*0x380e380*/ void SetLookAtPosition(UnityEngine.Vector3 position);
                /*0x380cb08*/ void TryDisableActionCamera();
                /*0x380d83c*/ void SetFollowTarget(UnityEngine.Transform target);
                /*0x380cb08*/ void EnablePostProcessing();
                /*0x380cb08*/ void DisablePostProcessing();
                /*0x380e380*/ void SetFocusLookAtPosition(UnityEngine.Vector3 position);
                /*0x380cb08*/ void TransitionToActiveCameraType();
                /*0x380e380*/ void SetFocusFollowPosition(UnityEngine.Vector3 position);
                /*0x380d83c*/ void AddToTargetGroup(UnityEngine.Transform[] targets);
                /*0x380d83c*/ void AddToTargetGroup(UnityEngine.Transform target);
                /*0x380cb08*/ void ClearTargetGroup();
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask PlaybackEntranceAnimation();
                /*0x380cdf0*/ void SetCameraOffset(bool value);
                Cysharp.Threading.Tasks.UniTask TryEnableActionCamera(string key, bool isEnemyActor, bool isExtraSkill);
                /*0x380e050*/ void SetCameraFocusDistance(float value);
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask PrepareEntranceAnimation();
                /*0x380e050*/ void SetCameraFocusYOffset(float value);
                /*0x380e050*/ void SetCameraTargetFocusDistance(float value);
                /*0x380e050*/ void SetCameraTargetFocusYOffset(float value);
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

                /*0x3cd03a8*/ CameraOverseer(Assets.GameUi.Externals.ICameraManager cameraManager, Assets.Battle.ICache cache, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3cd0264*/ UnityEngine.Vector3 get_CameraPosition();
                /*0x3cd0304*/ UnityEngine.Quaternion get_CameraRotation();
                /*0x3cd0730*/ void Initialize(Assets.Battle.Overseers.ICameraOverseerUnityFacade.Arguments arguments);
                /*0x3cd0d2c*/ void SetFieldCameraActive(bool value);
                /*0x3cd0d74*/ void SetCameraOffset(bool value);
                /*0x3cd1178*/ void SetCameraFocusDistance(float value);
                /*0x3cd1200*/ void SetCameraFocusYOffset(float value);
                /*0x3cd1288*/ void SetCameraTargetFocusDistance(float value);
                /*0x3cd1310*/ void SetCameraTargetFocusYOffset(float value);
                /*0x3cd1398*/ bool GetCameraOffset();
                /*0x3cd13a0*/ Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters);
                /*0x3cd1470*/ Cysharp.Threading.Tasks.UniTask ApplyCameraNoise(Assets.VisualEffectData.CameraNoiseParameters parameters, Unity.Cinemachine.CinemachineCamera camera);
                /*0x3cd1554*/ void EnablePostProcessing();
                /*0x3cd15e8*/ void DisablePostProcessing();
                /*0x3cd167c*/ void TransitionToActiveCameraType();
                /*0x3cd0d88*/ void TransitionTo(Assets.Battle.Overseers.CameraOverseer.CameraTypes type);
                /*0x3cd1684*/ void ClearTargetGroup();
                /*0x3cd1704*/ void AddToTargetGroup(UnityEngine.Transform target);
                /*0x3cd1730*/ void AddToTargetGroup(UnityEngine.Transform[] targets);
                /*0x3cd17b4*/ Cysharp.Threading.Tasks.UniTask PrepareEntranceAnimation();
                /*0x3cd1864*/ Cysharp.Threading.Tasks.UniTask PlaybackEntranceAnimation();
                /*0x3cd1910*/ Cysharp.Threading.Tasks.UniTask TryEnableActionCamera(string key, bool isEnemyActor, bool isExtraSkill);
                /*0x3cd19f4*/ Unity.Cinemachine.CinemachineCamera TryGetActionVirtualCamera(UnityEngine.GameObject actionCamera);
                /*0x3cd1b0c*/ void TryDisableActionCamera();
                /*0x3cd1bb0*/ Cysharp.Threading.Tasks.UniTask BlendToLoadingFade();
                /*0x3cd1c54*/ Cysharp.Threading.Tasks.UniTask BlendToDefaultUi();
                /*0x3cd1cf8*/ Cysharp.Threading.Tasks.UniTask AwaitCameraTransition();
                /*0x3cd1da0*/ void SetFollowTarget(UnityEngine.Transform target);
                /*0x3cd2000*/ void ConfigureCutBlendCamera();
                /*0x3cd20a8*/ void ConfigureBlendCamera(float duration);
                /*0x3cd2164*/ void DetatchFollowAndLook();
                /*0x3cd2204*/ void ReattachFollowAndLook();
                /*0x3cd22ac*/ void SetFollowPosition(UnityEngine.Vector3 position);
                /*0x3cd2494*/ void SetFollowStaticPosition(UnityEngine.Vector3 position);
                /*0x3cd267c*/ void SetLookAtPosition(UnityEngine.Vector3 position);
                /*0x3cd2864*/ void SetLookAtStaticPosition(UnityEngine.Vector3 position);
                /*0x3cd2a4c*/ void SetFocusLookAtPosition(UnityEngine.Vector3 position);
                /*0x3cd2c34*/ void SetFocusFollowPosition(UnityEngine.Vector3 position);
                /*0x3cd2e1c*/ void Dispose();
                /*0x3cd2e38*/ UnityEngine.Vector3 <SetFollowPosition>b__50_0();
                /*0x3cd2e68*/ void <SetFollowPosition>b__50_1(UnityEngine.Vector3 x);
                /*0x3cd2ec0*/ UnityEngine.Vector3 <SetFollowStaticPosition>b__51_0();
                /*0x3cd2ef0*/ void <SetFollowStaticPosition>b__51_1(UnityEngine.Vector3 x);
                /*0x3cd2f48*/ UnityEngine.Vector3 <SetLookAtPosition>b__52_0();
                /*0x3cd2f78*/ void <SetLookAtPosition>b__52_1(UnityEngine.Vector3 x);
                /*0x3cd2fd0*/ UnityEngine.Vector3 <SetLookAtStaticPosition>b__53_0();
                /*0x3cd3000*/ void <SetLookAtStaticPosition>b__53_1(UnityEngine.Vector3 x);
                /*0x3cd3058*/ UnityEngine.Vector3 <SetFocusLookAtPosition>b__54_0();
                /*0x3cd3088*/ void <SetFocusLookAtPosition>b__54_1(UnityEngine.Vector3 x);
                /*0x3cd30e0*/ UnityEngine.Vector3 <SetFocusFollowPosition>b__55_0();
                /*0x3cd3110*/ void <SetFocusFollowPosition>b__55_1(UnityEngine.Vector3 x);

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

                    /*0x3cd0728*/ <>c__DisplayClass19_0();
                    /*0x3cd3168*/ void <.ctor>b__0(bool value);
                    /*0x3cd3184*/ void <.ctor>b__1(bool value);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x18*/ UnityEngine.Transform target;

                    /*0x3cd1ff8*/ <>c__DisplayClass45_0();
                    /*0x3cd326c*/ void <SetFollowTarget>b__0();
                }

                struct <ApplyCameraNoise>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x30*/ Assets.VisualEffectData.CameraNoiseParameters parameters;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cd32a0*/ void MoveNext();
                    /*0x3cd3b40*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cd3b4c*/ void MoveNext();
                    /*0x3cd4130*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PlaybackEntranceAnimation>d__38 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cd413c*/ void MoveNext();
                    /*0x3cd497c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PrepareEntranceAnimation>d__37 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CameraOverseer <>4__this;
                    /*0x30*/ UnityEngine.Animator <animator>5__2;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cd4988*/ void MoveNext();
                    /*0x3cd4ea0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cd4eac*/ void MoveNext();
                    /*0x3cd55b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICockpitOverseerUnityFacade
            {
                /*0x380cb08*/ void Clear();
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ICockpitOverseerUnityFacade.Arguments arguments);

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

                    /*0x3cd5660*/ Arguments();
                    /*0x3cd55c0*/ UnityEngine.Transform get_CockpitResultLayer();
                    /*0x3cd55c8*/ void set_CockpitResultLayer(UnityEngine.Transform value);
                    /*0x3cd55d0*/ UnityEngine.Transform get_MinimizedCockpitLayer();
                    /*0x3cd55d8*/ void set_MinimizedCockpitLayer(UnityEngine.Transform value);
                    /*0x3cd55e0*/ UnityEngine.CanvasGroup get_MinimizedCockpitUnderlay();
                    /*0x3cd55e8*/ void set_MinimizedCockpitUnderlay(UnityEngine.CanvasGroup value);
                    /*0x3cd55f0*/ UnityEngine.UI.Image get_MinimizedCockpitOverlay();
                    /*0x3cd55f8*/ void set_MinimizedCockpitOverlay(UnityEngine.UI.Image value);
                    /*0x3cd5600*/ Assets.Battle.Hud.CockpitPlaceholder[] get_CockpitViewPlaceholders();
                    /*0x3cd5608*/ void set_CockpitViewPlaceholders(Assets.Battle.Hud.CockpitPlaceholder[] value);
                    /*0x3cd5610*/ UnityEngine.UI.Image get_CockpitBackground();
                    /*0x3cd5618*/ void set_CockpitBackground(UnityEngine.UI.Image value);
                    /*0x3cd5620*/ Assets.Battle.Utilities.PunchData get_DamagePunchData();
                    /*0x3cd5628*/ void set_DamagePunchData(Assets.Battle.Utilities.PunchData value);
                    /*0x3cd5630*/ Assets.Battle.Utilities.ColorData get_DamageColorData();
                    /*0x3cd5638*/ void set_DamageColorData(Assets.Battle.Utilities.ColorData value);
                    /*0x3cd5640*/ Assets.Battle.Utilities.ColorData get_HealColorData();
                    /*0x3cd5648*/ void set_HealColorData(Assets.Battle.Utilities.ColorData value);
                    /*0x3cd5650*/ UnityEngine.UI.Image[] get_AdditionalAnimationTargets();
                    /*0x3cd5658*/ void set_AdditionalAnimationTargets(UnityEngine.UI.Image[] value);
                }
            }

            interface ICockpitOverseer
            {
                Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> CreateCockpit(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask SetUpResultPose(Assets.Battle.Actor actor);
                /*0x380d83c*/ void ShowMinimizedCockpit(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask PrepareCockpitView(Assets.Battle.Actor[] actors);
                /*0x380cb08*/ void ForceHideMinimizedCockpit();
                /*0x380d83c*/ void UpdateCockpitViewCount(Assets.Battle.Actor[] actors);
                /*0x380cdf0*/ void UpdateCockpitPlaceholdersSizeAndPosition(bool tween);
                /*0x380d83c*/ void AddActorToCockpitView(Assets.Battle.Actor actor);
                /*0x380d83c*/ void TryKillActor(Assets.Battle.Actor actor);
                /*0x380b9e8*/ Assets.Battle.Actor TryAcquireScreenLeftCockpitActor();
                /*0x380d83c*/ void TryUpdateStatus(Assets.Battle.Actor actor);
                /*0x380cb08*/ void ClearCockpitViewData();
                /*0x380d83c*/ void ClearCockpitViewData(Assets.Battle.Actor exclude);
                /*0x380cdf0*/ void SetCockpitViewVisibility(bool value);
                /*0x380cb08*/ void ClearPlacehodlers();
                /*0x380cb08*/ void ClearPlaceholderStatuses();
                /*0x380d83c*/ void PlaybackDamageAnimation(Assets.Battle.Actor actor);
                /*0x380cb08*/ void PlaybackHealAnimation();
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

                /*0x3cd5668*/ CockpitOverseer(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.AssetManagement.ISpineAssetProvider spineAssetProvider);
                /*0x3cd57c8*/ void Initialize(Assets.Battle.Overseers.ICockpitOverseerUnityFacade.Arguments arguments);
                /*0x3cd5a0c*/ void SetCockpitViewVisibility(bool value);
                /*0x3cd5a68*/ void ShowMinimizedCockpit(Assets.Battle.Actor actor);
                /*0x3cd5ac8*/ void ShowMinimizedCockpit(Assets.Utilities.Spine.SkeletonController cockpit);
                /*0x3cd5ffc*/ void ForceHideMinimizedCockpit();
                /*0x3cd6114*/ Assets.Battle.Actor TryAcquireScreenLeftCockpitActor();
                /*0x3cd62b4*/ void ClearCockpitViewData();
                /*0x3cd62bc*/ void ClearCockpitViewData(Assets.Battle.Actor exclude);
                /*0x3cd65ec*/ void ClearPlacehodlers();
                /*0x3cd6940*/ Cysharp.Threading.Tasks.UniTask SetUpResultPose(Assets.Battle.Actor actor);
                /*0x3cd6a10*/ Cysharp.Threading.Tasks.UniTask PrepareCockpitView(Assets.Battle.Actor[] actors);
                /*0x3cd6ae0*/ void UpdateCockpitViewCount(Assets.Battle.Actor[] actors);
                /*0x3cd6c50*/ void UpdateCockpitPlaceholdersSizeAndPosition(bool tween);
                /*0x3cd6f64*/ void AddActorToCockpitView(Assets.Battle.Actor actor);
                /*0x3cd6648*/ void ClearPlaceholder(Assets.Battle.Hud.CockpitPlaceholder placeholder);
                /*0x3cd76f0*/ void ClearPlaceholderStatuses();
                /*0x3cd7750*/ void TryUpdateStatus(Assets.Battle.Actor actor);
                /*0x3cd78f8*/ void PlaybackDamageAnimation(Assets.Battle.Actor actor);
                /*0x3cd7d58*/ void PlaybackHealAnimation();
                /*0x3cd7f4c*/ void TryKillActor(Assets.Battle.Actor actor);
                /*0x3cd74bc*/ void AssignToPlaceholder(Assets.Battle.Actor actor, Assets.Battle.Hud.CockpitPlaceholder placeholder);
                /*0x3cd806c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> CreateCockpit(Assets.Battle.Actor actor);
                /*0x3cd8184*/ void Clear();
                /*0x3cd8254*/ void Dispose();
                /*0x3cd8290*/ void <Initialize>b__20_0(bool value);

                class CockpitViewData
                {
                    /*0x10*/ Assets.Battle.Actor <Actor>k__BackingField;
                    /*0x18*/ Assets.Battle.Hud.CockpitPlaceholder <Placeholder>k__BackingField;
                    /*0x20*/ System.DateTime <LastUpdated>k__BackingField;

                    /*0x3cd7424*/ CockpitViewData(Assets.Battle.Actor actor, Assets.Battle.Hud.CockpitPlaceholder placeholder);
                    /*0x3cd8428*/ Assets.Battle.Actor get_Actor();
                    /*0x3cd8430*/ Assets.Battle.Hud.CockpitPlaceholder get_Placeholder();
                    /*0x3cd8438*/ void set_Placeholder(Assets.Battle.Hud.CockpitPlaceholder value);
                    /*0x3cd8440*/ System.DateTime get_LastUpdated();
                    /*0x3cd8448*/ void set_LastUpdated(System.DateTime value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Overseers.CockpitOverseer.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Hud.CockpitPlaceholder, bool> <>9__31_0;
                    static /*0x10*/ System.Func<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData, bool> <>9__32_0;
                    static /*0x18*/ System.Func<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData, bool> <>9__33_1;
                    static /*0x20*/ System.Func<Assets.Battle.Overseers.CockpitOverseer.CockpitViewData, System.DateTime> <>9__33_2;

                    static /*0x3cd8450*/ <>c();
                    /*0x3cd84b8*/ <>c();
                    /*0x3cd84c0*/ bool <UpdateCockpitViewCount>b__31_0(Assets.Battle.Hud.CockpitPlaceholder c);
                    /*0x3cd854c*/ bool <UpdateCockpitPlaceholdersSizeAndPosition>b__32_0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                    /*0x3cd8574*/ bool <AddActorToCockpitView>b__33_1(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                    /*0x3cd8594*/ System.DateTime <AddActorToCockpitView>b__33_2(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x18*/ Assets.Utilities.Spine.SkeletonController oldCockpit;

                    /*0x3cd5ff4*/ <>c__DisplayClass23_0();
                    /*0x3cd85ac*/ void <ShowMinimizedCockpit>b__0();
                }

                class <>c__DisplayClass33_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3cd741c*/ <>c__DisplayClass33_0();
                    /*0x3cd86e0*/ bool <AddActorToCockpitView>b__0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                class <>c__DisplayClass37_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3cd7d50*/ <>c__DisplayClass37_0();
                    /*0x3cd8710*/ bool <PlaybackDamageAnimation>b__0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                class <>c__DisplayClass39_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3cd8064*/ <>c__DisplayClass39_0();
                    /*0x3cd8740*/ bool <TryKillActor>b__0(Assets.Battle.Overseers.CockpitOverseer.CockpitViewData c);
                }

                struct <CreateCockpit>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x38*/ Assets.Battle.Actor actor;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>u__1;

                    /*0x3cd8770*/ void MoveNext();
                    /*0x3cd8de0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <PrepareCockpitView>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor[] actors;
                    /*0x30*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cd8e38*/ void MoveNext();
                    /*0x3cd97d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SetUpResultPose>d__29 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Overseers.CockpitOverseer <>4__this;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cd97e0*/ void MoveNext();
                    /*0x3cda128*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ICombatTextOverseerUnityFacade
            {
                Cysharp.Threading.Tasks.UniTask FireCombatText(UnityEngine.Vector3 position, string text, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize, Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType);
                Cysharp.Threading.Tasks.UniTask FireDamageText(UnityEngine.Vector3 position, string value, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                Cysharp.Threading.Tasks.UniTask FireShieldDamageText(UnityEngine.Vector3 position, string value, string shieldValue, string additionalValue, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite, float scale);
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ICombatTextOverseerUnityFacade.Arguments arguments);

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

                    /*0x3cda1b4*/ Arguments();
                    /*0x3cda134*/ UnityEngine.Transform get_CombatTextLayer();
                    /*0x3cda13c*/ void set_CombatTextLayer(UnityEngine.Transform value);
                    /*0x3cda144*/ UnityEngine.Material get_CriticalMaterial();
                    /*0x3cda14c*/ void set_CriticalMaterial(UnityEngine.Material value);
                    /*0x3cda154*/ UnityEngine.Material get_MissMaterial();
                    /*0x3cda15c*/ void set_MissMaterial(UnityEngine.Material value);
                    /*0x3cda164*/ UnityEngine.Material get_NormalMaterial();
                    /*0x3cda16c*/ void set_NormalMaterial(UnityEngine.Material value);
                    /*0x3cda174*/ UnityEngine.Material get_ResistMaterial();
                    /*0x3cda17c*/ void set_ResistMaterial(UnityEngine.Material value);
                    /*0x3cda184*/ UnityEngine.Material get_WeakMaterial();
                    /*0x3cda18c*/ void set_WeakMaterial(UnityEngine.Material value);
                    /*0x3cda194*/ UnityEngine.Material get_HealMaterial();
                    /*0x3cda19c*/ void set_HealMaterial(UnityEngine.Material value);
                    /*0x3cda1a4*/ Assets.Battle.Hud.TotalDamageView get_TotalDamageView();
                    /*0x3cda1ac*/ void set_TotalDamageView(Assets.Battle.Hud.TotalDamageView value);
                }
            }

            interface ICombatTextOverseer
            {
                Cysharp.Threading.Tasks.UniTask FireCombatText(UnityEngine.Vector3 position, string text, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize, Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType);
                Cysharp.Threading.Tasks.UniTask FireDamageText(UnityEngine.Vector3 position, string value, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask FireMultipleDamageTexts(UnityEngine.Vector3 position, int hitCount, long damage, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                Cysharp.Threading.Tasks.UniTask FireShieldDamageText(UnityEngine.Vector3 position, string value, string shieldValue, string additionalValue, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite, float scale);
                /*0x380cdf0*/ void RecordTotalDamage(bool value);
                /*0x380cb08*/ void ResetTotalDamage();
                /*0x380cb08*/ void ResetTotalDamageSource();
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

                /*0x3cda1bc*/ CombatTextOverseer(Assets.Battle.ICache cahce, Assets.AssetManagement.ITextureAssetProvider textureAssetProvider, Assets.AssetManagement.IAddressablesAssetProvider addressablesAssetProvider);
                /*0x3cda21c*/ void Initialize(Assets.Battle.Overseers.ICombatTextOverseerUnityFacade.Arguments arguments);
                /*0x3cda2b8*/ void ResetTotalDamage();
                /*0x3cda2d4*/ void ResetTotalDamageSource();
                /*0x3cda2e0*/ void UpdateTotalDamage(Assets.Api.Client.PawnId source, long damage, int hitCount);
                /*0x3cda388*/ void RecordTotalDamage(bool value);
                /*0x3cda394*/ Cysharp.Threading.Tasks.UniTask FireMultipleDamageTexts(UnityEngine.Vector3 position, int hitCount, long damage, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                /*0x3cda4b8*/ Cysharp.Threading.Tasks.UniTask FireShieldDamageText(UnityEngine.Vector3 position, string value, string shieldValue, string additionalValue, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, Assets.Battle.Overseers.CombatTextOverseer.SpriteTypes sprite, float scale);
                /*0x3cda5f4*/ Cysharp.Threading.Tasks.UniTask FireDamageText(UnityEngine.Vector3 position, string value, string label, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize);
                /*0x3cda718*/ Cysharp.Threading.Tasks.UniTask FireCombatText(UnityEngine.Vector3 position, string text, Assets.Battle.Overseers.CombatTextOverseer.FontTypes font, int fontSize, Assets.Battle.Overseers.CombatTextOverseer.MotionTypes motionType);
                /*0x3cda828*/ UnityEngine.Material AquireMaterial(Assets.Battle.Overseers.CombatTextOverseer.FontTypes type);
                /*0x3cda880*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Material> AquireSpriteMaterial(Assets.Battle.Overseers.CombatTextOverseer.FontTypes type);

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

                    /*0x3cdac08*/ <>c__DisplayClass20_0();
                    /*0x3cdac10*/ void <FireShieldDamageText>b__0();
                }

                class <>c__DisplayClass21_0
                {
                    /*0x10*/ Assets.Battle.Hud.DamageText damageText;

                    /*0x3cdac3c*/ <>c__DisplayClass21_0();
                    /*0x3cdac44*/ void <FireDamageText>b__0();
                }

                class <>c__DisplayClass22_0
                {
                    /*0x10*/ Assets.Battle.Hud.DamageText damageText;

                    /*0x3cdac70*/ <>c__DisplayClass22_0();
                    /*0x3cdac78*/ void <FireCombatText>b__0();
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

                    /*0x3cdaca4*/ void MoveNext();
                    /*0x3cdb934*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cdb940*/ void MoveNext();
                    /*0x3cdc6d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cdc6dc*/ void MoveNext();
                    /*0x3cdcba4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cdcbb0*/ void MoveNext();
                    /*0x3cde33c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IFieldOverseerUnityFacade
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IFieldOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <FieldParent>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <FieldCenter>k__BackingField;
                    /*0x20*/ UnityEngine.Transform <PlayerGroupCenter>k__BackingField;
                    /*0x28*/ UnityEngine.Transform <EnemyGroupCenter>k__BackingField;

                    /*0x3cde388*/ Arguments();
                    /*0x3cde348*/ UnityEngine.Transform get_FieldParent();
                    /*0x3cde350*/ void set_FieldParent(UnityEngine.Transform value);
                    /*0x3cde358*/ UnityEngine.Transform get_FieldCenter();
                    /*0x3cde360*/ void set_FieldCenter(UnityEngine.Transform value);
                    /*0x3cde368*/ UnityEngine.Transform get_PlayerGroupCenter();
                    /*0x3cde370*/ void set_PlayerGroupCenter(UnityEngine.Transform value);
                    /*0x3cde378*/ UnityEngine.Transform get_EnemyGroupCenter();
                    /*0x3cde380*/ void set_EnemyGroupCenter(UnityEngine.Transform value);
                }
            }

            interface IFieldOverseer
            {
                /*0x380cad0*/ UnityEngine.Vector3 AcquireFieldCenterPosition();
                /*0x380b9e8*/ UnityEngine.Material[] AcquireFieldMaterials();
                UnityEngine.Vector3 AcquireGroupCenterPosition(bool isEnemyGroup);
                Cysharp.Threading.Tasks.UniTask LoadField(string configurationJson);
                /*0x380cdf0*/ void SetActive(bool active);
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

                /*0x3cde390*/ FieldOverseer(Assets.Battle.ICache cache, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer);
                /*0x3cde448*/ void Initialize(Assets.Battle.Overseers.IFieldOverseerUnityFacade.Arguments arguments);
                /*0x3cde4a4*/ UnityEngine.Vector3 AcquireFieldCenterPosition();
                /*0x3cde4c0*/ UnityEngine.Vector3 AcquireGroupCenterPosition(bool isEnemyGroup);
                /*0x3cde4e8*/ void SetActive(bool active);
                /*0x3cde580*/ Cysharp.Threading.Tasks.UniTask LoadField(string configurationJson);
                /*0x3cde654*/ Cysharp.Threading.Tasks.UniTask LoadFieldVisualEffects(Assets.Battle.Overseers.FieldOverseer.Configuration configuration);
                /*0x3cdea64*/ UnityEngine.Material[] AcquireFieldMaterials();
                /*0x3cdf0d8*/ void <LoadFieldVisualEffects>b__14_0(Assets.VisualEffectData.VfxHandler vfx);

                class Configuration
                {
                    /*0x10*/ string <FieldAssetId>k__BackingField;
                    /*0x18*/ string[] <FieldVisualEffectsAssetIds>k__BackingField;

                    /*0x3cdf1f8*/ Configuration();
                    /*0x3cdf2c4*/ Configuration(string configurationJson);
                    /*0x3cdf1d8*/ string get_FieldAssetId();
                    /*0x3cdf1e0*/ void set_FieldAssetId(string value);
                    /*0x3cdf1e8*/ string[] get_FieldVisualEffectsAssetIds();
                    /*0x3cdf1f0*/ void set_FieldVisualEffectsAssetIds(string[] value);
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

                    /*0x3cdf570*/ void MoveNext();
                    /*0x3ce0114*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IHudOverseerUnityFacade
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x380cdf0*/ void SetHudActive(bool active);
                /*0x380cdf0*/ void SetIntractability(bool interactable);
                /*0x380cdf0*/ void SetLocksActive(bool active);

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

                    /*0x3ce04f8*/ Arguments();
                    /*0x3ce0120*/ UnityEngine.UI.Image get_OverlayFade();
                    /*0x3ce0128*/ void set_OverlayFade(UnityEngine.UI.Image value);
                    /*0x3ce0130*/ UnityEngine.GameObject get_PlayerPauseLabel();
                    /*0x3ce0138*/ void set_PlayerPauseLabel(UnityEngine.GameObject value);
                    /*0x3ce0140*/ UnityEngine.GameObject get_EnemyPauseLabel();
                    /*0x3ce0148*/ void set_EnemyPauseLabel(UnityEngine.GameObject value);
                    /*0x3ce0150*/ UnityEngine.GameObject get_PauseHeader();
                    /*0x3ce0158*/ void set_PauseHeader(UnityEngine.GameObject value);
                    /*0x3ce0160*/ UnityEngine.GameObject get_PauseFade();
                    /*0x3ce0168*/ void set_PauseFade(UnityEngine.GameObject value);
                    /*0x3ce0170*/ Assets.Battle.Hud.PositionLegend get_PositionLegend();
                    /*0x3ce0178*/ void set_PositionLegend(Assets.Battle.Hud.PositionLegend value);
                    /*0x3ce0180*/ Assets.Battle.Hud.BossHealthGauge get_BossHealthGauge();
                    /*0x3ce0188*/ void set_BossHealthGauge(Assets.Battle.Hud.BossHealthGauge value);
                    /*0x3ce0190*/ Assets.Battle.Hud.CombinedGauge get_TeamHealthGauge();
                    /*0x3ce0198*/ void set_TeamHealthGauge(Assets.Battle.Hud.CombinedGauge value);
                    /*0x3ce01a0*/ Assets.Battle.Hud.ActionQueue get_ActionQueue();
                    /*0x3ce01a8*/ void set_ActionQueue(Assets.Battle.Hud.ActionQueue value);
                    /*0x3ce01b0*/ TMPro.TextMeshProUGUI get_TurnText();
                    /*0x3ce01b8*/ void set_TurnText(TMPro.TextMeshProUGUI value);
                    /*0x3ce01c0*/ TMPro.TextMeshProUGUI get_QuestText();
                    /*0x3ce01c8*/ void set_QuestText(TMPro.TextMeshProUGUI value);
                    /*0x3ce01d0*/ UnityEngine.UI.Button get_SkipButton();
                    /*0x3ce01d8*/ void set_SkipButton(UnityEngine.UI.Button value);
                    /*0x3ce01e0*/ UnityEngine.UI.Button get_SkipLock();
                    /*0x3ce01e8*/ void set_SkipLock(UnityEngine.UI.Button value);
                    /*0x3ce01f0*/ UnityEngine.UI.Button get_SpeedButton();
                    /*0x3ce01f8*/ void set_SpeedButton(UnityEngine.UI.Button value);
                    /*0x3ce0200*/ UnityEngine.UI.Button get_PauseButton();
                    /*0x3ce0208*/ void set_PauseButton(UnityEngine.UI.Button value);
                    /*0x3ce0210*/ UnityEngine.UI.Button get_ClosePauseButton();
                    /*0x3ce0218*/ void set_ClosePauseButton(UnityEngine.UI.Button value);
                    /*0x3ce0220*/ UnityEngine.UI.Button get_CameraChangeButton();
                    /*0x3ce0228*/ void set_CameraChangeButton(UnityEngine.UI.Button value);
                    /*0x3ce0230*/ UnityEngine.UI.Button get_CockpitViewChangeButton();
                    /*0x3ce0238*/ void set_CockpitViewChangeButton(UnityEngine.UI.Button value);
                    /*0x3ce0240*/ TMPro.TextMeshProUGUI get_SpeedButtonLabel();
                    /*0x3ce0248*/ void set_SpeedButtonLabel(TMPro.TextMeshProUGUI value);
                    /*0x3ce0250*/ Assets.Battle.Hud.SkillNameLabel get_SkillNameLabel();
                    /*0x3ce0258*/ void set_SkillNameLabel(Assets.Battle.Hud.SkillNameLabel value);
                    /*0x3ce0260*/ UnityEngine.GameObject get_HudLayer();
                    /*0x3ce0268*/ void set_HudLayer(UnityEngine.GameObject value);
                    /*0x3ce0270*/ Assets.Battle.Hud.TurnView get_TurnView();
                    /*0x3ce0278*/ void set_TurnView(Assets.Battle.Hud.TurnView value);
                    /*0x3ce0280*/ UnityEngine.Transform get_PlayerActorIconsGroup();
                    /*0x3ce0288*/ void set_PlayerActorIconsGroup(UnityEngine.Transform value);
                    /*0x3ce0290*/ UnityEngine.Transform get_EnemyActorIconsGroup();
                    /*0x3ce0298*/ void set_EnemyActorIconsGroup(UnityEngine.Transform value);
                    /*0x3ce02a0*/ UnityEngine.Transform get_PlayerActorStatusIconsGroup();
                    /*0x3ce02a8*/ void set_PlayerActorStatusIconsGroup(UnityEngine.Transform value);
                    /*0x3ce02b0*/ UnityEngine.Transform get_EnemyActorStatusIconsGroup();
                    /*0x3ce02b8*/ void set_EnemyActorStatusIconsGroup(UnityEngine.Transform value);
                    /*0x3ce02c0*/ UnityEngine.Transform get_WorldCanvas();
                    /*0x3ce02c8*/ void set_WorldCanvas(UnityEngine.Transform value);
                    /*0x3ce02d0*/ Assets.Battle.Hud.ResultNavigation get_ResultNavigation();
                    /*0x3ce02d8*/ void set_ResultNavigation(Assets.Battle.Hud.ResultNavigation value);
                    /*0x3ce02e0*/ Assets.Battle.Hud.ResultBackground get_ResultBackground();
                    /*0x3ce02e8*/ void set_ResultBackground(Assets.Battle.Hud.ResultBackground value);
                    /*0x3ce02f0*/ Assets.Battle.Hud.ResultRewardsView get_ResultRewardsView();
                    /*0x3ce02f8*/ void set_ResultRewardsView(Assets.Battle.Hud.ResultRewardsView value);
                    /*0x3ce0300*/ Assets.Battle.Hud.ResultLevelProgress get_ResultLevelProgress();
                    /*0x3ce0308*/ void set_ResultLevelProgress(Assets.Battle.Hud.ResultLevelProgress value);
                    /*0x3ce0318*/ Assets.Battle.Hud.ResultRankProgress get_ResultRankProgress();
                    /*0x3ce0320*/ void set_ResultRankProgress(Assets.Battle.Hud.ResultRankProgress value);
                    /*0x3ce0330*/ Assets.Battle.Hud.ResultDamageView get_ResultDamageView();
                    /*0x3ce0338*/ void set_ResultDamageView(Assets.Battle.Hud.ResultDamageView value);
                    /*0x3ce0348*/ UnityEngine.Transform get_NavigationParentLayer();
                    /*0x3ce0350*/ void set_NavigationParentLayer(UnityEngine.Transform value);
                    /*0x3ce0360*/ UnityEngine.Transform get_NavigationOverlayParentLayer();
                    /*0x3ce0368*/ void set_NavigationOverlayParentLayer(UnityEngine.Transform value);
                    /*0x3ce0378*/ UnityEngine.Transform get_NavigationHud();
                    /*0x3ce0380*/ void set_NavigationHud(UnityEngine.Transform value);
                    /*0x3ce0390*/ UnityEngine.Transform get_ResultLayerParentAnchor();
                    /*0x3ce0398*/ void set_ResultLayerParentAnchor(UnityEngine.Transform value);
                    /*0x3ce03a8*/ UnityEngine.Transform get_BottomHud();
                    /*0x3ce03b0*/ void set_BottomHud(UnityEngine.Transform value);
                    /*0x3ce03c0*/ UnityEngine.Transform get_BottomOverlayHud();
                    /*0x3ce03c8*/ void set_BottomOverlayHud(UnityEngine.Transform value);
                    /*0x3ce03d8*/ UnityEngine.Transform get_BottomHudParentLowAnchor();
                    /*0x3ce03e0*/ void set_BottomHudParentLowAnchor(UnityEngine.Transform value);
                    /*0x3ce03f0*/ UnityEngine.Transform get_BottomHudParentHightAnchor();
                    /*0x3ce03f8*/ void set_BottomHudParentHightAnchor(UnityEngine.Transform value);
                    /*0x3ce0408*/ UnityEngine.Transform get_BottomHudOverlayParentLowAnchor();
                    /*0x3ce0410*/ void set_BottomHudOverlayParentLowAnchor(UnityEngine.Transform value);
                    /*0x3ce0420*/ UnityEngine.Transform get_BottomHudOverlayParentHightAnchor();
                    /*0x3ce0428*/ void set_BottomHudOverlayParentHightAnchor(UnityEngine.Transform value);
                    /*0x3ce0438*/ Assets.Battle.Hud.ActorDetails get_ActorDetails();
                    /*0x3ce0440*/ void set_ActorDetails(Assets.Battle.Hud.ActorDetails value);
                    /*0x3ce0450*/ UnityEngine.UI.Button get_CloseActorDetailsButton();
                    /*0x3ce0458*/ void set_CloseActorDetailsButton(UnityEngine.UI.Button value);
                    /*0x3ce0468*/ UnityEngine.UI.Button get_ActorDetailsRightScrollButton();
                    /*0x3ce0470*/ void set_ActorDetailsRightScrollButton(UnityEngine.UI.Button value);
                    /*0x3ce0480*/ UnityEngine.UI.Button get_ActorDetailsLeftScrollButton();
                    /*0x3ce0488*/ void set_ActorDetailsLeftScrollButton(UnityEngine.UI.Button value);
                    /*0x3ce0498*/ UnityEngine.UI.Button get_SpeedLock();
                    /*0x3ce04a0*/ void set_SpeedLock(UnityEngine.UI.Button value);
                    /*0x3ce04b0*/ UnityEngine.UI.Button get_CameraChangeLock();
                    /*0x3ce04b8*/ void set_CameraChangeLock(UnityEngine.UI.Button value);
                    /*0x3ce04c8*/ UnityEngine.UI.Button get_CockpitViewChangeLock();
                    /*0x3ce04d0*/ void set_CockpitViewChangeLock(UnityEngine.UI.Button value);
                    /*0x3ce04e0*/ Assets.Battle.Hud.MvpDataView get_MvpDataView();
                    /*0x3ce04e8*/ void set_MvpDataView(Assets.Battle.Hud.MvpDataView value);
                }
            }

            interface IHudOverseer
            {
                /*0x380b9e8*/ UnityEngine.Events.UnityEvent get_OnUiButtonClicked();
                Cysharp.Threading.Tasks.UniTask OverlayFadeFadeIn(float duration);
                Cysharp.Threading.Tasks.UniTask OverlayFadeFadeOut(float duration);
                /*0x380d83c*/ void AddToLegend(Assets.Api.Client.PawnView pawn);
                /*0x380cb08*/ void AdvanceActionQueue();
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusIcon> CreateActorStatusIcon(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorWorldStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                Cysharp.Threading.Tasks.UniTask InitializeBossGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool showScoreView);
                Cysharp.Threading.Tasks.UniTask PlaybackTurnAnimation(int turn, int turnsCount);
                /*0x380cdf0*/ void SetHudActive(bool active);
                /*0x380cdf0*/ void SetIntractability(bool interactable);
                /*0x380cdf0*/ void SetTeamHealthGaugeState(bool active);
                /*0x380d12c*/ void ShowResultBackground(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, System.Action onFadeComplete);
                Cysharp.Threading.Tasks.UniTask ShowResultDamageView(string rankData, string damage, string damagePercentage, bool newRecord, bool showPercentage);
                Cysharp.Threading.Tasks.UniTask ShowResultLevelProgress(Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments);
                /*0x380d0e4*/ void ShowResultNavigation(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType);
                Cysharp.Threading.Tasks.UniTask ShowResultRankProgress(int currentPoints, int maxPoints, int rank);
                Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.Icon.IconBase.IconArgs[] rewards);
                Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs[] rewards);
                void ShowSkillLabel(string skillName, bool isEnemyActor, Assets.Api.Client.SkillTypes skillType, int pointAmount);
                Cysharp.Threading.Tasks.UniTask UpdateActionQueue(Assets.Battle.Actor[] actors);
                void UpdateActorsIconPositions(Assets.Battle.Actor[] actors, bool isEnemyIcons);
                /*0x380d93c*/ void UpdateBossHealthGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x380d438*/ void UpdateBossScoreValue(long value);
                Cysharp.Threading.Tasks.UniTask UpdateTeamHealthGauge(long leftCurrent, long leftMax, long rightCurrent, long rightMax);
                /*0x380cdf0*/ void SetSkipAvaiability(bool available);
                /*0x380cdf0*/ void ChangeCockpitViewHudActive(bool value);
                /*0x380b6a0*/ Assets.Battle.Hud.CombinedGauge.StateTypes GetCurrentTeamHealthGaugeState();
                /*0x380cb08*/ void HideBossGauge();
                /*0x380cb08*/ void Clear();
                void SetIconsInIconGroupActive(bool active, bool isEnemyGroup);
                /*0x380cdf0*/ void SetSpeedAvaiability(bool available);
                /*0x380cdf0*/ void SetCameraChangeAvaiability(bool available);
                /*0x380cdf0*/ void SetCockpitViewChangeAvaiability(bool available);
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

                /*0x3ce0508*/ HudOverseer(Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.Battle.ICache cache, Assets.GameUi.Externals.IAudioManager audioManager, Assets.AssetManagement.ITextureAssetProvider textureAssetProvider, Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3ce0500*/ UnityEngine.Events.UnityEvent get_OnUiButtonClicked();
                /*0x3ce06a4*/ void Initialize(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x3ce0d54*/ void InitializeSubscriptions(Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments);
                /*0x3ce151c*/ void ShowMvpDataView(Assets.GameUi.BattleArguments.BattleTypes battleType, Assets.Api.Client.PawnId attacker, Assets.Api.Client.PawnId defender, Assets.Api.Client.PawnId healer);
                /*0x3ce15a0*/ void SetTeamHealthGaugeState(bool active);
                /*0x3ce15c0*/ Cysharp.Threading.Tasks.UniTask UpdateTeamHealthGauge(long leftCurrent, long leftMax, long rightCurrent, long rightMax);
                /*0x3ce15e4*/ Assets.Battle.Hud.CombinedGauge.StateTypes GetCurrentTeamHealthGaugeState();
                /*0x3ce1600*/ void AddToLegend(Assets.Api.Client.PawnView pawn);
                /*0x3ce161c*/ void HideBossGauge();
                /*0x3ce1648*/ Cysharp.Threading.Tasks.UniTask InitializeBossGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool showScoreView);
                /*0x3ce174c*/ void UpdateBossHealthGauge(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3ce1768*/ void UpdateBossScoreValue(long value);
                /*0x3ce0aa4*/ void InitializeButtons();
                /*0x3ce1784*/ void SetHudActive(bool active);
                /*0x3ce17a4*/ void SetLocksActive(bool active);
                /*0x3ce17ec*/ void SetSkipAvaiability(bool available);
                /*0x3ce184c*/ void SetSpeedAvaiability(bool available);
                /*0x3ce18ac*/ void SetCameraChangeAvaiability(bool available);
                /*0x3ce190c*/ void SetCockpitViewChangeAvaiability(bool available);
                /*0x3ce196c*/ void SetPauseMenuActive(bool active);
                /*0x3ce1b04*/ Cysharp.Threading.Tasks.UniTask PlaybackTurnAnimation(int turn, int turnsCount);
                /*0x3ce1398*/ void SetIntractability(bool interactable);
                /*0x3ce1b20*/ void ShowSkillLabel(string skillName, bool isEnemyActor, Assets.Api.Client.SkillTypes skillType, int pointAmount);
                /*0x3ce1b48*/ Cysharp.Threading.Tasks.UniTask OverlayFadeFadeIn(float duration);
                /*0x3ce1bb4*/ Cysharp.Threading.Tasks.UniTask OverlayFadeFadeOut(float duration);
                /*0x3ce1c1c*/ Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.Icon.IconBase.IconArgs[] rewards);
                /*0x3ce1c6c*/ Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs[] rewards);
                /*0x3ce1cbc*/ void ShowResultBackground(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, System.Action onFadeComplete);
                /*0x3ce1cd8*/ void ShowResultNavigation(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType);
                /*0x3ce1db4*/ Cysharp.Threading.Tasks.UniTask ShowResultLevelProgress(Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments);
                /*0x3ce1e04*/ Cysharp.Threading.Tasks.UniTask ShowResultRankProgress(int currentPoints, int maxPoints, int rank);
                /*0x3ce1e6c*/ Cysharp.Threading.Tasks.UniTask ShowResultDamageView(string rankData, string damage, string damagePercentage, bool newRecord, bool showPercentage);
                /*0x3ce1eec*/ void ProcessCockpitViewButtonClick();
                /*0x3ce2050*/ void ProcessCameraChangeButtonClick();
                /*0x3ce2228*/ void ProcessPauseButtonClick();
                /*0x3ce2514*/ void UpdateEnemyActorIconsGroupTransform();
                /*0x3ce282c*/ void SetIconsInIconGroupActive(bool active, bool isEnemyGroup);
                /*0x3ce26f8*/ void ChangeCockpitViewHudActive(bool value);
                /*0x3ce26ac*/ void RestoreParentRelations();
                /*0x3ce2dc0*/ void ProcessCloseActorDetailsClick();
                /*0x3ce3120*/ void ProcessSkipButtonClick();
                /*0x3ce31e0*/ void ProcessSpeedButtonClick();
                /*0x3ce3294*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorWorldStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3ce33d0*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusView> CreateActorStatusView(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3ce3500*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActorStatusIcon> CreateActorStatusIcon(Assets.Battle.Actor actor);
                /*0x3ce3618*/ void UpdateActorsIconPositions(Assets.Battle.Actor[] actors, bool isEnemyIcons);
                /*0x3ce37d4*/ void Clear();
                /*0x3ce3964*/ Cysharp.Threading.Tasks.UniTask UpdateActionQueue(Assets.Battle.Actor[] actors);
                /*0x3ce3980*/ void AdvanceActionQueue();
                /*0x3ce399c*/ void Dispose();
                /*0x3ce39b8*/ void <InitializeButtons>b__72_0();
                /*0x3ce39bc*/ void <InitializeButtons>b__72_1();
                /*0x3ce39c0*/ void <InitializeButtons>b__72_2();
                /*0x3ce39c4*/ void <InitializeButtons>b__72_3();
                /*0x3ce39c8*/ void <InitializeButtons>b__72_4();
                /*0x3ce39cc*/ void <InitializeButtons>b__72_5();
                /*0x3ce39d0*/ void <InitializeButtons>b__72_6();

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Overseers.HudOverseer.<> <>9;
                    static /*0x8*/ System.Action<float> <>9__62_1;
                    static /*0x10*/ System.Func<Assets.Battle.Actor, int> <>9__103_1;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, int> <>9__105_0;

                    static /*0x3ce39d4*/ <>c();
                    /*0x3ce3a3c*/ <>c();
                    /*0x3ce3a44*/ void <InitializeSubscriptions>b__62_1(float speed);
                    /*0x3ce3a4c*/ int <CreateActorStatusView>b__103_1(Assets.Battle.Actor a);
                    /*0x3ce3a64*/ int <UpdateActorsIconPositions>b__105_0(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass103_0
                {
                    /*0x10*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x18*/ Assets.Battle.Actor actor;

                    /*0x3ce3a7c*/ <>c__DisplayClass103_0();
                    /*0x3ce3a84*/ void <CreateActorStatusView>b__0();
                }

                class <>c__DisplayClass103_1
                {
                    /*0x10*/ Assets.Battle.Actor[] relatedActors;
                    /*0x18*/ int index;
                    /*0x20*/ Assets.Battle.Overseers.HudOverseer.<> CS$<>8__locals1;

                    /*0x3ce4108*/ <>c__DisplayClass103_1();
                    /*0x3ce4110*/ void <CreateActorStatusView>b__2();
                    /*0x3ce417c*/ void <CreateActorStatusView>b__3();
                }

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ Assets.Battle.Overseers.IHudOverseerUnityFacade.Arguments arguments;
                    /*0x18*/ Assets.Battle.Overseers.HudOverseer <>4__this;

                    /*0x3ce1514*/ <>c__DisplayClass62_0();
                    /*0x3ce41e4*/ void <InitializeSubscriptions>b__0(int speed);
                    /*0x3ce4288*/ void <InitializeSubscriptions>b__2(System.ValueTuple<int, int> value);
                    /*0x3ce4350*/ void <InitializeSubscriptions>b__3(string quest);
                    /*0x3ce437c*/ void <InitializeSubscriptions>b__4(bool value);
                    /*0x3ce4398*/ void <InitializeSubscriptions>b__5(bool value);
                }

                struct <CreateActorStatusIcon>d__104 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Battle.Hud.ActorStatusIcon> <>t__builder;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Assets.Battle.Overseers.HudOverseer <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Battle.Hud.ActorStatusIcon> <>u__1;

                    /*0x3ce4454*/ void MoveNext();
                    /*0x3ce4afc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3ce4b54*/ void MoveNext();
                    /*0x3ce5754*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3ce57ac*/ void MoveNext();
                    /*0x3ce6414*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3ce7f38*/ void MoveNext();
                    /*0x3ce8420*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ILayoutOverseerUnityFacade
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ILayoutOverseerUnityFacade.Arguments arguments);

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <CinemachineLayer>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <ActorsLayer>k__BackingField;
                    /*0x20*/ UnityEngine.Transform <FieldLayer>k__BackingField;

                    /*0x3ce845c*/ Arguments();
                    /*0x3ce842c*/ UnityEngine.Transform get_CinemachineLayer();
                    /*0x3ce8434*/ void set_CinemachineLayer(UnityEngine.Transform value);
                    /*0x3ce843c*/ UnityEngine.Transform get_ActorsLayer();
                    /*0x3ce8444*/ void set_ActorsLayer(UnityEngine.Transform value);
                    /*0x3ce844c*/ UnityEngine.Transform get_FieldLayer();
                    /*0x3ce8454*/ void set_FieldLayer(UnityEngine.Transform value);
                }
            }

            interface ILayoutOverseer
            {
                /*0x380b9e8*/ UnityEngine.Transform get_ActorsLayer();
                /*0x380b9e8*/ UnityEngine.Transform get_CinemachineLayer();
                /*0x380b9e8*/ UnityEngine.Transform get_FieldLayer();
            }

            class LayoutOverseer : Assets.Battle.Overseers.ILayoutOverseer, Assets.Battle.Overseers.ILayoutOverseerUnityFacade
            {
                /*0x10*/ Assets.Battle.Overseers.ILayoutOverseerUnityFacade.Arguments arguments;

                /*0x3ce84c0*/ LayoutOverseer();
                /*0x3ce8464*/ UnityEngine.Transform get_CinemachineLayer();
                /*0x3ce8480*/ UnityEngine.Transform get_ActorsLayer();
                /*0x3ce849c*/ UnityEngine.Transform get_FieldLayer();
                /*0x3ce84b8*/ void Initialize(Assets.Battle.Overseers.ILayoutOverseerUnityFacade.Arguments arguments);
            }

            interface ITutorialOverseerUnityFacade
            {
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.ITutorialOverseerUnityFacade.Arguments arguments);

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

                    /*0x3ce8568*/ Arguments();
                    /*0x3ce84c8*/ UnityEngine.RectTransform get_FirstSlotHighlight();
                    /*0x3ce84d0*/ void set_FirstSlotHighlight(UnityEngine.RectTransform value);
                    /*0x3ce84d8*/ UnityEngine.RectTransform get_FirstSlotExtraGaugeHighlight();
                    /*0x3ce84e0*/ void set_FirstSlotExtraGaugeHighlight(UnityEngine.RectTransform value);
                    /*0x3ce84e8*/ UnityEngine.RectTransform get_ResultTips();
                    /*0x3ce84f0*/ void set_ResultTips(UnityEngine.RectTransform value);
                    /*0x3ce84f8*/ UnityEngine.RectTransform get_ActorsOrderList();
                    /*0x3ce8500*/ void set_ActorsOrderList(UnityEngine.RectTransform value);
                    /*0x3ce8508*/ UnityEngine.RectTransform get_PlayerActorIconFirstSlotAP();
                    /*0x3ce8510*/ void set_PlayerActorIconFirstSlotAP(UnityEngine.RectTransform value);
                    /*0x3ce8518*/ UnityEngine.RectTransform get_PlayerActorIconFirstSlotPP();
                    /*0x3ce8520*/ void set_PlayerActorIconFirstSlotPP(UnityEngine.RectTransform value);
                    /*0x3ce8528*/ UnityEngine.RectTransform get_PlayerActorIconSecondSlotPP();
                    /*0x3ce8530*/ void set_PlayerActorIconSecondSlotPP(UnityEngine.RectTransform value);
                    /*0x3ce8538*/ UnityEngine.RectTransform get_SpeedButton();
                    /*0x3ce8540*/ void set_SpeedButton(UnityEngine.RectTransform value);
                    /*0x3ce8548*/ UnityEngine.RectTransform get_CameraChangeButton();
                    /*0x3ce8550*/ void set_CameraChangeButton(UnityEngine.RectTransform value);
                    /*0x3ce8558*/ UnityEngine.RectTransform get_CockpitViewChangeButton();
                    /*0x3ce8560*/ void set_CockpitViewChangeButton(UnityEngine.RectTransform value);
                }
            }

            interface ITutorialOverseer
            {
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AwaitForProcessor();
                /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask AwaitForUserInput();
                /*0x380bb68*/ Assets.Api.Client.IBattleEngineEvent[] InjectCockpitViewUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x380bb68*/ Assets.Api.Client.IBattleEngineEvent[] InjectFirstTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x380bb68*/ Assets.Api.Client.IBattleEngineEvent[] InjectMazeTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x380bb68*/ Assets.Api.Client.IBattleEngineEvent[] InjectSecondTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x380bb68*/ Assets.Api.Client.IBattleEngineEvent[] InjectSpeedAndCameraChangeUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x380cb08*/ void TerminateActiveProcessor();
                /*0x380d83c*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData data);
                /*0x380d83c*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData[] data);
                /*0x380cb08*/ void TryReplayResultTutorialMessages();
                /*0x380cb08*/ void TryTriggerNextMessage();
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

                /*0x3ce8570*/ TutorialOverseer(Assets.GameUi.Service.Tutorial.ITutorialService tutorialService, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService);
                /*0x3ce8660*/ void Initialize(Assets.Battle.Overseers.ITutorialOverseerUnityFacade.Arguments arguments);
                /*0x3ce871c*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData data);
                /*0x3ce8a74*/ void ThrowTutorialMessage(Assets.Battle.Overseers.TutorialMessageData[] data);
                /*0x3ce8e68*/ Cysharp.Threading.Tasks.UniTask AwaitForProcessor();
                /*0x3ce8edc*/ void TryTriggerNextMessage();
                /*0x3ce8f90*/ void TryReplayResultTutorialMessages();
                /*0x3ce8fb8*/ UnityEngine.RectTransform GetHighlightRect(Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes highlight);
                /*0x3ce9038*/ void TerminateActiveProcessor();
                /*0x3ce906c*/ Cysharp.Threading.Tasks.UniTask AwaitForUserInput();
                /*0x3ce9278*/ Assets.Api.Client.IBattleEngineEvent[] InjectFirstTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cea0c8*/ Assets.Api.Client.IBattleEngineEvent[] InjectSecondTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3ceb298*/ Assets.Api.Client.IBattleEngineEvent[] InjectMazeTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3ceb62c*/ Assets.Api.Client.IBattleEngineEvent[] InjectSpeedAndCameraChangeUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3cebc10*/ Assets.Api.Client.IBattleEngineEvent[] InjectCockpitViewUnlockTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events);
                /*0x3ce9c5c*/ Assets.Api.Client.IBattleEngineEvent[] InjectTutorialMessages(Assets.Api.Client.IBattleEngineEvent[] events, System.Collections.Generic.List<Assets.Battle.Overseers.TutorialOverseer.MessageInjectionDescriptor> injectionDescriptors);
                /*0x3cec208*/ void <ThrowTutorialMessage>b__21_0();
                /*0x3cec234*/ void <ThrowTutorialMessage>b__22_0();
                /*0x3cec260*/ bool <InjectSecondTutorialMessages>b__30_3(Assets.Api.Client.IBattleEngineEvent eventData);
                /*0x3cec4a0*/ bool <InjectSecondTutorialMessages>b__30_6(Assets.Api.Client.IBattleEngineEvent eventData);
                /*0x3cec6e0*/ bool <InjectSecondTutorialMessages>b__30_9(Assets.Api.Client.IBattleEngineEvent eventData);
                /*0x3cec930*/ bool <InjectSecondTutorialMessages>b__30_12(Assets.Api.Client.IBattleEngineEvent eventData);

                class MessageInjectionDescriptor
                {
                    /*0x10*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <CanBeInjectedBefore>k__BackingField;
                    /*0x18*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <CanBeInjectedAfter>k__BackingField;
                    /*0x20*/ Assets.Api.Client.IBattleEngineEvent <EventData>k__BackingField;
                    /*0x28*/ bool <HasBeenInjected>k__BackingField;

                    /*0x3ce99d8*/ MessageInjectionDescriptor();
                    /*0x3cecb7c*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> get_CanBeInjectedBefore();
                    /*0x3cecb84*/ void set_CanBeInjectedBefore(System.Func<Assets.Api.Client.IBattleEngineEvent, bool> value);
                    /*0x3cecb8c*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> get_CanBeInjectedAfter();
                    /*0x3cecb94*/ void set_CanBeInjectedAfter(System.Func<Assets.Api.Client.IBattleEngineEvent, bool> value);
                    /*0x3cecb9c*/ Assets.Api.Client.IBattleEngineEvent get_EventData();
                    /*0x3cecba4*/ void set_EventData(Assets.Api.Client.IBattleEngineEvent value);
                    /*0x3cecbac*/ bool get_HasBeenInjected();
                    /*0x3cecbb4*/ void set_HasBeenInjected(bool value);

                    class <>c
                    {
                        static /*0x0*/ Assets.Battle.Overseers.TutorialOverseer.MessageInjectionDescriptor.<> <>9;
                        static /*0x8*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__16_0;
                        static /*0x10*/ System.Func<Assets.Api.Client.IBattleEngineEvent, bool> <>9__16_1;

                        static /*0x3cecbc0*/ <>c();
                        /*0x3cecc28*/ <>c();
                        /*0x3cecc30*/ bool <.ctor>b__16_0(Assets.Api.Client.IBattleEngineEvent eventData);
                        /*0x3cecc38*/ bool <.ctor>b__16_1(Assets.Api.Client.IBattleEngineEvent eventData);
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

                    static /*0x3cecc40*/ <>c();
                    /*0x3cecca8*/ <>c();
                    /*0x3ceccb0*/ bool <InjectFirstTutorialMessages>b__29_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3ceccb8*/ bool <InjectFirstTutorialMessages>b__29_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecd30*/ bool <InjectFirstTutorialMessages>b__29_2(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecd38*/ bool <InjectFirstTutorialMessages>b__29_3(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecdc8*/ bool <InjectSecondTutorialMessages>b__30_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecdd0*/ bool <InjectSecondTutorialMessages>b__30_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cece60*/ bool <InjectSecondTutorialMessages>b__30_2(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cece68*/ bool <InjectSecondTutorialMessages>b__30_5(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cece70*/ bool <InjectSecondTutorialMessages>b__30_8(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cece78*/ bool <InjectSecondTutorialMessages>b__30_11(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cece80*/ bool <InjectSecondTutorialMessages>b__30_14(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecf10*/ bool <InjectSecondTutorialMessages>b__30_15(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecf18*/ bool <InjectSecondTutorialMessages>b__30_16(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecf20*/ bool <InjectSecondTutorialMessages>b__30_17(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecfc0*/ bool <InjectMazeTutorialMessages>b__31_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3cecfc8*/ bool <InjectMazeTutorialMessages>b__31_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3ced058*/ bool <InjectSpeedAndCameraChangeUnlockTutorialMessages>b__32_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3ced060*/ bool <InjectSpeedAndCameraChangeUnlockTutorialMessages>b__32_1(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3ced0f0*/ bool <InjectCockpitViewUnlockTutorialMessages>b__33_0(Assets.Api.Client.IBattleEngineEvent eventData);
                    /*0x3ced0f8*/ bool <InjectCockpitViewUnlockTutorialMessages>b__33_1(Assets.Api.Client.IBattleEngineEvent eventData);
                }

                class <>c__DisplayClass28_0
                {
                    /*0x10*/ Assets.Battle.Overseers.TutorialOverseer <>4__this;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource completionSource;

                    /*0x3ce9270*/ <>c__DisplayClass28_0();
                    /*0x3ced188*/ void <AwaitForUserInput>b__0();
                }

                class <>c__DisplayClass30_0
                {
                    /*0x10*/ Assets.Api.Client.PawnPreparesSkillEvent data;

                    /*0x3cec498*/ <>c__DisplayClass30_0();
                    /*0x3ced250*/ bool <InjectSecondTutorialMessages>b__4(Assets.Api.Client.SkillMasterView s);
                }

                class <>c__DisplayClass30_1
                {
                    /*0x10*/ Assets.Api.Client.PawnUsedSkillEvent data;

                    /*0x3cec6d8*/ <>c__DisplayClass30_1();
                    /*0x3ced28c*/ bool <InjectSecondTutorialMessages>b__7(Assets.Api.Client.SkillMasterView s);
                }

                class <>c__DisplayClass30_2
                {
                    /*0x10*/ Assets.Api.Client.PawnsAreTargetedEvent data;

                    /*0x3cec928*/ <>c__DisplayClass30_2();
                    /*0x3ced2c8*/ bool <InjectSecondTutorialMessages>b__10(Assets.Api.Client.SkillMasterView s);
                }

                class <>c__DisplayClass30_3
                {
                    /*0x10*/ Assets.Api.Client.PawnResourcesUpdatedEvent data;

                    /*0x3cecb74*/ <>c__DisplayClass30_3();
                    /*0x3ced304*/ bool <InjectSecondTutorialMessages>b__13(Assets.Api.Client.PawnMasterView s);
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

                /*0x3ce9c08*/ TutorialMessageData();
                /*0x3ced340*/ string get_Message();
                /*0x3ced348*/ void set_Message(string value);
                /*0x3ced350*/ string get_CharacterAssetId();
                /*0x3ced358*/ void set_CharacterAssetId(string value);
                /*0x3ced360*/ Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes get_HighLight();
                /*0x3ced368*/ void set_HighLight(Assets.Battle.Overseers.TutorialMessageEvent.HighlightTypes value);
                /*0x3ced370*/ float get_ZOffset();
                /*0x3ced378*/ void set_ZOffset(float value);
                /*0x3ced380*/ Assets.GameUi.Guide.Narration.NarrationComponent.PositionTypes get_PositionType();
                /*0x3ced388*/ void set_PositionType(Assets.GameUi.Guide.Narration.NarrationComponent.PositionTypes value);
                /*0x3ced390*/ Assets.GameUi.Guide.Highlight.HoleComponent.ArrowDirection get_ArrowDirection();
                /*0x3ced398*/ void set_ArrowDirection(Assets.GameUi.Guide.Highlight.HoleComponent.ArrowDirection value);
                /*0x3ced3a0*/ bool get_DisableAutoContinuation();
                /*0x3ced3a8*/ void set_DisableAutoContinuation(bool value);
            }

            class TutorialMessageEvent : Assets.Api.Client.IBattleEngineEvent
            {
                /*0x10*/ int <Tick>k__BackingField;
                /*0x18*/ Assets.Battle.Overseers.TutorialMessageData[] <Messages>k__BackingField;

                /*0x3ce9b64*/ TutorialMessageEvent();
                /*0x3ced3b4*/ int get_Tick();
                /*0x3ced3bc*/ void set_Tick(int value);
                /*0x3ced3c4*/ Assets.Battle.Overseers.TutorialMessageData[] get_Messages();
                /*0x3ced3cc*/ void set_Messages(Assets.Battle.Overseers.TutorialMessageData[] value);

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
                /*0x380d83c*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x380cb08*/ void ClearActorRenderers();
                /*0x380cb08*/ void ClearFieldMaterials();
                /*0x380d83c*/ void Initialize(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade.Arguments arguments);
                /*0x380d83c*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                /*0x380d83c*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                /*0x380cb08*/ void Update();

                class Arguments
                {
                    /*0x10*/ UnityEngine.Transform <VisualEffectsLayer>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <OverlayLayer>k__BackingField;

                    /*0x3ced3f4*/ Arguments();
                    /*0x3ced3d4*/ UnityEngine.Transform get_VisualEffectsLayer();
                    /*0x3ced3dc*/ void set_VisualEffectsLayer(UnityEngine.Transform value);
                    /*0x3ced3e4*/ UnityEngine.Transform get_OverlayLayer();
                    /*0x3ced3ec*/ void set_OverlayLayer(UnityEngine.Transform value);
                }
            }

            interface IVisualEffectsOverseer
            {
                void AddActorRenderer(long id, UnityEngine.Renderer target);
                /*0x380d438*/ void RemoveActorRenderer(long id);
                /*0x380d83c*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                void PlaybackErosionIn(long id, float duration);
                void PlaybackErosionOut(long id, float duration);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key);
                Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAquireMecanimController(string key);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position);
                /*0x380bb68*/ string KeyToVfxKey(string key);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
                /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Vector3 scale);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent);
                /*0x380d83c*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x380cb08*/ void ClearFieldMaterials();
                /*0x380d83c*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                Cysharp.Threading.Tasks.UniTask PlaybackTimeStop(Assets.VisualEffectData.TimeStopParameters parameters);
                Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAquireVfx(UnityEngine.GameObject prefab);
                /*0x380d83c*/ void PlaybackColorPunch(Assets.Battle.Actor actor);
                Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAquireVfxAnimationHandler(string key);
                void PlaybackBetweenState(Assets.Battle.Actor actor, UnityEngine.Color firstColor, UnityEngine.Color secondColor);
                void PlaybackConflagration(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x380d83c*/ void StopConflagration(Assets.Battle.Actor actor);
                void PlaybackFreeze(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x380d83c*/ void StopFreeze(Assets.Battle.Actor actor);
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

                /*0x3ced3fc*/ VisualEffectsOverseer(Assets.Battle.ICache cache, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3ced544*/ void Initialize(Assets.Battle.Overseers.IVisualEffectsOverseerUnityFacade.Arguments arguments);
                /*0x3ced580*/ void Update();
                /*0x3ced8a4*/ string KeyToVfxAnimationKey(string key);
                /*0x3ced8f0*/ string KeyToVfxKey(string key);
                /*0x3ced93c*/ string KeyToMecanimKey(string key);
                /*0x3ced988*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position);
                /*0x3cedc14*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
                /*0x3cedcfc*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Vector3 scale);
                /*0x3ceddc8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(Assets.VisualEffectData.VfxHandler prefab, UnityEngine.Vector3 position);
                /*0x3ceda98*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryTriggerVfxAt(string key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
                /*0x3cedfe8*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key);
                /*0x3cee2cc*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent);
                /*0x3cee410*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandlerOnOverlayLayer(string key);
                /*0x3cee554*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> TryAquireVfx(UnityEngine.GameObject prefab);
                /*0x3cee12c*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxHandler> TryAquireVfxHandler(string key, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
                /*0x3cee66c*/ void SubscribeToHandlerEvents(Assets.VisualEffectData.VfxHandler vfx);
                /*0x3ceea48*/ void SubscribeToHandlerEvents(Assets.VisualEffectData.VfxAnimationHandler vfx);
                /*0x3ceebe4*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.MecanimController> TryAquireMecanimController(string key);
                /*0x3ceecfc*/ Cysharp.Threading.Tasks.UniTask<Assets.VisualEffectData.VfxAnimationHandler> TryAquireVfxAnimationHandler(string key);
                /*0x3ceee14*/ UnityEngine.Vector3 AcquireYOffsetedPosition(Assets.VisualEffectData.VfxHandler vfx, UnityEngine.Vector3 position);
                /*0x3ceeecc*/ void AddActorRenderer(long id, UnityEngine.Renderer target);
                /*0x3cef03c*/ void RemoveActorRenderer(long id);
                /*0x3cef158*/ void AddFieldMaterial(UnityEngine.Material material);
                /*0x3cef234*/ void ClearFieldMaterials();
                /*0x3cef284*/ void ClearActorRenderers();
                /*0x3cef2d4*/ void PlaybackErosionIn(long id, float duration);
                /*0x3cef488*/ void PlaybackErosionOut(long id, float duration);
                /*0x3cef640*/ void PlaybackLightFlash(Assets.VisualEffectData.LightFlashParameters param);
                /*0x3cef750*/ void PlaybackLightFlash(float inDuration, float outDuration);
                /*0x3cefa54*/ void PlaybackDarkFlash(Assets.VisualEffectData.DarkFlashParameters param);
                /*0x3cefb88*/ void PlaybackDarkFlash(UnityEngine.Color color, float inDuration, float outDuration);
                /*0x3cf00b0*/ void PlaybackColorPunch(Assets.Battle.Actor actor);
                /*0x3cf0114*/ void PlaybackColorPunch(Assets.Battle.Actor actor, UnityEngine.Color color, UnityEngine.Vector3 direction, float durtion, int vibrato, float elasticity, bool snapping);
                /*0x3cf0630*/ void PlaybackBetweenState(Assets.Battle.Actor actor, UnityEngine.Color firstColor, UnityEngine.Color secondColor);
                /*0x3cf0a8c*/ void PlaybackConflagration(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x3cf0ddc*/ void StopConflagration(Assets.Battle.Actor actor);
                /*0x3cf0ea4*/ void PlaybackFreeze(Assets.Battle.Actor actor, UnityEngine.Color color);
                /*0x3cf0f7c*/ void StopFreeze(Assets.Battle.Actor actor);
                /*0x3cf1044*/ Cysharp.Threading.Tasks.UniTask PlaybackTimeStop(Assets.VisualEffectData.TimeStopParameters parameters);
                /*0x3cf1114*/ void Dispose();
                /*0x3cef678*/ Cysharp.Threading.Tasks.UniTask <PlaybackLightFlash>g__Playback|42_0(int amount, int delay, float inDuration, float outDuration);
                /*0x3cf1150*/ float <PlaybackLightFlash>b__43_0();
                /*0x3cf1158*/ void <PlaybackLightFlash>b__43_1(float x);
                /*0x3cf1160*/ float <PlaybackLightFlash>b__43_2();
                /*0x3cf1168*/ void <PlaybackLightFlash>b__43_3(float x);
                /*0x3cf1170*/ float <PlaybackLightFlash>b__43_4();
                /*0x3cf1178*/ void <PlaybackLightFlash>b__43_5(float x);
                /*0x3cf1180*/ float <PlaybackLightFlash>b__43_6();
                /*0x3cf1188*/ void <PlaybackLightFlash>b__43_7(float x);
                /*0x3cefa84*/ Cysharp.Threading.Tasks.UniTask <PlaybackDarkFlash>g__Playback|44_0(UnityEngine.Color color, int amount, int delay, float inDuration, float outDuration);

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

                    /*0x3ceefc0*/ RendererParameters();
                    /*0x3cf1190*/ UnityEngine.MaterialPropertyBlock get_MaterialPropertyBlock();
                    /*0x3cf1198*/ DG.Tweening.Tween get_ErosionTween();
                    /*0x3cf11a0*/ void set_ErosionTween(DG.Tweening.Tween value);
                    /*0x3cf11a8*/ float get_Erosion();
                    /*0x3cf11b0*/ void set_Erosion(float value);
                    /*0x3cf11b8*/ DG.Tweening.Tween get_PunchTween();
                    /*0x3cf11c0*/ void set_PunchTween(DG.Tweening.Tween value);
                    /*0x3cf11c8*/ DG.Tweening.Sequence get_ColorSequence();
                    /*0x3cf11d0*/ void set_ColorSequence(DG.Tweening.Sequence value);
                    /*0x3cf11d8*/ UnityEngine.Color get_OverlayColor();
                    /*0x3cf11e4*/ void set_OverlayColor(UnityEngine.Color value);
                    /*0x3cf11f0*/ float get_OverlayStrength();
                    /*0x3cf11f8*/ void set_OverlayStrength(float value);
                    /*0x3cf1200*/ bool get_ignoreLight();
                    /*0x3cf1208*/ void set_ignoreLight(bool value);
                }

                class MaterialParameters
                {
                    /*0x10*/ UnityEngine.Material <Material>k__BackingField;
                    /*0x18*/ UnityEngine.Color <OriginalColor>k__BackingField;

                    /*0x3cef1e4*/ MaterialParameters(UnityEngine.Material material);
                    /*0x3cf1214*/ UnityEngine.Material get_Material();
                    /*0x3cf121c*/ UnityEngine.Color get_OriginalColor();
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

                    /*0x3cf1228*/ void MoveNext();
                    /*0x3cf1684*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cf1690*/ void MoveNext();
                    /*0x3cf1ae4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                class <>c__DisplayClass30_0
                {
                    /*0x10*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x18*/ Assets.VisualEffectData.VfxHandler vfx;

                    /*0x3ceea40*/ <>c__DisplayClass30_0();
                    /*0x3cf1af0*/ void <SubscribeToHandlerEvents>b__0(Assets.VisualEffectData.LightFlashParameters parameters);
                    /*0x3cf1b08*/ void <SubscribeToHandlerEvents>b__1(Assets.VisualEffectData.DarkFlashParameters parameters);
                    /*0x3cf1b20*/ void <SubscribeToHandlerEvents>b__2(Assets.VisualEffectData.CameraNoiseParameters parameters);
                    /*0x3cf1bf4*/ void <SubscribeToHandlerEvents>b__3(Assets.VisualEffectData.TimeStopParameters parameters);
                    /*0x3cf1cc8*/ void <SubscribeToHandlerEvents>b__4();
                    /*0x3cf1cf4*/ void <SubscribeToHandlerEvents>b__5(UnityEngine.AudioClip audioClip);

                    struct <<SubscribeToHandlerEvents>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Overseers.VisualEffectsOverseer.<> <>4__this;
                        /*0x40*/ Assets.VisualEffectData.CameraNoiseParameters parameters;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cf1da8*/ void MoveNext();
                        /*0x3cf2148*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<SubscribeToHandlerEvents>b__3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Overseers.VisualEffectsOverseer.<> <>4__this;
                        /*0x40*/ Assets.VisualEffectData.TimeStopParameters parameters;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cf2154*/ void MoveNext();
                        /*0x3cf2474*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass31_0
                {
                    /*0x10*/ Assets.VisualEffectData.VfxAnimationHandler vfx;
                    /*0x18*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;

                    /*0x3ceebdc*/ <>c__DisplayClass31_0();
                    /*0x3cf2480*/ void <SubscribeToHandlerEvents>b__0();
                    /*0x3cf24ac*/ void <SubscribeToHandlerEvents>b__1(UnityEngine.AudioClip audioClip);
                }

                class <>c__DisplayClass40_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> item;

                    /*0x3cef480*/ <>c__DisplayClass40_0();
                    /*0x3cf2560*/ float <PlaybackErosionIn>b__0();
                    /*0x3cf257c*/ void <PlaybackErosionIn>b__1(float value);
                }

                class <>c__DisplayClass41_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> item;

                    /*0x3cef638*/ <>c__DisplayClass41_0();
                    /*0x3cf2598*/ float <PlaybackErosionOut>b__0();
                    /*0x3cf25b4*/ void <PlaybackErosionOut>b__1(float value);
                }

                class <>c__DisplayClass45_0
                {
                    /*0x10*/ Assets.Battle.Overseers.VisualEffectsOverseer.MaterialParameters item;

                    /*0x3cf00a0*/ <>c__DisplayClass45_0();
                    /*0x3cf25d0*/ UnityEngine.Color <PlaybackDarkFlash>b__0();
                    /*0x3cf25f4*/ void <PlaybackDarkFlash>b__1(UnityEngine.Color x);
                }

                class <>c__DisplayClass45_1
                {
                    /*0x10*/ Assets.Battle.Overseers.VisualEffectsOverseer.MaterialParameters item;

                    /*0x3cf00a8*/ <>c__DisplayClass45_1();
                    /*0x3cf2618*/ UnityEngine.Color <PlaybackDarkFlash>b__2();
                    /*0x3cf263c*/ void <PlaybackDarkFlash>b__3(UnityEngine.Color x);
                }

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> target;
                    /*0x20*/ UnityEngine.Vector3 position;

                    /*0x3cf0628*/ <>c__DisplayClass47_0();
                    /*0x3cf2660*/ void <PlaybackColorPunch>b__0();
                    /*0x3cf2694*/ void <PlaybackColorPunch>b__1();
                    /*0x3cf26c8*/ float <PlaybackColorPunch>b__2();
                    /*0x3cf26e4*/ void <PlaybackColorPunch>b__3(float x);
                    /*0x3cf2700*/ float <PlaybackColorPunch>b__4();
                    /*0x3cf271c*/ void <PlaybackColorPunch>b__5(float x);
                    /*0x3cf2738*/ void <PlaybackColorPunch>b__6();
                    /*0x3cf2758*/ void <PlaybackColorPunch>b__7();
                }

                class <>c__DisplayClass48_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> target;

                    /*0x3cf0a84*/ <>c__DisplayClass48_0();
                    /*0x3cf2778*/ UnityEngine.Color <PlaybackBetweenState>b__0();
                    /*0x3cf2798*/ void <PlaybackBetweenState>b__1(UnityEngine.Color value);
                    /*0x3cf27b8*/ UnityEngine.Color <PlaybackBetweenState>b__2();
                    /*0x3cf27d8*/ void <PlaybackBetweenState>b__3(UnityEngine.Color value);
                    /*0x3cf27f8*/ UnityEngine.Color <PlaybackBetweenState>b__4();
                    /*0x3cf2818*/ void <PlaybackBetweenState>b__5(UnityEngine.Color value);
                    /*0x3cf2838*/ UnityEngine.Color <PlaybackBetweenState>b__6();
                    /*0x3cf2858*/ void <PlaybackBetweenState>b__7(UnityEngine.Color value);
                }

                class <>c__DisplayClass49_0
                {
                    /*0x10*/ System.ValueTuple<UnityEngine.Renderer, Assets.Battle.Overseers.VisualEffectsOverseer.RendererParameters> target;

                    /*0x3cf0dd4*/ <>c__DisplayClass49_0();
                    /*0x3cf2878*/ UnityEngine.Color <PlaybackConflagration>b__0();
                    /*0x3cf2898*/ void <PlaybackConflagration>b__1(UnityEngine.Color value);
                    /*0x3cf28b8*/ UnityEngine.Color <PlaybackConflagration>b__2();
                    /*0x3cf28d8*/ void <PlaybackConflagration>b__3(UnityEngine.Color value);
                }

                struct <PlaybackTimeStop>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.VisualEffectData.TimeStopParameters parameters;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cf28f8*/ void MoveNext();
                    /*0x3cf2eb8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireMecanimController>d__32 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Utilities.Spine.MecanimController> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.MecanimController> <>u__1;

                    /*0x3cf2ec4*/ void MoveNext();
                    /*0x3cf3598*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireVfx>d__28 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ UnityEngine.GameObject prefab;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x3cf35f0*/ void MoveNext();
                    /*0x3cf3cfc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAquireVfxAnimationHandler>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.VisualEffectData.VfxAnimationHandler> <>t__builder;
                    /*0x30*/ Assets.Battle.Overseers.VisualEffectsOverseer <>4__this;
                    /*0x38*/ string key;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxAnimationHandler> <>u__1;

                    /*0x3cf3d54*/ void MoveNext();
                    /*0x3cf4408*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cf4460*/ void MoveNext();
                    /*0x3cf4af8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3cf4b50*/ void MoveNext();
                    /*0x3cf5078*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3cf56dc*/ ActionQueue();
                /*0x3cf50d0*/ Assets.AssetManagement.IAssetInstanceProvider get_InstanceProvider();
                /*0x3cf50d8*/ void set_InstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                /*0x3cf50e0*/ Assets.AssetManagement.ITextureAssetProvider get_TextureProvider();
                /*0x3cf50e8*/ void set_TextureProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3cf50f0*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3cf50f8*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3cf5100*/ void Clear();
                /*0x3cf53d8*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Hud.ActionQueueIcon> RequestIcon(Assets.Battle.Actor actor);
                /*0x3cf54f0*/ Cysharp.Threading.Tasks.UniTask UpdateQueue(Assets.Battle.Actor[] queue);
                /*0x3cf55bc*/ void Advance();

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Assets.Battle.Hud.ActionQueueIcon[] icons;

                    /*0x3cf5764*/ <>c__DisplayClass17_0();
                }

                class <>c__DisplayClass17_1
                {
                    /*0x10*/ int index;
                    /*0x18*/ Assets.Battle.Actor actor;
                    /*0x20*/ Assets.Battle.Hud.ActionQueue.<> CS$<>8__locals1;

                    /*0x3cf576c*/ <>c__DisplayClass17_1();
                    /*0x3cf5774*/ void <UpdateQueue>b__0(Assets.Battle.Hud.ActionQueueIcon icon);
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

                    /*0x3cf58b8*/ void MoveNext();
                    /*0x3cf66d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <UpdateQueue>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Hud.ActionQueue <>4__this;
                    /*0x30*/ Assets.Battle.Actor[] queue;
                    /*0x38*/ Assets.Battle.Hud.ActionQueue.<> <>8__1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3cf672c*/ void MoveNext();
                    /*0x3cf6f5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3cf7054*/ ActionQueueIcon();
                /*0x3cf6f68*/ Assets.Api.Client.PawnId get_ActorId();
                /*0x3cf6f70*/ void set_ActorId(Assets.Api.Client.PawnId value);
                /*0x3cf6f78*/ bool get_ReadyToUse();
                /*0x3cf6f80*/ void set_ReadyToUse(bool value);
                /*0x3cf65ac*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.AssetManagement.ITextureAssetProvider assetProvider, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider);
                /*0x3cf5860*/ void UpdateState(Assets.Battle.Actor actor, int index);

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

                    /*0x3cf705c*/ void MoveNext();
                    /*0x3cf8004*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3cf9ce0*/ ActorDetails();
                /*0x3cf8010*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                /*0x3cf8018*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3cf8020*/ Assets.Battle.DataModels.IBattleDataStorageModel get_BattleDataStorageModel();
                /*0x3cf8028*/ void set_BattleDataStorageModel(Assets.Battle.DataModels.IBattleDataStorageModel value);
                /*0x3cf8030*/ Assets.Api.MemoryDB.IMemoryDB get_MemoryDB();
                /*0x3cf8038*/ void set_MemoryDB(Assets.Api.MemoryDB.IMemoryDB value);
                /*0x3cf8040*/ Assets.AssetManagement.IAssetInstanceProvider get_AssetInstanceProvider();
                /*0x3cf8048*/ void set_AssetInstanceProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                /*0x3cf8050*/ Assets.AssetManagement.IAddressablesKeyProvider get_KeyProvider();
                /*0x3cf8058*/ void set_KeyProvider(Assets.AssetManagement.IAddressablesKeyProvider value);
                /*0x3cf8060*/ Assets.Battle.ICache get_Cache();
                /*0x3cf8068*/ void set_Cache(Assets.Battle.ICache value);
                /*0x3cf8078*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor);
                /*0x3cf91ac*/ void Clear();
                /*0x3cf95ac*/ Cysharp.Threading.Tasks.UniTask ApplyAuraDataView(Assets.Battle.Actor actor);
                /*0x3cf998c*/ string ConstructParameterValueText(long parameter, long baseParameter);
                /*0x3cf9b38*/ string ConstructParameterValueText(float parameter, float baseParameter);

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ Assets.Battle.Hud.ActorDetails <>4__this;
                    /*0x18*/ Assets.Battle.Actor actor;

                    /*0x3cf91a4*/ <>c__DisplayClass47_0();
                    /*0x3cf9ce8*/ UnityEngine.Sprite <Initialize>b__0(UnityEngine.Sprite sprite);
                    /*0x3cf9d18*/ UnityEngine.Texture <Initialize>b__1(UnityEngine.Texture2D texture);
                    /*0x3cf9d48*/ bool <Initialize>b__2(Assets.Api.Client.PawnMasterView p);
                    /*0x3cf9d70*/ UnityEngine.Texture <Initialize>b__3(UnityEngine.Texture2D texture);
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

                    /*0x3cf9da0*/ void MoveNext();
                    /*0x3cfa6d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3cfa890*/ ActorIcon();
                /*0x3cfa6e0*/ UnityEngine.UI.Button get_Button();
                /*0x3cfa6e8*/ void set_Button(UnityEngine.UI.Button value);
                /*0x3cf7efc*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider);
                /*0x3cfa6f0*/ void SetGlowActive(bool active);
                /*0x3cfa710*/ void SetDeathLabelActive(bool active);
                /*0x3cf6f8c*/ void UpdateVisualState(Assets.Battle.Actor actor);
                /*0x3cfa730*/ void SetToAliveState();
                /*0x3cfa7e0*/ void SetToDeadState();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3cfa918*/ <>c__DisplayClass12_0();
                    /*0x3cfa920*/ bool <Initialize>b__0(UnityEngine.GameObject i);
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

                    /*0x3cfa954*/ void MoveNext();
                    /*0x3cfb354*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class ActorStatusIcon : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image icon;
                /*0x28*/ UnityEngine.Sprite playerSprite;
                /*0x30*/ UnityEngine.Sprite enemySprite;

                /*0x3cfb3c4*/ ActorStatusIcon();
                /*0x3cfb360*/ void Initialize(bool isEnemyActor);
                /*0x3cfb394*/ void SetStatus(bool active);
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

                /*0x3cfbf00*/ ActorStatusView();
                /*0x3cfb3cc*/ Assets.Battle.Hud.ActorIcon get_Icon();
                /*0x3cfb3d4*/ void set_Icon(Assets.Battle.Hud.ActorIcon value);
                /*0x3cfb3dc*/ void Awake();
                /*0x3cfb408*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool worldSpace, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.GameUi.Externals.IAudioManager audioManager, Assets.AssetManagement.ITextureAssetProvider textureAssetProvider);
                /*0x3cfb550*/ void TryRestoreStatus();
                /*0x3cfb564*/ void UpdateStatus(Assets.Api.Client.StatusView status, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3cfb83c*/ void UpdateAuraState(int buffs, int debuffs, bool hasAbnormalState, bool sustainsShieldEffect);
                /*0x3cfbaa8*/ void TryToFadeIn(float duration);
                /*0x3cfbb80*/ void TryToFadeOut(float delay, float duration);
                /*0x3cfbc78*/ Cysharp.Threading.Tasks.UniTask SetToEngageState(bool isEnemyActor);
                /*0x3cfbd60*/ Cysharp.Threading.Tasks.UniTask SetToIdleState(bool isEnemyActor);
                /*0x3cfbe48*/ void SetToAliveState();
                /*0x3cfbe90*/ void SetToDeadState();
                /*0x3cfb80c*/ void SetGlowActive(bool active);

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

                    /*0x3cfbf08*/ void MoveNext();
                    /*0x3cfc7cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class AuraDataView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI <Description>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <TurnLeft>k__BackingField;

                /*0x3cfc7f8*/ AuraDataView();
                /*0x3cfc7d8*/ TMPro.TextMeshProUGUI get_Description();
                /*0x3cfc7e0*/ void set_Description(TMPro.TextMeshProUGUI value);
                /*0x3cfc7e8*/ TMPro.TextMeshProUGUI get_TurnLeft();
                /*0x3cfc7f0*/ void set_TurnLeft(TMPro.TextMeshProUGUI value);
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

                /*0x3cfca78*/ BossHealthGauge();
                /*0x3cfc800*/ Assets.AssetManagement.ITextureAssetProvider get_TextureProvider();
                /*0x3cfc808*/ void set_TextureProvider(Assets.AssetManagement.ITextureAssetProvider value);
                /*0x3ce83b4*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status, bool showScoreView, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider);
                /*0x3cfc810*/ void UpdateStatus(Assets.Battle.Actor actor, Assets.Api.Client.StatusView status);
                /*0x3cfc8c0*/ void UpdateScoreValue(long value);
                /*0x3cfca70*/ long GetCurrentScoreValue();

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ long currentValue;
                    /*0x18*/ Assets.Battle.Hud.BossHealthGauge <>4__this;

                    /*0x3cfca68*/ <>c__DisplayClass13_0();
                    /*0x3cfca80*/ long <UpdateScoreValue>b__0();
                    /*0x3cfca88*/ void <UpdateScoreValue>b__1(long x);
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

                /*0x3cfccb4*/ CockpitPlaceholder();
                /*0x3cfcb08*/ UnityEngine.RectTransform get_RectTransform();
                /*0x3cfcb10*/ void set_RectTransform(UnityEngine.RectTransform value);
                /*0x3cfcb18*/ Assets.Battle.Actor get_Actor();
                /*0x3cfcb20*/ void set_Actor(Assets.Battle.Actor value);
                /*0x3cfcb28*/ bool get_Disabled();
                /*0x3cfcb30*/ void set_Disabled(bool value);
                /*0x3cfcb3c*/ void UpdateStatus(Assets.Battle.Actor actor);
                /*0x3cfcc64*/ void Clear();
            }

            class CombinedGauge : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image leftGauge;
                /*0x28*/ UnityEngine.UI.Image rightGauge;
                /*0x30*/ UnityEngine.GameObject inactiveLabel;
                /*0x38*/ DG.Tweening.Tween leftGaugeTween;
                /*0x40*/ DG.Tweening.Tween rightGaugeTween;
                /*0x48*/ Assets.Battle.Hud.CombinedGauge.StateTypes <State>k__BackingField;

                /*0x3cfcf90*/ CombinedGauge();
                /*0x3cfccbc*/ Assets.Battle.Hud.CombinedGauge.StateTypes get_State();
                /*0x3cfccc4*/ void set_State(Assets.Battle.Hud.CombinedGauge.StateTypes value);
                /*0x3cfcccc*/ void SetState(bool active);
                /*0x3cfcd40*/ Cysharp.Threading.Tasks.UniTask UpdateValue(long leftCurrent, long leftMax, long rightCurrent, long rightMax, float duration);
                /*0x3cfcf68*/ Assets.Battle.Hud.CombinedGauge.StateTypes CalculateCurrentState(float leftValue, float rightValue);

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

                /*0x3cfd030*/ DamageText();
                /*0x3cfcf98*/ TMPro.TextMeshPro get_Mesh();
                /*0x3cfcfa0*/ void set_Mesh(TMPro.TextMeshPro value);
                /*0x3cfcfa8*/ UnityEngine.Vector3 get_PositionOffset();
                /*0x3cfcfb4*/ void set_PositionOffset(UnityEngine.Vector3 value);
                /*0x3cfcfc0*/ float get_StartPositionYOffset();
                /*0x3cfcfc8*/ void set_StartPositionYOffset(float value);
                /*0x3cfcfd0*/ float get_Deviation();
                /*0x3cfcfd8*/ void set_Deviation(float value);
                /*0x3cfcfe0*/ float get_FadeInDuration();
                /*0x3cfcfe8*/ void set_FadeInDuration(float value);
                /*0x3cfcff0*/ float get_MoveInDuration();
                /*0x3cfcff8*/ void set_MoveInDuration(float value);
                /*0x3cfd000*/ float get_IntervalDuration();
                /*0x3cfd008*/ void set_IntervalDuration(float value);
                /*0x3cfd010*/ float get_FadeOutDuration();
                /*0x3cfd018*/ void set_FadeOutDuration(float value);
                /*0x3cfd020*/ DG.Tweening.Sequence get_ActiveSequence();
                /*0x3cfd028*/ void set_ActiveSequence(DG.Tweening.Sequence value);
            }

            class LegendMark : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.UI.Image <Icon>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <Label>k__BackingField;

                /*0x3cfd0bc*/ LegendMark();
                /*0x3cfd09c*/ UnityEngine.UI.Image get_Icon();
                /*0x3cfd0a4*/ void set_Icon(UnityEngine.UI.Image value);
                /*0x3cfd0ac*/ TMPro.TextMeshProUGUI get_Label();
                /*0x3cfd0b4*/ void set_Label(TMPro.TextMeshProUGUI value);
            }

            class MvpDataView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.GameUi.Icon.IconBase attackIcon;
                /*0x28*/ Assets.GameUi.Icon.IconBase defenceIcon;
                /*0x30*/ Assets.GameUi.Icon.IconBase healIcon;
                /*0x38*/ Assets.Battle.DataModels.IBattleDataStorageModel <Model>k__BackingField;

                /*0x3cfd554*/ MvpDataView();
                /*0x3cfd0c4*/ Assets.Battle.DataModels.IBattleDataStorageModel get_Model();
                /*0x3cfd0cc*/ void set_Model(Assets.Battle.DataModels.IBattleDataStorageModel value);
                /*0x3cfd0d4*/ void SetAnimationTrigger(Assets.Battle.Hud.MvpDataView.Animations trigger);
                /*0x3cfd18c*/ Cysharp.Threading.Tasks.UniTask AssignActors(Assets.Api.Client.PawnId attacker, Assets.Api.Client.PawnId defender, Assets.Api.Client.PawnId healer);
                /*0x3cfd474*/ Cysharp.Threading.Tasks.UniTask ApplyToIcon(Assets.Api.Client.PawnId actor, Assets.GameUi.Icon.IconBase icon);

                enum Animations
                {
                    Default = 0,
                    ScoreAttack = 1,
                    Maze = 2,
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Api.Client.PawnId actor;

                    /*0x3cfd55c*/ <>c__DisplayClass9_0();
                    /*0x3cfd564*/ bool <ApplyToIcon>b__0(Assets.Api.Client.PawnMasterView s);
                }

                struct <ApplyToIcon>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.PawnId actor;
                    /*0x30*/ Assets.Battle.Hud.MvpDataView <>4__this;
                    /*0x38*/ Assets.GameUi.Icon.IconBase icon;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3cfd598*/ void MoveNext();
                    /*0x3cfdd04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class NavigationTile : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI <Title>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <ButtonLabel>k__BackingField;
                /*0x30*/ UnityEngine.UI.Button <Button>k__BackingField;

                /*0x3cfdd40*/ NavigationTile();
                /*0x3cfdd10*/ TMPro.TextMeshProUGUI get_Title();
                /*0x3cfdd18*/ void set_Title(TMPro.TextMeshProUGUI value);
                /*0x3cfdd20*/ TMPro.TextMeshProUGUI get_ButtonLabel();
                /*0x3cfdd28*/ void set_ButtonLabel(TMPro.TextMeshProUGUI value);
                /*0x3cfdd30*/ UnityEngine.UI.Button get_Button();
                /*0x3cfdd38*/ void set_Button(UnityEngine.UI.Button value);
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

                /*0x3cfdf4c*/ Point();
                /*0x3cfdd48*/ UnityEngine.Transform get_Value();
                /*0x3cfdd50*/ void set_Value(UnityEngine.Transform value);
                /*0x3cfdd58*/ bool get_Enabled();
                /*0x3cfdd60*/ void set_Enabled(bool value);
                /*0x3cfdd6c*/ bool get_Inactive();
                /*0x3cfdd74*/ void set_Inactive(bool value);
                /*0x3cfdd80*/ bool get_NegativeScale();
                /*0x3cfdd88*/ void set_NegativeScale(bool value);
                /*0x3cfdd94*/ void Update();
            }

            class PointGauge : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Battle.Hud.Point[] points;
                /*0x28*/ bool <Inactive>k__BackingField;
                /*0x30*/ DG.Tweening.Sequence sequence;

                /*0x3cfdf68*/ PointGauge();
                /*0x3cfdf54*/ bool get_Inactive();
                /*0x3cfdf5c*/ void set_Inactive(bool value);
                /*0x3cf9680*/ Cysharp.Threading.Tasks.UniTask UpdateValue(int current, int max, float duration, Assets.GameUi.Externals.IAudioManager audioManager);
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

                /*0x3cfe2b4*/ PositionLegend();
                /*0x3cfdf70*/ void SetToEmpty();
                /*0x3cfe11c*/ void Add(Assets.Api.Client.PawnView pawn);
                /*0x3cfe240*/ void SetMarkToPlayer(Assets.Battle.Hud.LegendMark mark);
                /*0x3cfe1cc*/ void SetMarkToEnemy(Assets.Battle.Hud.LegendMark mark);
                /*0x3cfe0a8*/ void SetMarkToEmpty(Assets.Battle.Hud.LegendMark mark);
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

                /*0x3cfe5bc*/ ResultBackground();
                /*0x3cfe46c*/ void Show(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, System.Action onFadeComplete);
                /*0x3cfe5a0*/ void OnAnimationFadeStepComplete(string value);
            }

            class ResultDamageView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI rankPercentage;
                /*0x28*/ TMPro.TextMeshProUGUI damage;
                /*0x30*/ TMPro.TextMeshProUGUI damagePercentage;
                /*0x38*/ UnityEngine.GameObject damagePercentageParent;
                /*0x40*/ UnityEngine.GameObject damageRecordMark;

                /*0x3cfe6c4*/ ResultDamageView();
                /*0x3cfe5c4*/ Cysharp.Threading.Tasks.UniTask UpdateData(string rankData, string damage, string damagePercentage, bool newRecord, bool showPercentage);
            }

            class ResultLevelProgress : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent levelProgress;
                /*0x28*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> <OnRewardClicked>k__BackingField;
                /*0x30*/ Assets.Battle.DataModels.IBattleDataStorageModel <Model>k__BackingField;

                /*0x3cfe80c*/ ResultLevelProgress();
                /*0x3cfe6cc*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> get_OnRewardClicked();
                /*0x3cfe6d4*/ void set_OnRewardClicked(System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> value);
                /*0x3cfe6dc*/ Assets.Battle.DataModels.IBattleDataStorageModel get_Model();
                /*0x3cfe6e4*/ void set_Model(Assets.Battle.DataModels.IBattleDataStorageModel value);
                /*0x3cfe6ec*/ Cysharp.Threading.Tasks.UniTask UpdateLevelProgress(Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments);

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Battle.Hud.ResultLevelProgress <>4__this;
                    /*0x18*/ Assets.GameUi.IdleActivityLevelProgress.IdleActivityLevelProgressComponent.Args arguments;

                    /*0x3cfe804*/ <>c__DisplayClass9_0();
                    /*0x3cfe814*/ Cysharp.Threading.Tasks.UniTask <UpdateLevelProgress>b__0(Assets.GameUi.Icon.IconBase icon);

                    struct <<UpdateLevelProgress>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Hud.ResultLevelProgress.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cfe8c0*/ void MoveNext();
                        /*0x3cfed18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3cfef44*/ ResultNavigation();
                /*0x3cfed24*/ UnityEngine.UI.Button get_NextButton();
                /*0x3cfed2c*/ void set_NextButton(UnityEngine.UI.Button value);
                /*0x3cfed34*/ UnityEngine.UI.Button get_ReplayButton();
                /*0x3cfed3c*/ void set_ReplayButton(UnityEngine.UI.Button value);
                /*0x3cfed44*/ UnityEngine.UI.Button get_HomeButton();
                /*0x3cfed4c*/ void set_HomeButton(UnityEngine.UI.Button value);
                /*0x3cfed54*/ UnityEngine.UI.Button get_ReportButton();
                /*0x3cfed5c*/ void set_ReportButton(UnityEngine.UI.Button value);
                /*0x3cfed64*/ Assets.Battle.Hud.NavigationTile[] get_Tips();
                /*0x3cfed6c*/ void set_Tips(Assets.Battle.Hud.NavigationTile[] value);
                /*0x3cfed74*/ UnityEngine.UI.Button get_NextButtonLock();
                /*0x3cfed7c*/ void set_NextButtonLock(UnityEngine.UI.Button value);
                /*0x3cfed84*/ UnityEngine.UI.Button get_ReplayButtonLock();
                /*0x3cfed8c*/ void set_ReplayButtonLock(UnityEngine.UI.Button value);
                /*0x3cfed94*/ UnityEngine.UI.Button get_HomeButtonLock();
                /*0x3cfed9c*/ void set_HomeButtonLock(UnityEngine.UI.Button value);
                /*0x3cfeda4*/ void Show(Assets.Api.Client.BattleOutcome outcome, Assets.GameUi.BattleArguments.BattleTypes battleType, bool homeLock, bool nextLock);
            }

            class ResultRankProgress : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Utilities.FillGauge rankGauge;
                /*0x28*/ TMPro.TextMeshProUGUI currentRank;
                /*0x30*/ TMPro.TextMeshProUGUI rankPoints;

                /*0x3cff064*/ ResultRankProgress();
                /*0x3cfef4c*/ Cysharp.Threading.Tasks.UniTask UpdateRankProgress(int currentPoints, int maxPoints, int rank);
            }

            class ResultRewardsView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ UnityEngine.GameObject label;
                /*0x28*/ UnityEngine.Transform rewardsParent;
                /*0x30*/ UnityEngine.Transform scoreRewardsParent;
                /*0x38*/ Assets.GameUi.Icon.IconBase[] rewardIcons;
                /*0x40*/ Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell[] scoreRewardIcons;
                /*0x48*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> <OnRewardClicked>k__BackingField;

                /*0x3cff77c*/ ResultRewardsView();
                /*0x3cff06c*/ System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> get_OnRewardClicked();
                /*0x3cff074*/ void set_OnRewardClicked(System.Func<Assets.GameUi.Icon.IconBase.IconArgs, Cysharp.Threading.Tasks.UniTask> value);
                /*0x3cff07c*/ Cysharp.Threading.Tasks.UniTask ShowRewards(Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs[] rewards);
                /*0x3cff3fc*/ Cysharp.Threading.Tasks.UniTask ShowRewards(Assets.GameUi.Icon.IconBase.IconArgs[] rewards);

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ Assets.GameUi.Icon.IconBase.IconArgs args;
                    /*0x18*/ Assets.Battle.Hud.ResultRewardsView <>4__this;

                    /*0x3cff774*/ <>c__DisplayClass10_0();
                    /*0x3cff784*/ Cysharp.Threading.Tasks.UniTask <ShowRewards>b__0(UnityEngine.UI.Button icon);

                    struct <<ShowRewards>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Hud.ResultRewardsView.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cff830*/ void MoveNext();
                        /*0x3cffc78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.GameUi.SchoolTacticalExercise.SchoolTacticalExerciseRewardCell.SchoolTacticalExerciseRewardArgs args;
                    /*0x18*/ Assets.Battle.Hud.ResultRewardsView <>4__this;

                    /*0x3cff3f4*/ <>c__DisplayClass9_0();
                    /*0x3cffc84*/ Cysharp.Threading.Tasks.UniTask <ShowRewards>b__0(UnityEngine.UI.Button icon);

                    struct <<ShowRewards>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.Battle.Hud.ResultRewardsView.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3cffd30*/ void MoveNext();
                        /*0x3d00188*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d0026c*/ ShieldDamageText();
                /*0x3d00194*/ UnityEngine.Transform get_Container();
                /*0x3d0019c*/ void set_Container(UnityEngine.Transform value);
                /*0x3d001a4*/ TMPro.TextMeshPro get_Value();
                /*0x3d001ac*/ void set_Value(TMPro.TextMeshPro value);
                /*0x3d001b4*/ TMPro.TextMeshPro get_ShieldValue();
                /*0x3d001bc*/ void set_ShieldValue(TMPro.TextMeshPro value);
                /*0x3d001c4*/ TMPro.TextMeshPro get_AdditionalValue();
                /*0x3d001cc*/ void set_AdditionalValue(TMPro.TextMeshPro value);
                /*0x3d001d4*/ UnityEngine.SpriteRenderer get_ShieldSprite();
                /*0x3d001dc*/ void set_ShieldSprite(UnityEngine.SpriteRenderer value);
                /*0x3d001e4*/ UnityEngine.Vector3 get_PositionOffset();
                /*0x3d001f0*/ void set_PositionOffset(UnityEngine.Vector3 value);
                /*0x3d001fc*/ float get_StartPositionYOffset();
                /*0x3d00204*/ void set_StartPositionYOffset(float value);
                /*0x3d0020c*/ float get_Deviation();
                /*0x3d00214*/ void set_Deviation(float value);
                /*0x3d0021c*/ float get_FadeInDuration();
                /*0x3d00224*/ void set_FadeInDuration(float value);
                /*0x3d0022c*/ float get_MoveInDuration();
                /*0x3d00234*/ void set_MoveInDuration(float value);
                /*0x3d0023c*/ float get_IntervalDuration();
                /*0x3d00244*/ void set_IntervalDuration(float value);
                /*0x3d0024c*/ float get_FadeOutDuration();
                /*0x3d00254*/ void set_FadeOutDuration(float value);
                /*0x3d0025c*/ DG.Tweening.Sequence get_ActiveSequence();
                /*0x3d00264*/ void set_ActiveSequence(DG.Tweening.Sequence value);
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

                /*0x3d01f84*/ SkillNameLabel();
                /*0x3d019dc*/ void Playback(string skillName, Assets.Battle.Hud.SkillNameLabel.FrameTypes type, Assets.Battle.Hud.SkillNameLabel.PointTypes pointType, int pointAmount);
                /*0x3d01f6c*/ void OnDisable();
                /*0x3d01fa4*/ void <Playback>b__12_0();

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

                /*0x3d02384*/ TotalDamageView();
                /*0x3d01fdc*/ void ResetTotalDamage();
                /*0x3d020dc*/ void UpdateTotalDamage(long damage, int hitCount);
            }

            class TurnView : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI turnValue;
                /*0x28*/ TMPro.TextMeshProUGUI turnCount;
                /*0x30*/ bool trigger;

                /*0x3d024f0*/ TurnView();
                /*0x3d023fc*/ void Update();
                /*0x3d0242c*/ Cysharp.Threading.Tasks.UniTask Playback(int turn, int turnsCount);

                struct <Playback>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Hud.TurnView <>4__this;
                    /*0x30*/ int turn;
                    /*0x34*/ int turnsCount;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d024f8*/ void MoveNext();
                    /*0x3d029dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                static /*0x3d031c8*/ Assets.GameUi.Icon.IconBase.IconArgs[] <CreateRewardsIconsArguments>g__CreateIconArgumentsFromMaster|17_0(long id, string name, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing);
                static /*0x3d035fc*/ Assets.GameUi.Icon.IconBase.IconArgs <CreateRewardsIconsArguments>g__CreateIconArguments|17_1(Assets.Api.Client.RewardMaster rewardMaster, string name, Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing);
                /*0x3d029e8*/ BattleEndedEventDirector(Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing, Assets.GameUi.Services.ISchoolTacticalExerciseService schoolTacticalExerciseService, Assets.Api.Client.IApiClient apiClient, Assets.GameUi.Service.IMiningService miningService, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer, Assets.Battle.Overseers.ILayoutOverseer layoutOverseer);
                /*0x3d02b30*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d02c00*/ Cysharp.Threading.Tasks.UniTask ShowResultDamageView();
                /*0x3d02cb0*/ Cysharp.Threading.Tasks.UniTask ShowRewardsView(Assets.Api.Client.BattleEndedEvent eventData);
                /*0x3d0302c*/ Assets.GameUi.Icon.IconBase.IconArgs[] CreateRewardsIconsArguments(Assets.Api.Client.QuestMaster questMaster);
                /*0x3d0346c*/ bool <ShowResultDamageView>b__15_1(Assets.Api.Client.TacticStageResult v);
                /*0x3d03530*/ bool <ShowResultDamageView>b__15_2(Assets.Api.Client.TacticCycleQuestMaster v);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.BattleEndedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.TacticStageResult, long> <>9__15_0;
                    static /*0x10*/ System.Func<Assets.Api.Client.RewardMaster, bool> <>9__17_2;

                    static /*0x3d038a4*/ <>c();
                    /*0x3d0390c*/ <>c();
                    /*0x3d03914*/ long <ShowResultDamageView>b__15_0(Assets.Api.Client.TacticStageResult v);
                    /*0x3d0392c*/ bool <CreateRewardsIconsArguments>b__17_2(Assets.Api.Client.RewardMaster reward);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Assets.Battle.Actor leadActor;
                    /*0x18*/ Assets.Battle.Directors.BattleEndedEventDirector <>4__this;

                    /*0x3d0394c*/ <>c__DisplayClass14_0();
                    /*0x3d03954*/ void <Execute>b__1();
                    /*0x3d03970*/ void <Execute>b__0();
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ string name;
                    /*0x18*/ Assets.GameUi.Icon.IIconArgsFromThing iconArgsFromThing;

                    /*0x3d035f4*/ <>c__DisplayClass17_0();
                    /*0x3d03cb0*/ Assets.GameUi.Icon.IconBase.IconArgs <CreateRewardsIconsArguments>b__3(Assets.Api.Client.RewardMaster rewardMaster);
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

                    /*0x3d03cc0*/ void MoveNext();
                    /*0x3d06a64*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowResultDamageView>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Directors.BattleEndedEventDirector <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.RawRanking>> <>u__1;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                    /*0x3d06a70*/ void MoveNext();
                    /*0x3d07a3c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d07a48*/ BattleStartedEventDirector(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer, Assets.GameUi.Services.IBgmService bgmService, Assets.AssetManagement.IAssetInstanceProvider assetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.GameUi.Service.IUnlockFunctionService unlockFunctionService, Assets.Battle.Overseers.IFieldOverseer fieldOverseer, Assets.GameUi.Externals.IUiLayoutManager uiLayoutManager, Assets.Battle.Overseers.ILayoutOverseer layoutOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer);
                /*0x3d07bbc*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d07c90*/ Cysharp.Threading.Tasks.UniTask PlaybackCharacterVoices(Assets.Battle.Actor[] playerActors, Assets.Battle.Actor[] enemyActors);
                /*0x3d07d78*/ System.Threading.Tasks.Task TryPlaybackMemoryAnimation();
                /*0x3d07e68*/ void <PlaybackCharacterVoices>g__PlaybackVoice|17_0(Assets.Battle.Actor actor, Assets.GameUi.Externals.CharacterBattleVoiceTypes type);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.BattleStartedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Actor, int> <>9__16_0;
                    static /*0x10*/ System.Func<Assets.Api.Client.PawnMasterView, bool> <>9__17_3;

                    static /*0x3d07ff4*/ <>c();
                    /*0x3d0805c*/ <>c();
                    /*0x3d08064*/ int <Execute>b__16_0(Assets.Battle.Actor a);
                    /*0x3d0807c*/ bool <PlaybackCharacterVoices>b__17_3(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Assets.Battle.Actor player;

                    /*0x3d08098*/ <>c__DisplayClass17_0();
                    /*0x3d080a0*/ bool <PlaybackCharacterVoices>b__1(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass17_1
                {
                    /*0x10*/ Assets.Battle.Actor enemy;

                    /*0x3d080dc*/ <>c__DisplayClass17_1();
                    /*0x3d080e4*/ bool <PlaybackCharacterVoices>b__2(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass17_2
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d07fec*/ <>c__DisplayClass17_2();
                    /*0x3d08120*/ void <PlaybackCharacterVoices>b__4();
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ Assets.VisualEffectData.VfxAnimationHandler memoryVfx;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource source;

                    /*0x3d0813c*/ <>c__DisplayClass18_0();
                    /*0x3d08144*/ void <TryPlaybackMemoryAnimation>b__0();
                }

                struct <Execute>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.BattleStartedEventDirector <>4__this;
                    /*0x38*/ Assets.Battle.Actor[] <playerActors>5__2;
                    /*0x40*/ Assets.Battle.Actor[] <enemyActors>5__3;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                    /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__2;
                    /*0x70*/ System.Runtime.CompilerServices.TaskAwaiter <>u__3;

                    /*0x3d08184*/ void MoveNext();
                    /*0x3d0b414*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d0b420*/ void MoveNext();
                    /*0x3d0c3b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d0c3bc*/ void MoveNext();
                    /*0x3d0d868*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d0d8d0*/ PawnUsedSkillEventDirector(Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer);
                /*0x3d0d900*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
            }

            interface IManeuverOrderUpdatedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class ManeuverOrderUpdatedEventDirector : Assets.Battle.Directors.IManeuverOrderUpdatedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;
                /*0x18*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d0da6c*/ ManeuverOrderUpdatedEventDirector(Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d0dab0*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d0dd10*/ void <Execute>g__AddPawnToActionQueue|3_0(Assets.Api.Client.PawnId pawnId, ref Assets.Battle.Directors.ManeuverOrderUpdatedEventDirector.<> );

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

                /*0x3d0de94*/ MasterDataUpdatedEventDirector(Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d0dec4*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
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

                /*0x3d0e034*/ PawnAuraAddedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d0e0a8*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d0e178*/ Cysharp.Threading.Tasks.UniTask AddContinuousVfx(Assets.Battle.Actor actor, string key);

                struct <AddContinuousVfx>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Actor actor;
                    /*0x30*/ string key;
                    /*0x38*/ Assets.Battle.Directors.PawnAuraAddedEventDirector <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d0e25c*/ void MoveNext();
                    /*0x3d0e958*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d0e964*/ void MoveNext();
                    /*0x3d0f594*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d0f5a0*/ PawnAuraRemovedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d0f600*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d0fc00*/ void RemoveContinuousVfx(Assets.Battle.Actor actor, string key);
            }

            interface IPawnAuraUpdatedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnAuraUpdatedEventDirector : Assets.Battle.Directors.IPawnAuraUpdatedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d0fcf8*/ PawnAuraUpdatedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d0fd28*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
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

                /*0x3d0ff3c*/ PawnChargesSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer);
                /*0x3d0ffcc*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Api.Client.PawnChargesSkillEvent eventData;

                    /*0x3d1009c*/ <>c__DisplayClass6_0();
                    /*0x3d100a4*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
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

                    /*0x3d100e0*/ void MoveNext();
                    /*0x3d113f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d11404*/ PawnDiedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d11494*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d11578*/ <>c__DisplayClass6_0();
                    /*0x3d11580*/ void <Execute>b__0();
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

                    /*0x3d1159c*/ void MoveNext();
                    /*0x3d124f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d124fc*/ PawnPreparesSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d1255c*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass4_0
                {
                    /*0x10*/ Assets.Api.Client.PawnPreparesSkillEvent eventData;

                    /*0x3d12640*/ <>c__DisplayClass4_0();
                    /*0x3d12648*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
                }

                struct <Execute>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource;
                    /*0x38*/ Assets.Battle.Directors.PawnPreparesSkillEventDirector <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.VisualEffectData.VfxHandler> <>u__1;

                    /*0x3d12684*/ void MoveNext();
                    /*0x3d12ff8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d13004*/ PawnReceivedDamageEventDirector(Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer);
                /*0x3d130d8*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d131b0*/ void DumpDebugDataToLog(Assets.Api.Client.PawnReceivedDamageEvent eventData);

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ Assets.Api.Client.PawnReceivedDamageEvent eventData;

                    /*0x3d13a50*/ <>c__DisplayClass10_0();
                    /*0x3d13a58*/ bool <DumpDebugDataToLog>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d13a88*/ bool <DumpDebugDataToLog>b__1(Assets.Api.Client.PawnMasterView p);
                    /*0x3d13ab8*/ bool <DumpDebugDataToLog>b__2(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;
                    /*0x18*/ Assets.Api.Client.PawnReceivedDamageEvent eventData;

                    /*0x3d13ae8*/ <>c__DisplayClass9_0();
                    /*0x3d13af0*/ void <Execute>b__1();
                    /*0x3d13b0c*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass9_1
                {
                    /*0x10*/ Assets.Battle.Actor sourcePawn;

                    /*0x3d13b3c*/ <>c__DisplayClass9_1();
                    /*0x3d13b44*/ void <Execute>b__2();
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

                    /*0x3d13b60*/ void MoveNext();
                    /*0x3d168ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d168b8*/ PawnReceivedHealingEventDirector(Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer);
                /*0x3d1695c*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d16a40*/ void DumpDebugDataToLog(Assets.Api.Client.PawnReceivedHealingEvent eventData);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Assets.Api.Client.PawnReceivedHealingEvent eventData;

                    /*0x3d170a0*/ <>c__DisplayClass7_0();
                    /*0x3d170a8*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ Assets.Api.Client.PawnReceivedHealingEvent eventData;

                    /*0x3d17098*/ <>c__DisplayClass8_0();
                    /*0x3d170d8*/ bool <DumpDebugDataToLog>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d17108*/ bool <DumpDebugDataToLog>b__1(Assets.Api.Client.PawnMasterView p);
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

                    /*0x3d17138*/ void MoveNext();
                    /*0x3d18204*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d18210*/ PawnReceivedVfxEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d18284*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d18368*/ Cysharp.Threading.Tasks.UniTask FireCombatText(Assets.Api.Client.PawnReceivedVfxEvent eventData, Assets.Battle.Actor actor);

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Assets.Battle.Directors.PawnReceivedVfxEventDirector <>4__this;
                    /*0x18*/ Assets.Api.Client.PawnReceivedVfxEvent eventData;
                    /*0x20*/ Assets.Battle.Actor actor;

                    /*0x3d18630*/ <>c__DisplayClass5_0();
                    /*0x3d18638*/ void <Execute>b__0(Assets.VisualEffectData.VfxHandler _);

                    struct <<Execute>b__0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.Battle.Directors.PawnReceivedVfxEventDirector.<> <>4__this;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3d186e8*/ void MoveNext();
                        /*0x3d18a08*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d18a14*/ void MoveNext();
                    /*0x3d19778*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d19784*/ PawnResourcesUpdatedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d197f8*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Assets.Api.Client.PawnResourcesUpdatedEvent eventData;

                    /*0x3d19c84*/ <>c__DisplayClass5_0();
                    /*0x3d19c8c*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
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

                static /*0x3d1be08*/ UnityEngine.Vector3 <CalculateTargetPosition>g__GetSingleTargetPosition|20_1(Assets.Battle.Actor[] motionTargets, System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d19cb4*/ PawnsAreTargetedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer vfxOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Shared.ISkillMotionOverseer skillMotionOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Utilities.IMetronome metronome, Assets.Battle.Overseers.IFieldOverseer fieldOverseer);
                /*0x3d19e2c*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d19f18*/ Cysharp.Threading.Tasks.UniTask TryAwaitForMovementCompletionIfNotCompleted(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData);
                /*0x3d19fd4*/ bool CanSkipMotion(Assets.Api.Client.SkillMasterView skillView, Assets.Api.Client.SkillTargetGroupView targetGroupView);
                /*0x3d1a0bc*/ void DumpDebugDataToLog(Assets.Api.Client.PawnsAreTargetedEvent eventData, Assets.Api.Client.SkillMasterView skillView, Assets.Api.Client.SkillTargetGroupView targetGroupView, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData);
                /*0x3d1aeac*/ Assets.Battle.Actor[] SelectMotionTargets(System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targets);
                /*0x3d1affc*/ System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> CreateTargetDataDictionary(Assets.Api.Client.PawnsAreTargetedEvent eventData);
                /*0x3d1b4a0*/ Cysharp.Threading.Tasks.UniTask ShowSkillLabel(Assets.Battle.Actor actor, Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                /*0x3d1b58c*/ Cysharp.Threading.Tasks.UniTask RestoreInterceptorsState(System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targetData);
                /*0x3d1bad4*/ UnityEngine.Vector3 CalculateTargetPosition(Assets.VisualEffectData.VfxHandler vfx, Assets.Battle.Actor actor, Assets.Battle.Actor[] motionTargets, System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions);
                /*0x3d1bf88*/ Cysharp.Threading.Tasks.UniTask<System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3>> TriggerInterceptions(Assets.Battle.Actor actor, System.Collections.Generic.Dictionary<string, System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>> targetData);
                /*0x3d1c0d4*/ Cysharp.Threading.Tasks.UniTask PlaybackSkillMotion(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data, Assets.Api.Client.IBattleEngineEvent eventData, Assets.Battle.IEventProcessor eventProcessor);
                /*0x3d1c1d4*/ Cysharp.Threading.Tasks.UniTask<Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData> CreateSkillData(Assets.Battle.Actor actor, Assets.Battle.Actor[] targets, Assets.Api.Client.SkillMasterView skillView, Assets.Api.Client.SkillTargetGroupView targetGroupView, Assets.Api.Client.PawnsAreTargetedEvent eventData, System.Collections.Generic.Dictionary<Assets.Api.Client.PawnId, UnityEngine.Vector3> interceptorPositions);
                /*0x3d1c368*/ Cysharp.Threading.Tasks.UniTask ProcessNextPossibleEvent(int tick, Assets.Battle.IEventProcessor eventProcessor);
                /*0x3d1c410*/ UnityEngine.Vector3 <CalculateTargetPosition>b__20_0(Assets.Battle.Actor t);
                /*0x3d1c4e8*/ UnityEngine.Vector3 <TriggerInterceptions>b__21_0(Assets.Battle.Actor t);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Cysharp.Threading.Tasks.UniTask, bool> <>9__12_4;
                    static /*0x10*/ System.Func<System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>>, System.Collections.Generic.IEnumerable<Assets.Battle.Actor>> <>9__16_0;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, bool> <>9__23_1;
                    static /*0x20*/ System.Func<Assets.Battle.Actor, Assets.Battle.Shared.SharedActor> <>9__23_2;
                    static /*0x28*/ System.Func<Assets.Battle.Actor, bool> <>9__23_5;

                    static /*0x3d1c5c0*/ <>c();
                    /*0x3d1c628*/ <>c();
                    /*0x3d1c630*/ bool <Execute>b__12_4(Cysharp.Threading.Tasks.UniTask t);
                    /*0x3d1c728*/ System.Collections.Generic.IEnumerable<Assets.Battle.Actor> <SelectMotionTargets>b__16_0(System.ValueTuple<Assets.Battle.Actor, System.Collections.Generic.List<Assets.Battle.Actor>> item);
                    /*0x3d1c808*/ bool <CreateSkillData>b__23_1(Assets.Battle.Actor t);
                    /*0x3d1c820*/ Assets.Battle.Shared.SharedActor <CreateSkillData>b__23_2(Assets.Battle.Actor t);
                    /*0x3d1c8b4*/ bool <CreateSkillData>b__23_5(Assets.Battle.Actor t);
                }

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ Assets.Api.Client.PawnsAreTargetedEvent eventData;
                    /*0x18*/ Assets.Battle.Actor actor;

                    /*0x3d1c8cc*/ <>c__DisplayClass12_0();
                    /*0x3d1c8d4*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
                    /*0x3d1c910*/ bool <Execute>b__1(Assets.Api.Client.SkillTargetGroupView s);
                    /*0x3d1c94c*/ void <Execute>b__2();
                    /*0x3d1c968*/ void <Execute>b__3();
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource completionSource;

                    /*0x3d1c984*/ <>c__DisplayClass13_0();
                    /*0x3d1c98c*/ void <TryAwaitForMovementCompletionIfNotCompleted>b__0(string motion);
                    /*0x3d1ca2c*/ void <TryAwaitForMovementCompletionIfNotCompleted>b__1(string _);
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ Assets.Api.Client.PawnsAreTargetedEvent eventData;

                    /*0x3d1ae94*/ <>c__DisplayClass15_0();
                    /*0x3d1ca74*/ bool <DumpDebugDataToLog>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d1caa4*/ bool <DumpDebugDataToLog>b__1(Assets.Api.Client.PawnMasterView p);
                    /*0x3d1cb94*/ bool <DumpDebugDataToLog>b__2(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass15_1
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView p;

                    /*0x3d1cb8c*/ <>c__DisplayClass15_1();
                    /*0x3d1cc84*/ bool <DumpDebugDataToLog>b__3(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass15_2
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView p;

                    /*0x3d1cc7c*/ <>c__DisplayClass15_2();
                    /*0x3d1ccb4*/ bool <DumpDebugDataToLog>b__4(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass15_3
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView item;

                    /*0x3d1ae9c*/ <>c__DisplayClass15_3();
                    /*0x3d1ccf0*/ bool <DumpDebugDataToLog>b__5(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass15_4
                {
                    /*0x10*/ Assets.Api.Client.PawnMasterView item;

                    /*0x3d1aea4*/ <>c__DisplayClass15_4();
                    /*0x3d1cd20*/ bool <DumpDebugDataToLog>b__6(Assets.Api.Client.PawnViewAndInterceptor t);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x18*/ Assets.Battle.Actor actor;
                    /*0x20*/ Assets.Api.Client.SkillTargetGroupView targetGroupView;

                    /*0x3d1cd54*/ <>c__DisplayClass23_0();
                    /*0x3d1cd5c*/ UnityEngine.Vector3 <CreateSkillData>b__0(Assets.Battle.Actor t);
                    /*0x3d1ce3c*/ Cysharp.Threading.Tasks.UniTask <CreateSkillData>b__4(Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data);
                    /*0x3d1ce60*/ string <CreateSkillData>g__AcquireMotionName|3(Assets.Api.Client.SkillMasterView skillMaster);
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

                    /*0x3d1cf5c*/ void MoveNext();
                    /*0x3d1e554*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d1fa58*/ void MoveNext();
                    /*0x3d22030*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d2203c*/ void MoveNext();
                    /*0x3d22e40*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowSkillLabel>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData data;
                    /*0x30*/ Assets.Battle.Actor actor;
                    /*0x38*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d22e4c*/ void MoveNext();
                    /*0x3d23458*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3d23464*/ void MoveNext();
                    /*0x3d241c8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <TryAwaitForMovementCompletionIfNotCompleted>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Battle.Shared.SharedSkillMotionOverseer.SkillData skillData;
                    /*0x30*/ Assets.Battle.Directors.PawnsAreTargetedEventDirector.<> <>8__1;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d24220*/ void MoveNext();
                    /*0x3d24aa0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d24aac*/ PawnSkippedManeuverEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d24b3c*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d24c0c*/ <>c__DisplayClass6_0();
                    /*0x3d24c14*/ void <Execute>b__0();
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

                    /*0x3d24c30*/ void MoveNext();
                    /*0x3d25fc0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3d25fcc*/ PawnSpawnedEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer, Assets.Battle.ICache cache, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model);
                /*0x3d26070*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class Parameters
                {
                    /*0x10*/ int <Id>k__BackingField;
                    /*0x14*/ Assets.Battle.Actor.AttackTypes <Type>k__BackingField;
                    /*0x18*/ Assets.Battle.Actor.Formation <Formation>k__BackingField;
                    /*0x1c*/ int <PositionIndex>k__BackingField;
                    /*0x20*/ bool <IsEnemyActor>k__BackingField;
                    /*0x24*/ UnityEngine.Vector3 <Position>k__BackingField;

                    /*0x3d261bc*/ Parameters();
                    /*0x3d26150*/ int get_Id();
                    /*0x3d26158*/ void set_Id(int value);
                    /*0x3d26160*/ Assets.Battle.Actor.AttackTypes get_Type();
                    /*0x3d26168*/ void set_Type(Assets.Battle.Actor.AttackTypes value);
                    /*0x3d26170*/ Assets.Battle.Actor.Formation get_Formation();
                    /*0x3d26178*/ void set_Formation(Assets.Battle.Actor.Formation value);
                    /*0x3d26180*/ int get_PositionIndex();
                    /*0x3d26188*/ void set_PositionIndex(int value);
                    /*0x3d26190*/ bool get_IsEnemyActor();
                    /*0x3d26198*/ void set_IsEnemyActor(bool value);
                    /*0x3d261a4*/ UnityEngine.Vector3 get_Position();
                    /*0x3d261b0*/ void set_Position(UnityEngine.Vector3 value);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Assets.Api.Client.PawnSpawnedEvent eventData;
                    /*0x18*/ Assets.Battle.Directors.PawnSpawnedEventDirector <>4__this;

                    /*0x3d261c4*/ <>c__DisplayClass7_0();
                    /*0x3d261cc*/ bool <Execute>b__0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d261fc*/ string <Execute>b__1(string d);
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

                    /*0x3d262b0*/ void MoveNext();
                    /*0x3d28c34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IPawnStoppedChargingSkillEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class PawnStoppedChargingSkillEventDirector : Assets.Battle.Directors.IPawnStoppedChargingSkillEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IActorOverseer actorOverseer;

                /*0x3d28c40*/ PawnStoppedChargingSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d28c70*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
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

                /*0x3d28edc*/ PawnUsesSkillEventDirector(Assets.Battle.Overseers.IActorOverseer actorOverseer, Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.ICockpitOverseer cockpitOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICombatTextOverseer combatTextOverseer, Assets.GameUi.Externals.IAudioManager audioManager);
                /*0x3d28f80*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Assets.Api.Client.PawnUsesSkillEvent eventData;

                    /*0x3d29608*/ <>c__DisplayClass7_0();
                    /*0x3d29610*/ bool <Execute>b__0(Assets.Api.Client.SkillMasterView s);
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

                /*0x3d2964c*/ TurnStartedEventDirector(Assets.Battle.DataModels.IBattleDataStorageModel model, Assets.Battle.Overseers.IHudOverseer hudOverseer, Assets.Battle.Overseers.ICameraOverseer cameraOverseer, Assets.GameUi.Externals.IAudioManager audioManager, Assets.Battle.Overseers.IActorOverseer actorOverseer);
                /*0x3d296dc*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.Directors.TurnStartedEventDirector.<> <>9;
                    static /*0x8*/ System.Func<Assets.Battle.Actor, bool> <>9__6_0;
                    static /*0x10*/ System.Func<Assets.Battle.Actor, long> <>9__6_1;
                    static /*0x18*/ System.Func<Assets.Battle.Actor, bool> <>9__6_2;
                    static /*0x20*/ System.Func<Assets.Battle.Actor, long> <>9__6_3;

                    static /*0x3d297ac*/ <>c();
                    /*0x3d29814*/ <>c();
                    /*0x3d2981c*/ bool <Execute>b__6_0(Assets.Battle.Actor a);
                    /*0x3d2983c*/ long <Execute>b__6_1(Assets.Battle.Actor a);
                    /*0x3d2985c*/ bool <Execute>b__6_2(Assets.Battle.Actor a);
                    /*0x3d2987c*/ long <Execute>b__6_3(Assets.Battle.Actor a);
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Assets.Battle.Actor actor;

                    /*0x3d2989c*/ <>c__DisplayClass6_0();
                    /*0x3d298a4*/ void <Execute>b__4();
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

                    /*0x3d298c0*/ void MoveNext();
                    /*0x3d2aca4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface ITutorialMessageEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class TutorialMessageEventDirector : Assets.Battle.Directors.ITutorialMessageEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer;
                /*0x18*/ Assets.Battle.Overseers.IHudOverseer hudOverseer;

                /*0x3d2acb0*/ TutorialMessageEventDirector(Assets.Battle.Overseers.ITutorialOverseer tutorialOverseer, Assets.Battle.Overseers.IHudOverseer hudOverseer);
                /*0x3d2acf4*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);
                /*0x3d2adc4*/ void <Execute>b__3_0();

                struct <Execute>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.IBattleEngineEvent data;
                    /*0x30*/ Assets.Battle.Directors.TutorialMessageEventDirector <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3d2ae68*/ void MoveNext();
                    /*0x3d2b664*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            interface IWaveStartedEventDirector : Assets.Battle.Directors.IDirector
            {
            }

            class WaveStartedEventDirector : Assets.Battle.Directors.IWaveStartedEventDirector, Assets.Battle.Directors.IDirector
            {
                /*0x10*/ Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer;

                /*0x3d2b670*/ WaveStartedEventDirector(Assets.Battle.Overseers.IVisualEffectsOverseer visualEffectsOverseer);
                /*0x3d2b6a0*/ Cysharp.Threading.Tasks.UniTask Execute(Assets.Api.Client.IBattleEngineEvent data, Assets.Battle.IEventProcessor eventProcessor, Cysharp.Threading.Tasks.UniTaskCompletionSource taskCompletionSource);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ Assets.VisualEffectData.VfxHandler vfx;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource entranceTaskCompletionSource;

                    /*0x3d2b774*/ <>c__DisplayClass2_0();
                    /*0x3d2b77c*/ void <Execute>b__0();
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

                    /*0x3d2b7bc*/ void MoveNext();
                    /*0x3d2c2dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }
        }

        namespace DataModels
        {
            interface IBattleDataStorageModel
            {
                /*0x380b9e8*/ UniRx.ReactiveProperty<int> get_BattleSpeed();
                /*0x380b9e8*/ UniRx.ReactiveProperty<float> get_BattlePlaybackSpeed();
                /*0x380b9e8*/ UniRx.ReactiveProperty<System.ValueTuple<int, int>> get_Turn();
                /*0x380b9e8*/ UniRx.ReactiveProperty<string> get_Quest();
                /*0x380b9e8*/ UniRx.ReactiveProperty<bool> get_EnabledStaticCamera();
                /*0x380b9e8*/ UnityEngine.Vector3[] get_ActorFieldPositions();
                /*0x380d83c*/ void set_ActorFieldPositions(UnityEngine.Vector3[] value);
                /*0x380b9e8*/ Assets.Api.Client.MasterDataView get_MasterData();
                /*0x380d83c*/ void set_MasterData(Assets.Api.Client.MasterDataView value);
                /*0x380b6a0*/ int get_VictoryAdditionalMoveBackCount();
                /*0x380cffc*/ void set_VictoryAdditionalMoveBackCount(int value);
                /*0x380b6a0*/ int get_LoseAdditionalMoveBackCount();
                /*0x380cffc*/ void set_LoseAdditionalMoveBackCount(int value);
                /*0x380b9e8*/ UniRx.ReactiveProperty<bool> get_PauseCurrentEventProcess();
                /*0x380b9e8*/ UnityEngine.Events.UnityEvent get_OnSkipCurrentEventProcess();
                /*0x380b9e8*/ UnityEngine.Events.UnityEvent get_OnProcessSingleEvent();
                /*0x380b9e8*/ UnityEngine.Events.UnityEvent get_UserInputTriggeredEvent();
                /*0x380b9e8*/ Assets.Api.Client.QuestMaster get_QuestMaster();
                /*0x380d83c*/ void set_QuestMaster(Assets.Api.Client.QuestMaster value);
                /*0x380b9e8*/ UniRx.ReactiveProperty<bool> get_EnableGameNotifications();
                /*0x380b9e8*/ Assets.Api.Client.Mining get_Mining();
                /*0x380d83c*/ void set_Mining(Assets.Api.Client.Mining value);
                /*0x380b9e8*/ Assets.Api.Client.User get_User();
                /*0x380d83c*/ void set_User(Assets.Api.Client.User value);
                /*0x380b9e8*/ Assets.Api.Client.PlayerRankMaster get_RankMaster();
                /*0x380d83c*/ void set_RankMaster(Assets.Api.Client.PlayerRankMaster value);
                /*0x380b6a0*/ Assets.Api.Client.BattleOutcome get_Outcome();
                /*0x380cffc*/ void set_Outcome(Assets.Api.Client.BattleOutcome value);
                /*0x380b6a0*/ Assets.GameUi.BattleArguments.BattleTypes get_BattleType();
                /*0x380cffc*/ void set_BattleType(Assets.GameUi.BattleArguments.BattleTypes value);
                /*0x380b128*/ bool get_IsPlayground();
                /*0x380cdf0*/ void set_IsPlayground(bool value);
                /*0x380b128*/ bool get_IsFirstTurnHappend();
                /*0x380cdf0*/ void set_IsFirstTurnHappend(bool value);
                /*0x380b9e8*/ Assets.Battle.Actor get_SkillTarget();
                /*0x380d83c*/ void set_SkillTarget(Assets.Battle.Actor value);
                /*0x380b128*/ bool get_HasLargeScaleMecanim();
                /*0x380cdf0*/ void set_HasLargeScaleMecanim(bool value);
                /*0x380b6a0*/ Assets.GameUi.BattleArguments.BattleTutorialTypes get_Tutorial();
                /*0x380cffc*/ void set_Tutorial(Assets.GameUi.BattleArguments.BattleTutorialTypes value);
                /*0x380b128*/ bool get_DebugMode();
                /*0x380cdf0*/ void set_DebugMode(bool value);
                /*0x380b128*/ bool get_ShowEnemiesHpValue();
                /*0x380cdf0*/ void set_ShowEnemiesHpValue(bool value);
                /*0x380b9e8*/ UniRx.ReactiveProperty<bool> get_EnabledCockpitView();
                /*0x380b828*/ long get_TotalDamageScore();
                /*0x380d438*/ void set_TotalDamageScore(long value);
                /*0x380b128*/ bool get_SlowMotionOnBattleEndWasTriggered();
                /*0x380cdf0*/ void set_SlowMotionOnBattleEndWasTriggered(bool value);
                /*0x380b9e8*/ Assets.Api.Client.PawnId get_MvpAttacker();
                /*0x380d83c*/ void set_MvpAttacker(Assets.Api.Client.PawnId value);
                /*0x380b9e8*/ Assets.Api.Client.PawnId get_MvpDefender();
                /*0x380d83c*/ void set_MvpDefender(Assets.Api.Client.PawnId value);
                /*0x380b9e8*/ Assets.Api.Client.PawnId get_MvpHealer();
                /*0x380d83c*/ void set_MvpHealer(Assets.Api.Client.PawnId value);
                /*0x380b9e8*/ Assets.Battle.BattleController.LocalBattleSettings get_LocalBattleSettings();
                /*0x380d83c*/ void set_LocalBattleSettings(Assets.Battle.BattleController.LocalBattleSettings value);
                /*0x380b128*/ bool get_SingleExtraSkillPerDayEnabled();
                /*0x380cdf0*/ void set_SingleExtraSkillPerDayEnabled(bool value);
                /*0x380b9e8*/ System.Action get_UpdateLocalBattleSettingsCallback();
                /*0x380d83c*/ void set_UpdateLocalBattleSettingsCallback(System.Action value);
                /*0x380cb08*/ void AccelerateBattleSpeed();
                /*0x380b32c*/ bool IsPlayerTeamHasAttributesAdvantages(Assets.Battle.Actor[] playerActors, Assets.Battle.Actor[] enemyActors);
                /*0x380cdf0*/ void InitializeBattleSpeedSettings(bool IsFunctionUnlocked);
                /*0x380cdf0*/ void InitializeCameraSettings(bool IsFunctionUnlocked);
                /*0x380cdf0*/ void InitializeCockpitViewSettings(bool IsFunctionUnlocked);
                bool IsAttributeIsAdvantageous(Assets.Api.Client.CharacterAttributes attackerAttribute, Assets.Api.Client.CharacterAttributes targetAttribute);
                /*0x380b128*/ bool IsPlayerTeamHasAttributesAdvantages();
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

                /*0x3d2c504*/ BattleDataStorageModel();
                /*0x3d2c2e8*/ UniRx.ReactiveProperty<int> get_BattleSpeed();
                /*0x3d2c2f0*/ void set_BattleSpeed(UniRx.ReactiveProperty<int> value);
                /*0x3d2c2f8*/ UniRx.ReactiveProperty<float> get_BattlePlaybackSpeed();
                /*0x3d2c300*/ void set_BattlePlaybackSpeed(UniRx.ReactiveProperty<float> value);
                /*0x3d2c308*/ UniRx.ReactiveProperty<System.ValueTuple<int, int>> get_Turn();
                /*0x3d2c310*/ UniRx.ReactiveProperty<string> get_Quest();
                /*0x3d2c318*/ UniRx.ReactiveProperty<bool> get_EnabledStaticCamera();
                /*0x3d2c320*/ UniRx.ReactiveProperty<bool> get_PauseCurrentEventProcess();
                /*0x3d2c328*/ UniRx.ReactiveProperty<bool> get_EnableGameNotifications();
                /*0x3d2c330*/ UniRx.ReactiveProperty<bool> get_EnabledCockpitView();
                /*0x3d2c338*/ UnityEngine.Events.UnityEvent get_OnSkipCurrentEventProcess();
                /*0x3d2c340*/ UnityEngine.Events.UnityEvent get_OnProcessSingleEvent();
                /*0x3d2c348*/ UnityEngine.Events.UnityEvent get_UserInputTriggeredEvent();
                /*0x3d2c350*/ Assets.Battle.Actor get_SkillTarget();
                /*0x3d2c358*/ void set_SkillTarget(Assets.Battle.Actor value);
                /*0x3d2c360*/ Assets.GameUi.BattleArguments.BattleTutorialTypes get_Tutorial();
                /*0x3d2c368*/ void set_Tutorial(Assets.GameUi.BattleArguments.BattleTutorialTypes value);
                /*0x3d2c370*/ long get_TotalDamageScore();
                /*0x3d2c378*/ void set_TotalDamageScore(long value);
                /*0x3d2c380*/ bool get_SlowMotionOnBattleEndWasTriggered();
                /*0x3d2c388*/ void set_SlowMotionOnBattleEndWasTriggered(bool value);
                /*0x3d2c394*/ Assets.Api.Client.PawnId get_MvpAttacker();
                /*0x3d2c39c*/ void set_MvpAttacker(Assets.Api.Client.PawnId value);
                /*0x3d2c3a4*/ Assets.Api.Client.PawnId get_MvpDefender();
                /*0x3d2c3ac*/ void set_MvpDefender(Assets.Api.Client.PawnId value);
                /*0x3d2c3b4*/ Assets.Api.Client.PawnId get_MvpHealer();
                /*0x3d2c3bc*/ void set_MvpHealer(Assets.Api.Client.PawnId value);
                /*0x3d2c3c4*/ UnityEngine.Vector3[] get_ActorFieldPositions();
                /*0x3d2c3cc*/ void set_ActorFieldPositions(UnityEngine.Vector3[] value);
                /*0x3d2c3d4*/ Assets.Api.Client.MasterDataView get_MasterData();
                /*0x3d2c3dc*/ void set_MasterData(Assets.Api.Client.MasterDataView value);
                /*0x3d2c3e4*/ int get_VictoryAdditionalMoveBackCount();
                /*0x3d2c3ec*/ void set_VictoryAdditionalMoveBackCount(int value);
                /*0x3d2c3f4*/ int get_LoseAdditionalMoveBackCount();
                /*0x3d2c3fc*/ void set_LoseAdditionalMoveBackCount(int value);
                /*0x3d2c404*/ Assets.Api.Client.QuestMaster get_QuestMaster();
                /*0x3d2c40c*/ void set_QuestMaster(Assets.Api.Client.QuestMaster value);
                /*0x3d2c414*/ Assets.Api.Client.Mining get_Mining();
                /*0x3d2c41c*/ void set_Mining(Assets.Api.Client.Mining value);
                /*0x3d2c424*/ Assets.Api.Client.User get_User();
                /*0x3d2c42c*/ void set_User(Assets.Api.Client.User value);
                /*0x3d2c434*/ Assets.Api.Client.PlayerRankMaster get_RankMaster();
                /*0x3d2c43c*/ void set_RankMaster(Assets.Api.Client.PlayerRankMaster value);
                /*0x3d2c444*/ Assets.Api.Client.BattleOutcome get_Outcome();
                /*0x3d2c44c*/ void set_Outcome(Assets.Api.Client.BattleOutcome value);
                /*0x3d2c454*/ Assets.GameUi.BattleArguments.BattleTypes get_BattleType();
                /*0x3d2c45c*/ void set_BattleType(Assets.GameUi.BattleArguments.BattleTypes value);
                /*0x3d2c464*/ bool get_IsPlayground();
                /*0x3d2c46c*/ void set_IsPlayground(bool value);
                /*0x3d2c478*/ bool get_IsFirstTurnHappend();
                /*0x3d2c480*/ void set_IsFirstTurnHappend(bool value);
                /*0x3d2c48c*/ bool get_HasLargeScaleMecanim();
                /*0x3d2c494*/ void set_HasLargeScaleMecanim(bool value);
                /*0x3d2c4a0*/ bool get_DebugMode();
                /*0x3d2c4a8*/ void set_DebugMode(bool value);
                /*0x3d2c4b4*/ bool get_ShowEnemiesHpValue();
                /*0x3d2c4bc*/ void set_ShowEnemiesHpValue(bool value);
                /*0x3d2c4c8*/ Assets.Battle.BattleController.LocalBattleSettings get_LocalBattleSettings();
                /*0x3d2c4d0*/ void set_LocalBattleSettings(Assets.Battle.BattleController.LocalBattleSettings value);
                /*0x3d2c4d8*/ bool get_SingleExtraSkillPerDayEnabled();
                /*0x3d2c4e0*/ void set_SingleExtraSkillPerDayEnabled(bool value);
                /*0x3d2c4ec*/ System.Action get_UpdateLocalBattleSettingsCallback();
                /*0x3d2c4f4*/ void set_UpdateLocalBattleSettingsCallback(System.Action value);
                /*0x3d2cc14*/ void InitializeCameraSettings(bool IsFunctionUnlocked);
                /*0x3d2ccb0*/ void InitializeBattleSpeedSettings(bool IsFunctionUnlocked);
                /*0x3d2cd8c*/ void InitializeCockpitViewSettings(bool IsFunctionUnlocked);
                /*0x3d2ce28*/ void AccelerateBattleSpeed();
                /*0x3d2cedc*/ float SpeedToBattleSpeed(int value);
                /*0x3d2cf00*/ void Dispose();
                /*0x3d2cf64*/ bool IsPlayerTeamHasAttributesAdvantages();
                /*0x3d2d2ac*/ bool IsPlayerTeamHasAttributesAdvantages(Assets.Battle.Actor[] playerActors, Assets.Battle.Actor[] enemyActors);
                /*0x3d2d238*/ bool IsAttributeIsAdvantageous(Assets.Api.Client.CharacterAttributes attackerAttribute, Assets.Api.Client.CharacterAttributes targetAttribute);

                class <>c
                {
                    static /*0x0*/ Assets.Battle.DataModels.BattleDataStorageModel.<> <>9;
                    static /*0x8*/ System.Action<int> <>9__139_0;
                    static /*0x10*/ System.Action<bool> <>9__139_1;
                    static /*0x18*/ System.Action<bool> <>9__139_2;
                    static /*0x20*/ System.Func<Assets.Api.Client.PawnMasterView, bool> <>9__146_0;
                    static /*0x28*/ System.Func<Assets.Api.Client.PawnMasterView, bool> <>9__146_1;

                    static /*0x3d2d58c*/ <>c();
                    /*0x3d2d5f4*/ <>c();
                    /*0x3d2d5fc*/ void <.ctor>b__139_0(int value);
                    /*0x3d2d648*/ void <.ctor>b__139_1(bool value);
                    /*0x3d2d694*/ void <.ctor>b__139_2(bool value);
                    /*0x3d2d6e0*/ bool <IsPlayerTeamHasAttributesAdvantages>b__146_0(Assets.Api.Client.PawnMasterView p);
                    /*0x3d2d710*/ bool <IsPlayerTeamHasAttributesAdvantages>b__146_1(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass147_0
                {
                    /*0x10*/ Assets.Battle.Actor enemyActor;

                    /*0x3d2d57c*/ <>c__DisplayClass147_0();
                    /*0x3d2d740*/ bool <IsPlayerTeamHasAttributesAdvantages>b__0(Assets.Api.Client.PawnMasterView p);
                }

                class <>c__DisplayClass147_1
                {
                    /*0x10*/ Assets.Battle.Actor playerActor;

                    /*0x3d2d584*/ <>c__DisplayClass147_1();
                    /*0x3d2d77c*/ bool <IsPlayerTeamHasAttributesAdvantages>b__1(Assets.Api.Client.PawnMasterView p);
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

                /*0x3d2d918*/ CinemachineLayoutAccessor();
                /*0x3d2d7b8*/ Unity.Cinemachine.CinemachineCamera get_FieldCamera();
                /*0x3d2d7c0*/ void set_FieldCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d7c8*/ Unity.Cinemachine.CinemachineCamera get_FieldOverviewCamera();
                /*0x3d2d7d0*/ void set_FieldOverviewCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d7d8*/ Unity.Cinemachine.CinemachineCamera get_FieldOverviewCameraWithOffset();
                /*0x3d2d7e0*/ void set_FieldOverviewCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d7e8*/ Unity.Cinemachine.CinemachineCamera get_PlayerOverviewCamera();
                /*0x3d2d7f0*/ void set_PlayerOverviewCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d7f8*/ Unity.Cinemachine.CinemachineCamera get_PlayerOverviewCameraWithOffset();
                /*0x3d2d800*/ void set_PlayerOverviewCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d808*/ Unity.Cinemachine.CinemachineCamera get_EnemyOverviewCamera();
                /*0x3d2d810*/ void set_EnemyOverviewCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d818*/ Unity.Cinemachine.CinemachineCamera get_EnemyOverviewCameraWithOffset();
                /*0x3d2d820*/ void set_EnemyOverviewCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d828*/ Unity.Cinemachine.CinemachineCamera get_FocusCamera();
                /*0x3d2d830*/ void set_FocusCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d838*/ Unity.Cinemachine.CinemachineCamera get_FocusCameraWithOffset();
                /*0x3d2d840*/ void set_FocusCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d848*/ Unity.Cinemachine.CinemachineCamera get_TargetFocusCamera();
                /*0x3d2d850*/ void set_TargetFocusCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d858*/ Unity.Cinemachine.CinemachineCamera get_TargetFocusCameraWithOffset();
                /*0x3d2d860*/ void set_TargetFocusCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d868*/ Unity.Cinemachine.CinemachineCamera get_GroupFramingCamera();
                /*0x3d2d870*/ void set_GroupFramingCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d878*/ Unity.Cinemachine.CinemachineCamera get_GroupFramingCameraWithOffset();
                /*0x3d2d880*/ void set_GroupFramingCameraWithOffset(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d888*/ Unity.Cinemachine.CinemachineCamera get_FadeCamera();
                /*0x3d2d890*/ void set_FadeCamera(Unity.Cinemachine.CinemachineCamera value);
                /*0x3d2d898*/ UnityEngine.GameObject get_CameraFollow();
                /*0x3d2d8a0*/ void set_CameraFollow(UnityEngine.GameObject value);
                /*0x3d2d8a8*/ UnityEngine.GameObject get_CameraLookAt();
                /*0x3d2d8b0*/ void set_CameraLookAt(UnityEngine.GameObject value);
                /*0x3d2d8b8*/ Assets.Battle.Utilities.PositionFollower get_FollowAndLookAtContainer();
                /*0x3d2d8c0*/ void set_FollowAndLookAtContainer(Assets.Battle.Utilities.PositionFollower value);
                /*0x3d2d8c8*/ UnityEngine.GameObject get_CameraStaticFollow();
                /*0x3d2d8d0*/ void set_CameraStaticFollow(UnityEngine.GameObject value);
                /*0x3d2d8d8*/ UnityEngine.GameObject get_CameraStaticLookAt();
                /*0x3d2d8e0*/ void set_CameraStaticLookAt(UnityEngine.GameObject value);
                /*0x3d2d8e8*/ UnityEngine.GameObject get_CameraFocusLookAt();
                /*0x3d2d8f0*/ void set_CameraFocusLookAt(UnityEngine.GameObject value);
                /*0x3d2d8f8*/ UnityEngine.GameObject get_CameraFocusFollow();
                /*0x3d2d900*/ void set_CameraFocusFollow(UnityEngine.GameObject value);
                /*0x3d2d908*/ Unity.Cinemachine.CinemachineTargetGroup get_TargetGroup();
                /*0x3d2d910*/ void set_TargetGroup(Unity.Cinemachine.CinemachineTargetGroup value);
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

                /*0x3d2d990*/ LayerOrderAccessor();
                /*0x3d2d920*/ int get_CameraActiveOrder();
                /*0x3d2d928*/ void set_CameraActiveOrder(int value);
                /*0x3d2d930*/ int get_CameraInactiveOrder();
                /*0x3d2d938*/ void set_CameraInactiveOrder(int value);
                /*0x3d2d940*/ int get_CameraFadeOrder();
                /*0x3d2d948*/ void set_CameraFadeOrder(int value);
                /*0x3d2d950*/ int get_ActionCameraOrder();
                /*0x3d2d958*/ void set_ActionCameraOrder(int value);
                /*0x3d2d960*/ int get_StaticCameraOrder();
                /*0x3d2d968*/ void set_StaticCameraOrder(int value);
                /*0x3d2d970*/ int get_ActionCameraExtraSkillOrder();
                /*0x3d2d978*/ void set_ActionCameraExtraSkillOrder(int value);
                /*0x3d2d980*/ int get_EntranceAnimationCameraOrder();
                /*0x3d2d988*/ void set_EntranceAnimationCameraOrder(int value);
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
