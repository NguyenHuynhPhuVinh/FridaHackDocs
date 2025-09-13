class <Module>
{
}

namespace Firebase
{
    namespace Messaging
    {
        class MessageReceivedEventArgs : System.EventArgs
        {
            /*0x10*/ Firebase.Messaging.FirebaseMessage <Message>k__BackingField;

            /*0x2aef364*/ MessageReceivedEventArgs(Firebase.Messaging.FirebaseMessage msg);
            /*0x2aef3dc*/ void set_Message(Firebase.Messaging.FirebaseMessage value);
        }

        class TokenReceivedEventArgs : System.EventArgs
        {
            /*0x10*/ string <Token>k__BackingField;

            /*0x2aef3e4*/ TokenReceivedEventArgs(string token);
            /*0x2aef45c*/ string get_Token();
            /*0x2aef464*/ void set_Token(string value);
        }

        class FirebaseMessage : System.IDisposable
        {
            static /*0x0*/ System.DateTime UnixEpochUtc;
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2aeda78*/ FirebaseMessage();
            /*0x2aed6e0*/ FirebaseMessage(nint cPtr, bool cMemoryOwn);
            /*0x2aed744*/ void Finalize();
            /*0x2aed988*/ void Dispose();
            /*0x2aed7b0*/ void Dispose(bool disposing);
        }

