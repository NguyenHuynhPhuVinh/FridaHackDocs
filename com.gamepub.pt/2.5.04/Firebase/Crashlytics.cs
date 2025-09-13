class <Module>
{
}

namespace Firebase
{
    namespace Crashlytics
    {
        class Crashlytics
        {
            static /*0x2ac4834*/ bool get_IsCrashlyticsCollectionEnabled();
            static /*0x2ac4904*/ void Initialize();
            static /*0x2ac495c*/ void Log(string message);
            static /*0x2ac49d0*/ void SetCustomKey(string key, string value);
            static /*0x2ac4a54*/ void LogException(System.Exception exception);

            class PlatformAccessor
            {
                static /*0x0*/ Firebase.Crashlytics.ExceptionHandler _exceptionHandler;
                static /*0x8*/ Firebase.Crashlytics.Impl _impl;
                static /*0x10*/ Firebase.FirebaseApp _app;

                static /*0x2ac7c90*/ PlatformAccessor();
                static /*0x2ac7e0c*/ Firebase.Crashlytics.ExceptionHandler get_ExceptionHandler();
                static /*0x2ac48a0*/ Firebase.Crashlytics.Impl get_Impl();
                static /*0x2ac7e70*/ Firebase.FirebaseApp get_App();
            }
        }

        class ExceptionHandler
        {
            /*0x10*/ bool isRegistered;

            /*0x2ac5ba8*/ ExceptionHandler();
            /*0x2ac54e4*/ void Register();
            /*0x2ac567c*/ void HandleException(object sender, System.UnhandledExceptionEventArgs eArgs);
            /*0x2ac5720*/ void HandleLog(string message, string stackTraceString, UnityEngine.LogType type);
            /*0x2ac57f8*/ string[] getMessageParts(string message);
            /*0x2ac5ad8*/ void LogException(Firebase.Crashlytics.LoggedException e);
        }

        class Impl
        {
            static /*0x0*/ string LogString;
            static /*0x8*/ string SetKeyValueString;
            static /*0x10*/ string SetUserIdentifierString;
            static /*0x18*/ string LogExceptionString;
            static /*0x20*/ string IsCrashlyticsCollectionEnabledString;
            static /*0x28*/ string SetCrashlyticsCollectionEnabledString;

            static /*0x2ac6998*/ Impl();
            static /*0x2ac65c8*/ Firebase.Crashlytics.Impl Make();
            /*0x2ac315c*/ Impl();
            /*0x2ac6688*/ bool IsSDKInitialized();
            /*0x2ac6690*/ void Log(string message);
            /*0x2ac6744*/ void SetCustomKey(string key, string value);
            /*0x2ac6808*/ void LogException(System.Exception exception);
            /*0x2ac68bc*/ bool IsCrashlyticsCollectionEnabled();
        }

        class LoggedException : System.Exception
        {
            /*0x88*/ string <Name>k__BackingField;
            /*0x90*/ string <CustomStackTrace>k__BackingField;
            /*0x98*/ System.Collections.Generic.Dictionary<string, string> <ParsedStackTrace>k__BackingField;

            static /*0x2ac3df4*/ Firebase.Crashlytics.LoggedException FromException(System.Exception exception);
            /*0x2ac59f4*/ LoggedException(string name, string message, string stackTrace);
            /*0x2ac6d60*/ string get_Name();
            /*0x2ac6d68*/ void set_Name(string value);
            /*0x2ac6d70*/ string get_CustomStackTrace();
            /*0x2ac6d78*/ void set_CustomStackTrace(string value);
            /*0x2ac6d80*/ System.Collections.Generic.Dictionary<string, string> get_ParsedStackTrace();
            /*0x2ac6d88*/ void set_ParsedStackTrace(System.Collections.Generic.Dictionary<string, string> value);
        }

