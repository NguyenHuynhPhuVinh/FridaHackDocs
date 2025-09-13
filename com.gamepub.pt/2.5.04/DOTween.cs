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

            static /*0x2489550*/ DG.Tweening.Color2 op_Addition(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x24895e0*/ DG.Tweening.Color2 op_Subtraction(DG.Tweening.Color2 c1, DG.Tweening.Color2 c2);
            static /*0x2489670*/ DG.Tweening.Color2 op_Multiply(DG.Tweening.Color2 c1, float f);
            /*0xae6aec*/ Color2(UnityEngine.Color ca, UnityEngine.Color cb);
        }

        class TweenCallback : System.MulticastDelegate
        {
            /*0x24009fc*/ TweenCallback(object object, nint method);
            /*0x2405ba8*/ void Invoke();
            /*0x2405dd8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2405e04*/ void EndInvoke(System.IAsyncResult result);
        }

        class TweenCallback<T> : System.MulticastDelegate
        {
            TweenCallback(object object, nint method);
            void Invoke(T value);
            System.IAsyncResult BeginInvoke(T value, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class EaseFunction : System.MulticastDelegate
        {
            /*0x24928e8*/ EaseFunction(object object, nint method);
            /*0x2494870*/ float Invoke(float time, float duration, float overshootOrAmplitude, float period);
            /*0x2494ae4*/ System.IAsyncResult BeginInvoke(float time, float duration, float overshootOrAmplitude, float period, System.AsyncCallback callback, object object);
            /*0x2494bb0*/ float EndInvoke(System.IAsyncResult result);
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

            static /*0x2490650*/ DOTween();
            static /*0x248bde4*/ DG.Tweening.LogBehaviour get_logBehaviour();
            static /*0x248be48*/ void set_logBehaviour(DG.Tweening.LogBehaviour value);
            static /*0x248bf30*/ bool get_debugStoreTargetId();
            static /*0x248bfec*/ void set_debugStoreTargetId(bool value);
            static /*0x248c058*/ DG.Tweening.IDOTweenInit Init(System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x248c940*/ void AutoInit();
            static /*0x248c1e0*/ DG.Tweening.IDOTweenInit Init(DG.Tweening.Core.DOTweenSettings settings, System.Nullable<bool> recycleAllByDefault, System.Nullable<bool> useSafeMode, System.Nullable<DG.Tweening.LogBehaviour> logBehaviour);
            static /*0x248ccd0*/ void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity);
            static /*0x248cd44*/ void Clear(bool destroy);
            static /*0x248d0c4*/ void ClearCachedTweens();
            static /*0x248d120*/ int Validate();
            static /*0x248d17c*/ void ManualUpdate(float deltaTime, float unscaledDeltaTime);
            static /*0x248d34c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> To(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration);
            static /*0x248d3f0*/ DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, double endValue, float duration);
            static /*0x248d494*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, int endValue, float duration);
            static /*0x248d538*/ DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> To(DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, uint endValue, float duration);
            static /*0x248d5dc*/ DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, long endValue, float duration);
            static /*0x248d680*/ DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> To(DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, ulong endValue, float duration);
            static /*0x248d724*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> To(DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, string endValue, float duration);
            static /*0x248d7c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, UnityEngine.Vector2 endValue, float duration);
            static /*0x248d87c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x248d938*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, UnityEngine.Vector4 endValue, float duration);
            static /*0x248da04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, UnityEngine.Vector3 endValue, float duration);
            static /*0x248dac0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, UnityEngine.Color endValue, float duration);
            static /*0x248db8c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> To(DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, UnityEngine.Rect endValue, float duration);
            static /*0x248dc58*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, UnityEngine.RectOffset endValue, float duration);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration);
            static /*0x248dcfc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> ToAxis(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float endValue, float duration, DG.Tweening.AxisConstraint axisConstraint);
            static /*0x248ddbc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> ToAlpha(DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float endValue, float duration);
            static /*0x248dea4*/ DG.Tweening.Tweener To(DG.Tweening.Core.DOSetter<float> setter, float startValue, float endValue, float duration);
            static /*0x248e038*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Punch(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3 direction, float duration, int vibrato, float elasticity);
            static /*0x248e588*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, float strength, int vibrato, float randomness, bool ignoreZAxis, bool fadeOut);
            static /*0x248eb74*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x248e64c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> Shake(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut);
            static /*0x248e358*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> ToArray(DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, UnityEngine.Vector3[] endValues, float[] durations);
            static /*0x248ed90*/ DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> To(DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, DG.Tweening.Color2 endValue, float duration);
            static /*0x248ee50*/ DG.Tweening.Sequence Sequence();
            static /*0x248eff4*/ int CompleteAll(bool withCallbacks);
            static /*0x248f088*/ int Complete(object targetOrId, bool withCallbacks);
            static /*0x248f144*/ int CompleteAndReturnKilledTot();
            static /*0x248f1bc*/ int CompleteAndReturnKilledTot(object targetOrId);
            static /*0x248f24c*/ int CompleteAndReturnKilledTotExceptFor(object[] excludeTargetsOrIds);
            static /*0x248f2c8*/ int FlipAll();
            static /*0x248f340*/ int Flip(object targetOrId);
            static /*0x248f3d0*/ int GotoAll(float to, bool andPlay);
            static /*0x248f458*/ int Goto(object targetOrId, float to, bool andPlay);
            static /*0x248f508*/ int KillAll(bool complete);
            static /*0x248f5b0*/ int KillAll(bool complete, object[] idsOrTargetsToExclude);
            static /*0x248f6ec*/ int Kill(object targetOrId, bool complete);
            static /*0x248f7cc*/ int PauseAll();
            static /*0x248f844*/ int Pause(object targetOrId);
            static /*0x248f8d4*/ int PlayAll();
            static /*0x248f94c*/ int Play(object targetOrId);
            static /*0x248f9dc*/ int Play(object target, object id);
            static /*0x248fa80*/ int PlayBackwardsAll();
            static /*0x248faf8*/ int PlayBackwards(object targetOrId);
            static /*0x248fb88*/ int PlayBackwards(object target, object id);
            static /*0x248fc2c*/ int PlayForwardAll();
            static /*0x248fca4*/ int PlayForward(object targetOrId);
            static /*0x248fd34*/ int PlayForward(object target, object id);
            static /*0x248fdd8*/ int RestartAll(bool includeDelay);
            static /*0x248fe54*/ int Restart(object targetOrId, bool includeDelay, float changeDelayTo);
            static /*0x248ff04*/ int Restart(object target, object id, bool includeDelay, float changeDelayTo);
            static /*0x248ffbc*/ int RewindAll(bool includeDelay);
            static /*0x2490038*/ int Rewind(object targetOrId, bool includeDelay);
            static /*0x24900d8*/ int SmoothRewindAll();
            static /*0x2490150*/ int SmoothRewind(object targetOrId);
            static /*0x24901e0*/ int TogglePauseAll();
            static /*0x2490258*/ int TogglePause(object targetOrId);
            static /*0x24902e8*/ bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying);
            static /*0x249037c*/ int TotalPlayingTweens();
            static /*0x24903d8*/ System.Collections.Generic.List<DG.Tweening.Tween> PlayingTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x2490464*/ System.Collections.Generic.List<DG.Tweening.Tween> PausedTweens(System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x24904f0*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x24905a8*/ System.Collections.Generic.List<DG.Tweening.Tween> TweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
            static /*0x248d290*/ void InitCheck();
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            /*0x2490648*/ DOTween();

            class <>c__DisplayClass60_0
            {
                /*0x10*/ float v;
                /*0x18*/ DG.Tweening.Core.DOSetter<float> setter;

                /*0x2a25d68*/ <>c__DisplayClass60_0();
                /*0x2a25d70*/ float <To>b__0();
                /*0x2a25d78*/ void <To>b__1(float x);
            }
        }

        class DOVirtual
        {
            static /*0x2492430*/ DG.Tweening.Tweener Float(float from, float to, float duration, DG.Tweening.TweenCallback<float> onVirtualUpdate);
            static /*0x2492618*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType);
            static /*0x24926bc*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float overshoot);
            static /*0x2492768*/ float EasedValue(float from, float to, float lifetimePercentage, DG.Tweening.Ease easeType, float amplitude, float period);
            static /*0x24927ac*/ float EasedValue(float from, float to, float lifetimePercentage, UnityEngine.AnimationCurve easeCurve);
            static /*0x2492948*/ DG.Tweening.Tween DelayedCall(float delay, DG.Tweening.TweenCallback callback, bool ignoreTimeScale);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ float val;
                /*0x18*/ DG.Tweening.TweenCallback<float> onVirtualUpdate;

                /*0x2a2632c*/ <>c__DisplayClass0_0();
                /*0x2a26334*/ float <Float>b__0();
                /*0x2a2633c*/ void <Float>b__1(float x);
                /*0x2a26344*/ void <Float>b__2();
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
            static /*0x24930f4*/ DG.Tweening.EaseFunction StopMotion(int motionFps, System.Nullable<DG.Tweening.Ease> ease);
            static /*0x24947b8*/ DG.Tweening.EaseFunction StopMotion(int motionFps, UnityEngine.AnimationCurve animCurve);
            static /*0x24946f4*/ DG.Tweening.EaseFunction StopMotion(int motionFps, DG.Tweening.EaseFunction customEase);
            /*0x2494868*/ EaseFactory();

            class <>c__DisplayClass2_0
            {
                /*0x10*/ float motionDelay;
                /*0x18*/ DG.Tweening.EaseFunction customEase;

                /*0x2a2639c*/ <>c__DisplayClass2_0();
                /*0x2a263a4*/ float <StopMotion>b__0(float time, float duration, float overshootOrAmplitude, float period);
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
            static /*0x2405e10*/ void Complete(DG.Tweening.Tween t);
            static /*0x2405e18*/ void Complete(DG.Tweening.Tween t, bool withCallbacks);
            static /*0x24060d4*/ void Flip(DG.Tweening.Tween t);
            static /*0x2406268*/ void ForceInit(DG.Tweening.Tween t);
            static /*0x2405390*/ void Goto(DG.Tweening.Tween t, float to, bool andPlay);
            static /*0x24065a4*/ void Kill(DG.Tweening.Tween t, bool complete);
            static T Pause<T>(T t);
            static T Play<T>(T t);
            static /*0x2406d88*/ void PlayBackwards(DG.Tweening.Tween t);
            static /*0x2406ffc*/ void PlayForward(DG.Tweening.Tween t);
            static /*0x2407230*/ void Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
            static /*0x24074b8*/ void Rewind(DG.Tweening.Tween t, bool includeDelay);
            static /*0x240776c*/ void SmoothRewind(DG.Tweening.Tween t);
            static /*0x24079d8*/ void TogglePause(DG.Tweening.Tween t);
            static /*0x2407bd8*/ void GotoWaypoint(DG.Tweening.Tween t, int waypointIndex, bool andPlay);
            static /*0x2407f48*/ UnityEngine.YieldInstruction WaitForCompletion(DG.Tweening.Tween t);
            static /*0x2408034*/ UnityEngine.YieldInstruction WaitForRewind(DG.Tweening.Tween t);
            static /*0x2408120*/ UnityEngine.YieldInstruction WaitForKill(DG.Tweening.Tween t);
            static /*0x240820c*/ UnityEngine.YieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x2408308*/ UnityEngine.YieldInstruction WaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x2408404*/ UnityEngine.Coroutine WaitForStart(DG.Tweening.Tween t);
            static /*0x24084f4*/ int CompletedLoops(DG.Tweening.Tween t);
            static /*0x2408574*/ float Delay(DG.Tweening.Tween t);
            static /*0x2408600*/ float Duration(DG.Tweening.Tween t, bool includeLoops);
            static /*0x24052d8*/ float Elapsed(DG.Tweening.Tween t, bool includeLoops);
            static /*0x24086b8*/ float ElapsedPercentage(DG.Tweening.Tween t, bool includeLoops);
            static /*0x240878c*/ float ElapsedDirectionalPercentage(DG.Tweening.Tween t);
            static /*0x2408854*/ bool IsActive(DG.Tweening.Tween t);
            static /*0x240886c*/ bool IsBackwards(DG.Tweening.Tween t);
            static /*0x24088f4*/ bool IsComplete(DG.Tweening.Tween t);
            static /*0x240897c*/ bool IsInitialized(DG.Tweening.Tween t);
            static /*0x2408a04*/ bool IsPlaying(DG.Tweening.Tween t);
            static /*0x2408a8c*/ int Loops(DG.Tweening.Tween t);
            static /*0x2408b0c*/ UnityEngine.Vector3 PathGetPoint(DG.Tweening.Tween t, float pathPercentage);
            static /*0x2408d78*/ UnityEngine.Vector3[] PathGetDrawPoints(DG.Tweening.Tween t, int subdivisionsXSegment);
            static /*0x2408fc8*/ float PathLength(DG.Tweening.Tween t);
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

            static /*0x249af18*/ DG.Tweening.Sequence DoPrepend(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t);
            static /*0x249b028*/ DG.Tweening.Sequence DoInsert(DG.Tweening.Sequence inSequence, DG.Tweening.Tween t, float atPosition);
            static /*0x249b16c*/ DG.Tweening.Sequence DoAppendInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x249b190*/ DG.Tweening.Sequence DoPrependInterval(DG.Tweening.Sequence inSequence, float interval);
            static /*0x249b274*/ DG.Tweening.Sequence DoInsertCallback(DG.Tweening.Sequence inSequence, DG.Tweening.TweenCallback callback, float atPosition);
            static /*0x248eeec*/ void Setup(DG.Tweening.Sequence s);
            static /*0x249b48c*/ bool DoStartup(DG.Tweening.Sequence s);
            static /*0x249b5f4*/ bool DoApplyTween(DG.Tweening.Sequence s, float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x249bac0*/ bool ApplyInternalCycle(DG.Tweening.Sequence s, float fromPos, float toPos, DG.Tweening.Core.Enums.UpdateMode updateMode, bool useInverse, bool prevPosIsInverse, bool multiCycleStep);
            static /*0x249b930*/ void StableSortSequencedObjs(System.Collections.Generic.List<DG.Tweening.Core.ABSSequentiable> list);
            static /*0x249b8d0*/ bool IsAnyCallbackSet(DG.Tweening.Sequence s);
            /*0x249ae48*/ Sequence();
            /*0x249b33c*/ void Reset();
            /*0x249b3c8*/ bool Validate();
            /*0x249b488*/ bool Startup();
            /*0x249b5ec*/ bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class ShortcutExtensions
        {
            static /*0x23f9100*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAspect(UnityEngine.Camera target, float endValue, float duration);
            static /*0x23f9298*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Camera target, UnityEngine.Color endValue, float duration);
            static /*0x23f9458*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFarClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x23f95f0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFieldOfView(UnityEngine.Camera target, float endValue, float duration);
            static /*0x23f9788*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DONearClipPlane(UnityEngine.Camera target, float endValue, float duration);
            static /*0x23f9920*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOOrthoSize(UnityEngine.Camera target, float endValue, float duration);
            static /*0x23f9ab8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOPixelRect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x23f9c78*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DORect(UnityEngine.Camera target, UnityEngine.Rect endValue, float duration);
            static /*0x23f9e38*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x23fa0ac*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x23fa334*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x23fa5a8*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Camera target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x23fa830*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x23fa9f0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOIntensity(UnityEngine.Light target, float endValue, float duration);
            static /*0x23fab88*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOShadowStrength(UnityEngine.Light target, float endValue, float duration);
            static /*0x23fad20*/ DG.Tweening.Tweener DOColor(UnityEngine.LineRenderer target, DG.Tweening.Color2 startValue, DG.Tweening.Color2 endValue, float duration);
            static /*0x23faedc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x23fb09c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x23fb2c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x23fb4f8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, float duration);
            static /*0x23fb690*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x23fb894*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x23fba9c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, string property, float duration);
            static /*0x23fbca0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFloat(UnityEngine.Material target, float endValue, int propertyID, float duration);
            static /*0x23fbea8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x23fc050*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x23fc264*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, float duration);
            static /*0x23fc40c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, string property, float duration);
            static /*0x23fc620*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, string property, float duration);
            static /*0x23fc84c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> DOVector(UnityEngine.Material target, UnityEngine.Vector4 endValue, int propertyID, float duration);
            static /*0x23fca7c*/ DG.Tweening.Tweener DOResize(UnityEngine.TrailRenderer target, float toStartWidth, float toEndWidth, float duration);
            static /*0x23fcc18*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTime(UnityEngine.TrailRenderer target, float endValue, float duration);
            static /*0x23fcdb0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x23fcf94*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x23fd174*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x23fd338*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x23fd4fc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMove(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x23fd6c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveX(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x23fd88c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveY(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x23fda50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOLocalMoveZ(UnityEngine.Transform target, float endValue, float duration, bool snapping);
            static /*0x23fdc14*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x23fddd0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DORotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x23fdfb8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLocalRotate(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x23fe174*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> DOLocalRotateQuaternion(UnityEngine.Transform target, UnityEngine.Quaternion endValue, float duration);
            static /*0x23fe35c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float duration);
            static /*0x23fe50c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.Transform target, float endValue, float duration);
            static /*0x23fe6ac*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleX(UnityEngine.Transform target, float endValue, float duration);
            static /*0x23fe868*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleY(UnityEngine.Transform target, float endValue, float duration);
            static /*0x23fea24*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOScaleZ(UnityEngine.Transform target, float endValue, float duration);
            static /*0x23febe0*/ DG.Tweening.Tweener DOLookAt(UnityEngine.Transform target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x23fee20*/ DG.Tweening.Tweener DOPunchPosition(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x23ff0b0*/ DG.Tweening.Tweener DOPunchScale(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x23ff308*/ DG.Tweening.Tweener DOPunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x23ff560*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut);
            static /*0x23ff7ec*/ DG.Tweening.Tweener DOShakePosition(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut);
            static /*0x23ffa8c*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x23ffd00*/ DG.Tweening.Tweener DOShakeRotation(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x23fff88*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, float strength, int vibrato, float randomness, bool fadeOut);
            static /*0x240027c*/ DG.Tweening.Tweener DOShakeScale(UnityEngine.Transform target, float duration, UnityEngine.Vector3 strength, int vibrato, float randomness, bool fadeOut);
            static /*0x2400504*/ DG.Tweening.Sequence DOJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2400b0c*/ DG.Tweening.Sequence DOLocalJump(UnityEngine.Transform target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2400fc0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2401200*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2401448*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x2401614*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Transform target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x24017e8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOTimeScale(DG.Tweening.Tween target, float endValue, float duration);
            static /*0x2401980*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Light target, UnityEngine.Color endValue, float duration);
            static /*0x2401bcc*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, float duration);
            static /*0x2401e18*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, string property, float duration);
            static /*0x24020d4*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.Material target, UnityEngine.Color endValue, int propertyID, float duration);
            static /*0x2402394*/ DG.Tweening.Tweener DOBlendableMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x240257c*/ DG.Tweening.Tweener DOBlendableLocalMoveBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, bool snapping);
            static /*0x2402764*/ DG.Tweening.Tweener DOBlendableRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2402944*/ DG.Tweening.Tweener DOBlendableLocalRotateBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2402b24*/ DG.Tweening.Tweener DOBlendablePunchRotation(UnityEngine.Transform target, UnityEngine.Vector3 punch, float duration, int vibrato, float elasticity);
            static /*0x2402da8*/ DG.Tweening.Tweener DOBlendableScaleBy(UnityEngine.Transform target, UnityEngine.Vector3 byValue, float duration);
            static /*0x2402f78*/ int DOComplete(UnityEngine.Component target, bool withCallbacks);
            static /*0x2402fec*/ int DOComplete(UnityEngine.Material target, bool withCallbacks);
            static /*0x2403060*/ int DOKill(UnityEngine.Component target, bool complete);
            static /*0x24030d4*/ int DOKill(UnityEngine.Material target, bool complete);
            static /*0x2403148*/ int DOFlip(UnityEngine.Component target);
            static /*0x24031ac*/ int DOFlip(UnityEngine.Material target);
            static /*0x2403210*/ int DOGoto(UnityEngine.Component target, float to, bool andPlay);
            static /*0x2403294*/ int DOGoto(UnityEngine.Material target, float to, bool andPlay);
            static /*0x2403318*/ int DOPause(UnityEngine.Component target);
            static /*0x240337c*/ int DOPause(UnityEngine.Material target);
            static /*0x24033e0*/ int DOPlay(UnityEngine.Component target);
            static /*0x2403444*/ int DOPlay(UnityEngine.Material target);
            static /*0x24034a8*/ int DOPlayBackwards(UnityEngine.Component target);
            static /*0x240350c*/ int DOPlayBackwards(UnityEngine.Material target);
            static /*0x2403570*/ int DOPlayForward(UnityEngine.Component target);
            static /*0x24035d4*/ int DOPlayForward(UnityEngine.Material target);
            static /*0x2403638*/ int DORestart(UnityEngine.Component target, bool includeDelay);
            static /*0x24036b0*/ int DORestart(UnityEngine.Material target, bool includeDelay);
            static /*0x2403728*/ int DORewind(UnityEngine.Component target, bool includeDelay);
            static /*0x240379c*/ int DORewind(UnityEngine.Material target, bool includeDelay);
            static /*0x2403810*/ int DOSmoothRewind(UnityEngine.Component target);
            static /*0x2403874*/ int DOSmoothRewind(UnityEngine.Material target);
            static /*0x24038d8*/ int DOTogglePause(UnityEngine.Component target);
            static /*0x240393c*/ int DOTogglePause(UnityEngine.Material target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a2725c*/ <>c__DisplayClass0_0();
                /*0x2a27264*/ float <DOAspect>b__0();
                /*0x2a27280*/ void <DOAspect>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a275fc*/ <>c__DisplayClass1_0();
                /*0x2a27604*/ UnityEngine.Color <DOColor>b__0();
                /*0x2a27620*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a2793c*/ <>c__DisplayClass2_0();
                /*0x2a27944*/ float <DOFarClipPlane>b__0();
                /*0x2a27960*/ void <DOFarClipPlane>b__1(float x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a27c64*/ <>c__DisplayClass3_0();
                /*0x2a27c6c*/ float <DOFieldOfView>b__0();
                /*0x2a27c88*/ void <DOFieldOfView>b__1(float x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a27f24*/ <>c__DisplayClass4_0();
                /*0x2a27f2c*/ float <DONearClipPlane>b__0();
                /*0x2a27f48*/ void <DONearClipPlane>b__1(float x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a28390*/ <>c__DisplayClass5_0();
                /*0x2a28398*/ float <DOOrthoSize>b__0();
                /*0x2a283b4*/ void <DOOrthoSize>b__1(float x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a28990*/ <>c__DisplayClass6_0();
                /*0x2a28998*/ UnityEngine.Rect <DOPixelRect>b__0();
                /*0x2a289b4*/ void <DOPixelRect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a28f9c*/ <>c__DisplayClass7_0();
                /*0x2a28fa4*/ UnityEngine.Rect <DORect>b__0();
                /*0x2a28fc0*/ void <DORect>b__1(UnityEngine.Rect x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a28fdc*/ <>c__DisplayClass8_0();
                /*0x2a28fe4*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2a29010*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a29064*/ <>c__DisplayClass9_0();
                /*0x2a2906c*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2a29098*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a2729c*/ <>c__DisplayClass10_0();
                /*0x2a272a4*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2a272d0*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Camera target;

                /*0x2a2733c*/ <>c__DisplayClass11_0();
                /*0x2a27344*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2a27370*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x2a273dc*/ <>c__DisplayClass12_0();
                /*0x2a273e4*/ UnityEngine.Color <DOColor>b__0();
                /*0x2a27400*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x2a2741c*/ <>c__DisplayClass13_0();
                /*0x2a27424*/ float <DOIntensity>b__0();
                /*0x2a27440*/ void <DOIntensity>b__1(float x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.Light target;

                /*0x2a2745c*/ <>c__DisplayClass14_0();
                /*0x2a27464*/ float <DOShadowStrength>b__0();
                /*0x2a27480*/ void <DOShadowStrength>b__1(float x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ DG.Tweening.Color2 startValue;
                /*0x30*/ UnityEngine.LineRenderer target;

                /*0x2a2749c*/ <>c__DisplayClass15_0();
                /*0x2a274a4*/ DG.Tweening.Color2 <DOColor>b__0();
                /*0x2a274b0*/ void <DOColor>b__1(DG.Tweening.Color2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2a274dc*/ <>c__DisplayClass16_0();
                /*0x2a274e4*/ UnityEngine.Color <DOColor>b__0();
                /*0x2a27500*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2a2751c*/ <>c__DisplayClass17_0();
                /*0x2a27524*/ UnityEngine.Color <DOColor>b__0();
                /*0x2a27548*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2a2756c*/ <>c__DisplayClass18_0();
                /*0x2a27574*/ UnityEngine.Color <DOColor>b__0();
                /*0x2a27598*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2a275bc*/ <>c__DisplayClass19_0();
                /*0x2a275c4*/ UnityEngine.Color <DOFade>b__0();
                /*0x2a275e0*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2a2763c*/ <>c__DisplayClass20_0();
                /*0x2a27644*/ UnityEngine.Color <DOFade>b__0();
                /*0x2a27668*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2a2768c*/ <>c__DisplayClass21_0();
                /*0x2a27694*/ UnityEngine.Color <DOFade>b__0();
                /*0x2a276b8*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2a276dc*/ <>c__DisplayClass22_0();
                /*0x2a276e4*/ float <DOFloat>b__0();
                /*0x2a27708*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2a2772c*/ <>c__DisplayClass23_0();
                /*0x2a27734*/ float <DOFloat>b__0();
                /*0x2a27758*/ void <DOFloat>b__1(float x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2a2777c*/ <>c__DisplayClass24_0();
                /*0x2a27784*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x2a277a0*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2a277bc*/ <>c__DisplayClass25_0();
                /*0x2a277c4*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x2a277e8*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.Material target;

                /*0x2a2780c*/ <>c__DisplayClass26_0();
                /*0x2a27814*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x2a27830*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2a2784c*/ <>c__DisplayClass27_0();
                /*0x2a27854*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x2a27878*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ string property;

                /*0x2a2789c*/ <>c__DisplayClass28_0();
                /*0x2a278a4*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x2a278c8*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2a278ec*/ <>c__DisplayClass29_0();
                /*0x2a278f4*/ UnityEngine.Vector4 <DOVector>b__0();
                /*0x2a27918*/ void <DOVector>b__1(UnityEngine.Vector4 x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x2a2797c*/ <>c__DisplayClass30_0();
                /*0x2a27984*/ UnityEngine.Vector2 <DOResize>b__0();
                /*0x2a279d8*/ void <DOResize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.TrailRenderer target;

                /*0x2a27a24*/ <>c__DisplayClass31_0();
                /*0x2a27a2c*/ float <DOTime>b__0();
                /*0x2a27a48*/ void <DOTime>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27a64*/ <>c__DisplayClass32_0();
                /*0x2a27a6c*/ UnityEngine.Vector3 <DOMove>b__0();
                /*0x2a27a88*/ void <DOMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27aa4*/ <>c__DisplayClass33_0();
                /*0x2a27aac*/ UnityEngine.Vector3 <DOMoveX>b__0();
                /*0x2a27ac8*/ void <DOMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27ae4*/ <>c__DisplayClass34_0();
                /*0x2a27aec*/ UnityEngine.Vector3 <DOMoveY>b__0();
                /*0x2a27b08*/ void <DOMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27b24*/ <>c__DisplayClass35_0();
                /*0x2a27b2c*/ UnityEngine.Vector3 <DOMoveZ>b__0();
                /*0x2a27b48*/ void <DOMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27b64*/ <>c__DisplayClass36_0();
                /*0x2a27b6c*/ UnityEngine.Vector3 <DOLocalMove>b__0();
                /*0x2a27b88*/ void <DOLocalMove>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27ba4*/ <>c__DisplayClass37_0();
                /*0x2a27bac*/ UnityEngine.Vector3 <DOLocalMoveX>b__0();
                /*0x2a27bc8*/ void <DOLocalMoveX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27be4*/ <>c__DisplayClass38_0();
                /*0x2a27bec*/ UnityEngine.Vector3 <DOLocalMoveY>b__0();
                /*0x2a27c08*/ void <DOLocalMoveY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27c24*/ <>c__DisplayClass39_0();
                /*0x2a27c2c*/ UnityEngine.Vector3 <DOLocalMoveZ>b__0();
                /*0x2a27c48*/ void <DOLocalMoveZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27ca4*/ <>c__DisplayClass40_0();
                /*0x2a27cac*/ UnityEngine.Quaternion <DORotate>b__0();
                /*0x2a27cc8*/ void <DORotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27ce4*/ <>c__DisplayClass41_0();
                /*0x2a27cec*/ UnityEngine.Quaternion <DORotateQuaternion>b__0();
                /*0x2a27d08*/ void <DORotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass42_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27d24*/ <>c__DisplayClass42_0();
                /*0x2a27d2c*/ UnityEngine.Quaternion <DOLocalRotate>b__0();
                /*0x2a27d48*/ void <DOLocalRotate>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27d64*/ <>c__DisplayClass43_0();
                /*0x2a27d6c*/ UnityEngine.Quaternion <DOLocalRotateQuaternion>b__0();
                /*0x2a27d88*/ void <DOLocalRotateQuaternion>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass44_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27da4*/ <>c__DisplayClass44_0();
                /*0x2a27dac*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x2a27dc8*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass45_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27de4*/ <>c__DisplayClass45_0();
                /*0x2a27dec*/ UnityEngine.Vector3 <DOScale>b__0();
                /*0x2a27e08*/ void <DOScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass46_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27e24*/ <>c__DisplayClass46_0();
                /*0x2a27e2c*/ UnityEngine.Vector3 <DOScaleX>b__0();
                /*0x2a27e48*/ void <DOScaleX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass47_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27e64*/ <>c__DisplayClass47_0();
                /*0x2a27e6c*/ UnityEngine.Vector3 <DOScaleY>b__0();
                /*0x2a27e88*/ void <DOScaleY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27ea4*/ <>c__DisplayClass48_0();
                /*0x2a27eac*/ UnityEngine.Vector3 <DOScaleZ>b__0();
                /*0x2a27ec8*/ void <DOScaleZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass49_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27ee4*/ <>c__DisplayClass49_0();
                /*0x2a27eec*/ UnityEngine.Quaternion <DOLookAt>b__0();
                /*0x2a27f08*/ void <DOLookAt>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27f64*/ <>c__DisplayClass50_0();
                /*0x2a27f6c*/ UnityEngine.Vector3 <DOPunchPosition>b__0();
                /*0x2a27f88*/ void <DOPunchPosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27fa4*/ <>c__DisplayClass51_0();
                /*0x2a27fac*/ UnityEngine.Vector3 <DOPunchScale>b__0();
                /*0x2a27fc8*/ void <DOPunchScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a27fe4*/ <>c__DisplayClass52_0();
                /*0x2a27fec*/ UnityEngine.Vector3 <DOPunchRotation>b__0();
                /*0x2a28008*/ void <DOPunchRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a2803c*/ <>c__DisplayClass53_0();
                /*0x2a28044*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2a28060*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass54_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a2807c*/ <>c__DisplayClass54_0();
                /*0x2a28084*/ UnityEngine.Vector3 <DOShakePosition>b__0();
                /*0x2a280a0*/ void <DOShakePosition>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass55_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a280bc*/ <>c__DisplayClass55_0();
                /*0x2a280c4*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2a280e0*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a28114*/ <>c__DisplayClass56_0();
                /*0x2a2811c*/ UnityEngine.Vector3 <DOShakeRotation>b__0();
                /*0x2a28138*/ void <DOShakeRotation>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass57_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a2816c*/ <>c__DisplayClass57_0();
                /*0x2a28174*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x2a28190*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a281ac*/ <>c__DisplayClass58_0();
                /*0x2a281b4*/ UnityEngine.Vector3 <DOShakeScale>b__0();
                /*0x2a281d0*/ void <DOShakeScale>b__1(UnityEngine.Vector3 x);
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

                /*0x2a281ec*/ <>c__DisplayClass59_0();
                /*0x2a281f4*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x2a28210*/ void <DOJump>b__1(UnityEngine.Vector3 x);
                /*0x2a2822c*/ void <DOJump>b__2();
                /*0x2a28260*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x2a2827c*/ void <DOJump>b__4(UnityEngine.Vector3 x);
                /*0x2a28298*/ UnityEngine.Vector3 <DOJump>b__5();
                /*0x2a282b4*/ void <DOJump>b__6(UnityEngine.Vector3 x);
                /*0x2a282d0*/ void <DOJump>b__7();
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ UnityEngine.Transform target;
                /*0x18*/ bool offsetYSet;
                /*0x1c*/ float offsetY;
                /*0x20*/ DG.Tweening.Sequence s;
                /*0x28*/ UnityEngine.Vector3 endValue;
                /*0x34*/ float startPosY;

                /*0x2a283d0*/ <>c__DisplayClass60_0();
                /*0x2a283d8*/ UnityEngine.Vector3 <DOLocalJump>b__0();
                /*0x2a283f4*/ void <DOLocalJump>b__1(UnityEngine.Vector3 x);
                /*0x2a28410*/ UnityEngine.Vector3 <DOLocalJump>b__2();
                /*0x2a2842c*/ void <DOLocalJump>b__3(UnityEngine.Vector3 x);
                /*0x2a28448*/ UnityEngine.Vector3 <DOLocalJump>b__4();
                /*0x2a28464*/ void <DOLocalJump>b__5(UnityEngine.Vector3 x);
                /*0x2a28480*/ void <DOLocalJump>b__6();
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a28538*/ <>c__DisplayClass61_0();
                /*0x2a28540*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x2a2855c*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass62_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a28578*/ <>c__DisplayClass62_0();
                /*0x2a28580*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2a2859c*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass63_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a285b8*/ <>c__DisplayClass63_0();
                /*0x2a285c0*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x2a285dc*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ UnityEngine.Transform target;

                /*0x2a285f8*/ <>c__DisplayClass64_0();
                /*0x2a28600*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2a2861c*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass65_0
            {
                /*0x10*/ DG.Tweening.Tween target;

                /*0x2a28638*/ <>c__DisplayClass65_0();
                /*0x2a28640*/ float <DOTimeScale>b__0();
                /*0x2a2865c*/ void <DOTimeScale>b__1(float x);
            }

            class <>c__DisplayClass66_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Light target;

                /*0x2a28678*/ <>c__DisplayClass66_0();
                /*0x2a28680*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2a2868c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass67_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;

                /*0x2a28738*/ <>c__DisplayClass67_0();
                /*0x2a28740*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2a2874c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass68_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ string property;

                /*0x2a287f8*/ <>c__DisplayClass68_0();
                /*0x2a28800*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2a2880c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass69_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.Material target;
                /*0x28*/ int propertyID;

                /*0x2a288c4*/ <>c__DisplayClass69_0();
                /*0x2a288cc*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2a288d8*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2a289d0*/ <>c__DisplayClass70_0();
                /*0x2a289d8*/ UnityEngine.Vector3 <DOBlendableMoveBy>b__0();
                /*0x2a289e4*/ void <DOBlendableMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass71_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2a28a54*/ <>c__DisplayClass71_0();
                /*0x2a28a5c*/ UnityEngine.Vector3 <DOBlendableLocalMoveBy>b__0();
                /*0x2a28a68*/ void <DOBlendableLocalMoveBy>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2a28ad8*/ <>c__DisplayClass72_0();
                /*0x2a28ae0*/ UnityEngine.Quaternion <DOBlendableRotateBy>b__0();
                /*0x2a28aec*/ void <DOBlendableRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass73_0
            {
                /*0x10*/ UnityEngine.Quaternion to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2a28c20*/ <>c__DisplayClass73_0();
                /*0x2a28c28*/ UnityEngine.Quaternion <DOBlendableLocalRotateBy>b__0();
                /*0x2a28c34*/ void <DOBlendableLocalRotateBy>b__1(UnityEngine.Quaternion x);
            }

            class <>c__DisplayClass74_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2a28d68*/ <>c__DisplayClass74_0();
                /*0x2a28d70*/ UnityEngine.Vector3 <DOBlendablePunchRotation>b__0();
                /*0x2a28d7c*/ void <DOBlendablePunchRotation>b__1(UnityEngine.Vector3 v);
            }

            class <>c__DisplayClass75_0
            {
                /*0x10*/ UnityEngine.Vector3 to;
                /*0x20*/ UnityEngine.Transform target;

                /*0x2a28f18*/ <>c__DisplayClass75_0();
                /*0x2a28f20*/ UnityEngine.Vector3 <DOBlendableScaleBy>b__0();
                /*0x2a28f2c*/ void <DOBlendableScaleBy>b__1(UnityEngine.Vector3 x);
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

            static /*0x240d4b0*/ TweenParams();
            /*0x240d004*/ TweenParams();
            /*0x240d02c*/ DG.Tweening.TweenParams Clear();
            /*0x240d110*/ DG.Tweening.TweenParams SetAutoKill(bool autoKillOnCompletion);
            /*0x240d11c*/ DG.Tweening.TweenParams SetId(object id);
            /*0x240d124*/ DG.Tweening.TweenParams SetTarget(object target);
            /*0x240d12c*/ DG.Tweening.TweenParams SetLoops(int loops, System.Nullable<DG.Tweening.LoopType> loopType);
            /*0x240d1c8*/ DG.Tweening.TweenParams SetEase(DG.Tweening.Ease ease, System.Nullable<float> overshootOrAmplitude, System.Nullable<float> period);
            /*0x240d2e4*/ DG.Tweening.TweenParams SetEase(UnityEngine.AnimationCurve animCurve);
            /*0x240d3a0*/ DG.Tweening.TweenParams SetEase(DG.Tweening.EaseFunction customEase);
            /*0x240d3b0*/ DG.Tweening.TweenParams SetRecyclable(bool recyclable);
            /*0x240d3bc*/ DG.Tweening.TweenParams SetUpdate(bool isIndependentUpdate);
            /*0x240d440*/ DG.Tweening.TweenParams SetUpdate(DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            /*0x240d450*/ DG.Tweening.TweenParams OnStart(DG.Tweening.TweenCallback action);
            /*0x240d458*/ DG.Tweening.TweenParams OnPlay(DG.Tweening.TweenCallback action);
            /*0x240d460*/ DG.Tweening.TweenParams OnRewind(DG.Tweening.TweenCallback action);
            /*0x240d468*/ DG.Tweening.TweenParams OnUpdate(DG.Tweening.TweenCallback action);
            /*0x240d470*/ DG.Tweening.TweenParams OnStepComplete(DG.Tweening.TweenCallback action);
            /*0x240d478*/ DG.Tweening.TweenParams OnComplete(DG.Tweening.TweenCallback action);
            /*0x240d480*/ DG.Tweening.TweenParams OnKill(DG.Tweening.TweenCallback action);
            /*0x240d488*/ DG.Tweening.TweenParams OnWaypointChange(DG.Tweening.TweenCallback<int> action);
            /*0x240d490*/ DG.Tweening.TweenParams SetDelay(float delay);
            /*0x240d498*/ DG.Tweening.TweenParams SetRelative(bool isRelative);
            /*0x240d4a4*/ DG.Tweening.TweenParams SetSpeedBased(bool isSpeedBased);
        }

        class TweenSettingsExtensions
        {
            static T SetAutoKill<T>(T t);
            static T SetAutoKill<T>(T t, bool autoKillOnCompletion);
            static T SetId<T>(T t, object objectId);
            static T SetId<T>(T t, string stringId);
            static T SetId<T>(T t, int intId);
            static T SetLink<T>(T t, UnityEngine.GameObject gameObject);
            static T SetLink<T>(T t, UnityEngine.GameObject gameObject, DG.Tweening.LinkBehaviour behaviour);
            static T SetTarget<T>(T t, object target);
            static T SetLoops<T>(T t, int loops);
            static T SetLoops<T>(T t, int loops, DG.Tweening.LoopType loopType);
            static T SetEase<T>(T t, DG.Tweening.Ease ease);
            static T SetEase<T>(T t, DG.Tweening.Ease ease, float overshoot);
            static T SetEase<T>(T t, DG.Tweening.Ease ease, float amplitude, float period);
            static T SetEase<T>(T t, UnityEngine.AnimationCurve animCurve);
            static T SetEase<T>(T t, DG.Tweening.EaseFunction customEase);
            static T SetRecyclable<T>(T t);
            static T SetRecyclable<T>(T t, bool recyclable);
            static T SetUpdate<T>(T t, bool isIndependentUpdate);
            static T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType);
            static T SetUpdate<T>(T t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
            static T OnStart<T>(T t, DG.Tweening.TweenCallback action);
            static T OnPlay<T>(T t, DG.Tweening.TweenCallback action);
            static T OnPause<T>(T t, DG.Tweening.TweenCallback action);
            static T OnRewind<T>(T t, DG.Tweening.TweenCallback action);
            static T OnUpdate<T>(T t, DG.Tweening.TweenCallback action);
            static T OnStepComplete<T>(T t, DG.Tweening.TweenCallback action);
            static T OnComplete<T>(T t, DG.Tweening.TweenCallback action);
            static T OnKill<T>(T t, DG.Tweening.TweenCallback action);
            static T OnWaypointChange<T>(T t, DG.Tweening.TweenCallback<int> action);
            static T SetAs<T>(T t, DG.Tweening.Tween asTween);
            static T SetAs<T>(T t, DG.Tweening.TweenParams tweenParams);
            static /*0x2400a5c*/ DG.Tweening.Sequence Append(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x240d518*/ DG.Tweening.Sequence Prepend(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x2400ab4*/ DG.Tweening.Sequence Join(DG.Tweening.Sequence s, DG.Tweening.Tween t);
            static /*0x240d56c*/ DG.Tweening.Sequence Insert(DG.Tweening.Sequence s, float atPosition, DG.Tweening.Tween t);
            static /*0x240d5c0*/ DG.Tweening.Sequence AppendInterval(DG.Tweening.Sequence s, float interval);
            static /*0x240d600*/ DG.Tweening.Sequence PrependInterval(DG.Tweening.Sequence s, float interval);
            static /*0x240d640*/ DG.Tweening.Sequence AppendCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x240d688*/ DG.Tweening.Sequence PrependCallback(DG.Tweening.Sequence s, DG.Tweening.TweenCallback callback);
            static /*0x240d6d0*/ DG.Tweening.Sequence InsertCallback(DG.Tweening.Sequence s, float atPosition, DG.Tweening.TweenCallback callback);
            static T From<T>(T t);
            static T From<T>(T t, bool isRelative);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately);
            static /*0x240d714*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, float fromAlphaValue, bool setImmediately);
            static /*0x240d7d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> From(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, float fromValue, bool setImmediately);
            static T SetDelay<T>(T t, float delay);
            static T SetRelative<T>(T t);
            static T SetRelative<T>(T t, bool isRelative);
            static T SetSpeedBased<T>(T t);
            static T SetSpeedBased<T>(T t, bool isSpeedBased);
            static /*0x240d878*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool snapping);
            static /*0x240d890*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x240d8a8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x23fcf7c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x23fd158*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x240d8c4*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool snapping);
            static /*0x240d8dc*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x240d8f8*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool useShortest360Route);
            static /*0x240d914*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool alphaOnly);
            static /*0x240d92c*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool snapping);
            static /*0x240d944*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x23ff098*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool snapping);
            static /*0x240da30*/ DG.Tweening.Tweener SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, DG.Tweening.AxisConstraint axisConstraint, bool snapping);
            static /*0x240da4c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x240da68*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetOptions(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool closePath, DG.Tweening.AxisConstraint lockPosition, DG.Tweening.AxisConstraint lockRotation);
            static /*0x240da88*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 lookAtPosition, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x240dd08*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Transform lookAtTransform, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x240dd58*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, float lookAhead, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
            static /*0x240dad0*/ void SetPathForwardDirection(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, System.Nullable<UnityEngine.Vector3> forwardDirection, System.Nullable<UnityEngine.Vector3> up);
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

            static /*0x2405638*/ bool DoGoto(DG.Tweening.Tween t, float toPosition, int toCompletedLoops, DG.Tweening.Core.Enums.UpdateMode updateMode);
            static /*0x2405994*/ bool OnTweenCallback(DG.Tweening.TweenCallback callback, DG.Tweening.Tween t);
            static bool OnTweenCallback<T>(DG.Tweening.TweenCallback<T> callback, DG.Tweening.Tween t, T param);
            /*0x2405db4*/ Tween();
            /*0x24052a8*/ bool get_isRelative();
            /*0x24052b0*/ void set_isRelative(bool value);
            /*0x24052bc*/ bool get_active();
            /*0x24052c4*/ void set_active(bool value);
            /*0x24052d0*/ float get_fullPosition();
            /*0x2405388*/ void set_fullPosition(float value);
            /*0x2405580*/ bool get_playedOnce();
            /*0x2405588*/ void set_playedOnce(bool value);
            /*0x2405594*/ float get_position();
            /*0x240559c*/ void set_position(float value);
            /*0x24055a4*/ void Reset();
            bool Validate();
            /*0x2405630*/ float UpdateDelay(float elapsed);
            bool Startup();
            bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, DG.Tweening.Core.Enums.UpdateMode updateMode, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
        }

        class Tweener : DG.Tweening.Tween
        {
            /*0x120*/ bool hasManuallySetStartValue;
            /*0x121*/ bool isFromAllowed;

            static bool Setup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, T2 endValue, float duration, DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> plugin);
            static float DoUpdateDelay<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, float elapsed);
            static bool DoStartup<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeStartValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, float newDuration);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeEndValue<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newEndValue, float newDuration, bool snapStartValue);
            static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> DoChangeValues<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 newStartValue, T2 newEndValue, float newDuration);
            static bool DOStartupSpecials<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            static void DOStartupDurationBased<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            /*0x240dda4*/ Tweener();
            DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
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
                /*0x248ab2c*/ Color2Plugin();
                /*0x24896f8*/ void Reset(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x24896fc*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x2489934*/ void SetFrom(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 fromValue, bool setImmediately);
                /*0x2489a9c*/ DG.Tweening.Color2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t, DG.Tweening.Color2 value);
                /*0x2489aa8*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2489b14*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<DG.Tweening.Color2, DG.Tweening.Color2, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x2489b8c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, DG.Tweening.Color2 changeValue);
                /*0x2489b98*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<DG.Tweening.Color2> getter, DG.Tweening.Core.DOSetter<DG.Tweening.Color2> setter, float elapsed, DG.Tweening.Color2 startValue, DG.Tweening.Color2 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class DoublePlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<double, double, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2493008*/ DoublePlugin();
                /*0x2492d4c*/ void Reset(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2492d50*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2492df8*/ void SetFrom(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double fromValue, bool setImmediately);
                /*0x2492e88*/ double ConvertToStartValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t, double value);
                /*0x2492e8c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2492eac*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<double, double, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2492ecc*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, double changeValue);
                /*0x2492ee4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<double> getter, DG.Tweening.Core.DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class LongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<long, long, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2495efc*/ LongPlugin();
                /*0x2495ba0*/ void Reset(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2495ba4*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2495c44*/ void SetFrom(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long fromValue, bool setImmediately);
                /*0x2495cc8*/ long ConvertToStartValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t, long value);
                /*0x2495cd0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2495cf0*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<long, long, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2495d10*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, long changeValue);
                /*0x2495d28*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<long> getter, DG.Tweening.Core.DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UlongPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x2a22244*/ UlongPlugin();
                /*0x2a21f14*/ void Reset(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2a21f18*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2a21fb8*/ void SetFrom(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong fromValue, bool setImmediately);
                /*0x2a2203c*/ ulong ConvertToStartValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t, ulong value);
                /*0x2a22044*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2a22064*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<ulong, ulong, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2a22084*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, ulong changeValue);
                /*0x2a220a0*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<ulong> getter, DG.Tweening.Core.DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3ArrayPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>
            {
                /*0x2a23eec*/ Vector3ArrayPlugin();
                /*0x2a232cc*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x2a232e8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, bool isRelative);
                /*0x2a232ec*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3[] fromValue, bool setImmediately);
                /*0x2a232f0*/ UnityEngine.Vector3[] ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t, UnityEngine.Vector3 value);
                /*0x2a233fc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x2a234ec*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                /*0x2a235f0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, float unitsXSecond, UnityEngine.Vector3[] changeValue);
                /*0x2a236b4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.Vector3ArrayOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3[] startValue, UnityEngine.Vector3[] changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class PathPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>
            {
                static float MinLookAhead = 0.00009999999747378752;

                static /*0x2497208*/ DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> Get();
                /*0x24981e0*/ PathPlugin();
                /*0x24971c8*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x2497200*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, bool isRelative);
                /*0x2497204*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, DG.Tweening.Plugins.Core.PathCore.Path fromValue, bool setImmediately);
                /*0x249724c*/ DG.Tweening.Plugins.Core.PathCore.Path ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t, UnityEngine.Vector3 value);
                /*0x2497264*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x2497350*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> t);
                /*0x249773c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.PathOptions options, float unitsXSecond, DG.Tweening.Plugins.Core.PathCore.Path changeValue);
                /*0x2497758*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, DG.Tweening.Plugins.Core.PathCore.Path startValue, DG.Tweening.Plugins.Core.PathCore.Path changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x2497a08*/ void SetOrientation(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, DG.Tweening.Plugins.Core.PathCore.Path path, float pathPerc, UnityEngine.Vector3 tPos, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class ColorPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>
            {
                /*0x248b0d0*/ ColorPlugin();
                /*0x248ab80*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x248ab84*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, bool isRelative);
                /*0x248acb4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color fromValue, bool setImmediately);
                /*0x248adac*/ UnityEngine.Color ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t, UnityEngine.Color value);
                /*0x248adb0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x248ae0c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> t);
                /*0x248ae68*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.ColorOptions options, float unitsXSecond, UnityEngine.Color changeValue);
                /*0x248ae74*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.ColorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Color> getter, DG.Tweening.Core.DOSetter<UnityEngine.Color> setter, float elapsed, UnityEngine.Color startValue, UnityEngine.Color changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class IntPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<int, int, DG.Tweening.Plugins.Options.NoOptions>
            {
                /*0x249582c*/ IntPlugin();
                /*0x24954cc*/ void Reset(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x24954d0*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2495574*/ void SetFrom(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int fromValue, bool setImmediately);
                /*0x24955f8*/ int ConvertToStartValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t, int value);
                /*0x2495600*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2495624*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2495648*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, int changeValue);
                /*0x2495660*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<int> getter, DG.Tweening.Core.DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class QuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions>
            {
                /*0x2498f14*/ QuaternionPlugin();
                /*0x24986a4*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x24986a8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, bool isRelative);
                /*0x2498934*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately);
                /*0x24989f4*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t, UnityEngine.Quaternion value);
                /*0x2498a20*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x2498a58*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                /*0x2498be4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.QuaternionOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x2498c20*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.QuaternionOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectOffsetPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ UnityEngine.RectOffset _r;

                static /*0x2499d54*/ RectOffsetPlugin();
                /*0x2499d08*/ RectOffsetPlugin();
                /*0x2498f60*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2498f7c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x2499100*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset fromValue, bool setImmediately);
                /*0x2499184*/ UnityEngine.RectOffset ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.RectOffset value);
                /*0x249924c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2499364*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.RectOffset, UnityEngine.RectOffset, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x24994b8*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.RectOffset changeValue);
                /*0x2499590*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.RectOffset> getter, DG.Tweening.Core.DOSetter<UnityEngine.RectOffset> setter, float elapsed, UnityEngine.RectOffset startValue, UnityEngine.RectOffset changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class RectPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions>
            {
                /*0x249ad80*/ RectPlugin();
                /*0x2499dd0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x2499dd4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, bool isRelative);
                /*0x249a1ec*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect fromValue, bool setImmediately);
                /*0x249a508*/ UnityEngine.Rect ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t, UnityEngine.Rect value);
                /*0x249a50c*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x249a5ec*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> t);
                /*0x249a6f4*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.RectOptions options, float unitsXSecond, UnityEngine.Rect changeValue);
                /*0x249a7b4*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.RectOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Rect> getter, DG.Tweening.Core.DOSetter<UnityEngine.Rect> setter, float elapsed, UnityEngine.Rect startValue, UnityEngine.Rect changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class UintPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<uint, uint, DG.Tweening.Plugins.Options.UintOptions>
            {
                /*0x2a21ec8*/ UintPlugin();
                /*0x2a21b14*/ void Reset(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x2a21b18*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, bool isRelative);
                /*0x2a21bbc*/ void SetFrom(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint fromValue, bool setImmediately);
                /*0x2a21c40*/ uint ConvertToStartValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t, uint value);
                /*0x2a21c48*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x2a21c6c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<uint, uint, DG.Tweening.Plugins.Options.UintOptions> t);
                /*0x2a21ca0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.UintOptions options, float unitsXSecond, uint changeValue);
                /*0x2a21cbc*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.UintOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<uint> getter, DG.Tweening.Core.DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector2Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x2a23270*/ Vector2Plugin();
                /*0x2a22954*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a22958*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x2a22b60*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 fromValue, bool setImmediately);
                /*0x2a22d84*/ UnityEngine.Vector2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector2 value);
                /*0x2a22d88*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a22db4*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a22e24*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector2 changeValue);
                /*0x2a22e54*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector2> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector2> setter, float elapsed, UnityEngine.Vector2 startValue, UnityEngine.Vector2 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector4Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x2a25d10*/ Vector4Plugin();
                /*0x2a24bec*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a24bf0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x2a24f70*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 fromValue, bool setImmediately);
                /*0x2a25310*/ UnityEngine.Vector4 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector4 value);
                /*0x2a25314*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a25388*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector4, UnityEngine.Vector4, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a254b0*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector4 changeValue);
                /*0x2a254ec*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector4> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector4> setter, float elapsed, UnityEngine.Vector4 startValue, UnityEngine.Vector4 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class StringPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<string, string, DG.Tweening.Plugins.Options.StringOptions>
            {
                static /*0x0*/ System.Text.StringBuilder _Buffer;
                static /*0x8*/ System.Collections.Generic.List<char> _OpenedTags;

                static /*0x2404fb4*/ StringPlugin();
                /*0x2404f68*/ StringPlugin();
                /*0x2403e54*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, bool isRelative);
                /*0x2403ee0*/ void SetFrom(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string fromValue, bool setImmediately);
                /*0x2403f64*/ void Reset(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x2403f80*/ string ConvertToStartValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t, string value);
                /*0x2403f88*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x2403f8c*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> t);
                /*0x2404068*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.StringOptions options, float unitsXSecond, string changeValue);
                /*0x24040a8*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.StringOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<string> getter, DG.Tweening.Core.DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
                /*0x24045b0*/ System.Text.StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled);
                /*0x2404ce8*/ char[] ScrambledCharsToUse(DG.Tweening.Plugins.Options.StringOptions options);
            }

            class StringPluginExtensions
            {
                static /*0x0*/ char[] ScrambledCharsAll;
                static /*0x8*/ char[] ScrambledCharsUppercase;
                static /*0x10*/ char[] ScrambledCharsLowercase;
                static /*0x18*/ char[] ScrambledCharsNumerals;
                static /*0x20*/ int _lastRndSeed;

                static /*0x2405070*/ StringPluginExtensions();
                static /*0x24051f4*/ void ScrambleChars(char[] chars);
                static /*0x2404e0c*/ System.Text.StringBuilder AppendScrambledChars(System.Text.StringBuilder buffer, int length, char[] chars);
            }

            class FloatPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<float, float, DG.Tweening.Plugins.Options.FloatOptions>
            {
                /*0x2495480*/ FloatPlugin();
                /*0x2494fac*/ void Reset(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x2494fb0*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, bool isRelative);
                /*0x2495104*/ void SetFrom(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float fromValue, bool setImmediately);
                /*0x249523c*/ float ConvertToStartValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t, float value);
                /*0x2495240*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x2495264*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> t);
                /*0x2495288*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.FloatOptions options, float unitsXSecond, float changeValue);
                /*0x249529c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.FloatOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            class Vector3Plugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions>
            {
                /*0x2a24ba0*/ Vector3Plugin();
                /*0x2a23f38*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a23f3c*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, bool isRelative);
                /*0x2a241e0*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 fromValue, bool setImmediately);
                /*0x2a244bc*/ UnityEngine.Vector3 ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t, UnityEngine.Vector3 value);
                /*0x2a244c0*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a244f8*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> t);
                /*0x2a2459c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.VectorOptions options, float unitsXSecond, UnityEngine.Vector3 changeValue);
                /*0x2a245d8*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.VectorOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Vector3> getter, DG.Tweening.Core.DOSetter<UnityEngine.Vector3> setter, float elapsed, UnityEngine.Vector3 startValue, UnityEngine.Vector3 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
            }

            namespace Options
            {
                interface IPlugOptions
                {
                    void Reset();
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
                    /*0x64*/ UnityEngine.Quaternion startupRot;
                    /*0x74*/ float startupZRot;
                    /*0x78*/ bool addedExtraStartWp;
                    /*0x79*/ bool addedExtraEndWp;

                    /*0xae6bbc*/ void Reset();
                }

                struct QuaternionOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.RotateMode rotateMode;
                    /*0x14*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x18*/ UnityEngine.Vector3 up;

                    /*0xae6bc4*/ void Reset();
                }

                struct UintOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool isNegativeChangeValue;

                    /*0xb1eee4*/ void Reset();
                }

                struct Vector3ArrayOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;
                    /*0x18*/ float[] durations;

                    /*0xb1efcc*/ void Reset();
                }

                struct NoOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0xae6b7c*/ void Reset();
                }

                struct ColorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool alphaOnly;

                    /*0xae6b24*/ void Reset();
                }

                struct FloatOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0xae6b74*/ void Reset();
                }

                struct RectOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool snapping;

                    /*0xae6c18*/ void Reset();
                }

                struct StringOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ bool richTextEnabled;
                    /*0x14*/ DG.Tweening.ScrambleMode scrambleMode;
                    /*0x18*/ char[] scrambledChars;
                    /*0x20*/ int startValueStrippedLength;
                    /*0x24*/ int changeValueStrippedLength;

                    /*0xae5be4*/ void Reset();
                }

                struct VectorOptions : DG.Tweening.Plugins.Options.IPlugOptions
                {
                    /*0x10*/ DG.Tweening.AxisConstraint axisConstraint;
                    /*0x14*/ bool snapping;

                    /*0xb1f010*/ void Reset();
                }
            }

            namespace Core
            {
                interface ITPlugin<T1, T2, TPlugOptions, TPlugin>
                {
                }

                class SpecialPluginsUtils
                {
                    static /*0x24039a0*/ bool SetLookAt(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> t);
                    static /*0x2403ac4*/ bool SetPunch(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x2403c2c*/ bool SetShake(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                    static /*0x2403c68*/ bool SetCameraShakePosition(DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> t);
                }

                interface IPlugSetter<T1, T2, TPlugin, TPlugOptions>
                {
                    DG.Tweening.Core.DOGetter<T1> Getter();
                    DG.Tweening.Core.DOSetter<T1> Setter();
                    T2 EndValue();
                    TPlugOptions GetOptions();
                }

                interface ITweenPlugin
                {
                }

                class ABSTweenPlugin<T1, T2, TPlugOptions> : DG.Tweening.Plugins.Core.ITweenPlugin
                {
                    ABSTweenPlugin();
                    void Reset(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, bool isRelative);
                    void SetFrom(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately);
                    T2 ConvertToStartValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t, T1 value);
                    void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    void SetChangeValue(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                    float GetSpeedBasedDuration(TPlugOptions options, float unitsXSecond, T2 changeValue);
                    void EvaluateAndApply(TPlugOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<T1> getter, DG.Tweening.Core.DOSetter<T1> setter, float elapsed, T2 startValue, T2 changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
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

                    static DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin<T1, T2, TPlugOptions>();
                    static DG.Tweening.Plugins.Core.ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin<TPlugin, T1, T2, TPlugOptions>();
                    static /*0x248cea0*/ void PurgeAll();
                }

                namespace PathCore
                {
                    class CubicBezierDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x248bd4c*/ CubicBezierDecoder();
                        /*0x248bd44*/ CubicBezierDecoder();
                        /*0x248b2fc*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x248bb9c*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x248b6f4*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x248b8a4*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    struct ControlPoint
                    {
                        /*0x10*/ UnityEngine.Vector3 a;
                        /*0x1c*/ UnityEngine.Vector3 b;

                        static /*0x248b11c*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint op_Addition(DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, UnityEngine.Vector3 v);
                        /*0xae6b2c*/ ControlPoint(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                        /*0xae6b3c*/ string ToString();
                    }

                    class ABSPathDecoder
                    {
                        /*0x2488928*/ ABSPathDecoder();
                        void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                    }

                    class CatmullRomDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.ControlPoint[] _PartialControlPs;
                        static /*0x8*/ UnityEngine.Vector3[] _PartialWps;

                        static /*0x24894a4*/ CatmullRomDecoder();
                        /*0x248949c*/ CatmullRomDecoder();
                        /*0x2488a70*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x2489210*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x2488ca0*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x2488e50*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class LinearDecoder : DG.Tweening.Plugins.Core.PathCore.ABSPathDecoder
                    {
                        /*0x2495b98*/ LinearDecoder();
                        /*0x2495878*/ void FinalizePath(DG.Tweening.Plugins.Core.PathCore.Path p, UnityEngine.Vector3[] wps, bool isClosedPath);
                        /*0x2495a64*/ UnityEngine.Vector3 GetPoint(float perc, UnityEngine.Vector3[] wps, DG.Tweening.Plugins.Core.PathCore.Path p, DG.Tweening.Plugins.Core.PathCore.ControlPoint[] controlPoints);
                        /*0x24958a8*/ void SetTimeToLengthTables(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                        /*0x2495b94*/ void SetWaypointsLengths(DG.Tweening.Plugins.Core.PathCore.Path p, int subdivisions);
                    }

                    class Path
                    {
                        static /*0x0*/ DG.Tweening.Plugins.Core.PathCore.CatmullRomDecoder _catmullRomDecoder;
                        static /*0x8*/ DG.Tweening.Plugins.Core.PathCore.LinearDecoder _linearDecoder;
                        static /*0x10*/ DG.Tweening.Plugins.Core.PathCore.CubicBezierDecoder _cubicBezierDecoder;
                        /*0x10*/ float[] wpLengths;
                        /*0x18*/ DG.Tweening.PathType type;
                        /*0x1c*/ int subdivisionsXSegment;
                        /*0x20*/ int subdivisions;
                        /*0x28*/ UnityEngine.Vector3[] wps;
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

                        static /*0x2496680*/ UnityEngine.Vector3[] GetDrawPoints(DG.Tweening.Plugins.Core.PathCore.Path p, int drawSubdivisionsXSegment);
                        static /*0x2496770*/ void RefreshNonLinearDrawWps(DG.Tweening.Plugins.Core.PathCore.Path p);
                        static /*0x2496e48*/ void Draw(DG.Tweening.Plugins.Core.PathCore.Path p);
                        /*0x2495f4c*/ Path(DG.Tweening.PathType type, UnityEngine.Vector3[] waypoints, int subdivisionsXSegment, System.Nullable<UnityEngine.Color> gizmoColor);
                        /*0x2496358*/ Path();
                        /*0x24963bc*/ void FinalizePath(bool isClosedPath, DG.Tweening.AxisConstraint lockPositionAxes, UnityEngine.Vector3 currTargetVal);
                        /*0x2496474*/ UnityEngine.Vector3 GetPoint(float perc, bool convertToConstantPerc);
                        /*0x24964b8*/ float ConvertToConstantPathPerc(float perc);
                        /*0x24965d4*/ int GetWaypointIndexFromPerc(float perc, bool isMovingForward);
                        /*0x2496874*/ void Destroy();
                        /*0x24969a4*/ DG.Tweening.Plugins.Core.PathCore.Path CloneIncremental(int loopIncrement);
                        /*0x2496124*/ void AssignWaypoints(UnityEngine.Vector3[] newWps, bool cloneWps);
                        /*0x249620c*/ void AssignDecoder(DG.Tweening.PathType pathType);
                        /*0x2496e44*/ void Draw();
                    }
                }
            }
        }

        namespace CustomPlugins
        {
            class PureQuaternionPlugin : DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions>
            {
                static /*0x0*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin _plug;

                static /*0x249822c*/ DG.Tweening.CustomPlugins.PureQuaternionPlugin Plug();
                /*0x24982a4*/ PureQuaternionPlugin();
                /*0x24982f0*/ void Reset(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x24982f4*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, bool isRelative);
                /*0x24983f8*/ void SetFrom(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion fromValue, bool setImmediately);
                /*0x24984b8*/ UnityEngine.Quaternion ConvertToStartValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t, UnityEngine.Quaternion value);
                /*0x24984bc*/ void SetRelativeEndValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x2498518*/ void SetChangeValue(DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Quaternion, DG.Tweening.Plugins.Options.NoOptions> t);
                /*0x249853c*/ float GetSpeedBasedDuration(DG.Tweening.Plugins.Options.NoOptions options, float unitsXSecond, UnityEngine.Quaternion changeValue);
                /*0x249858c*/ void EvaluateAndApply(DG.Tweening.Plugins.Options.NoOptions options, DG.Tweening.Tween t, bool isRelative, DG.Tweening.Core.DOGetter<UnityEngine.Quaternion> getter, DG.Tweening.Core.DOSetter<UnityEngine.Quaternion> setter, float elapsed, UnityEngine.Quaternion startValue, UnityEngine.Quaternion changeValue, float duration, bool usingInversePosition, DG.Tweening.Core.Enums.UpdateNotice updateNotice);
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

                /*0x2488930*/ ABSSequentiable();
            }

            class DOGetter<T> : System.MulticastDelegate
            {
                DOGetter(object object, nint method);
                T Invoke();
                System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                T EndInvoke(System.IAsyncResult result);
            }

            class DOSetter<T> : System.MulticastDelegate
            {
                DOSetter(object object, nint method);
                void Invoke(T pNewValue);
                System.IAsyncResult BeginInvoke(T pNewValue, System.AsyncCallback callback, object object);
                void EndInvoke(System.IAsyncResult result);
            }

            class Debugger
            {
                static string _LogPrefix = "<color=#0099bc><b>DOTWEEN ► </b></colo";
                static /*0x0*/ int _logPriority;

                static /*0x2492a2c*/ int get_logPriority();
                static /*0x248cb84*/ void Log(object message);
                static /*0x24909ec*/ void LogWarning(object message, DG.Tweening.Tween t);
                static /*0x248ec44*/ void LogError(object message);
                static /*0x2491abc*/ void LogReport(object message);
                static /*0x2491c10*/ void LogSafeModeReport(object message);
                static /*0x2492a78*/ void LogInvalidTween(DG.Tweening.Tween t);
                static /*0x2492ac0*/ void LogNestedTween(DG.Tweening.Tween t);
                static /*0x2492b0c*/ void LogNullTween(DG.Tweening.Tween t);
                static /*0x2492b54*/ void LogNonPathTween(DG.Tweening.Tween t);
                static /*0x2492ba0*/ void LogMissingMaterialProperty(string propertyName);
                static /*0x2492bf8*/ void LogMissingMaterialProperty(int propertyId);
                static /*0x2492c84*/ void LogRemoveActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x2492ce8*/ void LogAddActiveTweenError(string errorInfo, DG.Tweening.Tween t);
                static /*0x248beb8*/ void SetLogPriority(DG.Tweening.LogBehaviour logBehaviour);
            }

            class DOTweenComponent : UnityEngine.MonoBehaviour, DG.Tweening.IDOTweenInit
            {
                /*0x18*/ int inspectorUpdater;
                /*0x1c*/ float _unscaledTime;
                /*0x20*/ float _unscaledDeltaTime;
                /*0x24*/ bool _paused;
                /*0x28*/ float _pausedTime;
                /*0x2c*/ bool _duplicateToDestroy;

                static /*0x248ca1c*/ void Create();
                static /*0x248cf90*/ void DestroyInstance();
                /*0x24920e4*/ DOTweenComponent();
                /*0x24907b4*/ void Awake();
                /*0x2490d00*/ void Start();
                /*0x2490e00*/ void Update();
                /*0x2491184*/ void LateUpdate();
                /*0x24912c4*/ void FixedUpdate();
                /*0x2491464*/ void OnDrawGizmos();
                /*0x24915cc*/ void OnDestroy();
                /*0x2491d54*/ void OnApplicationPause(bool pauseStatus);
                /*0x2491dbc*/ DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity);
                /*0x2491e3c*/ System.Collections.IEnumerator WaitForCompletion(DG.Tweening.Tween t);
                /*0x2491ea8*/ System.Collections.IEnumerator WaitForRewind(DG.Tweening.Tween t);
                /*0x2491f14*/ System.Collections.IEnumerator WaitForKill(DG.Tweening.Tween t);
                /*0x2491f80*/ System.Collections.IEnumerator WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
                /*0x2491ffc*/ System.Collections.IEnumerator WaitForPosition(DG.Tweening.Tween t, float position);
                /*0x2492078*/ System.Collections.IEnumerator WaitForStart(DG.Tweening.Tween t);

                class <WaitForCompletion>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2a25de0*/ <WaitForCompletion>d__15(int <>1__state);
                    /*0x2a25e0c*/ void System.IDisposable.Dispose();
                    /*0x2a25e10*/ bool MoveNext();
                    /*0x2a25e64*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2a25e6c*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a25eac*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForRewind>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2a26148*/ <WaitForRewind>d__16(int <>1__state);
                    /*0x2a26174*/ void System.IDisposable.Dispose();
                    /*0x2a26178*/ bool MoveNext();
                    /*0x2a261e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2a261f0*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a26230*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForKill>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2a25f90*/ <WaitForKill>d__17(int <>1__state);
                    /*0x2a25fbc*/ void System.IDisposable.Dispose();
                    /*0x2a25fc0*/ bool MoveNext();
                    /*0x2a2600c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2a26014*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a26054*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForElapsedLoops>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ int elapsedLoops;

                    /*0x2a25eb4*/ <WaitForElapsedLoops>d__18(int <>1__state);
                    /*0x2a25ee0*/ void System.IDisposable.Dispose();
                    /*0x2a25ee4*/ bool MoveNext();
                    /*0x2a25f40*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2a25f48*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a25f88*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForPosition>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;
                    /*0x28*/ float position;

                    /*0x2a2605c*/ <WaitForPosition>d__19(int <>1__state);
                    /*0x2a26088*/ void System.IDisposable.Dispose();
                    /*0x2a2608c*/ bool MoveNext();
                    /*0x2a260f8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2a26100*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a26140*/ object System.Collections.IEnumerator.get_Current();
                }

                class <WaitForStart>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ DG.Tweening.Tween t;

                    /*0x2a26238*/ <WaitForStart>d__20(int <>1__state);
                    /*0x2a26264*/ void System.IDisposable.Dispose();
                    /*0x2a26268*/ bool MoveNext();
                    /*0x2a262bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0x2a262c4*/ void System.Collections.IEnumerator.Reset();
                    /*0x2a26304*/ object System.Collections.IEnumerator.get_Current();
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

                /*0x2492358*/ DOTweenSettings();

                enum SettingsLocation
                {
                    AssetsDirectory = 0,
                    DOTweenDirectory = 1,
                    DemigiantDirectory = 2,
                }

                class SafeModeOptions
                {
                    /*0x10*/ DG.Tweening.Core.Enums.NestedTweenFailureBehaviour nestedTweenFailureBehaviour;

                    /*0x2a26324*/ SafeModeOptions();
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

                    /*0x2a2630c*/ ModulesSetup();
                }
            }

            class Extensions
            {
                static T SetSpecialStartupMode<T>(T t, DG.Tweening.Core.Enums.SpecialStartupMode mode);
                static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> Blendable<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
                static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> NoFrom<T1, T2, TPlugOptions>(DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> t);
            }

            class DOTweenExternalCommand
            {
                static /*0x0*/ System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> SetOrientationOnPath;

                static /*0x24920ec*/ void add_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x24921a8*/ void remove_SetOrientationOnPath(System.Action<DG.Tweening.Plugins.Options.PathOptions, DG.Tweening.Tween, UnityEngine.Quaternion, UnityEngine.Transform> value);
                static /*0x2492264*/ void Dispatch_SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
            }

            struct SafeModeReport
            {
                /*0x10*/ int <totMissingTargetOrFieldErrors>k__BackingField;
                /*0x14*/ int <totCallbackErrors>k__BackingField;
                /*0x18*/ int <totStartupErrors>k__BackingField;
                /*0x1c*/ int <totUnsetErrors>k__BackingField;

                /*0xae6c20*/ int get_totMissingTargetOrFieldErrors();
                /*0xae6c28*/ void set_totMissingTargetOrFieldErrors(int value);
                /*0xae6c30*/ int get_totCallbackErrors();
                /*0xae6c38*/ void set_totCallbackErrors(int value);
                /*0xae6c40*/ int get_totStartupErrors();
                /*0xae6c48*/ void set_totStartupErrors(int value);
                /*0xae6c50*/ int get_totUnsetErrors();
                /*0xae6c58*/ void set_totUnsetErrors(int value);
                /*0xae6c60*/ void Add(DG.Tweening.Core.SafeModeReport.SafeModeReportType type);
                /*0xae6c68*/ int GetTotErrors();

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
                /*0x23f90bc*/ SequenceCallback(float sequencedPosition, DG.Tweening.TweenCallback callback);
            }

            class TweenLink
            {
                /*0x10*/ UnityEngine.GameObject target;
                /*0x18*/ DG.Tweening.LinkBehaviour behaviour;
                /*0x1c*/ bool lastSeenActive;

                /*0x2409218*/ TweenLink(UnityEngine.GameObject target, DG.Tweening.LinkBehaviour behaviour);
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

                static /*0x2409270*/ TweenManager();
                static DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> GetTweener<T1, T2, TPlugOptions>();
                static /*0x240943c*/ DG.Tweening.Sequence GetSequence();
                static /*0x2409da0*/ void SetUpdateType(DG.Tweening.Tween t, DG.Tweening.UpdateType updateType, bool isIndependentUpdate);
                static /*0x240a05c*/ void AddActiveTweenToSequence(DG.Tweening.Tween t);
                static /*0x240a660*/ int DespawnAll();
                static /*0x24067dc*/ void Despawn(DG.Tweening.Tween t, bool modifyActiveLists);
                static /*0x240a8e0*/ void PurgeAll();
                static /*0x240aa84*/ void PurgePools();
                static /*0x240abcc*/ void AddTweenLink(DG.Tweening.Tween t, DG.Tweening.Core.TweenLink tweenLink);
                static /*0x240ae58*/ void RemoveTweenLink(DG.Tweening.Tween t);
                static /*0x240ab6c*/ void ResetCapacities();
                static /*0x240af48*/ void SetCapacities(int tweenersCapacity, int sequencesCapacity);
                static /*0x240b04c*/ int Validate();
                static /*0x240b604*/ void Update(DG.Tweening.UpdateType updateType, float deltaTime, float independentTime);
                static /*0x240bcc4*/ int FilteredOperation(DG.Tweening.Core.Enums.OperationType operationType, DG.Tweening.Core.Enums.FilterType filterType, object id, bool optionalBool, float optionalFloat, object optionalObj, object[] optionalArray);
                static /*0x2405fec*/ bool Complete(DG.Tweening.Tween t, bool modifyActiveLists, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x2406240*/ bool Flip(DG.Tweening.Tween t);
                static /*0x24063dc*/ void ForceInit(DG.Tweening.Tween t, bool isSequenced);
                static /*0x24064ac*/ bool Goto(DG.Tweening.Tween t, float to, bool andPlay, DG.Tweening.Core.Enums.UpdateMode updateMode);
                static /*0x240ae18*/ bool Pause(DG.Tweening.Tween t);
                static /*0x240ad98*/ bool Play(DG.Tweening.Tween t);
                static /*0x2406ef8*/ bool PlayBackwards(DG.Tweening.Tween t);
                static /*0x240716c*/ bool PlayForward(DG.Tweening.Tween t);
                static /*0x24073e0*/ bool Restart(DG.Tweening.Tween t, bool includeDelay, float changeDelayTo);
                static /*0x2407648*/ bool Rewind(DG.Tweening.Tween t, bool includeDelay);
                static /*0x24078dc*/ bool SmoothRewind(DG.Tweening.Tween t);
                static /*0x2407b48*/ bool TogglePause(DG.Tweening.Tween t);
                static /*0x240c764*/ int TotalPooledTweens();
                static /*0x240c7d0*/ int TotalPlayingTweens();
                static /*0x240c91c*/ System.Collections.Generic.List<DG.Tweening.Tween> GetActiveTweens(bool playing, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x240cb10*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensById(object id, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x240ce00*/ System.Collections.Generic.List<DG.Tweening.Tween> GetTweensByTarget(object target, bool playingOnly, System.Collections.Generic.List<DG.Tweening.Tween> fillableList);
                static /*0x240b494*/ void MarkForKilling(DG.Tweening.Tween t);
                static /*0x240ba60*/ void EvaluateTweenLink(DG.Tweening.Tween t);
                static /*0x240976c*/ void AddActiveTween(DG.Tweening.Tween t);
                static /*0x240b1f4*/ void ReorganizeActiveTweens();
                static /*0x240b528*/ void DespawnActiveTweens(System.Collections.Generic.List<DG.Tweening.Tween> tweens);
                static /*0x240a0bc*/ void RemoveActiveTween(DG.Tweening.Tween t);
                static /*0x240a888*/ void ClearTweenArray(DG.Tweening.Tween[] tweens);
                static /*0x2409ae8*/ void IncreaseCapacities(DG.Tweening.Core.TweenManager.CapacityIncreaseMode increaseMode);
                static /*0x240c69c*/ void ManageOnRewindCallbackWhenAlreadyRewinded(DG.Tweening.Tween t, bool isPlayBackwardsOrSmoothRewind);

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

                static /*0x2a22808*/ Utils();
                static /*0x2a22290*/ UnityEngine.Vector3 Vector3FromAngle(float degrees, float magnitude);
                static /*0x2a222e4*/ float Angle2D(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
                static /*0x2a22480*/ UnityEngine.Vector3 RotateAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion rotation);
                static /*0x2a224e0*/ bool Vector3AreApproximatelyEqual(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
                static /*0x2a22554*/ System.Type GetLooseScriptType(string typeName);
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

                TweenerCore();
                DG.Tweening.Tweener ChangeStartValue(object newStartValue, float newDuration);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
                DG.Tweening.Tweener ChangeEndValue(object newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeStartValue(T2 newStartValue, float newDuration);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, bool snapStartValue);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeEndValue(T2 newEndValue, float newDuration, bool snapStartValue);
                DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> ChangeValues(T2 newStartValue, T2 newEndValue, float newDuration);
                DG.Tweening.Tweener SetFrom(bool relative);
                DG.Tweening.Tweener SetFrom(T2 fromValue, bool setImmediately);
                void Reset();
                bool Validate();
                float UpdateDelay(float elapsed);
                bool Startup();
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
                    static /*0x2488938*/ float EaseIn(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x2488958*/ float EaseOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                    static /*0x2488a1c*/ float EaseInOut(float time, float duration, float unusedOvershootOrAmplitude, float unusedPeriod);
                }

                class EaseManager
                {
                    static float _PiOver2 = 1.5707963705062866;
                    static float _TwoPi = 6.2831854820251465;

                    static /*0x2494bdc*/ float Evaluate(DG.Tweening.Tween t, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2489ffc*/ float Evaluate(DG.Tweening.Ease easeType, DG.Tweening.EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x24931b4*/ DG.Tweening.EaseFunction ToEaseFunction(DG.Tweening.Ease ease);
                    static /*0x2494e34*/ bool IsFlashEase(DG.Tweening.Ease ease);

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

                        static /*0x2a26418*/ <>c();
                        /*0x2a26478*/ <>c();
                        /*0x2a26480*/ float <ToEaseFunction>b__4_0(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26488*/ float <ToEaseFunction>b__4_1(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26514*/ float <ToEaseFunction>b__4_2(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26598*/ float <ToEaseFunction>b__4_3(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a2662c*/ float <ToEaseFunction>b__4_4(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26638*/ float <ToEaseFunction>b__4_5(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a2664c*/ float <ToEaseFunction>b__4_6(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26690*/ float <ToEaseFunction>b__4_7(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a266a0*/ float <ToEaseFunction>b__4_8(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a266c0*/ float <ToEaseFunction>b__4_9(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26708*/ float <ToEaseFunction>b__4_10(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a2671c*/ float <ToEaseFunction>b__4_11(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26740*/ float <ToEaseFunction>b__4_12(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a2678c*/ float <ToEaseFunction>b__4_13(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a267a4*/ float <ToEaseFunction>b__4_14(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a267cc*/ float <ToEaseFunction>b__4_15(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26824*/ float <ToEaseFunction>b__4_16(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a268c4*/ float <ToEaseFunction>b__4_17(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26964*/ float <ToEaseFunction>b__4_18(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26a78*/ float <ToEaseFunction>b__4_19(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26b10*/ float <ToEaseFunction>b__4_20(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26bb0*/ float <ToEaseFunction>b__4_21(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26c90*/ float <ToEaseFunction>b__4_22(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26dfc*/ float <ToEaseFunction>b__4_23(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a26f64*/ float <ToEaseFunction>b__4_24(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27158*/ float <ToEaseFunction>b__4_25(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27178*/ float <ToEaseFunction>b__4_26(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a271a4*/ float <ToEaseFunction>b__4_27(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27210*/ float <ToEaseFunction>b__4_28(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27218*/ float <ToEaseFunction>b__4_29(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27220*/ float <ToEaseFunction>b__4_30(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27228*/ float <ToEaseFunction>b__4_31(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27230*/ float <ToEaseFunction>b__4_32(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27238*/ float <ToEaseFunction>b__4_33(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27240*/ float <ToEaseFunction>b__4_34(float time, float duration, float overshootOrAmplitude, float period);
                        /*0x2a27248*/ float <ToEaseFunction>b__4_35(float time, float duration, float overshootOrAmplitude, float period);
                    }
                }

                class EaseCurve
                {
                    /*0x10*/ UnityEngine.AnimationCurve _animCurve;

                    /*0x24928bc*/ EaseCurve(UnityEngine.AnimationCurve animCurve);
                    /*0x2493054*/ float Evaluate(float time, float duration, float unusedOvershoot, float unusedPeriod);
                }

                class Flash
                {
                    static /*0x2494bfc*/ float Ease(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2494c78*/ float EaseIn(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2494cf8*/ float EaseOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2494d80*/ float EaseInOut(float time, float duration, float overshootOrAmplitude, float period);
                    static /*0x2494e44*/ float WeightedEase(float overshootOrAmplitude, float period, int stepIndex, float stepDuration, float dir, float res);
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
