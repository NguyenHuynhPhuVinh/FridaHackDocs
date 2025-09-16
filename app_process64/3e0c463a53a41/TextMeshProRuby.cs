class <Module>
{
}

class TextMeshProRuby : UnityEngine.MonoBehaviour
{
    /*0x20*/ TMPro.TMP_Text tmpText;
    /*0x28*/ string text;
    /*0x30*/ bool fixedLineHeight;
    /*0x31*/ bool autoMarginTop;

    /*0x78ae9dc*/ TextMeshProRuby();
    /*0x78ae5fc*/ string get_Text();
    /*0x78ae604*/ void set_Text(string value);
    /*0x78ae720*/ bool get_FixedLineHeight();
    /*0x78ae728*/ void set_FixedLineHeight(bool value);
    /*0x78ae764*/ bool get_AutoMarginTop();
    /*0x78ae76c*/ void set_AutoMarginTop(bool value);
    /*0x78ae7a8*/ void OnEnable();
    /*0x78ae638*/ void Apply();
}

class TMProRubyUtil
{
    static string StartTag = "<voffset=1em><size=50%>";
    static string EndTag = "</size></voffset>";
    static int StringBuilderCapacity = 1024;
    static /*0x0*/ System.Text.RegularExpressions.Regex TagRegex;
    static /*0x8*/ System.Text.StringBuilder builder;

    static /*0x78af080*/ TMProRubyUtil();
    static /*0x78ae7ac*/ void SetTextAndExpandRuby(TMPro.TMP_Text tmpText, string text, bool fixedLineHeight, bool autoMarginTop);
    static /*0x78ae9ec*/ string GetExpandText(string text);
    static /*0x78aef28*/ string RemoveRubyTag(string text);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x78af160*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x78af250*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 672209AC4A87A82C0339143007355487F5913F3633C710CFBF4FFBB047351EF9;
    static /*0x28*/ <PrivateImplementationDetails> D8E0E4924B13B0A04E1AE2C51539F886729AC20623396F1362A1C6499C2665E8;

    struct __StaticArrayInitTypeSize=40
    {
    }

    struct __StaticArrayInitTypeSize=98
    {
    }
}
