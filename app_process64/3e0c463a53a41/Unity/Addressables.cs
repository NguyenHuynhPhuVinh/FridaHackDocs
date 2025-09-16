class <Module>
{
}

class PackedPlayModeBuildLogs
{
    /*0x10*/ System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs;

    /*0x7926768*/ PackedPlayModeBuildLogs();
    /*0x7926758*/ System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> get_RuntimeBuildLogs();
    /*0x7926760*/ void set_RuntimeBuildLogs(System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> value);

    struct RuntimeBuildLog
    {
        /*0x10*/ UnityEngine.LogType Type;
        /*0x18*/ string Message;

        /*0x79267f0*/ RuntimeBuildLog(UnityEngine.LogType type, string message);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x7926800*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x79268f4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        /*0x792690c*/ AssetReferenceUIRestriction();
        /*0x79268fc*/ bool ValidateAsset(UnityEngine.Object obj);
        /*0x7926904*/ bool ValidateAsset(string path);
    }

    class AssetReferenceUILabelRestriction : UnityEngine.AssetReferenceUIRestriction
    {
        /*0x10*/ string[] m_AllowedLabels;
        /*0x18*/ string m_CachedToString;

        /*0x7926914*/ AssetReferenceUILabelRestriction(string[] allowedLabels);
        /*0x7926944*/ bool ValidateAsset(UnityEngine.Object obj);
        /*0x792694c*/ bool ValidateAsset(string path);
        /*0x7926954*/ string ToString();
    }

