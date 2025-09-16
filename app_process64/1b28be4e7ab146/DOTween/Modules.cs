class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3fcf288*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3fcf37c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
            static /*0x3fcf384*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0x3fcf538*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOPitch(UnityEngine.AudioSource target, float endValue, float duration);
            static /*0x3fcf6c4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration);
            static /*0x3fcf86c*/ int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks);
            static /*0x3fcf8d4*/ int DOKill(UnityEngine.Audio.AudioMixer target, bool complete);
            static /*0x3fcf93c*/ int DOFlip(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcf994*/ int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay);
            static /*0x3fcfa0c*/ int DOPause(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfa64*/ int DOPlay(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfabc*/ int DOPlayBackwards(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfb14*/ int DOPlayForward(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfb6c*/ int DORestart(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfbcc*/ int DORewind(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfc28*/ int DOSmoothRewind(UnityEngine.Audio.AudioMixer target);
            static /*0x3fcfc80*/ int DOTogglePause(UnityEngine.Audio.AudioMixer target);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0x3fcf530*/ <>c__DisplayClass0_0();
                /*0x3fcfcd8*/ float <DOFade>b__0();
                /*0x3fcfcf4*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.AudioSource target;

                /*0x3fcf6bc*/ <>c__DisplayClass1_0();
                /*0x3fcfd10*/ float <DOPitch>b__0();
                /*0x3fcfd2c*/ void <DOPitch>b__1(float x);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Audio.AudioMixer target;
                /*0x18*/ string floatName;

                /*0x3fcf864*/ <>c__DisplayClass2_0();
                /*0x3fcfd48*/ float <DOSetFloat>b__0();
                /*0x3fcfd7c*/ void <DOSetFloat>b__1(float x);
            }
        }

        class DOTweenModulePhysics
        {
            static /*0x3fcfda0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fcff60*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x3fd0114*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x3fd02c8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping);
            static /*0x3fd047c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode);
            static /*0x3fd0638*/ DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint, System.Nullable<UnityEngine.Vector3> up);
            static /*0x3fd08a4*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fd0d9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fd0fec*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fd125c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fd1428*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fcff58*/ <>c__DisplayClass0_0();
                /*0x3fd1614*/ UnityEngine.Vector3 <DOMove>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0x3fd160c*/ <>c__DisplayClass10_0();
                /*0x3fd1630*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fd164c*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd010c*/ <>c__DisplayClass1_0();
                /*0x3fd1738*/ UnityEngine.Vector3 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd02c0*/ <>c__DisplayClass2_0();
                /*0x3fd1754*/ UnityEngine.Vector3 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd0474*/ <>c__DisplayClass3_0();
                /*0x3fd1770*/ UnityEngine.Vector3 <DOMoveZ>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd0630*/ <>c__DisplayClass4_0();
                /*0x3fd178c*/ UnityEngine.Quaternion <DORotate>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd089c*/ <>c__DisplayClass5_0();
                /*0x3fd17a8*/ UnityEngine.Quaternion <DOLookAt>b__0();
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

                /*0x3fd0d94*/ <>c__DisplayClass6_0();
                /*0x3fd17c4*/ UnityEngine.Vector3 <DOJump>b__0();
                /*0x3fd17e0*/ void <DOJump>b__1();
                /*0x3fd1808*/ UnityEngine.Vector3 <DOJump>b__2();
                /*0x3fd1824*/ UnityEngine.Vector3 <DOJump>b__3();
                /*0x3fd1840*/ void <DOJump>b__4();
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd0fe4*/ <>c__DisplayClass7_0();
                /*0x3fd18f4*/ UnityEngine.Vector3 <DOPath>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody target;

                /*0x3fd1254*/ <>c__DisplayClass8_0();
                /*0x3fd1910*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fd192c*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Rigidbody target;

                /*0x3fd1420*/ <>c__DisplayClass9_0();
                /*0x3fd1a18*/ UnityEngine.Vector3 <DOPath>b__0();
            }
        }

        class DOTweenModulePhysics2D
        {
            static /*0x3fd1a34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd1bec*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0x3fd1d9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping);
            static /*0x3fd1f4c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration);
            static /*0x3fd20dc*/ DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fd2500*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fd27d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, UnityEngine.Vector2[] path, float duration, DG.Tweening.PathType pathType, DG.Tweening.PathMode pathMode, int resolution, System.Nullable<UnityEngine.Color> gizmoColor);
            static /*0x3fd2ad0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
            static /*0x3fd2c9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fd1be4*/ <>c__DisplayClass0_0();
                /*0x3fd2e8c*/ UnityEngine.Vector2 <DOMove>b__0();
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fd1d94*/ <>c__DisplayClass1_0();
                /*0x3fd2ea8*/ UnityEngine.Vector2 <DOMoveX>b__0();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fd1f44*/ <>c__DisplayClass2_0();
                /*0x3fd2ec4*/ UnityEngine.Vector2 <DOMoveY>b__0();
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fd20d4*/ <>c__DisplayClass3_0();
                /*0x3fd2ee0*/ float <DORotate>b__0();
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

                /*0x3fd24f8*/ <>c__DisplayClass4_0();
                /*0x3fd2efc*/ UnityEngine.Vector2 <DOJump>b__0();
                /*0x3fd2f18*/ void <DOJump>b__1(UnityEngine.Vector2 x);
                /*0x3fd2f34*/ void <DOJump>b__2();
                /*0x3fd2f5c*/ UnityEngine.Vector2 <DOJump>b__3();
                /*0x3fd2f78*/ void <DOJump>b__4(UnityEngine.Vector2 x);
                /*0x3fd2f94*/ void <DOJump>b__5();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fd27d0*/ <>c__DisplayClass5_0();
                /*0x3fd3040*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fd3064*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0x3fd2ac8*/ <>c__DisplayClass6_0();
                /*0x3fd3080*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fd309c*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Rigidbody2D target;

                /*0x3fd2c94*/ <>c__DisplayClass7_0();
                /*0x3fd3180*/ UnityEngine.Vector3 <DOPath>b__0();
                /*0x3fd31a4*/ void <DOPath>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Transform trans;
                /*0x18*/ UnityEngine.Rigidbody2D target;

                /*0x3fd2e84*/ <>c__DisplayClass8_0();
                /*0x3fd31c0*/ UnityEngine.Vector3 <DOLocalPath>b__0();
                /*0x3fd31dc*/ void <DOLocalPath>b__1(UnityEngine.Vector3 x);
            }
        }

        class DOTweenModuleSprite
        {
            static /*0x3fd32c0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);
            static /*0x3fd3474*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration);
            static /*0x3fd3600*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration);
            static /*0x3fd37dc*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0x3fd346c*/ <>c__DisplayClass0_0();
                /*0x3fd39dc*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fd39f8*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.SpriteRenderer target;

                /*0x3fd35f8*/ <>c__DisplayClass1_0();
                /*0x3fd3a14*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fd3a30*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.SpriteRenderer target;

                /*0x3fd39d4*/ <>c__DisplayClass3_0();
                /*0x3fd3a4c*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fd3a58*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }
        }

        class DOTweenModuleUI
        {
            static /*0x3fd3ac4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFade(UnityEngine.CanvasGroup target, float endValue, float duration);
            static /*0x3fd3c50*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0x3fd3e04*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Graphic target, float endValue, float duration);
            static /*0x3fd3f90*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0x3fd4144*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3fd42d0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3fd4480*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration);
            static /*0x3fd4664*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd4818*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd49cc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd4b80*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration);
            static /*0x3fd4d34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Outline target, float endValue, float duration);
            static /*0x3fd4ec0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fd505c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd5210*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fd53bc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fd5568*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping);
            static /*0x3fd5724*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fd58d4*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fd5a84*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping);
            static /*0x3fd5c34*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd5de8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd5f9c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration);
            static /*0x3fd6138*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotX(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0x3fd62d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOPivotY(UnityEngine.RectTransform target, float endValue, float duration);
            static /*0x3fd6478*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd662c*/ DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato, float elasticity, bool snapping);
            static /*0x3fd67e8*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fd69d0*/ DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato, float randomness, bool snapping, bool fadeOut, DG.Tweening.ShakeRandomnessMode randomnessMode);
            static /*0x3fd6bc8*/ DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping);
            static /*0x3fd6fe0*/ DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping);
            static /*0x3fd7188*/ DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0x3fd7320*/ DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping);
            static /*0x3fd74b8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping);
            static /*0x3fd765c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0x3fd7810*/ DG.Tweening.Core.TweenerCore<int, int, DG.Tweening.Plugins.Options.NoOptions> DOCounter(UnityEngine.UI.Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator, System.Globalization.CultureInfo culture);
            static /*0x3fd7a30*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOFade(UnityEngine.UI.Text target, float endValue, float duration);
            static /*0x3fd7bbc*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x3fd7dec*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration);
            static /*0x3fd7ff4*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration);
            static /*0x3fd81fc*/ DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration);
            static /*0x3fd8404*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.CircleOptions> DOShapeCircle(UnityEngine.RectTransform target, UnityEngine.Vector2 center, float endValueDegrees, float duration, bool relativeCenter, bool snapping);

            class Utils
            {
                static /*0x3fd85f0*/ UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to);
            }

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.CanvasGroup target;

                /*0x3fd3c48*/ <>c__DisplayClass0_0();
                /*0x3fd8778*/ float <DOFade>b__0();
                /*0x3fd8794*/ void <DOFade>b__1(float x);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x3fd4d2c*/ <>c__DisplayClass10_0();
                /*0x3fd87b0*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fd87d0*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x3fd4eb8*/ <>c__DisplayClass11_0();
                /*0x3fd87ec*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fd880c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.UI.Outline target;

                /*0x3fd5054*/ <>c__DisplayClass12_0();
                /*0x3fd8828*/ UnityEngine.Vector2 <DOScale>b__0();
                /*0x3fd8844*/ void <DOScale>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd5208*/ <>c__DisplayClass13_0();
                /*0x3fd8860*/ UnityEngine.Vector2 <DOAnchorPos>b__0();
                /*0x3fd887c*/ void <DOAnchorPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd53b4*/ <>c__DisplayClass14_0();
                /*0x3fd8898*/ UnityEngine.Vector2 <DOAnchorPosX>b__0();
                /*0x3fd88b4*/ void <DOAnchorPosX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd5560*/ <>c__DisplayClass15_0();
                /*0x3fd88d0*/ UnityEngine.Vector2 <DOAnchorPosY>b__0();
                /*0x3fd88ec*/ void <DOAnchorPosY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd571c*/ <>c__DisplayClass16_0();
                /*0x3fd8908*/ UnityEngine.Vector3 <DOAnchorPos3D>b__0();
                /*0x3fd8924*/ void <DOAnchorPos3D>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd58cc*/ <>c__DisplayClass17_0();
                /*0x3fd8940*/ UnityEngine.Vector3 <DOAnchorPos3DX>b__0();
                /*0x3fd895c*/ void <DOAnchorPos3DX>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd5a7c*/ <>c__DisplayClass18_0();
                /*0x3fd8978*/ UnityEngine.Vector3 <DOAnchorPos3DY>b__0();
                /*0x3fd8994*/ void <DOAnchorPos3DY>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd5c2c*/ <>c__DisplayClass19_0();
                /*0x3fd89b0*/ UnityEngine.Vector3 <DOAnchorPos3DZ>b__0();
                /*0x3fd89cc*/ void <DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0x3fd3dfc*/ <>c__DisplayClass1_0();
                /*0x3fd89e8*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fd8a0c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd5de0*/ <>c__DisplayClass20_0();
                /*0x3fd8a30*/ UnityEngine.Vector2 <DOAnchorMax>b__0();
                /*0x3fd8a4c*/ void <DOAnchorMax>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd5f94*/ <>c__DisplayClass21_0();
                /*0x3fd8a68*/ UnityEngine.Vector2 <DOAnchorMin>b__0();
                /*0x3fd8a84*/ void <DOAnchorMin>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd6130*/ <>c__DisplayClass22_0();
                /*0x3fd8aa0*/ UnityEngine.Vector2 <DOPivot>b__0();
                /*0x3fd8abc*/ void <DOPivot>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd62d0*/ <>c__DisplayClass23_0();
                /*0x3fd8ad8*/ UnityEngine.Vector2 <DOPivotX>b__0();
                /*0x3fd8af4*/ void <DOPivotX>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd6470*/ <>c__DisplayClass24_0();
                /*0x3fd8b10*/ UnityEngine.Vector2 <DOPivotY>b__0();
                /*0x3fd8b2c*/ void <DOPivotY>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd6624*/ <>c__DisplayClass25_0();
                /*0x3fd8b48*/ UnityEngine.Vector2 <DOSizeDelta>b__0();
                /*0x3fd8b64*/ void <DOSizeDelta>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd67e0*/ <>c__DisplayClass26_0();
                /*0x3fd8b80*/ UnityEngine.Vector3 <DOPunchAnchorPos>b__0();
                /*0x3fd8ba4*/ void <DOPunchAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd69c8*/ <>c__DisplayClass27_0();
                /*0x3fd8bc0*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0x3fd8be4*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd6bc0*/ <>c__DisplayClass28_0();
                /*0x3fd8c00*/ UnityEngine.Vector3 <DOShakeAnchorPos>b__0();
                /*0x3fd8c24*/ void <DOShakeAnchorPos>b__1(UnityEngine.Vector3 x);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ UnityEngine.RectTransform target;
                /*0x18*/ float startPosY;
                /*0x1c*/ bool offsetYSet;
                /*0x20*/ float offsetY;
                /*0x28*/ DG.Tweening.Sequence s;
                /*0x30*/ UnityEngine.Vector2 endValue;

                /*0x3fd6fd8*/ <>c__DisplayClass29_0();
                /*0x3fd8c40*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__0();
                /*0x3fd8c5c*/ void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x);
                /*0x3fd8c78*/ void <DOJumpAnchorPos>b__2();
                /*0x3fd8ca0*/ UnityEngine.Vector2 <DOJumpAnchorPos>b__3();
                /*0x3fd8cbc*/ void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x);
                /*0x3fd8cd8*/ void <DOJumpAnchorPos>b__5();
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Graphic target;

                /*0x3fd3f88*/ <>c__DisplayClass2_0();
                /*0x3fd8d80*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fd8da4*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x3fd7180*/ <>c__DisplayClass30_0();
                /*0x3fd8dc8*/ UnityEngine.Vector2 <DONormalizedPos>b__0();
                /*0x3fd8e10*/ void <DONormalizedPos>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x3fd7318*/ <>c__DisplayClass31_0();
                /*0x3fd8e50*/ float <DOHorizontalNormalizedPos>b__0();
                /*0x3fd8e6c*/ void <DOHorizontalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ UnityEngine.UI.ScrollRect target;

                /*0x3fd74b0*/ <>c__DisplayClass32_0();
                /*0x3fd8e88*/ float <DOVerticalNormalizedPos>b__0();
                /*0x3fd8ea4*/ void <DOVerticalNormalizedPos>b__1(float x);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.UI.Slider target;

                /*0x3fd7654*/ <>c__DisplayClass33_0();
                /*0x3fd8ec0*/ float <DOValue>b__0();
                /*0x3fd8ee4*/ void <DOValue>b__1(float x);
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x3fd7808*/ <>c__DisplayClass34_0();
                /*0x3fd8f08*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fd8f2c*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass35_0
            {
                /*0x10*/ int v;
                /*0x18*/ UnityEngine.UI.Text target;
                /*0x20*/ bool addThousandsSeparator;
                /*0x28*/ System.Globalization.CultureInfo cInfo;

                /*0x3fd7a28*/ <>c__DisplayClass35_0();
                /*0x3fd8f50*/ int <DOCounter>b__0();
                /*0x3fd8f58*/ void <DOCounter>b__1(int x);
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x3fd7bb4*/ <>c__DisplayClass36_0();
                /*0x3fd8fe8*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fd900c*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ UnityEngine.UI.Text target;

                /*0x3fd7de4*/ <>c__DisplayClass37_0();
                /*0x3fd9030*/ string <DOText>b__0();
                /*0x3fd9054*/ void <DOText>b__1(string x);
            }

            class <>c__DisplayClass38_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Graphic target;

                /*0x3fd7fec*/ <>c__DisplayClass38_0();
                /*0x3fd9078*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fd9084*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Image target;

                /*0x3fd81f4*/ <>c__DisplayClass39_0();
                /*0x3fd9100*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fd910c*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3fd413c*/ <>c__DisplayClass3_0();
                /*0x3fd9188*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fd91ac*/ void <DOColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ UnityEngine.Color to;
                /*0x20*/ UnityEngine.UI.Text target;

                /*0x3fd83fc*/ <>c__DisplayClass40_0();
                /*0x3fd91d0*/ UnityEngine.Color <DOBlendableColor>b__0();
                /*0x3fd91dc*/ void <DOBlendableColor>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ UnityEngine.RectTransform target;

                /*0x3fd85e8*/ <>c__DisplayClass41_0();
                /*0x3fd9258*/ UnityEngine.Vector2 <DOShapeCircle>b__0();
                /*0x3fd9274*/ void <DOShapeCircle>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3fd42c8*/ <>c__DisplayClass4_0();
                /*0x3fd9290*/ UnityEngine.Color <DOFade>b__0();
                /*0x3fd92b4*/ void <DOFade>b__1(UnityEngine.Color x);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3fd4478*/ <>c__DisplayClass5_0();
                /*0x3fd92d8*/ float <DOFillAmount>b__0();
                /*0x3fd92f4*/ void <DOFillAmount>b__1(float x);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x3fd4810*/ <>c__DisplayClass7_0();
                /*0x3fd9310*/ UnityEngine.Vector2 <DOFlexibleSize>b__0();
                /*0x3fd9368*/ void <DOFlexibleSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x3fd49c4*/ <>c__DisplayClass8_0();
                /*0x3fd93b8*/ UnityEngine.Vector2 <DOMinSize>b__0();
                /*0x3fd9410*/ void <DOMinSize>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.UI.LayoutElement target;

                /*0x3fd4b78*/ <>c__DisplayClass9_0();
                /*0x3fd9460*/ UnityEngine.Vector2 <DOPreferredSize>b__0();
                /*0x3fd94b8*/ void <DOPreferredSize>b__1(UnityEngine.Vector2 x);
            }
        }

        class DOTweenModuleUnityVersion
        {
            static /*0x3fd9508*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration);
            static /*0x3fd96e8*/ DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration);
            static /*0x3fd98d4*/ UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fd99cc*/ UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fd9ac4*/ UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fd9bbc*/ UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction);
            static /*0x3fd9cc8*/ UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction);
            static /*0x3fd9de4*/ UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction);
            static /*0x3fd9edc*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0x3fda0d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration);
            static /*0x3fda2d4*/ System.Threading.Tasks.Task AsyncWaitForCompletion(DG.Tweening.Tween t);
            static /*0x3fda3b8*/ System.Threading.Tasks.Task AsyncWaitForRewind(DG.Tweening.Tween t);
            static /*0x3fda49c*/ System.Threading.Tasks.Task AsyncWaitForKill(DG.Tweening.Tween t);
            static /*0x3fda580*/ System.Threading.Tasks.Task AsyncWaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops);
            static /*0x3fda66c*/ System.Threading.Tasks.Task AsyncWaitForPosition(DG.Tweening.Tween t, float position);
            static /*0x3fda760*/ System.Threading.Tasks.Task AsyncWaitForStart(DG.Tweening.Tween t);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fda0d0*/ <>c__DisplayClass8_0();
                /*0x3fda844*/ UnityEngine.Vector2 <DOOffset>b__0();
                /*0x3fda868*/ void <DOOffset>b__1(UnityEngine.Vector2 x);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ UnityEngine.Material target;
                /*0x18*/ int propertyID;

                /*0x3fda2cc*/ <>c__DisplayClass9_0();
                /*0x3fda88c*/ UnityEngine.Vector2 <DOTiling>b__0();
                /*0x3fda8b0*/ void <DOTiling>b__1(UnityEngine.Vector2 x);
            }

            struct <AsyncWaitForCompletion>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fda8d4*/ void MoveNext();
                /*0x3fdab98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForElapsedLoops>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ int elapsedLoops;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fdac00*/ void MoveNext();
                /*0x3fdaecc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForKill>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fdaf34*/ void MoveNext();
                /*0x3fdb1e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForPosition>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ float position;
                /*0x3c*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fdb24c*/ void MoveNext();
                /*0x3fdb530*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForRewind>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fdb598*/ void MoveNext();
                /*0x3fdb880*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AsyncWaitForStart>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                /*0x30*/ DG.Tweening.Tween t;
                /*0x38*/ System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter <>u__1;

                /*0x3fdb8e8*/ void MoveNext();
                /*0x3fdbba0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DOTweenCYInstruction
        {
            class WaitForCompletion : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fd999c*/ WaitForCompletion(DG.Tweening.Tween tween);
                /*0x3fdbc08*/ bool get_keepWaiting();
            }

            class WaitForRewind : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fd9a94*/ WaitForRewind(DG.Tweening.Tween tween);
                /*0x3fdbc38*/ bool get_keepWaiting();
            }

            class WaitForKill : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fd9b8c*/ WaitForKill(DG.Tweening.Tween tween);
                /*0x3fdbc98*/ bool get_keepWaiting();
            }

            class WaitForElapsedLoops : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ int elapsedLoops;

                /*0x3fd9c8c*/ WaitForElapsedLoops(DG.Tweening.Tween tween, int elapsedLoops);
                /*0x3fdbcb4*/ bool get_keepWaiting();
            }

            class WaitForPosition : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;
                /*0x18*/ float position;

                /*0x3fd9da0*/ WaitForPosition(DG.Tweening.Tween tween, float position);
                /*0x3fdbcf4*/ bool get_keepWaiting();
            }

            class WaitForStart : UnityEngine.CustomYieldInstruction
            {
                /*0x10*/ DG.Tweening.Tween t;

                /*0x3fd9eac*/ WaitForStart(DG.Tweening.Tween tween);
                /*0x3fdbd4c*/ bool get_keepWaiting();
            }
        }

        class DOTweenModuleUtils
        {
            static /*0x0*/ bool _initialized;

            static /*0x3fdbd80*/ void Init();
            static /*0x3fdbe2c*/ void Preserver();

            class Physics
            {
                static /*0x3fdbec0*/ void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans);
                static /*0x3fdbfc0*/ bool HasRigidbody2D(UnityEngine.Component target);
                static /*0x3fdc04c*/ bool HasRigidbody(UnityEngine.Component target);
                static /*0x3fdc0d8*/ DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode);
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
