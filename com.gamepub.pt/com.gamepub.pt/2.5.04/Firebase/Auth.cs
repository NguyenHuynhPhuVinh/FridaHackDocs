class <Module>
{
}

namespace Firebase
{
    namespace Auth
    {
        interface IUserInfo
        {
            string get_Email();
            string get_ProviderId();
        }

        class UserInfoInterfaceList : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IList<Firebase.Auth.UserInfoInterface>, System.Collections.Generic.ICollection<Firebase.Auth.UserInfoInterface>, System.Collections.Generic.IEnumerable<Firebase.Auth.UserInfoInterface>
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            /*0x2a8c300*/ UserInfoInterfaceList(nint cPtr, bool cMemoryOwn);
            /*0x2a8dd1c*/ void Finalize();
            /*0x2a8dd94*/ void Dispose();
            /*0x2a8de10*/ void Dispose(bool disposing);
            /*0x2a8dfe8*/ bool get_IsReadOnly();
            /*0x2a8dff0*/ Firebase.Auth.UserInfoInterface get_Item(int index);
            /*0x2a8e158*/ void set_Item(int index, Firebase.Auth.UserInfoInterface value);
            /*0x2a8e290*/ int get_Count();
            /*0x2a8e3a0*/ void CopyTo(Firebase.Auth.UserInfoInterface[] array, int arrayIndex);
            /*0x2a8e3e4*/ void CopyTo(int index, Firebase.Auth.UserInfoInterface[] array, int arrayIndex, int count);
            /*0x2a8e750*/ System.Collections.Generic.IEnumerator<Firebase.Auth.UserInfoInterface> global::System.Collections.Generic.IEnumerable<Firebase.Auth.UserInfoInterface>.GetEnumerator();
            /*0x2a8e7f8*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
            /*0x2a8c364*/ Firebase.Auth.UserInfoInterfaceList.UserInfoInterfaceListEnumerator GetEnumerator();
            /*0x2a8e854*/ void Clear();
            /*0x2a8e954*/ void Add(Firebase.Auth.UserInfoInterface x);
            /*0x2a8e294*/ uint size();
            /*0x2a8e5ec*/ Firebase.Auth.UserInfoInterface getitemcopy(int index);
            /*0x2a8dff4*/ Firebase.Auth.UserInfoInterface getitem(int index);
            /*0x2a8e15c*/ void setitem(int index, Firebase.Auth.UserInfoInterface val);
            /*0x2a8ea78*/ void Insert(int index, Firebase.Auth.UserInfoInterface x);
            /*0x2a8ebac*/ void RemoveAt(int index);
            /*0x2a8ecbc*/ bool Contains(Firebase.Auth.UserInfoInterface value);
            /*0x2a8edec*/ int IndexOf(Firebase.Auth.UserInfoInterface value);
            /*0x2a8ef1c*/ bool Remove(Firebase.Auth.UserInfoInterface value);

            class UserInfoInterfaceListEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<Firebase.Auth.UserInfoInterface>, System.IDisposable
            {
                /*0x10*/ Firebase.Auth.UserInfoInterfaceList collectionRef;
                /*0x18*/ int currentIndex;
                /*0x20*/ object currentObject;
                /*0x28*/ int currentSize;

                /*0x2a8e7ac*/ UserInfoInterfaceListEnumerator(Firebase.Auth.UserInfoInterfaceList collection);
                /*0x2a8c3c0*/ Firebase.Auth.UserInfoInterface get_Current();
                /*0x2a91100*/ object global::System.Collections.IEnumerator.get_Current();
                /*0x2a8c4e0*/ bool MoveNext();
                /*0x2a91104*/ void Reset();
                /*0x2a91190*/ void Dispose();
            }
        }

        class Future_User : Firebase.FutureBase
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, Firebase.Auth.Future_User.Action> Callbacks;
            static /*0x8*/ int CallbackIndex;
            static /*0x10*/ object CallbackLock;
            /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x38*/ nint callbackData;
            /*0x40*/ Firebase.Auth.Future_User.SWIG_CompletionDelegate SWIG_CompletionCB;

