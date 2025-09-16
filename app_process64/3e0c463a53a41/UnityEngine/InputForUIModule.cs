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

            /*0x7ee0f68*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee0f70*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee0f78*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ee0f80*/ void set_playerId(uint value);
            /*0x7ee0f88*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee0f90*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ee0f98*/ string ToString();

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

            static /*0x7ee1d2c*/ Event();
            static /*0x7ee1054*/ int CompareType(UnityEngine.InputForUI.Event a, UnityEngine.InputForUI.Event b);
            static /*0x7ee16e0*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.KeyEvent keyEvent);
            static /*0x7ee17e0*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.PointerEvent pointerEvent);
            static /*0x7ee18e0*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.TextInputEvent textInputEvent);
            static /*0x7ee19c8*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.IMECompositionEvent imeCompositionEvent);
            static /*0x7ee1b40*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.CommandEvent commandEvent);
            static /*0x7ee1c28*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.NavigationEvent navigationEvent);
            /*0x7ee11a4*/ UnityEngine.InputForUI.Event.Type get_type();
            /*0x7ee11ac*/ UnityEngine.InputForUI.IEventProperties get_asObject();
            /*0x7ee1138*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee1218*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee128c*/ void Ensure(UnityEngine.InputForUI.Event.Type t);
            /*0x7ee131c*/ string ToString();
            /*0x7ee1768*/ UnityEngine.InputForUI.KeyEvent get_asKeyEvent();
            /*0x7ee1868*/ UnityEngine.InputForUI.PointerEvent get_asPointerEvent();
            /*0x7ee1958*/ UnityEngine.InputForUI.TextInputEvent get_asTextInputEvent();
            /*0x7ee1a90*/ UnityEngine.InputForUI.IMECompositionEvent get_asIMECompositionEvent();
            /*0x7ee1bb8*/ UnityEngine.InputForUI.CommandEvent get_asCommandEvent();
            /*0x7ee1cb4*/ UnityEngine.InputForUI.NavigationEvent get_asNavigationEvent();
            /*0x3907c14*/ TOutputType Map<TOutputType, TMapType>(TMapType fn);
            /*0x3907c14*/ TOutputType Map<TOutputType, TMapType>();

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
                /*0x3907c14*/ TOutputType Map<TEventType>(ref TEventType ev);
            }

            struct MapAsObject : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.IEventProperties>
            {
                /*0x380bb68*/ UnityEngine.InputForUI.IEventProperties Map<TEventType>(ref TEventType ev);
            }

            struct MapAsEventSource : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.EventSource>
            {
                /*0x380b7a8*/ UnityEngine.InputForUI.EventSource Map<TEventType>(ref TEventType ev);
            }

            struct MapAsEventModifiers : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.EventModifiers>
            {
                /*0x3907c14*/ UnityEngine.InputForUI.EventModifiers Map<TEventType>(ref TEventType ev);
            }
        }

        struct EventModifiers
        {
            /*0x10*/ uint _state;

            static /*0x7ee1e64*/ void Append(ref string str, string value);
            /*0x7ee1dcc*/ bool IsPressed(UnityEngine.InputForUI.EventModifiers.Modifiers mod);
            /*0x7ee1ddc*/ bool get_isShiftPressed();
            /*0x7ee1dec*/ bool get_isCtrlPressed();
            /*0x7ee1dfc*/ bool get_isAltPressed();
            /*0x7ee1e0c*/ bool get_isMetaPressed();
            /*0x7ee1e1c*/ bool get_isCapsLockEnabled();
            /*0x7ee1e28*/ bool get_isFunctionKeyPressed();
            /*0x7ee1e34*/ bool get_isNumericPressed();
            /*0x7ee1e40*/ void SetPressed(UnityEngine.InputForUI.EventModifiers.Modifiers modifier, bool pressed);
            /*0x7ee1e5c*/ void Reset();
            /*0x7ee1484*/ string ToString();

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
            /*0x380b6a0*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3907c14*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
        }

        struct IMECompositionEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ string compositionString;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x7ee1edc*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee1ee4*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee1eec*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ee1ef4*/ void set_playerId(uint value);
            /*0x7ee1efc*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee1f04*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ee1f0c*/ string ToString();
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

            /*0x7ee1f78*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee1f80*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee1f88*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ee1f90*/ void set_playerId(uint value);
            /*0x7ee1f98*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee1fa0*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ee1fa8*/ string ToString();

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

                static /*0x7ee2134*/ bool ShouldBeProcessed(UnityEngine.KeyCode keyCode);
                /*0x7ee2140*/ bool GetUnchecked(uint index);
                /*0x7ee215c*/ void SetUnchecked(uint index);
                /*0x7ee2180*/ void ClearUnchecked(uint index);
                /*0x7ee21a4*/ bool IsPressed(UnityEngine.KeyCode keyCode);
                /*0x7ee21d0*/ System.Collections.Generic.IEnumerable<UnityEngine.KeyCode> GetAllPressed();
                /*0x7ee2284*/ void SetPressed(UnityEngine.KeyCode keyCode, bool pressed);
                /*0x7ee22bc*/ void Reset();
                /*0x7ee231c*/ string ToString();

                class <GetAllPressed>d__8 : System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x14*/ UnityEngine.KeyCode <>2__current;
                    /*0x18*/ int <>l__initialThreadId;
                    /*0x1c*/ UnityEngine.InputForUI.KeyEvent.ButtonsState <>4__this;
                    /*0x44*/ UnityEngine.InputForUI.KeyEvent.ButtonsState <>3__<>4__this;
                    /*0x6c*/ uint <index>5__1;

                    /*0x7ee2250*/ <GetAllPressed>d__8(int <>1__state);
                    /*0x7ee2390*/ void System.IDisposable.Dispose();
                    /*0x7ee2394*/ bool MoveNext();
                    /*0x7ee2408*/ UnityEngine.KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current();
                    /*0x7ee2410*/ void System.Collections.IEnumerator.Reset();
                    /*0x7ee2448*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7ee24a4*/ System.Collections.Generic.IEnumerator<UnityEngine.KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator();
                    /*0x7ee2580*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7ee2720*/ UnityEngine.InputForUI.NavigationEvent.Direction DetermineMoveDirection(UnityEngine.Vector2 vec, float deadZone);
            /*0x7ee2584*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee258c*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee2594*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ee259c*/ void set_playerId(uint value);
            /*0x7ee25a4*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee25ac*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ee25b4*/ string ToString();

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

            static /*0x7ee34fc*/ UnityEngine.InputForUI.PointerEvent.Button ButtonFromButtonIndex(int index);
            /*0x7ee2774*/ bool get_isPrimaryPointer();
            /*0x7ee2784*/ float get_azimuth();
            /*0x7ee2838*/ float get_altitude();
            /*0x7ee28b0*/ Unity.IntegerTime.DiscreteTime get_timestamp();
            /*0x7ee28b8*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee28c0*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee28c8*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ee28d0*/ void set_playerId(uint value);
            /*0x7ee28d8*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee28e0*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ee28e8*/ string ToString();

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

                /*0x7ee3510*/ void Set(UnityEngine.InputForUI.PointerEvent.Button button, bool pressed);
                /*0x7ee352c*/ bool Get(UnityEngine.InputForUI.PointerEvent.Button button);
                /*0x7ee353c*/ void Reset();
                /*0x7ee3544*/ string ToString();
            }
        }

        struct TextInputEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ char character;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x7ee35bc*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee35c4*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ee35cc*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ee35d4*/ void set_playerId(uint value);
            /*0x7ee35dc*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ee35e4*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ee35ec*/ string ToString();
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

            static /*0x7ee4808*/ EventProvider();
            static /*0x7ee36a4*/ void Subscribe(UnityEngine.InputForUI.EventConsumer handler, int priority, System.Nullable<int> playerId, UnityEngine.InputForUI.Event.Type[] type);
            static /*0x7ee3990*/ void Unsubscribe(UnityEngine.InputForUI.EventConsumer handler);
            static /*0x7ee3aa4*/ void SetEnabled(bool enable);
            static /*0x7ee3ea4*/ void Dispatch(ref UnityEngine.InputForUI.Event ev);
            static /*0x7ee391c*/ void Bootstrap();
            static /*0x7ee3b40*/ void Initialize();
            static /*0x7ee3d04*/ void Shutdown();
            static /*0x7ee431c*/ void OnFocusChanged(bool focus);
            static /*0x7ee43f8*/ void NotifyUpdate();
            static /*0x7ee476c*/ void SetInputSystemProvider(UnityEngine.InputForUI.IEventProviderImpl impl);

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

                static /*0x7ee4a88*/ <>c();
                /*0x7ee4af0*/ <>c();
                /*0x7ee4af8*/ int <Subscribe>b__5_0(UnityEngine.InputForUI.EventProvider.Registration a, UnityEngine.InputForUI.EventProvider.Registration b);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.InputForUI.EventConsumer handler;

                /*0x7ee3a9c*/ <>c__DisplayClass6_0();
                /*0x7ee4b0c*/ bool <Unsubscribe>b__0(UnityEngine.InputForUI.EventProvider.Registration x);
            }
        }

        class EventConsumer : System.MulticastDelegate
        {
            /*0x7ee4b20*/ EventConsumer(object object, nint method);
            /*0x7ee4bd0*/ bool Invoke(ref UnityEngine.InputForUI.Event ev);
        }

        interface IEventProviderImpl
        {
            /*0x380cb08*/ void Initialize();
            /*0x380cb08*/ void Shutdown();
            /*0x380cb08*/ void Update();
            /*0x380cdf0*/ void OnFocusChanged(bool focus);
        }

        class InputEventPartialProvider : UnityEngine.InputForUI.IEventProviderImpl
        {
            /*0x10*/ UnityEngine.Event _ev;
            /*0x18*/ UnityEngine.OperatingSystemFamily _operatingSystemFamily;
            /*0x1c*/ UnityEngine.InputForUI.KeyEvent.ButtonsState _keyboardButtonsState;
            /*0x44*/ UnityEngine.InputForUI.EventModifiers _eventModifiers;
            /*0x48*/ bool _sendNavigationEventOnTabKey;
            /*0x50*/ System.Collections.Generic.IDictionary<string, UnityEngine.InputForUI.CommandEvent.Command> _IMGUICommandToInputForUICommandType;

            /*0x7ee5814*/ InputEventPartialProvider();
            /*0x7ee4be4*/ void Initialize();
            /*0x7ee4c60*/ void Shutdown();
            /*0x7ee4c64*/ void Update();
            /*0x7ee5794*/ void OnFocusChanged(bool focus);
            /*0x7ee57fc*/ Unity.IntegerTime.DiscreteTime GetTimestamp(ref UnityEngine.Event ev);
            /*0x7ee4f20*/ void UpdateEventModifiers(ref UnityEngine.Event ev);
            /*0x7ee5244*/ UnityEngine.InputForUI.KeyEvent ToKeyEvent(ref UnityEngine.Event ev);
            /*0x7ee5568*/ UnityEngine.InputForUI.TextInputEvent ToTextInputEvent(ref UnityEngine.Event ev);
            /*0x7ee53fc*/ void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(ref UnityEngine.Event ev);
            /*0x7ee55e8*/ UnityEngine.InputForUI.CommandEvent ToCommandEvent(ref UnityEngine.Event ev);
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

            static /*0x7ee832c*/ UnityEngine.InputForUI.PointerEvent.Button PenStatusToButton(UnityEngine.PenStatus status);
            static /*0x7ee278c*/ float TiltToAzimuth(UnityEngine.Vector2 tilt);
            static /*0x7ee82b8*/ UnityEngine.Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth);
            static /*0x7ee2874*/ float TiltToAltitude(UnityEngine.Vector2 tilt);
            static /*0x7ee8078*/ UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, ref int targetDisplay);
            static /*0x7ee8cac*/ UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x7ee8e00*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
            static /*0x7ee80dc*/ UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta);
            /*0x7ee48fc*/ InputManagerProvider();
            /*0x7ee5ca0*/ UnityEngine.InputForUI.EventModifiers get__eventModifiers();
            /*0x7ee5f6c*/ void Initialize();
            /*0x7ee61ac*/ void Shutdown();
            /*0x7ee61b0*/ void Update();
            /*0x7ee6650*/ bool CheckTouchEvents(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7ee654c*/ void DetectPen();
            /*0x7ee6c20*/ bool CheckPenEvent(Unity.IntegerTime.DiscreteTime currentTime, ref UnityEngine.PenData currentPenData);
            /*0x7ee6fe8*/ void CheckMouseEvents(Unity.IntegerTime.DiscreteTime currentTime, bool muted);
            /*0x7ee7678*/ void CheckMouseScroll(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7ee7f04*/ void NextPreviousNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7ee7d3c*/ void SubmitCancelNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7ee7b80*/ void DirectionNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7ee79bc*/ void CheckIfIMEChanged(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7ee8940*/ void OnFocusChanged(bool focus);
            /*0x7ee8648*/ UnityEngine.InputForUI.EventSource GetEventSourceFromPressedKey();
            /*0x7ee8a94*/ bool InputManagerJoystickWasPressed();
            /*0x7ee89bc*/ bool InputManagerKeyboardWasPressed();
            /*0x7ee8b6c*/ float InputManagerGetAxisRawOrDefault(string axisName);
            /*0x7ee8504*/ bool InputManagerGetButtonDownOrDefault(string axisName);
            /*0x7ee8680*/ System.ValueTuple<UnityEngine.Vector2, bool> ReadCurrentNavigationMoveVector();
            /*0x7ee88e0*/ UnityEngine.InputForUI.IMECompositionEvent ToIMECompositionEvent(Unity.IntegerTime.DiscreteTime currentTime, string compositionString);

            struct ButtonEventsIterator : System.Collections.IEnumerator
            {
                /*0x10*/ uint _mask;
                /*0x14*/ int _bit;

                static /*0x7ee83c4*/ UnityEngine.InputForUI.InputManagerProvider.ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current);
                /*0x7ee83e8*/ bool get_Current();
                /*0x7ee84d0*/ bool MoveNext();
                /*0x7ee8ee4*/ void Reset();
                /*0x7ee8ef0*/ object System.Collections.IEnumerator.get_Current();
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

                static /*0x7ee5cbc*/ UnityEngine.InputForUI.InputManagerProvider.Configuration GetDefaultConfiguration();
            }

            interface IInput
            {
                /*0x380b9e8*/ string get_compositionString();
                /*0x380b228*/ bool GetKey(UnityEngine.KeyCode keyCode);
                /*0x380b2f0*/ bool GetButtonDown(string button);
                float GetAxisRaw(string axis);
                UnityEngine.PenData GetLastPenContactEvent();
                /*0x380b128*/ bool get_touchSupported();
                /*0x380b6a0*/ int get_touchCount();
                UnityEngine.Touch GetTouch(int index);
                /*0x380b128*/ bool get_mousePresent();
                /*0x380b228*/ bool GetMouseButton(int button);
                /*0x380b228*/ bool GetMouseButtonDown(int button);
                /*0x380b228*/ bool GetMouseButtonUp(int button);
                /*0x380cad0*/ UnityEngine.Vector3 get_mousePosition();
                UnityEngine.Vector2 get_mouseScrollDelta();
            }

            class Input : UnityEngine.InputForUI.InputManagerProvider.IInput
            {
                /*0x7ee5e20*/ Input();
                /*0x7ee8f20*/ string get_compositionString();
                /*0x7ee8f28*/ bool GetKey(UnityEngine.KeyCode key);
                /*0x7ee8f34*/ bool GetButtonDown(string button);
                /*0x7ee8f40*/ float GetAxisRaw(string axis);
                /*0x7ee8f4c*/ UnityEngine.PenData GetLastPenContactEvent();
                /*0x7ee8f84*/ bool get_touchSupported();
                /*0x7ee8f8c*/ int get_touchCount();
                /*0x7ee8f94*/ UnityEngine.Touch GetTouch(int index);
                /*0x7ee8fcc*/ bool get_mousePresent();
                /*0x7ee8fd4*/ bool GetMouseButton(int button);
                /*0x7ee8fe0*/ bool GetMouseButtonDown(int button);
                /*0x7ee8fec*/ bool GetMouseButtonUp(int button);
                /*0x7ee8ff8*/ UnityEngine.Vector3 get_mousePosition();
                /*0x7ee9000*/ UnityEngine.Vector2 get_mouseScrollDelta();
            }

            interface ITime
            {
                Unity.IntegerTime.RationalTime get_timeAsRational();
            }

            class Time : UnityEngine.InputForUI.InputManagerProvider.ITime
            {
                /*0x7ee5e28*/ Time();
                /*0x7ee9008*/ Unity.IntegerTime.RationalTime get_timeAsRational();
            }
        }

        class NavigationEventRepeatHelper
        {
            /*0x10*/ int m_ConsecutiveMoveCount;
            /*0x14*/ UnityEngine.InputForUI.NavigationEvent.Direction m_LastDirection;
            /*0x18*/ Unity.IntegerTime.DiscreteTime m_PrevActionTime;
            /*0x20*/ Unity.IntegerTime.DiscreteTime m_InitialRepeatDelay;
            /*0x28*/ Unity.IntegerTime.DiscreteTime m_ConsecutiveRepeatDelay;

            /*0x7ee5e30*/ NavigationEventRepeatHelper();
            /*0x7ee8778*/ void Reset();
            /*0x7ee87dc*/ bool ShouldSendMoveEvent(Unity.IntegerTime.DiscreteTime timestamp, UnityEngine.InputForUI.NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame);
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

            static /*0x7ee907c*/ PointerState();
            /*0x7ee9010*/ UnityEngine.InputForUI.PointerEvent.Button get_LastPressedButton();
            /*0x7ee9018*/ void set_LastPressedButton(UnityEngine.InputForUI.PointerEvent.Button value);
            /*0x7ee9020*/ UnityEngine.InputForUI.PointerEvent.ButtonsState get_ButtonsState();
            /*0x7ee9028*/ Unity.IntegerTime.DiscreteTime get_NextPressTime();
            /*0x7ee9030*/ void set_NextPressTime(Unity.IntegerTime.DiscreteTime value);
            /*0x7ee9038*/ int get_ClickCount();
            /*0x7ee9040*/ void set_ClickCount(int value);
            /*0x7ee9048*/ UnityEngine.Vector2 get_LastPosition();
            /*0x7ee9050*/ void set_LastPosition(UnityEngine.Vector2 value);
            /*0x7ee9058*/ int get_LastDisplayIndex();
            /*0x7ee9060*/ void set_LastDisplayIndex(int value);
            /*0x7ee9068*/ bool get_LastPositionValid();
            /*0x7ee9070*/ void set_LastPositionValid(bool value);
            /*0x7ee80e4*/ void OnButtonDown(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button);
            /*0x7ee822c*/ void OnButtonUp(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button);
            /*0x7ee83f8*/ void OnButtonChange(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button, bool previousState, bool newState);
            /*0x7ee8348*/ void OnMove(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.Vector2 position, int displayIndex);
            /*0x7ee60e0*/ void Reset();
        }

        struct EventSanitizer
        {
            /*0x10*/ UnityEngine.InputForUI.EventSanitizer.IEventSanitizer[] _sanitizers;

            /*0x7ee4208*/ void Reset();
            /*0x7ee457c*/ void BeforeProviderUpdate();
            /*0x7ee4674*/ void AfterProviderUpdate();
            /*0x7ee4108*/ void Inspect(ref UnityEngine.InputForUI.Event ev);

            interface IEventSanitizer
            {
                /*0x380cb08*/ void Reset();
                /*0x380cb08*/ void BeforeProviderUpdate();
                /*0x380cb08*/ void AfterProviderUpdate();
                /*0x380d83c*/ void Inspect(ref UnityEngine.InputForUI.Event ev);
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
