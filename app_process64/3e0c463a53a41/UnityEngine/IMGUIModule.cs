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

        static /*0x7ec366c*/ nint Internal_Create(int displayIndex);
        static /*0x7ec36a8*/ void Internal_Destroy(nint ptr);
        static /*0x7ec381c*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x7ec38f4*/ void GetEventAtIndex(int index, UnityEngine.Event outEvent);
        static /*0x7ec39dc*/ int GetEventCount();
        static /*0x7ec3a04*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x7ec3a40*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x7ec3b6c*/ int GetDoubleClickTime();
        static /*0x7ec3d5c*/ UnityEngine.Event get_current();
        static /*0x7ec3da4*/ void set_current(UnityEngine.Event value);
        static /*0x7ec3e8c*/ UnityEngine.Event KeyboardEvent(string key);
        static /*0x7ec25a0*/ UnityEngine.EventType get_rawType_Injected(nint _unity_self);
        static /*0x7ec263c*/ void get_mousePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ec26dc*/ void set_mousePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7ec2780*/ void get_delta_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ec2820*/ void set_delta_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7ec28b4*/ UnityEngine.PointerType get_pointerType_Injected(nint _unity_self);
        static /*0x7ec2940*/ int get_button_Injected(nint _unity_self);
        static /*0x7ec29cc*/ UnityEngine.EventModifiers get_modifiers_Injected(nint _unity_self);
        static /*0x7ec2a60*/ void set_modifiers_Injected(nint _unity_self, UnityEngine.EventModifiers value);
        static /*0x7ec2af4*/ float get_pressure_Injected(nint _unity_self);
        static /*0x7ec2b80*/ float get_twist_Injected(nint _unity_self);
        static /*0x7ec2c1c*/ void get_tilt_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ec2cb0*/ UnityEngine.PenStatus get_penStatus_Injected(nint _unity_self);
        static /*0x7ec2d3c*/ int get_clickCount_Injected(nint _unity_self);
        static /*0x7ec2dc8*/ char get_character_Injected(nint _unity_self);
        static /*0x7ec2e5c*/ void set_character_Injected(nint _unity_self, char value);
        static /*0x7ec2ef0*/ UnityEngine.KeyCode get_Internal_keyCode_Injected(nint _unity_self);
        static /*0x7ec2f84*/ void set_Internal_keyCode_Injected(nint _unity_self, UnityEngine.KeyCode value);
        static /*0x7ec30ec*/ int get_displayIndex_Injected(nint _unity_self);
        static /*0x7ec3180*/ void set_displayIndex_Injected(nint _unity_self, int value);
        static /*0x7ec3214*/ UnityEngine.EventType get_type_Injected(nint _unity_self);
        static /*0x7ec32a8*/ void set_type_Injected(nint _unity_self, UnityEngine.EventType value);
        static /*0x7ec33c8*/ void get_commandName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ec359c*/ void set_commandName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7ec3630*/ void Internal_Use_Injected(nint _unity_self);
        static /*0x7ec373c*/ UnityEngine.EventType GetTypeForControl_Injected(nint _unity_self, int controlID);
        static /*0x7ec37d8*/ void CopyFromPtr_Injected(nint _unity_self, nint ptr);
        static /*0x7ec38b8*/ bool PopEvent_Injected(nint outEvent);
        static /*0x7ec3998*/ void GetEventAtIndex_Injected(int index, nint outEvent);
        /*0x7ec3b94*/ Event();
        /*0x7ec3b1c*/ Event(int displayIndex);
        /*0x7ec2550*/ UnityEngine.EventType get_rawType();
        /*0x7ec25dc*/ UnityEngine.Vector2 get_mousePosition();
        /*0x7ec2680*/ void set_mousePosition(UnityEngine.Vector2 value);
        /*0x7ec2720*/ UnityEngine.Vector2 get_delta();
        /*0x7ec27c4*/ void set_delta(UnityEngine.Vector2 value);
        /*0x7ec2864*/ UnityEngine.PointerType get_pointerType();
        /*0x7ec28f0*/ int get_button();
        /*0x7ec297c*/ UnityEngine.EventModifiers get_modifiers();
        /*0x7ec2a08*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x7ec2aa4*/ float get_pressure();
        /*0x7ec2b30*/ float get_twist();
        /*0x7ec2bbc*/ UnityEngine.Vector2 get_tilt();
        /*0x7ec2c60*/ UnityEngine.PenStatus get_penStatus();
        /*0x7ec2cec*/ int get_clickCount();
        /*0x7ec2d78*/ char get_character();
        /*0x7ec2e04*/ void set_character(char value);
        /*0x7ec2ea0*/ UnityEngine.KeyCode get_Internal_keyCode();
        /*0x7ec2f2c*/ void set_Internal_keyCode(UnityEngine.KeyCode value);
        /*0x7ec2fc8*/ UnityEngine.KeyCode get_keyCode();
        /*0x7ec3098*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x7ec309c*/ int get_displayIndex();
        /*0x7ec3128*/ void set_displayIndex(int value);
        /*0x7ec31c4*/ UnityEngine.EventType get_type();
        /*0x7ec3250*/ void set_type(UnityEngine.EventType value);
        /*0x7ec32ec*/ string get_commandName();
        /*0x7ec340c*/ void set_commandName(string value);
        /*0x7ec35e0*/ void Internal_Use();
        /*0x7ec36e4*/ UnityEngine.EventType GetTypeForControl(int controlID);
        /*0x7ec3780*/ void CopyFromPtr(nint ptr);
        /*0x7ec3be0*/ void Finalize();
        /*0x7ec3ca4*/ void CopyFrom(UnityEngine.Event e);
        /*0x7ec3cd0*/ bool get_shift();
        /*0x7ec3ce4*/ bool get_control();
        /*0x7ec3cf8*/ bool get_alt();
        /*0x7ec3d0c*/ bool get_command();
        /*0x7ec3d20*/ bool get_capsLock();
        /*0x7ec3d34*/ bool get_numeric();
        /*0x7ec3d48*/ bool get_functionKey();
        /*0x7ec3e3c*/ bool get_isKey();
        /*0x7ec304c*/ bool get_isMouse();
        /*0x7ec3080*/ bool get_isScrollWheel();
        /*0x7ec3e58*/ bool get_isDirectManipulationDevice();
        /*0x7ec5008*/ int GetHashCode();
        /*0x7ec50bc*/ bool Equals(object obj);
        /*0x7ec5268*/ string ToString();
        /*0x7ec5920*/ void Use();

        class BindingsMarshaller
        {
            static /*0x7ec5a80*/ nint ConvertToNative(UnityEngine.Event e);
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

        /*0x7ec5a98*/ bool get_wantsMouseMove();
        /*0x7ec5aa0*/ void set_wantsMouseMove(bool value);
        /*0x7ec5aac*/ bool get_wantsMouseEnterLeaveWindow();
        /*0x7ec5ab4*/ void set_wantsMouseEnterLeaveWindow(bool value);
        /*0x7ec5ac0*/ bool get_wantsLessLayoutEvents();
        /*0x7ec5ac8*/ bool WantsEvent(UnityEngine.EventType type);
        /*0x7ec5af8*/ bool WantsLayoutPass(UnityEngine.EventType type);
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

        static /*0x7ec63c4*/ GUI();
        static /*0x7ec5bfc*/ UnityEngine.Color get_color();
        static /*0x7ec5cc0*/ void set_color(UnityEngine.Color value);
        static /*0x7ec5d80*/ UnityEngine.Color get_backgroundColor();
        static /*0x7ec5e44*/ void set_backgroundColor(UnityEngine.Color value);
        static /*0x7ec5f04*/ UnityEngine.Color get_contentColor();
        static /*0x7ec5fc8*/ void set_contentColor(UnityEngine.Color value);
        static /*0x7ec6088*/ bool get_changed();
        static /*0x7ec60b0*/ void set_changed(bool value);
        static /*0x7ec60ec*/ bool get_enabled();
        static /*0x7ec6114*/ void set_enabled(bool value);
        static /*0x7ec6150*/ bool get_usePageScrollbars();
        static /*0x7ec6178*/ void GrabMouseControl(int id);
        static /*0x7ec61b4*/ bool HasMouseControl(int id);
        static /*0x7ec61f0*/ void ReleaseMouseControl();
        static /*0x7ec6218*/ void InternalRepaintEditorWindow();
        static /*0x7ec6240*/ UnityEngine.Rect Internal_DoWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout);
        static /*0x7ec665c*/ int get_scrollTroughSide();
        static /*0x7ec66b4*/ void set_scrollTroughSide(int value);
        static /*0x7ec6710*/ System.DateTime get_nextScrollStepTime();
        static /*0x7ec6768*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x7ec67c4*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x7ec69d0*/ UnityEngine.GUISkin get_skin();
        static /*0x7ec6900*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x7ec6bb0*/ UnityEngine.Matrix4x4 get_matrix();
        static /*0x7ec6c88*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x7ec6d10*/ void Label(UnityEngine.Rect position, string text);
        static /*0x7ec6ea8*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec71f0*/ void Box(UnityEngine.Rect position, string text);
        static /*0x7ec72c8*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec75d0*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec775c*/ bool Button(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec7930*/ bool DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType);
        static /*0x7ec7da4*/ bool DoControl(UnityEngine.Rect position, int id, bool on, bool hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec6f64*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec7820*/ bool DoButton(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ec85e4*/ float Slider(UnityEngine.Rect position, float value, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        static /*0x7ec8784*/ float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style);
        static /*0x7ec8f48*/ bool ScrollerRepeatButton(int scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style);
        static /*0x7ec91f8*/ float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style);
        static /*0x7ec8bac*/ float Scroller(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, bool horiz);
        static /*0x7ec94b4*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x7ec950c*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background);
        static /*0x7eca144*/ void EndScrollView(bool handleScrollWheel);
        static /*0x7ecac70*/ UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text);
        static /*0x7ecad90*/ UnityEngine.Rect DoWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, bool forceRectOnLayout);
        static /*0x7ecae8c*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x7ec5c84*/ void get_color_Injected(ref UnityEngine.Color ret);
        static /*0x7ec5d44*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x7ec5e08*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x7ec5ec8*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        static /*0x7ec5f8c*/ void get_contentColor_Injected(ref UnityEngine.Color ret);
        static /*0x7ec604c*/ void set_contentColor_Injected(ref UnityEngine.Color value);
        static /*0x7ec6328*/ void Internal_DoWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout, ref UnityEngine.Rect ret);

        class WindowFunction : System.MulticastDelegate
        {
            /*0x7ecb8a8*/ WindowFunction(object object, nint method);
            /*0x7ecb948*/ void Invoke(int id);
        }
    }

    class GUIClip
    {
        static /*0x7ec8268*/ UnityEngine.Rect get_visibleRect();
        static /*0x7ecb998*/ void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x7ecba58*/ void Internal_Pop();
        static /*0x7ecba80*/ int Internal_GetCount();
        static /*0x7ec6c24*/ UnityEngine.Matrix4x4 GetMatrix();
        static /*0x7ec6cd4*/ void SetMatrix(UnityEngine.Matrix4x4 m);
        static /*0x7ecbb20*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
        static /*0x7ecbb60*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect);
        static /*0x7ecbc10*/ void Internal_PopParentClip();
        static /*0x7eca13c*/ void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x7ecac48*/ void Pop();
        static /*0x7ecb95c*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x7ecb9fc*/ void Internal_Push_Injected(ref UnityEngine.Rect screenRect, ref UnityEngine.Vector2 scrollOffset, ref UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x7ecbaa8*/ void GetMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        static /*0x7ecbae4*/ void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x7ecbbbc*/ void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect);

        struct ParentClipScope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x7ecbc38*/ ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
            /*0x7ecbc8c*/ void Dispose();
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

        static /*0x7ecc320*/ GUIContent();
        static /*0x7ec6de0*/ UnityEngine.GUIContent Temp(string t);
        static /*0x7ecc1a0*/ void ClearStaticCache();
        /*0x7ecbfa4*/ GUIContent();
        /*0x7ecc010*/ GUIContent(string text);
        /*0x7ecc0e4*/ GUIContent(string text, string tooltip);
        /*0x7ecc02c*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x7ecc0f0*/ GUIContent(UnityEngine.GUIContent src);
        /*0x7ecbccc*/ void add_OnTextChanged(System.Action value);
        /*0x7ecbd68*/ void remove_OnTextChanged(System.Action value);
        /*0x7ecbe04*/ string get_text();
        /*0x7ecbe0c*/ void set_text(string value);
        /*0x7ecbef8*/ string get_textWithWhitespace();
        /*0x7ecbe78*/ void set_textWithWhitespace(string value);
        /*0x7ecbf68*/ void SetTextWithoutNotify(string value);
        /*0x7ecbf94*/ void set_image(UnityEngine.Texture value);
        /*0x7ec8260*/ string get_tooltip();
        /*0x7ecbf9c*/ void set_tooltip(string value);
        /*0x7ecc300*/ string ToString();
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
        static /*0x7ecc450*/ void Label(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x7ecc4f8*/ void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ecc630*/ bool Button(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x7ecc6e0*/ bool DoButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ecc7ac*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options);
        static /*0x7eccd44*/ void EndScrollView();
        static /*0x7eccd4c*/ void EndScrollView(bool handleScrollWheel);
        static /*0x7ecb294*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x7ecb330*/ UnityEngine.GUILayoutOption Height(float height);
    }

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x7ecd04c*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

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

        static /*0x7ecec4c*/ GUILayoutUtility();
        static /*0x7ecd084*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x7ecd158*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x7ecd228*/ int get_unbalancedgroupscount();
        static /*0x7ecd280*/ void set_unbalancedgroupscount(int value);
        static /*0x7ecd2dc*/ UnityEngine.GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow);
        static /*0x7ecb124*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x7ecd484*/ void RemoveSelectedIdList(int instanceID, bool isWindow);
        static /*0x7ecd558*/ void Begin(int instanceID);
        static /*0x7ecd874*/ void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache);
        static /*0x7ecb3d0*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ecb68c*/ void Layout();
        static /*0x7ecdd88*/ void LayoutFromEditorWindow();
        static /*0x7ecdf98*/ void LayoutFromContainer(float w, float h);
        static /*0x7ecda54*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x7ecdc10*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x7ece128*/ UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType);
        static /*0x7ecca1c*/ UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType);
        static /*0x7eccdc8*/ void EndLayoutGroup();
        static /*0x7ecc5c4*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ece6a0*/ UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ecd114*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x7ecd1e4*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x7ecd384*/ LayoutCache(int instanceID);
            /*0x7eced60*/ void set_id(int value);
            /*0x7eced68*/ void ResetCursor();
        }
    }

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        /*0x7ecf044*/ GUISettings();
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

        static /*0x7ecf1c8*/ void CleanupRoots();
        static /*0x7ecf6f8*/ UnityEngine.GUIStyle get_error();
        /*0x7ecf070*/ GUISkin();
        /*0x7ecf148*/ void OnEnable();
        /*0x7ecf230*/ UnityEngine.Font get_font();
        /*0x7ecf238*/ void set_font(UnityEngine.Font value);
        /*0x7ec72c0*/ UnityEngine.GUIStyle get_box();
        /*0x7ecf3b0*/ void set_box(UnityEngine.GUIStyle value);
        /*0x7ec6ea0*/ UnityEngine.GUIStyle get_label();
        /*0x7ecf3cc*/ void set_label(UnityEngine.GUIStyle value);
        /*0x7ecf3e8*/ UnityEngine.GUIStyle get_textField();
        /*0x7ecf3f0*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x7ecf40c*/ UnityEngine.GUIStyle get_textArea();
        /*0x7ecf414*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x7ecc6d8*/ UnityEngine.GUIStyle get_button();
        /*0x7ecf430*/ void set_button(UnityEngine.GUIStyle value);
        /*0x7ecf44c*/ UnityEngine.GUIStyle get_toggle();
        /*0x7ecf454*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x7ecad88*/ UnityEngine.GUIStyle get_window();
        /*0x7ecf470*/ void set_window(UnityEngine.GUIStyle value);
        /*0x7ecf48c*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x7ecf494*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x7ecf4b0*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x7ecf4b8*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x7ecf4d4*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x7ecf4dc*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x7ecf4f8*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x7ecf500*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x7ecf51c*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x7ecf524*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x7ecf540*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x7ecf548*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x7ecf564*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x7ecf56c*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x7ecf588*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x7ecf590*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x7ecf5ac*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x7ecf5b4*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x7ecf5d0*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x7ecf5d8*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x7ecf5f4*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x7ecf5fc*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x7ecf618*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x7ecf620*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x7ecf63c*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x7ecf644*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x7ecf660*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x7ecf668*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x7ecf684*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x7ecf68c*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x7ecf6a8*/ UnityEngine.GUIStyle get_scrollView();
        /*0x7ecf6b0*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x7ecf6cc*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x7ecf6d4*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x7ecf6f0*/ UnityEngine.GUISettings get_settings();
        /*0x7ecf14c*/ void Apply();
        /*0x7ecf88c*/ void BuildStyleCache();
        /*0x7ec8960*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x7ed08c4*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x7ec6af8*/ void MakeCurrent();
        /*0x7ed094c*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0x7ed0a0c*/ SkinChangedDelegate(object object, nint method);
            /*0x7ed0aa8*/ void Invoke();
        }
    }

    class GUIStateObjects
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, object> s_StateCache;

        static /*0x7ed0bf8*/ GUIStateObjects();
        static /*0x7ed0abc*/ object GetStateObject(System.Type t, int controlID);
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x7ed0cd4*/ nint Init();
        static /*0x7ed0e0c*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        static /*0x7ed0c90*/ void set_textColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7ed0d4c*/ void Cleanup_Injected(nint _unity_self);
        /*0x7ed0d88*/ GUIStyleState();
        /*0x7ed0dd0*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x7ed085c*/ void set_textColor(UnityEngine.Color value);
        /*0x7ed0cfc*/ void Cleanup();
        /*0x7ed0e84*/ void Finalize();

        class BindingsMarshaller
        {
            static /*0x7ed0f28*/ nint ConvertToNative(UnityEngine.GUIStyleState guiStyleState);
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

        static /*0x7ed365c*/ GUIStyle();
        static /*0x7ed1d30*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x7ed1d6c*/ void Internal_Destroy(nint self);
        static /*0x7ec844c*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x7ec82b0*/ bool IsTooltipActive(string tooltip);
        static /*0x7ecf310*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x7ed2730*/ UnityEngine.Font GetDefaultFont();
        static /*0x7ed27e0*/ void Internal_DestroyTextGenerator(int meshInfoId);
        static /*0x7ec9fec*/ UnityEngine.GUIStyle get_none();
        static /*0x7ed312c*/ void GetMeshInfo(UnityEngine.GUIStyle style, UnityEngine.Color color, string content, UnityEngine.Rect rect, ref UnityEngine.TextCore.Text.MeshInfoBindings[] meshInfos, ref UnityEngine.Vector2 dimensions, ref int generationId);
        static /*0x7ed351c*/ void GetDimensions(UnityEngine.GUIStyle style, UnityEngine.Color color, string content, UnityEngine.Rect rect, ref UnityEngine.Vector2 dimensions);
        static /*0x7ed354c*/ void GetLineHeight(UnityEngine.GUIStyle style, ref float lineHeight);
        static /*0x7ed356c*/ void EmptyManagedCache();
        static /*0x7ed1054*/ void get_rawName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ed124c*/ void set_rawName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7ed133c*/ nint get_font_Injected(nint _unity_self);
        static /*0x7ed1408*/ UnityEngine.ImagePosition get_imagePosition_Injected(nint _unity_self);
        static /*0x7ed14d4*/ UnityEngine.TextAnchor get_alignment_Injected(nint _unity_self);
        static /*0x7ed15b0*/ void set_alignment_Injected(nint _unity_self, UnityEngine.TextAnchor value);
        static /*0x7ed1684*/ bool get_wordWrap_Injected(nint _unity_self);
        static /*0x7ed1750*/ UnityEngine.TextClipping get_clipping_Injected(nint _unity_self);
        static /*0x7ed1834*/ void get_contentOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ed1878*/ float get_fixedWidth_Injected(nint _unity_self);
        static /*0x7ed18b4*/ float get_fixedHeight_Injected(nint _unity_self);
        static /*0x7ed1980*/ bool get_stretchWidth_Injected(nint _unity_self);
        static /*0x7ed1a4c*/ bool get_stretchHeight_Injected(nint _unity_self);
        static /*0x7ed1a88*/ void set_stretchHeight_Injected(nint _unity_self, bool value);
        static /*0x7ed1b5c*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x7ed1c28*/ UnityEngine.FontStyle get_fontStyle_Injected(nint _unity_self);
        static /*0x7ed1cf4*/ bool get_richText_Injected(nint _unity_self);
        static /*0x7ed1e48*/ nint GetStyleStatePtr_Injected(nint _unity_self, int idx);
        static /*0x7ed1f2c*/ nint GetRectOffsetPtr_Injected(nint _unity_self, int idx);
        static /*0x7ed2058*/ void Internal_Draw_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        static /*0x7ed21ac*/ void Internal_Draw2_Injected(nint _unity_self, ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        static /*0x7ed22d8*/ void Internal_CalcSizeWithConstraints_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, ref UnityEngine.Vector2 ret);
        static /*0x7ed23e4*/ float Internal_CalcHeight_Injected(nint _unity_self, UnityEngine.GUIContent content, float width);
        static /*0x7ed24e8*/ void Internal_CalcMinMaxWidth_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        static /*0x7ed2608*/ void Internal_GetTextRectOffset_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, ref UnityEngine.Vector2 textSize, ref UnityEngine.Vector2 ret);
        static /*0x7ed2674*/ void SetMouseTooltip_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tooltip, ref UnityEngine.Rect screenRect);
        static /*0x7ed26b8*/ bool IsTooltipActive_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tooltip);
        static /*0x7ed26f4*/ void SetDefaultFont_Injected(nint font);
        static /*0x7ed27b8*/ nint GetDefaultFont_Injected();
        /*0x7ecf7d8*/ GUIStyle();
        /*0x7ed0f40*/ string get_rawName();
        /*0x7ed1098*/ void set_rawName(string value);
        /*0x7ed1290*/ UnityEngine.Font get_font();
        /*0x7ed1378*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x7ed1444*/ UnityEngine.TextAnchor get_alignment();
        /*0x7ed1510*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x7ed15f4*/ bool get_wordWrap();
        /*0x7ed16c0*/ UnityEngine.TextClipping get_clipping();
        /*0x7ed178c*/ UnityEngine.Vector2 get_contentOffset();
        /*0x7ec9394*/ float get_fixedWidth();
        /*0x7ec9424*/ float get_fixedHeight();
        /*0x7ed18f0*/ bool get_stretchWidth();
        /*0x7ed19bc*/ bool get_stretchHeight();
        /*0x7ed076c*/ void set_stretchHeight(bool value);
        /*0x7ed1acc*/ int get_fontSize();
        /*0x7ed1b98*/ UnityEngine.FontStyle get_fontStyle();
        /*0x7ed1c64*/ bool get_richText();
        /*0x7ed1da8*/ nint GetStyleStatePtr(int idx);
        /*0x7ed1e8c*/ nint GetRectOffsetPtr(int idx);
        /*0x7ed1f70*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7ed20dc*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x7ed2218*/ UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize);
        /*0x7ed2334*/ float Internal_CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x7ed2438*/ UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content);
        /*0x7ed253c*/ UnityEngine.Vector2 Internal_GetTextRectOffset(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.Vector2 textSize);
        /*0x7ed281c*/ void Finalize();
        /*0x7ec8920*/ string get_name();
        /*0x7ecf860*/ void set_name(string value);
        /*0x7ed080c*/ UnityEngine.GUIStyleState get_normal();
        /*0x7ec9f54*/ UnityEngine.RectOffset get_margin();
        /*0x7ed2918*/ UnityEngine.RectOffset get_padding();
        /*0x7ed29b0*/ float get_lineHeight();
        /*0x7eca07c*/ void Draw(UnityEngine.Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7ec824c*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7ec7500*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x7ed2b88*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7ed2c6c*/ UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x7eceb1c*/ UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints);
        /*0x7ed2f40*/ float CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x7ed2f44*/ UnityEngine.Vector2 GetPreferredSize(string content, UnityEngine.Rect rect);
        /*0x7ece9fc*/ bool get_isHeightDependantOnWidth();
        /*0x7ed3040*/ void CalcMinMaxWidth(UnityEngine.GUIContent content, ref float minWidth, ref float maxWidth);
        /*0x7ed3068*/ string ToString();

        class BindingsMarshaller
        {
            static /*0x7ed36a8*/ nint ConvertToNative(UnityEngine.GUIStyle guiStyle);
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

        static /*0x7ed36c0*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
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

        static /*0x7ed5204*/ GUIUtility();
        static /*0x7ecda2c*/ float get_pixelsPerPoint();
        static /*0x7ed3850*/ void set_pixelsPerPoint(float value);
        static /*0x7ed3888*/ int get_guiDepth();
        static /*0x7ec5bd4*/ bool get_textFieldInput();
        static /*0x7ed38b0*/ string get_systemCopyBuffer();
        static /*0x7ed39d8*/ void set_systemCopyBuffer(string value);
        static /*0x7ed3ba0*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x7ec76b4*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x7ed3c90*/ void BeginContainerFromOwner(UnityEngine.ScriptableObject owner);
        static /*0x7ed3d6c*/ void BeginContainer(UnityEngine.ObjectGUIState objectGUIState);
        static /*0x7ed3e24*/ void Internal_EndContainer();
        static /*0x7ed3e4c*/ int CheckForTabEvent(UnityEngine.Event evt);
        static /*0x7ed3f04*/ void SetKeyboardControlToFirstControlId();
        static /*0x7ed3f2c*/ void SetKeyboardControlToLastControlId();
        static /*0x7ed3f54*/ bool HasFocusableControls();
        static /*0x7ed3f7c*/ bool OwnsId(int id);
        static /*0x7ed3fb8*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels);
        static /*0x7ed40c0*/ string get_compositionString();
        static /*0x7ed41e8*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x7ed4224*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x7ed42d8*/ int Internal_GetHotControl();
        static /*0x7ed4300*/ int Internal_GetKeyboardControl();
        static /*0x7ed4328*/ void Internal_SetHotControl(int value);
        static /*0x7ed4364*/ void Internal_SetKeyboardControl(int value);
        static /*0x7ed43a0*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x7ed43dc*/ void Internal_ExitGUI();
        static /*0x7ed4404*/ void MarkGUIChanged();
        static /*0x7ec7464*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x7ec9ef0*/ object GetStateObject(System.Type t, int controlID);
        static /*0x7ed4478*/ void set_guiIsExiting(bool value);
        static /*0x7ec7d3c*/ int get_hotControl();
        static /*0x7ec7cc8*/ void set_hotControl(int value);
        static /*0x7ed44d8*/ void TakeCapture();
        static /*0x7ed454c*/ void RemoveCapture();
        static /*0x7ec81e4*/ int get_keyboardControl();
        static /*0x7ed45c0*/ void set_keyboardControl(int value);
        static /*0x7ed2bac*/ bool HasKeyFocus(int controlID);
        static /*0x7ed4634*/ void ExitGUI();
        static /*0x7ec6a50*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x7ed4728*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x7ed4918*/ void EndContainer();
        static /*0x7ed49a0*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x7ed4b78*/ void DestroyGUI(int instanceID);
        static /*0x7ed4bd0*/ void EndGUI(int layoutType);
        static /*0x7ed4dd0*/ bool EndGUIFromException(System.Exception exception);
        static /*0x7ed4e98*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x7ed4a4c*/ void ResetGlobalState();
        static /*0x7ed4f38*/ bool IsExitGUIException(System.Exception exception);
        static /*0x7ed4e44*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x7ec6840*/ void CheckOnGUI();
        static /*0x7ed4fbc*/ float RoundToPixelGrid(float v);
        static /*0x7ed506c*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect);
        static /*0x7ed50f8*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x7ed5144*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x7ec8130*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt);
        static /*0x7ed399c*/ void get_systemCopyBuffer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ed3b64*/ void set_systemCopyBuffer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7ed3c3c*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x7ed3d30*/ void BeginContainerFromOwner_Injected(nint owner);
        static /*0x7ed3de8*/ void BeginContainer_Injected(nint objectGUIState);
        static /*0x7ed3ec8*/ int CheckForTabEvent_Injected(nint evt);
        static /*0x7ed4064*/ void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels, ref UnityEngine.Rect ret);
        static /*0x7ed41ac*/ void get_compositionString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ed429c*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class ExitGUIException : System.Exception
    {
        /*0x7ed4668*/ ExitGUIException();
        /*0x7ece5d0*/ ExitGUIException(string message);
    }

    class IMGUITextHandle : UnityEngine.TextCore.Text.TextHandle
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.IMGUITextHandle> textHandles;
        static /*0x8*/ System.Collections.Generic.LinkedList<UnityEngine.IMGUITextHandle.TextHandleTuple> textHandlesTuple;
        static /*0x10*/ float lastCleanupTime;
        static /*0x14*/ int newHandlesSinceCleanup;
        /*0xb0*/ System.Collections.Generic.LinkedListNode<UnityEngine.IMGUITextHandle.TextHandleTuple> tuple;
        /*0xb8*/ bool isCachedOnNative;

        static /*0x7ed5d1c*/ IMGUITextHandle();
        static /*0x7ed35b8*/ void EmptyManagedCache();
        static /*0x7ed2e14*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.GUIStyle style, UnityEngine.Rect position, string content, UnityEngine.Color32 textColor);
        static /*0x7ed33f4*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.GUIStyle style, UnityEngine.Rect position, string content, UnityEngine.Color32 textColor, ref bool isCached);
        static /*0x7ed5a30*/ bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold);
        static /*0x7ed5a4c*/ void ClearUnusedTextHandles();
        static /*0x7ed56b8*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.TextCore.Text.TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached);
        static /*0x7ed2a88*/ float GetLineHeight(UnityEngine.GUIStyle style);
        static /*0x7ed5280*/ void ConvertGUIStyleToGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.GUIStyle style, UnityEngine.Color textColor, string text, UnityEngine.Rect rect);
        static /*0x7ed5d04*/ UnityEngine.TextCore.Text.TextOverflowMode LegacyClippingToNewOverflow(UnityEngine.TextClipping clipping);
        /*0x7ed5c70*/ IMGUITextHandle();
        /*0x7ed3038*/ UnityEngine.Vector2 GetPreferredSize();

        class TextHandleTuple
        {
            /*0x10*/ float lastTimeUsed;
            /*0x14*/ int hashCode;

            /*0x7ed5ccc*/ TextHandleTuple(float lastTimeUsed, int hashCode);
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

        static /*0x7ed68c8*/ GUILayoutEntry();
        /*0x7ed5f2c*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x7eceb5c*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options);
        /*0x7ed5e1c*/ UnityEngine.GUIStyle get_style();
        /*0x7ecd9f8*/ void set_style(UnityEngine.GUIStyle value);
        /*0x7ed5e24*/ int get_marginLeft();
        /*0x7ed5e48*/ int get_marginRight();
        /*0x7ed5e6c*/ int get_marginTop();
        /*0x7ed5e90*/ int get_marginBottom();
        /*0x7ed5eb4*/ int get_marginHorizontal();
        /*0x7ed5ef0*/ int get_marginVertical();
        /*0x7ed601c*/ void CalcWidth();
        /*0x7ed6020*/ void CalcHeight();
        /*0x7ed6024*/ void SetHorizontal(float x, float width);
        /*0x7ed6030*/ void SetVertical(float y, float height);
        /*0x7ed603c*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x7ed60c0*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x7ed6360*/ string ToString();
    }

    class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ UnityEngine.GUIContent m_Content;
        /*0x50*/ float m_ForcedMinHeight;
        /*0x54*/ float m_ForcedMaxHeight;

        /*0x7ecea3c*/ GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options);
        /*0x7ed6924*/ void CalcWidth();
        /*0x7ed698c*/ void CalcHeight();
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

        static /*0x7ed8ba8*/ GUILayoutGroup();
        /*0x7ecd758*/ GUILayoutGroup();
        /*0x7ed69e8*/ int get_marginLeft();
        /*0x7ed69f0*/ int get_marginRight();
        /*0x7ed69f8*/ int get_marginTop();
        /*0x7ed6a00*/ int get_marginBottom();
        /*0x7ed6a08*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x7ed6b00*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x7ece120*/ void ResetCursor();
        /*0x7ece30c*/ UnityEngine.GUILayoutEntry GetNext();
        /*0x7ece260*/ void Add(UnityEngine.GUILayoutEntry e);
        /*0x7ed6b74*/ void CalcWidth();
        /*0x7ed71b8*/ void SetHorizontal(float x, float width);
        /*0x7ed79f4*/ void CalcHeight();
        /*0x7ed7f88*/ void SetVertical(float y, float height);
        /*0x7ed87d0*/ string ToString();
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

        /*0x7ed8c7c*/ GUIScrollGroup();
        /*0x7ed8cdc*/ void CalcWidth();
        /*0x7ed8d5c*/ void SetHorizontal(float x, float width);
        /*0x7ed8e3c*/ void CalcHeight();
        /*0x7ed8f18*/ void SetVertical(float y, float height);
    }

    class ObjectGUIState : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7ed90cc*/ nint Internal_Create();
        static /*0x7ed9298*/ void Internal_Destroy(nint ptr);
        /*0x7ed9084*/ ObjectGUIState();
        /*0x7ed90f4*/ void Dispose();
        /*0x7ed91d4*/ void Finalize();
        /*0x7ed9188*/ void Destroy();

        class BindingsMarshaller
        {
            static /*0x7ed92d4*/ nint ConvertToNative(UnityEngine.ObjectGUIState objectGUIState);
        }
    }

    class RuntimeTextSettings : UnityEngine.TextCore.Text.TextSettings
    {
        static /*0x0*/ UnityEngine.RuntimeTextSettings s_DefaultTextSettings;
        static /*0x8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> s_FallbackOSFontAssetIMGUIInternal;

        static /*0x7ed92ec*/ UnityEngine.RuntimeTextSettings get_defaultTextSettings();
        /*0x7ed9498*/ RuntimeTextSettings();
        /*0x7ed93b0*/ UnityEngine.Shader GetFontShader();
        /*0x7ed9400*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset();
        /*0x7ed9448*/ void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets);
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

        /*0x7ed94a0*/ ScrollViewState();
    }

    class SliderState
    {
        /*0x10*/ float dragStartPos;
        /*0x14*/ float dragStartValue;
        /*0x18*/ bool isDragging;

        /*0x7ed94a8*/ SliderState();
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

        /*0x7ed94b0*/ SliderHandler(UnityEngine.Rect position, float currentValue, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        /*0x7ed9520*/ float Handle();
        /*0x7ed95c8*/ float OnMouseDown();
        /*0x7ed99d4*/ float OnMouseDrag();
        /*0x7ed9af0*/ float OnMouseUp();
        /*0x7ed9b8c*/ float OnRepaint();
        /*0x7ed95a0*/ UnityEngine.EventType CurrentEventType();
        /*0x7eda2e0*/ int CurrentScrollTroughSide();
        /*0x7eda0fc*/ bool IsEmptySlider();
        /*0x7eda180*/ bool SupportsPageMovements();
        /*0x7eda344*/ float PageMovementValue();
        /*0x7eda5e8*/ float PageUpMovementBound();
        /*0x7eda0f4*/ UnityEngine.Event CurrentEvent();
        /*0x7eda3cc*/ float ValueForCurrentMousePosition();
        /*0x7eda440*/ float Clamp(float value);
        /*0x7eda0f0*/ UnityEngine.Rect ThumbSelectionRect();
        /*0x7eda138*/ void StartDraggingWithValue(float dragStartValue);
        /*0x7eda1f0*/ UnityEngine.SliderState SliderState();
        /*0x7eda560*/ UnityEngine.Rect ThumbExtRect();
        /*0x7eda5d8*/ UnityEngine.Rect ThumbRect();
        /*0x7eda650*/ UnityEngine.Rect VerticalThumbRect();
        /*0x7eda770*/ UnityEngine.Rect HorizontalThumbRect();
        /*0x7eda10c*/ float ClampedCurrentValue();
        /*0x7eda46c*/ float MousePosition();
        /*0x7eda4b8*/ float ValuesPerPixel();
        /*0x7eda890*/ float ThumbSize();
        /*0x7eda638*/ float MaxValue();
        /*0x7eda628*/ float MinValue();
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

        static /*0x7edd3fc*/ void MapKey(string key, UnityEngine.TextEditOp action);
        static /*0x7eddbf0*/ string ReplaceNewlinesWithSpaces(string value);
        /*0x7edadc4*/ TextEditingUtilities(UnityEngine.TextSelectingUtilities selectingUtilities, UnityEngine.TextCore.Text.TextHandle textHandle, string text);
        /*0x7eda924*/ bool get_hasSelection();
        /*0x7eda990*/ void set_revealCursor(bool value);
        /*0x7edaa08*/ int get_stringCursorIndex();
        /*0x7edaa3c*/ int get_cursorIndex();
        /*0x7edaaac*/ void set_cursorIndex(int value);
        /*0x7edab1c*/ int get_cursorIndexNoValidation();
        /*0x7edab40*/ void set_cursorIndexNoValidation(int value);
        /*0x7edabb0*/ void set_selectIndexNoValidation(int value);
        /*0x7edac20*/ int get_stringSelectIndex();
        /*0x7edac54*/ int get_selectIndex();
        /*0x7edacc4*/ void set_selectIndex(int value);
        /*0x7edad34*/ string get_text();
        /*0x7edad3c*/ void set_text(string value);
        /*0x7edadbc*/ void SetTextWithoutNotify(string value);
        /*0x7edae30*/ bool UpdateImeState();
        /*0x7edafe8*/ bool ShouldUpdateImeWindowPosition();
        /*0x7edaff0*/ void SetImeWindowPosition(UnityEngine.Vector2 worldPosition);
        /*0x7edb09c*/ string GeneratePreviewString(bool richText);
        /*0x7edb1dc*/ void EnableCursorPreviewState();
        /*0x7edb19c*/ void RestoreCursorState();
        /*0x7edb280*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x7edb9dc*/ void PerformOperation(UnityEngine.TextEditOp operation);
        /*0x7edb394*/ void InitKeyActions();
        /*0x7edd1bc*/ bool DeleteLineBack();
        /*0x7edd0d8*/ bool DeleteWordBack();
        /*0x7edd318*/ bool DeleteWordForward();
        /*0x7edcc6c*/ bool Delete();
        /*0x7edcd98*/ bool Backspace();
        /*0x7edd48c*/ bool DeleteSelection();
        /*0x7edaedc*/ void ReplaceSelection(string replace);
        /*0x7edd9d0*/ bool Insert(char c);
        /*0x7eddaf8*/ bool CanPaste();
        /*0x7edd004*/ bool Cut();
        /*0x7edd028*/ bool Paste();
        /*0x7eddc84*/ void OnBlur();
        /*0x7eddcf0*/ bool TouchScreenKeyboardShouldBeUsed();
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
        /*0x58*/ string m_TextWithWhitespace;
        /*0x60*/ UnityEngine.Rect <position>k__BackingField;
        /*0x70*/ UnityEngine.Vector2 graphicalCursorPos;
        /*0x78*/ UnityEngine.Vector2 lastCursorPos;
        /*0x80*/ UnityEngine.Vector2 previousContentSize;

        /*0x7ede0a8*/ TextEditor();
        /*0x7eddd74*/ bool get_showCursor();
        /*0x7eddd90*/ string get_text();
        /*0x7edddac*/ void set_text(string value);
        /*0x7ede02c*/ string get_textWithWhitespace();
        /*0x7edde6c*/ void set_textWithWhitespace(string value);
        /*0x7ede09c*/ UnityEngine.Rect get_position();
        /*0x7ede554*/ void OnTextChangedHandle();
        /*0x7ede594*/ void OnContentTextChangedHandle();
        /*0x7eddeec*/ void UpdateTextHandle();
        /*0x7ede5d4*/ void UpdateScrollOffset();
        /*0x7ede9c8*/ void OnCursorIndexChange();
        /*0x7ede9cc*/ void OnSelectIndexChange();

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

        static /*0x7edfedc*/ void MapKey(string key, UnityEngine.TextSelectOp action);
        /*0x7ede504*/ TextSelectingUtilities(UnityEngine.TextCore.Text.TextHandle textHandle);
        /*0x7eda960*/ bool get_hasSelection();
        /*0x7ede9d0*/ bool get_revealCursor();
        /*0x7eda9d8*/ void set_revealCursor(bool value);
        /*0x7ede9d8*/ int get_m_CharacterCount();
        /*0x7ede9f4*/ int get_characterCount();
        /*0x7edeac4*/ UnityEngine.TextCore.Text.TextElementInfo[] get_m_TextElementInfos();
        /*0x7edaa54*/ int get_cursorIndex();
        /*0x7edaaf0*/ void set_cursorIndex(int value);
        /*0x7edab38*/ int get_cursorIndexNoValidation();
        /*0x7edab84*/ void set_cursorIndexNoValidation(int value);
        /*0x7edeb10*/ void SetCursorIndexWithoutNotify(int index);
        /*0x7edac6c*/ int get_selectIndex();
        /*0x7edad08*/ void set_selectIndex(int value);
        /*0x7edabf4*/ void set_selectIndexNoValidation(int value);
        /*0x7edeb18*/ void SetSelectIndexWithoutNotify(int index);
        /*0x7edeb20*/ string get_selectedText();
        /*0x7edec14*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x7edf134*/ bool PerformOperation(UnityEngine.TextSelectOp operation);
        /*0x7eded20*/ void InitKeyActions();
        /*0x7edd9c0*/ void ClearCursorPos();
        /*0x7edff6c*/ void OnFocus(bool selectAll);
        /*0x7edfe70*/ void SelectAll();
        /*0x7eddca8*/ void SelectNone();
        /*0x7edf324*/ void SelectLeft();
        /*0x7edf40c*/ void SelectRight();
        /*0x7edf4f4*/ void SelectUp();
        /*0x7edf55c*/ void SelectDown();
        /*0x7edf8cc*/ void SelectTextEnd();
        /*0x7edf8a4*/ void SelectTextStart();
        /*0x7edf84c*/ void SelectToStartOfNextWord();
        /*0x7edf7f4*/ void SelectToEndOfPreviousWord();
        /*0x7edf5c4*/ void SelectWordRight();
        /*0x7edf6dc*/ void SelectWordLeft();
        /*0x7edfdc0*/ void SelectGraphicalLineStart();
        /*0x7edfe18*/ void SelectGraphicalLineEnd();
        /*0x7edfac4*/ void SelectParagraphForward();
        /*0x7edfc24*/ void SelectParagraphBackward();
        /*0x7ee0220*/ void SelectCurrentWord();
        /*0x7ee0558*/ void SelectCurrentParagraph();
        /*0x7edbdd0*/ void MoveRight();
        /*0x7edbce4*/ void MoveLeft();
        /*0x7edbec4*/ void MoveUp();
        /*0x7edbfdc*/ void MoveDown();
        /*0x7edc100*/ void MoveLineStart();
        /*0x7edc22c*/ void MoveLineEnd();
        /*0x7edcb04*/ void MoveGraphicalLineStart();
        /*0x7edcbb8*/ void MoveGraphicalLineEnd();
        /*0x7edc6f8*/ void MoveTextStart();
        /*0x7edc754*/ void MoveTextEnd();
        /*0x7edc7cc*/ void MoveParagraphForward();
        /*0x7edc948*/ void MoveParagraphBackward();
        /*0x7edc370*/ void MoveWordRight();
        /*0x7edc478*/ void MoveToStartOfNextWord();
        /*0x7edc534*/ void MoveToEndOfPreviousWord();
        /*0x7edc5f0*/ void MoveWordLeft();
        /*0x7ee07d8*/ void MouseDragSelectsWholeWords(bool on);
        /*0x7edf90c*/ void ExpandSelectGraphicalLineStart();
        /*0x7edf9e8*/ void ExpandSelectGraphicalLineEnd();
        /*0x7ee085c*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x7ee0864*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x7ee08fc*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x7ee06b8*/ int FindNextSeperator(int startPos);
        /*0x7ee073c*/ int FindPrevSeperator(int startPos);
        /*0x7edd768*/ int FindStartOfNextWord(int p);
        /*0x7edd658*/ int FindEndOfPreviousWord(int p);
        /*0x7ee0418*/ int FindEndOfClassification(int p, UnityEngine.TextSelectingUtilities.Direction dir);
        /*0x7edeaec*/ int ClampTextIndex(int index);
        /*0x7ee01e0*/ int IndexOfEndOfLine(int startIndex);
        /*0x7edd964*/ int PreviousCodePointIndex(int index);
        /*0x7edffb8*/ int NextCodePointIndex(int index);
        /*0x7ee0018*/ int GetGraphicalLineStart(int p);
        /*0x7ee00f8*/ int GetGraphicalLineEnd(int p);
        /*0x7eddb60*/ void Copy();
        /*0x7ee0e04*/ UnityEngine.TextSelectingUtilities.CharacterType ClassifyChar(int index);

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
    static /*0x7ee0eec*/ uint ComputeStringHash(string s);
}
