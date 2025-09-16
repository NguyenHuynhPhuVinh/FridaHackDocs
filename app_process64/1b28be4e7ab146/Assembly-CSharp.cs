class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3c38180*/ EmbeddedAttribute();
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

                /*0x3c38188*/ NullableAttribute(byte );
                /*0x3c38210*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3c38240*/ NullableContextAttribute(byte );
            }
        }
    }
}

class MosaicRenderer : UnityEngine.MonoBehaviour
{
    /*0x20*/ Assets.Utilities.Spine.RendererOverride <RendererOverride>k__BackingField;

    /*0x3c38848*/ MosaicRenderer();
    /*0x3c38268*/ Assets.Utilities.Spine.RendererOverride get_RendererOverride();
    /*0x3c38270*/ void set_RendererOverride(Assets.Utilities.Spine.RendererOverride value);
    /*0x3c38278*/ void OnEnable();
    /*0x3c385e4*/ void OnDisable();
}

class RendererOverrideListener : UnityEngine.ScriptableObject
{
    static /*0x0*/ System.Collections.Generic.List<Assets.Utilities.Spine.RendererOverride> targets;
    static /*0x8*/ object locked;

    static /*0x3c388d8*/ RendererOverrideListener();
    static /*0x3c382d0*/ void Register(Assets.Utilities.Spine.RendererOverride rendererOverride);
    static /*0x3c3863c*/ void Unregister(Assets.Utilities.Spine.RendererOverride rendererOverride);
    /*0x3c388d0*/ RendererOverrideListener();
    /*0x3c38858*/ Assets.Utilities.Spine.RendererOverride[] GetTargets();

    class <>c
    {
        static /*0x0*/ RendererOverrideListener.<> <>9;
        static /*0x8*/ System.Func<Assets.Utilities.Spine.RendererOverride, int> <>9__2_0;

        static /*0x3c389ac*/ <>c();
        /*0x3c38a14*/ <>c();
        /*0x3c38a1c*/ int <Register>b__2_0(Assets.Utilities.Spine.RendererOverride target);
    }

    class <>c__DisplayClass3_0
    {
        /*0x10*/ Assets.Utilities.Spine.RendererOverride rendererOverride;

        /*0x3c38850*/ <>c__DisplayClass3_0();
        /*0x3c38a94*/ bool <Unregister>b__0(Assets.Utilities.Spine.RendererOverride target);
    }
}

interface ICustomDebugCommands
{
}

