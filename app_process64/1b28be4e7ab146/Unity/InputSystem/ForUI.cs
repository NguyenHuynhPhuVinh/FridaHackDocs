class <Module>
{
}

namespace UnityEngine
{
    namespace InputSystem
    {
        namespace Plugins
        {
            namespace InputForUI
            {
                class InputSystemProvider : UnityEngine.InputForUI.IEventProviderImpl
                {
                    static /*0x0*/ System.Action<UnityEngine.InputSystem.InputActionAsset> s_OnRegisterActions;
                    /*0x10*/ UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider.Configuration m_Cfg;
                    /*0x58*/ UnityEngine.InputForUI.InputEventPartialProvider m_InputEventPartialProvider;
                    /*0x60*/ UnityEngine.InputSystem.InputActionAsset m_InputActionAsset;
                    /*0x68*/ UnityEngine.InputSystem.InputActionReference m_PointAction;
                    /*0x70*/ UnityEngine.InputSystem.InputActionReference m_MoveAction;
                    /*0x78*/ UnityEngine.InputSystem.InputActionReference m_SubmitAction;
                    /*0x80*/ UnityEngine.InputSystem.InputActionReference m_CancelAction;
                    /*0x88*/ UnityEngine.InputSystem.InputActionReference m_LeftClickAction;
                    /*0x90*/ UnityEngine.InputSystem.InputActionReference m_MiddleClickAction;
                    /*0x98*/ UnityEngine.InputSystem.InputActionReference m_RightClickAction;
                    /*0xa0*/ UnityEngine.InputSystem.InputActionReference m_ScrollWheelAction;
                    /*0xa8*/ UnityEngine.InputSystem.InputAction m_NextPreviousAction;
                    /*0xb0*/ System.Collections.Generic.List<UnityEngine.InputForUI.Event> m_Events;
                    /*0xb8*/ UnityEngine.InputForUI.PointerState m_MouseState;
                    /*0xe0*/ UnityEngine.InputForUI.PointerState m_PenState;
                    /*0x108*/ bool m_SeenPenEvents;
                    /*0x110*/ UnityEngine.InputForUI.PointerState m_TouchState;
                    /*0x138*/ bool m_SeenTouchEvents;
                    /*0x140*/ UnityEngine.InputForUI.NavigationEventRepeatHelper m_RepeatHelper;
                    /*0x148*/ bool m_ResetSeenEventsOnUpdate;

                    static /*0x7a016f8*/ InputSystemProvider();
                    static /*0x7a01830*/ void Bootstrap();
                    static /*0x7a035ec*/ int SortEvents(UnityEngine.InputForUI.Event a, UnityEngine.InputForUI.Event b);
                    static /*0x7a036e8*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
                    static /*0x7a03950*/ int FindTouchFingerIndex(UnityEngine.InputSystem.Touchscreen touchscreen, UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a01770*/ InputSystemProvider();
                    /*0x7a01834*/ UnityEngine.InputForUI.EventModifiers get_m_EventModifiers();
                    /*0x7a01850*/ Unity.IntegerTime.DiscreteTime get_m_CurrentTime();
                    /*0x7a01868*/ void Initialize();
                    /*0x7a02450*/ void Shutdown();
                    /*0x7a02ad0*/ void OnActionsChange();
                    /*0x7a02b20*/ void Update();
                    /*0x7a0313c*/ void ResetSeenEvents();
                    /*0x7a02f7c*/ void DirectionNavigation(Unity.IntegerTime.DiscreteTime currentTime);
                    /*0x7a03380*/ UnityEngine.InputSystem.InputDevice GetActiveDeviceFromDirection(UnityEngine.InputForUI.NavigationEvent.Direction direction);
                    /*0x7a03148*/ System.ValueTuple<UnityEngine.Vector2, bool> ReadCurrentNavigationMoveVector();
                    /*0x7a03274*/ UnityEngine.InputForUI.NavigationEvent.Direction ReadNextPreviousDirection();
                    /*0x7a036c8*/ void OnFocusChanged(bool focus);
                    /*0x7a037cc*/ UnityEngine.InputForUI.EventSource GetEventSource(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a03470*/ UnityEngine.InputForUI.EventSource GetEventSource(UnityEngine.InputSystem.InputDevice device);
                    /*0x7a03800*/ ref UnityEngine.InputForUI.PointerState GetPointerStateForSource(UnityEngine.InputForUI.EventSource eventSource);
                    /*0x7a03828*/ void DispatchFromCallback(ref UnityEngine.InputForUI.Event ev);
                    /*0x7a03c48*/ void OnPointerPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04430*/ void OnSubmitPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04550*/ void OnCancelPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04670*/ void OnClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx, UnityEngine.InputForUI.EventSource eventSource, UnityEngine.InputForUI.PointerEvent.Button button);
                    /*0x7a04a7c*/ void OnLeftClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04ab4*/ void OnMiddleClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04aec*/ void OnRightClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04b24*/ void OnScrollWheelPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x7a04ef0*/ void RegisterNextPreviousAction();
                    /*0x7a04fd8*/ void UnregisterFixedActions();
                    /*0x7a01cdc*/ void RegisterActions();
                    /*0x7a02524*/ void UnregisterActions();

                    struct Configuration
                    {
                        /*0x10*/ UnityEngine.InputSystem.InputActionAsset ActionAsset;
                        /*0x18*/ string PointAction;
                        /*0x20*/ string MoveAction;
                        /*0x28*/ string SubmitAction;
                        /*0x30*/ string CancelAction;
                        /*0x38*/ string LeftClickAction;
                        /*0x40*/ string MiddleClickAction;
                        /*0x48*/ string RightClickAction;
                        /*0x50*/ string ScrollWheelAction;

                        static /*0x7a01a28*/ UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider.Configuration GetDefaultConfiguration();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider.<> <>9;
                        static /*0x8*/ System.Comparison<UnityEngine.InputForUI.Event> <>9__33_0;

                        static /*0x7a0500c*/ <>c();
                        /*0x7a05074*/ <>c();
                        /*0x7a0507c*/ int <Update>b__33_0(UnityEngine.InputForUI.Event a, UnityEngine.InputForUI.Event b);
                    }
                }
            }
        }
    }
}
