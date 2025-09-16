class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3fe9bd8*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x3fe9be0*/ NullableAttribute(byte );
                /*0x3fe9c68*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3fe9c98*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3fe9cc0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3fe9db0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Extensions
{
    class TextMeshProUGUIExtensions
    {
        static /*0x3fe9db8*/ void PlayJumpNumberAnimation(TMPro.TextMeshProUGUI text, string finalValue, float maxScale, float duration, float waveDelay);

        class <>c
        {
            static /*0x0*/ Extensions.TextMeshProUGUIExtensions.<> <>9;
            static /*0x8*/ DG.Tweening.Core.DOGetter<float> <>9__0_1;

            static /*0x3fea268*/ <>c();
            /*0x3fea2d0*/ <>c();
            /*0x3fea2d8*/ float <PlayJumpNumberAnimation>b__0_1();
        }

        class <>c__DisplayClass0_0
        {
            /*0x10*/ TMPro.TextMeshProUGUI text;
            /*0x18*/ float maxScale;
            /*0x20*/ string valueStr;

            /*0x3fea258*/ <>c__DisplayClass0_0();
            /*0x3fea2e0*/ void <PlayJumpNumberAnimation>b__0();
        }

        class <>c__DisplayClass0_1
        {
            /*0x10*/ int charIndex;
            /*0x18*/ Extensions.TextMeshProUGUIExtensions.<> CS$<>8__locals1;

            /*0x3fea260*/ <>c__DisplayClass0_1();
            /*0x3fea32c*/ void <PlayJumpNumberAnimation>b__2(float t);
            /*0x3fea580*/ void <PlayJumpNumberAnimation>b__3();
        }
    }
}

namespace UnityEngine
{
    class MaterialExtensions
    {
        static /*0x3fea664*/ void TrySetColor(UnityEngine.Material target, string propertyName, UnityEngine.Color value);
        static /*0x3fea6e4*/ void TrySetFloat(UnityEngine.Material target, string propertyName, float value);
    }
}

namespace DG
{
    namespace Tweening
    {
        class DOTweenExtensions
        {
            static /*0x3fea740*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOAlpha(UnityEngine.UI.RawImage target, float endValue, float duration);
            static /*0x3fea8c0*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOUVRect(UnityEngine.UI.RawImage target, UnityEngine.Rect endValue, float duration);
            static /*0x3feaa68*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOAlpha(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3feabe8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(UnityEngine.CanvasGroup target, float endValue, float duration);
            static /*0x3fead68*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(TMPro.TMP_Text target, float endValue, float duration);
            static /*0x3feaee8*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFill(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3feb068*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.MeshRenderer target, UnityEngine.Color endValue, float duration);
            static /*0x3feb210*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(UnityEngine.MeshRenderer target, float endValue, float duration);
            static /*0x3feb3c0*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(UnityEngine.Material target, float endValue, float duration);
            static /*0x3feb564*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(TMPro.TMP_Text target, string endValue, float duration, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x3feb794*/ Cysharp.Threading.Tasks.UniTask ToUniTask(DG.Tweening.Tween self);
            static /*0x3feb970*/ Cysharp.Threading.Tasks.UniTask ToUniTask(DG.Tweening.Tween self, System.Threading.CancellationToken cancellationToken);
            static /*0x3febca4*/ Cysharp.Threading.Tasks.UniTask FillAsUniTask(UnityEngine.UI.Image image, float endValue, float duration, DG.Tweening.Ease ease);
            static /*0x3febd6c*/ Cysharp.Threading.Tasks.UniTask ToAsUniTask(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration, DG.Tweening.Ease ease);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.UI.RawImage target;

                /*0x3fea8b8*/ <>c__DisplayClass0_0();
                /*0x3febe58*/ UnityEngine.Color <DOAlpha>b__0();
                /*0x3febe7c*/ void <DOAlpha>b__1(UnityEngine.Color color);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource source;

                /*0x3feb968*/ <>c__DisplayClass10_0();
                /*0x3febea0*/ void <ToUniTask>b__0();
                /*0x3febebc*/ void <ToUniTask>b__1();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource source;
                /*0x18*/ DG.Tweening.Tween self;

                /*0x3febc9c*/ <>c__DisplayClass11_0();
                /*0x3febed8*/ void <ToUniTask>b__0();
                /*0x3febef4*/ void <ToUniTask>b__1();
                /*0x3febf10*/ void <ToUniTask>b__2();
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.UI.Image image;

                /*0x3febf30*/ <>c__DisplayClass12_0();
                /*0x3febf38*/ float <FillAsUniTask>b__0();
                /*0x3febf54*/ void <FillAsUniTask>b__1(float f);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.UI.RawImage target;

