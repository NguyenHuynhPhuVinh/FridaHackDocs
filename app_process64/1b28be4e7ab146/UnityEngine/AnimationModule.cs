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
        /*0x7df18bc*/ StateMachineBehaviour();
        /*0x7df1884*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7df1888*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7df188c*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7df1890*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7df1894*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7df1898*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x7df189c*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x7df18a0*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7df18a4*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7df18a8*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7df18ac*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7df18b0*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7df18b4*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7df18b8*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
    }

    enum PlayMode
    {
        StopSameLayer = 0,
        StopAll = 4,
    }

    enum AnimationEventSource
    {
        NoSource = 0,
        Legacy = 1,
        Animator = 2,
    }

    class Animation : UnityEngine.Behaviour, System.Collections.IEnumerable
    {
        static /*0x7df193c*/ void Stop_Injected(nint _unity_self);
        static /*0x7df1a04*/ bool PlayDefaultAnimation_Injected(nint _unity_self, UnityEngine.PlayMode mode);
        static /*0x7df1b70*/ UnityEngine.AnimationState GetStateAtIndex_Injected(nint _unity_self, int index);
        static /*0x7df1c2c*/ int GetStateCount_Injected(nint _unity_self);
        /*0x7df18c4*/ void Stop();
        /*0x7df1978*/ bool Play();
        /*0x7df1980*/ bool Play(UnityEngine.PlayMode mode);
        /*0x7df1984*/ bool PlayDefaultAnimation(UnityEngine.PlayMode mode);
        /*0x7df1a48*/ System.Collections.IEnumerator GetEnumerator();
        /*0x7df1af0*/ UnityEngine.AnimationState GetStateAtIndex(int index);
        /*0x7df1bb4*/ int GetStateCount();

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Animation m_Outer;
            /*0x18*/ int m_CurrentIndex;

            /*0x7df1ab8*/ Enumerator(UnityEngine.Animation outer);
            /*0x7df1c68*/ object get_Current();
            /*0x7df1c88*/ bool MoveNext();
            /*0x7df1cbc*/ void Reset();
        }
    }

    class AnimationState : UnityEngine.TrackedReference
    {
        /*0x7df1cc8*/ AnimationState();
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

        static /*0x7df1cd0*/ UnityEngine.AnimationEventBlittable FromAnimationEvent(UnityEngine.AnimationEvent animationEvent);
        static /*0x7df1ec0*/ void FromAnimationEvents(UnityEngine.AnimationEvent[] animationEvents, UnityEngine.AnimationEventBlittable* animationEventBlittables);
        static /*0x7df2064*/ UnityEngine.AnimationEvent PointerToAnimationEvent(nint animationEventBlittable);
        static /*0x7df2334*/ UnityEngine.AnimationEvent[] PointerToAnimationEvents(nint animationEventBlittableArray, int size);
        static /*0x7df2434*/ void DisposeEvents(nint animationEventBlittableArray, int size);
        static /*0x7df25a4*/ void FreeEventsInternal(nint value);
        static /*0x7df2098*/ UnityEngine.AnimationEvent ToAnimationEvent(UnityEngine.AnimationEventBlittable animationEventBlittable);
        /*0x7df24a0*/ void Dispose();
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

        /*0x7df25e0*/ AnimationEvent();
    }

    class AnimationClip : UnityEngine.Motion
    {
        static /*0x7df2814*/ void Internal_CreateAnimationClip(UnityEngine.AnimationClip self);
        static /*0x7df2904*/ void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode);
        static /*0x7df2a40*/ void SampleAnimation_Injected(nint go, nint clip, float inTime, UnityEngine.WrapMode wrapMode);
        static /*0x7df2b1c*/ float get_length_Injected(nint _unity_self);
        static /*0x7df2bd0*/ float get_startTime_Injected(nint _unity_self);
        static /*0x7df2c84*/ float get_stopTime_Injected(nint _unity_self);
        static /*0x7df2d38*/ float get_frameRate_Injected(nint _unity_self);
        static /*0x7df2dfc*/ void set_frameRate_Injected(nint _unity_self, float value);
        static /*0x7df315c*/ void SetCurve_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper relativePath, System.Type type, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName, nint curve);
        static /*0x7df3240*/ void EnsureQuaternionContinuity_Injected(nint _unity_self);
        static /*0x7df32f4*/ void ClearCurves_Injected(nint _unity_self);
        static /*0x7df3330*/ UnityEngine.WrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x7df33ec*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.WrapMode value);
        static /*0x7df34d4*/ void get_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7df3598*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x7df3654*/ bool get_legacy_Injected(nint _unity_self);
        static /*0x7df3710*/ void set_legacy_Injected(nint _unity_self, bool value);
        static /*0x7df37cc*/ bool get_humanMotion_Injected(nint _unity_self);
        static /*0x7df3880*/ bool get_empty_Injected(nint _unity_self);
        static /*0x7df3934*/ bool get_hasGenericRootTransform_Injected(nint _unity_self);
        static /*0x7df39e8*/ bool get_hasMotionFloatCurves_Injected(nint _unity_self);
        static /*0x7df3a9c*/ bool get_hasMotionCurves_Injected(nint _unity_self);
        static /*0x7df3b50*/ bool get_hasRootCurves_Injected(nint _unity_self);
        static /*0x7df3c04*/ bool get_hasRootMotion_Injected(nint _unity_self);
        static /*0x7df3db4*/ void AddEventInternal_Injected(nint _unity_self, object evt);
        static /*0x7df40d8*/ void SetEventsInternal_Injected(nint _unity_self, void* data, int length);
        static /*0x7df412c*/ void GetEventsInternal_Injected(nint _unity_self, ref nint values, ref int size);
        /*0x7df277c*/ AnimationClip();
        /*0x7df2850*/ void SampleAnimation(UnityEngine.GameObject go, float time);
        /*0x7df2aa4*/ float get_length();
        /*0x7df2b58*/ float get_startTime();
        /*0x7df2c0c*/ float get_stopTime();
        /*0x7df2cc0*/ float get_frameRate();
        /*0x7df2d74*/ void set_frameRate(float value);
        /*0x7df2e48*/ void SetCurve(string relativePath, System.Type type, string propertyName, UnityEngine.AnimationCurve curve);
        /*0x7df31c8*/ void EnsureQuaternionContinuity();
        /*0x7df327c*/ void ClearCurves();
        /*0x7df288c*/ UnityEngine.WrapMode get_wrapMode();
        /*0x7df336c*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x7df3430*/ UnityEngine.Bounds get_localBounds();
        /*0x7df3518*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x7df35dc*/ bool get_legacy();
        /*0x7df3690*/ void set_legacy(bool value);
        /*0x7df3754*/ bool get_humanMotion();
        /*0x7df3808*/ bool get_empty();
        /*0x7df38bc*/ bool get_hasGenericRootTransform();
        /*0x7df3970*/ bool get_hasMotionFloatCurves();
        /*0x7df3a24*/ bool get_hasMotionCurves();
        /*0x7df3ad8*/ bool get_hasRootCurves();
        /*0x7df3b8c*/ bool get_hasRootMotion();
        /*0x7df3c40*/ void AddEvent(UnityEngine.AnimationEvent evt);
        /*0x7df3d34*/ void AddEventInternal(object evt);
        /*0x7df3df8*/ UnityEngine.AnimationEvent[] get_events();
        /*0x7df3ed4*/ void set_events(UnityEngine.AnimationEvent[] value);
        /*0x7df4048*/ void SetEventsInternal(void* data, int length);
        /*0x7df3e44*/ void GetEventsInternal(ref nint values, ref int size);
    }

    class GCHandlePool
    {
        /*0x10*/ System.Runtime.InteropServices.GCHandle[] m_handles;
        /*0x18*/ int m_current;

        /*0x7df1e5c*/ GCHandlePool();
        /*0x7df4180*/ System.Runtime.InteropServices.GCHandle Alloc(object o);
        /*0x7df421c*/ nint AllocHandleIfNotNull(object o);
        /*0x7df2670*/ void Free(System.Runtime.InteropServices.GCHandle h);
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

        static /*0x7df4240*/ UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(int instanceID);
        static /*0x7df42b4*/ nint InstanceIDToAnimationClipPPtr_Injected(int instanceID);
        /*0x7df422c*/ UnityEngine.AnimationClip get_clip();
        /*0x7df42ac*/ float get_weight();
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

        /*0x7df42f0*/ bool IsName(string name);
        /*0x7df44a4*/ int get_fullPathHash();
        /*0x7df44ac*/ float get_normalizedTime();
        /*0x7df44b4*/ float get_speed();
        /*0x7df44bc*/ float get_speedMultiplier();
        /*0x7df44c4*/ bool get_loop();
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
        static /*0x38379c4*/ T[] ConvertStateMachineBehaviour<T>(UnityEngine.ScriptableObject[] rawObjects);
        static /*0x7df4334*/ int StringToHash(string name);
        static /*0x7df454c*/ bool get_isOptimizable_Injected(nint _unity_self);
        static /*0x7df4600*/ bool get_isHuman_Injected(nint _unity_self);
        static /*0x7df46b4*/ bool get_hasRootMotion_Injected(nint _unity_self);
        static /*0x7df4768*/ bool get_isRootPositionOrRotationControlledByCurves_Injected(nint _unity_self);
        static /*0x7df481c*/ float get_humanScale_Injected(nint _unity_self);
        static /*0x7df48d0*/ bool get_isInitialized_Injected(nint _unity_self);
        static /*0x7df6008*/ void get_deltaPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7df60e0*/ void get_deltaRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7df61bc*/ void get_velocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7df6298*/ void get_angularVelocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7df6374*/ void get_rootPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7df6448*/ void set_rootPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7df6520*/ void get_rootRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7df65f4*/ void set_rootRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7df66b0*/ bool get_applyRootMotion_Injected(nint _unity_self);
        static /*0x7df676c*/ void set_applyRootMotion_Injected(nint _unity_self, bool value);
        static /*0x7df6828*/ bool get_linearVelocityBlending_Injected(nint _unity_self);
        static /*0x7df68e4*/ void set_linearVelocityBlending_Injected(nint _unity_self, bool value);
        static /*0x7df69a0*/ bool get_animatePhysics_Injected(nint _unity_self);
        static /*0x7df6a5c*/ void set_animatePhysics_Injected(nint _unity_self, bool value);
        static /*0x7df6b18*/ UnityEngine.AnimatorUpdateMode get_updateMode_Injected(nint _unity_self);
        static /*0x7df6bd4*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.AnimatorUpdateMode value);
        static /*0x7df6c90*/ bool get_hasTransformHierarchy_Injected(nint _unity_self);
        static /*0x7df6d44*/ bool get_allowConstantClipSamplingOptimization_Injected(nint _unity_self);
        static /*0x7df6e00*/ void set_allowConstantClipSamplingOptimization_Injected(nint _unity_self, bool value);
        static /*0x7df6ebc*/ float get_gravityWeight_Injected(nint _unity_self);
        static /*0x7df7108*/ void get_bodyPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7df714c*/ void set_bodyPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7df7314*/ void get_bodyRotationInternal_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7df7358*/ void set_bodyRotationInternal_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7df7464*/ void GetGoalPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 ret);
        static /*0x7df75a0*/ void SetGoalPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 goalPosition);
        static /*0x7df76b8*/ void GetGoalRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion ret);
        static /*0x7df77fc*/ void SetGoalRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion goalRotation);
        static /*0x7df78f8*/ float GetGoalWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal);
        static /*0x7df7a04*/ void SetGoalWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, float value);
        static /*0x7df7b00*/ float GetGoalWeightRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal);
        static /*0x7df7c0c*/ void SetGoalWeightRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, float value);
        static /*0x7df7d28*/ void GetHintPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 ret);
        static /*0x7df7e64*/ void SetHintPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 hintPosition);
        static /*0x7df7f60*/ float GetHintWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint);
        static /*0x7df806c*/ void SetHintWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, float value);
        static /*0x7df8190*/ void SetLookAtPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 lookAtPosition);
        static /*0x7df83ec*/ void SetLookAtWeightInternal_Injected(nint _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        static /*0x7df85bc*/ void SetBoneLocalRotationInternal_Injected(nint _unity_self, int humanBoneId, ref UnityEngine.Quaternion rotation);
        static /*0x7df86e4*/ nint GetBehaviour_Injected(nint _unity_self, System.Type type);
        static /*0x7df87d8*/ UnityEngine.ScriptableObject[] InternalGetBehaviours_Injected(nint _unity_self, System.Type type);
        static /*0x7df8988*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey_Injected(nint _unity_self, int fullPathHash, int layerIndex, System.Type type);
        static /*0x7df8a5c*/ bool get_stabilizeFeet_Injected(nint _unity_self);
        static /*0x7df8b18*/ void set_stabilizeFeet_Injected(nint _unity_self, bool value);
        static /*0x7df8bd4*/ int get_layerCount_Injected(nint _unity_self);
        static /*0x7df8d18*/ void GetLayerName_Injected(nint _unity_self, int layerIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7df8f14*/ int GetLayerIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
        static /*0x7df8fd8*/ float GetLayerWeight_Injected(nint _unity_self, int layerIndex);
        static /*0x7df90ac*/ void SetLayerWeight_Injected(nint _unity_self, int layerIndex, float weight);
        static /*0x7df9198*/ void GetAnimatorStateInfo_Injected(nint _unity_self, int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        static /*0x7df9304*/ void GetAnimatorTransitionInfo_Injected(nint _unity_self, int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        static /*0x7df9418*/ int GetAnimatorClipInfoCount_Injected(nint _unity_self, int layerIndex, bool current);
        static /*0x7df94fc*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo_Injected(nint _unity_self, int layerIndex);
        static /*0x7df95c0*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo_Injected(nint _unity_self, int layerIndex);
        static /*0x7df96f8*/ void GetAnimatorClipInfoInternal_Injected(nint _unity_self, int layerIndex, bool isCurrent, object clips);
        static /*0x7df9830*/ bool IsInTransition_Injected(nint _unity_self, int layerIndex);
        static /*0x7df98ec*/ UnityEngine.AnimatorControllerParameter[] get_parameters_Injected(nint _unity_self);
        static /*0x7df99a0*/ int get_parameterCount_Injected(nint _unity_self);
        static /*0x7df9a5c*/ UnityEngine.AnimatorControllerParameter GetParameterInternal_Injected(nint _unity_self, int index);
        static /*0x7df9bb8*/ float get_feetPivotActive_Injected(nint _unity_self);
        static /*0x7df9c7c*/ void set_feetPivotActive_Injected(nint _unity_self, float value);
        static /*0x7df9d40*/ float get_pivotWeight_Injected(nint _unity_self);
        static /*0x7df9e14*/ void get_pivotPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7df9f30*/ void MatchTarget_Injected(nint _unity_self, ref UnityEngine.Vector3 matchPosition, ref UnityEngine.Quaternion matchRotation, int targetBodyPart, ref UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        static /*0x7dfa0b8*/ void InterruptMatchTarget_Injected(nint _unity_self, bool completeMatch);
        static /*0x7dfa174*/ bool get_isMatchingTarget_Injected(nint _unity_self);
        static /*0x7dfa228*/ float get_speed_Injected(nint _unity_self);
        static /*0x7dfa2ec*/ void set_speed_Injected(nint _unity_self, float value);
        static /*0x7dfa5e8*/ void CrossFadeInFixedTime_Injected(nint _unity_self, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        static /*0x7dfa6dc*/ void WriteDefaultValues_Injected(nint _unity_self);
        static /*0x7dfa900*/ void CrossFade_Injected(nint _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        static /*0x7dfaaec*/ void PlayInFixedTime_Injected(nint _unity_self, int stateNameHash, int layer, float fixedTime);
        static /*0x7dfac10*/ void Play_Injected(nint _unity_self, int stateNameHash, int layer, float normalizedTime);
        static /*0x7dfad20*/ void SetTarget_Injected(nint _unity_self, UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        static /*0x7dfae0c*/ void get_targetPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7dfaee4*/ void get_targetRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7dfafe4*/ bool IsBoneTransform_Injected(nint _unity_self, nint transform);
        static /*0x7dfb0bc*/ nint get_avatarRoot_Injected(nint _unity_self);
        static /*0x7dfb514*/ nint GetBoneTransformInternal_Injected(nint _unity_self, int humanBoneId);
        static /*0x7dfb5d0*/ UnityEngine.AnimatorCullingMode get_cullingMode_Injected(nint _unity_self);
        static /*0x7dfb68c*/ void set_cullingMode_Injected(nint _unity_self, UnityEngine.AnimatorCullingMode value);
        static /*0x7dfb748*/ void StartPlayback_Injected(nint _unity_self);
        static /*0x7dfb7fc*/ void StopPlayback_Injected(nint _unity_self);
        static /*0x7dfb8b0*/ float get_playbackTime_Injected(nint _unity_self);
        static /*0x7dfb974*/ void set_playbackTime_Injected(nint _unity_self, float value);
        static /*0x7dfba40*/ void StartRecording_Injected(nint _unity_self, int frameCount);
        static /*0x7dfbafc*/ void StopRecording_Injected(nint _unity_self);
        static /*0x7dfbbb8*/ float GetRecorderStartTime_Injected(nint _unity_self);
        static /*0x7dfbc74*/ float GetRecorderStopTime_Injected(nint _unity_self);
        static /*0x7dfbd28*/ UnityEngine.AnimatorRecorderMode get_recorderMode_Injected(nint _unity_self);
        static /*0x7dfbdf8*/ nint get_runtimeAnimatorController_Injected(nint _unity_self);
        static /*0x7dfbee8*/ void set_runtimeAnimatorController_Injected(nint _unity_self, nint value);
        static /*0x7dfbfa4*/ bool get_hasBoundPlayables_Injected(nint _unity_self);
        static /*0x7dfc058*/ void ClearInternalControllerPlayable_Injected(nint _unity_self);
        static /*0x7dfc124*/ bool HasState_Injected(nint _unity_self, int layerIndex, int stateID);
        static /*0x7dfc178*/ int StringToHash_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfc1b4*/ nint get_avatar_Injected(nint _unity_self);
        static /*0x7dfc2a4*/ void set_avatar_Injected(nint _unity_self, nint value);
        static /*0x7dfc3e4*/ void GetStats_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfc4cc*/ void GetCurrentGraph_Injected(nint _unity_self, ref UnityEngine.Playables.PlayableGraph graph);
        static /*0x7dfc600*/ bool IsInIKPass_Injected(nint _unity_self);
        static /*0x7dfc63c*/ void SetFloatString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value);
        static /*0x7dfc690*/ void SetFloatID_Injected(nint _unity_self, int id, float value);
        static /*0x7dfc6e4*/ float GetFloatString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfc728*/ float GetFloatID_Injected(nint _unity_self, int id);
        static /*0x7dfc76c*/ void SetBoolString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, bool value);
        static /*0x7dfc7c0*/ void SetBoolID_Injected(nint _unity_self, int id, bool value);
        static /*0x7dfc814*/ bool GetBoolString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfc858*/ bool GetBoolID_Injected(nint _unity_self, int id);
        static /*0x7dfc89c*/ void SetIntegerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, int value);
        static /*0x7dfc8f0*/ void SetIntegerID_Injected(nint _unity_self, int id, int value);
        static /*0x7dfc944*/ int GetIntegerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfc988*/ int GetIntegerID_Injected(nint _unity_self, int id);
        static /*0x7dfc9cc*/ void SetTriggerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfca10*/ void SetTriggerID_Injected(nint _unity_self, int id);
        static /*0x7dfca54*/ void ResetTriggerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfca98*/ void ResetTriggerID_Injected(nint _unity_self, int id);
        static /*0x7dfcadc*/ bool IsParameterControlledByCurveString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7dfcb20*/ bool IsParameterControlledByCurveID_Injected(nint _unity_self, int id);
        static /*0x7dfcb64*/ void SetFloatStringDamp_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value, float dampTime, float deltaTime);
        static /*0x7dfcbd0*/ void SetFloatIDDamp_Injected(nint _unity_self, int id, float value, float dampTime, float deltaTime);
        static /*0x7dfccb4*/ bool get_layersAffectMassCenter_Injected(nint _unity_self);
        static /*0x7dfcd70*/ void set_layersAffectMassCenter_Injected(nint _unity_self, bool value);
        static /*0x7dfce2c*/ float get_leftFeetBottomHeight_Injected(nint _unity_self);
        static /*0x7dfcee0*/ float get_rightFeetBottomHeight_Injected(nint _unity_self);
        static /*0x7dfcf94*/ bool get_supportsOnAnimatorMove_Injected(nint _unity_self);
        static /*0x7dfd048*/ void OnUpdateModeChanged_Injected(nint _unity_self);
        static /*0x7dfd0fc*/ void OnCullingModeChanged_Injected(nint _unity_self);
        static /*0x7dfd1b0*/ void WriteDefaultPose_Injected(nint _unity_self);
        static /*0x7dfd274*/ void Update_Injected(nint _unity_self, float deltaTime);
        static /*0x7dfd348*/ void Rebind_Injected(nint _unity_self, bool writeDefaultValues);
        static /*0x7dfd404*/ void ApplyBuiltinRootMotion_Injected(nint _unity_self);
        static /*0x7dfd4d0*/ void EvaluateController_Injected(nint _unity_self, float deltaTime);
        static /*0x7dfd644*/ void GetAnimatorStateName_Injected(nint _unity_self, int layerIndex, bool current, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfd7a8*/ void ResolveHash_Injected(nint _unity_self, int hash, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfd7fc*/ bool get_logWarnings_Injected(nint _unity_self);
        static /*0x7dfd8b8*/ void set_logWarnings_Injected(nint _unity_self, bool value);
        static /*0x7dfd974*/ bool get_fireEvents_Injected(nint _unity_self);
        static /*0x7dfda30*/ void set_fireEvents_Injected(nint _unity_self, bool value);
        static /*0x7dfdb78*/ bool get_keepAnimatorStateOnDisable_Injected(nint _unity_self);
        static /*0x7dfdbb4*/ void set_keepAnimatorStateOnDisable_Injected(nint _unity_self, bool value);
        static /*0x7dfdc70*/ bool get_writeDefaultValuesOnDisable_Injected(nint _unity_self);
        static /*0x7dfdd2c*/ void set_writeDefaultValuesOnDisable_Injected(nint _unity_self, bool value);
        /*0x7dfde90*/ Animator();
        /*0x7df44d4*/ bool get_isOptimizable();
        /*0x7df4588*/ bool get_isHuman();
        /*0x7df463c*/ bool get_hasRootMotion();
        /*0x7df46f0*/ bool get_isRootPositionOrRotationControlledByCurves();
        /*0x7df47a4*/ float get_humanScale();
        /*0x7df4858*/ bool get_isInitialized();
        /*0x7df490c*/ float GetFloat(string name);
        /*0x7df4ab4*/ float GetFloat(int id);
        /*0x7df4b38*/ void SetFloat(string name, float value);
        /*0x7df4cec*/ void SetFloat(string name, float value, float dampTime, float deltaTime);
        /*0x7df4eb8*/ void SetFloat(int id, float value);
        /*0x7df4f4c*/ void SetFloat(int id, float value, float dampTime, float deltaTime);
        /*0x7df4ff8*/ bool GetBool(string name);
        /*0x7df51a8*/ bool GetBool(int id);
        /*0x7df522c*/ void SetBool(string name, bool value);
        /*0x7df53e4*/ void SetBool(int id, bool value);
        /*0x7df547c*/ int GetInteger(string name);
        /*0x7df5628*/ int GetInteger(int id);
        /*0x7df56ac*/ void SetInteger(string name, int value);
        /*0x7df5860*/ void SetInteger(int id, int value);
        /*0x7df58f4*/ void SetTrigger(string name);
        /*0x7df5a94*/ void SetTrigger(int id);
        /*0x7df5b18*/ void ResetTrigger(string name);
        /*0x7df5cb8*/ void ResetTrigger(int id);
        /*0x7df5d3c*/ bool IsParameterControlledByCurve(string name);
        /*0x7df5eec*/ bool IsParameterControlledByCurve(int id);
        /*0x7df5f70*/ UnityEngine.Vector3 get_deltaPosition();
        /*0x7df604c*/ UnityEngine.Quaternion get_deltaRotation();
        /*0x7df6124*/ UnityEngine.Vector3 get_velocity();
        /*0x7df6200*/ UnityEngine.Vector3 get_angularVelocity();
        /*0x7df62dc*/ UnityEngine.Vector3 get_rootPosition();
        /*0x7df63b8*/ void set_rootPosition(UnityEngine.Vector3 value);
        /*0x7df648c*/ UnityEngine.Quaternion get_rootRotation();
        /*0x7df6564*/ void set_rootRotation(UnityEngine.Quaternion value);
        /*0x7df6638*/ bool get_applyRootMotion();
        /*0x7df66ec*/ void set_applyRootMotion(bool value);
        /*0x7df67b0*/ bool get_linearVelocityBlending();
        /*0x7df6864*/ void set_linearVelocityBlending(bool value);
        /*0x7df6928*/ bool get_animatePhysics();
        /*0x7df69dc*/ void set_animatePhysics(bool value);
        /*0x7df6aa0*/ UnityEngine.AnimatorUpdateMode get_updateMode();
        /*0x7df6b54*/ void set_updateMode(UnityEngine.AnimatorUpdateMode value);
        /*0x7df6c18*/ bool get_hasTransformHierarchy();
        /*0x7df6ccc*/ bool get_allowConstantClipSamplingOptimization();
        /*0x7df6d80*/ void set_allowConstantClipSamplingOptimization(bool value);
        /*0x7df6e44*/ float get_gravityWeight();
        /*0x7df6ef8*/ UnityEngine.Vector3 get_bodyPosition();
        /*0x7df7038*/ void set_bodyPosition(UnityEngine.Vector3 value);
        /*0x7df6fa0*/ UnityEngine.Vector3 get_bodyPositionInternal();
        /*0x7df7078*/ void set_bodyPositionInternal(UnityEngine.Vector3 value);
        /*0x7df7190*/ UnityEngine.Quaternion get_bodyRotation();
        /*0x7df723c*/ void set_bodyRotation(UnityEngine.Quaternion value);
        /*0x7df71a8*/ UnityEngine.Quaternion get_bodyRotationInternal();
        /*0x7df7284*/ void set_bodyRotationInternal(UnityEngine.Quaternion value);
        /*0x7df739c*/ UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal);
        /*0x7df73c4*/ UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal);
        /*0x7df74b8*/ void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x7df7508*/ void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x7df75f4*/ UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal);
        /*0x7df761c*/ UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal);
        /*0x7df770c*/ void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x7df7764*/ void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x7df7850*/ float GetIKPositionWeight(UnityEngine.AvatarIKGoal goal);
        /*0x7df7878*/ float GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal);
        /*0x7df793c*/ void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7df7974*/ void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7df7a58*/ float GetIKRotationWeight(UnityEngine.AvatarIKGoal goal);
        /*0x7df7a80*/ float GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal);
        /*0x7df7b44*/ void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7df7b7c*/ void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7df7c60*/ UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x7df7c88*/ UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x7df7d7c*/ void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x7df7dcc*/ void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x7df7eb8*/ float GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint);
        /*0x7df7ee0*/ float GetHintWeightPosition(UnityEngine.AvatarIKHint hint);
        /*0x7df7fa4*/ void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, float value);
        /*0x7df7fdc*/ void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, float value);
        /*0x7df80c0*/ void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition);
        /*0x7df8100*/ void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition);
        /*0x7df81d4*/ void SetLookAtWeight(float weight);
        /*0x7df82c4*/ void SetLookAtWeight(float weight, float bodyWeight);
        /*0x7df8300*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
        /*0x7df8348*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
        /*0x7df8394*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x7df820c*/ void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x7df8468*/ void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation);
        /*0x7df8524*/ void SetBoneLocalRotationInternal(int humanBoneId, UnityEngine.Quaternion rotation);
        /*0x7df8610*/ UnityEngine.ScriptableObject GetBehaviour(System.Type type);
        /*0x3910ae8*/ T GetBehaviour<T>();
        /*0x38148bc*/ T[] GetBehaviours<T>();
        /*0x7df8728*/ UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type);
        /*0x7df881c*/ UnityEngine.StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex);
        /*0x7df88c0*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, System.Type type);
        /*0x7df89e4*/ bool get_stabilizeFeet();
        /*0x7df8a98*/ void set_stabilizeFeet(bool value);
        /*0x7df8b5c*/ int get_layerCount();
        /*0x7df8c10*/ string GetLayerName(int layerIndex);
        /*0x7df8d6c*/ int GetLayerIndex(string layerName);
        /*0x7df8f58*/ float GetLayerWeight(int layerIndex);
        /*0x7df901c*/ void SetLayerWeight(int layerIndex, float weight);
        /*0x7df9100*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x7df91f4*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x7df9234*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        /*0x7df9274*/ void GetAnimatorTransitionInfo(int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        /*0x7df9358*/ UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
        /*0x7df9388*/ int GetAnimatorClipInfoCount(int layerIndex, bool current);
        /*0x7df946c*/ int GetCurrentAnimatorClipInfoCount(int layerIndex);
        /*0x7df9474*/ int GetNextAnimatorClipInfoCount(int layerIndex);
        /*0x7df947c*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        /*0x7df9540*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
        /*0x7df9604*/ void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x7df9660*/ void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);
        /*0x7df9754*/ void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x7df97b0*/ bool IsInTransition(int layerIndex);
        /*0x7df9874*/ UnityEngine.AnimatorControllerParameter[] get_parameters();
        /*0x7df9928*/ int get_parameterCount();
        /*0x7df99dc*/ UnityEngine.AnimatorControllerParameter GetParameterInternal(int index);
        /*0x7df9aa0*/ UnityEngine.AnimatorControllerParameter GetParameter(int index);
        /*0x7df9b40*/ float get_feetPivotActive();
        /*0x7df9bf4*/ void set_feetPivotActive(float value);
        /*0x7df9cc8*/ float get_pivotWeight();
        /*0x7df9d7c*/ UnityEngine.Vector3 get_pivotPosition();
        /*0x7df9e58*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, int targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x7df9fbc*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime);
        /*0x7df9ff0*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);
        /*0x7dfa010*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x7dfa030*/ void InterruptMatchTarget();
        /*0x7dfa038*/ void InterruptMatchTarget(bool completeMatch);
        /*0x7dfa0fc*/ bool get_isMatchingTarget();
        /*0x7dfa1b0*/ float get_speed();
        /*0x7dfa264*/ void set_speed(float value);
        /*0x7dfa338*/ void ForceStateNormalizedTime(float normalizedTime);
        /*0x7dfa3e4*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration);
        /*0x7dfa4d8*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer);
        /*0x7dfa520*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x7dfa56c*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x7dfa5c4*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x7dfa5cc*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer);
        /*0x7dfa5d8*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration);
        /*0x7dfa420*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x7dfa664*/ void WriteDefaultValues();
        /*0x7dfa718*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x7dfa7bc*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer);
        /*0x7dfa808*/ void CrossFade(string stateName, float normalizedTransitionDuration);
        /*0x7dfa764*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x7dfa848*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x7dfa97c*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x7dfa984*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer);
        /*0x7dfa994*/ void CrossFade(int stateHashName, float normalizedTransitionDuration);
        /*0x7dfa9a8*/ void PlayInFixedTime(string stateName, int layer);
        /*0x7dfaa20*/ void PlayInFixedTime(string stateName);
        /*0x7dfa9e0*/ void PlayInFixedTime(string stateName, int layer, float fixedTime);
        /*0x7dfaa4c*/ void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
        /*0x7dfab50*/ void PlayInFixedTime(int stateNameHash, int layer);
        /*0x7dfab5c*/ void PlayInFixedTime(int stateNameHash);
        /*0x7dfab6c*/ void Play(string stateName, int layer);
        /*0x7dfabe4*/ void Play(string stateName);
        /*0x7dfaba4*/ void Play(string stateName, int layer, float normalizedTime);
        /*0x7dfa344*/ void Play(int stateNameHash, int layer, float normalizedTime);
        /*0x7dfac74*/ void Play(int stateNameHash, int layer);
        /*0x7dfac80*/ void Play(int stateNameHash);
        /*0x7dfac90*/ void SetTarget(UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        /*0x7dfad74*/ UnityEngine.Vector3 get_targetPosition();
        /*0x7dfae50*/ UnityEngine.Quaternion get_targetRotation();
        /*0x7dfaf28*/ bool IsControlled(UnityEngine.Transform transform);
        /*0x7dfaf30*/ bool IsBoneTransform(UnityEngine.Transform transform);
        /*0x7dfb028*/ UnityEngine.Transform get_avatarRoot();
        /*0x7dfb0f8*/ UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId);
        /*0x7dfb470*/ UnityEngine.Transform GetBoneTransformInternal(int humanBoneId);
        /*0x7dfb558*/ UnityEngine.AnimatorCullingMode get_cullingMode();
        /*0x7dfb60c*/ void set_cullingMode(UnityEngine.AnimatorCullingMode value);
        /*0x7dfb6d0*/ void StartPlayback();
        /*0x7dfb784*/ void StopPlayback();
        /*0x7dfb838*/ float get_playbackTime();
        /*0x7dfb8ec*/ void set_playbackTime(float value);
        /*0x7dfb9c0*/ void StartRecording(int frameCount);
        /*0x7dfba84*/ void StopRecording();
        /*0x7dfbb38*/ float get_recorderStartTime();
        /*0x7dfbbb4*/ void set_recorderStartTime(float value);
        /*0x7dfbb3c*/ float GetRecorderStartTime();
        /*0x7dfbbf4*/ float get_recorderStopTime();
        /*0x7dfbc70*/ void set_recorderStopTime(float value);
        /*0x7dfbbf8*/ float GetRecorderStopTime();
        /*0x7dfbcb0*/ UnityEngine.AnimatorRecorderMode get_recorderMode();
        /*0x7dfbd64*/ UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController();
        /*0x7dfbe34*/ void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value);
        /*0x7dfbf2c*/ bool get_hasBoundPlayables();
        /*0x7dfbfe0*/ void ClearInternalControllerPlayable();
        /*0x7dfc094*/ bool HasState(int layerIndex, int stateID);
        /*0x7dfb2ec*/ UnityEngine.Avatar get_avatar();
        /*0x7dfc1f0*/ void set_avatar(UnityEngine.Avatar value);
        /*0x7dfc2e8*/ string GetStats();
        /*0x7dfc428*/ UnityEngine.Playables.PlayableGraph get_playableGraph();
        /*0x7dfc44c*/ void GetCurrentGraph(ref UnityEngine.Playables.PlayableGraph graph);
        /*0x7df6f10*/ void CheckIfInIKPass();
        /*0x7dfc588*/ bool IsInIKPass();
        /*0x7df4b3c*/ void SetFloatString(string name, float value);
        /*0x7df4ebc*/ void SetFloatID(int id, float value);
        /*0x7df4910*/ float GetFloatString(string name);
        /*0x7df4ab8*/ float GetFloatID(int id);
        /*0x7df5234*/ void SetBoolString(string name, bool value);
        /*0x7df53ec*/ void SetBoolID(int id, bool value);
        /*0x7df4ffc*/ bool GetBoolString(string name);
        /*0x7df51ac*/ bool GetBoolID(int id);
        /*0x7df56b0*/ void SetIntegerString(string name, int value);
        /*0x7df5864*/ void SetIntegerID(int id, int value);
        /*0x7df5480*/ int GetIntegerString(string name);
        /*0x7df562c*/ int GetIntegerID(int id);
        /*0x7df58f8*/ void SetTriggerString(string name);
        /*0x7df5a98*/ void SetTriggerID(int id);
        /*0x7df5b1c*/ void ResetTriggerString(string name);
        /*0x7df5cbc*/ void ResetTriggerID(int id);
        /*0x7df5d40*/ bool IsParameterControlledByCurveString(string name);
        /*0x7df5ef0*/ bool IsParameterControlledByCurveID(int id);
        /*0x7df4cf0*/ void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);
        /*0x7df4f50*/ void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);
        /*0x7dfcc3c*/ bool get_layersAffectMassCenter();
        /*0x7dfccf0*/ void set_layersAffectMassCenter(bool value);
        /*0x7dfcdb4*/ float get_leftFeetBottomHeight();
        /*0x7dfce68*/ float get_rightFeetBottomHeight();
        /*0x7dfcf1c*/ bool get_supportsOnAnimatorMove();
        /*0x7dfcfd0*/ void OnUpdateModeChanged();
        /*0x7dfd084*/ void OnCullingModeChanged();
        /*0x7dfd138*/ void WriteDefaultPose();
        /*0x7dfd1ec*/ void Update(float deltaTime);
        /*0x7dfd2c0*/ void Rebind();
        /*0x7dfd2c8*/ void Rebind(bool writeDefaultValues);
        /*0x7dfd38c*/ void ApplyBuiltinRootMotion();
        /*0x7dfd440*/ void EvaluateController();
        /*0x7dfd448*/ void EvaluateController(float deltaTime);
        /*0x7dfd51c*/ string GetCurrentStateName(int layerIndex);
        /*0x7dfd63c*/ string GetNextStateName(int layerIndex);
        /*0x7dfd524*/ string GetAnimatorStateName(int layerIndex, bool current);
        /*0x7dfd6a0*/ string ResolveHash(int hash);
        /*0x7dfc510*/ bool get_logWarnings();
        /*0x7dfd838*/ void set_logWarnings(bool value);
        /*0x7dfd8fc*/ bool get_fireEvents();
        /*0x7dfd9b0*/ void set_fireEvents(bool value);
        /*0x7dfda74*/ bool get_keepAnimatorControllerStateOnDisable();
        /*0x7dfdaf0*/ void set_keepAnimatorControllerStateOnDisable(bool value);
        /*0x7dfda78*/ bool get_keepAnimatorStateOnDisable();
        /*0x7dfdaf8*/ void set_keepAnimatorStateOnDisable(bool value);
        /*0x7dfdbf8*/ bool get_writeDefaultValuesOnDisable();
        /*0x7dfdcac*/ void set_writeDefaultValuesOnDisable(bool value);
        /*0x7dfdd70*/ UnityEngine.Vector3 GetVector(string name);
        /*0x7dfddb4*/ UnityEngine.Vector3 GetVector(int id);
        /*0x7dfddf8*/ void SetVector(string name, UnityEngine.Vector3 value);
        /*0x7dfddfc*/ void SetVector(int id, UnityEngine.Vector3 value);
        /*0x7dfde00*/ UnityEngine.Quaternion GetQuaternion(string name);
        /*0x7dfde44*/ UnityEngine.Quaternion GetQuaternion(int id);
        /*0x7dfde88*/ void SetQuaternion(string name, UnityEngine.Quaternion value);
        /*0x7dfde8c*/ void SetQuaternion(int id, UnityEngine.Quaternion value);
    }

    class AnimatorControllerParameter
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.AnimatorControllerParameterType m_Type;
        /*0x1c*/ float m_DefaultFloat;
        /*0x20*/ int m_DefaultInt;
        /*0x24*/ bool m_DefaultBool;

        /*0x7dfdfa4*/ AnimatorControllerParameter();
        /*0x7dfde98*/ string get_name();
        /*0x7dfdea0*/ UnityEngine.AnimatorControllerParameterType get_type();
        /*0x7dfdea8*/ bool Equals(object o);
        /*0x7dfdf84*/ int GetHashCode();
    }

    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x7dfdffc*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0x7dfe02c*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x7dfe0c8*/ void Invoke();
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
        static /*0x7dfe0dc*/ bool get_isValid_Injected(nint _unity_self);
        static /*0x7dfe118*/ bool get_isHuman_Injected(nint _unity_self);
        static /*0x7dfe1fc*/ void get_humanDescription_Injected(nint _unity_self, ref UnityEngine.HumanDescription ret);
        /*0x7dfb380*/ bool get_isValid();
        /*0x7dfb3f8*/ bool get_isHuman();
        /*0x7dfe154*/ UnityEngine.HumanDescription get_humanDescription();
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
        static /*0x7dfe2c0*/ void Internal_Create(UnityEngine.AvatarMask self);
        static /*0x7dfe37c*/ bool GetHumanoidBodyPartActive_Injected(nint _unity_self, UnityEngine.AvatarMaskBodyPart index);
        static /*0x7dfe438*/ int get_transformCount_Injected(nint _unity_self);
        static /*0x7dfe57c*/ void GetTransformPath_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfe650*/ float GetTransformWeight_Injected(nint _unity_self, int index);
        /*0x7dfe240*/ AvatarMask();
        /*0x7dfe2fc*/ bool GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index);
        /*0x7dfe3c0*/ int get_transformCount();
        /*0x7dfe474*/ string GetTransformPath(int index);
        /*0x7dfe5d0*/ float GetTransformWeight(int index);
        /*0x7dfe694*/ bool GetTransformActive(int index);
    }

    class HumanTrait
    {
        static /*0x7df84e8*/ int GetBoneIndexFromMono(int humanId);
    }

    class Motion : UnityEngine.Object
    {
        /*0x18*/ bool <isAnimatorMotion>k__BackingField;

        static /*0x7dfe728*/ bool get_isLooping_Injected(nint _unity_self);
        /*0x7df27bc*/ Motion();
        /*0x7dfe6b0*/ bool get_isLooping();
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
        static /*0x7dfe834*/ UnityEngine.AnimationClip[] get_animationClips_Injected(nint _unity_self);
        /*0x7dfe764*/ RuntimeAnimatorController();
        /*0x7dfe7bc*/ UnityEngine.AnimationClip[] get_animationClips();
    }

    namespace Animations
    {
        class AnimationPlayableBinding
        {
            static /*0x7dfe870*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key);
            static /*0x7dfe998*/ UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }

        class DiscreteEvaluationAttribute : System.Attribute
        {
        }

        class NotKeyableAttribute : System.Attribute
        {
        }

        struct AnimationClipPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7dfea68*/ UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x7dfeaa0*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x7dfecf8*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable);
            static /*0x7dfec40*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7dfede4*/ void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7dfee6c*/ void SetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7dfeef4*/ void SetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7dfef7c*/ void SetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7dfefc0*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, nint clip, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7dfeb50*/ AnimationClipPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7dfecec*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7dfed28*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
            /*0x7dfeda0*/ void SetApplyFootIK(bool value);
            /*0x7dfee28*/ void SetRemoveStartOffset(bool value);
            /*0x7dfeeb0*/ void SetOverrideLoopTime(bool value);
            /*0x7dfef38*/ void SetLoopTime(bool value);
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;
        }

        struct AnimationLayerMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7dff830*/ AnimationLayerMixerPlayable();
            static /*0x7dff014*/ UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool singleLayerOptimization);
            static /*0x7dff0bc*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7dff3d4*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable);
            static /*0x7dff2f8*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7dff384*/ void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7dff6e0*/ void SetLayerMaskFromAvatarMaskInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, UnityEngine.AvatarMask mask);
            static /*0x7dff798*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7dff7dc*/ void SetLayerMaskFromAvatarMaskInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, nint mask);
            /*0x7dff1ac*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization);
            /*0x7dff3c8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7dff454*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
            /*0x7dff4f0*/ void SetLayerMaskFromAvatarMask(uint layerIndex, UnityEngine.AvatarMask mask);
        }

        struct AnimationMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7dffd40*/ AnimationMixerPlayable();
            static /*0x7dff8d0*/ UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7dff968*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7dffbe0*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable);
            static /*0x7dffb48*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7dffcfc*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7dffa58*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7dffbd4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7dffc60*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
        }

        struct AnimationMotionXToDeltaPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7e00308*/ AnimationMotionXToDeltaPlayable();
            static /*0x7dffddc*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph);
            static /*0x7dffe6c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph);
            static /*0x7e000e0*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable);
            static /*0x7e00048*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7e00280*/ void SetAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7e002c4*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7dfff58*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e000d4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e00160*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
            /*0x7e001fc*/ void SetAbsoluteMotion(bool value);
        }

        struct AnimationOffsetPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7e0090c*/ AnimationOffsetPlayable();
            static /*0x7e003a4*/ UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x7e00494*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x7e0077c*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable);
            static /*0x7e006cc*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7e008b0*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7e005dc*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e00770*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e007fc*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
        }

        class AnimationPlayableExtensions
        {
            static /*0x3910ae8*/ void SetAnimatedProperties<U>(U playable, UnityEngine.AnimationClip clip);
            static /*0x7e009a8*/ void SetAnimatedPropertiesInternal(ref UnityEngine.Playables.PlayableHandle playable, UnityEngine.AnimationClip animatedProperties);
            static /*0x7e00a3c*/ void SetAnimatedPropertiesInternal_Injected(ref UnityEngine.Playables.PlayableHandle playable, nint animatedProperties);
        }

        class AnimationPlayableGraphExtensions
        {
            static /*0x7e00a80*/ bool InternalCreateAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x7e00c0c*/ bool InternalCreateAnimationOutput_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableOutputHandle handle);
        }

        struct AnimationPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7dfe9d8*/ UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.Animator target);
            static /*0x7e00c60*/ UnityEngine.Animations.AnimationPlayableOutput get_Null();
            static /*0x7dfea38*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output);
            static /*0x7e00ddc*/ UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x7e00e60*/ void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle, UnityEngine.Animator target);
            static /*0x7e00ef4*/ void InternalSetTarget_Injected(ref UnityEngine.Playables.PlayableOutputHandle handle, nint target);
            /*0x7e00cdc*/ AnimationPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7e00dd0*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x7e00dcc*/ void SetTarget(UnityEngine.Animator value);
        }

        struct AnimationPosePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7e010e8*/ AnimationPosePlayable();
            /*0x7e00f38*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e01028*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e01034*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
        }

        struct AnimationRemoveScalePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7e0160c*/ AnimationRemoveScalePlayable();
            static /*0x7e01184*/ UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7e0121c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7e01494*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable);
            static /*0x7e013fc*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7e015c8*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7e0130c*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e01488*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e01514*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimationScriptPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7e01840*/ AnimationScriptPlayable();
            /*0x7e016a8*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e01798*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e017a4*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
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

            static /*0x7e01b64*/ AnimatorControllerPlayable();
            /*0x7e018dc*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e01abc*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e01978*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e01ac8*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
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

        class ScaleConstraint : UnityEngine.Behaviour, UnityEngine.Animations.IConstraint, UnityEngine.Animations.IConstraintInternal
        {
            static /*0x7e01c44*/ void Internal_Create(UnityEngine.Animations.ScaleConstraint self);
            static /*0x7e025d4*/ int GetSourceCountInternal(UnityEngine.Animations.ScaleConstraint self);
            static /*0x7e02800*/ void SetSourcesInternal(UnityEngine.Animations.ScaleConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x7e01cf8*/ float get_weight_Injected(nint _unity_self);
            static /*0x7e01dbc*/ void set_weight_Injected(nint _unity_self, float value);
            static /*0x7e01ea0*/ void get_scaleAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x7e01f74*/ void set_scaleAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x7e02050*/ void get_scaleOffset_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x7e02124*/ void set_scaleOffset_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x7e021e0*/ UnityEngine.Animations.Axis get_scalingAxis_Injected(nint _unity_self);
            static /*0x7e0229c*/ void set_scalingAxis_Injected(nint _unity_self, UnityEngine.Animations.Axis value);
            static /*0x7e02358*/ bool get_constraintActive_Injected(nint _unity_self);
            static /*0x7e02414*/ void set_constraintActive_Injected(nint _unity_self, bool value);
            static /*0x7e024d0*/ bool get_locked_Injected(nint _unity_self);
            static /*0x7e0258c*/ void set_locked_Injected(nint _unity_self, bool value);
            static /*0x7e0267c*/ int GetSourceCountInternal_Injected(nint self);
            static /*0x7e02768*/ void GetSources_Injected(nint _unity_self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x7e028b0*/ void SetSourcesInternal_Injected(nint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x7e02980*/ int AddSource_Injected(nint _unity_self, ref UnityEngine.Animations.ConstraintSource source);
            static /*0x7e02b9c*/ void RemoveSourceInternal_Injected(nint _unity_self, int index);
            static /*0x7e02ca0*/ void GetSourceInternal_Injected(nint _unity_self, int index, ref UnityEngine.Animations.ConstraintSource ret);
            static /*0x7e02dc8*/ void SetSourceInternal_Injected(nint _unity_self, int index, ref UnityEngine.Animations.ConstraintSource source);
            /*0x7e01c00*/ ScaleConstraint();
            /*0x7e01c80*/ float get_weight();
            /*0x7e01d34*/ void set_weight(float value);
            /*0x7e01e08*/ UnityEngine.Vector3 get_scaleAtRest();
            /*0x7e01ee4*/ void set_scaleAtRest(UnityEngine.Vector3 value);
            /*0x7e01fb8*/ UnityEngine.Vector3 get_scaleOffset();
            /*0x7e02094*/ void set_scaleOffset(UnityEngine.Vector3 value);
            /*0x7e02168*/ UnityEngine.Animations.Axis get_scalingAxis();
            /*0x7e0221c*/ void set_scalingAxis(UnityEngine.Animations.Axis value);
            /*0x7e022e0*/ bool get_constraintActive();
            /*0x7e02394*/ void set_constraintActive(bool value);
            /*0x7e02458*/ bool get_locked();
            /*0x7e0250c*/ void set_locked(bool value);
            /*0x7e025d0*/ int get_sourceCount();
            /*0x7e026b8*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x7e027ac*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x7e028f4*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x7e029c4*/ void RemoveSource(int index);
            /*0x7e02b1c*/ void RemoveSourceInternal(int index);
            /*0x7e02be0*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x7e02c08*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x7e02cf4*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x7e02d34*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x7e029ec*/ void ValidateSourceIndex(int index);
        }
    }
}
