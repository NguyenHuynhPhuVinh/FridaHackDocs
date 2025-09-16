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

            /*0x7ef8398*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ef83a0*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ef83a8*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ef83b0*/ void set_playerId(uint value);
            /*0x7ef83b8*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ef83c0*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ef83c8*/ string ToString();

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

            static /*0x7ef915c*/ Event();
            static /*0x7ef8484*/ int CompareType(UnityEngine.InputForUI.Event a, UnityEngine.InputForUI.Event b);
            static /*0x7ef8b10*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.KeyEvent keyEvent);
            static /*0x7ef8c10*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.PointerEvent pointerEvent);
            static /*0x7ef8d10*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.TextInputEvent textInputEvent);
            static /*0x7ef8df8*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.IMECompositionEvent imeCompositionEvent);
            static /*0x7ef8f70*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.CommandEvent commandEvent);
            static /*0x7ef9058*/ UnityEngine.InputForUI.Event From(UnityEngine.InputForUI.NavigationEvent navigationEvent);
            /*0x7ef85d4*/ UnityEngine.InputForUI.Event.Type get_type();
            /*0x7ef85dc*/ UnityEngine.InputForUI.IEventProperties get_asObject();
            /*0x7ef8568*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ef8648*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ef86bc*/ void Ensure(UnityEngine.InputForUI.Event.Type t);
            /*0x7ef874c*/ string ToString();
            /*0x7ef8b98*/ UnityEngine.InputForUI.KeyEvent get_asKeyEvent();
            /*0x7ef8c98*/ UnityEngine.InputForUI.PointerEvent get_asPointerEvent();
            /*0x7ef8d88*/ UnityEngine.InputForUI.TextInputEvent get_asTextInputEvent();
            /*0x7ef8ec0*/ UnityEngine.InputForUI.IMECompositionEvent get_asIMECompositionEvent();
            /*0x7ef8fe8*/ UnityEngine.InputForUI.CommandEvent get_asCommandEvent();
            /*0x7ef90e4*/ UnityEngine.InputForUI.NavigationEvent get_asNavigationEvent();
            /*0x3910ae8*/ TOutputType Map<TOutputType, TMapType>(TMapType fn);
            /*0x3910ae8*/ TOutputType Map<TOutputType, TMapType>();

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
                /*0x3910ae8*/ TOutputType Map<TEventType>(ref TEventType ev);
            }

            struct MapAsObject : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.IEventProperties>
            {
                /*0x3814a3c*/ UnityEngine.InputForUI.IEventProperties Map<TEventType>(ref TEventType ev);
            }

            struct MapAsEventSource : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.EventSource>
            {
                /*0x381467c*/ UnityEngine.InputForUI.EventSource Map<TEventType>(ref TEventType ev);
            }

            struct MapAsEventModifiers : UnityEngine.InputForUI.Event.IMapFn<UnityEngine.InputForUI.EventModifiers>
            {
                /*0x3910ae8*/ UnityEngine.InputForUI.EventModifiers Map<TEventType>(ref TEventType ev);
            }
        }

        struct EventModifiers
        {
            /*0x10*/ uint _state;

            static /*0x7ef9294*/ void Append(ref string str, string value);
            /*0x7ef91fc*/ bool IsPressed(UnityEngine.InputForUI.EventModifiers.Modifiers mod);
            /*0x7ef920c*/ bool get_isShiftPressed();
            /*0x7ef921c*/ bool get_isCtrlPressed();
            /*0x7ef922c*/ bool get_isAltPressed();
            /*0x7ef923c*/ bool get_isMetaPressed();
            /*0x7ef924c*/ bool get_isCapsLockEnabled();
            /*0x7ef9258*/ bool get_isFunctionKeyPressed();
            /*0x7ef9264*/ bool get_isNumericPressed();
            /*0x7ef9270*/ void SetPressed(UnityEngine.InputForUI.EventModifiers.Modifiers modifier, bool pressed);
            /*0x7ef928c*/ void Reset();
            /*0x7ef88b4*/ string ToString();

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
            /*0x3814574*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x3910ae8*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
        }

        struct IMECompositionEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ string compositionString;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x7ef930c*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ef9314*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ef931c*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ef9324*/ void set_playerId(uint value);
            /*0x7ef932c*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ef9334*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ef933c*/ string ToString();
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

            /*0x7ef93a8*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ef93b0*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ef93b8*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ef93c0*/ void set_playerId(uint value);
            /*0x7ef93c8*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ef93d0*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ef93d8*/ string ToString();

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

                static /*0x7ef9564*/ bool ShouldBeProcessed(UnityEngine.KeyCode keyCode);
                /*0x7ef9570*/ bool GetUnchecked(uint index);
                /*0x7ef958c*/ void SetUnchecked(uint index);
                /*0x7ef95b0*/ void ClearUnchecked(uint index);
                /*0x7ef95d4*/ bool IsPressed(UnityEngine.KeyCode keyCode);
                /*0x7ef9600*/ System.Collections.Generic.IEnumerable<UnityEngine.KeyCode> GetAllPressed();
                /*0x7ef96b4*/ void SetPressed(UnityEngine.KeyCode keyCode, bool pressed);
                /*0x7ef96ec*/ void Reset();
                /*0x7ef974c*/ string ToString();

                class <GetAllPressed>d__8 : System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x14*/ UnityEngine.KeyCode <>2__current;
                    /*0x18*/ int <>l__initialThreadId;
                    /*0x1c*/ UnityEngine.InputForUI.KeyEvent.ButtonsState <>4__this;
                    /*0x44*/ UnityEngine.InputForUI.KeyEvent.ButtonsState <>3__<>4__this;
                    /*0x6c*/ uint <index>5__1;

                    /*0x7ef9680*/ <GetAllPressed>d__8(int <>1__state);
                    /*0x7ef97c0*/ void System.IDisposable.Dispose();
                    /*0x7ef97c4*/ bool MoveNext();
                    /*0x7ef9838*/ UnityEngine.KeyCode System.Collections.Generic.IEnumerator<UnityEngine.KeyCode>.get_Current();
                    /*0x7ef9840*/ void System.Collections.IEnumerator.Reset();
                    /*0x7ef9878*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7ef98d4*/ System.Collections.Generic.IEnumerator<UnityEngine.KeyCode> System.Collections.Generic.IEnumerable<UnityEngine.KeyCode>.GetEnumerator();
                    /*0x7ef99b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

            static /*0x7ef9b50*/ UnityEngine.InputForUI.NavigationEvent.Direction DetermineMoveDirection(UnityEngine.Vector2 vec, float deadZone);
            /*0x7ef99b4*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ef99bc*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ef99c4*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ef99cc*/ void set_playerId(uint value);
            /*0x7ef99d4*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ef99dc*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ef99e4*/ string ToString();

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

            static /*0x7efa92c*/ UnityEngine.InputForUI.PointerEvent.Button ButtonFromButtonIndex(int index);
            /*0x7ef9ba4*/ bool get_isPrimaryPointer();
            /*0x7ef9bb4*/ float get_azimuth();
            /*0x7ef9c68*/ float get_altitude();
            /*0x7ef9ce0*/ Unity.IntegerTime.DiscreteTime get_timestamp();
            /*0x7ef9ce8*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7ef9cf0*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7ef9cf8*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7ef9d00*/ void set_playerId(uint value);
            /*0x7ef9d08*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7ef9d10*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7ef9d18*/ string ToString();

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

                /*0x7efa940*/ void Set(UnityEngine.InputForUI.PointerEvent.Button button, bool pressed);
                /*0x7efa95c*/ bool Get(UnityEngine.InputForUI.PointerEvent.Button button);
                /*0x7efa96c*/ void Reset();
                /*0x7efa974*/ string ToString();
            }
        }

        struct TextInputEvent : UnityEngine.InputForUI.IEventProperties
        {
            /*0x10*/ char character;
            /*0x18*/ Unity.IntegerTime.DiscreteTime <timestamp>k__BackingField;
            /*0x20*/ UnityEngine.InputForUI.EventSource <eventSource>k__BackingField;
            /*0x24*/ uint <playerId>k__BackingField;
            /*0x28*/ UnityEngine.InputForUI.EventModifiers <eventModifiers>k__BackingField;

            /*0x7efa9ec*/ void set_timestamp(Unity.IntegerTime.DiscreteTime value);
            /*0x7efa9f4*/ UnityEngine.InputForUI.EventSource get_eventSource();
            /*0x7efa9fc*/ void set_eventSource(UnityEngine.InputForUI.EventSource value);
            /*0x7efaa04*/ void set_playerId(uint value);
            /*0x7efaa0c*/ UnityEngine.InputForUI.EventModifiers get_eventModifiers();
            /*0x7efaa14*/ void set_eventModifiers(UnityEngine.InputForUI.EventModifiers value);
            /*0x7efaa1c*/ string ToString();
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

            static /*0x7efbc38*/ EventProvider();
            static /*0x7efaad4*/ void Subscribe(UnityEngine.InputForUI.EventConsumer handler, int priority, System.Nullable<int> playerId, UnityEngine.InputForUI.Event.Type[] type);
            static /*0x7efadc0*/ void Unsubscribe(UnityEngine.InputForUI.EventConsumer handler);
            static /*0x7efaed4*/ void SetEnabled(bool enable);
            static /*0x7efb2d4*/ void Dispatch(ref UnityEngine.InputForUI.Event ev);
            static /*0x7efad4c*/ void Bootstrap();
            static /*0x7efaf70*/ void Initialize();
            static /*0x7efb134*/ void Shutdown();
            static /*0x7efb74c*/ void OnFocusChanged(bool focus);
            static /*0x7efb828*/ void NotifyUpdate();
            static /*0x7efbb9c*/ void SetInputSystemProvider(UnityEngine.InputForUI.IEventProviderImpl impl);

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

                static /*0x7efbeb8*/ <>c();
                /*0x7efbf20*/ <>c();
                /*0x7efbf28*/ int <Subscribe>b__5_0(UnityEngine.InputForUI.EventProvider.Registration a, UnityEngine.InputForUI.EventProvider.Registration b);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.InputForUI.EventConsumer handler;

                /*0x7efaecc*/ <>c__DisplayClass6_0();
                /*0x7efbf3c*/ bool <Unsubscribe>b__0(UnityEngine.InputForUI.EventProvider.Registration x);
            }
        }

        class EventConsumer : System.MulticastDelegate
        {
            /*0x7efbf50*/ EventConsumer(object object, nint method);
            /*0x7efc000*/ bool Invoke(ref UnityEngine.InputForUI.Event ev);
        }

        interface IEventProviderImpl
        {
            /*0x38159dc*/ void Initialize();
            /*0x38159dc*/ void Shutdown();
            /*0x38159dc*/ void Update();
            /*0x3815cc4*/ void OnFocusChanged(bool focus);
        }

        class InputEventPartialProvider : UnityEngine.InputForUI.IEventProviderImpl
        {
            /*0x10*/ UnityEngine.Event _ev;
            /*0x18*/ UnityEngine.OperatingSystemFamily _operatingSystemFamily;
            /*0x1c*/ UnityEngine.InputForUI.KeyEvent.ButtonsState _keyboardButtonsState;
            /*0x44*/ UnityEngine.InputForUI.EventModifiers _eventModifiers;
            /*0x48*/ bool _sendNavigationEventOnTabKey;
            /*0x50*/ System.Collections.Generic.IDictionary<string, UnityEngine.InputForUI.CommandEvent.Command> _IMGUICommandToInputForUICommandType;

            /*0x7efcc44*/ InputEventPartialProvider();
            /*0x7efc014*/ void Initialize();
            /*0x7efc090*/ void Shutdown();
            /*0x7efc094*/ void Update();
            /*0x7efcbc4*/ void OnFocusChanged(bool focus);
            /*0x7efcc2c*/ Unity.IntegerTime.DiscreteTime GetTimestamp(ref UnityEngine.Event ev);
            /*0x7efc350*/ void UpdateEventModifiers(ref UnityEngine.Event ev);
            /*0x7efc674*/ UnityEngine.InputForUI.KeyEvent ToKeyEvent(ref UnityEngine.Event ev);
            /*0x7efc998*/ UnityEngine.InputForUI.TextInputEvent ToTextInputEvent(ref UnityEngine.Event ev);
            /*0x7efc82c*/ void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(ref UnityEngine.Event ev);
            /*0x7efca18*/ UnityEngine.InputForUI.CommandEvent ToCommandEvent(ref UnityEngine.Event ev);
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

            static /*0x7eff75c*/ UnityEngine.InputForUI.PointerEvent.Button PenStatusToButton(UnityEngine.PenStatus status);
            static /*0x7ef9bbc*/ float TiltToAzimuth(UnityEngine.Vector2 tilt);
            static /*0x7eff6e8*/ UnityEngine.Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth);
            static /*0x7ef9ca4*/ float TiltToAltitude(UnityEngine.Vector2 tilt);
            static /*0x7eff4a8*/ UnityEngine.Vector2 MultiDisplayBottomLeftToPanelPosition(UnityEngine.Vector2 position, ref int targetDisplay);
            static /*0x7f000dc*/ UnityEngine.Vector2 MultiDisplayToLocalScreenPosition(UnityEngine.Vector2 position, ref System.Nullable<int> targetDisplay);
            static /*0x7f00230*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
            static /*0x7eff50c*/ UnityEngine.Vector2 ScreenBottomLeftToPanelDelta(UnityEngine.Vector2 delta);
            /*0x7efbd2c*/ InputManagerProvider();
            /*0x7efd0d0*/ UnityEngine.InputForUI.EventModifiers get__eventModifiers();
            /*0x7efd39c*/ void Initialize();
            /*0x7efd5dc*/ void Shutdown();
            /*0x7efd5e0*/ void Update();
            /*0x7efda80*/ bool CheckTouchEvents(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7efd97c*/ void DetectPen();
            /*0x7efe050*/ bool CheckPenEvent(Unity.IntegerTime.DiscreteTime currentTime, ref UnityEngine.PenData currentPenData);
            /*0x7efe418*/ void CheckMouseEvents(Unity.IntegerTime.DiscreteTime currentTime, bool muted);
            /*0x7efeaa8*/ void CheckMouseScroll(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7eff334*/ void NextPreviousNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7eff16c*/ void SubmitCancelNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7efefb0*/ void DirectionNavigation(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7efedec*/ void CheckIfIMEChanged(Unity.IntegerTime.DiscreteTime currentTime);
            /*0x7effd70*/ void OnFocusChanged(bool focus);
            /*0x7effa78*/ UnityEngine.InputForUI.EventSource GetEventSourceFromPressedKey();
            /*0x7effec4*/ bool InputManagerJoystickWasPressed();
            /*0x7effdec*/ bool InputManagerKeyboardWasPressed();
            /*0x7efff9c*/ float InputManagerGetAxisRawOrDefault(string axisName);
            /*0x7eff934*/ bool InputManagerGetButtonDownOrDefault(string axisName);
            /*0x7effab0*/ System.ValueTuple<UnityEngine.Vector2, bool> ReadCurrentNavigationMoveVector();
            /*0x7effd10*/ UnityEngine.InputForUI.IMECompositionEvent ToIMECompositionEvent(Unity.IntegerTime.DiscreteTime currentTime, string compositionString);

            struct ButtonEventsIterator : System.Collections.IEnumerator
            {
                /*0x10*/ uint _mask;
                /*0x14*/ int _bit;

                static /*0x7eff7f4*/ UnityEngine.InputForUI.InputManagerProvider.ButtonEventsIterator FromState(bool previous, bool down, bool up, bool current);
                /*0x7eff818*/ bool get_Current();
                /*0x7eff900*/ bool MoveNext();
                /*0x7f00314*/ void Reset();
                /*0x7f00320*/ object System.Collections.IEnumerator.get_Current();
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

                static /*0x7efd0ec*/ UnityEngine.InputForUI.InputManagerProvider.Configuration GetDefaultConfiguration();
            }

            interface IInput
            {
                /*0x38148bc*/ string get_compositionString();
                /*0x38140fc*/ bool GetKey(UnityEngine.KeyCode keyCode);
                /*0x38141c4*/ bool GetButtonDown(string button);
                float GetAxisRaw(string axis);
                UnityEngine.PenData GetLastPenContactEvent();
                /*0x3813ffc*/ bool get_touchSupported();
                /*0x3814574*/ int get_touchCount();
                UnityEngine.Touch GetTouch(int index);
                /*0x3813ffc*/ bool get_mousePresent();
                /*0x38140fc*/ bool GetMouseButton(int button);
                /*0x38140fc*/ bool GetMouseButtonDown(int button);
                /*0x38140fc*/ bool GetMouseButtonUp(int button);
                /*0x38159a4*/ UnityEngine.Vector3 get_mousePosition();
                UnityEngine.Vector2 get_mouseScrollDelta();
            }

            class Input : UnityEngine.InputForUI.InputManagerProvider.IInput
            {
                /*0x7efd250*/ Input();
                /*0x7f00350*/ string get_compositionString();
                /*0x7f00358*/ bool GetKey(UnityEngine.KeyCode key);
                /*0x7f00364*/ bool GetButtonDown(string button);
                /*0x7f00370*/ float GetAxisRaw(string axis);
                /*0x7f0037c*/ UnityEngine.PenData GetLastPenContactEvent();
                /*0x7f003b4*/ bool get_touchSupported();
                /*0x7f003bc*/ int get_touchCount();
                /*0x7f003c4*/ UnityEngine.Touch GetTouch(int index);
                /*0x7f003fc*/ bool get_mousePresent();
                /*0x7f00404*/ bool GetMouseButton(int button);
                /*0x7f00410*/ bool GetMouseButtonDown(int button);
                /*0x7f0041c*/ bool GetMouseButtonUp(int button);
                /*0x7f00428*/ UnityEngine.Vector3 get_mousePosition();
                /*0x7f00430*/ UnityEngine.Vector2 get_mouseScrollDelta();
            }

            interface ITime
            {
                Unity.IntegerTime.RationalTime get_timeAsRational();
            }

            class Time : UnityEngine.InputForUI.InputManagerProvider.ITime
            {
                /*0x7efd258*/ Time();
                /*0x7f00438*/ Unity.IntegerTime.RationalTime get_timeAsRational();
            }
        }

        class NavigationEventRepeatHelper
        {
            /*0x10*/ int m_ConsecutiveMoveCount;
            /*0x14*/ UnityEngine.InputForUI.NavigationEvent.Direction m_LastDirection;
            /*0x18*/ Unity.IntegerTime.DiscreteTime m_PrevActionTime;
            /*0x20*/ Unity.IntegerTime.DiscreteTime m_InitialRepeatDelay;
            /*0x28*/ Unity.IntegerTime.DiscreteTime m_ConsecutiveRepeatDelay;

            /*0x7efd260*/ NavigationEventRepeatHelper();
            /*0x7effba8*/ void Reset();
            /*0x7effc0c*/ bool ShouldSendMoveEvent(Unity.IntegerTime.DiscreteTime timestamp, UnityEngine.InputForUI.NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame);
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

            static /*0x7f004ac*/ PointerState();
            /*0x7f00440*/ UnityEngine.InputForUI.PointerEvent.Button get_LastPressedButton();
            /*0x7f00448*/ void set_LastPressedButton(UnityEngine.InputForUI.PointerEvent.Button value);
            /*0x7f00450*/ UnityEngine.InputForUI.PointerEvent.ButtonsState get_ButtonsState();
            /*0x7f00458*/ Unity.IntegerTime.DiscreteTime get_NextPressTime();
            /*0x7f00460*/ void set_NextPressTime(Unity.IntegerTime.DiscreteTime value);
            /*0x7f00468*/ int get_ClickCount();
            /*0x7f00470*/ void set_ClickCount(int value);
            /*0x7f00478*/ UnityEngine.Vector2 get_LastPosition();
            /*0x7f00480*/ void set_LastPosition(UnityEngine.Vector2 value);
            /*0x7f00488*/ int get_LastDisplayIndex();
            /*0x7f00490*/ void set_LastDisplayIndex(int value);
            /*0x7f00498*/ bool get_LastPositionValid();
            /*0x7f004a0*/ void set_LastPositionValid(bool value);
            /*0x7eff514*/ void OnButtonDown(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button);
            /*0x7eff65c*/ void OnButtonUp(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button);
            /*0x7eff828*/ void OnButtonChange(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.InputForUI.PointerEvent.Button button, bool previousState, bool newState);
            /*0x7eff778*/ void OnMove(Unity.IntegerTime.DiscreteTime currentTime, UnityEngine.Vector2 position, int displayIndex);
            /*0x7efd510*/ void Reset();
        }

        struct EventSanitizer
        {
            /*0x10*/ UnityEngine.InputForUI.EventSanitizer.IEventSanitizer[] _sanitizers;

            /*0x7efb638*/ void Reset();
            /*0x7efb9ac*/ void BeforeProviderUpdate();
            /*0x7efbaa4*/ void AfterProviderUpdate();
            /*0x7efb538*/ void Inspect(ref UnityEngine.InputForUI.Event ev);

            interface IEventSanitizer
            {
                /*0x38159dc*/ void Reset();
                /*0x38159dc*/ void BeforeProviderUpdate();
                /*0x38159dc*/ void AfterProviderUpdate();
                /*0x3816710*/ void Inspect(ref UnityEngine.InputForUI.Event ev);
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
