class <Module>
{
}

namespace DG
{
    namespace Tweening
    {
        enum AutoPlay
        {
            None = 0,
            AutoPlaySequences = 1,
            AutoPlayTweeners = 2,
            All = 3,
        }

        enum AxisConstraint
        {
            None = 0,
            X = 2,
            Y = 4,
            Z = 8,
            W = 16,
        }

        struct Color2
        {
            /*0x10*/ UnityEngine.Color ca;
            /*0x20*/ UnityEngine.Color cb;

            static /*0x3fab044*/ DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x3fab05c*/ DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x3fab074*/ DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, float f);
            /*0x3fab030*/ Color2(UnityEngine.Color ca, UnityEngine.Color cb);
        }

        class TweenCallback : System.MulticastDelegate
        {
            /*0x3fab088*/ TweenCallback(object object, nint method);
            /*0x3fab124*/ void Invoke();
            /*0x3fab138*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x3fab158*/ void EndInvoke(System.IAsyncResult result);
        }

        class TweenCallback<T> : System.MulticastDelegate
        {
            TweenCallback(object object, nint method);
            /*0x3907c14*/ void Invoke(T value);
            /*0x3907c14*/ System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, object object);
            /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
        }

        class EaseFunction : System.MulticastDelegate
        {
            /*0x3fab164*/ EaseFunction(object object, nint method);
            /*0x3fab204*/ float Invoke(float time, float duration, float overshootOrAmplitude, float period);
            /*0x3fab218*/ System.IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, System.AsyncCallback callback, object object);
            /*0x3fab2c4*/ float EndInvoke(System.IAsyncResult result);
        }

        class DOCurve
        {
            class CubicBezier
            {
                static /*0x3fab2ec*/ UnityEngine.Vector3 GetPointOnSegment(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, float factor);
                static /*0x3fab384*/ UnityEngine.Vector3[] GetSegmentPointCloud(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, int resolution);
                static /*0x3fab4ac*/ void GetSegmentPointCloud(System.Collections.Generic.List<UnityEngine.Vector3> addToList, UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, int resolution);
            }
        }

        class DOTween
        {
            static /*0x0*/ string Version;
            static /*0x8*/ bool useSafeMode;
            static /*0xc*/ DG.Tweening.Core.Enums.SafeModeLogBehaviour safeModeLogBehaviour;
            static /*0x10*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
            static /*0x14*/ bool showUnityEditorReport;
            static /*0x18*/ float timeScale;
            static /*0x1c*/ float unscaledTimeScale;
            static /*0x20*/ bool useSmoothDeltaTime;
            static /*0x24*/ float maxSmoothUnscaledTime;
            static /*0x28*/ DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
            static /*0x2c*/ DG.Tweening.LogBehaviour _logBehaviour;
            static /*0x30*/ System.Func<UnityEngine.LogType, object, bool> onWillLog;
            static /*0x38*/ bool drawGizmos;
            static /*0x39*/ bool debugMode;
            static /*0x3a*/ bool _fooDebugStoreTargetId;
            static /*0x3c*/ DG.Tweening.UpdateType defaultUpdateType;
            static /*0x40*/ bool defaultTimeScaleIndependent;
            static /*0x44*/ DG.Tweening.AutoPlay defaultAutoPlay;
            static /*0x48*/ bool defaultAutoKill;
            static /*0x4c*/ DG.Tweening.LoopType defaultLoopType;
            static /*0x50*/ bool defaultRecyclable;
            static /*0x54*/ DG.Tweening.Ease defaultEaseType;
            static /*0x58*/ float defaultEaseOvershootOrAmplitude;
            static /*0x5c*/ float defaultEasePeriod;
            static /*0x60*/ DG.Tweening.Core.DOTweenComponent instance;
            static /*0x68*/ bool _foo_isQuitting;
            static /*0x6c*/ int maxActiveTweenersReached;
            static /*0x70*/ int maxActiveSequencesReached;
            static /*0x74*/ DG.Tweening.Core.SafeModeReport safeModeReport;
            static /*0x88*/ System.Collections.Generic.List<DG.Tweening.TweenCallback> GizmosDelegates;
            static /*0x90*/ bool initialized;
            static /*0x94*/ int _isQuittingFrame;

            static /*0x3fafbec*/ DOTween();
            static /*0x3fab5fc*/ DG.Tweening.LogBehaviour get_logBehaviour();
            static /*0x3fab654*/ void set_logBehaviour(DG.Tweening.LogBehaviour value);
            static /*0x3fab6b8*/ bool get_debugStoreTargetId();
            static /*0x3fab758*/ void set_debugStoreTargetId(bool value);
            static /*0x3fab7b8*/ bool get_isQuitting();
            static /*0x3fab880*/ void set_isQuitting(bool value);
            static /*0x3fab918*/ DG.Tweening.IDOTweenInit Init(System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x3fac0c0*/ void AutoInit();
            static /*0x3faba98*/ DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x3fac1e8*/ void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity);
            static /*0x3fac250*/ void Clear(bool destroy);
            static /*0x3fac2a8*/ void Clear(bool destroy, bool isApplicationQuitting);
            static /*0x3fac428*/ void ClearCachedTweens();
            static /*0x3fac478*/ int Validate();
            static /*0x3fac4c8*/ void ManualUpdate(float deltaTime, float unscaledDeltaTime);
            static /*0x3fac67c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration);
            static /*0x3fac714*/ DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, double endValue, float duration);
            static /*0x3fac7ac*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, int endValue, float duration);
            static /*0x3fac844*/ DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, uint endValue, float duration);
            static /*0x3fac8dc*/ DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, long endValue, float duration);
            static /*0x3fac974*/ DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, ulong endValue, float duration);
            static /*0x3faca0c*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, string endValue, float duration);
            static /*0x3facaa4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, float duration);
            static /*0x3facb4c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x3facbfc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, float duration);
            static /*0x3faccbc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x3facd6c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration);
            static /*0x3face2c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, float duration);
            static /*0x3faceec*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, float duration);
            static /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration);
            static /*0x3facf84*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float endValue, float duration, DG.Tweening.AxisConstraint axisConstraint);
            static /*0x3fad038*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float endValue, float duration);
            static /*0x3fad10c*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<float> setter, float startValue, float endValue, float duration);
            static /*0x3fad290*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, float duration, int vibrato, float elasticity);
            static /*0x3fad8b8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, float strength, int vibrato, float randomness, bool ignoreZAxis, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fae1b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fad980*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fad680*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, float[] durations);
            static /*0x3fae27c*/ DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, float duration);
            static /*0x3fae330*/ DG.Tweening.Sequence Sequence();
            static /*0x3fae48c*/ DG.Tweening.Sequence Sequence(object target);
            static /*0x3fae4fc*/ int CompleteAll(bool withCallbacks);
            static /*0x3fae570*/ int Complete(object targetOrId, bool withCallbacks);
            static /*0x3fae5fc*/ int CompleteAndReturnKilledTot();
            static /*0x3fae668*/ int CompleteAndReturnKilledTot(object targetOrId);
            static /*0x3fae6ec*/ int CompleteAndReturnKilledTot(object target, object id);
            static /*0x3fae778*/ int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds);
            static /*0x3fae7e8*/ int FlipAll();
            static /*0x3fae854*/ int Flip(object targetOrId);
            static /*0x3fae8d8*/ int GotoAll(float to, bool andPlay);
            static /*0x3fae954*/ int Goto(object targetOrId, float to, bool andPlay);
            static /*0x3fae9ec*/ int KillAll(bool complete);
            static /*0x3faea80*/ int KillAll(bool complete, object[] idsOrTargetsToExclude);
            static /*0x3faeb88*/ int Kill(object targetOrId, bool complete);
            static /*0x3faec4c*/ int Kill(object target, object id, bool complete);
            static /*0x3faed20*/ int PauseAll();
            static /*0x3faed8c*/ int Pause(object targetOrId);
            static /*0x3faee10*/ int PlayAll();
            static /*0x3faee7c*/ int Play(object targetOrId);
            static /*0x3faef00*/ int Play(object target, object id);
            static /*0x3faef8c*/ int PlayBackwardsAll();
            static /*0x3faeff8*/ int PlayBackwards(object targetOrId);
            static /*0x3faf07c*/ int PlayBackwards(object target, object id);
            static /*0x3faf108*/ int PlayForwardAll();
            static /*0x3faf174*/ int PlayForward(object targetOrId);
            static /*0x3faf1f8*/ int PlayForward(object target, object id);
            static /*0x3faf284*/ int RestartAll(bool includeDelay);
            static /*0x3faf2f4*/ int Restart(object targetOrId, bool includeDelay, float changeDelayTo);
            static /*0x3faf38c*/ int Restart(object target, object id, bool includeDelay, float changeDelayTo);
            static /*0x3faf438*/ int RewindAll(bool includeDelay);
            static /*0x3faf4a8*/ int Rewind(object targetOrId, bool includeDelay);
            static /*0x3faf530*/ int SmoothRewindAll();
            static /*0x3faf59c*/ int SmoothRewind(object targetOrId);
            static /*0x3faf620*/ int TogglePauseAll();
            static /*0x3faf68c*/ int TogglePause(object targetOrId);
            static /*0x3faf710*/ bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying);
            static /*0x3faf798*/ int TotalActiveTweens();
            static /*0x3faf7f0*/ int TotalActiveTweeners();
            static /*0x3faf848*/ int TotalActiveSequences();
            static /*0x3faf8a0*/ int TotalPlayingTweens();
            static /*0x3faf8f0*/ int TotalTweensById(object id, bool playingOnly);
            static /*0x3faf964*/ System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3faf9f4*/ System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fafa84*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fafb40*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fac5bc*/ void InitCheck();
            static /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            /*0x3fafbe4*/ DOTween();

            class <>c__DisplayClass67_0
            {
                /*0x10*/ float v;
                /*0x18*/ DG.Tweening.Core.DOSetter<float> setter;

                /*0x3fad288*/ <>c__DisplayClass67_0();
                /*0x3fafd38*/ float <To>b__0();
                /*0x3fafd40*/ void <To>b__1(float x);
            }
        }

        class DOVirtual
        {
            static /*0x3fafd68*/ DG.Tweening.Tweener Float(float from, float to, float duration, DG.Tweening.TweenCallback<float> onVirtualUpdate);
            static /*0x3faff44*/ DG.Tweening.Tweener Int(int from, int to, float duration, DG.Tweening.TweenCallback<int> onVirtualUpdate);
            static /*0x3fb0118*/ DG.Tweening.Tweener Vector2(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float duration, DG.Tweening.TweenCallback<UnityEngine.Vector2> onVirtualUpdate);
            static /*0x3fb0308*/ DG.Tweening.Tweener Vector3(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float duration, DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate);
            static /*0x3fb0510*/ DG.Tweening.Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate);
            static /*0x3fb0724*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0x3fb07c0*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0x3fb0864*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0x3fb08a8*/ float EasedValue(float from, float to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0x3fb09c0*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0x3fb0a94*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0x3fb0b70*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0x3fb0be4*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0x3fb0d34*/ DG.Tweening.Tween DelayedCall(float delay, DG.Tweening.TweenCallback callback, bool ignoreTimeScale);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ float val;
                /*0x18*/ DG.Tweening.TweenCallback<float> onVirtualUpdate;

                /*0x3faff3c*/ <>c__DisplayClass0_0();
                /*0x3fb0e50*/ float <Float>b__0();
                /*0x3fb0e58*/ void <Float>b__1(float x);
                /*0x3fb0e60*/ void <Float>b__2();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ int val;
                /*0x18*/ DG.Tweening.TweenCallback<int> onVirtualUpdate;

                /*0x3fb0110*/ <>c__DisplayClass1_0();
                /*0x3fb0e88*/ int <Int>b__0();
                /*0x3fb0e90*/ void <Int>b__1(int x);
                /*0x3fb0e98*/ void <Int>b__2();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Vector2 val;
                /*0x18*/ DG.Tweening.TweenCallback<UnityEngine.Vector2> onVirtualUpdate;

                /*0x3fb0300*/ <>c__DisplayClass2_0();
                /*0x3fb0ec0*/ UnityEngine.Vector2 <Vector2>b__0();
                /*0x3fb0ec8*/ void <Vector2>b__1(UnityEngine.Vector2 x);
                /*0x3fb0ed0*/ void <Vector2>b__2();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Vector3 val;
                /*0x20*/ DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate;

                /*0x3fb0508*/ <>c__DisplayClass3_0();
                /*0x3fb0ef8*/ UnityEngine.Vector3 <Vector3>b__0();
                /*0x3fb0f04*/ void <Vector3>b__1(UnityEngine.Vector3 x);
                /*0x3fb0f10*/ void <Vector3>b__2();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Color val;
                /*0x20*/ DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate;

                /*0x3fb071c*/ <>c__DisplayClass4_0();
                /*0x3fb0f3c*/ UnityEngine.Color <Color>b__0();
                /*0x3fb0f48*/ void <Color>b__1(UnityEngine.Color x);
                /*0x3fb0f54*/ void <Color>b__2();
            }
        }

        enum Ease
        {
            Unset = 0,
            Linear = 1,
            InSine = 2,
            OutSine = 3,
            InOutSine = 4,
            InQuad = 5,
            OutQuad = 6,
            InOutQuad = 7,
            InCubic = 8,
            OutCubic = 9,
            InOutCubic = 10,
            InQuart = 11,
            OutQuart = 12,
            InOutQuart = 13,
            InQuint = 14,
            OutQuint = 15,
            InOutQuint = 16,
            InExpo = 17,
            OutExpo = 18,
            InOutExpo = 19,
            InCirc = 20,
            OutCirc = 21,
            InOutCirc = 22,
            InElastic = 23,
            OutElastic = 24,
            InOutElastic = 25,
            InBack = 26,
            OutBack = 27,
            InOutBack = 28,
            InBounce = 29,
            OutBounce = 30,
            InOutBounce = 31,
            Flash = 32,
            InFlash = 33,
            OutFlash = 34,
            InOutFlash = 35,
            INTERNAL_Zero = 36,
            INTERNAL_Custom = 37,
        }

        class EaseFactory
        {
            static /*0x3fb0f80*/ DG.Tweening.EaseFunction StopMotion(int motionFps, System.Nullable<DG.Tweening.Ease> ease);
            static /*0x3fb1104*/ DG.Tweening.EaseFunction StopMotion(int motionFps, UnityEngine.AnimationCurve animCurve);
            static /*0x3fb1038*/ DG.Tweening.EaseFunction StopMotion(int motionFps, DG.Tweening.EaseFunction customEase);
            /*0x3fb11c0*/ EaseFactory();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ float motionDelay;
                /*0x18*/ DG.Tweening.EaseFunction customEase;

                /*0x3fb11b8*/ <>c__DisplayClass2_0();
                /*0x3fb11c8*/ float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period);
            }
        }

        interface IDOTweenInit
        {
            DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
        }

        enum LinkBehaviour
        {
            PauseOnDisable = 0,
            PauseOnDisablePlayOnEnable = 1,
            PauseOnDisableRestartOnEnable = 2,
            PlayOnEnable = 3,
            RestartOnEnable = 4,
            KillOnDisable = 5,
            KillOnDestroy = 6,
            CompleteOnDisable = 7,
            CompleteAndKillOnDisable = 8,
            RewindOnDisable = 9,
            RewindAndKillOnDisable = 10,
        }

        enum PathMode
        {
            Ignore = 0,
            Full3D = 1,
            TopDown2D = 2,
            Sidescroller2D = 3,
        }

        enum PathType
        {
            Linear = 0,
            CatmullRom = 1,
            CubicBezier = 2,
        }

        enum RotateMode
        {
            Fast = 0,
            FastBeyond360 = 1,
            WorldAxisAdd = 2,
            LocalAxisAdd = 3,
        }

        enum ScrambleMode
        {
            None = 0,
            All = 1,
            Uppercase = 2,
            Lowercase = 3,
            Numerals = 4,
            Custom = 5,
        }

        enum ShakeRandomnessMode
        {
            Full = 0,
            Harmonic = 1,
        }

        class TweenExtensions
        {
            static /*0x3fb1238*/ void Complete(DG.Tweening.Tween t);
            static /*0x3fb1240*/ void Complete(DG.Tweening.Tween t, bool withCallbacks);
            static /*0x3907c14*/ T Done<T>(T t);
            static /*0x3fb13bc*/ void Flip(DG.Tweening.Tween t);
            static /*0x3fb1524*/ void ForceInit(DG.Tweening.Tween t);
            static /*0x3fb1690*/ void Goto(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0x3fb188c*/ void GotoWithCallbacks(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0x3fb169c*/ void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks);
            static /*0x3fb1898*/ void Kill(DG.Tweening.Tween t, bool complete);
            static /*0x3fb1a14*/ void ManualUpdate(DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime);
            static /*0x3907c14*/ T Pause<T>(T t);
            static /*0x3907c14*/ T Play<T>(T t);
            static /*0x3fb1ba8*/ void PlayBackwards(DG.Tweening.Tween t);
            static /*0x3fb1d10*/ void PlayForward(DG.Tweening.Tween t);
            static /*0x3fb1e78*/ void Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
            static /*0x3fb2008*/ void Rewind(DG.Tweening.Tween t, bool includeDelay);
            static /*0x3fb2178*/ void SmoothRewind(DG.Tweening.Tween t);
            static /*0x3fb22e0*/ void TogglePause(DG.Tweening.Tween t);
            static /*0x3fb2448*/ void GotoWaypoint(DG.Tweening.Tween t, int waypointIndex, bool andPlay);
            static /*0x3fb27dc*/ UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t);
            static /*0x3fb28c0*/ UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t);
            static /*0x3fb29a4*/ UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t);
            static /*0x3fb2a88*/ UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x3fb2b74*/ UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x3fb2c6c*/ UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t);
            static /*0x3fb2d50*/ int CompletedLoops(DG.Tweening.Tween t);
            static /*0x3fb2dcc*/ float Delay(DG.Tweening.Tween t);
            static /*0x3fb2e54*/ float ElapsedDelay(DG.Tweening.Tween t);
            static /*0x3fb2edc*/ float Duration(DG.Tweening.Tween t, bool includeLoops);
            static /*0x3fb2f90*/ float Elapsed(DG.Tweening.Tween t, bool includeLoops);
            static /*0x3fb303c*/ float ElapsedPercentage(DG.Tweening.Tween t, bool includeLoops);
            static /*0x3fb310c*/ float ElapsedDirectionalPercentage(DG.Tweening.Tween t);
            static /*0x3fb31e4*/ bool IsActive(DG.Tweening.Tween t);
            static /*0x3fb31f8*/ bool IsBackwards(DG.Tweening.Tween t);
            static /*0x3fb327c*/ bool IsLoopingOrExecutingBackwards(DG.Tweening.Tween t);
            static /*0x3fb3340*/ bool IsComplete(DG.Tweening.Tween t);
            static /*0x3fb33c4*/ bool IsInitialized(DG.Tweening.Tween t);
            static /*0x3fb3448*/ bool IsPlaying(DG.Tweening.Tween t);
            static /*0x3fb34cc*/ int Loops(DG.Tweening.Tween t);
            static /*0x3fb3548*/ UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, float pathPercentage);
            static /*0x3fb37dc*/ UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, int subdivisionsXSegment);
            static /*0x3fb3a1c*/ float PathLength(DG.Tweening.Tween t);
        }

        enum LoopType
        {
            Restart = 0,
            Yoyo = 1,
            Incremental = 2,
        }

        class Sequence : DG.Tweening.Tween
        {
            /*0x120*/ System.Collections.Generic.List<DG.Tweening.Tween> sequencedTweens;
            /*0x128*/ System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> _sequencedObjs;
            /*0x130*/ float lastTweenInsertTime;

            static /*0x3fb3d98*/ DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t);
            static /*0x3fb3eb8*/ DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, float atPosition);
            static /*0x3fb40f8*/ DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x3fb411c*/ DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x3fb41f0*/ DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, float atPosition);
            static /*0x3fae3b8*/ void Setup(DG.Tweening.Sequence s);
            static /*0x3fb45d8*/ bool DoStartup(DG.Tweening.Sequence s);
            static /*0x3fb4828*/ bool DoApplyTween(DG.Tweening.Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x3fb4cfc*/ bool ApplyInternalCycle(DG.Tweening.Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep);
            static /*0x3fb4bd0*/ void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list);
            static /*0x3fb4b70*/ bool IsAnyCallbackSet(DG.Tweening.Sequence s);
            /*0x3fb3c68*/ Sequence();
            /*0x3fb42fc*/ float UpdateDelay(float elapsed);
            /*0x3fb4328*/ void Reset();
            /*0x3fb4518*/ bool Validate();
            /*0x3fb45d4*/ bool Startup();
            /*0x3fb4820*/ bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class ShortcutExtensions
        {
            static /*0x3fb5608*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fb5790*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, float duration);
            static /*0x3fb5940*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fb5ac8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fb5c50*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fb5dd8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fb5f60*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x3fb6110*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x3fb62c0*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb6528*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb67a8*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb6a10*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb6c90*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x3fb6e40*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, float endValue, float duration);
            static /*0x3fb6fc8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, float endValue, float duration);
            static /*0x3fb7150*/ DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, float duration);
            static /*0x3fb7300*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x3fb74b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x3fb76d0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x3fb78e0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, float duration);
            static /*0x3fb7a68*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x3fb7c60*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x3fb7e48*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x3fb8040*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x3fb8228*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fb83c0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x3fb85c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fb8760*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x3fb8968*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, string property, float duration);
            static /*0x3fb8b88*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, int propertyID, float duration);
            static /*0x3fb8d98*/ DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, float toStartWidth, float toEndWidth, float duration);
            static /*0x3fb8f24*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, float endValue, float duration);
            static /*0x3fb90ac*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fb9280*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fb9450*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fb9604*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fb97b8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fb9974*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fb9b28*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fb9cdc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fb9e90*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fba044*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x3fba228*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fba3dc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x3fba5c0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration);
            static /*0x3fba760*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fba8f0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fbaa9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fbac48*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fbadf4*/ DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fbb07c*/ DG.Tweening.Tweener DODynamicLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fbadfc*/ DG.Tweening.Tweener LookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up, bool dynamic);
            static /*0x3fbb08c*/ DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x3fbb2f4*/ DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x3fbb538*/ DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x3fbb77c*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fbb9f0*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fbbc78*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fbbee0*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fbc160*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fbc42c*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fbc6ac*/ DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fbcc2c*/ DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fbd124*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fbd348*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fbd574*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fbd734*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fbd8fc*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, float endValue, float duration);
            static /*0x3fbda84*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x3fbdc80*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x3fbde7c*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x3fbe0ec*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x3fbe34c*/ DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x3fbe554*/ DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x3fbe75c*/ DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fbe95c*/ DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fbeb5c*/ DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x3fbedfc*/ DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration);
            static /*0x3fbefec*/ int DOComplete(UnityEngine.Component target, bool withCallbacks);
            static /*0x3fbf050*/ int DOComplete(UnityEngine.Material target, bool withCallbacks);
            static /*0x3fbf0b4*/ int DOKill(UnityEngine.Component target, bool complete);
            static /*0x3fbf118*/ int DOKill(UnityEngine.Material target, bool complete);
            static /*0x3fbf17c*/ int DOFlip(UnityEngine.Component target);
            static /*0x3fbf1d0*/ int DOFlip(UnityEngine.Material target);
            static /*0x3fbf224*/ int DOGoto(UnityEngine.Component target, float to, bool andPlay);
            static /*0x3fbf298*/ int DOGoto(UnityEngine.Material target, float to, bool andPlay);
            static /*0x3fbf30c*/ int DOPause(UnityEngine.Component target);
            static /*0x3fbf360*/ int DOPause(UnityEngine.Material target);
            static /*0x3fbf3b4*/ int DOPlay(UnityEngine.Component target);
            static /*0x3fbf408*/ int DOPlay(UnityEngine.Material target);
            static /*0x3fbf45c*/ int DOPlayBackwards(UnityEngine.Component target);
            static /*0x3fbf4b0*/ int DOPlayBackwards(UnityEngine.Material target);
            static /*0x3fbf504*/ int DOPlayForward(UnityEngine.Component target);
            static /*0x3fbf558*/ int DOPlayForward(UnityEngine.Material target);
            static /*0x3fbf5ac*/ int DORestart(UnityEngine.Component target, bool includeDelay);
            static /*0x3fbf614*/ int DORestart(UnityEngine.Material target, bool includeDelay);
            static /*0x3fbf67c*/ int DORewind(UnityEngine.Component target, bool includeDelay);
            static /*0x3fbf6e0*/ int DORewind(UnityEngine.Material target, bool includeDelay);
            static /*0x3fbf744*/ int DOSmoothRewind(UnityEngine.Component target);
            static /*0x3fbf798*/ int DOSmoothRewind(UnityEngine.Material target);
            static /*0x3fbf7ec*/ int DOTogglePause(UnityEngine.Component target);
            static /*0x3fbf840*/ int DOTogglePause(UnityEngine.Material target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb5788*/ <>c__DisplayClass0_0();
                /*0x3fbf894*/ float <DOAspect>b__0();
                /*0x3fbf8b0*/ void <DOAspect>b__1(float x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb6a08*/ <>c__DisplayClass10_0();
                /*0x3fbf8cc*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fbf8f4*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb6c88*/ <>c__DisplayClass11_0();
                /*0x3fbf95c*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fbf984*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x3fb6e38*/ <>c__DisplayClass12_0();
                /*0x3fbf9ec*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fbfa08*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x3fb6fc0*/ <>c__DisplayClass13_0();
                /*0x3fbfa24*/ float <DOIntensity>b__0();
                /*0x3fbfa40*/ void <DOIntensity>b__1(float x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x3fb7148*/ <>c__DisplayClass14_0();
                /*0x3fbfa5c*/ float <DOShadowStrength>b__0();
                /*0x3fbfa78*/ void <DOShadowStrength>b__1(float x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ DG.Tweening.Color2 startValue;
                /*0x30*/ UnityEngine.LineRenderer target;

                /*0x3fb72f8*/ <>c__DisplayClass15_0();
                /*0x3fbfa94*/ DG.Tweening.Color2 <DOColor>b__0();
                /*0x3fbfaa0*/ void <DOColor>b__1(DG.Tweening.Color2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fb74a8*/ <>c__DisplayClass16_0();
                /*0x3fbfaec*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fbfb08*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fb76c8*/ <>c__DisplayClass17_0();
                /*0x3fbfb24*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fbfb48*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fb78d8*/ <>c__DisplayClass18_0();
                /*0x3fbfb6c*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fbfb90*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fb7a60*/ <>c__DisplayClass19_0();
                /*0x3fbfbb4*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fbfbd0*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb5938*/ <>c__DisplayClass1_0();
                /*0x3fbfbec*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fbfc08*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fb7c58*/ <>c__DisplayClass20_0();
                /*0x3fbfc24*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fbfc48*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fb7e40*/ <>c__DisplayClass21_0();
                /*0x3fbfc6c*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fbfc90*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fb8038*/ <>c__DisplayClass22_0();
                /*0x3fbfcb4*/ float <DOFloat>b__0();
                /*0x3fbfcd8*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fb8220*/ <>c__DisplayClass23_0();
                /*0x3fbfcfc*/ float <DOFloat>b__0();
                /*0x3fbfd20*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fb83b8*/ <>c__DisplayClass24_0();
                /*0x3fbfd44*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x3fbfd60*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fb85c0*/ <>c__DisplayClass25_0();
                /*0x3fbfd7c*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x3fbfda0*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fb8758*/ <>c__DisplayClass26_0();
                /*0x3fbfdc4*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x3fbfde0*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fb8960*/ <>c__DisplayClass27_0();
                /*0x3fbfdfc*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x3fbfe20*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fb8b80*/ <>c__DisplayClass28_0();
                /*0x3fbfe44*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x3fbfe68*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fb8d90*/ <>c__DisplayClass29_0();
                /*0x3fbfe8c*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x3fbfeb0*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb5ac0*/ <>c__DisplayClass2_0();
                /*0x3fbfed4*/ float <DOFarClipPlane>b__0();
                /*0x3fbfef0*/ void <DOFarClipPlane>b__1(float x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x3fb8f1c*/ <>c__DisplayClass30_0();
                /*0x3fbff0c*/ UnityEngine.Vector2 <DOResize>b__0();
                /*0x3fbff54*/ void <DOResize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x3fb90a4*/ <>c__DisplayClass31_0();
                /*0x3fbff94*/ float <DOTime>b__0();
                /*0x3fbffb0*/ void <DOTime>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb9260*/ <>c__DisplayClass32_0();
                /*0x3fbffcc*/ UnityEngine.Vector3 <DOMove>b__0();
                /*0x3fbffe8*/ void <DOMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb942c*/ <>c__DisplayClass33_0();
                /*0x3fc0004*/ UnityEngine.Vector3 <DOMoveX>b__0();
                /*0x3fc0020*/ void <DOMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb95fc*/ <>c__DisplayClass34_0();
                /*0x3fc003c*/ UnityEngine.Vector3 <DOMoveY>b__0();
                /*0x3fc0058*/ void <DOMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb97b0*/ <>c__DisplayClass35_0();
                /*0x3fc0074*/ UnityEngine.Vector3 <DOMoveZ>b__0();
                /*0x3fc0090*/ void <DOMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb996c*/ <>c__DisplayClass36_0();
                /*0x3fc00ac*/ UnityEngine.Vector3 <DOLocalMove>b__0();
                /*0x3fc00c8*/ void <DOLocalMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb9b20*/ <>c__DisplayClass37_0();
                /*0x3fc00e4*/ UnityEngine.Vector3 <DOLocalMoveX>b__0();
                /*0x3fc0100*/ void <DOLocalMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb9cd4*/ <>c__DisplayClass38_0();
                /*0x3fc011c*/ UnityEngine.Vector3 <DOLocalMoveY>b__0();
                /*0x3fc0138*/ void <DOLocalMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fb9e88*/ <>c__DisplayClass39_0();
                /*0x3fc0154*/ UnityEngine.Vector3 <DOLocalMoveZ>b__0();
                /*0x3fc0170*/ void <DOLocalMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb5c48*/ <>c__DisplayClass3_0();
                /*0x3fc018c*/ float <DOFieldOfView>b__0();
                /*0x3fc01a8*/ void <DOFieldOfView>b__1(float x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fba03c*/ <>c__DisplayClass40_0();
                /*0x3fc01c4*/ UnityEngine.Quaternion <DORotate>b__0();
                /*0x3fc01e0*/ void <DORotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fba220*/ <>c__DisplayClass41_0();
                /*0x3fc01fc*/ UnityEngine.Quaternion <DORotateQuaternion>b__0();
                /*0x3fc0218*/ void <DORotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass42_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fba3d4*/ <>c__DisplayClass42_0();
                /*0x3fc0234*/ UnityEngine.Quaternion <DOLocalRotate>b__0();
                /*0x3fc0250*/ void <DOLocalRotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fba5b8*/ <>c__DisplayClass43_0();
                /*0x3fc026c*/ UnityEngine.Quaternion <DOLocalRotateQuaternion>b__0();
                /*0x3fc0288*/ void <DOLocalRotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass44_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fba758*/ <>c__DisplayClass44_0();
                /*0x3fc02a4*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x3fc02c0*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fba8e8*/ <>c__DisplayClass45_0();
                /*0x3fc02dc*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x3fc02f8*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass46_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbaa94*/ <>c__DisplayClass46_0();
                /*0x3fc0314*/ UnityEngine.Vector3 <DOScaleX>b__0();
                /*0x3fc0330*/ void <DOScaleX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbac40*/ <>c__DisplayClass47_0();
                /*0x3fc034c*/ UnityEngine.Vector3 <DOScaleY>b__0();
                /*0x3fc0368*/ void <DOScaleY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbadec*/ <>c__DisplayClass48_0();
                /*0x3fc0384*/ UnityEngine.Vector3 <DOScaleZ>b__0();
                /*0x3fc03a0*/ void <DOScaleZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb5dd0*/ <>c__DisplayClass4_0();
                /*0x3fc03bc*/ float <DONearClipPlane>b__0();
                /*0x3fc03d8*/ void <DONearClipPlane>b__1(float x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbb084*/ <>c__DisplayClass51_0();
                /*0x3fc03f4*/ UnityEngine.Quaternion <LookAt>b__0();
                /*0x3fc0410*/ void <LookAt>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbb2d4*/ <>c__DisplayClass52_0();
                /*0x3fc042c*/ UnityEngine.Vector3 <DOPunchPosition>b__0();
                /*0x3fc0448*/ void <DOPunchPosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbb530*/ <>c__DisplayClass53_0();
                /*0x3fc0464*/ UnityEngine.Vector3 <DOPunchScale>b__0();
                /*0x3fc0480*/ void <DOPunchScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass54_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbb774*/ <>c__DisplayClass54_0();
                /*0x3fc049c*/ UnityEngine.Vector3 <DOPunchRotation>b__0();
                /*0x3fc04b8*/ void <DOPunchRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass55_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbb9e8*/ <>c__DisplayClass55_0();
                /*0x3fc04f4*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fc0510*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbbc70*/ <>c__DisplayClass56_0();
                /*0x3fc052c*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fc0548*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass57_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbbed8*/ <>c__DisplayClass57_0();
                /*0x3fc0564*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fc0580*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbc158*/ <>c__DisplayClass58_0();
                /*0x3fc05bc*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fc05d8*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbc424*/ <>c__DisplayClass59_0();
                /*0x3fc0614*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x3fc0630*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb5f58*/ <>c__DisplayClass5_0();
                /*0x3fc064c*/ float <DOOrthoSize>b__0();
                /*0x3fc0668*/ void <DOOrthoSize>b__1(float x);
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbc6a4*/ <>c__DisplayClass60_0();
                /*0x3fc0684*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x3fc06a0*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0x3fbcb9c*/ <>c__DisplayClass61_0();
                /*0x3fc06bc*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x3fc06d8*/ void <DOJump>b__1(UnityEngine.Vector3 x);
                /*0x3fc06f4*/ void <DOJump>b__2();
                /*0x3fc071c*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x3fc0738*/ void <DOJump>b__4(UnityEngine.Vector3 x);
                /*0x3fc0754*/ UnityEngine.Vector3 <DOJump>b__5();
                /*0x3fc0770*/ void <DOJump>b__6(UnityEngine.Vector3 x);
                /*0x3fc078c*/ void <DOJump>b__7();
            }

            class <>c__DisplayClass62_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0x3fbd11c*/ <>c__DisplayClass62_0();
                /*0x3fc0838*/ UnityEngine.Vector3 <DOLocalJump>b__0();
                /*0x3fc0854*/ void <DOLocalJump>b__1(UnityEngine.Vector3 x);
                /*0x3fc0870*/ void <DOLocalJump>b__2();
                /*0x3fc0898*/ UnityEngine.Vector3 <DOLocalJump>b__3();
                /*0x3fc08b4*/ void <DOLocalJump>b__4(UnityEngine.Vector3 x);
                /*0x3fc08d0*/ UnityEngine.Vector3 <DOLocalJump>b__5();
                /*0x3fc08ec*/ void <DOLocalJump>b__6(UnityEngine.Vector3 x);
                /*0x3fc0908*/ void <DOLocalJump>b__7();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbd340*/ <>c__DisplayClass63_0();
                /*0x3fc09b4*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fc09d0*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbd56c*/ <>c__DisplayClass64_0();
                /*0x3fc09ec*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fc0a08*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbd72c*/ <>c__DisplayClass65_0();
                /*0x3fc0a24*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fc0a40*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fbd8f4*/ <>c__DisplayClass66_0();
                /*0x3fc0a5c*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fc0a78*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ DG.Tweening.Tween target;

                /*0x3fbda7c*/ <>c__DisplayClass67_0();
                /*0x3fc0a94*/ float <DOTimeScale>b__0();
                /*0x3fc0ab0*/ void <DOTimeScale>b__1(float x);
            }

            class <>c__DisplayClass68_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Light target;

                /*0x3fbdc78*/ <>c__DisplayClass68_0();
                /*0x3fc0acc*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fc0ad8*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass69_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;

                /*0x3fbde74*/ <>c__DisplayClass69_0();
                /*0x3fc0b44*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fc0b50*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb6108*/ <>c__DisplayClass6_0();
                /*0x3fc0bbc*/ UnityEngine.Rect <DOPixelRect>b__0();
                /*0x3fc0bd8*/ void <DOPixelRect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ string property;

                /*0x3fbe0e4*/ <>c__DisplayClass70_0();
                /*0x3fc0bf4*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fc0c00*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass71_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ int propertyID;

                /*0x3fbe344*/ <>c__DisplayClass71_0();
                /*0x3fc0c80*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fc0c8c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fbe54c*/ <>c__DisplayClass72_0();
                /*0x3fc0d0c*/ UnityEngine.Vector3 <DOBlendableMoveBy>b__0();
                /*0x3fc0d18*/ void <DOBlendableMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass73_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fbe754*/ <>c__DisplayClass73_0();
                /*0x3fc0d7c*/ UnityEngine.Vector3 <DOBlendableLocalMoveBy>b__0();
                /*0x3fc0d88*/ void <DOBlendableLocalMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass74_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fbe954*/ <>c__DisplayClass74_0();
                /*0x3fc0dec*/ UnityEngine.Quaternion <DOBlendableRotateBy>b__0();
                /*0x3fc0df8*/ void <DOBlendableRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass75_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fbeb54*/ <>c__DisplayClass75_0();
                /*0x3fc1074*/ UnityEngine.Quaternion <DOBlendableLocalRotateBy>b__0();
                /*0x3fc1080*/ void <DOBlendableLocalRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass76_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fbedf4*/ <>c__DisplayClass76_0();
                /*0x3fc12fc*/ UnityEngine.Vector3 <DOBlendablePunchRotation>b__0();
                /*0x3fc1308*/ void <DOBlendablePunchRotation>b__1(UnityEngine.Vector3 v);
            }

            class <>c__DisplayClass77_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fbefe4*/ <>c__DisplayClass77_0();
                /*0x3fc15d4*/ UnityEngine.Vector3 <DOBlendableScaleBy>b__0();
                /*0x3fc15e0*/ void <DOBlendableScaleBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb62b8*/ <>c__DisplayClass7_0();
                /*0x3fc1644*/ UnityEngine.Rect <DORect>b__0();
                /*0x3fc1660*/ void <DORect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb6520*/ <>c__DisplayClass8_0();
                /*0x3fc167c*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fc16a4*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fb67a0*/ <>c__DisplayClass9_0();
                /*0x3fc16f4*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fc171c*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }
        }

        class TweenParams
        {
            static /*0x0*/ DG.Tweening.TweenParams Params;
            /*0x10*/ object id;
            /*0x18*/ string stringId;
            /*0x20*/ int intId;
            /*0x28*/ object target;
            /*0x30*/ DG.Tweening.UpdateType updateType;
            /*0x34*/ bool isIndependentUpdate;
            /*0x38*/ DG.Tweening.TweenCallback onStart;
            /*0x40*/ DG.Tweening.TweenCallback onPlay;
            /*0x48*/ DG.Tweening.TweenCallback onRewind;
            /*0x50*/ DG.Tweening.TweenCallback onUpdate;
            /*0x58*/ DG.Tweening.TweenCallback onStepComplete;
            /*0x60*/ DG.Tweening.TweenCallback onComplete;
            /*0x68*/ DG.Tweening.TweenCallback onKill;
            /*0x70*/ DG.Tweening.TweenCallback<int> onWaypointChange;
            /*0x78*/ bool isRecyclable;
            /*0x79*/ bool isSpeedBased;
            /*0x7a*/ bool autoKill;
            /*0x7c*/ int loops;
            /*0x80*/ DG.Tweening.LoopType loopType;
            /*0x84*/ float delay;
            /*0x88*/ bool isRelative;
            /*0x8c*/ DG.Tweening.Ease easeType;
            /*0x90*/ DG.Tweening.EaseFunction customEase;
            /*0x98*/ float easeOvershootOrAmplitude;
            /*0x9c*/ float easePeriod;

            static /*0x3fc1d90*/ TweenParams();
            /*0x3fc176c*/ TweenParams();
            /*0x3fc1790*/ DG.Tweening.TweenParams Clear();
            /*0x3fc190c*/ DG.Tweening.TweenParams SetAutoKill(bool autoKillOnCompletion);
            /*0x3fc1918*/ DG.Tweening.TweenParams SetId(object objectId);
            /*0x3fc1934*/ DG.Tweening.TweenParams SetId(string stringId);
            /*0x3fc1950*/ DG.Tweening.TweenParams SetId(int intId);
            /*0x3fc1958*/ DG.Tweening.TweenParams SetTarget(object target);
            /*0x3fc1974*/ DG.Tweening.TweenParams SetLoops(int loops, System.Nullable<DG.Tweening.LoopType> loopType);
            /*0x3fc1a04*/ DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<float> overshootOrAmplitude, System.Nullable<float> period);
            /*0x3fc1b10*/ DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve);
            /*0x3fc1bd8*/ DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase);
            /*0x3fc1bfc*/ DG.Tweening.TweenParams SetRecyclable(bool recyclable);
            /*0x3fc1c08*/ DG.Tweening.TweenParams SetUpdate(bool isIndependentUpdate);
            /*0x3fc1c80*/ DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            /*0x3fc1c90*/ DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action);
            /*0x3fc1cac*/ DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action);
            /*0x3fc1cc8*/ DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action);
            /*0x3fc1ce4*/ DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action);
            /*0x3fc1d00*/ DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action);
            /*0x3fc1d1c*/ DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action);
            /*0x3fc1d38*/ DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action);
            /*0x3fc1d54*/ DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<int> action);
            /*0x3fc1d70*/ DG.Tweening.TweenParams SetDelay(float delay);
            /*0x3fc1d78*/ DG.Tweening.TweenParams SetRelative(bool isRelative);
            /*0x3fc1d84*/ DG.Tweening.TweenParams SetSpeedBased(bool isSpeedBased);
        }

        class TweenSettingsExtensions
        {
            static /*0x3907c14*/ T SetAutoKill<T>(T t);
            static /*0x3907c14*/ T SetAutoKill<T>(T t, bool autoKillOnCompletion);
            static /*0x3907c14*/ T SetId<T>(T t, object objectId);
            static /*0x3907c14*/ T SetId<T>(T t, string stringId);
            static /*0x3907c14*/ T SetId<T>(T t, int intId);
            static /*0x3907c14*/ T SetLink<T>(T t, UnityEngine.GameObject gameObject);
            static /*0x3907c14*/ T SetLink<T>(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour);
            static /*0x3907c14*/ T SetTarget<T>(T t, object target);
            static /*0x3907c14*/ T SetLoops<T>(T t, int loops);
            static /*0x3907c14*/ T SetLoops<T>(T t, int loops, DG.Tweening.LoopType loopType);
            static /*0x3907c14*/ T SetEase<T>(T t, DG.Tweening.Ease ease);
            static /*0x3907c14*/ T SetEase<T>(T t, DG.Tweening.Ease ease, float overshoot);
            static /*0x3907c14*/ T SetEase<T>(T t, DG.Tweening.Ease ease, float amplitude, float period);
            static /*0x3907c14*/ T SetEase<T>(T t, UnityEngine.AnimationCurve animCurve);
            static /*0x3907c14*/ T SetEase<T>(T t, DG.Tweening.EaseFunction customEase);
            static /*0x3907c14*/ T SetRecyclable<T>(T t);
            static /*0x3907c14*/ T SetRecyclable<T>(T t, bool recyclable);
            static /*0x3907c14*/ T SetUpdate<T>(T t, bool isIndependentUpdate);
            static /*0x3907c14*/ T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType);
            static /*0x3907c14*/ T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            static /*0x3907c14*/ T SetInverted<T>(T t);
            static /*0x3907c14*/ T SetInverted<T>(T t, bool inverted);
            static /*0x3907c14*/ T OnStart<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnPlay<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnPause<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnRewind<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnUpdate<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnStepComplete<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnComplete<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnKill<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3907c14*/ T OnWaypointChange<T>(T t, DG.Tweening.TweenCallback<int> action);
            static /*0x3907c14*/ T SetAs<T>(T t, DG.Tweening.Tween asTween);
            static /*0x3907c14*/ T SetAs<T>(T t, DG.Tweening.TweenParams tweenParams);
            static /*0x3fbcba4*/ DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x3fc1e94*/ DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x3fbcbe8*/ DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x3fc1ecc*/ DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t);
            static /*0x3fb0e08*/ DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, float interval);
            static /*0x3fc1f14*/ DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, float interval);
            static /*0x3fc1f50*/ DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x3fc1f9c*/ DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x3fc1fe0*/ DG.Tweening.Sequence JoinCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x3fc202c*/ DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, float atPosition, DG.Tweening.TweenCallback callback);
            static /*0x3fc1e08*/ bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween);
            static /*0x3907c14*/ T From<T>(T t);
            static /*0x3907c14*/ T From<T>(T t, bool isRelative);
            static /*0x3907c14*/ T From<T>(T t, bool setImmediately, bool isRelative);
            static /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
            static /*0x3fc207c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, float fromAlphaValue, bool setImmediately, bool isRelative);
            static /*0x3fc2124*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, float fromValue, bool setImmediately, bool isRelative);
            static /*0x3fc21c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, float fromValueDegrees, bool setImmediately, bool isRelative);
            static /*0x3907c14*/ T SetDelay<T>(T t, float delay);
            static /*0x3907c14*/ T SetDelay<T>(T t, float delay, bool asPrependedIntervalIfSequence);
            static /*0x3907c14*/ T SetRelative<T>(T t);
            static /*0x3907c14*/ T SetRelative<T>(T t, bool isRelative);
            static /*0x3907c14*/ T SetSpeedBased<T>(T t);
            static /*0x3907c14*/ T SetSpeedBased<T>(T t, bool isSpeedBased);
            static /*0x3fc2268*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool snapping);
            static /*0x3fc2280*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x3fc2298*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fb9268*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x3fb9434*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fc22b4*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x3fc22cc*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fc22e8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool useShortest360Route);
            static /*0x3fad0f4*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool alphaOnly);
            static /*0x3fc2304*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool snapping);
            static /*0x3fc231c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x3fbb2dc*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool snapping);
            static /*0x3fc2404*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fc2420*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, float endValueDegrees, bool relativeCenter, bool snapping);
            static /*0x3fc2448*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x3fc2464*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x3fc2484*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fc259c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, bool stableZRotation);
            static /*0x3fc25d4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fc2678*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, bool stableZRotation);
            static /*0x3fc2708*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fc27b4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, bool stableZRotation);
            static /*0x3fc24bc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Options.OrientType orientType, UnityEngine.Vector3 lookAtPosition, UnityEngine.Transform lookAtTransform, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up, bool stableZRotation);
            static /*0x3fc2844*/ void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
        }

        enum LogBehaviour
        {
            Default = 0,
            Verbose = 1,
            ErrorsOnly = 2,
        }

        class Tween : DG.Tweening.Core.ABSSequentiable
        {
            /*0x28*/ float timeScale;
            /*0x2c*/ bool isBackwards;
            /*0x2d*/ bool isInverted;
            /*0x30*/ object id;
            /*0x38*/ string stringId;
            /*0x40*/ int intId;
            /*0x48*/ object target;
            /*0x50*/ DG.Tweening.UpdateType updateType;
            /*0x54*/ bool isIndependentUpdate;
            /*0x58*/ DG.Tweening.TweenCallback onPlay;
            /*0x60*/ DG.Tweening.TweenCallback onPause;
            /*0x68*/ DG.Tweening.TweenCallback onRewind;
            /*0x70*/ DG.Tweening.TweenCallback onUpdate;
            /*0x78*/ DG.Tweening.TweenCallback onStepComplete;
            /*0x80*/ DG.Tweening.TweenCallback onComplete;
            /*0x88*/ DG.Tweening.TweenCallback onKill;
            /*0x90*/ DG.Tweening.TweenCallback<int> onWaypointChange;
            /*0x98*/ bool isFrom;
            /*0x99*/ bool isBlendable;
            /*0x9a*/ bool isRecyclable;
            /*0x9b*/ bool isSpeedBased;
            /*0x9c*/ bool autoKill;
            /*0xa0*/ float duration;
            /*0xa4*/ int loops;
            /*0xa8*/ DG.Tweening.LoopType loopType;
            /*0xac*/ float delay;
            /*0xb0*/ bool <isRelative>k__BackingField;
            /*0xb4*/ DG.Tweening.Ease easeType;
            /*0xb8*/ DG.Tweening.EaseFunction customEase;
            /*0xc0*/ float easeOvershootOrAmplitude;
            /*0xc4*/ float easePeriod;
            /*0xc8*/ string debugTargetId;
            /*0xd0*/ System.Type typeofT1;
            /*0xd8*/ System.Type typeofT2;
            /*0xe0*/ System.Type typeofTPlugOptions;
            /*0xe8*/ bool <active>k__BackingField;
            /*0xe9*/ bool isSequenced;
            /*0xf0*/ DG.Tweening.Sequence sequenceParent;
            /*0xf8*/ int activeId;
            /*0xfc*/ DG.Tweening.Core.Enums.SpecialStartupMode specialStartupMode;
            /*0x100*/ bool creationLocked;
            /*0x101*/ bool startupDone;
            /*0x102*/ bool <playedOnce>k__BackingField;
            /*0x104*/ float <position>k__BackingField;
            /*0x108*/ float fullDuration;
            /*0x10c*/ int completedLoops;
            /*0x110*/ bool isPlaying;
            /*0x111*/ bool isComplete;
            /*0x114*/ float elapsedDelay;
            /*0x118*/ bool delayComplete;
            /*0x11c*/ int miscInt;

            static /*0x3fc2bdc*/ bool DoGoto(DG.Tweening.Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x3fb5440*/ bool OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t);
            static /*0x3907c14*/ bool OnTweenCallback<T>(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param);
            /*0x3fb3d74*/ Tween();
            /*0x3fc2b74*/ bool get_isRelative();
            /*0x3fc2b7c*/ void set_isRelative(bool value);
            /*0x3fc2b88*/ bool get_active();
            /*0x3fc2b90*/ void set_active(bool value);
            /*0x3fc2b9c*/ float get_fullPosition();
            /*0x3fc2ba4*/ void set_fullPosition(float value);
            /*0x3fb27c0*/ bool get_hasLoops();
            /*0x3fc2bb0*/ bool get_playedOnce();
            /*0x3fc2bb8*/ void set_playedOnce(bool value);
            /*0x3fc2bc4*/ float get_position();
            /*0x3fc2bcc*/ void set_position(float value);
            /*0x3fb43d4*/ void Reset();
            /*0x380b128*/ bool Validate();
            /*0x3fc2bd4*/ float UpdateDelay(float elapsed);
            /*0x380b128*/ bool Startup();
            bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class Tweener : DG.Tweening.Tween
        {
            /*0x120*/ bool hasManuallySetStartValue;
            /*0x121*/ bool isFromAllowed;

            static /*0x3907c14*/ bool Setup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            static /*0x38331dc*/ float DoUpdateDelay<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, float elapsed);
            static /*0x381ac0c*/ bool DoStartup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration);
            static /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue);
            static /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration);
            static /*0x381ac0c*/ bool DOStartupSpecials<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static /*0x3837da0*/ void DOStartupDurationBased<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            /*0x3fc2f48*/ Tweener();
            /*0x380c11c*/ DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
            DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
            /*0x380bba0*/ DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
            DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
            DG.Tweening.Tweener SetFrom(bool relative);
        }

        enum TweenType
        {
            Tweener = 0,
            Sequence = 1,
            Callback = 2,
        }

        enum UpdateType
        {
            Normal = 0,
            Late = 1,
            Fixed = 2,
            Manual = 3,
        }

        namespace Plugins
        {
            struct CircleOptions : DG.Tweening.Plugins.Options.IPlugOptions
            {
                /*0x10*/ float endValueDegrees;
                /*0x14*/ bool relativeCenter;
                /*0x15*/ bool snapping;
                /*0x18*/ UnityEngine.Vector2 center;
                /*0x20*/ float radius;
                /*0x24*/ float startValueDegrees;
                /*0x28*/ bool initialized;

                /*0x3fc2f70*/ void Reset();
                /*0x3fc2f84*/ void Initialize(UnityEngine.Vector2 startValue, UnityEngine.Vector2 endValue);
            }

            class CirclePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>
            {
                static /*0x3fc3390*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> Get();
                /*0x3fc356c*/ CirclePlugin();
                /*0x3fc3050*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0x3fc3054*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, bool isRelative);
                /*0x3fc3298*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0x3fc33d0*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 value);
                /*0x3fc33d4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0x3fc341c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0x3fc3468*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.CircleOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0x3fc3470*/ void EvaluateAndApply(DG.Tweening.Plugins.CircleOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fc310c*/ UnityEngine.Vector2 GetPositionOnCircle(DG.Tweening.Plugins.CircleOptions options, float degrees);
            }

            class Color2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x3fd0ea0*/ Color2Plugin();
                /*0x3fd05d8*/ void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fd05dc*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x3fd07dc*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, bool setImmediately, bool isRelative);
                /*0x3fd09b8*/ DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value);
                /*0x3fd09c4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fd0a18*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fd0a74*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, DG.Tweening.Color2 changeValue);
                /*0x3fd0a80*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, float elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class DoublePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<double, double, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fd1124*/ DoublePlugin();
                /*0x3fd0ee8*/ void Reset(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd0eec*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fd0f5c*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double fromValue, bool setImmediately, bool isRelative);
                /*0x3fd0ff0*/ double ConvertToStartValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double value);
                /*0x3fd0ff4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd1014*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd1034*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, double changeValue);
                /*0x3fd104c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class LongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<long, long, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fd1474*/ LongPlugin();
                /*0x3fd116c*/ void Reset(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd1170*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fd11d4*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long fromValue, bool setImmediately, bool isRelative);
                /*0x3fd125c*/ long ConvertToStartValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long value);
                /*0x3fd1264*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd1284*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd12a4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, long changeValue);
                /*0x3fd12bc*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UlongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fd1790*/ UlongPlugin();
                /*0x3fd14bc*/ void Reset(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd14c0*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fd1524*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative);
                /*0x3fd15ac*/ ulong ConvertToStartValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong value);
                /*0x3fd15b4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd15d4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd15f4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, ulong changeValue);
                /*0x3fd1610*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3ArrayPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>
            {
                /*0x3fd241c*/ Vector3ArrayPlugin();
                /*0x3fd17d8*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x3fd181c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool isRelative);
                /*0x3fd1820*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, bool setImmediately, bool isRelative);
                /*0x3fd1824*/ UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value);
                /*0x3fd1924*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x3fd1a0c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x3fd1b0c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, float unitsXSecond, UnityEngine.Vector3[] changeValue);
                /*0x3fd1c1c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class PathPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>
            {
                static float MinLookAhead = 0.00009999999747378752;

                static /*0x3fd2624*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> Get();
                /*0x3fd3fc4*/ PathPlugin();
                /*0x3fd2464*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x3fd261c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool isRelative);
                /*0x3fd2620*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, bool setImmediately, bool isRelative);
                /*0x3fd2664*/ DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value);
                /*0x3fd267c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x3fd2734*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x3fd2c5c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, float unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue);
                /*0x3fd2c78*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fd35bc*/ void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, float pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fd3fa4*/ UnityEngine.Vector3 DivideVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector);
                /*0x3fd3fb4*/ UnityEngine.Vector3 MultiplyVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector);
            }

            class ColorPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x3fd43ec*/ ColorPlugin();
                /*0x3fd400c*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fd4010*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x3fd40ec*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative);
                /*0x3fd41f8*/ UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value);
                /*0x3fd41fc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fd4220*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fd4244*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue);
                /*0x3fd4250*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class IntPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<int, int, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fd4740*/ IntPlugin();
                /*0x3fd4434*/ void Reset(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd4438*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fd44a0*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int fromValue, bool setImmediately, bool isRelative);
                /*0x3fd4528*/ int ConvertToStartValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int value);
                /*0x3fd4530*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd4554*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd4578*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, int changeValue);
                /*0x3fd4590*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class QuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>
            {
                /*0x3fd5814*/ QuaternionPlugin();
                /*0x3fd4788*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x3fd478c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool isRelative);
                /*0x3fd4dec*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0x3fd4f18*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value);
                /*0x3fd4f44*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x3fd4f7c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x3fd5144*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x3fd51c4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fd4b5c*/ UnityEngine.Vector3 GetEulerValForCalculations(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 val, UnityEngine.Vector3 counterVal);
                /*0x3fd57fc*/ UnityEngine.Vector3 FlipEulerAngles(UnityEngine.Vector3 euler);
            }

            class RectOffsetPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ UnityEngine.RectOffset _r;

                static /*0x3fd678c*/ RectOffsetPlugin();
                /*0x3fd6744*/ RectOffsetPlugin();
                /*0x3fd585c*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd58a0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fd5a1c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, bool setImmediately, bool isRelative);
                /*0x3fd5c44*/ UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value);
                /*0x3fd5d00*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd5e0c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fd5f64*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.RectOffset changeValue);
                /*0x3fd6020*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, float elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>
            {
                /*0x3fd7298*/ RectPlugin();
                /*0x3fd6808*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x3fd680c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool isRelative);
                /*0x3fd6b08*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, bool setImmediately, bool isRelative);
                /*0x3fd6e1c*/ UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value);
                /*0x3fd6e20*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x3fd6e44*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x3fd6e68*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, float unitsXSecond, UnityEngine.Rect changeValue);
                /*0x3fd6ee4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, float elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UintPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<uint, uint, DG.Tweening.Plugins.Options.UintOptions>
            {
                /*0x3fd762c*/ UintPlugin();
                /*0x3fd72e0*/ void Reset(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x3fd72e4*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, bool isRelative);
                /*0x3fd734c*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint fromValue, bool setImmediately, bool isRelative);
                /*0x3fd73d4*/ uint ConvertToStartValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint value);
                /*0x3fd73dc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x3fd7400*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x3fd7434*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, float unitsXSecond, uint changeValue);
                /*0x3fd744c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x3fd7f78*/ Vector2Plugin();
                /*0x3fd7674*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fd7678*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x3fd784c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0x3fd7a90*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value);
                /*0x3fd7a94*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fd7ab8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fd7b20*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0x3fd7b94*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector4Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x3fd8f7c*/ Vector4Plugin();
                /*0x3fd7fc0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fd7fc4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x3fd82e4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, bool setImmediately, bool isRelative);
                /*0x3fd86b4*/ UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value);
                /*0x3fd86b8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fd86dc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fd87c4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector4 changeValue);
                /*0x3fd8858*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, float elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class StringPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<string, string, DG.Tweening.Plugins.Options.StringOptions>
            {
                static /*0x0*/ System.Text.StringBuilder _Buffer;
                static /*0x8*/ System.Collections.Generic.List<char> _OpenedTags;

                static /*0x3fda244*/ StringPlugin();
                /*0x3fda1fc*/ StringPlugin();
                /*0x3fd8fc4*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool isRelative);
                /*0x3fd9040*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string fromValue, bool setImmediately, bool isRelative);
                /*0x3fd9128*/ void Reset(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x3fd91a0*/ string ConvertToStartValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string value);
                /*0x3fd91a8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x3fd91ac*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x3fd9434*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, float unitsXSecond, string changeValue);
                /*0x3fd9474*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fd990c*/ System.Text.StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled);
                /*0x3fd9fd0*/ char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options);
            }

            class StringPluginExtensions
            {
                static /*0x0*/ char[] ScrambledCharsAll;
                static /*0x8*/ char[] ScrambledCharsUppercase;
                static /*0x10*/ char[] ScrambledCharsLowercase;
                static /*0x18*/ char[] ScrambledCharsNumerals;
                static /*0x20*/ int _lastRndSeed;

                static /*0x3fda318*/ StringPluginExtensions();
                static /*0x3fda4cc*/ void ScrambleChars(char[] chars);
                static /*0x3fda0d4*/ System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, int length, char[] chars);
            }

            class FloatPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<float, float, DG.Tweening.Plugins.Options.FloatOptions>
            {
                /*0x3fdaa08*/ FloatPlugin();
                /*0x3fda56c*/ void Reset(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x3fda570*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool isRelative);
                /*0x3fda69c*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float fromValue, bool setImmediately, bool isRelative);
                /*0x3fda7f0*/ float ConvertToStartValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float value);
                /*0x3fda7f4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x3fda818*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x3fda83c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, float unitsXSecond, float changeValue);
                /*0x3fda850*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x3fdb6b4*/ Vector3Plugin();
                /*0x3fdaa50*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fdaa54*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x3fdacd0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0x3fdafd8*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value);
                /*0x3fdafdc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fdb014*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fdb0b8*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x3fdb138*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Options
            {
                interface IPlugOptions
                {
                    /*0x380cb08*/ void Reset();
                }

                enum OrientType
                {
                    None = 0,
                    ToPath = 1,
                    LookAtTransform = 2,
                    LookAtPosition = 3,
                }

                struct PathOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.PathMode mode;
                    /*0x14*/ DG.Tweening.Plugins.Options.OrientType orientType;
                    /*0x18*/ DG.Tweening.AxisConstraint lockPositionAxis;
                    /*0x1c*/ DG.Tweening.AxisConstraint lockRotationAxis;
                    /*0x20*/ bool isClosedPath;
                    /*0x24*/ UnityEngine.Vector3 lookAtPosition;
                    /*0x30*/ UnityEngine.Transform lookAtTransform;
                    /*0x38*/ float lookAhead;
                    /*0x3c*/ bool hasCustomForwardDirection;
                    /*0x40*/ UnityEngine.Quaternion forward;
                    /*0x50*/ bool useLocalPosition;
                    /*0x58*/ UnityEngine.Transform parent;
                    /*0x60*/ bool isRigidbody;
                    /*0x61*/ bool isRigidbody2D;
                    /*0x62*/ bool stableZRotation;
                    /*0x64*/ UnityEngine.Quaternion startupRot;
                    /*0x74*/ float startupZRot;
                    /*0x78*/ bool addedExtraStartWp;
                    /*0x79*/ bool addedExtraEndWp;

                    /*0x3fdb6fc*/ void Reset();
                }

                struct QuaternionOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.RotateMode rotateMode;
                    /*0x14*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x18*/ UnityEngine.Vector3 up;
                    /*0x24*/ bool dynamicLookAt;
                    /*0x28*/ UnityEngine.Vector3 dynamicLookAtWorldPosition;

                    /*0x3fdb80c*/ void Reset();
                }

                struct UintOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool isNegativeChangeValue;

                    /*0x3fdb880*/ void Reset();
                }

                struct Vector3ArrayOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;
                    /*0x18*/ float[] durations;

                    /*0x3fdb888*/ void Reset();
                }

                struct NoOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x3fdb89c*/ void Reset();
                }

                struct ColorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool alphaOnly;

                    /*0x3fdb8a0*/ void Reset();
                }

                struct FloatOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0x3fdb8a8*/ void Reset();
                }

                struct RectOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0x3fdb8b0*/ void Reset();
                }

                struct StringOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool richTextEnabled;
                    /*0x14*/ DG.Tweening.ScrambleMode scrambleMode;
                    /*0x18*/ char[] scrambledChars;
                    /*0x20*/ int startValueStrippedLength;
                    /*0x24*/ int changeValueStrippedLength;

                    /*0x3fdb8b8*/ void Reset();
                }

                struct VectorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;

                    /*0x3fdb8e0*/ void Reset();
                }
            }

            namespace Core
            {
                interface ITPlugin<T1, T2, TPlugOptions, TPlugin>
                {
                }

                class SpecialPluginsUtils
                {
                    static /*0x3fd56d8*/ bool SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                    static /*0x3fdb8ec*/ bool SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x3fdba5c*/ bool SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x3fdba88*/ bool SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                }

                interface IPlugSetter<T1, T2, TPlugin, TPlugOptions>
                {
                    /*0x380b9e8*/ DG.Tweening.Core.DOGetter<T1> Getter();
                    /*0x380b9e8*/ DG.Tweening.Core.DOSetter<T1> Setter();
                    /*0x3907c14*/ T2 EndValue();
                    /*0x3907c14*/ TPlugOptions GetOptions();
                }

                interface ITweenPlugin
                {
                }

                class ABSTweenPlugin<T1, T2, TPlugOptions> : DG.Tweening.Plugins.Core.ITweenPlugin
                {
                    /*0x380cb08*/ ABSTweenPlugin();
                    /*0x380d83c*/ void Reset(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
                    /*0x3907c14*/ void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
                    /*0x3907c14*/ T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T1 value);
                    /*0x380d83c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    /*0x380d83c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    /*0x3907c14*/ float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
                    /*0x3907c14*/ void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                }

                class PluginsManager
                {
                    static int _MaxCustomPlugins = 20;
                    static /*0x0*/ DG.Tweening.Plugins.Core.ITweenPlugin _floatPlugin;
                    static /*0x8*/ DG.Tweening.Plugins.Core.ITweenPlugin _doublePlugin;
                    static /*0x10*/ DG.Tweening.Plugins.Core.ITweenPlugin _intPlugin;
                    static /*0x18*/ DG.Tweening.Plugins.Core.ITweenPlugin _uintPlugin;
                    static /*0x20*/ DG.Tweening.Plugins.Core.ITweenPlugin _longPlugin;
                    static /*0x28*/ DG.Tweening.Plugins.Core.ITweenPlugin _ulongPlugin;
                    static /*0x30*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector2Plugin;
                    static /*0x38*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector3Plugin;
                    static /*0x40*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector4Plugin;
                    static /*0x48*/ DG.Tweening.Plugins.Core.ITweenPlugin _quaternionPlugin;
                    static /*0x50*/ DG.Tweening.Plugins.Core.ITweenPlugin _colorPlugin;
                    static /*0x58*/ DG.Tweening.Plugins.Core.ITweenPlugin _rectPlugin;
                    static /*0x60*/ DG.Tweening.Plugins.Core.ITweenPlugin _rectOffsetPlugin;
                    static /*0x68*/ DG.Tweening.Plugins.Core.ITweenPlugin _stringPlugin;
                    static /*0x70*/ DG.Tweening.Plugins.Core.ITweenPlugin _vector3ArrayPlugin;
                    static /*0x78*/ DG.Tweening.Plugins.Core.ITweenPlugin _color2Plugin;
                    static /*0x80*/ System.Collections.Generic.Dictionary<System.Type, DG.Tweening.Plugins.Core.ITweenPlugin> _customPlugins;

                    static /*0x382dee4*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>();
                    static /*0x382dee4*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>();
                    static /*0x3fdbc38*/ void PurgeAll();
                }

                namespace PathCore
                {
                    class CubicBezierDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x3fdc9dc*/ CubicBezierDecoder();
                        /*0x3fdc9cc*/ CubicBezierDecoder();
                        /*0x3fdbddc*/ int get_minInputWaypoints();
                        /*0x3fdbde4*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x3fdc844*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3fdc2fc*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x3fdc50c*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    struct ControlPoint
                    {
                        /*0x10*/ UnityEngine.Vector3 a;
                        /*0x1c*/ UnityEngine.Vector3 b;

                        static /*0x3fdca90*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v);
                        /*0x3fdc2ec*/ ControlPoint(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                        /*0x3fdcac0*/ string ToString();
                    }

                    class ABSPathDecoder
                    {
                        /*0x3fdc9d4*/ ABSPathDecoder();
                        void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x380b6a0*/ int get_minInputWaypoints();
                    }

                    class CatmullRomDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x3fdd708*/ CatmullRomDecoder();
                        /*0x3fdd700*/ CatmullRomDecoder();
                        /*0x3fdcc20*/ int get_minInputWaypoints();
                        /*0x3fdcc28*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x3fdd48c*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3fdce90*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x3fdd0a0*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class LinearDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        /*0x3fddbe4*/ LinearDecoder();
                        /*0x3fdd7bc*/ int get_minInputWaypoints();
                        /*0x3fdd7c4*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x3fdda38*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3fdd810*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x3fddbe0*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class Path
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder _catmullRomDecoder;
                        static /*0x8*/ DG.Tweening.Plugins.Core.PathCore.LinearDecoder _linearDecoder;
                        static /*0x10*/ DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder _cubicBezierDecoder;
                        /*0x10*/ float[] wpLengths;
                        /*0x18*/ UnityEngine.Vector3[] wps;
                        /*0x20*/ DG.Tweening.PathType type;
                        /*0x24*/ int subdivisionsXSegment;
                        /*0x28*/ int subdivisions;
                        /*0x30*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints;
                        /*0x38*/ float length;
                        /*0x3c*/ bool isFinalized;
                        /*0x40*/ float[] timesTable;
                        /*0x48*/ float[] lengthsTable;
                        /*0x50*/ int linearWPIndex;
                        /*0x54*/ bool addedExtraStartWp;
                        /*0x55*/ bool addedExtraEndWp;
                        /*0x58*/ DG.Tweening.Plugins.Options.PathOptions plugOptions;
                        /*0xc8*/ DG.Tweening.Plugins.Core.PathCore.Path _incrementalClone;
                        /*0xd0*/ int _incrementalIndex;
                        /*0xd8*/ DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder _decoder;
                        /*0xe0*/ bool _changed;
                        /*0xe8*/ UnityEngine.Vector3[] nonLinearDrawWps;
                        /*0xf0*/ UnityEngine.Vector3 targetPosition;
                        /*0xfc*/ System.Nullable<UnityEngine.Vector3> lookAtPosition;
                        /*0x10c*/ UnityEngine.Color gizmoColor;

                        static /*0x3fde088*/ UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, int drawSubdivisionsXSegment);
                        static /*0x3fde164*/ void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0x3fde270*/ void Draw(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0x3fde690*/ UnityEngine.Vector3 ConvertToDrawPoint(UnityEngine.Vector3 wp, DG.Tweening.Plugins.Options.PathOptions plugOptions);
                        /*0x3fddbec*/ Path(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, int subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor);
                        /*0x3fde068*/ Path();
                        /*0x3fd2b98*/ int get_minInputWaypoints();
                        /*0x3fd2bb8*/ void FinalizePath(bool isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal);
                        /*0x3fd3580*/ UnityEngine.Vector3 GetPoint(float perc, bool convertToConstantPerc);
                        /*0x3fd346c*/ float ConvertToConstantPathPerc(float perc);
                        /*0x3fd3efc*/ int GetWaypointIndexFromPerc(float perc, bool isMovingForward);
                        /*0x3fd24c0*/ void Destroy();
                        /*0x3fd2f64*/ DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(int loopIncrement);
                        /*0x3fdddfc*/ void AssignWaypoints(UnityEngine.Vector3[] newWps, bool cloneWps);
                        /*0x3fddef4*/ void AssignDecoder(DG.Tweening.PathType pathType);
                        /*0x3fde26c*/ void Draw();
                    }
                }
            }
        }

        namespace CustomPlugins
        {
            class PureQuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;

                static /*0x3fde754*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug();
                /*0x3fde7d8*/ PureQuaternionPlugin();
                /*0x3fde820*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fde824*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fde938*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, bool setImmediately, bool isRelative);
                /*0x3fdeaec*/ UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value);
                /*0x3fdeaf0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdeba4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdebc8*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.Quaternion changeValue);
                /*0x3fdec7c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }
        }

        namespace Core
        {
            class ABSSequentiable
            {
                /*0x10*/ DG.Tweening.TweenType tweenType;
                /*0x14*/ float sequencedPosition;
                /*0x18*/ float sequencedEndPosition;
                /*0x20*/ DG.Tweening.TweenCallback onStart;

                /*0x3fded28*/ ABSSequentiable();
            }

            class DOGetter<T> : System.MulticastDelegate
            {
                DOGetter(object object, nint method);
                /*0x3907c14*/ T Invoke();
                /*0x380bcbc*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x3907c14*/ T EndInvoke(System.IAsyncResult result);
            }

            class DOSetter<T> : System.MulticastDelegate
            {
                DOSetter(object object, nint method);
                /*0x3907c14*/ void Invoke(T pNewValue);
                /*0x3907c14*/ System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, object object);
                /*0x380d83c*/ void EndInvoke(System.IAsyncResult result);
            }

            class Debugger
            {
                static string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>";
                static /*0x0*/ int _logPriority;

                static /*0x3fded30*/ int get_logPriority();
                static /*0x3fded78*/ void Log(object message);
                static /*0x3fdee9c*/ void LogWarning(object message, DG.Tweening.Tween t);
                static /*0x3fdf08c*/ void LogError(object message, DG.Tweening.Tween t);
                static /*0x3fdf21c*/ void LogSafeModeCapturedError(object message, DG.Tweening.Tween t);
                static /*0x3fdf440*/ void LogReport(object message);
                static /*0x3fdf568*/ void LogSafeModeReport(object message);
                static /*0x3fdf690*/ void LogInvalidTween(DG.Tweening.Tween t);
                static /*0x3fdf6d4*/ void LogNestedTween(DG.Tweening.Tween t);
                static /*0x3fdf71c*/ void LogNullTween(DG.Tweening.Tween t);
                static /*0x3fdf760*/ void LogNonPathTween(DG.Tweening.Tween t);
                static /*0x3fdf7a8*/ void LogMissingMaterialProperty(string propertyName);
                static /*0x3fdf7fc*/ void LogMissingMaterialProperty(int propertyId);
                static /*0x3fdf878*/ void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x3fdf8d8*/ void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x3fdf938*/ void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour);
                static /*0x3fdf9ac*/ bool ShouldLogSafeModeCapturedError();
                static /*0x3fdf02c*/ string GetDebugDataMessage(DG.Tweening.Tween t);
                static /*0x3fdfa4c*/ void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t);

                class Sequence
                {
                    static /*0x3fdfc1c*/ void LogAddToNullSequence();
                    static /*0x3fdfc60*/ void LogAddToInactiveSequence();
                    static /*0x3fdfca4*/ void LogAddToLockedSequence();
                    static /*0x3fdfce8*/ void LogAddNullTween();
                    static /*0x3fdfd2c*/ void LogAddInactiveTween(DG.Tweening.Tween t);
                    static /*0x3fdfd74*/ void LogAddAlreadySequencedTween(DG.Tweening.Tween t);
                }
            }

            class DOTweenComponent : UnityEngine.MonoBehaviour, DG.Tweening.IDOTweenInit
            {
                /*0x20*/ int inspectorUpdater;
                /*0x24*/ float _unscaledTime;
                /*0x28*/ float _unscaledDeltaTime;
                /*0x2c*/ bool _paused;
                /*0x30*/ float _pausedTime;
                /*0x34*/ bool _isQuitting;
                /*0x35*/ bool _duplicateToDestroy;

                static /*0x3fe105c*/ void Create();
                static /*0x3fe11a8*/ void DestroyInstance();
                /*0x3fe12ac*/ DOTweenComponent();
                /*0x3fdfdbc*/ void Awake();
                /*0x3fdffd4*/ void Start();
                /*0x3fe00ac*/ void Update();
                /*0x3fe0398*/ void LateUpdate();
                /*0x3fe04b0*/ void FixedUpdate();
                /*0x3fe0628*/ void OnDrawGizmos();
                /*0x3fe0768*/ void OnDestroy();
                /*0x3fe0bd4*/ void OnApplicationPause(bool pauseStatus);
                /*0x3fe0c30*/ void OnApplicationQuit();
                /*0x3fe0c90*/ DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
                /*0x3fe0d04*/ System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t);
                /*0x3fe0d98*/ System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t);
                /*0x3fe0e0c*/ System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t);
                /*0x3fe0ea0*/ System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
                /*0x3fe0f44*/ System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, float position);
                /*0x3fe0fe8*/ System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t);

                class <WaitForCompletion>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fe0d70*/ <WaitForCompletion>d__17(int <>1__state);
                    /*0x3fe12b4*/ void System.IDisposable.Dispose();
                    /*0x3fe12b8*/ bool MoveNext();
                    /*0x3fe1318*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fe1320*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fe1358*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForElapsedLoops>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ int elapsedLoops;

                    /*0x3fe0f1c*/ <WaitForElapsedLoops>d__20(int <>1__state);
                    /*0x3fe1360*/ void System.IDisposable.Dispose();
                    /*0x3fe1364*/ bool MoveNext();
                    /*0x3fe13cc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fe13d4*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fe140c*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForKill>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fe0e78*/ <WaitForKill>d__19(int <>1__state);
                    /*0x3fe1414*/ void System.IDisposable.Dispose();
                    /*0x3fe1418*/ bool MoveNext();
                    /*0x3fe1470*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fe1478*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fe14b0*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForPosition>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ float position;

                    /*0x3fe0fc0*/ <WaitForPosition>d__21(int <>1__state);
                    /*0x3fe14b8*/ void System.IDisposable.Dispose();
                    /*0x3fe14bc*/ bool MoveNext();
                    /*0x3fe1534*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fe153c*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fe1574*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForRewind>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fe1768*/ <WaitForRewind>d__18(int <>1__state);
                    /*0x3fe1790*/ void System.IDisposable.Dispose();
                    /*0x3fe1794*/ bool MoveNext();
                    /*0x3fe1810*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fe1818*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fe1850*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForStart>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fe1858*/ <WaitForStart>d__22(int <>1__state);
                    /*0x3fe1880*/ void System.IDisposable.Dispose();
                    /*0x3fe1884*/ bool MoveNext();
                    /*0x3fe18e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fe18ec*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fe1924*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DOTweenSettings : UnityEngine.ScriptableObject
            {
                static string AssetName = "DOTweenSettings";
                static string AssetFullFilename = "DOTweenSettings.asset";
                /*0x18*/ bool useSafeMode;
                /*0x20*/ DG.Tweening.Core.DOTweenSettings.SafeModeOptions safeModeOptions;
                /*0x28*/ float timeScale;
                /*0x2c*/ float unscaledTimeScale;
                /*0x30*/ bool useSmoothDeltaTime;
                /*0x34*/ float maxSmoothUnscaledTime;
                /*0x38*/ DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
                /*0x3c*/ bool showUnityEditorReport;
                /*0x40*/ DG.Tweening.LogBehaviour logBehaviour;
                /*0x44*/ bool drawGizmos;
                /*0x45*/ bool defaultRecyclable;
                /*0x48*/ DG.Tweening.AutoPlay defaultAutoPlay;
                /*0x4c*/ DG.Tweening.UpdateType defaultUpdateType;
                /*0x50*/ bool defaultTimeScaleIndependent;
                /*0x54*/ DG.Tweening.Ease defaultEaseType;
                /*0x58*/ float defaultEaseOvershootOrAmplitude;
                /*0x5c*/ float defaultEasePeriod;
                /*0x60*/ bool defaultAutoKill;
                /*0x64*/ DG.Tweening.LoopType defaultLoopType;
                /*0x68*/ bool debugMode;
                /*0x69*/ bool debugStoreTargetId;
                /*0x6a*/ bool showPreviewPanel;
                /*0x6c*/ DG.Tweening.Core.DOTweenSettings.SettingsLocation storeSettingsLocation;
                /*0x70*/ DG.Tweening.Core.DOTweenSettings.ModulesSetup modules;
                /*0x78*/ bool createASMDEF;
                /*0x79*/ bool showPlayingTweens;
                /*0x7a*/ bool showPausedTweens;

                /*0x3fe192c*/ DOTweenSettings();

                enum SettingsLocation
                {
                    AssetsDirectory = 0,
                    DOTweenDirectory = 1,
                    DemigiantDirectory = 2,
                }

                class SafeModeOptions
                {
                    /*0x10*/ DG.Tweening.Core.Enums.SafeModeLogBehaviour logBehaviour;
                    /*0x14*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;

                    /*0x3fe1a30*/ SafeModeOptions();
                }

                class ModulesSetup
                {
                    /*0x10*/ bool showPanel;
                    /*0x11*/ bool audioEnabled;
                    /*0x12*/ bool physicsEnabled;
                    /*0x13*/ bool physics2DEnabled;
                    /*0x14*/ bool spriteEnabled;
                    /*0x15*/ bool uiEnabled;
                    /*0x16*/ bool textMeshProEnabled;
                    /*0x17*/ bool tk2DEnabled;
                    /*0x18*/ bool deAudioEnabled;
                    /*0x19*/ bool deUnityExtendedEnabled;
                    /*0x1a*/ bool epoOutlineEnabled;

                    /*0x3fe1a40*/ ModulesSetup();
                }
            }

            class Extensions
            {
                static /*0x3907c14*/ T SetSpecialStartupMode<T>(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode);
                static /*0x382eaf0*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                static /*0x382eaf0*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            }

            class DOTweenExternalCommand
            {
                static /*0x0*/ System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> SetOrientationOnPath;

                static /*0x3fe1a54*/ void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x3fe1b20*/ void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x3fe1bec*/ void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
            }

            struct SafeModeReport
            {
                /*0x10*/ int <totMissingTargetOrFieldErrors>k__BackingField;
                /*0x14*/ int <totCallbackErrors>k__BackingField;
                /*0x18*/ int <totStartupErrors>k__BackingField;
                /*0x1c*/ int <totUnsetErrors>k__BackingField;

                /*0x3fe1ccc*/ int get_totMissingTargetOrFieldErrors();
                /*0x3fe1cd4*/ void set_totMissingTargetOrFieldErrors(int value);
                /*0x3fe1cdc*/ int get_totCallbackErrors();
                /*0x3fe1ce4*/ void set_totCallbackErrors(int value);
                /*0x3fe1cec*/ int get_totStartupErrors();
                /*0x3fe1cf4*/ void set_totStartupErrors(int value);
                /*0x3fe1cfc*/ int get_totUnsetErrors();
                /*0x3fe1d04*/ void set_totUnsetErrors(int value);
                /*0x3fe1d0c*/ void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type);
                /*0x3fe1d48*/ int GetTotErrors();

                enum SafeModeReportType
                {
                    Unset = 0,
                    TargetOrFieldMissing = 1,
                    Callback = 2,
                    StartupFailure = 3,
                }
            }

            class SequenceCallback : DG.Tweening.Core.ABSSequentiable
            {
                /*0x3fe1d58*/ SequenceCallback(float sequencedPosition, DG.Tweening.TweenCallback callback);
            }

            class TweenLink
            {
                /*0x10*/ UnityEngine.GameObject target;
                /*0x18*/ DG.Tweening.LinkBehaviour behaviour;
                /*0x1c*/ bool lastSeenActive;

                /*0x3fe1da0*/ TweenLink(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour);
            }

            class TweenManager
            {
                static int _DefaultMaxTweeners = 200;
                static int _DefaultMaxSequences = 50;
                static string _MaxTweensReached = "Max Tweens reached: capacity has automatically been increased from #0 to #1. Use DOTween.SetTweensCapacity to set it manually at startup";
                static float _EpsilonVsTimeCheck = 9.999999974752427e-7;
                static /*0x0*/ bool isUnityEditor;
                static /*0x1*/ bool isDebugBuild;
                static /*0x4*/ int maxActive;
                static /*0x8*/ int maxTweeners;
                static /*0xc*/ int maxSequences;
                static /*0x10*/ bool hasActiveTweens;
                static /*0x11*/ bool hasActiveDefaultTweens;
                static /*0x12*/ bool hasActiveLateTweens;
                static /*0x13*/ bool hasActiveFixedTweens;
                static /*0x14*/ bool hasActiveManualTweens;
                static /*0x18*/ int totActiveTweens;
                static /*0x1c*/ int totActiveDefaultTweens;
                static /*0x20*/ int totActiveLateTweens;
                static /*0x24*/ int totActiveFixedTweens;
                static /*0x28*/ int totActiveManualTweens;
                static /*0x2c*/ int totActiveTweeners;
                static /*0x30*/ int totActiveSequences;
                static /*0x34*/ int totPooledTweeners;
                static /*0x38*/ int totPooledSequences;
                static /*0x3c*/ int totTweeners;
                static /*0x40*/ int totSequences;
                static /*0x44*/ bool isUpdateLoop;
                static /*0x48*/ DG.Tweening.Tween[] _activeTweens;
                static /*0x50*/ DG.Tweening.Tween[] _pooledTweeners;
                static /*0x58*/ System.Collections.Generic.Stack<DG.Tweening.Tween> _PooledSequences;
                static /*0x60*/ System.Collections.Generic.List<DG.Tweening.Tween> _KillList;
                static /*0x68*/ System.Collections.Generic.Dictionary<DG.Tweening.Tween, DG.Tweening.Core.TweenLink> _TweenLinks;
                static /*0x70*/ int _totTweenLinks;
                static /*0x74*/ int _maxActiveLookupId;
                static /*0x78*/ bool _requiresActiveReorganization;
                static /*0x7c*/ int _reorganizeFromId;
                static /*0x80*/ int _minPooledTweenerId;
                static /*0x84*/ int _maxPooledTweenerId;
                static /*0x88*/ bool _despawnAllCalledFromUpdateLoopCallback;

                static /*0x3fe1e04*/ TweenManager();
                static /*0x382dee4*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>();
                static /*0x3fe2028*/ DG.Tweening.Sequence GetSequence();
                static /*0x3fe280c*/ void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
                static /*0x3fe2a50*/ void AddActiveTweenToSequence(DG.Tweening.Tween t);
                static /*0x3fe2f2c*/ int DespawnAll();
                static /*0x3fe30a4*/ void Despawn(DG.Tweening.Tween t, bool modifyActiveLists);
                static /*0x3fe3600*/ void PurgeAll(bool isApplicationQuitting);
                static /*0x3fe372c*/ void PurgePools();
                static /*0x3fe3830*/ void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink);
                static /*0x3fe3a6c*/ void RemoveTweenLink(DG.Tweening.Tween t);
                static /*0x3fe37dc*/ void ResetCapacities();
                static /*0x3fe3b48*/ void SetCapacities(int tweenersCapacity, int sequencesCapacity);
                static /*0x3fe3c28*/ int Validate();
                static /*0x3fe4190*/ void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime);
                static /*0x3fe43a0*/ bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate);
                static /*0x3fe483c*/ int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray);
                static /*0x3fe51bc*/ bool Complete(DG.Tweening.Tween t, bool modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x3fe529c*/ bool Flip(DG.Tweening.Tween t);
                static /*0x3fe510c*/ void ForceInit(DG.Tweening.Tween t, bool isSequenced);
                static /*0x3fe52c4*/ bool Goto(DG.Tweening.Tween t, float to, bool andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x3fe3a30*/ bool Pause(DG.Tweening.Tween t);
                static /*0x3fe39b0*/ bool Play(DG.Tweening.Tween t);
                static /*0x3fe5400*/ bool PlayBackwards(DG.Tweening.Tween t);
                static /*0x3fe54d8*/ bool PlayForward(DG.Tweening.Tween t);
                static /*0x3fe5588*/ bool Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
                static /*0x3fe5650*/ bool Rewind(DG.Tweening.Tween t, bool includeDelay);
                static /*0x3fe5770*/ bool SmoothRewind(DG.Tweening.Tween t);
                static /*0x3fe586c*/ bool TogglePause(DG.Tweening.Tween t);
                static /*0x3fe597c*/ int TotalPooledTweens();
                static /*0x3fe59d8*/ int TotalPlayingTweens();
                static /*0x3fe5ae4*/ int TotalTweensById(object id, bool playingOnly);
                static /*0x3fe5df8*/ System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(bool playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3fe5ffc*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3fe5bb4*/ int DoGetTweensById(object id, bool playingOnly, bool addToList, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3fe6148*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3fe3fb4*/ void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate);
                static /*0x3fe45fc*/ void EvaluateTweenLink(DG.Tweening.Tween t);
                static /*0x3fe2310*/ void AddActiveTween(DG.Tweening.Tween t);
                static /*0x3fe3dac*/ void ReorganizeActiveTweens();
                static /*0x3fe40d8*/ void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens);
                static /*0x3fe2aa4*/ void RemoveActiveTween(DG.Tweening.Tween t);
                static /*0x3fe3588*/ void ClearTweenArray(DG.Tweening.Tween[] tweens);
                static /*0x3fe25f0*/ void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode);
                static /*0x3fe58dc*/ void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind);

                enum CapacityIncreaseMode
                {
                    TweenersAndSequences = 0,
                    TweenersOnly = 1,
                    SequencesOnly = 2,
                }
            }

            class DOTweenUtils
            {
                static /*0x0*/ System.Reflection.Assembly[] _loadedAssemblies;
                static /*0x8*/ string[] _defAssembliesToQuery;

                static /*0x3fe6914*/ DOTweenUtils();
                static /*0x3fe6360*/ UnityEngine.Vector3 Vector3FromAngle(float degrees, float magnitude);
                static /*0x3fe63a8*/ float Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
                static /*0x3fe64f4*/ UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation);
                static /*0x3fe6550*/ UnityEngine.Vector2 GetPointOnCircle(UnityEngine.Vector2 center, float radius, float degrees);
                static /*0x3fe65b8*/ bool Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                static /*0x3fe66b8*/ System.Type GetLooseScriptType(string typeName);
            }

            class TweenerCore<T1, T2, TPlugOptions> : DG.Tweening.Tweener
            {
                static string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";
                /*0x0*/ T2 startValue;
                /*0x0*/ T2 endValue;
                /*0x0*/ T2 changeValue;
                /*0x0*/ TPlugOptions plugOptions;
                /*0x0*/ DG.Tweening.Core.DOGetter<T1> getter;
                /*0x0*/ DG.Tweening.Core.DOSetter<T1> setter;
                /*0x0*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
                /*0x0*/ System.Type _colorType;
                /*0x0*/ System.Type _color32Type;

                /*0x380cb08*/ TweenerCore();
                /*0x380c11c*/ DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
                /*0x380bba0*/ DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
                /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration);
                /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
                /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration, bool snapStartValue);
                /*0x3907c14*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration);
                DG.Tweening.Tweener SetFrom(bool relative);
                /*0x3907c14*/ DG.Tweening.Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative);
                /*0x380cb08*/ void Reset();
                /*0x380b128*/ bool Validate();
                /*0x380b32c*/ bool ValidateChangeValueType(System.Type newType, ref bool isColor32ToColor);
                /*0x380c3e8*/ float UpdateDelay(float elapsed);
                /*0x380b128*/ bool Startup();
                bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Enums
            {
                enum FilterType
                {
                    All = 0,
                    TargetOrId = 1,
                    TargetAndId = 2,
                    AllExceptTargetsOrIds = 3,
                    DOGetter = 4,
                }

                enum NestedTweenFailureBehaviour
                {
                    TryToPreserveSequence = 0,
                    KillWholeSequence = 1,
                }

                enum OperationType
                {
                    Complete = 0,
                    Despawn = 1,
                    Flip = 2,
                    Goto = 3,
                    Pause = 4,
                    Play = 5,
                    PlayForward = 6,
                    PlayBackwards = 7,
                    Rewind = 8,
                    SmoothRewind = 9,
                    Restart = 10,
                    TogglePause = 11,
                    IsTweening = 12,
                }

                enum SafeModeLogBehaviour
                {
                    None = 0,
                    Normal = 1,
                    Warning = 2,
                    Error = 3,
                }

                enum SpecialStartupMode
                {
                    None = 0,
                    SetLookAt = 1,
                    SetShake = 2,
                    SetPunch = 3,
                    SetCameraShakePosition = 4,
                }

                enum UpdateNotice
                {
                    None = 0,
                    RewindStep = 1,
                }

                enum UpdateMode
                {
                    Update = 0,
                    Goto = 1,
                    IgnoreOnUpdate = 2,
                    IgnoreOnComplete = 3,
                }

                enum RewindCallbackMode
                {
                    FireIfPositionChanged = 0,
                    FireAlwaysWithRewind = 1,
                    FireAlways = 2,
                }
            }

            namespace Easing
            {
                class Bounce
                {
                    static /*0x3fe6a24*/ float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x3fe6a40*/ float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x3fe6afc*/ float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                }

                class EaseManager
                {
                    static float _PiOver2 = 1.5707963705062866;
                    static float _TwoPi = 6.2831854820251465;

                    static /*0x3fe6b4c*/ float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3fe6b6c*/ float Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3fe7910*/ DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease);
                    static /*0x3fe8cb4*/ bool IsFlashEase(DG.Tweening.Ease ease);

                    class <>c
                    {
                        static /*0x0*/ DG.Tweening.Core.Easing.EaseManager.<> <>9;
                        static /*0x8*/ DG.Tweening.EaseFunction <>9__4_0;
                        static /*0x10*/ DG.Tweening.EaseFunction <>9__4_1;
                        static /*0x18*/ DG.Tweening.EaseFunction <>9__4_2;
                        static /*0x20*/ DG.Tweening.EaseFunction <>9__4_3;
                        static /*0x28*/ DG.Tweening.EaseFunction <>9__4_4;
                        static /*0x30*/ DG.Tweening.EaseFunction <>9__4_5;
                        static /*0x38*/ DG.Tweening.EaseFunction <>9__4_6;
                        static /*0x40*/ DG.Tweening.EaseFunction <>9__4_7;
                        static /*0x48*/ DG.Tweening.EaseFunction <>9__4_8;
                        static /*0x50*/ DG.Tweening.EaseFunction <>9__4_9;
                        static /*0x58*/ DG.Tweening.EaseFunction <>9__4_10;
                        static /*0x60*/ DG.Tweening.EaseFunction <>9__4_11;
                        static /*0x68*/ DG.Tweening.EaseFunction <>9__4_12;
                        static /*0x70*/ DG.Tweening.EaseFunction <>9__4_13;
                        static /*0x78*/ DG.Tweening.EaseFunction <>9__4_14;
                        static /*0x80*/ DG.Tweening.EaseFunction <>9__4_15;
                        static /*0x88*/ DG.Tweening.EaseFunction <>9__4_16;
                        static /*0x90*/ DG.Tweening.EaseFunction <>9__4_17;
                        static /*0x98*/ DG.Tweening.EaseFunction <>9__4_18;
                        static /*0xa0*/ DG.Tweening.EaseFunction <>9__4_19;
                        static /*0xa8*/ DG.Tweening.EaseFunction <>9__4_20;
                        static /*0xb0*/ DG.Tweening.EaseFunction <>9__4_21;
                        static /*0xb8*/ DG.Tweening.EaseFunction <>9__4_22;
                        static /*0xc0*/ DG.Tweening.EaseFunction <>9__4_23;
                        static /*0xc8*/ DG.Tweening.EaseFunction <>9__4_24;
                        static /*0xd0*/ DG.Tweening.EaseFunction <>9__4_25;
                        static /*0xd8*/ DG.Tweening.EaseFunction <>9__4_26;
                        static /*0xe0*/ DG.Tweening.EaseFunction <>9__4_27;
                        static /*0xe8*/ DG.Tweening.EaseFunction <>9__4_28;
                        static /*0xf0*/ DG.Tweening.EaseFunction <>9__4_29;
                        static /*0xf8*/ DG.Tweening.EaseFunction <>9__4_30;
                        static /*0x100*/ DG.Tweening.EaseFunction <>9__4_31;
                        static /*0x108*/ DG.Tweening.EaseFunction <>9__4_32;
                        static /*0x110*/ DG.Tweening.EaseFunction <>9__4_33;
                        static /*0x118*/ DG.Tweening.EaseFunction <>9__4_34;
                        static /*0x120*/ DG.Tweening.EaseFunction <>9__4_35;

                        static /*0x3fe8cc4*/ <>c();
                        /*0x3fe8d2c*/ <>c();
                        /*0x3fe8d34*/ float <ToEaseFunction>b__4_0(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8d3c*/ float <ToEaseFunction>b__4_1(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8dbc*/ float <ToEaseFunction>b__4_2(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8e34*/ float <ToEaseFunction>b__4_3(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8ebc*/ float <ToEaseFunction>b__4_4(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8ec8*/ float <ToEaseFunction>b__4_5(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8ee0*/ float <ToEaseFunction>b__4_6(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8f24*/ float <ToEaseFunction>b__4_7(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8f34*/ float <ToEaseFunction>b__4_8(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8f54*/ float <ToEaseFunction>b__4_9(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8f9c*/ float <ToEaseFunction>b__4_10(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8fb0*/ float <ToEaseFunction>b__4_11(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe8fd4*/ float <ToEaseFunction>b__4_12(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9020*/ float <ToEaseFunction>b__4_13(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9038*/ float <ToEaseFunction>b__4_14(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9060*/ float <ToEaseFunction>b__4_15(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe90b8*/ float <ToEaseFunction>b__4_16(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9140*/ float <ToEaseFunction>b__4_17(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe91c8*/ float <ToEaseFunction>b__4_18(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe92b8*/ float <ToEaseFunction>b__4_19(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9334*/ float <ToEaseFunction>b__4_20(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe93ac*/ float <ToEaseFunction>b__4_21(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9460*/ float <ToEaseFunction>b__4_22(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe95ac*/ float <ToEaseFunction>b__4_23(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe96f4*/ float <ToEaseFunction>b__4_24(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe98c0*/ float <ToEaseFunction>b__4_25(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe98e0*/ float <ToEaseFunction>b__4_26(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe990c*/ float <ToEaseFunction>b__4_27(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe997c*/ float <ToEaseFunction>b__4_28(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe9998*/ float <ToEaseFunction>b__4_29(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe999c*/ float <ToEaseFunction>b__4_30(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe99a0*/ float <ToEaseFunction>b__4_31(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe99a4*/ float <ToEaseFunction>b__4_32(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe99a8*/ float <ToEaseFunction>b__4_33(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe99ac*/ float <ToEaseFunction>b__4_34(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3fe99b0*/ float <ToEaseFunction>b__4_35(float time, float duration, float overshootOrAmplitude, float period);
                    }
                }

                class EaseCurve
                {
                    /*0x10*/ UnityEngine.AnimationCurve _animCurve;

                    /*0x3fe99c8*/ EaseCurve(UnityEngine.AnimationCurve animCurve);
                    /*0x3fe99f8*/ float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod);
                }

                class Flash
                {
                    static /*0x3fe75ac*/ float Ease(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3fe7670*/ float EaseIn(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3fe7738*/ float EaseOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3fe780c*/ float EaseInOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3fe9a94*/ float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 4EF0676A416B9CCF117C378BDCB6C5CA0EA9505154E3F0F7CC8570285DB79663;
    static /*0x32*/ <PrivateImplementationDetails> 921D53955C220A863C9C5D33DD45329C6F74471C522EA5D46EA838D8D4838055;
    static /*0x46*/ <PrivateImplementationDetails> A203B1199E78DE3BB75B28FC520ED2F86ADB2749BFC52E3ACA275A3BE2587678;
    static /*0xbe*/ <PrivateImplementationDetails> C845A807AA8EC73757DC1B07EA49311061FEDECA35AFFE91C5474E0814925020;

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=50
    {
    }

    struct __StaticArrayInitTypeSize=120
    {
    }
}
