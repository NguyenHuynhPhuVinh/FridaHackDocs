class <Module>
{
}

namespace NoaDebugger
{
    enum ShortcutActionType
    {
        ToggleDebugger = 0,
        ToggleFloatingWindow = 1,
        ToggleTriggerButton = 2,
        ToggleUIElements = 3,
        ToggleAllUI = 4,
        ResetApplication = 5,
        CaptureScreenshot = 6,
        TogglePauseResume = 7,
        DecreaseGameSpeed = 8,
        IncreaseGameSpeed = 9,
        ResetGameSpeed = 10,
        CustomAction1 = 11,
        CustomAction2 = 12,
        CustomAction3 = 13,
        CustomAction4 = 14,
        ToggleOverlay = 15,
        FrameStepping = 16,
        CustomAction5 = 17,
    }

    enum ShortcutModifierKey
    {
        None = 0,
        Alt = 1,
        Ctrl = 2,
        Shift = 3,
    }

    struct ShortcutKeyboardBinding
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.ShortcutModifierKey> modifiers;
        /*0x18*/ int key;
    }
}
