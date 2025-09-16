class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3ff58ac*/ EmbeddedAttribute();
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

                /*0x3ff58b4*/ NullableAttribute(byte );
                /*0x3ff593c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3ff596c*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3ff5994*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3ff5a84*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        static /*0x3ff5a8c*/ void PlayJumpNumberAnimation(TMPro.TextMeshProUGUI text, string finalValue, float maxScale, float duration, float waveDelay);

        class <>c
        {
            static /*0x0*/ Extensions.TextMeshProUGUIExtensions.<> <>9;
            static /*0x8*/ DG.Tweening.Core.DOGetter<float> <>9__0_1;

            static /*0x3ff5f3c*/ <>c();
            /*0x3ff5fa4*/ <>c();
            /*0x3ff5fac*/ float <PlayJumpNumberAnimation>b__0_1();
        }

        class <>c__DisplayClass0_0
        {
            /*0x10*/ TMPro.TextMeshProUGUI text;
            /*0x18*/ float maxScale;
            /*0x20*/ string valueStr;

            /*0x3ff5f2c*/ <>c__DisplayClass0_0();
            /*0x3ff5fb4*/ void <PlayJumpNumberAnimation>b__0();
        }

        class <>c__DisplayClass0_1
        {
            /*0x10*/ int charIndex;
            /*0x18*/ Extensions.TextMeshProUGUIExtensions.<> CS$<>8__locals1;

            /*0x3ff5f34*/ <>c__DisplayClass0_1();
            /*0x3ff6000*/ void <PlayJumpNumberAnimation>b__2(float t);
            /*0x3ff6254*/ void <PlayJumpNumberAnimation>b__3();
        }
    }
}

namespace UnityEngine
{
    class MaterialExtensions
    {
        static /*0x3ff6338*/ void TrySetColor(UnityEngine.Material target, string propertyName, UnityEngine.Color value);
        static /*0x3ff63b8*/ void TrySetFloat(UnityEngine.Material target, string propertyName, float value);
    }
}

namespace DG
{
    namespace Tweening
    {
        class DOTweenExtensions
        {
            static /*0x3ff6414*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOAlpha(UnityEngine.UI.RawImage target, float endValue, float duration);
            static /*0x3ff6594*/ DG.Tweening.Core.TweenerCore<UnityEngine.Rect, UnityEngine.Rect, DG.Tweening.Plugins.Options.RectOptions> DOUVRect(UnityEngine.UI.RawImage target, UnityEngine.Rect endValue, float duration);
            static /*0x3ff673c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOAlpha(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3ff68bc*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(UnityEngine.CanvasGroup target, float endValue, float duration);
            static /*0x3ff6a3c*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(TMPro.TMP_Text target, float endValue, float duration);
            static /*0x3ff6bbc*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOFill(UnityEngine.UI.Image target, float endValue, float duration);
            static /*0x3ff6d3c*/ DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> DOColor(UnityEngine.MeshRenderer target, UnityEngine.Color endValue, float duration);
            static /*0x3ff6ee4*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(UnityEngine.MeshRenderer target, float endValue, float duration);
            static /*0x3ff7094*/ DG.Tweening.Core.TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> DOAlpha(UnityEngine.Material target, float endValue, float duration);
            static /*0x3ff7238*/ DG.Tweening.Core.TweenerCore<string, string, DG.Tweening.Plugins.Options.StringOptions> DOText(TMPro.TMP_Text target, string endValue, float duration, bool richTextEnabled, DG.Tweening.ScrambleMode scrambleMode, string scrambleChars);
            static /*0x3ff7468*/ Cysharp.Threading.Tasks.UniTask ToUniTask(DG.Tweening.Tween self);
            static /*0x3ff7644*/ Cysharp.Threading.Tasks.UniTask ToUniTask(DG.Tweening.Tween self, System.Threading.CancellationToken cancellationToken);
            static /*0x3ff7978*/ Cysharp.Threading.Tasks.UniTask FillAsUniTask(UnityEngine.UI.Image image, float endValue, float duration, DG.Tweening.Ease ease);
            static /*0x3ff7a40*/ Cysharp.Threading.Tasks.UniTask ToAsUniTask(DG.Tweening.Core.DOGetter<float> getter, DG.Tweening.Core.DOSetter<float> setter, float endValue, float duration, DG.Tweening.Ease ease);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ UnityEngine.UI.RawImage target;

                /*0x3ff658c*/ <>c__DisplayClass0_0();
                /*0x3ff7b2c*/ UnityEngine.Color <DOAlpha>b__0();
                /*0x3ff7b50*/ void <DOAlpha>b__1(UnityEngine.Color color);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource source;

                /*0x3ff763c*/ <>c__DisplayClass10_0();
                /*0x3ff7b74*/ void <ToUniTask>b__0();
                /*0x3ff7b90*/ void <ToUniTask>b__1();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource source;
                /*0x18*/ DG.Tweening.Tween self;

