class <Module>
{
}

namespace UnityEngine
{
    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x10482c8*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0x10482f8*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x10483b4*/ void Invoke();
        }
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

    class Avatar : UnityEngine.Object
    {
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
    }

    enum AnimationEventSource
    {
        NoSource = 0,
        Legacy = 1,
        Animator = 2,
    }

    class AnimationState : UnityEngine.TrackedReference
    {
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

        /*0x10483c8*/ AnimationEvent();
    }

    class Motion : UnityEngine.Object
    {
        /*0x104842c*/ Motion();
    }

    enum StateInfoIndex
    {
        CurrentState = 0,
        NextState = 1,
        ExitState = 2,
        InterruptedState = 3,
    }

    struct AnimatorClipInfo
    {
        /*0x10*/ int m_ClipInstanceID;
        /*0x14*/ float m_Weight;

        static /*0x10484d4*/ UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(int instanceID);
        /*0x1048484*/ UnityEngine.AnimationClip get_clip();
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

        /*0x1048510*/ bool IsName(string name);
        /*0x10485bc*/ float get_normalizedTime();
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

    class Animator : UnityEngine.Behaviour
    {
        static /*0x1048580*/ int StringToHash(string name);
        /*0x10485c4*/ void SetFloat(string name, float value);
        /*0x104866c*/ bool GetBool(string name);
        /*0x10486f4*/ void SetBool(string name, bool value);
        /*0x104879c*/ void SetInteger(string name, int value);
        /*0x1048844*/ void SetTrigger(string name);
        /*0x10488cc*/ void ResetTrigger(string name);
        /*0x1048954*/ int GetLayerIndex(string layerName);
        /*0x1048998*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x10489f4*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x1048a74*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        /*0x1048af4*/ UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
        /*0x1048b38*/ bool IsInTransition(int layerIndex);
        /*0x1048b7c*/ void set_speed(float value);
        /*0x1048bc8*/ bool get_hasBoundPlayables();
        /*0x1048618*/ void SetFloatString(string name, float value);
        /*0x1048748*/ void SetBoolString(string name, bool value);
        /*0x10486b0*/ bool GetBoolString(string name);
        /*0x10487f0*/ void SetIntegerString(string name, int value);
        /*0x1048888*/ void SetTriggerString(string name);
        /*0x1048910*/ void ResetTriggerString(string name);
    }

    class AnimationClip : UnityEngine.Motion
    {
        static /*0x1048c44*/ void Internal_CreateAnimationClip(UnityEngine.AnimationClip self);
        /*0x1048c04*/ AnimationClip();
        /*0x1048c80*/ float get_length();
    }

    class SharedBetweenAnimatorsAttribute : System.Attribute
    {
    }

    class StateMachineBehaviour : UnityEngine.ScriptableObject
    {
        /*0x1048cf4*/ StateMachineBehaviour();
        /*0x1048cbc*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x1048cc0*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x1048cc4*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x1048cc8*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x1048ccc*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x1048cd0*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x1048cd4*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x1048cd8*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x1048cdc*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x1048ce0*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x1048ce4*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x1048ce8*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x1048cec*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x1048cf0*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
    }

    namespace Animations
    {
        struct AnimationRemoveScalePlayable : System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1048e74*/ AnimationRemoveScalePlayable();
            /*0x1048cfc*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1048dbc*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1048dc8*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimatorControllerPlayable : System.IEquatable<UnityEngine.Animations.AnimatorControllerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049114*/ AnimatorControllerPlayable();
            /*0x1048f10*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1049090*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1048f88*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0x104909c*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
        }

        struct AnimationOffsetPlayable : System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049328*/ AnimationOffsetPlayable();
            /*0x10491b0*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1049270*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x104927c*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
        }

        struct AnimationScriptPlayable : System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049508*/ AnimationScriptPlayable();
            /*0x10493c4*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1049484*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1049490*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
        }

        struct AnimationLayerMixerPlayable : System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049780*/ AnimationLayerMixerPlayable();
            static /*0x10496b8*/ void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            /*0x10495a4*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization);
            /*0x10496fc*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1049708*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
        }

        struct AnimationClipPlayable : System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x1049820*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x104982c*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;
        }

        struct AnimationPosePlayable : System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049a1c*/ AnimationPosePlayable();
            /*0x10498a4*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1049964*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1049970*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
        }

        struct AnimationMotionXToDeltaPlayable : System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049bfc*/ AnimationMotionXToDeltaPlayable();
            /*0x1049ab8*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1049b78*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1049b84*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
        }

        struct AnimationMixerPlayable : System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1049ddc*/ AnimationMixerPlayable();
            /*0x1049c98*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1049d58*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1049d64*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
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

        struct AnimationPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }

        class DiscreteEvaluationAttribute : System.Attribute
        {
        }

        class NotKeyableAttribute : System.Attribute
        {
        }
    }
}