        class FirebaseMessagingPINVOKE
        {
            static /*0x0*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2aef2ac*/ FirebaseMessagingPINVOKE();
            static /*0x2aed9f8*/ void delete_FirebaseMessage(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2aeed98*/ nint Subscribe(string jarg1);
            static /*0x2aeeef4*/ nint Unsubscribe(string jarg1);
            static /*0x2aeef8c*/ nint GetTokenInternalAsync();
            static /*0x2aef108*/ void SetListenerCallbacks(Firebase.Messaging.FirebaseMessaging.Listener.MessageReceivedDelegate jarg1, Firebase.Messaging.FirebaseMessaging.Listener.TokenReceivedDelegate jarg2);
            static /*0x2aef1ac*/ void SetListenerCallbacksEnabled(bool jarg1, bool jarg2);
            static /*0x2aef23c*/ void SendPendingEvents();

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x2af0a00*/ SWIGExceptionHelper();
                static /*0x2af03f0*/ void SWIGRegisterExceptionCallbacks_FirebaseMessaging(Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2af0564*/ void SWIGRegisterExceptionCallbacksArgument_FirebaseMessaging(Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2aefa50*/ void SetPendingApplicationException(string message);
                static /*0x2aefaf4*/ void SetPendingArithmeticException(string message);
                static /*0x2aefb98*/ void SetPendingDivideByZeroException(string message);
                static /*0x2aefc3c*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2aefce0*/ void SetPendingInvalidCastException(string message);
                static /*0x2aefd84*/ void SetPendingInvalidOperationException(string message);
                static /*0x2aefe28*/ void SetPendingIOException(string message);
                static /*0x2aefecc*/ void SetPendingNullReferenceException(string message);
                static /*0x2aeff70*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2af0014*/ void SetPendingOverflowException(string message);
                static /*0x2af00b8*/ void SetPendingSystemException(string message);
                static /*0x2af015c*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2af0208*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2af02fc*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2aef354*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2af0dc0*/ ExceptionDelegate(object object, nint method);
                    /*0x2af1cd0*/ void Invoke(string message);
                    /*0x2af2048*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2af206c*/ void EndInvoke(System.IAsyncResult result);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2af0e20*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2af1900*/ void Invoke(string message, string paramName);
                    /*0x2af1c94*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                    /*0x2af1cc4*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2af0e80*/ SWIGPendingException();
                static /*0x2af07c0*/ void Set(System.Exception e);
                static /*0x2af061c*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2af0fa0*/ SWIGStringHelper();
                static /*0x2af0f1c*/ void SWIGRegisterStringCallback_FirebaseMessaging(Firebase.Messaging.FirebaseMessagingPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2af0f18*/ string CreateString(string cString);
                /*0x2aef35c*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2af1038*/ SWIGStringDelegate(object object, nint method);
                    /*0x2af2078*/ string Invoke(string message);
                    /*0x2af23f8*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2af241c*/ string EndInvoke(System.IAsyncResult result);
                }
            }
        }

        class FirebaseMessaging
        {
            static /*0x0*/ System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> MessageReceivedInternal;
            static /*0x8*/ System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> TokenReceivedInternal;
            static /*0x10*/ Firebase.Messaging.FirebaseMessaging.Listener listener;

            static /*0x2aee56c*/ FirebaseMessaging();
            static /*0x2aedb04*/ void add_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value);
            static /*0x2aedbf8*/ void remove_MessageReceivedInternal(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value);
            static /*0x2aedcec*/ void add_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value);
            static /*0x2aedde4*/ void remove_TokenReceivedInternal(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value);
            static /*0x2aededc*/ void CreateOrDestroyListener();
            static /*0x2aee5bc*/ System.Threading.Tasks.Task<string> GetTokenAsync();
            static /*0x2aee764*/ void add_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value);
            static /*0x2aee8c0*/ void remove_MessageReceived(System.EventHandler<Firebase.Messaging.MessageReceivedEventArgs> value);
            static /*0x2aeea1c*/ void add_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value);
            static /*0x2aeeb78*/ void remove_TokenReceived(System.EventHandler<Firebase.Messaging.TokenReceivedEventArgs> value);
            static /*0x2aeecd4*/ System.Threading.Tasks.Task SubscribeAsync(string topic);
            static /*0x2aeee30*/ System.Threading.Tasks.Task UnsubscribeAsync(string topic);
            static /*0x2aee614*/ System.Threading.Tasks.Task<string> GetTokenInternalAsync();
            static /*0x2aef000*/ void SetListenerCallbacks(Firebase.Messaging.FirebaseMessaging.Listener.MessageReceivedDelegate messageCallback, Firebase.Messaging.FirebaseMessaging.Listener.TokenReceivedDelegate tokenCallback);
            static /*0x2aee374*/ void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled);
            static /*0x2aee47c*/ void SendPendingEvents();

            class Listener : System.IDisposable
            {
                static /*0x0*/ Firebase.Messaging.FirebaseMessaging.Listener listener;
                /*0x10*/ Firebase.Messaging.FirebaseMessaging.Listener.MessageReceivedDelegate messageReceivedDelegate;
                /*0x18*/ Firebase.Messaging.FirebaseMessaging.Listener.TokenReceivedDelegate tokenReceivedDelegate;
                /*0x20*/ Firebase.FirebaseApp app;

                static /*0x2aee0ac*/ Firebase.Messaging.FirebaseMessaging.Listener Create();
                static /*0x2aee22c*/ void Destroy();
                static /*0x2aef46c*/ int MessageReceivedDelegateMethod(nint message);
                static /*0x2aef574*/ void TokenReceivedDelegateMethod(string token);
                /*0x2aef650*/ Listener();
                /*0x2aef9d8*/ void Finalize();
                /*0x2aef784*/ void Dispose();

                class MessageReceivedDelegate : System.MulticastDelegate
                {
                    /*0x2aef918*/ MessageReceivedDelegate(object object, nint method);
                    /*0x2af1270*/ int Invoke(nint message);
                    /*0x2af14a4*/ System.IAsyncResult BeginInvoke(nint message, System.AsyncCallback callback, object object);
                    /*0x2af152c*/ int EndInvoke(System.IAsyncResult result);
                }

                class TokenReceivedDelegate : System.MulticastDelegate
                {
                    /*0x2aef978*/ TokenReceivedDelegate(object object, nint method);
                    /*0x2af1558*/ void Invoke(string token);
                    /*0x2af18d0*/ System.IAsyncResult BeginInvoke(string token, System.AsyncCallback callback, object object);
                    /*0x2af18f4*/ void EndInvoke(System.IAsyncResult result);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ nint message;

                    /*0x2aefa40*/ <>c__DisplayClass13_0();
                    /*0x2af1098*/ int <MessageReceivedDelegateMethod>b__0();
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ string token;

                    /*0x2aefa48*/ <>c__DisplayClass14_0();
                    /*0x2af119c*/ void <TokenReceivedDelegateMethod>b__0();
                }
            }
        }
    }
}
