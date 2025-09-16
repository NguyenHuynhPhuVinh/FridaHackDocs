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

                    static /*0x7d17698*/ void InitializeOnLoad();
                    static /*0x7d17ec0*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync();
                    static /*0x7d185dc*/ bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(System.Exception reason);
                    /*0x7d1775c*/ CorePackageInitializer(Unity.Services.Core.Internal.Serialization.IJsonSerializer serializer);
                    /*0x7d17608*/ Unity.Services.Core.Scheduler.Internal.ActionScheduler get_ActionScheduler();
                    /*0x7d17610*/ void set_ActionScheduler(Unity.Services.Core.Scheduler.Internal.ActionScheduler value);
                    /*0x7d17618*/ Unity.Services.Core.Device.InstallationId get_InstallationId();
                    /*0x7d17620*/ void set_InstallationId(Unity.Services.Core.Device.InstallationId value);
                    /*0x7d17628*/ Unity.Services.Core.Configuration.ProjectConfiguration get_ProjectConfig();
                    /*0x7d17630*/ void set_ProjectConfig(Unity.Services.Core.Configuration.ProjectConfiguration value);
                    /*0x7d17638*/ Unity.Services.Core.Environments.Internal.Environments get_Environments();
                    /*0x7d17640*/ void set_Environments(Unity.Services.Core.Environments.Internal.Environments value);
                    /*0x7d17648*/ Unity.Services.Core.Configuration.ExternalUserId get_ExternalUserId();
                    /*0x7d17650*/ void set_ExternalUserId(Unity.Services.Core.Configuration.ExternalUserId value);
                    /*0x7d17658*/ Unity.Services.Core.Configuration.Internal.ICloudProjectId get_CloudProjectId();
                    /*0x7d17660*/ void set_CloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId value);
                    /*0x7d17668*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory get_DiagnosticsFactory();
                    /*0x7d17670*/ void set_DiagnosticsFactory(Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory value);
                    /*0x7d17678*/ Unity.Services.Core.Telemetry.Internal.IMetricsFactory get_MetricsFactory();
                    /*0x7d17680*/ void set_MetricsFactory(Unity.Services.Core.Telemetry.Internal.IMetricsFactory value);
                    /*0x7d17688*/ Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal get_UnityThreadUtils();
                    /*0x7d17690*/ void set_UnityThreadUtils(Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal value);
                    /*0x7d1778c*/ void Register(Unity.Services.Core.Internal.CorePackageRegistry registry);
                    /*0x7d179c0*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                    /*0x7d17ac0*/ System.Threading.Tasks.Task InitializeInstanceAsync(Unity.Services.Core.Internal.CoreRegistry registry);
                    /*0x7d179dc*/ System.Threading.Tasks.Task InitializeComponents();
                    /*0x7d17adc*/ bool HaveInitOptionsChanged();
                    /*0x7d17b50*/ void FreeOptionsDependantComponents();
                    /*0x7d17b98*/ void InitializeInstallationId();
                    /*0x7d17c20*/ void InitializeActionScheduler();
                    /*0x7d17ca8*/ System.Threading.Tasks.Task InitializeProjectConfigAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x7d17da4*/ System.Threading.Tasks.Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync(Unity.Services.Core.InitializationOptions options);
                    /*0x7d17fb0*/ void InitializeExternalUserId(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x7d18124*/ void InitializeEnvironments(Unity.Services.Core.Configuration.Internal.IProjectConfiguration projectConfiguration);
                    /*0x7d18270*/ void InitializeMetrics();
                    /*0x7d182e4*/ void InitializeDiagnostics();
                    /*0x7d18358*/ void InitializeCloudProjectId(Unity.Services.Core.Configuration.Internal.ICloudProjectId cloudProjectId);
                    /*0x7d183d4*/ void InitializeUnityThreadUtils();
                    /*0x7d18448*/ void <InitializeComponents>g__RegisterProvidedComponents|47_0();

                    struct <GenerateProjectConfigurationAsync>d__53 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.ProjectConfiguration> <>t__builder;
                        /*0x30*/ Unity.Services.Core.InitializationOptions options;
                        /*0x38*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0x7d185e4*/ void MoveNext();
                        /*0x7d18900*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <GetSerializedConfigOrEmptyAsync>d__54 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>t__builder;
                        /*0x30*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.SerializableProjectConfiguration> <>u__1;

                        /*0x7d1897c*/ void MoveNext();
                        /*0x7d18da0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeComponents>d__47 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7d18e1c*/ void MoveNext();
                        /*0x7d19208*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeProjectConfigAsync>d__52 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Registration.CorePackageInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.InitializationOptions options;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Configuration.ProjectConfiguration> <>u__1;

                        /*0x7d19270*/ void MoveNext();
                        /*0x7d19500*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }
            }
        }
    }
}
