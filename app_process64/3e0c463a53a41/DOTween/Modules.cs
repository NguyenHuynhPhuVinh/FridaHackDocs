class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3fc35b4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3fc36a8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace DG
{
    namespace Tweening
    {
        class DOTweenModuleAudio
        {
            static /*0x3fc36b0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0x3fc3864*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOPitch(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0x3fc39f0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration);
            static /*0x3fc3b98*/ int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks);
            static /*0x3fc3c00*/ int DOKill(UnityEngine.Audio.AudioMixer target, bool complete);
            static /*0x3fc3c68*/ int DOFlip(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3cc0*/ int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay);
            static /*0x3fc3d38*/ int DOPause(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3d90*/ int DOPlay(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3de8*/ int DOPlayBackwards(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3e40*/ int DOPlayForward(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3e98*/ int DORestart(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3ef8*/ int DORewind(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3f54*/ int DOSmoothRewind(UnityEngine.Audio.AudioMixer target);
            static /*0x3fc3fac*/ int DOTogglePause(UnityEngine.Audio.AudioMixer target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0x3fc385c*/ <>c__DisplayClass0_0();
                /*0x3fc4004*/ float <DOFade>b__0();
                /*0x3fc4020*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0x3fc39e8*/ <>c__DisplayClass1_0();
                /*0x3fc403c*/ float <DOPitch>b__0();
                /*0x3fc4058*/ void <DOPitch>b__1(float x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Audio.AudioMixer target;
                /*0x18*/ string floatName;

                /*0x3fc3b90*/ <>c__DisplayClass2_0();
                /*0x3fc4074*/ float <DOSetFloat>b__0();
                /*0x3fc40a8*/ void <DOSetFloat>b__1(float x);
            }
        }

        class DOTweenModulePhysics
        {
            static /*0x3fc40cc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fc428c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x3fc4440*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x3fc45f4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x3fc47a8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fc4964*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fc4bd0*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fc50c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fc5318*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fc5588*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fc5754*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc4284*/ <>c__DisplayClass0_0();
                /*0x3fc5940*/ UnityEngine.Vector3 <DOMove>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0x3fc5938*/ <>c__DisplayClass10_0();
                /*0x3fc595c*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fc5978*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc4438*/ <>c__DisplayClass1_0();
                /*0x3fc5a64*/ UnityEngine.Vector3 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc45ec*/ <>c__DisplayClass2_0();
                /*0x3fc5a80*/ UnityEngine.Vector3 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc47a0*/ <>c__DisplayClass3_0();
                /*0x3fc5a9c*/ UnityEngine.Vector3 <DOMoveZ>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc495c*/ <>c__DisplayClass4_0();
                /*0x3fc5ab8*/ UnityEngine.Quaternion <DORotate>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc4bc8*/ <>c__DisplayClass5_0();
                /*0x3fc5ad4*/ UnityEngine.Quaternion <DOLookAt>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector3 endValue;
                /*0x40*/ DG.Tweening.Tween yTween;

                /*0x3fc50c0*/ <>c__DisplayClass6_0();
                /*0x3fc5af0*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x3fc5b0c*/ void <DOJump>b__1();
                /*0x3fc5b34*/ UnityEngine.Vector3 <DOJump>b__2();
                /*0x3fc5b50*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x3fc5b6c*/ void <DOJump>b__4();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc5310*/ <>c__DisplayClass7_0();
                /*0x3fc5c20*/ UnityEngine.Vector3 <DOPath>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0x3fc5580*/ <>c__DisplayClass8_0();
                /*0x3fc5c3c*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fc5c58*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fc574c*/ <>c__DisplayClass9_0();
                /*0x3fc5d44*/ UnityEngine.Vector3 <DOPath>b__0();
            }
        }

        class DOTweenModulePhysics2D
        {
            static /*0x3fc5d60*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fc5f18*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0x3fc60c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0x3fc6278*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration);
            static /*0x3fc6408*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fc682c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fc6b04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fc6dfc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fc6fc8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fc5f10*/ <>c__DisplayClass0_0();
                /*0x3fc71b8*/ UnityEngine.Vector2 <DOMove>b__0();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fc60c0*/ <>c__DisplayClass1_0();
                /*0x3fc71d4*/ UnityEngine.Vector2 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fc6270*/ <>c__DisplayClass2_0();
                /*0x3fc71f0*/ UnityEngine.Vector2 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fc6400*/ <>c__DisplayClass3_0();
                /*0x3fc720c*/ float <DORotate>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector2 endValue;
                /*0x38*/ DG.Tweening.Tween yTween;

                /*0x3fc6824*/ <>c__DisplayClass4_0();
                /*0x3fc7228*/ UnityEngine.Vector2 <DOJump>b__0();
                /*0x3fc7244*/ void <DOJump>b__1(UnityEngine.Vector2 x);
                /*0x3fc7260*/ void <DOJump>b__2();
                /*0x3fc7288*/ UnityEngine.Vector2 <DOJump>b__3();
                /*0x3fc72a4*/ void <DOJump>b__4(UnityEngine.Vector2 x);
                /*0x3fc72c0*/ void <DOJump>b__5();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fc6afc*/ <>c__DisplayClass5_0();
                /*0x3fc736c*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fc7390*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0x3fc6df4*/ <>c__DisplayClass6_0();
                /*0x3fc73ac*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fc73c8*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fc6fc0*/ <>c__DisplayClass7_0();
                /*0x3fc74ac*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fc74d0*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0x3fc71b0*/ <>c__DisplayClass8_0();
                /*0x3fc74ec*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fc7508*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }
        }

        class DOTweenModuleSprite
        {
            static /*0x3fc75ec*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);
            static /*0x3fc77a0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration);
            static /*0x3fc792c*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration);
            static /*0x3fc7b08*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0x3fc7798*/ <>c__DisplayClass0_0();
                /*0x3fc7d08*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fc7d24*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0x3fc7924*/ <>c__DisplayClass1_0();
                /*0x3fc7d40*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fc7d5c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.SpriteRenderer target;

                /*0x3fc7d00*/ <>c__DisplayClass3_0();
                /*0x3fc7d78*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fc7d84*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }
        }

        class DOTweenModuleUI
        {
            static /*0x3fc7df0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, float endValue, float duration);
            static /*0x3fc7f7c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0x3fc8130*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, float endValue, float duration);
            static /*0x3fc82bc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0x3fc8470*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3fc85fc*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3fc87ac*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration);
            static /*0x3fc8990*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fc8b44*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fc8cf8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fc8eac*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration);
            static /*0x3fc9060*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, float endValue, float duration);
            static /*0x3fc91ec*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fc9388*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fc953c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fc96e8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fc9894*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fc9a50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fc9c00*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fc9db0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fc9f60*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fca114*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fca2c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fca464*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0x3fca604*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0x3fca7a4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fca958*/ DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x3fcab14*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fcacfc*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fcaef4*/ DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fcb30c*/ DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fcb4b4*/ DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0x3fcb64c*/ DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0x3fcb7e4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping);
            static /*0x3fcb988*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0x3fcbb3c*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator, System.Globalization.CultureInfo culture);
            static /*0x3fcbd5c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, float endValue, float duration);
            static /*0x3fcbee8*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x3fcc118*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0x3fcc320*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0x3fcc528*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0x3fcc730*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> DOShapeCircle(UnityEngine.RectTransform target, UnityEngine.Vector2 center, float endValueDegrees, float duration, bool relativeCenter, bool snapping);

            class Utils
            {
                static /*0x3fcc91c*/ UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to);
            }

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.CanvasGroup target;

                /*0x3fc7f74*/ <>c__DisplayClass0_0();
                /*0x3fccaa4*/ float <DOFade>b__0();
                /*0x3fccac0*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x3fc9058*/ <>c__DisplayClass10_0();
                /*0x3fccadc*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fccafc*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x3fc91e4*/ <>c__DisplayClass11_0();
                /*0x3fccb18*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fccb38*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x3fc9380*/ <>c__DisplayClass12_0();
                /*0x3fccb54*/ UnityEngine.Vector2 <DOScale>b__0();
                /*0x3fccb70*/ void <DOScale>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc9534*/ <>c__DisplayClass13_0();
                /*0x3fccb8c*/ UnityEngine.Vector2 <DOAnchorPos>b__0();
                /*0x3fccba8*/ void <DOAnchorPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc96e0*/ <>c__DisplayClass14_0();
                /*0x3fccbc4*/ UnityEngine.Vector2 <DOAnchorPosX>b__0();
                /*0x3fccbe0*/ void <DOAnchorPosX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc988c*/ <>c__DisplayClass15_0();
                /*0x3fccbfc*/ UnityEngine.Vector2 <DOAnchorPosY>b__0();
                /*0x3fccc18*/ void <DOAnchorPosY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc9a48*/ <>c__DisplayClass16_0();
                /*0x3fccc34*/ UnityEngine.Vector3 <DOAnchorPos3D>b__0();
                /*0x3fccc50*/ void <DOAnchorPos3D>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc9bf8*/ <>c__DisplayClass17_0();
                /*0x3fccc6c*/ UnityEngine.Vector3 <DOAnchorPos3DX>b__0();
                /*0x3fccc88*/ void <DOAnchorPos3DX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc9da8*/ <>c__DisplayClass18_0();
                /*0x3fccca4*/ UnityEngine.Vector3 <DOAnchorPos3DY>b__0();
                /*0x3fcccc0*/ void <DOAnchorPos3DY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fc9f58*/ <>c__DisplayClass19_0();
                /*0x3fcccdc*/ UnityEngine.Vector3 <DOAnchorPos3DZ>b__0();
                /*0x3fcccf8*/ void <DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0x3fc8128*/ <>c__DisplayClass1_0();
                /*0x3fccd14*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fccd38*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fca10c*/ <>c__DisplayClass20_0();
                /*0x3fccd5c*/ UnityEngine.Vector2 <DOAnchorMax>b__0();
                /*0x3fccd78*/ void <DOAnchorMax>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fca2c0*/ <>c__DisplayClass21_0();
                /*0x3fccd94*/ UnityEngine.Vector2 <DOAnchorMin>b__0();
                /*0x3fccdb0*/ void <DOAnchorMin>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fca45c*/ <>c__DisplayClass22_0();
                /*0x3fccdcc*/ UnityEngine.Vector2 <DOPivot>b__0();
                /*0x3fccde8*/ void <DOPivot>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fca5fc*/ <>c__DisplayClass23_0();
                /*0x3fcce04*/ UnityEngine.Vector2 <DOPivotX>b__0();
                /*0x3fcce20*/ void <DOPivotX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fca79c*/ <>c__DisplayClass24_0();
                /*0x3fcce3c*/ UnityEngine.Vector2 <DOPivotY>b__0();
                /*0x3fcce58*/ void <DOPivotY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fca950*/ <>c__DisplayClass25_0();
                /*0x3fcce74*/ UnityEngine.Vector2 <DOSizeDelta>b__0();
                /*0x3fcce90*/ void <DOSizeDelta>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fcab0c*/ <>c__DisplayClass26_0();
                /*0x3fcceac*/ UnityEngine.Vector3 <DOPunchAnchorPos>b__0();
                /*0x3fcced0*/ void <DOPunchAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fcacf4*/ <>c__DisplayClass27_0();
                /*0x3fcceec*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0x3fccf10*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fcaeec*/ <>c__DisplayClass28_0();
                /*0x3fccf2c*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0x3fccf50*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.RectTransform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector2 endValue;

                /*0x3fcb304*/ <>c__DisplayClass29_0();
                /*0x3fccf6c*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__0();
                /*0x3fccf88*/ void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x);
                /*0x3fccfa4*/ void <DOJumpAnchorPos>b__2();
                /*0x3fccfcc*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__3();
                /*0x3fccfe8*/ void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x);
                /*0x3fcd004*/ void <DOJumpAnchorPos>b__5();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0x3fc82b4*/ <>c__DisplayClass2_0();
                /*0x3fcd0ac*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fcd0d0*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x3fcb4ac*/ <>c__DisplayClass30_0();
                /*0x3fcd0f4*/ UnityEngine.Vector2 <DONormalizedPos>b__0();
                /*0x3fcd13c*/ void <DONormalizedPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x3fcb644*/ <>c__DisplayClass31_0();
                /*0x3fcd17c*/ float <DOHorizontalNormalizedPos>b__0();
                /*0x3fcd198*/ void <DOHorizontalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x3fcb7dc*/ <>c__DisplayClass32_0();
                /*0x3fcd1b4*/ float <DOVerticalNormalizedPos>b__0();
                /*0x3fcd1d0*/ void <DOVerticalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.UI.Slider target;

                /*0x3fcb980*/ <>c__DisplayClass33_0();
                /*0x3fcd1ec*/ float <DOValue>b__0();
                /*0x3fcd210*/ void <DOValue>b__1(float x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x3fcbb34*/ <>c__DisplayClass34_0();
                /*0x3fcd234*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcd258*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ int v;
                /*0x18*/ UnityEngine.UI.Text target;
                /*0x20*/ bool addThousandsSeparator;
                /*0x28*/ System.Globalization.CultureInfo cInfo;

                /*0x3fcbd54*/ <>c__DisplayClass35_0();
                /*0x3fcd27c*/ int <DOCounter>b__0();
                /*0x3fcd284*/ void <DOCounter>b__1(int x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x3fcbee0*/ <>c__DisplayClass36_0();
                /*0x3fcd314*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fcd338*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x3fcc110*/ <>c__DisplayClass37_0();
                /*0x3fcd35c*/ string <DOText>b__0();
                /*0x3fcd380*/ void <DOText>b__1(string x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Graphic target;

                /*0x3fcc318*/ <>c__DisplayClass38_0();
                /*0x3fcd3a4*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcd3b0*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Image target;

                /*0x3fcc520*/ <>c__DisplayClass39_0();
                /*0x3fcd42c*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcd438*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3fc8468*/ <>c__DisplayClass3_0();
                /*0x3fcd4b4*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fcd4d8*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Text target;

                /*0x3fcc728*/ <>c__DisplayClass40_0();
                /*0x3fcd4fc*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fcd508*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fcc914*/ <>c__DisplayClass41_0();
                /*0x3fcd584*/ UnityEngine.Vector2 <DOShapeCircle>b__0();
                /*0x3fcd5a0*/ void <DOShapeCircle>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3fc85f4*/ <>c__DisplayClass4_0();
                /*0x3fcd5bc*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fcd5e0*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3fc87a4*/ <>c__DisplayClass5_0();
                /*0x3fcd604*/ float <DOFillAmount>b__0();
                /*0x3fcd620*/ void <DOFillAmount>b__1(float x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x3fc8b3c*/ <>c__DisplayClass7_0();
                /*0x3fcd63c*/ UnityEngine.Vector2 <DOFlexibleSize>b__0();
                /*0x3fcd694*/ void <DOFlexibleSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x3fc8cf0*/ <>c__DisplayClass8_0();
                /*0x3fcd6e4*/ UnityEngine.Vector2 <DOMinSize>b__0();
                /*0x3fcd73c*/ void <DOMinSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x3fc8ea4*/ <>c__DisplayClass9_0();
                /*0x3fcd78c*/ UnityEngine.Vector2 <DOPreferredSize>b__0();
                /*0x3fcd7e4*/ void <DOPreferredSize>b__1(UnityEngine.Vector2 x);
            }
        }

        class DOTweenModuleUnityVersion
        {
            static /*0x3fcd834*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration);
            static /*0x3fcda14*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration);
            static /*0x3fcdc00*/ UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fcdcf8*/ UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fcddf0*/ UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fcdee8*/ UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction);
            static /*0x3fcdff4*/ UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction);
            static /*0x3fce110*/ UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fce208*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0x3fce404*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0x3fce600*/ System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t);
            static /*0x3fce6e4*/ System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t);
            static /*0x3fce7c8*/ System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t);
            static /*0x3fce8ac*/ System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x3fce998*/ System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x3fcea8c*/ System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fce3fc*/ <>c__DisplayClass8_0();
                /*0x3fceb70*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x3fceb94*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fce5f8*/ <>c__DisplayClass9_0();
                /*0x3fcebb8*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x3fcebdc*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            struct <AsyncWaitForCompletion>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fcec00*/ void MoveNext();
                /*0x3fceec4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForElapsedLoops>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ int elapsedLoops;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fcef2c*/ void MoveNext();
                /*0x3fcf1f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForKill>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fcf260*/ void MoveNext();
                /*0x3fcf510*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForPosition>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ float position;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fcf578*/ void MoveNext();
                /*0x3fcf85c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForRewind>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fcf8c4*/ void MoveNext();
                /*0x3fcfbac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForStart>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fcfc14*/ void MoveNext();
                /*0x3fcfecc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DOTweenCYInstruction
        {
            class WaitForCompletion : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fcdcc8*/ WaitForCompletion(DG.Tweening.Tween tween);
                /*0x3fcff34*/ bool get_keepWaiting();
            }

            class WaitForRewind : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fcddc0*/ WaitForRewind(DG.Tweening.Tween tween);
                /*0x3fcff64*/ bool get_keepWaiting();
            }

            class WaitForKill : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fcdeb8*/ WaitForKill(DG.Tweening.Tween tween);
                /*0x3fcffc4*/ bool get_keepWaiting();
            }

            class WaitForElapsedLoops : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ int elapsedLoops;

                /*0x3fcdfb8*/ WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops);
                /*0x3fcffe0*/ bool get_keepWaiting();
            }

            class WaitForPosition : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ float position;

                /*0x3fce0cc*/ WaitForPosition(DG.Tweening.Tween tween, float position);
                /*0x3fd0020*/ bool get_keepWaiting();
            }

            class WaitForStart : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fce1d8*/ WaitForStart(DG.Tweening.Tween tween);
                /*0x3fd0078*/ bool get_keepWaiting();
            }
        }

        class DOTweenModuleUtils
        {
            static /*0x0*/ bool _initialized;

            static /*0x3fd00ac*/ void Init();
            static /*0x3fd0158*/ void Preserver();

            class Physics
            {
                static /*0x3fd01ec*/ void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
                static /*0x3fd02ec*/ bool HasRigidbody2D(UnityEngine.Component target);
                static /*0x3fd0378*/ bool HasRigidbody(UnityEngine.Component target);
                static /*0x3fd0404*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> EDFE5273C1CAAA166E30DB9E6A21A310097785B3701B9FEFE6E40553614DE65E;
    static /*0x2b1*/ <PrivateImplementationDetails> F6E279F3C1A6F64134F0DEFED8B9AA64DA17052806857BC852853D4416637F88;

    struct __StaticArrayInitTypeSize=508
    {
    }

    struct __StaticArrayInitTypeSize=689
    {
    }
}
