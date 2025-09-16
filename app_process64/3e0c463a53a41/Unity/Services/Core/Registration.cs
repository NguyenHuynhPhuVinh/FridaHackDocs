class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Registration
            {
                class CorePackageInitializer : Unity.Services.Core.Internal.IInitializablePackageV2, Unity.Services.Core.Internal.IInitializablePackage, Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider
                {
                    /*0x10*/ Unity.Services.Core.Scheduler.Internal.ActionScheduler <ActionScheduler>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Device.InstallationId <InstallationId>k__BackingField;
                    /*0x20*/ Unity.Services.Core.Configuration.ProjectConfiguration <ProjectConfig>k__BackingField;
                    /*0x28*/ Unity.Services.Core.Environments.Internal.Environments <Environments>k__BackingField;
                    /*0x30*/ Unity.Services.Core.Configuration.ExternalUserId <ExternalUserId>k__BackingField;
                    /*0x38*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId <CloudProjectId>k__BackingField;
                    /*0x40*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory <DiagnosticsFactory>k__BackingField;
                    /*0x48*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory <MetricsFactory>k__BackingField;
                    /*0x50*/ Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField;
                    /*0x58*/ Unity.Services.Core.Internal.CoreRegistry m_Registry;
                    /*0x60*/ Unity.Services.Core.Internal.Serialization.IJsonSerializer m_Serializer;
                    /*0x68*/ Unity.Services.Core.InitializationOptions m_CurrentInitializationOptions;

                    static /*0x7d00268*/ void InitializeOnLoad();
                    static /*0x7d00a90*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync();
                    static /*0x7d011ac*/ bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(System.Exception reason);
                    /*0x7d0032c*/ CorePackageInitializer(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer);
                    /*0x7d001d8*/ Unity.Services.Core.Scheduler.Internal.ActionScheduler get_ActionScheduler();
                    /*0x7d001e0*/ void set_ActionScheduler(Unity.Services.Core.Scheduler.Internal.ActionScheduler value);
                    /*0x7d001e8*/ Unity.Services.Core.Device.InstallationId get_InstallationId();
                    /*0x7d001f0*/ void set_InstallationId(Unity.Services.Core.Device.InstallationId value);
                    /*0x7d001f8*/ Unity.Services.Core.Configuration.ProjectConfiguration get_ProjectConfig();
                    /*0x7d00200*/ void set_ProjectConfig(Unity.Services.Core.Configuration.ProjectConfiguration value);
                    /*0x7d00208*/ Unity.Services.Core.Environments.Internal.Environments get_Environments();
                    /*0x7d00210*/ void set_Environments(Unity.Services.Core.Environments.Internal.Environments value);
                    /*0x7d00218*/ Unity.Services.Core.Configuration.ExternalUserId get_ExternalUserId();
                    /*0x7d00220*/ void set_ExternalUserId(Unity.Services.Core.Configuration.ExternalUserId value);
                    /*0x7d00228*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId get_CloudProjectId();
                    /*0x7d00230*/ void set_CloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId value);
                    /*0x7d00238*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory get_DiagnosticsFactory();
                    /*0x7d00240*/ void set_DiagnosticsFactory(Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory value);
                    /*0x7d00248*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory get_MetricsFactory();
                    /*0x7d00250*/ void set_MetricsFactory(Unity.Services.Core.Telemetry.Internal.IMetricsFactory value);
                    /*0x7d00258*/ Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal get_UnityThreadUtils();
                    /*0x7d00260*/ void set_UnityThreadUtils(Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal value);
                    /*0x7d0035c*/ void Register(Unity.Services.Core.Internal.CorePackageRegistry registry);
                    /*0x7d00590*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                    /*0x7d00690*/ System.Threading.Tasks.Task InitializeInstanceAsync(Unity.Services.Core.Internal.CoreRegistry registry);
                    /*0x7d005ac*/ System.Threading.Tasks.Task InitializeComponents();
                    /*0x7d006ac*/ bool HaveInitOptionsChanged();
                    /*0x7d00720*/ void FreeOptionsDependantComponents();
                    /*0x7d00768*/ void InitializeInstallationId();
                    /*0x7d007f0*/ void InitializeActionScheduler();
                    /*0x7d00878*/ System.Threading.Tasks.Task InitializeProjectConfigAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x7d00974*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x7d00b80*/ void InitializeExternalUserId(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x7d00cf4*/ void InitializeEnvironments(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x7d00e40*/ void InitializeMetrics();
                    /*0x7d00eb4*/ void InitializeDiagnostics();
                    /*0x7d00f28*/ void InitializeCloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId);
                    /*0x7d00fa4*/ void InitializeUnityThreadUtils();
                    /*0x7d01018*/ void <InitializeComponents>g__RegisterProvidedComponents|47_0();

                    struct <GenerateProjectConfigurationAsync>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder;
                        /*0x30*/ Unity.Services.Core.InitializationOptions options;
                        /*0x38*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0x7d011b4*/ void MoveNext();
                        /*0x7d014d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetSerializedConfigOrEmptyAsync>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0x7d0154c*/ void MoveNext();
                        /*0x7d01970*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeComponents>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7d019ec*/ void MoveNext();
                        /*0x7d01dd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeProjectConfigAsync>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.InitializationOptions options;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1;

                        /*0x7d01e40*/ void MoveNext();
                        /*0x7d020d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }
        }
    }
}