            static /*0x2a8d654*/ Future_User();
            static /*0x2a8b0d0*/ System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> GetTask(Firebase.Auth.Future_User fu);
            static /*0x2a8c65c*/ void SWIG_CompletionDispatcher(int key);
            /*0x2a8b010*/ Future_User(nint cPtr, bool cMemoryOwn);
            /*0x2a8c850*/ void Dispose(bool disposing);
            /*0x2a8cfc8*/ void ThrowIfDisposed();
            /*0x2a8cd3c*/ void SetOnCompletionCallback(Firebase.Auth.Future_User.Action userCompletionCallback);
            /*0x2a8ca60*/ void SetCompletionData(nint data);
            /*0x2a8d0c0*/ nint SWIG_OnCompletion(Firebase.Auth.Future_User.SWIG_CompletionDelegate cs_callback, int cs_key);
            /*0x2a8d1e4*/ void SWIG_FreeCompletionData(nint data);
            /*0x2a8d500*/ Firebase.Auth.FirebaseUser GetResult();

            class Action : System.MulticastDelegate
            {
                /*0x2a8ccdc*/ Action(object object, nint method);
                /*0x2a8d2f4*/ void Invoke();
                /*0x2a90e08*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x2a90e34*/ void EndInvoke(System.IAsyncResult result);
            }

