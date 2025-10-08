class <Module>
{
}

class AkEventPlayable : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ AK.Wwise.Event akEvent;
    /*0x20*/ AkCurveInterpolation blendInCurve;
    /*0x24*/ AkCurveInterpolation blendOutCurve;
    /*0x28*/ UnityEngine.ExposedReference<UnityEngine.GameObject> emitterObjectRef;
    /*0x38*/ float eventDurationMax;
    /*0x3c*/ float eventDurationMin;
    /*0x40*/ UnityEngine.Timeline.TimelineClip owningClip;
    /*0x48*/ bool retriggerEvent;
    /*0x49*/ bool UseWwiseEventDuration;
    /*0x4a*/ bool StopEventAtClipEnd;

    /*0x2157930*/ AkEventPlayable();
    /*0x2157660*/ UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps();
    /*0x2157668*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class AkEventPlayableBehavior : UnityEngine.Playables.PlayableBehaviour
{
    static uint CallbackFlags = 9;
    static int scrubPlaybackLengthMs = 100;
    static float alph = 0.05000000074505806;
    /*0x10*/ float currentDuration;
    /*0x14*/ float currentDurationProportion;
    /*0x18*/ bool eventIsPlaying;
    /*0x19*/ bool fadeinTriggered;
    /*0x1a*/ bool fadeoutTriggered;
    /*0x1c*/ float previousEventStartTime;
    /*0x20*/ AkEventPlayableBehavior.Actions requiredActions;
    /*0x28*/ AK.Wwise.Event akEvent;
    /*0x30*/ float eventDurationMax;
    /*0x34*/ float eventDurationMin;
    /*0x38*/ float blendInDuration;
    /*0x3c*/ float blendOutDuration;
    /*0x40*/ float easeInDuration;
    /*0x44*/ float easeOutDuration;
    /*0x48*/ AkCurveInterpolation blendInCurve;
    /*0x4c*/ AkCurveInterpolation blendOutCurve;
    /*0x50*/ UnityEngine.GameObject eventObject;
    /*0x58*/ bool retriggerEvent;
    /*0x59*/ bool wasScrubbingAndRequiresRetrigger;
    /*0x5a*/ bool StopEventAtClipEnd;
    /*0x5b*/ bool overrideTrackEmitterObject;

    /*0x2158774*/ AkEventPlayableBehavior();
    /*0x21579b4*/ void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
    /*0x2157a78*/ bool IsScrubbing(UnityEngine.Playables.FrameData info);
    /*0x2157a98*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x2157e70*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x2158060*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x2158168*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
    /*0x2157bc8*/ bool ShouldPlay(UnityEngine.Playables.Playable playable);
    /*0x2157d28*/ void CheckForFadeInFadeOut(UnityEngine.Playables.Playable playable);
    /*0x2157dcc*/ void CheckForFadeOut(UnityEngine.Playables.Playable playable, double currentClipTime);
    /*0x21584d4*/ void TriggerFadeIn(UnityEngine.Playables.Playable playable);
    /*0x21585d0*/ void TriggerFadeOut(UnityEngine.Playables.Playable playable);
    /*0x2158134*/ void StopEvent(int transition);
    /*0x21586c0*/ bool PostEvent();
    /*0x2158348*/ void PlayEvent();
    /*0x2158438*/ void RetriggerEvent(UnityEngine.Playables.Playable playable);
    /*0x2157f58*/ float GetProportionalTime(UnityEngine.Playables.Playable playable);
    /*0x215836c*/ float SeekToTime(UnityEngine.Playables.Playable playable);

    enum Actions
    {
        None = 0,
        Playback = 1,
        Retrigger = 2,
        DelayedStop = 4,
        Seek = 8,
        FadeIn = 16,
        FadeOut = 32,
    }
}

class AkEventTrack : UnityEngine.Timeline.TrackAsset
{
    /*0x2158b60*/ AkEventTrack();
    /*0x2158788*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
}

class AkRTPCPlayable : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ bool overrideTrackObject;
    /*0x20*/ UnityEngine.ExposedReference<UnityEngine.GameObject> RTPCObject;
    /*0x30*/ bool setRTPCGlobally;
    /*0x38*/ AkRTPCPlayableBehaviour template;
    /*0x40*/ AK.Wwise.RTPC <Parameter>k__BackingField;
    /*0x48*/ UnityEngine.Timeline.TimelineClip <OwningClip>k__BackingField;

