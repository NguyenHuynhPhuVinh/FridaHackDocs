class <Module>
{
}

namespace Unity
{
    namespace Services
    {
        namespace Authentication
        {
            namespace Internal
            {
                interface IPlayerId : Unity.Services.Core.Internal.IServiceComponent
                {
                    string get_PlayerId();
                }
            }
        }

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
                        void SendDiagnostic(string name, string message, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IDiagnosticsComponentProvider
                    {
                        System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> CreateDiagnosticsComponents();
                        System.Threading.Tasks.Task<string> GetSerializedProjectConfigurationAsync();
                    }

                    interface IDiagnosticsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        Unity.Services.Core.Telemetry.Internal.IDiagnostics Create(string packageName);
                    }

                    interface IMetrics
                    {
                        void SendGaugeMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendHistogramMetric(string name, double time, System.Collections.Generic.IDictionary<string, string> tags);
                        void SendSumMetric(string name, double value, System.Collections.Generic.IDictionary<string, string> tags);
                    }

                    interface IMetricsFactory : Unity.Services.Core.Internal.IServiceComponent
                    {
                        Unity.Services.Core.Telemetry.Internal.IMetrics Create(string packageName);
                    }
                }
            }

            namespace Scheduler
            {
                namespace Internal
                {
                    interface IActionScheduler : Unity.Services.Core.Internal.IServiceComponent
                    {
                        long ScheduleAction(System.Action action, double delaySeconds);
                        void CancelAction(long actionId);
                    }
                }
            }

            namespace Environments
            {
                namespace Internal
                {
                    interface IEnvironments : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string get_Current();
                    }
                }
            }

            namespace Device
            {
                namespace Internal
                {
                    interface IInstallationId : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string GetOrCreateIdentifier();
                    }
                }
            }

            namespace Configuration
            {
                namespace Internal
                {
                    interface ICloudProjectId : Unity.Services.Core.Internal.IServiceComponent
                    {
                        string GetCloudProjectId();
                    }

                    interface IProjectConfiguration : Unity.Services.Core.Internal.IServiceComponent
                    {
                        bool GetBool(string key, bool defaultValue);
                        int GetInt(string key, int defaultValue);
                        string GetString(string key, string defaultValue);
                    }
                }
            }

            namespace Internal
            {
                class AsyncOperationBase : UnityEngine.CustomYieldInstruction, Unity.Services.Core.Internal.IAsyncOperation, System.Collections.IEnumerator, System.Runtime.CompilerServices.INotifyCompletion
                {
                    /*0x10*/ System.Action<Unity.Services.Core.Internal.IAsyncOperation> m_CompletedCallback;

                    /*0x2a4619c*/ AsyncOperationBase();
                    /*0x2a45ef0*/ bool get_keepWaiting();
                    bool get_IsCompleted();
                    /*0x2a45f14*/ bool get_IsDone();
                    Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    System.Exception get_Exception();
                    void GetResult();
                    Unity.Services.Core.Internal.AsyncOperationBase GetAwaiter();
                    /*0x2a45f20*/ void add_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    /*0x2a45fe8*/ void remove_Completed(System.Action<Unity.Services.Core.Internal.IAsyncOperation> value);
                    /*0x2a46064*/ void DidComplete();
                    /*0x2a460c4*/ void OnCompleted(System.Action continuation);

                    class <>c__DisplayClass17_0
                    {
                        /*0x10*/ System.Action continuation;

                        /*0x2a46194*/ <>c__DisplayClass17_0();
                        /*0x2a4ac38*/ void <OnCompleted>b__0(Unity.Services.Core.Internal.IAsyncOperation op);
                    }
                }

                enum AsyncOperationStatus
                {
                    None = 0,
                    InProgress = 1,
                    Succeeded = 2,
                    Failed = 3,
                    Cancelled = 4,
                }

                interface IAsyncOperation : System.Collections.IEnumerator
                {
                }

                class TaskAsyncOperation : Unity.Services.Core.Internal.AsyncOperationBase, System.Runtime.CompilerServices.INotifyCompletion
                {
                    static /*0x0*/ System.Threading.Tasks.TaskScheduler Scheduler;
                    /*0x18*/ System.Threading.Tasks.Task m_Task;

                    static /*0x2a4a45c*/ Unity.Services.Core.Internal.TaskAsyncOperation Run(System.Action action);
                    static /*0x2a4a3dc*/ void SetScheduler();
                    /*0x2a4a240*/ TaskAsyncOperation(System.Threading.Tasks.Task task);
                    /*0x2a4a188*/ bool get_IsCompleted();
                    /*0x2a4a1a4*/ Unity.Services.Core.Internal.AsyncOperationStatus get_Status();
                    /*0x2a4a218*/ System.Exception get_Exception();
                    /*0x2a4a238*/ void GetResult();
                    /*0x2a4a23c*/ Unity.Services.Core.Internal.AsyncOperationBase GetAwaiter();

                    class <>c
                    {
                        static /*0x0*/ Unity.Services.Core.Internal.TaskAsyncOperation.<> <>9;
                        static /*0x8*/ System.Action<System.Threading.Tasks.Task, object> <>9__10_0;

                        static /*0x2a4bb90*/ <>c();
                        /*0x2a4bbf0*/ <>c();
                        /*0x2a4bbf8*/ void <.ctor>b__10_0(System.Threading.Tasks.Task t, object state);
                    }
                }

                class CoreLogger
                {
                    static /*0x2a46b64*/ void LogWarning(object message);
                    static /*0x2a46ca8*/ void LogError(object message);
                    static /*0x2a46a14*/ void LogException(System.Exception exception);
                }

                class CircularDependencyException : Unity.Services.Core.ServicesInitializationException
                {
                    /*0x2a461a4*/ CircularDependencyException();
                }

                class ComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> <ComponentTypeHashToInstance>k__BackingField;

                    /*0x2a461b4*/ ComponentRegistry(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                    /*0x2a461ac*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> get_ComponentTypeHashToInstance();
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    /*0x2a461e0*/ bool IsComponentTypeRegistered(int componentTypeHash);
                    /*0x2a462ac*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                interface IComponentRegistry
                {
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                class LockedComponentRegistry : Unity.Services.Core.Internal.IComponentRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.IComponentRegistry <Registry>k__BackingField;

                    /*0x2a47604*/ LockedComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry registryToLock);
                    /*0x2a49ea4*/ Unity.Services.Core.Internal.IComponentRegistry get_Registry();
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    /*0x2a49eac*/ void ResetProvidedComponents(System.Collections.Generic.IDictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentTypeHashToInstance);
                }

                struct CoreRegistration
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry m_Registry;
                    /*0x18*/ int m_PackageHash;

                    /*0xb1f84c*/ CoreRegistration(Unity.Services.Core.Internal.IPackageRegistry registry, int packageHash);
                    Unity.Services.Core.Internal.CoreRegistration DependsOn<T>();
                    Unity.Services.Core.Internal.CoreRegistration OptionallyDependsOn<T>();
                    Unity.Services.Core.Internal.CoreRegistration ProvidesComponent<T>();
                }

                class CoreRegistry
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreRegistry <Instance>k__BackingField;
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <PackageRegistry>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Internal.IComponentRegistry <ComponentRegistry>k__BackingField;

                    static /*0x2a47140*/ Unity.Services.Core.Internal.CoreRegistry get_Instance();
                    static /*0x2a4718c*/ void set_Instance(Unity.Services.Core.Internal.CoreRegistry value);
                    /*0x2a471fc*/ CoreRegistry();
                    /*0x2a471dc*/ Unity.Services.Core.Internal.IPackageRegistry get_PackageRegistry();
                    /*0x2a471e4*/ void set_PackageRegistry(Unity.Services.Core.Internal.IPackageRegistry value);
                    /*0x2a471ec*/ Unity.Services.Core.Internal.IComponentRegistry get_ComponentRegistry();
                    /*0x2a471f4*/ void set_ComponentRegistry(Unity.Services.Core.Internal.IComponentRegistry value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterServiceComponent<TComponent>(TComponent component);
                    TComponent GetServiceComponent<TComponent>();
                    /*0x2a474a8*/ void LockPackageRegistration();
                    /*0x2a4756c*/ void LockComponentRegistration();
                }

                class CoreRegistryInitializer
                {
                    /*0x10*/ Unity.Services.Core.Internal.CoreRegistry m_Registry;
                    /*0x18*/ System.Collections.Generic.List<int> m_SortedPackageTypeHashes;

                    /*0x2a47630*/ CoreRegistryInitializer(Unity.Services.Core.Internal.CoreRegistry registry, System.Collections.Generic.List<int> sortedPackageTypeHashes);
                    /*0x2a47668*/ System.Threading.Tasks.Task InitializeRegistryAsync();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x18*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;
                        /*0x20*/ System.Collections.Generic.List<System.Exception> failureReasons;

                        /*0x2a4b3dc*/ <>c__DisplayClass3_0();
                        /*0x2a4b3e4*/ System.Threading.Tasks.Task <InitializeRegistryAsync>g__InitializePackageAtIndexAsync|0(int index);
                        /*0x2a4b508*/ void <InitializeRegistryAsync>g__Fail|1();

                        struct <<InitializeRegistryAsync>g__InitializePackageAtIndexAsync|0>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>4__this;
                            /*0x38*/ int index;
                            /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0xb1f960*/ void MoveNext();
                            /*0xb1f968*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <InitializeRegistryAsync>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreRegistryInitializer <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.CoreRegistryInitializer.<> <>8__1;
                        /*0x40*/ int <i>5__2;
                        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb1f910*/ void MoveNext();
                        /*0xb1f918*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DependencyTree
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> PackageTypeHashToInstance;
                    /*0x18*/ System.Collections.Generic.Dictionary<int, int> ComponentTypeHashToPackageTypeHash;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> PackageTypeHashToComponentTypeHashDependencies;
                    /*0x28*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> ComponentTypeHashToInstance;

                    /*0x2a47338*/ DependencyTree();
                    /*0x2a4776c*/ DependencyTree(System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IInitializablePackage> packageToInstance, System.Collections.Generic.Dictionary<int, int> componentToPackage, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<int>> packageToComponentDependencies, System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.IServiceComponent> componentToInstance);
                }

                class DependencyTreeSortFailedException : System.Exception
                {
                    static /*0x2a49db8*/ string CreateExceptionMessage(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                    /*0x2a4959c*/ DependencyTreeSortFailedException(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target, System.Exception inner);
                }

                class DependencyTreeExtensions
                {
                    static /*0x2a47834*/ string ToJson(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> order);
                    static /*0x2a48a94*/ bool IsOptional(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x2a48b18*/ bool IsProvided(Unity.Services.Core.Internal.DependencyTree tree, int componentTypeHash);
                    static /*0x2a47fe8*/ Newtonsoft.Json.Linq.JObject GetPackageJObject(Unity.Services.Core.Internal.DependencyTree tree, int packageHash);
                    static /*0x2a48728*/ Newtonsoft.Json.Linq.JObject GetComponentJObject(Unity.Services.Core.Internal.DependencyTree tree, int componentHash);
                    static /*0x2a48b80*/ string GetComponentIdentifier(Unity.Services.Core.Internal.IServiceComponent component);
                }

                struct DependencyTreeInitializeOrderSorter
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree Tree;
                    /*0x18*/ System.Collections.Generic.ICollection<int> Target;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark> m_PackageTypeHashExplorationHistory;

                    /*0xb1f894*/ DependencyTreeInitializeOrderSorter(Unity.Services.Core.Internal.DependencyTree tree, System.Collections.Generic.ICollection<int> target);
                    /*0xb1f8a0*/ void SortRegisteredPackagesIntoTarget();
                    /*0xb1f8a8*/ void RemoveUnprovidedOptionalDependenciesFromTree();
                    /*0xb1f8b0*/ void RemoveUnprovidedOptionalDependencies(System.Collections.Generic.IList<int> dependencyTypeHashes);
                    /*0xb1f8bc*/ void SortTreeThrough(int packageTypeHash);
                    /*0xb1f8c4*/ void SortTreeThrough(System.Collections.Generic.IEnumerable<int> dependencyTypeHashes);
                    /*0xb1f8cc*/ void MarkPackage(int packageTypeHash, Unity.Services.Core.Internal.DependencyTreeInitializeOrderSorter.ExplorationMark mark);
                    /*0xb1f8d4*/ System.Collections.Generic.IReadOnlyCollection<int> GetPackageTypeHashes();
                    /*0xb1f8dc*/ int GetPackageTypeHashFor(int componentTypeHash);
                    /*0xb1f8e4*/ System.Collections.Generic.IEnumerable<int> GetDependencyTypeHashesFor(int packageTypeHash);

                    enum ExplorationMark
                    {
                        None = 0,
                        Viewed = 1,
                        Sorted = 2,
                    }
                }

                class HashException : System.Exception
                {
                    /*0x88*/ int <Hash>k__BackingField;

                    /*0x2a477bc*/ HashException(int hash, string message);
                    /*0x2a49d28*/ HashException(int hash, string message, System.Exception inner);
                    /*0x2a49e9c*/ int get_Hash();
                }

                class DependencyTreePackageHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x2a49d24*/ DependencyTreePackageHashException(int hash, string message);
                    /*0x2a49c30*/ DependencyTreePackageHashException(int hash, string message, System.Exception inner);
                }

                class DependencyTreeComponentHashException : Unity.Services.Core.Internal.HashException
                {
                    /*0x2a477b8*/ DependencyTreeComponentHashException(int hash, string message);
                }

                interface IInitializablePackage
                {
                    System.Threading.Tasks.Task Initialize(Unity.Services.Core.Internal.CoreRegistry registry);
                }

                interface IServiceComponent
                {
                }

                class MissingComponent : Unity.Services.Core.Internal.IServiceComponent
                {
                    /*0x10*/ System.Type <IntendedType>k__BackingField;

                    /*0x2a4a07c*/ MissingComponent(System.Type intendedType);
                    /*0x2a4a074*/ System.Type get_IntendedType();
                }

                interface IPackageRegistry
                {
                    Unity.Services.Core.Internal.DependencyTree get_Tree();
                    void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterDependency<TComponent>(int packageTypeHash);
                    void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class LockedPackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.IPackageRegistry <Registry>k__BackingField;

                    /*0x2a47540*/ LockedPackageRegistry(Unity.Services.Core.Internal.IPackageRegistry registryToLock);
                    /*0x2a49f00*/ Unity.Services.Core.Internal.IPackageRegistry get_Registry();
                    /*0x2a49f08*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x2a49fb4*/ void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterDependency<TComponent>(int packageTypeHash);
                    void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    void RegisterProvision<TComponent>(int packageTypeHash);
                }

                class PackageRegistry : Unity.Services.Core.Internal.IPackageRegistry
                {
                    /*0x10*/ Unity.Services.Core.Internal.DependencyTree <Tree>k__BackingField;

                    /*0x2a4747c*/ PackageRegistry(Unity.Services.Core.Internal.DependencyTree tree);
                    /*0x2a4a0a8*/ Unity.Services.Core.Internal.DependencyTree get_Tree();
                    /*0x2a4a0b0*/ void set_Tree(Unity.Services.Core.Internal.DependencyTree value);
                    Unity.Services.Core.Internal.CoreRegistration RegisterPackage<TPackage>(TPackage package);
                    void RegisterDependency<TComponent>(int packageTypeHash);
                    void RegisterOptionalDependency<TComponent>(int packageTypeHash);
                    void RegisterProvision<TComponent>(int packageTypeHash);
                    /*0x2a4a0b8*/ void AddComponentDependencyToPackage(int componentTypeHash, int packageTypeHash);
                }

                class CoreDiagnostics
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreDiagnostics <Instance>k__BackingField;
                    /*0x10*/ System.Collections.Generic.IDictionary<string, string> <CoreTags>k__BackingField;
                    /*0x18*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider <DiagnosticsComponentProvider>k__BackingField;
                    /*0x20*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics <Diagnostics>k__BackingField;

                    static /*0x2a46340*/ Unity.Services.Core.Internal.CoreDiagnostics get_Instance();
                    static /*0x2a4638c*/ void set_Instance(Unity.Services.Core.Internal.CoreDiagnostics value);
                    static /*0x2a469f4*/ void OnSendFailed(System.Threading.Tasks.Task failedSendTask);
                    /*0x2a46b5c*/ CoreDiagnostics();
                    /*0x2a46330*/ System.Collections.Generic.IDictionary<string, string> get_CoreTags();
                    /*0x2a46338*/ void set_CoreTags(System.Collections.Generic.IDictionary<string, string> value);
                    /*0x2a463dc*/ Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider get_DiagnosticsComponentProvider();
                    /*0x2a463e4*/ void set_DiagnosticsComponentProvider(Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider value);
                    /*0x2a463ec*/ Unity.Services.Core.Telemetry.Internal.IDiagnostics get_Diagnostics();
                    /*0x2a463f4*/ void set_Diagnostics(Unity.Services.Core.Telemetry.Internal.IDiagnostics value);
                    /*0x2a463fc*/ System.Threading.Tasks.Task<Unity.Services.Core.Telemetry.Internal.IDiagnostics> GetOrCreateDiagnostics();
                    /*0x2a4653c*/ void SetProjectConfiguration(string serializedProjectConfig);
                    /*0x2a46654*/ void SendCircularDependencyDiagnostics(System.Exception exception);
                    /*0x2a46844*/ void SendCorePackageInitDiagnostics(System.Exception exception);
                    /*0x2a4691c*/ void SendOperateServicesInitDiagnostics(System.Exception exception);
                    /*0x2a4672c*/ System.Threading.Tasks.Task SendCoreDiagnostics(string diagnosticName, System.Exception exception);

                    struct <GetOrCreateDiagnostics>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Unity.Services.Core.Telemetry.Internal.IDiagnostics> <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreDiagnostics <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Telemetry.Internal.IDiagnosticsFactory> <>u__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__2;

                        /*0xb1f8ec*/ void MoveNext();
                        /*0xb1f8f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <SendCoreDiagnostics>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.CoreDiagnostics <>4__this;
                        /*0x38*/ string diagnosticName;
                        /*0x40*/ System.Exception exception;
                        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<Unity.Services.Core.Telemetry.Internal.IDiagnostics> <>u__1;

                        /*0xb1f8fc*/ void MoveNext();
                        /*0xb1f904*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class CoreMetrics
                {
                    static /*0x0*/ Unity.Services.Core.Internal.CoreMetrics <Instance>k__BackingField;
                    /*0x10*/ Unity.Services.Core.Telemetry.Internal.IMetrics <Metrics>k__BackingField;

                    static /*0x2a46dec*/ Unity.Services.Core.Internal.CoreMetrics get_Instance();
                    static /*0x2a46e38*/ void set_Instance(Unity.Services.Core.Internal.CoreMetrics value);
                    /*0x2a4712c*/ CoreMetrics();
                    /*0x2a46e88*/ Unity.Services.Core.Telemetry.Internal.IMetrics get_Metrics();
                    /*0x2a46e90*/ void set_Metrics(Unity.Services.Core.Telemetry.Internal.IMetrics value);
                    /*0x2a46e98*/ void SendAllPackagesInitSuccessMetric();
                    /*0x2a46f6c*/ void SendAllPackagesInitTimeMetric(double initTimeSeconds);
                    /*0x2a4704c*/ void SendCorePackageInitTimeMetric(double initTimeSeconds);
                }

                class UnityServicesInitializer
                {
                    static /*0x2a4a4f8*/ void CreateStaticInstance();
                    static /*0x2a4a7b4*/ void EnableServicesInitializationAsync();

                    struct <EnableServicesInitializationAsync>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb1f924*/ void MoveNext();
                        /*0xb1f92c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class UnityServicesInternal : Unity.Services.Core.IUnityServices
                {
                    /*0x10*/ Unity.Services.Core.ServicesInitializationState <State>k__BackingField;
                    /*0x18*/ Unity.Services.Core.InitializationOptions <Options>k__BackingField;
                    /*0x20*/ bool CanInitialize;
                    /*0x28*/ System.Threading.Tasks.TaskCompletionSource<object> m_Initialization;
                    /*0x30*/ Unity.Services.Core.Internal.CoreRegistry <Registry>k__BackingField;
                    /*0x38*/ Unity.Services.Core.Internal.CoreMetrics <Metrics>k__BackingField;
                    /*0x40*/ Unity.Services.Core.Internal.CoreDiagnostics <Diagnostics>k__BackingField;

                    /*0x2a4a774*/ UnityServicesInternal(Unity.Services.Core.Internal.CoreRegistry registry, Unity.Services.Core.Internal.CoreMetrics metrics, Unity.Services.Core.Internal.CoreDiagnostics diagnostics);
                    /*0x2a4a85c*/ Unity.Services.Core.ServicesInitializationState get_State();
                    /*0x2a4a864*/ void set_State(Unity.Services.Core.ServicesInitializationState value);
                    /*0x2a4a86c*/ Unity.Services.Core.InitializationOptions get_Options();
                    /*0x2a4a874*/ Unity.Services.Core.Internal.CoreRegistry get_Registry();
                    /*0x2a4a87c*/ Unity.Services.Core.Internal.CoreMetrics get_Metrics();
                    /*0x2a4a884*/ Unity.Services.Core.Internal.CoreDiagnostics get_Diagnostics();
                    /*0x2a4a88c*/ bool HasRequestedInitialization();
                    /*0x2a4a89c*/ System.Threading.Tasks.Task InitializeServicesAsync();
                    /*0x2a4a9b8*/ System.Threading.Tasks.Task EnableInitializationAsync();

                    class <>c__DisplayClass22_0
                    {
                        /*0x10*/ Unity.Services.Core.Internal.DependencyTree dependencyTree;
                        /*0x18*/ System.Collections.Generic.List<int> sortedPackageTypeHashes;
                        /*0x20*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x28*/ System.Diagnostics.Stopwatch initStopwatch;

                        /*0x2a4be80*/ <>c__DisplayClass22_0();
                        /*0x2a4be88*/ void <InitializeServicesAsync>g__SortPackages|0();
                        /*0x2a4beb4*/ System.Threading.Tasks.Task <InitializeServicesAsync>g__InitializePackagesAsync|1();
                        /*0x2a4bfb8*/ void <InitializeServicesAsync>g__FailServicesInitialization|2(System.Exception reason);
                        /*0x2a4c0b8*/ void <InitializeServicesAsync>g__SucceedServicesInitialization|3();

                        struct <<InitializeServicesAsync>g__InitializePackagesAsync|1>d : System.Runtime.CompilerServices.IAsyncStateMachine
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                            /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>4__this;
                            /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                            /*0xb1f974*/ void MoveNext();
                            /*0xb1f97c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                        }
                    }

                    struct <InitializeServicesAsync>d__22 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ Unity.Services.Core.Internal.UnityServicesInternal.<> <>8__1;
                        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb1f94c*/ void MoveNext();
                        /*0xb1f954*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }

                    struct <EnableInitializationAsync>d__23 : System.Runtime.CompilerServices.IAsyncStateMachine
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
                        /*0x30*/ Unity.Services.Core.Internal.UnityServicesInternal <>4__this;
                        /*0x38*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

                        /*0xb1f938*/ void MoveNext();
                        /*0xb1f940*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
                    }
                }

                class DictionaryExtensions
                {
                    static TDictionary MergeAllowOverride<TDictionary, TKey, TValue>(TDictionary self, System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
                    static bool ValueEquals<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y);
                    static bool ValueEquals<TKey, TValue, TComparer>(System.Collections.Generic.IDictionary<TKey, TValue> x, System.Collections.Generic.IDictionary<TKey, TValue> y, TComparer valueComparer);
                }

                class UnityWebRequestUtils
                {
                    static /*0x2a4aabc*/ bool HasSucceeded(UnityEngine.Networking.UnityWebRequest self);
                    static /*0x2a4aae4*/ System.Threading.Tasks.Task<string> GetTextAsync(string uri);

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ System.Threading.Tasks.TaskCompletionSource<string> completionSource;

                        /*0x2a4ac30*/ <>c__DisplayClass2_0();
                        /*0x2a4c914*/ void <GetTextAsync>g__CompleteFetchTaskOnRequestCompleted|0(UnityEngine.AsyncOperation rawOperation);
                    }
                }
            }
        }
    }
}
