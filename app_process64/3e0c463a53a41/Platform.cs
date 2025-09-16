class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7348954*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x734895c*/ NullableAttribute(byte );
                /*0x73489e4*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x7348a14*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7348a3c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7348b30*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Assets
{
    namespace Platform
    {
        class AppStorePlatform : Assets.Platform.PlatformBase
        {
            /*0x7348b38*/ AppStorePlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7348c20*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x7348cbc*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7348de4*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7348eb8*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x7348f50*/ void NavigateNewVersion();
            /*0x7348f88*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x7348ffc*/ string GetProductId(long platformProductMasterId);
            /*0x73490ec*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x7349124*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
        }

        class DmmAndroidPlatform : Assets.Platform.PlatformBase
        {
            /*0x80*/ string openId;
            /*0x88*/ string accessToken;
            /*0x90*/ Assets.Configuration.RuntimeConfiguration runtimeConfiguration;

            static /*0x7349210*/ Cysharp.Threading.Tasks.UniTask<Assets.Configuration.RuntimeConfiguration> ReadConfigurationFromJarAsync();
            /*0x734915c*/ DmmAndroidPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7349160*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x73492e8*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x73499e0*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7349a8c*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x7349b24*/ void NavigateNewVersion();
            /*0x7349bfc*/ void OpenDmmStore();
            /*0x7349cd4*/ void OpenDmmTerm();
            /*0x7349dac*/ void OpenDmmContact();
            /*0x7349e84*/ void OpenDmmSubscription();
            /*0x7349f5c*/ void OpenDmmPointCharge();
            /*0x734a034*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x734a0a8*/ string GetProductId(long platformProductMasterId);
            /*0x734a198*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x734a2a4*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);

            class <>c
            {
                static /*0x0*/ Assets.Platform.DmmAndroidPlatform.<> <>9;
                static /*0x8*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__9_0;
                static /*0x10*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__10_0;
                static /*0x18*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__11_0;
                static /*0x20*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__12_0;
                static /*0x28*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__13_0;
                static /*0x30*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__14_0;

                static /*0x734a388*/ <>c();
                /*0x734a3f0*/ <>c();
                /*0x734a3f8*/ void <NavigateNewVersion>b__9_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x734a4f8*/ void <OpenDmmStore>b__10_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x734a5f8*/ void <OpenDmmTerm>b__11_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x734a6f8*/ void <OpenDmmContact>b__12_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x734a7f8*/ void <OpenDmmSubscription>b__13_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x734a8f8*/ void <OpenDmmPointCharge>b__14_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.SignInResult> completionSource;
                /*0x18*/ Assets.Platform.DmmAndroidPlatform <>4__this;

                /*0x73499d0*/ <>c__DisplayClass6_0();
                /*0x734a9f8*/ void <SignInAsync>b__0(Dmm.Games.Unity.Purchasing.ResultLoginData result);
            }

            class <>c__DisplayClass6_1
            {
                /*0x10*/ System.Uri authUri;
                /*0x18*/ Assets.Platform.DmmAndroidPlatform.<> CS$<>8__locals1;

                /*0x734aee8*/ <>c__DisplayClass6_1();
                /*0x734aef0*/ void <SignInAsync>b__1(Dmm.Games.Store.OsapiMakeRequestResult makeRequestResult);

                struct <<SignInAsync>b__1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ Dmm.Games.Store.OsapiMakeRequestResult makeRequestResult;
                    /*0x40*/ Assets.Platform.DmmAndroidPlatform.<> <>4__this;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__1;

                    /*0x734afc4*/ void MoveNext();
                    /*0x734b754*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct <Initialize>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Configuration.RuntimeConfiguration> <>u__1;

                /*0x734b760*/ void MoveNext();
                /*0x734bcd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitializeInAppPurchaseHandler>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x734bce0*/ void MoveNext();
                /*0x734c5c8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPaymentCanStart>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.Nullable<bool>> <>t__builder;
                /*0x30*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x38*/ string productId;
                /*0x40*/ int price;
                /*0x44*/ int quantity;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.CanStartDmmPaymentResult>> <>u__1;

                /*0x734c5d4*/ void MoveNext();
                /*0x734cbe4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchase>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x30*/ string receipt;
                /*0x38*/ string signature;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessDmmAndroidReceiptResult>> <>u__1;

                /*0x734cc3c*/ void MoveNext();
                /*0x734d3a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadConfigurationFromJarAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Configuration.RuntimeConfiguration> <>t__builder;
                /*0x30*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1;

                /*0x734d3ac*/ void MoveNext();
                /*0x734d7e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DmmClientPlatform : Assets.Platform.PlatformBase
        {
            /*0x80*/ string OpenId;
            /*0x88*/ string AccessToken;

            /*0x734d83c*/ DmmClientPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x734d8bc*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x734da68*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x734db64*/ Assets.Platform.DmmClientPlatform.CommandLineArguments ReadCommandLineArguments();
            /*0x734dee4*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x734df7c*/ void NavigateNewVersion();
            /*0x734dfcc*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x734e03c*/ string GetProductId(long platformProductMasterId);
            /*0x734e12c*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x734e238*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x734e31c*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();

            class CommandLineArguments
            {
                /*0x10*/ string <ViewerId>k__BackingField;
                /*0x18*/ string <OnetimeToken>k__BackingField;
                /*0x20*/ string <AccessToken>k__BackingField;
                /*0x28*/ string <OpenId>k__BackingField;
                /*0x30*/ string <PfAccessToken>k__BackingField;

                /*0x734de48*/ CommandLineArguments();
                /*0x734e374*/ string get_ViewerId();
                /*0x734e37c*/ void set_ViewerId(string value);
                /*0x734e384*/ string get_OnetimeToken();
                /*0x734e38c*/ void set_OnetimeToken(string value);
                /*0x734e394*/ string get_AccessToken();
                /*0x734e39c*/ void set_AccessToken(string value);
                /*0x734e3a4*/ string get_OpenId();
                /*0x734e3ac*/ void set_OpenId(string value);
                /*0x734e3b4*/ string get_PfAccessToken();
                /*0x734e3bc*/ void set_PfAccessToken(string value);
            }

            struct <PostPaymentCanStart>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.Nullable<bool>> <>t__builder;
                /*0x30*/ Assets.Platform.DmmClientPlatform <>4__this;
                /*0x38*/ string productId;
                /*0x40*/ int price;
                /*0x44*/ int quantity;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.CanStartDmmPaymentResult>> <>u__1;

                /*0x734e3c4*/ void MoveNext();
                /*0x734e9d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchase>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmClientPlatform <>4__this;
                /*0x30*/ string receipt;
                /*0x38*/ string signature;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessGamePlayerReceiptResult>> <>u__1;

                /*0x734ea2c*/ void MoveNext();
                /*0x734f124*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInAsync>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.DmmClientPlatform <>4__this;
                /*0x38*/ Assets.Platform.DmmClientPlatform.CommandLineArguments <commandLineArgs>5__2;
                /*0x40*/ Assets.Platform.InAppPurchase.DmmInAppPurchaseHandler <dmmInAppPurchaseHandler>5__3;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__2;

                /*0x734f130*/ void MoveNext();
                /*0x734ff64*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePlayStorePlatform : Assets.Platform.PlatformBase
        {
            /*0x734ffbc*/ GooglePlayStorePlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x734ffc0*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x735005c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7350154*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7350228*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x73502c0*/ void NavigateNewVersion();
            /*0x73502f8*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x735036c*/ string GetProductId(long platformProductMasterId);
            /*0x735045c*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x7350494*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);

            struct <SignInAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.GooglePlayStorePlatform <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__1;

                /*0x73504cc*/ void MoveNext();
                /*0x7350954*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface IPlatform
        {
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x380b9e8*/ string get_Token();
            /*0x380b9e8*/ string get_NickName();
            /*0x380b828*/ long get_WorldMasterId();
            /*0x380a8f0*/ System.Nullable<System.DateTime> get_Birthday();
            /*0x380b6a0*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x380b128*/ bool get_IsPrologueClear();
            /*0x380b128*/ bool get_IsBulkAssetDownloadSupported();
            /*0x380b128*/ bool get_IsCashClearSupported();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessPendingTransactions();
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x380b2f0*/ bool CopyToClipboard(string text);
            Cysharp.Threading.Tasks.UniTask<Assets.Platform.PurchaseResult> Purchase(long platformProductMasterId, int quantity, UnityEngine.Texture2D productIcon);
            Cysharp.Threading.Tasks.UniTask LoginWorld(long worldMasterId);
            /*0x380cb08*/ void NavigateNewVersion();
            /*0x380cb08*/ void ClearToken();
            /*0x380b9e8*/ string get_UserCode();
        }

        enum SignInFailedReasonTypes
        {
            Unknown = 0,
            NotAuthenticated = 1,
            Maintenance = 2,
            NotImplemented = 3,
        }

        enum PurchaseFailedReason
        {
            None = 0,
            NotInitialized = 1,
            UserCanceled = 2,
            CanNotPurchase = 3,
            ApiError = 4,
            PaymentError = 5,
        }

        class SignInResult
        {
            /*0x10*/ bool <IsSuccess>k__BackingField;
            /*0x14*/ System.Nullable<Assets.Platform.SignInFailedReasonTypes> <FailedReason>k__BackingField;

            /*0x73499d8*/ SignInResult();
            /*0x73509ac*/ bool get_IsSuccess();
            /*0x73509b4*/ void set_IsSuccess(bool value);
            /*0x73509c0*/ System.Nullable<Assets.Platform.SignInFailedReasonTypes> get_FailedReason();
            /*0x73509c8*/ void set_FailedReason(System.Nullable<Assets.Platform.SignInFailedReasonTypes> value);
        }

        class PurchaseResult
        {
            /*0x10*/ Assets.Platform.PurchaseFailedReason <FailedReason>k__BackingField;

            /*0x73509f0*/ PurchaseResult();
            /*0x73509d0*/ Assets.Platform.PurchaseFailedReason get_FailedReason();
            /*0x73509d8*/ void set_FailedReason(Assets.Platform.PurchaseFailedReason value);
            /*0x73509e0*/ bool get_IsSuccess();
        }

        class PurchaseException : System.Exception
        {
            /*0x73509f8*/ PurchaseException();
            /*0x7350a50*/ PurchaseException(string message);
            /*0x734d334*/ PurchaseException(Assets.Api.Client.ApiError apiError);
            /*0x7350ab8*/ PurchaseException(string message, System.Exception inner);
            /*0x7350b28*/ PurchaseException(Assets.Api.Client.ApiError apiError, System.Exception inner);
        }

        class PlatformBase : Assets.Platform.IPlatform
        {
            /*0x10*/ bool <IsPrologueClear>k__BackingField;
            /*0x18*/ Assets.Configuration.IApplicationConfiguration configuration;
            /*0x20*/ Assets.Plugins.WebGl.IJSInterop jSInterop;
            /*0x28*/ Assets.Api.Client.IApiClientOnPlatform apiClient;
            /*0x30*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
            /*0x38*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler inAppPurchaseHandler;
            /*0x40*/ string nickName;
            /*0x48*/ string token;
            /*0x50*/ long worldMasterId;
            /*0x58*/ System.Nullable<System.DateTime> birthday;
            /*0x68*/ System.Nullable<Assets.Configuration.GameRatings> gameRating;
            /*0x70*/ bool isBulkAssetDownloadSupported;
            /*0x71*/ bool isCashClearSupported;
            /*0x78*/ string userCode;

            /*0x7348b3c*/ PlatformBase(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7350ba4*/ string get_Token();
            /*0x7350bac*/ string get_NickName();
            /*0x7350bb4*/ long get_WorldMasterId();
            /*0x7350bbc*/ System.Nullable<System.DateTime> get_Birthday();
            /*0x7350bc8*/ bool get_IsBulkAssetDownloadSupported();
            /*0x7350bd0*/ bool get_IsCashClearSupported();
            /*0x7350bd8*/ bool get_IsPrologueClear();
            /*0x7350be0*/ void set_IsPrologueClear(bool value);
            /*0x734c3f4*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x7350bec*/ string get_UserCode();
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x380cb08*/ void NavigateNewVersion();
            /*0x380bd40*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            string GetProductId(long platformProductMasterId);
            Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x7350bf4*/ bool CopyToClipboard(string text);
            /*0x7350c54*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.PurchaseResult> Purchase(long platformProductMasterId, int quantity, UnityEngine.Texture2D productIcon);
            /*0x7350d7c*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessPendingTransactions();
            /*0x7350e58*/ Cysharp.Threading.Tasks.UniTask LoginWorld(long worldMasterId);
            /*0x7350f0c*/ void ClearToken();
            /*0x7350f28*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInThroughFrame();
            /*0x734b63c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignIn(string data);
            /*0x734fe2c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignIn(string viewerId, string oneTimeToken);
            /*0x7348cec*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInByDeviceUniqueIdentifier();
            /*0x7351024*/ System.Nullable<System.DateTime> ParseBirthday(string birthdayStr);
            /*0x73510c8*/ Assets.Platform.SignInResult ProcessAuthResult(Assets.Api.Client.AuthResult authResult, Assets.Plugins.WebGl.JSInterop.GetTokenResult getTokenResult);

            struct <LoginWorld>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.PlatformBase <>4__this;
                /*0x30*/ long worldMasterId;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.StringResult>> <>u__1;

                /*0x7351258*/ void MoveNext();
                /*0x73517c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessPendingTransactions>d__45 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ bool <existsPending>5__2;
                /*0x40*/ Assets.Platform.InAppPurchase.PurchaseResult <purchase>5__3;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.InAppPurchase.PurchaseResult> <>u__1;
                /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                /*0x73517cc*/ void MoveNext();
                /*0x735221c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Purchase>d__44 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.PurchaseResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ long platformProductMasterId;
                /*0x40*/ UnityEngine.Texture2D productIcon;
                /*0x48*/ int quantity;
                /*0x50*/ string <productId>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;
                /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.Nullable<bool>> <>u__2;
                /*0x78*/ Assets.Platform.InAppPurchase.PurchaseResult <purchase>5__3;
                /*0x80*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.InAppPurchase.PurchaseResult> <>u__3;
                /*0x98*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__4;

                /*0x7352274*/ void MoveNext();
                /*0x7353508*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignIn>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ string data;
                /*0x38*/ Assets.Platform.PlatformBase <>4__this;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.ApiResponse<Assets.Api.Client.AuthResult>> <>u__1;

                /*0x7353560*/ void MoveNext();
                /*0x7353c8c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignIn>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ string viewerId;
                /*0x40*/ string oneTimeToken;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.AuthResult>> <>u__1;

                /*0x7353ce4*/ void MoveNext();
                /*0x7354404*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInByDeviceUniqueIdentifier>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.AuthResult>> <>u__1;

                /*0x735445c*/ void MoveNext();
                /*0x73549b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInThroughFrame>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ Assets.Plugins.WebGl.JSInterop.GetTokenResult <getTokenResult>5__2;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.GetTokenResult> <>u__1;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.ApiResponse<Assets.Api.Client.AuthResult>> <>u__2;

                /*0x7354a0c*/ void MoveNext();
                /*0x73554b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class UnityEditorPlatform : Assets.Platform.PlatformBase
        {
            /*0x735550c*/ UnityEditorPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7355510*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x73555ac*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x73556ac*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7355758*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x73557f0*/ void NavigateNewVersion();
            /*0x7355828*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x7355940*/ Assets.Platform.UnityEditorPlatform.EnvironmentSettings LoadSettingsFromDisk();
            /*0x7355b38*/ string GetProductId(long platformProductMasterId);
            /*0x7355b70*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x7355ba8*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x7355c0c*/ Cysharp.Threading.Tasks.UniTask<bool> PostPurchaseWebGL(string receipt, string signature);

            class EnvironmentSettings
            {
                /*0x10*/ int <DmmUserId>k__BackingField;
                /*0x18*/ long <AccountId>k__BackingField;

                /*0x7355b30*/ EnvironmentSettings();
                /*0x7355d24*/ int get_DmmUserId();
                /*0x7355d2c*/ void set_DmmUserId(int value);
                /*0x7355d34*/ long get_AccountId();
                /*0x7355d3c*/ void set_AccountId(long value);
            }

            struct <InitializeInAppPurchaseHandler>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.UnityEditorPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x7355d44*/ void MoveNext();
                /*0x7356378*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchaseWebGL>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Platform.UnityEditorPlatform <>4__this;
                /*0x38*/ string receipt;
                /*0x40*/ string signature;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessDmmWebReceiptResult>> <>u__1;

                /*0x7356384*/ void MoveNext();
                /*0x7356a3c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.UnityEditorPlatform <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.AuthResult>> <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__2;

                /*0x7356a94*/ void MoveNext();
                /*0x735799c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebGLOrStandalonePlatform : Assets.Platform.PlatformBase
        {
            /*0x73579f4*/ WebGLOrStandalonePlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x73579f8*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x7357aa8*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7357ba8*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7357c54*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x7357cec*/ bool CopyToClipboard(string text);
            /*0x7357da0*/ void NavigateNewVersion();
            /*0x7357e44*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x7357eb4*/ string GetProductId(long platformProductMasterId);
            /*0x7357fa4*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x73580b0*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);

            struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> <>u__1;

                /*0x73580fc*/ void MoveNext();
                /*0x73586f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitializeInAppPurchaseHandler>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x73586fc*/ void MoveNext();
                /*0x7358c78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPaymentCanStart>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.Nullable<bool>> <>t__builder;
                /*0x30*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x38*/ string productId;
                /*0x40*/ int price;
                /*0x44*/ int quantity;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.CanStartDmmPaymentResult>> <>u__1;

                /*0x7358c84*/ void MoveNext();
                /*0x7359294*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__2;

                /*0x73592ec*/ void MoveNext();
                /*0x7359cec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebGLPlatform : Assets.Platform.PlatformBase
        {
            /*0x7359d44*/ WebGLPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7359d48*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x7359df8*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7359e28*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7359ed4*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x7359f6c*/ bool CopyToClipboard(string text);
            /*0x735a020*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x735a090*/ string GetProductId(long platformProductMasterId);
            /*0x735a180*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x735a28c*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x735a370*/ void NavigateNewVersion();

            struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> <>u__1;

                /*0x735a414*/ void MoveNext();
                /*0x735aa04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitializeInAppPurchaseHandler>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x735aa10*/ void MoveNext();
                /*0x735af8c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPaymentCanStart>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.Nullable<bool>> <>t__builder;
                /*0x30*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x38*/ string productId;
                /*0x40*/ int price;
                /*0x44*/ int quantity;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.CanStartDmmPaymentResult>> <>u__1;

                /*0x735af98*/ void MoveNext();
                /*0x735b5a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchase>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x30*/ string receipt;
                /*0x38*/ string signature;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessDmmWebReceiptResult>> <>u__1;

                /*0x735b600*/ void MoveNext();
                /*0x735bcf8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace InAppPurchase
        {
            class AppleAppStoreInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x7348ff8*/ AppleAppStoreInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x735bdd0*/ void Initialize();
                /*0x735c450*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x735cb30*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x735cf84*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
                /*0x735d2bc*/ void OnDeferred(UnityEngine.Purchasing.Product item);
                /*0x735d324*/ void OnTransactionsRestored(bool success, string message);
                /*0x735d42c*/ void <Purchase>b__2_0(object _);

                class <>c
                {
                    static /*0x0*/ Assets.Platform.InAppPurchase.AppleAppStoreInAppPurchaseHandler.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.PlatformProductMaster, string> <>9__1_0;
                    static /*0x10*/ System.Func<string, bool> <>9__1_1;

                    static /*0x735d4a8*/ <>c();
                    /*0x735d510*/ <>c();
                    /*0x735d518*/ string <Initialize>b__1_0(Assets.Api.Client.PlatformProductMaster x);
                    /*0x735d530*/ bool <Initialize>b__1_1(string x);
                }
            }

            class DmmInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x54*/ Assets.Configuration.GameRatings gameRating;
                /*0x58*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> initUcs;

                /*0x734a0a4*/ DmmInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x734fd60*/ string get_ViewerId();
                /*0x735d550*/ string get_CommerceUrl();
                /*0x734c490*/ Cysharp.Threading.Tasks.UniTask Initialize(string dmmOpenId, string dmmAccessToken, string dmmApiToken, Assets.Configuration.GameRatings gameRating, bool isSandbox, System.Uri productsBaseUri);
                /*0x735d63c*/ string[] LoadProducts();
                /*0x735d8a0*/ Cysharp.Threading.Tasks.UniTask<System.String[]> LoadProducts(System.Uri productsUri);
                /*0x735db04*/ void Initialize(string dmmOpenId, string dmmAccessToken, string dmmApiToken, Assets.Configuration.GameRatings gameRating);
                /*0x735db3c*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
                /*0x735dc60*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x735dd34*/ void SetProductIcon(string producId, UnityEngine.Texture2D texture);
                /*0x735de18*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x735e200*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
                /*0x735e3e4*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
                /*0x735e5d0*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x735e9d0*/ void <Purchase>b__14_0(object _);

                class <>c
                {
                    static /*0x0*/ Assets.Platform.InAppPurchase.DmmInAppPurchaseHandler.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.PlatformProductMaster, string> <>9__8_0;
                    static /*0x10*/ System.Func<string, bool> <>9__8_1;

                    static /*0x735ea4c*/ <>c();
                    /*0x735eab4*/ <>c();
                    /*0x735eabc*/ string <LoadProducts>b__8_0(Assets.Api.Client.PlatformProductMaster x);
                    /*0x735eaec*/ bool <LoadProducts>b__8_1(string x);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ System.Uri productsUri;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<System.String[]> getProductsTsc;

                    /*0x735dafc*/ <>c__DisplayClass9_0();
                    /*0x735eb0c*/ void <LoadProducts>b__0(Best.HTTP.HTTPRequest request, Best.HTTP.HTTPResponse response);
                }

                struct <Initialize>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Platform.InAppPurchase.DmmInAppPurchaseHandler <>4__this;
                    /*0x30*/ Assets.Configuration.GameRatings gameRating;
                    /*0x38*/ System.Uri productsBaseUri;
                    /*0x40*/ string dmmApiToken;
                    /*0x48*/ string dmmOpenId;
                    /*0x50*/ string dmmAccessToken;
                    /*0x58*/ bool isSandbox;
                    /*0x60*/ UnityEngine.Purchasing.ConfigurationBuilder <builder>5__2;
                    /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.String[]> <>u__1;
                    /*0x80*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

                    /*0x735ee80*/ void MoveNext();
                    /*0x735f81c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class DmmWebGLInAppPurchaseHandler : Assets.Platform.InAppPurchase.DmmInAppPurchaseHandler
            {
                /*0x7355938*/ DmmWebGLInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x73562c0*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Configuration.GameRatings gameRating, bool isSandbox);

                struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Platform.InAppPurchase.DmmWebGLInAppPurchaseHandler <>4__this;
                    /*0x30*/ Assets.Configuration.GameRatings gameRating;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x735f828*/ void MoveNext();
                    /*0x735fd44*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class GooglePlayInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x7350368*/ GooglePlayInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x735fd50*/ void Initialize();
                /*0x736032c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x73606f4*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7360aac*/ void <Purchase>b__2_0(object _);

                class GooglePlayJsonAndSignature
                {
                    /*0x10*/ string <Json>k__BackingField;
                    /*0x18*/ string <Signature>k__BackingField;

                    /*0x7360b48*/ GooglePlayJsonAndSignature();
                    /*0x7360b28*/ string get_Json();
                    /*0x7360b30*/ void set_Json(string value);
                    /*0x7360b38*/ string get_Signature();
                    /*0x7360b40*/ void set_Signature(string value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Platform.InAppPurchase.GooglePlayInAppPurchaseHandler.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.PlatformProductMaster, string> <>9__1_0;
                    static /*0x10*/ System.Func<string, bool> <>9__1_1;

                    static /*0x7360b9c*/ <>c();
                    /*0x7360c04*/ <>c();
                    /*0x7360c0c*/ string <Initialize>b__1_0(Assets.Api.Client.PlatformProductMaster x);
                    /*0x7360c24*/ bool <Initialize>b__1_1(string x);
                }
            }

            interface IInAppPurchaseHandler
            {
                /*0x380cb08*/ void Initialize();
                /*0x380b128*/ bool get_Initialized();
                /*0x380d83c*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x380d93c*/ void SetProductIcon(string productId, UnityEngine.Texture2D texture);
                Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                System.Nullable<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> GetPendingPurchaseOrDefault();
                /*0x380d83c*/ void ConfirmPendingTransaction(UnityEngine.Purchasing.Product product);
            }

            class PurchaseResult
            {
                /*0x10*/ string <Receipt>k__BackingField;
                /*0x18*/ string <Signature>k__BackingField;
                /*0x20*/ UnityEngine.Purchasing.Product <Product>k__BackingField;

                /*0x735cf50*/ PurchaseResult();
                /*0x7360c44*/ string get_Receipt();
                /*0x7360c4c*/ void set_Receipt(string value);
                /*0x7360c54*/ string get_Signature();
                /*0x7360c5c*/ void set_Signature(string value);
                /*0x7360c64*/ UnityEngine.Purchasing.Product get_Product();
                /*0x7360c6c*/ void set_Product(UnityEngine.Purchasing.Product value);
            }

            class InAppPurchaseHandlerBase : Assets.Platform.InAppPurchase.IInAppPurchaseHandler, UnityEngine.Purchasing.IDetailedStoreListener, UnityEngine.Purchasing.IStoreListener
            {
                /*0x10*/ System.Collections.Generic.Queue<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> <PendingPurchaseTasks>k__BackingField;
                /*0x18*/ UnityEngine.Purchasing.IStoreController storeController;
                /*0x20*/ UnityEngine.Purchasing.IExtensionProvider extensionProvider;
                /*0x28*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.InAppPurchase.PurchaseResult> <ActivePurchaseTCS>k__BackingField;
                /*0x30*/ UnityEngine.Purchasing.AppStore <CurrentAppStore>k__BackingField;
                /*0x34*/ bool <IsPurchaseRestricted>k__BackingField;
                /*0x38*/ Assets.Configuration.IApplicationConfiguration configuration;
                /*0x40*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                /*0x48*/ Assets.Api.Client.IApiClient apiClient;
                /*0x50*/ bool initialized;

                /*0x735bd04*/ InAppPurchaseHandlerBase(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x7360c74*/ System.Collections.Generic.Queue<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> get_PendingPurchaseTasks();
                /*0x735c9f0*/ UnityEngine.Purchasing.IStoreController get_StoreController();
                /*0x735cf08*/ UnityEngine.Purchasing.IExtensionProvider get_ExtensionProvider();
                /*0x7360c7c*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.InAppPurchase.PurchaseResult> get_ActivePurchaseTCS();
                /*0x7360c84*/ void set_ActivePurchaseTCS(Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.InAppPurchase.PurchaseResult> value);
                /*0x7360c8c*/ UnityEngine.Purchasing.AppStore get_CurrentAppStore();
                /*0x7360c94*/ void set_CurrentAppStore(UnityEngine.Purchasing.AppStore value);
                /*0x7360c9c*/ bool get_IsPurchaseRestricted();
                /*0x7360ca4*/ void set_IsPurchaseRestricted(bool value);
                /*0x7360cb0*/ bool get_Initialized();
                /*0x7360cb8*/ void Initialize();
                /*0x7360cf0*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x7360d28*/ void SetProductIcon(string productId, UnityEngine.Texture2D texture);
                /*0x7360d60*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x7360d98*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7360dd0*/ System.Nullable<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> GetPendingPurchaseOrDefault();
                /*0x7360ee0*/ void ConfirmPendingTransaction(UnityEngine.Purchasing.Product product);
                /*0x735dbbc*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
                /*0x7361044*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
                /*0x7361104*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
                /*0x73611cc*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription);
                /*0x73611f0*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
                /*0x735c818*/ bool ValidatePurchase(ref System.Nullable<UnityEngine.Purchasing.PurchaseFailureReason> reason);
                /*0x735ca38*/ bool ValidateProduct(UnityEngine.Purchasing.Product product, ref System.Nullable<UnityEngine.Purchasing.PurchaseFailureReason> reason);
            }

            class PurchaseException : System.Exception
            {
                /*0x8c*/ UnityEngine.Purchasing.PurchaseFailureReason <Reason>k__BackingField;

                /*0x735c984*/ PurchaseException(UnityEngine.Purchasing.PurchaseFailureReason reason);
                /*0x73615dc*/ UnityEngine.Purchasing.PurchaseFailureReason get_Reason();
            }

            class UnityEditorInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x735593c*/ UnityEditorInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x73615e4*/ void Initialize();
                /*0x73615e8*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x73615ec*/ void SetProductIcon(string productId, UnityEngine.Texture2D texture);
                /*0x73615f0*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x7361628*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7361660*/ System.Nullable<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> GetPendingPurchaseOrDefault();
                /*0x736166c*/ void ConfirmPendingTransaction(UnityEngine.Purchasing.Product product);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 045242B98021816AAD39BCD076F695D4544417C10A58F2A344992FAE266899B7;
    static /*0x4aa*/ <PrivateImplementationDetails> D75742F7D3B0C07820D90ABA903081198AD2AC5B059F6BD1A93E4DBC5B6D450E;

    struct __StaticArrayInitTypeSize=947
    {
    }

    struct __StaticArrayInitTypeSize=1194
    {
    }
}