class CustomDebugCommands : System.IDisposable, ICustomDebugCommands
{
    /*0x3c38b04*/ CustomDebugCommands();
    /*0x3c38b00*/ void Dispose();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c38b0c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c38c00*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        /*0x3c38c1c*/ EntryPoint(Assets.IEntryProcess entryProcess, Assets.UiComponentSystem.Runtime.IGameNavigator gameNavigator, Assets.GameUi.Externals.ICameraManager cameraController, Assets.Configuration.IApplicationConfiguration configuration);
        /*0x3c38c08*/ bool Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint.get_IsEntryInitializationCompleted();
        /*0x3c38c10*/ void Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSEntryPoint.set_IsEntryInitializationCompleted(bool value);
        /*0x3c3928c*/ Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken cancellation);

        class <>c
        {
            static /*0x0*/ Assets.EntryPoint.<> <>9;
            static /*0x8*/ System.Action<string> <>9__6_0;
            static /*0x10*/ System.Action<System.Exception> <>9__6_1;

            static /*0x3c39338*/ <>c();
            /*0x3c393a0*/ <>c();
            /*0x3c393a8*/ void <.ctor>b__6_0(string message);
            /*0x3c39400*/ void <.ctor>b__6_1(System.Exception exception);
        }

        struct <StartAsync>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            /*0x28*/ Assets.EntryPoint <>4__this;
            /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

            /*0x3c39484*/ void MoveNext();
            /*0x3c39d30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    interface IEntryProcess
    {
        /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Run();
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

        /*0x3c39d3c*/ EntryProcess(Assets.GameUi.Externals.ICameraManager cameraController, Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IAssetInstanceProvider instanceProvider, Assets.GameUi.Externals.LayoutManager layoutController, Assets.AssetManagement.IDirectAssetProvider directAssetProvider, Assets.Plugins.WebGl.IJSInterop jSInterop, Assets.Platform.IPlatform platform, Assets.Api.Client.ConnectionManager.IConnectionManager connectionManager, Assets.Api.Client.IApiClientOnMemoryDB apiClient, Assets.Api.MemoryDB.IMemoryDBOnEntry memoryDB, Assets.Api.Client.Time.IAdjustedTimeOnEntry adjustedTime, Assets.Configuration.IApplicationConfiguration configuration, Assets.AssetManagement.IAddressablesKeyProvider addressablesKeyProvider, Assets.AssetManagement.IDirectKeyProvider directKeyProvider, Assets.GameUi.Externals.ILocalSettingsManager localSettings, Assets.GameUi.Service.IPurchaseService purchaseService, Assets.GameUi.Service.IRealtimeService realtimeService, ICustomDebugCommands customDebugCommands, Assets.Api.Client.IErrorHandler errorHandler);
        /*0x3c39f08*/ Cysharp.Threading.Tasks.UniTask Run();
        /*0x3c39fbc*/ void ProcessAndroidInitialization();
        /*0x3c3a25c*/ string <Run>b__21_0();
        /*0x3c3a300*/ bool <Run>b__21_1();

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

            /*0x3c3a3b8*/ void MoveNext();
            /*0x3c3bc54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class ErrorHandler : Assets.Api.Client.IErrorHandler, System.IDisposable
    {
        /*0x10*/ System.Collections.Generic.Queue<Assets.ErrorHandler.Handler> errorQueue;
        /*0x18*/ UniRx.CompositeDisposable disposables;
        /*0x20*/ Assets.UiComponentSystem.Runtime.IGameNavigator navigator;
        /*0x28*/ bool isProcessing;

        /*0x3c3bc60*/ ErrorHandler(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
        /*0x3c3bec8*/ void ThrowError(string body);
        /*0x3c3bfe0*/ void ThrowError(string body, Assets.Api.Client.IErrorHandler.ActionTypes onCloseActionType);
        /*0x3c3c0f4*/ void ThrowError(string body, System.Func<Cysharp.Threading.Tasks.UniTask> onCloseAction);
        /*0x3c3c1ec*/ Cysharp.Threading.Tasks.UniTask ProcessError(Assets.ErrorHandler.Handler handler);
        /*0x3c3c2bc*/ void Dispose();
        /*0x3c3c2d8*/ bool <.ctor>b__4_0(long _);
        /*0x3c3c338*/ void <.ctor>b__4_1(long _);

        class Handler
        {
            /*0x10*/ string <Body>k__BackingField;
            /*0x18*/ System.Nullable<Assets.Api.Client.IErrorHandler.ActionTypes> <OnCloseActionType>k__BackingField;
            /*0x20*/ System.Func<Cysharp.Threading.Tasks.UniTask> <OnCloseAction>k__BackingField;

            /*0x3c3bfac*/ Handler();
            /*0x3c3c3e8*/ string get_Body();
            /*0x3c3c3f0*/ void set_Body(string value);
            /*0x3c3c3f8*/ System.Nullable<Assets.Api.Client.IErrorHandler.ActionTypes> get_OnCloseActionType();
            /*0x3c3c400*/ void set_OnCloseActionType(System.Nullable<Assets.Api.Client.IErrorHandler.ActionTypes> value);
            /*0x3c3c408*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_OnCloseAction();
            /*0x3c3c410*/ void set_OnCloseAction(System.Func<Cysharp.Threading.Tasks.UniTask> value);
        }

        struct <<-ctor>b__4_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x38*/ Assets.ErrorHandler <>4__this;
            /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

            /*0x3c3c418*/ void MoveNext();
            /*0x3c3c774*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }

        struct <ProcessError>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
            /*0x28*/ Assets.ErrorHandler.Handler handler;
            /*0x30*/ Assets.ErrorHandler <>4__this;
            /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.GameUi.ModalWindow.TextModal.TextModalWindowController.ResultTypes> <>u__1;
            /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

            /*0x3c3c780*/ void MoveNext();
            /*0x3c3d4bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

        static /*0x3c3d4d8*/ void InstantiateLifetimeScope();
        static /*0x3c3d590*/ void InitializeGraphicsSettings();
        /*0x3c3e304*/ RootLifetimeScope();
        /*0x3c3d4c8*/ Assets.Configuration.ApplicationConfiguration get_Configuration();
        /*0x3c3d4d0*/ void set_Configuration(Assets.Configuration.ApplicationConfiguration value);
        /*0x3c3d634*/ void Configure(VContainer.IContainerBuilder builder);
        /*0x3c3e000*/ System.Type SelectPlatformType();
        /*0x3c3e1e0*/ System.Type <SelectPlatformType>g__SelectAndroidPlatform|17_0();

        class <>c
        {
            static /*0x0*/ Assets.RootLifetimeScope.<> <>9;
            static /*0x8*/ System.Func<System.Type, bool> <>9__16_0;
            static /*0x10*/ System.Func<System.Type, bool> <>9__16_1;

            static /*0x3c3e35c*/ <>c();
            /*0x3c3e3c4*/ <>c();
            /*0x3c3e3cc*/ bool <Configure>b__16_0(System.Type t);
            /*0x3c3e410*/ bool <Configure>b__16_1(System.Type t);
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

                /*0x3c3e6e4*/ DebugInputFieldWindowComponent();
                /*0x3c3e474*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args);
                /*0x3c3e568*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args);
                /*0x3c3e68c*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                /*0x3c3e72c*/ void <ProcessOnCreate>b__4_0();
                /*0x3c3e7a4*/ void <ProcessOnCreate>b__4_1();

                class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent>
                {
                    /*0x10*/ string <Caption>k__BackingField;
                    /*0x18*/ string <PlaceHolder>k__BackingField;
                    /*0x20*/ string <DefaultValue>k__BackingField;

                    /*0x3c3e854*/ Args();
                    /*0x3c3e824*/ string get_Caption();
                    /*0x3c3e82c*/ void set_Caption(string value);
                    /*0x3c3e834*/ string get_PlaceHolder();
                    /*0x3c3e83c*/ void set_PlaceHolder(string value);
                    /*0x3c3e844*/ string get_DefaultValue();
                    /*0x3c3e84c*/ void set_DefaultValue(string value);
                }

                struct <ProcessOnCreate>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args;
                    /*0x38*/ Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3c3e8c0*/ void MoveNext();
                    /*0x3c3edf4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            class DebugInputFieldComponentNavigation
            {
                static /*0x3c3ee4c*/ Cysharp.Threading.Tasks.UniTask MoveToDebugInputFieldComponent(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
            }

            class DebugInputFieldWindowController : Assets.UiComponentSystem.Runtime.Controller<string>
            {
                /*0x3c3ef08*/ DebugInputFieldWindowController();
            }

            class DebugLocalSettingsManager
            {
                static string LocalSettingsKey = "Inu_DebugLocalSetting";
                /*0x10*/ Assets.DebugTools.DebugMenu.DebugLocalSettings localSettings;

                /*0x3c3f0d8*/ DebugLocalSettingsManager();
                /*0x3c3ef50*/ void Save(Assets.DebugTools.DebugMenu.DebugLocalSettings settings);
                /*0x3c3efec*/ Assets.DebugTools.DebugMenu.DebugLocalSettings Load();
            }

            class DebugLocalSettings
            {
                /*0x10*/ bool <DisableAutoOpenManual>k__BackingField;

                /*0x3c3f0d0*/ DebugLocalSettings();
                /*0x3c3f0e0*/ bool get_DisableAutoOpenManual();
                /*0x3c3f0e8*/ void set_DisableAutoOpenManual(bool value);
            }

            class DebugManualScrollViewCard : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugManualScrollViewCard, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs>
            {
                /*0x90*/ TMPro.TextMeshProUGUI headText;
                /*0x98*/ TMPro.TextMeshProUGUI bodyText;

                /*0x3c3f194*/ DebugManualScrollViewCard();
                /*0x3c3f0f4*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs args);

                class DebugManualScrollViewCardArgs
                {
                    /*0x10*/ string <Head>k__BackingField;
                    /*0x18*/ string <Body>k__BackingField;

                    /*0x3c3f1fc*/ DebugManualScrollViewCardArgs();
                    /*0x3c3f1dc*/ string get_Head();
                    /*0x3c3f1e4*/ void set_Head(string value);
                    /*0x3c3f1ec*/ string get_Body();
                    /*0x3c3f1f4*/ void set_Body(string value);
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

                /*0x3c42df8*/ DebugMenuComponent();
                /*0x3c3f250*/ TMPro.TextMeshProUGUI get_AstcLabel();
                /*0x3c3f258*/ void set_AstcLabel(TMPro.TextMeshProUGUI value);
                /*0x3c3f260*/ Assets.GameUi.Externals.IBackgroundManager get_BackgroundController();
                /*0x3c3f268*/ void set_BackgroundController(Assets.GameUi.Externals.IBackgroundManager value);
                /*0x3c3f270*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                /*0x3c41c80*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                /*0x3c41ecc*/ void OnEnable();
                /*0x3c41f70*/ void Update();
                /*0x3c422b8*/ UnityEngine.UI.Button CreateButton(string label, UnityEngine.Transform parent, UnityEngine.UI.Button originalButton);
                /*0x3c42504*/ UnityEngine.UI.Button CreateButtonAndManual(string label, UnityEngine.Transform parent, UnityEngine.UI.Button originalButton, string manual);
                /*0x3c41be0*/ UnityEngine.UI.Button CreateGiveButton(string label, string manual);
                /*0x3c41c00*/ UnityEngine.UI.Button CreateDateButton(string label, string manual);
                /*0x3c41c60*/ UnityEngine.UI.Button CreateAssetButton(string label, string manual);
                /*0x3c41c20*/ UnityEngine.UI.Button CreateScenarioButton(string label, string manual);
                /*0x3c41c40*/ UnityEngine.UI.Button CreateBackgroundButton(string label, string manual);
                /*0x3c41bc4*/ UnityEngine.UI.Button CreateAdvancedButton(string label);
                /*0x3c42618*/ void Open();
                /*0x3c42d50*/ void Close();
                /*0x3c42da0*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();

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

                    /*0x3c42f30*/ DebugMenuGroup();
                    /*0x3c42ef0*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes get_Type();
                    /*0x3c42ef8*/ void set_Type(Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes value);
                    /*0x3c42f00*/ UnityEngine.Transform get_Panel();
                    /*0x3c42f08*/ void set_Panel(UnityEngine.Transform value);
                    /*0x3c42f10*/ UnityEngine.UI.Button get_Button();
                    /*0x3c42f18*/ void set_Button(UnityEngine.UI.Button value);
                    /*0x3c42f20*/ UnityEngine.UI.Image get_SelectedImage();
                    /*0x3c42f28*/ void set_SelectedImage(UnityEngine.UI.Image value);
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

                    /*0x3c433f0*/ UserInfoPanel();
                    /*0x3c42f38*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton get_TokenButton();
                    /*0x3c42f40*/ void set_TokenButton(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton value);
                    /*0x3c42f48*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton get_SwaggerButton();
                    /*0x3c42f50*/ void set_SwaggerButton(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton value);
                    /*0x3c42f58*/ void Apply(Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel model);

                    class UserInfoPanelButton : UnityEngine.UI.IClickable
                    {
                        /*0x10*/ TMPro.TextMeshProUGUI <Text>k__BackingField;
                        /*0x18*/ UnityEngine.UI.Button <Button>k__BackingField;
                        /*0x20*/ string <Value>k__BackingField;

                        /*0x3c43428*/ UserInfoPanelButton();
                        /*0x3c433f8*/ TMPro.TextMeshProUGUI get_Text();
                        /*0x3c43400*/ void set_Text(TMPro.TextMeshProUGUI value);
                        /*0x3c43408*/ UnityEngine.UI.Button get_Button();
                        /*0x3c43410*/ void set_Button(UnityEngine.UI.Button value);
                        /*0x3c43418*/ string get_Value();
                        /*0x3c43420*/ void set_Value(string value);
                        /*0x3c4335c*/ void Apply(string head, string value);
                    }
                }

                class InputWindow
                {
                    /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                    /*0x18*/ TMPro.TMP_InputField <Input>k__BackingField;
                    /*0x20*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent <ModalFrame>k__BackingField;
                    /*0x28*/ System.Action<string> <Action>k__BackingField;
                    /*0x30*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> <AsyncAction>k__BackingField;

                    /*0x3c434ac*/ InputWindow();
                    /*0x3c4345c*/ UnityEngine.GameObject get_GameObject();
                    /*0x3c43464*/ void set_GameObject(UnityEngine.GameObject value);
                    /*0x3c4346c*/ TMPro.TMP_InputField get_Input();
                    /*0x3c43474*/ void set_Input(TMPro.TMP_InputField value);
                    /*0x3c4347c*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent get_ModalFrame();
                    /*0x3c43484*/ void set_ModalFrame(Assets.GameUi.ModalWindow.Frame.ModalFrameComponent value);
                    /*0x3c4348c*/ System.Action<string> get_Action();
                    /*0x3c43494*/ void set_Action(System.Action<string> value);
                    /*0x3c4349c*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> get_AsyncAction();
                    /*0x3c434a4*/ void set_AsyncAction(System.Func<string, Cysharp.Threading.Tasks.UniTask> value);
                }

                class ManualWindow
                {
                    /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                    /*0x18*/ Assets.GameUi.ScrollView.ScrollViewComponent <ScrollView>k__BackingField;
                    /*0x20*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent <ModalFrame>k__BackingField;
                    /*0x28*/ Assets.GameUi.ToggleButton <CheckButton>k__BackingField;

                    /*0x3c434f4*/ ManualWindow();
                    /*0x3c434b4*/ UnityEngine.GameObject get_GameObject();
                    /*0x3c434bc*/ void set_GameObject(UnityEngine.GameObject value);
                    /*0x3c434c4*/ Assets.GameUi.ScrollView.ScrollViewComponent get_ScrollView();
                    /*0x3c434cc*/ void set_ScrollView(Assets.GameUi.ScrollView.ScrollViewComponent value);
                    /*0x3c434d4*/ Assets.GameUi.ModalWindow.Frame.ModalFrameComponent get_ModalFrame();
                    /*0x3c434dc*/ void set_ModalFrame(Assets.GameUi.ModalWindow.Frame.ModalFrameComponent value);
                    /*0x3c434e4*/ Assets.GameUi.ToggleButton get_CheckButton();
                    /*0x3c434ec*/ void set_CheckButton(Assets.GameUi.ToggleButton value);
                }

                class SpineTapArea
                {
                    /*0x10*/ Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes <Type>k__BackingField;
                    /*0x18*/ UnityEngine.GameObject <GameObject>k__BackingField;
                    /*0x20*/ UnityEngine.RectTransform rect;

                    /*0x3c436bc*/ SpineTapArea();
                    /*0x3c434fc*/ Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes get_Type();
                    /*0x3c43504*/ void set_Type(Assets.GameUi.Externals.BackgroundManager.SpineTapPositionTypes value);
                    /*0x3c4350c*/ UnityEngine.GameObject get_GameObject();
                    /*0x3c43514*/ void set_GameObject(UnityEngine.GameObject value);
                    /*0x3c4351c*/ void Apply(UnityEngine.Vector3 screenPosition, float radius);
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

                    static /*0x3c436c4*/ <>c();
                    /*0x3c4372c*/ <>c();
                    /*0x3c43734*/ Assets.DebugTools.DebugMenu.DebugManualScrollViewCard.DebugManualScrollViewCardArgs <ProcessOnCreate>b__35_77(System.ValueTuple<string, string> m, int idx);
                    /*0x3c437bc*/ void <ProcessOnCreate>b__35_16(TMPro.TMP_LinkInfo info);
                    /*0x3c43858*/ void <ProcessOnCreate>b__35_17(TMPro.TMP_LinkInfo info);
                    /*0x3c438f4*/ void <ProcessOnCreate>b__35_18(TMPro.TMP_LinkInfo info);
                    /*0x3c43990*/ void <ProcessOnCreate>b__35_23();
                    /*0x3c43994*/ void <ProcessOnCreate>b__35_29();
                }

                class <>c__DisplayClass35_0
                {
                    /*0x10*/ Assets.DebugTools.DebugMenu.DebugMenuComponent <>4__this;
                    /*0x18*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup[] menuGroups;
                    /*0x20*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> <>9__78;
                    /*0x28*/ System.Func<string, Cysharp.Threading.Tasks.UniTask> <>9__79;

                    /*0x3c41bbc*/ <>c__DisplayClass35_0();
                    /*0x3c43a10*/ void <ProcessOnCreate>b__0();
                    /*0x3c43abc*/ void <ProcessOnCreate>b__1();
                    /*0x3c43b14*/ void <ProcessOnCreate>b__2();
                    /*0x3c43b6c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__3();
                    /*0x3c43c18*/ void <ProcessOnCreate>b__4();
                    /*0x3c43cc4*/ void <ProcessOnCreate>b__5();
                    /*0x3c43d1c*/ void <ProcessOnCreate>b__6();
                    /*0x3c43d74*/ void <ProcessOnCreate>b__7();
                    /*0x3c43e20*/ void <ProcessOnCreate>b__8(bool value);
                    /*0x3c43e44*/ void <ProcessOnCreate>b__9();
                    /*0x3c43ef0*/ void <ProcessOnCreate>b__10(Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuGroup group);
                    /*0x3c43f74*/ void <ProcessOnCreate>b__11(Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes value);
                    /*0x3c44028*/ void <ProcessOnCreate>b__12(bool value);
                    /*0x3c4409c*/ void <ProcessOnCreate>b__13(bool value);
                    /*0x3c44244*/ void <ProcessOnCreate>b__14(bool value);
                    /*0x3c44304*/ void <ProcessOnCreate>b__15(Assets.GameUi.ToggleButton button);
                    /*0x3c443f8*/ void <ProcessOnCreate>b__19();
                    /*0x3c444a4*/ void <ProcessOnCreate>b__20(Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel value);
                    /*0x3c444c4*/ void <ProcessOnCreate>b__21(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton button);
                    /*0x3c4461c*/ void <ProcessOnCreate>b__22(Assets.DebugTools.DebugMenu.DebugMenuComponent.UserInfoPanel.UserInfoPanelButton button);
                    /*0x3c446cc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__24();
                    /*0x3c4477c*/ void <ProcessOnCreate>b__25();
                    /*0x3c447c8*/ void <ProcessOnCreate>b__26();
                    /*0x3c44814*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__27();
                    /*0x3c448ec*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__28();
                    /*0x3c44998*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__30();
                    /*0x3c44a44*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__31();
                    /*0x3c44b54*/ void <ProcessOnCreate>b__32();
                    /*0x3c44b80*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__33();
                    /*0x3c44c90*/ void <ProcessOnCreate>b__34();
                    /*0x3c44d8c*/ void <ProcessOnCreate>b__35();
                    /*0x3c44e88*/ void <ProcessOnCreate>b__36();
                    /*0x3c44ef4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__37();
                    /*0x3c44fa0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__38();
                    /*0x3c4504c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__39();
                    /*0x3c450f8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__40();
                    /*0x3c451a4*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__41();
                    /*0x3c45250*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__42();
                    /*0x3c452fc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__43();
                    /*0x3c453a8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__44();
                    /*0x3c45454*/ void <ProcessOnCreate>b__45();
                    /*0x3c45588*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__46();
                    /*0x3c45634*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__47();
                    /*0x3c456e0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__48();
                    /*0x3c4578c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__49();
                    /*0x3c45838*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__50();
                    /*0x3c458e4*/ void <ProcessOnCreate>b__51();
                    /*0x3c45ec0*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__52();
                    /*0x3c45f6c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__53();
                    /*0x3c46018*/ void <ProcessOnCreate>g__ThrowSuccessToChangeDate|54(System.DateTime d);
                    /*0x3c460c8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__55();
                    /*0x3c46178*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__56();
                    /*0x3c46228*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__57();
                    /*0x3c462d8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__58();
                    /*0x3c46388*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__59();
                    /*0x3c46438*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__60();
                    /*0x3c464e8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__61();
                    /*0x3c46598*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__62();
                    /*0x3c46648*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__63();
                    /*0x3c466f8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__64();
                    /*0x3c467a8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__65();
                    /*0x3c46858*/ void <ProcessOnCreate>b__66();
                    /*0x3c4698c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__78(string frameJsonArrText);
                    /*0x3c46a5c*/ void <ProcessOnCreate>b__67();
                    /*0x3c46b3c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__79(string inputText);
                    /*0x3c46c0c*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__68();
                    /*0x3c46cb8*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__69();
                    /*0x3c46d64*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__70();
                    /*0x3c46e10*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__71();
                    /*0x3c46ebc*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__72();
                    /*0x3c46f68*/ void <ProcessOnCreate>b__73();
                    /*0x3c47150*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__74();
                    /*0x3c471fc*/ void <ProcessOnCreate>b__75(UnityEngine.InputSystem.InputAction.CallbackContext context);
                    /*0x3c4721c*/ void <ProcessOnCreate>b__76(UnityEngine.InputSystem.InputAction.CallbackContext context);

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

                        /*0x3c4723c*/ void MoveNext();
                        /*0x3c4875c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__28>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c48768*/ void MoveNext();
                        /*0x3c48c78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__30>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c48c84*/ void MoveNext();
                        /*0x3c49160*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__37>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4916c*/ void MoveNext();
                        /*0x3c496d4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__38>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c496e0*/ void MoveNext();
                        /*0x3c49c3c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__39>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c49c48*/ void MoveNext();
                        /*0x3c4a1a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4a1b0*/ void MoveNext();
                        /*0x3c4a6a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__40>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4a6b0*/ void MoveNext();
                        /*0x3c4ac18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__41>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4ac24*/ void MoveNext();
                        /*0x3c4b18c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__42>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4b198*/ void MoveNext();
                        /*0x3c4b6f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__43>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4b700*/ void MoveNext();
                        /*0x3c4bc68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__44>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c4bc74*/ void MoveNext();
                        /*0x3c4c25c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__46>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4c268*/ void MoveNext();
                        /*0x3c4c7e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__47>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4c7ec*/ void MoveNext();
                        /*0x3c4cc9c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__48>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4cca8*/ void MoveNext();
                        /*0x3c4d210*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__49>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c4d21c*/ void MoveNext();
                        /*0x3c4d7cc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__50>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4d7d8*/ void MoveNext();
                        /*0x3c4dce8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__52>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4dcf4*/ void MoveNext();
                        /*0x3c4e250*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__53>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c4e25c*/ void MoveNext();
                        /*0x3c4e76c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__55>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c4e778*/ void MoveNext();
                        /*0x3c4ed4c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__56>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c4ed58*/ void MoveNext();
                        /*0x3c4f228*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__57>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c4f234*/ void MoveNext();
                        /*0x3c4f704*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__58>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c4f710*/ void MoveNext();
                        /*0x3c4fbe0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__59>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c4fbec*/ void MoveNext();
                        /*0x3c500bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__60>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c500c8*/ void MoveNext();
                        /*0x3c50598*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__61>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c505a4*/ void MoveNext();
                        /*0x3c50a78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__62>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c50a84*/ void MoveNext();
                        /*0x3c50f58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__63>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c50f64*/ void MoveNext();
                        /*0x3c51438*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__64>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c51444*/ void MoveNext();
                        /*0x3c51918*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__65>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.DateTime> <>u__1;

                        /*0x3c51924*/ void MoveNext();
                        /*0x3c51f58*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__68>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c51f64*/ void MoveNext();
                        /*0x3c52484*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__69>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c52490*/ void MoveNext();
                        /*0x3c528ec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__70>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c528f8*/ void MoveNext();
                        /*0x3c52d54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__71>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c52d60*/ void MoveNext();
                        /*0x3c53270*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__72>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c5327c*/ void MoveNext();
                        /*0x3c537c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__74>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c537d0*/ void MoveNext();
                        /*0x3c53d40*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__78>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ string frameJsonArrText;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                        /*0x3c53d4c*/ void MoveNext();
                        /*0x3c5434c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__79>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuComponent.<> <>4__this;
                        /*0x30*/ string inputText;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c54358*/ void MoveNext();
                        /*0x3c54924*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c54960*/ DebugMenuController(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.Api.Client.IApiClient apiClient, Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Platform.IPlatform platform, Assets.Configuration.IApplicationConfiguration configuration, Assets.GameUi.Externals.ILocalSettingsManager localSettings, Assets.Api.Client.Time.IAdjustedTime adjustedTime, Assets.GameUi.Service.IMazeStateService mazeStateService, Assets.GameUi.Service.Tutorial.ITutorialService tutorialService, Assets.GameUi.Toast.IToastComponent toast, Assets.GameUi.Services.IBattleDebugService battleDebugService, Assets.GameUi.IGameNotificationsMessageBroker notificationsMessageBroker, Assets.GameUi.TouchBlock.ITouchBlockComponent touchblock);
                /*0x3c54930*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugMenuController.UserInfoViewModel> get_UserInfo();
                /*0x3c54938*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugMenuComponent.DebugMenuCategoryTypes> get_Category();
                /*0x3c54940*/ UniRx.ReactiveProperty<bool> get_ShowPanel();
                /*0x3c54948*/ UniRx.ReactiveProperty<bool> get_ShowInput();
                /*0x3c54950*/ UniRx.ReactiveProperty<bool> get_ShowManual();
                /*0x3c54958*/ UniRx.ReactiveProperty<bool> get_DisableAutoOpenManual();
                /*0x3c4e6b4*/ Cysharp.Threading.Tasks.UniTask ProcessMoveBackButtonClick();
                /*0x3c41d18*/ void Refresh();
                /*0x3c426c0*/ void RefreshUserInfo();
                /*0x3c42ccc*/ void RefreshSettingsAndManual();
                /*0x3c54c54*/ void RefreshSettings();
                /*0x3c44450*/ void OpenPanel();
                /*0x3c43dcc*/ void ClosePanel();
                /*0x3c46938*/ void OpenInput();
                /*0x3c43a68*/ void CloseInput();
                /*0x3c43e9c*/ void OpenManual();
                /*0x3c43c70*/ void CloseManual();
                /*0x3c48458*/ Cysharp.Threading.Tasks.UniTask<string> OpenInputFieldWindow(Assets.DebugTools.DebugMenu.DebugInputFieldWindowComponent.Args args);
                /*0x3c523c0*/ Cysharp.Threading.Tasks.UniTask OpenDebugAssetViewWindow(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                /*0x3c531b8*/ Cysharp.Threading.Tasks.UniTask OpenDebugSoundWindow();
                /*0x3c54d28*/ Cysharp.Threading.Tasks.UniTask OpenExceptionLogWindow(Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                /*0x3c4486c*/ Cysharp.Threading.Tasks.UniTask OpenNewsWindow();
                /*0x3c44a9c*/ Cysharp.Threading.Tasks.UniTask OpenSampleModal();
                /*0x3c486b0*/ Cysharp.Threading.Tasks.UniTask MoveTo(string componentAssetKey);
                /*0x3c485a0*/ Cysharp.Threading.Tasks.UniTask MoveTo(string componentAssetKey, string componentName, object args);
                /*0x3c49618*/ Cysharp.Threading.Tasks.UniTask GiveYokubari();
                /*0x3c4a0f4*/ Cysharp.Threading.Tasks.UniTask GiveComsumableItems();
                /*0x3c4bbac*/ Cysharp.Threading.Tasks.UniTask GiveVolunteer();
                /*0x3c49b8c*/ Cysharp.Threading.Tasks.UniTask GiveCharacters();
                /*0x3c4ab5c*/ Cysharp.Threading.Tasks.UniTask GiveMemories();
                /*0x3c4b0d0*/ Cysharp.Threading.Tasks.UniTask GiveMoney();
                /*0x3c4b644*/ Cysharp.Threading.Tasks.UniTask GiveActivityLevelPoint();
                /*0x3c4d154*/ Cysharp.Threading.Tasks.UniTask GiveMaxAffection();
                /*0x3c4e1a0*/ Cysharp.Threading.Tasks.UniTask AllUnlockFunctionOpen();
                /*0x3c4c718*/ Cysharp.Threading.Tasks.UniTask SetMissionReceivable(Assets.Api.Client.MissionCategories category);
                /*0x3c4c178*/ Cysharp.Threading.Tasks.UniTask<bool> ResetAccount();
                /*0x3c4dc30*/ Cysharp.Threading.Tasks.UniTask ShowMazeState();
                /*0x3c4d6e8*/ Cysharp.Threading.Tasks.UniTask<bool> ResetMazeState();
                /*0x3c4593c*/ void ShowTutorialStatus();
                /*0x3c4ec48*/ Cysharp.Threading.Tasks.UniTask<System.DateTime> ChangeDateByAdditionalSeconds(int additionalSeconds);
                /*0x3c51df0*/ Cysharp.Threading.Tasks.UniTask<System.DateTime> ChangeDateToRealNow();
                /*0x3c454e4*/ void DeleteLocalSettings();
                /*0x3c5424c*/ Cysharp.Threading.Tasks.UniTask<bool> MoveToScenario(string frameJsonArrText);
                /*0x3c53c58*/ Cysharp.Threading.Tasks.UniTask<bool> MoveToSampleAdultScneario();
                /*0x3c44570*/ bool CopyToClipboard(string text);
                /*0x3c44378*/ void SetDisableAutoOpenManualSettings(bool disableAutoOpenManual);
                /*0x3c44bd8*/ Cysharp.Threading.Tasks.UniTask ShowPendingNotifications();
                /*0x3c44ce8*/ void TurnOnColorTouchBlock();
                /*0x3c44de4*/ void TurnOffTouchBlcok();
                /*0x3c48bc0*/ Cysharp.Threading.Tasks.UniTask Reboot();
                /*0x3c54e20*/ void <Refresh>b__36_0(UniRx.Unit _);

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

                    /*0x3c54cbc*/ UserInfoViewModel();
                    /*0x3c550c4*/ System.DateTime get_GameDate();
                    /*0x3c550cc*/ void set_GameDate(System.DateTime value);
                    /*0x3c550d4*/ string get_Version();
                    /*0x3c550dc*/ void set_Version(string value);
                    /*0x3c550e4*/ Assets.Configuration.GameEnvironment get_GameEnvironment();
                    /*0x3c550ec*/ void set_GameEnvironment(Assets.Configuration.GameEnvironment value);
                    /*0x3c550f4*/ Assets.Configuration.GamePlatforms get_GamePlatform();
                    /*0x3c550fc*/ void set_GamePlatform(Assets.Configuration.GamePlatforms value);
                    /*0x3c55104*/ Assets.Configuration.GameDevices get_GameDevice();
                    /*0x3c5510c*/ void set_GameDevice(Assets.Configuration.GameDevices value);
                    /*0x3c55114*/ Assets.Configuration.GameRatings get_GameRating();
                    /*0x3c5511c*/ void set_GameRating(Assets.Configuration.GameRatings value);
                    /*0x3c55124*/ int get_InstanceLifetime();
                    /*0x3c5512c*/ void set_InstanceLifetime(int value);
                    /*0x3c55134*/ int get_InstanceQuantityAllowance();
                    /*0x3c5513c*/ void set_InstanceQuantityAllowance(int value);
                    /*0x3c55144*/ string get_Token();
                    /*0x3c5514c*/ void set_Token(string value);
                    /*0x3c55154*/ System.Nullable<long> get_UserId();
                    /*0x3c55160*/ void set_UserId(System.Nullable<long> value);
                    /*0x3c55168*/ string get_SwaggerUrl();
                    /*0x3c55170*/ void set_SwaggerUrl(string value);
                }

                class InputVideModel
                {
                    /*0x10*/ bool <Show>k__BackingField;
                    /*0x18*/ System.Action <Action>k__BackingField;
                    /*0x20*/ System.Func<Cysharp.Threading.Tasks.UniTask> <AsyncAction>k__BackingField;

                    /*0x3c551ac*/ InputVideModel();
                    /*0x3c55178*/ bool get_Show();
                    /*0x3c55180*/ void set_Show(bool value);
                    /*0x3c5518c*/ System.Action get_Action();
                    /*0x3c55194*/ void set_Action(System.Action value);
                    /*0x3c5519c*/ System.Func<Cysharp.Threading.Tasks.UniTask> get_AsyncAction();
                    /*0x3c551a4*/ void set_AsyncAction(System.Func<Cysharp.Threading.Tasks.UniTask> value);
                }

                class <>c
                {
                    static /*0x0*/ Assets.DebugTools.DebugMenu.DebugMenuController.<> <>9;
                    static /*0x8*/ System.Func<Assets.Api.Client.MissionStageMaster, long> <>9__63_2;
                    static /*0x10*/ System.Func<string, int, Assets.Api.Client.SceneFrameMaster> <>9__71_0;

                    static /*0x3c551b4*/ <>c();
                    /*0x3c5521c*/ <>c();
                    /*0x3c55224*/ long <SetMissionReceivable>b__63_2(Assets.Api.Client.MissionStageMaster m);
                    /*0x3c5523c*/ Assets.Api.Client.SceneFrameMaster <MoveToScenario>b__71_0(string c, int idx);
                }

                class <>c__DisplayClass63_0
                {
                    /*0x10*/ Assets.Api.Client.MissionCategories category;
                    /*0x18*/ System.Func<Assets.Api.Client.MissionMaster, bool> <>9__0;

                    /*0x3c552c0*/ <>c__DisplayClass63_0();
                    /*0x3c552c8*/ bool <SetMissionReceivable>b__0(Assets.Api.Client.MissionMaster m);
                }

                class <>c__DisplayClass63_1
                {
                    /*0x10*/ Assets.Api.Client.MissionMaster missionMaster;

                    /*0x3c552ec*/ <>c__DisplayClass63_1();
                    /*0x3c552f4*/ bool <SetMissionReceivable>b__1(Assets.Api.Client.MissionStageMaster m);
                }

                struct <AllUnlockFunctionOpen>d__62 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<bool>> <>u__1;

                    /*0x3c55320*/ void MoveNext();
                    /*0x3c55814*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ChangeDateByAdditionalSeconds>d__68 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.DateTime> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ int additionalSeconds;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c55820*/ void MoveNext();
                    /*0x3c5621c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveActivityLevelPoint>d__60 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c56274*/ void MoveNext();
                    /*0x3c56764*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveCharacters>d__57 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c56770*/ void MoveNext();
                    /*0x3c56c5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveComsumableItems>d__55 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c56c68*/ void MoveNext();
                    /*0x3c57154*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveMaxAffection>d__61 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<bool>> <>u__1;

                    /*0x3c5ab54*/ void MoveNext();
                    /*0x3c5b040*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveMemories>d__58 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5b04c*/ void MoveNext();
                    /*0x3c5b538*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveMoney>d__59 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5b544*/ void MoveNext();
                    /*0x3c5ba34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveVolunteer>d__56 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5ba40*/ void MoveNext();
                    /*0x3c5bf2c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <GiveYokubari>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5bf38*/ void MoveNext();
                    /*0x3c5c424*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3c5c430*/ void MoveNext();
                    /*0x3c5ccdc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveToSampleAdultScneario>d__72 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__1;

                    /*0x3c5cce8*/ void MoveNext();
                    /*0x3c5d174*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <MoveToScenario>d__71 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ string frameJsonArrText;
                    /*0x38*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5d1cc*/ void MoveNext();
                    /*0x3c5d7dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenDebugAssetViewWindow>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5d834*/ void MoveNext();
                    /*0x3c5ddec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenDebugSoundWindow>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5ddf8*/ void MoveNext();
                    /*0x3c5e33c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <OpenSampleModal>d__51 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5e348*/ void MoveNext();
                    /*0x3c5e794*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ProcessMoveBackButtonClick>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5e7a0*/ void MoveNext();
                    /*0x3c5ec54*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <Reboot>d__78 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c5ec60*/ void MoveNext();
                    /*0x3c5f118*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ResetAccount>d__64 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5f124*/ void MoveNext();
                    /*0x3c5f674*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ResetMazeState>d__66 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5f6cc*/ void MoveNext();
                    /*0x3c5fdbc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <SetMissionReceivable>d__63 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.Api.Client.MissionCategories category;
                    /*0x30*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x38*/ System.Collections.Generic.IEnumerator<Assets.Api.Client.MissionMaster> <>7__wrap1;
                    /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.BooleanResult>> <>u__1;

                    /*0x3c5fe14*/ void MoveNext();
                    /*0x3c609b8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowMazeState>d__65 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                    /*0x3c609c4*/ void MoveNext();
                    /*0x3c613e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }

                struct <ShowPendingNotifications>d__75 : System.Runtime.CompilerServices.IAsyncStateMachine
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                    /*0x28*/ Assets.DebugTools.DebugMenu.DebugMenuController <>4__this;
                    /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.GameUi.ModalWindow.TextModal.TextModalWindowController.ResultTypes> <>u__1;

                    /*0x3c613f0*/ void MoveNext();
                    /*0x3c619f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                }
            }

            namespace ExceptionLogWindow
            {
                class ChatworkSender : UnityEngine.MonoBehaviour
                {
                    static string RoomId = "363295064";
                    static string Token = "0e3729ef5c28cf86ac757269610f9c4d";

                    /*0x3c61c88*/ ChatworkSender();
                    /*0x3c619fc*/ Cysharp.Threading.Tasks.UniTask Send(string message, UnityEngine.Transform hideTransform);
                    /*0x3c61ae4*/ string GetPlatformName();

                    struct <Send>d__2 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ UnityEngine.Transform hideTransform;
                        /*0x30*/ Assets.DebugTools.DebugMenu.ExceptionLogWindow.ChatworkSender <>4__this;
                        /*0x38*/ string message;
                        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                        /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Networking.UnityWebRequest> <>u__2;

                        /*0x3c61c90*/ void MoveNext();
                        /*0x3c62aac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ExceptionLogWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent, Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowController, Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args>
                {
                    /*0x48*/ UnityEngine.UI.Button closeButton;
                    /*0x50*/ UnityEngine.UI.Button sendReportButton;
                    /*0x58*/ TMPro.TextMeshProUGUI exceptionMessageText;
                    /*0x60*/ Assets.DebugTools.DebugMenu.ExceptionLogWindow.ChatworkSender chatworkSender;

                    /*0x3c62cb0*/ ExceptionLogWindowComponent();
                    /*0x3c62ab8*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                    /*0x3c62bbc*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                    /*0x3c62c58*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                    /*0x3c62cf8*/ void <ProcessOnCreate>b__4_0();
                    /*0x3c62d50*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__4_1();

                    class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent>
                    {
                        /*0x10*/ string LogMessage;

                        /*0x3c62dfc*/ Args();
                    }

                    struct <<ProcessOnCreate>b__4_1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent <>4__this;
                        /*0x30*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c62e30*/ void MoveNext();
                        /*0x3c632e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class ExceptionLogWindowComponentNavigation
                {
                    static /*0x3c632ec*/ Cysharp.Threading.Tasks.UniTask OpenExceptionLogWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.DebugTools.DebugMenu.ExceptionLogWindow.ExceptionLogWindowComponent.Args args);
                }

                class ExceptionLogWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x3c63408*/ ExceptionLogWindowController();
                }
            }

            namespace DebugTextWindow
            {
                class DebugTextWindowComponent : UnityEngine.MonoBehaviour<Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent, Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowController, Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent.Args>
                {
                    /*0x48*/ UnityEngine.UI.Button closeButton;
                    /*0x50*/ TMPro.TextMeshProUGUI textView;
                    /*0x58*/ UnityEngine.UI.Button copyButton;

                    /*0x3c637dc*/ DebugTextWindowComponent();
                    /*0x3c63410*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent.Args args);
                    /*0x3c63614*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent.Args args);
                    /*0x3c63730*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                    /*0x3c63824*/ void <ProcessOnCreate>b__3_0(string text);
                    /*0x3c63848*/ void <ProcessOnCreate>b__3_1();
                    /*0x3c638a0*/ void <ProcessOnCreate>b__3_2();

                    class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.DebugTextWindow.DebugTextWindowComponent>
                    {
                        /*0x10*/ string <Text>k__BackingField;

                        /*0x3c63a60*/ Args();
                        /*0x3c63a50*/ string get_Text();
                        /*0x3c63a58*/ void set_Text(string value);
                    }
                }

                class DebugTextWindowComponentNavigation
                {
                    static /*0x3c61264*/ Cysharp.Threading.Tasks.UniTask OpenDebugTextWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, string text);
                }

                class DebugTextWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ Assets.Platform.IPlatform platform;
                    /*0x28*/ Assets.GameUi.Toast.IToastComponent toast;
                    /*0x30*/ UniRx.ReactiveProperty<string> <Text>k__BackingField;

                    /*0x3c63a9c*/ DebugTextWindowController(Assets.Platform.IPlatform platform, Assets.GameUi.Toast.IToastComponent toast);
                    /*0x3c63a94*/ UniRx.ReactiveProperty<string> get_Text();
                    /*0x3c636d8*/ void Refresh(string text);
                    /*0x3c638f4*/ void CopyToClipboard();
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

                    /*0x3c645c8*/ DebugSoundWindowComponent();
                    /*0x3c63b54*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                    /*0x3c63b5c*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                    /*0x3c63b64*/ Assets.GameUi.Externals.IAudioManager get_AudioManager();
                    /*0x3c63b6c*/ void set_AudioManager(Assets.GameUi.Externals.IAudioManager value);
                    /*0x3c63b74*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                    /*0x3c6401c*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                    /*0x3c64330*/ Cysharp.Threading.Tasks.UniTask ProcessOnSuspend();
                    /*0x3c643c0*/ Cysharp.Threading.Tasks.UniTask ApplyPlayingSound(string assetId, string name);
                    /*0x3c644a4*/ void LateUpdate();
                    /*0x3c64610*/ void <ProcessOnCreate>b__11_0();
                    /*0x3c64668*/ void <ProcessOnCreate>b__11_1(Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args[] sounds);
                    /*0x3c646d4*/ void <ProcessOnCreate>b__11_2(Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel model);
                    /*0x3c647a8*/ void <ProcessOnCreate>b__11_3(Assets.GameUi.Externals.AudioManager.BgmArgs bgmArgs);
                    /*0x3c6487c*/ void <ProcessOnCreate>b__11_4(Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args args);
                    /*0x3c64d38*/ void <ProcessOnCreate>b__11_5(bool on);
                    /*0x3c64f20*/ void <ProcessOnCreate>b__11_6();
                    /*0x3c64f9c*/ void <ProcessOnCreate>b__11_7();

                    class PlayingSound
                    {
                        /*0x10*/ UnityEngine.UI.RawImage <CdCoverImage>k__BackingField;
                        /*0x18*/ Assets.GameUi.Slidebar.SlidebarComponent <Slider>k__BackingField;
                        /*0x20*/ UnityEngine.UI.Button <PlayButton>k__BackingField;
                        /*0x28*/ UnityEngine.UI.Button <StopButton>k__BackingField;
                        /*0x30*/ UnityEngine.GameObject container;
                        /*0x38*/ TMPro.TextMeshProUGUI nameText;

                        /*0x3c65134*/ PlayingSound();
                        /*0x3c65044*/ UnityEngine.UI.RawImage get_CdCoverImage();
                        /*0x3c6504c*/ void set_CdCoverImage(UnityEngine.UI.RawImage value);
                        /*0x3c65054*/ Assets.GameUi.Slidebar.SlidebarComponent get_Slider();
                        /*0x3c6505c*/ void set_Slider(Assets.GameUi.Slidebar.SlidebarComponent value);
                        /*0x3c65064*/ UnityEngine.UI.Button get_PlayButton();
                        /*0x3c6506c*/ void set_PlayButton(UnityEngine.UI.Button value);
                        /*0x3c65074*/ UnityEngine.UI.Button get_StopButton();
                        /*0x3c6507c*/ void set_StopButton(UnityEngine.UI.Button value);
                        /*0x3c65084*/ void Apply(string name);
                        /*0x3c650d4*/ void SwitchButton(bool activatePlay);
                    }

                    struct <<ProcessOnCreate>b__11_2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent <>4__this;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel model;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c6513c*/ void MoveNext();
                        /*0x3c655e0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__11_3>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.GameUi.Externals.AudioManager.BgmArgs bgmArgs;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowComponent <>4__this;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c655ec*/ void MoveNext();
                        /*0x3c65aa0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                        /*0x3c65aac*/ void MoveNext();
                        /*0x3c66080*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugSoundWindowComponentNavigation
                {
                    static /*0x3c5e240*/ Cysharp.Threading.Tasks.UniTask OpenDebugSoundWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
                }

                class DebugSoundWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args[]> <Sounds>k__BackingField;
                    /*0x28*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel> <DisplayModel>k__BackingField;
                    /*0x30*/ UniRx.ReactiveProperty<Assets.GameUi.Externals.AudioManager.BgmArgs> <PlayBgmArgs>k__BackingField;
                    /*0x38*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                    /*0x40*/ Assets.GameUi.Service.ISoundService soundService;
                    /*0x48*/ System.Nullable<long> selectedHomeSoundTrackMasterId;

                    /*0x3c660a4*/ DebugSoundWindowController(Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.GameUi.Service.ISoundService soundService);
                    /*0x3c6608c*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args[]> get_Sounds();
                    /*0x3c66094*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.SoundViewModel> get_DisplayModel();
                    /*0x3c6609c*/ UniRx.ReactiveProperty<Assets.GameUi.Externals.AudioManager.BgmArgs> get_PlayBgmArgs();
                    /*0x3c640b4*/ void Refresh();
                    /*0x3c648e4*/ void SelectHomeSound(long homeSoundTrackMasterId);
                    /*0x3c64dc8*/ void PlayBgm(int samples);
                    /*0x3c64ff0*/ void StopBgm();
                    /*0x3c66298*/ string GetTimeText(System.TimeSpan timeSpan);
                    /*0x3c664fc*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args <Refresh>b__13_1(Assets.Api.Client.HomeSoundtrackMaster m);

                    class SoundViewModel
                    {
                        /*0x10*/ string <Name>k__BackingField;
                        /*0x18*/ Assets.GameUi.Externals.AudioManager.BgmArgs <BgmArgs>k__BackingField;

                        /*0x3c6620c*/ SoundViewModel();
                        /*0x3c66644*/ string get_Name();
                        /*0x3c6664c*/ void set_Name(string value);
                        /*0x3c66654*/ Assets.GameUi.Externals.AudioManager.BgmArgs get_BgmArgs();
                        /*0x3c6665c*/ void set_BgmArgs(Assets.GameUi.Externals.AudioManager.BgmArgs value);
                    }

                    class <>c
                    {
                        static /*0x0*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController.<> <>9;
                        static /*0x8*/ System.Func<Assets.Api.Client.HomeSoundtrackMaster, int> <>9__13_0;
                        static /*0x10*/ System.Func<Assets.Api.Client.HomeSoundtrackMaster, int> <>9__14_0;

                        static /*0x3c66664*/ <>c();
                        /*0x3c666cc*/ <>c();
                        /*0x3c666d4*/ int <Refresh>b__13_0(Assets.Api.Client.HomeSoundtrackMaster m);
                        /*0x3c666ec*/ int <SelectHomeSound>b__14_0(Assets.Api.Client.HomeSoundtrackMaster m);
                    }

                    class <>c__DisplayClass14_0
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.DebugSoundWindowController <>4__this;
                        /*0x18*/ long homeSoundTrackMasterId;

                        /*0x3c66204*/ <>c__DisplayClass14_0();
                        /*0x3c66704*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args <SelectHomeSound>b__1(Assets.Api.Client.HomeSoundtrackMaster m);
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

                        /*0x3c669a8*/ DebugSoundCardComponent();
                        /*0x3c66808*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args args);
                        /*0x3c668d8*/ Cysharp.Threading.Tasks.UniTask ApplyCdCover(string assetId);

                        class Args : Assets.GameUi.ScrollView.ScrollViewComponent.RefreshableArgs
                        {
                            /*0x18*/ string <Name>k__BackingField;
                            /*0x20*/ string <AssetId>k__BackingField;
                            /*0x28*/ string <TrackLengthText>k__BackingField;
                            /*0x30*/ bool <IsSelected>k__BackingField;

                            /*0x3c665d8*/ Args();
                            /*0x3c669f0*/ string get_Name();
                            /*0x3c669f8*/ void set_Name(string value);
                            /*0x3c66a00*/ string get_AssetId();
                            /*0x3c66a08*/ void set_AssetId(string value);
                            /*0x3c66a10*/ string get_TrackLengthText();
                            /*0x3c66a18*/ void set_TrackLengthText(string value);
                            /*0x3c66a20*/ bool get_IsSelected();
                            /*0x3c66a28*/ void set_IsSelected(bool value);
                        }

                        struct <Apply>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                            /*0x28*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent <>4__this;
                            /*0x30*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent.Args args;
                            /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                            /*0x3c66a34*/ void MoveNext();
                            /*0x3c66f5c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }

                        struct <ApplyCdCover>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                            /*0x28*/ Assets.DebugTools.DebugMenu.DebugSoundWindow.Card.DebugSoundCardComponent <>4__this;
                            /*0x30*/ string assetId;
                            /*0x38*/ UnityEngine.UI.RawImage <>7__wrap1;
                            /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                            /*0x3c66f68*/ void MoveNext();
                            /*0x3c674b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    static /*0x3c6982c*/ bool <ApplyScrollView>g__ContainsSubstring|32_1(string text, string filter);
                    /*0x3c68678*/ DebugAssetViewWindowComponent();
                    /*0x3c674bc*/ Assets.AssetManagement.ITextureAssetProvider get_TextureAssetProvider();
                    /*0x3c674c4*/ void set_TextureAssetProvider(Assets.AssetManagement.ITextureAssetProvider value);
                    /*0x3c674cc*/ Assets.AssetManagement.IAssetInstanceProvider get_AssetProvider();
                    /*0x3c674d4*/ void set_AssetProvider(Assets.AssetManagement.IAssetInstanceProvider value);
                    /*0x3c674dc*/ Assets.AssetManagement.ISpineAssetProvider get_SpineAssetProvider();
                    /*0x3c674e4*/ void set_SpineAssetProvider(Assets.AssetManagement.ISpineAssetProvider value);
                    /*0x3c674ec*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args args);
                    /*0x3c67d38*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args args);
                    /*0x3c681f0*/ void ApplyScrollView(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] args, Assets.GameUi.ScrollView.ScrollViewComponent scrollView, string filterText);
                    /*0x3c68340*/ Cysharp.Threading.Tasks.UniTask ApplyIllust(string key);
                    /*0x3c6840c*/ Cysharp.Threading.Tasks.UniTask ApplySpine(string key);
                    /*0x3c684d8*/ Cysharp.Threading.Tasks.UniTask ApplyUi(string key);
                    /*0x3c685a4*/ Cysharp.Threading.Tasks.UniTask ApplyIcon(Assets.Utilities.Illust.IllustShapeTypes illustShapeType, string assetId);
                    /*0x3c686f0*/ void <ProcessOnCreate>b__30_0();
                    /*0x3c68748*/ void <ProcessOnCreate>b__30_1(UnityEngine.UI.Button _);
                    /*0x3c6881c*/ void <ProcessOnCreate>b__30_2(UnityEngine.UI.Button _);
                    /*0x3c689c4*/ void <ProcessOnCreate>b__30_3(UnityEngine.UI.Button _);
                    /*0x3c68ce0*/ void <ProcessOnCreate>b__30_4(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                    /*0x3c68d7c*/ void <ProcessOnCreate>b__30_5(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.GroupArgs group);
                    /*0x3c68da4*/ void <ProcessOnCreate>b__30_6(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.KeyArgs key);
                    /*0x3c68e7c*/ void <ProcessOnCreate>b__30_7(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs shapes);
                    /*0x3c68f50*/ bool <ProcessOnCreate>b__30_16(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c68fe0*/ void <ProcessOnCreate>b__30_8(string key);
                    /*0x3c690b4*/ void <ProcessOnCreate>b__30_9(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs args);
                    /*0x3c69188*/ void <ProcessOnCreate>b__30_10(string text);
                    /*0x3c69228*/ void <ProcessOnCreate>b__30_11(string text);
                    /*0x3c692c8*/ void <ProcessOnCreate>b__30_12(string text);
                    /*0x3c69368*/ void <ProcessOnCreate>b__30_13(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c69600*/ void <ProcessOnCreate>b__30_14(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c696f8*/ void <ProcessOnCreate>b__30_15(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);

                    class Args : Assets.UiComponentSystem.Runtime.IArgsOf<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent>
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes <AssetType>k__BackingField;

                        /*0x3c5dcc4*/ Args();
                        /*0x3c6987c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes get_AssetType();
                        /*0x3c69884*/ void set_AssetType(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes value);
                    }

                    class UiView
                    {
                        /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                        /*0x18*/ TMPro.TextMeshProUGUI <TextureInfoText>k__BackingField;
                        /*0x20*/ UnityEngine.UI.RawImage <DisplayImage>k__BackingField;

                        /*0x3c698bc*/ UiView();
                        /*0x3c6988c*/ UnityEngine.GameObject get_GameObject();
                        /*0x3c69894*/ void set_GameObject(UnityEngine.GameObject value);
                        /*0x3c6989c*/ TMPro.TextMeshProUGUI get_TextureInfoText();
                        /*0x3c698a4*/ void set_TextureInfoText(TMPro.TextMeshProUGUI value);
                        /*0x3c698ac*/ UnityEngine.UI.RawImage get_DisplayImage();
                        /*0x3c698b4*/ void set_DisplayImage(UnityEngine.UI.RawImage value);
                    }

                    class IllustView
                    {
                        /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                        /*0x18*/ Assets.GameUi.Icon.IconBase <Icon>k__BackingField;
                        /*0x20*/ UnityEngine.Transform <IllustPoint>k__BackingField;
                        /*0x28*/ Assets.GameUi.ScrollView.ScrollViewComponent <IconTypeScrollView>k__BackingField;
                        /*0x30*/ TMPro.TMP_InputField <ShapeSearchInput>k__BackingField;

                        /*0x3c69914*/ IllustView();
                        /*0x3c698c4*/ UnityEngine.GameObject get_GameObject();
                        /*0x3c698cc*/ void set_GameObject(UnityEngine.GameObject value);
                        /*0x3c698d4*/ Assets.GameUi.Icon.IconBase get_Icon();
                        /*0x3c698dc*/ void set_Icon(Assets.GameUi.Icon.IconBase value);
                        /*0x3c698e4*/ UnityEngine.Transform get_IllustPoint();
                        /*0x3c698ec*/ void set_IllustPoint(UnityEngine.Transform value);
                        /*0x3c698f4*/ Assets.GameUi.ScrollView.ScrollViewComponent get_IconTypeScrollView();
                        /*0x3c698fc*/ void set_IconTypeScrollView(Assets.GameUi.ScrollView.ScrollViewComponent value);
                        /*0x3c69904*/ TMPro.TMP_InputField get_ShapeSearchInput();
                        /*0x3c6990c*/ void set_ShapeSearchInput(TMPro.TMP_InputField value);
                    }

                    class SpineView
                    {
                        /*0x10*/ UnityEngine.GameObject <GameObject>k__BackingField;
                        /*0x18*/ UnityEngine.Transform <BgSpinePoint>k__BackingField;
                        /*0x20*/ UnityEngine.Transform <AdvSpinePoint>k__BackingField;
                        /*0x28*/ UnityEngine.Transform <PixelatedSpineParent>k__BackingField;

                        /*0x3c6995c*/ SpineView();
                        /*0x3c6991c*/ UnityEngine.GameObject get_GameObject();
                        /*0x3c69924*/ void set_GameObject(UnityEngine.GameObject value);
                        /*0x3c6992c*/ UnityEngine.Transform get_BgSpinePoint();
                        /*0x3c69934*/ void set_BgSpinePoint(UnityEngine.Transform value);
                        /*0x3c6993c*/ UnityEngine.Transform get_AdvSpinePoint();
                        /*0x3c69944*/ void set_AdvSpinePoint(UnityEngine.Transform value);
                        /*0x3c6994c*/ UnityEngine.Transform get_PixelatedSpineParent();
                        /*0x3c69954*/ void set_PixelatedSpineParent(UnityEngine.Transform value);
                    }

                    struct <<ProcessOnCreate>b__30_7>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs shapes;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c69964*/ void MoveNext();
                        /*0x3c69d98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__30_8>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ string key;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c69da4*/ void MoveNext();
                        /*0x3c6a6c4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <<ProcessOnCreate>b__30_9>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x40*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs args;
                        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c6a6d0*/ void MoveNext();
                        /*0x3c6a9f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass32_0
                    {
                        /*0x10*/ string filterText;

                        /*0x3c68338*/ <>c__DisplayClass32_0();
                        /*0x3c6aa00*/ bool <ApplyScrollView>b__0(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args a);
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

                        /*0x3c6aa20*/ void MoveNext();
                        /*0x3c6b27c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplyIllust>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x30*/ string key;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                        /*0x3c6b288*/ void MoveNext();
                        /*0x3c6bc00*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplySpine>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x30*/ string key;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                        /*0x3c6bc0c*/ void MoveNext();
                        /*0x3c6caf4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <ApplyUi>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent <>4__this;
                        /*0x30*/ string key;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                        /*0x3c6cb00*/ void MoveNext();
                        /*0x3c6d254*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugAssetViewWindowComponentNavigation
                {
                    static /*0x3c5dccc*/ Cysharp.Threading.Tasks.UniTask OpenDebugAssetViewWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowComponent.Args args);
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

                    /*0x3c6d290*/ DebugAssetViewWindowController();
                    /*0x3c6d260*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes> get_AssetType();
                    /*0x3c6d268*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.GroupArgs> get_Group();
                    /*0x3c6d270*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.KeyArgs> get_Key();
                    /*0x3c6d278*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.ShapeArgs> get_Shapes();
                    /*0x3c6d280*/ UniRx.ReactiveProperty<string> get_DisplayKey();
                    /*0x3c6d288*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.DisplayIconArgs> get_DisplayIcon();
                    /*0x3c67e04*/ void Refresh(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                    /*0x3c6d4ac*/ void RefreshGroups(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugAssetViewWindowController.AssetTypes assetType);
                    /*0x3c693cc*/ void RefreshKeys(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c69664*/ void RefreshDisplay(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c6975c*/ void RefreshDisplayIcon(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c6e7d0*/ void RefreshShapes(string assetId);
                    /*0x3c6d798*/ System.ValueTuple<string, string> UiGroupPathPrefixs();
                    /*0x3c6e4d8*/ System.ValueTuple<string, string> SpineGroupPathPrefixs();
                    /*0x3c6e334*/ System.ValueTuple<string, string> IllustGroupPathPrefixs();
                    /*0x3c6ea5c*/ System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> IllustSquareTuples();
                    /*0x3c6ec14*/ System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> IllustVerticalTuples();

                    enum AssetTypes
                    {
                        Ui = 0,
                        Illust = 1,
                        Spine = 2,
                    }

                    class GroupArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c6e6e0*/ GroupArgs();
                        /*0x3c6ed2c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c6ed34*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class KeyArgs
                    {
                        /*0x10*/ string <GroupPathPrefix>k__BackingField;
                        /*0x18*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c6e74c*/ KeyArgs();
                        /*0x3c6ed3c*/ string get_GroupPathPrefix();
                        /*0x3c6ed44*/ void set_GroupPathPrefix(string value);
                        /*0x3c6ed4c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c6ed54*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class ShapeArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c6e9f8*/ ShapeArgs();
                        /*0x3c6ed5c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c6ed64*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
                    }

                    class DisplayIconArgs
                    {
                        /*0x10*/ Assets.Utilities.Illust.IllustShapeTypes <IllustShapeType>k__BackingField;
                        /*0x18*/ string <AssetId>k__BackingField;

                        /*0x3c6e9bc*/ DisplayIconArgs();
                        /*0x3c6ed6c*/ Assets.Utilities.Illust.IllustShapeTypes get_IllustShapeType();
                        /*0x3c6ed74*/ void set_IllustShapeType(Assets.Utilities.Illust.IllustShapeTypes value);
                        /*0x3c6ed7c*/ string get_AssetId();
                        /*0x3c6ed84*/ void set_AssetId(string value);
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

                        static /*0x3c6ed8c*/ <>c();
                        /*0x3c6edf4*/ <>c();
                        /*0x3c6edfc*/ System.Collections.Generic.IEnumerable<object> <Refresh>b__20_0(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                        /*0x3c6ee9c*/ string <Refresh>b__20_1(object key);
                        /*0x3c6eec0*/ bool <Refresh>b__20_2(string path);
                        /*0x3c6ef3c*/ string <Refresh>b__20_3(string path);
                        /*0x3c6ef44*/ System.ValueTuple<string, string> <RefreshGroups>b__21_0(System.ValueTuple<string, string> pathPrefixs);
                        /*0x3c6ef50*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshGroups>b__21_1(System.ValueTuple<string, string> pathPrefixs);
                    }

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ string pathPrefix;

                        /*0x3c6e744*/ <>c__DisplayClass22_0();
                        /*0x3c6f02c*/ bool <RefreshKeys>b__0(string key);
                        /*0x3c6f090*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshKeys>b__1(string key);
                    }

                    class <>c__DisplayClass25_0
                    {
                        /*0x10*/ string assetId;

                        /*0x3c6e9f0*/ <>c__DisplayClass25_0();
                        /*0x3c6f138*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshShapes>b__0(System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> t);
                        /*0x3c6f1c8*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <RefreshShapes>b__1(System.ValueTuple<string, Assets.Utilities.Illust.IllustShapeTypes> t);
                    }
                }

                class DebugButtonCell : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args>
                {
                    /*0x90*/ TMPro.TextMeshProUGUI text;

                    /*0x3c6f328*/ DebugButtonCell();
                    /*0x3c6f258*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);

                    class Args
                    {
                        /*0x10*/ string <DisplayText>k__BackingField;
                        /*0x18*/ int <IntValue>k__BackingField;
                        /*0x20*/ string <StringValue>k__BackingField;

                        /*0x3c6efd8*/ Args();
                        /*0x3c6f370*/ string get_DisplayText();
                        /*0x3c6f378*/ void set_DisplayText(string value);
                        /*0x3c6f380*/ int get_IntValue();
                        /*0x3c6f388*/ void set_IntValue(int value);
                        /*0x3c6f390*/ string get_StringValue();
                        /*0x3c6f398*/ void set_StringValue(string value);
                    }

                    struct <Apply>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell <>4__this;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c6f3a0*/ void MoveNext();
                        /*0x3c6f7e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugBattleLocationListCell : Assets.GameUi.ScrollView.ScrollViewCardComponent<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell, Assets.GameUi.ScrollView.ScrollViewCardController, Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args>
                {
                    /*0x90*/ TMPro.TextMeshProUGUI text;

                    /*0x3c6f8c0*/ DebugBattleLocationListCell();
                    /*0x3c6f7f0*/ Cysharp.Threading.Tasks.UniTask Apply(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);

                    class Args
                    {
                        /*0x10*/ string <DisplayText>k__BackingField;
                        /*0x18*/ long <LongValue>k__BackingField;

                        /*0x3c6f928*/ Args();
                        /*0x3c6f908*/ string get_DisplayText();
                        /*0x3c6f910*/ void set_DisplayText(string value);
                        /*0x3c6f918*/ long get_LongValue();
                        /*0x3c6f920*/ void set_LongValue(long value);
                    }

                    struct <Apply>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell <>4__this;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c6f95c*/ void MoveNext();
                        /*0x3c6fda0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3c706a4*/ DebugBattleLocationListWindowComponent();
                    /*0x3c6fdac*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                    /*0x3c70284*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                    /*0x3c70554*/ void ApplyScrollView(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] args, Assets.GameUi.ScrollView.ScrollViewComponent scrollView, string filterText);
                    /*0x3c706ec*/ void <ProcessOnCreate>b__7_0();
                    /*0x3c70744*/ void <ProcessOnCreate>b__7_1(string text);
                    /*0x3c707e4*/ void <ProcessOnCreate>b__7_2(string text);
                    /*0x3c70884*/ void <ProcessOnCreate>b__7_3(string text);
                    /*0x3c70924*/ void <ProcessOnCreate>b__7_4(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);
                    /*0x3c70d30*/ void <ProcessOnCreate>b__7_5(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);
                    /*0x3c711ac*/ void <ProcessOnCreate>b__7_6(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args args);
                    /*0x3c712d4*/ void <ProcessOnCreate>b__7_7(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs category);
                    /*0x3c712fc*/ void <ProcessOnCreate>b__7_8(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs group);
                    /*0x3c71324*/ void <ProcessOnCreate>b__7_9(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs key);

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ string filterText;

                        /*0x3c7069c*/ <>c__DisplayClass9_0();
                        /*0x3c7134c*/ bool <ApplyScrollView>b__0(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args a);
                    }
                }

                class DebugBattleLocationListWindowComponentNavigation
                {
                    static /*0x3c713a0*/ Cysharp.Threading.Tasks.UniTask OpenDebugBattleLocationListViewWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
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

                    /*0x3c714b4*/ DebugBattleLocationListWindowController(Assets.Api.MemoryDB.IMemoryDB memoryDB, Assets.Api.Client.IApiClient apiClient, Assets.UiComponentSystem.Runtime.IGameNavigator navigator, Assets.GameUi.Externals.ICameraManager cameraManager, Assets.GameUi.Services.IBattleDebugService battleDebugService);
                    /*0x3c7149c*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> get_CategoryCellArgs();
                    /*0x3c714a4*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> get_GroupCellArgs();
                    /*0x3c714ac*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController.ListCellArgs> get_KeyCellArgs();
                    /*0x3c7031c*/ void Refresh();
                    /*0x3c7098c*/ void RefreshGroups(long longValue);
                    /*0x3c70d98*/ void RefreshKeys(long locationMasterId);
                    /*0x3c7121c*/ Cysharp.Threading.Tasks.UniTask StartBattle(long locationNodeId);

                    class ListCellArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] <CellArgs>k__BackingField;

                        /*0x3c715f8*/ ListCellArgs();
                        /*0x3c7166c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] get_CellArgs();
                        /*0x3c71674*/ void set_CellArgs(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args[] value);
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

                        static /*0x3c7167c*/ <>c();
                        /*0x3c716e4*/ <>c();
                        /*0x3c716ec*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args <Refresh>b__15_0(Assets.Api.Client.LocationTypes type);
                        /*0x3c717f8*/ long <RefreshGroups>b__16_1(Assets.Api.Client.LocationMaster location);
                        /*0x3c71810*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args <RefreshGroups>b__16_2(Assets.Api.Client.LocationMaster location);
                        /*0x3c718f8*/ bool <RefreshKeys>b__17_1(Assets.Api.Client.LocationNodeMaster node);
                        /*0x3c71944*/ long <RefreshKeys>b__17_2(Assets.Api.Client.LocationNodeMaster node);
                        /*0x3c7195c*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListCell.Args <RefreshKeys>b__17_3(Assets.Api.Client.LocationNodeMaster node);
                    }

                    class <>c__DisplayClass16_0
                    {
                        /*0x10*/ Assets.Api.Client.LocationTypes locationType;

                        /*0x3c7165c*/ <>c__DisplayClass16_0();
                        /*0x3c71a44*/ bool <RefreshGroups>b__0(Assets.Api.Client.LocationMaster location);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ long locationMasterId;

                        /*0x3c71664*/ <>c__DisplayClass17_0();
                        /*0x3c71a68*/ bool <RefreshKeys>b__0(Assets.Api.Client.LocationNodeMaster node);
                    }

                    class <>c__DisplayClass18_0
                    {
                        /*0x10*/ Assets.Api.Client.PartyTypes partyType;
                        /*0x18*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController <>4__this;
                        /*0x20*/ Assets.Api.Client.LocationMaster locationMaster;

                        /*0x3c71a8c*/ <>c__DisplayClass18_0();
                        /*0x3c71a94*/ bool <StartBattle>b__1(Assets.Api.Client.Party party);
                        /*0x3c71ab8*/ Assets.Api.Client.PartyTypes <StartBattle>g__GetSimulationPartyType|0();
                        /*0x3c71c50*/ bool <StartBattle>b__2(Assets.Api.Client.SimulationMaster ms);
                    }

                    struct <StartBattle>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugBattleLocationListWindowController <>4__this;
                        /*0x30*/ long locationNodeId;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Api.Client.Result<Assets.Api.Client.RealBattleResult>> <>u__1;
                        /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__2;

                        /*0x3c71c7c*/ void MoveNext();
                        /*0x3c727f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x3c73898*/ DebugEnemyAssetViewWindowComponent();
                    /*0x3c72800*/ Assets.AssetManagement.ISpineAssetProvider get_SpineAssetProvider();
                    /*0x3c72808*/ void set_SpineAssetProvider(Assets.AssetManagement.ISpineAssetProvider value);
                    /*0x3c72810*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnCreate();
                    /*0x3c72ee8*/ Cysharp.Threading.Tasks.UniTask<bool> ProcessOnRestore();
                    /*0x3c7367c*/ void ApplyScrollView(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] args, Assets.GameUi.ScrollView.ScrollViewComponent scrollView, string filterText);
                    /*0x3c737cc*/ Cysharp.Threading.Tasks.UniTask ApplySpine(string assetId);
                    /*0x3c72b58*/ void SetScaleControlle();
                    /*0x3c738e0*/ void <ProcessOnCreate>b__15_0();
                    /*0x3c73938*/ void <ProcessOnCreate>b__15_1(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.GroupArgs enemy);
                    /*0x3c73960*/ void <ProcessOnCreate>b__15_2(string text);
                    /*0x3c73a00*/ void <ProcessOnCreate>b__15_3(string value);
                    /*0x3c73a58*/ Cysharp.Threading.Tasks.UniTask <ProcessOnCreate>b__15_4(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args);
                    /*0x3c73b28*/ void <SetScaleControlle>b__19_0(UnityEngine.EventSystems.BaseEventData data);
                    /*0x3c73bd4*/ void <SetScaleControlle>b__19_1(UnityEngine.EventSystems.BaseEventData data);
                    /*0x3c73bdc*/ void <SetScaleControlle>b__19_2(UnityEngine.EventSystems.BaseEventData data);

                    struct <<ProcessOnCreate>b__15_4>d : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowComponent <>4__this;
                        /*0x30*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args args;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                        /*0x3c73d04*/ void MoveNext();
                        /*0x3c74138*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ string filterText;

                        /*0x3c737c4*/ <>c__DisplayClass17_0();
                        /*0x3c74144*/ bool <ApplyScrollView>b__0(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args a);
                    }

                    struct <ApplySpine>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                        /*0x28*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowComponent <>4__this;
                        /*0x30*/ string assetId;
                        /*0x38*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> <>u__1;

                        /*0x3c74198*/ void MoveNext();
                        /*0x3c74974*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DebugEnemyAssetViewWindowComponentNavigation
                {
                    static /*0x3c74980*/ Cysharp.Threading.Tasks.UniTask OpenDebugEnemyAssetViewWindow(Assets.UiComponentSystem.Runtime.IGameNavigator navigator);
                }

                class DebugEnemyAssetViewWindowController : Assets.UiComponentSystem.Runtime.Controller
                {
                    /*0x20*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.GroupArgs> <Enemies>k__BackingField;
                    /*0x28*/ Assets.Api.MemoryDB.IMemoryDB memoryDB;
                    /*0x30*/ string[] filteredKeysCash;

                    /*0x3c74a84*/ DebugEnemyAssetViewWindowController(Assets.Api.MemoryDB.IMemoryDB memoryDB);
                    /*0x3c74a7c*/ UniRx.ReactiveProperty<Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugEnemyAssetViewWindowController.GroupArgs> get_Enemies();
                    /*0x3c72f80*/ void Refresh();

                    class GroupArgs
                    {
                        /*0x10*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] <Args>k__BackingField;

                        /*0x3c74b20*/ GroupArgs();
                        /*0x3c74b84*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] get_Args();
                        /*0x3c74b8c*/ void set_Args(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args[] value);
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

                        static /*0x3c74b94*/ <>c();
                        /*0x3c74bfc*/ <>c();
                        /*0x3c74c04*/ System.Collections.Generic.IEnumerable<object> <Refresh>b__6_0(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                        /*0x3c74ca4*/ string <Refresh>b__6_1(object key);
                        /*0x3c74cc8*/ bool <Refresh>b__6_2(string path);
                        /*0x3c74d44*/ string <Refresh>b__6_3(string path);
                        /*0x3c74d4c*/ long <Refresh>b__6_4(Assets.Api.Client.EnemyMaster enemy);
                        /*0x3c74d64*/ Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args <Refresh>b__6_5(Assets.Api.Client.EnemyMaster enemy);
                        /*0x3c74e44*/ bool <Refresh>b__6_6(Assets.DebugTools.DebugMenu.DebugAssetViewWindow.DebugButtonCell.Args a);
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

            /*0x3c74f8c*/ FullscreenGrabPassRendererFeature();
            /*0x3c74e6c*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            /*0x3c74ec8*/ void Create();
        }

        class FullscreenGrabPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
        {
            static string ProfilerTag = "FullscreenGrabPass";
            static string TextureName = "_FullscreenGrabTexture";

            /*0x3c74f34*/ FullscreenGrabPass();
            /*0x3c74f94*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);

            class FullscreenGrabPassData : UnityEngine.Rendering.ContextItem
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <GrabTexture>k__BackingField;

                /*0x3c7521c*/ FullscreenGrabPassData();
                /*0x3c75178*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_GrabTexture();
                /*0x3c75184*/ void set_GrabTexture(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c7518c*/ void Reset();
            }
        }

        class FullscreenShaderDoublePassRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
        {
            /*0x20*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings <PassSettings>k__BackingField;
            /*0x28*/ UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint;
            /*0x30*/ UnityEngine.Shader shader;
            /*0x38*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePass renderPass;
            /*0x40*/ UnityEngine.Material material;

            /*0x3c75504*/ FullscreenShaderDoublePassRendererFeature();
            /*0x3c75224*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings get_PassSettings();
            /*0x3c7522c*/ void set_PassSettings(Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings value);
            /*0x3c75234*/ void Create();
            /*0x3c75430*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            /*0x3c754a8*/ void Dispose(bool disposing);

            class Settings
            {
                /*0x10*/ float <Float_0_10>k__BackingField;
                /*0x14*/ bool <IgnoreOnZero>k__BackingField;

                /*0x3c75538*/ Settings();
                /*0x3c75514*/ float get_Float_0_10();
                /*0x3c7551c*/ void set_Float_0_10(float value);
                /*0x3c75524*/ bool get_IgnoreOnZero();
                /*0x3c7552c*/ void set_IgnoreOnZero(bool value);
            }
        }

        class FullscreenShaderDoublePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
        {
            static string ProfilerTag = "FullscreenShaderDoublePass";
            static /*0x0*/ int float_0_10_valueId;
            /*0xb8*/ Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings settings;
            /*0xc0*/ UnityEngine.Material material;
            /*0xc8*/ UnityEngine.RenderTextureDescriptor textureDescriptor;

            static /*0x3c75a40*/ FullscreenShaderDoublePass();
            /*0x3c75344*/ FullscreenShaderDoublePass(UnityEngine.Material material, Assets.CustomRendererFeatures.FullscreenShaderDoublePassRendererFeature.Settings settings);
            /*0x3c75548*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            /*0x3c7597c*/ void UpdateShaderSettings();
        }

        class MosaicRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
        {
            /*0x20*/ Assets.CustomRendererFeatures.MosaicRendererFeature.Settings passSettings;
            /*0x28*/ UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint;
            /*0x30*/ UnityEngine.Shader depthShader;
            /*0x38*/ UnityEngine.Shader colorCorrectionShader;
            /*0x40*/ UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass;

            /*0x3c7614c*/ MosaicRendererFeature();
            /*0x3c75aa8*/ void Create();
            /*0x3c75f80*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            /*0x3c76098*/ void Dispose(bool disposing);

            class Settings
            {
                /*0x10*/ RendererOverrideListener <Listener>k__BackingField;
                /*0x18*/ UnityEngine.LayerMask <LayerMask>k__BackingField;
                /*0x1c*/ int <Pixelation>k__BackingField;
                /*0x20*/ float <Threshold>k__BackingField;
                /*0x24*/ float <Softness>k__BackingField;
                /*0x28*/ string <Keyword>k__BackingField;

                /*0x3c761bc*/ Settings();
                /*0x3c7615c*/ RendererOverrideListener get_Listener();
                /*0x3c76164*/ void set_Listener(RendererOverrideListener value);
                /*0x3c7616c*/ UnityEngine.LayerMask get_LayerMask();
                /*0x3c76174*/ void set_LayerMask(UnityEngine.LayerMask value);
                /*0x3c7617c*/ int get_Pixelation();
                /*0x3c76184*/ void set_Pixelation(int value);
                /*0x3c7618c*/ float get_Threshold();
                /*0x3c76194*/ void set_Threshold(float value);
                /*0x3c7619c*/ float get_Softness();
                /*0x3c761a4*/ void set_Softness(float value);
                /*0x3c761ac*/ string get_Keyword();
                /*0x3c761b4*/ void set_Keyword(string value);
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

            static /*0x3c76f80*/ void ExecutePass(Assets.CustomRendererFeatures.MosaicRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
            /*0x3c75ba0*/ MosaicRenderPass(Assets.CustomRendererFeatures.MosaicRendererFeature.Settings passSettings, UnityEngine.Shader depthShader, UnityEngine.Shader colorCorrectionShader);
            /*0x3c7621c*/ void TryCreateMaterials();
            /*0x3c76334*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
            /*0x3c76e24*/ void UpdateColorCorrectionShaderSettings();
            /*0x3c775f4*/ void Dispose();

            class PassData
            {
                /*0x10*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle <RendererListHandle>k__BackingField;
                /*0x1c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <ColorTextureHandle>k__BackingField;
                /*0x2c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <DownsampleTextureHandle>k__BackingField;
                /*0x3c*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle <DepthTextureHandle>k__BackingField;
                /*0x50*/ Assets.Utilities.Spine.RendererOverride[] <Targets>k__BackingField;
                /*0x58*/ string <Keyword>k__BackingField;
                /*0x60*/ UnityEngine.Material <ColorCorrectionMaterial>k__BackingField;

                /*0x3c776fc*/ PassData();
                /*0x3c7765c*/ UnityEngine.Rendering.RenderGraphModule.RendererListHandle get_RendererListHandle();
                /*0x3c7766c*/ void set_RendererListHandle(UnityEngine.Rendering.RenderGraphModule.RendererListHandle value);
                /*0x3c77678*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_ColorTextureHandle();
                /*0x3c77688*/ void set_ColorTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c77694*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_DownsampleTextureHandle();
                /*0x3c776a4*/ void set_DownsampleTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c776b0*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle get_DepthTextureHandle();
                /*0x3c776c0*/ void set_DepthTextureHandle(UnityEngine.Rendering.RenderGraphModule.TextureHandle value);
                /*0x3c776cc*/ Assets.Utilities.Spine.RendererOverride[] get_Targets();
                /*0x3c776d4*/ void set_Targets(Assets.Utilities.Spine.RendererOverride[] value);
                /*0x3c776dc*/ string get_Keyword();
                /*0x3c776e4*/ void set_Keyword(string value);
                /*0x3c776ec*/ UnityEngine.Material get_ColorCorrectionMaterial();
                /*0x3c776f4*/ void set_ColorCorrectionMaterial(UnityEngine.Material value);
            }

            class <>c
            {
                static /*0x0*/ Assets.CustomRendererFeatures.MosaicRenderPass.<> <>9;
                static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<Assets.CustomRendererFeatures.MosaicRenderPass.PassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__10_0;

                static /*0x3c777c4*/ <>c();
                /*0x3c7782c*/ <>c();
                /*0x3c77834*/ void <RecordRenderGraph>b__10_0(Assets.CustomRendererFeatures.MosaicRenderPass.PassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
            }
        }
    }

    namespace VisualEffectData
    {
        class DummyVfxHandler : UnityEngine.MonoBehaviour
        {
            /*0x3c77844*/ DummyVfxHandler();
            /*0x3c77840*/ void VFX_EVENT_End();
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
