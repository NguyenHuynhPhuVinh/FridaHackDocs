class <Module>
{
}

namespace UnityEngine
{
    namespace InputForUI
    {
        struct CommandEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ UnityEngine.InputForUI.CommandEvent.Type type;
            /*0x14*/ UnityEngine.InputForUI.CommandEvent.Command command;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x3e5f9c8*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x3e5f9d0*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e5f9d8*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x3e5f9e0*/ void set_playerId(uint value);
            /*0x3e5f9e8*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e5f9f0*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x3e5f9f8*/ string ToString();

            enum Type
            {
                Validate = 1,
                Execute = 2,
            }

            enum Command
            {
                Invalid = 0,
                Cut = 1,
                Copy = 2,
                Paste = 3,
                SelectAll = 4,
                DeselectAll = 5,
                InvertSelection = 6,
                Duplicate = 7,
                Rename = 8,
                Delete = 9,
                SoftDelete = 10,
                Find = 11,
                SelectChildren = 12,
                SelectPrefabRoot = 13,
                UndoRedoPerformed = 14,
                OnLostFocus = 15,
                NewKeyboardFocus = 16,
                ModifierKeysChanged = 17,
                EyeDropperUpdate = 18,
                EyeDropperClicked = 19,
                EyeDropperCancelled = 20,
                ColorPickerChanged = 21,
                FrameSelected = 22,
                FrameSelectedWithLock = 23,
            }
        }

        struct Event : UnityEngine.InputForUI.IEventProperties
        {
            static /*0x0*/ UnityEngine.InputForUI.Event.Type[] TypesWithState;
            /*0x10*/ UnityEngine.InputForUI.Event.Type _type;
            /*0x18*/ object _managedEvent;
            /*0x20*/ UnityEngine.InputForUI.KeyEvent _keyEvent;
            /*0x20*/ UnityEngine.InputForUI.PointerEvent _pointerEvent;
            /*0x20*/ UnityEngine.InputForUI.TextInputEvent _textInputEvent;
            /*0x20*/ UnityEngine.InputForUI.CommandEvent _commandEvent;
            /*0x20*/ UnityEngine.InputForUI.NavigationEvent _navigationEvent;

            static /*0x3e606c8*/ Event();
            static /*0x3e60090*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.KeyEvent keyEvent);
            static /*0x3e60190*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.PointerEvent pointerEvent);
            static /*0x3e60284*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.TextInputEvent textInputEvent);
            static /*0x3e60368*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.IMECompositionEvent imeCompositionEvent);
            static /*0x3e604e0*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.CommandEvent commandEvent);
            static /*0x3e605c4*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.NavigationEvent navigationEvent);
            /*0x3e5fab4*/ UnityEngine.InputForUI.Event.Type get_type();
            /*0x3e5fabc*/ UnityEngine.InputForUI.IEventProperties get_asObject();
            /*0x3e5fb3c*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e5fbbc*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e5fc3c*/ void Ensure(UnityEngine.InputForUI.Event.Type t);
            /*0x3e5fccc*/ string ToString();
            /*0x3e6011c*/ UnityEngine.InputForUI.KeyEvent get_asKeyEvent();
            /*0x3e60210*/ UnityEngine.InputForUI.PointerEvent get_asPointerEvent();
            /*0x3e602f8*/ UnityEngine.InputForUI.TextInputEvent get_asTextInputEvent();
            /*0x3e60430*/ UnityEngine.InputForUI.IMECompositionEvent get_asIMECompositionEvent();
            /*0x3e60554*/ UnityEngine.InputForUI.CommandEvent get_asCommandEvent();
            /*0x3e60650*/ UnityEngine.InputForUI.NavigationEvent get_asNavigationEvent();
            /*0x1ffc854*/ TOutputType Map<TOutputType, TMapType>(TMapType fn);
            /*0x1ffc854*/ TOutputType Map<TOutputType, TMapType>();

            enum Type
            {
                Invalid = 0,
                KeyEvent = 1,
                PointerEvent = 2,
                TextInputEvent = 3,
                IMECompositionEvent = 4,
                CommandEvent = 5,
                NavigationEvent = 6,
            }

