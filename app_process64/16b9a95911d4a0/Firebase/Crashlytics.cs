class <Module>
{
}

namespace Firebase
{
    namespace Crashlytics
    {
        class Crashlytics
        {
            static /*0x0*/ bool <ReportUncaughtExceptionsAsFatal>k__BackingField;

            static /*0x2d3f450*/ bool get_ReportUncaughtExceptionsAsFatal();
            static /*0x2d3f498*/ void set_IsCrashlyticsCollectionEnabled(bool value);
            static /*0x2d3f558*/ void Initialize();
            static /*0x2d3f5a4*/ void Log(string message);
            static /*0x2d3f60c*/ void SetCustomKey(string key, string value);
            static /*0x2d3f684*/ void SetUserId(string identifier);
            static /*0x2d3f6ec*/ void LogException(System.Exception exception);
            static /*0x2d3f754*/ void LogExceptionAsFatal(System.Exception exception);

            class PlatformAccessor
            {
                static /*0x0*/ Firebase.Crashlytics.ExceptionHandler _exceptionHandler;
                static /*0x8*/ Firebase.Crashlytics.Impl _impl;
                static /*0x10*/ Firebase.FirebaseApp _app;

                static /*0x2d3f7bc*/ PlatformAccessor();
                static /*0x2d3fbe4*/ Firebase.Crashlytics.ExceptionHandler get_ExceptionHandler();
                static /*0x2d3f500*/ Firebase.Crashlytics.Impl get_Impl();
                static /*0x2d3fc3c*/ Firebase.FirebaseApp get_App();
            }
        }

        class ExceptionHandler
        {
            /*0x10*/ bool isRegistered;

            /*0x2d3f954*/ ExceptionHandler();
            /*0x2d3fa14*/ void Register();
            /*0x2d3fc94*/ void HandleException(object sender, System.UnhandledExceptionEventArgs eArgs);
            /*0x2d3fe14*/ void HandleLog(string message, string stackTraceString, UnityEngine.LogType type);
            /*0x2d3fed4*/ string[] getMessageParts(string message);
            /*0x2d40198*/ void LogException(Firebase.Crashlytics.LoggedException e);
        }

        class Impl
        {
            static /*0x0*/ string LogString;
            static /*0x8*/ string SetKeyValueString;
            static /*0x10*/ string SetUserIdentifierString;
            static /*0x18*/ string LogExceptionString;
            static /*0x20*/ string LogExceptionAsFatalString;
            static /*0x28*/ string IsCrashlyticsCollectionEnabledString;
            static /*0x30*/ string SetCrashlyticsCollectionEnabledString;

            static /*0x2d408fc*/ Impl();
            static /*0x2d3f960*/ Firebase.Crashlytics.Impl Make();
            /*0x2d404f0*/ Impl();
            /*0x2d404f8*/ bool IsSDKInitialized();
            /*0x2d40500*/ void Log(string message);
            /*0x2d405a0*/ void SetCustomKey(string key, string value);
            /*0x2d40650*/ void SetUserId(string identifier);
            /*0x2d406f0*/ void LogException(System.Exception exception);
            /*0x2d40790*/ void LogExceptionAsFatal(System.Exception exception);
            /*0x2d40830*/ void SetCrashlyticsCollectionEnabled(bool enabled);
        }

        class LoggedException : System.Exception
        {
            /*0x90*/ string <Name>k__BackingField;
            /*0x98*/ string <CustomStackTrace>k__BackingField;
            /*0xa0*/ System.Collections.Generic.Dictionary<string, string> <ParsedStackTrace>k__BackingField;

            static /*0x2d3fd2c*/ Firebase.Crashlytics.LoggedException FromException(System.Exception exception);
            /*0x2d40098*/ LoggedException(string name, string message, string stackTrace);
            /*0x2d40cd0*/ string get_Name();
            /*0x2d40cd8*/ void set_Name(string value);
            /*0x2d40ce0*/ string get_CustomStackTrace();
            /*0x2d40ce8*/ void set_CustomStackTrace(string value);
            /*0x2d40cf0*/ System.Collections.Generic.Dictionary<string, string> get_ParsedStackTrace();
            /*0x2d40cf8*/ void set_ParsedStackTrace(System.Collections.Generic.Dictionary<string, string> value);
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

            /*0x2d40d00*/ Metadata();
        }

        class MetadataBuilder
        {
            static /*0x0*/ string METADATA_KEY;

            static /*0x2d41084*/ MetadataBuilder();
            static /*0x2d40f48*/ string GenerateMetadataJSON();
        }

