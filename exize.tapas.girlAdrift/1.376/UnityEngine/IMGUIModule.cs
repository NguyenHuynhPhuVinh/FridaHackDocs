class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x1a63d84*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x1a63d8c*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace UnityEngine
{
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

        static /*0x1a64a88*/ GUILayoutEntry();
        /*0x1a63ec4*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style);
        /*0x1a63fd0*/ GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, UnityEngine.GUIStyle _style, UnityEngine.GUILayoutOption[] options);
        /*0x1a63d94*/ UnityEngine.GUIStyle get_style();
        /*0x1a63d9c*/ void set_style(UnityEngine.GUIStyle value);
        /*0x1a63dac*/ int get_marginLeft();
        /*0x1a63dd4*/ int get_marginRight();
        /*0x1a63dfc*/ int get_marginTop();
        /*0x1a63e24*/ int get_marginBottom();
        /*0x1a63e4c*/ int get_marginHorizontal();
        /*0x1a63e88*/ int get_marginVertical();
        /*0x1a640d8*/ void CalcWidth();
        /*0x1a640dc*/ void CalcHeight();
        /*0x1a640e0*/ void SetHorizontal(float x, float width);
        /*0x1a64114*/ void SetVertical(float y, float height);
        /*0x1a64148*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x1a641d4*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x1a644a8*/ string ToString();
    }

    class GUIGridSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ int m_Count;
        /*0x4c*/ int m_XCount;
        /*0x50*/ float m_MinButtonWidth;
        /*0x54*/ float m_MaxButtonWidth;
        /*0x58*/ float m_MinButtonHeight;
        /*0x5c*/ float m_MaxButtonHeight;

        static /*0x1a64b08*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        /*0x1a64d84*/ GUIGridSizer(UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle buttonStyle, UnityEngine.GUILayoutOption[] options);
        /*0x1a651dc*/ int get_rows();
    }

    class GUIWordWrapSizer : UnityEngine.GUILayoutEntry
    {
        /*0x48*/ UnityEngine.GUIContent m_Content;
        /*0x50*/ float m_ForcedMinHeight;
        /*0x54*/ float m_ForcedMaxHeight;

        /*0x1a651f4*/ GUIWordWrapSizer(UnityEngine.GUIStyle style, UnityEngine.GUIContent content, UnityEngine.GUILayoutOption[] options);
        /*0x1a65354*/ void CalcWidth();
        /*0x1a653d8*/ void CalcHeight();
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

        static /*0x1a65448*/ GUI();
        static /*0x1a656dc*/ int get_scrollTroughSide();
        static /*0x1a65734*/ void set_scrollTroughSide(int value);
        static /*0x1a65790*/ System.DateTime get_nextScrollStepTime();
        static /*0x1a657e8*/ void set_nextScrollStepTime(System.DateTime value);
        static /*0x1a65844*/ void set_skin(UnityEngine.GUISkin value);
        static /*0x1a659c8*/ UnityEngine.GUISkin get_skin();
        static /*0x1a65920*/ void DoSetSkin(UnityEngine.GUISkin newSkin);
        static /*0x1a65abc*/ UnityEngine.Matrix4x4 get_matrix();
        static /*0x1a65b94*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x1a65c1c*/ void Label(UnityEngine.Rect position, string text);
        static /*0x1a65d80*/ void Label(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a6607c*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode);
        static /*0x1a66114*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend);
        static /*0x1a661b4*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect);
        static /*0x1a66308*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, float borderWidth, float borderRadius);
        static /*0x1a6642c*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, float borderRadius);
        static /*0x1a66560*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses);
        static /*0x1a666b8*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color color, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, bool drawSmoothCorners);
        static /*0x1a66810*/ void DrawTexture(UnityEngine.Rect position, UnityEngine.Texture image, UnityEngine.ScaleMode scaleMode, bool alphaBlend, float imageAspect, UnityEngine.Color leftColor, UnityEngine.Color topColor, UnityEngine.Color rightColor, UnityEngine.Color bottomColor, UnityEngine.Vector4 borderWidths, UnityEngine.Vector4 borderRadiuses, bool drawSmoothCorners);
        static /*0x1a66f0c*/ bool CalculateScaledTextureRects(UnityEngine.Rect position, UnityEngine.ScaleMode scaleMode, float imageAspect, ref UnityEngine.Rect outScreenRect, ref UnityEngine.Rect outSourceRect);
        static /*0x1a67164*/ void Box(UnityEngine.Rect position, string text);
        static /*0x1a673c4*/ void Box(UnityEngine.Rect position, string text, UnityEngine.GUIStyle style);
        static /*0x1a6723c*/ void Box(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a67504*/ bool Button(UnityEngine.Rect position, UnityEngine.Texture image);
        static /*0x1a67720*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content);
        static /*0x1a67668*/ bool Button(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a6785c*/ bool Button(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a67a0c*/ bool DoRepeatButton(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.FocusType focusType);
        static /*0x1a67fbc*/ string PasswordFieldGetStrToShow(string password, char maskChar);
        static /*0x1a68100*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style);
        static /*0x1a681b8*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText);
        static /*0x1a68280*/ void DoTextField(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar);
        static /*0x1a68a80*/ void HandleTextFieldEventForTouchscreen(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, char maskChar, UnityEngine.TextEditor editor);
        static /*0x1a68e84*/ void HandleTextFieldEventForDesktop(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, UnityEngine.TextEditor editor);
        static /*0x1a68768*/ void HandleTextFieldEventForDesktopWithForcedKeyboard(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, bool multiline, int maxLength, UnityEngine.GUIStyle style, string secureText, UnityEngine.TextEditor editor);
        static /*0x1a6a1bc*/ bool Toggle(UnityEngine.Rect position, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a6a39c*/ int Toolbar(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, string[] controlNames, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled);
        static /*0x1a6b2c4*/ int SelectionGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style);
        static /*0x1a6a4e4*/ void FindStyles(ref UnityEngine.GUIStyle style, ref UnityEngine.GUIStyle firstStyle, ref UnityEngine.GUIStyle midStyle, ref UnityEngine.GUIStyle lastStyle, string first, string mid, string last);
        static /*0x1a6b3c0*/ int CalcTotalHorizSpacing(int xCount, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle);
        static /*0x1a6b518*/ bool DoControl(UnityEngine.Rect position, int id, bool on, bool hover, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a65e18*/ void DoLabel(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a6a280*/ bool DoToggle(UnityEngine.Rect position, int id, bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a678fc*/ bool DoButton(UnityEngine.Rect position, int id, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a6a678*/ int DoButtonGrid(UnityEngine.Rect position, int selected, UnityEngine.GUIContent[] contents, string[] controlNames, int itemsPerRow, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle, UnityEngine.GUI.ToolbarButtonSize buttonSize, bool[] contentsEnabled);
        static /*0x1a6bb28*/ UnityEngine.Rect[] CalcGridRects(UnityEngine.Rect position, UnityEngine.GUIContent[] contents, int xCount, float elemWidth, float elemHeight, UnityEngine.GUIStyle style, UnityEngine.GUIStyle firstStyle, UnityEngine.GUIStyle midStyle, UnityEngine.GUIStyle lastStyle, UnityEngine.GUI.ToolbarButtonSize buttonSize);
        static /*0x1a6bed8*/ float Slider(UnityEngine.Rect position, float value, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        static /*0x1a6c0a8*/ float HorizontalScrollbar(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle style);
        static /*0x1a6c7e0*/ bool ScrollerRepeatButton(int scrollerID, UnityEngine.Rect rect, UnityEngine.GUIStyle style);
        static /*0x1a6cae0*/ float VerticalScrollbar(UnityEngine.Rect position, float value, float size, float topValue, float bottomValue, UnityEngine.GUIStyle style);
        static /*0x1a6c25c*/ float Scroller(UnityEngine.Rect position, float value, float size, float leftValue, float rightValue, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, UnityEngine.GUIStyle leftButton, UnityEngine.GUIStyle rightButton, bool horiz);
        static /*0x1a6cc94*/ void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a6cd6c*/ void BeginGroup(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.Vector2 scrollOffset);
        static /*0x1a6d000*/ void EndGroup();
        static /*0x1a6d054*/ UnityEngineInternal.GenericStack get_scrollViewStates();
        static /*0x1a6d0ac*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Rect position, UnityEngine.Vector2 scrollPosition, UnityEngine.Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background);
        static /*0x1a6dd08*/ void EndScrollView(bool handleScrollWheel);
        static /*0x1a6e9b4*/ UnityEngine.Rect Window(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text);
        static /*0x1a6eb98*/ UnityEngine.Rect ModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, string text, UnityEngine.GUIStyle style);
        static /*0x1a6eab0*/ UnityEngine.Rect DoWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin, bool forceRectOnLayout);
        static /*0x1a6ec84*/ UnityEngine.Rect DoModalWindow(int id, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUISkin skin);
        static /*0x1a6ef28*/ void CallWindowDelegate(UnityEngine.GUI.WindowFunction func, int id, int instanceID, UnityEngine.GUISkin _skin, int forceRect, float width, float height, UnityEngine.GUIStyle style);
        static /*0x1a66280*/ UnityEngine.Color get_color();
        static /*0x1a6f83c*/ void set_color(UnityEngine.Color value);
        static /*0x1a6f8fc*/ UnityEngine.Color get_backgroundColor();
        static /*0x1a6f9c0*/ void set_backgroundColor(UnityEngine.Color value);
        static /*0x1a6fa80*/ UnityEngine.Color get_contentColor();
        static /*0x1a6fb44*/ void set_contentColor(UnityEngine.Color value);
        static /*0x1a6fc04*/ bool get_changed();
        static /*0x1a6977c*/ void set_changed(bool value);
        static /*0x1a6bde0*/ bool get_enabled();
        static /*0x1a6be08*/ void set_enabled(bool value);
        static /*0x1a6fc2c*/ bool get_usePageScrollbars();
        static /*0x1a66ee4*/ UnityEngine.Material get_blendMaterial();
        static /*0x1a66ebc*/ UnityEngine.Material get_blitMaterial();
        static /*0x1a66e94*/ UnityEngine.Material get_roundedRectMaterial();
        static /*0x1a66e6c*/ UnityEngine.Material get_roundedRectWithColorPerBorderMaterial();
        static /*0x1a6b9b0*/ void GrabMouseControl(int id);
        static /*0x1a6ba74*/ bool HasMouseControl(int id);
        static /*0x1a6bab0*/ void ReleaseMouseControl();
        static /*0x1a6be44*/ void SetNextControlName(string name);
        static /*0x1a6cab8*/ void InternalRepaintEditorWindow();
        static /*0x1a6ee4c*/ UnityEngine.Rect Internal_DoModalWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, object skin);
        static /*0x1a6ed64*/ UnityEngine.Rect Internal_DoWindow(int id, int instanceID, UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout);
        static /*0x1a6f800*/ void get_color_Injected(ref UnityEngine.Color ret);
        static /*0x1a6f8c0*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x1a6f984*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x1a6fa44*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        static /*0x1a6fb08*/ void get_contentColor_Injected(ref UnityEngine.Color ret);
        static /*0x1a6fbc8*/ void set_contentColor_Injected(ref UnityEngine.Color value);
        static /*0x1a6fc54*/ void Internal_DoModalWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, object skin, ref UnityEngine.Rect ret);
        static /*0x1a6fce0*/ void Internal_DoWindow_Injected(int id, int instanceID, ref UnityEngine.Rect clientRect, UnityEngine.GUI.WindowFunction func, UnityEngine.GUIContent title, UnityEngine.GUIStyle style, object skin, bool forceRectOnLayout, ref UnityEngine.Rect ret);

        enum ToolbarButtonSize
        {
            Fixed = 0,
            FitToContents = 1,
        }

        class WindowFunction : System.MulticastDelegate
        {
            /*0x1a6fd7c*/ WindowFunction(object object, nint method);
            /*0x1a6fe40*/ void Invoke(int id);
        }
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

    class SliderState
    {
        /*0x10*/ float dragStartPos;
        /*0x14*/ float dragStartValue;
        /*0x18*/ bool isDragging;

        /*0x1a6fe54*/ SliderState();
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

        /*0x1a6c000*/ SliderHandler(UnityEngine.Rect position, float currentValue, float size, float start, float end, UnityEngine.GUIStyle slider, UnityEngine.GUIStyle thumb, bool horiz, int id, UnityEngine.GUIStyle thumbExtent);
        /*0x1a6c028*/ float Handle();
        /*0x1a6fedc*/ float OnMouseDown();
        /*0x1a703b4*/ float OnMouseDrag();
        /*0x1a70514*/ float OnMouseUp();
        /*0x1a705c8*/ float OnRepaint();
        /*0x1a6fe5c*/ UnityEngine.EventType CurrentEventType();
        /*0x1a70d64*/ int CurrentScrollTroughSide();
        /*0x1a70b8c*/ bool IsEmptySlider();
        /*0x1a70c10*/ bool SupportsPageMovements();
        /*0x1a70e1c*/ float PageMovementValue();
        /*0x1a71188*/ float PageUpMovementBound();
        /*0x1a70b44*/ UnityEngine.Event CurrentEvent();
        /*0x1a70eac*/ float ValueForCurrentMousePosition();
        /*0x1a70f34*/ float Clamp(float value);
        /*0x1a70b40*/ UnityEngine.Rect ThumbSelectionRect();
        /*0x1a70bc8*/ void StartDraggingWithValue(float dragStartValue);
        /*0x1a70c98*/ UnityEngine.SliderState SliderState();
        /*0x1a710dc*/ UnityEngine.Rect ThumbExtRect();
        /*0x1a71178*/ UnityEngine.Rect ThumbRect();
        /*0x1a71234*/ UnityEngine.Rect VerticalThumbRect();
        /*0x1a713d0*/ UnityEngine.Rect HorizontalThumbRect();
        /*0x1a70b9c*/ float ClampedCurrentValue();
        /*0x1a70f60*/ float MousePosition();
        /*0x1a71018*/ float ValuesPerPixel();
        /*0x1a71568*/ float ThumbSize();
        /*0x1a7121c*/ float MaxValue();
        /*0x1a7120c*/ float MinValue();
    }

    class GUIClip
    {
        static /*0x1a6bae0*/ UnityEngine.Rect get_visibleRect();
        static /*0x1a71638*/ void Internal_Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x1a6d02c*/ void Internal_Pop();
        static /*0x1a716f8*/ int Internal_GetCount();
        static /*0x1a71720*/ UnityEngine.Vector2 UnclipToWindow_Vector2(UnityEngine.Vector2 pos);
        static /*0x1a65b30*/ UnityEngine.Matrix4x4 GetMatrix();
        static /*0x1a65be0*/ void SetMatrix(UnityEngine.Matrix4x4 m);
        static /*0x1a71828*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
        static /*0x1a71868*/ void Internal_PushParentClip(UnityEngine.Matrix4x4 renderTransform, UnityEngine.Matrix4x4 inputTransform, UnityEngine.Rect clipRect);
        static /*0x1a71918*/ void Internal_PopParentClip();
        static /*0x1a6cff8*/ void Push(UnityEngine.Rect screenRect, UnityEngine.Vector2 scrollOffset, UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x1a6e904*/ void Pop();
        static /*0x1a71940*/ UnityEngine.Vector2 UnclipToWindow(UnityEngine.Vector2 pos);
        static /*0x1a715fc*/ void get_visibleRect_Injected(ref UnityEngine.Rect ret);
        static /*0x1a7169c*/ void Internal_Push_Injected(ref UnityEngine.Rect screenRect, ref UnityEngine.Vector2 scrollOffset, ref UnityEngine.Vector2 renderOffset, bool resetOffset);
        static /*0x1a7176c*/ void UnclipToWindow_Vector2_Injected(ref UnityEngine.Vector2 pos, ref UnityEngine.Vector2 ret);
        static /*0x1a717b0*/ void GetMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        static /*0x1a717ec*/ void SetMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x1a718c4*/ void Internal_PushParentClip_Injected(ref UnityEngine.Matrix4x4 renderTransform, ref UnityEngine.Matrix4x4 inputTransform, ref UnityEngine.Rect clipRect);

        struct ParentClipScope : System.IDisposable
        {
            /*0x10*/ bool m_Disposed;

            /*0x1a71944*/ ParentClipScope(UnityEngine.Matrix4x4 objectTransform, UnityEngine.Rect clipRect);
            /*0x1a71998*/ void Dispose();
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

        /*0x1a719d8*/ bool get_wantsMouseMove();
        /*0x1a719e0*/ void set_wantsMouseMove(bool value);
        /*0x1a719ec*/ bool get_wantsMouseEnterLeaveWindow();
        /*0x1a719f4*/ void set_wantsMouseEnterLeaveWindow(bool value);
        /*0x1a71a00*/ bool get_wantsLessLayoutEvents();
        /*0x1a71a08*/ bool WantsEvent(UnityEngine.EventType type);
        /*0x1a71a38*/ bool WantsLayoutPass(UnityEngine.EventType type);
    }

    class Event
    {
        static /*0x0*/ UnityEngine.Event s_Current;
        static /*0x8*/ UnityEngine.Event s_MasterEvent;
        /*0x10*/ nint m_Ptr;

        static /*0x1a64d00*/ UnityEngine.Event get_current();
        static /*0x1a71ddc*/ void set_current(UnityEngine.Event value);
        static /*0x1a72014*/ UnityEngine.Event KeyboardEvent(string key);
        static /*0x1a71b40*/ nint Internal_Create(int displayIndex);
        static /*0x1a71cec*/ void Internal_Destroy(nint ptr);
        static /*0x1a74bc8*/ bool PopEvent(UnityEngine.Event outEvent);
        static /*0x1a71e70*/ void Internal_SetNativeEvent(nint ptr);
        static /*0x1a74c04*/ void Internal_MakeMasterEventCurrent(int displayIndex);
        static /*0x1a74cfc*/ int GetDoubleClickTime();
        /*0x1a71af4*/ Event();
        /*0x1a71b7c*/ Event(int displayIndex);
        /*0x1a71bcc*/ void Finalize();
        /*0x1a71d28*/ void CopyFrom(UnityEngine.Event e);
        /*0x1a699a4*/ bool get_shift();
        /*0x1a6ba30*/ bool get_control();
        /*0x1a69c7c*/ bool get_alt();
        /*0x1a6b9ec*/ bool get_command();
        /*0x1a71eac*/ bool get_isKey();
        /*0x1a71ef8*/ bool get_isMouse();
        /*0x1a71f5c*/ bool get_isDirectManipulationDevice();
        /*0x1a73cb0*/ int GetHashCode();
        /*0x1a73db0*/ bool Equals(object obj);
        /*0x1a73fe4*/ string ToString();
        /*0x1a67dd0*/ void Use();
        /*0x1a748b0*/ UnityEngine.EventType get_rawType();
        /*0x1a674b8*/ UnityEngine.Vector2 get_mousePosition();
        /*0x1a74930*/ void set_mousePosition(UnityEngine.Vector2 value);
        /*0x1a6e92c*/ UnityEngine.Vector2 get_delta();
        /*0x1a74a00*/ void set_delta(UnityEngine.Vector2 value);
        /*0x1a71fd8*/ UnityEngine.PointerType get_pointerType();
        /*0x1a74a8c*/ int get_button();
        /*0x1a6e978*/ UnityEngine.EventModifiers get_modifiers();
        /*0x1a73be4*/ void set_modifiers(UnityEngine.EventModifiers value);
        /*0x1a74ac8*/ float get_pressure();
        /*0x1a69854*/ int get_clickCount();
        /*0x1a69c40*/ char get_character();
        /*0x1a73c28*/ void set_character(char value);
        /*0x1a69c04*/ UnityEngine.KeyCode get_keyCode();
        /*0x1a73c6c*/ void set_keyCode(UnityEngine.KeyCode value);
        /*0x1a74b04*/ int get_displayIndex();
        /*0x1a74b40*/ void set_displayIndex(int value);
        /*0x1a64d48*/ UnityEngine.EventType get_type();
        /*0x1a73ba0*/ void set_type(UnityEngine.EventType value);
        /*0x1a74838*/ string get_commandName();
        /*0x1a74b84*/ void set_commandName(string value);
        /*0x1a74874*/ void Internal_Use();
        /*0x1a67d50*/ UnityEngine.EventType GetTypeForControl(int controlID);
        /*0x1a71d98*/ void CopyFromPtr(nint ptr);
        /*0x1a748ec*/ void get_mousePosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x1a74978*/ void set_mousePosition_Injected(ref UnityEngine.Vector2 value);
        /*0x1a749bc*/ void get_delta_Injected(ref UnityEngine.Vector2 ret);
        /*0x1a74a48*/ void set_delta_Injected(ref UnityEngine.Vector2 value);
    }

    class GUILayoutUtility
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredLayouts;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.GUILayoutUtility.LayoutCache> s_StoredWindows;
        static /*0x10*/ UnityEngine.GUILayoutUtility.LayoutCache current;
        static /*0x18*/ UnityEngine.Rect kDummyRect;
        static /*0x28*/ int <unbalancedgroupscount>k__BackingField;
        static /*0x30*/ UnityEngine.GUIStyle s_SpaceStyle;

        static /*0x1a76bc0*/ GUILayoutUtility();
        static /*0x1a74d24*/ UnityEngine.Rect Internal_GetWindowRect(int windowID);
        static /*0x1a74df8*/ void Internal_MoveWindow(int windowID, UnityEngine.Rect r);
        static /*0x1a74ec8*/ int get_unbalancedgroupscount();
        static /*0x1a74f20*/ void set_unbalancedgroupscount(int value);
        static /*0x1a6f240*/ UnityEngine.GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow);
        static /*0x1a7505c*/ void Begin(int instanceID);
        static /*0x1a75230*/ void BeginContainer(UnityEngine.GUILayoutUtility.LayoutCache cache);
        static /*0x1a6f388*/ void BeginWindow(int windowID, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1a6f608*/ void Layout();
        static /*0x1a75750*/ void LayoutFromEditorWindow();
        static /*0x1a7593c*/ void LayoutFromContainer(float w, float h);
        static /*0x1a753bc*/ void LayoutFreeGroup(UnityEngine.GUILayoutGroup toplevel);
        static /*0x1a75580*/ void LayoutSingleGroup(UnityEngine.GUILayoutGroup i);
        static /*0x1a75ac4*/ UnityEngine.GUILayoutGroup CreateGUILayoutGroupInstanceOfType(System.Type LayoutType);
        static /*0x1a75c14*/ UnityEngine.GUILayoutGroup BeginLayoutGroup(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options, System.Type layoutType);
        static /*0x1a75f68*/ void EndLayoutGroup();
        static /*0x1a761d4*/ UnityEngine.GUILayoutGroup BeginLayoutArea(UnityEngine.GUIStyle style, System.Type layoutType);
        static /*0x1a76468*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1a76810*/ UnityEngine.Rect GetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1a764d0*/ UnityEngine.Rect DoGetRect(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1a7687c*/ UnityEngine.Rect GetRect(float width, float height, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1a76900*/ UnityEngine.Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1a76ae4*/ UnityEngine.GUIStyle get_spaceStyle();
        static /*0x1a74db4*/ void Internal_GetWindowRect_Injected(int windowID, ref UnityEngine.Rect ret);
        static /*0x1a74e84*/ void Internal_MoveWindow_Injected(int windowID, ref UnityEngine.Rect r);

        class LayoutCache
        {
            /*0x10*/ int <id>k__BackingField;
            /*0x18*/ UnityEngine.GUILayoutGroup topLevel;
            /*0x20*/ UnityEngineInternal.GenericStack layoutGroups;
            /*0x28*/ UnityEngine.GUILayoutGroup windows;

            /*0x1a74f7c*/ LayoutCache(int instanceID);
            /*0x1a76ce8*/ void set_id(int value);
            /*0x1a76cf0*/ void ResetCursor();
        }
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

        /*0x1a76fdc*/ ScrollViewState();
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
        static /*0x40*/ bool <guiIsExiting>k__BackingField;
        static /*0x48*/ System.Func<bool> s_HasCurrentWindowKeyFocusFunc;

        static /*0x1a75394*/ float get_pixelsPerPoint();
        static /*0x1a76fe4*/ int get_guiDepth();
        static /*0x1a6be80*/ void set_mouseUsed(bool value);
        static /*0x1a71acc*/ bool get_textFieldInput();
        static /*0x1a6a180*/ void set_textFieldInput(bool value);
        static /*0x1a7700c*/ string get_systemCopyBuffer();
        static /*0x1a77034*/ void set_systemCopyBuffer(string value);
        static /*0x1a77070*/ int Internal_GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x1a677c4*/ int GetControlID(int hint, UnityEngine.FocusType focusType, UnityEngine.Rect rect);
        static /*0x1a77120*/ void BeginContainerFromOwner(UnityEngine.ScriptableObject owner);
        static /*0x1a7715c*/ void BeginContainer(UnityEngine.ObjectGUIState objectGUIState);
        static /*0x1a77198*/ void Internal_EndContainer();
        static /*0x1a771c0*/ int CheckForTabEvent(UnityEngine.Event evt);
        static /*0x1a771fc*/ void SetKeyboardControlToFirstControlId();
        static /*0x1a77224*/ void SetKeyboardControlToLastControlId();
        static /*0x1a7724c*/ bool HasFocusableControls();
        static /*0x1a77274*/ bool OwnsId(int id);
        static /*0x1a772b0*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels);
        static /*0x1a69cf4*/ string get_compositionString();
        static /*0x1a77378*/ void set_imeCompositionMode(UnityEngine.IMECompositionMode value);
        static /*0x1a773b4*/ void set_compositionCursorPos(UnityEngine.Vector2 value);
        static /*0x1a77430*/ int Internal_GetHotControl();
        static /*0x1a77458*/ int Internal_GetKeyboardControl();
        static /*0x1a77480*/ void Internal_SetHotControl(int value);
        static /*0x1a774bc*/ void Internal_SetKeyboardControl(int value);
        static /*0x1a774f8*/ object Internal_GetDefaultSkin(int skinMode);
        static /*0x1a77534*/ void Internal_ExitGUI();
        static /*0x1a7755c*/ void MarkGUIChanged();
        static /*0x1a775c0*/ int GetControlID(UnityEngine.FocusType focus);
        static /*0x1a6748c*/ int GetControlID(int hint, UnityEngine.FocusType focus);
        static /*0x1a685a0*/ object GetStateObject(System.Type t, int controlID);
        static /*0x1a775cc*/ void set_guiIsExiting(bool value);
        static /*0x1a67f94*/ int get_hotControl();
        static /*0x1a67d94*/ void set_hotControl(int value);
        static /*0x1a77618*/ void TakeCapture();
        static /*0x1a7767c*/ void RemoveCapture();
        static /*0x1a69718*/ int get_keyboardControl();
        static /*0x1a69740*/ void set_keyboardControl(int value);
        static /*0x1a776e0*/ bool HasKeyFocus(int controlID);
        static /*0x1a77780*/ void ExitGUI();
        static /*0x1a65a24*/ UnityEngine.GUISkin GetDefaultSkin();
        static /*0x1a777c0*/ void ProcessEvent(int instanceID, nint nativeEventPtr, ref bool result);
        static /*0x1a77844*/ void EndContainer();
        static /*0x1a7788c*/ void BeginGUI(int skinMode, int instanceID, int useGUILayout);
        static /*0x1a77a28*/ void EndGUI(int layoutType);
        static /*0x1a77cb8*/ bool EndGUIFromException(System.Exception exception);
        static /*0x1a77cfc*/ bool EndContainerGUIFromException(System.Exception exception);
        static /*0x1a77928*/ void ResetGlobalState();
        static /*0x1a77d6c*/ bool IsExitGUIException(System.Exception exception);
        static /*0x1a77cf8*/ bool ShouldRethrowException(System.Exception exception);
        static /*0x1a6589c*/ void CheckOnGUI();
        static /*0x1a77df0*/ float RoundToPixelGrid(float v);
        static /*0x1a6bebc*/ UnityEngine.Rect AlignRectToDevice(UnityEngine.Rect rect);
        static /*0x1a77e5c*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, int offset);
        static /*0x1a77f00*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Vector2 point, bool isDirectManipulationDevice);
        static /*0x1a6b940*/ bool HitTest(UnityEngine.Rect rect, UnityEngine.Event evt);
        static /*0x1a770cc*/ int Internal_GetControlID_Injected(int hint, UnityEngine.FocusType focusType, ref UnityEngine.Rect rect);
        static /*0x1a7731c*/ void AlignRectToDevice_Injected(ref UnityEngine.Rect rect, ref int widthInPixels, ref int heightInPixels, ref UnityEngine.Rect ret);
        static /*0x1a773f4*/ void set_compositionCursorPos_Injected(ref UnityEngine.Vector2 value);
    }

    class ObjectGUIState : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1a77f50*/ nint Internal_Create();
        static /*0x1a7810c*/ void Internal_Destroy(nint ptr);
        /*0x1a77f08*/ ObjectGUIState();
        /*0x1a77f78*/ void Dispose();
        /*0x1a78078*/ void Finalize();
        /*0x1a77fd8*/ void Destroy();
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

        static /*0x1a783cc*/ GUIContent();
        static /*0x1a65cf4*/ UnityEngine.GUIContent Temp(string t);
        static /*0x1a675dc*/ UnityEngine.GUIContent Temp(UnityEngine.Texture i);
        static /*0x1a77c18*/ void ClearStaticCache();
        static /*0x1a7829c*/ UnityEngine.GUIContent[] Temp(string[] texts);
        /*0x1a78158*/ GUIContent();
        /*0x1a781b4*/ GUIContent(string text);
        /*0x1a78218*/ GUIContent(string text, UnityEngine.Texture image, string tooltip);
        /*0x1a652d0*/ GUIContent(UnityEngine.GUIContent src);
        /*0x1a68590*/ string get_text();
        /*0x1a68598*/ void set_text(string value);
        /*0x1a78148*/ void set_image(UnityEngine.Texture value);
        /*0x1a6bad8*/ string get_tooltip();
        /*0x1a78150*/ void set_tooltip(string value);
        /*0x1a783ac*/ string ToString();
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

        static /*0x1a7b8a4*/ string ReplaceNewlinesWithSpaces(string value);
        static /*0x1a7b938*/ void MapKey(string key, UnityEngine.TextEditor.TextEditOp action);
        /*0x1a78968*/ TextEditor();
        /*0x1a69be8*/ string get_text();
        /*0x1a68608*/ void set_text(string value);
        /*0x1a784dc*/ UnityEngine.Rect get_position();
        /*0x1a686a4*/ void set_position(UnityEngine.Rect value);
        /*0x1a7888c*/ UnityEngine.Rect get_localPosition();
        /*0x1a78898*/ int get_cursorIndex();
        /*0x1a788a0*/ void set_cursorIndex(int value);
        /*0x1a788f8*/ int get_selectIndex();
        /*0x1a78900*/ void set_selectIndex(int value);
        /*0x1a78950*/ void ClearCursorPos();
        /*0x1a78960*/ int get_altCursorPosition();
        /*0x1a78a60*/ void OnFocus();
        /*0x1a78ae8*/ void OnLostFocus();
        /*0x1a78b3c*/ void GrabGraphicalCursorPos();
        /*0x1a69be0*/ bool HandleKeyEvent(UnityEngine.Event e);
        /*0x1a78bc0*/ bool HandleKeyEvent(UnityEngine.Event e, bool textIsReadOnly);
        /*0x1a79ba8*/ bool DeleteLineBack();
        /*0x1a79d7c*/ bool DeleteWordBack();
        /*0x1a79ed4*/ bool DeleteWordForward();
        /*0x1a7a100*/ bool Delete();
        /*0x1a7a250*/ bool CanPaste();
        /*0x1a7a294*/ bool Backspace();
        /*0x1a78aa4*/ void SelectAll();
        /*0x1a7a3f4*/ void SelectNone();
        /*0x1a79c60*/ bool get_hasSelection();
        /*0x1a7a418*/ string get_SelectedText();
        /*0x1a79c70*/ bool DeleteSelection();
        /*0x1a69d1c*/ void ReplaceSelection(string replace);
        /*0x1a69cc0*/ void Insert(char c);
        /*0x1a7a4a4*/ void MoveSelectionToAltCursor();
        /*0x1a7a560*/ void MoveRight();
        /*0x1a7a5cc*/ void MoveLeft();
        /*0x1a7a624*/ void MoveUp();
        /*0x1a7a6d4*/ void MoveDown();
        /*0x1a7a7b4*/ void MoveLineStart();
        /*0x1a7a828*/ void MoveLineEnd();
        /*0x1a7a8b8*/ void MoveGraphicalLineStart();
        /*0x1a7a9b0*/ void MoveGraphicalLineEnd();
        /*0x1a7aabc*/ void MoveTextStart();
        /*0x1a7aadc*/ void MoveTextEnd();
        /*0x1a7ab1c*/ int IndexOfEndOfLine(int startIndex);
        /*0x1a7ab6c*/ void MoveParagraphForward();
        /*0x1a7abec*/ void MoveParagraphBackward();
        /*0x1a697b8*/ void MoveCursorToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x1a7ac64*/ void MoveCursorToPosition_Internal(UnityEngine.Vector2 cursorPosition, bool shift);
        /*0x1a7acec*/ void MoveAltCursorToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x1a699e8*/ void SelectToPosition(UnityEngine.Vector2 cursorPosition);
        /*0x1a7ae88*/ void SelectLeft();
        /*0x1a7aee0*/ void SelectRight();
        /*0x1a7af38*/ void SelectUp();
        /*0x1a7af9c*/ void SelectDown();
        /*0x1a7b01c*/ void SelectTextEnd();
        /*0x1a7b040*/ void SelectTextStart();
        /*0x1a69904*/ void MouseDragSelectsWholeWords(bool on);
        /*0x1a698fc*/ void DblClickSnap(UnityEngine.TextEditor.DblClickSnapping snapping);
        /*0x1a7a900*/ int GetGraphicalLineStart(int p);
        /*0x1a7a9f8*/ int GetGraphicalLineEnd(int p);
        /*0x1a7b048*/ int FindNextSeperator(int startPos);
        /*0x1a7b1c8*/ int FindPrevSeperator(int startPos);
        /*0x1a7b264*/ void MoveWordRight();
        /*0x1a7b2c8*/ void MoveToStartOfNextWord();
        /*0x1a7b328*/ void MoveToEndOfPreviousWord();
        /*0x1a7b388*/ void SelectToStartOfNextWord();
        /*0x1a7b3b4*/ void SelectToEndOfPreviousWord();
        /*0x1a7b0e0*/ UnityEngine.TextEditor.CharacterType ClassifyChar(int index);
        /*0x1a79f50*/ int FindStartOfNextWord(int p);
        /*0x1a79e0c*/ int FindEndOfPreviousWord(int p);
        /*0x1a7b3e0*/ void MoveWordLeft();
        /*0x1a7b428*/ void SelectWordRight();
        /*0x1a7b490*/ void SelectWordLeft();
        /*0x1a7b4f8*/ void ExpandSelectGraphicalLineStart();
        /*0x1a7b55c*/ void ExpandSelectGraphicalLineEnd();
        /*0x1a7b5c0*/ void SelectGraphicalLineStart();
        /*0x1a7b5ec*/ void SelectGraphicalLineEnd();
        /*0x1a7b618*/ void SelectParagraphForward();
        /*0x1a7b6a0*/ void SelectParagraphBackward();
        /*0x1a69890*/ void SelectCurrentWord();
        /*0x1a7ad74*/ int FindEndOfClassification(int p, UnityEngine.TextEditor.Direction dir);
        /*0x1a69918*/ void SelectCurrentParagraph();
        /*0x1a69688*/ void UpdateScrollOffsetIfNeeded(UnityEngine.Event evt);
        /*0x1a784e8*/ void UpdateScrollOffset();
        /*0x1a69d98*/ void DrawCursor(string newText);
        /*0x1a797d0*/ bool PerformOperation(UnityEngine.TextEditor.TextEditOp operation, bool textIsReadOnly);
        /*0x1a68680*/ void SaveBackup();
        /*0x1a7b744*/ bool Cut();
        /*0x1a7b770*/ void Copy();
        /*0x1a7b800*/ bool Paste();
        /*0x1a78d74*/ void InitKeyActions();
        /*0x1a6875c*/ void DetectFocusChange();
        /*0x1a7b9c4*/ void OnDetectFocusChange();
        /*0x1a7ba60*/ void OnCursorIndexChange();
        /*0x1a7ba64*/ void OnSelectIndexChange();
        /*0x1a7ba68*/ void ClampTextIndex(ref int index);
        /*0x1a7849c*/ void EnsureValidCodePointIndex(ref int index);
        /*0x1a7baa4*/ bool IsValidCodePointIndex(int index);
        /*0x1a7a334*/ int PreviousCodePointIndex(int index);
        /*0x1a7a18c*/ int NextCodePointIndex(int index);

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

    class GUISettings
    {
        /*0x10*/ bool m_DoubleClickSelectsWord;
        /*0x11*/ bool m_TripleClickSelectsLine;
        /*0x14*/ UnityEngine.Color m_CursorColor;
        /*0x24*/ float m_CursorFlashSpeed;
        /*0x28*/ UnityEngine.Color m_SelectionColor;

        static /*0x1393290*/ float Internal_GetCursorFlashSpeed();
        /*0x139331c*/ GUISettings();
        /*0x13932b8*/ bool get_doubleClickSelectsWord();
        /*0x13932c0*/ bool get_tripleClickSelectsLine();
        /*0x13932c8*/ UnityEngine.Color get_cursorColor();
        /*0x13932d4*/ float get_cursorFlashSpeed();
        /*0x1393310*/ UnityEngine.Color get_selectionColor();
    }

    class GUILayout
    {
        static /*0x1393348*/ void Label(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x13934d4*/ void Label(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1393400*/ void DoLabel(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1393548*/ bool Button(string text, UnityEngine.GUILayoutOption[] options);
        static /*0x1393600*/ bool DoButton(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x13936d4*/ string TextField(string text, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x13936e8*/ string DoTextField(string text, int maxLength, bool multiline, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x13938d8*/ bool Toggle(bool value, string text, UnityEngine.GUILayoutOption[] options);
        static /*0x1393998*/ bool DoToggle(bool value, UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1393a7c*/ int Toolbar(int selected, string[] texts, UnityEngine.GUILayoutOption[] options);
        static /*0x1393b3c*/ int Toolbar(int selected, UnityEngine.GUIContent[] contents, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1393b50*/ int Toolbar(int selected, UnityEngine.GUIContent[] contents, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, UnityEngine.GUILayoutOption[] options);
        static /*0x1393b64*/ int Toolbar(int selected, UnityEngine.GUIContent[] contents, bool[] enabled, UnityEngine.GUIStyle style, UnityEngine.GUI.ToolbarButtonSize buttonSize, UnityEngine.GUILayoutOption[] options);
        static /*0x1393ef8*/ int SelectionGrid(int selected, string[] texts, int xCount, UnityEngine.GUILayoutOption[] options);
        static /*0x1393fc0*/ int SelectionGrid(int selected, UnityEngine.GUIContent[] contents, int xCount, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x139408c*/ void Space(float pixels);
        static /*0x13943b0*/ void FlexibleSpace();
        static /*0x1394748*/ void BeginHorizontal(UnityEngine.GUILayoutOption[] options);
        static /*0x139486c*/ void BeginHorizontal(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1394a24*/ void EndHorizontal();
        static /*0x1394a74*/ void BeginVertical(UnityEngine.GUILayoutOption[] options);
        static /*0x1394cc4*/ void BeginVertical(UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1394b08*/ void BeginVertical(UnityEngine.GUIContent content, UnityEngine.GUIStyle style, UnityEngine.GUILayoutOption[] options);
        static /*0x1394d34*/ void EndVertical();
        static /*0x1394d84*/ void BeginArea(UnityEngine.Rect screenRect);
        static /*0x1394e40*/ void BeginArea(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, UnityEngine.GUIStyle style);
        static /*0x1395028*/ void EndArea();
        static /*0x1395184*/ UnityEngine.Vector2 BeginScrollView(UnityEngine.Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, UnityEngine.GUIStyle horizontalScrollbar, UnityEngine.GUIStyle verticalScrollbar, UnityEngine.GUIStyle background, UnityEngine.GUILayoutOption[] options);
        static /*0x13953c4*/ void EndScrollView();
        static /*0x13953cc*/ void EndScrollView(bool handleScrollWheel);
        static /*0x1394314*/ UnityEngine.GUILayoutOption Width(float width);
        static /*0x1395450*/ UnityEngine.GUILayoutOption MinWidth(float minWidth);
        static /*0x1394274*/ UnityEngine.GUILayoutOption Height(float height);
        static /*0x1394674*/ UnityEngine.GUILayoutOption ExpandWidth(bool expand);
        static /*0x13945d0*/ UnityEngine.GUILayoutOption ExpandHeight(bool expand);
    }

    class GUITargetAttribute : System.Attribute
    {
        /*0x10*/ int displayMask;

        static /*0x13954f0*/ int GetGUITargetAttrValue(System.Type klass, string methodName);
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

        static /*0x13957a4*/ void CleanupRoots();
        static /*0x1395a8c*/ UnityEngine.GUIStyle get_error();
        /*0x1395670*/ GUISkin();
        /*0x1395724*/ void OnEnable();
        /*0x13957f0*/ UnityEngine.Font get_font();
        /*0x13957f8*/ void set_font(UnityEngine.Font value);
        /*0x139591c*/ UnityEngine.GUIStyle get_box();
        /*0x1395924*/ void set_box(UnityEngine.GUIStyle value);
        /*0x13933f8*/ UnityEngine.GUIStyle get_label();
        /*0x139592c*/ void set_label(UnityEngine.GUIStyle value);
        /*0x1395934*/ UnityEngine.GUIStyle get_textField();
        /*0x139593c*/ void set_textField(UnityEngine.GUIStyle value);
        /*0x1395944*/ UnityEngine.GUIStyle get_textArea();
        /*0x139594c*/ void set_textArea(UnityEngine.GUIStyle value);
        /*0x13935f8*/ UnityEngine.GUIStyle get_button();
        /*0x1395954*/ void set_button(UnityEngine.GUIStyle value);
        /*0x1393990*/ UnityEngine.GUIStyle get_toggle();
        /*0x139595c*/ void set_toggle(UnityEngine.GUIStyle value);
        /*0x1395964*/ UnityEngine.GUIStyle get_window();
        /*0x139596c*/ void set_window(UnityEngine.GUIStyle value);
        /*0x1395974*/ UnityEngine.GUIStyle get_horizontalSlider();
        /*0x139597c*/ void set_horizontalSlider(UnityEngine.GUIStyle value);
        /*0x1395984*/ UnityEngine.GUIStyle get_horizontalSliderThumb();
        /*0x139598c*/ void set_horizontalSliderThumb(UnityEngine.GUIStyle value);
        /*0x1395994*/ UnityEngine.GUIStyle get_horizontalSliderThumbExtent();
        /*0x139599c*/ void set_horizontalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x13959a4*/ UnityEngine.GUIStyle get_sliderMixed();
        /*0x13959ac*/ void set_sliderMixed(UnityEngine.GUIStyle value);
        /*0x13959b4*/ UnityEngine.GUIStyle get_verticalSlider();
        /*0x13959bc*/ void set_verticalSlider(UnityEngine.GUIStyle value);
        /*0x13959c4*/ UnityEngine.GUIStyle get_verticalSliderThumb();
        /*0x13959cc*/ void set_verticalSliderThumb(UnityEngine.GUIStyle value);
        /*0x13959d4*/ UnityEngine.GUIStyle get_verticalSliderThumbExtent();
        /*0x13959dc*/ void set_verticalSliderThumbExtent(UnityEngine.GUIStyle value);
        /*0x13959e4*/ UnityEngine.GUIStyle get_horizontalScrollbar();
        /*0x13959ec*/ void set_horizontalScrollbar(UnityEngine.GUIStyle value);
        /*0x13959f4*/ UnityEngine.GUIStyle get_horizontalScrollbarThumb();
        /*0x13959fc*/ void set_horizontalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x1395a04*/ UnityEngine.GUIStyle get_horizontalScrollbarLeftButton();
        /*0x1395a0c*/ void set_horizontalScrollbarLeftButton(UnityEngine.GUIStyle value);
        /*0x1395a14*/ UnityEngine.GUIStyle get_horizontalScrollbarRightButton();
        /*0x1395a1c*/ void set_horizontalScrollbarRightButton(UnityEngine.GUIStyle value);
        /*0x1395a24*/ UnityEngine.GUIStyle get_verticalScrollbar();
        /*0x1395a2c*/ void set_verticalScrollbar(UnityEngine.GUIStyle value);
        /*0x1395a34*/ UnityEngine.GUIStyle get_verticalScrollbarThumb();
        /*0x1395a3c*/ void set_verticalScrollbarThumb(UnityEngine.GUIStyle value);
        /*0x1395a44*/ UnityEngine.GUIStyle get_verticalScrollbarUpButton();
        /*0x1395a4c*/ void set_verticalScrollbarUpButton(UnityEngine.GUIStyle value);
        /*0x1395a54*/ UnityEngine.GUIStyle get_verticalScrollbarDownButton();
        /*0x1395a5c*/ void set_verticalScrollbarDownButton(UnityEngine.GUIStyle value);
        /*0x1395a64*/ UnityEngine.GUIStyle get_scrollView();
        /*0x1395a6c*/ void set_scrollView(UnityEngine.GUIStyle value);
        /*0x1395a74*/ UnityEngine.GUIStyle[] get_customStyles();
        /*0x1395a7c*/ void set_customStyles(UnityEngine.GUIStyle[] value);
        /*0x1395a84*/ UnityEngine.GUISettings get_settings();
        /*0x1395728*/ void Apply();
        /*0x1395c4c*/ void BuildStyleCache();
        /*0x1396c00*/ UnityEngine.GUIStyle GetStyle(string styleName);
        /*0x1396e8c*/ UnityEngine.GUIStyle FindStyle(string styleName);
        /*0x1396f14*/ void MakeCurrent();
        /*0x1396fe4*/ System.Collections.IEnumerator GetEnumerator();

        class SkinChangedDelegate : System.MulticastDelegate
        {
            /*0x13970a4*/ SkinChangedDelegate(object object, nint method);
            /*0x1397160*/ void Invoke();
        }
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

        static /*0x1399a08*/ GUILayoutGroup();
        /*0x1397194*/ GUILayoutGroup();
        /*0x1397174*/ int get_marginLeft();
        /*0x139717c*/ int get_marginRight();
        /*0x1397184*/ int get_marginTop();
        /*0x139718c*/ int get_marginBottom();
        /*0x13972ac*/ void ApplyOptions(UnityEngine.GUILayoutOption[] options);
        /*0x13973d0*/ void ApplyStyleSettings(UnityEngine.GUIStyle style);
        /*0x1397448*/ void ResetCursor();
        /*0x1397450*/ UnityEngine.GUILayoutEntry GetNext();
        /*0x1397780*/ void Add(UnityEngine.GUILayoutEntry e);
        /*0x1397828*/ void CalcWidth();
        /*0x1397fd0*/ void SetHorizontal(float x, float width);
        /*0x139878c*/ void CalcHeight();
        /*0x1398e18*/ void SetVertical(float y, float height);
        /*0x13995e4*/ string ToString();
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

        /*0x1399ad8*/ GUIScrollGroup();
        /*0x1399b34*/ void CalcWidth();
        /*0x1399bb0*/ void SetHorizontal(float x, float width);
        /*0x1399cd4*/ void CalcHeight();
        /*0x1399dd0*/ void SetVertical(float y, float height);
    }

    class GUIStateObjects
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<int, object> s_StateCache;

        static /*0x139a0f0*/ GUIStateObjects();
        static /*0x1399fe0*/ object GetStateObject(System.Type t, int controlID);
    }

    class GUIStyleState
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.GUIStyle m_SourceStyle;

        static /*0x139a204*/ nint Init();
        static /*0x139a2dc*/ UnityEngine.GUIStyleState GetGUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x139a268*/ GUIStyleState();
        /*0x139a2b0*/ GUIStyleState(UnityEngine.GUIStyle sourceStyle, nint source);
        /*0x139a17c*/ void set_background(UnityEngine.Texture2D value);
        /*0x1396bac*/ void set_textColor(UnityEngine.Color value);
        /*0x139a22c*/ void Cleanup();
        /*0x139a34c*/ void Finalize();
        /*0x139a1c0*/ void set_textColor_Injected(ref UnityEngine.Color value);
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

        static /*0x139c244*/ GUIStyle();
        static /*0x139a940*/ nint Internal_Create(UnityEngine.GUIStyle self);
        static /*0x139a97c*/ nint Internal_Copy(UnityEngine.GUIStyle self, UnityEngine.GUIStyle other);
        static /*0x139a9c0*/ void Internal_Destroy(nint self);
        static /*0x139aa84*/ float Internal_GetLineHeight(nint target);
        static /*0x139b414*/ void SetMouseTooltip(string tooltip, UnityEngine.Rect screenRect);
        static /*0x139b4e4*/ bool IsTooltipActive(string tooltip);
        static /*0x139b520*/ float Internal_GetCursorFlashOffset();
        static /*0x13958e0*/ void SetDefaultFont(UnityEngine.Font font);
        static /*0x13947dc*/ UnityEngine.GUIStyle get_none();
        static /*0x139b4a0*/ void SetMouseTooltip_Injected(string tooltip, ref UnityEngine.Rect screenRect);
        /*0x1395b7c*/ GUIStyle();
        /*0x139b548*/ GUIStyle(UnityEngine.GUIStyle other);
        /*0x139a444*/ string get_rawName();
        /*0x139a480*/ void set_rawName(string value);
        /*0x139a4c4*/ UnityEngine.Font get_font();
        /*0x139a500*/ void set_font(UnityEngine.Font value);
        /*0x139a544*/ UnityEngine.ImagePosition get_imagePosition();
        /*0x139a580*/ void set_alignment(UnityEngine.TextAnchor value);
        /*0x139a5c4*/ bool get_wordWrap();
        /*0x139a600*/ void set_wordWrap(bool value);
        /*0x139a644*/ void set_clipping(UnityEngine.TextClipping value);
        /*0x139a688*/ UnityEngine.Vector2 get_contentOffset();
        /*0x139a718*/ void set_contentOffset(UnityEngine.Vector2 value);
        /*0x1397f94*/ float get_fixedWidth();
        /*0x1398ddc*/ float get_fixedHeight();
        /*0x1397f58*/ bool get_stretchWidth();
        /*0x139a7a4*/ void set_stretchWidth(bool value);
        /*0x1398da0*/ bool get_stretchHeight();
        /*0x1396b0c*/ void set_stretchHeight(bool value);
        /*0x139a7e8*/ void set_fontSize(int value);
        /*0x139a82c*/ void set_fontStyle(UnityEngine.FontStyle value);
        /*0x139a870*/ void set_richText(bool value);
        /*0x139a8b4*/ void set_Internal_clipOffset(UnityEngine.Vector2 value);
        /*0x139a9fc*/ nint GetStyleStatePtr(int idx);
        /*0x139aa40*/ nint GetRectOffsetPtr(int idx);
        /*0x139aac0*/ void Internal_Draw(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x139abd0*/ void Internal_Draw2(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x139acb0*/ void Internal_DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int pos, UnityEngine.Color cursorColor);
        /*0x139ad94*/ void Internal_DrawWithTextSelection(UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, UnityEngine.Color cursorColor, UnityEngine.Color selectionColor);
        /*0x139af20*/ UnityEngine.Vector2 Internal_GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x139b000*/ int Internal_GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition);
        /*0x139b0c0*/ string Internal_GetSelectedRenderedText(UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex);
        /*0x139b1a0*/ UnityEngine.Vector2 Internal_CalcSize(UnityEngine.GUIContent content);
        /*0x139b250*/ UnityEngine.Vector2 Internal_CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 maxSize);
        /*0x139b310*/ float Internal_CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x139b364*/ UnityEngine.Vector2 Internal_CalcMinMaxWidth(UnityEngine.GUIContent content);
        /*0x139b628*/ void Finalize();
        /*0x1396ac0*/ string get_name();
        /*0x1395c04*/ void set_name(string value);
        /*0x1396b50*/ UnityEngine.GUIStyleState get_normal();
        /*0x139b76c*/ UnityEngine.RectOffset get_border();
        /*0x1393e50*/ UnityEngine.RectOffset get_margin();
        /*0x1397eb0*/ UnityEngine.RectOffset get_padding();
        /*0x139b814*/ float get_lineHeight();
        /*0x139b910*/ void Draw(UnityEngine.Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x139b9f4*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x139ba08*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID);
        /*0x139ba1c*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x139ba30*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on, bool hover);
        /*0x139b9d0*/ void Draw(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x139bad0*/ void DrawCursor(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int character);
        /*0x139bcb0*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, UnityEngine.Color selectionColor);
        /*0x139bed8*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition);
        /*0x139c024*/ void DrawWithTextSelection(UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter);
        /*0x139c02c*/ UnityEngine.Vector2 GetCursorPixelPosition(UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex);
        /*0x139c030*/ int GetCursorStringIndex(UnityEngine.Rect position, UnityEngine.GUIContent content, UnityEngine.Vector2 cursorPixelPosition);
        /*0x1393e4c*/ UnityEngine.Vector2 CalcSize(UnityEngine.GUIContent content);
        /*0x139c034*/ UnityEngine.Vector2 CalcSizeWithConstraints(UnityEngine.GUIContent content, UnityEngine.Vector2 constraints);
        /*0x139c038*/ float CalcHeight(UnityEngine.GUIContent content, float width);
        /*0x139c08c*/ bool get_isHeightDependantOnWidth();
        /*0x139c138*/ void CalcMinMaxWidth(UnityEngine.GUIContent content, ref float minWidth, ref float maxWidth);
        /*0x139c160*/ string ToString();
        /*0x139a6d4*/ void get_contentOffset_Injected(ref UnityEngine.Vector2 ret);
        /*0x139a760*/ void set_contentOffset_Injected(ref UnityEngine.Vector2 value);
        /*0x139a8fc*/ void set_Internal_clipOffset_Injected(ref UnityEngine.Vector2 value);
        /*0x139ab4c*/ void Internal_Draw_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus);
        /*0x139ac44*/ void Internal_Draw2_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int controlID, bool on);
        /*0x139ad28*/ void Internal_DrawCursor_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int pos, ref UnityEngine.Color cursorColor);
        /*0x139ae64*/ void Internal_DrawWithTextSelection_Injected(ref UnityEngine.Rect screenRect, UnityEngine.GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, int cursorFirst, int cursorLast, ref UnityEngine.Color cursorColor, ref UnityEngine.Color selectionColor);
        /*0x139af94*/ void Internal_GetCursorPixelPosition_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, int cursorStringIndex, ref UnityEngine.Vector2 ret);
        /*0x139b064*/ int Internal_GetCursorStringIndex_Injected(ref UnityEngine.Rect position, UnityEngine.GUIContent content, ref UnityEngine.Vector2 cursorPixelPosition);
        /*0x139b134*/ string Internal_GetSelectedRenderedText_Injected(ref UnityEngine.Rect localPosition, UnityEngine.GUIContent mContent, int selectIndex, int cursorIndex);
        /*0x139b1fc*/ void Internal_CalcSize_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
        /*0x139b2b4*/ void Internal_CalcSizeWithConstraints_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 maxSize, ref UnityEngine.Vector2 ret);
        /*0x139b3c0*/ void Internal_CalcMinMaxWidth_Injected(UnityEngine.GUIContent content, ref UnityEngine.Vector2 ret);
    }

    class ExitGUIException : System.Exception
    {
        /*0x139c290*/ ExitGUIException();
        /*0x139c324*/ ExitGUIException(string message);
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

    class GUILayoutOption
    {
        /*0x10*/ UnityEngine.GUILayoutOption.Type type;
        /*0x18*/ object value;

        /*0x1394718*/ GUILayoutOption(UnityEngine.GUILayoutOption.Type type, object value);

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
}

class <PrivateImplementationDetails>
{
    static /*0x139c3c8*/ uint ComputeStringHash(string s);
}
