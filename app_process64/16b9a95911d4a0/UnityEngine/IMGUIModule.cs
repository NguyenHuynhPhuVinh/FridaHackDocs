class <Module>
{
}

namespace UnityEngine
{
    class Event
    {
        static float scrollWheelDeltaPerTick = 3;
        static /*0x0*/ bool ignoreGuiDepth;
        static /*0x8*/ UnityEngine.Event s_Current;
        static /*0x10*/ UnityEngine.Event s_MasterEvent;
        /*0x10*/ nint m_Ptr;

        static /*0x3e396e0*/ nint Internal_Create(int displayIndex);
        static /*0x3e3971c*/ void Internal_Destroy(nint ptr);
        static /*0x3e39890*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x3e39968*/ void GetEventAtIndex(int index, UnityEngine.Event outEvent);
        static /*0x3e39a50*/ int GetEventCount();
        static /*0x3e39a78*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x3e39ab4*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x3e39be4*/ int GetDoubleClickTime();
        static /*0x3e39dc4*/ UnityEngine.Event get_current();
        static /*0x3e39e0c*/ void set_current(UnityEngine.Event value);
        static /*0x3e39ef4*/ UnityEngine.Event KeyboardEvent(string key);
        static /*0x3e385ec*/ UnityEngine.EventType get_rawType_Injected(nint _unity_self);
        static /*0x3e38688*/ void get_mousePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3e38728*/ void set_mousePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3e387cc*/ void get_delta_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3e3886c*/ void set_delta_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3e38900*/ UnityEngine.PointerType get_pointerType_Injected(nint _unity_self);
        static /*0x3e3898c*/ int get_button_Injected(nint _unity_self);
        static /*0x3e38a18*/ UnityEngine.EventModifiers get_modifiers_Injected(nint _unity_self);
        static /*0x3e38aac*/ void set_modifiers_Injected(nint _unity_self, UnityEngine.EventModifiers value);
        static /*0x3e38b40*/ float get_pressure_Injected(nint _unity_self);
        static /*0x3e38bcc*/ float get_twist_Injected(nint _unity_self);
        static /*0x3e38c68*/ void get_tilt_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3e38cfc*/ UnityEngine.PenStatus get_penStatus_Injected(nint _unity_self);
        static /*0x3e38d88*/ int get_clickCount_Injected(nint _unity_self);
        static /*0x3e38e14*/ char get_character_Injected(nint _unity_self);
        static /*0x3e38ea8*/ void set_character_Injected(nint _unity_self, char value);
        static /*0x3e38f3c*/ UnityEngine.KeyCode get_Internal_keyCode_Injected(nint _unity_self);
        static /*0x3e38fd0*/ void set_Internal_keyCode_Injected(nint _unity_self, UnityEngine.KeyCode value);
        static /*0x3e3913c*/ int get_displayIndex_Injected(nint _unity_self);
        static /*0x3e391d0*/ void set_displayIndex_Injected(nint _unity_self, int value);
        static /*0x3e39264*/ UnityEngine.EventType get_type_Injected(nint _unity_self);
        static /*0x3e392f8*/ void set_type_Injected(nint _unity_self, UnityEngine.EventType value);
        static /*0x3e3943c*/ void get_commandName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e39610*/ void set_commandName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3e396a4*/ void Internal_Use_Injected(nint _unity_self);
        static /*0x3e397b0*/ UnityEngine.EventType GetTypeForControl_Injected(nint _unity_self, int controlID);
        static /*0x3e3984c*/ void CopyFromPtr_Injected(nint _unity_self, nint ptr);
        static /*0x3e3992c*/ bool PopEvent_Injected(nint outEvent);
        static /*0x3e39a0c*/ void GetEventAtIndex_Injected(int index, nint outEvent);
        /*0x3e39c0c*/ Event();
        /*0x3e39b94*/ Event(int displayIndex);
        /*0x3e3859c*/ UnityEngine.EventType get_rawType();
        /*0x3e38628*/ UnityEngine.Vector2 get_mousePosition();
        /*0x3e386cc*/ void set_mousePosition(UnityEngine.Vector2 value);
        /*0x3e3876c*/ UnityEngine.Vector2 get_delta();
        /*0x3e38810*/ void set_delta(UnityEngine.Vector2 value);
        /*0x3e388b0*/ UnityEngine.PointerType get_pointerType();
        /*0x3e3893c*/ int get_button();
        /*0x3e389c8*/ UnityEngine.EventModifiers get_modifiers();
        /*0x3e38a54*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x3e38af0*/ float get_pressure();
        /*0x3e38b7c*/ float get_twist();
        /*0x3e38c08*/ UnityEngine.Vector2 get_tilt();
        /*0x3e38cac*/ UnityEngine.PenStatus get_penStatus();
        /*0x3e38d38*/ int get_clickCount();
        /*0x3e38dc4*/ char get_character();
        /*0x3e38e50*/ void set_character(char value);
        /*0x3e38eec*/ UnityEngine.KeyCode get_Internal_keyCode();
        /*0x3e38f78*/ void set_Internal_keyCode(UnityEngine.KeyCode value);
        /*0x3e39014*/ UnityEngine.KeyCode get_keyCode();
        /*0x3e390e8*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x3e390ec*/ int get_displayIndex();
        /*0x3e39178*/ void set_displayIndex(int value);
        /*0x3e39214*/ UnityEngine.EventType get_type();
        /*0x3e392a0*/ void set_type(UnityEngine.EventType value);
        /*0x3e3933c*/ string get_commandName();
        /*0x3e39480*/ void set_commandName(string value);
        /*0x3e39654*/ void Internal_Use();
        /*0x3e39758*/ UnityEngine.EventType GetTypeForControl(int controlID);
        /*0x3e397f4*/ void CopyFromPtr(nint ptr);
        /*0x3e39c58*/ void Finalize();
        /*0x3e39d14*/ void CopyFrom(UnityEngine.Event e);
        /*0x3e39d38*/ bool get_shift();
        /*0x3e39d4c*/ bool get_control();
        /*0x3e39d60*/ bool get_alt();
        /*0x3e39d74*/ bool get_command();
        /*0x3e39d88*/ bool get_capsLock();
        /*0x3e39d9c*/ bool get_numeric();
        /*0x3e39db0*/ bool get_functionKey();
        /*0x3e39ea4*/ bool get_isKey();
        /*0x3e39094*/ bool get_isMouse();
        /*0x3e390d0*/ bool get_isScrollWheel();
        /*0x3e39ec0*/ bool get_isDirectManipulationDevice();
        /*0x3e3b3e8*/ int GetHashCode();
        /*0x3e3b498*/ bool Equals(object obj);
        /*0x3e3b640*/ string ToString();
        /*0x3e3bcf8*/ void Use();

        class BindingsMarshaller
        {
            static /*0x3e3be58*/ nint ConvertToNative(UnityEngine.Event e);
        }
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

        /*0x3e3be6c*/ bool get_wantsMouseMove();
        /*0x3e3be74*/ void set_wantsMouseMove(bool value);
        /*0x3e3be7c*/ bool get_wantsMouseEnterLeaveWindow();
        /*0x3e3be84*/ void set_wantsMouseEnterLeaveWindow(bool value);
        /*0x3e3be8c*/ bool get_wantsLessLayoutEvents();
        /*0x3e3be94*/ bool WantsEvent(UnityEngine.EventType type);
        /*0x3e3bec4*/ bool WantsLayoutPass(UnityEngine.EventType type);
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

