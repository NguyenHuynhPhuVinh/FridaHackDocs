class <Module>
{
}

namespace UnityEngine
{
    namespace Timeline
    {
        class AnimationOutputWeightProcessor : UnityEngine.Timeline.ITimelineEvaluateCallback
        {
            /*0x10*/ UnityEngine.Animations.AnimationPlayableOutput m_Output;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.AnimationOutputWeightProcessor.WeightInfo> m_Mixers;

            /*0x7da4b74*/ AnimationOutputWeightProcessor(UnityEngine.Animations.AnimationPlayableOutput output);
            /*0x7da4c40*/ void FindMixers();
            /*0x7da4d28*/ void FindMixers(UnityEngine.Playables.Playable parent, int port, UnityEngine.Playables.Playable node);
            /*0x7da5010*/ void Evaluate();

            struct WeightInfo
            {
                /*0x10*/ UnityEngine.Playables.Playable mixer;
                /*0x20*/ UnityEngine.Playables.Playable parentMixer;
                /*0x30*/ int port;
            }
        }

        class AnimationPlayableAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.IPropertyPreview, UnityEngine.ISerializationCallbackReceiver
        {
            static /*0x0*/ int k_LatestVersion;
            /*0x18*/ UnityEngine.AnimationClip m_Clip;
            /*0x20*/ UnityEngine.Vector3 m_Position;
            /*0x2c*/ UnityEngine.Vector3 m_EulerAngles;
            /*0x38*/ bool m_UseTrackMatchFields;
            /*0x3c*/ UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;
            /*0x40*/ bool m_RemoveStartOffset;
            /*0x41*/ bool m_ApplyFootIK;
            /*0x44*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode m_Loop;
            /*0x48*/ UnityEngine.Timeline.AppliedOffsetMode <appliedOffsetMode>k__BackingField;
            /*0x4c*/ int m_Version;
            /*0x50*/ UnityEngine.Quaternion m_Rotation;

            static /*0x7da6250*/ AnimationPlayableAsset();
            static /*0x7da59a8*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, bool removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, bool applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop);
            static /*0x7da5d98*/ bool ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip);
            static /*0x7da5d70*/ bool ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x7da5490*/ bool HasRootTransforms(UnityEngine.AnimationClip clip);
            /*0x7da614c*/ AnimationPlayableAsset();
            /*0x7da5300*/ UnityEngine.Vector3 get_position();
            /*0x7da530c*/ void set_position(UnityEngine.Vector3 value);
            /*0x7da5318*/ UnityEngine.Quaternion get_rotation();
            /*0x7da533c*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x7da5378*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x7da5384*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x7da5390*/ bool get_useTrackMatchFields();
            /*0x7da5398*/ void set_useTrackMatchFields(bool value);
            /*0x7da53a4*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x7da53ac*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x7da53b4*/ bool get_removeStartOffset();
            /*0x7da53bc*/ void set_removeStartOffset(bool value);
            /*0x7da53c8*/ bool get_applyFootIK();
            /*0x7da53d0*/ void set_applyFootIK(bool value);
            /*0x7da53dc*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_loop();
            /*0x7da53e4*/ void set_loop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x7da53ec*/ bool get_hasRootTransforms();
            /*0x7da555c*/ UnityEngine.Timeline.AppliedOffsetMode get_appliedOffsetMode();
            /*0x7da5564*/ void set_appliedOffsetMode(UnityEngine.Timeline.AppliedOffsetMode value);
            /*0x7da556c*/ UnityEngine.AnimationClip get_clip();
            /*0x7da5574*/ void set_clip(UnityEngine.AnimationClip value);
            /*0x7da563c*/ double get_duration();
            /*0x7da5820*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7da58d0*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x7da5e0c*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7da5ef4*/ void ResetOffsets();
            /*0x7da5f60*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7da600c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7da606c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7da60f0*/ void OnUpgradeFromVersion(int oldVersion);

            enum LoopMode
            {
                UseSourceAsset = 0,
                On = 1,
                Off = 2,
            }

            class AnimationPlayableAssetUpgrade
            {
                static /*0x7da6100*/ void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset);
            }

            class <get_outputs>d__45 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationPlayableAsset <>4__this;

                /*0x7da589c*/ <get_outputs>d__45(int <>1__state);
                /*0x7da629c*/ void System.IDisposable.Dispose();
                /*0x7da62a0*/ bool MoveNext();
                /*0x7da633c*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7da634c*/ void System.Collections.IEnumerator.Reset();
                /*0x7da6384*/ object System.Collections.IEnumerator.get_Current();
                /*0x7da63e4*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7da6488*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        enum MatchTargetFields
        {
            PositionX = 1,
            PositionY = 2,
            PositionZ = 4,
            RotationX = 8,
            RotationY = 16,
            RotationZ = 32,
        }

        enum TrackOffset
        {
            ApplyTransformOffsets = 0,
            ApplySceneOffsets = 1,
            Auto = 2,
        }

        enum AppliedOffsetMode
        {
            NoRootTransform = 0,
            TransformOffset = 1,
            SceneOffset = 2,
            TransformOffsetLegacy = 3,
            SceneOffsetLegacy = 4,
            SceneOffsetEditor = 5,
            SceneOffsetLegacyEditor = 6,
        }

        class MatchTargetFieldConstants
        {
            static /*0x0*/ UnityEngine.Timeline.MatchTargetFields All;
            static /*0x4*/ UnityEngine.Timeline.MatchTargetFields None;
            static /*0x8*/ UnityEngine.Timeline.MatchTargetFields Position;
            static /*0xc*/ UnityEngine.Timeline.MatchTargetFields Rotation;