    /*0x2158d68*/ AkRTPCPlayable();
    /*0x2158bb8*/ AK.Wwise.RTPC get_Parameter();
    /*0x2158bc0*/ void set_Parameter(AK.Wwise.RTPC value);
    /*0x2158bc8*/ UnityEngine.Timeline.TimelineClip get_OwningClip();
    /*0x2158bd0*/ void set_OwningClip(UnityEngine.Timeline.TimelineClip value);
    /*0x2158bd8*/ UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps();
    /*0x2158be0*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
}

class AkRTPCPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    /*0x10*/ float RTPCValue;
    /*0x14*/ bool <setRTPCGlobally>k__BackingField;
    /*0x15*/ bool <overrideTrackObject>k__BackingField;
    /*0x18*/ UnityEngine.GameObject <rtpcObject>k__BackingField;
    /*0x20*/ AK.Wwise.RTPC <parameter>k__BackingField;

    /*0x2158dd4*/ AkRTPCPlayableBehaviour();
    /*0x2158ddc*/ void set_setRTPCGlobally(bool value);
    /*0x2158de4*/ bool get_setRTPCGlobally();
    /*0x2158dec*/ void set_overrideTrackObject(bool value);
    /*0x2158df4*/ bool get_overrideTrackObject();
    /*0x2158dfc*/ void set_rtpcObject(UnityEngine.GameObject value);
    /*0x2158e04*/ UnityEngine.GameObject get_rtpcObject();
    /*0x2158e0c*/ void set_parameter(AK.Wwise.RTPC value);
    /*0x2158e14*/ AK.Wwise.RTPC get_parameter();
    /*0x2158e1c*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
}

class AkRTPCTrack : UnityEngine.Timeline.TrackAsset
{
    /*0xa0*/ AK.Wwise.RTPC Parameter;

    /*0x21596a8*/ AkRTPCTrack();
    /*0x2158f98*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
    /*0x215905c*/ void setPlayableProperties();
    /*0x2159394*/ void OnValidate();
}

class AkTimelineEventPlayableBehavior : UnityEngine.Playables.PlayableBehaviour
{
    static uint CallbackFlags = 9;
    static int scrubPlaybackLengthMs = 100;
    static float alph = 0.05000000074505806;
    /*0x10*/ float currentDuration;
    /*0x14*/ float currentDurationProportion;
    /*0x18*/ float previousEventStartTime;
    /*0x1c*/ uint playingId;
    /*0x20*/ AkTimelineEventPlayableBehavior.Actions requiredActions;
    /*0x28*/ AK.Wwise.Event akEvent;
    /*0x30*/ float eventDurationMax;
    /*0x34*/ float eventDurationMin;
    /*0x38*/ float blendInDuration;
    /*0x3c*/ float blendOutDuration;
    /*0x40*/ float easeInDuration;
    /*0x44*/ float easeOutDuration;
    /*0x48*/ AkCurveInterpolation blendInCurve;
    /*0x4c*/ AkCurveInterpolation blendOutCurve;
    /*0x50*/ UnityEngine.GameObject eventObject;
    /*0x58*/ bool retriggerEvent;
    /*0x59*/ bool wasScrubbingAndRequiresRetrigger;
    /*0x5a*/ bool StopEventAtClipEnd;
    /*0x5b*/ bool PrintDebugInformation;

