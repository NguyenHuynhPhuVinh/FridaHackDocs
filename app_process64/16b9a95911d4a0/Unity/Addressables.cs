class <Module>
{
}

class PackedPlayModeBuildLogs
{
    /*0x10*/ System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs;

    /*0x3a94dd4*/ PackedPlayModeBuildLogs();
    /*0x3a94dc4*/ System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> get_RuntimeBuildLogs();
    /*0x3a94dcc*/ void set_RuntimeBuildLogs(System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> value);

    struct RuntimeBuildLog
    {
        /*0x10*/ UnityEngine.LogType Type;
        /*0x18*/ string Message;

        /*0x3a94e5c*/ RuntimeBuildLog(UnityEngine.LogType type, string message);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3a94e6c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3a94f60*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    class AssetReferenceUIRestriction : System.Attribute
    {
        /*0x3a94f78*/ AssetReferenceUIRestriction();
        /*0x3a94f68*/ bool ValidateAsset(UnityEngine.Object obj);
        /*0x3a94f70*/ bool ValidateAsset(string path);
    }

    class AssetReferenceUILabelRestriction : UnityEngine.AssetReferenceUIRestriction
    {
        /*0x10*/ string[] m_AllowedLabels;
        /*0x18*/ string m_CachedToString;

        /*0x3a94f80*/ AssetReferenceUILabelRestriction(string[] allowedLabels);
        /*0x3a94fb0*/ bool ValidateAsset(UnityEngine.Object obj);
        /*0x3a94fb8*/ bool ValidateAsset(string path);
        /*0x3a94fc0*/ string ToString();
    }

    namespace ResourceManagement
    {
        namespace AsyncOperations
        {
            class InitalizationObjectsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
            {
                /*0x80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> m_RtdOp;
                /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xa0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;

                /*0x3a95d14*/ InitalizationObjectsOperation();
                /*0x3a950d4*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> rtdOp, UnityEngine.AddressableAssets.AddressablesImpl addressables);
                /*0x3a951cc*/ string get_DebugName();
                /*0x3a9520c*/ bool LogRuntimeWarnings(string pathToBuildLogs);
                /*0x3a955a4*/ void Execute();
                /*0x3a95d5c*/ void <Execute>b__7_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> obj);
            }
        }
    }

    namespace AddressableAssets
    {
        class InvalidKeyException : System.Exception
        {
            /*0x90*/ object <Key>k__BackingField;
            /*0x98*/ System.Type <Type>k__BackingField;

            /*0x3a95f30*/ InvalidKeyException(object key);
            /*0x3a95f84*/ InvalidKeyException(object key, System.Type type);
            /*0x3a9600c*/ InvalidKeyException();
            /*0x3a96064*/ InvalidKeyException(string message);
            /*0x3a960cc*/ InvalidKeyException(string message, System.Exception innerException);
            /*0x3a9613c*/ InvalidKeyException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
            /*0x3a95f10*/ object get_Key();
            /*0x3a95f18*/ void set_Key(object value);
            /*0x3a95f20*/ System.Type get_Type();
            /*0x3a95f28*/ void set_Type(System.Type value);
            /*0x3a961bc*/ string get_Message();
        }

        class Addressables
        {
            static string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
            static string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
            static string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";
            static /*0x0*/ bool reinitializeAddressables;
            static /*0x8*/ UnityEngine.AddressableAssets.AddressablesImpl m_AddressablesInstance;

            static /*0x3a9e0e0*/ Addressables();
            static /*0x3a9622c*/ UnityEngine.AddressableAssets.AddressablesImpl get_m_Addressables();
            static /*0x3a96284*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
            static /*0x3a96314*/ UnityEngine.AddressableAssets.AddressablesImpl get_Instance();
            static /*0x3a9639c*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider get_InstanceProvider();
            static /*0x3a96430*/ string ResolveInternalId(string id);
            static /*0x3a964c8*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            static /*0x3a96580*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            static /*0x3a9663c*/ string get_StreamingAssetsSubFolder();
            static /*0x3a96738*/ string get_BuildPath();
            static /*0x3a968c8*/ string get_PlayerBuildDataPath();
            static /*0x3a96a04*/ string get_RuntimePath();
            static /*0x3a96a98*/ System.Collections.Generic.IEnumerable<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_ResourceLocators();
            static /*0x3a96c24*/ void InternalSafeSerializationLog(string msg, UnityEngine.LogType logType);
            static /*0x3a96e40*/ void InternalSafeSerializationLogFormat(string format, UnityEngine.LogType logType, object[] args);
            static /*0x3a9709c*/ void Log(string msg);
            static /*0x3a97134*/ void LogFormat(string format, object[] args);
            static /*0x3a95474*/ void LogWarning(string msg);
            static /*0x3a971dc*/ void LogWarningFormat(string format, object[] args);
            static /*0x3a9550c*/ void LogError(string msg);
            static /*0x3a97284*/ void LogException(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
            static /*0x3a95c6c*/ void LogErrorFormat(string format, object[] args);
            static /*0x3a975a8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> Initialize();
            static /*0x3a97618*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync();
            static /*0x3a9775c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix);
            static /*0x3a977e4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix);
            static /*0x3a97b28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix);
            static /*0x3a97c00*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_InitializationOperation();
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAsset<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAsset<TObject>(object key);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key);
            static /*0x3a97c0c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocations(System.Collections.Generic.IList<object> keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            static /*0x3a97ca0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.Generic.IList<object> keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            static /*0x3a97ee8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            static /*0x3a97fc0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocations(object key, System.Type type);
            static /*0x3a98048*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(object key, System.Type type);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssets<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssets<TObject>(System.Collections.Generic.IList<object> keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<object> keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<object> keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssets<TObject>(object key, System.Action<TObject> callback);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback);
            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            static /*0x1ffc854*/ void Release<TObject>(TObject obj);
            static /*0x1ffc854*/ void Release<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            static /*0x3a98278*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            static /*0x3a98368*/ bool ReleaseInstance(UnityEngine.GameObject instance);
            static /*0x3a984fc*/ bool ReleaseInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            static /*0x3a985b4*/ bool ReleaseInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> handle);
            static /*0x3a98684*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSize(object key);
            static /*0x3a98700*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
            static /*0x3a98890*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(string key);
            static /*0x3a98950*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.Generic.IList<object> keys);
            static /*0x3a996e8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.IEnumerable keys);
            static /*0x3a997a8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependencies(object key);
            static /*0x3a99828*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);
            static /*0x3a99bcc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            static /*0x3a99e14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<object> keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            static /*0x3a9a1d0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            static /*0x3a9a2a8*/ void ClearDependencyCacheAsync(object key);
            static /*0x3a9a580*/ void ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            static /*0x3a9aae4*/ void ClearDependencyCacheAsync(System.Collections.Generic.IList<object> keys);
            static /*0x3a9b05c*/ void ClearDependencyCacheAsync(System.Collections.IEnumerable keys);
            static /*0x3a9b108*/ void ClearDependencyCacheAsync(string key);
            static /*0x3a9b1b4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle);
            static /*0x3a9b280*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            static /*0x3a9b34c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<object> keys, bool autoReleaseHandle);
            static /*0x3a9b418*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.IEnumerable keys, bool autoReleaseHandle);
            static /*0x3a9b4e4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle);
            static /*0x3a9b5b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x3a9b764*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x3a9b988*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x3a9bb0c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x3a9bd30*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x3a9bec0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x3a9bf68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x3a9b854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x3a9ba28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x3a9bbfc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x3a9bdd8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x3a9b67c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x3a9c804*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadScene(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            static /*0x3a9c98c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadScene(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            static /*0x3a9c8a4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            static /*0x3a9ca2c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            static /*0x3a9ce2c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadScene(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, bool autoReleaseHandle);
            static /*0x3a9cf98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadScene(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, bool autoReleaseHandle);
            static /*0x3a9d10c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadScene(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            static /*0x3a9cec0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, bool autoReleaseHandle);
            static /*0x3a9d030*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, bool autoReleaseHandle);
            static /*0x3a9d1a4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            static /*0x3a9d6c8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdates(bool autoReleaseHandle);
            static /*0x3a9d8fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(System.Collections.Generic.IEnumerable<string> catalogs, bool autoReleaseHandle);
            static /*0x3a9dc38*/ void AddResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, string localCatalogHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            static /*0x3a9dd8c*/ void RemoveResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
            static /*0x3a9df08*/ void ClearResourceLocators();
            static /*0x3a9e034*/ void Reset();