        static /*0x3e3c9f0*/ GUI();
        static /*0x3e3bfa0*/ UnityEngine.Color get_color();
        static /*0x3e3c064*/ void set_color(UnityEngine.Color value);
        static /*0x3e3c124*/ UnityEngine.Color get_backgroundColor();
        static /*0x3e3c1e8*/ void set_backgroundColor(UnityEngine.Color value);
        static /*0x3e3c2a8*/ UnityEngine.Color get_contentColor();
        static /*0x3e3c36c*/ void set_contentColor(UnityEngine.Color value);
        static /*0x3e3c42c*/ bool get_changed();
        static /*0x3e3c454*/ void set_changed(bool value);
        static /*0x3e3c490*/ bool get_enabled();
        static /*0x3e3c4b8*/ void set_enabled(bool value);
        static /*0x3e3c4f4*/ bool get_usePageScrollbars();
        static /*0x3e3c51c*/ void GrabMouseControl(int id);
        static /*0x3e3c558*/ bool HasMouseControl(int id);
        static /*0x3e3c594*/ void ReleaseMouseControl();
        static /*0x3e3c5bc*/ void SetNextControlName(string name);
        static /*0x3e3c784*/ void InternalRepaintEditorWindow();
        static /*0x3e3c7ac*/ UnityEngine.Rect Internal_DoWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout);
        static /*0x3e3c930*/ void DragWindow(UnityEngine.Rect position);
        static /*0x3e3cca8*/ int get_scrollTroughSide();
        static /*0x3e3cd00*/ void set_scrollTroughSide(int value);
        static /*0x3e3cd5c*/ System.DateTime get_nextScrollStepTime();
        static /*0x3e3cdb4*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x3e3ce10*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x3e3cf64*/ UnityEngine.GUISkin get_skin();
        static /*0x3e3ce90*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x3e3d0a0*/ UnityEngine.Matrix4x4 get_matrix();
        static /*0x3e3d178*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x3e3d200*/ void Label(UnityEngine.Rect position, string text);
        static /*0x3e3d398*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3d6e4*/ void Box(UnityEngine.Rect position, string text);
        static /*0x3e3d960*/ void Box(UnityEngine.Rect position, UnityEngine.Texture image);
        static /*0x3e3dad8*/ void Box(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style);
        static /*0x3e3dba0*/ void Box(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.GUIStyle style);
        static /*0x3e3d7bc*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3dd40*/ bool Button(UnityEngine.Rect position, string text);
        static /*0x3e3de18*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3df00*/ bool Button(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3e0d4*/ bool DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType);
        static /*0x3e3e47c*/ string PasswordFieldGetStrToShow(string password, char maskChar);
        static /*0x3e3e570*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style);
        static /*0x3e3e628*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText);
        static /*0x3e3e6f0*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar);
        static /*0x3e3ea48*/ void HandleTextFieldEventForTouchscreen(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar, UnityEngine.TextEditor editor);
        static /*0x3e3eecc*/ void HandleTextFieldEventForDesktop(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, UnityEngine.TextEditor editor);
        static /*0x3e3f6dc*/ bool Toggle(UnityEngine.Rect position, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3f8e4*/ int SelectionGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style);
        static /*0x3e40608*/ int CalcTotalHorizSpacing(int xCount, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle);
        static /*0x3e407d8*/ bool DoControl(UnityEngine.Rect position, int id, bool on, bool hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3d458*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3f7cc*/ bool DoToggle(UnityEngine.Rect position, int id, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3dfc8*/ bool DoButton(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e3f9dc*/ int DoButtonGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, string[] controlNames, int itemsPerRow, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle, UnityEngine.GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled);
        static /*0x3e4101c*/ UnityEngine.Rect[] CalcGridRects(UnityEngine.Rect position, UnityEngine.GUIContent[] contents, int xCount, float elemWidth, float elemHeight, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle, UnityEngine.GUI.ToolbarButtonSize buttonSize);
        static /*0x3e412c0*/ float HorizontalSlider(UnityEngine.Rect position, float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb);
        static /*0x3e4138c*/ float Slider(UnityEngine.Rect position, float value, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        static /*0x3e41534*/ float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style);
        static /*0x3e41ce4*/ bool ScrollerRepeatButton(int scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style);
        static /*0x3e41fa4*/ float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style);
        static /*0x3e4195c*/ float Scroller(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, bool horiz);
        static /*0x3e42140*/ void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e42218*/ void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.Vector2 scrollOffset);
        static /*0x3e4254c*/ void EndGroup();
        static /*0x3e425e4*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x3e4263c*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background);
        static /*0x3e43110*/ void EndScrollView(bool handleScrollWheel);
        static /*0x3e43c6c*/ UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style);
        static /*0x3e43d50*/ UnityEngine.Rect DoWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, bool forceRectOnLayout);
        static /*0x3e43e4c*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x3e3c028*/ void get_color_Injected(ref UnityEngine.Color ret);
        static /*0x3e3c0e8*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x3e3c1ac*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x3e3c26c*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        static /*0x3e3c330*/ void get_contentColor_Injected(ref UnityEngine.Color ret);
        static /*0x3e3c3f0*/ void set_contentColor_Injected(ref UnityEngine.Color value);
        static /*0x3e3c748*/ void SetNextControlName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3e3c894*/ void Internal_DoWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout, ref UnityEngine.Rect ret);
        static /*0x3e3c9b4*/ void DragWindow_Injected(ref UnityEngine.Rect position);

        enum ToolbarButtonSize
        {
            Fixed = 0,
            FitToContents = 1,
        }

        class WindowFunction : System.MulticastDelegate
        {
            /*0x3e44844*/ WindowFunction(object object, nint method);
            /*0x3e448e4*/ void Invoke(int id);
        }

        class Scope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x3e44bc4*/ Scope();
            /*0x3e448f8*/ void Dispose(bool disposing);
            /*0x3e449b0*/ void Finalize();
            /*0x3e44b58*/ void Dispose();
            /*0x1f309e4*/ void CloseScope();
        }
    }

    class GUIClip
    {
        static /*0x3e40b80*/ UnityEngine.Rect get_visibleRect();
        static /*0x3e44c08*/ void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x3e425bc*/ void Internal_Pop();
        static /*0x3e44cc8*/ int Internal_GetCount();
        static /*0x3e44cf0*/ UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos);
        static /*0x3e3d114*/ UnityEngine.Matrix4x4 GetMatrix();
        static /*0x3e3d1c4*/ void SetMatrix(UnityEngine.Matrix4x4 m);
        static /*0x3e44df8*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
        static /*0x3e44e30*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect);
        static /*0x3e44ee0*/ void Internal_PopParentClip();
        static /*0x3e42548*/ void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x3e43c44*/ void Pop();
        static /*0x3e44f08*/ UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos);
        static /*0x3e44bcc*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x3e44c6c*/ void Internal_Push_Injected(ref UnityEngine.Rect screenRect, ref UnityEngine.Vector2 scrollOffset, ref UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x3e44d3c*/ void UnclipToWindow_Vector2_Injected(ref UnityEngine.Vector2 pos, ref UnityEngine.Vector2 ret);
        static /*0x3e44d80*/ void GetMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        static /*0x3e44dbc*/ void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x3e44e8c*/ void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect);

        struct ParentClipScope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x3e44f0c*/ ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
            /*0x3e44f50*/ void Dispose();
        }
    }

    class GUIContent
    {
        static /*0x0*/ UnityEngine.GUIContent s_Text;
        static /*0x8*/ UnityEngine.GUIContent s_Image;
        static /*0x10*/ UnityEngine.GUIContent s_TextImage;
        static /*0x18*/ string k_ZeroWidthSpace;
        static /*0x20*/ UnityEngine.GUIContent none;
        /*0x10*/ string m_Text;
        /*0x18*/ UnityEngine.Texture m_Image;
        /*0x20*/ string m_Tooltip;
        /*0x28*/ string m_TextWithWhitespace;
        /*0x30*/ System.Action OnTextChanged;

        static /*0x3e456bc*/ GUIContent();
        static /*0x3e3d2d0*/ UnityEngine.GUIContent Temp(string t);
        static /*0x3e3da30*/ UnityEngine.GUIContent Temp(UnityEngine.Texture i);
        static /*0x3e45408*/ void ClearStaticCache();
        static /*0x3e45568*/ UnityEngine.GUIContent[] Temp(string[] texts);
        /*0x3e451f4*/ GUIContent();
        /*0x3e45260*/ GUIContent(string text);
        /*0x3e45334*/ GUIContent(string text, UnityEngine.Texture image);
        /*0x3e4534c*/ GUIContent(string text, string tooltip);
        /*0x3e4527c*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x3e45358*/ GUIContent(UnityEngine.GUIContent src);
        /*0x3e44f90*/ void add_OnTextChanged(System.Action value);
        /*0x3e4502c*/ void remove_OnTextChanged(System.Action value);
        /*0x3e3e9d4*/ string get_text();
        /*0x3e3e9dc*/ void set_text(string value);
        /*0x3e45148*/ string get_textWithWhitespace();
        /*0x3e450c8*/ void set_textWithWhitespace(string value);
        /*0x3e451b8*/ void SetTextWithoutNotify(string value);
        /*0x3e451e4*/ void set_image(UnityEngine.Texture value);
        /*0x3e40b78*/ string get_tooltip();
        /*0x3e451ec*/ void set_tooltip(string value);
        /*0x3e4569c*/ string ToString();
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
        static /*0x3e457ec*/ void Label(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45960*/ void Label(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45894*/ void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45a3c*/ void Box(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45aac*/ void DoBox(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45b78*/ bool Button(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45cec*/ bool Button(UnityEngine.Texture image, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45d5c*/ bool Button(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45dcc*/ bool Button(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45c20*/ bool DoButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45dd0*/ string TextField(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46074*/ string TextField(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e45e54*/ string DoTextField(string text, int maxLength, bool multiline, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46088*/ bool Toggle(bool value, string text, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46140*/ bool DoToggle(bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e4621c*/ int SelectionGrid(int selected, string[] texts, int xCount, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e462a8*/ int SelectionGrid(int selected, UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46370*/ float HorizontalSlider(float value, float leftValue, float rightValue, UnityEngine.GUILayoutOption[] options);
        static /*0x3e4641c*/ float DoHorizontalSlider(float value, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46560*/ void Space(float pixels);
        static /*0x3e468e8*/ void BeginHorizontal(UnityEngine.GUILayoutOption[] options);
        static /*0x3e4697c*/ void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46e3c*/ void EndHorizontal();
        static /*0x3e47124*/ void BeginVertical(UnityEngine.GUILayoutOption[] options);
        static /*0x3e471b8*/ void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e47354*/ void EndVertical();
        static /*0x3e473a0*/ void BeginArea(UnityEngine.Rect screenRect);
        static /*0x3e4745c*/ void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x3e47924*/ void EndArea();
        static /*0x3e47bac*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, UnityEngine.GUILayoutOption[] options);
        static /*0x3e47c68*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options);
        static /*0x3e47edc*/ void EndScrollView();
        static /*0x3e47ee4*/ void EndScrollView(bool handleScrollWheel);
        static /*0x3e47f60*/ UnityEngine.Rect Window(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e4801c*/ UnityEngine.Rect DoWindow(int id, UnityEngine.Rect screenRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e44250*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x3e48248*/ UnityEngine.GUILayoutOption MinWidth(float minWidth);
        static /*0x3e482e8*/ UnityEngine.GUILayoutOption MaxWidth(float maxWidth);
        static /*0x3e442ec*/ UnityEngine.GUILayoutOption Height(float height);
        static /*0x3e48388*/ UnityEngine.GUILayoutOption MinHeight(float minHeight);
        static /*0x3e48428*/ UnityEngine.GUILayoutOption MaxHeight(float maxHeight);
        static /*0x3e484c8*/ UnityEngine.GUILayoutOption ExpandWidth(bool expand);
        static /*0x3e48564*/ UnityEngine.GUILayoutOption ExpandHeight(bool expand);

        class LayoutedWindow
        {
            /*0x10*/ UnityEngine.GUI.WindowFunction m_Func;
            /*0x18*/ UnityEngine.Rect m_ScreenRect;
            /*0x28*/ UnityEngine.GUILayoutOption[] m_Options;
            /*0x30*/ UnityEngine.GUIStyle m_Style;

            /*0x3e48188*/ LayoutedWindow(UnityEngine.GUI.WindowFunction f, UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options, UnityEngine.GUIStyle style);
            /*0x3e48600*/ void DoWindow(int windowID);
        }

        class HorizontalScope : UnityEngine.GUI.Scope
        {
            /*0x3e4872c*/ HorizontalScope(UnityEngine.GUILayoutOption[] options);
            /*0x3e48748*/ void CloseScope();
        }

        class VerticalScope : UnityEngine.GUI.Scope
        {
            /*0x3e4874c*/ VerticalScope(UnityEngine.GUILayoutOption[] options);
            /*0x3e48768*/ void CloseScope();
        }

        class ScrollViewScope : UnityEngine.GUI.Scope
        {
            /*0x14*/ UnityEngine.Vector2 <scrollPosition>k__BackingField;
            /*0x1c*/ bool <handleScrollWheel>k__BackingField;

            /*0x3e4878c*/ ScrollViewScope(UnityEngine.Vector2 scrollPosition, UnityEngine.GUILayoutOption[] options);
            /*0x3e4876c*/ UnityEngine.Vector2 get_scrollPosition();
            /*0x3e48774*/ void set_scrollPosition(UnityEngine.Vector2 value);
            /*0x3e4877c*/ bool get_handleScrollWheel();
            /*0x3e48784*/ void set_handleScrollWheel(bool value);
            /*0x3e487dc*/ void CloseScope();
        }
    }

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x3e48210*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

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
        static /*0x28*/ int <unbalancedgroupscount>k__BackingField;
        static /*0x30*/ UnityEngine.GUIStyle s_SpaceStyle;

        static /*0x3e4a040*/ GUILayoutUtility();
        static /*0x3e487e4*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x3e488b8*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x3e48988*/ int get_unbalancedgroupscount();
        static /*0x3e489e0*/ void set_unbalancedgroupscount(int value);
        static /*0x3e48a3c*/ UnityEngine.GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow);
        static /*0x3e440e4*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x3e48c04*/ void RemoveSelectedIdList(int instanceID, bool isWindow);
        static /*0x3e48ce4*/ void Begin(int instanceID);
        static /*0x3e48ef8*/ void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache);
        static /*0x3e4438c*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e44644*/ void Layout();
        static /*0x3e49424*/ void LayoutFromEditorWindow();
        static /*0x3e495f8*/ void LayoutFromContainer(float w, float h);
        static /*0x3e49084*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x3e492ac*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x3e49780*/ UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType);
        static /*0x3e46b14*/ UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType);
        static /*0x3e46e88*/ void EndLayoutGroup();
        static /*0x3e4762c*/ UnityEngine.GUILayoutGroup BeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType);
        static /*0x3e47a18*/ void EndLayoutArea();
        static /*0x3e459d0*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e498b8*/ UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e46864*/ UnityEngine.Rect GetRect(float width, float height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e49ca0*/ UnityEngine.Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x3e49e3c*/ UnityEngine.Rect GetLastRect();
        static /*0x3e46788*/ UnityEngine.GUIStyle get_spaceStyle();
        static /*0x3e48874*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x3e48944*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x3e48afc*/ LayoutCache(int instanceID);
            /*0x3e4a154*/ void set_id(int value);
            /*0x3e4a15c*/ void ResetCursor();
        }
    }

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        static /*0x3e4a41c*/ float Internal_GetCursorFlashSpeed();
        /*0x3e4a494*/ GUISettings();
        /*0x3e3f618*/ bool get_doubleClickSelectsWord();
        /*0x3e3f620*/ bool get_tripleClickSelectsLine();
        /*0x3e4a444*/ UnityEngine.Color get_cursorColor();
        /*0x3e4a450*/ float get_cursorFlashSpeed();
        /*0x3e4a488*/ UnityEngine.Color get_selectionColor();
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

        static /*0x3e4a618*/ void CleanupRoots();
        static /*0x3e4ab08*/ UnityEngine.GUIStyle get_error();
        /*0x3e4a4c0*/ GUISkin();
        /*0x3e4a598*/ void OnEnable();
        /*0x3e3f6d4*/ UnityEngine.Font get_font();
        /*0x3e4a680*/ void set_font(UnityEngine.Font value);
        /*0x3e3d7b4*/ UnityEngine.GUIStyle get_box();
        /*0x3e4a7f8*/ void set_box(UnityEngine.GUIStyle value);
        /*0x3e3d390*/ UnityEngine.GUIStyle get_label();
        /*0x3e4a814*/ void set_label(UnityEngine.GUIStyle value);
        /*0x3e45e4c*/ UnityEngine.GUIStyle get_textField();
        /*0x3e4a830*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x3e4a84c*/ UnityEngine.GUIStyle get_textArea();
        /*0x3e4a854*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x3e3de10*/ UnityEngine.GUIStyle get_button();
        /*0x3e4a870*/ void set_button(UnityEngine.GUIStyle value);
        /*0x3e46138*/ UnityEngine.GUIStyle get_toggle();
        /*0x3e4a88c*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x3e4a8a8*/ UnityEngine.GUIStyle get_window();
        /*0x3e4a8b0*/ void set_window(UnityEngine.GUIStyle value);
        /*0x3e4640c*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x3e4a8cc*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x3e46414*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x3e4a8e8*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x3e4a904*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x3e4a90c*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x3e4a928*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x3e4a930*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x3e4a94c*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x3e4a954*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x3e4a970*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x3e4a978*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x3e4a994*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x3e4a99c*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x3e47c50*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x3e4a9b8*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x3e4a9d4*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x3e4a9dc*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x3e4a9f8*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x3e4aa00*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x3e4aa1c*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x3e4aa24*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x3e47c58*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x3e4aa40*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x3e4aa5c*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x3e4aa64*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x3e4aa80*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x3e4aa88*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x3e4aaa4*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x3e4aaac*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x3e47c60*/ UnityEngine.GUIStyle get_scrollView();
        /*0x3e4aac8*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x3e4aae4*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x3e4aaec*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x3e3f610*/ UnityEngine.GUISettings get_settings();
        /*0x3e4a59c*/ void Apply();
        /*0x3e4ac14*/ void BuildStyleCache();
        /*0x3e41710*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x3e4bc3c*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x3e3cfe8*/ void MakeCurrent();
        /*0x3e4bcc4*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0x3e4bd84*/ SkinChangedDelegate(object object, nint method);
            /*0x3e4be20*/ void Invoke();
        }
    }

    class GUIStateObjects
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, object> s_StateCache;

        static /*0x3e4bf7c*/ GUIStateObjects();
        static /*0x3e4be34*/ object GetStateObject(System.Type t, int controlID);
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x3e4c058*/ nint Init();
        static /*0x3e4c18c*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        static /*0x3e4c014*/ void set_textColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3e4c0d0*/ void Cleanup_Injected(nint _unity_self);
        /*0x3e4c10c*/ GUIStyleState();
        /*0x3e4c150*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x3e4bbd4*/ void set_textColor(UnityEngine.Color value);
        /*0x3e4c080*/ void Cleanup();
        /*0x3e4c204*/ void Finalize();

        class BindingsMarshaller
        {
            static /*0x3e4c294*/ nint ConvertToNative(UnityEngine.GUIStyleState guiStyleState);
        }
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

        static /*0x3e4f7c4*/ GUIStyle();
        static /*0x3e4d5d8*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x3e4d614*/ nint Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other);
        static /*0x3e4d6dc*/ void Internal_Destroy(nint self);
        static /*0x3e40d64*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x3e40bc8*/ bool IsTooltipActive(string tooltip);
        static /*0x3e4e56c*/ float Internal_GetCursorFlashOffset();
        static /*0x3e4a758*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x3e4e5d0*/ UnityEngine.Font GetDefaultFont();
        static /*0x3e4e67c*/ void Internal_DestroyTextGenerator(int meshInfoId);
        static /*0x3e424a4*/ UnityEngine.GUIStyle get_none();
        static /*0x3e4f45c*/ void GetMeshInfo(UnityEngine.GUIStyle style, UnityEngine.Color color, string content, UnityEngine.Rect rect, ref UnityEngine.TextCore.Text.MeshInfoBindings[] meshInfos, ref UnityEngine.Vector2 dimensions, ref int generationId);
        static /*0x3e4f724*/ void GetDimensions(UnityEngine.GUIStyle style, UnityEngine.Color color, string content, UnityEngine.Rect rect, ref UnityEngine.Vector2 dimensions);
        static /*0x3e4f754*/ void GetLineHeight(UnityEngine.GUIStyle style, ref float lineHeight);
        static /*0x3e4f774*/ void EmptyManagedCache();
        static /*0x3e4c3ec*/ void get_rawName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e4c5e4*/ void set_rawName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3e4c628*/ nint get_font_Injected(nint _unity_self);
        static /*0x3e4c6f4*/ UnityEngine.ImagePosition get_imagePosition_Injected(nint _unity_self);
        static /*0x3e4c7c0*/ UnityEngine.TextAnchor get_alignment_Injected(nint _unity_self);
        static /*0x3e4c89c*/ void set_alignment_Injected(nint _unity_self, UnityEngine.TextAnchor value);
        static /*0x3e4c970*/ bool get_wordWrap_Injected(nint _unity_self);
        static /*0x3e4ca3c*/ UnityEngine.TextClipping get_clipping_Injected(nint _unity_self);
        static /*0x3e4cb20*/ void get_contentOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3e4cc08*/ void set_contentOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3e4cc4c*/ float get_fixedWidth_Injected(nint _unity_self);
        static /*0x3e4cd28*/ void set_fixedWidth_Injected(nint _unity_self, float value);
        static /*0x3e4cd74*/ float get_fixedHeight_Injected(nint _unity_self);
        static /*0x3e4ce50*/ void set_fixedHeight_Injected(nint _unity_self, float value);
        static /*0x3e4cf2c*/ bool get_stretchWidth_Injected(nint _unity_self);
        static /*0x3e4cf68*/ void set_stretchWidth_Injected(nint _unity_self, bool value);
        static /*0x3e4d03c*/ bool get_stretchHeight_Injected(nint _unity_self);
        static /*0x3e4d078*/ void set_stretchHeight_Injected(nint _unity_self, bool value);
        static /*0x3e4d14c*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x3e4d228*/ void set_fontSize_Injected(nint _unity_self, int value);
        static /*0x3e4d2fc*/ UnityEngine.FontStyle get_fontStyle_Injected(nint _unity_self);
        static /*0x3e4d3c8*/ bool get_richText_Injected(nint _unity_self);
        static /*0x3e4d4ac*/ void get_Internal_clipOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3e4d594*/ void set_Internal_clipOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3e4d698*/ nint Internal_Copy_Injected(UnityEngine.GUIStyle self, nint other);
        static /*0x3e4d7b8*/ nint GetStyleStatePtr_Injected(nint _unity_self, int idx);
        static /*0x3e4d89c*/ nint GetRectOffsetPtr_Injected(nint _unity_self, int idx);
        static /*0x3e4d988*/ void AssignRectOffset_Injected(nint _unity_self, int idx, nint srcRectOffset);
        static /*0x3e4dac4*/ void Internal_Draw_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        static /*0x3e4dc18*/ void Internal_Draw2_Injected(nint _unity_self, ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        static /*0x3e4dd50*/ void Internal_DrawCursor_Injected(nint _unity_self, ref UnityEngine.Rect position, UnityEngine.GUIContent content, ref UnityEngine.Vector2 pos, ref UnityEngine.Color cursorColor);
        static /*0x3e4ded4*/ void Internal_DrawWithTextSelection_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, ref UnityEngine.Vector2 cursorFirstPosition, ref UnityEngine.Vector2 cursorLastPosition, ref UnityEngine.Color cursorColor, ref UnityEngine.Color selectionColor);
        static /*0x3e4e03c*/ void Internal_CalcSize_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        static /*0x3e4e150*/ void Internal_CalcSizeWithConstraints_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, ref UnityEngine.Vector2 ret);
        static /*0x3e4e25c*/ float Internal_CalcHeight_Injected(nint _unity_self, UnityEngine.GUIContent content, float width);
        static /*0x3e4e360*/ void Internal_CalcMinMaxWidth_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        static /*0x3e4e480*/ void Internal_GetTextRectOffset_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, ref UnityEngine.Vector2 textSize, ref UnityEngine.Vector2 ret);
        static /*0x3e4e4ec*/ void SetMouseTooltip_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tooltip, ref UnityEngine.Rect screenRect);
        static /*0x3e4e530*/ bool IsTooltipActive_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tooltip);
        static /*0x3e4e594*/ void SetDefaultFont_Injected(nint font);
        static /*0x3e4e654*/ nint GetDefaultFont_Injected();
        /*0x3e49f18*/ GUIStyle();
        /*0x3e4e6b8*/ GUIStyle(UnityEngine.GUIStyle other);
        /*0x3e4c2a8*/ string get_rawName();
        /*0x3e4c430*/ void set_rawName(string value);
        /*0x3e3f628*/ UnityEngine.Font get_font();
        /*0x3e4c664*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x3e4c730*/ UnityEngine.TextAnchor get_alignment();
        /*0x3e4c7fc*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x3e4c8e0*/ bool get_wordWrap();
        /*0x3e4c9ac*/ UnityEngine.TextClipping get_clipping();
        /*0x3e4ca78*/ UnityEngine.Vector2 get_contentOffset();
        /*0x3e4cb64*/ void set_contentOffset(UnityEngine.Vector2 value);
        /*0x3e40efc*/ float get_fixedWidth();
        /*0x3e4cc88*/ void set_fixedWidth(float value);
        /*0x3e40f8c*/ float get_fixedHeight();
        /*0x3e4cdb0*/ void set_fixedHeight(float value);
        /*0x3e4ce9c*/ bool get_stretchWidth();
        /*0x3e49fa0*/ void set_stretchWidth(bool value);
        /*0x3e4cfac*/ bool get_stretchHeight();
        /*0x3e4bae4*/ void set_stretchHeight(bool value);
        /*0x3e4d0bc*/ int get_fontSize();
        /*0x3e4d188*/ void set_fontSize(int value);
        /*0x3e4d26c*/ UnityEngine.FontStyle get_fontStyle();
        /*0x3e4d338*/ bool get_richText();
        /*0x3e4d404*/ UnityEngine.Vector2 get_Internal_clipOffset();
        /*0x3e4d4f0*/ void set_Internal_clipOffset(UnityEngine.Vector2 value);
        /*0x3e4d718*/ nint GetStyleStatePtr(int idx);
        /*0x3e4d7fc*/ nint GetRectOffsetPtr(int idx);
        /*0x3e4d8e0*/ void AssignRectOffset(int idx, nint srcRectOffset);
        /*0x3e4d9dc*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x3e4db48*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x3e4dc84*/ void Internal_DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 pos, UnityEngine.Color cursorColor);
        /*0x3e4ddbc*/ void Internal_DrawWithTextSelection(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, UnityEngine.Vector2 cursorFirstPosition, UnityEngine.Vector2 cursorLastPosition, UnityEngine.Color cursorColor, UnityEngine.Color selectionColor);
        /*0x3e4df8c*/ UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content);
        /*0x3e4e090*/ UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize);
        /*0x3e4e1ac*/ float Internal_CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x3e4e2b0*/ UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content);
        /*0x3e4e3b4*/ UnityEngine.Vector2 Internal_GetTextRectOffset(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.Vector2 textSize);
        /*0x3e4e778*/ void Finalize();
        /*0x3e416d0*/ string get_name();
        /*0x3e4abe8*/ void set_name(string value);
        /*0x3e4bb84*/ UnityEngine.GUIStyleState get_normal();
        /*0x3e40740*/ UnityEngine.RectOffset get_margin();
        /*0x3e4e870*/ UnityEngine.RectOffset get_padding();
        /*0x3e4e908*/ void set_padding(UnityEngine.RectOffset value);
        /*0x3e4e920*/ float get_lineHeight();
        /*0x3e43050*/ void Draw(UnityEngine.Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x3e40b74*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x3e42534*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID);
        /*0x3e3f5fc*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x3e3dc68*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x3e4e9fc*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x3e4ea20*/ void DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int character);
        /*0x3e4edec*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, UnityEngine.Color selectionColor);
        /*0x3e4f100*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition);
        /*0x3e4f26c*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter);
        /*0x3e4ec38*/ UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x3e412bc*/ UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content);
        /*0x3e49c60*/ UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints);
        /*0x3e4f274*/ float CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x3e4f278*/ UnityEngine.Vector2 GetPreferredSize(string content, UnityEngine.Rect rect);
        /*0x3e49c20*/ bool get_isHeightDependantOnWidth();
        /*0x3e4f370*/ void CalcMinMaxWidth(UnityEngine.GUIContent content, ref float minWidth, ref float maxWidth);
        /*0x3e4f398*/ string ToString();

        class BindingsMarshaller
        {
            static /*0x3e4f810*/ nint ConvertToNative(UnityEngine.GUIStyle guiStyle);
        }
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
        Ellipsis = 2,
    }

    class GUITargetAttribute : System.Attribute
    {
        /*0x10*/ int displayMask;

        static /*0x3e4f824*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
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
        static /*0x40*/ System.Action<UnityEngine.EventType, UnityEngine.KeyCode, UnityEngine.EventModifiers> beforeEventProcessed;
        static /*0x48*/ UnityEngine.Event m_Event;
        static /*0x50*/ bool <guiIsExiting>k__BackingField;
        static /*0x58*/ System.Func<bool> s_HasCurrentWindowKeyFocusFunc;

        static /*0x3e51ac4*/ GUIUtility();
        static /*0x3e4f9b4*/ float get_pixelsPerPoint();
        static /*0x3e4f9dc*/ void set_pixelsPerPoint(float value);
        static /*0x3e4fa14*/ int get_guiDepth();
        static /*0x3e4fa3c*/ void set_mouseUsed(bool value);
        static /*0x3e4fa78*/ bool get_textFieldInput();
        static /*0x3e4faa0*/ void set_textFieldInput(bool value);
        static /*0x3e4fadc*/ string get_systemCopyBuffer();
        static /*0x3e4fc14*/ void set_systemCopyBuffer(string value);
        static /*0x3e4fddc*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x3e4fecc*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x3e4ff74*/ void BeginContainerFromOwner(UnityEngine.ScriptableObject owner);
        static /*0x3e50050*/ void BeginContainer(UnityEngine.ObjectGUIState objectGUIState);
        static /*0x3e50108*/ void Internal_EndContainer();
        static /*0x3e50130*/ int CheckForTabEvent(UnityEngine.Event evt);
        static /*0x3e501e8*/ void SetKeyboardControlToFirstControlId();
        static /*0x3e50210*/ void SetKeyboardControlToLastControlId();
        static /*0x3e50238*/ bool HasFocusableControls();
        static /*0x3e50260*/ bool OwnsId(int id);
        static /*0x3e5029c*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels);
        static /*0x3e503a4*/ string get_compositionString();
        static /*0x3e504dc*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x3e50518*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x3e505cc*/ int Internal_GetHotControl();
        static /*0x3e505f4*/ int Internal_GetKeyboardControl();
        static /*0x3e5061c*/ void Internal_SetHotControl(int value);
        static /*0x3e50658*/ void Internal_SetKeyboardControl(int value);
        static /*0x3e50694*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x3e506d0*/ void Internal_ExitGUI();
        static /*0x3e506f8*/ void MarkGUIChanged();
        static /*0x3e5076c*/ int GetControlID(UnityEngine.FocusType focus);
        static /*0x3e507c4*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x3e50860*/ object GetStateObject(System.Type t, int controlID);
        static /*0x3e508c8*/ bool get_guiIsExiting();
        static /*0x3e50920*/ void set_guiIsExiting(bool value);
        static /*0x3e50980*/ int get_hotControl();
        static /*0x3e509e8*/ void set_hotControl(int value);
        static /*0x3e50a5c*/ void TakeCapture();
        static /*0x3e50ad0*/ void RemoveCapture();
        static /*0x3e50b44*/ int get_keyboardControl();
        static /*0x3e50bac*/ void set_keyboardControl(int value);
        static /*0x3e50c20*/ bool HasKeyFocus(int controlID);
        static /*0x3e50cf4*/ void ExitGUI();
        static /*0x3e50de8*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x3e50e90*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x3e510b4*/ void EndContainer();
        static /*0x3e5113c*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x3e51300*/ void DestroyGUI(int instanceID);
        static /*0x3e5135c*/ void EndGUI(int layoutType);
        static /*0x3e51518*/ bool EndGUIFromException(System.Exception exception);
        static /*0x3e515e0*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x3e511ec*/ void ResetGlobalState();
        static /*0x3e51694*/ bool IsExitGUIException(System.Exception exception);
        static /*0x3e5158c*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x3e51718*/ void CheckOnGUI();
        static /*0x3e517d4*/ float RoundToPixelGrid(float v);
        static /*0x3e51884*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect);
        static /*0x3e51910*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x3e51954*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x3e51a08*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt);
        static /*0x3e4fbd8*/ void get_systemCopyBuffer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e4fda0*/ void set_systemCopyBuffer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3e4fe78*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x3e50014*/ void BeginContainerFromOwner_Injected(nint owner);
        static /*0x3e500cc*/ void BeginContainer_Injected(nint objectGUIState);
        static /*0x3e501ac*/ int CheckForTabEvent_Injected(nint evt);
        static /*0x3e50348*/ void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels, ref UnityEngine.Rect ret);
        static /*0x3e504a0*/ void get_compositionString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e50590*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class ExitGUIException : System.Exception
    {
        /*0x3e50d28*/ ExitGUIException();
        /*0x3e51b44*/ ExitGUIException(string message);
    }

    class IMGUITextHandle : UnityEngine.TextCore.Text.TextHandle
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.IMGUITextHandle> textHandles;
        static /*0x8*/ System.Collections.Generic.LinkedList<UnityEngine.IMGUITextHandle.TextHandleTuple> textHandlesTuple;
        static /*0x10*/ float lastCleanupTime;
        static /*0x14*/ int newHandlesSinceCleanup;
        /*0xb0*/ System.Collections.Generic.LinkedListNode<UnityEngine.IMGUITextHandle.TextHandleTuple> tuple;
        /*0xb8*/ bool isCachedOnNative;

        static /*0x3e52ad4*/ IMGUITextHandle();
        static /*0x3e51c14*/ void EmptyManagedCache();
        static /*0x3e51cb8*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.GUIStyle style, UnityEngine.Rect position, string content, UnityEngine.Color32 textColor);
        static /*0x3e52500*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.GUIStyle style, UnityEngine.Rect position, string content, UnityEngine.Color32 textColor, ref bool isCached);
        static /*0x3e52628*/ bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold);
        static /*0x3e52640*/ void ClearUnusedTextHandles();
        static /*0x3e5218c*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.TextCore.Text.TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached);
        static /*0x3e528f0*/ float GetLineHeight(UnityEngine.GUIStyle style);
        static /*0x3e51de4*/ void ConvertGUIStyleToGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.GUIStyle style, UnityEngine.Color textColor, string text, UnityEngine.Rect rect);
        static /*0x3e52abc*/ UnityEngine.TextCore.Text.TextOverflowMode LegacyClippingToNewOverflow(UnityEngine.TextClipping clipping);
        /*0x3e5285c*/ IMGUITextHandle();
        /*0x3e529f0*/ UnityEngine.Vector2 GetPreferredSize();

        class TextHandleTuple
        {
            /*0x10*/ float lastTimeUsed;
            /*0x14*/ int hashCode;

            /*0x3e528b8*/ TextHandleTuple(float lastTimeUsed, int hashCode);
        }
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

        static /*0x3e53800*/ GUILayoutEntry();
        /*0x3e52d28*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x3e52e20*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options);
        /*0x3e52bd4*/ UnityEngine.GUIStyle get_style();
        /*0x3e52bdc*/ void set_style(UnityEngine.GUIStyle value);
        /*0x3e52c10*/ int get_marginLeft();
        /*0x3e52c38*/ int get_marginRight();
        /*0x3e52c60*/ int get_marginTop();
        /*0x3e52c88*/ int get_marginBottom();
        /*0x3e52cb0*/ int get_marginHorizontal();
        /*0x3e52cec*/ int get_marginVertical();
        /*0x3e52f14*/ void CalcWidth();
        /*0x3e52f18*/ void CalcHeight();
        /*0x3e52f1c*/ void SetHorizontal(float x, float width);
        /*0x3e52f28*/ void SetVertical(float y, float height);
        /*0x3e52f34*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x3e52fc8*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x3e53294*/ string ToString();
    }

    class GUIGridSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ int m_Count;
        /*0x4c*/ int m_XCount;
        /*0x50*/ float m_MinButtonWidth;
        /*0x54*/ float m_MaxButtonWidth;
        /*0x58*/ float m_MinButtonHeight;
        /*0x5c*/ float m_MaxButtonHeight;

        static /*0x3e5385c*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        /*0x3e539d4*/ GUIGridSizer(UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle buttonStyle, UnityEngine.GUILayoutOption[] options);
        /*0x3e540f8*/ int get_rows();
    }

    class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ UnityEngine.GUIContent m_Content;
        /*0x50*/ float m_ForcedMinHeight;
        /*0x54*/ float m_ForcedMaxHeight;

        /*0x3e54110*/ GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options);
        /*0x3e541f4*/ void CalcWidth();
        /*0x3e5427c*/ void CalcHeight();
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

        static /*0x3e56dd0*/ GUILayoutGroup();
        /*0x3e542f8*/ GUILayoutGroup();
        /*0x3e542d8*/ int get_marginLeft();
        /*0x3e542e0*/ int get_marginRight();
        /*0x3e542e8*/ int get_marginTop();
        /*0x3e542f0*/ int get_marginBottom();
        /*0x3e54418*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x3e54510*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x3e54588*/ void ResetCursor();
        /*0x3e53e90*/ UnityEngine.GUILayoutEntry GetNext();
        /*0x3e54590*/ UnityEngine.Rect GetLast();
        /*0x3e53e38*/ void Add(UnityEngine.GUILayoutEntry e);
        /*0x3e548bc*/ void CalcWidth();
        /*0x3e54ff0*/ void SetHorizontal(float x, float width);
        /*0x3e55984*/ void CalcHeight();
        /*0x3e5600c*/ void SetVertical(float y, float height);
        /*0x3e569b0*/ string ToString();
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

        /*0x3e56ea8*/ GUIScrollGroup();
        /*0x3e56f04*/ void CalcWidth();
        /*0x3e56f78*/ void SetHorizontal(float x, float width);
        /*0x3e57050*/ void CalcHeight();
        /*0x3e57120*/ void SetVertical(float y, float height);
    }

    class ObjectGUIState : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3e572c8*/ nint Internal_Create();
        static /*0x3e57490*/ void Internal_Destroy(nint ptr);
        /*0x3e57284*/ ObjectGUIState();
        /*0x3e572f0*/ void Dispose();
        /*0x3e573d0*/ void Finalize();
        /*0x3e57384*/ void Destroy();

        class BindingsMarshaller
        {
            static /*0x3e574cc*/ nint ConvertToNative(UnityEngine.ObjectGUIState objectGUIState);
        }
    }

    class RuntimeTextSettings : UnityEngine.TextCore.Text.TextSettings
    {
        static /*0x0*/ UnityEngine.RuntimeTextSettings s_DefaultTextSettings;
        static /*0x8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> s_FallbackOSFontAssetIMGUIInternal;

        static /*0x3e529f8*/ UnityEngine.RuntimeTextSettings get_defaultTextSettings();
        /*0x3e57578*/ RuntimeTextSettings();
        /*0x3e574e0*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset();
        /*0x3e57528*/ void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets);
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

        /*0x3e57580*/ ScrollViewState();
    }

    class SliderState
    {
        /*0x10*/ float dragStartPos;
        /*0x14*/ float dragStartValue;
        /*0x18*/ bool isDragging;

        /*0x3e57588*/ SliderState();
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

        /*0x3e57590*/ SliderHandler(UnityEngine.Rect position, float currentValue, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        /*0x3e57600*/ float Handle();
        /*0x3e576a8*/ float OnMouseDown();
        /*0x3e57ab8*/ float OnMouseDrag();
        /*0x3e57bd0*/ float OnMouseUp();
        /*0x3e57c64*/ float OnRepaint();
        /*0x3e57680*/ UnityEngine.EventType CurrentEventType();
        /*0x3e583ac*/ int CurrentScrollTroughSide();
        /*0x3e581cc*/ bool IsEmptySlider();
        /*0x3e58250*/ bool SupportsPageMovements();
        /*0x3e58424*/ float PageMovementValue();
        /*0x3e586f8*/ float PageUpMovementBound();
        /*0x3e581c4*/ UnityEngine.Event CurrentEvent();
        /*0x3e584d4*/ float ValueForCurrentMousePosition();
        /*0x3e58548*/ float Clamp(float value);
        /*0x3e581c0*/ UnityEngine.Rect ThumbSelectionRect();
        /*0x3e58208*/ void StartDraggingWithValue(float dragStartValue);
        /*0x3e582c0*/ UnityEngine.SliderState SliderState();
        /*0x3e58670*/ UnityEngine.Rect ThumbExtRect();
        /*0x3e586e8*/ UnityEngine.Rect ThumbRect();
        /*0x3e5875c*/ UnityEngine.Rect VerticalThumbRect();
        /*0x3e58884*/ UnityEngine.Rect HorizontalThumbRect();
        /*0x3e581dc*/ float ClampedCurrentValue();
        /*0x3e58574*/ float MousePosition();
        /*0x3e585cc*/ float ValuesPerPixel();
        /*0x3e589ac*/ float ThumbSize();
        /*0x3e58744*/ float MaxValue();
        /*0x3e58734*/ float MinValue();
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
        /*0x18*/ UnityEngine.TextCore.Text.TextHandle textHandle;
        /*0x20*/ int m_CursorIndexSavedState;
        /*0x24*/ bool isCompositionActive;
        /*0x25*/ bool m_UpdateImeWindowPosition;
        /*0x28*/ System.Action OnTextChanged;
        /*0x30*/ bool multiline;
        /*0x38*/ string m_Text;
        /*0x40*/ char m_HighSurrogate;

        static /*0x3e5b510*/ void MapKey(string key, UnityEngine.TextEditOp action);
        static /*0x3e5bd08*/ string ReplaceNewlinesWithSpaces(string value);
        /*0x3e58ec0*/ TextEditingUtilities(UnityEngine.TextSelectingUtilities selectingUtilities, UnityEngine.TextCore.Text.TextHandle textHandle, string text);
        /*0x3e58a54*/ bool get_hasSelection();
        /*0x3e58ac0*/ void set_revealCursor(bool value);
        /*0x3e58b30*/ int get_stringCursorIndex();
        /*0x3e58b64*/ int get_cursorIndex();
        /*0x3e58bd0*/ void set_cursorIndex(int value);
        /*0x3e58c38*/ int get_cursorIndexNoValidation();
        /*0x3e58c58*/ void set_cursorIndexNoValidation(int value);
        /*0x3e58cc0*/ void set_selectIndexNoValidation(int value);
        /*0x3e58d28*/ int get_stringSelectIndex();
        /*0x3e58d5c*/ int get_selectIndex();
        /*0x3e58dc8*/ void set_selectIndex(int value);
        /*0x3e58e30*/ string get_text();
        /*0x3e58e38*/ void set_text(string value);
        /*0x3e58eb8*/ void SetTextWithoutNotify(string value);
        /*0x3e58f2c*/ bool UpdateImeState();
        /*0x3e590e0*/ bool ShouldUpdateImeWindowPosition();
        /*0x3e590e8*/ void SetImeWindowPosition(UnityEngine.Vector2 worldPosition);
        /*0x3e59190*/ string GeneratePreviewString(bool richText);
        /*0x3e592cc*/ void EnableCursorPreviewState();
        /*0x3e5928c*/ void RestoreCursorState();
        /*0x3e59368*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x3e59af8*/ void PerformOperation(UnityEngine.TextEditOp operation);
        /*0x3e59488*/ void InitKeyActions();
        /*0x3e5b2c8*/ bool DeleteLineBack();
        /*0x3e5b1e4*/ bool DeleteWordBack();
        /*0x3e5b42c*/ bool DeleteWordForward();
        /*0x3e5adc8*/ bool Delete();
        /*0x3e5aef4*/ bool Backspace();
        /*0x3e5b5a8*/ bool DeleteSelection();
        /*0x3e58fd4*/ void ReplaceSelection(string replace);
        /*0x3e5baec*/ bool Insert(char c);
        /*0x3e5bc18*/ bool CanPaste();
        /*0x3e5b114*/ bool Cut();
        /*0x3e5b138*/ bool Paste();
        /*0x3e5bd9c*/ void OnBlur();
        /*0x3e5be14*/ bool TouchScreenKeyboardShouldBeUsed();
    }

    class TextEditor
    {
        /*0x10*/ UnityEngine.GUIContent m_Content;
        /*0x18*/ UnityEngine.TextSelectingUtilities m_TextSelecting;
        /*0x20*/ UnityEngine.TextEditingUtilities m_TextEditing;
        /*0x28*/ UnityEngine.IMGUITextHandle m_TextHandle;
        /*0x30*/ UnityEngine.TouchScreenKeyboard keyboardOnScreen;
        /*0x38*/ int controlID;
        /*0x40*/ UnityEngine.GUIStyle style;
        /*0x48*/ bool hasHorizontalCursorPos;
        /*0x49*/ bool isPasswordField;
        /*0x4c*/ UnityEngine.Vector2 scrollOffset;
        /*0x54*/ bool focus;
        /*0x58*/ string m_TextWithWhitespace;
        /*0x60*/ UnityEngine.Rect <position>k__BackingField;
        /*0x70*/ UnityEngine.Vector2 graphicalCursorPos;
        /*0x78*/ UnityEngine.Vector2 lastCursorPos;
        /*0x80*/ UnityEngine.Vector2 previousContentSize;
        /*0x88*/ string oldText;
        /*0x90*/ int oldPos;
        /*0x94*/ int oldSelectPos;

        /*0x3e5c224*/ TextEditor();
        /*0x3e5be9c*/ void set_isMultiline(bool value);
        /*0x3e5beb8*/ bool get_showCursor();
        /*0x3e5bed0*/ bool get_m_HasFocus();
        /*0x3e5bed8*/ void set_m_HasFocus(bool value);
        /*0x3e5bee0*/ string get_text();
        /*0x3e5bef8*/ void set_text(string value);
        /*0x3e5c174*/ string get_textWithWhitespace();
        /*0x3e5bfb8*/ void set_textWithWhitespace(string value);
        /*0x3e5c1e4*/ UnityEngine.Rect get_position();
        /*0x3e5c1f0*/ void set_position(UnityEngine.Rect value);
        /*0x3e5c1fc*/ int get_cursorIndex();
        /*0x3e5c210*/ int get_selectIndex();
        /*0x3e5c6cc*/ void OnTextChangedHandle();
        /*0x3e5c714*/ void OnContentTextChangedHandle();
        /*0x3e5c754*/ void OnFocus();
        /*0x3e5c7c0*/ void OnLostFocus();
        /*0x3e5c7c8*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x3e5c92c*/ void ReplaceSelection(string replace);
        /*0x3e5c940*/ void Insert(char c);
        /*0x3e5c954*/ void MoveCursorToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x3e5c9a0*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x3e5cb24*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x3e5c9d0*/ UnityEngine.Vector2 GetLocalCursorPosition(UnityEngine.Vector2 cursorPosition);
        /*0x3e5d090*/ void MouseDragSelectsWholeWords(bool on);
        /*0x3e5d128*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x3e5d148*/ void SelectCurrentWord();
        /*0x3e5d350*/ void SelectCurrentParagraph();
        /*0x3e5d4f8*/ void UpdateScrollOffsetIfNeeded(UnityEngine.Event evt);
        /*0x3e5c038*/ void UpdateTextHandle();
        /*0x3e5d554*/ void UpdateScrollOffset();
        /*0x3e5d94c*/ void DrawCursor(string newText);
        /*0x3e5dd10*/ void SaveBackup();
        /*0x3e5dd6c*/ void DetectFocusChange();
        /*0x3e5dd78*/ void OnDetectFocusChange();
        /*0x3e5de20*/ void OnCursorIndexChange();
        /*0x3e5de24*/ void OnSelectIndexChange();

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
        /*0x28*/ UnityEngine.TextCore.Text.TextHandle textHandle;
        /*0x30*/ bool m_RevealCursor;
        /*0x34*/ int m_CursorIndex;
        /*0x38*/ int m_SelectIndex;
        /*0x40*/ System.Action OnCursorIndexChange;
        /*0x48*/ System.Action OnSelectIndexChange;
        /*0x50*/ System.Action OnRevealCursorChange;

        static /*0x3e5f2dc*/ void MapKey(string key, UnityEngine.TextSelectOp action);
        /*0x3e5c67c*/ TextSelectingUtilities(UnityEngine.TextCore.Text.TextHandle textHandle);
        /*0x3e58a90*/ bool get_hasSelection();
        /*0x3e5de28*/ bool get_revealCursor();
        /*0x3e58b00*/ void set_revealCursor(bool value);
        /*0x3e5de30*/ int get_m_CharacterCount();
        /*0x3e5de48*/ int get_characterCount();
        /*0x3e5df18*/ UnityEngine.TextCore.Text.TextElementInfo[] get_m_TextElementInfos();
        /*0x3e58b78*/ int get_cursorIndex();
        /*0x3e58c0c*/ void set_cursorIndex(int value);
        /*0x3e58c50*/ int get_cursorIndexNoValidation();
        /*0x3e58c94*/ void set_cursorIndexNoValidation(int value);
        /*0x3e5df64*/ void SetCursorIndexWithoutNotify(int index);
        /*0x3e58d70*/ int get_selectIndex();
        /*0x3e58e04*/ void set_selectIndex(int value);
        /*0x3e58cfc*/ void set_selectIndexNoValidation(int value);
        /*0x3e5df6c*/ void SetSelectIndexWithoutNotify(int index);
        /*0x3e5df74*/ string get_selectedText();
        /*0x3e5c814*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x3e5e484*/ bool PerformOperation(UnityEngine.TextSelectOp operation);
        /*0x3e5e068*/ void InitKeyActions();
        /*0x3e5badc*/ void ClearCursorPos();
        /*0x3e5c778*/ void OnFocus(bool selectAll);
        /*0x3e5f270*/ void SelectAll();
        /*0x3e5bdcc*/ void SelectNone();
        /*0x3e5e674*/ void SelectLeft();
        /*0x3e5e75c*/ void SelectRight();
        /*0x3e5e844*/ void SelectUp();
        /*0x3e5e8ac*/ void SelectDown();
        /*0x3e5ecac*/ void SelectTextEnd();
        /*0x3e5ec84*/ void SelectTextStart();
        /*0x3e5ec2c*/ void SelectToStartOfNextWord();
        /*0x3e5ebd4*/ void SelectToEndOfPreviousWord();
        /*0x3e5e914*/ void SelectWordRight();
        /*0x3e5ea74*/ void SelectWordLeft();
        /*0x3e5f1c0*/ void SelectGraphicalLineStart();
        /*0x3e5f218*/ void SelectGraphicalLineEnd();
        /*0x3e5eea4*/ void SelectParagraphForward();
        /*0x3e5f014*/ void SelectParagraphBackward();
        /*0x3e5d15c*/ void SelectCurrentWord();
        /*0x3e5d364*/ void SelectCurrentParagraph();
        /*0x3e59eec*/ void MoveRight();
        /*0x3e59e00*/ void MoveLeft();
        /*0x3e59fe0*/ void MoveUp();
        /*0x3e5a0f8*/ void MoveDown();
        /*0x3e5a21c*/ void MoveLineStart();
        /*0x3e5a348*/ void MoveLineEnd();
        /*0x3e5ac60*/ void MoveGraphicalLineStart();
        /*0x3e5ad14*/ void MoveGraphicalLineEnd();
        /*0x3e5a81c*/ void MoveTextStart();
        /*0x3e5a878*/ void MoveTextEnd();
        /*0x3e5a8f0*/ void MoveParagraphForward();
        /*0x3e5aa88*/ void MoveParagraphBackward();
        /*0x3e5a494*/ void MoveWordRight();
        /*0x3e5a59c*/ void MoveToStartOfNextWord();
        /*0x3e5a658*/ void MoveToEndOfPreviousWord();
        /*0x3e5a714*/ void MoveWordLeft();
        /*0x3e5d0a8*/ void MouseDragSelectsWholeWords(bool on);
        /*0x3e5ecec*/ void ExpandSelectGraphicalLineStart();
        /*0x3e5edc8*/ void ExpandSelectGraphicalLineEnd();
        /*0x3e5d140*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x3e5ca8c*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x3e5cb44*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x3e5f748*/ int FindNextSeperator(int startPos);
        /*0x3e5f7cc*/ int FindPrevSeperator(int startPos);
        /*0x3e5b884*/ int FindStartOfNextWord(int p);
        /*0x3e5b774*/ int FindEndOfPreviousWord(int p);
        /*0x3e5f608*/ int FindEndOfClassification(int p, UnityEngine.TextSelectingUtilities.Direction dir);
        /*0x3e5df40*/ int ClampTextIndex(int index);
        /*0x3e5f5c8*/ int IndexOfEndOfLine(int startIndex);
        /*0x3e5ba80*/ int PreviousCodePointIndex(int index);
        /*0x3e5f374*/ int NextCodePointIndex(int index);
        /*0x3e5f3d4*/ int GetGraphicalLineStart(int p);
        /*0x3e5f4c8*/ int GetGraphicalLineEnd(int p);
        /*0x3e5bc7c*/ void Copy();
        /*0x3e5f868*/ UnityEngine.TextSelectingUtilities.CharacterType ClassifyChar(int index);

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
    static /*0x3e5f94c*/ uint ComputeStringHash(string s);
}
