class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3c2c624*/ EmbeddedAttribute();
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

                /*0x3c2c62c*/ NullableAttribute(byte );
                /*0x3c2c6b4*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3c2c6e4*/ NullableContextAttribute(byte );
            }
        }
    }
}

class MosaicRenderer : UnityEngine.MonoBehaviour
{
    /*0x20*/ Assets.Utilities.Spine.RendererOverride <RendererOverride>k__BackingField;

    /*0x3c2ccec*/ MosaicRenderer();
    /*0x3c2c70c*/ Assets.Utilities.Spine.RendererOverride get_RendererOverride();
    /*0x3c2c714*/ void set_RendererOverride(Assets.Utilities.Spine.RendererOverride value);
    /*0x3c2c71c*/ void OnEnable();
    /*0x3c2ca88*/ void OnDisable();
}

class RendererOverrideListener : UnityEngine.ScriptableObject
{
    static /*0x0*/ System.Collections.Generic.List<Assets.Utilities.Spine.RendererOverride> targets;
    static /*0x8*/ object locked;

    static /*0x3c2cd7c*/ RendererOverrideListener();
    static /*0x3c2c774*/ void Register(Assets.Utilities.Spine.RendererOverride rendererOverride);
    static /*0x3c2cae0*/ void Unregister(Assets.Utilities.Spine.RendererOverride rendererOverride);
    /*0x3c2cd74*/ RendererOverrideListener();
    /*0x3c2ccfc*/ Assets.Utilities.Spine.RendererOverride[] GetTargets();

    class <>c
    {
        static /*0x0*/ RendererOverrideListener.<> <>9;
        static /*0x8*/ System.Func<Assets.Utilities.Spine.RendererOverride, int> <>9__2_0;

        static /*0x3c2ce50*/ <>c();
        /*0x3c2ceb8*/ <>c();
        /*0x3c2cec0*/ int <Register>b__2_0(Assets.Utilities.Spine.RendererOverride target);
    }

    class <>c__DisplayClass3_0
    {
        /*0x10*/ Assets.Utilities.Spine.RendererOverride rendererOverride;

        /*0x3c2ccf4*/ <>c__DisplayClass3_0();
        /*0x3c2cf38*/ bool <Unregister>b__0(Assets.Utilities.Spine.RendererOverride target);
    }
}

interface ICustomDebugCommands
{
}

class CustomDebugCommands : System.IDisposable, ICustomDebugCommands
{
    /*0x3c2cfa8*/ CustomDebugCommands();
    /*0x3c2cfa4*/ void Dispose();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c2cfb0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c2d0a4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    class EntryPoint : VContainer.Unity.IAsyncStartable, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint
    {
        /*0x10*/ bool <Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint.IsEntryInitializationCompleted>k__BackingField;
        /*0x18*/ Assets.IEntryProcess entryProcess;
        /*0x20*/ Assets.GameUi.Externals.ICameraManager cameraController;

        /*0x3c2d0c0*/ EntryPoint(Assets.IEntryProcess entryProcess, Assets.UiComponentSystem.Runtime.IGameNavigator gameNavigator, Assets.GameUi.Externals.ICameraManager cameraController, Assets.Configuration.IApplicationConfiguration configuration);
        /*0x3c2d0ac*/ bool Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint.get_IsEntryInitializationCompleted();
        /*0x3c2d0b4*/ void Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint.set_IsEntryInitializationCompleted(bool value);
        /*0x3c2d730*/ Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken cancellation);

        class <>c
        {
            static /*0x0*/ Assets.EntryPoint.<> <>9;
            static /*0x8*/ System.Action<string> <>9__6_0;
            static /*0x10*/ System.Action<System.Exception> <>9__6_1;

            static /*0x3c2d7dc*/ <>c();
            /*0x3c2d844*/ <>c();
            /*0x3c2d84c*/ void <.ctor>b__6_0(string message);
            /*0x3c2d8a4*/ void <.ctor>b__6_1(System.Exception exception);
        }

        struct <StartAsync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            /*0x28*/ Assets.EntryPoint <>4__this;
            /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

            /*0x3c2d928*/ void MoveNext();
            /*0x3c2e1d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    interface IEntryProcess
    {
        /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Run();
    }

    class EntryProcess : Assets.IEntryProcess
    {
        /*0x10*/ Assets.GameUi.Externals.ICameraManager cameraController;
        /*0x18*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
        /*0x20*/ Assets.AssetManagement.IAssetInstanceProvider instanceProvider;
        /*0x28*/ Assets.GameUi.Externals.LayoutManager layoutController;
        /*0x30*/ Assets.AssetManagement.IDirectAssetProvider directAssetProvider;
        /*0x38*/ Assets.Plugins.WebGl.IJSInterop jSInterop;
        /*0x40*/ Assets.Platform.IPlatform platform;
        /*0x48*/ Assets.Api.Client.ConnectionManager.IConnectionManager connectionManager;
        /*0x50*/ Assets.Api.Client.IApiClientOnMemoryDB apiClient;
        /*0x58*/ Assets.Api.MemoryDB.IMemoryDBOnEntry memoryDB;
        /*0x60*/ Assets.Api.Client.Time.IAdjustedTimeOnEntry adjustedTime;
        /*0x68*/ Assets.Configuration.IApplicationConfiguration configuration;
        /*0x70*/ Assets.AssetManagement.IAddressablesKeyProvider addressablesKeyProvider;
        /*0x78*/ Assets.AssetManagement.IDirectKeyProvider directKeyProvider;
        /*0x80*/ Assets.GameUi.Externals.ILocalSettingsManager localSettings;
        /*0x88*/ Assets.GameUi.Service.IPurchaseService purchaseService;
        /*0x90*/ Assets.GameUi.Service.IRealtimeService realtimeService;
        /*0x98*/ ICustomDebugCommands customDebugCommands;
        /*0xa0*/ Assets.Api.Client.IErrorHandler errorHandler;
        /*0xa8*/ bool initialized;

        /*0x3c2e1e0*/ EntryProcess(Assets.GameUi.Externals.ICameraManager cameraController, Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.GameUi.Externals.LayoutManager layoutController, Assets.AssetManagement.IDirectAssetProvider directAssetProvider, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Platform.IPlatform platform, Assets.Api.Client.ConnectionManager.IConnectionManager connectionManager, Assets.Api.Client.IApiClientOnMemoryDB apiClient, Assets.Api.MemoryDB.IMemoryDBOnEntry memoryDB, Assets.Api.Client.Time.IAdjustedTimeOnEntry adjustedTime, Assets.Configuration.IApplicationConfiguration configuration, Assets.AssetManagement.IAddressablesKeyProvider addressablesKeyProvider, Assets.AssetManagement.IDirectKeyProvider directKeyProvider, Assets.GameUi.Externals.ILocalSettingsManager localSettings, Assets.GameUi.Service.IPurchaseService purchaseService, Assets.GameUi.Service.IRealtimeService realtimeService, ICustomDebugCommands customDebugCommands, Assets.Api.Client.IErrorHandler errorHandler);
        /*0x3c2e3ac*/ Cysharp.Threading.Tasks.UniTask Run();
        /*0x3c2e460*/ void ProcessAndroidInitialization();
        /*0x3c2e700*/ string <Run>b__21_0();
        /*0x3c2e7a4*/ bool <Run>b__21_1();

        struct <Run>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            /*0x28*/ Assets.EntryProcess <>4__this;
            /*0x30*/ string <remoteAssetUrl>5__2;
            /*0x38*/ string <directAssetUrl>5__3;
            /*0x40*/ bool <isAstcFormatIsSupported>5__4;
            /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
            /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

            /*0x3c2e85c*/ void MoveNext();
            /*0x3c300f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class ErrorHandler : Assets.Api.Client.IErrorHandler, System.IDisposable
    {
        /*0x10*/ System.Collections.Generic.Queue<Assets.ErrorHandler.Handler> errorQueue;
        /*0x18*/ UniRx.CompositeDisposable disposables;
        /*0x20*/ Assets.UiComponentSystem.Runtime.IGameNavigator navigator;
        /*0x28*/ bool isProcessing;

        /*0x3c30104*/ ErrorHandler(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
        /*0x3c3036c*/ void ThrowError(string body);
        /*0x3c30484*/ void ThrowError(string body, Assets.Api.Client.IErrorHandler.ActionTypes onCloseActionType);
        /*0x3c30598*/ void ThrowError(string body, System.Func<Cysharp.Threading.Tasks.UniTask> onCloseAction);
        /*0x3c30690*/ Cysharp.Threading.Tasks.UniTask ProcessError(Assets.ErrorHandler.Handler handler);
        /*0x3c30760*/ void Dispose();
        /*0x3c3077c*/ bool <.ctor>b__4_0(long _);
        /*0x3c307dc*/ void <.ctor>b__4_1(long _);

        class Handler
        {
            /*0x10*/ string <Body>k__BackingField;
            /*0x18*/ System.Nullable<Assets.Api.Client.IErrorHandler.ActionTypes> <OnCloseActionType>k__BackingField;
            /*0x20*/ System.Func<Cysharp.Threading.Tasks.UniTask> <OnCloseAction>k__BackingField;

            /*0x3c30450*/ Handler();
            /*0x3c3088c*/ string get_Body();
            /*0x3c30894*/ void set_Body(string value);
            /*0x3c3089c*/ System.Nullable<Assets.Api.Client.IErrorHandler.ActionTypes> get_OnCloseActionType();
            /*0x3c308a4*/ void set_OnCloseActionType(System.Nullable<Assets.Api.Client.IErrorHandler.ActionTypes> value);
            /*0x3c308ac*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnCloseAction();
            /*0x3c308b4*/ void set_OnCloseAction(System.Func<Cysharp.Threading.Tasks.UniTask> value);
        }

        struct <<-ctor>b__4_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x38*/ Assets.ErrorHandler <>4__this;
            /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

            /*0x3c308bc*/ void MoveNext();
            /*0x3c30c18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <ProcessError>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            /*0x28*/ Assets.ErrorHandler.Handler handler;
            /*0x30*/ Assets.ErrorHandler <>4__this;
            /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.GameUi.ModalWindow.TextModal.TextModalWindowController.ResultTypes> <>u__1;
            /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

            /*0x3c30c24*/ void MoveNext();
            /*0x3c31960*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class RootLifetimeScope : VContainer.Unity.LifetimeScope
    {
        /*0x68*/ Assets.GameUi.Externals.CameraManager cameraManager;
        /*0x70*/ Assets.GameUi.Externals.LayoutManager layoutManager;
        /*0x78*/ Assets.GameUi.Externals.AudioManager audioManager;
        /*0x80*/ Assets.GameUi.Externals.BackgroundManager backgroundManager;
        /*0x88*/ Assets.GameUi.Header.HeaderComponent headerComponent;
        /*0x90*/ Assets.GameUi.Guide.GuideComponent guideComponent;
        /*0x98*/ Assets.GameUi.Toast.ToastComponent toastComponent;
        /*0xa0*/ Assets.GameUi.TouchBlock.TouchBlockComponent touchBlockComponent;
        /*0xa8*/ Assets.AssetManagement.UnusedInstanceManager unusedInstanceManager;
        /*0xb0*/ Assets.GameUi.EmergencyModal.EmergencyModalComponent emergencyTextModal;
        /*0xb8*/ Assets.Configuration.ApplicationConfiguration <Configuration>k__BackingField;

        static /*0x3c3197c*/ void InstantiateLifetimeScope();
        static /*0x3c31a34*/ void InitializeGraphicsSettings();
        /*0x3c327a8*/ RootLifetimeScope();
        /*0x3c3196c*/ Assets.Configuration.ApplicationConfiguration get_Configuration();
        /*0x3c31974*/ void set_Configuration(Assets.Configuration.ApplicationConfiguration value);
        /*0x3c31ad8*/ void Configure(VContainer.IContainerBuilder builder);
        /*0x3c324a4*/ System.Type SelectPlatformType();
        /*0x3c32684*/ System.Type <SelectPlatformType>g__SelectAndroidPlatform|17_0();

        class <>c
        {
            static /*0x0*/ Assets.RootLifetimeScope.<> <>9;
            static /*0x8*/ System.Func<System.Type, bool> <>9__16_0;
            static /*0x10*/ System.Func<System.Type, bool> <>9__16_1;

            static /*0x3c32800*/ <>c();
            /*0x3c32868*/ <>c();
            /*0x3c32870*/ bool <Configure>b__16_0(System.Type t);
            /*0x3c328b4*/ bool <Configure>b__16_1(System.Type t);
        }
    }

