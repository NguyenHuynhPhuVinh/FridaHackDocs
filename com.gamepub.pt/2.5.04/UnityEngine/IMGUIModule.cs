class <Module>
{
}

namespace UnityEngine
{
    class Event
    {
        static /*0x0*/ UnityEngine.Event s_Current;
        static /*0x8*/ UnityEngine.Event s_MasterEvent;
        /*0x10*/ nint m_Ptr;

        static /*0x2972064*/ nint Internal_Create(int displayIndex);
        static /*0x29720a4*/ void Internal_Destroy(nint ptr);
        static /*0x2972134*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x2972174*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x29721b4*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x2972554*/ UnityEngine.Event get_current();
        static /*0x29726d8*/ UnityEngine.Event KeyboardEvent(string key);
        /*0x297230c*/ Event();
        /*0x29722b0*/ Event(int displayIndex);
        /*0x2971b44*/ UnityEngine.EventType get_rawType();
        /*0x2971b84*/ UnityEngine.Vector2 get_mousePosition();
        /*0x2971c2c*/ UnityEngine.Vector2 get_delta();
        /*0x2971cd4*/ UnityEngine.PointerType get_pointerType();
        /*0x2971d14*/ UnityEngine.EventModifiers get_modifiers();
        /*0x2971d54*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x2971da4*/ int get_clickCount();
        /*0x2971de4*/ char get_character();
        /*0x2971e24*/ void set_character(char value);
        /*0x2971e74*/ UnityEngine.KeyCode get_keyCode();
        /*0x2971eb4*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x2971f04*/ void set_displayIndex(int value);
        /*0x2971f54*/ UnityEngine.EventType get_type();
        /*0x2971f94*/ void set_type(UnityEngine.EventType value);
        /*0x2971fe4*/ string get_commandName();
        /*0x2972024*/ void Internal_Use();
        /*0x29720e4*/ UnityEngine.EventType GetTypeForControl(int controlID);
        /*0x297235c*/ void Finalize();
        /*0x2972434*/ bool get_shift();
        /*0x297247c*/ bool get_control();
        /*0x29724c4*/ bool get_alt();
        /*0x297250c*/ bool get_command();
        /*0x29725a0*/ bool get_isKey();
        /*0x29725f0*/ bool get_isMouse();
        /*0x2972658*/ bool get_isDirectManipulationDevice();
        /*0x29742bc*/ int GetHashCode();
        /*0x29743a8*/ bool Equals(object obj);
        /*0x29745e8*/ string ToString();
        /*0x2974f08*/ void Use();
        /*0x2971bdc*/ void get_mousePosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x2971c84*/ void get_delta_Injected(ref UnityEngine.Vector2 ret);
    }

    enum EventType
    {
        MouseDown = 0,
        MouseUp = 1,
        MouseMove = 2,
        MouseDrag = 3,
        KeyDown = 4,
        KeyUp = 5,
        ScrollWheel = 6,
        Repaint = 7,
        Layout = 8,
        DragUpdated = 9,
        DragPerform = 10,
        DragExited = 15,
        Ignore = 11,
        Used = 12,
        ValidateCommand = 13,
        ExecuteCommand = 14,
        ContextClick = 16,
        MouseEnterWindow = 20,
        MouseLeaveWindow = 21,
        TouchDown = 30,
        TouchUp = 31,
        TouchMove = 32,
        TouchEnter = 33,
        TouchLeave = 34,
        TouchStationary = 35,
        mouseDown = 0,
        mouseUp = 1,
        mouseMove = 2,
        mouseDrag = 3,
        keyDown = 4,
        keyUp = 5,
        scrollWheel = 6,
        repaint = 7,
        layout = 8,
        dragUpdated = 9,
        dragPerform = 10,
        ignore = 11,
        used = 12,
    }

    enum EventModifiers
    {
        None = 0,
        Shift = 1,
        Control = 2,
        Alt = 4,
        Command = 8,
        Numeric = 16,
        CapsLock = 32,
        FunctionKey = 64,
    }

    enum PointerType
    {
        Mouse = 0,
        Touch = 1,
        Pen = 2,
    }

    class GUI
    {
        static /*0x0*/ int s_ScrollControlId;
        static /*0x4*/ int s_HotTextField;
        static /*0x8*/ int s_BoxHash;
        static /*0xc*/ int s_ButonHash;
        static /*0x10*/ int s_RepeatButtonHash;
        static /*0x14*/ int s_ToggleHash;
        static /*0x18*/ int s_ButtonGridHash;
        static /*0x1c*/ int s_SliderHash;
        static /*0x20*/ int s_BeginGroupHash;
        static /*0x24*/ int s_ScrollviewHash;
        static /*0x28*/ int <scrollTroughSide>k__BackingField;
        static /*0x30*/ System.DateTime <nextScrollStepTime>k__BackingField;
        static /*0x38*/ UnityEngine.GUISkin s_Skin;
        static /*0x40*/ UnityEngine.Rect s_ToolTipRect;
        static /*0x50*/ UnityEngineInternal.GenericStack <scrollViewStates>k__BackingField;