            interface IMapFn<TOutputType>
            {
                /*0x1ffc854*/ TOutputType Map<TEventType>(ref TEventType ev);
            }

            struct MapAsObject : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.IEventProperties>
            {
                /*0x1f302cc*/ UnityEngine.InputForUI.IEventProperties Map<TEventType>(ref TEventType ev);
            }

            struct MapAsEventSource : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.EventSource>
            {
                /*0x1f3008c*/ UnityEngine.InputForUI.EventSource Map<TEventType>(ref TEventType ev);
            }

            struct MapAsEventModifiers : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.EventModifiers>
            {
                /*0x1ffc854*/ UnityEngine.InputForUI.EventModifiers Map<TEventType>(ref TEventType ev);
            }
        }

        struct EventModifiers
        {
            /*0x10*/ uint _state;

            static /*0x3e60800*/ void Append(ref string str, string value);
            /*0x3e60768*/ bool IsPressed(UnityEngine.InputForUI.EventModifiers.Modifiers mod);
            /*0x3e60778*/ bool get_isShiftPressed();
            /*0x3e60788*/ bool get_isCtrlPressed();
            /*0x3e60798*/ bool get_isAltPressed();
            /*0x3e607a8*/ bool get_isMetaPressed();
            /*0x3e607b8*/ bool get_isCapsLockEnabled();
            /*0x3e607c4*/ bool get_isFunctionKeyPressed();
            /*0x3e607d0*/ bool get_isNumericPressed();
            /*0x3e607dc*/ void SetPressed(UnityEngine.InputForUI.EventModifiers.Modifiers modifier, bool pressed);
            /*0x3e607f8*/ void Reset();
            /*0x3e5fe34*/ string ToString();

            enum Modifiers
            {
                LeftShift = 1,
                RightShift = 2,
                Shift = 3,
                LeftCtrl = 4,
                RightCtrl = 8,
                Ctrl = 12,
                LeftAlt = 16,
                RightAlt = 32,
                Alt = 48,
                LeftMeta = 64,
                RightMeta = 128,
                Meta = 192,
                CapsLock = 256,
                Numlock = 512,
                FunctionKey = 1024,
                Numeric = 2048,
            }
        }

        enum EventSource
        {
            Unspecified = 0,
            Keyboard = 1,
            Gamepad = 2,
            Mouse = 3,
            Pen = 4,
            Touch = 5,
        }

        interface IEventProperties
        {
            /*0x1f2ffc8*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x1ffc854*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
        }

        struct IMECompositionEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ string compositionString;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x3e60878*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x3e60880*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e60888*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x3e60890*/ void set_playerId(uint value);
            /*0x3e60898*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e608a0*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x3e608a8*/ string ToString();
        }

        struct KeyEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ UnityEngine.InputForUI.KeyEvent.Type type;
            /*0x14*/ UnityEngine.KeyCode keyCode;
            /*0x18*/ UnityEngine.InputForUI.KeyEvent.ButtonsState buttonsState;
            /*0x40*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x48*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x4c*/ uint <playerId>k__BackingField;
            /*0x50*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x3e60914*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x3e6091c*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e60924*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x3e6092c*/ void set_playerId(uint value);
            /*0x3e60934*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e6093c*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x3e60944*/ string ToString();

            enum Type
            {
                KeyPressed = 1,
                KeyRepeated = 2,
                KeyReleased = 3,
                State = 4,
            }

            struct ButtonsState
            {
                /*0x10*/ UnityEngine.InputForUI.KeyEvent.ButtonsState.<buttons> buttons;

                static /*0x3e60adc*/ bool ShouldBeProcessed(UnityEngine.KeyCode keyCode);
                /*0x3e60ae8*/ bool GetUnchecked(uint index);
                /*0x3e60b04*/ void SetUnchecked(uint index);
                /*0x3e60b28*/ void ClearUnchecked(uint index);
                /*0x3e60b4c*/ bool IsPressed(UnityEngine.KeyCode keyCode);
                /*0x3e60b78*/ System.Collections.Generic.IEnumerable<UnityEngine.KeyCode> GetAllPressed();
                /*0x3e60c30*/ void SetPressed(UnityEngine.KeyCode keyCode, bool pressed);
                /*0x3e60c68*/ void Reset();
                /*0x3e60dd4*/ string ToString();