    namespace DebugTools
    {
        namespace DebugMenu
        {
            class DebugInputFieldWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent, Assets.DebugTools.DebugMenu.DebugInputFieldWindowController, Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args>
            {
                /*0x48*/ TMPro.TextMeshProUGUI captionText;
                /*0x50*/ TMPro.TMP_InputField inputField;
                /*0x58*/ UnityEngine.UI.Button okButton;
                /*0x60*/ UnityEngine.UI.Button cancelButton;

                /*0x3c32b88*/ DebugInputFieldWindowComponent();
                /*0x3c32918*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args);
                /*0x3c32a0c*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args);
                /*0x3c32b30*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                /*0x3c32bd0*/ void <ProcessOnCreate>b__4_0();
                /*0x3c32c48*/ void <ProcessOnCreate>b__4_1();

                class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent>
                {
                    /*0x10*/ string <Caption>k__BackingField;
                    /*0x18*/ string <PlaceHolder>k__BackingField;
                    /*0x20*/ string <DefaultValue>k__BackingField;

                    /*0x3c32cf8*/ Args();
                    /*0x3c32cc8*/ string get_Caption();
                    /*0x3c32cd0*/ void set_Caption(string value);
                    /*0x3c32cd8*/ string get_PlaceHolder();
                    /*0x3c32ce0*/ void set_PlaceHolder(string value);
                    /*0x3c32ce8*/ string get_DefaultValue();
                    /*0x3c32cf0*/ void set_DefaultValue(string value);
                }

                struct <ProcessOnCreate>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args;
                    /*0x38*/ Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3c32d64*/ void MoveNext();
                    /*0x3c33298*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class DebugInputFieldComponentNavigation
            {
                static /*0x3c332f0*/ Cysharp.Threading.Tasks.UniTask MoveToDebugInputFieldComponent(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
            }

            class DebugInputFieldWindowController : Assets.UiComponentSystem.Runtime.Controller<string>
            {
                /*0x3c333ac*/ DebugInputFieldWindowController();
            }

            class DebugLocalSettingsManager
            {
                static string LocalSettingsKey = "Inu_DebugLocalSetting";
                /*0x10*/ Assets.DebugTools.DebugMenu.DebugLocalSettings localSettings;

                /*0x3c3357c*/ DebugLocalSettingsManager();
                /*0x3c333f4*/ void Save(Assets.DebugTools.DebugMenu.DebugLocalSettings settings);
                /*0x3c33490*/ Assets.DebugTools.DebugMenu.DebugLocalSettings Load();
            }

            class DebugLocalSettings
            {
                /*0x10*/ bool <DisableAutoOpenManual>k__BackingField;

                /*0x3c33574*/ DebugLocalSettings();
                /*0x3c33584*/ bool get_DisableAutoOpenManual();
                /*0x3c3358c*/ void set_DisableAutoOpenManual(bool value);
            }

            class DebugManualScrollViewCard : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugManualScrollViewCard, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs>
            {
                /*0x90*/ TMPro.TextMeshProUGUI headText;
                /*0x98*/ TMPro.TextMeshProUGUI bodyText;

                /*0x3c33638*/ DebugManualScrollViewCard();
                /*0x3c33598*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs args);

                class DebugManualScrollViewCardArgs
                {
                    /*0x10*/ string <Head>k__BackingField;
                    /*0x18*/ string <Body>k__BackingField;

                    /*0x3c336a0*/ DebugManualScrollViewCardArgs();
                    /*0x3c33680*/ string get_Head();
                    /*0x3c33688*/ void set_Head(string value);
                    /*0x3c33690*/ string get_Body();
                    /*0x3c33698*/ void set_Body(string value);
                }
            }

            class DebugMenuComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugMenuComponent, Assets.DebugTools.DebugMenu.DebugMenuController>
            {
                /*0x40*/ UnityEngine.UI.Button debugButton;
                /*0x48*/ TMPro.TextMeshProUGUI fpsLabel;
                /*0x50*/ TMPro.TextMeshProUGUI renderingStatisticsLabel;
                /*0x58*/ UnityEngine.Transform gridParent;
                /*0x60*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup giveMenu;
                /*0x68*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup dateMenu;
                /*0x70*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup assetMenu;
                /*0x78*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup scenarioMenu;
                /*0x80*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup backgroundMenu;
                /*0x88*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup advancedMenu;
                /*0x90*/ TMPro.TextMeshProUGUI label;
                /*0x98*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel userInfoPanel;
                /*0xa0*/ Assets.GameUi.Toast.ToastComponent toast;
                /*0xa8*/ UnityEngine.GameObject restartBlockPanel;
                /*0xb0*/ UnityEngine.UI.Button closeButton;
                /*0xb8*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.InputWindow inputWindow;
                /*0xc0*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.ManualWindow manualWindow;
                /*0xc8*/ UnityEngine.UI.Button helpButton;
                /*0xd0*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.SpineTapArea[] spineTapAreas;
                /*0xd8*/ UnityEngine.RectTransform screenRect;
                /*0xe0*/ TMPro.TextMeshProUGUI <AstcLabel>k__BackingField;
                /*0xe8*/ Assets.GameUi.Externals.IBackgroundManager <BackgroundController>k__BackingField;
                /*0xf0*/ System.Collections.Generic.List<string> sentExceptionMessages;
                /*0xf8*/ System.Collections.Generic.List<System.ValueTuple<string, string>> manual;
                /*0x100*/ float frameDeltaTime;
                /*0x104*/ bool visibleFps;
                /*0x105*/ bool visibleShowRenderingStatistics;
                /*0x108*/ Unity.Profiling.ProfilerRecorder drawCallsRecorder;
                /*0x110*/ Unity.Profiling.ProfilerRecorder batchesRecorder;

                /*0x3c3729c*/ DebugMenuComponent();
                /*0x3c336f4*/ TMPro.TextMeshProUGUI get_AstcLabel();
                /*0x3c336fc*/ void set_AstcLabel(TMPro.TextMeshProUGUI value);
                /*0x3c33704*/ Assets.GameUi.Externals.IBackgroundManager get_BackgroundController();
                /*0x3c3370c*/ void set_BackgroundController(Assets.GameUi.Externals.IBackgroundManager value);
                /*0x3c33714*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                /*0x3c36124*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                /*0x3c36370*/ void OnEnable();
                /*0x3c36414*/ void Update();
                /*0x3c3675c*/ UnityEngine.UI.Button CreateButton(string label, UnityEngine.Transform parent, UnityEngine.UI.Button originalButton);
                /*0x3c369a8*/ UnityEngine.UI.Button CreateButtonAndManual(string label, UnityEngine.Transform parent, UnityEngine.UI.Button originalButton, string manual);
                /*0x3c36084*/ UnityEngine.UI.Button CreateGiveButton(string label, string manual);
                /*0x3c360a4*/ UnityEngine.UI.Button CreateDateButton(string label, string manual);
                /*0x3c36104*/ UnityEngine.UI.Button CreateAssetButton(string label, string manual);
                /*0x3c360c4*/ UnityEngine.UI.Button CreateScenarioButton(string label, string manual);
                /*0x3c360e4*/ UnityEngine.UI.Button CreateBackgroundButton(string label, string manual);
                /*0x3c36068*/ UnityEngine.UI.Button CreateAdvancedButton(string label);
                /*0x3c36abc*/ void Open();
                /*0x3c371f4*/ void Close();
                /*0x3c37244*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();

                enum DebugMenuCategoryTypes
                {
                    None = 0,
                    Give = 1,
                    Date = 2,
                    Asset = 3,
                    Scenario = 4,
                    Background = 5,
                    Advanced = 6,
                }

                class DebugMenuGroup : UnityEngine.UI.IClickable
                {
                    /*0x10*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes <Type>k__BackingField;
                    /*0x18*/ UnityEngine.Transform <Panel>k__BackingField;
                    /*0x20*/ UnityEngine.UI.Button <Button>k__BackingField;
                    /*0x28*/ UnityEngine.UI.Image <SelectedImage>k__BackingField;

                    /*0x3c373d4*/ DebugMenuGroup();
                    /*0x3c37394*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes get_Type();
                    /*0x3c3739c*/ void set_Type(Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes value);
                    /*0x3c373a4*/ UnityEngine.Transform get_Panel();
                    /*0x3c373ac*/ void set_Panel(UnityEngine.Transform value);
                    /*0x3c373b4*/ UnityEngine.UI.Button get_Button();
                    /*0x3c373bc*/ void set_Button(UnityEngine.UI.Button value);
                    /*0x3c373c4*/ UnityEngine.UI.Image get_SelectedImage();
                    /*0x3c373cc*/ void set_SelectedImage(UnityEngine.UI.Image value);
                }

                class UserInfoPanel
                {
                    /*0x10*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton <TokenButton>k__BackingField;
                    /*0x18*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton <SwaggerButton>k__BackingField;
                    /*0x20*/ TMPro.TextMeshProUGUI date;
                    /*0x28*/ TMPro.TextMeshProUGUI version;
                    /*0x30*/ TMPro.TextMeshProUGUI env;
                    /*0x38*/ TMPro.TextMeshProUGUI platform;
                    /*0x40*/ TMPro.TextMeshProUGUI userId;
                    /*0x48*/ TMPro.TextMeshProUGUI instanceLifetime;
                    /*0x50*/ TMPro.TextMeshProUGUI instanceQuantityAllowance;

                    /*0x3c37894*/ UserInfoPanel();
                    /*0x3c373dc*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton get_TokenButton();
                    /*0x3c373e4*/ void set_TokenButton(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton value);
                    /*0x3c373ec*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton get_SwaggerButton();
                    /*0x3c373f4*/ void set_SwaggerButton(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton value);
                    /*0x3c373fc*/ void Apply(Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel model);

                    class UserInfoPanelButton : UnityEngine.UI.IClickable
                    {
                        /*0x10*/ TMPro.TextMeshProUGUI <Text>k__BackingField;
                        /*0x18*/ UnityEngine.UI.Button <Button>k__BackingField;
                        /*0x20*/ string <Value>k__BackingField;

                        /*0x3c378cc*/ UserInfoPanelButton();
                        /*0x3c3789c*/ TMPro.TextMeshProUGUI get_Text();
                        /*0x3c378a4*/ void set_Text(TMPro.TextMeshProUGUI value);
                        /*0x3c378ac*/ UnityEngine.UI.Button get_Button();
                        /*0x3c378b4*/ void set_Button(UnityEngine.UI.Button value);
                        /*0x3c378bc*/ string get_Value();
                        /*0x3c378c4*/ void set_Value(string value);
                        /*0x3c37800*/ void Apply(string head, string value);
                    }
                }

                class InputWindow
                {
                    /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                    /*0x18*/ TMPro.TMP_InputField <Input>k__BackingField;
                    /*0x20*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent <ModalFrame>k__BackingField;
                    /*0x28*/ System.Action<string> <Action>k__BackingField;
                    /*0x30*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> <AsyncAction>k__BackingField;

                    /*0x3c37950*/ InputWindow();
                    /*0x3c37900*/ UnityEngine.GameObject get_GameObject();
                    /*0x3c37908*/ void set_GameObject(UnityEngine.GameObject value);
                    /*0x3c37910*/ TMPro.TMP_InputField get_Input();
                    /*0x3c37918*/ void set_Input(TMPro.TMP_InputField value);
                    /*0x3c37920*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent get_ModalFrame();
                    /*0x3c37928*/ void set_ModalFrame(Assets.GameUi.ModalWindow.Frame.ModalFrameComponent value);
                    /*0x3c37930*/ System.Action<string> get_Action();
                    /*0x3c37938*/ void set_Action(System.Action<string> value);
                    /*0x3c37940*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> get_AsyncAction();
                    /*0x3c37948*/ void set_AsyncAction(System.Func<string, Cysharp.Threading.Tasks.UniTask> value);
                }

                class ManualWindow
                {
                    /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                    /*0x18*/ Assets.GameUi.ScrollView.ScrollViewComponent <ScrollView>k__BackingField;
                    /*0x20*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent <ModalFrame>k__BackingField;
                    /*0x28*/ Assets.GameUi.ToggleButton <CheckButton>k__BackingField;

                    /*0x3c37998*/ ManualWindow();
                    /*0x3c37958*/ UnityEngine.GameObject get_GameObject();
                    /*0x3c37960*/ void set_GameObject(UnityEngine.GameObject value);
                    /*0x3c37968*/ Assets.GameUi.ScrollView.ScrollViewComponent get_ScrollView();
                    /*0x3c37970*/ void set_ScrollView(Assets.GameUi.ScrollView.ScrollViewComponent value);
                    /*0x3c37978*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent get_ModalFrame();
                    /*0x3c37980*/ void set_ModalFrame(Assets.GameUi.ModalWindow.Frame.ModalFrameComponent value);
                    /*0x3c37988*/ Assets.GameUi.ToggleButton get_CheckButton();
                    /*0x3c37990*/ void set_CheckButton(Assets.GameUi.ToggleButton value);
                }