        class StackTraceParser
        {
            static /*0x0*/ string FrameArgsRegex;
            static /*0x8*/ string FrameRegexWithoutFileInfo;
            static /*0x10*/ string FrameRegexWithFileInfo;
            static /*0x18*/ string MonoFilenameUnknownString;
            static /*0x20*/ string[] StringDelimiters;

            static /*0x2d414c8*/ StackTraceParser();
            static /*0x2d40a6c*/ System.Collections.Generic.Dictionary<string, string> ParseStackTraceString(string stackTrace);
            static /*0x2d410ec*/ System.Collections.Generic.Dictionary<string, string> ParseFrameString(string regex, string frameString);
        }

        class IOSImpl : Firebase.Crashlytics.Impl
        {
            /*0x2d402b0*/ IOSImpl();
        }

        class AndroidImpl : Firebase.Crashlytics.Impl
        {
            /*0x10*/ Firebase.Crashlytics.FirebaseCrashlyticsInternal crashlyticsInternal;
            /*0x18*/ Firebase.FirebaseApp firebaseApp;

            /*0x2d40308*/ AndroidImpl();
            /*0x2d4181c*/ void Finalize();
            /*0x2d418a0*/ void Dispose();
            /*0x2d41a28*/ bool IsSDKInitialized();
            /*0x2d41a38*/ void LogOperationFailedWarningDueToShutdown(string operation);
            /*0x2d41ac8*/ void CallInternalMethod(System.Action methodCall, string operation);
            /*0x2d41c38*/ void Log(string message);
            /*0x2d41d80*/ void SetCustomKey(string key, string value);
            /*0x2d41ee8*/ void SetUserId(string identifier);
            /*0x2d42030*/ void LogException(System.Exception exception);
            /*0x2d428c4*/ void LogExceptionAsFatal(System.Exception exception);
            /*0x2d42c7c*/ void SetCrashlyticsCollectionEnabled(bool enabled);

            class <>c__DisplayClass9_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ string message;

                /*0x2d41d78*/ <>c__DisplayClass9_0();
                /*0x2d42d70*/ void <Log>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ string key;
                /*0x20*/ string value;

                /*0x2d41ee0*/ <>c__DisplayClass10_0();
                /*0x2d42e6c*/ void <SetCustomKey>b__0();
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ string identifier;

                /*0x2d42028*/ <>c__DisplayClass11_0();
                /*0x2d42f70*/ void <SetUserId>b__0();
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ Firebase.Crashlytics.LoggedException loggedException;
                /*0x20*/ Firebase.Crashlytics.StackFrames frames;

                /*0x2d422f4*/ <>c__DisplayClass12_0();
                /*0x2d4306c*/ void <LogException>b__0();
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ Firebase.Crashlytics.LoggedException loggedException;
                /*0x20*/ Firebase.Crashlytics.StackFrames frames;

                /*0x2d42c74*/ <>c__DisplayClass13_0();
                /*0x2d431c0*/ void <LogExceptionAsFatal>b__0();
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ Firebase.Crashlytics.AndroidImpl <>4__this;
                /*0x18*/ bool enabled;

                /*0x2d42d68*/ <>c__DisplayClass15_0();
                /*0x2d43314*/ void <SetCrashlyticsCollectionEnabled>b__0();
            }
        }

