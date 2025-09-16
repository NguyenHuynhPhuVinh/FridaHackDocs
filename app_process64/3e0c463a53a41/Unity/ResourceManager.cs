class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7cd8e80*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x7cd8e88*/ IsUnmanagedAttribute();
            }
        }
    }
}

class DelegateList<T>
{
    /*0x0*/ System.Func<System.Action<T>, System.Collections.Generic.LinkedListNode<System.Action<T>>> m_acquireFunc;
    /*0x0*/ System.Action<System.Collections.Generic.LinkedListNode<System.Action<T>>> m_releaseFunc;
    /*0x0*/ System.Collections.Generic.LinkedList<System.Action<T>> m_callbacks;
    /*0x0*/ bool m_invoking;

    static /*0x382dee4*/ DelegateList<T> CreateWithGlobalCache();
    /*0x380d93c*/ DelegateList(System.Func<System.Action<T>, System.Collections.Generic.LinkedListNode<System.Action<T>>> acquireFunc, System.Action<System.Collections.Generic.LinkedListNode<System.Action<T>>> releaseFunc);
    /*0x380b6a0*/ int get_Count();
    /*0x380d83c*/ void Add(System.Action<T> action);
    /*0x380d83c*/ void Remove(System.Action<T> action);
    /*0x3907c14*/ void Invoke(T res);
    /*0x380cb08*/ void Clear();
}

class ListWithEvents<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
{
    /*0x0*/ System.Collections.Generic.List<T> m_List;
    /*0x0*/ System.Action<T> OnElementAdded;
    /*0x0*/ System.Action<T> OnElementRemoved;

    /*0x380cb08*/ ListWithEvents();
    /*0x380d83c*/ void add_OnElementAdded(System.Action<T> value);
    /*0x380d83c*/ void remove_OnElementAdded(System.Action<T> value);
    /*0x380d83c*/ void add_OnElementRemoved(System.Action<T> value);
    /*0x380d83c*/ void remove_OnElementRemoved(System.Action<T> value);
    /*0x3907c14*/ void InvokeAdded(T element);
    /*0x3907c14*/ void InvokeRemoved(T element);
    /*0x3907c14*/ T get_Item(int index);
    /*0x3907c14*/ void set_Item(int index, T value);
    /*0x380b6a0*/ int get_Count();
    /*0x380b128*/ bool get_IsReadOnly();
    /*0x3907c14*/ void Add(T item);
    /*0x380cb08*/ void Clear();
    /*0x3907c14*/ bool Contains(T item);
    /*0x380d8b8*/ void CopyTo(T[] array, int arrayIndex);
    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
    /*0x3907c14*/ int IndexOf(T item);
    /*0x3907c14*/ void Insert(int index, T item);
    /*0x3907c14*/ bool Remove(T item);
    /*0x380cffc*/ void RemoveAt(int index);
    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
}

class MonoBehaviourCallbackHooks : UnityEngine.ResourceManagement.Util.ComponentSingleton<MonoBehaviourCallbackHooks>
{
    /*0x20*/ System.Action<float> m_OnUpdateDelegate;
    /*0x28*/ System.Action<float> m_OnLateUpdateDelegate;

    /*0x7cd91d0*/ MonoBehaviourCallbackHooks();
    /*0x7cd8e90*/ void add_OnUpdateDelegate(System.Action<float> value);
    /*0x7cd8f38*/ void remove_OnUpdateDelegate(System.Action<float> value);
    /*0x7cd8fe0*/ void add_OnLateUpdateDelegate(System.Action<float> value);
    /*0x7cd9088*/ void remove_OnLateUpdateDelegate(System.Action<float> value);
    /*0x7cd9130*/ string GetGameObjectName();
    /*0x7cd9170*/ void Update();
    /*0x7cd91a0*/ void LateUpdate();
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7cd9218*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x7cd930c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus m_depStatus;
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus m_wrapStatus;
            /*0x0*/ System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_Callback;
            /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;
            /*0x0*/ bool m_ReleaseDependenciesOnFailure;

