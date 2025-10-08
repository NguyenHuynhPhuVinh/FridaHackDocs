class <Module>
{
}

namespace Firebase
{
    namespace Auth
    {
        class FirebaseAccountLinkException : System.Exception
        {
            /*0x8c*/ int <ErrorCode>k__BackingField;
            /*0x90*/ Firebase.Auth.AuthResult result;

            /*0x2d38bfc*/ FirebaseAccountLinkException(int errorCode, string message, Firebase.Auth.AuthResult authResult);
            /*0x2d38c9c*/ void set_ErrorCode(int value);
        }

        class FirebaseUser : Firebase.Auth.UserInfoInterface
        {
            /*0x28*/ Firebase.Auth.FirebaseAuth authProxy;

            /*0x2d38ca4*/ FirebaseUser(Firebase.Auth.FirebaseAuth auth);
            /*0x2d38d98*/ Firebase.Auth.FirebaseUserInternal GetValidFirebaseUserInternal();
            /*0x2d38eec*/ System.Threading.Tasks.Task<string> TokenAsync(bool forceRefresh);
            /*0x2d39030*/ System.Threading.Tasks.Task DeleteAsync();
            /*0x2d390f8*/ bool get_IsAnonymous();
            /*0x2d391e0*/ string get_UserId();
        }

        class Future_AuthResult : Firebase.FutureBase
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.Auth.Future_AuthResult.Action> Callbacks;
            static /*0x8*/ int CallbackIndex;
            static /*0x10*/ object CallbackLock;
            /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x38*/ nint callbackData;
            /*0x40*/ Firebase.Auth.Future_AuthResult.SWIG_CompletionDelegate SWIG_CompletionCB;

            static /*0x2d3a428*/ Future_AuthResult();
            static /*0x2d399bc*/ System.Threading.Tasks.Task<Firebase.Auth.AuthResult> GetTask(Firebase.Auth.Future_AuthResult fu);
            static /*0x2d392c8*/ void SWIG_CompletionDispatcher(int key);
            static /*0x2d3a074*/ void SWIG_FreeCompletionData(nint data);
            /*0x2d394bc*/ Future_AuthResult(nint cPtr, bool cMemoryOwn);
            /*0x2d395fc*/ void Dispose(bool disposing);
            /*0x2d39e94*/ void ThrowIfDisposed();
            /*0x2d39c20*/ void SetOnCompletionCallback(Firebase.Auth.Future_AuthResult.Action userCompletionCallback);
            /*0x2d397d4*/ void SetCompletionData(nint data);
            /*0x2d39f8c*/ nint SWIG_OnCompletion(Firebase.Auth.Future_AuthResult.SWIG_CompletionDelegate cs_callback, int cs_key);
            /*0x2d3a248*/ Firebase.Auth.AuthResult GetResult();

            class Action : System.MulticastDelegate
            {
                /*0x2d39b84*/ Action(object object, nint method);
                /*0x2d3a4a8*/ void Invoke();
            }

            class SWIG_CompletionDelegate : System.MulticastDelegate
            {
                /*0x2d39eec*/ SWIG_CompletionDelegate(object object, nint method);
                /*0x2d3a4bc*/ void Invoke(int index);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ Firebase.Auth.Future_AuthResult fu;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<Firebase.Auth.AuthResult> tcs;

                /*0x2d39b7c*/ <>c__DisplayClass5_0();
                /*0x2d3a4d0*/ void <GetTask>b__0();
            }
        }

