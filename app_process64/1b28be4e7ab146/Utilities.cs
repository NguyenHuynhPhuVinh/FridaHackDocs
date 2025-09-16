class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x81f46fc*/ EmbeddedAttribute();
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

                /*0x81f4704*/ NullableAttribute(byte );
                /*0x81f478c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x81f47bc*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UVAnimator : UnityEngine.MonoBehaviour
{
    /*0x20*/ UnityEngine.Vector2 speed;
    /*0x28*/ UnityEngine.UI.RawImage image;
    /*0x30*/ UnityEngine.Rect uvRect;

    /*0x81f4940*/ UVAnimator();
    /*0x81f47e4*/ void Awake();
    /*0x81f4858*/ void Update();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x81f4948*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x81f4a3c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    namespace Utilities
    {
        class AlphaHoleRaycastFilter : UnityEngine.UI.Image, UnityEngine.ICanvasRaycastFilter
        {
            /*0x110*/ UnityEngine.RectTransform[] <HoleRectTransforms>k__BackingField;

            /*0x81f4b98*/ AlphaHoleRaycastFilter();
            /*0x81f4a44*/ UnityEngine.RectTransform[] get_HoleRectTransforms();
            /*0x81f4a4c*/ void set_HoleRectTransforms(UnityEngine.RectTransform[] value);
            /*0x81f4a5c*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
        }

        class DebugNeko
        {
            static /*0x0*/ string Magic;

            static /*0x81f4bf8*/ DebugNeko();
            /*0x81f4bf0*/ DebugNeko();
        }

        class FillGauge : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.UI.Image gauge;
            /*0x28*/ TMPro.TextMeshProUGUI percentage;
            /*0x30*/ DG.Tweening.Tween tween;

            /*0x81f4e24*/ FillGauge();
            /*0x81f4c5c*/ UnityEngine.Color get_Color();
            /*0x81f4c80*/ void set_Color(UnityEngine.Color value);
            /*0x81f4ca4*/ Cysharp.Threading.Tasks.UniTask UpdateValue(long current, long max, float duration);
            /*0x81f4e2c*/ float <UpdateValue>b__6_0();
            /*0x81f4e48*/ void <UpdateValue>b__6_1(float x);
        }

        class InputImeVerifier : UnityEngine.MonoBehaviour
        {
            /*0x20*/ TMPro.TMP_InputField <Input>k__BackingField;
            /*0x28*/ UnityEngine.UI.Image backImage;
            /*0x30*/ bool isDeleteNewLineCode;
            /*0x31*/ bool onFocusSelectAll;
            /*0x38*/ UnityEngine.RectTransform caretCash;
            /*0x40*/ UnityEngine.Vector2 defaultTextComponentPosition;

            /*0x81f5890*/ InputImeVerifier();
            /*0x81f5004*/ TMPro.TMP_InputField get_Input();
            /*0x81f500c*/ void set_Input(TMPro.TMP_InputField value);
            /*0x81f5014*/ bool IsInputConfirmed();
            /*0x81f50e8*/ void Awake();
            /*0x81f5128*/ void Start();
            /*0x81f51e8*/ void OnEnable();
            /*0x81f51ec*/ void RegisterInputEvents();
            /*0x81f5388*/ void OnDisable();
            /*0x81f538c*/ void UnregisterInputEvents();
            /*0x81f53fc*/ void OnInputFieldEndEdit(string text);
            /*0x81f549c*/ void OnInputValueChanged(string text);
            /*0x81f561c*/ void OnDestroy();
            /*0x81f5718*/ void DeleteNewLineCode(string text);
            /*0x81f5804*/ void SelectAll();
            /*0x81f58a0*/ void <RegisterInputEvents>b__13_0(string text);
            /*0x81f58d8*/ void <RegisterInputEvents>b__13_1(string text);
            /*0x81f58dc*/ void <RegisterInputEvents>b__13_2(string text);
            /*0x81f5824*/ System.Collections.IEnumerator <SelectAll>g__SelectAllCoroutine|20_0();

            class <<SelectAll>g__SelectAllCoroutine|20_0>d : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ Assets.Utilities.InputImeVerifier <>4__this;

                /*0x81f59c4*/ <<SelectAll>g__SelectAllCoroutine|20_0>d(int <>1__state);
                /*0x81f59ec*/ void System.IDisposable.Dispose();
                /*0x81f59f0*/ bool MoveNext();
                /*0x81f5a94*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x81f5a9c*/ void System.Collections.IEnumerator.Reset();
                /*0x81f5ad4*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class StencilMaskedImage : UnityEngine.UI.Image
        {
            /*0x81f5da4*/ StencilMaskedImage();
            /*0x81f5adc*/ bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera);
        }

        class TextCarousel : UnityEngine.MonoBehaviour
        {
            /*0x20*/ TMPro.TMP_Text textField;
            /*0x28*/ string[] textData;
            /*0x30*/ Assets.Utilities.TextCarousel.DoTextData doTextData;
            /*0x38*/ float intervalBetweenTexts;
            /*0x3c*/ bool trigger;
            /*0x40*/ DG.Tweening.Sequence sequence;

            /*0x81f5fa0*/ TextCarousel();
            /*0x81f5dfc*/ void Update();
            /*0x81f5e14*/ void Play(string[] text);
            /*0x81f5f4c*/ void Stop();
            /*0x81f5f64*/ void Set(string text);
            /*0x81f5f88*/ void OnDisable();

            class DoTextData
            {
                /*0x10*/ float <Duration>k__BackingField;
                /*0x14*/ bool <RichTextEnabled>k__BackingField;
                /*0x18*/ DG.Tweening.ScrambleMode <ScrambleMode>k__BackingField;

                /*0x81f5fe8*/ DoTextData();
                /*0x81f5fb4*/ float get_Duration();
                /*0x81f5fbc*/ void set_Duration(float value);
                /*0x81f5fc4*/ bool get_RichTextEnabled();
                /*0x81f5fcc*/ void set_RichTextEnabled(bool value);
                /*0x81f5fd8*/ DG.Tweening.ScrambleMode get_ScrambleMode();
                /*0x81f5fe0*/ void set_ScrambleMode(DG.Tweening.ScrambleMode value);
            }
        }

        class TextMarquee : UnityEngine.MonoBehaviour, System.IDisposable
        {
            /*0x20*/ float <Duration>k__BackingField;
            /*0x24*/ float <FirstInterval>k__BackingField;
            /*0x28*/ TMPro.TextMeshProUGUI text;
            /*0x30*/ float width;
            /*0x34*/ bool moving;
            /*0x38*/ DG.Tweening.Sequence sequence;
            /*0x40*/ UnityEngine.Vector3 defaultPosition;
            /*0x4c*/ TMPro.HorizontalAlignmentOptions defaultHorizontalAlignmentOptions;

            /*0x81f6518*/ TextMarquee();
            /*0x81f5ff0*/ float get_Duration();
            /*0x81f5ff8*/ void set_Duration(float value);
            /*0x81f6000*/ float get_FirstInterval();
            /*0x81f6008*/ void set_FirstInterval(float value);
            /*0x81f6010*/ void Start();
            /*0x81f60c0*/ void Update();
            /*0x81f64c8*/ void OnDisable();
            /*0x81f64f0*/ void Dispose();

            class <>c__DisplayClass15_0
            {
                /*0x10*/ Assets.Utilities.TextMarquee <>4__this;
                /*0x18*/ string originalText;

                /*0x81f64c0*/ <>c__DisplayClass15_0();
                /*0x81f652c*/ void <Update>b__0();
                /*0x81f6570*/ void <Update>b__1();
            }
        }

        namespace Spine
        {
            class BlinkAnimator : UnityEngine.MonoBehaviour
            {
                static string SlotId = "eye";
                /*0x20*/ Spine.Unity.SkeletonMecanim <Mecanim>k__BackingField;
                /*0x28*/ Assets.Utilities.Spine.FaceStates facialState;
                /*0x2c*/ Assets.Utilities.Spine.BlinkAnimator.BlinkStates blinkState;
                /*0x30*/ float eyesClosedDuration;
                /*0x34*/ UnityEngine.Vector2 eyesOpenedDurationConstraint;
                /*0x3c*/ float eyesHalfOpenedDuration;
                /*0x40*/ System.Nullable<Assets.Utilities.Spine.FaceStates> <TriggeringFacialState>k__BackingField;
                /*0x48*/ DG.Tweening.Sequence sequence;

                /*0x81f6f80*/ BlinkAnimator();
                /*0x81f65f4*/ Spine.Unity.SkeletonMecanim get_Mecanim();
                /*0x81f65fc*/ void set_Mecanim(Spine.Unity.SkeletonMecanim value);
                /*0x81f6604*/ System.Nullable<Assets.Utilities.Spine.FaceStates> get_TriggeringFacialState();
                /*0x81f660c*/ void set_TriggeringFacialState(System.Nullable<Assets.Utilities.Spine.FaceStates> value);
                /*0x81f6614*/ void ApplyBlinkState(Assets.Utilities.Spine.BlinkAnimator.BlinkStates state);
                /*0x81f69d0*/ void Update();
                /*0x81f6d30*/ void OnEnable();
                /*0x81f6d38*/ void OnDisable();
                /*0x81f6d50*/ string AcquireAttachmentName(Assets.Utilities.Spine.FaceStates faceState, Assets.Utilities.Spine.BlinkAnimator.BlinkStates blinkState);
                /*0x81f6e3c*/ string BlinkStateToAttachmentSuffix(Assets.Utilities.Spine.BlinkAnimator.BlinkStates state);
                /*0x81f6ec0*/ string FaceStateToAttachmentSuffix(Assets.Utilities.Spine.FaceStates state);
                /*0x81f6fac*/ void <Update>b__16_0();
                /*0x81f6fb4*/ void <Update>b__16_1();
                /*0x81f6fbc*/ void <Update>b__16_2();
                /*0x81f6fc4*/ void <Update>b__16_3();
                /*0x81f6fcc*/ void <Update>b__16_4();
                /*0x81f6fd4*/ void <Update>b__16_5();

                enum BlinkStates
                {
                    Opened = 0,
                    HalfOpened = 1,
                    Closed = 2,
                }
            }

            class BoneFollowerGroup
            {
                /*0x10*/ string <Key>k__BackingField;
                /*0x18*/ Spine.Unity.BoneFollower[] <BoneFollowers>k__BackingField;

                /*0x81f7000*/ BoneFollowerGroup(string key, Spine.Unity.BoneFollower[] boneFollowers);
                /*0x81f6fe0*/ string get_Key();
                /*0x81f6fe8*/ void set_Key(string value);
                /*0x81f6ff0*/ Spine.Unity.BoneFollower[] get_BoneFollowers();
                /*0x81f6ff8*/ void set_BoneFollowers(Spine.Unity.BoneFollower[] value);
            }

            class SkeletonUtilityBoneGroup
            {
                /*0x10*/ string <Key>k__BackingField;
                /*0x18*/ Spine.Unity.SkeletonUtilityBone[] <BoneFollowers>k__BackingField;

                /*0x81f711c*/ SkeletonUtilityBoneGroup(string key, Spine.Unity.SkeletonUtilityBone[] boneFollowers);
                /*0x81f70fc*/ string get_Key();
                /*0x81f7104*/ void set_Key(string value);
                /*0x81f710c*/ Spine.Unity.SkeletonUtilityBone[] get_BoneFollowers();
                /*0x81f7114*/ void set_BoneFollowers(Spine.Unity.SkeletonUtilityBone[] value);
            }

            class EmotionAnimator : UnityEngine.MonoBehaviour
            {
                static string EmotionLowerBoneFollowerKey = "emotion_lower";
                static string EmotionTopRightBoneFollowerKey = "emotion_top_right";
                static string EmotionTopLeftBoneFollowerKey = "emotion_top_left";
                /*0x20*/ UnityEngine.Animator <Animator>k__BackingField;
                /*0x28*/ Spine.Unity.BoneFollower <BoneFollower>k__BackingField;

                /*0x81f749c*/ EmotionAnimator();
                /*0x81f7218*/ UnityEngine.Animator get_Animator();
                /*0x81f7220*/ void set_Animator(UnityEngine.Animator value);
                /*0x81f7228*/ Spine.Unity.BoneFollower get_BoneFollower();
                /*0x81f7230*/ void set_BoneFollower(Spine.Unity.BoneFollower value);
                /*0x81f7238*/ void set_Emotion(Assets.Utilities.Spine.EmotionAnimator.EmotionTypes value);
                /*0x81f723c*/ void ApplyEmotion(Assets.Utilities.Spine.EmotionAnimator.EmotionTypes type);
                /*0x81f7424*/ string TypeToBoneName(Assets.Utilities.Spine.EmotionAnimator.EmotionTypes type);

                enum EmotionTypes
                {
                    None = 0,
                    Note = 1,
                    Shock = 2,
                    Angry = 3,
                    ExclamationMark = 4,
                    Sweat1 = 5,
                    Sweat2 = 6,
                    Heart = 7,
                    QuestionMark = 8,
                    Surprise = 9,
                    Sigh = 10,
                    Sparkle = 11,
                    Silence = 12,
                    Laugh = 13,
                    Dissatisfaction = 14,
                    Inspiration = 15,
                }
            }

            class EyeTrackingAnimator : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Spine.Unity.SkeletonMecanim <Mecanim>k__BackingField;
                /*0x28*/ Spine.Unity.BoneFollower <LeftEye>k__BackingField;
                /*0x30*/ Spine.Unity.BoneFollower <RightEye>k__BackingField;
                /*0x38*/ Spine.Unity.BoneFollower <LeftEyeMax>k__BackingField;
                /*0x40*/ Spine.Unity.BoneFollower <RightEyeMax>k__BackingField;
                /*0x48*/ UnityEngine.InputSystem.InputAction clickAction;
                /*0x50*/ UnityEngine.InputSystem.InputAction pointAction;
                /*0x58*/ float planeDiviation;
                /*0x5c*/ bool applyEmbeddedConstrains;
                /*0x60*/ float leftTreshhold;
                /*0x64*/ float rightTreshhold;
                /*0x68*/ UnityEngine.Vector3 leftEyePosition;
                /*0x74*/ UnityEngine.Vector3 rightEyePosition;
                /*0x80*/ UnityEngine.Vector3 leftEyeActivePosition;
                /*0x8c*/ UnityEngine.Vector3 rightEyeActivePosition;
                /*0x98*/ float acceleration;
                /*0x9c*/ float accelerationAtTheStart;
                /*0xa0*/ float acceleratonAtTheEnd;
                /*0xa4*/ float accelerationTime;
                /*0xa8*/ float currentAccelerationTime;
                /*0xac*/ float delayTime;
                /*0xb0*/ float currentDelayTime;

                /*0x81f7f84*/ EyeTrackingAnimator();
                /*0x81f74a4*/ Spine.Unity.SkeletonMecanim get_Mecanim();
                /*0x81f74ac*/ void set_Mecanim(Spine.Unity.SkeletonMecanim value);
                /*0x81f74b4*/ Spine.Unity.BoneFollower get_LeftEye();
                /*0x81f74bc*/ void set_LeftEye(Spine.Unity.BoneFollower value);
                /*0x81f74c4*/ Spine.Unity.BoneFollower get_RightEye();
                /*0x81f74cc*/ void set_RightEye(Spine.Unity.BoneFollower value);
                /*0x81f74d4*/ Spine.Unity.BoneFollower get_LeftEyeMax();
                /*0x81f74dc*/ void set_LeftEyeMax(Spine.Unity.BoneFollower value);
                /*0x81f74e4*/ Spine.Unity.BoneFollower get_RightEyeMax();
                /*0x81f74ec*/ void set_RightEyeMax(Spine.Unity.BoneFollower value);
                /*0x81f74f4*/ void Awake();
                /*0x81f75bc*/ void OnEnable();
                /*0x81f75f0*/ void OnDisable();
                /*0x81f7624*/ void Update();
                /*0x81f7a50*/ void ApplyEmbeddedConstrains();
                /*0x81f7e84*/ void ApplyWorldPosition(Spine.Unity.BoneFollower target, UnityEngine.Vector3 position);
                /*0x81f7d0c*/ UnityEngine.Vector3 ConstrainToRadius(UnityEngine.Vector3 center, UnityEngine.Vector3 point, float radius);
                /*0x81f7c7c*/ UnityEngine.Vector3 CalculateBonePositionInWorldSpace(Spine.Unity.BoneFollower target);
                /*0x81f7ee0*/ UnityEngine.Vector3 CalculateLocalPositionFromWorldSpace(Spine.Unity.BoneFollower target, UnityEngine.Vector3 worldPosition);
            }

            enum FaceStates
            {
                Normal = 0,
                Shy = 1,
                Delighted = 2,
                Angry = 3,
                Sad = 4,
                Surprised = 5,
                Confused = 6,
                Scared = 7,
                Custom = 8,
            }

            class LipSyncAnimator : UnityEngine.MonoBehaviour
            {
                static float ClosedVolumeThreshold = 0.0010000000474974513;
                static float HalfOpenedVolumeThreshold = 0.004000000189989805;
                static string SlotId = "mouth";
                /*0x20*/ Spine.Unity.SkeletonMecanim <Mecanim>k__BackingField;
                /*0x28*/ string attachmentName;
                /*0x30*/ System.IDisposable volumeSyncDisposable;
                /*0x38*/ Assets.Utilities.Spine.FaceStates faceState;

                /*0x81f8648*/ LipSyncAnimator();
                /*0x81f7fc0*/ Spine.Unity.SkeletonMecanim get_Mecanim();
                /*0x81f7fc8*/ void set_Mecanim(Spine.Unity.SkeletonMecanim value);
                /*0x81f7fd0*/ Assets.Utilities.Spine.FaceStates get_FaceState();
                /*0x81f7fd8*/ void set_FaceState(Assets.Utilities.Spine.FaceStates value);
                /*0x81f81dc*/ void Apply(UniRx.ReactiveProperty<float> volume);
                /*0x81f8388*/ void Stop();
                /*0x81f8430*/ void OnDisable();
                /*0x81f84d8*/ void OnEnable();
                /*0x81f7fe4*/ void ApplySlotAttachment(float voiceVolume);
                /*0x81f84e0*/ string AcquireMouthAttachementSlotName(Assets.Utilities.Spine.FaceStates state, float voiceVolume);
                /*0x81f86a0*/ void <Apply>b__13_0(float voiceVolume);
            }

            class MecanimController : UnityEngine.MonoBehaviour
            {
                static string DefaultBoneFollowerKey = "default";
                static string DamageBoneFollowerKey = "damage";
                static string BoosterBoneFollowerKey = "booster";
                static string SkillActionPointBoneFollowerKey = "san_point";
                static string ExtraSkillActionPointBoneFollowerKey = "esan_point";
                static string VisualEffectBoneFollowerKey = "fx_point";
                static string EmitterBoneFollowerKey = "fx_barrel";
                static string TapPointCenterBoneFollowerKey = "tap_point_c";
                static string TapPointRadiusBoneFollowerKey = "tap_point_r";
                static string SpeechBubblePointBoneFollowerKey = "speech_bubble_point";
                static string CharacterFaceBoneFollowerKey = "chara_ctrl";
                static string CharacterLocatorBoneFollowerKey = "face_locator";
                static string RootBoneFollowerKey = "root";
                static string ManualSequenceKey = "ManualSequence";
                static string CameraFocusFollowerKey = "focus_point";
                static string StatusViewFollowerKey = "status_point";
                static string GuardBoosterBoneLabel = "guarding";
                static string MaterialLightColorPropertyName = "_LightColor";
                static string MaterialLightStrengthPropertyName = "_LightStrenght";
                static string MaterialColorOverlayPropertyName = "_ColorOverlay";
                static string MaterialOverlayStrenghPropertyName = "_OverlayStrenght";
                static string MaterialErosionPropertyName = "_Erosion";
                static string MaterialDitherPropertyName = "_DitherDistance";
                /*0x20*/ Spine.Unity.SkeletonMecanim <Mecanim>k__BackingField;
                /*0x28*/ UnityEngine.MeshRenderer <MeshRenderer>k__BackingField;
                /*0x30*/ UnityEngine.Animator <Animator>k__BackingField;
                /*0x38*/ Assets.Utilities.Spine.RendererOverride <RendererOverride>k__BackingField;
                /*0x40*/ string[] <VfxData>k__BackingField;
                /*0x48*/ Assets.Utilities.Spine.MecanimController.Triggers trigger;
                /*0x50*/ Assets.Utilities.Spine.BoneFollowerGroup[] <BoneFollowers>k__BackingField;
                /*0x58*/ UnityEngine.Events.UnityEvent<string> <OnStartEvent>k__BackingField;
                /*0x60*/ UnityEngine.Events.UnityEvent<string> <OnEndEvent>k__BackingField;
                /*0x68*/ UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.ActionData> <OnPlaybackActionInEvent>k__BackingField;
                /*0x70*/ UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.ActionData> <OnPlaybackActionOutEvent>k__BackingField;
                /*0x78*/ UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.VisualEffectData> <OnPlaybackVfxEvent>k__BackingField;
                /*0x80*/ UnityEngine.Events.UnityEvent <OnPlaybackSkillVfxEvent>k__BackingField;
                /*0x88*/ UnityEngine.Events.UnityEvent <OnPlaybackExtraSkillVfxEvent>k__BackingField;
                /*0x90*/ UnityEngine.Events.UnityEvent<string> <OnEndSequenceEvent>k__BackingField;
                /*0x98*/ float ditherDistance;
                /*0x9c*/ float alpha;
                /*0xa0*/ bool synchronizeAlpha;
                /*0xa8*/ System.Collections.Generic.List<System.Action<Assets.Utilities.Spine.FaceStates, float>> <AdditionalActions>k__BackingField;
                /*0xb0*/ System.Nullable<float> <AnimatorSpeedOverride>k__BackingField;
                /*0xb8*/ DG.Tweening.Tween <JumpTween>k__BackingField;
                /*0xc0*/ bool <DisableAutoPropertyUpdate>k__BackingField;
                /*0xc8*/ DG.Tweening.Tween activeTween;
                /*0xd0*/ Assets.Utilities.Spine.MecanimController.Triggers activeTrigger;
                /*0xd8*/ Assets.Utilities.Spine.MecanimController.ActionData lastBoostParameters;
                /*0xe0*/ UnityEngine.MaterialPropertyBlock materialPropertyBlock;

                static /*0x81fab7c*/ Assets.Utilities.Spine.MecanimController.ActionData TryCreateActionData(string stringData);
                static /*0x81fa9b4*/ Assets.Utilities.Spine.MecanimController.VisualEffectData TryCreateVfxData(string stringData);
                /*0x81fb4a4*/ MecanimController();
                /*0x81f86a4*/ Spine.Unity.SkeletonMecanim get_Mecanim();
                /*0x81f86ac*/ void set_Mecanim(Spine.Unity.SkeletonMecanim value);
                /*0x81f86b4*/ UnityEngine.MeshRenderer get_MeshRenderer();
                /*0x81f86bc*/ void set_MeshRenderer(UnityEngine.MeshRenderer value);
                /*0x81f86c4*/ UnityEngine.Animator get_Animator();
                /*0x81f86cc*/ void set_Animator(UnityEngine.Animator value);
                /*0x81f86d4*/ Assets.Utilities.Spine.RendererOverride get_RendererOverride();
                /*0x81f86dc*/ void set_RendererOverride(Assets.Utilities.Spine.RendererOverride value);
                /*0x81f86e4*/ string[] get_VfxData();
                /*0x81f86ec*/ void set_VfxData(string[] value);
                /*0x81f86f4*/ Assets.Utilities.Spine.BoneFollowerGroup[] get_BoneFollowers();
                /*0x81f86fc*/ void set_BoneFollowers(Assets.Utilities.Spine.BoneFollowerGroup[] value);
                /*0x81f8704*/ UnityEngine.Events.UnityEvent<string> get_OnStartEvent();
                /*0x81f870c*/ void set_OnStartEvent(UnityEngine.Events.UnityEvent<string> value);
                /*0x81f8714*/ UnityEngine.Events.UnityEvent<string> get_OnEndEvent();
                /*0x81f871c*/ void set_OnEndEvent(UnityEngine.Events.UnityEvent<string> value);
                /*0x81f8724*/ UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.ActionData> get_OnPlaybackActionInEvent();
                /*0x81f872c*/ void set_OnPlaybackActionInEvent(UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.ActionData> value);
                /*0x81f8734*/ UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.ActionData> get_OnPlaybackActionOutEvent();
                /*0x81f873c*/ void set_OnPlaybackActionOutEvent(UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.ActionData> value);
                /*0x81f8744*/ UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.VisualEffectData> get_OnPlaybackVfxEvent();
                /*0x81f874c*/ void set_OnPlaybackVfxEvent(UnityEngine.Events.UnityEvent<Assets.Utilities.Spine.MecanimController.VisualEffectData> value);
                /*0x81f8754*/ UnityEngine.Events.UnityEvent get_OnPlaybackSkillVfxEvent();
                /*0x81f875c*/ void set_OnPlaybackSkillVfxEvent(UnityEngine.Events.UnityEvent value);
                /*0x81f8764*/ UnityEngine.Events.UnityEvent get_OnPlaybackExtraSkillVfxEvent();
                /*0x81f876c*/ void set_OnPlaybackExtraSkillVfxEvent(UnityEngine.Events.UnityEvent value);
                /*0x81f8774*/ UnityEngine.Events.UnityEvent<string> get_OnEndSequenceEvent();
                /*0x81f877c*/ void set_OnEndSequenceEvent(UnityEngine.Events.UnityEvent<string> value);
                /*0x81f8784*/ System.Collections.Generic.List<System.Action<Assets.Utilities.Spine.FaceStates, float>> get_AdditionalActions();
                /*0x81f878c*/ System.Nullable<float> get_AnimatorSpeedOverride();
                /*0x81f8794*/ void set_AnimatorSpeedOverride(System.Nullable<float> value);
                /*0x81f879c*/ DG.Tweening.Tween get_JumpTween();
                /*0x81f87a4*/ void set_JumpTween(DG.Tweening.Tween value);
                /*0x81f87ac*/ bool get_DisableAutoPropertyUpdate();
                /*0x81f87b4*/ void set_DisableAutoPropertyUpdate(bool value);
                /*0x81f87c0*/ float get_DitherDistance();
                /*0x81f87c8*/ void set_DitherDistance(float value);
                /*0x81f883c*/ void Awake();
                /*0x81f8904*/ void ClearAllListeners();
                /*0x81f8994*/ void Update();
                /*0x81f8a6c*/ void OnDisable();
                /*0x81f8a84*/ UnityEngine.Vector3[] GetBoneFollowersPositions(string key);
                /*0x81f8db8*/ UnityEngine.Transform[] GetBoneFollowersTransforms(string key);
                /*0x81f8f80*/ System.Nullable<UnityEngine.Vector3> GetBoneFollowersPosition(string key, string boneName);
                /*0x81f925c*/ bool TryGetBoneFollowerPosition(string key, string boneName, ref System.Nullable<UnityEngine.Vector3> position);
                /*0x81f92c8*/ UnityEngine.Vector3[] GetBoneFollowersLocalPositions(string key);
                /*0x81f9490*/ System.Nullable<UnityEngine.Vector3> GetBoneFollowersLocalPosition(string key, string boneName);
                /*0x81f976c*/ bool TryGetBoneFollowerLocalPosition(string key, string boneName, ref System.Nullable<UnityEngine.Vector3> position);
                /*0x81f97d8*/ Spine.Unity.BoneFollower[] TryGetBoneFollowers(string key);
                /*0x81f9888*/ bool TryGetBoneFollower(string key, ref Spine.Unity.BoneFollower follower);
                /*0x81f98f4*/ DG.Tweening.Tween DOMaterialFloatValue(string keyword, float endValue, float duration);
                /*0x81f9ae4*/ DG.Tweening.Tween DOMaterialColorValue(string keyword, UnityEngine.Color endValue, float duration);
                /*0x81f9d00*/ DG.Tweening.Tween DOSkeletonAlpha(float endValue, float duration);
                /*0x81f8a48*/ void SetSkeletonAlpha(float value);
                /*0x81f9e3c*/ void DisablePhysicsInheritanceFactor();
                /*0x81f9eb0*/ void SetMaterialFloatValue(string keyword, float value);
                /*0x81f9f44*/ float GetMaterialFloatValue(string keyword);
                /*0x81f9f90*/ void SetMaterialColorValue(string keyword, UnityEngine.Color value);
                /*0x81fa044*/ UnityEngine.Color GetMaterialColorValue(string keyword);
                /*0x81fa090*/ void SetTrigger(Assets.Utilities.Spine.MecanimController.Triggers trigger, float animatorSpeed);
                /*0x81fa148*/ void SetTriggerWithAdditionalActions(Assets.Utilities.Spine.FaceStates state, float animatorSpeed);
                /*0x81fa31c*/ void SetAnimationTrigger(int index, float animatorSpeed);
                /*0x81fa3a8*/ void SetTriggerIfNotTriggered(Assets.Utilities.Spine.MecanimController.Triggers trigger, float animatorSpeed);
                /*0x81fa0c0*/ void SetTrigger(string triggerName, float animatorSpeed);
                /*0x81fa458*/ void SetBool(string name, bool value);
                /*0x81fa478*/ void SetManualSequence(bool value);
                /*0x81fa4d4*/ void SetSkin(Assets.Utilities.Spine.MecanimController.SkinTypes skin);
                /*0x81fa598*/ void SetSkin(string skinName);
                /*0x81fa608*/ void FireStartEvent(string args);
                /*0x81fa660*/ void FireEndEvent(string args);
                /*0x81fa6b8*/ void SPINE_EVENT_PlaybackSkillVfx();
                /*0x81fa6d4*/ void SPINE_EVENT_PlaybackExtraSkillVfx();
                /*0x81fa6f0*/ void SPINE_EVENT_End(string args);
                /*0x81fa748*/ void san();
                /*0x81fa764*/ void esan();
                /*0x81fa780*/ void fx_0(string args);
                /*0x81fa7f4*/ void fx_1(string args);
                /*0x81fa7f8*/ void fx_2(string args);
                /*0x81fa7fc*/ void fx_3(string args);
                /*0x81fa800*/ void fx_4(string args);
                /*0x81fa804*/ void fx_5(string args);
                /*0x81fa808*/ void fx_6(string args);
                /*0x81fa80c*/ void fx_7(string args);
                /*0x81fa810*/ void fx_8(string args);
                /*0x81fa814*/ void fx_9(string args);
                /*0x81fa818*/ void FireBoostEvent(string args);
                /*0x81fa98c*/ void an_0(string args);
                /*0x81fa990*/ void an_1(string args);
                /*0x81fa994*/ void an_2(string args);
                /*0x81fa998*/ void an_3(string args);
                /*0x81fa99c*/ void an_4(string args);
                /*0x81fa9a0*/ void an_5(string args);
                /*0x81fa9a4*/ void an_6(string args);
                /*0x81fa9a8*/ void an_7(string args);
                /*0x81fa9ac*/ void an_8(string args);
                /*0x81fa9b0*/ void an_9(string args);
                /*0x81fa784*/ void SPINE_EVENT_PlaybackVfx(string args);
                /*0x81fa81c*/ void SPINE_EVENT_PlaybackAction(string args);
                /*0x81fad24*/ void TrySimulateBoostEvent();
                /*0x81fad84*/ Assets.Utilities.Spine.MecanimController.ActionData AcquireSimulatedBoostEventData();
                /*0x81f8c4c*/ Assets.Utilities.Spine.BoneFollowerGroup GetBoneFollowerGroup(string key, string defaultKey);
                /*0x81fa4f0*/ string SkinTypeToSkinName(Assets.Utilities.Spine.MecanimController.SkinTypes skin);
                /*0x81faf74*/ string AnimationIndexToTriggerName(int index);
                /*0x81fa2d0*/ string FaceStateToTriggerName(Assets.Utilities.Spine.FaceStates state);
                /*0x81fafe8*/ string TriggerToTriggerName(Assets.Utilities.Spine.MecanimController.Triggers trigger);
                /*0x81fb288*/ void ResetBoolValues();
                /*0x81fb338*/ void ResetValues();
                /*0x81fb7dc*/ void <Awake>b__105_0(Spine.Unity.SkeletonRenderer skeletonRenderer);
                /*0x81fb810*/ float <DOSkeletonAlpha>b__120_0();
                /*0x81fb83c*/ void <DOSkeletonAlpha>b__120_1(float alpha);

                enum Triggers
                {
                    IdlingLoop = 0,
                    SequenceIn = 1,
                    Step_1 = 2,
                    Step_2 = 3,
                    Step_3 = 4,
                    Step_4 = 5,
                    Step_5 = 6,
                    Step_6 = 7,
                    Step_7 = 8,
                    Step_8 = 9,
                    Step_9 = 10,
                    SequenceOut = 11,
                    DefeatedIn = 12,
                    DefeatedLoop = 13,
                    VictoryIn = 14,
                    VictoryLoop = 15,
                    DamageIn = 16,
                    DamageLoop = 17,
                    GuardingIn = 18,
                    GuardingLoop = 19,
                    GuardingEnd = 20,
                    Normal = 21,
                    Shy = 22,
                    Delighted = 23,
                    Angry = 24,
                    Sad = 25,
                    Surprised = 26,
                    Confused = 27,
                    Scared = 28,
                    Custom = 29,
                    EntryAnimation = 30,
                    FirstCameraIn = 31,
                    SecondCameraIn = 32,
                    ThirdCameraIn = 33,
                    Animation_1 = 34,
                    Animation_2 = 35,
                    Animation_3 = 36,
                    Animation_4 = 37,
                    Animation_5 = 38,
                    Animation_6 = 39,
                    Animation_7 = 40,
                    Animation_8 = 41,
                    Animation_9 = 42,
                    Animation_2_Loop = 43,
                    Animation_3_Loop = 44,
                    Animation_4_Loop = 45,
                }

                enum SkinTypes
                {
                    Default = 0,
                    Icon = 1,
                    Battle = 2,
                    Mask_2 = 3,
                    Mask_3 = 4,
                    Mask_4 = 5,
                    Mask_5 = 6,
                }

                enum ActionTypes
                {
                    None = 0,
                    Jump = 1,
                    SlideFromRight = 2,
                    SlideFromLeft = 3,
                    Boost = 4,
                }

                class ActionData
                {
                    /*0x10*/ Assets.Utilities.Spine.MecanimController.ActionTypes <Type>k__BackingField;
                    /*0x14*/ float <Duration>k__BackingField;
                    /*0x18*/ float <Power>k__BackingField;
                    /*0x20*/ string <VfxAssetKey>k__BackingField;
                    /*0x28*/ string <BoneLabel>k__BackingField;

                    /*0x81fae48*/ ActionData();
                    /*0x81fb860*/ Assets.Utilities.Spine.MecanimController.ActionTypes get_Type();
                    /*0x81fb868*/ void set_Type(Assets.Utilities.Spine.MecanimController.ActionTypes value);
                    /*0x81fb870*/ float get_Duration();
                    /*0x81fb878*/ void set_Duration(float value);
                    /*0x81fb880*/ float get_Power();
                    /*0x81fb888*/ void set_Power(float value);
                    /*0x81fb890*/ string get_VfxAssetKey();
                    /*0x81fb898*/ void set_VfxAssetKey(string value);
                    /*0x81fb8a0*/ string get_BoneLabel();
                    /*0x81fb8a8*/ void set_BoneLabel(string value);
                }

                class VisualEffectData
                {
                    /*0x10*/ string <VfxAssetKey>k__BackingField;
                    /*0x18*/ string[] <BoneNames>k__BackingField;

                    /*0x81faea8*/ VisualEffectData();
                    /*0x81fb8b0*/ string get_VfxAssetKey();
                    /*0x81fb8b8*/ void set_VfxAssetKey(string value);
                    /*0x81fb8c0*/ string[] get_BoneNames();
                    /*0x81fb8c8*/ void set_BoneNames(string[] value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Utilities.Spine.MecanimController.<> <>9;
                    static /*0x8*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Vector3> <>9__109_0;
                    static /*0x10*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Transform> <>9__110_0;
                    static /*0x18*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Vector3> <>9__111_0;
                    static /*0x20*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Vector3> <>9__111_2;
                    static /*0x28*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Vector3> <>9__113_0;
                    static /*0x30*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Vector3> <>9__114_0;
                    static /*0x38*/ System.Func<Spine.Unity.BoneFollower, UnityEngine.Vector3> <>9__114_2;

                    static /*0x81fb8d0*/ <>c();
                    /*0x81fb938*/ <>c();
                    /*0x81fb940*/ UnityEngine.Vector3 <GetBoneFollowersPositions>b__109_0(Spine.Unity.BoneFollower f);
                    /*0x81fb968*/ UnityEngine.Transform <GetBoneFollowersTransforms>b__110_0(Spine.Unity.BoneFollower f);
                    /*0x81fb980*/ UnityEngine.Vector3 <GetBoneFollowersPosition>b__111_0(Spine.Unity.BoneFollower f);
                    /*0x81fb9a8*/ UnityEngine.Vector3 <GetBoneFollowersPosition>b__111_2(Spine.Unity.BoneFollower f);
                    /*0x81fb9d0*/ UnityEngine.Vector3 <GetBoneFollowersLocalPositions>b__113_0(Spine.Unity.BoneFollower f);
                    /*0x81fb9f8*/ UnityEngine.Vector3 <GetBoneFollowersLocalPosition>b__114_0(Spine.Unity.BoneFollower f);
                    /*0x81fba20*/ UnityEngine.Vector3 <GetBoneFollowersLocalPosition>b__114_2(Spine.Unity.BoneFollower f);
                }

                class <>c__DisplayClass111_0
                {
                    /*0x10*/ string boneName;

                    /*0x81f9254*/ <>c__DisplayClass111_0();
                    /*0x81fba48*/ bool <GetBoneFollowersPosition>b__1(Spine.Unity.BoneFollower f);
                }

                class <>c__DisplayClass114_0
                {
                    /*0x10*/ string boneName;

                    /*0x81f9764*/ <>c__DisplayClass114_0();
                    /*0x81fba74*/ bool <GetBoneFollowersLocalPosition>b__1(Spine.Unity.BoneFollower f);
                }

                class <>c__DisplayClass118_0
                {
                    /*0x10*/ float floatValue;
                    /*0x18*/ Assets.Utilities.Spine.MecanimController <>4__this;
                    /*0x20*/ string keyword;

                    /*0x81f9adc*/ <>c__DisplayClass118_0();
                    /*0x81fbaa0*/ float <DOMaterialFloatValue>b__0();
                    /*0x81fbaa8*/ void <DOMaterialFloatValue>b__1(float value);
                }

                class <>c__DisplayClass119_0
                {
                    /*0x10*/ UnityEngine.Color colorValue;
                    /*0x20*/ Assets.Utilities.Spine.MecanimController <>4__this;
                    /*0x28*/ string keyword;

                    /*0x81f9cf8*/ <>c__DisplayClass119_0();
                    /*0x81fbad8*/ UnityEngine.Color <DOMaterialColorValue>b__0();
                    /*0x81fbae4*/ void <DOMaterialColorValue>b__1(UnityEngine.Color value);
                }

                class <>c__DisplayClass170_0
                {
                    /*0x10*/ string key;
                    /*0x18*/ string defaultKey;

                    /*0x81faf6c*/ <>c__DisplayClass170_0();
                    /*0x81fbb18*/ bool <GetBoneFollowerGroup>b__0(Assets.Utilities.Spine.BoneFollowerGroup g);
                    /*0x81fbb3c*/ bool <GetBoneFollowerGroup>b__1(Assets.Utilities.Spine.BoneFollowerGroup g);
                }
            }

            class RendererOverride : UnityEngine.MonoBehaviour
            {
                static string MosaicSlotId = "mosaic";
                /*0x20*/ Spine.Unity.SkeletonRenderSeparator <RenderSeparator>k__BackingField;
                /*0x28*/ System.Collections.Generic.Queue<Spine.Unity.SkeletonPartsRenderer> unusedRenderers;

                /*0x81fc420*/ RendererOverride();
                /*0x81fbb60*/ Spine.Unity.SkeletonRenderSeparator get_RenderSeparator();
                /*0x81fbb68*/ void set_RenderSeparator(Spine.Unity.SkeletonRenderSeparator value);
                /*0x81fbb70*/ void Update();
                /*0x81fbb74*/ void ConfigureRenderers();
                /*0x81fc138*/ void AddRenderer(string name);
                /*0x81fbf50*/ void FreeActiveRenderers();

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<string, Spine.Slot> separatorSlots;

                    /*0x81fbf48*/ <>c__DisplayClass7_0();
                    /*0x81fc4a8*/ bool <ConfigureRenderers>b__0(string slot);
                }
            }

            class SkeletonController : UnityEngine.MonoBehaviour
            {
                static string DefaultBoneFollowerKey = "root";
                static string CharacterFaceBoneFollowerKey = "chara_ctrl";
                /*0x20*/ Spine.Unity.SkeletonGraphic <SkeletonGraphic>k__BackingField;
                /*0x28*/ Assets.Utilities.Spine.SkeletonUtilityBoneGroup[] <BoneFollowers>k__BackingField;
                /*0x30*/ float alpha;
                /*0x34*/ bool synchronizeAlpha;
                /*0x38*/ DG.Tweening.Tween fadeTween;
                /*0x40*/ string currentAnimation;

                /*0x81fd8d8*/ SkeletonController();
                /*0x81fc500*/ Spine.Unity.SkeletonGraphic get_SkeletonGraphic();
                /*0x81fc508*/ void set_SkeletonGraphic(Spine.Unity.SkeletonGraphic value);
                /*0x81fc510*/ Assets.Utilities.Spine.SkeletonUtilityBoneGroup[] get_BoneFollowers();
                /*0x81fc518*/ void set_BoneFollowers(Assets.Utilities.Spine.SkeletonUtilityBoneGroup[] value);
                /*0x81fc520*/ void Update();
                /*0x81fc598*/ UnityEngine.Vector3[] GetBoneFollowersPositions(string key);
                /*0x81fc8cc*/ System.Nullable<UnityEngine.Vector3> GetBoneFollowersPosition(string key, string boneName);
                /*0x81fcba8*/ bool TryGetBoneFollowerPosition(string key, string boneName, ref System.Nullable<UnityEngine.Vector3> position);
                /*0x81fcc14*/ UnityEngine.Vector3[] GetBoneFollowersLocalPositions(string key);
                /*0x81fcddc*/ System.Nullable<UnityEngine.Vector3> GetBoneFollowersLocalPosition(string key, string boneName);
                /*0x81fd0b8*/ bool TryGetBoneFollowerLocalPosition(string key, string boneName, ref System.Nullable<UnityEngine.Vector3> position);
                /*0x81fd124*/ Spine.Unity.SkeletonUtilityBone[] TryGetBoneFollowers(string key);
                /*0x81fd1d4*/ bool TryGetBoneFollower(string key, ref Spine.Unity.SkeletonUtilityBone follower);
                /*0x81fc760*/ Assets.Utilities.Spine.SkeletonUtilityBoneGroup GetBoneFollowerGroup(string key, string defaultKey);
                /*0x81fd248*/ void SetAnimation(Assets.Utilities.Spine.SkeletonController.AnimationTypes type);
                /*0x81fd4e4*/ Spine.TrackEntry SetAnimation(string animationName);
                /*0x81fd680*/ void SetSkin(string skinName);
                /*0x81fd728*/ DG.Tweening.Tween DOAlpha(float endValue, float duration);
                /*0x81fc534*/ void SetAlpha(float value);
                /*0x81fd864*/ void DisablePhysicsInheritanceFactor();
                /*0x81fd440*/ string AnimationTypeToAnimationString(Assets.Utilities.Spine.SkeletonController.AnimationTypes animationType);
                /*0x81fd9a4*/ float <DOAlpha>b__27_0();
                /*0x81fd9f0*/ void <DOAlpha>b__27_1(float alpha);

                enum AnimationTypes
                {
                    IdlingLoop = 0,
                    SequenceIn = 1,
                    DamageIn = 2,
                    DamageLoop = 3,
                    VictoryIn = 4,
                    VictoryLoop = 5,
                }

                class <>c
                {
                    static /*0x0*/ Assets.Utilities.Spine.SkeletonController.<> <>9;
                    static /*0x8*/ System.Func<Spine.Unity.SkeletonUtilityBone, UnityEngine.Vector3> <>9__15_0;
                    static /*0x10*/ System.Func<Spine.Unity.SkeletonUtilityBone, UnityEngine.Vector3> <>9__16_0;
                    static /*0x18*/ System.Func<Spine.Unity.SkeletonUtilityBone, UnityEngine.Vector3> <>9__16_2;
                    static /*0x20*/ System.Func<Spine.Unity.SkeletonUtilityBone, UnityEngine.Vector3> <>9__18_0;
                    static /*0x28*/ System.Func<Spine.Unity.SkeletonUtilityBone, UnityEngine.Vector3> <>9__19_0;
                    static /*0x30*/ System.Func<Spine.Unity.SkeletonUtilityBone, UnityEngine.Vector3> <>9__19_2;

                    static /*0x81fda54*/ <>c();
                    /*0x81fdabc*/ <>c();
                    /*0x81fdac4*/ UnityEngine.Vector3 <GetBoneFollowersPositions>b__15_0(Spine.Unity.SkeletonUtilityBone f);
                    /*0x81fdaec*/ UnityEngine.Vector3 <GetBoneFollowersPosition>b__16_0(Spine.Unity.SkeletonUtilityBone f);
                    /*0x81fdb14*/ UnityEngine.Vector3 <GetBoneFollowersPosition>b__16_2(Spine.Unity.SkeletonUtilityBone f);
                    /*0x81fdb3c*/ UnityEngine.Vector3 <GetBoneFollowersLocalPositions>b__18_0(Spine.Unity.SkeletonUtilityBone f);
                    /*0x81fdb64*/ UnityEngine.Vector3 <GetBoneFollowersLocalPosition>b__19_0(Spine.Unity.SkeletonUtilityBone f);
                    /*0x81fdb8c*/ UnityEngine.Vector3 <GetBoneFollowersLocalPosition>b__19_2(Spine.Unity.SkeletonUtilityBone f);
                }

                class <>c__DisplayClass16_0
                {
                    /*0x10*/ string boneName;

                    /*0x81fcba0*/ <>c__DisplayClass16_0();
                    /*0x81fdbb4*/ bool <GetBoneFollowersPosition>b__1(Spine.Unity.SkeletonUtilityBone f);
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ string boneName;

                    /*0x81fd0b0*/ <>c__DisplayClass19_0();
                    /*0x81fdbe0*/ bool <GetBoneFollowersLocalPosition>b__1(Spine.Unity.SkeletonUtilityBone f);
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ string key;
                    /*0x18*/ string defaultKey;

                    /*0x81fd240*/ <>c__DisplayClass23_0();
                    /*0x81fdc0c*/ bool <GetBoneFollowerGroup>b__0(Assets.Utilities.Spine.SkeletonUtilityBoneGroup g);
                    /*0x81fdc30*/ bool <GetBoneFollowerGroup>b__1(Assets.Utilities.Spine.SkeletonUtilityBoneGroup g);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ Assets.Utilities.Spine.SkeletonController <>4__this;
                    /*0x18*/ string animation;
                    /*0x20*/ string chainedAnimation;

                    /*0x81fd438*/ <>c__DisplayClass24_0();
                    /*0x81fdc54*/ void <SetAnimation>b__0(Spine.TrackEntry e);
                }
            }
        }

        namespace Illust
        {
            interface IIlust
            {
                /*0x3815ed0*/ void Apply(Assets.Utilities.Illust.IllustShapeTypes type);
            }

            class IllustBaseComponent : UnityEngine.MonoBehaviour
            {
                /*0x81fdc98*/ IllustBaseComponent();
            }

            class IllustComponent<T> : Assets.Utilities.Illust.IllustBaseComponent
            {
                /*0x0*/ T <Props>k__BackingField;

                /*0x38159dc*/ IllustComponent();
                /*0x3910ae8*/ T get_Props();
                /*0x3910ae8*/ void set_Props(T value);
            }

            enum IllustShapeTypes
            {
                None = 0,
                Size_188x188 = 1,
                Size_300x188 = 2,
                Size_188x240 = 3,
                Size_300x168 = 4,
                Size_188x512 = 5,
                Size_360x640 = 6,
                Size_180x512 = 7,
                Size_116x116 = 8,
                Size_300x144 = 9,
            }

            class IllustImageProp
            {
                /*0x10*/ float <Scale>k__BackingField;
                /*0x14*/ float <X>k__BackingField;
                /*0x18*/ float <Y>k__BackingField;

                /*0x81fdcd0*/ IllustImageProp();
                /*0x81fdca0*/ float get_Scale();
                /*0x81fdca8*/ void set_Scale(float value);
                /*0x81fdcb0*/ float get_X();
                /*0x81fdcb8*/ void set_X(float value);
                /*0x81fdcc0*/ float get_Y();
                /*0x81fdcc8*/ void set_Y(float value);
            }

            namespace Memory
            {
                class MemorySquareIllustComponent : Assets.Utilities.Illust.IllustComponent<Assets.Utilities.Illust.Memory.MemorySquareIllustProps>, Assets.Utilities.Illust.IIlust
                {
                    /*0x81fde4c*/ MemorySquareIllustComponent();
                    /*0x81fdce0*/ void Apply(Assets.Utilities.Illust.IllustShapeTypes type);
                }

                class MemorySquareIllustProps
                {
                    /*0x10*/ Assets.Utilities.Illust.IllustImageProp <Prop_300x168>k__BackingField;
                    /*0x18*/ Assets.Utilities.Illust.IllustImageProp <Prop_188x188>k__BackingField;

                    /*0x81fdeb4*/ MemorySquareIllustProps();
                    /*0x81fde94*/ Assets.Utilities.Illust.IllustImageProp get_Prop_300x168();
                    /*0x81fde9c*/ void set_Prop_300x168(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fdea4*/ Assets.Utilities.Illust.IllustImageProp get_Prop_188x188();
                    /*0x81fdeac*/ void set_Prop_188x188(Assets.Utilities.Illust.IllustImageProp value);
                }
            }

            namespace Machine
            {
                class MachineSquareIllustComponent : Assets.Utilities.Illust.IllustComponent<Assets.Utilities.Illust.Machine.MachineSquareIllustProps>, Assets.Utilities.Illust.IIlust
                {
                    /*0x81fe0a8*/ MachineSquareIllustComponent();
                    /*0x81fdf58*/ void Apply(Assets.Utilities.Illust.IllustShapeTypes type);
                }

                class MachineSquareIllustProps
                {
                    /*0x10*/ Assets.Utilities.Illust.IllustImageProp <Prop_300x168>k__BackingField;

                    /*0x81fe100*/ MachineSquareIllustProps();
                    /*0x81fe0f0*/ Assets.Utilities.Illust.IllustImageProp get_Prop_300x168();
                    /*0x81fe0f8*/ void set_Prop_300x168(Assets.Utilities.Illust.IllustImageProp value);
                }
            }

            namespace Character
            {
                class CharacterSquareIllustComponent : Assets.Utilities.Illust.IllustComponent<Assets.Utilities.Illust.Character.CharacterSquareIllustProps>, Assets.Utilities.Illust.IIlust
                {
                    /*0x81fe2c8*/ CharacterSquareIllustComponent();
                    /*0x81fe174*/ void Apply(Assets.Utilities.Illust.IllustShapeTypes type);
                }

                class CharacterSquareIllustProps
                {
                    /*0x10*/ Assets.Utilities.Illust.IllustImageProp <Prop_188x188>k__BackingField;
                    /*0x18*/ Assets.Utilities.Illust.IllustImageProp <Prop_300x188>k__BackingField;
                    /*0x20*/ Assets.Utilities.Illust.IllustImageProp <Prop_188x240>k__BackingField;
                    /*0x28*/ Assets.Utilities.Illust.IllustImageProp <Prop_300x168>k__BackingField;
                    /*0x30*/ Assets.Utilities.Illust.IllustImageProp <Prop_116x116>k__BackingField;
                    /*0x38*/ Assets.Utilities.Illust.IllustImageProp <Prop_300x144>k__BackingField;

                    /*0x81fe370*/ CharacterSquareIllustProps();
                    /*0x81fe310*/ Assets.Utilities.Illust.IllustImageProp get_Prop_188x188();
                    /*0x81fe318*/ void set_Prop_188x188(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe320*/ Assets.Utilities.Illust.IllustImageProp get_Prop_300x188();
                    /*0x81fe328*/ void set_Prop_300x188(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe330*/ Assets.Utilities.Illust.IllustImageProp get_Prop_188x240();
                    /*0x81fe338*/ void set_Prop_188x240(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe340*/ Assets.Utilities.Illust.IllustImageProp get_Prop_300x168();
                    /*0x81fe348*/ void set_Prop_300x168(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe350*/ Assets.Utilities.Illust.IllustImageProp get_Prop_116x116();
                    /*0x81fe358*/ void set_Prop_116x116(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe360*/ Assets.Utilities.Illust.IllustImageProp get_Prop_300x144();
                    /*0x81fe368*/ void set_Prop_300x144(Assets.Utilities.Illust.IllustImageProp value);
                }

                class CharacterVerticalIllustComponent : Assets.Utilities.Illust.IllustComponent<Assets.Utilities.Illust.Character.CharacterVerticalIllustProps>, Assets.Utilities.Illust.IIlust
                {
                    /*0x81fe638*/ CharacterVerticalIllustComponent();
                    /*0x81fe4b4*/ void Apply(Assets.Utilities.Illust.IllustShapeTypes type);
                }

                class CharacterVerticalIllustProps
                {
                    /*0x10*/ Assets.Utilities.Illust.IllustImageProp <Prop_180x512>k__BackingField;
                    /*0x18*/ Assets.Utilities.Illust.IllustImageProp <Prop_116x116>k__BackingField;
                    /*0x20*/ Assets.Utilities.Illust.IllustImageProp <Prop_360x640>k__BackingField;

                    /*0x81fe6b0*/ CharacterVerticalIllustProps();
                    /*0x81fe680*/ Assets.Utilities.Illust.IllustImageProp get_Prop_180x512();
                    /*0x81fe688*/ void set_Prop_180x512(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe690*/ Assets.Utilities.Illust.IllustImageProp get_Prop_116x116();
                    /*0x81fe698*/ void set_Prop_116x116(Assets.Utilities.Illust.IllustImageProp value);
                    /*0x81fe6a0*/ Assets.Utilities.Illust.IllustImageProp get_Prop_360x640();
                    /*0x81fe6a8*/ void set_Prop_360x640(Assets.Utilities.Illust.IllustImageProp value);
                }
            }
        }

        namespace FunctionalImage
        {
            class BackgroundComponent : UnityEngine.MonoBehaviour
            {
                /*0x20*/ Assets.Utilities.FunctionalImage.BackgroundComponent.LocatorPoint[] <LocatorPoints>k__BackingField;
                /*0x28*/ UnityEngine.CanvasGroup <CanvasGroup>k__BackingField;

                /*0x81fe79c*/ BackgroundComponent();
                /*0x81fe77c*/ Assets.Utilities.FunctionalImage.BackgroundComponent.LocatorPoint[] get_LocatorPoints();
                /*0x81fe784*/ void set_LocatorPoints(Assets.Utilities.FunctionalImage.BackgroundComponent.LocatorPoint[] value);
                /*0x81fe78c*/ UnityEngine.CanvasGroup get_CanvasGroup();
                /*0x81fe794*/ void set_CanvasGroup(UnityEngine.CanvasGroup value);

                class LocatorPoint
                {
                    /*0x10*/ long <Id>k__BackingField;
                    /*0x18*/ UnityEngine.Vector2 <LocalPosition>k__BackingField;
                    /*0x20*/ UnityEngine.Vector2 <LocalControlPosition>k__BackingField;

                    /*0x81fe7d4*/ LocatorPoint();
                    /*0x81fe7a4*/ long get_Id();
                    /*0x81fe7ac*/ void set_Id(long value);
                    /*0x81fe7b4*/ UnityEngine.Vector2 get_LocalPosition();
                    /*0x81fe7bc*/ void set_LocalPosition(UnityEngine.Vector2 value);
                    /*0x81fe7c4*/ UnityEngine.Vector2 get_LocalControlPosition();
                    /*0x81fe7cc*/ void set_LocalControlPosition(UnityEngine.Vector2 value);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 13F8940F122B0C04B42F33D47E711F2ADBA99629F205D79FECCF0C3DFF74490A;
    static /*0x676*/ <PrivateImplementationDetails> 242667B01BF93CBCD8C670FFD3D92F514BE27E81398F38B4E55302A610F33694;

    struct __StaticArrayInitTypeSize=1160
    {
    }

    struct __StaticArrayInitTypeSize=1654
    {
    }
}
