class <Module>
{
}

class DelegateList<T>
{
    /*0x0*/ System.Func<System.Action<T>, System.Collections.Generic.LinkedListNode<System.Action<T>>> m_acquireFunc;
    /*0x0*/ System.Action<System.Collections.Generic.LinkedListNode<System.Action<T>>> m_releaseFunc;
    /*0x0*/ System.Collections.Generic.LinkedList<System.Action<T>> m_callbacks;
    /*0x0*/ bool m_invoking;

    static /*0x1f327a0*/ DelegateList<T> CreateWithGlobalCache();
    /*0x1f30ff0*/ DelegateList(System.Func<System.Action<T>, System.Collections.Generic.LinkedListNode<System.Action<T>>> acquireFunc, System.Action<System.Collections.Generic.LinkedListNode<System.Action<T>>> releaseFunc);
    /*0x1f2ffc8*/ int get_Count();
    /*0x1f30ebc*/ void Add(System.Action<T> action);
    /*0x1f30ebc*/ void Remove(System.Action<T> action);
    /*0x1ffc854*/ void Invoke(T res);
    /*0x1f309e4*/ void Clear();
}

class ListWithEvents<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
    /*0x0*/ System.Collections.Generic.List<T> m_List;
    /*0x0*/ System.Action<T> OnElementAdded;
    /*0x0*/ System.Action<T> OnElementRemoved;

    /*0x1f309e4*/ ListWithEvents();
    /*0x1f30ebc*/ void add_OnElementAdded(System.Action<T> value);
    /*0x1f30ebc*/ void remove_OnElementAdded(System.Action<T> value);
    /*0x1f30ebc*/ void add_OnElementRemoved(System.Action<T> value);
    /*0x1f30ebc*/ void remove_OnElementRemoved(System.Action<T> value);
    /*0x1ffc854*/ void InvokeAdded(T element);
    /*0x1ffc854*/ void InvokeRemoved(T element);
    /*0x1ffc854*/ T get_Item(int index);
    /*0x1ffc854*/ void set_Item(int index, T value);
    /*0x1f2ffc8*/ int get_Count();
    /*0x1f2fe14*/ bool get_IsReadOnly();
    /*0x1ffc854*/ void Add(T item);
    /*0x1f309e4*/ void Clear();
    /*0x1ffc854*/ bool Contains(T item);
    /*0x1f30ee8*/ void CopyTo(T[] array, int arrayIndex);
    /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
    /*0x1ffc854*/ int IndexOf(T item);
    /*0x1ffc854*/ void Insert(int index, T item);
    /*0x1ffc854*/ bool Remove(T item);
    /*0x1f30b78*/ void RemoveAt(int index);
    /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
}

class MonoBehaviourCallbackHooks : UnityEngine.ResourceManagement.Util.ComponentSingleton<MonoBehaviourCallbackHooks>
{
    /*0x20*/ System.Action<float> m_OnUpdateDelegate;

    /*0x3c9a660*/ MonoBehaviourCallbackHooks();
    /*0x3c9a494*/ void add_OnUpdateDelegate(System.Action<float> value);
    /*0x3c9a53c*/ void remove_OnUpdateDelegate(System.Action<float> value);
    /*0x3c9a5e4*/ string GetGameObjectName();
    /*0x3c9a624*/ void Update();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c9a6a8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c9a79c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    namespace ResourceManagement
    {
        class ChainOperation<TObject, TObjectDependency> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>
        {
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> m_DepOp;
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> m_WrappedOp;
            /*0x0*/ System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_Callback;
            /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;
            /*0x0*/ bool m_isWrappedOpEverValid;
            /*0x0*/ bool m_isDepOpEverValid;
            /*0x0*/ bool m_ReleaseDependenciesOnFailure;

            /*0x1f309e4*/ ChainOperation();
            /*0x1f30214*/ string get_DebugName();
            /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
            /*0x1ffc854*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x1f309e4*/ void Execute();
            /*0x1ffc854*/ void OnWrappedCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> x);
            /*0x1f309e4*/ void Destroy();
            /*0x1f309e4*/ void ReleaseDependencies();
            UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
            /*0x1f30804*/ float get_Progress();
        }

        class ChainOperationTypelessDepedency<TObject> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>
        {
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle m_DepOp;
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> m_WrappedOp;
            /*0x0*/ System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_Callback;
            /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;
            /*0x0*/ bool m_ReleaseDependenciesOnFailure;

