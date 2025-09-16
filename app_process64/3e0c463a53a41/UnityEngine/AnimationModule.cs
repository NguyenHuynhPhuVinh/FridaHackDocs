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
        /*0x7dda48c*/ StateMachineBehaviour();
        /*0x7dda454*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7dda458*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7dda45c*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7dda460*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7dda464*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x7dda468*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x7dda46c*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x7dda470*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7dda474*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7dda478*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7dda47c*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7dda480*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7dda484*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x7dda488*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
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
        static /*0x7dda50c*/ void Stop_Injected(nint _unity_self);
        static /*0x7dda5d4*/ bool PlayDefaultAnimation_Injected(nint _unity_self, UnityEngine.PlayMode mode);
        static /*0x7dda740*/ UnityEngine.AnimationState GetStateAtIndex_Injected(nint _unity_self, int index);
        static /*0x7dda7fc*/ int GetStateCount_Injected(nint _unity_self);
        /*0x7dda494*/ void Stop();
        /*0x7dda548*/ bool Play();
        /*0x7dda550*/ bool Play(UnityEngine.PlayMode mode);
        /*0x7dda554*/ bool PlayDefaultAnimation(UnityEngine.PlayMode mode);
        /*0x7dda618*/ System.Collections.IEnumerator GetEnumerator();
        /*0x7dda6c0*/ UnityEngine.AnimationState GetStateAtIndex(int index);
        /*0x7dda784*/ int GetStateCount();

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Animation m_Outer;
            /*0x18*/ int m_CurrentIndex;

            /*0x7dda688*/ Enumerator(UnityEngine.Animation outer);
            /*0x7dda838*/ object get_Current();
            /*0x7dda858*/ bool MoveNext();
            /*0x7dda88c*/ void Reset();
        }
    }

    class AnimationState : UnityEngine.TrackedReference
    {
        /*0x7dda898*/ AnimationState();
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

        static /*0x7dda8a0*/ UnityEngine.AnimationEventBlittable FromAnimationEvent(UnityEngine.AnimationEvent animationEvent);
        static /*0x7ddaa90*/ void FromAnimationEvents(UnityEngine.AnimationEvent[] animationEvents, UnityEngine.AnimationEventBlittable* animationEventBlittables);
        static /*0x7ddac34*/ UnityEngine.AnimationEvent PointerToAnimationEvent(nint animationEventBlittable);
        static /*0x7ddaf04*/ UnityEngine.AnimationEvent[] PointerToAnimationEvents(nint animationEventBlittableArray, int size);
        static /*0x7ddb004*/ void DisposeEvents(nint animationEventBlittableArray, int size);
        static /*0x7ddb174*/ void FreeEventsInternal(nint value);
        static /*0x7ddac68*/ UnityEngine.AnimationEvent ToAnimationEvent(UnityEngine.AnimationEventBlittable animationEventBlittable);
        /*0x7ddb070*/ void Dispose();
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

        /*0x7ddb1b0*/ AnimationEvent();
    }

    class AnimationClip : UnityEngine.Motion
    {
        static /*0x7ddb3e4*/ void Internal_CreateAnimationClip(UnityEngine.AnimationClip self);
        static /*0x7ddb4d4*/ void SampleAnimation(UnityEngine.GameObject go, UnityEngine.AnimationClip clip, float inTime, UnityEngine.WrapMode wrapMode);
        static /*0x7ddb610*/ void SampleAnimation_Injected(nint go, nint clip, float inTime, UnityEngine.WrapMode wrapMode);
        static /*0x7ddb6ec*/ float get_length_Injected(nint _unity_self);
        static /*0x7ddb7a0*/ float get_startTime_Injected(nint _unity_self);
        static /*0x7ddb854*/ float get_stopTime_Injected(nint _unity_self);
        static /*0x7ddb908*/ float get_frameRate_Injected(nint _unity_self);
        static /*0x7ddb9cc*/ void set_frameRate_Injected(nint _unity_self, float value);
        static /*0x7ddbd2c*/ void SetCurve_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper relativePath, System.Type type, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName, nint curve);
        static /*0x7ddbe10*/ void EnsureQuaternionContinuity_Injected(nint _unity_self);
        static /*0x7ddbec4*/ void ClearCurves_Injected(nint _unity_self);
        static /*0x7ddbf00*/ UnityEngine.WrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x7ddbfbc*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.WrapMode value);
        static /*0x7ddc0a4*/ void get_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7ddc168*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x7ddc224*/ bool get_legacy_Injected(nint _unity_self);
        static /*0x7ddc2e0*/ void set_legacy_Injected(nint _unity_self, bool value);
        static /*0x7ddc39c*/ bool get_humanMotion_Injected(nint _unity_self);
        static /*0x7ddc450*/ bool get_empty_Injected(nint _unity_self);
        static /*0x7ddc504*/ bool get_hasGenericRootTransform_Injected(nint _unity_self);
        static /*0x7ddc5b8*/ bool get_hasMotionFloatCurves_Injected(nint _unity_self);
        static /*0x7ddc66c*/ bool get_hasMotionCurves_Injected(nint _unity_self);
        static /*0x7ddc720*/ bool get_hasRootCurves_Injected(nint _unity_self);
        static /*0x7ddc7d4*/ bool get_hasRootMotion_Injected(nint _unity_self);
        static /*0x7ddc984*/ void AddEventInternal_Injected(nint _unity_self, object evt);
        static /*0x7ddcca8*/ void SetEventsInternal_Injected(nint _unity_self, void* data, int length);
        static /*0x7ddccfc*/ void GetEventsInternal_Injected(nint _unity_self, ref nint values, ref int size);
        /*0x7ddb34c*/ AnimationClip();
        /*0x7ddb420*/ void SampleAnimation(UnityEngine.GameObject go, float time);
        /*0x7ddb674*/ float get_length();
        /*0x7ddb728*/ float get_startTime();
        /*0x7ddb7dc*/ float get_stopTime();
        /*0x7ddb890*/ float get_frameRate();
        /*0x7ddb944*/ void set_frameRate(float value);
        /*0x7ddba18*/ void SetCurve(string relativePath, System.Type type, string propertyName, UnityEngine.AnimationCurve curve);
        /*0x7ddbd98*/ void EnsureQuaternionContinuity();
        /*0x7ddbe4c*/ void ClearCurves();
        /*0x7ddb45c*/ UnityEngine.WrapMode get_wrapMode();
        /*0x7ddbf3c*/ void set_wrapMode(UnityEngine.WrapMode value);
        /*0x7ddc000*/ UnityEngine.Bounds get_localBounds();
        /*0x7ddc0e8*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x7ddc1ac*/ bool get_legacy();
        /*0x7ddc260*/ void set_legacy(bool value);
        /*0x7ddc324*/ bool get_humanMotion();
        /*0x7ddc3d8*/ bool get_empty();
        /*0x7ddc48c*/ bool get_hasGenericRootTransform();
        /*0x7ddc540*/ bool get_hasMotionFloatCurves();
        /*0x7ddc5f4*/ bool get_hasMotionCurves();
        /*0x7ddc6a8*/ bool get_hasRootCurves();
        /*0x7ddc75c*/ bool get_hasRootMotion();
        /*0x7ddc810*/ void AddEvent(UnityEngine.AnimationEvent evt);
        /*0x7ddc904*/ void AddEventInternal(object evt);
        /*0x7ddc9c8*/ UnityEngine.AnimationEvent[] get_events();
        /*0x7ddcaa4*/ void set_events(UnityEngine.AnimationEvent[] value);
        /*0x7ddcc18*/ void SetEventsInternal(void* data, int length);
        /*0x7ddca14*/ void GetEventsInternal(ref nint values, ref int size);
    }

    class GCHandlePool
    {
        /*0x10*/ System.Runtime.InteropServices.GCHandle[] m_handles;
        /*0x18*/ int m_current;

        /*0x7ddaa2c*/ GCHandlePool();
        /*0x7ddcd50*/ System.Runtime.InteropServices.GCHandle Alloc(object o);
        /*0x7ddcdec*/ nint AllocHandleIfNotNull(object o);
        /*0x7ddb240*/ void Free(System.Runtime.InteropServices.GCHandle h);
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

        static /*0x7ddce10*/ UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(int instanceID);
        static /*0x7ddce84*/ nint InstanceIDToAnimationClipPPtr_Injected(int instanceID);
        /*0x7ddcdfc*/ UnityEngine.AnimationClip get_clip();
        /*0x7ddce7c*/ float get_weight();
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

        /*0x7ddcec0*/ bool IsName(string name);
        /*0x7ddd074*/ int get_fullPathHash();
        /*0x7ddd07c*/ float get_normalizedTime();
        /*0x7ddd084*/ float get_speed();
        /*0x7ddd08c*/ float get_speedMultiplier();
        /*0x7ddd094*/ bool get_loop();
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
        static /*0x382eaf0*/ T[] ConvertStateMachineBehaviour<T>(UnityEngine.ScriptableObject[] rawObjects);
        static /*0x7ddcf04*/ int StringToHash(string name);
        static /*0x7ddd11c*/ bool get_isOptimizable_Injected(nint _unity_self);
        static /*0x7ddd1d0*/ bool get_isHuman_Injected(nint _unity_self);
        static /*0x7ddd284*/ bool get_hasRootMotion_Injected(nint _unity_self);
        static /*0x7ddd338*/ bool get_isRootPositionOrRotationControlledByCurves_Injected(nint _unity_self);
        static /*0x7ddd3ec*/ float get_humanScale_Injected(nint _unity_self);
        static /*0x7ddd4a0*/ bool get_isInitialized_Injected(nint _unity_self);
        static /*0x7ddebd8*/ void get_deltaPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ddecb0*/ void get_deltaRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7dded8c*/ void get_velocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ddee68*/ void get_angularVelocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ddef44*/ void get_rootPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ddf018*/ void set_rootPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7ddf0f0*/ void get_rootRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7ddf1c4*/ void set_rootRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7ddf280*/ bool get_applyRootMotion_Injected(nint _unity_self);
        static /*0x7ddf33c*/ void set_applyRootMotion_Injected(nint _unity_self, bool value);
        static /*0x7ddf3f8*/ bool get_linearVelocityBlending_Injected(nint _unity_self);
        static /*0x7ddf4b4*/ void set_linearVelocityBlending_Injected(nint _unity_self, bool value);
        static /*0x7ddf570*/ bool get_animatePhysics_Injected(nint _unity_self);
        static /*0x7ddf62c*/ void set_animatePhysics_Injected(nint _unity_self, bool value);
        static /*0x7ddf6e8*/ UnityEngine.AnimatorUpdateMode get_updateMode_Injected(nint _unity_self);
        static /*0x7ddf7a4*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.AnimatorUpdateMode value);
        static /*0x7ddf860*/ bool get_hasTransformHierarchy_Injected(nint _unity_self);
        static /*0x7ddf914*/ bool get_allowConstantClipSamplingOptimization_Injected(nint _unity_self);
        static /*0x7ddf9d0*/ void set_allowConstantClipSamplingOptimization_Injected(nint _unity_self, bool value);
        static /*0x7ddfa8c*/ float get_gravityWeight_Injected(nint _unity_self);
        static /*0x7ddfcd8*/ void get_bodyPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7ddfd1c*/ void set_bodyPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7ddfee4*/ void get_bodyRotationInternal_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7ddff28*/ void set_bodyRotationInternal_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7de0034*/ void GetGoalPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 ret);
        static /*0x7de0170*/ void SetGoalPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Vector3 goalPosition);
        static /*0x7de0288*/ void GetGoalRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion ret);
        static /*0x7de03cc*/ void SetGoalRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, ref UnityEngine.Quaternion goalRotation);
        static /*0x7de04c8*/ float GetGoalWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal);
        static /*0x7de05d4*/ void SetGoalWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, float value);
        static /*0x7de06d0*/ float GetGoalWeightRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal);
        static /*0x7de07dc*/ void SetGoalWeightRotation_Injected(nint _unity_self, UnityEngine.AvatarIKGoal goal, float value);
        static /*0x7de08f8*/ void GetHintPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 ret);
        static /*0x7de0a34*/ void SetHintPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, ref UnityEngine.Vector3 hintPosition);
        static /*0x7de0b30*/ float GetHintWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint);
        static /*0x7de0c3c*/ void SetHintWeightPosition_Injected(nint _unity_self, UnityEngine.AvatarIKHint hint, float value);
        static /*0x7de0d60*/ void SetLookAtPositionInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 lookAtPosition);
        static /*0x7de0fbc*/ void SetLookAtWeightInternal_Injected(nint _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        static /*0x7de118c*/ void SetBoneLocalRotationInternal_Injected(nint _unity_self, int humanBoneId, ref UnityEngine.Quaternion rotation);
        static /*0x7de12b4*/ nint GetBehaviour_Injected(nint _unity_self, System.Type type);
        static /*0x7de13a8*/ UnityEngine.ScriptableObject[] InternalGetBehaviours_Injected(nint _unity_self, System.Type type);
        static /*0x7de1558*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey_Injected(nint _unity_self, int fullPathHash, int layerIndex, System.Type type);
        static /*0x7de162c*/ bool get_stabilizeFeet_Injected(nint _unity_self);
        static /*0x7de16e8*/ void set_stabilizeFeet_Injected(nint _unity_self, bool value);
        static /*0x7de17a4*/ int get_layerCount_Injected(nint _unity_self);
        static /*0x7de18e8*/ void GetLayerName_Injected(nint _unity_self, int layerIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7de1ae4*/ int GetLayerIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
        static /*0x7de1ba8*/ float GetLayerWeight_Injected(nint _unity_self, int layerIndex);
        static /*0x7de1c7c*/ void SetLayerWeight_Injected(nint _unity_self, int layerIndex, float weight);
        static /*0x7de1d68*/ void GetAnimatorStateInfo_Injected(nint _unity_self, int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        static /*0x7de1ed4*/ void GetAnimatorTransitionInfo_Injected(nint _unity_self, int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        static /*0x7de1fe8*/ int GetAnimatorClipInfoCount_Injected(nint _unity_self, int layerIndex, bool current);
        static /*0x7de20cc*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo_Injected(nint _unity_self, int layerIndex);
        static /*0x7de2190*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo_Injected(nint _unity_self, int layerIndex);
        static /*0x7de22c8*/ void GetAnimatorClipInfoInternal_Injected(nint _unity_self, int layerIndex, bool isCurrent, object clips);
        static /*0x7de2400*/ bool IsInTransition_Injected(nint _unity_self, int layerIndex);
        static /*0x7de24bc*/ UnityEngine.AnimatorControllerParameter[] get_parameters_Injected(nint _unity_self);
        static /*0x7de2570*/ int get_parameterCount_Injected(nint _unity_self);
        static /*0x7de262c*/ UnityEngine.AnimatorControllerParameter GetParameterInternal_Injected(nint _unity_self, int index);
        static /*0x7de2788*/ float get_feetPivotActive_Injected(nint _unity_self);
        static /*0x7de284c*/ void set_feetPivotActive_Injected(nint _unity_self, float value);
        static /*0x7de2910*/ float get_pivotWeight_Injected(nint _unity_self);
        static /*0x7de29e4*/ void get_pivotPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7de2b00*/ void MatchTarget_Injected(nint _unity_self, ref UnityEngine.Vector3 matchPosition, ref UnityEngine.Quaternion matchRotation, int targetBodyPart, ref UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        static /*0x7de2c88*/ void InterruptMatchTarget_Injected(nint _unity_self, bool completeMatch);
        static /*0x7de2d44*/ bool get_isMatchingTarget_Injected(nint _unity_self);
        static /*0x7de2df8*/ float get_speed_Injected(nint _unity_self);
        static /*0x7de2ebc*/ void set_speed_Injected(nint _unity_self, float value);
        static /*0x7de31b8*/ void CrossFadeInFixedTime_Injected(nint _unity_self, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        static /*0x7de32ac*/ void WriteDefaultValues_Injected(nint _unity_self);
        static /*0x7de34d0*/ void CrossFade_Injected(nint _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        static /*0x7de36bc*/ void PlayInFixedTime_Injected(nint _unity_self, int stateNameHash, int layer, float fixedTime);
        static /*0x7de37e0*/ void Play_Injected(nint _unity_self, int stateNameHash, int layer, float normalizedTime);
        static /*0x7de38f0*/ void SetTarget_Injected(nint _unity_self, UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        static /*0x7de39dc*/ void get_targetPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7de3ab4*/ void get_targetRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7de3bb4*/ bool IsBoneTransform_Injected(nint _unity_self, nint transform);
        static /*0x7de3c8c*/ nint get_avatarRoot_Injected(nint _unity_self);
        static /*0x7de40e4*/ nint GetBoneTransformInternal_Injected(nint _unity_self, int humanBoneId);
        static /*0x7de41a0*/ UnityEngine.AnimatorCullingMode get_cullingMode_Injected(nint _unity_self);
        static /*0x7de425c*/ void set_cullingMode_Injected(nint _unity_self, UnityEngine.AnimatorCullingMode value);
        static /*0x7de4318*/ void StartPlayback_Injected(nint _unity_self);
        static /*0x7de43cc*/ void StopPlayback_Injected(nint _unity_self);
        static /*0x7de4480*/ float get_playbackTime_Injected(nint _unity_self);
        static /*0x7de4544*/ void set_playbackTime_Injected(nint _unity_self, float value);
        static /*0x7de4610*/ void StartRecording_Injected(nint _unity_self, int frameCount);
        static /*0x7de46cc*/ void StopRecording_Injected(nint _unity_self);
        static /*0x7de4788*/ float GetRecorderStartTime_Injected(nint _unity_self);
        static /*0x7de4844*/ float GetRecorderStopTime_Injected(nint _unity_self);
        static /*0x7de48f8*/ UnityEngine.AnimatorRecorderMode get_recorderMode_Injected(nint _unity_self);
        static /*0x7de49c8*/ nint get_runtimeAnimatorController_Injected(nint _unity_self);
        static /*0x7de4ab8*/ void set_runtimeAnimatorController_Injected(nint _unity_self, nint value);
        static /*0x7de4b74*/ bool get_hasBoundPlayables_Injected(nint _unity_self);
        static /*0x7de4c28*/ void ClearInternalControllerPlayable_Injected(nint _unity_self);
        static /*0x7de4cf4*/ bool HasState_Injected(nint _unity_self, int layerIndex, int stateID);
        static /*0x7de4d48*/ int StringToHash_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de4d84*/ nint get_avatar_Injected(nint _unity_self);
        static /*0x7de4e74*/ void set_avatar_Injected(nint _unity_self, nint value);
        static /*0x7de4fb4*/ void GetStats_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7de509c*/ void GetCurrentGraph_Injected(nint _unity_self, ref UnityEngine.Playables.PlayableGraph graph);
        static /*0x7de51d0*/ bool IsInIKPass_Injected(nint _unity_self);
        static /*0x7de520c*/ void SetFloatString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value);
        static /*0x7de5260*/ void SetFloatID_Injected(nint _unity_self, int id, float value);
        static /*0x7de52b4*/ float GetFloatString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de52f8*/ float GetFloatID_Injected(nint _unity_self, int id);
        static /*0x7de533c*/ void SetBoolString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, bool value);
        static /*0x7de5390*/ void SetBoolID_Injected(nint _unity_self, int id, bool value);
        static /*0x7de53e4*/ bool GetBoolString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de5428*/ bool GetBoolID_Injected(nint _unity_self, int id);
        static /*0x7de546c*/ void SetIntegerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, int value);
        static /*0x7de54c0*/ void SetIntegerID_Injected(nint _unity_self, int id, int value);
        static /*0x7de5514*/ int GetIntegerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de5558*/ int GetIntegerID_Injected(nint _unity_self, int id);
        static /*0x7de559c*/ void SetTriggerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de55e0*/ void SetTriggerID_Injected(nint _unity_self, int id);
        static /*0x7de5624*/ void ResetTriggerString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de5668*/ void ResetTriggerID_Injected(nint _unity_self, int id);
        static /*0x7de56ac*/ bool IsParameterControlledByCurveString_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7de56f0*/ bool IsParameterControlledByCurveID_Injected(nint _unity_self, int id);
        static /*0x7de5734*/ void SetFloatStringDamp_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, float value, float dampTime, float deltaTime);
        static /*0x7de57a0*/ void SetFloatIDDamp_Injected(nint _unity_self, int id, float value, float dampTime, float deltaTime);
        static /*0x7de5884*/ bool get_layersAffectMassCenter_Injected(nint _unity_self);
        static /*0x7de5940*/ void set_layersAffectMassCenter_Injected(nint _unity_self, bool value);
        static /*0x7de59fc*/ float get_leftFeetBottomHeight_Injected(nint _unity_self);
        static /*0x7de5ab0*/ float get_rightFeetBottomHeight_Injected(nint _unity_self);
        static /*0x7de5b64*/ bool get_supportsOnAnimatorMove_Injected(nint _unity_self);
        static /*0x7de5c18*/ void OnUpdateModeChanged_Injected(nint _unity_self);
        static /*0x7de5ccc*/ void OnCullingModeChanged_Injected(nint _unity_self);
        static /*0x7de5d80*/ void WriteDefaultPose_Injected(nint _unity_self);
        static /*0x7de5e44*/ void Update_Injected(nint _unity_self, float deltaTime);
        static /*0x7de5f18*/ void Rebind_Injected(nint _unity_self, bool writeDefaultValues);
        static /*0x7de5fd4*/ void ApplyBuiltinRootMotion_Injected(nint _unity_self);
        static /*0x7de60a0*/ void EvaluateController_Injected(nint _unity_self, float deltaTime);
        static /*0x7de6214*/ void GetAnimatorStateName_Injected(nint _unity_self, int layerIndex, bool current, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7de6378*/ void ResolveHash_Injected(nint _unity_self, int hash, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7de63cc*/ bool get_logWarnings_Injected(nint _unity_self);
        static /*0x7de6488*/ void set_logWarnings_Injected(nint _unity_self, bool value);
        static /*0x7de6544*/ bool get_fireEvents_Injected(nint _unity_self);
        static /*0x7de6600*/ void set_fireEvents_Injected(nint _unity_self, bool value);
        static /*0x7de6748*/ bool get_keepAnimatorStateOnDisable_Injected(nint _unity_self);
        static /*0x7de6784*/ void set_keepAnimatorStateOnDisable_Injected(nint _unity_self, bool value);
        static /*0x7de6840*/ bool get_writeDefaultValuesOnDisable_Injected(nint _unity_self);
        static /*0x7de68fc*/ void set_writeDefaultValuesOnDisable_Injected(nint _unity_self, bool value);
        /*0x7de6a60*/ Animator();
        /*0x7ddd0a4*/ bool get_isOptimizable();
        /*0x7ddd158*/ bool get_isHuman();
        /*0x7ddd20c*/ bool get_hasRootMotion();
        /*0x7ddd2c0*/ bool get_isRootPositionOrRotationControlledByCurves();
        /*0x7ddd374*/ float get_humanScale();
        /*0x7ddd428*/ bool get_isInitialized();
        /*0x7ddd4dc*/ float GetFloat(string name);
        /*0x7ddd684*/ float GetFloat(int id);
        /*0x7ddd708*/ void SetFloat(string name, float value);
        /*0x7ddd8bc*/ void SetFloat(string name, float value, float dampTime, float deltaTime);
        /*0x7ddda88*/ void SetFloat(int id, float value);
        /*0x7dddb1c*/ void SetFloat(int id, float value, float dampTime, float deltaTime);
        /*0x7dddbc8*/ bool GetBool(string name);
        /*0x7dddd78*/ bool GetBool(int id);
        /*0x7ddddfc*/ void SetBool(string name, bool value);
        /*0x7dddfb4*/ void SetBool(int id, bool value);
        /*0x7dde04c*/ int GetInteger(string name);
        /*0x7dde1f8*/ int GetInteger(int id);
        /*0x7dde27c*/ void SetInteger(string name, int value);
        /*0x7dde430*/ void SetInteger(int id, int value);
        /*0x7dde4c4*/ void SetTrigger(string name);
        /*0x7dde664*/ void SetTrigger(int id);
        /*0x7dde6e8*/ void ResetTrigger(string name);
        /*0x7dde888*/ void ResetTrigger(int id);
        /*0x7dde90c*/ bool IsParameterControlledByCurve(string name);
        /*0x7ddeabc*/ bool IsParameterControlledByCurve(int id);
        /*0x7ddeb40*/ UnityEngine.Vector3 get_deltaPosition();
        /*0x7ddec1c*/ UnityEngine.Quaternion get_deltaRotation();
        /*0x7ddecf4*/ UnityEngine.Vector3 get_velocity();
        /*0x7ddedd0*/ UnityEngine.Vector3 get_angularVelocity();
        /*0x7ddeeac*/ UnityEngine.Vector3 get_rootPosition();
        /*0x7ddef88*/ void set_rootPosition(UnityEngine.Vector3 value);
        /*0x7ddf05c*/ UnityEngine.Quaternion get_rootRotation();
        /*0x7ddf134*/ void set_rootRotation(UnityEngine.Quaternion value);
        /*0x7ddf208*/ bool get_applyRootMotion();
        /*0x7ddf2bc*/ void set_applyRootMotion(bool value);
        /*0x7ddf380*/ bool get_linearVelocityBlending();
        /*0x7ddf434*/ void set_linearVelocityBlending(bool value);
        /*0x7ddf4f8*/ bool get_animatePhysics();
        /*0x7ddf5ac*/ void set_animatePhysics(bool value);
        /*0x7ddf670*/ UnityEngine.AnimatorUpdateMode get_updateMode();
        /*0x7ddf724*/ void set_updateMode(UnityEngine.AnimatorUpdateMode value);
        /*0x7ddf7e8*/ bool get_hasTransformHierarchy();
        /*0x7ddf89c*/ bool get_allowConstantClipSamplingOptimization();
        /*0x7ddf950*/ void set_allowConstantClipSamplingOptimization(bool value);
        /*0x7ddfa14*/ float get_gravityWeight();
        /*0x7ddfac8*/ UnityEngine.Vector3 get_bodyPosition();
        /*0x7ddfc08*/ void set_bodyPosition(UnityEngine.Vector3 value);
        /*0x7ddfb70*/ UnityEngine.Vector3 get_bodyPositionInternal();
        /*0x7ddfc48*/ void set_bodyPositionInternal(UnityEngine.Vector3 value);
        /*0x7ddfd60*/ UnityEngine.Quaternion get_bodyRotation();
        /*0x7ddfe0c*/ void set_bodyRotation(UnityEngine.Quaternion value);
        /*0x7ddfd78*/ UnityEngine.Quaternion get_bodyRotationInternal();
        /*0x7ddfe54*/ void set_bodyRotationInternal(UnityEngine.Quaternion value);
        /*0x7ddff6c*/ UnityEngine.Vector3 GetIKPosition(UnityEngine.AvatarIKGoal goal);
        /*0x7ddff94*/ UnityEngine.Vector3 GetGoalPosition(UnityEngine.AvatarIKGoal goal);
        /*0x7de0088*/ void SetIKPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x7de00d8*/ void SetGoalPosition(UnityEngine.AvatarIKGoal goal, UnityEngine.Vector3 goalPosition);
        /*0x7de01c4*/ UnityEngine.Quaternion GetIKRotation(UnityEngine.AvatarIKGoal goal);
        /*0x7de01ec*/ UnityEngine.Quaternion GetGoalRotation(UnityEngine.AvatarIKGoal goal);
        /*0x7de02dc*/ void SetIKRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x7de0334*/ void SetGoalRotation(UnityEngine.AvatarIKGoal goal, UnityEngine.Quaternion goalRotation);
        /*0x7de0420*/ float GetIKPositionWeight(UnityEngine.AvatarIKGoal goal);
        /*0x7de0448*/ float GetGoalWeightPosition(UnityEngine.AvatarIKGoal goal);
        /*0x7de050c*/ void SetIKPositionWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7de0544*/ void SetGoalWeightPosition(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7de0628*/ float GetIKRotationWeight(UnityEngine.AvatarIKGoal goal);
        /*0x7de0650*/ float GetGoalWeightRotation(UnityEngine.AvatarIKGoal goal);
        /*0x7de0714*/ void SetIKRotationWeight(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7de074c*/ void SetGoalWeightRotation(UnityEngine.AvatarIKGoal goal, float value);
        /*0x7de0830*/ UnityEngine.Vector3 GetIKHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x7de0858*/ UnityEngine.Vector3 GetHintPosition(UnityEngine.AvatarIKHint hint);
        /*0x7de094c*/ void SetIKHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x7de099c*/ void SetHintPosition(UnityEngine.AvatarIKHint hint, UnityEngine.Vector3 hintPosition);
        /*0x7de0a88*/ float GetIKHintPositionWeight(UnityEngine.AvatarIKHint hint);
        /*0x7de0ab0*/ float GetHintWeightPosition(UnityEngine.AvatarIKHint hint);
        /*0x7de0b74*/ void SetIKHintPositionWeight(UnityEngine.AvatarIKHint hint, float value);
        /*0x7de0bac*/ void SetHintWeightPosition(UnityEngine.AvatarIKHint hint, float value);
        /*0x7de0c90*/ void SetLookAtPosition(UnityEngine.Vector3 lookAtPosition);
        /*0x7de0cd0*/ void SetLookAtPositionInternal(UnityEngine.Vector3 lookAtPosition);
        /*0x7de0da4*/ void SetLookAtWeight(float weight);
        /*0x7de0e94*/ void SetLookAtWeight(float weight, float bodyWeight);
        /*0x7de0ed0*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight);
        /*0x7de0f18*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight);
        /*0x7de0f64*/ void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x7de0ddc*/ void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight);
        /*0x7de1038*/ void SetBoneLocalRotation(UnityEngine.HumanBodyBones humanBoneId, UnityEngine.Quaternion rotation);
        /*0x7de10f4*/ void SetBoneLocalRotationInternal(int humanBoneId, UnityEngine.Quaternion rotation);
        /*0x7de11e0*/ UnityEngine.ScriptableObject GetBehaviour(System.Type type);
        /*0x3907c14*/ T GetBehaviour<T>();
        /*0x380b9e8*/ T[] GetBehaviours<T>();
        /*0x7de12f8*/ UnityEngine.ScriptableObject[] InternalGetBehaviours(System.Type type);
        /*0x7de13ec*/ UnityEngine.StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex);
        /*0x7de1490*/ UnityEngine.ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, System.Type type);
        /*0x7de15b4*/ bool get_stabilizeFeet();
        /*0x7de1668*/ void set_stabilizeFeet(bool value);
        /*0x7de172c*/ int get_layerCount();
        /*0x7de17e0*/ string GetLayerName(int layerIndex);
        /*0x7de193c*/ int GetLayerIndex(string layerName);
        /*0x7de1b28*/ float GetLayerWeight(int layerIndex);
        /*0x7de1bec*/ void SetLayerWeight(int layerIndex, float weight);
        /*0x7de1cd0*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x7de1dc4*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x7de1e04*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        /*0x7de1e44*/ void GetAnimatorTransitionInfo(int layerIndex, ref UnityEngine.AnimatorTransitionInfo info);
        /*0x7de1f28*/ UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
        /*0x7de1f58*/ int GetAnimatorClipInfoCount(int layerIndex, bool current);
        /*0x7de203c*/ int GetCurrentAnimatorClipInfoCount(int layerIndex);
        /*0x7de2044*/ int GetNextAnimatorClipInfoCount(int layerIndex);
        /*0x7de204c*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        /*0x7de2110*/ UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
        /*0x7de21d4*/ void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x7de2230*/ void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);
        /*0x7de2324*/ void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x7de2380*/ bool IsInTransition(int layerIndex);
        /*0x7de2444*/ UnityEngine.AnimatorControllerParameter[] get_parameters();
        /*0x7de24f8*/ int get_parameterCount();
        /*0x7de25ac*/ UnityEngine.AnimatorControllerParameter GetParameterInternal(int index);
        /*0x7de2670*/ UnityEngine.AnimatorControllerParameter GetParameter(int index);
        /*0x7de2710*/ float get_feetPivotActive();
        /*0x7de27c4*/ void set_feetPivotActive(float value);
        /*0x7de2898*/ float get_pivotWeight();
        /*0x7de294c*/ UnityEngine.Vector3 get_pivotPosition();
        /*0x7de2a28*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, int targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x7de2b8c*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime);
        /*0x7de2bc0*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime);
        /*0x7de2be0*/ void MatchTarget(UnityEngine.Vector3 matchPosition, UnityEngine.Quaternion matchRotation, UnityEngine.AvatarTarget targetBodyPart, UnityEngine.MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch);
        /*0x7de2c00*/ void InterruptMatchTarget();
        /*0x7de2c08*/ void InterruptMatchTarget(bool completeMatch);
        /*0x7de2ccc*/ bool get_isMatchingTarget();
        /*0x7de2d80*/ float get_speed();
        /*0x7de2e34*/ void set_speed(float value);
        /*0x7de2f08*/ void ForceStateNormalizedTime(float normalizedTime);
        /*0x7de2fb4*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration);
        /*0x7de30a8*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer);
        /*0x7de30f0*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x7de313c*/ void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x7de3194*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset);
        /*0x7de319c*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer);
        /*0x7de31a8*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration);
        /*0x7de2ff0*/ void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime);
        /*0x7de3234*/ void WriteDefaultValues();
        /*0x7de32e8*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x7de338c*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer);
        /*0x7de33d8*/ void CrossFade(string stateName, float normalizedTransitionDuration);
        /*0x7de3334*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x7de3418*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x7de354c*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset);
        /*0x7de3554*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer);
        /*0x7de3564*/ void CrossFade(int stateHashName, float normalizedTransitionDuration);
        /*0x7de3578*/ void PlayInFixedTime(string stateName, int layer);
        /*0x7de35f0*/ void PlayInFixedTime(string stateName);
        /*0x7de35b0*/ void PlayInFixedTime(string stateName, int layer, float fixedTime);
        /*0x7de361c*/ void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
        /*0x7de3720*/ void PlayInFixedTime(int stateNameHash, int layer);
        /*0x7de372c*/ void PlayInFixedTime(int stateNameHash);
        /*0x7de373c*/ void Play(string stateName, int layer);
        /*0x7de37b4*/ void Play(string stateName);
        /*0x7de3774*/ void Play(string stateName, int layer, float normalizedTime);
        /*0x7de2f14*/ void Play(int stateNameHash, int layer, float normalizedTime);
        /*0x7de3844*/ void Play(int stateNameHash, int layer);
        /*0x7de3850*/ void Play(int stateNameHash);
        /*0x7de3860*/ void SetTarget(UnityEngine.AvatarTarget targetIndex, float targetNormalizedTime);
        /*0x7de3944*/ UnityEngine.Vector3 get_targetPosition();
        /*0x7de3a20*/ UnityEngine.Quaternion get_targetRotation();
        /*0x7de3af8*/ bool IsControlled(UnityEngine.Transform transform);
        /*0x7de3b00*/ bool IsBoneTransform(UnityEngine.Transform transform);
        /*0x7de3bf8*/ UnityEngine.Transform get_avatarRoot();
        /*0x7de3cc8*/ UnityEngine.Transform GetBoneTransform(UnityEngine.HumanBodyBones humanBoneId);
        /*0x7de4040*/ UnityEngine.Transform GetBoneTransformInternal(int humanBoneId);
        /*0x7de4128*/ UnityEngine.AnimatorCullingMode get_cullingMode();
        /*0x7de41dc*/ void set_cullingMode(UnityEngine.AnimatorCullingMode value);
        /*0x7de42a0*/ void StartPlayback();
        /*0x7de4354*/ void StopPlayback();
        /*0x7de4408*/ float get_playbackTime();
        /*0x7de44bc*/ void set_playbackTime(float value);
        /*0x7de4590*/ void StartRecording(int frameCount);
        /*0x7de4654*/ void StopRecording();
        /*0x7de4708*/ float get_recorderStartTime();
        /*0x7de4784*/ void set_recorderStartTime(float value);
        /*0x7de470c*/ float GetRecorderStartTime();
        /*0x7de47c4*/ float get_recorderStopTime();
        /*0x7de4840*/ void set_recorderStopTime(float value);
        /*0x7de47c8*/ float GetRecorderStopTime();
        /*0x7de4880*/ UnityEngine.AnimatorRecorderMode get_recorderMode();
        /*0x7de4934*/ UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController();
        /*0x7de4a04*/ void set_runtimeAnimatorController(UnityEngine.RuntimeAnimatorController value);
        /*0x7de4afc*/ bool get_hasBoundPlayables();
        /*0x7de4bb0*/ void ClearInternalControllerPlayable();
        /*0x7de4c64*/ bool HasState(int layerIndex, int stateID);
        /*0x7de3ebc*/ UnityEngine.Avatar get_avatar();
        /*0x7de4dc0*/ void set_avatar(UnityEngine.Avatar value);
        /*0x7de4eb8*/ string GetStats();
        /*0x7de4ff8*/ UnityEngine.Playables.PlayableGraph get_playableGraph();
        /*0x7de501c*/ void GetCurrentGraph(ref UnityEngine.Playables.PlayableGraph graph);
        /*0x7ddfae0*/ void CheckIfInIKPass();
        /*0x7de5158*/ bool IsInIKPass();
        /*0x7ddd70c*/ void SetFloatString(string name, float value);
        /*0x7ddda8c*/ void SetFloatID(int id, float value);
        /*0x7ddd4e0*/ float GetFloatString(string name);
        /*0x7ddd688*/ float GetFloatID(int id);
        /*0x7ddde04*/ void SetBoolString(string name, bool value);
        /*0x7dddfbc*/ void SetBoolID(int id, bool value);
        /*0x7dddbcc*/ bool GetBoolString(string name);
        /*0x7dddd7c*/ bool GetBoolID(int id);
        /*0x7dde280*/ void SetIntegerString(string name, int value);
        /*0x7dde434*/ void SetIntegerID(int id, int value);
        /*0x7dde050*/ int GetIntegerString(string name);
        /*0x7dde1fc*/ int GetIntegerID(int id);
        /*0x7dde4c8*/ void SetTriggerString(string name);
        /*0x7dde668*/ void SetTriggerID(int id);
        /*0x7dde6ec*/ void ResetTriggerString(string name);
        /*0x7dde88c*/ void ResetTriggerID(int id);
        /*0x7dde910*/ bool IsParameterControlledByCurveString(string name);
        /*0x7ddeac0*/ bool IsParameterControlledByCurveID(int id);
        /*0x7ddd8c0*/ void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime);
        /*0x7dddb20*/ void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime);
        /*0x7de580c*/ bool get_layersAffectMassCenter();
        /*0x7de58c0*/ void set_layersAffectMassCenter(bool value);
        /*0x7de5984*/ float get_leftFeetBottomHeight();
        /*0x7de5a38*/ float get_rightFeetBottomHeight();
        /*0x7de5aec*/ bool get_supportsOnAnimatorMove();
        /*0x7de5ba0*/ void OnUpdateModeChanged();
        /*0x7de5c54*/ void OnCullingModeChanged();
        /*0x7de5d08*/ void WriteDefaultPose();
        /*0x7de5dbc*/ void Update(float deltaTime);
        /*0x7de5e90*/ void Rebind();
        /*0x7de5e98*/ void Rebind(bool writeDefaultValues);
        /*0x7de5f5c*/ void ApplyBuiltinRootMotion();
        /*0x7de6010*/ void EvaluateController();
        /*0x7de6018*/ void EvaluateController(float deltaTime);
        /*0x7de60ec*/ string GetCurrentStateName(int layerIndex);
        /*0x7de620c*/ string GetNextStateName(int layerIndex);
        /*0x7de60f4*/ string GetAnimatorStateName(int layerIndex, bool current);
        /*0x7de6270*/ string ResolveHash(int hash);
        /*0x7de50e0*/ bool get_logWarnings();
        /*0x7de6408*/ void set_logWarnings(bool value);
        /*0x7de64cc*/ bool get_fireEvents();
        /*0x7de6580*/ void set_fireEvents(bool value);
        /*0x7de6644*/ bool get_keepAnimatorControllerStateOnDisable();
        /*0x7de66c0*/ void set_keepAnimatorControllerStateOnDisable(bool value);
        /*0x7de6648*/ bool get_keepAnimatorStateOnDisable();
        /*0x7de66c8*/ void set_keepAnimatorStateOnDisable(bool value);
        /*0x7de67c8*/ bool get_writeDefaultValuesOnDisable();
        /*0x7de687c*/ void set_writeDefaultValuesOnDisable(bool value);
        /*0x7de6940*/ UnityEngine.Vector3 GetVector(string name);
        /*0x7de6984*/ UnityEngine.Vector3 GetVector(int id);
        /*0x7de69c8*/ void SetVector(string name, UnityEngine.Vector3 value);
        /*0x7de69cc*/ void SetVector(int id, UnityEngine.Vector3 value);
        /*0x7de69d0*/ UnityEngine.Quaternion GetQuaternion(string name);
        /*0x7de6a14*/ UnityEngine.Quaternion GetQuaternion(int id);
        /*0x7de6a58*/ void SetQuaternion(string name, UnityEngine.Quaternion value);
        /*0x7de6a5c*/ void SetQuaternion(int id, UnityEngine.Quaternion value);
    }

    class AnimatorControllerParameter
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.AnimatorControllerParameterType m_Type;
        /*0x1c*/ float m_DefaultFloat;
        /*0x20*/ int m_DefaultInt;
        /*0x24*/ bool m_DefaultBool;

        /*0x7de6b74*/ AnimatorControllerParameter();
        /*0x7de6a68*/ string get_name();
        /*0x7de6a70*/ UnityEngine.AnimatorControllerParameterType get_type();
        /*0x7de6a78*/ bool Equals(object o);
        /*0x7de6b54*/ int GetHashCode();
    }

    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x7de6bcc*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0x7de6bfc*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x7de6c98*/ void Invoke();
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
        static /*0x7de6cac*/ bool get_isValid_Injected(nint _unity_self);
        static /*0x7de6ce8*/ bool get_isHuman_Injected(nint _unity_self);
        static /*0x7de6dcc*/ void get_humanDescription_Injected(nint _unity_self, ref UnityEngine.HumanDescription ret);
        /*0x7de3f50*/ bool get_isValid();
        /*0x7de3fc8*/ bool get_isHuman();
        /*0x7de6d24*/ UnityEngine.HumanDescription get_humanDescription();
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
        static /*0x7de6e90*/ void Internal_Create(UnityEngine.AvatarMask self);
        static /*0x7de6f4c*/ bool GetHumanoidBodyPartActive_Injected(nint _unity_self, UnityEngine.AvatarMaskBodyPart index);
        static /*0x7de7008*/ int get_transformCount_Injected(nint _unity_self);
        static /*0x7de714c*/ void GetTransformPath_Injected(nint _unity_self, int index, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7de7220*/ float GetTransformWeight_Injected(nint _unity_self, int index);
        /*0x7de6e10*/ AvatarMask();
        /*0x7de6ecc*/ bool GetHumanoidBodyPartActive(UnityEngine.AvatarMaskBodyPart index);
        /*0x7de6f90*/ int get_transformCount();
        /*0x7de7044*/ string GetTransformPath(int index);
        /*0x7de71a0*/ float GetTransformWeight(int index);
        /*0x7de7264*/ bool GetTransformActive(int index);
    }

    class HumanTrait
    {
        static /*0x7de10b8*/ int GetBoneIndexFromMono(int humanId);
    }

    class Motion : UnityEngine.Object
    {
        /*0x18*/ bool <isAnimatorMotion>k__BackingField;

        static /*0x7de72f8*/ bool get_isLooping_Injected(nint _unity_self);
        /*0x7ddb38c*/ Motion();
        /*0x7de7280*/ bool get_isLooping();
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
        static /*0x7de7404*/ UnityEngine.AnimationClip[] get_animationClips_Injected(nint _unity_self);
        /*0x7de7334*/ RuntimeAnimatorController();
        /*0x7de738c*/ UnityEngine.AnimationClip[] get_animationClips();
    }

    namespace Animations
    {
        class AnimationPlayableBinding
        {
            static /*0x7de7440*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key);
            static /*0x7de7568*/ UnityEngine.Playables.PlayableOutput CreateAnimationOutput(UnityEngine.Playables.PlayableGraph graph, string name);
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

            static /*0x7de7638*/ UnityEngine.Animations.AnimationClipPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x7de7670*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip);
            static /*0x7de78c8*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationClipPlayable playable);
            static /*0x7de7810*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7de79b4*/ void SetApplyFootIKInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7de7a3c*/ void SetRemoveStartOffsetInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7de7ac4*/ void SetOverrideLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7de7b4c*/ void SetLoopTimeInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7de7b90*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, nint clip, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7de7720*/ AnimationClipPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7de78bc*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7de78f8*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
            /*0x7de7970*/ void SetApplyFootIK(bool value);
            /*0x7de79f8*/ void SetRemoveStartOffset(bool value);
            /*0x7de7a80*/ void SetOverrideLoopTime(bool value);
            /*0x7de7b08*/ void SetLoopTime(bool value);
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;
        }

        struct AnimationLayerMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7de8400*/ AnimationLayerMixerPlayable();
            static /*0x7de7be4*/ UnityEngine.Animations.AnimationLayerMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount, bool singleLayerOptimization);
            static /*0x7de7c8c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7de7fa4*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationLayerMixerPlayable playable);
            static /*0x7de7ec8*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7de7f54*/ void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7de82b0*/ void SetLayerMaskFromAvatarMaskInternal(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, UnityEngine.AvatarMask mask);
            static /*0x7de8368*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7de83ac*/ void SetLayerMaskFromAvatarMaskInternal_Injected(ref UnityEngine.Playables.PlayableHandle handle, uint layerIndex, nint mask);
            /*0x7de7d7c*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization);
            /*0x7de7f98*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7de8024*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
            /*0x7de80c0*/ void SetLayerMaskFromAvatarMask(uint layerIndex, UnityEngine.AvatarMask mask);
        }

        struct AnimationMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7de8910*/ AnimationMixerPlayable();
            static /*0x7de84a0*/ UnityEngine.Animations.AnimationMixerPlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7de8538*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7de87b0*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMixerPlayable playable);
            static /*0x7de8718*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7de88cc*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7de8628*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7de87a4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7de8830*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
        }

        struct AnimationMotionXToDeltaPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7de8ed8*/ AnimationMotionXToDeltaPlayable();
            static /*0x7de89ac*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable Create(UnityEngine.Playables.PlayableGraph graph);
            static /*0x7de8a3c*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph);
            static /*0x7de8cb0*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationMotionXToDeltaPlayable playable);
            static /*0x7de8c18*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7de8e50*/ void SetAbsoluteMotionInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            static /*0x7de8e94*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7de8b28*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7de8ca4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7de8d30*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
            /*0x7de8dcc*/ void SetAbsoluteMotion(bool value);
        }

        struct AnimationOffsetPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7de94dc*/ AnimationOffsetPlayable();
            static /*0x7de8f74*/ UnityEngine.Animations.AnimationOffsetPlayable Create(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x7de9064*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, int inputCount);
            static /*0x7de934c*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationOffsetPlayable playable);
            static /*0x7de929c*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7de9480*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7de91ac*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7de9340*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7de93cc*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
        }

        class AnimationPlayableExtensions
        {
            static /*0x3907c14*/ void SetAnimatedProperties<U>(U playable, UnityEngine.AnimationClip clip);
            static /*0x7de9578*/ void SetAnimatedPropertiesInternal(ref UnityEngine.Playables.PlayableHandle playable, UnityEngine.AnimationClip animatedProperties);
            static /*0x7de960c*/ void SetAnimatedPropertiesInternal_Injected(ref UnityEngine.Playables.PlayableHandle playable, nint animatedProperties);
        }

        class AnimationPlayableGraphExtensions
        {
            static /*0x7de9650*/ bool InternalCreateAnimationOutput(ref UnityEngine.Playables.PlayableGraph graph, string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x7de97dc*/ bool InternalCreateAnimationOutput_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableOutputHandle handle);
        }

        struct AnimationPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7de75a8*/ UnityEngine.Animations.AnimationPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name, UnityEngine.Animator target);
            static /*0x7de9830*/ UnityEngine.Animations.AnimationPlayableOutput get_Null();
            static /*0x7de7608*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Animations.AnimationPlayableOutput output);
            static /*0x7de99ac*/ UnityEngine.Animations.AnimationPlayableOutput op_Explicit(UnityEngine.Playables.PlayableOutput output);
            static /*0x7de9a30*/ void InternalSetTarget(ref UnityEngine.Playables.PlayableOutputHandle handle, UnityEngine.Animator target);
            static /*0x7de9ac4*/ void InternalSetTarget_Injected(ref UnityEngine.Playables.PlayableOutputHandle handle, nint target);
            /*0x7de98ac*/ AnimationPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7de99a0*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x7de999c*/ void SetTarget(UnityEngine.Animator value);
        }

        struct AnimationPosePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7de9cb8*/ AnimationPosePlayable();
            /*0x7de9b08*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7de9bf8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7de9c04*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
        }

        struct AnimationRemoveScalePlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7dea1dc*/ AnimationRemoveScalePlayable();
            static /*0x7de9d54*/ UnityEngine.Animations.AnimationRemoveScalePlayable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7de9dec*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x7dea064*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Animations.AnimationRemoveScalePlayable playable);
            static /*0x7de9fcc*/ bool CreateHandleInternal(UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            static /*0x7dea198*/ bool CreateHandleInternal_Injected(ref UnityEngine.Playables.PlayableGraph graph, ref UnityEngine.Playables.PlayableHandle handle);
            /*0x7de9edc*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7dea058*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7dea0e4*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimationScriptPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x7dea410*/ AnimationScriptPlayable();
            /*0x7dea278*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7dea368*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7dea374*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
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

            static /*0x7dea734*/ AnimatorControllerPlayable();
            /*0x7dea4ac*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7dea68c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7dea548*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0x7dea698*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
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
            static /*0x7dea814*/ void Internal_Create(UnityEngine.Animations.ScaleConstraint self);
            static /*0x7deb1a4*/ int GetSourceCountInternal(UnityEngine.Animations.ScaleConstraint self);
            static /*0x7deb3d0*/ void SetSourcesInternal(UnityEngine.Animations.ScaleConstraint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x7dea8c8*/ float get_weight_Injected(nint _unity_self);
            static /*0x7dea98c*/ void set_weight_Injected(nint _unity_self, float value);
            static /*0x7deaa70*/ void get_scaleAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x7deab44*/ void set_scaleAtRest_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x7deac20*/ void get_scaleOffset_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
            static /*0x7deacf4*/ void set_scaleOffset_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
            static /*0x7deadb0*/ UnityEngine.Animations.Axis get_scalingAxis_Injected(nint _unity_self);
            static /*0x7deae6c*/ void set_scalingAxis_Injected(nint _unity_self, UnityEngine.Animations.Axis value);
            static /*0x7deaf28*/ bool get_constraintActive_Injected(nint _unity_self);
            static /*0x7deafe4*/ void set_constraintActive_Injected(nint _unity_self, bool value);
            static /*0x7deb0a0*/ bool get_locked_Injected(nint _unity_self);
            static /*0x7deb15c*/ void set_locked_Injected(nint _unity_self, bool value);
            static /*0x7deb24c*/ int GetSourceCountInternal_Injected(nint self);
            static /*0x7deb338*/ void GetSources_Injected(nint _unity_self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x7deb480*/ void SetSourcesInternal_Injected(nint self, System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            static /*0x7deb550*/ int AddSource_Injected(nint _unity_self, ref UnityEngine.Animations.ConstraintSource source);
            static /*0x7deb76c*/ void RemoveSourceInternal_Injected(nint _unity_self, int index);
            static /*0x7deb870*/ void GetSourceInternal_Injected(nint _unity_self, int index, ref UnityEngine.Animations.ConstraintSource ret);
            static /*0x7deb998*/ void SetSourceInternal_Injected(nint _unity_self, int index, ref UnityEngine.Animations.ConstraintSource source);
            /*0x7dea7d0*/ ScaleConstraint();
            /*0x7dea850*/ float get_weight();
            /*0x7dea904*/ void set_weight(float value);
            /*0x7dea9d8*/ UnityEngine.Vector3 get_scaleAtRest();
            /*0x7deaab4*/ void set_scaleAtRest(UnityEngine.Vector3 value);
            /*0x7deab88*/ UnityEngine.Vector3 get_scaleOffset();
            /*0x7deac64*/ void set_scaleOffset(UnityEngine.Vector3 value);
            /*0x7dead38*/ UnityEngine.Animations.Axis get_scalingAxis();
            /*0x7deadec*/ void set_scalingAxis(UnityEngine.Animations.Axis value);
            /*0x7deaeb0*/ bool get_constraintActive();
            /*0x7deaf64*/ void set_constraintActive(bool value);
            /*0x7deb028*/ bool get_locked();
            /*0x7deb0dc*/ void set_locked(bool value);
            /*0x7deb1a0*/ int get_sourceCount();
            /*0x7deb288*/ void GetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x7deb37c*/ void SetSources(System.Collections.Generic.List<UnityEngine.Animations.ConstraintSource> sources);
            /*0x7deb4c4*/ int AddSource(UnityEngine.Animations.ConstraintSource source);
            /*0x7deb594*/ void RemoveSource(int index);
            /*0x7deb6ec*/ void RemoveSourceInternal(int index);
            /*0x7deb7b0*/ UnityEngine.Animations.ConstraintSource GetSource(int index);
            /*0x7deb7d8*/ UnityEngine.Animations.ConstraintSource GetSourceInternal(int index);
            /*0x7deb8c4*/ void SetSource(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x7deb904*/ void SetSourceInternal(int index, UnityEngine.Animations.ConstraintSource source);
            /*0x7deb5bc*/ void ValidateSourceIndex(int index);
        }
    }
}
