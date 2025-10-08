class <Module>
{
}

namespace UnityEngine
{
    class SharedBetweenAnimatorsAttribute : System.Attribute
    {
    }

    class StateMachineBehaviour : UnityEngine.ScriptableObject
    {
        /*0x3d4b998*/ StateMachineBehaviour();
        /*0x3d4b960*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x3d4b964*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x3d4b968*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x3d4b96c*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x3d4b970*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x3d4b974*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x3d4b978*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x3d4b97c*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x3d4b980*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x3d4b984*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x3d4b988*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x3d4b98c*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x3d4b990*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x3d4b994*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
    }

    enum PlayMode
    {
        StopSameLayer = 0,
        StopAll = 4,
    }

    enum QueueMode
    {
        CompleteOthers = 0,
        PlayNow = 2,
    }

    enum AnimationPlayMode
    {
        Stop = 0,
        Queue = 1,
        Mix = 2,
    }

    enum AnimationCullingType
    {
        AlwaysAnimate = 0,
        BasedOnRenderers = 1,
        BasedOnClipBounds = 2,
        BasedOnUserBounds = 3,
    }

    enum AnimationUpdateMode
    {
        Normal = 0,
        Fixed = 1,
    }

    enum AnimationEventSource
    {
        NoSource = 0,
        Legacy = 1,
        Animator = 2,
    }

    class Animation : UnityEngine.Behaviour, System.Collections.IEnumerable
    {
        static /*0x3d4ba34*/ nint get_clip_Injected(nint _unity_self);
        static /*0x3d4bb24*/ void set_clip_Injected(nint _unity_self, nint value);
        static /*0x3d4bbe0*/ bool get_playAutomatically_Injected(nint _unity_self);
        static /*0x3d4bc9c*/ void set_playAutomatically_Injected(nint _unity_self, bool value);
        static /*0x3d4bd58*/ UnityEngine.WrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x3d4be14*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.WrapMode value);
        static /*0x3d4bed0*/ void Stop_Injected(nint _unity_self);
        static /*0x3d4c0ac*/ void StopNamed_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d4c168*/ void Rewind_Injected(nint _unity_self);
        static /*0x3d4c344*/ void RewindNamed_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d4c400*/ void Sample_Injected(nint _unity_self);
        static /*0x3d4c4b4*/ bool get_isPlaying_Injected(nint _unity_self);
        static /*0x3d4c69c*/ bool IsPlaying_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d4c918*/ bool PlayDefaultAnimation_Injected(nint _unity_self, UnityEngine.PlayMode mode);
        static /*0x3d4cb20*/ bool Play_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper animation, UnityEngine.PlayMode mode);
        static /*0x3d4cd4c*/ void CrossFade_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper animation, float fadeLength, UnityEngine.PlayMode mode);
        static /*0x3d4cf84*/ void Blend_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper animation, float targetWeight, float fadeLength);
        static /*0x3d4d1d8*/ UnityEngine.AnimationState CrossFadeQueued_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper animation, float fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode);
        static /*0x3d4d418*/ UnityEngine.AnimationState PlayQueued_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode);
        static /*0x3d4d6c0*/ void AddClip_Injected(nint _unity_self, nint clip, ref UnityEngine.Bindings.ManagedSpanWrapper newName, int firstFrame, int lastFrame, bool addLoopFrame);
        static /*0x3d4d818*/ void RemoveClip_Injected(nint _unity_self, nint clip);
        static /*0x3d4d9fc*/ void RemoveClipNamed_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper clipName);
        static /*0x3d4dab8*/ int GetClipCount_Injected(nint _unity_self);
        static /*0x3d4db7c*/ void SyncLayer_Injected(nint _unity_self, int layer);
        static /*0x3d4dc68*/ UnityEngine.AnimationState GetState_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d4dd2c*/ UnityEngine.AnimationState GetStateAtIndex_Injected(nint _unity_self, int index);
        static /*0x3d4dde8*/ int GetStateCount_Injected(nint _unity_self);
        static /*0x3d4df5c*/ bool get_animatePhysics_Injected(nint _unity_self);
        static /*0x3d4e018*/ void set_animatePhysics_Injected(nint _unity_self, bool value);
        static /*0x3d4e0d4*/ UnityEngine.AnimationUpdateMode get_updateMode_Injected(nint _unity_self);
        static /*0x3d4e190*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.AnimationUpdateMode value);
        static /*0x3d4e24c*/ bool get_animateOnlyIfVisible_Injected(nint _unity_self);
        static /*0x3d4e308*/ void set_animateOnlyIfVisible_Injected(nint _unity_self, bool value);
        static /*0x3d4e3c4*/ UnityEngine.AnimationCullingType get_cullingType_Injected(nint _unity_self);
        static /*0x3d4e480*/ void set_cullingType_Injected(nint _unity_self, UnityEngine.AnimationCullingType value);
        static /*0x3d4e568*/ void get_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x3d4e62c*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        /*0x3d4e670*/ Animation();
        /*0x3d4b9a0*/ UnityEngine.AnimationClip get_clip();
        /*0x3d4ba70*/ void set_clip(UnityEngine.AnimationClip value);
        /*0x3d4bb68*/ bool get_playAutomatically();
        /*0x3d4bc1c*/ void set_playAutomatically(bool value);
        /*0x3d4bce0*/ UnityEngine.WrapMode get_wrapMode();
        /*0x3d4bd94*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x3d4be58*/ void Stop();
        /*0x3d4bf0c*/ void Stop(string name);
        /*0x3d4bf10*/ void StopNamed(string name);
        /*0x3d4c0f0*/ void Rewind();
        /*0x3d4c1a4*/ void Rewind(string name);
        /*0x3d4c1a8*/ void RewindNamed(string name);
        /*0x3d4c388*/ void Sample();
        /*0x3d4c43c*/ bool get_isPlaying();
        /*0x3d4c4f0*/ bool IsPlaying(string name);
        /*0x3d4c6e0*/ UnityEngine.AnimationState get_Item(string name);
        /*0x3d4c88c*/ bool Play();
        /*0x3d4c894*/ bool Play(UnityEngine.PlayMode mode);
        /*0x3d4c898*/ bool PlayDefaultAnimation(UnityEngine.PlayMode mode);
        /*0x3d4c95c*/ bool Play(string animation);
        /*0x3d4c964*/ bool Play(string animation, UnityEngine.PlayMode mode);
        /*0x3d4cb74*/ void CrossFade(string animation);
        /*0x3d4cb84*/ void CrossFade(string animation, float fadeLength);
        /*0x3d4cb8c*/ void CrossFade(string animation, float fadeLength, UnityEngine.PlayMode mode);
        /*0x3d4cdb0*/ void Blend(string animation);
        /*0x3d4cdc0*/ void Blend(string animation, float targetWeight);
        /*0x3d4cdcc*/ void Blend(string animation, float targetWeight, float fadeLength);
        /*0x3d4cfe0*/ UnityEngine.AnimationState CrossFadeQueued(string animation);
        /*0x3d4cff4*/ UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength);
        /*0x3d4d000*/ UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue);
        /*0x3d4d008*/ UnityEngine.AnimationState CrossFadeQueued(string animation, float fadeLength, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode);
        /*0x3d4d244*/ UnityEngine.AnimationState PlayQueued(string animation);
        /*0x3d4d250*/ UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue);
        /*0x3d4d258*/ UnityEngine.AnimationState PlayQueued(string animation, UnityEngine.QueueMode queue, UnityEngine.PlayMode mode);
        /*0x3d4d474*/ void AddClip(UnityEngine.AnimationClip clip, string newName);
        /*0x3d4d484*/ void AddClip(UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame);
        /*0x3d4d48c*/ void AddClip(UnityEngine.AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame);
        /*0x3d4d734*/ void RemoveClip(UnityEngine.AnimationClip clip);
        /*0x3d4d85c*/ void RemoveClip(string clipName);
        /*0x3d4d860*/ void RemoveClipNamed(string clipName);
        /*0x3d4da40*/ int GetClipCount();
        /*0x3d4daf4*/ bool Play(UnityEngine.AnimationPlayMode mode);
        /*0x3d4daf8*/ bool Play(string animation, UnityEngine.AnimationPlayMode mode);
        /*0x3d4dafc*/ void SyncLayer(int layer);
        /*0x3d4dbc0*/ System.Collections.IEnumerator GetEnumerator();
        /*0x3d4c6e4*/ UnityEngine.AnimationState GetState(string name);
        /*0x3d4dcac*/ UnityEngine.AnimationState GetStateAtIndex(int index);
        /*0x3d4dd70*/ int GetStateCount();
        /*0x3d4de24*/ UnityEngine.AnimationClip GetClip(string name);
        /*0x3d4dee4*/ bool get_animatePhysics();
        /*0x3d4df98*/ void set_animatePhysics(bool value);
        /*0x3d4e05c*/ UnityEngine.AnimationUpdateMode get_updateMode();
        /*0x3d4e110*/ void set_updateMode(UnityEngine.AnimationUpdateMode value);
        /*0x3d4e1d4*/ bool get_animateOnlyIfVisible();
        /*0x3d4e288*/ void set_animateOnlyIfVisible(bool value);
        /*0x3d4e34c*/ UnityEngine.AnimationCullingType get_cullingType();
        /*0x3d4e400*/ void set_cullingType(UnityEngine.AnimationCullingType value);
        /*0x3d4e4c4*/ UnityEngine.Bounds get_localBounds();
        /*0x3d4e5ac*/ void set_localBounds(UnityEngine.Bounds value);

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Animation m_Outer;
            /*0x18*/ int m_CurrentIndex;

            /*0x3d4dc30*/ Enumerator(UnityEngine.Animation outer);
            /*0x3d4e678*/ object get_Current();
            /*0x3d4e694*/ bool MoveNext();
            /*0x3d4e6c8*/ void Reset();
        }
    }

    class AnimationState : UnityEngine.TrackedReference
    {
        static /*0x3d4e72c*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x3d4e7d0*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x3d4e87c*/ void set_normalizedTime_Injected(nint _unity_self, float value);
        static /*0x3d4e928*/ void set_speed_Injected(nint _unity_self, float value);
        static /*0x3d4e9c4*/ float get_length_Injected(nint _unity_self);
        static /*0x3d4ea00*/ nint get_clip_Injected(nint _unity_self);
        /*0x3d4ea3c*/ AnimationState();
        /*0x3d4e6d4*/ void set_enabled(bool value);
        /*0x3d4e770*/ void set_time(float value);
        /*0x3d4e81c*/ void set_normalizedTime(float value);
        /*0x3d4e8c8*/ void set_speed(float value);
        /*0x3d4e974*/ float get_length();
        /*0x3d4de5c*/ UnityEngine.AnimationClip get_clip();

        class BindingsMarshaller
        {
            static /*0x3d4ea44*/ nint ConvertToNative(UnityEngine.AnimationState animationState);
        }
    }

    struct AnimationEventBlittable : System.IDisposable
    {
        [ThreadStatic] static UnityEngine.GCHandlePool s_handlePool;
        /*0x10*/ float m_Time;
        /*0x18*/ nint m_FunctionName;
        /*0x20*/ nint m_StringParameter;
        /*0x28*/ nint m_ObjectReferenceParameter;
        /*0x30*/ float m_FloatParameter;
        /*0x34*/ int m_IntParameter;
        /*0x38*/ int m_MessageOptions;
        /*0x3c*/ UnityEngine.AnimationEventSource m_Source;
        /*0x40*/ nint m_StateSender;
        /*0x48*/ UnityEngine.AnimatorStateInfo m_AnimatorStateInfo;
        /*0x6c*/ UnityEngine.AnimatorClipInfo m_AnimatorClipInfo;

        static /*0x3d4ea58*/ UnityEngine.AnimationEventBlittable FromAnimationEvent(UnityEngine.AnimationEvent animationEvent);
        static /*0x3d4ec48*/ void FromAnimationEvents(UnityEngine.AnimationEvent[] animationEvents, UnityEngine.AnimationEventBlittable* animationEventBlittables);
        static /*0x3d4edec*/ UnityEngine.AnimationEvent PointerToAnimationEvent(nint animationEventBlittable);
        static /*0x3d4f0c0*/ UnityEngine.AnimationEvent[] PointerToAnimationEvents(nint animationEventBlittableArray, int size);
        static /*0x3d4f1c0*/ void DisposeEvents(nint animationEventBlittableArray, int size);
        static /*0x3d4f330*/ void FreeEventsInternal(nint value);
        static /*0x3d4ee20*/ UnityEngine.AnimationEvent ToAnimationEvent(UnityEngine.AnimationEventBlittable animationEventBlittable);
        /*0x3d4f22c*/ void Dispose();
    }

    class AnimationEvent
    {
        /*0x10*/ float m_Time;
        /*0x18*/ string m_FunctionName;
        /*0x20*/ string m_StringParameter;
        /*0x28*/ UnityEngine.Object m_ObjectReferenceParameter;
        /*0x30*/ float m_FloatParameter;
        /*0x34*/ int m_IntParameter;
        /*0x38*/ int m_MessageOptions;
        /*0x3c*/ UnityEngine.AnimationEventSource m_Source;
        /*0x40*/ UnityEngine.AnimationState m_StateSender;
        /*0x48*/ UnityEngine.AnimatorStateInfo m_AnimatorStateInfo;
        /*0x6c*/ UnityEngine.AnimatorClipInfo m_AnimatorClipInfo;

        /*0x3d4f36c*/ AnimationEvent();
        /*0x3d4f508*/ string get_stringParameter();
        /*0x3d4f510*/ int get_intParameter();
        /*0x3d4f518*/ void set_intParameter(int value);
        /*0x3d4f520*/ string get_functionName();
        /*0x3d4f528*/ void set_functionName(string value);
        /*0x3d4f530*/ float get_time();
        /*0x3d4f538*/ void set_time(float value);
        /*0x3d4f540*/ void set_messageOptions(UnityEngine.SendMessageOptions value);
    }

    class AnimationClip : UnityEngine.Motion
    {
        static /*0x3d4f5e0*/ void Internal_CreateAnimationClip(UnityEngine.AnimationClip self);
        static /*0x3d4f6d0*/ void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode);
        static /*0x3d4f80c*/ void SampleAnimation_Injected(nint go, nint clip, float inTime, UnityEngine.WrapMode wrapMode);
        static /*0x3d4f8e8*/ float get_length_Injected(nint _unity_self);
        static /*0x3d4f99c*/ float get_startTime_Injected(nint _unity_self);
        static /*0x3d4fa50*/ float get_stopTime_Injected(nint _unity_self);
        static /*0x3d4fb04*/ float get_frameRate_Injected(nint _unity_self);
        static /*0x3d4fbc8*/ void set_frameRate_Injected(nint _unity_self, float value);
        static /*0x3d4ff28*/ void SetCurve_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper relativePath, System.Type type, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName, nint curve);
        static /*0x3d5000c*/ void EnsureQuaternionContinuity_Injected(nint _unity_self);
        static /*0x3d500c0*/ void ClearCurves_Injected(nint _unity_self);
        static /*0x3d500fc*/ UnityEngine.WrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x3d501b8*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.WrapMode value);
        static /*0x3d502a0*/ void get_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x3d50364*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x3d50420*/ bool get_legacy_Injected(nint _unity_self);
        static /*0x3d504dc*/ void set_legacy_Injected(nint _unity_self, bool value);
        static /*0x3d50598*/ bool get_humanMotion_Injected(nint _unity_self);
        static /*0x3d5064c*/ bool get_empty_Injected(nint _unity_self);
        static /*0x3d50700*/ bool get_hasGenericRootTransform_Injected(nint _unity_self);
        static /*0x3d507b4*/ bool get_hasMotionFloatCurves_Injected(nint _unity_self);
        static /*0x3d50868*/ bool get_hasMotionCurves_Injected(nint _unity_self);
        static /*0x3d5091c*/ bool get_hasRootCurves_Injected(nint _unity_self);
        static /*0x3d509d0*/ bool get_hasRootMotion_Injected(nint _unity_self);
        static /*0x3d50b80*/ void AddEventInternal_Injected(nint _unity_self, object evt);
        static /*0x3d50e98*/ void SetEventsInternal_Injected(nint _unity_self, void* data, int length);
        static /*0x3d50eec*/ void GetEventsInternal_Injected(nint _unity_self, ref nint values, ref int size);
        /*0x3d4f548*/ AnimationClip();
        /*0x3d4f61c*/ void SampleAnimation(UnityEngine.GameObject go, float time);
        /*0x3d4f870*/ float get_length();
        /*0x3d4f924*/ float get_startTime();
        /*0x3d4f9d8*/ float get_stopTime();
        /*0x3d4fa8c*/ float get_frameRate();
        /*0x3d4fb40*/ void set_frameRate(float value);
        /*0x3d4fc14*/ void SetCurve(string relativePath, System.Type type, string propertyName, UnityEngine.AnimationCurve curve);
        /*0x3d4ff94*/ void EnsureQuaternionContinuity();
        /*0x3d50048*/ void ClearCurves();
        /*0x3d4f658*/ UnityEngine.WrapMode get_wrapMode();
        /*0x3d50138*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x3d501fc*/ UnityEngine.Bounds get_localBounds();
        /*0x3d502e4*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x3d503a8*/ bool get_legacy();
        /*0x3d5045c*/ void set_legacy(bool value);
        /*0x3d50520*/ bool get_humanMotion();
        /*0x3d505d4*/ bool get_empty();
        /*0x3d50688*/ bool get_hasGenericRootTransform();
        /*0x3d5073c*/ bool get_hasMotionFloatCurves();
        /*0x3d507f0*/ bool get_hasMotionCurves();
        /*0x3d508a4*/ bool get_hasRootCurves();
        /*0x3d50958*/ bool get_hasRootMotion();
        /*0x3d50a0c*/ void AddEvent(UnityEngine.AnimationEvent evt);
        /*0x3d50b00*/ void AddEventInternal(object evt);
        /*0x3d50bc4*/ UnityEngine.AnimationEvent[] get_events();
        /*0x3d50ca0*/ void set_events(UnityEngine.AnimationEvent[] value);
        /*0x3d50e08*/ void SetEventsInternal(void* data, int length);
        /*0x3d50c10*/ void GetEventsInternal(ref nint values, ref int size);
    }

    class GCHandlePool
    {
        /*0x10*/ System.Runtime.InteropServices.GCHandle[] m_handles;
        /*0x18*/ int m_current;

        /*0x3d4ebe4*/ GCHandlePool();
        /*0x3d50f40*/ System.Runtime.InteropServices.GCHandle Alloc(object o);
        /*0x3d50fdc*/ nint AllocHandleIfNotNull(object o);
        /*0x3d4f3fc*/ void Free(System.Runtime.InteropServices.GCHandle h);
    }

    enum AvatarTarget
    {
        Root = 0,
        Body = 1,
        LeftFoot = 2,
        RightFoot = 3,
        LeftHand = 4,
        RightHand = 5,
    }

    enum AvatarIKGoal
    {
        LeftFoot = 0,
        RightFoot = 1,
        LeftHand = 2,
        RightHand = 3,
    }

    enum AvatarIKHint
    {
        LeftKnee = 0,
        RightKnee = 1,
        LeftElbow = 2,
        RightElbow = 3,
    }

    enum AnimatorControllerParameterType
    {
        Float = 1,
        Int = 3,
        Bool = 4,
        Trigger = 9,
    }

    enum StateInfoIndex
    {
        CurrentState = 0,
        NextState = 1,
        ExitState = 2,
        InterruptedState = 3,
    }

    enum AnimatorRecorderMode
    {
        Offline = 0,
        Playback = 1,
        Record = 2,
    }

    enum AnimatorCullingMode
    {
        AlwaysAnimate = 0,
        CullUpdateTransforms = 1,
        CullCompletely = 2,
    }

    enum AnimatorUpdateMode
    {
        Normal = 0,
        Fixed = 1,
        UnscaledTime = 2,
    }

    struct AnimatorClipInfo
    {
        /*0x10*/ int m_ClipInstanceID;
        /*0x14*/ float m_Weight;
    }

    struct AnimatorStateInfo
    {
        /*0x10*/ int m_Name;
        /*0x14*/ int m_Path;
        /*0x18*/ int m_FullPath;
        /*0x1c*/ float m_NormalizedTime;
        /*0x20*/ float m_Length;
        /*0x24*/ float m_Speed;
        /*0x28*/ float m_SpeedMultiplier;
        /*0x2c*/ int m_Tag;
        /*0x30*/ int m_Loop;

        /*0x3d50fec*/ int get_shortNameHash();
        /*0x3d50ff4*/ float get_normalizedTime();
    }

    struct AnimatorTransitionInfo
    {
        /*0x10*/ int m_FullPath;
        /*0x14*/ int m_UserName;
        /*0x18*/ int m_Name;
        /*0x1c*/ bool m_HasFixedDuration;
        /*0x20*/ float m_Duration;
        /*0x24*/ float m_NormalizedTime;
        /*0x28*/ bool m_AnyState;
        /*0x2c*/ int m_TransitionType;
    }

    struct MatchTargetWeightMask
    {
        /*0x10*/ UnityEngine.Vector3 m_PositionXYZWeight;
        /*0x1c*/ float m_RotationWeight;
    }

    class Animator : UnityEngine.Behaviour
    {
        static /*0x1f327cc*/ T[] ConvertStateMachineBehaviour<T>(UnityEngine.ScriptableObject[] rawObjects);
        static /*0x3d56f6c*/ int StringToHash(string name);
        static /*0x3d51074*/ bool get_isOptimizable_Injected(nint _unity_self);
        static /*0x3d51128*/ bool get_isHuman_Injected(nint _unity_self);
        static /*0x3d511dc*/ bool get_hasRootMotion_Injected(nint _unity_self);
        static /*0x3d51290*/ bool get_isRootPositionOrRotationControlledByCurves_Injected(nint _unity_self);
        static /*0x3d51344*/ float get_humanScale_Injected(nint _unity_self);
        static /*0x3d513f8*/ bool get_isInitialized_Injected(nint _unity_self);
        static /*0x3d52b28*/ void get_deltaPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d52c00*/ void get_deltaRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3d52cdc*/ void get_velocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d52db8*/ void get_angularVelocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d52e94*/ void get_rootPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d52f68*/ void set_rootPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3d53040*/ void get_rootRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3d53114*/ void set_rootRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x3d531d0*/ bool get_applyRootMotion_Injected(nint _unity_self);
        static /*0x3d5328c*/ void set_applyRootMotion_Injected(nint _unity_self, bool value);
        static /*0x3d53348*/ bool get_linearVelocityBlending_Injected(nint _unity_self);
        static /*0x3d53404*/ void set_linearVelocityBlending_Injected(nint _unity_self, bool value);
        static /*0x3d534c0*/ bool get_animatePhysics_Injected(nint _unity_self);
        static /*0x3d5357c*/ void set_animatePhysics_Injected(nint _unity_self, bool value);
        static /*0x3d53638*/ UnityEngine.AnimatorUpdateMode get_updateMode_Injected(nint _unity_self);
        static /*0x3d536f4*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.AnimatorUpdateMode value);
        static /*0x3d537b0*/ bool get_hasTransformHierarchy_Injected(nint _unity_self);
        static /*0x3d53864*/ bool get_allowConstantClipSamplingOptimization_Injected(nint _unity_self);
        static /*0x3d53920*/ void set_allowConstantClipSamplingOptimization_Injected(nint _unity_self, bool value);
        static /*0x3d539dc*/ float get_gravityWeight_Injected(nint _unity_self);
        static /*0x3d53c28*/ void get_bodyPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d53c6c*/ void set_bodyPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3d53e34*/ void get_bodyRotationInternal_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3d53e78*/ void set_bodyRotationInternal_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x3d53f84*/ void GetGoalPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 ret);
        static /*0x3d540c0*/ void SetGoalPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 goalPosition);
        static /*0x3d541d8*/ void GetGoalRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion ret);
        static /*0x3d5431c*/ void SetGoalRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion goalRotation);
        static /*0x3d54418*/ float GetGoalWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal);
        static /*0x3d54524*/ void SetGoalWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, float value);
        static /*0x3d54620*/ float GetGoalWeightRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal);
        static /*0x3d5472c*/ void SetGoalWeightRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, float value);
        static /*0x3d54848*/ void GetHintPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 ret);
        static /*0x3d54984*/ void SetHintPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 hintPosition);
        static /*0x3d54a80*/ float GetHintWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint);
        static /*0x3d54b8c*/ void SetHintWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, float value);
        static /*0x3d54cb0*/ void SetLookAtPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 lookAtPosition);
        static /*0x3d54f0c*/ void SetLookAtWeightInternal_Injected(nint _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        static /*0x3d550dc*/ void SetBoneLocalRotationInternal_Injected(nint _unity_self, int humanBoneId, ref UnityEngine.Quaternion rotation);
        static /*0x3d55204*/ nint GetBehaviour_Injected(nint _unity_self, System.Type type);
        static /*0x3d552f8*/ UnityEngine.ScriptableObject[] InternalGetBehaviours_Injected(nint _unity_self, System.Type type);
        static /*0x3d554a8*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey_Injected(nint _unity_self, int fullPathHash, int layerIndex, System.Type type);
        static /*0x3d5557c*/ bool get_stabilizeFeet_Injected(nint _unity_self);
        static /*0x3d55638*/ void set_stabilizeFeet_Injected(nint _unity_self, bool value);
        static /*0x3d556f4*/ int get_layerCount_Injected(nint _unity_self);
        static /*0x3d55868*/ void GetLayerName_Injected(nint _unity_self, int layerIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d55a64*/ int GetLayerIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
        static /*0x3d55b28*/ float GetLayerWeight_Injected(nint _unity_self, int layerIndex);
        static /*0x3d55bfc*/ void SetLayerWeight_Injected(nint _unity_self, int layerIndex, float weight);
        static /*0x3d55ce8*/ void GetAnimatorStateInfo_Injected(nint _unity_self, int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        static /*0x3d55e54*/ void GetAnimatorTransitionInfo_Injected(nint _unity_self, int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        static /*0x3d55f68*/ int GetAnimatorClipInfoCount_Injected(nint _unity_self, int layerIndex, bool current);
        static /*0x3d5604c*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo_Injected(nint _unity_self, int layerIndex);
        static /*0x3d56110*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo_Injected(nint _unity_self, int layerIndex);
        static /*0x3d56248*/ void GetAnimatorClipInfoInternal_Injected(nint _unity_self, int layerIndex, bool isCurrent, object clips);
        static /*0x3d56380*/ bool IsInTransition_Injected(nint _unity_self, int layerIndex);
        static /*0x3d5643c*/ UnityEngine.AnimatorControllerParameter[] get_parameters_Injected(nint _unity_self);
        static /*0x3d564f0*/ int get_parameterCount_Injected(nint _unity_self);
        static /*0x3d565ac*/ UnityEngine.AnimatorControllerParameter GetParameterInternal_Injected(nint _unity_self, int index);
        static /*0x3d56708*/ float get_feetPivotActive_Injected(nint _unity_self);
        static /*0x3d567cc*/ void set_feetPivotActive_Injected(nint _unity_self, float value);
        static /*0x3d56890*/ float get_pivotWeight_Injected(nint _unity_self);
        static /*0x3d56964*/ void get_pivotPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d56a80*/ void MatchTarget_Injected(nint _unity_self, ref UnityEngine.Vector3 matchPosition, ref UnityEngine.Quaternion matchRotation, int targetBodyPart, ref UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        static /*0x3d56c04*/ void InterruptMatchTarget_Injected(nint _unity_self, bool completeMatch);
        static /*0x3d56cc0*/ bool get_isMatchingTarget_Injected(nint _unity_self);
        static /*0x3d56d74*/ float get_speed_Injected(nint _unity_self);
        static /*0x3d56e38*/ void set_speed_Injected(nint _unity_self, float value);
        static /*0x3d572a4*/ void CrossFadeInFixedTime_Injected(nint _unity_self, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        static /*0x3d57398*/ void WriteDefaultValues_Injected(nint _unity_self);
        static /*0x3d575bc*/ void CrossFade_Injected(nint _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        static /*0x3d577a8*/ void PlayInFixedTime_Injected(nint _unity_self, int stateNameHash, int layer, float fixedTime);
        static /*0x3d578cc*/ void Play_Injected(nint _unity_self, int stateNameHash, int layer, float normalizedTime);
        static /*0x3d579dc*/ void SetTarget_Injected(nint _unity_self, UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        static /*0x3d57ac8*/ void get_targetPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d57ba0*/ void get_targetRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3d57ca0*/ bool IsBoneTransform_Injected(nint _unity_self, nint transform);
        static /*0x3d57d78*/ nint get_avatarRoot_Injected(nint _unity_self);
        static /*0x3d581d0*/ nint GetBoneTransformInternal_Injected(nint _unity_self, int humanBoneId);
        static /*0x3d5828c*/ UnityEngine.AnimatorCullingMode get_cullingMode_Injected(nint _unity_self);
        static /*0x3d58348*/ void set_cullingMode_Injected(nint _unity_self, UnityEngine.AnimatorCullingMode value);
        static /*0x3d58404*/ void StartPlayback_Injected(nint _unity_self);
        static /*0x3d584b8*/ void StopPlayback_Injected(nint _unity_self);
        static /*0x3d5856c*/ float get_playbackTime_Injected(nint _unity_self);
        static /*0x3d58630*/ void set_playbackTime_Injected(nint _unity_self, float value);
        static /*0x3d586fc*/ void StartRecording_Injected(nint _unity_self, int frameCount);
        static /*0x3d587b8*/ void StopRecording_Injected(nint _unity_self);
        static /*0x3d58874*/ float GetRecorderStartTime_Injected(nint _unity_self);
        static /*0x3d58930*/ float GetRecorderStopTime_Injected(nint _unity_self);
        static /*0x3d589e4*/ UnityEngine.AnimatorRecorderMode get_recorderMode_Injected(nint _unity_self);
        static /*0x3d58ab4*/ nint get_runtimeAnimatorController_Injected(nint _unity_self);
        static /*0x3d58ba4*/ void set_runtimeAnimatorController_Injected(nint _unity_self, nint value);
        static /*0x3d58c60*/ bool get_hasBoundPlayables_Injected(nint _unity_self);
        static /*0x3d58d14*/ void ClearInternalControllerPlayable_Injected(nint _unity_self);
        static /*0x3d58de0*/ bool HasState_Injected(nint _unity_self, int layerIndex, int stateID);
        static /*0x3d58e34*/ int StringToHash_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d58e70*/ nint get_avatar_Injected(nint _unity_self);
        static /*0x3d58f60*/ void set_avatar_Injected(nint _unity_self, nint value);
        static /*0x3d590d0*/ void GetStats_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d591b8*/ void GetCurrentGraph_Injected(nint _unity_self, ref UnityEngine.Playables.PlayableGraph graph);
        static /*0x3d592ec*/ bool IsInIKPass_Injected(nint _unity_self);
        static /*0x3d59328*/ void SetFloatString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value);
        static /*0x3d5937c*/ void SetFloatID_Injected(nint _unity_self, int id, float value);
        static /*0x3d593d0*/ float GetFloatString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d59414*/ float GetFloatID_Injected(nint _unity_self, int id);
        static /*0x3d59458*/ void SetBoolString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, bool value);
        static /*0x3d594ac*/ void SetBoolID_Injected(nint _unity_self, int id, bool value);
        static /*0x3d59500*/ bool GetBoolString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d59544*/ bool GetBoolID_Injected(nint _unity_self, int id);
        static /*0x3d59588*/ void SetIntegerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, int value);
        static /*0x3d595dc*/ void SetIntegerID_Injected(nint _unity_self, int id, int value);
        static /*0x3d59630*/ int GetIntegerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d59674*/ int GetIntegerID_Injected(nint _unity_self, int id);
        static /*0x3d596b8*/ void SetTriggerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d596fc*/ void SetTriggerID_Injected(nint _unity_self, int id);
        static /*0x3d59740*/ void ResetTriggerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d59784*/ void ResetTriggerID_Injected(nint _unity_self, int id);
        static /*0x3d597c8*/ bool IsParameterControlledByCurveString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d5980c*/ bool IsParameterControlledByCurveID_Injected(nint _unity_self, int id);
        static /*0x3d59850*/ void SetFloatStringDamp_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value, float dampTime, float deltaTime);
        static /*0x3d598bc*/ void SetFloatIDDamp_Injected(nint _unity_self, int id, float value, float dampTime, float deltaTime);
        static /*0x3d599a0*/ bool get_layersAffectMassCenter_Injected(nint _unity_self);
        static /*0x3d59a5c*/ void set_layersAffectMassCenter_Injected(nint _unity_self, bool value);
        static /*0x3d59b18*/ float get_leftFeetBottomHeight_Injected(nint _unity_self);
        static /*0x3d59bcc*/ float get_rightFeetBottomHeight_Injected(nint _unity_self);
        static /*0x3d59c80*/ bool get_supportsOnAnimatorMove_Injected(nint _unity_self);
        static /*0x3d59d34*/ void OnUpdateModeChanged_Injected(nint _unity_self);
        static /*0x3d59de8*/ void OnCullingModeChanged_Injected(nint _unity_self);
        static /*0x3d59e9c*/ void WriteDefaultPose_Injected(nint _unity_self);
        static /*0x3d59f60*/ void Update_Injected(nint _unity_self, float deltaTime);
        static /*0x3d5a034*/ void Rebind_Injected(nint _unity_self, bool writeDefaultValues);
        static /*0x3d5a0f0*/ void ApplyBuiltinRootMotion_Injected(nint _unity_self);
        static /*0x3d5a1bc*/ void EvaluateController_Injected(nint _unity_self, float deltaTime);
        static /*0x3d5a358*/ void GetAnimatorStateName_Injected(nint _unity_self, int layerIndex, bool current, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d5a4ec*/ void ResolveHash_Injected(nint _unity_self, int hash, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d5a540*/ bool get_logWarnings_Injected(nint _unity_self);
        static /*0x3d5a5fc*/ void set_logWarnings_Injected(nint _unity_self, bool value);
        static /*0x3d5a6b8*/ bool get_fireEvents_Injected(nint _unity_self);
        static /*0x3d5a774*/ void set_fireEvents_Injected(nint _unity_self, bool value);
        static /*0x3d5a8b8*/ bool get_keepAnimatorStateOnDisable_Injected(nint _unity_self);
        static /*0x3d5a8f4*/ void set_keepAnimatorStateOnDisable_Injected(nint _unity_self, bool value);
        static /*0x3d5a9b0*/ bool get_writeDefaultValuesOnDisable_Injected(nint _unity_self);
        static /*0x3d5aa6c*/ void set_writeDefaultValuesOnDisable_Injected(nint _unity_self, bool value);
        /*0x3d5abd0*/ Animator();
        /*0x3d50ffc*/ bool get_isOptimizable();
        /*0x3d510b0*/ bool get_isHuman();
        /*0x3d51164*/ bool get_hasRootMotion();
        /*0x3d51218*/ bool get_isRootPositionOrRotationControlledByCurves();
        /*0x3d512cc*/ float get_humanScale();
        /*0x3d51380*/ bool get_isInitialized();
        /*0x3d51434*/ float GetFloat(string name);
        /*0x3d515dc*/ float GetFloat(int id);
        /*0x3d51660*/ void SetFloat(string name, float value);
        /*0x3d51814*/ void SetFloat(string name, float value, float dampTime, float deltaTime);
        /*0x3d519e0*/ void SetFloat(int id, float value);
        /*0x3d51a74*/ void SetFloat(int id, float value, float dampTime, float deltaTime);
        /*0x3d51b20*/ bool GetBool(string name);
        /*0x3d51cd0*/ bool GetBool(int id);
        /*0x3d51d54*/ void SetBool(string name, bool value);
        /*0x3d51f08*/ void SetBool(int id, bool value);
        /*0x3d51f9c*/ int GetInteger(string name);
        /*0x3d52148*/ int GetInteger(int id);
        /*0x3d521cc*/ void SetInteger(string name, int value);
        /*0x3d52380*/ void SetInteger(int id, int value);
        /*0x3d52414*/ void SetTrigger(string name);
        /*0x3d525b4*/ void SetTrigger(int id);
        /*0x3d52638*/ void ResetTrigger(string name);
        /*0x3d527d8*/ void ResetTrigger(int id);
        /*0x3d5285c*/ bool IsParameterControlledByCurve(string name);
        /*0x3d52a0c*/ bool IsParameterControlledByCurve(int id);
        /*0x3d52a90*/ UnityEngine.Vector3 get_deltaPosition();
        /*0x3d52b6c*/ UnityEngine.Quaternion get_deltaRotation();
        /*0x3d52c44*/ UnityEngine.Vector3 get_velocity();
        /*0x3d52d20*/ UnityEngine.Vector3 get_angularVelocity();
        /*0x3d52dfc*/ UnityEngine.Vector3 get_rootPosition();
        /*0x3d52ed8*/ void set_rootPosition(UnityEngine.Vector3 value);
        /*0x3d52fac*/ UnityEngine.Quaternion get_rootRotation();
        /*0x3d53084*/ void set_rootRotation(UnityEngine.Quaternion value);
        /*0x3d53158*/ bool get_applyRootMotion();
        /*0x3d5320c*/ void set_applyRootMotion(bool value);
        /*0x3d532d0*/ bool get_linearVelocityBlending();
        /*0x3d53384*/ void set_linearVelocityBlending(bool value);
        /*0x3d53448*/ bool get_animatePhysics();
        /*0x3d534fc*/ void set_animatePhysics(bool value);
        /*0x3d535c0*/ UnityEngine.AnimatorUpdateMode get_updateMode();
        /*0x3d53674*/ void set_updateMode(UnityEngine.AnimatorUpdateMode value);
        /*0x3d53738*/ bool get_hasTransformHierarchy();
        /*0x3d537ec*/ bool get_allowConstantClipSamplingOptimization();
        /*0x3d538a0*/ void set_allowConstantClipSamplingOptimization(bool value);
        /*0x3d53964*/ float get_gravityWeight();
        /*0x3d53a18*/ UnityEngine.Vector3 get_bodyPosition();
        /*0x3d53b58*/ void set_bodyPosition(UnityEngine.Vector3 value);
        /*0x3d53ac0*/ UnityEngine.Vector3 get_bodyPositionInternal();
        /*0x3d53b98*/ void set_bodyPositionInternal(UnityEngine.Vector3 value);
        /*0x3d53cb0*/ UnityEngine.Quaternion get_bodyRotation();
        /*0x3d53d5c*/ void set_bodyRotation(UnityEngine.Quaternion value);
        /*0x3d53cc8*/ UnityEngine.Quaternion get_bodyRotationInternal();
        /*0x3d53da4*/ void set_bodyRotationInternal(UnityEngine.Quaternion value);
        /*0x3d53ebc*/ UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal);
        /*0x3d53ee4*/ UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal);
        /*0x3d53fd8*/ void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x3d54028*/ void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x3d54114*/ UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal);
        /*0x3d5413c*/ UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal);
        /*0x3d5422c*/ void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x3d54284*/ void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x3d54370*/ float GetIKPositionWeight(UnityEngine.AvatarIKGoal goal);
        /*0x3d54398*/ float GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal);
        /*0x3d5445c*/ void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x3d54494*/ void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, float value);
        /*0x3d54578*/ float GetIKRotationWeight(UnityEngine.AvatarIKGoal goal);
        /*0x3d545a0*/ float GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal);
        /*0x3d54664*/ void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x3d5469c*/ void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, float value);
        /*0x3d54780*/ UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x3d547a8*/ UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x3d5489c*/ void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x3d548ec*/ void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x3d549d8*/ float GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint);
        /*0x3d54a00*/ float GetHintWeightPosition(UnityEngine.AvatarIKHint hint);
        /*0x3d54ac4*/ void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, float value);
        /*0x3d54afc*/ void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, float value);
        /*0x3d54be0*/ void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition);
        /*0x3d54c20*/ void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition);
        /*0x3d54cf4*/ void SetLookAtWeight(float weight);
        /*0x3d54de4*/ void SetLookAtWeight(float weight, float bodyWeight);
        /*0x3d54e20*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
        /*0x3d54e68*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
        /*0x3d54eb4*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x3d54d2c*/ void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x3d54f88*/ void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation);
        /*0x3d55044*/ void SetBoneLocalRotationInternal(int humanBoneId, UnityEngine.Quaternion rotation);
        /*0x3d55130*/ UnityEngine.ScriptableObject GetBehaviour(System.Type type);
        /*0x1ffc854*/ T GetBehaviour<T>();
        /*0x1f30214*/ T[] GetBehaviours<T>();
        /*0x3d55248*/ UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type);
        /*0x3d5533c*/ UnityEngine.StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex);
        /*0x3d553e0*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, System.Type type);
        /*0x3d55504*/ bool get_stabilizeFeet();
        /*0x3d555b8*/ void set_stabilizeFeet(bool value);
        /*0x3d5567c*/ int get_layerCount();
        /*0x3d55730*/ string GetLayerName(int layerIndex);
        /*0x3d558bc*/ int GetLayerIndex(string layerName);
        /*0x3d55aa8*/ float GetLayerWeight(int layerIndex);
        /*0x3d55b6c*/ void SetLayerWeight(int layerIndex, float weight);
        /*0x3d55c50*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x3d55d44*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x3d55d84*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        /*0x3d55dc4*/ void GetAnimatorTransitionInfo(int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        /*0x3d55ea8*/ UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
        /*0x3d55ed8*/ int GetAnimatorClipInfoCount(int layerIndex, bool current);
        /*0x3d55fbc*/ int GetCurrentAnimatorClipInfoCount(int layerIndex);
        /*0x3d55fc4*/ int GetNextAnimatorClipInfoCount(int layerIndex);
        /*0x3d55fcc*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        /*0x3d56090*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
        /*0x3d56154*/ void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x3d561b0*/ void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);
        /*0x3d562a4*/ void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x3d56300*/ bool IsInTransition(int layerIndex);
        /*0x3d563c4*/ UnityEngine.AnimatorControllerParameter[] get_parameters();
        /*0x3d56478*/ int get_parameterCount();
        /*0x3d5652c*/ UnityEngine.AnimatorControllerParameter GetParameterInternal(int index);
        /*0x3d565f0*/ UnityEngine.AnimatorControllerParameter GetParameter(int index);
        /*0x3d56690*/ float get_feetPivotActive();
        /*0x3d56744*/ void set_feetPivotActive(float value);
        /*0x3d56818*/ float get_pivotWeight();
        /*0x3d568cc*/ UnityEngine.Vector3 get_pivotPosition();
        /*0x3d569a8*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, int targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x3d56b0c*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime);
        /*0x3d56b40*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);
        /*0x3d56b60*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x3d56b7c*/ void InterruptMatchTarget();
        /*0x3d56b84*/ void InterruptMatchTarget(bool completeMatch);
        /*0x3d56c48*/ bool get_isMatchingTarget();
        /*0x3d56cfc*/ float get_speed();
        /*0x3d56db0*/ void set_speed(float value);
        /*0x3d56e84*/ void ForceStateNormalizedTime(float normalizedTime);
        /*0x3d56f30*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration);
        /*0x3d57194*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer);
        /*0x3d571dc*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x3d57228*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x3d57280*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x3d57288*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer);
        /*0x3d57294*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration);
        /*0x3d570dc*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x3d57320*/ void WriteDefaultValues();
        /*0x3d573d4*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x3d57478*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer);
        /*0x3d574c4*/ void CrossFade(string stateName, float normalizedTransitionDuration);
        /*0x3d57420*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x3d57504*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x3d57638*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x3d57640*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer);
        /*0x3d57650*/ void CrossFade(int stateHashName, float normalizedTransitionDuration);
        /*0x3d57664*/ void PlayInFixedTime(string stateName, int layer);
        /*0x3d576dc*/ void PlayInFixedTime(string stateName);
        /*0x3d5769c*/ void PlayInFixedTime(string stateName, int layer, float fixedTime);
        /*0x3d57708*/ void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
        /*0x3d5780c*/ void PlayInFixedTime(int stateNameHash, int layer);
        /*0x3d57818*/ void PlayInFixedTime(int stateNameHash);
        /*0x3d57828*/ void Play(string stateName, int layer);
        /*0x3d578a0*/ void Play(string stateName);
        /*0x3d57860*/ void Play(string stateName, int layer, float normalizedTime);
        /*0x3d56e90*/ void Play(int stateNameHash, int layer, float normalizedTime);
        /*0x3d57930*/ void Play(int stateNameHash, int layer);
        /*0x3d5793c*/ void Play(int stateNameHash);
        /*0x3d5794c*/ void SetTarget(UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        /*0x3d57a30*/ UnityEngine.Vector3 get_targetPosition();
        /*0x3d57b0c*/ UnityEngine.Quaternion get_targetRotation();
        /*0x3d57be4*/ bool IsControlled(UnityEngine.Transform transform);
        /*0x3d57bec*/ bool IsBoneTransform(UnityEngine.Transform transform);
        /*0x3d57ce4*/ UnityEngine.Transform get_avatarRoot();
        /*0x3d57db4*/ UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId);
        /*0x3d5812c*/ UnityEngine.Transform GetBoneTransformInternal(int humanBoneId);
        /*0x3d58214*/ UnityEngine.AnimatorCullingMode get_cullingMode();
        /*0x3d582c8*/ void set_cullingMode(UnityEngine.AnimatorCullingMode value);
        /*0x3d5838c*/ void StartPlayback();
        /*0x3d58440*/ void StopPlayback();
        /*0x3d584f4*/ float get_playbackTime();
        /*0x3d585a8*/ void set_playbackTime(float value);
        /*0x3d5867c*/ void StartRecording(int frameCount);
        /*0x3d58740*/ void StopRecording();
        /*0x3d587f4*/ float get_recorderStartTime();
        /*0x3d58870*/ void set_recorderStartTime(float value);
        /*0x3d587f8*/ float GetRecorderStartTime();
        /*0x3d588b0*/ float get_recorderStopTime();
        /*0x3d5892c*/ void set_recorderStopTime(float value);
        /*0x3d588b4*/ float GetRecorderStopTime();
        /*0x3d5896c*/ UnityEngine.AnimatorRecorderMode get_recorderMode();
        /*0x3d58a20*/ UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController();
        /*0x3d58af0*/ void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value);
        /*0x3d58be8*/ bool get_hasBoundPlayables();
        /*0x3d58c9c*/ void ClearInternalControllerPlayable();
        /*0x3d58d50*/ bool HasState(int layerIndex, int stateID);
        /*0x3d57fa8*/ UnityEngine.Avatar get_avatar();
        /*0x3d58eac*/ void set_avatar(UnityEngine.Avatar value);
        /*0x3d58fa4*/ string GetStats();
        /*0x3d59114*/ UnityEngine.Playables.PlayableGraph get_playableGraph();
        /*0x3d59138*/ void GetCurrentGraph(ref UnityEngine.Playables.PlayableGraph graph);
        /*0x3d53a30*/ void CheckIfInIKPass();
        /*0x3d59274*/ bool IsInIKPass();
        /*0x3d51664*/ void SetFloatString(string name, float value);
        /*0x3d519e4*/ void SetFloatID(int id, float value);
        /*0x3d51438*/ float GetFloatString(string name);
        /*0x3d515e0*/ float GetFloatID(int id);
        /*0x3d51d58*/ void SetBoolString(string name, bool value);
        /*0x3d51f0c*/ void SetBoolID(int id, bool value);
        /*0x3d51b24*/ bool GetBoolString(string name);
        /*0x3d51cd4*/ bool GetBoolID(int id);
        /*0x3d521d0*/ void SetIntegerString(string name, int value);
        /*0x3d52384*/ void SetIntegerID(int id, int value);
        /*0x3d51fa0*/ int GetIntegerString(string name);
        /*0x3d5214c*/ int GetIntegerID(int id);
        /*0x3d52418*/ void SetTriggerString(string name);
        /*0x3d525b8*/ void SetTriggerID(int id);
        /*0x3d5263c*/ void ResetTriggerString(string name);
        /*0x3d527dc*/ void ResetTriggerID(int id);
        /*0x3d52860*/ bool IsParameterControlledByCurveString(string name);
        /*0x3d52a10*/ bool IsParameterControlledByCurveID(int id);
        /*0x3d51818*/ void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);
        /*0x3d51a78*/ void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);
        /*0x3d59928*/ bool get_layersAffectMassCenter();
        /*0x3d599dc*/ void set_layersAffectMassCenter(bool value);
        /*0x3d59aa0*/ float get_leftFeetBottomHeight();
        /*0x3d59b54*/ float get_rightFeetBottomHeight();
        /*0x3d59c08*/ bool get_supportsOnAnimatorMove();
        /*0x3d59cbc*/ void OnUpdateModeChanged();
        /*0x3d59d70*/ void OnCullingModeChanged();
        /*0x3d59e24*/ void WriteDefaultPose();
        /*0x3d59ed8*/ void Update(float deltaTime);
        /*0x3d59fac*/ void Rebind();
        /*0x3d59fb4*/ void Rebind(bool writeDefaultValues);
        /*0x3d5a078*/ void ApplyBuiltinRootMotion();
        /*0x3d5a12c*/ void EvaluateController();
        /*0x3d5a134*/ void EvaluateController(float deltaTime);
        /*0x3d5a208*/ string GetCurrentStateName(int layerIndex);
        /*0x3d5a350*/ string GetNextStateName(int layerIndex);
        /*0x3d5a210*/ string GetAnimatorStateName(int layerIndex, bool current);
        /*0x3d5a3b4*/ string ResolveHash(int hash);
        /*0x3d591fc*/ bool get_logWarnings();
        /*0x3d5a57c*/ void set_logWarnings(bool value);
        /*0x3d5a640*/ bool get_fireEvents();
        /*0x3d5a6f4*/ void set_fireEvents(bool value);
        /*0x3d5a7b8*/ bool get_keepAnimatorControllerStateOnDisable();
        /*0x3d5a834*/ void set_keepAnimatorControllerStateOnDisable(bool value);
        /*0x3d5a7bc*/ bool get_keepAnimatorStateOnDisable();
        /*0x3d5a838*/ void set_keepAnimatorStateOnDisable(bool value);
        /*0x3d5a938*/ bool get_writeDefaultValuesOnDisable();
        /*0x3d5a9ec*/ void set_writeDefaultValuesOnDisable(bool value);
        /*0x3d5aab0*/ UnityEngine.Vector3 GetVector(string name);
        /*0x3d5aaf4*/ UnityEngine.Vector3 GetVector(int id);
        /*0x3d5ab38*/ void SetVector(string name, UnityEngine.Vector3 value);
        /*0x3d5ab3c*/ void SetVector(int id, UnityEngine.Vector3 value);
        /*0x3d5ab40*/ UnityEngine.Quaternion GetQuaternion(string name);
        /*0x3d5ab84*/ UnityEngine.Quaternion GetQuaternion(int id);
        /*0x3d5abc8*/ void SetQuaternion(string name, UnityEngine.Quaternion value);
        /*0x3d5abcc*/ void SetQuaternion(int id, UnityEngine.Quaternion value);
    }

    class AnimatorControllerParameter
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.AnimatorControllerParameterType m_Type;
        /*0x1c*/ float m_DefaultFloat;
        /*0x20*/ int m_DefaultInt;
        /*0x24*/ bool m_DefaultBool;

        /*0x3d5accc*/ AnimatorControllerParameter();
        /*0x3d5abd8*/ string get_name();
        /*0x3d5abe0*/ bool Equals(object o);
        /*0x3d5acb0*/ int GetHashCode();
    }

    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x3d5ad24*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0x3d5ad4c*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x3d5ade8*/ void Invoke();
        }
    }

    enum HumanBodyBones
    {
        Hips = 0,
        LeftUpperLeg = 1,
        RightUpperLeg = 2,
        LeftLowerLeg = 3,
        RightLowerLeg = 4,
        LeftFoot = 5,
        RightFoot = 6,
        Spine = 7,
        Chest = 8,
        UpperChest = 54,
        Neck = 9,
        Head = 10,
        LeftShoulder = 11,
        RightShoulder = 12,
        LeftUpperArm = 13,
        RightUpperArm = 14,
        LeftLowerArm = 15,
        RightLowerArm = 16,
        LeftHand = 17,
        RightHand = 18,
        LeftToes = 19,
        RightToes = 20,
        LeftEye = 21,
        RightEye = 22,
        Jaw = 23,
        LeftThumbProximal = 24,
        LeftThumbIntermediate = 25,
        LeftThumbDistal = 26,
        LeftIndexProximal = 27,
        LeftIndexIntermediate = 28,
        LeftIndexDistal = 29,
        LeftMiddleProximal = 30,
        LeftMiddleIntermediate = 31,
        LeftMiddleDistal = 32,
        LeftRingProximal = 33,
        LeftRingIntermediate = 34,
        LeftRingDistal = 35,
        LeftLittleProximal = 36,
        LeftLittleIntermediate = 37,
        LeftLittleDistal = 38,
        RightThumbProximal = 39,
        RightThumbIntermediate = 40,
        RightThumbDistal = 41,
        RightIndexProximal = 42,
        RightIndexIntermediate = 43,
        RightIndexDistal = 44,
        RightMiddleProximal = 45,
        RightMiddleIntermediate = 46,
        RightMiddleDistal = 47,
        RightRingProximal = 48,
        RightRingIntermediate = 49,
        RightRingDistal = 50,
        RightLittleProximal = 51,
        RightLittleIntermediate = 52,
        RightLittleDistal = 53,
        LastBone = 55,
    }

    class Avatar : UnityEngine.Object
    {
        static /*0x3d5ae54*/ bool get_isValid_Injected(nint _unity_self);
        static /*0x3d5ae90*/ bool get_isHuman_Injected(nint _unity_self);
        static /*0x3d5af74*/ void get_humanDescription_Injected(nint _unity_self, ref UnityEngine.HumanDescription ret);
        static /*0x3d5b050*/ void SetMuscleMinMax_Injected(nint _unity_self, int muscleId, float min, float max);
        static /*0x3d5b13c*/ void SetParameter_Injected(nint _unity_self, int parameterId, float value);
        static /*0x3d5b794*/ float Internal_GetAxisLength_Injected(nint _unity_self, int humanId);
        static /*0x3d5b7d8*/ void Internal_GetPreRotation_Injected(nint _unity_self, int humanId, ref UnityEngine.Quaternion ret);
        static /*0x3d5b82c*/ void Internal_GetPostRotation_Injected(nint _unity_self, int humanId, ref UnityEngine.Quaternion ret);
        static /*0x3d5b880*/ void Internal_GetZYPostQ_Injected(nint _unity_self, int humanId, ref UnityEngine.Quaternion parentQ, ref UnityEngine.Quaternion q, ref UnityEngine.Quaternion ret);
        static /*0x3d5b8ec*/ void Internal_GetZYRoll_Injected(nint _unity_self, int humanId, ref UnityEngine.Vector3 uvw, ref UnityEngine.Quaternion ret);
        static /*0x3d5b948*/ void Internal_GetLimitSign_Injected(nint _unity_self, int humanId, ref UnityEngine.Vector3 ret);
        /*0x3d5adfc*/ Avatar();
        /*0x3d5803c*/ bool get_isValid();
        /*0x3d580b4*/ bool get_isHuman();
        /*0x3d5aecc*/ UnityEngine.HumanDescription get_humanDescription();
        /*0x3d5afb8*/ void SetMuscleMinMax(int muscleId, float min, float max);
        /*0x3d5b0ac*/ void SetParameter(int parameterId, float value);
        /*0x3d5b190*/ float GetAxisLength(int humanId);
        /*0x3d5b25c*/ UnityEngine.Quaternion GetPreRotation(int humanId);
        /*0x3d5b344*/ UnityEngine.Quaternion GetPostRotation(int humanId);
        /*0x3d5b42c*/ UnityEngine.Quaternion GetZYPostQ(int humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q);
        /*0x3d5b58c*/ UnityEngine.Quaternion GetZYRoll(int humanId, UnityEngine.Vector3 uvw);
        /*0x3d5b6a8*/ UnityEngine.Vector3 GetLimitSign(int humanId);
        /*0x3d5b1dc*/ float Internal_GetAxisLength(int humanId);
        /*0x3d5b2a8*/ UnityEngine.Quaternion Internal_GetPreRotation(int humanId);
        /*0x3d5b390*/ UnityEngine.Quaternion Internal_GetPostRotation(int humanId);
        /*0x3d5b4d8*/ UnityEngine.Quaternion Internal_GetZYPostQ(int humanId, UnityEngine.Quaternion parentQ, UnityEngine.Quaternion q);
        /*0x3d5b600*/ UnityEngine.Quaternion Internal_GetZYRoll(int humanId, UnityEngine.Vector3 uvw);
        /*0x3d5b6f4*/ UnityEngine.Vector3 Internal_GetLimitSign(int humanId);
    }

    struct SkeletonBone
    {
        /*0x10*/ string name;
        /*0x18*/ string parentName;
        /*0x20*/ UnityEngine.Vector3 position;
        /*0x2c*/ UnityEngine.Quaternion rotation;
        /*0x3c*/ UnityEngine.Vector3 scale;
    }

    struct HumanLimit
    {
        /*0x10*/ UnityEngine.Vector3 m_Min;
        /*0x1c*/ UnityEngine.Vector3 m_Max;
        /*0x28*/ UnityEngine.Vector3 m_Center;
        /*0x34*/ float m_AxisLength;
        /*0x38*/ int m_UseDefaultValues;
    }

    struct HumanBone
    {
        /*0x10*/ string m_BoneName;
        /*0x18*/ string m_HumanName;
        /*0x20*/ UnityEngine.HumanLimit limit;
    }

    struct HumanDescription
    {
        /*0x10*/ UnityEngine.HumanBone[] human;
        /*0x18*/ UnityEngine.SkeletonBone[] skeleton;
        /*0x20*/ float m_ArmTwist;
        /*0x24*/ float m_ForeArmTwist;
        /*0x28*/ float m_UpperLegTwist;
        /*0x2c*/ float m_LegTwist;
        /*0x30*/ float m_ArmStretch;
        /*0x34*/ float m_LegStretch;
        /*0x38*/ float m_FeetSpacing;
        /*0x3c*/ float m_GlobalScale;
        /*0x40*/ string m_RootMotionBoneName;
        /*0x48*/ bool m_HasTranslationDoF;
        /*0x49*/ bool m_HasExtraRoot;
        /*0x4a*/ bool m_SkeletonHasParents;
    }

    enum AvatarMaskBodyPart
    {
        Root = 0,
        Body = 1,
        Head = 2,
        LeftLeg = 3,
        RightLeg = 4,
        LeftArm = 5,
        RightArm = 6,
        LeftFingers = 7,
        RightFingers = 8,
        LeftFootIK = 9,
        RightFootIK = 10,
        LeftHandIK = 11,
        RightHandIK = 12,
        LastBodyPart = 13,
    }

    class AvatarMask : UnityEngine.Object
    {
        static /*0x3d5ba1c*/ void Internal_Create(UnityEngine.AvatarMask self);
        static /*0x3d5bad8*/ bool GetHumanoidBodyPartActive_Injected(nint _unity_self, UnityEngine.AvatarMaskBodyPart index);
        static /*0x3d5bb94*/ int get_transformCount_Injected(nint _unity_self);
        static /*0x3d5bd08*/ void GetTransformPath_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d5bddc*/ float GetTransformWeight_Injected(nint _unity_self, int index);
        /*0x3d5b99c*/ AvatarMask();
        /*0x3d5ba58*/ bool GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index);
        /*0x3d5bb1c*/ int get_transformCount();
        /*0x3d5bbd0*/ string GetTransformPath(int index);
        /*0x3d5bd5c*/ float GetTransformWeight(int index);
        /*0x3d5be20*/ bool GetTransformActive(int index);
    }

    class HumanTrait
    {
        static /*0x3d55008*/ int GetBoneIndexFromMono(int humanId);
    }

    class Motion : UnityEngine.Object
    {
        /*0x18*/ bool <isAnimatorMotion>k__BackingField;

        static /*0x3d5beb4*/ bool get_isLooping_Injected(nint _unity_self);
        /*0x3d4f588*/ Motion();
        /*0x3d5be3c*/ bool get_isLooping();
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
        static /*0x3d5bfc0*/ UnityEngine.AnimationClip[] get_animationClips_Injected(nint _unity_self);
        /*0x3d5bef0*/ RuntimeAnimatorController();
        /*0x3d5bf48*/ UnityEngine.AnimationClip[] get_animationClips();
    }

    namespace Playables
    {
        class AnimationPlayableUtilities
        {
            static /*0x3d5bffc*/ void Play(UnityEngine.Animator animator, UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableGraph graph);
        }
    }

    namespace Animations
    {
        class AnimationPlayableBinding
        {
            static /*0x3d5c154*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key);
            static /*0x3d5c278*/ UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }

        class DiscreteEvaluationAttribute : System.Attribute
        {
            /*0x3d5c2e8*/ DiscreteEvaluationAttribute();
        }

        class DiscreteEvaluationAttributeUtilities
        {
            static /*0x3d5c2f0*/ int ConvertFloatToDiscreteInt(float f);
            static /*0x3d5c2f8*/ float ConvertDiscreteIntToFloat(int f);
        }

        interface IAnimationPreviewable
        {
        }

        class NotKeyableAttribute : System.Attribute
        {
        }

        struct AnimationClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5c300*/ UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x3d5c338*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x3d5c588*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable);
            static /*0x3d5c4d8*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5c674*/ void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x3d5c6fc*/ void SetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x3d5c784*/ void SetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x3d5c80c*/ void SetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x3d5c850*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, nint clip, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5c3e8*/ AnimationClipPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5c57c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5c5b8*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
            /*0x3d5c630*/ void SetApplyFootIK(bool value);
            /*0x3d5c6b8*/ void SetRemoveStartOffset(bool value);
            /*0x3d5c740*/ void SetOverrideLoopTime(bool value);
            /*0x3d5c7c8*/ void SetLoopTime(bool value);
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;
        }

        struct AnimationLayerMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5d0c0*/ AnimationLayerMixerPlayable();
            static /*0x3d5c8a4*/ UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool singleLayerOptimization);
            static /*0x3d5c94c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3d5cc64*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable);
            static /*0x3d5cb88*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5cc14*/ void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x3d5cf70*/ void SetLayerMaskFromAvatarMaskInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, UnityEngine.AvatarMask mask);
            static /*0x3d5d028*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5d06c*/ void SetLayerMaskFromAvatarMaskInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, nint mask);
            /*0x3d5ca3c*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization);
            /*0x3d5cc58*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5cce4*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
            /*0x3d5cd80*/ void SetLayerMaskFromAvatarMask(uint layerIndex, UnityEngine.AvatarMask mask);
        }

        struct AnimationMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5d63c*/ AnimationMixerPlayable();
            static /*0x3d5d160*/ UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool normalizeWeights);
            static /*0x3d5d1cc*/ UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3d5d264*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3d5d4dc*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable);
            static /*0x3d5d444*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5d5f8*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5d354*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5d4d0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5d55c*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
        }

        struct AnimationMotionXToDeltaPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5dc04*/ AnimationMotionXToDeltaPlayable();
            static /*0x3d5d6d8*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph);
            static /*0x3d5d768*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph);
            static /*0x3d5d9dc*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable);
            static /*0x3d5d944*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5db7c*/ void SetAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x3d5dbc0*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5d854*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5d9d0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5da5c*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
            /*0x3d5daf8*/ void SetAbsoluteMotion(bool value);
        }

        struct AnimationOffsetPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5e208*/ AnimationOffsetPlayable();
            static /*0x3d5dca0*/ UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x3d5dd90*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x3d5e078*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable);
            static /*0x3d5dfc8*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5e1ac*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5ded8*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5e06c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5e0f8*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
        }

        class AnimationPlayableExtensions
        {
            static /*0x1ffc854*/ void SetAnimatedProperties<U>(U playable, UnityEngine.AnimationClip clip);
            static /*0x3d5e2a4*/ void SetAnimatedPropertiesInternal(ref UnityEngine.Playables.PlayableHandle playable, UnityEngine.AnimationClip animatedProperties);
            static /*0x3d5e330*/ void SetAnimatedPropertiesInternal_Injected(ref UnityEngine.Playables.PlayableHandle playable, nint animatedProperties);
        }

        class AnimationPlayableGraphExtensions
        {
            static /*0x3d5c130*/ void SyncUpdateAndTimeMode(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animator animator);
            static /*0x3d5e424*/ bool InternalCreateAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x3d5e374*/ void InternalSyncUpdateAndTimeMode(ref UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animator animator);
            static /*0x3d5e5b0*/ bool InternalCreateAnimationOutput_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x3d5e604*/ void InternalSyncUpdateAndTimeMode_Injected(ref UnityEngine.Playables.PlayableGraph graph, nint animator);
        }

        struct AnimationPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x3d5c0d0*/ UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.Animator target);
            static /*0x3d5e648*/ UnityEngine.Animations.AnimationPlayableOutput get_Null();
            static /*0x3d5c2b8*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output);
            static /*0x3d5e7c4*/ UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x3d5e848*/ void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle, UnityEngine.Animator target);
            static /*0x3d5e8d4*/ void InternalSetTarget_Injected(ref UnityEngine.Playables.PlayableOutputHandle handle, nint target);
            /*0x3d5e6c4*/ AnimationPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x3d5e7b8*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x3d5e7b4*/ void SetTarget(UnityEngine.Animator value);
        }

        struct AnimationPosePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5eac8*/ AnimationPosePlayable();
            /*0x3d5e918*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5ea08*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5ea14*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
        }

        struct AnimationRemoveScalePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5efec*/ AnimationRemoveScalePlayable();
            static /*0x3d5eb64*/ UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3d5ebfc*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3d5ee74*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable);
            static /*0x3d5eddc*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x3d5efa8*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5ecec*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5ee68*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5eef4*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimationScriptPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5f220*/ AnimationScriptPlayable();
            /*0x3d5f088*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5f178*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5f184*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
        }

        struct AnimationStream
        {
            /*0x10*/ uint m_AnimatorBindingsVersion;
            /*0x18*/ nint constant;
            /*0x20*/ nint input;
            /*0x28*/ nint output;
            /*0x30*/ nint workspace;
            /*0x38*/ nint inputStreamAccessor;
            /*0x40*/ nint animationHandleBinder;
        }

        struct AnimatorControllerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimatorControllerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3d5f544*/ AnimatorControllerPlayable();
            /*0x3d5f2bc*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5f49c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3d5f358*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0x3d5f4a8*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
        }

        enum Axis
        {
            None = 0,
            X = 1,
            Y = 2,
            Z = 4,
        }

        struct ConstraintSource
        {
            /*0x10*/ UnityEngine.Transform m_SourceTransform;
            /*0x18*/ float m_Weight;
        }

        interface IConstraint
        {
        }

        interface IConstraintInternal
        {
        }

        class ParentConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x3d5f624*/ void Internal_Create(UnityEngine.Animations.ParentConstraint self);
            static /*0x3d5fadc*/ int GetSourceCountInternal(UnityEngine.Animations.ParentConstraint self);
            static /*0x3d60ef0*/ void SetSourcesInternal(UnityEngine.Animations.ParentConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x3d5f6d8*/ float get_weight_Injected(nint _unity_self);
            static /*0x3d5f79c*/ void set_weight_Injected(nint _unity_self, float value);
            static /*0x3d5f860*/ bool get_constraintActive_Injected(nint _unity_self);
            static /*0x3d5f91c*/ void set_constraintActive_Injected(nint _unity_self, bool value);
            static /*0x3d5f9d8*/ bool get_locked_Injected(nint _unity_self);
            static /*0x3d5fa94*/ void set_locked_Injected(nint _unity_self, bool value);
            static /*0x3d5fb84*/ int GetSourceCountInternal_Injected(nint self);
            static /*0x3d5fc58*/ void get_translationAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x3d5fd2c*/ void set_translationAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x3d5fe08*/ void get_rotationAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x3d5fedc*/ void set_rotationAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x3d60074*/ void get_translationOffsets_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            static /*0x3d601b8*/ void set_translationOffsets_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x3d60350*/ void get_rotationOffsets_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
            static /*0x3d60494*/ void set_rotationOffsets_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x3d60550*/ UnityEngine.Animations.Axis get_translationAxis_Injected(nint _unity_self);
            static /*0x3d6060c*/ void set_translationAxis_Injected(nint _unity_self, UnityEngine.Animations.Axis value);
            static /*0x3d606c8*/ UnityEngine.Animations.Axis get_rotationAxis_Injected(nint _unity_self);
            static /*0x3d60784*/ void set_rotationAxis_Injected(nint _unity_self, UnityEngine.Animations.Axis value);
            static /*0x3d60aa8*/ void GetTranslationOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 ret);
            static /*0x3d60afc*/ void SetTranslationOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 value);
            static /*0x3d60d00*/ void GetRotationOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 ret);
            static /*0x3d60d54*/ void SetRotationOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 value);
            static /*0x3d60e58*/ void GetSources_Injected(nint _unity_self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x3d60fa0*/ void SetSourcesInternal_Injected(nint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x3d61070*/ int AddSource_Injected(nint _unity_self, ref UnityEngine.Animations.ConstraintSource source);
            static /*0x3d6115c*/ void RemoveSourceInternal_Injected(nint _unity_self, int index);
            static /*0x3d61260*/ void GetSourceInternal_Injected(nint _unity_self, int index, ref UnityEngine.Animations.ConstraintSource ret);
            static /*0x3d61388*/ void SetSourceInternal_Injected(nint _unity_self, int index, ref UnityEngine.Animations.ConstraintSource source);
            /*0x3d5f5e0*/ ParentConstraint();
            /*0x3d5f660*/ float get_weight();
            /*0x3d5f714*/ void set_weight(float value);
            /*0x3d5f7e8*/ bool get_constraintActive();
            /*0x3d5f89c*/ void set_constraintActive(bool value);
            /*0x3d5f960*/ bool get_locked();
            /*0x3d5fa14*/ void set_locked(bool value);
            /*0x3d5fad8*/ int get_sourceCount();
            /*0x3d5fbc0*/ UnityEngine.Vector3 get_translationAtRest();
            /*0x3d5fc9c*/ void set_translationAtRest(UnityEngine.Vector3 value);
            /*0x3d5fd70*/ UnityEngine.Vector3 get_rotationAtRest();
            /*0x3d5fe4c*/ void set_rotationAtRest(UnityEngine.Vector3 value);
            /*0x3d5ff20*/ UnityEngine.Vector3[] get_translationOffsets();
            /*0x3d600b8*/ void set_translationOffsets(UnityEngine.Vector3[] value);
            /*0x3d601fc*/ UnityEngine.Vector3[] get_rotationOffsets();
            /*0x3d60394*/ void set_rotationOffsets(UnityEngine.Vector3[] value);
            /*0x3d604d8*/ UnityEngine.Animations.Axis get_translationAxis();
            /*0x3d6058c*/ void set_translationAxis(UnityEngine.Animations.Axis value);
            /*0x3d60650*/ UnityEngine.Animations.Axis get_rotationAxis();
            /*0x3d60704*/ void set_rotationAxis(UnityEngine.Animations.Axis value);
            /*0x3d607c8*/ UnityEngine.Vector3 GetTranslationOffset(int index);
            /*0x3d609c0*/ void SetTranslationOffset(int index, UnityEngine.Vector3 value);
            /*0x3d60920*/ UnityEngine.Vector3 GetTranslationOffsetInternal(int index);
            /*0x3d60a10*/ void SetTranslationOffsetInternal(int index, UnityEngine.Vector3 value);
            /*0x3d60b50*/ UnityEngine.Vector3 GetRotationOffset(int index);
            /*0x3d60c18*/ void SetRotationOffset(int index, UnityEngine.Vector3 value);
            /*0x3d60b78*/ UnityEngine.Vector3 GetRotationOffsetInternal(int index);
            /*0x3d60c68*/ void SetRotationOffsetInternal(int index, UnityEngine.Vector3 value);
            /*0x3d607f0*/ void ValidateSourceIndex(int index);
            /*0x3d60da8*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x3d60e9c*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x3d60fe4*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x3d610b4*/ void RemoveSource(int index);
            /*0x3d610dc*/ void RemoveSourceInternal(int index);
            /*0x3d611a0*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x3d611c8*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x3d612b4*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x3d612f4*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
        }
    }
}