                /*0x3feaa60*/ <>c__DisplayClass1_0();
                /*0x3febf70*/ UnityEngine.Rect <DOUVRect>b__0();
                /*0x3febf90*/ void <DOUVRect>b__1(UnityEngine.Rect uvRect);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3feabe0*/ <>c__DisplayClass2_0();
                /*0x3febfac*/ UnityEngine.Color <DOAlpha>b__0();
                /*0x3febfd0*/ void <DOAlpha>b__1(UnityEngine.Color color);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.CanvasGroup target;

                /*0x3fead60*/ <>c__DisplayClass3_0();
                /*0x3febff4*/ float <DOAlpha>b__0();
                /*0x3fec010*/ void <DOAlpha>b__1(float color);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ TMPro.TMP_Text target;

                /*0x3feaee0*/ <>c__DisplayClass4_0();
                /*0x3fec02c*/ float <DOAlpha>b__0();
                /*0x3fec048*/ void <DOAlpha>b__1(float alpha);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3feb060*/ <>c__DisplayClass5_0();
                /*0x3fec064*/ float <DOFill>b__0();
                /*0x3fec080*/ void <DOFill>b__1(float color);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.MeshRenderer target;

                /*0x3feb208*/ <>c__DisplayClass6_0();
                /*0x3fec09c*/ UnityEngine.Color <DOColor>b__0();
                /*0x3fec0c4*/ void <DOColor>b__1(UnityEngine.Color color);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Color itemColor;
                /*0x20*/ UnityEngine.MeshRenderer target;

                /*0x3feb3b8*/ <>c__DisplayClass7_0();
                /*0x3fec11c*/ float <DOAlpha>b__0();
                /*0x3fec124*/ void <DOAlpha>b__1(float color);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Color itemColor;
                /*0x20*/ UnityEngine.Material target;

                /*0x3feb55c*/ <>c__DisplayClass8_0();
                /*0x3fec15c*/ float <DOAlpha>b__0();
                /*0x3fec164*/ void <DOAlpha>b__1(float color);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ TMPro.TMP_Text target;

                /*0x3feb78c*/ <>c__DisplayClass9_0();
                /*0x3fec194*/ string <DOText>b__0();
                /*0x3fec1b8*/ void <DOText>b__1(string x);
            }

            struct <FillAsUniTask>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ UnityEngine.UI.Image image;
                /*0x30*/ float endValue;
                /*0x34*/ float duration;
                /*0x38*/ DG.Tweening.Ease ease;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3fec1dc*/ void MoveNext();
                /*0x3fec73c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ToAsUniTask>d__13 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ DG.Tweening.Core.DOGetter<float> getter;
                /*0x30*/ DG.Tweening.Core.DOSetter<float> setter;
                /*0x38*/ float endValue;
                /*0x3c*/ float duration;
                /*0x40*/ DG.Tweening.Ease ease;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3fec748*/ void MoveNext();
                /*0x3fecbd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }
    }
}

namespace System
{
    class DateTimeExtensions
    {
        static /*0x3fecbe0*/ string ToShortFormat(System.DateTime self);
    }

    class EnumerableExtensions
    {
        static /*0x0*/ System.Random rng;

        static /*0x3fecc8c*/ EnumerableExtensions();
        static /*0x382eaf0*/ System.Collections.Generic.IEnumerable<T> Shuffle<T>(System.Collections.Generic.IEnumerable<T> source);

        class <>c__<T>
        {
            static /*0x0*/ System.EnumerableExtensions.<>c__1<T> <>9;
            static /*0x0*/ System.Func<T, int> <>9__1_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x3907c14*/ int <Shuffle>b__1_0(T _);
        }
    }

    class IntExtensions
    {
        static /*0x3fecd08*/ string ToUiString(int number, bool disableRoundCount);
        static /*0x3feceb0*/ string ToUiString(long number, bool disableRoundCount);
        static /*0x3fecd14*/ string NumberToUiString(long number, bool disableRoundCount);
    }

    class StringExtensions
    {
        static /*0x3feceb8*/ string FormatNewline(string text);
        static /*0x3fecf6c*/ string WildcardToRegex(string pattern);
        static /*0x3fed0bc*/ string EscapeAndCleanForTMP(string text);
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 375A203C7B92F46A025795A37039FC3C528BC053AE74529F2ABC0B1FBC53437F;
    static /*0x103*/ <PrivateImplementationDetails> CA0AE6067446BC91B03849657EA1632A54BE9616698E2D27A72D7E9FDE1096A7;

    struct __StaticArrayInitTypeSize=259
    {
    }

    struct __StaticArrayInitTypeSize=448
    {
    }
}
