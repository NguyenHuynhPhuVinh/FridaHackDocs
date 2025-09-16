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

            /*0x7d8d744*/ AnimationOutputWeightProcessor(UnityEngine.Animations.AnimationPlayableOutput output);
            /*0x7d8d810*/ void FindMixers();
            /*0x7d8d8f8*/ void FindMixers(UnityEngine.Playables.Playable parent, int port, UnityEngine.Playables.Playable node);
            /*0x7d8dbe0*/ void Evaluate();

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

            static /*0x7d8ee20*/ AnimationPlayableAsset();
            static /*0x7d8e578*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.AnimationClip clip, UnityEngine.Vector3 positionOffset, UnityEngine.Vector3 eulerOffset, bool removeStartOffset, UnityEngine.Timeline.AppliedOffsetMode mode, bool applyFootIK, UnityEngine.Timeline.AnimationPlayableAsset.LoopMode loop);
            static /*0x7d8e968*/ bool ShouldApplyOffset(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.AnimationClip clip);
            static /*0x7d8e940*/ bool ShouldApplyScaleRemove(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x7d8e060*/ bool HasRootTransforms(UnityEngine.AnimationClip clip);
            /*0x7d8ed1c*/ AnimationPlayableAsset();
            /*0x7d8ded0*/ UnityEngine.Vector3 get_position();
            /*0x7d8dedc*/ void set_position(UnityEngine.Vector3 value);
            /*0x7d8dee8*/ UnityEngine.Quaternion get_rotation();
            /*0x7d8df0c*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x7d8df48*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x7d8df54*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x7d8df60*/ bool get_useTrackMatchFields();
            /*0x7d8df68*/ void set_useTrackMatchFields(bool value);
            /*0x7d8df74*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x7d8df7c*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x7d8df84*/ bool get_removeStartOffset();
            /*0x7d8df8c*/ void set_removeStartOffset(bool value);
            /*0x7d8df98*/ bool get_applyFootIK();
            /*0x7d8dfa0*/ void set_applyFootIK(bool value);
            /*0x7d8dfac*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_loop();
            /*0x7d8dfb4*/ void set_loop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x7d8dfbc*/ bool get_hasRootTransforms();
            /*0x7d8e12c*/ UnityEngine.Timeline.AppliedOffsetMode get_appliedOffsetMode();
            /*0x7d8e134*/ void set_appliedOffsetMode(UnityEngine.Timeline.AppliedOffsetMode value);
            /*0x7d8e13c*/ UnityEngine.AnimationClip get_clip();
            /*0x7d8e144*/ void set_clip(UnityEngine.AnimationClip value);
            /*0x7d8e20c*/ double get_duration();
            /*0x7d8e3f0*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7d8e4a0*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x7d8e9dc*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7d8eac4*/ void ResetOffsets();
            /*0x7d8eb30*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7d8ebdc*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7d8ec3c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7d8ecc0*/ void OnUpgradeFromVersion(int oldVersion);

            enum LoopMode
            {
                UseSourceAsset = 0,
                On = 1,
                Off = 2,
            }

            class AnimationPlayableAssetUpgrade
            {
                static /*0x7d8ecd0*/ void ConvertRotationToEuler(UnityEngine.Timeline.AnimationPlayableAsset asset);
            }

            class <get_outputs>d__45 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationPlayableAsset <>4__this;

                /*0x7d8e46c*/ <get_outputs>d__45(int <>1__state);
                /*0x7d8ee6c*/ void System.IDisposable.Dispose();
                /*0x7d8ee70*/ bool MoveNext();
                /*0x7d8ef0c*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7d8ef1c*/ void System.Collections.IEnumerator.Reset();
                /*0x7d8ef54*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d8efb4*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7d8f058*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7d8f05c*/ MatchTargetFieldConstants();
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

            static /*0x7d936ac*/ AnimationTrack();
            static /*0x7d92148*/ bool UsesAbsoluteMotion(UnityEngine.Timeline.AppliedOffsetMode mode);
            static /*0x7d91c48*/ UnityEngine.Animations.AnimationLayerMixerPlayable CreateGroupMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            static /*0x7d93048*/ UnityEngine.Transform FindInHierarchyBreadthFirst(UnityEngine.Transform t, string name);
            /*0x7d93430*/ AnimationTrack();
            /*0x7d8f0ac*/ UnityEngine.Vector3 get_position();
            /*0x7d8f0b8*/ void set_position(UnityEngine.Vector3 value);
            /*0x7d8f0c4*/ UnityEngine.Quaternion get_rotation();
            /*0x7d8f0e8*/ void set_rotation(UnityEngine.Quaternion value);
            /*0x7d8f124*/ UnityEngine.Vector3 get_eulerAngles();
            /*0x7d8f130*/ void set_eulerAngles(UnityEngine.Vector3 value);
            /*0x7d8f13c*/ bool get_applyOffsets();
            /*0x7d8f144*/ void set_applyOffsets(bool value);
            /*0x7d8f148*/ UnityEngine.Timeline.TrackOffset get_trackOffset();
            /*0x7d8f150*/ void set_trackOffset(UnityEngine.Timeline.TrackOffset value);
            /*0x7d8f158*/ UnityEngine.Timeline.MatchTargetFields get_matchTargetFields();
            /*0x7d8f160*/ void set_matchTargetFields(UnityEngine.Timeline.MatchTargetFields value);
            /*0x7d8f1d0*/ UnityEngine.AnimationClip get_infiniteClip();
            /*0x7d8f1d8*/ void set_infiniteClip(UnityEngine.AnimationClip value);
            /*0x7d8f1e8*/ bool get_infiniteClipRemoveOffset();
            /*0x7d8f1f0*/ void set_infiniteClipRemoveOffset(bool value);
            /*0x7d8f1fc*/ UnityEngine.AvatarMask get_avatarMask();
            /*0x7d8f204*/ void set_avatarMask(UnityEngine.AvatarMask value);
            /*0x7d8f20c*/ bool get_applyAvatarMask();
            /*0x7d8f214*/ void set_applyAvatarMask(bool value);
            /*0x7d8f220*/ bool CanCompileClips();
            /*0x7d8f2dc*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7d8f38c*/ bool get_inClipMode();
            /*0x7d8f490*/ UnityEngine.Vector3 get_infiniteClipOffsetPosition();
            /*0x7d8f49c*/ void set_infiniteClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x7d8f4a8*/ UnityEngine.Quaternion get_infiniteClipOffsetRotation();
            /*0x7d8f4cc*/ void set_infiniteClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x7d8f508*/ UnityEngine.Vector3 get_infiniteClipOffsetEulerAngles();
            /*0x7d8f514*/ void set_infiniteClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x7d8f520*/ bool get_infiniteClipApplyFootIK();
            /*0x7d8f528*/ void set_infiniteClipApplyFootIK(bool value);
            /*0x7d8f534*/ double get_infiniteClipTimeOffset();
            /*0x7d8f53c*/ void set_infiniteClipTimeOffset(double value);
            /*0x7d8f544*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPreExtrapolation();
            /*0x7d8f54c*/ void set_infiniteClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7d8f554*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_infiniteClipPostExtrapolation();
            /*0x7d8f55c*/ void set_infiniteClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7d8f564*/ UnityEngine.Timeline.AnimationPlayableAsset.LoopMode get_infiniteClipLoop();
            /*0x7d8f56c*/ void set_infiniteClipLoop(UnityEngine.Timeline.AnimationPlayableAsset.LoopMode value);
            /*0x7d8f574*/ void ResetOffsets();
            /*0x7d8f5e4*/ UnityEngine.Timeline.TimelineClip CreateClip(UnityEngine.AnimationClip clip);
            /*0x7d8f8c0*/ void CreateInfiniteClip(string infiniteClipName);
            /*0x7d8fb8c*/ UnityEngine.Timeline.TimelineClip CreateRecordableClip(string animClipName);
            /*0x7d8ff2c*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7d900e8*/ int CalculateItemsHash();
            /*0x7d8f5e0*/ void UpdateClipOffsets();
            /*0x7d90310*/ UnityEngine.Playables.Playable CompileTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.AnimationTrack track, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x7d90cd8*/ UnityEngine.Playables.Playable UnityEngine.Timeline.ILayerable.CreateLayerMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x7d90d28*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x7d91c40*/ int GetDefaultBlendCount();
            /*0x7d92144*/ void AttachDefaultBlend(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Animations.AnimationLayerMixerPlayable mixer, bool requireOffset);
            /*0x7d92160*/ UnityEngine.Playables.Playable AttachOffsetPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable playable, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
            /*0x7d92034*/ bool RequiresMotionXPlayable(UnityEngine.Timeline.AppliedOffsetMode mode, UnityEngine.GameObject gameObject);
            /*0x7d9249c*/ bool HasController(UnityEngine.GameObject gameObject);
            /*0x7d922b8*/ UnityEngine.Animator GetBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x7d91cbc*/ UnityEngine.Playables.Playable CreateInfiniteTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x7d90b28*/ UnityEngine.Playables.Playable ApplyTrackOffset(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable root, UnityEngine.GameObject go, UnityEngine.Timeline.AppliedOffsetMode mode);
            /*0x7d925e8*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x7d92878*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x7d8f68c*/ void AssignAnimationClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.AnimationClip animClip);
            /*0x7d92ae4*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7d92ae8*/ void GetAnimationClips(System.Collections.Generic.List<UnityEngine.AnimationClip> animClips);
            /*0x7d91b5c*/ UnityEngine.Timeline.AppliedOffsetMode GetOffsetMode(UnityEngine.GameObject go, bool animatesRootTransform);
            /*0x7d918e0*/ bool IsRootTransformDisabledByMask(UnityEngine.GameObject gameObject, UnityEngine.Transform genericRootNode);
            /*0x7d916f8*/ UnityEngine.Transform GetGenericRootNode(UnityEngine.GameObject gameObject);
            /*0x7d9075c*/ bool AnimatesRootTransform();
            /*0x7d93220*/ UnityEngine.Vector3 get_openClipOffsetPosition();
            /*0x7d9322c*/ void set_openClipOffsetPosition(UnityEngine.Vector3 value);
            /*0x7d93238*/ UnityEngine.Quaternion get_openClipOffsetRotation();
            /*0x7d9325c*/ void set_openClipOffsetRotation(UnityEngine.Quaternion value);
            /*0x7d93260*/ UnityEngine.Vector3 get_openClipOffsetEulerAngles();
            /*0x7d9326c*/ void set_openClipOffsetEulerAngles(UnityEngine.Vector3 value);
            /*0x7d93278*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPreExtrapolation();
            /*0x7d93280*/ void set_openClipPreExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7d93288*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_openClipPostExtrapolation();
            /*0x7d93290*/ void set_openClipPostExtrapolation(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7d93298*/ void OnUpgradeFromVersion(int oldVersion);

            class AnimationTrackUpgrade
            {
                static /*0x7d932dc*/ void ConvertRotationsToEuler(UnityEngine.Timeline.AnimationTrack track);
                static /*0x7d93378*/ void ConvertRootMotion(UnityEngine.Timeline.AnimationTrack track);
                static /*0x7d933fc*/ void ConvertInfiniteTrack(UnityEngine.Timeline.AnimationTrack track);
            }

            class <get_outputs>d__49 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.AnimationTrack <>4__this;

                /*0x7d8f358*/ <get_outputs>d__49(int <>1__state);
                /*0x7d93748*/ void System.IDisposable.Dispose();
                /*0x7d9374c*/ bool MoveNext();
                /*0x7d937e8*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7d937f8*/ void System.Collections.IEnumerator.Reset();
                /*0x7d93830*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d93890*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7d93934*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        interface ICurvesOwner
        {
            /*0x380b9e8*/ string get_defaultCurvesName();
            /*0x380b9e8*/ UnityEngine.Object get_asset();
            /*0x380b9e8*/ UnityEngine.Object get_assetOwner();
            /*0x380b9e8*/ UnityEngine.Timeline.TrackAsset get_targetTrack();
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

            static /*0x7d94f80*/ TimelineClip();
            static /*0x7d944a0*/ UnityEngine.AnimationCurve GetDefaultMixInCurve();
            static /*0x7d94598*/ UnityEngine.AnimationCurve GetDefaultMixOutCurve();
            static /*0x7d93cc4*/ double SanitizeTimeValue(double value, double defaultValue);
            static /*0x7d94a7c*/ double GetExtrapolatedTime(double time, UnityEngine.Timeline.TimelineClip.ClipExtrapolation mode, double duration);
            /*0x7d939b0*/ TimelineClip(UnityEngine.Timeline.TrackAsset parent);
            /*0x7d93938*/ void UpgradeToLatestVersion();
            /*0x7d93af4*/ double get_timeScale();
            /*0x7d93cbc*/ double get_start();
            /*0x7d8fcd4*/ void set_start(double value);
            /*0x7d93e90*/ double get_duration();
            /*0x7d8fe14*/ void set_duration(double value);
            /*0x7d93e98*/ double get_end();
            /*0x7d93ea8*/ double get_clipIn();
            /*0x7d93ec8*/ string get_displayName();
            /*0x7d93ed0*/ void set_displayName(string value);
            /*0x7d93ed8*/ UnityEngine.AnimationClip get_curves();
            /*0x7d93ee0*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x7d93f38*/ UnityEngine.Object get_asset();
            /*0x7d93f40*/ void set_asset(UnityEngine.Object value);
            /*0x7d93f48*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x7d93f50*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x7d93f58*/ UnityEngine.Timeline.TrackAsset GetParentTrack();
            /*0x7d939ec*/ void SetParentTrack_Internal(UnityEngine.Timeline.TrackAsset newParentTrack);
            /*0x7d940dc*/ double get_easeInDuration();
            /*0x7d941c4*/ double get_easeOutDuration();
            /*0x7d942ac*/ double get_blendInDuration();
            /*0x7d942cc*/ void set_blendInDuration(double value);
            /*0x7d94354*/ double get_blendOutDuration();
            /*0x7d94374*/ void set_blendOutDuration(double value);
            /*0x7d943fc*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode get_blendInCurveMode();
            /*0x7d94404*/ UnityEngine.Timeline.TimelineClip.BlendCurveMode get_blendOutCurveMode();
            /*0x7d94280*/ bool get_hasBlendIn();
            /*0x7d94198*/ bool get_hasBlendOut();
            /*0x7d9440c*/ UnityEngine.AnimationCurve get_mixInCurve();
            /*0x7d944b8*/ void set_mixInCurve(UnityEngine.AnimationCurve value);
            /*0x7d944c0*/ double get_mixInDuration();
            /*0x7d94504*/ UnityEngine.AnimationCurve get_mixOutCurve();
            /*0x7d945b0*/ void set_mixOutCurve(UnityEngine.AnimationCurve value);
            /*0x7d945b8*/ double get_mixOutTime();
            /*0x7d945e4*/ double get_mixOutDuration();
            /*0x7d94628*/ bool get_recordable();
            /*0x7d94630*/ void set_recordable(bool value);
            /*0x7d93bcc*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7d9463c*/ int Hash();
            /*0x7d94774*/ float EvaluateMixOut(double time);
            /*0x7d94868*/ float EvaluateMixIn(double time);
            /*0x7d9493c*/ double ToLocalTime(double time);
            /*0x7d94bf0*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_postExtrapolationMode();
            /*0x7d900b4*/ void set_postExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7d94c14*/ UnityEngine.Timeline.TimelineClip.ClipExtrapolation get_preExtrapolationMode();
            /*0x7d90080*/ void set_preExtrapolationMode(UnityEngine.Timeline.TimelineClip.ClipExtrapolation value);
            /*0x7d94c38*/ void SetPostExtrapolationTime(double time);
            /*0x7d94c40*/ void SetPreExtrapolationTime(double time);
            /*0x7d94a2c*/ bool IsPreExtrapolatedTime(double sequenceTime);
            /*0x7d94b98*/ bool IsPostExtrapolatedTime(double sequenceTime);
            /*0x7d94c48*/ double get_extrapolatedStart();
            /*0x7d94c60*/ double get_extrapolatedDuration();
            /*0x7d94d2c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7d94d38*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7d94d74*/ string ToString();
            /*0x7d93de0*/ void UpdateDirty(double oldValue, double newValue);

            class TimelineClipUpgrade
            {
                static /*0x7d93974*/ void UpgradeClipInFromGlobalToLocal(UnityEngine.Timeline.TimelineClip clip);
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

            static /*0x7d95ec0*/ double GetValidFrameRate(double frameRate);
            static /*0x7d961a8*/ void AddSubTracksRecursive(UnityEngine.Timeline.TrackAsset track, ref System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> allTracks);
            /*0x7d993d0*/ TimelineAsset();
            /*0x7d95010*/ void UpgradeToLatestVersion();
            /*0x7d95014*/ UnityEngine.Timeline.TimelineAsset.EditorSettings get_editorSettings();
            /*0x7d9501c*/ double get_duration();
            /*0x7d952c4*/ double get_fixedDuration();
            /*0x7d95394*/ void set_fixedDuration(double value);
            /*0x7d95404*/ UnityEngine.Timeline.TimelineAsset.DurationMode get_durationMode();
            /*0x7d9540c*/ void set_durationMode(UnityEngine.Timeline.TimelineAsset.DurationMode value);
            /*0x7d95414*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7d954c4*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
            /*0x7d95828*/ int get_outputTrackCount();
            /*0x7d95a98*/ int get_rootTrackCount();
            /*0x7d95e98*/ void OnValidate();
            /*0x7d95f84*/ UnityEngine.Timeline.TrackAsset GetRootTrack(int index);
            /*0x7d95810*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetRootTracks();
            /*0x7d95fe4*/ UnityEngine.Timeline.TrackAsset GetOutputTrack(int index);
            /*0x7d96028*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetOutputTracks();
            /*0x7d95ae8*/ void UpdateRootTrackCache();
            /*0x7d9584c*/ void UpdateOutputTrackCache();
            /*0x7d96040*/ UnityEngine.Timeline.TrackAsset[] get_flattenedTracks();
            /*0x7d964f8*/ UnityEngine.Timeline.MarkerTrack get_markerTrack();
            /*0x7d96500*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_trackObjects();
            /*0x7d96508*/ void AddTrackInternal(UnityEngine.Timeline.TrackAsset track);
            /*0x7d96604*/ void RemoveTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x7d96790*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x7d96b68*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7d96b70*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7d96b74*/ void __internalAwake();
            /*0x7d96cf8*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7d971b4*/ void CreateMarkerTrack();
            /*0x7d9739c*/ void RemoveMarkerTrack();
            /*0x7d965cc*/ void Invalidate();
            /*0x7d974e0*/ void UpdateFixedDurationWithItemsDuration();
            /*0x7d950cc*/ UnityEngine.Timeline.DiscreteTime CalculateItemsDuration();
            /*0x7d9767c*/ UnityEngine.Timeline.TrackAsset CreateTrack(System.Type type, UnityEngine.Timeline.TrackAsset parent, string name);
            /*0x3907c14*/ T CreateTrack<T>(UnityEngine.Timeline.TrackAsset parent, string trackName);
            /*0x3907c14*/ T CreateTrack<T>(string trackName);
            /*0x3907c14*/ T CreateTrack<T>();
            /*0x7d98328*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7d98a60*/ bool DeleteTrack(UnityEngine.Timeline.TrackAsset track);
            /*0x7d990cc*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x7d980c8*/ UnityEngine.Timeline.TrackAsset AllocateTrack(UnityEngine.Timeline.TrackAsset trackAssetParent, string trackName, System.Type trackType);
            /*0x7d98f9c*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TrackAsset track);
            /*0x7d9855c*/ void DeleteRecordedAnimation(UnityEngine.Timeline.TimelineClip clip);

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

                static /*0x7d994b0*/ EditorSettings();
                /*0x7d99438*/ EditorSettings();
                /*0x7d994a8*/ double get_frameRate();
                /*0x7d95f6c*/ void set_frameRate(double value);
            }

            class <get_outputs>d__27 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TimelineAsset <>4__this;
                /*0x48*/ System.Collections.Generic.IEnumerator<UnityEngine.Timeline.TrackAsset> <>7__wrap1;
                /*0x50*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> <>7__wrap2;

                /*0x7d95490*/ <get_outputs>d__27(int <>1__state);
                /*0x7d99534*/ void System.IDisposable.Dispose();
                /*0x7d995e4*/ bool MoveNext();
                /*0x7d99b20*/ void <>m__Finally1();
                /*0x7d99a70*/ void <>m__Finally2();
                /*0x7d99bd0*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7d99be0*/ void System.Collections.IEnumerator.Reset();
                /*0x7d99c18*/ object System.Collections.IEnumerator.get_Current();
                /*0x7d99c78*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7d99d1c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7da01e0*/ TrackAsset();
            static /*0x7d9a3a8*/ void add_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7d9a49c*/ void remove_OnClipPlayableCreate(System.Action<UnityEngine.Timeline.TimelineClip, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7d9a590*/ void add_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7d9a684*/ void remove_OnTrackAnimationPlayableCreate(System.Action<UnityEngine.Timeline.TrackAsset, UnityEngine.GameObject, UnityEngine.Playables.Playable> value);
            static /*0x7d90168*/ int GetAnimationClipHash(UnityEngine.AnimationClip clip);
            /*0x7d935c0*/ TrackAsset();
            /*0x7d99d20*/ void OnBeforeTrackSerialize();
            /*0x7d99d24*/ void OnAfterTrackDeserialize();
            /*0x7d99d28*/ void OnUpgradeFromVersion(int oldVersion);
            /*0x7d99d2c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7d99f28*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7d9a388*/ void UpgradeToLatestVersion();
            /*0x7d9a778*/ double get_start();
            /*0x7d975b4*/ double get_end();
            /*0x7d9a8e0*/ double get_duration();
            /*0x7d9a948*/ bool get_muted();
            /*0x7d9a950*/ void set_muted(bool value);
            /*0x7d97010*/ bool get_mutedInHierarchy();
            /*0x7d97960*/ UnityEngine.Timeline.TimelineAsset get_timelineAsset();
            /*0x7d9a95c*/ UnityEngine.Playables.PlayableAsset get_parent();
            /*0x7d9a964*/ void set_parent(UnityEngine.Playables.PlayableAsset value);
            /*0x7d9321c*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TimelineClip> GetClips();
            /*0x7d8f3c0*/ UnityEngine.Timeline.TimelineClip[] get_clips();
            /*0x7d9a96c*/ bool get_blendsValid();
            /*0x7d9a974*/ void set_blendsValid(bool value);
            /*0x7d9a980*/ bool get_isEmpty();
            /*0x7d9a9ec*/ bool get_hasClips();
            /*0x7d9aa40*/ bool get_hasCurves();
            /*0x7d8ff6c*/ bool get_isSubTrack();
            /*0x7d9aad4*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
            /*0x7d91b44*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> GetChildTracks();
            /*0x7d9adb8*/ string get_customPlayableTypename();
            /*0x7d9adc0*/ void set_customPlayableTypename(string value);
            /*0x7d9adc8*/ UnityEngine.AnimationClip get_curves();
            /*0x7d9add0*/ void set_curves(UnityEngine.AnimationClip value);
            /*0x7d9add8*/ string UnityEngine.Timeline.ICurvesOwner.get_defaultCurvesName();
            /*0x7d9ae18*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_asset();
            /*0x7d9ae1c*/ UnityEngine.Object UnityEngine.Timeline.ICurvesOwner.get_assetOwner();
            /*0x7d9ae20*/ UnityEngine.Timeline.TrackAsset UnityEngine.Timeline.ICurvesOwner.get_targetTrack();
            /*0x7d9ae24*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> get_subTracksObjects();
            /*0x7d9ae2c*/ bool get_locked();
            /*0x7d9ae34*/ void set_locked(bool value);
            /*0x7d9ae40*/ bool get_lockedInHierarchy();
            /*0x7d9afe4*/ bool get_supportsNotifications();
            /*0x7d9b208*/ void __internalAwake();
            /*0x7d9b2f8*/ void CreateCurves(string curvesClipName);
            /*0x7d9b3c4*/ UnityEngine.Playables.Playable CreateTrackMixer(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, int inputCount);
            /*0x7d9b434*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go);
            /*0x7d9b484*/ UnityEngine.Timeline.TimelineClip CreateDefaultClip();
            /*0x380b9e8*/ UnityEngine.Timeline.TimelineClip CreateClip<T>();
            /*0x7d9b774*/ bool DeleteClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7d9b884*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time);
            /*0x3907c14*/ T CreateMarker<T>(double time);
            /*0x7d9bb78*/ bool DeleteMarker(UnityEngine.Timeline.IMarker marker);
            /*0x7d9a38c*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x7d9aacc*/ int GetMarkerCount();
            /*0x7d9bdc0*/ UnityEngine.Timeline.IMarker GetMarker(int idx);
            /*0x7d9be28*/ UnityEngine.Timeline.TimelineClip CreateClip(System.Type requestedType);
            /*0x7d9b744*/ UnityEngine.Timeline.TimelineClip CreateAndAddNewClipOfType(System.Type requestedType);
            /*0x7d9c19c*/ UnityEngine.Timeline.TimelineClip CreateClipOfType(System.Type requestedType);
            /*0x7d9c5c8*/ UnityEngine.Timeline.TimelineClip CreateClipFromPlayableAsset(UnityEngine.Playables.IPlayableAsset asset);
            /*0x7d9c348*/ UnityEngine.Timeline.TimelineClip CreateClipFromAsset(UnityEngine.ScriptableObject playableAsset);
            /*0x7d9ca5c*/ System.Collections.Generic.IEnumerable<UnityEngine.ScriptableObject> GetMarkersRaw();
            /*0x7d9ca64*/ void ClearMarkers();
            /*0x7d9cadc*/ void AddMarker(UnityEngine.ScriptableObject e);
            /*0x7d9cbd8*/ bool DeleteMarkerRaw(UnityEngine.ScriptableObject marker);
            /*0x7d9cca8*/ int GetTimeRangeHash();
            /*0x7d93fe0*/ void AddClip(UnityEngine.Timeline.TimelineClip newClip);
            /*0x7d9cf68*/ UnityEngine.Playables.Playable CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable mixerPlayable, UnityEngine.GameObject go, UnityEngine.Playables.Playable timelinePlayable);
            /*0x7d9d5cc*/ UnityEngine.Playables.Playable CreatePlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.Playables.Playable timelinePlayable);
            /*0x7d9dca0*/ UnityEngine.Playables.Playable CompileClips(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, System.Collections.Generic.IList<UnityEngine.Timeline.TimelineClip> timelineClips, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x7d9e21c*/ void GatherCompilableTracks(System.Collections.Generic.IList<UnityEngine.Timeline.TrackAsset> tracks);
            /*0x7d9d23c*/ void GatherNotifications(System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markers);
            /*0x7d9e620*/ UnityEngine.Playables.Playable CreateMixerPlayableGraph(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree);
            /*0x7d9e0c4*/ void ConfigureTrackAnimation(UnityEngine.Timeline.IntervalTree<UnityEngine.Timeline.RuntimeElement> tree, UnityEngine.GameObject go, UnityEngine.Playables.Playable blend);
            /*0x7d9ebc0*/ void SortClips();
            /*0x7d9ece8*/ void ClearClipsInternal();
            /*0x7d9ed74*/ void ClearSubTracksInternal();
            /*0x7d93de4*/ void OnClipMove(UnityEngine.Timeline.ITimelineClipAsset clip);
            /*0x7d9c818*/ UnityEngine.Timeline.TimelineClip CreateNewClipContainerInternal();
            /*0x7d992bc*/ void AddChild(UnityEngine.Timeline.TrackAsset child);
            /*0x7d9edf8*/ void MoveLastTrackBefore(UnityEngine.Timeline.TrackAsset asset);
            /*0x7d9670c*/ bool RemoveSubTrack(UnityEngine.Timeline.TrackAsset child);
            /*0x7d93f60*/ void RemoveClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7d92684*/ void GetEvaluationTime(ref double outStart, ref double outDuration);
            /*0x7d92970*/ void GetSequenceTime(ref double outStart, ref double outDuration);
            /*0x7d9f004*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
            /*0x7d9f6dc*/ UnityEngine.GameObject GetGameObjectBinding(UnityEngine.Playables.PlayableDirector director);
            /*0x7d9bf28*/ bool ValidateClipType(System.Type clipType);
            /*0x7d9f854*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
            /*0x7d9a7d8*/ void UpdateDuration();
            /*0x7d90250*/ int CalculateItemsHash();
            /*0x7d9f9f8*/ UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject gameObject, UnityEngine.Timeline.TimelineClip clip);
            /*0x7d9a2ec*/ void Invalidate();
            /*0x7d92980*/ double GetNotificationDuration();
            /*0x7d9fc94*/ bool CanCompileClips();
            /*0x7d9fcf0*/ bool CanCreateTrackMixer();
            /*0x7d9fd00*/ bool IsCompilable();
            /*0x7d9ab84*/ void UpdateChildTrackCache();
            /*0x7da00a8*/ int Hash();
            /*0x7d9f858*/ int GetClipsHash();
            /*0x7d9efe8*/ bool HasNotifications();
            /*0x7d9e5ec*/ bool CanCompileNotifications();
            /*0x7d9d8a4*/ bool CanCreateMixerRecursive();

            struct TransientBuildData
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Timeline.TrackAsset> trackList;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.TimelineClip> clipList;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> markerList;

                static /*0x7da02e0*/ UnityEngine.Timeline.TrackAsset.TransientBuildData Create();
                /*0x7d9dbc0*/ void Clear();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TrackAsset.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__125_0;

                static /*0x7da043c*/ <>c();
                /*0x7da04a4*/ <>c();
                /*0x7da04ac*/ int <SortClips>b__125_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }

            class <get_outputs>d__69 : System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ UnityEngine.Playables.PlayableBinding <>2__current;
                /*0x38*/ int <>l__initialThreadId;
                /*0x40*/ UnityEngine.Timeline.TrackAsset <>4__this;

                /*0x7d9ab50*/ <get_outputs>d__69(int <>1__state);
                /*0x7da04e0*/ void System.IDisposable.Dispose();
                /*0x7da04e4*/ bool MoveNext();
                /*0x7da0728*/ UnityEngine.Playables.PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current();
                /*0x7da0738*/ void System.Collections.IEnumerator.Reset();
                /*0x7da0770*/ object System.Collections.IEnumerator.get_Current();
                /*0x7da07d0*/ System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator();
                /*0x7da0874*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TrackColorAttribute : System.Attribute
        {
            /*0x10*/ UnityEngine.Color m_Color;

            /*0x7da0878*/ TrackColorAttribute(float r, float g, float b);
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
            static /*0x7da08bc*/ bool SupportsExtrapolation(UnityEngine.Timeline.TimelineClip clip);
            static /*0x7d9cf50*/ bool SupportsBlending(UnityEngine.Timeline.TimelineClip clip);
            static /*0x7d93cb0*/ bool HasAny(UnityEngine.Timeline.ClipCaps caps, UnityEngine.Timeline.ClipCaps flags);
        }

        class CurveEditUtility
        {
            static /*0x7da08d4*/ UnityEngine.AnimationCurve CreateMatchingCurve(UnityEngine.AnimationCurve curve);
        }

        struct DiscreteTime : System.IComparable
        {
            static double k_Tick = 1e-12;
            static /*0x0*/ UnityEngine.Timeline.DiscreteTime kMaxTime;
            /*0x10*/ long m_DiscreteTime;

            static /*0x7da0e20*/ DiscreteTime();
            static /*0x7da0a70*/ double get_tickValue();
            static /*0x7da0bec*/ UnityEngine.Timeline.DiscreteTime FromTicks(long ticks);
            static /*0x7da0aec*/ long DoubleToDiscreteTime(double time);
            static /*0x7da0b8c*/ long IntToDiscreteTime(int time);
            static /*0x7da0d24*/ double ToDouble(long time);
            static /*0x7d95264*/ double op_Explicit(UnityEngine.Timeline.DiscreteTime b);
            static /*0x7d95378*/ UnityEngine.Timeline.DiscreteTime op_Explicit(double time);
            static /*0x7d9522c*/ UnityEngine.Timeline.DiscreteTime op_Implicit(int time);
            static /*0x7da0d38*/ bool op_Equality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7da0d44*/ bool op_Inequality(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7d9524c*/ bool op_LessThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7da0da8*/ bool op_GreaterThanOrEqual(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7d9a940*/ UnityEngine.Timeline.DiscreteTime op_Subtraction(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7d97614*/ UnityEngine.Timeline.DiscreteTime Max(UnityEngine.Timeline.DiscreteTime lhs, UnityEngine.Timeline.DiscreteTime rhs);
            static /*0x7da0dc4*/ long GetNearestTick(double time);
            /*0x7da0a7c*/ DiscreteTime(long time);
            /*0x7da0a84*/ DiscreteTime(double time);
            /*0x7d9754c*/ DiscreteTime(int time);
            /*0x7d95258*/ UnityEngine.Timeline.DiscreteTime OneTickBefore();
            /*0x7da0be0*/ UnityEngine.Timeline.DiscreteTime OneTickAfter();
            /*0x7da0bf0*/ int CompareTo(object obj);
            /*0x7da0c6c*/ bool Equals(UnityEngine.Timeline.DiscreteTime other);
            /*0x7da0c7c*/ bool Equals(object obj);
            /*0x7da0db4*/ string ToString();
            /*0x7da0dbc*/ int GetHashCode();
        }

        class InfiniteRuntimeClip : UnityEngine.Timeline.RuntimeElement
        {
            static /*0x0*/ long kIntervalEnd;
            /*0x18*/ UnityEngine.Playables.Playable m_Playable;

            static /*0x7da100c*/ InfiniteRuntimeClip();
            /*0x7d925bc*/ InfiniteRuntimeClip(UnityEngine.Playables.Playable playable);
            /*0x7da0e74*/ long get_intervalStart();
            /*0x7da0e7c*/ long get_intervalEnd();
            /*0x7da0ed4*/ void set_enable(bool value);
            /*0x7da0f48*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x7da0fa0*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IInterval
        {
            /*0x380b828*/ long get_intervalStart();
            /*0x380b828*/ long get_intervalEnd();
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

            /*0x380cb08*/ IntervalTree();
            /*0x380b128*/ bool get_dirty();
            /*0x380cdf0*/ void set_dirty(bool value);
            /*0x3907c14*/ void Add(T item);
            void IntersectsWith(long value, System.Collections.Generic.List<T> results);
            /*0x3907c14*/ void Query(UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long value, System.Collections.Generic.List<T> results);
            /*0x380cb08*/ void Rebuild();
            /*0x380b710*/ int Rebuild(int start, int end);

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

            /*0x7d90700*/ RuntimeClip(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x7da10bc*/ double get_start();
            /*0x7da10e8*/ double get_duration();
            /*0x7da1108*/ void Create(UnityEngine.Timeline.TimelineClip clip, UnityEngine.Playables.Playable clipPlayable, UnityEngine.Playables.Playable parentMixer);
            /*0x7da1198*/ UnityEngine.Timeline.TimelineClip get_clip();
            /*0x7da11a0*/ UnityEngine.Playables.Playable get_mixer();
            /*0x7da11ac*/ UnityEngine.Playables.Playable get_playable();
            /*0x7da11b8*/ void set_enable(bool value);
            /*0x7da12ec*/ void SetTime(double time);
            /*0x7da1344*/ void SetDuration(double duration);
            /*0x7da139c*/ void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            /*0x7da1594*/ void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        class RuntimeClipBase : UnityEngine.Timeline.RuntimeElement
        {
            /*0x7da1100*/ RuntimeClipBase();
            /*0x380b564*/ double get_start();
            /*0x380b564*/ double get_duration();
            /*0x7da16ec*/ long get_intervalStart();
            /*0x7da175c*/ long get_intervalEnd();
        }

        class RuntimeElement : UnityEngine.Timeline.IInterval
        {
            /*0x10*/ int <intervalBit>k__BackingField;

            /*0x7da0e6c*/ RuntimeElement();
            /*0x380b828*/ long get_intervalStart();
            /*0x380b828*/ long get_intervalEnd();
            /*0x7da17e0*/ int get_intervalBit();
            /*0x7da17e8*/ void set_intervalBit(int value);
            /*0x380cdf0*/ void set_enable(bool value);
            void EvaluateAt(double localTime, UnityEngine.Playables.FrameData frameData);
            void DisableAt(double localTime, double rootDuration, UnityEngine.Playables.FrameData frameData);
        }

        interface IMarker
        {
            /*0x380b564*/ double get_time();
            /*0x380cee0*/ void set_time(double value);
            /*0x380b9e8*/ UnityEngine.Timeline.TrackAsset get_parent();
            /*0x380d83c*/ void Initialize(UnityEngine.Timeline.TrackAsset parent);
        }

        interface INotificationOptionProvider
        {
            /*0x380b674*/ UnityEngine.Timeline.NotificationFlags get_flags();
        }

        struct MarkerList : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> m_Objects;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> m_Cache;
            /*0x20*/ bool m_CacheDirty;
            /*0x21*/ bool m_HasNotifications;

            /*0x7da00f8*/ MarkerList(int capacity);
            /*0x7da17f0*/ System.Collections.Generic.List<UnityEngine.Timeline.IMarker> get_markers();
            /*0x7d9cae4*/ void Add(UnityEngine.ScriptableObject item);
            /*0x7d9bb80*/ bool Remove(UnityEngine.Timeline.IMarker item);
            /*0x7d9cc08*/ bool Remove(UnityEngine.ScriptableObject item, UnityEngine.Timeline.TimelineAsset timelineAsset, UnityEngine.Playables.PlayableAsset thingToDirty);
            /*0x7d9ca6c*/ void Clear();
            /*0x7d9bd58*/ System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> GetMarkers();
            /*0x7d9bd70*/ int get_Count();
            /*0x7d9bdc8*/ UnityEngine.Timeline.IMarker get_Item(int idx);
            /*0x7da1aec*/ System.Collections.Generic.List<UnityEngine.ScriptableObject> GetRawMarkerList();
            /*0x7d9b890*/ UnityEngine.Timeline.IMarker CreateMarker(System.Type type, double time, UnityEngine.Timeline.TrackAsset owner);
            /*0x7da00e0*/ bool HasNotifications();
            /*0x7da1af4*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7da1af8*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x7da1808*/ void BuildCache();
        }

        class MarkerTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x7da1cdc*/ MarkerTrack();
            /*0x7da1b04*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class TrackAssetExtensions
        {
            static /*0x7d99ea0*/ void ComputeBlendsFromOverlaps(UnityEngine.Timeline.TrackAsset asset, bool force);
        }

        class GroupTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x7da1fd0*/ GroupTrack();
            /*0x7da1f70*/ bool CanCompileClips();
            /*0x7da1f78*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
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

            static /*0x7da202c*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> Create(UnityEngine.Playables.PlayableGraph graph, double duration, UnityEngine.Playables.DirectorWrapMode loopMode);
            static /*0x7da2de0*/ bool CanRestoreNotification(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, UnityEngine.Playables.FrameData info, double currentTime, double previousTime);
            static /*0x7da2714*/ void Trigger_internal(UnityEngine.Playables.Playable playable, UnityEngine.Playables.PlayableOutput output, ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            static /*0x7da2e3c*/ void Restore_internal(ref UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e);
            /*0x7da2e5c*/ TimeNotificationBehaviour();
            /*0x7da2024*/ void set_timeSource(UnityEngine.Playables.Playable value);
            /*0x7da2148*/ void AddNotification(double time, UnityEngine.Playables.INotification payload, UnityEngine.Timeline.NotificationFlags flags);
            /*0x7da2284*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x7da2568*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7da279c*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7da2448*/ void SortNotifications();
            /*0x7da2bfc*/ void TriggerNotificationsInRange(double start, double end, UnityEngine.Playables.FrameData info, UnityEngine.Playables.Playable playable, bool checkState);
            /*0x7da2af8*/ void SyncDurationWithExternalSource(UnityEngine.Playables.Playable playable);

            struct NotificationEntry
            {
                /*0x10*/ double time;
                /*0x18*/ UnityEngine.Playables.INotification payload;
                /*0x20*/ bool notificationFired;
                /*0x22*/ UnityEngine.Timeline.NotificationFlags flags;

                /*0x7da2e50*/ bool get_triggerInEditor();
                /*0x7da2e44*/ bool get_prewarm();
                /*0x7da255c*/ bool get_triggerOnce();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.TimeNotificationBehaviour.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> <>9__12_0;

                static /*0x7da2ee4*/ <>c();
                /*0x7da2f4c*/ <>c();
                /*0x7da2f54*/ int <SortNotifications>b__12_0(UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry x, UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry y);
            }
        }

        class PlayableTrack : UnityEngine.Timeline.TrackAsset
        {
            /*0x7da300c*/ PlayableTrack();
            /*0x7da2f64*/ void OnCreateClip(UnityEngine.Timeline.TimelineClip clip);
        }

        class TrackClipTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type inspectedType;
            /*0x18*/ bool allowAutoCreate;

            /*0x7da3060*/ TrackClipTypeAttribute(System.Type clipClass);
            /*0x7da309c*/ TrackClipTypeAttribute(System.Type clipClass, bool allowAutoCreate);
        }

        class NotKeyableAttribute : System.Attribute
        {
            /*0x7da30cc*/ NotKeyableAttribute();
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

            /*0x7da30d4*/ TrackBindingTypeAttribute(System.Type type);
            /*0x7da3110*/ TrackBindingTypeAttribute(System.Type type, UnityEngine.Timeline.TrackBindingFlags flags);
        }

        class SupportsChildTracksAttribute : System.Attribute
        {
            /*0x10*/ System.Type childType;
            /*0x18*/ int levels;

            /*0x7da314c*/ SupportsChildTracksAttribute(System.Type childType, int levels);
        }

        class IgnoreOnPlayableTrackAttribute : System.Attribute
        {
            /*0x7da3188*/ IgnoreOnPlayableTrackAttribute();
        }

        class FrameRateFieldAttribute : UnityEngine.PropertyAttribute
        {
            /*0x7da3190*/ FrameRateFieldAttribute();
        }

        class HideInMenuAttribute : System.Attribute
        {
            /*0x7da3198*/ HideInMenuAttribute();
        }

        interface ITimelineClipAsset
        {
            /*0x380b6a0*/ UnityEngine.Timeline.ClipCaps get_clipCaps();
        }

        interface ITimelineEvaluateCallback
        {
            /*0x380cb08*/ void Evaluate();
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

            static /*0x7da5918*/ TimelinePlayable();
            static /*0x7d96950*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimelinePlayable> Create(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x7da568c*/ TimelinePlayable();
            /*0x7da31a0*/ void Compile(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool autoRebalance, bool createOutputs);
            /*0x7da3450*/ void CompileTrackList(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.TrackAsset> tracks, UnityEngine.GameObject go, bool createOutputs);
            /*0x7da3bd4*/ void CreateTrackOutput(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, UnityEngine.Playables.Playable playable, int port);
            /*0x7da37f0*/ UnityEngine.Playables.Playable CreateTrackPlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.Playables.Playable timelinePlayable, UnityEngine.Timeline.TrackAsset track, UnityEngine.GameObject go, bool createOutputs);
            /*0x7da4308*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7da4334*/ void Evaluate(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData frameData);
            /*0x7da4298*/ void CacheTrack(UnityEngine.Timeline.TrackAsset track, UnityEngine.Playables.Playable playable);
            /*0x7da425c*/ void AddPlayableOutputCallbacks(UnityEngine.Timeline.AnimationTrack track, UnityEngine.Playables.PlayableOutput playableOutput);
            /*0x7da5244*/ void AddOutputWeightProcessor(UnityEngine.Timeline.AnimationTrack track, UnityEngine.Animations.AnimationPlayableOutput animOutput);
            /*0x7da537c*/ void AddEvaluateCallback(UnityEngine.Timeline.AnimationTrack track, UnityEngine.Timeline.ITimelineEvaluateCallback callback);
            /*0x7da4820*/ void InvokeOutputCallbacks(System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements);
            /*0x7da556c*/ bool TryGetCallbackList(UnityEngine.Timeline.AnimationTrack track, ref System.Collections.Generic.List<UnityEngine.Timeline.ITimelineEvaluateCallback> list);

            struct TrackCacheManager : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.Timeline.AnimationTrack> trackCache;

                /*0x7da5540*/ TrackCacheManager(System.Collections.Generic.HashSet<UnityEngine.Timeline.AnimationTrack> cache, System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements);
                /*0x7da5b78*/ void Dispose();
                /*0x7da5964*/ void GetTrackAssetsFromRuntimeElements(System.Collections.Generic.IReadOnlyList<UnityEngine.Timeline.RuntimeElement> activeRuntimeElements);
            }
        }

        class BlendUtility
        {
            static /*0x0*/ double kMinOverlapTime;

            static /*0x7da5e58*/ BlendUtility();
            static /*0x7da5bc8*/ bool Overlaps(UnityEngine.Timeline.TimelineClip blendOut, UnityEngine.Timeline.TimelineClip blendIn);
            static /*0x7da1d30*/ void ComputeBlendsFromOverlaps(UnityEngine.Timeline.TimelineClip[] clips);
            static /*0x7da5cb8*/ void UpdateClipIntersection(UnityEngine.Timeline.TimelineClip blendOutClip, UnityEngine.Timeline.TimelineClip blendInClip);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.BlendUtility.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;

                static /*0x7da5edc*/ <>c();
                /*0x7da5f44*/ <>c();
                /*0x7da5f4c*/ int <ComputeBlendsFromOverlaps>b__2_0(UnityEngine.Timeline.TimelineClip c1, UnityEngine.Timeline.TimelineClip c2);
            }
        }

        class Extrapolation
        {
            static /*0x0*/ double kMinExtrapolationTime;

            static /*0x7da616c*/ Extrapolation();
            static /*0x7d9868c*/ void CalculateExtrapolationTimes(UnityEngine.Timeline.TrackAsset asset);
            static /*0x7da602c*/ UnityEngine.Timeline.TimelineClip[] SortClipsByStartTime(UnityEngine.Timeline.TimelineClip[] clips);

            class <>c
            {
                static /*0x0*/ UnityEngine.Timeline.Extrapolation.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.Timeline.TimelineClip> <>9__2_0;

                static /*0x7da61f0*/ <>c();
                /*0x7da6258*/ <>c();
                /*0x7da6260*/ int <SortClipsByStartTime>b__2_0(UnityEngine.Timeline.TimelineClip clip1, UnityEngine.Timeline.TimelineClip clip2);
            }
        }

        class HashUtility
        {
            static /*0x7d902f4*/ int CombineHash(int h1, int h2);
            static /*0x7d9f9cc*/ int CombineHash(int h1, int h2, int h3);
            static /*0x7da6294*/ int CombineHash(int h1, int h2, int h3, int h4);
            static /*0x7da62d0*/ int CombineHash(int h1, int h2, int h3, int h4, int h5);
            static /*0x7d94718*/ int CombineHash(int h1, int h2, int h3, int h4, int h5, int h6);
        }

        interface IPropertyCollector
        {
            /*0x380d83c*/ void PushActiveGameObject(UnityEngine.GameObject gameObject);
            /*0x380cb08*/ void PopActiveGameObject();
            /*0x380d83c*/ void AddFromClip(UnityEngine.AnimationClip clip);
            /*0x380d83c*/ void AddFromName<T>(string name);
            /*0x380d93c*/ void AddObjectProperties(UnityEngine.Object obj, UnityEngine.AnimationClip clip);
        }

        interface IPropertyPreview
        {
            /*0x380d93c*/ void GatherProperties(UnityEngine.Playables.PlayableDirector director, UnityEngine.Timeline.IPropertyCollector driver);
        }

        class NotificationUtilities
        {
            static /*0x7d9d5b8*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Playables.PlayableDirector director);
            static /*0x7d9d5c4*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Timeline.TimelineAsset timelineAsset);
            static /*0x7da631c*/ UnityEngine.Playables.ScriptPlayable<UnityEngine.Timeline.TimeNotificationBehaviour> CreateNotificationsPlayable(UnityEngine.Playables.PlayableGraph graph, System.Collections.Generic.IEnumerable<UnityEngine.Timeline.IMarker> markers, UnityEngine.Playables.IPlayableAsset asset, UnityEngine.Playables.PlayableDirector director);
            static /*0x7d9b094*/ bool TrackTypeSupportsNotifications(System.Type type);
        }

        class TimelineCreateUtilities
        {
            static /*0x7d97dd4*/ string GenerateUniqueActorName(System.Collections.Generic.List<UnityEngine.ScriptableObject> tracks, string name);
            static /*0x7d972b4*/ void SaveAssetIntoObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x7d97444*/ void RemoveAssetFromObject(UnityEngine.Object childAsset, UnityEngine.Object masterAsset);
            static /*0x7d8f9d8*/ UnityEngine.AnimationClip CreateAnimationClipForTrack(string name, UnityEngine.Timeline.TrackAsset track, bool isLegacy);
            static /*0x7d97acc*/ bool ValidateParentTrack(UnityEngine.Timeline.TrackAsset parent, System.Type childType);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ string name;

                /*0x7da6b5c*/ <>c__DisplayClass0_0();
                /*0x7da6b6c*/ bool <GenerateUniqueActorName>b__0(UnityEngine.ScriptableObject x);
            }

            class <>c__DisplayClass0_1
            {
                /*0x10*/ string result;

                /*0x7da6b64*/ <>c__DisplayClass0_1();
                /*0x7da6b9c*/ bool <GenerateUniqueActorName>b__1(UnityEngine.ScriptableObject x);
            }
        }

        class TimelineUndo
        {
            static /*0x7d984d4*/ void PushDestroyUndo(UnityEngine.Timeline.TimelineAsset timeline, UnityEngine.Object thingToDirty, UnityEngine.Object objectToDestroy);
        }

        class TimeUtility
        {
            static /*0x0*/ double kTimeEpsilon;
            static /*0x8*/ double kFrameRateEpsilon;
            static /*0x10*/ double k_MaxTimelineDurationInSeconds;
            static /*0x18*/ double kFrameRateRounding;

            static /*0x7da6bcc*/ TimeUtility();
            static /*0x7d8e28c*/ double GetAnimationClipLength(UnityEngine.AnimationClip clip);
        }

        class WeightUtility
        {
            static /*0x7d8dd3c*/ float NormalizeMixer(UnityEngine.Playables.Playable mixer);
        }
    }
}
