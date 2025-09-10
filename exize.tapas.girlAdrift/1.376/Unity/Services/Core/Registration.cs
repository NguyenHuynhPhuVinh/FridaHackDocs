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
                class CorePackageInitializer : Unity.Services.Core.Internal.IInitializablePackage, Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider
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
                    /*0x58*/ Unity.Services.Core.InitializationOptions m_CurrentInitializationOptions;

                    static /*0x124d704*/ void Register();
                    static /*0x124dd78*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(Unity.Services.Core.InitializationOptions options);
                    static /*0x124de68*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync();
                    static /*0x124e69c*/ bool <Initialize>g__SendFailedInitDiagnostic|40_1(System.Exception reason);
                    /*0x124d984*/ CorePackageInitializer();
                    /*0x124d674*/ Unity.Services.Core.Scheduler.Internal.ActionScheduler get_ActionScheduler();
                    /*0x124d67c*/ void set_ActionScheduler(Unity.Services.Core.Scheduler.Internal.ActionScheduler value);
                    /*0x124d684*/ Unity.Services.Core.Device.InstallationId get_InstallationId();
                    /*0x124d68c*/ void set_InstallationId(Unity.Services.Core.Device.InstallationId value);
                    /*0x124d694*/ Unity.Services.Core.Configuration.ProjectConfiguration get_ProjectConfig();
                    /*0x124d69c*/ void set_ProjectConfig(Unity.Services.Core.Configuration.ProjectConfiguration value);
                    /*0x124d6a4*/ Unity.Services.Core.Environments.Internal.Environments get_Environments();
                    /*0x124d6ac*/ void set_Environments(Unity.Services.Core.Environments.Internal.Environments value);
                    /*0x124d6b4*/ Unity.Services.Core.Configuration.ExternalUserId get_ExternalUserId();
                    /*0x124d6bc*/ void set_ExternalUserId(Unity.Services.Core.Configuration.ExternalUserId value);
                    /*0x124d6c4*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId get_CloudProjectId();
                    /*0x124d6cc*/ void set_CloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId value);
                    /*0x124d6d4*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory get_DiagnosticsFactory();
                    /*0x124d6dc*/ void set_DiagnosticsFactory(Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory value);
                    /*0x124d6e4*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory get_MetricsFactory();
                    /*0x124d6ec*/ void set_MetricsFactory(Unity.Services.Core.Telemetry.Internal.IMetricsFactory value);
                    /*0x124d6f4*/ Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal get_UnityThreadUtils();
                    /*0x124d6fc*/ void set_UnityThreadUtils(Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal value);
                    /*0x124d98c*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                    /*0x124da68*/ bool HaveInitOptionsChanged();
                    /*0x124dba8*/ void FreeOptionsDependantComponents();
                    /*0x124dbb4*/ void InitializeInstallationId();
                    /*0x124dc28*/ void InitializeActionScheduler();
                    /*0x124dc9c*/ System.Threading.Tasks.Task InitializeProjectConfigAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x124df54*/ void InitializeExternalUserId(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x124e0b8*/ void InitializeEnvironments(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x124e1e4*/ void InitializeCloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId);
                    /*0x124e254*/ void InitializeDiagnostics(Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration, Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                    /*0x124e288*/ void InitializeMetrics(Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration, Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                    /*0x124e2bc*/ void InitializeUnityThreadUtils();
                    /*0x124e324*/ System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> CreateDiagnosticsComponents();
                    /*0x124e414*/ System.Threading.Tasks.Task<string> GetSerializedProjectConfigurationAsync();
                    /*0x124e504*/ void <Initialize>g__RegisterProvidedComponents|40_0(ref Unity.Services.Core.Registration.CorePackageInitializer.<> );

                    struct <>c__DisplayClass40_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.CoreRegistry registry;
                        /*0x18*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                    }

                    struct <Initialize>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreRegistry registry;
                        /*0x38*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x40*/ Unity.Services.Core.Registration.CorePackageInitializer.<> <>8__1;
                        /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x124e700*/ void MoveNext();
                        /*0x124ee14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeProjectConfigAsync>d__45 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.InitializationOptions options;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1;

                        /*0x124ee20*/ void MoveNext();
                        /*0x124f03c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GenerateProjectConfigurationAsync>d__46 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder;
                        /*0x30*/ Unity.Services.Core.InitializationOptions options;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0x124f048*/ void MoveNext();
                        /*0x124f300*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetSerializedConfigOrEmptyAsync>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0x124f358*/ void MoveNext();
                        /*0x124f718*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <CreateDiagnosticsComponents>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x124f770*/ void MoveNext();
                        /*0x124fa78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetSerializedProjectConfigurationAsync>d__56 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x124fad0*/ void MoveNext();
                        /*0x124fd88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }
        }
    }
}