            /*0x380cb08*/ ChainOperation();
            /*0x380b9e8*/ string get_DebugName();
            /*0x380d83c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
            /*0x3907c14*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x380b128*/ bool InvokeWaitForCompletion();
            /*0x380cb08*/ void Execute();
            /*0x3907c14*/ void OnWrappedCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> x);
            /*0x380cb08*/ void Destroy();
            /*0x380cb08*/ void ReleaseDependencies();
            UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
            /*0x380d83c*/ void RefreshDownloadStatus(System.Collections.Generic.HashSet<object> visited);
            /*0x380c2e4*/ float get_Progress();
        }

        class ChainOperationTypelessDepedency<TObject> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>
        {
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle m_DepOp;
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> m_WrappedOp;
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus m_depStatus;
            /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus m_wrapStatus;
            /*0x0*/ System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_Callback;
            /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;
            /*0x0*/ bool m_ReleaseDependenciesOnFailure;

            /*0x380cb08*/ ChainOperationTypelessDepedency();
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> get_WrappedOp();
            /*0x380b9e8*/ string get_DebugName();
            /*0x380d83c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
            /*0x3907c14*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x380b128*/ bool InvokeWaitForCompletion();
            /*0x380cb08*/ void Execute();
            /*0x3907c14*/ void OnWrappedCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> x);
            /*0x380cb08*/ void Destroy();
            /*0x380cb08*/ void ReleaseDependencies();
            UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
            /*0x380d83c*/ void RefreshDownloadStatus(System.Collections.Generic.HashSet<object> visited);
            /*0x380c2e4*/ float get_Progress();
        }

        class ResourceManager : System.IDisposable
        {
            static /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> <ExceptionHandler>k__BackingField;
            static /*0x8*/ int s_GroupOperationTypeHash;
            static /*0xc*/ int s_InstanceOperationTypeHash;
            /*0x10*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> <InternalIdTransformFunc>k__BackingField;
            /*0x18*/ System.Action<UnityEngine.Networking.UnityWebRequest> <WebRequestOverride>k__BackingField;
            /*0x20*/ bool CallbackHooksEnabled;
            /*0x28*/ ListWithEvents<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider> m_ResourceProviders;
            /*0x30*/ UnityEngine.ResourceManagement.Util.IAllocationStrategy m_allocator;
            /*0x38*/ ListWithEvents<UnityEngine.ResourceManagement.IUpdateReceiver> m_UpdateReceivers;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.IUpdateReceiver> m_UpdateReceiversToRemove;
            /*0x48*/ bool m_UpdatingReceivers;
            /*0x49*/ bool m_InsideUpdateMethod;
            /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider> m_providerMap;
            /*0x58*/ System.Collections.Generic.Dictionary<UnityEngine.ResourceManagement.Util.IOperationCacheKey, UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_AssetOperationCache;
            /*0x60*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceManager.InstanceOperation> m_TrackedInstanceOperations;
            /*0x68*/ DelegateList<float> m_UpdateCallbacks;
            /*0x70*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_DeferredCompleteCallbacks;
            /*0x78*/ bool m_InsideExecuteDeferredCallbacksMethod;
            /*0x80*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceManager.DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister;
            /*0x88*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_ReleaseOpNonCached;
            /*0x90*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_ReleaseOpCached;
            /*0x98*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_ReleaseInstanceOp;
            /*0xa0*/ UnityEngine.Networking.CertificateHandler <CertificateHandlerInstance>k__BackingField;
            /*0xa8*/ bool m_RegisteredForCallbacks;
            /*0xb0*/ System.Collections.Generic.Dictionary<System.Type, System.Type> m_ProviderOperationTypeCache;

            static /*0x7cde248*/ ResourceManager();
            static /*0x7cd9314*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> get_ExceptionHandler();
            static /*0x7cd936c*/ void set_ExceptionHandler(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, System.Exception> value);
            /*0x7cd97bc*/ ResourceManager(UnityEngine.ResourceManagement.Util.IAllocationStrategy alloc);
            /*0x7cd93d4*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            /*0x7cd93dc*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            /*0x7cd93e4*/ string TransformInternalId(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x7cd94a8*/ System.Action<UnityEngine.Networking.UnityWebRequest> get_WebRequestOverride();
            /*0x7cd94b0*/ void set_WebRequestOverride(System.Action<UnityEngine.Networking.UnityWebRequest> value);
            /*0x7cd94b8*/ int get_OperationCacheCount();
            /*0x7cd9508*/ int get_InstanceOperationCount();
            /*0x7cd9550*/ int get_DeferredCompleteCallbacksCount();
            /*0x7cd9598*/ int get_DeferredCallbackCount();
            /*0x7cd95e4*/ void AddUpdateReceiver(UnityEngine.ResourceManagement.IUpdateReceiver receiver);
            /*0x7cd964c*/ void RemoveUpdateReciever(UnityEngine.ResourceManagement.IUpdateReceiver receiver);
            /*0x7cd9794*/ UnityEngine.ResourceManagement.Util.IAllocationStrategy get_Allocator();
            /*0x7cd979c*/ void set_Allocator(UnityEngine.ResourceManagement.Util.IAllocationStrategy value);
            /*0x7cd97a4*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider> get_ResourceProviders();
            /*0x7cd97ac*/ UnityEngine.Networking.CertificateHandler get_CertificateHandlerInstance();
            /*0x7cd97b4*/ void set_CertificateHandlerInstance(UnityEngine.Networking.CertificateHandler value);
            /*0x7cda0dc*/ void OnObjectAdded(object obj);
            /*0x7cda150*/ void OnObjectRemoved(object obj);
            /*0x7cda1c4*/ void RegisterForCallbacks();
            /*0x7cda28c*/ UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider GetResourceProvider(System.Type t, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x7cda6c8*/ System.Type GetDefaultTypeForLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x7cda7fc*/ int CalculateLocationsHash(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Type t);
            /*0x7cdac44*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle ProvideResource(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Type desiredType, bool releaseDependenciesOnFailure);
            /*0x7cdbf04*/ UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation GetOperationFromCache(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Type desiredType);
            /*0x7cdb450*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey CreateCacheKeyForLocation(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Type desiredType);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> ProvideResource<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> StartOperation<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> operation, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency);
            /*0x7cdbd90*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle StartOperation(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation operation, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency);
            /*0x7cdc084*/ void OnInstanceOperationDestroy(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation o);
            /*0x7cdc1c8*/ void OnOperationDestroyNonCached(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation o);
            /*0x7cdc29c*/ void OnOperationDestroyCached(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation o);
            /*0x3907c14*/ T CreateOperation<T>(System.Type actualType, int typeHash, UnityEngine.ResourceManagement.Util.IOperationCacheKey cacheKey, System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> onDestroyAction);
            /*0x7cdc548*/ void AddOperationToCache(UnityEngine.ResourceManagement.Util.IOperationCacheKey key, UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation operation);
            /*0x7cdc4d0*/ bool RemoveOperationFromCache(UnityEngine.ResourceManagement.Util.IOperationCacheKey key);
            /*0x7cdc5d0*/ bool IsOperationCached(UnityEngine.ResourceManagement.Util.IOperationCacheKey key);
            /*0x7cdc628*/ int CachedOperationCount();
            /*0x7cdc678*/ void ClearOperationCache();
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, System.Exception exception);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, System.Exception exception, bool releaseDependenciesOnFailure);
            /*0x7cdc6c8*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> Acquire<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x7cdc78c*/ void Acquire(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x7cdc870*/ UnityEngine.ResourceManagement.AsyncOperations.GroupOperation AcquireGroupOpFromCache(UnityEngine.ResourceManagement.Util.IOperationCacheKey key);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> CreateGroupOperation<T>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> CreateGroupOperation<T>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool allowFailedDependencies);
            /*0x7cdc9ac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> CreateGenericGroupOperation(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> operations, bool releasedCachedOpOnComplete);
            /*0x7cdb610*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> ProvideResourceGroupCached(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, int groupHash, System.Type desiredType, System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> callback, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> ProvideResources<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> ProvideResources<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool releaseDependenciesOnFailure, System.Action<TObject> callback);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperation<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency> dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObjectDependency>, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> CreateChainOperation<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependentOp, System.Func<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure);
            /*0x7cdccc0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider sceneProvider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode, bool activateOnLoad, int priority);
            /*0x7cdce20*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider sceneProvider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
            /*0x7cdcf68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider sceneProvider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            /*0x7cdd0b8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider sceneProvider, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);
            /*0x7cdd1fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> ProvideInstance(UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
            /*0x7cdd540*/ void CleanupSceneInstances(UnityEngine.SceneManagement.Scene scene);
            /*0x7cdd948*/ void ExecuteDeferredCallbacks();
            /*0x7cddafc*/ void RegisterForDeferredCallback(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, bool incrementRefCount);
            /*0x7cddd3c*/ void Update(float unscaledDeltaTime);
            /*0x7cde174*/ void Dispose();
            /*0x7cde31c*/ void <.ctor>b__53_0(UnityEngine.ResourceManagement.IUpdateReceiver x);

            enum DiagnosticEventType
            {
                AsyncOperationFail = 0,
                AsyncOperationCreate = 1,
                AsyncOperationPercentComplete = 2,
                AsyncOperationComplete = 3,
                AsyncOperationReferenceCount = 4,
                AsyncOperationDestroy = 5,
            }

            struct DeferredCallbackRegisterRequest
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation operation;
                /*0x18*/ bool incrementRefCount;
            }

            class CompletedOperation<TObject> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>
            {
                /*0x0*/ bool m_Success;
                /*0x0*/ System.Exception m_Exception;
                /*0x0*/ bool m_ReleaseDependenciesOnFailure;

                /*0x380cb08*/ CompletedOperation();
                /*0x3907c14*/ void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure);
                /*0x3907c14*/ void Init(TObject result, bool success, System.Exception exception, bool releaseDependenciesOnFailure);
                /*0x380b9e8*/ string get_DebugName();
                /*0x380b128*/ bool InvokeWaitForCompletion();
                /*0x380cb08*/ void Execute();
            }

            class InstanceOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.GameObject>
            {
                /*0x98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> m_dependency;
                /*0xb0*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters m_instantiationParams;
                /*0xe0*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider m_instanceProvider;
                /*0xe8*/ UnityEngine.GameObject m_instance;
                /*0xf0*/ UnityEngine.SceneManagement.Scene m_scene;

                /*0x7cdeab4*/ InstanceOperation();
                /*0x7cdd4c0*/ void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider instanceProvider, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiationParams, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> dependency);
                /*0x7cde320*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x7cde3fc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x7cde52c*/ string get_DebugName();
                /*0x7cde63c*/ UnityEngine.SceneManagement.Scene InstanceScene();
                /*0x7cde644*/ void Destroy();
                /*0x7cde6f8*/ float get_Progress();
                /*0x7cde740*/ bool InvokeWaitForCompletion();
                /*0x7cde870*/ void Execute();
            }

            class <>c__DisplayClass90_0<TObject>
            {
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceManager <>4__this;

                /*0x380cb08*/ <>c__DisplayClass90_0();
                void <ProvideResources>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle x);
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <ProvideResources>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle resultHandle);
            }
        }

        interface IUpdateReceiver
        {
            /*0x380e050*/ void Update(float unscaledDeltaTime);
        }

        class WebRequestQueueOperation
        {
            /*0x10*/ bool m_Completed;
            /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation Result;
            /*0x20*/ System.Action<UnityEngine.Networking.UnityWebRequestAsyncOperation> OnComplete;
            /*0x28*/ UnityEngine.Networking.UnityWebRequest m_WebRequest;

            /*0x7cdeb2c*/ WebRequestQueueOperation(UnityEngine.Networking.UnityWebRequest request);
            /*0x7cdeafc*/ bool get_IsDone();
            /*0x7cdeb1c*/ UnityEngine.Networking.UnityWebRequest get_WebRequest();
            /*0x7cdeb24*/ void set_WebRequest(UnityEngine.Networking.UnityWebRequest value);
            /*0x7cdeb5c*/ void Complete(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOp);
        }

        class WebRequestQueue
        {
            static /*0x0*/ int s_MaxRequest;
            static /*0x8*/ System.Collections.Generic.Queue<UnityEngine.ResourceManagement.WebRequestQueueOperation> s_QueuedOperations;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.UnityWebRequestAsyncOperation> s_ActiveRequests;

            static /*0x7cdf760*/ WebRequestQueue();
            static /*0x7cdeba0*/ void SetMaxConcurrentRequests(int maxRequests);
            static /*0x7cdec60*/ UnityEngine.ResourceManagement.WebRequestQueueOperation QueueRequest(UnityEngine.Networking.UnityWebRequest request);
            static /*0x7cdefdc*/ void WaitForRequestToBeActive(UnityEngine.ResourceManagement.WebRequestQueueOperation request, int millisecondsTimeout);
            static /*0x7cdf604*/ void DequeueRequest(UnityEngine.Networking.UnityWebRequestAsyncOperation operation);
            static /*0x7cdf6bc*/ void OnWebAsyncOpComplete(UnityEngine.AsyncOperation operation);
            static /*0x7cdf4fc*/ void OnWebAsyncOpComplete(UnityEngine.Networking.UnityWebRequestAsyncOperation operation);
            static /*0x7cded6c*/ void BeginWebRequest(UnityEngine.ResourceManagement.WebRequestQueueOperation queueOperation);
        }

        namespace Exceptions
        {
            class ResourceManagerException : System.Exception
            {
                /*0x7cdf858*/ ResourceManagerException();
                /*0x7cdf8b0*/ ResourceManagerException(string message);
                /*0x7cdf918*/ ResourceManagerException(string message, System.Exception innerException);
                /*0x7cdf988*/ ResourceManagerException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
                /*0x7cdfa08*/ string ToString();
            }

            class UnknownResourceProviderException : UnityEngine.ResourceManagement.Exceptions.ResourceManagerException
            {
                /*0x90*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <Location>k__BackingField;

                /*0x7cdb424*/ UnknownResourceProviderException(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x7cdfaa0*/ UnknownResourceProviderException();
                /*0x7cdfaa4*/ UnknownResourceProviderException(string message);
                /*0x7cdfaa8*/ UnknownResourceProviderException(string message, System.Exception innerException);
                /*0x7cdfaac*/ UnknownResourceProviderException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
                /*0x7cdfa90*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x7cdfa98*/ void set_Location(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation value);
                /*0x7cdfab0*/ string get_Message();
                /*0x7cdfc6c*/ string ToString();
            }

            class OperationException : System.Exception
            {
                /*0x7cdfc78*/ OperationException(string message, System.Exception innerException);
                /*0x7cdfce8*/ string ToString();
            }

            class ProviderException : UnityEngine.ResourceManagement.Exceptions.OperationException
            {
                /*0x90*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <Location>k__BackingField;

                /*0x7cdfd70*/ ProviderException(string message, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Exception innerException);
                /*0x7cdfda0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
            }

            class RemoteProviderException : UnityEngine.ResourceManagement.Exceptions.ProviderException
            {
                /*0x98*/ UnityEngine.ResourceManagement.Util.UnityWebRequestResult <WebRequestResult>k__BackingField;

                /*0x7cdfda8*/ RemoteProviderException(string message, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.Util.UnityWebRequestResult uwrResult, System.Exception innerException);
                /*0x7cdfdec*/ string get_Message();
                /*0x7cdfdf8*/ UnityEngine.ResourceManagement.Util.UnityWebRequestResult get_WebRequestResult();
                /*0x7cdfe00*/ string ToString();
            }
        }

        namespace Util
        {
            class BinaryStorageBuffer
            {
                static uint kUnicodeStringFlag = 2147483648;
                static uint kDynamicStringFlag = 1073741824;
                static uint kClearFlagsMask = 1073741823;

                static /*0x7cdffa4*/ void ComputeHash(void* pData, ulong size, UnityEngine.Hash128* hash);
                static /*0x7cdffbc*/ void AddSerializationAdapter(System.Collections.Generic.Dictionary<System.Type, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter adapter, bool forceOverride);
                static /*0x7ce05ac*/ bool GetSerializationAdapter(System.Collections.Generic.Dictionary<System.Type, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, System.Type t, ref UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter adapter);
                /*0x7ce07f4*/ BinaryStorageBuffer();

                class BuiltinTypesSerializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<int>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<bool>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<long>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<string>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.Hash128>
                {
                    /*0x7ce109c*/ BuiltinTypesSerializer();
                    /*0x7ce07fc*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x7ce0804*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                    /*0x7ce0af8*/ char FindBestSeparator(string str, char[] seps);
                    /*0x7ce0cc0*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

                    struct ObjectToStringRemap
                    {
                        /*0x10*/ uint stringId;
                        /*0x14*/ char separator;
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ char s;

                        /*0x7ce0cb8*/ <>c__DisplayClass4_0();
                        /*0x7ce10a4*/ bool <FindBestSeparator>b__0(char c);
                    }
                }

                class TypeSerializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<System.Type>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                    /*0x7ce1394*/ TypeSerializer();
                    /*0x7ce10b4*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x7ce10bc*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type type, uint offset);
                    /*0x7ce1270*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

                    struct Data
                    {
                        /*0x10*/ uint assemblyId;
                        /*0x14*/ uint classId;
                    }
                }

                struct DynamicString
                {
                    /*0x10*/ uint stringId;
                    /*0x14*/ uint nextId;
                }

                struct ObjectTypeData
                {
                    /*0x10*/ uint typeId;
                    /*0x14*/ uint objectId;
                }

                interface ISerializationAdapter
                {
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);
                    object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                }

                interface ISerializationAdapter<T> : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                }

                class Reader
                {
                    /*0x10*/ byte[] m_Buffer;
                    /*0x18*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> m_Adapters;
                    /*0x20*/ UnityEngine.ResourceManagement.Util.LRUCache<uint, object> m_Cache;
                    /*0x38*/ System.Text.StringBuilder stringBuilder;

                    /*0x7ce15a4*/ Reader(byte[] data, int maxCachedObjects, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter[] adapters);
                    /*0x7ce15f0*/ Reader(System.IO.Stream inputStream, uint bufferSize, int maxCachedObjects, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter[] adapters);
                    /*0x7ce139c*/ void Init(byte[] data, int maxCachedObjects, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter[] adapters);
                    /*0x7ce1598*/ void AddSerializationAdapter(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter a);
                    /*0x7ce15e8*/ byte[] GetBuffer();
                    /*0x3907c14*/ bool TryGetCachedValue<T>(uint offset, ref T val);
                    /*0x7ce16d4*/ object[] ReadObjectArray(uint id, bool cacheValues);
                    /*0x7ce18dc*/ object[] ReadObjectArray(System.Type t, uint id, bool cacheValues);
                    /*0x3907c14*/ T[] ReadObjectArray<T>(uint id, bool cacheValues);
                    /*0x7ce1824*/ object ReadObject(uint id, bool cacheValue);
                    /*0x3907c14*/ T ReadObject<T>(uint offset, bool cacheValue);
                    /*0x7ce1a3c*/ object ReadObject(System.Type t, uint id, bool cacheValue);
                    /*0x3907c14*/ T[] ReadValueArray<T>(uint id, bool cacheValue);
                    /*0x3907c14*/ T ReadValue<T>(uint id);
                    /*0x7ce0ad0*/ string ReadString(uint id, char sep, bool cacheValue);
                    /*0x7ce1eb0*/ string ReadStringInternal(uint offset, System.Text.Encoding enc, bool cacheValue);
                    /*0x7ce1c38*/ string ReadAutoEncodedString(uint id, bool cacheValue);
                    /*0x7ce1c8c*/ string ReadDynamicString(uint id, char sep, bool cacheValue);
                }

                class Writer
                {
                    /*0x10*/ uint totalBytes;
                    /*0x14*/ uint defaulChunkSize;
                    /*0x18*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer.Chunk> chunks;
                    /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, uint> existingValues;
                    /*0x28*/ System.Collections.Generic.Dictionary<System.Type, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> serializationAdapters;

                    static /*0x7ce3188*/ bool IsUnicode(string str);
                    static /*0x7ce322c*/ uint ComputeStringSize(string str, ref bool isUnicode);
                    /*0x7ce20d8*/ Writer(int chunkSize, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter[] adapters);
                    /*0x7ce20d0*/ uint get_Length();
                    /*0x7ce23a4*/ UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer.Chunk FindChunkWithSpace(uint length);
                    /*0x7ce2558*/ uint WriteInternal(void* pData, uint dataSize, bool prefixSize);
                    /*0x7ce2708*/ uint ReserveInternal(uint dataSize, bool prefixSize);
                    /*0x7ce2760*/ void WriteInternal(uint id, void* pData, uint dataSize, bool prefixSize);
                    /*0x380c7f0*/ uint Reserve<T>();
                    /*0x380c81c*/ uint Write<T>(ref T val);
                    /*0x3907c14*/ uint Write<T>(T val);
                    uint Write<T>(uint offset, ref T val);
                    /*0x3907c14*/ uint Write<T>(uint offset, T val);
                    /*0x380c858*/ uint Reserve<T>(uint count);
                    /*0x3907c14*/ uint Write<T>(T[] values, bool hashElements);
                    /*0x3907c14*/ uint Write<T>(uint offset, T[] values, bool hashElements);
                    /*0x3907c14*/ uint WriteObjects<T>(System.Collections.Generic.IEnumerable<T> objs, bool serizalizeTypeData);
                    /*0x7ce29e0*/ uint WriteObject(object obj, bool serializeTypeData);
                    /*0x7ce1080*/ uint WriteString(string str, char sep);
                    /*0x7ce2d60*/ uint WriteStringInternal(string val, System.Text.Encoding enc);
                    /*0x7ce2dbc*/ byte[] SerializeToByteArray();
                    /*0x7ce3008*/ uint SerializeToStream(System.IO.Stream str);
                    /*0x7ce2cc0*/ uint WriteAutoEncodedString(string str);
                    /*0x7ce31f4*/ uint WriteUnicodeString(string str);
                    /*0x7ce2b28*/ uint WriteDynamicString(string str, char sep);
                    /*0x7ce3280*/ uint RecurseDynamicStringParts(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer.StringParts[] parts, int index, char sep, uint minSize);

                    class Chunk
                    {
                        /*0x10*/ uint position;
                        /*0x18*/ byte[] data;

                        /*0x7ce239c*/ Chunk();
                    }

                    struct StringParts
                    {
                        /*0x10*/ string str;
                        /*0x18*/ uint dataSize;
                        /*0x1c*/ bool isUnicode;
                    }
                }
            }

            struct LRUCache<TKey, TValue>
            {
                /*0x0*/ int entryLimit;
                /*0x0*/ System.Collections.Generic.Dictionary<TKey, UnityEngine.ResourceManagement.Util.LRUCache.Entry<TKey, TValue>> cache;
                /*0x0*/ System.Collections.Generic.LinkedList<TKey> lru;

                /*0x380cffc*/ LRUCache(int limit);
                /*0x3907c14*/ bool TryAdd(TKey id, TValue obj);
                /*0x3907c14*/ bool TryGet(TKey offset, ref TValue val);

                struct Entry<TKey, TValue> : System.IEquatable<UnityEngine.ResourceManagement.Util.LRUCache.Entry<TKey, TValue>>
                {
                    /*0x0*/ System.Collections.Generic.LinkedListNode<TKey> lruNode;
                    /*0x0*/ TValue Value;

                    /*0x3907c14*/ bool Equals(UnityEngine.ResourceManagement.Util.LRUCache.Entry<TKey, TValue> other);
                    /*0x380b6a0*/ int GetHashCode();
                }
            }

            class ComponentSingleton<T> : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ T s_Instance;

                static /*0x3818690*/ bool get_Exists();
                static /*0x3907c14*/ T get_Instance();
                static /*0x3907c14*/ T FindInstance();
                static /*0x3907c14*/ T CreateNewSingleton();
                static /*0x38358cc*/ void DestroySingleton();
                /*0x380cb08*/ ComponentSingleton();
                /*0x380b9e8*/ string GetGameObjectName();
                /*0x380cb08*/ void Awake();
            }

            class DelayedActionManager : UnityEngine.ResourceManagement.Util.ComponentSingleton<UnityEngine.ResourceManagement.Util.DelayedActionManager>
            {
                /*0x20*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo> m_Actions;
                /*0x28*/ System.Collections.Generic.LinkedList<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo> m_DelayedActions;
                /*0x30*/ System.Collections.Generic.Stack<System.Collections.Generic.LinkedListNode<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo>> m_NodeCache;
                /*0x38*/ int m_CollectionIndex;
                /*0x3c*/ bool m_DestroyOnCompletion;

                static /*0x7ce35b0*/ void Clear();
                static /*0x7ce3630*/ void AddAction(System.Delegate action, float delay, object[] parameters);
                static /*0x7ce3984*/ bool get_IsActive();
                static /*0x7ce3aa0*/ bool Wait(float timeout, float timeAdvanceAmount);
                /*0x7ce4180*/ DelayedActionManager();
                /*0x7ce34a8*/ System.Collections.Generic.LinkedListNode<UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo> GetNode(ref UnityEngine.ResourceManagement.Util.DelayedActionManager.DelegateInfo del);
                /*0x7ce3624*/ void DestroyWhenComplete();
                /*0x7ce36a4*/ void AddActionInternal(System.Delegate action, float delay, object[] parameters);
                /*0x7ce3f1c*/ void LateUpdate();
                /*0x7ce3c00*/ void InternalLateUpdate(float t);
                /*0x7ce40cc*/ void OnApplicationQuit();

                struct DelegateInfo
                {
                    static /*0x0*/ int s_Id;
                    /*0x10*/ int m_Id;
                    /*0x18*/ System.Delegate m_Delegate;
                    /*0x20*/ object[] m_Target;
                    /*0x28*/ float <InvocationTime>k__BackingField;

                    /*0x7ce38ec*/ DelegateInfo(System.Delegate d, float invocationTime, object[] p);
                    /*0x7ce4380*/ float get_InvocationTime();
                    /*0x7ce4388*/ void set_InvocationTime(float value);
                    /*0x7ce4390*/ string ToString();
                    /*0x7ce3f38*/ void Invoke();
                }
            }

            interface IOperationCacheKey : System.IEquatable<UnityEngine.ResourceManagement.Util.IOperationCacheKey>
            {
            }

            class IdCacheKey : UnityEngine.ResourceManagement.Util.IOperationCacheKey, System.IEquatable<UnityEngine.ResourceManagement.Util.IOperationCacheKey>
            {
                /*0x10*/ string ID;
                /*0x18*/ System.Type locationType;

                /*0x7ce4738*/ IdCacheKey(string id);
                /*0x7ce47a0*/ IdCacheKey(System.Type locType, string id);
                /*0x7ce47e4*/ bool Equals(UnityEngine.ResourceManagement.Util.IdCacheKey other);
                /*0x7ce4864*/ int GetHashCode();
                /*0x7ce48bc*/ bool Equals(object obj);
                /*0x7ce4920*/ bool Equals(UnityEngine.ResourceManagement.Util.IOperationCacheKey other);
            }

            class LocationCacheKey : UnityEngine.ResourceManagement.Util.IOperationCacheKey, System.IEquatable<UnityEngine.ResourceManagement.Util.IOperationCacheKey>
            {
                /*0x10*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation m_Location;
                /*0x18*/ System.Type m_DesiredType;

                /*0x7cdbfa8*/ LocationCacheKey(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Type desiredType);
                /*0x7ce4984*/ int GetHashCode();
                /*0x7ce4a30*/ bool Equals(object obj);
                /*0x7ce4af0*/ bool Equals(UnityEngine.ResourceManagement.Util.IOperationCacheKey other);
                /*0x7ce4a94*/ bool Equals(UnityEngine.ResourceManagement.Util.LocationCacheKey other);
            }

            class DependenciesCacheKey : UnityEngine.ResourceManagement.Util.IOperationCacheKey, System.IEquatable<UnityEngine.ResourceManagement.Util.IOperationCacheKey>
            {
                /*0x10*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_Dependencies;
                /*0x18*/ int m_DependenciesHash;

                /*0x7cdcbd0*/ DependenciesCacheKey(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> dependencies, int dependenciesHash);
                /*0x7ce4e48*/ int GetHashCode();
                /*0x7ce4e50*/ bool Equals(object obj);
                /*0x7ce4f08*/ bool Equals(UnityEngine.ResourceManagement.Util.IOperationCacheKey other);
                /*0x7ce4ee0*/ bool Equals(UnityEngine.ResourceManagement.Util.DependenciesCacheKey other);
            }

            class AsyncOpHandlesCacheKey : UnityEngine.ResourceManagement.Util.IOperationCacheKey, System.IEquatable<UnityEngine.ResourceManagement.Util.IOperationCacheKey>
            {
                /*0x10*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_Handles;

                /*0x7cdcb40*/ AsyncOpHandlesCacheKey(System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> handles);
                /*0x7ce5224*/ int GetHashCode();
                /*0x7ce5244*/ bool Equals(object obj);
                /*0x7ce5324*/ bool Equals(UnityEngine.ResourceManagement.Util.IOperationCacheKey other);
                /*0x7ce52a8*/ bool Equals(UnityEngine.ResourceManagement.Util.AsyncOpHandlesCacheKey other);
            }

            class LocationUtils
            {
                static /*0x7ce4b54*/ bool LocationEquals(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc1, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc2);
                static /*0x7ce4f98*/ bool DependenciesEqual(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> deps1, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> deps2);
            }

            class PlatformUtilities
            {
                static /*0x7ce5388*/ bool PlatformUsesMultiThreading(UnityEngine.RuntimePlatform platform);
                /*0x7ce5394*/ PlatformUtilities();
            }

            interface IInitializableObject
            {
                /*0x380b32c*/ bool Initialize(string id, string data);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);
            }

            interface IObjectInitializationDataProvider
            {
                /*0x380b9e8*/ string get_Name();
                UnityEngine.ResourceManagement.Util.ObjectInitializationData CreateObjectInitializationData();
            }

            interface IAllocationStrategy
            {
                /*0x380bc74*/ object New(System.Type type, int typeHash);
                /*0x380d170*/ void Release(int typeHash, object obj);
            }

            class DefaultAllocationStrategy : UnityEngine.ResourceManagement.Util.IAllocationStrategy
            {
                /*0x7ce53ac*/ DefaultAllocationStrategy();
                /*0x7ce539c*/ object New(System.Type type, int typeHash);
                /*0x7ce53a8*/ void Release(int typeHash, object obj);
            }

            class LRUCacheAllocationStrategy : UnityEngine.ResourceManagement.Util.IAllocationStrategy
            {
                /*0x10*/ int m_poolMaxSize;
                /*0x14*/ int m_poolInitialCapacity;
                /*0x18*/ int m_poolCacheMaxSize;
                /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<object>> m_poolCache;
                /*0x28*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<object>> m_cache;

                /*0x7cd9ce0*/ LRUCacheAllocationStrategy(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity);
                /*0x7ce53b4*/ System.Collections.Generic.List<object> GetPool();
                /*0x7ce54a4*/ void ReleasePool(System.Collections.Generic.List<object> pool);
                /*0x7ce5574*/ object New(System.Type type, int typeHash);
                /*0x7ce56b0*/ void Release(int typeHash, object obj);
            }

            class SerializedTypeRestrictionAttribute : System.Attribute
            {
                /*0x10*/ System.Type type;

                /*0x7ce57f0*/ SerializedTypeRestrictionAttribute();
            }

            class LinkedListNodeCache<T>
            {
                /*0x0*/ int m_NodesCreated;
                /*0x0*/ System.Collections.Generic.LinkedList<T> m_NodeCache;

                /*0x380cb08*/ LinkedListNodeCache();
                /*0x3907c14*/ System.Collections.Generic.LinkedListNode<T> Acquire(T val);
                /*0x380d83c*/ void Release(System.Collections.Generic.LinkedListNode<T> node);
                /*0x380b6a0*/ int get_CreatedNodeCount();
                /*0x380b6a0*/ int get_CachedNodeCount();
                /*0x380cffc*/ void set_CachedNodeCount(int value);
            }

            class GlobalLinkedListNodeCache<T>
            {
                static /*0x0*/ UnityEngine.ResourceManagement.Util.LinkedListNodeCache<T> m_globalCache;

                static /*0x3818690*/ bool get_CacheExists();
                static /*0x3837458*/ void SetCacheSize(int length);
                static /*0x3907c14*/ System.Collections.Generic.LinkedListNode<T> Acquire(T val);
                static /*0x3837da0*/ void Release(System.Collections.Generic.LinkedListNode<T> node);
            }

            struct SerializedType
            {
                /*0x10*/ string m_AssemblyName;
                /*0x18*/ string m_ClassName;
                /*0x20*/ System.Type m_CachedType;
                /*0x28*/ bool <ValueChanged>k__BackingField;

                /*0x7ce57f8*/ string get_AssemblyName();
                /*0x7ce5800*/ string get_ClassName();
                /*0x7ce5808*/ string ToString();
                /*0x7ce58ac*/ System.Type get_Value();
                /*0x7ce5a94*/ void set_Value(System.Type value);
                /*0x7ce5b5c*/ bool get_ValueChanged();
                /*0x7ce5b64*/ void set_ValueChanged(bool value);
            }

            struct ObjectInitializationData
            {
                /*0x10*/ string m_Id;
                /*0x18*/ UnityEngine.ResourceManagement.Util.SerializedType m_ObjectType;
                /*0x38*/ string m_Data;

                /*0x7ce5b70*/ string get_Id();
                /*0x7ce5b78*/ UnityEngine.ResourceManagement.Util.SerializedType get_ObjectType();
                /*0x7ce5b88*/ string get_Data();
                /*0x7ce5b90*/ string ToString();
                /*0x3907c14*/ TObject CreateInstance<TObject>(string idOverride);
                /*0x7ce5c28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle GetAsyncInitHandle(UnityEngine.ResourceManagement.ResourceManager rm, string idOverride);

                class Serializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.ResourceManagement.Util.ObjectInitializationData>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                    /*0x7ce6124*/ Serializer();
                    /*0x7ce5e74*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x7ce5e7c*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                    /*0x7ce6000*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

                    struct Data
                    {
                        /*0x10*/ uint id;
                        /*0x14*/ uint type;
                        /*0x18*/ uint data;
                    }
                }
            }

            class ResourceManagerConfig
            {
                static /*0x7ce612c*/ bool ExtractKeyAndSubKey(object keyObj, ref string mainKey, ref string subKey);
                static /*0x7ce621c*/ bool IsPathRemote(string path);
                static /*0x7ce6280*/ string StripQueryParameters(string path);
                static /*0x7ce62c4*/ bool ShouldPathUseWebRequest(string path);
                static /*0x7ce6340*/ bool PlatformCanLoadLocallyFromUrlPath();
                static /*0x7ce6464*/ System.Array CreateArrayResult(System.Type type, UnityEngine.Object[] allAssets);
                static /*0x3907c14*/ TObject CreateArrayResult<TObject>(UnityEngine.Object[] allAssets);
                static /*0x7ce65f4*/ System.Collections.IList CreateListResult(System.Type type, UnityEngine.Object[] allAssets);
                static /*0x3907c14*/ TObject CreateListResult<TObject>(UnityEngine.Object[] allAssets);
                static /*0x3818690*/ bool IsInstance<T1, T2>();
            }

            enum BundleSource
            {
                None = 0,
                Local = 1,
                Cache = 2,
                Download = 4,
            }

            class UnityWebRequestUtilities
            {
                static string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";

                static /*0x7ce67b4*/ bool RequestHasErrors(UnityEngine.Networking.UnityWebRequest webReq, ref UnityEngine.ResourceManagement.Util.UnityWebRequestResult result);
                static /*0x7cdf458*/ bool IsAssetBundleDownloaded(UnityEngine.Networking.UnityWebRequestAsyncOperation op);
                static /*0x7ce6a14*/ void LogOperationResult(UnityEngine.AsyncOperation op);
                static /*0x7ce6b38*/ void Log(string msg);
                static /*0x7ce6ae0*/ void LogError(string msg);
                /*0x7ce6b90*/ UnityWebRequestUtilities();
            }

            class UnityWebRequestResult
            {
                /*0x10*/ string <Error>k__BackingField;
                /*0x18*/ long <ResponseCode>k__BackingField;
                /*0x20*/ UnityEngine.Networking.UnityWebRequest.Result <Result>k__BackingField;
                /*0x28*/ string <Method>k__BackingField;
                /*0x30*/ string <Url>k__BackingField;

                /*0x7ce68f4*/ UnityWebRequestResult(UnityEngine.Networking.UnityWebRequest request);
                /*0x7ce6b98*/ string ToString();
                /*0x7ce6d0c*/ string get_Error();
                /*0x7ce6d14*/ void set_Error(string value);
                /*0x7ce6d1c*/ long get_ResponseCode();
                /*0x7ce6d24*/ UnityEngine.Networking.UnityWebRequest.Result get_Result();
                /*0x7ce6d2c*/ string get_Method();
                /*0x7ce6d34*/ string get_Url();
                /*0x7ce6d3c*/ bool ShouldRetryDownloadError();
            }
        }

        namespace ResourceProviders
        {
            class DownloadOnlyLocation : UnityEngine.ResourceManagement.ResourceLocations.LocationWrapper
            {
                /*0x7ce7034*/ DownloadOnlyLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            }

            enum AssetLoadMode
            {
                RequestedAssetAndDependencies = 0,
                AllPackedAssetsAndDependencies = 1,
            }

            interface IAssetBundleResource
            {
                /*0x380b9e8*/ UnityEngine.AssetBundle GetAssetBundle();
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
                /*0x38*/ UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode m_AssetLoadMode;
                /*0x40*/ long m_BundleSize;
                /*0x48*/ bool m_UseCrcForCachedBundles;
                /*0x49*/ bool m_UseUWRForLocalBundles;
                /*0x4a*/ bool m_ClearOtherCachedVersionsWhenLoaded;

                /*0x7ce72b8*/ AssetBundleRequestOptions();
                /*0x7ce7094*/ string get_Hash();
                /*0x7ce709c*/ void set_Hash(string value);
                /*0x7ce70a4*/ uint get_Crc();
                /*0x7ce70ac*/ void set_Crc(uint value);
                /*0x7ce70b4*/ int get_Timeout();
                /*0x7ce70bc*/ void set_Timeout(int value);
                /*0x7ce70c4*/ bool get_ChunkedTransfer();
                /*0x7ce70cc*/ void set_ChunkedTransfer(bool value);
                /*0x7ce70d8*/ int get_RedirectLimit();
                /*0x7ce70ec*/ void set_RedirectLimit(int value);
                /*0x7ce70f4*/ int get_RetryCount();
                /*0x7ce70fc*/ void set_RetryCount(int value);
                /*0x7ce7104*/ string get_BundleName();
                /*0x7ce710c*/ void set_BundleName(string value);
                /*0x7ce7114*/ UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode get_AssetLoadMode();
                /*0x7ce711c*/ void set_AssetLoadMode(UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode value);
                /*0x7ce7124*/ long get_BundleSize();
                /*0x7ce712c*/ void set_BundleSize(long value);
                /*0x7ce7134*/ bool get_UseCrcForCachedBundle();
                /*0x7ce713c*/ void set_UseCrcForCachedBundle(bool value);
                /*0x7ce7148*/ bool get_UseUnityWebRequestForLocalBundles();
                /*0x7ce7150*/ void set_UseUnityWebRequestForLocalBundles(bool value);
                /*0x7ce715c*/ bool get_ClearOtherCachedVersionsWhenLoaded();
                /*0x7ce7164*/ void set_ClearOtherCachedVersionsWhenLoaded(bool value);
                /*0x7ce7170*/ long ComputeSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceManager resourceManager);
            }

            class AssetBundleResource : UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource, UnityEngine.ResourceManagement.IUpdateReceiver
            {
                static int k_WaitForWebRequestMainThreadSleep = 1;
                /*0x10*/ UnityEngine.AssetBundle m_AssetBundle;
                /*0x18*/ UnityEngine.AsyncOperation m_RequestOperation;
                /*0x20*/ UnityEngine.ResourceManagement.WebRequestQueueOperation m_WebRequestQueueOperation;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProvideHandle;
                /*0x40*/ UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions m_Options;
                /*0x48*/ bool m_RequestCompletedCallbackCalled;
                /*0x4c*/ int m_Retries;
                /*0x50*/ UnityEngine.ResourceManagement.Util.BundleSource m_Source;
                /*0x58*/ long m_BytesToDownload;
                /*0x60*/ long m_DownloadedBytes;
                /*0x68*/ bool m_Completed;
                /*0x70*/ UnityEngine.AssetBundleUnloadOperation m_UnloadOperation;
                /*0x78*/ string m_TransformedInternalId;
                /*0x80*/ UnityEngine.AssetBundleRequest m_PreloadRequest;
                /*0x88*/ bool m_PreloadCompleted;
                /*0x90*/ ulong m_LastDownloadedByteCount;
                /*0x98*/ float m_TimeoutTimer;
                /*0x9c*/ int m_TimeoutOverFrames;
                /*0xa0*/ bool m_DownloadOnly;
                /*0xa4*/ int m_LastFrameCount;
                /*0xa8*/ float m_TimeSecSinceLastUpdate;
                /*0xb0*/ System.Func<UnityEngine.ResourceManagement.Util.UnityWebRequestResult, bool> m_RequestRetryCallback;

                static /*0x7ce9550*/ void GetLoadInfo(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle handle, ref UnityEngine.ResourceManagement.ResourceProviders.AssetBundleResource.LoadType loadType, ref string path);
                static /*0x7ce9580*/ void GetLoadInfo(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceManager resourceManager, ref UnityEngine.ResourceManagement.ResourceProviders.AssetBundleResource.LoadType loadType, ref string path);
                /*0x7ce9fb0*/ AssetBundleResource();
                /*0x7ce7318*/ bool get_HasTimedOut();
                /*0x7ce7358*/ long get_BytesToDownload();
                /*0x7ce745c*/ UnityEngine.Networking.UnityWebRequest CreateWebRequest(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
                /*0x7ce7484*/ UnityEngine.Networking.UnityWebRequest CreateWebRequest(string url);
                /*0x7ce7808*/ UnityEngine.AssetBundleRequest GetAssetPreloadRequest();
                /*0x7ce7958*/ float PercentComplete();
                /*0x7ce7970*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus();
                /*0x7ce793c*/ UnityEngine.AssetBundle GetAssetBundle();
                /*0x7ce76c8*/ void AddBundleToProfiler(UnityEngine.ResourceManagement.Profiling.ContentStatus status, UnityEngine.ResourceManagement.Util.BundleSource source);
                /*0x7ce8158*/ void RemoveBundleFromProfiler();
                /*0x7ce81c4*/ void OnUnloadOperationComplete(UnityEngine.AsyncOperation op);
                /*0x7ce83ec*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle, UnityEngine.AssetBundleUnloadOperation unloadOp, System.Func<UnityEngine.ResourceManagement.Util.UnityWebRequestResult, bool> requestRetryCallback);
                /*0x7ce89c8*/ bool WaitForCompletionHandler();
                /*0x7ce94f0*/ void AddCallbackInvokeIfDone(UnityEngine.AsyncOperation operation, System.Action<UnityEngine.AsyncOperation> callback);
                /*0x7ce81e4*/ void BeginOperation();
                /*0x7ce97f8*/ void LoadLocalBundle();
                /*0x7ce98c8*/ UnityEngine.ResourceManagement.WebRequestQueueOperation EnqueueWebRequest(string internalId);
                /*0x7ce99d8*/ void AddBeginWebRequestHandler(UnityEngine.ResourceManagement.WebRequestQueueOperation webRequestQueueOperation);
                /*0x7ce9af8*/ void BeginWebRequestOperation(UnityEngine.AsyncOperation asyncOp);
                /*0x7ce9c0c*/ void Update(float unscaledDeltaTime);
                /*0x7ce9440*/ void LocalRequestOperationCompleted(UnityEngine.AsyncOperation op);
                /*0x7ce9d70*/ void CompleteBundleLoad(UnityEngine.AssetBundle bundle);
                /*0x7ce8d70*/ void WebRequestOperationCompleted(UnityEngine.AsyncOperation op);
                /*0x7ce9ecc*/ bool Unload(ref UnityEngine.AssetBundleUnloadOperation unloadOp);
                /*0x7cea0a8*/ void <GetAssetPreloadRequest>b__30_0(UnityEngine.AsyncOperation operation);
                /*0x7cea0b4*/ void <AddBeginWebRequestHandler>b__45_0(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOp);

                enum LoadType
                {
                    None = 0,
                    Local = 1,
                    Web = 2,
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.ResourceManagement.ResourceProviders.AssetBundleResource.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.ResourceManagement.Util.UnityWebRequestResult, bool> <>9__52_0;

                    static /*0x7cea0b8*/ <>c();
                    /*0x7cea120*/ <>c();
                    /*0x7cea128*/ bool <.ctor>b__52_0(UnityEngine.ResourceManagement.Util.UnityWebRequestResult x);
                }
            }

            class AssetBundleProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, UnityEngine.AssetBundleUnloadOperation> m_UnloadingBundles;

                static /*0x7ceaadc*/ AssetBundleProvider();
                static /*0x7cea13c*/ void Init();
                static /*0x7cea1e4*/ System.Collections.Generic.Dictionary<string, UnityEngine.AssetBundleUnloadOperation> get_UnloadingBundles();
                static /*0x7cea23c*/ void set_UnloadingBundles(System.Collections.Generic.Dictionary<string, UnityEngine.AssetBundleUnloadOperation> value);
                static /*0x7cea2a4*/ int get_UnloadingAssetBundleCount();
                static /*0x7cea31c*/ int get_AssetBundleCount();
                static /*0x7cea39c*/ void WaitForAllUnloadingBundlesToComplete();
                /*0x7ceaacc*/ AssetBundleProvider();
                /*0x7cea498*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);
                /*0x7cea66c*/ System.Type GetDefaultType(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x7cea6cc*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object asset);
                /*0x7ceaa20*/ bool ShouldRetryDownloadError(UnityEngine.ResourceManagement.Util.UnityWebRequestResult uwrResult);
                /*0x7ceaa34*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey CreateCacheKeyForLocation(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Type desiredType);

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;

                    /*0x7ceaa18*/ <>c__DisplayClass12_0();
                    /*0x7ceab74*/ void <Release>b__0(UnityEngine.AsyncOperation op);
                }
            }

            class AtlasSpriteProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x7ceb07c*/ AtlasSpriteProvider();
                /*0x7ceac6c*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);
                /*0x7ceaff0*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object obj);
            }

            class BinaryAssetProvider<TAdapter> : UnityEngine.ResourceManagement.ResourceProviders.BinaryDataProvider
            {
                /*0x380cb08*/ BinaryAssetProvider();
                /*0x380bcbc*/ object Convert(System.Type type, byte[] data);
            }

            class BinaryDataProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x1c*/ bool <IgnoreFailures>k__BackingField;

                /*0x7ceb5b4*/ BinaryDataProvider();
                /*0x7ceb084*/ bool get_IgnoreFailures();
                /*0x7ceb08c*/ void set_IgnoreFailures(bool value);
                /*0x7ceb098*/ object Convert(System.Type type, byte[] data);
                /*0x7ceb0a0*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);

                class InternalOp
                {
                    /*0x10*/ UnityEngine.ResourceManagement.ResourceProviders.BinaryDataProvider m_Provider;
                    /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation m_RequestOperation;
                    /*0x20*/ UnityEngine.ResourceManagement.WebRequestQueueOperation m_RequestQueueOperation;
                    /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_PI;
                    /*0x40*/ bool m_IgnoreFailures;
                    /*0x41*/ bool m_Complete;
                    /*0x44*/ int m_Timeout;

                    /*0x7ceb140*/ InternalOp();
                    /*0x7ceb5bc*/ float GetPercentComplete();
                    /*0x7ceb148*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle, UnityEngine.ResourceManagement.ResourceProviders.BinaryDataProvider rawProvider);
                    /*0x7ceb778*/ bool WaitForCompletionHandler();
                    /*0x7ceb7ec*/ void RequestOperation_completed(UnityEngine.AsyncOperation op);
                    /*0x7ceb9b0*/ void CompleteOperation(byte[] data, System.Exception exception);
                    /*0x7ceb5d4*/ object ConvertBytes(byte[] data);
                    /*0x7ceba54*/ void SendWebRequest(string path);
                    /*0x7cebcfc*/ void <SendWebRequest>b__13_0(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                }
            }

            class BundledAssetProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x7cec240*/ BundledAssetProvider();
                /*0x7cebda4*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);

                class InternalOp
                {
                    /*0x10*/ UnityEngine.AssetBundle m_AssetBundle;
                    /*0x18*/ UnityEngine.AssetBundleRequest m_PreloadRequest;
                    /*0x20*/ UnityEngine.AssetBundleRequest m_RequestOperation;
                    /*0x28*/ object m_Result;
                    /*0x30*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProvideHandle;
                    /*0x48*/ string subObjectName;

                    static /*0x3907c14*/ T LoadBundleFromDependecies<T>(System.Collections.Generic.IList<object> results);
                    static /*0x7cec248*/ bool IsDownloadOnly(System.Collections.Generic.IList<object> results);
                    /*0x7cebe34*/ InternalOp();
                    /*0x7cebe3c*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                    /*0x7cec620*/ void BeginAssetLoad();
                    /*0x7ced16c*/ bool WaitForCompletionHandler();
                    /*0x7cec9f8*/ void ActionComplete(UnityEngine.AsyncOperation obj);
                    /*0x7ced26c*/ void GetArrayResult(UnityEngine.Object[] allAssets);
                    /*0x7ced2a4*/ void GetListResult(UnityEngine.Object[] allAssets);
                    /*0x7ced2dc*/ void GetAssetResult(UnityEngine.Object asset);
                    /*0x7ced3a0*/ void GetAssetSubObjectResult(UnityEngine.Object[] allAssets);
                    /*0x7ced484*/ void CompleteOperation();
                    /*0x7ced5e8*/ float ProgressCallback();
                    /*0x7ced600*/ void <Start>b__8_0(UnityEngine.AsyncOperation operation);
                }
            }

            struct InstantiationParameters
            {
                /*0x10*/ UnityEngine.Vector3 m_Position;
                /*0x1c*/ UnityEngine.Quaternion m_Rotation;
                /*0x30*/ UnityEngine.Transform m_Parent;
                /*0x38*/ bool m_InstantiateInWorldPosition;
                /*0x39*/ bool m_SetPositionRotation;

                /*0x7ced634*/ InstantiationParameters(UnityEngine.Transform parent, bool instantiateInWorldSpace);
                /*0x7ced6f0*/ InstantiationParameters(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
                /*0x7ced604*/ UnityEngine.Vector3 get_Position();
                /*0x7ced610*/ UnityEngine.Quaternion get_Rotation();
                /*0x7ced61c*/ UnityEngine.Transform get_Parent();
                /*0x7ced624*/ bool get_InstantiateInWorldPosition();
                /*0x7ced62c*/ bool get_SetPositionRotation();
                /*0x3907c14*/ TObject Instantiate<TObject>(TObject source);
            }

            interface IInstanceProvider
            {
                UnityEngine.GameObject ProvideInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> prefabHandle, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
                /*0x380d93c*/ void ReleaseInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.GameObject instance);
            }

            class InstanceProvider : UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider
            {
                /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject>> m_InstanceObjectToPrefabHandle;

                /*0x7ceda0c*/ InstanceProvider();
                /*0x7ced720*/ UnityEngine.GameObject ProvideInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> prefabHandle, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
                /*0x7ced808*/ void ReleaseInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.GameObject instance);
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

                /*0x7ceda94*/ ProvideHandle(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation op);
                /*0x7ce7ac0*/ bool get_IsValid();
                /*0x7cedb6c*/ UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation get_InternalOp();
                /*0x7cedc6c*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
                /*0x7ceb6cc*/ System.Type get_Type();
                /*0x7ce73b0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x7cedc74*/ int get_DependencyCount();
                /*0x3907c14*/ TDepObject GetDependency<TDepObject>(int index);
                /*0x7cec56c*/ void GetDependencies(System.Collections.Generic.IList<object> list);
                /*0x7ce87ac*/ void SetProgressCallback(System.Func<float> callback);
                /*0x7ce8860*/ void SetDownloadProgressCallbacks(System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> callback);
                /*0x7ce8914*/ void SetWaitForCompletionCallback(System.Func<bool> callback);
                /*0x3907c14*/ void Complete<T>(T result, bool status, System.Exception exception);
            }

            interface IResourceProvider
            {
                /*0x380b9e8*/ string get_ProviderId();
                /*0x380bb68*/ System.Type GetDefaultType(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x380b32c*/ bool CanProvide(System.Type type, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                /*0x380d93c*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object asset);
                /*0x380b6a0*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderBehaviourFlags get_BehaviourFlags();
            }

            enum SceneReleaseMode
            {
                ReleaseSceneWhenSceneUnloaded = 0,
                OnlyReleaseSceneOnHandleRelease = 1,
            }

            struct SceneInstance
            {
                /*0x10*/ UnityEngine.SceneManagement.Scene m_Scene;
                /*0x14*/ bool m_ReleaseOnSceneUnloaded;
                /*0x18*/ UnityEngine.AsyncOperation m_Operation;

                /*0x7cedd20*/ UnityEngine.SceneManagement.Scene get_Scene();
                /*0x7cedd28*/ void set_Scene(UnityEngine.SceneManagement.Scene value);
                /*0x7cedd30*/ bool get_ReleaseSceneOnSceneUnloaded();
                /*0x7cedd38*/ void set_ReleaseSceneOnSceneUnloaded(bool value);
                /*0x7cedd44*/ UnityEngine.AsyncOperation ActivateAsync();
                /*0x7cedd70*/ int GetHashCode();
                /*0x7cedd94*/ bool Equals(object obj);
            }

            interface ISceneProvider
            {
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);
            }

            interface ISceneProvider2 : UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider
            {
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions);
            }

            class SceneProviderExtensions
            {
                static /*0x7cede4c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider provider, UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions);
            }

            class JsonAssetProvider : UnityEngine.ResourceManagement.ResourceProviders.TextDataProvider
            {
                /*0x7cee080*/ JsonAssetProvider();
                /*0x7cee074*/ object Convert(System.Type type, string text);
            }

            class ResourceProviderBase : UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, UnityEngine.ResourceManagement.Util.IInitializableObject
            {
                /*0x10*/ string m_ProviderId;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderBehaviourFlags m_BehaviourFlags;

                /*0x7ceaad4*/ ResourceProviderBase();
                /*0x7cee090*/ string get_ProviderId();
                /*0x7cee0f4*/ bool Initialize(string id, string data);
                /*0x7cee124*/ bool CanProvide(System.Type t, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x7cee164*/ string ToString();
                /*0x7cee170*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object obj);
                /*0x7cee174*/ System.Type GetDefaultType(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);
                /*0x7cee1a4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);
                /*0x7cee384*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.get_BehaviourFlags();

                class BaseInitAsyncOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
                {
                    /*0x98*/ System.Func<bool> m_CallBack;

                    /*0x7cee33c*/ BaseInitAsyncOp();
                    /*0x7cee38c*/ void Init(System.Func<bool> callback);
                    /*0x7cee394*/ bool InvokeWaitForCompletion();
                    /*0x7cee404*/ void Execute();
                }

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase <>4__this;
                    /*0x18*/ string id;
                    /*0x20*/ string data;

                    /*0x7cee334*/ <>c__DisplayClass10_0();
                    /*0x7cee48c*/ bool <InitializeAsync>b__0();
                }
            }

            class ProviderLoadRequestOptions
            {
                /*0x10*/ bool m_IgnoreFailures;
                /*0x14*/ int m_WebRequestTimeout;

                /*0x7cee55c*/ ProviderLoadRequestOptions();
                /*0x7cee4b8*/ UnityEngine.ResourceManagement.ResourceProviders.ProviderLoadRequestOptions Copy();
                /*0x7cee538*/ bool get_IgnoreFailures();
                /*0x7cee540*/ void set_IgnoreFailures(bool value);
                /*0x7cee54c*/ int get_WebRequestTimeout();
                /*0x7cee554*/ void set_WebRequestTimeout(int value);
            }

            class SceneProvider : UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2, UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider
            {
                /*0x7ceeeec*/ SceneProvider();
                /*0x7cee564*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode, bool activateOnLoad, int priority);
                /*0x7cee5e8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
                /*0x7cee624*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ProvideScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
                /*0x7ceeb9c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> ReleaseScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle);
                /*0x7ceec9c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2.ReleaseScene(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions);

                class SceneOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>, UnityEngine.ResourceManagement.IUpdateReceiver
                {
                    /*0xa0*/ bool m_ActivateOnLoad;
                    /*0xa8*/ UnityEngine.ResourceManagement.ResourceProviders.SceneInstance m_Inst;
                    /*0xb8*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation m_Location;
                    /*0xc0*/ UnityEngine.SceneManagement.LoadSceneParameters m_LoadSceneParameters;
                    /*0xc8*/ UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode m_ReleaseMode;
                    /*0xcc*/ int m_Priority;
                    /*0xd0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
                    /*0xe8*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;
                    /*0xf0*/ UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2 m_provider;

                    /*0x7ceea18*/ SceneOp(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2 provider);
                    /*0x7ceeef4*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                    /*0x7ceefd0*/ void Init(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                    /*0x7ceea90*/ void Init(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                    /*0x7cef04c*/ bool InvokeWaitForCompletion();
                    /*0x7cef38c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                    /*0x7cef4e4*/ string get_DebugName();
                    /*0x7cef588*/ void Execute();
                    /*0x7cefb88*/ UnityEngine.ResourceManagement.ResourceProviders.SceneInstance InternalLoadScene(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, bool loadingFromBundle, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
                    /*0x7cefc90*/ UnityEngine.AsyncOperation InternalLoad(string path, bool loadingFromBundle, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters);
                    /*0x7ceffb4*/ void Destroy();
                    /*0x7cf0184*/ float get_Progress();
                    /*0x7cf0244*/ void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime);
                }

                class UnloadSceneOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance>
                {
                    /*0xa0*/ UnityEngine.ResourceManagement.ResourceProviders.SceneInstance m_Instance;
                    /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> m_sceneLoadHandle;
                    /*0xc8*/ UnityEngine.SceneManagement.UnloadSceneOptions m_UnloadOptions;

                    /*0x7ceede8*/ UnloadSceneOp();
                    /*0x7ceee30*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneLoadHandle, UnityEngine.SceneManagement.UnloadSceneOptions options);
                    /*0x7cf03e8*/ void Execute();
                    /*0x7cf0654*/ bool InvokeWaitForCompletion();
                    /*0x7cf0508*/ void UnloadSceneCompleted(UnityEngine.AsyncOperation obj);
                    /*0x7cf0944*/ float get_Progress();
                }
            }

            class TextDataProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x1c*/ bool <IgnoreFailures>k__BackingField;

                /*0x7cee088*/ TextDataProvider();
                /*0x7cf098c*/ bool get_IgnoreFailures();
                /*0x7cf0994*/ void set_IgnoreFailures(bool value);
                /*0x7cf09a0*/ object Convert(System.Type type, string text);
                /*0x7cf09a8*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle);

                class InternalOp
                {
                    /*0x10*/ UnityEngine.ResourceManagement.ResourceProviders.TextDataProvider m_Provider;
                    /*0x18*/ UnityEngine.Networking.UnityWebRequestAsyncOperation m_RequestOperation;
                    /*0x20*/ UnityEngine.ResourceManagement.WebRequestQueueOperation m_RequestQueueOperation;
                    /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_PI;
                    /*0x40*/ bool m_IgnoreFailures;
                    /*0x41*/ bool m_Complete;
                    /*0x44*/ int m_Timeout;

                    /*0x7cf0a48*/ InternalOp();
                    /*0x7cf0e24*/ float GetPercentComplete();
                    /*0x7cf0a50*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle provideHandle, UnityEngine.ResourceManagement.ResourceProviders.TextDataProvider rawProvider);
                    /*0x7cf0f34*/ bool WaitForCompletionHandler();
                    /*0x7cf0fa8*/ void RequestOperation_completed(UnityEngine.AsyncOperation op);
                    /*0x7cf116c*/ void CompleteOperation(string text, System.Exception exception);
                    /*0x7cf0e3c*/ object ConvertText(string text);
                    /*0x7cf1218*/ void SendWebRequest(string path);
                    /*0x7cf1620*/ void <SendWebRequest>b__13_0(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation);
                }
            }
        }

        namespace ResourceLocations
        {
            interface ILocationSizeData
            {
                long ComputeSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceManager resourceManager);
            }

            interface IResourceLocation
            {
                /*0x380b9e8*/ string get_InternalId();
                /*0x380b9e8*/ string get_ProviderId();
                /*0x380b9e8*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                /*0x380b7a8*/ int Hash(System.Type resultType);
                /*0x380b6a0*/ int get_DependencyHashCode();
                /*0x380b128*/ bool get_HasDependencies();
                /*0x380b9e8*/ object get_Data();
                /*0x380b9e8*/ string get_PrimaryKey();
                /*0x380b9e8*/ System.Type get_ResourceType();
            }

            class ResourceLocationComparer : System.Collections.Generic.IEqualityComparer<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>
            {
                /*0x7cf1824*/ ResourceLocationComparer();
                /*0x7cf16c8*/ bool Equals(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation x, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation y);
                /*0x7cf16f8*/ int GetHashCode(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation obj);
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

                /*0x7cf1924*/ ResourceLocationBase(string name, string id, string providerId, System.Type t, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation[] dependencies);
                /*0x7cf182c*/ string get_InternalId();
                /*0x7cf1834*/ string get_ProviderId();
                /*0x7cf183c*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                /*0x7cf1844*/ bool get_HasDependencies();
                /*0x7cf1898*/ object get_Data();
                /*0x7cf18a0*/ void set_Data(object value);
                /*0x7cf18a8*/ string get_PrimaryKey();
                /*0x7cf18b0*/ void set_PrimaryKey(string value);
                /*0x7cf18b8*/ int get_DependencyHashCode();
                /*0x7cf18c0*/ System.Type get_ResourceType();
                /*0x7cf18c8*/ int Hash(System.Type t);
                /*0x7cf191c*/ string ToString();
                /*0x7cf1b78*/ void ComputeDependencyHash();
            }

            class LocationWrapper : UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation
            {
                /*0x10*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation m_InternalLocation;

                /*0x7ce7064*/ LocationWrapper(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x7cf1db0*/ string get_InternalId();
                /*0x7cf1e50*/ string get_ProviderId();
                /*0x7cf1ef4*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                /*0x7cf1f98*/ int get_DependencyHashCode();
                /*0x7cf203c*/ bool get_HasDependencies();
                /*0x7cf20e0*/ object get_Data();
                /*0x7cf2184*/ string get_PrimaryKey();
                /*0x7cf2228*/ System.Type get_ResourceType();
                /*0x7cf22cc*/ int Hash(System.Type resultType);
            }
        }

        namespace Profiling
        {
            class EngineEmitter : UnityEngine.ResourceManagement.Profiling.IProfilerEmitter
            {
                /*0x7cf23d8*/ EngineEmitter();
                /*0x7cf2378*/ bool get_IsEnabled();
                /*0x7cf2380*/ void EmitFrameMetaData(System.Guid id, int tag, System.Array data);
                /*0x7cf2384*/ void InitialiseCallbacks(System.Action<float> d);
            }

            enum ContentStatus
            {
                None = 0,
                Queue = 2,
                Downloading = 4,
                Released = 16,
                Loading = 64,
                Active = 256,
            }

            enum BundleOptions
            {
                None = 0,
                CachingEnabled = 1,
                CheckSumEnabled = 2,
            }

            struct CatalogFrameData
            {
                /*0x10*/ UnityEngine.Hash128 BuildResultHash;
            }

            struct BundleFrameData
            {
                /*0x10*/ int BundleCode;
                /*0x14*/ int ReferenceCount;
                /*0x18*/ float PercentComplete;
                /*0x1c*/ UnityEngine.ResourceManagement.Profiling.ContentStatus Status;
                /*0x20*/ UnityEngine.ResourceManagement.Util.BundleSource Source;
                /*0x24*/ UnityEngine.ResourceManagement.Profiling.BundleOptions LoadingOptions;
            }

            struct AssetFrameData
            {
                /*0x10*/ int AssetCode;
                /*0x14*/ int BundleCode;
                /*0x18*/ int ReferenceCount;
                /*0x1c*/ float PercentComplete;
                /*0x20*/ UnityEngine.ResourceManagement.Profiling.ContentStatus Status;

                /*0x7cf23e0*/ bool Equals(object obj);
                /*0x7cf2468*/ int GetHashCode();
            }

            interface IProfilerEmitter
            {
                /*0x380b128*/ bool get_IsEnabled();
                void EmitFrameMetaData(System.Guid id, int tag, System.Array data);
                /*0x380d83c*/ void InitialiseCallbacks(System.Action<float> onLateUpdateDelegate);
            }

            class ProfilerFrameData<T1, T2>
            {
                /*0x0*/ System.Collections.Generic.Dictionary<T1, T2> m_Data;
                /*0x0*/ T2[] m_Array;
                /*0x0*/ uint m_Version;
                /*0x0*/ uint m_ArrayVersion;

                /*0x380cb08*/ ProfilerFrameData();
                /*0x380cffc*/ ProfilerFrameData(int count);
                /*0x380b9e8*/ System.Collections.Generic.Dictionary<T1, T2> get_Data();
                /*0x3907c14*/ bool Add(T1 key, T2 value);
                /*0x3907c14*/ bool Remove(T1 key);
                /*0x380b9e8*/ T2[] get_Values();
                /*0x3907c14*/ T2 get_Item(T1 key);
                /*0x3907c14*/ void set_Item(T1 key, T2 value);
                /*0x3907c14*/ bool TryGetValue(T1 key, ref T2 value);
                /*0x3907c14*/ bool ContainsKey(T1 key);
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1, T2>> Enumerate();

                class <Enumerate>d__17<T1, T2> : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1, T2>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1, T2>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ int <>1__state;
                    /*0x0*/ System.Collections.Generic.KeyValuePair<T1, T2> <>2__current;
                    /*0x0*/ int <>l__initialThreadId;
                    /*0x0*/ UnityEngine.ResourceManagement.Profiling.ProfilerFrameData<T1, T2> <>4__this;
                    /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<T1, T2> <>7__wrap1;

                    /*0x380cffc*/ <Enumerate>d__17(int <>1__state);
                    /*0x380cb08*/ void System.IDisposable.Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void <>m__Finally1();
                    /*0x3907c14*/ System.Collections.Generic.KeyValuePair<T1, T2> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1,T2>>.get_Current();
                    /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                    /*0x380b9e8*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<T1, T2>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T1,T2>>.GetEnumerator();
                    /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class ProfilerRuntime
            {
                static int kCatalogTag = 0;
                static int kBundleDataTag = 1;
                static int kAssetDataTag = 2;
                static int kSceneDataTag = 3;
                static /*0x0*/ UnityEngine.ResourceManagement.Profiling.IProfilerEmitter m_profilerEmitter;
                static /*0x8*/ System.Guid kResourceManagerProfilerGuid;
                static /*0x18*/ Unity.Profiling.ProfilerCounterValue<int> CatalogLoadCounter;
                static /*0x19*/ Unity.Profiling.ProfilerCounterValue<int> AssetBundleLoadCounter;
                static /*0x1a*/ Unity.Profiling.ProfilerCounterValue<int> AssetLoadCounter;
                static /*0x1b*/ Unity.Profiling.ProfilerCounterValue<int> SceneLoadCounter;
                static /*0x20*/ UnityEngine.ResourceManagement.Profiling.ProfilerFrameData<UnityEngine.Hash128, UnityEngine.ResourceManagement.Profiling.CatalogFrameData> m_CatalogData;
                static /*0x28*/ UnityEngine.ResourceManagement.Profiling.ProfilerFrameData<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation, UnityEngine.ResourceManagement.Profiling.BundleFrameData> m_BundleData;
                static /*0x30*/ UnityEngine.ResourceManagement.Profiling.ProfilerFrameData<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation, UnityEngine.ResourceManagement.Profiling.AssetFrameData> m_AssetData;
                static /*0x38*/ UnityEngine.ResourceManagement.Profiling.ProfilerFrameData<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation, UnityEngine.ResourceManagement.Profiling.AssetFrameData> m_SceneData;
                static /*0x40*/ System.Collections.Generic.Dictionary<string, UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> m_BundleNameToOperation;
                static /*0x48*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation>> m_BundleNameToAssetOperations;
                static /*0x50*/ System.Collections.Generic.Dictionary<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation, System.ValueTuple<int, float>> m_DataChange;

                static /*0x7cf3bf8*/ ProfilerRuntime();
                static /*0x7cd9edc*/ void Initialise();
                static /*0x7cf2548*/ void InstanceOnOnLateUpdateDelegate(float deltaTime);
                static /*0x7cf2964*/ void AddCatalog(UnityEngine.Hash128 buildHash);
                static /*0x7ce7e74*/ void AddBundleOperation(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle handle, UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions requestOptions, UnityEngine.ResourceManagement.Profiling.ContentStatus status, UnityEngine.ResourceManagement.Util.BundleSource source);
                static /*0x7ce7b78*/ void BundleReleased(string bundleName);
                static /*0x7cecb6c*/ void AddAssetOperation(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle handle, UnityEngine.ResourceManagement.Profiling.ContentStatus status);
                static /*0x7cf2a18*/ string GetContainingBundleNameForLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                static /*0x7cefd8c*/ void AddSceneOperation(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.Profiling.ContentStatus status);
                static /*0x7cf0708*/ void SceneReleased(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle);
                static /*0x7cf2d74*/ int GetSceneLoadCounterValue();
                static /*0x7cf2594*/ void PushToProfilerStream();
                static /*0x7cf2dd0*/ void RefreshChangedReferenceCounts();
                static /*0x7cf38f0*/ bool ShouldUpdateFrameDataWithOperationData(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation activeOperation, int frameReferenceCount, float framePercentComplete, ref System.ValueTuple<int, float> newDataOut);
            }
        }

        namespace AsyncOperations
        {
            interface ICachable
            {
                /*0x380b9e8*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey get_Key();
                /*0x380d83c*/ void set_Key(UnityEngine.ResourceManagement.Util.IOperationCacheKey value);
            }

            interface IAsyncOperation
            {
                /*0x380b9e8*/ object GetResultAsObject();
                /*0x380b9e8*/ System.Type get_ResultType();
                /*0x380b6a0*/ int get_Version();
                /*0x380b9e8*/ string get_DebugName();
                /*0x380cb08*/ void DecrementReferenceCount();
                /*0x380cb08*/ void IncrementReferenceCount();
                /*0x380b6a0*/ int get_ReferenceCount();
                /*0x380c2e4*/ float get_PercentComplete();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x380b6a0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x380b9e8*/ System.Exception get_OperationException();
                /*0x380b128*/ bool get_IsDone();
                /*0x380d83c*/ void set_OnDestroy(System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> value);
                /*0x380d83c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x380b128*/ bool get_IsRunning();
                /*0x380d83c*/ void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380cb08*/ void InvokeCompletionEvent();
                /*0x380b9e8*/ System.Threading.Tasks.Task<object> get_Task();
                void Start(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_Handle();
                /*0x380cb08*/ void WaitForCompletion();
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
                /*0x0*/ bool HasExecuted;
                /*0x0*/ System.Action Executed;
                /*0x0*/ bool <IsRunning>k__BackingField;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<TObject> m_taskCompletionSource;
                /*0x0*/ System.Threading.Tasks.TaskCompletionSource<object> m_taskCompletionSourceTypeless;
                /*0x0*/ bool m_InDeferredCallbackQueue;
                /*0x0*/ DelegateList<float> m_UpdateCallbacks;
                /*0x0*/ System.Action<float> m_UpdateCallback;

                static /*0x382fccc*/ string ShortenPath(string p, bool keepExtension);
                /*0x380cb08*/ AsyncOperationBase();
                /*0x380cb08*/ void Execute();
                /*0x380cb08*/ void Destroy();
                /*0x380c2e4*/ float get_Progress();
                /*0x380b9e8*/ string get_DebugName();
                /*0x380d83c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
                /*0x3907c14*/ TObject get_Result();
                /*0x3907c14*/ void set_Result(TObject value);
                /*0x380b6a0*/ int get_Version();
                /*0x380b128*/ bool get_CompletedEventHasListeners();
                /*0x380b128*/ bool get_DestroyedEventHasListeners();
                /*0x380d83c*/ void set_OnDestroy(System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> value);
                /*0x380d83c*/ void add_Executed(System.Action value);
                /*0x380d83c*/ void remove_Executed(System.Action value);
                /*0x380b6a0*/ int get_ReferenceCount();
                /*0x380b128*/ bool get_IsRunning();
                /*0x380cdf0*/ void set_IsRunning(bool value);
                /*0x380cb08*/ void WaitForCompletion();
                /*0x380b128*/ bool InvokeWaitForCompletion();
                /*0x380cb08*/ void IncrementReferenceCount();
                /*0x380cb08*/ void DecrementReferenceCount();
                /*0x380b9e8*/ System.Threading.Tasks.Task<TObject> get_Task();
                /*0x380b9e8*/ System.Threading.Tasks.Task<object> UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Task();
                /*0x380b9e8*/ string ToString();
                /*0x380cdf0*/ void RegisterForDeferredCallbackEvent(bool incrementReferenceCount);
                /*0x380d83c*/ void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x380d83c*/ void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x380d83c*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380b6a0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x380b9e8*/ System.Exception get_OperationException();
                /*0x380d83c*/ void set_OperationException(System.Exception value);
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Reset();
                /*0x380b9e8*/ object get_Current();
                /*0x380b128*/ bool get_IsDone();
                /*0x380c2e4*/ float get_PercentComplete();
                /*0x380cb08*/ void InvokeCompletionEvent();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> get_Handle();
                /*0x380e050*/ void UpdateCallback(float unscaledDeltaTime);
                /*0x3907c14*/ void Complete(TObject result, bool success, string errorMsg);
                /*0x3907c14*/ void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure);
                /*0x3907c14*/ void Complete(TObject result, bool success, System.Exception exception, bool releaseDependenciesOnFailure);
                void Start(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);
                /*0x380cb08*/ void InvokeExecute();
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380b6a0*/ int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Version();
                /*0x380b6a0*/ int UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ReferenceCount();
                /*0x380c2e4*/ float UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_PercentComplete();
                /*0x380b6a0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Status();
                /*0x380b9e8*/ System.Exception UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_OperationException();
                /*0x380b128*/ bool UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_IsDone();
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_Handle();
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.set_OnDestroy(System.Action<UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation> value);
                /*0x380b9e8*/ string UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_DebugName();
                /*0x380b9e8*/ object UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetResultAsObject();
                /*0x380b9e8*/ System.Type UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.get_ResultType();
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x380cb08*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.DecrementReferenceCount();
                /*0x380cb08*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.IncrementReferenceCount();
                /*0x380cb08*/ void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.InvokeCompletionEvent();
                void UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.Start(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dependency, DelegateList<float> updateCallbacks);
                /*0x380cb08*/ void ReleaseDependencies();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation.GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                void <.ctor>b__38_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle o);

                class <>c__DisplayClass60_0<TObject>
                {
                    /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value;

                    /*0x380cb08*/ <>c__DisplayClass60_0();
                    /*0x3907c14*/ void <add_CompletedTypeless>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> s);
                }

                class <>c__DisplayClass61_0<TObject>
                {
                    /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value;

                    /*0x380cb08*/ <>c__DisplayClass61_0();
                    /*0x3907c14*/ void <remove_CompletedTypeless>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> s);
                }
            }

            struct AsyncOperationHandle<TObject> : System.Collections.IEnumerator, System.IEquatable<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>>
            {
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> m_InternalOp;
                /*0x0*/ int m_Version;
                /*0x0*/ string m_LocationName;

                static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op_Implicit(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> obj);
                /*0x380d83c*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> op);
                /*0x380d83c*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op);
                /*0x380d8b8*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version);
                /*0x380d93c*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, string locationName);
                AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version, string locationName);
                /*0x380b6a0*/ int get_Version();
                /*0x380b9e8*/ string get_LocationName();
                /*0x380d83c*/ void set_LocationName(string value);
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus InternalGetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> Acquire();
                /*0x380d83c*/ void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x380d83c*/ void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> value);
                /*0x380cb08*/ void ReleaseHandleOnCompletion();
                /*0x380d83c*/ void add_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void remove_CompletedTypeless(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380b9e8*/ string get_DebugName();
                /*0x380d83c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x380d83c*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x380d83c*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x3907c14*/ bool Equals(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> other);
                /*0x380b6a0*/ int GetHashCode();
                /*0x3907c14*/ TObject WaitForCompletion();
                /*0x380b9e8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject> get_InternalOp();
                /*0x380b128*/ bool get_IsDone();
                /*0x380b128*/ bool IsValid();
                /*0x380b9e8*/ System.Exception get_OperationException();
                /*0x380c2e4*/ float get_PercentComplete();
                /*0x380b6a0*/ int get_ReferenceCount();
                /*0x380cb08*/ void Release();
                /*0x3907c14*/ TObject get_Result();
                /*0x380b6a0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x380b9e8*/ System.Threading.Tasks.Task<TObject> get_Task();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                /*0x380b128*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x380cb08*/ void System.Collections.IEnumerator.Reset();

                class <>c<TObject>
                {
                    static /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle.<>c<TObject> <>9;
                    static /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject>> <>9__20_0;

                    static /*0x38358cc*/ <>c();
                    /*0x380cb08*/ <>c();
                    /*0x3907c14*/ void <ReleaseHandleOnCompletion>b__20_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> op);
                }
            }

            struct AsyncOperationHandle : System.Collections.IEnumerator
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation m_InternalOp;
                /*0x18*/ int m_Version;
                /*0x20*/ string m_LocationName;

                /*0x7cf3fa0*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op);
                /*0x7cf4078*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version);
                /*0x7cdb52c*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, string locationName);
                /*0x7cf40ac*/ AsyncOperationHandle(UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation op, int version, string locationName);
                /*0x7cf3f88*/ int get_Version();
                /*0x7cf3f90*/ string get_LocationName();
                /*0x7cf3f98*/ void set_LocationName(string value);
                /*0x7cdc7ac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle Acquire();
                /*0x7cdcc0c*/ void add_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x7cf41e0*/ void remove_Completed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x7cf4294*/ void ReleaseHandleOnCompletion();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<T> Convert<T>();
                /*0x7cf4374*/ bool Equals(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle other);
                /*0x7cf43a0*/ string get_DebugName();
                /*0x7cf4534*/ void add_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x7cf45e8*/ void remove_Destroyed(System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> value);
                /*0x7cf469c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x7cf4750*/ int GetHashCode();
                /*0x7cf40e4*/ UnityEngine.ResourceManagement.AsyncOperations.IAsyncOperation get_InternalOp();
                /*0x7cf4780*/ bool get_IsDone();
                /*0x7cf447c*/ bool IsValid();
                /*0x7cf4848*/ System.Exception get_OperationException();
                /*0x7cf48f4*/ float get_PercentComplete();
                /*0x7cf49a0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus();
                /*0x7cf4a3c*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus InternalGetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x7cf4bbc*/ int get_ReferenceCount();
                /*0x7cdc6d0*/ void Release();
                /*0x7cefae0*/ object get_Result();
                /*0x7cf4c68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationStatus get_Status();
                /*0x7cf4d14*/ System.Threading.Tasks.Task<object> get_Task();
                /*0x7cf4dc0*/ object System.Collections.IEnumerator.get_Current();
                /*0x7cf4dc4*/ bool System.Collections.IEnumerator.MoveNext();
                /*0x7cf4ddc*/ void System.Collections.IEnumerator.Reset();
                /*0x7cf4de0*/ object WaitForCompletion();

                class <>c
                {
                    static /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle.<> <>9;
                    static /*0x8*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> <>9__16_0;

                    static /*0x7cf4f2c*/ <>c();
                    /*0x7cf4f94*/ <>c();
                    /*0x7cf4f9c*/ void <ReleaseHandleOnCompletion>b__16_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                }
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

                /*0x7cf4fa4*/ float get_Percent();
            }

            class GroupOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>>, UnityEngine.ResourceManagement.AsyncOperations.ICachable
            {
                static int k_MaxDisplayedLocationLength = 45;
                static int k_MaxDebugNameLength = 2000;
                /*0x98*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_InternalOnComplete;
                /*0xa0*/ int m_LoadedCount;
                /*0xa4*/ UnityEngine.ResourceManagement.AsyncOperations.GroupOperation.GroupOperationSettings m_Settings;
                /*0xa8*/ string debugName;
                /*0xb0*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField;
                /*0xb8*/ System.Collections.Generic.HashSet<string> m_CachedDependencyLocations;

                /*0x7cf4fdc*/ GroupOperation();
                /*0x7cf5134*/ bool InvokeWaitForCompletion();
                /*0x7cf551c*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key();
                /*0x7cf5524*/ void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(UnityEngine.ResourceManagement.Util.IOperationCacheKey value);
                /*0x7cf552c*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> GetDependentOps();
                /*0x7cf5568*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x7cf55cc*/ void ReleaseDependencies();
                /*0x7cf5828*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x7cf5a94*/ bool DependenciesAreUnchanged(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x7cf5c68*/ string get_DebugName();
                /*0x7cf5f80*/ void Execute();
                /*0x7cf61a0*/ void CompleteIfDependenciesComplete();
                /*0x7cf64a8*/ void Destroy();
                /*0x7cf64d4*/ float get_Progress();
                /*0x7cf66d0*/ void Init(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> operations, bool releaseDependenciesOnFailure, bool allowFailedDependencies);
                /*0x7cf678c*/ void Init(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> operations, UnityEngine.ResourceManagement.AsyncOperations.GroupOperation.GroupOperationSettings settings);
                /*0x7cf6830*/ void OnOperationCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);

                enum GroupOperationSettings
                {
                    None = 0,
                    ReleaseDependenciesOnFailure = 1,
                    AllowFailedDependencies = 2,
                }
            }

            interface IGenericProviderOperation
            {
                /*0x3907c14*/ void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);
                /*0x380b6a0*/ int get_ProvideHandleVersion();
                /*0x380b9e8*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x380b6a0*/ int get_DependencyCount();
                /*0x380d83c*/ void GetDependencies(System.Collections.Generic.IList<object> dstList);
                /*0x3907c14*/ TDepObject GetDependency<TDepObject>(int index);
                /*0x380d83c*/ void SetProgressCallback(System.Func<float> callback);
                /*0x3907c14*/ void ProviderCompleted<T>(T result, bool status, System.Exception e);
                /*0x380b9e8*/ System.Type get_RequestedType();
                /*0x380d83c*/ void SetDownloadProgressCallback(System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> callback);
                /*0x380d83c*/ void SetWaitForCompletionCallback(System.Func<bool> callback);
            }

            class ProviderOperation<TObject> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<TObject>, UnityEngine.ResourceManagement.AsyncOperations.IGenericProviderOperation, UnityEngine.ResourceManagement.AsyncOperations.ICachable
            {
                static float k_OperationWaitingToCompletePercentComplete = 0.9900000095367432;
                static string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";
                /*0x0*/ bool m_ReleaseDependenciesOnFailure;
                /*0x0*/ System.Func<float> m_GetProgressCallback;
                /*0x0*/ System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> m_GetDownloadProgressCallback;
                /*0x0*/ System.Func<bool> m_WaitForCompletionCallback;
                /*0x0*/ bool m_ProviderCompletedCalled;
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus m_DownloadStatus;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider m_Provider;
                /*0x0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation m_Location;
                /*0x0*/ int m_ProvideHandleVersion;
                /*0x0*/ bool m_NeedsRelease;
                /*0x0*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey <UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;

                /*0x380cb08*/ ProviderOperation();
                /*0x380b9e8*/ UnityEngine.ResourceManagement.Util.IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.get_Key();
                /*0x380d83c*/ void UnityEngine.ResourceManagement.AsyncOperations.ICachable.set_Key(UnityEngine.ResourceManagement.Util.IOperationCacheKey value);
                /*0x380b6a0*/ int get_ProvideHandleVersion();
                /*0x380b9e8*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_Location();
                /*0x380d83c*/ void SetDownloadProgressCallback(System.Func<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus> callback);
                /*0x380d83c*/ void SetWaitForCompletionCallback(System.Func<bool> callback);
                /*0x380b128*/ bool InvokeWaitForCompletion();
                UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus GetDownloadStatus(System.Collections.Generic.HashSet<object> visited);
                /*0x380d83c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> deps);
                /*0x380cb08*/ void ReleaseDependencies();
                /*0x380b9e8*/ string get_DebugName();
                /*0x380d83c*/ void GetDependencies(System.Collections.Generic.IList<object> dstList);
                /*0x380b9e8*/ System.Type get_RequestedType();
                /*0x380b6a0*/ int get_DependencyCount();
                /*0x3907c14*/ TDepObject GetDependency<TDepObject>(int index);
                /*0x380d83c*/ void SetProgressCallback(System.Func<float> callback);
                /*0x3907c14*/ void ProviderCompleted<T>(T result, bool status, System.Exception e);
                /*0x380c2e4*/ float get_Progress();
                /*0x380cb08*/ void Execute();
                /*0x3907c14*/ void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
                void Init(UnityEngine.ResourceManagement.ResourceManager rm, UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider provider, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure);
                /*0x380b128*/ bool WaitForCompletionHandler();
                /*0x380cb08*/ void Destroy();
            }

            class UnityWebRequestOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.Networking.UnityWebRequest>
            {
                /*0x98*/ UnityEngine.Networking.UnityWebRequest m_UWR;

                /*0x7cf6840*/ UnityWebRequestOperation(UnityEngine.Networking.UnityWebRequest webRequest);
                /*0x7cf68a4*/ void Execute();
                /*0x7cf6940*/ void <Execute>b__2_0(UnityEngine.AsyncOperation request);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3F4AAF2D80A71A442299E92A3C0F0FDA7FD632937B686F829684064A7AF47947;
    static /*0x1c59*/ <PrivateImplementationDetails> AEFAFBEB5C62866A99DDC88AAAAB29449AB45CCBEDFD0EE2A7B49F9BC7E23E76;
    static /*0x30c5*/ <PrivateImplementationDetails> C648E428189236A63C63B6B306F41029ACB6DEF19803F3544D7688B6D52D6140;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=5228
    {
    }

    struct __StaticArrayInitTypeSize=7257
    {
    }
}
