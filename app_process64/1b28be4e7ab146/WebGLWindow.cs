class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x822364c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x8223740*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace WebGLSupport
{
    class WebGLWindowPlugin
    {
        static /*0x8223748*/ void WebGLWindowInit();
        static /*0x822374c*/ void WebGLWindowOnFocus(System.Action cb);
        static /*0x8223750*/ void WebGLWindowOnBlur(System.Action cb);
        static /*0x8223754*/ void WebGLWindowOnResize(System.Action cb);
        static /*0x8223758*/ void WebGLWindowInjectFullscreen();
        static /*0x822375c*/ string WebGLWindowGetCanvasName();
        static /*0x822379c*/ void MakeFullscreen(string str);
        static /*0x82237a0*/ void ExitFullscreen();
        static /*0x82237a4*/ bool IsFullscreen();
    }

    class WebGLWindow
    {
        static /*0x0*/ bool <Focus>k__BackingField;
        static /*0x8*/ System.Action OnFocusEvent;
        static /*0x10*/ System.Action OnBlurEvent;
        static /*0x18*/ System.Action OnResizeEvent;
        static /*0x20*/ string ViewportContent;

        static /*0x822395c*/ WebGLWindow();
        static /*0x8223acc*/ bool get_Focus();
        static /*0x8223b24*/ void set_Focus(bool value);
        static /*0x8223b84*/ void add_OnFocusEvent(System.Action value);
        static /*0x8223c60*/ void remove_OnFocusEvent(System.Action value);
        static /*0x8223d3c*/ void add_OnBlurEvent(System.Action value);
        static /*0x8223e18*/ void remove_OnBlurEvent(System.Action value);
        static /*0x8223ef4*/ void add_OnResizeEvent(System.Action value);
        static /*0x8223fd0*/ void remove_OnResizeEvent(System.Action value);
        static /*0x82240ac*/ void Init();
        static /*0x82237ac*/ void OnWindowFocus();
        static /*0x8223850*/ void OnWindowBlur();
        static /*0x82238f0*/ void OnWindowResize();
        static /*0x82241d4*/ void RuntimeInitializeOnLoadMethod();
        static /*0x8224220*/ string GetCanvasName();
        static /*0x8224260*/ void MakeFullscreen(string fullscreenElementName);
        static /*0x82242d4*/ void ExitFullscreen();
        static /*0x82242d8*/ bool IsFullscreen();
        static /*0x82242e0*/ void SwitchFullscreen();

        class <>c
        {
            static /*0x0*/ WebGLSupport.WebGLWindow.<> <>9;

            static /*0x8224340*/ <>c();
            /*0x82243a8*/ <>c();
            /*0x82243b0*/ void <.cctor>b__0_0();
            /*0x82243b4*/ void <.cctor>b__0_1();
            /*0x82243b8*/ void <.cctor>b__0_2();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 6EB8EAF53B9F9F302F1C800F4D24708DA08AEE34DDC1C86074AC047C206D6C22;
    static /*0x40*/ <PrivateImplementationDetails> 7F30245F936BB6CDEC26B1FF07EC06B2E02A282EA869D45A3107D0CFD367BE66;

    struct __StaticArrayInitTypeSize=55
    {
    }

    struct __StaticArrayInitTypeSize=64
    {
    }
}