        class Metadata
        {
            /*0x10*/ string uv;
            /*0x18*/ bool idb;
            /*0x20*/ string pt;
            /*0x28*/ int pc;
            /*0x2c*/ int pf;
            /*0x30*/ int sms;
            /*0x34*/ int gms;
            /*0x38*/ int gdid;
            /*0x3c*/ int gdvid;
            /*0x40*/ string gdn;
            /*0x48*/ string gdv;
            /*0x50*/ string gdver;
            /*0x58*/ UnityEngine.Rendering.GraphicsDeviceType gdt;
            /*0x5c*/ int gsl;
            /*0x60*/ int grtc;
            /*0x64*/ UnityEngine.Rendering.CopyTextureSupport gcts;
            /*0x68*/ int gmts;
            /*0x70*/ string ss;
            /*0x78*/ float sdpi;
            /*0x7c*/ int srr;

            /*0x2ac6d90*/ Metadata();
        }

        class MetadataBuilder
        {
            static /*0x0*/ string METADATA_KEY;

            static /*0x2ac6f8c*/ MetadataBuilder();
            static /*0x2ac3364*/ string GenerateMetadataJSON();
        }

        class StackTraceParser
        {
            static /*0x0*/ string FrameArgsRegex;
            static /*0x8*/ string FrameRegexWithoutFileInfo;
            static /*0x10*/ string FrameRegexWithFileInfo;
            static /*0x18*/ string MonoFilenameUnknownString;
            static /*0x20*/ string[] StringDelimiters;

            static /*0x2ac7a60*/ StackTraceParser();
            static /*0x2ac6aa0*/ System.Collections.Generic.Dictionary<string, string> ParseStackTraceString(string stackTrace);
            static /*0x2ac7678*/ System.Collections.Generic.Dictionary<string, string> ParseFrameString(string regex, string frameString);
        }

        class IOSImpl : Firebase.Crashlytics.Impl
        {
            /*0x2ac6564*/ IOSImpl();
        }

        class AndroidImpl : Firebase.Crashlytics.Impl
        {
            /*0x10*/ Firebase.Crashlytics.FirebaseCrashlyticsInternal crashlyticsInternal;
            /*0x18*/ Firebase.FirebaseApp firebaseApp;

            /*0x2ac2f4c*/ AndroidImpl();
            /*0x2ac34c0*/ void Finalize();
            /*0x2ac3528*/ void Dispose();
            /*0x2ac36b8*/ bool IsSDKInitialized();
            /*0x2ac36c8*/ void LogOperationFailedWarningDueToShutdown(string operation);
            T CallInternalMethod<T>(System.Func<T> methodCall, string operation, T errorValue);
            /*0x2ac375c*/ void CallInternalMethod(System.Action methodCall, string operation);
            /*0x2ac3904*/ void Log(string message);
            /*0x2ac3a2c*/ void SetCustomKey(string key, string value);
            /*0x2ac3b60*/ void LogException(System.Exception exception);
            /*0x2ac464c*/ bool IsCrashlyticsCollectionEnabled();
            /*0x2ac4710*/ bool <IsCrashlyticsCollectionEnabled>b__13_0();

            class <>c__DisplayClass9_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ string message;

                /*0x2ac3a24*/ <>c__DisplayClass9_0();
                /*0x2ac7c64*/ void <Log>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ string key;
                /*0x20*/ string value;

                /*0x2ac3b58*/ <>c__DisplayClass10_0();
                /*0x2ac7bd8*/ void <SetCustomKey>b__0();
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ Firebase.Crashlytics.LoggedException loggedException;
                /*0x20*/ Firebase.Crashlytics.StackFrames frames;

                /*0x2ac3dec*/ <>c__DisplayClass12_0();
                /*0x2ac7c04*/ void <LogException>b__0();
            }
        }

