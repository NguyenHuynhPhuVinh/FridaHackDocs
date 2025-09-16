class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x8206888*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x820697c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        /*0x8206984*/ KeyboardEventHandler(object object, nint method);
        /*0x8206a90*/ void Invoke(WebGLSupport.WebGLInput input, WebGLSupport.KeyboardEvent keyboardEvent);
        /*0x8206aa4*/ System.IAsyncResult BeginInvoke(WebGLSupport.WebGLInput input, WebGLSupport.KeyboardEvent keyboardEvent, System.AsyncCallback callback, object object);
        /*0x8206acc*/ void EndInvoke(System.IAsyncResult result);
    }

    class KeyboardEvent
    {
        /*0x10*/ string <Key>k__BackingField;
        /*0x18*/ int <Code>k__BackingField;
        /*0x1c*/ bool <ShiftKey>k__BackingField;
        /*0x1d*/ bool <CtrlKey>k__BackingField;
        /*0x1e*/ bool <AltKey>k__BackingField;

        /*0x8206b00*/ KeyboardEvent(string key, int code, bool shiftKey, bool ctrlKey, bool altKey);
        /*0x8206ad8*/ string get_Key();
        /*0x8206ae0*/ int get_Code();
        /*0x8206ae8*/ bool get_ShiftKey();
        /*0x8206af0*/ bool get_CtrlKey();
        /*0x8206af8*/ bool get_AltKey();
    }

    class WebGLInputMobilePlugin
    {
        static /*0x8206b64*/ int WebGLInputMobileRegister(System.Action<int> OnTouchEnd);
        static /*0x8206b6c*/ void WebGLInputMobileOnFocusOut(int id, System.Action<int> OnFocusOut);
        /*0x8206b70*/ WebGLInputMobilePlugin();
    }

    class WebGLInputMobile : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, WebGLSupport.WebGLInputMobile> instances;
        /*0x20*/ int id;

        static /*0x8207714*/ WebGLInputMobile();
        static /*0x8206b78*/ void OnTouchEnd(int id);
        static /*0x82075f4*/ System.Collections.IEnumerator RegisterOnFocusOut(int id);
        static /*0x8206c3c*/ void OnFocusOut(int id);
        static /*0x820767c*/ System.Collections.IEnumerator ExecFocusOut(int id);
        /*0x8207704*/ WebGLInputMobile();
        /*0x8206cdc*/ void Awake();
        /*0x8206ce8*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);

        class <ExecFocusOut>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int id;

            /*0x82076dc*/ <ExecFocusOut>d__7(int <>1__state);
            /*0x82077ac*/ void System.IDisposable.Dispose();
            /*0x82077b0*/ bool MoveNext();
            /*0x8207a9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x8207aa4*/ void System.Collections.IEnumerator.Reset();
            /*0x8207adc*/ object System.Collections.IEnumerator.get_Current();
        }

        class <RegisterOnFocusOut>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int id;

            /*0x8207654*/ <RegisterOnFocusOut>d__5(int <>1__state);
            /*0x8207ae4*/ void System.IDisposable.Dispose();
            /*0x8207ae8*/ bool MoveNext();
            /*0x8207b94*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x8207b9c*/ void System.Collections.IEnumerator.Reset();
            /*0x8207bd4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class WebGLInputManipulator : UnityEngine.UIElements.Manipulator
    {
        /*0x18*/ UnityEngine.GameObject go;
        /*0x20*/ bool showHtmlElement;

        /*0x8207bdc*/ WebGLInputManipulator(bool showHtmlElement);
        /*0x8207c04*/ void RegisterCallbacksOnTarget();
        /*0x8207db0*/ void UnregisterCallbacksFromTarget();
        /*0x8207f5c*/ void OnFocusInEvent(UnityEngine.UIElements.FocusInEvent evt);
        /*0x820811c*/ void OnFocusOutEvent(UnityEngine.UIElements.FocusOutEvent evt);
    }

    class WebGLUIToolkitTextField : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UIElements.TextField <TextField>k__BackingField;

        /*0x82081cc*/ WebGLUIToolkitTextField();
        /*0x82081bc*/ UnityEngine.UIElements.TextField get_TextField();
        /*0x82081c4*/ void set_TextField(UnityEngine.UIElements.TextField value);
    }

    class WebGLInputPlugin
    {
        static /*0x82081d4*/ void WebGLInputInit();
        static /*0x82081d8*/ int WebGLInputCreate(string canvasId, int x, int y, int width, int height, int fontsize, string text, string placeholder, bool isMultiLine, bool isPassword, bool isHidden, bool isMobile);
        static /*0x82081e0*/ void WebGLInputEnterSubmit(int id, bool flag);
        static /*0x82081e4*/ void WebGLInputTab(int id, System.Action<int, int> cb);
        static /*0x82081e8*/ void WebGLInputFocus(int id);
        static /*0x82081ec*/ void WebGLInputOnFocus(int id, System.Action<int> cb);
        static /*0x82081f0*/ void WebGLInputOnBlur(int id, System.Action<int> cb);
        static /*0x82081f4*/ void WebGLInputOnValueChange(int id, System.Action<int, string> cb);
        static /*0x82081f8*/ void WebGLInputOnEditEnd(int id, System.Action<int, string> cb);
        static /*0x82081fc*/ void WebGLInputOnKeyboardEvent(int id, System.Action<int, int, string, int, int, int, int> cb);
        static /*0x8208200*/ int WebGLInputSelectionStart(int id);
        static /*0x8208208*/ int WebGLInputSelectionEnd(int id);
        static /*0x8208210*/ int WebGLInputSelectionDirection(int id);
        static /*0x8208218*/ void WebGLInputSetSelectionRange(int id, int start, int end);
        static /*0x820821c*/ void WebGLInputMaxLength(int id, int maxlength);
        static /*0x8208220*/ void WebGLInputText(int id, string text);
        static /*0x8208224*/ bool WebGLInputIsFocus(int id);
        static /*0x820822c*/ void WebGLInputDelete(int id);
        static /*0x8208230*/ void WebGLInputForceBlur(int id);
        /*0x8208234*/ WebGLInputPlugin();
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

        static /*0x8208fb8*/ WebGLInput();
        static /*0x8208b98*/ void add_OnKeyboardDown(WebGLSupport.KeyboardEventHandler value);
        static /*0x8208c70*/ void remove_OnKeyboardDown(WebGLSupport.KeyboardEventHandler value);
        static /*0x8208d48*/ void add_OnKeyboardUp(WebGLSupport.KeyboardEventHandler value);
        static /*0x8208e24*/ void remove_OnKeyboardUp(WebGLSupport.KeyboardEventHandler value);
        static /*0x8208f00*/ string get_CanvasId();
        static /*0x8208f58*/ void set_CanvasId(string value);
        static /*0x820823c*/ void OnFocus(int id);
        static /*0x8208240*/ void OnBlur(int id);
        static /*0x8209908*/ System.Collections.IEnumerator Blur(int id);
        static /*0x82082e0*/ void OnValueChange(int id, string value);
        static /*0x820873c*/ void OnEditEnd(int id, string value);
        static /*0x82088fc*/ void OnTab(int id, int value);
        static /*0x82089c0*/ void OnKeyboardEvent(int id, int mode, string key, int code, int shiftKey, int ctrlKey, int altKey);
        /*0x820a354*/ WebGLInput();
        /*0x82090bc*/ int get_Id();
        /*0x82090c4*/ WebGLSupport.IInputField get_input();
        /*0x82090cc*/ void set_input(WebGLSupport.IInputField value);
        /*0x82090d4*/ WebGLSupport.IInputField Setup();
        /*0x8209464*/ void Awake();
        /*0x82095b8*/ UnityEngine.RectInt GetElemetRect();
        /*0x8206dc8*/ void OnSelect();
        /*0x8209768*/ void SyncText(System.Nullable<int> cursorIndex);
        /*0x82098fc*/ void OnWindowBlur();
        /*0x82078d8*/ void DeactivateInputField();
        /*0x8209b64*/ void Update();
        /*0x8209f38*/ void OnDestroy();
        /*0x8209fd0*/ void OnEnable();
        /*0x820a120*/ void OnDisable();
        /*0x820a1f4*/ int CompareTo(WebGLSupport.WebGLInput other);
        /*0x8209e0c*/ void CheckOutFocus();

        class WebGLInputTabFocus
        {
            static /*0x0*/ System.Collections.Generic.List<WebGLSupport.WebGLInput> inputs;

            static /*0x820a364*/ WebGLInputTabFocus();
            static /*0x820a024*/ void Add(WebGLSupport.WebGLInput input);
            static /*0x820a174*/ void Remove(WebGLSupport.WebGLInput input);
            static /*0x8209990*/ void OnTab(WebGLSupport.WebGLInput input, int value);
        }

        class <Blur>d__30 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ int id;

            /*0x8209968*/ <Blur>d__30(int <>1__state);
            /*0x820a3fc*/ void System.IDisposable.Dispose();
            /*0x820a400*/ bool MoveNext();
            /*0x820a580*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x820a588*/ void System.Collections.IEnumerator.Reset();
            /*0x820a5c0*/ object System.Collections.IEnumerator.get_Current();
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
        /*0x380b6a0*/ WebGLSupport.ContentType get_contentType();
        /*0x380b6a0*/ WebGLSupport.LineType get_lineType();
        /*0x380b6a0*/ int get_fontSize();
        /*0x380b9e8*/ string get_text();
        /*0x380d83c*/ void set_text(string value);
        /*0x380b9e8*/ string get_placeholder();
        /*0x380b6a0*/ int get_characterLimit();
        /*0x380b6a0*/ int get_caretPosition();
        /*0x380b128*/ bool get_isFocused();
        /*0x380b6a0*/ int get_selectionFocusPosition();
        /*0x380cffc*/ void set_selectionFocusPosition(int value);
        /*0x380b6a0*/ int get_selectionAnchorPosition();
        /*0x380cffc*/ void set_selectionAnchorPosition(int value);
        /*0x380b128*/ bool get_ReadOnly();
        /*0x380b128*/ bool get_OnFocusSelectAll();
        /*0x380b128*/ bool get_EnableMobileSupport();
        UnityEngine.Rect GetScreenCoordinates();
        /*0x380cb08*/ void ActivateInputField();
        /*0x380cb08*/ void DeactivateInputField();
        /*0x380cb08*/ void Rebuild();
    }

    class WrappedInputField : WebGLSupport.IInputField
    {
        /*0x10*/ UnityEngine.UI.InputField input;
        /*0x18*/ WebGLSupport.Detail.RebuildChecker checker;

        /*0x82092fc*/ WrappedInputField(UnityEngine.UI.InputField input);
        /*0x820a5c8*/ bool get_ReadOnly();
        /*0x820a5e4*/ string get_text();
        /*0x820a600*/ void set_text(string value);
        /*0x820a61c*/ string get_placeholder();
        /*0x820a718*/ int get_fontSize();
        /*0x820a73c*/ WebGLSupport.ContentType get_contentType();
        /*0x820a758*/ WebGLSupport.LineType get_lineType();
        /*0x820a774*/ int get_characterLimit();
        /*0x820a790*/ int get_caretPosition();
        /*0x820a7ac*/ bool get_isFocused();
        /*0x820a7c8*/ int get_selectionFocusPosition();
        /*0x820a7e4*/ void set_selectionFocusPosition(int value);
        /*0x820a800*/ int get_selectionAnchorPosition();
        /*0x820a81c*/ void set_selectionAnchorPosition(int value);
        /*0x820a838*/ bool get_OnFocusSelectAll();
        /*0x820a840*/ bool get_EnableMobileSupport();
        /*0x820a878*/ void ActivateInputField();
        /*0x820a894*/ void DeactivateInputField();
        /*0x820a8b0*/ void Rebuild();
        /*0x820b0b4*/ UnityEngine.Rect GetScreenCoordinates();
    }

    class WrappedTMPInputField : WebGLSupport.IInputField
    {
        /*0x10*/ TMPro.TMP_InputField input;
        /*0x18*/ WebGLSupport.Detail.RebuildChecker checker;
        /*0x20*/ UnityEngine.Coroutine delayedGraphicRebuild;

        /*0x82093cc*/ WrappedTMPInputField(TMPro.TMP_InputField input);
        /*0x820b324*/ bool get_ReadOnly();
        /*0x820b340*/ string get_text();
        /*0x820b35c*/ void set_text(string value);
        /*0x820b384*/ string FixContentTypeByInputField(string inText);
        /*0x820b7d0*/ string get_placeholder();
        /*0x820b8cc*/ int get_fontSize();
        /*0x820b908*/ WebGLSupport.ContentType get_contentType();
        /*0x820b924*/ WebGLSupport.LineType get_lineType();
        /*0x820b940*/ int get_characterLimit();
        /*0x820b95c*/ int get_caretPosition();
        /*0x820b978*/ bool get_isFocused();
        /*0x820b994*/ int get_selectionFocusPosition();
        /*0x820b9b0*/ void set_selectionFocusPosition(int value);
        /*0x820b9cc*/ int get_selectionAnchorPosition();
        /*0x820b9e8*/ void set_selectionAnchorPosition(int value);
        /*0x820ba04*/ bool get_OnFocusSelectAll();
        /*0x820ba20*/ bool get_EnableMobileSupport();
        /*0x820ba28*/ UnityEngine.Rect GetScreenCoordinates();
        /*0x820ba7c*/ void ActivateInputField();
        /*0x820ba98*/ void DeactivateInputField();
        /*0x820bab8*/ void Rebuild();
        /*0x820bb40*/ bool rectOverlaps(UnityEngine.RectTransform rectTrans1, UnityEngine.RectTransform rectTrans2);
    }

    class WrappedUIToolkit : WebGLSupport.IInputField
    {
        /*0x10*/ UnityEngine.UIElements.TextField input;

        /*0x8209394*/ WrappedUIToolkit(WebGLSupport.WebGLUIToolkitTextField input);
        /*0x820bc38*/ bool get_ReadOnly();
        /*0x820bc88*/ string get_text();
        /*0x820bcac*/ void set_text(string value);
        /*0x820bcd0*/ string get_placeholder();
        /*0x820bd98*/ int get_fontSize();
        /*0x820bda0*/ WebGLSupport.ContentType get_contentType();
        /*0x820be70*/ WebGLSupport.LineType get_lineType();
        /*0x820be9c*/ int get_characterLimit();
        /*0x820beec*/ int get_caretPosition();
        /*0x820bf3c*/ bool get_isFocused();
        /*0x820bf44*/ int get_selectionFocusPosition();
        /*0x820bf94*/ void set_selectionFocusPosition(int value);
        /*0x820bfec*/ int get_selectionAnchorPosition();
        /*0x820c03c*/ void set_selectionAnchorPosition(int value);
        /*0x820c094*/ bool get_OnFocusSelectAll();
        /*0x820c11c*/ bool get_EnableMobileSupport();
        /*0x820c124*/ UnityEngine.Rect GetScreenCoordinates();
        /*0x820c1f0*/ void ActivateInputField();
        /*0x820c1f4*/ void DeactivateInputField();
        /*0x820c218*/ void Rebuild();
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

            /*0x820a848*/ RebuildChecker(WebGLSupport.IInputField input);
            /*0x820a918*/ bool NeedRebuild(bool debug);
        }

        class Support
        {
            static /*0x820b108*/ UnityEngine.Rect GetScreenCoordinates(UnityEngine.RectTransform uiElement);
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