        class StackFrames : System.IDisposable, System.Collections.IEnumerable, System.Collections.Generic.IEnumerable<Firebase.Crashlytics.FirebaseCrashlyticsFrame>
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2d43470*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Crashlytics.StackFrames obj);
            /*0x2d43410*/ StackFrames(nint cPtr, bool cMemoryOwn);
            /*0x2d422fc*/ StackFrames();
            /*0x2d434b4*/ void Finalize();
            /*0x2d43544*/ void Dispose();
            /*0x2d435b0*/ void Dispose(bool disposing);
            /*0x2d437d8*/ Firebase.Crashlytics.FirebaseCrashlyticsFrame get_Item(int index);
            /*0x2d438e8*/ int get_Count();
            /*0x2d439bc*/ System.Collections.Generic.IEnumerator<Firebase.Crashlytics.FirebaseCrashlyticsFrame> global::System.Collections.Generic.IEnumerable<Firebase.Crashlytics.FirebaseCrashlyticsFrame>.GetEnumerator();
            /*0x2d43a78*/ System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator();
            /*0x2d427dc*/ void Add(Firebase.Crashlytics.FirebaseCrashlyticsFrame x);
            /*0x2d438ec*/ uint size();
            /*0x2d437dc*/ Firebase.Crashlytics.FirebaseCrashlyticsFrame getitem(int index);

            class StackFramesEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<Firebase.Crashlytics.FirebaseCrashlyticsFrame>, System.IDisposable
            {
                /*0x10*/ Firebase.Crashlytics.StackFrames collectionRef;
                /*0x18*/ int currentIndex;
                /*0x20*/ object currentObject;
                /*0x28*/ int currentSize;

                /*0x2d43a14*/ StackFramesEnumerator(Firebase.Crashlytics.StackFrames collection);
                /*0x2d43d5c*/ Firebase.Crashlytics.FirebaseCrashlyticsFrame get_Current();
                /*0x2d43e78*/ object global::System.Collections.IEnumerator.get_Current();
                /*0x2d43e7c*/ bool MoveNext();
                /*0x2d43ef4*/ void Reset();
                /*0x2d43f8c*/ void Dispose();
            }
        }

        class FirebaseCrashlyticsFrame : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2d43b34*/ System.Runtime.InteropServices.HandleRef getCPtr(Firebase.Crashlytics.FirebaseCrashlyticsFrame obj);
            /*0x2d43cfc*/ FirebaseCrashlyticsFrame(nint cPtr, bool cMemoryOwn);
            /*0x2d423c4*/ FirebaseCrashlyticsFrame();
            /*0x2d43fa0*/ void Finalize();
            /*0x2d44030*/ void Dispose();
            /*0x2d4409c*/ void Dispose(bool disposing);
            /*0x2d4248c*/ void set_library(string value);
            /*0x2d42560*/ void set_symbol(string value);
            /*0x2d42634*/ void set_fileName(string value);
            /*0x2d42708*/ void set_lineNumber(string value);
        }

        class FirebaseCrashlyticsInternal : System.IDisposable
        {
            /*0x10*/ System.Runtime.InteropServices.HandleRef swigCPtr;
            /*0x20*/ bool swigCMemOwn;

            static /*0x2d41654*/ Firebase.Crashlytics.FirebaseCrashlyticsInternal GetInstance(Firebase.FirebaseApp app, ref Firebase.InitResult init_result_out);
            /*0x2d44588*/ FirebaseCrashlyticsInternal(nint cPtr, bool cMemoryOwn);
            /*0x2d445e8*/ void Finalize();
            /*0x2d419bc*/ void Dispose();
            /*0x2d44678*/ void Dispose(bool disposing);
            /*0x2d41c28*/ bool get_IsDisposed();
            /*0x2d42d98*/ void Log(string message);
            /*0x2d42e94*/ void SetCustomKey(string key, string value);
            /*0x2d42f98*/ void SetUserId(string id);
            /*0x2d430c0*/ void LogException(string name, string reason, Firebase.Crashlytics.StackFrames frames);
            /*0x2d43214*/ void LogExceptionAsFatal(string name, string reason, Firebase.Crashlytics.StackFrames frames);
            /*0x2d4333c*/ void SetCrashlyticsCollectionEnabled(bool enabled);
        }

        class CrashlyticsInternalPINVOKE
        {
            static /*0x0*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper swigExceptionHelper;
            static /*0x8*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper swigStringHelper;

            static /*0x2d44c54*/ CrashlyticsInternalPINVOKE();
            static /*0x2d43ad0*/ nint new_StackFrames__SWIG_0();
            static /*0x2d43b78*/ void StackFrames_Add(System.Runtime.InteropServices.HandleRef jarg1, System.Runtime.InteropServices.HandleRef jarg2);
            static /*0x2d43bfc*/ uint StackFrames_size(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d43c78*/ nint StackFrames_getitem(System.Runtime.InteropServices.HandleRef jarg1, int jarg2);
            static /*0x2d4375c*/ void delete_StackFrames(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d442c4*/ void FirebaseCrashlyticsFrame_library_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d4435c*/ void FirebaseCrashlyticsFrame_symbol_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d443f4*/ void FirebaseCrashlyticsFrame_fileName_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d4448c*/ void FirebaseCrashlyticsFrame_lineNumber_set(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d44524*/ nint new_FirebaseCrashlyticsFrame();
            static /*0x2d44248*/ void delete_FirebaseCrashlyticsFrame(System.Runtime.InteropServices.HandleRef jarg1);
            static /*0x2d447d8*/ nint FirebaseCrashlyticsInternal_GetInstance__SWIG_0(System.Runtime.InteropServices.HandleRef jarg1, ref int jarg2);
            static /*0x2d4485c*/ void FirebaseCrashlyticsInternal_Log(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d448f4*/ void FirebaseCrashlyticsInternal_SetCustomKey(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);
            static /*0x2d449b0*/ void FirebaseCrashlyticsInternal_SetUserId(System.Runtime.InteropServices.HandleRef jarg1, string jarg2);
            static /*0x2d44a48*/ void FirebaseCrashlyticsInternal_LogException(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, System.Runtime.InteropServices.HandleRef jarg4);
            static /*0x2d44b0c*/ void FirebaseCrashlyticsInternal_LogExceptionAsFatal(System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3, System.Runtime.InteropServices.HandleRef jarg4);
            static /*0x2d44bd0*/ void FirebaseCrashlyticsInternal_SetCrashlyticsCollectionEnabled(System.Runtime.InteropServices.HandleRef jarg1, bool jarg2);

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

                static /*0x2d45b70*/ SWIGExceptionHelper();
                static /*0x2d455b4*/ void SWIGRegisterExceptionCallbacks_CrashlyticsInternal(Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate applicationDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate arithmeticDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate divideByZeroDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate indexOutOfRangeDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidCastDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate invalidOperationDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate ioDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate nullReferenceDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate outOfMemoryDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate overflowDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionDelegate systemExceptionDelegate);
                static /*0x2d45720*/ void SWIGRegisterExceptionCallbacksArgument_CrashlyticsInternal(Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentNullDelegate, Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGExceptionHelper.ExceptionArgumentDelegate argumentOutOfRangeDelegate);
                static /*0x2d44d24*/ void SetPendingApplicationException(string message);
                static /*0x2d44db4*/ void SetPendingArithmeticException(string message);
                static /*0x2d44e44*/ void SetPendingDivideByZeroException(string message);
                static /*0x2d44ed4*/ void SetPendingIndexOutOfRangeException(string message);
                static /*0x2d44f64*/ void SetPendingInvalidCastException(string message);
                static /*0x2d44ff4*/ void SetPendingInvalidOperationException(string message);
                static /*0x2d45084*/ void SetPendingIOException(string message);
                static /*0x2d45114*/ void SetPendingNullReferenceException(string message);
                static /*0x2d451a4*/ void SetPendingOutOfMemoryException(string message);
                static /*0x2d45234*/ void SetPendingOverflowException(string message);
                static /*0x2d452c4*/ void SetPendingSystemException(string message);
                static /*0x2d45354*/ void SetPendingArgumentException(string message, string paramName);
                static /*0x2d453f4*/ void SetPendingArgumentNullException(string message, string paramName);
                static /*0x2d454d4*/ void SetPendingArgumentOutOfRangeException(string message, string paramName);
                /*0x2d44d14*/ SWIGExceptionHelper();

                class ExceptionDelegate : System.MulticastDelegate
                {
                    /*0x2d45fc0*/ ExceptionDelegate(object object, nint method);
                    /*0x2d46124*/ void Invoke(string message);
                }

                class ExceptionArgumentDelegate : System.MulticastDelegate
                {
                    /*0x2d46070*/ ExceptionArgumentDelegate(object object, nint method);
                    /*0x2d46138*/ void Invoke(string message, string paramName);
                }
            }

            class SWIGPendingException
            {
                static /*0x0*/ int numExceptionsPending;
                static /*0x8*/ object exceptionsLock;
                [ThreadStatic] static System.Exception pendingException;

                static /*0x2d4614c*/ SWIGPendingException();
                static /*0x2d45964*/ void Set(System.Exception e);
                static /*0x2d457d4*/ System.Exception Retrieve();
            }

            class SWIGStringHelper
            {
                static /*0x0*/ Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate;

                static /*0x2d46278*/ SWIGStringHelper();
                static /*0x2d461f8*/ void SWIGRegisterStringCallback_CrashlyticsInternal(Firebase.Crashlytics.CrashlyticsInternalPINVOKE.SWIGStringHelper.SWIGStringDelegate stringDelegate);
                static /*0x2d461f4*/ string CreateString(string cString);
                /*0x2d44d1c*/ SWIGStringHelper();

                class SWIGStringDelegate : System.MulticastDelegate
                {
                    /*0x2d46324*/ SWIGStringDelegate(object object, nint method);
                    /*0x2d463d4*/ string Invoke(string message);
                }
            }
        }
    }
}
