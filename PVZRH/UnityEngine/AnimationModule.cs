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
        /*0x533ec0*/ StateMachineBehaviour();
        /*0x32d010*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x32d010*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x32d010*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x32d010*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x32d010*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x32d010*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x32d010*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x32d010*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x32d010*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x32d010*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x32d010*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x32d010*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x32d010*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x32d010*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
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

        /*0x15b64b0*/ AnimationEvent();
    }

    class AnimationClip : UnityEngine.Motion
    {
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

    enum AnimatorUpdateMode
    {
        Normal = 0,
        AnimatePhysics = 1,
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

        /*0x15b7d60*/ bool IsName(string name);
        /*0x501220*/ float get_normalizedTime();
        /*0x15b7dc0*/ float get_length();
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
        static /*0x15b84a0*/ int StringToHash(string name);
        /*0x15b84e0*/ Animator();
        /*0x15b8390*/ void SetFloat(string name, float value);
        /*0x15b8000*/ bool GetBool(string name);
        /*0x15b7fc0*/ bool GetBool(int id);
        /*0x15b8330*/ void SetBool(string name, bool value);
        /*0x15b82d0*/ void SetBool(int id, bool value);
        /*0x15b83f0*/ void SetInteger(string name, int value);
        /*0x15b8450*/ void SetTrigger(string name);
        /*0x15b8280*/ void ResetTrigger(string name);
        /*0x15b8540*/ UnityEngine.Vector3 get_deltaPosition();
        /*0x15b86f0*/ void set_updateMode(UnityEngine.AnimatorUpdateMode value);
        /*0x15b7f60*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x15b8050*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x15b85d0*/ UnityEngine.AnimatorControllerParameter[] get_parameters();
        /*0x15b8610*/ float get_speed();
        /*0x15b86a0*/ void set_speed(float value);
        /*0x15b7e30*/ void CrossFade(string stateName, float normalizedTransitionDuration);
        /*0x15b7ed0*/ void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x15b7dd0*/ void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime);
        /*0x15b8260*/ void Play(string stateName, int layer);
        /*0x15b8140*/ void Play(string stateName);
        /*0x15b81d0*/ void Play(string stateName, int layer, float normalizedTime);
        /*0x15b8170*/ void Play(int stateNameHash, int layer, float normalizedTime);
        /*0x15b8590*/ bool get_hasBoundPlayables();
        /*0x15b80f0*/ bool HasState(int layerIndex, int stateID);
        /*0x15b8390*/ void SetFloatString(string name, float value);
        /*0x15b8330*/ void SetBoolString(string name, bool value);
        /*0x15b82d0*/ void SetBoolID(int id, bool value);
        /*0x15b8000*/ bool GetBoolString(string name);
        /*0x15b7fc0*/ bool GetBoolID(int id);
        /*0x15b83f0*/ void SetIntegerString(string name, int value);
        /*0x15b8450*/ void SetTriggerString(string name);
        /*0x15b8280*/ void ResetTriggerString(string name);
        /*0x15b8650*/ void set_keepAnimatorStateOnDisable(bool value);
        /*0x15b84f0*/ void get_deltaPosition_Injected(ref UnityEngine.Vector3 ret);
    }

    class AnimatorControllerParameter
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.AnimatorControllerParameterType m_Type;
        /*0x1c*/ float m_DefaultFloat;
        /*0x20*/ int m_DefaultInt;
        /*0x24*/ bool m_DefaultBool;

        /*0x15b7940*/ AnimatorControllerParameter();
        /*0x9e3110*/ string get_name();
        /*0x15b7890*/ bool Equals(object o);
        /*0xe77c60*/ int GetHashCode();
    }

    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x15b7d20*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0xe25c50*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x9dbe20*/ void Invoke();
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

    class Motion : UnityEngine.Object
    {
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
    }

    namespace Animations
    {
        class DiscreteEvaluationAttribute : System.Attribute
        {
            /*0x534220*/ DiscreteEvaluationAttribute();
        }

        class DiscreteEvaluationAttributeUtilities
        {
            static /*0x15b8740*/ int ConvertFloatToDiscreteInt(float f);
            static /*0x15b8730*/ float ConvertDiscreteIntToFloat(int f);
        }

        interface IAnimationPreviewable
        {
        }

        class NotKeyableAttribute : System.Attribute
        {
            /*0x534220*/ NotKeyableAttribute();
        }

        struct AnimationClipPlayable : System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b6420*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;
        }

        struct AnimationLayerMixerPlayable : System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b6640*/ AnimationLayerMixerPlayable();
            static /*0x15b65f0*/ void SetSingleLayerOptimizationInternal(ref UnityEngine.Playables.PlayableHandle handle, bool value);
            /*0x15b66d0*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle, bool singleLayerOptimization);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b6550*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
        }

        struct AnimationMixerPlayable : System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b68b0*/ AnimationMixerPlayable();
            /*0x15b69f0*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b6810*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
        }

        struct AnimationMotionXToDeltaPlayable : System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b6b70*/ AnimationMotionXToDeltaPlayable();
            /*0x15b6cb0*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b6ad0*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
        }

        struct AnimationOffsetPlayable : System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b6e30*/ AnimationOffsetPlayable();
            /*0x15b6f70*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b6d90*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
        }

        struct AnimationPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }

        struct AnimationPosePlayable : System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b70f0*/ AnimationPosePlayable();
            /*0x15b7230*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b7050*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
        }

        struct AnimationRemoveScalePlayable : System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b73b0*/ AnimationRemoveScalePlayable();
            /*0x15b74f0*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b7310*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimationScriptPlayable : System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b7670*/ AnimationScriptPlayable();
            /*0x15b77b0*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b75d0*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
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

        struct AnimatorControllerPlayable : System.IEquatable<UnityEngine.Animations.AnimatorControllerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimatorControllerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x15b7b80*/ AnimatorControllerPlayable();
            /*0x15b7c80*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x15b7a30*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b7990*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
        }
    }
}