                class SpineTapArea
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes <Type>k__BackingField;
                    /*0x18*/ UnityEngine.GameObject <GameObject>k__BackingField;
                    /*0x20*/ UnityEngine.RectTransform rect;

                    /*0x3c37b60*/ SpineTapArea();
                    /*0x3c379a0*/ Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes get_Type();
                    /*0x3c379a8*/ void set_Type(Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes value);
                    /*0x3c379b0*/ UnityEngine.GameObject get_GameObject();
                    /*0x3c379b8*/ void set_GameObject(UnityEngine.GameObject value);
                    /*0x3c379c0*/ void Apply(UnityEngine.Vector3 screenPosition, float radius);
                }

                class <>c
                {
                    static /*0x0*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>9;
                    static /*0x8*/ System.Func<System.ValueTuple<string, string>, int, Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs> <>9__35_77;
                    static /*0x10*/ System.Action<TMPro.TMP_LinkInfo> <>9__35_16;
                    static /*0x18*/ System.Action<TMPro.TMP_LinkInfo> <>9__35_17;
                    static /*0x20*/ System.Action<TMPro.TMP_LinkInfo> <>9__35_18;
                    static /*0x28*/ UnityEngine.Events.UnityAction <>9__35_23;
                    static /*0x30*/ UnityEngine.Events.UnityAction <>9__35_29;

                    static /*0x3c37b68*/ <>c();
                    /*0x3c37bd0*/ <>c();
                    /*0x3c37bd8*/ Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs <ProcessOnCreate>b__35_77(System.ValueTuple<string, string> m, int idx);
                    /*0x3c37c60*/ void <ProcessOnCreate>b__35_16(TMPro.TMP_LinkInfo info);
                    /*0x3c37cfc*/ void <ProcessOnCreate>b__35_17(TMPro.TMP_LinkInfo info);
                    /*0x3c37d98*/ void <ProcessOnCreate>b__35_18(TMPro.TMP_LinkInfo info);
                    /*0x3c37e34*/ void <ProcessOnCreate>b__35_23();
                    /*0x3c37e38*/ void <ProcessOnCreate>b__35_29();
                }

                class <>c__DisplayClass35_0
                {
                    /*0x10*/ Assets.DebugTools.DebugMenu.DebugMenuComponent <>4__this;
                    /*0x18*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup[] menuGroups;
                    /*0x20*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> <>9__78;
                    /*0x28*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> <>9__79;

                    /*0x3c36060*/ <>c__DisplayClass35_0();
                    /*0x3c37eb4*/ void <ProcessOnCreate>b__0();
                    /*0x3c37f60*/ void <ProcessOnCreate>b__1();
                    /*0x3c37fb8*/ void <ProcessOnCreate>b__2();
                    /*0x3c38010*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__3();
                    /*0x3c380bc*/ void <ProcessOnCreate>b__4();
                    /*0x3c38168*/ void <ProcessOnCreate>b__5();
                    /*0x3c381c0*/ void <ProcessOnCreate>b__6();
                    /*0x3c38218*/ void <ProcessOnCreate>b__7();
                    /*0x3c382c4*/ void <ProcessOnCreate>b__8(bool value);
                    /*0x3c382e8*/ void <ProcessOnCreate>b__9();
                    /*0x3c38394*/ void <ProcessOnCreate>b__10(Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup group);
                    /*0x3c38418*/ void <ProcessOnCreate>b__11(Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes value);
                    /*0x3c384cc*/ void <ProcessOnCreate>b__12(bool value);
                    /*0x3c38540*/ void <ProcessOnCreate>b__13(bool value);
                    /*0x3c386e8*/ void <ProcessOnCreate>b__14(bool value);
                    /*0x3c387a8*/ void <ProcessOnCreate>b__15(Assets.GameUi.ToggleButton button);
                    /*0x3c3889c*/ void <ProcessOnCreate>b__19();
                    /*0x3c38948*/ void <ProcessOnCreate>b__20(Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel value);
                    /*0x3c38968*/ void <ProcessOnCreate>b__21(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton button);
                    /*0x3c38ac0*/ void <ProcessOnCreate>b__22(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton button);
                    /*0x3c38b70*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__24();
                    /*0x3c38c20*/ void <ProcessOnCreate>b__25();
                    /*0x3c38c6c*/ void <ProcessOnCreate>b__26();
                    /*0x3c38cb8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__27();
                    /*0x3c38d90*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__28();
                    /*0x3c38e3c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__30();
                    /*0x3c38ee8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__31();
                    /*0x3c38ff8*/ void <ProcessOnCreate>b__32();
                    /*0x3c39024*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__33();
                    /*0x3c39134*/ void <ProcessOnCreate>b__34();
                    /*0x3c39230*/ void <ProcessOnCreate>b__35();
                    /*0x3c3932c*/ void <ProcessOnCreate>b__36();
                    /*0x3c39398*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__37();
                    /*0x3c39444*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__38();
                    /*0x3c394f0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__39();
                    /*0x3c3959c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__40();
                    /*0x3c39648*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__41();
                    /*0x3c396f4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__42();
                    /*0x3c397a0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__43();
                    /*0x3c3984c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__44();
                    /*0x3c398f8*/ void <ProcessOnCreate>b__45();
                    /*0x3c39a2c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__46();
                    /*0x3c39ad8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__47();
                    /*0x3c39b84*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__48();
                    /*0x3c39c30*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__49();
                    /*0x3c39cdc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__50();
                    /*0x3c39d88*/ void <ProcessOnCreate>b__51();
                    /*0x3c3a364*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__52();
                    /*0x3c3a410*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__53();
                    /*0x3c3a4bc*/ void <ProcessOnCreate>g__ThrowSuccessToChangeDate|54(System.DateTime d);
                    /*0x3c3a56c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__55();
                    /*0x3c3a61c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__56();
                    /*0x3c3a6cc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__57();
                    /*0x3c3a77c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__58();
                    /*0x3c3a82c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__59();
                    /*0x3c3a8dc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__60();
                    /*0x3c3a98c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__61();
                    /*0x3c3aa3c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__62();
                    /*0x3c3aaec*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__63();
                    /*0x3c3ab9c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__64();
                    /*0x3c3ac4c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__65();
                    /*0x3c3acfc*/ void <ProcessOnCreate>b__66();
                    /*0x3c3ae30*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__78(string frameJsonArrText);
                    /*0x3c3af00*/ void <ProcessOnCreate>b__67();
                    /*0x3c3afe0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__79(string inputText);
                    /*0x3c3b0b0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__68();
                    /*0x3c3b15c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__69();
                    /*0x3c3b208*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__70();
                    /*0x3c3b2b4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__71();
                    /*0x3c3b360*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__72();
                    /*0x3c3b40c*/ void <ProcessOnCreate>b__73();
                    /*0x3c3b5f4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__74();
                    /*0x3c3b6a0*/ void <ProcessOnCreate>b__75(UnityEngine.InputSystem.InputAction.CallbackContext context);
                    /*0x3c3b6c0*/ void <ProcessOnCreate>b__76(UnityEngine.InputSystem.InputAction.CallbackContext context);

                    struct <<ProcessOnCreate>b__24>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ string <inputComponentAssetName>5__2;
                        /*0x38*/ string <componentName>5__3;
                        /*0x40*/ System.Type <argsType>5__4;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;
                        /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                        /*0x3c3b6e0*/ void MoveNext();
                        /*0x3c3cc00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__28>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3cc0c*/ void MoveNext();
                        /*0x3c3d11c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__30>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3d128*/ void MoveNext();
                        /*0x3c3d604*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__37>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3d610*/ void MoveNext();
                        /*0x3c3db78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__38>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3db84*/ void MoveNext();
                        /*0x3c3e0e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__39>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3e0ec*/ void MoveNext();
                        /*0x3c3e648*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3e654*/ void MoveNext();
                        /*0x3c3eb48*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__40>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3eb54*/ void MoveNext();
                        /*0x3c3f0bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__41>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3f0c8*/ void MoveNext();
                        /*0x3c3f630*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__42>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3f63c*/ void MoveNext();
                        /*0x3c3fb98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__43>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c3fba4*/ void MoveNext();
                        /*0x3c4010c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__44>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c40118*/ void MoveNext();
                        /*0x3c40700*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__46>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4070c*/ void MoveNext();
                        /*0x3c40c84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__47>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c40c90*/ void MoveNext();
                        /*0x3c41140*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__48>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4114c*/ void MoveNext();
                        /*0x3c416b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__49>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c416c0*/ void MoveNext();
                        /*0x3c41c70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__50>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c41c7c*/ void MoveNext();
                        /*0x3c4218c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__52>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c42198*/ void MoveNext();
                        /*0x3c426f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__53>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c42700*/ void MoveNext();
                        /*0x3c42c10*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__55>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c42c1c*/ void MoveNext();
                        /*0x3c431f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__56>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c431fc*/ void MoveNext();
                        /*0x3c436cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__57>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c436d8*/ void MoveNext();
                        /*0x3c43ba8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__58>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c43bb4*/ void MoveNext();
                        /*0x3c44084*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__59>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c44090*/ void MoveNext();
                        /*0x3c44560*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__60>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c4456c*/ void MoveNext();
                        /*0x3c44a3c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__61>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c44a48*/ void MoveNext();
                        /*0x3c44f1c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__62>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c44f28*/ void MoveNext();
                        /*0x3c453fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__63>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c45408*/ void MoveNext();
                        /*0x3c458dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__64>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c458e8*/ void MoveNext();
                        /*0x3c45dbc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__65>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c45dc8*/ void MoveNext();
                        /*0x3c463fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__68>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c46408*/ void MoveNext();
                        /*0x3c46928*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__69>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c46934*/ void MoveNext();
                        /*0x3c46d90*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__70>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c46d9c*/ void MoveNext();
                        /*0x3c471f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__71>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c47204*/ void MoveNext();
                        /*0x3c47714*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__72>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c47720*/ void MoveNext();
                        /*0x3c47c68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__74>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c47c74*/ void MoveNext();
                        /*0x3c481e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__78>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ string frameJsonArrText;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c481f0*/ void MoveNext();
                        /*0x3c487f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__79>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ string inputText;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c487fc*/ void MoveNext();
                        /*0x3c48dc8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }

            class DebugMenuController : Assets.UiComponentSystem.Runtime.Controller
            {
                /*0x20*/ Assets.UiComponentSystem.Runtime.IGameNavigator navigator;
                /*0x28*/ Assets.GameUi.Externals.ILocalSettingsManager localSettings;
                /*0x30*/ Assets.Api.Client.IApiClient apiClient;
                /*0x38*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                /*0x40*/ Assets.Platform.IPlatform platform;
                /*0x48*/ Assets.Configuration.IApplicationConfiguration configuration;
                /*0x50*/ Assets.Api.Client.Time.IAdjustedTime adjustedTime;
                /*0x58*/ Assets.GameUi.Service.IMazeStateService mazeStateService;
                /*0x60*/ Assets.GameUi.Service.Tutorial.ITutorialService tutorialService;
                /*0x68*/ Assets.GameUi.Toast.IToastComponent toast;
                /*0x70*/ Assets.GameUi.Services.IBattleDebugService battleDebugService;
                /*0x78*/ Assets.GameUi.IGameNotificationsMessageBroker notificationsMessageBroker;
                /*0x80*/ Assets.GameUi.TouchBlock.ITouchBlockComponent touchblock;
                /*0x88*/ Assets.DebugTools.DebugMenu.DebugLocalSettingsManager localSettingsManager;
                /*0x90*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel> <UserInfo>k__BackingField;
                /*0x98*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes> <Category>k__BackingField;
                /*0xa0*/ UniRx.ReactiveProperty<bool> <ShowPanel>k__BackingField;
                /*0xa8*/ UniRx.ReactiveProperty<bool> <ShowInput>k__BackingField;
                /*0xb0*/ UniRx.ReactiveProperty<bool> <ShowManual>k__BackingField;
                /*0xb8*/ UniRx.ReactiveProperty<bool> <DisableAutoOpenManual>k__BackingField;
                /*0xc0*/ int[] currentClearedTutorialStages;
                /*0xc8*/ System.IDisposable disposable;

