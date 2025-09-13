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
                    /*0x30*/ Unity.Services.Core.Configuration.CloudProjectId <CloudProjectId>k__BackingField;
                    /*0x38*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory <DiagnosticsFactory>k__BackingField;
                    /*0x40*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory <MetricsFactory>k__BackingField;
                    /*0x48*/ Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField;
                    /*0x50*/ Unity.Services.Core.InitializationOptions m_CurrentInitializationOptions;

                    static /*0x2aeb08c*/ void Register();
                    static /*0x2aeb71c*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(Unity.Services.Core.InitializationOptions options);
                    static /*0x2aeb83c*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync();
                    /*0x2aeb2c4*/ CorePackageInitializer();
                    /*0x2aeb00c*/ Unity.Services.Core.Scheduler.Internal.ActionScheduler get_ActionScheduler();
                    /*0x2aeb014*/ void set_ActionScheduler(Unity.Services.Core.Scheduler.Internal.ActionScheduler value);
                    /*0x2aeb01c*/ Unity.Services.Core.Device.InstallationId get_InstallationId();
                    /*0x2aeb024*/ void set_InstallationId(Unity.Services.Core.Device.InstallationId value);
                    /*0x2aeb02c*/ Unity.Services.Core.Configuration.ProjectConfiguration get_ProjectConfig();
                    /*0x2aeb034*/ void set_ProjectConfig(Unity.Services.Core.Configuration.ProjectConfiguration value);
                    /*0x2aeb03c*/ Unity.Services.Core.Environments.Internal.Environments get_Environments();
                    /*0x2aeb044*/ void set_Environments(Unity.Services.Core.Environments.Internal.Environments value);
                    /*0x2aeb04c*/ Unity.Services.Core.Configuration.CloudProjectId get_CloudProjectId();
                    /*0x2aeb054*/ void set_CloudProjectId(Unity.Services.Core.Configuration.CloudProjectId value);
                    /*0x2aeb05c*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory get_DiagnosticsFactory();
                    /*0x2aeb064*/ void set_DiagnosticsFactory(Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory value);
                    /*0x2aeb06c*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory get_MetricsFactory();
                    /*0x2aeb074*/ void set_MetricsFactory(Unity.Services.Core.Telemetry.Internal.IMetricsFactory value);
                    /*0x2aeb07c*/ Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal get_UnityThreadUtils();
                    /*0x2aeb084*/ void set_UnityThreadUtils(Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal value);
                    /*0x2aeb2cc*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                    /*0x2aeb3e0*/ bool HaveInitOptionsChanged();
                    /*0x2aeb500*/ void FreeOptionsDependantComponents();
                    /*0x2aeb50c*/ void InitializeInstallationId();
                    /*0x2aeb584*/ void InitializeActionScheduler();
                    /*0x2aeb5fc*/ System.Threading.Tasks.Task InitializeProjectConfigAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x2aeb968*/ void InitializeEnvironments(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x2aebaa0*/ void InitializeCloudProjectId();
                    /*0x2aebb04*/ void InitializeDiagnostics(Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration, Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                    /*0x2aebb48*/ void InitializeMetrics(Unity.Services.Core.Scheduler.Internal.IActionScheduler scheduler, Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration, Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId, Unity.Services.Core.Environments.Internal.IEnvironments environments);
                    /*0x2aebb8c*/ void InitializeUnityThreadUtils();
                    /*0x2aebbf0*/ System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> CreateDiagnosticsComponents();
                    /*0x2aebd10*/ System.Threading.Tasks.Task<string> GetSerializedProjectConfigurationAsync();
                    /*0x2aebe30*/ void <Initialize>g__RegisterProvidedComponents|35_0(ref Unity.Services.Core.Registration.CorePackageInitializer.<> );

                    struct <>c__DisplayClass35_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.CoreRegistry registry;
                        /*0x18*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                    }

                    struct <Initialize>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreRegistry registry;
                        /*0x38*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x40*/ Unity.Services.Core.Registration.CorePackageInitializer.<> <>8__1;
                        /*0x50*/ System.Diagnostics.Stopwatch <stopwatch>5__2;
                        /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb273c8*/ void MoveNext();
                        /*0xb273d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeProjectConfigAsync>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.InitializationOptions options;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1;

                        /*0xb273dc*/ void MoveNext();
                        /*0xb273e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GenerateProjectConfigurationAsync>d__41 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder;
                        /*0x30*/ Unity.Services.Core.InitializationOptions options;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0xb27398*/ void MoveNext();
                        /*0xb273a0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetSerializedConfigOrEmptyAsync>d__42 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0xb273a8*/ void MoveNext();
                        /*0xb273b0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <CreateDiagnosticsComponents>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb27388*/ void MoveNext();
                        /*0xb27390*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetSerializedProjectConfigurationAsync>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb273b8*/ void MoveNext();
                        /*0xb273c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }
        }
    }
}
