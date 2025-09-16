class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x821dcb8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x821ddac*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    class KeyboardEventHandler : System.MulticastDelegate
    {
        /*0x821ddb4*/ KeyboardEventHandler(object object, nint method);
        /*0x821dec0*/ void Invoke(WebGLSupport.WebGLInput input, WebGLSupport.KeyboardEvent keyboardEvent);
        /*0x821ded4*/ System.IAsyncResult BeginInvoke(WebGLSupport.WebGLInput input, WebGLSupport.KeyboardEvent keyboardEvent, System.AsyncCallback callback, object object);
        /*0x821defc*/ void EndInvoke(System.IAsyncResult result);
    }

    class KeyboardEvent
    {
        /*0x10*/ string <Key>k__BackingField;
        /*0x18*/ int <Code>k__BackingField;
        /*0x1c*/ bool <ShiftKey>k__BackingField;
        /*0x1d*/ bool <CtrlKey>k__BackingField;
        /*0x1e*/ bool <AltKey>k__BackingField;

        /*0x821df30*/ KeyboardEvent(string key, int code, bool shiftKey, bool ctrlKey, bool altKey);
        /*0x821df08*/ string get_Key();
        /*0x821df10*/ int get_Code();
        /*0x821df18*/ bool get_ShiftKey();
        /*0x821df20*/ bool get_CtrlKey();
        /*0x821df28*/ bool get_AltKey();
    }

    class WebGLInputMobilePlugin
    {
        static /*0x821df94*/ int WebGLInputMobileRegister(System.Action<int> OnTouchEnd);
        static /*0x821df9c*/ void WebGLInputMobileOnFocusOut(int id, System.Action<int> OnFocusOut);
        /*0x821dfa0*/ WebGLInputMobilePlugin();
    }

    class WebGLInputMobile : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, WebGLSupport.WebGLInputMobile> instances;
        /*0x20*/ int id;

        static /*0x821eb44*/ WebGLInputMobile();
        static /*0x821dfa8*/ void OnTouchEnd(int id);
        static /*0x821ea24*/ System.Collections.IEnumerator RegisterOnFocusOut(int id);
        static /*0x821e06c*/ void OnFocusOut(int id);
        static /*0x821eaac*/ System.Collections.IEnumerator ExecFocusOut(int id);
        /*0x821eb34*/ WebGLInputMobile();
        /*0x821e10c*/ void Awake();
        /*0x821e118*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);

        class <ExecFocusOut>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int id;

            /*0x821eb0c*/ <ExecFocusOut>d__7(int <>1__state);
            /*0x821ebdc*/ void System.IDisposable.Dispose();
            /*0x821ebe0*/ bool MoveNext();
            /*0x821eecc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x821eed4*/ void System.Collections.IEnumerator.Reset();
            /*0x821ef0c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <RegisterOnFocusOut>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int id;

            /*0x821ea84*/ <RegisterOnFocusOut>d__5(int <>1__state);
            /*0x821ef14*/ void System.IDisposable.Dispose();
            /*0x821ef18*/ bool MoveNext();
            /*0x821efc4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x821efcc*/ void System.Collections.IEnumerator.Reset();
            /*0x821f004*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class WebGLInputManipulator : UnityEngine.UIElements.Manipulator
    {
        /*0x18*/ UnityEngine.GameObject go;
        /*0x20*/ bool showHtmlElement;

        /*0x821f00c*/ WebGLInputManipulator(bool showHtmlElement);
        /*0x821f034*/ void RegisterCallbacksOnTarget();
        /*0x821f1e0*/ void UnregisterCallbacksFromTarget();
        /*0x821f38c*/ void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent evt);
        /*0x821f54c*/ void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent evt);
    }

    class WebGLUIToolkitTextField : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UIElements.TextField <TextField>k__BackingField;

        /*0x821f5fc*/ WebGLUIToolkitTextField();
        /*0x821f5ec*/ UnityEngine.UIElements.TextField get_TextField();
        /*0x821f5f4*/ void set_TextField(UnityEngine.UIElements.TextField value);
    }

    class WebGLInputPlugin
    {
        static /*0x821f604*/ void WebGLInputInit();
        static /*0x821f608*/ int WebGLInputCreate(string canvasId, int x, int y, int width, int height, int fontsize, string text, string placeholder, bool isMultiLine, bool isPassword, bool isHidden, bool isMobile);
        static /*0x821f610*/ void WebGLInputEnterSubmit(int id, bool flag);
        static /*0x821f614*/ void WebGLInputTab(int id, System.Action<int, int> cb);
        static /*0x821f618*/ void WebGLInputFocus(int id);
        static /*0x821f61c*/ void WebGLInputOnFocus(int id, System.Action<int> cb);
        static /*0x821f620*/ void WebGLInputOnBlur(int id, System.Action<int> cb);
        static /*0x821f624*/ void WebGLInputOnValueChange(int id, System.Action<int, string> cb);
        static /*0x821f628*/ void WebGLInputOnEditEnd(int id, System.Action<int, string> cb);
        static /*0x821f62c*/ void WebGLInputOnKeyboardEvent(int id, System.Action<int, int, string, int, int, int, int> cb);
        static /*0x821f630*/ int WebGLInputSelectionStart(int id);
        static /*0x821f638*/ int WebGLInputSelectionEnd(int id);
        static /*0x821f640*/ int WebGLInputSelectionDirection(int id);
        static /*0x821f648*/ void WebGLInputSetSelectionRange(int id, int start, int end);
        static /*0x821f64c*/ void WebGLInputMaxLength(int id, int maxlength);
        static /*0x821f650*/ void WebGLInputText(int id, string text);
        static /*0x821f654*/ bool WebGLInputIsFocus(int id);
        static /*0x821f65c*/ void WebGLInputDelete(int id);
        static /*0x821f660*/ void WebGLInputForceBlur(int id);
        /*0x821f664*/ WebGLInputPlugin();
    }

    class WebGLInput : UnityEngine.MonoBehaviour, System.IComparable<WebGLSupport.WebGLInput>
    {
        static /*0x0*/ WebGLSupport.KeyboardEventHandler OnKeyboardDown;
        static /*0x8*/ WebGLSupport.KeyboardEventHandler OnKeyboardUp;
        static /*0x10*/ System.Collections.Generic.Dictionary<int, WebGLSupport.WebGLInput> instances;
        static /*0x18*/ string <CanvasId>k__BackingField;
        /*0x20*/ int id;
        /*0x28*/ WebGLSupport.IInputField <input>k__BackingField;
        /*0x30*/ bool blurBlock;
        /*0x31*/ bool showHtmlElement;

        static /*0x82203e8*/ WebGLInput();
        static /*0x821ffc8*/ void add_OnKeyboardDown(WebGLSupport.KeyboardEventHandler value);
        static /*0x82200a0*/ void remove_OnKeyboardDown(WebGLSupport.KeyboardEventHandler value);
        static /*0x8220178*/ void add_OnKeyboardUp(WebGLSupport.KeyboardEventHandler value);
        static /*0x8220254*/ void remove_OnKeyboardUp(WebGLSupport.KeyboardEventHandler value);
        static /*0x8220330*/ string get_CanvasId();
        static /*0x8220388*/ void set_CanvasId(string value);
        static /*0x821f66c*/ void OnFocus(int id);
        static /*0x821f670*/ void OnBlur(int id);
        static /*0x8220d38*/ System.Collections.IEnumerator Blur(int id);
        static /*0x821f710*/ void OnValueChange(int id, string value);
        static /*0x821fb6c*/ void OnEditEnd(int id, string value);
        static /*0x821fd2c*/ void OnTab(int id, int value);
        static /*0x821fdf0*/ void OnKeyboardEvent(int id, int mode, string key, int code, int shiftKey, int ctrlKey, int altKey);
        /*0x8221784*/ WebGLInput();
        /*0x82204ec*/ int get_Id();
        /*0x82204f4*/ WebGLSupport.IInputField get_input();
        /*0x82204fc*/ void set_input(WebGLSupport.IInputField value);
        /*0x8220504*/ WebGLSupport.IInputField Setup();
        /*0x8220894*/ void Awake();
        /*0x82209e8*/ UnityEngine.RectInt GetElemetRect();
        /*0x821e1f8*/ void OnSelect();
        /*0x8220b98*/ void SyncText(System.Nullable<int> cursorIndex);
        /*0x8220d2c*/ void OnWindowBlur();
        /*0x821ed08*/ void DeactivateInputField();
        /*0x8220f94*/ void Update();
        /*0x8221368*/ void OnDestroy();
        /*0x8221400*/ void OnEnable();
        /*0x8221550*/ void OnDisable();
        /*0x8221624*/ int CompareTo(WebGLSupport.WebGLInput other);
        /*0x822123c*/ void CheckOutFocus();

        class WebGLInputTabFocus
        {
            static /*0x0*/ System.Collections.Generic.List<WebGLSupport.WebGLInput> inputs;

            static /*0x8221794*/ WebGLInputTabFocus();
            static /*0x8221454*/ void Add(WebGLSupport.WebGLInput input);
            static /*0x82215a4*/ void Remove(WebGLSupport.WebGLInput input);
            static /*0x8220dc0*/ void OnTab(WebGLSupport.WebGLInput input, int value);
        }

        class <Blur>d__30 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int id;

            /*0x8220d98*/ <Blur>d__30(int <>1__state);
            /*0x822182c*/ void System.IDisposable.Dispose();
            /*0x8221830*/ bool MoveNext();
            /*0x82219b0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x82219b8*/ void System.Collections.IEnumerator.Reset();
            /*0x82219f0*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum ContentType
    {
        Standard = 0,
        Autocorrected = 1,
        IntegerNumber = 2,
        DecimalNumber = 3,
        Alphanumeric = 4,
        Name = 5,
        EmailAddress = 6,
        Password = 7,
        Pin = 8,
        Custom = 9,
    }

    enum LineType
    {
        SingleLine = 0,
        MultiLineSubmit = 1,
        MultiLineNewline = 2,
    }

    interface IInputField
    {
        /*0x3814574*/ WebGLSupport.ContentType get_contentType();
        /*0x3814574*/ WebGLSupport.LineType get_lineType();
        /*0x3814574*/ int get_fontSize();
        /*0x38148bc*/ string get_text();
        /*0x3816710*/ void set_text(string value);
        /*0x38148bc*/ string get_placeholder();
        /*0x3814574*/ int get_characterLimit();
        /*0x3814574*/ int get_caretPosition();
        /*0x3813ffc*/ bool get_isFocused();
        /*0x3814574*/ int get_selectionFocusPosition();
        /*0x3815ed0*/ void set_selectionFocusPosition(int value);
        /*0x3814574*/ int get_selectionAnchorPosition();
        /*0x3815ed0*/ void set_selectionAnchorPosition(int value);
        /*0x3813ffc*/ bool get_ReadOnly();
        /*0x3813ffc*/ bool get_OnFocusSelectAll();
        /*0x3813ffc*/ bool get_EnableMobileSupport();
        UnityEngine.Rect GetScreenCoordinates();
        /*0x38159dc*/ void ActivateInputField();
        /*0x38159dc*/ void DeactivateInputField();
        /*0x38159dc*/ void Rebuild();
    }

    class WrappedInputField : WebGLSupport.IInputField
    {
        /*0x10*/ UnityEngine.UI.InputField input;
        /*0x18*/ WebGLSupport.Detail.RebuildChecker checker;

        /*0x822072c*/ WrappedInputField(UnityEngine.UI.InputField input);
        /*0x82219f8*/ bool get_ReadOnly();
        /*0x8221a14*/ string get_text();
        /*0x8221a30*/ void set_text(string value);
        /*0x8221a4c*/ string get_placeholder();
        /*0x8221b48*/ int get_fontSize();
        /*0x8221b6c*/ WebGLSupport.ContentType get_contentType();
        /*0x8221b88*/ WebGLSupport.LineType get_lineType();
        /*0x8221ba4*/ int get_characterLimit();
        /*0x8221bc0*/ int get_caretPosition();
        /*0x8221bdc*/ bool get_isFocused();
        /*0x8221bf8*/ int get_selectionFocusPosition();
        /*0x8221c14*/ void set_selectionFocusPosition(int value);
        /*0x8221c30*/ int get_selectionAnchorPosition();
        /*0x8221c4c*/ void set_selectionAnchorPosition(int value);
        /*0x8221c68*/ bool get_OnFocusSelectAll();
        /*0x8221c70*/ bool get_EnableMobileSupport();
        /*0x8221ca8*/ void ActivateInputField();
        /*0x8221cc4*/ void DeactivateInputField();
        /*0x8221ce0*/ void Rebuild();
        /*0x82224e4*/ UnityEngine.Rect GetScreenCoordinates();
    }

    class WrappedTMPInputField : WebGLSupport.IInputField
    {
        /*0x10*/ TMPro.TMP_InputField input;
        /*0x18*/ WebGLSupport.Detail.RebuildChecker checker;
        /*0x20*/ UnityEngine.Coroutine delayedGraphicRebuild;

        /*0x82207fc*/ WrappedTMPInputField(TMPro.TMP_InputField input);
        /*0x8222754*/ bool get_ReadOnly();
        /*0x8222770*/ string get_text();
        /*0x822278c*/ void set_text(string value);
        /*0x82227b4*/ string FixContentTypeByInputField(string inText);
        /*0x8222c00*/ string get_placeholder();
        /*0x8222cfc*/ int get_fontSize();
        /*0x8222d38*/ WebGLSupport.ContentType get_contentType();
        /*0x8222d54*/ WebGLSupport.LineType get_lineType();
        /*0x8222d70*/ int get_characterLimit();
        /*0x8222d8c*/ int get_caretPosition();
        /*0x8222da8*/ bool get_isFocused();
        /*0x8222dc4*/ int get_selectionFocusPosition();
        /*0x8222de0*/ void set_selectionFocusPosition(int value);
        /*0x8222dfc*/ int get_selectionAnchorPosition();
        /*0x8222e18*/ void set_selectionAnchorPosition(int value);
        /*0x8222e34*/ bool get_OnFocusSelectAll();
        /*0x8222e50*/ bool get_EnableMobileSupport();
        /*0x8222e58*/ UnityEngine.Rect GetScreenCoordinates();
        /*0x8222eac*/ void ActivateInputField();
        /*0x8222ec8*/ void DeactivateInputField();
        /*0x8222ee8*/ void Rebuild();
        /*0x8222f70*/ bool rectOverlaps(UnityEngine.RectTransform rectTrans1, UnityEngine.RectTransform rectTrans2);
    }

    class WrappedUIToolkit : WebGLSupport.IInputField
    {
        /*0x10*/ UnityEngine.UIElements.TextField input;

        /*0x82207c4*/ WrappedUIToolkit(WebGLSupport.WebGLUIToolkitTextField input);
        /*0x8223068*/ bool get_ReadOnly();
        /*0x82230b8*/ string get_text();
        /*0x82230dc*/ void set_text(string value);
        /*0x8223100*/ string get_placeholder();
        /*0x82231c8*/ int get_fontSize();
        /*0x82231d0*/ WebGLSupport.ContentType get_contentType();
        /*0x82232a0*/ WebGLSupport.LineType get_lineType();
        /*0x82232cc*/ int get_characterLimit();
        /*0x822331c*/ int get_caretPosition();
        /*0x822336c*/ bool get_isFocused();
        /*0x8223374*/ int get_selectionFocusPosition();
        /*0x82233c4*/ void set_selectionFocusPosition(int value);
        /*0x822341c*/ int get_selectionAnchorPosition();
        /*0x822346c*/ void set_selectionAnchorPosition(int value);
        /*0x82234c4*/ bool get_OnFocusSelectAll();
        /*0x822354c*/ bool get_EnableMobileSupport();
        /*0x8223554*/ UnityEngine.Rect GetScreenCoordinates();
        /*0x8223620*/ void ActivateInputField();
        /*0x8223624*/ void DeactivateInputField();
        /*0x8223648*/ void Rebuild();
    }

    namespace Detail
    {
        class RebuildChecker
        {
            /*0x10*/ WebGLSupport.IInputField input;
            /*0x18*/ string beforeString;
            /*0x20*/ int beforeCaretPosition;
            /*0x24*/ int beforeSelectionFocusPosition;
            /*0x28*/ int beforeSelectionAnchorPosition;

            /*0x8221c78*/ RebuildChecker(WebGLSupport.IInputField input);
            /*0x8221d48*/ bool NeedRebuild(bool debug);
        }

        class Support
        {
            static /*0x8222538*/ UnityEngine.Rect GetScreenCoordinates(UnityEngine.RectTransform uiElement);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 49F7FE93B6193E7AD7372FDD6DDF41BEE1E669E303DD56593D8DA557CDEEC627;
    static /*0x2d1*/ <PrivateImplementationDetails> BC03AF83DF9110317BEC6ADBD791C41E15922141BDE0AB6F8686934DAEC529C7;

    struct __StaticArrayInitTypeSize=501
    {
    }

    struct __StaticArrayInitTypeSize=721
    {
    }
}
