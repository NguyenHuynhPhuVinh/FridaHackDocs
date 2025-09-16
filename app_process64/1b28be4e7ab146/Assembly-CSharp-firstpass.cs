class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c36934*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c36a28*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Assets
{
    namespace Paripari
    {
        namespace Scripts
        {
            namespace WindowSizeAdjust
            {
                class ApplicationWindowResolutionConstraint
                {
                    static int WM_SIZING = 532;
                    static int WMSZ_LEFT = 1;
                    static int WMSZ_RIGHT = 2;
                    static int WMSZ_TOP = 3;
                    static int WMSZ_BOTTOM = 6;
                    static int GWLP_WNDPROC = -4;
                    static /*0x0*/ Assets.Paripari.Scripts.WindowSizeAdjust.WindowHandle windowHandle;
                    static /*0x8*/ System.Threading.CancellationTokenSource sizeAdjustTaskCts;
                    static /*0x10*/ bool isTaskInitialized;
                    static /*0x18*/ nint oldWndProcPtr;
                    static /*0x20*/ nint newWndProcPtr;
                    static /*0x28*/ Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.WndProcDelegate wndProcDelegate;
                    static /*0x30*/ float aspectRatio;

                    static /*0x3c3798c*/ ApplicationWindowResolutionConstraint();
                    static /*0x3c37014*/ void OnAfterAssembliesLoaded();
                    static /*0x3c371a8*/ void TryAdjustTaskInitialize();
                    static /*0x3c37534*/ System.Threading.Tasks.Task WindowSizeAdjust(System.Threading.CancellationToken token);
                    static /*0x3c37618*/ void ApplicationQuitting();
                    static /*0x3c37698*/ nint CallWindowProc(nint lpPrevWndFunc, nint hWnd, uint Msg, nint wParam, nint lParam);
                    static /*0x3c37744*/ bool GetWindowRect(nint hwnd, ref Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.RECT lpRect);
                    static /*0x3c377d8*/ bool GetClientRect(nint hWnd, ref Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.RECT lpRect);
                    static /*0x3c37864*/ nint SetWindowLong32(nint hWnd, int nIndex, nint dwNewLong);
                    static /*0x3c378f8*/ nint SetWindowLongPtr64(nint hWnd, int nIndex, nint dwNewLong);
                    static /*0x3c36a30*/ nint WindowProc(nint hWnd, uint msg, nint wParam, nint lParam);
                    static /*0x3c37478*/ nint SetWindowLong(int nIndex, nint dwNewLong);

                    struct RECT
                    {
                        /*0x10*/ int Left;
                        /*0x14*/ int Top;
                        /*0x18*/ int Right;
                        /*0x1c*/ int Bottom;
                    }

                    class WndProcDelegate : System.MulticastDelegate
                    {
                        /*0x3c373d8*/ WndProcDelegate(object object, nint method);
                        /*0x3c37a30*/ nint Invoke(nint hWnd, uint msg, nint wParam, nint lParam);
                        /*0x3c37a44*/ System.IAsyncResult BeginInvoke(nint hWnd, uint msg, nint wParam, nint lParam, System.AsyncCallback callback, object object);
                        /*0x3c37af0*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.<> <>9;
                        static /*0x8*/ System.Func<System.Threading.Tasks.Task> <>9__7_0;

                        static /*0x3c37b18*/ <>c();
                        /*0x3c37b80*/ <>c();
                        /*0x3c37b88*/ System.Threading.Tasks.Task <OnAfterAssembliesLoaded>b__7_0();
                    }

                    struct <WindowSizeAdjust>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ System.Threading.CancellationToken token;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x3c37bf0*/ void MoveNext();
                        /*0x3c37e84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class WindowHandle
                {
                    static int WS_VISIBLE = 268435456;
                    /*0x10*/ nint windowHandle;
                    /*0x18*/ bool isHandleConclusive;

                    static /*0x3c37eec*/ nint GetTopWindow(nint hWnd);
                    static /*0x3c37f68*/ nint GetWindow(nint hWnd, uint wCmd);
                    static /*0x3c37fec*/ int GetWindowThreadProcessId(nint hWnd, ref int lpdwProcessId);
                    static /*0x3c38070*/ int GetWindowLong(nint hWnd, int nIndex);
                    /*0x3c37a24*/ WindowHandle();
                    /*0x3c37380*/ nint TryGetWindowHandle();
                    /*0x3c380f4*/ nint SearchWindowHandle();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> D97157C6F79FC4E9C9AD0DCB842A12CD1694CD6F55B4C8BFE0DBDA5A7D28303D;
    static /*0xe5*/ <PrivateImplementationDetails> DD7371BE91877FFD6134E0E6471206977B3AE0ADB2CDE28F6D472069501E9AB8;

    struct __StaticArrayInitTypeSize=125
    {
    }

    struct __StaticArrayInitTypeSize=229
    {
    }
}
