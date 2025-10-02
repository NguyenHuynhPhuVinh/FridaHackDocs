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

        static /*0x1629730*/ nint Internal_Create(int displayIndex);
        static /*0x1629770*/ void Internal_Destroy(nint ptr);
        static /*0x162ae80*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x1629910*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x16297b0*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x16295b0*/ int GetDoubleClickTime();
        static /*0x162bb30*/ UnityEngine.Event get_current();
        static /*0x162c190*/ void set_current(UnityEngine.Event value);
        static /*0x1629990*/ UnityEngine.Event KeyboardEvent(string key);
        /*0x162b9a0*/ Event();
        /*0x162b9e0*/ Event(int displayIndex);
        /*0x162bf50*/ UnityEngine.EventType get_rawType();
        /*0x162be40*/ UnityEngine.Vector2 get_mousePosition();
        /*0x162c3e0*/ void set_mousePosition(UnityEngine.Vector2 value);
        /*0x162bbc0*/ UnityEngine.Vector2 get_delta();
        /*0x162c290*/ void set_delta(UnityEngine.Vector2 value);
        /*0x162bed0*/ UnityEngine.PointerType get_pointerType();
        /*0x162ba30*/ int get_button();
        /*0x162bdb0*/ UnityEngine.EventModifiers get_modifiers();
        /*0x162c350*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x162bf10*/ float get_pressure();
        /*0x162c070*/ float get_twist();
        /*0x162c020*/ UnityEngine.Vector2 get_tilt();
        /*0x162be90*/ UnityEngine.PenStatus get_penStatus();
        /*0x162bab0*/ int get_clickCount();
        /*0x162ba70*/ char get_character();
        /*0x162c0f0*/ void set_character(char value);
        /*0x162bd70*/ UnityEngine.KeyCode get_keyCode();
        /*0x162c310*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x162bc10*/ int get_displayIndex();
        /*0x162c2d0*/ void set_displayIndex(int value);
        /*0x162c0b0*/ UnityEngine.EventType get_type();
        /*0x162c420*/ void set_type(UnityEngine.EventType value);
        /*0x162baf0*/ string get_commandName();
        /*0x162c140*/ void set_commandName(string value);
        /*0x1629950*/ void Internal_Use();
        /*0x16291f0*/ void CopyFromPtr(nint ptr);
        /*0x1629510*/ void Finalize();
        /*0x1629240*/ void CopyFrom(UnityEngine.Event e);
        /*0x162bf90*/ bool get_shift();
        /*0x162bcc0*/ bool get_isKey();
        /*0x162bd10*/ bool get_isMouse();
        /*0x162bc50*/ bool get_isDirectManipulationDevice();
        /*0x16295e0*/ int GetHashCode();
        /*0x16292b0*/ bool Equals(object obj);
        /*0x162aec0*/ string ToString();
        /*0x162b7e0*/ void Use();
        /*0x162bdf0*/ void get_mousePosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x162c390*/ void set_mousePosition_Injected(ref UnityEngine.Vector2 value);
        /*0x162bb70*/ void get_delta_Injected(ref UnityEngine.Vector2 ret);
        /*0x162c240*/ void set_delta_Injected(ref UnityEngine.Vector2 value);
        /*0x162bfd0*/ void get_tilt_Injected(ref UnityEngine.Vector2 ret);
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

    struct EventInterests
    {
        /*0x10*/ bool <wantsMouseMove>k__BackingField;
        /*0x11*/ bool <wantsMouseEnterLeaveWindow>k__BackingField;
        /*0x12*/ bool <wantsLessLayoutEvents>k__BackingField;

        /*0xbad660*/ bool get_wantsMouseMove();
        /*0xd340f0*/ void set_wantsMouseMove(bool value);
        /*0xba9540*/ bool get_wantsMouseEnterLeaveWindow();
        /*0x1626d80*/ void set_wantsMouseEnterLeaveWindow(bool value);
        /*0xfa51c0*/ bool get_wantsLessLayoutEvents();
        /*0x16290d0*/ bool WantsEvent(UnityEngine.EventType type);
        /*0x16290f0*/ bool WantsLayoutPass(UnityEngine.EventType type);
    }

    class GUI
    {
        static /*0x0*/ int s_HotTextField;
        static /*0x4*/ int s_BoxHash;
        static /*0x8*/ int s_ButonHash;
        static /*0xc*/ int s_RepeatButtonHash;
        static /*0x10*/ int s_ToggleHash;
        static /*0x14*/ int s_ButtonGridHash;
        static /*0x18*/ int s_SliderHash;
        static /*0x1c*/ int s_BeginGroupHash;
        static /*0x20*/ int s_ScrollviewHash;
        static /*0x28*/ System.DateTime <nextScrollStepTime>k__BackingField;
        static /*0x30*/ UnityEngine.GUISkin s_Skin;
        static /*0x38*/ UnityEngine.Rect s_ToolTipRect;
        static /*0x48*/ UnityEngineInternal.GenericStack <scrollViewStates>k__BackingField;

        static /*0x163a7e0*/ GUI();
        static /*0x163ac10*/ UnityEngine.Color get_color();
        static /*0x163aff0*/ void set_color(UnityEngine.Color value);
        static /*0x163ab30*/ UnityEngine.Color get_backgroundColor();
        static /*0x163af00*/ void set_backgroundColor(UnityEngine.Color value);
        static /*0x163acc0*/ UnityEngine.Color get_contentColor();
        static /*0x163b0a0*/ void set_contentColor(UnityEngine.Color value);
        static /*0x163aba0*/ bool get_changed();
        static /*0x163af70*/ void set_changed(bool value);
        static /*0x163ad30*/ bool get_enabled();
        static /*0x163b110*/ void set_enabled(bool value);
        static /*0x163b1b0*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x163b210*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x163ae40*/ UnityEngine.GUISkin get_skin();
        static /*0x163a400*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x163ad60*/ UnityEngine.Matrix4x4 get_matrix();
        static /*0x163b150*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x163a620*/ void Label(UnityEngine.Rect position, string text);
        static /*0x163a740*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1639b20*/ void Box(UnityEngine.Rect position, string text);
        static /*0x1639830*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x163a010*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x163adf0*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x1639be0*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x163abd0*/ void get_color_Injected(ref UnityEngine.Color ret);
        static /*0x163afb0*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x163aaf0*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x163aec0*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        static /*0x163ac80*/ void get_contentColor_Injected(ref UnityEngine.Color ret);
        static /*0x163b060*/ void set_contentColor_Injected(ref UnityEngine.Color value);

        class WindowFunction : System.MulticastDelegate
        {
            /*0x721150*/ WindowFunction(object object, nint method);
            /*0x720980*/ void Invoke(int id);
        }
    }

    class GUIClip
    {
        static /*0x162ca40*/ UnityEngine.Rect get_visibleRect();
        static /*0x162c9c0*/ UnityEngine.Rect get_topmostRect();
        static /*0x162c690*/ void Internal_Pop();
        static /*0x162c630*/ int Internal_GetCount();
        static /*0x162c5f0*/ UnityEngine.Rect GetTopRect();
        static /*0x162c8e0*/ UnityEngine.Vector2 Unclip_Vector2(UnityEngine.Vector2 pos);
        static /*0x162c560*/ UnityEngine.Matrix4x4 GetMatrix();
        static /*0x162c850*/ void SetMatrix(UnityEngine.Matrix4x4 m);
        static /*0x162c720*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
        static /*0x162c7b0*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect);
        static /*0x162c660*/ void Internal_PopParentClip();
        static /*0x162c930*/ UnityEngine.Vector2 Unclip(UnityEngine.Vector2 pos);
        static /*0x162ca00*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x162c980*/ void get_topmostRect_Injected(ref UnityEngine.Rect ret);
        static /*0x162c5b0*/ void GetTopRect_Injected(ref UnityEngine.Rect ret);
        static /*0x162c890*/ void Unclip_Vector2_Injected(ref UnityEngine.Vector2 pos, ref UnityEngine.Vector2 ret);
        static /*0x162c520*/ void GetMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        static /*0x162c810*/ void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x162c6c0*/ void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect);

        struct ParentClipScope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x163b880*/ ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
            /*0x163b840*/ void Dispose();
        }
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
        /*0x28*/ System.Action OnTextChanged;

        static /*0x162cce0*/ GUIContent();
        static /*0x162cbf0*/ UnityEngine.GUIContent Temp(string t);
        static /*0x162ca80*/ void ClearStaticCache();
        /*0x162d0c0*/ GUIContent();
        /*0x162d130*/ GUIContent(string text);
        /*0x162cfd0*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x9e3110*/ string get_text();
        /*0x162d240*/ void set_text(string value);
        /*0x7963c0*/ void set_image(UnityEngine.Texture value);
        /*0x15fe5a0*/ string get_tooltip();
        /*0x7965a0*/ void set_tooltip(string value);
        /*0x162ccb0*/ string ToString();
    }

    enum ScaleMode
    {
        StretchToFill = 0,
        ScaleAndCrop = 1,
        ScaleToFit = 2,
    }

    enum FocusType
    {
        Native = 0,
        Keyboard = 1,
        Passive = 2,
    }

    class GUILayout
    {
        static /*0x16321d0*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x1632130*/ UnityEngine.GUILayoutOption Height(float height);
    }

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x12f3850*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

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

        static /*0x1631ff0*/ GUILayoutUtility();
        static /*0x1631030*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x16310f0*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x1630f30*/ UnityEngine.GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow);
        static /*0x1631da0*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x1631cc0*/ void RemoveSelectedIdList(int instanceID, bool isWindow);
        static /*0x1630c80*/ void Begin(int instanceID);
        static /*0x16306e0*/ void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache);
        static /*0x16308c0*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1631a00*/ void Layout();
        static /*0x1631510*/ void LayoutFromEditorWindow();
        static /*0x1631320*/ void LayoutFromContainer(float w, float h);
        static /*0x1631170*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x1631780*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x1630ff0*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x16310b0*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x163b4f0*/ LayoutCache(int instanceID);
            /*0xdcd9c0*/ void set_id(int value);
            /*0x163b290*/ void ResetCursor();
        }
    }

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        /*0x16328a0*/ GUISettings();
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

        static /*0x1633df0*/ void CleanupRoots();
        static /*0x1634450*/ UnityEngine.GUIStyle get_error();
        /*0x1634360*/ GUISkin();
        /*0x16328d0*/ void OnEnable();
        /*0x8b8f40*/ UnityEngine.Font get_font();
        /*0x1634830*/ void set_font(UnityEngine.Font value);
        /*0x15fe5a0*/ UnityEngine.GUIStyle get_box();
        /*0x16346b0*/ void set_box(UnityEngine.GUIStyle value);
        /*0x16345e0*/ UnityEngine.GUIStyle get_label();
        /*0x1634cf0*/ void set_label(UnityEngine.GUIStyle value);
        /*0x162e040*/ UnityEngine.GUIStyle get_textField();
        /*0x1634ef0*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x1634620*/ UnityEngine.GUIStyle get_textArea();
        /*0x1634e70*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x15f1340*/ UnityEngine.GUIStyle get_button();
        /*0x1634730*/ void set_button(UnityEngine.GUIStyle value);
        /*0x15fe590*/ UnityEngine.GUIStyle get_toggle();
        /*0x1634f70*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x16346a0*/ UnityEngine.GUIStyle get_window();
        /*0x1635370*/ void set_window(UnityEngine.GUIStyle value);
        /*0x16345d0*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x1634c70*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x16345c0*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x1634bf0*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x16345b0*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x1634b70*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x1634610*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x1634df0*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x1634690*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x16352f0*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x1634680*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x1635270*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x1634670*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x16351f0*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x16345a0*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x1634af0*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x1634590*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x1634a70*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x1634570*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x1634970*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x1634580*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x16349f0*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x1634660*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x1635170*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x1634640*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x1635070*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x1634650*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x16350f0*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x1634630*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x1634ff0*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x16345f0*/ UnityEngine.GUIStyle get_scrollView();
        /*0x1634d70*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x1634440*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x16347b0*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x1634600*/ UnityEngine.GUISettings get_settings();
        /*0x16328d0*/ void Apply();
        /*0x1632940*/ void BuildStyleCache();
        /*0x1633fc0*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x1633e70*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x1634290*/ void MakeCurrent();
        /*0x1633f00*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0xe25c50*/ SkinChangedDelegate(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x1635540*/ nint Init();
        static /*0x16354c0*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x1635570*/ GUIStyleState();
        /*0x15d40f0*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x16355b0*/ UnityEngine.Texture2D get_background();
        /*0x1635690*/ void set_background(UnityEngine.Texture2D value);
        /*0x1635640*/ UnityEngine.Color get_textColor();
        /*0x1635730*/ void set_textColor(UnityEngine.Color value);
        /*0x16353f0*/ void Cleanup();
        /*0x1635430*/ void Finalize();
        /*0x16355f0*/ void get_textColor_Injected(ref UnityEngine.Color ret);
        /*0x16356e0*/ void set_textColor_Injected(ref UnityEngine.Color value);
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

        static /*0x16361d0*/ GUIStyle();
        static /*0x1635d00*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x1635d40*/ void Internal_Destroy(nint self);
        static /*0x1636050*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x1635f80*/ bool IsTooltipActive(string tooltip);
        static /*0x1635fc0*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x1636840*/ UnityEngine.GUIStyle get_none();
        static /*0x1636000*/ void SetMouseTooltip_Injected(string tooltip, ref UnityEngine.Rect screenRect);
        /*0x1636210*/ GUIStyle();
        /*0x1636c90*/ string get_rawName();
        /*0x1637560*/ void set_rawName(string value);
        /*0x1636640*/ UnityEngine.Font get_font();
        /*0x1637120*/ void set_font(UnityEngine.Font value);
        /*0x16366f0*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x16371d0*/ void set_imagePosition(UnityEngine.ImagePosition value);
        /*0x1636300*/ UnityEngine.TextAnchor get_alignment();
        /*0x1636e30*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x1636d90*/ bool get_wordWrap();
        /*0x16376a0*/ void set_wordWrap(bool value);
        /*0x16363f0*/ UnityEngine.TextClipping get_clipping();
        /*0x1636ed0*/ void set_clipping(UnityEngine.TextClipping value);
        /*0x1636480*/ UnityEngine.Vector2 get_contentOffset();
        /*0x1636f60*/ void set_contentOffset(UnityEngine.Vector2 value);
        /*0x1636510*/ float get_fixedWidth();
        /*0x1636ff0*/ void set_fixedWidth(float value);
        /*0x16364d0*/ float get_fixedHeight();
        /*0x1636fa0*/ void set_fixedHeight(float value);
        /*0x1636d50*/ bool get_stretchWidth();
        /*0x1637650*/ void set_stretchWidth(bool value);
        /*0x1636d10*/ bool get_stretchHeight();
        /*0x1637600*/ void set_stretchHeight(bool value);
        /*0x16365c0*/ int get_fontSize();
        /*0x16370a0*/ void set_fontSize(int value);
        /*0x1636600*/ UnityEngine.FontStyle get_fontStyle();
        /*0x16370e0*/ void set_fontStyle(UnityEngine.FontStyle value);
        /*0x1636cd0*/ bool get_richText();
        /*0x16375b0*/ void set_richText(bool value);
        /*0x1635cc0*/ nint GetStyleStatePtr(int idx);
        /*0x16357d0*/ void AssignStyleState(int idx, nint srcStyleState);
        /*0x1635c80*/ nint GetRectOffsetPtr(int idx);
        /*0x1635780*/ void AssignRectOffset(int idx, nint srcRectOffset);
        /*0x1635ef0*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x1635df0*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x1635bb0*/ void Finalize();
        /*0x16367e0*/ string get_name();
        /*0x1637270*/ void set_name(string value);
        /*0x1636900*/ UnityEngine.GUIStyleState get_normal();
        /*0x16372c0*/ void set_normal(UnityEngine.GUIStyleState value);
        /*0x1636680*/ UnityEngine.GUIStyleState get_hover();
        /*0x1637170*/ void set_hover(UnityEngine.GUIStyleState value);
        /*0x1636290*/ UnityEngine.GUIStyleState get_active();
        /*0x1636dd0*/ void set_active(UnityEngine.GUIStyleState value);
        /*0x1636ac0*/ UnityEngine.GUIStyleState get_onNormal();
        /*0x1637440*/ void set_onNormal(UnityEngine.GUIStyleState value);
        /*0x1636a50*/ UnityEngine.GUIStyleState get_onHover();
        /*0x16373e0*/ void set_onHover(UnityEngine.GUIStyleState value);
        /*0x1636970*/ UnityEngine.GUIStyleState get_onActive();
        /*0x1637320*/ void set_onActive(UnityEngine.GUIStyleState value);
        /*0x1636550*/ UnityEngine.GUIStyleState get_focused();
        /*0x1637040*/ void set_focused(UnityEngine.GUIStyleState value);
        /*0x16369e0*/ UnityEngine.GUIStyleState get_onFocused();
        /*0x1637380*/ void set_onFocused(UnityEngine.GUIStyleState value);
        /*0x1636340*/ UnityEngine.RectOffset get_border();
        /*0x1636e70*/ void set_border(UnityEngine.RectOffset value);
        /*0x1636730*/ UnityEngine.RectOffset get_margin();
        /*0x1637210*/ void set_margin(UnityEngine.RectOffset value);
        /*0x1636be0*/ UnityEngine.RectOffset get_padding();
        /*0x1637500*/ void set_padding(UnityEngine.RectOffset value);
        /*0x1636b30*/ UnityEngine.RectOffset get_overflow();
        /*0x16374a0*/ void set_overflow(UnityEngine.RectOffset value);
        /*0x1635900*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x1635990*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x1635820*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x16360d0*/ string ToString();
        /*0x1636430*/ void get_contentOffset_Injected(ref UnityEngine.Vector2 ret);
        /*0x1636f10*/ void set_contentOffset_Injected(ref UnityEngine.Vector2 value);
        /*0x1635e60*/ void Internal_Draw_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x1635d80*/ void Internal_Draw2_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
    }

    enum ImagePosition
    {
        ImageLeft = 0,
        ImageAbove = 1,
        ImageOnly = 2,
        TextOnly = 3,
    }

    enum TextClipping
    {
        Overflow = 0,
        Clip = 1,
    }

    class GUITargetAttribute : System.Attribute
    {
        /*0x10*/ int displayMask;

        static /*0x16376f0*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
    }

    class GUIUtility
    {
        static /*0x0*/ int s_ControlCount;
        static /*0x4*/ int s_SkinMode;
        static /*0x8*/ int s_OriginalID;
        static /*0x10*/ System.Action takeCapture;
        static /*0x18*/ System.Action releaseCapture;
        static /*0x20*/ System.Func<int, nint, bool> processEvent;
        static /*0x28*/ System.Action cleanupRoots;
        static /*0x30*/ System.Func<System.Exception, bool> endContainerGUIFromException;
        static /*0x38*/ System.Action guiChanged;
        static /*0x40*/ System.Action<UnityEngine.EventType, UnityEngine.KeyCode> beforeEventProcessed;
        static /*0x48*/ UnityEngine.Event m_Event;
        static /*0x50*/ bool <guiIsExiting>k__BackingField;
        static /*0x58*/ System.Func<bool> s_HasCurrentWindowKeyFocusFunc;

        static /*0x1639350*/ GUIUtility();
        static /*0x1639530*/ float get_pixelsPerPoint();
        static /*0x1639440*/ int get_guiDepth();
        static /*0x1639590*/ bool get_textFieldInput();
        static /*0x1639560*/ string get_systemCopyBuffer();
        static /*0x16397f0*/ void set_systemCopyBuffer(string value);
        static /*0x1638a60*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x16385b0*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x1637a80*/ void BeginContainerFromOwner(UnityEngine.ScriptableObject owner);
        static /*0x1637ac0*/ void BeginContainer(UnityEngine.ObjectGUIState objectGUIState);
        static /*0x16389b0*/ void Internal_EndContainer();
        static /*0x1637d30*/ int CheckForTabEvent(UnityEngine.Event evt);
        static /*0x16391d0*/ void SetKeyboardControlToFirstControlId();
        static /*0x1639200*/ void SetKeyboardControlToLastControlId();
        static /*0x1638720*/ bool HasFocusableControls();
        static /*0x1638cf0*/ bool OwnsId(int id);
        static /*0x1637900*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels);
        static /*0x1639410*/ string get_compositionString();
        static /*0x1639740*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x1639600*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x1638b20*/ int Internal_GetHotControl();
        static /*0x1638b50*/ int Internal_GetKeyboardControl();
        static /*0x1638b80*/ void Internal_SetHotControl(int value);
        static /*0x1638bc0*/ void Internal_SetKeyboardControl(int value);
        static /*0x1638ae0*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x16389e0*/ void Internal_ExitGUI();
        static /*0x1638c80*/ void MarkGUIChanged();
        static /*0x16384a0*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x1639670*/ void set_guiIsExiting(bool value);
        static /*0x1639470*/ int get_hotControl();
        static /*0x16396d0*/ void set_hotControl(int value);
        static /*0x16392e0*/ void TakeCapture();
        static /*0x1638f20*/ void RemoveCapture();
        static /*0x16394d0*/ int get_keyboardControl();
        static /*0x1639780*/ void set_keyboardControl(int value);
        static /*0x1638750*/ bool HasKeyFocus(int controlID);
        static /*0x1638460*/ void ExitGUI();
        static /*0x1638680*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x1638d30*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x1637fb0*/ void EndContainer();
        static /*0x1637b00*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x1637e30*/ void DestroyGUI(int instanceID);
        static /*0x1638130*/ void EndGUI(int layoutType);
        static /*0x1638030*/ bool EndGUIFromException(System.Exception exception);
        static /*0x1637f10*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x1638f90*/ void ResetGlobalState();
        static /*0x1638c00*/ bool IsExitGUIException(System.Exception exception);
        static /*0x1639230*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x1637d70*/ void CheckOnGUI();
        static /*0x1639120*/ float RoundToPixelGrid(float v);
        static /*0x16379a0*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect);
        static /*0x1638870*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x16388f0*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x1638a10*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x1637890*/ void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels, ref UnityEngine.Rect ret);
        static /*0x16395c0*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class ExitGUIException : System.Exception
    {
        /*0x162c460*/ ExitGUIException();
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

        static /*0x162dd60*/ GUILayoutEntry();
        /*0x162ddc0*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x162e040*/ UnityEngine.GUIStyle get_style();
        /*0x162e050*/ void set_style(UnityEngine.GUIStyle value);
        /*0x162df60*/ int get_marginLeft();
        /*0x162df90*/ int get_marginRight();
        /*0x162dfc0*/ int get_marginTop();
        /*0x162dee0*/ int get_marginBottom();
        /*0x162df10*/ int get_marginHorizontal();
        /*0x162dff0*/ int get_marginVertical();
        /*0x32d010*/ void CalcWidth();
        /*0x32d010*/ void CalcHeight();
        /*0x162d780*/ void SetHorizontal(float x, float width);
        /*0x162d790*/ void SetVertical(float y, float height);
        /*0x162d670*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x162d2a0*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x162d7a0*/ string ToString();
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

        static /*0x16304d0*/ GUILayoutGroup();
        /*0x16305b0*/ GUILayoutGroup();
        /*0x12d9c50*/ int get_marginLeft();
        /*0x115f670*/ int get_marginRight();
        /*0x737a20*/ int get_marginTop();
        /*0x7378d0*/ int get_marginBottom();
        /*0x162e0a0*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x162e1e0*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x162f190*/ void ResetCursor();
        /*0x162ea40*/ void CalcWidth();
        /*0x162f1a0*/ void SetHorizontal(float x, float width);
        /*0x162e350*/ void CalcHeight();
        /*0x162f980*/ void SetVertical(float y, float height);
        /*0x1630160*/ string ToString();
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

        /*0x1632840*/ GUIScrollGroup();
        /*0x16323c0*/ void CalcWidth();
        /*0x1632460*/ void SetHorizontal(float x, float width);
        /*0x1632270*/ void CalcHeight();
        /*0x16325d0*/ void SetVertical(float y, float height);
    }

    class ObjectGUIState : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x163b790*/ nint Internal_Create();
        static /*0x163b7c0*/ void Internal_Destroy(nint ptr);
        /*0x163b800*/ ObjectGUIState();
        /*0x163b650*/ void Dispose();
        /*0x163b6f0*/ void Finalize();
        /*0x163b5f0*/ void Destroy();
    }

    class ScrollViewState
    {
        /*0x32f970*/ ScrollViewState();
    }

    class SliderState
    {
        /*0x32f970*/ SliderState();
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
        Delete = 18,
        Backspace = 19,
        DeleteWordBack = 20,
        DeleteWordForward = 21,
        DeleteLineBack = 22,
        Cut = 23,
        Paste = 24,
        ScrollStart = 25,
        ScrollEnd = 26,
        ScrollPageUp = 27,
        ScrollPageDown = 28,
    }

    enum TextSelectOp
    {
        SelectLeft = 0,
        SelectRight = 1,
        SelectUp = 2,
        SelectDown = 3,
        SelectTextStart = 4,
        SelectTextEnd = 5,
        SelectPageUp = 6,
        SelectPageDown = 7,
        ExpandSelectGraphicalLineStart = 8,
        ExpandSelectGraphicalLineEnd = 9,
        SelectGraphicalLineStart = 10,
        SelectGraphicalLineEnd = 11,
        SelectWordLeft = 12,
        SelectWordRight = 13,
        SelectToEndOfPreviousWord = 14,
        SelectToStartOfNextWord = 15,
        SelectParagraphBackward = 16,
        SelectParagraphForward = 17,
        Copy = 18,
        SelectAll = 19,
        SelectNone = 20,
    }

    class TextEditingUtilities
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextEditOp> s_KeyEditOps;
        /*0x10*/ UnityEngine.TextSelectingUtilities m_TextSelectingUtility;
        /*0x18*/ UnityEngine.TextCore.Text.TextHandle m_TextHandle;
        /*0x20*/ int m_CursorIndexSavedState;
        /*0x24*/ bool isCompositionActive;
        /*0x25*/ bool m_UpdateImeWindowPosition;
        /*0x26*/ bool multiline;
        /*0x28*/ string m_Text;

        static /*0x163cf80*/ void MapKey(string key, UnityEngine.TextEditOp action);
        static /*0x163dbd0*/ string ReplaceNewlinesWithSpaces(string value);
        /*0x163e060*/ TextEditingUtilities(UnityEngine.TextSelectingUtilities selectingUtilities, UnityEngine.TextCore.Text.TextHandle textHandle, string text);
        /*0x163e110*/ bool get_hasSelection();
        /*0x163e1d0*/ void set_revealCursor(bool value);
        /*0x163e0e0*/ int get_cursorIndex();
        /*0x163e190*/ void set_cursorIndex(int value);
        /*0x163e160*/ int get_selectIndex();
        /*0x163e210*/ void set_selectIndex(int value);
        /*0x15f1340*/ string get_text();
        /*0x163e250*/ void set_text(string value);
        /*0x163dfa0*/ bool UpdateImeState();
        /*0x163df20*/ bool ShouldUpdateImeWindowPosition();
        /*0x163de00*/ void SetImeWindowPosition(UnityEngine.Vector2 worldPosition);
        /*0x163c5d0*/ string GeneratePreviewString(bool richText);
        /*0x163c4e0*/ void EnableCursorPreviewState();
        /*0x163dd80*/ void RestoreCursorState();
        /*0x163c6f0*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x163d1d0*/ void PerformOperation(UnityEngine.TextEditOp operation);
        /*0x163c8b0*/ void InitKeyActions();
        /*0x163bb50*/ bool DeleteLineBack();
        /*0x163c020*/ bool DeleteWordBack();
        /*0x163c1e0*/ bool DeleteWordForward();
        /*0x163c360*/ bool Delete();
        /*0x163b910*/ bool Backspace();
        /*0x163bd20*/ bool DeleteSelection();
        /*0x163dc60*/ void ReplaceSelection(string replace);
        /*0x163cf20*/ void Insert(char c);
        /*0x163bab0*/ bool CanPaste();
        /*0x163bb20*/ bool Cut();
        /*0x163d090*/ bool Paste();
        /*0x163d010*/ void OnBlur();
        /*0x163df30*/ bool TouchScreenKeyboardShouldBeUsed();
    }

    class TextEditor
    {
        /*0x10*/ UnityEngine.TouchScreenKeyboard keyboardOnScreen;
        /*0x18*/ int controlID;
        /*0x20*/ UnityEngine.GUIStyle style;
        /*0x28*/ bool multiline;
        /*0x29*/ bool hasHorizontalCursorPos;
        /*0x2a*/ bool isPasswordField;
        /*0x2c*/ UnityEngine.Vector2 scrollOffset;
        /*0x38*/ UnityEngine.GUIContent m_Content;
        /*0x40*/ int m_CursorIndex;
        /*0x44*/ int m_SelectIndex;
        /*0x48*/ bool m_RevealCursor;
        /*0x49*/ bool m_MouseDragSelectsWholeWords;
        /*0x4c*/ int m_DblClickInitPos;
        /*0x50*/ UnityEngine.TextEditor.DblClickSnapping m_DblClickSnap;
        /*0x51*/ bool m_bJustSelected;
        /*0x54*/ int m_iAltCursorPos;

        /*0x163e2c0*/ TextEditor();

        enum DblClickSnapping
        {
            WORDS = 0,
            PARAGRAPHS = 1,
        }
    }

    class TextSelectingUtilities
    {
        static int kMoveDownHeight = 5;
        static char kNewLineChar = 10;
        static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Event, UnityEngine.TextSelectOp> s_KeySelectOps;
        /*0x10*/ UnityEngine.TextEditor.DblClickSnapping dblClickSnap;
        /*0x14*/ int iAltCursorPos;
        /*0x18*/ bool hasHorizontalCursorPos;
        /*0x19*/ bool m_bJustSelected;
        /*0x1a*/ bool m_MouseDragSelectsWholeWords;
        /*0x1c*/ int m_DblClickInitPosStart;
        /*0x20*/ int m_DblClickInitPosEnd;
        /*0x28*/ UnityEngine.TextCore.Text.TextHandle m_TextHandle;
        /*0x30*/ bool m_RevealCursor;
        /*0x34*/ int m_CursorIndex;
        /*0x38*/ int m_SelectIndex;
        /*0x40*/ System.Action OnCursorIndexChange;
        /*0x48*/ System.Action OnSelectIndexChange;
        /*0x50*/ System.Action OnRevealCursorChange;

        static /*0x163f840*/ void MapKey(string key, UnityEngine.TextSelectOp action);
        /*0x1642480*/ TextSelectingUtilities(UnityEngine.TextCore.Text.TextHandle textHandle);
        /*0x16425c0*/ bool get_hasSelection();
        /*0x995050*/ bool get_revealCursor();
        /*0x16427b0*/ void set_revealCursor(bool value);
        /*0x1642600*/ int get_m_CharacterCount();
        /*0x16424d0*/ int get_characterCount();
        /*0x1642630*/ UnityEngine.TextCore.Text.TextElementInfo[] get_m_TextElementInfos();
        /*0x16425b0*/ int get_cursorIndex();
        /*0x1642780*/ void set_cursorIndex(int value);
        /*0x9952f0*/ void SetCursorIndexWithoutNotify(int index);
        /*0x1642660*/ int get_selectIndex();
        /*0x16427e0*/ void set_selectIndex(int value);
        /*0x12d8f70*/ void SetSelectIndexWithoutNotify(int index);
        /*0x1642670*/ string get_selectedText();
        /*0x163f0e0*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x1640a00*/ bool PerformOperation(UnityEngine.TextSelectOp operation);
        /*0x163f2d0*/ void InitKeyActions();
        /*0x163e5b0*/ void ClearCursorPos();
        /*0x1640970*/ void OnFocus(bool selectAll);
        /*0x16410e0*/ void SelectAll();
        /*0x1641780*/ void SelectNone();
        /*0x16416a0*/ void SelectLeft();
        /*0x1641a50*/ void SelectRight();
        /*0x1642180*/ void SelectUp();
        /*0x1641580*/ void SelectDown();
        /*0x1641b30*/ void SelectTextEnd();
        /*0x1641b70*/ void SelectTextStart();
        /*0x1642120*/ void SelectToStartOfNextWord();
        /*0x1641ba0*/ void SelectToEndOfPreviousWord();
        /*0x1642330*/ void SelectWordRight();
        /*0x16421e0*/ void SelectWordLeft();
        /*0x1641640*/ void SelectGraphicalLineStart();
        /*0x16415e0*/ void SelectGraphicalLineEnd();
        /*0x1641920*/ void SelectParagraphForward();
        /*0x16417d0*/ void SelectParagraphBackward();
        /*0x1641250*/ void SelectCurrentWord();
        /*0x1641150*/ void SelectCurrentParagraph();
        /*0x16401f0*/ void MoveRight();
        /*0x163fc60*/ void MoveLeft();
        /*0x1640500*/ void MoveUp();
        /*0x163fa00*/ void MoveDown();
        /*0x163fea0*/ void MoveLineStart();
        /*0x163fd50*/ void MoveLineEnd();
        /*0x163fbc0*/ void MoveGraphicalLineStart();
        /*0x163fb20*/ void MoveGraphicalLineEnd();
        /*0x1640340*/ void MoveTextStart();
        /*0x16402e0*/ void MoveTextEnd();
        /*0x16400e0*/ void MoveParagraphForward();
        /*0x163ffe0*/ void MoveParagraphBackward();
        /*0x1640760*/ void MoveWordRight();
        /*0x1640450*/ void MoveToStartOfNextWord();
        /*0x16403a0*/ void MoveToEndOfPreviousWord();
        /*0x1640610*/ void MoveWordLeft();
        /*0x163f8d0*/ void MouseDragSelectsWholeWords(bool on);
        /*0x163e910*/ void ExpandSelectGraphicalLineStart();
        /*0x163e840*/ void ExpandSelectGraphicalLineEnd();
        /*0x793ec0*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x163f970*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x1641c00*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x163ebf0*/ int FindNextSeperator(int startPos);
        /*0x163ec70*/ int FindPrevSeperator(int startPos);
        /*0x163ed10*/ int FindStartOfNextWord(int p);
        /*0x163eb00*/ int FindEndOfPreviousWord(int p);
        /*0x163e9e0*/ int FindEndOfClassification(int p, UnityEngine.TextSelectingUtilities.Direction dir);
        /*0x163e430*/ int ClampTextIndex(int index);
        /*0x163e750*/ int EnsureValidCodePointIndex(int index);
        /*0x163f760*/ bool IsValidCodePointIndex(int index);
        /*0x163f290*/ int IndexOfEndOfLine(int startIndex);
        /*0x1641000*/ int PreviousCodePointIndex(int index);
        /*0x1640890*/ int NextCodePointIndex(int index);
        /*0x163f010*/ int GetGraphicalLineStart(int p);
        /*0x163ef30*/ int GetGraphicalLineEnd(int p);
        /*0x163e5c0*/ void Copy();
        /*0x163e460*/ UnityEngine.TextSelectingUtilities.CharacterType ClassifyChar(int index);

        enum CharacterType
        {
            LetterLike = 0,
            Symbol = 1,
            Symbol2 = 2,
            WhiteSpace = 3,
            NewLine = 4,
        }

        enum Direction
        {
            Forward = 0,
            Backward = 1,
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0xf36e20*/ uint ComputeStringHash(string s);
}
