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

        static /*0x7edaa9c*/ nint Internal_Create(int displayIndex);
        static /*0x7edaad8*/ void Internal_Destroy(nint ptr);
        static /*0x7edac4c*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x7edad24*/ void GetEventAtIndex(int index, UnityEngine.Event outEvent);
        static /*0x7edae0c*/ int GetEventCount();
        static /*0x7edae34*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x7edae70*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x7edaf9c*/ int GetDoubleClickTime();
        static /*0x7edb18c*/ UnityEngine.Event get_current();
        static /*0x7edb1d4*/ void set_current(UnityEngine.Event value);
        static /*0x7edb2bc*/ UnityEngine.Event KeyboardEvent(string key);
        static /*0x7ed99d0*/ UnityEngine.EventType get_rawType_Injected(nint _unity_self);
        static /*0x7ed9a6c*/ void get_mousePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ed9b0c*/ void set_mousePosition_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7ed9bb0*/ void get_delta_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ed9c50*/ void set_delta_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7ed9ce4*/ UnityEngine.PointerType get_pointerType_Injected(nint _unity_self);
        static /*0x7ed9d70*/ int get_button_Injected(nint _unity_self);
        static /*0x7ed9dfc*/ UnityEngine.EventModifiers get_modifiers_Injected(nint _unity_self);
        static /*0x7ed9e90*/ void set_modifiers_Injected(nint _unity_self, UnityEngine.EventModifiers value);
        static /*0x7ed9f24*/ float get_pressure_Injected(nint _unity_self);
        static /*0x7ed9fb0*/ float get_twist_Injected(nint _unity_self);
        static /*0x7eda04c*/ void get_tilt_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7eda0e0*/ UnityEngine.PenStatus get_penStatus_Injected(nint _unity_self);
        static /*0x7eda16c*/ int get_clickCount_Injected(nint _unity_self);
        static /*0x7eda1f8*/ char get_character_Injected(nint _unity_self);
        static /*0x7eda28c*/ void set_character_Injected(nint _unity_self, char value);
        static /*0x7eda320*/ UnityEngine.KeyCode get_Internal_keyCode_Injected(nint _unity_self);
        static /*0x7eda3b4*/ void set_Internal_keyCode_Injected(nint _unity_self, UnityEngine.KeyCode value);
        static /*0x7eda51c*/ int get_displayIndex_Injected(nint _unity_self);
        static /*0x7eda5b0*/ void set_displayIndex_Injected(nint _unity_self, int value);
        static /*0x7eda644*/ UnityEngine.EventType get_type_Injected(nint _unity_self);
        static /*0x7eda6d8*/ void set_type_Injected(nint _unity_self, UnityEngine.EventType value);
        static /*0x7eda7f8*/ void get_commandName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7eda9cc*/ void set_commandName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7edaa60*/ void Internal_Use_Injected(nint _unity_self);
        static /*0x7edab6c*/ UnityEngine.EventType GetTypeForControl_Injected(nint _unity_self, int controlID);
        static /*0x7edac08*/ void CopyFromPtr_Injected(nint _unity_self, nint ptr);
        static /*0x7edace8*/ bool PopEvent_Injected(nint outEvent);
        static /*0x7edadc8*/ void GetEventAtIndex_Injected(int index, nint outEvent);
        /*0x7edafc4*/ Event();
        /*0x7edaf4c*/ Event(int displayIndex);
        /*0x7ed9980*/ UnityEngine.EventType get_rawType();
        /*0x7ed9a0c*/ UnityEngine.Vector2 get_mousePosition();
        /*0x7ed9ab0*/ void set_mousePosition(UnityEngine.Vector2 value);
        /*0x7ed9b50*/ UnityEngine.Vector2 get_delta();
        /*0x7ed9bf4*/ void set_delta(UnityEngine.Vector2 value);
        /*0x7ed9c94*/ UnityEngine.PointerType get_pointerType();
        /*0x7ed9d20*/ int get_button();
        /*0x7ed9dac*/ UnityEngine.EventModifiers get_modifiers();
        /*0x7ed9e38*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x7ed9ed4*/ float get_pressure();
        /*0x7ed9f60*/ float get_twist();
        /*0x7ed9fec*/ UnityEngine.Vector2 get_tilt();
        /*0x7eda090*/ UnityEngine.PenStatus get_penStatus();
        /*0x7eda11c*/ int get_clickCount();
        /*0x7eda1a8*/ char get_character();
        /*0x7eda234*/ void set_character(char value);
        /*0x7eda2d0*/ UnityEngine.KeyCode get_Internal_keyCode();
        /*0x7eda35c*/ void set_Internal_keyCode(UnityEngine.KeyCode value);
        /*0x7eda3f8*/ UnityEngine.KeyCode get_keyCode();
        /*0x7eda4c8*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x7eda4cc*/ int get_displayIndex();
        /*0x7eda558*/ void set_displayIndex(int value);
        /*0x7eda5f4*/ UnityEngine.EventType get_type();
        /*0x7eda680*/ void set_type(UnityEngine.EventType value);
        /*0x7eda71c*/ string get_commandName();
        /*0x7eda83c*/ void set_commandName(string value);
        /*0x7edaa10*/ void Internal_Use();
        /*0x7edab14*/ UnityEngine.EventType GetTypeForControl(int controlID);
        /*0x7edabb0*/ void CopyFromPtr(nint ptr);
        /*0x7edb010*/ void Finalize();
        /*0x7edb0d4*/ void CopyFrom(UnityEngine.Event e);
        /*0x7edb100*/ bool get_shift();
        /*0x7edb114*/ bool get_control();
        /*0x7edb128*/ bool get_alt();
        /*0x7edb13c*/ bool get_command();
        /*0x7edb150*/ bool get_capsLock();
        /*0x7edb164*/ bool get_numeric();
        /*0x7edb178*/ bool get_functionKey();
        /*0x7edb26c*/ bool get_isKey();
        /*0x7eda47c*/ bool get_isMouse();
        /*0x7eda4b0*/ bool get_isScrollWheel();
        /*0x7edb288*/ bool get_isDirectManipulationDevice();
        /*0x7edc438*/ int GetHashCode();
        /*0x7edc4ec*/ bool Equals(object obj);
        /*0x7edc698*/ string ToString();
        /*0x7edcd50*/ void Use();

        class BindingsMarshaller
        {
            static /*0x7edceb0*/ nint ConvertToNative(UnityEngine.Event e);
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

        /*0x7edcec8*/ bool get_wantsMouseMove();
        /*0x7edced0*/ void set_wantsMouseMove(bool value);
        /*0x7edcedc*/ bool get_wantsMouseEnterLeaveWindow();
        /*0x7edcee4*/ void set_wantsMouseEnterLeaveWindow(bool value);
        /*0x7edcef0*/ bool get_wantsLessLayoutEvents();
        /*0x7edcef8*/ bool WantsEvent(UnityEngine.EventType type);
        /*0x7edcf28*/ bool WantsLayoutPass(UnityEngine.EventType type);
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

        static /*0x7edd7f4*/ GUI();
        static /*0x7edd02c*/ UnityEngine.Color get_color();
        static /*0x7edd0f0*/ void set_color(UnityEngine.Color value);
        static /*0x7edd1b0*/ UnityEngine.Color get_backgroundColor();
        static /*0x7edd274*/ void set_backgroundColor(UnityEngine.Color value);
        static /*0x7edd334*/ UnityEngine.Color get_contentColor();
        static /*0x7edd3f8*/ void set_contentColor(UnityEngine.Color value);
        static /*0x7edd4b8*/ bool get_changed();
        static /*0x7edd4e0*/ void set_changed(bool value);
        static /*0x7edd51c*/ bool get_enabled();
        static /*0x7edd544*/ void set_enabled(bool value);
        static /*0x7edd580*/ bool get_usePageScrollbars();
        static /*0x7edd5a8*/ void GrabMouseControl(int id);
        static /*0x7edd5e4*/ bool HasMouseControl(int id);
        static /*0x7edd620*/ void ReleaseMouseControl();
        static /*0x7edd648*/ void InternalRepaintEditorWindow();
        static /*0x7edd670*/ UnityEngine.Rect Internal_DoWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout);
        static /*0x7edda8c*/ int get_scrollTroughSide();
        static /*0x7eddae4*/ void set_scrollTroughSide(int value);
        static /*0x7eddb40*/ System.DateTime get_nextScrollStepTime();
        static /*0x7eddb98*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x7eddbf4*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x7edde00*/ UnityEngine.GUISkin get_skin();
        static /*0x7eddd30*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x7eddfe0*/ UnityEngine.Matrix4x4 get_matrix();
        static /*0x7ede0b8*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x7ede140*/ void Label(UnityEngine.Rect position, string text);
        static /*0x7ede2d8*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ede620*/ void Box(UnityEngine.Rect position, string text);
        static /*0x7ede6f8*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7edea00*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7edeb8c*/ bool Button(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7eded60*/ bool DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType);
        static /*0x7edf1d4*/ bool DoControl(UnityEngine.Rect position, int id, bool on, bool hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7ede394*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7edec50*/ bool DoButton(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x7edfa14*/ float Slider(UnityEngine.Rect position, float value, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        static /*0x7edfbb4*/ float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style);
        static /*0x7ee0378*/ bool ScrollerRepeatButton(int scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style);
        static /*0x7ee0628*/ float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style);
        static /*0x7edffdc*/ float Scroller(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, bool horiz);
        static /*0x7ee08e4*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x7ee093c*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background);
        static /*0x7ee1574*/ void EndScrollView(bool handleScrollWheel);
        static /*0x7ee20a0*/ UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text);
        static /*0x7ee21c0*/ UnityEngine.Rect DoWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, bool forceRectOnLayout);
        static /*0x7ee22bc*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x7edd0b4*/ void get_color_Injected(ref UnityEngine.Color ret);
        static /*0x7edd174*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x7edd238*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x7edd2f8*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        static /*0x7edd3bc*/ void get_contentColor_Injected(ref UnityEngine.Color ret);
        static /*0x7edd47c*/ void set_contentColor_Injected(ref UnityEngine.Color value);
        static /*0x7edd758*/ void Internal_DoWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout, ref UnityEngine.Rect ret);

        class WindowFunction : System.MulticastDelegate
        {
            /*0x7ee2cd8*/ WindowFunction(object object, nint method);
            /*0x7ee2d78*/ void Invoke(int id);
        }
    }

    class GUIClip
    {
        static /*0x7edf698*/ UnityEngine.Rect get_visibleRect();
        static /*0x7ee2dc8*/ void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x7ee2e88*/ void Internal_Pop();
        static /*0x7ee2eb0*/ int Internal_GetCount();
        static /*0x7ede054*/ UnityEngine.Matrix4x4 GetMatrix();
        static /*0x7ede104*/ void SetMatrix(UnityEngine.Matrix4x4 m);
        static /*0x7ee2f50*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
        static /*0x7ee2f90*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect);
        static /*0x7ee3040*/ void Internal_PopParentClip();
        static /*0x7ee156c*/ void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x7ee2078*/ void Pop();
        static /*0x7ee2d8c*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x7ee2e2c*/ void Internal_Push_Injected(ref UnityEngine.Rect screenRect, ref UnityEngine.Vector2 scrollOffset, ref UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x7ee2ed8*/ void GetMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        static /*0x7ee2f14*/ void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x7ee2fec*/ void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect);

        struct ParentClipScope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x7ee3068*/ ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
            /*0x7ee30bc*/ void Dispose();
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

        static /*0x7ee3750*/ GUIContent();
        static /*0x7ede210*/ UnityEngine.GUIContent Temp(string t);
        static /*0x7ee35d0*/ void ClearStaticCache();
        /*0x7ee33d4*/ GUIContent();
        /*0x7ee3440*/ GUIContent(string text);
        /*0x7ee3514*/ GUIContent(string text, string tooltip);
        /*0x7ee345c*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x7ee3520*/ GUIContent(UnityEngine.GUIContent src);
        /*0x7ee30fc*/ void add_OnTextChanged(System.Action value);
        /*0x7ee3198*/ void remove_OnTextChanged(System.Action value);
        /*0x7ee3234*/ string get_text();
        /*0x7ee323c*/ void set_text(string value);
        /*0x7ee3328*/ string get_textWithWhitespace();
        /*0x7ee32a8*/ void set_textWithWhitespace(string value);
        /*0x7ee3398*/ void SetTextWithoutNotify(string value);
        /*0x7ee33c4*/ void set_image(UnityEngine.Texture value);
        /*0x7edf690*/ string get_tooltip();
        /*0x7ee33cc*/ void set_tooltip(string value);
        /*0x7ee3730*/ string ToString();
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
        static /*0x7ee3880*/ void Label(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee3928*/ void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee3a60*/ bool Button(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee3b10*/ bool DoButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee3bdc*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee4174*/ void EndScrollView();
        static /*0x7ee417c*/ void EndScrollView(bool handleScrollWheel);
        static /*0x7ee26c4*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x7ee2760*/ UnityEngine.GUILayoutOption Height(float height);
    }

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x7ee447c*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

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

        static /*0x7ee607c*/ GUILayoutUtility();
        static /*0x7ee44b4*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x7ee4588*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x7ee4658*/ int get_unbalancedgroupscount();
        static /*0x7ee46b0*/ void set_unbalancedgroupscount(int value);
        static /*0x7ee470c*/ UnityEngine.GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow);
        static /*0x7ee2554*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x7ee48b4*/ void RemoveSelectedIdList(int instanceID, bool isWindow);
        static /*0x7ee4988*/ void Begin(int instanceID);
        static /*0x7ee4ca4*/ void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache);
        static /*0x7ee2800*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee2abc*/ void Layout();
        static /*0x7ee51b8*/ void LayoutFromEditorWindow();
        static /*0x7ee53c8*/ void LayoutFromContainer(float w, float h);
        static /*0x7ee4e84*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x7ee5040*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x7ee5558*/ UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType);
        static /*0x7ee3e4c*/ UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType);
        static /*0x7ee41f8*/ void EndLayoutGroup();
        static /*0x7ee39f4*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee5ad0*/ UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x7ee4544*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x7ee4614*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x7ee47b4*/ LayoutCache(int instanceID);
            /*0x7ee6190*/ void set_id(int value);
            /*0x7ee6198*/ void ResetCursor();
        }
    }

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        /*0x7ee6474*/ GUISettings();
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

        static /*0x7ee65f8*/ void CleanupRoots();
        static /*0x7ee6b28*/ UnityEngine.GUIStyle get_error();
        /*0x7ee64a0*/ GUISkin();
        /*0x7ee6578*/ void OnEnable();
        /*0x7ee6660*/ UnityEngine.Font get_font();
        /*0x7ee6668*/ void set_font(UnityEngine.Font value);
        /*0x7ede6f0*/ UnityEngine.GUIStyle get_box();
        /*0x7ee67e0*/ void set_box(UnityEngine.GUIStyle value);
        /*0x7ede2d0*/ UnityEngine.GUIStyle get_label();
        /*0x7ee67fc*/ void set_label(UnityEngine.GUIStyle value);
        /*0x7ee6818*/ UnityEngine.GUIStyle get_textField();
        /*0x7ee6820*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x7ee683c*/ UnityEngine.GUIStyle get_textArea();
        /*0x7ee6844*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x7ee3b08*/ UnityEngine.GUIStyle get_button();
        /*0x7ee6860*/ void set_button(UnityEngine.GUIStyle value);
        /*0x7ee687c*/ UnityEngine.GUIStyle get_toggle();
        /*0x7ee6884*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x7ee21b8*/ UnityEngine.GUIStyle get_window();
        /*0x7ee68a0*/ void set_window(UnityEngine.GUIStyle value);
        /*0x7ee68bc*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x7ee68c4*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x7ee68e0*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x7ee68e8*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x7ee6904*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x7ee690c*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x7ee6928*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x7ee6930*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x7ee694c*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x7ee6954*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x7ee6970*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x7ee6978*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x7ee6994*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x7ee699c*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x7ee69b8*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x7ee69c0*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x7ee69dc*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x7ee69e4*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x7ee6a00*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x7ee6a08*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x7ee6a24*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x7ee6a2c*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x7ee6a48*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x7ee6a50*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x7ee6a6c*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x7ee6a74*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x7ee6a90*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x7ee6a98*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x7ee6ab4*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x7ee6abc*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x7ee6ad8*/ UnityEngine.GUIStyle get_scrollView();
        /*0x7ee6ae0*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x7ee6afc*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x7ee6b04*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x7ee6b20*/ UnityEngine.GUISettings get_settings();
        /*0x7ee657c*/ void Apply();
        /*0x7ee6cbc*/ void BuildStyleCache();
        /*0x7edfd90*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x7ee7cf4*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x7eddf28*/ void MakeCurrent();
        /*0x7ee7d7c*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0x7ee7e3c*/ SkinChangedDelegate(object object, nint method);
            /*0x7ee7ed8*/ void Invoke();
        }
    }

    class GUIStateObjects
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, object> s_StateCache;

        static /*0x7ee8028*/ GUIStateObjects();
        static /*0x7ee7eec*/ object GetStateObject(System.Type t, int controlID);
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x7ee8104*/ nint Init();
        static /*0x7ee823c*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        static /*0x7ee80c0*/ void set_textColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7ee817c*/ void Cleanup_Injected(nint _unity_self);
        /*0x7ee81b8*/ GUIStyleState();
        /*0x7ee8200*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x7ee7c8c*/ void set_textColor(UnityEngine.Color value);
        /*0x7ee812c*/ void Cleanup();
        /*0x7ee82b4*/ void Finalize();

        class BindingsMarshaller
        {
            static /*0x7ee8358*/ nint ConvertToNative(UnityEngine.GUIStyleState guiStyleState);
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

        static /*0x7eeaa8c*/ GUIStyle();
        static /*0x7ee9160*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x7ee919c*/ void Internal_Destroy(nint self);
        static /*0x7edf87c*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x7edf6e0*/ bool IsTooltipActive(string tooltip);
        static /*0x7ee6740*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x7ee9b60*/ UnityEngine.Font GetDefaultFont();
        static /*0x7ee9c10*/ void Internal_DestroyTextGenerator(int meshInfoId);
        static /*0x7ee141c*/ UnityEngine.GUIStyle get_none();
        static /*0x7eea55c*/ void GetMeshInfo(UnityEngine.GUIStyle style, UnityEngine.Color color, string content, UnityEngine.Rect rect, ref UnityEngine.TextCore.Text.MeshInfoBindings[] meshInfos, ref UnityEngine.Vector2 dimensions, ref int generationId);
        static /*0x7eea94c*/ void GetDimensions(UnityEngine.GUIStyle style, UnityEngine.Color color, string content, UnityEngine.Rect rect, ref UnityEngine.Vector2 dimensions);
        static /*0x7eea97c*/ void GetLineHeight(UnityEngine.GUIStyle style, ref float lineHeight);
        static /*0x7eea99c*/ void EmptyManagedCache();
        static /*0x7ee8484*/ void get_rawName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7ee867c*/ void set_rawName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7ee876c*/ nint get_font_Injected(nint _unity_self);
        static /*0x7ee8838*/ UnityEngine.ImagePosition get_imagePosition_Injected(nint _unity_self);
        static /*0x7ee8904*/ UnityEngine.TextAnchor get_alignment_Injected(nint _unity_self);
        static /*0x7ee89e0*/ void set_alignment_Injected(nint _unity_self, UnityEngine.TextAnchor value);
        static /*0x7ee8ab4*/ bool get_wordWrap_Injected(nint _unity_self);
        static /*0x7ee8b80*/ UnityEngine.TextClipping get_clipping_Injected(nint _unity_self);
        static /*0x7ee8c64*/ void get_contentOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7ee8ca8*/ float get_fixedWidth_Injected(nint _unity_self);
        static /*0x7ee8ce4*/ float get_fixedHeight_Injected(nint _unity_self);
        static /*0x7ee8db0*/ bool get_stretchWidth_Injected(nint _unity_self);
        static /*0x7ee8e7c*/ bool get_stretchHeight_Injected(nint _unity_self);
        static /*0x7ee8eb8*/ void set_stretchHeight_Injected(nint _unity_self, bool value);
        static /*0x7ee8f8c*/ int get_fontSize_Injected(nint _unity_self);
        static /*0x7ee9058*/ UnityEngine.FontStyle get_fontStyle_Injected(nint _unity_self);
        static /*0x7ee9124*/ bool get_richText_Injected(nint _unity_self);
        static /*0x7ee9278*/ nint GetStyleStatePtr_Injected(nint _unity_self, int idx);
        static /*0x7ee935c*/ nint GetRectOffsetPtr_Injected(nint _unity_self, int idx);
        static /*0x7ee9488*/ void Internal_Draw_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        static /*0x7ee95dc*/ void Internal_Draw2_Injected(nint _unity_self, ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        static /*0x7ee9708*/ void Internal_CalcSizeWithConstraints_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, ref UnityEngine.Vector2 ret);
        static /*0x7ee9814*/ float Internal_CalcHeight_Injected(nint _unity_self, UnityEngine.GUIContent content, float width);
        static /*0x7ee9918*/ void Internal_CalcMinMaxWidth_Injected(nint _unity_self, UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        static /*0x7ee9a38*/ void Internal_GetTextRectOffset_Injected(nint _unity_self, ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, ref UnityEngine.Vector2 textSize, ref UnityEngine.Vector2 ret);
        static /*0x7ee9aa4*/ void SetMouseTooltip_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tooltip, ref UnityEngine.Rect screenRect);
        static /*0x7ee9ae8*/ bool IsTooltipActive_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tooltip);
        static /*0x7ee9b24*/ void SetDefaultFont_Injected(nint font);
        static /*0x7ee9be8*/ nint GetDefaultFont_Injected();
        /*0x7ee6c08*/ GUIStyle();
        /*0x7ee8370*/ string get_rawName();
        /*0x7ee84c8*/ void set_rawName(string value);
        /*0x7ee86c0*/ UnityEngine.Font get_font();
        /*0x7ee87a8*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x7ee8874*/ UnityEngine.TextAnchor get_alignment();
        /*0x7ee8940*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x7ee8a24*/ bool get_wordWrap();
        /*0x7ee8af0*/ UnityEngine.TextClipping get_clipping();
        /*0x7ee8bbc*/ UnityEngine.Vector2 get_contentOffset();
        /*0x7ee07c4*/ float get_fixedWidth();
        /*0x7ee0854*/ float get_fixedHeight();
        /*0x7ee8d20*/ bool get_stretchWidth();
        /*0x7ee8dec*/ bool get_stretchHeight();
        /*0x7ee7b9c*/ void set_stretchHeight(bool value);
        /*0x7ee8efc*/ int get_fontSize();
        /*0x7ee8fc8*/ UnityEngine.FontStyle get_fontStyle();
        /*0x7ee9094*/ bool get_richText();
        /*0x7ee91d8*/ nint GetStyleStatePtr(int idx);
        /*0x7ee92bc*/ nint GetRectOffsetPtr(int idx);
        /*0x7ee93a0*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7ee950c*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x7ee9648*/ UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize);
        /*0x7ee9764*/ float Internal_CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x7ee9868*/ UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content);
        /*0x7ee996c*/ UnityEngine.Vector2 Internal_GetTextRectOffset(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.Vector2 textSize);
        /*0x7ee9c4c*/ void Finalize();
        /*0x7edfd50*/ string get_name();
        /*0x7ee6c90*/ void set_name(string value);
        /*0x7ee7c3c*/ UnityEngine.GUIStyleState get_normal();
        /*0x7ee1384*/ UnityEngine.RectOffset get_margin();
        /*0x7ee9d48*/ UnityEngine.RectOffset get_padding();
        /*0x7ee9de0*/ float get_lineHeight();
        /*0x7ee14ac*/ void Draw(UnityEngine.Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7edf67c*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7ede930*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x7ee9fb8*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x7eea09c*/ UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x7ee5f4c*/ UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints);
        /*0x7eea370*/ float CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x7eea374*/ UnityEngine.Vector2 GetPreferredSize(string content, UnityEngine.Rect rect);
        /*0x7ee5e2c*/ bool get_isHeightDependantOnWidth();
        /*0x7eea470*/ void CalcMinMaxWidth(UnityEngine.GUIContent content, ref float minWidth, ref float maxWidth);
        /*0x7eea498*/ string ToString();

        class BindingsMarshaller
        {
            static /*0x7eeaad8*/ nint ConvertToNative(UnityEngine.GUIStyle guiStyle);
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

        static /*0x7eeaaf0*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
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

        static /*0x7eec634*/ GUIUtility();
        static /*0x7ee4e5c*/ float get_pixelsPerPoint();
        static /*0x7eeac80*/ void set_pixelsPerPoint(float value);
        static /*0x7eeacb8*/ int get_guiDepth();
        static /*0x7edd004*/ bool get_textFieldInput();
        static /*0x7eeace0*/ string get_systemCopyBuffer();
        static /*0x7eeae08*/ void set_systemCopyBuffer(string value);
        static /*0x7eeafd0*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x7edeae4*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x7eeb0c0*/ void BeginContainerFromOwner(UnityEngine.ScriptableObject owner);
        static /*0x7eeb19c*/ void BeginContainer(UnityEngine.ObjectGUIState objectGUIState);
        static /*0x7eeb254*/ void Internal_EndContainer();
        static /*0x7eeb27c*/ int CheckForTabEvent(UnityEngine.Event evt);
        static /*0x7eeb334*/ void SetKeyboardControlToFirstControlId();
        static /*0x7eeb35c*/ void SetKeyboardControlToLastControlId();
        static /*0x7eeb384*/ bool HasFocusableControls();
        static /*0x7eeb3ac*/ bool OwnsId(int id);
        static /*0x7eeb3e8*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels);
        static /*0x7eeb4f0*/ string get_compositionString();
        static /*0x7eeb618*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x7eeb654*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x7eeb708*/ int Internal_GetHotControl();
        static /*0x7eeb730*/ int Internal_GetKeyboardControl();
        static /*0x7eeb758*/ void Internal_SetHotControl(int value);
        static /*0x7eeb794*/ void Internal_SetKeyboardControl(int value);
        static /*0x7eeb7d0*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x7eeb80c*/ void Internal_ExitGUI();
        static /*0x7eeb834*/ void MarkGUIChanged();
        static /*0x7ede894*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x7ee1320*/ object GetStateObject(System.Type t, int controlID);
        static /*0x7eeb8a8*/ void set_guiIsExiting(bool value);
        static /*0x7edf16c*/ int get_hotControl();
        static /*0x7edf0f8*/ void set_hotControl(int value);
        static /*0x7eeb908*/ void TakeCapture();
        static /*0x7eeb97c*/ void RemoveCapture();
        static /*0x7edf614*/ int get_keyboardControl();
        static /*0x7eeb9f0*/ void set_keyboardControl(int value);
        static /*0x7ee9fdc*/ bool HasKeyFocus(int controlID);
        static /*0x7eeba64*/ void ExitGUI();
        static /*0x7edde80*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x7eebb58*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x7eebd48*/ void EndContainer();
        static /*0x7eebdd0*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x7eebfa8*/ void DestroyGUI(int instanceID);
        static /*0x7eec000*/ void EndGUI(int layoutType);
        static /*0x7eec200*/ bool EndGUIFromException(System.Exception exception);
        static /*0x7eec2c8*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x7eebe7c*/ void ResetGlobalState();
        static /*0x7eec368*/ bool IsExitGUIException(System.Exception exception);
        static /*0x7eec274*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x7eddc70*/ void CheckOnGUI();
        static /*0x7eec3ec*/ float RoundToPixelGrid(float v);
        static /*0x7eec49c*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect);
        static /*0x7eec528*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x7eec574*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x7edf560*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt);
        static /*0x7eeadcc*/ void get_systemCopyBuffer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7eeaf94*/ void set_systemCopyBuffer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7eeb06c*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x7eeb160*/ void BeginContainerFromOwner_Injected(nint owner);
        static /*0x7eeb218*/ void BeginContainer_Injected(nint objectGUIState);
        static /*0x7eeb2f8*/ int CheckForTabEvent_Injected(nint evt);
        static /*0x7eeb494*/ void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels, ref UnityEngine.Rect ret);
        static /*0x7eeb5dc*/ void get_compositionString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7eeb6cc*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class ExitGUIException : System.Exception
    {
        /*0x7eeba98*/ ExitGUIException();
        /*0x7ee5a00*/ ExitGUIException(string message);
    }

    class IMGUITextHandle : UnityEngine.TextCore.Text.TextHandle
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.IMGUITextHandle> textHandles;
        static /*0x8*/ System.Collections.Generic.LinkedList<UnityEngine.IMGUITextHandle.TextHandleTuple> textHandlesTuple;
        static /*0x10*/ float lastCleanupTime;
        static /*0x14*/ int newHandlesSinceCleanup;
        /*0xb0*/ System.Collections.Generic.LinkedListNode<UnityEngine.IMGUITextHandle.TextHandleTuple> tuple;
        /*0xb8*/ bool isCachedOnNative;

        static /*0x7eed14c*/ IMGUITextHandle();
        static /*0x7eea9e8*/ void EmptyManagedCache();
        static /*0x7eea244*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.GUIStyle style, UnityEngine.Rect position, string content, UnityEngine.Color32 textColor);
        static /*0x7eea824*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.GUIStyle style, UnityEngine.Rect position, string content, UnityEngine.Color32 textColor, ref bool isCached);
        static /*0x7eece60*/ bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold);
        static /*0x7eece7c*/ void ClearUnusedTextHandles();
        static /*0x7eecae8*/ UnityEngine.IMGUITextHandle GetTextHandle(UnityEngine.TextCore.Text.TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached);
        static /*0x7ee9eb8*/ float GetLineHeight(UnityEngine.GUIStyle style);
        static /*0x7eec6b0*/ void ConvertGUIStyleToGenerationSettings(UnityEngine.TextCore.Text.TextGenerationSettings settings, UnityEngine.GUIStyle style, UnityEngine.Color textColor, string text, UnityEngine.Rect rect);
        static /*0x7eed134*/ UnityEngine.TextCore.Text.TextOverflowMode LegacyClippingToNewOverflow(UnityEngine.TextClipping clipping);
        /*0x7eed0a0*/ IMGUITextHandle();
        /*0x7eea468*/ UnityEngine.Vector2 GetPreferredSize();

        class TextHandleTuple
        {
            /*0x10*/ float lastTimeUsed;
            /*0x14*/ int hashCode;

            /*0x7eed0fc*/ TextHandleTuple(float lastTimeUsed, int hashCode);
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

        static /*0x7eedcf8*/ GUILayoutEntry();
        /*0x7eed35c*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x7ee5f8c*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options);
        /*0x7eed24c*/ UnityEngine.GUIStyle get_style();
        /*0x7ee4e28*/ void set_style(UnityEngine.GUIStyle value);
        /*0x7eed254*/ int get_marginLeft();
        /*0x7eed278*/ int get_marginRight();
        /*0x7eed29c*/ int get_marginTop();
        /*0x7eed2c0*/ int get_marginBottom();
        /*0x7eed2e4*/ int get_marginHorizontal();
        /*0x7eed320*/ int get_marginVertical();
        /*0x7eed44c*/ void CalcWidth();
        /*0x7eed450*/ void CalcHeight();
        /*0x7eed454*/ void SetHorizontal(float x, float width);
        /*0x7eed460*/ void SetVertical(float y, float height);
        /*0x7eed46c*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x7eed4f0*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x7eed790*/ string ToString();
    }

    class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ UnityEngine.GUIContent m_Content;
        /*0x50*/ float m_ForcedMinHeight;
        /*0x54*/ float m_ForcedMaxHeight;

        /*0x7ee5e6c*/ GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options);
        /*0x7eedd54*/ void CalcWidth();
        /*0x7eeddbc*/ void CalcHeight();
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

        static /*0x7eeffd8*/ GUILayoutGroup();
        /*0x7ee4b88*/ GUILayoutGroup();
        /*0x7eede18*/ int get_marginLeft();
        /*0x7eede20*/ int get_marginRight();
        /*0x7eede28*/ int get_marginTop();
        /*0x7eede30*/ int get_marginBottom();
        /*0x7eede38*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x7eedf30*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x7ee5550*/ void ResetCursor();
        /*0x7ee573c*/ UnityEngine.GUILayoutEntry GetNext();
        /*0x7ee5690*/ void Add(UnityEngine.GUILayoutEntry e);
        /*0x7eedfa4*/ void CalcWidth();
        /*0x7eee5e8*/ void SetHorizontal(float x, float width);
        /*0x7eeee24*/ void CalcHeight();
        /*0x7eef3b8*/ void SetVertical(float y, float height);
        /*0x7eefc00*/ string ToString();
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

        /*0x7ef00ac*/ GUIScrollGroup();
        /*0x7ef010c*/ void CalcWidth();
        /*0x7ef018c*/ void SetHorizontal(float x, float width);
        /*0x7ef026c*/ void CalcHeight();
        /*0x7ef0348*/ void SetVertical(float y, float height);
    }

    class ObjectGUIState : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7ef04fc*/ nint Internal_Create();
        static /*0x7ef06c8*/ void Internal_Destroy(nint ptr);
        /*0x7ef04b4*/ ObjectGUIState();
        /*0x7ef0524*/ void Dispose();
        /*0x7ef0604*/ void Finalize();
        /*0x7ef05b8*/ void Destroy();

        class BindingsMarshaller
        {
            static /*0x7ef0704*/ nint ConvertToNative(UnityEngine.ObjectGUIState objectGUIState);
        }
    }

    class RuntimeTextSettings : UnityEngine.TextCore.Text.TextSettings
    {
        static /*0x0*/ UnityEngine.RuntimeTextSettings s_DefaultTextSettings;
        static /*0x8*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> s_FallbackOSFontAssetIMGUIInternal;

        static /*0x7ef071c*/ UnityEngine.RuntimeTextSettings get_defaultTextSettings();
        /*0x7ef08c8*/ RuntimeTextSettings();
        /*0x7ef07e0*/ UnityEngine.Shader GetFontShader();
        /*0x7ef0830*/ System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset();
        /*0x7ef0878*/ void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets);
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

        /*0x7ef08d0*/ ScrollViewState();
    }

    class SliderState
    {
        /*0x10*/ float dragStartPos;
        /*0x14*/ float dragStartValue;
        /*0x18*/ bool isDragging;

        /*0x7ef08d8*/ SliderState();
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

        /*0x7ef08e0*/ SliderHandler(UnityEngine.Rect position, float currentValue, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        /*0x7ef0950*/ float Handle();
        /*0x7ef09f8*/ float OnMouseDown();
        /*0x7ef0e04*/ float OnMouseDrag();
        /*0x7ef0f20*/ float OnMouseUp();
        /*0x7ef0fbc*/ float OnRepaint();
        /*0x7ef09d0*/ UnityEngine.EventType CurrentEventType();
        /*0x7ef1710*/ int CurrentScrollTroughSide();
        /*0x7ef152c*/ bool IsEmptySlider();
        /*0x7ef15b0*/ bool SupportsPageMovements();
        /*0x7ef1774*/ float PageMovementValue();
        /*0x7ef1a18*/ float PageUpMovementBound();
        /*0x7ef1524*/ UnityEngine.Event CurrentEvent();
        /*0x7ef17fc*/ float ValueForCurrentMousePosition();
        /*0x7ef1870*/ float Clamp(float value);
        /*0x7ef1520*/ UnityEngine.Rect ThumbSelectionRect();
        /*0x7ef1568*/ void StartDraggingWithValue(float dragStartValue);
        /*0x7ef1620*/ UnityEngine.SliderState SliderState();
        /*0x7ef1990*/ UnityEngine.Rect ThumbExtRect();
        /*0x7ef1a08*/ UnityEngine.Rect ThumbRect();
        /*0x7ef1a80*/ UnityEngine.Rect VerticalThumbRect();
        /*0x7ef1ba0*/ UnityEngine.Rect HorizontalThumbRect();
        /*0x7ef153c*/ float ClampedCurrentValue();
        /*0x7ef189c*/ float MousePosition();
        /*0x7ef18e8*/ float ValuesPerPixel();
        /*0x7ef1cc0*/ float ThumbSize();
        /*0x7ef1a68*/ float MaxValue();
        /*0x7ef1a58*/ float MinValue();
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

        static /*0x7ef482c*/ void MapKey(string key, UnityEngine.TextEditOp action);
        static /*0x7ef5020*/ string ReplaceNewlinesWithSpaces(string value);
        /*0x7ef21f4*/ TextEditingUtilities(UnityEngine.TextSelectingUtilities selectingUtilities, UnityEngine.TextCore.Text.TextHandle textHandle, string text);
        /*0x7ef1d54*/ bool get_hasSelection();
        /*0x7ef1dc0*/ void set_revealCursor(bool value);
        /*0x7ef1e38*/ int get_stringCursorIndex();
        /*0x7ef1e6c*/ int get_cursorIndex();
        /*0x7ef1edc*/ void set_cursorIndex(int value);
        /*0x7ef1f4c*/ int get_cursorIndexNoValidation();
        /*0x7ef1f70*/ void set_cursorIndexNoValidation(int value);
        /*0x7ef1fe0*/ void set_selectIndexNoValidation(int value);
        /*0x7ef2050*/ int get_stringSelectIndex();
        /*0x7ef2084*/ int get_selectIndex();
        /*0x7ef20f4*/ void set_selectIndex(int value);
        /*0x7ef2164*/ string get_text();
        /*0x7ef216c*/ void set_text(string value);
        /*0x7ef21ec*/ void SetTextWithoutNotify(string value);
        /*0x7ef2260*/ bool UpdateImeState();
        /*0x7ef2418*/ bool ShouldUpdateImeWindowPosition();
        /*0x7ef2420*/ void SetImeWindowPosition(UnityEngine.Vector2 worldPosition);
        /*0x7ef24cc*/ string GeneratePreviewString(bool richText);
        /*0x7ef260c*/ void EnableCursorPreviewState();
        /*0x7ef25cc*/ void RestoreCursorState();
        /*0x7ef26b0*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x7ef2e0c*/ void PerformOperation(UnityEngine.TextEditOp operation);
        /*0x7ef27c4*/ void InitKeyActions();
        /*0x7ef45ec*/ bool DeleteLineBack();
        /*0x7ef4508*/ bool DeleteWordBack();
        /*0x7ef4748*/ bool DeleteWordForward();
        /*0x7ef409c*/ bool Delete();
        /*0x7ef41c8*/ bool Backspace();
        /*0x7ef48bc*/ bool DeleteSelection();
        /*0x7ef230c*/ void ReplaceSelection(string replace);
        /*0x7ef4e00*/ bool Insert(char c);
        /*0x7ef4f28*/ bool CanPaste();
        /*0x7ef4434*/ bool Cut();
        /*0x7ef4458*/ bool Paste();
        /*0x7ef50b4*/ void OnBlur();
        /*0x7ef5120*/ bool TouchScreenKeyboardShouldBeUsed();
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

        /*0x7ef54d8*/ TextEditor();
        /*0x7ef51a4*/ bool get_showCursor();
        /*0x7ef51c0*/ string get_text();
        /*0x7ef51dc*/ void set_text(string value);
        /*0x7ef545c*/ string get_textWithWhitespace();
        /*0x7ef529c*/ void set_textWithWhitespace(string value);
        /*0x7ef54cc*/ UnityEngine.Rect get_position();
        /*0x7ef5984*/ void OnTextChangedHandle();
        /*0x7ef59c4*/ void OnContentTextChangedHandle();
        /*0x7ef531c*/ void UpdateTextHandle();
        /*0x7ef5a04*/ void UpdateScrollOffset();
        /*0x7ef5df8*/ void OnCursorIndexChange();
        /*0x7ef5dfc*/ void OnSelectIndexChange();

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

        static /*0x7ef730c*/ void MapKey(string key, UnityEngine.TextSelectOp action);
        /*0x7ef5934*/ TextSelectingUtilities(UnityEngine.TextCore.Text.TextHandle textHandle);
        /*0x7ef1d90*/ bool get_hasSelection();
        /*0x7ef5e00*/ bool get_revealCursor();
        /*0x7ef1e08*/ void set_revealCursor(bool value);
        /*0x7ef5e08*/ int get_m_CharacterCount();
        /*0x7ef5e24*/ int get_characterCount();
        /*0x7ef5ef4*/ UnityEngine.TextCore.Text.TextElementInfo[] get_m_TextElementInfos();
        /*0x7ef1e84*/ int get_cursorIndex();
        /*0x7ef1f20*/ void set_cursorIndex(int value);
        /*0x7ef1f68*/ int get_cursorIndexNoValidation();
        /*0x7ef1fb4*/ void set_cursorIndexNoValidation(int value);
        /*0x7ef5f40*/ void SetCursorIndexWithoutNotify(int index);
        /*0x7ef209c*/ int get_selectIndex();
        /*0x7ef2138*/ void set_selectIndex(int value);
        /*0x7ef2024*/ void set_selectIndexNoValidation(int value);
        /*0x7ef5f48*/ void SetSelectIndexWithoutNotify(int index);
        /*0x7ef5f50*/ string get_selectedText();
        /*0x7ef6044*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x7ef6564*/ bool PerformOperation(UnityEngine.TextSelectOp operation);
        /*0x7ef6150*/ void InitKeyActions();
        /*0x7ef4df0*/ void ClearCursorPos();
        /*0x7ef739c*/ void OnFocus(bool selectAll);
        /*0x7ef72a0*/ void SelectAll();
        /*0x7ef50d8*/ void SelectNone();
        /*0x7ef6754*/ void SelectLeft();
        /*0x7ef683c*/ void SelectRight();
        /*0x7ef6924*/ void SelectUp();
        /*0x7ef698c*/ void SelectDown();
        /*0x7ef6cfc*/ void SelectTextEnd();
        /*0x7ef6cd4*/ void SelectTextStart();
        /*0x7ef6c7c*/ void SelectToStartOfNextWord();
        /*0x7ef6c24*/ void SelectToEndOfPreviousWord();
        /*0x7ef69f4*/ void SelectWordRight();
        /*0x7ef6b0c*/ void SelectWordLeft();
        /*0x7ef71f0*/ void SelectGraphicalLineStart();
        /*0x7ef7248*/ void SelectGraphicalLineEnd();
        /*0x7ef6ef4*/ void SelectParagraphForward();
        /*0x7ef7054*/ void SelectParagraphBackward();
        /*0x7ef7650*/ void SelectCurrentWord();
        /*0x7ef7988*/ void SelectCurrentParagraph();
        /*0x7ef3200*/ void MoveRight();
        /*0x7ef3114*/ void MoveLeft();
        /*0x7ef32f4*/ void MoveUp();
        /*0x7ef340c*/ void MoveDown();
        /*0x7ef3530*/ void MoveLineStart();
        /*0x7ef365c*/ void MoveLineEnd();
        /*0x7ef3f34*/ void MoveGraphicalLineStart();
        /*0x7ef3fe8*/ void MoveGraphicalLineEnd();
        /*0x7ef3b28*/ void MoveTextStart();
        /*0x7ef3b84*/ void MoveTextEnd();
        /*0x7ef3bfc*/ void MoveParagraphForward();
        /*0x7ef3d78*/ void MoveParagraphBackward();
        /*0x7ef37a0*/ void MoveWordRight();
        /*0x7ef38a8*/ void MoveToStartOfNextWord();
        /*0x7ef3964*/ void MoveToEndOfPreviousWord();
        /*0x7ef3a20*/ void MoveWordLeft();
        /*0x7ef7c08*/ void MouseDragSelectsWholeWords(bool on);
        /*0x7ef6d3c*/ void ExpandSelectGraphicalLineStart();
        /*0x7ef6e18*/ void ExpandSelectGraphicalLineEnd();
        /*0x7ef7c8c*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x7ef7c94*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x7ef7d2c*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x7ef7ae8*/ int FindNextSeperator(int startPos);
        /*0x7ef7b6c*/ int FindPrevSeperator(int startPos);
        /*0x7ef4b98*/ int FindStartOfNextWord(int p);
        /*0x7ef4a88*/ int FindEndOfPreviousWord(int p);
        /*0x7ef7848*/ int FindEndOfClassification(int p, UnityEngine.TextSelectingUtilities.Direction dir);
        /*0x7ef5f1c*/ int ClampTextIndex(int index);
        /*0x7ef7610*/ int IndexOfEndOfLine(int startIndex);
        /*0x7ef4d94*/ int PreviousCodePointIndex(int index);
        /*0x7ef73e8*/ int NextCodePointIndex(int index);
        /*0x7ef7448*/ int GetGraphicalLineStart(int p);
        /*0x7ef7528*/ int GetGraphicalLineEnd(int p);
        /*0x7ef4f90*/ void Copy();
        /*0x7ef8234*/ UnityEngine.TextSelectingUtilities.CharacterType ClassifyChar(int index);

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
    static /*0x7ef831c*/ uint ComputeStringHash(string s);
}