        static /*0x29754bc*/ GUI();
        static /*0x29751cc*/ void set_changed(bool value);
        static /*0x297520c*/ bool get_usePageScrollbars();
        static /*0x2975240*/ void GrabMouseControl(int id);
        static /*0x2975280*/ bool HasMouseControl(int id);
        static /*0x29752c0*/ void ReleaseMouseControl();
        static /*0x29752f4*/ void InternalRepaintEditorWindow();
        static /*0x2975328*/ UnityEngine.Rect Internal_DoWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout);
        static /*0x2975768*/ int get_scrollTroughSide();
        static /*0x29757cc*/ void set_scrollTroughSide(int value);
        static /*0x2975834*/ System.DateTime get_nextScrollStepTime();
        static /*0x2975898*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x2975900*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x2975a7c*/ UnityEngine.GUISkin get_skin();
        static /*0x2975994*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x2975bc0*/ void Label(UnityEngine.Rect position, string text);
        static /*0x2975e2c*/ void Label(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style);
        static /*0x2975d58*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x2976190*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x2976360*/ bool Button(UnityEngine.Rect position, string text);
        static /*0x2976548*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content);
        static /*0x297644c*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x29765f0*/ bool Button(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x29767e8*/ bool DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType);
        static /*0x2976b64*/ string PasswordFieldGetStrToShow(string password, char maskChar);
        static /*0x2976cac*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style);
        static /*0x2976d70*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText);
        static /*0x2976e44*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar);
        static /*0x297758c*/ void HandleTextFieldEventForTouchscreen(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar, UnityEngine.TextEditor editor);
        static /*0x2977a04*/ void HandleTextFieldEventForDesktop(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, UnityEngine.TextEditor editor);
        static /*0x29771ec*/ void HandleTextFieldEventForDesktopWithForcedKeyboard(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, UnityEngine.TextEditor editor);
        static /*0x2978250*/ bool DoControl(UnityEngine.Rect position, int id, bool on, bool hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x2975f08*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x29766cc*/ bool DoButton(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x297877c*/ float HorizontalSlider(UnityEngine.Rect position, float value, float leftValue, float rightValue);
        static /*0x2978880*/ float Slider(UnityEngine.Rect position, float value, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        static /*0x2978a44*/ float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style);
        static /*0x29794bc*/ bool ScrollerRepeatButton(int scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style);
        static /*0x2979808*/ float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style);
        static /*0x2978ef8*/ float Scroller(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, bool horiz);
        static /*0x29799bc*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x2979a20*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background);
        static /*0x297a7a4*/ void EndScrollView(bool handleScrollWheel);
        static /*0x297b434*/ UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text);
        static /*0x297b684*/ UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text, UnityEngine.GUIStyle style);
        static /*0x297b574*/ UnityEngine.Rect DoWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, bool forceRectOnLayout);
        static /*0x297b7b8*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x297541c*/ void Internal_DoWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout, ref UnityEngine.Rect ret);

        class WindowFunction : System.MulticastDelegate
        {
            /*0x2a6b3b4*/ WindowFunction(object object, nint method);
            /*0x2a6b414*/ void Invoke(int id);
            /*0x2a6b640*/ System.IAsyncResult BeginInvoke(int id, System.AsyncCallback callback, object object);
            /*0x2a6b6c8*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class GUIClip
    {
        static /*0x2978728*/ UnityEngine.Rect get_visibleRect();
        static /*0x297c364*/ void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x297c434*/ void Internal_Pop();
        static /*0x297c468*/ UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos);
        static /*0x297a79c*/ void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x297b400*/ void Pop();
        static /*0x297c50c*/ UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos);
        static /*0x297c324*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x297c3cc*/ void Internal_Push_Injected(ref UnityEngine.Rect screenRect, ref UnityEngine.Vector2 scrollOffset, ref UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x297c4bc*/ void UnclipToWindow_Vector2_Injected(ref UnityEngine.Vector2 pos, ref UnityEngine.Vector2 ret);
    }

    class GUIContent
    {
        static /*0x0*/ UnityEngine.GUIContent s_Text;
        static /*0x8*/ UnityEngine.GUIContent s_Image;
        static /*0x10*/ UnityEngine.GUIContent s_TextImage;
        static /*0x18*/ UnityEngine.GUIContent none;
        /*0x10*/ string m_Text;
        /*0x18*/ UnityEngine.Texture m_Image;
        /*0x20*/ string m_Tooltip;

        static /*0x297c800*/ GUIContent();
        static /*0x2975ca4*/ UnityEngine.GUIContent Temp(string t);
        static /*0x297c718*/ void ClearStaticCache();
        /*0x297c520*/ GUIContent();
        /*0x297c588*/ GUIContent(string text);
        /*0x297c5f0*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x297c680*/ GUIContent(UnityEngine.GUIContent src);
        /*0x29771dc*/ string get_text();
        /*0x29771e4*/ void set_text(string value);
        /*0x297c510*/ void set_image(UnityEngine.Texture value);
        /*0x2978720*/ string get_tooltip();
        /*0x297c518*/ void set_tooltip(string value);
    }

    enum FocusType
    {
        Native = 0,
        Keyboard = 1,
        Passive = 2,
    }

    class GUILayout
    {
        static /*0x297c8c0*/ void Label(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x297c97c*/ void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297cad4*/ bool Button(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x297cb90*/ bool DoButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297cc70*/ string TextField(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297cc84*/ string DoTextField(string text, int maxLength, bool multiline, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297cef8*/ void Space(float pixels);
        static /*0x297d338*/ void FlexibleSpace();
        static /*0x297d770*/ void BeginHorizontal(UnityEngine.GUILayoutOption[] options);
        static /*0x297d81c*/ void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297dce8*/ void EndHorizontal();
        static /*0x297df58*/ void BeginVertical(UnityEngine.GUILayoutOption[] options);
        static /*0x297e004*/ void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297e1dc*/ void EndVertical();
        static /*0x297e234*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options);
        static /*0x297e508*/ void EndScrollView();
        static /*0x297e510*/ void EndScrollView(bool handleScrollWheel);
        static /*0x297bce4*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x297e5a0*/ UnityEngine.GUILayoutOption MinWidth(float minWidth);
        static /*0x297bd7c*/ UnityEngine.GUILayoutOption Height(float height);
        static /*0x297d694*/ UnityEngine.GUILayoutOption ExpandWidth(bool expand);
        static /*0x297d5f4*/ UnityEngine.GUILayoutOption ExpandHeight(bool expand);
    }

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x297d734*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

        enum Type
        {
            fixedWidth = 0,
            fixedHeight = 1,
            minWidth = 2,
            maxWidth = 3,
            minHeight = 4,
            maxHeight = 5,
            stretchWidth = 6,
            stretchHeight = 7,
            alignStart = 8,
            alignMiddle = 9,
            alignEnd = 10,
            alignJustify = 11,
            equalSize = 12,
            spacing = 13,
        }
    }

    class GUILayoutUtility
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows;
        static /*0x10*/ UnityEngine.GUILayoutUtility.LayoutCache current;
        static /*0x18*/ UnityEngine.Rect kDummyRect;
        static /*0x28*/ UnityEngine.GUIStyle s_SpaceStyle;

        static /*0x2982d7c*/ GUILayoutUtility();
        static /*0x2981c6c*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x2981d58*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x297bb50*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x2981e40*/ void Begin(int instanceID);
        static /*0x297be18*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297c0f0*/ void Layout();
        static /*0x29823f8*/ void LayoutFromEditorWindow();
        static /*0x298205c*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x29821fc*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x29825fc*/ UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType);
        static /*0x297d9f0*/ UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType);
        static /*0x297dd40*/ void EndLayoutGroup();
        static /*0x298274c*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x297ca5c*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x29827c0*/ UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297d2a8*/ UnityEngine.Rect GetRect(float width, float height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x2982b70*/ UnityEngine.Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x297d1b4*/ UnityEngine.GUIStyle get_spaceStyle();
        static /*0x2981d08*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x2981df0*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x2a6b6dc*/ LayoutCache(int instanceID);
            /*0x2a6b6d4*/ void set_id(int value);
        }
    }

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        static /*0x2983354*/ float Internal_GetCursorFlashSpeed();
        /*0x29833e4*/ GUISettings();
        /*0x2978238*/ bool get_doubleClickSelectsWord();
        /*0x2978240*/ bool get_tripleClickSelectsLine();
        /*0x2983388*/ UnityEngine.Color get_cursorColor();
        /*0x2983394*/ float get_cursorFlashSpeed();
        /*0x29833d8*/ UnityEngine.Color get_selectionColor();
    }

    class GUISkin : UnityEngine.ScriptableObject
    {
        static /*0x0*/ UnityEngine.GUIStyle ms_Error;
        static /*0x8*/ UnityEngine.GUISkin.SkinChangedDelegate m_SkinChanged;
        static /*0x10*/ UnityEngine.GUISkin current;
        /*0x18*/ UnityEngine.Font m_Font;
        /*0x20*/ UnityEngine.GUIStyle m_box;
        /*0x28*/ UnityEngine.GUIStyle m_button;
        /*0x30*/ UnityEngine.GUIStyle m_toggle;
        /*0x38*/ UnityEngine.GUIStyle m_label;
        /*0x40*/ UnityEngine.GUIStyle m_textField;
        /*0x48*/ UnityEngine.GUIStyle m_textArea;
        /*0x50*/ UnityEngine.GUIStyle m_window;
        /*0x58*/ UnityEngine.GUIStyle m_horizontalSlider;
        /*0x60*/ UnityEngine.GUIStyle m_horizontalSliderThumb;
        /*0x68*/ UnityEngine.GUIStyle m_horizontalSliderThumbExtent;
        /*0x70*/ UnityEngine.GUIStyle m_verticalSlider;
        /*0x78*/ UnityEngine.GUIStyle m_verticalSliderThumb;
        /*0x80*/ UnityEngine.GUIStyle m_verticalSliderThumbExtent;
        /*0x88*/ UnityEngine.GUIStyle m_SliderMixed;
        /*0x90*/ UnityEngine.GUIStyle m_horizontalScrollbar;
        /*0x98*/ UnityEngine.GUIStyle m_horizontalScrollbarThumb;
        /*0xa0*/ UnityEngine.GUIStyle m_horizontalScrollbarLeftButton;
        /*0xa8*/ UnityEngine.GUIStyle m_horizontalScrollbarRightButton;
        /*0xb0*/ UnityEngine.GUIStyle m_verticalScrollbar;
        /*0xb8*/ UnityEngine.GUIStyle m_verticalScrollbarThumb;
        /*0xc0*/ UnityEngine.GUIStyle m_verticalScrollbarUpButton;
        /*0xc8*/ UnityEngine.GUIStyle m_verticalScrollbarDownButton;
        /*0xd0*/ UnityEngine.GUIStyle m_ScrollView;
        /*0xd8*/ UnityEngine.GUIStyle[] m_CustomStyles;
        /*0xe0*/ UnityEngine.GUISettings m_Settings;
        /*0xe8*/ System.Collections.Generic.Dictionary<string, UnityEngine.GUIStyle> m_Styles;

        static /*0x298356c*/ void CleanupRoots();
        static /*0x29837f0*/ UnityEngine.GUIStyle get_error();
        /*0x2983458*/ GUISkin();
        /*0x29834e0*/ void OnEnable();
        /*0x2978248*/ UnityEngine.Font get_font();
        /*0x29835c0*/ void set_font(UnityEngine.Font value);
        /*0x29836a0*/ UnityEngine.GUIStyle get_box();
        /*0x29836a8*/ void set_box(UnityEngine.GUIStyle value);
        /*0x2975d50*/ UnityEngine.GUIStyle get_label();
        /*0x29836b0*/ void set_label(UnityEngine.GUIStyle value);
        /*0x29836b8*/ UnityEngine.GUIStyle get_textField();
        /*0x29836c0*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x29836c8*/ UnityEngine.GUIStyle get_textArea();
        /*0x29836d0*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x2976444*/ UnityEngine.GUIStyle get_button();
        /*0x29836d8*/ void set_button(UnityEngine.GUIStyle value);
        /*0x29836e0*/ UnityEngine.GUIStyle get_toggle();
        /*0x29836e8*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x297b56c*/ UnityEngine.GUIStyle get_window();
        /*0x29836f0*/ void set_window(UnityEngine.GUIStyle value);
        /*0x2978868*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x29836f8*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x2978870*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x2983700*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x2978878*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x2983708*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x2983710*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x2983718*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x2983720*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x2983728*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x2983730*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x2983738*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x2983740*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x2983748*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x2983750*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x2983758*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x2983760*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x2983768*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x2983770*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x2983778*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x2983780*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x2983788*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x2983790*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x2983798*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x29837a0*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x29837a8*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x29837b0*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x29837b8*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x29837c0*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x29837c8*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x29837d0*/ UnityEngine.GUIStyle get_scrollView();
        /*0x29837d8*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x29837e0*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x29837e8*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x2978230*/ UnityEngine.GUISettings get_settings();
        /*0x29834e4*/ void Apply();
        /*0x29838b4*/ void BuildStyleCache();
        /*0x2978bf8*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x2984470*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x2975b14*/ void MakeCurrent();
        /*0x29844fc*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0x2a6b7b4*/ SkinChangedDelegate(object object, nint method);
            /*0x2a6b814*/ void Invoke();
            /*0x2a6ba20*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2a6ba4c*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class GUIStateObjects
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, object> s_StateCache;

        static /*0x2a61648*/ GUIStateObjects();
        static /*0x2a61524*/ object GetStateObject(System.Type t, int controlID);
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x2a63ca8*/ nint Init();
        static /*0x2a62c20*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x2a63d1c*/ GUIStyleState();
        /*0x2a63d68*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x2a63bb0*/ void set_background(UnityEngine.Texture2D value);
        /*0x2a63c00*/ void set_textColor(UnityEngine.Color value);
        /*0x2a63cdc*/ void Cleanup();
        /*0x2a63da0*/ void Finalize();
        /*0x2a63c58*/ void set_textColor_Injected(ref UnityEngine.Color value);
    }

    class GUIStyle
    {
        static /*0x0*/ bool showKeyboardFocus;
        static /*0x8*/ UnityEngine.GUIStyle s_None;
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyleState m_Normal;
        /*0x20*/ UnityEngine.GUIStyleState m_Hover;
        /*0x28*/ UnityEngine.GUIStyleState m_Active;
        /*0x30*/ UnityEngine.GUIStyleState m_Focused;
        /*0x38*/ UnityEngine.GUIStyleState m_OnNormal;
        /*0x40*/ UnityEngine.GUIStyleState m_OnHover;
        /*0x48*/ UnityEngine.GUIStyleState m_OnActive;
        /*0x50*/ UnityEngine.GUIStyleState m_OnFocused;
        /*0x58*/ UnityEngine.RectOffset m_Border;
        /*0x60*/ UnityEngine.RectOffset m_Padding;
        /*0x68*/ UnityEngine.RectOffset m_Margin;
        /*0x70*/ UnityEngine.RectOffset m_Overflow;
        /*0x78*/ string m_Name;

        static /*0x2a63b60*/ GUIStyle();
        static /*0x2a61ca0*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x2a61ce0*/ void Internal_Destroy(nint self);
        static /*0x2a61dc0*/ float Internal_GetLineHeight(nint target);
        static /*0x2a627e8*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x2a628d0*/ bool IsTooltipActive(string tooltip);
        static /*0x2a62910*/ float Internal_GetCursorFlashOffset();
        static /*0x2a62944*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x2a63880*/ UnityEngine.GUIStyle get_none();
        static /*0x2a62880*/ void SetMouseTooltip_Injected(string tooltip, ref UnityEngine.Rect screenRect);
        /*0x2a62984*/ GUIStyle();
        /*0x2a616d0*/ string get_rawName();
        /*0x2a61710*/ void set_rawName(string value);
        /*0x2a61760*/ UnityEngine.Font get_font();
        /*0x2a617a0*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x2a617e0*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x2a61830*/ bool get_wordWrap();
        /*0x2a61870*/ void set_wordWrap(bool value);
        /*0x2a618c0*/ UnityEngine.Vector2 get_contentOffset();
        /*0x2a61968*/ void set_contentOffset(UnityEngine.Vector2 value);
        /*0x2a61a0c*/ float get_fixedWidth();
        /*0x2a61a4c*/ float get_fixedHeight();
        /*0x2a61a8c*/ bool get_stretchWidth();
        /*0x2a61acc*/ void set_stretchWidth(bool value);
        /*0x2a61b1c*/ bool get_stretchHeight();
        /*0x2a61b5c*/ void set_stretchHeight(bool value);
        /*0x2a61bac*/ void set_fontSize(int value);
        /*0x2a61bfc*/ void set_Internal_clipOffset(UnityEngine.Vector2 value);
        /*0x2a61d20*/ nint GetStyleStatePtr(int idx);
        /*0x2a61d70*/ nint GetRectOffsetPtr(int idx);
        /*0x2a61e00*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2a61f20*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x2a62010*/ void Internal_DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int pos, UnityEngine.Color cursorColor);
        /*0x2a620fc*/ void Internal_DrawWithTextSelection(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, UnityEngine.Color cursorColor, UnityEngine.Color selectionColor);
        /*0x2a62290*/ UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x2a6237c*/ int Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition);
        /*0x2a62454*/ string Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex);
        /*0x2a62544*/ UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content);
        /*0x2a625fc*/ UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize);
        /*0x2a626d0*/ float Internal_CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x2a62730*/ UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content);
        /*0x2a62a18*/ void Finalize();
        /*0x2a62b1c*/ string get_name();
        /*0x2a62b6c*/ void set_name(string value);
        /*0x2a62bc0*/ UnityEngine.GUIStyleState get_normal();
        /*0x2a62c8c*/ UnityEngine.RectOffset get_margin();
        /*0x2a62d38*/ UnityEngine.RectOffset get_padding();
        /*0x2a62de4*/ float get_lineHeight();
        /*0x2a62eec*/ void Draw(UnityEngine.Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2a62fdc*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2a62ff0*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x2a63004*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x2a62fb8*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2a63240*/ void DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int character);
        /*0x2a63440*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, UnityEngine.Color selectionColor);
        /*0x2a63670*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition);
        /*0x2a63878*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter);
        /*0x2a6391c*/ UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x2a63920*/ int GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition);
        /*0x2a63924*/ UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content);
        /*0x2a63928*/ UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints);
        /*0x2a6392c*/ float CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x2a6398c*/ bool get_isHeightDependantOnWidth();
        /*0x2a63a3c*/ void CalcMinMaxWidth(UnityEngine.GUIContent content, ref float minWidth, ref float maxWidth);
        /*0x2a63a68*/ string ToString();
        /*0x2a61918*/ void get_contentOffset_Injected(ref UnityEngine.Vector2 ret);
        /*0x2a619bc*/ void set_contentOffset_Injected(ref UnityEngine.Vector2 value);
        /*0x2a61c50*/ void set_Internal_clipOffset_Injected(ref UnityEngine.Vector2 value);
        /*0x2a61e98*/ void Internal_Draw_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x2a61fa0*/ void Internal_Draw2_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x2a6208c*/ void Internal_DrawCursor_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int pos, ref UnityEngine.Color cursorColor);
        /*0x2a621d0*/ void Internal_DrawWithTextSelection_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref UnityEngine.Color cursorColor, ref UnityEngine.Color selectionColor);
        /*0x2a6230c*/ void Internal_GetCursorPixelPosition_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex, ref UnityEngine.Vector2 ret);
        /*0x2a623ec*/ int Internal_GetCursorStringIndex_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, ref UnityEngine.Vector2 cursorPixelPosition);
        /*0x2a624d4*/ string Internal_GetSelectedRenderedText_Injected(ref UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex);
        /*0x2a625a4*/ void Internal_CalcSize_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        /*0x2a62668*/ void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, ref UnityEngine.Vector2 ret);
        /*0x2a62790*/ void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
    }

    enum ImagePosition
    {
        ImageLeft = 0,
        ImageAbove = 1,
        ImageOnly = 2,
        TextOnly = 3,
    }

    class GUITargetAttribute : System.Attribute
    {
        /*0x10*/ int displayMask;

        static /*0x2a63e58*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
    }

    class GUIUtility
    {
        static /*0x0*/ int s_ControlCount;
        static /*0x4*/ int s_SkinMode;
        static /*0x8*/ int s_OriginalID;
        static /*0x10*/ System.Action takeCapture;
        static /*0x18*/ System.Action releaseCapture;
        static /*0x20*/ System.Func<int, nint, bool> processEvent;
        static /*0x28*/ System.Func<System.Exception, bool> endContainerGUIFromException;
        static /*0x30*/ System.Action guiChanged;
        static /*0x38*/ bool <guiIsExiting>k__BackingField;
        static /*0x40*/ System.Func<bool> s_HasCurrentWindowKeyFocusFunc;

        static /*0x2a65428*/ GUIUtility();
        static /*0x2a63fe8*/ float get_pixelsPerPoint();
        static /*0x2a6401c*/ int get_guiDepth();
        static /*0x2a64050*/ void set_textFieldInput(bool value);
        static /*0x2a64090*/ string get_systemCopyBuffer();
        static /*0x2a640c4*/ void set_systemCopyBuffer(string value);
        static /*0x2a64104*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x2a64204*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x2a642b8*/ string get_compositionString();
        static /*0x2a642ec*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x2a643b0*/ int Internal_GetHotControl();
        static /*0x2a643e4*/ int Internal_GetKeyboardControl();
        static /*0x2a64418*/ void Internal_SetHotControl(int value);
        static /*0x2a64458*/ void Internal_SetKeyboardControl(int value);
        static /*0x2a64498*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x2a644d8*/ void Internal_ExitGUI();
        static /*0x2a6450c*/ void MarkGUIChanged();
        static /*0x2a64584*/ int GetControlID(UnityEngine.FocusType focus);
        static /*0x2a645e8*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x2a64690*/ object GetStateObject(System.Type t, int controlID);
        static /*0x2a64700*/ void set_guiIsExiting(bool value);
        static /*0x2a630e0*/ int get_hotControl();
        static /*0x2a6476c*/ void set_hotControl(int value);
        static /*0x2a647ec*/ void TakeCapture();
        static /*0x2a64864*/ void RemoveCapture();
        static /*0x2a63804*/ int get_keyboardControl();
        static /*0x2a648dc*/ void set_keyboardControl(int value);
        static /*0x2a63154*/ bool HasKeyFocus(int controlID);
        static /*0x2a6495c*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x2a64a10*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x2a64ae8*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x2a64cf8*/ void EndGUI(int layoutType);
        static /*0x2a64f14*/ bool EndGUIFromException(System.Exception exception);
        static /*0x2a64ff4*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x2a64bb8*/ void ResetGlobalState();
        static /*0x2a650b8*/ bool IsExitGUIException(System.Exception exception);
        static /*0x2a64f94*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x2a65140*/ void CheckOnGUI();
        static /*0x2a6520c*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x2a652bc*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x2a65360*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt);
        static /*0x2a641ac*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x2a64370*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class ExitGUIException : System.Exception
    {
        /*0x29750e0*/ ExitGUIException(string message);
    }

    class GUILayoutEntry
    {
        static /*0x0*/ UnityEngine.Rect kDummyRect;
        static /*0x10*/ int indent;
        /*0x10*/ float minWidth;
        /*0x14*/ float maxWidth;
        /*0x18*/ float minHeight;
        /*0x1c*/ float maxHeight;
        /*0x20*/ UnityEngine.Rect rect;
        /*0x30*/ int stretchWidth;
        /*0x34*/ int stretchHeight;
        /*0x38*/ bool consideredForMargin;
        /*0x40*/ UnityEngine.GUIStyle m_Style;

        static /*0x297f398*/ GUILayoutEntry();
        /*0x297e784*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x297e8a4*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options);
        /*0x297e63c*/ UnityEngine.GUIStyle get_style();
        /*0x297e644*/ void set_style(UnityEngine.GUIStyle value);
        /*0x297e654*/ int get_marginLeft();
        /*0x297e680*/ int get_marginRight();
        /*0x297e6ac*/ int get_marginTop();
        /*0x297e6d8*/ int get_marginBottom();
        /*0x297e704*/ int get_marginHorizontal();
        /*0x297e744*/ int get_marginVertical();
        /*0x297e9b8*/ void CalcWidth();
        /*0x297e9bc*/ void CalcHeight();
        /*0x297e9c0*/ void SetHorizontal(float x, float width);
        /*0x297ea00*/ void SetVertical(float y, float height);
        /*0x297ea40*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x297ead0*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x297edb4*/ string ToString();
    }

    class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ UnityEngine.GUIContent m_Content;
        /*0x50*/ float m_ForcedMinHeight;
        /*0x54*/ float m_ForcedMaxHeight;

        /*0x2a65474*/ GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options);
        /*0x2a6555c*/ void CalcWidth();
        /*0x2a655d4*/ void CalcHeight();
    }

    class GUILayoutGroup : UnityEngine.GUILayoutEntry
    {
        static /*0x0*/ UnityEngine.GUILayoutEntry none;
        /*0x48*/ System.Collections.Generic.List<UnityEngine.GUILayoutEntry> entries;
        /*0x50*/ bool isVertical;
        /*0x51*/ bool resetCoords;
        /*0x54*/ float spacing;
        /*0x58*/ bool sameSize;
        /*0x59*/ bool isWindow;
        /*0x5c*/ int windowID;
        /*0x60*/ int m_Cursor;
        /*0x64*/ int m_StretchableCountX;
        /*0x68*/ int m_StretchableCountY;
        /*0x6c*/ bool m_UserSpecifiedWidth;
        /*0x6d*/ bool m_UserSpecifiedHeight;
        /*0x70*/ float m_ChildMinWidth;
        /*0x74*/ float m_ChildMaxWidth;
        /*0x78*/ float m_ChildMinHeight;
        /*0x7c*/ float m_ChildMaxHeight;
        /*0x80*/ int m_MarginLeft;
        /*0x84*/ int m_MarginRight;
        /*0x88*/ int m_MarginTop;
        /*0x8c*/ int m_MarginBottom;

        static /*0x2981bac*/ GUILayoutGroup();
        /*0x297f43c*/ GUILayoutGroup();
        /*0x297f41c*/ int get_marginLeft();
        /*0x297f424*/ int get_marginRight();
        /*0x297f42c*/ int get_marginTop();
        /*0x297f434*/ int get_marginBottom();
        /*0x297f558*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x297f684*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x297f700*/ void ResetCursor();
        /*0x297f708*/ UnityEngine.GUILayoutEntry GetNext();
        /*0x297faac*/ void Add(UnityEngine.GUILayoutEntry e);
        /*0x297fb10*/ void CalcWidth();
        /*0x2980154*/ void SetHorizontal(float x, float width);
        /*0x29809a4*/ void CalcHeight();
        /*0x2980f58*/ void SetVertical(float y, float height);
        /*0x29817a4*/ string ToString();
    }

    class GUIScrollGroup : UnityEngine.GUILayoutGroup
    {
        /*0x90*/ float calcMinWidth;
        /*0x94*/ float calcMaxWidth;
        /*0x98*/ float calcMinHeight;
        /*0x9c*/ float calcMaxHeight;
        /*0xa0*/ float clientWidth;
        /*0xa4*/ float clientHeight;
        /*0xa8*/ bool allowHorizontalScroll;
        /*0xa9*/ bool allowVerticalScroll;
        /*0xaa*/ bool needsHorizontalScrollbar;
        /*0xab*/ bool needsVerticalScrollbar;
        /*0xb0*/ UnityEngine.GUIStyle horizontalScrollbar;
        /*0xb8*/ UnityEngine.GUIStyle verticalScrollbar;

        /*0x2982e9c*/ GUIScrollGroup();
        /*0x2982f04*/ void CalcWidth();
        /*0x2982f94*/ void SetHorizontal(float x, float width);
        /*0x29830a0*/ void CalcHeight();
        /*0x2983184*/ void SetVertical(float y, float height);
    }

    class ScrollViewState
    {
        /*0x10*/ UnityEngine.Rect position;
        /*0x20*/ UnityEngine.Rect visibleRect;
        /*0x30*/ UnityEngine.Rect viewRect;
        /*0x40*/ UnityEngine.Vector2 scrollPosition;
        /*0x48*/ bool apply;
        /*0x49*/ bool isDuringTouchScroll;
        /*0x4c*/ UnityEngine.Vector2 touchScrollStartMousePosition;
        /*0x54*/ UnityEngine.Vector2 touchScrollStartPosition;
        /*0x5c*/ UnityEngine.Vector2 velocity;
        /*0x64*/ float previousTimeSinceStartup;

        /*0x2a6568c*/ ScrollViewState();
    }

    class SliderState
    {
        /*0x10*/ float dragStartPos;
        /*0x14*/ float dragStartValue;
        /*0x18*/ bool isDragging;

        /*0x2a66f84*/ SliderState();
    }

    struct SliderHandler
    {
        /*0x10*/ UnityEngine.Rect position;
        /*0x20*/ float currentValue;
        /*0x24*/ float size;
        /*0x28*/ float start;
        /*0x2c*/ float end;
        /*0x30*/ UnityEngine.GUIStyle slider;
        /*0x38*/ UnityEngine.GUIStyle thumb;
        /*0x40*/ UnityEngine.GUIStyle thumbExtent;
        /*0x48*/ bool horiz;
        /*0x4c*/ int id;

        /*0xb1fc5c*/ SliderHandler(UnityEngine.Rect position, float currentValue, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        /*0xb1fc84*/ float Handle();
        /*0xb1fc8c*/ float OnMouseDown();
        /*0xb1fc94*/ float OnMouseDrag();
        /*0xb1fc9c*/ float OnMouseUp();
        /*0xb1fca4*/ float OnRepaint();
        /*0xb1fcac*/ UnityEngine.EventType CurrentEventType();
        /*0xb1fcb4*/ int CurrentScrollTroughSide();
        /*0xb1fcbc*/ bool IsEmptySlider();
        /*0xb1fccc*/ bool SupportsPageMovements();
        /*0xb1fcd4*/ float PageMovementValue();
        /*0xb1fcdc*/ float PageUpMovementBound();
        /*0xb1fce4*/ UnityEngine.Event CurrentEvent();
        /*0xb1fcec*/ float ValueForCurrentMousePosition();
        /*0xb1fcf4*/ float Clamp(float value);
        /*0xb1fcfc*/ UnityEngine.Rect ThumbSelectionRect();
        /*0xb1fd04*/ void StartDraggingWithValue(float dragStartValue);
        /*0xb1fd0c*/ UnityEngine.SliderState SliderState();
        /*0xb1fd14*/ UnityEngine.Rect ThumbExtRect();
        /*0xb1fd1c*/ UnityEngine.Rect ThumbRect();
        /*0xb1fd24*/ UnityEngine.Rect VerticalThumbRect();
        /*0xb1fd2c*/ UnityEngine.Rect HorizontalThumbRect();
        /*0xb1fd34*/ float ClampedCurrentValue();
        /*0xb1fd40*/ float MousePosition();
        /*0xb1fd48*/ float ValuesPerPixel();
        /*0xb1fd50*/ float ThumbSize();
        /*0xb1fd58*/ float MaxValue();
        /*0xb1fd88*/ float MinValue();
    }

    class TextEditor
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextEditor.TextEditOp> s_Keyactions;
        /*0x10*/ UnityEngine.TouchScreenKeyboard keyboardOnScreen;
        /*0x18*/ int controlID;
        /*0x20*/ UnityEngine.GUIStyle style;
        /*0x28*/ bool multiline;
        /*0x29*/ bool hasHorizontalCursorPos;
        /*0x2a*/ bool isPasswordField;
        /*0x2b*/ bool m_HasFocus;
        /*0x2c*/ UnityEngine.Vector2 scrollOffset;
        /*0x38*/ UnityEngine.GUIContent m_Content;
        /*0x40*/ UnityEngine.Rect m_Position;
        /*0x50*/ int m_CursorIndex;
        /*0x54*/ int m_SelectIndex;
        /*0x58*/ bool m_RevealCursor;
        /*0x5c*/ UnityEngine.Vector2 graphicalCursorPos;
        /*0x64*/ UnityEngine.Vector2 graphicalSelectCursorPos;
        /*0x6c*/ bool m_MouseDragSelectsWholeWords;
        /*0x70*/ int m_DblClickInitPos;
        /*0x74*/ UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap;
        /*0x75*/ bool m_bJustSelected;
        /*0x78*/ int m_iAltCursorPos;
        /*0x80*/ string oldText;
        /*0x88*/ int oldPos;
        /*0x8c*/ int oldSelectPos;

        static /*0x2a6b064*/ string ReplaceNewlinesWithSpaces(string value);
        static /*0x2a6b0fc*/ void MapKey(string key, UnityEngine.TextEditor.TextEditOp action);
        /*0x2a675b4*/ TextEditor();
        /*0x2a66f8c*/ string get_text();
        /*0x2a66fa8*/ void set_text(string value);
        /*0x2a67078*/ UnityEngine.Rect get_position();
        /*0x2a67084*/ void set_position(UnityEngine.Rect value);
        /*0x2a674c0*/ UnityEngine.Rect get_localPosition();
        /*0x2a674cc*/ int get_cursorIndex();
        /*0x2a674d4*/ void set_cursorIndex(int value);
        /*0x2a6753c*/ int get_selectIndex();
        /*0x2a67544*/ void set_selectIndex(int value);
        /*0x2a675a4*/ void ClearCursorPos();
        /*0x2a67684*/ void OnFocus();
        /*0x2a67728*/ void OnLostFocus();
        /*0x2a67754*/ void GrabGraphicalCursorPos();
        /*0x2a677d4*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x2a677dc*/ bool HandleKeyEvent(UnityEngine.Event e, bool textIsReadOnly);
        /*0x2a68650*/ bool DeleteLineBack();
        /*0x2a688e8*/ bool DeleteWordBack();
        /*0x2a68a78*/ bool DeleteWordForward();
        /*0x2a68d00*/ bool Delete();
        /*0x2a68eb8*/ bool Backspace();
        /*0x2a676d4*/ void SelectAll();
        /*0x2a69048*/ void SelectNone();
        /*0x2a68734*/ bool get_hasSelection();
        /*0x2a68744*/ bool DeleteSelection();
        /*0x2a69078*/ void ReplaceSelection(string replace);
        /*0x2a69114*/ void Insert(char c);
        /*0x2a6914c*/ void MoveRight();
        /*0x2a691d4*/ void MoveLeft();
        /*0x2a69238*/ void MoveUp();
        /*0x2a692e8*/ void MoveDown();
        /*0x2a693c8*/ void MoveLineStart();
        /*0x2a69464*/ void MoveLineEnd();
        /*0x2a69518*/ void MoveGraphicalLineStart();
        /*0x2a69658*/ void MoveGraphicalLineEnd();
        /*0x2a697ac*/ void MoveTextStart();
        /*0x2a697d8*/ void MoveTextEnd();
        /*0x2a69824*/ int IndexOfEndOfLine(int startIndex);
        /*0x2a6988c*/ void MoveParagraphForward();
        /*0x2a69918*/ void MoveParagraphBackward();
        /*0x2a699b0*/ void MoveCursorToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x2a69a04*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x2a69a94*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x2a69e68*/ void SelectLeft();
        /*0x2a69ec4*/ void SelectRight();
        /*0x2a69f20*/ void SelectUp();
        /*0x2a69f84*/ void SelectDown();
        /*0x2a6a000*/ void SelectTextEnd();
        /*0x2a6a03c*/ void SelectTextStart();
        /*0x2a6a044*/ void MouseDragSelectsWholeWords(bool on);
        /*0x2a6a058*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x2a69564*/ int GetGraphicalLineStart(int p);
        /*0x2a696a4*/ int GetGraphicalLineEnd(int p);
        /*0x2a6a060*/ int FindNextSeperator(int startPos);
        /*0x2a6a220*/ int FindPrevSeperator(int startPos);
        /*0x2a6a2c0*/ void MoveWordRight();
        /*0x2a6a328*/ void MoveToStartOfNextWord();
        /*0x2a6a38c*/ void MoveToEndOfPreviousWord();
        /*0x2a6a3f0*/ void SelectToStartOfNextWord();
        /*0x2a6a428*/ void SelectToEndOfPreviousWord();
        /*0x2a6a108*/ UnityEngine.TextEditor.CharacterType ClassifyChar(int index);
        /*0x2a68b30*/ int FindStartOfNextWord(int p);
        /*0x2a689a0*/ int FindEndOfPreviousWord(int p);
        /*0x2a6a460*/ void MoveWordLeft();
        /*0x2a6a4b4*/ void SelectWordRight();
        /*0x2a6a52c*/ void SelectWordLeft();
        /*0x2a6a5a4*/ void ExpandSelectGraphicalLineStart();
        /*0x2a6a60c*/ void ExpandSelectGraphicalLineEnd();
        /*0x2a6a674*/ void SelectGraphicalLineStart();
        /*0x2a6a6ac*/ void SelectGraphicalLineEnd();
        /*0x2a6a6e4*/ void SelectParagraphForward();
        /*0x2a6a780*/ void SelectParagraphBackward();
        /*0x2a6a844*/ void SelectCurrentWord();
        /*0x2a69d10*/ int FindEndOfClassification(int p, UnityEngine.TextEditor.Direction dir);
        /*0x2a6a8e4*/ void SelectCurrentParagraph();
        /*0x2a6a98c*/ void UpdateScrollOffsetIfNeeded(UnityEngine.Event evt);
        /*0x2a67114*/ void UpdateScrollOffset();
        /*0x2a6a9ec*/ void DrawCursor(string newText);
        /*0x2a68254*/ bool PerformOperation(UnityEngine.TextEditor.TextEditOp operation, bool textIsReadOnly);
        /*0x2a6b02c*/ void SaveBackup();
        /*0x2a6ae50*/ bool Cut();
        /*0x2a6ae84*/ void Copy();
        /*0x2a6af58*/ bool Paste();
        /*0x2a67910*/ void InitKeyActions();
        /*0x2a691c8*/ void DetectFocusChange();
        /*0x2a6b190*/ void OnDetectFocusChange();
        /*0x2a6b25c*/ void OnCursorIndexChange();
        /*0x2a6b260*/ void OnSelectIndexChange();
        /*0x2a6b264*/ void ClampTextIndex(ref int index);
        /*0x2a67034*/ void EnsureValidCodePointIndex(ref int index);
        /*0x2a6b2b4*/ bool IsValidCodePointIndex(int index);
        /*0x2a68f78*/ int PreviousCodePointIndex(int index);
        /*0x2a68dc0*/ int NextCodePointIndex(int index);

        enum DblClickSnapping
        {
            WORDS = 0,
            PARAGRAPHS = 1,
        }

        enum CharacterType
        {
            LetterLike = 0,
            Symbol = 1,
            Symbol2 = 2,
            WhiteSpace = 3,
        }

        enum Direction
        {
            Forward = 0,
            Backward = 1,
        }

        enum TextEditOp
        {
            MoveLeft = 0,
            MoveRight = 1,
            MoveUp = 2,
            MoveDown = 3,
            MoveLineStart = 4,
            MoveLineEnd = 5,
            MoveTextStart = 6,
            MoveTextEnd = 7,
            MovePageUp = 8,
            MovePageDown = 9,
            MoveGraphicalLineStart = 10,
            MoveGraphicalLineEnd = 11,
            MoveWordLeft = 12,
            MoveWordRight = 13,
            MoveParagraphForward = 14,
            MoveParagraphBackward = 15,
            MoveToStartOfNextWord = 16,
            MoveToEndOfPreviousWord = 17,
            SelectLeft = 18,
            SelectRight = 19,
            SelectUp = 20,
            SelectDown = 21,
            SelectTextStart = 22,
            SelectTextEnd = 23,
            SelectPageUp = 24,
            SelectPageDown = 25,
            ExpandSelectGraphicalLineStart = 26,
            ExpandSelectGraphicalLineEnd = 27,
            SelectGraphicalLineStart = 28,
            SelectGraphicalLineEnd = 29,
            SelectWordLeft = 30,
            SelectWordRight = 31,
            SelectToEndOfPreviousWord = 32,
            SelectToStartOfNextWord = 33,
            SelectParagraphBackward = 34,
            SelectParagraphForward = 35,
            Delete = 36,
            Backspace = 37,
            DeleteWordBack = 38,
            DeleteWordForward = 39,
            DeleteLineBack = 40,
            Cut = 41,
            Copy = 42,
            Paste = 43,
            SelectAll = 44,
            SelectNone = 45,
            ScrollStart = 46,
            ScrollEnd = 47,
            ScrollPageUp = 48,
            ScrollPageDown = 49,
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x2971ac4*/ uint ComputeStringHash(string s);
}
