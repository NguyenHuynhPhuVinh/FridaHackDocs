class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x2b867b8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2b868ac*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
            static /*0x2b868b4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0x2b86a68*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOPitch(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0x2b86bf4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration);
            static /*0x2b86d9c*/ int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks);
            static /*0x2b86e04*/ int DOKill(UnityEngine.Audio.AudioMixer target, bool complete);
            static /*0x2b86e6c*/ int DOFlip(UnityEngine.Audio.AudioMixer target);
            static /*0x2b86ec4*/ int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay);
            static /*0x2b86f3c*/ int DOPause(UnityEngine.Audio.AudioMixer target);
            static /*0x2b86f94*/ int DOPlay(UnityEngine.Audio.AudioMixer target);
            static /*0x2b86fec*/ int DOPlayBackwards(UnityEngine.Audio.AudioMixer target);
            static /*0x2b87044*/ int DOPlayForward(UnityEngine.Audio.AudioMixer target);
            static /*0x2b8709c*/ int DORestart(UnityEngine.Audio.AudioMixer target);
            static /*0x2b870fc*/ int DORewind(UnityEngine.Audio.AudioMixer target);
            static /*0x2b87158*/ int DOSmoothRewind(UnityEngine.Audio.AudioMixer target);
            static /*0x2b871b0*/ int DOTogglePause(UnityEngine.Audio.AudioMixer target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0x2b86a60*/ <>c__DisplayClass0_0();
                /*0x2b87208*/ float <DOFade>b__0();
                /*0x2b87220*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0x2b86bec*/ <>c__DisplayClass1_0();
                /*0x2b87238*/ float <DOPitch>b__0();
                /*0x2b87250*/ void <DOPitch>b__1(float x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Audio.AudioMixer target;
                /*0x18*/ string floatName;

                /*0x2b86d94*/ <>c__DisplayClass2_0();
                /*0x2b87268*/ float <DOSetFloat>b__0();
                /*0x2b8729c*/ void <DOSetFloat>b__1(float x);
            }
        }

        class DOTweenModulePhysics
        {
            static /*0x2b872bc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x2b8747c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x2b87630*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x2b877e4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x2b87998*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x2b87b54*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x2b87df4*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2b882e0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2b88530*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2b887a0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x2b8896c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b87474*/ <>c__DisplayClass0_0();
                /*0x2b88b58*/ UnityEngine.Vector3 <DOMove>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0x2b88b50*/ <>c__DisplayClass10_0();
                /*0x2b88b70*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2b88b88*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b87628*/ <>c__DisplayClass1_0();
                /*0x2b88c74*/ UnityEngine.Vector3 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b877dc*/ <>c__DisplayClass2_0();
                /*0x2b88c8c*/ UnityEngine.Vector3 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b87990*/ <>c__DisplayClass3_0();
                /*0x2b88ca4*/ UnityEngine.Vector3 <DOMoveZ>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b87b4c*/ <>c__DisplayClass4_0();
                /*0x2b88cbc*/ UnityEngine.Quaternion <DORotate>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b87dec*/ <>c__DisplayClass5_0();
                /*0x2b88cd4*/ UnityEngine.Quaternion <DOLookAt>b__0();
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

                /*0x2b882d8*/ <>c__DisplayClass6_0();
                /*0x2b88cec*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x2b88d04*/ void <DOJump>b__1();
                /*0x2b88d2c*/ UnityEngine.Vector3 <DOJump>b__2();
                /*0x2b88d44*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x2b88d5c*/ void <DOJump>b__4();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b88528*/ <>c__DisplayClass7_0();
                /*0x2b88e10*/ UnityEngine.Vector3 <DOPath>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0x2b88798*/ <>c__DisplayClass8_0();
                /*0x2b88e28*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2b88e40*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x2b88964*/ <>c__DisplayClass9_0();
                /*0x2b88f2c*/ UnityEngine.Vector3 <DOPath>b__0();
            }
        }

        class DOTweenModulePhysics2D
        {
            static /*0x2b88f44*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b890fc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0x2b892ac*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0x2b8945c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration);
            static /*0x2b895ec*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2b89a0c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x2b89ce0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x2b890f4*/ <>c__DisplayClass0_0();
                /*0x2b89fd0*/ UnityEngine.Vector2 <DOMove>b__0();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x2b892a4*/ <>c__DisplayClass1_0();
                /*0x2b89fe8*/ UnityEngine.Vector2 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x2b89454*/ <>c__DisplayClass2_0();
                /*0x2b8a000*/ UnityEngine.Vector2 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x2b895e4*/ <>c__DisplayClass3_0();
                /*0x2b8a018*/ float <DORotate>b__0();
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

                /*0x2b89a04*/ <>c__DisplayClass4_0();
                /*0x2b8a030*/ UnityEngine.Vector2 <DOJump>b__0();
                /*0x2b8a048*/ void <DOJump>b__1(UnityEngine.Vector2 x);
                /*0x2b8a060*/ void <DOJump>b__2();
                /*0x2b8a088*/ UnityEngine.Vector2 <DOJump>b__3();
                /*0x2b8a0a0*/ void <DOJump>b__4(UnityEngine.Vector2 x);
                /*0x2b8a0b8*/ void <DOJump>b__5();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x2b89cd8*/ <>c__DisplayClass5_0();
                /*0x2b8a164*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x2b8a188*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0x2b89fc8*/ <>c__DisplayClass6_0();
                /*0x2b8a1a0*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x2b8a1b8*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }
        }

        class DOTweenModuleSprite
        {
            static /*0x2b8a29c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);
            static /*0x2b8a450*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration);
            static /*0x2b8a5dc*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration);
            static /*0x2b8a7a4*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0x2b8a448*/ <>c__DisplayClass0_0();
                /*0x2b8a9a4*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b8a9bc*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0x2b8a5d4*/ <>c__DisplayClass1_0();
                /*0x2b8a9d4*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b8a9ec*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.SpriteRenderer target;

                /*0x2b8a99c*/ <>c__DisplayClass3_0();
                /*0x2b8aa04*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b8aa10*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }
        }

        class DOTweenModuleUI
        {
            static /*0x2b8aa7c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, float endValue, float duration);
            static /*0x2b8ac08*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0x2b8adbc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, float endValue, float duration);
            static /*0x2b8af48*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0x2b8b0fc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x2b8b288*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x2b8b438*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration);
            static /*0x2b8b608*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8b7bc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8b970*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8bb24*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration);
            static /*0x2b8bcd8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, float endValue, float duration);
            static /*0x2b8be64*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration);
            static /*0x2b8c000*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8c1b4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x2b8c360*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x2b8c50c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x2b8c6c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x2b8c878*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x2b8ca28*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x2b8cbd8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8cd8c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8cf40*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration);
            static /*0x2b8d0dc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0x2b8d27c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0x2b8d41c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8d5d0*/ DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x2b8d78c*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut);
            static /*0x2b8d968*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato, float randomness, bool snapping, bool fadeOut);
            static /*0x2b8db4c*/ DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x2b8df60*/ DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x2b8e108*/ DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0x2b8e2a0*/ DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0x2b8e438*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping);
            static /*0x2b8e5dc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0x2b8e790*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator, System.Globalization.CultureInfo culture);
            static /*0x2b8e98c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, float endValue, float duration);
            static /*0x2b8eb18*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x2b8ed60*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0x2b8ef68*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0x2b8f170*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);

            class Utils
            {
                static /*0x2b8f378*/ UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to);
            }

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.CanvasGroup target;

                /*0x2b8ac00*/ <>c__DisplayClass0_0();
                /*0x2b8f500*/ float <DOFade>b__0();
                /*0x2b8f518*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x2b8bcd0*/ <>c__DisplayClass10_0();
                /*0x2b8f530*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b8f54c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x2b8be5c*/ <>c__DisplayClass11_0();
                /*0x2b8f564*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b8f580*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x2b8bff8*/ <>c__DisplayClass12_0();
                /*0x2b8f598*/ UnityEngine.Vector2 <DOScale>b__0();
                /*0x2b8f5b0*/ void <DOScale>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8c1ac*/ <>c__DisplayClass13_0();
                /*0x2b8f5c8*/ UnityEngine.Vector2 <DOAnchorPos>b__0();
                /*0x2b8f5e0*/ void <DOAnchorPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8c358*/ <>c__DisplayClass14_0();
                /*0x2b8f5f8*/ UnityEngine.Vector2 <DOAnchorPosX>b__0();
                /*0x2b8f610*/ void <DOAnchorPosX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8c504*/ <>c__DisplayClass15_0();
                /*0x2b8f628*/ UnityEngine.Vector2 <DOAnchorPosY>b__0();
                /*0x2b8f640*/ void <DOAnchorPosY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8c6c0*/ <>c__DisplayClass16_0();
                /*0x2b8f658*/ UnityEngine.Vector3 <DOAnchorPos3D>b__0();
                /*0x2b8f670*/ void <DOAnchorPos3D>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8c870*/ <>c__DisplayClass17_0();
                /*0x2b8f688*/ UnityEngine.Vector3 <DOAnchorPos3DX>b__0();
                /*0x2b8f6a0*/ void <DOAnchorPos3DX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8ca20*/ <>c__DisplayClass18_0();
                /*0x2b8f6b8*/ UnityEngine.Vector3 <DOAnchorPos3DY>b__0();
                /*0x2b8f6d0*/ void <DOAnchorPos3DY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8cbd0*/ <>c__DisplayClass19_0();
                /*0x2b8f6e8*/ UnityEngine.Vector3 <DOAnchorPos3DZ>b__0();
                /*0x2b8f700*/ void <DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0x2b8adb4*/ <>c__DisplayClass1_0();
                /*0x2b8f718*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b8f738*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8cd84*/ <>c__DisplayClass20_0();
                /*0x2b8f758*/ UnityEngine.Vector2 <DOAnchorMax>b__0();
                /*0x2b8f770*/ void <DOAnchorMax>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8cf38*/ <>c__DisplayClass21_0();
                /*0x2b8f788*/ UnityEngine.Vector2 <DOAnchorMin>b__0();
                /*0x2b8f7a0*/ void <DOAnchorMin>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8d0d4*/ <>c__DisplayClass22_0();
                /*0x2b8f7b8*/ UnityEngine.Vector2 <DOPivot>b__0();
                /*0x2b8f7d0*/ void <DOPivot>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8d274*/ <>c__DisplayClass23_0();
                /*0x2b8f7e8*/ UnityEngine.Vector2 <DOPivotX>b__0();
                /*0x2b8f800*/ void <DOPivotX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8d414*/ <>c__DisplayClass24_0();
                /*0x2b8f818*/ UnityEngine.Vector2 <DOPivotY>b__0();
                /*0x2b8f830*/ void <DOPivotY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8d5c8*/ <>c__DisplayClass25_0();
                /*0x2b8f848*/ UnityEngine.Vector2 <DOSizeDelta>b__0();
                /*0x2b8f860*/ void <DOSizeDelta>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8d784*/ <>c__DisplayClass26_0();
                /*0x2b8f878*/ UnityEngine.Vector3 <DOPunchAnchorPos>b__0();
                /*0x2b8f89c*/ void <DOPunchAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8d960*/ <>c__DisplayClass27_0();
                /*0x2b8f8b4*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0x2b8f8d8*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x2b8db44*/ <>c__DisplayClass28_0();
                /*0x2b8f8f0*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0x2b8f914*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.RectTransform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector2 endValue;

                /*0x2b8df58*/ <>c__DisplayClass29_0();
                /*0x2b8f92c*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__0();
                /*0x2b8f944*/ void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x);
                /*0x2b8f95c*/ void <DOJumpAnchorPos>b__2();
                /*0x2b8f984*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__3();
                /*0x2b8f99c*/ void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x);
                /*0x2b8f9b4*/ void <DOJumpAnchorPos>b__5();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0x2b8af40*/ <>c__DisplayClass2_0();
                /*0x2b8fa5c*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b8fa7c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x2b8e100*/ <>c__DisplayClass30_0();
                /*0x2b8fa9c*/ UnityEngine.Vector2 <DONormalizedPos>b__0();
                /*0x2b8fae4*/ void <DONormalizedPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x2b8e298*/ <>c__DisplayClass31_0();
                /*0x2b8fb24*/ float <DOHorizontalNormalizedPos>b__0();
                /*0x2b8fb3c*/ void <DOHorizontalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x2b8e430*/ <>c__DisplayClass32_0();
                /*0x2b8fb54*/ float <DOVerticalNormalizedPos>b__0();
                /*0x2b8fb6c*/ void <DOVerticalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.UI.Slider target;

                /*0x2b8e5d4*/ <>c__DisplayClass33_0();
                /*0x2b8fb84*/ float <DOValue>b__0();
                /*0x2b8fba4*/ void <DOValue>b__1(float x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x2b8e788*/ <>c__DisplayClass34_0();
                /*0x2b8fbc4*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b8fbe4*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ int v;
                /*0x18*/ UnityEngine.UI.Text target;
                /*0x20*/ bool addThousandsSeparator;
                /*0x28*/ System.Globalization.CultureInfo cInfo;

                /*0x2b8e984*/ <>c__DisplayClass35_0();
                /*0x2b8fc04*/ int <DOCounter>b__0();
                /*0x2b8fc0c*/ void <DOCounter>b__1(int x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x2b8eb10*/ <>c__DisplayClass36_0();
                /*0x2b8fc9c*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b8fcbc*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x2b8ed58*/ <>c__DisplayClass37_0();
                /*0x2b8fcdc*/ string <DOText>b__0();
                /*0x2b8fcfc*/ void <DOText>b__1(string x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Graphic target;

                /*0x2b8ef60*/ <>c__DisplayClass38_0();
                /*0x2b8fd1c*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b8fd28*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Image target;

                /*0x2b8f168*/ <>c__DisplayClass39_0();
                /*0x2b8fda4*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b8fdb0*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x2b8b0f4*/ <>c__DisplayClass3_0();
                /*0x2b8fe2c*/ UnityEngine.Color <DOColor>b__0();
                /*0x2b8fe4c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Text target;

                /*0x2b8f370*/ <>c__DisplayClass40_0();
                /*0x2b8fe6c*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x2b8fe78*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x2b8b280*/ <>c__DisplayClass4_0();
                /*0x2b8fef4*/ UnityEngine.Color <DOFade>b__0();
                /*0x2b8ff14*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x2b8b430*/ <>c__DisplayClass5_0();
                /*0x2b8ff34*/ float <DOFillAmount>b__0();
                /*0x2b8ff4c*/ void <DOFillAmount>b__1(float x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x2b8b7b4*/ <>c__DisplayClass7_0();
                /*0x2b8ff64*/ UnityEngine.Vector2 <DOFlexibleSize>b__0();
                /*0x2b8ffbc*/ void <DOFlexibleSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x2b8b968*/ <>c__DisplayClass8_0();
                /*0x2b9000c*/ UnityEngine.Vector2 <DOMinSize>b__0();
                /*0x2b90064*/ void <DOMinSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x2b8bb1c*/ <>c__DisplayClass9_0();
                /*0x2b900b4*/ UnityEngine.Vector2 <DOPreferredSize>b__0();
                /*0x2b9010c*/ void <DOPreferredSize>b__1(UnityEngine.Vector2 x);
            }
        }

        class DOTweenModuleUnityVersion
        {
            static /*0x2b9015c*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration);
            static /*0x2b90328*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration);
            static /*0x2b90500*/ UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x2b905f8*/ UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x2b906f0*/ UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x2b907e8*/ UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction);
            static /*0x2b908f4*/ UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction);
            static /*0x2b90a10*/ UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x2b90b08*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0x2b90d04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0x2b90f00*/ System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t);
            static /*0x2b90fd8*/ System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t);
            static /*0x2b910b0*/ System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t);
            static /*0x2b91188*/ System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x2b91270*/ System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x2b91358*/ System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2b90cfc*/ <>c__DisplayClass8_0();
                /*0x2b91430*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x2b91450*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x2b90ef8*/ <>c__DisplayClass9_0();
                /*0x2b91470*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x2b91490*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            struct <AsyncWaitForCompletion>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x2b914b0*/ void MoveNext();
                /*0x2b91794*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForElapsedLoops>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ int elapsedLoops;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x2b917fc*/ void MoveNext();
                /*0x2b91ae8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForKill>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x2b91b50*/ void MoveNext();
                /*0x2b91e24*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForPosition>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ float position;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x2b91e8c*/ void MoveNext();
                /*0x2b92190*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForRewind>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x2b921f8*/ void MoveNext();
                /*0x2b92500*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForStart>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x2b92568*/ void MoveNext();
                /*0x2b92844*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DOTweenCYInstruction
        {
            class WaitForCompletion : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x2b905c8*/ WaitForCompletion(DG.Tweening.Tween tween);
                /*0x2b928ac*/ bool get_keepWaiting();
            }

            class WaitForRewind : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x2b906c0*/ WaitForRewind(DG.Tweening.Tween tween);
                /*0x2b928dc*/ bool get_keepWaiting();
            }

            class WaitForKill : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x2b907b8*/ WaitForKill(DG.Tweening.Tween tween);
                /*0x2b9293c*/ bool get_keepWaiting();
            }

            class WaitForElapsedLoops : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ int elapsedLoops;

                /*0x2b908b8*/ WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops);
                /*0x2b92954*/ bool get_keepWaiting();
            }

            class WaitForPosition : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ float position;

                /*0x2b909cc*/ WaitForPosition(DG.Tweening.Tween tween, float position);
                /*0x2b92994*/ bool get_keepWaiting();
            }

            class WaitForStart : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x2b90ad8*/ WaitForStart(DG.Tweening.Tween tween);
                /*0x2b929ec*/ bool get_keepWaiting();
            }
        }

        class DOTweenModuleUtils
        {
            static /*0x0*/ bool _initialized;

            static /*0x2b92a1c*/ void Init();
            static /*0x2b92ac8*/ void Preserver();

            class Physics
            {
                static /*0x2b92b5c*/ void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
                static /*0x2b92c5c*/ bool HasRigidbody2D(UnityEngine.Component target);
                static /*0x2b92cf0*/ bool HasRigidbody(UnityEngine.Component target);
                static /*0x2b92d84*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> EDFE5273C1CAAA166E30DB9E6A21A310097785B3701B9FEFE6E40553614DE65E;
    static /*0x2b1*/ <PrivateImplementationDetails> F0F8289DCAFC7290AF451128FEBF852B0034FE53DEC6197BC6432D799FF565F2;

    struct __StaticArrayInitTypeSize=382
    {
    }

    struct __StaticArrayInitTypeSize=689
    {
    }
}
