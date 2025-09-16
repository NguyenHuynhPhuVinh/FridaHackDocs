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

            static /*0x3fb6d18*/ DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x3fb6d30*/ DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x3fb6d48*/ DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, float f);
            /*0x3fb6d04*/ Color2(UnityEngine.Color ca, UnityEngine.Color cb);
        }

        class TweenCallback : System.MulticastDelegate
        {
            /*0x3fb6d5c*/ TweenCallback(object object, nint method);
            /*0x3fb6df8*/ void Invoke();
            /*0x3fb6e0c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x3fb6e2c*/ void EndInvoke(System.IAsyncResult result);
        }

        class TweenCallback<T> : System.MulticastDelegate
        {
            TweenCallback(object object, nint method);
            /*0x3910ae8*/ void Invoke(T value);
            /*0x3910ae8*/ System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, object object);
            /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
        }

        class EaseFunction : System.MulticastDelegate
        {
            /*0x3fb6e38*/ EaseFunction(object object, nint method);
            /*0x3fb6ed8*/ float Invoke(float time, float duration, float overshootOrAmplitude, float period);
            /*0x3fb6eec*/ System.IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, System.AsyncCallback callback, object object);
            /*0x3fb6f98*/ float EndInvoke(System.IAsyncResult result);
        }

        class DOCurve
        {
            class CubicBezier
            {
                static /*0x3fb6fc0*/ UnityEngine.Vector3 GetPointOnSegment(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, float factor);
                static /*0x3fb7058*/ UnityEngine.Vector3[] GetSegmentPointCloud(UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, int resolution);
                static /*0x3fb7180*/ void GetSegmentPointCloud(System.Collections.Generic.List<UnityEngine.Vector3> addToList, UnityEngine.Vector3 startPoint, UnityEngine.Vector3 startControlPoint, UnityEngine.Vector3 endPoint, UnityEngine.Vector3 endControlPoint, int resolution);
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

            static /*0x3fbb8c0*/ DOTween();
            static /*0x3fb72d0*/ DG.Tweening.LogBehaviour get_logBehaviour();
            static /*0x3fb7328*/ void set_logBehaviour(DG.Tweening.LogBehaviour value);
            static /*0x3fb738c*/ bool get_debugStoreTargetId();
            static /*0x3fb742c*/ void set_debugStoreTargetId(bool value);
            static /*0x3fb748c*/ bool get_isQuitting();
            static /*0x3fb7554*/ void set_isQuitting(bool value);
            static /*0x3fb75ec*/ DG.Tweening.IDOTweenInit Init(System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x3fb7d94*/ void AutoInit();
            static /*0x3fb776c*/ DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x3fb7ebc*/ void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity);
            static /*0x3fb7f24*/ void Clear(bool destroy);
            static /*0x3fb7f7c*/ void Clear(bool destroy, bool isApplicationQuitting);
            static /*0x3fb80fc*/ void ClearCachedTweens();
            static /*0x3fb814c*/ int Validate();
            static /*0x3fb819c*/ void ManualUpdate(float deltaTime, float unscaledDeltaTime);
            static /*0x3fb8350*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration);
            static /*0x3fb83e8*/ DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, double endValue, float duration);
            static /*0x3fb8480*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, int endValue, float duration);
            static /*0x3fb8518*/ DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, uint endValue, float duration);
            static /*0x3fb85b0*/ DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, long endValue, float duration);
            static /*0x3fb8648*/ DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, ulong endValue, float duration);
            static /*0x3fb86e0*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, string endValue, float duration);
            static /*0x3fb8778*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fb8820*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x3fb88d0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, float duration);
            static /*0x3fb8990*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x3fb8a40*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration);
            static /*0x3fb8b00*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, float duration);
            static /*0x3fb8bc0*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, float duration);
            static /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration);
            static /*0x3fb8c58*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float endValue, float duration, DG.Tweening.AxisConstraint axisConstraint);
            static /*0x3fb8d0c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float endValue, float duration);
            static /*0x3fb8de0*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<float> setter, float startValue, float endValue, float duration);
            static /*0x3fb8f64*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, float duration, int vibrato, float elasticity);
            static /*0x3fb958c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, float strength, int vibrato, float randomness, bool ignoreZAxis, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb9e84*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb9654*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fb9354*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, float[] durations);
            static /*0x3fb9f50*/ DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, float duration);
            static /*0x3fba004*/ DG.Tweening.Sequence Sequence();
            static /*0x3fba160*/ DG.Tweening.Sequence Sequence(object target);
            static /*0x3fba1d0*/ int CompleteAll(bool withCallbacks);
            static /*0x3fba244*/ int Complete(object targetOrId, bool withCallbacks);
            static /*0x3fba2d0*/ int CompleteAndReturnKilledTot();
            static /*0x3fba33c*/ int CompleteAndReturnKilledTot(object targetOrId);
            static /*0x3fba3c0*/ int CompleteAndReturnKilledTot(object target, object id);
            static /*0x3fba44c*/ int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds);
            static /*0x3fba4bc*/ int FlipAll();
            static /*0x3fba528*/ int Flip(object targetOrId);
            static /*0x3fba5ac*/ int GotoAll(float to, bool andPlay);
            static /*0x3fba628*/ int Goto(object targetOrId, float to, bool andPlay);
            static /*0x3fba6c0*/ int KillAll(bool complete);
            static /*0x3fba754*/ int KillAll(bool complete, object[] idsOrTargetsToExclude);
            static /*0x3fba85c*/ int Kill(object targetOrId, bool complete);
            static /*0x3fba920*/ int Kill(object target, object id, bool complete);
            static /*0x3fba9f4*/ int PauseAll();
            static /*0x3fbaa60*/ int Pause(object targetOrId);
            static /*0x3fbaae4*/ int PlayAll();
            static /*0x3fbab50*/ int Play(object targetOrId);
            static /*0x3fbabd4*/ int Play(object target, object id);
            static /*0x3fbac60*/ int PlayBackwardsAll();
            static /*0x3fbaccc*/ int PlayBackwards(object targetOrId);
            static /*0x3fbad50*/ int PlayBackwards(object target, object id);
            static /*0x3fbaddc*/ int PlayForwardAll();
            static /*0x3fbae48*/ int PlayForward(object targetOrId);
            static /*0x3fbaecc*/ int PlayForward(object target, object id);
            static /*0x3fbaf58*/ int RestartAll(bool includeDelay);
            static /*0x3fbafc8*/ int Restart(object targetOrId, bool includeDelay, float changeDelayTo);
            static /*0x3fbb060*/ int Restart(object target, object id, bool includeDelay, float changeDelayTo);
            static /*0x3fbb10c*/ int RewindAll(bool includeDelay);
            static /*0x3fbb17c*/ int Rewind(object targetOrId, bool includeDelay);
            static /*0x3fbb204*/ int SmoothRewindAll();
            static /*0x3fbb270*/ int SmoothRewind(object targetOrId);
            static /*0x3fbb2f4*/ int TogglePauseAll();
            static /*0x3fbb360*/ int TogglePause(object targetOrId);
            static /*0x3fbb3e4*/ bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying);
            static /*0x3fbb46c*/ int TotalActiveTweens();
            static /*0x3fbb4c4*/ int TotalActiveTweeners();
            static /*0x3fbb51c*/ int TotalActiveSequences();
            static /*0x3fbb574*/ int TotalPlayingTweens();
            static /*0x3fbb5c4*/ int TotalTweensById(object id, bool playingOnly);
            static /*0x3fbb638*/ System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fbb6c8*/ System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fbb758*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fbb814*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x3fb8290*/ void InitCheck();
            static /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            /*0x3fbb8b8*/ DOTween();

            class <>c__DisplayClass67_0
            {
                /*0x10*/ float v;
                /*0x18*/ DG.Tweening.Core.DOSetter<float> setter;

                /*0x3fb8f5c*/ <>c__DisplayClass67_0();
                /*0x3fbba0c*/ float <To>b__0();
                /*0x3fbba14*/ void <To>b__1(float x);
            }
        }

        class DOVirtual
        {
            static /*0x3fbba3c*/ DG.Tweening.Tweener Float(float from, float to, float duration, DG.Tweening.TweenCallback<float> onVirtualUpdate);
            static /*0x3fbbc18*/ DG.Tweening.Tweener Int(int from, int to, float duration, DG.Tweening.TweenCallback<int> onVirtualUpdate);
            static /*0x3fbbdec*/ DG.Tweening.Tweener Vector2(UnityEngine.Vector2 from, UnityEngine.Vector2 to, float duration, DG.Tweening.TweenCallback<UnityEngine.Vector2> onVirtualUpdate);
            static /*0x3fbbfdc*/ DG.Tweening.Tweener Vector3(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float duration, DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate);
            static /*0x3fbc1e4*/ DG.Tweening.Tweener Color(UnityEngine.Color from, UnityEngine.Color to, float duration, DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate);
            static /*0x3fbc3f8*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0x3fbc494*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0x3fbc538*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0x3fbc57c*/ float EasedValue(float from, float to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0x3fbc694*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0x3fbc768*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0x3fbc844*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0x3fbc8b8*/ UnityEngine.Vector3 EasedValue(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0x3fbca08*/ DG.Tweening.Tween DelayedCall(float delay, DG.Tweening.TweenCallback callback, bool ignoreTimeScale);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ float val;
                /*0x18*/ DG.Tweening.TweenCallback<float> onVirtualUpdate;

                /*0x3fbbc10*/ <>c__DisplayClass0_0();
                /*0x3fbcb24*/ float <Float>b__0();
                /*0x3fbcb2c*/ void <Float>b__1(float x);
                /*0x3fbcb34*/ void <Float>b__2();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ int val;
                /*0x18*/ DG.Tweening.TweenCallback<int> onVirtualUpdate;

                /*0x3fbbde4*/ <>c__DisplayClass1_0();
                /*0x3fbcb5c*/ int <Int>b__0();
                /*0x3fbcb64*/ void <Int>b__1(int x);
                /*0x3fbcb6c*/ void <Int>b__2();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Vector2 val;
                /*0x18*/ DG.Tweening.TweenCallback<UnityEngine.Vector2> onVirtualUpdate;

                /*0x3fbbfd4*/ <>c__DisplayClass2_0();
                /*0x3fbcb94*/ UnityEngine.Vector2 <Vector2>b__0();
                /*0x3fbcb9c*/ void <Vector2>b__1(UnityEngine.Vector2 x);
                /*0x3fbcba4*/ void <Vector2>b__2();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Vector3 val;
                /*0x20*/ DG.Tweening.TweenCallback<UnityEngine.Vector3> onVirtualUpdate;

                /*0x3fbc1dc*/ <>c__DisplayClass3_0();
                /*0x3fbcbcc*/ UnityEngine.Vector3 <Vector3>b__0();
                /*0x3fbcbd8*/ void <Vector3>b__1(UnityEngine.Vector3 x);
                /*0x3fbcbe4*/ void <Vector3>b__2();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Color val;
                /*0x20*/ DG.Tweening.TweenCallback<UnityEngine.Color> onVirtualUpdate;

                /*0x3fbc3f0*/ <>c__DisplayClass4_0();
                /*0x3fbcc10*/ UnityEngine.Color <Color>b__0();
                /*0x3fbcc1c*/ void <Color>b__1(UnityEngine.Color x);
                /*0x3fbcc28*/ void <Color>b__2();
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
            static /*0x3fbcc54*/ DG.Tweening.EaseFunction StopMotion(int motionFps, System.Nullable<DG.Tweening.Ease> ease);
            static /*0x3fbcdd8*/ DG.Tweening.EaseFunction StopMotion(int motionFps, UnityEngine.AnimationCurve animCurve);
            static /*0x3fbcd0c*/ DG.Tweening.EaseFunction StopMotion(int motionFps, DG.Tweening.EaseFunction customEase);
            /*0x3fbce94*/ EaseFactory();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ float motionDelay;
                /*0x18*/ DG.Tweening.EaseFunction customEase;

                /*0x3fbce8c*/ <>c__DisplayClass2_0();
                /*0x3fbce9c*/ float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period);
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
            static /*0x3fbcf0c*/ void Complete(DG.Tweening.Tween t);
            static /*0x3fbcf14*/ void Complete(DG.Tweening.Tween t, bool withCallbacks);
            static /*0x3910ae8*/ T Done<T>(T t);
            static /*0x3fbd090*/ void Flip(DG.Tweening.Tween t);
            static /*0x3fbd1f8*/ void ForceInit(DG.Tweening.Tween t);
            static /*0x3fbd364*/ void Goto(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0x3fbd560*/ void GotoWithCallbacks(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0x3fbd370*/ void DoGoto(DG.Tweening.Tween t, float to, bool andPlay, bool withCallbacks);
            static /*0x3fbd56c*/ void Kill(DG.Tweening.Tween t, bool complete);
            static /*0x3fbd6e8*/ void ManualUpdate(DG.Tweening.Tween t, float deltaTime, float unscaledDeltaTime);
            static /*0x3910ae8*/ T Pause<T>(T t);
            static /*0x3910ae8*/ T Play<T>(T t);
            static /*0x3fbd87c*/ void PlayBackwards(DG.Tweening.Tween t);
            static /*0x3fbd9e4*/ void PlayForward(DG.Tweening.Tween t);
            static /*0x3fbdb4c*/ void Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
            static /*0x3fbdcdc*/ void Rewind(DG.Tweening.Tween t, bool includeDelay);
            static /*0x3fbde4c*/ void SmoothRewind(DG.Tweening.Tween t);
            static /*0x3fbdfb4*/ void TogglePause(DG.Tweening.Tween t);
            static /*0x3fbe11c*/ void GotoWaypoint(DG.Tweening.Tween t, int waypointIndex, bool andPlay);
            static /*0x3fbe4b0*/ UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t);
            static /*0x3fbe594*/ UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t);
            static /*0x3fbe678*/ UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t);
            static /*0x3fbe75c*/ UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x3fbe848*/ UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x3fbe940*/ UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t);
            static /*0x3fbea24*/ int CompletedLoops(DG.Tweening.Tween t);
            static /*0x3fbeaa0*/ float Delay(DG.Tweening.Tween t);
            static /*0x3fbeb28*/ float ElapsedDelay(DG.Tweening.Tween t);
            static /*0x3fbebb0*/ float Duration(DG.Tweening.Tween t, bool includeLoops);
            static /*0x3fbec64*/ float Elapsed(DG.Tweening.Tween t, bool includeLoops);
            static /*0x3fbed10*/ float ElapsedPercentage(DG.Tweening.Tween t, bool includeLoops);
            static /*0x3fbede0*/ float ElapsedDirectionalPercentage(DG.Tweening.Tween t);
            static /*0x3fbeeb8*/ bool IsActive(DG.Tweening.Tween t);
            static /*0x3fbeecc*/ bool IsBackwards(DG.Tweening.Tween t);
            static /*0x3fbef50*/ bool IsLoopingOrExecutingBackwards(DG.Tweening.Tween t);
            static /*0x3fbf014*/ bool IsComplete(DG.Tweening.Tween t);
            static /*0x3fbf098*/ bool IsInitialized(DG.Tweening.Tween t);
            static /*0x3fbf11c*/ bool IsPlaying(DG.Tweening.Tween t);
            static /*0x3fbf1a0*/ int Loops(DG.Tweening.Tween t);
            static /*0x3fbf21c*/ UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, float pathPercentage);
            static /*0x3fbf4b0*/ UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, int subdivisionsXSegment);
            static /*0x3fbf6f0*/ float PathLength(DG.Tweening.Tween t);
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

            static /*0x3fbfa6c*/ DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t);
            static /*0x3fbfb8c*/ DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, float atPosition);
            static /*0x3fbfdcc*/ DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x3fbfdf0*/ DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x3fbfec4*/ DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, float atPosition);
            static /*0x3fba08c*/ void Setup(DG.Tweening.Sequence s);
            static /*0x3fc02ac*/ bool DoStartup(DG.Tweening.Sequence s);
            static /*0x3fc04fc*/ bool DoApplyTween(DG.Tweening.Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x3fc09d0*/ bool ApplyInternalCycle(DG.Tweening.Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep);
            static /*0x3fc08a4*/ void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list);
            static /*0x3fc0844*/ bool IsAnyCallbackSet(DG.Tweening.Sequence s);
            /*0x3fbf93c*/ Sequence();
            /*0x3fbffd0*/ float UpdateDelay(float elapsed);
            /*0x3fbfffc*/ void Reset();
            /*0x3fc01ec*/ bool Validate();
            /*0x3fc02a8*/ bool Startup();
            /*0x3fc04f4*/ bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class ShortcutExtensions
        {
            static /*0x3fc12dc*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fc1464*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, float duration);
            static /*0x3fc1614*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fc179c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fc1924*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fc1aac*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, float endValue, float duration);
            static /*0x3fc1c34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x3fc1de4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x3fc1f94*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc21fc*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc247c*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc26e4*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc2964*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x3fc2b14*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, float endValue, float duration);
            static /*0x3fc2c9c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, float endValue, float duration);
            static /*0x3fc2e24*/ DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, float duration);
            static /*0x3fc2fd4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x3fc3184*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x3fc33a4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x3fc35b4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, float duration);
            static /*0x3fc373c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x3fc3934*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x3fc3b1c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x3fc3d14*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x3fc3efc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fc4094*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x3fc429c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fc4434*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x3fc463c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, string property, float duration);
            static /*0x3fc485c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, int propertyID, float duration);
            static /*0x3fc4a6c*/ DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, float toStartWidth, float toEndWidth, float duration);
            static /*0x3fc4bf8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, float endValue, float duration);
            static /*0x3fc4d80*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fc4f54*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fc5124*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fc52d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fc548c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fc5648*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fc57fc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fc59b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x3fc5b64*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fc5d18*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x3fc5efc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fc60b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x3fc6294*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration);
            static /*0x3fc6434*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fc65c4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fc6770*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fc691c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, float endValue, float duration);
            static /*0x3fc6ac8*/ DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fc6d50*/ DG.Tweening.Tweener DODynamicLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fc6ad0*/ DG.Tweening.Tweener LookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up, bool dynamic);
            static /*0x3fc6d60*/ DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x3fc6fc8*/ DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x3fc720c*/ DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x3fc7450*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc76c4*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc794c*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc7bb4*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc7e34*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc8100*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fc8380*/ DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fc8900*/ DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fc8df8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fc901c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fc9248*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fc9408*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fc95d0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, float endValue, float duration);
            static /*0x3fc9758*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x3fc9954*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x3fc9b50*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x3fc9dc0*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x3fca020*/ DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x3fca228*/ DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x3fca430*/ DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fca630*/ DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fca830*/ DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x3fcaad0*/ DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration);
            static /*0x3fcacc0*/ int DOComplete(UnityEngine.Component target, bool withCallbacks);
            static /*0x3fcad24*/ int DOComplete(UnityEngine.Material target, bool withCallbacks);
            static /*0x3fcad88*/ int DOKill(UnityEngine.Component target, bool complete);
            static /*0x3fcadec*/ int DOKill(UnityEngine.Material target, bool complete);
            static /*0x3fcae50*/ int DOFlip(UnityEngine.Component target);
            static /*0x3fcaea4*/ int DOFlip(UnityEngine.Material target);
            static /*0x3fcaef8*/ int DOGoto(UnityEngine.Component target, float to, bool andPlay);
            static /*0x3fcaf6c*/ int DOGoto(UnityEngine.Material target, float to, bool andPlay);
            static /*0x3fcafe0*/ int DOPause(UnityEngine.Component target);
            static /*0x3fcb034*/ int DOPause(UnityEngine.Material target);
            static /*0x3fcb088*/ int DOPlay(UnityEngine.Component target);
            static /*0x3fcb0dc*/ int DOPlay(UnityEngine.Material target);
            static /*0x3fcb130*/ int DOPlayBackwards(UnityEngine.Component target);
            static /*0x3fcb184*/ int DOPlayBackwards(UnityEngine.Material target);
            static /*0x3fcb1d8*/ int DOPlayForward(UnityEngine.Component target);
            static /*0x3fcb22c*/ int DOPlayForward(UnityEngine.Material target);
            static /*0x3fcb280*/ int DORestart(UnityEngine.Component target, bool includeDelay);
            static /*0x3fcb2e8*/ int DORestart(UnityEngine.Material target, bool includeDelay);
            static /*0x3fcb350*/ int DORewind(UnityEngine.Component target, bool includeDelay);
            static /*0x3fcb3b4*/ int DORewind(UnityEngine.Material target, bool includeDelay);
            static /*0x3fcb418*/ int DOSmoothRewind(UnityEngine.Component target);
            static /*0x3fcb46c*/ int DOSmoothRewind(UnityEngine.Material target);
            static /*0x3fcb4c0*/ int DOTogglePause(UnityEngine.Component target);
            static /*0x3fcb514*/ int DOTogglePause(UnityEngine.Material target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc145c*/ <>c__DisplayClass0_0();
                /*0x3fcb568*/ float <DOAspect>b__0();
                /*0x3fcb584*/ void <DOAspect>b__1(float x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc26dc*/ <>c__DisplayClass10_0();
                /*0x3fcb5a0*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fcb5c8*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc295c*/ <>c__DisplayClass11_0();
                /*0x3fcb630*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fcb658*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x3fc2b0c*/ <>c__DisplayClass12_0();
                /*0x3fcb6c0*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcb6dc*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x3fc2c94*/ <>c__DisplayClass13_0();
                /*0x3fcb6f8*/ float <DOIntensity>b__0();
                /*0x3fcb714*/ void <DOIntensity>b__1(float x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x3fc2e1c*/ <>c__DisplayClass14_0();
                /*0x3fcb730*/ float <DOShadowStrength>b__0();
                /*0x3fcb74c*/ void <DOShadowStrength>b__1(float x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ DG.Tweening.Color2 startValue;
                /*0x30*/ UnityEngine.LineRenderer target;

                /*0x3fc2fcc*/ <>c__DisplayClass15_0();
                /*0x3fcb768*/ DG.Tweening.Color2 <DOColor>b__0();
                /*0x3fcb774*/ void <DOColor>b__1(DG.Tweening.Color2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fc317c*/ <>c__DisplayClass16_0();
                /*0x3fcb7c0*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcb7dc*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fc339c*/ <>c__DisplayClass17_0();
                /*0x3fcb7f8*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcb81c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fc35ac*/ <>c__DisplayClass18_0();
                /*0x3fcb840*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcb864*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fc3734*/ <>c__DisplayClass19_0();
                /*0x3fcb888*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fcb8a4*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc160c*/ <>c__DisplayClass1_0();
                /*0x3fcb8c0*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcb8dc*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fc392c*/ <>c__DisplayClass20_0();
                /*0x3fcb8f8*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fcb91c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fc3b14*/ <>c__DisplayClass21_0();
                /*0x3fcb940*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fcb964*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fc3d0c*/ <>c__DisplayClass22_0();
                /*0x3fcb988*/ float <DOFloat>b__0();
                /*0x3fcb9ac*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fc3ef4*/ <>c__DisplayClass23_0();
                /*0x3fcb9d0*/ float <DOFloat>b__0();
                /*0x3fcb9f4*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fc408c*/ <>c__DisplayClass24_0();
                /*0x3fcba18*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x3fcba34*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fc4294*/ <>c__DisplayClass25_0();
                /*0x3fcba50*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x3fcba74*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x3fc442c*/ <>c__DisplayClass26_0();
                /*0x3fcba98*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x3fcbab4*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fc4634*/ <>c__DisplayClass27_0();
                /*0x3fcbad0*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x3fcbaf4*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x3fc4854*/ <>c__DisplayClass28_0();
                /*0x3fcbb18*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x3fcbb3c*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fc4a64*/ <>c__DisplayClass29_0();
                /*0x3fcbb60*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x3fcbb84*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc1794*/ <>c__DisplayClass2_0();
                /*0x3fcbba8*/ float <DOFarClipPlane>b__0();
                /*0x3fcbbc4*/ void <DOFarClipPlane>b__1(float x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x3fc4bf0*/ <>c__DisplayClass30_0();
                /*0x3fcbbe0*/ UnityEngine.Vector2 <DOResize>b__0();
                /*0x3fcbc28*/ void <DOResize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x3fc4d78*/ <>c__DisplayClass31_0();
                /*0x3fcbc68*/ float <DOTime>b__0();
                /*0x3fcbc84*/ void <DOTime>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc4f34*/ <>c__DisplayClass32_0();
                /*0x3fcbca0*/ UnityEngine.Vector3 <DOMove>b__0();
                /*0x3fcbcbc*/ void <DOMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc5100*/ <>c__DisplayClass33_0();
                /*0x3fcbcd8*/ UnityEngine.Vector3 <DOMoveX>b__0();
                /*0x3fcbcf4*/ void <DOMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc52d0*/ <>c__DisplayClass34_0();
                /*0x3fcbd10*/ UnityEngine.Vector3 <DOMoveY>b__0();
                /*0x3fcbd2c*/ void <DOMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc5484*/ <>c__DisplayClass35_0();
                /*0x3fcbd48*/ UnityEngine.Vector3 <DOMoveZ>b__0();
                /*0x3fcbd64*/ void <DOMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc5640*/ <>c__DisplayClass36_0();
                /*0x3fcbd80*/ UnityEngine.Vector3 <DOLocalMove>b__0();
                /*0x3fcbd9c*/ void <DOLocalMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc57f4*/ <>c__DisplayClass37_0();
                /*0x3fcbdb8*/ UnityEngine.Vector3 <DOLocalMoveX>b__0();
                /*0x3fcbdd4*/ void <DOLocalMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc59a8*/ <>c__DisplayClass38_0();
                /*0x3fcbdf0*/ UnityEngine.Vector3 <DOLocalMoveY>b__0();
                /*0x3fcbe0c*/ void <DOLocalMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc5b5c*/ <>c__DisplayClass39_0();
                /*0x3fcbe28*/ UnityEngine.Vector3 <DOLocalMoveZ>b__0();
                /*0x3fcbe44*/ void <DOLocalMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc191c*/ <>c__DisplayClass3_0();
                /*0x3fcbe60*/ float <DOFieldOfView>b__0();
                /*0x3fcbe7c*/ void <DOFieldOfView>b__1(float x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc5d10*/ <>c__DisplayClass40_0();
                /*0x3fcbe98*/ UnityEngine.Quaternion <DORotate>b__0();
                /*0x3fcbeb4*/ void <DORotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc5ef4*/ <>c__DisplayClass41_0();
                /*0x3fcbed0*/ UnityEngine.Quaternion <DORotateQuaternion>b__0();
                /*0x3fcbeec*/ void <DORotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass42_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc60a8*/ <>c__DisplayClass42_0();
                /*0x3fcbf08*/ UnityEngine.Quaternion <DOLocalRotate>b__0();
                /*0x3fcbf24*/ void <DOLocalRotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc628c*/ <>c__DisplayClass43_0();
                /*0x3fcbf40*/ UnityEngine.Quaternion <DOLocalRotateQuaternion>b__0();
                /*0x3fcbf5c*/ void <DOLocalRotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass44_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc642c*/ <>c__DisplayClass44_0();
                /*0x3fcbf78*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x3fcbf94*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc65bc*/ <>c__DisplayClass45_0();
                /*0x3fcbfb0*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x3fcbfcc*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass46_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc6768*/ <>c__DisplayClass46_0();
                /*0x3fcbfe8*/ UnityEngine.Vector3 <DOScaleX>b__0();
                /*0x3fcc004*/ void <DOScaleX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc6914*/ <>c__DisplayClass47_0();
                /*0x3fcc020*/ UnityEngine.Vector3 <DOScaleY>b__0();
                /*0x3fcc03c*/ void <DOScaleY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc6ac0*/ <>c__DisplayClass48_0();
                /*0x3fcc058*/ UnityEngine.Vector3 <DOScaleZ>b__0();
                /*0x3fcc074*/ void <DOScaleZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc1aa4*/ <>c__DisplayClass4_0();
                /*0x3fcc090*/ float <DONearClipPlane>b__0();
                /*0x3fcc0ac*/ void <DONearClipPlane>b__1(float x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc6d58*/ <>c__DisplayClass51_0();
                /*0x3fcc0c8*/ UnityEngine.Quaternion <LookAt>b__0();
                /*0x3fcc0e4*/ void <LookAt>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc6fa8*/ <>c__DisplayClass52_0();
                /*0x3fcc100*/ UnityEngine.Vector3 <DOPunchPosition>b__0();
                /*0x3fcc11c*/ void <DOPunchPosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc7204*/ <>c__DisplayClass53_0();
                /*0x3fcc138*/ UnityEngine.Vector3 <DOPunchScale>b__0();
                /*0x3fcc154*/ void <DOPunchScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass54_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc7448*/ <>c__DisplayClass54_0();
                /*0x3fcc170*/ UnityEngine.Vector3 <DOPunchRotation>b__0();
                /*0x3fcc18c*/ void <DOPunchRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass55_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc76bc*/ <>c__DisplayClass55_0();
                /*0x3fcc1c8*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fcc1e4*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc7944*/ <>c__DisplayClass56_0();
                /*0x3fcc200*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fcc21c*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass57_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc7bac*/ <>c__DisplayClass57_0();
                /*0x3fcc238*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fcc254*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc7e2c*/ <>c__DisplayClass58_0();
                /*0x3fcc290*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x3fcc2ac*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc80f8*/ <>c__DisplayClass59_0();
                /*0x3fcc2e8*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x3fcc304*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc1c2c*/ <>c__DisplayClass5_0();
                /*0x3fcc320*/ float <DOOrthoSize>b__0();
                /*0x3fcc33c*/ void <DOOrthoSize>b__1(float x);
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc8378*/ <>c__DisplayClass60_0();
                /*0x3fcc358*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x3fcc374*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
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

                /*0x3fc8870*/ <>c__DisplayClass61_0();
                /*0x3fcc390*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x3fcc3ac*/ void <DOJump>b__1(UnityEngine.Vector3 x);
                /*0x3fcc3c8*/ void <DOJump>b__2();
                /*0x3fcc3f0*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x3fcc40c*/ void <DOJump>b__4(UnityEngine.Vector3 x);
                /*0x3fcc428*/ UnityEngine.Vector3 <DOJump>b__5();
                /*0x3fcc444*/ void <DOJump>b__6(UnityEngine.Vector3 x);
                /*0x3fcc460*/ void <DOJump>b__7();
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

                /*0x3fc8df0*/ <>c__DisplayClass62_0();
                /*0x3fcc50c*/ UnityEngine.Vector3 <DOLocalJump>b__0();
                /*0x3fcc528*/ void <DOLocalJump>b__1(UnityEngine.Vector3 x);
                /*0x3fcc544*/ void <DOLocalJump>b__2();
                /*0x3fcc56c*/ UnityEngine.Vector3 <DOLocalJump>b__3();
                /*0x3fcc588*/ void <DOLocalJump>b__4(UnityEngine.Vector3 x);
                /*0x3fcc5a4*/ UnityEngine.Vector3 <DOLocalJump>b__5();
                /*0x3fcc5c0*/ void <DOLocalJump>b__6(UnityEngine.Vector3 x);
                /*0x3fcc5dc*/ void <DOLocalJump>b__7();
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc9014*/ <>c__DisplayClass63_0();
                /*0x3fcc688*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fcc6a4*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc9240*/ <>c__DisplayClass64_0();
                /*0x3fcc6c0*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fcc6dc*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc9400*/ <>c__DisplayClass65_0();
                /*0x3fcc6f8*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fcc714*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x3fc95c8*/ <>c__DisplayClass66_0();
                /*0x3fcc730*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fcc74c*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ DG.Tweening.Tween target;

                /*0x3fc9750*/ <>c__DisplayClass67_0();
                /*0x3fcc768*/ float <DOTimeScale>b__0();
                /*0x3fcc784*/ void <DOTimeScale>b__1(float x);
            }

            class <>c__DisplayClass68_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Light target;

                /*0x3fc994c*/ <>c__DisplayClass68_0();
                /*0x3fcc7a0*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcc7ac*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass69_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;

                /*0x3fc9b48*/ <>c__DisplayClass69_0();
                /*0x3fcc818*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcc824*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc1ddc*/ <>c__DisplayClass6_0();
                /*0x3fcc890*/ UnityEngine.Rect <DOPixelRect>b__0();
                /*0x3fcc8ac*/ void <DOPixelRect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ string property;

                /*0x3fc9db8*/ <>c__DisplayClass70_0();
                /*0x3fcc8c8*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcc8d4*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass71_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ int propertyID;

                /*0x3fca018*/ <>c__DisplayClass71_0();
                /*0x3fcc954*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcc960*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fca220*/ <>c__DisplayClass72_0();
                /*0x3fcc9e0*/ UnityEngine.Vector3 <DOBlendableMoveBy>b__0();
                /*0x3fcc9ec*/ void <DOBlendableMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass73_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fca428*/ <>c__DisplayClass73_0();
                /*0x3fcca50*/ UnityEngine.Vector3 <DOBlendableLocalMoveBy>b__0();
                /*0x3fcca5c*/ void <DOBlendableLocalMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass74_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fca628*/ <>c__DisplayClass74_0();
                /*0x3fccac0*/ UnityEngine.Quaternion <DOBlendableRotateBy>b__0();
                /*0x3fccacc*/ void <DOBlendableRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass75_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fca828*/ <>c__DisplayClass75_0();
                /*0x3fccd48*/ UnityEngine.Quaternion <DOBlendableLocalRotateBy>b__0();
                /*0x3fccd54*/ void <DOBlendableLocalRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass76_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fcaac8*/ <>c__DisplayClass76_0();
                /*0x3fccfd0*/ UnityEngine.Vector3 <DOBlendablePunchRotation>b__0();
                /*0x3fccfdc*/ void <DOBlendablePunchRotation>b__1(UnityEngine.Vector3 v);
            }

            class <>c__DisplayClass77_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x3fcacb8*/ <>c__DisplayClass77_0();
                /*0x3fcd2a8*/ UnityEngine.Vector3 <DOBlendableScaleBy>b__0();
                /*0x3fcd2b4*/ void <DOBlendableScaleBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc1f8c*/ <>c__DisplayClass7_0();
                /*0x3fcd318*/ UnityEngine.Rect <DORect>b__0();
                /*0x3fcd334*/ void <DORect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc21f4*/ <>c__DisplayClass8_0();
                /*0x3fcd350*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fcd378*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x3fc2474*/ <>c__DisplayClass9_0();
                /*0x3fcd3c8*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x3fcd3f0*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
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

            static /*0x3fcda64*/ TweenParams();
            /*0x3fcd440*/ TweenParams();
            /*0x3fcd464*/ DG.Tweening.TweenParams Clear();
            /*0x3fcd5e0*/ DG.Tweening.TweenParams SetAutoKill(bool autoKillOnCompletion);
            /*0x3fcd5ec*/ DG.Tweening.TweenParams SetId(object objectId);
            /*0x3fcd608*/ DG.Tweening.TweenParams SetId(string stringId);
            /*0x3fcd624*/ DG.Tweening.TweenParams SetId(int intId);
            /*0x3fcd62c*/ DG.Tweening.TweenParams SetTarget(object target);
            /*0x3fcd648*/ DG.Tweening.TweenParams SetLoops(int loops, System.Nullable<DG.Tweening.LoopType> loopType);
            /*0x3fcd6d8*/ DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<float> overshootOrAmplitude, System.Nullable<float> period);
            /*0x3fcd7e4*/ DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve);
            /*0x3fcd8ac*/ DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase);
            /*0x3fcd8d0*/ DG.Tweening.TweenParams SetRecyclable(bool recyclable);
            /*0x3fcd8dc*/ DG.Tweening.TweenParams SetUpdate(bool isIndependentUpdate);
            /*0x3fcd954*/ DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            /*0x3fcd964*/ DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action);
            /*0x3fcd980*/ DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action);
            /*0x3fcd99c*/ DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action);
            /*0x3fcd9b8*/ DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action);
            /*0x3fcd9d4*/ DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action);
            /*0x3fcd9f0*/ DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action);
            /*0x3fcda0c*/ DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action);
            /*0x3fcda28*/ DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<int> action);
            /*0x3fcda44*/ DG.Tweening.TweenParams SetDelay(float delay);
            /*0x3fcda4c*/ DG.Tweening.TweenParams SetRelative(bool isRelative);
            /*0x3fcda58*/ DG.Tweening.TweenParams SetSpeedBased(bool isSpeedBased);
        }

        class TweenSettingsExtensions
        {
            static /*0x3910ae8*/ T SetAutoKill<T>(T t);
            static /*0x3910ae8*/ T SetAutoKill<T>(T t, bool autoKillOnCompletion);
            static /*0x3910ae8*/ T SetId<T>(T t, object objectId);
            static /*0x3910ae8*/ T SetId<T>(T t, string stringId);
            static /*0x3910ae8*/ T SetId<T>(T t, int intId);
            static /*0x3910ae8*/ T SetLink<T>(T t, UnityEngine.GameObject gameObject);
            static /*0x3910ae8*/ T SetLink<T>(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour);
            static /*0x3910ae8*/ T SetTarget<T>(T t, object target);
            static /*0x3910ae8*/ T SetLoops<T>(T t, int loops);
            static /*0x3910ae8*/ T SetLoops<T>(T t, int loops, DG.Tweening.LoopType loopType);
            static /*0x3910ae8*/ T SetEase<T>(T t, DG.Tweening.Ease ease);
            static /*0x3910ae8*/ T SetEase<T>(T t, DG.Tweening.Ease ease, float overshoot);
            static /*0x3910ae8*/ T SetEase<T>(T t, DG.Tweening.Ease ease, float amplitude, float period);
            static /*0x3910ae8*/ T SetEase<T>(T t, UnityEngine.AnimationCurve animCurve);
            static /*0x3910ae8*/ T SetEase<T>(T t, DG.Tweening.EaseFunction customEase);
            static /*0x3910ae8*/ T SetRecyclable<T>(T t);
            static /*0x3910ae8*/ T SetRecyclable<T>(T t, bool recyclable);
            static /*0x3910ae8*/ T SetUpdate<T>(T t, bool isIndependentUpdate);
            static /*0x3910ae8*/ T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType);
            static /*0x3910ae8*/ T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            static /*0x3910ae8*/ T SetInverted<T>(T t);
            static /*0x3910ae8*/ T SetInverted<T>(T t, bool inverted);
            static /*0x3910ae8*/ T OnStart<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnPlay<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnPause<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnRewind<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnUpdate<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnStepComplete<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnComplete<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnKill<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x3910ae8*/ T OnWaypointChange<T>(T t, DG.Tweening.TweenCallback<int> action);
            static /*0x3910ae8*/ T SetAs<T>(T t, DG.Tweening.Tween asTween);
            static /*0x3910ae8*/ T SetAs<T>(T t, DG.Tweening.TweenParams tweenParams);
            static /*0x3fc8878*/ DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x3fcdb68*/ DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x3fc88bc*/ DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x3fcdba0*/ DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t);
            static /*0x3fbcadc*/ DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, float interval);
            static /*0x3fcdbe8*/ DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, float interval);
            static /*0x3fcdc24*/ DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x3fcdc70*/ DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x3fcdcb4*/ DG.Tweening.Sequence JoinCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x3fcdd00*/ DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, float atPosition, DG.Tweening.TweenCallback callback);
            static /*0x3fcdadc*/ bool ValidateAddToSequence(DG.Tweening.Sequence s, DG.Tweening.Tween t, bool ignoreTween);
            static /*0x3910ae8*/ T From<T>(T t);
            static /*0x3910ae8*/ T From<T>(T t, bool isRelative);
            static /*0x3910ae8*/ T From<T>(T t, bool setImmediately, bool isRelative);
            static /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
            static /*0x3fcdd50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, float fromAlphaValue, bool setImmediately, bool isRelative);
            static /*0x3fcddf8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, float fromValue, bool setImmediately, bool isRelative);
            static /*0x3fcde9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, float fromValueDegrees, bool setImmediately, bool isRelative);
            static /*0x3910ae8*/ T SetDelay<T>(T t, float delay);
            static /*0x3910ae8*/ T SetDelay<T>(T t, float delay, bool asPrependedIntervalIfSequence);
            static /*0x3910ae8*/ T SetRelative<T>(T t);
            static /*0x3910ae8*/ T SetRelative<T>(T t, bool isRelative);
            static /*0x3910ae8*/ T SetSpeedBased<T>(T t);
            static /*0x3910ae8*/ T SetSpeedBased<T>(T t, bool isSpeedBased);
            static /*0x3fcdf3c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool snapping);
            static /*0x3fcdf54*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x3fcdf6c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fc4f3c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x3fc5108*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fcdf88*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x3fcdfa0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fcdfbc*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool useShortest360Route);
            static /*0x3fb8dc8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool alphaOnly);
            static /*0x3fcdfd8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool snapping);
            static /*0x3fcdff0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x3fc6fb0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool snapping);
            static /*0x3fce0d8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x3fce0f4*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, float endValueDegrees, bool relativeCenter, bool snapping);
            static /*0x3fce11c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x3fce138*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x3fce158*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fce270*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, bool stableZRotation);
            static /*0x3fce2a8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fce34c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, bool stableZRotation);
            static /*0x3fce3dc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fce488*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, bool stableZRotation);
            static /*0x3fce190*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Options.OrientType orientType, UnityEngine.Vector3 lookAtPosition, UnityEngine.Transform lookAtTransform, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up, bool stableZRotation);
            static /*0x3fce518*/ void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
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

            static /*0x3fce8b0*/ bool DoGoto(DG.Tweening.Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x3fc1114*/ bool OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t);
            static /*0x3910ae8*/ bool OnTweenCallback<T>(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param);
            /*0x3fbfa48*/ Tween();
            /*0x3fce848*/ bool get_isRelative();
            /*0x3fce850*/ void set_isRelative(bool value);
            /*0x3fce85c*/ bool get_active();
            /*0x3fce864*/ void set_active(bool value);
            /*0x3fce870*/ float get_fullPosition();
            /*0x3fce878*/ void set_fullPosition(float value);
            /*0x3fbe494*/ bool get_hasLoops();
            /*0x3fce884*/ bool get_playedOnce();
            /*0x3fce88c*/ void set_playedOnce(bool value);
            /*0x3fce898*/ float get_position();
            /*0x3fce8a0*/ void set_position(float value);
            /*0x3fc00a8*/ void Reset();
            /*0x3813ffc*/ bool Validate();
            /*0x3fce8a8*/ float UpdateDelay(float elapsed);
            /*0x3813ffc*/ bool Startup();
            bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class Tweener : DG.Tweening.Tween
        {
            /*0x120*/ bool hasManuallySetStartValue;
            /*0x121*/ bool isFromAllowed;

            static /*0x3910ae8*/ bool Setup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            static /*0x383c0b0*/ float DoUpdateDelay<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, float elapsed);
            static /*0x3823ae0*/ bool DoStartup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration);
            static /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue);
            static /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration);
            static /*0x3823ae0*/ bool DOStartupSpecials<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static /*0x3840c74*/ void DOStartupDurationBased<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            /*0x3fcec1c*/ Tweener();
            /*0x3814ff0*/ DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
            DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
            /*0x3814a74*/ DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
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

                /*0x3fcec44*/ void Reset();
                /*0x3fcec58*/ void Initialize(UnityEngine.Vector2 startValue, UnityEngine.Vector2 endValue);
            }

            class CirclePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions>
            {
                static /*0x3fcf064*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> Get();
                /*0x3fcf240*/ CirclePlugin();
                /*0x3fced24*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0x3fced28*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, bool isRelative);
                /*0x3fcef6c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0x3fcf0a4*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t, UnityEngine.Vector2 value);
                /*0x3fcf0a8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0x3fcf0f0*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> t);
                /*0x3fcf13c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.CircleOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0x3fcf144*/ void EvaluateAndApply(DG.Tweening.Plugins.CircleOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fcede0*/ UnityEngine.Vector2 GetPositionOnCircle(DG.Tweening.Plugins.CircleOptions options, float degrees);
            }

            class Color2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x3fdcb74*/ Color2Plugin();
                /*0x3fdc2ac*/ void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fdc2b0*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x3fdc4b0*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, bool setImmediately, bool isRelative);
                /*0x3fdc68c*/ DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value);
                /*0x3fdc698*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fdc6ec*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fdc748*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, DG.Tweening.Color2 changeValue);
                /*0x3fdc754*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, float elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class DoublePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<double, double, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fdcdf8*/ DoublePlugin();
                /*0x3fdcbbc*/ void Reset(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdcbc0*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fdcc30*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double fromValue, bool setImmediately, bool isRelative);
                /*0x3fdccc4*/ double ConvertToStartValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double value);
                /*0x3fdccc8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdcce8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdcd08*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, double changeValue);
                /*0x3fdcd20*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class LongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<long, long, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fdd148*/ LongPlugin();
                /*0x3fdce40*/ void Reset(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdce44*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fdcea8*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long fromValue, bool setImmediately, bool isRelative);
                /*0x3fdcf30*/ long ConvertToStartValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long value);
                /*0x3fdcf38*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdcf58*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdcf78*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, long changeValue);
                /*0x3fdcf90*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UlongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fdd464*/ UlongPlugin();
                /*0x3fdd190*/ void Reset(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdd194*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fdd1f8*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative);
                /*0x3fdd280*/ ulong ConvertToStartValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong value);
                /*0x3fdd288*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdd2a8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fdd2c8*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, ulong changeValue);
                /*0x3fdd2e4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3ArrayPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>
            {
                /*0x3fde0f0*/ Vector3ArrayPlugin();
                /*0x3fdd4ac*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x3fdd4f0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool isRelative);
                /*0x3fdd4f4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, bool setImmediately, bool isRelative);
                /*0x3fdd4f8*/ UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value);
                /*0x3fdd5f8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x3fdd6e0*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x3fdd7e0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, float unitsXSecond, UnityEngine.Vector3[] changeValue);
                /*0x3fdd8f0*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class PathPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>
            {
                static float MinLookAhead = 0.00009999999747378752;

                static /*0x3fde2f8*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> Get();
                /*0x3fdfc98*/ PathPlugin();
                /*0x3fde138*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x3fde2f0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool isRelative);
                /*0x3fde2f4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, bool setImmediately, bool isRelative);
                /*0x3fde338*/ DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value);
                /*0x3fde350*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x3fde408*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x3fde930*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, float unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue);
                /*0x3fde94c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fdf290*/ void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, float pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fdfc78*/ UnityEngine.Vector3 DivideVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector);
                /*0x3fdfc88*/ UnityEngine.Vector3 MultiplyVectorByVector(UnityEngine.Vector3 vector, UnityEngine.Vector3 byVector);
            }

            class ColorPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x3fe00c0*/ ColorPlugin();
                /*0x3fdfce0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fdfce4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x3fdfdc0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative);
                /*0x3fdfecc*/ UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value);
                /*0x3fdfed0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fdfef4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x3fdff18*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue);
                /*0x3fdff24*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class IntPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<int, int, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x3fe0414*/ IntPlugin();
                /*0x3fe0108*/ void Reset(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fe010c*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fe0174*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int fromValue, bool setImmediately, bool isRelative);
                /*0x3fe01fc*/ int ConvertToStartValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int value);
                /*0x3fe0204*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fe0228*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fe024c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, int changeValue);
                /*0x3fe0264*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class QuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>
            {
                /*0x3fe14e8*/ QuaternionPlugin();
                /*0x3fe045c*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x3fe0460*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool isRelative);
                /*0x3fe0ac0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0x3fe0bec*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value);
                /*0x3fe0c18*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x3fe0c50*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x3fe0e18*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x3fe0e98*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fe0830*/ UnityEngine.Vector3 GetEulerValForCalculations(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 val, UnityEngine.Vector3 counterVal);
                /*0x3fe14d0*/ UnityEngine.Vector3 FlipEulerAngles(UnityEngine.Vector3 euler);
            }

            class RectOffsetPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ UnityEngine.RectOffset _r;

                static /*0x3fe2460*/ RectOffsetPlugin();
                /*0x3fe2418*/ RectOffsetPlugin();
                /*0x3fe1530*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fe1574*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fe16f0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, bool setImmediately, bool isRelative);
                /*0x3fe1918*/ UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value);
                /*0x3fe19d4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fe1ae0*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fe1c38*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.RectOffset changeValue);
                /*0x3fe1cf4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, float elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>
            {
                /*0x3fe2f6c*/ RectPlugin();
                /*0x3fe24dc*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x3fe24e0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool isRelative);
                /*0x3fe27dc*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, bool setImmediately, bool isRelative);
                /*0x3fe2af0*/ UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value);
                /*0x3fe2af4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x3fe2b18*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x3fe2b3c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, float unitsXSecond, UnityEngine.Rect changeValue);
                /*0x3fe2bb8*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, float elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UintPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<uint, uint, DG.Tweening.Plugins.Options.UintOptions>
            {
                /*0x3fe3300*/ UintPlugin();
                /*0x3fe2fb4*/ void Reset(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x3fe2fb8*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, bool isRelative);
                /*0x3fe3020*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint fromValue, bool setImmediately, bool isRelative);
                /*0x3fe30a8*/ uint ConvertToStartValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint value);
                /*0x3fe30b0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x3fe30d4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x3fe3108*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, float unitsXSecond, uint changeValue);
                /*0x3fe3120*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x3fe3c4c*/ Vector2Plugin();
                /*0x3fe3348*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe334c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x3fe3520*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0x3fe3764*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value);
                /*0x3fe3768*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe378c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe37f4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0x3fe3868*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector4Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x3fe4c50*/ Vector4Plugin();
                /*0x3fe3c94*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe3c98*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x3fe3fb8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, bool setImmediately, bool isRelative);
                /*0x3fe4388*/ UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value);
                /*0x3fe438c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe43b0*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe4498*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector4 changeValue);
                /*0x3fe452c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, float elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class StringPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<string, string, DG.Tweening.Plugins.Options.StringOptions>
            {
                static /*0x0*/ System.Text.StringBuilder _Buffer;
                static /*0x8*/ System.Collections.Generic.List<char> _OpenedTags;

                static /*0x3fe5f18*/ StringPlugin();
                /*0x3fe5ed0*/ StringPlugin();
                /*0x3fe4c98*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool isRelative);
                /*0x3fe4d14*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string fromValue, bool setImmediately, bool isRelative);
                /*0x3fe4dfc*/ void Reset(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x3fe4e74*/ string ConvertToStartValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string value);
                /*0x3fe4e7c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x3fe4e80*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x3fe5108*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, float unitsXSecond, string changeValue);
                /*0x3fe5148*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x3fe55e0*/ System.Text.StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled);
                /*0x3fe5ca4*/ char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options);
            }

            class StringPluginExtensions
            {
                static /*0x0*/ char[] ScrambledCharsAll;
                static /*0x8*/ char[] ScrambledCharsUppercase;
                static /*0x10*/ char[] ScrambledCharsLowercase;
                static /*0x18*/ char[] ScrambledCharsNumerals;
                static /*0x20*/ int _lastRndSeed;

                static /*0x3fe5fec*/ StringPluginExtensions();
                static /*0x3fe61a0*/ void ScrambleChars(char[] chars);
                static /*0x3fe5da8*/ System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, int length, char[] chars);
            }

            class FloatPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<float, float, DG.Tweening.Plugins.Options.FloatOptions>
            {
                /*0x3fe66dc*/ FloatPlugin();
                /*0x3fe6240*/ void Reset(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x3fe6244*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool isRelative);
                /*0x3fe6370*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float fromValue, bool setImmediately, bool isRelative);
                /*0x3fe64c4*/ float ConvertToStartValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float value);
                /*0x3fe64c8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x3fe64ec*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x3fe6510*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, float unitsXSecond, float changeValue);
                /*0x3fe6524*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x3fe7388*/ Vector3Plugin();
                /*0x3fe6724*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe6728*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x3fe69a4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0x3fe6cac*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value);
                /*0x3fe6cb0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe6ce8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x3fe6d8c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x3fe6e0c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Options
            {
                interface IPlugOptions
                {
                    /*0x38159dc*/ void Reset();
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

                    /*0x3fe73d0*/ void Reset();
                }

                struct QuaternionOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.RotateMode rotateMode;
                    /*0x14*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x18*/ UnityEngine.Vector3 up;
                    /*0x24*/ bool dynamicLookAt;
                    /*0x28*/ UnityEngine.Vector3 dynamicLookAtWorldPosition;

                    /*0x3fe74e0*/ void Reset();
                }

                struct UintOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool isNegativeChangeValue;

                    /*0x3fe7554*/ void Reset();
                }

                struct Vector3ArrayOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;
                    /*0x18*/ float[] durations;

                    /*0x3fe755c*/ void Reset();
                }

                struct NoOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x3fe7570*/ void Reset();
                }

                struct ColorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool alphaOnly;

                    /*0x3fe7574*/ void Reset();
                }

                struct FloatOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0x3fe757c*/ void Reset();
                }

                struct RectOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0x3fe7584*/ void Reset();
                }

                struct StringOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool richTextEnabled;
                    /*0x14*/ DG.Tweening.ScrambleMode scrambleMode;
                    /*0x18*/ char[] scrambledChars;
                    /*0x20*/ int startValueStrippedLength;
                    /*0x24*/ int changeValueStrippedLength;

                    /*0x3fe758c*/ void Reset();
                }

                struct VectorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;

                    /*0x3fe75b4*/ void Reset();
                }
            }

            namespace Core
            {
                interface ITPlugin<T1, T2, TPlugOptions, TPlugin>
                {
                }

                class SpecialPluginsUtils
                {
                    static /*0x3fe13ac*/ bool SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                    static /*0x3fe75c0*/ bool SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x3fe7730*/ bool SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x3fe775c*/ bool SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                }

                interface IPlugSetter<T1, T2, TPlugin, TPlugOptions>
                {
                    /*0x38148bc*/ DG.Tweening.Core.DOGetter<T1> Getter();
                    /*0x38148bc*/ DG.Tweening.Core.DOSetter<T1> Setter();
                    /*0x3910ae8*/ T2 EndValue();
                    /*0x3910ae8*/ TPlugOptions GetOptions();
                }

                interface ITweenPlugin
                {
                }

                class ABSTweenPlugin<T1, T2, TPlugOptions> : DG.Tweening.Plugins.Core.ITweenPlugin
                {
                    /*0x38159dc*/ ABSTweenPlugin();
                    /*0x3816710*/ void Reset(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
                    /*0x3910ae8*/ void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
                    /*0x3910ae8*/ T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T1 value);
                    /*0x3816710*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    /*0x3816710*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    /*0x3910ae8*/ float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
                    /*0x3910ae8*/ void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
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

                    static /*0x3836db8*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>();
                    static /*0x3836db8*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>();
                    static /*0x3fe790c*/ void PurgeAll();
                }

                namespace PathCore
                {
                    class CubicBezierDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x3fe86b0*/ CubicBezierDecoder();
                        /*0x3fe86a0*/ CubicBezierDecoder();
                        /*0x3fe7ab0*/ int get_minInputWaypoints();
                        /*0x3fe7ab8*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x3fe8518*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3fe7fd0*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x3fe81e0*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    struct ControlPoint
                    {
                        /*0x10*/ UnityEngine.Vector3 a;
                        /*0x1c*/ UnityEngine.Vector3 b;

                        static /*0x3fe8764*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v);
                        /*0x3fe7fc0*/ ControlPoint(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                        /*0x3fe8794*/ string ToString();
                    }

                    class ABSPathDecoder
                    {
                        /*0x3fe86a8*/ ABSPathDecoder();
                        void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3814574*/ int get_minInputWaypoints();
                    }

                    class CatmullRomDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x3fe93dc*/ CatmullRomDecoder();
                        /*0x3fe93d4*/ CatmullRomDecoder();
                        /*0x3fe88f4*/ int get_minInputWaypoints();
                        /*0x3fe88fc*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x3fe9160*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3fe8b64*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x3fe8d74*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class LinearDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        /*0x3fe98b8*/ LinearDecoder();
                        /*0x3fe9490*/ int get_minInputWaypoints();
                        /*0x3fe9498*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x3fe970c*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x3fe94e4*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x3fe98b4*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
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

                        static /*0x3fe9d5c*/ UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, int drawSubdivisionsXSegment);
                        static /*0x3fe9e38*/ void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0x3fe9f44*/ void Draw(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0x3fea364*/ UnityEngine.Vector3 ConvertToDrawPoint(UnityEngine.Vector3 wp, DG.Tweening.Plugins.Options.PathOptions plugOptions);
                        /*0x3fe98c0*/ Path(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, int subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor);
                        /*0x3fe9d3c*/ Path();
                        /*0x3fde86c*/ int get_minInputWaypoints();
                        /*0x3fde88c*/ void FinalizePath(bool isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal);
                        /*0x3fdf254*/ UnityEngine.Vector3 GetPoint(float perc, bool convertToConstantPerc);
                        /*0x3fdf140*/ float ConvertToConstantPathPerc(float perc);
                        /*0x3fdfbd0*/ int GetWaypointIndexFromPerc(float perc, bool isMovingForward);
                        /*0x3fde194*/ void Destroy();
                        /*0x3fdec38*/ DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(int loopIncrement);
                        /*0x3fe9ad0*/ void AssignWaypoints(UnityEngine.Vector3[] newWps, bool cloneWps);
                        /*0x3fe9bc8*/ void AssignDecoder(DG.Tweening.PathType pathType);
                        /*0x3fe9f40*/ void Draw();
                    }
                }
            }
        }

        namespace CustomPlugins
        {
            class PureQuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;

                static /*0x3fea428*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug();
                /*0x3fea4ac*/ PureQuaternionPlugin();
                /*0x3fea4f4*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fea4f8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x3fea60c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, bool setImmediately, bool isRelative);
                /*0x3fea7c0*/ UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value);
                /*0x3fea7c4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fea878*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x3fea89c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.Quaternion changeValue);
                /*0x3fea950*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, float duration, bool usingInversePosition, int newCompletedSteps, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
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

                /*0x3fea9fc*/ ABSSequentiable();
            }

            class DOGetter<T> : System.MulticastDelegate
            {
                DOGetter(object object, nint method);
                /*0x3910ae8*/ T Invoke();
                /*0x3814b90*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x3910ae8*/ T EndInvoke(System.IAsyncResult result);
            }

            class DOSetter<T> : System.MulticastDelegate
            {
                DOSetter(object object, nint method);
                /*0x3910ae8*/ void Invoke(T pNewValue);
                /*0x3910ae8*/ System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, object object);
                /*0x3816710*/ void EndInvoke(System.IAsyncResult result);
            }

            class Debugger
            {
                static string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>";
                static /*0x0*/ int _logPriority;

                static /*0x3feaa04*/ int get_logPriority();
                static /*0x3feaa4c*/ void Log(object message);
                static /*0x3feab70*/ void LogWarning(object message, DG.Tweening.Tween t);
                static /*0x3fead60*/ void LogError(object message, DG.Tweening.Tween t);
                static /*0x3feaef0*/ void LogSafeModeCapturedError(object message, DG.Tweening.Tween t);
                static /*0x3feb114*/ void LogReport(object message);
                static /*0x3feb23c*/ void LogSafeModeReport(object message);
                static /*0x3feb364*/ void LogInvalidTween(DG.Tweening.Tween t);
                static /*0x3feb3a8*/ void LogNestedTween(DG.Tweening.Tween t);
                static /*0x3feb3f0*/ void LogNullTween(DG.Tweening.Tween t);
                static /*0x3feb434*/ void LogNonPathTween(DG.Tweening.Tween t);
                static /*0x3feb47c*/ void LogMissingMaterialProperty(string propertyName);
                static /*0x3feb4d0*/ void LogMissingMaterialProperty(int propertyId);
                static /*0x3feb54c*/ void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x3feb5ac*/ void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x3feb60c*/ void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour);
                static /*0x3feb680*/ bool ShouldLogSafeModeCapturedError();
                static /*0x3fead00*/ string GetDebugDataMessage(DG.Tweening.Tween t);
                static /*0x3feb720*/ void AddDebugDataToMessage(ref string message, DG.Tweening.Tween t);

                class Sequence
                {
                    static /*0x3feb8f0*/ void LogAddToNullSequence();
                    static /*0x3feb934*/ void LogAddToInactiveSequence();
                    static /*0x3feb978*/ void LogAddToLockedSequence();
                    static /*0x3feb9bc*/ void LogAddNullTween();
                    static /*0x3feba00*/ void LogAddInactiveTween(DG.Tweening.Tween t);
                    static /*0x3feba48*/ void LogAddAlreadySequencedTween(DG.Tweening.Tween t);
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

                static /*0x3fecd30*/ void Create();
                static /*0x3fece7c*/ void DestroyInstance();
                /*0x3fecf80*/ DOTweenComponent();
                /*0x3feba90*/ void Awake();
                /*0x3febca8*/ void Start();
                /*0x3febd80*/ void Update();
                /*0x3fec06c*/ void LateUpdate();
                /*0x3fec184*/ void FixedUpdate();
                /*0x3fec2fc*/ void OnDrawGizmos();
                /*0x3fec43c*/ void OnDestroy();
                /*0x3fec8a8*/ void OnApplicationPause(bool pauseStatus);
                /*0x3fec904*/ void OnApplicationQuit();
                /*0x3fec964*/ DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
                /*0x3fec9d8*/ System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t);
                /*0x3feca6c*/ System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t);
                /*0x3fecae0*/ System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t);
                /*0x3fecb74*/ System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
                /*0x3fecc18*/ System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, float position);
                /*0x3feccbc*/ System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t);

                class <WaitForCompletion>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3feca44*/ <WaitForCompletion>d__17(int <>1__state);
                    /*0x3fecf88*/ void System.IDisposable.Dispose();
                    /*0x3fecf8c*/ bool MoveNext();
                    /*0x3fecfec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fecff4*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fed02c*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForElapsedLoops>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ int elapsedLoops;

                    /*0x3fecbf0*/ <WaitForElapsedLoops>d__20(int <>1__state);
                    /*0x3fed034*/ void System.IDisposable.Dispose();
                    /*0x3fed038*/ bool MoveNext();
                    /*0x3fed0a0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fed0a8*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fed0e0*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForKill>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fecb4c*/ <WaitForKill>d__19(int <>1__state);
                    /*0x3fed0e8*/ void System.IDisposable.Dispose();
                    /*0x3fed0ec*/ bool MoveNext();
                    /*0x3fed144*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fed14c*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fed184*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForPosition>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ float position;

                    /*0x3fecc94*/ <WaitForPosition>d__21(int <>1__state);
                    /*0x3fed18c*/ void System.IDisposable.Dispose();
                    /*0x3fed190*/ bool MoveNext();
                    /*0x3fed208*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fed210*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fed248*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForRewind>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fed43c*/ <WaitForRewind>d__18(int <>1__state);
                    /*0x3fed464*/ void System.IDisposable.Dispose();
                    /*0x3fed468*/ bool MoveNext();
                    /*0x3fed4e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fed4ec*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fed524*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForStart>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x3fed52c*/ <WaitForStart>d__22(int <>1__state);
                    /*0x3fed554*/ void System.IDisposable.Dispose();
                    /*0x3fed558*/ bool MoveNext();
                    /*0x3fed5b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x3fed5c0*/ void System.Collections.IEnumerator.Reset();
                    /*0x3fed5f8*/ object System.Collections.IEnumerator.get_Current();
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

                /*0x3fed600*/ DOTweenSettings();

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

                    /*0x3fed704*/ SafeModeOptions();
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

                    /*0x3fed714*/ ModulesSetup();
                }
            }

            class Extensions
            {
                static /*0x3910ae8*/ T SetSpecialStartupMode<T>(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode);
                static /*0x38379c4*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                static /*0x38379c4*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            }

            class DOTweenExternalCommand
            {
                static /*0x0*/ System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> SetOrientationOnPath;

                static /*0x3fed728*/ void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x3fed7f4*/ void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x3fed8c0*/ void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
            }

            struct SafeModeReport
            {
                /*0x10*/ int <totMissingTargetOrFieldErrors>k__BackingField;
                /*0x14*/ int <totCallbackErrors>k__BackingField;
                /*0x18*/ int <totStartupErrors>k__BackingField;
                /*0x1c*/ int <totUnsetErrors>k__BackingField;

                /*0x3fed9a0*/ int get_totMissingTargetOrFieldErrors();
                /*0x3fed9a8*/ void set_totMissingTargetOrFieldErrors(int value);
                /*0x3fed9b0*/ int get_totCallbackErrors();
                /*0x3fed9b8*/ void set_totCallbackErrors(int value);
                /*0x3fed9c0*/ int get_totStartupErrors();
                /*0x3fed9c8*/ void set_totStartupErrors(int value);
                /*0x3fed9d0*/ int get_totUnsetErrors();
                /*0x3fed9d8*/ void set_totUnsetErrors(int value);
                /*0x3fed9e0*/ void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type);
                /*0x3feda1c*/ int GetTotErrors();

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
                /*0x3feda2c*/ SequenceCallback(float sequencedPosition, DG.Tweening.TweenCallback callback);
            }

            class TweenLink
            {
                /*0x10*/ UnityEngine.GameObject target;
                /*0x18*/ DG.Tweening.LinkBehaviour behaviour;
                /*0x1c*/ bool lastSeenActive;

                /*0x3feda74*/ TweenLink(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour);
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

                static /*0x3fedad8*/ TweenManager();
                static /*0x3836db8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>();
                static /*0x3fedcfc*/ DG.Tweening.Sequence GetSequence();
                static /*0x3fee4e0*/ void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
                static /*0x3fee724*/ void AddActiveTweenToSequence(DG.Tweening.Tween t);
                static /*0x3feec00*/ int DespawnAll();
                static /*0x3feed78*/ void Despawn(DG.Tweening.Tween t, bool modifyActiveLists);
                static /*0x3fef2d4*/ void PurgeAll(bool isApplicationQuitting);
                static /*0x3fef400*/ void PurgePools();
                static /*0x3fef504*/ void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink);
                static /*0x3fef740*/ void RemoveTweenLink(DG.Tweening.Tween t);
                static /*0x3fef4b0*/ void ResetCapacities();
                static /*0x3fef81c*/ void SetCapacities(int tweenersCapacity, int sequencesCapacity);
                static /*0x3fef8fc*/ int Validate();
                static /*0x3fefe64*/ void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime);
                static /*0x3ff0074*/ bool Update(DG.Tweening.Tween t, float deltaTime, float independentTime, bool isSingleTweenManualUpdate);
                static /*0x3ff0510*/ int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray);
                static /*0x3ff0e90*/ bool Complete(DG.Tweening.Tween t, bool modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x3ff0f70*/ bool Flip(DG.Tweening.Tween t);
                static /*0x3ff0de0*/ void ForceInit(DG.Tweening.Tween t, bool isSequenced);
                static /*0x3ff0f98*/ bool Goto(DG.Tweening.Tween t, float to, bool andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x3fef704*/ bool Pause(DG.Tweening.Tween t);
                static /*0x3fef684*/ bool Play(DG.Tweening.Tween t);
                static /*0x3ff10d4*/ bool PlayBackwards(DG.Tweening.Tween t);
                static /*0x3ff11ac*/ bool PlayForward(DG.Tweening.Tween t);
                static /*0x3ff125c*/ bool Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
                static /*0x3ff1324*/ bool Rewind(DG.Tweening.Tween t, bool includeDelay);
                static /*0x3ff1444*/ bool SmoothRewind(DG.Tweening.Tween t);
                static /*0x3ff1540*/ bool TogglePause(DG.Tweening.Tween t);
                static /*0x3ff1650*/ int TotalPooledTweens();
                static /*0x3ff16ac*/ int TotalPlayingTweens();
                static /*0x3ff17b8*/ int TotalTweensById(object id, bool playingOnly);
                static /*0x3ff1acc*/ System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(bool playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3ff1cd0*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3ff1888*/ int DoGetTweensById(object id, bool playingOnly, bool addToList, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3ff1e1c*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x3fefc88*/ void MarkForKilling(DG.Tweening.Tween t, bool isSingleTweenManualUpdate);
                static /*0x3ff02d0*/ void EvaluateTweenLink(DG.Tweening.Tween t);
                static /*0x3fedfe4*/ void AddActiveTween(DG.Tweening.Tween t);
                static /*0x3fefa80*/ void ReorganizeActiveTweens();
                static /*0x3fefdac*/ void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens);
                static /*0x3fee778*/ void RemoveActiveTween(DG.Tweening.Tween t);
                static /*0x3fef25c*/ void ClearTweenArray(DG.Tweening.Tween[] tweens);
                static /*0x3fee2c4*/ void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode);
                static /*0x3ff15b0*/ void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind);

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

                static /*0x3ff25e8*/ DOTweenUtils();
                static /*0x3ff2034*/ UnityEngine.Vector3 Vector3FromAngle(float degrees, float magnitude);
                static /*0x3ff207c*/ float Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
                static /*0x3ff21c8*/ UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation);
                static /*0x3ff2224*/ UnityEngine.Vector2 GetPointOnCircle(UnityEngine.Vector2 center, float radius, float degrees);
                static /*0x3ff228c*/ bool Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                static /*0x3ff238c*/ System.Type GetLooseScriptType(string typeName);
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

                /*0x38159dc*/ TweenerCore();
                /*0x3814ff0*/ DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
                /*0x3814a74*/ DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
                /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration);
                /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
                /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration, bool snapStartValue);
                /*0x3910ae8*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration);
                DG.Tweening.Tweener SetFrom(bool relative);
                /*0x3910ae8*/ DG.Tweening.Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative);
                /*0x38159dc*/ void Reset();
                /*0x3813ffc*/ bool Validate();
                /*0x3814200*/ bool ValidateChangeValueType(System.Type newType, ref bool isColor32ToColor);
                /*0x38152bc*/ float UpdateDelay(float elapsed);
                /*0x3813ffc*/ bool Startup();
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
                    static /*0x3ff26f8*/ float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x3ff2714*/ float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x3ff27d0*/ float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                }

                class EaseManager
                {
                    static float _PiOver2 = 1.5707963705062866;
                    static float _TwoPi = 6.2831854820251465;

                    static /*0x3ff2820*/ float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3ff2840*/ float Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3ff35e4*/ DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease);
                    static /*0x3ff4988*/ bool IsFlashEase(DG.Tweening.Ease ease);

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

                        static /*0x3ff4998*/ <>c();
                        /*0x3ff4a00*/ <>c();
                        /*0x3ff4a08*/ float <ToEaseFunction>b__4_0(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4a10*/ float <ToEaseFunction>b__4_1(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4a90*/ float <ToEaseFunction>b__4_2(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4b08*/ float <ToEaseFunction>b__4_3(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4b90*/ float <ToEaseFunction>b__4_4(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4b9c*/ float <ToEaseFunction>b__4_5(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4bb4*/ float <ToEaseFunction>b__4_6(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4bf8*/ float <ToEaseFunction>b__4_7(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4c08*/ float <ToEaseFunction>b__4_8(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4c28*/ float <ToEaseFunction>b__4_9(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4c70*/ float <ToEaseFunction>b__4_10(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4c84*/ float <ToEaseFunction>b__4_11(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4ca8*/ float <ToEaseFunction>b__4_12(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4cf4*/ float <ToEaseFunction>b__4_13(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4d0c*/ float <ToEaseFunction>b__4_14(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4d34*/ float <ToEaseFunction>b__4_15(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4d8c*/ float <ToEaseFunction>b__4_16(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4e14*/ float <ToEaseFunction>b__4_17(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4e9c*/ float <ToEaseFunction>b__4_18(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff4f8c*/ float <ToEaseFunction>b__4_19(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5008*/ float <ToEaseFunction>b__4_20(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5080*/ float <ToEaseFunction>b__4_21(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5134*/ float <ToEaseFunction>b__4_22(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5280*/ float <ToEaseFunction>b__4_23(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff53c8*/ float <ToEaseFunction>b__4_24(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5594*/ float <ToEaseFunction>b__4_25(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff55b4*/ float <ToEaseFunction>b__4_26(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff55e0*/ float <ToEaseFunction>b__4_27(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5650*/ float <ToEaseFunction>b__4_28(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff566c*/ float <ToEaseFunction>b__4_29(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5670*/ float <ToEaseFunction>b__4_30(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5674*/ float <ToEaseFunction>b__4_31(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5678*/ float <ToEaseFunction>b__4_32(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff567c*/ float <ToEaseFunction>b__4_33(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5680*/ float <ToEaseFunction>b__4_34(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x3ff5684*/ float <ToEaseFunction>b__4_35(float time, float duration, float overshootOrAmplitude, float period);
                    }
                }

                class EaseCurve
                {
                    /*0x10*/ UnityEngine.AnimationCurve _animCurve;

                    /*0x3ff569c*/ EaseCurve(UnityEngine.AnimationCurve animCurve);
                    /*0x3ff56cc*/ float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod);
                }

                class Flash
                {
                    static /*0x3ff3280*/ float Ease(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3ff3344*/ float EaseIn(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3ff340c*/ float EaseOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3ff34e0*/ float EaseInOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x3ff5768*/ float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res);
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