                /*0x3ff7970*/ <>c__DisplayClass11_0();
                /*0x3ff7bac*/ void <ToUniTask>b__0();
                /*0x3ff7bc8*/ void <ToUniTask>b__1();
                /*0x3ff7be4*/ void <ToUniTask>b__2();
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ UnityEngine.UI.Image image;

                /*0x3ff7c04*/ <>c__DisplayClass12_0();
                /*0x3ff7c0c*/ float <FillAsUniTask>b__0();
                /*0x3ff7c28*/ void <FillAsUniTask>b__1(float f);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ UnityEngine.UI.RawImage target;

                /*0x3ff6734*/ <>c__DisplayClass1_0();
                /*0x3ff7c44*/ UnityEngine.Rect <DOUVRect>b__0();
                /*0x3ff7c64*/ void <DOUVRect>b__1(UnityEngine.Rect uvRect);
            }

            class <>c__DisplayClass2_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3ff68b4*/ <>c__DisplayClass2_0();
                /*0x3ff7c80*/ UnityEngine.Color <DOAlpha>b__0();
                /*0x3ff7ca4*/ void <DOAlpha>b__1(UnityEngine.Color color);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.CanvasGroup target;

                /*0x3ff6a34*/ <>c__DisplayClass3_0();
                /*0x3ff7cc8*/ float <DOAlpha>b__0();
                /*0x3ff7ce4*/ void <DOAlpha>b__1(float color);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ TMPro.TMP_Text target;

                /*0x3ff6bb4*/ <>c__DisplayClass4_0();
                /*0x3ff7d00*/ float <DOAlpha>b__0();
                /*0x3ff7d1c*/ void <DOAlpha>b__1(float alpha);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.UI.Image target;

                /*0x3ff6d34*/ <>c__DisplayClass5_0();
                /*0x3ff7d38*/ float <DOFill>b__0();
                /*0x3ff7d54*/ void <DOFill>b__1(float color);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.MeshRenderer target;

                /*0x3ff6edc*/ <>c__DisplayClass6_0();
                /*0x3ff7d70*/ UnityEngine.Color <DOColor>b__0();
                /*0x3ff7d98*/ void <DOColor>b__1(UnityEngine.Color color);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ UnityEngine.Color itemColor;
                /*0x20*/ UnityEngine.MeshRenderer target;

                /*0x3ff708c*/ <>c__DisplayClass7_0();
                /*0x3ff7df0*/ float <DOAlpha>b__0();
                /*0x3ff7df8*/ void <DOAlpha>b__1(float color);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ UnityEngine.Color itemColor;
                /*0x20*/ UnityEngine.Material target;

                /*0x3ff7230*/ <>c__DisplayClass8_0();
                /*0x3ff7e30*/ float <DOAlpha>b__0();
                /*0x3ff7e38*/ void <DOAlpha>b__1(float color);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ TMPro.TMP_Text target;

                /*0x3ff7460*/ <>c__DisplayClass9_0();
                /*0x3ff7e68*/ string <DOText>b__0();
                /*0x3ff7e8c*/ void <DOText>b__1(string x);
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

                /*0x3ff7eb0*/ void MoveNext();
                /*0x3ff8410*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3ff841c*/ void MoveNext();
                /*0x3ff88a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }
    }
}

namespace System
{
    class DateTimeExtensions
    {
        static /*0x3ff88b4*/ string ToShortFormat(System.DateTime self);
    }

    class EnumerableExtensions
    {
        static /*0x0*/ System.Random rng;

        static /*0x3ff8960*/ EnumerableExtensions();
        static /*0x38379c4*/ System.Collections.Generic.IEnumerable<T> Shuffle<T>(System.Collections.Generic.IEnumerable<T> source);

        class <>c__<T>
        {
            static /*0x0*/ System.EnumerableExtensions.<>c__1<T> <>9;
            static /*0x0*/ System.Func<T, int> <>9__1_0;

            static /*0x383e7a0*/ <>c__();
            /*0x38159dc*/ <>c__();
            /*0x3910ae8*/ int <Shuffle>b__1_0(T _);
        }
    }

    class IntExtensions
    {
        static /*0x3ff89dc*/ string ToUiString(int number, bool disableRoundCount);
        static /*0x3ff8b84*/ string ToUiString(long number, bool disableRoundCount);
        static /*0x3ff89e8*/ string NumberToUiString(long number, bool disableRoundCount);
    }

    class StringExtensions
    {
        static /*0x3ff8b8c*/ string FormatNewline(string text);
        static /*0x3ff8c40*/ string WildcardToRegex(string pattern);
        static /*0x3ff8d90*/ string EscapeAndCleanForTMP(string text);
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