            /*0x1f309e4*/ ChainOperationTypelessDepedency();
            /*0x1f30214*/ string get_DebugName();
            /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
            /*0x1ffc854*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x1f309e4*/ void Execute();
            /*0x1ffc854*/ void OnWrappedCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> x);
            /*0x1f309e4*/ void Destroy();
            /*0x1f309e4*/ void ReleaseDependencies();
            UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
            /*0x1f30804*/ float get_Progress();
        }

        class WebRequestQueueOperationMetricHooks
        {
            static string TypeName = "WebRequestQueueOperation";

            static /*0x3c9a7a4*/ void StartMetricQueued(UnityEngine.ResourceManagement.WebRequestQueueOperation queueOperation);
            static /*0x3c9a9b4*/ void EndMetricQueued(UnityEngine.ResourceManagement.WebRequestQueueOperation queueOperation);
        }

        class ResourceManager : System.IDisposable
        {
            static /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> <ExceptionHandler>k__BackingField;
            static /*0x8*/ int s_GroupOperationTypeHash;
            static /*0xc*/ int s_InstanceOperationTypeHash;
            /*0x10*/ bool postProfilerEvents;
            /*0x18*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> <InternalIdTransformFunc>k__BackingField;
            /*0x20*/ bool CallbackHooksEnabled;
            /*0x28*/ ListWithEvents<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider> m_ResourceProviders;
            /*0x30*/ UnityEngine.ResourceManagement.Util.IAllocationStrategy m_allocator;
            /*0x38*/ ListWithEvents<UnityEngine.ResourceManagement.IUpdateReceiver> m_UpdateReceivers;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.IUpdateReceiver> m_UpdateReceiversToRemove;
            /*0x48*/ bool m_UpdatingReceivers;
            /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider> m_providerMap;
            /*0x58*/ System.Collections.Generic.Dictionary<int, UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_AssetOperationCache;
            /*0x60*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceManager.InstanceOperation> m_TrackedInstanceOperations;
            /*0x68*/ DelegateList<float> m_UpdateCallbacks;
            /*0x70*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_DeferredCompleteCallbacks;
            /*0x78*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler;
            /*0x80*/ System.Action<UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext> m_diagnosticsHandler;
            /*0x88*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_ReleaseOpNonCached;
            /*0x90*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_ReleaseOpCached;
            /*0x98*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_ReleaseInstanceOp;
            /*0xa0*/ UnityEngine.Networking.CertificateHandler <CertificateHandlerInstance>k__BackingField;
            /*0xa8*/ bool m_RegisteredForCallbacks;
            /*0xb0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> m_ProviderOperationTypeCache;
            /*0xb8*/ UnityEngine.ResourceManagement.EA.IExternalAllocationReporter _externalAllocationReporter;

            static /*0x3c9f340*/ ResourceManager();
            static /*0x3c9abc4*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> get_ExceptionHandler();
            static /*0x3c9ac1c*/ void set_ExceptionHandler(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> value);
            /*0x3c9af8c*/ ResourceManager(UnityEngine.ResourceManagement.Util.IAllocationStrategy alloc);
            /*0x3c9ac84*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            /*0x3c9ac8c*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            /*0x3c9ac94*/ string TransformInternalId(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x3c9ad70*/ int get_OperationCacheCount();
            /*0x3c9adc0*/ int get_InstanceOperationCount();
            /*0x3c9ae08*/ void AddUpdateReceiver(UnityEngine.ResourceManagement.IUpdateReceiver receiver);
            /*0x3c9ae70*/ void RemoveUpdateReciever(UnityEngine.ResourceManagement.IUpdateReceiver receiver);
            /*0x3c9af64*/ UnityEngine.ResourceManagement.Util.IAllocationStrategy get_Allocator();
            /*0x3c9af6c*/ void set_Allocator(UnityEngine.ResourceManagement.Util.IAllocationStrategy value);
            /*0x3c9af74*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider> get_ResourceProviders();
            /*0x3c9af7c*/ UnityEngine.Networking.CertificateHandler get_CertificateHandlerInstance();
            /*0x3c9af84*/ void set_CertificateHandlerInstance(UnityEngine.Networking.CertificateHandler value);
            /*0x3c9b614*/ void OnObjectAdded(object obj);
            /*0x3c9b688*/ void OnObjectRemoved(object obj);
            /*0x3c9b6fc*/ void RegisterForCallbacks();
            /*0x3c9b7c4*/ void ClearDiagnosticsCallback();
            /*0x3c9b7ec*/ void ClearDiagnosticCallbacks();
            /*0x3c9b814*/ void UnregisterDiagnosticCallback(System.Action<UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext> func);
            /*0x3c9b910*/ void RegisterDiagnosticCallback(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventType, int, object> func);
            /*0x3c9b918*/ void RegisterDiagnosticCallback(System.Action<UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext> func);
            /*0x3c9b9c0*/ void PostDiagnosticEvent(UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext context);
            /*0x3c9bae0*/ UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider GetResourceProvider(System.Type t, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x3c9bf24*/ System.Type GetDefaultTypeForLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x3c9c058*/ int CalculateLocationsHash(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Type t);
            /*0x3c9c460*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle ProvideResource(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Type desiredType, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> ProvideResource<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> StartOperation<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> operation, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency);
            /*0x3c9d448*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle StartOperation(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation operation, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency);
            /*0x3c9d5ac*/ void OnInstanceOperationDestroy(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation o);
            /*0x3c9d6fc*/ void OnOperationDestroyNonCached(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation o);
            /*0x3c9d7d0*/ void OnOperationDestroyCached(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation o);
            /*0x1ffc854*/ T CreateOperation<T>(System.Type actualType, int typeHash, int operationHash, System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> onDestroyAction);
            /*0x3c9d9cc*/ void AddOperationToCache(int hash, UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation operation);
            /*0x3c9d948*/ bool RemoveOperationFromCache(int hash);
            /*0x3c9da4c*/ bool IsOperationCached(int hash);
            /*0x3c9dab8*/ int CachedOperationCount();
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure);
            /*0x3c9db08*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3c9dbcc*/ void Acquire(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3c9dcb0*/ UnityEngine.ResourceManagement.AsyncOperations.GroupOperation AcquireGroupOpFromCache(int hash);
            UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> CreateGroupOperation<T>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> CreateGroupOperation<T>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool allowFailedDependencies);
            /*0x3c9ddf0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> CreateGenericGroupOperation(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> operations, bool releasedCachedOpOnComplete);
            /*0x3c9cdd4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> ProvideResourceGroupCached(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, int groupHash, System.Type desiredType, System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> callback, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> ProvideResources<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> ProvideResources<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool releaseDependenciesOnFailure, System.Action<TObject> callback);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperation<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperationInternal<TObject, TObjectDependency>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperationInternal<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x3c9e178*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider sceneProvider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            /*0x3c9e2b8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider sceneProvider, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);
            /*0x3c9e3fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> ProvideInstance(UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
            /*0x3c9e72c*/ void CleanupSceneInstances(UnityEngine.SceneManagement.Scene scene);
            /*0x3c9ebfc*/ void ExecuteDeferredCallbacks();
            /*0x3c9ede8*/ void RegisterForDeferredCallback(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, bool incrementRefCount);
            /*0x3c9eecc*/ void Update(float unscaledDeltaTime);
            /*0x3c9f1ec*/ void Dispose();
            /*0x3c9f2c0*/ UnityEngine.ResourceManagement.EA.IExternalAllocationReporter get_ExternalAllocationReporter();
            /*0x3c9f338*/ void set_ExternalAllocationReporter(UnityEngine.ResourceManagement.EA.IExternalAllocationReporter value);
            /*0x3c9f418*/ void <.ctor>b__45_0(UnityEngine.ResourceManagement.IUpdateReceiver x);

            enum DiagnosticEventType
            {
                AsyncOperationFail = 0,
                AsyncOperationCreate = 1,
                AsyncOperationPercentComplete = 2,
                AsyncOperationComplete = 3,
                AsyncOperationReferenceCount = 4,
                AsyncOperationDestroy = 5,
            }

            struct DiagnosticEventContext
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle <OperationHandle>k__BackingField;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventType <Type>k__BackingField;
                /*0x2c*/ int <EventValue>k__BackingField;
                /*0x30*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <Location>k__BackingField;
                /*0x38*/ object <Context>k__BackingField;
                /*0x40*/ string <Error>k__BackingField;

                /*0x3c9f458*/ DiagnosticEventContext(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventType type, int eventValue, string error, object context);
                /*0x3c9f41c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OperationHandle();
                /*0x3c9f430*/ UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventType get_Type();
                /*0x3c9f438*/ int get_EventValue();
                /*0x3c9f440*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x3c9f448*/ object get_Context();
                /*0x3c9f450*/ string get_Error();
            }

            class CompletedOperation<TObject> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>
            {
                /*0x0*/ bool m_Success;
                /*0x0*/ string m_ErrorMsg;
                /*0x0*/ bool m_ReleaseDependenciesOnFailure;

                /*0x1f309e4*/ CompletedOperation();
                /*0x1ffc854*/ void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure);
                /*0x1f30214*/ string get_DebugName();
                /*0x1f309e4*/ void Execute();
            }

            class InstanceOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.GameObject>
            {
                /*0x80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> m_dependency;
                /*0x98*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters m_instantiationParams;
                /*0xc8*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider m_instanceProvider;
                /*0xd0*/ UnityEngine.GameObject m_instance;
                /*0xd8*/ UnityEngine.SceneManagement.Scene m_scene;

                /*0x3c9fb48*/ InstanceOperation();
                /*0x3c9e6ac*/ void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider instanceProvider, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiationParams, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> dependency);
                /*0x3c9f590*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x3c9f668*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x3c9f718*/ string get_DebugName();
                /*0x3c9f818*/ UnityEngine.SceneManagement.Scene InstanceScene();
                /*0x3c9f820*/ void Destroy();
                /*0x3c9f8d4*/ float get_Progress();
                /*0x3c9f91c*/ void Execute();
            }

            class <>c__DisplayClass83_0<TObject>
            {
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceManager <>4__this;

                /*0x1f309e4*/ <>c__DisplayClass83_0();
                void <ProvideResources>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle x);
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <ProvideResources>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle resultHandle);
            }
        }

        interface IUpdateReceiver
        {
            void Update(float unscaledDeltaTime);
        }

        class WebRequestQueueOperation
        {
            /*0x10*/ UnityEngine.Networking.UnityWebRequestAsyncOperation Result;
            /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation Location;
            /*0x20*/ System.Action<UnityEngine.Networking.UnityWebRequestAsyncOperation> _onComplete;
            /*0x28*/ UnityEngine.Networking.UnityWebRequest m_WebRequest;

            /*0x3c9fd34*/ WebRequestQueueOperation(UnityEngine.Networking.UnityWebRequest request, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
            /*0x3c9fb90*/ void add_OnComplete(System.Action<UnityEngine.Networking.UnityWebRequestAsyncOperation> value);
            /*0x3c9fc74*/ void remove_OnComplete(System.Action<UnityEngine.Networking.UnityWebRequestAsyncOperation> value);
            /*0x3c9fc64*/ bool get_IsDone();
            /*0x3c9fd1c*/ ulong get_DownloadedBytes();
            /*0x3c9fd80*/ void Complete(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOp);
        }

        class WebRequestQueue
        {
            static /*0x3c9fdc8*/ UnityEngine.ResourceManagement.WebRequestQueueOperation QueueRequest(UnityEngine.Networking.UnityWebRequest request, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            static /*0x3c9fec0*/ void SetMaxConcurrentRequests(int maxRequests);
        }

        namespace Exceptions
        {
            class ResourceManagerException : System.Exception
            {
                /*0x3ca0038*/ ResourceManagerException();
                /*0x3ca0090*/ ResourceManagerException(string message);
                /*0x3ca00f8*/ ResourceManagerException(string message, System.Exception innerException);
                /*0x3ca0168*/ ResourceManagerException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
            }

            class UnknownResourceProviderException : UnityEngine.ResourceManagement.Exceptions.ResourceManagerException
            {
                /*0x90*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <Location>k__BackingField;

                /*0x3c9ccc0*/ UnknownResourceProviderException(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3ca01f8*/ UnknownResourceProviderException();
                /*0x3ca01fc*/ UnknownResourceProviderException(string message);
                /*0x3ca0200*/ UnknownResourceProviderException(string message, System.Exception innerException);
                /*0x3ca0204*/ UnknownResourceProviderException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
                /*0x3ca01e8*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x3ca01f0*/ void set_Location(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation value);
                /*0x3ca0208*/ string get_Message();
                /*0x3ca03c4*/ string ToString();
            }
        }

        namespace Util
        {
            class ComponentSingleton<T> : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ T s_Instance;

                static /*0x1f317dc*/ bool get_Exists();
                static /*0x1ffc854*/ T get_Instance();
                static /*0x1ffc854*/ T FindInstance();
                static /*0x1ffc854*/ T CreateNewSingleton();
                static /*0x1f33998*/ void DestroySingleton();
                /*0x1f309e4*/ ComponentSingleton();
                /*0x1f30214*/ string GetGameObjectName();
                /*0x1f309e4*/ void Awake();
            }

            class DelayedActionManager : UnityEngine.ResourceManagement.Util.ComponentSingleton<UnityEngine.ResourceManagement.Util.DelayedActionManager>
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo> m_Actions;
                /*0x28*/ System.Collections.Generic.LinkedList<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo> m_DelayedActions;
                /*0x30*/ System.Collections.Generic.Stack<System.Collections.Generic.LinkedListNode<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo>> m_NodeCache;
                /*0x38*/ int m_CollectionIndex;
                /*0x3c*/ bool m_DestroyOnCompletion;

                static /*0x3ca04d0*/ void Clear();
                static /*0x3ca0550*/ void AddAction(System.Delegate action, float delay, object[] parameters);
                static /*0x3ca087c*/ bool get_IsActive();
                static /*0x3ca0998*/ bool Wait(float timeout, float timeAdvanceAmount);
                /*0x3ca1078*/ DelayedActionManager();
                /*0x3ca03d0*/ System.Collections.Generic.LinkedListNode<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo> GetNode(ref UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo del);
                /*0x3ca0544*/ void DestroyWhenComplete();
                /*0x3ca05c4*/ void AddActionInternal(System.Delegate action, float delay, object[] parameters);
                /*0x3ca0e54*/ void LateUpdate();
                /*0x3ca0af8*/ void InternalLateUpdate(float t);
                /*0x3ca0fc4*/ void OnApplicationQuit();

                struct DelegateInfo
                {
                    static /*0x0*/ int s_Id;
                    /*0x10*/ int m_Id;
                    /*0x18*/ System.Delegate m_Delegate;
                    /*0x20*/ object[] m_Target;
                    /*0x28*/ float <InvocationTime>k__BackingField;

                    /*0x3ca07e4*/ DelegateInfo(System.Delegate d, float invocationTime, object[] p);
                    /*0x3ca1278*/ float get_InvocationTime();
                    /*0x3ca1280*/ void set_InvocationTime(float value);
                    /*0x3ca1288*/ string ToString();
                    /*0x3ca0e70*/ void Invoke();
                }
            }

            interface IInitializableObject
            {
                /*0x1f2ff00*/ bool Initialize(string id, string data);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);
            }

            interface IObjectInitializationDataProvider
            {
                /*0x1f30214*/ string get_Name();
                /*0x1ffc854*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData CreateObjectInitializationData();
            }

            interface IAllocationStrategy
            {
                /*0x1f30300*/ object New(System.Type type, int typeHash);
                /*0x1f30c88*/ void Release(int typeHash, object obj);
            }

            class DefaultAllocationStrategy : UnityEngine.ResourceManagement.Util.IAllocationStrategy
            {
                /*0x3ca1650*/ DefaultAllocationStrategy();
                /*0x3ca1640*/ object New(System.Type type, int typeHash);
                /*0x3ca164c*/ void Release(int typeHash, object obj);
            }

            class LRUCacheAllocationStrategy : UnityEngine.ResourceManagement.Util.IAllocationStrategy
            {
                /*0x10*/ int m_poolMaxSize;
                /*0x14*/ int m_poolInitialCapacity;
                /*0x18*/ int m_poolCacheMaxSize;
                /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<object>> m_poolCache;
                /*0x28*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<object>> m_cache;

                /*0x3c9b488*/ LRUCacheAllocationStrategy(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity);
                /*0x3ca1658*/ System.Collections.Generic.List<object> GetPool();
                /*0x3ca1744*/ void ReleasePool(System.Collections.Generic.List<object> pool);
                /*0x3ca17c4*/ object New(System.Type type, int typeHash);
                /*0x3ca1908*/ void Release(int typeHash, object obj);
            }

            class SerializedTypeRestrictionAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x3ca1a0c*/ SerializedTypeRestrictionAttribute();
            }

            class LinkedListNodeCache<T>
            {
                /*0x0*/ int m_NodesCreated;
                /*0x0*/ System.Collections.Generic.LinkedList<T> m_NodeCache;

                /*0x1f309e4*/ LinkedListNodeCache();
                /*0x1ffc854*/ System.Collections.Generic.LinkedListNode<T> Acquire(T val);
                /*0x1f30ebc*/ void Release(System.Collections.Generic.LinkedListNode<T> node);
                /*0x1f2ffc8*/ int get_CreatedNodeCount();
                /*0x1f2ffc8*/ int get_CachedNodeCount();
            }

            class GlobalLinkedListNodeCache<T>
            {
                static /*0x0*/ UnityEngine.ResourceManagement.Util.LinkedListNodeCache<T> m_globalCache;

                static /*0x1ffc854*/ System.Collections.Generic.LinkedListNode<T> Acquire(T val);
                static /*0x1f350f8*/ void Release(System.Collections.Generic.LinkedListNode<T> node);
            }

            struct SerializedType
            {
                /*0x10*/ string m_AssemblyName;
                /*0x18*/ string m_ClassName;
                /*0x20*/ System.Type m_CachedType;
                /*0x28*/ bool <ValueChanged>k__BackingField;

                /*0x3ca1a14*/ string get_AssemblyName();
                /*0x3ca1a1c*/ string get_ClassName();
                /*0x3ca1a24*/ string ToString();
                /*0x3ca1ac8*/ System.Type get_Value();
                /*0x3ca1cb0*/ void set_Value(System.Type value);
                /*0x3ca1d78*/ bool get_ValueChanged();
                /*0x3ca1d80*/ void set_ValueChanged(bool value);
            }

            struct ObjectInitializationData
            {
                /*0x10*/ string m_Id;
                /*0x18*/ UnityEngine.ResourceManagement.Util.SerializedType m_ObjectType;
                /*0x38*/ string m_Data;

                /*0x3ca1d88*/ string get_Id();
                /*0x3ca1d90*/ UnityEngine.ResourceManagement.Util.SerializedType get_ObjectType();
                /*0x3ca1da0*/ string get_Data();
                /*0x3ca1da8*/ string ToString();
                /*0x1ffc854*/ TObject CreateInstance<TObject>(string idOverride);
                /*0x3ca1e40*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle GetAsyncInitHandle(UnityEngine.ResourceManagement.ResourceManager rm, string idOverride);
            }

            class ResourceManagerConfig
            {
                static /*0x3ca20ac*/ bool ExtractKeyAndSubKey(object keyObj, ref string mainKey, ref string subKey);
                static /*0x3ca2194*/ bool IsPathRemote(string path);
                static /*0x3ca21f4*/ bool ShouldPathUseWebRequest(string path);
                static /*0x3ca2254*/ System.Array CreateArrayResult(System.Type type, UnityEngine.Object[] allAssets);
                static /*0x1ffc854*/ TObject CreateArrayResult<TObject>(UnityEngine.Object[] allAssets);
                static /*0x3ca23e4*/ System.Collections.IList CreateListResult(System.Type type, UnityEngine.Object[] allAssets);
                static /*0x1ffc854*/ TObject CreateListResult<TObject>(UnityEngine.Object[] allAssets);
                static /*0x1f317dc*/ bool IsInstance<T1, T2>();
            }
        }

        namespace ResourceProviders
        {
            class AssetBundleResourceMetricHooks
            {
                static /*0x3ca25a4*/ void StartMetricDownload(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x3ca25a8*/ void EndMetricDownload(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x3ca25ac*/ void StartMetricStreamingAssetsLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x3ca25b0*/ void EndMetricStreamingAssetsLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x3ca25b4*/ void StartMetricLocalLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x3ca25b8*/ void EndMetricLocalLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
            }

            class ResourceProviderBaseMetricHooks
            {
                static /*0x1ffc854*/ void MetricStartAssetLoading<TResourceProvider>(TResourceProvider resourceProvider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x1ffc854*/ void MetricEndAssetLoading<TResourceProvider>(TResourceProvider resourceProvider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                static /*0x1ffc854*/ void MetricStartWaitingForDependencies<TResourceProvider>(TResourceProvider resourceProvider, System.Collections.Generic.List<object> dependencies);
                static /*0x3ca25bc*/ void MetricEndWaitingForDependencies(UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase resourceProvider);
            }

            interface IAssetBundleResource
            {
                /*0x1f30214*/ UnityEngine.AssetBundle GetAssetBundle();
            }

            class AssetBundleRequestOptions : UnityEngine.ResourceManagement.ResourceLocations.ILocationSizeData
            {
                /*0x10*/ string m_Hash;
                /*0x18*/ uint m_Crc;
                /*0x1c*/ int m_Timeout;
                /*0x20*/ bool m_ChunkedTransfer;
                /*0x24*/ int m_RedirectLimit;
                /*0x28*/ int m_RetryCount;
                /*0x30*/ string m_BundleName;
                /*0x38*/ long m_BundleSize;
                /*0x40*/ bool m_UseCrcForCachedBundles;

                /*0x3ca2804*/ AssetBundleRequestOptions();
                /*0x3ca25c0*/ string get_Hash();
                /*0x3ca25c8*/ void set_Hash(string value);
                /*0x3ca25d0*/ uint get_Crc();
                /*0x3ca25d8*/ void set_Crc(uint value);
                /*0x3ca25e0*/ int get_Timeout();
                /*0x3ca25e8*/ void set_Timeout(int value);
                /*0x3ca25f0*/ bool get_ChunkedTransfer();
                /*0x3ca25f8*/ void set_ChunkedTransfer(bool value);
                /*0x3ca2600*/ int get_RedirectLimit();
                /*0x3ca2608*/ void set_RedirectLimit(int value);
                /*0x3ca2610*/ int get_RetryCount();
                /*0x3ca2618*/ void set_RetryCount(int value);
                /*0x3ca2620*/ string get_BundleName();
                /*0x3ca2628*/ void set_BundleName(string value);
                /*0x3ca2630*/ long get_BundleSize();
                /*0x3ca2638*/ void set_BundleSize(long value);
                /*0x3ca2640*/ bool get_UseCrcForCachedBundle();
                /*0x3ca2648*/ void set_UseCrcForCachedBundle(bool value);
                /*0x3ca2650*/ long ComputeSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceManager resourceManager);
            }

            class AssetBundleResource : UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource
            {
                /*0x10*/ UnityEngine.AssetBundle m_AssetBundle;
                /*0x18*/ UnityEngine.Networking.DownloadHandlerAssetBundle m_downloadHandler;
                /*0x20*/ UnityEngine.AsyncOperation m_RequestOperation;
                /*0x28*/ UnityEngine.ResourceManagement.WebRequestQueueOperation m_WebRequestQueueOperation;
                /*0x30*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProvideHandle;
                /*0x48*/ UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions m_Options;
                /*0x50*/ int m_Retries;
                /*0x58*/ long m_BytesToDownload;
                /*0x60*/ UnityEngine.ResourceManagement.ResourceManager _resourceManager;
                /*0x68*/ long m_BundleFileSize;
                /*0x70*/ bool _isAllocated;
                /*0x78*/ string _deprecatedCacheBundlePath;

                static /*0x3ca36cc*/ long GetFileSize(string fileName);
                /*0x3ca4410*/ AssetBundleResource();
                /*0x3ca2864*/ string get_CachedFilePath();
                /*0x3ca2938*/ long get_BundleSize();
                /*0x3ca2964*/ void Finalize();
                /*0x3ca2afc*/ UnityEngine.Networking.UnityWebRequest CreateWebRequest(string url);
                /*0x3ca2cb8*/ float PercentComplete();
                /*0x3ca2cd0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus();
                /*0x3ca2d94*/ UnityEngine.AssetBundle GetAssetBundle();
                /*0x3ca2f30*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                /*0x3ca3334*/ void BeginOperation();
                /*0x3ca39e0*/ void LocalRequestOperationCompleted(UnityEngine.AsyncOperation op);
                /*0x3ca3be4*/ void WebRequestOperationCompleted(UnityEngine.AsyncOperation op);
                /*0x3ca4270*/ void Unload();
                /*0x3ca38f4*/ UnityEngine.Networking.UnityWebRequest CreateWebRequestForLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3ca37d8*/ bool IsResourceLocationCached(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3ca3928*/ void StartLocalRequest(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, UnityEngine.Networking.UnityWebRequest request);
                /*0x3ca4418*/ void <BeginOperation>b__22_0(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOp);
            }

            class AssetBundleProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x3ca4788*/ AssetBundleProvider();
                /*0x3ca4520*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);
                /*0x3ca45a0*/ System.Type GetDefaultType(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3ca4600*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object asset);
            }

            class AtlasSpriteProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x3ca4b14*/ AtlasSpriteProvider();
                /*0x3ca4798*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);
            }

            class BundledAssetProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x3ca550c*/ BundledAssetProvider();
                /*0x3ca4b1c*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);

                class InternalOp
                {
                    /*0x10*/ UnityEngine.AssetBundleRequest m_RequestOperation;
                    /*0x18*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProvideHandle;
                    /*0x30*/ string subObjectName;

                    static /*0x3ca5514*/ UnityEngine.AssetBundle LoadBundleFromDependecies(System.Collections.Generic.IList<object> results);
                    /*0x3ca4b9c*/ InternalOp();
                    /*0x3ca4ba4*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                    /*0x3ca58a0*/ void ActionComplete(UnityEngine.AsyncOperation obj);
                    /*0x3ca5c1c*/ float ProgressCallback();
                }
            }

            struct InstantiationParameters
            {
                /*0x10*/ UnityEngine.Vector3 m_Position;
                /*0x1c*/ UnityEngine.Quaternion m_Rotation;
                /*0x30*/ UnityEngine.Transform m_Parent;
                /*0x38*/ bool m_InstantiateInWorldPosition;
                /*0x39*/ bool m_SetPositionRotation;

                /*0x3ca5c64*/ InstantiationParameters(UnityEngine.Transform parent, bool instantiateInWorldSpace);
                /*0x3ca5d20*/ InstantiationParameters(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
                /*0x3ca5c34*/ UnityEngine.Vector3 get_Position();
                /*0x3ca5c40*/ UnityEngine.Quaternion get_Rotation();
                /*0x3ca5c4c*/ UnityEngine.Transform get_Parent();
                /*0x3ca5c54*/ bool get_InstantiateInWorldPosition();
                /*0x3ca5c5c*/ bool get_SetPositionRotation();
                /*0x1ffc854*/ TObject Instantiate<TObject>(TObject source);
            }

            interface IInstanceProvider
            {
                UnityEngine.GameObject ProvideInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> prefabHandle, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
                /*0x1f30ff0*/ void ReleaseInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.GameObject instance);
            }

            class InstanceProvider : UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider
            {
                /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject>> m_InstanceObjectToPrefabHandle;

                /*0x3ca607c*/ InstanceProvider();
                /*0x3ca5d50*/ UnityEngine.GameObject ProvideInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> prefabHandle, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
                /*0x3ca5e30*/ void ReleaseInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.GameObject instance);
            }

            enum ProviderBehaviourFlags
            {
                None = 0,
                CanProvideWithFailedDependencies = 1,
            }

            struct ProvideHandle
            {
                /*0x10*/ int m_Version;
                /*0x18*/ UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation m_InternalOp;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;

                /*0x3ca6104*/ ProvideHandle(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation op);
                /*0x3ca61dc*/ UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation get_InternalOp();
                /*0x3ca62dc*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
                /*0x3ca57f4*/ System.Type get_Type();
                /*0x3ca288c*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x3ca62e4*/ int get_DependencyCount();
                /*0x1ffc854*/ TDepObject GetDependency<TDepObject>(int index);
                /*0x3ca5740*/ void GetDependencies(System.Collections.Generic.IList<object> list);
                /*0x3ca31cc*/ void SetProgressCallback(System.Func<float> callback);
                /*0x3ca3280*/ void SetDownloadProgressCallbacks(System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> callback);
                /*0x1ffc854*/ void Complete<T>(T result, bool status, System.Exception exception);
            }

            interface IResourceProvider
            {
                /*0x1f30214*/ string get_ProviderId();
                /*0x1f302cc*/ System.Type GetDefaultType(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x1f2ff00*/ bool CanProvide(System.Type type, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                /*0x1f30ff0*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object asset);
                /*0x1f2ffc8*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderBehaviourFlags get_BehaviourFlags();
            }

            struct SceneInstance
            {
                /*0x10*/ UnityEngine.SceneManagement.Scene m_Scene;
                /*0x18*/ UnityEngine.AsyncOperation m_Operation;

                /*0x3ca6390*/ UnityEngine.SceneManagement.Scene get_Scene();
                /*0x3ca6398*/ void set_Scene(UnityEngine.SceneManagement.Scene value);
                /*0x3ca63a0*/ void Activate();
                /*0x3ca63bc*/ UnityEngine.AsyncOperation ActivateAsync();
                /*0x3ca63e8*/ int GetHashCode();
                /*0x3ca6408*/ bool Equals(object obj);
            }

            interface ISceneProvider
            {
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);
            }

            class JsonAssetProvider : UnityEngine.ResourceManagement.ResourceProviders.TextDataProvider
            {
                /*0x3ca6588*/ JsonAssetProvider();
                /*0x3ca64c0*/ object Convert(System.Type type, string text);
            }

            class LegacyResourcesProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x3ca6c10*/ LegacyResourcesProvider();
                /*0x3ca6598*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle pi);
                /*0x3ca6aec*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object asset);

                class InternalOp
                {
                    /*0x10*/ UnityEngine.AsyncOperation m_RequestOperation;
                    /*0x18*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProvideHandle;

                    /*0x3ca6998*/ InternalOp();
                    /*0x3ca69a0*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                    /*0x3ca6c18*/ void AsyncOperationCompleted(UnityEngine.AsyncOperation op);
                    /*0x3ca6d98*/ float PercentComplete();
                }
            }

            class ResourceProviderBase : UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, UnityEngine.ResourceManagement.Util.IInitializableObject
            {
                /*0x10*/ string m_ProviderId;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderBehaviourFlags m_BehaviourFlags;

                /*0x3ca4790*/ ResourceProviderBase();
                /*0x3ca6db0*/ string get_ProviderId();
                /*0x3ca6e14*/ bool Initialize(string id, string data);
                /*0x3ca6e44*/ bool CanProvide(System.Type t, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3ca6e84*/ string ToString();
                /*0x3ca6e90*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object obj);
                /*0x3ca6e94*/ System.Type GetDefaultType(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                /*0x3ca6ec4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);
                /*0x3ca7094*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags();

                class BaseInitAsyncOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
                {
                    /*0x80*/ System.Func<bool> m_CallBack;

                    /*0x3ca704c*/ BaseInitAsyncOp();
                    /*0x3ca709c*/ void Init(System.Func<bool> callback);
                    /*0x3ca70a4*/ void Execute();
                }

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase <>4__this;
                    /*0x18*/ string id;
                    /*0x20*/ string data;

                    /*0x3ca7044*/ <>c__DisplayClass10_0();
                    /*0x3ca714c*/ bool <InitializeAsync>b__0();
                }
            }

            class SceneProvider : UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider
            {
                /*0x3ca7820*/ SceneProvider();
                /*0x3ca7174*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
                /*0x3ca760c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);

                class SceneOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>, UnityEngine.ResourceManagement.IUpdateReceiver
                {
                    /*0x88*/ bool m_ActivateOnLoad;
                    /*0x90*/ UnityEngine.ResourceManagement.ResourceProviders.SceneInstance m_Inst;
                    /*0xa0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation m_Location;
                    /*0xa8*/ UnityEngine.SceneManagement.LoadSceneMode m_LoadMode;
                    /*0xac*/ int m_Priority;
                    /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
                    /*0xc8*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;

                    /*0x3ca74c8*/ SceneOp(UnityEngine.ResourceManagement.ResourceManager rm);
                    /*0x3ca7828*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                    /*0x3ca752c*/ void Init(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                    /*0x3ca7900*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                    /*0x3ca79d4*/ string get_DebugName();
                    /*0x3ca7a78*/ void Execute();
                    /*0x3ca7fc4*/ UnityEngine.ResourceManagement.ResourceProviders.SceneInstance InternalLoadScene(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, bool loadingFromBundle, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
                    /*0x3ca80b8*/ UnityEngine.AsyncOperation InternalLoad(string path, bool loadingFromBundle, UnityEngine.SceneManagement.LoadSceneMode mode);
                    /*0x3ca813c*/ void Destroy();
                    /*0x3ca81c8*/ float get_Progress();
                    /*0x3ca8284*/ void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime);
                }

                class UnloadSceneOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>
                {
                    /*0x88*/ UnityEngine.ResourceManagement.ResourceProviders.SceneInstance m_Instance;
                    /*0x98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> m_sceneLoadHandle;

                    /*0x3ca771c*/ UnloadSceneOp();
                    /*0x3ca7764*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);
                    /*0x3ca8344*/ void Execute();
                    /*0x3ca8454*/ void UnloadSceneCompleted(UnityEngine.AsyncOperation obj);
                    /*0x3ca851c*/ float get_Progress();
                }
            }

            class TextDataProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x1c*/ bool <IgnoreFailures>k__BackingField;
                /*0x1d*/ bool <DisableRemoteAccess>k__BackingField;

                /*0x3ca6590*/ TextDataProvider();
                /*0x3ca8564*/ bool get_IgnoreFailures();
                /*0x3ca856c*/ void set_IgnoreFailures(bool value);
                /*0x3ca8574*/ bool get_DisableRemoteAccess();
                /*0x3ca857c*/ void set_DisableRemoteAccess(bool value);
                /*0x3ca8584*/ object Convert(System.Type type, string text);
                /*0x3ca858c*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);

                class InternalOp
                {
                    /*0x10*/ UnityEngine.ResourceManagement.ResourceProviders.TextDataProvider m_Provider;
                    /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation m_RequestOperation;
                    /*0x20*/ UnityEngine.ResourceManagement.WebRequestQueueOperation m_RequestQueueOperation;
                    /*0x28*/ bool m_IgnoreFailures;
                    /*0x30*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_PI;

                    /*0x3ca8620*/ InternalOp();
                    /*0x3ca8b90*/ float GetPercentComplete();
                    /*0x3ca8628*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle, UnityEngine.ResourceManagement.ResourceProviders.TextDataProvider rawProvider, bool ignoreFailures);
                    /*0x3ca8ba8*/ void StartLocalRequest(string path, UnityEngine.Networking.UnityWebRequest request);
                    /*0x3ca8c60*/ void RequestOperation_completed(UnityEngine.AsyncOperation op);
                    /*0x3ca8e38*/ void <Start>b__6_0(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                }
            }
        }

        namespace ResourceLocations
        {
            class ResourceLocationExtension
            {
                static /*0x3ca8ee0*/ long GetRuntimeSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                static /*0x3ca9068*/ long GetCloneSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            }

            interface ILocationSizeData
            {
                long ComputeSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceManager resourceManager);
            }

            interface IResourceLocation
            {
                /*0x1f30214*/ string get_InternalId();
                /*0x1f30214*/ string get_ProviderId();
                /*0x1f30ebc*/ void set_ProviderId(string value);
                /*0x1f30214*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                /*0x1f3008c*/ int Hash(System.Type resultType);
                /*0x1f2ffc8*/ int get_DependencyHashCode();
                /*0x1f2fe14*/ bool get_HasDependencies();
                /*0x1f30214*/ object get_Data();
                /*0x1f30214*/ string get_PrimaryKey();
                /*0x1f30214*/ System.Type get_ResourceType();
                /*0x1f30214*/ System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> get_OnPriorityChanged();
                /*0x1f30ebc*/ void set_OnPriorityChanged(System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> value);
                /*0x1f2ffc8*/ UnityEngine.ResourceManagement.EA.ResourcePriority get_Priority();
                /*0x1f30b78*/ void set_Priority(UnityEngine.ResourceManagement.EA.ResourcePriority value);
            }

            class ResourceLocationBase : UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation
            {
                /*0x10*/ string m_Name;
                /*0x18*/ string m_Id;
                /*0x20*/ string m_ProviderId;
                /*0x28*/ object m_Data;
                /*0x30*/ int m_DependencyHashCode;
                /*0x34*/ int m_HashCode;
                /*0x38*/ System.Type m_Type;
                /*0x40*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_Dependencies;
                /*0x48*/ string m_PrimaryKey;
                /*0x50*/ System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> <OnPriorityChanged>k__BackingField;
                /*0x58*/ UnityEngine.ResourceManagement.EA.ResourcePriority _priority;

                /*0x3ca92ec*/ ResourceLocationBase(string name, string id, string providerId, System.Type t, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation[] dependencies);
                /*0x3ca91f4*/ string get_InternalId();
                /*0x3ca91fc*/ string get_ProviderId();
                /*0x3ca9204*/ void set_ProviderId(string value);
                /*0x3ca920c*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                /*0x3ca9214*/ bool get_HasDependencies();
                /*0x3ca9268*/ object get_Data();
                /*0x3ca9270*/ void set_Data(object value);
                /*0x3ca9278*/ string get_PrimaryKey();
                /*0x3ca9280*/ void set_PrimaryKey(string value);
                /*0x3ca9288*/ int get_DependencyHashCode();
                /*0x3ca9290*/ System.Type get_ResourceType();
                /*0x3ca9298*/ int Hash(System.Type t);
                /*0x3ca92e4*/ string ToString();
                /*0x3ca9530*/ void ComputeDependencyHash();
                /*0x3ca97d0*/ System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> get_OnPriorityChanged();
                /*0x3ca97d8*/ void set_OnPriorityChanged(System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> value);
                /*0x3ca97e0*/ UnityEngine.ResourceManagement.EA.ResourcePriority get_Priority();
                /*0x3ca97e8*/ void set_Priority(UnityEngine.ResourceManagement.EA.ResourcePriority value);
            }
        }

        namespace EA
        {
            class ContentUpdateDebugUtils
            {
                static string ClearCacheOnBootEnabledKey = "ClearCacheOnBootEnabled";
                static /*0x0*/ System.Func<System.Collections.Generic.List<string>> GetInstalledCatalogsAction;
                static /*0x8*/ System.Func<string> GetCurrentCatalogHashAction;

                static /*0x3ca9830*/ System.Collections.Generic.List<string> get_InstalledCatalogs();
                static /*0x3ca98d8*/ bool get_ClearCacheOnBootEnabled();
                static /*0x3ca992c*/ void set_ClearCacheOnBootEnabled(bool value);
                static /*0x3ca9978*/ void RemoveClearCacheOnBootEnabledFlag();
                static /*0x3ca99bc*/ string GetCurrentCatalogHash();
            }

            class AbortedWebRequestException : System.Exception
            {
                /*0x3ca4218*/ AbortedWebRequestException();
            }

            interface IWebRequestCompletedListener
            {
                /*0x1f30ebc*/ void OnWebRequestFinished(UnityEngine.Networking.UnityWebRequestAsyncOperation request);
            }

            class WebRequestPermissionRequester
            {
                static /*0x0*/ System.Action<System.Action> CheckIfNotWifiAndGetPermissionToDownloadAction;

                static /*0x3ca9a28*/ void SetCheckIfNotWifiAndGetPermissionToDownloadAction(System.Action<System.Action> runOnPermission);
                static /*0x3ca9a80*/ void RemoveCheckIfNotWifiAndGetPermissionToDownloadAction();
            }

            class ResourceManagerLoggerScope : System.IDisposable
            {
                /*0x10*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> _current;

                /*0x3ca9ad4*/ ResourceManagerLoggerScope();
                /*0x3ca9bc0*/ void Dispose();
            }

            class UnityWebRequestAsyncOperationWrapper
            {
                /*0x10*/ UnityEngine.Networking.UnityWebRequestAsyncOperation <Operation>k__BackingField;
                /*0x18*/ UnityEngine.ResourceManagement.EA.ResourcePriority <Priority>k__BackingField;
                /*0x20*/ System.Action<UnityEngine.ResourceManagement.EA.UnityWebRequestAsyncOperationWrapper> _onComplete;

                /*0x3ca9df8*/ UnityWebRequestAsyncOperationWrapper(UnityEngine.Networking.UnityWebRequestAsyncOperation operation, UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                /*0x3ca9c5c*/ UnityEngine.Networking.UnityWebRequestAsyncOperation get_Operation();
                /*0x3ca9c64*/ UnityEngine.ResourceManagement.EA.ResourcePriority get_Priority();
                /*0x3ca9c6c*/ void add_OnComplete(System.Action<UnityEngine.ResourceManagement.EA.UnityWebRequestAsyncOperationWrapper> value);
                /*0x3ca9d50*/ void remove_OnComplete(System.Action<UnityEngine.ResourceManagement.EA.UnityWebRequestAsyncOperationWrapper> value);
                /*0x3ca9ebc*/ void OnWebRequestCompletd(UnityEngine.AsyncOperation obj);
            }

            class EaWebRequestQueue
            {
                static int DefaultMaxRequests = 16;
                static /*0x0*/ int _maxRequests;
                static /*0x8*/ UnityEngine.ResourceManagement.EA.PriorityWebRequestStatus PriorityStatus;
                static /*0x10*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.EA.UnityWebRequestAsyncOperationWrapper> ActiveRequests;
                static /*0x18*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.EA.IWebRequestCompletedListener> RequestCompletedListeners;
                static /*0x20*/ bool _isInit;

                static /*0x3cac524*/ EaWebRequestQueue();
                static /*0x3ca9f78*/ int get_MaxRequests();
                static /*0x3c9ff78*/ void set_MaxRequests(int value);
                static /*0x3ca9fd0*/ bool get_HasActiveRequests();
                static /*0x3caa028*/ int get_RemainingRequestCount();
                static /*0x3caa168*/ int get_ActiveRequestCount();
                static /*0x3caa1d8*/ bool HasActiveRequestOfPriority(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                static /*0x3c9fe2c*/ UnityEngine.ResourceManagement.WebRequestQueueOperation QueueRequest(UnityEngine.Networking.UnityWebRequest request, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                static /*0x3caa540*/ void PauseRequests(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                static /*0x3caa654*/ void PauseRequests();
                static /*0x3caa80c*/ void ResumeRequests(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                static /*0x3caac68*/ void ResumeRequests();
                static /*0x3caaef4*/ void OnWebAsyncOpComplete(UnityEngine.ResourceManagement.EA.UnityWebRequestAsyncOperationWrapper wrapper);
                static /*0x3cab238*/ void FillUpActiveQueueWithAvailablePendingRequests();
                static /*0x3caa2d0*/ void StartOrQueueRequest(UnityEngine.ResourceManagement.WebRequestQueueOperation webRequestQueueOperation);
                static /*0x3caaaec*/ void StartRequest(UnityEngine.ResourceManagement.WebRequestQueueOperation webRequestQueueOperation);
                static /*0x3cab3d0*/ void StartRequestInternal(UnityEngine.ResourceManagement.WebRequestQueueOperation webRequestQueueOperation);
                static /*0x3cab6dc*/ void OnPriorityChanged(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority previousPriority, UnityEngine.ResourceManagement.EA.ResourcePriority newPriority);
                static /*0x3caa97c*/ bool CanStartRequest(UnityEngine.ResourceManagement.WebRequestQueueOperation webRequestQueueOperation);
                static /*0x3cab990*/ void AddRequestCompletedListener(UnityEngine.ResourceManagement.EA.IWebRequestCompletedListener webRequestCompletedListener);
                static /*0x3caba10*/ void RemoveRequestCompletedListener(UnityEngine.ResourceManagement.EA.IWebRequestCompletedListener webRequestCompletedListener);
                static /*0x3caafdc*/ void InvokeRequestCompleteListeners(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                static /*0x3caba90*/ void ClearRequestListeners();
                static /*0x3cabb54*/ void Init(int maxRequests);
                static /*0x3cabe20*/ void Release();
                static /*0x3cac1f4*/ void FailPendingRequests(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                static /*0x3cac424*/ void Clear();

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ UnityEngine.ResourceManagement.WebRequestQueueOperation webRequestQueueOperation;

                    /*0x3cab3c8*/ <>c__DisplayClass23_0();
                    /*0x3cac694*/ void <StartRequest>b__0();
                }
            }

            interface IExternalAllocationReporter
            {
                void ReportAssetBundleMemoryAllocated(string bundleName, long bytes);
                void ReportAssetBundleMemoryFreed(string bundleName, long bytes);
                /*0x1f30ebc*/ void ReportAssetBundleLeak(string bundleName);
                void ReportMemoryAllocated(string assetName, long bytes);
                void ReportMemoryAllocated(string assetName, bool forClone);
                void ReportMemoryFreed(string assetName, long bytes);
                void ReportMemoryFreed(string assetName, bool forClone);
            }

            class NullExternalAllocationReporter : UnityEngine.ResourceManagement.EA.IExternalAllocationReporter
            {
                /*0x3c9f330*/ NullExternalAllocationReporter();
                /*0x3cac6ec*/ void ReportAssetBundleMemoryAllocated(string bundleName, long bytes);
                /*0x3cac6f0*/ void ReportAssetBundleMemoryFreed(string bundleName, long bytes);
                /*0x3cac6f4*/ void ReportAssetBundleLeak(string bundleName);
                /*0x3cac6f8*/ void ReportMemoryAllocated(string assetName, long bytes);
                /*0x3cac6fc*/ void ReportMemoryAllocated(string assetName, bool forClone);
                /*0x3cac700*/ void ReportMemoryFreed(string assetName, long bytes);
                /*0x3cac704*/ void ReportMemoryFreed(string assetName, bool forClone);
                /*0x3cac708*/ long GetRuntimeMemorySize(string assetName, bool forClone);
            }

            interface IRuntimeLocationSizeData
            {
                long get_RuntimeSize();
                long get_CloneSize();
            }

            class MetricHooks
            {
                static /*0x0*/ System.Action<string, System.String[]> StartCallbackHook;
                static /*0x8*/ System.Action<string, System.String[]> EndCallbackHook;
                static /*0x10*/ string[] EmptyTags;

                static /*0x3cacb50*/ MetricHooks();
                static /*0x3cac710*/ void add_StartCallbackHook(System.Action<string, System.String[]> value);
                static /*0x3cac800*/ void remove_StartCallbackHook(System.Action<string, System.String[]> value);
                static /*0x3cac8f0*/ void add_EndCallbackHook(System.Action<string, System.String[]> value);
                static /*0x3cac9e4*/ void remove_EndCallbackHook(System.Action<string, System.String[]> value);
                static /*0x3c9a924*/ void Start(string eventName, string[] tags);
                static /*0x1ffc854*/ void Start<T>(T caller, string eventName, string[] tags);
                static /*0x3c9ab34*/ void End(string eventName, string[] tags);
                static /*0x1ffc854*/ void End<T>(T caller, string eventName, string[] tags);
                static /*0x3cacad8*/ void ClearHooks();

                struct Scope : System.IDisposable
                {
                    /*0x10*/ string _eventName;

                    /*0x3cacbc0*/ Scope(string eventName);
                    /*0x3cacca8*/ void Dispose();
                }
            }

            class PriorityWebRequestStatus
            {
                static /*0x0*/ UnityEngine.ResourceManagement.EA.ResourcePriority[] ResourcePriorities;
                /*0x10*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.EA.PriorityWebRequestStatus.PriorityWebRequestData> _queue;

                static /*0x3cacdd8*/ PriorityWebRequestStatus();
                static /*0x3cacd74*/ int get_PriorityCount();
                static /*0x3cad124*/ int QueueIndexForPriority(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                /*0x3cabc2c*/ PriorityWebRequestStatus();
                /*0x3caa6ec*/ bool get_AreAllPrioritiesPaused();
                /*0x3caa790*/ void SetAllPrioritiesPaused(bool isPaused);
                /*0x3cad00c*/ bool get_IsAnyPaused();
                /*0x3cad0b0*/ void SetIsPriorityPaused(UnityEngine.ResourceManagement.EA.ResourcePriority priority, bool isPaused);
                /*0x3cab974*/ bool IsPriorityPaused(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                /*0x3cabfd4*/ void Clear();
                /*0x3cac25c*/ void Clear(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                /*0x3caa5b8*/ UnityEngine.ResourceManagement.EA.PriorityWebRequestStatus.PriorityWebRequestData GetResourcePriorityData(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                /*0x3cacfa0*/ UnityEngine.ResourceManagement.EA.PriorityWebRequestStatus.PriorityWebRequestData GetResourcePriorityData(int index);
                /*0x3cad194*/ void AddFirst(UnityEngine.ResourceManagement.WebRequestQueueOperation operation);
                /*0x3cab304*/ void AddLast(UnityEngine.ResourceManagement.WebRequestQueueOperation operation);
                /*0x3cad308*/ bool HasQueuedRequests();
                /*0x3cad3fc*/ bool HasQueuedRequests(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                /*0x3caa0a8*/ int get_Count();
                /*0x3cad4a8*/ int get_PausedCount();
                /*0x3caae2c*/ UnityEngine.ResourceManagement.WebRequestQueueOperation RemoveNext();
                /*0x3caad74*/ UnityEngine.ResourceManagement.WebRequestQueueOperation Next();
                /*0x3cab760*/ void OnPriorityChanged(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority previousPriority, UnityEngine.ResourceManagement.EA.ResourcePriority newPriority);

                class PriorityWebRequestData
                {
                    /*0x10*/ UnityEngine.ResourceManagement.EA.ResourcePriority Priority;
                    /*0x14*/ bool IsPaused;
                    /*0x18*/ System.Collections.Generic.LinkedList<UnityEngine.ResourceManagement.WebRequestQueueOperation> QueuedOperations;

                    /*0x3cacf0c*/ PriorityWebRequestData(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                    /*0x3cad3ac*/ bool get_IsEmpty();
                    /*0x3cad650*/ int get_Count();
                    /*0x3caa8e8*/ UnityEngine.ResourceManagement.WebRequestQueueOperation get_Next();
                    /*0x3cad258*/ void AddFirst(UnityEngine.ResourceManagement.WebRequestQueueOperation request);
                    /*0x3cad2b0*/ void AddLast(UnityEngine.ResourceManagement.WebRequestQueueOperation request);
                    /*0x3caac18*/ void RemoveFront();
                    /*0x3cad0d4*/ void Clear();
                    /*0x3cad568*/ System.Collections.Generic.LinkedListNode<UnityEngine.ResourceManagement.WebRequestQueueOperation> Find(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation);
                }
            }

            class ProviderUtils
            {
                static /*0x3cad698*/ void MarkFileNoBackup(string fullFilePath);
            }

            enum ResourcePriority
            {
                Low = 0,
                Medium = 1,
                High = 2,
                VeryHigh = 2147483647,
            }
        }

        namespace Diagnostics
        {
            struct DiagnosticEvent
            {
                /*0x10*/ string m_Graph;
                /*0x18*/ int[] m_Dependencies;
                /*0x20*/ int m_ObjectId;
                /*0x28*/ string m_DisplayName;
                /*0x30*/ int m_Stream;
                /*0x34*/ int m_Frame;
                /*0x38*/ int m_Value;

                static /*0x3cad7dc*/ UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent Deserialize(byte[] data);
                /*0x3cad6d4*/ DiagnosticEvent(string graph, string name, int id, int stream, int frame, int value, int[] deps);
                /*0x3cad69c*/ string get_Graph();
                /*0x3cad6a4*/ int get_ObjectId();
                /*0x3cad6ac*/ string get_DisplayName();
                /*0x3cad6b4*/ int[] get_Dependencies();
                /*0x3cad6bc*/ int get_Stream();
                /*0x3cad6c4*/ int get_Frame();
                /*0x3cad6cc*/ int get_Value();
                /*0x3cad744*/ byte[] Serialize();
            }

            class DiagnosticEventCollectorSingleton : UnityEngine.ResourceManagement.Util.ComponentSingleton<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEventCollectorSingleton>
            {
                static /*0x0*/ System.Guid s_editorConnectionGuid;
                /*0x20*/ System.Collections.Generic.Dictionary<int, UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> m_CreatedEvents;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> m_UnhandledEvents;
                /*0x30*/ DelegateList<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> s_EventHandlers;
                /*0x38*/ float m_lastTickSent;
                /*0x3c*/ int m_lastFrame;
                /*0x40*/ float fpsAvg;

                static /*0x3cad868*/ System.Guid get_PlayerConnectionGuid();
                static /*0x3cad9a4*/ bool RegisterEventHandler(System.Action<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> handler, bool register, bool create);
                /*0x3cae464*/ DiagnosticEventCollectorSingleton();
                /*0x3cad964*/ string GetGameObjectName();
                /*0x3cada68*/ void RegisterEventHandler(System.Action<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> handler);
                /*0x3cadf44*/ void UnregisterEventHandler(System.Action<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> handler);
                /*0x3cadfe8*/ void PostEvent(UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent diagnosticEvent);
                /*0x3cae188*/ void Awake();
                /*0x3cae270*/ void Update();

                class <>c
                {
                    static /*0x0*/ UnityEngine.ResourceManagement.Diagnostics.DiagnosticEventCollectorSingleton.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent, int> <>9__8_0;
                    static /*0x10*/ System.Action<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> <>9__11_0;

                    static /*0x3cae590*/ <>c();
                    /*0x3cae5f8*/ <>c();
                    /*0x3cae600*/ int <RegisterEventHandler>b__8_0(UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent evt);
                    /*0x3cae608*/ void <Awake>b__11_0(UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent diagnosticEvent);
                }
            }

            class DiagnosticEventCollector : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ UnityEngine.ResourceManagement.Diagnostics.DiagnosticEventCollector s_Collector;

                static /*0x3cae664*/ System.Guid get_PlayerConnectionGuid();
                static /*0x3cae668*/ UnityEngine.ResourceManagement.Diagnostics.DiagnosticEventCollector FindOrCreateGlobalInstance();
                static /*0x3cae844*/ bool RegisterEventHandler(System.Action<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> handler, bool register, bool create);
                /*0x3cae90c*/ DiagnosticEventCollector();
                /*0x3cae848*/ void UnregisterEventHandler(System.Action<UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent> handler);
                /*0x3cae89c*/ void PostEvent(UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent diagnosticEvent);
            }
        }

        namespace AsyncOperations
        {
            interface ICachable
            {
                /*0x1f2ffc8*/ int get_Hash();
                /*0x1f30b78*/ void set_Hash(int value);
            }

            interface IAsyncOperation
            {
                /*0x1f30214*/ object GetResultAsObject();
                /*0x1f30214*/ System.Type get_ResultType();
                /*0x1f2ffc8*/ int get_Version();
                /*0x1f30214*/ string get_DebugName();
                /*0x1f309e4*/ void DecrementReferenceCount();
                /*0x1f309e4*/ void IncrementReferenceCount();
                /*0x1f2ffc8*/ int get_ReferenceCount();
                /*0x1f30804*/ float get_PercentComplete();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x1f2ffc8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x1f30214*/ System.Exception get_OperationException();
                /*0x1f2fe14*/ bool get_IsDone();
                /*0x1f30ebc*/ void set_OnDestroy(System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> value);
                /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x1f2fe14*/ bool get_IsRunning();
                /*0x1f30ebc*/ void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f309e4*/ void InvokeCompletionEvent();
                /*0x1f30214*/ System.Threading.Tasks.Task<object> get_Task();
                void Start(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_Handle();
            }

            class AsyncOperationBase<TObject> : UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation
            {
                /*0x0*/ TObject <Result>k__BackingField;
                /*0x0*/ int m_referenceCount;
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus m_Status;
                /*0x0*/ System.Exception m_Error;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceManager m_RM;
                /*0x0*/ int m_Version;
                /*0x0*/ DelegateList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_DestroyedAction;
                /*0x0*/ DelegateList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_CompletedActionT;
                /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_OnDestroyAction;
                /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_dependencyCompleteAction;
                /*0x0*/ bool <IsRunning>k__BackingField;
                /*0x0*/ System.Threading.EventWaitHandle m_waitHandle;
                /*0x0*/ bool m_InDeferredCallbackQueue;
                /*0x0*/ DelegateList<float> m_UpdateCallbacks;
                /*0x0*/ System.Action<float> m_UpdateCallback;

                static string ShortenPath(string p, bool keepExtension);
                /*0x1f309e4*/ AsyncOperationBase();
                /*0x1f309e4*/ void Execute();
                /*0x1f309e4*/ void Destroy();
                /*0x1f30804*/ float get_Progress();
                /*0x1f30214*/ string get_DebugName();
                /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
                /*0x1ffc854*/ TObject get_Result();
                /*0x1ffc854*/ void set_Result(TObject value);
                /*0x1f2ffc8*/ int get_Version();
                /*0x1f2fe14*/ bool get_CompletedEventHasListeners();
                /*0x1f2fe14*/ bool get_DestroyedEventHasListeners();
                /*0x1f30ebc*/ void set_OnDestroy(System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> value);
                /*0x1f2ffc8*/ int get_ReferenceCount();
                /*0x1f2fe14*/ bool get_IsRunning();
                /*0x1f30a84*/ void set_IsRunning(bool value);
                /*0x1f309e4*/ void IncrementReferenceCount();
                /*0x1f309e4*/ void DecrementReferenceCount();
                /*0x1f30214*/ System.Threading.WaitHandle get_WaitHandle();
                /*0x1f30214*/ System.Threading.Tasks.Task<TObject> get_Task();
                /*0x1f30214*/ System.Threading.Tasks.Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task();
                /*0x1f30214*/ string ToString();
                /*0x1f30a84*/ void RegisterForDeferredCallbackEvent(bool incrementReferenceCount);
                /*0x1f30ebc*/ void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x1f30ebc*/ void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x1f30ebc*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f2ffc8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x1f30214*/ System.Exception get_OperationException();
                /*0x1f30ebc*/ void set_OperationException(System.Exception value);
                /*0x1f2fe14*/ bool MoveNext();
                /*0x1f309e4*/ void Reset();
                /*0x1f30214*/ object get_Current();
                /*0x1f2fe14*/ bool get_IsDone();
                /*0x1f30804*/ float get_PercentComplete();
                /*0x1f309e4*/ void InvokeCompletionEvent();
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> get_Handle();
                void UpdateCallback(float unscaledDeltaTime);
                /*0x1ffc854*/ void Complete(TObject result, bool success, string errorMsg);
                /*0x1ffc854*/ void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure);
                void Start(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);
                /*0x1f309e4*/ void InvokeExecute();
                /*0x1f30ebc*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f2ffc8*/ int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version();
                /*0x1f2ffc8*/ int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount();
                /*0x1f30804*/ float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete();
                /*0x1f2ffc8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status();
                /*0x1f30214*/ System.Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException();
                /*0x1f2fe14*/ bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone();
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle();
                /*0x1f30ebc*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> value);
                /*0x1f30214*/ string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName();
                /*0x1f30214*/ object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject();
                /*0x1f30214*/ System.Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType();
                /*0x1f30ebc*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x1f309e4*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount();
                /*0x1f309e4*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount();
                /*0x1f309e4*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent();
                void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);
                /*0x1f309e4*/ void ReleaseDependencies();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                void <.ctor>b__34_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle o);

                class <>c__DisplayClass42_0<TObject>
                {
                    /*0x0*/ System.Threading.WaitHandle handle;

                    /*0x1f309e4*/ <>c__DisplayClass42_0();
                    /*0x1ffc854*/ TObject <get_Task>b__0(object o);
                }

                class <>c__DisplayClass44_0<TObject>
                {
                    /*0x0*/ System.Threading.WaitHandle handle;

                    /*0x1f309e4*/ <>c__DisplayClass44_0();
                    /*0x1f302cc*/ object <UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task>b__0(object o);
                }

                class <>c__DisplayClass55_0<TObject>
                {
                    /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value;

                    /*0x1f309e4*/ <>c__DisplayClass55_0();
                    /*0x1ffc854*/ void <add_CompletedTypeless>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> s);
                }

                class <>c__DisplayClass56_0<TObject>
                {
                    /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value;

                    /*0x1f309e4*/ <>c__DisplayClass56_0();
                    /*0x1ffc854*/ void <remove_CompletedTypeless>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> s);
                }
            }

            struct AsyncOperationHandle<TObject> : System.Collections.IEnumerator, System.IEquatable<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>>
            {
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> m_InternalOp;
                /*0x0*/ int m_Version;
                /*0x0*/ string m_LocationName;

                static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op_Implicit(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> obj);
                /*0x1f30ebc*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> op);
                /*0x1f30ebc*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op);
                /*0x1f30ee8*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version);
                /*0x1f30ff0*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, string locationName);
                /*0x1f30f2c*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version, string locationName);
                /*0x1f30214*/ string get_LocationName();
                /*0x1f30ebc*/ void set_LocationName(string value);
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus InternalGetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> Acquire();
                /*0x1f30ebc*/ void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x1f30ebc*/ void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x1f30ebc*/ void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30214*/ string get_DebugName();
                /*0x1f30ebc*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1f30ebc*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1ffc854*/ bool Equals(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> other);
                /*0x1f2ffc8*/ int GetHashCode();
                /*0x1f30214*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> get_InternalOp();
                /*0x1f2fe14*/ bool get_IsDone();
                /*0x1f2fe14*/ bool IsValid();
                /*0x1f30214*/ System.Exception get_OperationException();
                /*0x1f30804*/ float get_PercentComplete();
                /*0x1f2ffc8*/ int get_ReferenceCount();
                /*0x1f309e4*/ void Release();
                /*0x1ffc854*/ TObject get_Result();
                /*0x1f2ffc8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x1f30214*/ System.Threading.Tasks.Task<TObject> get_Task();
                /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                /*0x1f2fe14*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x1f309e4*/ void System.Collections.IEnumerator.Reset();
            }

            struct AsyncOperationHandle : System.Collections.IEnumerator
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation m_InternalOp;
                /*0x18*/ int m_Version;
                /*0x20*/ string m_LocationName;

                /*0x3cae924*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op);
                /*0x3caea00*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version);
                /*0x3c9ccec*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, string locationName);
                /*0x3caea34*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version, string locationName);
                /*0x3cae914*/ string get_LocationName();
                /*0x3cae91c*/ void set_LocationName(string value);
                /*0x3c9dbec*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle Acquire();
                /*0x3c9e0c4*/ void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x3caeb68*/ void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<T> Convert<T>();
                /*0x3caec1c*/ bool Equals(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle other);
                /*0x3caec48*/ string get_DebugName();
                /*0x3caeddc*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x3caee90*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x3caef44*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x3caeff8*/ int GetHashCode();
                /*0x3caea6c*/ UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation get_InternalOp();
                /*0x3caf028*/ bool get_IsDone();
                /*0x3caed24*/ bool IsValid();
                /*0x3caf0f0*/ System.Exception get_OperationException();
                /*0x3caf19c*/ float get_PercentComplete();
                /*0x3caf248*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus();
                /*0x3caf2e4*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus InternalGetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x3caf464*/ int get_ReferenceCount();
                /*0x3c9db10*/ void Release();
                /*0x3ca7f1c*/ object get_Result();
                /*0x3caf510*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x3caf5bc*/ System.Threading.Tasks.Task<object> get_Task();
                /*0x3caf668*/ object System.Collections.IEnumerator.get_Current();
                /*0x3caf66c*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x3caf684*/ void System.Collections.IEnumerator.Reset();
            }

            enum AsyncOperationStatus
            {
                None = 0,
                Succeeded = 1,
                Failed = 2,
            }

            struct DownloadStatus
            {
                /*0x10*/ long TotalBytes;
                /*0x18*/ long DownloadedBytes;
                /*0x20*/ bool IsDone;

                /*0x3caf688*/ float get_Percent();
            }

            class GroupOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>>, UnityEngine.ResourceManagement.AsyncOperations.ICachable
            {
                static int k_MaxDisplayedLocationLength = 45;
                /*0x80*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_InternalOnComplete;
                /*0x88*/ int m_LoadedCount;
                /*0x8c*/ UnityEngine.ResourceManagement.AsyncOperations.GroupOperation.GroupOperationSettings m_Settings;
                /*0x90*/ string debugName;
                /*0x98*/ int <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Hash>k__BackingField;
                /*0xa0*/ System.Collections.Generic.HashSet<string> m_CachedDependencyLocations;

                /*0x3caf6c0*/ GroupOperation();
                /*0x3caf828*/ int UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Hash();
                /*0x3caf830*/ void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Hash(int value);
                /*0x3c9e048*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> GetDependentOps();
                /*0x3caf838*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x3caf8dc*/ void ReleaseDependencies();
                /*0x3cafc04*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x3cafefc*/ bool DependenciesAreUnchanged(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x3cb0128*/ string get_DebugName();
                /*0x3cb0404*/ void Execute();
                /*0x3cb06bc*/ void CompleteIfDependenciesComplete();
                /*0x3cb0ccc*/ void Destroy();
                /*0x3cb0cdc*/ float get_Progress();
                /*0x3c9df74*/ void Init(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> operations, bool releaseDependenciesOnFailure, bool allowFailedDependencies);
                /*0x3cb0f8c*/ void Init(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> operations, UnityEngine.ResourceManagement.AsyncOperations.GroupOperation.GroupOperationSettings settings);
                /*0x3cb1038*/ void OnOperationCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);

                enum GroupOperationSettings
                {
                    None = 0,
                    ReleaseDependenciesOnFailure = 1,
                    AllowFailedDependencies = 2,
                }
            }

            interface IGenericProviderOperation
            {
                /*0x1ffc854*/ void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);
                /*0x1f2ffc8*/ int get_ProvideHandleVersion();
                /*0x1f30214*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x1f2ffc8*/ int get_DependencyCount();
                /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.IList<object> dstList);
                /*0x1ffc854*/ TDepObject GetDependency<TDepObject>(int index);
                /*0x1f30ebc*/ void SetProgressCallback(System.Func<float> callback);
                /*0x1ffc854*/ void ProviderCompleted<T>(T result, bool status, System.Exception e);
                /*0x1f30214*/ System.Type get_RequestedType();
                /*0x1f30ebc*/ void SetDownloadProgressCallback(System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> callback);
            }

            class ProviderOperation<TObject> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>, UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation, UnityEngine.ResourceManagement.AsyncOperations.ICachable
            {
                static float k_OperationWaitingToCompletePercentComplete = 0.9900000095367432;
                static string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";
                /*0x0*/ bool m_ReleaseDependenciesOnFailure;
                /*0x0*/ System.Action<int, object, bool, System.Exception> m_CompletionCallback;
                /*0x0*/ System.Action<int, System.Collections.Generic.IList<object>> m_GetDepCallback;
                /*0x0*/ System.Func<float> m_GetProgressCallback;
                /*0x0*/ System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> m_GetDownloadProgressCallback;
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus m_DownloadStatus;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider m_Provider;
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
                /*0x0*/ bool m_wasDepEverValid;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation m_Location;
                /*0x0*/ int m_ProvideHandleVersion;
                /*0x0*/ bool m_NeedsRelease;
                /*0x0*/ int <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Hash>k__BackingField;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;

                /*0x1f309e4*/ ProviderOperation();
                /*0x1f2ffc8*/ int UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Hash();
                /*0x1f30b78*/ void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Hash(int value);
                /*0x1f2ffc8*/ int get_ProvideHandleVersion();
                /*0x1f30214*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x1f30ebc*/ void SetDownloadProgressCallback(System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> callback);
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x1f309e4*/ void ReleaseDependencies();
                /*0x1f30214*/ string get_DebugName();
                /*0x1f30ebc*/ void GetDependencies(System.Collections.Generic.IList<object> dstList);
                /*0x1f30214*/ System.Type get_RequestedType();
                /*0x1f2ffc8*/ int get_DependencyCount();
                /*0x1ffc854*/ TDepObject GetDependency<TDepObject>(int index);
                /*0x1f30ebc*/ void SetProgressCallback(System.Func<float> callback);
                /*0x1ffc854*/ void ProviderCompleted<T>(T result, bool status, System.Exception e);
                /*0x1f30804*/ float get_Progress();
                /*0x1f309e4*/ void Execute();
                /*0x1ffc854*/ void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);
                /*0x1f309e4*/ void Destroy();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 247FB9BC2503378474AB914E6535273212A32BA4F3E8B063B9C6E946147BF335;
    static /*0x16a8*/ long 2D2025322643CE1497D8FB03FA789F27E833CF43545CA1003AFEFEA250D39313;
    static /*0x16b0*/ <PrivateImplementationDetails> 4A1F7B222B6ADBC8BEFC809AE6E69FE6EC5632ED4DE89A73D26BCC7BC9885693;

    struct __StaticArrayInitTypeSize=3908
    {
    }

    struct __StaticArrayInitTypeSize=5798
    {
    }
}