                /*0x3c48e04*/ DebugMenuController(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.Api.Client.IApiClient apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Platform.IPlatform platform, Assets.Configuration.IApplicationConfiguration configuration, Assets.GameUi.Externals.ILocalSettingsManager localSettings, Assets.Api.Client.Time.IAdjustedTime adjustedTime, Assets.GameUi.Service.IMazeStateService mazeStateService, Assets.GameUi.Service.Tutorial.ITutorialService tutorialService, Assets.GameUi.Toast.IToastComponent toast, Assets.GameUi.Services.IBattleDebugService battleDebugService, Assets.GameUi.IGameNotificationsMessageBroker notificationsMessageBroker, Assets.GameUi.TouchBlock.ITouchBlockComponent touchblock);
                /*0x3c48dd4*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel> get_UserInfo();
                /*0x3c48ddc*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes> get_Category();
                /*0x3c48de4*/ UniRx.ReactiveProperty<bool> get_ShowPanel();
                /*0x3c48dec*/ UniRx.ReactiveProperty<bool> get_ShowInput();
                /*0x3c48df4*/ UniRx.ReactiveProperty<bool> get_ShowManual();
                /*0x3c48dfc*/ UniRx.ReactiveProperty<bool> get_DisableAutoOpenManual();
                /*0x3c42b58*/ Cysharp.Threading.Tasks.UniTask ProcessMoveBackButtonClick();
                /*0x3c361bc*/ void Refresh();
                /*0x3c36b64*/ void RefreshUserInfo();
                /*0x3c37170*/ void RefreshSettingsAndManual();
                /*0x3c490f8*/ void RefreshSettings();
                /*0x3c388f4*/ void OpenPanel();
                /*0x3c38270*/ void ClosePanel();
                /*0x3c3addc*/ void OpenInput();
                /*0x3c37f0c*/ void CloseInput();
                /*0x3c38340*/ void OpenManual();
                /*0x3c38114*/ void CloseManual();
                /*0x3c3c8fc*/ Cysharp.Threading.Tasks.UniTask<string> OpenInputFieldWindow(Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args);
                /*0x3c46864*/ Cysharp.Threading.Tasks.UniTask OpenDebugAssetViewWindow(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                /*0x3c4765c*/ Cysharp.Threading.Tasks.UniTask OpenDebugSoundWindow();
                /*0x3c491cc*/ Cysharp.Threading.Tasks.UniTask OpenExceptionLogWindow(Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                /*0x3c38d10*/ Cysharp.Threading.Tasks.UniTask OpenNewsWindow();
                /*0x3c38f40*/ Cysharp.Threading.Tasks.UniTask OpenSampleModal();
                /*0x3c3cb54*/ Cysharp.Threading.Tasks.UniTask MoveTo(string componentAssetKey);
                /*0x3c3ca44*/ Cysharp.Threading.Tasks.UniTask MoveTo(string componentAssetKey, string componentName, object args);
                /*0x3c3dabc*/ Cysharp.Threading.Tasks.UniTask GiveYokubari();
                /*0x3c3e598*/ Cysharp.Threading.Tasks.UniTask GiveComsumableItems();
                /*0x3c40050*/ Cysharp.Threading.Tasks.UniTask GiveVolunteer();
                /*0x3c3e030*/ Cysharp.Threading.Tasks.UniTask GiveCharacters();
                /*0x3c3f000*/ Cysharp.Threading.Tasks.UniTask GiveMemories();
                /*0x3c3f574*/ Cysharp.Threading.Tasks.UniTask GiveMoney();
                /*0x3c3fae8*/ Cysharp.Threading.Tasks.UniTask GiveActivityLevelPoint();
                /*0x3c415f8*/ Cysharp.Threading.Tasks.UniTask GiveMaxAffection();
                /*0x3c42644*/ Cysharp.Threading.Tasks.UniTask AllUnlockFunctionOpen();
                /*0x3c40bbc*/ Cysharp.Threading.Tasks.UniTask SetMissionReceivable(Assets.Api.Client.MissionCategories category);
                /*0x3c4061c*/ Cysharp.Threading.Tasks.UniTask<bool> ResetAccount();
                /*0x3c420d4*/ Cysharp.Threading.Tasks.UniTask ShowMazeState();
                /*0x3c41b8c*/ Cysharp.Threading.Tasks.UniTask<bool> ResetMazeState();
                /*0x3c39de0*/ void ShowTutorialStatus();
                /*0x3c430ec*/ Cysharp.Threading.Tasks.UniTask<System.DateTime> ChangeDateByAdditionalSeconds(int additionalSeconds);
                /*0x3c46294*/ Cysharp.Threading.Tasks.UniTask<System.DateTime> ChangeDateToRealNow();
                /*0x3c39988*/ void DeleteLocalSettings();
                /*0x3c486f0*/ Cysharp.Threading.Tasks.UniTask<bool> MoveToScenario(string frameJsonArrText);
                /*0x3c480fc*/ Cysharp.Threading.Tasks.UniTask<bool> MoveToSampleAdultScneario();
                /*0x3c38a14*/ bool CopyToClipboard(string text);
                /*0x3c3881c*/ void SetDisableAutoOpenManualSettings(bool disableAutoOpenManual);
                /*0x3c3907c*/ Cysharp.Threading.Tasks.UniTask ShowPendingNotifications();
                /*0x3c3918c*/ void TurnOnColorTouchBlock();
                /*0x3c39288*/ void TurnOffTouchBlcok();
                /*0x3c3d064*/ Cysharp.Threading.Tasks.UniTask Reboot();
                /*0x3c492c4*/ void <Refresh>b__36_0(UniRx.Unit _);

                class UserInfoViewModel
                {
                    /*0x10*/ System.DateTime <GameDate>k__BackingField;
                    /*0x18*/ string <Version>k__BackingField;
                    /*0x20*/ Assets.Configuration.GameEnvironment <GameEnvironment>k__BackingField;
                    /*0x24*/ Assets.Configuration.GamePlatforms <GamePlatform>k__BackingField;
                    /*0x28*/ Assets.Configuration.GameDevices <GameDevice>k__BackingField;
                    /*0x2c*/ Assets.Configuration.GameRatings <GameRating>k__BackingField;
                    /*0x30*/ int <InstanceLifetime>k__BackingField;
                    /*0x34*/ int <InstanceQuantityAllowance>k__BackingField;
                    /*0x38*/ string <Token>k__BackingField;
                    /*0x40*/ System.Nullable<long> <UserId>k__BackingField;
                    /*0x50*/ string <SwaggerUrl>k__BackingField;

                    /*0x3c49160*/ UserInfoViewModel();
                    /*0x3c49568*/ System.DateTime get_GameDate();
                    /*0x3c49570*/ void set_GameDate(System.DateTime value);
                    /*0x3c49578*/ string get_Version();
                    /*0x3c49580*/ void set_Version(string value);
                    /*0x3c49588*/ Assets.Configuration.GameEnvironment get_GameEnvironment();
                    /*0x3c49590*/ void set_GameEnvironment(Assets.Configuration.GameEnvironment value);
                    /*0x3c49598*/ Assets.Configuration.GamePlatforms get_GamePlatform();
                    /*0x3c495a0*/ void set_GamePlatform(Assets.Configuration.GamePlatforms value);
                    /*0x3c495a8*/ Assets.Configuration.GameDevices get_GameDevice();
                    /*0x3c495b0*/ void set_GameDevice(Assets.Configuration.GameDevices value);
                    /*0x3c495b8*/ Assets.Configuration.GameRatings get_GameRating();
                    /*0x3c495c0*/ void set_GameRating(Assets.Configuration.GameRatings value);
                    /*0x3c495c8*/ int get_InstanceLifetime();
                    /*0x3c495d0*/ void set_InstanceLifetime(int value);
                    /*0x3c495d8*/ int get_InstanceQuantityAllowance();
                    /*0x3c495e0*/ void set_InstanceQuantityAllowance(int value);
                    /*0x3c495e8*/ string get_Token();
                    /*0x3c495f0*/ void set_Token(string value);
                    /*0x3c495f8*/ System.Nullable<long> get_UserId();
                    /*0x3c49604*/ void set_UserId(System.Nullable<long> value);
                    /*0x3c4960c*/ string get_SwaggerUrl();
                    /*0x3c49614*/ void set_SwaggerUrl(string value);
                }

                class InputVideModel
                {
                    /*0x10*/ bool <Show>k__BackingField;
                    /*0x18*/ System.Action <Action>k__BackingField;
                    /*0x20*/ System.Func<Cysharp.Threading.Tasks.UniTask> <AsyncAction>k__BackingField;

                    /*0x3c49650*/ InputVideModel();
                    /*0x3c4961c*/ bool get_Show();
                    /*0x3c49624*/ void set_Show(bool value);
                    /*0x3c49630*/ System.Action get_Action();
                    /*0x3c49638*/ void set_Action(System.Action value);
                    /*0x3c49640*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_AsyncAction();
                    /*0x3c49648*/ void set_AsyncAction(System.Func<Cysharp.Threading.Tasks.UniTask> value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.DebugTools.DebugMenu.DebugMenuController.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.MissionStageMaster, long> <>9__63_2;
                    static /*0x10*/ System.Func<string, int, Assets.Api.Client.SceneFrameMaster> <>9__71_0;

                    static /*0x3c49658*/ <>c();
                    /*0x3c496c0*/ <>c();
                    /*0x3c496c8*/ long <SetMissionReceivable>b__63_2(Assets.Api.Client.MissionStageMaster m);
                    /*0x3c496e0*/ Assets.Api.Client.SceneFrameMaster <MoveToScenario>b__71_0(string c, int idx);
                }

                class <>c__DisplayClass63_0
                {
                    /*0x10*/ Assets.Api.Client.MissionCategories category;
                    /*0x18*/ System.Func<Assets.Api.Client.MissionMaster, bool> <>9__0;

                    /*0x3c49764*/ <>c__DisplayClass63_0();
                    /*0x3c4976c*/ bool <SetMissionReceivable>b__0(Assets.Api.Client.MissionMaster m);
                }

                class <>c__DisplayClass63_1
                {
                    /*0x10*/ Assets.Api.Client.MissionMaster missionMaster;

                    /*0x3c49790*/ <>c__DisplayClass63_1();
                    /*0x3c49798*/ bool <SetMissionReceivable>b__1(Assets.Api.Client.MissionStageMaster m);
                }

                struct <AllUnlockFunctionOpen>d__62 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<bool>> <>u__1;

                    /*0x3c497c4*/ void MoveNext();
                    /*0x3c49cb8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ChangeDateByAdditionalSeconds>d__68 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.DateTime> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ int additionalSeconds;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c49cc4*/ void MoveNext();
                    /*0x3c4a6c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveActivityLevelPoint>d__60 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c4a718*/ void MoveNext();
                    /*0x3c4ac08*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveCharacters>d__57 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c4ac14*/ void MoveNext();
                    /*0x3c4b100*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveComsumableItems>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c4b10c*/ void MoveNext();
                    /*0x3c4b5f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveMaxAffection>d__61 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<bool>> <>u__1;

                    /*0x3c4eff8*/ void MoveNext();
                    /*0x3c4f4e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveMemories>d__58 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c4f4f0*/ void MoveNext();
                    /*0x3c4f9dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveMoney>d__59 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c4f9e8*/ void MoveNext();
                    /*0x3c4fed8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveVolunteer>d__56 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c4fee4*/ void MoveNext();
                    /*0x3c503d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveYokubari>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c503dc*/ void MoveNext();
                    /*0x3c508c8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveTo>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ string componentName;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ string componentAssetKey;
                    /*0x40*/ object args;
                    /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c508d4*/ void MoveNext();
                    /*0x3c51180*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveToSampleAdultScneario>d__72 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3c5118c*/ void MoveNext();
                    /*0x3c51618*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveToScenario>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ string frameJsonArrText;
                    /*0x38*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c51670*/ void MoveNext();
                    /*0x3c51c80*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenDebugAssetViewWindow>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c51cd8*/ void MoveNext();
                    /*0x3c52290*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenDebugSoundWindow>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5229c*/ void MoveNext();
                    /*0x3c527e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenSampleModal>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c527ec*/ void MoveNext();
                    /*0x3c52c38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessMoveBackButtonClick>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c52c44*/ void MoveNext();
                    /*0x3c530f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Reboot>d__78 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c53104*/ void MoveNext();
                    /*0x3c535bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ResetAccount>d__64 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c535c8*/ void MoveNext();
                    /*0x3c53b18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ResetMazeState>d__66 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c53b70*/ void MoveNext();
                    /*0x3c54260*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SetMissionReceivable>d__63 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.MissionCategories category;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ System.Collections.Generic.IEnumerator<Assets.Api.Client.MissionMaster> <>7__wrap1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c542b8*/ void MoveNext();
                    /*0x3c54e5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowMazeState>d__65 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c54e68*/ void MoveNext();
                    /*0x3c55888*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowPendingNotifications>d__75 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.GameUi.ModalWindow.TextModal.TextModalWindowController.ResultTypes> <>u__1;

                    /*0x3c55894*/ void MoveNext();
                    /*0x3c55e94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            namespace ExceptionLogWindow
            {
                class ChatworkSender : UnityEngine.MonoBehaviour
                {
                    static string RoomId = "363295064";
                    static string Token = "0e3729ef5c28cf86ac757269610f9c4d";

                    /*0x3c5612c*/ ChatworkSender();
                    /*0x3c55ea0*/ Cysharp.Threading.Tasks.UniTask Send(string message, UnityEngine.Transform hideTransform);
                    /*0x3c55f88*/ string GetPlatformName();

                    struct <Send>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ UnityEngine.Transform hideTransform;
                        /*0x30*/ Assets.DebugTools.DebugMenu.ExceptionLogWindow.ChatworkSender <>4__this;
                        /*0x38*/ string message;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                        /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Networking.UnityWebRequest> <>u__2;

                        /*0x3c56134*/ void MoveNext();
                        /*0x3c56f50*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ExceptionLogWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent, Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowController, Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args>
                {
                    /*0x48*/ UnityEngine.UI.Button closeButton;
                    /*0x50*/ UnityEngine.UI.Button sendReportButton;
                    /*0x58*/ TMPro.TextMeshProUGUI exceptionMessageText;
                    /*0x60*/ Assets.DebugTools.DebugMenu.ExceptionLogWindow.ChatworkSender chatworkSender;

                    /*0x3c57154*/ ExceptionLogWindowComponent();
                    /*0x3c56f5c*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                    /*0x3c57060*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                    /*0x3c570fc*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                    /*0x3c5719c*/ void <ProcessOnCreate>b__4_0();
                    /*0x3c571f4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__4_1();

                    class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent>
                    {
                        /*0x10*/ string LogMessage;

                        /*0x3c572a0*/ Args();
                    }

                    struct <<ProcessOnCreate>b__4_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c572d4*/ void MoveNext();
                        /*0x3c57784*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ExceptionLogWindowComponentNavigation
                {
                    static /*0x3c57790*/ Cysharp.Threading.Tasks.UniTask OpenExceptionLogWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                }

                class ExceptionLogWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x3c578ac*/ ExceptionLogWindowController();
                }
            }