        class StackFrames : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<Firebase.Crashlytics.FirebaseCrashlyticsFrame>
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2ac64f8*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Crashlytics.StackFrames obj);
            /*0x2ac6ff0*/ StackFrames(nint cPtr, bool cMemoryOwn);
            /*0x2ac3ee0*/ StackFrames();
            /*0x2ac7054*/ void Finalize();
            /*0x2ac70c8*/ void Dispose();
            /*0x2ac7140*/ void Dispose(bool disposing);
            /*0x2ac7318*/ Firebase.Crashlytics.FirebaseCrashlyticsFrame get_Item(int index);
            /*0x2ac7464*/ int get_Count();
            /*0x2ac7574*/ System.Collections.Generic.IEnumerator<Firebase.Crashlytics.FirebaseCrashlyticsFrame> global::System.Collections.Generic.IEnumerable<Firebase.Crashlytics.FirebaseCrashlyticsFrame>.GetEnumerator();
            /*0x2ac761c*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
            /*0x2ac4528*/ void Add(Firebase.Crashlytics.FirebaseCrashlyticsFrame x);
            /*0x2ac7468*/ uint size();
            /*0x2ac731c*/ Firebase.Crashlytics.FirebaseCrashlyticsFrame getitem(int index);

            class StackFramesEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<Firebase.Crashlytics.FirebaseCrashlyticsFrame>, System.IDisposable
            {
                /*0x10*/ Firebase.Crashlytics.StackFrames collectionRef;
                /*0x18*/ int currentIndex;
                /*0x20*/ object currentObject;
                /*0x28*/ int currentSize;

                /*0x2ac75d0*/ StackFramesEnumerator(Firebase.Crashlytics.StackFrames collection);
                /*0x2ac951c*/ Firebase.Crashlytics.FirebaseCrashlyticsFrame get_Current();
                /*0x2ac963c*/ object global::System.Collections.IEnumerator.get_Current();
                /*0x2ac9640*/ bool MoveNext();
                /*0x2ac96b0*/ void Reset();
                /*0x2ac973c*/ void Dispose();
            }
        }

        class FirebaseCrashlyticsFrame : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2ac5c18*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Crashlytics.FirebaseCrashlyticsFrame obj);
            /*0x2ac5bb4*/ FirebaseCrashlyticsFrame(nint cPtr, bool cMemoryOwn);
            /*0x2ac3fe4*/ FirebaseCrashlyticsFrame();
            /*0x2ac5c84*/ void Finalize();
            /*0x2ac5cf8*/ void Dispose();
            /*0x2ac5d70*/ void Dispose(bool disposing);
            /*0x2ac40e8*/ void set_library(string value);
            /*0x2ac41f8*/ void set_symbol(string value);
            /*0x2ac4308*/ void set_fileName(string value);
            /*0x2ac4418*/ void set_lineNumber(string value);
        }

        class FirebaseCrashlyticsInternal : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2ac3164*/ Firebase.Crashlytics.FirebaseCrashlyticsInternal GetInstance(Firebase.FirebaseApp app, ref Firebase.InitResult init_result_out);
            /*0x2ac5f48*/ FirebaseCrashlyticsInternal(nint cPtr, bool cMemoryOwn);
            /*0x2ac5fac*/ void Finalize();
            /*0x2ac3640*/ void Dispose();
            /*0x2ac6020*/ void Dispose(bool disposing);
            /*0x2ac38bc*/ bool get_IsDisposed();
            /*0x2ac6194*/ void Log(string message);
            /*0x2ac62a4*/ void SetCustomKey(string key, string value);
            /*0x2ac63bc*/ void LogException(string name, string reason, Firebase.Crashlytics.StackFrames frames);
            /*0x2ac4728*/ bool IsCrashlyticsCollectionEnabled();
        }

        class CrashlyticsInternalPINVOKE
        {
            static /*0x0*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2ac4ac8*/ CrashlyticsInternalPINVOKE();
            static /*0x2ac4b80*/ void StackFrames_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2ac4c10*/ uint StackFrames_size(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2ac4c90*/ nint new_StackFrames__SWIG_0();
            static /*0x2ac4d04*/ nint StackFrames_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
            static /*0x2ac4d94*/ void delete_StackFrames(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2ac4e14*/ void FirebaseCrashlyticsFrame_library_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2ac4eb8*/ void FirebaseCrashlyticsFrame_symbol_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2ac4f5c*/ void FirebaseCrashlyticsFrame_fileName_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2ac5000*/ void FirebaseCrashlyticsFrame_lineNumber_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2ac50a4*/ nint new_FirebaseCrashlyticsFrame();
            static /*0x2ac5118*/ void delete_FirebaseCrashlyticsFrame(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2ac5198*/ nint FirebaseCrashlyticsInternal_GetInstance__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1, ref int jarg2);
            static /*0x2ac5228*/ void FirebaseCrashlyticsInternal_Log(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2ac52cc*/ void FirebaseCrashlyticsInternal_SetCustomKey(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
            static /*0x2ac538c*/ void FirebaseCrashlyticsInternal_LogException(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, System.Runtime.InteropServices.HandleRef jarg4);
            static /*0x2ac545c*/ bool FirebaseCrashlyticsInternal_IsCrashlyticsCollectionEnabled(System.Runtime.InteropServices.HandleRef jarg1);

            class SWIGExceptionHelper
            {
                static /*0x0*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate;
                static /*0x8*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate;
                static /*0x10*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate;
                static /*0x18*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate;
                static /*0x20*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate;
                static /*0x28*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate;
                static /*0x30*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate;
                static /*0x38*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate;
                static /*0x40*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate;
                static /*0x48*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate;
                static /*0x50*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemDelegate;
                static /*0x58*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate;
                static /*0x60*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate;
                static /*0x68*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate;

                static /*0x2ac8e84*/ SWIGExceptionHelper();
                static /*0x2ac8874*/ void SWIGRegisterExceptionCallbacks_CrashlyticsInternal(Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2ac89e8*/ void SWIGRegisterExceptionCallbacksArgument_CrashlyticsInternal(Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2ac7ed4*/ void SetPendingApplicationException(string message);
                static /*0x2ac7f78*/ void SetPendingArithmeticException(string message);
                static /*0x2ac801c*/ void SetPendingDivideByZeroException(string message);
                static /*0x2ac80c0*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2ac8164*/ void SetPendingInvalidCastException(string message);
                static /*0x2ac8208*/ void SetPendingInvalidOperationException(string message);
                static /*0x2ac82ac*/ void SetPendingIOException(string message);
                static /*0x2ac8350*/ void SetPendingNullReferenceException(string message);
                static /*0x2ac83f4*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2ac8498*/ void SetPendingOverflowException(string message);
                static /*0x2ac853c*/ void SetPendingSystemException(string message);
                static /*0x2ac85e0*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2ac868c*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2ac8780*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2ac4b70*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2ac9244*/ ExceptionDelegate(object object, nint method);
                    /*0x2ac9b1c*/ void Invoke(string message);
                    /*0x2ac9e94*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2ac9eb8*/ void EndInvoke(System.IAsyncResult result);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2ac92a4*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2ac974c*/ void Invoke(string message, string paramName);
                    /*0x2ac9ae0*/ System.IAsyncResult BeginInvoke(string message, string paramName, System.AsyncCallback callback, object object);
                    /*0x2ac9b10*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2ac9304*/ SWIGPendingException();
                static /*0x2ac8c44*/ void Set(System.Exception e);
                static /*0x2ac8aa0*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2ac9424*/ SWIGStringHelper();
                static /*0x2ac93a0*/ void SWIGRegisterStringCallback_CrashlyticsInternal(Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2ac939c*/ string CreateString(string cString);
                /*0x2ac4b78*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2ac94bc*/ SWIGStringDelegate(object object, nint method);
                    /*0x2ac9ec4*/ string Invoke(string message);
                    /*0x2aca244*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                    /*0x2aca268*/ string EndInvoke(System.IAsyncResult result);
                }
            }
        }
    }
}
