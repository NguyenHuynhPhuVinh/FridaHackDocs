class <Module>
{
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
                    static string AssetPackPackagePrefix = "com.google.android.play.core.assetpacks.";
                    static int InternalErrorCode = -100;
                }

                class PlayCoreEventHandler : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ Google.Play.Core.Internal.PlayCoreEventHandler _instance;
                    /*0x18*/ System.Collections.Generic.Queue<System.Action> _sharedEventQueue;
                    /*0x20*/ System.Collections.Generic.Queue<System.Action> _localEventQueue;

                    static /*0x2b2f9d0*/ void CreateInScene();
                    static /*0x2b2faa4*/ void HandleEvent(System.Action action);
                    /*0x2b2ff10*/ PlayCoreEventHandler();
                    /*0x2b2fca0*/ void Awake();
                    /*0x2b2fb9c*/ void HandleEventInternal(System.Action action);
                    /*0x2b2fd74*/ void Update();
                }

                class PlayCoreHelper
                {
                    static System.Collections.Generic.List<TAndroidJava> ConvertJavaList<TAndroidJava>(UnityEngine.AndroidJavaObject javaList);
                    static System.Collections.Generic.Dictionary<TAndroidJavaKey, TAndroidJavaValue> ConvertJavaMap<TAndroidJavaKey, TAndroidJavaValue>(UnityEngine.AndroidJavaObject javaMap);
                    static /*0x2b2ffa8*/ string ConvertJavaString(UnityEngine.AndroidJavaObject javaString);
                    static /*0x2b300cc*/ bool IsNull(UnityEngine.AndroidJavaObject javaObject);
                }

                class PlayCoreJavaProxy : UnityEngine.AndroidJavaProxy
                {
                    /*0x2b30114*/ PlayCoreJavaProxy(string javaInterface);
                }

                class PlayCoreOnFailureListener : Google.Play.Core.Internal.PlayCoreJavaProxy
                {
                    /*0x20*/ System.Action<string, int> OnTaskFailed;

                    /*0x2b302c8*/ PlayCoreOnFailureListener();
                    /*0x2b30188*/ void add_OnTaskFailed(System.Action<string, int> value);
                    /*0x2b30228*/ void remove_OnTaskFailed(System.Action<string, int> value);
                    /*0x2b303e8*/ void onFailure(UnityEngine.AndroidJavaObject exception);

                    class <>c
                    {
                        static /*0x0*/ Google.Play.Core.Internal.PlayCoreOnFailureListener.<> <>9;
                        static /*0x8*/ System.Action<string, int> <>9__3_0;

                        static /*0x2b306c0*/ <>c();
                        /*0x2b30720*/ <>c();
                        /*0x2b30728*/ void <.ctor>b__3_0(string <p0>, int <p1>);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ Google.Play.Core.Internal.PlayCoreOnFailureListener <>4__this;
                        /*0x18*/ string message;
                        /*0x20*/ int errorCode;

                        /*0x2b306b8*/ <>c__DisplayClass4_0();
                        /*0x2b3072c*/ void <onFailure>b__0();
                    }
                }

                class PlayCoreOnSuccessListener<TAndroidJava> : Google.Play.Core.Internal.PlayCoreJavaProxy
                {
                    /*0x0*/ System.Action<TAndroidJava> OnTaskSucceeded;

                    PlayCoreOnSuccessListener();
                    void add_OnTaskSucceeded(System.Action<TAndroidJava> value);
                    void remove_OnTaskSucceeded(System.Action<TAndroidJava> value);
                    void onSuccess(TAndroidJava result);

                    class <>c<TAndroidJava>
                    {
                        static /*0x0*/ Google.Play.Core.Internal.PlayCoreOnSuccessListener.<>c<TAndroidJava> <>9;
                        static /*0x0*/ System.Action<TAndroidJava> <>9__3_0;

                        static <>c();
                        <>c();
                        void <.ctor>b__3_0(TAndroidJava <p0>);
                    }

                    class <>c__DisplayClass4_0<TAndroidJava>
                    {
                        /*0x0*/ Google.Play.Core.Internal.PlayCoreOnSuccessListener<TAndroidJava> <>4__this;
                        /*0x0*/ TAndroidJava result;

                        <>c__DisplayClass4_0();
                        void <onSuccess>b__0();
                    }
                }

                class PlayCoreTask<TAndroidJava> : System.IDisposable
                {
                    /*0x0*/ UnityEngine.AndroidJavaObject _javaTask;

                    PlayCoreTask(UnityEngine.AndroidJavaObject javaTask);
                    void RegisterOnSuccessCallback(System.Action<TAndroidJava> onSuccess);
                    void RegisterOnFailureCallback(System.Action<string, int> onFailure);
                    void AddOnSuccessListener(UnityEngine.AndroidJavaProxy listenerProxy);
                    void AddOnFailureListener(UnityEngine.AndroidJavaProxy listenerProxy);
                    void Dispose();
                }
            }
        }
    }
}
