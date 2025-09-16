class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x735fd84*/ EmbeddedAttribute();
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

                /*0x735fd8c*/ NullableAttribute(byte );
                /*0x735fe14*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x735fe44*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x735fe6c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x735ff60*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
            /*0x735ff68*/ AppStorePlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7360050*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x73600ec*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7360214*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x73602e8*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x7360380*/ void NavigateNewVersion();
            /*0x73603b8*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x736042c*/ string GetProductId(long platformProductMasterId);
            /*0x736051c*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x7360554*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
        }

        class DmmAndroidPlatform : Assets.Platform.PlatformBase
        {
            /*0x80*/ string openId;
            /*0x88*/ string accessToken;
            /*0x90*/ Assets.Configuration.RuntimeConfiguration runtimeConfiguration;

            static /*0x7360640*/ Cysharp.Threading.Tasks.UniTask<Assets.Configuration.RuntimeConfiguration> ReadConfigurationFromJarAsync();
            /*0x736058c*/ DmmAndroidPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7360590*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x7360718*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7360e10*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7360ebc*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x7360f54*/ void NavigateNewVersion();
            /*0x736102c*/ void OpenDmmStore();
            /*0x7361104*/ void OpenDmmTerm();
            /*0x73611dc*/ void OpenDmmContact();
            /*0x73612b4*/ void OpenDmmSubscription();
            /*0x736138c*/ void OpenDmmPointCharge();
            /*0x7361464*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x73614d8*/ string GetProductId(long platformProductMasterId);
            /*0x73615c8*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x73616d4*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);

            class <>c
            {
                static /*0x0*/ Assets.Platform.DmmAndroidPlatform.<> <>9;
                static /*0x8*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__9_0;
                static /*0x10*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__10_0;
                static /*0x18*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__11_0;
                static /*0x20*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__12_0;
                static /*0x28*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__13_0;
                static /*0x30*/ System.Action<Dmm.Games.Unity.Purchasing.MenuEventData> <>9__14_0;

                static /*0x73617b8*/ <>c();
                /*0x7361820*/ <>c();
                /*0x7361828*/ void <NavigateNewVersion>b__9_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x7361928*/ void <OpenDmmStore>b__10_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x7361a28*/ void <OpenDmmTerm>b__11_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x7361b28*/ void <OpenDmmContact>b__12_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x7361c28*/ void <OpenDmmSubscription>b__13_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
                /*0x7361d28*/ void <OpenDmmPointCharge>b__14_0(Dmm.Games.Unity.Purchasing.MenuEventData result);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.SignInResult> completionSource;
                /*0x18*/ Assets.Platform.DmmAndroidPlatform <>4__this;

                /*0x7360e00*/ <>c__DisplayClass6_0();
                /*0x7361e28*/ void <SignInAsync>b__0(Dmm.Games.Unity.Purchasing.ResultLoginData result);
            }

            class <>c__DisplayClass6_1
            {
                /*0x10*/ System.Uri authUri;
                /*0x18*/ Assets.Platform.DmmAndroidPlatform.<> CS$<>8__locals1;

                /*0x7362318*/ <>c__DisplayClass6_1();
                /*0x7362320*/ void <SignInAsync>b__1(Dmm.Games.Store.OsapiMakeRequestResult makeRequestResult);

                struct <<SignInAsync>b__1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                    /*0x38*/ Dmm.Games.Store.OsapiMakeRequestResult makeRequestResult;
                    /*0x40*/ Assets.Platform.DmmAndroidPlatform.<> <>4__this;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__1;

                    /*0x73623f4*/ void MoveNext();
                    /*0x7362b84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            struct <Initialize>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Configuration.RuntimeConfiguration> <>u__1;

                /*0x7362b90*/ void MoveNext();
                /*0x7363104*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitializeInAppPurchaseHandler>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x7363110*/ void MoveNext();
                /*0x73639f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x7363a04*/ void MoveNext();
                /*0x7364014*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchase>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmAndroidPlatform <>4__this;
                /*0x30*/ string receipt;
                /*0x38*/ string signature;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessDmmAndroidReceiptResult>> <>u__1;

                /*0x736406c*/ void MoveNext();
                /*0x73647d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ReadConfigurationFromJarAsync>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Configuration.RuntimeConfiguration> <>t__builder;
                /*0x30*/ Cysharp.Threading.Tasks.UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter <>u__1;

                /*0x73647dc*/ void MoveNext();
                /*0x7364c14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DmmClientPlatform : Assets.Platform.PlatformBase
        {
            /*0x80*/ string OpenId;
            /*0x88*/ string AccessToken;

            /*0x7364c6c*/ DmmClientPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7364cec*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x7364e98*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7364f94*/ Assets.Platform.DmmClientPlatform.CommandLineArguments ReadCommandLineArguments();
            /*0x7365314*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x73653ac*/ void NavigateNewVersion();
            /*0x73653fc*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x736546c*/ string GetProductId(long platformProductMasterId);
            /*0x736555c*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x7365668*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x736574c*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();

            class CommandLineArguments
            {
                /*0x10*/ string <ViewerId>k__BackingField;
                /*0x18*/ string <OnetimeToken>k__BackingField;
                /*0x20*/ string <AccessToken>k__BackingField;
                /*0x28*/ string <OpenId>k__BackingField;
                /*0x30*/ string <PfAccessToken>k__BackingField;

                /*0x7365278*/ CommandLineArguments();
                /*0x73657a4*/ string get_ViewerId();
                /*0x73657ac*/ void set_ViewerId(string value);
                /*0x73657b4*/ string get_OnetimeToken();
                /*0x73657bc*/ void set_OnetimeToken(string value);
                /*0x73657c4*/ string get_AccessToken();
                /*0x73657cc*/ void set_AccessToken(string value);
                /*0x73657d4*/ string get_OpenId();
                /*0x73657dc*/ void set_OpenId(string value);
                /*0x73657e4*/ string get_PfAccessToken();
                /*0x73657ec*/ void set_PfAccessToken(string value);
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

                /*0x73657f4*/ void MoveNext();
                /*0x7365e04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchase>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.DmmClientPlatform <>4__this;
                /*0x30*/ string receipt;
                /*0x38*/ string signature;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessGamePlayerReceiptResult>> <>u__1;

                /*0x7365e5c*/ void MoveNext();
                /*0x7366554*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x7366560*/ void MoveNext();
                /*0x7367394*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class GooglePlayStorePlatform : Assets.Platform.PlatformBase
        {
            /*0x73673ec*/ GooglePlayStorePlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x73673f0*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x736748c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7367584*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7367658*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x73676f0*/ void NavigateNewVersion();
            /*0x7367728*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x736779c*/ string GetProductId(long platformProductMasterId);
            /*0x736788c*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x73678c4*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);

            struct <SignInAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.GooglePlayStorePlatform <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__1;

                /*0x73678fc*/ void MoveNext();
                /*0x7367d84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface IPlatform
        {
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x38148bc*/ string get_Token();
            /*0x38148bc*/ string get_NickName();
            /*0x38146fc*/ long get_WorldMasterId();
            /*0x38137c4*/ System.Nullable<System.DateTime> get_Birthday();
            /*0x3814574*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x3813ffc*/ bool get_IsPrologueClear();
            /*0x3813ffc*/ bool get_IsBulkAssetDownloadSupported();
            /*0x3813ffc*/ bool get_IsCashClearSupported();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessPendingTransactions();
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x38141c4*/ bool CopyToClipboard(string text);
            Cysharp.Threading.Tasks.UniTask<Assets.Platform.PurchaseResult> Purchase(long platformProductMasterId, int quantity, UnityEngine.Texture2D productIcon);
            Cysharp.Threading.Tasks.UniTask LoginWorld(long worldMasterId);
            /*0x38159dc*/ void NavigateNewVersion();
            /*0x38159dc*/ void ClearToken();
            /*0x38148bc*/ string get_UserCode();
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

            /*0x7360e08*/ SignInResult();
            /*0x7367ddc*/ bool get_IsSuccess();
            /*0x7367de4*/ void set_IsSuccess(bool value);
            /*0x7367df0*/ System.Nullable<Assets.Platform.SignInFailedReasonTypes> get_FailedReason();
            /*0x7367df8*/ void set_FailedReason(System.Nullable<Assets.Platform.SignInFailedReasonTypes> value);
        }

        class PurchaseResult
        {
            /*0x10*/ Assets.Platform.PurchaseFailedReason <FailedReason>k__BackingField;

            /*0x7367e20*/ PurchaseResult();
            /*0x7367e00*/ Assets.Platform.PurchaseFailedReason get_FailedReason();
            /*0x7367e08*/ void set_FailedReason(Assets.Platform.PurchaseFailedReason value);
            /*0x7367e10*/ bool get_IsSuccess();
        }

        class PurchaseException : System.Exception
        {
            /*0x7367e28*/ PurchaseException();
            /*0x7367e80*/ PurchaseException(string message);
            /*0x7364764*/ PurchaseException(Assets.Api.Client.ApiError apiError);
            /*0x7367ee8*/ PurchaseException(string message, System.Exception inner);
            /*0x7367f58*/ PurchaseException(Assets.Api.Client.ApiError apiError, System.Exception inner);
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

            /*0x735ff6c*/ PlatformBase(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7367fd4*/ string get_Token();
            /*0x7367fdc*/ string get_NickName();
            /*0x7367fe4*/ long get_WorldMasterId();
            /*0x7367fec*/ System.Nullable<System.DateTime> get_Birthday();
            /*0x7367ff8*/ bool get_IsBulkAssetDownloadSupported();
            /*0x7368000*/ bool get_IsCashClearSupported();
            /*0x7368008*/ bool get_IsPrologueClear();
            /*0x7368010*/ void set_IsPrologueClear(bool value);
            /*0x7363824*/ Assets.Configuration.GameRatings get_GameRating();
            /*0x736801c*/ string get_UserCode();
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x38159dc*/ void NavigateNewVersion();
            /*0x3814c14*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            string GetProductId(long platformProductMasterId);
            Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x7368024*/ bool CopyToClipboard(string text);
            /*0x7368084*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.PurchaseResult> Purchase(long platformProductMasterId, int quantity, UnityEngine.Texture2D productIcon);
            /*0x73681ac*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessPendingTransactions();
            /*0x7368288*/ Cysharp.Threading.Tasks.UniTask LoginWorld(long worldMasterId);
            /*0x736833c*/ void ClearToken();
            /*0x7368358*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInThroughFrame();
            /*0x7362a6c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignIn(string data);
            /*0x736725c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignIn(string viewerId, string oneTimeToken);
            /*0x736011c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInByDeviceUniqueIdentifier();
            /*0x7368454*/ System.Nullable<System.DateTime> ParseBirthday(string birthdayStr);
            /*0x73684f8*/ Assets.Platform.SignInResult ProcessAuthResult(Assets.Api.Client.AuthResult authResult, Assets.Plugins.WebGl.JSInterop.GetTokenResult getTokenResult);

            struct <LoginWorld>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.PlatformBase <>4__this;
                /*0x30*/ long worldMasterId;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.StringResult>> <>u__1;

                /*0x7368688*/ void MoveNext();
                /*0x7368bf0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x7368bfc*/ void MoveNext();
                /*0x736964c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x73696a4*/ void MoveNext();
                /*0x736a938*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignIn>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ string data;
                /*0x38*/ Assets.Platform.PlatformBase <>4__this;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.ApiResponse<Assets.Api.Client.AuthResult>> <>u__1;

                /*0x736a990*/ void MoveNext();
                /*0x736b0bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignIn>d__50 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ string viewerId;
                /*0x40*/ string oneTimeToken;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.AuthResult>> <>u__1;

                /*0x736b114*/ void MoveNext();
                /*0x736b834*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInByDeviceUniqueIdentifier>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.AuthResult>> <>u__1;

                /*0x736b88c*/ void MoveNext();
                /*0x736bde4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInThroughFrame>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.PlatformBase <>4__this;
                /*0x38*/ Assets.Plugins.WebGl.JSInterop.GetTokenResult <getTokenResult>5__2;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.GetTokenResult> <>u__1;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.ApiResponse<Assets.Api.Client.AuthResult>> <>u__2;

                /*0x736be3c*/ void MoveNext();
                /*0x736c8e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class UnityEditorPlatform : Assets.Platform.PlatformBase
        {
            /*0x736c93c*/ UnityEditorPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x736c940*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x736c9dc*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x736cadc*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x736cb88*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x736cc20*/ void NavigateNewVersion();
            /*0x736cc58*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x736cd70*/ Assets.Platform.UnityEditorPlatform.EnvironmentSettings LoadSettingsFromDisk();
            /*0x736cf68*/ string GetProductId(long platformProductMasterId);
            /*0x736cfa0*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x736cfd8*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x736d03c*/ Cysharp.Threading.Tasks.UniTask<bool> PostPurchaseWebGL(string receipt, string signature);

            class EnvironmentSettings
            {
                /*0x10*/ int <DmmUserId>k__BackingField;
                /*0x18*/ long <AccountId>k__BackingField;

                /*0x736cf60*/ EnvironmentSettings();
                /*0x736d154*/ int get_DmmUserId();
                /*0x736d15c*/ void set_DmmUserId(int value);
                /*0x736d164*/ long get_AccountId();
                /*0x736d16c*/ void set_AccountId(long value);
            }

            struct <InitializeInAppPurchaseHandler>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.UnityEditorPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x736d174*/ void MoveNext();
                /*0x736d7a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchaseWebGL>d__12 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                /*0x30*/ Assets.Platform.UnityEditorPlatform <>4__this;
                /*0x38*/ string receipt;
                /*0x40*/ string signature;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessDmmWebReceiptResult>> <>u__1;

                /*0x736d7b4*/ void MoveNext();
                /*0x736de6c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.UnityEditorPlatform <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.AuthResult>> <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__2;

                /*0x736dec4*/ void MoveNext();
                /*0x736edcc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebGLOrStandalonePlatform : Assets.Platform.PlatformBase
        {
            /*0x736ee24*/ WebGLOrStandalonePlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x736ee28*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x736eed8*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x736efd8*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x736f084*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x736f11c*/ bool CopyToClipboard(string text);
            /*0x736f1d0*/ void NavigateNewVersion();
            /*0x736f274*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x736f2e4*/ string GetProductId(long platformProductMasterId);
            /*0x736f3d4*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x736f4e0*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);

            struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> <>u__1;

                /*0x736f52c*/ void MoveNext();
                /*0x736fb20*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitializeInAppPurchaseHandler>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x736fb2c*/ void MoveNext();
                /*0x73700a8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x73700b4*/ void MoveNext();
                /*0x73706c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <SignInAsync>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Platform.SignInResult> <>t__builder;
                /*0x30*/ Assets.Platform.WebGLOrStandalonePlatform <>4__this;
                /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> <>u__1;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Platform.SignInResult> <>u__2;

                /*0x737071c*/ void MoveNext();
                /*0x737111c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class WebGLPlatform : Assets.Platform.PlatformBase
        {
            /*0x7371174*/ WebGLPlatform(Assets.Configuration.IApplicationConfiguration configuration, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Api.Client.IApiClientOnPlatform apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB);
            /*0x7371178*/ Cysharp.Threading.Tasks.UniTask Initialize();
            /*0x7371228*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.SignInResult> SignInAsync();
            /*0x7371258*/ Cysharp.Threading.Tasks.UniTask InitializeInAppPurchaseHandler();
            /*0x7371304*/ Cysharp.Threading.Tasks.UniTask SignOutAsync();
            /*0x737139c*/ bool CopyToClipboard(string text);
            /*0x7371450*/ Assets.Platform.InAppPurchase.IInAppPurchaseHandler CreateAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
            /*0x73714c0*/ string GetProductId(long platformProductMasterId);
            /*0x73715b0*/ Cysharp.Threading.Tasks.UniTask<System.Nullable<bool>> PostPaymentCanStart(string productId, int price, int quantity);
            /*0x73716bc*/ Cysharp.Threading.Tasks.UniTask PostPurchase(string receipt, string signature);
            /*0x73717a0*/ void NavigateNewVersion();

            struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> <>u__1;

                /*0x7371844*/ void MoveNext();
                /*0x7371e34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InitializeInAppPurchaseHandler>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x7371e40*/ void MoveNext();
                /*0x73723bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x73723c8*/ void MoveNext();
                /*0x73729d8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <PostPurchase>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ Assets.Platform.WebGLPlatform <>4__this;
                /*0x30*/ string receipt;
                /*0x38*/ string signature;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.ProcessDmmWebReceiptResult>> <>u__1;

                /*0x7372a30*/ void MoveNext();
                /*0x7373128*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        namespace InAppPurchase
        {
            class AppleAppStoreInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x7360428*/ AppleAppStoreInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x7373200*/ void Initialize();
                /*0x7373880*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x7373f60*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x73743b4*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
                /*0x73746ec*/ void OnDeferred(UnityEngine.Purchasing.Product item);
                /*0x7374754*/ void OnTransactionsRestored(bool success, string message);
                /*0x737485c*/ void <Purchase>b__2_0(object _);

                class <>c
                {
                    static /*0x0*/ Assets.Platform.InAppPurchase.AppleAppStoreInAppPurchaseHandler.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.PlatformProductMaster, string> <>9__1_0;
                    static /*0x10*/ System.Func<string, bool> <>9__1_1;

                    static /*0x73748d8*/ <>c();
                    /*0x7374940*/ <>c();
                    /*0x7374948*/ string <Initialize>b__1_0(Assets.Api.Client.PlatformProductMaster x);
                    /*0x7374960*/ bool <Initialize>b__1_1(string x);
                }
            }

            class DmmInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x54*/ Assets.Configuration.GameRatings gameRating;
                /*0x58*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> initUcs;

                /*0x73614d4*/ DmmInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x7367190*/ string get_ViewerId();
                /*0x7374980*/ string get_CommerceUrl();
                /*0x73638c0*/ Cysharp.Threading.Tasks.UniTask Initialize(string dmmOpenId, string dmmAccessToken, string dmmApiToken, Assets.Configuration.GameRatings gameRating, bool isSandbox, System.Uri productsBaseUri);
                /*0x7374a6c*/ string[] LoadProducts();
                /*0x7374cd0*/ Cysharp.Threading.Tasks.UniTask<System.String[]> LoadProducts(System.Uri productsUri);
                /*0x7374f34*/ void Initialize(string dmmOpenId, string dmmAccessToken, string dmmApiToken, Assets.Configuration.GameRatings gameRating);
                /*0x7374f6c*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
                /*0x7375090*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x7375164*/ void SetProductIcon(string producId, UnityEngine.Texture2D texture);
                /*0x7375248*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x7375630*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
                /*0x7375814*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
                /*0x7375a00*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7375e00*/ void <Purchase>b__14_0(object _);

                class <>c
                {
                    static /*0x0*/ Assets.Platform.InAppPurchase.DmmInAppPurchaseHandler.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.PlatformProductMaster, string> <>9__8_0;
                    static /*0x10*/ System.Func<string, bool> <>9__8_1;

                    static /*0x7375e7c*/ <>c();
                    /*0x7375ee4*/ <>c();
                    /*0x7375eec*/ string <LoadProducts>b__8_0(Assets.Api.Client.PlatformProductMaster x);
                    /*0x7375f1c*/ bool <LoadProducts>b__8_1(string x);
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ System.Uri productsUri;
                    /*0x18*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<System.String[]> getProductsTsc;

                    /*0x7374f2c*/ <>c__DisplayClass9_0();
                    /*0x7375f3c*/ void <LoadProducts>b__0(Best.HTTP.HTTPRequest request, Best.HTTP.HTTPResponse response);
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

                    /*0x73762b0*/ void MoveNext();
                    /*0x7376c4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class DmmWebGLInAppPurchaseHandler : Assets.Platform.InAppPurchase.DmmInAppPurchaseHandler
            {
                /*0x736cd68*/ DmmWebGLInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x736d6f0*/ Cysharp.Threading.Tasks.UniTask Initialize(Assets.Configuration.GameRatings gameRating, bool isSandbox);

                struct <Initialize>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Platform.InAppPurchase.DmmWebGLInAppPurchaseHandler <>4__this;
                    /*0x30*/ Assets.Configuration.GameRatings gameRating;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x7376c58*/ void MoveNext();
                    /*0x7377174*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class GooglePlayInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x7367798*/ GooglePlayInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x7377180*/ void Initialize();
                /*0x737775c*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x7377b24*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7377edc*/ void <Purchase>b__2_0(object _);

                class GooglePlayJsonAndSignature
                {
                    /*0x10*/ string <Json>k__BackingField;
                    /*0x18*/ string <Signature>k__BackingField;

                    /*0x7377f78*/ GooglePlayJsonAndSignature();
                    /*0x7377f58*/ string get_Json();
                    /*0x7377f60*/ void set_Json(string value);
                    /*0x7377f68*/ string get_Signature();
                    /*0x7377f70*/ void set_Signature(string value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.Platform.InAppPurchase.GooglePlayInAppPurchaseHandler.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.PlatformProductMaster, string> <>9__1_0;
                    static /*0x10*/ System.Func<string, bool> <>9__1_1;

                    static /*0x7377fcc*/ <>c();
                    /*0x7378034*/ <>c();
                    /*0x737803c*/ string <Initialize>b__1_0(Assets.Api.Client.PlatformProductMaster x);
                    /*0x7378054*/ bool <Initialize>b__1_1(string x);
                }
            }

            interface IInAppPurchaseHandler
            {
                /*0x38159dc*/ void Initialize();
                /*0x3813ffc*/ bool get_Initialized();
                /*0x3816710*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x3816810*/ void SetProductIcon(string productId, UnityEngine.Texture2D texture);
                Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                System.Nullable<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> GetPendingPurchaseOrDefault();
                /*0x3816710*/ void ConfirmPendingTransaction(UnityEngine.Purchasing.Product product);
            }

            class PurchaseResult
            {
                /*0x10*/ string <Receipt>k__BackingField;
                /*0x18*/ string <Signature>k__BackingField;
                /*0x20*/ UnityEngine.Purchasing.Product <Product>k__BackingField;

                /*0x7374380*/ PurchaseResult();
                /*0x7378074*/ string get_Receipt();
                /*0x737807c*/ void set_Receipt(string value);
                /*0x7378084*/ string get_Signature();
                /*0x737808c*/ void set_Signature(string value);
                /*0x7378094*/ UnityEngine.Purchasing.Product get_Product();
                /*0x737809c*/ void set_Product(UnityEngine.Purchasing.Product value);
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

                /*0x7373134*/ InAppPurchaseHandlerBase(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x73780a4*/ System.Collections.Generic.Queue<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> get_PendingPurchaseTasks();
                /*0x7373e20*/ UnityEngine.Purchasing.IStoreController get_StoreController();
                /*0x7374338*/ UnityEngine.Purchasing.IExtensionProvider get_ExtensionProvider();
                /*0x73780ac*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.InAppPurchase.PurchaseResult> get_ActivePurchaseTCS();
                /*0x73780b4*/ void set_ActivePurchaseTCS(Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Platform.InAppPurchase.PurchaseResult> value);
                /*0x73780bc*/ UnityEngine.Purchasing.AppStore get_CurrentAppStore();
                /*0x73780c4*/ void set_CurrentAppStore(UnityEngine.Purchasing.AppStore value);
                /*0x73780cc*/ bool get_IsPurchaseRestricted();
                /*0x73780d4*/ void set_IsPurchaseRestricted(bool value);
                /*0x73780e0*/ bool get_Initialized();
                /*0x73780e8*/ void Initialize();
                /*0x7378120*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x7378158*/ void SetProductIcon(string productId, UnityEngine.Texture2D texture);
                /*0x7378190*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x73781c8*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7378200*/ System.Nullable<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> GetPendingPurchaseOrDefault();
                /*0x7378310*/ void ConfirmPendingTransaction(UnityEngine.Purchasing.Product product);
                /*0x7374fec*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
                /*0x7378474*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
                /*0x7378534*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error, string message);
                /*0x73785fc*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.Extension.PurchaseFailureDescription failureDescription);
                /*0x7378620*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason);
                /*0x7373c48*/ bool ValidatePurchase(ref System.Nullable<UnityEngine.Purchasing.PurchaseFailureReason> reason);
                /*0x7373e68*/ bool ValidateProduct(UnityEngine.Purchasing.Product product, ref System.Nullable<UnityEngine.Purchasing.PurchaseFailureReason> reason);
            }

            class PurchaseException : System.Exception
            {
                /*0x8c*/ UnityEngine.Purchasing.PurchaseFailureReason <Reason>k__BackingField;

                /*0x7373db4*/ PurchaseException(UnityEngine.Purchasing.PurchaseFailureReason reason);
                /*0x7378a0c*/ UnityEngine.Purchasing.PurchaseFailureReason get_Reason();
            }

            class UnityEditorInAppPurchaseHandler : Assets.Platform.InAppPurchase.InAppPurchaseHandlerBase
            {
                /*0x736cd6c*/ UnityEditorInAppPurchaseHandler(Assets.Configuration.IApplicationConfiguration configuration, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient);
                /*0x7378a14*/ void Initialize();
                /*0x7378a18*/ void SetProductIcon(UnityEngine.Texture2D texture);
                /*0x7378a1c*/ void SetProductIcon(string productId, UnityEngine.Texture2D texture);
                /*0x7378a20*/ Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult> Purchase(string productId);
                /*0x7378a58*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
                /*0x7378a90*/ System.Nullable<Cysharp.Threading.Tasks.UniTask<Assets.Platform.InAppPurchase.PurchaseResult>> GetPendingPurchaseOrDefault();
                /*0x7378a9c*/ void ConfirmPendingTransaction(UnityEngine.Purchasing.Product product);
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
