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
                        /*0x3816920*/ void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IDiagnosticsComponentProvider
                    {
                    }

                    interface IDiagnosticsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x3814a3c*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    interface IMetrics
                    {
                        void SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IMetricsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x3814a3c*/ Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
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
                        /*0x38148bc*/ string get_Current();
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
                        /*0x38148bc*/ string GetCloudProjectId();
                    }

                    interface IExternalUserId : Unity.Services.Core.Internal.IServiceComponent
                    {
                    }

                    interface IProjectConfiguration : Unity.Services.Core.Internal.IServiceComponent
                    {
                        /*0x3814b90*/ string GetString(string key, string defaultValue);
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
                    /*0x7d10ad0*/ bool get_keepWaiting();
                    /*0x3813ffc*/ bool get_IsCompleted();
                }

                class TaskAsyncOperation : Unity.Services.Core.Internal.AsyncOperationBase
                {
                    static /*0x0*/ System.Threading.Tasks.TaskScheduler Scheduler;
                    /*0x10*/ System.Threading.Tasks.Task m_Task;

                    static /*0x7d10b0c*/ void SetScheduler();
                    /*0x7d10af0*/ bool get_IsCompleted();
                }

                class CoreLogger
                {
                    static /*0x7d10b8c*/ void LogWarning(object message);
                    static /*0x7d10cac*/ void LogError(object message);
                    static /*0x7d10dcc*/ void LogException(System.Exception exception);
                }

                class CircularDependencyException : Unity.Services.Core.ServicesInitializationException
                {
                    /*0x7d10ef0*/ CircularDependencyException();
                }

                class ComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField;

                    /*0x7d10f00*/ ComponentRegistry();
                    /*0x7d10ef8*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance();
                    /*0x3910ae8*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3910ae8*/ TComponent GetServiceComponent<TComponent>();
                    /*0x7d10f88*/ bool IsComponentTypeRegistered(int componentTypeHash);
                    /*0x7d11050*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                interface IComponentRegistry
                {
                    /*0x3910ae8*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3910ae8*/ TComponent GetServiceComponent<TComponent>();
                    /*0x3816710*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                class LockedComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.IComponentRegistry <Registry>k__BackingField;

                    /*0x7d110d0*/ LockedComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry registryToLock);
                    /*0x7d110c8*/ Unity.Services.Core.Internal.IComponentRegistry get_Registry();
                    /*0x3910ae8*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3910ae8*/ TComponent GetServiceComponent<TComponent>();
                    /*0x7d11100*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                class CorePackageRegistry
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CorePackageRegistry <Instance>k__BackingField;
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField;

                    static /*0x7d1114c*/ Unity.Services.Core.Internal.CorePackageRegistry get_Instance();
                    static /*0x7d11194*/ void set_Instance(Unity.Services.Core.Internal.CorePackageRegistry value);
                    /*0x7d111fc*/ CorePackageRegistry();
                    /*0x7d111ec*/ Unity.Services.Core.Internal.IPackageRegistry get_Registry();
                    /*0x7d111f4*/ void set_Registry(Unity.Services.Core.Internal.IPackageRegistry value);
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration Register<TPackage>(TPackage package);
                    /*0x7d11424*/ void Lock();
                }

                struct CoreRegistration
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry m_Registry;
                    /*0x18*/ int m_PackageHash;

                    /*0x7d11500*/ CoreRegistration(Unity.Services.Core.Internal.IPackageRegistry registry, int packageHash);
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration DependsOn<T>();
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration OptionallyDependsOn<T>();
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration ProvidesComponent<T>();
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

                    static /*0x7d11528*/ Unity.Services.Core.Internal.CoreRegistry get_Instance();
                    static /*0x7d11570*/ void set_Instance(Unity.Services.Core.Internal.CoreRegistry value);
                    /*0x7d11608*/ CoreRegistry(Unity.Services.Core.Internal.IPackageRegistry packageRegistry, Unity.Services.Core.Internal.ServicesType type, string instanceId);
                    /*0x7d115c8*/ Unity.Services.Core.Internal.ServicesType get_Type();
                    /*0x7d115d0*/ void set_Type(Unity.Services.Core.Internal.ServicesType value);
                    /*0x7d115d8*/ Unity.Services.Core.InitializationOptions get_Options();
                    /*0x7d115e0*/ Unity.Services.Core.Internal.IPackageRegistry get_PackageRegistry();
                    /*0x7d115e8*/ void set_PackageRegistry(Unity.Services.Core.Internal.IPackageRegistry value);
                    /*0x7d115f0*/ Unity.Services.Core.Internal.IComponentRegistry get_ComponentRegistry();
                    /*0x7d115f8*/ void set_ComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry value);
                    /*0x7d11600*/ void set_ServiceRegistry(Unity.Services.Core.Internal.IServiceRegistry value);
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x3910ae8*/ void RegisterServiceComponent<TComponent>(TComponent component);
                    /*0x3910ae8*/ TComponent GetServiceComponent<TComponent>();
                    /*0x7d1176c*/ void LockComponentRegistration();
                }

                class CoreRegistryInitializer
                {
                    /*0x10*/ Unity.Services.Core.Internal.CoreRegistry m_Registry;
                    /*0x18*/ System.Collections.Generic.List<int> m_SortedPackageTypeHashes;

                    /*0x7d11818*/ CoreRegistryInitializer(Unity.Services.Core.Internal.CoreRegistry registry, System.Collections.Generic.List<int> sortedPackageTypeHashes);
                    /*0x7d1185c*/ System.Threading.Tasks.Task<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> InitializeRegistryAsync();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ System.Diagnostics.Stopwatch stopwatch;
                        /*0x18*/ System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo> packagesInitInfos;
                        /*0x20*/ System.Collections.Generic.List<System.Exception> failureReasons;
                        /*0x28*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x30*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;

                        /*0x7d11958*/ <>c__DisplayClass3_0();
                        /*0x7d11960*/ System.Threading.Tasks.Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(Unity.Services.Core.Internal.IInitializablePackage package);
                        /*0x7d11a5c*/ Unity.Services.Core.Internal.IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index);
                        /*0x7d11aec*/ System.Threading.Tasks.Task <InitializeRegistryAsync>g__InitializePackageAsync|2(Unity.Services.Core.Internal.IInitializablePackage package);
                        /*0x7d11be8*/ void <InitializeRegistryAsync>g__Fail|3();

                        struct <<InitializeRegistryAsync>g__InitializePackageAsync|2>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>4__this;
                            /*0x38*/ Unity.Services.Core.Internal.IInitializablePackage package;
                            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0x7d11c60*/ void MoveNext();
                            /*0x7d12090*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }

                        struct <<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>4__this;
                            /*0x38*/ Unity.Services.Core.Internal.IInitializablePackage package;
                            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0x7d120f8*/ void MoveNext();
                            /*0x7d1258c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                        /*0x7d125f4*/ void MoveNext();
                        /*0x7d12c98*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DependencyTree
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance;
                    /*0x18*/ System.Collections.Generic.Dictionary<int, int> ComponentTypeHashToPackageTypeHash;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> PackageTypeHashToComponentTypeHashDependencies;
                    /*0x28*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance;

                    /*0x7d112a4*/ DependencyTree();
                    /*0x7d12d14*/ DependencyTree(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<int, int> componentToPackage, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> packageToComponentDependencies, System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentToInstance);
                }

                class DependencyTreeSortFailedException : System.Exception
                {
                    static /*0x7d12e1c*/ string CreateExceptionMessage(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                    /*0x7d12d88*/ DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                }

                class DependencyTreeExtensions
                {
                    static /*0x7d12ef0*/ string ToJson(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> order);
                    static /*0x7d14190*/ bool IsOptional(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x7d14210*/ bool IsProvided(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x7d136b0*/ Newtonsoft.Json.Linq.JObject GetPackageJObject(Unity.Services.Core.Internal.DependencyTree tree, int packageHash);
                    static /*0x7d13e0c*/ Newtonsoft.Json.Linq.JObject GetComponentJObject(Unity.Services.Core.Internal.DependencyTree tree, int componentHash);
                    static /*0x7d1426c*/ string GetComponentIdentifier(Unity.Services.Core.Internal.IServiceComponent component);
                }

                struct DependencyTreeInitializeOrderSorter
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree Tree;
                    /*0x18*/ System.Collections.Generic.ICollection<int> Target;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory;

                    /*0x7d14324*/ DependencyTreeInitializeOrderSorter(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target);
                    /*0x7d14364*/ void SortRegisteredPackagesIntoTarget();
                    /*0x7d1484c*/ void RemoveUnprovidedOptionalDependenciesFromTree();
                    /*0x7d14cdc*/ void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<int> dependencyTypeHashes);
                    /*0x7d149fc*/ void SortTreeThrough(int packageTypeHash);
                    /*0x7d14fe4*/ void SortTreeThrough(System.Collections.Generic.IEnumerable<int> dependencyTypeHashes);
                    /*0x7d14e90*/ void MarkPackage(int packageTypeHash, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark mark);
                    /*0x7d149a4*/ System.Collections.Generic.IReadOnlyCollection<int> GetPackageTypeHashes();
                    /*0x7d152cc*/ int GetPackageTypeHashFor(int componentTypeHash);
                    /*0x7d14ef8*/ System.Collections.Generic.IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash);

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

                    /*0x7d153c8*/ HashException(int hash, string message);
                    /*0x7d15434*/ HashException(int hash, string message, System.Exception inner);
                    /*0x7d153c0*/ int get_Hash();
                }

                class DependencyTreePackageHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x7d153bc*/ DependencyTreePackageHashException(int hash, string message);
                    /*0x7d152c8*/ DependencyTreePackageHashException(int hash, string message, System.Exception inner);
                }

                class DependencyTreeComponentHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x7d153b8*/ DependencyTreeComponentHashException(int hash, string message);
                }

                interface IInitializablePackage
                {
                    /*0x3814a3c*/ System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                }

                interface IInitializablePackageV2 : Unity.Services.Core.Internal.IInitializablePackage
                {
                    /*0x3814a3c*/ System.Threading.Tasks.Task InitializeInstanceAsync(Unity.Services.Core.Internal.CoreRegistry registry);
                }

                interface IServiceComponent
                {
                }

                class MissingComponent : Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ System.Type <IntendedType>k__BackingField;

                    /*0x7d154c0*/ MissingComponent(System.Type intendedType);
                    /*0x7d154b8*/ System.Type get_IntendedType();
                }

                class PackageInitializationInfo
                {
                    /*0x10*/ System.Type PackageType;
                    /*0x18*/ double InitializationTimeInSeconds;

                    /*0x7d12584*/ PackageInitializationInfo();
                }

                interface IPackageRegistry
                {
                    /*0x38148bc*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x3815ed0*/ void RegisterDependency<TComponent>(int packageTypeHash);
                    /*0x3815ed0*/ void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    /*0x3815ed0*/ void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class LockedPackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField;

                    /*0x7d114d0*/ LockedPackageRegistry(Unity.Services.Core.Internal.IPackageRegistry registryToLock);
                    /*0x7d154f0*/ Unity.Services.Core.Internal.IPackageRegistry get_Registry();
                    /*0x7d154f8*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x3815ed0*/ void RegisterDependency<TComponent>(int packageTypeHash);
                    /*0x3815ed0*/ void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    /*0x3815ed0*/ void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class PackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree <Tree>k__BackingField;

                    /*0x7d113f4*/ PackageRegistry(Unity.Services.Core.Internal.DependencyTree tree);
                    /*0x7d15598*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x7d155a0*/ void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    /*0x3910ae8*/ Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    /*0x3815ed0*/ void RegisterDependency<TComponent>(int packageTypeHash);
                    /*0x3815ed0*/ void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    /*0x3815ed0*/ void RegisterProvision<TComponent>(int packageTypeHash);
                    /*0x7d155a8*/ void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash);
                }

                interface IServiceRegistry
                {
                }

                class ServiceRegistry : Unity.Services.Core.Internal.IServiceRegistry
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, object> <ServiceTypeHashToInstance>k__BackingField;

                    /*0x7d116e4*/ ServiceRegistry();
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

                    static /*0x7d156b4*/ Unity.Services.Core.Internal.CoreDiagnostics get_Instance();
                    static /*0x7d156fc*/ void set_Instance(Unity.Services.Core.Internal.CoreDiagnostics value);
                    /*0x7d1575c*/ CoreDiagnostics();
                    /*0x7d15754*/ void set_DiagnosticsComponentProvider(Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider value);
                }

                class CoreMetrics
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreMetrics <Instance>k__BackingField;
                    /*0x10*/ System.Collections.Generic.IDictionary<System.Type, Unity.Services.Core.Telemetry.Internal.IMetrics> <AllPackageMetrics>k__BackingField;

                    static /*0x7d157e4*/ Unity.Services.Core.Internal.CoreMetrics get_Instance();
                    static /*0x7d1582c*/ void set_Instance(Unity.Services.Core.Internal.CoreMetrics value);
                    /*0x7d15884*/ CoreMetrics();
                }

                class UnityServicesInitializer
                {
                    static /*0x7d1590c*/ void CreateStaticInstance();
                    static /*0x7d15cd0*/ void EnableServicesInitializationAsync();
                    static /*0x7d15d64*/ Unity.Services.Core.IUnityServices CreateInstance(string servicesId);

                    struct <EnableServicesInitializationAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7d15ebc*/ void MoveNext();
                        /*0x7d161d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                    /*0x7d15c70*/ UnityServicesInternal(Unity.Services.Core.Internal.CoreRegistry registry, Unity.Services.Core.Internal.CoreMetrics coreMetrics, Unity.Services.Core.Internal.CoreDiagnostics coreDiagnostics);
                    /*0x7d161dc*/ Unity.Services.Core.ServicesInitializationState get_State();
                    /*0x7d161e4*/ void set_State(Unity.Services.Core.ServicesInitializationState value);
                    /*0x7d161ec*/ Unity.Services.Core.Internal.CoreRegistry get_Registry();
                    /*0x7d161f4*/ bool HasRequestedInitialization();
                    /*0x7d16204*/ System.Threading.Tasks.Task InitializeServicesAsync();
                    /*0x7d15eb0*/ void EnableInitialization();
                    /*0x7d160ec*/ System.Threading.Tasks.Task EnableInitializationAsync();

                    class <>c__DisplayClass33_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;
                        /*0x18*/ System.Collections.Generic.List<int> sortedPackageTypeHashes;
                        /*0x20*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x28*/ System.Diagnostics.Stopwatch initStopwatch;

                        /*0x7d162ec*/ <>c__DisplayClass33_0();
                        /*0x7d162f4*/ void <InitializeServicesAsync>g__SortPackages|0();
                        /*0x7d16320*/ System.Threading.Tasks.Task <InitializeServicesAsync>g__InitializePackagesAsync|1();
                        /*0x7d16404*/ void <InitializeServicesAsync>g__FailServicesInitialization|2(System.Exception reason);
                        /*0x7d16480*/ void <InitializeServicesAsync>g__SucceedServicesInitialization|3();

                        struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>4__this;
                            /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<Unity.Services.Core.Internal.PackageInitializationInfo>> <>u__1;

                            /*0x7d16508*/ void MoveNext();
                            /*0x7d1677c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <EnableInitializationAsync>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7d167e4*/ void MoveNext();
                        /*0x7d16a18*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <InitializeServicesAsync>d__33 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>8__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0x7d16a80*/ void MoveNext();
                        /*0x7d17008*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DictionaryExtensions
                {
                    static /*0x3910ae8*/ TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
                    static /*0x3825b78*/ bool ValueEquals<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y);
                    static /*0x3910ae8*/ bool ValueEquals<TKey, TValue, TComparer>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y, TComparer valueComparer);
                }

                class UnityWebRequestUtils
                {
                    static /*0x7d17070*/ bool HasSucceeded(UnityEngine.Networking.UnityWebRequest self);
                    static /*0x7d17094*/ System.Threading.Tasks.Task<string> GetTextAsync(string uri);

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Threading.Tasks.TaskCompletionSource<string> completionSource;

                        /*0x7d171d8*/ <>c__DisplayClass2_0();
                        /*0x7d171e0*/ void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(UnityEngine.AsyncOperation rawOperation);
                    }
                }

                namespace Serialization
                {
                    interface IJsonSerializer
                    {
                        /*0x3910ae8*/ T DeserializeObject<T>(string value);
                    }

                    class NewtonsoftSerializer : Unity.Services.Core.Internal.Serialization.IJsonSerializer
                    {
                        /*0x10*/ Newtonsoft.Json.JsonSerializer m_Serializer;

                        /*0x7d17598*/ NewtonsoftSerializer(Newtonsoft.Json.JsonSerializerSettings settings);
                        /*0x7d175d8*/ NewtonsoftSerializer(Newtonsoft.Json.JsonSerializer serializer);
                        /*0x3910ae8*/ T DeserializeObject<T>(string value);
                    }
                }
            }
        }
    }
}
