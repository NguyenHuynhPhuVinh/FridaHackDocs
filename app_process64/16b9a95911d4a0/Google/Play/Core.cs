class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x304ac84*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x304ad74*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Google
{
    namespace Play
    {
        namespace Core
        {
            namespace Internal
            {
                class ActivityResult
                {
                    static int ResultOk = -1;
                    static int ResultCancelled = 0;
                    static int ResultFailed = 1;
                }

                class PlayCoreConstants
                {
                    static string PlayCorePackagePrefix = "com.google.android.play.core.";
                    static string GmsCorePackagePrefix = "com.google.android.gms.";
                    static string AssetPackPackagePrefix = "com.google.android.play.core.assetpacks.";
                    static string IntegrityPackagePrefix = "com.google.android.play.core.integrity.";
                    static int InternalErrorCode = -100;
                }

                class PlayCoreEventHandler : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ Google.Play.Core.Internal.PlayCoreEventHandler _instance;
                    /*0x20*/ System.Collections.Generic.Queue<System.Action> _sharedEventQueue;
                    /*0x28*/ System.Collections.Generic.Queue<System.Action> _localEventQueue;

                    static /*0x304ad7c*/ void CreateInScene();
                    static /*0x304ae44*/ void HandleEvent(System.Action action);
                    /*0x304b2a8*/ PlayCoreEventHandler();
                    /*0x304b030*/ void Awake();
                    /*0x304af30*/ void HandleEventInternal(System.Action action);
                    /*0x304b0fc*/ void Update();
                }

                class PlayCoreHelper
                {
                    static /*0x1f327cc*/ System.Collections.Generic.List<TAndroidJava> ConvertJavaList<TAndroidJava>(UnityEngine.AndroidJavaObject javaList);
                    static /*0x1f327cc*/ System.Collections.Generic.Dictionary<TAndroidJavaKey, TAndroidJavaValue> ConvertJavaMap<TAndroidJavaKey, TAndroidJavaValue>(UnityEngine.AndroidJavaObject javaMap);
                    static /*0x304b354*/ string ConvertJavaString(UnityEngine.AndroidJavaObject javaString);
                    static /*0x304b448*/ bool IsNull(UnityEngine.AndroidJavaObject javaObject);
                }

                class PlayCoreOnFailureListener : UnityEngine.AndroidJavaProxy
                {
                    /*0x20*/ System.Action<string, int> OnTaskFailed;

                    /*0x304b5e0*/ PlayCoreOnFailureListener();
                    /*0x304b480*/ void add_OnTaskFailed(System.Action<string, int> value);
                    /*0x304b530*/ void remove_OnTaskFailed(System.Action<string, int> value);
                    /*0x304b714*/ void onFailure(UnityEngine.AndroidJavaObject exception);

                    class <>c
                    {
                        static /*0x0*/ Google.Play.Core.Internal.PlayCoreOnFailureListener.<> <>9;
                        static /*0x8*/ System.Action<string, int> <>9__3_0;

                        static /*0x304b9d8*/ <>c();
                        /*0x304ba40*/ <>c();
                        /*0x304ba48*/ void <.ctor>b__3_0(string <p0>, int <p1>);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ Google.Play.Core.Internal.PlayCoreOnFailureListener <>4__this;
                        /*0x18*/ string message;
                        /*0x20*/ int errorCode;

                        /*0x304b9d0*/ <>c__DisplayClass4_0();
                        /*0x304ba4c*/ void <onFailure>b__0();
                    }
                }

                class PlayCoreOnSuccessListener<TAndroidJava> : UnityEngine.AndroidJavaProxy
                {
                    /*0x0*/ System.Action<TAndroidJava> OnTaskSucceeded;

                    /*0x1f309e4*/ PlayCoreOnSuccessListener();
                    /*0x1f30ebc*/ void add_OnTaskSucceeded(System.Action<TAndroidJava> value);
                    /*0x1f30ebc*/ void remove_OnTaskSucceeded(System.Action<TAndroidJava> value);
                    /*0x1ffc854*/ void onSuccess(TAndroidJava result);

                    class <>c<TAndroidJava>
                    {
                        static /*0x0*/ Google.Play.Core.Internal.PlayCoreOnSuccessListener.<>c<TAndroidJava> <>9;
                        static /*0x0*/ System.Action<TAndroidJava> <>9__3_0;

                        static /*0x1f33998*/ <>c();
                        /*0x1f309e4*/ <>c();
                        /*0x1ffc854*/ void <.ctor>b__3_0(TAndroidJava <p0>);
                    }

                    class <>c__DisplayClass4_0<TAndroidJava>
                    {
                        /*0x0*/ Google.Play.Core.Internal.PlayCoreOnSuccessListener<TAndroidJava> <>4__this;
                        /*0x0*/ TAndroidJava result;

                        /*0x1f309e4*/ <>c__DisplayClass4_0();
                        /*0x1f309e4*/ void <onSuccess>b__0();
                    }
                }

                class PlayServicesTask<TAndroidJava> : System.IDisposable
                {
                    /*0x0*/ UnityEngine.AndroidJavaObject _javaTask;

                    /*0x1f30ebc*/ PlayServicesTask(UnityEngine.AndroidJavaObject javaTask);
                    /*0x1f30ebc*/ void RegisterOnSuccessCallback(System.Action<TAndroidJava> onSuccess);
                    /*0x1f30ebc*/ void RegisterOnFailureCallback(System.Action<string, int> onFailure);
                    /*0x1f30ebc*/ void AddOnSuccessListener(UnityEngine.AndroidJavaProxy listenerProxy);
                    /*0x1f30ebc*/ void AddOnFailureListener(UnityEngine.AndroidJavaProxy listenerProxy);
                    /*0x1f309e4*/ void Dispose();
                }

                class TaskOnFailureListener : UnityEngine.AndroidJavaProxy
                {
                    /*0x20*/ System.Action<string, int> OnTaskFailed;

                    /*0x304bbec*/ TaskOnFailureListener();
                    /*0x304ba8c*/ void add_OnTaskFailed(System.Action<string, int> value);
                    /*0x304bb3c*/ void remove_OnTaskFailed(System.Action<string, int> value);
                    /*0x304bd20*/ void onFailure(UnityEngine.AndroidJavaObject exception);

                    class <>c
                    {
                        static /*0x0*/ Google.Play.Core.Internal.TaskOnFailureListener.<> <>9;
                        static /*0x8*/ System.Action<string, int> <>9__3_0;

                        static /*0x304bfe4*/ <>c();
                        /*0x304c04c*/ <>c();
                        /*0x304c054*/ void <.ctor>b__3_0(string <p0>, int <p1>);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ Google.Play.Core.Internal.TaskOnFailureListener <>4__this;
                        /*0x18*/ string message;
                        /*0x20*/ int errorCode;

                        /*0x304bfdc*/ <>c__DisplayClass4_0();
                        /*0x304c058*/ void <onFailure>b__0();
                    }
                }

                class TaskOnSuccessListener<TAndroidJava> : UnityEngine.AndroidJavaProxy
                {
                    /*0x0*/ System.Action<TAndroidJava> OnTaskSucceeded;

                    /*0x1f309e4*/ TaskOnSuccessListener();
                    /*0x1f30ebc*/ void add_OnTaskSucceeded(System.Action<TAndroidJava> value);
                    /*0x1f30ebc*/ void remove_OnTaskSucceeded(System.Action<TAndroidJava> value);
                    /*0x1ffc854*/ void onSuccess(TAndroidJava result);

                    class <>c<TAndroidJava>
                    {
                        static /*0x0*/ Google.Play.Core.Internal.TaskOnSuccessListener.<>c<TAndroidJava> <>9;
                        static /*0x0*/ System.Action<TAndroidJava> <>9__3_0;

                        static /*0x1f33998*/ <>c();
                        /*0x1f309e4*/ <>c();
                        /*0x1ffc854*/ void <.ctor>b__3_0(TAndroidJava <p0>);
                    }

                    class <>c__DisplayClass4_0<TAndroidJava>
                    {
                        /*0x0*/ Google.Play.Core.Internal.TaskOnSuccessListener<TAndroidJava> <>4__this;
                        /*0x0*/ TAndroidJava result;

                        /*0x1f309e4*/ <>c__DisplayClass4_0();
                        /*0x1f309e4*/ void <onSuccess>b__0();
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3469B010B482AE628A4E0F2609D8A9171B811ECF0866BD0FF92F628E00C7DEC1;
    static /*0x1c4*/ <PrivateImplementationDetails> 53587F6CAAADF8D27CAF7F3B2173228DFCBF5161EE6F922487E88995DFB2F6D0;

    struct __StaticArrayInitTypeSize=452
    {
    }

    struct __StaticArrayInitTypeSize=920
    {
    }
}
