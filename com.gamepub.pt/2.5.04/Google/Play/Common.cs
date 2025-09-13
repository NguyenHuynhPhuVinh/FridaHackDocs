class <Module>
{
}

namespace Google
{
    namespace Play
    {
        namespace Common
        {
            class PlayAsyncOperation<TResult, TError> : UnityEngine.CustomYieldInstruction
            {
                /*0x0*/ bool <IsDone>k__BackingField;
                /*0x0*/ TError <Error>k__BackingField;
                /*0x0*/ System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> Completed;

                PlayAsyncOperation();
                bool get_IsDone();
                void set_IsDone(bool value);
                bool get_IsSuccessful();
                TError get_Error();
                void set_Error(TError value);
                void add_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                void remove_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                bool get_keepWaiting();
                TResult GetResult();
                void InvokeCompletedEvent();
                TResult GetResultImpl();

                class <>c<TResult, TError>
                {
                    static /*0x0*/ Google.Play.Common.PlayAsyncOperation.<>c<TResult, TError> <>9;
                    static /*0x0*/ System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> <>9__18_0;

                    static <>c();
                    <>c();
                    void <.ctor>b__18_0(Google.Play.Common.PlayAsyncOperation<TResult, TError> <p0>);
                }
            }

            class UnityPlayerHelper
            {
                static /*0x2b07394*/ UnityEngine.AndroidJavaObject GetCurrentActivity();
            }

            class VoidResult
            {
                /*0x2b0753c*/ VoidResult();
            }

            namespace LoadingScreen
            {
                class LoadingBar : UnityEngine.MonoBehaviour
                {
                    /*0x18*/ float OutlineWidth;
                    /*0x1c*/ float InnerBorderWidth;
                    /*0x20*/ bool ResizeAutomatically;
                    /*0x24*/ float Progress;
                    /*0x28*/ UnityEngine.RectTransform Background;
                    /*0x30*/ UnityEngine.RectTransform Outline;
                    /*0x38*/ UnityEngine.RectTransform ProgressHolder;
                    /*0x40*/ UnityEngine.RectTransform ProgressFill;
                    /*0x48*/ float AssetBundleDownloadToInstallRatio;

                    /*0x2b06c9c*/ LoadingBar();
                    /*0x2b06a04*/ void Update();
                    /*0x2b06a38*/ void ApplyBorderWidth();
                    /*0x2b06b18*/ void SetProgress(float proportionOfLoadingBar);
                    /*0x2b06bd0*/ System.Collections.IEnumerator FillUntilDone(UnityEngine.AsyncOperation operation, float startingFillProportion, float endingFillProportion, bool skipFinalUpdate);

                    class <FillUntilDone>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ float startingFillProportion;
                        /*0x28*/ UnityEngine.AsyncOperation operation;
                        /*0x30*/ float endingFillProportion;
                        /*0x38*/ Google.Play.Common.LoadingScreen.LoadingBar <>4__this;
                        /*0x40*/ bool skipFinalUpdate;
                        /*0x44*/ float <previousFillProportion>5__2;
                        /*0x48*/ bool <isDone>5__3;

                        /*0x2b06c70*/ <FillUntilDone>d__12(int <>1__state);
                        /*0x2b07544*/ void System.IDisposable.Dispose();
                        /*0x2b07548*/ bool MoveNext();
                        /*0x2b076a0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2b076a8*/ void System.Collections.IEnumerator.Reset();
                        /*0x2b076e8*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class LoadingScreen : UnityEngine.MonoBehaviour
                {
                    static int InitialAttemptCount = 3;
                    /*0x18*/ string AssetBundleUrl;
                    /*0x20*/ Google.Play.Common.LoadingScreen.LoadingBar LoadingBar;
                    /*0x28*/ UnityEngine.UI.Button RetryButton;
                    /*0x30*/ UnityEngine.AssetBundle _bundle;
                    /*0x38*/ int _assetBundleRetrievalAttemptCount;
                    /*0x3c*/ float _maxLoadingBarProgress;
                    /*0x40*/ bool _downloading;

                    static /*0x2b06f9c*/ bool IsNetworkError(UnityEngine.Networking.UnityWebRequest request);
                    static /*0x2b06fec*/ UnityEngine.AsyncOperation StartAssetBundleDownload(string assetBundleUrl, ref UnityEngine.Networking.UnityWebRequest webRequest);
                    /*0x2b07020*/ LoadingScreen();
                    /*0x2b06cc8*/ void Start();
                    /*0x2b06d90*/ void ButtonEventRetryDownload();
                    /*0x2b06cd0*/ void AttemptAssetBundleDownload(int numberOfAttempts);
                    /*0x2b06df4*/ System.Collections.IEnumerator AttemptAssetBundleDownloadsCo(int numberOfAttempts);
                    /*0x2b06e9c*/ System.Collections.IEnumerator GetAssetBundle(string assetBundleUrl);
                    /*0x2b06f40*/ void ShowRetryButton();
                    /*0x2b06d98*/ void HideRetryButton();