    /*0x215abf4*/ AkTimelineEventPlayableBehavior();
    /*0x2159700*/ bool get_eventIsPlaying();
    /*0x2159710*/ void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
    /*0x2159848*/ bool IsScrubbing(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x2159954*/ void PrintInfo(string FunctionName, UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x2159e08*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x215a21c*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x215a46c*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
    /*0x215a578*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
    /*0x2159f80*/ bool ShouldPlay(UnityEngine.Playables.Playable playable);
    /*0x215a0d4*/ void CheckForFadeInFadeOut(UnityEngine.Playables.Playable playable);
    /*0x215a178*/ void CheckForFadeOut(UnityEngine.Playables.Playable playable, double currentClipTime);
    /*0x215aa28*/ void TriggerFadeIn(UnityEngine.Playables.Playable playable);
    /*0x215a91c*/ void TriggerFadeOut(UnityEngine.Playables.Playable playable);
    /*0x21597dc*/ void StopEvent(int transition);
    /*0x215ab34*/ bool PostEvent();
    /*0x215a778*/ void PlayEvent();
    /*0x215a880*/ void RetriggerEvent(UnityEngine.Playables.Playable playable);
    /*0x215a364*/ float GetProportionalTime(UnityEngine.Playables.Playable playable);
    /*0x215a79c*/ float SeekToTime(UnityEngine.Playables.Playable playable);

    enum Actions
    {
        None = 0,
        Playback = 1,
        Retrigger = 2,
        DelayedStop = 4,
        Seek = 8,
        FadeIn = 16,
        FadeOut = 32,
    }
}

class AkTimelineEventPlayable : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ AK.Wwise.Event akEvent;
    /*0x20*/ AkCurveInterpolation blendInCurve;
    /*0x24*/ AkCurveInterpolation blendOutCurve;
    /*0x28*/ float eventDurationMax;
    /*0x2c*/ float eventDurationMin;
    /*0x30*/ UnityEngine.Timeline.TimelineClip owningClip;
    /*0x38*/ bool retriggerEvent;
    /*0x39*/ bool UseWwiseEventDuration;
    /*0x3a*/ bool PrintDebugInformation;
    /*0x3b*/ bool StopEventAtClipEnd;

    /*0x215ae4c*/ AkTimelineEventPlayable();
    /*0x215ac08*/ UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps();
    /*0x215ac10*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
}

class AkTimelineEventTrack : UnityEngine.Timeline.TrackAsset
{
    /*0x215b2a8*/ AkTimelineEventTrack();
    /*0x215aed0*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
}

class AkTimelineRtpcPlayableBehaviour : UnityEngine.Playables.PlayableBehaviour
{
    /*0x10*/ float value;
    /*0x18*/ AK.Wwise.RTPC <RTPC>k__BackingField;
    /*0x20*/ bool <setGlobally>k__BackingField;
    /*0x28*/ UnityEngine.GameObject <gameObject>k__BackingField;

    /*0x215b488*/ AkTimelineRtpcPlayableBehaviour();
    /*0x215b300*/ void set_RTPC(AK.Wwise.RTPC value);
    /*0x215b308*/ AK.Wwise.RTPC get_RTPC();
    /*0x215b310*/ void set_setGlobally(bool value);
    /*0x215b318*/ bool get_setGlobally();
    /*0x215b320*/ void set_gameObject(UnityEngine.GameObject value);
    /*0x215b328*/ UnityEngine.GameObject get_gameObject();
    /*0x215b330*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData, object playerData);
}

class AkTimelineRtpcPlayable : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset
{
    /*0x18*/ AK.Wwise.RTPC RTPC;
    /*0x20*/ bool setGlobally;
    /*0x28*/ AkTimelineRtpcPlayableBehaviour template;
    /*0x30*/ UnityEngine.Timeline.TimelineClip <owningClip>k__BackingField;

    /*0x215b5cc*/ AkTimelineRtpcPlayable();
    /*0x215b490*/ void SetupClipDisplay();
    /*0x215b494*/ UnityEngine.Timeline.TimelineClip get_owningClip();
    /*0x215b49c*/ void set_owningClip(UnityEngine.Timeline.TimelineClip value);
    /*0x215b4a4*/ UnityEngine.Timeline.ClipCaps UnityEngine.Timeline.ITimelineClipAsset.get_clipCaps();
    /*0x215b4ac*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject);
}

class AkTimelineRtpcTrack : UnityEngine.Timeline.TrackAsset
{
    /*0x215bd20*/ AkTimelineRtpcTrack();
    /*0x215b678*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, int inputCount);
    /*0x215ba24*/ void OnValidate();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x215bd78*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x215be6c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 6CB86F027412330B66BC359A9DD56825DBFF4F9C7CDBCBC55D11F56F5CF61BA5;
    static /*0x219*/ <PrivateImplementationDetails> A56239F2F8943F3BB7F0B4ABAFC12808E2355E27A731B71CD114B255534AAF99;

    struct __StaticArrayInitTypeSize=316
    {
    }

    struct __StaticArrayInitTypeSize=537
    {
    }
}
