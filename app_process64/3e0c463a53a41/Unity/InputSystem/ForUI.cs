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

                    static /*0x79ea2c8*/ InputSystemProvider();
                    static /*0x79ea400*/ void Bootstrap();
                    static /*0x79ec1bc*/ int SortEvents(UnityEngine.InputForUI.Event a, UnityEngine.InputForUI.Event b);
                    static /*0x79ec2b8*/ UnityEngine.Vector2 ScreenBottomLeftToPanelPosition(UnityEngine.Vector2 position, int targetDisplay);
                    static /*0x79ec520*/ int FindTouchFingerIndex(UnityEngine.InputSystem.Touchscreen touchscreen, UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ea340*/ InputSystemProvider();
                    /*0x79ea404*/ UnityEngine.InputForUI.EventModifiers get_m_EventModifiers();
                    /*0x79ea420*/ Unity.IntegerTime.DiscreteTime get_m_CurrentTime();
                    /*0x79ea438*/ void Initialize();
                    /*0x79eb020*/ void Shutdown();
                    /*0x79eb6a0*/ void OnActionsChange();
                    /*0x79eb6f0*/ void Update();
                    /*0x79ebd0c*/ void ResetSeenEvents();
                    /*0x79ebb4c*/ void DirectionNavigation(Unity.IntegerTime.DiscreteTime currentTime);
                    /*0x79ebf50*/ UnityEngine.InputSystem.InputDevice GetActiveDeviceFromDirection(UnityEngine.InputForUI.NavigationEvent.Direction direction);
                    /*0x79ebd18*/ System.ValueTuple<UnityEngine.Vector2, bool> ReadCurrentNavigationMoveVector();
                    /*0x79ebe44*/ UnityEngine.InputForUI.NavigationEvent.Direction ReadNextPreviousDirection();
                    /*0x79ec298*/ void OnFocusChanged(bool focus);
                    /*0x79ec39c*/ UnityEngine.InputForUI.EventSource GetEventSource(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ec040*/ UnityEngine.InputForUI.EventSource GetEventSource(UnityEngine.InputSystem.InputDevice device);
                    /*0x79ec3d0*/ ref UnityEngine.InputForUI.PointerState GetPointerStateForSource(UnityEngine.InputForUI.EventSource eventSource);
                    /*0x79ec3f8*/ void DispatchFromCallback(ref UnityEngine.InputForUI.Event ev);
                    /*0x79ec818*/ void OnPointerPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ed000*/ void OnSubmitPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ed120*/ void OnCancelPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ed240*/ void OnClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx, UnityEngine.InputForUI.EventSource eventSource, UnityEngine.InputForUI.PointerEvent.Button button);
                    /*0x79ed64c*/ void OnLeftClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ed684*/ void OnMiddleClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ed6bc*/ void OnRightClickPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79ed6f4*/ void OnScrollWheelPerformed(UnityEngine.InputSystem.InputAction.CallbackContext ctx);
                    /*0x79edac0*/ void RegisterNextPreviousAction();
                    /*0x79edba8*/ void UnregisterFixedActions();
                    /*0x79ea8ac*/ void RegisterActions();
                    /*0x79eb0f4*/ void UnregisterActions();

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

                        static /*0x79ea5f8*/ UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider.Configuration GetDefaultConfiguration();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider.<> <>9;
                        static /*0x8*/ System.Comparison<UnityEngine.InputForUI.Event> <>9__33_0;

                        static /*0x79edbdc*/ <>c();
                        /*0x79edc44*/ <>c();
                        /*0x79edc4c*/ int <Update>b__33_0(UnityEngine.InputForUI.Event a, UnityEngine.InputForUI.Event b);
                    }
                }
            }
        }
    }
}