            namespace DebugTextWindow
            {
                class DebugTextWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent, Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowController, Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent.Args>
                {
                    /*0x48*/ UnityEngine.UI.Button closeButton;
                    /*0x50*/ TMPro.TextMeshProUGUI textView;
                    /*0x58*/ UnityEngine.UI.Button copyButton;

                    /*0x3c57c80*/ DebugTextWindowComponent();
                    /*0x3c578b4*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent.Args args);
                    /*0x3c57ab8*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent.Args args);
                    /*0x3c57bd4*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                    /*0x3c57cc8*/ void <ProcessOnCreate>b__3_0(string text);
                    /*0x3c57cec*/ void <ProcessOnCreate>b__3_1();
                    /*0x3c57d44*/ void <ProcessOnCreate>b__3_2();

                    class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent>
                    {
                        /*0x10*/ string <Text>k__BackingField;

                        /*0x3c57f04*/ Args();
                        /*0x3c57ef4*/ string get_Text();
                        /*0x3c57efc*/ void set_Text(string value);
                    }
                }

                class DebugTextWindowComponentNavigation
                {
                    static /*0x3c55708*/ Cysharp.Threading.Tasks.UniTask OpenDebugTextWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, string text);
                }

                class DebugTextWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ Assets.Platform.IPlatform platform;
                    /*0x28*/ Assets.GameUi.Toast.IToastComponent toast;
                    /*0x30*/ UniRx.ReactiveProperty<string> <Text>k__BackingField;