    namespace ResourceManagement
    {
        namespace AsyncOperations
        {
            class InitalizationObjectsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>
            {
                /*0x98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> m_RtdOp;
                /*0xb0*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xb8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;

                /*0x7927708*/ InitalizationObjectsOperation();
                /*0x7926a68*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> rtdOp, UnityEngine.AddressableAssets.AddressablesImpl addressables);
                /*0x7926ac8*/ string get_DebugName();
                /*0x7926b08*/ bool LogRuntimeWarnings(string pathToBuildLogs);
                /*0x7926e3c*/ bool InvokeWaitForCompletion();
                /*0x7926fdc*/ void Execute();
                /*0x7927750*/ void <Execute>b__8_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> obj);
            }
        }
    }

    namespace AddressableAssets
    {
        class ResourceLocatorInfo
        {
            /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator <Locator>k__BackingField;
            /*0x18*/ string <LocalHash>k__BackingField;
            /*0x20*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <CatalogLocation>k__BackingField;
            /*0x28*/ bool <ContentUpdateAvailable>k__BackingField;

            /*0x7927920*/ ResourceLocatorInfo(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc, string localHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            /*0x79278dc*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator get_Locator();
            /*0x79278e4*/ void set_Locator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator value);
            /*0x79278ec*/ string get_LocalHash();
            /*0x79278f4*/ void set_LocalHash(string value);
            /*0x79278fc*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_CatalogLocation();
            /*0x7927904*/ void set_CatalogLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation value);
            /*0x792790c*/ bool get_ContentUpdateAvailable();
            /*0x7927914*/ void set_ContentUpdateAvailable(bool value);
            /*0x7927980*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_HashLocation();
            /*0x7927a9c*/ bool get_CanUpdateContent();
            /*0x7927c40*/ void UpdateContent(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, string hash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
        }

        class InvalidKeyException : System.Exception
        {
            static string BaseInvalidKeyMessageFormat = "{0}, Key={1}, Type={2}";
            static string NoLocationMessageFormat = "{0} No Location found for Key={1}";
            static string MultipleTypeMismatchMessageFormat = "{0} No Asset found for Key={1} with Type={2}. Key exists as multiple Types={3}, which is not assignable from the requested Type={2}";
            static string TypeMismatchMessageFormat = "{0} No Asset found for Key={1} with Type={2}. Key exists as Type={3}, which is not assignable from the requested Type={2}";
            static string MultipleTypesMessageFormat = "{0} Enumerable key contains multiple Types. {1}, all Keys are expected to be strings";
            static string MergeModeNoLocationMessageFormat = "
No Location found for Key={0}";
            static string NoMergeModeMessageFormat = "{0} No MergeMode is set to merge the multiple keys requested. {1}, Type={2}";
            static string MergeModeBaseMessageFormat = "{0} No {1} of Assets between {2} with Type={3}";
            static string UnionAvailableForKeysMessageFormat = "
Union of Type={0} found with {1}";
            static string UnionAvailableForKeysWithoutOtherMessageFormat = "
Union of Type={0} found with {1}. Without {2}";
            static string IntersectionAvailableMessageFormat = "
An Intersection exists for Type={0}";
            static string KeyAvailableAsTypeMessageFormat = "
Type={0} exists for {1}";
            /*0x90*/ object <Key>k__BackingField;
            /*0x98*/ System.Type <Type>k__BackingField;
            /*0xa0*/ System.Nullable<UnityEngine.AddressableAssets.Addressables.MergeMode> <MergeMode>k__BackingField;
            /*0xa8*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;

            static /*0x79295a8*/ string GetCSVString(System.Collections.IEnumerable enumerator, string prefixSingle, string prefixPlural);
            /*0x7927cb0*/ InvalidKeyException(object key);
            /*0x7927d04*/ InvalidKeyException(object key, System.Type type);
            /*0x7927d8c*/ InvalidKeyException(object key, System.Type type, UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x7927e30*/ InvalidKeyException(object key, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode);
            /*0x7927ef8*/ InvalidKeyException(object key, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode, UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x7927fdc*/ InvalidKeyException();
            /*0x7928034*/ InvalidKeyException(string message);
            /*0x792809c*/ InvalidKeyException(string message, System.Exception innerException);
            /*0x792810c*/ InvalidKeyException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
            /*0x7927c88*/ object get_Key();
            /*0x7927c90*/ void set_Key(object value);
            /*0x7927c98*/ System.Type get_Type();
            /*0x7927ca0*/ void set_Type(System.Type value);
            /*0x7927ca8*/ System.Nullable<UnityEngine.AddressableAssets.Addressables.MergeMode> get_MergeMode();
            /*0x792818c*/ string FormatMessage(UnityEngine.AddressableAssets.InvalidKeyException.Format format, string foundWithTypeString);
            /*0x792898c*/ string FormatMergeModeMessage(UnityEngine.AddressableAssets.InvalidKeyException.Format format, string keysAvailable, string keysUnavailable, string typeString);
            /*0x7928e6c*/ string get_Message();
            /*0x7929518*/ string GetMessageForSingleKey(string keyString);
            /*0x792ad50*/ string FormatNotFoundMessage(string keyString);
            /*0x792ad5c*/ string FormatTypeNotAssignableMessage(string keyString, System.Collections.Generic.HashSet<System.Type> typesAvailableForKey);
            /*0x792af00*/ string FormatMultipleAssignableTypesMessage(string keyString, System.Collections.Generic.HashSet<System.Type> typesAvailableForKey);
            /*0x7929990*/ string GetMessageforMergeKeys(System.Collections.Generic.List<string> keys);
            /*0x792a638*/ System.Collections.Generic.HashSet<System.Type> GetTypesForKey(string keyString);
            /*0x792b114*/ bool GetTypeToKeys(string key, System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<string>> typeToKeys);
            /*0x7928d84*/ string GetKeyString();

            enum Format
            {
                StandardMessage = 0,
                NoMergeMode = 1,
                MultipleTypesRequested = 2,
                NoLocation = 3,
                TypeMismatch = 4,
                MultipleTypeMismatch = 5,
                MergeModeBase = 6,
                UnionAvailableForKeys = 7,
                UnionAvailableForKeysWithoutOther = 8,
                IntersectionAvailable = 9,
                KeyAvailableAsType = 10,
            }
        }

        class Addressables
        {
            static string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";
            static string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";
            static string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";
            static /*0x0*/ bool reinitializeAddressables;
            static /*0x8*/ UnityEngine.AddressableAssets.AddressablesImpl m_AddressablesInstance;
            static /*0x10*/ string LibraryPath;
            static /*0x18*/ string BuildReportPath;

            static /*0x7933890*/ Addressables();
            static /*0x792b538*/ UnityEngine.AddressableAssets.AddressablesImpl get_m_Addressables();
            static /*0x792b590*/ string get_Version();
            static /*0x792b5d0*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
            static /*0x792b664*/ UnityEngine.AddressableAssets.AddressablesImpl get_Instance();
            static /*0x792b6ec*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider get_InstanceProvider();
            static /*0x792b780*/ string ResolveInternalId(string id);
            static /*0x792b86c*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            static /*0x792b924*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            static /*0x792b9e4*/ System.Action<UnityEngine.Networking.UnityWebRequest> get_WebRequestOverride();
            static /*0x792ba9c*/ void set_WebRequestOverride(System.Action<UnityEngine.Networking.UnityWebRequest> value);
            static /*0x792bb5c*/ string get_StreamingAssetsSubFolder();
            static /*0x792bc58*/ string get_BuildPath();
            static /*0x792bdc4*/ string get_PlayerBuildDataPath();
            static /*0x792bf00*/ string get_RuntimePath();
            static /*0x792bf94*/ System.Collections.Generic.IEnumerable<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_ResourceLocators();
            static /*0x792c024*/ void InternalSafeSerializationLog(string msg, UnityEngine.LogType logType);
            static /*0x792c240*/ void InternalSafeSerializationLogFormat(string format, UnityEngine.LogType logType, object[] args);
            static /*0x792c49c*/ void Log(string msg);
            static /*0x792c534*/ void LogFormat(string format, object[] args);
            static /*0x7926d0c*/ void LogWarning(string msg);
            static /*0x792c5dc*/ void LogWarningFormat(string format, object[] args);
            static /*0x7926da4*/ void LogError(string msg);
            static /*0x792c684*/ void LogException(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
            static /*0x792c7f4*/ void LogException(System.Exception ex);
            static /*0x7927660*/ void LogErrorFormat(string format, object[] args);
            static /*0x792c888*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync();
            static /*0x792c9cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(bool autoReleaseHandle);
            static /*0x792cb24*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix);
            static /*0x792cdfc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key);
            static /*0x792ced4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            static /*0x792d138*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(object key, System.Type type);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(string key, System.Action<TObject> callback);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(string key, bool releaseDependenciesOnFailure, System.Action<TObject> callback);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback);
            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            static /*0x3907c14*/ void Release<TObject>(TObject obj);
            static /*0x3907c14*/ void Release<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            static /*0x792d384*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            static /*0x792d38c*/ bool ReleaseInstance(UnityEngine.GameObject instance);
            static /*0x792d510*/ bool ReleaseInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            static /*0x792d528*/ bool ReleaseInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> handle);
            static /*0x792d578*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
            static /*0x792d708*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(string key);
            static /*0x792d7c8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.IEnumerable keys);
            static /*0x792e834*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);
            static /*0x792eb48*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            static /*0x792ed50*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            static /*0x792f08c*/ void ClearDependencyCacheAsync(object key);
            static /*0x792f388*/ void ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            static /*0x792f938*/ void ClearDependencyCacheAsync(System.Collections.IEnumerable keys);
            static /*0x792fef8*/ void ClearDependencyCacheAsync(string key);
            static /*0x792ffa4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle);
            static /*0x7930070*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            static /*0x793013c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.IEnumerable keys, bool autoReleaseHandle);
            static /*0x7930208*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle);
            static /*0x79302d4*/ UnityEngine.AddressableAssets.ResourceLocatorInfo GetLocatorInfo(string locatorId);
            static /*0x793055c*/ UnityEngine.AddressableAssets.ResourceLocatorInfo GetLocatorInfo(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
            static /*0x7930668*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x79308b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x7930a6c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x7930be0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x7930d9c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x79312cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x79313c8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode);
            static /*0x7931720*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x793182c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
            static /*0x7931918*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7931a0c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            static /*0x7931c28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7931d34*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
            static /*0x7931e20*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7931f14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            static /*0x7932218*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            static /*0x793246c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, bool autoReleaseHandle);
            static /*0x7932548*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, bool autoReleaseHandle);
            static /*0x7932638*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            static /*0x79327fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdates(bool autoReleaseHandle);
            static /*0x7932a14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(System.Collections.Generic.IEnumerable<string> catalogs, bool autoReleaseHandle);
            static /*0x7932d3c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, System.Collections.Generic.IEnumerable<string> catalogs, bool autoReleaseHandle);
            static /*0x7932e14*/ void AddResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, string localCatalogHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            static /*0x7932fc0*/ void RemoveResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
            static /*0x793313c*/ void ClearResourceLocators();
            static /*0x793323c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCache(System.Collections.Generic.IEnumerable<string> catalogsIds);
            static /*0x382eaf0*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath);
            static /*0x382eaf0*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            static /*0x3830700*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath);

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
            /*0x20*/ int m_CatalogRequestsTimeout;
            /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider SceneProvider;
            /*0x30*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> m_ResourceLocators;
            /*0x38*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> m_InitializationOperation;
            /*0x50*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> m_ActiveCheckUpdateOperation;
            /*0x68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> m_ActiveUpdateOperation;
            /*0x80*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_OnHandleCompleteAction;
            /*0x88*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_OnSceneHandleCompleteAction;
            /*0x90*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_OnHandleDestroyedAction;
            /*0x98*/ System.Collections.Generic.Dictionary<object, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_resultToHandle;
            /*0xa0*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> m_SceneInstances;
            /*0xa8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> m_ActiveCleanBundleCacheOperation;
            /*0xc0*/ bool hasStartedInitialization;

            static /*0x7936f8c*/ void WrapAsDownloadLocations(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            static /*0x793707c*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> GatherDependenciesFromLocations(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x79339ac*/ AddressablesImpl(UnityEngine.ResourceManagement.Util.IAllocationStrategy alloc);
            /*0x7933b98*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider get_InstanceProvider();
            /*0x7933ba0*/ void set_InstanceProvider(UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider value);
            /*0x7933c34*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
            /*0x7933c3c*/ int get_CatalogRequestsTimeout();
            /*0x7933c44*/ void set_CatalogRequestsTimeout(int value);
            /*0x7933c4c*/ int get_ActiveSceneInstances();
            /*0x7933c94*/ int get_TrackedHandleCount();
            /*0x7933ce4*/ void ReleaseSceneManagerOperation();
            /*0x792b908*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            /*0x792b9c8*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            /*0x792ba80*/ System.Action<UnityEngine.Networking.UnityWebRequest> get_WebRequestOverride();
            /*0x792bb40*/ void set_WebRequestOverride(System.Action<UnityEngine.Networking.UnityWebRequest> value);
            /*0x7933d88*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_ChainOperation();
            /*0x7933f40*/ bool get_ShouldChainRequest();
            /*0x7934020*/ void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            /*0x792bc18*/ string get_StreamingAssetsSubFolder();
            /*0x792bce8*/ string get_BuildPath();
            /*0x792be54*/ string get_PlayerBuildDataPath();
            /*0x792bf90*/ string get_RuntimePath();
            /*0x792c1e8*/ void Log(string msg);
            /*0x792c434*/ void LogFormat(string format, object[] args);
            /*0x792c138*/ void LogWarning(string msg);
            /*0x792c364*/ void LogWarningFormat(string format, object[] args);
            /*0x792c190*/ void LogError(string msg);
            /*0x792c758*/ void LogException(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
            /*0x792c884*/ void LogException(System.Exception ex);
            /*0x792c3cc*/ void LogErrorFormat(string format, object[] args);
            /*0x792b818*/ string ResolveInternalId(string id);
            /*0x792b43c*/ System.Collections.Generic.IEnumerable<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_ResourceLocators();
            /*0x7932ec4*/ void AddResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc, string localCatalogHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            /*0x7933058*/ void RemoveResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc);
            /*0x79331cc*/ void ClearResourceLocators();
            /*0x793456c*/ bool GetResourceLocations(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x7934d30*/ bool GetResourceLocations(System.Collections.IEnumerable keys, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode merge, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x7935244*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle);
            /*0x792c93c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync();
            /*0x792ca8c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(bool autoReleaseHandle);
            /*0x380bb68*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLocation);
            /*0x380bb68*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation);
            /*0x380bcbc*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath);
            /*0x79356c0*/ void QueueEditorUpdateIfNeeded();
            /*0x792cbf4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix);
            /*0x79356cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> TrackHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> TrackHandle<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x7935788*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle TrackHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x79357c4*/ void ClearTrackHandles();
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key);
            /*0x7935814*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            /*0x792cfac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            /*0x7935a28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, System.Type type);
            /*0x792d204*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(object key, System.Type type);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x7935c24*/ void OnHandleDestroyed(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x7935cac*/ void OnSceneHandleCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x7935db4*/ void OnHandleCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3907c14*/ void Release<TObject>(TObject obj);
            /*0x3907c14*/ void Release<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x7935e74*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x7935ec0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
            /*0x7936010*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> ComputeCatalogSizeWithChain(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc);
            /*0x79363f4*/ bool IsCatalogCached(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc, UnityEngine.Hash128 remoteHash);
            /*0x7936824*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc);
            /*0x7936c80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys);
            /*0x792d638*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
            /*0x792d888*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.IEnumerable keys);
            /*0x7936dd0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, bool autoReleaseHandle);
            /*0x792e900*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);
            /*0x793795c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x792ec14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x7937b18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            /*0x792ee28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            /*0x7937cdc*/ bool ClearDependencyCacheForKey(object key);
            /*0x3907c14*/ void AutoReleaseHandleOnTypelessCompletion<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x792f138*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle);
            /*0x792f434*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x792f9e4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.IEnumerable keys, bool autoReleaseHandle);
            /*0x7938490*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            /*0x79309e4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            /*0x7930b50*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            /*0x7930d14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            /*0x7938520*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x7930e98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x79386cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x793077c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x792d424*/ bool ReleaseInstance(UnityEngine.GameObject instance);
            /*0x7938878*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            /*0x7938a1c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            /*0x79314d4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority, bool trackHandle);
            /*0x7931b10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority, bool trackHandle);
            /*0x7931ff8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7932314*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7932728*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7938bc0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> CreateUnloadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7938d10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> CreateUnloadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7938e60*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> InternalUnloadScene(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7934c54*/ object EvaluateKey(object obj);
            /*0x79328bc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdates(bool autoReleaseHandle);
            /*0x7938f3c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle);
            /*0x793036c*/ UnityEngine.AddressableAssets.ResourceLocatorInfo GetLocatorInfo(string c);
            /*0x7939728*/ System.Collections.Generic.IEnumerable<string> get_CatalogsWithAvailableUpdates();
            /*0x7932ae4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(System.Collections.Generic.IEnumerable<string> catalogIds, bool autoReleaseHandle, bool autoCleanBundleCache);
            /*0x793a08c*/ bool Equals(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation x, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation y);
            /*0x793a36c*/ int GetHashCode(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x7933300*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCache(System.Collections.Generic.IEnumerable<string> catalogIds, bool forceSingleThreading);
            /*0x793a5e8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCache(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool forceSingleThreading);
            /*0x793a798*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCacheWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool forceSingleThreading);
            /*0x793a49c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCacheWithChain(System.Collections.Generic.IEnumerable<string> catalogIds, bool forceSingleThreading);
            /*0x793aae0*/ void <TrackHandle>b__73_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneHandle);
            /*0x793ab9c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetRemoteCatalogHeaderSize>b__102_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Networking.UnityWebRequest> getOp);

            class LoadResourceLocationKeyOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>
            {
                /*0x98*/ object m_Keys;
                /*0xa0*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_locations;
                /*0xa8*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xb0*/ System.Type m_ResourceType;

                /*0x7935b94*/ LoadResourceLocationKeyOp();
                /*0x793acbc*/ string get_DebugName();
                /*0x7935bdc*/ void Init(UnityEngine.AddressableAssets.AddressablesImpl aa, System.Type t, object keys);
                /*0x793acdc*/ bool InvokeWaitForCompletion();
                /*0x793ad50*/ void Execute();
            }

            class LoadResourceLocationKeysOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>
            {
                /*0x98*/ System.Collections.IEnumerable m_Key;
                /*0xa0*/ UnityEngine.AddressableAssets.Addressables.MergeMode m_MergeMode;
                /*0xa8*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_locations;
                /*0xb0*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xb8*/ System.Type m_ResourceType;

                /*0x7935988*/ LoadResourceLocationKeysOp();
                /*0x793ae30*/ string get_DebugName();
                /*0x79359d0*/ void Init(UnityEngine.AddressableAssets.AddressablesImpl aa, System.Type t, System.Collections.IEnumerable key, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode);
                /*0x793ae70*/ void Execute();
                /*0x793af54*/ bool InvokeWaitForCompletion();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <>9__59_0;
                static /*0x10*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, bool> <>9__143_0;
                static /*0x18*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, string> <>9__143_1;
                static /*0x20*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, string> <>9__147_0;

                static /*0x793afc8*/ <>c();
                /*0x793b030*/ <>c();
                /*0x793b038*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator <get_ResourceLocators>b__59_0(UnityEngine.AddressableAssets.ResourceLocatorInfo l);
                /*0x793b050*/ bool <get_CatalogsWithAvailableUpdates>b__143_0(UnityEngine.AddressableAssets.ResourceLocatorInfo s);
                /*0x793b068*/ string <get_CatalogsWithAvailableUpdates>b__143_1(UnityEngine.AddressableAssets.ResourceLocatorInfo s);
                /*0x793b10c*/ string <CleanBundleCache>b__147_0(UnityEngine.AddressableAssets.ResourceLocatorInfo s);
            }

            class <>c__115<TObject>
            {
                static /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl.<>c__115<TObject> <>9;
                static /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> <>9__115_0;

                static /*0x38358cc*/ <>c__115();
                /*0x380cb08*/ <>c__115();
                void <AutoReleaseHandleOnTypelessCompletion>b__115_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass100_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc;

                /*0x79363ec*/ <>c__DisplayClass100_0();
                /*0x793b1b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <ComputeCatalogSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass103_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;

                /*0x7936dc8*/ <>c__DisplayClass103_0();
                /*0x793b3ac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass106_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;

                /*0x7936f84*/ <>c__DisplayClass106_0();
                /*0x793b3f0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass110_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;

                /*0x7937b10*/ <>c__DisplayClass110_0();
                /*0x793b480*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass112_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;

                /*0x7937cd4*/ <>c__DisplayClass112_0();
                /*0x793b510*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass116_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ bool autoReleaseHandle;

                /*0x7938478*/ <>c__DisplayClass116_0();
                /*0x793b5a4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass117_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;
                /*0x20*/ bool autoReleaseHandle;

                /*0x7938480*/ <>c__DisplayClass117_0();
                /*0x793b5ec*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass118_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ bool autoReleaseHandle;

                /*0x7938488*/ <>c__DisplayClass118_0();
                /*0x793b634*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass123_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters;

                /*0x79386c4*/ <>c__DisplayClass123_0();
                /*0x793b67c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> <InstantiateWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass125_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters;

                /*0x7938870*/ <>c__DisplayClass125_0();
                /*0x793b6e8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> <InstantiateWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass128_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode;
                /*0x2c*/ bool activateOnLoad;
                /*0x30*/ int priority;

                /*0x7938a14*/ <>c__DisplayClass128_0();
                /*0x793b754*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <LoadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass129_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation key;
                /*0x20*/ UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode;
                /*0x2c*/ bool activateOnLoad;
                /*0x30*/ int priority;

                /*0x7938bb8*/ <>c__DisplayClass129_0();
                /*0x793b7a8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <LoadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass135_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions;
                /*0x1c*/ bool autoReleaseHandle;

                /*0x7938f2c*/ <>c__DisplayClass135_0();
                /*0x793b7fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <CreateUnloadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle completedHandle);
            }

            class <>c__DisplayClass136_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions;
                /*0x1c*/ bool autoReleaseHandle;

                /*0x7938f34*/ <>c__DisplayClass136_0();
                /*0x793b8b8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <CreateUnloadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> completedHandle);
            }

            class <>c__DisplayClass140_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;

                /*0x7939720*/ <>c__DisplayClass140_0();
                /*0x793b924*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> <CheckForCatalogUpdatesWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass144_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;
                /*0x19*/ bool autoCleanBundleCache;

                /*0x79398e4*/ <>c__DisplayClass144_0();
                /*0x793b968*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> <UpdateCatalogs>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> depOp);
            }

            class <>c__DisplayClass149_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp;
                /*0x30*/ bool forceSingleThreading;

                /*0x793aad0*/ <>c__DisplayClass149_0();
                /*0x793b9c8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass150_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IEnumerable<string> catalogIds;
                /*0x20*/ bool forceSingleThreading;

                /*0x793aad8*/ <>c__DisplayClass150_0();
                /*0x793ba30*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc;

                /*0x7934564*/ <>c__DisplayClass61_0();
                /*0x793ba78*/ bool <RemoveResourceLocator>b__0(UnityEngine.AddressableAssets.ResourceLocatorInfo l);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ string catalogPath;
                /*0x20*/ bool autoReleaseHandle;
                /*0x28*/ string providerSuffix;

                /*0x79356c4*/ <>c__DisplayClass72_0();
                /*0x793ba9c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <LoadContentCatalogAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass78_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc;

                /*0x380cb08*/ <>c__DisplayClass78_0();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass79_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ object key;

                /*0x380cb08*/ <>c__DisplayClass79_0();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass83_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;
                /*0x28*/ System.Type type;

                /*0x7935980*/ <>c__DisplayClass83_0();
                /*0x793bae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <LoadResourceLocationsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass85_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ System.Type type;

                /*0x7935b8c*/ <>c__DisplayClass85_0();
                /*0x793bb34*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <LoadResourceLocationsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass88_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x380cb08*/ <>c__DisplayClass88_0();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass89_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ System.Collections.IEnumerable keys;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x380cb08*/ <>c__DisplayClass89_0();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass91_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ object key;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x380cb08*/ <>c__DisplayClass91_0();
                /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op2);
            }

            class <>c__DisplayClass99_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;

                /*0x7936008*/ <>c__DisplayClass99_0();
                /*0x793bb78*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }
        }

        class AssetLabelReference : UnityEngine.AddressableAssets.IKeyEvaluator
        {
            /*0x10*/ string m_LabelString;

            /*0x793bc88*/ AssetLabelReference();
            /*0x793bbbc*/ string get_labelString();
            /*0x793bbc4*/ void set_labelString(string value);
            /*0x793bbcc*/ object get_RuntimeKey();
            /*0x793bc08*/ bool RuntimeKeyIsValid();
            /*0x793bc68*/ int GetHashCode();
        }

        class AssetReferenceT<TObject> : UnityEngine.AddressableAssets.AssetReference
        {
            /*0x380d83c*/ AssetReferenceT(string guid);
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync();
            /*0x380b2f0*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x380b2f0*/ bool ValidateAsset(string mainAssetPath);
        }

        class AssetReferenceGameObject : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.GameObject>
        {
            /*0x793bc90*/ AssetReferenceGameObject(string guid);
        }

        class AssetReferenceTexture : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture>
        {
            /*0x793bce8*/ AssetReferenceTexture(string guid);
        }

        class AssetReferenceTexture2D : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture2D>
        {
            /*0x793bd40*/ AssetReferenceTexture2D(string guid);
        }

        class AssetReferenceTexture3D : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture3D>
        {
            /*0x793bd98*/ AssetReferenceTexture3D(string guid);
        }

        class AssetReferenceSprite : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Sprite>
        {
            /*0x793bdf0*/ AssetReferenceSprite(string guid);
            /*0x793be48*/ bool ValidateAsset(string path);
        }

        class AssetReferenceAtlasedSprite : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Sprite>
        {
            /*0x793be50*/ AssetReferenceAtlasedSprite(string guid);
            /*0x793bea8*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x793bf20*/ bool ValidateAsset(string path);
        }

        class AssetReference : UnityEngine.AddressableAssets.IKeyEvaluator
        {
            /*0x10*/ string m_AssetGUID;
            /*0x18*/ string m_SubObjectName;
            /*0x20*/ string m_SubObjectType;
            /*0x28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle m_Operation;

            static /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<T> CreateFailedOperation<T>();
            /*0x793c0c4*/ AssetReference();
            /*0x793c11c*/ AssetReference(string guid);
            /*0x793bf28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OperationHandle();
            /*0x793bf3c*/ void set_OperationHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle value);
            /*0x793bf5c*/ object get_RuntimeKey();
            /*0x793bff4*/ string get_AssetGUID();
            /*0x793bffc*/ string get_SubObjectName();
            /*0x793c004*/ void set_SubObjectName(string value);
            /*0x793c00c*/ System.Type get_SubObjectType();
            /*0x793c0ac*/ bool IsValid();
            /*0x793c0b8*/ bool get_IsDone();
            /*0x793c194*/ UnityEngine.Object get_Asset();
            /*0x793c234*/ string ToString();
            /*0x3907c14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>();
            /*0x793c2a0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            /*0x793c420*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnLoadScene();
            /*0x793c4c4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            /*0x793c5c0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.Transform parent, bool instantiateInWorldSpace);
            /*0x793c670*/ bool RuntimeKeyIsValid();
            /*0x793c6f0*/ void ReleaseAsset();
            /*0x793c790*/ void ReleaseInstance(UnityEngine.GameObject obj);
            /*0x793c7e4*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x793c7ec*/ bool ValidateAsset(string path);
        }

        interface IKeyEvaluator
        {
            /*0x380b9e8*/ object get_RuntimeKey();
            /*0x380b128*/ bool RuntimeKeyIsValid();
        }

        class CheckCatalogsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.List<string>>
        {
            /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0xa0*/ System.Collections.Generic.List<string> m_LocalHashes;
            /*0xa8*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> m_LocatorInfos;
            /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;

            static /*0x793caa0*/ System.Collections.Generic.List<string> ProcessDependentOpResults(System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> results, System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> locatorInfos, System.Collections.Generic.List<string> localHashes, ref string errorString, ref bool success);
            /*0x7939074*/ CheckCatalogsOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
            /*0x79390d8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> Start(System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> locatorInfos);
            /*0x793c7f4*/ bool InvokeWaitForCompletion();
            /*0x793c928*/ void Destroy();
            /*0x793c970*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x793d0ec*/ void Execute();

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.CheckCatalogsOperation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__5_0;

                static /*0x793d18c*/ <>c();
                /*0x793d1f4*/ <>c();
                /*0x793d1fc*/ bool <Start>b__5_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
            }
        }

        class CleanBundleCacheOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>, UnityEngine.ResourceManagement.IUpdateReceiver
        {
            /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0xa0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
            /*0xb8*/ System.Collections.Generic.List<string> m_CacheDirsForRemoval;
            /*0xc0*/ System.Threading.Thread m_EnumerationThread;
            /*0xc8*/ string m_BaseCachePath;
            /*0xd0*/ bool m_UseMultiThreading;

            /*0x793a8f0*/ CleanBundleCacheOperation(UnityEngine.AddressableAssets.AddressablesImpl aa, bool forceSingleThreading);
            /*0x793a9a4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> Start(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
            /*0x793d28c*/ void CompleteInternal(bool result, bool success, string errorMsg);
            /*0x793d31c*/ bool InvokeWaitForCompletion();
            /*0x793d580*/ void Destroy();
            /*0x793d5fc*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x793d72c*/ void Execute();
            /*0x793e500*/ void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime);
            /*0x793d3ec*/ void RemoveCacheEntries();
            /*0x793e55c*/ void DetermineCacheDirsNotInUse(object data);
            /*0x793e0d8*/ void DetermineCacheDirsNotInUse(System.Collections.Generic.HashSet<string> cacheDirsInUse);
            /*0x793d904*/ System.Collections.Generic.HashSet<string> GetCacheDirsInUse(System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> catalogOps);
        }

        class UpdateCatalogsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>>
        {
            /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0xa0*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> m_LocatorInfos;
            /*0xa8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
            /*0xc0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> m_CleanCacheOp;
            /*0xd8*/ bool m_AutoCleanBundleCache;

            /*0x79398ec*/ UpdateCatalogsOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
            /*0x7939950*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> Start(System.Collections.Generic.IEnumerable<string> catalogIds, bool autoCleanBundleCache);
            /*0x793e678*/ bool InvokeWaitForCompletion();
            /*0x793e824*/ void Destroy();
            /*0x793e86c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x793e99c*/ void Execute();
            /*0x793f050*/ void OnCleanCacheCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> handle, System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> catalogs);

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.UpdateCatalogsOperation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__6_0;

                static /*0x793f150*/ <>c();
                /*0x793f1b8*/ <>c();
                /*0x793f1c0*/ bool <Start>b__6_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.UpdateCatalogsOperation <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> catalogs;

                /*0x793f148*/ <>c__DisplayClass11_0();
                /*0x793f250*/ void <OnCleanCacheCompleted>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> obj);
            }
        }

        class DynamicResourceLocator : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
        {
            /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0x18*/ string m_AtlasSpriteProviderId;

            /*0x793f8e8*/ DynamicResourceLocator(UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x793f3cc*/ string get_LocatorId();
            /*0x793f40c*/ System.Collections.Generic.IEnumerable<object> get_Keys();
            /*0x793f450*/ string get_AtlasSpriteProviderId();
            /*0x793f8a4*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
            /*0x793f918*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x793fe74*/ void CreateDynamicLocations(System.Type type, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, string locName, string subKey, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation mainLoc);
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

            static /*0x7940700*/ PlatformMappingService();
            static /*0x7940504*/ UnityEngine.AddressableAssets.AddressablesPlatform GetAddressablesPlatformInternal(UnityEngine.RuntimePlatform platform);
            static /*0x79405d8*/ string GetAddressablesPlatformPathInternal(UnityEngine.RuntimePlatform platform);
            static /*0x7934434*/ string GetPlatformPathSubFolder();
            /*0x79406f8*/ PlatformMappingService();
        }

        namespace Utility
        {
            class AssetReferenceUtilities
            {
                static /*0x79408d8*/ string FormatName(string name);
                /*0x794096c*/ AssetReferenceUtilities();
            }

            class SerializationUtilities
            {
                static /*0x7940974*/ int ReadInt32FromByteArray(byte[] data, int offset);
                static /*0x79409e8*/ int WriteInt32ToByteArray(byte[] data, int val, int offset);
                static /*0x7940a6c*/ object ReadObjectFromByteArray(byte[] keyData, int dataIndex);
                static /*0x7940f50*/ int WriteObjectToByteList(object obj, System.Collections.Generic.List<byte> buffer);

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

                /*0x7941964*/ ContentCatalogProvider(UnityEngine.ResourceManagement.ResourceManager resourceManagerInstance);
                /*0x79419f8*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object obj);
                /*0x7941b04*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);

                enum DependencyHashIndex
                {
                    Remote = 0,
                    Cache = 1,
                    Local = 2,
                    Count = 3,
                }

                class InternalOp
                {
                    static string kCatalogExt = ".bin";
                    /*0x10*/ string m_LocalDataPath;
                    /*0x18*/ string m_RemoteHashValue;
                    /*0x20*/ string m_LocalHashValue;
                    /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle m_ProviderInterface;
                    /*0x40*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData m_ContentCatalogData;
                    /*0x48*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> m_ContentCatalogDataLoadOp;
                    /*0x60*/ UnityEngine.AddressableAssets.ResourceProviders.ContentCatalogProvider.InternalOp.BundledCatalog m_BundledCatalog;
                    /*0x68*/ bool m_Retried;
                    /*0x69*/ bool m_DisableCatalogUpdateOnStart;
                    /*0x6a*/ bool m_IsLocalCatalogInBundle;

                    /*0x7941c5c*/ InternalOp();
                    /*0x7941c64*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle);
                    /*0x7942f2c*/ bool WaitForCompletionCallback();
                    /*0x7941acc*/ void Release();
                    /*0x79427fc*/ bool CanLoadCatalogFromBundle(string idToLoad, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                    /*0x79428c0*/ void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle);
                    /*0x7943668*/ void CatalogLoadOpCompleteCallback(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> op);
                    /*0x7943100*/ string GetTransformedInternalId(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
                    /*0x7941e00*/ string DetermineIdToLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Collections.Generic.IList<object> dependencyObjects, bool disableCatalogUpdateOnStart);
                    /*0x79436fc*/ void OnCatalogLoaded(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
                    /*0x7944060*/ void <LoadCatalog>b__14_0(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);

                    class BundledCatalog
                    {
                        /*0x10*/ string m_BundlePath;
                        /*0x18*/ bool m_OpInProgress;
                        /*0x20*/ UnityEngine.AssetBundleCreateRequest m_LoadBundleRequest;
                        /*0x28*/ UnityEngine.AssetBundle m_CatalogAssetBundle;
                        /*0x30*/ UnityEngine.AssetBundleRequest m_LoadTextAssetRequest;
                        /*0x38*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData m_CatalogData;
                        /*0x40*/ UnityEngine.ResourceManagement.WebRequestQueueOperation m_WebRequestQueueOperation;
                        /*0x48*/ UnityEngine.AsyncOperation m_RequestOperation;
                        /*0x50*/ int m_WebRequestTimeout;
                        /*0x58*/ System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> OnLoaded;

                        /*0x79431bc*/ BundledCatalog(string bundlePath, int webRequestTimeout);
                        /*0x79432ec*/ void add_OnLoaded(System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> value);
                        /*0x794408c*/ void remove_OnLoaded(System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> value);
                        /*0x794413c*/ bool get_OpInProgress();
                        /*0x7944144*/ bool get_OpIsSuccess();
                        /*0x7944164*/ void Finalize();
                        /*0x79441f8*/ void Unload();
                        /*0x794339c*/ void LoadCatalogFromBundleAsync();
                        /*0x7944228*/ void WebRequestOperationCompleted(UnityEngine.AsyncOperation op);
                        /*0x7944460*/ void LoadTextAssetRequestComplete(UnityEngine.AsyncOperation op);
                        /*0x7942ff4*/ bool WaitForCompletion();
                        /*0x79445f8*/ void <LoadCatalogFromBundleAsync>b__19_1(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOp);
                        /*0x79446a0*/ void <LoadCatalogFromBundleAsync>b__19_0(UnityEngine.AsyncOperation loadOp);
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

                /*0x79448fc*/ ContentCatalogDataEntry(System.Type type, string internalId, string provider, System.Collections.Generic.IEnumerable<object> keys, System.Collections.Generic.IEnumerable<object> dependencies, object extraData);
                /*0x794489c*/ string get_InternalId();
                /*0x79448a4*/ void set_InternalId(string value);
                /*0x79448ac*/ string get_Provider();
                /*0x79448b4*/ void set_Provider(string value);
                /*0x79448bc*/ System.Collections.Generic.List<object> get_Keys();
                /*0x79448c4*/ void set_Keys(System.Collections.Generic.List<object> value);
                /*0x79448cc*/ System.Collections.Generic.List<object> get_Dependencies();
                /*0x79448d4*/ void set_Dependencies(System.Collections.Generic.List<object> value);
                /*0x79448dc*/ object get_Data();
                /*0x79448e4*/ void set_Data(object value);
                /*0x79448ec*/ System.Type get_ResourceType();
                /*0x79448f4*/ void set_ResourceType(System.Type value);
            }

            class ContentCatalogData
            {
                static int kVersion = 2;
                static /*0x0*/ int kMagic;
                /*0x10*/ string LocalHash;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;
                /*0x20*/ string m_LocatorId;
                /*0x28*/ string m_BuildResultHash;
                /*0x30*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData m_InstanceProviderData;
                /*0x60*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData m_SceneProviderData;
                /*0x90*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> m_ResourceProviderData;
                /*0x98*/ System.Collections.Generic.IList<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogDataEntry> m_Entries;
                /*0xa0*/ UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader m_Reader;

                static /*0x7945028*/ ContentCatalogData();
                static /*0x7944ed4*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData LoadFromFile(string path, int cacheSize);
                /*0x7944ae4*/ ContentCatalogData(string id);
                /*0x7944b80*/ ContentCatalogData();
                /*0x7944c30*/ ContentCatalogData(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader);
                /*0x7944a4c*/ string get_BuildResultHash();
                /*0x7944a54*/ void set_BuildResultHash(string value);
                /*0x7944a5c*/ string get_ProviderId();
                /*0x7944a64*/ void set_ProviderId(string value);
                /*0x7944a6c*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData get_InstanceProviderData();
                /*0x7944a80*/ void set_InstanceProviderData(UnityEngine.ResourceManagement.Util.ObjectInitializationData value);
                /*0x7944aa0*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData get_SceneProviderData();
                /*0x7944ab4*/ void set_SceneProviderData(UnityEngine.ResourceManagement.Util.ObjectInitializationData value);
                /*0x7944ad4*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> get_ResourceProviderData();
                /*0x7944adc*/ void set_ResourceProviderData(System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> value);
                /*0x79430d8*/ void CleanData();
                /*0x7944c08*/ void CopyToFile(string path);
                /*0x7944044*/ byte[] GetBytes();
                /*0x793e5e0*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator CreateCustomLocator(string overrideId, string providerSuffix, int locatorCacheSize);

                class Serializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                    /*0x7945020*/ Serializer();
                    /*0x794509c*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x7945228*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                    /*0x79454f8*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ uint[] locationIds;
                        /*0x18*/ System.Func<int, uint> <>9__0;

                        /*0x7945fb8*/ <>c__DisplayClass3_0();
                        /*0x7945fc8*/ uint <Serialize>b__0(int i);
                    }
                }

                class ResourceLocator : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
                {
                    /*0x10*/ UnityEngine.ResourceManagement.Util.LRUCache<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.CacheKey, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> m_Cache;
                    /*0x28*/ System.Collections.Generic.Dictionary<object, uint> keyData;
                    /*0x30*/ UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader;
                    /*0x38*/ string <LocatorId>k__BackingField;
                    /*0x40*/ string providerSuffix;

                    /*0x7944ccc*/ ResourceLocator(string id, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, int cacheLimit, string providerSuffix);
                    /*0x7945ff8*/ string get_LocatorId();
                    /*0x7946000*/ void set_LocatorId(string value);
                    /*0x7946008*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                    /*0x7946058*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
                    /*0x794651c*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);

                    struct Header
                    {
                        /*0x10*/ int magic;
                        /*0x14*/ int version;
                        /*0x18*/ uint keysOffset;
                        /*0x1c*/ uint idOffset;
                        /*0x20*/ uint instanceProvider;
                        /*0x24*/ uint sceneProvider;
                        /*0x28*/ uint initObjectsArray;
                        /*0x2c*/ uint buildResultHash;
                    }

                    struct KeyData
                    {
                        /*0x10*/ uint keyNameOffset;
                        /*0x14*/ uint locationSetOffset;
                    }

                    class ContentCatalogDataEntrySerializationContext
                    {
                        /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogDataEntry entry;
                        /*0x18*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.List<int>> keyToEntryIndices;
                        /*0x20*/ System.Collections.Generic.IList<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogDataEntry> allEntries;

                        /*0x7945fc0*/ ContentCatalogDataEntrySerializationContext();
                    }

                    class ResourceLocation : UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation
                    {
                        /*0x10*/ string <PrimaryKey>k__BackingField;
                        /*0x18*/ string <InternalId>k__BackingField;
                        /*0x20*/ object <Data>k__BackingField;
                        /*0x28*/ string <ProviderId>k__BackingField;
                        /*0x30*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <Dependencies>k__BackingField;
                        /*0x38*/ int <DependencyHashCode>k__BackingField;
                        /*0x40*/ System.Type <ResourceType>k__BackingField;

                        /*0x7946a9c*/ ResourceLocation(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader r, uint id);
                        /*0x7946c80*/ string ToString();
                        /*0x7946c88*/ void set_PrimaryKey(string value);
                        /*0x7946c90*/ string get_PrimaryKey();
                        /*0x7946c98*/ void set_InternalId(string value);
                        /*0x7946ca0*/ string get_InternalId();
                        /*0x7946ca8*/ void set_Data(object value);
                        /*0x7946cb0*/ object get_Data();
                        /*0x7946cb8*/ void set_ProviderId(string value);
                        /*0x7946cc0*/ string get_ProviderId();
                        /*0x7946cc8*/ void set_Dependencies(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> value);
                        /*0x7946cd0*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                        /*0x7946cd8*/ void set_DependencyHashCode(int value);
                        /*0x7946ce0*/ int get_DependencyHashCode();
                        /*0x7946ce8*/ bool get_HasDependencies();
                        /*0x7946cf8*/ void set_ResourceType(System.Type value);
                        /*0x7946d00*/ System.Type get_ResourceType();
                        /*0x7946d08*/ int Hash(System.Type t);

                        class Serializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.ResourceLocation>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.ContentCatalogDataEntrySerializationContext>
                        {
                            /*0x7945220*/ Serializer();
                            /*0x7946d70*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                            /*0x7946d78*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                            /*0x7946de0*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

                            struct Data
                            {
                                /*0x10*/ uint primaryKeyOffset;
                                /*0x14*/ uint internalIdOffset;
                                /*0x18*/ uint providerOffset;
                                /*0x1c*/ uint dependencySetOffset;
                                /*0x20*/ int dependencyHashValue;
                                /*0x24*/ uint extraDataOffset;
                                /*0x28*/ uint typeId;
                            }
                        }
                    }

                    struct CacheKey : System.IEquatable<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.CacheKey>
                    {
                        /*0x10*/ object key;
                        /*0x18*/ System.Type type;
                        /*0x20*/ int hashCode;

                        /*0x79469e4*/ CacheKey(object o, System.Type t);
                        /*0x79473ec*/ bool Equals(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.CacheKey other);
                        /*0x79474bc*/ int GetHashCode();
                    }
                }

                class AssetBundleRequestOptionsSerializationAdapter : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                    /*0x7945218*/ AssetBundleRequestOptionsSerializationAdapter();
                    /*0x79474c4*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x79474cc*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type type, uint offset);
                    /*0x7947710*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object obj);

                    struct SerializedData
                    {
                        /*0x10*/ uint hashId;
                        /*0x14*/ uint bundleNameId;
                        /*0x18*/ uint crc;
                        /*0x1c*/ uint bundleSize;
                        /*0x20*/ uint commonId;

                        struct Common
                        {
                            /*0x10*/ short timeout;
                            /*0x12*/ byte redirectLimit;
                            /*0x13*/ byte retryCount;
                            /*0x14*/ int flags;

                            /*0x79476d4*/ UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode get_assetLoadMode();
                            /*0x79478f8*/ void set_assetLoadMode(UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode value);
                            /*0x79476e0*/ bool get_chunkedTransfer();
                            /*0x794790c*/ void set_chunkedTransfer(bool value);
                            /*0x79476f8*/ bool get_useCrcForCachedBundle();
                            /*0x794794c*/ void set_useCrcForCachedBundle(bool value);
                            /*0x79476ec*/ bool get_useUnityWebRequestForLocalBundles();
                            /*0x794796c*/ void set_useUnityWebRequestForLocalBundles(bool value);
                            /*0x7947704*/ bool get_clearOtherCachedVersionsWhenLoaded();
                            /*0x794792c*/ void set_clearOtherCachedVersionsWhenLoaded(bool value);
                        }
                    }
                }
            }

            interface IResourceLocator
            {
                /*0x380b9e8*/ string get_LocatorId();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
                bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            }

            class ResourceLocationData
            {
                /*0x10*/ string[] m_Keys;
                /*0x18*/ string m_InternalId;
                /*0x20*/ string m_Provider;
                /*0x28*/ string[] m_Dependencies;
                /*0x30*/ UnityEngine.ResourceManagement.Util.SerializedType m_ResourceType;
                /*0x50*/ byte[] SerializedData;
                /*0x58*/ object _Data;

                /*0x7947ac0*/ ResourceLocationData(string[] keys, string id, System.Type provider, System.Type t, string[] dependencies);
                /*0x794798c*/ string[] get_Keys();
                /*0x7947994*/ string get_InternalId();
                /*0x794799c*/ string get_Provider();
                /*0x79479a4*/ string[] get_Dependencies();
                /*0x79479ac*/ System.Type get_ResourceType();
                /*0x79479b8*/ object get_Data();
                /*0x7947a0c*/ void set_Data(object value);
            }

            class ResourceLocationMap : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
            {
                /*0x10*/ string <LocatorId>k__BackingField;
                /*0x18*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> locations;

                /*0x7947c28*/ ResourceLocationMap(string id, int capacity);
                /*0x7947cf0*/ ResourceLocationMap(string id, System.Collections.Generic.IList<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> locations);
                /*0x7947ce0*/ string get_LocatorId();
                /*0x7947ce8*/ void set_LocatorId(string value);
                /*0x7948820*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
                /*0x794891c*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> get_Locations();
                /*0x7948924*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                /*0x7948974*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                /*0x79486c0*/ void Add(object key, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x7949208*/ void Add(object key, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);

                class <>c
                {
                    static /*0x0*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap.<> <>9;
                    static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>, System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <>9__8_0;

                    static /*0x7949270*/ <>c();
                    /*0x79492d8*/ <>c();
                    /*0x79492e0*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <get_AllLocations>b__8_0(System.Collections.Generic.KeyValuePair<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> k);
                }
            }
        }

        namespace Initialization
        {
            class AddressablesRuntimeProperties
            {
                static /*0x0*/ System.Collections.Generic.Stack<string> s_TokenStack;
                static /*0x8*/ System.Collections.Generic.Stack<int> s_TokenStartStack;
                static /*0x10*/ bool s_StaticStacksAreInUse;
                static /*0x18*/ System.Collections.Generic.Dictionary<string, string> s_CachedValues;

                static /*0x7949e64*/ AddressablesRuntimeProperties();
                static /*0x794931c*/ System.Reflection.Assembly[] GetAssemblies();
                static /*0x794933c*/ int GetCachedValueCount();
                static /*0x79493b4*/ void SetPropertyValue(string name, string val);
                static /*0x7949444*/ void ClearCachedPropertyValues();
                static /*0x79494bc*/ string EvaluateProperty(string name);
                static /*0x79344b8*/ string EvaluateString(string input);
                static /*0x79498dc*/ string EvaluateString(string inputString, char startDelimiter, char endDelimiter, System.Func<string, string> varFunc);
            }

            class CacheInitialization : UnityEngine.ResourceManagement.Util.IInitializableObject
            {
                static /*0x794a2fc*/ string get_RootPath();
                /*0x794a378*/ CacheInitialization();
                /*0x7949fc0*/ bool Initialize(string id, string dataStr);
                /*0x794a114*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);

                class CacheInitOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>, UnityEngine.ResourceManagement.IUpdateReceiver
                {
                    /*0x98*/ System.Func<bool> m_Callback;
                    /*0xa0*/ bool m_UpdateRequired;

                    /*0x794a2ac*/ CacheInitOp();
                    /*0x794a380*/ void Init(System.Func<bool> callback);
                    /*0x794a388*/ bool InvokeWaitForCompletion();
                    /*0x794a41c*/ void Update(float unscaledDeltaTime);
                    /*0x794a4d8*/ void Execute();
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.Initialization.CacheInitialization <>4__this;
                    /*0x18*/ string id;
                    /*0x20*/ string data;

                    /*0x794a2a4*/ <>c__DisplayClass1_0();
                    /*0x794a570*/ bool <InitializeAsync>b__0();
                }
            }

            class CacheInitializationData
            {
                /*0x10*/ bool m_CompressionEnabled;
                /*0x18*/ string m_CacheDirectoryOverride;
                /*0x20*/ bool m_LimitCacheSize;
                /*0x28*/ long m_MaximumCacheSize;

                /*0x794a5dc*/ CacheInitializationData();
                /*0x794a594*/ bool get_CompressionEnabled();
                /*0x794a59c*/ void set_CompressionEnabled(bool value);
                /*0x794a5a8*/ string get_CacheDirectoryOverride();
                /*0x794a5b0*/ void set_CacheDirectoryOverride(string value);
                /*0x794a5b8*/ bool get_LimitCacheSize();
                /*0x794a5c0*/ void set_LimitCacheSize(bool value);
                /*0x794a5cc*/ long get_MaximumCacheSize();
                /*0x794a5d4*/ void set_MaximumCacheSize(long value);
            }

            class InitializationOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>
            {
                /*0x98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> m_rtdOp;
                /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> m_loadCatalogOp;
                /*0xc8*/ string m_ProviderSuffix;
                /*0xd0*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xd8*/ UnityEngine.ResourceManagement.AsyncOperations.InitalizationObjectsOperation m_InitGroupOps;

                static /*0x794a768*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> CreateInitializationOperation(UnityEngine.AddressableAssets.AddressablesImpl aa, string playerSettingsLocation, string providerSuffix);
                static /*0x794be38*/ void LoadProvider(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.Util.ObjectInitializationData providerData, string providerSuffix);
                static /*0x794c2c4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> OnCatalogDataLoaded(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> op, string providerSuffix, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                static /*0x794c864*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc, string providerSuffix, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                /*0x794a644*/ InitializationOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
                /*0x794a6a8*/ float get_Progress();
                /*0x794a728*/ string get_DebugName();
                /*0x794ad14*/ bool InvokeWaitForCompletion();
                /*0x794aee0*/ void Execute();
                /*0x794cf4c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc, string providerSuffix, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                /*0x794bbfc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogInternal(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs, int index, UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                /*0x794cf88*/ void LoadOpComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> op, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs, UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap, int index, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);

                class <>c
                {
                    static /*0x0*/ UnityEngine.AddressableAssets.Initialization.InitializationOperation.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__12_0;

                    static /*0x794d31c*/ <>c();
                    /*0x794d384*/ <>c();
                    /*0x794d38c*/ bool <Execute>b__12_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl addressables;
                    /*0x18*/ string providerSuffix;
                    /*0x20*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation;

                    /*0x794cf44*/ <>c__DisplayClass15_0();
                    /*0x794d41c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <LoadContentCatalog>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> res);
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.Initialization.InitializationOperation <>4__this;
                    /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs;
                    /*0x20*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap;
                    /*0x28*/ int index;
                    /*0x30*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation;

                    /*0x794cf80*/ <>c__DisplayClass17_0();
                    /*0x794d46c*/ void <LoadContentCatalogInternal>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> op);
                }
            }

            class ResourceManagerRuntimeData
            {
                static string kCatalogAddress = "AddressablesMainContentCatalog";
                /*0x10*/ string m_buildTarget;
                /*0x18*/ string m_SettingsHash;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> m_CatalogLocations;
                /*0x28*/ bool m_LogResourceManagerExceptions;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> m_ExtraInitializationData;
                /*0x38*/ bool m_DisableCatalogUpdateOnStart;
                /*0x39*/ bool m_IsLocalCatalogInBundle;
                /*0x40*/ UnityEngine.ResourceManagement.Util.SerializedType m_CertificateHandlerType;
                /*0x60*/ string m_AddressablesVersion;
                /*0x68*/ int m_maxConcurrentWebRequests;
                /*0x6c*/ int m_CatalogRequestsTimeout;

                /*0x794d594*/ ResourceManagerRuntimeData();
                /*0x794d4c4*/ string get_BuildTarget();
                /*0x794d4cc*/ void set_BuildTarget(string value);
                /*0x794d4d4*/ string get_SettingsHash();
                /*0x794d4dc*/ void set_SettingsHash(string value);
                /*0x794d4e4*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> get_CatalogLocations();
                /*0x794d4ec*/ bool get_LogResourceManagerExceptions();
                /*0x794d4f4*/ void set_LogResourceManagerExceptions(bool value);
                /*0x794d500*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> get_InitializationObjects();
                /*0x794d508*/ bool get_DisableCatalogUpdateOnStartup();
                /*0x794d510*/ void set_DisableCatalogUpdateOnStartup(bool value);
                /*0x794d51c*/ bool get_IsLocalCatalogInBundle();
                /*0x794d524*/ void set_IsLocalCatalogInBundle(bool value);
                /*0x794bbf0*/ System.Type get_CertificateHandlerType();
                /*0x794d530*/ void set_CertificateHandlerType(System.Type value);
                /*0x794d53c*/ string get_AddressablesVersion();
                /*0x794d544*/ void set_AddressablesVersion(string value);
                /*0x794d54c*/ int get_MaxConcurrentWebRequests();
                /*0x794d554*/ void set_MaxConcurrentWebRequests(int value);
                /*0x794d570*/ int get_CatalogRequestsTimeout();
                /*0x794d578*/ void set_CatalogRequestsTimeout(int value);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 458AB22B3684F1C36211775C2A8AECC9A231A16EBBB277E19CD4C1048962A0A5;
    static /*0xa39*/ <PrivateImplementationDetails> 75D4F0C35183C8248EF2A15F6575E5C8539CC8008D8A5BBD3A08E1B426708201;

    struct __StaticArrayInitTypeSize=2617
    {
    }

    struct __StaticArrayInitTypeSize=3932
    {
    }
}
