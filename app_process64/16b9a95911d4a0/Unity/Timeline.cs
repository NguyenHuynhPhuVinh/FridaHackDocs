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

            /*0x3d1cea4*/ AnimationOutputWeightProcessor(UnityEngine.Animations.AnimationPlayableOutput output);
            /*0x3d1cf7c*/ void FindMixers();
            /*0x3d1d0cc*/ void FindMixers(UnityEngine.Playables.Playable parent, int port, UnityEngine.Playables.Playable node);
            /*0x3d1d368*/ void Evaluate();

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

            static /*0x3d1e5c8*/ AnimationPlayableAsset();
            static /*0x3d1dd0c*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, bool removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, bool applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop);
            static /*0x3d1e114*/ bool ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip);
            static /*0x3d1e0fc*/ bool ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x3d1d7f0*/ bool HasRootTransforms(UnityEngine.AnimationClip clip);
            /*0x3d1e4c4*/ AnimationPlayableAsset();
            /*0x3d1d660*/ UnityEngine.Vector3 get_position();
            /*0x3d1d66c*/ void set_position(UnityEngine.Vector3 value);
            /*0x3d1d678*/ UnityEngine.Quaternion get_rotation();
            /*0x3d1d6a8*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x3d1d6e4*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x3d1d6f0*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x3d1d6fc*/ bool get_useTrackMatchFields();
            /*0x3d1d704*/ void set_useTrackMatchFields(bool value);
            /*0x3d1d70c*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x3d1d714*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x3d1d71c*/ bool get_removeStartOffset();
            /*0x3d1d724*/ void set_removeStartOffset(bool value);
            /*0x3d1d72c*/ bool get_applyFootIK();
            /*0x3d1d734*/ void set_applyFootIK(bool value);
            /*0x3d1d73c*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_loop();
            /*0x3d1d744*/ void set_loop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x3d1d74c*/ bool get_hasRootTransforms();
            /*0x3d1d8bc*/ UnityEngine.Timeline.AppliedOffsetMode get_appliedOffsetMode();
            /*0x3d1d8c4*/ void set_appliedOffsetMode(UnityEngine.Timeline.AppliedOffsetMode value);
            /*0x3d1d8cc*/ UnityEngine.AnimationClip get_clip();
            /*0x3d1d8d4*/ void set_clip(UnityEngine.AnimationClip value);
            /*0x3d1d99c*/ double get_duration();
            /*0x3d1db80*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x3d1dc34*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x3d1e188*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x3d1e26c*/ void ResetOffsets();
            /*0x3d1e2d8*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x3d1e384*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3d1e3e4*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3d1e468*/ void OnUpgradeFromVersion(int oldVersion);

            enum LoopMode
            {
                UseSourceAsset = 0,
                On = 1,
                Off = 2,
            }

            class AnimationPlayableAssetUpgrade
            {
                static /*0x3d1e478*/ void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset);
            }

            class <get_outputs>d__45 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationPlayableAsset <>4__this;

                /*0x3d1dc00*/ <get_outputs>d__45(int <>1__state);
                /*0x3d1e614*/ void System.IDisposable.Dispose();
                /*0x3d1e618*/ bool MoveNext();
                /*0x3d1e6a8*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x3d1e6b8*/ void System.Collections.IEnumerator.Reset();
                /*0x3d1e6f0*/ object System.Collections.IEnumerator.get_Current();
                /*0x3d1e750*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x3d1e7f4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x3d1e7f8*/ MatchTargetFieldConstants();
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

            static /*0x3d22c50*/ AnimationTrack();
            static /*0x3d2179c*/ bool UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x3d21294*/ UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            static /*0x3d225e0*/ UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, string name);
            /*0x3d229dc*/ AnimationTrack();
            /*0x3d1e848*/ UnityEngine.Vector3 get_position();
            /*0x3d1e854*/ void set_position(UnityEngine.Vector3 value);
            /*0x3d1e860*/ UnityEngine.Quaternion get_rotation();
            /*0x3d1e890*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x3d1e8cc*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x3d1e8d8*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x3d1e8e4*/ bool get_applyOffsets();
            /*0x3d1e8ec*/ void set_applyOffsets(bool value);
            /*0x3d1e8f0*/ UnityEngine.Timeline.TrackOffset get_trackOffset();
            /*0x3d1e8f8*/ void set_trackOffset(UnityEngine.Timeline.TrackOffset value);
            /*0x3d1e900*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x3d1e908*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x3d1e978*/ UnityEngine.AnimationClip get_infiniteClip();
            /*0x3d1e980*/ void set_infiniteClip(UnityEngine.AnimationClip value);
            /*0x3d1e990*/ bool get_infiniteClipRemoveOffset();
            /*0x3d1e998*/ void set_infiniteClipRemoveOffset(bool value);
            /*0x3d1e9a0*/ UnityEngine.AvatarMask get_avatarMask();
            /*0x3d1e9a8*/ void set_avatarMask(UnityEngine.AvatarMask value);
            /*0x3d1e9b0*/ bool get_applyAvatarMask();
            /*0x3d1e9b8*/ void set_applyAvatarMask(bool value);
            /*0x3d1e9c0*/ bool CanCompileClips();
            /*0x3d1ea7c*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x3d1eb30*/ bool get_inClipMode();
            /*0x3d1ec34*/ UnityEngine.Vector3 get_infiniteClipOffsetPosition();
            /*0x3d1ec40*/ void set_infiniteClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x3d1ec4c*/ UnityEngine.Quaternion get_infiniteClipOffsetRotation();
            /*0x3d1ec7c*/ void set_infiniteClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x3d1ecb8*/ UnityEngine.Vector3 get_infiniteClipOffsetEulerAngles();
            /*0x3d1ecc4*/ void set_infiniteClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x3d1ecd0*/ bool get_infiniteClipApplyFootIK();
            /*0x3d1ecd8*/ void set_infiniteClipApplyFootIK(bool value);
            /*0x3d1ece0*/ double get_infiniteClipTimeOffset();
            /*0x3d1ece8*/ void set_infiniteClipTimeOffset(double value);
            /*0x3d1ecf0*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation();
            /*0x3d1ecf8*/ void set_infiniteClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x3d1ed00*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation();
            /*0x3d1ed08*/ void set_infiniteClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x3d1ed10*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_infiniteClipLoop();
            /*0x3d1ed18*/ void set_infiniteClipLoop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x3d1ed20*/ void ResetOffsets();
            /*0x3d1ed90*/ UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip);
            /*0x3d1f06c*/ void CreateInfiniteClip(string infiniteClipName);
            /*0x3d1f334*/ UnityEngine.Timeline.TimelineClip CreateRecordableClip(string animClipName);
            /*0x3d1f62c*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x3d1f7e8*/ int CalculateItemsHash();
            /*0x3d1ed8c*/ void UpdateClipOffsets();
            /*0x3d1fa10*/ UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x3d203d8*/ UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x3d20428*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x3d2128c*/ int GetDefaultBlendCount();
            /*0x3d21798*/ void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, bool requireOffset);
            /*0x3d217ac*/ UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x3d21688*/ bool RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject);
            /*0x3d21af4*/ bool HasController(UnityEngine.GameObject gameObject);
            /*0x3d2190c*/ UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x3d21308*/ UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x3d20214*/ UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x3d21c40*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x3d21ed0*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x3d1ee38*/ void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip);
            /*0x3d22138*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x3d2213c*/ void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips);
            /*0x3d211a8*/ UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, bool animatesRootTransform);
            /*0x3d20f30*/ bool IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode);
            /*0x3d20d44*/ UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject);
            /*0x3d1fe78*/ bool AnimatesRootTransform();
            /*0x3d227c8*/ UnityEngine.Vector3 get_openClipOffsetPosition();
            /*0x3d227d4*/ void set_openClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x3d227e0*/ UnityEngine.Quaternion get_openClipOffsetRotation();
            /*0x3d22810*/ void set_openClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x3d22814*/ UnityEngine.Vector3 get_openClipOffsetEulerAngles();
            /*0x3d22820*/ void set_openClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x3d2282c*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPreExtrapolation();
            /*0x3d22834*/ void set_openClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x3d2283c*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPostExtrapolation();
            /*0x3d22844*/ void set_openClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x3d2284c*/ void OnUpgradeFromVersion(int oldVersion);

            class AnimationTrackUpgrade
            {
                static /*0x3d22890*/ void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track);
                static /*0x3d22924*/ void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track);
                static /*0x3d229a8*/ void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track);
            }

            class <get_outputs>d__49 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationTrack <>4__this;

                /*0x3d1eafc*/ <get_outputs>d__49(int <>1__state);
                /*0x3d22cec*/ void System.IDisposable.Dispose();
                /*0x3d22cf0*/ bool MoveNext();
                /*0x3d22d80*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x3d22d90*/ void System.Collections.IEnumerator.Reset();
                /*0x3d22dc8*/ object System.Collections.IEnumerator.get_Current();
                /*0x3d22e28*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x3d22ecc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        interface ICurvesOwner
        {
            /*0x1f30214*/ string get_defaultCurvesName();
            /*0x1f30214*/ UnityEngine.Object get_asset();
            /*0x1f30214*/ UnityEngine.Object get_assetOwner();
            /*0x1f30214*/ UnityEngine.Timeline.TrackAsset get_targetTrack();
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

            static /*0x3d242dc*/ TimelineClip();
            static /*0x3d237fc*/ UnityEngine.AnimationCurve GetDefaultMixInCurve();
            static /*0x3d238f4*/ UnityEngine.AnimationCurve GetDefaultMixOutCurve();
            static /*0x3d2325c*/ double SanitizeTimeValue(double value, double defaultValue);
            static /*0x3d23dd8*/ double GetExtrapolatedTime(double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, double duration);
            /*0x3d22f44*/ TimelineClip(UnityEngine.Timeline.TrackAsset parent);
            /*0x3d22ed0*/ void UpgradeToLatestVersion();
            /*0x3d23088*/ double get_timeScale();
            /*0x3d23250*/ double get_start();
            /*0x3d1f47c*/ void set_start(double value);
            /*0x3d23380*/ double get_duration();
            /*0x3d1f580*/ void set_duration(double value);
            /*0x3d23388*/ double get_end();
            /*0x3d23398*/ double get_clipIn();
            /*0x3d233b8*/ string get_displayName();
            /*0x3d233c0*/ void set_displayName(string value);
            /*0x3d233c8*/ UnityEngine.AnimationClip get_curves();
            /*0x3d233d0*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x3d23428*/ UnityEngine.Object get_asset();
            /*0x3d23430*/ void set_asset(UnityEngine.Object value);
            /*0x3d23438*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x3d23440*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x3d23448*/ UnityEngine.Timeline.TrackAsset GetParentTrack();
            /*0x3d22f80*/ void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack);
            /*0x3d23558*/ double get_easeInDuration();
            /*0x3d23640*/ double get_easeOutDuration();
            /*0x3d23728*/ double get_blendInDuration();
            /*0x3d23748*/ double get_blendOutDuration();
            /*0x3d236fc*/ bool get_hasBlendIn();
            /*0x3d23614*/ bool get_hasBlendOut();
            /*0x3d23768*/ UnityEngine.AnimationCurve get_mixInCurve();
            /*0x3d23814*/ void set_mixInCurve(UnityEngine.AnimationCurve value);
            /*0x3d2381c*/ double get_mixInDuration();
            /*0x3d23860*/ UnityEngine.AnimationCurve get_mixOutCurve();
            /*0x3d2390c*/ void set_mixOutCurve(UnityEngine.AnimationCurve value);
            /*0x3d23914*/ double get_mixOutTime();
            /*0x3d23940*/ double get_mixOutDuration();
            /*0x3d23984*/ bool get_recordable();
            /*0x3d2398c*/ void set_recordable(bool value);
            /*0x3d23160*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x3d23994*/ int Hash();
            /*0x3d23ac8*/ float EvaluateMixOut(double time);
            /*0x3d23bc0*/ float EvaluateMixIn(double time);
            /*0x3d23c98*/ double ToLocalTime(double time);
            /*0x3d23f4c*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_postExtrapolationMode();
            /*0x3d1f7b4*/ void set_postExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x3d23f70*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_preExtrapolationMode();
            /*0x3d1f780*/ void set_preExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x3d23f94*/ void SetPostExtrapolationTime(double time);
            /*0x3d23f9c*/ void SetPreExtrapolationTime(double time);
            /*0x3d23d88*/ bool IsPreExtrapolatedTime(double sequenceTime);
            /*0x3d23ef4*/ bool IsPostExtrapolatedTime(double sequenceTime);
            /*0x3d23fa4*/ double get_extrapolatedStart();
            /*0x3d23fbc*/ double get_extrapolatedDuration();
            /*0x3d24088*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3d24094*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3d240d0*/ string ToString();
            /*0x3d23258*/ void UpdateDirty(double oldValue, double newValue);

            class TimelineClipUpgrade
            {
                static /*0x3d22f0c*/ void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip);
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

            static /*0x3d2517c*/ double GetValidFrameRate(double frameRate);
            static /*0x3d25480*/ void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, ref System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> allTracks);
            /*0x3d28594*/ TimelineAsset();
            /*0x3d2436c*/ void UpgradeToLatestVersion();
            /*0x3d24370*/ UnityEngine.Timeline.TimelineAsset.EditorSettings get_editorSettings();
            /*0x3d24378*/ double get_duration();
            /*0x3d2461c*/ double get_fixedDuration();
            /*0x3d246e8*/ void set_fixedDuration(double value);
            /*0x3d24758*/ UnityEngine.Timeline.TimelineAsset.DurationMode get_durationMode();
            /*0x3d24760*/ void set_durationMode(UnityEngine.Timeline.TimelineAsset.DurationMode value);
            /*0x3d24768*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x3d2481c*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x3d24b5c*/ int get_outputTrackCount();
            /*0x3d24d80*/ int get_rootTrackCount();
            /*0x3d25154*/ void OnValidate();
            /*0x3d25240*/ UnityEngine.Timeline.TrackAsset GetRootTrack(int index);
            /*0x3d24b44*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks();
            /*0x3d252b4*/ UnityEngine.Timeline.TrackAsset GetOutputTrack(int index);
            /*0x3d252f8*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks();
            /*0x3d24dd0*/ void UpdateRootTrackCache();
            /*0x3d24b80*/ void UpdateOutputTrackCache();
            /*0x3d25310*/ UnityEngine.Timeline.TrackAsset[] get_flattenedTracks();
            /*0x3d25798*/ UnityEngine.Timeline.MarkerTrack get_markerTrack();
            /*0x3d257a0*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_trackObjects();
            /*0x3d257a8*/ void AddTrackInternal(UnityEngine.Timeline.TrackAsset track);
            /*0x3d25854*/ void RemoveTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x3d259e0*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x3d25dc0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3d25dc8*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3d25dcc*/ void __internalAwake();
            /*0x3d25f60*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x3d263d8*/ void CreateMarkerTrack();
            /*0x3d265c0*/ void RemoveMarkerTrack();
            /*0x3d2581c*/ void Invalidate();
            /*0x3d266f8*/ void UpdateFixedDurationWithItemsDuration();
            /*0x3d24428*/ UnityEngine.Timeline.DiscreteTime CalculateItemsDuration();
            /*0x3d26894*/ UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, string name);
            /*0x1ffc854*/ T CreateTrack<T>(UnityEngine.Timeline.TrackAsset parent, string trackName);
            /*0x1ffc854*/ T CreateTrack<T>(string trackName);
            /*0x1ffc854*/ T CreateTrack<T>();
            /*0x3d27544*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x3d27c5c*/ bool DeleteTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x3d282e0*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x3d272e4*/ UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, string trackName, System.Type trackType);
            /*0x3d281b0*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track);
            /*0x3d27778*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip);

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

                static /*0x3d28674*/ EditorSettings();
                /*0x3d285fc*/ EditorSettings();
                /*0x3d2866c*/ double get_frameRate();
                /*0x3d25228*/ void set_frameRate(double value);
            }

            class <get_outputs>d__27 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TimelineAsset <>4__this;
                /*0x48*/ System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TrackAsset> <>7__wrap1;
                /*0x50*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> <>7__wrap2;

                /*0x3d247e8*/ <get_outputs>d__27(int <>1__state);
                /*0x3d286f8*/ void System.IDisposable.Dispose();
                /*0x3d287a4*/ bool MoveNext();
                /*0x3d28ce8*/ void <>m__Finally1();
                /*0x3d28c38*/ void <>m__Finally2();
                /*0x3d28d98*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x3d28da8*/ void System.Collections.IEnumerator.Reset();
                /*0x3d28de0*/ object System.Collections.IEnumerator.get_Current();
                /*0x3d28e40*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x3d28ee4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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
            /*0x71*/ System.Nullable<bool> m_SupportsNotifications;
            /*0x78*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> m_ChildTrackCache;
            /*0x80*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> m_Clips;
            /*0x88*/ UnityEngine.Timeline.MarkerList m_Markers;

            static /*0x3d2f32c*/ TrackAsset();
            static /*0x3d294b4*/ void add_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x3d295a8*/ void remove_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x3d2969c*/ void add_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x3d29790*/ void remove_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x3d1f868*/ int GetAnimationClipHash(UnityEngine.AnimationClip clip);
            /*0x3d22b6c*/ TrackAsset();
            /*0x3d28ee8*/ void OnBeforeTrackSerialize();
            /*0x3d28eec*/ void OnAfterTrackDeserialize();
            /*0x3d28ef0*/ void OnUpgradeFromVersion(int oldVersion);
            /*0x3d28ef4*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3d29074*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3d29494*/ void UpgradeToLatestVersion();
            /*0x3d29884*/ double get_start();
            /*0x3d267cc*/ double get_end();
            /*0x3d299ec*/ double get_duration();
            /*0x3d29a54*/ bool get_muted();
            /*0x3d29a5c*/ void set_muted(bool value);
            /*0x3d26244*/ bool get_mutedInHierarchy();
            /*0x3d26b78*/ UnityEngine.Timeline.TimelineAsset get_timelineAsset();
            /*0x3d29a64*/ UnityEngine.Playables.PlayableAsset get_parent();
            /*0x3d29a6c*/ void set_parent(UnityEngine.Playables.PlayableAsset value);
            /*0x3d227c4*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips();
            /*0x3d1eb64*/ UnityEngine.Timeline.TimelineClip[] get_clips();
            /*0x3d29a74*/ bool get_isEmpty();
            /*0x3d29ae0*/ bool get_hasClips();
            /*0x3d29b34*/ bool get_hasCurves();
            /*0x3d1f66c*/ bool get_isSubTrack();
            /*0x3d29bc8*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x3d21190*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks();
            /*0x3d29e88*/ string get_customPlayableTypename();
            /*0x3d29e90*/ void set_customPlayableTypename(string value);
            /*0x3d29e98*/ UnityEngine.AnimationClip get_curves();
            /*0x3d29ea0*/ void set_curves(UnityEngine.AnimationClip value);
            /*0x3d29ea8*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x3d29ee8*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_asset();
            /*0x3d29eec*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x3d29ef0*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x3d29ef4*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_subTracksObjects();
            /*0x3d29efc*/ bool get_locked();
            /*0x3d29f04*/ void set_locked(bool value);
            /*0x3d29f0c*/ bool get_lockedInHierarchy();
            /*0x3d2a0a0*/ bool get_supportsNotifications();
            /*0x3d2a300*/ void __internalAwake();
            /*0x3d2a3f0*/ void CreateCurves(string curvesClipName);
            /*0x3d2a4bc*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x3d2a52c*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x3d2a57c*/ UnityEngine.Timeline.TimelineClip CreateDefaultClip();
            /*0x1f30214*/ UnityEngine.Timeline.TimelineClip CreateClip<T>();
            /*0x3d2a86c*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x3d2a97c*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time);
            /*0x1ffc854*/ T CreateMarker<T>(double time);
            /*0x3d2ac70*/ bool DeleteMarker(UnityEngine.Timeline.IMarker marker);
            /*0x3d29498*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x3d29bc0*/ int GetMarkerCount();
            /*0x3d2aeb4*/ UnityEngine.Timeline.IMarker GetMarker(int idx);
            /*0x3d2af30*/ UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType);
            /*0x3d2a83c*/ UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType);
            /*0x3d2b2a4*/ UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType);
            /*0x3d2b6e0*/ UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset);
            /*0x3d2b464*/ UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset);
            /*0x3d2bb88*/ System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw();
            /*0x3d2bb90*/ void ClearMarkers();
            /*0x3d2bc38*/ void AddMarker(UnityEngine.ScriptableObject e);
            /*0x3d2bce4*/ bool DeleteMarkerRaw(UnityEngine.ScriptableObject marker);
            /*0x3d2bdac*/ int GetTimeRangeHash();
            /*0x3d234b8*/ void AddClip(UnityEngine.Timeline.TimelineClip newClip);
            /*0x3d2c048*/ UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable);
            /*0x3d2c6dc*/ UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable);
            /*0x3d2ce04*/ UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x3d2d380*/ void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks);
            /*0x3d2c384*/ void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers);
            /*0x3d2d74c*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x3d2d230*/ void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend);
            /*0x3d2dd34*/ void SortClips();
            /*0x3d2de5c*/ void ClearClipsInternal();
            /*0x3d2dee8*/ void ClearSubTracksInternal();
            /*0x3d23378*/ void OnClipMove();
            /*0x3d2b930*/ UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal();
            /*0x3d284d0*/ void AddChild(UnityEngine.Timeline.TrackAsset child);
            /*0x3d2df6c*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x3d2595c*/ bool RemoveSubTrack(UnityEngine.Timeline.TrackAsset child);
            /*0x3d23450*/ void RemoveClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x3d21cdc*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x3d21fc8*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x3d2e178*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x3d2e7fc*/ UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x3d2b030*/ bool ValidateClipType(System.Type clipType);
            /*0x3d2e974*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x3d298e4*/ void UpdateDuration();
            /*0x3d1f950*/ int CalculateItemsHash();
            /*0x3d2eb74*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip);
            /*0x3d293f8*/ void Invalidate();
            /*0x3d21fd8*/ double GetNotificationDuration();
            /*0x3d2ee18*/ bool CanCompileClips();
            /*0x3d2ee74*/ bool CanCreateTrackMixer();
            /*0x3d2ee84*/ bool IsCompilable();
            /*0x3d29c7c*/ void UpdateChildTrackCache();
            /*0x3d2f1f4*/ int Hash();
            /*0x3d2e978*/ int GetClipsHash();
            /*0x3d2e15c*/ bool HasNotifications();
            /*0x3d2d718*/ bool CanCompileNotifications();
            /*0x3d2c9b4*/ bool CanCreateMixerRecursive();

            struct TransientBuildData
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> trackList;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> clipList;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markerList;

                static /*0x3d2f42c*/ UnityEngine.Timeline.TrackAsset.TransientBuildData Create();
                /*0x3d2cc98*/ void Clear();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TrackAsset.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__121_0;

                static /*0x3d2f580*/ <>c();
                /*0x3d2f5e8*/ <>c();
                /*0x3d2f5f0*/ int <SortClips>b__121_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }

            class <get_outputs>d__65 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TrackAsset <>4__this;

                /*0x3d29c48*/ <get_outputs>d__65(int <>1__state);
                /*0x3d2f620*/ void System.IDisposable.Dispose();
                /*0x3d2f624*/ bool MoveNext();
                /*0x3d2f864*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x3d2f874*/ void System.Collections.IEnumerator.Reset();
                /*0x3d2f8ac*/ object System.Collections.IEnumerator.get_Current();
                /*0x3d2f90c*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x3d2f9b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TrackColorAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.Color m_Color;

            /*0x3d2f9b4*/ TrackColorAttribute(float r, float g, float b);
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
            static /*0x3d2f9f8*/ bool SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip);
            static /*0x3d23244*/ bool HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags);
        }

        struct DiscreteTime : System.IComparable
        {
            static double k_Tick = 1e-12;
            static /*0x0*/ UnityEngine.Timeline.DiscreteTime kMaxTime;
            /*0x10*/ long m_DiscreteTime;

            static /*0x3d2fdf0*/ DiscreteTime();
            static /*0x3d2fa10*/ double get_tickValue();
            static /*0x3d2fb84*/ UnityEngine.Timeline.DiscreteTime FromTicks(long ticks);
            static /*0x3d2fa8c*/ long DoubleToDiscreteTime(double time);
            static /*0x3d2fb24*/ long IntToDiscreteTime(int time);
            static /*0x3d2fccc*/ double ToDouble(long time);
            static /*0x3d245bc*/ double op_Explicit(UnityEngine.Timeline.DiscreteTime b);
            static /*0x3d246d0*/ UnityEngine.Timeline.DiscreteTime op_Explicit(double time);
            static /*0x3d24588*/ UnityEngine.Timeline.DiscreteTime op_Implicit(int time);
            static /*0x3d2fce0*/ bool op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x3d2fcec*/ bool op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x3d245a4*/ bool op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x3d2fd50*/ bool op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x3d29a4c*/ UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x3d2682c*/ UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x3d2fd94*/ long GetNearestTick(double time);
            /*0x3d2fa1c*/ DiscreteTime(long time);
            /*0x3d2fa24*/ DiscreteTime(double time);
            /*0x3d26764*/ DiscreteTime(int time);
            /*0x3d245b0*/ UnityEngine.Timeline.DiscreteTime OneTickBefore();
            /*0x3d2fb78*/ UnityEngine.Timeline.DiscreteTime OneTickAfter();
            /*0x3d2fb88*/ int CompareTo(object obj);
            /*0x3d2fc14*/ bool Equals(UnityEngine.Timeline.DiscreteTime other);
            /*0x3d2fc24*/ bool Equals(object obj);
            /*0x3d2fd5c*/ string ToString();
            /*0x3d2fd78*/ int GetHashCode();
        }

        class InfiniteRuntimeClip : UnityEngine.Timeline.RuntimeElement
        {
            static /*0x0*/ long kIntervalEnd;
            /*0x18*/ UnityEngine.Playables.Playable m_Playable;

            static /*0x3d3001c*/ InfiniteRuntimeClip();
            /*0x3d21c14*/ InfiniteRuntimeClip(UnityEngine.Playables.Playable playable);
            /*0x3d2fe44*/ long get_intervalStart();
            /*0x3d2fe4c*/ long get_intervalEnd();
            /*0x3d2fea4*/ void set_enable(bool value);
            /*0x3d2ff30*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x3d2ff9c*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IInterval
        {
            long get_intervalStart();
            long get_intervalEnd();
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

            /*0x1f309e4*/ IntervalTree();
            /*0x1f2fe14*/ bool get_dirty();
            /*0x1f30a84*/ void set_dirty(bool value);
            /*0x1ffc854*/ void Add(T item);
            void IntersectsWith(long value, System.Collections.Generic.List<T> results);
            /*0x1ffc854*/ void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long value, System.Collections.Generic.List<T> results);
            /*0x1f309e4*/ void Rebuild();
            /*0x1f2fff4*/ int Rebuild(int start, int end);

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

            /*0x3d1fe1c*/ RuntimeClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x3d300cc*/ double get_start();
            /*0x3d300f4*/ double get_duration();
            /*0x3d30110*/ void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x3d301ac*/ UnityEngine.Timeline.TimelineClip get_clip();
            /*0x3d301b4*/ UnityEngine.Playables.Playable get_mixer();
            /*0x3d301c0*/ UnityEngine.Playables.Playable get_playable();
            /*0x3d301cc*/ void set_enable(bool value);
            /*0x3d30328*/ void SetTime(double time);
            /*0x3d30394*/ void SetDuration(double duration);
            /*0x3d30400*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x3d3060c*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        class RuntimeClipBase : UnityEngine.Timeline.RuntimeElement
        {
            /*0x3d30108*/ RuntimeClipBase();
            double get_start();
            double get_duration();
            /*0x3d30764*/ long get_intervalStart();
            /*0x3d307d4*/ long get_intervalEnd();
        }

        class RuntimeElement : UnityEngine.Timeline.IInterval
        {
            /*0x10*/ int <intervalBit>k__BackingField;

            /*0x3d2fe3c*/ RuntimeElement();
            long get_intervalStart();
            long get_intervalEnd();
            /*0x3d30858*/ int get_intervalBit();
            /*0x3d30860*/ void set_intervalBit(int value);
            /*0x1f30a84*/ void set_enable(bool value);
            void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IMarker
        {
            double get_time();
            /*0x1f30b04*/ void set_time(double value);
            /*0x1f30214*/ UnityEngine.Timeline.TrackAsset get_parent();
            /*0x1f30ebc*/ void Initialize(UnityEngine.Timeline.TrackAsset parent);
        }

        interface INotificationOptionProvider
        {
            UnityEngine.Timeline.NotificationFlags get_flags();
        }

        struct MarkerList : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Objects;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> m_Cache;
            /*0x20*/ bool m_CacheDirty;
            /*0x21*/ bool m_HasNotifications;

            /*0x3d2f244*/ MarkerList(int capacity);
            /*0x3d30868*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> get_markers();
            /*0x3d2bc40*/ void Add(UnityEngine.ScriptableObject item);
            /*0x3d2ac78*/ bool Remove(UnityEngine.Timeline.IMarker item);
            /*0x3d2bd0c*/ bool Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty);
            /*0x3d2bb98*/ void Clear();
            /*0x3d2ae4c*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x3d2ae64*/ int get_Count();
            /*0x3d2aebc*/ UnityEngine.Timeline.IMarker get_Item(int idx);
            /*0x3d30b8c*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList();
            /*0x3d2a988*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time, UnityEngine.Timeline.TrackAsset owner);
            /*0x3d2f22c*/ bool HasNotifications();
            /*0x3d30b94*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3d30b98*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3d30880*/ void BuildCache();
        }

        class MarkerTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x3d30d18*/ MarkerTrack();
            /*0x3d30ba4*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class GroupTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x3d30dcc*/ GroupTrack();
            /*0x3d30d6c*/ bool CanCompileClips();
            /*0x3d30d74*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
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

            static /*0x3d30e28*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, double duration, UnityEngine.Playables.DirectorWrapMode loopMode);
            static /*0x3d31b78*/ bool CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, double currentTime, double previousTime);
            static /*0x3d31464*/ void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            static /*0x3d31bdc*/ void Restore_internal(ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            /*0x3d31bfc*/ TimeNotificationBehaviour();
            /*0x3d30e20*/ void set_timeSource(UnityEngine.Playables.Playable value);
            /*0x3d30f54*/ void AddNotification(double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags);
            /*0x3d31008*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x3d312d8*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3d314f4*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3d311b8*/ void SortNotifications();
            /*0x3d3196c*/ void TriggerNotificationsInRange(double start, double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, bool checkState);
            /*0x3d31858*/ void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable);

            struct NotificationEntry
            {
                /*0x10*/ double time;
                /*0x18*/ UnityEngine.Playables.INotification payload;
                /*0x20*/ bool notificationFired;
                /*0x22*/ UnityEngine.Timeline.NotificationFlags flags;

                /*0x3d31bf0*/ bool get_triggerInEditor();
                /*0x3d31be4*/ bool get_prewarm();
                /*0x3d312cc*/ bool get_triggerOnce();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TimeNotificationBehaviour.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> <>9__12_0;

                static /*0x3d31c84*/ <>c();
                /*0x3d31cec*/ <>c();
                /*0x3d31cf4*/ int <SortNotifications>b__12_0(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry x, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry y);
            }
        }

        class PlayableTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x3d31dac*/ PlayableTrack();
            /*0x3d31d04*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
        }

        class TrackClipTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type inspectedType;
            /*0x18*/ bool allowAutoCreate;

            /*0x3d31e00*/ TrackClipTypeAttribute(System.Type clipClass);
            /*0x3d31e3c*/ TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate);
        }

        class NotKeyableAttribute : System.Attribute
        {
            /*0x3d31e6c*/ NotKeyableAttribute();
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

            /*0x3d31e74*/ TrackBindingTypeAttribute(System.Type type);
        }

        class SupportsChildTracksAttribute : System.Attribute
        {
            /*0x10*/ System.Type childType;
            /*0x18*/ int levels;

            /*0x3d31eb0*/ SupportsChildTracksAttribute(System.Type childType, int levels);
        }

        class IgnoreOnPlayableTrackAttribute : System.Attribute
        {
            /*0x3d31eec*/ IgnoreOnPlayableTrackAttribute();
        }

        class FrameRateFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x3d31ef4*/ FrameRateFieldAttribute();
        }

        class HideInMenuAttribute : System.Attribute
        {
            /*0x3d31efc*/ HideInMenuAttribute();
        }

        interface ITimelineClipAsset
        {
            /*0x1f2ffc8*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
        }

        interface ITimelineEvaluateCallback
        {
            /*0x1f309e4*/ void Evaluate();
        }

        class TimelinePlayable : UnityEngine.Playables.PlayableBehaviour
        {
            static /*0x0*/ bool muteAudioScrubbing;
            /*0x10*/ UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> m_IntervalTree;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_ActiveClips;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.RuntimeElement> m_CurrentListOfActiveClips;
            /*0x28*/ int m_ActiveBit;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> m_EvaluateCallbacks;
            /*0x38*/ System.Collections.Generic.Dictionary<UnityEngine.Timeline.TrackAsset, UnityEngine.Playables.Playable> m_PlayableCache;

            static /*0x3d3392c*/ TimelinePlayable();
            static /*0x3d25ba0*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x3d337a8*/ TimelinePlayable();
            /*0x3d31f04*/ void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x3d321e4*/ void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool createOutputs);
            /*0x3d32934*/ void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, int port);
            /*0x3d32fd4*/ void EvaluateWeightsForAnimationPlayableOutput(UnityEngine.Timeline.TrackAsset track, UnityEngine.Animations.AnimationPlayableOutput animOutput);
            /*0x3d32534*/ UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, bool createOutputs);
            /*0x3d330e4*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3d33110*/ void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData);
            /*0x3d33068*/ void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable, int port, UnityEngine.Playables.Playable parent);
        }

        class Extrapolation
        {
            static /*0x0*/ double kMinExtrapolationTime;

            static /*0x3d33ab8*/ Extrapolation();
            static /*0x3d278a8*/ void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset);
            static /*0x3d33978*/ UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.Extrapolation.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;

                static /*0x3d33b3c*/ <>c();
                /*0x3d33ba4*/ <>c();
                /*0x3d33bac*/ int <SortClipsByStartTime>b__2_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }
        }

        class HashUtility
        {
            static /*0x3d1f9f4*/ int CombineHash(int h1, int h2);
            static /*0x3d2eb48*/ int CombineHash(int h1, int h2, int h3);
            static /*0x3d33bdc*/ int CombineHash(int h1, int h2, int h3, int h4);
            static /*0x3d33c18*/ int CombineHash(int h1, int h2, int h3, int h4, int h5);
            static /*0x3d23a6c*/ int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6);
        }

        interface IPropertyCollector
        {
            /*0x1f30ebc*/ void PushActiveGameObject(UnityEngine.GameObject gameObject);
            /*0x1f309e4*/ void PopActiveGameObject();
            /*0x1f30ebc*/ void AddFromClip(UnityEngine.AnimationClip clip);
            /*0x1f30ff0*/ void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip);
        }

        interface IPropertyPreview
        {
            /*0x1f30ff0*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
        }

        class NotificationUtilities
        {
            static /*0x3d2c6c8*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Playables.PlayableDirector director);
            static /*0x3d2c6d4*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Timeline.TimelineAsset timelineAsset);
            static /*0x3d33c64*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Playables.IPlayableAsset asset, UnityEngine.Playables.PlayableDirector director);
            static /*0x3d2a18c*/ bool TrackTypeSupportsNotifications(System.Type type);
        }

        class TimelineCreateUtilities
        {
            static /*0x3d26ff0*/ string GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, string name);
            static /*0x3d264cc*/ void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x3d2665c*/ void RemoveAssetFromObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x3d1f180*/ UnityEngine.AnimationClip CreateAnimationClipForTrack(string name, UnityEngine.Timeline.TrackAsset track, bool isLegacy);
            static /*0x3d26ce4*/ bool ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ string name;

                /*0x3d34450*/ <>c__DisplayClass0_0();
                /*0x3d34460*/ bool <GenerateUniqueActorName>b__0(UnityEngine.ScriptableObject x);
            }

            class <>c__DisplayClass0_1
            {
                /*0x10*/ string result;

                /*0x3d34458*/ <>c__DisplayClass0_1();
                /*0x3d34490*/ bool <GenerateUniqueActorName>b__1(UnityEngine.ScriptableObject x);
            }
        }

        class TimelineUndo
        {
            static /*0x3d276f0*/ void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy);
        }

        class TimeUtility
        {
            static /*0x0*/ double kTimeEpsilon;
            static /*0x8*/ double kFrameRateEpsilon;
            static /*0x10*/ double k_MaxTimelineDurationInSeconds;
            static /*0x18*/ double kFrameRateRounding;

            static /*0x3d344c0*/ TimeUtility();
            static /*0x3d1da1c*/ double GetAnimationClipLength(UnityEngine.AnimationClip clip);
        }

        class WeightUtility
        {
            static /*0x3d1d4d4*/ float NormalizeMixer(UnityEngine.Playables.Playable mixer);
        }
    }
}