                    /*0x3c57f40*/ DebugTextWindowController(Assets.Platform.IPlatform platform, Assets.GameUi.Toast.IToastComponent toast);
                    /*0x3c57f38*/ UniRx.ReactiveProperty<string> get_Text();
                    /*0x3c57b7c*/ void Refresh(string text);
                    /*0x3c57d98*/ void CopyToClipboard();
                }
            }

            namespace DebugSoundWindow
            {
                class DebugSoundWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent, Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController>
                {
                    /*0x40*/ UnityEngine.UI.Button closeButton;
                    /*0x48*/ Assets.GameUi.ScrollView.ScrollViewComponent scrollView;
                    /*0x50*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent.PlayingSound playingSound;
                    /*0x58*/ Assets.AssetManagement.ITextureAssetProvider <TextureAssetProvider>k__BackingField;
                    /*0x60*/ Assets.GameUi.Externals.IAudioManager <AudioManager>k__BackingField;

                    /*0x3c58a6c*/ DebugSoundWindowComponent();
                    /*0x3c57ff8*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                    /*0x3c58000*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                    /*0x3c58008*/ Assets.GameUi.Externals.IAudioManager get_AudioManager();
                    /*0x3c58010*/ void set_AudioManager(Assets.GameUi.Externals.IAudioManager value);
                    /*0x3c58018*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                    /*0x3c584c0*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                    /*0x3c587d4*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                    /*0x3c58864*/ Cysharp.Threading.Tasks.UniTask ApplyPlayingSound(string assetId, string name);
                    /*0x3c58948*/ void LateUpdate();
                    /*0x3c58ab4*/ void <ProcessOnCreate>b__11_0();
                    /*0x3c58b0c*/ void <ProcessOnCreate>b__11_1(Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args[] sounds);
                    /*0x3c58b78*/ void <ProcessOnCreate>b__11_2(Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel model);
                    /*0x3c58c4c*/ void <ProcessOnCreate>b__11_3(Assets.GameUi.Externals.AudioManager.BgmArgs bgmArgs);
                    /*0x3c58d20*/ void <ProcessOnCreate>b__11_4(Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args args);
                    /*0x3c591dc*/ void <ProcessOnCreate>b__11_5(bool on);
                    /*0x3c593c4*/ void <ProcessOnCreate>b__11_6();
                    /*0x3c59440*/ void <ProcessOnCreate>b__11_7();

                    class PlayingSound
                    {
                        /*0x10*/ UnityEngine.UI.RawImage <CdCoverImage>k__BackingField;
                        /*0x18*/ Assets.GameUi.Slidebar.SlidebarComponent <Slider>k__BackingField;
                        /*0x20*/ UnityEngine.UI.Button <PlayButton>k__BackingField;
                        /*0x28*/ UnityEngine.UI.Button <StopButton>k__BackingField;
                        /*0x30*/ UnityEngine.GameObject container;
                        /*0x38*/ TMPro.TextMeshProUGUI nameText;

                        /*0x3c595d8*/ PlayingSound();
                        /*0x3c594e8*/ UnityEngine.UI.RawImage get_CdCoverImage();
                        /*0x3c594f0*/ void set_CdCoverImage(UnityEngine.UI.RawImage value);
                        /*0x3c594f8*/ Assets.GameUi.Slidebar.SlidebarComponent get_Slider();
                        /*0x3c59500*/ void set_Slider(Assets.GameUi.Slidebar.SlidebarComponent value);
                        /*0x3c59508*/ UnityEngine.UI.Button get_PlayButton();
                        /*0x3c59510*/ void set_PlayButton(UnityEngine.UI.Button value);
                        /*0x3c59518*/ UnityEngine.UI.Button get_StopButton();
                        /*0x3c59520*/ void set_StopButton(UnityEngine.UI.Button value);
                        /*0x3c59528*/ void Apply(string name);
                        /*0x3c59578*/ void SwitchButton(bool activatePlay);
                    }

                    struct <<ProcessOnCreate>b__11_2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent <>4__this;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel model;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c595e0*/ void MoveNext();
                        /*0x3c59a84*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__11_3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.GameUi.Externals.AudioManager.BgmArgs bgmArgs;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c59a90*/ void MoveNext();
                        /*0x3c59f44*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplyPlayingSound>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ string assetId;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent <>4__this;
                        /*0x38*/ string name;
                        /*0x40*/ UnityEngine.UI.RawImage <>7__wrap1;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                        /*0x3c59f50*/ void MoveNext();
                        /*0x3c5a524*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugSoundWindowComponentNavigation
                {
                    static /*0x3c526e4*/ Cysharp.Threading.Tasks.UniTask OpenDebugSoundWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
                }

                class DebugSoundWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args[]> <Sounds>k__BackingField;
                    /*0x28*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel> <DisplayModel>k__BackingField;
                    /*0x30*/ UniRx.ReactiveProperty<Assets.GameUi.Externals.AudioManager.BgmArgs> <PlayBgmArgs>k__BackingField;
                    /*0x38*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                    /*0x40*/ Assets.GameUi.Service.ISoundService soundService;
                    /*0x48*/ System.Nullable<long> selectedHomeSoundTrackMasterId;

                    /*0x3c5a548*/ DebugSoundWindowController(Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Service.ISoundService soundService);
                    /*0x3c5a530*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args[]> get_Sounds();
                    /*0x3c5a538*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel> get_DisplayModel();
                    /*0x3c5a540*/ UniRx.ReactiveProperty<Assets.GameUi.Externals.AudioManager.BgmArgs> get_PlayBgmArgs();
                    /*0x3c58558*/ void Refresh();
                    /*0x3c58d88*/ void SelectHomeSound(long homeSoundTrackMasterId);
                    /*0x3c5926c*/ void PlayBgm(int samples);
                    /*0x3c59494*/ void StopBgm();
                    /*0x3c5a73c*/ string GetTimeText(System.TimeSpan timeSpan);
                    /*0x3c5a9a0*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args <Refresh>b__13_1(Assets.Api.Client.HomeSoundtrackMaster m);

                    class SoundViewModel
                    {
                        /*0x10*/ string <Name>k__BackingField;
                        /*0x18*/ Assets.GameUi.Externals.AudioManager.BgmArgs <BgmArgs>k__BackingField;

                        /*0x3c5a6b0*/ SoundViewModel();
                        /*0x3c5aae8*/ string get_Name();
                        /*0x3c5aaf0*/ void set_Name(string value);
                        /*0x3c5aaf8*/ Assets.GameUi.Externals.AudioManager.BgmArgs get_BgmArgs();
                        /*0x3c5ab00*/ void set_BgmArgs(Assets.GameUi.Externals.AudioManager.BgmArgs value);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.<> <>9;
                        static /*0x8*/ System.Func<Assets.Api.Client.HomeSoundtrackMaster, int> <>9__13_0;
                        static /*0x10*/ System.Func<Assets.Api.Client.HomeSoundtrackMaster, int> <>9__14_0;

                        static /*0x3c5ab08*/ <>c();
                        /*0x3c5ab70*/ <>c();
                        /*0x3c5ab78*/ int <Refresh>b__13_0(Assets.Api.Client.HomeSoundtrackMaster m);
                        /*0x3c5ab90*/ int <SelectHomeSound>b__14_0(Assets.Api.Client.HomeSoundtrackMaster m);
                    }

                    class <>c__DisplayClass14_0
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController <>4__this;
                        /*0x18*/ long homeSoundTrackMasterId;

                        /*0x3c5a6a8*/ <>c__DisplayClass14_0();
                        /*0x3c5aba8*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args <SelectHomeSound>b__1(Assets.Api.Client.HomeSoundtrackMaster m);
                    }
                }

                namespace Card
                {
                    class DebugSoundCardComponent : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args>
                    {
                        /*0x90*/ UnityEngine.UI.RawImage cdCoverImage;
                        /*0x98*/ TMPro.TextMeshProUGUI idText;
                        /*0xa0*/ TMPro.TextMeshProUGUI nameText;
                        /*0xa8*/ TMPro.TextMeshProUGUI trackLengthText;
                        /*0xb0*/ UnityEngine.GameObject selected;

                        /*0x3c5ae4c*/ DebugSoundCardComponent();
                        /*0x3c5acac*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args args);
                        /*0x3c5ad7c*/ Cysharp.Threading.Tasks.UniTask ApplyCdCover(string assetId);

                        class Args : Assets.GameUi.ScrollView.ScrollViewComponent.RefreshableArgs
                        {
                            /*0x18*/ string <Name>k__BackingField;
                            /*0x20*/ string <AssetId>k__BackingField;
                            /*0x28*/ string <TrackLengthText>k__BackingField;
                            /*0x30*/ bool <IsSelected>k__BackingField;

                            /*0x3c5aa7c*/ Args();
                            /*0x3c5ae94*/ string get_Name();
                            /*0x3c5ae9c*/ void set_Name(string value);
                            /*0x3c5aea4*/ string get_AssetId();
                            /*0x3c5aeac*/ void set_AssetId(string value);
                            /*0x3c5aeb4*/ string get_TrackLengthText();
                            /*0x3c5aebc*/ void set_TrackLengthText(string value);
                            /*0x3c5aec4*/ bool get_IsSelected();
                            /*0x3c5aecc*/ void set_IsSelected(bool value);
                        }

                        struct <Apply>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                            /*0x28*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent <>4__this;
                            /*0x30*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args args;
                            /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                            /*0x3c5aed8*/ void MoveNext();
                            /*0x3c5b400*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }

                        struct <ApplyCdCover>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                            /*0x28*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent <>4__this;
                            /*0x30*/ string assetId;
                            /*0x38*/ UnityEngine.UI.RawImage <>7__wrap1;
                            /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                            /*0x3c5b40c*/ void MoveNext();
                            /*0x3c5b954*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }
                }
            }

            namespace DebugAssetViewWindow
            {
                class DebugAssetViewWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args>
                {
                    /*0x48*/ UnityEngine.UI.Button closeButton;
                    /*0x50*/ TMPro.TMP_InputField keySearchInput;
                    /*0x58*/ TMPro.TMP_InputField groupSearchInput;
                    /*0x60*/ Assets.GameUi.ScrollView.ScrollViewComponent keyScrollView;
                    /*0x68*/ Assets.GameUi.ScrollView.ScrollViewComponent groupScrollView;
                    /*0x70*/ UnityEngine.Transform uiParent;
                    /*0x78*/ UnityEngine.Transform pixelatedSpineUi;
                    /*0x80*/ UnityEngine.UI.Button closePixelatedView;
                    /*0x88*/ UnityEngine.UI.Button nextPixelationAnimation;
                    /*0x90*/ UnityEngine.UI.Button nextAnimationButton;
                    /*0x98*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.UiView uiView;
                    /*0xa0*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.IllustView illustView;
                    /*0xa8*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.SpineView spineView;
                    /*0xb0*/ Assets.AssetManagement.ITextureAssetProvider <TextureAssetProvider>k__BackingField;
                    /*0xb8*/ Assets.AssetManagement.IAssetInstanceProvider <AssetProvider>k__BackingField;
                    /*0xc0*/ Assets.AssetManagement.ISpineAssetProvider <SpineAssetProvider>k__BackingField;
                    /*0xc8*/ Assets.Utilities.Spine.MecanimController activeMecanim;
                    /*0xd0*/ string activeKey;
                    /*0xd8*/ int currentAnimationIndex;
                    /*0xdc*/ int currentEmotionIndex;
                    /*0xe0*/ int currentCameraIndex;

                    static /*0x3c5dcd0*/ bool <ApplyScrollView>g__ContainsSubstring|32_1(string text, string filter);
                    /*0x3c5cb1c*/ DebugAssetViewWindowComponent();
                    /*0x3c5b960*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                    /*0x3c5b968*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                    /*0x3c5b970*/ Assets.AssetManagement.IAssetInstanceProvider get_AssetProvider();
                    /*0x3c5b978*/ void set_AssetProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                    /*0x3c5b980*/ Assets.AssetManagement.ISpineAssetProvider get_SpineAssetProvider();
                    /*0x3c5b988*/ void set_SpineAssetProvider(Assets.AssetManagement.ISpineAssetProvider value);
                    /*0x3c5b990*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args args);
                    /*0x3c5c1dc*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args args);
                    /*0x3c5c694*/ void ApplyScrollView(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] args, Assets.GameUi.ScrollView.ScrollViewComponent scrollView, string filterText);
                    /*0x3c5c7e4*/ Cysharp.Threading.Tasks.UniTask ApplyIllust(string key);
                    /*0x3c5c8b0*/ Cysharp.Threading.Tasks.UniTask ApplySpine(string key);
                    /*0x3c5c97c*/ Cysharp.Threading.Tasks.UniTask ApplyUi(string key);
                    /*0x3c5ca48*/ Cysharp.Threading.Tasks.UniTask ApplyIcon(Assets.Utilities.Illust.IllustShapeTypes illustShapeType, string assetId);
                    /*0x3c5cb94*/ void <ProcessOnCreate>b__30_0();
                    /*0x3c5cbec*/ void <ProcessOnCreate>b__30_1(UnityEngine.UI.Button _);
                    /*0x3c5ccc0*/ void <ProcessOnCreate>b__30_2(UnityEngine.UI.Button _);
                    /*0x3c5ce68*/ void <ProcessOnCreate>b__30_3(UnityEngine.UI.Button _);
                    /*0x3c5d184*/ void <ProcessOnCreate>b__30_4(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                    /*0x3c5d220*/ void <ProcessOnCreate>b__30_5(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.GroupArgs group);
                    /*0x3c5d248*/ void <ProcessOnCreate>b__30_6(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.KeyArgs key);
                    /*0x3c5d320*/ void <ProcessOnCreate>b__30_7(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs shapes);
                    /*0x3c5d3f4*/ bool <ProcessOnCreate>b__30_16(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c5d484*/ void <ProcessOnCreate>b__30_8(string key);
                    /*0x3c5d558*/ void <ProcessOnCreate>b__30_9(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs args);
                    /*0x3c5d62c*/ void <ProcessOnCreate>b__30_10(string text);
                    /*0x3c5d6cc*/ void <ProcessOnCreate>b__30_11(string text);
                    /*0x3c5d76c*/ void <ProcessOnCreate>b__30_12(string text);
                    /*0x3c5d80c*/ void <ProcessOnCreate>b__30_13(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c5daa4*/ void <ProcessOnCreate>b__30_14(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c5db9c*/ void <ProcessOnCreate>b__30_15(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);

                    class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent>
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes <AssetType>k__BackingField;

                        /*0x3c52168*/ Args();
                        /*0x3c5dd20*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes get_AssetType();
                        /*0x3c5dd28*/ void set_AssetType(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes value);
                    }

                    class UiView
                    {
                        /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                        /*0x18*/ TMPro.TextMeshProUGUI <TextureInfoText>k__BackingField;
                        /*0x20*/ UnityEngine.UI.RawImage <DisplayImage>k__BackingField;

                        /*0x3c5dd60*/ UiView();
                        /*0x3c5dd30*/ UnityEngine.GameObject get_GameObject();
                        /*0x3c5dd38*/ void set_GameObject(UnityEngine.GameObject value);
                        /*0x3c5dd40*/ TMPro.TextMeshProUGUI get_TextureInfoText();
                        /*0x3c5dd48*/ void set_TextureInfoText(TMPro.TextMeshProUGUI value);
                        /*0x3c5dd50*/ UnityEngine.UI.RawImage get_DisplayImage();
                        /*0x3c5dd58*/ void set_DisplayImage(UnityEngine.UI.RawImage value);
                    }

                    class IllustView
                    {
                        /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                        /*0x18*/ Assets.GameUi.Icon.IconBase <Icon>k__BackingField;
                        /*0x20*/ UnityEngine.Transform <IllustPoint>k__BackingField;
                        /*0x28*/ Assets.GameUi.ScrollView.ScrollViewComponent <IconTypeScrollView>k__BackingField;
                        /*0x30*/ TMPro.TMP_InputField <ShapeSearchInput>k__BackingField;

                        /*0x3c5ddb8*/ IllustView();
                        /*0x3c5dd68*/ UnityEngine.GameObject get_GameObject();
                        /*0x3c5dd70*/ void set_GameObject(UnityEngine.GameObject value);
                        /*0x3c5dd78*/ Assets.GameUi.Icon.IconBase get_Icon();
                        /*0x3c5dd80*/ void set_Icon(Assets.GameUi.Icon.IconBase value);
                        /*0x3c5dd88*/ UnityEngine.Transform get_IllustPoint();
                        /*0x3c5dd90*/ void set_IllustPoint(UnityEngine.Transform value);
                        /*0x3c5dd98*/ Assets.GameUi.ScrollView.ScrollViewComponent get_IconTypeScrollView();
                        /*0x3c5dda0*/ void set_IconTypeScrollView(Assets.GameUi.ScrollView.ScrollViewComponent value);
                        /*0x3c5dda8*/ TMPro.TMP_InputField get_ShapeSearchInput();
                        /*0x3c5ddb0*/ void set_ShapeSearchInput(TMPro.TMP_InputField value);
                    }

                    class SpineView
                    {
                        /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                        /*0x18*/ UnityEngine.Transform <BgSpinePoint>k__BackingField;
                        /*0x20*/ UnityEngine.Transform <AdvSpinePoint>k__BackingField;
                        /*0x28*/ UnityEngine.Transform <PixelatedSpineParent>k__BackingField;

                        /*0x3c5de00*/ SpineView();
                        /*0x3c5ddc0*/ UnityEngine.GameObject get_GameObject();
                        /*0x3c5ddc8*/ void set_GameObject(UnityEngine.GameObject value);
                        /*0x3c5ddd0*/ UnityEngine.Transform get_BgSpinePoint();
                        /*0x3c5ddd8*/ void set_BgSpinePoint(UnityEngine.Transform value);
                        /*0x3c5dde0*/ UnityEngine.Transform get_AdvSpinePoint();
                        /*0x3c5dde8*/ void set_AdvSpinePoint(UnityEngine.Transform value);
                        /*0x3c5ddf0*/ UnityEngine.Transform get_PixelatedSpineParent();
                        /*0x3c5ddf8*/ void set_PixelatedSpineParent(UnityEngine.Transform value);
                    }

                    struct <<ProcessOnCreate>b__30_7>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs shapes;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c5de08*/ void MoveNext();
                        /*0x3c5e23c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__30_8>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ string key;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c5e248*/ void MoveNext();
                        /*0x3c5eb68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__30_9>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs args;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c5eb74*/ void MoveNext();
                        /*0x3c5ee98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass32_0
                    {
                        /*0x10*/ string filterText;

                        /*0x3c5c7dc*/ <>c__DisplayClass32_0();
                        /*0x3c5eea4*/ bool <ApplyScrollView>b__0(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args a);
                    }

                    struct <ApplyIcon>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ string assetId;
                        /*0x30*/ Assets.Utilities.Illust.IllustShapeTypes illustShapeType;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ Assets.GameUi.Icon.IconBase.IconArgs <iconArgs>5__2;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c5eec4*/ void MoveNext();
                        /*0x3c5f720*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplyIllust>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x30*/ string key;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                        /*0x3c5f72c*/ void MoveNext();
                        /*0x3c600a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplySpine>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x30*/ string key;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                        /*0x3c600b0*/ void MoveNext();
                        /*0x3c60f98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplyUi>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x30*/ string key;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                        /*0x3c60fa4*/ void MoveNext();
                        /*0x3c616f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugAssetViewWindowComponentNavigation
                {
                    static /*0x3c52170*/ Cysharp.Threading.Tasks.UniTask OpenDebugAssetViewWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args args);
                }

                class DebugAssetViewWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes> <AssetType>k__BackingField;
                    /*0x28*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.GroupArgs> <Group>k__BackingField;
                    /*0x30*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.KeyArgs> <Key>k__BackingField;
                    /*0x38*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs> <Shapes>k__BackingField;
                    /*0x40*/ UniRx.ReactiveProperty<string> <DisplayKey>k__BackingField;
                    /*0x48*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs> <DisplayIcon>k__BackingField;
                    /*0x50*/ string[] filteredKeysCash;

                    /*0x3c61734*/ DebugAssetViewWindowController();
                    /*0x3c61704*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes> get_AssetType();
                    /*0x3c6170c*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.GroupArgs> get_Group();
                    /*0x3c61714*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.KeyArgs> get_Key();
                    /*0x3c6171c*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs> get_Shapes();
                    /*0x3c61724*/ UniRx.ReactiveProperty<string> get_DisplayKey();
                    /*0x3c6172c*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs> get_DisplayIcon();
                    /*0x3c5c2a8*/ void Refresh(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                    /*0x3c61950*/ void RefreshGroups(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                    /*0x3c5d870*/ void RefreshKeys(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c5db08*/ void RefreshDisplay(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c5dc00*/ void RefreshDisplayIcon(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c62c74*/ void RefreshShapes(string assetId);
                    /*0x3c61c3c*/ System.ValueTuple<string, string> UiGroupPathPrefixs();
                    /*0x3c6297c*/ System.ValueTuple<string, string> SpineGroupPathPrefixs();
                    /*0x3c627d8*/ System.ValueTuple<string, string> IllustGroupPathPrefixs();
                    /*0x3c62f00*/ System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> IllustSquareTuples();
                    /*0x3c630b8*/ System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> IllustVerticalTuples();

                    enum AssetTypes
                    {
                        Ui = 0,
                        Illust = 1,
                        Spine = 2,
                    }

                    class GroupArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c62b84*/ GroupArgs();
                        /*0x3c631d0*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c631d8*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class KeyArgs
                    {
                        /*0x10*/ string <GroupPathPrefix>k__BackingField;
                        /*0x18*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c62bf0*/ KeyArgs();
                        /*0x3c631e0*/ string get_GroupPathPrefix();
                        /*0x3c631e8*/ void set_GroupPathPrefix(string value);
                        /*0x3c631f0*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c631f8*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class ShapeArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c62e9c*/ ShapeArgs();
                        /*0x3c63200*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c63208*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class DisplayIconArgs
                    {
                        /*0x10*/ Assets.Utilities.Illust.IllustShapeTypes <IllustShapeType>k__BackingField;
                        /*0x18*/ string <AssetId>k__BackingField;

                        /*0x3c62e60*/ DisplayIconArgs();
                        /*0x3c63210*/ Assets.Utilities.Illust.IllustShapeTypes get_IllustShapeType();
                        /*0x3c63218*/ void set_IllustShapeType(Assets.Utilities.Illust.IllustShapeTypes value);
                        /*0x3c63220*/ string get_AssetId();
                        /*0x3c63228*/ void set_AssetId(string value);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator, System.Collections.Generic.IEnumerable<object>> <>9__20_0;
                        static /*0x10*/ System.Func<object, string> <>9__20_1;
                        static /*0x18*/ System.Func<string, bool> <>9__20_2;
                        static /*0x20*/ System.Func<string, string> <>9__20_3;
                        static /*0x28*/ System.Func<System.ValueTuple<string, string>, System.ValueTuple<string, string>> <>9__21_0;
                        static /*0x30*/ System.Func<System.ValueTuple<string, string>, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args> <>9__21_1;

                        static /*0x3c63230*/ <>c();
                        /*0x3c63298*/ <>c();
                        /*0x3c632a0*/ System.Collections.Generic.IEnumerable<object> <Refresh>b__20_0(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                        /*0x3c63340*/ string <Refresh>b__20_1(object key);
                        /*0x3c63364*/ bool <Refresh>b__20_2(string path);
                        /*0x3c633e0*/ string <Refresh>b__20_3(string path);
                        /*0x3c633e8*/ System.ValueTuple<string, string> <RefreshGroups>b__21_0(System.ValueTuple<string, string> pathPrefixs);
                        /*0x3c633f4*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshGroups>b__21_1(System.ValueTuple<string, string> pathPrefixs);
                    }

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ string pathPrefix;

                        /*0x3c62be8*/ <>c__DisplayClass22_0();
                        /*0x3c634d0*/ bool <RefreshKeys>b__0(string key);
                        /*0x3c63534*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshKeys>b__1(string key);
                    }

                    class <>c__DisplayClass25_0
                    {
                        /*0x10*/ string assetId;

                        /*0x3c62e94*/ <>c__DisplayClass25_0();
                        /*0x3c635dc*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshShapes>b__0(System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> t);
                        /*0x3c6366c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshShapes>b__1(System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> t);
                    }
                }

                class DebugButtonCell : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args>
                {
                    /*0x90*/ TMPro.TextMeshProUGUI text;

                    /*0x3c637cc*/ DebugButtonCell();
                    /*0x3c636fc*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);

                    class Args
                    {
                        /*0x10*/ string <DisplayText>k__BackingField;
                        /*0x18*/ int <IntValue>k__BackingField;
                        /*0x20*/ string <StringValue>k__BackingField;

                        /*0x3c6347c*/ Args();
                        /*0x3c63814*/ string get_DisplayText();
                        /*0x3c6381c*/ void set_DisplayText(string value);
                        /*0x3c63824*/ int get_IntValue();
                        /*0x3c6382c*/ void set_IntValue(int value);
                        /*0x3c63834*/ string get_StringValue();
                        /*0x3c6383c*/ void set_StringValue(string value);
                    }

                    struct <Apply>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell <>4__this;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c63844*/ void MoveNext();
                        /*0x3c63c88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugBattleLocationListCell : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args>
                {
                    /*0x90*/ TMPro.TextMeshProUGUI text;

                    /*0x3c63d64*/ DebugBattleLocationListCell();
                    /*0x3c63c94*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);

                    class Args
                    {
                        /*0x10*/ string <DisplayText>k__BackingField;
                        /*0x18*/ long <LongValue>k__BackingField;

                        /*0x3c63dcc*/ Args();
                        /*0x3c63dac*/ string get_DisplayText();
                        /*0x3c63db4*/ void set_DisplayText(string value);
                        /*0x3c63dbc*/ long get_LongValue();
                        /*0x3c63dc4*/ void set_LongValue(long value);
                    }

                    struct <Apply>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell <>4__this;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c63e00*/ void MoveNext();
                        /*0x3c64244*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugBattleLocationListWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowComponent, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController>
                {
                    /*0x40*/ UnityEngine.UI.Button closeButton;
                    /*0x48*/ TMPro.TMP_InputField categorySearchInput;
                    /*0x50*/ TMPro.TMP_InputField groupSearchInput;
                    /*0x58*/ TMPro.TMP_InputField keySearchInput;
                    /*0x60*/ Assets.GameUi.ScrollView.ScrollViewComponent categoryScrollView;
                    /*0x68*/ Assets.GameUi.ScrollView.ScrollViewComponent groupScrollView;
                    /*0x70*/ Assets.GameUi.ScrollView.ScrollViewComponent keyScrollView;

                    /*0x3c64b48*/ DebugBattleLocationListWindowComponent();
                    /*0x3c64250*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                    /*0x3c64728*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                    /*0x3c649f8*/ void ApplyScrollView(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] args, Assets.GameUi.ScrollView.ScrollViewComponent scrollView, string filterText);
                    /*0x3c64b90*/ void <ProcessOnCreate>b__7_0();
                    /*0x3c64be8*/ void <ProcessOnCreate>b__7_1(string text);
                    /*0x3c64c88*/ void <ProcessOnCreate>b__7_2(string text);
                    /*0x3c64d28*/ void <ProcessOnCreate>b__7_3(string text);
                    /*0x3c64dc8*/ void <ProcessOnCreate>b__7_4(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);
                    /*0x3c651d4*/ void <ProcessOnCreate>b__7_5(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);
                    /*0x3c65650*/ void <ProcessOnCreate>b__7_6(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);
                    /*0x3c65778*/ void <ProcessOnCreate>b__7_7(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs category);
                    /*0x3c657a0*/ void <ProcessOnCreate>b__7_8(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs group);
                    /*0x3c657c8*/ void <ProcessOnCreate>b__7_9(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs key);

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ string filterText;

                        /*0x3c64b40*/ <>c__DisplayClass9_0();
                        /*0x3c657f0*/ bool <ApplyScrollView>b__0(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args a);
                    }
                }

                class DebugBattleLocationListWindowComponentNavigation
                {
                    static /*0x3c65844*/ Cysharp.Threading.Tasks.UniTask OpenDebugBattleLocationListViewWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
                }

                class DebugBattleLocationListWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                    /*0x28*/ Assets.Api.Client.IApiClient apiClient;
                    /*0x30*/ Assets.UiComponentSystem.Runtime.IGameNavigator navigator;
                    /*0x38*/ Assets.GameUi.Externals.ICameraManager cameraManager;
                    /*0x40*/ Assets.GameUi.Services.IBattleDebugService battleDebugService;
                    /*0x48*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> <CategoryCellArgs>k__BackingField;
                    /*0x50*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> <GroupCellArgs>k__BackingField;
                    /*0x58*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> <KeyCellArgs>k__BackingField;

                    /*0x3c65958*/ DebugBattleLocationListWindowController(Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient, Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.GameUi.Externals.ICameraManager cameraManager, Assets.GameUi.Services.IBattleDebugService battleDebugService);
                    /*0x3c65940*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> get_CategoryCellArgs();
                    /*0x3c65948*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> get_GroupCellArgs();
                    /*0x3c65950*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> get_KeyCellArgs();
                    /*0x3c647c0*/ void Refresh();
                    /*0x3c64e30*/ void RefreshGroups(long longValue);
                    /*0x3c6523c*/ void RefreshKeys(long locationMasterId);
                    /*0x3c656c0*/ Cysharp.Threading.Tasks.UniTask StartBattle(long locationNodeId);

                    class ListCellArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] <CellArgs>k__BackingField;

                        /*0x3c65a9c*/ ListCellArgs();
                        /*0x3c65b10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] get_CellArgs();
                        /*0x3c65b18*/ void set_CellArgs(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] value);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.<> <>9;
                        static /*0x8*/ System.Func<Assets.Api.Client.LocationTypes, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args> <>9__15_0;
                        static /*0x10*/ System.Func<Assets.Api.Client.LocationMaster, long> <>9__16_1;
                        static /*0x18*/ System.Func<Assets.Api.Client.LocationMaster, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args> <>9__16_2;
                        static /*0x20*/ System.Func<Assets.Api.Client.LocationNodeMaster, bool> <>9__17_1;
                        static /*0x28*/ System.Func<Assets.Api.Client.LocationNodeMaster, long> <>9__17_2;
                        static /*0x30*/ System.Func<Assets.Api.Client.LocationNodeMaster, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args> <>9__17_3;

                        static /*0x3c65b20*/ <>c();
                        /*0x3c65b88*/ <>c();
                        /*0x3c65b90*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args <Refresh>b__15_0(Assets.Api.Client.LocationTypes type);
                        /*0x3c65c9c*/ long <RefreshGroups>b__16_1(Assets.Api.Client.LocationMaster location);
                        /*0x3c65cb4*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args <RefreshGroups>b__16_2(Assets.Api.Client.LocationMaster location);
                        /*0x3c65d9c*/ bool <RefreshKeys>b__17_1(Assets.Api.Client.LocationNodeMaster node);
                        /*0x3c65de8*/ long <RefreshKeys>b__17_2(Assets.Api.Client.LocationNodeMaster node);
                        /*0x3c65e00*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args <RefreshKeys>b__17_3(Assets.Api.Client.LocationNodeMaster node);
                    }

                    class <>c__DisplayClass16_0
                    {
                        /*0x10*/ Assets.Api.Client.LocationTypes locationType;

                        /*0x3c65b00*/ <>c__DisplayClass16_0();
                        /*0x3c65ee8*/ bool <RefreshGroups>b__0(Assets.Api.Client.LocationMaster location);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ long locationMasterId;

                        /*0x3c65b08*/ <>c__DisplayClass17_0();
                        /*0x3c65f0c*/ bool <RefreshKeys>b__0(Assets.Api.Client.LocationNodeMaster node);
                    }

                    class <>c__DisplayClass18_0
                    {
                        /*0x10*/ Assets.Api.Client.PartyTypes partyType;
                        /*0x18*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController <>4__this;
                        /*0x20*/ Assets.Api.Client.LocationMaster locationMaster;

                        /*0x3c65f30*/ <>c__DisplayClass18_0();
                        /*0x3c65f38*/ bool <StartBattle>b__1(Assets.Api.Client.Party party);
                        /*0x3c65f5c*/ Assets.Api.Client.PartyTypes <StartBattle>g__GetSimulationPartyType|0();
                        /*0x3c660f4*/ bool <StartBattle>b__2(Assets.Api.Client.SimulationMaster ms);
                    }

                    struct <StartBattle>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController <>4__this;
                        /*0x30*/ long locationNodeId;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.RealBattleResult>> <>u__1;
                        /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                        /*0x3c66120*/ void MoveNext();
                        /*0x3c66c98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugEnemyAssetViewWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowComponent, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController>
                {
                    /*0x40*/ UnityEngine.UI.Button closeButton;
                    /*0x48*/ TMPro.TMP_InputField searchInput;
                    /*0x50*/ TMPro.TMP_InputField scaleInput;
                    /*0x58*/ Assets.GameUi.ScrollView.ScrollViewComponent ScrollView;
                    /*0x60*/ UnityEngine.Transform spaineParent;
                    /*0x68*/ UnityEngine.Transform scaleChangeTarget;
                    /*0x70*/ TMPro.TextMeshProUGUI displayAssetId;
                    /*0x78*/ Assets.AssetManagement.ISpineAssetProvider <SpineAssetProvider>k__BackingField;
                    /*0x80*/ Assets.AssetManagement.SpineMecanim spineMecanim;
                    /*0x88*/ bool isDragging;
                    /*0x8c*/ UnityEngine.Vector3 dragStartPos;
                    /*0x98*/ float dragStartScale;

                    /*0x3c67d3c*/ DebugEnemyAssetViewWindowComponent();
                    /*0x3c66ca4*/ Assets.AssetManagement.ISpineAssetProvider get_SpineAssetProvider();
                    /*0x3c66cac*/ void set_SpineAssetProvider(Assets.AssetManagement.ISpineAssetProvider value);
                    /*0x3c66cb4*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                    /*0x3c6738c*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                    /*0x3c67b20*/ void ApplyScrollView(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] args, Assets.GameUi.ScrollView.ScrollViewComponent scrollView, string filterText);
                    /*0x3c67c70*/ Cysharp.Threading.Tasks.UniTask ApplySpine(string assetId);
                    /*0x3c66ffc*/ void SetScaleControlle();
                    /*0x3c67d84*/ void <ProcessOnCreate>b__15_0();
                    /*0x3c67ddc*/ void <ProcessOnCreate>b__15_1(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.GroupArgs enemy);
                    /*0x3c67e04*/ void <ProcessOnCreate>b__15_2(string text);
                    /*0x3c67ea4*/ void <ProcessOnCreate>b__15_3(string value);
                    /*0x3c67efc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__15_4(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c67fcc*/ void <SetScaleControlle>b__19_0(UnityEngine.EventSystems.BaseEventData data);
                    /*0x3c68078*/ void <SetScaleControlle>b__19_1(UnityEngine.EventSystems.BaseEventData data);
                    /*0x3c68080*/ void <SetScaleControlle>b__19_2(UnityEngine.EventSystems.BaseEventData data);

                    struct <<ProcessOnCreate>b__15_4>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowComponent <>4__this;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c681a8*/ void MoveNext();
                        /*0x3c685dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ string filterText;

                        /*0x3c67c68*/ <>c__DisplayClass17_0();
                        /*0x3c685e8*/ bool <ApplyScrollView>b__0(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args a);
                    }

                    struct <ApplySpine>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowComponent <>4__this;
                        /*0x30*/ string assetId;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> <>u__1;

                        /*0x3c6863c*/ void MoveNext();
                        /*0x3c68e18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugEnemyAssetViewWindowComponentNavigation
                {
                    static /*0x3c68e24*/ Cysharp.Threading.Tasks.UniTask OpenDebugEnemyAssetViewWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
                }

                class DebugEnemyAssetViewWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.GroupArgs> <Enemies>k__BackingField;
                    /*0x28*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                    /*0x30*/ string[] filteredKeysCash;

                    /*0x3c68f28*/ DebugEnemyAssetViewWindowController(Assets.Api.MemoryDB.IMemoryDB memoryDB);
                    /*0x3c68f20*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.GroupArgs> get_Enemies();
                    /*0x3c67424*/ void Refresh();

                    class GroupArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c68fc4*/ GroupArgs();
                        /*0x3c69028*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c69030*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.<> <>9;
                        static /*0x8*/ System.Func<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator, System.Collections.Generic.IEnumerable<object>> <>9__6_0;
                        static /*0x10*/ System.Func<object, string> <>9__6_1;
                        static /*0x18*/ System.Func<string, bool> <>9__6_2;
                        static /*0x20*/ System.Func<string, string> <>9__6_3;
                        static /*0x28*/ System.Func<Assets.Api.Client.EnemyMaster, long> <>9__6_4;
                        static /*0x30*/ System.Func<Assets.Api.Client.EnemyMaster, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args> <>9__6_5;
                        static /*0x38*/ System.Func<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args, bool> <>9__6_6;

                        static /*0x3c69038*/ <>c();
                        /*0x3c690a0*/ <>c();
                        /*0x3c690a8*/ System.Collections.Generic.IEnumerable<object> <Refresh>b__6_0(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                        /*0x3c69148*/ string <Refresh>b__6_1(object key);
                        /*0x3c6916c*/ bool <Refresh>b__6_2(string path);
                        /*0x3c691e8*/ string <Refresh>b__6_3(string path);
                        /*0x3c691f0*/ long <Refresh>b__6_4(Assets.Api.Client.EnemyMaster enemy);
                        /*0x3c69208*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <Refresh>b__6_5(Assets.Api.Client.EnemyMaster enemy);
                        /*0x3c692e8*/ bool <Refresh>b__6_6(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args a);
                    }
                }
            }
        }
    }

    namespace CustomRendererFeatures
    {
        class FullscreenGrabPassRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
        {
            /*0x20*/ Assets.CustomRendererFeatures.FullscreenGrabPass renderPass;

            /*0x3c69430*/ FullscreenGrabPassRendererFeature();
            /*0x3c69310*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            /*0x3c6936c*/ void Create();
        }

        class FullscreenGrabPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
        {
            static string ProfilerTag = "FullscreenGrabPass";
            static string TextureName = "_FullscreenGrabTexture";

            /*0x3c693d8*/ FullscreenGrabPass();
            /*0x3c69438*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

            class FullscreenGrabPassData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <GrabTexture>k__BackingField;

                /*0x3c696c0*/ FullscreenGrabPassData();
                /*0x3c6961c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_GrabTexture();
                /*0x3c69628*/ void set_GrabTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c69630*/ void Reset();
            }
        }

        class FullscreenShaderDoublePassRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
        {
            /*0x20*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings <PassSettings>k__BackingField;
            /*0x28*/ UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint;
            /*0x30*/ UnityEngine.Shader shader;
            /*0x38*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePass renderPass;
            /*0x40*/ UnityEngine.Material material;

            /*0x3c699a8*/ FullscreenShaderDoublePassRendererFeature();
            /*0x3c696c8*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings get_PassSettings();
            /*0x3c696d0*/ void set_PassSettings(Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings value);
            /*0x3c696d8*/ void Create();
            /*0x3c698d4*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            /*0x3c6994c*/ void Dispose(bool disposing);

            class Settings
            {
                /*0x10*/ float <Float_0_10>k__BackingField;
                /*0x14*/ bool <IgnoreOnZero>k__BackingField;

                /*0x3c699dc*/ Settings();
                /*0x3c699b8*/ float get_Float_0_10();
                /*0x3c699c0*/ void set_Float_0_10(float value);
                /*0x3c699c8*/ bool get_IgnoreOnZero();
                /*0x3c699d0*/ void set_IgnoreOnZero(bool value);
            }
        }

        class FullscreenShaderDoublePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
        {
            static string ProfilerTag = "FullscreenShaderDoublePass";
            static /*0x0*/ int float_0_10_valueId;
            /*0xb8*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings settings;
            /*0xc0*/ UnityEngine.Material material;
            /*0xc8*/ UnityEngine.RenderTextureDescriptor textureDescriptor;

            static /*0x3c69ee4*/ FullscreenShaderDoublePass();
            /*0x3c697e8*/ FullscreenShaderDoublePass(UnityEngine.Material material, Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings settings);
            /*0x3c699ec*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            /*0x3c69e20*/ void UpdateShaderSettings();
        }

        class MosaicRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
        {
            /*0x20*/ Assets.CustomRendererFeatures.MosaicRendererFeature.Settings passSettings;
            /*0x28*/ UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint;
            /*0x30*/ UnityEngine.Shader depthShader;
            /*0x38*/ UnityEngine.Shader colorCorrectionShader;
            /*0x40*/ UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass;

            /*0x3c6a5f0*/ MosaicRendererFeature();
            /*0x3c69f4c*/ void Create();
            /*0x3c6a424*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            /*0x3c6a53c*/ void Dispose(bool disposing);

            class Settings
            {
                /*0x10*/ RendererOverrideListener <Listener>k__BackingField;
                /*0x18*/ UnityEngine.LayerMask <LayerMask>k__BackingField;
                /*0x1c*/ int <Pixelation>k__BackingField;
                /*0x20*/ float <Threshold>k__BackingField;
                /*0x24*/ float <Softness>k__BackingField;
                /*0x28*/ string <Keyword>k__BackingField;

                /*0x3c6a660*/ Settings();
                /*0x3c6a600*/ RendererOverrideListener get_Listener();
                /*0x3c6a608*/ void set_Listener(RendererOverrideListener value);
                /*0x3c6a610*/ UnityEngine.LayerMask get_LayerMask();
                /*0x3c6a618*/ void set_LayerMask(UnityEngine.LayerMask value);
                /*0x3c6a620*/ int get_Pixelation();
                /*0x3c6a628*/ void set_Pixelation(int value);
                /*0x3c6a630*/ float get_Threshold();
                /*0x3c6a638*/ void set_Threshold(float value);
                /*0x3c6a640*/ float get_Softness();
                /*0x3c6a648*/ void set_Softness(float value);
                /*0x3c6a650*/ string get_Keyword();
                /*0x3c6a658*/ void set_Keyword(string value);
            }
        }

        class MosaicRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass, System.IDisposable
        {
            static string ProfilerTag = "MosaicShaderPass";
            /*0xb8*/ Assets.CustomRendererFeatures.MosaicRendererFeature.Settings passSettings;
            /*0xc0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTags;
            /*0xc8*/ UnityEngine.Shader depthShader;
            /*0xd0*/ UnityEngine.Shader colorCorrectionShader;
            /*0xd8*/ UnityEngine.RenderTextureDescriptor downsampleTextureDescriptor;
            /*0x110*/ UnityEngine.Material depthMaterial;
            /*0x118*/ UnityEngine.Material colorCorrectionMaterial;

            static /*0x3c6b424*/ void ExecutePass(Assets.CustomRendererFeatures.MosaicRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
            /*0x3c6a044*/ MosaicRenderPass(Assets.CustomRendererFeatures.MosaicRendererFeature.Settings passSettings, UnityEngine.Shader depthShader, UnityEngine.Shader colorCorrectionShader);
            /*0x3c6a6c0*/ void TryCreateMaterials();
            /*0x3c6a7d8*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            /*0x3c6b2c8*/ void UpdateColorCorrectionShaderSettings();
            /*0x3c6ba98*/ void Dispose();

            class PassData
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle <RendererListHandle>k__BackingField;
                /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <ColorTextureHandle>k__BackingField;
                /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <DownsampleTextureHandle>k__BackingField;
                /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <DepthTextureHandle>k__BackingField;
                /*0x50*/ Assets.Utilities.Spine.RendererOverride[] <Targets>k__BackingField;
                /*0x58*/ string <Keyword>k__BackingField;
                /*0x60*/ UnityEngine.Material <ColorCorrectionMaterial>k__BackingField;

                /*0x3c6bba0*/ PassData();
                /*0x3c6bb00*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle get_RendererListHandle();
                /*0x3c6bb10*/ void set_RendererListHandle(UnityEngine.Rendering.RenderGraphModule.RendererListHandle value);
                /*0x3c6bb1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_ColorTextureHandle();
                /*0x3c6bb2c*/ void set_ColorTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c6bb38*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_DownsampleTextureHandle();
                /*0x3c6bb48*/ void set_DownsampleTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c6bb54*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_DepthTextureHandle();
                /*0x3c6bb64*/ void set_DepthTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c6bb70*/ Assets.Utilities.Spine.RendererOverride[] get_Targets();
                /*0x3c6bb78*/ void set_Targets(Assets.Utilities.Spine.RendererOverride[] value);
                /*0x3c6bb80*/ string get_Keyword();
                /*0x3c6bb88*/ void set_Keyword(string value);
                /*0x3c6bb90*/ UnityEngine.Material get_ColorCorrectionMaterial();
                /*0x3c6bb98*/ void set_ColorCorrectionMaterial(UnityEngine.Material value);
            }

            class <>c
            {
                static /*0x0*/ Assets.CustomRendererFeatures.MosaicRenderPass.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<Assets.CustomRendererFeatures.MosaicRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__10_0;

                static /*0x3c6bc68*/ <>c();
                /*0x3c6bcd0*/ <>c();
                /*0x3c6bcd8*/ void <RecordRenderGraph>b__10_0(Assets.CustomRendererFeatures.MosaicRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
            }
        }
    }

    namespace VisualEffectData
    {
        class DummyVfxHandler : UnityEngine.MonoBehaviour
        {
            /*0x3c6bce8*/ DummyVfxHandler();
            /*0x3c6bce4*/ void VFX_EVENT_End();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 8739C04B96632954EFA389AFD1117D6F4F3F4B516828CEE6DB227D3832F182C9;
    static /*0x96d*/ <PrivateImplementationDetails> B26FD0BC57992E28B639DECCCBF7E6E265E812E715618A72564D80EAED83EFCF;

    struct __StaticArrayInitTypeSize=2413
    {
    }

    struct __StaticArrayInitTypeSize=5480
    {
    }
}