                    class <AttemptAssetBundleDownloadsCo>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ Google.Play.Common.LoadingScreen.LoadingScreen <>4__this;
                        /*0x28*/ int numberOfAttempts;
                        /*0x2c*/ int <i>5__2;

                        /*0x2b06e70*/ <AttemptAssetBundleDownloadsCo>d__11(int <>1__state);
                        /*0x2b076f0*/ void System.IDisposable.Dispose();
                        /*0x2b076f4*/ bool MoveNext();
                        /*0x2b07a3c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2b07a44*/ void System.Collections.IEnumerator.Reset();
                        /*0x2b07a84*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <GetAssetBundle>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ string assetBundleUrl;
                        /*0x28*/ Google.Play.Common.LoadingScreen.LoadingScreen <>4__this;
                        /*0x30*/ UnityEngine.Networking.UnityWebRequest <webRequest>5__2;

                        /*0x2b06f14*/ <GetAssetBundle>d__12(int <>1__state);
                        /*0x2b07a8c*/ void System.IDisposable.Dispose();
                        /*0x2b07a90*/ bool MoveNext();
                        /*0x2b07c3c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x2b07c44*/ void System.Collections.IEnumerator.Reset();
                        /*0x2b07c84*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class ScrollingFillAnimator : UnityEngine.MonoBehaviour
                {
                    /*0x18*/ float ScrollSpeed;
                    /*0x20*/ UnityEngine.UI.RawImage _image;
                    /*0x28*/ UnityEngine.RectTransform _rectTransform;

                    /*0x2b07384*/ ScrollingFillAnimator();
                    /*0x2b07028*/ void Update();
                    /*0x2b0716c*/ UnityEngine.Rect ScrollUvs(UnityEngine.Rect uvRect);
                    /*0x2b0720c*/ UnityEngine.Rect ScaleUvs(UnityEngine.Rect uvRect);
                    /*0x2b07078*/ void LazyInit();
                }
            }

            namespace Internal
            {
                class AndroidConstants
                {
                    static string GooglePlayServicesPackageName = "com.google.android.gms";
                    static string GooglePlayStorePackageName = "com.android.vending";
                    static string ActivityMethodGetIntent = "getIntent";
                    static string ActivityMethodStartActivityForResult = "startActivityForResult";
                    static string BundleClass = "android.os.Bundle";
                    static string BundleMethodGetBoolean = "getBoolean";
                    static string BundleMethodGetByteArray = "getByteArray";
                    static string BundleMethodGetInt = "getInt";
                    static string BundleMethodPutByteArray = "putByteArray";
                    static string BundleMethodPutInt = "putInt";
                    static string ContentResolverMethodCall = "call";
                    static string ContextMethodGetContentResolver = "getContentResolver";
                    static string ContextMethodGetPackageManager = "getPackageManager";
                    static string IntentActionMain = "android.intent.action.MAIN";
                    static string IntentActionView = "android.intent.action.VIEW";
                    static string IntentCategoryDefault = "android.intent.category.DEFAULT";
                    static string IntentCategoryLauncher = "android.intent.category.LAUNCHER";
                    static string IntentClass = "android.content.Intent";
                    static string IntentMethodAddCategory = "addCategory";
                    static string IntentMethodGetStringExtra = "getStringExtra";
                    static string IntentMethodPutExtra = "putExtra";
                    static string IntentMethodSetData = "setData";
                    static string IntentMethodSetPackage = "setPackage";
                    static string ObjectMethodGetClass = "getClass";
                    static string PackageInfoFieldSignatures = "signatures";
                    static int PackageManagerFieldGetSignatures = 64;
                    static string PackageManagerMethodGetPackageInfo = "getPackageInfo";
                    static string PackageManagerMethodResolveActivity = "resolveActivity";
                    static string PackageManagerMethodResolveContentProvider = "resolveContentProvider";
                    static string ProcessClass = "android.os.Process";
                    static string ProcessMethodMyUid = "myUid";
                    static string ProviderInfoFieldPackageName = "packageName";
                    static string SignatureMethodToByteArray = "toByteArray";
                    static string UriClass = "android.net.Uri";
                    static string UriMethodParse = "parse";
                    static string UriBuilderClass = "android.net.Uri$Builder";
                    static string UriBuilderMethodAppendQueryParameter = "appendQueryParameter";
                    static string UriBuilderMethodAuthority = "authority";
                    static string UriBuilderMethodBuild = "build";
                    static string UriBuilderMethodScheme = "scheme";
                }

                class PlayAsyncOperationImpl<TResult, TError> : Google.Play.Common.PlayAsyncOperation<TResult, TError>
                {
                    /*0x0*/ TResult _result;

                    PlayAsyncOperationImpl();
                    void add_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                    void remove_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                    void SetResult(TResult result);
                    void SetError(TError errorCode);
                    TResult GetResultImpl();
                }
            }
        }
    }
}