            enum MergeMode
            {
                None = 0,
                UseFirst = 0,
                Union = 1,
                Intersection = 2,
            }
        }

        class AddressablesImpl : System.Collections.Generic.IEqualityComparer<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>
        {
            static string kCacheDataFolder = "{UnityEngine.Application.persistentDataPath}/com.unity.addressables/";
            /*0x10*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;
            /*0x18*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider m_InstanceProvider;
            /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider SceneProvider;
            /*0x28*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo> m_ResourceLocators;
            /*0x30*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> m_InitializationOperation;
            /*0x48*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> m_ActiveCheckUpdateOperation;
            /*0x60*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> m_ActiveUpdateOperation;
            /*0x78*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_OnHandleCompleteAction;
            /*0x80*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_OnSceneHandleCompleteAction;
            /*0x88*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_OnHandleDestroyedAction;
            /*0x90*/ System.Collections.Generic.Dictionary<object, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_resultToHandle;
            /*0x98*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_SceneInstances;
            /*0xa0*/ bool hasStartedInitialization;

            static /*0x3aa1d7c*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> GatherDependenciesFromLocations(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x3a9e1a4*/ AddressablesImpl(UnityEngine.ResourceManagement.Util.IAllocationStrategy alloc);
            /*0x3a9e390*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider get_InstanceProvider();
            /*0x3a9e398*/ void set_InstanceProvider(UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider value);
            /*0x3a95130*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
            /*0x3a9e42c*/ int get_SceneOperationCount();
            /*0x3a9e474*/ int get_TrackedHandleCount();
            /*0x3a9e4c4*/ void ReleaseSceneManagerOperation();
            /*0x3a96564*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            /*0x3a96618*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            /*0x3a9e568*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_ChainOperation();
            /*0x3a9e708*/ bool get_ShouldChainRequest();
            /*0x3a9e7e0*/ void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            /*0x3a966f8*/ string get_StreamingAssetsSubFolder();
            /*0x3a967c8*/ string get_BuildPath();
            /*0x3a96958*/ string get_PlayerBuildDataPath();
            /*0x3a96a94*/ string get_RuntimePath();
            /*0x3a96de8*/ void Log(string msg);
            /*0x3a97034*/ void LogFormat(string format, object[] args);
            /*0x3a96d38*/ void LogWarning(string msg);
            /*0x3a96f64*/ void LogWarningFormat(string format, object[] args);
            /*0x3a96d90*/ void LogError(string msg);
            /*0x3a97348*/ void LogException(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
            /*0x3a96fcc*/ void LogErrorFormat(string format, object[] args);
            /*0x3a95c18*/ string ResolveInternalId(string id);
            /*0x3a96b28*/ System.Collections.Generic.IEnumerable<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_ResourceLocators();
            /*0x3a9dce8*/ void AddResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc, string localCatalogHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            /*0x3a9de24*/ void RemoveResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc);
            /*0x3a9df98*/ void ClearResourceLocators();
            /*0x3a9edd0*/ bool GetResourceLocations(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x3a9f5a0*/ bool GetResourceLocations(System.Collections.IEnumerable keys, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode merge, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x3a9fa70*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle);
            /*0x3a976cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync();
            /*0x3aa0530*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies(string catalogPath, string hashFilePath);
            /*0x3a978b4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix);
            /*0x3aa1048*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> TrackHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> TrackHandle<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x3aa1104*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle TrackHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3aa1140*/ void ClearTrackHandles();
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key);
            /*0x3aa1190*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            /*0x3a97d78*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            /*0x3aa13ac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, System.Type type);
            /*0x3a98114*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(object key, System.Type type);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3aa15b0*/ void OnHandleDestroyed(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3aa1638*/ void OnSceneHandleCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3aa1758*/ void OnHandleCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x1ffc854*/ void Release<TObject>(TObject obj);
            /*0x1ffc854*/ void Release<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x3a9832c*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3aa18c0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
            /*0x3aa1a18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys);
            /*0x3a987c0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
            /*0x3a98a10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.IEnumerable keys);
            /*0x3aa1b70*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, bool autoReleaseHandle);
            /*0x3a998f4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);
            /*0x3aa259c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x3a99c98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x3aa27a8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            /*0x3a99eec*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            /*0x3aa29bc*/ bool ClearDependencyCacheForKey(object key);
            /*0x3a9a354*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle);
            /*0x3a9a62c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x3a9ab90*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.IEnumerable keys, bool autoReleaseHandle);
            /*0x3aa3118*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            /*0x3a9c19c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            /*0x3a9c224*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            /*0x3a9c2b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            /*0x3aa31a4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x3a9c338*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x3aa3358*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x3a9c07c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x3a98400*/ bool ReleaseInstance(UnityEngine.GameObject instance);
            /*0x3aa350c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            /*0x3a9cb14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority, bool trackHandle);
            /*0x3a9cd70*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority, bool trackHandle);
            /*0x3a9d280*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, bool autoReleaseHandle);
            /*0x3a9d490*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, bool autoReleaseHandle);
            /*0x3a9d5e0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            /*0x3aa36b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> CreateUnloadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, bool autoReleaseHandle);
            /*0x3aa37f0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> CreateUnloadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            /*0x3aa3930*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> InternalUnloadScene(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            /*0x3a9f4c4*/ object EvaluateKey(object obj);
            /*0x3a9d788*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdates(bool autoReleaseHandle);
            /*0x3aa4054*/ UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo GetLocatorInfo(string c);
            /*0x3aa42b8*/ System.Collections.Generic.IEnumerable<string> get_CatalogsWithAvailableUpdates();
            /*0x3a9d9c8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(System.Collections.Generic.IEnumerable<string> catalogIds, bool autoReleaseHandle);
            /*0x3aa4b2c*/ bool Equals(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation x, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation y);
            /*0x3aa4e0c*/ int GetHashCode(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x3a9e0d0*/ void Reset();
            /*0x3aa4f38*/ void <InitializeAsync>b__57_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> x);
            /*0x3aa4fe0*/ void <TrackHandle>b__61_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneHandle);
            /*0x3aa5084*/ void <DownloadDependenciesAsync>b__91_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            /*0x3aa50f8*/ void <DownloadDependenciesAsync>b__91_1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            /*0x3aa516c*/ void <DownloadDependenciesAsync>b__93_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            /*0x3aa51e0*/ void <DownloadDependenciesAsync>b__95_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            /*0x3aa5254*/ void <DownloadDependenciesAsync>b__95_1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            /*0x3aa52c8*/ void <InternalUnloadScene>b__117_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> op);
            /*0x3aa533c*/ void <CheckForCatalogUpdates>b__119_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle o);

            class ResourceLocatorInfo
            {
                /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator <Locator>k__BackingField;
                /*0x18*/ string <LocalHash>k__BackingField;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <CatalogLocation>k__BackingField;
                /*0x28*/ bool <ContentUpdateAvailable>k__BackingField;

