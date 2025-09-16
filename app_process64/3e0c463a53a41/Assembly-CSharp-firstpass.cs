class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c2add8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c2aecc*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

                    static /*0x3c2be30*/ ApplicationWindowResolutionConstraint();
                    static /*0x3c2b4b8*/ void OnAfterAssembliesLoaded();
                    static /*0x3c2b64c*/ void TryAdjustTaskInitialize();
                    static /*0x3c2b9d8*/ System.Threading.Tasks.Task WindowSizeAdjust(System.Threading.CancellationToken token);
                    static /*0x3c2babc*/ void ApplicationQuitting();
                    static /*0x3c2bb3c*/ nint CallWindowProc(nint lpPrevWndFunc, nint hWnd, uint Msg, nint wParam, nint lParam);
                    static /*0x3c2bbe8*/ bool GetWindowRect(nint hwnd, ref Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.RECT lpRect);
                    static /*0x3c2bc7c*/ bool GetClientRect(nint hWnd, ref Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.RECT lpRect);
                    static /*0x3c2bd08*/ nint SetWindowLong32(nint hWnd, int nIndex, nint dwNewLong);
                    static /*0x3c2bd9c*/ nint SetWindowLongPtr64(nint hWnd, int nIndex, nint dwNewLong);
                    static /*0x3c2aed4*/ nint WindowProc(nint hWnd, uint msg, nint wParam, nint lParam);
                    static /*0x3c2b91c*/ nint SetWindowLong(int nIndex, nint dwNewLong);

                    struct RECT
                    {
                        /*0x10*/ int Left;
                        /*0x14*/ int Top;
                        /*0x18*/ int Right;
                        /*0x1c*/ int Bottom;
                    }

                    class WndProcDelegate : System.MulticastDelegate
                    {
                        /*0x3c2b87c*/ WndProcDelegate(object object, nint method);
                        /*0x3c2bed4*/ nint Invoke(nint hWnd, uint msg, nint wParam, nint lParam);
                        /*0x3c2bee8*/ System.IAsyncResult BeginInvoke(nint hWnd, uint msg, nint wParam, nint lParam, System.AsyncCallback callback, object object);
                        /*0x3c2bf94*/ nint EndInvoke(System.IAsyncResult result);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.Paripari.Scripts.WindowSizeAdjust.ApplicationWindowResolutionConstraint.<> <>9;
                        static /*0x8*/ System.Func<System.Threading.Tasks.Task> <>9__7_0;

                        static /*0x3c2bfbc*/ <>c();
                        /*0x3c2c024*/ <>c();
                        /*0x3c2c02c*/ System.Threading.Tasks.Task <OnAfterAssembliesLoaded>b__7_0();
                    }

                    struct <WindowSizeAdjust>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ System.Threading.CancellationToken token;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x3c2c094*/ void MoveNext();
                        /*0x3c2c328*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class WindowHandle
                {
                    static int WS_VISIBLE = 268435456;
                    /*0x10*/ nint windowHandle;
                    /*0x18*/ bool isHandleConclusive;

                    static /*0x3c2c390*/ nint GetTopWindow(nint hWnd);
                    static /*0x3c2c40c*/ nint GetWindow(nint hWnd, uint wCmd);
                    static /*0x3c2c490*/ int GetWindowThreadProcessId(nint hWnd, ref int lpdwProcessId);
                    static /*0x3c2c514*/ int GetWindowLong(nint hWnd, int nIndex);
                    /*0x3c2bec8*/ WindowHandle();
                    /*0x3c2b824*/ nint TryGetWindowHandle();
                    /*0x3c2c598*/ nint SearchWindowHandle();
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
