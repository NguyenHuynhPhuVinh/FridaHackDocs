class <Module>
{
}

namespace Firebase
{
    namespace Analytics
    {
        class FirebaseAnalyticsPINVOKE
        {
            static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2b15f94*/ FirebaseAnalyticsPINVOKE();
            static /*0x2b15bc4*/ void LogEvent__SWIG_3(string jarg1, string jarg2, int jarg3);
            static /*0x2b15d7c*/ void LogEvent__SWIG_4(string jarg1);
            static /*0x2b15f04*/ void SetUserId(string jarg1);

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x2b16ffc*/ SWIGExceptionHelper();
                static /*0x2b169ec*/ void SWIGRegisterExceptionCallbacks_FirebaseAnalytics(Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2b16b60*/ void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalytics(Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2b1604c*/ void SetPendingApplicationException(string message);
                static /*0x2b160f0*/ void SetPendingArithmeticException(string message);
                static /*0x2b16194*/ void SetPendingDivideByZeroException(string message);
                static /*0x2b16238*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2b162dc*/ void SetPendingInvalidCastException(string message);
                static /*0x2b16380*/ void SetPendingInvalidOperationException(string message);
                static /*0x2b16424*/ void SetPendingIOException(string message);
                static /*0x2b164c8*/ void SetPendingNullReferenceException(string message);
                static /*0x2b1656c*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2b16610*/ void SetPendingOverflowException(string message);
                static /*0x2b166b4*/ void SetPendingSystemException(string message);
                static /*0x2b16758*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2b16804*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2b168f8*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2b1603c*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2b173bc*/ ExceptionDelegate(object object, nint method);
                    /*0x2b17a64*/ void Invoke(string message);
                    /*0x2b17ddc*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2b17e00*/ void EndInvoke(System.IAsyncResult result);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2b1741c*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2b17694*/ void Invoke(string message, string paramName);
                    /*0x2b17a28*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                    /*0x2b17a58*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2b1747c*/ SWIGPendingException();
                static /*0x2b16dbc*/ void Set(System.Exception e);
                static /*0x2b16c18*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2b1759c*/ SWIGStringHelper();
                static /*0x2b17518*/ void SWIGRegisterStringCallback_FirebaseAnalytics(Firebase.Analytics.FirebaseAnalyticsPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2b17514*/ string CreateString(string cString);
                /*0x2b16044*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2b17634*/ SWIGStringDelegate(object object, nint method);
                    /*0x2b17e0c*/ string Invoke(string message);
                    /*0x2b1818c*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2b181b0*/ string EndInvoke(System.IAsyncResult result);
                }
            }
        }

        class FirebaseAnalytics
        {
            static /*0x0*/ Firebase.FirebaseApp app;

            static /*0x2b15a34*/ FirebaseAnalytics();
            static /*0x2b15ab4*/ void LogEvent(string name, string parameterName, int parameterValue);
            static /*0x2b15c84*/ void LogEvent(string name);
            static /*0x2b15e0c*/ void SetUserId(string userId);
        }
    }
}
