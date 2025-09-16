class <Module>
{
}

namespace NoaDebugger
{
    class InputInternal
    {
        /*0x72c63cc*/ InputInternal();
        /*0x72c61ac*/ void Initialize();
        /*0x72c61b4*/ bool IsButtonUp();
        /*0x72c6220*/ bool IsButtonReleased();
        /*0x72c6314*/ UnityEngine.Vector2 GetCursorPosition();
    }

    class UnityInputUtilsInternal
    {
        /*0x72c6db8*/ UnityInputUtilsInternal();
        /*0x72c63d4*/ void AddInputModule(UnityEngine.GameObject target);
        /*0x72c6424*/ void OnShortcutHandlerInitialize();
        /*0x72c6488*/ bool IsShortcutKeyDown(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72c68b8*/ bool IsShortcutKeyHeld(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72c697c*/ bool IsShortcutKeyUp(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72c654c*/ bool IsShortcutModifierPressed(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72c6a40*/ string GetKeyTextFromInt(int keyNum);
        /*0x72c6d0c*/ int GetDefaultKeyFromActionType(NoaDebugger.ShortcutActionType actionType);
        /*0x72c6d2c*/ int GetCurrentKey(UnityEngine.Event current);
        /*0x72c6db0*/ bool get_IsValidInput();
    }
}
