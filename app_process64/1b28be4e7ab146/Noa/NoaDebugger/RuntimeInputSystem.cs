class <Module>
{
}

namespace NoaDebugger
{
    class InputInternal
    {
        /*0x72dd7fc*/ InputInternal();
        /*0x72dd5dc*/ void Initialize();
        /*0x72dd5e4*/ bool IsButtonUp();
        /*0x72dd650*/ bool IsButtonReleased();
        /*0x72dd744*/ UnityEngine.Vector2 GetCursorPosition();
    }

    class UnityInputUtilsInternal
    {
        /*0x72de1e8*/ UnityInputUtilsInternal();
        /*0x72dd804*/ void AddInputModule(UnityEngine.GameObject target);
        /*0x72dd854*/ void OnShortcutHandlerInitialize();
        /*0x72dd8b8*/ bool IsShortcutKeyDown(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72ddce8*/ bool IsShortcutKeyHeld(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72dddac*/ bool IsShortcutKeyUp(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72dd97c*/ bool IsShortcutModifierPressed(NoaDebugger.ShortcutKeyboardBinding keyboard);
        /*0x72dde70*/ string GetKeyTextFromInt(int keyNum);
        /*0x72de13c*/ int GetDefaultKeyFromActionType(NoaDebugger.ShortcutActionType actionType);
        /*0x72de15c*/ int GetCurrentKey(UnityEngine.Event current);
        /*0x72de1e0*/ bool get_IsValidInput();
    }
}
