class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x8217ea4*/ EmbeddedAttribute();
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

                /*0x8217eac*/ NullableAttribute(byte );
                /*0x8217f34*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x8217f64*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x8217f8c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x821807c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            /*0x82180c4*/ CameraNoiseParameters();
            /*0x8218084*/ Assets.VisualEffectData.CameraNoiseParameters.NoiseTypes get_NoiseType();
            /*0x821808c*/ void set_NoiseType(Assets.VisualEffectData.CameraNoiseParameters.NoiseTypes value);
            /*0x8218094*/ float get_AmplitudeGain();
            /*0x821809c*/ void set_AmplitudeGain(float value);
            /*0x82180a4*/ float get_FrequencyGain();
            /*0x82180ac*/ void set_FrequencyGain(float value);
            /*0x82180b4*/ float get_Duration();
            /*0x82180bc*/ void set_Duration(float value);

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

            /*0x8218104*/ CustomProjectileEmitter();
            /*0x82180e4*/ string get_BoneAttachementName();
            /*0x82180ec*/ void set_BoneAttachementName(string value);
            /*0x82180f4*/ Assets.VisualEffectData.ProjectileEmitter get_ProjectileEmitter();
            /*0x82180fc*/ void set_ProjectileEmitter(Assets.VisualEffectData.ProjectileEmitter value);
        }

        class DarkFlashParameters
        {
            /*0x10*/ int <FlashCount>k__BackingField;
            /*0x14*/ int <FlashDelay>k__BackingField;
            /*0x18*/ float <FlashInDuration>k__BackingField;
            /*0x1c*/ float <FlashOutDuration>k__BackingField;
            /*0x20*/ UnityEngine.Color <Color>k__BackingField;

            /*0x8218190*/ DarkFlashParameters();
            /*0x8218138*/ int get_FlashCount();
            /*0x8218140*/ void set_FlashCount(int value);
            /*0x8218148*/ int get_FlashDelay();
            /*0x8218150*/ void set_FlashDelay(int value);
            /*0x8218158*/ float get_FlashInDuration();
            /*0x8218160*/ void set_FlashInDuration(float value);
            /*0x8218168*/ float get_FlashOutDuration();
            /*0x8218170*/ void set_FlashOutDuration(float value);
            /*0x8218178*/ UnityEngine.Color get_Color();
            /*0x8218184*/ void set_Color(UnityEngine.Color value);
        }

        class LightFlashParameters
        {
            /*0x10*/ int <FlashCount>k__BackingField;
            /*0x14*/ int <FlashDelay>k__BackingField;
            /*0x18*/ float <FlashInDuration>k__BackingField;
            /*0x1c*/ float <FlashOutDuration>k__BackingField;
            /*0x20*/ UnityEngine.Color <LightColor>k__BackingField;
            /*0x30*/ UnityEngine.Color <ShadowColor>k__BackingField;

            /*0x8218228*/ LightFlashParameters();
            /*0x82181b8*/ int get_FlashCount();
            /*0x82181c0*/ void set_FlashCount(int value);
            /*0x82181c8*/ int get_FlashDelay();
            /*0x82181d0*/ void set_FlashDelay(int value);
            /*0x82181d8*/ float get_FlashInDuration();
            /*0x82181e0*/ void set_FlashInDuration(float value);
            /*0x82181e8*/ float get_FlashOutDuration();
            /*0x82181f0*/ void set_FlashOutDuration(float value);
            /*0x82181f8*/ UnityEngine.Color get_LightColor();
            /*0x8218204*/ void set_LightColor(UnityEngine.Color value);
            /*0x8218210*/ UnityEngine.Color get_ShadowColor();
            /*0x821821c*/ void set_ShadowColor(UnityEngine.Color value);
        }

        class LineSegmentHandler : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Vector3 <Origin>k__BackingField;
            /*0x2c*/ UnityEngine.Vector3 <Target>k__BackingField;
            /*0x38*/ float <Deviation>k__BackingField;
            /*0x3c*/ float time;

            /*0x8218418*/ LineSegmentHandler();
            /*0x8218254*/ UnityEngine.Vector3 get_Origin();
            /*0x8218260*/ void set_Origin(UnityEngine.Vector3 value);
            /*0x821826c*/ UnityEngine.Vector3 get_Target();
            /*0x8218278*/ void set_Target(UnityEngine.Vector3 value);
            /*0x8218284*/ float get_Deviation();
            /*0x821828c*/ void set_Deviation(float value);
            /*0x8218294*/ void Update();
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

            /*0x8218894*/ Projectile();
            /*0x8218420*/ Assets.VisualEffectData.VfxHandler get_VfxHandler();
            /*0x8218428*/ void set_VfxHandler(Assets.VisualEffectData.VfxHandler value);
            /*0x8218430*/ UnityEngine.Vector3 get_Origin();
            /*0x821843c*/ void set_Origin(UnityEngine.Vector3 value);
            /*0x8218448*/ UnityEngine.Vector3 get_Target();
            /*0x8218454*/ void set_Target(UnityEngine.Vector3 value);
            /*0x8218460*/ float get_Time();
            /*0x8218468*/ void set_Time(float value);
            /*0x8218470*/ float get_CurveRadius();
            /*0x8218478*/ void set_CurveRadius(float value);
            /*0x8218480*/ float get_CurveDegree();
            /*0x8218488*/ void set_CurveDegree(float value);
            /*0x8218490*/ float get_CurveDistance();
            /*0x8218498*/ void set_CurveDistance(float value);
            /*0x82184a0*/ bool get_LookAtTarget();
            /*0x82184a8*/ void set_LookAtTarget(bool value);
            /*0x82184b4*/ void Update();
            /*0x8218830*/ UnityEngine.Vector3 Bezier(UnityEngine.Vector3 position, UnityEngine.Vector3 curvePoint, UnityEngine.Vector3 target, float time);
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

            /*0x8219238*/ ProjectileEmitter();
            /*0x821889c*/ Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea get_DeviationAxis();
            /*0x82188a4*/ void set_DeviationAxis(Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea value);
            /*0x82188ac*/ UnityEngine.Vector3[] get_Targets();
            /*0x82188b4*/ void set_Targets(UnityEngine.Vector3[] value);
            /*0x82188bc*/ UnityEngine.Vector3[] get_EmittionPoints();
            /*0x82188c4*/ void set_EmittionPoints(UnityEngine.Vector3[] value);
            /*0x82188cc*/ UnityEngine.Events.UnityEvent get_OnLoopEndEventReceived();
            /*0x82188d4*/ void set_OnLoopEndEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82188dc*/ UnityEngine.Events.UnityEvent get_OnImpactEventReceived();
            /*0x82188e4*/ void set_OnImpactEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82188ec*/ UnityEngine.Events.UnityEvent get_OnLastImpactEventReceived();
            /*0x82188f4*/ void set_OnLastImpactEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x82188fc*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> get_OnVfxHandlerCreated();
            /*0x8218904*/ void set_OnVfxHandlerCreated(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> value);
            /*0x821890c*/ System.Func<UnityEngine.GameObject, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> get_CustomPoolGet();
            /*0x8218914*/ void set_CustomPoolGet(System.Func<UnityEngine.GameObject, Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject>> value);
            /*0x821891c*/ void Update();
            /*0x82189fc*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.Projectile> CreateProjectilePool();
            /*0x8218c98*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.VfxHandler> CreateImpactPool();
            /*0x8218f34*/ UnityEngine.Pool.ObjectPool<Assets.VisualEffectData.VfxHandler> CreateInitiationPool();
            /*0x8218944*/ Cysharp.Threading.Tasks.UniTask Fire();
            /*0x82191d0*/ UnityEngine.Vector3 TryToApplyDeviation(UnityEngine.Vector3 position, float radius, Assets.VisualEffectData.ProjectileEmitter.DeviationAxisArea axis);
            /*0x8219490*/ Assets.VisualEffectData.Projectile <CreateProjectilePool>b__48_0();
            /*0x8219628*/ Assets.VisualEffectData.VfxHandler <CreateImpactPool>b__49_0();
            /*0x82197e0*/ Assets.VisualEffectData.VfxHandler <CreateInitiationPool>b__50_0();

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

                static /*0x8219998*/ <>c();
                /*0x8219a00*/ <>c();
                /*0x8219a08*/ void <CreateProjectilePool>b__48_1(Assets.VisualEffectData.Projectile instance);
                /*0x8219a98*/ void <CreateProjectilePool>b__48_2(Assets.VisualEffectData.Projectile instance);
                /*0x8219ac4*/ void <CreateProjectilePool>b__48_3(Assets.VisualEffectData.Projectile instance);
                /*0x8219b38*/ void <CreateImpactPool>b__49_1(Assets.VisualEffectData.VfxHandler instance);
                /*0x8219bc8*/ void <CreateImpactPool>b__49_2(Assets.VisualEffectData.VfxHandler instance);
                /*0x8219bf4*/ void <CreateImpactPool>b__49_3(Assets.VisualEffectData.VfxHandler instance);
                /*0x8219c68*/ void <CreateInitiationPool>b__50_1(Assets.VisualEffectData.VfxHandler instance);
                /*0x8219cf8*/ void <CreateInitiationPool>b__50_2(Assets.VisualEffectData.VfxHandler instance);
                /*0x8219d24*/ void <CreateInitiationPool>b__50_3(Assets.VisualEffectData.VfxHandler instance);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ Assets.VisualEffectData.Projectile instance;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x8219620*/ <>c__DisplayClass48_0();
                /*0x8219d98*/ void <CreateProjectilePool>b__4();
            }

            class <>c__DisplayClass49_0
            {
                /*0x10*/ Assets.VisualEffectData.VfxHandler instance;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x82197d8*/ <>c__DisplayClass49_0();
                /*0x8219e00*/ void <CreateImpactPool>b__4();
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ Assets.VisualEffectData.VfxHandler instance;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x8219990*/ <>c__DisplayClass50_0();
                /*0x8219e68*/ void <CreateInitiationPool>b__4();
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ int impactAmountHappend;
                /*0x14*/ int impactAmount;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter <>4__this;

                /*0x8219ed0*/ <>c__DisplayClass51_0();
            }

            class <>c__DisplayClass51_1
            {
                /*0x10*/ Assets.VisualEffectData.Projectile projectile;
                /*0x18*/ Assets.VisualEffectData.ProjectileEmitter.<> CS$<>8__locals1;

                /*0x8219ed8*/ <>c__DisplayClass51_1();
                /*0x8219ee0*/ float <Fire>b__0();
                /*0x8219efc*/ void <Fire>b__1(float value);
                /*0x8219f18*/ void <Fire>b__2();

                struct <<Fire>b__2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ Assets.VisualEffectData.ProjectileEmitter.<> <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                    /*0x8219fcc*/ void MoveNext();
                    /*0x821a6a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x821a6b0*/ void MoveNext();
                /*0x821baac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class TimeStopParameters
        {
            /*0x10*/ float <Value>k__BackingField;
            /*0x14*/ float <Duration>k__BackingField;

            /*0x821bad8*/ TimeStopParameters();
            /*0x821bab8*/ float get_Value();
            /*0x821bac0*/ void set_Value(float value);
            /*0x821bac8*/ float get_Duration();
            /*0x821bad0*/ void set_Duration(float value);
        }

        class VfxAnchorOverride : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.VisualEffectData.VfxAnchorOverride.AnchorTypes <Type>k__BackingField;

            /*0x821bafc*/ VfxAnchorOverride();
            /*0x821baec*/ Assets.VisualEffectData.VfxAnchorOverride.AnchorTypes get_Type();
            /*0x821baf4*/ void set_Type(Assets.VisualEffectData.VfxAnchorOverride.AnchorTypes value);

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

            /*0x821c084*/ VfxAnimationHandler();
            /*0x821bb04*/ UnityEngine.AudioClip get_AudioClip();
            /*0x821bb0c*/ void set_AudioClip(UnityEngine.AudioClip value);
            /*0x821bb14*/ UnityEngine.Events.UnityEvent get_OnEndEventReceived();
            /*0x821bb1c*/ void set_OnEndEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x821bb24*/ UnityEngine.Events.UnityEvent get_OnActionEventReceived();
            /*0x821bb2c*/ void set_OnActionEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x821bb34*/ UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> get_OnEnabled();
            /*0x821bb3c*/ void set_OnEnabled(UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> value);
            /*0x821bb44*/ void VFX_EVENT_Action();
            /*0x821bb58*/ void VFX_EVENT_End();
            /*0x821bb6c*/ void OnEnable();
            /*0x821bc04*/ void Attach(UnityEngine.Transform target, int slotIndex);
            /*0x821bfec*/ void SetAnimatorSpeed(float value);
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

            /*0x821d150*/ VfxHandler();
            /*0x821c1d8*/ UnityEngine.AudioClip get_AudioClip();
            /*0x821c1e0*/ void set_AudioClip(UnityEngine.AudioClip value);
            /*0x821c1e8*/ Assets.VisualEffectData.ProjectileEmitter get_ProjectileEmitter();
            /*0x821c1f0*/ void set_ProjectileEmitter(Assets.VisualEffectData.ProjectileEmitter value);
            /*0x821c1f8*/ Assets.VisualEffectData.CustomProjectileEmitter[] get_CustomProjectileEmitters();
            /*0x821c200*/ void set_CustomProjectileEmitters(Assets.VisualEffectData.CustomProjectileEmitter[] value);
            /*0x821c208*/ Assets.VisualEffectData.VfxHandler get_AreaVfxPrefab();
            /*0x821c210*/ void set_AreaVfxPrefab(Assets.VisualEffectData.VfxHandler value);
            /*0x821c218*/ UnityEngine.Events.UnityEvent get_OnEndEventReceived();
            /*0x821c220*/ void set_OnEndEventReceived(UnityEngine.Events.UnityEvent value);
            /*0x821c228*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.LightFlashParameters> get_OnLightFlashEventReceived();
            /*0x821c230*/ void set_OnLightFlashEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.LightFlashParameters> value);
            /*0x821c238*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.DarkFlashParameters> get_OnDarkFlashEventReceived();
            /*0x821c240*/ void set_OnDarkFlashEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.DarkFlashParameters> value);
            /*0x821c248*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.CameraNoiseParameters> get_OnCameraNoiseEventReceived();
            /*0x821c250*/ void set_OnCameraNoiseEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.CameraNoiseParameters> value);
            /*0x821c258*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.TimeStopParameters> get_OnTimeStopEventReceived();
            /*0x821c260*/ void set_OnTimeStopEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.TimeStopParameters> value);
            /*0x821c268*/ UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> get_OnActionEventReceived();
            /*0x821c270*/ void set_OnActionEventReceived(UnityEngine.Events.UnityEvent<Assets.VisualEffectData.VfxHandler> value);
            /*0x821c278*/ UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> get_OnEnabled();
            /*0x821c280*/ void set_OnEnabled(UnityEngine.Events.UnityEvent<UnityEngine.AudioClip> value);
            /*0x821c288*/ void OnEnable();
            /*0x821c320*/ void Update();
            /*0x821c474*/ void SetOrderInLayer(int orderInLayer);
            /*0x821c57c*/ void Play(int orderInLayer);
            /*0x821c674*/ void Play();
            /*0x821c5b4*/ void PlayEmitters();
            /*0x821a5e4*/ void StopEmitters();
            /*0x821c6a4*/ void VFX_EVENT_Action();
            /*0x821c700*/ void VFX_EVENT_LightFlash(string data);
            /*0x821ca98*/ void VFX_EVENT_DarkFlash(string data);
            /*0x821ccac*/ void VFX_EVENT_TimeStop(string data);
            /*0x821ce80*/ void VFX_EVENT_CameraNoise(string data);
            /*0x821c948*/ UnityEngine.Color ExtractColor(string data, UnityEngine.Color defaultValue);
            /*0x821d0c4*/ int ExtractInt(string data, int defaultValue);
            /*0x821d0fc*/ float ExtractFloat(string data, float defaultValue);
            /*0x821d13c*/ void VFX_EVENT_End();
        }

        class VfxTargetOverride : UnityEngine.MonoBehaviour
        {
            /*0x20*/ Assets.VisualEffectData.VfxTargetOverride.ValueTypes <Value>k__BackingField;
            /*0x24*/ Assets.VisualEffectData.VfxTargetOverride.OffsetTypes <Offset>k__BackingField;

            /*0x821d4cc*/ VfxTargetOverride();
            /*0x821d4ac*/ Assets.VisualEffectData.VfxTargetOverride.ValueTypes get_Value();
            /*0x821d4b4*/ void set_Value(Assets.VisualEffectData.VfxTargetOverride.ValueTypes value);
            /*0x821d4bc*/ Assets.VisualEffectData.VfxTargetOverride.OffsetTypes get_Offset();
            /*0x821d4c4*/ void set_Offset(Assets.VisualEffectData.VfxTargetOverride.OffsetTypes value);

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

                /*0x821d4f4*/ AdventureTitle();
                /*0x821d4d4*/ TMPro.TextMeshProUGUI get_Title();
                /*0x821d4dc*/ void set_Title(TMPro.TextMeshProUGUI value);
                /*0x821d4e4*/ TMPro.TextMeshProUGUI get_Body();
                /*0x821d4ec*/ void set_Body(TMPro.TextMeshProUGUI value);
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