                /*0x3a9ed68*/ ResourceLocatorInfo(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc, string localHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
                /*0x3aa537c*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator get_Locator();
                /*0x3aa5384*/ void set_Locator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator value);
                /*0x3aa538c*/ string get_LocalHash();
                /*0x3aa5394*/ void set_LocalHash(string value);
                /*0x3aa539c*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_CatalogLocation();
                /*0x3aa53a4*/ void set_CatalogLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation value);
                /*0x3aa53ac*/ bool get_ContentUpdateAvailable();
                /*0x3aa53b4*/ void set_ContentUpdateAvailable(bool value);
                /*0x3aa53bc*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_HashLocation();
                /*0x3aa54d8*/ bool get_CanUpdateContent();
                /*0x3aa567c*/ void UpdateContent(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, string hash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            }

            class LoadResourceLocationKeyOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>
            {
                /*0x80*/ object m_Keys;
                /*0x88*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_locations;
                /*0x90*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0x98*/ System.Type m_ResourceType;

                /*0x3aa1520*/ LoadResourceLocationKeyOp();
                /*0x3aa56c4*/ string get_DebugName();
                /*0x3aa1568*/ void Init(UnityEngine.AddressableAssets.AddressablesImpl aa, System.Type t, object keys);
                /*0x3aa56e0*/ void Execute();
            }

            class LoadResourceLocationKeysOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>
            {
                /*0x80*/ System.Collections.IEnumerable m_Key;
                /*0x88*/ UnityEngine.AddressableAssets.Addressables.MergeMode m_MergeMode;
                /*0x90*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_locations;
                /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xa0*/ System.Type m_ResourceType;

                /*0x3aa130c*/ LoadResourceLocationKeysOp();
                /*0x3aa57b4*/ string get_DebugName();
                /*0x3aa1354*/ void Init(UnityEngine.AddressableAssets.AddressablesImpl aa, System.Type t, System.Collections.IEnumerable key, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode);
                /*0x3aa57f4*/ void Execute();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo, UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <>9__51_0;
                static /*0x10*/ System.Func<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo, bool> <>9__122_0;
                static /*0x18*/ System.Func<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo, string> <>9__122_1;

                static /*0x3aa58cc*/ <>c();
                /*0x3aa5934*/ <>c();
                /*0x3aa593c*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator <get_ResourceLocators>b__51_0(UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo l);
                /*0x3aa5950*/ bool <get_CatalogsWithAvailableUpdates>b__122_0(UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo s);
                /*0x3aa5964*/ string <get_CatalogsWithAvailableUpdates>b__122_1(UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo s);
            }

            class <>c__DisplayClass104_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters;

                /*0x3aa3350*/ <>c__DisplayClass104_0();
                /*0x3aa5a08*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> <InstantiateWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass106_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters;

                /*0x3aa3504*/ <>c__DisplayClass106_0();
                /*0x3aa5a64*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> <InstantiateWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass109_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ UnityEngine.SceneManagement.LoadSceneMode loadMode;
                /*0x24*/ bool activateOnLoad;
                /*0x28*/ int priority;