            static /*0x7da648c*/ MatchTargetFieldConstants();
        }

        class AnimationTrack : UnityEngine.Timeline.TrackAsset, UnityEngine.Timeline.ILayerable
        {
            static string k_DefaultInfiniteClipName = "Recorded";
            static string k_DefaultRecordableClipName = "Recorded";
            static /*0x0*/ System.Collections.Generic.Queue<UnityEngine.Transform> s_CachedQueue;
            /*0xa0*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPreExtrapolation;
            /*0xa4*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_InfiniteClipPostExtrapolation;
            /*0xa8*/ UnityEngine.Vector3 m_InfiniteClipOffsetPosition;
            /*0xb4*/ UnityEngine.Vector3 m_InfiniteClipOffsetEulerAngles;
            /*0xc0*/ double m_InfiniteClipTimeOffset;
            /*0xc8*/ bool m_InfiniteClipRemoveOffset;
            /*0xc9*/ bool m_InfiniteClipApplyFootIK;
            /*0xcc*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode mInfiniteClipLoop;
            /*0xd0*/ UnityEngine.Timeline.MatchTargetFields m_MatchTargetFields;
            /*0xd4*/ UnityEngine.Vector3 m_Position;
            /*0xe0*/ UnityEngine.Vector3 m_EulerAngles;
            /*0xf0*/ UnityEngine.AvatarMask m_AvatarMask;
            /*0xf8*/ bool m_ApplyAvatarMask;
            /*0xfc*/ UnityEngine.Timeline.TrackOffset m_TrackOffset;
            /*0x100*/ UnityEngine.AnimationClip m_InfiniteClip;
            /*0x108*/ UnityEngine.Quaternion m_OpenClipOffsetRotation;
            /*0x118*/ UnityEngine.Quaternion m_Rotation;
            /*0x128*/ bool m_ApplyOffsets;

            static /*0x7daaadc*/ AnimationTrack();
            static /*0x7da9578*/ bool UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x7da9078*/ UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            static /*0x7daa478*/ UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, string name);
            /*0x7daa860*/ AnimationTrack();
            /*0x7da64dc*/ UnityEngine.Vector3 get_position();
            /*0x7da64e8*/ void set_position(UnityEngine.Vector3 value);
            /*0x7da64f4*/ UnityEngine.Quaternion get_rotation();
            /*0x7da6518*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x7da6554*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x7da6560*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x7da656c*/ bool get_applyOffsets();
            /*0x7da6574*/ void set_applyOffsets(bool value);
            /*0x7da6578*/ UnityEngine.Timeline.TrackOffset get_trackOffset();
            /*0x7da6580*/ void set_trackOffset(UnityEngine.Timeline.TrackOffset value);
            /*0x7da6588*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x7da6590*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x7da6600*/ UnityEngine.AnimationClip get_infiniteClip();
            /*0x7da6608*/ void set_infiniteClip(UnityEngine.AnimationClip value);
            /*0x7da6618*/ bool get_infiniteClipRemoveOffset();
            /*0x7da6620*/ void set_infiniteClipRemoveOffset(bool value);
            /*0x7da662c*/ UnityEngine.AvatarMask get_avatarMask();
            /*0x7da6634*/ void set_avatarMask(UnityEngine.AvatarMask value);
            /*0x7da663c*/ bool get_applyAvatarMask();
            /*0x7da6644*/ void set_applyAvatarMask(bool value);
            /*0x7da6650*/ bool CanCompileClips();
            /*0x7da670c*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7da67bc*/ bool get_inClipMode();
            /*0x7da68c0*/ UnityEngine.Vector3 get_infiniteClipOffsetPosition();
            /*0x7da68cc*/ void set_infiniteClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x7da68d8*/ UnityEngine.Quaternion get_infiniteClipOffsetRotation();
            /*0x7da68fc*/ void set_infiniteClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x7da6938*/ UnityEngine.Vector3 get_infiniteClipOffsetEulerAngles();
            /*0x7da6944*/ void set_infiniteClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x7da6950*/ bool get_infiniteClipApplyFootIK();
            /*0x7da6958*/ void set_infiniteClipApplyFootIK(bool value);
            /*0x7da6964*/ double get_infiniteClipTimeOffset();
            /*0x7da696c*/ void set_infiniteClipTimeOffset(double value);
            /*0x7da6974*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation();
            /*0x7da697c*/ void set_infiniteClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7da6984*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation();
            /*0x7da698c*/ void set_infiniteClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7da6994*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_infiniteClipLoop();
            /*0x7da699c*/ void set_infiniteClipLoop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x7da69a4*/ void ResetOffsets();
            /*0x7da6a14*/ UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip);
            /*0x7da6cf0*/ void CreateInfiniteClip(string infiniteClipName);
            /*0x7da6fbc*/ UnityEngine.Timeline.TimelineClip CreateRecordableClip(string animClipName);
            /*0x7da735c*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7da7518*/ int CalculateItemsHash();
            /*0x7da6a10*/ void UpdateClipOffsets();
            /*0x7da7740*/ UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x7da8108*/ UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x7da8158*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x7da9070*/ int GetDefaultBlendCount();
            /*0x7da9574*/ void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, bool requireOffset);
            /*0x7da9590*/ UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7da9464*/ bool RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject);
            /*0x7da98cc*/ bool HasController(UnityEngine.GameObject gameObject);
            /*0x7da96e8*/ UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x7da90ec*/ UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x7da7f58*/ UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x7da9a18*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x7da9ca8*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x7da6abc*/ void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip);
            /*0x7da9f14*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7da9f18*/ void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips);
            /*0x7da8f8c*/ UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, bool animatesRootTransform);
            /*0x7da8d10*/ bool IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode);
            /*0x7da8b28*/ UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject);
            /*0x7da7b8c*/ bool AnimatesRootTransform();
            /*0x7daa650*/ UnityEngine.Vector3 get_openClipOffsetPosition();
            /*0x7daa65c*/ void set_openClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x7daa668*/ UnityEngine.Quaternion get_openClipOffsetRotation();
            /*0x7daa68c*/ void set_openClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x7daa690*/ UnityEngine.Vector3 get_openClipOffsetEulerAngles();
            /*0x7daa69c*/ void set_openClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x7daa6a8*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPreExtrapolation();
            /*0x7daa6b0*/ void set_openClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7daa6b8*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPostExtrapolation();
            /*0x7daa6c0*/ void set_openClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7daa6c8*/ void OnUpgradeFromVersion(int oldVersion);

            class AnimationTrackUpgrade
            {
                static /*0x7daa70c*/ void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track);
                static /*0x7daa7a8*/ void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track);
                static /*0x7daa82c*/ void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track);
            }

            class <get_outputs>d__49 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationTrack <>4__this;

                /*0x7da6788*/ <get_outputs>d__49(int <>1__state);
                /*0x7daab78*/ void System.IDisposable.Dispose();
                /*0x7daab7c*/ bool MoveNext();
                /*0x7daac18*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7daac28*/ void System.Collections.IEnumerator.Reset();
                /*0x7daac60*/ object System.Collections.IEnumerator.get_Current();
                /*0x7daacc0*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7daad64*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        interface ICurvesOwner
        {
            /*0x38148bc*/ string get_defaultCurvesName();
            /*0x38148bc*/ UnityEngine.Object get_asset();
            /*0x38148bc*/ UnityEngine.Object get_assetOwner();
            /*0x38148bc*/ UnityEngine.Timeline.TrackAsset get_targetTrack();
        }

        class TimelineClip : UnityEngine.Timeline.ICurvesOwner, UnityEngine.ISerializationCallbackReceiver
        {
            static int k_LatestVersion = 1;
            static /*0x0*/ UnityEngine.Timeline.ClipCaps kDefaultClipCaps;
            static /*0x4*/ float kDefaultClipDurationInSeconds;
            static /*0x8*/ double kTimeScaleMin;
            static /*0x10*/ double kTimeScaleMax;
            static /*0x18*/ string kDefaultCurvesName;
            static /*0x20*/ double kMinDuration;
            static /*0x28*/ double kMaxTimeValue;
            /*0x10*/ int m_Version;
            /*0x18*/ double m_Start;
            /*0x20*/ double m_ClipIn;
            /*0x28*/ UnityEngine.Object m_Asset;
            /*0x30*/ double m_Duration;
            /*0x38*/ double m_TimeScale;
            /*0x40*/ UnityEngine.Timeline.TrackAsset m_ParentTrack;
            /*0x48*/ double m_EaseInDuration;
            /*0x50*/ double m_EaseOutDuration;
            /*0x58*/ double m_BlendInDuration;
            /*0x60*/ double m_BlendOutDuration;
            /*0x68*/ UnityEngine.AnimationCurve m_MixInCurve;
            /*0x70*/ UnityEngine.AnimationCurve m_MixOutCurve;
            /*0x78*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendInCurveMode;
            /*0x7c*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode m_BlendOutCurveMode;
            /*0x80*/ System.Collections.Generic.List<string> m_ExposedParameterNames;
            /*0x88*/ UnityEngine.AnimationClip m_AnimationCurves;
            /*0x90*/ bool m_Recordable;
            /*0x94*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PostExtrapolationMode;
            /*0x98*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation m_PreExtrapolationMode;
            /*0xa0*/ double m_PostExtrapolationTime;
            /*0xa8*/ double m_PreExtrapolationTime;
            /*0xb0*/ string m_DisplayName;

            static /*0x7dac3b0*/ TimelineClip();
            static /*0x7dab8d0*/ UnityEngine.AnimationCurve GetDefaultMixInCurve();
            static /*0x7dab9c8*/ UnityEngine.AnimationCurve GetDefaultMixOutCurve();
            static /*0x7dab0f4*/ double SanitizeTimeValue(double value, double defaultValue);
            static /*0x7dabeac*/ double GetExtrapolatedTime(double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, double duration);
            /*0x7daade0*/ TimelineClip(UnityEngine.Timeline.TrackAsset parent);
            /*0x7daad68*/ void UpgradeToLatestVersion();
            /*0x7daaf24*/ double get_timeScale();
            /*0x7dab0ec*/ double get_start();
            /*0x7da7104*/ void set_start(double value);
            /*0x7dab2c0*/ double get_duration();
            /*0x7da7244*/ void set_duration(double value);
            /*0x7dab2c8*/ double get_end();
            /*0x7dab2d8*/ double get_clipIn();
            /*0x7dab2f8*/ string get_displayName();
            /*0x7dab300*/ void set_displayName(string value);
            /*0x7dab308*/ UnityEngine.AnimationClip get_curves();
            /*0x7dab310*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x7dab368*/ UnityEngine.Object get_asset();
            /*0x7dab370*/ void set_asset(UnityEngine.Object value);
            /*0x7dab378*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x7dab380*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x7dab388*/ UnityEngine.Timeline.TrackAsset GetParentTrack();
            /*0x7daae1c*/ void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack);
            /*0x7dab50c*/ double get_easeInDuration();
            /*0x7dab5f4*/ double get_easeOutDuration();
            /*0x7dab6dc*/ double get_blendInDuration();
            /*0x7dab6fc*/ void set_blendInDuration(double value);
            /*0x7dab784*/ double get_blendOutDuration();
            /*0x7dab7a4*/ void set_blendOutDuration(double value);
            /*0x7dab82c*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode get_blendInCurveMode();
            /*0x7dab834*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode get_blendOutCurveMode();
            /*0x7dab6b0*/ bool get_hasBlendIn();
            /*0x7dab5c8*/ bool get_hasBlendOut();
            /*0x7dab83c*/ UnityEngine.AnimationCurve get_mixInCurve();
            /*0x7dab8e8*/ void set_mixInCurve(UnityEngine.AnimationCurve value);
            /*0x7dab8f0*/ double get_mixInDuration();
            /*0x7dab934*/ UnityEngine.AnimationCurve get_mixOutCurve();
            /*0x7dab9e0*/ void set_mixOutCurve(UnityEngine.AnimationCurve value);
            /*0x7dab9e8*/ double get_mixOutTime();
            /*0x7daba14*/ double get_mixOutDuration();
            /*0x7daba58*/ bool get_recordable();
            /*0x7daba60*/ void set_recordable(bool value);
            /*0x7daaffc*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7daba6c*/ int Hash();
            /*0x7dabba4*/ float EvaluateMixOut(double time);
            /*0x7dabc98*/ float EvaluateMixIn(double time);
            /*0x7dabd6c*/ double ToLocalTime(double time);
            /*0x7dac020*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_postExtrapolationMode();
            /*0x7da74e4*/ void set_postExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7dac044*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_preExtrapolationMode();
            /*0x7da74b0*/ void set_preExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7dac068*/ void SetPostExtrapolationTime(double time);
            /*0x7dac070*/ void SetPreExtrapolationTime(double time);
            /*0x7dabe5c*/ bool IsPreExtrapolatedTime(double sequenceTime);
            /*0x7dabfc8*/ bool IsPostExtrapolatedTime(double sequenceTime);
            /*0x7dac078*/ double get_extrapolatedStart();
            /*0x7dac090*/ double get_extrapolatedDuration();
            /*0x7dac15c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7dac168*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7dac1a4*/ string ToString();
            /*0x7dab210*/ void UpdateDirty(double oldValue, double newValue);

            class TimelineClipUpgrade
            {
                static /*0x7daada4*/ void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip);
            }

            enum ClipExtrapolation
            {
                None = 0,
                Hold = 1,
                Loop = 2,
                PingPong = 3,
                Continue = 4,
            }

            enum BlendCurveMode
            {
                Auto = 0,
                Manual = 1,
            }
        }

        class TimelineAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.ITimelineClipAsset, UnityEngine.Timeline.IPropertyPreview
        {
            static int k_LatestVersion = 0;
            /*0x18*/ int m_Version;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Tracks;
            /*0x28*/ double m_FixedDuration;
            /*0x30*/ UnityEngine.Timeline.TrackAsset[] m_CacheOutputTracks;
            /*0x38*/ System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> m_CacheRootTracks;
            /*0x40*/ UnityEngine.Timeline.TrackAsset[] m_CacheFlattenedTracks;
            /*0x48*/ UnityEngine.Timeline.TimelineAsset.EditorSettings m_EditorSettings;
            /*0x50*/ UnityEngine.Timeline.TimelineAsset.DurationMode m_DurationMode;
            /*0x58*/ UnityEngine.Timeline.MarkerTrack m_MarkerTrack;

            static /*0x7dad2f0*/ double GetValidFrameRate(double frameRate);
            static /*0x7dad5d8*/ void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, ref System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> allTracks);
            /*0x7db0800*/ TimelineAsset();
            /*0x7dac440*/ void UpgradeToLatestVersion();
            /*0x7dac444*/ UnityEngine.Timeline.TimelineAsset.EditorSettings get_editorSettings();
            /*0x7dac44c*/ double get_duration();
            /*0x7dac6f4*/ double get_fixedDuration();
            /*0x7dac7c4*/ void set_fixedDuration(double value);
            /*0x7dac834*/ UnityEngine.Timeline.TimelineAsset.DurationMode get_durationMode();
            /*0x7dac83c*/ void set_durationMode(UnityEngine.Timeline.TimelineAsset.DurationMode value);
            /*0x7dac844*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7dac8f4*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7dacc58*/ int get_outputTrackCount();
            /*0x7dacec8*/ int get_rootTrackCount();
            /*0x7dad2c8*/ void OnValidate();
            /*0x7dad3b4*/ UnityEngine.Timeline.TrackAsset GetRootTrack(int index);
            /*0x7dacc40*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks();
            /*0x7dad414*/ UnityEngine.Timeline.TrackAsset GetOutputTrack(int index);
            /*0x7dad458*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks();
            /*0x7dacf18*/ void UpdateRootTrackCache();
            /*0x7dacc7c*/ void UpdateOutputTrackCache();
            /*0x7dad470*/ UnityEngine.Timeline.TrackAsset[] get_flattenedTracks();
            /*0x7dad928*/ UnityEngine.Timeline.MarkerTrack get_markerTrack();
            /*0x7dad930*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_trackObjects();
            /*0x7dad938*/ void AddTrackInternal(UnityEngine.Timeline.TrackAsset track);
            /*0x7dada34*/ void RemoveTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x7dadbc0*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x7dadf98*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7dadfa0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7dadfa4*/ void __internalAwake();
            /*0x7dae128*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7dae5e4*/ void CreateMarkerTrack();
            /*0x7dae7cc*/ void RemoveMarkerTrack();
            /*0x7dad9fc*/ void Invalidate();
            /*0x7dae910*/ void UpdateFixedDurationWithItemsDuration();
            /*0x7dac4fc*/ UnityEngine.Timeline.DiscreteTime CalculateItemsDuration();
            /*0x7daeaac*/ UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, string name);
            /*0x3910ae8*/ T CreateTrack<T>(UnityEngine.Timeline.TrackAsset parent, string trackName);
            /*0x3910ae8*/ T CreateTrack<T>(string trackName);
            /*0x3910ae8*/ T CreateTrack<T>();
            /*0x7daf758*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7dafe90*/ bool DeleteTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x7db04fc*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x7daf4f8*/ UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, string trackName, System.Type trackType);
            /*0x7db03cc*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track);
            /*0x7daf98c*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip);

            enum DurationMode
            {
                BasedOnClips = 0,
                FixedLength = 1,
            }

            class EditorSettings
            {
                static /*0x0*/ double kMinFrameRate;
                static /*0x8*/ double kMaxFrameRate;
                static /*0x10*/ double kDefaultFrameRate;
                /*0x10*/ double m_Framerate;
                /*0x18*/ bool m_ScenePreview;

                static /*0x7db08e0*/ EditorSettings();
                /*0x7db0868*/ EditorSettings();
                /*0x7db08d8*/ double get_frameRate();
                /*0x7dad39c*/ void set_frameRate(double value);
            }

            class <get_outputs>d__27 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TimelineAsset <>4__this;
                /*0x48*/ System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TrackAsset> <>7__wrap1;
                /*0x50*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> <>7__wrap2;

                /*0x7dac8c0*/ <get_outputs>d__27(int <>1__state);
                /*0x7db0964*/ void System.IDisposable.Dispose();
                /*0x7db0a14*/ bool MoveNext();
                /*0x7db0f50*/ void <>m__Finally1();
                /*0x7db0ea0*/ void <>m__Finally2();
                /*0x7db1000*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7db1010*/ void System.Collections.IEnumerator.Reset();
                /*0x7db1048*/ object System.Collections.IEnumerator.get_Current();
                /*0x7db10a8*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7db114c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TrackAsset : UnityEngine.Playables.PlayableAsset, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Timeline.IPropertyPreview, UnityEngine.Timeline.ICurvesOwner
        {
            static int k_LatestVersion = 3;
            static string kDefaultCurvesName = "Track Parameters";
            static /*0x0*/ UnityEngine.Timeline.TrackAsset.TransientBuildData s_BuildData;
            static /*0x18*/ System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> OnClipPlayableCreate;
            static /*0x20*/ System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> OnTrackAnimationPlayableCreate;
            static /*0x28*/ UnityEngine.Timeline.TrackAsset[] s_EmptyCache;
            static /*0x30*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.Timeline.TrackBindingTypeAttribute> s_TrackBindingTypeAttributeCache;
            /*0x18*/ int m_Version;
            /*0x20*/ UnityEngine.AnimationClip m_AnimClip;
            /*0x28*/ bool m_Locked;
            /*0x29*/ bool m_Muted;
            /*0x30*/ string m_CustomPlayableFullTypename;
            /*0x38*/ UnityEngine.AnimationClip m_Curves;
            /*0x40*/ UnityEngine.Playables.PlayableAsset m_Parent;
            /*0x48*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Children;
            /*0x50*/ int m_ItemsHash;
            /*0x58*/ UnityEngine.Timeline.TimelineClip[] m_ClipsCache;
            /*0x60*/ UnityEngine.Timeline.DiscreteTime m_Start;
            /*0x68*/ UnityEngine.Timeline.DiscreteTime m_End;
            /*0x70*/ bool m_CacheSorted;
            /*0x71*/ bool m_BlendsValid;
            /*0x72*/ System.Nullable<bool> m_SupportsNotifications;
            /*0x78*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> m_ChildTrackCache;
            /*0x80*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> m_Clips;
            /*0x88*/ UnityEngine.Timeline.MarkerList m_Markers;

            static /*0x7db7610*/ TrackAsset();
            static /*0x7db17d8*/ void add_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7db18cc*/ void remove_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7db19c0*/ void add_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7db1ab4*/ void remove_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7da7598*/ int GetAnimationClipHash(UnityEngine.AnimationClip clip);
            /*0x7daa9f0*/ TrackAsset();
            /*0x7db1150*/ void OnBeforeTrackSerialize();
            /*0x7db1154*/ void OnAfterTrackDeserialize();
            /*0x7db1158*/ void OnUpgradeFromVersion(int oldVersion);
            /*0x7db115c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7db1358*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7db17b8*/ void UpgradeToLatestVersion();
            /*0x7db1ba8*/ double get_start();
            /*0x7dae9e4*/ double get_end();
            /*0x7db1d10*/ double get_duration();
            /*0x7db1d78*/ bool get_muted();
            /*0x7db1d80*/ void set_muted(bool value);
            /*0x7dae440*/ bool get_mutedInHierarchy();
            /*0x7daed90*/ UnityEngine.Timeline.TimelineAsset get_timelineAsset();
            /*0x7db1d8c*/ UnityEngine.Playables.PlayableAsset get_parent();
            /*0x7db1d94*/ void set_parent(UnityEngine.Playables.PlayableAsset value);
            /*0x7daa64c*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips();
            /*0x7da67f0*/ UnityEngine.Timeline.TimelineClip[] get_clips();
            /*0x7db1d9c*/ bool get_blendsValid();
            /*0x7db1da4*/ void set_blendsValid(bool value);
            /*0x7db1db0*/ bool get_isEmpty();
            /*0x7db1e1c*/ bool get_hasClips();
            /*0x7db1e70*/ bool get_hasCurves();
            /*0x7da739c*/ bool get_isSubTrack();
            /*0x7db1f04*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7da8f74*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks();
            /*0x7db21e8*/ string get_customPlayableTypename();
            /*0x7db21f0*/ void set_customPlayableTypename(string value);
            /*0x7db21f8*/ UnityEngine.AnimationClip get_curves();
            /*0x7db2200*/ void set_curves(UnityEngine.AnimationClip value);
            /*0x7db2208*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x7db2248*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_asset();
            /*0x7db224c*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x7db2250*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x7db2254*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_subTracksObjects();
            /*0x7db225c*/ bool get_locked();
            /*0x7db2264*/ void set_locked(bool value);
            /*0x7db2270*/ bool get_lockedInHierarchy();
            /*0x7db2414*/ bool get_supportsNotifications();
            /*0x7db2638*/ void __internalAwake();
            /*0x7db2728*/ void CreateCurves(string curvesClipName);
            /*0x7db27f4*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x7db2864*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x7db28b4*/ UnityEngine.Timeline.TimelineClip CreateDefaultClip();
            /*0x38148bc*/ UnityEngine.Timeline.TimelineClip CreateClip<T>();
            /*0x7db2ba4*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7db2cb4*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time);
            /*0x3910ae8*/ T CreateMarker<T>(double time);
            /*0x7db2fa8*/ bool DeleteMarker(UnityEngine.Timeline.IMarker marker);
            /*0x7db17bc*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x7db1efc*/ int GetMarkerCount();
            /*0x7db31f0*/ UnityEngine.Timeline.IMarker GetMarker(int idx);
            /*0x7db3258*/ UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType);
            /*0x7db2b74*/ UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType);
            /*0x7db35cc*/ UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType);
            /*0x7db39f8*/ UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset);
            /*0x7db3778*/ UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset);
            /*0x7db3e8c*/ System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw();
            /*0x7db3e94*/ void ClearMarkers();
            /*0x7db3f0c*/ void AddMarker(UnityEngine.ScriptableObject e);
            /*0x7db4008*/ bool DeleteMarkerRaw(UnityEngine.ScriptableObject marker);
            /*0x7db40d8*/ int GetTimeRangeHash();
            /*0x7dab410*/ void AddClip(UnityEngine.Timeline.TimelineClip newClip);
            /*0x7db4398*/ UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable);
            /*0x7db49fc*/ UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable);
            /*0x7db50d0*/ UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x7db564c*/ void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks);
            /*0x7db466c*/ void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers);
            /*0x7db5a50*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x7db54f4*/ void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend);
            /*0x7db5ff0*/ void SortClips();
            /*0x7db6118*/ void ClearClipsInternal();
            /*0x7db61a4*/ void ClearSubTracksInternal();
            /*0x7dab214*/ void OnClipMove(UnityEngine.Timeline.ITimelineClipAsset clip);
            /*0x7db3c48*/ UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal();
            /*0x7db06ec*/ void AddChild(UnityEngine.Timeline.TrackAsset child);
            /*0x7db6228*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x7dadb3c*/ bool RemoveSubTrack(UnityEngine.Timeline.TrackAsset child);
            /*0x7dab390*/ void RemoveClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7da9ab4*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x7da9da0*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x7db6434*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7db6b0c*/ UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x7db3358*/ bool ValidateClipType(System.Type clipType);
            /*0x7db6c84*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7db1c08*/ void UpdateDuration();
            /*0x7da7680*/ int CalculateItemsHash();
            /*0x7db6e28*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip);
            /*0x7db171c*/ void Invalidate();
            /*0x7da9db0*/ double GetNotificationDuration();
            /*0x7db70c4*/ bool CanCompileClips();
            /*0x7db7120*/ bool CanCreateTrackMixer();
            /*0x7db7130*/ bool IsCompilable();
            /*0x7db1fb4*/ void UpdateChildTrackCache();
            /*0x7db74d8*/ int Hash();
            /*0x7db6c88*/ int GetClipsHash();
            /*0x7db6418*/ bool HasNotifications();
            /*0x7db5a1c*/ bool CanCompileNotifications();
            /*0x7db4cd4*/ bool CanCreateMixerRecursive();

            struct TransientBuildData
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> trackList;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> clipList;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markerList;

                static /*0x7db7710*/ UnityEngine.Timeline.TrackAsset.TransientBuildData Create();
                /*0x7db4ff0*/ void Clear();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TrackAsset.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__125_0;

                static /*0x7db786c*/ <>c();
                /*0x7db78d4*/ <>c();
                /*0x7db78dc*/ int <SortClips>b__125_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }

            class <get_outputs>d__69 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TrackAsset <>4__this;

                /*0x7db1f80*/ <get_outputs>d__69(int <>1__state);
                /*0x7db7910*/ void System.IDisposable.Dispose();
                /*0x7db7914*/ bool MoveNext();
                /*0x7db7b58*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7db7b68*/ void System.Collections.IEnumerator.Reset();
                /*0x7db7ba0*/ object System.Collections.IEnumerator.get_Current();
                /*0x7db7c00*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7db7ca4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TrackColorAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.Color m_Color;

            /*0x7db7ca8*/ TrackColorAttribute(float r, float g, float b);
        }

        enum ClipCaps
        {
            None = 0,
            Looping = 1,
            Extrapolation = 2,
            ClipIn = 4,
            SpeedMultiplier = 8,
            Blending = 16,
            AutoScale = 40,
            All = -1,
        }

        class TimelineClipCapsExtensions
        {
            static /*0x7db7cec*/ bool SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip);
            static /*0x7db4380*/ bool SupportsBlending(UnityEngine.Timeline.TimelineClip clip);
            static /*0x7dab0e0*/ bool HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags);
        }

        class CurveEditUtility
        {
            static /*0x7db7d04*/ UnityEngine.AnimationCurve CreateMatchingCurve(UnityEngine.AnimationCurve curve);
        }

        struct DiscreteTime : System.IComparable
        {
            static double k_Tick = 1e-12;
            static /*0x0*/ UnityEngine.Timeline.DiscreteTime kMaxTime;
            /*0x10*/ long m_DiscreteTime;

            static /*0x7db8250*/ DiscreteTime();
            static /*0x7db7ea0*/ double get_tickValue();
            static /*0x7db801c*/ UnityEngine.Timeline.DiscreteTime FromTicks(long ticks);
            static /*0x7db7f1c*/ long DoubleToDiscreteTime(double time);
            static /*0x7db7fbc*/ long IntToDiscreteTime(int time);
            static /*0x7db8154*/ double ToDouble(long time);
            static /*0x7dac694*/ double op_Explicit(UnityEngine.Timeline.DiscreteTime b);
            static /*0x7dac7a8*/ UnityEngine.Timeline.DiscreteTime op_Explicit(double time);
            static /*0x7dac65c*/ UnityEngine.Timeline.DiscreteTime op_Implicit(int time);
            static /*0x7db8168*/ bool op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7db8174*/ bool op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7dac67c*/ bool op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7db81d8*/ bool op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7db1d70*/ UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7daea44*/ UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7db81f4*/ long GetNearestTick(double time);
            /*0x7db7eac*/ DiscreteTime(long time);
            /*0x7db7eb4*/ DiscreteTime(double time);
            /*0x7dae97c*/ DiscreteTime(int time);
            /*0x7dac688*/ UnityEngine.Timeline.DiscreteTime OneTickBefore();
            /*0x7db8010*/ UnityEngine.Timeline.DiscreteTime OneTickAfter();
            /*0x7db8020*/ int CompareTo(object obj);
            /*0x7db809c*/ bool Equals(UnityEngine.Timeline.DiscreteTime other);
            /*0x7db80ac*/ bool Equals(object obj);
            /*0x7db81e4*/ string ToString();
            /*0x7db81ec*/ int GetHashCode();
        }

        class InfiniteRuntimeClip : UnityEngine.Timeline.RuntimeElement
        {
            static /*0x0*/ long kIntervalEnd;
            /*0x18*/ UnityEngine.Playables.Playable m_Playable;

            static /*0x7db843c*/ InfiniteRuntimeClip();
            /*0x7da99ec*/ InfiniteRuntimeClip(UnityEngine.Playables.Playable playable);
            /*0x7db82a4*/ long get_intervalStart();
            /*0x7db82ac*/ long get_intervalEnd();
            /*0x7db8304*/ void set_enable(bool value);
            /*0x7db8378*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x7db83d0*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IInterval
        {
            /*0x38146fc*/ long get_intervalStart();
            /*0x38146fc*/ long get_intervalEnd();
        }

        struct IntervalTreeNode
        {
            /*0x10*/ long center;
            /*0x18*/ int first;
            /*0x1c*/ int last;
            /*0x20*/ int left;
            /*0x24*/ int right;
        }

        class IntervalTree<T>
        {
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Timeline.IntervalTree.Entry<T>> m_Entries;
            /*0x0*/ System.Collections.Generic.List<UnityEngine.Timeline.IntervalTreeNode> m_Nodes;
            /*0x0*/ bool <dirty>k__BackingField;

            /*0x38159dc*/ IntervalTree();
            /*0x3813ffc*/ bool get_dirty();
            /*0x3815cc4*/ void set_dirty(bool value);
            /*0x3910ae8*/ void Add(T item);
            void IntersectsWith(long value, System.Collections.Generic.List<T> results);
            /*0x3910ae8*/ void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long value, System.Collections.Generic.List<T> results);
            /*0x38159dc*/ void Rebuild();
            /*0x38145e4*/ int Rebuild(int start, int end);

            struct Entry<T>
            {
                /*0x0*/ long intervalStart;
                /*0x0*/ long intervalEnd;
                /*0x0*/ T item;
            }
        }

        class RuntimeClip : UnityEngine.Timeline.RuntimeClipBase
        {
            /*0x18*/ UnityEngine.Timeline.TimelineClip m_Clip;
            /*0x20*/ UnityEngine.Playables.Playable m_Playable;
            /*0x30*/ UnityEngine.Playables.Playable m_ParentMixer;

            /*0x7da7b30*/ RuntimeClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x7db84ec*/ double get_start();
            /*0x7db8518*/ double get_duration();
            /*0x7db8538*/ void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x7db85c8*/ UnityEngine.Timeline.TimelineClip get_clip();
            /*0x7db85d0*/ UnityEngine.Playables.Playable get_mixer();
            /*0x7db85dc*/ UnityEngine.Playables.Playable get_playable();
            /*0x7db85e8*/ void set_enable(bool value);
            /*0x7db871c*/ void SetTime(double time);
            /*0x7db8774*/ void SetDuration(double duration);
            /*0x7db87cc*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x7db89c4*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        class RuntimeClipBase : UnityEngine.Timeline.RuntimeElement
        {
            /*0x7db8530*/ RuntimeClipBase();
            /*0x3814438*/ double get_start();
            /*0x3814438*/ double get_duration();
            /*0x7db8b1c*/ long get_intervalStart();
            /*0x7db8b8c*/ long get_intervalEnd();
        }

        class RuntimeElement : UnityEngine.Timeline.IInterval
        {
            /*0x10*/ int <intervalBit>k__BackingField;

            /*0x7db829c*/ RuntimeElement();
            /*0x38146fc*/ long get_intervalStart();
            /*0x38146fc*/ long get_intervalEnd();
            /*0x7db8c10*/ int get_intervalBit();
            /*0x7db8c18*/ void set_intervalBit(int value);
            /*0x3815cc4*/ void set_enable(bool value);
            void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IMarker
        {
            /*0x3814438*/ double get_time();
            /*0x3815db4*/ void set_time(double value);
            /*0x38148bc*/ UnityEngine.Timeline.TrackAsset get_parent();
            /*0x3816710*/ void Initialize(UnityEngine.Timeline.TrackAsset parent);
        }

        interface INotificationOptionProvider
        {
            /*0x3814548*/ UnityEngine.Timeline.NotificationFlags get_flags();
        }

        struct MarkerList : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Objects;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> m_Cache;
            /*0x20*/ bool m_CacheDirty;
            /*0x21*/ bool m_HasNotifications;

            /*0x7db7528*/ MarkerList(int capacity);
            /*0x7db8c20*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> get_markers();
            /*0x7db3f14*/ void Add(UnityEngine.ScriptableObject item);
            /*0x7db2fb0*/ bool Remove(UnityEngine.Timeline.IMarker item);
            /*0x7db4038*/ bool Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty);
            /*0x7db3e9c*/ void Clear();
            /*0x7db3188*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x7db31a0*/ int get_Count();
            /*0x7db31f8*/ UnityEngine.Timeline.IMarker get_Item(int idx);
            /*0x7db8f1c*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList();
            /*0x7db2cc0*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time, UnityEngine.Timeline.TrackAsset owner);
            /*0x7db7510*/ bool HasNotifications();
            /*0x7db8f24*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7db8f28*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7db8c38*/ void BuildCache();
        }

        class MarkerTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x7db910c*/ MarkerTrack();
            /*0x7db8f34*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class TrackAssetExtensions
        {
            static /*0x7db12d0*/ void ComputeBlendsFromOverlaps(UnityEngine.Timeline.TrackAsset asset, bool force);
        }

        class GroupTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x7db9400*/ GroupTrack();
            /*0x7db93a0*/ bool CanCompileClips();
            /*0x7db93a8*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        interface ILayerable
        {
            UnityEngine.Playables.Playable CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
        }

        enum NotificationFlags
        {
            TriggerInEditMode = 1,
            Retroactive = 2,
            TriggerOnce = 4,
        }

        class TimeNotificationBehaviour : UnityEngine.Playables.PlayableBehaviour
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> m_Notifications;
            /*0x18*/ double m_PreviousTime;
            /*0x20*/ bool m_NeedSortNotifications;
            /*0x28*/ UnityEngine.Playables.Playable m_TimeSource;

            static /*0x7db945c*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, double duration, UnityEngine.Playables.DirectorWrapMode loopMode);
            static /*0x7dba210*/ bool CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, double currentTime, double previousTime);
            static /*0x7db9b44*/ void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            static /*0x7dba26c*/ void Restore_internal(ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            /*0x7dba28c*/ TimeNotificationBehaviour();
            /*0x7db9454*/ void set_timeSource(UnityEngine.Playables.Playable value);
            /*0x7db9578*/ void AddNotification(double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags);
            /*0x7db96b4*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x7db9998*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7db9bcc*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7db9878*/ void SortNotifications();
            /*0x7dba02c*/ void TriggerNotificationsInRange(double start, double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, bool checkState);
            /*0x7db9f28*/ void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable);

            struct NotificationEntry
            {
                /*0x10*/ double time;
                /*0x18*/ UnityEngine.Playables.INotification payload;
                /*0x20*/ bool notificationFired;
                /*0x22*/ UnityEngine.Timeline.NotificationFlags flags;

                /*0x7dba280*/ bool get_triggerInEditor();
                /*0x7dba274*/ bool get_prewarm();
                /*0x7db998c*/ bool get_triggerOnce();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TimeNotificationBehaviour.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> <>9__12_0;

                static /*0x7dba314*/ <>c();
                /*0x7dba37c*/ <>c();
                /*0x7dba384*/ int <SortNotifications>b__12_0(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry x, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry y);
            }
        }

        class PlayableTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x7dba43c*/ PlayableTrack();
            /*0x7dba394*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
        }

        class TrackClipTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type inspectedType;
            /*0x18*/ bool allowAutoCreate;

            /*0x7dba490*/ TrackClipTypeAttribute(System.Type clipClass);
            /*0x7dba4cc*/ TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate);
        }

        class NotKeyableAttribute : System.Attribute
        {
            /*0x7dba4fc*/ NotKeyableAttribute();
        }

        enum TrackBindingFlags
        {
            None = 0,
            AllowCreateComponent = 1,
            All = 1,
        }

        class TrackBindingTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type type;
            /*0x18*/ UnityEngine.Timeline.TrackBindingFlags flags;

            /*0x7dba504*/ TrackBindingTypeAttribute(System.Type type);
            /*0x7dba540*/ TrackBindingTypeAttribute(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags);
        }

        class SupportsChildTracksAttribute : System.Attribute
        {
            /*0x10*/ System.Type childType;
            /*0x18*/ int levels;

            /*0x7dba57c*/ SupportsChildTracksAttribute(System.Type childType, int levels);
        }

        class IgnoreOnPlayableTrackAttribute : System.Attribute
        {
            /*0x7dba5b8*/ IgnoreOnPlayableTrackAttribute();
        }

        class FrameRateFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7dba5c0*/ FrameRateFieldAttribute();
        }

        class HideInMenuAttribute : System.Attribute
        {
            /*0x7dba5c8*/ HideInMenuAttribute();
        }

        interface ITimelineClipAsset
        {
            /*0x3814574*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
        }

        interface ITimelineEvaluateCallback
        {
            /*0x38159dc*/ void Evaluate();
        }

        class TimelinePlayable : UnityEngine.Playables.PlayableBehaviour
        {
            static /*0x0*/ bool muteAudioScrubbing;
            /*0x10*/ UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> m_IntervalTree;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClips;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips;
            /*0x28*/ int m_ActiveBit;
            /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset, UnityEngine.Playables.Playable> m_PlayableCache;
            /*0x38*/ System.Collections.Generic.Dictionary<UnityEngine.Timeline.AnimationTrack, System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback>> m_EvaluateCallbacks;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> m_AlwaysEvaluateCallbacks;
            /*0x48*/ System.Collections.Generic.HashSet<UnityEngine.Timeline.ITimelineEvaluateCallback> m_ForceEvaluateNextEvaluate;
            /*0x50*/ System.Collections.Generic.HashSet<UnityEngine.Timeline.ITimelineEvaluateCallback> m_InvokedThisFrame;
            /*0x58*/ System.Collections.Generic.HashSet<UnityEngine.Timeline.AnimationTrack> m_ActiveTracksToEvaluateCache;

            static /*0x7dbcd48*/ TimelinePlayable();
            static /*0x7dadd80*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x7dbcabc*/ TimelinePlayable();
            /*0x7dba5d0*/ void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x7dba880*/ void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool createOutputs);
            /*0x7dbb004*/ void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, int port);
            /*0x7dbac20*/ UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, bool createOutputs);
            /*0x7dbb738*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7dbb764*/ void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData);
            /*0x7dbb6c8*/ void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable);
            /*0x7dbb68c*/ void AddPlayableOutputCallbacks(UnityEngine.Timeline.AnimationTrack track, UnityEngine.Playables.PlayableOutput playableOutput);
            /*0x7dbc674*/ void AddOutputWeightProcessor(UnityEngine.Timeline.AnimationTrack track, UnityEngine.Animations.AnimationPlayableOutput animOutput);
            /*0x7dbc7ac*/ void AddEvaluateCallback(UnityEngine.Timeline.AnimationTrack track, UnityEngine.Timeline.ITimelineEvaluateCallback callback);
            /*0x7dbbc50*/ void InvokeOutputCallbacks(System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements);
            /*0x7dbc99c*/ bool TryGetCallbackList(UnityEngine.Timeline.AnimationTrack track, ref System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> list);

            struct TrackCacheManager : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Timeline.AnimationTrack> trackCache;

                /*0x7dbc970*/ TrackCacheManager(System.Collections.Generic.HashSet<UnityEngine.Timeline.AnimationTrack> cache, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements);
                /*0x7dbcfa8*/ void Dispose();
                /*0x7dbcd94*/ void GetTrackAssetsFromRuntimeElements(System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements);
            }
        }

        class BlendUtility
        {
            static /*0x0*/ double kMinOverlapTime;

            static /*0x7dbd288*/ BlendUtility();
            static /*0x7dbcff8*/ bool Overlaps(UnityEngine.Timeline.TimelineClip blendOut, UnityEngine.Timeline.TimelineClip blendIn);
            static /*0x7db9160*/ void ComputeBlendsFromOverlaps(UnityEngine.Timeline.TimelineClip[] clips);
            static /*0x7dbd0e8*/ void UpdateClipIntersection(UnityEngine.Timeline.TimelineClip blendOutClip, UnityEngine.Timeline.TimelineClip blendInClip);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.BlendUtility.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;

                static /*0x7dbd30c*/ <>c();
                /*0x7dbd374*/ <>c();
                /*0x7dbd37c*/ int <ComputeBlendsFromOverlaps>b__2_0(UnityEngine.Timeline.TimelineClip c1, UnityEngine.Timeline.TimelineClip c2);
            }
        }

        class Extrapolation
        {
            static /*0x0*/ double kMinExtrapolationTime;

            static /*0x7dbd59c*/ Extrapolation();
            static /*0x7dafabc*/ void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset);
            static /*0x7dbd45c*/ UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.Extrapolation.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;

                static /*0x7dbd620*/ <>c();
                /*0x7dbd688*/ <>c();
                /*0x7dbd690*/ int <SortClipsByStartTime>b__2_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }
        }

        class HashUtility
        {
            static /*0x7da7724*/ int CombineHash(int h1, int h2);
            static /*0x7db6dfc*/ int CombineHash(int h1, int h2, int h3);
            static /*0x7dbd6c4*/ int CombineHash(int h1, int h2, int h3, int h4);
            static /*0x7dbd700*/ int CombineHash(int h1, int h2, int h3, int h4, int h5);
            static /*0x7dabb48*/ int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6);
        }

        interface IPropertyCollector
        {
            /*0x3816710*/ void PushActiveGameObject(UnityEngine.GameObject gameObject);
            /*0x38159dc*/ void PopActiveGameObject();
            /*0x3816710*/ void AddFromClip(UnityEngine.AnimationClip clip);
            /*0x3816710*/ void AddFromName<T>(string name);
            /*0x3816810*/ void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip);
        }

        interface IPropertyPreview
        {
            /*0x3816810*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
        }

        class NotificationUtilities
        {
            static /*0x7db49e8*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Playables.PlayableDirector director);
            static /*0x7db49f4*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Timeline.TimelineAsset timelineAsset);
            static /*0x7dbd74c*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Playables.IPlayableAsset asset, UnityEngine.Playables.PlayableDirector director);
            static /*0x7db24c4*/ bool TrackTypeSupportsNotifications(System.Type type);
        }

        class TimelineCreateUtilities
        {
            static /*0x7daf204*/ string GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, string name);
            static /*0x7dae6e4*/ void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x7dae874*/ void RemoveAssetFromObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x7da6e08*/ UnityEngine.AnimationClip CreateAnimationClipForTrack(string name, UnityEngine.Timeline.TrackAsset track, bool isLegacy);
            static /*0x7daeefc*/ bool ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ string name;

                /*0x7dbdf8c*/ <>c__DisplayClass0_0();
                /*0x7dbdf9c*/ bool <GenerateUniqueActorName>b__0(UnityEngine.ScriptableObject x);
            }

            class <>c__DisplayClass0_1
            {
                /*0x10*/ string result;

                /*0x7dbdf94*/ <>c__DisplayClass0_1();
                /*0x7dbdfcc*/ bool <GenerateUniqueActorName>b__1(UnityEngine.ScriptableObject x);
            }
        }

        class TimelineUndo
        {
            static /*0x7daf904*/ void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy);
        }

        class TimeUtility
        {
            static /*0x0*/ double kTimeEpsilon;
            static /*0x8*/ double kFrameRateEpsilon;
            static /*0x10*/ double k_MaxTimelineDurationInSeconds;
            static /*0x18*/ double kFrameRateRounding;

            static /*0x7dbdffc*/ TimeUtility();
            static /*0x7da56bc*/ double GetAnimationClipLength(UnityEngine.AnimationClip clip);
        }

        class WeightUtility
        {
            static /*0x7da516c*/ float NormalizeMixer(UnityEngine.Playables.Playable mixer);
        }
    }
}
