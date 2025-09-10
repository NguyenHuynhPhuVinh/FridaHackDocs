class <Module>
{
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class PreserveDependencyAttribute : System.Attribute
            {
                /*0x10*/ string <Condition>k__BackingField;

                /*0x150b098*/ PreserveDependencyAttribute(string memberSignature);
                /*0x150b0a0*/ PreserveDependencyAttribute(string memberSignature, string typeName);
                /*0x150b0a8*/ PreserveDependencyAttribute(string memberSignature, string typeName, string assembly);
                /*0x150b0b0*/ string get_Condition();
                /*0x150b0b8*/ void set_Condition(string value);
            }
        }
    }
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            class CommonErrorCodes
            {
                static int Unknown = 0;
                static int TransportError = 1;
                static int Timeout = 2;
                static int ServiceUnavailable = 3;
                static int ApiMissing = 4;
                static int RequestRejected = 5;
                static int TooManyRequests = 50;
                static int InvalidToken = 51;
                static int TokenExpired = 52;
                static int Forbidden = 53;
                static int NotFound = 54;
                static int InvalidRequest = 55;
            }

            class ExternalUserIdProperty
            {
                /*0x10*/ System.Action<string> UserIdChanged;
                /*0x18*/ string m_UserId;

                /*0x150b248*/ ExternalUserIdProperty();
                /*0x150b0c0*/ void add_UserIdChanged(System.Action<string> value);
                /*0x150b170*/ void remove_UserIdChanged(System.Action<string> value);
                /*0x150b220*/ string get_UserId();
                /*0x150b228*/ void set_UserId(string value);
            }

            class InitializationOptions
            {
                /*0x10*/ System.Collections.Generic.IDictionary<string, object> <Values>k__BackingField;

                /*0x150b258*/ InitializationOptions();
                /*0x150b2d8*/ InitializationOptions(System.Collections.Generic.IDictionary<string, object> values);
                /*0x150b300*/ InitializationOptions(Unity.Services.Core.InitializationOptions source);
                /*0x150b250*/ System.Collections.Generic.IDictionary<string, object> get_Values();
                /*0x150b390*/ bool TryGetOption(string key, ref bool option);
                /*0x150b3f0*/ bool TryGetOption(string key, ref int option);
                /*0x150b450*/ bool TryGetOption(string key, ref float option);
                /*0x150b4b0*/ bool TryGetOption(string key, ref string option);
                bool TryGetOption<T>(string key, ref T option);
                /*0x150b510*/ Unity.Services.Core.InitializationOptions SetOption(string key, bool value);
                /*0x150b604*/ Unity.Services.Core.InitializationOptions SetOption(string key, int value);
                /*0x150b6f8*/ Unity.Services.Core.InitializationOptions SetOption(string key, float value);
                /*0x150b7f4*/ Unity.Services.Core.InitializationOptions SetOption(string key, string value);
            }

            class ServicesInitializationException : System.Exception
            {
                /*0x150b8b8*/ ServicesInitializationException();
                /*0x150b910*/ ServicesInitializationException(string message);
                /*0x150b978*/ ServicesInitializationException(string message, System.Exception innerException);
            }

            enum ServicesInitializationState
            {
                Uninitialized = 0,
                Initializing = 1,
                Initialized = 2,
            }

            class UnityProjectNotLinkedException : Unity.Services.Core.ServicesInitializationException
            {
                /*0x150b9e8*/ UnityProjectNotLinkedException();
                /*0x150b9ec*/ UnityProjectNotLinkedException(string message);
            }

            interface IUnityServices
            {
                Unity.Services.Core.ServicesInitializationState get_State();
                Unity.Services.Core.InitializationOptions get_Options();
                System.Threading.Tasks.Task InitializeAsync(Unity.Services.Core.InitializationOptions options);
            }

            class RequestFailedException : System.Exception
            {
                /*0x8c*/ int <ErrorCode>k__BackingField;

                /*0x150b9f8*/ RequestFailedException(int errorCode, string message);
                /*0x150ba00*/ RequestFailedException(int errorCode, string message, System.Exception innerException);
                /*0x150b9f0*/ int get_ErrorCode();
            }

            class UnityServices
            {
                static /*0x0*/ Unity.Services.Core.IUnityServices <Instance>k__BackingField;
                static /*0x8*/ System.Threading.Tasks.TaskCompletionSource<object> <InstantiationCompletion>k__BackingField;
                static /*0x10*/ Unity.Services.Core.ExternalUserIdProperty ExternalUserIdProperty;

                static /*0x150c0a0*/ UnityServices();
                static /*0x150ba84*/ Unity.Services.Core.IUnityServices get_Instance();
                static /*0x150badc*/ void set_Instance(Unity.Services.Core.IUnityServices value);
                static /*0x150bb38*/ System.Threading.Tasks.TaskCompletionSource<object> get_InstantiationCompletion();
                static /*0x150bb90*/ void set_InstantiationCompletion(System.Threading.Tasks.TaskCompletionSource<object> value);
                static /*0x150bbec*/ Unity.Services.Core.ServicesInitializationState get_State();
                static /*0x150be68*/ string get_ExternalUserId();
                static /*0x150becc*/ void set_ExternalUserId(string value);
                static /*0x150bf58*/ System.Threading.Tasks.Task InitializeAsync();
                static /*0x150bfd4*/ System.Threading.Tasks.Task InitializeAsync(Unity.Services.Core.InitializationOptions options);

                struct <InitializeAsync>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                    /*0x30*/ Unity.Services.Core.InitializationOptions options;
                    /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<object> <>u__1;
                    /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__2;

                    /*0x150c118*/ void MoveNext();
                    /*0x150c708*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class UnityThreadUtils
            {
                static /*0x0*/ int s_UnityThreadId;
                static /*0x8*/ System.Threading.Tasks.TaskScheduler <UnityThreadScheduler>k__BackingField;

                static /*0x150c714*/ System.Threading.Tasks.TaskScheduler get_UnityThreadScheduler();
                static /*0x150c75c*/ void set_UnityThreadScheduler(System.Threading.Tasks.TaskScheduler value);
                static /*0x150c7a8*/ void CaptureUnityThreadInfo();
                static /*0x150be08*/ bool get_IsRunningOnUnityThread();
            }
        }
    }
}
