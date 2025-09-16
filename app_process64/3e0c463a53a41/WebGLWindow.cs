class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x820c21c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x820c310*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        static /*0x820c318*/ void WebGLWindowInit();
        static /*0x820c31c*/ void WebGLWindowOnFocus(System.Action cb);
        static /*0x820c320*/ void WebGLWindowOnBlur(System.Action cb);
        static /*0x820c324*/ void WebGLWindowOnResize(System.Action cb);
        static /*0x820c328*/ void WebGLWindowInjectFullscreen();
        static /*0x820c32c*/ string WebGLWindowGetCanvasName();
        static /*0x820c36c*/ void MakeFullscreen(string str);
        static /*0x820c370*/ void ExitFullscreen();
        static /*0x820c374*/ bool IsFullscreen();
    }

    class WebGLWindow
    {
        static /*0x0*/ bool <Focus>k__BackingField;
        static /*0x8*/ System.Action OnFocusEvent;
        static /*0x10*/ System.Action OnBlurEvent;
        static /*0x18*/ System.Action OnResizeEvent;
        static /*0x20*/ string ViewportContent;

        static /*0x820c52c*/ WebGLWindow();
        static /*0x820c69c*/ bool get_Focus();
        static /*0x820c6f4*/ void set_Focus(bool value);
        static /*0x820c754*/ void add_OnFocusEvent(System.Action value);
        static /*0x820c830*/ void remove_OnFocusEvent(System.Action value);
        static /*0x820c90c*/ void add_OnBlurEvent(System.Action value);
        static /*0x820c9e8*/ void remove_OnBlurEvent(System.Action value);
        static /*0x820cac4*/ void add_OnResizeEvent(System.Action value);
        static /*0x820cba0*/ void remove_OnResizeEvent(System.Action value);
        static /*0x820cc7c*/ void Init();
        static /*0x820c37c*/ void OnWindowFocus();
        static /*0x820c420*/ void OnWindowBlur();
        static /*0x820c4c0*/ void OnWindowResize();
        static /*0x820cda4*/ void RuntimeInitializeOnLoadMethod();
        static /*0x820cdf0*/ string GetCanvasName();
        static /*0x820ce30*/ void MakeFullscreen(string fullscreenElementName);
        static /*0x820cea4*/ void ExitFullscreen();
        static /*0x820cea8*/ bool IsFullscreen();
        static /*0x820ceb0*/ void SwitchFullscreen();

        class <>c
        {
            static /*0x0*/ WebGLSupport.WebGLWindow.<> <>9;

            static /*0x820cf10*/ <>c();
            /*0x820cf78*/ <>c();
            /*0x820cf80*/ void <.cctor>b__0_0();
            /*0x820cf84*/ void <.cctor>b__0_1();
            /*0x820cf88*/ void <.cctor>b__0_2();
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
