class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x8200a74*/ EmbeddedAttribute();
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

                /*0x8200a7c*/ NullableAttribute(byte );
                /*0x8200b04*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x8200b34*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x8200b5c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x8200c4c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    namespace VisualEffectData
    {
        class CameraNoiseParameters
        {
            /*0x10*/ Assets.VisualEffectData.CameraNoiseParameters.NoiseTypes <NoiseType>k__BackingField;
            /*0x14*/ float <AmplitudeGain>k__BackingField;
            /*0x18*/ float <FrequencyGain>k__BackingField;
            /*0x1c*/ float <Duration>k__BackingField;

            /*0x8200c94*/ CameraNoiseParameters();
            /*0x8200c54*/ Assets.VisualEffectData.CameraNoiseParameters.NoiseTypes get_NoiseType();
            /*0x8200c5c*/ void set_NoiseType(Assets.VisualEffectData.CameraNoiseParameters.NoiseTypes value);
            /*0x8200c64*/ float get_AmplitudeGain();
            /*0x8200c6c*/ void set_AmplitudeGain(float value);
            /*0x8200c74*/ float get_FrequencyGain();
            /*0x8200c7c*/ void set_FrequencyGain(float value);
            /*0x8200c84*/ float get_Duration();
            /*0x8200c8c*/ void set_Duration(float value);

            enum NoiseTypes
            {
                Shake = 0,
                Wobble = 1,
            }
        }

        class CustomProjectileEmitter
        {
            /*0x10*/ string <BoneAttachementName>k__BackingField;
            /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <ProjectileEmitter>k__BackingField;

            /*0x8200cd4*/ CustomProjectileEmitter();
            /*0x8200cb4*/ string get_BoneAttachementName();
            /*0x8200cbc*/ void set_BoneAttachementName(string value);
            /*0x8200cc4*/ Assets.VisualEffectData.ProjectileEmitter get_ProjectileEmitter();
            /*0x8200ccc*/ void set_ProjectileEmitter(Assets.VisualEffectData.ProjectileEmitter value);
        }

        class DarkFlashParameters
        {
            /*0x10*/ int <FlashCount>k__BackingField;
            /*0x14*/ int <FlashDelay>k__BackingField;
            /*0x18*/ float <FlashInDuration>k__BackingField;
            /*0x1c*/ float <FlashOutDuration>k__BackingField;
            /*0x20*/ UnityEngine.Color <Color>k__BackingField;

            /*0x8200d60*/ DarkFlashParameters();
            /*0x8200d08*/ int get_FlashCount();
            /*0x8200d10*/ void set_FlashCount(int value);
            /*0x8200d18*/ int get_FlashDelay();
            /*0x8200d20*/ void set_FlashDelay(int value);
            /*0x8200d28*/ float get_FlashInDuration();
            /*0x8200d30*/ void set_FlashInDuration(float value);
            /*0x8200d38*/ float get_FlashOutDuration();
            /*0x8200d40*/ void set_FlashOutDuration(float value);
            /*0x8200d48*/ UnityEngine.Color get_Color();
            /*0x8200d54*/ void set_Color(UnityEngine.Color value);
        }

        class LightFlashParameters
        {
            /*0x10*/ int <FlashCount>k__BackingField;
            /*0x14*/ int <FlashDelay>k__BackingField;
            /*0x18*/ float <FlashInDuration>k__BackingField;
            /*0x1c*/ float <FlashOutDuration>k__BackingField;
            /*0x20*/ UnityEngine.Color <LightColor>k__BackingField;
            /*0x30*/ UnityEngine.Color <ShadowColor>k__BackingField;

            /*0x8200df8*/ LightFlashParameters();
            /*0x8200d88*/ int get_FlashCount();
            /*0x8200d90*/ void set_FlashCount(int value);
            /*0x8200d98*/ int get_FlashDelay();
            /*0x8200da0*/ void set_FlashDelay(int value);
            /*0x8200da8*/ float get_FlashInDuration();
            /*0x8200db0*/ void set_FlashInDuration(float value);
            /*0x8200db8*/ float get_FlashOutDuration();
            /*0x8200dc0*/ void set_FlashOutDuration(float value);
            /*0x8200dc8*/ UnityEngine.Color get_LightColor();
            /*0x8200dd4*/ void set_LightColor(UnityEngine.Color value);
            /*0x8200de0*/ UnityEngine.Color get_ShadowColor();
            /*0x8200dec*/ void set_ShadowColor(UnityEngine.Color value);
        }

        class LineSegmentHandler : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Vector3 <Origin>k__BackingField;
            /*0x2c*/ UnityEngine.Vector3 <Target>k__BackingField;
            /*0x38*/ float <Deviation>k__BackingField;
            /*0x3c*/ float time;

            /*0x8200fe8*/ LineSegmentHandler();
            /*0x8200e24*/ UnityEngine.Vector3 get_Origin();
            /*0x8200e30*/ void set_Origin(UnityEngine.Vector3 value);
            /*0x8200e3c*/ UnityEngine.Vector3 get_Target();
            /*0x8200e48*/ void set_Target(UnityEngine.Vector3 value);
            /*0x8200e54*/ float get_Deviation();
            /*0x8200e5c*/ void set_Deviation(float value);
            /*0x8200e64*/ void Update();
        }

        class Projectile : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.VisualEffectData.VfxHandler <VfxHandler>k__BackingField;
            /*0x28*/ UnityEngine.Vector3 <Origin>k__BackingField;
            /*0x34*/ UnityEngine.Vector3 <Target>k__BackingField;
            /*0x40*/ float <Time>k__BackingField;
            /*0x44*/ float <CurveRadius>k__BackingField;
            /*0x48*/ float <CurveDegree>k__BackingField;
            /*0x4c*/ float <CurveDistance>k__BackingField;
            /*0x50*/ bool <LookAtTarget>k__BackingField;
            /*0x54*/ UnityEngine.Vector3 curve;

            /*0x8201464*/ Projectile();
            /*0x8200ff0*/ Assets.VisualEffectData.VfxHandler get_VfxHandler();
            /*0x8200ff8*/ void set_VfxHandler(Assets.VisualEffectData.VfxHandler value);
            /*0x8201000*/ UnityEngine.Vector3 get_Origin();
            /*0x820100c*/ void set_Origin(UnityEngine.Vector3 value);
            /*0x8201018*/ UnityEngine.Vector3 get_Target();
            /*0x8201024*/ void set_Target(UnityEngine.Vector3 value);
            /*0x8201030*/ float get_Time();
            /*0x8201038*/ void set_Time(float value);
            /*0x8201040*/ float get_CurveRadius();
            /*0x8201048*/ void set_CurveRadius(float value);
            /*0x8201050*/ float get_CurveDegree();
            /*0x8201058*/ void set_CurveDegree(float value);
            /*0x8201060*/ float get_CurveDistance();
            /*0x8201068*/ void set_CurveDistance(float value);
            /*0x8201070*/ bool get_LookAtTarget();
            /*0x8201078*/ void set_LookAtTarget(bool value);
            /*0x8201084*/ void Update();
            /*0x8201400*/ UnityEngine.Vector3 Bezier(UnityEngine.Vector3 position, UnityEngine.Vector3 curvePoint, UnityEngine.Vector3 target, float time);
        }

        class ProjectileEmitter : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.VisualEffectData.Projectile projectilePrefab;
            /*0x28*/ Assets.VisualEffectData.VfxHandler impactPrefab;
            /*0x30*/ Assets.VisualEffectData.VfxHandler initiationPrefab;
            /*0x38*/ UnityEngine.Vector2 durationMinMax;
            /*0x40*/ UnityEngine.Vector2 delayMinMax;
            /*0x48*/ UnityEngine.Vector2 curveRadiusMinMax;
            /*0x50*/ UnityEngine.Vector2 curveDegreeMinMax;
            /*0x58*/ float deviationRadius;
            /*0x5c*/ int loopCount;
            /*0x60*/ float delayBetweenLoops;
            /*0x64*/ bool lookAtTarget;
            /*0x65*/ bool trigger;
            /*0x68*/ Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea <DeviationAxis>k__BackingField;
            /*0x70*/ UnityEngine.Vector3[] <Targets>k__BackingField;
            /*0x78*/ UnityEngine.Vector3[] <EmittionPoints>k__BackingField;
            /*0x80*/ UnityEngine.Events.UnityEvent <OnLoopEndEventReceived>k__BackingField;
            /*0x88*/ UnityEngine.Events.UnityEvent <OnImpactEventReceived>k__BackingField;
            /*0x90*/ UnityEngine.Events.UnityEvent <OnLastImpactEventReceived>k__BackingField;
            /*0x98*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> <OnVfxHandlerCreated>k__BackingField;
            /*0xa0*/ System.Func<UnityEngine.GameObject, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> <CustomPoolGet>k__BackingField;
            /*0xa8*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.Projectile> projectilePool;
            /*0xb0*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.VfxHandler> impactPool;
            /*0xb8*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.VfxHandler> initiationPool;

            /*0x8201e08*/ ProjectileEmitter();
            /*0x820146c*/ Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea get_DeviationAxis();
            /*0x8201474*/ void set_DeviationAxis(Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea value);
            /*0x820147c*/ UnityEngine.Vector3[] get_Targets();
            /*0x8201484*/ void set_Targets(UnityEngine.Vector3[] value);
            /*0x820148c*/ UnityEngine.Vector3[] get_EmittionPoints();
            /*0x8201494*/ void set_EmittionPoints(UnityEngine.Vector3[] value);
            /*0x820149c*/ UnityEngine.Events.UnityEvent get_OnLoopEndEventReceived();
            /*0x82014a4*/ void set_OnLoopEndEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82014ac*/ UnityEngine.Events.UnityEvent get_OnImpactEventReceived();
            /*0x82014b4*/ void set_OnImpactEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82014bc*/ UnityEngine.Events.UnityEvent get_OnLastImpactEventReceived();
            /*0x82014c4*/ void set_OnLastImpactEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82014cc*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> get_OnVfxHandlerCreated();
            /*0x82014d4*/ void set_OnVfxHandlerCreated(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> value);
            /*0x82014dc*/ System.Func<UnityEngine.GameObject, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> get_CustomPoolGet();
            /*0x82014e4*/ void set_CustomPoolGet(System.Func<UnityEngine.GameObject, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> value);
            /*0x82014ec*/ void Update();
            /*0x82015cc*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.Projectile> CreateProjectilePool();
            /*0x8201868*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.VfxHandler> CreateImpactPool();
            /*0x8201b04*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.VfxHandler> CreateInitiationPool();
            /*0x8201514*/ Cysharp.Threading.Tasks.UniTask Fire();
            /*0x8201da0*/ UnityEngine.Vector3 TryToApplyDeviation(UnityEngine.Vector3 position, float radius, Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea axis);
            /*0x8202060*/ Assets.VisualEffectData.Projectile <CreateProjectilePool>b__48_0();
            /*0x82021f8*/ Assets.VisualEffectData.VfxHandler <CreateImpactPool>b__49_0();
            /*0x82023b0*/ Assets.VisualEffectData.VfxHandler <CreateInitiationPool>b__50_0();

            enum DeviationAxisArea
            {
                XY = 0,
                XZ = 1,
            }

            class <>c
            {
                static /*0x0*/ Assets.VisualEffectData.ProjectileEmitter.<> <>9;
                static /*0x8*/ System.Action<Assets.VisualEffectData.Projectile> <>9__48_1;
                static /*0x10*/ System.Action<Assets.VisualEffectData.Projectile> <>9__48_2;
                static /*0x18*/ System.Action<Assets.VisualEffectData.Projectile> <>9__48_3;
                static /*0x20*/ System.Action<Assets.VisualEffectData.VfxHandler> <>9__49_1;
                static /*0x28*/ System.Action<Assets.VisualEffectData.VfxHandler> <>9__49_2;
                static /*0x30*/ System.Action<Assets.VisualEffectData.VfxHandler> <>9__49_3;
                static /*0x38*/ System.Action<Assets.VisualEffectData.VfxHandler> <>9__50_1;
                static /*0x40*/ System.Action<Assets.VisualEffectData.VfxHandler> <>9__50_2;
                static /*0x48*/ System.Action<Assets.VisualEffectData.VfxHandler> <>9__50_3;

                static /*0x8202568*/ <>c();
                /*0x82025d0*/ <>c();
                /*0x82025d8*/ void <CreateProjectilePool>b__48_1(Assets.VisualEffectData.Projectile instance);
                /*0x8202668*/ void <CreateProjectilePool>b__48_2(Assets.VisualEffectData.Projectile instance);
                /*0x8202694*/ void <CreateProjectilePool>b__48_3(Assets.VisualEffectData.Projectile instance);
                /*0x8202708*/ void <CreateImpactPool>b__49_1(Assets.VisualEffectData.VfxHandler instance);
                /*0x8202798*/ void <CreateImpactPool>b__49_2(Assets.VisualEffectData.VfxHandler instance);
                /*0x82027c4*/ void <CreateImpactPool>b__49_3(Assets.VisualEffectData.VfxHandler instance);
                /*0x8202838*/ void <CreateInitiationPool>b__50_1(Assets.VisualEffectData.VfxHandler instance);
                /*0x82028c8*/ void <CreateInitiationPool>b__50_2(Assets.VisualEffectData.VfxHandler instance);
                /*0x82028f4*/ void <CreateInitiationPool>b__50_3(Assets.VisualEffectData.VfxHandler instance);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ Assets.VisualEffectData.Projectile instance;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x82021f0*/ <>c__DisplayClass48_0();
                /*0x8202968*/ void <CreateProjectilePool>b__4();
            }

            class <>c__DisplayClass49_0
            {
                /*0x10*/ Assets.VisualEffectData.VfxHandler instance;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x82023a8*/ <>c__DisplayClass49_0();
                /*0x82029d0*/ void <CreateImpactPool>b__4();
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ Assets.VisualEffectData.VfxHandler instance;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x8202560*/ <>c__DisplayClass50_0();
                /*0x8202a38*/ void <CreateInitiationPool>b__4();
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ int impactAmountHappend;
                /*0x14*/ int impactAmount;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x8202aa0*/ <>c__DisplayClass51_0();
            }

            class <>c__DisplayClass51_1
            {
                /*0x10*/ Assets.VisualEffectData.Projectile projectile;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter.<> CS$<>8__locals1;

                /*0x8202aa8*/ <>c__DisplayClass51_1();
                /*0x8202ab0*/ float <Fire>b__0();
                /*0x8202acc*/ void <Fire>b__1(float value);
                /*0x8202ae8*/ void <Fire>b__2();

                struct <<Fire>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ Assets.VisualEffectData.ProjectileEmitter.<> <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x8202b9c*/ void MoveNext();
                    /*0x8203274*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct <Fire>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;
                /*0x30*/ Assets.VisualEffectData.ProjectileEmitter.<> <>8__1;
                /*0x38*/ Assets.VisualEffectData.ProjectileEmitter.<> <>8__2;
                /*0x40*/ int <targetIndex>5__2;
                /*0x44*/ int <i>5__3;
                /*0x48*/ UnityEngine.Vector3[] <>7__wrap3;
                /*0x50*/ int <>7__wrap4;
                /*0x54*/ UnityEngine.Vector3 <item>5__6;
                /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;
                /*0x78*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                /*0x8203280*/ void MoveNext();
                /*0x820467c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class TimeStopParameters
        {
            /*0x10*/ float <Value>k__BackingField;
            /*0x14*/ float <Duration>k__BackingField;

            /*0x82046a8*/ TimeStopParameters();
            /*0x8204688*/ float get_Value();
            /*0x8204690*/ void set_Value(float value);
            /*0x8204698*/ float get_Duration();
            /*0x82046a0*/ void set_Duration(float value);
        }

        class VfxAnchorOverride : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.VisualEffectData.VfxAnchorOverride.AnchorTypes <Type>k__BackingField;

            /*0x82046cc*/ VfxAnchorOverride();
            /*0x82046bc*/ Assets.VisualEffectData.VfxAnchorOverride.AnchorTypes get_Type();
            /*0x82046c4*/ void set_Type(Assets.VisualEffectData.VfxAnchorOverride.AnchorTypes value);

            enum AnchorTypes
            {
                None = 0,
                Top = 1,
                TopLeft = 2,
                TopRight = 3,
                Bottom = 4,
                BottomLeft = 5,
                BottomRight = 6,
                Right = 7,
                Left = 8,
            }
        }

        class VfxAnimationHandler : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Animator animator;
            /*0x28*/ UnityEngine.Transform[] AttachementSlots;
            /*0x30*/ UnityEngine.AudioClip <AudioClip>k__BackingField;
            /*0x38*/ UnityEngine.Events.UnityEvent <OnEndEventReceived>k__BackingField;
            /*0x40*/ UnityEngine.Events.UnityEvent <OnActionEventReceived>k__BackingField;
            /*0x48*/ UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> <OnEnabled>k__BackingField;

            /*0x8204c54*/ VfxAnimationHandler();
            /*0x82046d4*/ UnityEngine.AudioClip get_AudioClip();
            /*0x82046dc*/ void set_AudioClip(UnityEngine.AudioClip value);
            /*0x82046e4*/ UnityEngine.Events.UnityEvent get_OnEndEventReceived();
            /*0x82046ec*/ void set_OnEndEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82046f4*/ UnityEngine.Events.UnityEvent get_OnActionEventReceived();
            /*0x82046fc*/ void set_OnActionEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x8204704*/ UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> get_OnEnabled();
            /*0x820470c*/ void set_OnEnabled(UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> value);
            /*0x8204714*/ void VFX_EVENT_Action();
            /*0x8204728*/ void VFX_EVENT_End();
            /*0x820473c*/ void OnEnable();
            /*0x82047d4*/ void Attach(UnityEngine.Transform target, int slotIndex);
            /*0x8204bbc*/ void SetAnimatorSpeed(float value);
        }

        class VfxHandler : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Animator animator;
            /*0x28*/ UnityEngine.ParticleSystem[] particleSystems;
            /*0x30*/ Assets.VisualEffectData.VfxHandler afterEffectPrefab;
            /*0x38*/ UnityEngine.Color flashLightColor;
            /*0x48*/ UnityEngine.Color flashShadowColor;
            /*0x58*/ UnityEngine.Color darkFlashLightColor;
            /*0x68*/ UnityEngine.AudioClip <AudioClip>k__BackingField;
            /*0x70*/ Assets.VisualEffectData.ProjectileEmitter <ProjectileEmitter>k__BackingField;
            /*0x78*/ Assets.VisualEffectData.CustomProjectileEmitter[] <CustomProjectileEmitters>k__BackingField;
            /*0x80*/ Assets.VisualEffectData.VfxHandler <AreaVfxPrefab>k__BackingField;
            /*0x88*/ UnityEngine.Events.UnityEvent <OnEndEventReceived>k__BackingField;
            /*0x90*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.LightFlashParameters> <OnLightFlashEventReceived>k__BackingField;
            /*0x98*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.DarkFlashParameters> <OnDarkFlashEventReceived>k__BackingField;
            /*0xa0*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.CameraNoiseParameters> <OnCameraNoiseEventReceived>k__BackingField;
            /*0xa8*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.TimeStopParameters> <OnTimeStopEventReceived>k__BackingField;
            /*0xb0*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> <OnActionEventReceived>k__BackingField;
            /*0xb8*/ UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> <OnEnabled>k__BackingField;

            /*0x8205d20*/ VfxHandler();
            /*0x8204da8*/ UnityEngine.AudioClip get_AudioClip();
            /*0x8204db0*/ void set_AudioClip(UnityEngine.AudioClip value);
            /*0x8204db8*/ Assets.VisualEffectData.ProjectileEmitter get_ProjectileEmitter();
            /*0x8204dc0*/ void set_ProjectileEmitter(Assets.VisualEffectData.ProjectileEmitter value);
            /*0x8204dc8*/ Assets.VisualEffectData.CustomProjectileEmitter[] get_CustomProjectileEmitters();
            /*0x8204dd0*/ void set_CustomProjectileEmitters(Assets.VisualEffectData.CustomProjectileEmitter[] value);
            /*0x8204dd8*/ Assets.VisualEffectData.VfxHandler get_AreaVfxPrefab();
            /*0x8204de0*/ void set_AreaVfxPrefab(Assets.VisualEffectData.VfxHandler value);
            /*0x8204de8*/ UnityEngine.Events.UnityEvent get_OnEndEventReceived();
            /*0x8204df0*/ void set_OnEndEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x8204df8*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.LightFlashParameters> get_OnLightFlashEventReceived();
            /*0x8204e00*/ void set_OnLightFlashEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.LightFlashParameters> value);
            /*0x8204e08*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.DarkFlashParameters> get_OnDarkFlashEventReceived();
            /*0x8204e10*/ void set_OnDarkFlashEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.DarkFlashParameters> value);
            /*0x8204e18*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.CameraNoiseParameters> get_OnCameraNoiseEventReceived();
            /*0x8204e20*/ void set_OnCameraNoiseEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.CameraNoiseParameters> value);
            /*0x8204e28*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.TimeStopParameters> get_OnTimeStopEventReceived();
            /*0x8204e30*/ void set_OnTimeStopEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.TimeStopParameters> value);
            /*0x8204e38*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> get_OnActionEventReceived();
            /*0x8204e40*/ void set_OnActionEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> value);
            /*0x8204e48*/ UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> get_OnEnabled();
            /*0x8204e50*/ void set_OnEnabled(UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> value);
            /*0x8204e58*/ void OnEnable();
            /*0x8204ef0*/ void Update();
            /*0x8205044*/ void SetOrderInLayer(int orderInLayer);
            /*0x820514c*/ void Play(int orderInLayer);
            /*0x8205244*/ void Play();
            /*0x8205184*/ void PlayEmitters();
            /*0x82031b4*/ void StopEmitters();
            /*0x8205274*/ void VFX_EVENT_Action();
            /*0x82052d0*/ void VFX_EVENT_LightFlash(string data);
            /*0x8205668*/ void VFX_EVENT_DarkFlash(string data);
            /*0x820587c*/ void VFX_EVENT_TimeStop(string data);
            /*0x8205a50*/ void VFX_EVENT_CameraNoise(string data);
            /*0x8205518*/ UnityEngine.Color ExtractColor(string data, UnityEngine.Color defaultValue);
            /*0x8205c94*/ int ExtractInt(string data, int defaultValue);
            /*0x8205ccc*/ float ExtractFloat(string data, float defaultValue);
            /*0x8205d0c*/ void VFX_EVENT_End();
        }

        class VfxTargetOverride : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.VisualEffectData.VfxTargetOverride.ValueTypes <Value>k__BackingField;
            /*0x24*/ Assets.VisualEffectData.VfxTargetOverride.OffsetTypes <Offset>k__BackingField;

            /*0x820609c*/ VfxTargetOverride();
            /*0x820607c*/ Assets.VisualEffectData.VfxTargetOverride.ValueTypes get_Value();
            /*0x8206084*/ void set_Value(Assets.VisualEffectData.VfxTargetOverride.ValueTypes value);
            /*0x820608c*/ Assets.VisualEffectData.VfxTargetOverride.OffsetTypes get_Offset();
            /*0x8206094*/ void set_Offset(Assets.VisualEffectData.VfxTargetOverride.OffsetTypes value);

            enum ValueTypes
            {
                None = 0,
                Centroid = 1,
                GroupCenter = 2,
                FieldCenter = 3,
                FrontLine = 4,
                BackLine = 5,
            }

            enum OffsetTypes
            {
                None = 0,
                Ground = 1,
                Overhead = 2,
            }
        }

        namespace VisualEffects
        {
            class AdventureTitle : UnityEngine.MonoBehaviour
            {
                /*0x20*/ TMPro.TextMeshProUGUI <Title>k__BackingField;
                /*0x28*/ TMPro.TextMeshProUGUI <Body>k__BackingField;

                /*0x82060c4*/ AdventureTitle();
                /*0x82060a4*/ TMPro.TextMeshProUGUI get_Title();
                /*0x82060ac*/ void set_Title(TMPro.TextMeshProUGUI value);
                /*0x82060b4*/ TMPro.TextMeshProUGUI get_Body();
                /*0x82060bc*/ void set_Body(TMPro.TextMeshProUGUI value);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 85FDBE913E543FC739178CD344C5FA1886ACF9B5A0280900E88B6067429653A1;
    static /*0x266*/ <PrivateImplementationDetails> E254C140B456676172B2CB725D548F7F437936B529CA2142DC47CA9A22B91232;

    struct __StaticArrayInitTypeSize=614
    {
    }

    struct __StaticArrayInitTypeSize=691
    {
    }
}
