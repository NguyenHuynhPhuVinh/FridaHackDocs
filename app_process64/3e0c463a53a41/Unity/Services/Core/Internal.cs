class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Core
        {
            namespace Threading
            {
                namespace Internal
                {
                    interface IUnityThreadUtils : Unity.Services.Core.Internal.IServiceComponent
                    {
                    }
                }
            }

            namespace Telemetry
            {
                namespace Internal
                {
                    interface IDiagnostics
                    {
                        /*0x380da4c*/ void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IDiagnosticsComponentProvider
                    {
                    }

                    interface IDiagnosticsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x380bb68*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    interface IMetrics
                    {
                        void SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IMetricsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x380bb68*/ Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
                    }
                }
            }

            namespace Scheduler
            {
                namespace Internal
                {
                    interface IActionScheduler : Unity.Services.Core.Internal.IServiceComponent
                    {
                    }
                }
            }

            namespace Environments
            {
                namespace Internal
                {
                    interface IEnvironments : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x380b9e8*/ string get_Current();
                    }
                }
            }

            namespace Device
            {
                namespace Internal
                {
                    interface IInstallationId : Unity.Services.Core.Internal.IServiceComponent
                    {
                    }
                }
            }

            namespace Configuration
            {
                namespace Internal
                {
                    interface ICloudProjectId : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x380b9e8*/ string GetCloudProjectId();
                    }

                    interface IExternalUserId : Unity.Services.Core.Internal.IServiceComponent
                    {
                    }

                    interface IProjectConfiguration : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x380bcbc*/ string GetString(string key, string defaultValue);
                    }
                }
            }

            namespace Analytics
            {
                namespace Internal
                {
                    interface IAnalyticsStandardEventComponent : Unity.Services.Core.Internal.IServiceComponent
                    {
                    }
                }
            }

            namespace Internal
            {
                class AsyncOperationBase : UnityEngine.CustomYieldInstruction
                {
                    /*0x7cf96a0*/ bool get_keepWaiting();
                    /*0x380b128*/ bool get_IsCompleted();
                }

                class TaskAsyncOperation : Unity.Services.Core.Internal.AsyncOperationBase
                {
                    static /*0x0*/ System.Threading.Tasks.TaskScheduler Scheduler;
                    /*0x10*/ System.Threading.Tasks.Task m_Task;

                    static /*0x7cf96dc*/ void SetScheduler();
                    /*0x7cf96c0*/ bool get_IsCompleted();
                }

                class CoreLogger
                {
                    static /*0x7cf975c*/ void LogWarning(object message);
                    static /*0x7cf987c*/ void LogError(object message);
                    static /*0x7cf999c*/ void LogException(System.Exception exception);
                }

                class CircularDependencyException : Unity.Services.Core.ServicesInitializationException
                {
                    /*0x7cf9ac0*/ CircularDependencyException();
                }

                class ComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField;

                    /*0x7cf9ad0*/ ComponentRegistry();
                    /*0x7cf9ac8*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance();
                    /*0x3907c14*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3907c14*/ TComponent GetServiceComponent<TComponent>();
                    /*0x7cf9b58*/ bool IsComponentTypeRegistered(int componentTypeHash);
                    /*0x7cf9c20*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                interface IComponentRegistry
                {
                    /*0x3907c14*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3907c14*/ TComponent GetServiceComponent<TComponent>();
                    /*0x380d83c*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                class LockedComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.IComponentRegistry <Registry>k__BackingField;

                    /*0x7cf9ca0*/ LockedComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry registryToLock);
                    /*0x7cf9c98*/ Unity.Services.Core.Internal.IComponentRegistry get_Registry();
                    /*0x3907c14*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3907c14*/ TComponent GetServiceComponent<TComponent>();
                    /*0x7cf9cd0*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                class CorePackageRegistry
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CorePackageRegistry <Instance>k__BackingField;
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField;

                    static /*0x7cf9d1c*/ Unity.Services.Core.Internal.CorePackageRegistry get_Instance();
                    static /*0x7cf9d64*/ void set_Instance(Unity.Services.Core.Internal.CorePackageRegistry value);
                    /*0x7cf9dcc*/ CorePackageRegistry();
                    /*0x7cf9dbc*/ Unity.Services.Core.Internal.IPackageRegistry get_Registry();
                    /*0x7cf9dc4*/ void set_Registry(Unity.Services.Core.Internal.IPackageRegistry value);
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration Register<TPackage>(TPackage package);
                    /*0x7cf9ff4*/ void Lock();
                }

                struct CoreRegistration
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry m_Registry;
                    /*0x18*/ int m_PackageHash;

                    /*0x7cfa0d0*/ CoreRegistration(Unity.Services.Core.Internal.IPackageRegistry registry, int packageHash);
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration DependsOn<T>();
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration OptionallyDependsOn<T>();
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration ProvidesComponent<T>();
                }

                class CoreRegistry
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreRegistry <Instance>k__BackingField;
                    /*0x10*/ string <InstanceId>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Internal.ServicesType <Type>k__BackingField;
                    /*0x20*/ Unity.Services.Core.InitializationOptions <Options>k__BackingField;
                    /*0x28*/ Unity.Services.Core.Internal.IPackageRegistry <PackageRegistry>k__BackingField;
                    /*0x30*/ Unity.Services.Core.Internal.IComponentRegistry <ComponentRegistry>k__BackingField;
                    /*0x38*/ Unity.Services.Core.Internal.IServiceRegistry <ServiceRegistry>k__BackingField;

                    static /*0x7cfa0f8*/ Unity.Services.Core.Internal.CoreRegistry get_Instance();
                    static /*0x7cfa140*/ void set_Instance(Unity.Services.Core.Internal.CoreRegistry value);
                    /*0x7cfa1d8*/ CoreRegistry(Unity.Services.Core.Internal.IPackageRegistry packageRegistry, Unity.Services.Core.Internal.ServicesType type, string instanceId);
                    /*0x7cfa198*/ Unity.Services.Core.Internal.ServicesType get_Type();
                    /*0x7cfa1a0*/ void set_Type(Unity.Services.Core.Internal.ServicesType value);
                    /*0x7cfa1a8*/ Unity.Services.Core.InitializationOptions get_Options();
                    /*0x7cfa1b0*/ Unity.Services.Core.Internal.IPackageRegistry get_PackageRegistry();
                    /*0x7cfa1b8*/ void set_PackageRegistry(Unity.Services.Core.Internal.IPackageRegistry value);
                    /*0x7cfa1c0*/ Unity.Services.Core.Internal.IComponentRegistry get_ComponentRegistry();
                    /*0x7cfa1c8*/ void set_ComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry value);
                    /*0x7cfa1d0*/ void set_ServiceRegistry(Unity.Services.Core.Internal.IServiceRegistry value);
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x3907c14*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3907c14*/ TComponent GetServiceComponent<TComponent>();
                    /*0x7cfa33c*/ void LockComponentRegistration();
                }

                class CoreRegistryInitializer
                {
                    /*0x10*/ Unity.Services.Core.Internal.CoreRegistry m_Registry;
                    /*0x18*/ System.Collections.Generic.List<int> m_SortedPackageTypeHashes;

                    /*0x7cfa3e8*/ CoreRegistryInitializer(Unity.Services.Core.Internal.CoreRegistry registry, System.Collections.Generic.List<int> sortedPackageTypeHashes);
                    /*0x7cfa42c*/ System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> InitializeRegistryAsync();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ System.Diagnostics.Stopwatch stopwatch;
                        /*0x18*/ System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packagesInitInfos;
                        /*0x20*/ System.Collections.Generic.List<System.Exception> failureReasons;
                        /*0x28*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x30*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;

                        /*0x7cfa528*/ <>c__DisplayClass3_0();
                        /*0x7cfa530*/ System.Threading.Tasks.Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(Unity.Services.Core.Internal.IInitializablePackage package);
                        /*0x7cfa62c*/ Unity.Services.Core.Internal.IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index);
                        /*0x7cfa6bc*/ System.Threading.Tasks.Task <InitializeRegistryAsync>g__InitializePackageAsync|2(Unity.Services.Core.Internal.IInitializablePackage package);
                        /*0x7cfa7b8*/ void <InitializeRegistryAsync>g__Fail|3();

                        struct <<InitializeRegistryAsync>g__InitializePackageAsync|2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>4__this;
                            /*0x38*/ Unity.Services.Core.Internal.IInitializablePackage package;
                            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0x7cfa830*/ void MoveNext();
                            /*0x7cfac60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }

                        struct <<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>4__this;
                            /*0x38*/ Unity.Services.Core.Internal.IInitializablePackage package;
                            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0x7cfacc8*/ void MoveNext();
                            /*0x7cfb15c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <InitializeRegistryAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>8__1;
                        /*0x40*/ int <i>5__2;
                        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7cfb1c4*/ void MoveNext();
                        /*0x7cfb868*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DependencyTree
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance;
                    /*0x18*/ System.Collections.Generic.Dictionary<int, int> ComponentTypeHashToPackageTypeHash;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> PackageTypeHashToComponentTypeHashDependencies;
                    /*0x28*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance;

                    /*0x7cf9e74*/ DependencyTree();
                    /*0x7cfb8e4*/ DependencyTree(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<int, int> componentToPackage, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> packageToComponentDependencies, System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentToInstance);
                }

                class DependencyTreeSortFailedException : System.Exception
                {
                    static /*0x7cfb9ec*/ string CreateExceptionMessage(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                    /*0x7cfb958*/ DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                }

                class DependencyTreeExtensions
                {
                    static /*0x7cfbac0*/ string ToJson(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> order);
                    static /*0x7cfcd60*/ bool IsOptional(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x7cfcde0*/ bool IsProvided(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x7cfc280*/ Newtonsoft.Json.Linq.JObject GetPackageJObject(Unity.Services.Core.Internal.DependencyTree tree, int packageHash);
                    static /*0x7cfc9dc*/ Newtonsoft.Json.Linq.JObject GetComponentJObject(Unity.Services.Core.Internal.DependencyTree tree, int componentHash);
                    static /*0x7cfce3c*/ string GetComponentIdentifier(Unity.Services.Core.Internal.IServiceComponent component);
                }

                struct DependencyTreeInitializeOrderSorter
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree Tree;
                    /*0x18*/ System.Collections.Generic.ICollection<int> Target;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory;

                    /*0x7cfcef4*/ DependencyTreeInitializeOrderSorter(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target);
                    /*0x7cfcf34*/ void SortRegisteredPackagesIntoTarget();
                    /*0x7cfd41c*/ void RemoveUnprovidedOptionalDependenciesFromTree();
                    /*0x7cfd8ac*/ void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<int> dependencyTypeHashes);
                    /*0x7cfd5cc*/ void SortTreeThrough(int packageTypeHash);
                    /*0x7cfdbb4*/ void SortTreeThrough(System.Collections.Generic.IEnumerable<int> dependencyTypeHashes);
                    /*0x7cfda60*/ void MarkPackage(int packageTypeHash, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark mark);
                    /*0x7cfd574*/ System.Collections.Generic.IReadOnlyCollection<int> GetPackageTypeHashes();
                    /*0x7cfde9c*/ int GetPackageTypeHashFor(int componentTypeHash);
                    /*0x7cfdac8*/ System.Collections.Generic.IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash);

                    enum ExplorationMark
                    {
                        None = 0,
                        Viewed = 1,
                        Sorted = 2,
                    }
                }

                class HashException : System.Exception
                {
                    /*0x8c*/ int <Hash>k__BackingField;

                    /*0x7cfdf98*/ HashException(int hash, string message);
                    /*0x7cfe004*/ HashException(int hash, string message, System.Exception inner);
                    /*0x7cfdf90*/ int get_Hash();
                }

                class DependencyTreePackageHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x7cfdf8c*/ DependencyTreePackageHashException(int hash, string message);
                    /*0x7cfde98*/ DependencyTreePackageHashException(int hash, string message, System.Exception inner);
                }

                class DependencyTreeComponentHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x7cfdf88*/ DependencyTreeComponentHashException(int hash, string message);
                }

                interface IInitializablePackage
                {
                    /*0x380bb68*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                }

                interface IInitializablePackageV2 : Unity.Services.Core.Internal.IInitializablePackage
                {
                    /*0x380bb68*/ System.Threading.Tasks.Task InitializeInstanceAsync(Unity.Services.Core.Internal.CoreRegistry registry);
                }

                interface IServiceComponent
                {
                }

                class MissingComponent : Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ System.Type <IntendedType>k__BackingField;

                    /*0x7cfe090*/ MissingComponent(System.Type intendedType);
                    /*0x7cfe088*/ System.Type get_IntendedType();
                }

                class PackageInitializationInfo
                {
                    /*0x10*/ System.Type PackageType;
                    /*0x18*/ double InitializationTimeInSeconds;

                    /*0x7cfb154*/ PackageInitializationInfo();
                }

                interface IPackageRegistry
                {
                    /*0x380b9e8*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x380cffc*/ void RegisterDependency<TComponent>(int packageTypeHash);
                    /*0x380cffc*/ void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    /*0x380cffc*/ void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class LockedPackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField;

                    /*0x7cfa0a0*/ LockedPackageRegistry(Unity.Services.Core.Internal.IPackageRegistry registryToLock);
                    /*0x7cfe0c0*/ Unity.Services.Core.Internal.IPackageRegistry get_Registry();
                    /*0x7cfe0c8*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x380cffc*/ void RegisterDependency<TComponent>(int packageTypeHash);
                    /*0x380cffc*/ void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    /*0x380cffc*/ void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class PackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree <Tree>k__BackingField;

                    /*0x7cf9fc4*/ PackageRegistry(Unity.Services.Core.Internal.DependencyTree tree);
                    /*0x7cfe168*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x7cfe170*/ void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    /*0x3907c14*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x380cffc*/ void RegisterDependency<TComponent>(int packageTypeHash);
                    /*0x380cffc*/ void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    /*0x380cffc*/ void RegisterProvision<TComponent>(int packageTypeHash);
                    /*0x7cfe178*/ void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash);
                }

                interface IServiceRegistry
                {
                }

                class ServiceRegistry : Unity.Services.Core.Internal.IServiceRegistry
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, object> <ServiceTypeHashToInstance>k__BackingField;

                    /*0x7cfa2b4*/ ServiceRegistry();
                }

                enum ServicesType
                {
                    Default = 0,
                    Instance = 1,
                }

                class CoreDiagnostics
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreDiagnostics <Instance>k__BackingField;
                    /*0x10*/ System.Collections.Generic.IDictionary<string, string> <CoreTags>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField;

                    static /*0x7cfe284*/ Unity.Services.Core.Internal.CoreDiagnostics get_Instance();
                    static /*0x7cfe2cc*/ void set_Instance(Unity.Services.Core.Internal.CoreDiagnostics value);
                    /*0x7cfe32c*/ CoreDiagnostics();
                    /*0x7cfe324*/ void set_DiagnosticsComponentProvider(Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider value);
                }

                class CoreMetrics
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreMetrics <Instance>k__BackingField;
                    /*0x10*/ System.Collections.Generic.IDictionary<System.Type, Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField;

                    static /*0x7cfe3b4*/ Unity.Services.Core.Internal.CoreMetrics get_Instance();
                    static /*0x7cfe3fc*/ void set_Instance(Unity.Services.Core.Internal.CoreMetrics value);
                    /*0x7cfe454*/ CoreMetrics();
                }

                class UnityServicesInitializer
                {
                    static /*0x7cfe4dc*/ void CreateStaticInstance();
                    static /*0x7cfe8a0*/ void EnableServicesInitializationAsync();
                    static /*0x7cfe934*/ Unity.Services.Core.IUnityServices CreateInstance(string servicesId);

                    struct <EnableServicesInitializationAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7cfea8c*/ void MoveNext();
                        /*0x7cfeda0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class UnityServicesInternal : Unity.Services.Core.IUnityServices
                {
                    /*0x10*/ Unity.Services.Core.ServicesInitializationState <State>k__BackingField;
                    /*0x14*/ bool CanInitialize;
                    /*0x18*/ System.Threading.Tasks.TaskCompletionSource<object> m_Initialization;
                    /*0x20*/ Unity.Services.Core.Internal.CoreRegistry <Registry>k__BackingField;
                    /*0x28*/ Unity.Services.Core.Internal.CoreMetrics <Metrics>k__BackingField;
                    /*0x30*/ Unity.Services.Core.Internal.CoreDiagnostics <Diagnostics>k__BackingField;

                    /*0x7cfe840*/ UnityServicesInternal(Unity.Services.Core.Internal.CoreRegistry registry, Unity.Services.Core.Internal.CoreMetrics coreMetrics, Unity.Services.Core.Internal.CoreDiagnostics coreDiagnostics);
                    /*0x7cfedac*/ Unity.Services.Core.ServicesInitializationState get_State();
                    /*0x7cfedb4*/ void set_State(Unity.Services.Core.ServicesInitializationState value);
                    /*0x7cfedbc*/ Unity.Services.Core.Internal.CoreRegistry get_Registry();
                    /*0x7cfedc4*/ bool HasRequestedInitialization();
                    /*0x7cfedd4*/ System.Threading.Tasks.Task InitializeServicesAsync();
                    /*0x7cfea80*/ void EnableInitialization();
                    /*0x7cfecbc*/ System.Threading.Tasks.Task EnableInitializationAsync();

                    class <>c__DisplayClass33_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;
                        /*0x18*/ System.Collections.Generic.List<int> sortedPackageTypeHashes;
                        /*0x20*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x28*/ System.Diagnostics.Stopwatch initStopwatch;

                        /*0x7cfeebc*/ <>c__DisplayClass33_0();
                        /*0x7cfeec4*/ void <InitializeServicesAsync>g__SortPackages|0();
                        /*0x7cfeef0*/ System.Threading.Tasks.Task <InitializeServicesAsync>g__InitializePackagesAsync|1();
                        /*0x7cfefd4*/ void <InitializeServicesAsync>g__FailServicesInitialization|2(System.Exception reason);
                        /*0x7cff050*/ void <InitializeServicesAsync>g__SucceedServicesInitialization|3();

                        struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>4__this;
                            /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1;

                            /*0x7cff0d8*/ void MoveNext();
                            /*0x7cff34c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <EnableInitializationAsync>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7cff3b4*/ void MoveNext();
                        /*0x7cff5e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeServicesAsync>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>8__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7cff650*/ void MoveNext();
                        /*0x7cffbd8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DictionaryExtensions
                {
                    static /*0x3907c14*/ TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
                    static /*0x381cca4*/ bool ValueEquals<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y);
                    static /*0x3907c14*/ bool ValueEquals<TKey, TValue, TComparer>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y, TComparer valueComparer);
                }

                class UnityWebRequestUtils
                {
                    static /*0x7cffc40*/ bool HasSucceeded(UnityEngine.Networking.UnityWebRequest self);
                    static /*0x7cffc64*/ System.Threading.Tasks.Task<string> GetTextAsync(string uri);

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Threading.Tasks.TaskCompletionSource<string> completionSource;

                        /*0x7cffda8*/ <>c__DisplayClass2_0();
                        /*0x7cffdb0*/ void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(UnityEngine.AsyncOperation rawOperation);
                    }
                }

                namespace Serialization
                {
                    interface IJsonSerializer
                    {
                        /*0x3907c14*/ T DeserializeObject<T>(string value);
                    }

                    class NewtonsoftSerializer : Unity.Services.Core.Internal.Serialization.IJsonSerializer
                    {
                        /*0x10*/ Newtonsoft.Json.JsonSerializer m_Serializer;

                        /*0x7d00168*/ NewtonsoftSerializer(Newtonsoft.Json.JsonSerializerSettings settings);
                        /*0x7d001a8*/ NewtonsoftSerializer(Newtonsoft.Json.JsonSerializer serializer);
                        /*0x3907c14*/ T DeserializeObject<T>(string value);
                    }
                }
            }
        }
    }
}
