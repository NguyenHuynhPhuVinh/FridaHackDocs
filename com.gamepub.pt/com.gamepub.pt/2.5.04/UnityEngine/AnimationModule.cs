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
        /*0x2b02718*/ StateMachineBehaviour();
        /*0x2b026e0*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x2b026e4*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x2b026e8*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x2b026ec*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x2b026f0*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
        /*0x2b026f4*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x2b026f8*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash);
        /*0x2b026fc*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x2b02700*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x2b02704*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x2b02708*/ void OnStateMove(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x2b0270c*/ void OnStateIK(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x2b02710*/ void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
        /*0x2b02714*/ void OnStateMachineExit(UnityEngine.Animator animator, int stateMachinePathHash, UnityEngine.Animations.AnimatorControllerPlayable controller);
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

        /*0x2b009f4*/ AnimationEvent();
    }

    class AnimationClip : UnityEngine.Motion
    {
        static /*0x2b008e4*/ void Internal_CreateAnimationClip(UnityEngine.AnimationClip self);
        /*0x2b0083c*/ AnimationClip();
        /*0x2b00924*/ float get_length();
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

        static /*0x2b02184*/ UnityEngine.AnimationClip InstanceIDToAnimationClipPPtr(int instanceID);
        /*0xb39b64*/ UnityEngine.AnimationClip get_clip();
        /*0xb39bb8*/ float get_weight();
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

        /*0xb39be4*/ int get_fullPathHash();
        /*0xb39bec*/ float get_normalizedTime();
        /*0xb39bf4*/ float get_speed();
        /*0xb39bfc*/ bool get_loop();
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
        static /*0x2b02048*/ int StringToHash(string name);
        /*0x2b018ec*/ void SetFloat(string name, float value);
        /*0x2b019ac*/ void SetTrigger(string name);
        /*0x2b01a4c*/ void ResetTrigger(string name);
        /*0x2b01aec*/ int get_layerCount();
        /*0x2b01b2c*/ float GetLayerWeight(int layerIndex);
        /*0x2b01b7c*/ void GetAnimatorStateInfo(int layerIndex, UnityEngine.StateInfoIndex stateInfoIndex, ref UnityEngine.AnimatorStateInfo info);
        /*0x2b01be4*/ UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
        /*0x2b01c70*/ UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
        /*0x2b01cfc*/ int GetAnimatorClipInfoCount(int layerIndex, bool current);
        /*0x2b01d54*/ int GetCurrentAnimatorClipInfoCount(int layerIndex);
        /*0x2b01da8*/ int GetNextAnimatorClipInfoCount(int layerIndex);
        /*0x2b01dfc*/ void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x2b01ea4*/ void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips);
        /*0x2b01f0c*/ void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips);
        /*0x2b01fb4*/ void Play(string stateName, int layer, float normalizedTime);
        /*0x2b02088*/ void Play(int stateNameHash, int layer, float normalizedTime);
        /*0x2b020f0*/ bool get_hasBoundPlayables();
        /*0x2b0194c*/ void SetFloatString(string name, float value);
        /*0x2b019fc*/ void SetTriggerString(string name);
        /*0x2b01a9c*/ void ResetTriggerString(string name);
    }

    class AnimatorOverrideController : UnityEngine.RuntimeAnimatorController
    {
        /*0x18*/ UnityEngine.AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty;

        static /*0x2b0248c*/ void OnInvalidateOverrideController(UnityEngine.AnimatorOverrideController controller);

        class OnOverrideControllerDirtyCallback : System.MulticastDelegate
        {
            /*0x2b02720*/ OnOverrideControllerDirtyCallback(object object, nint method);
            /*0x2b024ac*/ void Invoke();
            /*0x2b02780*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2b027ac*/ void EndInvoke(System.IAsyncResult result);
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
        /*0x18*/ bool <isAnimatorMotion>k__BackingField;

        /*0x2b00880*/ Motion();
    }

    class RuntimeAnimatorController : UnityEngine.Object
    {
    }

    namespace Animations
    {
        class NotKeyableAttribute : System.Attribute
        {
        }

        struct AnimationClipPlayable : System.IEquatable<UnityEngine.Animations.AnimationClipPlayable>
        {
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            /*0xb39a50*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39a5c*/ bool Equals(UnityEngine.Animations.AnimationClipPlayable other);
        }

        struct AnimationHumanStream
        {
            /*0x10*/ nint stream;
        }

        struct AnimationLayerMixerPlayable : System.IEquatable<UnityEngine.Animations.AnimationLayerMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationLayerMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b00ba8*/ AnimationLayerMixerPlayable();
            /*0xb39aa0*/ AnimationLayerMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39aa8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39ab4*/ bool Equals(UnityEngine.Animations.AnimationLayerMixerPlayable other);
        }

        struct AnimationMixerPlayable : System.IEquatable<UnityEngine.Animations.AnimationMixerPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMixerPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b00da0*/ AnimationMixerPlayable();
            /*0xb39abc*/ AnimationMixerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39ac4*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39ad0*/ bool Equals(UnityEngine.Animations.AnimationMixerPlayable other);
        }

        struct AnimationMotionXToDeltaPlayable : System.IEquatable<UnityEngine.Animations.AnimationMotionXToDeltaPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationMotionXToDeltaPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b00f98*/ AnimationMotionXToDeltaPlayable();
            /*0xb39ad8*/ AnimationMotionXToDeltaPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39ae0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39aec*/ bool Equals(UnityEngine.Animations.AnimationMotionXToDeltaPlayable other);
        }

        struct AnimationOffsetPlayable : System.IEquatable<UnityEngine.Animations.AnimationOffsetPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationOffsetPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b011d4*/ AnimationOffsetPlayable();
            /*0xb39af4*/ AnimationOffsetPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39afc*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39b08*/ bool Equals(UnityEngine.Animations.AnimationOffsetPlayable other);
        }

        struct AnimationPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }

        struct AnimationPosePlayable : System.IEquatable<UnityEngine.Animations.AnimationPosePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationPosePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b01410*/ AnimationPosePlayable();
            /*0xb39b10*/ AnimationPosePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39b18*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39b24*/ bool Equals(UnityEngine.Animations.AnimationPosePlayable other);
        }

        struct AnimationRemoveScalePlayable : System.IEquatable<UnityEngine.Animations.AnimationRemoveScalePlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationRemoveScalePlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b0164c*/ AnimationRemoveScalePlayable();
            /*0xb39b2c*/ AnimationRemoveScalePlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39b34*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39b40*/ bool Equals(UnityEngine.Animations.AnimationRemoveScalePlayable other);
        }

        struct AnimationScriptPlayable : System.IEquatable<UnityEngine.Animations.AnimationScriptPlayable>
        {
            static /*0x0*/ UnityEngine.Animations.AnimationScriptPlayable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x2b01844*/ AnimationScriptPlayable();
            /*0xb39b48*/ AnimationScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39b50*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39b5c*/ bool Equals(UnityEngine.Animations.AnimationScriptPlayable other);
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

            static /*0x2b023e4*/ AnimatorControllerPlayable();
            /*0xb39bc0*/ AnimatorControllerPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39bc8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xb39bd4*/ void SetHandle(UnityEngine.Playables.PlayableHandle handle);
            /*0xb39bdc*/ bool Equals(UnityEngine.Animations.AnimatorControllerPlayable other);
        }
    }
}
