class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x30498e0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x30499d0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        namespace Common
        {
            class PlayAsyncOperation<TResult, TError> : UnityEngine.CustomYieldInstruction
            {
                /*0x0*/ bool <IsDone>k__BackingField;
                /*0x0*/ TError <Error>k__BackingField;
                /*0x0*/ System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> Completed;

                /*0x1f309e4*/ PlayAsyncOperation();
                /*0x1f2fe14*/ bool get_IsDone();
                /*0x1f30a84*/ void set_IsDone(bool value);
                /*0x1f2fe14*/ bool get_IsSuccessful();
                /*0x1ffc854*/ TError get_Error();
                /*0x1ffc854*/ void set_Error(TError value);
                /*0x1f30ebc*/ void add_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                /*0x1f30ebc*/ void remove_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                /*0x1f2fe14*/ bool get_keepWaiting();
                /*0x1ffc854*/ TResult GetResult();
                /*0x1f309e4*/ void InvokeCompletedEvent();
                /*0x1ffc854*/ TResult GetResultImpl();

                class <>c<TResult, TError>
                {
                    static /*0x0*/ Google.Play.Common.PlayAsyncOperation.<>c<TResult, TError> <>9;
                    static /*0x0*/ System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> <>9__18_0;

                    static /*0x1f33998*/ <>c();
                    /*0x1f309e4*/ <>c();
                    /*0x1f30ebc*/ void <.ctor>b__18_0(Google.Play.Common.PlayAsyncOperation<TResult, TError> <p0>);
                }
            }

            class UnityPlayerHelper
            {
                static /*0x30499d8*/ UnityEngine.AndroidJavaObject GetCurrentActivity();
            }

            class VoidResult
            {
                /*0x3049b74*/ VoidResult();
            }

            namespace LoadingScreen
            {
                class LoadingBar : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ float OutlineWidth;
                    /*0x24*/ float InnerBorderWidth;
                    /*0x28*/ bool ResizeAutomatically;
                    /*0x2c*/ float Progress;
                    /*0x30*/ UnityEngine.RectTransform Background;
                    /*0x38*/ UnityEngine.RectTransform Outline;
                    /*0x40*/ UnityEngine.RectTransform ProgressHolder;
                    /*0x48*/ UnityEngine.RectTransform ProgressFill;
                    /*0x50*/ float AssetBundleDownloadToInstallRatio;

                    /*0x3049eec*/ LoadingBar();
                    /*0x3049b7c*/ void Update();
                    /*0x3049ba4*/ void ApplyBorderWidth();
                    /*0x3049d6c*/ void SetProgress(float proportionOfLoadingBar);
                    /*0x3049e18*/ System.Collections.IEnumerator FillUntilDone(UnityEngine.AsyncOperation operation, float startingFillProportion, float endingFillProportion, bool skipFinalUpdate);

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

                        /*0x3049ec4*/ <FillUntilDone>d__12(int <>1__state);
                        /*0x3049f18*/ void System.IDisposable.Dispose();
                        /*0x3049f1c*/ bool MoveNext();
                        /*0x304a074*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x304a07c*/ void System.Collections.IEnumerator.Reset();
                        /*0x304a0b4*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class LoadingScreen : UnityEngine.MonoBehaviour
                {
                    static int InitialAttemptCount = 3;
                    /*0x20*/ string AssetBundleUrl;
                    /*0x28*/ Google.Play.Common.LoadingScreen.LoadingBar LoadingBar;
                    /*0x30*/ UnityEngine.UI.Button RetryButton;
                    /*0x38*/ UnityEngine.AssetBundle _bundle;
                    /*0x40*/ int _assetBundleRetrievalAttemptCount;
                    /*0x44*/ float _maxLoadingBarProgress;
                    /*0x48*/ bool _downloading;

                    static /*0x304a368*/ bool IsNetworkError(UnityEngine.Networking.UnityWebRequest request);
                    static /*0x304a3ac*/ UnityEngine.AsyncOperation StartAssetBundleDownload(string assetBundleUrl, ref UnityEngine.Networking.UnityWebRequest webRequest);
                    /*0x304a3e4*/ LoadingScreen();
                    /*0x304a0bc*/ void Start();
                    /*0x304a16c*/ void ButtonEventRetryDownload();
                    /*0x304a0c4*/ void AttemptAssetBundleDownload(int numberOfAttempts);
                    /*0x304a1c4*/ System.Collections.IEnumerator AttemptAssetBundleDownloadsCo(int numberOfAttempts);
                    /*0x304a268*/ System.Collections.IEnumerator GetAssetBundle(string assetBundleUrl);
                    /*0x304a318*/ void ShowRetryButton();
                    /*0x304a174*/ void HideRetryButton();

                    class <AttemptAssetBundleDownloadsCo>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ Google.Play.Common.LoadingScreen.LoadingScreen <>4__this;
                        /*0x28*/ int numberOfAttempts;
                        /*0x2c*/ int <i>5__2;

                        /*0x304a240*/ <AttemptAssetBundleDownloadsCo>d__11(int <>1__state);
                        /*0x304a3ec*/ void System.IDisposable.Dispose();
                        /*0x304a3f0*/ bool MoveNext();
                        /*0x304a720*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x304a728*/ void System.Collections.IEnumerator.Reset();
                        /*0x304a760*/ object System.Collections.IEnumerator.get_Current();
                    }

                    class <GetAssetBundle>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ object <>2__current;
                        /*0x20*/ string assetBundleUrl;
                        /*0x28*/ Google.Play.Common.LoadingScreen.LoadingScreen <>4__this;
                        /*0x30*/ UnityEngine.Networking.UnityWebRequest <webRequest>5__2;

                        /*0x304a2f0*/ <GetAssetBundle>d__12(int <>1__state);
                        /*0x304a768*/ void System.IDisposable.Dispose();
                        /*0x304a76c*/ bool MoveNext();
                        /*0x304a91c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                        /*0x304a924*/ void System.Collections.IEnumerator.Reset();
                        /*0x304a95c*/ object System.Collections.IEnumerator.get_Current();
                    }
                }

                class ScrollingFillAnimator : UnityEngine.MonoBehaviour
                {
                    /*0x20*/ float ScrollSpeed;
                    /*0x28*/ UnityEngine.UI.RawImage _image;
                    /*0x30*/ UnityEngine.RectTransform _rectTransform;

                    /*0x304ac74*/ ScrollingFillAnimator();
                    /*0x304a964*/ void Update();
                    /*0x304aab0*/ UnityEngine.Rect ScrollUvs(UnityEngine.Rect uvRect);
                    /*0x304ab58*/ UnityEngine.Rect ScaleUvs(UnityEngine.Rect uvRect);
                    /*0x304a9a8*/ void LazyInit();
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

                    /*0x1f309e4*/ PlayAsyncOperationImpl();
                    /*0x1f30ebc*/ void add_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                    /*0x1f30ebc*/ void remove_Completed(System.Action<Google.Play.Common.PlayAsyncOperation<TResult, TError>> value);
                    /*0x1ffc854*/ void SetResult(TResult result);
                    /*0x1ffc854*/ void SetError(TError errorCode);
                    /*0x1ffc854*/ TResult GetResultImpl();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 13DBA11CB61E445A60473EA14F9EFEE13BD228C3B592B5F23D65E50A83B03231;
    static /*0x17b*/ <PrivateImplementationDetails> 6F5E5CE87E3DE01EA45D07B4A5D0525C0DEC2EC45E0E68AD0F2735B31CEEA61B;

    struct __StaticArrayInitTypeSize=379
    {
    }

    struct __StaticArrayInitTypeSize=795
    {
    }
}