                /*0x3aa36a8*/ <>c__DisplayClass109_0();
                /*0x3aa5ac0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <LoadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass115_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;

                /*0x3aa3a30*/ <>c__DisplayClass115_0();
                /*0x3aa5b14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <CreateUnloadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle completedHandle);
            }

            class <>c__DisplayClass116_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;

                /*0x3aa3a38*/ <>c__DisplayClass116_0();
                /*0x3aa5bbc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <CreateUnloadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> completedHandle);
            }

            class <>c__DisplayClass123_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;

                /*0x3aa4474*/ <>c__DisplayClass123_0();
                /*0x3aa5c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> <UpdateCatalogs>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> depOp);
                /*0x3aa5c70*/ void <UpdateCatalogs>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle o);
            }

            class <>c__DisplayClass33_0
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> op;
                /*0x28*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;

                /*0x3a9ec30*/ <>c__DisplayClass33_0();
                /*0x3aa5cb8*/ void <OnSceneUnloaded>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle);
            }

            class <>c__DisplayClass53_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc;

                /*0x3a9edc8*/ <>c__DisplayClass53_0();
                /*0x3aa5d28*/ bool <RemoveResourceLocator>b__0(UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo l);
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ string catalogPath;
                /*0x20*/ bool autoReleaseHandle;
                /*0x28*/ string providerSuffix;
                /*0x30*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> handle;

                /*0x3aa09a8*/ <>c__DisplayClass60_0();
                /*0x3aa5d48*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <LoadContentCatalogAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                /*0x3aa5d94*/ void <LoadContentCatalogAsync>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> obj);
            }

            class <>c__DisplayClass66_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ object key;

                /*0x1f309e4*/ <>c__DisplayClass66_0();
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass70_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;
                /*0x28*/ System.Type type;

                /*0x3aa1304*/ <>c__DisplayClass70_0();
                /*0x3aa5e04*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <LoadResourceLocationsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ System.Type type;

                /*0x3aa1518*/ <>c__DisplayClass72_0();
                /*0x3aa5e50*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <LoadResourceLocationsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass75_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ System.Collections.IEnumerable keys;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x1f309e4*/ <>c__DisplayClass75_0();
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass77_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ object key;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x1f309e4*/ <>c__DisplayClass77_0();
                /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op2);
            }

            class <>c__DisplayClass85_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;

                /*0x3aa1a10*/ <>c__DisplayClass85_0();
                /*0x3aa5e94*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass86_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;

                /*0x3aa1b68*/ <>c__DisplayClass86_0();
                /*0x3aa5ed8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass89_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;

                /*0x3aa1d74*/ <>c__DisplayClass89_0();
                /*0x3aa5f1c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                /*0x3aa5fac*/ void <DownloadDependenciesAsyncWithChain>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            }

            class <>c__DisplayClass92_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;

                /*0x3aa27a0*/ <>c__DisplayClass92_0();
                /*0x3aa6020*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                /*0x3aa60b0*/ void <DownloadDependenciesAsyncWithChain>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            }

            class <>c__DisplayClass94_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;

                /*0x3aa29b4*/ <>c__DisplayClass94_0();
                /*0x3aa6124*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                /*0x3aa61b8*/ void <DownloadDependenciesAsyncWithChain>b__1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> op);
            }

            class <>c__DisplayClass97_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ bool autoReleaseHandle;

                /*0x3aa3100*/ <>c__DisplayClass97_0();
                /*0x3aa622c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass98_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;
                /*0x20*/ bool autoReleaseHandle;

                /*0x3aa3108*/ <>c__DisplayClass98_0();
                /*0x3aa6274*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass99_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ bool autoReleaseHandle;

                /*0x3aa3110*/ <>c__DisplayClass99_0();
                /*0x3aa62bc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }
        }

        class AssetLabelReference : UnityEngine.AddressableAssets.IKeyEvaluator
        {
            /*0x10*/ string m_LabelString;

            /*0x3aa63cc*/ AssetLabelReference();
            /*0x3aa6304*/ string get_labelString();
            /*0x3aa630c*/ void set_labelString(string value);
            /*0x3aa6314*/ object get_RuntimeKey();
            /*0x3aa6350*/ bool RuntimeKeyIsValid();
            /*0x3aa63b0*/ int GetHashCode();
        }

        class AssetReferenceT<TObject> : UnityEngine.AddressableAssets.AssetReference
        {
            /*0x1f30ebc*/ AssetReferenceT(string guid);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAsset();
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync();
            /*0x1f2fec8*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x1f2fec8*/ bool ValidateAsset(string path);
        }

        class AssetReferenceGameObject : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.GameObject>
        {
            /*0x3aa63d4*/ AssetReferenceGameObject(string guid);
        }

        class AssetReferenceTexture : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture>
        {
            /*0x3aa642c*/ AssetReferenceTexture(string guid);
        }

        class AssetReferenceTexture2D : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture2D>
        {
            /*0x3aa6484*/ AssetReferenceTexture2D(string guid);
        }

        class AssetReferenceTexture3D : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture3D>
        {
            /*0x3aa64dc*/ AssetReferenceTexture3D(string guid);
        }

        class AssetReferenceSprite : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Sprite>
        {
            /*0x3aa6534*/ AssetReferenceSprite(string guid);
            /*0x3aa658c*/ bool ValidateAsset(string path);
        }

        class AssetReferenceAtlasedSprite : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Sprite>
        {
            /*0x3aa6594*/ AssetReferenceAtlasedSprite(string guid);
            /*0x3aa65ec*/ bool ValidateAsset(string path);
        }

        class AssetReference : UnityEngine.AddressableAssets.IKeyEvaluator
        {
            /*0x10*/ string m_AssetGUID;
            /*0x18*/ string m_SubObjectName;
            /*0x20*/ string m_SubObjectType;
            /*0x28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle m_Operation;

            static /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<T> CreateFailedOperation<T>();
            /*0x3aa6770*/ AssetReference();
            /*0x3aa67c8*/ AssetReference(string guid);
            /*0x3aa65f4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OperationHandle();
            /*0x3aa6608*/ object get_RuntimeKey();
            /*0x3aa66a0*/ string get_AssetGUID();
            /*0x3aa66a8*/ string get_SubObjectName();
            /*0x3aa66b0*/ void set_SubObjectName(string value);
            /*0x3aa66b8*/ System.Type get_SubOjbectType();
            /*0x3aa6758*/ bool IsValid();
            /*0x3aa6764*/ bool get_IsDone();
            /*0x3aa6840*/ UnityEngine.Object get_Asset();
            /*0x3aa68dc*/ string ToString();
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAsset<TObject>();
            /*0x3aa6948*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadScene();
            /*0x3aa6990*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            /*0x3aa69cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> Instantiate(UnityEngine.Transform parent, bool instantiateInWorldSpace);
            /*0x1ffc854*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>();
            /*0x3aa6a08*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            /*0x3aa6b70*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnLoadScene();
            /*0x3aa6c04*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            /*0x3aa6d00*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.Transform parent, bool instantiateInWorldSpace);
            /*0x3aa6db0*/ bool RuntimeKeyIsValid();
            /*0x3aa6e68*/ void ReleaseAsset();
            /*0x3aa6f40*/ void ReleaseInstance(UnityEngine.GameObject obj);
            /*0x3aa6f94*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x3aa6f9c*/ bool ValidateAsset(string path);
        }

        interface IKeyEvaluator
        {
            /*0x1f30214*/ object get_RuntimeKey();
            /*0x1f2fe14*/ bool RuntimeKeyIsValid();
        }

        class CheckCatalogsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.List<string>>
        {
            /*0x80*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0x88*/ System.Collections.Generic.List<string> m_LocalHashes;
            /*0x90*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos;
            /*0x98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;

            /*0x3aa3a40*/ CheckCatalogsOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
            /*0x3aa3aa4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> Start(System.Collections.Generic.List<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo> locatorInfos);
            /*0x3aa6fa4*/ void Destroy();
            /*0x3aa7014*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x3aa70c4*/ void Execute();

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.CheckCatalogsOperation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__5_0;

                static /*0x3aa7460*/ <>c();
                /*0x3aa74c8*/ <>c();
                /*0x3aa74d0*/ bool <Start>b__5_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
            }
        }

        class UpdateCatalogsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>>
        {
            /*0x80*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0x88*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo> m_LocatorInfos;
            /*0x90*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;

            /*0x3aa447c*/ UpdateCatalogsOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
            /*0x3aa44e0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> Start(System.Collections.Generic.IEnumerable<string> catalogIds);
            /*0x3aa7560*/ void Destroy();
            /*0x3aa75d0*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x3aa7680*/ void Execute();

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.UpdateCatalogsOperation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__4_0;

                static /*0x3aa7b94*/ <>c();
                /*0x3aa7bfc*/ <>c();
                /*0x3aa7c04*/ bool <Start>b__4_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
            }
        }

        class DynamicResourceLocator : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
        {
            /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;

            /*0x3aa7d18*/ DynamicResourceLocator(UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x3aa7c94*/ string get_LocatorId();
            /*0x3aa7cd4*/ System.Collections.Generic.IEnumerable<object> get_Keys();
            /*0x3aa7d48*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x3aa8254*/ void CreateDynamicLocations(System.Type type, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, string locName, string subKey, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation mainLoc);
            /*0x3aa8a64*/ int get_Count();
        }

        enum AddressablesPlatform
        {
            Unknown = 0,
            Windows = 1,
            OSX = 2,
            Linux = 3,
            PS4 = 4,
            Switch = 5,
            XboxOne = 6,
            WebGL = 7,
            iOS = 8,
            Android = 9,
            WindowsUniversal = 10,
        }

        class PlatformMappingService
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.RuntimePlatform, UnityEngine.AddressableAssets.AddressablesPlatform> s_RuntimeTargetMapping;

            static /*0x3aa8b5c*/ PlatformMappingService();
            static /*0x3aa8a6c*/ UnityEngine.AddressableAssets.AddressablesPlatform GetAddressablesPlatformInternal(UnityEngine.RuntimePlatform platform);
            static /*0x3a9ec38*/ UnityEngine.AddressableAssets.AddressablesPlatform GetPlatform();
            /*0x3aa8b54*/ PlatformMappingService();
        }

        namespace Utility
        {
            class DiagnosticInfo
            {
                /*0x10*/ string DisplayName;
                /*0x18*/ int ObjectId;
                /*0x20*/ int[] Dependencies;

                /*0x3aa8e20*/ DiagnosticInfo();
                /*0x3aa8ddc*/ UnityEngine.ResourceManagement.Diagnostics.DiagnosticEvent CreateEvent(string category, UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventType eventType, int frame, int val);
            }

            class ResourceManagerDiagnostics : System.IDisposable
            {
                /*0x10*/ UnityEngine.ResourceManagement.ResourceManager m_ResourceManager;
                /*0x18*/ System.Collections.Generic.Dictionary<int, UnityEngine.AddressableAssets.Utility.DiagnosticInfo> m_cachedDiagnosticInfo;

                /*0x3aa8e28*/ ResourceManagerDiagnostics(UnityEngine.ResourceManagement.ResourceManager resourceManager);
                /*0x3aa8f28*/ int SumDependencyNameHashCodes(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
                /*0x3aa91a4*/ int CalculateHashCode(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
                /*0x3aa9298*/ void OnResourceManagerDiagnosticEvent(UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext eventContext);
                /*0x3aa9614*/ void Dispose();
            }

            class SerializationUtilities
            {
                static /*0x3aa96ec*/ int ReadInt32FromByteArray(byte[] data, int offset);
                static /*0x3aa975c*/ int WriteInt32ToByteArray(byte[] data, int val, int offset);
                static /*0x3aa97e0*/ object ReadObjectFromByteArray(byte[] keyData, int dataIndex);
                static /*0x3aa9d18*/ int WriteObjectToByteList(object obj, System.Collections.Generic.List<byte> buffer);

                enum ObjectType
                {
                    AsciiString = 0,
                    UnicodeString = 1,
                    UInt16 = 2,
                    UInt32 = 3,
                    Int32 = 4,
                    Hash128 = 5,
                    Type = 6,
                    JsonObject = 7,
                }
            }
        }

        namespace ResourceProviders
        {
            class ContentCatalogProvider : UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase
            {
                /*0x1c*/ bool DisableCatalogUpdateOnStart;
                /*0x1d*/ bool IsLocalCatalogInBundle;
                /*0x20*/ System.Collections.Generic.Dictionary<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.AddressableAssets.ResourceProviders.ContentCatalogProvider.InternalOp> m_LocationToCatalogLoadOpMap;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceManager m_RM;

                /*0x3aaa4c4*/ ContentCatalogProvider(UnityEngine.ResourceManagement.ResourceManager resourceManagerInstance);
                /*0x3aaa56c*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object obj);
                /*0x3aaa664*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);

                enum DependencyHashIndex
                {
                    Remote = 0,
                    Cache = 1,
                    Builtin = 2,
                    Count = 3,
                }

                class InternalOp
                {
                    /*0x10*/ string m_LocalDataPath;
                    /*0x18*/ string m_RemoteHashValue;
                    /*0x20*/ string m_LocalHashValue;
                    /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProviderInterface;
                    /*0x40*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData m_ContentCatalogData;

                    /*0x3aaa7b4*/ InternalOp();
                    /*0x3aaa7bc*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle);
                    /*0x3aaa654*/ void Release();
                    /*0x3aaaf3c*/ void LoadCatalog(string idToLoad, bool isLocalCatalogInBundle, bool isLocalCatalog);
                    /*0x3aaae80*/ string GetTransformedInternalId(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
                    /*0x3aaa8f0*/ string DetermineIdToLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Collections.Generic.IList<object> dependencyObjects, bool disableCatalogUpdateOnStart);
                    /*0x3aab664*/ void OnCatalogLoaded(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
                    /*0x3aab860*/ void <LoadCatalog>b__7_0(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
                    /*0x3aab88c*/ void <LoadCatalog>b__7_1(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> op);

                    class BundledCatalog
                    {
                        /*0x10*/ string m_BundlePath;
                        /*0x18*/ bool m_OpInProgress;
                        /*0x20*/ UnityEngine.AssetBundleCreateRequest m_LoadBundleRequest;
                        /*0x28*/ UnityEngine.AssetBundle m_CatalogAssetBundle;
                        /*0x30*/ UnityEngine.AssetBundleRequest m_LoadTextAssetRequest;
                        /*0x38*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData m_CatalogData;
                        /*0x40*/ System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> OnLoaded;

                        /*0x3aab39c*/ BundledCatalog(string bundlePath);
                        /*0x3aab4b4*/ void add_OnLoaded(System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> value);
                        /*0x3aab970*/ void remove_OnLoaded(System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> value);
                        /*0x3aaba20*/ bool get_OpInProgress();
                        /*0x3aaba28*/ bool get_OpIsSuccess();
                        /*0x3aaba48*/ void Finalize();
                        /*0x3aabacc*/ void Unload();
                        /*0x3aab564*/ void LoadCatalogFromBundleAsync();
                        /*0x3aabafc*/ void <LoadCatalogFromBundleAsync>b__16_0(UnityEngine.AsyncOperation loadOp);
                        /*0x3aabcd8*/ void <LoadCatalogFromBundleAsync>b__16_1(UnityEngine.AsyncOperation op);
                    }
                }
            }
        }

        namespace ResourceLocators
        {
            class ContentCatalogDataEntry
            {
                /*0x10*/ string <InternalId>k__BackingField;
                /*0x18*/ string <Provider>k__BackingField;
                /*0x20*/ System.Collections.Generic.List<object> <Keys>k__BackingField;
                /*0x28*/ System.Collections.Generic.List<object> <Dependencies>k__BackingField;
                /*0x30*/ object <Data>k__BackingField;
                /*0x38*/ System.Type <ResourceType>k__BackingField;

                /*0x3aabedc*/ ContentCatalogDataEntry(System.Type type, string internalId, string provider, System.Collections.Generic.IEnumerable<object> keys, System.Collections.Generic.IEnumerable<object> dependencies, object extraData);
                /*0x3aabe7c*/ string get_InternalId();
                /*0x3aabe84*/ void set_InternalId(string value);
                /*0x3aabe8c*/ string get_Provider();
                /*0x3aabe94*/ void set_Provider(string value);
                /*0x3aabe9c*/ System.Collections.Generic.List<object> get_Keys();
                /*0x3aabea4*/ void set_Keys(System.Collections.Generic.List<object> value);
                /*0x3aabeac*/ System.Collections.Generic.List<object> get_Dependencies();
                /*0x3aabeb4*/ void set_Dependencies(System.Collections.Generic.List<object> value);
                /*0x3aabebc*/ object get_Data();
                /*0x3aabec4*/ void set_Data(object value);
                /*0x3aabecc*/ System.Type get_ResourceType();
                /*0x3aabed4*/ void set_ResourceType(System.Type value);
            }

            class ContentCatalogData
            {
                static int kBytesPerInt32 = 4;
                static int k_EntryDataItemPerEntry = 7;
                /*0x10*/ string localHash;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;
                /*0x20*/ string m_LocatorId;
                /*0x28*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData m_InstanceProviderData;
                /*0x58*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData m_SceneProviderData;
                /*0x88*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> m_ResourceProviderData;
                /*0x90*/ string[] m_ProviderIds;
                /*0x98*/ string[] m_InternalIds;
                /*0xa0*/ string m_KeyDataString;
                /*0xa8*/ string m_BucketDataString;
                /*0xb0*/ string m_EntryDataString;
                /*0xb8*/ string m_ExtraDataString;
                /*0xc0*/ UnityEngine.ResourceManagement.Util.SerializedType[] m_resourceTypes;
                /*0xc8*/ string[] m_InternalIdPrefixes;

                static /*0x3aac920*/ string ExpandInternalId(string[] internalIdPrefixes, string v);
                /*0x3aacb9c*/ ContentCatalogData();
                /*0x3aac02c*/ string get_ProviderId();
                /*0x3aac034*/ void set_ProviderId(string value);
                /*0x3aac03c*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData get_InstanceProviderData();
                /*0x3aac054*/ void set_InstanceProviderData(UnityEngine.ResourceManagement.Util.ObjectInitializationData value);
                /*0x3aac07c*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData get_SceneProviderData();
                /*0x3aac094*/ void set_SceneProviderData(UnityEngine.ResourceManagement.Util.ObjectInitializationData value);
                /*0x3aac0bc*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> get_ResourceProviderData();
                /*0x3aac0c4*/ void set_ResourceProviderData(System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> value);
                /*0x3aac0cc*/ string[] get_ProviderIds();
                /*0x3aac0d4*/ string[] get_InternalIds();
                /*0x3aab2d0*/ void CleanData();
                /*0x3aa7b68*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap CreateCustomLocator(string overrideId, string providerSuffix);
                /*0x3aac0dc*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap CreateLocator(string providerSuffix);

                struct Bucket
                {
                    /*0x10*/ int dataOffset;
                    /*0x18*/ int[] entries;
                }

                class CompactLocation : UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation
                {
                    /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap m_Locator;
                    /*0x18*/ string m_InternalId;
                    /*0x20*/ string m_ProviderId;
                    /*0x28*/ object m_Dependency;
                    /*0x30*/ object m_Data;
                    /*0x38*/ int m_HashCode;
                    /*0x3c*/ int m_DependencyHashCode;
                    /*0x40*/ string m_PrimaryKey;
                    /*0x48*/ System.Type m_Type;
                    /*0x50*/ System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> <OnPriorityChanged>k__BackingField;
                    /*0x58*/ UnityEngine.ResourceManagement.EA.ResourcePriority _priority;

                    /*0x3aac9e0*/ CompactLocation(UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, System.Type type);
                    /*0x3aacc24*/ string get_InternalId();
                    /*0x3aacc2c*/ string get_ProviderId();
                    /*0x3aacc34*/ void set_ProviderId(string value);
                    /*0x3aacc3c*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                    /*0x3aad4dc*/ bool get_HasDependencies();
                    /*0x3aad4ec*/ int get_DependencyHashCode();
                    /*0x3aad4f4*/ object get_Data();
                    /*0x3aad4fc*/ string get_PrimaryKey();
                    /*0x3aad504*/ void set_PrimaryKey(string value);
                    /*0x3aad50c*/ System.Type get_ResourceType();
                    /*0x3aad514*/ string ToString();
                    /*0x3aad51c*/ int Hash(System.Type t);
                    /*0x3aad568*/ System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> get_OnPriorityChanged();
                    /*0x3aad570*/ void set_OnPriorityChanged(System.Action<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, UnityEngine.ResourceManagement.EA.ResourcePriority, UnityEngine.ResourceManagement.EA.ResourcePriority> value);
                    /*0x3aad578*/ UnityEngine.ResourceManagement.EA.ResourcePriority get_Priority();
                    /*0x3aad580*/ void set_Priority(UnityEngine.ResourceManagement.EA.ResourcePriority value);
                }
            }

            interface IResourceLocator
            {
                /*0x1f30214*/ string get_LocatorId();
                /*0x1f30214*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                /*0x1f2ffc8*/ int get_Count();
            }

            class LegacyResourcesLocator : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
            {
                /*0x3aad88c*/ LegacyResourcesLocator();
                /*0x3aad5c8*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                /*0x3aad83c*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                /*0x3aad844*/ string get_LocatorId();
                /*0x3aad884*/ int get_Count();
            }

            class ResourceLocationData
            {
                /*0x10*/ string[] m_Keys;
                /*0x18*/ string m_InternalId;
                /*0x20*/ string m_Provider;
                /*0x28*/ string[] m_Dependencies;
                /*0x30*/ UnityEngine.ResourceManagement.Util.SerializedType m_ResourceType;

                /*0x3aad8c0*/ ResourceLocationData(string[] keys, string id, System.Type provider, System.Type t, string[] dependencies);
                /*0x3aada28*/ ResourceLocationData(string[] keys, string id, string provider, System.Type t, string[] dependencies);
                /*0x3aad894*/ string[] get_Keys();
                /*0x3aad89c*/ string get_InternalId();
                /*0x3aad8a4*/ string get_Provider();
                /*0x3aad8ac*/ string[] get_Dependencies();
                /*0x3aad8b4*/ System.Type get_ResourceType();
            }

            class ResourceLocationMap : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
            {
                /*0x10*/ string <LocatorId>k__BackingField;
                /*0x18*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <Locations>k__BackingField;

                /*0x3aac868*/ ResourceLocationMap(string id, int capacity);
                /*0x3aadb3c*/ ResourceLocationMap(string id, System.Collections.Generic.IList<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> locations);
                /*0x3aadb2c*/ string get_LocatorId();
                /*0x3aadb34*/ void set_LocatorId(string value);
                /*0x3aae9b0*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> get_Locations();
                /*0x3aae9b8*/ void set_Locations(System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> value);
                /*0x3aae9c0*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                /*0x3aaccbc*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                /*0x3aae850*/ void Add(object key, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3aacb34*/ void Add(object key, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                /*0x3aaea10*/ int get_Count();
            }
        }

        namespace Initialization
        {
            class AddressablesRuntimeProperties
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<string, string> s_CachedValues;

                static /*0x3aaf174*/ AddressablesRuntimeProperties();
                static /*0x3aaea60*/ System.Reflection.Assembly[] GetAssemblies();
                static /*0x3aaea80*/ int GetCachedValueCount();
                static /*0x3aaeaf8*/ void SetPropertyValue(string name, string val);
                static /*0x3aaeb88*/ void ClearCachedPropertyValues();
                static /*0x3aaec00*/ string EvaluateProperty(string name);
                static /*0x3a9ecbc*/ string EvaluateString(string input);
                static /*0x3aaf040*/ string EvaluateString(string inputString, char startDelimiter, char endDelimiter, System.Func<string, string> varFunc);
            }

            class CacheInitialization : UnityEngine.ResourceManagement.Util.IInitializableObject
            {
                static /*0x3aaf554*/ string get_RootPath();
                /*0x3aaf5d0*/ CacheInitialization();
                /*0x3aaf20c*/ bool Initialize(string id, string dataStr);
                /*0x3aaf37c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);

                class CacheInitOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
                {
                    /*0x80*/ System.Func<bool> m_Callback;
                    /*0x88*/ bool m_UpdateRequired;

                    /*0x3aaf504*/ CacheInitOp();
                    /*0x3aaf5d8*/ void Init(System.Func<bool> callback);
                    /*0x3aaf5e0*/ void Execute();
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.Initialization.CacheInitialization <>4__this;
                    /*0x18*/ string id;
                    /*0x20*/ string data;

                    /*0x3aaf4fc*/ <>c__DisplayClass1_0();
                    /*0x3aaf6b8*/ bool <InitializeAsync>b__0();
                }
            }

            class CacheInitializationData
            {
                /*0x10*/ bool m_CompressionEnabled;
                /*0x18*/ string m_CacheDirectoryOverride;
                /*0x20*/ int m_ExpirationDelay;
                /*0x24*/ bool m_LimitCacheSize;
                /*0x28*/ long m_MaximumCacheSize;

                /*0x3aaf72c*/ CacheInitializationData();
                /*0x3aaf6dc*/ bool get_CompressionEnabled();
                /*0x3aaf6e4*/ void set_CompressionEnabled(bool value);
                /*0x3aaf6ec*/ string get_CacheDirectoryOverride();
                /*0x3aaf6f4*/ void set_CacheDirectoryOverride(string value);
                /*0x3aaf6fc*/ int get_ExpirationDelay();
                /*0x3aaf704*/ void set_ExpirationDelay(int value);
                /*0x3aaf70c*/ bool get_LimitCacheSize();
                /*0x3aaf714*/ void set_LimitCacheSize(bool value);
                /*0x3aaf71c*/ long get_MaximumCacheSize();
                /*0x3aaf724*/ void set_MaximumCacheSize(long value);
            }

            class InitializationOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>
            {
                /*0x80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> m_rtdOp;
                /*0x98*/ string m_ProviderSuffix;
                /*0xa0*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xa8*/ UnityEngine.AddressableAssets.Utility.ResourceManagerDiagnostics m_Diagnostics;
                /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.InitalizationObjectsOperation m_InitGroupOps;

                static /*0x3a9ff54*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> CreateInitializationOperation(UnityEngine.AddressableAssets.AddressablesImpl aa, string playerSettingsLocation, string providerSuffix);
                static /*0x3ab05bc*/ void LoadProvider(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.Util.ObjectInitializationData providerData, string providerSuffix);
                static /*0x3ab0a2c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> OnCatalogDataLoaded(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> op, string providerSuffix);
                static /*0x3aa09b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc, string providerSuffix);
                /*0x3aaf7a0*/ InitializationOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
                /*0x3aaf854*/ float get_Progress();
                /*0x3aaf8d0*/ string get_DebugName();
                /*0x3aafb64*/ void Execute();
                /*0x3ab0f0c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc, string providerSuffix);
                /*0x3ab03a8*/ void LoadContentCatalogInternal(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs, int index, UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap);

                class <>c
                {
                    static /*0x0*/ UnityEngine.AddressableAssets.Initialization.InitializationOperation.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__11_0;
                    static /*0x10*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__11_1;

                    static /*0x3ab0f48*/ <>c();
                    /*0x3ab0fb0*/ <>c();
                    /*0x3ab0fb8*/ bool <Execute>b__11_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
                    /*0x3ab1048*/ bool <Execute>b__11_1(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl addressables;
                    /*0x18*/ string providerSuffix;

                    /*0x3ab0f04*/ <>c__DisplayClass14_0();
                    /*0x3ab10d8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <LoadContentCatalog>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> res);
                }

                class <>c__DisplayClass16_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.Initialization.InitializationOperation <>4__this;
                    /*0x18*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap;
                    /*0x20*/ int index;
                    /*0x28*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs;

                    /*0x3ab0f40*/ <>c__DisplayClass16_0();
                    /*0x3ab1124*/ void <LoadContentCatalogInternal>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> op);
                }
            }

            class ResourceManagerRuntimeData
            {
                static string kCatalogAddress = "AddressablesMainContentCatalog";
                /*0x10*/ string m_buildTarget;
                /*0x18*/ string m_SettingsHash;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> m_CatalogLocations;
                /*0x28*/ bool m_ProfileEvents;
                /*0x29*/ bool m_LogResourceManagerExceptions;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> m_ExtraInitializationData;
                /*0x38*/ bool m_DisableCatalogUpdateOnStart;
                /*0x39*/ bool m_IsLocalCatalogInBundle;
                /*0x40*/ UnityEngine.ResourceManagement.Util.SerializedType m_CertificateHandlerType;
                /*0x60*/ string m_AddressablesVersion;
                /*0x68*/ int m_maxConcurrentWebRequests;

                /*0x3ab15b4*/ ResourceManagerRuntimeData();
                /*0x3ab1504*/ string get_BuildTarget();
                /*0x3ab150c*/ void set_BuildTarget(string value);
                /*0x3ab1514*/ string get_SettingsHash();
                /*0x3ab151c*/ void set_SettingsHash(string value);
                /*0x3ab1524*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> get_CatalogLocations();
                /*0x3ab152c*/ bool get_ProfileEvents();
                /*0x3ab1534*/ void set_ProfileEvents(bool value);
                /*0x3ab153c*/ bool get_LogResourceManagerExceptions();
                /*0x3ab1544*/ void set_LogResourceManagerExceptions(bool value);
                /*0x3ab154c*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> get_InitializationObjects();
                /*0x3ab1554*/ bool get_DisableCatalogUpdateOnStartup();
                /*0x3ab155c*/ void set_DisableCatalogUpdateOnStartup(bool value);
                /*0x3ab1564*/ bool get_IsLocalCatalogInBundle();
                /*0x3ab156c*/ void set_IsLocalCatalogInBundle(bool value);
                /*0x3ab039c*/ System.Type get_CertificateHandlerType();
                /*0x3ab1574*/ void set_CertificateHandlerType(System.Type value);
                /*0x3ab1580*/ string get_AddressablesVersion();
                /*0x3ab1588*/ void set_AddressablesVersion(string value);
                /*0x3ab1590*/ int get_MaxConcurrentWebRequests();
                /*0x3ab1598*/ void set_MaxConcurrentWebRequests(int value);
            }
        }

        namespace EA
        {
            class CatalogAddressPaths
            {
                static string PackageInBuildTag = "PackageInBuild";
                static string UpdateContentId = "AddressablesUpdateContentCatalog";
                static string UpdateCatalogLocatorKey = "CatalogUpdateAddress";
                static string BuiltinCatalogLocatorKey = "BuiltinCatalogHashAddress";
                static string CatalogCacheHashAddress = "AddressablesMainContentCatalogCacheHash";
                static string CatalogRemoteHashAddress = "AddressablesMainContentCatalogRemoteHash";
                static string AddressablesCachedDataPath = "CachedAddressablesRuntimeDataPath";

                static /*0x3ab16a0*/ string get_CacheSettingsDataPath();
                static /*0x3ab16e0*/ string get_CachedDataLocation();
                static /*0x3ab174c*/ string GetPlayerLocation(string playerPrefKey, string playerPrefDefault);
            }

            class CheckCatalogHashIsInstalledOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
            {
                /*0x80*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo> _locatorInfos;
                /*0x88*/ string _hash;

                /*0x3ab17c4*/ CheckCatalogHashIsInstalledOperation(System.Collections.Generic.List<UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo> locatorInfos, string hash);
                /*0x3ab183c*/ void Execute();
            }

            struct ResourceOptionData : System.IEquatable<UnityEngine.AddressableAssets.EA.ResourceOptionData>
            {
                /*0x10*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation Location;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions _options;

                /*0x3ab1a24*/ ResourceOptionData(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions options);
                /*0x3ab1a0c*/ string get_Hash();
                /*0x3ab1a54*/ bool Equals(UnityEngine.AddressableAssets.EA.ResourceOptionData other);
                /*0x3ab1a60*/ bool Equals(object obj);
                /*0x3ab1ae0*/ int GetHashCode();
            }

            class GetAllBundleResourceOptionsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.AddressableAssets.EA.ResourceOptionData>>
            {
                /*0x80*/ UnityEngine.AddressableAssets.AddressablesImpl _addressables;
                /*0x88*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator _resourceLocator;

                /*0x3ab1af8*/ GetAllBundleResourceOptionsOperation(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator resourceLocator);
                /*0x3ab1b70*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.AddressableAssets.EA.ResourceOptionData>> Start();
                /*0x3ab1bfc*/ void Execute();
            }

            class ClearOutdatedBundleCache : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<int>
            {
                /*0x80*/ UnityEngine.AddressableAssets.AddressablesImpl _addressables;
                /*0x88*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.AddressableAssets.EA.ResourceOptionData>> _loadOp;

                /*0x3ab2150*/ ClearOutdatedBundleCache(UnityEngine.AddressableAssets.AddressablesImpl addressables);
                /*0x3ab21b4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle Start(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator resourceLocator);
                /*0x3ab2320*/ void Destroy();
                /*0x3ab2390*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
                /*0x3ab2440*/ void Execute();
                /*0x3ab2868*/ System.ValueTuple<string, System.Nullable<UnityEngine.Hash128>> GetBundleCachingInfo(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, string hash);
            }

            class ComponentReference<TComponent> : UnityEngine.AddressableAssets.AssetReference
            {
                /*0x1f309e4*/ ComponentReference();
                /*0x1f30ebc*/ ComponentReference(string guid);
                /*0x1f30214*/ UnityEngine.GameObject get_GameObj();
                /*0x1ffc854*/ TComponent get_Component();
                UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> LoadAssetAsync();
                /*0x1f2fec8*/ bool ValidateAsset(UnityEngine.Object obj);
                /*0x1f2fec8*/ bool ValidateAsset(string path);
            }

            class ContentUpdateOperationBase<T> : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<T>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl _addressables;

                /*0x1f30ebc*/ ContentUpdateOperationBase(UnityEngine.AddressableAssets.AddressablesImpl addressables);
                /*0x1f30a84*/ void SetDisableCatalogUpdateOnStart(bool shouldEnable);
            }

            class DownloadInstallRemoteCatalogOperation : UnityEngine.AddressableAssets.EA.ContentUpdateOperationBase<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>
            {
                /*0x88*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> _loadOp;
                /*0xa0*/ UnityEngine.AddressableAssets.EA.RemoteCatalogData _catalogResource;
                /*0xc0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation _localCatalogLocation;
                /*0xc8*/ UnityEngine.AddressableAssets.EA.IModifyCatalogDataRunner _modifyCatalogDataRunner;

                /*0x3ab2a48*/ DownloadInstallRemoteCatalogOperation(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.AddressableAssets.EA.IModifyCatalogDataRunner modifyCatalogDataRunner);
                /*0x3ab2ab4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> Start(string hash);
                /*0x3ab3014*/ void Destroy();
                /*0x3ab3084*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
                /*0x3ab3134*/ void Execute();
                /*0x3ab387c*/ void OnCatalogLoaded(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
                /*0x3ab3598*/ void UpdateCatalogWithPackaged(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData localCcd, UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData remoteCcd);
            }

            class DownloadUtils
            {
                static /*0x0*/ System.Collections.Generic.IList<object> SingleKeyCache;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> SingleResourceLocationList;
                static /*0x10*/ System.Collections.Generic.IDictionary<UnityEngine.ResourceManagement.ResourceLocations.ILocationSizeData, long> CachedComputedSizes;
                static /*0x18*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> UniqueLocationsTrackerScratchSet;

                static /*0x3ab6bb8*/ DownloadUtils();
                static /*0x3ab3a3c*/ void ClearCachedComputedSizes();
                static /*0x3ab3b08*/ long GetDownloadSizeAssumeSyncSuccess(object key);
                static /*0x3ab3cec*/ long GetDownloadSizeFromHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> handle);
                static /*0x3ab3b74*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
                static /*0x3ab4780*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
                static /*0x3ab48e4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.Generic.IList<object> keys);
                static /*0x3ab4a48*/ long GetDownloadSizeAssumeSyncSuccess(System.Collections.Generic.IList<object> keys);
                static /*0x3ab3e24*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.Generic.IList<object> keys);
                static /*0x3ab4f10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> DownloadDependenciesAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation key, bool autoReleaseHandle);
                static /*0x3ab5408*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle, System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> progressCallback);
                static /*0x3ab5b60*/ System.ValueTuple<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, long> DownloadAndGetSizeForDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> keys, bool autoReleaseHandle, System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> progressCallback);
                static /*0x3ab6034*/ System.ValueTuple<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle, long> DownloadAndGetSizeForDependenciesAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation key, bool autoReleaseHandle, System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> progressCallback);
                static /*0x3ab6284*/ int GetCachedCount(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> keys);
                static /*0x3ab4ab4*/ long CalculateTotalSizeOfDependencies(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, System.Collections.Generic.ISet<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> uniqueLocationsTracker);
                static /*0x3ab68fc*/ bool TryGetSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, ref long size);

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ object key;

                    /*0x3ab48dc*/ <>c__DisplayClass7_0();
                    /*0x3ab6d64*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ System.Collections.Generic.IList<object> keys;

                    /*0x3ab4a40*/ <>c__DisplayClass8_0();
                    /*0x3ab6de4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                }
            }

            interface IModifyCatalogDataRunner
            {
                /*0x1f30ebc*/ void ModifyCatalogData(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
            }

            class LoadResourceManagerRuntimeData : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData>
            {
                /*0x80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> _loadOp;
                /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl _addressables;
                /*0xa0*/ UnityEngine.AddressableAssets.EA.ResourceManagerRuntimeDataUtil _dataUtil;

                /*0x3aaf910*/ LoadResourceManagerRuntimeData(UnityEngine.AddressableAssets.AddressablesImpl aa);
                /*0x3aaf9b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> Start(UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase runtimeDataLocation);
                /*0x3ab6e74*/ void Destroy();
                /*0x3ab6ee4*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
                /*0x3ab6f94*/ void Execute();
                /*0x3ab725c*/ void CompleteAndUpdateCachedSettings(UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData runtimeData);

                enum HandleIndex
                {
                    Packaged = 0,
                    Cached = 1,
                    Count = 2,
                }
            }

            struct RemoteCatalogData
            {
                /*0x10*/ string Hash;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CatalogLocation;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CachedHashLocation;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase RemoteHashLocation;

                /*0x3ab7498*/ RemoteCatalogData(string hash, UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase catalogLocation, UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase cachedHashLocation, UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase remoteHashLocation);
                /*0x3ab73f4*/ string get_CachedHashFilePath();
                /*0x3ab39cc*/ string get_CachedJsonFilePath();
                /*0x3ab2d88*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateRemoteCatalogLocation();
            }

            class RemoteCatalogDebugUtils
            {
                static /*0x3ab74f8*/ void HookUpCrossAssemblyHooks();
                static /*0x3ab75f8*/ string GetCurrentCatalog();
                static /*0x3ab78c0*/ System.Collections.Generic.List<string> GetInstalledHashes();
                static /*0x3ab7a78*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> ForceContentUpdate(string hash);
                static /*0x3ab7b6c*/ void RemoveAllCurrentBundles();
                static /*0x3ab7b70*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle FinalizeContentUpdate(string catalogHash);
            }

            class RemoteCatalogUtils
            {
                static string CatalogBaseFilenameFormat = "catalog";
                static /*0x0*/ string CatalogJsonFilenameFormat;
                static /*0x8*/ string CatalogHashFilenameFormat;
                static /*0x10*/ string _remotePath;

                static /*0x3ab8bc4*/ RemoteCatalogUtils();
                static /*0x3ab7c6c*/ string get_RemotePath();
                static /*0x3ab1974*/ bool get_IsRemotePathSet();
                static /*0x3ab2cf4*/ UnityEngine.AddressableAssets.EA.RemoteCatalogData GetCatalogUpdateResourceLocation(string hash);
                static /*0x3ab7d84*/ UnityEngine.AddressableAssets.EA.RemoteCatalogData CreateCatalogLocationWithHashDependencies(string hash, string catalogPath, string hashFilePath);
                static /*0x3ab8158*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> HasHashInstalled(string hash);
                static /*0x3ab8240*/ System.Collections.Generic.IList<string> GetInstalledHashes();
                static /*0x3ab838c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> PrepareForContentUpdate(string hash);
                static /*0x3ab7bec*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle FinalizeContentUpdate(string hash);
                static /*0x3ab7cc4*/ string GetCatalogJsonPathForHash(string hash);
                static /*0x3ab7d24*/ string GetCatalogHashPathForHash(string hash);
                static /*0x3ab8644*/ void CleanOldAssetBundlesAsync(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator resourceLocator);
                static /*0x3ab8544*/ string GetCatalogPath(string format, string hash);
                static /*0x3ab0568*/ void SetCurrentLocationMap(UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locationMap);
                static /*0x3ab8750*/ void SetRemoteSettings(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locationMap);
                static /*0x3ab2fb0*/ UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo GetMainLocatorInfo();
                static /*0x3ab8b64*/ UnityEngine.AddressableAssets.AddressablesImpl.ResourceLocatorInfo GetLocatorInfo(string catalogId);
            }

            struct ResourceManagerRuntimeDataUtil
            {
                /*0x10*/ UnityEngine.ResourceManagement.ResourceManager _rm;

                static /*0x3ab8c88*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateResourceBase(string location);
                static /*0x3ab844c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> UpdatingSettingToUseHash(string hash);
                static /*0x3ab72d4*/ void UpdateCached(UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData packagedData);
                static /*0x1f36f18*/ void WriteObjectFileToCacheLocation<T>(ref T obj, string fileName);
                /*0x3ab8c80*/ ResourceManagerRuntimeDataUtil(UnityEngine.ResourceManagement.ResourceManager rm);
                /*0x3ab6e64*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase GetCachedDataLocation();
                /*0x3ab8e04*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> GetCachedData();
            }

            class SwapOutPackagedLocationForRemote : UnityEngine.AddressableAssets.EA.IModifyCatalogDataRunner
            {
                /*0x3ab7b64*/ SwapOutPackagedLocationForRemote();
                /*0x3ab9044*/ void ModifyCatalogData(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
            }

            class UpdateResourceManagerDataOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
            {
                /*0x80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> _loadOp;
                /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl _addressables;
                /*0xa0*/ UnityEngine.AddressableAssets.EA.ResourceManagerRuntimeDataUtil _dataUtil;
                /*0xa8*/ UnityEngine.AddressableAssets.EA.RemoteCatalogData _catalogData;

                static /*0x3ab9898*/ void UpdateResourceData(System.Collections.Generic.IReadOnlyDictionary<string, int> locationMap, UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData resourceManagerData, string address, string internalId);
                static /*0x3ab99d8*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData CreateResourceData(UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData original, string internalId);
                static /*0x3ab96dc*/ System.Collections.Generic.Dictionary<string, int> GetLocationsIndexData(System.Collections.Generic.IReadOnlyList<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> catalogLocations);
                /*0x3ab8e88*/ UpdateResourceManagerDataOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
                /*0x3ab8f28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> Start(ref UnityEngine.AddressableAssets.EA.RemoteCatalogData catalogData);
                /*0x3ab9230*/ void Destroy();
                /*0x3ab92a0*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
                /*0x3ab9350*/ void Execute();
                /*0x3ab94b0*/ void UpdateCatalogLocations(UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData resourceManagerData);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 70F9DDF1540A4B47556307166F9F45EB0EA4CA18B1363301BF44C6F2786A7F28;
    static /*0xc9c*/ <PrivateImplementationDetails> 916FE92EEC6A6EE2AA64C06D9FA1A21409CC80CD3899DA1A9D187BA2B8020F8A;

    struct __StaticArrayInitTypeSize=3228
    {
    }

    struct __StaticArrayInitTypeSize=3981
    {
    }
}
