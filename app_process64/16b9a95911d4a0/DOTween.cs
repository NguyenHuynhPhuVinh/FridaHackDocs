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

            static /*0x2b6e4c8*/ DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x2b6e4e0*/ DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x2b6e4f8*/ DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, float f);
            /*0x2b6e4b4*/ Color2(UnityEngine.Color ca, UnityEngine.Color cb);
        }

        class TweenCallback : System.MulticastDelegate
        {
            /*0x2b6e50c*/ TweenCallback(object object, nint method);
            /*0x2b6e5a8*/ void Invoke();
            /*0x2b6e5bc*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2b6e5d8*/ void EndInvoke(System.IAsyncResult result);
        }

        class TweenCallback<T> : System.MulticastDelegate
        {
            TweenCallback(object object, nint method);
            /*0x1ffc854*/ void Invoke(T value);
            /*0x1ffc854*/ System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, object object);
            /*0x1f30ebc*/ void EndInvoke(System.IAsyncResult result);
        }

        class EaseFunction : System.MulticastDelegate
        {
            /*0x2b6e5e4*/ EaseFunction(object object, nint method);
            /*0x2b6e684*/ float Invoke(float time, float duration, float overshootOrAmplitude, float period);
            /*0x2b6e698*/ System.IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, System.AsyncCallback callback, object object);
            /*0x2b6e744*/ float EndInvoke(System.IAsyncResult result);
        }

        class DOTween
        {
            static /*0x0*/ string Version;
            static /*0x8*/ bool useSafeMode;
            static /*0xc*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;
            static /*0x10*/ bool showUnityEditorReport;
            static /*0x14*/ float timeScale;
            static /*0x18*/ bool useSmoothDeltaTime;
            static /*0x1c*/ float maxSmoothUnscaledTime;
            static /*0x20*/ DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
            static /*0x24*/ DG.Tweening.LogBehaviour _logBehaviour;
            static /*0x28*/ System.Func<UnityEngine.LogType, object, bool> onWillLog;
            static /*0x30*/ bool drawGizmos;
            static /*0x31*/ bool debugMode;
            static /*0x32*/ bool _fooDebugStoreTargetId;
            static /*0x34*/ DG.Tweening.UpdateType defaultUpdateType;
            static /*0x38*/ bool defaultTimeScaleIndependent;
            static /*0x3c*/ DG.Tweening.AutoPlay defaultAutoPlay;
            static /*0x40*/ bool defaultAutoKill;
            static /*0x44*/ DG.Tweening.LoopType defaultLoopType;
            static /*0x48*/ bool defaultRecyclable;
            static /*0x4c*/ DG.Tweening.Ease defaultEaseType;
            static /*0x50*/ float defaultEaseOvershootOrAmplitude;
            static /*0x54*/ float defaultEasePeriod;
            static /*0x58*/ DG.Tweening.Core.DOTweenComponent instance;
            static /*0x60*/ int maxActiveTweenersReached;
            static /*0x64*/ int maxActiveSequencesReached;
            static /*0x68*/ DG.Tweening.Core.SafeModeReport safeModeReport;
            static /*0x78*/ System.Collections.Generic.List<DG.Tweening.TweenCallback> GizmosDelegates;
            static /*0x80*/ bool initialized;
            static /*0x81*/ bool isQuitting;

            static /*0x2b72950*/ DOTween();
            static /*0x2b6e76c*/ DG.Tweening.LogBehaviour get_logBehaviour();
            static /*0x2b6e7c4*/ void set_logBehaviour(DG.Tweening.LogBehaviour value);
            static /*0x2b6e828*/ bool get_debugStoreTargetId();
            static /*0x2b6e8c8*/ void set_debugStoreTargetId(bool value);
            static /*0x2b6e928*/ DG.Tweening.IDOTweenInit Init(System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x2b6f1e4*/ void AutoInit();
            static /*0x2b6eab0*/ DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x2b6f314*/ void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity);
            static /*0x2b6f37c*/ void Clear(bool destroy);
            static /*0x2b6f3d4*/ void Clear(bool destroy, bool isApplicationQuitting);
            static /*0x2b6f4f0*/ void ClearCachedTweens();
            static /*0x2b6f540*/ int Validate();
            static /*0x2b6f590*/ void ManualUpdate(float deltaTime, float unscaledDeltaTime);
            static /*0x2b6f744*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration);
            static /*0x2b6f7e4*/ DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, double endValue, float duration);
            static /*0x2b6f884*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, int endValue, float duration);
            static /*0x2b6f924*/ DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, uint endValue, float duration);
            static /*0x2b6f9c4*/ DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, long endValue, float duration);
            static /*0x2b6fa64*/ DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, ulong endValue, float duration);
            static /*0x2b6fb04*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, string endValue, float duration);
            static /*0x2b6fb9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, float duration);
            static /*0x2b6fc50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x2b6fd0c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, float duration);
            static /*0x2b6fdd4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x2b6fe90*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration);
            static /*0x2b6ff58*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, float duration);
            static /*0x2b70020*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, float duration);
            static /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration);
            static /*0x2b700b8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float endValue, float duration, DG.Tweening.AxisConstraint axisConstraint);
            static /*0x2b70174*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float endValue, float duration);
            static /*0x2b70250*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<float> setter, float startValue, float endValue, float duration);
            static /*0x2b703d4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, float duration, int vibrato, float elasticity);
            static /*0x2b709f8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, float strength, int vibrato, float randomness, bool ignoreZAxis, bool fadeOut);
            static /*0x2b71188*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b70ab0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut);
            static /*0x2b707c4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, float[] durations);
            static /*0x2b7124c*/ DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, float duration);
            static /*0x2b71300*/ DG.Tweening.Sequence Sequence();
            static /*0x2b7145c*/ int CompleteAll(bool withCallbacks);
            static /*0x2b714d8*/ int Complete(object targetOrId, bool withCallbacks);
            static /*0x2b7157c*/ int CompleteAndReturnKilledTot();
            static /*0x2b715e8*/ int CompleteAndReturnKilledTot(object targetOrId);
            static /*0x2b7166c*/ int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds);
            static /*0x2b716dc*/ int FlipAll();
            static /*0x2b71748*/ int Flip(object targetOrId);
            static /*0x2b717cc*/ int GotoAll(float to, bool andPlay);
            static /*0x2b71848*/ int Goto(object targetOrId, float to, bool andPlay);
            static /*0x2b718e0*/ int KillAll(bool complete);
            static /*0x2b71974*/ int KillAll(bool complete, object[] idsOrTargetsToExclude);
            static /*0x2b71a7c*/ int Kill(object targetOrId, bool complete);
            static /*0x2b71b40*/ int PauseAll();
            static /*0x2b71bac*/ int Pause(object targetOrId);
            static /*0x2b71c30*/ int PlayAll();
            static /*0x2b71c9c*/ int Play(object targetOrId);
            static /*0x2b71d20*/ int Play(object target, object id);
            static /*0x2b71dac*/ int PlayBackwardsAll();
            static /*0x2b71e18*/ int PlayBackwards(object targetOrId);
            static /*0x2b71e9c*/ int PlayBackwards(object target, object id);
            static /*0x2b71f28*/ int PlayForwardAll();
            static /*0x2b71f94*/ int PlayForward(object targetOrId);
            static /*0x2b72018*/ int PlayForward(object target, object id);
            static /*0x2b720a4*/ int RestartAll(bool includeDelay);
            static /*0x2b72114*/ int Restart(object targetOrId, bool includeDelay, float changeDelayTo);
            static /*0x2b721ac*/ int Restart(object target, object id, bool includeDelay, float changeDelayTo);
            static /*0x2b72258*/ int RewindAll(bool includeDelay);
            static /*0x2b722c8*/ int Rewind(object targetOrId, bool includeDelay);
            static /*0x2b72350*/ int SmoothRewindAll();
            static /*0x2b723bc*/ int SmoothRewind(object targetOrId);
            static /*0x2b72440*/ int TogglePauseAll();
            static /*0x2b724ac*/ int TogglePause(object targetOrId);
            static /*0x2b72530*/ bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying);
            static /*0x2b725b8*/ int TotalPlayingTweens();
            static /*0x2b72608*/ System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x2b726c8*/ System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x2b72788*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x2b72874*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x2b6f680*/ void InitCheck();
            static /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            /*0x2b72948*/ DOTween();

            class <>c__DisplayClass61_0
            {
                /*0x10*/ float v;
                /*0x18*/ DG.Tweening.Core.DOSetter<float> setter;

                /*0x2b703cc*/ <>c__DisplayClass61_0();
                /*0x2b72a7c*/ float <To>b__0();
                /*0x2b72a84*/ void <To>b__1(float x);
            }
        }

        class DOVirtual
        {
            static /*0x2b72ab8*/ DG.Tweening.Tweener Float(float from, float to, float duration, DG.Tweening.TweenCallback<float> onVirtualUpdate);
            static /*0x2b72c94*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0x2b72d30*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0x2b72dd4*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0x2b72e18*/ float EasedValue(float from, float to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0x2b72f30*/ DG.Tweening.Tween DelayedCall(float delay, DG.Tweening.TweenCallback callback, bool ignoreTimeScale);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ float val;
                /*0x18*/ DG.Tweening.TweenCallback<float> onVirtualUpdate;

                /*0x2b72c8c*/ <>c__DisplayClass0_0();
                /*0x2b7304c*/ float <Float>b__0();
                /*0x2b73054*/ void <Float>b__1(float x);
                /*0x2b7305c*/ void <Float>b__2();
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
            static /*0x2b73090*/ DG.Tweening.EaseFunction StopMotion(int motionFps, System.Nullable<DG.Tweening.Ease> ease);
            static /*0x2b7324c*/ DG.Tweening.EaseFunction StopMotion(int motionFps, UnityEngine.AnimationCurve animCurve);
            static /*0x2b73180*/ DG.Tweening.EaseFunction StopMotion(int motionFps, DG.Tweening.EaseFunction customEase);
            /*0x2b73308*/ EaseFactory();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ float motionDelay;
                /*0x18*/ DG.Tweening.EaseFunction customEase;

                /*0x2b73300*/ <>c__DisplayClass2_0();
                /*0x2b73310*/ float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period);
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

        class TweenExtensions
        {
            static /*0x2b73380*/ void Complete(DG.Tweening.Tween t);
            static /*0x2b73388*/ void Complete(DG.Tweening.Tween t, bool withCallbacks);
            static /*0x2b73548*/ void Flip(DG.Tweening.Tween t);
            static /*0x2b736b0*/ void ForceInit(DG.Tweening.Tween t);
            static /*0x2b7381c*/ void Goto(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0x2b739ec*/ void Kill(DG.Tweening.Tween t, bool complete);
            static /*0x1ffc854*/ T Pause<T>(T t);
            static /*0x1ffc854*/ T Play<T>(T t);
            static /*0x2b73c08*/ void PlayBackwards(DG.Tweening.Tween t);
            static /*0x2b73d70*/ void PlayForward(DG.Tweening.Tween t);
            static /*0x2b73ed8*/ void Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
            static /*0x2b74068*/ void Rewind(DG.Tweening.Tween t, bool includeDelay);
            static /*0x2b741d8*/ void SmoothRewind(DG.Tweening.Tween t);
            static /*0x2b74340*/ void TogglePause(DG.Tweening.Tween t);
            static /*0x2b744a8*/ void GotoWaypoint(DG.Tweening.Tween t, int waypointIndex, bool andPlay);
            static /*0x2b74838*/ UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t);
            static /*0x2b7491c*/ UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t);
            static /*0x2b74a00*/ UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t);
            static /*0x2b74ae4*/ UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x2b74bd0*/ UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x2b74cc8*/ UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t);
            static /*0x2b74dac*/ int CompletedLoops(DG.Tweening.Tween t);
            static /*0x2b74e28*/ float Delay(DG.Tweening.Tween t);
            static /*0x2b74eb0*/ float ElapsedDelay(DG.Tweening.Tween t);
            static /*0x2b74f38*/ float Duration(DG.Tweening.Tween t, bool includeLoops);
            static /*0x2b74fec*/ float Elapsed(DG.Tweening.Tween t, bool includeLoops);
            static /*0x2b75098*/ float ElapsedPercentage(DG.Tweening.Tween t, bool includeLoops);
            static /*0x2b75168*/ float ElapsedDirectionalPercentage(DG.Tweening.Tween t);
            static /*0x2b75240*/ bool IsActive(DG.Tweening.Tween t);
            static /*0x2b75254*/ bool IsBackwards(DG.Tweening.Tween t);
            static /*0x2b752d8*/ bool IsComplete(DG.Tweening.Tween t);
            static /*0x2b7535c*/ bool IsInitialized(DG.Tweening.Tween t);
            static /*0x2b753e0*/ bool IsPlaying(DG.Tweening.Tween t);
            static /*0x2b75464*/ int Loops(DG.Tweening.Tween t);
            static /*0x2b754e0*/ UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, float pathPercentage);
            static /*0x2b7577c*/ UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, int subdivisionsXSegment);
            static /*0x2b759bc*/ float PathLength(DG.Tweening.Tween t);
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

            static /*0x2b75d38*/ DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t);
            static /*0x2b75e3c*/ DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, float atPosition);
            static /*0x2b75f84*/ DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x2b75fa4*/ DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x2b76080*/ DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, float atPosition);
            static /*0x2b71388*/ void Setup(DG.Tweening.Sequence s);
            static /*0x2b7648c*/ bool DoStartup(DG.Tweening.Sequence s);
            static /*0x2b765e4*/ bool DoApplyTween(DG.Tweening.Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x2b76aac*/ bool ApplyInternalCycle(DG.Tweening.Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep);
            static /*0x2b76970*/ void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list);
            static /*0x2b76914*/ bool IsAnyCallbackSet(DG.Tweening.Sequence s);
            /*0x2b75c08*/ Sequence();
            /*0x2b7613c*/ float UpdateDelay(float elapsed);
            /*0x2b7616c*/ void Reset();
            /*0x2b763bc*/ bool Validate();
            /*0x2b76488*/ bool Startup();
            /*0x2b765e0*/ bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class ShortcutExtensions
        {
            static /*0x2b773dc*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, float endValue, float duration);
            static /*0x2b77564*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, float duration);
            static /*0x2b77714*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x2b7789c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, float endValue, float duration);
            static /*0x2b77a24*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x2b77bac*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, float endValue, float duration);
            static /*0x2b77d34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x2b77ee4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x2b78094*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b782f4*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b7856c*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b787cc*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b78a44*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x2b78bf4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, float endValue, float duration);
            static /*0x2b78d7c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, float endValue, float duration);
            static /*0x2b78f04*/ DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, float duration);
            static /*0x2b790a4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x2b79254*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x2b79474*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x2b79684*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, float duration);
            static /*0x2b7980c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x2b79a04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x2b79bec*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x2b79de4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x2b79fcc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x2b7a164*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x2b7a36c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x2b7a504*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x2b7a70c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, string property, float duration);
            static /*0x2b7a92c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, int propertyID, float duration);
            static /*0x2b7ab3c*/ DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, float toStartWidth, float toEndWidth, float duration);
            static /*0x2b7acc8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, float endValue, float duration);
            static /*0x2b7ae50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x2b7b024*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x2b7b1f4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x2b7b3a8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x2b7b55c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x2b7b718*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x2b7b8cc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x2b7ba80*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x2b7bc34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2b7bde8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x2b7bfd0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2b7c184*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x2b7c36c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration);
            static /*0x2b7c50c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, float endValue, float duration);
            static /*0x2b7c69c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, float endValue, float duration);
            static /*0x2b7c848*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, float endValue, float duration);
            static /*0x2b7c9f4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, float endValue, float duration);
            static /*0x2b7cba0*/ DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x2b7ce38*/ DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x2b7d0a0*/ DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x2b7d2e4*/ DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x2b7d528*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut);
            static /*0x2b7d78c*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut);
            static /*0x2b7da04*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b7dc64*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b7dedc*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b7e1ac*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2b7e424*/ DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2b7e990*/ DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2b7ee20*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2b7f044*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2b7f270*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x2b7f430*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x2b7f5f8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, float endValue, float duration);
            static /*0x2b7f780*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x2b7f97c*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x2b7fb78*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x2b7fde8*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x2b80048*/ DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x2b80258*/ DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x2b80468*/ DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2b80668*/ DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2b80868*/ DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x2b80b08*/ DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration);
            static /*0x2b80d00*/ int DOComplete(UnityEngine.Component target, bool withCallbacks);
            static /*0x2b80d64*/ int DOComplete(UnityEngine.Material target, bool withCallbacks);
            static /*0x2b80dc8*/ int DOKill(UnityEngine.Component target, bool complete);
            static /*0x2b80e2c*/ int DOKill(UnityEngine.Material target, bool complete);
            static /*0x2b80e90*/ int DOFlip(UnityEngine.Component target);
            static /*0x2b80ee4*/ int DOFlip(UnityEngine.Material target);
            static /*0x2b80f38*/ int DOGoto(UnityEngine.Component target, float to, bool andPlay);
            static /*0x2b80fac*/ int DOGoto(UnityEngine.Material target, float to, bool andPlay);
            static /*0x2b81020*/ int DOPause(UnityEngine.Component target);
            static /*0x2b81074*/ int DOPause(UnityEngine.Material target);
            static /*0x2b810c8*/ int DOPlay(UnityEngine.Component target);
            static /*0x2b8111c*/ int DOPlay(UnityEngine.Material target);
            static /*0x2b81170*/ int DOPlayBackwards(UnityEngine.Component target);
            static /*0x2b811c4*/ int DOPlayBackwards(UnityEngine.Material target);
            static /*0x2b81218*/ int DOPlayForward(UnityEngine.Component target);
            static /*0x2b8126c*/ int DOPlayForward(UnityEngine.Material target);
            static /*0x2b812c0*/ int DORestart(UnityEngine.Component target, bool includeDelay);
            static /*0x2b81328*/ int DORestart(UnityEngine.Material target, bool includeDelay);
            static /*0x2b81390*/ int DORewind(UnityEngine.Component target, bool includeDelay);
            static /*0x2b813f4*/ int DORewind(UnityEngine.Material target, bool includeDelay);
            static /*0x2b81458*/ int DOSmoothRewind(UnityEngine.Component target);
            static /*0x2b814ac*/ int DOSmoothRewind(UnityEngine.Material target);
            static /*0x2b81500*/ int DOTogglePause(UnityEngine.Component target);
            static /*0x2b81554*/ int DOTogglePause(UnityEngine.Material target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b7755c*/ <>c__DisplayClass0_0();
                /*0x2b815a8*/ float <DOAspect>b__0();
                /*0x2b815c0*/ void <DOAspect>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b7770c*/ <>c__DisplayClass1_0();
                /*0x2b815d8*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b815f0*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b77894*/ <>c__DisplayClass2_0();
                /*0x2b81608*/ float <DOFarClipPlane>b__0();
                /*0x2b81620*/ void <DOFarClipPlane>b__1(float x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b77a1c*/ <>c__DisplayClass3_0();
                /*0x2b81638*/ float <DOFieldOfView>b__0();
                /*0x2b81650*/ void <DOFieldOfView>b__1(float x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b77ba4*/ <>c__DisplayClass4_0();
                /*0x2b81668*/ float <DONearClipPlane>b__0();
                /*0x2b81680*/ void <DONearClipPlane>b__1(float x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b77d2c*/ <>c__DisplayClass5_0();
                /*0x2b81698*/ float <DOOrthoSize>b__0();
                /*0x2b816b0*/ void <DOOrthoSize>b__1(float x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b77edc*/ <>c__DisplayClass6_0();
                /*0x2b816c8*/ UnityEngine.Rect <DOPixelRect>b__0();
                /*0x2b816e0*/ void <DOPixelRect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b7808c*/ <>c__DisplayClass7_0();
                /*0x2b816f8*/ UnityEngine.Rect <DORect>b__0();
                /*0x2b81710*/ void <DORect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b782ec*/ <>c__DisplayClass8_0();
                /*0x2b81728*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2b81750*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b78564*/ <>c__DisplayClass9_0();
                /*0x2b817a0*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2b817c8*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b787c4*/ <>c__DisplayClass10_0();
                /*0x2b81818*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2b81840*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2b78a3c*/ <>c__DisplayClass11_0();
                /*0x2b818a8*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2b818d0*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x2b78bec*/ <>c__DisplayClass12_0();
                /*0x2b81938*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b81950*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x2b78d74*/ <>c__DisplayClass13_0();
                /*0x2b81968*/ float <DOIntensity>b__0();
                /*0x2b81980*/ void <DOIntensity>b__1(float x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x2b78efc*/ <>c__DisplayClass14_0();
                /*0x2b81998*/ float <DOShadowStrength>b__0();
                /*0x2b819b0*/ void <DOShadowStrength>b__1(float x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ DG.Tweening.Color2 startValue;
                /*0x30*/ UnityEngine.LineRenderer target;

                /*0x2b7909c*/ <>c__DisplayClass15_0();
                /*0x2b819c8*/ DG.Tweening.Color2 <DOColor>b__0();
                /*0x2b819d4*/ void <DOColor>b__1(DG.Tweening.Color2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2b7924c*/ <>c__DisplayClass16_0();
                /*0x2b819fc*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b81a14*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2b7946c*/ <>c__DisplayClass17_0();
                /*0x2b81a2c*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b81a4c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2b7967c*/ <>c__DisplayClass18_0();
                /*0x2b81a6c*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b81a8c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2b79804*/ <>c__DisplayClass19_0();
                /*0x2b81aac*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b81ac4*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2b799fc*/ <>c__DisplayClass20_0();
                /*0x2b81adc*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b81afc*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2b79be4*/ <>c__DisplayClass21_0();
                /*0x2b81b1c*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b81b3c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2b79ddc*/ <>c__DisplayClass22_0();
                /*0x2b81b5c*/ float <DOFloat>b__0();
                /*0x2b81b7c*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2b79fc4*/ <>c__DisplayClass23_0();
                /*0x2b81b9c*/ float <DOFloat>b__0();
                /*0x2b81bbc*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2b7a15c*/ <>c__DisplayClass24_0();
                /*0x2b81bdc*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x2b81bf4*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2b7a364*/ <>c__DisplayClass25_0();
                /*0x2b81c0c*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x2b81c2c*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2b7a4fc*/ <>c__DisplayClass26_0();
                /*0x2b81c4c*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x2b81c64*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2b7a704*/ <>c__DisplayClass27_0();
                /*0x2b81c7c*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x2b81c9c*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2b7a924*/ <>c__DisplayClass28_0();
                /*0x2b81cbc*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x2b81cdc*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2b7ab34*/ <>c__DisplayClass29_0();
                /*0x2b81cfc*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x2b81d1c*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x2b7acc0*/ <>c__DisplayClass30_0();
                /*0x2b81d3c*/ UnityEngine.Vector2 <DOResize>b__0();
                /*0x2b81d84*/ void <DOResize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x2b7ae48*/ <>c__DisplayClass31_0();
                /*0x2b81dc4*/ float <DOTime>b__0();
                /*0x2b81ddc*/ void <DOTime>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7b004*/ <>c__DisplayClass32_0();
                /*0x2b81df4*/ UnityEngine.Vector3 <DOMove>b__0();
                /*0x2b81e0c*/ void <DOMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7b1d0*/ <>c__DisplayClass33_0();
                /*0x2b81e24*/ UnityEngine.Vector3 <DOMoveX>b__0();
                /*0x2b81e3c*/ void <DOMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7b3a0*/ <>c__DisplayClass34_0();
                /*0x2b81e54*/ UnityEngine.Vector3 <DOMoveY>b__0();
                /*0x2b81e6c*/ void <DOMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7b554*/ <>c__DisplayClass35_0();
                /*0x2b81e84*/ UnityEngine.Vector3 <DOMoveZ>b__0();
                /*0x2b81e9c*/ void <DOMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7b710*/ <>c__DisplayClass36_0();
                /*0x2b81eb4*/ UnityEngine.Vector3 <DOLocalMove>b__0();
                /*0x2b81ecc*/ void <DOLocalMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7b8c4*/ <>c__DisplayClass37_0();
                /*0x2b81ee4*/ UnityEngine.Vector3 <DOLocalMoveX>b__0();
                /*0x2b81efc*/ void <DOLocalMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7ba78*/ <>c__DisplayClass38_0();
                /*0x2b81f14*/ UnityEngine.Vector3 <DOLocalMoveY>b__0();
                /*0x2b81f2c*/ void <DOLocalMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7bc2c*/ <>c__DisplayClass39_0();
                /*0x2b81f44*/ UnityEngine.Vector3 <DOLocalMoveZ>b__0();
                /*0x2b81f5c*/ void <DOLocalMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7bde0*/ <>c__DisplayClass40_0();
                /*0x2b81f74*/ UnityEngine.Quaternion <DORotate>b__0();
                /*0x2b81f8c*/ void <DORotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7bfc8*/ <>c__DisplayClass41_0();
                /*0x2b81fa4*/ UnityEngine.Quaternion <DORotateQuaternion>b__0();
                /*0x2b81fbc*/ void <DORotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass42_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7c17c*/ <>c__DisplayClass42_0();
                /*0x2b81fd4*/ UnityEngine.Quaternion <DOLocalRotate>b__0();
                /*0x2b81fec*/ void <DOLocalRotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7c364*/ <>c__DisplayClass43_0();
                /*0x2b82004*/ UnityEngine.Quaternion <DOLocalRotateQuaternion>b__0();
                /*0x2b8201c*/ void <DOLocalRotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass44_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7c504*/ <>c__DisplayClass44_0();
                /*0x2b82034*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x2b8204c*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7c694*/ <>c__DisplayClass45_0();
                /*0x2b82064*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x2b8207c*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass46_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7c840*/ <>c__DisplayClass46_0();
                /*0x2b82094*/ UnityEngine.Vector3 <DOScaleX>b__0();
                /*0x2b820ac*/ void <DOScaleX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7c9ec*/ <>c__DisplayClass47_0();
                /*0x2b820c4*/ UnityEngine.Vector3 <DOScaleY>b__0();
                /*0x2b820dc*/ void <DOScaleY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7cb98*/ <>c__DisplayClass48_0();
                /*0x2b820f4*/ UnityEngine.Vector3 <DOScaleZ>b__0();
                /*0x2b8210c*/ void <DOScaleZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass49_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7ce30*/ <>c__DisplayClass49_0();
                /*0x2b82124*/ UnityEngine.Quaternion <DOLookAt>b__0();
                /*0x2b8213c*/ void <DOLookAt>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7d080*/ <>c__DisplayClass50_0();
                /*0x2b82154*/ UnityEngine.Vector3 <DOPunchPosition>b__0();
                /*0x2b8216c*/ void <DOPunchPosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7d2dc*/ <>c__DisplayClass51_0();
                /*0x2b82184*/ UnityEngine.Vector3 <DOPunchScale>b__0();
                /*0x2b8219c*/ void <DOPunchScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7d520*/ <>c__DisplayClass52_0();
                /*0x2b821b4*/ UnityEngine.Vector3 <DOPunchRotation>b__0();
                /*0x2b821cc*/ void <DOPunchRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7d784*/ <>c__DisplayClass53_0();
                /*0x2b82208*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2b82220*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass54_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7d9fc*/ <>c__DisplayClass54_0();
                /*0x2b82238*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2b82250*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass55_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7dc5c*/ <>c__DisplayClass55_0();
                /*0x2b82268*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2b82280*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7ded4*/ <>c__DisplayClass56_0();
                /*0x2b822bc*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2b822d4*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass57_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7e1a4*/ <>c__DisplayClass57_0();
                /*0x2b82310*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x2b82328*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7e41c*/ <>c__DisplayClass58_0();
                /*0x2b82340*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x2b82358*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0x2b7e908*/ <>c__DisplayClass59_0();
                /*0x2b82370*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x2b82388*/ void <DOJump>b__1(UnityEngine.Vector3 x);
                /*0x2b823a0*/ void <DOJump>b__2();
                /*0x2b823c8*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x2b823e0*/ void <DOJump>b__4(UnityEngine.Vector3 x);
                /*0x2b823f8*/ UnityEngine.Vector3 <DOJump>b__5();
                /*0x2b82410*/ void <DOJump>b__6(UnityEngine.Vector3 x);
                /*0x2b82428*/ void <DOJump>b__7();
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ bool offsetYSet;
                /*0x1c*/ float offsetY;
                /*0x20*/ DG.Tweening.Sequence s;
                /*0x28*/ UnityEngine.Vector3 endValue;
                /*0x34*/ float startPosY;

                /*0x2b7ee18*/ <>c__DisplayClass60_0();
                /*0x2b824d4*/ UnityEngine.Vector3 <DOLocalJump>b__0();
                /*0x2b824ec*/ void <DOLocalJump>b__1(UnityEngine.Vector3 x);
                /*0x2b82504*/ UnityEngine.Vector3 <DOLocalJump>b__2();
                /*0x2b8251c*/ void <DOLocalJump>b__3(UnityEngine.Vector3 x);
                /*0x2b82534*/ UnityEngine.Vector3 <DOLocalJump>b__4();
                /*0x2b8254c*/ void <DOLocalJump>b__5(UnityEngine.Vector3 x);
                /*0x2b82564*/ void <DOLocalJump>b__6();
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7f03c*/ <>c__DisplayClass61_0();
                /*0x2b82608*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x2b82620*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass62_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7f268*/ <>c__DisplayClass62_0();
                /*0x2b82638*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2b82650*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7f428*/ <>c__DisplayClass63_0();
                /*0x2b82668*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x2b82680*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2b7f5f0*/ <>c__DisplayClass64_0();
                /*0x2b82698*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2b826b0*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ DG.Tweening.Tween target;

                /*0x2b7f778*/ <>c__DisplayClass65_0();
                /*0x2b826c8*/ float <DOTimeScale>b__0();
                /*0x2b826e0*/ void <DOTimeScale>b__1(float x);
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Light target;

                /*0x2b7f974*/ <>c__DisplayClass66_0();
                /*0x2b826f8*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b82704*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;

                /*0x2b7fb70*/ <>c__DisplayClass67_0();
                /*0x2b82770*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b8277c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass68_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ string property;

                /*0x2b7fde0*/ <>c__DisplayClass68_0();
                /*0x2b827e8*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b827f4*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass69_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ int propertyID;

                /*0x2b80040*/ <>c__DisplayClass69_0();
                /*0x2b82874*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b82880*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2b80250*/ <>c__DisplayClass70_0();
                /*0x2b82900*/ UnityEngine.Vector3 <DOBlendableMoveBy>b__0();
                /*0x2b8290c*/ void <DOBlendableMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass71_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2b80460*/ <>c__DisplayClass71_0();
                /*0x2b82970*/ UnityEngine.Vector3 <DOBlendableLocalMoveBy>b__0();
                /*0x2b8297c*/ void <DOBlendableLocalMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2b80660*/ <>c__DisplayClass72_0();
                /*0x2b829e0*/ UnityEngine.Quaternion <DOBlendableRotateBy>b__0();
                /*0x2b829ec*/ void <DOBlendableRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass73_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2b80860*/ <>c__DisplayClass73_0();
                /*0x2b82cbc*/ UnityEngine.Quaternion <DOBlendableLocalRotateBy>b__0();
                /*0x2b82cc8*/ void <DOBlendableLocalRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass74_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2b80b00*/ <>c__DisplayClass74_0();
                /*0x2b82f98*/ UnityEngine.Vector3 <DOBlendablePunchRotation>b__0();
                /*0x2b82fa4*/ void <DOBlendablePunchRotation>b__1(UnityEngine.Vector3 v);
            }

            class <>c__DisplayClass75_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2b80cf8*/ <>c__DisplayClass75_0();
                /*0x2b832d0*/ UnityEngine.Vector3 <DOBlendableScaleBy>b__0();
                /*0x2b832dc*/ void <DOBlendableScaleBy>b__1(UnityEngine.Vector3 x);
            }
        }

        class TweenParams
        {
            static /*0x0*/ DG.Tweening.TweenParams Params;
            /*0x10*/ object id;
            /*0x18*/ object target;
            /*0x20*/ DG.Tweening.UpdateType updateType;
            /*0x24*/ bool isIndependentUpdate;
            /*0x28*/ DG.Tweening.TweenCallback onStart;
            /*0x30*/ DG.Tweening.TweenCallback onPlay;
            /*0x38*/ DG.Tweening.TweenCallback onRewind;
            /*0x40*/ DG.Tweening.TweenCallback onUpdate;
            /*0x48*/ DG.Tweening.TweenCallback onStepComplete;
            /*0x50*/ DG.Tweening.TweenCallback onComplete;
            /*0x58*/ DG.Tweening.TweenCallback onKill;
            /*0x60*/ DG.Tweening.TweenCallback<int> onWaypointChange;
            /*0x68*/ bool isRecyclable;
            /*0x69*/ bool isSpeedBased;
            /*0x6a*/ bool autoKill;
            /*0x6c*/ int loops;
            /*0x70*/ DG.Tweening.LoopType loopType;
            /*0x74*/ float delay;
            /*0x78*/ bool isRelative;
            /*0x7c*/ DG.Tweening.Ease easeType;
            /*0x80*/ DG.Tweening.EaseFunction customEase;
            /*0x88*/ float easeOvershootOrAmplitude;
            /*0x8c*/ float easePeriod;

            static /*0x2b839b4*/ TweenParams();
            /*0x2b83340*/ TweenParams();
            /*0x2b8335c*/ DG.Tweening.TweenParams Clear();
            /*0x2b834bc*/ DG.Tweening.TweenParams SetAutoKill(bool autoKillOnCompletion);
            /*0x2b834c4*/ DG.Tweening.TweenParams SetId(object id);
            /*0x2b834e0*/ DG.Tweening.TweenParams SetTarget(object target);
            /*0x2b834fc*/ DG.Tweening.TweenParams SetLoops(int loops, System.Nullable<DG.Tweening.LoopType> loopType);
            /*0x2b835cc*/ DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<float> overshootOrAmplitude, System.Nullable<float> period);
            /*0x2b83744*/ DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve);
            /*0x2b8380c*/ DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase);
            /*0x2b83830*/ DG.Tweening.TweenParams SetRecyclable(bool recyclable);
            /*0x2b83838*/ DG.Tweening.TweenParams SetUpdate(bool isIndependentUpdate);
            /*0x2b838b0*/ DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            /*0x2b838bc*/ DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action);
            /*0x2b838d8*/ DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action);
            /*0x2b838f4*/ DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action);
            /*0x2b83910*/ DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action);
            /*0x2b8392c*/ DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action);
            /*0x2b83948*/ DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action);
            /*0x2b83964*/ DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action);
            /*0x2b83980*/ DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<int> action);
            /*0x2b8399c*/ DG.Tweening.TweenParams SetDelay(float delay);
            /*0x2b839a4*/ DG.Tweening.TweenParams SetRelative(bool isRelative);
            /*0x2b839ac*/ DG.Tweening.TweenParams SetSpeedBased(bool isSpeedBased);
        }

        class TweenSettingsExtensions
        {
            static /*0x1ffc854*/ T SetAutoKill<T>(T t);
            static /*0x1ffc854*/ T SetAutoKill<T>(T t, bool autoKillOnCompletion);
            static /*0x1ffc854*/ T SetId<T>(T t, object objectId);
            static /*0x1ffc854*/ T SetId<T>(T t, string stringId);
            static /*0x1ffc854*/ T SetId<T>(T t, int intId);
            static /*0x1ffc854*/ T SetLink<T>(T t, UnityEngine.GameObject gameObject);
            static /*0x1ffc854*/ T SetLink<T>(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour);
            static /*0x1ffc854*/ T SetTarget<T>(T t, object target);
            static /*0x1ffc854*/ T SetLoops<T>(T t, int loops);
            static /*0x1ffc854*/ T SetLoops<T>(T t, int loops, DG.Tweening.LoopType loopType);
            static /*0x1ffc854*/ T SetEase<T>(T t, DG.Tweening.Ease ease);
            static /*0x1ffc854*/ T SetEase<T>(T t, DG.Tweening.Ease ease, float overshoot);
            static /*0x1ffc854*/ T SetEase<T>(T t, DG.Tweening.Ease ease, float amplitude, float period);
            static /*0x1ffc854*/ T SetEase<T>(T t, UnityEngine.AnimationCurve animCurve);
            static /*0x1ffc854*/ T SetEase<T>(T t, DG.Tweening.EaseFunction customEase);
            static /*0x1ffc854*/ T SetRecyclable<T>(T t);
            static /*0x1ffc854*/ T SetRecyclable<T>(T t, bool recyclable);
            static /*0x1ffc854*/ T SetUpdate<T>(T t, bool isIndependentUpdate);
            static /*0x1ffc854*/ T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType);
            static /*0x1ffc854*/ T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            static /*0x1ffc854*/ T OnStart<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnPlay<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnPause<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnRewind<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnUpdate<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnStepComplete<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnComplete<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnKill<T>(T t, DG.Tweening.TweenCallback action);
            static /*0x1ffc854*/ T OnWaypointChange<T>(T t, DG.Tweening.TweenCallback<int> action);
            static /*0x1ffc854*/ T SetAs<T>(T t, DG.Tweening.Tween asTween);
            static /*0x1ffc854*/ T SetAs<T>(T t, DG.Tweening.TweenParams tweenParams);
            static /*0x2b7e910*/ DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x2b83a24*/ DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x2b7e950*/ DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x2b83a60*/ DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t);
            static /*0x2b73020*/ DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, float interval);
            static /*0x2b83a9c*/ DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, float interval);
            static /*0x2b83ac4*/ DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x2b83af0*/ DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x2b83b1c*/ DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, float atPosition, DG.Tweening.TweenCallback callback);
            static /*0x1ffc854*/ T From<T>(T t);
            static /*0x1ffc854*/ T From<T>(T t, bool isRelative);
            static /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
            static /*0x2b83b44*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, float fromAlphaValue, bool setImmediately, bool isRelative);
            static /*0x2b83bf4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, float fromValue, bool setImmediately, bool isRelative);
            static /*0x1ffc854*/ T SetDelay<T>(T t, float delay);
            static /*0x1ffc854*/ T SetDelay<T>(T t, float delay, bool asPrependedIntervalIfSequence);
            static /*0x1ffc854*/ T SetRelative<T>(T t);
            static /*0x1ffc854*/ T SetRelative<T>(T t, bool isRelative);
            static /*0x1ffc854*/ T SetSpeedBased<T>(T t);
            static /*0x1ffc854*/ T SetSpeedBased<T>(T t, bool isSpeedBased);
            static /*0x2b83ca0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool snapping);
            static /*0x2b83cb8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x2b83cd0*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x2b7b00c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x2b7b1d8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x2b83cec*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x2b83d04*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x2b83d20*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool useShortest360Route);
            static /*0x2b70238*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool alphaOnly);
            static /*0x2b83d3c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool snapping);
            static /*0x2b83d54*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x2b7d088*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool snapping);
            static /*0x2b83e3c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x2b83e58*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x2b83e74*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x2b83e94*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x2b83fb8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, bool stableZRotation);
            static /*0x2b8400c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x2b840b0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, bool stableZRotation);
            static /*0x2b84140*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x2b84210*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, bool stableZRotation);
            static /*0x2b83ed4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Options.OrientType orientType, UnityEngine.Vector3 lookAtPosition, UnityEngine.Transform lookAtTransform, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up, bool stableZRotation);
            static /*0x2b842c8*/ void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
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

            static /*0x2b848d8*/ bool DoGoto(DG.Tweening.Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x2b771e4*/ bool OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t);
            static /*0x1ffc854*/ bool OnTweenCallback<T>(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param);
            /*0x2b75d14*/ Tween();
            /*0x2b84880*/ bool get_isRelative();
            /*0x2b84888*/ void set_isRelative(bool value);
            /*0x2b84890*/ bool get_active();
            /*0x2b84898*/ void set_active(bool value);
            /*0x2b848a0*/ float get_fullPosition();
            /*0x2b848a8*/ void set_fullPosition(float value);
            /*0x2b74824*/ bool get_hasLoops();
            /*0x2b848b0*/ bool get_playedOnce();
            /*0x2b848b8*/ void set_playedOnce(bool value);
            /*0x2b848c0*/ float get_position();
            /*0x2b848c8*/ void set_position(float value);
            /*0x2b76278*/ void Reset();
            /*0x1f2fe14*/ bool Validate();
            /*0x2b848d0*/ float UpdateDelay(float elapsed);
            /*0x1f2fe14*/ bool Startup();
            bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class Tweener : DG.Tweening.Tween
        {
            /*0x120*/ bool hasManuallySetStartValue;
            /*0x121*/ bool isFromAllowed;

            static /*0x1ffc854*/ bool Setup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            static float DoUpdateDelay<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, float elapsed);
            static /*0x1f31840*/ bool DoStartup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration);
            static /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue);
            static /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration);
            static /*0x1f31840*/ bool DOStartupSpecials<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static /*0x1f350f8*/ void DOStartupDurationBased<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            /*0x2b84bf8*/ Tweener();
            /*0x1f30778*/ DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
            DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
            DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
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
            class Color2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x2b85194*/ Color2Plugin();
                /*0x2b84c20*/ void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2b84c24*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x2b84d70*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, bool setImmediately, bool isRelative);
                /*0x2b84edc*/ DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value);
                /*0x2b84ee8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2b84f10*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2b84f38*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, DG.Tweening.Color2 changeValue);
                /*0x2b84f44*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, float elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class DoublePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<double, double, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2b85444*/ DoublePlugin();
                /*0x2b851dc*/ void Reset(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b851e0*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2b85270*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double fromValue, bool setImmediately, bool isRelative);
                /*0x2b8530c*/ double ConvertToStartValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double value);
                /*0x2b85310*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b8532c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b85348*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, double changeValue);
                /*0x2b85360*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class LongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<long, long, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2b857b8*/ LongPlugin();
                /*0x2b8548c*/ void Reset(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b85490*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2b85510*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long fromValue, bool setImmediately, bool isRelative);
                /*0x2b855a4*/ long ConvertToStartValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long value);
                /*0x2b855ac*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b855c8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b855e4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, long changeValue);
                /*0x2b855fc*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UlongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2b85b00*/ UlongPlugin();
                /*0x2b85800*/ void Reset(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b85804*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2b85884*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong fromValue, bool setImmediately, bool isRelative);
                /*0x2b85918*/ ulong ConvertToStartValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong value);
                /*0x2b85920*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b8593c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b85958*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, ulong changeValue);
                /*0x2b85974*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3ArrayPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>
            {
                /*0x2b86770*/ Vector3ArrayPlugin();
                /*0x2b85b48*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x2b85b8c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool isRelative);
                /*0x2b85b90*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, bool setImmediately, bool isRelative);
                /*0x2b85b94*/ UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value);
                /*0x2b85c94*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x2b85d7c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x2b85e7c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, float unitsXSecond, UnityEngine.Vector3[] changeValue);
                /*0x2b85f88*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class PathPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>
            {
                static float MinLookAhead = 0.00009999999747378752;

                static /*0x2b93078*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> Get();
                /*0x2b949a0*/ PathPlugin();
                /*0x2b92ec4*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x2b93070*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool isRelative);
                /*0x2b93074*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, bool setImmediately, bool isRelative);
                /*0x2b930b8*/ DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value);
                /*0x2b930cc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x2b93194*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x2b93650*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, float unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue);
                /*0x2b93668*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x2b93f1c*/ void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, float pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class ColorPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x2b94e00*/ ColorPlugin();
                /*0x2b949e8*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2b949ec*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x2b94acc*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately, bool isRelative);
                /*0x2b94bd4*/ UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value);
                /*0x2b94bd8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2b94bf8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2b94c18*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue);
                /*0x2b94c24*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class IntPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<int, int, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2b95178*/ IntPlugin();
                /*0x2b94e48*/ void Reset(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b94e4c*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2b94ed0*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int fromValue, bool setImmediately, bool isRelative);
                /*0x2b94f64*/ int ConvertToStartValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int value);
                /*0x2b94f6c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b94f8c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b94fac*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, int changeValue);
                /*0x2b94fc4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class QuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>
            {
                /*0x2b95d68*/ QuaternionPlugin();
                /*0x2b951c0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x2b951c4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool isRelative);
                /*0x2b95598*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0x2b956b0*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value);
                /*0x2b956dc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x2b95710*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x2b95880*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x2b95900*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectOffsetPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ UnityEngine.RectOffset _r;

                static /*0x2b96cd0*/ RectOffsetPlugin();
                /*0x2b96c88*/ RectOffsetPlugin();
                /*0x2b95db0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b95df4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2b95f70*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, bool setImmediately, bool isRelative);
                /*0x2b9618c*/ UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value);
                /*0x2b96248*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b96358*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b964b0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.RectOffset changeValue);
                /*0x2b9656c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, float elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>
            {
                /*0x2b97770*/ RectPlugin();
                /*0x2b96d4c*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x2b96d50*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool isRelative);
                /*0x2b9704c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, bool setImmediately, bool isRelative);
                /*0x2b97344*/ UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value);
                /*0x2b97348*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x2b97368*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x2b97388*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, float unitsXSecond, UnityEngine.Rect changeValue);
                /*0x2b97404*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, float elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UintPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<uint, uint, DG.Tweening.Plugins.Options.UintOptions>
            {
                /*0x2b97b20*/ UintPlugin();
                /*0x2b977b8*/ void Reset(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x2b977bc*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, bool isRelative);
                /*0x2b97840*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint fromValue, bool setImmediately, bool isRelative);
                /*0x2b978d4*/ uint ConvertToStartValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint value);
                /*0x2b978dc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x2b978fc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x2b9792c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, float unitsXSecond, uint changeValue);
                /*0x2b97944*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x2b9846c*/ Vector2Plugin();
                /*0x2b97b68*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b97b6c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x2b97d4c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately, bool isRelative);
                /*0x2b97f88*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value);
                /*0x2b97f8c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b97fac*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b98010*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0x2b98084*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector4Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x2b9940c*/ Vector4Plugin();
                /*0x2b984b4*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b984b8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x2b987e4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, bool setImmediately, bool isRelative);
                /*0x2b98ba0*/ UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value);
                /*0x2b98ba4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b98bc4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b98c70*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector4 changeValue);
                /*0x2b98d04*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, float elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class StringPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<string, string, DG.Tweening.Plugins.Options.StringOptions>
            {
                static /*0x0*/ System.Text.StringBuilder _Buffer;
                static /*0x8*/ System.Collections.Generic.List<char> _OpenedTags;

                static /*0x2b9a4fc*/ StringPlugin();
                /*0x2b9a4b4*/ StringPlugin();
                /*0x2b99454*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool isRelative);
                /*0x2b994d0*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string fromValue, bool setImmediately, bool isRelative);
                /*0x2b9956c*/ void Reset(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x2b995b0*/ string ConvertToStartValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string value);
                /*0x2b995b8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x2b995bc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x2b99698*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, float unitsXSecond, string changeValue);
                /*0x2b996d4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x2b99b68*/ System.Text.StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled);
                /*0x2b9a27c*/ char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options);
            }

            class StringPluginExtensions
            {
                static /*0x0*/ char[] ScrambledCharsAll;
                static /*0x8*/ char[] ScrambledCharsUppercase;
                static /*0x10*/ char[] ScrambledCharsLowercase;
                static /*0x18*/ char[] ScrambledCharsNumerals;
                static /*0x20*/ int _lastRndSeed;

                static /*0x2b9a5d0*/ StringPluginExtensions();
                static /*0x2b9a784*/ void ScrambleChars(char[] chars);
                static /*0x2b9a384*/ System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, int length, char[] chars);
            }

            class FloatPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<float, float, DG.Tweening.Plugins.Options.FloatOptions>
            {
                /*0x2b9acd4*/ FloatPlugin();
                /*0x2b9a824*/ void Reset(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x2b9a828*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool isRelative);
                /*0x2b9a968*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float fromValue, bool setImmediately, bool isRelative);
                /*0x2b9aab8*/ float ConvertToStartValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float value);
                /*0x2b9aabc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x2b9aadc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x2b9aafc*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, float unitsXSecond, float changeValue);
                /*0x2b9ab10*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x2b9b964*/ Vector3Plugin();
                /*0x2b9ad1c*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b9ad20*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x2b9afb0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately, bool isRelative);
                /*0x2b9b2b0*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value);
                /*0x2b9b2b4*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b9b2e8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2b9b380*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x2b9b400*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Options
            {
                interface IPlugOptions
                {
                    /*0x1f309e4*/ void Reset();
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
                    /*0x61*/ bool stableZRotation;
                    /*0x64*/ UnityEngine.Quaternion startupRot;
                    /*0x74*/ float startupZRot;
                    /*0x78*/ bool addedExtraStartWp;
                    /*0x79*/ bool addedExtraEndWp;

                    /*0x2b9b9ac*/ void Reset();
                }

                struct QuaternionOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.RotateMode rotateMode;
                    /*0x14*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x18*/ UnityEngine.Vector3 up;

                    /*0x2b9bab8*/ void Reset();
                }

                struct UintOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool isNegativeChangeValue;

                    /*0x2b9bb14*/ void Reset();
                }

                struct Vector3ArrayOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;
                    /*0x18*/ float[] durations;

                    /*0x2b9bb1c*/ void Reset();
                }

                struct NoOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x2b9bb30*/ void Reset();
                }

                struct ColorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool alphaOnly;

                    /*0x2b9bb34*/ void Reset();
                }

                struct FloatOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0x2b9bb3c*/ void Reset();
                }

                struct RectOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0x2b9bb44*/ void Reset();
                }

                struct StringOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool richTextEnabled;
                    /*0x14*/ DG.Tweening.ScrambleMode scrambleMode;
                    /*0x18*/ char[] scrambledChars;
                    /*0x20*/ int startValueStrippedLength;
                    /*0x24*/ int changeValueStrippedLength;

                    /*0x2b9bb4c*/ void Reset();
                }

                struct VectorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;

                    /*0x2b9bb74*/ void Reset();
                }
            }

            namespace Core
            {
                interface ITPlugin<T1, T2, TPlugOptions, TPlugin>
                {
                }

                class SpecialPluginsUtils
                {
                    static /*0x2b9bb80*/ bool SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                    static /*0x2b9bca4*/ bool SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x2b9be28*/ bool SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x2b9be54*/ bool SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                }

                interface IPlugSetter<T1, T2, TPlugin, TPlugOptions>
                {
                    /*0x1f30214*/ DG.Tweening.Core.DOGetter<T1> Getter();
                    /*0x1f30214*/ DG.Tweening.Core.DOSetter<T1> Setter();
                    /*0x1ffc854*/ T2 EndValue();
                    /*0x1ffc854*/ TPlugOptions GetOptions();
                }

                interface ITweenPlugin
                {
                }

                class ABSTweenPlugin<T1, T2, TPlugOptions> : DG.Tweening.Plugins.Core.ITweenPlugin
                {
                    /*0x1f309e4*/ ABSTweenPlugin();
                    /*0x1f30ebc*/ void Reset(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
                    /*0x1ffc854*/ void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately, bool isRelative);
                    /*0x1ffc854*/ T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T1 value);
                    /*0x1f30ebc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    /*0x1f30ebc*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    /*0x1ffc854*/ float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
                    /*0x1ffc854*/ void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
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

                    static /*0x1f327a0*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>();
                    static /*0x1f327a0*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>();
                    static /*0x2b9c00c*/ void PurgeAll();
                }

                namespace PathCore
                {
                    class CubicBezierDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x2b9cd74*/ CubicBezierDecoder();
                        /*0x2b9cd64*/ CubicBezierDecoder();
                        /*0x2b9c1b0*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x2b9cbdc*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x2b9c6b8*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x2b9c8c4*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    struct ControlPoint
                    {
                        /*0x10*/ UnityEngine.Vector3 a;
                        /*0x1c*/ UnityEngine.Vector3 b;

                        static /*0x2b9ce28*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v);
                        /*0x2b9c6a8*/ ControlPoint(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                        /*0x2b9ce5c*/ string ToString();
                    }

                    class ABSPathDecoder
                    {
                        /*0x2b9cd6c*/ ABSPathDecoder();
                        void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                    }

                    class CatmullRomDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x2b9da84*/ CatmullRomDecoder();
                        /*0x2b9da7c*/ CatmullRomDecoder();
                        /*0x2b9cfbc*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x2b9d818*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x2b9d21c*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x2b9d428*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class LinearDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        /*0x2b9df60*/ LinearDecoder();
                        /*0x2b9db38*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x2b9ddb8*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x2b9db84*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x2b9df5c*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
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
                        /*0x58*/ DG.Tweening.Plugins.Core.PathCore.Path _incrementalClone;
                        /*0x60*/ int _incrementalIndex;
                        /*0x68*/ DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder _decoder;
                        /*0x70*/ bool _changed;
                        /*0x78*/ UnityEngine.Vector3[] nonLinearDrawWps;
                        /*0x80*/ UnityEngine.Vector3 targetPosition;
                        /*0x8c*/ System.Nullable<UnityEngine.Vector3> lookAtPosition;
                        /*0x9c*/ UnityEngine.Color gizmoColor;

                        static /*0x2b9e3c4*/ UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, int drawSubdivisionsXSegment);
                        static /*0x2b9e49c*/ void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0x2b9e5a8*/ void Draw(DG.Tweening.Plugins.Core.PathCore.Path p);
                        /*0x2b9df68*/ Path(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, int subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor);
                        /*0x2b9e3a8*/ Path();
                        /*0x2b935ac*/ void FinalizePath(bool isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal);
                        /*0x2b93ee0*/ UnityEngine.Vector3 GetPoint(float perc, bool convertToConstantPerc);
                        /*0x2b93d98*/ float ConvertToConstantPathPerc(float perc);
                        /*0x2b94838*/ int GetWaypointIndexFromPerc(float perc, bool isMovingForward);
                        /*0x2b92f14*/ void Destroy();
                        /*0x2b938e8*/ DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(int loopIncrement);
                        /*0x2b9e144*/ void AssignWaypoints(UnityEngine.Vector3[] newWps, bool cloneWps);
                        /*0x2b9e23c*/ void AssignDecoder(DG.Tweening.PathType pathType);
                        /*0x2b9e5a4*/ void Draw();
                    }
                }
            }
        }

        namespace CustomPlugins
        {
            class PureQuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;

                static /*0x2b9e8bc*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug();
                /*0x2b9e940*/ PureQuaternionPlugin();
                /*0x2b9e988*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b9e98c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2b9eab4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, bool setImmediately, bool isRelative);
                /*0x2b9ec68*/ UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value);
                /*0x2b9ec6c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b9ed1c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2b9ed3c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.Quaternion changeValue);
                /*0x2b9edf0*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
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

                /*0x2b9eeb0*/ ABSSequentiable();
            }

            class DOGetter<T> : System.MulticastDelegate
            {
                DOGetter(object object, nint method);
                /*0x1ffc854*/ T Invoke();
                /*0x1f30394*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x1ffc854*/ T EndInvoke(System.IAsyncResult result);
            }

            class DOSetter<T> : System.MulticastDelegate
            {
                DOSetter(object object, nint method);
                /*0x1ffc854*/ void Invoke(T pNewValue);
                /*0x1ffc854*/ System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, object object);
                /*0x1f30ebc*/ void EndInvoke(System.IAsyncResult result);
            }

            class Debugger
            {
                static string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></color>";
                static /*0x0*/ int _logPriority;

                static /*0x2b9eeb8*/ int get_logPriority();
                static /*0x2b9ef00*/ void Log(object message);
                static /*0x2b9f034*/ void LogWarning(object message, DG.Tweening.Tween t);
                static /*0x2b9f318*/ void LogError(object message);
                static /*0x2b9f448*/ void LogReport(object message);
                static /*0x2b9f57c*/ void LogSafeModeReport(object message);
                static /*0x2b9f6b0*/ void LogInvalidTween(DG.Tweening.Tween t);
                static /*0x2b9f6f4*/ void LogNestedTween(DG.Tweening.Tween t);
                static /*0x2b9f73c*/ void LogNullTween(DG.Tweening.Tween t);
                static /*0x2b9f780*/ void LogNonPathTween(DG.Tweening.Tween t);
                static /*0x2b9f7c8*/ void LogMissingMaterialProperty(string propertyName);
                static /*0x2b9f81c*/ void LogMissingMaterialProperty(int propertyId);
                static /*0x2b9f898*/ void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x2b9f8f8*/ void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x2b9f958*/ void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour);
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

                static /*0x2ba1134*/ void Create();
                static /*0x2ba1280*/ void DestroyInstance();
                /*0x2ba1384*/ DOTweenComponent();
                /*0x2b9f9b8*/ void Awake();
                /*0x2b9fbcc*/ void Start();
                /*0x2b9fca4*/ void Update();
                /*0x2ba03b8*/ void LateUpdate();
                /*0x2ba04c8*/ void FixedUpdate();
                /*0x2ba062c*/ void OnDrawGizmos();
                /*0x2ba076c*/ void OnDestroy();
                /*0x2ba0be4*/ void OnApplicationPause(bool pauseStatus);
                /*0x2ba0c40*/ void OnApplicationQuit();
                /*0x2ba0c4c*/ DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
                /*0x2ba0d9c*/ System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t);
                /*0x2ba0e30*/ System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t);
                /*0x2ba0ec4*/ System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t);
                /*0x2ba0f58*/ System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
                /*0x2ba0ffc*/ System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, float position);
                /*0x2ba10a0*/ System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t);

                class <WaitForCompletion>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2ba0e08*/ <WaitForCompletion>d__17(int <>1__state);
                    /*0x2ba138c*/ void System.IDisposable.Dispose();
                    /*0x2ba1390*/ bool MoveNext();
                    /*0x2ba13f0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ba13f8*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ba1430*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForRewind>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2ba0e9c*/ <WaitForRewind>d__18(int <>1__state);
                    /*0x2ba1438*/ void System.IDisposable.Dispose();
                    /*0x2ba143c*/ bool MoveNext();
                    /*0x2ba14b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ba14c0*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ba14f8*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForKill>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2ba0f30*/ <WaitForKill>d__19(int <>1__state);
                    /*0x2ba1500*/ void System.IDisposable.Dispose();
                    /*0x2ba1504*/ bool MoveNext();
                    /*0x2ba155c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ba1564*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ba159c*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForElapsedLoops>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ int elapsedLoops;

                    /*0x2ba0fd4*/ <WaitForElapsedLoops>d__20(int <>1__state);
                    /*0x2ba15a4*/ void System.IDisposable.Dispose();
                    /*0x2ba15a8*/ bool MoveNext();
                    /*0x2ba1610*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ba1618*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ba1650*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForPosition>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ float position;

                    /*0x2ba1078*/ <WaitForPosition>d__21(int <>1__state);
                    /*0x2ba1658*/ void System.IDisposable.Dispose();
                    /*0x2ba165c*/ bool MoveNext();
                    /*0x2ba16d4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ba16dc*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ba1714*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForStart>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2ba110c*/ <WaitForStart>d__22(int <>1__state);
                    /*0x2ba171c*/ void System.IDisposable.Dispose();
                    /*0x2ba1720*/ bool MoveNext();
                    /*0x2ba1780*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2ba1788*/ void System.Collections.IEnumerator.Reset();
                    /*0x2ba17c0*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class DOTweenSettings : UnityEngine.ScriptableObject
            {
                static string AssetName = "DOTweenSettings";
                static string AssetFullFilename = "DOTweenSettings.asset";
                /*0x18*/ bool useSafeMode;
                /*0x20*/ DG.Tweening.Core.DOTweenSettings.SafeModeOptions safeModeOptions;
                /*0x28*/ float timeScale;
                /*0x2c*/ bool useSmoothDeltaTime;
                /*0x30*/ float maxSmoothUnscaledTime;
                /*0x34*/ DG.Tweening.Core.Enums.RewindCallbackMode rewindCallbackMode;
                /*0x38*/ bool showUnityEditorReport;
                /*0x3c*/ DG.Tweening.LogBehaviour logBehaviour;
                /*0x40*/ bool drawGizmos;
                /*0x41*/ bool defaultRecyclable;
                /*0x44*/ DG.Tweening.AutoPlay defaultAutoPlay;
                /*0x48*/ DG.Tweening.UpdateType defaultUpdateType;
                /*0x4c*/ bool defaultTimeScaleIndependent;
                /*0x50*/ DG.Tweening.Ease defaultEaseType;
                /*0x54*/ float defaultEaseOvershootOrAmplitude;
                /*0x58*/ float defaultEasePeriod;
                /*0x5c*/ bool defaultAutoKill;
                /*0x60*/ DG.Tweening.LoopType defaultLoopType;
                /*0x64*/ bool debugMode;
                /*0x65*/ bool debugStoreTargetId;
                /*0x66*/ bool showPreviewPanel;
                /*0x68*/ DG.Tweening.Core.DOTweenSettings.SettingsLocation storeSettingsLocation;
                /*0x70*/ DG.Tweening.Core.DOTweenSettings.ModulesSetup modules;
                /*0x78*/ bool showPlayingTweens;
                /*0x79*/ bool showPausedTweens;

                /*0x2ba17c8*/ DOTweenSettings();

                enum SettingsLocation
                {
                    AssetsDirectory = 0,
                    DOTweenDirectory = 1,
                    DemigiantDirectory = 2,
                }

                class SafeModeOptions
                {
                    /*0x10*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;

                    /*0x2ba18c0*/ SafeModeOptions();
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

                    /*0x2ba18c8*/ ModulesSetup();
                }
            }

            class Extensions
            {
                static /*0x1ffc854*/ T SetSpecialStartupMode<T>(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode);
                static /*0x1f327cc*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                static /*0x1f327cc*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            }

            class DOTweenExternalCommand
            {
                static /*0x0*/ System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> SetOrientationOnPath;

                static /*0x2ba18dc*/ void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x2ba19a8*/ void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x2b948e0*/ void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
            }

            struct SafeModeReport
            {
                /*0x10*/ int <totMissingTargetOrFieldErrors>k__BackingField;
                /*0x14*/ int <totCallbackErrors>k__BackingField;
                /*0x18*/ int <totStartupErrors>k__BackingField;
                /*0x1c*/ int <totUnsetErrors>k__BackingField;

                /*0x2ba1a74*/ int get_totMissingTargetOrFieldErrors();
                /*0x2ba1a7c*/ void set_totMissingTargetOrFieldErrors(int value);
                /*0x2ba1a84*/ int get_totCallbackErrors();
                /*0x2ba1a8c*/ void set_totCallbackErrors(int value);
                /*0x2ba1a94*/ int get_totStartupErrors();
                /*0x2ba1a9c*/ void set_totStartupErrors(int value);
                /*0x2ba1aa4*/ int get_totUnsetErrors();
                /*0x2ba1aac*/ void set_totUnsetErrors(int value);
                /*0x2ba1ab4*/ void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type);
                /*0x2ba0bd4*/ int GetTotErrors();

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
                /*0x2ba1ae8*/ SequenceCallback(float sequencedPosition, DG.Tweening.TweenCallback callback);
            }

            class TweenLink
            {
                /*0x10*/ UnityEngine.GameObject target;
                /*0x18*/ DG.Tweening.LinkBehaviour behaviour;
                /*0x1c*/ bool lastSeenActive;

                /*0x2ba1b30*/ TweenLink(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour);
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

                static /*0x2ba1b94*/ TweenManager();
                static /*0x1f327a0*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>();
                static /*0x2ba1db8*/ DG.Tweening.Sequence GetSequence();
                static /*0x2ba2594*/ void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
                static /*0x2ba2794*/ void AddActiveTweenToSequence(DG.Tweening.Tween t);
                static /*0x2ba2c54*/ int DespawnAll();
                static /*0x2ba2dd8*/ void Despawn(DG.Tweening.Tween t, bool modifyActiveLists);
                static /*0x2ba333c*/ void PurgeAll(bool isApplicationQuitting);
                static /*0x2ba346c*/ void PurgePools();
                static /*0x2ba3570*/ void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink);
                static /*0x2ba37c0*/ void RemoveTweenLink(DG.Tweening.Tween t);
                static /*0x2ba351c*/ void ResetCapacities();
                static /*0x2ba0cbc*/ void SetCapacities(int tweenersCapacity, int sequencesCapacity);
                static /*0x2ba389c*/ int Validate();
                static /*0x2b9ff90*/ void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime);
                static /*0x2ba4078*/ int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray);
                static /*0x2ba4a00*/ bool Complete(DG.Tweening.Tween t, bool modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x2ba4ad8*/ bool Flip(DG.Tweening.Tween t);
                static /*0x2ba4950*/ void ForceInit(DG.Tweening.Tween t, bool isSequenced);
                static /*0x2ba4afc*/ bool Goto(DG.Tweening.Tween t, float to, bool andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x2ba3784*/ bool Pause(DG.Tweening.Tween t);
                static /*0x2ba3704*/ bool Play(DG.Tweening.Tween t);
                static /*0x2ba4c38*/ bool PlayBackwards(DG.Tweening.Tween t);
                static /*0x2ba4d10*/ bool PlayForward(DG.Tweening.Tween t);
                static /*0x2ba4dc0*/ bool Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
                static /*0x2ba4e88*/ bool Rewind(DG.Tweening.Tween t, bool includeDelay);
                static /*0x2ba4fa8*/ bool SmoothRewind(DG.Tweening.Tween t);
                static /*0x2ba50a4*/ bool TogglePause(DG.Tweening.Tween t);
                static /*0x2ba51d4*/ int TotalPooledTweens();
                static /*0x2ba5230*/ int TotalPlayingTweens();
                static /*0x2ba533c*/ System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(bool playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x2ba5500*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x2ba578c*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x2ba3ca8*/ void MarkForKilling(DG.Tweening.Tween t);
                static /*0x2ba3df4*/ void EvaluateTweenLink(DG.Tweening.Tween t);
                static /*0x2ba20a0*/ void AddActiveTween(DG.Tweening.Tween t);
                static /*0x2ba3a4c*/ void ReorganizeActiveTweens();
                static /*0x2ba3d30*/ void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens);
                static /*0x2ba27e8*/ void RemoveActiveTween(DG.Tweening.Tween t);
                static /*0x2ba32cc*/ void ClearTweenArray(DG.Tweening.Tween[] tweens);
                static /*0x2ba2370*/ void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode);
                static /*0x2ba5120*/ void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind);

                enum CapacityIncreaseMode
                {
                    TweenersAndSequences = 0,
                    TweenersOnly = 1,
                    SequencesOnly = 2,
                }
            }

            class Utils
            {
                static /*0x0*/ System.Reflection.Assembly[] _loadedAssemblies;
                static /*0x8*/ string[] _defAssembliesToQuery;

                static /*0x2ba5ef4*/ Utils();
                static /*0x2ba59a0*/ UnityEngine.Vector3 Vector3FromAngle(float degrees, float magnitude);
                static /*0x2ba59e8*/ float Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
                static /*0x2ba5b38*/ UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation);
                static /*0x2ba5b88*/ bool Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                static /*0x2ba5c88*/ System.Type GetLooseScriptType(string typeName);
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

                /*0x1f309e4*/ TweenerCore();
                /*0x1f30778*/ DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
                /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration);
                /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
                /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration, bool snapStartValue);
                /*0x1ffc854*/ DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration);
                DG.Tweening.Tweener SetFrom(bool relative);
                /*0x1ffc854*/ DG.Tweening.Tweener SetFrom(T2 fromValue, bool setImmediately, bool relative);
                /*0x1f309e4*/ void Reset();
                /*0x1f2fe14*/ bool Validate();
                float UpdateDelay(float elapsed);
                /*0x1f2fe14*/ bool Startup();
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
                    static /*0x2ba6004*/ float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x2ba6020*/ float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x2ba60dc*/ float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                }

                class EaseManager
                {
                    static float _PiOver2 = 1.5707963705062866;
                    static float _TwoPi = 6.2831854820251465;

                    static /*0x2ba612c*/ float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2ba6148*/ float Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2ba6ed4*/ DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease);
                    static /*0x2ba8048*/ bool IsFlashEase(DG.Tweening.Ease ease);

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

                        static /*0x2ba8058*/ <>c();
                        /*0x2ba80c0*/ <>c();
                        /*0x2ba80c8*/ float <ToEaseFunction>b__4_0(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba80d0*/ float <ToEaseFunction>b__4_1(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8150*/ float <ToEaseFunction>b__4_2(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba81c8*/ float <ToEaseFunction>b__4_3(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8250*/ float <ToEaseFunction>b__4_4(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba825c*/ float <ToEaseFunction>b__4_5(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8270*/ float <ToEaseFunction>b__4_6(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba82b4*/ float <ToEaseFunction>b__4_7(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba82c4*/ float <ToEaseFunction>b__4_8(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba82e4*/ float <ToEaseFunction>b__4_9(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8328*/ float <ToEaseFunction>b__4_10(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba833c*/ float <ToEaseFunction>b__4_11(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8360*/ float <ToEaseFunction>b__4_12(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba83ac*/ float <ToEaseFunction>b__4_13(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba83c4*/ float <ToEaseFunction>b__4_14(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba83ec*/ float <ToEaseFunction>b__4_15(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8440*/ float <ToEaseFunction>b__4_16(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba84c8*/ float <ToEaseFunction>b__4_17(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8550*/ float <ToEaseFunction>b__4_18(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8648*/ float <ToEaseFunction>b__4_19(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba86c4*/ float <ToEaseFunction>b__4_20(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba873c*/ float <ToEaseFunction>b__4_21(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba87f0*/ float <ToEaseFunction>b__4_22(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba893c*/ float <ToEaseFunction>b__4_23(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8a84*/ float <ToEaseFunction>b__4_24(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8c5c*/ float <ToEaseFunction>b__4_25(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8c7c*/ float <ToEaseFunction>b__4_26(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8ca8*/ float <ToEaseFunction>b__4_27(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d14*/ float <ToEaseFunction>b__4_28(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d30*/ float <ToEaseFunction>b__4_29(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d34*/ float <ToEaseFunction>b__4_30(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d38*/ float <ToEaseFunction>b__4_31(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d3c*/ float <ToEaseFunction>b__4_32(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d40*/ float <ToEaseFunction>b__4_33(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d44*/ float <ToEaseFunction>b__4_34(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2ba8d48*/ float <ToEaseFunction>b__4_35(float time, float duration, float overshootOrAmplitude, float period);
                    }
                }

                class EaseCurve
                {
                    /*0x10*/ UnityEngine.AnimationCurve _animCurve;

                    /*0x2ba8d5c*/ EaseCurve(UnityEngine.AnimationCurve animCurve);
                    /*0x2ba8d8c*/ float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod);
                }

                class Flash
                {
                    static /*0x2ba6b68*/ float Ease(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2ba6c30*/ float EaseIn(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2ba6cfc*/ float EaseOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2ba6dd0*/ float EaseInOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2ba8e28*/ float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res);
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