                class <GetAllPressed>d__8 : System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x14*/ UnityEngine.KeyCode <>2__current;
                    /*0x18*/ int <>l__initialThreadId;
                    /*0x1c*/ UnityEngine.InputForUI.KeyEvent.ButtonsState <>4__this;
                    /*0x44*/ UnityEngine.InputForUI.KeyEvent.ButtonsState <>3__<>4__this;
                    /*0x6c*/ uint <index>5__1;

                    /*0x3e60bfc*/ <GetAllPressed>d__8(int <>1__state);
                    /*0x3e60e48*/ void System.IDisposable.Dispose();
                    /*0x3e60e4c*/ bool MoveNext();
                    /*0x3e60ec0*/ UnityEngine.KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current();
                    /*0x3e60ec8*/ void System.Collections.IEnumerator.Reset();
                    /*0x3e60f00*/ object System.Collections.IEnumerator.get_Current();
                    /*0x3e60f5c*/ System.Collections.Generic.IEnumerator<UnityEngine.KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator();
                    /*0x3e61008*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }

                struct <buttons>e__FixedBuffer
                {
                    /*0x10*/ byte FixedElementField;
                }
            }
        }

        struct NavigationEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ UnityEngine.InputForUI.NavigationEvent.Type type;
            /*0x14*/ UnityEngine.InputForUI.NavigationEvent.Direction direction;
            /*0x18*/ bool shouldBeUsed;
            /*0x20*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x2c*/ uint <playerId>k__BackingField;
            /*0x30*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            static /*0x3e611a8*/ UnityEngine.InputForUI.NavigationEvent.Direction DetermineMoveDirection(UnityEngine.Vector2 vec, float deadZone);
            /*0x3e6100c*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x3e61014*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e6101c*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x3e61024*/ void set_playerId(uint value);
            /*0x3e6102c*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e61034*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x3e6103c*/ string ToString();

            enum Type
            {
                Move = 1,
                Submit = 2,
                Cancel = 3,
            }

            enum Direction
            {
                None = 0,
                Left = 1,
                Up = 2,
                Right = 3,
                Down = 4,
                Next = 5,
                Previous = 6,
            }
        }

        struct PointerEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ UnityEngine.InputForUI.PointerEvent.Type type;
            /*0x14*/ int pointerIndex;
            /*0x18*/ UnityEngine.Vector2 position;
            /*0x20*/ UnityEngine.Vector2 deltaPosition;
            /*0x28*/ UnityEngine.Vector2 scroll;
            /*0x30*/ int displayIndex;
            /*0x34*/ UnityEngine.Vector2 tilt;
            /*0x3c*/ float twist;
            /*0x40*/ float pressure;
            /*0x44*/ bool isInverted;
            /*0x48*/ UnityEngine.InputForUI.PointerEvent.Button button;
            /*0x4c*/ UnityEngine.InputForUI.PointerEvent.ButtonsState buttonsState;
            /*0x50*/ int clickCount;
            /*0x58*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x60*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x64*/ uint <playerId>k__BackingField;
            /*0x68*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            static /*0x3e61f88*/ UnityEngine.InputForUI.PointerEvent.Button ButtonFromButtonIndex(int index);
            /*0x3e611fc*/ bool get_isPrimaryPointer();
            /*0x3e6120c*/ float get_azimuth();
            /*0x3e612bc*/ float get_altitude();
            /*0x3e61334*/ Unity.IntegerTime.DiscreteTime get_timestamp();
            /*0x3e6133c*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x3e61344*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e6134c*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x3e61354*/ void set_playerId(uint value);
            /*0x3e6135c*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e61364*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x3e6136c*/ string ToString();

            enum Type
            {
                PointerMoved = 1,
                Scroll = 2,
                ButtonPressed = 3,
                ButtonReleased = 4,
                State = 5,
                TouchCanceled = 6,
            }

            enum Button
            {
                None = 0,
                Primary = 1,
                FingerInTouch = 1,
                PenTipInTouch = 1,
                PenEraserInTouch = 2,
                PenBarrelButton = 4,
                MouseLeft = 1,
                MouseRight = 2,
                MouseMiddle = 4,
                MouseForward = 8,
                MouseBack = 16,
            }

            struct ButtonsState
            {
                /*0x10*/ uint _state;

                /*0x3e61f9c*/ void Set(UnityEngine.InputForUI.PointerEvent.Button button, bool pressed);
                /*0x3e61fb8*/ bool Get(UnityEngine.InputForUI.PointerEvent.Button button);
                /*0x3e61fc8*/ void Reset();
                /*0x3e61fd0*/ string ToString();
            }
        }

        struct TextInputEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ char character;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x3e62048*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x3e62050*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3e62058*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x3e62060*/ void set_playerId(uint value);
            /*0x3e62068*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x3e62070*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x3e62078*/ string ToString();
        }

        class EventProvider
        {
            static /*0x0*/ UnityEngine.InputForUI.IEventProviderImpl s_impl;
            static /*0x8*/ UnityEngine.InputForUI.EventSanitizer s_sanitizer;
            static /*0x10*/ UnityEngine.InputForUI.IEventProviderImpl s_implMockBackup;
            static /*0x18*/ bool s_focusChangedRegistered;
            static /*0x19*/ bool m_IsEnabled;
            static /*0x1a*/ bool m_IsInitialized;
            static /*0x20*/ System.Collections.Generic.List<UnityEngine.InputForUI.EventProvider.Registration> _registrations;

            static /*0x3e631f8*/ EventProvider();
            static /*0x3e62130*/ void Subscribe(UnityEngine.InputForUI.EventConsumer handler, int priority, System.Nullable<int> playerId, UnityEngine.InputForUI.Event.Type[] type);
            static /*0x3e623b8*/ void Unsubscribe(UnityEngine.InputForUI.EventConsumer handler);
            static /*0x3e624cc*/ void SetEnabled(bool enable);
            static /*0x3e628c0*/ void Dispatch(ref UnityEngine.InputForUI.Event ev);
            static /*0x3e62344*/ void Bootstrap();
            static /*0x3e6255c*/ void Initialize();
            static /*0x3e62720*/ void Shutdown();
            static /*0x3e62da8*/ void OnFocusChanged(bool focus);
            static /*0x3e62e84*/ void NotifyUpdate();

            struct Registration
            {
                /*0x10*/ UnityEngine.InputForUI.EventConsumer handler;
                /*0x18*/ int priority;
                /*0x1c*/ System.Nullable<int> playerId;
                /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.InputForUI.Event.Type> _types;
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.InputForUI.EventProvider.<> <>9;
                static /*0x8*/ System.Comparison<UnityEngine.InputForUI.EventProvider.Registration> <>9__5_0;

                static /*0x3e63478*/ <>c();
                /*0x3e634e0*/ <>c();
                /*0x3e634e8*/ int <Subscribe>b__5_0(UnityEngine.InputForUI.EventProvider.Registration a, UnityEngine.InputForUI.EventProvider.Registration b);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.InputForUI.EventConsumer handler;

                /*0x3e624c4*/ <>c__DisplayClass6_0();
                /*0x3e634fc*/ bool <Unsubscribe>b__0(UnityEngine.InputForUI.EventProvider.Registration x);
            }
        }

        class EventConsumer : System.MulticastDelegate
        {
            /*0x3e63510*/ EventConsumer(object object, nint method);
            /*0x3e635c0*/ bool Invoke(ref UnityEngine.InputForUI.Event ev);
        }

        interface IEventProviderImpl
        {
            /*0x1f309e4*/ void Initialize();
            /*0x1f309e4*/ void Shutdown();
            /*0x1f309e4*/ void Update();
            /*0x1f30a84*/ void OnFocusChanged(bool focus);
        }

        class InputEventPartialProvider : UnityEngine.InputForUI.IEventProviderImpl
        {
            /*0x10*/ UnityEngine.Event _ev;
            /*0x18*/ UnityEngine.OperatingSystemFamily _operatingSystemFamily;
            /*0x1c*/ UnityEngine.InputForUI.KeyEvent.ButtonsState _keyboardButtonsState;
            /*0x44*/ UnityEngine.InputForUI.EventModifiers _eventModifiers;
            /*0x48*/ bool _sendNavigationEventOnTabKey;
            /*0x50*/ System.Collections.Generic.IDictionary<string, UnityEngine.InputForUI.CommandEvent.Command> _IMGUICommandToInputForUICommandType;

            /*0x3e64434*/ InputEventPartialProvider();
            /*0x3e635d4*/ void Initialize();
            /*0x3e63760*/ void Shutdown();
            /*0x3e63764*/ void Update();
            /*0x3e642a4*/ void OnFocusChanged(bool focus);
            /*0x3e6441c*/ Unity.IntegerTime.DiscreteTime GetTimestamp(ref UnityEngine.Event ev);
            /*0x3e63a2c*/ void UpdateEventModifiers(ref UnityEngine.Event ev);
            /*0x3e63d8c*/ UnityEngine.InputForUI.KeyEvent ToKeyEvent(ref UnityEngine.Event ev);
            /*0x3e64090*/ UnityEngine.InputForUI.TextInputEvent ToTextInputEvent(ref UnityEngine.Event ev);
            /*0x3e63f14*/ void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(ref UnityEngine.Event ev);
            /*0x3e640f8*/ UnityEngine.InputForUI.CommandEvent ToCommandEvent(ref UnityEngine.Event ev);
        }

        class InputManagerProvider : UnityEngine.InputForUI.IEventProviderImpl
        {
            /*0x10*/ UnityEngine.InputForUI.InputEventPartialProvider _inputEventPartialProvider;
            /*0x18*/ string _compositionString;
            /*0x20*/ UnityEngine.InputForUI.InputManagerProvider.Configuration _configuration;
            /*0x58*/ UnityEngine.InputForUI.InputManagerProvider.IInput _input;
            /*0x60*/ UnityEngine.InputForUI.InputManagerProvider.ITime _time;
            /*0x68*/ UnityEngine.InputForUI.NavigationEventRepeatHelper _navigationEventRepeatHelper;
            /*0x70*/ UnityEngine.InputForUI.PointerState _mouseState;
            /*0x98*/ bool _isPenPresent;
            /*0x99*/ bool _seenAtLeastOnePenPosition;
            /*0x9c*/ UnityEngine.Vector2 _lastSeenPenPositionForDetection;
            /*0xa8*/ UnityEngine.InputForUI.PointerState _penState;
            /*0xd0*/ UnityEngine.PenData _lastPenData;
            /*0xf8*/ System.Collections.Generic.Dictionary<int, int> _touchFingerIdToFingerIndex;
            /*0x100*/ int _touchNextFingerIndex;
            /*0x108*/ UnityEngine.InputForUI.PointerState _touchState;

            static /*0x3e67150*/ UnityEngine.InputForUI.PointerEvent.Button PenStatusToButton(UnityEngine.PenStatus status);
            static /*0x3e61214*/ float TiltToAzimuth(UnityEngine.Vector2 tilt);
            static /*0x3e670d8*/ UnityEngine.Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth);
            static /*0x3e612f8*/ float TiltToAltitude(UnityEngine.Vector2 tilt);
            static /*0x3e66dfc*/ UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, ref int targetDisplay);
            static /*0x3e67be8*/ UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x3e67d4c*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
            static /*0x3e66ef8*/ UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta);
            /*0x3e632ec*/ InputManagerProvider();
            /*0x3e64984*/ UnityEngine.InputForUI.EventModifiers get__eventModifiers();
            /*0x3e64c44*/ void Initialize();
            /*0x3e64f90*/ void Shutdown();
            /*0x3e64f94*/ void Update();
            /*0x3e65424*/ bool CheckTouchEvents(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x3e65328*/ void DetectPen();
            /*0x3e65a30*/ bool CheckPenEvent(Unity.IntegerTime.DiscreteTime currentTime, ref UnityEngine.PenData currentPenData);
            /*0x3e65dd0*/ void CheckMouseEvents(Unity.IntegerTime.DiscreteTime currentTime, bool muted);
            /*0x3e66410*/ void CheckMouseScroll(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x3e66c8c*/ void NextPreviousNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x3e66ab4*/ void SubmitCancelNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x3e668d0*/ void DirectionNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x3e66734*/ void CheckIfIMEChanged(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x3e6776c*/ void OnFocusChanged(bool focus);
            /*0x3e67468*/ UnityEngine.InputForUI.EventSource GetEventSourceFromPressedKey();
            /*0x3e679d0*/ bool InputManagerJoystickWasPressed();
            /*0x3e678f8*/ bool InputManagerKeyboardWasPressed();
            /*0x3e67aa8*/ float InputManagerGetAxisRawOrDefault(string axisName);
            /*0x3e67324*/ bool InputManagerGetButtonDownOrDefault(string axisName);
            /*0x3e6749c*/ System.ValueTuple<UnityEngine.Vector2, bool> ReadCurrentNavigationMoveVector();
            /*0x3e6770c*/ UnityEngine.InputForUI.IMECompositionEvent ToIMECompositionEvent(Unity.IntegerTime.DiscreteTime currentTime, string compositionString);

            struct ButtonEventsIterator : System.Collections.IEnumerator
            {
                /*0x10*/ uint _mask;
                /*0x14*/ int _bit;

                static /*0x3e671e8*/ UnityEngine.InputForUI.InputManagerProvider.ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current);
                /*0x3e67208*/ bool get_Current();
                /*0x3e672f0*/ bool MoveNext();
                /*0x3e67e30*/ void Reset();
                /*0x3e67e3c*/ object System.Collections.IEnumerator.get_Current();
            }

            struct Configuration
            {
                /*0x10*/ string HorizontalAxis;
                /*0x18*/ string VerticalAxis;
                /*0x20*/ string SubmitButton;
                /*0x28*/ string CancelButton;
                /*0x30*/ string NavigateNextButton;
                /*0x38*/ string NavigatePreviousButton;
                /*0x40*/ float InputActionsPerSecond;
                /*0x44*/ float RepeatDelay;

                static /*0x3e6499c*/ UnityEngine.InputForUI.InputManagerProvider.Configuration GetDefaultConfiguration();
            }

            interface IInput
            {
                /*0x1f30214*/ string get_compositionString();
                /*0x1f2fe40*/ bool GetKey(UnityEngine.KeyCode keyCode);
                /*0x1f2fec8*/ bool GetButtonDown(string button);
                float GetAxisRaw(string axis);
                UnityEngine.PenData GetLastPenContactEvent();
                /*0x1f2fe14*/ bool get_touchSupported();
                /*0x1f2ffc8*/ int get_touchCount();
                UnityEngine.Touch GetTouch(int index);
                /*0x1f2fe14*/ bool get_mousePresent();
                /*0x1f2fe40*/ bool GetMouseButton(int button);
                /*0x1f2fe40*/ bool GetMouseButtonDown(int button);
                /*0x1f2fe40*/ bool GetMouseButtonUp(int button);
                UnityEngine.Vector3 get_mousePosition();
                UnityEngine.Vector2 get_mouseScrollDelta();
            }

            class Input : UnityEngine.InputForUI.InputManagerProvider.IInput
            {
                /*0x3e64af8*/ Input();
                /*0x3e67e6c*/ string get_compositionString();
                /*0x3e67e74*/ bool GetKey(UnityEngine.KeyCode key);
                /*0x3e67e80*/ bool GetButtonDown(string button);
                /*0x3e67e8c*/ float GetAxisRaw(string axis);
                /*0x3e67e98*/ UnityEngine.PenData GetLastPenContactEvent();
                /*0x3e67ed0*/ bool get_touchSupported();
                /*0x3e67ed8*/ int get_touchCount();
                /*0x3e67ee0*/ UnityEngine.Touch GetTouch(int index);
                /*0x3e67f18*/ bool get_mousePresent();
                /*0x3e67f20*/ bool GetMouseButton(int button);
                /*0x3e67f2c*/ bool GetMouseButtonDown(int button);
                /*0x3e67f38*/ bool GetMouseButtonUp(int button);
                /*0x3e67f44*/ UnityEngine.Vector3 get_mousePosition();
                /*0x3e67f4c*/ UnityEngine.Vector2 get_mouseScrollDelta();
            }

            interface ITime
            {
                Unity.IntegerTime.RationalTime get_timeAsRational();
            }

            class Time : UnityEngine.InputForUI.InputManagerProvider.ITime
            {
                /*0x3e64b00*/ Time();
                /*0x3e67f54*/ Unity.IntegerTime.RationalTime get_timeAsRational();
            }
        }

        class NavigationEventRepeatHelper
        {
            /*0x10*/ int m_ConsecutiveMoveCount;
            /*0x14*/ UnityEngine.InputForUI.NavigationEvent.Direction m_LastDirection;
            /*0x18*/ Unity.IntegerTime.DiscreteTime m_PrevActionTime;
            /*0x20*/ Unity.IntegerTime.DiscreteTime m_InitialRepeatDelay;
            /*0x28*/ Unity.IntegerTime.DiscreteTime m_ConsecutiveRepeatDelay;

            /*0x3e64b08*/ NavigationEventRepeatHelper();
            /*0x3e675a4*/ void Reset();
            /*0x3e67608*/ bool ShouldSendMoveEvent(Unity.IntegerTime.DiscreteTime timestamp, UnityEngine.InputForUI.NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame);
        }

        struct PointerState
        {
            static /*0x0*/ Unity.IntegerTime.DiscreteTime kClickDelay;
            /*0x10*/ UnityEngine.InputForUI.PointerEvent.Button <LastPressedButton>k__BackingField;
            /*0x14*/ UnityEngine.InputForUI.PointerEvent.ButtonsState _buttonsState;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <NextPressTime>k__BackingField;
            /*0x20*/ int <ClickCount>k__BackingField;
            /*0x24*/ UnityEngine.Vector2 <LastPosition>k__BackingField;
            /*0x2c*/ int <LastDisplayIndex>k__BackingField;
            /*0x30*/ bool <LastPositionValid>k__BackingField;

            static /*0x3e67fc4*/ PointerState();
            /*0x3e67f5c*/ UnityEngine.InputForUI.PointerEvent.Button get_LastPressedButton();
            /*0x3e67f64*/ void set_LastPressedButton(UnityEngine.InputForUI.PointerEvent.Button value);
            /*0x3e67f6c*/ UnityEngine.InputForUI.PointerEvent.ButtonsState get_ButtonsState();
            /*0x3e67f74*/ Unity.IntegerTime.DiscreteTime get_NextPressTime();
            /*0x3e67f7c*/ void set_NextPressTime(Unity.IntegerTime.DiscreteTime value);
            /*0x3e67f84*/ int get_ClickCount();
            /*0x3e67f8c*/ void set_ClickCount(int value);
            /*0x3e67f94*/ UnityEngine.Vector2 get_LastPosition();
            /*0x3e67f9c*/ void set_LastPosition(UnityEngine.Vector2 value);
            /*0x3e67fa4*/ int get_LastDisplayIndex();
            /*0x3e67fac*/ void set_LastDisplayIndex(int value);
            /*0x3e67fb4*/ bool get_LastPositionValid();
            /*0x3e67fbc*/ void set_LastPositionValid(bool value);
            /*0x3e66f00*/ void OnButtonDown(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button);
            /*0x3e6704c*/ void OnButtonUp(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button);
            /*0x3e67218*/ void OnButtonChange(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button, bool previousState, bool newState);
            /*0x3e6716c*/ void OnMove(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.Vector2 position, int displayIndex);
            /*0x3e64ec4*/ void Reset();
        }

        struct EventSanitizer
        {
            /*0x10*/ UnityEngine.InputForUI.EventSanitizer.IEventSanitizer[] _sanitizers;

            /*0x3e62c94*/ void Reset();
            /*0x3e63008*/ void BeforeProviderUpdate();
            /*0x3e63100*/ void AfterProviderUpdate();
            /*0x3e62b94*/ void Inspect(ref UnityEngine.InputForUI.Event ev);

            interface IEventSanitizer
            {
                /*0x1f309e4*/ void Reset();
                /*0x1f309e4*/ void BeforeProviderUpdate();
                /*0x1f309e4*/ void AfterProviderUpdate();
                /*0x1f30ebc*/ void Inspect(ref UnityEngine.InputForUI.Event ev);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137;

    struct __StaticArrayInitTypeSize=12
    {
    }
}