            class SWIG_CompletionDelegate : System.MulticastDelegate
            {
                /*0x2a8d060*/ SWIG_CompletionDelegate(object object, nint method);
                /*0x2a90e40*/ void Invoke(int index);
                /*0x2a9106c*/ System.IAsyncResult BeginInvoke(int index, System.AsyncCallback callback, object object);
                /*0x2a910f4*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ Firebase.Auth.Future_User fu;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<Firebase.Auth.FirebaseUser> tcs;

                /*0x2a8ca94*/ <>c__DisplayClass4_0();
                /*0x2a90ba8*/ void <GetTask>b__0();
            }
        }

        class Credential : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2a88bd8*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Auth.Credential obj);
            /*0x2a88b74*/ Credential(nint cPtr, bool cMemoryOwn);
            /*0x2a88c44*/ void Finalize();
            /*0x2a88e88*/ void Dispose();
            /*0x2a88cb0*/ void Dispose(bool disposing);
            /*0x2a88ef8*/ string get_Provider();
        }

        class FacebookAuthProvider
        {
            static /*0x2a89004*/ FacebookAuthProvider();
            static /*0x2a89060*/ Firebase.Auth.Credential GetCredential(string accessToken);
        }

        class GoogleAuthProvider
        {
            static /*0x2a8d6d4*/ GoogleAuthProvider();
            static /*0x2a8d730*/ Firebase.Auth.Credential GetCredential(string idToken, string accessToken);
        }

        class OAuthProvider
        {
            static /*0x2a8d870*/ OAuthProvider();
            static /*0x2a8d8cc*/ Firebase.Auth.Credential GetCredential(string ProviderId, string idToken, string rawNonce, string accessToken);
        }

        class UserInfoInterface : Firebase.Auth.IUserInfo, System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2a8da24*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Auth.UserInfoInterface obj);
            /*0x2a8b714*/ UserInfoInterface(nint cPtr, bool cMemoryOwn);
            /*0x2a8da90*/ void Finalize();
            /*0x2a8a1bc*/ void Dispose();
            /*0x2a8b960*/ void Dispose(bool disposing);
            /*0x2a8db04*/ string get_Email();
            /*0x2a8dc10*/ string get_ProviderId();
        }

        class FirebaseUser : Firebase.Auth.UserInfoInterface
        {
            /*0x28*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x38*/ Firebase.Auth.FirebaseAuth authProxy;

            static /*0x2a8a72c*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Auth.FirebaseUser obj);
            /*0x2a8b5e0*/ FirebaseUser(nint cPtr, bool cMemoryOwn);
            /*0x2a8b778*/ void Dispose(bool disposing);
            /*0x2a8bb38*/ System.Threading.Tasks.Task<string> TokenAsync(bool forceRefresh);
            /*0x2a8bca0*/ System.Threading.Tasks.Task UpdateEmailAsync(string email);
            /*0x2a8bd74*/ System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> LinkWithCredentialAsync(Firebase.Auth.Credential credential);
            /*0x2a8bee8*/ System.Threading.Tasks.Task ReloadAsync();
            /*0x2a8bfb4*/ bool get_IsAnonymous();
            /*0x2a8c0c0*/ System.Collections.Generic.IEnumerable<Firebase.Auth.IUserInfo> get_ProviderData();
            /*0x2a8c550*/ string get_UserId();
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
            /*0x48*/ Firebase.Auth.FirebaseUser currentUser;
            /*0x50*/ System.EventHandler stateChangedImpl;
            /*0x58*/ System.EventHandler idTokenChangedImpl;
            /*0x60*/ bool persistentLoaded;

            static /*0x2a8b68c*/ FirebaseAuth();
            static /*0x2a86d10*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Auth.FirebaseAuth obj);
            static /*0x2a89900*/ Firebase.Auth.FirebaseAuth ProxyFromAppCPtr(nint appCPtr);
            static /*0x2a89b1c*/ Firebase.Auth.FirebaseAuth GetAuth(Firebase.FirebaseApp app);
            static /*0x2a8a36c*/ void ForwardStateChange(nint appCPtr, System.Action<Firebase.Auth.FirebaseAuth> stateChangeClosure);
            static /*0x2a89190*/ void StateChangedFunction(nint appCPtr);
            static /*0x2a892bc*/ void IdTokenChangedFunction(nint appCPtr);
            static /*0x2a8b3e0*/ Firebase.Auth.FirebaseAuth GetAuthInternal(Firebase.FirebaseApp app, ref Firebase.InitResult init_result_out);
            static /*0x2a8a01c*/ void LogHeartbeatInternal(Firebase.FirebaseApp app);
            static /*0x2a8a234*/ void ReleaseReferenceInternal(Firebase.Auth.FirebaseAuth instance);
            /*0x2a893e8*/ FirebaseAuth(nint cPtr, bool cMemoryOwn);
            /*0x2a89450*/ void Finalize();
            /*0x2a894bc*/ void Dispose();
            /*0x2a894b8*/ void Dispose(bool disposing);
            /*0x2a89a98*/ void ThrowIfNull();
            /*0x2a8a1b8*/ void OnAppDisposed(object sender, System.EventArgs eventArgs);
            /*0x2a89528*/ void DisposeInternal();
            /*0x2a8a5b0*/ Firebase.Auth.FirebaseUser UpdateCurrentUser(Firebase.Auth.FirebaseUser proxy);
            /*0x2a8a798*/ Firebase.Auth.FirebaseUser get_CurrentUser();
            /*0x2a8a950*/ System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> SignInWithCredentialAsync(Firebase.Auth.Credential credential);
            /*0x2a8ac30*/ System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> SignInAnonymouslyAsync();
            /*0x2a8aeec*/ void CompleteFirebaseUserTask(System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> task, System.Threading.Tasks.TaskCompletionSource<Firebase.Auth.FirebaseUser> taskCompletionSource);
            /*0x2a8aabc*/ System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> SignInWithCredentialInternalAsync(Firebase.Auth.Credential credential);
            /*0x2a8ad94*/ System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> SignInAnonymouslyInternalAsync();
            /*0x2a8b2e0*/ void SignOut();
            /*0x2a8a7fc*/ Firebase.Auth.FirebaseUser get_CurrentUserInternal();

            class StateChangedDelegate : System.MulticastDelegate
            {
                /*0x2a8a158*/ StateChangedDelegate(object object, nint method);
                /*0x2a908e8*/ void Invoke(nint authCPtr);
                /*0x2a90b14*/ System.IAsyncResult BeginInvoke(nint authCPtr, System.AsyncCallback callback, object object);
                /*0x2a90b9c*/ void EndInvoke(System.IAsyncResult result);
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ Firebase.Auth.FirebaseAuth auth;
                /*0x18*/ Firebase.FirebaseApp app;

                /*0x2a8a00c*/ <>c__DisplayClass19_0();
            }

            class <>c__DisplayClass19_1
            {
                /*0x10*/ Firebase.InitResult init_result;
                /*0x18*/ Firebase.Auth.FirebaseAuth.<> CS$<>8__locals1;

                /*0x2a8a014*/ <>c__DisplayClass19_1();
                /*0x2a90780*/ void <GetAuth>b__0();
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ System.Action<Firebase.Auth.FirebaseAuth> stateChangeClosure;

                /*0x2a8a5a0*/ <>c__DisplayClass22_0();
            }

            class <>c__DisplayClass22_1
            {
                /*0x10*/ Firebase.Auth.FirebaseAuth auth;
                /*0x18*/ Firebase.Auth.FirebaseAuth.<> CS$<>8__locals1;

                /*0x2a8a5a8*/ <>c__DisplayClass22_1();
                /*0x2a90848*/ void <ForwardStateChange>b__0();
            }

            class <>c
            {
                static /*0x0*/ Firebase.Auth.FirebaseAuth.<> <>9;
                static /*0x8*/ System.Action<Firebase.Auth.FirebaseAuth> <>9__23_0;
                static /*0x10*/ System.Action<Firebase.Auth.FirebaseAuth> <>9__24_0;

                static /*0x2a904f0*/ <>c();
                /*0x2a90550*/ <>c();
                /*0x2a90558*/ void <StateChangedFunction>b__23_0(Firebase.Auth.FirebaseAuth auth);
                /*0x2a906e4*/ void <IdTokenChangedFunction>b__24_0(Firebase.Auth.FirebaseAuth auth);
            }

            class <>c__DisplayClass48_0
            {
                /*0x10*/ Firebase.Auth.FirebaseAuth <>4__this;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<Firebase.Auth.FirebaseUser> taskCompletionSource;

                /*0x2a8aab4*/ <>c__DisplayClass48_0();
                /*0x2a908a8*/ void <SignInWithCredentialAsync>b__0(System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> task);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ Firebase.Auth.FirebaseAuth <>4__this;
                /*0x18*/ System.Threading.Tasks.TaskCompletionSource<Firebase.Auth.FirebaseUser> taskCompletionSource;

                /*0x2a8ad8c*/ <>c__DisplayClass50_0();
                /*0x2a908c8*/ void <SignInAnonymouslyAsync>b__0(System.Threading.Tasks.Task<Firebase.Auth.FirebaseUser> task);
            }
        }

        class AuthUtilPINVOKE
        {
            static /*0x0*/ Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Auth.AuthUtilPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2a873b0*/ AuthUtilPINVOKE();
            static /*0x2a87468*/ void UserInfoInterfaceList_Clear(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a874e8*/ void UserInfoInterfaceList_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2a87578*/ uint UserInfoInterfaceList_size(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a875f8*/ nint UserInfoInterfaceList_getitemcopy(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
            static /*0x2a87688*/ nint UserInfoInterfaceList_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
            static /*0x2a87718*/ void UserInfoInterfaceList_setitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
            static /*0x2a877b0*/ void UserInfoInterfaceList_Insert(System.Runtime.InteropServices.HandleRef jarg1, int jarg2, System.Runtime.InteropServices.HandleRef jarg3);
            static /*0x2a87848*/ void UserInfoInterfaceList_RemoveAt(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
            static /*0x2a878d8*/ bool UserInfoInterfaceList_Contains(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2a87970*/ int UserInfoInterfaceList_IndexOf(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2a87a00*/ bool UserInfoInterfaceList_Remove(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2a87a98*/ void delete_UserInfoInterfaceList(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a87b18*/ nint Future_User_SWIG_OnCompletion(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Auth.Future_User.SWIG_CompletionDelegate jarg2, int jarg3);
            static /*0x2a87bb8*/ void Future_User_SWIG_FreeCompletionData(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
            static /*0x2a87c48*/ nint Future_User_GetResult(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a87cc8*/ void delete_Future_User(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a87d48*/ void delete_Credential(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a87dc8*/ string Credential_Provider_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a87e60*/ nint FacebookAuthProvider_GetCredential(string jarg1);
            static /*0x2a87ef8*/ nint GoogleAuthProvider_GetCredential(string jarg1, string jarg2);
            static /*0x2a87fb8*/ nint OAuthProvider_GetCredential__SWIG_1(string jarg1, string jarg2, string jarg3, string jarg4);
            static /*0x2a880b8*/ void delete_UserInfoInterface(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a88138*/ string UserInfoInterface_Email_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a881d0*/ string UserInfoInterface_ProviderId_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a88268*/ void delete_FirebaseUser(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a882e8*/ nint FirebaseUser_Token(System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);
            static /*0x2a88378*/ nint FirebaseUser_UpdateEmail(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2a88424*/ nint FirebaseUser_LinkWithCredential(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2a884b4*/ nint FirebaseUser_Reload(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a88534*/ bool FirebaseUser_IsAnonymous_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a885bc*/ nint FirebaseUser_ProviderData_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a8863c*/ string FirebaseUser_UserId_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a886d4*/ nint FirebaseAuth_SignInWithCredentialInternal(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2a88764*/ nint FirebaseAuth_SignInAnonymouslyInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a887e4*/ void FirebaseAuth_SignOut(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a88864*/ nint FirebaseAuth_GetAuthInternal(System.Runtime.InteropServices.HandleRef jarg1, ref int jarg2);
            static /*0x2a888f4*/ void FirebaseAuth_LogHeartbeatInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a88974*/ void FirebaseAuth_ReleaseReferenceInternal(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a889f4*/ nint FirebaseAuth_CurrentUserInternal_get(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2a86d7c*/ nint CreateAuthStateListener(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Auth.FirebaseAuth.StateChangedDelegate jarg2);
            static /*0x2a86f5c*/ void DestroyAuthStateListener(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
            static /*0x2a87140*/ nint CreateIdTokenListener(System.Runtime.InteropServices.HandleRef jarg1, Firebase.Auth.FirebaseAuth.StateChangedDelegate jarg2);
            static /*0x2a87320*/ void DestroyIdTokenListener(System.Runtime.InteropServices.HandleRef jarg1, nint jarg2);
            static /*0x2a88a74*/ nint Future_User_SWIGUpcast(nint jarg1);
            static /*0x2a88af4*/ nint FirebaseUser_SWIGUpcast(nint jarg1);

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

                static /*0x2a8fe58*/ SWIGExceptionHelper();
                static /*0x2a8f9ec*/ void SWIGRegisterExceptionCallbacks_AuthUtil(Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2a8fb60*/ void SWIGRegisterExceptionCallbacksArgument_AuthUtil(Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Auth.AuthUtilPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2a8f04c*/ void SetPendingApplicationException(string message);
                static /*0x2a8f0f0*/ void SetPendingArithmeticException(string message);
                static /*0x2a8f194*/ void SetPendingDivideByZeroException(string message);
                static /*0x2a8f238*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2a8f2dc*/ void SetPendingInvalidCastException(string message);
                static /*0x2a8f380*/ void SetPendingInvalidOperationException(string message);
                static /*0x2a8f424*/ void SetPendingIOException(string message);
                static /*0x2a8f4c8*/ void SetPendingNullReferenceException(string message);
                static /*0x2a8f56c*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2a8f610*/ void SetPendingOverflowException(string message);
                static /*0x2a8f6b4*/ void SetPendingSystemException(string message);
                static /*0x2a8f758*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2a8f804*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2a8f8f8*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2a87458*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2a90218*/ ExceptionDelegate(object object, nint method);
                    /*0x2a91570*/ void Invoke(string message);
                    /*0x2a918e8*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2a9190c*/ void EndInvoke(System.IAsyncResult result);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2a90278*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2a911a0*/ void Invoke(string message, string paramName);
                    /*0x2a91534*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                    /*0x2a91564*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2a902d8*/ SWIGPendingException();
                static /*0x2a8ca9c*/ bool get_Pending();
                static /*0x2a8fc18*/ void Set(System.Exception e);
                static /*0x2a8cb38*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Auth.AuthUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2a903f8*/ SWIGStringHelper();
                static /*0x2a90374*/ void SWIGRegisterStringCallback_AuthUtil(Firebase.Auth.AuthUtilPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2a90370*/ string CreateString(string cString);
                /*0x2a87460*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2a90490*/ SWIGStringDelegate(object object, nint method);
                    /*0x2a91918*/ string Invoke(string message);
                    /*0x2a91c98*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2a91cbc*/ string EndInvoke(System.IAsyncResult result);
                }
            }
        }

        class AuthUtil
        {
            static /*0x2a86bbc*/ nint CreateAuthStateListener(Firebase.Auth.FirebaseAuth auth, Firebase.Auth.FirebaseAuth.StateChangedDelegate state_changed_delegate);
            static /*0x2a86e14*/ void DestroyAuthStateListener(Firebase.Auth.FirebaseAuth auth, nint listener);
            static /*0x2a86fec*/ nint CreateIdTokenListener(Firebase.Auth.FirebaseAuth auth, Firebase.Auth.FirebaseAuth.StateChangedDelegate state_changed_delegate);
            static /*0x2a871d8*/ void DestroyIdTokenListener(Firebase.Auth.FirebaseAuth auth, nint listener);
        }
    }
}