        class UserInfoInterface : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            /*0x2d3a79c*/ UserInfoInterface(nint cPtr, bool cMemoryOwn);
            /*0x2d38cd0*/ UserInfoInterface();
            /*0x2d3a7fc*/ void Finalize();
            /*0x2d3a88c*/ void Dispose();
            /*0x2d3a8f8*/ void Dispose(bool disposing);
        }

        class FirebaseUserInternal : Firebase.Auth.UserInfoInterface
        {
            /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;

            /*0x2d3ab84*/ FirebaseUserInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d3acac*/ void Dispose(bool disposing);
            /*0x2d3aee4*/ bool IsValid();
            /*0x2d38f0c*/ System.Threading.Tasks.Task<string> TokenAsync(bool forceRefresh);
            /*0x2d39048*/ System.Threading.Tasks.Task DeleteAsync();
            /*0x2d39110*/ bool get_IsAnonymous();
            /*0x2d391f8*/ string get_UserId();
        }

        class AuthResult : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;
            /*0x28*/ Firebase.Auth.FirebaseAuth authProxy;

            /*0x2d3a3c8*/ AuthResult(nint cPtr, bool cMemoryOwn);
            /*0x2d3b250*/ void Finalize();
            /*0x2d3b484*/ void Dispose();
            /*0x2d3b2d8*/ void Dispose(bool disposing);
            /*0x2d3b564*/ Firebase.Auth.FirebaseUser get_User();
        }

        class FirebaseAuth : System.IDisposable
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<nint, Firebase.Auth.FirebaseAuth> appCPtrToAuth;
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;
            /*0x28*/ Firebase.FirebaseApp appProxy;
            /*0x30*/ nint appCPtr;
            /*0x38*/ nint authStateListener;
            /*0x40*/ nint idTokenListener;
            /*0x48*/ System.EventHandler stateChangedImpl;
            /*0x50*/ System.EventHandler idTokenChangedImpl;
            /*0x58*/ bool persistentLoaded;
            /*0x60*/ Firebase.Auth.FirebaseUser currentUser;

            static /*0x2d3d480*/ FirebaseAuth();
            static /*0x2d3b88c*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Auth.FirebaseAuth obj);
            static /*0x2d3bd0c*/ Firebase.Auth.FirebaseAuth ProxyFromAppCPtr(nint appCPtr);
            static /*0x2d3bed4*/ Firebase.Auth.FirebaseAuth GetAuth(Firebase.FirebaseApp app);
            static /*0x2d3ca88*/ void ForwardStateChange(nint appCPtr, System.Action<Firebase.Auth.FirebaseAuth> stateChangeClosure);
            static /*0x2d3b620*/ void StateChangedFunction(nint appCPtr);
            static /*0x2d3b724*/ void IdTokenChangedFunction(nint appCPtr);
            static /*0x2d3d0c0*/ Firebase.Auth.FirebaseAuth GetAuthInternal(Firebase.FirebaseApp app, ref Firebase.InitResult init_result_out);
            static /*0x2d3c3d0*/ void LogHeartbeatInternal(Firebase.FirebaseApp app);
            static /*0x2d3c994*/ void ReleaseReferenceInternal(Firebase.Auth.FirebaseAuth instance);
            /*0x2d3b828*/ FirebaseAuth(nint cPtr, bool cMemoryOwn);
            /*0x2d3b8d0*/ void Finalize();
            /*0x2d3b958*/ void Dispose();
            /*0x2d3b954*/ void Dispose(bool disposing);
            /*0x2d3be90*/ void ThrowIfNull();
            /*0x2d3c788*/ void OnAppDisposed(object sender, System.EventArgs eventArgs);
            /*0x2d3b9b8*/ void DisposeInternal();
            /*0x2d3b574*/ Firebase.Auth.FirebaseUser get_CurrentUser();
            /*0x2d3ccb8*/ System.Threading.Tasks.Task<Firebase.Auth.AuthResult> SignInAnonymouslyAsync();
            /*0x2d3cdf8*/ System.Threading.Tasks.Task<Firebase.Auth.AuthResult> SignInAnonymouslyInternalAsync();
            /*0x2d3cf80*/ void SignOut();
            /*0x2d38de8*/ Firebase.Auth.FirebaseUserInternal get_CurrentUserInternal();

            class StateChangedDelegate : System.MulticastDelegate
            {
                /*0x2d3c4c8*/ StateChangedDelegate(object object, nint method);
                /*0x2d3d518*/ void Invoke(nint authCPtr);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ Firebase.Auth.FirebaseAuth auth;
                /*0x18*/ Firebase.FirebaseApp app;

                /*0x2d3c3c0*/ <>c__DisplayClass19_0();
            }

            class <>c__DisplayClass19_1
            {
                /*0x10*/ Firebase.InitResult init_result;
                /*0x18*/ Firebase.Auth.FirebaseAuth.<> CS$<>8__locals1;

                /*0x2d3c3c8*/ <>c__DisplayClass19_1();
                /*0x2d3d52c*/ void <GetAuth>b__0();
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ System.Action<Firebase.Auth.FirebaseAuth> stateChangeClosure;

                /*0x2d3cca8*/ <>c__DisplayClass22_0();
            }

            class <>c__DisplayClass22_1
            {
                /*0x10*/ Firebase.Auth.FirebaseAuth auth;
                /*0x18*/ Firebase.Auth.FirebaseAuth.<> CS$<>8__locals1;

                /*0x2d3ccb0*/ <>c__DisplayClass22_1();
                /*0x2d3d5e8*/ void <ForwardStateChange>b__0();
            }

            class <>c
            {
                static /*0x0*/ Firebase.Auth.FirebaseAuth.<> <>9;
                static /*0x8*/ System.Action<Firebase.Auth.FirebaseAuth> <>9__23_0;
                static /*0x10*/ System.Action<Firebase.Auth.FirebaseAuth> <>9__24_0;

                static /*0x2d3d618*/ <>c();
                /*0x2d3d680*/ <>c();
                /*0x2d3d688*/ void <StateChangedFunction>b__23_0(Firebase.Auth.FirebaseAuth auth);
                /*0x2d3d710*/ void <IdTokenChangedFunction>b__24_0(Firebase.Auth.FirebaseAuth auth);
            }

            class <SignInAnonymouslyAsync>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Firebase.Auth.AuthResult> <>t__builder;
                /*0x30*/ Firebase.Auth.FirebaseAuth <>4__this;
                /*0x38*/ Firebase.Auth.AuthResult <result>5__1;
                /*0x40*/ Firebase.Auth.AuthResult <>s__2;
                /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<Firebase.Auth.AuthResult> <>u__1;

                /*0x2d3cdf0*/ <SignInAnonymouslyAsync>d__50();
                /*0x2d3d798*/ void MoveNext();
                /*0x2d3da98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class AuthUtilPINVOKE
        {
            static /*0x0*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Auth.AuthUtilPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2d3da9c*/ AuthUtilPINVOKE();
            static /*0x2d3a130*/ nint Future_AuthResult_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Auth.Future_AuthResult.SWIG_CompletionDelegate jarg2, int jarg3);
            static /*0x2d3a1cc*/ void Future_AuthResult_SWIG_FreeCompletionData(nint jarg1);
            static /*0x2d3a34c*/ nint Future_AuthResult_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d39940*/ void delete_Future_AuthResult(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3aaa4*/ void delete_UserInfoInterface(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3ab20*/ nint new_UserInfoInterface();
            static /*0x2d3ae68*/ void delete_FirebaseUserInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3afb4*/ bool FirebaseUserInternal_IsValid(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3b038*/ nint FirebaseUserInternal_Token(System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);
            static /*0x2d3b0bc*/ nint FirebaseUserInternal_Delete(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3b138*/ bool FirebaseUserInternal_IsAnonymous_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3b1bc*/ string FirebaseUserInternal_UserId_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3b4e8*/ void delete_AuthResult(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3cf04*/ nint FirebaseAuth_SignInAnonymouslyInternalAsync(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3d044*/ void FirebaseAuth_SignOut(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3d288*/ nint FirebaseAuth_GetAuthInternal(System.Runtime.InteropServices.HandleRef jarg1, ref int jarg2);
            static /*0x2d3d30c*/ void FirebaseAuth_LogHeartbeatInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3d388*/ void FirebaseAuth_ReleaseReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3d404*/ nint FirebaseAuth_CurrentUserInternal_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d3db6c*/ nint CreateAuthStateListener(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Auth.FirebaseAuth.StateChangedDelegate jarg2);
            static /*0x2d3dbf8*/ void DestroyAuthStateListener(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
            static /*0x2d3dc7c*/ nint CreateIdTokenListener(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Auth.FirebaseAuth.StateChangedDelegate jarg2);
            static /*0x2d3dd08*/ void DestroyIdTokenListener(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
            static /*0x2d39580*/ nint Future_AuthResult_SWIGUpcast(nint jarg1);
            static /*0x2d3ac30*/ nint FirebaseUserInternal_SWIGUpcast(nint jarg1);

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x2d3ebd8*/ SWIGExceptionHelper();
                static /*0x2d3e61c*/ void SWIGRegisterExceptionCallbacks_AuthUtil(Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2d3e788*/ void SWIGRegisterExceptionCallbacksArgument_AuthUtil(Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2d3dd8c*/ void SetPendingApplicationException(string message);
                static /*0x2d3de1c*/ void SetPendingArithmeticException(string message);
                static /*0x2d3deac*/ void SetPendingDivideByZeroException(string message);
                static /*0x2d3df3c*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2d3dfcc*/ void SetPendingInvalidCastException(string message);
                static /*0x2d3e05c*/ void SetPendingInvalidOperationException(string message);
                static /*0x2d3e0ec*/ void SetPendingIOException(string message);
                static /*0x2d3e17c*/ void SetPendingNullReferenceException(string message);
                static /*0x2d3e20c*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2d3e29c*/ void SetPendingOverflowException(string message);
                static /*0x2d3e32c*/ void SetPendingSystemException(string message);
                static /*0x2d3e3bc*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2d3e45c*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2d3e53c*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2d3db5c*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2d3f028*/ ExceptionDelegate(object object, nint method);
                    /*0x2d3f18c*/ void Invoke(string message);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2d3f0d8*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2d3f1a0*/ void Invoke(string message, string paramName);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2d3f1b4*/ SWIGPendingException();
                static /*0x2d3e9cc*/ void Set(System.Exception e);
                static /*0x2d3e83c*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Auth.AuthUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2d3f2e0*/ SWIGStringHelper();
                static /*0x2d3f260*/ void SWIGRegisterStringCallback_AuthUtil(Firebase.Auth.AuthUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2d3f25c*/ string CreateString(string cString);
                /*0x2d3db64*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2d3f38c*/ SWIGStringDelegate(object object, nint method);
                    /*0x2d3f43c*/ string Invoke(string message);
                }
            }
        }

        class AuthUtil
        {
            static /*0x2d3c568*/ nint CreateAuthStateListener(Firebase.Auth.FirebaseAuth auth, Firebase.Auth.FirebaseAuth.StateChangedDelegate state_changed_delegate);
            static /*0x2d3c78c*/ void DestroyAuthStateListener(Firebase.Auth.FirebaseAuth auth, nint listener);
            static /*0x2d3c678*/ nint CreateIdTokenListener(Firebase.Auth.FirebaseAuth auth, Firebase.Auth.FirebaseAuth.StateChangedDelegate state_changed_delegate);
            static /*0x2d3c890*/ void DestroyIdTokenListener(Firebase.Auth.FirebaseAuth auth, nint listener);
        }
    }
}
